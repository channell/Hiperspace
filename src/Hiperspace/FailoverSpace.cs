// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;

namespace Hiperspace
{
    /// <summary>
    /// A hiperspace aggregate that partitions writes to multiple hiperspaces
    /// </summary>
    public class FailoverSpace : HiperSpace
    {
        private (HiperSpace space, DateTime? fault)[] _spaces;
        private HiperSpace _primary;

        public FailoverSpace([NotNull] HiperSpace[] stores)
        {
            if (stores.Length < 2)
                throw new ArgumentException($"{nameof(FailoverSpace)} should have at least two spaces");
            _primary = stores[0];
            _spaces = new(HiperSpace space, DateTime ? fault)[stores.Length - 1];
            for (int c = 0; c < stores.Length - 1; c++)
            {
                _spaces[c].space = stores[c + 1];
            }
        }

        private void Recover (DateTime start)
        {
            lock (_spaces)
            {
                HiperSpace? target = null;
                for (int c = 0; c < _spaces.Length - 1; c++)
                {
                    if (!_spaces[c].fault.HasValue)
                    {
                        target = _spaces[c].space;
                        break;
                    }
                }
                if (target == null)
                    throw new IOException("No Failover Space is currently available");
                else
                {
                    for (int c = 0, i = 1; c < _spaces.Length - 1; c++)
                    {
                        if (_spaces[c].space != target)
                        {
                            _spaces[i++] = _spaces[c];
                        }
                    }
                    _spaces[_spaces.Length - 1] = (target, start);
                    _primary = target;
                }
            }
        }
        private void Sync (int c)
        {
            lock (_spaces) 
            {
                var target = _spaces[c];
                if (target.fault.HasValue)
                {
                    try
                    {
                        foreach (var row in _primary.Space())
                        {
                            if (row.Key.Length > 0 && row.Key[0] != 0x00)
                            {
                                target.space.Bind(row.Key, row.Value, null);
                            }
                            else
                            {
                                var keypart = new byte[row.Key.Length - sizeof(long) - 1];
                                var span = new Span<byte>(row.Key, 1, row.Key.Length - sizeof(long) - 1);
                                span.CopyTo(keypart);
                                var ver = (long)(ulong.MaxValue - BinaryPrimitives.ReadUInt64BigEndian(new Span<byte>(row.Key, row.Key.Length - sizeof(ulong), sizeof(ulong))));
                                if (ver > target.fault.Value.Ticks)
                                {
                                    target.space.Bind(row.Key, row.Value, new DateTime(ver), null);
                                }
                            }
                        }
                        target.fault = null;
                    }
                    catch { }   // still in fault
                }
            }
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, object? source)
        {
            var start = DateTime.Now;
            Task.Run(() =>
            {
                var tasks = new Task[_spaces.Length];
                for (int c = 0; c < _spaces.Length; c++)
                {
                    tasks[c] = _spaces[c].space.BindAsync(key, value, source);
                }
                for (int c = 0; c < tasks.Length; c++)
                {
                    tasks[c].Wait();
                    if (tasks[c].IsCompleted && _spaces[c].fault.HasValue)
                    {
                        Sync(c);
                    }
                    else if (!_spaces[c].fault.HasValue)
                    {
                        lock (_spaces)
                        {
                            _spaces[c].fault = start;
                        }
                    }
                }
            });
            try
            {
                return _primary.Bind(key, value, source);
            }
            catch
            {
                Recover(start);
                return _primary.Bind(key, value, source);
            }
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            var start = DateTime.Now;
            Task.Run(() =>
            {
                var tasks = new Task[_spaces.Length];
                for (int c = 0; c < _spaces.Length; c++)
                {
                    tasks[c] = _spaces[c].space.BindAsync(key, value, version, source);
                }
                for (int c = 0; c < tasks.Length; c++)
                {
                    tasks[c].Wait();
                    if (tasks[c].IsCompleted && _spaces[c].fault.HasValue)
                    {
                        Sync(c);
                    }
                    else if (!_spaces[c].fault.HasValue)
                    {
                        lock (_spaces)
                        {
                            _spaces[c].fault = start;
                        }
                    }
                }
            });
            try
            {
                return _primary.Bind(key, value, version, source);
            }
            catch
            {
                Recover(start);
                return _primary.Bind(key, value, version, source);
            }
        }
        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            var start = DateTime.Now;
            Task.Run(() =>
            {
                var tasks = new Task[_spaces.Length];
                for (int c = 0; c < _spaces.Length; c++)
                {
                    tasks[c] = _spaces[c].space.BindAsync(key, value, version, priorVersion, source);
                }
                for (int c = 0; c < tasks.Length; c++)
                {
                    tasks[c].Wait();
                    if (tasks[c].IsCompleted && _spaces[c].fault.HasValue)
                    {
                        Sync(c);
                    }
                    else if (!_spaces[c].fault.HasValue)
                    {
                        lock (_spaces)
                        {
                            _spaces[c].fault = start;
                        }
                    }
                }
            });
            try
            {
                return _primary.Bind(key, value, version, source);
            }
            catch
            {
                Recover(start);
                return _primary.Bind(key, value, version, source);
            }
        }

