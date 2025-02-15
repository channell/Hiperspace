// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Hiperspace;
using ProtoBuf;
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

        public bool IsInt(int l)
        {
            if (Ints == null || Ints.Length != l)
                return false;
            return true;
        }

        public bool IsFloat(int l)
        {
            if (Floats == null || Floats.Length != l)
                return false;
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Float()
        {
            if (Ints != null && Floats == null)
            {
                Floats = new float[Ints.Length];
                for (int c = 0; c < Ints.Length; c++)
                {
                    Floats[c] = Ints[c];
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
        public double? Nearest (Vector other, Method method)
        {
            Float();

            if (Floats != null)
            {
                if (Floats.Length == 0 || other.Floats == null || Floats.Length != other.Floats.Length)
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
            if (other == null) return false;
            if (other is Vector) return Equals((Vector)other);
            return false;
        }
        public override int GetHashCode()
        {
            HashCode hc = new HashCode();
            hc.Add(Ints);
            hc.Add(Floats);
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
            if (left.Ints != null && right.Ints != null)
            {
                if (left.Ints.Length != right.Ints.Length) 
                    return false;
                for (int c = 0; c < left.Ints.Length; c++)
                {
                    var eq = left.Ints[c] == right.Ints[c];
                    if (!eq) return false;
                }
            }
            else if (left.Floats != null && right.Floats != null)
            {
                if (left.Floats.Length != right.Floats.Length)
                    return false;
                for (int c = 0; c < left.Floats.Length; c++)
                {
                    var eq = left.Floats[c] == right.Floats[c];
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
            if (left.Ints != null && right.Ints != null)
            {
                if (left.Ints.Length != right.Ints.Length)
                    return false;
                for (int c = 0; c < left.Ints.Length; c++)
                {
                    var cmp = left.Ints[c] < right.Ints[c];
                    if (!cmp) return false;
                }
            }
            else if (left.Floats != null && right.Floats != null)
            {
                if (left.Floats.Length != right.Floats.Length)
                    return false;
                for (int c = 0; c < left.Floats.Length; c++)
                {
                    var cmp = left.Floats[c] < right.Floats[c];
                    if (!cmp) return false;
                }
            }
            return true;
        }
        public static bool operator >(Vector left, Vector right)
        {
            if (left.Ints != null && right.Ints != null)
            {
                if (left.Ints.Length != right.Ints.Length)
                    return false;
                for (int c = 0; c < left.Ints.Length; c++)
                {
                    var cmp = left.Ints[c] > right.Ints[c];
                    if (!cmp) return false;
                }
            }
            else if (left.Floats != null && right.Floats != null)
            {
                if (left.Floats.Length != right.Floats.Length)
                    return false;
                for (int c = 0; c < left.Floats.Length; c++)
                {
                    var cmp = left.Floats[c] > right.Floats[c];
                    if (!cmp) return false;
                }
            }
            return true;
        }
    }
}
