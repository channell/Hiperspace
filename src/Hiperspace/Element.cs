// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
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

        /// <summary>
        /// Cast helper for F# code
        /// </summary>
        /// <typeparam name="TView">any view tyope that may be projected from the element</typeparam>
        /// <param name="view">optional target value to drive cast</param>
        /// <returns>the object as the view type or null</returns>
        public TView? As<TView>(TView? view = null) where TView : Element<TView>, new()
        {
            return this as TView;
        }
        /// <summary>
        /// Helper function for KeyRef<> to bind the key to a blank entity
        /// </summary>
        /// <typeparam name="TKey">type of the KeyRef key</typeparam>
        /// <param name="key">key value help by KeyRef<></param>
        public virtual bool BindKey<TKey>(TKey key) => false;
    }
}
