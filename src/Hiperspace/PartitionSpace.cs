// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Channels;

namespace Hiperspace
{
    /// <summary>
    /// A hiperspace aggregate that partitions writes to multiple hiperspaces
    /// </summary>
    public class PartitionSpace : HiperSpace
    {
        private HiperSpace[] _spaces;

        public PartitionSpace([NotNull] HiperSpace[] aggregates)
        {
            if (aggregates.Length < 2)
                throw new ArgumentException($"{nameof(PartitionSpace)} should have at least two spaces");
            _spaces = aggregates;
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, object? source)
        {
            var partition = key.GetHashCode() % (_spaces.Length);
            return _spaces[partition].Bind(key, value, source);
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            var partition = key.GetHashCode() % (_spaces.Length);
            return _spaces[partition].Bind(key, value, version, source);
        }
        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            var partition = key.GetHashCode() % (_spaces.Length);
            return _spaces[partition].Bind(key, value, source);
        }

        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, object? source)
        {
            var partition = key.GetHashCode() % (_spaces.Length);
            return _spaces[partition].BindAsync(key, value, source);
        }
        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            var partition = key.GetHashCode() % (_spaces.Length);
            return _spaces[partition].BindAsync(key, value, version, source);
        }
        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            var partition = key.GetHashCode() % (_spaces.Length);
            return _spaces[partition].BindAsync(key, value, version, source);
        }

        public override IEnumerable<(byte[], byte[])> Find(byte[] begin, byte[] end)
        {
            var request = new Task<IEnumerable<(byte[] Key, byte[] Value)>>[_spaces.Length];
            var result = new IEnumerable<(byte[] Key, byte[] Value)>[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = Task.Run(() => _spaces[c].Find(begin, end));
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            var request = new Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>>[_spaces.Length];
            var result = new IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = Task.Run(() => _spaces[c].Find(begin, end, version));
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }

        public override async IAsyncEnumerable<(byte[], byte[])> FindAsync(byte[] begin, byte[] end, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(byte[] Key, byte[] Value)>();

            for (int c = 0; c < _spaces.Length; c++)
            {
                _ = Task.Run(async () =>
                {
                    await foreach (var item in _spaces[c].FindAsync(begin, end, cancellationToken))
                    {
                        await channel.Writer.WriteAsync(item, cancellationToken);
                    }
                }, cancellationToken);
            }

            await foreach (var item in channel.Reader.ReadAllAsync(cancellationToken))
            {
                yield return item;
            }
        }
        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindAsync(byte[] begin, byte[] end, DateTime? version, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(byte[] Key, DateTime AsAt, byte[] Value)>();

            for (int c = 0; c < _spaces.Length; c++)
            {
                _ = Task.Run(async () =>
                {
                    await foreach (var item in _spaces[c].FindAsync(begin, end, version, cancellationToken))
                    {
                        await channel.Writer.WriteAsync(item, cancellationToken);
                    }
                }, cancellationToken);
            }

            await foreach (var item in channel.Reader.ReadAllAsync(cancellationToken))
            {
                yield return item;
            }
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndex(byte[] begin, byte[] end, DateTime? version)
        {
            var request = new Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>>[_spaces.Length];
            var result = new IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = Task.Run(() => _spaces[c].FindIndex(begin, end, version));
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }

        public override async IAsyncEnumerable<(byte[] Key, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(byte[] Key, byte[] Value)>();

            for (int c = 0; c < _spaces.Length; c++)
            {
                _ = Task.Run(async () =>
                {
                    await foreach (var item in _spaces[c].FindIndexAsync(begin, end, cancellationToken))
                    {
                        await channel.Writer.WriteAsync(item, cancellationToken);
                    }
                }, cancellationToken);
            }

            await foreach (var item in channel.Reader.ReadAllAsync(cancellationToken))
            {
                yield return item;
            }
        }
        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, DateTime? version, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(byte[] Key, DateTime AsAt, byte[] Value)>();

            for (int c = 0; c < _spaces.Length; c++)
            {
                _ = Task.Run(async () =>
                {
                    await foreach (var item in _spaces[c].FindIndexAsync(begin, end, version, cancellationToken))
                    {
                        await channel.Writer.WriteAsync(item, cancellationToken);
                    }
                }, cancellationToken);
            }

            await foreach (var item in channel.Reader.ReadAllAsync(cancellationToken))
            {
                yield return item;
            }
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

        public override (byte[] Key, byte[] Value)? GetFirst(byte[] begin, byte[] end)
        {
            var request = new Task<(byte[] Key, byte[] Value)?>[_spaces.Length];
            var result = new (byte[] Key, byte[] Value)?[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = Task.Run(() => _spaces[c].GetFirst(begin, end));
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }

            var first = result[0];
            for (int c = 1; c < _spaces.Length; c++)
            {
                if (!first.HasValue)
                {
                    first = result[c];
                }
                else if (result[c].HasValue)
                {
                    var val = result[c];
                    if (val.HasValue)
                    {
                        switch (Compare(first.Value.Key, val.Value.Key))
                        {
                            case -1:
                                first = result[c];
                                break;
                        }
                    }
                }
            }
            return first;
        }
        public override async Task<(byte[] Key, byte[] Value)?> GetFirstAsync(byte[] begin, byte[] end)
        {
            var request = new Task<(byte[] Key, byte[] Value)?>[_spaces.Length];
            var result = new (byte[] Key, byte[] Value)?[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = _spaces[c].GetFirstAsync(begin, end);
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = await request[c];
            }

            var first = result[0];
            for (int c = 1; c < _spaces.Length; c++)
            {
                if (!first.HasValue)
                {
                    first = result[c];
                }
                else if (result[c].HasValue)
                {
                    var val = result[c];
                    if (val.HasValue)
                    {
                        switch (Compare(first.Value.Key, val.Value.Key))
                        {
                            case -1:
                                first = result[c];
                                break;
                        }
                    }
                }
            }
            return first;
        }
        public override (byte[] Key, DateTime AsAt, byte[] Value)? GetFirst(byte[] begin, byte[] end, DateTime? version)
        {
            var request = new Task<(byte[] Key, DateTime AsAt, byte[] Value)?>[_spaces.Length];
            var result = new (byte[] Key, DateTime AsAt, byte[] Value)?[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = Task.Run(() => _spaces[c].GetFirst(begin, end, version));
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }

            var first = result[0];
            for (int c = 1; c < _spaces.Length; c++)
            {
                if (!first.HasValue)
                {
                    first = result[c];
                }
                else if (result[c].HasValue)
                {
                    var val = result[c];
                    if (val.HasValue)
                    {
                        switch (Compare(first.Value.Key, val.Value.Key))
                        {
                            case -1:
                                first = result[c];
                                break;
                        }
                    }
                }
            }
            return first;
        }
        public override async Task<(byte[] Key, DateTime AsAt, byte[] Value)?> GetFirstAsync(byte[] begin, byte[] end, DateTime? version)
        {
            var request = new Task<(byte[] Key, DateTime AsAt, byte[] Value)?>[_spaces.Length];
            var result = new (byte[] Key, DateTime AsAt, byte[] Value)?[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = _spaces[c].GetFirstAsync(begin, end, version);
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = await request[c];
            }

            var first = result[0];
            for (int c = 1; c < _spaces.Length; c++)
            {
                if (!first.HasValue)
                {
                    first = result[c];
                }
                else if (result[c].HasValue)
                {
                    var val = result[c];
                    if (val.HasValue)
                    {
                        switch (Compare(first.Value.Key, val.Value.Key))
                        {
                            case -1:
                                first = result[c];
                                break;
                        }
                    }
                }
            }
            return first;
        }
        public override (byte[] Key, byte[] Value)? GetLast(byte[] begin, byte[] end)
        {
            var request = new Task<(byte[] Key, byte[] Value)?>[_spaces.Length];
            var result = new (byte[] Key, byte[] Value)?[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = Task.Run(() => _spaces[c].GetFirst(begin, end));
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }

            var last = result[0];
            for (int c = 1; c < _spaces.Length; c++)
            {
                if (!last.HasValue)
                {
                    last = result[c];
                }
                else if (result[c].HasValue)
                {
                    var val = result[c];
                    if (val.HasValue)
                    {
                        switch (Compare(last.Value.Key, val.Value.Key))
                        {
                            case 1:
                                last = result[c];
                                break;
                        }
                    }
                }
            }
            return last;
        }
        public override async Task<(byte[] Key, byte[] Value)?> GetLastAsync(byte[] begin, byte[] end)
        {
            var request = new Task<(byte[] Key, byte[] Value)?>[_spaces.Length];
            var result = new (byte[] Key, byte[] Value)?[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = _spaces[c].GetFirstAsync(begin, end);
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = await request[c];
            }

            var last = result[0];
            for (int c = 1; c < _spaces.Length; c++)
            {
                if (!last.HasValue)
                {
                    last = result[c];
                }
                else if (result[c].HasValue)
                {
                    var val = result[c];
                    if (val.HasValue)
                    {
                        switch (Compare(last.Value.Key, val.Value.Key))
                        {
                            case 1:
                                last = result[c];
                                break;
                        }
                    }
                }
            }
            return last;
        }
        public override (byte[] Key, DateTime AsAt, byte[] Value)? GetLast(byte[] begin, byte[] end, DateTime? version)
        {
            var request = new Task<(byte[] Key, DateTime AsAt, byte[] Value)?>[_spaces.Length];
            var result = new (byte[] Key, DateTime AsAt, byte[] Value)?[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = Task.Run(() => _spaces[c].GetFirst(begin, end, version));
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }

            var last = result[0];
            for (int c = 1; c < _spaces.Length; c++)
            {
                if (!last.HasValue)
                {
                    last = result[c];
                }
                else if (result[c].HasValue)
                {
                    var val = result[c];
                    if (val.HasValue)
                    {
                        switch (Compare(last.Value.Key, val.Value.Key))
                        {
                            case 1:
                                last = result[c];
                                break;
                        }
                    }
                }
            }
            return last;
        }
        public override async Task<(byte[] Key, DateTime AsAt, byte[] Value)?> GetLastAsync(byte[] begin, byte[] end, DateTime? version)
        {
            var request = new Task<(byte[] Key, DateTime AsAt, byte[] Value)?>[_spaces.Length];
            var result = new (byte[] Key, DateTime AsAt, byte[] Value)?[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = _spaces[c].GetFirstAsync(begin, end, version);
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = await request[c];
            }

            var last = result[0];
            for (int c = 1; c < _spaces.Length; c++)
            {
                if (!last.HasValue)
                {
                    last = result[c];
                }
                else if (result[c].HasValue)
                {
                    var val = result[c];
                    if (val.HasValue)
                    {
                        switch (Compare(last.Value.Key, val.Value.Key))
                        {
                            case 1:
                                last = result[c];
                                break;
                        }
                    }
                }
            }
            return last;
        }
        public override IEnumerable<(byte[] key, byte[] value)> GetMany(IEnumerable<byte[]> keys)
        {
            var request = new Task<IEnumerable<(byte[] key, byte[] value)>>[_spaces.Length];
            var result = new IEnumerable<(byte[] Key, byte[] Value)>[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = Task.Run(() => _spaces[c].GetMany(keys));
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }
        public override IEnumerable<(byte[] key, byte[] Value, DateTime version)> GetMany(IEnumerable<byte[]> keys, DateTime? version)
        {
            var request = new Task<IEnumerable<(byte[] key, byte[] Value, DateTime version)>>[_spaces.Length];
            var result = new IEnumerable<(byte[] key, byte[] Value, DateTime version)>[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = Task.Run(() => _spaces[c].GetMany(keys, version));
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }
        public override IAsyncEnumerable<(byte[] key, byte[] value)> GetManyAsync(IAsyncEnumerable<byte[]> keys, CancellationToken cancellationToken = default)
        {
            return GetMany(keys.ToBlockingEnumerable()).ToAsyncEnumerable(cancellationToken);
        }
        public override IAsyncEnumerable<(byte[] key, byte[] Value, DateTime version)> GetManyAsync(IAsyncEnumerable<byte[]> keys, DateTime? version, CancellationToken cancellationToken = default)
        {
            return GetMany(keys.ToBlockingEnumerable(), version).ToAsyncEnumerable(cancellationToken);
        }

        public override IEnumerable<(byte[] Key, byte[] Value)> Scan(byte[] begin, byte[] end, byte[][] values)
        {
            var request = new Task<IEnumerable<(byte[] Key, byte[] Value)>>[_spaces.Length];
            var result = new IEnumerable<(byte[] Key, byte[] Value)>[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = Task.Run(() => _spaces[c].Scan(begin, end, values));
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Scan(byte[] begin, byte[] end, byte[][] values, DateTime? version)
        {
            var request = new Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>>[_spaces.Length];
            var result = new IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = Task.Run(() => _spaces[c].Scan(begin, end, values, version));
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }
        public override IAsyncEnumerable<(byte[] Key, byte[] Value)> ScanAsync(byte[] begin, byte[] end, byte[][] values, CancellationToken cancellationToken = default)
        {
            return Scan(begin, end, values).ToAsyncEnumerable(cancellationToken);
        }
        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> ScanAsync(byte[] begin, byte[] end, byte[][] values, DateTime? version, CancellationToken cancellationToken = default)
        {
            return Scan(begin, end, values, version).ToAsyncEnumerable(cancellationToken);
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindDelta(byte[] begin, DateTime? version, DateTime? DeltaFrom)
        {
            var request = new Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>>[_spaces.Length];
            var result = new IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                request[c] = Task.Run(() => _spaces[c].FindDelta(begin, version, DeltaFrom));
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> Nearest(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0)
        {
            var ranks = new SortedSet<Nearest>();
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var result in _spaces[c].Nearest(begin, end, version, space, method, limit))
                    ranks.Add(new Nearest(result));
            }
            var keys = limit == 0 ? ranks : ranks.Take(limit);
            foreach (var key in keys)
                yield return key.ToTuple();
        }
        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> NearestAsync(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0, CancellationToken cancellationToken = default)
        {
            return Nearest(begin, end, version, space, method, limit).ToAsyncEnumerable(cancellationToken);
        }
        public override IEnumerable<(byte[] value, DateTime version)> GetVersions(byte[] key)
        {
            var partition = key.GetHashCode() % (_spaces.Length);
            return _spaces[partition].GetVersions(key);
        }

        public override IAsyncEnumerable<(byte[] value, DateTime version)> GetVersionsAsync(byte[] key, CancellationToken cancellationToken = default)
        {
            var partition = key.GetHashCode() % (_spaces.Length);
            return _spaces[partition].GetVersionsAsync(key, cancellationToken);
        }

        public override byte[] Get(byte[] key)
        {
            var partition = key.GetHashCode() % (_spaces.Length);
            return _spaces[partition].Get(key);
        }
        public override (byte[], DateTime) Get(byte[] key, DateTime? version)
        {
            var partition = key.GetHashCode() % (_spaces.Length);
            return _spaces[partition].Get(key, version);
        }

        public override Task<byte[]> GetAsync(byte[] key)
        {
            var partition = key.GetHashCode() % (_spaces.Length);
            return _spaces[partition].GetAsync(key);
        }
        public override Task<(byte[], DateTime)> GetAsync(byte[] key, DateTime? version)
        {
            var partition = key.GetHashCode() % (_spaces.Length);
            return _spaces[partition].GetAsync(key, version);
        }

        public override IEnumerable<(byte[], byte[])> Space()
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var b in _spaces[c].Space())
                    yield return b;
            }
        }

        public override IAsyncEnumerable<(byte[], byte[])> SpaceAsync(CancellationToken cancellationToken = default)
        {
            return Space().ToAsyncEnumerable(cancellationToken);
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Delta(byte[] key, DateTime? version)
        {
            var partition = key.GetHashCode() % (_spaces.Length);
            return _spaces[partition].Delta(key, version);
        }
        public override IEnumerable<Horizon> GetHorizons()
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var h in _spaces[c].GetHorizons())
                    yield return h;
            }
        }
    }
}
