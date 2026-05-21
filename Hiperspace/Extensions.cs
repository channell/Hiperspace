using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hiperspace
{
    public static class Extensions
    {
        /// <summary>
        /// Provides an asynchronous enumerable wrapper around an existing enumerable.
        /// </summary>
        /// <typeparam name="T">The type of elements in the enumerable.</typeparam>
        /// <param name="source">The source enumerable.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An asynchronous enumerable.</returns>
        public static async IAsyncEnumerable<T> ToAsyncEnumerable<T>(this IEnumerable<T> source, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            foreach (var item in source)
            {
                cancellationToken.ThrowIfCancellationRequested();
                yield return await Task.FromResult(item);
            }
        }

        /// <summary>
        /// Executes the specified action within a critical section protected by the given SpinLock.
        /// </summary>
        /// <remarks>
        /// SpinLock is a lightweight lock for very short duration that is agnostic to use within
        /// a normal OS or a WebAssembly browser app.  It should be used to protected collections that
        /// are not thread safe.
        /// This is a utility method, it is normally more efficient to implement as a pattern within
        /// code since a pattern does not involve the creation of a action closure.
        /// <param name="spinLock">The SpinLock instance used to synchronize access to the critical section.</param>
        /// <param name="action">The action to execute while the SpinLock is held. Cannot be null.</param>
        /// <exception cref="LockRecursionException">Thrown if the current thread already holds the lock and recursion is not allowed.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Scoped(this SpinLock spinLock, Action action)
        {
            bool taken = false;
            spinLock.Enter(ref taken);
            if (taken || (spinLock.IsThreadOwnerTrackingEnabled && spinLock.IsHeldByCurrentThread))
            {
                try
                {
                    action();
                }
                finally
                {
                    if (taken)
                        spinLock.Exit();
                }
            }
            else
                throw new LockRecursionException();
        }
    }
}
