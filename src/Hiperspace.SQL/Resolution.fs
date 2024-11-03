module internal Hiperspace.SQL.Resolution

open Hiperspace
open System
open Hiperspace.SQL.Ast
open System.Reflection

let references (space : SubSpace) =

    let sets = 
        space.GetType().GetProperties()
        |> Array.map        (fun i -> i.Name, i.GetValue(space))
        |> Array.choose     (fun (n,i) -> match i with | :? ISetSpace -> Some (n, i :?> ISetSpace) | _ -> None)
        |> Array.filter     (fun (n,i) -> i <> null)

    let members (setType : Type) =
        setType.GetProperties(BindingFlags.Public ||| BindingFlags.Instance)
        |> Array.map        (fun i -> i.Name, i)
        |> Map.ofArray

    let subjectType (t : Type) =
        let head = Array.head (t.BaseType.GetGenericArguments())
        head

    let relations =
        sets
        |> Array.map        (fun (n,t) -> n, (t, (members (subjectType (t.GetType())))))
        |> Array.map        (fun (n,(t, m)) -> n, { Name = n; Set = t; Subject = subjectType (t.GetType());  Columns = m})

    let columns =
        relations
        |> Array.map        (fun (set, relation) -> relation.Columns |> Map.fold (fun a name property -> (name, (relation, property)) :: a) [])
        |> Array.fold       (fun a i -> i @ a) []
        |> List.groupBy     (fun (n, (s, t)) -> n)
        |> List.map         (fun (n, l) -> n, l |> List.map (fun (n, (s, t)) -> s, t))
        |> Map.ofList

    let dba_relations = 
      [
        { Name = "SCHEMA_TABLES"; Cols = ["TABLE_NAME"; "TABLE_TYPE"] |> Set.ofList}
        { Name = "SCHEMA_COLUMNS"; Cols = ["TABLE_NAME"; "COLUMN_NAME"; "COLUMN_TYPE"] |> Set.ofList}
        { Name = "SCHEMA_PROPERTIES"; Cols = ["TYPE_NAME"; "PROPERTY_NAME"; "PROPERTY_TYPE"] |> Set.ofList}
      ]
      |> List.map (fun i -> i.Name, i)
      |> Map.ofList

    { 
      Relations = Map.ofArray relations
      Columns = columns
      Dba = dba_relations
    }

let rec parameters (expr : Expr) =
    match expr with
    | Mul (a, b)    
    | Div (a, b)    
    | Add (a, b)    
    | Sub (a, b)            -> parameters a @ parameters b
    | Avg a         
    | Sum a         
    | Count a       
    | Max a         
    | Min a                 -> parameters a 
    | Param (s, t)          -> [s,t]
    | _                     -> []

and ``bool parameters`` (boolExpr : BoolExpr) =
    match boolExpr with
    | Less (a, b)           
    | Greater (a, b)        
    | GreaterEqual (a, b)   
    | LessEqual (a, b)      
    | Equal (a, b)          
    | Like (a, b)
    | NotEqual (a, b)       -> parameters a @ parameters b
    | And (a, b)            
    | Or (a, b)             -> ``bool parameters`` a @ ``bool parameters`` b
    | Not a                 -> ``bool parameters`` a
    | IsNull a              
    | IsNotNull a           -> parameters a 
    | In (a, b)             -> parameters a @ List.collect parameters b
    | InSelect (a, b)       -> []
    | Exists a              
    | NotExists a           -> []
    | Between (a, b, c)     -> parameters a @ parameters b @ parameters c

/// References to tables
type Refs = Map<string, Table>

let matches (column : string list) (reference : string list) =
    let rec loop prefix list =
        match prefix, list with
        | [], _ -> true
        | _, [] -> false
        | p::ps, l::ls when p = l -> loop ps ls
        | _ -> false
    loop column reference

let resolve (schema : Schema) (result : Result) =

    let empty : Refs = Map.ofList []

    let ``expresion Name`` (expression : Expr) =
        match expression with
        | Ref r -> Some (List.last r.Name)
