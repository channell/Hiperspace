// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf;
using System.Numerics;
using System.Runtime.CompilerServices;
using TP = System.Numerics.Tensors.TensorPrimitives;

namespace Hiperspace
{

    [ProtoContract]
    public partial struct Vector
    {
        public enum Method
        {
            Distance = 0,
            Dot = 1,
            Cosine = 2
        }

        [ProtoMember(1)] public Int32[]? Ints;      // protobuf varint
        [ProtoMember(2)] public float[]? Floats;
        [ProtoMember(3)] public double[]? Doubles;

        public Vector()
        {
        }
        public Vector(int[] ints)
        {
            Ints = ints;
        }
        public Vector(float[] floats)
        {
            Floats = floats;
        }
        public Vector(double[] doubles)
        {
            Doubles = doubles;
            Float();
        }

        public bool IsInt(int l)
        {
            if (Ints is null || Ints.Length != l)
                return false;
            return true;
        }

        public bool IsFloat(int l)
        {
            if (Floats is null || Floats.Length != l)
                return false;
            return true;
        }
        public bool IsDouble(int l)
        {
            if (Doubles is null || Doubles.Length != l)
                return false;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Float()
        {
            switch (Ints is not null, Floats is not null, Doubles is not null)
            {
                case (_, true, _): return Floats!.Length == 0 ? false : true;
                case (_, _, true):
                    {
                        if (Doubles!.Length == 0) return false;
                        var floats = new float[Doubles!.Length];
                        for (int c = 0; c < Doubles.Length; c++)
                        {
                            if (Doubles[c] < float.MinValue || Doubles[c] > float.MaxValue)
                                return false;
                            floats[c] = (float)Doubles[c];
                        }
                        Floats = floats;
                        Doubles = null;
                        Ints = null;
                        return true;
                    }
                case (true, _, _):
                    {
                        if (Ints!.Length == 0) return false;
                        var floats = new float[Ints!.Length];
                        for (int c = 0; c < Ints.Length; c++)
                        {
                            floats[c] = (float)Ints[c];
                        }
                        Floats = floats;
                        Doubles = null;
                        Ints = null;
                        return true;
                    }
            }
            return false;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Double()
        {
            switch (Ints is not null, Floats is not null, Doubles is not null)
            {
                case (_, _, true): return;
                case (_, true, _):
                    {
                        var doubles = new double[Floats!.Length];
                        for (int c = 0; c < Floats.Length; c++)
                            doubles[c] = Floats[c];
                        Doubles = doubles;
                        Floats = null;
                        Ints = null;
                        return;
                    }
                case (true, _, _):
                    {
                        var doubles = new double[Ints!.Length];
                        for (int c = 0; c < Ints.Length; c++)
                            doubles[c] = Ints[c];
                        Doubles = doubles;
                        Floats = null;
                        Ints = null;
                        return;
                    }
            }
        }
        public void Compress()
        {
            switch (Ints is not null, Floats is not null, Doubles is not null)
            {
                case (true, _, _):
                    {
                        Floats = null;
                        Doubles = null;
                        return;
                    }
                case (_, true, _):
                    {
                        var ints = new Int32[Floats!.Length];
                        for (int c = 0; c < Floats.Length; c++)
                        {
                            if (Floats[c] < Int32.MinValue || Floats[c] > Int32.MaxValue)
                            {
                                Ints = null;
                                Doubles = null;
                                return;
                            }

                            ints[c] = (Int32)Floats[c];
                        }
                        Ints = ints;
                        Floats = null;
                        Doubles = null;
                        return;
                    }
                case (_, _, true):
                    {
                        var floats = new float[Doubles!.Length];
                        for (int c = 0; c < Doubles.Length; c++)
                        {
                            if (Doubles[c] < float.MinValue || Doubles[c] > float.MaxValue)
                            {
                                Ints = null;
                                Floats = null;
                                return;
                            }

                            floats[c] = (float)Doubles[c];
                        }
                        Floats = floats;
                        Doubles = null;
                        Ints = null;
                        return;
                    }
            }
        }

        /// <summary>
        /// Align the type of this vector with the other vector with a preference for float
        /// </summary>
        /// <param name="other"></param>
        public void Align(ref Vector other)
        {
            switch ((Ints is not null, Floats is not null, Doubles is not null),
                    (other.Ints is not null, other.Floats is not null, other.Doubles is not null))
            {
                // same
                case ((true, _, _), (true, _, _)): return;
                case ((_, true, _), (_, true, _)): return;
                case ((_, _, true), (_, _, true)): return;
                // narrow other or expand this
                case ((_, true, _), (_, _, true)):
                    {
                        if (other.Float()) return;
                        Double();
                        return;
                    }
                // other is int, expand it
                case ((_, true, _), (_, _, _)):
                    {
                        if (other.Float()) return;
                        Double();
                        other.Double();
                        return;
                    }
                // narrow this or expand other
                case ((_, _, true), (_, true, _)):
                    {
                        if (Float()) return;
                        other.Double();
                        return;
                    }
                // expand other int
                case ((_, _, true), (_, _, _)):
                    {
                        if (Float() && other.Float()) return;
                        other.Double();
                        return;
                    }
                // expand int
                case ((_, _, _), (_, true, _)):
                    {
                        if (Float()) return;
                        Double();
                        other.Double();
                        return;
                    }
                case ((_, _, _), (_, _, true)):
                    {
                        if (Float() && other.Float()) return;
                        Double();
                        return;
                    }
            }
        }

        /// <summary>
        /// Calculate the distance from two vectors
        /// </summary>
        /// <param name="other">the search vector</param>
        /// <param name="method">distance method</param>
        /// <returns>distance using method</returns>
        /// <remarks>as other is the search criteria, cast to wider if needed</remarks>
        public double? Nearest(Vector other, Method method)
        {
            if (Float())
            {
                if (!(other.Float()) || Floats!.Length != other.Floats!.Length)
                    return null;
                switch (method)
                {
                    case Method.Dot:
                        return TP.Dot(Floats, other.Floats);

                    case Method.Cosine:
                        return TP.CosineSimilarity(Floats, other.Floats);

                    case Method.Distance:
                    default:
                        return TP.Distance(Floats, other.Floats);
                }
            }
            return null;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Bind(SubSpace space)
        {

        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Unbind(SubSpace space)
        {

        }
        public bool Equals(Vector other)
        {
            if (this == other) return true;
            return false;
        }
        public override bool Equals(Object? other)
        {
            if (other is null) return false;
            if (other is Vector) return Equals((Vector)other);
            return false;
        }
        public override int GetHashCode()
        {
            HashCode hc = new HashCode();
            hc.Add(Ints);
            hc.Add(Floats);
            hc.Add(Doubles);
            return hc.ToHashCode();
        }

        public int CompareTo(Vector other)
        {
            if (this < other) return -1;
            if (this > other) return 1;
            return 0;
        }
        public static bool operator ==(Vector left, Vector right)
        {
            left.Align(ref right);
            if (left.Ints is not null && right.Ints is not null)
            {
                if (left.Ints.Length != right.Ints.Length)
                    return false;
                for (int c = 0; c < left.Ints.Length; c++)
                {
                    var eq = left.Ints[c] == right.Ints[c];
                    if (!eq) return false;
                }
            }
            else if (left.Floats is not null && right.Floats is not null)
            {
                if (left.Floats.Length != right.Floats.Length)
                    return false;
                for (int c = 0; c < left.Floats.Length; c++)
                {
                    var eq = left.Floats[c] == right.Floats[c];
                    if (!eq) return false;
                }
            }
            else if (left.Doubles is not null && right.Doubles is not null)
            {
                if (left.Doubles.Length != right.Doubles.Length)
                    return false;
                for (int c = 0; c < left.Doubles.Length; c++)
                {
                    var eq = left.Doubles[c] == right.Doubles[c];
                    if (!eq) return false;
                }
            }
            return true;
        }
        public static bool operator !=(Vector left, Vector right)
        {
            return !(left == right);
        }
        public static bool operator <(Vector left, Vector right)
        {
            left.Align(ref right);
            if (left.Ints is not null && right.Ints is not null)
            {
                if (left.Ints.Length != right.Ints.Length)
                    return false;
                for (int c = 0; c < left.Ints.Length; c++)
                {
                    var cmp = left.Ints[c] < right.Ints[c];
                    if (!cmp) return false;
                }
            }
            else if (left.Floats is not null && right.Floats is not null)
            {
                if (left.Floats.Length != right.Floats.Length)
                    return false;
                for (int c = 0; c < left.Floats.Length; c++)
                {
                    var cmp = left.Floats[c] < right.Floats[c];
                    if (!cmp) return false;
                }
            }
            else if (left.Doubles is not null && right.Doubles is not null)
            {
                if (left.Doubles.Length != right.Doubles.Length)
                    return false;
                for (int c = 0; c < left.Doubles.Length; c++)
                {
                    var cmp = left.Doubles[c] < right.Doubles[c];
                    if (!cmp) return false;
                }
            }
            return true;
        }
        public static bool operator >(Vector left, Vector right)
        {
            left.Align(ref right);
            if (left.Ints is not null && right.Ints is not null)
            {
                if (left.Ints.Length != right.Ints.Length)
                    return false;
                for (int c = 0; c < left.Ints.Length; c++)
                {
                    var cmp = left.Ints[c] > right.Ints[c];
                    if (!cmp) return false;
                }
            }
            else if (left.Floats is not null && right.Floats is not null)
            {
                if (left.Floats.Length != right.Floats.Length)
                    return false;
                for (int c = 0; c < left.Floats.Length; c++)
                {
                    var cmp = left.Floats[c] > right.Floats[c];
                    if (!cmp) return false;
                }
            }
            else if (left.Doubles is not null && right.Doubles is not null)
            {
                if (left.Doubles.Length != right.Doubles.Length)
                    return false;
                for (int c = 0; c < left.Doubles.Length; c++)
                {
                    var cmp = left.Doubles[c] > right.Doubles[c];
                    if (!cmp) return false;
                }
            }
            return true;
        }

        // Element-wise arithmetic using System.Numerics.Tensors.TensorPrimitives (float-based)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector operator +(Vector left, Vector right)
        {
            left.Align(ref right);
            switch (left.Ints is not null, left.Floats is not null, left.Doubles is not null)
            {
                case (_, true, _):
                    {
                        if (right.Floats is null) return new Vector();
                        if (left.Floats!.Length != right.Floats.Length) return new Vector();

                        var dest = new float[left.Floats.Length];
                        TP.Add(left.Floats.AsSpan(), right.Floats.AsSpan(), dest.AsSpan());
                        return new Vector(dest);
                    }
                case (_, _, true):
                    {
                        if (right.Doubles is null) return new Vector();
                        if (left.Doubles!.Length != right.Doubles.Length) return new Vector();

                        var dest = new double[left.Doubles.Length];
                        for (int c = 0; c < dest.Length; c++)
                            dest[c] = left.Doubles[c] + right.Doubles[c];
                        return new Vector(dest);
                    }
                case (true, _, _):
                    {
                        if (right.Ints is null) return new Vector();
                        if (left.Ints!.Length != right.Ints.Length) return new Vector();

                        var dest = new Int32[left.Ints.Length];
                        for (int c = 0; c < dest.Length; c++)
                            dest[c] = left.Ints[c] + right.Ints[c];
                        return new Vector(dest);
                    }
            }
            return new Vector();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector operator -(Vector left, Vector right)
        {
            left.Align(ref right);
            switch (left.Ints is not null, left.Floats is not null, left.Doubles is not null)
            {
                case (_, true, _):
                    {
                        if (right.Floats is null) return new Vector();
                        if (left.Floats!.Length != right.Floats.Length) return new Vector();

                        var dest = new float[left.Floats.Length];
                        TP.Subtract(left.Floats.AsSpan(), right.Floats.AsSpan(), dest.AsSpan());
                        return new Vector(dest);
                    }
                case (_, _, true):
                    {
                        if (right.Doubles is null) return new Vector();
                        if (left.Doubles!.Length != right.Doubles.Length) return new Vector();

                        var dest = new double[left.Doubles.Length];
                        for (int c = 0; c < dest.Length; c++)
                            dest[c] = left.Doubles[c] - right.Doubles[c];
                        return new Vector(dest);
                    }
                case (true, _, _):
                    {
                        if (right.Ints is null) return new Vector();
                        if (left.Ints!.Length != right.Ints.Length) return new Vector();

                        var dest = new Int32[left.Ints.Length];
                        for (int c = 0; c < dest.Length; c++)
                            dest[c] = left.Ints[c] - right.Ints[c];
                        return new Vector(dest);
                    }
            }
            return new Vector();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector operator *(Vector left, Vector right)
        {
            left.Align(ref right);
            switch (left.Ints is not null, left.Floats is not null, left.Doubles is not null)
            {
                case (_, true, _):
                    {
                        if (right.Floats is null) return new Vector();
                        if (left.Floats!.Length != right.Floats.Length) return new Vector();

                        var dest = new float[left.Floats.Length];
                        TP.Multiply(left.Floats.AsSpan(), right.Floats.AsSpan(), dest.AsSpan());
                        return new Vector(dest);
                    }
                case (_, _, true):
                    {
                        if (right.Doubles is null) return new Vector();
                        if (left.Doubles!.Length != right.Doubles.Length) return new Vector();

                        var dest = new double[left.Doubles.Length];
                        for (int c = 0; c < dest.Length; c++)
                            dest[c] = left.Doubles[c] * right.Doubles[c];
                        return new Vector(dest);
                    }
                case (true, _, _):
                    {
                        if (right.Ints is null) return new Vector();
                        if (left.Ints!.Length != right.Ints.Length) return new Vector();

                        var dest = new Int32[left.Ints.Length];
                        for (int c = 0; c < dest.Length; c++)
                            dest[c] = left.Ints[c] * right.Ints[c];
                        return new Vector(dest);
                    }
            }
            return new Vector();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector operator /(Vector left, Vector right)
        {
            left.Align(ref right);
            switch (left.Ints is not null, left.Floats is not null, left.Doubles is not null)
            {
                case (_, true, _):
                    {
                        if (right.Floats is null) return new Vector();
                        if (left.Floats!.Length != right.Floats.Length) return new Vector();

                        var dest = new float[left.Floats.Length];
                        TP.Divide(left.Floats.AsSpan(), right.Floats.AsSpan(), dest.AsSpan());
                        return new Vector(dest);
                    }
                case (_, _, true):
                    {
                        if (right.Doubles is null) return new Vector();
                        if (left.Doubles!.Length != right.Doubles.Length) return new Vector();

                        var dest = new double[left.Doubles.Length];
                        for (int c = 0; c < dest.Length; c++)
                            dest[c] = left.Doubles[c] / right.Doubles[c];
                        return new Vector(dest);
                    }
                case (true, _, _):
                    {
                        if (right.Ints is null) return new Vector();
                        if (left.Ints!.Length != right.Ints.Length) return new Vector();

                        var dest = new Int32[left.Ints.Length];
                        for (int c = 0; c < dest.Length; c++)
                            dest[c] = left.Ints[c] / right.Ints[c];
                        return new Vector(dest);
                    }
            }
            return new Vector();
        }

        // Sum of elements (uses TensorPrimitives via Dot with an ones vector)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double? Sum()
        {
            switch (Ints is not null, Floats is not null, Doubles is not null)
            {
                case (_, true, _):
                    {
                        if (Floats!.Length == 0) return null;
                        var ones = new float[Floats.Length];
                        for (int i = 0; i < ones.Length; i++) ones[i] = 1f;
                        double d = TP.Dot(Floats, ones);
                        return d;
                    }
                case (_, _, true):
                    {
                        if (Doubles!.Length == 0) return null;

                        double dest = 0.0;
                        for (int c = 0; c < Doubles.Length; c++)
                            dest += Doubles[c];
                        return dest;
                    }
                case (true, _, _):
                    {
                        if (Ints!.Length == 0) return null;

                        double dest = 0.0;
                        for (int c = 0; c < Ints.Length; c++)
                            dest += Ints[c];
                        return dest;
                    }
            }
            return null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector Sum(Vector[] vectors)
        {
            if (vectors is null || vectors.Length == 0) return new Vector();
            if (vectors.Length == 1) return vectors[0];

            // determine target length from first non-null vector (ints or floats)
            int max = 0, min = 0;
            var first = vectors[0];
            for (int c = 0; c < vectors.Length; c++)
            {
                first.Align(ref vectors[c]);
                var v = vectors[c];
                var len = v.Ints is not null ? v.Ints.Length :
                          v.Floats is not null ? v.Floats.Length :
                          v.Doubles is not null ? v.Doubles.Length : 0;

                min = min < len ? min : len;
                max = max > len ? max : len;
            }
            if (min != max) throw new ArgumentException("Vectors are not the same size");

            switch (first.Ints is not null, first.Floats is not null, first.Doubles is not null)
            {
                case (_, true, _):
                    {
                        var acc = new float[min];
                        var temp = new float[min];
                        Array.Copy(first!.Floats!, acc, min);

                        for (int c = 1; c < vectors.Length; c++)
                        {
                            var v = vectors[c];
                            // acc = acc + v.Floats  (use TP.Add -> temp then copy back)
                            TP.Add(first.Floats.AsSpan(), v.Floats.AsSpan(), temp.AsSpan());
                            Array.Copy(temp, acc, min);
                        }
                        return new Vector(acc!);
                    }
                case (_, _, true):
                    {
                        var acc = new double[min];
                        Array.Copy(first!.Doubles!, acc, min);

                        for (int c = 1; c < vectors.Length; c++)
                        {
                            var v = vectors[c];
                            for (int i = 0; i < min; i++)
                            {
                                acc[i] += v.Doubles![i];
                            }
                        }
                        return new Vector(acc!);
                    }
                case (true, _, _):
                    {
                        var acc = new Int32[min];
                        Array.Copy(first!.Ints!, acc, min);

                        for (int c = 1; c < vectors.Length; c++)
                        {
                            var v = vectors[c];
                            for (int i = 0; i < min; i++)
                            {
                                acc[i] += v.Ints![i];
                            }
                        }
                        return new Vector(acc!);
                    }
            }
            throw new ArgumentException("Vectors are not compatible");
        }

        // Return a new Vector with elements sorted ascending
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector Sort()
        {
            if (Ints is not null)
            {
                var copy = new Int32[Ints.Length];
                Array.Copy(Ints, copy, Ints.Length);
                Array.Sort(copy);
                return new Vector(copy);
            }
            else if (Floats is not null)
            {
                var copy = new float[Floats.Length];
                Array.Copy(Floats, copy, Floats.Length);
                Array.Sort(copy);
                return new Vector(copy);
            }
            else if (Doubles is not null)
            {
                var copy = new double[Doubles.Length];
                Array.Copy(Doubles, copy, Doubles.Length);
                Array.Sort(copy);
                return new Vector(copy);
            }
            return new Vector();
        }

        // Minimum element
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double? Min()
        {
            if (Ints is not null)
            {
                if (Ints.Length == 0) return null;
                if (Ints.Length == 1) return Ints[0];

                double result = Ints[0];
                for (int c = 1; c < Ints.Length; c++)
                    result = result > Ints[c] ? Ints[c] : result;
                return result;
            }
            else if (Floats is not null)
            {
                if (Floats.Length == 0) return null;
                if (Floats.Length == 1) return Floats[0];

                double result = Floats[0];
                for (int c = 1; c < Floats.Length; c++)
                    result = result > Floats[c] ? Floats[c] : result;
                return result;
            }
            else if (Doubles is not null)
            {
                if (Doubles.Length == 0) return null;
                if (Doubles.Length == 1) return Doubles[0];

                double result = Doubles[0];
                for (int c = 1; c < Doubles.Length; c++)
                    result = result > Doubles[c] ? Doubles[c] : result;
                return result;
            }
            return null;
        }

        // Maximum element
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double? Max()
        {
            if (Ints is not null)
            {
                if (Ints.Length == 0) return null;
                if (Ints.Length == 1) return Ints[0];

                double result = Ints[0];
                for (int c = 1; c < Ints.Length; c++)
                    result = result < Ints[c] ? Ints[c] : result;
                return result;
            }
            else if (Floats is not null)
            {
                if (Floats.Length == 0) return null;
                if (Floats.Length == 1) return Floats[0];

                double result = Floats[0];
                for (int c = 1; c < Floats.Length; c++)
                    result = result < Floats[c] ? Floats[c] : result;
                return result;
            }
            else if (Doubles is not null)
            {
                if (Doubles.Length == 0) return null;
                if (Doubles.Length == 1) return Doubles[0];

                double result = Doubles[0];
                for (int c = 1; c < Doubles.Length; c++)
                    result = result < Doubles[c] ? Doubles[c] : result;
                return result;
            }
            return null;
        }
        // Average of elements
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double? Average()
        {
            switch (Ints is not null, Floats is not null, Doubles is not null)
            {
                case (_, true, _):
                    {
                        if (Floats!.Length == 0) return null;
                        var ones = new float[Floats.Length];
                        for (int i = 0; i < ones.Length; i++) ones[i] = 1f;
                        double sum = TP.Dot(Floats, ones);
                        return sum / Floats.Length;
                    }
                case (_, _, true):
                    {
                        if (Doubles!.Length == 0) return null;
                        double sum = 0.0;
                        for (int c = 0; c < Doubles.Length; c++)
                            sum += Doubles[c];
                        return sum / Doubles.Length;
                    }
                case (true, _, _):
                    {
                        if (Ints!.Length == 0) return null;
                        double sum = 0.0;
                        for (int c = 0; c < Ints.Length; c++)
                            sum += Ints[c];
                        return sum / Ints.Length;
                    }
            }
            return null;
        }

        // Standard deviation (population)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double? StandardDeviation()
        {
            var avg = Average();
            if (avg is null) return null;
            double mean = avg.Value;

            switch (Ints is not null, Floats is not null, Doubles is not null)
            {
                case (_, true, _):
                    {
                        if (Floats!.Length == 0) return null;
                        double sumSquaredDiff = 0.0;
                        for (int c = 0; c < Floats.Length; c++)
                        {
                            double diff = Floats[c] - mean;
                            sumSquaredDiff += diff * diff;
                        }
                        return Math.Sqrt(sumSquaredDiff / Floats.Length);
                    }
                case (_, _, true):
                    {
                        if (Doubles!.Length == 0) return null;
                        double sumSquaredDiff = 0.0;
                        for (int c = 0; c < Doubles.Length; c++)
                        {
                            double diff = Doubles[c] - mean;
                            sumSquaredDiff += diff * diff;
                        }
                        return Math.Sqrt(sumSquaredDiff / Doubles.Length);
                    }
                case (true, _, _):
                    {
                        if (Ints!.Length == 0) return null;
                        double sumSquaredDiff = 0.0;
                        for (int c = 0; c < Ints.Length; c++)
                        {
                            double diff = Ints[c] - mean;
                            sumSquaredDiff += diff * diff;
                        }
                        return Math.Sqrt(sumSquaredDiff / Ints.Length);
                    }
            }
            return null;
        }
        /// <summary>
        /// Join (concatenate) this vector with another vector to form a new vector
        /// </summary>
        /// <param name="other">The vector to append to this vector</param>
        /// <returns>A new vector containing elements from both vectors</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector Join(Vector? other)
        {
            if (other == null) return this;
            return Join(this, other.Value);
        }

        /// <summary>
        /// Join (concatenate) two vectors to form a new vector
        /// </summary>
        /// <param name="left">The first vector</param>
        /// <param name="right">The second vector to append</param>
        /// <returns>A new vector containing elements from both vectors</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector Join(Vector left, Vector right)
        {
            left.Align(ref right);

            switch (left.Ints is not null, left.Floats is not null, left.Doubles is not null)
            {
                case (_, true, _):
                    {
                        if (right.Floats is null) return left;
                        int leftLen = left.Floats!.Length;
                        int rightLen = right.Floats.Length;
                        var result = new float[leftLen + rightLen];
                        Array.Copy(left.Floats, 0, result, 0, leftLen);
                        Array.Copy(right.Floats, 0, result, leftLen, rightLen);
                        return new Vector(result);
                    }
                case (_, _, true):
                    {
                        if (right.Doubles is null) return left;
                        int leftLen = left.Doubles!.Length;
                        int rightLen = right.Doubles.Length;
                        var result = new double[leftLen + rightLen];
                        Array.Copy(left.Doubles, 0, result, 0, leftLen);
                        Array.Copy(right.Doubles, 0, result, leftLen, rightLen);
                        return new Vector(result);
                    }
                case (true, _, _):
                    {
                        if (right.Ints is null) return left;
                        int leftLen = left.Ints!.Length;
                        int rightLen = right.Ints.Length;
                        var result = new Int32[leftLen + rightLen];
                        Array.Copy(left.Ints, 0, result, 0, leftLen);
                        Array.Copy(right.Ints, 0, result, leftLen, rightLen);
                        return new Vector(result);
                    }
            }
            return new Vector();
        }
    }

    /// <summary>
    /// Utility class to Accumulate doubles for StdDev and Percentile aggregation of Cubes
    /// instance.
    /// </summary>
    /// <remarks>The VectorAggregator class extends List<double> to provide convenient aggregation of numeric
    /// values for vector operations. An implicit conversion operator allows instances of VectorAggregator to be
    /// converted to Vector objects, enabling seamless integration with APIs that consume Vector types.</remarks>
    public class VectorAggregator : List<double>
    {
        public VectorAggregator Merge(double? item)
        {
            if (item is not null) Add(item.Value);
            return this;
        }
        public VectorAggregator Merge(decimal? item)
        {
            if (item is not null) Add(Convert.ToDouble(item.Value));
            return this;
        }
        public VectorAggregator Merge(int? item)
        {
            if (item is not null) Add(item.Value);
            return this;
        }
        public VectorAggregator Merge(long? item)
        {
            if (item is not null) Add(item.Value);
            return this;
        }

        public static implicit operator Vector(VectorAggregator aggregator)
        {
            if (aggregator == null || aggregator.Count == 0)
                return new Vector();
            var arr = aggregator.ToArray();
            return new Vector(arr);
        }
    }
}