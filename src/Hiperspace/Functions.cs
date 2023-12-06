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
            foreach (var item in source)
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
            foreach (var item in source)
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
            foreach (var item in source)
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
            foreach (var item in source)
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
            foreach (var item in source)
            {
                T result = func(item);
                if (result != null && returner != null)
                {
                    returner = returner + T.One;
                }
            }
            return returner ?? T.Zero;
        }
    }
}
