// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Microsoft.Win32.SafeHandles;

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

        /// <summary>
        /// The name of the member that provides the parent dimension reference
        /// </summary>
        public string? ChildrenName { get; set; }

        /// <summary>
        /// The name of the member that provides the hierarchy level identifier
        /// </summary>
        public string? LevelName { get; set; }
        public CubeHierarchyAttribute(string parentName, string? childrenName = null, string? levelName = null) : base()
        {
            ParentName = parentName;
            ChildrenName = childrenName;
            LevelName = levelName;
        }
    }

    /// <summary>
    /// An element that provides the CubeHierarchyAttribute will implement this 
    /// interface to navigate to the parent dimension
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface ICubeHierarchy : ICubeDimension
    {
        /// <summary>
        /// The optional Level within the Hierarchy used for Pivot-table views
        /// </summary>
        public Int32? Level { get => 1; }
    }
    /// <summary>
    /// An element that provides the CubeHierarchyAttribute will implement this 
    /// interface to navigate to the parent dimension
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface ICubeHierarchy<TEntity> : ICubeHierarchy
        where TEntity : ICubeDimension
    {
        /// <summary>
        /// The parent element 
        /// </summary>
        public TEntity? Parent { get; }

        /// <summary>
        /// Child elements of this entity
        /// </summary>
        public IEnumerable<TEntity> Children { get => throw new NotImplementedException("This property is provided by a compatible HiLang model and will become mandatory in the next release"); }

        /// <summary>
        /// Recursively retrieve all children for this hierarchy down to leaf nodes
        /// </summary>
        /// <returns>An <see cref="IEnumerable{TEntity}"/> containing all direct and indirect child entities. The sequence is
        /// empty if there are no children.</returns>
        public IEnumerable<TEntity> AllChildren()
        {
            foreach (var child in Children)
            {
                yield return child;
                if (child is ICubeHierarchy<TEntity> hierarchy)
                    foreach (var child2 in hierarchy.AllChildren())
                        yield return child2;
            }
        }
        /// <summary>
        /// Recursively retrieve all parents upto the root of the hierarchy
        /// </summary>
        /// <returns>An <see cref="IEnumerable{TEntity}"/> containing all direct and indirect parent entities. The sequence is
        /// empty if the parent is null</returns>
        public IEnumerable<TEntity> AllParents()
        {
            if (Parent is not null)
                yield return Parent;
            foreach (var parent in AllParents())
                yield return parent;
        }
    }
}
