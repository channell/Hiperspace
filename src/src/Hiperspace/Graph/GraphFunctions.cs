// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Hiperspace;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Graph
{
    public static class PathFunctions 
    {
        public static RouteMap CompileRoute(Route route)
        {
            return new RouteMap(route);
        }

        class Dispatch
        {
            private long Count;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Increment()
            {
                Interlocked.Increment(ref Count);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Decrement()
            {
                Interlocked.Decrement(ref Count);
            }
            public bool EOF => Interlocked.Read(ref Count) == 0;
        }

        public static HashSet<HiperEdge> Paths
            (Node? root
            , Route? route
            , int? length = null
            , HashSet<string>? targets = null)
        {
            if (root is null || route is null)
                return new HashSet<HiperEdge>();
            else
                return new HashSet<HiperEdge>(PathsAsync(root, route.Value, length, targets).GetAwaiter().GetResult());
        }
        [Obsolete("use messages to invoke graph functions on a server")]
        public static HashSet<HiperEdge> PathsRemote
            (Node? root
            , Route? route
            , int? length = null
            , HashSet<string>? targets = null)
        {
            if (root is not null && route is not null && root.SetSpace is not null)
                return root.SetSpace.Space.FindPaths(root, route, length, targets);
            else
                return new HashSet<HiperEdge>();
        }
        [Obsolete("use messages to invoke graph functions on a server")]
        public static async Task<HashSet<HiperEdge>> PathsRemoteAsync
            (Node? root
            , Route? route
            , int? length = null
            , HashSet<string>? targets = null)
        {
            if (root is not null && route is not null && root.SetSpace is not null)
                return await root.SetSpace.Space.FindPathsAsync(root, route.Value, length, targets);
            else
                return new HashSet<HiperEdge>();
        }

        public static async Task<HashSet<HiperEdge>> PathsAsync
            ( Node root
            , Route route
            , int? length = null
            , HashSet<string>? targets = null
            , CancellationToken cancellationToken = default)
        {
            if (root?.SetSpace?.Space?.CalculationGPU is not null)
            {
                return await root.SetSpace.Space.CalculationGPU.PathsAsync
                    ( root
                    , route
                    , length
                    , targets
                    , cancellationToken);
            }
            var map = new RouteMap(route);
            var channel = Channel.CreateUnbounded<Result<HiperEdge>>();
            Dispatch dispatched = new Dispatch();

            HashSet<HiperEdge> result = new HashSet<HiperEdge>();
            if (root?.Froms is not null)
            {
                foreach (var edge in root.Froms)
                {
                    if (edge is not null)
                    {
                        dispatched.Increment();
                        _ = Task.Run(async () =>
                        {
                            try
                            {
                                await FindRoutes(root, map, edge, null, length, 0, channel, dispatched, targets, null, cancellationToken);
                            }
                            finally
                            {
                                await channel.Writer.WriteAsync(Result.EOF<HiperEdge>());
                            }
                        });
                    }
                }
            }
            if (dispatched.EOF)
                return result;
            await foreach (var item in channel.Reader.ReadAllAsync())
            {
                if (item.Ok)
                {
                    if (result.TryGetValue(item.Value, out var path))
                    {
                        if (path is not null)
                        {
                            if (path.Length > item.Value.Length)
                            {
                                result.Remove(path);
                                result.Add(item.Value);
                                item.Value.Width++;
                            }
                            else
                                path.Width++;
                        }
                    }
                    else
                    {
                        result.Add(item.Value);
                    }
                }
                else if (item.EOF)
                {
                    dispatched.Decrement();
                    if (dispatched.EOF)
                        break;
                }
            }

            return result;
        }

        public static async Task<HashSet<HiperEdge>> LinksAsync
            ( Node root
            , Route route
            , HashSet<Node> targets
            , int? length = null
            , CancellationToken cancellationToken = default)
        {
            if (root?.SetSpace?.Space?.CalculationGPU is not null)
            {
                return await root.SetSpace.Space.CalculationGPU.LinksAsync
                    (root
                    , route
                    , targets
                    , length
                    , cancellationToken);
            }
            var map = new RouteMap(route);
            var channel = Channel.CreateUnbounded<Result<HiperEdge>>();
            Dispatch dispatched = new Dispatch();

            HashSet<HiperEdge> result = new HashSet<HiperEdge>();
            if (root?.Froms is not null)
            {
                foreach (var edge in root.Froms)
                {
                    if (edge is not null)
                    {
                        dispatched.Increment();
                        _ = Task.Run(async () =>
                        {
                            try
                            {
                                await FindRoutes(root, map, edge, null, null, 0, channel, dispatched, null, targets, cancellationToken);
                            }
                            finally
                            {
                                await channel.Writer.WriteAsync(Result.EOF<HiperEdge>());
                            }
                        });
                    }
                }
            }
            if (dispatched.EOF)
                return result;
            await foreach (var item in channel.Reader.ReadAllAsync())
            {
                if (item.Ok)
                {
                    if (result.TryGetValue(item.Value, out var path))
                    {
                        if (path is not null)
                        {
                            if (path.Length > item.Value.Length)
                            {
                                result.Remove(path);
                                result.Add(item.Value);
                                item.Value.Width++;
                            }
                            else
                                path.Width++;
                        }
                    }
                    else
                    {
                        result.Add(item.Value);
                    }
                }
                else if (item.EOF)
                {
                    dispatched.Decrement();
                    if (dispatched.EOF)
                        break;
                }
            }

            return result;
        }

        static async Task FindRoutes
            ( Node root
            , RouteMap route
            , Edge edge
            , HiperEdge? source
            , int? length
            , int recursion
            , Channel<Result<HiperEdge>> channel
            , Dispatch dispatched
            , HashSet<string>? targets
            , HashSet<Node>? targetNodes
            , CancellationToken cancellationToken = default)
        {
            if (edge is null ||
                root == edge.To ||
                root == edge.From && source is not null ||
                recursion >= length ||
                edge.InPath(source))
                return;

            var path = new HiperEdge
            {
                From = root,
                To = edge.To,
                Source = source,
                Edge = edge,
                TypeName = route.Name,
                Length = source?.Length + 1 ?? 1,
                Width = 1
            };
            var from = edge?.To?.Froms.ToArray();
            if (from is not null && from.Length > 0)
            {
                foreach (var next in from)
                {
                    if (next is not null)
                    {
                        if ((recursion + 1 <= length || length is null) && route.Match(next) == true)
                        {
                            dispatched.Increment();
                            _ = Task.Run(async () =>
                            {
                                try
                                {
                                    await FindRoutes(root, route, next, path, length, recursion + 1, channel, dispatched, targets, null, cancellationToken);
                                }
                                finally
                                {
                                    await channel.Writer.WriteAsync(Result.EOF<HiperEdge>());
                                }
                            });
                        }
                    }
                }
            }
            // if this edge is in the set of target types
            if (edge is not null &&
                route.Match(edge) == true &&
                edge?.To?.TypeName is not null &&
                (targets is null || targets.Contains(edge.To.TypeName)) &&
                (targetNodes is null || targetNodes.Contains(edge.To)))
            {
                await channel.Writer.WriteAsync(Result.Ok(path));
            }
        }
        public static bool InPath(this Edge edge, HiperEdge? path)
        {
            if (path is null) return false;
            if (edge == path.Edge) return true;
            if (edge.To == path.Edge?.From) return true;
            if (edge.To == path.Edge?.To) return true;
            if (path.Source is not null)
            {
                var source = path.Source;
                if (edge == source.Edge) return true;
                if (edge.To == source.Edge?.From) return true;
                if (edge.To == source.Edge?.To) return true;
                if (source.Source is null) return false;
                else
                {
                    source = source.Source;
                    if (edge == source.Edge) return true;
                    if (edge.To == source.Edge?.From) return true;
                    if (edge.To == source.Edge?.To) return true;
                    if (source.Source is null) return false;
                    else
                    {
                        source = source.Source;
                        if (edge == source.Edge) return true;
                        if (edge.To == source.Edge?.From) return true;
                        if (edge.To == source.Edge?.To) return true;
                        if (source.Source is null) return false;
                        return edge.InPath(source.Source);
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Find cycles in the graph that link back to the root node
        /// </summary>
        /// <param name="root">node being considered</param>
        /// <param name="route">rules for the graph search</param>
        /// <param name="length">maximum length to consider</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <remarks> 
        /// This doesn't look like a very useful function, BUT is useful for 
        /// fraud detection, where a high number of cycle in a financial graph
        /// can indicate money laundering.
        /// </remarks>
        public static async IAsyncEnumerable<HiperEdge> CycleAsync
            (Node root
            , Route route
            , int? length = null
            , [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            if (root?.SetSpace?.Space?.CalculationGPU is not null)
            {
                await foreach (var row in root.SetSpace.Space.CalculationGPU.CycleAsync
                    (root
                    , route
                    , length
                    , cancellationToken))
                {
                    yield return row;
                }
            }
            else
            {
                var map = new RouteMap(route);
                var channel = Channel.CreateUnbounded<Result<HiperEdge>>();
                Dispatch dispatched = new Dispatch();

                HashSet<HiperEdge> result = new HashSet<HiperEdge>();
                if (root?.Froms is not null)
                {
                    foreach (var edge in root.Froms)
                    {
                        if (edge is not null)
                        {
                            dispatched.Increment();
                            _ = Task.Run(async () =>
                            {
                                try
                                {
                                    await CycleRoutes(root, map, edge, null, length, 0, channel, dispatched, cancellationToken);
                                }
                                finally
                                {
                                    await channel.Writer.WriteAsync(Result.EOF<HiperEdge>());
                                }
                            });
                        }
                    }
                }
                if (!dispatched.EOF)
                {
                    await foreach (var item in channel.Reader.ReadAllAsync())
                    {
                        if (item.Ok)
                        {
                            yield return item.Value;
                        }
                        else if (item.EOF)
                        {
                            dispatched.Decrement();
                            if (dispatched.EOF)
                                break;
                        }
                    }
                }
            }
        }

        static async Task CycleRoutes
            ( Node root
            , RouteMap route
            , Edge edge
            , HiperEdge? source
            , int? length
            , int recursion
            , Channel<Result<HiperEdge>> channel
            , Dispatch dispatched
            , CancellationToken cancellationToken = default)
        {
            var path = new HiperEdge
            {
                From = root,
                To = edge.To,
                Source = source,
                Edge = edge,
                TypeName = route.Name,
                Length = source?.Length + 1 ?? 1,
                Width = 1
            };
            if (root == edge.To)
            {
                await channel.Writer.WriteAsync(Result.Ok(path));
            }
            else if (edge is null ||
                recursion >= length ||
                edge.InPath(source))
                return;

            var from = edge?.To?.Froms.ToArray();
            if (from is not null && from.Length > 0)
            {
                foreach (var next in from)
                {
                    if (next is not null)
                    {
                        if ((recursion + 1 <= length || length is null) && route.Match(next) == true)
                        {
                            dispatched.Increment();
                            _ = Task.Run(async () =>
                            {
                                try
                                {
                                    await CycleRoutes(root, route, next, path, length, recursion + 1, channel, dispatched, cancellationToken);
                                }
                                finally
                                {
                                    await channel.Writer.WriteAsync(Result.EOF<HiperEdge>());
                                }
                            });
                        }
                    }
                }
            }
        }
    }
}