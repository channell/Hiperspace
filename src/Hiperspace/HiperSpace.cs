// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.IO.Compression;

namespace Hiperspace
{
    public abstract class HiperSpace : IDisposable
    {
        protected bool _disposedValue;

        public delegate void Bound(byte[] key, byte[] value, object? entity);
        public delegate void BeforeGet(ref byte[] key);
        public delegate void AfterGet(ref byte[] key, ref byte[] value);
        public delegate void BeforeFind(ref byte[] begin, ref byte[] end);
        public delegate void AfterFind(ref byte[] begin, ref byte[] end);
        /// <summary>
        /// Event to capture Bind Events
        /// </summary>
        public event Bound? OnBind;
        public event BeforeGet? OnBeforeGet;
        public event AfterGet? OnAfterGet;
        public event BeforeFind? OnBeforeFind;
        public event AfterFind? OnAfterFind;
        protected void RaiseOnBind(byte[] key, byte[] value, object? entity)
        {
            if (OnBind != null && entity != null)
                OnBind(key, value, entity);
        }
        protected void RaiseOnBeforeGet(ref byte[] key)
        {
            if (OnBeforeGet != null)
                OnBeforeGet(ref key);
        }
        protected void RaiseOnAfterGet(ref byte[] key, ref byte[] value)
        {
            if (OnAfterGet != null)
                OnAfterGet(ref key, ref value);
        }
        protected void RaiseOnBeforeFind(ref byte[] key, ref byte[] value)
        {
            if (OnBeforeFind != null)
                OnBeforeFind(ref key, ref value);
        }
        protected void RaiseOnAfterFind(ref byte[] key, ref byte[] value)
        {
            if (OnAfterFind != null)
                OnAfterFind(ref key, ref value);
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
        /// Bind a key/value pair to the space, passing in the source object, if the driver can use additional metadata (e.g. EFCore)
        /// </summary>
        /// <param name="key">serialised key</param>
        /// <param name="value">serialised value</param>
        /// <param name="source">original object</param>
        /// <returns>a result struct that indicates success, ignore, or fail </returns>
        public virtual Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            return Bind(key, value, version, source);
        }
        /// <summary>
        /// Bind a key/value pair to the space asyncronously, passing in the source object, if the driver can use additional metadata (e.g. EFCore)
        /// including optimistic concurrency control, with a default implementation of lockless concurrency
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
        /// Bind a key/value pair to the space asyncronously, passing in the source object, if the driver can use additional metadata (e.g. EFCore)
        /// including optimistic concurrency control, with a default implementation of lockless concurrency
        /// </summary>
        /// <param name="key">serialised key</param>
        /// <param name="value">serialised value</param>
        /// <param name="source">original object</param>
        /// <returns>a result struct that indicates success, ignore, or fail </returns>
        public virtual Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            return BindAsync(key, value, version, source);
        }

