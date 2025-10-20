// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Collections;
using System.Reflection;

namespace Hiperspace
{
    /// <summary>
    /// Represents a query on a set of objects.
    /// </summary>
    public interface ISetQuery : IEnumerable
    {
        /// <summary>
        /// Gets or sets the alias for the query.
        /// </summary>
        public string? Alias { get; set; }

        /// <summary>
        /// Gets the template object for the query.
        /// </summary>
        public object Template { get; }

        /// <summary>
        /// Gets the space object for the query.
        /// </summary>
        public object Space { get; }

        /// <summary>
        /// Gets the type of the elements in the query.
        /// </summary>
        public Type ElementType { get; }

        /// <summary>
        /// Explains the query.
        /// </summary>
        /// <returns>A tuple containing the explanation for the query.</returns>
        public (string?, string?) Explain();

        /// <summary>
        /// Explains the query using the specified template object.
        /// </summary>
        /// <param name="template">The template object to use for explanation.</param>
        /// <returns>A tuple containing the explanation for the query.</returns>
        public (string?, string?) Explain(object template);

        /// <summary>
        /// Gets a runnable version of the query.
        /// </summary>
        public ISetQuery Runnable { get; }
    }
}
