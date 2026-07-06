using System;
using System.Collections.Generic;
using System.Text;

namespace Hiperspace.ISO20022
{
    public class XmlNameSpaceAttribute : Attribute
    {
        public XmlNameSpaceAttribute(string name) { }
    }
    public class CheckValidAttribute : Attribute
    {
    }
}
