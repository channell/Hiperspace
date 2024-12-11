using Cousins;
using FluentAssertions;
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

        private CousinsSpace _space;

        public Test(ITestOutputHelper output)
        {
            _output = output;
            var driver = new HeapSpace();
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
            using (var temp = new GenerationSpace(new HiperSpace[] { new HeapSpace(), _space }))
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
                            space.Paths.Add(rel);
                        }
                    }
                    var edges = (from r in space.Edges
                                 where r.From != null && r.To != null
                                 select r).ToArray();
                    edges.Length.Should().Be(106);
                    for (var i = 0; i < edges.Length; i++)
                    {
                        _output.WriteLine($"{edges[i].From?.Name} has a {edges[i].TypeName} named {edges[i].To?.Name}");
                    }
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
    }
}