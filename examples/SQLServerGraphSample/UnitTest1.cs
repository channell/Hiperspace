using Domain;
using Hiperspace;
using Hiperspace.Heap;
using Hiperspace.Rocks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Xunit.Abstractions;
using static HiLang.Parser.token;

namespace SQLServerGraphSample
{
    public class UnitTest1
    {
        public static T? nvl<T>(T t) where T: struct {  return new Nullable<T>(t); }
        ITestOutputHelper _output;
        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }
        /*
        -- Insert data into node tables. Inserting into a node table is same as inserting into a regular table
        INSERT INTO Person (ID, name)
            VALUES (1, 'John')
                 , (2, 'Mary')
                 , (3, 'Alice')
                 , (4, 'Jacob')
                 , (5, 'Julie');

        INSERT INTO Restaurant (ID, name, city)
            VALUES (1, 'Taco Dell','Bellevue')
                 , (2, 'Ginger and Spice','Seattle')
                 , (3, 'Noodle Land', 'Redmond');

        INSERT INTO City (ID, name, stateName)
            VALUES (1,'Bellevue','WA')
                 , (2,'Seattle','WA')
                 , (3,'Redmond','WA');

        -- Insert into edge table. While inserting into an edge table,
        -- you need to provide the $node_id from $from_id and $to_id columns.
        -- Insert which restaurants each person likes 
                INSERT INTO likes
                    VALUES((SELECT $node_id FROM Person WHERE ID = 1), (SELECT $node_id FROM Restaurant WHERE ID = 1), 9)
                 , ((SELECT $node_id FROM Person WHERE ID = 2), (SELECT $node_id FROM Restaurant WHERE ID = 2), 9)
                 , ((SELECT $node_id FROM Person WHERE ID = 3), (SELECT $node_id FROM Restaurant WHERE ID = 3), 9)
                 , ((SELECT $node_id FROM Person WHERE ID = 4), (SELECT $node_id FROM Restaurant WHERE ID = 3), 9)
                 , ((SELECT $node_id FROM Person WHERE ID = 5), (SELECT $node_id FROM Restaurant WHERE ID = 3), 9);

        -- Associate in which city live each person
        INSERT INTO livesIn
            VALUES((SELECT $node_id FROM Person WHERE ID = 1), (SELECT $node_id FROM City WHERE ID = 1))
                 , ((SELECT $node_id FROM Person WHERE ID = 2), (SELECT $node_id FROM City WHERE ID = 2))
                 , ((SELECT $node_id FROM Person WHERE ID = 3), (SELECT $node_id FROM City WHERE ID = 3))
                 , ((SELECT $node_id FROM Person WHERE ID = 4), (SELECT $node_id FROM City WHERE ID = 3))
                 , ((SELECT $node_id FROM Person WHERE ID = 5), (SELECT $node_id FROM City WHERE ID = 1));

        -- Insert data where the restaurants are located 
        INSERT INTO locatedIn
            VALUES((SELECT $node_id FROM Restaurant WHERE ID = 1), (SELECT $node_id FROM City WHERE ID =1))
                 , ((SELECT $node_id FROM Restaurant WHERE ID = 2), (SELECT $node_id FROM City WHERE ID =2))
                 , ((SELECT $node_id FROM Restaurant WHERE ID = 3), (SELECT $node_id FROM City WHERE ID =3));

        --  Insert data into the friendOf edge 
        INSERT INTO friendOf
            VALUES((SELECT $NODE_ID FROM Person WHERE ID = 1), (SELECT $NODE_ID FROM Person WHERE ID = 2))
                 , ((SELECT $NODE_ID FROM Person WHERE ID = 2), (SELECT $NODE_ID FROM Person WHERE ID = 3))
                 , ((SELECT $NODE_ID FROM Person WHERE ID = 3), (SELECT $NODE_ID FROM Person WHERE ID = 1))
                 , ((SELECT $NODE_ID FROM Person WHERE ID = 4), (SELECT $NODE_ID FROM Person WHERE ID = 2))
                 , ((SELECT $NODE_ID FROM Person WHERE ID = 5), (SELECT $NODE_ID FROM Person WHERE ID = 4));
        */

