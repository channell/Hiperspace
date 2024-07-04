// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
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
    }
    public abstract class DeltaIndexPathVersion<TEntity, TKey> : IndexPathVersion<TEntity, TKey> 
    where TEntity : ElementVersion<TEntity>, new()
    where TKey : struct
    {
        public DeltaIndexPathVersion(KeyPathVersion<TEntity, TKey> keypath, DateTime? AsAt, DateTime? DeltaFrom = null) : base(keypath, AsAt, DeltaFrom)
        {
        }
        public abstract IEnumerable<TEntity> Delta(TEntity template);
        public Task<IEnumerable<TEntity>> DeltaAsync(TEntity template)
        {
            return Task.Run(() => Delta(template));
        }
    }
}
