// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Hiperspace;
using ProtoBuf;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Graph.Cube
{

    #region MeasureValue

    /* Summary: A Cube measure serialized with the node 
    */
    [ProtoContract]

    public partial struct MeasureValue
    {
        internal KeyType _key;
        internal ValueType _value;
        internal bool _bound = false;

        public MeasureValue()
        {

            _key = new KeyType();
            _value = new ValueType();



        }
        internal MeasureValue(KeyType key, ValueType value) : this()
        {
            _key = key;
            _value = value;
        }
        internal MeasureValue(KeyType key) : this()
        {
            _key = key;
        }
        public MeasureValue(MeasureValue source) : this()
        {
            _key = source._key;
            _value = source._value;
        }



        [ProtoMember(1)]
        public Int64? Integer
        {
            get
            {
                return _value.Integer;
            }
            set
            {
                if (_bound && _value.Integer != value) throw new Hiperspace.ValueMutationException($"Integer");
                _value.Integer = value;
            }
        }

        [ProtoMember(2)]
        public Double? Double
        {
            get
            {
                return _value.Double;
            }
            set
            {
                if (_bound && _value.Double != value) throw new Hiperspace.ValueMutationException($"Double");
                _value.Double = value;
            }
        }

        [ProtoMember(3)]
        public Decimal? Decimal
        {
            get
            {
                return _value.Decimal;
            }
            set
            {
                if (_bound && _value.Decimal != value) throw new Hiperspace.ValueMutationException($"Decimal");
                _value.Decimal = value;
            }
        }

        [ProtoMember(4)]
        public String? String
        {
            get
            {
                return _value.String;
            }
            set
            {
                if (_bound && _value.String != value) throw new Hiperspace.ValueMutationException($"String");
                _value.String = value;
            }
        }

        [ProtoMember(5)]
        public DateTime? DateTime
        {
            get
            {
                return _value.DateTime;
            }
            set
            {
                if (_bound && _value.DateTime != value) throw new Hiperspace.ValueMutationException($"DateTime");
                _value.DateTime = value;
            }
        }

        #region state

        [ProtoContract]
        public struct KeyType : IEquatable<KeyType>, IComparable<KeyType>
        {
            internal KeyType(MeasureValue item)
            {

            }


            public bool IsGetable()
            {

                return true;
            }
            public bool IsSargable()
            {

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

                return true;
            }
            public static bool operator !=(KeyType left, KeyType right)
            {
                return !(left == right);
            }
            public static bool operator <(KeyType left, KeyType right)
            {

                return false;
            }
            public static bool operator >(KeyType left, KeyType right)
            {

                return false;
            }
        }
        public static explicit operator KeyType(MeasureValue item) => item._key;

        [ProtoContract]
        public struct ValueType
        {
            internal ValueType(MeasureValue item)
            {

                Integer = item.Integer;
                Double = item.Double;
                Decimal = item.Decimal;
                String = item.String;
                DateTime = item.DateTime;
            }

            [ProtoMember(1)] public Int64? Integer;
            [ProtoMember(2)] public Double? Double;
            [ProtoMember(3)] public Decimal? Decimal;
            [ProtoMember(4)] public String? String;
            [ProtoMember(5)] public DateTime? DateTime;
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

                hc.Add(Integer);
                hc.Add(Double);
                hc.Add(Decimal);
                hc.Add(String);
                hc.Add(DateTime);
                return hc.ToHashCode();
            }

            public static bool operator ==(ValueType left, ValueType right)
            {

                if (left.Integer?.Equals(right.Integer) == false) return false;
                if (left.Double?.Equals(right.Double) == false) return false;
                if (left.Decimal?.Equals(right.Decimal) == false) return false;
                if (left.String?.Equals(right.String) == false) return false;
                if (left.DateTime?.Equals(right.DateTime) == false) return false;
                return true;
            }
            public static bool operator !=(ValueType left, ValueType right)
            {
                return !(left == right);
            }
        }
        public static explicit operator ValueType(MeasureValue item) => item._value;

        #endregion

        #region Extents




        #endregion

        #region Entity
        public Result<MeasureValue> Bind(SubSpace subSpace)
        {
            _key.Bind(subSpace);
            _value.Bind(subSpace);
            _bound = true;
            return Result.Ok(this);
        }
        public void Unbind(SubSpace subSpace)
        {
            _key.Unbind(subSpace);
            _value.Unbind(subSpace);
            _bound = false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_key.GetHashCode(), _value.GetHashCode());
        }
        public bool Equals(MeasureValue? other)
        {
            if (other is null)
                return false;
            return (_key == other.Value._key && _value == other.Value._value);
        }
        public override bool Equals(Object? other)
        {
            if (other is null) return false;
            if (other is MeasureValue) return Equals((MeasureValue)other);
            return false;
        }
        public int CompareTo(MeasureValue? other)
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
        public static bool operator ==(MeasureValue left, MeasureValue right)
        {
            if (left._key.Equals(right._key) != true) return false;
            return true;
        }
        public static bool operator !=(MeasureValue left, MeasureValue right)
        {
            return !(left == right);
        }
        public static bool operator <(MeasureValue left, MeasureValue right)
        {
            if (left._key < right._key) return false;
            return false;
        }
        public static bool operator >(MeasureValue left, MeasureValue right)
        {
            if (left._key > right._key) return false;
            return false;
        }
        #endregion

        public override string ToString()
        {
            if (_value.Double is not null) return _value.Double.Value.ToString();
            if (_value.Integer is not null) return _value.Integer.Value.ToString();
            if (_value.Decimal is not null) return _value.Decimal.Value.ToString();
            if (_value.DateTime is not null) return _value.DateTime.Value.ToString();
            if (_value.String is not null) return _value.String.ToString();
            return "N/A";
        }
    }
    #endregion
}
