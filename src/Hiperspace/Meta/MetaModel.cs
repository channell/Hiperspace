// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024 Cepheis Ltd
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
            if (other == null) return false;
            if (other is MetaModel value)
                return Equals(value);
            return false;
        }
        public bool Equals(MetaModel? other)
        {
            if (other == null) return false;
            if (Elements == null) return true;      // other may introduce any element 

            var map = other.Elements?.ToDictionary(p => p.Id);
            if (map == null) return false;
            for (int c = 0; c < Elements.Length; c++)
                if (map.TryGetValue(Elements[c].Id, out Element value))
                    if (!Elements[c].Equals(value)) return false;
            return true;
        }

        public override int GetHashCode()
        {
            var hc = new HashCode();
            if (Elements != null)
                for (int c = 0; c < Elements.Length; c++)
                    hc.Add(Elements[c].GetHashCode());
            return hc.ToHashCode();
        }
        public void Merge(MetaModel other)
        {
            if (other.Elements != null && Elements != null)
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
            else if (Elements == null)
            {
                Elements = other.Elements;
            }
        }

        public (int key, (int member, int key)[] values)[] MetaMap()
        {
            var stores =
                (from e in Elements
                 where e.Category == "EntityImpl" || e.Category == "SegmentImpl" || e.Category == "AspectImpl"
                 orderby e.Id
                 select e
                ).ToArray();

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


            var dict = stores.ToDictionary(p => p.Name.Reference, p => p.Id);

            var result = new List<(int key, (int member, int key)[] values)>
            {
                (0, roots)
            };

            var fieldMaps =
                (from e in stores
                 let keys = e.Keys ?? new Field[0]
                 select (e.Id, (from k in keys
                                where dict.ContainsKey(k.DataType.Reference)
                                let id = dict[k.DataType.Reference]
                                orderby id
                                select (k.Id, id)
                                ).ToArray()
                 ));

            var indexMaps =
                (from i in indexes
                 let Pamrameters = i.Parameters ?? new Relation[0]
                 select (i.Id, (from p in Pamrameters
                                where dict.ContainsKey(p.DataType.Reference)
                                let id = dict[p.DataType.Reference]
                                orderby id
                                select (p.Id, id)
                                ).ToArray()
                 ));

            var maps =
                (from r in (fieldMaps.Union(indexMaps))
                 orderby r.Item1
                 select r
                ).ToArray();
            result.AddRange(maps);

            return result.ToArray();
        }

        public IEnumerable<(int id, string reason)> Difference(MetaModel other)
        {
            var map = other.Elements?.ToDictionary(p => p.Id) ?? default;

            if (Elements != null && map != null)
                for (int c = 0; c < Elements.Length; c++)
                    if (map.TryGetValue(Elements[c].Id, out Element value))
                    {
                        foreach (var diff in Elements[c].Difference(value))
                            yield return diff;
                    }
        }
    }
}