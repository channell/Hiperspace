// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    public abstract class KeyPath<TEntity, TKey> 
        where TEntity : Element<TEntity>, new()
        where TKey : struct
    {
        protected SetSpace<TEntity> _setSpace;
        public readonly HiperSpace Space;
        public KeyPath
            ( HiperSpace space
            , SetSpace<TEntity> setSpace
            )
        {
            _setSpace = setSpace;
            Space = space;
        }

        public abstract byte[] KeyBytes(TEntity item);
        public abstract byte[] ValueBytes(TEntity item);

        public abstract bool IsGetable(TEntity item);
        public abstract bool IsSargable(TEntity item);

        public abstract bool Bind(TEntity item);
        public virtual (byte[], byte[], object?)? Batch(TEntity item)
        {
            throw new NotImplementedException("This KeyPath provides BatchVersion instead");
        }
        public abstract Task<bool> BindAsync(TEntity item);

 
        public abstract TEntity? Get(ref TKey key);
        public abstract IEnumerable<TEntity> Find(TEntity template);
        public abstract IAsyncEnumerable<TEntity> FindAsync(TEntity template, CancellationToken cancellation = default);
        public abstract IEnumerable<(TEntity Item, double Distance)> Nearest(TEntity template, Vector space, Vector.Method method, int limit);

        public abstract IAsyncEnumerable<(TEntity Item, double Distance)> NearestAsync(TEntity template, Vector space, Vector.Method method, int limit, CancellationToken cancellation = default);

        /// <summary>
        /// Perform a full table scan because there are no suitable Key or Index to use
        /// </summary>
        /// <param name="template">empty structure</param>
        /// <returns>every instance of TEntity in the hiperspace</returns>
        public virtual IEnumerable<TEntity> Scan(TEntity template)
        {
            return Find(template);
        }
        /// <summary>
        /// Perform a full table scan async because there are no suitable Key or Index to use
        /// </summary>
        /// <param name="template">empty structure</param>
        /// <returns>every instance of TEntity in the hiperspace</returns>
        public virtual IAsyncEnumerable<TEntity> ScanAsync(TEntity template, CancellationToken cancellationToken = default)
        {
            return Scan(template).ToAsyncEnumerable(cancellationToken);
        }
    }
}
