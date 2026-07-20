// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
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
        /// <typeparam name="T">property to be resolved</typeparam>
        /// <param name="self">this Element<></param>
        /// <param name="func">function to retrieve </param>
        /// <code>
        ///     domainSetSpace.Include(e => e.reference.Value);
        /// </code>
        /// <returns>self</returns>
        public static IEnumerable<TEntity> Include<TEntity, T>(this IEnumerable<TEntity> self, Func<TEntity, T> func)
            where TEntity : Element<TEntity>, new()
        {
            foreach (var entity in self)
            {
                var t = func(entity);
                yield return entity;
            }
        }
        /// <summary>
        /// Cache a reference setinclusion in serialisation
        /// </summary>
        /// <typeparam name="TEntity">element being passed to Include</typeparam>
        /// <typeparam name="T">property to be resolved</typeparam>
        /// <param name="self">this Element<></param>
        /// <param name="func">function to retrieve </param>
        /// <code>
        ///     domainSetSpace.Include(e => e.references);
        ///     domainSetSpace.Include(e => e.references.Include(r => r.property));
        ///     domainSetSpace.Include(e => e.references.Include(r => r.references.Include(i => i.property);
        ///     domainSetSpace.Include(e => e.references.Include(r => r.references.Include(i => i.referernces);
        /// </code>
        /// <returns>self</returns>
        public static IEnumerable<TEntity> Include<TEntity, T>(this IEnumerable<TEntity> self, Func<TEntity, IEnumerable<T>> func)
            where TEntity : Element<TEntity>, new()
        {
            foreach (var entity in self)
            {
                foreach (var t in func(entity)) ;
                yield return entity;
            }
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
