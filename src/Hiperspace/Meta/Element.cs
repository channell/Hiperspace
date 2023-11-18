
using ProtoBuf;

namespace Hiperspace.Meta
{
    [ProtoContract]
    public struct Element : IEquatable<Element>
    {
        [ProtoMember(1)]
        public Name Name { get; set; }

        [ProtoMember(2)] 
        public string Category { get; set; }
        [ProtoMember(3)]
        public Field[] Keys { get; set; }
        [ProtoMember(4)]
        public Field[] Values { get; set; }
        [ProtoMember(5)]
        public Alias[] Index { get; set; }
        [ProtoMember(6)]
        public int Id { get; set; }
        [ProtoMember(7)]
        public bool Versioned { get; set; }

        public override bool Equals(object? other)
        {
            if (other is Element value)
                return Equals(value);
            return false;
        }

        public bool Equals(Element other)
        {
            Keys = Keys ?? new Field[0];
            Values = Values ?? new Field[0];
            Index = Index ?? new Alias[0];
            if (!Name.Equals(other.Name)) return false;
            if (Id != other.Id) return false;
            if (Category != other.Category) return false;
            if (Versioned != other.Versioned) return false;

            var keymap = other.Keys.ToDictionary(i => i.Id);
            for (int c = 0; c < Keys.Length; c++)
                if (keymap.TryGetValue(Keys[c].Id, out Field value))
                    if (!Keys[c].Equals(value)) return false;

            var valuemap = other.Values.ToDictionary(i => i.Id); 
            for (int c = 0; c < Values.Length; c++)
                if (valuemap.TryGetValue(Values[c].Id, out Field value))
                    if (!Values[c].Equals(value)) return false;

            var indexmap = other.Index.ToDictionary(i => i.Id);
            for (int c = 0; c < Index.Length; c++)
                if (indexmap.TryGetValue(Index[c].Id, out Alias value))
                    if (!Index[c].Equals (value)) return false;

            return true;
        }
        public override int GetHashCode()
        {
            Keys = Keys ?? new Field[0];
            Values = Values ?? new Field[0];
            Index = Index ?? new Alias[0];
            var hc = new HashCode();
            hc.Add(Name);
            hc.Add(Id);
            hc.Add(Versioned);
            for (int c = 0; c < Keys.Length; c++)
                hc.Add(Keys[c].GetHashCode());

            for (int c = 0; c < Values.Length; c++)
                hc.Add(Values[c].GetHashCode());

            for (int c = 0; c < Index.Length; c++)
                hc.Add(Index[c].GetHashCode());

            return hc.ToHashCode();
        }

        public void Merge (Element other)
        {
            Keys = Keys ?? new Field[0];
            Values = Values ?? new Field[0];
            Index = Index ?? new Alias[0];
            var keymap = Keys.ToDictionary(i => i.Id);
            for (int c = 0; c < other.Keys.Length; c++)
                if (!keymap.ContainsKey(other.Keys[c].Id))
                    keymap[other.Keys[c].Id] = other.Keys[c];
            Keys = keymap.Select(p => p.Value).ToArray();

            var valuemap = Values.ToDictionary(i => i.Id);
            for (int c = 0; c < other.Values.Length; c++)
                if (!valuemap.ContainsKey(other.Values[c].Id))
                    valuemap[other.Values[c].Id] = other.Values[c];
            Values = valuemap.Select(p => p.Value).ToArray();

            var indexmap = Index.ToDictionary(i => i.Id);
            for (int c = 0; c < other.Index.Length; c++)
                if (!indexmap.ContainsKey(other.Index[c].Id))
                    indexmap[other.Index[c].Id] = other.Index[c];
            Index = indexmap.Select(p => p.Value).ToArray();
        }
    }
}
