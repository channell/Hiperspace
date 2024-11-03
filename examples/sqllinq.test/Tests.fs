module Tests

open System
open Xunit
open Xunit.Abstractions
open Hiperspace
open Hiperspace.Sparx
open Hiperspace.Rocks
open System.Collections.Generic
open System.Linq
open Microsoft.FSharp.Linq   
open SQLLinq
open FSharp.Compiler.Interactive.Shell
open FSharp.Compiler.Tokenization

open System
open System.IO
open System.Text

let kv (k : string, v : obj) = KeyValuePair(k,v)

let sqlquery (space : Sparx.SparxSpace) =
    (query 
    { for p1 in space.Packages do 
      where (p1.Name = "dotnet") 
      select {| Name = p1.Name; Notes = p1.Notes; ModifiedDate = p1.ModifiedDate; GUID = p1.GUID |}  })
     .Union (query 
    { for p2 in space.Packages do 
      where (p2.Name = "java") 
      select {| Name = p2.Name; Notes = p2.Notes; ModifiedDate = p2.ModifiedDate; GUID = p2.GUID |}  })

let tq (space : Sparx.SparxSpace) =
    space.Packages
     .Where(fun p -> p.Name = "dotnet").Select(fun p -> {| Name = p.Name; Notes = p.Notes; ModifiedDate = p.ModifiedDate; GUID = p.GUID |})
     .Union( 
        space.Packages
         .Where(fun p -> p.Name = "java")
         .Select(fun p -> {| Name = p.Name; Notes = p.Notes; ModifiedDate = p.ModifiedDate; GUID = p.GUID |})
   

let markdown (source : IDictionary<string, obj array> array) =
    let asMarkDown (source : IDictionary<string, obj array>) = 
        let asArray = 
            source
            |> Seq.map  (fun kv -> (kv.Key, kv.Value |> Array.map (fun i -> if i <> null then i.ToString() else "")))
            |> Array.ofSeq

        let colwidths =
            asArray 
            |> Array.map    (fun (k,v) -> v |> Array.fold (fun a i -> if i.Length > a then i.Length else a) 0)
            |> Array.mapi   (fun n i -> if i < (fst asArray[n]).Length then (fst asArray[n]).Length else i)

        let collength =
            asArray 
            |> Array.fold (fun a (k,v) -> if a = 0 then v.Length elif a > v.Length then a else v.Length) 0

        let sb = System.Text.StringBuilder()

        asArray |> Array.iteri      (fun n (k,v) -> sb.Append("|").Append(k).Append(' ', colwidths[n] - k.Length) |> ignore)
        sb.AppendLine("|") |> ignore
        colwidths |> Array.iter     (fun i -> sb.Append("|").Append('-', i) |> ignore)
        sb.AppendLine("|") |> ignore

        for r in 0..(collength - 1) do
            for c in 0..(colwidths.Length - 1) do
                sb.Append("|") |> ignore
                let i = (snd asArray[c])[r]
                sb.Append(i) |> ignore
                sb.Append(' ', (colwidths[c] - i.Length)) |> ignore
            sb.AppendLine("|") |> ignore

        sb.ToString()
    source |> Array.fold (fun a i -> a + asMarkDown i) ""

(* let sqlquery (space : Sparx.SparxSpace) =
    (query { for p1 in space.Packages do 
             where (p1.Name = "dotnet") 
             select {| Name = p1.Name; Notes = p1.Notes; ModifiedDate = p1.ModifiedDate; GUID = p1.GUID |} })
           .Union (query { for p2 in space.Packages do 
                           where (p2.Name = "java") 
                           select {| Name = p2.Name; Notes = p2.Notes; ModifiedDate = p2.ModifiedDate; GUID = p2.GUID |} })

*)

type Tests (output : ITestOutputHelper) =

    // Initialize output and input streams
    let sbOut = new StringBuilder()
    let sbErr = new StringBuilder()
    let inStream = new StringReader("")
    let outStream = new StringWriter(sbOut)
    let errStream = new StringWriter(sbErr)

    // Build command line arguments & start FSI session
    let argv = [| "C:\\fsi.exe" |]

    let allArgs =
        Array.append argv [| "--noninteractive" |]

    let fsiConfig =
        FsiEvaluationSession.GetDefaultConfiguration()

    let fsiSession =
        FsiEvaluationSession.Create(fsiConfig, allArgs, inStream, outStream, errStream)

    let driver = new RockSpace (@"C:\Hiperspace\Sparx", read = true)
    let space = new Sparx.SparxSpace(driver)
    let sql = new SQL.Engine(space)

    let sqllinq = new SQLLinq.Engine(space, fsiSession)

    [<Fact>]
    member _.``test schema`` () =

        let parameters = Dictionary<string,obj> ()

        let result = sql.Execute ("""
select t.TABLE_NAME from SCHEMA_TABLES AS t where t.TABLE_NAME = 'Packages';
select t.TABLE_NAME, t.COLUMN_NAME from SCHEMA_COLUMNS as t where t.TABLE_NAME = 'Packages';"""  , parameters)
    
        output.WriteLine(markdown result)

    [<Fact>]
    member _.``SQL test1`` () =

        let parameters = Dictionary<string,obj> ((seq { kv ("name", "dotnet")}))

        let result = sql.Execute("SELECT Name, Notes, ModifiedDate, GUID FROM Packages where Name = :name;", parameters)
        output.WriteLine(markdown result)

    [<Fact>]
    member _.tt () =
        let cnt (l : 't seq) = l |> Seq.length

        space.Packages.Find (new Sparx.EA.Package(Name = "dotnet")) 
        |> Seq.iter (fun p -> output.WriteLine($"{p.Name} {cnt p.Children}"))

        let q = query {
            for p in space.Packages do
            join p2 in space.Packages on (p.Id = p2.Parent_Id)
            where (p.Name = "dotnet")
            groupBy p.Id into GROUP
            select (GROUP.Key, GROUP.Count())
        }
        q |> Seq.iter (fun (k,v) -> output.WriteLine($"{k} {v}"))

    [<Fact>]
    member _.``SQL test1 f`` () =

        let fs = sqllinq.Code ("SELECT Name, Notes, ModifiedDate, GUID FROM Packages where Name = 'dotnet';")
        fs 
        |> List.iter (fun i -> output.WriteLine(i))
    [<Fact>]
    member _.``SQL test2`` () =

        let parameters = Dictionary<string,obj> ((seq { kv ("name", "dotnet")}))

        let result = sql.Explain("""
SELECT p.Name, p.Notes, p.ModifiedDate, p.GUID, count(p2.Id) as Children
FROM Packages as p join Packages as p2 on p.Id = p2.Parent_Id
where p.Name = 'dotnet'
group by p.Id, p.Name, p.Notes, p.ModifiedDate, p.GUID
"""         , parameters)
        result |> Array.iter (fun i -> output.WriteLine(i))

        let result = sql.Execute("""
SELECT p.Name, p.Notes, p.ModifiedDate, p.GUID, count(p2.Id) as Children
FROM Packages as p join Packages as p2 on p.Id = p2.Parent_Id
where p.Name = 'dotnet'
group by p.Id, p.Name, p.Notes, p.ModifiedDate, p.GUID
"""         , parameters)
        output.WriteLine(markdown result)

    [<Fact>]
    member _.``SQL test2 f`` () =

        let fs = sqllinq.Code ("""
SELECT p.Name, p.Notes, p.ModifiedDate, p.GUID, count(p2.Id) as Children
FROM Packages as p join Packages as p2 on p.Id = p2.Parent_Id
where p.Name = 'dotnet'
group by p.Id, p.Name, p.Notes, p.ModifiedDate, p.GUID
;"""        )
        fs 
        |> List.iter (fun i -> output.WriteLine(i))


    [<Fact>]
    member _.``SQL union`` () =

        let parameters = Dictionary<string,obj> ((seq { kv ("name", "dotnet")}))
        let src = $"""
SELECT p1.Name, p1.Notes, p1.ModifiedDate, p1.GUID FROM Packages as p1 where p1.Name = 'dotnet'
union
SELECT p2.Name, p2.Notes, p2.ModifiedDate, p2.GUID FROM Packages as p2 where p2.Name = 'java'
;
        """

        let explain = sql.Explain(src, parameters)
        explain |> Array.iter (fun i -> output.WriteLine(i))

        let result = sql.Execute(src, parameters)
        output.WriteLine(markdown result)

    [<Fact>]
    member _.``SQL union f`` () =

        let parameters = Dictionary<string,obj> ((seq { kv ("name", "dotnet")}))
        let src = $"""
SELECT p1.Name, p1.Notes, p1.ModifiedDate, p1.GUID FROM Packages as p1 where p1.Name = 'dotnet'
union
SELECT p2.Name, p2.Notes, p2.ModifiedDate, p2.GUID FROM Packages as p2 where p2.Name = 'java'
;
        """

        let fs = sqllinq.Code(src)
        fs 
        |> List.iter (fun i -> output.WriteLine(i))

//    member _.``tt`` () =
