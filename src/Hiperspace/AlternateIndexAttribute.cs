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
    /// Indicates that the attribute should be indexed
    /// </summary>
    [AttributeUsage(AttributeTargets.Property|AttributeTargets.Field)]
    public class AlternateIndexAttribute : Attribute
    {
        /// <summary>
        /// Property with named and id
        /// </summary>
        /// <param name="id">id to use for serialisation of index</param>
        public AlternateIndexAttribute(int id) : base() { }

        /// <summary>
        /// Property with named and id
        /// </summary>
        /// <param name="name">name of the view being indexed</param>
        public AlternateIndexAttribute() : base() { }
    }
}
