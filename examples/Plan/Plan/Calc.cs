using Hiperspace;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.ExceptionServices;

namespace Plan
{
    public static class Calc
    {
        public static decimal Hours(DateTime? Start, DateTime? End)
        {
            if (Start == null || End == null)
                return 0;

            TimeSpan diff;
            if (Start.Value < End.Value)
                diff = (End.Value - Start.Value);
            else
                diff = (Start.Value - End.Value);

            return
                (diff.Days * 24) +
                diff.Hours +
                (new decimal(diff.Minutes) / 60m);
        }

        public static decimal? ZeroNull (decimal? value)
       {
            if (value == null)
                return 0m;
            return value;
        }

        public static T First<T>(RefSet<T> values ) where T : Element<T>, new()
        {
            return values.First();
        }
    }
}
