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
        public abstract Task BindAsync(TEntity item);
        public abstract IEnumerable<TEntity> Find(TEntity template);
        public abstract Task<IEnumerable<TEntity>> FindAsync(TEntity template);
    }
}
