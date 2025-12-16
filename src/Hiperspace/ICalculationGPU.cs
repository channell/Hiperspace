// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Graph;
namespace Hiperspace
{
    /// <summary>
    /// Defines methods for performing high-performance graph traversal and pathfinding operations using GPU
    /// acceleration.
    /// </summary>
    /// <remarks>Implementations of this interface provide asynchronous and synchronous methods for
    /// discovering cycles, paths, and links within a graph structure. These operations are optimized for large-scale
    /// graphs and may leverage GPU resources for improved performance. Thread safety and resource management depend on
    /// the specific implementation.</remarks>
    public interface ICalculationGPU
    {
        /// <summary>
        /// Recursive search the graph to find paths to other nodes optionally applying criteria to limit the population
        /// to return the shortest path to each Node
        /// </summary>
        /// <remarks>
        /// HiLang enables Elements to be viewed as a Node, and optional provide the source for a number of Edges
        /// Path functions search the ontological graph of connections, and returns the shorted path from the root
        /// to the ends with additions, with addition: 
        /// * Width : total number of alternate paths that could connect the root to ends
        /// * Length : the number of Nodes visied to get from root to end
        /// </remarks>
        /// <param name="root">node being inspected</param>
        /// <param name="route">route that should be searched to find this node</param>
        /// <param name="length">optional maximum length of edges that should be searched</param>
        /// <param name="targets">optional TypeName of the Nodes that should be returned as ends</param>
        /// <param name="cancellationToken">for cancellation</param>
        /// <returns></returns>
        Task<HashSet<HiperEdge>> PathsAsync
            ( Node root
            , Route route
            , int? length = null
            , HashSet<string>? targets = null
            , CancellationToken cancellationToken = default
            );

        /// <summary>
        /// Recursive search the graph to find paths to specific other nodes
        /// </summary>
        /// <remarks>
        /// HiLang enables Elements to be viewed as a Node, and optional provide the source for a number of Edges
        /// Path functions search the ontological graph of connections, and returns the shorted path from the root
        /// to the ends with additions, with addition: 
        /// * Width : total number of alternate paths that could connect the root to ends
        /// * Length : the number of Nodes visied to get from root to end
        /// 
        /// This function does not have a legnth, but searches until all links are found, or connections in the
        /// root are exhausted
        /// </remarks>
        /// <param name="root">node being inspected</param>
        /// <param name="route">route that should be searched to find this node</param>
        /// <param name="targets">optional set of specific Nodes being connected</param>
        /// <param name="cancellationToken">for cancellation</param>
        /// <returns></returns>
        Task<HashSet<HiperEdge>> LinksAsync
            ( Node root
            , Route route
            , HashSet<Node> targets
            , int? length = null
            , CancellationToken cancellationToken = default
            );

        /// <summary>
        /// Recursively Find Cycles of connections that return to the root Node through the graph of edges
        /// </summary>
        /// <param name="root">node being inspected</param>
        /// <param name="route">route that should be searched to find this node</param>
        /// <param name="length">maximum length of edges that should be searched</param>
        /// <param name="cancellationToken">for cancellation</param>
        /// <returns>set of HiperEdges that contain the source path of nodes visited for the shortest path</returns>
        IAsyncEnumerable<HiperEdge> CycleAsync
            ( Node root
            , Route route
            , int? length = null
            , CancellationToken cancellationToken = default
            );

        /// <summary>
        /// Compute the nearest neighbors search of a SetSpace VectorSpace using a graph GPU 
        /// </summary>
        /// <typeparam name="TEntity">type of element being searched for</typeparam>
        /// <param name="template">template object to limit population searched</param>
        /// <param name="space">the Vector that we're comparing the population with</param>
        /// <param name="method">Distance, Dot, or Cosine product method to use</param>
        /// <param name="limit">number of nearest neighbors to return</param>
        /// <param name="cancellation">for cancellation</param>
        /// <returns></returns>
        IAsyncEnumerable<(TEntity Item, double Distance)> NearestAsync<TEntity>
            ( SetSpace<TEntity> caller
            , TEntity template
            , Vector space
            , Vector.Method method
            , int limit = 0
            , CancellationToken cancellation = default
            )
            where TEntity : Element<TEntity>, new();
    }
}
