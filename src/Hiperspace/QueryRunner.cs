// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Linq.Expressions;

namespace Hiperspace
{
    /// <summary>
    /// Represents a query runner that visits expression trees and performs operations on constants.
    /// </summary>
    public class QueryRunner : ExpressionVisitor
    {
        /// <summary>
        /// Visits a constant expression and performs operations based on the type of the constant value.
        /// </summary>
        /// <param name="node">The constant expression to visit.</param>
        /// <returns>The modified constant expression.</returns>
        protected override Expression VisitConstant(ConstantExpression node)
        {
            if (node?.Value is ISetQuery sq)
            {
                return Expression.Constant(sq.Runnable.AsQueryable());
            }
            else if (node?.Value is ISetJoin sj)
            {
                return Expression.Constant(sj.Runnable.AsQueryable());
            }
            else if (node?.Value is ISetSpace sp)
            {
                return Expression.Constant(sp.Runnable());
            }
            else
                return node!;
        }
    }
}