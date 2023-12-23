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
    public class Query<TEntity> : IOrderedQueryable<TEntity>
        where TEntity : Element<TEntity>, new()
    {
        protected SetSpace<TEntity> _setSpace;
        protected Expression _expresion;
        public Query(SetSpace<TEntity> setspace, IQueryProvider provider)
        {
            _setSpace = setspace;
            _expresion = Expression.Constant(this);
            Provider = provider;
        }
        public Query(SetSpace<TEntity> setspace, IQueryProvider provider, Expression expresion)
        {
            _setSpace = setspace;
            _expresion = expresion;
            Provider = provider;
        }

        public Type ElementType => typeof(TEntity);

        public Expression Expression => _expresion;

        public IQueryProvider Provider { get; init; }

        public IEnumerator<TEntity> GetEnumerator()
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
                                            ((HashSet<TEntity>)_setSpace).Add(result.Value);
                                        return result.Value;
                                    }
                                    else 
                                        return e;
                                })
                                .GetEnumerator();
                        }
                        return result.Where(func).GetEnumerator();
                    }
                }
                return result.GetEnumerator();
            }
            else
            {
                return Array.Empty<TEntity>().AsEnumerable().GetEnumerator();
            }
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
    }
}
