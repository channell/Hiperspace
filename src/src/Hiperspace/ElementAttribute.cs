using System;

namespace Hiperspace
{
    /// <summary>
    /// Specifies metadata for a class that represents an element in Hiperspace
    /// </summary>
    /// <remarks>
    /// This attribute is used to annotate the generated without version<see cref="Element{TEntity}"/>
    /// or with version <see cref="ElementVersion{TEntity}"/> 
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class)]
    public class ElementAttribute : Attribute
    {
        /// <summary>
        /// Indicates that this element is a part of the Hiperspace system.
        /// </summary>
        /// <param name="versioned">is this Element versioned</param>
        /// <param name="setSpace">the name of the setspace within the subspace that holds collections of this type</param>
        /// <param name="related">when the type is a Cube, the typenane of the fact element</param>
        public ElementAttribute(bool versioned, string setSpace, Type related) : base()
        {
            Versioned = versioned;
            SetSpace = setSpace;
            Related = related;
            Domain = string.Empty;
        }
        /// <summary>
        /// Indicates that this element is a part of the Hiperspace system.
        /// </summary>
        /// <param name="versioned">is this Element versioned</param>
        /// <param name="setSpace">the name of the setspace within the subspace that holds collections of this type</param>
        /// <param name="domain">the name of the domain space</param>
        /// <param name="related">when the type is a Cube, the typenane of the fact element</param>
        public ElementAttribute(bool versioned, string setSpace, string domain, Type related) : base()
        {
            Versioned = versioned;
            SetSpace = setSpace;
            Related = related;
            Domain = domain;
        }
        /// <summary>
        /// Indicates that this element is a part of the Hiperspace system.
        /// </summary>
        /// <param name="versioned">is this Element versioned</param>
        /// <param name="setSpace">the name of the setspace within the subspace that holds collections of this type</param>
        public ElementAttribute(bool versioned, string setSpace) : base()
        {
            Versioned = versioned;
            SetSpace = setSpace;
            Domain = string.Empty;
        }
        /// <summary>
        /// Indicates that this element is a part of the Hiperspace system.
        /// </summary>
        /// <param name="versioned">is this Element versioned</param>
        /// <param name="domain">the name of the domain space</param>
        /// <param name="setSpace">the name of the setspace within the subspace that holds collections of this type</param>
        public ElementAttribute(bool versioned, string setSpace, string domain) : base()
        {
            Versioned = versioned;
            SetSpace = setSpace;
            Domain = domain;
        }
        /// <summary>
        /// The name of the set space for this element, which may have a prefix for uniquness
        /// </summary>
        public string? SetSpace { get; set; }
        /// <summary>
        /// whether this elemnent is versioned or not
        /// </summary>
        public bool Versioned { get; set; }

        public Type? Related { get; set; } 

        public string Domain { get; set; }
    }
}
