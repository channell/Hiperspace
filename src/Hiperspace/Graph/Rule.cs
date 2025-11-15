// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
#nullable enable
using Hiperspace;
using ProtoBuf;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Graph
{

    #region Rule

    /* Summary: Rule for the edges that are included in in the route 
    */
    [ProtoContract]

    public partial struct Rule
    {
        internal KeyType _key;
        internal ValueType _value;
        internal bool _bound = false;

        public Rule()
        {

            _key = new KeyType();
            _value = new ValueType();



        }
        internal Rule(KeyType key, ValueType value) : this()
        {
            _key = key;
            _value = value;
        }
        internal Rule(KeyType key) : this()
        {
            _key = key;
        }
        public Rule(Rule source) : this()
        {
            _key = source._key;
            _value = source._value;
        }


        /* Summary: Some(name of the From Node TypeName or * for all) 
        */
        [ProtoMember(1)]
        public String? FromType
        {
            get
            {
                return _key.FromType;
            }
            set
            {
                if (_bound && _key.FromType != value) throw new Hiperspace.ValueMutationException($"FromType");
                _key.FromType = value;
            }
        }

        /* Summary: Some(name of the To Node TypeName or * for all) 
        */
        [ProtoMember(2)]
        public String? ToType
        {
            get
            {
                return _key.ToType;
            }
            set
            {
                if (_bound && _key.ToType != value) throw new Hiperspace.ValueMutationException($"ToType");
                _key.ToType = value;
            }
        }

        /* Summary: Some(name of the To Node TypeName or * for all) 
        */
        [ProtoMember(3)]
        public String? EdgeType
        {
            get
            {
                return _key.EdgeType;
            }
            set
            {
                if (_bound && _key.EdgeType != value) throw new Hiperspace.ValueMutationException($"EdgeType");
                _key.EdgeType = value;
            }
        }


        #region state

        [ProtoContract]
        public struct KeyType : IEquatable<KeyType>, IComparable<KeyType>
        {
            internal KeyType(Rule item)
            {

                FromType = item.FromType;
                ToType = item.ToType;
                EdgeType = item.EdgeType;
            }

            [ProtoMember(1)] public String? FromType;
            [ProtoMember(2)] public String? ToType;
            [ProtoMember(3)] public String? EdgeType;

            public bool IsGetable()
            {

                if (FromType == default) return false;
                if (ToType == default) return false;
                if (EdgeType == default) return false;
                return true;
            }
            public bool IsSargable()
            {

                if (FromType != default) return true;
                return false;
            }
            public string SKey => ""; // Values can't have string keys
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

                hc.Add(FromType);
                hc.Add(ToType);
                hc.Add(EdgeType);
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

                if (left.FromType?.Equals(right.FromType) != true) return false;
                if (left.ToType?.Equals(right.ToType) != true) return false;
                if (left.EdgeType?.Equals(right.EdgeType) != true) return false;
                return true;
            }
            public static bool operator !=(KeyType left, KeyType right)
            {
                return !(left == right);
            }
            public static bool operator <(KeyType left, KeyType right)
            {

                if (left.FromType is not null && left.FromType.CompareTo(right.FromType) < 0) return true;
                if (left.ToType is not null && left.ToType.CompareTo(right.ToType) < 0) return true;
                if (left.EdgeType is not null && left.EdgeType.CompareTo(right.EdgeType) < 0) return true;
                return false;
            }
            public static bool operator >(KeyType left, KeyType right)
            {

                if (left.FromType is not null && left.FromType.CompareTo(right.FromType) > 0) return true;
                if (left.ToType is not null && left.ToType.CompareTo(right.ToType) > 0) return true;
                if (left.EdgeType is not null && left.EdgeType.CompareTo(right.EdgeType) > 0) return true;
                return false;
            }
        }
        public static explicit operator KeyType(Rule item) => item._key;

        [ProtoContract]
        public struct ValueType
        {
            internal ValueType(Rule item)
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
            public bool Equals(ValueType other)
            {
                if (this == other) return true;
                return false;
            }
            public override bool Equals(Object? other)
            {
                if (other is null) return false;
                if (other is ValueType) return Equals((ValueType)other);
                return false;
            }
            public override int GetHashCode()
            {
                HashCode hc = new HashCode();

                return hc.ToHashCode();
            }

            public static bool operator ==(ValueType left, ValueType right)
            {

                return true;
            }
            public static bool operator !=(ValueType left, ValueType right)
            {
                return !(left == right);
            }
        }
        public static explicit operator ValueType(Rule item) => item._value;

        #endregion

        #region Extents




        #endregion

        #region Entity
        public Result<Rule> Bind(SubSpace subSpace)
        {
            if (subSpace is SubSpace space)
            {
                _key.Bind(space);
                _value.Bind(space);
                _bound = true;



            }
            return Result.Skip(this);
        }
        public void Unbind(SubSpace subSpace)
        {
            if (subSpace is SubSpace space)
            {
                _key.Unbind(space);
                _value.Unbind(space);
                _bound = false;



            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_key.GetHashCode(), _value.GetHashCode());
        }
        public bool Equals(Rule? other)
        {
            if (other is null)
                return false;
            return (_key == other.Value._key && _value == other.Value._value);
        }
        public override bool Equals(Object? other)
        {
            if (other is null) return false;
            if (other is Rule) return Equals((Rule)other);
            return false;
        }
        public int CompareTo(Rule? other)
        {
            if (other is null)
                throw new ArgumentNullException(nameof(other));
            if (_key < other.Value._key)
                return -1;
            else if (_key > other.Value._key)
                return 1;
            else
                return 0;
        }
        public static bool operator ==(Rule left, Rule right)
        {
            if (left._key.Equals(right._key) != true) return false;
            return true;
        }
        public static bool operator !=(Rule left, Rule right)
        {
            return !(left == right);
        }
        public static bool operator <(Rule left, Rule right)
        {
            if (left._key < right._key) return false;
            return false;
        }
        public static bool operator >(Rule left, Rule right)
        {
            if (left._key > right._key) return false;
            return false;
        }
        #endregion
    }
    #endregion
}
