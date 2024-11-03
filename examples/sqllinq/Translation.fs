module internal SQLLinq.Translation

open System
open Ast
open Hiperspace
open Resolution
open System.Reflection

let ``translate reference`` (name : Name) =
    let dotref sl = sl |> String.concat "."
    let rec nullCoalesce (root : string list) (names : string list) (types : PropertyInfo list) level =
        match (dotref (List.take level root)), types.Head.PropertyType.IsValueType, types.Head.PropertyType = typeof<Nullable<_>>, names.Tail, types.Tail with
        | nam, true, false, [], _   
        | nam, true, true, [], _    
        | nam, false, _, [], _      -> nam
        | nam, true, false, _, []   -> nullCoalesce root names.Tail types (level + 1)
        | nam, true, false, _, _    -> nullCoalesce root names.Tail types.Tail (level + 1)
        | nam, true, true, _, []
        | nam, false, _, _, []      -> $"({nam} == null ? null : {nullCoalesce root names.Tail types (level + 1)})"
        | nam, true, true, _, _    
        | nam, false, _, _, _       -> $"({nam} == null ? null : {nullCoalesce root names.Tail types.Tail (level + 1)})"
    match name.Name.Length with
    | 1 -> $"{name.Name.Head}"
    | 2 -> $"{name.Name.Head}.{name.Name.Tail.Head}"
    | _ -> nullCoalesce name.Name name.Name name.Property 1

let rec ``translate Expr`` indent (expr : Expr) =
    match expr with
    | Mul (a, b)            -> $"{``translate Expr`` indent a} * {``translate Expr`` indent b}" 
    | Div (a, b)            -> $"{``translate Expr`` indent a} / {``translate Expr`` indent b}"
    | Add (a, b)            -> $"{``translate Expr`` indent a} + {``translate Expr`` indent b}"
    | Sub (a, b)            -> $"{``translate Expr`` indent a} - {``translate Expr`` indent b}"
    | Avg a                 -> $"GROUP.Average(ROW => ROW.{(``translate Expr`` indent a)})"
    | Sum a                 -> $"GROUP.Sum(ROW => ROW.{``translate Expr`` indent a})"
    | Count a               -> $"GROUP.Count(ROW => ROW.{``translate Expr`` indent a} != null)"
    | CountStar             -> $"GROUP.Count()"
    | Max a                 -> $"GROUP.Max(ROW => ROW.{``translate Expr`` indent a})"
    | Min a                 -> $"GROUP.Min(ROW => ROW.{``translate Expr`` indent a})"
    | Lit a                 -> $"{a}" 
    | Ref a                 -> $"{``translate reference`` a}"
    | Param (a, t)          -> $"{a}"
    | Int a                 -> $"{a}"
    | Dec a                 -> $"{a}"
    | Num a                 -> $"{a}"
    | Str a                 -> $"\"{a}\""
    | Date a                -> $"{a}"
    | Bool a                -> $"{a}"
    | Boolean a             -> $"{``translate Bool`` indent a}"
    | Concat (a,b)          -> $"{``translate Expr`` indent a}.ToString() + {``translate Expr`` indent b}.ToString()"

and ``translate List`` indent (el : Expr list) =
    el |> List.map (fun x -> ``translate Expr`` indent x) |> String.concat ", "

and ``translate Bool`` (indent : string) (bool : BoolExpr) =
    match bool with
    | Less (a, b)           -> $"({``translate Expr`` indent a} < {``translate Expr`` indent b})"
    | Greater (a, b)        -> $"({``translate Expr`` indent a} > {``translate Expr`` indent b})"
    | GreaterEqual (a, b)   -> $"({``translate Expr`` indent a} >= {``translate Expr`` indent b})"
    | LessEqual (a, b)      -> $"({``translate Expr`` indent a} <= {``translate Expr`` indent b})"
    | Equal (a, b)          -> $"({``translate Expr`` indent a} = {``translate Expr`` indent b})"
    | NotEqual (a, b)       -> $"({``translate Expr`` indent a} <> {``translate Expr`` indent b})"
    | And (a, b)            -> $"({``translate Bool`` indent a} && {``translate Bool`` indent b})"
    | Or (a, b)             -> $"({``translate Bool`` indent a} || {``translate Bool`` indent b})"
    | Like (a, b)           -> let a = ``translate Expr`` indent a
                               let b = ``translate Expr`` indent b
                               let bare = b.Replace("%", "")
                               let reg = b.Replace("%", ".*").Replace("_", ".")
                               match b.Split("%").Length, b.Split("_").Length with
                               | 2, 1 when b.StartsWith("\"%") -> $"{a}.EndsWith({bare})"
                               | 2, 1 when b.EndsWith("%\"") -> $"{a}.StartsWith({bare})"
                               | 3, 1 when b.StartsWith("\"%") && b.EndsWith("%\"") -> $"{a}.Contains({bare})"
                               | _ -> $"Regex.IsMatch({a}, {reg})"
    | Not a                 -> $"!({``translate Bool`` indent a})"
    | IsNull a              -> $"({``translate Expr`` indent a} == null)"
    | IsNotNull a           -> $"({``translate Expr`` indent a} != null)"
    | In (a, b)             -> $"( new [] {{ {``translate List`` indent b} }}).Contains({``translate Expr`` indent  a})"
    | InSelect (a, b)       -> ``translate inselect`` indent a b
    | Exists a              -> $"(({``translate Select`` indent a}).Count() > 0)"
    | NotExists a           -> $"(({``translate Select`` indent a}).Count() == 0)"
    | Between (a, b, c)     -> let a = ``translate Expr`` indent a
                               $"({a} <= {``translate Expr`` indent b} && {a} >= {``translate Expr`` indent c})"

