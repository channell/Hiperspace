// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.IO.Compression;
using System.Runtime.CompilerServices;

namespace Hiperspace
{
    /// <summary>
    /// A hiperspace that bulk loads updated from a session
    /// </summary>
    public class SessionSpace : HiperSpace
    {
        /// <summary>
        /// Rollup function to filter content
        /// </summary>
        /// <param name="last">the last value from store which is newer that current</param>
        /// <param name="current">the current version</param>
        /// <param name="final">true when this is the final version</param>
        /// <returns></returns>
        public delegate bool Rollup(DateTime? last, DateTime current);

        public static Rollup RollUpYears(int n = 1) => (last, current) => !last.HasValue ? true : current.AddYears(n) < last.Value ? true : false;
        public static Rollup RollUpMonths(int n = 1) => (last, current) => !last.HasValue ? true : current.AddMonths(n) < last.Value ? true : false;
        public static Rollup RollUpDays(double n = 1.0) => (last, current) => !last.HasValue ? true : current.AddDays(n) < last.Value ? true : false;
        public static Rollup RollUpHours(double n = 1.0) => (last, current) => !last.HasValue ? true : current.AddHours(n) < last.Value ? true : false;
        public static Rollup RollUpMinutes(double n = 1.0) => (last, current) => !last.HasValue ? true : current.AddMinutes(n) < last.Value ? true : false;
        public static Rollup RollUpSeconds(double n = 1.0) => (last, current) => !last.HasValue ? true : current.AddSeconds(n) < last.Value ? true : false;

        private HiperSpace _sessionSpace;
        private HiperSpace _durableSpace;
        private HiperSpace[] _spaces;
        private Rollup _roller;

        /// <summary>
        /// Create a session space, that only writes additions to the backing store when the session is close
        /// </summary>
        /// <param name="sessionSpace">space for local session</param>
        /// <param name="durableSpace">durable backing store</param>
        public SessionSpace([NotNull] HiperSpace sessionSpace, [NotNull] HiperSpace durableSpace)
        {
            _sessionSpace = sessionSpace;
            _durableSpace = durableSpace;
            _spaces = new[] { _sessionSpace, _durableSpace };
            _roller = (l, c) => true;
        }

        /// <summary>
        /// Create a session space, that only writes additions to the backing store when the session is close, 
        /// that <b>match</b> the rollup function
        /// </summary>
        /// <param name="sessionSpace">space for local session</param>
        /// <param name="durableSpace">durable backing store</param>
        public SessionSpace([NotNull] HiperSpace sessionSpace, [NotNull] HiperSpace durableSpace, Rollup rollup)
        {
            _sessionSpace = sessionSpace;
            _durableSpace = durableSpace;
            _spaces = new[] { _sessionSpace, _durableSpace };
            _roller = rollup;
        }

