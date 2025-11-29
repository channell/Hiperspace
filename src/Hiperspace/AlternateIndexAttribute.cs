// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    /// <summary>
    /// Indicates that the attribute should be indexed, or is indexed by property reference
    /// </summary>
    /// <remarks>
    /// Foreign References to a segment / aspect property will create an index to support lookups
    /// and a @AlternateIndex("concrete instance, id) will be adeed to the property
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property|AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
    public class AlternateIndexAttribute : Attribute
    {
        /// <summary>
        /// Property with the id that should be used to create the index
        /// </summary>
        /// <remarks>
        /// For entity Asset { @AlternateIndex(42) CostCentre : Guid };
        /// The recompilation will produce an index element with the id 42
        /// </remarks>
        /// <param name="id">id to use for serialisation of index</param>
        public AlternateIndexAttribute(int id) : base() { }
        /// <summary>
        /// Property with the name and id that should be used to create the index for a segment/aspect
        /// </summary>
        /// <remarks>
        /// For segment Cost { @AlternateIndex CostCentre : Guid }; applied to entities Asset and Project
        /// AssetCost and ProjectCost segment will be created, each with a seperate indexes.
        /// HiLang source edit (with %ids) will add
        /// segment Cost { @AlternateIndex("AssetCost", 42), AlternateIndex("ProjectCost", 43) CostCentre : Guid }
        /// so that re-compilation will create index elements with teh same #ids
        /// </remarks>
        /// <param name="id">id to use for serialisation of index</param>
        public AlternateIndexAttribute(string implementation, int id) : base() { }

        /// <summary>
        /// Property with named and id
        /// </summary>
        /// <remarks>
        /// For entity Asset { @AlternateIndex CostCentre : Guid };
        /// The compilation will allocate a new #id for the index element
        /// HiLang source edit (with %ids) will add the allocated #id to the source so that 
        /// re-compilation will create index elements with the same #id
        /// </remarks>
        /// <param name="name">name of the view being indexed</param>
        public AlternateIndexAttribute() : base() { }
    }
}
