module internal Hiperspace.SQL.Translation

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
    | Equal (a, b)          -> $"({``translate Expr`` indent a} == {``translate Expr`` indent b})"
    | NotEqual (a, b)       -> $"({``translate Expr`` indent a} != {``translate Expr`` indent b})"
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

and ``translate Join Relations`` indent (b : BoolExpr) = 
    let expr (a : Expr) = 
        match a with
        | Ref l     -> l.Name |> String.concat "."
        | l         -> $"{``translate Expr`` indent l}"
    let rec equalList (l :BoolExpr)  (r : BoolExpr) =
        match l, r with
        | And (a, b), And (c, d) ->  equalList a b @ equalList c d
        | And (a, b), Equal (c, d) -> equalList a b @ [(c,d)]
        | Equal (c, d), And (a, b) -> [(c,d)] @ equalList a b 
        | _, _ -> []
    let empty : (Expr list * Expr list) = ([],[])
    match b with
    | Equal (a, b)  -> $"on {expr a} equals {expr b}"
    | And (a, b)    -> let l, r = equalList a b |> List.fold (fun (sa, sb) (a,b) -> (a :: sa, b :: sb)) empty
                       let left  = l |> List.map expr |> String.concat ", "
                       let right = r |> List.map expr |> String.concat ", "
                       $"on new {{ {left} }} equals {{ {right} }} "
    | _             -> ""

and ``translate From`` indent (from : From) =
    match from with 
    | Table t when t.Name.StartsWith("SCHEMA_") -> $"{t.Alias.Value} in _engine.{t.Name}"
    | Table t                                   -> $"{t.Alias.Value} in _space.{t.Name}"
    | Join (t1, t2, j)                          -> $"""
{indent}{``translate From`` indent t1}
{indent} join {``translate From`` indent t2} {``translate Join Relations`` indent j} """
    | Product (t1, t)                           -> $"{``translate From`` indent t1} {``translate From`` indent t1}"
    | SubQuery (s, n)                           -> $"{n} in ({snd (``translate Select`` indent s)})"

and ``all Table Alias`` (from : From) =
        match from with
        | Table t                   -> [t.Alias.Value]
        | Join (t1, t2, _)          -> ``all Table Alias`` t1 @ ``all Table Alias`` t2
        | Product (t1, t)           -> ``all Table Alias`` t1 @ ``all Table Alias`` t1
        | SubQuery (s, n)           -> [n]

and ``translate inselect`` (indent : string) (a : Expr) (b : Select) = 
    let indent = indent + "  "
    let query = snd (``translate Select`` indent b)
    let column = ``translate Expr`` indent a
    let first = b.Columns.Head.Alias.Value
    $"""
{indent}({query}).Any(ITEM => ITEM.{first} == {column})"""

