// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf;
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
            if (space != null) 
                Bind(space);
        }

        public KeyRef<Node.KeyType, Node>? From
        {
            get => _key.From;
            set
            {
                if (SetSpace != null) throw new Hiperspace.MutationException($"From can not be changed once bound to a Space");
                _key.From = value;
            }
        }
        public KeyRef<Node.KeyType, Node>? To
        {
            get => _key.To;
            set
            {
                if (SetSpace != null) throw new Hiperspace.MutationException($"To can not be changed once bound to a Space");
                _key.To = value;
            }
        }
        public string? TypeName
        {
            get => _value.TypeName;
            set
            {
                if (SetSpace != null) throw new Hiperspace.MutationException($"TypeName can not be changed once bound to a Space");
                _value.TypeName = value;
            }
        }

        public string? Name 
        { 
            get => _value.Name;
            set
            {
                if (SetSpace != null) throw new Hiperspace.MutationException($"Name can not be changed once bound to a Space");
                _value.Name = value;
            }
        }

        public override string SKey
        {
            get => From?.Key.SKey + To?.Key.SKey;
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
                if (other == null) return false;
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
                if (left.TypeName != null && left.TypeName.CompareTo(right.TypeName) < 0) return true;
                return false;
            }
            public static bool operator >(KeyType left, KeyType right)
            {
                if (left.From > right.From) return true;
                if (left.To > right.To) return true;
                if (left.TypeName != null && left.TypeName.CompareTo(right.TypeName) > 0) return true;
                return false;
            }
        }

        [ProtoContract]
        internal struct ValueType
        {
            public ValueType()
            {
                Name = default;
            }
            internal ValueType(Node item)
            {
                Name = item.Name;
            }
            [ProtoMember(2)] public String? Name;
            [ProtoMember(3)] public String? TypeName;
        }

        #endregion

        public override Result<Edge> Bind(SubSpace subspace)
        {       
            if (SetSpace != subspace.Edges)
            {
                if (From.HasValue)
                {
                    var value = From.Value;
                    value.Bind(subspace.Nodes);
                    From = value;
                }
                if (To.HasValue)
                {
                    var value = To.Value;
                    value.Bind(subspace.Nodes);
                    To = value;
                }
                SetSpace = subspace.Edges;
                var result = SetSpace.Bind(this);
                return result;
            }
            return Result.Skip(this);
        }
        public override void Unbind(SubSpace subSpace)
        {
            if (SetSpace?.Space == subSpace)
            {
                From?.Unbind(subSpace.Nodes);
                To?.Unbind(subSpace.Nodes);
            }
        }

        public override int GetHashCode()
        {
            return _key.GetHashCode();
        }

        public override int CompareTo(Edge? other)
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
        public override bool Equals(Edge? other)
        {
            if (ReferenceEquals(null, other))
                return false;
            return (_key == other._key);
        }
        #region  helpers
        internal KeyRef<Edge.KeyType, Edge> self { get => new KeyRef<Edge.KeyType, Edge>(_key, this); }

        public static implicit operator KeyRef<KeyType, Edge>([NotNull] Edge other)
        {
            return other.self;
        }
        public static implicit operator KeyRef<KeyType, Edge>?(Edge? other)
        {
            if (!ReferenceEquals(null, other))
                return other.self;
            return null;
        }
        #endregion
    }
}
