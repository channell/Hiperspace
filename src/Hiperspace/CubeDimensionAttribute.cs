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
    /// Indicates that this attribute is a dimension in a cube.  
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class CubeDimensionAttribute : Attribute
    {
        public string? DimensionName { get; set; }  
        public CubeDimensionAttribute(string? dimensionName = null) : base() 
        { 
            DimensionName = dimensionName;
        }
    }
}
