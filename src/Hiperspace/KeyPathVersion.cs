// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------

namespace Hiperspace
{
    public abstract class KeyPathVersion<TEntity, TKey> : KeyPath<TEntity, TKey>
        where TEntity : ElementVersion<TEntity>, new()
        where TKey : struct
    {
        protected DateTime? _AsAt;
        protected DateTime? _DeltaFrom;
        public KeyPathVersion
            ( HiperSpace space
            , SetSpace<TEntity> setSpace
            , DateTime? AsAt
            , DateTime? DeltaFrom = null
            )
            : base (space, setSpace)
        {
            _AsAt = AsAt;
            _DeltaFrom = DeltaFrom;
        }
        public abstract (byte[], byte[], DateTime, object?)? BatchVersion(TEntity item);
        public virtual TEntity? Get(ref TKey key, DateTime? version)
        {
            if (!version.HasValue)
                return Get (ref key);
            throw new NotImplementedException ();
        }
    }
}
