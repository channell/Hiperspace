// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
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
    public abstract class SetSpace<TEntity> : ISet<TEntity>, IOrderedQueryable<TEntity>, IEnumerable<TEntity> 
        where TEntity : Element<TEntity>, new()
    {
        public HashSet<TEntity> Cached = new HashSet<TEntity>();

        public delegate void Bound (TEntity entity);
        public delegate void Dependency((TEntity target, Meta.DependencyPath sender) value);
        /// <summary>
        /// Event to capture Bind Events
        /// </summary>
        public event Bound? OnBind;
        public event Dependency? OnDependency;

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
        
        public void ForwardEventsFrom (SetSpace<TEntity> source)
        {
            if (OnBind !=null) source.OnBind += RaiseOnbind;
            if (OnDependency != null) source.OnDependency += RaiseOnDependency;
        }

        protected Func<TEntity,bool>[]? predicates;
        public SubSpace Space { get; set; }
        public SetSpace(SubSpace space, IQueryProvider provider) 
        {
            Space = space;
//            Provider = provider;
            if (space.Horizon != null)
                predicates = space.Horizon
                    .Where(h => h.Type == typeof(TEntity))
                    .Select(i=> ((Horizon<TEntity>)i).Predicate)
                    .ToArray();
        }
        protected SpinLock _lock = new SpinLock();

        public virtual Result<TEntity> Bind(TEntity item, bool cache = true)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                try
                {
                    TEntity? res;
                    if (Cached.TryGetValue(item, out res))
                    {
                        return Result.Skip(res);
                    }

                    if (!cache || Filter(item).Ok)
                    {
                        Cached.Add(item);
                        return Result.Ok(item);
                    }
                    else
                    {
                        return Result.Fail(item, "Filtered by Horizon");
                    }
                }
                finally
                {
                    _lock.Exit();
                }
            }
            else
                throw new LockRecursionException();
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
                    bool taken = false;
                    _lock.Enter(ref taken);
                    if (taken)
                    {
                        try
                        {
                            Cached.Remove(item);
                            Cached.Add(item);
                        }
                        finally
                        {
                            _lock.Exit();
                        }
                    }
                    else
                        throw new LockRecursionException();
                    RaiseOnbind(item);
                    return Result.Ok(item);
                }
                RaiseOnbind(item);
                return Result.Ok(item);
            }
        }

        public bool Add(TEntity item)
        {
            return Bind(item, true).Ok;
        }

        public bool Insert(TEntity item)
        {
            var current = Get(item);
            if (current != null)
            {
                if (item.GetType().GetCustomAttribute<VersionedAttribute>() != null)
                    throw new MutationException($"Cannot insert a new {item.GetType().Name}, use Update(item) instead");
                else
                    throw new MutationException($"Cannot insert a new {item.GetType().Name}, value already exists");
            }
            return Bind(item, true).Ok;
        }
        public bool Update(TEntity item)
        {
            var current = Get(item);
            if (current == null)
                throw new MutationException($"Cannot update a {item.GetType().Name}, use Add(item) if an existing value is not needed");
            return Bind(item, true).Ok;
        }
        public virtual bool Delete(TEntity item)
        {
            var current = Get(item);
            if (current == null)
                throw new MutationException($"Cannot delete {item.GetType().Name}, a vlaue was not found");

            return Bind(item, true).Ok;
        }

        public bool TryGetValue(TEntity equalValue, out TEntity actualValue)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                try
                {
                    TEntity? res;
                    if (Cached.TryGetValue(equalValue, out res))
                    {
                        actualValue = res;
                        return true;
                    }
                    else
                    {
                        actualValue = equalValue;
                        return false;
                    }
                }
                finally
                {
                    _lock.Exit();
                }
            }
            else
                throw new LockRecursionException();
        }

        #region entity functions
        public abstract TEntity? Get(TEntity template);

        public abstract Task<Result<TEntity>> BindAsync(TEntity item, bool cache = true);

        public abstract void UnionWith (IEnumerable<TEntity> other);

        public abstract bool IsSargable(TEntity template);
        public abstract IEnumerable<TEntity> Find(TEntity template, bool cache = true);

        public abstract Task<IEnumerable<TEntity>> FindAsync(TEntity template, bool cache = true);

        public abstract IEnumerable<(TEntity Item, double Distance)> Nearest(TEntity template, Vector space, Vector.Method method, int limit = 0, bool cache = true);

        public abstract Task<IEnumerable<(TEntity Item, double Distance)>> NearestAsync(TEntity template, Vector space, Vector.Method method, int limit = 0, bool cache = true);

        public IEnumerable<TEntity> Filter(IEnumerable<TEntity> entities)
        {
            if (predicates != null)
                return entities
                    .Where(e =>
                    {
                        if (Filter(e).Fail)
                        {
                            Cached.Remove(e);
                            return false;
                        }
                        else
                            return true;
                    });
            return entities;
        }
        public IEnumerable<(TEntity Item, double Distance)> Filter(IEnumerable<(TEntity Item, double Distance)> entities)
        {
            if (predicates != null)
                return entities
                    .Where(e =>
                    {
                        for (int c = 0; c < predicates.Length; c++)
                        {
                            if (!predicates[c](e.Item))
                                return false;
                        }
                        return true;
                    });
            return entities;
        }
        public virtual Result<TEntity> Filter(TEntity entity)
        {
            if (predicates != null)
            {
                for (int c = 0; c < predicates.Length; c++)
                {
                    if (!predicates[c](entity))
                        return Result.Fail(entity);
                }
            }
            return Result.Ok(entity);
        }
        #endregion
        #region key functions
        public abstract TEntity? Get<TKey>(ref TKey key);

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

        public static Expression<Predicate<TEntity>> True = f => true;

        Type IQueryable.ElementType => typeof(TEntity);

        Expression IQueryable.Expression => Expression.Constant(this);

        public IQueryProvider Provider => new Query<TEntity>(this, null);

        public int Count => Cached.Count;

        public bool IsReadOnly => false;
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

        public override Result<TEntity> Bind(TEntity item, bool cache = true)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                try
                {
                    TEntity? res;
                    if (Cached.TryGetValue(item, out res))
                    {
                        base.Remove(res);
                        Cached.Add(item);
                        return Result.Ok(item);
                    }

                    if (cache && Filter(item).Ok)
                    {
                        Cached.Add(item);
                        return Result.Ok(item);
                    }
                    else
                    {
                        return Result.Fail(item, "Filtered by Horizon");
                    }
                }
                finally
                {
                    _lock.Exit();
                }
            }
            else
                throw new LockRecursionException();
        }
        public Result<TEntity> BatchBind(TEntity item, bool cache, (byte[] key, byte[] value, DateTime version, object? source)[] batch)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                try
                {
                    var result = Space.BatchBind(batch);
                    if (result.Any(b => b.Fail))
                        return Result.Fail(item);
                    else
                    {
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
                }
                finally
                {
                    _lock.Exit();
                }
            }
            else
                throw new LockRecursionException();
        }
        public Result<TEntity> BatchBind(TEntity item, bool cache, (byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source)[] batch)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                try
                {
                    var result = Space.BatchBind(batch);
                    if (result.Any(b => b.Fail))
                        return Result.Fail(item);
                    else
                    {
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
                }
                finally
                {
                    _lock.Exit();
                }
            }
            else
                throw new LockRecursionException();
        }
        public new bool Add(TEntity item)
        {
            return Bind(item, true).Ok;
        }

        public virtual Result<TEntity> BindVersion(TEntity item, bool cache = true)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                try
                {
                    TEntity? res;
                    if (base.TryGetValue(item, out res))
                    {
                        base.Remove(res);
                        base.Add(item);
                        return Result.Ok(item);
                    }

                    if (!cache || Filter(item).Ok)
                    {
                        base.Add(item);
                        return Result.Ok(item);
                    }
                    else
                    {
                        return Result.Fail(item, "Filtered by Horizon");
                    }
                }
                finally
                {
                    _lock.Exit();
                }
            }
            else
                throw new LockRecursionException();
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
    }
}
