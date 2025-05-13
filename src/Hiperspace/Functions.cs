// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Diagnostics;
using System.Numerics;

namespace Hiperspace
{
    public static class Functions
    {
        public static T Sum<T, S>(IEnumerable<S>? source, Func<S, T> func)
            where T : INumber<T>, new()
        {
            T result = T.Zero;
            if (source != null)
                foreach (var item in source.ToArray())
                {
                    result += func(item);
                }
            return result;
        }
        public static T Avg<T, S>(IEnumerable<S>? source, Func<S, T> func)
            where T : INumber<T>, new()
        {
            T result = T.Zero;
            T count = T.Zero;
            if (source != null)
                foreach (var item in source.ToArray())
                {
                    result += func(item);
                    count++;
                }
            return result / count;
        }
        public static T Max<T, S>(IEnumerable<S>? source, Func<S, T> func)
            where T : INumber<T>, new()
        {
            bool first = true;
            T returner = T.Zero;
            if (source != null)
                foreach (var item in source.ToArray())
                {
                    T result = func(item);
                    if (first)
                    {
                        first = false;
                        returner = result;
                    }
                    else
                    {
                        returner = T.Max(result, returner);
                    }
                }
            return returner;
        }
        public static T Min<T, S>(IEnumerable<S>? source, Func<S, T> func)
            where T : INumber<T>, new()
        {
            bool first = true;
            T returner = T.Zero;
            if (source != null)
                foreach (var item in source.ToArray())
                {
                    T result = func(item);
                    if (first)
                    {
                        first = false;
                        returner = result;
                    }
                    else
                    {
                        returner = T.Min(result, returner);
                    }
                }
            return returner;
        }
        public static T Count<T, S>(IEnumerable<S>? source, Func<S, T> func)
            where T : INumber<T>, new()
        {
            T returner = T.Zero;
            if (source != null)
                foreach (var item in source.ToArray())
                {
                    T result = func(item);
                    if (result != null && returner != null)
                    {
                        returner = returner + T.One;
                    }
                }
            return returner ?? T.Zero;
        }
        public static T DeltaSum<T, S>(RefSet<S> source, Func<S, T> func)
            where S : ElementVersion<S>, new()
            where T : INumber<T>, new()
        {
            if (source?.SetSpace is SetSpaceVersion<S> versionspace && versionspace.DeltaFrom.HasValue)
            {
                T result = T.Zero;
                foreach (var item in source.ToArray())
                {
					var last = versionspace?.Get(item, item!.SetSpace!.Space.DeltaFrom);
					// subtract the prior value if exits to allow the sum to provide the delta
                    if (last != null) result -= func(item);
                    result += func(item);
                }
                return result;
            }
            else if (source != null)
                return Sum(source, func);
            return T.Zero;
        }
        public static T DeltaMax<T, S>(RefSet<S> source, Func<S, T> func)
            where S : ElementVersion<S>, new()
            where T : INumber<T>, new()
        {
            if (source?.SetSpace is SetSpaceVersion<S> versionspace && versionspace.DeltaFrom.HasValue)
            {
                bool first = true;

                T returner = T.Zero;
                foreach (var item in source.ToArray())
                {
                    T result = func(item);
                    var last = versionspace?.Get(item, item!.SetSpace!.Space.DeltaFrom);
                    // subtract the prior value if exits to allow the sum to provide the delta
                    if (last != null) result = T.Max(result, func(item));
                    if (first)
                    {
                        first = false;
                        returner = result;
                    }
                    else
                    {
                        returner = T.Max(result, returner);
                    }
                }
                return returner;
            }
            else if (source != null) 
                return Sum(source, func);
            return T.Zero;
        }
        public static T DeltaMin<T, S>(RefSet<S> source, Func<S, T> func)
            where S : ElementVersion<S>, new()
            where T : INumber<T>, new()
        {
            if (source?.SetSpace is SetSpaceVersion<S> versionspace && versionspace.DeltaFrom.HasValue)
            {
                bool first = true;
                T returner = T.Zero;
                foreach (var item in source.ToArray())
                {
                    T result = func(item);
					var last = versionspace?.Get(item, item!.SetSpace!.Space.DeltaFrom);
					// subtract the prior value if exits to allow the sum to provide the delta
                    if (last != null) result = T.Min(result, func(item));
                    if (first)
                    {
                        first = false;
                        returner = result;
                    }
                    else
                    {
                        returner = T.Min(result, returner);
                    }
                }
                return returner;
            }
            else if (source != null) 
                return Sum(source, func);
            return T.Zero;
        }
        public static T DeltaCount<T, S>(RefSet<S> source, Func<S, T> func)
            where S : ElementVersion<S>, new()
            where T : INumber<T>, new()
        {
            if (source?.SetSpace is SetSpaceVersion<S> versionspace && versionspace.DeltaFrom.HasValue)
            {
                T returner = T.Zero;
                foreach (var item in source.ToArray())
                {
                    T result = func(item);
					var last = versionspace?.Get(item, item!.SetSpace!.Space.DeltaFrom);
					// subtract the prior value if exits to allow the sum to provide the delta
                    if (last != null) result -= T.One;
                    if (result != null && returner != null)
                    {
                        returner = returner + T.One;
                    }
                }
                return returner ?? T.Zero;
            }
            else if (source != null) 
                return Sum(source, func);
            return T.Zero;
        }

        public static T? First<T>(SetSpace<T> source)
            where T : Element<T>, new()
        {
            if (source != null)
            {
                return source.GetFirst();
            }
            return null;
        }
        public static T? Last<T>(SetSpace<T> source)
            where T : Element<T>, new()
        {
            if (source != null)
            {
                return source.GetLast();
            }
            return null;
        }
        public static string DrillDownSlice(ICubeFact fact, ICubeDimension dimension)
        {
            var parts = fact.CubeSlice?.Split(',') ?? Array.Empty<string>();
            var newParts = new string[parts.Length + 1];
            parts.CopyTo(newParts, 1);
            newParts[0] = dimension.CubeSlice;
            Array.Sort(newParts);
            return String.Join(',', newParts);
        }

        public static TDrill DrillDown<TDrill,TKey, TEntity> (ICubeFact source, KeyRef<TKey, TEntity> target, TDrill drilldown)
            where TKey : struct, IEquatable<TKey>, IComparable<TKey>
            where TEntity : Element<TEntity>, new()
        {
            if (target.Value != null)
            {
                var routes = 
                    source.SubSpace.Routes
                    .Where

            }
        }    
    }
}
