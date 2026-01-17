// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Hiperspace.Meta;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Hiperspace
{
    /// <summary>
    /// A hiperspace aggregate that reads from a number of spaces, and writes to one 
    /// </summary>
    public class GenerationSpace : HiperSpace
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

        [Obsolete("use Bind((byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)")]
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
        [Obsolete("use BindAsync(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null) instead")]
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
            var channel = Channel.CreateUnbounded<Result<(byte[], byte[])>>(new UnboundedChannelOptions
            {
                SingleWriter = false,
                SingleReader = true,
                AllowSynchronousContinuations = true
            });
            var channelEnumerator = channel.Reader.ReadAllAsync().ToBlockingEnumerable();
            var dispatched = 0;
            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].FindAsync(begin, end))
                        {
                            await channel.Writer.WriteAsync(Result.Ok(item));
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[], byte[])>());
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[], byte[])>(ex));
                    }
                });
            }
            if (dispatched > 0)
            {
                foreach (var item in channelEnumerator)
                {
                    if (item.Ok)
                        yield return item.Value;
                    else if (item.EOF)
                    {
                        if (--dispatched == 0)
                            break;
                    }
                    else if (item.Error)
                        throw item.Exception;
                }
            }
            else
            {
                foreach (var item in Array.Empty<(byte[], byte[])>()) yield return item;
            }
        }

        public override async IAsyncEnumerable<(byte[], byte[])> FindAsync(byte[] begin, byte[] end, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, byte[] Value)>>();
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
                        await foreach (var item in _read[C].FindAsync(begin, end, cancellationToken))
                        {
                            await channel.Writer.WriteAsync(Result.Ok(item), cancellationToken);
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[], byte[])>(), cancellationToken);
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[], byte[])>(ex), cancellationToken);
                    }
                }, cancellationToken);
            }

            await foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }

        /// <remarks>
        /// There is a bug in channel enumeration that does not generate the correct state machine when the channel is out
        /// of scope
        /// </remarks>
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, DateTime AsAt, byte[] Value)>>();
            var channelEnumerator = channel.Reader.ReadAllAsync().ToBlockingEnumerable();
            long dispatched = 0;

            // earlier version from different generations will be filtered in the client SetSpace
            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].FindAsync(begin, end, version))
                        {
                            await channel.Writer.WriteAsync(Result.Ok(item));
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, DateTime AsAt, byte[] Value)>());
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[] Key, DateTime AsAt, byte[] Value)>(ex));
                    }
                });
            }
            foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }

        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindAsync(byte[] begin, byte[] end, DateTime? version, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, DateTime AsAt, byte[] Value)>>();
            var channelEnumerator = channel.Reader.ReadAllAsync(cancellationToken);
            long dispatched = 0;

            // earlier version from different generations will be filtered in the client SetSpace
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
                            await channel.Writer.WriteAsync(Result.Ok(item), cancellationToken);
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, DateTime AsAt, byte[] Value)>(), cancellationToken);
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[] Key, DateTime AsAt, byte[] Value)>(ex), cancellationToken);
                    }
                }, cancellationToken);
            }
            await foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> Nearest(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0, double? distanceLimit = null)
        {
            var ranks = new SortedSet<Nearest>();
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var result in _read[c].Nearest(begin, end, version, space, method, limit, distanceLimit))
                    ranks.Add(new Nearest(result));
            }
            var keys = limit == 0 ? ranks : ranks.Take(limit);
            foreach (var key in keys)
                yield return key.ToTuple();
        }
        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> NearestAsync(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0, double? distanceLimit = null, CancellationToken cancellationToken = default)
        {
            return Nearest(begin, end, version, space, method, limit, distanceLimit).ToAsyncEnumerable(cancellationToken);
        }

        public override IEnumerable<(byte[] value, DateTime version)> GetVersions(byte[] key)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] value, DateTime version)>>();
            var channelEnumerator = channel.Reader.ReadAllAsync().ToBlockingEnumerable();
            var dispatched = 0;

            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].GetVersionsAsync(key))
                        {
                            await channel.Writer.WriteAsync(Result.Ok(item));
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[] value, DateTime version)>());
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[] value, DateTime version)>(ex));
                    }
                });
            }
            foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }

        public override async IAsyncEnumerable<(byte[] value, DateTime version)> GetVersionsAsync(byte[] key, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] value, DateTime version)>>();
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
                            await channel.Writer.WriteAsync(Result.Ok(item), cancellationToken);
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[] value, DateTime version)>(), cancellationToken);
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[] value, DateTime version)>(ex), cancellationToken);
                    }
                }, cancellationToken);
            }
            await foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }

        public override byte[] Get(byte[] key)
        {
            for (int c = 0; c < _read.Length; c++)
            {
                var result = _read[c].Get(key);
                if (result is not null && result != Array.Empty<byte>())
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
                if (result is not null && result != Array.Empty<byte>())
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
        [Obsolete("use BatchBind((byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)")]
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
        [Obsolete("use BatchBindAsync((byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)")]
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
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, DateTime AsAt, byte[] Value)>>();
            var channelEnumerator = channel.Reader.ReadAllAsync().ToBlockingEnumerable();
            long dispatched = 0;

            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].DeltaAsync(key, version))
                        {
                            await channel.Writer.WriteAsync(Result.Ok(item));
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, DateTime AsAt, byte[] Value)>());
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[] Key, DateTime AsAt, byte[] Value)>(ex));
                    }
                });
            }

            foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }
        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> DeltaAsync(byte[] begin, DateTime? version, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, DateTime AsAt, byte[] Value)>>();
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
                            await channel.Writer.WriteAsync(Result.Ok(item), cancellationToken);
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, DateTime AsAt, byte[] Value)>(), cancellationToken);
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[] Key, DateTime AsAt, byte[] Value)>(ex), cancellationToken);
                    }
                }, cancellationToken);
            }

            await foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }

        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindDeltaAsync(byte[] begin, DateTime? version, DateTime? DeltaFrom, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, DateTime AsAt, byte[] Value)>>();
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
                            await channel.Writer.WriteAsync(Result.Ok((item.Value, value.Item2, value.Item1)), cancellationToken);
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, DateTime AsAt, byte[] Value)>(), cancellationToken);
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[] Key, DateTime AsAt, byte[] Value)>(ex), cancellationToken);
                    }
                }, cancellationToken);
            }

            await foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindDelta(byte[] begin, DateTime? version, DateTime? DeltaFrom)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, DateTime AsAt, byte[] Value)>>();
            var channelEnumerator = channel.Reader.ReadAllAsync().ToBlockingEnumerable();
            long dispatched = 0;

            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].DeltaAsync(begin, version))
                        {
                            var value = await GetAsync(item.Value, version);
                            await channel.Writer.WriteAsync(Result.Ok((item.Value, value.Item2, value.Item1)));
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, DateTime AsAt, byte[] Value)>());
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[] Key, DateTime AsAt, byte[] Value)>(ex));
                    }
                });
            }

            foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }
        public override IEnumerable<(byte[] Key, byte[] Value)> FindIndex(byte[] begin, byte[] end)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, byte[] Value)>>();
            var channelEnumerator = channel.Reader.ReadAllAsync().ToBlockingEnumerable();   
            long dispatched = 0;

            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].FindAsync(begin, end))
                        {
                            var value = await GetAsync(item.Value);
                            await channel.Writer.WriteAsync(Result.Ok((item.Value, value)));
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, byte[] Value)>());
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[] Key, byte[] Value)>(ex));
                    }
                });
            }
            foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndex(byte[] begin, byte[] end, DateTime? version)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, DateTime AsAt, byte[] Value)>>();
            var channelEnumerator = channel.Reader.ReadAllAsync().ToBlockingEnumerable();
            long dispatched = 0;

            for (int c = 0; c < _read.Length; c++)
            {
                dispatched++;
                var C = c;
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await foreach (var item in _read[C].FindAsync(begin, end, version))
                        {
                            var (value, asAt) = await GetAsync(item.Value, version);
                            await channel.Writer.WriteAsync(Result.Ok((item.Value, asAt, value)));
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, DateTime AsAt, byte[] Value)>());
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[] Key, DateTime AsAt, byte[] Value)>(ex));
                    }
                });
            }
            foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }
        public override async IAsyncEnumerable<(byte[] Key, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, byte[] Value)>>();
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
                            await channel.Writer.WriteAsync(Result.Ok((item.Value, value)), cancellationToken);
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, byte[] Value)>(), cancellationToken);
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[] Key, byte[] Value)>(ex), cancellationToken);
                    }
                }, cancellationToken);
            }
            await foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }
        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, DateTime? version, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, DateTime AsAt, byte[] Value)>>();
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
                            await channel.Writer.WriteAsync(Result.Ok((item.Value, asAt, value)), cancellationToken);
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, DateTime AsAt, byte[] Value)>(), cancellationToken);
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[] Key, DateTime AsAt, byte[] Value)>(ex), cancellationToken);
                    }
                }, cancellationToken);
            }
            await foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
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
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, byte[] Value)>>();
            var channelEnumerator = channel.Reader.ReadAllAsync().ToBlockingEnumerable();
            long dispatched = 0;

            foreach (var key in keys)
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
                            await channel.Writer.WriteAsync(Result.Ok((key, item)));
                            await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, byte[] Value)>());
                        }
                        catch (Exception ex)
                        {
                            await channel.Writer.WriteAsync(Result.Error<(byte[] Key, byte[] Value)>(ex));
                        }
                    });
                }
            }
            foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }
        public override IEnumerable<(byte[] key, byte[] Value, DateTime version)> GetMany(IEnumerable<byte[]> keys, DateTime? version)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] key, byte[] Value, DateTime version)>>();
            var channelEnumerator = channel.Reader.ReadAllAsync().ToBlockingEnumerable();
            long dispatched = 0;

            foreach (var key in keys)
            {
                for (int c = 0; c < _read.Length; c++)
                {
                    dispatched++;
                    var C = c;
                    _ = Task.Run(async () =>
                    {
                        try
                        {
                            var (item, ver) = await _read[C].GetAsync(key, version);
                            await channel.Writer.WriteAsync(Result.Ok((key, item, ver)));
                            await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, byte[] Value, DateTime version)>());
                        }
                        catch (Exception ex)
                        {
                            await channel.Writer.WriteAsync(Result.Error<(byte[] Key, byte[] Value, DateTime version)>(ex));
                        }
                    });
                }
            }
            foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }
        public override async IAsyncEnumerable<(byte[] key, byte[] value)> GetManyAsync(IAsyncEnumerable<byte[]> keys, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, byte[] Value)>>();
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
                            await channel.Writer.WriteAsync(Result.Ok((key, item)), cancellationToken);
                            await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, byte[] Value)>(), cancellationToken);
                        }
                        catch (Exception ex)
                        {
                            await channel.Writer.WriteAsync(Result.Error<(byte[] Key, byte[] Value)>(ex), cancellationToken);
                        }
                    }, cancellationToken);
                }
            }
            await foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }
        public override async IAsyncEnumerable<(byte[] key, byte[] Value, DateTime version)> GetManyAsync(IAsyncEnumerable<byte[]> keys, DateTime? version, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, byte[] Value, DateTime version) >>();
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
                            var (item, ver) = await _read[C].GetAsync(key, version);
                            await channel.Writer.WriteAsync(Result.Ok((key, item, ver)), cancellationToken);
                            await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, byte[] Value, DateTime version)>(), cancellationToken);
                        }
                        catch (Exception ex)
                        {
                            await channel.Writer.WriteAsync(Result.Error<(byte[] Key, byte[] Value, DateTime version)>(ex), cancellationToken);
                        }
                    }, cancellationToken);
                }
            }
            await foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
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
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, byte[] Value)>>();
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
                            await channel.Writer.WriteAsync(Result.Ok(item), cancellationToken);
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, byte[] Value)>(), cancellationToken);
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[] Key, byte[] Value)>(ex), cancellationToken);
                    }
                }, cancellationToken);
            }
            await foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }
        public override async IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> ScanAsync(byte[] begin, byte[] end, byte[][] values, DateTime? version, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            var channel = Channel.CreateUnbounded<Result<(byte[] Key, DateTime AsAt, byte[] Value)>>();
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
                            await channel.Writer.WriteAsync(Result.Ok(item), cancellationToken);
                        }
                        await channel.Writer.WriteAsync(Result.EOF<(byte[] Key, DateTime AsAt, byte[] Value)>(), cancellationToken);
                    }
                    catch (Exception ex)
                    {
                        await channel.Writer.WriteAsync(Result.Error<(byte[] Key, DateTime AsAt, byte[] Value)>(ex), cancellationToken);
                    }
                }, cancellationToken);
            }
            await foreach (var item in channelEnumerator)
            {
                if (item.Ok)
                    yield return item.Value;
                else if (item.EOF)
                {
                    if (--dispatched == 0)
                        break;
                }
                else if (item.Error)
                    throw item.Exception;
            }
        }
        public override async IAsyncEnumerable<(byte[] Key, byte[] Value)> ExportAsync([EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (int c = 0; c < _read.Length; c++)
            {
                await foreach (var b in _read[c].ExportAsync(cancellationToken))
                    yield return b;
            }
        }

        public override void ImportAsync(IAsyncEnumerable<(byte[] Key, byte[] Value)> values, CancellationToken cancellationToken = default)
        {
            _write.ImportAsync(values, cancellationToken);
        }

        public override MetaModel? GetMetaModel()
        {
            return _write.GetMetaModel();
        }
        public override Task<MetaModel?> GetMetaModelAsync()
        {
            return _write.GetMetaModelAsync();
        }

        public override bool SetMetaModel(MetaModel metaModel)
        {
            return _write.SetMetaModel(metaModel);
        }
        public override Task<bool> SetMetaModelAsync(MetaModel metaModel)
        {
            return _write.SetMetaModelAsync(metaModel);
        }

        public async override Task<ulong> GetSequenceAsync(byte[] key)
        {
            var sequence = await _write.GetSequenceAsync(key);
            if (sequence == 1)   // first read
            {
                var oldSequence = await _read[1].GetSequenceAsync(key);
                while (sequence < oldSequence)
                {
                    sequence = await _write.UseSequenceAsync(key);
                }
            }
            return sequence;
        }
        public async override Task<ulong> UseSequenceAsync(byte[] key)
        {
            var sequence = await _write.UseSequenceAsync(key);
            if (sequence < 3)   // probably first read
            {
                var oldSequence = await _read[1].GetSequenceAsync(key);
                while (sequence < oldSequence)
                {
                    sequence = await _write.UseSequenceAsync(key);
                }
            }
            return sequence;
        }
    }
}
