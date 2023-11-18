namespace Hiperspace
{
    /// <summary>
    /// Extension methods
    /// </summary>
    public static class ElementExtensions
    {
        /// <summary>
        /// Cache values of the reference for inclusion in serialisation
        /// </summary>
        /// <typeparam name="TEntity">element being passed to Include</typeparam>
        /// <param name="self">this Element<></param>
        /// <param name="func">function to retrieve </param>
        /// <code>
        ///     domainObject.Include(e => e.reference.Value);
        /// </code>
        /// <returns>self</returns>
        public static TEntity Include<TEntity>(this TEntity self, Action<TEntity> func)
            where TEntity : Element<TEntity>, new()
        {
            func(self);
            return self;
        }
        /// <summary>
        /// Cache values of the reference for inclusion in serialisation
        /// </summary>
        /// <typeparam name="TEntity">element being passed to Include</typeparam>
        /// <param name="self">this Element<></param>
        /// <param name="func">function to retrieve </param>
        /// <code>
        ///     domainObject.Include(e => e.set, s => s.reference.Value));
        ///     domainObject.Include(e => e.set, s => s.otherset.Include(oe => oe.reference.Value));
        ///     domainObject.Include(e => e.set, s => s.otherset.Include(oe => oe.anotherset, os => os.refernence.Value));
        /// </code>
        /// <returns>self</returns>
        public static TEntity Include<TEntity, TOther>(this TEntity self, Func<TEntity, RefSet<TOther>> func, Action<TOther> setfunc)
            where TEntity : Element<TEntity>, new()
            where TOther : Element<TOther>, new()
        {
            var set = func(self);
            foreach (var v in set)
                setfunc(v);
            return self;
        }
    }
}
