// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024,2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Hiperspace.Meta;
using ProtoBuf.Meta;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading.Channels;

namespace Hiperspace
{
    /// <summary>
    ///  Base class for domain Subspaces
    /// </summary>
    public abstract class SubSpace : HiperSpace, IQueryProvider
    {
        protected HiperSpace _space;
        private Horizon[]? _Horizon;
        /// <summary>
        /// Allow domain specific subspaces to override the horizon with domain critieria conditional on Context
        /// </summary>
        public virtual Horizon[]? Horizon { get => _Horizon; init { _Horizon = value; } }
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
            var baseHorizon = space?.GetHorizons()?.ToArray();
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
        /// Initializes a new instance of the <see cref="SubSpace"/> class with the specified parameters, to simplify dynanmic construction 
        /// </summary>
        /// <param name="parameters">The parameters used to configure the <see cref="SubSpace"/> instance, including space, horizon, and labels.</param>
        protected SubSpace (SubSpaceParameters parameters) : this(parameters.Space, parameters.Horizon, parameters.AsAt, parameters.DeltaFrom)
        {
            ContextLabel = parameters.ContextLabel;
            UserLabel = parameters.UserLabel;
            RemoteLabel = parameters.RemoteLabel;
            _space = parameters.Space;
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

        /// <summary>
        /// The meta map is a optimised map used to serialise and deserialise the byte[], for range based access 
        /// within the key store. protobuf messages are transformed from length-prefix value to value prefix length 
        /// using this map
        /// </summary>
        public virtual (int key, (int member, int key)[] values)[] MetaMap { get; }

        /// <summary>
        /// Asynchronously retrieves metadata mappings 
        /// </summary>
        /// <returns>
        /// A task representing the asynchronous operation. The result contains an array of tuples,  where each tuple
        /// includes a key and an array of values associated with that key.  Each value is represented as a tuple
        /// containing a member and a key. Returns <see langword="null"/> if no metadata mappings are available.
        /// </returns>
        /// <remarks>
        /// This method must be overriden for remote clients that can not performed syncronous IO to the server
        /// </remarks>
        public virtual Task<(int key, (int member, int key)[] values)[]> MetaMapAsync()
        {
            return Task.FromResult(MetaMap);
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
        public SetSpace<Graph.HiperEdge> HiperEdges { get; protected set; }

#pragma warning disable CS8618 // Nodes and Edges will be constructed from domain
        public SubSpace(HiperSpace space) : base()
        {
            _space = space;
        }
#pragma warning restore CS8618 // Nodes and Edges will be constructed from domain

        /// <summary>
        /// Get an object using the stringified key, regardless of type
        /// </summary>
        /// <param name="skey">a base64 encoding of a key structure</param>
        /// <returns>the object from one of the setspaces in the subspace</returns>
        [Obsolete("Use Get<object>(sid) instead")]
        public abstract object? Get(string sid);

        /// <summary>
        /// Retrieves a node associated with the specified identifier.
        /// </summary>
        /// <remarks>
        /// This method will be overridden in generated domain space to provide to use each Elements cast operator to convert to a node.
        /// The default implementation can't use the implicit operqator, and returns a value only if the concrete object is already of the target type
        /// <returns>The typed object associated with the specified identifier, or <see langword="null"/> if it is missing or can't be cast to the type</returns>
        public virtual TEntity? Get<TEntity>(string sid) where TEntity : class
        {
#pragma warning disable CS0618
            var result = Get(sid);
#pragma warning restore CS0618
            if (result is TEntity entity)
                return entity;
            else
                return null;
        }
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

        public override IEnumerable<(byte[] Key, byte[] Value)> Find(byte[] begin, byte[] end)
        {
            return _space.Find(begin, end);
        }

        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Find(byte[] begin, byte[] end, DateTime? version)
        {
            return _space.Find(begin, end, version);
        }

        public override IAsyncEnumerable<(byte[] Key, byte[] Value)> FindAsync(byte[] begin, byte[] end, CancellationToken cancellationToken = default)
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

        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> DeltaAsync(byte[] begin, DateTime? version, CancellationToken cancellationToken = default)
        {
            return _space.DeltaAsync(begin, version);
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
        public override (byte[] Key, byte[] Value)? GetFirst(byte[] begin, byte[] end)
        {
            return _space.GetFirst(begin, end);
        }
        public override Task<(byte[] Key, byte[] Value)?> GetFirstAsync(byte[] begin, byte[] end)
        {
            return _space.GetFirstAsync(begin, end);
        }
        public override (byte[] Key, byte[] Value)? GetLast(byte[] begin, byte[] end)
        {
            return _space.GetLast(begin, end);
        }
        public override Task<(byte[] Key, byte[] Value)?> GetLastAsync(byte[] begin, byte[] end)
        {
            return _space.GetLastAsync(begin, end);
        }
        public override (byte[] Key, DateTime AsAt, byte[] Value)? GetFirst(byte[] begin, byte[] end, DateTime? version)
        {
            return _space.GetFirst(begin, end, version);
        }
        public override Task<(byte[] Key, DateTime AsAt, byte[] Value)?> GetFirstAsync(byte[] begin, byte[] end, DateTime? version)
        {
            return _space.GetFirstAsync(begin, end, version);
        }
        public override (byte[] Key, DateTime AsAt, byte[] Value)? GetLast(byte[] begin, byte[] end, DateTime? version)
        {
            return _space.GetLast(begin, end, version);
        }
        public override Task<(byte[] Key, DateTime AsAt, byte[] Value)?> GetLastAsync(byte[] begin, byte[] end, DateTime? version)
        {
            return _space.GetLastAsync(begin, end, version);
        }
        public override IEnumerable<(byte[] key, byte[] value)> GetMany(IEnumerable<byte[]> keys)
        {
            return _space.GetMany(keys);
        }
        public override IEnumerable<(byte[] key, byte[] Value, DateTime version)> GetMany(IEnumerable<byte[]> keys, DateTime? version)
        {
            return _space.GetMany(keys, version);
        }
        public override async IAsyncEnumerable<(byte[] key, byte[] value)> GetManyAsync(IAsyncEnumerable<byte[]> keys, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            await foreach (var item in _space.GetManyAsync(keys, cancellationToken))
                yield return item;
        }
        public override async IAsyncEnumerable<(byte[] key, byte[] Value, DateTime version)> GetManyAsync(IAsyncEnumerable<byte[]> keys, DateTime? version, [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            await foreach (var item in _space.GetManyAsync(keys, version, cancellationToken))
                yield return item;
        }
        public override IEnumerable<(byte[] Key, byte[] Value)> Scan(byte[] begin, byte[] end, byte[][] values)
        {
            return _space.Scan(begin, end, values);
        }
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> Scan(byte[] begin, byte[] end, byte[][] values, DateTime? version)
        {
            return _space.Scan(begin, end, values, version);
        }
        public override IAsyncEnumerable<(byte[] Key, byte[] Value)> ScanAsync(byte[] begin, byte[] end, byte[][] values, CancellationToken cancellationToken = default)
        {
            return _space.ScanAsync(begin, end, values, cancellationToken);
        }
        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> ScanAsync(byte[] begin, byte[] end, byte[][] values, DateTime? version, CancellationToken cancellationToken = default)
        {
            return _space.ScanAsync(begin, end, values, version, cancellationToken);
        }
        public override IAsyncEnumerable<(byte[] Key, byte[] Value)> ExportAsync(CancellationToken cancellationToken = default)
        {
            return _space.ExportAsync(cancellationToken);

        }
        public override void ImportAsync(IAsyncEnumerable<(byte[] Key, byte[] Value)> values, CancellationToken cancellationToken = default)
        {
            _space.ImportAsync(values, cancellationToken);
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
            return Execute<object>(expression);
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
        public override IEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindDelta(byte[] begin, DateTime? version, DateTime? DeltaFrom)
        {
            return _space.FindDelta(begin, version, DeltaFrom);
        }
        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindDeltaAsync(byte[] begin, DateTime? version, DateTime? DeltaFrom, CancellationToken cancellationToken = default)
        {
            return _space.FindDeltaAsync(begin, version, DeltaFrom, cancellationToken);
        }

        public override IAsyncEnumerable<(byte[] Key, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, CancellationToken cancellationToken = default)
        {
            return _space.FindIndexAsync(begin, end, cancellationToken);
        }
        public override IAsyncEnumerable<(byte[] Key, DateTime AsAt, byte[] Value)> FindIndexAsync(byte[] begin, byte[] end, DateTime? version, CancellationToken cancellationToken = default)
        {
            return _space.FindIndexAsync(begin, end, version, cancellationToken);
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

        public interface ISQLQueryProvider
        {
            public IQueryable<TEntity> Query<TEntity>(string SQL);
        }
        public ISQLQueryProvider? SQLQueryProvider { get; init; }

        /// <summary>
        /// Find all paths from a root node to a target node on a server if available
        /// </summary>
        /// <param name="root">the node that the path is being constructed from</param>
        /// <param name="route">the routing rules that are included in this path</param>
        /// <param name="length">the maximum length of routes to be searched</param>
        /// <param name="targets">set of target node types for this use of path</param>
        /// <returns>Set of value references to paths</returns>
        public virtual HashSet<Graph.HiperEdge> FindPaths(Node? root, Graph.Route? route, int? length = null, HashSet<string>? targets = null)
        {
            return Graph.PathFunctions.Paths(root, route, length, targets);
        }
        /// <summary>
        /// Find all paths from a root node to a target node on a server if available
        /// </summary>
        /// <param name="root">the node that the path is being constructed from</param>
        /// <param name="route">the routing rules that are included in this path</param>
        /// <param name="length">the maximum length of routes to be searched</param>
        /// <param name="targets">set of target node types for this use of path</param>
        /// <returns>Set of value references to paths</returns>
        public virtual async Task<HashSet<Graph.HiperEdge>> FindPathsAsync(Node root, Graph.Route route, int? length = null, HashSet<string>? targets = null, CancellationToken cancellationToken = default)
        {
            return await Graph.PathFunctions.PathsAsync(root, new Graph.RouteMap(route), length, targets, cancellationToken);
        }

        /// <summary>
        /// Export contents of the cache 
        /// </summary>
        /// <remarks>
        /// is usefull for web-assembly/phone clients need to transfer the full set for a use-case
        /// </remarks>
        public abstract IAsyncEnumerable<(byte[] Key, byte[] Value, DateTime? AsAt)> ExportCacheAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Import into SubSpace cache if avialable 
        /// </summary>
        /// <param name="cacheOnly">true if the import is only to the cache
        /// <remarks>
        /// cachedOnly is usefull for web-assembly/phone clients need to transfer the full set for a use-case
        /// </remarks>
        public abstract void ImportCacheAsync(IAsyncEnumerable<(byte[] Key, byte[] Value, DateTime? AsAt)> values, CancellationToken cancellationToken = default);

        public override MetaModel? GetMetaModel()
        {
            return _space.GetMetaModel();
        }
        public override Task<MetaModel?> GetMetaModelAsync()
        {
            return _space.GetMetaModelAsync();
        }

        public override bool SetMetaModel(MetaModel metaModel)
        {
            return _space.SetMetaModel(metaModel);
        }
        public override Task<bool> SetMetaModelAsync(MetaModel metaModel)
        {
            return _space.SetMetaModelAsync(metaModel);
        }
    }
}