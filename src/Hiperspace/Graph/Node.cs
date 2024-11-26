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
        internal class NodeSetSpace : SetSpace<Node>
        {

            private SetSpace<Node>[] _spaces;

            public NodeSetSpace(GraphSpace space, SetSpace<Node>[] spaces) : base(space, space)
            {
                _spaces = spaces;
            }

            #region SetSpace
            public override Result<Node> Bind(Node item, bool cache = true)
            {
                return Bind(item, true, cache);
            }

            internal Result<Node> Bind(Node item, bool itembind, bool cache = true)
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

            public override Task<Result<Node>> BindAsync(Node item, bool cache = true)
            {
                return Task.FromResult(Bind(item, cache));
            }

            private static (bool Valid, T Value) make<T>(Func<Node, T> maker, Node template) where T : Element<T>, new()
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

            public override bool IsSargable(Node template)
            {
                return template._key.IsSargable();
            }

            public override (string?, string?) Explain(Node template)
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


            public override IEnumerable<Node> Find(Node template, bool cache = true)
            {
                var result = FindAsync(template, cache).GetAsyncEnumerator();
                while (result.MoveNextAsync().GetAwaiter().GetResult())
                    yield return result.Current;
            }

            public override async IAsyncEnumerable<Node> FindAsync(Node template, bool cache = true, [EnumeratorCancellation] CancellationToken cancellationToken = default)
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

            public override IEnumerable<(Node Item, double Distance)> Nearest(Node template, Hiperspace.Vector space, Hiperspace.Vector.Method method, int limit, bool cache = true)
            {
                var result = NearestAsync(template, space, method, limit, cache).GetAsyncEnumerator();
                while (result.MoveNextAsync().GetAwaiter().GetResult())
                    yield return result.Current;
            }
            public override async IAsyncEnumerable<(Node Item, double Distance)> NearestAsync(Node template, Hiperspace.Vector space, Hiperspace.Vector.Method method, int limit, bool cache = true, [EnumeratorCancellation] CancellationToken cancellationToken = default)
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

            public override Node? Get(Node template)
            {
                for (int c = 0; c < _spaces.Length; c++)
                {
                    var result = _spaces[c].Get(template);
                    if (result != null)
                        return result;
                }
                return null;
            }
            public override Task<Node?> GetAsync(Node template)
            {
                return Task.Run(() => Get(template));
            }

            public override Node? Get<TProto>(ref TProto key)
            {
                if (key is Node.KeyType k && k.IsSargable())
                {
                    var item = new Node(k);
                    return Get(item);
                }
                return null;
            }

            public override void UnionWith(IEnumerable<Node> other)
            {
                foreach (var i in other)
                    Bind(i);
            }
            #endregion
        }
    }

    #endregion
}