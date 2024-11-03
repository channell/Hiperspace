module SQLLinq.Ast

open System
open System.Reflection
open Hiperspace

let inline IsNumeric (t : System.Type) =
    t.IsAssignableTo(typeof<int64>) ||
    t.IsAssignableTo(typeof<decimal>) ||
    t.IsAssignableTo(typeof<double>) 

/// <summary>
/// Represents the position of a code element in the source file.
/// </summary>
type Position =
  {
    sl              : int
    sc              : int
    el              : int
    ec              : int
  }

/// Reference to a table
and Table =
  {
    /// Name of the Subspace collection 
    Name            : string
    /// Allias assigned in the query
    Alias           : string option
    /// type of element in the Set
    Subject         : Type option
    /// referehce to the set in the subspace
    Set             : ISetSpace option
    /// query that provides the subquery
    SubQuery        : Select option
    /// position in the source code
    Position        : Position
  }

and Name =
  {
    Name            : string list
    Table           : Table list
    Target          : obj option
    Property        : PropertyInfo list
    Position        : Position
  }
  member this.Type with get() : Type option =
    match this.Property with
    | [] when this.Table.Head.Name.StartsWith("SCHEMA_") -> Some typeof<string>
    | []    -> None
    | _     -> Some ((List.last this.Property).PropertyType)

  static member Create name pos = 
    { 
      Name          = name
      Table         = []
      Target        = None
      Property      = []
      Position      = pos
    }
  override this.ToString() =
    let name = this.Name |> String.concat "."
    let table = List.head this.Table 
    $"{table.Name}.{name}"

and Column =
  {
    Expression      : Expr
    Alias           : string option
    Position        : Position
  }

and From =
    | Table         of Table
    | Join          of From * From * BoolExpr
    | Product       of From * From
    | SubQuery      of Select * string
    member this.Position = 
      match this with
      | Table t         -> t.Position
      | Join (a, b, c)  -> a.Position
      | Product (a, b)  -> a.Position
      | SubQuery (s, n) -> s.Position
    override this.ToString() =
      match this with
      | Table t         -> sprintf "%s in %s " t.Alias.Value t.Name
      | Join (a, b, c)  -> sprintf "%s join %s on %s" (a.ToString()) (b.ToString()) (c.ToString())
      | Product (a, b)  -> sprintf "%s from %s" (a.ToString()) (b.ToString())
      | SubQuery (s, n) -> sprintf "(%s)" (s.ToString()) 

and Grouping =
  {
    Columns         : Column list
    Having          : BoolExpr option
    Position        : Position
  }
  override this.ToString() =
    let groupBy = this.Columns |> List.map (fun x -> x.ToString()) |> String.concat ", "
    let having = match this.Having with | Some h -> "having " + h.ToString() | None -> ""
    sprintf "group by %s %s" groupBy having

and Select =
  {
    Columns         : Column list
    From            : From
    Where           : BoolExpr option
    GroupBy         : Grouping option
    OrderBy         : Column list
    Limit           : int option
    Distinct        : bool
    Position        : Position
  }
  override this.ToString() =
        let columns = this.Columns |> List.map (fun x -> x.ToString()) |> String.concat ", "
        let from = this.From.ToString()
        let where = match this.Where with | Some w -> "where " + w.ToString() | None -> ""
        let groupBy = match this.GroupBy with | Some g -> g.ToString() | None -> ""
        let orderBy = this.OrderBy |> List.map (fun x -> x.ToString()) |> String.concat ", "
        let limit = match this.Limit with | Some l -> "limit " + l.ToString() | None -> ""
        let distinct = if this.Distinct then "distinct" else ""

        sprintf "select %s from %s %s %s %s %s %s" columns from where groupBy orderBy limit distinct

