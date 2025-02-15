// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Hiperspace
{
    /// <summary>
    /// Represents a thread-safe collection of unique elements.
    /// locks are applied at the segment level, allowing for concurrent operations (add, remove, replace) on different segments.
    /// chained operations only lock the current segment. Set level operations during enumeration are deferred to enumeration has completed
    /// </summary>
    /// <typeparam name="T">The type of elements in the set.</typeparam>
    public class ConcurrentHashSet<T> : ISet<T> where T : class
    {
        private HashSet<T> _segment = new HashSet<T>();
        private SpinLock Lock = new SpinLock();
        private long SetSemaphore = 0;
        private ConcurrentHashSet<T>? _next = null;
        private event Action? PostMerge;

        /// <summary>
        /// Gets the next segment of the concurrent hash set.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ConcurrentHashSet<T> GetNext()
        {
            if (_next == null)
                _next = new ConcurrentHashSet<T>();
            return _next;
        }

        /// <summary>
        /// Merges the next segment into the current segment.
        /// Any item level additions are posted to the next set, and merged into 
        /// the current set when all set operations are complete.
        /// </summary>
        private bool Merge()
        {
            if (Interlocked.Read(ref SetSemaphore) == 0)
            {
                if (_next != null)
                {
                    bool taken = false;
                    try
                    {
                        Lock.Enter(ref taken);
                        if (_next.Merge())
                        {
                            _segment.UnionWith(_next._segment);
                            _next = null;
                        }
                        else
                            return false;
                    }
                    finally
                    {
                        if (PostMerge != null)
                        {
                            PostMerge();
                            PostMerge = null;
                        }
                        if (taken) Lock.Exit();
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Gets the number of elements contained in the set.
        /// </summary>
        public int Count => ((ICollection<T>)_segment).Count + (_next?.Count ?? 0);

        /// <summary>
        /// Gets a value indicating whether the set is read-only.
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// Adds an element to the set.
        /// </summary>
        /// <param name="item">The element to add to the set.</param>
        /// <returns>true if the element is added to the set; otherwise, false.</returns>
        public bool Add(T item)
        {
            if (Interlocked.Read(ref SetSemaphore) > 0)
                return GetNext().Add(item);
            else
            {
                bool taken = false;
                try
                {
                    Lock.Enter(ref taken);
                    return _segment.Add(item);
                }
                finally
                {
                    if (taken) Lock.Exit();
                }
            }
        }

        /// <summary>
        /// Removes all elements from the set.
        /// </summary>
        public void Clear()
        {
            if (Interlocked.Read(ref SetSemaphore) > 0)
            {
                Interlocked.Increment(ref SetSemaphore);
                PostMerge += () => Clear();
                Interlocked.Decrement(ref SetSemaphore);
            }
            else
            {
                bool taken = false;
                try
                {
                    Lock.Enter(ref taken);
                    _segment.Clear();
                }
                finally
                {
                    if (taken) Lock.Exit();
                    Merge();
                }
            }
        }

        /// <summary>
        /// Determines whether the set contains a specific element.
        /// </summary>
        /// <param name="item">The element to locate in the set.</param>
        /// <returns>true if the set contains the specified element; otherwise, false.</returns>
        public bool Contains(T item)
        {
            bool taken = false;
            try
            {
                Lock.Enter(ref taken);
                if (_segment.Contains(item)) return true;

                if (_next != null)
                {
                    var next = _next;
                    Lock.Exit();
                    taken = false;
                    return next.Contains(item);
                }
            }
            finally
            {
                if (taken) Lock.Exit();
            }
            return false;
        }

        /// <summary>
        /// Copies the elements of the set to an array, starting at a particular array index.
        /// </summary>
        /// <param name="array">The one-dimensional array that is the destination of the elements copied from the set.</param>
        /// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            Interlocked.Increment(ref SetSemaphore);
            bool taken = false;
            try
            {
                Lock.Enter(ref taken);
                var len = _segment.Count;
                _segment.CopyTo(array, arrayIndex);
                if (_next != null)
                {
                    var next = _next;
                    Lock.Exit();
                    taken = false;
                    next.CopyTo(array, arrayIndex + len);
                }
            }
            finally
            {
                if (taken) Lock.Exit();
                Interlocked.Decrement(ref SetSemaphore);
            }
        }

        /// <summary>
        /// Removes the elements in the specified collection from the set.
        /// </summary>
        /// <param name="other">The collection of items to remove from the set.</param>
        public void ExceptWith(IEnumerable<T> other)
        {
            if (Interlocked.Read(ref SetSemaphore) > 0)
            {
                Interlocked.Increment(ref SetSemaphore);
                PostMerge += () => ExceptWith(other);
                Interlocked.Decrement(ref SetSemaphore);
            }
            else
            {
                bool taken = false;
                try
                {
                    Lock.Enter(ref taken);
                    _segment.ExceptWith(other);
                }
                finally
                {
                    if (taken) Lock.Exit();
                    Merge();
                }
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the set.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the set.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            Interlocked.Increment(ref SetSemaphore);
            bool taken = false;
            Lock.Enter(ref taken);  // wait for concurrent operations to complete
            Lock.Exit();
            try
            {
                foreach (var t in _segment)
                    yield return t;
                if (_next != null)
                    foreach (var t in _next)
                    yield return t;
            }
            finally
            {
                Interlocked.Decrement(ref SetSemaphore);
                Merge();
            }
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            if (Interlocked.Read(ref SetSemaphore) > 0)
            {
                Interlocked.Increment(ref SetSemaphore);
                PostMerge += () => IntersectWith(other);
                Interlocked.Decrement(ref SetSemaphore);
            }
            else
            {
                bool taken = false;
                try
                {
                    Lock.Enter(ref taken);
                    _segment.ExceptWith(other);
                }
                finally
                {
                    if (taken) Lock.Exit();
                    Merge();
                }
            }
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            Interlocked.Increment(ref SetSemaphore);
            bool taken = false;
            try
            {
                Lock.Enter(ref taken);
                var enumerate = other.ToList();
                var next = _next;
                if (!_segment.IsProperSubsetOf(enumerate)) return false;
                Lock.Exit();
                taken = false;
                if (next != null)
                {
                    return next.IsProperSubsetOf(enumerate);
                }
            }
            finally
            {
                Interlocked.Decrement(ref SetSemaphore);
                if (taken) Lock.Exit();
                Merge();
            }
            return true;
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            Interlocked.Increment(ref SetSemaphore);
            bool taken = false;
            try
            {
                Lock.Enter(ref taken);
                var enumerate = other.ToList();
                var next = _next;
                if (!_segment.IsProperSupersetOf(enumerate)) return false;
                Lock.Exit();
                taken = false;
                if (next != null)
                {
                    return next.IsProperSupersetOf(enumerate);
                }
            }
            finally
            {
                Interlocked.Decrement(ref SetSemaphore);
                if (taken) Lock.Exit();
                Merge();
            }
            return true;
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            Interlocked.Increment(ref SetSemaphore);
            bool taken = false;
            try
            {
                Lock.Enter(ref taken);
                var enumerate = other.ToList();
                var next = _next;
                if (!_segment.IsSubsetOf(enumerate)) return false;
                Lock.Exit();
                taken = false;
                if (next != null)
                {
                    return next.IsSubsetOf(enumerate);
                }
            }
            finally
            {
                Interlocked.Decrement(ref SetSemaphore);
                if (taken) Lock.Exit();
                Merge();
            }
            return true;
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            Interlocked.Increment(ref SetSemaphore);
            bool taken = false;
            try
            {
                Lock.Enter(ref taken);
                var enumerate = other.ToList();
                var next = _next;
                if (!_segment.IsSupersetOf(enumerate)) return false;
                Lock.Exit();
                taken = false;
                if (next != null)
                {
                    return next.IsSupersetOf(enumerate);
                }
            }
            finally
            {
                Interlocked.Decrement(ref SetSemaphore);
                if (taken) Lock.Exit();
                Merge();
            }
            return true;
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            Interlocked.Increment(ref SetSemaphore);
            bool taken = false;
            try
            {
                Lock.Enter(ref taken);
                var enumerate = other.ToList();
                var next = _next;
                if (_segment.Overlaps(enumerate)) return true;
                Lock.Exit();
                taken = false;
                if (next != null)
                {
                    return next.Overlaps(enumerate);
                }
            }
            finally
            {
                Interlocked.Decrement(ref SetSemaphore);
                if (taken) Lock.Exit();
                Merge();
            }
            return false;
        }

        public bool SetEquals(IEnumerable<T> other)
        {
            if (Interlocked.Read(ref SetSemaphore) > 0)
                throw new ThreadStateException("Concurrent operation in progress.");
            bool taken = false;
            try
            {
                Lock.Enter(ref taken);
                return _segment.SetEquals(other);
            }
            finally
            {
                if (taken) Lock.Exit();
            }
        }

        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            if (Interlocked.Read(ref SetSemaphore) > 0)
            {
                Interlocked.Increment(ref SetSemaphore);
                PostMerge += () => SymmetricExceptWith(other);
                Interlocked.Decrement(ref SetSemaphore);
            }
            else
            {
                bool taken = false;
                try
                {
                    Lock.Enter(ref taken);
                    _segment.SymmetricExceptWith(other);
                }
                finally
                {
                    if (taken) Lock.Exit();
                    Merge();
                }
            }
        }

        public void UnionWith(IEnumerable<T> other)
        {
            if (Interlocked.Read(ref SetSemaphore) > 0)
            {
                GetNext().UnionWith(other);
            }
            else
            {
                bool taken = false;
                try
                {
                    Lock.Enter(ref taken);
                    _segment.UnionWith(other);
                }
                finally
                {
                    if (taken) Lock.Exit();
                }
            }
        }

        void ICollection<T>.Add(T item)
        {
            if (Interlocked.Read(ref SetSemaphore) > 0)
                GetNext().Add(item);
            else
            {
                bool taken = false;
                try
                {
                    Lock.Enter(ref taken);
                    _segment.Add(item);
                }
                finally
                {
                    if (taken) Lock.Exit();
                }
            }
        }

        public bool Remove(T item)
        {
            bool taken = false;
            try
            {
                Lock.Enter(ref taken);
                if (Interlocked.Read(ref SetSemaphore) > 0)
                {
                    if (_segment.Contains(item))
                    {
                        Interlocked.Increment(ref SetSemaphore);
                        PostMerge += () => _segment.Remove(item);
                        Interlocked.Decrement(ref SetSemaphore);
                        return true;
                    }
                    else
                    {
                        return GetNext().Remove(item);
                    }
                }
                else
                {
                    return _segment.Remove(item);
                }
            }
            finally
            {
                if (taken) Lock.Exit();
                Merge();
            }
        }
        public bool Replace(T item)
        {
            bool taken = false;
            try
            {
                Lock.Enter(ref taken);
                if (Interlocked.Read(ref SetSemaphore) > 0)
                {
                    if (_segment.Contains(item))
                    {
                        Interlocked.Increment(ref SetSemaphore);
                        PostMerge += () => Replace(item);
                        Interlocked.Decrement(ref SetSemaphore);
                        return GetNext().Replace(item);
                    }
                    else
                    {
                        return GetNext().Replace(item);
                    }
                }
                else
                {
                    _segment.Remove(item);
                    return _segment.Add(item);
                }
            }
            finally
            {
                if (taken) Lock.Exit();
                Merge();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Interlocked.Increment(ref SetSemaphore);
            bool taken = false;
            try
            {
                Lock.Enter(ref taken);
                var enumerate = _segment.ToList();
                Lock.Exit();
                taken = false;
                foreach (var t in enumerate)
                    yield return t;
                if (_next != null)
                {
                    foreach (var t in _next)
                        yield return t;
                }
            }
            finally
            {
                if (taken) Lock.Exit();
                Interlocked.Decrement(ref SetSemaphore);
                Merge();
            }
        }
        public bool TryGetValue(T equalValue, [MaybeNullWhen(false)] out T actualValue)
        {
            if (Interlocked.Read(ref SetSemaphore) > 0)
                return GetNext().TryGetValue(equalValue, out actualValue);
            else
            {
                bool taken = false;
                try
                {
                    Lock.Enter(ref taken);
                    return _segment.TryGetValue(equalValue, out actualValue);
                }
                finally
                {
                    if (taken) Lock.Exit();
                }
            }
        }
    }
}
