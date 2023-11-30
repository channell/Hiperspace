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

type Perf () =

    let rocks = @"C:\Hiperspace\Sparx"
    let sql = @"Data Source=localhost;Initial Catalog=dotnet;User id=demo;Password=demo;MultipleActiveResultSets=True;Max Pool Size=100;TrustServerCertificate=True"

    do 
      if (Directory.Exists(rocks)) then Directory.Delete(rocks, true) |> ignore;
      Directory.CreateDirectory (rocks) |> ignore

    let space = 
        let ssd = new RockSpace(rocks, MetaModel())
        new SparxSpace (ssd)
    let ctx = 
        let bld = 
            (new DbContextOptionsBuilder<Context> ()).UseSqlServer (sql)
        new Context (bld.Options)

    [<Benchmark>]
    member _.Load () =
        loader.load space ctx

    [<Benchmark>]
    member _.CountRocks () =
        export.countrocks space

    [<Benchmark>]
    member _.CountSQL () =
        export.countsql ctx

    [<Benchmark>]
    member _.UpdateRocks () =
        updates.update space

    [<Benchmark>]
    member _.UpdateSQL () =
        updates.updateSQL ctx

    [<Benchmark>]
    member _.JSONRocks () =
        export.jsonrocks space

    [<Benchmark>]
    member _.JSONSQL () =
        export.jsonsql ctx


[<EntryPoint>]
let main argv = 
    let summary = BenchmarkRunner.Run<Perf>() 
    0