// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Collections;
using System.Linq.Expressions;

namespace Hiperspace
{
    /// <summary>
    /// Represents a join query in the Hiperspace framework.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the query result.</typeparam>
    public class JoinQuery<T> : IOrderedQueryable<T>
    {
        private readonly Expression _expression;
        private readonly IQueryProvider _provider;
        private static QueryOptimizer optimizer = new QueryOptimizer();
        private static QueryRunner runner = new QueryRunner();

        /// <summary>
        /// Initializes a new instance of the <see cref="JoinQuery{T}"/> class.
        /// </summary>
        /// <param name="provider">The query provider.</param>
        /// <param name="expression">The expression representing the join query.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="provider"/> or <paramref name="expression"/> is null.</exception>
        public JoinQuery(IQueryProvider provider, Expression expression)
        {
            _provider = provider ?? throw new ArgumentNullException(nameof(provider));
            _expression = optimizer.Visit(expression) ?? throw new ArgumentNullException(nameof(expression));
        }

        /// <summary>
        /// Gets the type of the elements in the query result.
        /// </summary>
        public Type ElementType => typeof(T);

        /// <summary>
        /// Gets the expression representing the join query.
        /// </summary>
        public Expression Expression => _expression;

        /// <summary>
        /// Gets the query provider.
        /// </summary>
        public IQueryProvider Provider => _provider;

        /// <summary>
        /// Returns an enumerator that iterates through the query result.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the query result.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            var run = runner.Visit(_expression);
            var result = _provider.Execute(run!);
            return ((IEnumerable<T>)result!).GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the query result.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the query result.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
