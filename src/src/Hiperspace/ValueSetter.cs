// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hiperspace
{
    public class ValueSetter : ExpressionVisitor
    {
        protected MemberExpression? _node;
        protected PropertyInfo? _property;
        protected ValueSetter? _prior;
        protected object? _value;

        public static ValueSetter Empty = new ValueSetter();

        public ValueSetter() { }
        public ValueSetter(PropertyInfo property, MemberExpression expression)
        {
            _property = property;
            _node = expression;
            if (expression.Expression is MemberExpression me)
            {
                _prior = new ValueSetter(property, me);
            }
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            var result = base.VisitMember(node);
            if (node.Expression is MemberExpression me)
            {
                try
                {
                    if (result is MemberExpression memberExpression &&
                        memberExpression.Expression?.Type is not null)
                    {
                        var nullValue =
                            memberExpression.Expression.Type.IsValueType ?
                            Expression.Constant(Activator.CreateInstance(memberExpression.Expression.Type), memberExpression.Expression.Type) :
                            Expression.Constant(null, memberExpression.Expression.Type);
                        var nullResult =
                            result.Type.IsValueType ?
                            Expression.Constant(Activator.CreateInstance(result.Type), result.Type) :
                            Expression.Constant(null, result.Type);
                        var isNull = Expression.Equal(memberExpression.Expression, nullValue);
                        var condition = Expression.Condition(isNull, nullResult, result);
                        result = condition;
                    }
                }
                catch { } // will fail if memberExpression.Expression is malformed.. do not use null coalescing
            }
            return result;
        }
 
        public object? GetTargetMember (object? target, PropertyInfo property, Queue<(object? obj, PropertyInfo? pi)> queue)
        {
            object? item = null;
            if (_prior is not null)
            {
                target = _prior.GetTargetMember(target, property, queue);
            }
            if (_node?.Member is PropertyInfo pi)
            {
                item = pi.GetValue(target);
                var type = pi.GetModifiedPropertyType();
                var under = Nullable.GetUnderlyingType(type);
                if (pi.CanWrite)
                {
                    if (type.UnderlyingSystemType == typeof(string))
                    {
                        queue.Enqueue((item, pi));
                    }
                    else if (under is not null && item is null)
                    {
                        item = Activator.CreateInstance(under);
                        queue.Enqueue((item, pi));
                        pi.SetValue(target, item);

                        return item;
                    }
                    else if (item is null)
                    {
                        item = Activator.CreateInstance(type);
                        queue.Enqueue((item, pi));
                    }
                    else 
                    {
                        queue.Enqueue((item, pi));
                    }
                }
                return item;
            }
            return item;
        }

        /// <summary>
        /// Used to compensate for value marshalling of struct members
        /// </summary>
        /// <remarks>
        /// if a predicate has the form "class c1 -> struct s1 -> struct s2" s1 will lack the update of s2
        /// without recursive setting.
        /// </remarks>
        class RecursiveSetter
        {
            private object? Obj;
            private PropertyInfo? Pi;
            private RecursiveSetter? Prior;
            
            // root
            public RecursiveSetter(object? obj)
            {
                Obj = obj;
            }
            public RecursiveSetter((object? obj, PropertyInfo? pi) frame, RecursiveSetter? prior = null)
            {
                Obj = frame.obj;
                Pi = frame.pi;
                Prior = prior;
                SetValue(frame.obj);
            }
            public void SetValue(object? obj)
            {
                if (Prior != null)
                {
                    Pi?.SetValue(Prior.Obj, obj);
                    Prior.SetValue(Prior.Obj);
                }
            }
        }

        public void SetValue(object? target, object? value)
        {
            if (target == null || _property == null) return;

            var queue = new Queue<(object? obj, PropertyInfo? pi)> ();
            var item = GetTargetMember(target, _property, queue);

            var prior = new RecursiveSetter(target);
            (object? obj, PropertyInfo? pi) apply = default;
            while (queue.TryDequeue(out apply))
            {
                prior = new RecursiveSetter(apply, prior);
            }
            prior.SetValue(value);
        }
    }
}
