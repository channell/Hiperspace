module Tests

open System
open Xunit
open System.IO
open Hiperspace
open FluentAssertions
open Xunit.Abstractions
open System.Text.Json
open System.Text.Json.Serialization

type  PlanTest (output : ITestOutputHelper) =

    do if Directory.Exists("./rockstest") then Directory.Delete("./rockstest", true) |> ignore
    let rocks = new Hiperspace.Rocks.RockSpace ("./rockstest")
//    let rocks = new Hiperspace.Heap.HeapSpace()
    let planSpace = new Plan.PlanSpace ( space = rocks, write = true)

    let nvl (v : 'v) = Nullable<'v> (v)

    let result (p : Result<'p>) = 
        p.Ok.Should().BeTrue("added") |> ignore
        p.Value

    let zeronull (v : Nullable<decimal>) = if v.HasValue then v.Value else 0m

    [<Fact>]
    member _.``test plan`` () =
        let make_resource name cost =
            Plan.Resource 
              (
                Name = name,
                Duration = Plan.Duration 
                  (
                    Start = DateTime(DateTime.Now.Year, 1, 1), 
                    End = DateTime(DateTime.Now.Year, 12, 1)
                  ),
                TimeCost = nvl cost
              )
            |> planSpace.Resources.Bind
            |> result

        let make_project name =
            Plan.Project
              (
                Id = new Guid ([|1uy;1uy;1uy;1uy;1uy;1uy;1uy;1uy;1uy;1uy;1uy;1uy;1uy;1uy;1uy;1uy;|]),
                Name = name,
                WBS = name,
                Duration = Plan.Duration 
                  (
                    Start = DateTime(DateTime.Now.Year, 1, 1), 
                    End = DateTime(DateTime.Now.Year, 12, 1)
                  )
              )
            |> planSpace.Projects.Bind
            |> result

        let rec make_task project id name start stop res =
            let task  =
                Plan.Tasks.Task
                  (
                    Id  = nvl id,
                    WBS = string id,
                    Project = project,
                    Name = name,
                    Duration = Plan.Duration
                      (
                        Start = nvl start,
                        End = nvl stop
                      ),
                    Cost = 0.0m
                  )
                |> planSpace.Tasks.Bind
                |> result

            let subtask (n,s,e) =
                Plan.Tasks.Task
                  (
                    Id  = nvl (n * 10 + id),
                    WBS = string n,
                    Project = project,
                    Name = $"{name}-{n}",
                    Duration = Plan.Duration
                      (
                        Start = nvl s,
                        End = nvl e
                      ),
                    Parent = task,
                    Cost = 0.0m
                  )
                |> planSpace.Tasks.Bind
                |> result
            let subtasks =
                [for w in 1.0..3.0 do
                  int w, start.AddDays (w * 7.), start.AddDays ((w * 7.) + 7.)
                ]
                |> List.map subtask

            let withr (t : Plan.Tasks.Task) = 
                t.Resources.Add (Plan.Tasks.TaskResource ( Resource = res))
                t

            task :: (subtasks |> List.map withr)

        let plan =
            ( "Sample",
              [
                ("Jan", 1)
                ("Feb", 2)
                ("Mar", 3)
                ("Apr", 4)
                ("May", 5)
                ("Jun", 6)
                ("Jul", 7)
                ("Aug", 8)
                ("Sep", 9)
              ]
            )
        let fred = make_resource "fred" 1000m
        (planSpace.Resources.Bind fred).Ok.Should().BeTrue("was added") |> ignore
        let p = make_project (fst plan)
        (planSpace.Projects.Bind p).Ok.Should().BeTrue("was added") |> ignore
        let task =
            (snd plan)
            |> List.map     (fun (s,n) -> make_task p n s (DateTime(DateTime.Now.Year, n, 1)) (DateTime(DateTime.Now.Year, n + 1, 1)) fred)
            |> List.fold    (fun a i -> i @ a) []
        let bireport (space : Plan.PlanSpace) =
            let bi =
                space.Items
                |> List.ofSeq

            output.WriteLine("WBS, TypeName, Name, PlanCost, ActualCost, ImpliedCost, PlanStart, PlanEnd")
            bi
            |> List.sortBy      (fun i -> i.WBS)
            |> List.iter        (fun i -> output.WriteLine ($"{i.WBS},{i.TypeName},{i.Name},{i.PlanCost}, {i.ActualCost}, {i.ImpliedCost}, {i.PlanStart.Value.ToShortDateString()},{i.PlanEnd.Value.ToShortDateString()}"))

            let exceptPlan =
                bi
                |> List.filter  (fun i -> not (i.TypeName = "Plan" ))
            let plancost, actualCost = 
                exceptPlan
                |> List.fold    (fun (ap, aa) i -> ap + (zeronull i.PlanCost) , aa + (zeronull i.ActualCost)) (0m, 0m)
            let proj = space.Projects.Get(p)
            let pacosts = proj.ActualCost.Value
            let ppcosts = proj.PlanCost.Value

            output.WriteLine($"Total: Project Plan Cost = {ppcosts}, BI Plan Cost = {plancost}, Project Actual Cost = {pacosts}, BI Actual Cost = {actualCost}")

            plancost.Should().Be(ppcosts, "equals") |> ignore
            actualCost.Should().Be(pacosts, "equals") |> ignore

        output.WriteLine($"\nBase planspace costs")
        bireport planSpace

        use snapbeforeTime = new Plan.PlanSpace(planSpace, true, DateTime.Now)

        let updateTasks =
            query {for t in planSpace.Tasks do
                    where (t.Name.EndsWith("-1"))
                    select t}
            |> List.ofSeq

        let addActual (task : Plan.Tasks.Task) plus  = 
            task.Resources.Refresh ()       // refresh triggers re-fetch for next reference
            task.Resources |> Seq.iter (fun r -> r.Timesheets.Refresh())
            let actual =
                Plan.Tasks.TaskActual 
                    (
                    owner = task,
                    Duration = task.Duration,
                    Close = DateTime(DateTime.Now.Year, 1, 1),
                    Cost = task.ImpliedCost 
                    )
                |> planSpace.TaskActuals.Bind
                |> result
            task.Actual <- actual
            actual

        let addTimeSheet (task : Plan.Tasks.Task) = 
            task.Resources.Refresh()
            let time =
                Booking.Timesheet
                  (
                    Resource = fred,
                    Task = task,
                    Date = task.Duration.Value.Start.Value.AddDays(1),
                    Time = 10m,
                    Estimate = task.Duration.Value.Time.Value - 10m, 
                    Comment = $"Timesheet for {fred.Name} / {task.Name}"
                  )
                |> planSpace.Timesheets.Bind
                |> result
            task.Resources.Refresh()
            let added = task.Resources |> List.ofSeq |> List.head |> fun r -> r.Timesheets |> List.ofSeq |> List.contains time
            //added.Should().BeTrue("added") |> ignore
            time

        updateTasks
        |> List.map addActual
        |> ignore

        updateTasks
        |> List.map addTimeSheet
        |> ignore

        use snapbeforeupdate = new Plan.PlanSpace(planSpace, true, DateTime.Now)

        updateTasks
        |> List.map addActual
        |> ignore

        output.WriteLine($"\nBase with actual and timesheets ")
        bireport planSpace

        output.WriteLine($"\nSnapshot excluding actual and timesheets - timesheets are displayed because they're external")
        bireport snapbeforeTime

        output.WriteLine($"\nSnapshot excluding updated actual ")
        bireport snapbeforeupdate

        use snapbase = new Plan.PlanSpace(planSpace)
        output.WriteLine($"\nBase including time and latest actual")
        bireport snapbase

        let rec print tabs (visited : Set<Node>) (n : Node) =
            let printEdges tabs (visited : Set<Node>) (n : Node)  =
                let printFrom tabs (visited : Set<Node>) (e : Edge) =
                    output.WriteLine ($"{tabs}Edge {{ From = {e.From.SKey}, To = {e.To.SKey}, Name = {e.Name}, TypeName = {e.TypeName}}}")
                    print ($"{tabs}\t") visited e.To
                n.Froms
                |> Seq.filter  (fun e -> not (e.From = null || e.To = null))
                |> List.ofSeq
                |> List.iter    (printFrom tabs visited)
            output.WriteLine ($"{tabs}Node {{ SKey = {n.SKey}, Name = {n.Name}, TypeName = {n.TypeName} }}")
            if not (visited.Contains n) then 
                let newVisited = visited |> Set.add n
                printEdges $"{tabs}\t" newVisited n

        let node = 
            query {for n in planSpace.Nodes do 
                   where (n.SKey = p.SKey)
                   select n}

            |> Seq.head

        
        print "" (Set.ofList []) node

          