        protected override void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    var fname = Path.GetTempFileName();
                    try
                    {
                        using (var file = File.OpenWrite(fname))
                        {
                            Zip(file);      // only zip the session
                            file.Close();
                        }
                        using (var file = File.OpenRead(fname))
                        {
                            _durableSpace.Unzip(file);
                            file.Close();
                        }
                    }
                    finally 
                    { 
                        if (Path.Exists(fname))
                            File.Delete(fname);
                    }
                }
                _disposedValue = true;
            }
        }

        /// <summary>
        /// Abort the session, and do not write changes
        /// </summary>
        public void Abort ()
        {
            _disposedValue = true;  // prevent write to backing
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, object? source)
        {
            return _sessionSpace.Bind(key, value, source);
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            return _sessionSpace.Bind(key, value, version, source);
        }
        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            return _sessionSpace.Bind(key, value, version, priorVersion, source);
        }

        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, object? source)
        {
            return _sessionSpace.BindAsync(key, value, source);
        }
        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            return _sessionSpace.BindAsync(key, value, version, source);
        }
        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            return _sessionSpace.BindAsync(key, value, version, priorVersion, source);
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

        public override async Task<IEnumerable<(byte[], byte[])>> FindAsync(byte[] begin, byte[] end)
        {
            var reads = new Task<IEnumerable<(byte[], byte[])>>[_spaces.Length];
            var returns = new IEnumerable<(byte[], byte[])>[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                reads[c] = Task.Run(() => _spaces[c].FindAsync(begin, end));
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                returns[c] = await reads[c];
            }
            return Yielder(returns);
        }
        public async override Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>> FindAsync(byte[] begin, byte[] end, DateTime? version)
        {
            var reads = new Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>>[_spaces.Length];
            var returns = new IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                reads[c] = Task.Run(() => _spaces[c].FindAsync(begin, end, version));
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                returns[c] = await reads[c];
            }
            return Yielder(returns);
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
        public override async Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)>> NearestAsync(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0)
        {
            var ranks = new SortedSet<Nearest>();
            var reads = new Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)>>[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                reads[c] = _spaces[c].NearestAsync(begin, end, version, space, method, limit);
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var result in await reads[c])
                    ranks.Add(new Nearest(result));
            }
            var keys = limit == 0 ? ranks : ranks.Take(limit);
            return keys.Select(key => key.ToTuple());
        }
        public override IEnumerable<(byte[] value, DateTime version)> GetVersions(byte[] key)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var v in _spaces[c].GetVersions(key))
                    yield return v;
            }
        }

        public async override Task<IEnumerable<(byte[] value, DateTime version)>> GetVersionsAsync(byte[] key)
        {
            var reads = new Task<IEnumerable<(byte[], DateTime)>>[_spaces.Length];
            var returns = new IEnumerable<(byte[], DateTime)>[_spaces.Length];

            for (int c = 0; c < _spaces.Length; c++)
            {
                reads[c] = Task.Run(() => _spaces[c].GetVersions(key));
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                returns[c] = await reads[c];
            }
            return Yielder(returns);
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
            (byte[] Key, byte[] Value)? current = null;
            DateTime? last = null;
            foreach (var item in _sessionSpace.Space())
            {
                if (item.Key.Length > sizeof(ulong) + 1 && item.Key[0] == 0)   // versioned
                {
                    if (current.HasValue && item.Key.Length == current.Value.Key.Length)
                    {
                        var curkey = new Span<byte>(current.Value.Key, 0, current.Value.Key.Length - sizeof(ulong));
                        var key = new Span<byte>(item.Key, 0, item.Key.Length - sizeof(ulong));
                        if (Compare(curkey, key) != 0)
                            last = null;
                    }
                    var ver = (long)(ulong.MaxValue - BinaryPrimitives.ReadUInt64BigEndian(new Span<byte>(item.Key, item.Key.Length - sizeof(ulong), sizeof(ulong))));
                    var currentDate = new DateTime(ver);
                    if (_roller(last, currentDate))
                    {
                        yield return item;
                        last = currentDate;
                    }
                }
                current = item;
            }
        }

        public override Task<IEnumerable<(byte[], byte[])>> SpaceAsync()
        {
            return Task.Run (() => Space().ToList() as IEnumerable<(byte[], byte[])>);
        }
        /// <summary>
        /// Transfer the content of the session space to a zip stream
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="level"></param>
        public new void Zip(Stream stream, CompressionLevel level = CompressionLevel.Fastest)
        {
            using (var zip = new GZipStream(stream, level))
            {
                foreach (var r in Space())
                {
                    zip.Write(BitConverter.GetBytes(r.Item1.Length));
                    zip.Write(r.Item1);
                    zip.Write(BitConverter.GetBytes(r.Item2.Length));
                    zip.Write(r.Item2);
                }
            }
        }
        /// <summary>
        /// Transfer the entire content of the space to a zip stream async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="level"></param>
        public new Task ZipAsync(Stream stream, CompressionLevel level = CompressionLevel.Fastest)
        {
            return Task.Run(() => Zip(stream, level));
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

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Delta(byte[] key, DateTime? version)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var b in _spaces[c].Delta(key, version))
                    yield return b;
            }
        }
    }
}
