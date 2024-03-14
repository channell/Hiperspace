module Location.Tests

open System
open Xunit
open Hiperspace.Heap
open Hiperspace
open FluentAssertions
open System.IO
open Hiperspace.Rocks

[<Fact>]
let ``Nearest test`` () =
    
    let heap = new HeapSpace ()
    let space = new LocationSpace (heap)

    let countries =
      [
        "England"
        "Scotland"
        "Wales"
        "France"
      ]
      |> List.map (fun i -> Country ( Code = i))
      |> List.map (fun i -> space.Countrys.Bind i)
      |> List.map (fun i -> i.Value.Code, i.Value)
      |> Map.ofList

    let airport (country, code, latitude : single, longitude : single) =
        Airport
          (
            Country = countries[country].self,
            Code = code,
            VectorSpace = AirportVectorSpace
              (
                Vector = Vector ([|latitude;longitude|])
              )
           )
        
    let airports =
      [
        ("England", "Heathrow", 51.47070850261983f, -0.4593255939442451f)
        ("England", "Gatwick", 51.15625995155483f, -0.20662776663278873f)
        ("England", "Stanstead", 51.888253277860294f, 0.23988628361277178f)
        ("England", "Luton", 51.87890706525595f, -0.37261716988618604f)
        ("England", "Southend", 51.572103714634935f, 0.6940022738051255f)
      ]
      |> List.map airport
      |> List.map (fun i -> space.Airports.Bind i)
      |> List.map (fun i -> i.Value.Code, i.Value)
      |> Map.ofList

    let theMonument = 
        Vector [|51.51020425941176f; -0.08595773888870796f|]

    let nearst = 
        space.Airports.Nearest (Airport (Country = Country( Code = "England").self), theMonument, Vector.Method.Distance, 1)
        |> Seq.head

    let nearairport = fst (nearst.ToTuple())

    nearairport.Code.Should().Be("Gatwick", "Clsoest airport") |> ignore

[<Fact>]
let ``Nearest Rocks test`` () =
    
    if not (Directory.Exists("./rockstest")) then Directory.CreateDirectory("./rockstest") |> ignore
    if Directory.Exists("./rockstest/Nearest") then Directory.Delete("./rockstest/Nearest", true)

    let rocks = new RockSpace("./rockstest/Nearest")
    let space = new LocationSpace (rocks)

    let countries =
      [
        "England"
        "Scotland"
        "Wales"
        "France"
      ]
      |> List.map (fun i -> Country ( Code = i))
      |> List.map (fun i -> space.Countrys.Bind i)
      |> List.map (fun i -> i.Value.Code, i.Value)
      |> Map.ofList

    let airport (country, code, latitude : single, longitude : single) =
        Airport
          (
            Country = countries[country].self,
            Code = code,
            VectorSpace = AirportVectorSpace
              (
                Vector = Vector ([|latitude;longitude|])
              )
           )
        
    let airports =
      [
        ("England", "Heathrow", 51.47070850261983f, -0.4593255939442451f)
        ("England", "Gatwick", 51.15625995155483f, -0.20662776663278873f)
        ("England", "Stanstead", 51.888253277860294f, 0.23988628361277178f)
        ("England", "Luton", 51.87890706525595f, -0.37261716988618604f)
        ("England", "Southend", 51.572103714634935f, 0.6940022738051255f)
      ]
      |> List.map airport
      |> List.map (fun i -> space.Airports.Bind i)
      |> List.map (fun i -> i.Value.Code, i.Value)
      |> Map.ofList

    let theMonument = 
        Vector [|51.51020425941176f; -0.08595773888870796f|]

    let nearst = 
        space.Airports.Nearest (Airport (Country = Country( Code = "England").self), theMonument, Vector.Method.Distance, 1)
        |> 
        Seq.head

    let nearairport = fst (nearst.ToTuple())

    nearairport.Code.Should().Be("Gatwick", "Clsoest airport") |> ignore

