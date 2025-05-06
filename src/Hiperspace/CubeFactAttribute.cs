// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
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
    }
}
