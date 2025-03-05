// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Hiperspace
{
    /// <summary>
    /// A hiperspace aggregate that reads from a number of spaces, and writes to one 
    /// </summary>
    public class GenerationSpace  : HiperSpace
    {
        private HiperSpace _write;
        private HiperSpace[] _read;

        public GenerationSpace([NotNull]HiperSpace[] aggregates)
        {
            if (aggregates.Length < 2)
                throw new ArgumentException("AggregateSpace should have at least two spaces");
            _read = aggregates;
            _write = aggregates[0];
        }

        public override BaseTypeModel? TypeModel 
        { 
            get
            {
                return _write.TypeModel;
            }
            set
            {
                for (int c = 0; c< _read.Length; c++)
                    _read[c].TypeModel = value;
            }
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, object? source)
        {
            return _write.Bind(key, value, source);
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            return _write.Bind(key, value, version, source);
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            return _write.Bind(key, value, version, priorVersion, source);
        }

        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, object? source)
        {
            return _write.BindAsync(key, value, source);
        }
        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            return _write.BindAsync(key, value, version, source);
        }
        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            return _write.BindAsync(key, value, version, priorVersion, source);
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

            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].FindAsync(begin, end, cancellationToken))
                        {
                            await channel.Writer.WriteAsync((false, item), cancellationToken);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
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
        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindAsync(byte[] begin, byte[] end, DateTime? version, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof, (byte[] Key, DateTime AsAt, byte[] Value))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            // earlier version from different generations will be filted in the client SetSpace
            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].FindAsync(begin, end, version, cancellationToken))
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

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> Nearest(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0)
        {
            var ranks = new SortedSet<Nearest>();
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var result in _read[c].Nearest(begin, end, version, space, method, limit))
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
            return GetVersionsAsync(key).ToBlockingEnumerable();
        }

        public override async IAsyncEnumerable<(byte[] value, DateTime version)> GetVersionsAsync(byte[] key, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof, (byte[] value, DateTime version))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            var dispatched = 0;

            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].GetVersionsAsync(key, cancellationToken))
                        {
                            await channel.Writer.WriteAsync((false, item), cancellationToken);
                        }
                    }
                    finally
                    {
                        await channel.Writer.WriteAsync((true, (Array.Empty<byte>(), new DateTime())), cancellationToken);

                        if (Interlocked.Decrement(ref dispatched) == 0)
                        {
                            channel.Writer.Complete();
                        }
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

        public override byte[] Get(byte[] key)
        {
            for (int c = 0; c < _read.Length; c++)
            {
                var result = _read[c].Get(key);
                if (result != null && result != Array.Empty<byte>())
                    return result;
            }
            return Array.Empty<byte>();
        }
        public override (byte[], DateTime) Get(byte[] key, DateTime? version)
        {
            for (int c = 0; c < _read.Length; c++)
            {
                var result = _read[c].Get(key, version);
                if (result != default && result.Item1 != Array.Empty<byte>())
                    return result;
            }
            return (Array.Empty<byte>(), new DateTime());
        }

        public override async Task<byte[]> GetAsync(byte[] key)
        {
            for (int c = 0; c < _read.Length; c++)
            {
                var result = await _read[c].GetAsync(key);
                if (result != null && result != Array.Empty<byte>())
                    return result;
            }
            return Array.Empty<byte>();
        }
        public async override Task<(byte[], DateTime)> GetAsync(byte[] key, DateTime? version)
        {
            for (int c = 0; c < _read.Length; c++)
            {
                var result = await _read[c].GetAsync(key, version);
                if (result != default && result.Item1 != Array.Empty<byte>())
                    return result;
            }
            return (Array.Empty<byte>(), new DateTime());
        }

        public override IEnumerable<(byte[], byte[])> Space()
        {
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var b in _read[c].Space())
                    yield return b;
            }
        }

        public override IAsyncEnumerable<(byte[], byte[])> SpaceAsync(CancellationToken cancellationToken = default)
        {
            return Space().ToAsyncEnumerable(cancellationToken);
        }

        public override IEnumerable<Horizon> GetHorizons()
        {
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var h in _read[c].GetHorizons())
                    yield return h;
            }
        }
        public override Result<(byte[] Key, byte[] Value)>[] BatchBind((byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)
        {
            return _write.BatchBind(batch);
        }
        public override Result<(byte[] Key, byte[] Value)>[] BatchBind((byte[] key, byte[] value, DateTime version, object? source)[] batch)
        {
            return _write.BatchBind(batch);
        }
        public override Result<(byte[] Key, byte[] Value)>[] BatchBind((byte[] key, byte[] value, object? source)[] batch)
        {
            return _write.BatchBind(batch);
        }
        public override Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)
        {
            return _write.BatchBindAsync(batch);
        }
        public override Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, DateTime version, object? source)[] batch)
        {
            return _write.BatchBindAsync(batch);
        }
        public override Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, object? source)[] batch)
        {
            return _write.BatchBindAsync(batch);
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Delta(byte[] key, DateTime? version)
        {
            return DeltaAsync(key, version).ToBlockingEnumerable();
        }
        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> DeltaAsync(byte[] begin, DateTime? version, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof, (byte[] Key, DateTime AsAt, byte[] Value))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].DeltaAsync(begin, version, cancellationToken))
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

        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindDeltaAsync(byte[] begin, DateTime? version, DateTime? DeltaFrom, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof, (byte[] Key, DateTime AsAt, byte[] Value))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].DeltaAsync(begin, version, cancellationToken))
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

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindDelta(byte[] begin, DateTime? version, DateTime? DeltaFrom)
        {
            return FindDeltaAsync(begin, version, DeltaFrom).ToBlockingEnumerable();
        }
        public override IEnumerable<(byte[] Key, byte[] Value)> FindIndex(byte[] begin, byte[] end)
        {
            return FindIndexAsync(begin, end).ToBlockingEnumerable();
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndex(byte[] begin, byte[] end, DateTime? version)
        {
            return FindIndexAsync(begin, end, version).ToBlockingEnumerable();
        }
        public override async IAsyncEnumerable<(byte[] Key, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof,(byte[] Key, byte[] Value))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].FindAsync(begin, end, cancellationToken))
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
        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, DateTime? version, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(bool eof, (byte[] Key, DateTime AsAt, byte[] Value))>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].FindAsync(begin, end, version, cancellationToken))
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
            for (int c = _read.Length - 1; c >= 0; c--)
            {
                var result = _read[c].GetFirst(begin, end);
                if (result != default)
                    return result;
            }
            return default;
        }
        public override (byte[] Key, DateTime AsAt, byte[] Value)? GetFirst(byte[] begin, byte[] end, DateTime? version)
        {
            for (int c = _read.Length - 1; c >= 0; c--)
            {
                var result = _read[c].GetFirst(begin, end, version);
                if (result != default)
                    return result;
            }
            return default;
        }
        public override Task<(byte[] Key, byte[] Value)?> GetFirstAsync(byte[] begin, byte[] end)
        {
            for (int c = _read.Length - 1; c >= 0; c--)
            {
                var result = _read[c].GetFirstAsync(begin, end);
                if (result != default)
                    return result;
            }
            return Task.FromResult(((byte[] Key, byte[] Value)?)null);
        }
        public override async Task<(byte[] Key, DateTime AsAt, byte[] Value)?> GetFirstAsync(byte[] begin, byte[] end, DateTime? version)
        {
            for (int c = _read.Length - 1; c >= 0; c--)
            {
                var result = await _read[c].GetFirstAsync(begin, end, version);
                if (result != default)
                    return result;
            }
            return default;
        }
        public override (byte[] Key, byte[] Value)? GetLast(byte[] begin, byte[] end)
        {
            for (int c = 0; c < _read.Length ; c++)
            {
                var result = _read[c].GetLast(begin, end);
                if (result != default)
                    return result;
            }
            return default;
        }
        public override (byte[] Key, DateTime AsAt, byte[] Value)? GetLast(byte[] begin, byte[] end, DateTime? version)
        {
            for (int c = 0; c < _read.Length; c++)
            {
                var result = _read[c].GetLast(begin, end, version);
                if (result != default)
                    return result;
            }
            return default;
        }
        public override async Task<(byte[] Key, byte[] Value)?> GetLastAsync(byte[] begin, byte[] end)
        {
            for (int c = 0; c < _read.Length; c++)
            {
                var result = await _read[c].GetLastAsync(begin, end);
                if (result != default)
                    return result;
            }
            return default;
        }
        public override async Task<(byte[] Key, DateTime AsAt, byte[] Value)?> GetLastAsync(byte[] begin, byte[] end, DateTime? version)
        {
            for (int c = 0; c < _read.Length; c++)
            {
                var result = await _read[c].GetLastAsync(begin, end, version);
                if (result != default)
                    return result;
            }
            return default;
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
                for (int c = 0; c < _read.Length; c++)
                {
                    dispatched++;
                    var C = c;
                    _ = Task.Run(async () =>
                    {
                        try
                        {
                            var item = await _read[C].GetAsync(key);
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
            var results = new Dictionary<KeyPart, (byte[] Key, byte[] Value, DateTime AsAt)>(); ;
            for (int c = 0; c < _read.Length; c++)
            {
                await foreach (var item in _read[c].GetManyAsync(keys, version, cancellationToken))
                {
                    if (results.TryAdd(new KeyPart(item.key), item))
                        yield return item;
                }
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

            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].ScanAsync(begin, end, values, cancellationToken))
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

            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].ScanAsync(begin, end, values, version, cancellationToken))
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
    }
}
