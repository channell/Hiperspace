namespace Hiperspace
{
    public abstract class KeyPathVersion<TEntity, TKey> : KeyPath<TEntity, TKey>
        where TEntity : ElementVersion<TEntity>, new()
        where TKey : struct
    {
        protected DateTime? _AsAt;
        public KeyPathVersion
            ( HiperSpace space
            , SetSpace<TEntity> setSpace
            , DateTime? AsAt
            )
            : base (space, setSpace)
        {
            _AsAt = AsAt;
        }
    }
}