        public override async Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, object? source)
        {
            return await Task.Run(() => Bind(key, value, source));
        }
        public override async Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            return await Task.Run(() => Bind(key, value, version, source));
        }
        public override async Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            return await Task.Run(() => Bind(key, value, version, priorVersion, source));
        }

        public override IEnumerable<(byte[], byte[])> Find(byte[] begin, byte[] end)
        {
            var start = DateTime.Now;
            try
            {
                return _primary.Find(begin, end);
            }
            catch
            {
                Recover(start);
                return _primary.Find(begin, end);
            }
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            var start = DateTime.Now;
            try
            {
                return _primary.Find(begin, end, version);
            }
            catch
            {
                Recover(start);
                return _primary.Find(begin, end, version);
            }
        }


        public override async Task<IEnumerable<(byte[], byte[])>> FindAsync(byte[] begin, byte[] end)
        {
            return await Task.Run(() => Find(begin, end));
        }
        public async override Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>> FindAsync(byte[] begin, byte[] end, DateTime? version)
        {
            return await Task.Run(() => Find(begin, end, version));
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> Nearest(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0)
        {
            var start = DateTime.Now;
            try
            {
                return _primary.Nearest(begin, end, version, space, method, limit);
            }
            catch
            {
                Recover(start);
                return _primary.Nearest(begin, end, version, space, method, limit);
            }
        }
        public override async Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)>> NearestAsync(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0)
        {
            return await Task.Run(() => Nearest (begin, end, version, space, method, limit));
        }

        public override IEnumerable<(byte[] value, DateTime version)> GetVersions(byte[] key)
        {
            var start = DateTime.Now;
            try
            {
                return _primary.GetVersions(key);
            }
            catch
            {
                Recover(start);
                return _primary.GetVersions(key);
            }
        }

        public async override Task<IEnumerable<(byte[] value, DateTime version)>> GetVersionsAsync(byte[] key)
        {
            return await Task.Run(() => GetVersions(key));
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
            var start = DateTime.Now;
            try
            {
                return _primary.Get(key);
            }
            catch
            {
                Recover(start);
                return _primary.Get(key);
            }
        }
        public override (byte[], DateTime) Get(byte[] key, DateTime? version)
        {
            var start = DateTime.Now;
            try
            {
                return _primary.Get(key, version);
            }
            catch
            {
                Recover(start);
                return _primary.Get(key, version);
            }
        }

        public override async Task<byte[]> GetAsync(byte[] key)
        {
            return await Task.Run(() => Get(key));
        }
        public async override Task<(byte[], DateTime)> GetAsync(byte[] key, DateTime? version)
        {
            return await Task.Run(() => Get(key, version));
        }

        public override IEnumerable<(byte[], byte[])> Space()
        {
            var start = DateTime.Now;
            try
            {
                return _primary.Space();
            }
            catch
            {
                Recover(start);
                return _primary.Space();
            }
        }

        public override async Task<IEnumerable<(byte[], byte[])>> SpaceAsync()
        {
            return await Task.Run(() => Space());
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Delta(byte[] key, DateTime? version)
        {
            var start = DateTime.Now;
            try
            {
                return _primary.Delta(key, version);
            }
            catch
            {
                Recover(start);
                return _primary.Delta(key, version);
            }
        }
    }
}
