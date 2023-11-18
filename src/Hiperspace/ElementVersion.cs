namespace Hiperspace
{
    /// <summary>
    /// An element that includes multiple versions
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class ElementVersion<TEntity> : Element<TEntity>
        where TEntity : ElementVersion<TEntity>, new()
    {
        public DateTime AsAt { get; set; }
        public abstract IEnumerable<TEntity> GetVersions();
        public abstract Task<IEnumerable<TEntity>> GetVersionsAsync();
    }
}
