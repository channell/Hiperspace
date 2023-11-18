using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Hiperspace
{
    public abstract class SetSpace<TEntity> : HashSet<TEntity>, IOrderedQueryable<TEntity>
        where TEntity : Element<TEntity>, new()
    {
        public delegate void Bound (TEntity entity);
        /// <summary>
        /// Event to capture Bind Events
        /// </summary>
        public event Bound? OnBind;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected void RaiseOnbind(TEntity entity)
        {
            OnBind?.Invoke(entity);
        }

        protected Func<TEntity,bool>[]? predicates;
        public SubSpace Space { get; set; }
        public SetSpace(SubSpace space, IQueryProvider provider) 
        {
            Space = space;
            Provider = provider;
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
                TEntity? res;
                if (((HashSet<TEntity>)this).TryGetValue(item, out res))
                    return Result.Skip(res);

                if (!cache || Filter(item).Ok)
                {
                    base.Add(item);
                    _lock.Exit();
                    RaiseOnbind(item);
                    return Result.Ok(item);
                }
                else
                    return Result.Fail(item, "Filtered by Horizon");
            }
            else
                throw new LockRecursionException();
        }

        public new bool Add(TEntity item)
        {
            return Bind(item, true).Ok;
        }
        protected bool ProtecedAdd(TEntity item)
        {
            return base.Add(item);
        }

        public new bool TryGetValue(TEntity equalValue, out TEntity actualValue)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                TEntity? res;
                if (base.TryGetValue(equalValue, out res))
                {
                    actualValue = res;
                    _lock.Exit();
                    return true;
                }
                else
                {
                    actualValue = equalValue;
                    _lock.Exit();
                    return false;
                }
            }
            else
                throw new LockRecursionException();
        }

        #region entity functions
        public abstract TEntity? Get(TEntity template);

        public abstract Task<Result<TEntity>> BindAsync(TEntity item, bool cache = true);

        public new abstract void UnionWith (IEnumerable<TEntity> other);

        public abstract IEnumerable<TEntity> Find(TEntity template, bool cache = true);

        public abstract Task<IEnumerable<TEntity>> FindAsync(TEntity template, bool cache = true);

        public IEnumerable<TEntity> Filter(IEnumerable<TEntity> entities)
        {
            if (predicates != null)
                return entities
                    .Where(e =>
                    {
                        for (int c = 0; c < predicates.Length; c++)
                        {
                            if (!predicates[c](e))
                                return false;
                        }
                        return true;
                    });
            return entities;
        }
        public Result<TEntity> Filter(TEntity entity)
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

        public IEnumerable<TEntity> Cached => (HashSet<TEntity>)this;
        #endregion
        #region queryable
        IEnumerator<TEntity> IEnumerable<TEntity>.GetEnumerator()
        {
            foreach (var item in Find(new TEntity()))
            {
                yield return item;
            }
        }
        public static Expression<Predicate<TEntity>> True = f => true;

        Type IQueryable.ElementType => typeof(TEntity);

        Expression IQueryable.Expression => Expression.Constant(this);

        public IQueryProvider Provider { get; init; }
        #endregion
    }

    public abstract class SetSpaceVersion<TEntity> : SetSpace<TEntity>
        where TEntity : ElementVersion<TEntity>, new()
    {
        protected DateTime? _AsAt;
        protected bool _isStrict;
        public SetSpaceVersion(SubSpace space, IQueryProvider provider, DateTime? AsAt = null, bool isStrict = false) : base(space, provider) 
        { 
            _AsAt = AsAt;
            _isStrict = isStrict;
        }

        public override Result<TEntity> Bind(TEntity item, bool cache = true)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                TEntity? res;
                if (((HashSet<TEntity>)this).TryGetValue(item, out res))
                {
                    if (_isStrict)
                        return Result.Skip(res);
                    else
                        base.Remove(res);
                }

                if (cache && Filter(item).Ok)
                {
                    base.ProtecedAdd(item);
                    _lock.Exit();
                    RaiseOnbind(item);
                    return Result.Ok(item);
                }
                else
                    return Result.Fail(item, "Filtered by Horizon");
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
                TEntity? res;
                if (base.TryGetValue(item, out res))
                    base.Remove(res);
                else if (_isStrict)
                    return Result.Skip(res);

                if (!cache || Filter(item).Ok)
                {
                    base.Add(item);
                    _lock.Exit();
                    RaiseOnbind(item);
                    return Result.Ok(item);
                }
                else
                    return Result.Fail(item, "Filtered by Horizon");
            }
            else
                throw new LockRecursionException();
        }
    }
}
