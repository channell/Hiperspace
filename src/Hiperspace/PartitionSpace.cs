﻿// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
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
            return FindAsync(begin, end).ToBlockingEnumerable();
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            return FindAsync(begin, end, version).ToBlockingEnumerable();
        }

        public override async IAsyncEnumerable<(byte[], byte[])> FindAsync(byte[] begin, byte[] end, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof, (byte[] Key, byte[] Value))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            for (int c = 0; c < _spaces.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _spaces[C].FindAsync(begin, end, cancellationToken))
                        {
                            await channel.Writer.WriteAsync((false, item), cancellationToken);
                        }
                    }
                    finally
                    {
                        await channel.Writer.WriteAsync((true, (Array.Empty<byte>(), Array.Empty<byte>())), cancellationToken);
                    }
                }, cancellationToken);
            }
            await foreach (var (eof,item) in channelEnumerator)
            {
                if (eof)
                {
                    if (--dispatched == 0)
                        break;
                }
                else
                    yield return item;
            }
        }
        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindAsync(byte[] begin, byte[] end, DateTime? version, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof, (byte[] Key, DateTime AsAt, byte[] Value))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            for (int c = 0; c < _spaces.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _spaces[C].FindAsync(begin, end, version, cancellationToken))
                        {
                            await channel.Writer.WriteAsync((false, item), cancellationToken);
                        }
                    }
                    finally
                    {
                        await channel.Writer.WriteAsync((true, (Array.Empty<byte>(), new DateTime(), Array.Empty<byte>())), cancellationToken);
                    }
                }, cancellationToken);
            }

            await foreach (var (eof, item) in channelEnumerator)
            {
                if (eof)
                {
                    if (--dispatched == 0)
                        break;
                }
                else
                    yield return item;
            }
        }
        public override IEnumerable<(byte[] Key, byte[] Value)> FindIndex(byte[] begin, byte[] end)
        {
            return FindAsync(begin, end).ToBlockingEnumerable();
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndex(byte[] begin, byte[] end, DateTime? version)
        {
            return FindAsync(begin, end, version).ToBlockingEnumerable();
        }

        public override async IAsyncEnumerable<(byte[] Key, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof, (byte[] Key, byte[] Value))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            for (int c = 0; c < _spaces.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _spaces[C].FindAsync(begin, end, cancellationToken))
                        {
                            var value = await GetAsync(item.Value);
                            await channel.Writer.WriteAsync((false, (item.Value, value)), cancellationToken);
                        }
                    }
                    finally
                    {
                        await channel.Writer.WriteAsync((true, (Array.Empty<byte>(), Array.Empty<byte>())), cancellationToken);
                    }
                }, cancellationToken);
            }
            await foreach (var (eof, item) in channelEnumerator)
            {
                if (eof)
                {
                    if (--dispatched == 0)
                        break;
                }
                else
                    yield return item;
            }
        }
        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, DateTime? version, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof, (byte[] Key, DateTime AsAt, byte[] Value))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            for (int c = 0; c < _spaces.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _spaces[C].FindAsync(begin, end, version, cancellationToken))
                        {
                            var (value, asAt) = await GetAsync(item.Value, version);
                            await channel.Writer.WriteAsync((false, (item.Value, asAt, value)), cancellationToken);
                        }
                    }
                    finally
                    {
                        await channel.Writer.WriteAsync((true, (Array.Empty<byte>(), new DateTime(), Array.Empty<byte>())), cancellationToken);
                    }
                }, cancellationToken);
            }
            await foreach (var (eof, item) in channelEnumerator)
            {
                if (eof)
                {
                    if (--dispatched == 0)
                        break;
                }
                else
                    yield return item;
            }
        }

        public override (byte[] Key, byte[] Value)? GetFirst(byte[] begin, byte[] end)
        {
            return GetFirstAsync(begin, end).GetAwaiter().GetResult();
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
                        switch (KeyPart.Compare(first.Value.Key, val.Value.Key))
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
            return GetFirstAsync(begin, end, version).GetAwaiter().GetResult();
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
                        switch (KeyPart.Compare(first.Value.Key, val.Value.Key))
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
            return GetLastAsync(begin, end).GetAwaiter().GetResult();
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
                        switch (KeyPart.Compare(last.Value.Key, val.Value.Key))
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
            return GetLastAsync(begin, end, version).GetAwaiter().GetResult();
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
                        switch (KeyPart.Compare(last.Value.Key, val.Value.Key))
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
        public static async IAsyncEnumerable<T> AsyncEnumerable<T>(IEnumerable<T> source)
        {
            foreach (var item in source)
            {
                yield return await Task.FromResult(item);
            }
        }

        public override IEnumerable<(byte[] key, byte[] value)> GetMany(IEnumerable<byte[]> keys)
        {
            return GetManyAsync(AsyncEnumerable(keys)).ToBlockingEnumerable();
        }
        public override IEnumerable<(byte[] key, byte[] Value, DateTime version)> GetMany(IEnumerable<byte[]> keys, DateTime? version)
        {
            return GetManyAsync(AsyncEnumerable(keys), version).ToBlockingEnumerable();
        }
        public override async IAsyncEnumerable<(byte[] key, byte[] value)> GetManyAsync(IAsyncEnumerable<byte[]> keys, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof, (byte[] Key, byte[] Value))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            await foreach (var key in keys)
            {
                for (int c = 0; c < _spaces.Length; c++)
                {
                    dispatched++;
                    var C = c;
                    _ = Task.Run(async () =>
                    {
                        try
                        {
                            var item = await _spaces[C].GetAsync(key);
                            await channel.Writer.WriteAsync((false, (key, item)), cancellationToken);
                        }
                        finally
                        {
                            await channel.Writer.WriteAsync((true, (Array.Empty<byte>(), Array.Empty<byte>())), cancellationToken);
                        }
                    }, cancellationToken);
                }
            }
            await foreach (var (eof, item) in channelEnumerator)
            {
                if (eof)
                {
                    if (--dispatched == 0)
                        break;
                }
                else
                    yield return item;
            }
        }
        public override async IAsyncEnumerable<(byte[] key, byte[] Value, DateTime version)> GetManyAsync(IAsyncEnumerable<byte[]> keys, DateTime? version, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof, (byte[] Key, byte[] Value, DateTime version))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            await foreach (var key in keys)
            {
                for (int c = 0; c < _spaces.Length; c++)
                {
                    dispatched++;
                    var C = c;
                    _ = Task.Run(async () =>
                    {
                        try
                        {
                            var (item, ver) = await _spaces[C].GetAsync(key, version);
                            await channel.Writer.WriteAsync((false, (key, item, ver)), cancellationToken);
                        }
                        finally
                        {
                            await channel.Writer.WriteAsync((true, (Array.Empty<byte>(), Array.Empty<byte>(), new DateTime())), cancellationToken);
                        }
                    }, cancellationToken);
                }
            }
            await foreach (var (eof, item) in channelEnumerator)
            {
                if (eof)
                {
                    if (--dispatched == 0)
                        break;
                }
                else
                    yield return item;
            }
        }

        public override IEnumerable<(byte[] Key, byte[] Value)> Scan(byte[] begin, byte[] end, byte[][] values)
        {
            return ScanAsync(begin, end, values).ToBlockingEnumerable();
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Scan(byte[] begin, byte[] end, byte[][] values, DateTime? version)
        {
            return ScanAsync(begin, end, values, version).ToBlockingEnumerable();
        }
        public override async IAsyncEnumerable<(byte[] Key, byte[] Value)> ScanAsync(byte[] begin, byte[] end, byte[][] values, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof, (byte[] Key, byte[] Value))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            for (int c = 0; c < _spaces.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _spaces[C].ScanAsync(begin, end, values, cancellationToken))
                        {
                            await channel.Writer.WriteAsync((false, item), cancellationToken);
                        }
                    }
                    finally
                    {
                        await channel.Writer.WriteAsync((true, (Array.Empty<byte>(), Array.Empty<byte>())), cancellationToken);
                    }
                }, cancellationToken);
            }

            await foreach (var (eof, item) in channelEnumerator)
            {
                if (eof)
                {
                    if (--dispatched == 0)
                        break;
                }
                else
                    yield return item;
            }
        }
        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> ScanAsync(byte[] begin, byte[] end, byte[][] values, DateTime? version, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof, (byte[] Key, DateTime AsAt, byte[] Value))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            for (int c = 0; c < _spaces.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _spaces[C].ScanAsync(begin, end, values, version, cancellationToken))
                        {
                            await channel.Writer.WriteAsync((false, item), cancellationToken);
                        }
                    }
                    finally
                    {
                        await channel.Writer.WriteAsync((true, (Array.Empty<byte>(), new DateTime(), Array.Empty<byte>())), cancellationToken);
                    }
                }, cancellationToken);
            }

            await foreach (var (eof, item) in channelEnumerator)
            {
                if (eof)
                {
                    if (--dispatched == 0)
                        break;
                }
                else
                    yield return item;
            }
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Delta(byte[] key, DateTime? version)
        {
            return DeltaAsync(key, version).ToBlockingEnumerable();
        }
        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> DeltaAsync(byte[] begin, DateTime? version, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof, (byte[] Key, DateTime AsAt, byte[] Value))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            for (int c = 0; c < _spaces.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _spaces[C].DeltaAsync(begin, version, cancellationToken))
                        {
                            await channel.Writer.WriteAsync((false, item), cancellationToken);
                        }
                    }
                    finally
                    {
                        await channel.Writer.WriteAsync((true, (Array.Empty<byte>(), new DateTime(), Array.Empty<byte>())), cancellationToken);
                    }
                }, cancellationToken);
            }
            await foreach (var (eof, item) in channelEnumerator)
            {
                if (eof)
                {
                    if (--dispatched == 0)
                        break;
                }
                else
                    yield return item;
            }
        }
        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindDeltaAsync(byte[] begin, DateTime? version, DateTime? DeltaFrom, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof, (byte[] Key, DateTime AsAt, byte[] Value))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            for (int c = 0; c < _spaces.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _spaces[C].DeltaAsync(begin, version, cancellationToken))
                        {
                            var value = await GetAsync(item.Value, version);
                            await channel.Writer.WriteAsync((false, (item.Value, value.Item2, value.Item1)), cancellationToken);
                        }
                    }
                    finally
                    {
                        await channel.Writer.WriteAsync((true, (Array.Empty<byte>(), new DateTime(), Array.Empty<byte>())), cancellationToken);
                    }
                }, cancellationToken);
            }
            await foreach (var (eof, item) in channelEnumerator)
            {
                if (eof)
                {
                    if (--dispatched == 0)
                        break;
                }
                else
                    yield return item;
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
