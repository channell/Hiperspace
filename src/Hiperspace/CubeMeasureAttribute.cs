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
    /// Aggregation methods used for cube calculations. 
    /// </summary>
    public enum Aggregate
    {
        Sum,
        Max,
        Min,
        Average,
        Count,
        AverageTotal  // Measure accumilated to support average aggregation
    }
    /// <summary>
    /// Indicates that this attribute is a measure aggregated in a cube
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class CubeMeasureAttribute : Attribute
    {
        public CubeMeasureAttribute(Aggregate type) : base()
        {
            Type = type;
        }

        public Aggregate Type { get; init; }
    }
}
