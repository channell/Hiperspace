// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Hiperspace
{

    public class QueryOptimizer : ExpressionVisitor
    {
        protected class TreeType
        {
            public enum PathType
            {
                /// <summary>From a setspace</summary>
                From,
                /// <summary>Value member</summary>
                Constant,
                /// <summary>property value</summary>
                Property,
                /// <summary>Identify the target setspace</summary>
                Target,
                /// <summary>Set the alias name</summary>
                Alias,
                /// <summary>Join of queryables</summary>
                Join,
                /// <summary>member access</summary>
                Member,
                /// <summary>Binary expression</summary>
                Binary,
                /// <summary>unary function</summary>
                Unary,
                /// <summary>Indexer</summary>
                Index,
                Lambda,
                /// <summary>new expression</summary>
                New,
                /// <summary>Method call</summary>
                Call,
            }
            public PathType Type { get; set; }

            public bool InJoin
            {
                get
                {
                    if (Type == PathType.Join)
                        return true;
                    else if (Parent is not null)
                        return Parent.InJoin;
                    else
                        return false;
                }
            }

            public TreeType(Expression node)
            {
                Node = node;
            }
            public TreeType(Expression node, TreeType parent)
            {
                Node = node;
                Parent = parent;
                parent.Children.Add(this);
            }
            public TreeType Next(Expression node)
            {
                var next = new TreeType(node, this);
                return next;
            }
            public Expression Node;
            public TreeType? Parent;
            public ISetQuery? FromSet { get; set; }
            public ISetJoin? FromJoin { get; set; }

            public List<TreeType> Children = new List<TreeType>();
            private List<Expression>? _arguments;
            public List<Expression> Arguments
            {
                get
                {
                    if (_arguments is null && Parent is not null)
                        return Parent.Arguments;
                    else if (_arguments is not null)
                        return _arguments;
                    else
                        return new List<Expression>();
                }
                set
                {
                    _arguments = value;
                }
            }
            protected object? _target;
            public object? Target
            {
                get
                {
                    if (_target is not null)
                        return _target;
                    foreach(var child in Children.ToArray())
                    {
                        var result = child.Target;
                        if (result is not null)
                            return result;
                    }
                    return null;
                }
                set
                {
                    _target = value;
                }
            }
            protected PropertyInfo? _PropertyInfo;
            public PropertyInfo? PropertyInfo
            {
                get
                {
                    if (_PropertyInfo is not null)
                        return _PropertyInfo;
                    foreach (var child in Children.ToArray())
                    {
                        var result = child.PropertyInfo;
                        if (result is not null)
                            return result;
                    }
                    return null;
                }
                set
                {
                    _PropertyInfo = value;
                }
            }
            public IEnumerable<(string alias, PropertyInfo property)> GetProperties()
            {
                if (_PropertyInfo is not null)
                    yield return (ParentSetName, _PropertyInfo);
                foreach (var child in Children.ToArray())
                {
                    foreach (var item in child.GetProperties())
                    {
                        yield return item;
                    }
                }
            }
            private bool HasPropertyNotComposite()
            {
                if (Type == PathType.New)
                    return false;

                if (_PropertyInfo is not null)
                    return true;

                foreach (var child in Children.ToArray())
                {
                    if (child.HasPropertyNotComposite())
                        return true;
                }
                return false;
            }

            public static IEnumerable<TreeType> CompositeKeys(TreeType current)
            {
                if (current.Type == PathType.New)
                {
                    foreach (var child in current.Children.ToArray())
                    {
                        foreach (var item in CompositeKeys(child))
                        {
                            yield return item;
                        }
                        if (child.HasPropertyNotComposite())
                            yield return child;
                    }
                }
                else
                {
                    foreach (var child in current.Children.ToArray())
                    {
                        foreach (var item in CompositeKeys(child))
                        {
                            yield return item;
                        }
                    }
                }
            }
            public IEnumerable<(string alias, ValueGetter property)> GetSelectors()
            {
                var composite = CompositeKeys(this).ToArray();

                // composite 
                if (composite.Length > 0)   
                {
                    foreach (var node in composite)
                    {
                        var alias = node.SetName;
                        var getter = node.Getter();
                        if (alias is not null && getter is not null)
                            yield return (alias, getter);
                    }
                }
                else
                {
                    var alias = SetName;
                    var getter = Getter();
                    if (alias is not null && getter is not null)
                        yield return (alias, getter);
                }
            }

            public LambdaExpression? GetLambda()
            {
                if (_LambdaExpression is not null)
                    return _LambdaExpression;
                else
                {
                    foreach (var child in Children)
                    {
                        var l = child.GetLambda();
                        if (l is not null)
                            return l;
                    }
                }
                return null;
            }

            protected FieldInfo? _FieldInfo;
            public FieldInfo? FieldInfo
            {
                get
                {
                    if (_FieldInfo is not null)
                        return _FieldInfo;
                    foreach (var child in Children.ToArray())
                    {
                        var result = child.FieldInfo;
                        if (result is not null)
                            return result;
                    }
                    return null;
                }
                set
                {
                    _FieldInfo = value;
                }
            }
            protected object? _Value;
            public object? Value
            {
                get
                {
                    if (_Value is not null)
                        return _Value;
                    foreach (var child in Children.ToArray())
                    {
                        var result = child.Value;
                        if (result is not null)
                            return result;
                    }
                    return null;
                }
                set
                {
                    _Value = value;
                }
            }

            public ValueGetter Getter()
            {
                var c = Children.Count;
                switch (c)
                {
                    case 0:
                        return ValueGetter.Value(_Value);

                    case 1:
                        {
                            var result = Children[0].Getter();
                            if (_FieldInfo is not null)
                                return result.Field(_FieldInfo);
                            else if (_PropertyInfo is not null)
                                return result.Property(_PropertyInfo);
                            else
                                return result;
                        }

                    case 2:
                        {
                            var result = Children[0].Getter();
                            var index = Children[1].Getter();
                            if (result is not null && index is not null)
                                return result.Index(index);
                            else if (result is not null)
                                return result;
                            else
                                return ValueGetter.Value(_Value);
                        }

                    default:
                        return ValueGetter.Value(_Value);
                }
            }

            protected Type? _ClosureType;
            public Type? ClosureType
            {
                get
                {
                    if (_ClosureType is not null)
                        return _ClosureType;
                    foreach (var child in Children.ToArray())
                    {
                        var result = child.ClosureType;
                        if (result is not null)
                            return result;
                    }
                    return null;
                }
                set
                {
                    _ClosureType = value;
                }
            }
            protected LambdaExpression? _LambdaExpression;
            public LambdaExpression? LambdaExpression
            {
                get
                {
                    if (_LambdaExpression is not null)
                        return _LambdaExpression;
                    foreach (var child in Children.ToArray())
                    {
                        var result = child.LambdaExpression;
                        if (result is not null)
                            return result;
                    }
                    return null;
                }
                set
                {
                    _LambdaExpression = value;
                }
            }

            protected string? _SetName;
            public string? SetName 
            { 
                get
                {
                    if (_SetName is not null)
                        return _SetName;
                    foreach (var child in Children.ToArray())
                    {
                        var result = child.SetName;
                        if (result is not null)
                            return result;
                    }
                    return null;
                }
                set
                {
                    _SetName = value;
                }
            }
            
            public string ParentSetName
            {
                get
                {
                    if (_SetName is not null)
                        return _SetName;
                    else if (Parent is not null)
                        return Parent.SetName!;
                    else
                        return null!;
                }
            }

            private string? _Name;
            public string? Name
            {
                get
                {
                    if (_Name is null && Parent is not null)
                        return Parent.Name;
                    else if (_Name is not null)
                        return _Name;
                    else
                        return null;
                }
                set
                {
                    _Name = value;
                }
            }
            private int? _Position;
            public int? Position
            {
                get
                {
                    if (_Position is null && Parent is not null)
                        return Parent.Position;
                    else if (_Position is not null)
                        return _Position;
                    else
                        return null;
                }
                set
                {
                    _Position = value;
                }
            }
            public bool? _Assignement;
            public bool Assignement
            {
                get
                {
                    if (_Assignement is null && Parent is not null)
                        return Parent.Assignement;
                    else if (_Assignement is not null)
                        return _Assignement.Value;
                    else
                        return false;
                }
                set
                {
                    _Assignement = value;
                }
            }
            private bool? _searchable;
            public bool Searchable
            {
                get
                {
                    if (Parent is not null && _searchable is null)
                        return Parent.Searchable;
                    else
                        return _searchable ?? true;
                }
                set
                {
                    if (_searchable is not null)
                        _searchable = value;
                    else if (Parent is not null)
                        Parent.Searchable = value;
                }
            }
            public void SetSearchable(bool value)
            {
                _searchable = value;
            }
            public override string ToString()
            {
                return ToString(0);
            }
            public string ToString(int level)
            {
                var indent = "\r" + (new string(' ', level * 2));
                var sb = new StringBuilder();

                sb.Append($"{indent}Type: {Type.ToString()}");

                if (Children.Count > 0)
                {
                    sb.Append($"{indent}Children:[");
                    foreach (var item in Children.ToArray())
                    {
                        sb.Append(indent);
                        sb.Append(item.ToString(level + 1));
                    }
                    sb.Append("]");
                }
                if (_Name is not null) sb.Append($"{indent}CubeName: {_Name}");
                if (_target is not null) sb.Append($"{indent}Target: {_target}");
                if (_PropertyInfo is not null) sb.Append($"{indent}PropertyInfo: {_PropertyInfo.Name}");
                if (_FieldInfo is not null) sb.Append($"{indent}FieldInfo: {_FieldInfo.Name}");
                if (_Value is not null) sb.Append($"{indent}Value: {_Value}");
                if (SetName is not null) sb.Append($"{indent}SetName: {SetName}");
                if (_Position is not null) sb.Append($"{indent}Position: {_Position}"); 
                if (_LambdaExpression is not null) sb.Append($"{indent}Lambda: {_LambdaExpression}");
                return sb.ToString();
            }
            public bool? FirstBinaryVisit;
        }

        public Stack<string> aliases = new Stack<string>();

        private Stack<TreeType> Tree = new Stack<TreeType>();

        private TreeType PushTree(Expression node, TreeType.PathType type)
        {
            if (Tree.TryPeek(out TreeType? parent) && parent is not null)
            {
                var result = parent.Next(node);
                result.Type = type;
                Tree.Push(result);
                return result;
            }
            else
            {
                var result = new TreeType(node);
                result.Type = type;

                Tree.Push(result);
                return result;
            }
        }
        private void PopTree()
        {
            if (Tree.TryPeek(out TreeType? current))
            {
                Tree.Pop();
                if (Tree.TryPeek(out TreeType? parent) && parent is not null)
                {
                    if (current?.Target is not null && parent?.Target is null && parent is not null)
                        parent.Target = current?.Target;
                }
            }
        }

        public class SourcesType
        {
            public Dictionary<string, ISetQuery> named = new Dictionary<string, ISetQuery>();

            public void Add(ISetQuery set)
            {
                if (set.Alias is null)
                    throw new ArgumentNullException("Alias must be set");
                else if (!named.ContainsKey(set.Alias))
                    named.Add(set.Alias, set);
            }
            public ISetQuery? Get(string name)
            {
                if (named.TryGetValue(name, out var result))
                    return result;
                return null;
            }
        }
        protected SourcesType Sources = new SourcesType();

        private Expression VisitWhere(MethodCallExpression node)
        {
            if (node.Arguments.Count != 2)
                throw new ArgumentException("Where must have two arguments");
            var path = PushTree(node, TreeType.PathType.From);
            try
            {
                var args = new List<Expression>(node.Arguments);
                path.Arguments = args;
                args[0] = Visit(node.Arguments[0]);
                args[1] = Visit(node.Arguments[1]);
                var from = path.Children.Count > 0 ? path.Children[0].FromSet : null;
                var join = path.Children.Count > 0 ? path.Children[0].FromJoin : null;
                var alias = path.Children.Count > 1 ? path.Children[1].SetName : null;
                if (from is not null && alias is not null)
                {
                    from.Alias = alias;
                    Sources.Add(from);
                    path.Children.RemoveAt(1);
                    args[1] = Visit(node.Arguments[1]);
                    return Expression.Call(node.Method, args);
                }
                else if (join is not null && alias is not null)
                {
                    //join.Alias = alias;
                    //Sources.Add(join);
                    path.Children.RemoveAt(1);
                    args[1] = Visit(node.Arguments[1]);
                    return Expression.Call(node.Method, args);
                }
                else
                {
                    return base.VisitMethodCall(node);
                }
            }
            finally
            {
                PopTree();
            }
        }
        private Expression VisitJoin(MethodCallExpression node)
        {
            if (node.Arguments.Count != 5)
                throw new ArgumentException("Join must have five arguments");
            var path = PushTree(node, TreeType.PathType.Join);
            try
            {
                var args = new List<Expression>(node.Arguments);
                path.Arguments = args;

                args[0] = Visit(node.Arguments[0]);
                var left = path.Children[0].FromSet;
                var join = path.Children[0].FromJoin;
                if (join is not null)
                {
                    var j = join;
                    while (j is not null)
                    {
                        if (j.Left is not null)
                        {
                            Sources.Add(j.Left);
                        }
                        if (j.Right is not null)
                        {
                            Sources.Add(j.Right);
                        }
                        if (j.Inner is not null)
                            j = j.Inner;
                        else
                            j = null;
                    }
                }

                args[1] = Visit(node.Arguments[1]);
                var right = path.Children[1].FromSet;

                args[2] = Visit(node.Arguments[2]);
                args[3] = Visit(node.Arguments[3]);

                var leftalias = path.Children[2].SetName;
                var rightalias = path.Children[3].SetName;
                if (left is not null)
                {
                    left.Alias = leftalias;
                    Sources.Add(left);
                }
                if (right is not null)
                {
                    right.Alias = rightalias;
                    Sources.Add(right);
                }

                var leftSelectors = path.Children[2].GetSelectors().ToArray();
                var rightProperties = path.Children[3].GetProperties().ToArray();

                var joins = new List<((string alias, ValueGetter property) left, (string alias, PropertyInfo property) right)>();

                // if they don't match it is because a SetSpace is being joined to an non-SetSpace ()
                // e.g. a collections such as an array -> a join condition can not be created to optimise the 
                // join, and must be performed by LINQ from the result
                if (leftSelectors.Length == rightProperties.Length)     
                    for (int c = 0; c < leftSelectors.Length; c++)
                    {
                        // only include join conditions that can be compared
                        if (rightProperties[c].property.PropertyType.IsAssignableFrom(leftSelectors[c].property.GetValueType()))
                            joins.Add((leftSelectors[c], rightProperties[c]));
                    }

                args[4] = Visit(node.Arguments[4]);
                var closure = path.Children[4].ClosureType;
                var lambda = path.Children[4].LambdaExpression;

                var residuals = (path.Children[2].GetLambda(), path.Children[3].GetLambda());

                if (left is not null && right is not null && closure is not null && lambda is not null)
                {
                    var setJoin = typeof(SetJoin<,,>).MakeGenericType(closure, left.ElementType, right.ElementType);
                    var instance = Activator.CreateInstance(setJoin, new object[] { left, right, joins, lambda, residuals});
                    return Expression.Constant(instance, setJoin);
                }
                if (join is not null && right is not null && closure is not null && lambda is not null)
                {
                    var setJoin = typeof(SetJoin<,,>).MakeGenericType(closure, join.ElementType, right.ElementType);
                    var instance = Activator.CreateInstance(setJoin, new object[] { join, right, joins, lambda, residuals});
                    return Expression.Constant(instance, setJoin);
                }
                else
                {
                    return base.VisitMethodCall(node);
                }
            }
            finally
            {
                PopTree();
            }
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            if (node.Method.Name == "Where")
            {
                return VisitWhere(node);
            }
            else if (node.Method.Name == "Join")
            {
                return VisitJoin(node);
            }
            else
            {
                try
                {
                    var path = PushTree(node, TreeType.PathType.Call);
                    return base.VisitMethodCall(node);
                }

                finally
                {
                    PopTree();
                }
            }
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            var path = PushTree(node, TreeType.PathType.Constant);
            try
            {
                if (node?.Value is Hiperspace.ISetQuery sq)
                {
                    node = Expression.Constant(sq, sq.GetType());
                    path.Type = TreeType.PathType.From;
                    path.FromSet = sq;
                    path.Target = sq.Template;
                    return node;
                }
                else if (node?.Value is ISetSpace ss)
                {
                    var q = ss.SetQuery();
                    node = Expression.Constant(q, q.GetType());
                    path.Type = TreeType.PathType.From;
                    path.FromSet = q;
                    path.Target = q.Template;
                    return node;
                }
                else if (node?.Value is ISetJoin sj)
                {
                    node = Expression.Constant(sj, sj.GetType());
                    path.Type = TreeType.PathType.From;
                    path.FromJoin = sj;
                    return node;
                }
                else
                {
                    path.Type = TreeType.PathType.Constant;
                    path.Value = node?.Value;
                    return base.VisitConstant(node!);
                }
            }
            finally
            {
                PopTree();
            }
        }
        private static bool IsElement(Type? type)
        {
            if (type is null)
                return false;
            Type? lastGeneric = null;
            var curentType = type;
            while (curentType is not null && curentType.IsGenericType)
            {
                lastGeneric = curentType;
                curentType = curentType.BaseType;
            }
            if (lastGeneric is not null && lastGeneric.GetGenericTypeDefinition() == typeof(Element<>))
                return true;
            else
                return false;
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            var path = PushTree(node, TreeType.PathType.Member);
            try
            {
                var args = path.Arguments;
                var i = path.Position ?? -1;
                var join = path.InJoin;
                var t = join ? i - 2 : i - 1;

                if (node.Member is PropertyInfo pi)
                {
                    path.Type = TreeType.PathType.Property;
                    path.PropertyInfo = pi;
                }

                // direct predicate
                if (t >= 0 && args is not null && 
                    args[t] is ConstantExpression ce && 
                    ce?.Value is ISetQuery sq && 
                    path.Parent?.FirstBinaryVisit == true)
                {
                    path.Target = sq.Template;
                    path.Type = TreeType.PathType.Property;
                    path.Parent.FirstBinaryVisit = false;
                    return node;
                }
                else
                {
                    if (IsElement(node.Type.BaseType))
                    {
                        var alias = Sources.Get(node.Member.Name);
                        if (alias is not null && node.Member is PropertyInfo pi2 && alias.ElementType == node.Type)
                        {
                            path.Target = alias.Template;
                            path.SetName = alias.Alias;
                        }
                        path.Type = TreeType.PathType.Target;
                    }
                }
                var result = base.VisitMember(node);
                if (node!.Expression is MemberExpression)
                {
                    if (result is MemberExpression memberExpression &&
                        memberExpression.Expression?.Type is not null &&
                        (!node.Type.IsValueType || node.Type.Name.StartsWith("Nullable")))
                    {
                        var nullValue = Expression.Constant(null, memberExpression.Expression.Type );
                        var nullResult = Expression.Constant(null, result.Type);
                        var isNull = Expression.Equal(memberExpression.Expression, nullValue);
                        var condition = Expression.Condition(isNull, nullResult, result);
                        result = condition;
                    }
                    path.Node = result;
                }
                if (path.Target is not null && node.Member is PropertyInfo pi3 && !IsElement(node.Type.BaseType))
                {
                    path.PropertyInfo = pi3;
                }
                else 
                {
                    var member = node.Member;
                    var value = node.Expression is ConstantExpression constantExpression ? constantExpression.Value : null;
                    var field = member as FieldInfo;
                    var name = member.Name;
                    if (value is not null && field is not null)
                    {
                        path.Target = value;
                        path.FieldInfo = field;
                    }
                }
                // replace c.Mother.Name {((((c).Mother).Name) - Name(Mother(c))} with c.Mother {(((c).Mother) - Mother(c)}
                if (path.Parent is not null && path.Parent.Type == TreeType.PathType.Property)
                {
                    var parentParent = path?.Parent?.Parent;
                    if (parentParent is not null)
                    {
                        parentParent.Children.Remove(path!.Parent);
                        parentParent.Children.Add(path);
                        path.Node = path.Parent.Node;   // the outer expression
                    }
                }
                return result;
            }
            finally
            {
                PopTree();
            }
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            var path = PushTree(node, TreeType.PathType.Member);
            try
            {
                if (node.Name is not null)
                {
                    if (IsElement(node.Type.BaseType))
                    { 
                        path.Type = TreeType.PathType.Alias;
                        path.SetName = node.Name;
                    }
                }

                path.Name = node?.Name;
                if (node?.Name is not null)
                    aliases.Push(node.Name);
                return base.VisitParameter(node!);
            }
            finally
            {
                PopTree();
            }
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            var path = PushTree(node, TreeType.PathType.Unary);
            int i = 0;
            try
            {
                var arg = path.Arguments;
                i = arg.FindIndex(e => e == node);
                path.Position = i;

                return base.VisitUnary(node);
            }
            finally
            {
                PopTree();
            }
        }
        protected override Expression VisitBinary(BinaryExpression node)
        {
            var path = PushTree(node, TreeType.PathType.Binary);
            path.FirstBinaryVisit = true;
            try
            {
                switch (node.NodeType)
                {
                    case ExpressionType.Equal when path.Searchable == true:
                        path.Assignement = true;
                        var result = base.VisitBinary(node);

                        var left = path.Children[0];
                        var right = path.Children[1];

                        var property = left.PropertyInfo;
                        var getter = right.Getter();
                        var value = getter.GetValue();

                        if (left.Target is not null && property is not null && value is not null)
                        {
                            property.SetValue(left.Target, value);
                        }
                        return result;

                    case ExpressionType.OrElse:
                        path.SetSearchable(false);
                        break;
                    case ExpressionType.AndAlso:
                        path.Assignement = true;
                        break;
                    case ExpressionType.ArrayIndex:
                        path.Type = TreeType.PathType.Index;
                        break;

                    default:
                        break;
                }
                return base.VisitBinary(node);
            }
            finally
            {
                path.Assignement = false;
                PopTree();
            }
        }
        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            var path = PushTree(node, TreeType.PathType.Lambda);
            try
            {
                path.Node = base.VisitLambda(node);
                path.LambdaExpression = path.Node as LambdaExpression;
                return path.Node;
            }
            finally
            {
                PopTree();
            }
        }
        protected override Expression VisitIndex(IndexExpression node)
        {
            var path = PushTree(node, TreeType.PathType.Index);
            try
            {
                return base.VisitIndex(node);
            }
            finally
            {
                PopTree();
            }
        }
        protected override Expression VisitNew(NewExpression node)
        {
            var path = PushTree(node, TreeType.PathType.New);
            try
            {
                path.ClosureType = node.Type;
                return base.VisitNew(node);
            }
            finally
            {
                PopTree();
            }
        }
    }
}