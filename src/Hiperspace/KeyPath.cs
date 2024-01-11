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
        public abstract Task<bool> BindAsync(TEntity item);

        public virtual (byte[] key, byte[] value) PrepareBind(TEntity item)
        {
            throw new NotImplementedException();
        }
        public virtual Task<(byte[] key, byte[] value)> PrepareBindAsync(TEntity item)
        {
            throw new NotImplementedException();
        }

        public abstract TEntity? Get(ref TKey key);
        public abstract IEnumerable<TEntity> Find(TEntity template);
        public abstract Task<IEnumerable<TEntity>> FindAsync(TEntity template);

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
        public virtual Task<IEnumerable<TEntity>> ScanAsync(TEntity template)
        {
            return FindAsync(template);
        }
    }
}
