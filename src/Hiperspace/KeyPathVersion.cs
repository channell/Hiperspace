// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
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
            ( SubSpace space
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
        public virtual (byte[], byte[], DateTime, DateTime?, object?)? BatchLockedVersion(TEntity item)
        {
            var nonlocked = BatchVersion(item);
            if (nonlocked.HasValue)
                return (nonlocked.Value.Item1, nonlocked.Value.Item2, nonlocked.Value.Item3, null, nonlocked.Value.Item4);
            return null;
        }
        public virtual TEntity? Get(ref TKey key, DateTime? version)
        {
            if (!version.HasValue)
                return Get(ref key);
            else
            {
                var item = Get(ref key);
                if (item != null)
                    foreach (var v in item.GetVersions())
                    {
                        if (v.AsAt <= version)
                            return v;
                    }
            }
            return null;
        }
        public virtual async Task<TEntity?> GetAsync(TKey key, DateTime? version)
        {
            if (!version.HasValue)
                return await GetAsync(key);
            else
            {
                var item = await GetAsync(key);
                if (item != null)
                await foreach (var v in item.GetVersionsAsync())
                {
                    if (v.AsAt <= version)
                        return v;
                }
            }
            return null;
        }
    }
}
