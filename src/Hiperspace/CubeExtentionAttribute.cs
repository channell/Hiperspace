// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    /// <summary>
    /// Indicates that this attribute is an extension to measures, used to add calculated methods that extend measures
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class CubeExtentAttribute : Attribute
    {
        public CubeExtentAttribute() : base()
        {
        }
    }
}
