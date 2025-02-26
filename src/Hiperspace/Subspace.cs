// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf.Meta;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;

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
        protected DateTime? _delta;
        protected TypeModel _model;

        /// <summary>
        /// Label applied to the subspace for security verification in Horizon filters
        /// </summary>
        public string? ContextLabel { get; init; }

        /// <summary>
        /// Label applied to the subspace for fine grained access control
        /// </summary>
        public IPrincipal? UserLabel { get; set; }


        /// <summary>
        /// Was the subspace opened by a remote client, and need to have Horizon security re-applied 
        /// </summary>
        public bool RemoteLabel { get; init; }

        /// <summary>
        /// Create a subpace through the domain space
        /// </summary>
        /// <param name="space">base space that provides the store driver</param>
        /// <param name="horizon">set of filters to limit the content returned or stored</param>
        /// <param name="AsAt">Timestamp that versioned elements must be before </param>
        /// <param name="DeltaFrom">Timestamp that versions must be after</param>
        protected SubSpace(HiperSpace space, Horizon[]? horizon, DateTime? AsAt = null, DateTime? DeltaFrom = null) : this(space)
        {
            var baseHorizon = space.GetHorizons().ToArray();
            if (baseHorizon != null && baseHorizon != Array.Empty<Horizon>())
            {
                if (horizon is null)
                    Horizon = baseHorizon;
                else
                    Horizon = baseHorizon.Union(horizon).ToArray();
            }
            else
            { 
                Horizon = horizon; 
            }
            _version = AsAt;
            _delta = DeltaFrom;
        }
        /// <summary>
        /// Get all Horizon filters from referenced spaces
        /// </summary>
        /// <returns>horizon filters</returns>
        public override IEnumerable<Horizon> GetHorizons()
        {
            if (Horizon != null)
                return Horizon;
            else
                return Array.Empty<Horizon>();
        }

        private void SubSpace_OnAfterGet(ref byte[] key, ref byte[] value)
        {
        }

        /// <summary>
        /// Get the Horizon for a type 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>

        public SetSpace<Node> Nodes { get; protected set; }
        public SetSpace<Edge> Edges { get; protected set; }
        public SetSpace<VectorSpace> VectorSpaces { get; protected set; }
        public SetSpace<VectorNode> VectorNodes { get; protected set; }

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
            if (space == this)
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

        public override IAsyncEnumerable<(byte[], byte[])> SpaceAsync(CancellationToken cancellationToken = default)
        {
            return _space.SpaceAsync(cancellationToken);
        }

        public override IEnumerable<(byte[], byte[])> Find(byte[] begin, byte[] end)
        {
            return _space.Find(begin, end);
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            return _space.Find(begin, end, version);
        }

        public override IAsyncEnumerable<(byte[], byte[])> FindAsync(byte[] begin, byte[] end, CancellationToken cancellationToken = default)
        {
            return _space.FindAsync(begin, end, cancellationToken);
        }
        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindAsync(byte[] begin, byte[] end, DateTime? version, CancellationToken cancellationToken = default)
        {
            return _space.FindAsync(begin, end, version, cancellationToken);
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Delta(byte[] key, DateTime? version)
        {
            return _space.Delta(key, version);
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> Nearest(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0)
        {
            return _space.Nearest(begin, end, version, space, method, limit);
        }
        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value, double Distance)> NearestAsync(byte[] begin, byte[] end, DateTime? version, Vector space, Vector.Method method, int limit = 0, CancellationToken cancellationToken = default)
        {
            return _space.NearestAsync(begin, end, version, space, method, limit, cancellationToken);
        }

        public override byte[] Get(byte[] key)
        {
            return _space.Get(key);
        }

        public override Task<byte[]> GetAsync(byte[] key)
        {
            return _space.GetAsync(key);
        }
        public override IEnumerable<(byte[] value, DateTime version)> GetVersions(byte[] key)
        {
            return _space.GetVersions(key);
        }
        public override IAsyncEnumerable<(byte[] value, DateTime version)> GetVersionsAsync(byte[] key, CancellationToken cancellationToken = default)
        {
            return _space.GetVersionsAsync(key, cancellationToken);
        }


        public DateTime? AsAt => _version;
        public DateTime? DeltaFrom => _delta;

        #region IQueryProvider
        public virtual IQueryable CreateQuery(Expression expression)
        {
            return new JoinQuery<object>(this, expression);
        }
        public virtual IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            return new JoinQuery<TElement>(this, expression);
        }
        public virtual object? Execute(Expression expression)
        {
            return Execute<object> (expression);
        }
        public virtual TResult Execute<TResult>(Expression expression)
        {
            var runner = new QueryRunner();
            var run = runner.Visit(expression);
            var lambda = Expression.Lambda(run);
            var compiled = lambda.Compile();
            var result = compiled.DynamicInvoke();
            return (TResult)result!;
        }

        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            return _space.Bind(key, value, version, source);
        }

        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, object? source = null)
        {
            return _space.BindAsync(key, value, version, source);
        }
        public override Result<byte[]> Bind(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            return _space.Bind(key, value, version, priorVersion, source);
        }
        public override Task<Result<byte[]>> BindAsync(byte[] key, byte[] value, DateTime version, DateTime? priorVersion, object? source = null)
        {
            return _space.BindAsync(key, value, version, priorVersion, source);
        }

        public override (byte[], DateTime) Get(byte[] key, DateTime? version)
        {
            return _space.Get(key, version ?? _version);
        }

        public override Task<(byte[], DateTime)> GetAsync(byte[] key, DateTime? version)
        {
            return _space.GetAsync(key, version ?? _version);
        }

        public override IEnumerable<(byte[] Key, byte[] Value)> FindIndex(byte[] begin, byte[] end)
        {
            return _space.FindIndex(begin, end);
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndex(byte[] begin, byte[] end, DateTime? version)
        {
            return _space.FindIndex(begin, end, version);
        }
        public override IAsyncEnumerable<(byte[] Key, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, CancellationToken cancellationToken = default)
        {
            return _space.FindIndexAsync(begin, end, cancellationToken);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
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
        public virtual Meta.Dependencies Dependencies => new Meta.Dependencies(Array.Empty<Meta.Dependency>());
        public virtual Meta.Routes Routes => new Meta.Routes(Array.Empty<Meta.Route>());
    }
}
