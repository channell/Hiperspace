// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
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
            (IQueryable<TLeft> left
            , IQueryable<TRight> right
            , List<((string alias, ValueGetter property) left, (string alias, PropertyInfo property) right)> joins
            , LambdaExpression closureExpression
            )
        {
            _runnable = new RunJoin<TResult, TLeft, TRight>(left, right, joins, closureExpression);
            _provider = left.Provider ?? right.Provider;
            _expression = Expression.Constant(this);
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
            )
        {
            _left = left;
            _right = right;
            _joins = joins;

            _closureFactory = (Func<TLeft, TRight, TResult>)closureExpression.Compile();

            _setJoin = left as ISetJoin;
            _setLeft = left as ISetQuery;
            _setRight = right as ISetQuery;
            _sources = new Dictionary<string, ISetQuery>(buildSource(this));
        }
        public ISetJoin Runnable => this;


        /// <summary>
        /// Unpacks the elements of a closure. This function should be converted to Emit when time allows
        /// </summary>
        /// <param name="closure">the closure object created during teh Expression execution</param>
        /// <returns></returns>
        public IEnumerable<(string name, object value)> UnpackElements(object closure)
        {
            var fields = closure.GetType().GetFields();
            for (int c = 0; c < fields.Length; c++)
            {
                var value = fields[c].GetValue(closure);
                yield return (fields[c].Name, value!);
            }
            var properties = closure.GetType().GetProperties();
            for (int c = 0; c < properties.Length; c++)
            {
                var value = properties[c].GetValue(closure);
                yield return (properties[c].Name, value!);
            }
        }

        public string? Alias { get; set; }

        private IQueryable<TLeft> _left;
        private IQueryable<TRight> _right;
        private Func<TLeft, TRight, TResult> _closureFactory;
        private List<((string alias, ValueGetter property) left, (string alias, PropertyInfo property) right)> _joins;

        private ISetJoin? _setJoin;
        private ISetQuery? _setLeft;
        private ISetQuery? _setRight;

        private Dictionary<string, ISetQuery> _sources;

        private IEnumerable<KeyValuePair<string, ISetQuery>> buildSource (ISetJoin join)
        {
            if (join.Inner is not null)
            {
                foreach (var source in buildSource(join.Inner))
                {
                    yield return source;
                }
            }
            if (join.Left is not null && join.Left.Alias is not null && join.Left is not null)
            {
                yield return KeyValuePair.Create(join.Left.Alias, join.Left);
            }
            if (join.Right is not null && join.Right.Alias is not null && join.Right is not null)
            {
                yield return KeyValuePair.Create(join.Right.Alias, join.Right);
            }
        }

        public ISetJoin? Inner => _setJoin;
        public ISetQuery? Left => _setLeft;
        public ISetQuery? Right => _setRight;

        public List<((string alias, ValueGetter property) left, (string alias, PropertyInfo property) right)> Joins => _joins;
        public Type ElementType => typeof(TResult);

        public IEnumerator<TResult> GetEnumerator()
        {
            if (_setLeft is not null)
            {
                foreach (var left in _left)
                {
                    if (_setRight is not null)
                    {
                        foreach (var j in _joins)
                        {
                            object? value = j.left.property.GetValue(left);
                            j.right.property.SetValue(_setRight.Template, value);
                        }
                        foreach (var right in _right)
                        {
                            yield return _closureFactory(left, right);
                        }
                    }
                    else // cross join to non-hiperspace collection
                    {
                        foreach (var right in _right)
                        {
                            yield return _closureFactory(left, right);
                        }
                    }
                }
            }
            else if (_setJoin is not null)
            {
                foreach (var left in _left)
                {
                    if (_setRight is not null)
                    {
                        //!var tuple = UnpackElements(left).ToArray();
                        foreach (var j in _joins)
                        {
                            object? value = j.left.property.GetValue(left);
                            j.right.property.SetValue(_setRight.Template, value);
                        }
                        foreach (var right in _right)
                        {
                            yield return _closureFactory(left, right);
                        }
                    }
                    else // cross join to non-hiperspace collection
                    {
                        foreach (var right in _right)
                        {
                            yield return _closureFactory(left, right);
                        }
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public QueryExplain.Explain Explain()
        {
            var result = new QueryExplain.Explain() { Area = "Join" };
            if (_setLeft is not null)
            {
                var (path, name) = _setLeft.Explain();
                result.Children.Add(new QueryExplain.Explain() { Area = path, Message = name });
            }
            if (_setRight is not null)
            {
                var (path, name) = _setRight.Explain();
                result.Children.Add(new QueryExplain.Explain() { Area = path, Message = name });
            }
            return result;
        }
    }
}
