using Hiperspace;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Acc
{
    internal static class Totals
    {
        public static Decimal? Credit(Decimal? source)
        {
            if ((source ?? 0.0m) > 0.0m)
                return source;
            else
                return 0.0m;
        }
        public static Decimal? Debit(Decimal? source)
        {
            if ((source ?? 0.0m) < 0.0m)
                return source;
            else
                return 0.0m;
        }
    }
}