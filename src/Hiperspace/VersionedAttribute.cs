﻿// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    /// <summary>
    /// Indicates that the class has multiple versions. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class VersionedAttribute : Attribute
    {
        public VersionedAttribute() : base() { }
    }
}
