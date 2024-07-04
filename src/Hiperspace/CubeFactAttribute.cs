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
    /// Indicates that this element is a fact in a cube
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class CubeFactAttribute : Attribute
    {
        public CubeFactAttribute() : base() { }
    }
}
