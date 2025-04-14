using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Hiperspace.Heap
{
    public class FailoverSpace : HiperSpace
    {
        private (HiperSpace space, bool fault)[] _spaces;
        private HiperSpace _primary;
        private HiperSpace? _sync;
        private Func<HiperSpace> _createSync;
#if NET9_0_OR_GREATER
        private readonly Lock _lock = new();
#else
        private readonly object _lock = new();
#endif
        /// <summary>
        /// Create a failover space
        /// </summary>
        /// <param name="stores">collection of Hiperspace</param>
        /// <param name="createSync">function to create a HeapSpace</param>
        /// <exception cref="ArgumentException">should be at least two stores</exception>
        public FailoverSpace([NotNull] HiperSpace[] stores, Func<HiperSpace> createSync)
        {
            if (stores.Length < 2)
                throw new ArgumentException($"{nameof(FailoverSpace)} should have at least two spaces");
            _primary = stores[0];
            _spaces = new (HiperSpace space, bool fault)[stores.Length - 1];
            for (int c = 0; c < stores.Length - 1; c++)
            {
                _spaces[c] = (stores[c], false);
            }
            _createSync = createSync;
        }
        public override BaseTypeModel? TypeModel
        {
            get
            {
                return _primary.TypeModel;
            }
            set
            {
                for (int c = 0; c < _spaces.Length; c++)
                    _spaces[c].space.TypeModel = value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private async Task SyncAsync()
        {
            HiperSpace? sync = null;
            lock (_lock)
            {
                if (_sync == null)
                {
                    sync = _sync!;
                    _sync = null;
                }
            }

            if (sync != null)
            {
                bool fault = false;
                for (int c = 0; c < _spaces.Length; c++)
                {
                    if (_spaces[c].fault)
                    {
                        try
                        {
                            await foreach (var row in sync.ExportAsync())
                            {
                                if (row.Item1.Length > 0 && row.Item1[0] != 0x00)
                                {
                                    _spaces[c].space.Bind(row.Item1, row.Item2, null);
                                }
                                else
                                {
                                    var keypart = new byte[row.Item1.Length - sizeof(long) - 1];
                                    var span = new Span<byte>(row.Item1, 1, row.Item1.Length - sizeof(long) - 1);
                                    span.CopyTo(keypart);
                                    var ver = (long)(ulong.MaxValue - BinaryPrimitives.ReadUInt64BigEndian(new Span<byte>(row.Item1, row.Item1.Length - sizeof(ulong), sizeof(ulong))));
                                    var stamp = new DateTime(ver);
                                    _spaces[c].space.Bind(keypart, row.Item2, stamp, null);
                                }
                            }
                            _spaces[c].fault = false;
                        }
                        catch (Exception)
                        {
                            fault = true;
                            _spaces[c].fault = true;
                        }
                    }
                }
                if (!fault)
                {
                    sync.Dispose();
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Fault(int c)
        {
            _spaces[c].fault = true;
            if (_primary == _spaces[c].space)
            {
                for (int d = 0; d < _spaces.Length; d++)
                {
                    if (!_spaces[d].fault)
                    {
                        _primary = _spaces[d].space;
                        break;
                    }
                }
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Recover()
        {
            for (int c = 0; c < _spaces.Length; c++)
            {
                if (_spaces[c].space == _primary)
                {
                    _spaces[c].fault = true;
                }
                else if (!_spaces[c].fault)
                {
                    _primary = _spaces[c].space;
                    Task.Run(SyncAsync);
                    break;
                }
            }
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, object? source = null)
        {
            return BindAsync(key, value, source).GetAwaiter().GetResult();
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            return BindAsync(key, value, version, source).GetAwaiter().GetResult();
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            return BindAsync(key, value, version, priorVersion, source).GetAwaiter().GetResult();
        }

        public override async Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, object? source = null)
        {
            var tasks = new Task<Result<byte[]>>[_spaces.Length];
            Result<byte[]>? result = null;
            Exception? exception = null;

            for (int c = 0; c < _spaces.Length; c++)
            {
                tasks[c] = _spaces[c].space.BindAsync(key, value, source);
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                try
                {
                    var r = await tasks[c];
                    if (!result.HasValue)
                        result = r;
                }
                catch (Exception e)
                {
                    lock (_lock)
                    {
                        if (_sync == null)
                            _sync = _createSync();
                        _sync.Bind(key, value);
                        Fault(c);
                        exception = e;
                    }
                }
            }
            if (result.HasValue)
                return result.Value;
            else
                throw exception!;
        }

        public override async Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            var tasks = new Task<Result<byte[]>>[_spaces.Length];
            Result<byte[]>? result = null;
            Exception? exception = null;

            for (int c = 0; c < _spaces.Length; c++)
            {
                tasks[c] = _spaces[c].space.BindAsync(key, value, source);
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                try
                {
                    var r = await tasks[c];
                    if (!result.HasValue)
                        result = r;
                }
                catch (Exception e)
                {
                    lock (_lock)
                    {
                        if (_sync == null)
                            _sync = _createSync();
                        _sync.Bind(key, value, version);
                        Fault(c);
                        exception = e;
                    }
                }
            }
            if (result.HasValue)
                return result.Value;
            else
                throw exception!;
        }

        public override async Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            var tasks = new Task<Result<byte[]>>[_spaces.Length];
            Result<byte[]>? result = null;
            Exception? exception = null;
            for (int c = 0; c < _spaces.Length; c++)
            {
                tasks[c] = _spaces[c].space.BindAsync(key, value, version, priorVersion, source);
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                try
                {
                    var r = await tasks[c];
                    if (!result.HasValue)
                        result = r;
                }
                catch (Exception e)
                {
                    lock (_lock)
                    {
                        if (_sync == null)
                            _sync = _createSync();
                        _sync.Bind(key, value, version, priorVersion);
                        Fault(c);
                        exception = e;
                    }
                }
            }
            if (result.HasValue)
                return result.Value;
            else
                throw exception!;
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Delta(byte[] key, DateTime? version)
        {
            try
            {
                return _primary.Delta(key, version);
            }
            catch (Exception)
            {
                Recover();
                return _primary.Delta(key, version);
            }
        }

        public override IEnumerable<(byte[] Key, byte[] Value)> Find(byte[] begin, byte[] end)
        {
            try
            {
                return _primary.Find(begin, end);
            }
            catch (Exception)
            {
                Recover();
                return _primary.Find(begin, end);
            }
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            try
            {
                return _primary.Find(begin, end, version);
            }
            catch (Exception)
            {
                Recover();
                return _primary.Find(begin, end, version);
            }
        }

        public override IAsyncEnumerable<(byte[] Key, byte[] Value)> FindAsync(byte[] begin, byte[] end, CancellationToken cancellationToken = default)
        {
            try
            {
                return _primary.FindAsync(begin, end, cancellationToken);
            }
            catch (Exception)
            {
                Recover();
                return _primary.FindAsync(begin, end, cancellationToken);
            }
        }

        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindAsync(byte[] begin, byte[] end, DateTime? version, CancellationToken cancellationToken = default)
        {
            try
            {
                return _primary.FindAsync(begin, end, version, cancellationToken);
            }
            catch (Exception)
            {
                Recover();
                return _primary.FindAsync(begin, end, version, cancellationToken);
            }
        }

        public override byte[] Get(byte[] key)
        {
            try
            {
                return _primary.Get(key);
            }
            catch (Exception)
            {
                Recover();
                return _primary.Get(key);
            }
        }

        public override (byte[] Value, DateTime version) Get(byte[] key, DateTime? version)
        {
            try
            {
                return _primary.Get(key, version);
            }
            catch (Exception)
            {
                Recover();
                return _primary.Get(key, version);
            }
        }

        public override Task<byte[]> GetAsync(byte[] key)
        {
            try
            {
                return _primary.GetAsync(key);
            }
            catch (Exception)
            {
                Recover();
                return _primary.GetAsync(key);
            }
        }

        public override Task<(byte[] Value, DateTime version)> GetAsync(byte[] key, DateTime? version)
        {
            try
            {
                return _primary.GetAsync(key, version);
            }
            catch (Exception)
            {
                Recover();
                return _primary.GetAsync(key, version);
            }
        }

        public override IEnumerable<(byte[] value, DateTime version)> GetVersions(byte[] key)
        {
            try
            {
                return _primary.GetVersions(key);
            }
            catch (Exception)
            {
                Recover();
                return _primary.GetVersions(key);
            }
        }

        public override IAsyncEnumerable<(byte[] value, DateTime version)> GetVersionsAsync(byte[] key, CancellationToken cancellationToken = default)
        {
            try
            {
                return _primary.GetVersionsAsync(key, cancellationToken);
            }
            catch (Exception)
            {
                Recover();
                return _primary.GetVersionsAsync(key, cancellationToken);
            }
        }

        [Obsolete("Use ExportAsync instead")]
        public override IEnumerable<(byte[] Key, byte[] Value)> Space()
        {
            try
            {
                return _primary.Space();
            }
            catch (Exception)
            {
                Recover();
                return _primary.Space();
            }
        }

        [Obsolete("Use ExportAsync instead")]
        public override IAsyncEnumerable<(byte[] Key, byte[] Value)> SpaceAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                return _primary.SpaceAsync(cancellationToken);
            }
            catch (Exception)
            {
                Recover();
                return _primary.SpaceAsync(cancellationToken);
            }
        }
        public override Result<(byte[] Key, byte[] Value)>[] BatchBind((byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)
        {
            try
            {
                return _primary.BatchBind(batch);
            }
            catch (Exception)
            {
                Recover();
                return _primary.BatchBind(batch);
            }
        }
        public override Result<(byte[] Key, byte[] Value)>[] BatchBind((byte[] key, byte[] value, DateTime version, object? source)[] batch)
        {
            try
            {
                return _primary.BatchBind(batch);
            }
            catch (Exception)
            {
                Recover();
                return _primary.BatchBind(batch);
            }
        }
        public override Result<(byte[] Key, byte[] Value)>[] BatchBind((byte[] key, byte[] value, object? source)[] batch)
        {
            return base.BatchBind(batch);
        }
        public override async Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)
        {
            var tasks = new Task<Result<(byte[] Key, byte[] Value)>[]>[_spaces.Length];
            Result<(byte[] Key, byte[] Value)>[]? result = null;
            Exception? exception = null;
            for (int c = 0; c < _spaces.Length; c++)
            {
                tasks[c] = _spaces[c].space.BatchBindAsync(batch);
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                try
                {
                    var r = await tasks[c];
                    if (result == null)
                        result = r;
                }
                catch (Exception e)
                {
                    lock (_lock)
                    {
                        if (_sync == null)
                            _sync = _createSync();
                        _sync.BatchBind(batch);
                        Fault(c);
                        exception = e;
                    }
                }
            }
            if (result != null)
                return result;
            else
                throw exception!;
        }
        public override async Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, DateTime version, object? source)[] batch)
        {
            var tasks = new Task<Result<(byte[] Key, byte[] Value)>[]>[_spaces.Length];
            Result<(byte[] Key, byte[] Value)>[]? result = null;
            Exception? exception = null;
            for (int c = 0; c < _spaces.Length; c++)
            {
                tasks[c] = _spaces[c].space.BatchBindAsync(batch);
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                try
                {
                    var r = await tasks[c];
                    if (result == null)
                        result = r;
                }
                catch (Exception e)
                {
                    lock (_lock)
                    {
                        if (_sync == null)
                            _sync = _createSync();
                        _sync.BatchBind(batch);
                        Fault(c);
                        exception = e;
                    }
                }
            }
            if (result != null)
                return result;
            else
                throw exception!;
        }
        public override async Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, object? source)[] batch)
        {
            var tasks = new Task<Result<(byte[] Key, byte[] Value)>[]>[_spaces.Length];
            Result<(byte[] Key, byte[] Value)>[]? result = null;
            Exception? exception = null;
            for (int c = 0; c < _spaces.Length; c++)
            {
                tasks[c] = _spaces[c].space.BatchBindAsync(batch);
            }
            for (int c = 0; c < _spaces.Length; c++)
            {
                try
                {
                    var r = await tasks[c];
                    if (result == null)
                        result = r;
                }
                catch (Exception e)
                {
                    lock (_lock)
                    {
                        if (_sync == null)
                            _sync = _createSync();
                        _sync.BatchBind(batch);
                        Fault(c);
                        exception = e;
                    }
                }
            }
            if (result != null)
                return result;
            else
                throw exception!;
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindDelta(byte[] begin, DateTime? version, DateTime? DeltaFrom)
        {
            try
            {
                return _primary.FindDelta(begin, version, DeltaFrom);
            }
            catch (Exception)
            {
                Recover();
                return _primary.FindDelta(begin, version, DeltaFrom);
            }
        }
        public override IEnumerable<(byte[] Key, byte[] Value)> FindIndex(byte[] begin, byte[] end)
        {
            try
            {
                return _primary.FindIndex(begin, end);
            }
            catch (Exception)
            {
                Recover();
                return _primary.FindIndex(begin, end);
            }
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndex(byte[] begin, byte[] end, DateTime? version)
        {
            try
            {
                return _primary.FindIndex(begin, end, version);
            }
            catch (Exception)
            {
                Recover();
                return _primary.FindIndex(begin, end, version);
            }
        }
        public override IAsyncEnumerable<(byte[] Key, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, CancellationToken cancellationToken = default)
        {
            try
            {
                return _primary.FindIndexAsync(begin, end, cancellationToken);
            }
            catch (Exception)
            {
                Recover();
                return _primary.FindIndexAsync(begin, end, cancellationToken);
            }
        }
        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, DateTime? version, CancellationToken cancellationToken = default)
        {
            try
            {
                return _primary.FindIndexAsync(begin, end, version, cancellationToken);
            }
            catch (Exception)
            {
                Recover();
                return _primary.FindIndexAsync(begin, end, version, cancellationToken);
            }
        }
        public override (byte[] Key, byte[] Value)? GetFirst(byte[] begin, byte[] end)
        {
            try
            {
                return _primary.GetFirst(begin, end);
            }
            catch (Exception)
            {
                Recover();
                return _primary.GetFirst(begin, end);
            }
        }
        public override (byte[] Key, DateTime AsAt, byte[] Value)? GetFirst(byte[] begin, byte[] end, DateTime? version)
        {
            try
            {
                return _primary.GetFirst(begin, end, version);
            }
            catch (Exception)
            {
                Recover();
                return _primary.GetFirst(begin, end, version);
            }
        }
        public override Task<(byte[] Key, byte[] Value)?> GetFirstAsync(byte[] begin, byte[] end)
        {
            try
            {
                return _primary.GetFirstAsync(begin, end);
            }
            catch (Exception)
            {
                Recover();
                return _primary.GetFirstAsync(begin, end);
            }
        }
        public override Task<(byte[] Key, DateTime AsAt, byte[] Value)?> GetFirstAsync(byte[] begin, byte[] end, DateTime? version)
        {
            try
            {
                return _primary.GetFirstAsync(begin, end, version);
            }
            catch (Exception)
            {
                Recover();
                return _primary.GetFirstAsync(begin, end, version);
            }
        }
        public override IEnumerable<Horizon> GetHorizons()
        {
            var result = new HashSet<Horizon>();
            for (int c = 0; c < _spaces.Length; c++)
            {
                foreach (var horizon in _spaces[c].space.GetHorizons())
                {
                    result.Add(horizon);
                }
            }
            return result;
        }
        public override (byte[] Key, byte[] Value)? GetLast(byte[] begin, byte[] end)
        {
            try
            {
                return _primary.GetLast(begin, end);
            }
            catch (Exception)
            {
                Recover();
                return _primary.GetLast(begin, end);
            }
        }
        public override (byte[] Key, DateTime AsAt, byte[] Value)? GetLast(byte[] begin, byte[] end, DateTime? version)
        {
            try
            {
                return _primary.GetLast(begin, end, version);
            }
            catch (Exception)
            {
                Recover();
                return _primary.GetLast(begin, end, version);
            }
        }
        public override Task<(byte[] Key, byte[] Value)?> GetLastAsync(byte[] begin, byte[] end)
        {
            try
            {
                return _primary.GetLastAsync(begin, end);
            }
            catch (Exception)
            {
                Recover();
                return _primary.GetLastAsync(begin, end);
            }
        }
        public override Task<(byte[] Key, DateTime AsAt, byte[] Value)?> GetLastAsync(byte[] begin, byte[] end, DateTime? version)
        {
            try
            {
                return _primary.GetLastAsync(begin, end, version);
            }
            catch (Exception)
            {
                Recover();
                return _primary.GetLastAsync(begin, end, version);
            }
        }
        public override IEnumerable<(byte[] key, byte[] value)> GetMany(IEnumerable<byte[]> keys)
        {
            try
            {
                return _primary.GetMany(keys);
            }
            catch (Exception)
            {
                Recover();
                return _primary.GetMany(keys);
            }
        }
        public override IEnumerable<(byte[] key, byte[] Value, DateTime version)> GetMany(IEnumerable<byte[]> keys, DateTime? version)
        {
            try
            {
                return _primary.GetMany(keys, version);
            }
            catch (Exception)
            {
                Recover();
                return _primary.GetMany(keys, version);
            }
        }
        public override async IAsyncEnumerable<(byte[] key, byte[] value)> GetManyAsync(IAsyncEnumerable<byte[]> keys, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            await foreach (var row in _primary.GetManyAsync(keys, cancellationToken))
            {
                yield return row;
            }
        }
        public override async IAsyncEnumerable<(byte[] key, byte[] Value, DateTime version)> GetManyAsync(IAsyncEnumerable<byte[]> keys, DateTime? version, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            await foreach (var row in _primary.GetManyAsync(keys, version, cancellationToken))
            {
                yield return row;
            }
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> Nearest(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0)
        {
            try
            {
                return _primary.Nearest(begin, end, version, space, method, limit);
            }
            catch (Exception)
            {
                Recover();
                return _primary.Nearest(begin, end, version, space, method, limit);
            }
        }
        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> NearestAsync(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0, CancellationToken cancellationToken = default)
        {
            try
            {
                return _primary.NearestAsync(begin, end, version, space, method, limit, cancellationToken);
            }
            catch (Exception)
            {
                Recover();
                return _primary.NearestAsync(begin, end, version, space, method, limit, cancellationToken);
            }
        }
        public override IEnumerable<(byte[] Key, byte[] Value)> Scan(byte[] begin, byte[] end, byte[][] values)
        {
            try
            {
                return _primary.Scan(begin, end, values);
            }
            catch (Exception)
            {
                Recover();
                return _primary.Scan(begin, end, values);
            }
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Scan(byte[] begin, byte[] end, byte[][] values, DateTime? version)
        {
            try
            {
                return _primary.Scan(begin, end, values, version);
            }
            catch (Exception)
            {
                Recover();
                return _primary.Scan(begin, end, values, version);
            }
        }
        public override IAsyncEnumerable<(byte[] Key, byte[] Value)> ScanAsync(byte[] begin, byte[] end, byte[][] values, CancellationToken cancellationToken = default)
        {
            try
            {
                return _primary.ScanAsync(begin, end, values, cancellationToken);
            }
            catch (Exception)
            {
                Recover();
                return _primary.ScanAsync(begin, end, values, cancellationToken);
            }
        }
        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> ScanAsync(byte[] begin, byte[] end, byte[][] values, DateTime? version, CancellationToken cancellationToken = default)
        {
            try
            {
                return _primary.ScanAsync(begin, end, values, version, cancellationToken);
            }
            catch (Exception)
            {
                Recover();
                return _primary.ScanAsync(begin, end, values, version, cancellationToken);
            }
        }
        public override IAsyncEnumerable<(byte[] Key, byte[] Value)> ExportAsync(CancellationToken cancellationToken = default)
        {
            return _primary.ExportAsync(cancellationToken);
        }
        public override void ImportAsync(IAsyncEnumerable<(byte[] Key, byte[] Value)> values, CancellationToken cancellationToken = default)
        {
            _primary.ImportAsync(values, cancellationToken);
        }
    }
}
