// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf;
using System.Diagnostics.CodeAnalysis;

/*view node #1
(
    Sid         : string
)
{
    name        : string,
    typename    : string 
}
*/
namespace Hiperspace
{
    public class Node : Element<Node>
    {
        public KeyType _key;
        internal ValueType _value;

        public Node ()
        {
            _key = new KeyType();
            _value = new ValueType();
            Froms = new RefSet<Edge>(() => new Edge { From = self }, item => item.From = self);
            Tos = new RefSet<Edge>(() => new Edge { To = self }, item => item.To = self);
        }
        public Node (KeyType key) : this()
        {
            _key = key;
            _value = new ValueType();
        }

        public override string SKey 
        {
            get => _key.SKey;
            set
            {
                if (SetSpace != null) throw new Hiperspace.MutationException($"SKey can not be changed once bound to a Space");
                _key.SKey = value;
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
        public string? TypeName 
        {
            get => _value.TypeName;
            set
            {
                if (SetSpace != null) throw new Hiperspace.MutationException($"TypeName can not be changed once bound to a Space");
                _value.TypeName = value;
            }
        }

        #region state
        [ProtoContract]
        public struct KeyType : IEquatable<KeyType>, IComparable<KeyType>
        {
            public KeyType(Node item)
            {
                SKey = item.SKey;
            }
            [ProtoMember(2)] public String SKey;

            public bool IsGetable()
            {
                if (SKey != default)
                    return true;
                return false;
            }
            public bool IsSargable()
            {
                if (SKey != default)
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
                HashCode hc = new HashCode();
                hc.Add(SKey);
                return hc.ToHashCode();
            }

            public int CompareTo(KeyType other)
            {
                if (this < other) return -1;
                if (this > other) return 1;
                return 0;
            }

            public static bool operator ==(KeyType left, KeyType right)
            {
                if (left.SKey != right.SKey) return false;
                return true;
            }
            public static bool operator !=(KeyType left, KeyType right)
            {
                return !(left == right);
            }
            public static bool operator <(KeyType left, KeyType right)
            {
                if (left.SKey != null && left.SKey.CompareTo(right.SKey) < 0) return true;
                return false;
            }
            public static bool operator >(KeyType left, KeyType right)
            {
                if (left.SKey != null && left.SKey.CompareTo(right.SKey) > 0) return true;
                return false;
            }
        }

        [ProtoContract]
        internal struct ValueType
        {
            public ValueType()
            {
                Name = default;
                TypeName = default;
            }
            internal ValueType(Node item)
            {
                Name = item.Name;
                TypeName = item.TypeName;
            }
            [ProtoMember(2)] public String? Name;
            [ProtoMember(3)] public String? TypeName;
        }

        #endregion
        #region Extents

        public RefSet<Edge> Froms;
        public RefSet<Edge> Tos;

        #endregion

        #region Entity
        public override Result<Node> Bind(SubSpace subspace)
        {
            if (SetSpace != subspace.Nodes)
            {
                SetSpace = subspace.Nodes;
                var result = SetSpace.Bind(this);
                if (result.Ok && this == result.Value)
                {
                    Froms.Bind(subspace.Edges);
                    Tos.Bind(subspace.Edges);
                }
                return result;
            }
            return Result.Skip(this);
        }
        public override void Unbind(SubSpace subSpace)
        {
            if (SetSpace?.Space == subSpace)
            {
                Froms.Unbind(subSpace);
                Tos.Unbind(subSpace);
            }
        }

        public override int GetHashCode()
        {
            return _key.GetHashCode();
        }

        public override int CompareTo(Node? other)
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
        public override bool Equals(Node? other)
        {
            if (ReferenceEquals(null, other))
                return false;
            return (_key == other._key);
        }
        #endregion
        #region  helpers
        internal KeyRef<Node.KeyType, Node> self { get => new KeyRef<Node.KeyType, Node>(_key, this); }

        public static implicit operator KeyRef<KeyType, Node>([NotNull] Node other)
        {
            return other.self;
        }
        public static implicit operator KeyRef<KeyType, Node>?(Node? other)
        {
            if (!ReferenceEquals(null, other))
                return other.self;
            return null;
        }
        #endregion

    }
}
