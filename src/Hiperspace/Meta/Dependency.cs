// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace.Meta
{
    public class DependencyPath
    {
        public readonly object Sender;
        public readonly DependencyPath? From;
        public readonly object Source;
        public readonly DateTime When;

        public DependencyPath(object source)
        {
            Source = source;
            Sender = source;
            When = DateTime.UtcNow;
        }
        public DependencyPath(object sender, DependencyPath path)
        {
            Sender = sender;
            From = path;
            Source = path.Source;
            When = path.When;
        }
        public bool Contains(object sender)
        {
            if (Sender.Equals(sender)) return true;
            if (From is not null) return From.Contains(sender);
            return false;
        }
        public int Length
        {
            get
            {
                if (From is null) return 1;
                return From.Length;
            }
        }
        public IEnumerable<object> Path
        {
            get
            {
                yield return Sender;
                if (From is not null)
                    foreach (var o in From.Path)
                        yield return o;
            }
        }
    }
    public class Dependencies : IDisposable
    {
        /// <summary>
        /// terminate any cyclic dependency (caused by user extension)
        /// </summary>
        Dependency[]? _dependencies;
        internal static int _eventSubscriptions = 0;
        public Dependencies(Dependency[]? dependencies) 
        { 
            _dependencies = dependencies;
        }

        private class AggregateTrigger<TTarget> : IObserver<(TTarget target, DependencyPath sender)>, IDisposable
        {
            private IDisposable[] _source;
            private IObserver<(TTarget target, DependencyPath sender)> _sink;
            public AggregateTrigger(
                IEnumerable<IObservable<(TTarget target, DependencyPath sender)>> source, 
                IObserver<(TTarget target, DependencyPath sender)> subscriber)
            {
                _source =
                    source
                    .Select(d => d.Subscribe(this))
                    .ToArray();
                _sink = subscriber;
                Interlocked.Increment(ref _eventSubscriptions);
            }
            public void Dispose()
            {
                foreach (var d in _source)
                {
                    d.Dispose();
                }
                Interlocked.Decrement(ref _eventSubscriptions);
            }

            public void OnCompleted()
            {
                _sink.OnCompleted();
            }

            public void OnError(Exception error)
            {
                _sink.OnError(error);
            }

            public void OnNext((TTarget target, DependencyPath sender) value)
            {
                _sink.OnNext(value);
            }
        }

        public IDisposable Subscribe<TTarget>(IObserver<(TTarget target, DependencyPath sender)> observer)
        {
            if (_dependencies is not null)
            {
                var source =
                    _dependencies
                    .Where(d => d.TargeType == typeof(TTarget) && d is IObservable<(TTarget target, DependencyPath sender)>)
                    .Select(d => (IObservable<(TTarget target, DependencyPath sender)>)d);
                return new AggregateTrigger<TTarget>(source, observer);
            }
            else
            {
                return new AggregateTrigger<TTarget>(Array.Empty<IObservable<(TTarget target, DependencyPath sender)>>(), observer);
            }
        }

        public void Dispose()
        {
            if (_dependencies is not null)
                foreach (var d in _dependencies)
                    d.Dispose();
        }
    }

    public abstract class Dependency : IDisposable
    {
        protected bool disposedValue;

        public Type SourceType { get; set; }
        public Type TargeType { get; set; }

        public Dependency(Type targeType, Type sourceType)
        {
            SourceType = sourceType;
            TargeType = targeType;
        }

        protected abstract void Dispose(bool disposing);

        public abstract object? Value (object source);

        ~Dependency()
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
    }

    public class Dependency<TSource, TTarget> : Dependency, IObservable<(TTarget target, DependencyPath sender)>
        where TSource : Element<TSource>, new()
        where TTarget : Element<TTarget>, new()
    {
        internal Func<TSource, TTarget?> _dependency;
        internal SetSpace<TSource>? _sourceSet;
        public Dependency(SetSpace<TSource> sourceSet, Func<TSource, TTarget?> dependency)
            : base(typeof(TTarget), typeof(TSource))
        {
            _dependency = dependency;
            _sourceSet = sourceSet;
            if (sourceSet is not null)
            {
                sourceSet.OnDependency += OnDependency;
            }
        }
        
        private void OnDependency((TSource source, DependencyPath sender) value)
        {
            if (OnTrigger is not null || Dependencies._eventSubscriptions > 0)
            {
                if (value.source is not null)
                {
                    var target = _dependency(value.source);
                    if (target is not null && value.sender.Contains(target)) return;
                    if (target is not null)
                    {
                        OnTrigger?.Invoke((target, value.sender));
                        target?.SetSpace?.RaiseOnDependency((target, new DependencyPath(target, value.sender)));
                    }
                }
            }
        }

        public IDisposable Subscribe(IObserver<(TTarget target, DependencyPath sender)> observer)
        {
            return new TriggerSubscription(this, observer);
        }
        internal class TriggerSubscription : IDisposable, IObserver<(TTarget target, DependencyPath sender)>
        {
            internal IObserver<(TTarget target, DependencyPath sender)> _sink;
            internal Dependency<TSource, TTarget> _source;
            private WeakReference? _last;
            private DateTime _lastEvent;

            internal TriggerSubscription(Dependency<TSource, TTarget> source, IObserver<(TTarget target, DependencyPath sender)> sink)
            {
                _sink = sink;
                _source = source;

                _source.OnTrigger += OnNext;
                Interlocked.Increment(ref Dependencies._eventSubscriptions);
            }

            public void Dispose()
            {
                if (_sink is not null)
                    _source.OnTrigger -= OnNext;
                Interlocked.Decrement(ref Dependencies._eventSubscriptions);
                GC.SuppressFinalize(this);
            }
            ~TriggerSubscription()
            {
                Dispose();
            }

            public void OnCompleted()
            {
                _sink.OnCompleted();
            }

            public void OnError(Exception error)
            {
                _sink.OnError(error);
            }

            public void OnNext((TTarget target, DependencyPath sender) value)
            {
                if (!(value.sender == _last?.Target && value.sender.When == _lastEvent))
                {
                    _last = new WeakReference(value.sender.Source);
                    _lastEvent = value.sender.When;
                    _sink.OnNext(value);
                }
            }
        }

        public delegate void Trigger((TTarget target, DependencyPath sender) value);

        public event Trigger? OnTrigger;

        ~Dependency()
        {
            Dispose();
        }
        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing && _sourceSet is not null)
                {
                    _sourceSet.OnDependency -= OnDependency;
                }
                disposedValue = true;
            }
        }
        public TTarget? Value(TSource source)
        {
            return _dependency(source);
        }
        public override object? Value(object source)
        {
            if (source is TSource value)
                return Value(value);
            else
                return null;
        }
    }
}
