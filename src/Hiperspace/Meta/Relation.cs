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
    public struct Relation : IEquatable<Relation>
    {
        [ProtoMember(1)]
        public string Name { get; set; }
        [ProtoMember(2)]
        public Name DataType { get; set; }
        [ProtoMember(3)]
        public int Id { get; set; }

        public override bool Equals(object? other)
        {
            if (other == null) return false;
            if (other is Relation value) 
                return Equals(value);
            return false;
        }
        public bool Equals(Relation other)
        {
            if (!DataType.Equals(other.DataType)) return false;
            if (Id != other.Id) return false;
            return true;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, DataType, Id);
        }
    }
}
