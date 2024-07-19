// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Diagnostics.CodeAnalysis;

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

        public override Result<byte[]> Bind(byte[] key, byte[] value, object? source)
        {
            return _write.Bind(key, value, source);
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            return _write.Bind(key, value, version, source);
        }


        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, object? source)
        {
            return _write.BindAsync(key, value, source);
        }
        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            return _write.BindAsync(key, value, version, source);
        }

        public override IEnumerable<(byte[], byte[])> Find(byte[] begin, byte[] end)
        {
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var b in _read[c].Find(begin, end))
                    yield return b;
            }
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var b in _read[c].Find(begin, end, version))
                    yield return b;
            }
        }


        public override async Task<IEnumerable<(byte[], byte[])>> FindAsync(byte[] begin, byte[] end)
        {
            var reads = new Task<IEnumerable<(byte[], byte[])>>[_read.Length];
            var returns = new IEnumerable<(byte[], byte[])>[_read.Length];

            for (int c = 0; c < _read.Length; c++)
            {
                var read = _read[c]; // avoid lambda capture of c rather than space
                reads[c] = Task.Run(() => read.FindAsync(begin, end));
            }
            for (int c = 0; c < _read.Length; c++)
            {
                returns[c] = await reads[c];
            }
            return Yielder(returns);
        }
        public async override Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>> FindAsync(byte[] begin, byte[] end, DateTime? version)
        {
            var reads = new Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>>[_read.Length];
            var returns = new IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>[_read.Length];

            for (int c = 0; c < _read.Length; c++)
            {
                var read = _read[c]; // avoid lambda capture of c rather than space
                reads[c] = Task.Run(() => read.FindAsync(begin, end, version));
            }
            for (int c = 0; c < _read.Length; c++)
            {
                returns[c] = await reads[c];
            }
            return Yielder(returns);
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
        public override async Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)>> NearestAsync(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0)
        {
            var ranks = new SortedSet<Nearest>();
            var reads = new Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)>>[_read.Length];

            for (int c = 0; c < _read.Length; c++)
            {
                reads[c] = _read[c].NearestAsync(begin, end, version, space, method, limit);
            }
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var result in await reads[c])
                    ranks.Add(new Nearest(result));
            }
            var keys = limit == 0 ? ranks : ranks.Take(limit);
            return keys.Select(key => key.ToTuple());
        }

        public override IEnumerable<(byte[] value, DateTime version)> GetVersions(byte[] key)
        {
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var v in _read[c].GetVersions(key))
                    yield return v;
            }
        }

        public async override Task<IEnumerable<(byte[] value, DateTime version)>> GetVersionsAsync(byte[] key)
        {
            var reads = new Task<IEnumerable<(byte[], DateTime)>>[_read.Length];
            var returns = new IEnumerable<(byte[], DateTime)>[_read.Length];

            for (int c = 0; c < _read.Length; c++)
            {
                var read = _read[c]; // avoid lambda capture of c rather than space
                reads[c] = Task.Run(() => read.GetVersions(key));
            }
            for (int c = 0; c < _read.Length; c++)
            {
                returns[c] = await reads[c];
            }
            return Yielder(returns);
        }

        private IEnumerable<T> Yielder<T>([NotNull]IEnumerable<T>[] values)
        {
            for (int c = 0; c < _read.Length; ++c)
            {
                foreach(var t in values[c])
                    yield return t;
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

        public override async Task<IEnumerable<(byte[], byte[])>> SpaceAsync()
        {
            var reads = new Task<IEnumerable<(byte[], byte[])>>[_read.Length];
            var returns = new IEnumerable<(byte[], byte[])>[_read.Length];

            for (int c = 0; c < _read.Length; c++)
            {
                var read = _read[c]; // avoid lambda capture of c rather than space
                reads[c] = Task.Run(() => read.SpaceAsync());
            }
            for (int c = 0; c < _read.Length; c++)
            {
                returns[c] = await reads[c];
            }
            return Yielder(returns);
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Delta(byte[] key, DateTime? version)
        {
            for (int c = 0; c < _read.Length; c++)
            {
                foreach (var b in _read[c].Delta(key, version))
                    yield return b;
            }
        }
    }
}
