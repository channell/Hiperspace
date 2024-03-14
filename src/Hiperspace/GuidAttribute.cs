// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    [AttributeUsage(AttributeTargets.Class)]
    public class GuidAttribute : Attribute
    {
        public Guid Guid {  get; init; }
        public GuidAttribute(string value) : base() 
        { 
            Guid = Guid.Parse(value);
        }
    }
}
