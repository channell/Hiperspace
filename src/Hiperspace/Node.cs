// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf;
using System.ComponentModel.DataAnnotations.Schema;
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

        public Node()
        {
            _key = new KeyType();
            _value = new ValueType();
            Froms = new RefSet<Edge>(() => new Edge { From = this}, item => item.From = this);
            Tos = new RefSet<Edge>(() => new Edge { To = this}, item => item.To = this);
        }
        public Node(Node source, SubSpace? space = null) : this()
        {
            _key = source._key;
            _value = source._value;
            if (space != null)
                Bind(space);
        }

        public Node(KeyType key) : this()
        {
            _key = key;
            _value = new ValueType();
        }

        public override string SKey
        {
            get => _key.SKey;
            set
            {
                if (SetSpace != null && _key.SKey != value) throw new Hiperspace.MutationException($"SKey can not be changed once bound to a Space");
                _key.SKey = value;
            }
        }
        public string? Name
        {
            get => _value.Name;
            set
            {
                if (SetSpace != null && _value.Name != value) throw new Hiperspace.MutationException($"CubeName can not be changed once bound to a Space");
                _value.Name = value;
            }
        }
        public string? TypeName
        {
            get => _value.TypeName;
            set
            {
                if (SetSpace != null && _value.TypeName != value) throw new Hiperspace.MutationException($"TypeName can not be changed once bound to a Space");
                _value.TypeName = value;
            }
        }

        private WeakReference? _Object;
        /// <summary>
        /// Get the underlying object from hiperspace and cache it
        /// </summary>
        /// <remarks>
        /// The object reference is hot held to allow Nodes to be extracted without 
        /// pinning the the source in memory. Not needed for most Graph use-cases 
        /// </remarks>
        public object? Object
        {
            get
            {
                if (_Object == null || _Object.Target == null)
                    _Object = new WeakReference(SetSpace?.Space?.Get<object>(SKey));
                return _Object.Target;
            }
        }

        /// <summary>
        /// Get all the properties of the underlying object
        /// </summary>
        [NotMapped]
        public (string,object?)[]? Properties 
        {
            get
            {
                var obj = Object;
                if (obj != null)
                {
                    return obj
                        .GetType()
                        .GetProperties()
                        .Where(pi => pi.CanRead && pi.Name != "SetSpace" && pi.Name != "SKey")
                        .Select(pi => (pi.Name, pi.GetValue(obj)))
                        .ToArray();
                }
                else 
                    return Array.Empty<(string,object?)>();
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
        public struct ValueType
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

        public IEnumerable<Edge> TosType(string typename)
        {
            foreach (var edge in Tos)
                if (edge.TypeName == typename)
                    yield return edge;
        }
        public IEnumerable<Edge> FromType(string typename)
        {
            foreach (var edge in Froms)
                if (edge.TypeName == typename)
                    yield return edge;
        }
        #endregion

        #region Entity
        public override Result<Node> Bind(SubSpace subspace)
        {
            if (SetSpace != subspace.Nodes)
            {
                SetSpace = subspace.Nodes;
                var result = SetSpace.Bind(this, true, true);
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
        public override bool Equals(Object? other)
        {
            if (other == null) return false;
            if (other is Node) return Equals((Node)other);
            return false;
        }
        public override bool Equals(Node? other)
        {
            if (ReferenceEquals(null, other))
                return false;
            return (_key == other._key);
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
        public static bool operator ==(Node? left, Node? right)
        {
            if (ReferenceEquals(null, left) && ReferenceEquals(null, right))
                return true;
            else if (ReferenceEquals(null, left) || ReferenceEquals(null, right))
                return false;
            else
                return left.Equals(right);
        }
        public static bool operator !=(Node? left, Node? right)
        {
            if (ReferenceEquals(null, left) && ReferenceEquals(null, right))
                return false;
            else if (ReferenceEquals(null, left) || ReferenceEquals(null, right))
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
        public bool Filter(Node other, bool read)
        {
            if (other._value.TypeName != null && this._value.TypeName != null && this._value.TypeName != other._value.TypeName) return false;
            if (other._key.SKey != null && this._key.SKey != null && this._key.SKey != other._key.SKey) return false;
            if (other._value.Name != null && this._value.Name != null && this._value.Name != other._value.Name) return false;
            return true;
        }
    }
}
