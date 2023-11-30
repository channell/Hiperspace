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

        public abstract TEntity? Get(ref TKey key);
        public abstract IEnumerable<TEntity> Find(TEntity template);
        public abstract Task<IEnumerable<TEntity>> FindAsync(TEntity template);
    }
}
