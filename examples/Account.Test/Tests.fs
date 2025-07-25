module Acc.Tests

open System
open Xunit
open System.IO
open Hiperspace
open FluentAssertions
open Xunit.Abstractions
open Hiperspace.Meta
open System.Collections.Generic

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


type CustomerObserver (output : ITestOutputHelper) =

    interface IObserver<struct (Customer * DependencyPath)> with
        member this.OnCompleted(): unit = 
            ignore 1
        member this.OnError(error: exn): unit = 
            output.WriteLine $">> ERROR: {error.Message}"
        member this.OnNext(value: struct (Customer * DependencyPath)): unit = 
            let struct (node , source) = value
            let struct (node , source) = value
            let path =
                source.Path
                |> Seq.fold (fun a i -> if a = "" then i.GetType().Name else $"{a}, {i}" ) ""

            output.WriteLine $">> Change {node.Name} from {path}"

type  AccountTest (output : ITestOutputHelper) =

    do if Directory.Exists("./rockstest") then Directory.Delete("./rockstest", true) |> ignore

    let rocks = new Hiperspace.Rocks.RockSpace ("./rockstest")
    let accSpace = AccSpace.Make(rocks)

    let nvl (v : 'v) = Nullable<'v> (v)

    let result (p : Result<'p>) = 
        p.Ok.Should().BeTrue("added") |> ignore
        p.Value

    let zeronull (v : Nullable<decimal>) = if v.HasValue then v.Value else 0m

    [<Fact>]
    member _.``test acc`` () =
        use subscription = accSpace.Dependencies.Subscribe<Customer> (CustomerObserver output)

        let cust = Customer ( Name = "Fred")
        let acc  = CustomerAccount ( owner = cust, Title = "Freds")
        cust.Accounts.Add acc
        acc.Balance <- CustomerAccountBalance ( When = DateTime.UtcNow, Current = 0m)

        accSpace.Customers.Add cust |> ignore

        for n in [0m..4m] do
            let tran = CustomerAccountTransaction ( owner = acc, At = DateTime.Now, Payee = $"Payee {n}", Amount = n )
            acc.Transactions.Add tran |> ignore
            
        output.WriteLine "Name, Title, At, Movement, AsAt"
        let trans = List.ofSeq accSpace.CustomerAccountTransactions
        trans.Length.Should().Be(5, "") |> ignore
        for n in trans do
            sprintf "%s, %s, %s, %s, %M, %s" n.owner.owner.Name n.owner.Title (n.At.Value.ToString()) n.Payee (n.Amount.Value) (n.AsAt.ToString()) |> output.WriteLine

        let beforeAdd = DateTime.Now

        Threading.Thread.Sleep(1000)
        output.WriteLine "\nAdd a penny"
        for n in accSpace.CustomerAccountTransactions do
            let a = CustomerAccountTransaction(n)
            a.Amount <- n.Amount.Value + 0.01m
            acc.Transactions.Add a

        output.WriteLine "Name, Title, At, Movement, AsAt (after amend)"
        let trans = List.ofSeq accSpace.CustomerAccountTransactions
        trans.Length.Should().Be(5, "") |> ignore
        for n in trans do
            sprintf "%s, %s, %s, %s, %M, %s" n.owner.owner.Name n.owner.Title (n.At.Value.ToString()) n.Payee (n.Amount.Value) (n.AsAt.ToString()) |> output.WriteLine

        output.WriteLine "\nName, Title, At, Movement, AsAt (after rollup)"
        acc.Rollup()
        let trans = List.ofSeq accSpace.CustomerAccountTransactions
        trans.Length.Should().Be(0, "Hidden by rollup") |> ignore
        acc.Balance.Current.Should().Be(10.05m, "include pennies") |> ignore

        for n in trans do
            sprintf "%s, %s, %s, %s, %M, %s" n.owner.owner.Name n.owner.Title (n.At.Value.ToString()) n.Payee (n.Amount.Value) (n.AsAt.ToString()) |> output.WriteLine
        sprintf "prior Balance : %M" acc.Balance.Current.Value |> output.WriteLine

        output.WriteLine "\nBefore snapshot"
        output.WriteLine "Name, Title, At, Movement, AsAt "
        use snap = new AccSpace(accSpace, null, beforeAdd)

        let trans = List.ofSeq snap.CustomerAccountTransactions
        trans.Length.Should().Be(5, "") |> ignore

        for n in snap.CustomerAccountTransactions do
            sprintf "%s, %s, %s, %s, %M, %s" n.owner.owner.Name n.owner.Title (n.At.Value.ToString()) n.Payee (n.Amount.Value) (n.AsAt.ToString()) |> output.WriteLine
        let spanAcc = snap.CustomerAccounts.Get(acc)
        sprintf "prior Balance : %M" spanAcc.Balance.Current.Value |> output.WriteLine
        spanAcc.Balance.Current.Should().Be(0m, "not rolled up") |> ignore

        Threading.Thread.Sleep(1000)
        let beforeDelta = DateTime.Now
        Threading.Thread.Sleep(1000)
        output.WriteLine "\nAdd a penny"
        for n in snap.CustomerAccountTransactions do
            if (match n.Payee with | "Payee 0" | "Payee 1" -> true | _ -> false) then
                let a = CustomerAccountTransaction (Payee = n.Payee, Amount = n.Amount.Value + 0.02m, At = DateTime.Now)
                acc.Transactions.Add a

        use delta = new AccSpace(accSpace, null, Nullable<DateTime>(), beforeDelta)

        let trans = List.ofSeq delta.CustomerAccountTransactions
        trans.Length.Should().Be(2, "") |> ignore

        output.WriteLine $"\nDelta from {beforeDelta}"
        output.WriteLine "At, Movement, AsAt "
        for n in delta.CustomerAccountTransactions do
            sprintf "%s, %s, %M, %s"  (n.At.Value.ToString()) n.Payee (n.Amount.Value) (n.AsAt.ToString()) |> output.WriteLine

        let engine = SQL.Engine(accSpace)

        let dd = engine.Execute("select * from SCHEMA_TABLES; select * from SCHEMA_COLUMNS; SELECT * FROM SCHEMA_PROPERTIES;", null)
        output.WriteLine( markdown dd)

        let result = engine.Execute("select * from CustomerAccounts; select * from Customers; select * from CustomerAccountTransactions;", null)
        output.WriteLine( markdown result)

    [<Fact>]
    member _.``test add account`` () =

        let donald = (accSpace.Customers.Bind (Customer ( Name = "Donald"))).Value
        donald.Accounts.Add (CustomerAccount ( Title = "Donalds"))
        let donalds = accSpace.CustomerAccounts.Find (new CustomerAccount (owner = donald)) |> Seq.tryHead
        donalds.IsSome.Should().BeTrue("added") |> ignore
        donalds.Value.Title.Should().Be("Donalds", "added") |> ignore
