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
    /// Used for AI and special search 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class VectorSpaceAttribute : Attribute
    {
        public VectorSpaceAttribute() : base() { }
    }
}
