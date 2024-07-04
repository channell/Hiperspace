// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf;
namespace Hiperspace.Meta
{
    [ProtoContract]
    public class MetaModel : IEquatable<MetaModel>
    {
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
                return Space.ValueBytes(cp);
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
                    if (!elmentmap.ContainsKey(other.Elements[c].Id))
                        elmentmap[other.Elements[c].Id] = other.Elements[c];
                Elements = elmentmap.Select(p => p.Value).ToArray();
            }
            else if (Elements == null)
            {
                Elements = other.Elements;
            }
        }
    }
}
