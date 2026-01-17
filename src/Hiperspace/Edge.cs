// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

/*
"edge between nodes"
view Edge #2
(
    From        : node,
    To          : node
    TypeName    : string
)
{
    name        : string,
};
*/
namespace Hiperspace
{
    [DebuggerDisplay("(F:{From}, T:{To}, N:{Name}, Y:{TypeName})")]
    public class Edge : Element<Edge>
    {
        public KeyType _key;
        internal ValueType _value;
        public Edge ()
        {

        }
        public Edge (KeyType key) : this()
        {
            _key = key;
            _value = new ValueType();
        }
        public Edge(Edge source, SubSpace? space = null) : this()
        {
            _key = source._key;
            _value = source._value;
            if (space is not null) 
                Bind(space);
        }

        public Node? From
        {
            get => _key.From?.Value;
            set
            {
                if (SetSpace is not null && _key.From != value) throw new Hiperspace.ValueMutationException($"From");
                _key.From = value;
            }
        }
        public string? From_SKey
        {
            get
            {
                return _key.From?.Key.SKey;
            }
        }
        public Node? To
        {
            get => _key.To?.Value;
            set
            {
                if (SetSpace is not null && _key.To != value) throw new Hiperspace.ValueMutationException($"To");
                _key.To = value;
            }
        }
        public string? To_SKey
        {
            get
            {
                return _key.To?.Key.SKey;
            }
        }
        public string? TypeName
        {
            get => _key.TypeName;
            set
            {
                if (SetSpace is not null && _key.TypeName != value) throw new Hiperspace.ValueMutationException($"TypeName");
                _key.TypeName = value;
            }
        }

        public string? Name 
        { 
            get => _value.Name;
            set
            {
                if (SetSpace is not null && _value.Name != value) throw new Hiperspace.ValueMutationException($"CubeName");
                _value.Name = value;
            }
        }

        public override string SKey
        {
            get => From?.SKey + To?.SKey;
            set { }
        }

        #region state
        [ProtoContract]
        public struct KeyType : IEquatable<KeyType>, IComparable<KeyType>
        {
            public KeyType(Edge item)
            {
                From = item.From;
                To = item.To;
                TypeName = item?.TypeName;
            }
            [ProtoMember(2)] public KeyRef<Node.KeyType, Node>? From;
            [ProtoMember(3)] public KeyRef<Node.KeyType, Node>? To;
            [ProtoMember(4)] public String? TypeName;

            public bool IsGetable()
            {
                if (From.HasValue && 
                    To.HasValue)
                    return true;
                return false;
            }
            public bool IsSargable()
            {
                if (From.HasValue)
                    return true;
                return false;
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
            public override int GetHashCode()
            {
                return HashCode.Combine(From, To, TypeName);
            }

            public int CompareTo(KeyType other)
            {
                if (this < other) return -1;
                if (this > other) return 1;
                return 0;
            }

            public static bool operator ==(KeyType left, KeyType right)
            {
                if (left.From != right.From) return false;
                if (left.To != right.To) return false;
                if (left.TypeName!= right.TypeName) return false;
                return true;
            }
            public static bool operator !=(KeyType left, KeyType right)
            {
                return !(left == right);
            }
            public static bool operator <(KeyType left, KeyType right)
            {
                if (left.From < right.From) return true;
                if (left.To < right.To) return true;
                if (left.TypeName is not null && left.TypeName.CompareTo(right.TypeName) < 0) return true;
                return false;
            }
            public static bool operator >(KeyType left, KeyType right)
            {
                if (left.From > right.From) return true;
                if (left.To > right.To) return true;
                if (left.TypeName is not null && left.TypeName.CompareTo(right.TypeName) > 0) return true;
                return false;
            }
        }

        [ProtoContract]
        public struct ValueType
        {
            public ValueType()
            {
                Name = default;
            }
            internal ValueType(Node item)
            {
                Name = item.Name;
            }
            [ProtoMember(5)] public String? Name;
            public override int GetHashCode()
            {
                return HashCode.Combine(Name);
            }
        }

        #endregion

        public override Result<Edge> Bind(SubSpace subspace)
        {
            if (SetSpace != subspace.Edges)
            {
                if (From is not null)
                {
                    var value = From;
                    value.Bind(subspace);
                    From = value;
                }
                if (To is not null)
                {
                    var value = To;
                    value.Bind(subspace);
                    To = value;
                }
                SetSpace = subspace.Edges;
                var result = SetSpace.Bind(this, true, true);
                return result;
            }
            return Result.Skip(this);
        }
        public override void Unbind(SubSpace subSpace)
        {
            if (SetSpace?.Space == subSpace)
            {
                From?.Unbind(subSpace);
                To?.Unbind(subSpace);
            }
        }

        public override int GetHashCode()
        {
            return _key.GetHashCode();
        }

        public override int CompareTo(Edge? other)
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
        public override bool Equals(Object? other)
        {
            if (other is null) return false;
            if (other is Edge) return Equals((Edge)other);
            return false;
        }
        public override bool Equals(Edge? other)
        {
            if (other is null)
                return false;
            return (_key == other._key);
        }

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
        #region  helpers
        internal KeyRef<Edge.KeyType, Edge> self { get => new KeyRef<Edge.KeyType, Edge>(_key, this); }

        public static implicit operator KeyRef<KeyType, Edge>([NotNull] Edge other)
        {
            return other.self;
        }
        public static implicit operator KeyRef<KeyType, Edge>?(Edge? other)
        {
            if (other is not null)
                return other.self;
            return null;
        }
        public static bool operator ==(Edge? left, Edge? right)
        {
            if (left is null && right is null)
                return true;
            else if (left is null || right is null)
                return false;
            else
                return left.Equals(right);
        }
        public static bool operator !=(Edge? left, Edge? right)
        {
            if (left is null && right is null)
                return false;
            else if (left is null || right is null)
                return true;
            else
                return !left.Equals(right);
        }
        #endregion

        /// <summary>
        /// Apply any filters in teh tempate that were not saragable in an index seek
        /// </summary>
        /// <param name="other">the template for the search</param>
        /// <param name="read">for compatability with HiLang generaterdf methods</param>
        /// <returns>true if it matched the provided values of the template</returns>
        public bool Filter(Edge other, bool read)
        {
            if (other._key.From is not null && this._key.From is not null && this._key.From != other._key.From) return false;
            if (other._key.To is not null && this._key.To is not null && this._key.To != other._key.To) return false;
            if (other._value.Name is not null && read && this._value.Name is not null && this._value.Name != other._value.Name) return false;
            if (other._key.TypeName is not null && this._key.TypeName is not null && this._key.TypeName != other._key.TypeName) return false;
            return true;
        }

    }
}
