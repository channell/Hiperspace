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
using System.Diagnostics;

namespace Hiperspace.Meta
{
#if NET8_0_OR_GREATER
    [ProtoContract]
#endif
    [DebuggerDisplay("{Reference}")]
    public struct Name : IEquatable<Name>
    {
#if NET8_0_OR_GREATER
        [ProtoMember(1)]
#endif
        public string Reference { get; set; }
#if NET8_0_OR_GREATER
        [ProtoMember(2)]
#endif
        public Name[] Parameters { get; set; }

        public override bool Equals(object? other)
        {
            if (other is null) return false;
            if (other is Name value) return Equals(value);
            return false;
        }
        public bool Equals(Name other)
        {
            Parameters = Parameters ?? new Name[0];
            if (!Reference.Equals(other.Reference)) return false;
            if (Parameters.Length != 0 && other.Parameters?.Length == 0) return false;
            if (Parameters.Length == 0 && other.Parameters?.Length > 0) return false;
            if (other.Parameters is not null)
            {
                if (Parameters.Length != other.Parameters.Length) return false;
                for (int c = 0; c < Parameters.Length; ++c)
                {
                    if (!Parameters[c].Equals(other.Parameters[c])) return false;
                }
            }
            return true;
        }
        public override int GetHashCode()
        {
            Parameters ??= new Name[0];
            var hc = new HashCode();
            hc.Add(Reference);
            if (Parameters is not null)
                for (int c = 0; c < Parameters.Length; c++)
                    hc.Add(Parameters[c].GetHashCode());
            return hc.ToHashCode();
        }
        public static bool operator ==(Name left, Name right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Name left, Name right)
        {
            return !(left.Equals(right));
        }
    }
}
