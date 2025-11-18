// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
#nullable enable
using Hiperspace;
using ProtoBuf;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Hiperspace
{
    #region VectorNode

    /* Summary: node in a graph view of data with a VectorSpace 
    */
    [ProtoContract]

    public class VectorNode : Element<VectorNode>
    {
        public KeyType _key;
        internal ValueType _value;

        public VectorNode()
        {

            _key = new KeyType();
            _value = new ValueType();



        }
        public VectorNode(KeyType key, ValueType value) : this()
        {
            _key = key;
            _value = value;
        }
        public VectorNode(KeyType key) : this()
        {
            _key = key;
            _value = new ValueType();
        }
        public VectorNode(VectorNode source, SubSpace? space = null) : this()
        {
            _key = source._key;
            _value = source._value;
            if (space is not null)
                Bind(space);
        }


        [ProtoMember(1)]
        public override String SKey
        {
            get
            {
#pragma warning disable CS8603 // Possible null reference return.
                return _key.SKey;
#pragma warning restore CS8603 // Possible null reference return.
            }
            set
            {
                if (SetSpace is not null && _key.SKey != value) throw new Hiperspace.ValueMutationException("SKey");
                _key.SKey = value;
            }
        }


        [ProtoMember(3)]
        public Hiperspace.Vector? Vector
        {
            get
            {
#pragma warning disable CS8603 // Possible null reference return.
                return _value.Vector;
#pragma warning restore CS8603 // Possible null reference return.
            }
            set
            {
                if (SetSpace is not null && _value.Vector != value) throw new Hiperspace.ValueMutationException($"Vector");
                _value.Vector = value;
            }
        }

        #region state

        [ProtoContract]
        public struct KeyType : IEquatable<KeyType>, IComparable<KeyType>
        {
            internal KeyType(VectorNode item)
            {

                SKey = item.SKey;
            }

            [ProtoMember(1)] public String? SKey;

            public bool IsGetable()
            {

                if (SKey == default) return false;
                return true;
            }
            public bool IsSargable()
            {

                if (SKey != default) return true;
                return false;
            }

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
                if (other is null) return false;
                if (other is KeyType) return Equals((KeyType)other);
                return false;
            }
            private int? _hashCode;
            public override int GetHashCode()
            {
                if (_hashCode.HasValue) return _hashCode.Value;
                HashCode hc = new HashCode();

                hc.Add(SKey);
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

                if (left.SKey?.Equals(right.SKey) != true) return false;
                return true;
            }
            public static bool operator !=(KeyType left, KeyType right)
            {
                return !(left == right);
            }
            public static bool operator <(KeyType left, KeyType right)
            {

                if (left.SKey is not null && left.SKey.CompareTo(right.SKey) < 0) return true;
                return false;
            }
            public static bool operator >(KeyType left, KeyType right)
            {

                if (left.SKey is not null && left.SKey.CompareTo(right.SKey) > 0) return true;
                return false;
            }
            #region view
            #endregion
        }
        public static explicit operator KeyType(VectorNode item) => item._key;

        [ProtoContract]
        public struct ValueType
        {
            internal ValueType(VectorNode item)
            {

                Vector = item.Vector;
            }

            [ProtoMember(3)] public Hiperspace.Vector? Vector;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Bind(SubSpace space)
            {

                if (Vector is not null) Vector?.Bind(space);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Unbind(SubSpace space)
            {

                if (Vector is not null) Vector?.Unbind(space);
            }
        }
        public static explicit operator ValueType(VectorNode item) => item._value;

        #endregion

        #region Extents




        #endregion
        #region views

        #endregion

        #region Entity
        public override Result<VectorNode> Bind(SubSpace subspace)
        {
            return Result.Skip(this);
        }
        public override void Unbind(SubSpace subSpace)
        {
        }

        public override int GetHashCode()
        {
            return _key.GetHashCode();
        }
        public override bool Equals(VectorNode? other)
        {
            if (other is null)
                return false;
            return (_key == other._key);
        }
        public override bool Equals(Object? other)
        {
            if (other is null) return false;
            if (other is VectorNode) return Equals((VectorNode)other);
            return false;
        }

        public override int CompareTo(VectorNode? other)
        {
            if (other is null)
                throw new ArgumentNullException(nameof(other));
            if (_key < other._key)
                return -1;
            else if (_key > other._key)
                return 1;
            else
                return 0;
        }


        #endregion
        #region  helpers
        internal KeyRef<VectorNode.KeyType, VectorNode> self { get => new KeyRef<VectorNode.KeyType, VectorNode>(_key, this); }

        public static implicit operator KeyRef<KeyType, VectorNode>([NotNull] VectorNode other)
        {
            return other.self;
        }
        public static implicit operator KeyRef<KeyType, VectorNode>?(VectorNode? other)
        {
            if (other is not null)
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