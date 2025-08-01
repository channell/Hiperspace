﻿// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Hiperspace.Meta;
using ProtoBuf.Meta;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

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

        /// <summary>
        /// Enable Hiperspace to use ProtoBuf-net.core for serialization win Blazor web assembly
        /// </summary>
        public virtual BaseTypeModel? TypeModel { get; set; }

        #region space

        /// <summary>
        /// Bind a key/value pair to the space, passing in the source object, if the driver can use additional metadata (e.g. EFCore)
        /// </summary>
        /// <param name="key">serialized key</param>
        /// <param name="value">serialized value</param>
        /// <param name="source">original object</param>
        /// <returns>a result struct that indicates success, ignore, or fail </returns>
        public abstract Result<byte[]> Bind(byte[] key, byte[] value, object? source = null);
        /// <summary>
        /// Bind a key/value pair to the space, passing in the source object, if the driver can use additional metadata (e.g. EFCore)
        /// </summary>
        /// <param name="key">serialized key</param>
        /// <param name="value">serialized value</param>
        /// <param name="source">original object</param>
        /// <returns>a result struct that indicates success, ignore, or fail </returns>
        public abstract Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, object? source = null);
        /// <summary>
        /// Bind a key/value pair to the space, passing in the source object, if the driver can use additional metadata (e.g. EFCore)
        /// </summary>
        /// <param name="key">serialized key</param>
        /// <param name="value">serialized value</param>
        /// <param name="source">original object</param>
        /// <returns>a result struct that indicates success, ignore, or fail </returns>
        public abstract Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null);

        /// <summary>
        /// Bind a key/value pair to the space asynchronously, passing in the source object, if the driver can use additional metadata (e.g. EFCore)
        /// including optimistic concurrency control, with a default implementation of lockless concurrency
        /// </summary>
        /// <param name="key">serialized key</param>
        /// <param name="value">serialized value</param>
        /// <param name="source">original object</param>
        /// <returns>a result struct that indicates success, ignore, or fail </returns>
        public abstract Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, object? source = null);
        /// <summary>
        /// Bind a key/value pair to the space asynchronously, passing in the source object, if the driver can use additional metadata (e.g. EFCore)
        /// </summary>
        /// <param name="key">serialized key</param>
        /// <param name="value">serialized value</param>
        /// <param name="source">original object</param>
        /// <returns>a result struct that indicates success, ignore, or fail </returns>
        public abstract Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source = null);

        /// <summary>
        /// Bind a key/value pair to the space asynchronously, passing in the source object, if the driver can use additional metadata (e.g. EFCore)
        /// including optimistic concurrency control, with a default implementation of lockless concurrency
        /// </summary>
        /// <param name="key">serialized key</param>
        /// <param name="value">serialized value</param>
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
            var result = new Result<(byte[] Key, byte[] Value)>[batch.Length];

            for (int c = 0; c < batch.Length; c++)
            {
                var value = await BindAsync(batch[c].key, batch[c].value, batch[c].source);
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
        /// Bind a batch of values for server single trip async
        /// </summary>
        /// <param name="batch">array of request</param>
        /// <returns>array of results</returns>
        public virtual async Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, DateTime version, object? source)[] batch)
        {
            var result = new Result<(byte[] Key, byte[] Value)>[batch.Length];

            for (int c = 0; c < batch.Length; c++)
            {
                var value = await BindAsync(batch[c].key, batch[c].value, batch[c].version, batch[c].source);
                result[c] = value.Status switch
                {
                    Result.Status.Ok => Result.Ok((batch[c].key, value.Value)),
                    Result.Status.Skip => Result.Skip((batch[c].key, value.Value)),
                    _ => Result.Fail((batch[c].key, value.Value), value.Reason)
                };
            }
            return result;
        }
        public virtual async Task<Result<(byte[] Key, byte[] Value)>[]> BatchBindAsync((byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)
        {
            var result = new Result<(byte[] Key, byte[] Value)>[batch.Length];

            for (int c = 0; c < batch.Length; c++)
            {
                var value = await BindAsync(batch[c].key, batch[c].value, batch[c].version, batch[c].priorVersion, batch[c].source);
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
        /// Find all values of space between the key values asynchronously
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public abstract IAsyncEnumerable<(byte[] Key, byte[] Value)> FindAsync(byte[] begin, byte[] end, CancellationToken cancellationToken = default);
        /// <summary>
        /// Find all values of space between the key values asynchronously
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="version">version stamp or null for latest</param>
        /// <returns></returns>
        public abstract IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindAsync(byte[] begin, byte[] end, DateTime? version, CancellationToken cancellationToken = default);
        /// <summary>
        /// Find keys in a delta index that are greater than the value provided
        /// </summary>
        /// <param name="key">the start value for delta search </param>
        /// <param name="version">version stamp or null for latest</param>
        /// <returns></returns>
        public abstract IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Delta(byte[] key, DateTime? version);

        /// <summary>
        /// Find keys in a delta index that are greater than the value provided asynchronously
        /// </summary>
        /// <param name="key">the start value for delta search </param>
        /// <param name="end"></param>
        /// <returns></returns>
        public virtual IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> DeltaAsync(byte[] begin, DateTime? version, CancellationToken cancellationToken = default)
        {
            return Delta(begin, version).ToAsyncEnumerable(cancellationToken);  
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
        /// Find all values of space for index values between the index values
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="version">version stamp or null for latest</param>
        /// <returns></returns>
        public virtual IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindDeltaAsync(byte[] begin, DateTime? version, DateTime? DeltaFrom, CancellationToken cancellationToken = default)
        {
            return FindDelta(begin, version, DeltaFrom).ToAsyncEnumerable();
        }
        /// <summary>
        /// Find all values of space for index values between the index values asynchronously
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public virtual IAsyncEnumerable<(byte[] Key, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, CancellationToken cancellationToken = default)
        {
            return FindIndex (begin, end).ToAsyncEnumerable(cancellationToken);
        }
        /// <summary>
        /// Find all values of space for index values between the index values asynchronously
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="version">version stamp or null for latest</param>
        /// <returns></returns>
        public virtual IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, DateTime? version, CancellationToken cancellationToken = default)
        {
            return FindIndex(begin, end, version).ToAsyncEnumerable(cancellationToken);
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
        /// Find all values of space for index values between the index values asynchronously
        /// </summary>
        /// <param name="key"></param>
        /// <param name="vector"></param>
        /// <param name="limit">limit to the top results, or zero for all</param>
        /// <param name="version">datestamp of key</param>
        /// <returns></returns>
        public virtual IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> NearestAsync(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0, CancellationToken cancellationToken = default)
        {
            return Nearest(begin, end, version, space, method, limit).ToAsyncEnumerable(cancellationToken);
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
        public abstract IAsyncEnumerable<(byte[] value, DateTime version)> GetVersionsAsync(byte[] key, CancellationToken cancellationToken = default);
        /// <summary>
        /// Default implementation to get the first item from a setspace
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public virtual (byte[] Key, byte[] Value)? GetFirst(byte[] begin, byte[] end)
        {
            return Find(begin, end).FirstOrDefault();
        }
        /// <summary>
        /// Get the first item asynchronously. 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public virtual Task<(byte[] Key, byte[] Value)?> GetFirstAsync(byte[] begin, byte[] end)
        {
            return Task.Run(() => GetFirst(begin, end));
        }
        /// <summary>
        /// Get the last item from a set space. 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public virtual (byte[] Key, byte[] Value)? GetLast(byte[] begin, byte[] end)
        {
            return Find(begin, end).LastOrDefault();
        }
        /// <summary>
        /// Get the last item asynchronously.   
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public virtual Task<(byte[] Key, byte[] Value)?> GetLastAsync(byte[] begin, byte[] end)
        {
            return Task.Run(() => GetLast(begin, end));
        }
        /// <summary>
        /// Get the first item that is before the specified version date. 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public virtual (byte[] Key, DateTime AsAt, byte[] Value)? GetFirst(byte[] begin, byte[] end, DateTime? version)
        {
            return Find(begin, end, version).FirstOrDefault();
        }
        /// <summary>
        /// Get the first version item asynchronously. 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public virtual Task<(byte[] Key, DateTime AsAt, byte[] Value)?> GetFirstAsync(byte[] begin, byte[] end, DateTime? version)
        {
            return Task.Run(() => GetFirst(begin, end, version));
        }
        /// <summary>
        /// Get the last item that matches that's on or before the specified version date.
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public virtual (byte[] Key, DateTime AsAt, byte[] Value)? GetLast(byte[] begin, byte[] end, DateTime? version)
        {
            return Find(begin, end, version).LastOrDefault();
        }
        /// <summary>
        /// Get the last version asynchronously. 
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public virtual Task<(byte[] Key, DateTime AsAt, byte[] Value)?> GetLastAsync(byte[] begin, byte[] end, DateTime? version)
        {
            return Task.Run(() => GetLast(begin, end, version));
        }

        /// <summary>
        /// GPU Accelerated Get a set of value from space for the collection of keys
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public virtual IEnumerable<(byte[] key, byte[] value)> GetMany(IEnumerable<byte[]> keys)
        {
            foreach (var key in keys)
            {
                yield return (key, Get(key));
            }
        }
        /// <summary>
        /// GPU Accelerated Get a set of value from space for the collection of keys
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="version">version stamp or null for latest</param>
        /// <returns></returns>
        public virtual IEnumerable<(byte[] key, byte[] Value, DateTime version)> GetMany(IEnumerable<byte[]> keys, DateTime? version)
        {
            foreach (var key in keys)
            {
                var value = Get(key, version);
                yield return (key, value.Value, value.version);
            }
        }
        /// <summary>
        /// GPU Accelerated Get a set of value from space for the collection of keys asynchronously
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public virtual async IAsyncEnumerable<(byte[] key, byte[] value)> GetManyAsync(IAsyncEnumerable<byte[]> keys, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            await foreach (var key in keys)
            {
                if (cancellationToken.IsCancellationRequested)
                    yield break;
                yield return (key, await GetAsync(key));
            }
        }
        /// <summary>
        /// GPU Accelerated Get a set of value from space for the collection of keys asynchronously
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public virtual async IAsyncEnumerable<(byte[] key, byte[] Value, DateTime version)> GetManyAsync(IAsyncEnumerable<byte[]> keys, DateTime? version, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            await foreach (var key in keys)
            {
                if (cancellationToken.IsCancellationRequested)
                    yield break;
                var value = await GetAsync(key, version);
                yield return (key, value.Value, value.version);
            }
        }

        /// <summary>
        /// GPU Accelerated Scan for matching values, with default implementation of non-optimized scan
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="values">an array of values (that are byte[] values) </param>
        /// <returns></returns>
        public virtual IEnumerable<(byte[] Key, byte[] Value)> Scan(byte[] begin, byte[] end, byte[][] values)
        {
            return Find(begin, end);
        }
        /// <summary>
        /// GPU Accelerated Scan for matching versioned values, with default implementation of non-optimized scan
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="values">an array of values (that are byte[] values) </param>
        /// <returns></returns>
        public virtual IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Scan(byte[] begin, byte[] end, byte[][] values, DateTime? version)
        {
            return Find(begin, end, version);
        }
        /// <summary>
        /// GPU Accelerated async Scan for matching values, with default implementation of non-optimized scan
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="values">an array of values (that are byte[] values) </param>
        /// <returns></returns>
        public virtual IAsyncEnumerable<(byte[] Key, byte[] Value)> ScanAsync(byte[] begin, byte[] end, byte[][] values, CancellationToken cancellationToken = default)
        {
            return FindAsync(begin, end, cancellationToken);
        }
        /// <summary>
        /// GPU Accelerated async Scan for matching versioned values, with default implementation of non-optimized scan
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <param name="values">an array of values (that are byte[] values) </param>
        /// <returns></returns>
        public virtual IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> ScanAsync(byte[] begin, byte[] end, byte[][] values, DateTime? version, CancellationToken cancellationToken = default)
        {
            return FindAsync(begin, end, version, cancellationToken);
        }
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
                foreach (var r in ExportAsync().ToBlockingEnumerable())
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
        public async Task ZipAsync(Stream stream, CompressionLevel level = CompressionLevel.Fastest)
        {
            using (var zip = new GZipStream(stream, level))
            {
                await foreach (var r in ExportAsync())
                {
                    zip.Write(BitConverter.GetBytes(r.Item1.Length));
                    zip.Write(r.Item1);
                    zip.Write(BitConverter.GetBytes(r.Item2.Length));
                    zip.Write(r.Item2);
                }
            }
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
        /// Export contents of Hiperspace, for SessionSpace without temp ZipStream
        /// </summary>
        /// <remarks>
        /// virtual will be replaced with abstract when Space() is removed
        /// </remarks>
        public abstract IAsyncEnumerable<(byte[] Key, byte[] Value)> ExportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Import into Hiperspace, for SessionSpace without temp ZipStream
        /// </summary>
        public abstract void ImportAsync(IAsyncEnumerable<(byte[] Key, byte[] Value)> values, CancellationToken cancellationToken = default);

        /// <summary>
        /// release all resources
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            _disposedValue = true;
        }

        ~HiperSpace()
        {
            Dispose(disposing: true);
        }

        public void Dispose()
        {
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

        /// <summary>
        /// Get the metamodel currently stored in a durable space
        /// </summary>
        /// <returns></returns>
        public abstract MetaModel? GetMetaModel();

        /// <summary>
        /// Get the metamodel currently stored in a durable space asyncronously
        /// </summary>
        /// <returns></returns>
        public abstract Task<MetaModel?> GetMetaModelAsync();

        /// <summary>
        /// Set the meta model of the space if the store is durable
        /// </summary>
        /// <param name="metaModel">meta model of the subspace assembly</param>
        /// <returns>success</returns>
        public abstract bool SetMetaModel(MetaModel metaModel);
        /// <summary>
        /// Set the meta model of the space if the store is durable asyncronously
        /// </summary>
        /// <param name="metaModel">meta model of the subspace assembly</param>
        /// <returns>success</returns>
        public abstract Task<bool> SetMetaModelAsync(MetaModel metaModel);

        /// <summary>
        /// Apply the metamodel from the assembly to the hiperspace
        /// </summary>
        /// <param name="metaModel">meta model of the subspace assembly</param>
        /// <param name="merge">true if the current model should be merged into the historical model in the store</param>
        /// <returns>sucess</returns>
        public (bool success, MetaModel model) ApplyMetaModel(MetaModel metaModel)
        {
            var current = GetMetaModel();
            if (current == null)
            {
                return (SetMetaModel(metaModel), metaModel);
            }
            else
            {
                return ApplyMetaModel(metaModel, current);
            }
        }
        public (bool success, MetaModel model) ApplyMetaModel(MetaModel metaModel, MetaModel current)
        {
            // new hiperspace
            if (current == null)
            {
                return (SetMetaModel(metaModel), metaModel);
            }
            else
            {
                // is it an incompatible metamodel, due to type redefinition
                if (!metaModel.Equals(current))
                {
                    return (false, current);
                }
                // changed model
                if (current.GetHashCode() != metaModel.GetHashCode())
                {
                    // merge legacy elements
                    metaModel.Merge(current);
                    return (SetMetaModel(metaModel), metaModel);
                }
                else
                    return (true, metaModel);
            }
        }
        /// <summary>
        /// Apply the metamodel from the assembly to the hiperspace
        /// </summary>
        /// <param name="metaModel">meta model of the subspace assembly</param>
        /// <param name="merge">true if the current model should be merged into the historical model in the store</param>
        /// <returns>sucess</returns>
        public async Task<(bool success, MetaModel model)> ApplyMetaModelAsync(MetaModel metaModel)
        {
            var current = GetMetaModel();
            if (current == null)
            {
                return (await SetMetaModelAsync(metaModel), metaModel);
            }
            else
            {
                return await ApplyMetaModelAsync(metaModel, current);
            }
        }
        public async Task<(bool success, MetaModel model)> ApplyMetaModelAsync(MetaModel metaModel, MetaModel current)
        {
            // new hiperspace
            if (current == null)
            {
                return (await SetMetaModelAsync(metaModel), metaModel);
            }
            else
            {
                // is it an incompatible metamodel, due to type redefinition
                if (!current.Equals(metaModel))
                {
                    return (false, metaModel);
                }
                // changed model
                if (current.GetHashCode() != metaModel.GetHashCode())
                {
                    // merge legacy elements
                    metaModel.Merge(current);
                    return (await SetMetaModelAsync(metaModel), metaModel);
                }
                else
                    return (true, metaModel);
            }
        }
    }
}