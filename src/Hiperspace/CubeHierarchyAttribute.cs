// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    /// <summary>
    /// Indicates that the Cube Dimension is part of a self referencing Hierarchy
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class CubeHierarchyAttribute : Attribute
    {
        /// <summary>
        /// The name of the member that provides the parent dimension reference
        /// </summary>
        public string? ParentName { get; set; }
        public CubeHierarchyAttribute(string? parentName = null) : base()
        {
            ParentName = parentName;
        }
    }

    /// <summary>
    /// An element that provides the CubeHierarchyAttribute will implement this 
    /// interface to navigate to the parent dimension
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface ICubeHierarchy<TEntity>
    {
        /// <summary>
        /// The parent element 
        /// </summary>
        public TEntity? Parent { get;}
    }
}