        [Theory]
        [InlineData("Rocks", "Relation")]
        [InlineData("Rocks", "Graph")]
        [InlineData("Heap", "Relation")]
        [InlineData("Heap", "Graph")]
        public void Test1(string store, string kind)
        {
            HiperSpace space;
            var fn = DateTime.Now.Ticks.ToString();
            if (store == "Rocks")
            {
                if (!Directory.Exists("./rockstest")) Directory.CreateDirectory("./rockstest");
                if (Directory.Exists($"./rockstest/{fn}")) Directory.Delete($"./rockstest/{fn}", true);
                if (!Directory.Exists(fn)) Directory.CreateDirectory(fn);
                space = new RockSpace(fn);
            }
            else
            {
                space = new HeapSpace();
            }

            using (var dom = new DomainSpace(space))
            {
                var cities = new List<City>()
                {
                    new City { Id = 1, Name = "Bellevue", State = "WA" },
                    new City { Id = 2, Name = "Seattle", State = "WA" },
                    new City { Id = 3, Name = "Redmond", State = "WA" }
                };

                var people = new List<Person>()
                {
                    new() { Id = 1, Name = "John", City_Id = 1},
                    new() { Id = 2, Name = "Mary", City_Id = 2},
                    new() { Id = 3, Name = "Alice", City_Id = 3},
                    new() { Id = 4, Name = "Jacob",City_Id = 3},
                    new() { Id = 5, Name = "Julie",City_Id = 1},
                };

                var resteraunts = new List<Restaurant>()
                {
                    new() { Id = 1, Name = "Taco Bell", City_Id = 1},
                    new() { Id = 2, Name = "Ginger and Spice", City_Id = 2},
                    new() { Id = 3, Name = "Noodle Land", City_Id = 3},
                };

                var likes = new List<(Person.KeyType p, Restaurant.KeyType r, int n)>()
                {
                    (new Person.KeyType {Id = 1}, new Restaurant.KeyType { Id = 1}, 9),
                    (new Person.KeyType {Id = 2}, new Restaurant.KeyType { Id = 2}, 9),
                    (new Person.KeyType {Id = 3}, new Restaurant.KeyType { Id = 3}, 9),
                    (new Person.KeyType {Id = 4}, new Restaurant.KeyType { Id = 3}, 9),
                    (new Person.KeyType {Id = 5}, new Restaurant.KeyType { Id = 3}, 9),
                };

                var friends = new List<(int p, int f)>
                {
                    (1,2),
                    (2,3),
                    (3,1),
                    (4,2),
                    (5,4),
                };

                // add to Hiperspace
                people.ForEach(p => dom.Persons.Add(p));
                cities.ForEach(c => dom.Citys.Add(c));
                resteraunts.ForEach(r => dom.Restaurants.Add(r));
                likes.ForEach(l => dom.PersonLikess.Add(new PersonLikes { owner = l.p, Restaurant = l.r, Rating = l.n }));
                friends.ForEach(f => dom.PersonFriendss.Add(new PersonFriends { owner_Id = f.p, Of_Id = f.f }));

                /*-- Find Restaurants that John likes
                SELECT Restaurant.name
                FROM Person, likes, Restaurant
                WHERE MATCH (Person-(likes)->Restaurant)
                AND Person.name = 'John';

                -- Find Restaurants that John's friends like
                SELECT Restaurant.name
                FROM Person person1, Person person2, likes, friendOf, Restaurant
                WHERE MATCH(person1-(friendOf)->person2-(likes)->Restaurant)
                AND person1.name='John';

                -- Find people who like a restaurant in the same city they live in
                SELECT Person.name
                FROM Person, likes, Restaurant, livesIn, City, locatedIn
                WHERE MATCH (Person-(likes)->Restaurant-(locatedIn)->City AND Person-(livesIn)->City);*/

                var John = 
                    dom.Persons
                    .Where(p => p.Name == "John")
                    .ToArray()
                    .First();

                if (kind == "Relation")
                {
                    _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} John likes (object)");
                    foreach (var l in
                        John.Likes
                        .Select(l => l.Restaurant?.Value?.Name))
                    {
                        _output.WriteLine($"\t{l}");
                    }
                    _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} John's friends like (object)");
                    foreach (var l in
                        John.Friends
                        .Select(f => f?.Of?.Value)
                        .Aggregate(new List<PersonLikes>(), (a, f) => { if (f?.Likes != null) a.AddRange(f.Likes); return a; })
                        .Select(l => l.Restaurant?.Value?.Name))
                    {
                        _output.WriteLine($"\t{l}");
                    }

                    _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} Likes local restaurant (object)");
                    var same = new HashSet<Person>();
                    foreach (var p in dom.Persons)
                        foreach (var l in p.Likes)
                            if (l.Restaurant_Value?.City == p.City)
                                same.Add(p);
                    foreach (var p in same)
                        _output.WriteLine($"\t{p.Name}");

