using Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cube
{
    internal static class Functions
    {
        /// <summary>
        /// Determines the RAG (Red, Amber, Green) status for the specified product with the range of values within the parent
        /// using the current value and parents standard deviation and average
        /// </summary>
        /// <remarks>
        /// If the current product has a parent, the values of the Contact_Cube are retrieved from Hiperspace.
        /// Note: If a cube has not been calculated for this product or its parent, calculation is performed as a side effect
        /// Note: Whenever the underlying fact changes, the Cube and Fact values will be re-calculated (by Hiperspace.DB)
        /// Note: If the product hierarchy has changed, the Cube and Fact values will be re-calculated (by Hiperspace.DB)
        /// </remarks>
        /// <param name="product">The product for which to evaluate the RAG status. May be null.</param>
        /// <returns>A RAG value indicating the status: Red if the observation is significantly above average, Green if
        /// significantly below, Amber if within the average range, Unknown if required data is missing, or None if it is the root</returns>
        public static RAG RAG (Product? product)
        {
            if (product?.Parent is not null) 
            {
                var stddev = product.Parent?.Contract_Cube?.StdDev;
                var avg = product.Parent?.Contract_Cube?.Avg;
                var observation = product?.Contract_Cube?.Value is not null ? Convert.ToDouble(product?.Contract_Cube?.Value) : (double?)null;

                return (stddev, observation, avg) switch
                {
                    (null, _, _) => Cube.RAG.Unknown,
                    (_, null, _) => Cube.RAG.Unknown,
                    (_, _, null) => Cube.RAG.Unknown,
                    (_, _, _) when observation.Value > avg.Value + stddev.Value => Cube.RAG.Red,
                    (_, _, _) when observation.Value < avg.Value - stddev.Value => Cube.RAG.Green,
                    _ => Cube.RAG.Amber,
                };
            }
            return Cube.RAG.None;
        }
        public static IEnumerable<Contract_Cube> ProductBySectors(Product? product)
        {
            return product?.Contract_Cube?.Sector_DrillDown() ?? Enumerable.Empty<Contract_Cube>();
        }
    }
}
