// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Hiperspace.Meta;
using RocksDbSharp;
using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Hiperspace.Rocks
{
    /// <summary>
    /// A Hiperspace implemented with RocksDB
    /// </summary>
    public class RockSpace : HiperSpace
    {
        private RocksDb _db;
        /// <summary>
        /// Create a HiperSpace using the RocksDB provider 
        /// </summary>
        /// <param name="path">path to the RocksDB database</param>
        /// <param name="metaModel">
        /// optional metamodel to ensure that deserialisation is compatible with the model used to serialise objects
        /// and that expected indexes ID are not not changed
        /// </param>
        /// <param name="compress">attempt to open store with compression when metamodel provided</param>
        public RockSpace(string path, MetaModel? metaModel = null, bool compress = false)
        { 
            try
            {
                _db = Open(path, metaModel, metaModel != null ? compress : false);
            }
            catch (MutationException)
            {
                throw;
            }
            catch 
            {
                _db = Open(path, metaModel, !compress);
            }
        }
        protected RocksDb Open(string path, MetaModel? metaModel = null, bool compress = false)
        {
            var option = compress ?
                new DbOptions()
                .SetCompression(Compression.Snappy)
                .SetCreateIfMissing(true) :
                new DbOptions()
                .SetCreateIfMissing(true);

            _db = RocksDb.Open(option, path);

            if (metaModel != null ) 
            {
                var mk = new byte[] { 0x00, 0x00 };
                var stored = Get(mk);    // no proto message starts with 0x00
                if (stored != null) 
                {
                    var current = Hiperspace.Space.FromValue<MetaModel>(stored);
                    if (current != null)
                    {
                        if (!current.Equals(metaModel))
                        {
                            Dispose();
                            throw new MutationException("The MetaModel provided is not compatible with the HyperSpace");
                        }
                        if (current.GetHashCode() != metaModel.GetHashCode())   // additions
                        {
                            metaModel.Merge(current);
                            var bytes = metaModel.Bytes;
                            _db.Put(mk, bytes);
                        }
                    }
                }
                else
                {
                    Bind(mk, metaModel.Bytes);
                }
            }
            return _db;
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, object? source = null)
        {
            var current = _db.Get(key);
            if (current != null)
            {
                return Result.Skip(current);
            }
            _db.Put(key, value);
            RaiseOnBind(key, value, source);
            return Result.Ok(value);
        }
        /// <summary>
        /// Bind and object to the hiperspace using versions. 
        /// </summary>
        /// <remarks>
        /// for Versioned keys the key is prefixed with 0 to indicate that it is versioned
        /// with the version number added at the end
        /// +---+---+--------+----------+
        /// | 0 | n | ...... | 12345678 |
        /// +---+---+--------+----------+
        /// </remarks>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="version"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            var fullkey = new byte[key.Length + sizeof(long) + 1];
            key.CopyTo(fullkey, 1);
            var toend = ulong.MaxValue - (ulong)version.Ticks;
            BinaryPrimitives.WriteUInt64BigEndian(new Span<byte>(fullkey, fullkey.Length - sizeof(long), sizeof(long)), toend);

            var (cur, v) = Get(key, version);
            if (cur != null)
            {
                if (v == version)
                    return Result.Skip(cur);
                if (cur.Length > 0 && cur.SequenceEqual(value))
                    return Result.Skip(cur);    // no change to value
            }
            _db.Put(fullkey, value);
            RaiseOnBind(key, value, source);
            return Result.Ok(value);
        }

        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, object? source)
        {
            return Task.Run(() => Bind(key, value, source));
        }

        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source)
        {
            return Task.Run(() => Bind(key, value, version, source));
        }

        public override IEnumerable<(byte[], byte[])> Space()
        {
            using (var iter = _db.NewIterator())
            {
                while (iter.Valid())
                {
                    yield return (iter.Key(), iter.Value());
                    iter.Next();
                }
            }
        }

        public override Task<IEnumerable<(byte[], byte[])>> SpaceAsync()
        {
            return Task.Run(() =>
            {
                return Space().ToList() as IEnumerable<(byte[], byte[])>;
            });
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
        public override IEnumerable<(byte[], byte[])> Find(byte[] begin, byte[] end)
        {
            RaiseOnBeforeFind(ref begin, ref end);
            using (var iter = _db.NewIterator())
            {
                var range = iter.Seek(begin);
                while (range.Valid())
                {
                    var k = range.Key();
                    if (Compare(begin, k) <= 0 && Compare(end, k) >= 0)
                    {
                        var v = range.Value();
                        yield return (range.Key(), range.Value());
                        range.Next();
                    }
                    else
                        break;
                }
            }
            RaiseOnAfterFind(ref begin, ref end);
        }
        private static byte[] FF = new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff };
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            RaiseOnBeforeFind(ref begin, ref end);
            var vbegin = new byte[begin.Length + sizeof(long) + 1];
            var vend = new byte[end.Length + sizeof(long) + 1];
            begin.CopyTo(new Span<byte>(vbegin, 1, begin.Length));
            end.CopyTo(new Span<byte>(vend, 1, end.Length));
            FF.CopyTo(new Span<byte>(vend, vend.Length - sizeof(long), sizeof(long)));
            using (var iter = _db.NewIterator())
            {
                byte[] lastKey = Array.Empty<byte>();
                byte[] lastValue = Array.Empty<byte>();
                long lastVersion = 0;
                var range = iter.Seek(vbegin);
                while (range.Valid())
                {
                    var k = range.Key();
                    if (Compare(k, vend) <= 0)
                    {
                        var keypart = new byte[k.Length - sizeof(long) - 1];
                        var span = new Span<byte>(k, 1, k.Length - sizeof(long) - 1);
                        span.CopyTo(keypart);
                        if (lastKey == Array.Empty<byte>() || Compare(keypart, lastKey) == 0)
                        {
                            var ver = (long)(ulong.MaxValue - BinaryPrimitives.ReadUInt64BigEndian(new Span<byte>(k, k.Length - sizeof(ulong), sizeof(ulong))));
                            if ((version.HasValue && ver < version.Value.Ticks && ver > lastVersion) || (!version.HasValue && lastVersion == 0))
                            {
                                lastKey = keypart;
                                lastVersion = ver;
                                lastValue = range.Value();
                            }
                        }
                        else if (lastVersion != 0)
                        {
                            if (lastValue != null)
                                yield return (lastKey, new DateTime(lastVersion), lastValue);
                            lastKey = keypart;
                            lastVersion = (long)(ulong.MaxValue - BinaryPrimitives.ReadUInt64BigEndian(new Span<byte>(k, k.Length - sizeof(ulong), sizeof(ulong))));
                            lastValue = range.Value();
                        }
                    }
                    else
                        break;
                    range.Next();
                }
                if (lastVersion != 0 && lastValue != null)
                {
                    yield return (lastKey, new DateTime(lastVersion), lastValue);
                }
                RaiseOnAfterFind(ref begin, ref end);
            }
        }

        public override Task<IEnumerable<(byte[], byte[])>> FindAsync(byte[] begin, byte[] end)
        {
            return Task.Run(() => Find(begin, end).ToList() as IEnumerable<(byte[], byte[])>);
        }
        public override Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>> FindAsync(byte[] begin, byte[] end, DateTime? version)
        {
            return Task.Run(() => Find(begin, end, version).ToList() as IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>);
        }

        public override byte[] Get(byte[] key)
        {
            RaiseOnBeforeGet(ref key);
            var result = _db.Get(key);
            RaiseOnAfterGet(ref key, ref result);
            return result;
        }

        public override (byte[], DateTime) Get(byte[] key, DateTime? version)
        {
            RaiseOnBeforeGet(ref key);
            var vbegin = new byte[key.Length + sizeof(long) + 1];
            key.CopyTo(new Span<byte>(vbegin, 1, key.Length));
            byte[] lastValue = Array.Empty<byte>();
            long lastVersion = 0;
            using (var iter = _db.NewIterator())
            {
                var range = iter.Seek(vbegin);
                while (range.Valid())
                {
                    var k = range.Key();
                    var keypart = new byte[k.Length - sizeof(ulong) - 1];
                    var span = new Span<byte>(k, 1, k.Length - sizeof(ulong) - 1);
                    span.CopyTo(keypart);
                    if (Compare(keypart, key) == 0)
                    {
                        var ver = (long)(ulong.MaxValue - BinaryPrimitives.ReadUInt64BigEndian(new Span<byte>(k, k.Length - sizeof(ulong), sizeof(ulong))));
                        if (version.HasValue)
                        {
                            if (ver <= version.Value.Ticks && ver > lastVersion)
                            {
                                lastVersion = ver;
                                lastValue = range.Value();
                            }
                        }
                        else
                        {
                            var result = range.Value();
                            RaiseOnAfterGet(ref key, ref result);
                            return (result, new DateTime(ver));
                        }
                    }
                    else
                        break;
                    range.Next();
                }
            }
            if (lastVersion != 0)
            {
                if (lastValue != null)
                {
                    RaiseOnAfterGet(ref key, ref lastValue);
                    return (lastValue, new DateTime(lastVersion));
                }
            }
            return (Array.Empty<byte>(), new DateTime());
        }
        public override Task<byte[]> GetAsync(byte[] key)
        {
            return Task.Run(() => Get(key));
        }
        public override Task<(byte[], DateTime)> GetAsync(byte[] key, DateTime? version)
        {
            return Task.Run(() => Get(key, version));
        }

        public override IEnumerable<(byte[], DateTime)> GetVersions(byte[] key)
        {
            RaiseOnBeforeGet(ref key);
            var finding = true;
            var begin = new byte[key.Length + sizeof(long) + 1];
            var end = new byte[key.Length + sizeof(long) + 1];
            key.CopyTo(begin, 1);
            key.CopyTo(end, 1);
            BinaryPrimitives.WriteUInt64BigEndian(new Span<byte>(begin, begin.Length - sizeof(long), sizeof(long)), 0);
            BinaryPrimitives.WriteUInt64BigEndian(new Span<byte>(end, end.Length - sizeof(long), sizeof(long)), ulong.MaxValue);
            foreach (var r in Find(begin, end))
            {
                var keypart = new byte[r.Item1.Length - sizeof(ulong) - 1];
                var span = new Span<byte>(r.Item1, 1, r.Item1.Length - sizeof(ulong) - 1);

                if (Compare(key, keypart) == 0)
                {
                    if (finding)
                    {
                        var result = r.Item1;
                        RaiseOnAfterGet(ref key, ref result);
                    }
                    var ver = (long)(ulong.MaxValue - BinaryPrimitives.ReadUInt64BigEndian(new Span<byte>(r.Item1, r.Item1.Length - sizeof(ulong), sizeof(ulong))));
                    yield return (r.Item2, new DateTime(ver));
                }
            }
        }

        public override Task<IEnumerable<(byte[] value, DateTime version)>> GetVersionsAsync(byte[] key)
        {
            return Task.Run (() => GetVersions(key).ToList() as IEnumerable<(byte[] value, DateTime version)>);
        }
        protected override void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _db.Flush(new FlushOptions());
                    _db.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }
    }
}
