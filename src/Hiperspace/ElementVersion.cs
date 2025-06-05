// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Runtime.CompilerServices;

namespace Hiperspace
{
    /// <summary>
    /// An element that includes multiple versions
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class ElementVersion<TEntity> : Element<TEntity>
        where TEntity : ElementVersion<TEntity>, new()
    {
        /// <summary>
        /// Timestamp when this element was created.  Used as part of the stored key for versions in hiperspace
        /// </summary>
        public DateTime AsAt { get; set; }  // changed to allow historical loading of versions and cube calculation

        /// <summary>
        /// Timestamp of the version that this element replaced.  Used to implement optimistic concurrency control
        /// </summary>
        public DateTime? AsWas { get; protected set; }
        public abstract IEnumerable<TEntity> GetVersions();

        /// <remarks>
        /// Will be replaced with Astract in a future release
        /// </remarks>
        public virtual IAsyncEnumerable<TEntity> GetVersionsAsync(CancellationToken cancellationToken = default)
        {
            return GetVersions().ToAsyncEnumerable(cancellationToken);
        }
    }
}
