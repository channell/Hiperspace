namespace Hiperspace.SQL

open Hiperspace.SQL.Ast
open Hiperspace
open System

open FSharp.Text.Lexing
open Resolution
open Validation
open System.Collections.Generic
open System.Reflection
open System.Linq

type Engine (space : SubSpace) =

    let parse source = 
        let lexbuf = LexBuffer<_>.FromString source
        try
            Some (Parser.start Lexer.read lexbuf), None
        with e -> 
            let src = Array.fold(fun a y -> a + y.ToString() ) "" (lexbuf.Lexeme)
            let pos =   
                { 
                    sl = lexbuf.StartPos.pos_lnum
                    sc = (lexbuf.StartPos.pos_cnum - lexbuf.StartPos.pos_bol + 1)
                    el = lexbuf.EndPos.pos_lnum
                    ec = (lexbuf.EndPos.pos_cnum - lexbuf.StartPos.pos_bol + 1)
                }
            None , Some (pos, src, e.Message)

    let schema = Resolution.references space

    let compiler = Compiler()

    let queryCache = new Dictionary<Statement, PlanReference>()

    let prepare (source : string) =
        let result = 
            match (parse source) with
            | Some result, _            -> validate (resolve schema result)
            | _, Some (pos, src, msg)   -> None, [$"{msg} with \"{src}\"", pos]
            | _                         -> None, ["Unknown error", { sl = 0; sc = 0; el = 0; ec = 0 }]

        let result =
            match result with
            | Some result, []           -> result
            | Some _, errors            -> raise (new Exception (errors |> Seq.fold (fun a (m,p) -> a + $"{m} at {p}\n") ""))
            | _, errors                 -> raise (new Exception (errors |> Seq.fold (fun a (m,p) -> a + $"{m} at {p}\n") ""))
    
        let compile (statement : Statement) =
            let unspace (s : string) = s.Split("\r\n") |> Array.filter (fun i -> i.Trim() <> "") |> String.concat "\r\n"
            match statement with
            | Select s      -> let code = Translation.``translate Union`` "        " space [s] |> unspace
                               let plan = compiler.Prepare "ΣxecPlan" code source
                               queryCache.Add(statement, plan); 
                               plan

            | ValidUnion u  -> let code = Translation.``translate Union`` "        " space u |> unspace
                               let plan = compiler.Prepare "ΣxecPlan" code source
                               queryCache.Add(statement, plan)
                               plan        
            | _             -> raise (new Exception "Union was replaced during validation")

        result.Statements
        |> List.map     (fun i -> if queryCache.ContainsKey(i) then queryCache.[i] else compile i)
        |> List.map     (fun i -> i.Use())

    member this.Validate source = 
        match (parse source) with
        | Some result, _            -> validate (resolve schema result)
        | _, Some (pos, src, msg)   -> None, [$"Erorr {msg} with {src}", pos]
        | _                         -> None, ["Unknown error", { sl = 0; sc = 0; el = 0; ec = 0 }]

    /// Explain the queries in the source
    member engine.Explain (source, parameters : IDictionary<string,obj>) : string array = 
        let results (plan : PlanReference) =
            let cons = plan.Plan.GetConstructors().[0]
            let instance = cons.Invoke([| space; engine |]) :?> IPlan
            let errors = instance.Validate(parameters)
            if errors <> "" then 
                raise (new Exception ($"Error with parameters {errors}"))
            let query = instance.Queryable(parameters)
            let explainer = QueryExplain (query.Expression)
            explainer.ToString()
        prepare source 
        |> List.map (fun i -> results i)
        |> Array.ofList

    /// Execute the queries in the source
    member engine.Execute (source , parameters : IDictionary<string,obj>) : IDictionary<string, obj array> array  =
        let results (plan : PlanReference) =
            let cons = plan.Plan.GetConstructors().[0]
            let instance = cons.Invoke([| space; engine |]) :?> IPlan
            let errors = instance.Validate(parameters)
            if errors <> "" then 
                raise (new Exception ($"Error with parameters {errors}"))
            instance.Execute(parameters)
        prepare source 
        |> List.map (fun i -> results i)
        |> Array.ofList
        
    /// Create a parquet file from the source
    member this.Parquet (source, fileNames, parameters : IDictionary<string,obj>): string array = 
        let results (plan : PlanReference) fileName =
            let cons = plan.Plan.GetConstructors().[0]
            let instance = cons.Invoke([| space; this |]) :?> IPlan
            let errors = instance.Validate(parameters)
            if errors <> "" then 
                raise (new Exception ($"Error with parameters {errors}"))
            instance.Parquet(parameters, fileName)
        let fileNames = List.ofArray fileNames
        prepare source 
        |> List.map2 (fun f i -> results i f) fileNames
        |> Array.ofList

    member this.SCHEMA_TABLES with get () =
        let Set = null :> ISetSpace
        let setType (set : ISetSpace) = (set.GetType().BaseType.GetGenericArguments()[0]).FullName 
        let mapper (relation : Relation) = 
          {
            TABLE_NAME = relation.Name
            TABLE_TYPE = setType relation.Set
          }
        schema.Relations
        |> Seq.map (fun kv -> kv.Value)
        |> Seq.map mapper
        |> fun i -> i.AsQueryable()

    member this.SCHEMA_COLUMNS with get () =
        let mappercol (relation : Relation) (columname, propertytype : PropertyInfo) = 
          {
            TABLE_NAME = relation.Name
            COLUMN_NAME = columname
            COLUMN_TYPE = propertytype.PropertyType.FullName
          }
        let folder a (relation : Relation) = 
            a @ (relation.Columns
                 |> Seq.map  (fun kv -> kv.Key, kv.Value) 
                 |> Seq.toList
                 |> List.map (mappercol relation))

        schema.Relations
        |> Seq.map (fun kv -> kv.Value)
        |> Seq.toList
        |> List.fold folder []
        |> Seq.ofList
        |> fun i -> i.AsQueryable()

    member this.SCHEMA_PROPERTIES with get () =
        let mapper (t : Type, ps : PropertyInfo) = 
          {
            TYPE_NAME = t.FullName
            PROPERTY_NAME = ps.Name
            PROPERTY_TYPE = ps.PropertyType.FullName
          }
        space.GetType().Assembly.GetTypes()
        |> List.ofSeq
        |> List.map     (fun i -> i.GetProperties(BindingFlags.Public ||| BindingFlags.Instance) |> Array.map (fun p -> i,p) |> List.ofArray)
        |> List.concat
        |> List.map     mapper
        |> Seq.ofList
        |> fun i -> i.AsQueryable()
