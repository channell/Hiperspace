// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Collections;
using System.Linq.Expressions;

namespace Hiperspace
{
    public class Query<TEntity> : IOrderedQueryable<TEntity>, IQueryProvider
        where TEntity : Element<TEntity>, new()
    {
        protected SetSpace<TEntity> _setSpace;
        protected Expression _expresion;
        public Query(SetSpace<TEntity> setspace, IQueryProvider? provider)
        {
            _setSpace = setspace;
            _expresion = Expression.Constant(this);
        }
        public Query(SetSpace<TEntity> setspace, IQueryProvider provider, Expression expresion)
        {
            _setSpace = setspace;
            _expresion = expresion;
        }

        public Type ElementType => typeof(TEntity);

        public Expression Expression => _expresion;

        public IQueryProvider Provider => this;

        public IEnumerable<TEntity> GetEntities()
        {
            var visitor = new QueryVisitor<TEntity>();
            visitor.Visit(Expression);
            var result = _setSpace.Find(visitor.Template, false);
            if (result != null)
            {
                if (visitor.Expresion != null)
                {
                    var func = visitor.Expresion.Compile();
                    if (func != null)
                    {
                        if (typeof(TEntity).IsSubclassOf(typeof(Element<TEntity>)))
                        {
                            return result
                                .Where(func)
                                .Select(e =>
                                {
                                    if (e is Element<TEntity> ee)
                                    {
                                        var result = ee.Bind(_setSpace.Space);
                                        if (result.New)
                                            _setSpace.Cached.Add(result.Value);
                                        return result.Value;
                                    }
                                    else
                                        return e;
                                });                        }
                        return result.Where(func);
                    }
                }
                if (typeof(TEntity).IsSubclassOf(typeof(Element<TEntity>)))
                {
                    return result
                        .Select(e =>
                        {
                            if (e is Element<TEntity> ee)
                            {
                                var result = ee.Bind(_setSpace.Space);
                                if (result.New)
                                    _setSpace.Cached.Add(result.Value);
                                return result.Value;
                            }
                            else
                                return e;
                        });
                }

                return result;
            }
            else
            {
                return Array.Empty<TEntity>();
            }
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            return GetEntities().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        internal object Execute(Expression<Func<TEntity, bool>> expression)
        {
            var visitor = new QueryVisitor<TEntity>();
            visitor.Visit(expression);

            var result = _setSpace.Find(visitor.Template);
            var filter = expression.Compile();
            return result.Where(filter);
        }

        public IQueryable CreateQuery(Expression expression)
        {
            if (expression.Type == typeof(TEntity))
            {
                _expresion = expression;
                var res = this.GetEntities();
                return res.AsQueryable();
            }
            throw new NotSupportedException("Join queries are not supported");
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            if (typeof(TElement) == typeof(TEntity))
            {
                _expresion = expression;
                var res = this.GetEntities();
                return (IQueryable<TElement>)res.AsQueryable();
            }
            throw new NotSupportedException("Join queries are not supported");
        }

        public object? Execute(Expression expression)
        {
            throw new NotImplementedException("Not needed for Hiperspace queries");
        }

        public TResult Execute<TResult>(Expression expression)
        {
            throw new NotImplementedException("Not needed for Hiperspace queries");
        }
    }
}
