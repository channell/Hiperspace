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
    /// Indicates that this attribute is a dimension in a cube.  
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class CubeDimensionAttribute : Attribute
    {
        public string? CubeName { get; set; }
        public CubeDimensionAttribute(string? dimensionName = null) : base()
        {
            CubeName = dimensionName;
        }
    }
    /// <summary>
    /// Indicates that this attribute is a reference to cube dimension
    /// </summary>
    [AttributeUsage(AttributeTargets.Property| AttributeTargets.Field)]
    public class CubeDimensionReferenceAttribute : Attribute
    {
        public CubeDimensionReferenceAttribute() : base()
        {
        }
    }
    /// <summary>
    /// An element that provides the CubeDimensionAttribute provides a Slice string that 
    /// can be used to locate a fact instance in a cube
    /// </summary>
    public interface ICubeDimension
    {
        /// <summary>
        /// the Slice is the string value of the #id used to serialize elements to
        /// protobuf.
        /// </summary>
        /// <example>1,2</example>
        public string CubeSlice { get; }
        
        /// <summary>
        /// Namer of the cube element
        /// </summary>
        /// <example>Customer</example>
        public string CubeName { get; }

        /// <summary>
        /// Gets the stringified key for the dimension element
        /// </summary>
        public string SKey { get; }
    }
}
