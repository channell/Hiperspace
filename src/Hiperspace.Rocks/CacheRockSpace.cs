// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Hiperspace.Meta;
using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Hiperspace.Rocks
{
    public class CacheRockSpace : RockSpace
    {
        /// <summary>
        /// Create a HiperSpace using the RocksDB provider that does not include history
        /// </summary>
        /// <param name="path">path to the RocksDB database</param>
        /// <param name="metaModel">
        /// optional metamodel to ensure that deserialisation is compatible with the model used to serialise objects
        /// and that expected indexes ID are not not changed
        /// </param>
        /// <param name="compress">attempt to open store with compression when metamodel provided</param>
        public CacheRockSpace(string path, MetaModel? metaModel = null, bool compress = false, bool read = false) 
            : base (path, metaModel, compress, read) { }

        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            var fullkey = new byte[key.Length + 1];
            key.CopyTo(fullkey, 1);
            return Bind(fullkey, value, source);
        }
        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source)
        {
            return Task.Run(() => Bind(key, value, version, source));
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            foreach (var (key, value) in Find (begin, end))
                yield return (key, DateTime.Now, value);
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Delta(byte[] begin, DateTime? version)
        {
            var end = Hiperspace.Space.DeltaKey(begin);
            return Find(begin, end, version);
        }
        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindAsync(byte[] begin, byte[] end, DateTime? version, CancellationToken cancellationToken = default)
        {
            return Find(begin, end, version).ToAsyncEnumerable(cancellationToken);
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> Nearest(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0)
        {
            var vbegin = new byte[begin.Length + 1];
            var vend = new byte[end.Length + 1];
            begin.CopyTo(new Span<byte>(vbegin, 1, begin.Length));
            end.CopyTo(new Span<byte>(vend, 1, end.Length));

            space.Float();
            var ranks = new SortedSet<Nearest>();

            foreach (var (key, value) in Find(begin, end))
            {
                var vec = Hiperspace.Space.FromValue<Vector>(TypeModel, value);
                var distance = space.Nearest(vec, method);
                if (distance.HasValue)
                    ranks.Add(new Nearest(distance.Value, key));
            }
            var keys = limit == 0 ? ranks : ranks.Take(limit);

            foreach (var r in keys)
            {
                var res = Get(r.Key, version);
                yield return (r.Key, res.Item2, res.Item1, r.Distance);
            }
        }
        public override (byte[], DateTime) Get(byte[] key, DateTime? version)
        {
            var fullkey = new byte[key.Length + 1];
            key.CopyTo(fullkey, 1);
            return (Get(fullkey), DateTime.Now);
        }

        public override Task<(byte[], DateTime)> GetAsync(byte[] key, DateTime? version)
        {
            return Task.Run(() => Get(key, version));
        }
        public override IEnumerable<(byte[], DateTime)> GetVersions(byte[] key)
        {
            return Array.Empty<(byte[] value, DateTime version)>();
        }
        public override IAsyncEnumerable<(byte[] value, DateTime version)> GetVersionsAsync(byte[] key, CancellationToken cancellationToken = default)
        {
            return GetVersions(key).ToAsyncEnumerable(cancellationToken);
        }

        /// <summary>
        /// Asynchronously exports all key-value pairs from the data store as an asynchronous stream, adding a timestamp for versioned elements.
        /// </summary>
        /// <remarks>For certain keys, a timestamp is appended to the key to indicate the export time.
        /// </remarks>
        /// <param name="cancellationToken">A cancellation token that can be used to cancel the export operation.</param>
        /// <returns>An asynchronous stream of tuples containing the key and value bytes for each exported entry. The stream may
        /// be empty if there are no entries to export.</returns>
        public async override IAsyncEnumerable<(byte[] Key, byte[] Value)> ExportAsync([EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            await foreach (var (key, value) in Export().ToAsyncEnumerable(cancellationToken))
            {
                if (key.Length > 2 && key[0] == 0x00 && key[1] != 0x00) // not metadata
                {
                    var fullkey = new byte[key.Length + sizeof(long)];
                    key.CopyTo(fullkey, 0);
                    var toend = ulong.MaxValue - (ulong)DateTime.UtcNow.Ticks;
                    BinaryPrimitives.WriteUInt64BigEndian(new Span<byte>(fullkey, fullkey.Length - sizeof(long), sizeof(long)), toend);
                    yield return (fullkey, value);
                }
                else
                    yield return (key, value);
            }
        }
        public async override void ImportAsync(IAsyncEnumerable<(byte[] Key, byte[] Value)> data, CancellationToken cancellationToken = default)
        {
            await foreach (var (key, value) in data.WithCancellation(cancellationToken))
            {
                if (key.Length > 2 && key[0] == 0x00 && key[1] != 0x00) // not metadata
                {
                    var storekey = new byte[key.Length - sizeof(long)];
                    var keyspan = new Span<byte>(key, 0, key.Length - sizeof(long));
                    keyspan.CopyTo(storekey);
                }
                else
                    Bind(key, value);
            }
        }
    }
}
