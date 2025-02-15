// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Collections;

namespace Hiperspace
{
    public class RefSet<TEntity> : ISet<TEntity>, ICollection<TEntity>, ICollection
        where TEntity : Element<TEntity>, new()
    {
        public readonly HashSet<TEntity> Cached = new HashSet<TEntity>();
        /// <summary>
        /// For deserialisation
        /// </summary>
        public RefSet()
        {
            _template = () => new TEntity();
            _binder = e => { };
            _filter = e => true;
        }
        public RefSet(Func<TEntity> template, Action<TEntity> binder)
        {
            _template = template;
            _binder = binder;
            _filter = e => true;
        }
        public void PreBind(Func<TEntity> template, Action<TEntity> binder)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                try
                {
                    _template = template;
                    _binder = binder;
                    _filter = e => true;
                }
                finally
                {
                    _lock.Exit();
                }
            }
            else
                throw new LockRecursionException();
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
            _filter = filter;
        }
        public void PreBind(Func<TEntity> template, Action<TEntity> binder, Func<TEntity, bool> filter)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                try
                {
                    _template = template;
                    _binder = binder;
                    _filter = filter;
                }
                finally
                {
                    _lock.Exit();
                }
            }
            else
                throw new LockRecursionException();
        }

        private ISet<TEntity> Lazy()
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                try
                {
                    if (_new && SetSpace != null)
                    {
                        _new = false;
                        TEntity[] result = SetSpace.Find(_template(), true).ToArray();
                        if (result != Array.Empty<TEntity>())
                        {
                            Cached.UnionWith(result.Where(_filter));
                        }
                    }
                }
                finally
                {
                    _lock.Exit();
                }
            }
            else
                throw new LockRecursionException();
            return Cached;
        }

        private SpinLock _lock = new SpinLock(true);
        private volatile bool _new = true;
        private Func<TEntity> _template;
        private Action<TEntity> _binder;
        private Func<TEntity, bool> _filter;
        public SetSpace<TEntity>? SetSpace;


        public void Bind(SetSpace<TEntity> setspace)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                try
                {
                    SetSpace = setspace;
                    foreach (var en in Cached)
                    {
                        _binder(en);
                        SetSpace.Bind(en);
                    }
                }
                finally
                {
                    _lock.Exit();
                }
            }
            else
                throw new LockRecursionException();
        }
        public void Unbind(SubSpace subSpace)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                try
                {
                    if (SetSpace?.Space == subSpace)
                    {
                        foreach (var en in Cached)
                        {
                            en.Unbind(SetSpace.Space);
                        }
                        SetSpace = null;
                    }
                }
                finally
                {
                    _lock.Exit();
                }
            }
            else throw new LockRecursionException();
        }
        public int Count => Lazy().Count();

        public void Add (TEntity item)
        {
            bool taken = false;
            _lock.Enter(ref taken);
            if (taken)
            {
                try
                {
                    _new = false;
                    if (SetSpace != null)
                    {
                        _binder(item);
                        SetSpace.Bind(item);
                        if (!Cached.Add(item))
                        {
                            Cached.Remove(item);
                            Cached.Add(item);
                        }
                    }
                    else
                    {
                        _binder(item);
                        if (!Cached.Add(item))
                        {
                            Cached.Remove(item);
                            Cached.Add(item);
                        }
                    }
                }
                finally
                {
                    _lock.Exit();
                }
            }
            else
                throw new LockRecursionException();
        }

        public bool IsReadOnly => Lazy().IsReadOnly;

        public bool Contains(TEntity item) =>Lazy().Contains(item);

        public void CopyTo(TEntity[] array, int arrayIndex) => Lazy().CopyTo(array, arrayIndex);

        public IEnumerator<TEntity> GetEnumerator() => Lazy().GetEnumerator();

        public bool Remove(TEntity item) => Cached.Remove(item);

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
                bool added;
                try
                {
                    added = Cached.Add(item);
                    if (!added)
                    {
                        Cached.Remove(item);
                        added = Cached.Add(item);
                    }
                }
                finally
                {
                    _lock.Exit();
                }
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
                try
                {
                    Cached.ExceptWith(other);
                }
                finally
                {
                    _lock.Exit();
                }
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
                try
                {
                    Cached.IntersectWith(other);
                }
                finally
                {
                    _lock.Exit();
                }
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
                bool returner;
                try
                {
                    returner = Cached.IsProperSubsetOf(other);
                }
                finally
                {
                    _lock.Exit();
                }
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
                bool returner;
                try
                {
                    returner = Cached.IsProperSupersetOf(other);
                }
                finally
                {
                    _lock.Exit();
                }
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
                bool returner;
                try
                {
                    returner = Cached.IsSubsetOf(other);
                }
                finally
                {
                    _lock.Exit();
                }
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
                bool returner;
                try
                {
                    returner = Cached.IsSupersetOf(other);
                }
                finally
                {
                    _lock.Exit();
                }
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
                bool returner;
                try
                {
                    returner = Cached.Overlaps(other);
                }
                finally
                {
                    _lock.Exit();
                }
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
                bool returner;
                try
                {
                    returner = Cached.SetEquals(other);
                }
                finally
                {
                    _lock.Exit();
                }
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
                try
                {
                    Cached.SymmetricExceptWith(other);
                }
                finally
                {
                    _lock.Exit();
                }
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
                try
                {
                    Cached.UnionWith(other);
                }
                finally
                {
                    _lock.Exit();
                }
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
            return Lazy().GetEnumerator();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
        public bool IsSynchronized => true;

        public object SyncRoot => Cached;
    }
}
