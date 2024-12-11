// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.ComponentModel.Design;

namespace Hiperspace.Meta
{
    public class Routes: IDisposable
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
    }

    public abstract class Route : IDisposable
    {
        protected bool disposedValue;

        public Type SourceType { get; set; }
        public Type TargeType { get; set; }
        public string[]? SourceProperties { get; set; }
        public string[]? TargetProperties { get; set; }

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
    }

    public class Route<TSource, TTarget> : Route
        where TSource : Element<TSource>, new()
        where TTarget : Element<TTarget>, new()
    {
        internal Func<TSource, RefSet<TTarget>?>? _many;
        internal Func<TSource, TTarget?>? _one;
        internal SetSpace<TSource> _sourceSet;

        public Route(SetSpace<TSource> sourceSet, Func<TSource, RefSet<TTarget>> routes, string[] sourceProperties, string[] targetProperties)
            : base(typeof(TTarget), typeof(TSource))
        {
            _many = routes;
            _sourceSet = sourceSet;
            SourceProperties = sourceProperties;
            TargetProperties = targetProperties;
        }
        public Route(SetSpace<TSource> sourceSet, Func<TSource, TTarget?> routes, string[] sourceProperties, string[] targetProperties)
            : base(typeof(TTarget), typeof(TSource))
        {
            _one = routes;
            _sourceSet = sourceSet;
            SourceProperties = sourceProperties;
            TargetProperties = targetProperties;
        }
        public Route(SetSpace<TSource> sourceSet, Func<TSource, RefSet<TTarget>> routes)
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