and Expr = 
  | Mul             of Expr * Expr
  | Div             of Expr * Expr
  | Add             of Expr * Expr
  | Sub             of Expr * Expr
  | Avg             of Expr
  | Sum             of Expr
  | Count           of Expr
  | CountStar
  | Max             of Expr
  | Min             of Expr
  | Lit             of string
  | Ref             of Name
  | Param           of string * Type option
  | Int             of int64
  | Dec             of decimal
  | Num             of float
  | Str             of string
  | Date            of DateTime
  | Bool            of bool
  | Boolean         of BoolExpr
  | Concat          of Expr * Expr

  member this.IsAnAggregate() =
    match this with
    | Avg _ | Sum _ | Count _ | CountStar | Max _ | Min _ -> true
    | Mul (a, b) -> a.IsAnAggregate() || b.IsAnAggregate()
    | Div (a, b) -> a.IsAnAggregate() || b.IsAnAggregate()
    | Add (a, b) -> a.IsAnAggregate() || b.IsAnAggregate()
    | Sub (a, b) -> a.IsAnAggregate() || b.IsAnAggregate()
    | _ -> false

  member this.ExpressionType with get() : Type option =
    match this with 
    | Mul (a, b)            -> let l = a.ExpressionType
                               let r = b.ExpressionType
                               match l, r with
                               | Some l, Some r when l.IsAssignableTo r -> Some r
                               | Some l, Some r when r.IsAssignableTo l -> Some l
                               | _ -> None
    | Div (a, b)            -> let l = a.ExpressionType 
                               let r = b.ExpressionType
                               match l, r with
                               | Some l, Some r when l.IsAssignableTo r -> Some r
                               | Some l, Some r when r.IsAssignableTo l -> Some l
                               | _ -> None
    | Add (a, b)            -> let l = a.ExpressionType 
                               let r = b.ExpressionType
                               match l, r with
                               | Some l, Some r when l.IsAssignableTo r -> Some r
                               | Some l, Some r when r.IsAssignableTo l -> Some l
                               | _ -> None
    | Sub (a, b)            -> let l = a.ExpressionType 
                               let r = b.ExpressionType
                               match l, r with
                               | Some l, Some r when l.IsAssignableTo r -> Some r
                               | Some l, Some r when r.IsAssignableTo l -> Some l
                               | _ -> None
    | Avg a                 -> match a.ExpressionType with
                               | Some t when IsNumeric t -> Some t
                               | _ -> None
    | Sum a                 -> match a.ExpressionType with
                               | Some t when IsNumeric t -> Some t
                               | _ -> None
    | Count a               -> Some typeof<int64>
    | CountStar             -> Some typeof<int64>
    | Param (s,t)           -> t
    | Max a                 -> a.ExpressionType
    | Min a                 -> a.ExpressionType
    | Lit l                 -> Some typeof<string>
    | Ref r                 -> r.Type
    | Int i                 -> Some typeof<int64>
    | Dec d                 -> Some typeof<decimal>
    | Num n                 -> Some typeof<double>
    | Str s                 -> Some typeof<string>
    | Bool b                -> Some typeof<bool>
    | Boolean b             -> Some typeof<bool>    
    | Date d                -> Some typeof<System.DateTime>  
    | Concat (a, b)         -> Some typeof<string>

  override this.ToString() =
    match this with
    | Mul (a, b)    -> sprintf "%s * %s" (a.ToString()) (b.ToString())
    | Div (a, b)    -> sprintf "%s / %s" (a.ToString()) (b.ToString())
    | Add (a, b)    -> sprintf "%s + %s" (a.ToString()) (b.ToString())
    | Sub (a, b)    -> sprintf "%s - %s" (a.ToString()) (b.ToString())
    | Avg a         -> sprintf "GROUP.Average(i => i.%s)" (a.ToString())
    | Sum a         -> sprintf "GROUP.Sum(i => i.%s)" (a.ToString())
    | Count a       -> sprintf "GROUP.Count(i => i.%s)" (a.ToString())
    | CountStar     -> sprintf "GROUP.Count()"
    | Max a         -> sprintf "GROUP.Max(i =>i.%s)" (a.ToString())
    | Min a         -> sprintf "GROUP.Min(i => i.%s)" (a.ToString())
    | Lit a         -> sprintf "%s" a
    | Ref a         -> sprintf "%s" (a.Name |> String.concat ".")
    | Param (s, t)  -> sprintf ":%s" s
    | Int a         -> sprintf "%d" a
    | Dec a         -> sprintf "%s" (a.ToString())
    | Num a         -> sprintf "%f" a
    | Bool a        -> sprintf "%b" a
    | Str a         -> sprintf "\"%s\"" a
    | Date a        -> sprintf "DateTime.Parse(\"%s\")" (a.ToString())
    | Boolean a     -> a.ToString()
    | Concat (a, b) -> sprintf "%s.ToString() + %s.ToString()" (a.ToString()) (b.ToString())