and ``translate Select`` (indent : string) (select : Select) =
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
        | [] -> (``all Table Alias`` select.From |> String.concat ", ")
        | _  -> select.Columns 
                |> List.map (fun x -> ``translate Column Select`` indent x groupColumns)
                |> String.concat ", "

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

    let parameters = 
        let whereParameters = match select.Where with | Some w -> ``bool parameters`` w | None   -> []
        let groupParameters = match select.GroupBy with | Some g -> (match g.Having with | Some h -> ``bool parameters`` h | _ -> []) | _ -> []
        let colParameters   = select.Columns |> List.map (fun c -> parameters c.Expression) |> List.concat
        whereParameters @ groupParameters @ colParameters 
        |> List.distinct
        |> List.map     (fun (s,t) -> s, match t with | Some t -> t | None -> typeof<obj>)

    let distinct = if select.Distinct then ".Distinct()" else ""
    let limit = match select.Limit with | Some l -> $".Take({l})" | None -> ""
    let result = 
        $"""(from {from} 
{indent}{where} 
{indent}{groupBy} 
{indent}{having} 
{indent}{orderby}
{indent}select new /*Row*/ {{ {columns} }}){distinct}{limit}"""
    parameters, result

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

    let finalrow (s : string) =
        let parts = s.Split("/*Row*/")
        parts
        |> Array.mapi   (fun n i -> if n = (parts.Length - 1) then "Row " + i else i)
        |> Array.fold   (fun a i -> a + i) ""

    let queries = 
        selects 
        |> List.map (fun (p, s) -> s)
        |> List.map finalrow
        |> String.concat $"\n{indent}.Union\n{indent}"

    let parameters = 
        selects 
        |> List.map (fun (p, s) -> p)
        |> List.concat
        |> List.distinct

    let ValidParam =
        parameters 
        |> List.map (fun (s,t) -> $"""
        {{
            if (parameters.TryGetValue("{s}", out var item))
            {{
                if (!(item is {``translate type`` t})) result += "{s} invalid ";
            }}
            else result += "{s} missing, ";
        }}""")
        |> String.concat ""

    let Param =
        parameters 
        |> List.map (fun (s,t) -> $"""
        {``translate type`` t} {s} = parameters["{s}"] as {``translate type`` t};""")
        |> String.concat ""

    let row = 
        union.Head.Columns
        |> List.map (fun c -> $"""
        public {``translate type`` c.Expression.ExpressionType.Value} {c.Alias.Value} {{ get; init; }}""")
        |> String.concat ""

    let frames = 
        union.Head.Columns
        |> List.map (fun c -> $"""
            {{ "{c.Alias.Value}", new object[rows.Length] }},""")
        |> String.concat ""

    let copy = 
        let format name  (t : Type) =
            let t = 
                if t.IsGenericType then
                    t.GetGenericArguments().[0]
                else
                    t
            match t with
            | t when t = typeof<Guid>       -> $"rows[c].{name}.ToString();"
            | t when t = typeof<DateTime>   -> $"rows[c].{name};" //.ToString(\"yyyy-MM-ddTHH:mm:ss.fffffffK\");"
            | t when t = typeof<Int16>      -> $"rows[c].{name};"
            | t when t = typeof<Int32>      -> $"rows[c].{name};"
            | t when t = typeof<Int64>      -> $"rows[c].{name};"
            | t when t = typeof<double>     -> $"rows[c].{name};"
            | t when t = typeof<single>     -> $"rows[c].{name};"
            | t when t = typeof<Half>       -> $"rows[c].{name};"
            | t when t = typeof<bool>       -> $"rows[c].{name};"
            | t when t = typeof<decimal>    -> $"rows[c].{name};"
            | t when t = typeof<string>     -> $"rows[c].{name};"
            | t when t.IsEnum               -> $"rows[c].{name}.ToString();"
            | _                             -> $"JsonSerializer.Serialize(rows[c].{name}, _JsonOptions);"
        union.Head.Columns
        |> List.map (fun c -> $"""
            frame["{c.Alias.Value}"][c] = {format c.Alias.Value c.Expression.ExpressionType.Value}""")
        |> String.concat ""
    
    $"""using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using Parquet.Serialization;
public class ΣxecPlan : Hiperspace.SQL.IPlan
{{
    {space.GetType().FullName} _space;
    Hiperspace.SQL.Engine _engine;
    JsonSerializerOptions _JsonOptions = new JsonSerializerOptions {{ ReferenceHandler = ReferenceHandler.IgnoreCycles}};
    public ΣxecPlan (Hiperspace.SubSpace space, Hiperspace.SQL.Engine engine)
    {{
        _space = space as {space.GetType().FullName};
        _engine = engine;
    }}

    public record Row
    {{
{row}
    }}

    public string Validate(IDictionary<string, object> parameters)
    {{
        string result = "";
{ValidParam}
        return result;
    }}

    public IQueryable<Row> Query(IDictionary<string, object> parameters)
    {{
        {Param}
        return 
{indent} {queries}
            ;
    }}
    public IDictionary<string, object[]> Execute(IDictionary<string, object> parameters)
    {{
        var rows = Query(parameters).ToArray();
        var frame = new SortedDictionary<string, object[]> 
        {{ 
{frames}
        }};
        for(int c = 0; c < rows.Length; c++)
        {{
{copy}
        }}
        return frame;
    }}
    public string Parquet(IDictionary<string, object> parameters, string filename)
    {{
        var rows = Query(parameters).ToArray();
        ParquetSerializer.SerializeAsync(rows, filename).Wait();
        return filename;
    }}
    public IQueryable Queryable(IDictionary<string, object> parameters)
    {{
        return Query(parameters);
    }}
}}"""
    
and translate (space : SubSpace) (statements: Statement list) =
    let unspace (s : string) = s.Split("\n") |> Array.filter (fun i -> i <> "") |> String.concat "\n"
    statements
    |> List.map (fun statement -> match statement with
                                  | Select s      -> ``translate Union`` "        " space [s] |> unspace
                                  | ValidUnion u  -> ``translate Union`` "        " space u |> unspace
                                  | _ -> "")
