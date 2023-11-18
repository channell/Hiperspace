using System.Linq.Expressions;
using System.Reflection;

namespace Hiperspace
{
    /// <summary>
    /// Visits an expression and extracts template values that 
    /// can be passed into a Find function to search the Hipersapce
    /// for matching entities
    /// </summary>
    /// <typeparam name="TEntity">the type of object being searched</typeparam>
    public class QueryVisitor<TEntity> : ExpressionVisitor
        where TEntity : class, new()
    {
        public TEntity Template { get; private set; }

        public Expression<Func<TEntity, bool>>? Expresion { get; private set; }

        private bool _currentlySearable = true;
        private HashSet<PropertyInfo> _properties =
            typeof(TEntity).GetProperties().ToHashSet();

        public QueryVisitor() 
        {
            Template = new TEntity();
        }

        public override Expression? Visit(Expression? node)
        {
            if (node is Expression<Func<TEntity, bool>> pred)
            {
                Expresion = pred;
            }
            return base.Visit(node);
        }

        protected override Expression VisitBinary(BinaryExpression b)
        {
            switch (b.NodeType)
            {
                case ExpressionType.OrElse:
                    _currentlySearable = false;
                    break;
                case ExpressionType.AndAlso:
                    return base.VisitBinary(b);
                case ExpressionType.Equal when _currentlySearable:
                    var tup = Predicate(b);
                    if (tup.Item1 != null)
                    {
                        tup.Item1.SetValue(Template, tup.Item2);
                    }
                    break;
            }
            return base.VisitBinary(b);
        }
        private ValueTuple<PropertyInfo?, object?> Predicate(BinaryExpression b)
        {
            var left = PropertyOrValue(b.Left);
            var right = PropertyOrValue(b.Right);

            if (left.Item1 != null && _properties.Contains(left.Item1) && right.Item2 != null)
            {
                return ValueTuple.Create(left.Item1, right.Item2);
            }
            else if (right.Item1 != null && _properties.Contains(right.Item1) && left.Item2 != null)
            {
                return ValueTuple.Create(right.Item1, left.Item2);
            }
            else
            {
                return new ValueTuple<PropertyInfo?, object?>(null, null);
            }
        }
        private ValueTuple<PropertyInfo?, object?> PropertyOrValue(Expression expr)
        {
            PropertyInfo? prop = null;
            object? value = null;

            switch (expr.NodeType)
            {
                case ExpressionType.MemberAccess:
                    var mem = expr as MemberExpression;
                    if (mem?.Member is PropertyInfo pi)
                        prop = pi;
                    else if (mem?.Member is FieldInfo fi && mem?.Expression is ConstantExpression ce)
                    {
                        value = fi?.GetValue(ce.Value);
                    }
                    break;
                case ExpressionType.Constant:
                    var cev = expr as ConstantExpression;
                    value = cev?.Value;
                    break;
            }
            return ValueTuple.Create(prop, value);
        }
    }
}
