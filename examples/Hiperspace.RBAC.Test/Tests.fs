module Tests

open System
open Xunit
open Hiperspace
open FluentAssertions
open Xunit.Abstractions
open Access

type RBACTest (output : ITestOutputHelper) =

    let nvl (v : 'v) = Nullable<'v> (v)

    let result (p : Result<'p>) = 
        p.Ok.Should().BeTrue("added") |> ignore
        p.Value

    let resultMsg (msg : 'p -> string) (p : Result<'p>) = 
        if p.Fail then  output.WriteLine (msg p.Value)
        p.Ok.Should().BeTrue(msg p.Value) |> ignore
        p.Value

    let zeronull (v : Nullable<decimal>) = if v.HasValue then v.Value else 0m

    let IloadSpace () = 
        let heap = new Hiperspace.Heap.HeapSpace ()
        let access = new Access.AccessSpace (heap)

        let realmseed =
            Access.RBAC.Realm 
              (
                Name = "Access", 
                Valid = true
              )

        let seed = 
            Access.RBAC.User 
              (
                Realm = realmseed,
                Id = Guid.NewGuid(),
                Name = "Admin",  
                PublicKey = "some",
                Valid = true
              )
            |> access.Users.Bind
            |> result

        let realm =
            Access.RBAC.Realm 
              (
                Name = "Access", 
                Valid = true,
                Author = seed
              )
            |> access.Realms.Bind
            |> result

        let admins = 
            Access.RBAC.Group 
              (
                Id = Guid.NewGuid(),
                Name = "Administrators", 
                Realm = realm, 
                Author = seed,
                Valid = true
              )
            |> access.Groups.Bind
            |> result

        let approval =
            System.Collections.Generic.HashSet<RefGroup> ( seq { RefGroup ( Value = admins ) })
               
        let admin = 
            Access.RBAC.User 
              ( 
                seed,
                Realm = realm,
                Group = admins,
                Author = seed
              )
            |> access.Users.Bind
            |> result

        let adminVersions =
            admin.GetVersions()
            |> List.ofSeq

        let items =
          [
            Access.RBAC.Resource ( Subject = "RBAC-Realm", Author = admin, Valid = true)
            Access.RBAC.Resource ( Subject = "RBAC-Permission", Author = admin, Valid = true )
            Access.RBAC.Resource ( Subject = "RBAC-User", Author = admin, Valid = true )
            Access.RBAC.Resource ( Subject = "RBAC-Group", Author = admin, Valid = true )
          ]
          |> List.map access.Resources.Bind
          |> List.map result

        let permission (item : Access.RBAC.Resource) =
            Access.RBAC.GroupPermission 
              ( 
                Item = item,   
                Right = Access.RBAC.PermissionType.All,
                owner = admins,
                Approval = approval,
                Required = approval,
                Author = admin,
                Valid = true
              )
            |> access.GroupPermissions.Bind
            |> result

        let permissions = 
            items
            |> List.map permission

        access

    [<Fact>]
    member _.``Test ILoad`` () =

        let space = IloadSpace ()

        query {for i in space.GroupPermissions do
                select i}
        |> Seq.length
        |> fun i -> i.Should().Be(4, "items") |> ignore

    [<Fact>]
    member _.``add user`` () = 


        let space = IloadSpace()
        let realm = space.Realms.Get(Access.RBAC.Realm (Name = "Access"))
        use read  = new AccessSpace(space, Access.AccessSpace.Mode.Read, realm)
        use write = new AccessSpace(space, Access.AccessSpace.Mode.Write, realm)

        let admin =
            query {for u in read.Users do 
                    where (u.Name = "Admin")
                    select u}
            |> Seq.head

        let user =
            Access.RBAC.User 
              (
                Id = Guid.NewGuid(),
                Name = "Steve",
                Realm = realm,
                Author = admin,
                PublicKey = "something"
              )
            |> write.Users.Bind
            |> (resultMsg (fun (u : Access.RBAC.User) -> u.ErrorMsg))

        read.Users.Get(user).Id.Should().Be(user.Id, "was created") |> ignore

        let tryAdd () = 
            Access.RBAC.User 
              (
                Id = Guid.NewGuid(),
                Name = "Jane",
                Realm = realm,
                Author = user,
                PublicKey = "something"
              )
            |> write.Users.Bind

        tryAdd().Fail.Should().BeTrue("did not have permission") |> ignore

        admin.Group.Members.Add user

        tryAdd().Ok.Should().BeTrue("has permission") |> ignore

    [<Fact>]
     member _.``Graph list`` () =

        let space = IloadSpace()

        let nodes = 
            query { for n in space.Nodes do
                    select n}
            |> List.ofSeq

        let edges = 
            query { for e in space.Edges do 
                    select e }
            |> Seq.toList

        output.WriteLine ("SKey, Name, TypeName")
        nodes 
        |> List.iter    (fun n -> output.WriteLine ($"{n.SKey}, {n.Name}, {n.TypeName}"))

        output.WriteLine ("From, To, Name, TypeName")
        edges 
        |> List.filter  (fun e -> not(e.From = null || e.To = null))
        |> List.iter    (fun e -> output.WriteLine ($"{e.From.SKey}, {e.To.SKey}, {e.Name}, {e.TypeName} "))

    [<Fact>]
     member _.``Graph view`` () =

        let space = IloadSpace()

        let relm = 
            query { for n in space.Nodes do
                    where (n.Name = "Access")
                    select n}
            |> Seq.head

        let rec print tabs (visited : Set<Node>) (n : Node) =
            let printEdges tabs (visited : Set<Node>) (n : Node)  =
                let printFrom tabs (visited : Set<Node>) (e : Edge) =
                    output.WriteLine ($"{tabs}Edge {{ From = {e.From.SKey}, To = {e.To.SKey}, Name = {e.Name}, TypeName = {e.TypeName}}}")
                    print ($"{tabs}\t") visited e.To
                n.Froms
                |> Seq.filter  (fun e -> not (e.From = null || e.To = null))
                |> List.ofSeq
                |> List.iter    (printFrom tabs visited)
            output.WriteLine ($"{tabs}Node {{ SKey = {n.SKey}, Name = {n.Name} TypeName = {n.TypeName} }}")
            if not (visited.Contains n) then 
                let newVisited = visited |> Set.add n
                printEdges $"{tabs}\t" newVisited n

        print "" (Set.ofList []) relm

    [<Fact>]
    member _.``empty test`` () =

        use space = new AccessSpace (new Heap.HeapSpace())

        let res = new RBAC.GroupPermission( owner = RBAC.Group())

        let find = space.GroupPermissions.Find(res) |> List.ofSeq;


        let bytes = Hiperspace.Space.ValueBytes (res)
        let res2 = Hiperspace.Space.FromValue<RBAC.GroupPermission.KeyType> (bytes)

        res.Should().Be(res, "same")

