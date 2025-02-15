// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    /// <summary>
    /// Indicates that the composite key are a series of alternatives.
    /// </summary>
    /// <remarks>
    /// Used for Fact tables, where the key is a series of alternatives
    /// entity Sales_Fact (region, sector, product) {value}; is gettable when only one dimension is
    /// provided
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class)]
    public class AnyKeyAttribute : Attribute
    {
        public AnyKeyAttribute() { }
    }
}
