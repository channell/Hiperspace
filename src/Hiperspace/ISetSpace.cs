// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    /// <summary>
    /// Common functions that all SetSpaces provide
    /// </summary>
    public interface ISetSpace
    {
        /// <summary>
        /// Reference to the subspace for this set
        /// </summary>
        public SubSpace Space { get; set; }
        
        /// <summary>
        /// Create a query object for this set
        /// </summary>
        /// <returns>A SetQuery<TEntity></returns>
        public ISetQuery SetQuery();

        /// <summary>
        /// Provides an explanation for the specified template.
        /// </summary>
        /// <param name="template">The template object.</param>
        /// <returns>A tuple containing the explanation query.</returns>
        public (string?, string?) Explain(object template);
    }
}
