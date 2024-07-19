using Hiperspace;
using System.Collections.Immutable;
using System.Diagnostics;

namespace Cousins
{
    internal static class Helper
    {
        internal static List<Path> Relations(Person person)
        {
            Node node = person;
            var result = new SortedSet<Path>();
            foreach (var edge in node.Froms)
            {
                var paths = FindPaths(node, edge, null);
                if (paths != ImmutableSortedSet<Path>.Empty)
                {
                    var transformed =
                        paths
                        .Select(p => p.TransformPath(Infered))
                        .ToList();
                    transformed.ForEach(p => result.Add(p));
                }
            }
            return result.ToList();
        }
        internal struct Transform
        {
            internal string Infered;
            internal string[][] Path;
            internal Func<Person?, Person?, bool> Predicate;
        }

        static Transform[] Infered = new Transform[]
        {
            new Transform
            {
                Infered = "Brother",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Child"},
                },
                Predicate = (f,t) => t?.Gender == Gender.Male
            },
            new Transform
            {
                Infered = "Sister",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Child"},
                },
                Predicate = (f,t) => t?.Gender == Gender.Female
            },
            new Transform
            {
                Infered = "Sibling",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Child"},
                },
                Predicate = (f,t) => true
            },
            new Transform
            {
                Infered = "Parents",
                Path = new string[][]
                {
                    new [] {"Child"},
                    new [] {"Father", "Mother"},
                },
                Predicate = (f,t) => true
            },
            new Transform
            {
                Infered = "Uncle",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Father", "Mother"},
                    new [] {"Child"},
                },
                Predicate = (f,t) => t?.Gender == Gender.Male
            },
            new Transform
            {
                Infered = "Aunt",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Father", "Mother"},
                    new [] {"Child"},
                },
                Predicate = (f,t) => t?.Gender != Gender.Female
            },
            new Transform
            {
                Infered = "Grandfather",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Father"},
                },
                Predicate = (f,t) => t?.Gender == Gender.Male
            },
            new Transform
            {
                Infered = "GrandMother",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Mother"},
                },
                Predicate = (f,t) => t?.Gender == Gender.Female
            },
            new Transform
            {
                Infered = "Great-Grandfather",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Father", "Mother"},
                    new [] {"Father"},
                },
                Predicate = (f,t) => t?.Gender == Gender.Male
            },
            new Transform
            {
                Infered = "Great-GrandMother",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Father", "Mother"},
                    new [] {"Mother"},
                },
                Predicate = (f,t) => t?.Gender == Gender.Female
            },
            new Transform
            {
                Infered = "Uncle",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Father", "Mother"},
                    new [] {"Child"},
                },
                Predicate = (f,t) => t?.Gender == Gender.Male
            },
            new Transform
            {
                Infered = "Aunt",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Father", "Mother"},
                    new [] {"Child"},
                },
                Predicate = (f,t) => t?.Gender == Gender.Female
            },
            new Transform
            {
                Infered = "Great-Aunt",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Father", "Mother"},
                    new [] {"Father", "Mother"},
                    new [] {"Child"},
                },
                Predicate = (f,t) => t?.Gender == Gender.Female
            },
            new Transform
            {
                Infered = "Great-Uncle",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Father", "Mother"},
                    new [] {"Father", "Mother"},
                    new [] {"Child"},
                },
                Predicate = (f,t) => t?.Gender == Gender.Male
            },
            new Transform
            {
                Infered = "Niece",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Child"},
                    new [] {"Child"},
                },
                Predicate = (f,t) => t?.Gender == Gender.Female
            },
            new Transform
            {
                Infered = "Nephew",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Child"},
                    new [] {"Child"},
                },
                Predicate = (f,t) => t?.Gender == Gender.Male
            },
            new Transform
            {
                Infered = "Great-Niece",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Child"},
                    new [] {"Child"},
                    new [] {"Child"},
                },
                Predicate = (f,t) => t?.Gender == Gender.Female
            },
            new Transform
            {
                Infered = "Graet-Nephew",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Child"},
                    new [] {"Child"},
                    new [] {"Child"},
                },
                Predicate = (f,t) => t?.Gender == Gender.Male
            },
            new Transform
            {
                Infered = "Cousin",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Father", "Mother"},
                    new [] {"Child"},
                    new [] {"Child"},
                },
                Predicate = (f,t) => true
            },
            new Transform
            {
                Infered = "Second-Cousin",
                Path = new string[][]
                {
                    new [] {"Father", "Mother"},
                    new [] {"Father", "Mother"},
                    new [] {"Father", "Mother"},
                    new [] {"Child"},
                    new [] {"Child"},
                    new [] {"Child"},
                },
                Predicate = (f,t) => true
            },
        };
        public static bool InPath(this Edge edge, Cousins.Path? path)
        {
            if (path == null)
                return false;
            else if (edge == path.Edge ||
                     edge.To == path.Edge?.From)
                return true;
            else
                return edge.InPath(path?.Source);
        }
        public static IEnumerable<Edge> Edges(this Path path)
        {
            if (path != null)
            {
                if (path.Edge != null)
                    yield return path.Edge;
                if (path.Source != null)
                    foreach (var source in path.Source.Edges())
                        yield return source;
            }
        }
        private static bool Match(this Path path, Stack<string[]> valid)
        {
            if (path != null)
            {
                var val = valid.Pop();

                if (!val.Any(i => i == path?.Edge?.TypeName)) 
                    return false;
                if (path.Source != null)
                {
                    if (valid.TryPeek(out var src))
                        return path.Source.Match(valid);
                    else
                        return false;   // longer
                }
            }
            if (valid.TryPeek(out var i))
                return false;           // shorter
            else
                return true;
        }

        private static ImmutableSortedSet<Path> FindPaths(Node root, Edge edge, Path? source)
        {
            if (edge == null || 
                root == edge.To || 
                (root == edge.From && source != null) || 
                edge.InPath(source) )
                return ImmutableSortedSet<Path>.Empty;

            var path = new Path
            {
                From = root,
                To = edge.To,
                Edge = edge,
                Source = source,
                TypeName = "relation"
            };

            var result = ImmutableSortedSet<Path>.Empty.Add(path);
            var froms = edge?.To?.Froms.ToArray();
            if (froms != null)
            {
                foreach (var e in froms)
                {
                    if (e != null && e.To != null && edge?.To != null)
                    {
                        var paths = FindPaths(root, e, path);
                        if (paths != ImmutableSortedSet<Path>.Empty)
                        {
                            result = result.Union(paths);
                        }
                    }
                }
            }
            return result;
        }

        internal static Path TransformPath(this Path path, Transform[] transforms)
        {
            foreach (var transform in transforms)
            {
                var stack = new Stack<string[]>(transform.Path);
                if (path.Match(stack))
                {
                    if (path.From?.Object is Person f && 
                        path.To?.Object is Person t 
                        && transform.Predicate(f,t))
                        return new Path(path)
                        {
                            TypeName = transform.Infered
                        };
                }
            }
            return path;
        }
    }
}
