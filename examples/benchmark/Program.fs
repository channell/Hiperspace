// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
module benchmark
// For more information see https://aka.ms/fsharp-console-apps
open Hiperspace.Rocks
open Sparx
open BenchmarkDotNet.Attributes
open Microsoft.EntityFrameworkCore
open Sparx.EA
open System.IO
open BenchmarkDotNet.Running
open Argu
open System

type Count () =

    let rocks = @"C:\Hiperspace\Sparx"
    let sql = @"Data Source=localhost;Initial Catalog=dotnet;User id=demo;Password=demo;MultipleActiveResultSets=True;Max Pool Size=100;TrustServerCertificate=True"

    [<Benchmark>]
    member _.CountRocks () =
        use space = 
            let ssd = new RockSpace(rocks, MetaModel(), false)
            new SparxSpace (ssd)
        export.countrocks space 

    [<Benchmark>]
    member _.CountSQL () =
        let ctx = 
            let bld = 
                (new DbContextOptionsBuilder<Context> ()).UseSqlServer (sql)
            new Context (bld.Options)
        export.countsql ctx


type Update () =

    let rocks = @"C:\Hiperspace\Sparx"
    let sql = @"Data Source=localhost;Initial Catalog=dotnet;User id=demo;Password=demo;MultipleActiveResultSets=True;Max Pool Size=100;TrustServerCertificate=True"

    [<Benchmark>]
    member _.UpdateRocks () =
        use space = 
            let ssd = new RockSpace(rocks, MetaModel())
            new SparxSpace (ssd)
        updates.update space 

    [<Benchmark>]
    member _.UpdateSQL () =
        let ctx = 
            let bld = 
                (new DbContextOptionsBuilder<Context> ()).UseSqlServer (sql)
            new Context (bld.Options)
        updates.updateSQL ctx

type Json () =

    let rocks = @"C:\Hiperspace\Sparx"
    let sql = @"Data Source=localhost;Initial Catalog=dotnet;User id=demo;Password=demo;MultipleActiveResultSets=True;Max Pool Size=100;TrustServerCertificate=True"

    [<Benchmark>]
    member _.JSONRocks () =
        let space = 
            let ssd = new RockSpace(rocks, MetaModel(), false)
            new SparxSpace (ssd)
        export.jsonrocks space 

    [<Benchmark>]
    member _.JSONSQL () =
        let ctx = 
            let bld = 
                (new DbContextOptionsBuilder<Context> ()).UseSqlServer (sql)
            new Context (bld.Options)
        export.jsonsql ctx

type Load () =

    let rocks = @"C:\Hiperspace\Sparx"
    let sql = @"Data Source=localhost;Initial Catalog=dotnet;User id=demo;Password=demo;MultipleActiveResultSets=True;Max Pool Size=100;TrustServerCertificate=True"

    [<Benchmark>]
    member _.Load () =
        if (Directory.Exists(rocks)) then Directory.Delete(rocks, true) |> ignore;
        Directory.CreateDirectory (rocks) |> ignore
        let space = 
            let ssd = new RockSpace(rocks, MetaModel())
            new SparxSpace (ssd)
        let ctx = 
            let bld = 
                (new DbContextOptionsBuilder<Context> ()).UseSqlServer (sql)
            new Context (bld.Options)
        loader.load space ctx

type Arguments =
| [<Unique>]    Count
| [<Unique>]    Update
| [<Unique>]    Json
| [<Unique>]    Load


  interface IArgParserTemplate with
    member s.Usage =
        match s with
        | Count         -> "Count benchmarks"
        | Update        -> "Count benchmarks"
        | Json          -> "Count benchmarks"
        | Load          -> "Count benchmarks"

[<EntryPoint>]
let main argv = 

    let cmdLine = 
        let errorHandler = ProcessExiter(colorizer = function ErrorCode.HelpText -> None | _ -> Some ConsoleColor.Red)
        ArgumentParser.Create<Arguments>(programName = "util", errorHandler = errorHandler)

    let results = cmdLine.ParseCommandLine argv

    if results.Contains Count   then BenchmarkRunner.Run<Count>() |> printfn "%A"
    if results.Contains Update  then BenchmarkRunner.Run<Update>() |> printfn "%A"
    if results.Contains Json    then BenchmarkRunner.Run<Json>() |> printfn "%A"
    if results.Contains Load    then BenchmarkRunner.Run<Load>() |> printfn "%A"
    0