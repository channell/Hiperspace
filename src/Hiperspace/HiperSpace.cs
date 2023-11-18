using System.IO.Compression;

namespace Hiperspace
{
    public abstract class HiperSpace : IDisposable
    {
        protected bool _disposedValue;

        public delegate void Bound(byte[] key, byte[] value, object? entity);
        /// <summary>
        /// Event to capture Bind Events
        /// </summary>
        public event Bound? OnBind;
        protected void RaiseOnBind (byte[] key, byte[] value, object? entity)
        {
            if (OnBind != null && entity != null) 
                OnBind (key, value, entity);
        }
        public HiperSpace() 
        {
        }

        #region space

        /// <summary>
        /// Bind a key/value pair to the space, passing in the source object, if the driver can use additional metadata (e.g. EFCore)
        /// </summary>
        /// <param name="key">serialised key</param>
        /// <param name="value">serialised value</param>
        /// <param name="source">original object</param>
        /// <returns>a result struct that indicates success, ignore, or fail </returns>
        public abstract Result<byte[]> Bind(byte[] key, byte[] value, object? source = null);
        /// <summary>
        /// Bind a key/value pair to the space, passing in the source object, if the driver can use additional metadata (e.g. EFCore)
        /// </summary>
        /// <param name="key">serialised key</param>
        /// <param name="value">serialised value</param>
        /// <param name="source">original object</param>
        /// <returns>a result struct that indicates success, ignore, or fail </returns>
        public abstract Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, object? source = null);
        /// <summary>
        /// Bind a key/value pair to the space asyncronously, passing in the source object, if the driver can use additional metadata (e.g. EFCore)
        /// </summary>
        /// <param name="key">serialised key</param>
        /// <param name="value">serialised value</param>
        /// <param name="source">original object</param>
        /// <returns>a result struct that indicates success, ignore, or fail </returns>
        public abstract Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, object? source = null);
        /// <summary>
        /// Bind a key/value pair to the space asyncronously, passing in the source object, if the driver can use additional metadata (e.g. EFCore)
        /// </summary>
        /// <param name="key">serialised key</param>
        /// <param name="value">serialised value</param>
        /// <param name="source">original object</param>
        /// <returns>a result struct that indicates success, ignore, or fail </returns>
        public abstract Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source = null);

        /// <summary>
        /// Enumeration of raw values for transfer
        /// </summary>
        /// <returns>content of space</returns>
        public abstract IEnumerable<(byte[] Key, byte[] Value)> Space();
        /// <summary>
        /// Async Enumeration of raw values for transfer
        /// </summary>
        /// <returns>content of space</returns>
        public abstract Task<IEnumerable<(byte[] Key, byte[] Value)>> SpaceAsync();

        /// <summary>
        /// Find all values of space between the key values
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public abstract IEnumerable<(byte[] Key, byte[] Value)> Find(byte[] begin, byte[] end);
        /// <summary>
        /// Find all values of space between the key values
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="version">version stamp or null for latest</param>
        /// <returns></returns>
        public abstract IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version);
        /// <summary>
        /// Find all values of space between the key values asyncronously
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public abstract Task<IEnumerable<(byte[] Key, byte[] Value)>> FindAsync(byte[] begin, byte[] end);
        /// <summary>
        /// Find all values of space between the key values asyncronously
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="version">version stamp or null for latest</param>
        /// <returns></returns>
        public abstract Task<IEnumerable<(byte[] Key,DateTime AsAt, byte[] Value)>> FindAsync(byte[] begin, byte[] end, DateTime? version);

        /// <summary>
        /// Get a single unique value from space
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public abstract byte[] Get(byte[] key);
        /// <summary>
        /// Get a single unique value from space
        /// </summary>
        /// <param name="key"></param>
        /// <param name="version">version stamp or null for latest</param>
        /// <returns></returns>
        public abstract (byte[] Value, DateTime version) Get(byte[] key, DateTime? version);
        /// <summary>
        /// Get a single unique value from space
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public abstract Task<byte[]> GetAsync(byte[] key);
        /// <summary>
        /// Get a single unique value from space
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public abstract Task<(byte[] Value, DateTime version)> GetAsync(byte[] key, DateTime? version);
        /// <summary>
        /// Get the version history for a key item
        /// </summary>
        /// <param name="key"></param>
        /// <param name="version">version stamp or null for latest</param>
        /// <returns></returns>
        public abstract IEnumerable<(byte[] value, DateTime version)> GetVersions(byte[] key);
        /// <summary>
        /// Get the version history for a key item async
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public abstract Task<IEnumerable<(byte[] value, DateTime version)>> GetVersionsAsync(byte[] key);

        /// <summary>
        /// If the space supports transactions, start one to ensure that values and indexes are both stored 
        /// </summary>
        /// <returns></returns>
        public abstract Transaction BeginTransaction();
        /// <summary>
        /// End transaction called from <see cref="Transaction"/> 
        /// </summary>
        /// <returns></returns>
        public abstract void EndTransaction();

        #endregion

        /// <summary>
        /// Transfer the entire content of the space to a zip stream
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="level"></param>
        public void Zip(Stream stream, CompressionLevel level = CompressionLevel.Fastest)
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
        public Task ZipAsync(Stream stream, CompressionLevel level = CompressionLevel.Fastest)
        {
            return Task.Run (() => Zip(stream, level));
        }

        /// <summary>
        /// populate the space with the content of zip stream
        /// </summary>
        /// <param name="stream"></param>
        public void Unzip(Stream stream)
        {
            using (var zip = new GZipStream(stream, CompressionMode.Decompress))
            {
                var lenBuff = new byte[sizeof(int)];
                
                while (zip.Read(lenBuff, 0, 4) == sizeof(int))
                {
                    var len = BitConverter.ToInt32(lenBuff, 0);
                    var key = new byte[len];
                    if (zip.Read(key, 0, len) == len)
                    {
                        if (zip.Read(lenBuff, 0, 4) == sizeof(int))
                        {
                            len = BitConverter.ToInt32(lenBuff, 0);
                            var value = new byte[len];
                            if (zip.Read(value, 0, len) == len)
                            {
                                Bind(key, value, null);
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// populate the space with the content of zip stream async
        /// </summary>
        /// <param name="stream"></param>
        public async Task UnzipAsync(Stream stream)
        {
            using (var zip = new GZipStream(stream, CompressionMode.Decompress))
            {
                var lenBuff = new byte[sizeof(int)];
                if (zip.Read(lenBuff, 0, 4) == sizeof(int))
                {
                    var len = BitConverter.ToInt32(lenBuff, 0);
                    var key = new byte[len];
                    if (await zip.ReadAsync(key, 0, len) == len)
                    {
                        if (zip.Read(lenBuff, 0, 4) == sizeof(int))
                        {
                            len = BitConverter.ToInt32(lenBuff, 0);
                            var value = new byte[len];
                            if (await zip.ReadAsync(value, 0, len) == len)
                            {
                                await BindAsync(key, value, null);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// release all resources
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }

        // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~HiperSpace()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}