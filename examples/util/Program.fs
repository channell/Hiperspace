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
open Microsoft.Data.SqlClient
open Microsoft.EntityFrameworkCore
open Sparx
open Sparx.EA
open Hiperspace.Rocks
open System.IO
open Log

type Arguments =
    | [<Mandatory>] Path    of path : string 
    | [<Mandatory>] Connect of connect :string
    | [<Unique>]    Load
    | [<Unique>]    Listing
    | [<Unique>]    Graph
    | [<Unique>]    Json
    | [<Unique>]    JsonSQL
    | [<Unique>]    Count
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
            | Load          -> "Load hiperspace from SQL"
            | Listing       -> "List the content of the hiperspace"
            | Graph         -> "List the content of the hiperspace as a graph"
            | Json          -> "write hiperspace to a file"
            | JsonSQL       -> "write SQL database model to a file"
            | Count         -> "count the objects in the hiperspace"
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
  
    use ctx = 
        log "Opening database"
        let con = results.GetResult Connect
        let bld = 
            (new DbContextOptionsBuilder<Context> ()).UseSqlServer (con)
        new Context (bld.Options)

    use rocks =
        log "Opening RocksDB"
        let path = results.GetResult Path
        if not (Directory.Exists(path)) then Directory.CreateDirectory(path) |> ignore;
        new SparxSpace (new RockSpace (path, MetaModel()))


    if results.Contains Load        then loader.load rocks ctx
    if results.Contains Listing     then export.listing rocks
    if results.Contains Graph       then export.graphListing rocks
    if results.Contains Json        then export.jsonrocks rocks    
    if results.Contains JsonSQL     then export.jsonsql ctx
    if results.Contains Count       then export.countrocks rocks
    if results.Contains CountSQL    then export.countsql ctx
    if results.Contains Update      then updates.update rocks
    if results.Contains UpdateSQL   then updates.updateSQL ctx
    if results.Contains Nodes       then export.nodes rocks (results.GetResult Nodes)
    if results.Contains Edges       then export.edges rocks (results.GetResult Edges)
    if results.Contains Sample      then export.oneVistor rocks 
    log "Finish"

    0
