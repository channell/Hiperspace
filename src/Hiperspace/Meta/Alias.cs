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
using System.Collections;
using System.Diagnostics;

namespace Hiperspace.Meta
{
#if NET8_0_OR_GREATER
    [ProtoContract]
#endif
    [DebuggerDisplay("Alias {Name} ({Id})")]
#if NET8_0_OR_GREATER
    public struct Alias : IEquatable<Alias>
#else
    public struct Alias 
#endif
    {
#if NET8_0_OR_GREATER
        [ProtoMember(1)]
#endif
        public string Name { get; set; }
#if NET8_0_OR_GREATER
        [ProtoMember(2)]
#endif
        public Relation[] Parameters { get; set; }
#if NET8_0_OR_GREATER
        [ProtoMember(3)]
#endif
        public int Id { get; set; }

        public override bool Equals(object? other)
        {
            if (other is Alias value)
                return Equals(value);
            return false;
        }

        public bool Equals(Alias other)
        {
            Parameters = Parameters ?? new Relation[0];
            if (Id != other.Id) return false;
            var map = other.Parameters.ToDictionary(i => i.Id);
            for (int c = 0; c < Parameters.Length; c++) 
                if (map.TryGetValue(Parameters[c].Id, out Relation value))
                    if (!Parameters[c].Equals(value)) return false;

            return true;
        }
        public override int GetHashCode()
        {
            Parameters = Parameters ?? new Relation[0];
            var hc = new HashCode();
            hc.Add(Name);
            hc.Add(Id);
            for (int c = 0; c < Parameters.Length; c++)
                hc.Add(Parameters[c].GetHashCode());

            return hc.ToHashCode();
        }
        public IEnumerable<(int id, string reason)> Difference(string path, Alias other)
        {
            Parameters = Parameters ?? new Relation[0];

            var map = other.Parameters.ToDictionary(i => i.Id);
            for (int c = 0; c < Parameters.Length; c++)
                if (map.TryGetValue(Parameters[c].Id, out Relation value))
                    foreach (var diff in Parameters[c].Difference($"{path}.{Name}", value))
                        yield return diff;
        }
        public static bool operator ==(Alias left, Alias right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Alias left, Alias right)
        {
            return !(left.Equals(right));
        }
    }
}
