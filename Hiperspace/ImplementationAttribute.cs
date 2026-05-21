// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    /// <summary>
    /// Indicates that the attribute is a reference to a segment (many) or aspect (one) with the #id of the implementation
    /// </summary>
    /// <remarks>Apply this attribute to a property or field to associate it with a specific implementation,
    /// typically for use in frameworks or tools that support multiple implementations or variants. Multiple instances
    /// of this attribute can be applied to the same member. The attribute is inherited by derived classes.</remarks>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
    public class ImplementationAttribute : Attribute
    {
        /// <summary>
        /// Not normally used, but included to avoid errors when referenced as a placeholder
        /// </summary>
        public ImplementationAttribute() : base() { }

        /// <summary>
        /// The segment/aspect has one implementation and retails the name
        /// </summary>
        /// <param name="id">the #id of the implementation</param>
        public ImplementationAttribute(int id) : base() { }


        /// <summary>
        /// The segment/aspect has many specialisations for different elements that reference it
        /// identifier.
        /// </summary>
        /// <param name="implementation">the name of the segment </param>
        /// <param name="id">the #id of the implementation</param>
        public ImplementationAttribute(string implementation, int id) : base() { }
    }
}
