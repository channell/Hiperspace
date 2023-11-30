// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    [AttributeUsage(AttributeTargets.Field| AttributeTargets.Class)]
    public class VersionedAttribute : Attribute
    {
        public VersionedAttribute() : base() { }
    }
}
