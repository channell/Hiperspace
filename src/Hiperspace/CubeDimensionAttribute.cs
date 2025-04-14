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
    /// An element that provides the CubeDimensionAttribute provides a Slice string that 
    /// can be used to locate a fact instance in a cube
    /// </summary>
    public interface ICubeDimension
    {
        /// <summary>
        /// the Slice is the string value of the #id used to serialize elements to
        /// protobuf.
        /// </summary>
        public string CubeSlice { get; }
        public string CubeName { get; }
    }
}
