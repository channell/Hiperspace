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
    /// Indicates that the extention property should be evaluated once and cached
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class OnceAttribute : Attribute
    {
        public OnceAttribute() { }
    }
}