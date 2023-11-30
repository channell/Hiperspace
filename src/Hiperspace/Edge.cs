// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf;

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
        internal KeyType _key;
        internal ValueType _value;

        public Edge ()
        {

        }
        public Edge (KeyType key) : this()
        {
            _key = key;
            _value = new ValueType();
        }

        public KeyRef<Node.KeyType, Node>? From
        {
            get;
            set;
        }
        public KeyRef<Node.KeyType, Node>? To
        {
            get;
            set;
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
                From = item.From?.Key;
                To = item.To?.Key;
                TypeName = item?.TypeName;
            }
            [ProtoMember(2)] public Node.KeyType? From;
            [ProtoMember(3)] public Node.KeyType? To;
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
                SetSpace = subspace.Edges;
                var result = SetSpace.Bind(this);
                if (result.Ok && this == result.Value)
                {
                    From?.Bind(subspace.Nodes);
                    To?.Bind(subspace.Nodes);
                }
                return result;
            }
            return Result.Fail(this);
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
    }
}
