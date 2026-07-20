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
using System.Diagnostics;

namespace Hiperspace.Meta
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#if NET8_0_OR_GREATER
    [ProtoContract]
#endif
    [DebuggerDisplay("Field {Name} {DataType.Reference} ({Id})")]
    public class Field : IEquatable<Field>
    {
#if NET8_0_OR_GREATER
        [ProtoMember(1)]
#endif
        public string Name {  get; set; }
#if NET8_0_OR_GREATER
        [ProtoMember(2)]
#endif
        public Name DataType { get; set; }
#if NET8_0_OR_GREATER
        [ProtoMember(3)]
#endif
        public int Id { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        public override bool Equals( object? other)
        {
            if (other is Field value)
                return Equals(value);
            return false;
        }
        public bool Equals(Field? other)
        {
            if (other is null) return false;
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
        public static bool operator ==(Field left, Field right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Field  left, Field right)
        {
            return !(left.Equals(right));
        }
    }
}
