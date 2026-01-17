// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Hiperspace.Heap
{
    public class CacheHeapSpace : HeapSpace
    {

        public CacheHeapSpace() : base() { }

        [Obsolete("use Bind((byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)")]
        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            var fullkey = new byte[key.Length + 1];
            key.CopyTo(fullkey, 1);
            var node = new HeapNode(fullkey, value);
            lock (_heap)
            {
                if (_heap.TryGetValue(node, out HeapNode? result) && Compare(result.Value, value) != 0)
                {
                    return Result.Skip(result.Value);
                }
                _heap.Remove(node);
                _heap.Add(node);
                RaiseOnBind(key, value, source);
                return Result.Ok(value);
            }
        }
        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            var fullkey = new byte[key.Length + 1];
            key.CopyTo(fullkey, 1);
            var node = new HeapNode(fullkey, value);
            lock (_heap)
            {
                if (_heap.TryGetValue(node, out HeapNode? result) && Compare(result.Value, value) != 0)
                {
                    return Result.Skip(result.Value);
                }
                _heap.Remove(node);
                _heap.Add(node);
                RaiseOnBind(key, value, source);
                return Result.Ok(value);
            }
        }

        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, object? source)
        {
            return Task.Run(() => Bind(key, value, source));
        }
        [Obsolete("use BindAsync((byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)")]
        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source)
        {
            return Task.Run(() => Bind(key, value, version, source));
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            var vbegin = new byte[begin.Length + 1];
            var vend = new byte[end.Length + 1];
            begin.CopyTo(new Span<byte>(vbegin, 1, begin.Length));
            end.CopyTo(new Span<byte>(vend, 1, end.Length));
            var now = DateTime.UtcNow;
            foreach (var v in Find(vbegin, vend))
            {
                var keypart = new byte[v.Item1.Length - 1];
                var span = new Span<byte>(v.Item1, 1, v.Item1.Length - 1);
                span.CopyTo(keypart);
                yield return (keypart, now, v.Item2);
            }
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> Nearest(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0, double? distanceLimit = null)
        {
            space.Float();
            var ranks = new SortedSet<Nearest>();
            RaiseOnBeforeFind(ref begin, ref end);

            var vbegin = new byte[begin.Length + 2];
            var vend = new byte[end.Length + 2];
            begin.CopyTo(new Span<byte>(vbegin, 2, begin.Length));
            end.CopyTo(new Span<byte>(vend, 2, end.Length));
            var beginnode = new HeapNode(vbegin, Array.Empty<byte>());
            var endnode = new HeapNode(vend, Array.Empty<byte>());
            (byte[] Key, byte[] Value)[] cursor;

            lock (_heap)
            {
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
                    var vec = Space.FromValue<Vector>(TypeModel, row.Value);
                    var distance = space.Nearest(vec, method);
                    if (distance.HasValue && (distanceLimit is null || distance <= distanceLimit))
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
            var vbegin = new byte[begin.Length + 1];
            begin.CopyTo(vbegin, 1);
            var vend = Hiperspace.Space.DeltaKey(begin);

            foreach (var v in Find(vbegin, vend))
                yield return (v.Item1, now, v.Item2);
        }

        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindAsync(byte[] begin, byte[] end, DateTime? version, CancellationToken cancellationToken = default)
        {
            return Find(begin, end, version).ToAsyncEnumerable();
        }

        public override (byte[], DateTime) Get(byte[] key, DateTime? version)
        {
            RaiseOnBeforeGet(ref key);
            var (_, d, v) = Find(key, key, version).FirstOrDefault();
            RaiseOnAfterGet(ref key, ref v);
            return (v, d);
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
                if (h.Key.Length > 2 && h.Key[0] == 0x00 && h.Key[1] != 0x00) // not metadata
                {
                    var fullkey = new byte[h.Key.Length + sizeof(long)];
                    h.Key.CopyTo(fullkey, 0);
                    var toend = ulong.MaxValue - (ulong)DateTime.UtcNow.Ticks;
                    BinaryPrimitives.WriteUInt64BigEndian(new Span<byte>(fullkey, fullkey.Length - sizeof(long), sizeof(long)), toend);
                    yield return (fullkey, h.Value);
                }
                else
                    yield return (h.Key, h.Value);
            }
        }
        public async override void ImportAsync(IAsyncEnumerable<(byte[] Key, byte[] Value)> data, CancellationToken cancellationToken = default)
        {
            await foreach (var (key, value) in data.WithCancellation(cancellationToken))
            {
                if (key.Length > 2 && key[0] == 0x00 && key[1] != 0x00) // not metadata
                {
                    var storekey = new byte[key.Length - sizeof(long)];
                    var keyspan = new Span<byte>(key, 0, key.Length - sizeof(long));
                    keyspan.CopyTo(storekey);
                }
                else
                    Bind(key, value);
            }
        }
    }
}
