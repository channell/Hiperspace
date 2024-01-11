// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Linq.Expressions;

namespace Hiperspace
{
    /// <summary>
    ///  Base class for domain Subspaces
    /// </summary>
    public abstract class SubSpace : HiperSpace, IQueryProvider
    {
        protected HiperSpace _space;
        internal Horizon[]? Horizon;
        protected DateTime? _version;
        /// <summary>
        /// Create a subpace throught he domain space
        /// </summary>
        /// <param name="space">base space that provides the store driver</param>
        /// <param name="horizon">set of filters to limit the content rerturned or stored</param>
        /// <param name="AsAt">Timestamp that versioned elements must be before </param>
        /// <param name="isStrict">enforce that elements must not exist before adding, and must exist prior to BindVersion</param>
        protected SubSpace(HiperSpace space, Horizon[]? horizon, DateTime? AsAt = null) : this(space)
        {
            Horizon = horizon;
            _version = AsAt;
        }
        /// <summary>
        /// Get the Horizon for a type 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>

        public SetSpace<Node> Nodes { get; protected set; }
        public SetSpace<Edge> Edges { get; protected set; }

#pragma warning disable CS8618 // Nodes and Edges will be constructed from domain
        public SubSpace (HiperSpace space) : base ()
        {
            _space = space;
        }
#pragma warning restore CS8618 // Nodes and Edges will be constructed from domain

        /// <summary>
        /// Get an object using the stringified key, regardless of type
        /// </summary>
        /// <param name="skey">a base64 encoding of a key structure</param>
        /// <returns>the object from one of the setspaces in the subspace</returns>
        public abstract object? Get(string sid);

        public bool ISChild(SubSpace space)
        {
            if (space == _space)
                return true;
            else if (_space is SubSpace subspace)
                return subspace.ISChild(space);
            else
                return false;
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, object? source = null)
        {
            return _space.Bind(key, value, source);
        }

        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, object? source = null)    
        {
            return _space.BindAsync(key, value, source);
        }

        public override IEnumerable<(byte[], byte[])> Space()
        {
            return _space.Space();
        }

        public override Task<IEnumerable<(byte[], byte[])>> SpaceAsync()
        {
            return _space.SpaceAsync();
        }

        public override IEnumerable<(byte[], byte[])> Find(byte[] begin, byte[] end)
        {
            return _space.Find(begin, end);
        }

        public override Task<IEnumerable<(byte[], byte[])>> FindAsync(byte[] begin, byte[] end)
        {
            return _space.FindAsync(begin, end);
        }

        public override byte[] Get(byte[] key)
        {
            return _space.Get(key);
        }

        public override Task<byte[]> GetAsync(byte[] key)
        {
            return _space.GetAsync(key);
        }
        public override Transaction BeginTransaction()
        {
            return _space.BeginTransaction();
        }

        public override void EndTransaction()
        {
            _space.EndTransaction();
        }

        public DateTime? AsAt => _version;

        #region IQueryProvider
        public virtual IQueryable CreateQuery(Expression expression)
        {
            if (expression.Type == typeof(Node)) return new Query<Node>(Nodes, this, expression);
            if (expression.Type == typeof(Edge)) return new Query<Edge>(Edges, this, expression);
            throw new ArgumentException($"{expression.Type.Name} is not as a suppoerted collection type");
        }
        public virtual IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            if (typeof(TElement) == typeof(Node)) return (IQueryable<TElement>)new Query<Node>(Nodes, this, expression);
            if (typeof(TElement) == typeof(Edge)) return (IQueryable<TElement>)new Query<Edge>(Edges, this, expression);

            var t = new EnumerableQuery<TElement>(expression).AsQueryable();
            return t;
            throw new ArgumentException($"{typeof(TElement).FullName} is not as a supported collection type");
        }
        public virtual object? Execute(Expression expression)
        {
            throw new NotImplementedException();
        }
        public virtual TResult Execute<TResult>(Expression expression)
        {
            throw new NotImplementedException(); 
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            return _space.Bind(key, value, version, source);
        }

        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            return _space.BindAsync(key, value, version, source);
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            return _space.Find(begin, end, version ?? _version);
        }

        public override Task<IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)>> FindAsync(byte[] begin, byte[] end, DateTime? version)
        {
            return _space.FindAsync(begin, end, version ?? _version);
        }

        public override (byte[], DateTime) Get(byte[] key, DateTime? version)
        {
            return _space.Get(key, version ?? _version);
        }

        public override Task<(byte[], DateTime)> GetAsync(byte[] key, DateTime? version)
        {
            return _space.GetAsync(key, version ?? _version);
        }

        public override IEnumerable<(byte[] value, DateTime version)> GetVersions(byte[] key)
        {
            return _space.GetVersions(key);
        }

        public override Task<IEnumerable<(byte[] value, DateTime version)>> GetVersionsAsync(byte[] key)
        {
            return _space.GetVersionsAsync(key);
        }

        /// <summary>
        /// Implementation of the Subspace should provide an implementation for entities they map
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public virtual SetSpace<TEntity>? SetSpace<TEntity>() where TEntity : Element<TEntity>, new()
        {
            if (typeof(TEntity) == typeof(Node))
                return Nodes as SetSpace<TEntity>;

            else if (typeof(TEntity) == typeof(Edge))
                return Edges as SetSpace<TEntity>;

            return null;
        }
        #endregion
    }
}
