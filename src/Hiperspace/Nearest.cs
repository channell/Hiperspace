// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Windows.Markup;

namespace Hiperspace
{
    /// <summary>
    /// Used to rank keys by distance in Nearest search in descending order 
    /// </summary>
    public struct Nearest : IEquatable<Nearest>, IComparable<Nearest>
    {
        public Nearest(double distance, byte[] key)
        {
            Distance = distance;
            Key = key;
        }
        public Nearest(double distance, byte[] key, byte[] value)
        {
            Distance = distance;
            Key = key;
            Value = value;
        }
        public Nearest ((byte[] Key, DateTime AsAt, byte[] Value, double Distance) tuple)
        {
            Distance = tuple.Distance;
            Key = tuple.Key;
            Value = tuple.Value;
            AsAt = tuple.AsAt;
        }

        public (byte[] Key, DateTime AsAt, byte[] Value, double Distance) ToTuple()
        {
            if (Value == null)
                return (Key, AsAt, Array.Empty<byte>(), Distance);
            else
                return (Key, AsAt, Value, Distance);
        }

        public readonly double Distance;
        public readonly byte[] Key; 
        public readonly byte[]? Value;
        public readonly DateTime AsAt;

        public bool Equals(Nearest other)
        {
            if (this == other) return true;
            return false;
        }
        public override bool Equals(Object? other)
        {
            if (other == null) return false;
            if (other is Nearest) return Equals((Nearest)other);
            return false;
        }
        public override int GetHashCode()
        {
            return Distance.GetHashCode();
        }

        public int CompareTo(Nearest other)
        {
            if (this < other) return -1;
            if (this > other) return 1;
            return 0;
        }
        public static bool operator ==(Nearest left, Nearest right)
        {
            if (left.Distance == right.Distance) 
                return true;
            else
                return false;
        }
        public static bool operator !=(Nearest left, Nearest right)
        {
            return !(left == right);
        }
        public static bool operator <(Nearest left, Nearest right)
        {
            return left.Distance < right.Distance;
        }
        public static bool operator >(Nearest left, Nearest right)
        {
            return left.Distance > right.Distance;
        }
    }
}
