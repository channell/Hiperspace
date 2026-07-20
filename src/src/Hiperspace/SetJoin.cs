// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;

namespace Hiperspace
{

    public class SetJoin<TResult, TLeft, TRight> : IOrderedQueryable<TResult>, ISetJoin
        where TLeft : class
        where TRight : class
    {
        protected RunJoin<TResult, TLeft, TRight> _runnable;
        protected Expression _expression;
        protected IQueryProvider _provider;

        public SetJoin
            ( IQueryable<TLeft> left
            , IQueryable<TRight> right
            , List<((string alias, ValueGetter property) left, (string alias, PropertyInfo property) right)> joins
            , LambdaExpression closureExpression
            , (LambdaExpression left, LambdaExpression right) functors
            )
        {
            var joinClosure = BuildClosure(functors, closureExpression);
            _runnable = new RunJoin<TResult, TLeft, TRight>(left, right, joins, closureExpression, joinClosure);
            _provider = left.Provider ?? right.Provider;
            _expression = closureExpression;
        }
        static IJoinClosure<TLeft, TRight> BuildClosure((LambdaExpression left, LambdaExpression right) residual, LambdaExpression closureExpression)
        {
            var residualType = typeof(JoinClosure<,,,>).MakeGenericType(typeof(TLeft), typeof(TRight), residual.left.ReturnType, residual.right.ReturnType);
            var instance = Activator.CreateInstance(residualType, new object[] { residual.left, residual.right });
            return (IJoinClosure<TLeft, TRight>)instance!;
        }

        public IQueryProvider Provider => _provider;

        public Type ElementType => typeof(TResult);

        public Expression Expression => _expression;
        public ISetJoin? Inner => _runnable.Inner;

        public ISetQuery? Left => _runnable.Left;

        public ISetQuery? Right => _runnable.Right;

        public List<((string alias, ValueGetter property) left, (string alias, PropertyInfo property) right)> Joins => _runnable.Joins;

        public ISetJoin Runnable => _runnable;

        public QueryExplain.Explain Explain()
        {
            return _runnable.Explain();
        }
        public IEnumerator<TResult> GetEnumerator()
        {
            return _runnable.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class RunJoin<TResult, TLeft, TRight> : IEnumerable<TResult>, ISetJoin
        where TLeft : class
        where TRight : class
    {
        public RunJoin
            ( IQueryable<TLeft> left
            , IQueryable<TRight> right
            , List<((string alias, ValueGetter property) left, (string alias, PropertyInfo property) right)> joins
            , LambdaExpression closureExpression
            , IJoinClosure<TLeft, TRight> residual
            )
        {
            _left = left;
            _right = right;
            _joins = joins;
            _residual = residual;
            _closureFactory = (Func<TLeft, TRight, TResult>)closureExpression.Compile();
        }
        public ISetJoin Runnable => this;

        public string? Alias { get; set; }

        private IQueryable<TLeft> _left;
        private IQueryable<TRight> _right;
        private Func<TLeft, TRight, TResult> _closureFactory;
        private IJoinClosure<TLeft, TRight> _residual;
        private List<((string alias, ValueGetter property) left, (string alias, PropertyInfo property) right)> _joins;

        public ISetJoin? Inner => _left as ISetJoin;
        public ISetQuery? Left => _left as ISetQuery;
        public ISetQuery? Right => _right as ISetQuery;

        public List<((string alias, ValueGetter property) left, (string alias, PropertyInfo property) right)> Joins => _joins;
        public Type ElementType => typeof(TResult);

        public IEnumerator<TResult> GetEnumerator()
        {
            return _residual.GetEnumerator<TResult>(_left, _right, _closureFactory);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public QueryExplain.Explain Explain()
        {
            var result = new QueryExplain.Explain() { Area = "Join" };
            if (Left is not null)
            {
                var (path, name) = Left.Explain();
                result.Children.Add(new QueryExplain.Explain() { Area = path, Message = name });
            }
            if (Right is not null)
            {
                var (path, name) = Right.Explain();
                result.Children.Add(new QueryExplain.Explain() { Area = path, Message = name });
            }
            return result;
        }
    }
}
