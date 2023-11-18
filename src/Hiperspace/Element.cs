namespace Hiperspace
{
    /// <summary>
    /// Base class for all Hiperspace elements 
    /// </summary>
    /// <typeparam name="TEntity">An element that inherits from Element<TEntity></typeparam>
    public abstract class Element<TEntity> : 
        IEquatable<TEntity>, 
        IComparable<TEntity>, 
        IComparable
        where TEntity : Element<TEntity>, new()
    {
        public abstract Result<TEntity> Bind(SubSpace subSpace);
        public abstract void Unbind(SubSpace subSpace);
        public SetSpace<TEntity>? SetSpace { get; protected set; }

        public abstract int CompareTo(TEntity? other);

        public int CompareTo(object? obj)
        {
            return CompareTo(obj as TEntity);
        }

        public abstract bool Equals(TEntity? other);

        public abstract string SKey { get; set; }

        public static implicit operator Result<Element<TEntity>> (Element<TEntity> element)
        {
            return Result.Ok(element);
        }
    }
}
