﻿// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Diagnostics.CodeAnalysis;
using System.Threading;

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
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var b in _spaces[c].Find(begin, end))
                    yield return b;
            }
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var b in _spaces[c].Find(begin, end, version))
                    yield return b;
            }
        }


        public override IAsyncEnumerable<(byte[], byte[])> FindAsync(byte[] begin, byte[] end, CancellationToken cancellationToken = default)
        {
            return Find(begin, end).ToAsyncEnumerable(cancellationToken);
        }
        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindAsync(byte[] begin, byte[] end, DateTime? version, CancellationToken cancellationToken = default)
        {
            return Find(begin, end, version).ToAsyncEnumerable(cancellationToken);
        }
        public override IEnumerable<(byte[] value, DateTime version)> GetVersions(byte[] key)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var v in _spaces[c].GetVersions(key))
                    yield return v;
            }
        }

        public override IAsyncEnumerable<(byte[] value, DateTime version)> GetVersionsAsync(byte[] key, CancellationToken cancellationToken = default)
        {
            return GetVersions(key).ToAsyncEnumerable(cancellationToken);
        }

        private IEnumerable<T> Yielder<T>([NotNull] IEnumerable<T>[] values)
        {
            for (int c = 0; c < _spaces.Length; ++c)
            {
                foreach (var t in values[c])
                    yield return t;
            }
        }

        public override byte[] Get(byte[] key)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                var result = _spaces[c].Get(key);
                if (result != null && result != Array.Empty<byte>())
                    return result;
            }
            return Array.Empty<byte>();
        }
        public override (byte[], DateTime) Get(byte[] key, DateTime? version)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                var result = _spaces[c].Get(key, version);
                if (result != default && result.Item1 != Array.Empty<byte>())
                    return result;
            }
            return (Array.Empty<byte>(), new DateTime());
        }

        public override async Task<byte[]> GetAsync(byte[] key)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                var result = await _spaces[c].GetAsync(key);
                if (result != null && result != Array.Empty<byte>())
                    return result;
            }
            return Array.Empty<byte>();
        }
        public async override Task<(byte[], DateTime)> GetAsync(byte[] key, DateTime? version)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                var result = await _spaces[c].GetAsync(key, version);
                if (result != default && result.Item1 != Array.Empty<byte>())
                    return result;
            }
            return (Array.Empty<byte>(), new DateTime());
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
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var b in _spaces[c].Delta(key, version))
                    yield return b;
            }
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
