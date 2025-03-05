using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Hiperspace
{
    public struct KeyPart : IEquatable<KeyPart>, IEquatable<byte[]>, IComparable<KeyPart>, IComparable<byte[]>
    {
        private byte[] _Key;

        public KeyPart(byte[] key)
        {
            _Key = key;
        }
        public int CompareTo(KeyPart other)
        {
            return Compare(_Key, other._Key);
        }

        public int CompareTo(byte[]? other)
        {
            return Compare(_Key, other);
        }

        public bool Equals(KeyPart other)
        {
            return Compare(_Key, other._Key) == 0;
        }

        public bool Equals(byte[]? other)
        {
            return Compare(_Key, other) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Compare(Span<byte> left, Span<byte> right)
        {
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
}
