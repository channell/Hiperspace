// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Linq.Expressions;
using System.Text;

namespace Hiperspace
{
    /// <summary>
    /// Represents a class that visits and explains the structure of a query expression.
    /// </summary>
    public class QueryExplain : ExpressionVisitor
    {
        /// <summary>
        /// Represents an explanation of a specific area in the query expression.
        /// </summary>
        public class Explain
        {
            /// <summary>
            /// Gets or sets the area of the explanation.
            /// </summary>
            public string? Area { get; set; }

            /// <summary>
            /// Gets or sets the message of the explanation.
            /// </summary>
            public string? Message { get; set; }

            /// <summary>
            /// Gets the list of child explanations.
            /// </summary>
            public List<Explain> Children { get; } = new List<Explain>();

            /// <summary>
            /// Converts the explanation to a string representation with the specified indentation level.
            /// </summary>
            /// <param name="level">The indentation level.</param>
            /// <returns>The string representation of the explanation.</returns>
            public string ToString(int level)
            {
                var indent = new string(' ', level * 2);
                if (Children.Count > 0)
                {
                    var str = $"{indent} {Area} {Message}\n";
                    foreach (var child in Children)
                    {
                        var cs = child.ToString(level + 1);
                        if (!string.IsNullOrWhiteSpace(cs))
                            str = $"{str}{cs}";
                    }
                    return str;
                }
                else
                {
                    return $"{indent} {Area} {Message}\n";
                }
            }

            /// <summary>
            /// Converts the explanation to a string representation.
            /// </summary>
            /// <returns>The string representation of the explanation.</returns>
            public override string ToString()
            {
                return ToString(0);
            }
        }

        private Stack<Explain> _stack = new Stack<Explain>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryExplain"/> class with the specified query expression.
        /// </summary>
        /// <param name="expression">The query expression to explain.</param>
        public QueryExplain(Expression expression) : base()
        {
            _stack.Push(new Explain { Area = "Query" });
            Visit(expression);
        }

        /// <summary>
        /// Visits the method call expression and adds an explanation for the method call.
        /// </summary>
        /// <param name="node">The method call expression to visit.</param>
        /// <returns>The visited method call expression.</returns>
        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            try
            {
                var next = new Explain() { Area = node.Method.Name, Message = node.ToString() };
                var current = _stack.Peek();
                current.Children.Add(next);
                _stack.Push(next);
                return base.VisitMethodCall(node);
            }
            finally
            {
                _stack.Pop();
            }
        }

        /// <summary>
        /// Gets the template explanation for the specified template object.
        /// </summary>
        /// <param name="template">The template object.</param>
        /// <param name="outer">The outer object.</param>
        /// <returns>The template explanation.</returns>
        private Explain GetTemplate(object template, object? outer = null)
        {
            var sb = new StringBuilder();
            sb.Append($"{template.GetType().Name} (");
            var comma = "";
            foreach (var prop in template.GetType().GetProperties())
            {
                if ((prop.PropertyType.IsValueType || prop.PropertyType == typeof(string)) && prop.Name != "AsAt")
                {
                    var val = prop.GetValue(template);
                    if (val != null)
                    {
                        sb.Append($"{comma}{prop.Name}={val}");
                        comma = ", ";
                    }
                    if (outer != null && prop.Name != "SKey" && val == null)
                    {
                        val = prop.GetValue(outer);
                        if (val != null)
                        {
                            sb.Append($"{comma}{prop.Name}=left.{prop.Name}");
                            comma = ", ";
                        }
                    }
                }
            }
            sb.Append(")");
            return new Explain() { Message = sb.ToString() };
        }

        /// <summary>
        /// Visits the query expression and adds an explanation for the query.
        /// </summary>
        /// <param name="sq">The query expression to visit.</param>
        /// <param name="template">The template object.</param>
        protected void VisitQuery(ISetQuery sq, object? template = null)
        {
            var (path, name) = template == null ? sq.Explain() : sq.Explain(template);
            var next = sq.IsJoin ? new Explain() { Area = "Loop", Message = name } : new Explain() { Area = path, Message = name + " as " + sq.Alias };
            next.Children.Add(GetTemplate(sq.Template, template));
            var current = _stack.Peek();
            current.Children.Add(next);
        }

        /// <summary>
        /// Visits the join expression and adds an explanation for the join.
        /// </summary>
        /// <param name="sj">The join expression to visit.</param>
        protected void VisitJoin(ISetJoin sj)
        {
            var current = _stack.Peek();
            var next = new Explain() { Area = "Nested Loop" };
            current.Children.Add(next);
            _stack.Push(next);

            if (sj.Inner != null)
            {
                VisitJoin(sj.Inner);
            }
            else if (sj.Left != null)
            {
                VisitQuery(sj.Left);
            }
            if (sj.Right != null)
            {
                var template = Activator.CreateInstance(sj.Right.ElementType, new object[] { sj.Right.Template, null! });
                var joins = "";
                if (template != null)
                {
                    foreach (var prop in sj.Joins)
                    {
                        joins += $", {prop.left.property?.Name} = {prop.right.alias}.{prop.right.property?.Name}";
                        if (prop.right.property != null)
                        {
                            if (prop.right.property.PropertyType.IsValueType)
                            {
                                if (prop.right.property.PropertyType.IsGenericType && prop.right.property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                                {
                                    var vt = prop.right.property.PropertyType.GetGenericArguments()[0];
                                    if (vt == typeof(int)) prop.right.property.SetValue(template, 1);
                                    else if (vt == typeof(long)) prop.right.property.SetValue(template, 1L);
                                    else if (vt == typeof(double)) prop.right.property.SetValue(template, 1.0);
                                    else if (vt == typeof(DateTime)) prop.right.property.SetValue(template, DateTime.Now);
                                    else if (vt == typeof(bool)) prop.right.property.SetValue(template, true);
                                    else if (vt == typeof(Guid)) prop.right.property.SetValue(template, Guid.NewGuid());
                                    else if (vt == typeof(decimal)) prop.right.property.SetValue(template, 1.0m);
                                    else if (vt == typeof(float)) prop.right.property.SetValue(template, 1.0f);
                                    else if (vt == typeof(short)) prop.right.property.SetValue(template, (short)1);
                                    else if (vt == typeof(byte)) prop.right.property.SetValue(template, (byte)1);
                                    else if (vt == typeof(char)) prop.right.property.SetValue(template, '1');
                                }
                            }
                            else if (prop.right.property.PropertyType == typeof(string))
                            {
                                prop.right.property.SetValue(template, "..");
                            }
                        }
                    }
                }
                if (joins.Length > 2) 
                    next.Message = $"on ({joins.Substring(2)})";
                VisitQuery(sj.Right, template);
            }
            _stack.Pop();
        }

        /// <summary>
        /// Visits the constant expression and adds an explanation for the query or join.
        /// </summary>
        /// <param name="node">The constant expression to visit.</param>
        /// <returns>The visited constant expression.</returns>
        protected override Expression VisitConstant(ConstantExpression node)
        {
            if (node?.Value is ISetQuery sq)
            {
                VisitQuery(sq);
            }
            else if (node?.Value is ISetJoin sj)
            {
                VisitJoin(sj);
            }
            return base.VisitConstant(node!);
        }

        /// <summary>
        /// Converts the query explanation to a string representation.
        /// </summary>
        /// <returns>The string representation of the query explanation.</returns>
        public override string ToString()
        {
            return _stack.Peek().ToString();
        }
    }
}