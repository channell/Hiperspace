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
    /// Indicates that the class includes an index by AsAt date for delta filtering
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DeltaIndexAttribute : Attribute
    {
        public DeltaIndexAttribute(int id) : base() { }
        public DeltaIndexAttribute() : base() { }
    }
}
