// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Assembly)]
    public class XmiAttribute : Attribute
    {
        private string? _package;
        private string _value;

        public XmiAttribute(string value) : base()
        {
            _value = value;
        }
        public XmiAttribute(string package, string value) : base()
        {
            _package = package;
            _value = value;
        }
    }
}
