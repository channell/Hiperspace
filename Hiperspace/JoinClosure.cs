// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Hiperspace
{
    /// <summary>
    /// Provides a generic closure for joining two queryable collections using custom projection and predicate
    /// expressions.
    /// </summary>
    /// <remarks>
    /// Uses the closure functions to extract join conditions from left and right results, built by the QueryOptimizer,
    /// and creates a predicate to compare the two sides and copy the left closure to the template class for the right
    /// NB the predicate matches the 'C' convention that null is no-value, rather than SQL convention.
    ///    Hiperspace uses template to select the index to use when finding elements
    /// Builds Expressions to to compare 
    /// Use this class to define join logic between two collections by specifying projection
    /// functions and a predicate for matching elements. The join operation supports custom copying and comparison
    /// logic, allowing for flexible join scenarios beyond standard equality. This class is typically used in advanced
    /// </remarks>
    /// <typeparam name="TLeft">The type of the elements in the left collection to be joined. Must be a reference type.</typeparam>
    /// <typeparam name="TRight">The type of the elements in the right collection to be joined. Must be a reference type.</typeparam>
    /// <typeparam name="LambdaLeft">The type produced by projecting the join conditions from the left collection. Must be a reference type.</typeparam>
    /// <typeparam name="LambdaRight">The type produced by projecting the join conditions from the right collection. Must be a reference type.</typeparam>
    public class JoinClosure<TLeft, TRight, LambdaLeft, LambdaRight> : IJoinClosure<TLeft, TRight>
        where TLeft : class
        where TRight : class
    {
        Expression<Func<TLeft, LambdaLeft>> _leftFunctor;
        Expression<Func<TRight, LambdaRight>> _rightFunctor;
        Expression<Func<LambdaLeft, LambdaRight, bool>> _predicate;
        Expression<Func<LambdaLeft, TRight, TRight>> _copy;


        public JoinClosure(Expression<Func<TLeft, LambdaLeft>> left, Expression<Func<TRight, LambdaRight>> right)
        {
            _leftFunctor = left;
            _rightFunctor = right;
            _predicate = MakeClosure(left, right);
            _copy = MakeCopy(left, right);
        }
        Expression<Func<LambdaLeft, LambdaRight, bool>> MakeClosure(Expression<Func<TLeft, LambdaLeft>> left, Expression<Func<TRight, LambdaRight>> right)
        {
            var isClass = typeof(LambdaLeft).IsClass && typeof(LambdaLeft) != typeof(string);
            var leftParameter = Expression.Parameter(typeof(LambdaLeft), "l");
            var rightParameter = Expression.Parameter(typeof(LambdaRight), "r");

            if (isClass)
            {
                var leftProperty = typeof(LambdaLeft).GetProperties(BindingFlags.Instance | BindingFlags.Public);
                var rightProperty = typeof(LambdaRight).GetProperties(BindingFlags.Instance | BindingFlags.Public);
                Expression predicate = Expression.Constant(true);
                for (int c = 0; c < leftProperty.Length; c++)
                {
                    var leftAccess = Expression.Property(leftParameter, leftProperty[c]);
                    var rightAccess = Expression.Property(rightParameter, rightProperty[c]);
                    var equal = Expression.Equal(leftAccess, rightAccess);

                    if ((!leftProperty[c].PropertyType.IsValueType || leftProperty[c].PropertyType.IsSubclassOf(typeof(Nullable<>))) &&
                        (!rightProperty[c].PropertyType.IsValueType || rightProperty[c].PropertyType.IsSubclassOf(typeof(Nullable<>))))
                    {
                        var leftNull = Expression.Constant(null, leftProperty[c].PropertyType);
                        var rightNull = Expression.Constant(null, rightProperty[c].PropertyType);
                        var leftIsNull = Expression.Equal(leftAccess, leftNull);
                        var rightIsNull = Expression.Equal(rightAccess, rightNull);
                        var bothNull = Expression.AndAlso(leftIsNull, rightIsNull);
                        var either = Expression.OrElse(bothNull, equal);
                        predicate = Expression.AndAlso(predicate, either);
                    }
                    else
                    {
                        predicate = Expression.AndAlso(predicate, equal);
                    }
                }
                return Expression.Lambda<Func<LambdaLeft, LambdaRight, bool>>(predicate, rightParameter, leftParameter);
            }
            else
            {
                var equal = Expression.Equal(leftParameter, rightParameter);
                if ((!leftParameter.Type.IsValueType || leftParameter.Type.IsSubclassOf(typeof(Nullable<>))) &&
                    (!leftParameter.Type.IsValueType || leftParameter.Type.IsSubclassOf(typeof(Nullable<>))))
                {
                    var leftNull = Expression.Constant(null, leftParameter.Type);
                    var rightNull = Expression.Constant(null, rightParameter.Type);
                    var leftIsNull = Expression.Equal(leftParameter, leftNull);
                    var rightIsNull = Expression.Equal(rightParameter, rightNull);
                    var bothNull = Expression.AndAlso(leftIsNull, rightIsNull);
                    var predicate = Expression.OrElse(bothNull, equal);
                    return Expression.Lambda<Func<LambdaLeft, LambdaRight, bool>>(predicate, rightParameter, leftParameter);
                }
                else
                {
                    return Expression.Lambda<Func<LambdaLeft, LambdaRight, bool>>(equal, rightParameter, leftParameter);
                }
            }
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        bool Equal(Func<TLeft, LambdaLeft> leftFunctor, Func<TRight, LambdaRight> rightFunctor, Func<LambdaLeft, LambdaRight, bool> predicate, TLeft left, TRight right)
        {
            var leftClosure = leftFunctor(left);
            var rightClosure = rightFunctor(right);
            return predicate(leftClosure!, rightClosure!);
        }

        Expression<Func<LambdaLeft, TRight, TRight>> MakeCopy(Expression<Func<TLeft, LambdaLeft>> left, Expression<Func<TRight, LambdaRight>> right)
        {
            var leftClosure = Expression.Parameter(typeof(LambdaLeft), "c");
            var current = Expression.Parameter(typeof(TRight), "r");
            var newElement = Expression.New(typeof(TRight));
            var elementProperty =
                typeof(TRight).GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty);

            if (!(typeof(LambdaLeft).IsValueType || Nullable.GetUnderlyingType(typeof(LambdaLeft)) is null))
            {
                var closureProperty =
                    typeof(LambdaLeft).GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Select(p => (p.Name, p))
                    .ToDictionary(k => k.Name, v => v.p);

                var pams = new List<MemberBinding>();
                for (int c = 0; c < elementProperty.Length; c++)
                {
                    if (closureProperty.TryGetValue(elementProperty[c].Name, out PropertyInfo? property))
                    {
                        var leftProperty = Expression.Property(leftClosure, property);
                        var rightProperty = Expression.Property(current, elementProperty[c]);
                        // prefer residual condition over join condition
                        var coalesce = Expression.Coalesce(rightProperty, leftProperty);
                        pams.Add(Expression.Bind(elementProperty[c], coalesce));
                    }
                    else
                    {
                        var value = Expression.Property(current, elementProperty[c]);
                        pams.Add(Expression.Bind(elementProperty[c], value));
                    }
                }
                var init = Expression.MemberInit(newElement, pams.ToArray());
                return Expression.Lambda<Func<LambdaLeft, TRight, TRight>>(init, leftClosure, current);
            }
            else
            {
                var body = left.Body as MemberExpression;
                var member = body?.Member;
                var memberName = member?.Name;

                var pams = new List<MemberBinding>();
                for (int c = 0; c < elementProperty.Length; c++)
                {
                    if (elementProperty[c].Name == memberName)
                    {
                        var leftProperty = leftClosure;
                        var rightProperty = Expression.Property(current, elementProperty[c]);
                        // prefer residual condition over join condition
                        var coalesce = Expression.Coalesce(rightProperty, leftProperty);
                        pams.Add(Expression.Bind(elementProperty[c], coalesce));
                    }
                    else if (elementProperty[c].SetMethod is not null)
                    {
                        var value = Expression.Property(current, elementProperty[c]);
                        pams.Add(Expression.Bind(elementProperty[c], value));
                    }
                }
                var init = Expression.MemberInit(newElement, pams.ToArray());
                return Expression.Lambda<Func<LambdaLeft, TRight, TRight>>(init, leftClosure, current);
            }
        }

        public IEnumerator<TResult> GetEnumerator<TResult>(IQueryable<TLeft> leftQuery, IQueryable<TRight> rightQuery, Func<TLeft, TRight, TResult> closureFactory)
        {
            var leftFunctor = _leftFunctor.Compile();
            var rightFunctor = _rightFunctor.Compile();
            var predicate = _predicate.Compile();
            var copy = _copy.Compile();

            var setJoin = leftQuery as ISetJoin;
            var setLeft = leftQuery as ISetQuery;
            var setRight = rightQuery as ISetQuery;

            if (setLeft is not null)
            {
                foreach (var left in leftQuery)
                {
                    var leftClosure = leftFunctor(left);
                    if (setRight is not null && setRight.Template is TRight rightSet)
                    {
                        setRight.Template = copy(leftClosure, rightSet);
                        foreach (var right in rightQuery)
                        {
                            if (Equal(leftFunctor, rightFunctor, predicate, left, right))
                                yield return closureFactory(left, right);
                        }
                    }
                    else // cross join to non-hiperspace collection
                    {
                        foreach (var right in rightQuery)
                        {
                            if (Equal(leftFunctor, rightFunctor, predicate, left, right))
                                yield return closureFactory(left, right);
                        }
                    }
                }
            }
            else if (setJoin is not null)
            {
                foreach (var left in leftQuery)
                {
                    var leftClosure = leftFunctor(left);
                    if (setRight is not null)
                    {
                        if (setRight is not null && setRight.Template is TRight rightSet)
                        {
                            setRight.Template = copy(leftClosure, rightSet);
                            foreach (var right in rightQuery)
                            {
                                if (Equal(leftFunctor, rightFunctor, predicate, left, right))
                                    yield return closureFactory(left, right);
                            }
                        }
                    }
                    else // cross join to non-hiperspace collection
                    {
                        foreach (var right in rightQuery)
                        {
                            if (Equal(leftFunctor, rightFunctor, predicate, left, right))
                                yield return closureFactory(left, right);
                        }
                    }
                }
            }
        }
    }
}
