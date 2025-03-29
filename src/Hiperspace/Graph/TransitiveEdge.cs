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
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Graph
{

    #region TransitiveEdge

    /* <Summary>Path from one Node to another Node over a number of routes</Summary> */
    [ProtoContract]
    public partial class TransitiveEdge : Hiperspace.Element<TransitiveEdge>
    {
        public KeyType _key;
        internal ValueType _value;

        public TransitiveEdge()
        {
            _key = new KeyType();
            _value = new ValueType();



        }
        public TransitiveEdge(KeyType key, ValueType value) : this()
        {
            _key = key;
            _value = value;

        }

        public TransitiveEdge(KeyType key) : this()
        {
            _key = key;
        }

        public TransitiveEdge(TransitiveEdge source, SubSpace? space = null) : this()
        {
            _key = source._key;
            _value = source._value;

            if (space != null)
                Bind(space);
        }

        [ProtoMember(2)]
        public Node? From
        {
            get
            {
                return _key.From?.Value;
            }
            set
            {
                if (SetSpace != null && _key.From != value) throw new Hiperspace.ValueMutationException("From");
                _key.From = value;
            }
        }

        [ProtoMember(3)]
        public Node? To
        {
            get
            {
                return _key.To?.Value;
            }
            set
            {
                if (SetSpace != null && _key.To != value) throw new Hiperspace.ValueMutationException("To");
                _key.To = value;
            }
        }

        [ProtoMember(4)]
        public String? TypeName
        {
            get
            {
                return _key.TypeName;
            }
            set
            {
                if (SetSpace != null && _key.TypeName != value) throw new Hiperspace.ValueMutationException($"TypeName");
                _key.TypeName = value;
            }
        }


        [ProtoMember(5)]
        public String? Name
        {
            get
            {
                return _value.Name;
            }
            set
            {
                if (SetSpace != null && _value.Name != value) throw new Hiperspace.ValueMutationException($"Name");
                _value.Name = value;
            }
        }

        /* <Summary>The Edge that provides the end of this Path</Summary> */
        [ProtoMember(10)]
        public Edge? Edge
        {
            get
            {
                return _value.Edge?.Value;
            }
            set
            {
                if (SetSpace != null && _value.Edge != value) throw new Hiperspace.ValueMutationException("Edge");
                _value.Edge = value;
            }
        }

        /* <Summary>The shortest source Path that this path extends</Summary> */
        [ProtoMember(11)]
        public Graph.TransitiveEdge? Source
        {
            get
            {
                return _value.Source?.Value;
            }
            set
            {
                if (SetSpace != null && _value.Source != value) throw new Hiperspace.ValueMutationException("Source");
                _value.Source = value;
            }
        }

        /* <Summary>The number of distict paths between the Nodes</Summary> */
        [ProtoMember(13)]
        public Int32? Width
        {
            get
            {
                return _value.Width;
            }
            set
            {
                if (SetSpace != null && _value.Width != value) throw new Hiperspace.ValueMutationException($"Width");
                _value.Width = value;
            }
        }

        /* <Summary>The shortest number of Edges in the Path</Summary> */
        [ProtoMember(14)]
        public Int32? Length
        {
            get
            {
                return _value.Length;
            }
            set
            {
                if (SetSpace != null && _value.Length != value) throw new Hiperspace.ValueMutationException($"Length");
                _value.Length = value;
            }
        }

        #region state

        [ProtoContract]
        public struct KeyType : IEquatable<KeyType>, IComparable<KeyType>
        {

            internal KeyType(TransitiveEdge item)
            {

                From = item.From;
                To = item.To;
                TypeName = item.TypeName;
            }

            [ProtoMember(2)] public KeyRef<Node.KeyType, Node>? From;
            [ProtoMember(3)] public KeyRef<Node.KeyType, Node>? To;
            [ProtoMember(4)] public String? TypeName;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool IsGetable()
            {

                if (!(From.HasValue)) return false;
                if (!(To.HasValue)) return false;
                if (TypeName == null || TypeName == default) return false;
                return true;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool IsSargable()
            {

                if (From != null && From?.Key.IsSargable() == true) return true;
                return false;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Bind(SubSpace space)
            {

                if (From.HasValue)
                {
                    var item = From.Value;
                    item.Bind(space.Nodes);
                    From = item;
                }
                if (To.HasValue)
                {
                    var item = To.Value;
                    item.Bind(space.Nodes);
                    To = item;
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Unbind(SubSpace space)
            {

                if (From.HasValue)
                {
                    var item = From.Value;
                    item.Unbind(space.Nodes);
                    From = item;
                }
                if (To.HasValue)
                {
                    var item = To.Value;
                    item.Unbind(space.Nodes);
                    To = item;
                }
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

                hc.Add(From);
                hc.Add(To);
                hc.Add(TypeName);
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

                if (left.From?.Equals(right.From) != true) return false;
                if (left.To?.Equals(right.To) != true) return false;
                if (left.TypeName?.Equals(right.TypeName) != true) return false;
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

            internal KeyRef<KeyType, TransitiveEdge> self { get => new KeyRef<KeyType, TransitiveEdge>(this); }

            public static implicit operator KeyRef<KeyType, TransitiveEdge>([NotNull] KeyType other)
            {
                return other.self;
            }
        }
        public static explicit operator KeyType(TransitiveEdge item) => item._key;

        [ProtoContract]
        public struct ValueType
        {
            internal ValueType(TransitiveEdge item)
            {

                Name = item.Name;
                Edge = item.Edge;
                Source = item.Source;
                Width = item.Width;
                Length = item.Length;
            }

            [ProtoMember(5)] public String? Name;
            [ProtoMember(10)] public KeyRef<Edge.KeyType, Edge>? Edge;
            [ProtoMember(11)] public KeyRef<Graph.TransitiveEdge.KeyType, Graph.TransitiveEdge>? Source;
            [ProtoMember(13)] public Int32? Width;
            [ProtoMember(14)] public Int32? Length;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Bind(SubSpace space)
            {

                if (Edge.HasValue)
                {
                    var item = Edge.Value;
                    item.Bind(space.Edges);
                    Edge = item;
                }
                if (Source.HasValue)
                {
                    var item = Source.Value;
                    item.Bind(space.TransitiveEdges);
                    Source = item;
                }
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Unbind(SubSpace space)
            {

                if (Edge.HasValue)
                {
                    var item = Edge.Value;
                    item.Unbind(space.Edges);
                    Edge = item;
                }
                if (Source.HasValue)
                {
                    var item = Source.Value;
                    item.Unbind(space.TransitiveEdges);
                    Source = item;
                }
            }
            public override int GetHashCode()
            {
                HashCode hc = new HashCode();

                hc.Add(Name);
                hc.Add(Edge);
                hc.Add(Source);
                hc.Add(Width);
                hc.Add(Length);
                return hc.ToHashCode();
            }
        }
        public static explicit operator ValueType(TransitiveEdge item) => item._value;

        #endregion

        #region Extents

        /// <summary>
        /// All the edges in the Transitive Edge
        /// </summary>
        /// <returns>Collection of all the edges</returns>
        public IEnumerable<Edge> AllEdges()
        {
            if (Edge != null)
                yield return Edge;
            if (Source != null)
                foreach (var item in Source.AllEdges())
                    yield return item;
        }

        /// <summary>
        /// All the nodes in the Transitive Edge
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public ISet<Node> AllNodes()
        {
            return InnerAllNodes().ToHashSet();
        }
        internal IEnumerable<Node> InnerAllNodes(bool root = true)
        {
            if (root)
            {
                if (From != null)
                    yield return From;
                if (To != null)
                    yield return To;
            }
            if (Source != null)
                foreach (var item in Source.InnerAllNodes(false))
                    yield return item;
        }

        #endregion

        #region views

        public static implicit operator Edge(TransitiveEdge item)
        {
#pragma warning disable CS8603
#pragma warning disable CS8604

            if (item == null) return null!;
            var view = new Edge
            {

                SKey = item.SKey,
                From = item?.From,
                To = item?.To,
                TypeName = item?.TypeName,
                Name = item?.Name
            };
            return new Edge(view, item?.SetSpace?.Space);
#pragma warning restore CS8604
#pragma warning restore CS8603

        }
        public static implicit operator KeyRef<Edge.KeyType, Edge>(TransitiveEdge? key)
        {
            if (key != null)
                return (Edge)key;
            else
                return default;
        }
        public TransitiveEdge(Edge that) : this()
        {
            var item = this;

            if (that.SKey != null)
                item.SKey = that.SKey;
            if (that.From != null)
                item.From = new(that.From);
            if (that.To != null)
                item.To = new(that.To);
            if (that.TypeName != null)
                item.TypeName = that.TypeName;
            if (that.Name != null)
                item.Name = that.Name;
        }
        #endregion

        #region Entity

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void PreBind()
        {


            if (Width == null)
            {
                Width = 1;
            }
            if (Length == null)
            {
                Length = 1;
            }
        }

        public override Result<TransitiveEdge> Bind(SubSpace subSpace)
        {
            if (subSpace is SubSpace space)
            {
                if (SetSpace != space.TransitiveEdges)
                {
                    PreBind();
                    if (space.TransitiveEdges.TryGetValue(this, out TransitiveEdge current))
                        return Result.Skip(current);
                    SetSpace = space.TransitiveEdges;
                    _key.Bind(space);
                    _value.Bind(space);



                }
                return Result.Ok(this);
            }
            return Result.Fail(this);
        }
        public override void Unbind(SubSpace subSpace)
        {
            if (subSpace is SubSpace space && space.TransitiveEdges == SetSpace)
            {
                _key.Unbind(space);
                _value.Unbind(space);



                SetSpace = null;
            }
        }

        public override int GetHashCode()
        {
            return _key.GetHashCode();
        }
        public override bool Equals(Object? other)
        {
            if (other == null) return false;
            if (other is TransitiveEdge) return Equals((TransitiveEdge)other);
            return false;
        }
        public override bool Equals(TransitiveEdge? other)
        {
            if (ReferenceEquals(null, other))
                return false;
            return (_key == other._key);
        }
        public override int CompareTo(TransitiveEdge? other)
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

        public override string SKey
        {
            get => From?.SKey + To?.SKey;
            set { }
        }
        #endregion
        #region helpers
        [JsonIgnore] public KeyRef<TransitiveEdge.KeyType, TransitiveEdge> self { get => new KeyRef<TransitiveEdge.KeyType, TransitiveEdge>(_key, this); }

        public static implicit operator KeyRef<KeyType, TransitiveEdge>([NotNull] TransitiveEdge other)
        {
            return other.self;
        }
        public static implicit operator KeyRef<KeyType, TransitiveEdge>?(TransitiveEdge? other)
        {
            if (!ReferenceEquals(null, other))
                return other.self;
            return null;
        }
        internal bool Filter(TransitiveEdge other, bool read)
        {

            if (other.From != null && this.From != null && this.From != other.From) return false;
            if (other.To != null && this.To != null && this.To != other.To) return false;
            if (other.TypeName != null && this.TypeName != null && this.TypeName != other.TypeName) return false;

            if (other.Name != null && this.Name != null && this.Name != other.Name) return false;
            if (other.Edge != null && this.Edge != null && this.Edge != other.Edge) return false;
            if (other.Source != null && this.Source != null && this.Source != other.Source) return false;
            return true;
        }
        public override bool BindKey<TKey>(TKey key)
        {
            if (key is KeyType kt && kt.IsSargable())
            {
                _key = kt;
                return true;
            }
            return false;
        }
        public static bool operator ==(TransitiveEdge? left, TransitiveEdge? right)
        {
            if (ReferenceEquals(null, left) && ReferenceEquals(null, right))
                return true;
            else if (ReferenceEquals(null, left) || ReferenceEquals(null, right))
                return false;
            else
                return left.Equals(right);
        }
        public static bool operator !=(TransitiveEdge? left, TransitiveEdge? right)
        {
            if (ReferenceEquals(null, left) && ReferenceEquals(null, right))
                return false;
            else if (ReferenceEquals(null, left) || ReferenceEquals(null, right))
                return true;
            else
                return !left.Equals(right);
        }

        [JsonIgnore]
        public new SetSpace<TransitiveEdge>? SetSpace { get => base.SetSpace; set => base.SetSpace = value; }

        #endregion
    }
    #endregion
}
