// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    public abstract class IndexPathVersion<TEntity, TKey> : IndexPath<TEntity, TKey>
    where TEntity : ElementVersion<TEntity>, new()
    where TKey : struct
    {
        protected DateTime? _AsAt;
        protected DateTime? _DeltaFrom;
        public IndexPathVersion(KeyPathVersion<TEntity, TKey> keypath, DateTime? AsAt, DateTime? DeltaFrom = null) : base(keypath)
        {
            _AsAt = AsAt;
            _DeltaFrom = DeltaFrom;
        }
        public abstract (byte[], byte[], DateTime, object?)? BatchVersion(TEntity item);

        /// <summary>
        /// not overridable, since index may not change when the main value does, and can not be used for optimistic concurrency control
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public (byte[], byte[], DateTime, DateTime?, object?)? BatchLockedVersion(TEntity item)
        {
            var nonlocked = BatchVersion(item);
            if (nonlocked.HasValue)
                return (nonlocked.Value.Item1, nonlocked.Value.Item2, nonlocked.Value.Item3, null, nonlocked.Value.Item4);
            return null;
        }

    }
    public abstract class DeltaIndexPathVersion<TEntity, TKey> : IndexPathVersion<TEntity, TKey> 
    where TEntity : ElementVersion<TEntity>, new()
    where TKey : struct
    {
        public DeltaIndexPathVersion(KeyPathVersion<TEntity, TKey> keypath, DateTime? AsAt, DateTime? DeltaFrom = null) : base(keypath, AsAt, DeltaFrom)
        {
        }
        public abstract IEnumerable<TEntity> Delta(TEntity template);
        public IAsyncEnumerable<TEntity> DeltaAsync(TEntity template)
        {
            return Delta(template).ToAsyncEnumerable();
        }
    }
}
