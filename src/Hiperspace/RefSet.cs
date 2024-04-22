// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Collections;

namespace Hiperspace
{
    public class RefSet<TEntity> : ISet<TEntity>, ICollection<TEntity>
        where TEntity : Element<TEntity>, new()
    {
        protected HashSet<TEntity> _cached;
        /// <summary>
        /// For deserialisation
        /// </summary>
        public RefSet()
        {
            _template = () => new TEntity();
            _binder = e => { };
            _cached = new HashSet<TEntity>();
            _filter = e => true;
        }
        public RefSet(Func<TEntity> template, Action<TEntity> binder)
        {
            _template = template;
            _binder = binder;
            _cached = new HashSet<TEntity>();
            _filter = e => true;
        }
        public void PreBind(Func<TEntity> template, Action<TEntity> binder)
        {
            _template = template;
            _binder = binder;
            _cached = new HashSet<TEntity>();
            _filter = e => true;
        }
        /// <summary>
        /// Construct a reference, including a a filter for scenario where the index to the set overlaps with 
        /// the key
        /// </summary>
        /// <param name="template">for search in Hiperspace</param>
        /// <param name="binder">for items added to the collection</param>
        /// <param name="filter">for filtering results from Hiperspace</param>
        public RefSet(Func<TEntity> template, Action<TEntity> binder, Func<TEntity,bool> filter)
        {
            _template = template;
            _binder = binder;
            _cached = new HashSet<TEntity>();
            _filter = filter;
        }
        public void PreBind(Func<TEntity> template, Action<TEntity> binder, Func<TEntity, bool> filter)
        {
            _template = template;
            _binder = binder;
            _cached = new HashSet<TEntity>();
            _filter = filter;
        }

        private ISet<TEntity> Lazy()
        {
            if (_new && SetSpace != null)
            {
                _new = false;
                bool taken = false;
                _lock.Enter(ref taken);
                if (taken)
                {
                    TEntity[] result = SetSpace.Find(_template(),true).ToArray();
                    if (result != Array.Empty<TEntity>())
                    {
                        _cached.UnionWith(result.Where(_filter));
                    }
                    _lock.Exit();
                }
                else
                    throw new LockRecursionException();
            }
            return _cached;
        }

        private SpinLock _lock = new SpinLock();
        private volatile bool _new = true;
        private Func<TEntity> _template;
        private Action<TEntity> _binder;
        private Func<TEntity, bool> _filter;
        public SetSpace<TEntity>? SetSpace;


        public void Bind(SetSpace<TEntity> setspace)
        {
            SetSpace = setspace;
            foreach (var en in _cached) 
            {
                _binder(en);
                SetSpace.Bind(en);
            }
        }
        public void Unbind(SubSpace subSpace)
        {
            if (SetSpace?.Space == subSpace)
            {
                foreach (var en in _cached)
                {
                    en.Unbind(SetSpace.Space);
                }
                SetSpace = null;
            }
        }
        public int Count => Lazy().Count();

        public void Add (TEntity item)
        {
            _new = false;
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                if (SetSpace != null)
                {
                    _binder(item);
                    SetSpace.Bind(item);
                    _cached.Add(item);
                }
                else
                   _cached.Add(item);
                _lock.Exit();
            }
            else
                throw new LockRecursionException();
        }

        public bool IsReadOnly => Lazy().IsReadOnly;

        public bool Contains(TEntity item) =>Lazy().Contains(item);

        public void CopyTo(TEntity[] array, int arrayIndex) => Lazy().CopyTo(array, arrayIndex);

        public IEnumerator<TEntity> GetEnumerator() => Lazy().GetEnumerator();

        public bool Remove(TEntity item) => throw new NotImplementedException();

        public IEnumerable<TEntity> Cached => _cached;

        /// <summary>
        /// Cause next action to re-fetch from Hiperspace
        /// </summary>
        public void Refresh() => _new = true;

        bool ISet<TEntity>.Add(TEntity item)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                var added = _cached.Add(item);
                _lock.Exit();
                return added;
            }
            else
                throw new LockRecursionException();
        }

        public void ExceptWith(IEnumerable<TEntity> other)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                _cached.ExceptWith(other);
                _lock.Exit();
            }
            else
                throw new LockRecursionException();
        }

        public void IntersectWith(IEnumerable<TEntity> other)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                _cached.IntersectWith(other);
                _lock.Exit();
            }
            else
                throw new LockRecursionException();
        }

        public bool IsProperSubsetOf(IEnumerable<TEntity> other)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                var returner = _cached.IsProperSubsetOf(other);
                _lock.Exit();
                return returner;
            }
            else
                throw new LockRecursionException();
        }

        public bool IsProperSupersetOf(IEnumerable<TEntity> other)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                var returner = _cached.IsProperSupersetOf(other);
                _lock.Exit();
                return returner;
            }
            else
                throw new LockRecursionException();
        }

        public bool IsSubsetOf(IEnumerable<TEntity> other)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                var returner = _cached.IsSubsetOf(other);
                _lock.Exit();
                return returner;
            }
            else
                throw new LockRecursionException();
        }

        public bool IsSupersetOf(IEnumerable<TEntity> other)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                var returner = _cached.IsSupersetOf(other);
                _lock.Exit();
                return returner;
            }
            else
                throw new LockRecursionException();
        }

        public bool Overlaps(IEnumerable<TEntity> other)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                var returner = _cached.Overlaps(other);
                _lock.Exit();
                return returner;
            }
            else
                throw new LockRecursionException();
        }

        public bool SetEquals(IEnumerable<TEntity> other)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                var returner = _cached.SetEquals(other);
                _lock.Exit();
                return returner;
            }
            else
                throw new LockRecursionException();
        }

        public void SymmetricExceptWith(IEnumerable<TEntity> other)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                _cached.SymmetricExceptWith(other);
                _lock.Exit();
            }
            else
                throw new LockRecursionException();
        }

        public void UnionWith(IEnumerable<TEntity> other)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                _cached.UnionWith(other);
                _lock.Exit();
            }
            else
                throw new LockRecursionException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_cached).GetEnumerator();
        }
    }
}