and ``translate Column Select`` indent (column : Column) (grouping : Map<string list, string>) =
    match column.Expression with
    | Ref r when grouping.ContainsKey r.Name -> $"{column.Alias.Value} = GROUP.Key.{grouping.[r.Name]}"
    | _ -> $"{column.Alias.Value} = {``translate Expr`` indent column.Expression}"

and ``translate Join Relations`` (b : BoolExpr) = 
    let rec equalList (l :BoolExpr)  (r : BoolExpr) =
        match l, r with
        | And (a, b), And (c, d) ->  equalList a b @ equalList c d
        | And (a, b), Equal (Ref c, Ref d) -> equalList a b @ [(c,d)]
        | Equal (Ref c, Ref d), And (a, b) -> [(c,d)] @ equalList a b 
        | _, _ -> []
    let empty : (Name list * Name list) = ([],[])
    match b with
    | Equal (a, b)  -> $"on {a} equals {b}"
    | And (a, b)    -> let l, r = equalList a b |> List.fold (fun (sa, sb) (a,b) -> (a :: sa, b :: sb)) empty
                       let left  = l |> List.map (fun i -> $"{i.Table.Head.Alias}.{i.Name}") |> String.concat ", "
                       let right = r |> List.map (fun i -> $"{i.Table.Head.Alias}.{i.Name}") |> String.concat ", "
                       $"on new {{ {left} }} equals {{ {right} }} "
    | _             -> ""

and ``translate From`` indent (from : From) =
    match from with 
    | Table t                                   -> $"for {t.Alias.Value} in space.{t.Name} do"
    | Join (t1, t2, j)                          -> $"""
{indent}{``translate From`` indent t1}
{indent}join {``translate From`` indent t2} {``translate Join Relations`` j} """
    | Product (t1, t)                           -> $"{``translate From`` indent t1} {``translate From`` indent t1}"
    | SubQuery (s, n)                           -> $"{n} in ({``translate Select`` indent s})"

and ``all Table Alias`` (from : From) =
        match from with
        | Table t                   -> [t.Alias.Value]
        | Join (t1, t2, _)          -> ``all Table Alias`` t1 @ ``all Table Alias`` t2
        | Product (t1, t)           -> ``all Table Alias`` t1 @ ``all Table Alias`` t1
        | SubQuery (s, n)           -> [n]

and ``translate inselect`` (indent : string) (a : Expr) (b : Select) = 
    let indent = indent + "  "
    let query = ``translate Select`` indent b
    let column = ``translate Expr`` indent a
    let first = b.Columns.Head.Alias.Value
    $"""
{indent}({query}).Any(ITEM => ITEM.{first} == {column})"""

and ``translate Select`` (indent : string) (select : Select) : string =
    let indent = indent + "  "
    let from = ``translate From`` indent select.From

    let where = 
        match select.Where with 
        | Some w -> $"""
{indent}where {``translate Bool`` indent w }""" 
        | None -> ""

    let groupColumns =
        if select.GroupBy.IsSome then 
            select.GroupBy.Value.Columns
            |> List.choose  (fun i -> match i.Expression with
                                      | Ref r -> Some (r.Name, i.Alias.Value)
                                      | _     -> None)
            |> Map.ofList
        else
            Map.empty

    let columns = 
        match select.Columns with
        | [] -> (``all Table Alias`` select.From |> String.concat "; ")
        | _  -> select.Columns 
                |> List.map (fun x -> ``translate Column Select`` indent x groupColumns)
                |> String.concat "; "

    let groupBy = 
        match select.GroupBy with
        | None -> ""
        | Some g -> let groupTables = ``all Table Alias`` select.From
                    let groupCols = 
                        g.Columns 
                        |> List.map (fun x -> $"{x.Alias.Value} = {``translate Expr`` indent x.Expression}")
                        |> String.concat ", "
                    $"""group new {{ {groupTables |> String.concat (", ")} }} by new {{ {groupCols} }} into GROUP """

    let orderby =
        select.OrderBy
        |> List.map (fun x -> $"orderby {``translate Expr`` indent x.Expression}")
        |> String.concat ", "
           

    let having =
        match select.GroupBy with
        | None -> ""
        | Some g -> match g.Having with
                    | Some h    -> $"where {``translate Bool`` indent h}"
                    | None      -> ""

    let distinct = if select.Distinct then ".Distinct()" else ""
    let limit = match select.Limit with | Some l -> $".Take({l})" | None -> ""
    $$"""(query { {{from}} 
{{indent}}{{where}} 
{{indent}}{{groupBy}} 
{{indent}}{{having}} 
{{indent}}{{orderby}}
{{indent}}select {| {{columns}} |} {{distinct}}{{limit}} })"""

and ``translate type`` (t : Type) =
    if t.IsGenericType then
        let name = t.FullName.Split("`").[0]
        let types = t.GetGenericArguments() |> Array.map (fun i -> ``translate type`` i) |> String.concat ", "
        $"{name}<{types}>"
    else    
        t.FullName

and ``translate Union`` (indent : string) (space : SubSpace) (union : Select list) =
    let indent = indent + "  "
    let selects = 
        union 
        |> List.map (fun s -> ``translate Select`` indent s)
        |> String.concat $"\n{indent}.Union\n{indent}"
    
    $"""
let sqlquery (space : {space.GetType().FullName}) =
    {selects}
"""
    
and translate (space : SubSpace) (statements: Statement list) =
    let unspace (s : string) = s.Split("\r\n") |> Array.filter (fun i -> i.Trim() <> "") |> String.concat "\r\n"
    statements
    |> List.map (fun statement -> match statement with
                                  | Select s      -> ``translate Union`` "         " space [s] |> unspace
                                  | ValidUnion u  -> ``translate Union`` "         " space u |> unspace
                                  | _ -> "")
