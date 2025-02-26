// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            var request = new Task<IEnumerable<(byte[] Key, byte[] Value)>>[_read.Length];
            var result = new IEnumerable<(byte[] Key, byte[] Value)>[_read.Length];

            for (int c = 0; c < _read.Length; c++)
            {
                request[c] = Task.Run(() => _read[c].Find(begin, end));
            }
            for (int c = 0; c < _read.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            var request = new Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>>[_read.Length];
            var result = new IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>[_read.Length];

            for (int c = 0; c < _read.Length; c++)
            {
                request[c] = Task.Run(() => _read[c].Find(begin, end, version));
            }
            for (int c = 0; c < _read.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }

        public override async IAsyncEnumerable<(byte[], byte[])> FindAsync(byte[] begin, byte[] end, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(byte[] Key, byte[] Value)>();

            for (int c = 0; c < _read.Length; c++)
            {
                _ = Task.Run(async () =>
                {
                    await foreach (var item in _read[c].FindAsync(begin, end, cancellationToken))
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

            for (int c = 0; c < _read.Length; c++)
            {
                _ = Task.Run(async () =>
                {
                    await foreach (var item in _read[c].FindAsync(begin, end, version, cancellationToken))
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
            var request = new Task<IEnumerable<(byte[] value, DateTime version)>>[_read.Length];
            var result = new IEnumerable<(byte[] value, DateTime version)>[_read.Length];

            for (int c = 0; c < _read.Length; c++)
            {
                request[c] = Task.Run(() => _read[c].GetVersions(key));
            }
            for (int c = 0; c < _read.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }

        public override IAsyncEnumerable<(byte[] value, DateTime version)> GetVersionsAsync(byte[] key, CancellationToken cancellationToken = default)
        {
            return GetVersions(key).ToAsyncEnumerable(cancellationToken);
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

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Delta(byte[] key, DateTime? version)
        {
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var b in _read[c].Delta(key, version))
                    yield return b;
            }
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
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindDelta(byte[] begin, DateTime? version, DateTime? DeltaFrom)
        {
            var request = new Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>>[_read.Length];
            var result = new IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>[_read.Length];

            for (int c = 0; c < _read.Length; c++)
            {
                request[c] = Task.Run(() => _read[c].FindDelta(begin, version, DeltaFrom));
            }
            for (int c = 0; c < _read.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }
        public override IEnumerable<(byte[] Key, byte[] Value)> FindIndex(byte[] begin, byte[] end)
        {
            var request = new Task<IEnumerable<(byte[] Key, byte[] Value)>>[_read.Length];
            var result = new IEnumerable<(byte[] Key, byte[] Value)>[_read.Length];

            for (int c = 0; c < _read.Length; c++)
            {
                request[c] = Task.Run(() => _read[c].FindIndex(begin, end));
            }
            for (int c = 0; c < _read.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndex(byte[] begin, byte[] end, DateTime? version)
        {
            var request = new Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>>[_read.Length];
            var result = new IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>[_read.Length];

            for (int c = 0; c < _read.Length; c++)
            {
                request[c] = Task.Run(() => _read[c].FindIndex(begin, end, version));
            }
            for (int c = 0; c < _read.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }
        public override async IAsyncEnumerable<(byte[] Key, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(byte[] Key, byte[] Value)>();

            for (int c = 0; c < _read.Length; c++)
            {
                _ = Task.Run(async () =>
                {
                    await foreach (var item in _read[c].FindIndexAsync(begin, end, cancellationToken))
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
        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, DateTime? version, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<(byte[] Key, DateTime AsAt, byte[] Value)>();

            for (int c = 0; c < _read.Length; c++)
            {
                _ = Task.Run(async () =>
                {
                    await foreach (var item in _read[c].FindIndexAsync(begin, end, version, cancellationToken))
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
        public override IEnumerable<(byte[] key, byte[] value)> GetMany(IEnumerable<byte[]> keys)
        {
            var request = new Task<IEnumerable<(byte[] key, byte[] value)>>[_read.Length];
            var result = new IEnumerable<(byte[] Key, byte[] Value)>[_read.Length];

            for (int c = 0; c < _read.Length; c++)
            {
                request[c] = Task.Run(() => _read[c].GetMany(keys));
            }
            for (int c = 0; c < _read.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }
        public override IEnumerable<(byte[] key, byte[] Value, DateTime version)> GetMany(IEnumerable<byte[]> keys, DateTime? version)
        {
            var request = new Task<IEnumerable<(byte[] key, byte[] Value, DateTime version)>>[_read.Length];
            var result = new IEnumerable<(byte[] key, byte[] Value, DateTime version)>[_read.Length];

            for (int c = 0; c < _read.Length; c++)
            {
                request[c] = Task.Run(() => _read[c].GetMany(keys, version));
            }
            for (int c = 0; c < _read.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _read.Length; c++)
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
            var request = new Task<IEnumerable<(byte[] Key, byte[] Value)>>[_read.Length];
            var result = new IEnumerable<(byte[] Key, byte[] Value)>[_read.Length];

            for (int c = 0; c < _read.Length; c++)
            {
                request[c] = Task.Run(() => _read[c].Scan(begin, end, values));
            }
            for (int c = 0; c < _read.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var b in result[c])
                    yield return b;
            }
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Scan(byte[] begin, byte[] end, byte[][] values, DateTime? version)
        {
            var request = new Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>>[_read.Length];
            var result = new IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>[_read.Length];

            for (int c = 0; c < _read.Length; c++)
            {
                request[c] = Task.Run(() => _read[c].Scan(begin, end, values, version));
            }
            for (int c = 0; c < _read.Length; c++)
            {
                result[c] = request[c].GetAwaiter().GetResult();
            }
            for (int c = 0; c < _read.Length; c++)
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
    }
}
