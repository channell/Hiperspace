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
        public DateTime AsAt { get; protected set; }
        public abstract IEnumerable<TEntity> GetVersions();
        public abstract Task<IEnumerable<TEntity>> GetVersionsAsync();
    }
}
