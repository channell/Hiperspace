// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------

module export

open Sparx
open Sparx.EA
open System.Text.Json
open System.IO
open System.Text.Json.Serialization
open Microsoft.EntityFrameworkCore
open Log
open System.Linq
open Hiperspace

let dirOperation tabs (o : ElementOperations) =
    printfn "%s%s" tabs o.Name

let dirAttribute tabs (a : Attribute) =
    printfn "%s%s" tabs a.Name

let dirElement tabs (e : Element) =
    printfn "%s%s" tabs e.Name
    let tabs = tabs + "\t"
    e.Operations
    |> Seq.iter     (dirOperation tabs)
    e.Attributes
    |> Seq.iter     (dirAttribute tabs)

let rec dirPackage tabs  (p : Package) =
    printfn "%s%s" tabs p.Name
    let tabs = tabs + "\t"
    p.Children
    |> Seq.iter     (dirPackage tabs)
    p.Content
    |> Seq.iter     (dirElement tabs)

let listing (space : SparxSpace) =
    log "Listing"
    space.Packages
    |> Seq.filter   (fun p -> (p.Parent.Value.Key.Id.Value = 0))
    |> Seq.iter     (dirPackage "\t")

/// graph listing
let graphListing (space : SparxSpace) =
    log "Graph list"
    let edgeListing (edges : Edge list) =
        edges 
        |> List.iter (fun e -> let n = e.To.Value.Value
                               printfn "\t(%s) %s (%s)" e.TypeName  n.Name n.TypeName)

    let listing (node : Node, edges : Edge list) =
        printfn "%s (%s)" node.Name node.TypeName
        edgeListing edges

    let edges = 
        use scope = new SparxSpace(space)
        query { for e in scope.Edges do
                where (e.TypeName.StartsWith ("EA-Package")) 
                select e}
        |> Seq.filter   (fun e -> not (e.From.Value.Value = null))
        |> Seq.toList
        |> List.map     (fun e -> ignore e.From.Value.Value     // touch references to escape scope
                                  ignore e.To.Value.Value
                                  e)
        |> List.groupBy (fun e -> e.From.Value.Value)
    
    edges
    |> List.iter    listing
        
let nodes (space : SparxSpace) (typename : string) =
    log "Nodes"
    query { for n in space.Nodes do
            where (n.TypeName.StartsWith(typename))
            select n }
    |> Seq.iter (fun n -> printfn """"Node", "%s", "%s", "%s" """ n.SKey n.Name n.TypeName)

let edges (space : SparxSpace) (typename : string) =
    log "Edges"
    query { for e in space.Edges do
            where (e.TypeName.StartsWith(typename))
            select e }
    |> Seq.iter (fun e -> printfn """"Edge", "%s", "%s", "%s", "%s", "%s" """ e.SKey e.Name e.From.Value.Key.SKey e.To.Value.Key.SKey e.TypeName)

let savejson prefix (package : Package) = 
    log $"Saving {package.Name}"

    let options = JsonSerializerOptions()
    options.ReferenceHandler <- ReferenceHandler.Preserve
    options.WriteIndented <- true
    options.Converters.Add(SetSpaceConverter())
    options.Converters.Add(KeyRefConverter())
    use file = new FileStream(prefix + $"{package.Name}.json", FileMode.OpenOrCreate)
    JsonSerializer.Serialize (file, package, options);

let NV (v : 'v) = System.Nullable<'v> (v)

/// Hiperspace loader
let jsonrocks (space : SparxSpace) =
    log $"Json rocks"
    let id = NV 0
    query {for p in space.Packages do
            where (p.ParentId = id)
            select p}
    |> Seq.iter (savejson "R")

let sqlGraph (ctx : Context) = 
    log $"SQL graph"
    let withOperations (e : Element) =
        query {for o in ctx.ElementOperations.AsNoTracking() do
                where (o.ObjectId = e.Id.Value)
                select o}
        |> Seq.toArray
        |> fun c -> e.DBOperations <- c
        e
    let withAttributes (e: Element) =
        query {for a in ctx.Attributes.AsNoTracking() do
                where (a.ObjectId = e.Id.Value)}
        |> Seq.toArray
        |> fun c -> e.DBAttributes <- c
        e

    let withElements (p : Package) =
        query {for e in ctx.Elements.AsNoTracking() do
                where (e.PackageId = p.Id)
                select e}
        |> Seq.toArray
        |> Array.map withOperations
        |> Array.map withAttributes
        |> fun c -> p.DBContent <- c
        p
   
    let rec withChilden (p : Package) =

        query {for c in ctx.Packages.AsNoTracking() do
                where (c.ParentId = p.Id)
                select c}
        |> Seq.toArray
        |> Array.map withChilden
        |> Array.map withElements
        |> fun c -> p.DBChildren <- c
        p

    let id = NV 1
    query {for p in ctx.Packages.AsNoTracking() do
            where (p.Id = id)
            select p}
    |> Seq.head
    |> withChilden
/// SQL Loader
let jsonsql (ctx : Context) =
    log $"Json SQL"
    sqlGraph ctx
    |> (savejson "S")

let rec count (package : Package) =
    let elementCount (element : Element) =
        Seq.length element.Attributes +
        Seq.length element.Operations 
    let withContent (p : Package)  =
        p, p.Content |> Seq.map elementCount |> Seq.fold (fun a i -> a + i) 0

    package.Children
    |> Seq.map  withContent
    |> Seq.map  (fun (p,c) -> (count p) + c)
    |> Seq.fold (fun a i -> a + i) 0

let countrocks (space : SparxSpace) = 
    let id = NV 1
    query {for p in space.Packages do
            where (p.Id = id)
            select p} 
    |> Seq.head
    |> count
    |> fun c -> log $"Count of objects is {c}"

let countsql (ctx : Context ) = 
    let id = NV 1
    sqlGraph ctx
    |> count
    |> fun c -> log $"Count of objects is {c}"


/// extract one object without traveral
let oneVistor  (space : SparxSpace) =
    log "One Visitor"
    let incl (set : ('t -> RefSet<'i>)) (op : ('i -> unit)) (self : 't) =
        set self |> Seq.iter op
        self
    let visitor : Element = 
        use scope = new SparxSpace (space)
        query { for element in scope.EAElements do
                 where (element.Name = "Visitor" && element.ObjectType = "Class")
                 select element}
        |> Seq.head
        |> incl (fun e -> e.Attributes) (fun a -> ignore a.Tags )
//        |> incl (fun e -> e.Operations) (fun o -> ignore o.Tags )
//        |> incl (fun e -> e.Operations) (fun o -> ignore o.Parameters)
    let options = JsonSerializerOptions()
    options.ReferenceHandler <- ReferenceHandler.Preserve
    options.WriteIndented <- true
    options.DefaultIgnoreCondition <- JsonIgnoreCondition.WhenWritingNull
    options.Converters.Add(SetSpaceConverter())
    options.Converters.Add(KeyRefConverter())
    printfn "%s" (JsonSerializer.Serialize (visitor, options));
    log "End One Visitor"
