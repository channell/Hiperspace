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
    public class SetQuery<TEntity> : IOrderedQueryable<TEntity>, ISetQuery
        where TEntity : Element<TEntity>, new()
    {
        protected RunQuery<TEntity> _runQuery;
        protected Expression _expression;
        protected IQueryProvider _provider;

        public SetQuery(SetSpace<TEntity> setspace, IQueryProvider provider, TEntity template)
        {
            _runQuery = new RunQuery<TEntity>(setspace, template);
            _expression = Expression.Constant(this);
            _provider = provider ?? throw new ArgumentNullException(nameof(provider));
        }
        public ISetQuery Runnable => _runQuery;

        public IQueryProvider Provider => _provider;

        public Type ElementType => typeof(TEntity);

        public Expression Expression => _expression;

        public string? Alias { get => _runQuery.Alias; set => _runQuery.Alias = value; }

        public object Template => _runQuery.Template;

        public object Space => _runQuery.Space;

        public bool IsJoin => _runQuery.IsJoin;

        public (string?, string?) Explain()
        {
            return _runQuery.Explain();
        }

        public (string?, string?) Explain(object template)
        {
            return _runQuery.Explain(template);
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            return _runQuery.GetEnumerator();
        }

        [Obsolete]
        public void Join(ISetQuery left, List<(PropertyInfo left, PropertyInfo right)> joins)
        {
            _runQuery.Join(left, joins);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class RunQuery<TEntity> : IEnumerable<TEntity>, ISetQuery
        where TEntity : Element<TEntity>, new()
    {
        protected SetSpace<TEntity> _setSpace;
        protected TEntity _template;
        public object Template => _template;

        public RunQuery(SetSpace<TEntity> setspace, TEntity template)
        {
            _setSpace = setspace;
            _template = template;
        }

        public ISetQuery Runnable => this;

        public string? Alias { get; set; }
        public Type ElementType => typeof(TEntity);

        private ISetQuery? _left;
        private List<(PropertyInfo left, PropertyInfo right)>? _joins;

        [Obsolete]
        public void Join (ISetQuery left, List<(PropertyInfo left, PropertyInfo right)> joins)
        {
            _left = left;
            _joins = joins;
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            return _setSpace.Find(_template, true).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public bool IsJoin => _left != null;

        public object Space => _setSpace.Space;

        public (string?, string?) Explain()
        {
            return _setSpace.Explain(_template);
        }
        public (string?, string?) Explain(object template)
        {
            if (template is TEntity e)
                return _setSpace.Explain(e);
            else
                return (null, null);
        }
    }
}
