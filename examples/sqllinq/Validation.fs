module internal SQLLinq.Validation

open SQLLinq.Ast
open SQLLinq.Resolution

let dot (sl : string list) = sl |> String.concat "."
let error (message : string) (pos : Position) = (message, pos)

let validate (result : Result)  =

    let nopos = {sl=0;sc=0;el=0;ec=0}
    let addpos pos (list : (string * Position) list) =
        list 
        |> List.map (fun (s, p) -> if p = nopos then (s, pos) else (s, p))

    let delim (list : string list) (delim : string) =
        list
        |> List.fold (fun a i -> if a = "" then i else a + delim + i) ""

    let ``validate Table`` (table : Table) =
        match table.Set, table.SubQuery, table.Alias with
        | Some set, _, Some a                   -> []
        | _, Some select, Some a                -> []
        | _, _, None                            -> [error $"Table {table.Name} does not have an alias" table.Position]
        | _, _, _                               -> [error $"Table {table.Name} not found" table.Position]

    let rec ``validate Column`` (column : Column) =
        let expression = ``validate Expression`` column.Expression |> (addpos column.Position)
        match column.Alias with
        | Some a            -> expression
        | None              -> [error $"Column {column.Expression} must have an alias" column.Position] @ expression

    and ``from Alias`` (from : From) =
        match from with
        | Table t           -> [t.Alias]
        | Join (a, b, c)    -> ``from Alias`` a
        | Product (a, b)    -> ``from Alias`` a
        | SubQuery (s, n)   -> [Some n]

    and ``validate From`` (from : From) =
        match from with
        | Table t           -> ``validate Table`` t
        | Join (a, b, c)    -> (if c.IsAJoin() then [] else [error  $"Join {c} is not an equijoin, and is not supported" from.Position]) @
                               ``validate From`` a @
                               ``validate From`` b @
                               ``validate Boolean`` c |> (addpos from.Position)
        | Product (a, b)    -> ``validate From`` a @
                               ``validate From`` b 
        | SubQuery (s, n)   -> ``validate Select`` s

    and ``validate Grouping`` (group : Grouping) =
        let columns = 
            group.Columns 
            |> List.map     (fun c -> ``validate Column`` c)
            |> List.concat

        let groupable = 
            group.Columns
            |> List.choose  (fun c -> match c.Expression with | Ref r -> None | _ -> Some c)
            |> List.map     (fun c -> error $"Join {c} is not not valid for group by" c.Position)

        let having =
            match group.Having with
            | Some b -> ``validate Boolean`` b
            | None   -> []

        columns @ having @ groupable

    and ``is Aggregate`` (expression : Expr) =
        match expression with
        | Avg a                 -> true
        | Sum a                 -> true
        | Count a               -> true
        | Max a                 -> true
        | Min a                 -> true
        | Mul (a,b)             -> match ``is Aggregate`` a, ``is Aggregate`` b with
                                   | true,  _  
                                   | _, true      -> true
                                   | false, false -> false
        | Div (a,b)             -> match ``is Aggregate`` a, ``is Aggregate`` b with
                                   | true,  _  
                                   | _, true      -> true
                                   | false, false -> false
        | Add (a,b)             -> match ``is Aggregate`` a, ``is Aggregate`` b with
                                   | true,  _  
                                   | _, true      -> true
                                   | false, false -> false
        | Sub (a,b)             -> match ``is Aggregate`` a, ``is Aggregate`` b with
                                   | true,  _  
                                   | _, true      -> true
                                   | false, false -> false
        | _                     -> false

    and ``is Aggregate bool`` (expr : BoolExpr) = 
        match expr with
        | And (a, b)            -> ``is Aggregate bool`` a || ``is Aggregate bool`` b
        | Or (a, b)             -> ``is Aggregate bool`` a || ``is Aggregate bool`` b
        | Not a                 -> ``is Aggregate bool`` a
        | Less (a, b)           -> ``is Aggregate`` a || ``is Aggregate`` b
        | Greater (a, b)        -> ``is Aggregate`` a || ``is Aggregate`` b
        | GreaterEqual (a, b)   -> ``is Aggregate`` a || ``is Aggregate`` b
        | LessEqual (a, b)      -> ``is Aggregate`` a || ``is Aggregate`` b
        | Equal (a, b)          -> ``is Aggregate`` a || ``is Aggregate`` b
        | NotEqual (a, b)       -> ``is Aggregate`` a || ``is Aggregate`` b
        | Like (a, b)           -> ``is Aggregate`` a || ``is Aggregate`` b
        | IsNull a              -> ``is Aggregate`` a
        | IsNotNull a           -> false
        | Exists s              -> false
        | NotExists s           -> false
        | In (a, b)             -> false
        | InSelect (a, s)       -> false
        | Between (a, b, c)     -> ``is Aggregate`` a || ``is Aggregate`` b || ``is Aggregate`` c
    
    and ``validate Select`` (select : Select) =
        let from            = ``validate From`` select.From
        let columns         = select.Columns    |> List.fold (fun a i -> (``validate Column`` i) @ a) []
        let where           = match select.Where with | Some i -> ``validate Boolean`` i | None -> []
        let groupBy         = match select.GroupBy with Some i -> ``validate Grouping`` i | None -> []
        let orderBy         = select.OrderBy    |> List.fold (fun a i -> (``validate Column`` i) @ a) [] 

        let whereAggregate  =
            match select.Where with
            | Some w    -> ``is Aggregate bool`` w
                           |> function
                           | true  -> [error $"Can not use aggregate in WHERE clause" select.Position]
                           | false -> []
            | None      -> []

        let aggregateColumns =
            match select.GroupBy with
            | None      -> Set.ofList []
            | Some c    ->  select.Columns @ c.Columns @ select.OrderBy
                            |> List.choose      (fun i -> match ``is Aggregate`` i.Expression with | true -> Some i.Alias.Value | _ -> None)
                            |> List.distinct
                            |> Set.ofList

        let groupAggregates =
            match select.GroupBy with
            | None      -> []
            | Some c    -> c.Columns
                           |> List.filter      (fun c -> aggregateColumns.Contains c.Alias.Value)
                           |> List.map         (fun c -> error $"Can not group by aggregate column {c.Alias.Value}" c.Position)

        let nonGroupColumns : (string * Position) list=
            match select.GroupBy with
            | None      -> []
            | Some cols -> select.Columns
                           |> List.choose  (fun c -> match aggregateColumns.Contains c.Alias.Value with | true -> Some c | _ -> None)
                           |> List.filter  (fun c -> match cols.Columns |> List.tryFind (fun i -> c.Alias = c.Alias) with
                                                     | Some v -> false
                                                     | None   -> true)
                           |> List.map     (fun c -> error $"Column {c.Alias.Value} is not part of GROUP BY" c.Position)

        let amgiguousColumn =
            select.Columns
            |> List.groupBy     (fun i -> i.Alias)
            |> List.filter      (fun (i, l) -> l.Length > 1)
            |> List.map         (fun (i, l) -> error $"Column {i.Value} is ambiguous" (List.last l).Position)

        let amgiguousGroup =
            match select.GroupBy with
            | None      -> []
            | Some cols -> cols.Columns
                           |> List.groupBy     (fun i -> i.Alias)
                           |> List.filter      (fun (i, l) -> l.Length > 1)
                           |> List.map         (fun (i, l) -> error $"Column {i.Value} is ambiguous" (List.last l).Position)

        let amgiguousOrder =
            select.OrderBy
            |> List.groupBy     (fun i -> i.Alias)
            |> List.filter      (fun (i, l) -> l.Length > 1)
            |> List.map         (fun (i, l) -> error $"Column {i.Value} is ambiguous" (List.last l).Position)

        let parameters = 
            let comma l = l |> String.concat ", "
            let typeNames (l : (string * System.Type option) list) =
                l
                |> List.choose  (fun (_, t) -> t)
                |> List.distinct
                |> List.map     (fun t -> t.FullName)
            let whereParameters = match select.Where with | Some w -> ``bool parameters`` w | None   -> []
            let groupParameters = match select.GroupBy with | Some g -> (match g.Having with | Some h -> ``bool parameters`` h | _ -> []) | _ -> []
            let colParameters   = select.Columns |> List.map (fun c -> parameters c.Expression) |> List.concat
            whereParameters @ groupParameters @ colParameters 
            |> List.groupBy     (fun (s,_) -> s)
            |> List.map         (fun (s,t) -> s, t |> typeNames)
            |> List.filter      (fun (_,t) -> t.Length > 1)
            |> List.map         (fun (s,t) -> error $"Parameter {s} has ambiguous type: {comma t}" nopos)

        let ambiguousAlias = 
            let rec aliasFrom (from : From) = 
                match from with
                | Table t           -> [t.Alias.Value, t.Position]
                | Join (a, b, c)    -> aliasFrom a @ aliasFrom b
                | Product (a, b)    -> aliasFrom a @ aliasFrom b
                | SubQuery (s, n)   -> [n, s.Position]

            and aliasBool (boolean : BoolExpr) =
                match boolean with
                | And (a, b)            -> aliasBool a @ aliasBool b
                | Or (a, b)             -> aliasBool a @ aliasBool b
                | Not a                 -> aliasBool a
                | Exists s              -> aliasSelect s
                | NotExists s           -> aliasSelect s
                | InSelect (a, s)       -> aliasSelect s
                | _                     -> []

            and aliasSelect (select : Select) =
                let from = aliasFrom select.From
                let where = match select.Where with | Some i -> aliasBool i | None -> []
                let groupBy = match select.GroupBy with Some i -> (match i.Having with | Some h -> aliasBool h | None -> []) | None -> []

                from @ where @ groupBy 

            aliasSelect select
            |> List.groupBy (fun (s, _) -> s)
            |> List.filter  (fun (s, l) -> l.Length > 1)
            |> List.map     (fun (s, l) -> l)
            |> List.concat
            |> List.map     (fun (s, p) -> error $"Alias {s} is duplicate" p)

        from @ 
        columns @ 
        where @ 
        groupBy @ 
        orderBy @ 
        amgiguousColumn @ 
        amgiguousGroup @ 
        amgiguousOrder @ 
        groupAggregates @ 
        nonGroupColumns @ 
        parameters @ 
        ambiguousAlias @
        whereAggregate

    and ``validate Name`` (ref : Name) =
        let table = 
            match ref.Table with
            | []            -> [error $"Name {dot ref.Name} can not be resolved to a table" ref.Position]
            | t :: []       -> []
            | t :: ts       -> [error $"Name {dot ref.Name} is ambiguous (could be {ref.Table |> List.map (fun t -> t.Name) |> delim})" ref.Position]
        let property = 
            match ref.Property with
            | [] when (ref.Table <> [] && ref.Table.Head.Name.StartsWith("SCHEMA_")) -> []
            | []            -> table @ [error $"Name {ref.Name} can not be resolved to a property" ref.Position]
            | p             -> match p.Head.PropertyType with
                                | null  -> table @ [error $"Name {dot ref.Name}, property does not have a type" ref.Position]
                                | p     -> []
        let unsupportedproperty = 
            if ref.Property <> [] then
                ref.Property
                |> List.filter  (fun p -> p.PropertyType.Name.Contains("ValueTuple") || p.PropertyType = typeof<obj>)
                |> List.map     (fun p -> error $"Property {p.Name} type {p.PropertyType.Name} is not supported" ref.Position)
            else
                []
        table @ property @ unsupportedproperty

    and ``Is Param`` (expr : Expr) =
        match expr with
        | Param _ -> true
        | _       -> false

    and ``validate Expression`` (expression : Expr) =
        match expression with
        | Mul (a, b)            -> let inner = ``validate Expression`` a @ ``validate Expression`` b
                                   let l = a.ExpressionType
                                   let r = b.ExpressionType
                                   match ``Is Param`` a, ``Is Param`` b , l, r with
                                   | true, true, _, _   -> (error "{expression} should be evaluated before query" nopos) :: inner
                                   | true, false, Some l, _  when IsNumeric l -> inner
                                   | false, true , _, Some r when IsNumeric r -> inner
                                   | _, _, Some l, Some r when l.IsAssignableTo r && IsNumeric l -> inner
                                   | _, _, Some l, Some r when r.IsAssignableTo l && IsNumeric r -> inner
                                   | _ -> (error $"Expression {expression} is not valid" nopos) :: inner
        | Div (a, b)            -> let inner = ``validate Expression`` a @ ``validate Expression`` b
                                   let l = a.ExpressionType
                                   let r = b.ExpressionType
                                   match ``Is Param`` a, ``Is Param`` b , l, r with
                                   | true, true, _, _   -> (error $"{expression} should be evaluated before query" nopos) :: inner
                                   | true, false, Some l, _  when IsNumeric l -> inner
                                   | false, true , _, Some r when IsNumeric r -> inner
                                   | _, _, Some l, Some r when l.IsAssignableTo r && IsNumeric l -> inner
                                   | _, _, Some l, Some r when r.IsAssignableTo l && IsNumeric r -> inner
                                   | _ -> (error $"Expression {expression} is not valid" nopos) :: inner
        | Add (a, b)            -> let inner = ``validate Expression`` a @ ``validate Expression`` b
                                   let l = a.ExpressionType
                                   let r = b.ExpressionType
                                   match ``Is Param`` a, ``Is Param`` b , l, r with
                                   | true, true, _, _   -> (error $"{expression} should be evaluated before query" nopos) :: inner
                                   | true, false, Some l, _  when IsNumeric l -> inner
                                   | false, true , _, Some r when IsNumeric r -> inner
                                   | _, _, Some l, Some r when l.IsAssignableTo r && IsNumeric l -> inner
                                   | _, _, Some l, Some r when r.IsAssignableTo l && IsNumeric r -> inner
                                   | _ -> (error $"Expression {expression} is not valid" nopos) :: inner
        | Sub (a, b)            -> let inner = ``validate Expression`` a @ ``validate Expression`` b
                                   let l = a.ExpressionType
                                   let r = b.ExpressionType
                                   match ``Is Param`` a, ``Is Param`` b , l, r with
                                   | true, true, _, _   -> (error $"{expression} should be evaluated before query" nopos) :: inner
                                   | true, false, Some l, _  when IsNumeric l -> inner
                                   | false, true , _, Some r when IsNumeric r -> inner
                                   | _, _, Some l, Some r when l.IsAssignableTo r && IsNumeric l -> inner
                                   | _, _, Some l, Some r when r.IsAssignableTo l && IsNumeric r -> inner
                                   | _ -> (error $"Expression {expression} is not valid" nopos) :: inner
        | Avg a                 -> let inner = ``validate Expression`` a
                                   let t = a.ExpressionType
                                   match t with
                                   | Some t when IsNumeric t -> inner
                                   | _ -> (error $"Expression {expression} is not valid" nopos) :: inner
        | Sum a                 -> let inner = ``validate Expression`` a
                                   let t = a.ExpressionType
                                   match t with
                                   | Some t when IsNumeric t -> inner
                                   | _ -> (error $"Expression {expression} is not valid" nopos) :: inner
        | Count a               -> ``validate Expression`` a
        | Max a                 -> ``validate Expression`` a
        | Min a                 -> ``validate Expression`` a
        | Ref r                 -> ``validate Name`` r
        | _                     -> []

    and ``validate Boolean`` (boolean : BoolExpr) : (string * Position) list =
        match boolean with
        | And (a, b)            -> ``validate Boolean`` a @ ``validate Boolean`` b
        | Or (a, b)             -> ``validate Boolean`` a @ ``validate Boolean`` b
        | Not a                 -> ``validate Boolean`` a
        | Less (a, b)           -> let inner = ``validate Expression`` a @ ``validate Expression`` b
                                   let l = a.ExpressionType
                                   let r = b.ExpressionType
                                   match l, r with
                                   | Some l, Some r when l.IsAssignableTo r && IsNumeric l -> inner
                                   | Some l, Some r when r.IsAssignableTo l && IsNumeric r -> inner
                                   | _ -> (error $"Expression {boolean} is not valid" nopos) :: inner
        | Greater (a, b)        -> let inner = ``validate Expression`` a @ ``validate Expression`` b
                                   let l = a.ExpressionType
                                   let r = b.ExpressionType
                                   match l, r with
                                   | Some l, Some r when l.IsAssignableTo r && IsNumeric l -> inner
                                   | Some l, Some r when r.IsAssignableTo l && IsNumeric r -> inner
                                   | _ -> (error $"Expression {boolean} is not valid" nopos) :: inner
        | GreaterEqual (a, b)   -> let inner = ``validate Expression`` a @ ``validate Expression`` b
                                   let l = a.ExpressionType
                                   let r = b.ExpressionType
                                   match l, r with
                                   | Some l, Some r when l.IsAssignableTo r && IsNumeric l -> inner
                                   | Some l, Some r when r.IsAssignableTo l && IsNumeric r -> inner
                                   | _ -> (error $"Expression {boolean} is not valid" nopos) :: inner
        | LessEqual (a, b)      -> let inner = ``validate Expression`` a @ ``validate Expression`` b
                                   let l = a.ExpressionType
                                   let r = b.ExpressionType
                                   match l, r with
                                   | Some l, Some r when l.IsAssignableTo r && IsNumeric l -> inner
                                   | Some l, Some r when r.IsAssignableTo l && IsNumeric r -> inner
                                   | _ -> (error $"Expression {boolean} is not valid" nopos) :: inner
        | Equal (a, b)          -> let inner = ``validate Expression`` a @ ``validate Expression`` b
                                   let l = a.ExpressionType
                                   let r = b.ExpressionType
                                   match l, r with
                                   | Some l, Some r when l.IsAssignableTo r -> inner
                                   | Some l, Some r when r.IsAssignableTo l -> inner
                                   | _ -> (error $"Expression {boolean} is not valid" nopos) :: inner
        | NotEqual (a, b)       -> let inner = ``validate Expression`` a @ ``validate Expression`` b
                                   let l = a.ExpressionType
                                   let r = b.ExpressionType
                                   match l, r with
                                   | Some l, Some r when l.IsAssignableTo r -> inner
                                   | Some l, Some r when r.IsAssignableTo l -> inner
                                   | _ -> (error $"Expression {boolean} is not valid" nopos) :: inner
        | Like (a, b)           -> ``validate Expression`` a @ ``validate Expression`` b
        | IsNull a              -> ``validate Expression`` a
        | IsNotNull a           -> ``validate Expression`` a
        | Exists s              -> ``validate Select`` s
        | NotExists s           -> ``validate Select`` s
        | In (a, b)             -> let ins = b |> List.fold (fun a i -> (``validate Expression`` i) @ a) []
                                   let types = 
                                     b 
                                     |> List.map (fun i -> i.ExpressionType)
                                     |> List.distinct
                                   let mismatch =
                                     match a.ExpressionType = types.Head, types.Length with
                                     | true,  1 -> []
                                     | false, 1 -> [error $"IN list type ({types}) does not match column type {a} type ({a.ExpressionType})" nopos]
                                     | _, _     -> [error $"In list has multiple types ({types})" nopos]
                                   ``validate Expression`` a @ ins @ mismatch
        | InSelect (a, s)       -> ``validate Expression`` a @ ``validate Select`` s
        | Between (a, b, c)     -> ``validate Expression`` a @ ``validate Expression`` b @ ``validate Expression`` c

    and ``validate Union`` (selects : Select list) =
        let parts = 
            selects 
            |> List.fold        (fun a i -> (``validate Select`` i) @ a) []

        let spanPos () = 
            selects
            |> List.map         (fun i -> i.Position)
            |> List.fold        (fun a i -> {sl = min a.sl i.sl; sc = min a.sc i.sc; el = max a.el i.el; ec = max a.ec i.ec}) nopos

        let mismatch = 
            selects
            |> List.map         (fun i -> i.Columns |> List.map (fun c -> c.Alias.Value))
            |> List.fold        (fun (b,l) i -> if b then (b,l) elif l = [] then (false, i) else ((l <> i), i)) (false, [])
            |> fun (b,l) -> if b then l else []
            |> List.map         (fun i -> error $"Column {i} mismatch" (spanPos()))

        parts @ mismatch

    and ``validate Statement`` (statement : Statement) =
        match statement with
        | Select s              -> ``validate Select`` s
        | Union (s, t)          -> let inner = ``validate Select`` s @ ``validate Statement`` t
                                   inner
        | ValidUnion s          -> ``validate Union`` s

    Some result, result.Statements |> List.map ``validate Statement`` |> List.concat
