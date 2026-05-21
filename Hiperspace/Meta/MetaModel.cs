// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf;
using System.Diagnostics;
namespace Hiperspace.Meta
{
    [ProtoContract]
    public class MetaModel : IEquatable<MetaModel>
    {
        internal static readonly BaseTypeModel MetaTypeModel = new BaseTypeModel();
        public MetaModel()
        {
            Elements = new Element[0];
        }
        public MetaModel(Element[] elements)
        {
            Elements = elements;
        }

        public Byte[] Bytes
        {
            get
            {
                // ensure we have a serialisable model
                var cp = new MetaModel(Elements ?? new Element[] { });
                return Space.ValueBytes(MetaTypeModel, cp);
            }
        }

        [ProtoMember(1)]
        public Element[]? Elements { get; set; }

        public override bool Equals(object? other)
        {
            if (other is null) return false;
            if (other is MetaModel value)
                return Equals(value);
            return false;
        }
        public bool Equals(MetaModel? other)
        {
            if (other is null) return false;
            if (Elements is null) return true;      // other may introduce any element 

            var map = other.Elements?.ToDictionary(p => p.Id);
            if (map is null) return false;
            for (int c = 0; c < Elements.Length; c++)
                if (map.TryGetValue(Elements[c].Id, out Element value))
                    if (!Elements[c].Equals(value)) return false;
            return true;
        }

        public override int GetHashCode()
        {
            var hc = new HashCode();
            if (Elements is not null)
                for (int c = 0; c < Elements.Length; c++)
                    hc.Add(Elements[c].GetHashCode());
            return hc.ToHashCode();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        public void Merge(MetaModel other)
        {
            if (other.Elements is not null && Elements is not null)
            {
                var elmentmap = Elements.ToDictionary(i => i.Id);
                for (int c = 0; c < other.Elements.Length; c++)
                {
                    if (!elmentmap.ContainsKey(other.Elements[c].Id))
                    {
                        elmentmap[other.Elements[c].Id] = other.Elements[c];
                    }
                    else
                    {
                        elmentmap[other.Elements[c].Id].Merge(other.Elements[c]);
                    }
                }
                Elements = elmentmap.Select(p => p.Value).ToArray();
            }
            else if (Elements is null)
            {
                Elements = other.Elements;
            }
        }

        public (int key, (int member, int key)[] values)[] MetaMap()
        {
            var any = new Meta.Element[]
            {
                new Meta.Element
                {
                    Category = "Type",
                    Id = 0,
                    Name = new Name { Reference = "Any"}
                }
            };
            var stores =
                (from e in Elements
                 where e.Category == "EntityImpl" || e.Category == "SegmentImpl" || e.Category == "AspectImpl"
                 orderby e.Id
                 select e
                ).Union(any).ToArray();

            var indexes = 
                (from e in Elements
                 from i in e.Index ?? new Alias[0]
                 orderby e.Id
                 select i
                ).ToArray();

            var roots = 
                (from r in (from e in stores select e.Id)
                           .Union
                           (from i in indexes select i.Id)
                 orderby r
                 select (r, r)
                ).ToArray();

            // get all the id for this name
            var dict =
                (from s in stores
                 group s by s.Name.Reference into g
                 select (g.Key, g.Select(e => e.Id).Distinct().ToHashSet())
                ).ToDictionary(p => p.Key, p => p.Item2);


            var aggregator = new Func<List<(int key, int value)>, 
                                      List<(int key, int value)>, 
                                      List<(int key, int value)>>
                ((current, next) =>
            {
                current.AddRange(next);
                return current;
            });

            var fieldMaps =
                (from r in 
                    (from e in stores
                     let keys = e.Keys ?? new Field[0]
                     let values = 
                        (from k in keys
                         where dict.ContainsKey(k.DataType.Reference)
                         let id = 
                            (from i in dict[k.DataType.Reference]
                             orderby i
                             select (k.Id, i)
                            ).ToList()
                         orderby k.Id
                         select id
                        ).Aggregate(new(), aggregator)
                     orderby e.Id
                     select (e.Id, values.ToArray())
                    )
                 orderby r.Id
                 select (r.Id, r.Item2)
                ).ToArray();

            var indexMaps =
                (from r in 
                    (from i in indexes
                     let parameters = i.Parameters ?? new Relation[0]
                     let values = 
                        (from p in parameters
                         where dict.ContainsKey(p.DataType.Reference)
                         let id = 
                            (from i in dict[p.DataType.Reference]
                             orderby i
                             select (p.Id, i)
                            ).ToList()
                         orderby p.Id
                         select id
                        ).Aggregate(new(), aggregator)
                     orderby i.Id
                     select (i.Id, values.ToArray())
                    )
                 orderby r.Id
                 select (r.Id, r.Item2)
                ).ToArray();

            var maps =
                (from r in (fieldMaps.Union(indexMaps))
                 orderby r.Item1
                 select r
                ).ToArray();

            var result = new List<(int key, (int member, int key)[] values)>
            {
                (0, roots)
            };

            result.AddRange(maps);

            return result.ToArray();
        }

        public IEnumerable<(int id, string reason)> Difference(MetaModel other)
        {
            var map = other.Elements?.ToDictionary(p => p.Id) ?? default;

            if (Elements is not null && map is not null)
            {
                for (int c = 0; c < Elements.Length; c++)
                {
                    if (map.TryGetValue(Elements[c].Id, out Element value))
                    {
                        foreach (var diff in Elements[c].Difference(value))
                            yield return diff;
                    }
                }
            }
        }
        public IEnumerable<(int id, string reason)> Warning(MetaModel other)
        {

            var map = 
                other
                .Elements?
                .GroupBy(p => p.Name.Reference)
                .ToDictionary(p => p.Key, v => v.ToDictionary(k => k.Id, v => v)) ?? default;

            if (Elements is not null && map is not null)
            {
                for (int c = 0; c < Elements.Length; c++)
                {
                    if (map.TryGetValue(Elements[c].Name.Reference, out var value))
                    {
                        if (!value.ContainsKey(Elements[c].Id))
                        {
                            foreach (var row in value)
                            {
                                if (Elements[c].Id != row.Value.Id)
                                    yield return (Elements[c].Id, $"{Elements[c].Name.Reference} name changed to existing element id {row.Value.Id}");
                                foreach (var diff in Elements[c].Warning(row.Value))
                                    yield return diff;
                            }
                        }
                    }
                }
            }
        }
    }
}