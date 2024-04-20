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
        public IndexPathVersion(KeyPathVersion<TEntity, TKey> keypath, DateTime? AsAt) : base(keypath)
        {
            _AsAt = AsAt;
        }
        public virtual (byte[], byte[], DateTime, object?)? BatchVersion(TEntity item)
        {
            return null;
        }

    }
}
