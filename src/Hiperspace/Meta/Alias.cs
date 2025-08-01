﻿// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------

using ProtoBuf;
using System.Collections;

namespace Hiperspace.Meta
{
    [ProtoContract]
    public struct Alias : IEquatable<Alias>
    {
        [ProtoMember(1)]
        public string Name { get; set; }
        [ProtoMember(2)]
        public Relation[] Parameters { get; set; }
        [ProtoMember(3)]
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
    }
}
