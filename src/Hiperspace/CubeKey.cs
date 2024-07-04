// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf;
using System.Buffers.Binary;
using System.ComponentModel.DataAnnotations;

namespace Hiperspace
{
    /// <summary>
    /// A Key to a durable versioned Cube projection of a collections of Facts
    /// </summary>
    [ProtoContract]
    public struct CubeKey
    {
        [ProtoContract]
        public struct KeyPart
        {
            [ProtoMember(1)]
            public byte[]? Key;
        }

        [ProtoMember(1)] public KeyPart[]? Keys;

        public CubeKey()
        {

        }

        public CubeKey(KeyPart[] keys)
        {
            var ordered = new SortedSet<KeyPart>(Compare);
            for (int i = 0; i < keys.Length; i++)
            {
                ordered.Add(keys[i]);
            }
            Keys = ordered.ToArray();
        }
        private static KeyPart[] ToKeyParts(byte[][] keys)
        {
            var ret = new KeyPart[keys.Length];
            for (var i = 0; i < keys.Length; i++)
                ret[i] = new KeyPart { Key = keys[i] };
            return ret;
        }
        public CubeKey(byte[][] keys) : this(ToKeyParts(keys)) { }

        public object?[] Objects (SubSpace subSpace)
        {
            if (Keys == null || subSpace == null)
                return Array.Empty<object>();
            else
            {
                return Keys.Select(k => subSpace.Get(k)).ToArray();
            }
        }

        public static bool operator ==(CubeKey? left, CubeKey? right)
        {
            if (!left.HasValue || !right.HasValue)
                return false;
            else
            {
                var ll = left.Value.Keys?.Length ?? 0;
                var rl = right.Value.Keys?.Length ?? 0;
                var min = ll < rl ? ll : rl;
                for (int c = 0; c < min; c++)
                {
                    if (left.Value.Keys != null && right.Value.Keys != null)
                    {
                        var cmp = (Compare.Compare(left.Value.Keys[c], right.Value.Keys[c]));
                        if (cmp < 0) return false;
                        if (cmp > 0) return false;
                    }
                }
            }
            return true;
        }
        public static bool operator !=(CubeKey? left, CubeKey? right)
        {
            if (!left.HasValue || !right.HasValue)
                return true;
            else
            {
                var ll = left.Value.Keys?.Length ?? 0;
                var rl = right.Value.Keys?.Length ?? 0;
                var min = ll < rl ? ll : rl;
                for (int c = 0; c < min; c++)
                {
                    if (left.Value.Keys != null && right.Value.Keys != null)
                    {
                        var cmp = (Compare.Compare(left.Value.Keys[c], right.Value.Keys[c]));
                        if (cmp < 0) return true;
                        if (cmp > 0) return true;
                    }
                }
            }
            return true;
        }
        public static bool operator <(CubeKey? left, CubeKey? right)
        {
            if (left == null || right == null)
                return false;
            else
            {
                var ll = left.Value.Keys?.Length ?? 0;
                var rl = right.Value.Keys?.Length ?? 0;
                var min = ll < rl ? ll : rl;
                for (int c = 0; c < min; c++)
                {
                    if (left.Value.Keys != null && right.Value.Keys != null)
                    {
                        var cmp = (Compare.Compare(left.Value.Keys[c], right.Value.Keys[c]));
                        if (cmp < 0) return true;
                        if (cmp > 0) return false;
                    }
                }
            }
            return false;
        }
        public static bool operator >(CubeKey? left, CubeKey? right)
        {
            if (left == null || right == null)
                return false;
            else
            {
                var ll = left.Value.Keys?.Length ?? 0;
                var rl = right.Value.Keys?.Length ?? 0;
                var min = ll < rl ? ll : rl;
                for (int c = 0; c < min; c++)
                {
                    if (left.Value.Keys != null && right.Value.Keys != null)
                    {
                        var cmp = (Compare.Compare(left.Value.Keys[c], right.Value.Keys[c]));
                        if (cmp < 0) return false;
                        if (cmp > 0) return true;
                    }
                }
            }
            return false;
        }
        static KeyPartCompare Compare = new KeyPartCompare();
        internal class KeyPartCompare : IComparer<KeyPart>
        {
            public int Compare(KeyPart x, KeyPart y)
            {
                var left = new Span<byte>(x.Key);
                var right = new Span<byte>(y.Key);
                var min = left.Length < right.Length ? left.Length : right.Length;
                int c = 0, d = 0;

                // compare 8-byte chunks
                while ((d += sizeof(long)) < min)
                {
                    var longleft = BinaryPrimitives.ReadUInt64BigEndian(left.Slice(c, sizeof(long)));
                    var longright = BinaryPrimitives.ReadUInt64BigEndian(right.Slice(c, sizeof(long)));
                    if (longleft < longright)
                        return -1;
                    else if (longright < longleft)
                        return 1;
                    c = d;
                }
                // compare 4-byte chunks
                if (min - c > sizeof(int))
                {
                    var intleft = BinaryPrimitives.ReadUInt32BigEndian(left.Slice(c, sizeof(int)));
                    var intright = BinaryPrimitives.ReadUInt32BigEndian(right.Slice(c, sizeof(int)));
                    if (intleft < intright)
                        return -1;
                    else if (intright < intleft)
                        return 1;
                    c += sizeof(int);
                }
                // compare bytes
                while (c < min)
                {
                    if (left[c] < right[c])
                        return -1;
                    else if (left[c] > right[c])
                        return 1;
                    c++;
                }
                return left.Length < right.Length ? -1 : left.Length > right.Length ? 1 : 0;
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj is CubeKey ck)
            {
                var ll = Keys?.Length ?? 0;
                var rl = ck.Keys?.Length ?? 0;
                var min = ll < rl ? ll : rl;
                for (int c = 0; c < min; c++)
                {
                    if (Keys != null && ck.Keys != null)
                    {
                        var cmp = (Compare.Compare(Keys[c], ck.Keys[c]));
                        if (cmp < 0) return false;
                        if (cmp > 0) return false;
                    }
                }
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            HashCode hc = new HashCode();
            if (Keys == null || Keys == Array.Empty<KeyPart>()) return 0;
            for (int i = 0; i < Keys.Length; i++)
            {
                hc.Add(Keys[i].GetHashCode());
            }
            return hc.ToHashCode();
        }
    }
}