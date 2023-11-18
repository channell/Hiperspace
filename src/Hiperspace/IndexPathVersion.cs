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
    }
}
