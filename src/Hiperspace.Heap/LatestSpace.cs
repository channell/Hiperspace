// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Hiperspace.Meta;
using System.Buffers.Binary;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace Hiperspace.Heap
{
    public class LatestSpace : HiperSpace
    {
        private SortedSet<HeapNode> _heap = new SortedSet<HeapNode>();

        public LatestSpace() 
        {
            TypeModel = new BaseTypeModel();
        }

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
            return Bind(key, value, source);
        }
        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            return Bind(key, value, source);
        }

        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, object? source)
        {
            return Task.Run(()=> Bind(key, value, source));
        }
        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source)
        {
            return Task.Run(() => Bind(key, value, version, source));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int Compare(Span<byte> left, Span<byte> right)
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

        public override IEnumerable<(byte[], byte[])> Find(byte[] begin, byte[] end)
        {
            RaiseOnBeforeFind(ref begin, ref end);
            lock (_heap)
            {
                var beginnode = new HeapNode(begin, Array.Empty<byte>());
                var endnode = new HeapNode(end, Array.Empty<byte>());
                var cursor =
                    _heap
                    .GetViewBetween(beginnode, endnode)
                    .Select(n => (n.Key, n.Value))
                    .ToArray();
                RaiseOnAfterFind(ref begin, ref end);
                return cursor;
            }
        }
        private static byte[] FF = new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff };

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            var now = DateTime.UtcNow;
            foreach (var v in Find(begin, end))
                yield return (v.Item1, now, v.Item2);
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> Nearest(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0)
        {
            space.Float();
            var ranks = new SortedSet<Nearest>();
            RaiseOnBeforeFind(ref begin, ref end);

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
                if (Compare(begin, row.Key) <= 0 && Compare(end, row.Key) >= 0)
                {
                    var keypart = row.Key;
                    var vec = Hiperspace.Space.FromValue<Vector>(TypeModel, row.Value);
                    var distance = space.Nearest(vec, method);
                    if (distance.HasValue)
                        ranks.Add(new Nearest(distance.Value, row.Key));
                }
            }
            var keys = limit == 0 ? ranks : ranks.Take(limit);

            foreach (var r in keys)
            {
                var res = Get(r.Key, version);
                yield return (r.Key, res.Item2, res.Item1, r.Distance);
            }

            RaiseOnAfterFind(ref begin, ref end);
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Delta(byte[] begin, DateTime? version)
        {
            var now = DateTime.UtcNow;
            var vbegin = new byte[begin.Length + sizeof(long) + 1];
            var vend = Hiperspace.Space.DeltaKey(begin);

            foreach (var v in Find (vbegin, vend))
                yield return (v.Item1, now, v.Item2);
        }


        public override IAsyncEnumerable<(byte[], byte[])> FindAsync(byte[] begin, byte[] end, CancellationToken cancellationToken = default)
        {
            return Find(begin, end).ToAsyncEnumerable();
        }
        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindAsync(byte[] begin, byte[] end, DateTime? version, CancellationToken cancellationToken = default)
        {
            return Find(begin, end, version).ToAsyncEnumerable();
        }

        public override byte[] Get(byte[] key)
        {
            RaiseOnBeforeGet(ref key);
            var result = Find(key, key).FirstOrDefault().Item2;
            RaiseOnAfterGet (ref key, ref result);
            return result;
        }
        public override (byte[], DateTime) Get(byte[] key, DateTime? version)
        {
            RaiseOnBeforeGet(ref key);
            var (_,d,v) = Find(key,key,version).FirstOrDefault();
            RaiseOnAfterGet(ref key, ref v);
            return (v, d);
        }

        public override Task<byte[]> GetAsync(byte[] key)
        {
            return Task.Run(() => Get(key));
        }
        public override Task<(byte[], DateTime)> GetAsync(byte[] key, DateTime? version)
        {
            return Task.Run(() => Get(key, version));
        }

        public override IEnumerable<(byte[] value, DateTime version)> GetVersions(byte[] key)
        {
            return Array.Empty<(byte[] value, DateTime version)>();
        }
        public override IAsyncEnumerable<(byte[] value, DateTime version)> GetVersionsAsync(byte[] key, CancellationToken cancellationToken = default)
        {
            return GetVersions(key).ToAsyncEnumerable(cancellationToken);
        }

        public async override IAsyncEnumerable<(byte[] Key, byte[] Value)> ExportAsync([EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            await foreach (var h in _heap.ToAsyncEnumerable(cancellationToken))
            {
                yield return (h.Key, h.Value);
            }
        }
        public async override void ImportAsync(IAsyncEnumerable<(byte[] Key, byte[] Value)> data, CancellationToken cancellationToken = default)
        {
            await foreach (var h in data.WithCancellation(cancellationToken))
            {
                Bind(h.Key, h.Value);
            }
        }

        #region node
        [DebuggerDisplay("{KeyHex} / {ValueHex}")]
        class HeapNode : IStructuralEquatable, IStructuralComparable, IComparable
        {
            public byte[] Key;
            public byte[] Value;
            public HeapNode(byte[] key, byte[] value) 
            {
                Key = key;
                Value = value;
            }
            public string KeyHex => BitConverter.ToString(Key);
            public string ValueHex => BitConverter.ToString(Value);
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
                if (other is null) return false;

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
                if (other is null) return 1;

                if (!(other is HeapNode objTuple))
                {
                    throw new ArgumentException($"Type {nameof(other)} is not compatible with Node");
                }
                var min = Key.Length < objTuple.Key.Length ? Key.Length : objTuple.Key.Length;
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

        /// <summary>
        /// HeapSpace does not need a MetaModel since it is not durable
        /// </summary>
        /// <returns>null</returns>
        public override MetaModel? GetMetaModel()
        {
            return null;
        }
        public override Task<MetaModel?> GetMetaModelAsync()
        {
            return Task.FromResult<MetaModel?>(null);
        }

        public override bool SetMetaModel(MetaModel metaModel)
        {
            return true;
        }
        public override Task<bool> SetMetaModelAsync(MetaModel metaModel)
        {
            return Task.FromResult(true);
        }
    }
}
