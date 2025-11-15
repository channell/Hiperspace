using Cousins;
using FluentAssertions;
using HiLang.CSGen;
using Hiperspace;
using Hiperspace.Heap;
using Xunit;
using Xunit.Abstractions;

namespace CousinProblem
{
    public class Test
    {
        public static T? nvl<T>(T t) where T : struct { return new T?(t); }
        ITestOutputHelper _output;

        private HeapSpace driver;
        private CousinsSpace _space;

        public Test(ITestOutputHelper output)
        {
            _output = output;
            driver = new HeapSpace();
            _space = new CousinsSpace(driver);
            var tree = new List<Person>
            {
                new Person {Name = "Eve", Gender = Gender.Female },
                new Person {Name = "Jane", Gender = Gender.Female, Mother = new Person {Name = "Eve" }},
                new Person {Name = "Jack", Gender = Gender.Male, Mother = new Person {Name = "Eve" }},
                new Person {Name = "Adam", Gender = Gender.Male, Father = new Person {Name = "Jack" }},
                new Person {Name = "Liz", Gender = Gender.Female, Father = new Person {Name = "Adam" }},
                new Person {Name = "Mary", Gender = Gender.Female, Mother = new Person {Name = "Jane" }},
                new Person {Name = "Burt", Gender = Gender.Male, Mother= new Person {Name = "Jane" }},
                new Person {Name = "Rob", Gender = Gender.Male, Father = new Person {Name = "Burt" }},
                new Person {Name = "John", Gender = Gender.Male},
                new Person {Name = "Lucy", Gender = Gender.Female, Father = new Person {Name = "John" }, Mother = new Person {Name = "Mary" } },
                new Person {Name = "Mark", Gender = Gender.Male, Father = new Person {Name = "John" }, Mother = new Person {Name = "Mary"} },
            };
            tree.ForEach(p => _space.Persons.Bind(p, false));
        }

        [Fact]
        public void TestValid()
        {
            using (var space = new CousinsSpace(_space))
            {
                var gendererror =
                    (from p in space.Persons
                     where p.Father != null && p.Father.Gender != null && p.Father.Gender != Gender.Male ||
                            p.Mother != null && p.Mother.Gender != null && p.Mother.Gender != Gender.Female
                     select new { p.Name, Mine = p.Gender, father = p.Father, mother = p.Mother }
                    ).ToList();
                gendererror.ForEach(r => _output.WriteLine($"{r.Name} ({r.Mine}) has father {r.father.Name} and mother {r.mother.Name}"));
                gendererror.Should().BeEmpty();

                var noParents =
                    (from p in space.Persons
                     where p.Mother == null && p.Father == null
                     select p.Name
                    ).ToList();
                noParents.ForEach(r => _output.WriteLine($"{r} has no parents"));
                noParents.Count.Should().Be(2, "John and Eve have unknown parents");
            }
        }

        [Fact]
        public void TestDecendants()
        {
            using (var space = new CousinsSpace(_space))
            {
                var eve = space.Persons.Get(new Person { Name = "Eve" })!;
                Node node = eve!;
                var descendants = node.HiperEdges("Child");

                foreach (var child in descendants)
                {
                    _output.WriteLine($"{child.From?.Name} ({child.From?.TypeName}) has {child.TypeName} to {child.To?.Name} ({child.To?.TypeName}) with Length {child.Length} and Wdith {child.Width}");
                }
                descendants?.Count.Should().Be(9);
            }
        }
        [Fact]
        public void TestAncestors()
        {
            using (var space = new CousinsSpace(_space))
            {
                var lucy = space.Persons.Get(new Person { Name = "Lucy" })!;
                Node node = lucy!;
                var ancestors = node.HiperEdges("Ancestors", new[] {"Mother", "Father" });

                foreach (var child in ancestors)
                {
                    _output.WriteLine($"{child.From?.Name} ({child.From?.TypeName}) has {child.TypeName} to {child.To?.Name} ({child.To?.TypeName})with Length {child.Length} and Wdith {child.Width}");
                }
                ancestors?.Count.Should().Be(4);
            }
        }

        [Fact]
        public void TestEdge()
        {
            using (var space = new CousinsSpace(_space))
            {
                var lines = space.Edge2s.Find(new Edge2 { From = new Person { Name = "Jack" }, TypeName = "Father" }).ToList();
                lines.ForEach(e => _output.WriteLine($"{e.From?.Name} ({e.From?.TypeName}) has {e.TypeName} to {e.To?.Name} ({e.To?.TypeName})"));
                lines.Should().NotBeEmpty();
                lines.Count.Should().Be(1);
            }
        }