and BoolExpr =
  | Less            of Expr * Expr
  | Greater         of Expr * Expr
  | GreaterEqual    of Expr * Expr
  | LessEqual       of Expr * Expr
  | Equal           of Expr * Expr
  | NotEqual        of Expr * Expr
  | Like            of Expr * Expr
  | And             of BoolExpr * BoolExpr
  | Or              of BoolExpr * BoolExpr
  | Not             of BoolExpr
  | IsNull          of Expr
  | IsNotNull       of Expr
  | In              of Expr * Expr list
  | InSelect        of Expr * Select  
  | Exists          of Select
  | NotExists       of Select
  | Between         of Expr * Expr * Expr 

  /// is this boolean expression a join
  member this.IsAJoin() =
    match this with
    | And (a, b)            -> a.IsAJoin() && b.IsAJoin()
    | Equal (Ref a, Ref b)  -> true
    | _                     -> false

  member this.IsAnAggregate() =
    match this with
    | Less (a, b) 
    | Greater (a, b) 
    | GreaterEqual (a, b) 
    | LessEqual (a, b) 
    | Equal (a, b) 
    | NotEqual (a, b)       -> a.IsAnAggregate() || b.IsAnAggregate()
    | And (a, b) 
    | Or (a, b)             -> a.IsAnAggregate() || b.IsAnAggregate()
    | Like (a, b)           -> a.IsAnAggregate() || b.IsAnAggregate()
    | Not a                 -> a.IsAnAggregate()
    | IsNull a 
    | IsNotNull a           -> false
    | In (a, b)             -> a.IsAnAggregate() || b |> List.exists (fun x -> x.IsAnAggregate())
    | InSelect (a, b)       -> a.IsAnAggregate() || b.Columns |> List.exists (fun x -> x.Expression.IsAnAggregate())
    | Exists a 
    | NotExists a           -> a.Columns |> List.exists (fun x -> x.Expression.IsAnAggregate())
    | Between (a, b, c)     -> a.IsAnAggregate() || b.IsAnAggregate() || c.IsAnAggregate()

  override this.ToString() =
    match this with
    | Less (a, b)           -> sprintf "((%s) < (%s))" (a.ToString()) (b.ToString())
    | Greater (a, b)        -> sprintf "((%s) > (%s))" (a.ToString()) (b.ToString())
    | GreaterEqual (a, b)   -> sprintf "((%s) >= (%s))" (a.ToString()) (b.ToString())
    | LessEqual (a, b)      -> sprintf "((%s) <= (%s))" (a.ToString()) (b.ToString())
    | Equal (a, b)          -> sprintf "((%s) == (%s))" (a.ToString()) (b.ToString())
    | NotEqual (a, b)       -> sprintf "((%s) != (%s))" (a.ToString()) (b.ToString())
    | And (a, b)            -> sprintf "((%s) && (%s))" (a.ToString()) (b.ToString())
    | Or (a, b)             -> sprintf "((%s) || (%s))" (a.ToString()) (b.ToString())
    | Not a                 -> sprintf "!(%s)" (a.ToString())
    | IsNull a              -> sprintf "((%s) == null)" (a.ToString())
    | IsNotNull a           -> sprintf "((%s) != null)" (a.ToString())
    | Like (a, b)           -> sprintf "((%s).Contains(%s))" (b.ToString()) (a.ToString())
    | In (a, b)             -> sprintf "((%s).Contains(%s))" (b |> List.map (fun x -> x.ToString()) |> String.concat ", ") (a.ToString()) 
    | InSelect (a, b)       -> sprintf "((%s).Contains(%s))" (b.ToString()) (a.ToString()) 
    | Exists a              -> sprintf "((%s).Any())" (a.ToString())
    | NotExists a           -> sprintf "(!(%s).Any())" (a.ToString())
    | Between (a, b, c)     -> sprintf "((%s) <= (%s) && (%s) >= (%s))" (a.ToString()) (b.ToString()) (a.ToString()) (c.ToString())

type Statement =
  | Select          of Select
  | Union           of Select * Statement
  | ValidUnion      of Select list
  override this.ToString() =
    match this with
    | Select s          -> s.ToString()
    | Union (s, r)      -> sprintf "(%s).Union(%s)" (s.ToString()) (r.ToString())
    | ValidUnion s      -> s |> List.fold (fun a x -> if a = "" then "(" + x.ToString() + ")" else a + ".Union(" + x.ToString() + ")")  ""


type Result = 
  {
    Statements  : Statement list
  }
  static member Create stmts = 
    { Statements = stmts }
  override this.ToString (): string = 
    this.Statements |> List.map (fun x -> x.ToString()) |> String.concat ";"
  
/// Relations in the in Subspace
type Relation =
  {
    /// name of the set for lookup
    Name        : string
    /// reference to the subspace set
    Set         : ISetSpace 
    /// subject of the set
    Subject     : Type
    /// collection of columns
    Columns     : Map<string, PropertyInfo>
  }

type dba_relation =
  {
    Name        : string
    Cols        : Set<string>
  }

type Schema =
  {
    Relations   : Map<string, Relation>
    Columns     : Map<string, (Relation * PropertyInfo) list>
  }
