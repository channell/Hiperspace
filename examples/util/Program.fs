// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
module util

open Argu
open System
open Microsoft.EntityFrameworkCore
open Sparx
open Sparx.EA
open Hiperspace.Rocks
open System.IO
open Log

type Arguments =
    | [<Unique>]    Path    of path : string 
    | [<Unique>]    Connect of connect :string
    | [<Unique>]    Port    of port :string
    | [<Unique>]    Load
    | [<Unique>]    Listing
    | [<Unique>]    Graph
    | [<Unique>]    Tree
    | [<Unique>]    Json
    | [<Unique>]    JsonSQL
    | [<Unique>]    Count
    | [<Unique>]    CountRemote
    | [<Unique>]    CountSQL
    | [<Unique>]    Update 
    | [<Unique>]    UpdateSQL
    | [<Unique>]    Nodes   of typename : string
    | [<Unique>]    Edges   of typename : string
    | [<Unique>]    Sample

    

    interface IArgParserTemplate with
        member s.Usage =
            match s with
            | Path _        -> "RocksDB path"
            | Connect _     -> "SQL Server connect string"
            | Port _        -> "port for remote connection"
            | Load          -> "Load hiperspace from SQL"
            | Listing       -> "List the content of the hiperspace"
            | Graph         -> "List the content of the hiperspace as a graph"
            | Tree          -> "List the content of the hiperspace as a graph tree"
            | Json          -> "write hiperspace to a file"
            | JsonSQL       -> "write SQL database model to a file"
            | Count         -> "count the objects in the hiperspace"
            | CountRemote   -> "count the objects in the remote hiperspace"
            | CountSQL      -> "count the objects in the SQL"
            | Update        -> "update 'Visitor' to 'Approved'"            
            | UpdateSQL     -> "update SQL 'Visitor' to 'Approved'"
            | Nodes _       -> "listing of nodes by type name"
            | Edges _       -> "listing of edges by type name"
            | Sample        -> "list a sample item without traversal"

[<EntryPoint>]
let main argv = 
    let cmdLine = 
        let errorHandler = ProcessExiter(colorizer = function ErrorCode.HelpText -> None | _ -> Some ConsoleColor.Red)
        ArgumentParser.Create<Arguments>(programName = "util", errorHandler = errorHandler)

    let results = cmdLine.ParseCommandLine argv
  
    let ctx = lazy (
        log "Opening database"
        let con = results.GetResult Connect
        let bld = 
            (new DbContextOptionsBuilder<Context> ()).UseSqlServer (con)
        new Context (bld.Options))

    let rocks = lazy (
        log "Opening RocksDB"
        let path = results.GetResult Path
        if not (Directory.Exists(path)) then Directory.CreateDirectory(path) |> ignore;
        new SparxSpace (new RockSpace (path, MetaModel())))

    let remote = lazy (
        log "Opening Remote RocksDB"
        let path = results.GetResult Path
        let port =  results.GetResult Port
        let remote = new Hiperspace.Remote.RemoteSpace (path, MetaModel(), port, "root", Guid.NewGuid(), true)
        new SparxSpace (remote))


    if results.Contains Load        then loader.load (rocks.Value) (ctx.Value)
    if results.Contains Listing     then export.listing (rocks.Value)
    if results.Contains Graph       then export.graphListing (rocks.Value)
    if results.Contains Tree        then export.GraphTree (rocks.Value)
    if results.Contains Json        then export.jsonrocks (rocks.Value)    
    if results.Contains JsonSQL     then export.jsonsql (ctx.Value)
    if results.Contains Count       then export.countrocks (rocks.Value)
    if results.Contains CountRemote then export.countremote (remote.Value)
    if results.Contains CountSQL    then export.countsql (ctx.Value)
    if results.Contains Update      then updates.update (rocks.Value)
    if results.Contains UpdateSQL   then updates.updateSQL (ctx.Value)
    if results.Contains Nodes       then export.nodes (rocks.Value) (results.GetResult Nodes)
    if results.Contains Edges       then export.edges (rocks.Value) (results.GetResult Edges)
    if results.Contains Sample      then export.oneVistor (rocks.Value) 
    log "Finish"

    0