        [Fact]
        public void TestGraph()
        {
            using (var space = new CousinsSpace(_space))
            {
                var l = space.Edges.ToArray();
                var l2 = (from e in space.Edges select e).ToArray();
                var l3 = (from e in space.Edges where e.From != null select e).ToArray();
                var l4 = (from e in space.Edges where e.To != null select e).ToArray();
                var lines =
                    (from e in space.Edges
                     where e.From != null && e.To != null
                     select e
                    ).ToList();

                lines.ForEach(e => _output.WriteLine($"{e.From?.Name} ({e.From?.TypeName}) has {e.TypeName} to {e.To?.Name} ({e.To?.TypeName})"));
                lines.Should().NotBeEmpty();
                lines.Count.Should().Be(22);
            }
        }
        [Fact]
        public void TestLucy()
        {
            using (var space = new CousinsSpace(_space))
            {
                var relatives =
                    (from i in from p in space.Persons
                               where p.Name == "Lucy"
                               select p
                     select i.Relatives
                    ).FirstOrDefault();
                relatives.Should().NotBeNull("Lucy is in hiperspace");

                var sibling =
                    (from r in relatives
                     where r.TypeName == "Brother"
                     select r.To).FirstOrDefault();
                sibling.Should().NotBeNull("has a brother");
                sibling?.Name.Should().Be("Mark");

                var cousin =
                    (from r in relatives
                     where r.TypeName == "Cousin"
                     select r.To).FirstOrDefault();
                cousin.Should().NotBeNull("has a cousin");
                cousin?.Name.Should().Be("Rob");

                relatives?.ForEach(e => _output.WriteLine($"{e.From?.Name} ({e.From?.TypeName}) has {e.TypeName} to {e.To?.Name} ({e.To?.TypeName})"));

            }
        }
        [Fact]
        public void TestRelations()
        {
            var tempHash = new HeapSpace();
            using (var temp = new GenerationSpace(new HiperSpace[] { tempHash, _space }))
            {
                using (var space = new CousinsSpace(temp))
                {
                    var all = (from p in space.Persons select p).ToList();
                    var fall = space.Persons.Find(new Person { }).ToList();
                    var infered =
                        (from i in (from p in space.Persons select p).ToList()
                         select i.Relatives
                        )
                        .ToList();
                    foreach (var rels in infered)
                    {
                        foreach (var rel in rels)
                        {
                            space.Paths.Bind(rel);
                        }
                    }
                    var edges = (from r in space.Edges
                                 where r.From != null && r.To != null
                                 select r).ToArray();
                    for (var i = 0; i < edges.Length; i++)
                    {
                        _output.WriteLine($"{edges[i].From?.Name} has a {edges[i].TypeName} named {edges[i].To?.Name}");
                    }
                    edges.Length.Should().Be(80);
                }
            }
        }
        public static T NVL<T>(T? t) where T : struct { return t ?? default; }
        public static T NVL<T>(T? t) where T : class { return t!; }
        [Fact]
        public void TestJoin()
        {
            var lucy = "Lucy";
            using (var temp = new GenerationSpace(new HiperSpace[] { new HeapSpace(), _space }))
            {
                using (var space = new CousinsSpace(temp))
                {
                    var join =
                        from p in space.Persons
                        join f in space.Persons on p.Father!.Name equals f.Name
                        join m in space.Persons on p.Mother!.Name equals m.Name
                        where p.Name == lucy
                        select new { p, f, m };

                    _output.WriteLine($"{new QueryExplain(join.Expression)}");

                    foreach (var j in join)
                    {
                        _output.WriteLine($"{j.p.Name} () has father {j.f.Name} and mother {j.m.Name}");
                    }
                }
            }
        }

        [Fact]
        public void TestMetrics ()
        {
            var query = (from node in _space.Nodes
                         group node by node.TypeName into g
                         select new { TypeName = "Node", Name = g.Key, Count = g.Count() }
                        ).Union
                        (from edge in _space.Edges
                         group edge by edge.TypeName into g
                         select new { TypeName = "Edge", Name = g.Key, Count = g.Count() }
                        );
            var rows = query.ToHashSet();

            _output.WriteLine($"{new QueryExplain(query.Expression)}");

            var total = (from r in rows
                         select r.Count).Sum();

            foreach (var r in rows)
            {
                _output.WriteLine($"{r.TypeName} {r.Name} count {r.Count}");
            }
            total.Should().Be(55);
        }

        [Fact]
        public void TestGraphFunc()
        {
            var relation = new Graph.Route
            {
                Name = "Relation",
                Rules = new HashSet<Graph.Rule>
                {
                    new Graph.Rule { FromType = "Person", EdgeType = "Father", ToType = "Person" },
                    new Graph.Rule { FromType = "Person", EdgeType = "Mother", ToType = "Person" },
                    new Graph.Rule { FromType = "Person", EdgeType = "Child", ToType = "Person" },
                }
            };

            using (var temp = new CousinsSpace(new SessionSpace(new HeapSpace(), _space)))
            {
                var lucy = (from r in temp.Persons
                            where r.Name == "Lucy"
                            select r).FirstOrDefault();

                lucy!.Stored.Add(new Graph.TransitiveSegment
                {
                    Route = relation
                });
                foreach (var path in lucy.Stored)
                {
                    if (path.Paths is not null)
                    { 
                        foreach (var r in path.Paths)
                        {
                            var p = r;
                            if (p is not null)
                                _output.WriteLine($"From {p.From?.Name} To {p.To?.Name} Length {p.Length} Width {p.Width}");
                            var arrow = $"\t{p?.To?.Name} ({p?.Edge?.TypeName})";
                            var source = p?.Source;
                            while (source is not null) 
                            {
                                arrow = arrow + $" <- {source.To?.Name} ({source.Edge?.TypeName})";
                                source = source.Source;
                            }
                            arrow = arrow + $" <- {p?.From?.Name}";

                            _output.WriteLine(arrow);
                        }
                    }
                }
            }
        }
    }
}