//!        | Ref r -> Some (r.Name |> String.concat "_")
        | _     -> None

    let ``resolve Table`` (tables : Refs) (table : Table) =
        match (schema.Relations.TryFind table.Name), table.Alias with
        | Some r , Some a   -> { table with Set = Some r.Set; Subject = Some r.Subject }
        | Some r , None     -> { table with Set = Some r.Set; Alias = Some table.Name}
        | None , None       -> { table with Alias = Some table.Name}
        | None , Some a     -> table 

    let rec ``resolve Column`` (tables : Refs) (column : Column) =
        match column.Alias, ``expresion Name`` column.Expression with
        | Some a, _ -> { column with Expression = ``resolve Expression`` tables column.Expression}
        | None  , n -> { column with Expression = ``resolve Expression`` tables column.Expression; Alias = n}

    and ``resolve From`` (tables : Refs) (from : From) =
        match from with
        | Table t           -> let i = ``resolve Table`` tables t
                               Table i, tables.Add (i.Alias.Value, i)
        | Join (a, b, c)    -> let (l, tables) = ``resolve From`` tables a
                               let (r, tables) = ``resolve From`` tables b
                               let e = ``resolve Boolean`` tables c
                               Join  (l, r, e), tables
        | Product (a, b)    -> let (l, tables) = ``resolve From`` tables a
                               let (r, tables) = ``resolve From`` tables b
                               Product (l, r), tables
        | SubQuery (s, n)   -> let s = ``resolve Select`` s
                               let asTable = { Name = n; Alias = Some n; Set = None; Subject = None;  SubQuery = Some s; Position = s.Position}
                               SubQuery (s,n), tables.Add (n, asTable)

    and ``resolve Grouping`` (tables : Refs) (grouping : Grouping) =
        { grouping with 
            Columns = List.map (``resolve Column`` tables) grouping.Columns
            Having = Option.map (fun i -> ``resolve Boolean`` tables i) grouping.Having
        }

    and ``expand Columns`` (tables : Map<string,Table>) (columns : Column list) =
        // Expand "select * from table" to "select c1,c2,c3.. from table"
        let ``expand Table`` (table : Table) =
            if schema.Relations.ContainsKey table.Name then
                schema.Relations[table.Name].Columns
                |> Map.toList
                |> List.map (fun (k, v) -> [table.Alias.Value ;k], v)
                |> List.map (fun (i,p)  -> { Alias = None; Position = table.Position; Expression = Ref { Name = i; Table = [table]; Property = [p]; Target = None; Position = table.Position }})
            elif
                schema.Dba.ContainsKey table.Name then
                schema.Dba[table.Name].Cols
                |> Set.toList
                |> List.map (fun s      -> { Alias = None; Position = table.Position; Expression = Ref { Name = [table.Alias.Value; s]; Table = [table]; Property = []; Target = None; Position = table.Position }})
            else
                []
        // Expand "select table.* from table" to "select table.c1, table.c2, table.c3.. from table"
        let ``expand Column`` (column : Column) : Column list =
            match column.Expression with
            | Ref r -> match r.Name with | t :: ["*"] -> ``expand Table`` tables[t] | _ -> [column]
            | _ -> [column]
        match columns with
        | [] -> tables 
                |> Map.toList
                |> List.map (fun (k, v) -> ``expand Table`` v)
                |> List.concat
        | _  -> columns 
                |> List.map ``expand Column``
                |> List.concat

    and ``resolve Select`` (select : Select) =
        let (from, tables)  = ``resolve From`` empty select.From
        let columns         = (``expand Columns`` tables select.Columns) |> List.map (``resolve Column`` tables)
        let where           = Option.map (fun i -> ``resolve Boolean`` tables i) select.Where
        let groupBy         = match select.GroupBy with | Some group -> Some (``resolve Grouping`` tables group) | None -> None
        let orderBy         = select.OrderBy |> List.map (``resolve Column`` tables)
        { select with 
            Columns = columns 
            From = from 
            Where = where 
            GroupBy = groupBy 
            OrderBy = orderBy
        }

    /// recursively resolve the property type
    and ``resolve PropertyType`` (names : string list) (current : PropertyInfo) =
        let name = names.Head
        let property = 
            current.PropertyType.GetProperties(BindingFlags.Public ||| BindingFlags.Instance)
            |> Array.tryFind (fun i -> i.Name = name)
        match names.Tail, property with
        | [], Some p    -> Some [p]
        | [], None      -> None
        | tail, Some p  -> match ``resolve PropertyType`` tail p with
                           | Some tp -> Some (p :: tp)
                           | None    -> None
        | _, _          -> None

    and ``resolve Name`` (tables : Refs) (ref : Name) =
        let alias = ref.Name.Head
        if tables.ContainsKey alias then
            let table = tables[alias]
            if schema.Dba.ContainsKey(table.Name) then
                { ref with Table = [table] }
            else
                let name = ref.Name.Tail.Head
                if schema.Relations.ContainsKey table.Name then
                    let columns = schema.Relations[table.Name].Columns
                    let (propertyName, property) = 
                        columns
                        |> Map.filter   (fun s p -> s = name)
                        |> Seq.tryHead
                        |> function | Some kv -> Some kv.Key, kv.Value | None -> None, null
                    // e.g. Child.Parent.Name
                    if ref.Name.Tail.Tail <> [] then
                        match ``resolve PropertyType`` ref.Name.Tail.Tail property with
                        | Some properties -> { ref with Table = [table]; Property = property :: properties}
                        | None            -> ref
                
                    elif propertyName.IsSome then 
                        { ref with Table = [table]; Property = [property]}
                    else
                        { ref with Table = [table]}
                else
                    { ref with Table = [table]}
        elif schema.Columns.ContainsKey alias then
            let tablenames =
                tables
                |> Seq.map      ( fun kv -> kv.Value.Name, kv.Value)
                |> Map.ofSeq
            let relations = 
                schema.Columns[alias]
                |> List.filter  (fun (relation, _)  -> tablenames.ContainsKey relation.Name)
                |> List.map     (fun (relation, _)  -> tablenames[relation.Name])
            let properties =
                schema.Columns[alias]
                |> List.filter  (fun (relation, _)  -> tablenames.ContainsKey relation.Name)
                |> List.map (fun (_, property)      -> property)
            if relations = [] then
                ref                                                     // Error will be highlighted later
            elif relations.Tail = [] then
                { ref with Table = relations; Property = properties; Name = relations.Head.Alias.Value :: ref.Name }   
            elif ref.Name.Tail = [] then
                { ref with Table = relations; Property = properties}   // Duplicates will be validated later
            else
               let property = properties.Head
               match ``resolve PropertyType`` ref.Name.Tail.Tail property with
               | Some properties -> { ref with Table = relations; Property = property :: properties}
               | None            -> ref
        else
            ref

    and ``resolve Parameter`` (left : Expr, right : Expr) =
        match left, right with
        | Param (s, t), _ when t.IsNone -> (Param (s, right.ExpressionType), right)
        | _, Param (s, t) when t.IsNone -> (left, Param (s, left.ExpressionType))
        | _ -> (left, right)
    and ``resolve Parameter Between`` (left : Expr, lower : Expr, upper : Expr) =
        match left, lower, upper with
        | Param (s, t), _, _ when t.IsNone -> match lower.ExpressionType , upper.ExpressionType with
                                              | Some l, _ -> (Param (s, Some l), lower, upper)
                                              | _, Some r -> (Param (s, Some r), lower, upper)
                                              | _ -> (left, lower, upper)     
        | _, Param (s, t), _ when t.IsNone -> match left.ExpressionType, upper.ExpressionType with
                                              | Some l, _ -> (left, Param (s, Some l), upper)
                                              | _, Some r -> (left, Param (s, Some r), upper)
                                              | _ -> (left, lower, upper)     
        | _, _, Param (s, t) when t.IsNone -> match left.ExpressionType, lower.ExpressionType with
                                              | Some l, _ -> (left, lower, Param (s, Some l))
                                              | _, Some r -> (left, lower, Param (s, Some r))
                                              | _ -> (left, lower, upper)     
        | _ -> (left, lower, upper)

    and ``resolve Expression`` (tables : Refs) (expression : Expr) =
        match expression with
        | Mul (a, b)            -> Mul (``resolve Parameter`` (``resolve Expression`` tables a, ``resolve Expression`` tables b))
        | Div (a, b)            -> Div (``resolve Parameter`` (``resolve Expression`` tables a, ``resolve Expression`` tables b))
        | Add (a, b)            -> Add (``resolve Parameter`` (``resolve Expression`` tables a, ``resolve Expression`` tables b))
        | Sub (a, b)            -> Sub (``resolve Parameter`` (``resolve Expression`` tables a, ``resolve Expression`` tables b))
        | Avg a                 -> Avg (``resolve Expression`` tables a)
        | Sum a                 -> Sum (``resolve Expression`` tables a)
        | Count a               -> Count (``resolve Expression`` tables a)
        | CountStar             -> CountStar
        | Param (s, t)          -> Param (s, t)
        | Max a                 -> Max (``resolve Expression`` tables a)
        | Min a                 -> Min (``resolve Expression`` tables a)
        | Lit l                 -> Lit l
        | Ref r                 -> Ref (``resolve Name`` tables r) 
        | Int i                 -> Int i
        | Dec d                 -> Dec d
        | Num n                 -> Num n
        | Str s                 -> Str s
        | Date d                -> Date d
        | Bool b                -> Bool b
        | Boolean b             -> Boolean (``resolve Boolean`` tables b)
        | Concat (a, b)         -> Sub (``resolve Parameter`` (``resolve Expression`` tables a, ``resolve Expression`` tables b))

    and ``resolve Boolean`` (tables : Refs) (boolean : BoolExpr) =
        match boolean with
        | And (a, b)            -> And ((``resolve Boolean`` tables a), (``resolve Boolean`` tables  b))
        | Or (a, b)             -> Or (``resolve Boolean`` tables a, ``resolve Boolean`` tables b)
        | Not a                 -> Not (``resolve Boolean`` tables a)
        | Less (a, b)           -> Less (``resolve Parameter`` (``resolve Expression`` tables a, ``resolve Expression`` tables b))
        | Greater (a, b)        -> Greater (``resolve Parameter`` (``resolve Expression`` tables a, ``resolve Expression`` tables b))
        | GreaterEqual (a, b)   -> GreaterEqual (``resolve Parameter`` (``resolve Expression`` tables a, ``resolve Expression`` tables b))
        | LessEqual (a, b)      -> LessEqual (``resolve Parameter`` (``resolve Expression`` tables a, ``resolve Expression`` tables b))
        | Equal (a, b)          -> match  (``resolve Expression`` tables a), (``resolve Expression`` tables b) with
                                   // when a the expression is a join condition 
                                   | Ref l, Ref r when r.Property = [] && r.Table <> [] && r.Table.Head.SubQuery.IsSome
                                            -> Equal (``resolve Parameter`` (Ref l, Ref {r with Property = l.Property}))
                                   | l, r   -> Equal (``resolve Parameter`` (l, r))
        | NotEqual (a, b)       -> NotEqual (``resolve Parameter`` (``resolve Expression`` tables a, ``resolve Expression`` tables b))
        | Like (a, b)           -> Like (``resolve Parameter`` (``resolve Expression`` tables a, ``resolve Expression`` tables b))
        | IsNull a              -> IsNull (``resolve Expression`` tables a)
        | IsNotNull a           -> IsNotNull (``resolve Expression`` tables a)
        | Exists s              -> Exists (``resolve Select`` s)
        | NotExists s           -> NotExists (``resolve Select`` s)
        | In (a, b)             -> In (``resolve Expression`` tables a, List.map (``resolve Expression`` tables) b)
        | InSelect (a, s)       -> InSelect (``resolve Expression`` tables a, ``resolve Select`` s)
        | Between (a, b, c)     -> Between (``resolve Parameter Between`` (``resolve Expression`` tables a, ``resolve Expression`` tables b, ``resolve Expression`` tables c))

    and unpack (statement : Statement) =
        match statement with
        | Select s              -> [s]
        | Union (s, t)          -> unpack t
        | ValidUnion s          -> s

    and ``resolve Statement`` (statement : Statement) =
        match statement with
        | Select s              -> Select (``resolve Select`` s)
        | Union (s, t)          -> ValidUnion (``resolve Select`` s :: (``resolve Statement`` t |> unpack))
        | ValidUnion s          -> ValidUnion (List.map ``resolve Select`` s)

    result.Statements 
    |> List.map ``resolve Statement``
    |> Result.Create
