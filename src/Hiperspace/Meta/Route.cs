// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Collections;
using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace Hiperspace.Meta
{
    public class Routes: IDisposable, IEnumerable<Route>
    {
        /// <summary>
        /// terminate any cyclic dependency (caused by user extension)
        /// </summary>
        internal const int MAX_RECURSION = 100;
        Route[]? _routes;
        internal static int _eventSubscriptions = 0;
        public Routes(Route[]? routes)
        {
            _routes = routes;
        }

        public void Dispose()
        {
            if (_routes != null)
                foreach (var d in _routes)
                    d.Dispose();
        }

        public IEnumerator<Route> ForSource<T> ()
        {
            foreach (var i in _routes ?? [])
            {
                if ( i.SourceType == typeof(T))
                {
                    yield return i;
                }
            }
        }
        public IEnumerator<Route> ForHierarchy<T>()
        {
            foreach (var i in _routes ?? [])
            {
                if (i.SourceType == typeof(T) && 
                    i.TargeType == typeof(T) &&
                    i.SourceProperties != null &&
                    i.SourceProperties.Contains("CubeHierarchy") &&
                    i.TargetProperties != null &&
                    i.TargetProperties.Contains("CubeHierarchy") &&
                    i.Many)
                {
                    yield return i;
                }
            }
        }
        public bool IsHierarchy<T>()
        {
            foreach (var i in _routes ?? [])
            {
                if (i.SourceType == typeof(T) &&
                    i.TargeType == typeof(T) &&
                    i.SourceProperties != null &&
                    i.SourceProperties.Contains("CubeHierarchy") &&
                    i.TargetProperties != null &&
                    i.TargetProperties.Contains("CubeHierarchy") &&
                    i.Many)
                {
                    return true;
                }
            }
            return false;
        }

        public Route? HierarchyParent<T>()
        {
            foreach (var i in _routes ?? [])
            {
                if (i.SourceType == typeof(T) &&
                    i.TargeType == typeof(T) &&
                    i.SourceProperties != null &&
                    i.SourceProperties.Contains("CubeHierarchy") &&
                    i.TargetProperties != null &&
                    i.TargetProperties.Contains("CubeHierarchy") &&
                    i.One)
                {
                    return i;
                }
            }
            return null;
        }


        public IEnumerator<Route> GetEnumerator()
        {
            foreach (var i in _routes ?? [])
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public abstract class Route : IDisposable
    {
        protected bool disposedValue;

        public Type SourceType { get; init; }
        public Type TargeType { get; init; }
        public string[]? SourceProperties { get; init; }
        public string[]? TargetProperties { get; init; }

        public string? FieldName { get; init; }

        public Route(Type targeType, Type sourceType)
        {
            SourceType = sourceType;
            TargeType = targeType;
        }
        protected abstract void Dispose(bool disposing);

        ~Route()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public abstract bool One { get; }
        public abstract bool Many { get; }

        public abstract object? OneValue(object source);
        public abstract IEnumerable<object>? ManyValue (object source);
        public abstract IEnumerable DeltaObject(DateTime deltaFrom);

        public static Route<TSource, TTarget> Combine<TSource, TTransitive, TTarget>(Route<TSource, TTransitive> source, Route<TTransitive, TTarget> dest)
            where TSource : Element<TSource>, new()
            where TTarget : Element<TTarget>, new()
            where TTransitive : Element<TTransitive>, new()
        {
            if (dest._one != null && source._one != null)
            {
                /*        internal Func<TSource, IEnumerable<TTarget>?>? _many;
                        internal Func<TSource, TTarget?>? _one;
                */
                Func<TTransitive, TTarget?> destFunc = dest._one;
                Func<TSource, TTransitive?> sourceFunc = source._one;
                Func<TSource, TTarget?> transitativeFunc = s => destFunc(sourceFunc(s)!);
                return new Route<TSource, TTarget>(source._sourceSet, transitativeFunc, source.SourceProperties!, dest.TargetProperties!, dest.FieldName);
            }
            else if (dest._many != null && source._one != null)
            {
                Func<TTransitive, IEnumerable<TTarget>?> destFunc = dest._many;
                Func<TSource, TTransitive?> sourceFunc = source._one;
                Func<TSource, IEnumerable<TTarget>?> transitativeFunc = s => destFunc(sourceFunc(s)!);
                return new Route<TSource, TTarget>(source._sourceSet, transitativeFunc!, source.SourceProperties!, dest.TargetProperties!, dest.FieldName);
            }
            else if (dest._many != null && source._many != null)
            {
                Func<TTransitive, IEnumerable<TTarget>?> destFunc = dest._many;
                Func<TSource, IEnumerable<TTransitive>?> sourceFunc = source._many;
                Func<TSource, IEnumerable<TTarget>> transitativeFunc = s =>
                {
                    List<TTarget> targets = new List<TTarget>();
                    foreach (var transitive in source._many(s) ?? Enumerable.Empty<TTransitive>())
                    {
                        foreach (var target in dest._many(transitive) ?? Enumerable.Empty<TTarget>())
                        {
                            targets.Add(target);
                        }
                    }
                    return targets;
                };
                return new Route<TSource, TTarget>(source._sourceSet, transitativeFunc, source.SourceProperties!, dest.TargetProperties!, dest.FieldName);
            }
            else
                throw new NotImplementedException($"Cannot combine routes from {nameof(TSource)} through {nameof(TTransitive)} to {nameof(TTarget)}");
        }
        public static Route CombineRoute(Route source, Route dest)
        {
            if ( source.TargeType == dest.SourceType)
            {
                var method = typeof(Route).GetMethod(nameof(Combine))?.MakeGenericMethod(new[] { source.SourceType, source.TargeType, dest.TargeType });
                if (method != null)
                {
                    var result = method.Invoke(null, new[] { source, dest }) as Route;
                    if (result != null) return result;
                }
            }
            throw new NotImplementedException($"Cannot combine routes from {source.SourceType.Name} through {source.TargeType.Name} to {dest.TargeType.Name}");
        }
    }

    public class Route<TSource, TTarget> : Route
        where TSource : Element<TSource>, new()
        where TTarget : Element<TTarget>, new()
    {
        internal Func<TSource, IEnumerable<TTarget>?>? _many;
        internal Func<TSource, TTarget?>? _one;
        internal SetSpace<TSource> _sourceSet;

        public Route(SetSpace<TSource> sourceSet, Func<TSource, IEnumerable<TTarget>> routes, string[] sourceProperties, string[] targetProperties, string? fieldName = null)
            : base(typeof(TTarget), typeof(TSource))
        {
            _many = routes;
            _sourceSet = sourceSet;
            SourceProperties = sourceProperties;
            TargetProperties = targetProperties;
            FieldName = fieldName;
        }
        public Route(SetSpace<TSource> sourceSet, Func<TSource, TTarget?> routes, string[] sourceProperties, string[] targetProperties, string? fieldName = null)
            : base(typeof(TTarget), typeof(TSource))
        {
            _one = routes;
            _sourceSet = sourceSet;
            SourceProperties = sourceProperties;
            TargetProperties = targetProperties;
            FieldName = fieldName;
        }
        public Route(SetSpace<TSource> sourceSet, Func<TSource, IEnumerable<TTarget>> routes)
            : base(typeof(TTarget), typeof(TSource))
        {
            _many = routes;
            _sourceSet = sourceSet;
            SourceProperties = Array.Empty<string>();
            TargetProperties = Array.Empty<string>();
        }
        public Route(SetSpace<TSource> sourceSet, Func<TSource, TTarget?> routes)
            : base(typeof(TTarget), typeof(TSource))
        {
            _one = routes;
            _sourceSet = sourceSet;
            SourceProperties = Array.Empty<string>();
            TargetProperties = Array.Empty<string>();
        }

        ~Route()
        {
            Dispose();
        }

        public override bool One => _one != null;

        public override bool Many => _many != null;

        public static bool IsElementVersionType()
        {
            var tSource = typeof(TSource);
            var elementVersionType = typeof(ElementVersion<>).MakeGenericType(tSource);
            return elementVersionType.IsAssignableFrom(tSource);
        }

        public IEnumerable<TTarget> Delta(DateTime deltaFrom)
        {
            if (_sourceSet is IDeltaIndex<TSource> versionedSet)
            {
                if (_one != null)
                {
                    foreach (var source in versionedSet.Delta(new TSource(), deltaFrom))
                    {
                        var result = _one(source);
                        if (result != null)
                            yield return result;
                    }
                }
                else if (_many != null)
                {
                    foreach (var source in versionedSet.Delta(new TSource(), deltaFrom))
                    {
                        var targets = _many(source);
                        if (targets != null)
                        {
                            foreach (var target in targets)
                            {
                                yield return target;
                            }
                        }
                    }
                }
                else
                    yield break;
            }
            else
                yield break;
        }
        public override IEnumerable DeltaObject(DateTime deltaFrom)
        {
            return Delta(deltaFrom).Cast<object>();
        }

        public TTarget? OneValue (TSource source)
        {
            if (_one != null)
                return _one(source);
            else
                return default;

        }
        public IEnumerable<TTarget>? ManyValue (TSource source)
        {
            if (_many != null)
                return _many(source);
            else
                return default;
        }
        public override object? OneValue (object source)
        {
            if (source is TSource value)
                return OneValue(value);
            else
                return default;
        }
        public override IEnumerable<object>? ManyValue (object source)
        {
            if (source is TSource value)
                return ManyValue(value);
            else
                return default;
        }

        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                disposedValue = true;
            }
        }
    }
}
