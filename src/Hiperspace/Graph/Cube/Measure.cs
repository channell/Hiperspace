// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Hiperspace;
using ProtoBuf;
using System.Runtime.CompilerServices;

namespace Graph.Cube
{

    #region Measure

    /* Summary: A Cube named measure associated with a Cube Node 
    */
    [ProtoContract]

    public partial struct Measure
    {
        internal KeyType _key;
        internal ValueType _value;
        internal bool _bound = false;

        public Measure()
        {

            _key = new KeyType();
            _value = new ValueType();



        }
        internal Measure(KeyType key, ValueType value) : this()
        {
            _key = key;
            _value = value;
        }
        internal Measure(KeyType key) : this()
        {
            _key = key;
        }
        public Measure(Measure source) : this()
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
        public Graph.Cube.MeasureValue? Value
        {
            get
            {
                return _value.Value;
            }
            set
            {
                if (_bound && _value.Value != value) throw new Hiperspace.ValueMutationException($"Value");
                _value.Value = value;
            }
        }

        #region state

        [ProtoContract]
        public struct KeyType : IEquatable<KeyType>, IComparable<KeyType>
        {
            internal KeyType(Measure item)
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
                if (other is null) return false;
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

                if (left.Name?.Equals(right.Name) == false) return false;
                return true;
            }
            public static bool operator !=(KeyType left, KeyType right)
            {
                return !(left == right);
            }
            public static bool operator <(KeyType left, KeyType right)
            {

                if (left.Name is not null && left.Name.CompareTo(right.Name) < 0) return true;
                return false;
            }
            public static bool operator >(KeyType left, KeyType right)
            {

                if (left.Name is not null && left.Name.CompareTo(right.Name) > 0) return true;
                return false;
            }
        }
        public static explicit operator KeyType(Measure item) => item._key;

        [ProtoContract]
        public struct ValueType
        {
            internal ValueType(Measure item)
            {

                Value = item.Value;
            }

            [ProtoMember(2)] public Graph.Cube.MeasureValue? Value;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Bind(SubSpace space)
            {

                if (Value is not null) Value?.Bind(space);

            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Unbind(SubSpace space)
            {

                if (Value is not null) Value?.Unbind(space);
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

                hc.Add(Value);
                return hc.ToHashCode();
            }

            public static bool operator ==(ValueType left, ValueType right)
            {

                if (left.Value?.Equals(right.Value) == false) return false;
                return true;
            }
            public static bool operator !=(ValueType left, ValueType right)
            {
                return !(left == right);
            }
        }
        public static explicit operator ValueType(Measure item) => item._value;

        #endregion

        #region Extents




        #endregion

        #region Entity
        public Result<Measure> Bind(SubSpace subSpace)
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
        public bool Equals(Measure? other)
        {
            if (other is null)
                return false;
            return (_key == other.Value._key && _value == other.Value._value);
        }
        public override bool Equals(Object? other)
        {
            if (other is null) return false;
            if (other is Measure) return Equals((Measure)other);
            return false;
        }
        public int CompareTo(Measure? other)
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
        public static bool operator ==(Measure left, Measure right)
        {
            if (left._key.Equals(right._key) != true) return false;
            return true;
        }
        public static bool operator !=(Measure left, Measure right)
        {
            return !(left == right);
        }
        public static bool operator <(Measure left, Measure right)
        {
            if (left._key < right._key) return false;
            return false;
        }
        public static bool operator >(Measure left, Measure right)
        {
            if (left._key > right._key) return false;
            return false;
        }
        #endregion

        /// <summary>
        /// Creates a list of measure objects from the Measures property of of an <see cref="ICubeFact" Measures collection/>
        /// </summary>
        /// <param name="measures">The dictionary returned from <see cref="ICubeFact.Measures"/></param>
        /// <returns>A protobuf serializable collection of measures for a <see cref="Node"/></returns>
        public static List<Graph.Cube.Measure> FromFact(IDictionary<string, (Aggregate, object)> measures)
        {
            var result = new List<Graph.Cube.Measure>();
            foreach (var kv in measures)
            {
                result.Add(MeasureValue.FromFact(kv));
            }
            return result;
        }
    }
    #endregion
}
