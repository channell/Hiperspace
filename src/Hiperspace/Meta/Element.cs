// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------

using ProtoBuf;
using System.Diagnostics;

namespace Hiperspace.Meta
{
    [ProtoContract]
    [DebuggerDisplay("Element {Name.Reference} {Category} ({Id})")]
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

        [ProtoMember(8)]
        public string? SetSpace { get; set; }


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
            if (Id != other.Id) return false;
            if (Category != other.Category) return false;
            if (Versioned != other.Versioned) return false;

            if (other.Keys is not null)
            {
                var keymap = other.Keys.ToDictionary(i => i.Id);
                for (int c = 0; c < Keys.Length; c++)
                    if (keymap.TryGetValue(Keys[c].Id, out Field value))
                        if (!Keys[c].Equals(value)) return false;
            }

            if (other.Values is not null)
            {
                var valuemap = other.Values.ToDictionary(i => i.Id);
                for (int c = 0; c < Values.Length; c++)
                    if (valuemap.TryGetValue(Values[c].Id, out Field value))
                        if (!Values[c].Equals(value)) return false;
            }
            if (other.Index is not null)
            {
                var indexmap = other.Index.ToDictionary(i => i.Id);
                for (int c = 0; c < Index.Length; c++)
                    if (indexmap.TryGetValue(Index[c].Id, out Alias value))
                        if (!Index[c].Equals(value)) return false;
            }

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
            Keys ??= new Field[0];
            Values ??= new Field[0];
            Index ??= new Alias[0];

            if (other.Keys is not null)
            {
                var keymap = Keys.ToDictionary(i => i.Id);
                for (int c = 0; c < other.Keys.Length; c++)
                    if (!keymap.ContainsKey(other.Keys[c].Id))
                        keymap[other.Keys[c].Id] = other.Keys[c];
                Keys = keymap.Select(p => p.Value).ToArray();
            }

            if (other.Values is not null)
            {
                var valuemap = Values.ToDictionary(i => i.Id);
                for (int c = 0; c < other.Values.Length; c++)
                    if (!valuemap.ContainsKey(other.Values[c].Id))
                        valuemap[other.Values[c].Id] = other.Values[c];
                Values = valuemap.Select(p => p.Value).ToArray();
            }

            if (other.Index is not null)
            {
                var indexmap = Index.ToDictionary(i => i.Id);
                for (int c = 0; c < other.Index.Length; c++)
                    if (!indexmap.ContainsKey(other.Index[c].Id))
                        indexmap[other.Index[c].Id] = other.Index[c];
                Index = indexmap.Select(p => p.Value).ToArray();
            }
        }

        public IEnumerable<(int id, string reason)> Difference(Element other)
        {
            if (Category != other.Category) yield return (Id, $"{Name.Reference} category changed from {Category} to {other.Category}");
            if (Versioned != other.Versioned) yield return (Id, $"{Name.Reference} versioned changed from {Versioned} to {other.Versioned}");

            if (other.Keys is not null)
            {
                var keymap = other.Keys.ToDictionary(i => i.Id);
                for (int c = 0; c < Keys.Length; c++)
                    if (keymap.TryGetValue(Keys[c].Id, out Field value))
                        foreach (var diff in Keys[c].Difference(Name.Reference, value))
                            yield return diff;
            }

            if (other.Values is not null)
            {
                var valuemap = other.Values.ToDictionary(i => i.Id);
                for (int c = 0; c < Values.Length; c++)
                    if (valuemap.TryGetValue(Values[c].Id, out Field value))
                        foreach (var diff in Values[c].Difference(Name.Reference, value))
                            yield return diff;
            }

            if (other.Index is not null)
            {
                var indexmap = other.Index.ToDictionary(i => i.Id);
                for (int c = 0; c < Index.Length; c++)
                    if (indexmap.TryGetValue(Index[c].Id, out Alias value))
                        foreach (var diff in Index[c].Difference(Name.Reference, value))
                            yield return diff;
            }
        }
        public IEnumerable<(int id, string reason)> Warning(Element other)
        {
            if (other.Keys is not null)
            {
                var keymap = other.Keys.ToDictionary(i => i.Name);
                for (int c = 0; c < Keys.Length; c++)
                    if (keymap.TryGetValue(Keys[c].Name, out Field value))
                        if (Keys[c].Id != value.Id)
                            yield return (Keys[c].Id, $"{Name.Reference}.{Keys[c].Name} key id changed from {Keys[c].Id} to {value.Id}");
            }

            if (other.Values is not null)
            {
                var valuemap = other.Values.ToDictionary(i => i.Name);
                for (int c = 0; c < Values.Length; c++)
                    if (valuemap.TryGetValue(Values[c].Name, out Field value))
                        if (Values[c].Id != value.Id)
                            yield return (Values[c].Id, $"{Name.Reference}.{Values[c].Name} value id changed from {Values[c].Id} to {value.Id}");
            }

            if (other.Index is not null)
            {
                var indexmap = other.Index.ToDictionary(i => i.Name);
                for (int c = 0; c < Index.Length; c++)
                    if (indexmap.TryGetValue(Index[c].Name, out Alias value))
                        if (Index[c].Id != value.Id)
                            yield return (Index[c].Id, $"{Name.Reference}.{Index[c].Name} index id changed from {Index[c].Id} to {value.Id}");
            }
        }
    }
}
