// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Hiperspace;
using ProtoBuf;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Hiperspace.Graph
{
    #region Internal

    namespace Internal
    {
        internal class EdgeSetSpace : SetSpace<Edge>
        {
            private SetSpace<Edge>[] _spaces;

            public EdgeSetSpace(GraphSpace space, SetSpace<Edge>[] spaces) : base(space, space)
            {
                _spaces = spaces;
            }

            #region SetSpace
            public override Result<Edge> Bind(Edge item, bool cache = true)
            {
                return Bind(item, true, cache);
            }

            internal Result<Edge> Bind(Edge item, bool itembind, bool cache = true)
            {

                if (Filter(item).Fail)
                    return Result.Fail(item);
                if (item.SetSpace != this && cache)
                {
                    if (!base.Bind(item, cache).Skip && itembind)
                        return item.Bind(Space);
                }
                return Result.Ok(item);
            }

            public override Task<Result<Edge>> BindAsync(Edge item, bool cache = true)
            {
                return Task.FromResult(Bind(item, cache));
            }

            private static (bool Valid, T Value) make<T>(Func<Edge, T> maker, Edge template) where T : Element<T>, new()
            {
                try
                {
                    return (true, maker(template));
                }
                catch (ArgumentException)
                {
                    return (false, new T());
                }
            }

            public override bool IsSargable(Edge template)
            {
                return template._key.IsSargable();
            }

            public override (string?, string?) Explain(Edge template)
            {
                var result = string.Empty;
                if (IsSargable(template))
                {
                    for (int c = 0; c < _spaces.Length; c++)
                    {
                        var (area, message) = _spaces[c].Explain(template);
                        if (area != "Scan") result += $", {area} {message}";
                    }
                    return ("Union", result == string.Empty ? string.Empty : result.Substring(2));
                }
                else
                {
                    for (int c = 0; c < _spaces.Length; c++)
                    {
                        var (area, message) = _spaces[c].Explain(template);
                    }
                    return ("Union", result == string.Empty ? string.Empty : result.Substring(2));
                }
            }


            public override IEnumerable<Edge> Find(Edge template, bool cache = true)
            {
                var result = FindAsync(template, cache).GetAsyncEnumerator();
                while (result.MoveNextAsync().GetAwaiter().GetResult())
                    yield return result.Current;
            }

            public override async IAsyncEnumerable<Edge> FindAsync(Edge template, bool cache = true, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                var all = !template._key.IsSargable();

                {
                    var returner = new List<Node>();
                    for (int c = 0; c < _spaces.Length; c++)
                    {
                        await foreach (var item in _spaces[c].FindAsync(template, cache, cancellationToken))
                        {
                            var result = Bind(item, cache);
                            if (result.Ok)
                                yield return result.Value;
                        }
                    }
                }
            }

            public override IEnumerable<(Edge Item, double Distance)> Nearest(Edge template, Hiperspace.Vector space, Hiperspace.Vector.Method method, int limit, bool cache = true)
            {
                var result = NearestAsync(template, space, method, limit, cache).GetAsyncEnumerator();
                while (result.MoveNextAsync().GetAwaiter().GetResult())
                    yield return result.Current;
            }
            public override async IAsyncEnumerable<(Edge Item, double Distance)> NearestAsync(Edge template, Hiperspace.Vector space, Hiperspace.Vector.Method method, int limit, bool cache = true, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                var all = !template._key.IsSargable();

                {
                    var returner = new List<(Node Item, double Distance)>();
                    for (int c = 0; c < _spaces.Length; c++)
                    {
                        await foreach (var item in _spaces[c].NearestAsync(template, space, method, limit, cache, cancellationToken))
                        {
                            var result = Bind(item.Item, cache);
                            if (result.Ok)
                                yield return (result.Value, item.Distance);
                        }
                    }
                }
            }

            public override Edge? Get(Edge template)
            {
                for (int c = 0; c < _spaces.Length; c++)
                {
                    var result = _spaces[c].Get(template);
                    if (result != null)
                        return result;
                }
                return null;
            }
            public override Task<Edge?> GetAsync(Edge template)
            {
                return Task.Run(() => Get(template));
            }

            public override Edge? Get<TProto>(ref TProto key)
            {
                if (key is Edge.KeyType k && k.IsSargable())
                {
                    var item = new Edge(k);
                    return Get(item);
                }
                return null;
            }

            public override void UnionWith(IEnumerable<Edge> other)
            {
                foreach (var i in other)
                    Bind(i);
            }
            #endregion
        }
    }

    #endregion
}