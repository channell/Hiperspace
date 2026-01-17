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
    [DebuggerDisplay("Field {Name} {DataType.Reference} ({Id})")]
    public struct Field : IEquatable<Field>
    {
        [ProtoMember(1)]
        public string Name {  get; set; }
        [ProtoMember(2)]
        public Name DataType { get; set; }
        [ProtoMember(3)]
        public int Id { get; set; }

        public override bool Equals( object? other)
        {
            if (other is Field value)
                return Equals(value);
            return false;
        }
        public bool Equals(Field other)
        {
            if (!DataType.Equals(other.DataType)) return false;
            if (Id != other.Id) return false;
            return true;
        }
        public override int GetHashCode()
        {
            var hc = new HashCode();
            hc.Add(Name);
            hc.Add(DataType);
            hc.Add(Id);
            return hc.ToHashCode();
        }
        public IEnumerable<(int id, string reason)> Difference(string path, Field other)
        {

            if (!DataType.Equals(other.DataType))
                yield return (Id, $"{path}.{Name} dataType changed from {DataType.Reference} to {other.DataType.Reference}");
        }
    }
}
