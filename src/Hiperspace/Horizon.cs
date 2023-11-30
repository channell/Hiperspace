// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Diagnostics.CodeAnalysis;

namespace Hiperspace
{
    /// <summary>
    /// The Horizon is the global set of expresions that applies to all entities
    /// </summary>
    public class Horizon
    {
        protected Horizon(Type type) 
        { 
            Type = type;
        }
        public readonly Type Type;
    }

    /// <summary>
    /// Horizon objects can only be constructed with predicates
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class Horizon<TEntity> : Horizon where TEntity : class
    {
        internal Func<TEntity, bool> Predicate;
        public Horizon([NotNull]Func<TEntity, bool> predicate) : base (typeof(TEntity))
        {
            Predicate = predicate;
        }
    }
}
