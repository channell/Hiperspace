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
    /// Aggregation methods used for cube calculations. 
    /// </summary>
    public enum Aggregate
    {
        Sum,
        Max,
        Min,
        Average,
        Count,
        AverageTotal,   // Measure accumulated to support average aggregation
        StdDev,         // Calculate standard deviation from raw values
        Percentile,     // Calculate the ranked percentile, e.g. @CubeMeasure(Aggregate.Percentile, 95) for risk aggregation
        StdVector,      // Compress all observable measure values into Vector
        PerVector       // Compress all observable measure values into Vector
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
            Percentile = null;
        }
        public CubeMeasureAttribute(Aggregate type, int percentile) : base()
        {
            Type = type;
            Percentile = percentile;
        }

        public Aggregate Type { get; init; }
        public int? Percentile { get; init; }
    }
}
