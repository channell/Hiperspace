// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------

#if NET8_0_OR_GREATER
using ProtoBuf;
#endif

using System;
using System.Collections.Generic;

namespace Hiperspace.Meta
{
#if NET8_0_OR_GREATER
    [ProtoContract]
#endif
    [System.Diagnostics.DebuggerDisplay("Relation {Name} {DataType.Reference} ({Id})")]
    public struct Relation : IEquatable<Relation>
    {
#if NET8_0_OR_GREATER
        [ProtoMember(1)]
#endif
        public string Name { get; set; }
#if NET8_0_OR_GREATER
        [ProtoMember(2)]
#endif
        public Name DataType { get; set; }
#if NET8_0_OR_GREATER
        [ProtoMember(3)]
#endif
        public int Id { get; set; }

        public override bool Equals(object? other)
        {
            if (other is null) return false;
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
        public IEnumerable<(int id, string reason)> Difference(string path, Relation other)
        {

            if (!DataType.Equals(other.DataType))
                yield return (Id, $"{path}.{Name} dataType changed from {DataType} to {other.DataType}");
        }

        public static bool operator ==(Relation left, Relation right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Relation left, Relation right)
        {
            return !(left.Equals(right));
        }

    }
}
