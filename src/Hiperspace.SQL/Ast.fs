module Hiperspace.SQL.Ast

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
    match this.Property, this.Table with
    | [], []    -> None
    | [], _ when this.Table.Head.Name.StartsWith("SCHEMA_") -> Some typeof<string>
    | _, _      -> Some ((List.last this.Property).PropertyType)

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

and Grouping =
  {
    Columns         : Column list
    Having          : BoolExpr option
    Position        : Position
  }

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

type Statement =
  | Select          of Select
  | Union           of Select * Statement
  | ValidUnion      of Select list

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
    Dba         : Map<string, dba_relation>
  }
