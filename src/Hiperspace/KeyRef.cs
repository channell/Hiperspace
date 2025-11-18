// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf;

namespace Hiperspace
{
    /// <summary>
    /// Provided a key reference from one entity to another with lazy loading
    /// </summary>
    [ProtoContract]
    public struct KeyRef<TKey, TEntity> : IEquatable<KeyRef<TKey, TEntity>>, IComparable<KeyRef<TKey, TEntity>>, IComparable
        where TKey : struct, IEquatable<TKey>, IComparable<TKey>
        where TEntity : Element<TEntity>, new()
    {
        private TKey _key;
        private TEntity? _entity;

        public KeyRef(TKey key)
        {
            _key = key;
        }
        public KeyRef(TKey key, TEntity entity)
        {
            _key = key;
            _entity = entity;
            SetSpace = entity.SetSpace;
        }

        [ProtoMember(2)]
        public TKey Key 
        { 
            get => _key; 
            init => _key = value;
        }

        public TEntity? Value
        {
            get
            {
                if (_entity is null)
                {
                    if (SetSpace is not null)
                    {
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
            init
            {
                _entity = value;
            }
        }
        public async Task<TEntity?> ValueAsync()
        {
            if (_entity is null)
            {
                if (SetSpace is not null)
                {
                    _entity = await SetSpace.GetAsync<TKey>(_key);
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

        public SetSpace<TEntity>? SetSpace { get; set; }

        public void Bind(SetSpace<TEntity> entities)
        {
            SetSpace = entities;
        }
        public void Unbind(SetSpace<TEntity> subSpace)
        {
            if (SetSpace == subSpace)
            {
                SetSpace = null;
            }
        }
        public void Refresh() => _entity = null;

        public bool Equals(KeyRef<TKey, TEntity> other)
        {
            if (this == other) return true;
            return false;
        }
        public override bool Equals(Object? other)
        {
            if (other is null) return false;
            if (other is KeyRef<TKey, TEntity>) return Equals((KeyRef<TKey, TEntity>)other);
            return false;
        }
        public override int GetHashCode()
        {
            return _key.GetHashCode();
        }

        public int CompareTo(KeyRef<TKey, TEntity> other)
        {
            if (this < other) return -1;
            if (this > other) return 1;
            return 0;
        }

        public int CompareTo(object? obj)
        {
            if (obj is null) throw new ArgumentNullException();
            if (obj is KeyRef<TKey, TEntity> kr)
                return CompareTo(kr);
            throw new ArgumentException();
        }

        public static bool operator ==(KeyRef<TKey, TEntity> left, KeyRef<TKey, TEntity> right)
        {
            if (left._key.Equals(right._key)) return true;
            return false;
        }
        public static bool operator !=(KeyRef<TKey, TEntity> left, KeyRef<TKey, TEntity> right)
        {
            if (!left._key.Equals(right._key)) return true;
            return false;
        }
        public static bool operator <(KeyRef<TKey, TEntity> left, KeyRef<TKey, TEntity> right)
        {
            if (left._key.CompareTo(right._key) < 0) return true;
            return false;
        }
        public static bool operator >(KeyRef<TKey, TEntity> left, KeyRef<TKey, TEntity> right)
        {
            if (left._key.CompareTo(right._key) > 0) return true;
            return false;
        }
        /// <summary>
        /// Helper property for F# to convert to a nullable reference
        /// </summary>
        public KeyRef<TKey, TEntity>? Nullable => this;
    }
}
