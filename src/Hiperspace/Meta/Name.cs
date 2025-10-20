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
    [DebuggerDisplay("{Reference}")]
    public struct Name : IEquatable<Name>
    {
        [ProtoMember(1)]
        public string Reference { get; set; }
        [ProtoMember(2)]
        public Name[] Parameters { get; set; }

        public override bool Equals(object? other)
        {
            if (other == null) return false;
            if (other is Name value) return Equals(value);
            return false;
        }
        public bool Equals(Name other)
        {
            Parameters = Parameters ?? new Name[0];
            if (!Reference.Equals(other.Reference)) return false;
            if (Parameters.Length != 0 && other.Parameters?.Length == 0) return false;
            if (Parameters.Length == 0 && other.Parameters?.Length > 0) return false;
            if (other.Parameters != null)
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
            if (Parameters != null)
                for (int c = 0; c < Parameters.Length; c++)
                    hc.Add(Parameters[c].GetHashCode());
            return hc.ToHashCode();
        }
    }
}
