// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Buffers.Binary;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hiperspace.Heap
{
    public class HeapSpace : HiperSpace
    {
        private SortedSet<HeapNode> _heap = new SortedSet<HeapNode>();

        public HeapSpace() { }

        public override Result<byte[]> Bind(byte[] key, byte[] value, object? source = null)
        {
            var node = new HeapNode(key, value);
            lock (_heap)
            {
                if (_heap.TryGetValue(node, out HeapNode? result))
                {
                    return Result.Skip(result.Value);
                }
                _heap.Add(node);
                RaiseOnBind(key, value, source);
                return Result.Ok(value);
            }
        }
        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            var fullkey = new byte[key.Length + sizeof(long) + 1];
            key.CopyTo(fullkey, 1);
            BinaryPrimitives.WriteInt64BigEndian(new Span<byte>(fullkey, fullkey.Length - sizeof(long), sizeof(long)), version.Ticks);

            var (cur, v) = Get(key, version);
            if (cur != null)
            {
                if (v == version)
                    return Result.Skip(cur);
                if (Compare(cur, value) == 0)
                    return Result.Skip(cur);    // no change to value
            }

            lock (_heap)
            {
                var node = new HeapNode(fullkey, value);
                _heap.Add(node);
                RaiseOnBind(key, value, source);
                return Result.Ok(value);
            }
        }

        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, object? source)
        {
            return Task.Run(()=> Bind(key, value, source));
        }
        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source)
        {
            return Task.Run(() => Bind(key, value, version, source));
        }

        public override IEnumerable<(byte[], byte[])> Space()
        {
            foreach(var h in _heap)
            {
                yield return (h.Key, h.Value);
            }
        }

        public override Task<IEnumerable<(byte[], byte[])>> SpaceAsync()
        {
            return Task.Run(() =>
            {
                return _heap.Select(n => (n.Key, n.Value));
            });
        }

        private static int Compare(byte[] left, byte[] right)
        {
            var min = left.Length < right.Length ? left.Length : right.Length;
            for (var c = 0; c < min; c++)
            {
                var cmp = left[c].CompareTo(right[c]);
                if (cmp != 0)
                    return cmp;
            }
            return (left.Length) - (right.Length);
        }

        public override IEnumerable<(byte[], byte[])> Find(byte[] begin, byte[] end)
        {
            lock (_heap)
            {
                var beginnode = new HeapNode(begin, Array.Empty<byte>());
                var endnode = new HeapNode(end, Array.Empty<byte>());
                var cursor =
                    _heap
                    .GetViewBetween(beginnode, endnode)
                    .Select(n => (n.Key, n.Value))
                    .ToArray();
                return cursor;
            }
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            var vbegin = new byte[begin.Length + sizeof(long) + 1];
            var vend = new byte[end.Length + sizeof(long) + 1];

            begin.CopyTo(new Span<byte>(vbegin, 1, begin.Length));
            end.CopyTo(new Span<byte>(vend, 1, end.Length));
            for (int c = end.Length; c < vend.Length; c++) vend[c] = 0xFF;

            byte[] lastKey = Array.Empty<byte>();
            byte[] lastValue = Array.Empty<byte>();
            long lastVersion = 0;
            (byte[] Key, byte[] Value)[] cursor;

            lock (_heap)
            {
                var beginnode = new HeapNode(vbegin, Array.Empty<byte>());
                var endnode = new HeapNode(vend, Array.Empty<byte>());
                cursor =
                    _heap
                    .GetViewBetween(beginnode, endnode)
                    .Select(n => (n.Key, n.Value))
                    .ToArray();
            }
            foreach (var row in cursor)
            {
                if (Compare(vbegin, row.Key) <= 0 && Compare(vend, row.Key) >= 0)
                {
                    var keypart = new byte[row.Key.Length - sizeof(long) - 1];
                    for (int c = 0; c < keypart.Length; c++) keypart[c] = row.Key[c + 1];
                    if (Compare(keypart, lastKey) == 0 || lastKey == Array.Empty<byte>())
                    {
                        var ver = BinaryPrimitives.ReadInt64BigEndian(new Span<byte>(row.Key, row.Key.Length - sizeof(long), sizeof(long)));
                        if (!version.HasValue || (ver < version.Value.Ticks && ver > lastVersion))
                        {
                            lastKey = keypart;
                            lastVersion = ver;
                            lastValue = row.Value;
                        }
                    }
                    else if (lastVersion != 0)
                    {
                        yield return (lastKey, new DateTime(lastVersion), lastValue);
                        lastKey = keypart;
                        lastVersion = BinaryPrimitives.ReadInt64BigEndian(new Span<byte>(row.Key, row.Key.Length - sizeof(long), sizeof(long)));
                        lastValue = row.Value;
                    }
                }
            }
            if (lastVersion != 0)
            {
                yield return (lastKey, new DateTime(lastVersion), lastValue);
            }
        }

        public override Task<IEnumerable<(byte[], byte[])>> FindAsync(byte[] begin, byte[] end)
        {
            return Task.Run (() => Find (begin, end));
        }
        public override Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>> FindAsync(byte[] begin, byte[] end, DateTime? version)
        {
            return Task.Run(() => Find(begin, end, version).ToList() as IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>);
        }

        public override byte[] Get(byte[] key)
        {
            return Find(key, key).FirstOrDefault().Item2;
        }
        public override (byte[], DateTime) Get(byte[] key, DateTime? version)
        {
            var (_,d,v) = Find(key,key,version).LastOrDefault();
            return (v, d);
        }

        public override async Task<byte[]> GetAsync(byte[] key)
        {
            var node = new HeapNode(key, Array.Empty<byte>());
            var find = await FindAsync(key, key);
            return find.FirstOrDefault().Item2;
        }
        public override Task<(byte[], DateTime)> GetAsync(byte[] key, DateTime? version)
        {
            return Task.Run(() => Get(key, version));
        }

        public override IEnumerable<(byte[] value, DateTime version)> GetVersions(byte[] key)
        {
            var begin = new byte[key.Length + sizeof(long) + 1];
            var end = new byte[key.Length + sizeof(long) + 1];
            key.CopyTo(begin, 0);
            key.CopyTo(end, 0);
            BinaryPrimitives.WriteInt64BigEndian(new Span<byte>(begin, begin.Length - sizeof(long), sizeof(long)), 0);
            BinaryPrimitives.WriteInt64BigEndian(new Span<byte>(end, end.Length - sizeof(long), sizeof(long)), long.MaxValue);
            (byte[] Key, byte[] Value)[] cursor;

            lock (_heap)
            {
                var beginnode = new HeapNode(begin, Array.Empty<byte>());
                var endnode = new HeapNode(end, Array.Empty<byte>());
                cursor =
                    _heap
                    .GetViewBetween(beginnode, endnode)
                    .Select(n => (n.Key, n.Value))
                    .ToArray();
            }
            foreach (var row in cursor)
            {
                var keypart = new byte[row.Key.Length - sizeof(long)];
                row.Key.CopyTo(new Span<byte>(keypart, 0, keypart.Length));

                if (Compare(key, keypart) == 0)
                {
                    long ver = BinaryPrimitives.ReadInt64BigEndian(new Span<byte>(row.Key, row.Key.Length - sizeof(long), sizeof(long)));
                    yield return (row.Value, new DateTime(ver));
                }
            }
        }
        public override Task<IEnumerable<(byte[] value, DateTime version)>> GetVersionsAsync(byte[] key)
        {
            return Task.Run(() => GetVersions(key).ToList() as IEnumerable<(byte[], DateTime)>);
        }

        #region node
        class HeapNode : IStructuralEquatable, IStructuralComparable, IComparable
        {
            public byte[] Key;
            public byte[] Value;
            public HeapNode(byte[] key, byte[] value) 
            {
                Key = key;
                Value = value;
            }

            public override bool Equals([NotNullWhen(true)] object? obj)
            {
                return Equals(obj, EqualityComparer<object>.Default);
            }

            bool IStructuralEquatable.Equals([NotNullWhen(true)] object? other, IEqualityComparer comparer)
            {
                return Equals(other, comparer);
            }

            private bool Equals([NotNullWhen(true)] object? other, IEqualityComparer comparer)
            {
                if (other == null) return false;

                if (!(other is HeapNode objTuple))
                {
                    return false;
                }
                if (Key.Length - objTuple.Key.Length == 0)
                    return StructuralComparisons.StructuralEqualityComparer.Equals(Key, objTuple.Key);
                else
                    return false;
            }

            int IComparable.CompareTo(object? obj)
            {
                return CompareTo(obj, Comparer<object>.Default);
            }

            int IStructuralComparable.CompareTo(object? other, IComparer comparer)
            {
                return CompareTo(other, comparer);
            }

            private int CompareTo(object? other, IComparer comparer)
            {
                if (other == null) return 1;

                if (!(other is HeapNode objTuple))
                {
                    throw new ArgumentException($"Type {nameof(other)} is not compatible with Node");
                }
                var min = Key.Length < objTuple.Key.Length ? Key.Length : objTuple.Key.Length;
#if DEBUG
                var thisStr = asString(Key);
                var thatStr = asString(objTuple.Key);
#endif
                var cmp = CompareKeys(Key, objTuple.Key);
                return cmp;
            }
            private static int CompareKeys(byte[] left, byte[] right)
            {
                var min = left.Length < right.Length ? left.Length : right.Length;
                for (var c = 0; c < min; c++) 
                {
                    var cmp = left[c].CompareTo(right[c]);
                    if (cmp != 0)
                        return cmp;
                }
                return left.Length - right.Length;
            }

            public override int GetHashCode()
            {
                return GetHashCode(EqualityComparer<byte[]>.Default);
            }

            int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
            {
                return GetHashCode(comparer);
            }
            private int GetHashCode(IEqualityComparer comparer)
            {
                return comparer.GetHashCode(Key);
            }
        }
        #endregion
        protected override void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }

#if DEBUG
        public static string asString(byte[] b)
        {
            var sb = new StringBuilder();
            for (int c = 0; c < b.Length; c++)
            {
                sb.Append(Convert.ToChar(b[c]));
            }
            return sb.ToString();
        }
#endif

        public override Transaction BeginTransaction()
        {
            return new Transaction(this);
        }

        public override void EndTransaction()
        {
        }
    }
}