                    _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} Fiend paths (join)");
                    Func<PersonFriends, string> fname = e => e.owner?.Value?.Name ?? "";
                    var frields = dom.PersonFriendss.ToArray();
                    var q =
                        (from p in frields
                         join p2 in frields on p.Of equals p2.owner
                         join p3 in frields on p2.Of equals p3.owner
                         join p4 in frields on p3.Of equals p4.owner
                         where p2.owner != p.owner
                            && p3.owner != p2.owner
                            && p4.owner != p3.owner
                            && p.owner != p4.owner
                         let pname = fname(p)
                         let pname2 = fname(p2)
                         let pname3 = fname(p3)
                         let pname4 = fname(p4)
                         select $"\t{pname}->{pname2}->{pname3}->{pname4}"
                         );
                    foreach (var l in q)
                        _output.WriteLine(l);

                    _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} Fiend paths (recursive)");
                    foreach (var p in dom.Persons)
                        foreach (var path in Paths(p) ?? ImmutableList<ImmutableList<Person>>.Empty)
                        {
                            var sb = new StringBuilder();
                            foreach (var point in path ?? ImmutableList<Person>.Empty)
                                sb.Append($"->{point.Name}");
                            _output.WriteLine($"\t{sb.ToString().Substring(2)}");
                        }
                }
                else
                {
                    _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} John likes (graph)");
                    var johnNode = (Node)John;
                    var johnkey = nvl(johnNode.self);
                    foreach (var l in
                        johnNode.Froms
                        .Where(e => e.TypeName == "Likes")
                        .ToArray()
                        .Select(e => e.To?.Value?.Name))
                    {
                        _output.WriteLine($"\t{l}");
                    }

                    _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} John's friends like (graph)");
                    foreach (var l in
                        johnNode.Froms
                        .Where(e => e.TypeName == "Friend")
                        .ToArray()
                        .Aggregate(new List<Node?>(), (a, e) => { a.Add(e.To?.Value); return a; })
                        .Aggregate(new List<Edge?>(), (a, n) => { if (n != null) a.AddRange(n.Froms); return a; })
                        .Where(e => e?.TypeName == "Likes")
                        .Select(e => e?.To?.Value?.Name))
                    {
                        _output.WriteLine($"\t{l}");
                    }

                    Func<Node, Person?> pn = n => n.Object as Person;
                    Func<Node, Restaurant?> rn = n => n.Object as Restaurant;
                    _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} Likes local restaurant (graph)");
                    foreach (var l in
                        dom.Edges
                        .Where(e => e.TypeName == "Likes")
                        .ToArray()
                        .Where(e => e.From?.Value?.Object is Person && e.To?.Value?.Object is Restaurant)
                        .Select(e => (e.From?.Value?.Object as Person, e.To?.Value?.Object as Restaurant))
                        .Where(p => p.Item1?.City == p.Item2?.City)
                        .Select(p => p.Item1)
                        )
                    {
                        _output.WriteLine($"\t{l?.Name}");
                    }
                    _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} Fiend paths");
                    Func<Edge, string> fname = e => e.From?.Value?.Name ?? "";
                    var edges = dom.Edges.Where(e => e.TypeName == "Friend").ToArray();
                    var q =
                        (from p in edges
                         join p2 in edges on p.To equals p2.From
                         join p3 in edges on p2.To equals p3.From
                         join p4 in edges on p3.To equals p4.From
                         where p2.From != p.From
                            && p3.From != p2.From
                            && p4.From != p3.From
                            && p.From != p4.From
                         let pname = fname(p)
                         let pname2 = fname(p2)
                         let pname3 = fname(p3)
                         let pname4 = fname(p4)
                         select $"\t{pname}->{pname2}->{pname3}->{pname4}"
                         );
                    foreach (var l in q)
                        _output.WriteLine (l);

                    _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} Fiend paths (recursive)");
                    foreach (var p in dom.Nodes)
                        foreach (var path in Paths(p) ?? ImmutableList<ImmutableList<Node>>.Empty)
                        {
                            var sb = new StringBuilder();
                            foreach (var point in path ?? ImmutableList<Node>.Empty)
                                sb.Append($"->{point.Name}");
                            _output.WriteLine($"\t{sb.ToString().Substring(2)}");
                        }

                    if (Directory.Exists($"./rockstest/{fn}")) Directory.Delete($"./rockstest/{fn}", true);
                }
                _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} End");
            }
        }
        private static ImmutableList<ImmutableList<Person>> Paths(Person current, ImmutableList<Person>? path = null)
        {
            if (path == null) path = ImmutableList<Person>.Empty;
            var paths = ImmutableList<ImmutableList<Person>>.Empty;
            var newpath = path.Add(current);
            var currentpath = ImmutableList<Person>.Empty.Add(current);

            foreach (var f in current.Friends)
            {
                var of = f.Of?.Value;
                if (of != null && !path.Contains(of))
                {
                    var next = Paths(of, newpath);
                    foreach (var p in next)
                    {
                        paths = paths.Add(currentpath.AddRange(p));
                    }
                }
                else
                {
                    paths = paths.Add(currentpath);
                }
            }

            return paths;
        }

        private static ImmutableList<ImmutableList<Node>> Paths(Node current, ImmutableList<Node>? path = null)
        {
            if (path == null) path = ImmutableList<Node>.Empty;
            var paths = ImmutableList<ImmutableList<Node>>.Empty;
            var newpath = path.Add(current);
            var currentpath = ImmutableList<Node>.Empty.Add(current);

            foreach (var f in current.FromType("Friend"))
            {
                var of = f.To?.Value;
                if (of != null && !path.Contains(of))
                {
                    var next = Paths(of, newpath);
                    foreach (var p in next)
                    {
                        paths = paths.Add(currentpath.AddRange(p));
                    }
                }
                else
                {
                    paths = paths.Add(currentpath);
                }
            }
            return paths;
        }
    }
}