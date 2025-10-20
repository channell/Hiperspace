using Domain;
using FluentAssertions;
using HiLang.CSGen;
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

        private RockSpace Rocks (string fn)
        {
            if (!Directory.Exists("./rockstest")) Directory.CreateDirectory($"./rockstest");
            if (Directory.Exists(fn)) Directory.Delete(fn, true);
            if (!Directory.Exists(fn)) Directory.CreateDirectory(fn);
            return new RockSpace(fn);
        }

            [Theory]
        [InlineData("Rocks", "Relation")]
        [InlineData("Rocks", "Graph")]
        [InlineData("Heap", "Relation")]
        [InlineData("Heap", "Graph")]
        public void Test1(string store, string kind)
        {
            var fn = $"./rockstest/{kind}{DateTime.Now.Ticks.ToString()}";
            using (HiperSpace space = store == "Rocks" ? Rocks(fn) : new HeapSpace())
            {
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

                    var likes = new List<(Person p, Restaurant r, int n)>()
                {
                    (new Person {Id = 1}, new Restaurant { Id = 1}, 9),
                    (new Person {Id = 2}, new Restaurant { Id = 2}, 9),
                    (new Person {Id = 3}, new Restaurant { Id = 3}, 9),
                    (new Person {Id = 4}, new Restaurant { Id = 3}, 9),
                    (new Person {Id = 5}, new Restaurant { Id = 3}, 9),
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
                    likes.ForEach(l => dom.Likess.Add(new Likes { owner = l.p, Restaurant = l.r, Rating = l.n }));
                    friends.ForEach(f => dom.Friends.Add(new Friend { owner_Id = f.p, Of_Id = f.f }));

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
                            .Select(l => l.Restaurant?.Name))
                        {
                            _output.WriteLine($"\t{l}");
                        }
                        _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} John's friends like (object)");
                        foreach (var l in
                            John.Friends
                            .Select(f => f?.Of)
                            .Aggregate(new List<Likes>(), (a, f) => { if (f?.Likes != null) a.AddRange(f.Likes); return a; })
                            .Select(l => l.Restaurant?.Name))
                        {
                            _output.WriteLine($"\t{l}");
                        }

                        _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} Likes local restaurant (object)");
                        var same = new HashSet<Person>();
                        foreach (var p in dom.Persons)
                            foreach (var l in p.Likes)
                                if (l.Restaurant?.City == p.City)
                                    same.Add(p);
                        foreach (var p in same)
                            _output.WriteLine($"\t{p.Name}");

                        _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} Fiend paths (join)");
                        Func<Friend, string> fname = e => e.owner?.Name ?? "";
                        var frields = dom.Friends.ToArray();
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

                        var q2 = from p in dom.Friends
                                 join p2 in dom.Friends on p.Of equals p2.owner
                                 join p3 in dom.Friends on p2.Of equals p3.owner
                                 join p4 in dom.Friends on p3.Of equals p4.owner
                                 where p2.owner != p.owner
                                    && p3.owner != p2.owner
                                    && p4.owner != p3.owner
                                    && p.owner != p4.owner
                                 let pname = fname(p)
                                 let pname2 = fname(p2)
                                 let pname3 = fname(p3)
                                 let pname4 = fname(p4)
                                 select $"\t{pname}->{pname2}->{pname3}->{pname4}";

                        _output.WriteLine($"{new QueryExplain(q2.Expression)}");

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

                        var johnNode =
                            dom.Nodes
                            .Where(p => p.Name == "John")
                            .ToArray()
                            .First();
                        foreach (var l in
                            johnNode.FromType("Likes")
                            .Select(e => e.To?.Name))
                        {
                            _output.WriteLine($"\t{l}");
                        }

                        _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} John's friends like (graph)");
                        foreach (var l in
                            johnNode.FromType("Friend")
                            .ToArray()
                            .Aggregate(new List<Node?>(), (a, e) => { a.Add(e.To); return a; })
                            .Aggregate(new List<Edge?>(), (a, n) => { if (n != null) a.AddRange(n.Froms); return a; })
                            .Where(e => e?.TypeName == "Likes")
                            .Select(e => e?.To?.Name))
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
                            .Select(e => (e.From?.Object as Person, e.To?.Object as Restaurant))
                            .Where(p => p.Item1?.City == p.Item2?.City)
                            .Select(p => p.Item1)
                            )
                        {
                            _output.WriteLine($"\t{l?.Name}");
                        }
                        _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} Fiend paths");
                        Func<Edge, string> fname = e => e.From?.Name ?? "";
                        var edges = dom.Edges.Where(e => e.TypeName == "Friend").ToArray();
                        foreach (var line in
                            (from p in edges
                             join p2 in edges on p.To equals p2.From
                             join p3 in edges on p2.To equals p3.From
                             join p4 in edges on p3.To equals p4.From
                             where p2.From != p.From
                                && p3.From != p2.From
                                && p4.From != p3.From
                                && p.From != p4.From
                             select $"\t{fname(p)}->{fname(p2)}->{fname(p3)}->{fname(p4)}"
                             ))
                            _output.WriteLine(line);


                        _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} Fiend paths (recursive)");
                        foreach (var p in dom.Nodes)
                            foreach (var path in Paths(p) ?? ImmutableList<ImmutableList<Node>>.Empty)
                            {
                                var sb = new StringBuilder();
                                foreach (var point in path ?? ImmutableList<Node>.Empty)
                                    sb.Append($"->{point.Name}");
                                _output.WriteLine($"\t{sb.ToString().Substring(2)}");
                            }

                    }
                    _output.WriteLine($"{DateTime.Now.TimeOfDay.ToString()} End");
                }
            }
            if (Directory.Exists(fn)) Directory.Delete(fn, true);
        }
        private static ImmutableList<ImmutableList<Person>> Paths(Person current, ImmutableList<Person>? path = null)
        {
            if (path == null) path = ImmutableList<Person>.Empty;
            var paths = ImmutableList<ImmutableList<Person>>.Empty;
            var newpath = path.Add(current);
            var currentpath = ImmutableList<Person>.Empty.Add(current);

            foreach (var f in current.Friends)
            {
                var of = f.Of;
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
                var of = f.To;
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

        [Fact]
        public void TestSession ()
        {
            using (var heap = new HeapSpace())
            {
                using (var durable = new DomainSpace(heap))
                {
                    var pk1 = new Person.KeyType { Id = 1 };
                    var pk2 = new Person.KeyType { Id = 2 };
                    using (var session = new SessionSpace(new HeapSpace(), heap, SessionSpace.RollUpSeconds(1)))
                    {
                        using (var subses = new DomainSpace(session))
                        {
                            for (int c = 0; c < 100; c++)
                            {
                                subses.Persons.Add(new Person
                                {
                                    Id = pk1.Id,
                                    Name = $"Fred {c}",
                                });
                                subses.Persons.Add(new Person
                                {
                                    Id = pk2.Id,
                                    Name = $"Jane {c}",
                                });
                                Thread.Sleep(10);
                            }
                            var fred = subses.Persons.Get(ref pk1);
                            fred.Should().NotBeNull();
                            if (fred != null)
                            {
                                var history = fred.GetVersions().ToList();
                                history.Count.Should().Be(100);

                                durable.Persons.Get(ref pk1).Should().BeNull();
                            }
                        }
                    }
                    // after
                    var fredS = durable.Persons.Get(ref pk1);
                    fredS.Should().NotBeNull();

                    durable.Persons.Get(ref pk2).Should().NotBeNull();
                    if (fredS != null)
                    {
                        var historyS = fredS.GetVersions().ToList();
                        historyS.Count.Should().BeGreaterThan(1);
                        foreach (var v in historyS)
                        {
                            _output.WriteLine($"{v.Name} {v.AsAt}");
                        }
                    }
                }
            }
        }
    }
}