// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    public abstract class IndexPath<TEntity, TKey>
        where TEntity : Element<TEntity>, new()
        where TKey : struct
    {
        protected KeyPath<TEntity, TKey> _keyPath;
        public IndexPath(KeyPath<TEntity, TKey> keypath)
        {
            _keyPath = keypath;
        }

        public abstract byte[] IndexBytes(TEntity item);
        public abstract bool IsSargable(TEntity item);

        public abstract void Bind(TEntity item);
        public virtual (byte[], byte[], object?)? Batch(TEntity item)
        {
            return null;
        }
        public abstract Task BindAsync(TEntity item);

        public virtual (byte[] key, byte[] value) PrepareBind(TEntity item)
        {
            throw new NotImplementedException();
        }
        public virtual Task<(byte[] key, byte[] value)> PrepareBindAsync(TEntity item)
        {
            throw new NotImplementedException();
        }

        public abstract IEnumerable<TEntity> Find(TEntity template);
        public abstract Task<IEnumerable<TEntity>> FindAsync(TEntity template);
    }
}
