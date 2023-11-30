using Microsoft.EntityFrameworkCore;
using Sparx.EA;
using System.Numerics;
using System.Security.Cryptography;

namespace Hiperspace.Sparx
{
    internal static class Helper
    {
        public static int Count<T, S>(RefSet<S> source, Func<S, T> func)
            where S : Element<S>, new()
        {
            return source.Count();
        }
    }
 }
