// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Diagnostics.CodeAnalysis;
using System.Security.Principal;

namespace Hiperspace
{
    /// <summary>
    /// The Horizon is the global set of expressions that applies to all entities
    /// </summary>
    public class Horizon
    {
        /// <summary>
        /// The predicate that determines if an entity is accessible
        /// </summary>
        /// <param name="entity">the entity passed to the Horizon filter by the set space</param>
        /// <param name="context">context label assigned to the subspace when created, usually the access role</param>
        /// <param name="user">Optional security principle of user, that can be used to check IsInRole(String) </param>
        /// <param name="read">whether the access is read (i.e. not Bind of a new value)</param>
        /// <returns>true if the element is within the horizon for access</returns>
        public delegate bool Predicate<TEntity>(TEntity entity, string? context, IPrincipal? user, bool read);

        protected Horizon(Type type)
        {
            Type = type;
        }
        protected Horizon(Type type, string reason)
        {
            Type = type;
            Reason = reason;
        }
        public readonly Type Type;
        /// <summary>
        /// explanation for a failed result
        /// </summary>
        public string? Reason { get; protected set; }
    }

    /// <summary>
    /// Horizon objects can only be constructed with predicates
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class Horizon<TEntity> : Horizon where TEntity : class
    {
        internal Predicate<TEntity>? predicate;

        /// <summary>
        /// Construct a Horizon with a predicate that does not apply RBAC roles
        /// </summary>
        /// <param name="predicate"></param>
        public Horizon([NotNull] Func<TEntity, bool> entityOnlyPredicate) : base(typeof(TEntity))
        {
            predicate = (p, s, u, b) => entityOnlyPredicate(p);
        }
        /// <summary>
        /// Construct a Horizon with a predicate that does not apply RBAC roles
        /// </summary>
        /// <param name="predicate"></param>
        public Horizon([NotNull] Func<TEntity, bool> entityOnlyPredicate, string reason) : base(typeof(TEntity), reason)
        {
            predicate = (p, s, u, b) => entityOnlyPredicate(p);
        }

        /// <summary>
        /// Construct a Horizon with a predicate that includes context and read access role
        /// </summary>
        /// <param name="entityContextReadPredicate"></param>
        public Horizon([NotNull] Func<TEntity, bool, bool> entityReadPredicate) : base(typeof(TEntity))
        {
            predicate = (p, s, u, b) => entityReadPredicate(p, b);
        }
        /// <summary>
        /// Construct a Horizon with a predicate that includes context and read access role
        /// </summary>
        /// <param name="entityContextReadPredicate"></param>
        public Horizon([NotNull] Func<TEntity, bool, bool> entityReadPredicate, string reason) : base(typeof(TEntity), reason)
        {
            predicate = (p, s, u, b) => entityReadPredicate(p, b);
        }
        /// <summary>
        /// Construct a Horizon with a predicate that includes context and read access role
        /// </summary>
        /// <param name="entityContextReadPredicate"></param>
        public Horizon([NotNull] Func<TEntity, string?, bool, bool> entityContextReadPredicate) : base(typeof(TEntity))
        {
            predicate = (p, s, u, b) => entityContextReadPredicate(p, s, b);
        }
        /// <summary>
        /// Construct a Horizon with a predicate that includes context and read access role
        /// </summary>
        /// <param name="entityContextReadPredicate"></param>
        public Horizon([NotNull] Func<TEntity, string?, bool, bool> entityContextReadPredicate, string reason) : base(typeof(TEntity), reason)
        {
            predicate = (p, s, u, b) => entityContextReadPredicate(p, s, b);
        }
        /// <summary>
        /// Construct a Horizon with a predicate that includes context, user, and access role
        /// </summary>
        /// <param name="entityContextReadUserPredicate"></param>
        public Horizon([NotNull] Predicate<TEntity> entityContextReadUserPredicate) : base(typeof(TEntity))
        {
            predicate = entityContextReadUserPredicate;
        }
        /// <summary>
        /// Construct a Horizon with a predicate that includes context, user, and access role
        /// </summary>
        /// <param name="entityContextReadUserPredicate"></param>
        public Horizon([NotNull] Predicate<TEntity> entityContextReadUserPredicate, string reason) : base(typeof(TEntity), reason)
        {
            predicate = entityContextReadUserPredicate;
        }
    }
}
