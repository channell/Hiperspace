// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Hiperspace
{
    #region VectorSpace

    /* Summary:  Aspect used to search for similar entities 
    */
    [ProtoContract]

    [VectorSpace(), Versioned()]
    public class VectorSpace : Element<VectorSpace>
    {
        public KeyType _key;
        internal ValueType _value;

        public VectorSpace()
        {

            _key = new KeyType();
            _value = new ValueType();
        }
        public VectorSpace(KeyType key, ValueType value) : this()
        {
            _key = key;
            _value = value;
        }
        public VectorSpace(KeyType key) : this()
        {
            _key = key;
            _value = new ValueType();
        }
        public VectorSpace(VectorSpace source, SubSpace? space = null) : this()
        {
            _key = source._key;
            _value = source._value;
            if (space != null)
                Bind(space);
        }


        [ProtoMember(1)]
        public Hiperspace.Vector? Vector
        {
            get
            {
#pragma warning disable CS8603 // Possible null reference return.
                return _key.Vector;
#pragma warning restore CS8603 // Possible null reference return.
            }
            set
            {
                if (SetSpace != null) throw new Hiperspace.MutationException($"Vector can not be changed once bound to a Space");
                _key.Vector = value;
            }
        }


        #region state

        [ProtoContract]
        public struct KeyType : IEquatable<KeyType>, IComparable<KeyType>
        {
            public KeyType(VectorSpace item)
            {
                Vector = item.Vector;
            }

            [ProtoMember(1)] public Hiperspace.Vector? Vector;

            public bool IsGetable()
            {
                return true;
            }
            public bool IsSargable()
            {
                return false;
            }

            public string SKey => Convert.ToBase64String(Hiperspace.Space.ValueBytes(this));
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Bind(SubSpace space)
            {
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Unbind(SubSpace space)
            {
            }
            public bool Equals(KeyType other)
            {
                if (this == other) return true;
                return false;
            }
            public override bool Equals(Object? other)
            {
                if (other == null) return false;
                if (other is KeyType) return Equals((KeyType)other);
                return false;
            }
            private int? _hashCode;
            public override int GetHashCode()
            {
                if (_hashCode.HasValue) return _hashCode.Value;
                HashCode hc = new HashCode();

                hc.Add(Vector);
                _hashCode = hc.ToHashCode();
                return _hashCode.Value;
            }

            public int CompareTo(KeyType other)
            {
                if (this < other) return -1;
                if (this > other) return 1;
                return 0;
            }
            public static bool operator ==(KeyType left, KeyType right)
            {
                if (left.Vector.Equals(right.Vector) != true) return false;
                return true;
            }
            public static bool operator !=(KeyType left, KeyType right)
            {
                return !(left == right);
            }
            public static bool operator <(KeyType left, KeyType right)
            {
                if (left.Vector < right.Vector) return true;
                return false;
            }
            public static bool operator >(KeyType left, KeyType right)
            {
                if (left.Vector > right.Vector) return true;
                return false;
            }
        }
        public static explicit operator KeyType(VectorSpace item) => item._key;

        [ProtoContract]
        public struct ValueType
        {
            public ValueType(VectorSpace item)
            {

            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Bind(SubSpace space)
            {

            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Unbind(SubSpace space)
            {

            }
        }
        public static explicit operator ValueType(VectorSpace item) => item._value;

        #endregion

        #region Extents




        #endregion
        #region views

        #endregion

        #region Entity
        public override Result<VectorSpace> Bind(SubSpace subSpace)
        {
            if (subSpace is SubSpace space)
            {
                if (SetSpace != space.VectorSpaces)
                {
                    if (space.VectorSpaces.TryGetValue(this, out VectorSpace? current) && current != this && current != null)
                        return Result.Skip(current);
                    SetSpace = space.VectorSpaces;
                    var result = SetSpace.Bind(this);
                    if (result.Ok && this == result.Value)
                    {
                        _key.Bind(space);
                        _value.Bind(space);
                    }
                    return result;
                }
            }
            return Result.Skip(this);
        }
        public override void Unbind(SubSpace subSpace)
        {
            if (subSpace is SubSpace space)
            {
                _key.Unbind(space);
                _value.Unbind(space);
            }
        }

        public override int GetHashCode()
        {
            return _key.GetHashCode();
        }
        public override bool Equals(VectorSpace? other)
        {
            if (ReferenceEquals(null, other))
                return false;
            return (_key == other._key);
        }
        public override bool Equals(Object? other)
        {
            if (other == null) return false;
            if (other is VectorSpace) return Equals((VectorSpace)other);
            return false;
        }

        public override int CompareTo(VectorSpace? other)
        {
            if (ReferenceEquals(null, other))
                throw new ArgumentNullException(nameof(other));
            if (_key < other._key)
                return -1;
            else if (_key > other._key)
                return 1;
            else
                return 0;
        }
        public override string SKey
        {
            get
            {
                return _key.SKey;
            }
            set
            {
            }
        }

        #endregion
        #region  helpers
        internal KeyRef<VectorSpace.KeyType, VectorSpace> self { get => new KeyRef<VectorSpace.KeyType, VectorSpace>(_key, this); }

        public static implicit operator KeyRef<KeyType, VectorSpace>([NotNull] VectorSpace other)
        {
            return other.self;
        }
        public static implicit operator KeyRef<KeyType, VectorSpace>?(VectorSpace? other)
        {
            if (!ReferenceEquals(null, other))
                return other.self;
            return null;
        }
        #endregion
        public override bool BindKey<TKey>(TKey key)
        {
            if (key is KeyType kt)
            {
                _key = kt;
                return true;
            }
            else
                return false;
        }
    }
    #endregion
}
