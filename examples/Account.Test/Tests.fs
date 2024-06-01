module Acc.Tests

open System
open Xunit
open System.IO
open Hiperspace
open FluentAssertions
open Xunit.Abstractions


type  PlanTest (output : ITestOutputHelper) =

    do if Directory.Exists("./rockstest") then Directory.Delete("./rockstest", true) |> ignore
    let rocks = new Hiperspace.Rocks.RockSpace ("./rockstest")
    let accSpace = new AccSpace(rocks)

    let nvl (v : 'v) = Nullable<'v> (v)

    let result (p : Result<'p>) = 
        p.Ok.Should().BeTrue("added") |> ignore
        p.Value

    let zeronull (v : Nullable<decimal>) = if v.HasValue then v.Value else 0m

    [<Fact>]
    member _.``test acc`` () =

        let cust = Customer ( Name = "Fred")
        let acc  = CustomerAccount ( owner = cust, Title = "Freds")
        cust.Accounts.Add acc
        acc.Balance <- CustomerAccountBalance ( When = DateTime.UtcNow, Current = 0m)

        accSpace.Customers.Add cust |> ignore

        for n in [0m..4m] do
            let tran = CustomerAccountTransaction ( owner = acc, At = DateTime.Now, Payee = $"Payee {n}", Movement = n )
            acc.Transactions.Add tran |> ignore
            
        output.WriteLine "Name, Title, At, Movement"
        let trans = List.ofSeq accSpace.CustomerAccountTransactions
        trans.Length.Should().Be(5, "") |> ignore
        for n in trans do
            sprintf "%s, %s, %s, %s, %M" n.owner.owner.Name n.owner.Title (n.At.Value.ToString()) n.Payee (n.Movement.Value) |> output.WriteLine

        let beforeAdd = DateTime.Now

        Threading.Thread.Sleep(1000)
        output.WriteLine "\nAdd a penny"
        for n in accSpace.CustomerAccountTransactions do
            let a = CustomerAccountTransaction(n)
            a.Movement <- n.Movement.Value + 0.01m
            acc.Transactions.Add a

        output.WriteLine "Name, Title, At, Movement (after amend)"
        let trans = List.ofSeq accSpace.CustomerAccountTransactions
        trans.Length.Should().Be(5, "") |> ignore
        for n in trans do
            sprintf "%s, %s, %s, %s, %M" n.owner.owner.Name n.owner.Title (n.At.Value.ToString()) n.Payee (n.Movement.Value) |> output.WriteLine

        output.WriteLine "\nName, Title, At, Movement (after rollup)"
        acc.Rollup()
        let trans = List.ofSeq accSpace.CustomerAccountTransactions
        trans.Length.Should().Be(0, "Hidden by rollup") |> ignore
        acc.Balance.Current.Should().Be(10.05m, "include pennies") |> ignore

        for n in trans do
            sprintf "%s, %s, %s, %s, %M" n.owner.owner.Name n.owner.Title (n.At.Value.ToString()) n.Payee (n.Movement.Value) |> output.WriteLine
        sprintf "prior Balance : %M" acc.Balance.Current.Value |> output.WriteLine

        output.WriteLine "\nBefore snapshot"
        output.WriteLine "\nName, Title, At, Movement "
        use snap = new AccSpace(accSpace, beforeAdd)

        let trans = List.ofSeq snap.CustomerAccountTransactions
        trans.Length.Should().Be(5, "") |> ignore

        for n in snap.CustomerAccountTransactions do
            sprintf "%s, %s, %s, %s, %M" n.owner.owner.Name n.owner.Title (n.At.Value.ToString()) n.Payee (n.Movement.Value) |> output.WriteLine
        let spanAcc = snap.CustomerAccounts.Get(acc)
        sprintf "prior Balance : %M" spanAcc.Balance.Current.Value |> output.WriteLine
        spanAcc.Balance.Current.Should().Be(0m, "not rolled up") |> ignore

