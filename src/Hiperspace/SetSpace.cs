// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Hiperspace
{
    public abstract class SetSpace<TEntity> : ISet<TEntity>, IOrderedQueryable<TEntity>, IEnumerable<TEntity>, ISetSpace
        where TEntity : Element<TEntity>, new()
    {
        public readonly ConcurrentHashSet<TEntity> Cached = new ConcurrentHashSet<TEntity>();

        public delegate void Bound(TEntity entity);
        public delegate void Dependency((TEntity target, Meta.DependencyPath sender) value);
        public delegate void Missing (TEntity entity);
        /// <summary>
        /// Event to capture Bind Events
        /// </summary>
        public event Bound? OnBind;
        public event Dependency? OnDependency;
        /// <summary>
        /// Occurs when a required item is missing in Hiperspace, trigger alternate source
        /// </summary>
        public event Missing? OnMissing;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected void RaiseOnbind(TEntity entity)
        {
            OnBind?.Invoke(entity);
            OnDependency?.Invoke((entity, new Meta.DependencyPath(entity)));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RaiseOnDependency((TEntity target, Meta.DependencyPath sender) value)
        {
            OnDependency?.Invoke((value.target, value.sender));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RaiseOnMissing(TEntity target)
        {
            OnMissing?.Invoke(target);
        }

        public void ForwardEventsFrom(SetSpace<TEntity> source)
        {
            if (OnBind is not null) source.OnBind += RaiseOnbind;
            if (OnDependency is not null) source.OnDependency += RaiseOnDependency;
        }

        private Horizon<TEntity>[]? _horizons;
        protected Horizon<TEntity>[]? Horizons
        {             
            get
            {
                if (_horizons is null)
                {
                    _horizons = Space?.Horizon?
                        .Where(h => h.Type == typeof(TEntity))
                        .Select(i => ((Horizon<TEntity>)i))
                        .ToArray();
                }
                return _horizons;
            }
        }
        public SubSpace Space { get; set; }
        public SetSpace(SubSpace space, IQueryProvider provider)
        {
            Space = space;
            Provider = provider ?? throw new ArgumentNullException(nameof(provider));
        }
        protected SpinLock _lock = new SpinLock();

        public virtual Result<TEntity> Bind(TEntity item, bool cache = true, bool read = false)
        {
            var filtered = Filter(item, read);
            if (filtered.Fail)
                return filtered;

            TEntity? res;
            if (Cached.TryGetValue(item, out res))
            {
                return Result.Skip(res);
            }
            if (cache)
            {
                Cached.Add(item);
            }
            return Result.Ok(item);
        }
        public Result<TEntity> BatchBind(TEntity item, bool cache, (byte[] key, byte[] value, object? source)[] batch)
        {
            var result = Space.BatchBind(batch);
            if (result.Any(b => b.Fail))
                return Result.Fail(item);
            else
            {
                if (cache)
                {
                    Cached.Replace(item);
                }
                RaiseOnbind(item);
                return Result.Ok(item);
            }
        }

        public bool Add(TEntity item)
        {
            return Bind(item, true, false).New;
        }

        public async Task<bool> AddAsync(TEntity item)
        {
            var result = await BindAsync(item, true, false);
            return result.New;
        }

        public bool Insert(TEntity item)
        {
            var current = Get(item);
            if (current is not null)
            {
                if (item.GetType().GetCustomAttribute<VersionedAttribute>() is not null)
                    throw new MutationException($"Cannot insert a new {item.GetType().Name}, use Update(item) instead");
                else
                    throw new MutationException($"Cannot insert a new {item.GetType().Name}, value already exists");
            }
            return Bind(item, true, false).Ok;
        }
        public async Task<bool> InsertAsync(TEntity item)
        {
            var current = await GetAsync(item);
            if (current is not null)
            {
                if (item.GetType().GetCustomAttribute<VersionedAttribute>() is not null)
                    throw new MutationException($"Cannot insert a new {item.GetType().Name}, use Update(item) instead");
                else
                    throw new MutationException($"Cannot insert a new {item.GetType().Name}, value already exists");
            }
            return (Bind(item, true)).Ok;
        }
        public bool Update(TEntity item)
        {
            var current = Get(item);
            if (current is null)
                throw new MutationException($"Cannot update a {item.GetType().Name}, use Add(item) if an existing value is not needed");
            return Bind(item, true, false).Ok;
        }
        public async Task<bool> UpdateAsync(TEntity item)
        {
            var current = await GetAsync(item);
            if (current is null)
                throw new MutationException($"Cannot update a {item.GetType().Name}, use Add(item) if an existing value is not needed");
            return (Bind(item, true)).Ok;
        }
        public bool Delete(TEntity item)
        {
            var current = Get(item);
            if (current is null)
            {
                if (item.GetType().GetCustomAttribute<VersionedAttribute>() is not null)
                {
                    item.GetType().GetProperty("Deleted")?.SetValue(item, true);
                    return Bind(item, true, false).Ok;
                }
                else
                    throw new MutationException($"Cannot insert a new deleted {item.GetType().Name}, value already exists");
            }
            throw new MutationException($"Cannot delete {item.GetType().Name}, a value was not found");
        }
        public async Task<bool> DeleteAsync(TEntity item)
        {
            var current = await GetAsync(item);
            if (current is null)
            {
                if (item.GetType().GetCustomAttribute<VersionedAttribute>() is not null)
                {
                    item.GetType().GetProperty("Deleted")?.SetValue(item, true);
                    return (Bind(item, true)).Ok;
                }
                else
                    throw new MutationException($"Cannot insert a new deleted {item.GetType().Name}, value already exists");
            }
            throw new MutationException($"Cannot delete {item.GetType().Name}, a value was not found");
        }

        public bool TryGetValue(TEntity equalValue, out TEntity actualValue)
        {
            return Cached.TryGetValue(equalValue, out actualValue!);
        }

        #region entity functions
        public abstract TEntity? Get(TEntity template);
        public abstract Task<TEntity?> GetAsync(TEntity template);
        public abstract Task<Result<TEntity>> BindAsync(TEntity item, bool cache = true, bool read = false);

        public abstract void UnionWith(IEnumerable<TEntity> other);

        /// <summary>
        /// Does the template contain part of the key that can be used for used as a find a subset of elements
        /// either by the key or an index
        /// </summary>
        /// <param name="template"></param>
        /// <returns></returns>
        public abstract bool IsSargable(TEntity template);

        /// <summary>
        /// Would the set return no elements for the template Node provided
        /// </summary>
        /// <param name="node">node pattern provided</param>
        /// <returns>true if it can be skipped</returns>
        /// <remarks>
        /// If the Element provides the Node view TypeName = "Person" (static value), 
        /// any template with a different value with return no elements 
        /// </remarks>
        public virtual bool IsSkippable(object template) => false;

        public abstract IEnumerable<TEntity> Find(TEntity template, bool cache = true);

        public abstract IAsyncEnumerable<TEntity> FindAsync(TEntity template, bool cache = true, CancellationToken cancellationToken = default);

        /// <summary>
        /// Provides an interface for queries like customers.Query("customer.id IN (SELECT id FROM contact WHERE status = 'OPEN') AND valid IS NOT NULL")
        /// </summary>
        /// <param name="SQLWhere">Just there WHERE clause (SELECT * FROM customers) is added</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual IEnumerable<TEntity> Query(string SQL, bool cache = true)
        {
            throw new NotImplementedException("This SubSpace does not support SQL queries");
        }

        /// <summary>
        /// Provides an interface for queries like await customers.QueryAsync("customer.id IN (SELECT id FROM contact WHERE status = 'OPEN') AND valid IS NOT NULL")
        /// </summary>
        /// <param name="SQLWhere">Just there WHERE clause (SELECT * FROM customers) is added</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public virtual IAsyncEnumerable<TEntity> QueryAsync(string SQL, bool cache = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException("This SubSpace does not support SQL queries");
        }

        public abstract IEnumerable<(TEntity Item, double Distance)> Nearest(TEntity template, Vector space, Vector.Method method, int limit = 0, bool cache = true);

        public abstract IAsyncEnumerable<(TEntity Item, double Distance)> NearestAsync(TEntity template, Vector space, Vector.Method method, int limit = 0, bool cache = true, CancellationToken cancellation = default);

        public IEnumerable<TEntity> Filter(IEnumerable<TEntity> entities, bool read = true)
        {
            var horizons = Horizons;
            if (horizons is not null)
                return entities
                    .Where(e =>
                    {
                        if (Filter(e, read).Fail)
                        {
                            Cached.Remove(e);
                            return false;
                        }
                        else
                            return true;
                    });
            return entities;
        }
        public IEnumerable<(TEntity Item, double Distance)> Filter(IEnumerable<(TEntity Item, double Distance)> entities, bool read = true)
        {
            var horizons = Horizons;
            if (horizons is not null)
                return entities
                    .Where(e =>
                    {
                        for (int c = 0; c < horizons.Length; c++)
                        {
                            var horizon = horizons[c];
                            if (horizon.predicate is not null && !horizon.predicate(e.Item, Space?.ContextLabel, Space?.UserLabel, read))
                                return false;
                        }
                        return true;
                    });
            return entities;
        }
        public virtual Result<TEntity> Filter(TEntity entity, bool read = true)
        {
            var horizons = Horizons;
            if (horizons is not null)
            {
                for (int c = 0; c < horizons.Length; c++)
                {
                    var horizon = horizons[c];
                    if (horizon.predicate is not null && !horizon.predicate(entity, Space?.ContextLabel, Space?.UserLabel, read))
                    {
                        return Result.Fail(entity, horizons[c].Reason);
                    }
                }
            }
            return Result.Ok(entity);
        }
        #endregion
        #region key functions
        public abstract TEntity? Get<TKey>(ref TKey key, bool useAlternate = true);
        /// <remarks>
        /// Will ve replaced with abstracvt in a future release
        /// </remarks>
        public virtual Task<TEntity?> GetAsync<TKey>(TKey key, bool useAlternate = true)
        {
            return Task.FromResult(Get(ref key));
        }

        #endregion
        #region queryable
        public IEnumerator<TEntity> GetEnumerator()
        {
            foreach (var item in Find(new TEntity()))
            {
                yield return item;
            }
        }

        public void ExceptWith(IEnumerable<TEntity> other)
        {
            Cached.ExceptWith(other);
        }

        public void IntersectWith(IEnumerable<TEntity> other)
        {
            Cached.IntersectWith(other);
        }

        public bool IsProperSubsetOf(IEnumerable<TEntity> other)
        {
            return Cached.IsProperSubsetOf(other);
        }

        public bool IsProperSupersetOf(IEnumerable<TEntity> other)
        {
            return Cached.IsProperSupersetOf(other);
        }

        public bool IsSubsetOf(IEnumerable<TEntity> other)
        {
            return Cached.IsSubsetOf(other);
        }

        public bool IsSupersetOf(IEnumerable<TEntity> other)
        {
            return Cached.IsSupersetOf(other);
        }

        public bool Overlaps(IEnumerable<TEntity> other)
        {
            return Cached.Overlaps(other);
        }

        public bool SetEquals(IEnumerable<TEntity> other)
        {
            return Cached.SetEquals(other);
        }

        public void SymmetricExceptWith(IEnumerable<TEntity> other)
        {
            Cached.SymmetricExceptWith(other);
        }

        void ICollection<TEntity>.Add(TEntity item)
        {
            Cached.Add(item);
        }

        public void Clear()
        {
            Cached.Clear();
        }

        public bool Contains(TEntity item)
        {
            return Cached.Contains(item);
        }

        public void CopyTo(TEntity[] array, int arrayIndex)
        {
            Cached.CopyTo(array, arrayIndex);
        }

        public bool Remove(TEntity item)
        {
            return Cached.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in Find(new TEntity()))
            {
                yield return item;
            }
        }
        class Async : IAsyncEnumerable<TEntity>
        {
            private Func<IAsyncEnumerable<TEntity>> _source;
            public Async(Func<IAsyncEnumerable<TEntity>> source)
            {
                _source = source;
            }
            public async IAsyncEnumerator<TEntity> GetAsyncEnumerator(CancellationToken cancellationToken = default)
            {
                await foreach (var item in _source())
                {
                    if (cancellationToken.IsCancellationRequested)
                        yield break;
                    yield return item;
                }
            }
        }
        public IAsyncEnumerable<TEntity> AsAsyncEnumerable(CancellationToken cancellationToken)
        {
            return new Async(() => FindAsync(new TEntity(), true, cancellationToken));
        }

        public static Expression<Predicate<TEntity>> True = f => true;

        public Type ElementType => typeof(TEntity);

        public Expression Expression => Expression.Constant(this);

        public IQueryProvider Provider { get; set; } // => new Query<TEntity>(this, null);

        public int Count => Cached.Count;

        public bool IsReadOnly => false;

        public IQueryable Runnable() => Find(new TEntity { }).AsQueryable();

        public virtual TEntity? GetFirst(TEntity? template = null)
        {
            if (template is null)
                template = new TEntity();
            return Find(template).FirstOrDefault();
        }
        public virtual async Task<TEntity?> GetFirstAsync(TEntity? template = null)
        {
            if (template is null)
                template = new TEntity();
            var result = FindAsync(template).GetAsyncEnumerator();
            if (await result.MoveNextAsync())
            {
                return result.Current;
            }
            return null;
        }
        public virtual TEntity? GetLast(TEntity? template = null)
        {
            if (template is null)
                template = new TEntity();
            return Find(new TEntity()).LastOrDefault();
        }
        public virtual async Task<TEntity?> GetLastAsync(TEntity? template = null)
        {
            if (template is null)
                template = new TEntity();
            TEntity? result = null;
            await foreach (var item in FindAsync(template, true))
            {
                result = item;
            }
            return result;
        }

        public ISetQuery SetQuery()
        {
            return new SetQuery<TEntity>(this, Provider, new TEntity());
        }

        public abstract (string?, string?) Explain(TEntity template);
        public (string?, string?) Explain(object template)
        {
            if (template is TEntity entity)
                return Explain(entity);
            return (null, null);
        }

        /// <summary>
        /// Asynchronously retrieves the sequence number associated with the specified entity.
        /// </summary>
        /// <typeparam name="TEntity">The element to retrieve the sequence number.</typeparam>
        /// <param name="element">The entity instance whose sequence number is to be retrieved. Can be null if the implementation allows.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the sequence number associated
        /// with the specified entity.</returns>
        /// <exception cref="NotImplementedException">Thrown if the method is not implemented in a derived class.</exception>
        /// TODO: change to abstract in the next version
        public virtual Task<ulong> GetSequenceAsync(TEntity element) { throw new NotImplementedException("Update the HiuLang compiler and/or drivers"); }

        /// <summary>
        /// Asynchronously get the NEXT sequence number associated with the specified entity.
        /// </summary>
        /// <typeparam name="TEntity">The element to retrieve the sequence number.</typeparam>
        /// <param name="element">The entity instance whose sequence number is to be retrieved. Can be null if the implementation allows.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the sequence number associated
        /// with the specified entity.</returns>
        /// <exception cref="NotImplementedException">Thrown if the method is not implemented in a derived class.</exception>
        /// TODO: change to abstract in the next version
        public virtual Task<ulong> UseSequenceAsync(TEntity element) { throw new NotImplementedException("Update the HiuLang compiler and/or drivers"); }

        #endregion
    }

    public abstract class SetSpaceVersion<TEntity> : SetSpace<TEntity>
        where TEntity : ElementVersion<TEntity>, new()
    {
        protected DateTime? _AsAt;
        protected DateTime? _DeltaFrom;
        public SetSpaceVersion(SubSpace space, IQueryProvider provider, DateTime? AsAt = null, DateTime? DeltaFrom = null) : base(space, provider)
        {
            _AsAt = AsAt;
            _DeltaFrom = DeltaFrom;
        }
        public DateTime? DeltaFrom => _DeltaFrom;

        public override Result<TEntity> Bind(TEntity item, bool cache = true, bool read = false)
        {
            TEntity? res;
            var filtered = Filter(item, read);
            if (filtered.Fail)
                return filtered;
            if (Cached.TryGetValue(item, out res))
            {
                // update the value if it is newer
                if (res.AsAt < item.AsAt)
                { 
                    Cached.Remove(res);
                    if (cache)
                        Cached.Add(item);
                    return Result.Ok(item);
                }
                else
                {
                    return Result.Skip(res);    
                }
            }
            else if (cache)
            {
                Cached.Add(item);
            }
            return Result.Ok(item);
        }
        public Result<TEntity> BatchBind(TEntity item, bool cache, (byte[] key, byte[] value, DateTime version, object? source)[] batch)
        {
            var result = Space.BatchBind(batch);
            if (result.Any(b => b.Fail))
                return Result.Fail(item);
            if (cache)
            {
                Cached.Remove(item);
                Cached.Add(item);
                RaiseOnbind(item);
                return Result.Ok(item);
            }
            RaiseOnbind(item);
            return Result.Ok(item);
        }
        public Result<TEntity> BatchBind(TEntity item, bool cache, (byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)
        {
            var result = Space.BatchBind(batch);
            if (result.Any(b => b.Fail))
                return Result.Fail(item);
            if (cache)
            {
                Cached.Remove(item);
                Cached.Add(item);
                RaiseOnbind(item);
                return Result.Ok(item);
            }
            RaiseOnbind(item);
            return Result.Ok(item);
        }
        public new bool Add(TEntity item)
        {
            return Bind(item, true, true).Ok;
        }

        public virtual Result<TEntity> BindVersion(TEntity item, bool cache = true)
        {
            TEntity? res;
            var filtered = Filter(item, false);
            if (filtered.Fail)
                return filtered;
            if (Cached.TryGetValue(item, out res))
            {
                Cached.Remove(res);
            }
            if (cache)
            {
                Cached.Add(item);
            }
            return Result.Ok(item);
        }
        public virtual TEntity? Get(TEntity template, DateTime? version)
        {
            if (!version.HasValue)
                return Get(template);

            template.Bind(this.Space);
            foreach (var item in template.GetVersions())
            {
                if (item.AsAt <= version)
                    return item;
            }
            return null;
        }
        public virtual async Task<TEntity?> GetAsync(TEntity template, DateTime? version)
        {
            if (!version.HasValue)
                return await GetAsync(template);

            template.Bind(this.Space);
            await foreach (var item in template.GetVersionsAsync())
            {
                if (item.AsAt <= version)
                    return item;
            }
            return null;
        }
    }
}
