// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    /// <summary>
    /// Utility class to help the comparison of List<> in element keys
    /// </summary>
    public static class ComparableExtension
    {

        /// <summary>
        /// A Temporary value to facilitate comparison functions of List<> item in keys
        /// elements.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list. Must implement <see cref="IComparable{T}"/>.</typeparam>
        public struct ComparableList<T> : IComparable<ComparableList<T>>, IEquatable<ComparableList<T>> where T : IComparable<T>
        {
            public List<T>? Value;
            public ComparableList(List<T>? value)
            {
                Value = value;
            }
            public static bool operator >(ComparableList<T> left, ComparableList<T> right)
            {
                if (left.Value is null || right.Value is null) return false;
                return left.CompareTo(right) > 0;
            }
            public static bool operator <(ComparableList<T> left, ComparableList<T> right)
            {
                if (left.Value is null || right.Value is null) return false;
                return left.CompareTo(right) < 0;
            }
            public static bool operator ==(ComparableList<T> left, ComparableList<T> right)
            {
                if (left.Value is null || right.Value is null) return false;
                return left.CompareTo(right) == 0;
            }
            public static bool operator !=(ComparableList<T> left, ComparableList<T> right)
            {
                if (left.Value is null || right.Value is null) return false;
                return left.CompareTo(right) != 0;
            }

            public bool Equals(ComparableList<T> other)
            {
                return CompareTo(other) == 0;
            }
            public override bool Equals(object? obj)
            {
                if (obj is ComparableList<T> other) return this == other;
                return false;
            }
            public override int GetHashCode()
            {
                HashCode hc = new HashCode();
                if (Value != null)
                    foreach (var item in Value)
                        hc.Add(item);
                return hc.ToHashCode();
            }

            /// <summary>
            /// Compare the list using value semantics  
            /// </summary>
            /// <param name="other"></param>
            /// <returns></returns>
            public int CompareTo(ComparableList<T> other)
            {
                var len = Value!.Count < other.Value!.Count ? Value.Count : other.Value.Count;
                for (int c = 0; c < len; c++)
                {
                    var cmp = Value[c].CompareTo(other.Value[c]);
                    if (cmp != 0) return cmp;
                }
                if (Value!.Count == other.Value!.Count) return 0;
                return Value!.Count - other.Value!.Count;
            }
        }
        public static ComparableList<T> Comparable<T>(this List<T>? list) where T : IComparable<T>
        {
            return new ComparableList<T>(list);
        }
        public static ComparableList<ComparableList<T>> Comparable<T>(this List<List<T>>? list) where T : IComparable<T>
        {
            return new ComparableList<ComparableList<T>>(list?.Select(i => i.Comparable()).ToList());
        }
        public static ComparableList<ComparableList<ComparableList<T>>> Comparable<T>(this List<List<List<T>>>? list) where T : IComparable<T>
        {
            return new ComparableList<ComparableList<ComparableList<T>>>(list?.Select(i => i.Comparable()).ToList());
        }
    }
}
