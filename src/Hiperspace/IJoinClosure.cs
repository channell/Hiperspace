// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    /// <summary>
    /// Defines the interface to join two queryable data sources, producing results by
    /// applying a closure function to each pair of joined elements
    /// </summary>
    /// <typeparam name="TLeft">The type of elements in the left queryable data source</typeparam>
    /// <typeparam name="TRight">The type of elements in the right queryable data source</typeparam>
    public interface IJoinClosure<TLeft, TRight> 
    {
        /// <summary>
        /// enumerate over the left set, appling the join conditions to the right template (to find only matching elements)
        /// and enumerate over the right set providing the result through the closure factory
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="leftQuery">left set, normally a SetQuery or SetJoin, but could be an external source</param>
        /// <param name="rightQuery">right set, normally a SetQuery or SetJoin, but could be an external source</param>
        /// <param name="closureFactory">factory to produce a result from the join</param>
        /// <returns>a single result set</returns>
        public IEnumerator<TResult> GetEnumerator<TResult>(IQueryable<TLeft> leftQuery, IQueryable<TRight> rightQuery, Func<TLeft, TRight, TResult> closureFactory);
    }
}
