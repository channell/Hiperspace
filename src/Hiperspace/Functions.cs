// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace Hiperspace
{
    public static class Functions
    {
        public static T Sum<T, S>(IEnumerable<S>? source, Func<S, T> func)
            where T : INumber<T>, new()
        {
            T result = T.Zero;
            if (source is not null)
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
            if (source is not null)
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
            if (source is not null)
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
            if (source is not null)
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
            if (source is not null)
                foreach (var item in source.ToArray())
                {
                    T result = func(item);
                    if (result is not null && returner is not null)
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
                    if (last is not null) result -= func(item);
                    result += func(item);
                }
                return result;
            }
            else if (source is not null)
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
                    if (last is not null) result = T.Max(result, func(item));
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
            else if (source is not null)
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
                    if (last is not null) result = T.Min(result, func(item));
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
            else if (source is not null)
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
                    if (last is not null) result -= T.One;
                    if (result is not null && returner is not null)
                    {
                        returner = returner + T.One;
                    }
                }
                return returner ?? T.Zero;
            }
            else if (source is not null)
                return Sum(source, func);
            return T.Zero;
        }

        public static T? First<T>(SetSpace<T> source)
            where T : Element<T>, new()
        {
            if (source is not null)
            {
                return source.GetFirst();
            }
            return null;
        }
        public static T? Last<T>(SetSpace<T> source)
            where T : Element<T>, new()
        {
            if (source is not null)
            {
                return source.GetLast();
            }
            return null;
        }

        public static IEnumerable<TDrill> DrillDown<TDrill, TEntity>(ICubeFact source, TEntity? target, RefSet<TDrill> drilldown)
            where TEntity : Element<TEntity>, ICubeDimension, new()
            where TDrill : Element<TDrill>, new()
        {
            // if the dimension already has a value, get any drilldown values of the same type
            if (target is not null)
            {
                foreach (var row in drilldown)
                {
                    var fact = row as ICubeDrillDown;
                    if (fact?.To?.CubeSlice == source.CubeSlice)
                    {
                        yield return row;
                    }
                }
            }
            // if the dimension is empty, get drilldown values adding the slice id
            else
            {
                var template = new TEntity() as ICubeDimension;
                var parts = source.CubeSlice?.Split(',') ?? Array.Empty<string>();
                var newParts = new int[parts.Length + 1];
                for (int c = 1; c < newParts.Length; c++)
                {
                    if (int.TryParse(parts[c - 1], out int part))
                    {
                        newParts[c] = part;
                    }
                }
                newParts[0] = int.Parse(template.CubeSlice);
                Array.Sort(newParts);
                var slice = String.Join(',', newParts);

                foreach (var row in drilldown)
                {
                    var fact = row as ICubeDrillDown;
                    if (fact?.To?.CubeSlice == slice)
                    {
                        yield return row;
                    }
                }
            }
        }

        /// <summary>
        /// Get the name of a cube observation based on the dimensions provided
        /// </summary>
        /// <param name="dimensions">dimensions to the cube</param>
        /// <returns></returns>
        public static string CubeName(params ICubeDimension?[]? dimensions)
        {
            StringBuilder sb = new StringBuilder();
            if (dimensions  is null || dimensions.Length == 0) return string.Empty;
            for (int i = 0; i < dimensions.Length; i++)
            {
                if (dimensions[i]  is null)
                    continue;
                else
                {
                    if (sb.Length > 0)
                        sb.Append(',');
                    sb.Append($"{dimensions[i]?.CubeName}:{dimensions[i]?.SKey}");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Retrieves the context label associated with the SubSpace of the specified element.
        /// </summary>
        /// <typeparam name="T">The type of the element, which must inherit from <see cref="Element{T}"/></typeparam>
        /// <param name="t">The element instance for which to retrieve the context label</param>
        /// <returns>The context label of the specified element if any</returns>
        public static string? ContextLabel<T>(T? t) where T : Element<T>, new()
        {
            return t?.SetSpace?.Space?.ContextLabel;
        }

        /// <summary>
        /// Make a reference to a Node defined in another database
        /// </summary>
        /// <param name="skey">The SKey of the external node</param>
        /// <returns>An external node with the specified SKey, or null if the SKey is missing</returns>
        public static Node? ExternalNode (string? skey)
        {
            if (string.IsNullOrWhiteSpace(skey)) return null;
            return new Node { SKey = skey };
        }
    }
}
