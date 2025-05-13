// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
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
    /// A special case of Session space for use in Blazor browser applications while 
    /// Web Assembly does not support threads and asyncronous blocking IO
    /// A disconnected hiperspace that only searches the session space
    /// </summary>
    public class BrowserSpace : HiperSpace
    {
        /// <summary>
        /// Rollup function to filter content
        /// </summary>
        /// <param name="last">the last value from store which is newer that current</param>
        /// <param name="current">the current version</param>
        /// <param name="final">true when this is the final version</param>
        /// <returns></returns>
        public delegate bool Rollup(DateTime? last, DateTime current);

        public static Rollup RollUpYears(int n = 1) => (last, current) => !last.HasValue ? true : last.Value.AddYears(n) < current || last.Value.Year != current.Year ? true : false;
        public static Rollup RollUpMonths(int n = 1) => (last, current) => !last.HasValue ? true : last.Value.AddMonths(n) < current || last.Value.Month != current.Month ? true : false;
        public static Rollup RollUpDays(double n = 1.0) => (last, current) => !last.HasValue ? true : last.Value.AddDays(n) < current || last.Value.Day != current.Day ? true : false;
        public static Rollup RollUpHours(double n = 1.0) => (last, current) => !last.HasValue ? true : last.Value.AddHours(n) < current || last.Value.Hour != current.Hour ? true : false;
        public static Rollup RollUpMinutes(double n = 1.0) => (last, current) => !last.HasValue ? true : last.Value.AddMinutes(n) < current || last.Value.Minute != current.Minute ? true : false;
        public static Rollup RollUpSeconds(double n = 1.0) => (last, current) => !last.HasValue ? true : last.Value.AddSeconds(n) < current || last.Value.Second != current.Second ? true : false;

        private HiperSpace _sessionSpace;
        private HiperSpace _durableSpace;
        private HiperSpace[] _spaces;
        private Rollup _roller;

        /// <summary>
        /// Create a session space, that only writes additions to the backing store when the session is close
        /// </summary>
        /// <param name="sessionSpace">space for local session</param>
        /// <param name="durableSpace">durable backing store</param>
        public BrowserSpace([NotNull] HiperSpace sessionSpace, [NotNull] HiperSpace durableSpace)
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
        public BrowserSpace([NotNull] HiperSpace sessionSpace, [NotNull] HiperSpace durableSpace, Rollup rollup)
        {
            _sessionSpace = sessionSpace;
            _durableSpace = durableSpace;
            _spaces = new[] { _sessionSpace, _durableSpace };
            _roller = rollup;
        }

        public override BaseTypeModel? TypeModel
        {
            get
            {
                return _durableSpace.TypeModel;
            }
            set
            {
                for (int c = 0; c < _spaces.Length; c++)
                    _spaces[c].TypeModel = value;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    var elements = _sessionSpace.ExportAsync();
                    _durableSpace.ImportAsync(elements);
                }
                _disposedValue = true;
            }
        }

        /// <summary>
        /// Abort the session, and do not write changes
        /// </summary>
        public void Abort()
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
            return _durableSpace.BindAsync(key, value, source);
        }
        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            return _durableSpace.BindAsync(key, value, version, source);
        }
        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            return _durableSpace.BindAsync(key, value, version, priorVersion, source);
        }

        public override IEnumerable<(byte[], byte[])> Find(byte[] begin, byte[] end)
        {
            foreach (var b in _sessionSpace.Find(begin, end))
                yield return b;
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            foreach (var b in _sessionSpace.Find(begin, end, version))
                yield return b;
        }

        public async override IAsyncEnumerable<(byte[], byte[])> FindAsync(byte[] begin, byte[] end, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                await foreach (var b in _spaces[c].FindAsync(begin, end, cancellationToken))
                    yield return b;
            }
        }
        public async override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindAsync(byte[] begin, byte[] end, DateTime? version, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                await foreach (var b in _spaces[c].FindAsync(begin, end, version, cancellationToken))
                    yield return b;
            }
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> Nearest(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0)
        {
            var ranks = new SortedSet<Nearest>();
            foreach (var result in _sessionSpace.Nearest(begin, end, version, space, method, limit))
                ranks.Add(new Nearest(result));
            var keys = limit == 0 ? ranks : ranks.Take(limit);
            foreach (var key in keys)
                yield return key.ToTuple();
        }
        public async override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> NearestAsync(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            var ranks = new SortedSet<Nearest>();
            for (int c = 0; c < _spaces.Length; c++)
            {
                await foreach (var result in _spaces[c].NearestAsync(begin, end, version, space, method, limit, cancellationToken))
                    ranks.Add(new Nearest(result));
            }
            var keys = limit == 0 ? ranks : ranks.Take(limit);
            foreach (var key in keys)
                yield return key.ToTuple();
        }
        public override IEnumerable<(byte[] value, DateTime version)> GetVersions(byte[] key)
        {
            foreach (var v in _sessionSpace.GetVersions(key))
                yield return v;
        }

        public async override IAsyncEnumerable<(byte[] value, DateTime version)> GetVersionsAsync(byte[] key, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                await foreach (var v in _spaces[c].GetVersionsAsync(key))
                    yield return v;
            }
        }

        public override byte[] Get(byte[] key)
        {
            return _sessionSpace.Get(key);
        }
        public override (byte[], DateTime) Get(byte[] key, DateTime? version)
        {
            return _sessionSpace.Get(key, version);
        }

        public async override Task<byte[]> GetAsync(byte[] key)
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

        /// <summary>
        /// Transfer the content of the session space to a zip stream
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="level"></param>
        public new void Zip(Stream stream, CompressionLevel level = CompressionLevel.Fastest)
        {
            _sessionSpace.Zip(stream, level);
        }
        /// <summary>
        /// Transfer the entire content of the space to a zip stream async
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="level"></param>
        public new async Task ZipAsync(Stream stream, CompressionLevel level = CompressionLevel.Fastest)
        {
            await _sessionSpace.ZipAsync(stream, level);
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
            return _sessionSpace.Delta(key, version);
        }
        public override IEnumerable<Horizon> GetHorizons()
        {
            foreach (var h in _sessionSpace.GetHorizons())
                yield return h;
            foreach (var h in _durableSpace.GetHorizons())
                yield return h;
        }
        public override Result<(byte[] Key, byte[] Value)>[] BatchBind((byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)
        {
            return _sessionSpace.BatchBind(batch);
        }
        public override Result<(byte[] Key, byte[] Value)>[] BatchBind((byte[] key, byte[] value, DateTime version, object? source)[] batch)
        {
            return _sessionSpace.BatchBind(batch);
        }
        public override Result<(byte[] Key, byte[] Value)>[] BatchBind((byte[] key, byte[] value, object? source)[] batch)
        {
            return _sessionSpace.BatchBind(batch);
        }
        public override Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)
        {
            return _durableSpace.BatchBindAsync(batch);
        }
        public override Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, DateTime version, object? source)[] batch)
        {
            return _durableSpace.BatchBindAsync(batch);
        }
        public override Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, object? source)[] batch)
        {
            return _durableSpace.BatchBindAsync(batch);
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindDelta(byte[] begin, DateTime? version, DateTime? DeltaFrom)
        {
            return _sessionSpace.FindDelta(begin, version, DeltaFrom);
        }
        public async override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindDeltaAsync(byte[] begin, DateTime? version, DateTime? DeltaFrom, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                await foreach (var b in _spaces[c].FindDeltaAsync(begin, version, DeltaFrom, cancellationToken))
                    yield return b;
            }
        }

        public override IEnumerable<(byte[] Key, byte[] Value)> FindIndex(byte[] begin, byte[] end)
        {
            return _sessionSpace.FindIndex(begin, end);
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndex(byte[] begin, byte[] end, DateTime? version)
        {
            return _sessionSpace.FindIndex(begin, end, version);
        }
        public async override IAsyncEnumerable<(byte[] Key, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                await foreach (var b in _spaces[c].FindIndexAsync(begin, end, cancellationToken))
                    yield return b;
            }
        }
        public async override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, DateTime? version, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                await foreach (var b in _spaces[c].FindIndexAsync(begin, end, version, cancellationToken))
                    yield return b;
            }
        }
        public override (byte[] Key, byte[] Value)? GetFirst(byte[] begin, byte[] end)
        {
            return _sessionSpace.GetFirst(begin, end);
        }
        public override (byte[] Key, DateTime AsAt, byte[] Value)? GetFirst(byte[] begin, byte[] end, DateTime? version)
        {
            return _sessionSpace.GetFirst(begin, end, version);
        }
        public async override Task<(byte[] Key, byte[] Value)?> GetFirstAsync(byte[] begin, byte[] end)
        {
            for (int c = _spaces.Length - 1; c >= 0; c--)
            {
                var result = await _spaces[c].GetFirstAsync(begin, end);
                if (result != null)
                    return result;
            }
            return null;
        }
        public async override Task<(byte[] Key, DateTime AsAt, byte[] Value)?> GetFirstAsync(byte[] begin, byte[] end, DateTime? version)
        {
            for (int c = _spaces.Length - 1; c >= 0; c--)
            {
                var result = await _spaces[c].GetFirstAsync(begin, end, version);
                if (result != null)
                    return result;
            }
            return null;
        }
        public override (byte[] Key, byte[] Value)? GetLast(byte[] begin, byte[] end)
        {
            return _sessionSpace.GetLast(begin, end);
        }
        public override (byte[] Key, DateTime AsAt, byte[] Value)? GetLast(byte[] begin, byte[] end, DateTime? version)
        {
            return _sessionSpace.GetLast(begin, end, version);
        }
        public async override Task<(byte[] Key, byte[] Value)?> GetLastAsync(byte[] begin, byte[] end)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                var result = await _spaces[c].GetLastAsync(begin, end);
                if (result != null)
                    return result;
            }
            return null;
        }
        public async override Task<(byte[] Key, DateTime AsAt, byte[] Value)?> GetLastAsync(byte[] begin, byte[] end, DateTime? version)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                var result = await _spaces[c].GetLastAsync(begin, end, version);
                if (result != null)
                    return result;
            }
            return null;
        }
        public override IEnumerable<(byte[] key, byte[] value)> GetMany(IEnumerable<byte[]> keys)
        {
            return _sessionSpace.GetMany(keys);
        }
        public async override IAsyncEnumerable<(byte[] key, byte[] value)> GetManyAsync(IAsyncEnumerable<byte[]> keys, [EnumeratorCancellation]CancellationToken cancellationToken = default)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                await foreach (var b in _spaces[c].GetManyAsync(keys, cancellationToken))
                    yield return b;
            }
        }
        public override IEnumerable<(byte[] key, byte[] Value, DateTime version)> GetMany(IEnumerable<byte[]> keys, DateTime? version)
        {
            return _sessionSpace.GetMany(keys, version);
        }
        public async override IAsyncEnumerable<(byte[] key, byte[] Value, DateTime version)> GetManyAsync(IAsyncEnumerable<byte[]> keys, DateTime? version, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                await foreach (var b in _spaces[c].GetManyAsync(keys, version, cancellationToken))
                    yield return b;
            }
        }
        public override IEnumerable<(byte[] Key, byte[] Value)> Scan(byte[] begin, byte[] end, byte[][] values)
        {
            return _sessionSpace.Scan(begin, end, values);
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Scan(byte[] begin, byte[] end, byte[][] values, DateTime? version)
        {
            return _sessionSpace.Scan(begin, end, values, version);
        }
        public async override IAsyncEnumerable<(byte[] Key, byte[] Value)> ScanAsync(byte[] begin, byte[] end, byte[][] values, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                await foreach (var b in _spaces[c].ScanAsync(begin, end, values))
                    yield return b;
            }
        }
        public async override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> ScanAsync(byte[] begin, byte[] end, byte[][] values, DateTime? version, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                await foreach (var b in _spaces[c].ScanAsync(begin, end, values, version))
                    yield return b;
            }
        }
        public async override IAsyncEnumerable<(byte[] Key, byte[] Value)> ExportAsync([EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            (byte[] Key, byte[] Value)? current = null;
            DateTime? last = null;

            await foreach (var item in _sessionSpace.ExportAsync(cancellationToken))
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
        public override void ImportAsync(IAsyncEnumerable<(byte[] Key, byte[] Value)> values, CancellationToken cancellationToken = default)
        {
            _sessionSpace.ImportAsync(values, cancellationToken);
        }
        
        public void SaveChanges(CancellationToken cancellationToken)
        {
            var elements = _sessionSpace.ExportAsync(cancellationToken);
            _durableSpace.ImportAsync(elements);
        }
    }
}