        /// <summary>
        /// Bind a batch of values for server single trip
        /// </summary>
        /// <param name="batch">array of request</param>
        /// <returns>array of results</returns>
        public virtual Result<(byte[] Key, byte[] Value)>[] BatchBind((byte[] key, byte[] value, object? source)[] batch)
        {
            var result = new Result<(byte[] Key, byte[] Value)>[batch.Length];

            for (int c = 0; c < batch.Length; c++)
            {
                var value = Bind(batch[c].key, batch[c].value, batch[c].source);
                result[c] = value.Status switch
                {
                    Result.Status.Ok => Result.Ok((batch[c].key, value.Value)),
                    Result.Status.Skip => Result.Skip((batch[c].key, value.Value)),
                    _ => Result.Fail((batch[c].key, value.Value), value.Reason)
                };
                // do not apply index updates if the main value has failed
                if (value.Status == Result.Status.Fail) 
                    return result;
            }
            return result;
        }
        /// <summary>
        /// Bind a batch of values for server single trip
        /// </summary>
        /// <param name="batch">array of request</param>
        /// <returns>array of results</returns>
        public virtual Result<(byte[] Key, byte[] Value)>[] BatchBind((byte[] key, byte[] value, DateTime version, object? source)[] batch)
        {
            var result = new Result<(byte[] Key, byte[] Value)>[batch.Length];

            for (int c = 0; c < batch.Length; c++)
            {
                var value = Bind(batch[c].key, batch[c].value, batch[c].version, batch[c].source);
                result[c] = value.Status switch
                {
                    Result.Status.Ok => Result.Ok((batch[c].key, value.Value)),
                    Result.Status.Skip => Result.Skip((batch[c].key, value.Value)),
                    _ => Result.Fail((batch[c].key, value.Value), value.Reason)
                };
            }
            return result;
        }
        /// <summary>
        /// Bind a batch of values for server single trip
        /// </summary>
        /// <param name="batch">array of request</param>
        /// <returns>array of results</returns>
        public virtual Result<(byte[] Key, byte[] Value)>[] BatchBind((byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)
        {
            var result = new Result<(byte[] Key, byte[] Value)>[batch.Length];

            for (int c = 0; c < batch.Length; c++)
            {
                var value = Bind(batch[c].key, batch[c].value, batch[c].version, batch[c].priorVersion, batch[c].source);
                result[c] = value.Status switch
                {
                    Result.Status.Ok => Result.Ok((batch[c].key, value.Value)),
                    Result.Status.Skip => Result.Skip((batch[c].key, value.Value)),
                    _ => Result.Fail((batch[c].key, value.Value), value.Reason)
                };
            }
            return result;
        }

        /// <summary>
        /// Bind a batch of values for server single trip async
        /// </summary>
        /// <param name="batch">array of request</param>
        /// <returns>array of results</returns>
        public virtual async Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, object? source)[] batch)
        {
            return await Task.Run(() => BatchBind(batch));
        }

        /// <summary>
        /// Bind a batch of values for server single trip async
        /// </summary>
        /// <param name="batch">array of request</param>
        /// <returns>array of results</returns>
        public virtual async Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, DateTime version, object? source)[] batch)
        {
            return await Task.Run(() => BatchBind(batch));
        }
        public virtual async Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)
        {
            return await Task.Run(() => BatchBind(batch));
        }

        /// <summary>
        /// Enumeration of raw values for transfer
        /// </summary>
        /// <remarks>will be protected in a future release</remarks>
        /// <returns>content of space</returns>
        public abstract IEnumerable<(byte[] Key, byte[] Value)> Space();
        /// <summary>
        /// Async Enumeration of raw values for transfer
        /// </summary>
        /// <remarks>will be protected in a future release</remarks>
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
        public abstract Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>> FindAsync(byte[] begin, byte[] end, DateTime? version);

        /// <summary>
        /// Find keys in a delta index that are greater than the value provided
        /// </summary>
        /// <param name="key">the start value for delta search </param>
        /// <param name="version">version stamp or null for latest</param>
        /// <returns></returns>
        public abstract IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Delta(byte[] key, DateTime? version);

        /// <summary>
        /// Find keys in a delta index that are greater than the value provided asyncronously
        /// </summary>
        /// <param name="key">the start value for delta search </param>
        /// <param name="end"></param>
        /// <returns></returns>
        public Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>> DeltaAsync(byte[] begin, DateTime? version)
        {
            return Task.Run(() => Delta(begin, version));  
        }

        /// <summary>
        /// Find all values of space for index values between the index values
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="entityId">the proto id of key field</param>
        /// <returns></returns>
        public virtual IEnumerable<(byte[] Key, byte[] Value)> FindIndex(byte[] begin, byte[] end)
        {
            foreach (var inx in Find(begin, end))
            {
                var value = Get(inx.Value);
                yield return (inx.Value, value);
            }
        }

        /// <summary>
        /// Find all values of space for index values between the index values
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="version">version stamp or null for latest</param>
        /// <returns></returns>
        public virtual IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndex(byte[] begin, byte[] end, DateTime? version)
        {
            foreach (var inx in Find(begin, end, version))
            {
                var value = Get(inx.Value, version);
                yield return (inx.Value, value.version, value.Value);
            }
        }
        /// <summary>
        /// Find all values of space for index values between the index values
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="version">version stamp or null for latest</param>
        /// <returns></returns>
        public virtual IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindDelta(byte[] begin, DateTime? version, DateTime? DeltaFrom)
        {
            foreach (var inx in Delta(begin, DeltaFrom))
            {
                var value = Get(inx.Value, version);
                yield return (inx.Value, value.version, value.Value);
            }
        }
        /// <summary>
        /// Find all values of space for index values between the index values asyncronously
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public virtual Task<IEnumerable<(byte[] Key, byte[] Value)>> FindIndexAsync(byte[] begin, byte[] end)
        {
            return Task.Run(() => FindIndex (begin, end));
        }
        /// <summary>
        /// Find all values of space for index values between the index values asyncronously
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="version">version stamp or null for latest</param>
        /// <returns></returns>
        public virtual Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>> FindIndexAsync(byte[] begin, byte[] end, DateTime? version)
        {
            return Task.Run(() => FindIndex(begin, end, version));
        }

        /// <summary>
        /// Find all values of space for similarity match for AI queries
        /// </summary>
        /// <param name="key"></param>
        /// <param name="vector"></param>
        /// <param name="version">datestamp of key</param>
        /// <param name="limit">limit to the top results, or zero for all</param>
        /// <returns></returns>
        public virtual IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> Nearest(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0)
        {
            throw new NotImplementedException("This HiperSpace does not support Vector Search");
        }
        /// <summary>
        /// Find all values of space for index values between the index values asyncronously
        /// </summary>
        /// <param name="key"></param>
        /// <param name="vector"></param>
        /// <param name="limit">limit to the top results, or zero for all</param>
        /// <param name="version">datestamp of key</param>
        /// <returns></returns>
        public virtual Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)>> NearestAsync(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0)
        {
            return Task.Run(() => Nearest(begin, end, version, space, method, limit));
        }

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

        /// <summary>
        /// Get the horizons for the space, and every space that it uses.
        /// This is useful for domain SubSpaces that are opened with a SessionSpace that batched updates to 
        /// an underlying domain SubSpace
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<Horizon> GetHorizons()
        {
            return Enumerable.Empty<Horizon>();
        }
    }
}