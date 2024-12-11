// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
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
        public DateTime AsAt { get; protected set; }

        /// <summary>
        /// Timestamp of the version that this element replaced.  Used to implement optimistic concurrency control
        /// </summary>
        public DateTime? AsWas { get; protected set; }
        public abstract IEnumerable<TEntity> GetVersions();
        public abstract Task<IEnumerable<TEntity>> GetVersionsAsync();
    }
}
