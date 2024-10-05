// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Collections;
using System.Reflection;

namespace Hiperspace
{
    /// <summary>
    /// Represents a set join operation.
    /// </summary>
    public interface ISetJoin : IEnumerable
    {
        /// <summary>
        /// Gets the explanation of the join operation.
        /// </summary>
        /// <returns>The explanation of the join operation.</returns>
        public QueryExplain.Explain Explain();

        /// <summary>
        /// Gets the inner join.
        /// </summary>
        public ISetJoin? Inner { get; }

        /// <summary>
        /// Gets the left source of the join.
        /// </summary>
        public ISetQuery? Left { get; }

        /// <summary>
        /// Gets the right source of the join.
        /// </summary>
        public ISetQuery? Right { get; }

        /// <summary>
        /// Gets the list of join conditions.
        /// </summary>
        public List<((string alias, ValueGetter property) left, (string alias, PropertyInfo property) right)> Joins { get; }

        /// <summary>
        /// Gets the element type of the join.
        /// </summary>
        public Type ElementType { get; }

        /// <summary>
        /// Gets the runnable join.
        /// </summary>
        public ISetJoin Runnable { get; }
    }
}
