// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Numerics;

namespace Hiperspace
{
    /// <summary>
    /// Indicates that this element is a fact in a cube
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class CubeFactAttribute : Attribute
    {
        public CubeFactAttribute(int id) : base() { }
        public CubeFactAttribute(int id, int drillId) : base() { }
        public CubeFactAttribute() : base() { }
    }
    /// <summary>
    /// An element that provides the CubeFactAttribute 
    /// </summary>
    public interface ICubeFact
    {
        /// <summary>
        /// The slice of the cube that this fact belongs to.
        /// If Dimensions are {Customer #1, Product #2} the slice is "1,2"
        /// </summary>
        public string CubeSlice { get; }

        /// <summary>
        /// add this dimension to the cube fact
        /// </summary>
        /// <typeparam name="TEntity">type of the dimension</typeparam>
        /// <param name="dimension">value of the dimension</param>
        /// <remarks>
        /// The implementation is expected to update teh CubeSlice if this dimension was not previously added
        /// </remarks>
        public void Dimension<TEntity>(TEntity dimension) where TEntity : ICubeDimension;

        /// <summary>
        /// add this dimension to the fact without knowing (at compile time) the type of the dimension
        /// </summary>
        /// <param name="type"></param>
        /// <param name="dimension"></param>
        public void Dimension(Type type, object dimension);

        /// <summary>
        /// Set of dimensions for this Cube fact
        /// </summary>
        public ISet<ICubeDimension> Dimensions { get; }

        /// <summary>
        /// Dictionary of measures for this Cube fact
        /// </summary>
        public IDictionary<string, (Aggregate, object)> Measures { get; }

        /// <summary>
        /// Indicate that the Cube Slice is a Fact rather than a summary for a dimension
        /// </summary>
        public Boolean? IsFact { get; set; }

        /// <summary>
        /// Calculate the summary using the the drilldown elements, and measure methods 
        /// </summary>
        /// <remarks>
        /// Every Cube (that is not a fact) has a set of drilldown links that can be used to retrieve the 
        /// underlying facts that can be used to calculate a summary.  Calculation of a fact is the same
        /// as the fact itself.
        /// The Drilldown is created by the aggregation process that creates the base fact elements
        /// method.
        /// </remarks>
        public ICubeFact Calculate();

        public IEnumerable<ICubeDrillDown> DrillDown { get; }
    }

    /// <summary>
    /// Represents a drilldown operation within a cube structure, providing access hierarchy and other dimensions
    /// </summary>
    public interface ICubeDrillDown
    {
        /// <summary>
        /// the owner of this drilldown segment <see cref="ICubeFact"/> 
        /// </summary>
        public ICubeFact owner { get; }

        /// <summary>
        /// the target cube that is either a a levewl down in a hierarchy, another dimension or a fact
        /// </summary>
        public ICubeFact To { get; }
    }
}