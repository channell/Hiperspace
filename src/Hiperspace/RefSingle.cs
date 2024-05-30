// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf;
using System.Collections;
using System.Diagnostics;

namespace Hiperspace
{
    /// <summary>
    /// A single value from the hiperspace, typically an aspect
    /// </summary>
    /// <typeparam name="TKey">key type for the entity</typeparam>
    /// <typeparam name="TEntity">entity type</typeparam>
    public struct RefSingle<TKey, TEntity> : IEquatable<RefSingle<TKey, TEntity>>, IComparable<RefSingle<TKey, TEntity>>
        where TKey : struct
        where TEntity : Element<TEntity>, new()
    {
        public RefSingle()
        {
            _keyBuilder = () => new TKey();
            _binder = _ => { };
        }

        public RefSingle(Func<TKey> keyBuilder, Action<TEntity> binder)
        {
            _keyBuilder = keyBuilder;
            _binder = binder;
        }

        private TEntity? _entity;
        private TKey _key = default;

        public TEntity? Value
        { 
            get
            {
                if (_entity == null)
                {
                    if (SetSpace != null)
                    {
                        _key = _keyBuilder();
                        _entity = SetSpace.Get<TKey>(ref _key);
                    }
                    else  // enable Concrete Elements to expose TEntity rather that KeyRef<>
                    {
                        var entity = new TEntity();
                        if (entity.BindKey(_key))
                            _entity = entity;
                    }
                }
                return _entity;
            }
            // for deserialisation
            set
            {
                _entity = value;
                if (SetSpace != null && value != null) 
                {
                    _key = _keyBuilder();
                    _binder(value);
                    SetSpace.Bind(value);
                }
            }
        }

        private Func<TKey> _keyBuilder;
        private Action<TEntity> _binder;
        public SetSpace<TEntity>? SetSpace;

        public void Bind (Func<TKey> keyBuilder, Action<TEntity> binder)
        {
            _keyBuilder = keyBuilder;
            _binder = binder;
            if (_entity != null) 
            {
                _binder(_entity);
            }
        }
        public void Refresh() => _entity = null;

        public void Bind(SetSpace<TEntity> setspace)
        {
            SetSpace = setspace;
            if (_entity != null && _entity.SetSpace != setspace)
            {
                _binder(_entity);
                setspace.Bind(_entity);
            }
        }
        public void Unbind(SubSpace subSpace)
        {
            if (SetSpace?.Space == subSpace)
            {
                SetSpace = null;
            }
        }
        
        public bool Equals (RefSingle<TKey, TEntity> other) 
        {
            return Equals(_key, other._key);
        }

        public int CompareTo(RefSingle<TKey, TEntity> other)
        {
            return StructuralComparisons.StructuralComparer.Compare(_key, other._key);
        }
    }
}
