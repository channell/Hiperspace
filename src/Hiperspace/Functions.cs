// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Numerics;

namespace Hiperspace
{
    public static class Functions
    {
        public static T Sum<T, S>(RefSet<S> source, Func<S, T> func)
            where S : Element<S>, new()
            where T : INumber<T>, new()
        {
            T result = T.Zero;
            foreach (var item in source.ToArray())
            {
                result += func(item);
            }
            return result;
        }
        public static T Avg<T, S>(RefSet<S> source, Func<S, T> func)
            where S : Element<S>, new()
            where T : INumber<T>, new()
        {
            T result = T.Zero;
            T count = T.Zero;
            foreach (var item in source.ToArray())
            {
                result += func(item);
                count++;
            }
            return result / count;
        }
        public static T Max<T, S>(RefSet<S> source, Func<S, T> func)
            where S : Element<S>, new()
            where T : INumber<T>, new()
        {
            bool first = true;
            T returner = T.Zero;
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
        public static T Min<T, S>(RefSet<S> source, Func<S, T> func)
            where S : Element<S>, new()
            where T : INumber<T>, new()
        {
            bool first = true;
            T returner = T.Zero;
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
        public static T Count<T, S>(RefSet<S> source, Func<S, T> func)
            where S : Element<S>, new()
            where T : INumber<T>, new()
        {
            T returner = T.Zero;
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
                    var last = versionspace?.Get(item, item.AsAt.AddMilliseconds(-1));
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
                    var last = versionspace?.Get(item, item.AsAt.AddMilliseconds(-1));
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
                    var last = versionspace?.Get(item, item.AsAt.AddMilliseconds(-1));
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
                    var last = versionspace?.Get(item, item.AsAt.AddMilliseconds(-1));
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
    }
}
