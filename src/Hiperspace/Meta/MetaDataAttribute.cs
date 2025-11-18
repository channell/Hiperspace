// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace.Meta
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class MetaDataAttribute : Attribute
    {
        public MetaModel? Model { get; set; }
        public MetaDataAttribute(Type model)
        {
            Model = Activator.CreateInstance(model) as MetaModel;
        }
    }
}
