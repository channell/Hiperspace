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

    #region Route

    /* Summary: Route between nodes following one of the rules 
    */
    [ProtoContract]

    public partial struct Route
    {
        internal KeyType _key;
        internal ValueType _value;
        internal bool _bound = false;

        public Route()
        {

            _key = new KeyType();
            _value = new ValueType();



        }
        internal Route(KeyType key, ValueType value) : this()
        {
            _key = key;
            _value = value;
        }
        internal Route(KeyType key) : this()
        {
            _key = key;
        }
        public Route(Route source) : this()
        {
            _key = source._key;
            _value = source._value;
        }


        [ProtoMember(1)]
        public String? Name
        {
            get
            {
                return _key.Name;
            }
            set
            {
                if (_bound && _key.Name != value) throw new Hiperspace.ValueMutationException($"Name");
                _key.Name = value;
            }
        }


        [ProtoMember(2)]
        public HashSet<Graph.Rule>? Rules
        {
            get
            {
                return _value.Rules;
            }
            set
            {
                if (_bound && _value.Rules != value) throw new Hiperspace.ValueMutationException($"Rules");
                _value.Rules = value;
            }
        }

        #region state

        [ProtoContract]
        public struct KeyType : IEquatable<KeyType>, IComparable<KeyType>
        {
            internal KeyType(Route item)
            {

                Name = item.Name;
            }

            [ProtoMember(1)] public String? Name;

            public bool IsGetable()
            {

                if (Name == default) return false;
                return true;
            }
            public bool IsSargable()
            {

                if (Name != default) return true;
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
                if (other == null) return false;
                if (other is KeyType) return Equals((KeyType)other);
                return false;
            }
            private int? _hashCode;
            public override int GetHashCode()
            {
                if (_hashCode.HasValue) return _hashCode.Value;
                HashCode hc = new HashCode();

                hc.Add(Name);
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

                if (left.Name?.Equals(right.Name) != true) return false;
                return true;
            }
            public static bool operator !=(KeyType left, KeyType right)
            {
                return !(left == right);
            }
            public static bool operator <(KeyType left, KeyType right)
            {

                if (left.Name != null && left.Name.CompareTo(right.Name) < 0) return true;
                return false;
            }
            public static bool operator >(KeyType left, KeyType right)
            {

                if (left.Name != null && left.Name.CompareTo(right.Name) > 0) return true;
                return false;
            }
        }
        public static explicit operator KeyType(Route item) => item._key;

        [ProtoContract]
        public struct ValueType
        {
            internal ValueType(Route item)
            {

                Rules = item.Rules;
            }

            [ProtoMember(2)] public HashSet<Graph.Rule>? Rules;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Bind(SubSpace space)
            {

                if (Rules != null) foreach (var p1 in Rules) p1.Bind(space);

            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Unbind(SubSpace space)
            {

                if (Rules != null) foreach (var p1 in Rules) p1.Unbind(space);
            }
            public bool Equals(ValueType other)
            {
                if (this == other) return true;
                return false;
            }
            public override bool Equals(Object? other)
            {
                if (other == null) return false;
                if (other is ValueType) return Equals((ValueType)other);
                return false;
            }
            public override int GetHashCode()
            {
                HashCode hc = new HashCode();

                hc.Add(Rules);
                return hc.ToHashCode();
            }

            public static bool operator ==(ValueType left, ValueType right)
            {

                if (left.Rules?.Equals(right.Rules) != true) return false;
                return true;
            }
            public static bool operator !=(ValueType left, ValueType right)
            {
                return !(left == right);
            }
        }
        public static explicit operator ValueType(Route item) => item._value;

        #endregion

        #region Extents




        private Graph.RouteMap? _Map;

        [Once()]
        public Graph.RouteMap? Map
        {
            get
            {
                if (_Map == null)
                    _Map = Graph.PathFunctions.CompileRoute(this);
                return _Map;
            }
        }
        #endregion

        #region Entity
        public Result<Route> Bind(SubSpace subSpace)
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
        public bool Equals(Route? other)
        {
            if (other == null)
                return false;
            return (_key == other.Value._key && _value == other.Value._value);
        }
        public override bool Equals(Object? other)
        {
            if (other == null) return false;
            if (other is Route) return Equals((Route)other);
            return false;
        }
        public int CompareTo(Route? other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));
            if (_key < other.Value._key)
                return -1;
            else if (_key > other.Value._key)
                return 1;
            else
                return 0;
        }
        public static bool operator ==(Route left, Route right)
        {
            if (left._key.Equals(right._key) != true) return false;
            return true;
        }
        public static bool operator !=(Route left, Route right)
        {
            return !(left == right);
        }
        public static bool operator <(Route left, Route right)
        {
            if (left._key < right._key) return false;
            return false;
        }
        public static bool operator >(Route left, Route right)
        {
            if (left._key > right._key) return false;
            return false;
        }
        #endregion
    }
    #endregion
}
