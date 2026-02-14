#nullable enable
using Hiperspace;
using Hiperspace.DB.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Hiperspace.DB.Calculation
{
    public class TogafAggregator : Hiperspace.DB.Calculation.IAggregator
    {
        #region API
        public async Task<Nullable<long>> Full(SubSpace subSpace, Database database)
        {
            var space = subSpace as Togaf.TogafSpace;
            if (space is null) throw new ArgumentException($"{nameof(subSpace)} is not an Togaf.TogafSpace");
            var start = DateTime.Now;

            DateTime? latest = null;
            long? totalRows = null;


            var TogafComplexity_CubeTask = FullTogafComplexity_Cube(space, database);
            var TogafFinancialCost_CubeTask = FullTogafFinancialCost_Cube(space, database);
            var TogafFinancialIncome_CubeTask = FullTogafFinancialIncome_Cube(space, database);

            long rowsTogafComplexity_Cube;
            DateTime? whenTogafComplexity_Cube;
            (rowsTogafComplexity_Cube, whenTogafComplexity_Cube) = await TogafComplexity_CubeTask;
            latest = latest is null || whenTogafComplexity_Cube > latest ? whenTogafComplexity_Cube : latest;
            totalRows = totalRows is null ? rowsTogafComplexity_Cube : totalRows + rowsTogafComplexity_Cube;
            long rowsTogafFinancialCost_Cube;
            DateTime? whenTogafFinancialCost_Cube;
            (rowsTogafFinancialCost_Cube, whenTogafFinancialCost_Cube) = await TogafFinancialCost_CubeTask;
            latest = latest is null || whenTogafFinancialCost_Cube > latest ? whenTogafFinancialCost_Cube : latest;
            totalRows = totalRows is null ? rowsTogafFinancialCost_Cube : totalRows + rowsTogafFinancialCost_Cube;
            long rowsTogafFinancialIncome_Cube;
            DateTime? whenTogafFinancialIncome_Cube;
            (rowsTogafFinancialIncome_Cube, whenTogafFinancialIncome_Cube) = await TogafFinancialIncome_CubeTask;
            latest = latest is null || whenTogafFinancialIncome_Cube > latest ? whenTogafFinancialIncome_Cube : latest;
            totalRows = totalRows is null ? rowsTogafFinancialIncome_Cube : totalRows + rowsTogafFinancialIncome_Cube;

            if (totalRows > 0)
            {
                var cube = new Cube
                {
                    owner = database,
                    CubeType = CubeType.Full,
                    Facts = totalRows,
                    When = latest
                };
                database.Cube.SetSpace?.Bind(cube, false);
            }
            return totalRows;
        }
        public async Task<Nullable<long>> Delta(SubSpace subSpace, Database database)
        {
            var delta = DeltaFrom(database, CubeType.Delta);
            DateTime? latest = null;
            long? totalRows = null;

            if (subSpace is Togaf.TogafSpace space)
            {

                var TogafComplexity_CubeTask = DeltaTogafComplexity_Cube(space, database, delta);
                var TogafFinancialCost_CubeTask = DeltaTogafFinancialCost_Cube(space, database, delta);
                var TogafFinancialIncome_CubeTask = DeltaTogafFinancialIncome_Cube(space, database, delta);

                long rowsTogafComplexity_Cube;
                DateTime? whenTogafComplexity_Cube;
                (rowsTogafComplexity_Cube, whenTogafComplexity_Cube) = await TogafComplexity_CubeTask;
                latest = latest is null || whenTogafComplexity_Cube > latest ? whenTogafComplexity_Cube : latest;
                totalRows = totalRows is null ? rowsTogafComplexity_Cube : totalRows + rowsTogafComplexity_Cube;
                long rowsTogafFinancialCost_Cube;
                DateTime? whenTogafFinancialCost_Cube;
                (rowsTogafFinancialCost_Cube, whenTogafFinancialCost_Cube) = await TogafFinancialCost_CubeTask;
                latest = latest is null || whenTogafFinancialCost_Cube > latest ? whenTogafFinancialCost_Cube : latest;
                totalRows = totalRows is null ? rowsTogafFinancialCost_Cube : totalRows + rowsTogafFinancialCost_Cube;
                long rowsTogafFinancialIncome_Cube;
                DateTime? whenTogafFinancialIncome_Cube;
                (rowsTogafFinancialIncome_Cube, whenTogafFinancialIncome_Cube) = await TogafFinancialIncome_CubeTask;
                latest = latest is null || whenTogafFinancialIncome_Cube > latest ? whenTogafFinancialIncome_Cube : latest;
                totalRows = totalRows is null ? rowsTogafFinancialIncome_Cube : totalRows + rowsTogafFinancialIncome_Cube;

                if (totalRows > 0)
                {
                    var cube = new Cube
                    {
                        owner = database,
                        CubeType = CubeType.Delta,
                        Facts = totalRows,
                        When = latest
                    };
                    database.Cube.SetSpace?.Bind(cube, false);
                }
                return totalRows;
            }
            else
            {
                throw new ArgumentException($"{nameof(space)} is not an Togaf.TogafSpace");
            }
        }

        public async Task<Nullable<long>> Dependency(SubSpace subSpace, Database database, Hiperspace.Meta.Route[] routes)
        {
            var delta = DeltaFrom(database, CubeType.Delta);
            DateTime? latest = null;
            long? totalRows = null;

            if (subSpace is Togaf.TogafSpace space)
            {

                var TogafComplexity_CubeTask = DependencyTogafComplexity_Cube(space, database, delta, routes);
                var TogafFinancialCost_CubeTask = DependencyTogafFinancialCost_Cube(space, database, delta, routes);
                var TogafFinancialIncome_CubeTask = DependencyTogafFinancialIncome_Cube(space, database, delta, routes);

                long rowsTogafComplexity_Cube;
                DateTime? whenTogafComplexity_Cube;
                (rowsTogafComplexity_Cube, whenTogafComplexity_Cube) = await TogafComplexity_CubeTask;
                latest = latest is null || whenTogafComplexity_Cube > latest ? whenTogafComplexity_Cube : latest;
                totalRows = totalRows is null ? rowsTogafComplexity_Cube : totalRows + rowsTogafComplexity_Cube;
                long rowsTogafFinancialCost_Cube;
                DateTime? whenTogafFinancialCost_Cube;
                (rowsTogafFinancialCost_Cube, whenTogafFinancialCost_Cube) = await TogafFinancialCost_CubeTask;
                latest = latest is null || whenTogafFinancialCost_Cube > latest ? whenTogafFinancialCost_Cube : latest;
                totalRows = totalRows is null ? rowsTogafFinancialCost_Cube : totalRows + rowsTogafFinancialCost_Cube;
                long rowsTogafFinancialIncome_Cube;
                DateTime? whenTogafFinancialIncome_Cube;
                (rowsTogafFinancialIncome_Cube, whenTogafFinancialIncome_Cube) = await TogafFinancialIncome_CubeTask;
                latest = latest is null || whenTogafFinancialIncome_Cube > latest ? whenTogafFinancialIncome_Cube : latest;
                totalRows = totalRows is null ? rowsTogafFinancialIncome_Cube : totalRows + rowsTogafFinancialIncome_Cube;

                if (totalRows > 0)
                {
                    var cube = new Cube
                    {
                        owner = database,
                        CubeType = CubeType.Dependency,
                        Facts = totalRows,
                        When = latest
                    };
                    database.Cube.SetSpace?.Bind(cube, false);
                }
                return totalRows;
            }
            else
                throw new ArgumentException($"{nameof(space)} is not an Togaf.TogafSpace");
        }
        public async Task<Nullable<long>> Related(SubSpace subSpace, Database database, Hiperspace.Meta.Route[] routes)
        {
            var delta = DeltaFrom(database, CubeType.Related);
            DateTime? latest = null;
            long? totalRows = null;

            if (subSpace is Togaf.TogafSpace space)
            {

                var TogafComplexity_CubeTask = RelatedTogafComplexity_Cube(space, database, delta, routes);
                var TogafFinancialCost_CubeTask = RelatedTogafFinancialCost_Cube(space, database, delta, routes);
                var TogafFinancialIncome_CubeTask = RelatedTogafFinancialIncome_Cube(space, database, delta, routes);

                long rowsTogafComplexity_Cube;
                DateTime? whenTogafComplexity_Cube;
                (rowsTogafComplexity_Cube, whenTogafComplexity_Cube) = await TogafComplexity_CubeTask;
                latest = latest is null || whenTogafComplexity_Cube > latest ? whenTogafComplexity_Cube : latest;
                totalRows = totalRows is null ? rowsTogafComplexity_Cube : totalRows + rowsTogafComplexity_Cube;
                long rowsTogafFinancialCost_Cube;
                DateTime? whenTogafFinancialCost_Cube;
                (rowsTogafFinancialCost_Cube, whenTogafFinancialCost_Cube) = await TogafFinancialCost_CubeTask;
                latest = latest is null || whenTogafFinancialCost_Cube > latest ? whenTogafFinancialCost_Cube : latest;
                totalRows = totalRows is null ? rowsTogafFinancialCost_Cube : totalRows + rowsTogafFinancialCost_Cube;
                long rowsTogafFinancialIncome_Cube;
                DateTime? whenTogafFinancialIncome_Cube;
                (rowsTogafFinancialIncome_Cube, whenTogafFinancialIncome_Cube) = await TogafFinancialIncome_CubeTask;
                latest = latest is null || whenTogafFinancialIncome_Cube > latest ? whenTogafFinancialIncome_Cube : latest;
                totalRows = totalRows is null ? rowsTogafFinancialIncome_Cube : totalRows + rowsTogafFinancialIncome_Cube;

                if (totalRows > 0)
                {
                    var cube = new Cube
                    {
                        owner = database,
                        CubeType = CubeType.Related,
                        Facts = totalRows,
                        When = latest
                    };
                    database.Cube.SetSpace?.Bind(cube, false);
                }
                return totalRows;
            }
            else
                throw new ArgumentException($"{nameof(space)} is not an AccSpace");
        }

        public async Task<Nullable<long>> Dimension(SubSpace subSpace, Database database, Hiperspace.Meta.Route[] routes)
        {
            var delta = DeltaFrom(database, CubeType.Dimension);
            DateTime? latest = null;
            long? totalRows = null;

            if (subSpace is Togaf.TogafSpace space)
            {
                if (delta is not null)
                {

                    var TogafComplexity_CubeTask = DimensionTogafComplexity_Cube(space, database, delta, routes);
                    var TogafFinancialCost_CubeTask = DimensionTogafFinancialCost_Cube(space, database, delta, routes);
                    var TogafFinancialIncome_CubeTask = DimensionTogafFinancialIncome_Cube(space, database, delta, routes);

                    long rowsTogafComplexity_Cube;
                    DateTime? whenTogafComplexity_Cube;
                    (rowsTogafComplexity_Cube, whenTogafComplexity_Cube) = await TogafComplexity_CubeTask;
                    latest = latest is null || whenTogafComplexity_Cube > latest ? whenTogafComplexity_Cube : latest;
                    totalRows = totalRows is null ? rowsTogafComplexity_Cube : totalRows + rowsTogafComplexity_Cube;
                    long rowsTogafFinancialCost_Cube;
                    DateTime? whenTogafFinancialCost_Cube;
                    (rowsTogafFinancialCost_Cube, whenTogafFinancialCost_Cube) = await TogafFinancialCost_CubeTask;
                    latest = latest is null || whenTogafFinancialCost_Cube > latest ? whenTogafFinancialCost_Cube : latest;
                    totalRows = totalRows is null ? rowsTogafFinancialCost_Cube : totalRows + rowsTogafFinancialCost_Cube;
                    long rowsTogafFinancialIncome_Cube;
                    DateTime? whenTogafFinancialIncome_Cube;
                    (rowsTogafFinancialIncome_Cube, whenTogafFinancialIncome_Cube) = await TogafFinancialIncome_CubeTask;
                    latest = latest is null || whenTogafFinancialIncome_Cube > latest ? whenTogafFinancialIncome_Cube : latest;
                    totalRows = totalRows is null ? rowsTogafFinancialIncome_Cube : totalRows + rowsTogafFinancialIncome_Cube;

                    if (totalRows > 0)
                    {
                        var cube = new Cube
                        {
                            owner = database,
                            CubeType = CubeType.Dimension,
                            Facts = totalRows,
                            When = latest
                        };
                        database.Cube.SetSpace?.Bind(cube, false);
                    }
                }
                return totalRows;
            }
            else
                throw new ArgumentException($"{nameof(space)} is not an AccSpace");
        }
        #endregion

        #region  API impl

        private async Task<(long rows, DateTime? when)> FullTogafComplexity_Cube(Togaf.TogafSpace space, Database database)
        {
            var start = DateTime.Now;
            var parameters = new SubSpaceParameters
            {
                Space = space,
                ContextLabel = space.ContextLabel,
            };

            using (var session = new Togaf.TogafSpace(parameters))
            {
                long rowCount = 0;
                DateTime? now = null;
                using (var snap = new Togaf.TogafSpace(parameters.WithAsAt(start)))
                {
                    var query = Query(snap.Complexitys, space.ContextLabel);

                    foreach (var row in query)
                    {
                        if (now is null || row.AsAt > now)
                            now = row.AsAt;
                        session.Complexity_Facts.Bind(row, true);
                        rowCount++;
                    }
                    var tasks = new List<Task<Result<Togaf.Complexity_Cube>>>();
                    await foreach (var row in session.Complexity_Cubes.FindAsync(new Togaf.Complexity_Cube()))
                    {
                        tasks.Add(Task.Run(async () =>
                        {
                            var result = row.Calculate() as Togaf.Complexity_Cube;
                            if (result is not null && result.Deleted == false)
                                return await session.Complexity_Cubes.BindAsync(result);
                            return Result.Fail(result!, "not found");
                        }));
                        rowCount++;
                    }
                    await Task.WhenAll(tasks);
                }

                return (rowCount, now ?? start);
            }
        }
        private async Task<(long rows, DateTime? when)> FullTogafFinancialCost_Cube(Togaf.TogafSpace space, Database database)
        {
            var start = DateTime.Now;
            var parameters = new SubSpaceParameters
            {
                Space = space,
                ContextLabel = space.ContextLabel,
            };

            using (var session = new Togaf.TogafSpace(parameters))
            {
                long rowCount = 0;
                DateTime? now = null;
                using (var snap = new Togaf.TogafSpace(parameters.WithAsAt(start)))
                {
                    var query = Query(snap.Costs, space.ContextLabel);

                    foreach (var row in query)
                    {
                        if (now is null || row.AsAt > now)
                            now = row.AsAt;
                        session.Cost_Facts.Bind(row, true);
                        rowCount++;
                    }
                    var tasks = new List<Task<Result<Togaf.Financial.Cost_Cube>>>();
                    await foreach (var row in session.Cost_Cubes.FindAsync(new Togaf.Financial.Cost_Cube()))
                    {
                        tasks.Add(Task.Run(async () =>
                        {
                            var result = row.Calculate() as Togaf.Financial.Cost_Cube;
                            if (result is not null && result.Deleted == false)
                                return await session.Cost_Cubes.BindAsync(result);
                            return Result.Fail(result!, "not found");
                        }));
                        rowCount++;
                    }
                    await Task.WhenAll(tasks);
                }

                return (rowCount, now ?? start);
            }
        }
        private async Task<(long rows, DateTime? when)> FullTogafFinancialIncome_Cube(Togaf.TogafSpace space, Database database)
        {
            var start = DateTime.Now;
            var parameters = new SubSpaceParameters
            {
                Space = space,
                ContextLabel = space.ContextLabel,
            };

            using (var session = new Togaf.TogafSpace(parameters))
            {
                long rowCount = 0;
                DateTime? now = null;
                using (var snap = new Togaf.TogafSpace(parameters.WithAsAt(start)))
                {
                    var query = Query(snap.Incomes, space.ContextLabel);

                    foreach (var row in query)
                    {
                        if (now is null || row.AsAt > now)
                            now = row.AsAt;
                        session.Income_Facts.Bind(row, true);
                        rowCount++;
                    }
                    var tasks = new List<Task<Result<Togaf.Financial.Income_Cube>>>();
                    await foreach (var row in session.Income_Cubes.FindAsync(new Togaf.Financial.Income_Cube()))
                    {
                        tasks.Add(Task.Run(async () =>
                        {
                            var result = row.Calculate() as Togaf.Financial.Income_Cube;
                            if (result is not null && result.Deleted == false)
                                return await session.Income_Cubes.BindAsync(result);
                            return Result.Fail(result!, "not found");
                        }));
                        rowCount++;
                    }
                    await Task.WhenAll(tasks);
                }

                return (rowCount, now ?? start);
            }
        }

        private async Task<(long rows, DateTime? when)> DeltaTogafComplexity_Cube(Togaf.TogafSpace space, Database database, DateTime? delta)
        {
            if (delta is null)
            {
                return await FullTogafComplexity_Cube(space, database); // no delta, so run full aggregation
            }
            var index = space.Complexitys as IDeltaIndex<Togaf.Complexity>;
            if (index is not null)
            {
                var source = index.Delta(new Togaf.Complexity(), delta.Value).AsQueryable();
                return await DeltaProcess(space, database, delta.Value, source, CubeType.Delta);
            }
            else
                return (0, null);
        }
        private async Task<(long rows, DateTime? when)> DeltaTogafFinancialCost_Cube(Togaf.TogafSpace space, Database database, DateTime? delta)
        {
            if (delta is null)
            {
                return await FullTogafFinancialCost_Cube(space, database); // no delta, so run full aggregation
            }
            var index = space.Costs as IDeltaIndex<Togaf.Financial.Cost>;
            if (index is not null)
            {
                var source = index.Delta(new Togaf.Financial.Cost(), delta.Value).AsQueryable();
                return await DeltaProcess(space, database, delta.Value, source, CubeType.Delta);
            }
            else
                return (0, null);
        }
        private async Task<(long rows, DateTime? when)> DeltaTogafFinancialIncome_Cube(Togaf.TogafSpace space, Database database, DateTime? delta)
        {
            if (delta is null)
            {
                return await FullTogafFinancialIncome_Cube(space, database); // no delta, so run full aggregation
            }
            var index = space.Incomes as IDeltaIndex<Togaf.Financial.Income>;
            if (index is not null)
            {
                var source = index.Delta(new Togaf.Financial.Income(), delta.Value).AsQueryable();
                return await DeltaProcess(space, database, delta.Value, source, CubeType.Delta);
            }
            else
                return (0, null);
        }

        private async Task<(long rows, DateTime? when)> DependencyTogafComplexity_Cube(Togaf.TogafSpace space, Database database, DateTime? delta, Hiperspace.Meta.Route[] routes)
        {
            if (delta is not null)
            {
                var changes = new HashSet<Togaf.Complexity>();

                for (int c = 0; c < routes.Length; c++)
                {
                    var route = routes[c];
                    if (route.TargeType == typeof(Togaf.Complexity))
                    {
                        foreach (var obj in route.DeltaObject(delta.Value))
                        {
                            if (obj is Togaf.Complexity transaction)
                            {
                                if (transaction.AsAt > delta)
                                {
                                    changes.Add(transaction);
                                }
                            }
                        }
                    }
                }
                return await DeltaProcess(space, database, delta.Value, changes.AsQueryable(), CubeType.Dependency);
            }
            else
                return await FullTogafComplexity_Cube(space, database); // no delta, so run full aggregation
        }
        private async Task<(long rows, DateTime? when)> DependencyTogafFinancialCost_Cube(Togaf.TogafSpace space, Database database, DateTime? delta, Hiperspace.Meta.Route[] routes)
        {
            if (delta is not null)
            {
                var changes = new HashSet<Togaf.Financial.Cost>();

                for (int c = 0; c < routes.Length; c++)
                {
                    var route = routes[c];
                    if (route.TargeType == typeof(Togaf.Financial.Cost))
                    {
                        foreach (var obj in route.DeltaObject(delta.Value))
                        {
                            if (obj is Togaf.Financial.Cost transaction)
                            {
                                if (transaction.AsAt > delta)
                                {
                                    changes.Add(transaction);
                                }
                            }
                        }
                    }
                }
                return await DeltaProcess(space, database, delta.Value, changes.AsQueryable(), CubeType.Dependency);
            }
            else
                return await FullTogafFinancialCost_Cube(space, database); // no delta, so run full aggregation
        }
        private async Task<(long rows, DateTime? when)> DependencyTogafFinancialIncome_Cube(Togaf.TogafSpace space, Database database, DateTime? delta, Hiperspace.Meta.Route[] routes)
        {
            if (delta is not null)
            {
                var changes = new HashSet<Togaf.Financial.Income>();

                for (int c = 0; c < routes.Length; c++)
                {
                    var route = routes[c];
                    if (route.TargeType == typeof(Togaf.Financial.Income))
                    {
                        foreach (var obj in route.DeltaObject(delta.Value))
                        {
                            if (obj is Togaf.Financial.Income transaction)
                            {
                                if (transaction.AsAt > delta)
                                {
                                    changes.Add(transaction);
                                }
                            }
                        }
                    }
                }
                return await DeltaProcess(space, database, delta.Value, changes.AsQueryable(), CubeType.Dependency);
            }
            else
                return await FullTogafFinancialIncome_Cube(space, database); // no delta, so run full aggregation
        }

        private async Task<(long rows, DateTime? when)> RelatedTogafComplexity_Cube(Togaf.TogafSpace space, Database database, DateTime? delta, Hiperspace.Meta.Route[] routes)
        {
            if (delta is not null)
            {
                var changes = new HashSet<Togaf.Complexity>();

                for (int c = 0; c < routes.Length; c++)
                {
                    var route = routes[c];
                    if (route.TargeType == typeof(Togaf.Complexity))
                    {
                        foreach (var obj in route.DeltaObject(delta.Value))
                        {
                            if (obj is Togaf.Complexity transaction)
                            {
                                if (transaction.AsAt > delta)
                                {
                                    changes.Add(transaction);
                                }
                            }
                        }
                    }
                }
                return await DeltaProcess(space, database, delta.Value, changes.AsQueryable(), CubeType.Related);
            }
            else
                return await FullTogafComplexity_Cube(space, database); // no delta, so run full aggregation
        }
        private async Task<(long rows, DateTime? when)> RelatedTogafFinancialCost_Cube(Togaf.TogafSpace space, Database database, DateTime? delta, Hiperspace.Meta.Route[] routes)
        {
            if (delta is not null)
            {
                var changes = new HashSet<Togaf.Financial.Cost>();

                for (int c = 0; c < routes.Length; c++)
                {
                    var route = routes[c];
                    if (route.TargeType == typeof(Togaf.Financial.Cost))
                    {
                        foreach (var obj in route.DeltaObject(delta.Value))
                        {
                            if (obj is Togaf.Financial.Cost transaction)
                            {
                                if (transaction.AsAt > delta)
                                {
                                    changes.Add(transaction);
                                }
                            }
                        }
                    }
                }
                return await DeltaProcess(space, database, delta.Value, changes.AsQueryable(), CubeType.Related);
            }
            else
                return await FullTogafFinancialCost_Cube(space, database); // no delta, so run full aggregation
        }
        private async Task<(long rows, DateTime? when)> RelatedTogafFinancialIncome_Cube(Togaf.TogafSpace space, Database database, DateTime? delta, Hiperspace.Meta.Route[] routes)
        {
            if (delta is not null)
            {
                var changes = new HashSet<Togaf.Financial.Income>();

                for (int c = 0; c < routes.Length; c++)
                {
                    var route = routes[c];
                    if (route.TargeType == typeof(Togaf.Financial.Income))
                    {
                        foreach (var obj in route.DeltaObject(delta.Value))
                        {
                            if (obj is Togaf.Financial.Income transaction)
                            {
                                if (transaction.AsAt > delta)
                                {
                                    changes.Add(transaction);
                                }
                            }
                        }
                    }
                }
                return await DeltaProcess(space, database, delta.Value, changes.AsQueryable(), CubeType.Related);
            }
            else
                return await FullTogafFinancialIncome_Cube(space, database); // no delta, so run full aggregation
        }

        public async Task<(long rows, DateTime? when)> DimensionTogafComplexity_Cube(Togaf.TogafSpace space, Database database, DateTime? delta, Hiperspace.Meta.Route[] routes)
        {
            if (delta is not null)
            {

                var Hosts = new HashSet<Togaf.Technology.Host>();
                var Events = new HashSet<Togaf.Business.Event>();
                var Systems = new HashSet<Togaf.Application.System>();
                var Services = new HashSet<Togaf.Service>();
                var Processs = new HashSet<Togaf.Business.Process>();
                var Products = new HashSet<Togaf.Business.Product>();
                var Platforms = new HashSet<Togaf.Technology.Platform>();
                var Functions = new HashSet<Togaf.Business.Function>();
                var Capabilitys = new HashSet<Togaf.Business.Capability>();
                var Organizations = new HashSet<Togaf.Organization>();
                long count = 0;
                DateTime? when = null;

                if (space.Hosts is IDeltaIndex<Togaf.Technology.Host> deltaHost)
                {
                    var targets = deltaHost.Delta(new Togaf.Technology.Host(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Technology.Host> itemHost && itemHost.Parent is not null)
                            targets.UnionWith(itemHost.AllParents());
                    }
                    Hosts.UnionWith(targets);
                }
                if (space.Events is IDeltaIndex<Togaf.Business.Event> deltaEvent)
                {
                    var targets = deltaEvent.Delta(new Togaf.Business.Event(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Business.Event> itemEvent && itemEvent.Parent is not null)
                            targets.UnionWith(itemEvent.AllParents());
                    }
                    Events.UnionWith(targets);
                }
                if (space.Systems is IDeltaIndex<Togaf.Application.System> deltaSystem)
                {
                    var targets = deltaSystem.Delta(new Togaf.Application.System(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Application.System> itemSystem && itemSystem.Parent is not null)
                            targets.UnionWith(itemSystem.AllParents());
                    }
                    Systems.UnionWith(targets);
                }
                if (space.Services is IDeltaIndex<Togaf.Service> deltaService)
                {
                    var targets = deltaService.Delta(new Togaf.Service(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Service> itemService && itemService.Parent is not null)
                            targets.UnionWith(itemService.AllParents());
                    }
                    Services.UnionWith(targets);
                }
                if (space.Processs is IDeltaIndex<Togaf.Business.Process> deltaProcess)
                {
                    var targets = deltaProcess.Delta(new Togaf.Business.Process(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Business.Process> itemProcess && itemProcess.Parent is not null)
                            targets.UnionWith(itemProcess.AllParents());
                    }
                    Processs.UnionWith(targets);
                }
                if (space.Products is IDeltaIndex<Togaf.Business.Product> deltaProduct)
                {
                    var targets = deltaProduct.Delta(new Togaf.Business.Product(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Business.Product> itemProduct && itemProduct.Parent is not null)
                            targets.UnionWith(itemProduct.AllParents());
                    }
                    Products.UnionWith(targets);
                }
                if (space.Platforms is IDeltaIndex<Togaf.Technology.Platform> deltaPlatform)
                {
                    var targets = deltaPlatform.Delta(new Togaf.Technology.Platform(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Technology.Platform> itemPlatform && itemPlatform.Parent is not null)
                            targets.UnionWith(itemPlatform.AllParents());
                    }
                    Platforms.UnionWith(targets);
                }
                if (space.Functions is IDeltaIndex<Togaf.Business.Function> deltaFunction)
                {
                    var targets = deltaFunction.Delta(new Togaf.Business.Function(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Business.Function> itemFunction && itemFunction.Parent is not null)
                            targets.UnionWith(itemFunction.AllParents());
                    }
                    Functions.UnionWith(targets);
                }
                if (space.Capabilitys is IDeltaIndex<Togaf.Business.Capability> deltaCapability)
                {
                    var targets = deltaCapability.Delta(new Togaf.Business.Capability(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Business.Capability> itemCapability && itemCapability.Parent is not null)
                            targets.UnionWith(itemCapability.AllParents());
                    }
                    Capabilitys.UnionWith(targets);
                }
                if (space.Organizations is IDeltaIndex<Togaf.Organization> deltaOrganization)
                {
                    var targets = deltaOrganization.Delta(new Togaf.Organization(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Organization> itemOrganization && itemOrganization.Parent is not null)
                            targets.UnionWith(itemOrganization.AllParents());
                    }
                    Organizations.UnionWith(targets);
                }

                for (int c = 0; c < routes.Length; c++)
                {
                    var route = routes[c];
                    foreach (var obj in route.DeltaObject(delta.Value))
                    {

                        if (obj is Togaf.Technology.Host itemHost)
                        {
                            Hosts.Add(itemHost);
                            if (itemHost is ICubeHierarchy<Togaf.Technology.Host> hier)
                                Hosts.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Business.Event itemEvent)
                        {
                            Events.Add(itemEvent);
                            if (itemEvent is ICubeHierarchy<Togaf.Business.Event> hier)
                                Events.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Application.System itemSystem)
                        {
                            Systems.Add(itemSystem);
                            if (itemSystem is ICubeHierarchy<Togaf.Application.System> hier)
                                Systems.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Service itemService)
                        {
                            Services.Add(itemService);
                            if (itemService is ICubeHierarchy<Togaf.Service> hier)
                                Services.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Business.Process itemProcess)
                        {
                            Processs.Add(itemProcess);
                            if (itemProcess is ICubeHierarchy<Togaf.Business.Process> hier)
                                Processs.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Business.Product itemProduct)
                        {
                            Products.Add(itemProduct);
                            if (itemProduct is ICubeHierarchy<Togaf.Business.Product> hier)
                                Products.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Technology.Platform itemPlatform)
                        {
                            Platforms.Add(itemPlatform);
                            if (itemPlatform is ICubeHierarchy<Togaf.Technology.Platform> hier)
                                Platforms.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Business.Function itemFunction)
                        {
                            Functions.Add(itemFunction);
                            if (itemFunction is ICubeHierarchy<Togaf.Business.Function> hier)
                                Functions.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Business.Capability itemCapability)
                        {
                            Capabilitys.Add(itemCapability);
                            if (itemCapability is ICubeHierarchy<Togaf.Business.Capability> hier)
                                Capabilitys.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Organization itemOrganization)
                        {
                            Organizations.Add(itemOrganization);
                            if (itemOrganization is ICubeHierarchy<Togaf.Organization> hier)
                                Organizations.UnionWith(hier.AllParents());
                        }
                    }
                }
                var predicate = PredicateBuilder.False<Togaf.Complexity_Cube>();

                if (Hosts.Count > 0) predicate = predicate.Or(c => c.Host != null && Hosts.Contains(c.Host));
                if (Events.Count > 0) predicate = predicate.Or(c => c.Event != null && Events.Contains(c.Event));
                if (Systems.Count > 0) predicate = predicate.Or(c => c.System != null && Systems.Contains(c.System));
                if (Services.Count > 0) predicate = predicate.Or(c => c.Service != null && Services.Contains(c.Service));
                if (Processs.Count > 0) predicate = predicate.Or(c => c.Process != null && Processs.Contains(c.Process));
                if (Products.Count > 0) predicate = predicate.Or(c => c.Product != null && Products.Contains(c.Product));
                if (Platforms.Count > 0) predicate = predicate.Or(c => c.Platform != null && Platforms.Contains(c.Platform));
                if (Functions.Count > 0) predicate = predicate.Or(c => c.Function != null && Functions.Contains(c.Function));
                if (Capabilitys.Count > 0) predicate = predicate.Or(c => c.Capability != null && Capabilitys.Contains(c.Capability));
                if (Organizations.Count > 0) predicate = predicate.Or(c => c.Organization != null && Organizations.Contains(c.Organization));

                var changes = space.Complexity_Cubes.Where(predicate).ToArray();
                var tasks = new Task<Togaf.Complexity_Cube?>[changes.Length];
                for (int c = 0; c < changes.Length; c++)
                {
                    var C = c;
                    tasks[C] = Task.Run(() => changes[C].Calculate() as Togaf.Complexity_Cube);
                }
                for (int c = 0; c < tasks.Length; c++)
                {
                    var C = c;
                    var result = await tasks[c];
                    if (result != null)
                    {
                        await space.Complexity_Cubes.BindAsync(result, false);
                        count++;
                    }
                }
                return (count, when);
            }
            else
                return await FullTogafComplexity_Cube(space, database);
        }
        public async Task<(long rows, DateTime? when)> DimensionTogafFinancialCost_Cube(Togaf.TogafSpace space, Database database, DateTime? delta, Hiperspace.Meta.Route[] routes)
        {
            if (delta is not null)
            {

                var Hosts = new HashSet<Togaf.Technology.Host>();
                var Events = new HashSet<Togaf.Business.Event>();
                var Systems = new HashSet<Togaf.Application.System>();
                var Services = new HashSet<Togaf.Service>();
                var Processs = new HashSet<Togaf.Business.Process>();
                var Products = new HashSet<Togaf.Business.Product>();
                var Platforms = new HashSet<Togaf.Technology.Platform>();
                var Functions = new HashSet<Togaf.Business.Function>();
                var Capabilitys = new HashSet<Togaf.Business.Capability>();
                var Organizations = new HashSet<Togaf.Organization>();
                long count = 0;
                DateTime? when = null;

                if (space.Hosts is IDeltaIndex<Togaf.Technology.Host> deltaHost)
                {
                    var targets = deltaHost.Delta(new Togaf.Technology.Host(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Technology.Host> itemHost && itemHost.Parent is not null)
                            targets.UnionWith(itemHost.AllParents());
                    }
                    Hosts.UnionWith(targets);
                }
                if (space.Events is IDeltaIndex<Togaf.Business.Event> deltaEvent)
                {
                    var targets = deltaEvent.Delta(new Togaf.Business.Event(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Business.Event> itemEvent && itemEvent.Parent is not null)
                            targets.UnionWith(itemEvent.AllParents());
                    }
                    Events.UnionWith(targets);
                }
                if (space.Systems is IDeltaIndex<Togaf.Application.System> deltaSystem)
                {
                    var targets = deltaSystem.Delta(new Togaf.Application.System(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Application.System> itemSystem && itemSystem.Parent is not null)
                            targets.UnionWith(itemSystem.AllParents());
                    }
                    Systems.UnionWith(targets);
                }
                if (space.Services is IDeltaIndex<Togaf.Service> deltaService)
                {
                    var targets = deltaService.Delta(new Togaf.Service(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Service> itemService && itemService.Parent is not null)
                            targets.UnionWith(itemService.AllParents());
                    }
                    Services.UnionWith(targets);
                }
                if (space.Processs is IDeltaIndex<Togaf.Business.Process> deltaProcess)
                {
                    var targets = deltaProcess.Delta(new Togaf.Business.Process(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Business.Process> itemProcess && itemProcess.Parent is not null)
                            targets.UnionWith(itemProcess.AllParents());
                    }
                    Processs.UnionWith(targets);
                }
                if (space.Products is IDeltaIndex<Togaf.Business.Product> deltaProduct)
                {
                    var targets = deltaProduct.Delta(new Togaf.Business.Product(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Business.Product> itemProduct && itemProduct.Parent is not null)
                            targets.UnionWith(itemProduct.AllParents());
                    }
                    Products.UnionWith(targets);
                }
                if (space.Platforms is IDeltaIndex<Togaf.Technology.Platform> deltaPlatform)
                {
                    var targets = deltaPlatform.Delta(new Togaf.Technology.Platform(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Technology.Platform> itemPlatform && itemPlatform.Parent is not null)
                            targets.UnionWith(itemPlatform.AllParents());
                    }
                    Platforms.UnionWith(targets);
                }
                if (space.Functions is IDeltaIndex<Togaf.Business.Function> deltaFunction)
                {
                    var targets = deltaFunction.Delta(new Togaf.Business.Function(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Business.Function> itemFunction && itemFunction.Parent is not null)
                            targets.UnionWith(itemFunction.AllParents());
                    }
                    Functions.UnionWith(targets);
                }
                if (space.Capabilitys is IDeltaIndex<Togaf.Business.Capability> deltaCapability)
                {
                    var targets = deltaCapability.Delta(new Togaf.Business.Capability(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Business.Capability> itemCapability && itemCapability.Parent is not null)
                            targets.UnionWith(itemCapability.AllParents());
                    }
                    Capabilitys.UnionWith(targets);
                }
                if (space.Organizations is IDeltaIndex<Togaf.Organization> deltaOrganization)
                {
                    var targets = deltaOrganization.Delta(new Togaf.Organization(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Organization> itemOrganization && itemOrganization.Parent is not null)
                            targets.UnionWith(itemOrganization.AllParents());
                    }
                    Organizations.UnionWith(targets);
                }

                for (int c = 0; c < routes.Length; c++)
                {
                    var route = routes[c];
                    foreach (var obj in route.DeltaObject(delta.Value))
                    {

                        if (obj is Togaf.Technology.Host itemHost)
                        {
                            Hosts.Add(itemHost);
                            if (itemHost is ICubeHierarchy<Togaf.Technology.Host> hier)
                                Hosts.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Business.Event itemEvent)
                        {
                            Events.Add(itemEvent);
                            if (itemEvent is ICubeHierarchy<Togaf.Business.Event> hier)
                                Events.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Application.System itemSystem)
                        {
                            Systems.Add(itemSystem);
                            if (itemSystem is ICubeHierarchy<Togaf.Application.System> hier)
                                Systems.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Service itemService)
                        {
                            Services.Add(itemService);
                            if (itemService is ICubeHierarchy<Togaf.Service> hier)
                                Services.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Business.Process itemProcess)
                        {
                            Processs.Add(itemProcess);
                            if (itemProcess is ICubeHierarchy<Togaf.Business.Process> hier)
                                Processs.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Business.Product itemProduct)
                        {
                            Products.Add(itemProduct);
                            if (itemProduct is ICubeHierarchy<Togaf.Business.Product> hier)
                                Products.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Technology.Platform itemPlatform)
                        {
                            Platforms.Add(itemPlatform);
                            if (itemPlatform is ICubeHierarchy<Togaf.Technology.Platform> hier)
                                Platforms.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Business.Function itemFunction)
                        {
                            Functions.Add(itemFunction);
                            if (itemFunction is ICubeHierarchy<Togaf.Business.Function> hier)
                                Functions.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Business.Capability itemCapability)
                        {
                            Capabilitys.Add(itemCapability);
                            if (itemCapability is ICubeHierarchy<Togaf.Business.Capability> hier)
                                Capabilitys.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Organization itemOrganization)
                        {
                            Organizations.Add(itemOrganization);
                            if (itemOrganization is ICubeHierarchy<Togaf.Organization> hier)
                                Organizations.UnionWith(hier.AllParents());
                        }
                    }
                }
                var predicate = PredicateBuilder.False<Togaf.Financial.Cost_Cube>();

                if (Hosts.Count > 0) predicate = predicate.Or(c => c.Host != null && Hosts.Contains(c.Host));
                if (Events.Count > 0) predicate = predicate.Or(c => c.Event != null && Events.Contains(c.Event));
                if (Systems.Count > 0) predicate = predicate.Or(c => c.System != null && Systems.Contains(c.System));
                if (Services.Count > 0) predicate = predicate.Or(c => c.Service != null && Services.Contains(c.Service));
                if (Processs.Count > 0) predicate = predicate.Or(c => c.Process != null && Processs.Contains(c.Process));
                if (Products.Count > 0) predicate = predicate.Or(c => c.Product != null && Products.Contains(c.Product));
                if (Platforms.Count > 0) predicate = predicate.Or(c => c.Platform != null && Platforms.Contains(c.Platform));
                if (Functions.Count > 0) predicate = predicate.Or(c => c.Function != null && Functions.Contains(c.Function));
                if (Capabilitys.Count > 0) predicate = predicate.Or(c => c.Capability != null && Capabilitys.Contains(c.Capability));
                if (Organizations.Count > 0) predicate = predicate.Or(c => c.Organization != null && Organizations.Contains(c.Organization));

                var changes = space.Cost_Cubes.Where(predicate).ToArray();
                var tasks = new Task<Togaf.Financial.Cost_Cube?>[changes.Length];
                for (int c = 0; c < changes.Length; c++)
                {
                    var C = c;
                    tasks[C] = Task.Run(() => changes[C].Calculate() as Togaf.Financial.Cost_Cube);
                }
                for (int c = 0; c < tasks.Length; c++)
                {
                    var C = c;
                    var result = await tasks[c];
                    if (result != null)
                    {
                        await space.Cost_Cubes.BindAsync(result, false);
                        count++;
                    }
                }
                return (count, when);
            }
            else
                return await FullTogafFinancialCost_Cube(space, database);
        }
        public async Task<(long rows, DateTime? when)> DimensionTogafFinancialIncome_Cube(Togaf.TogafSpace space, Database database, DateTime? delta, Hiperspace.Meta.Route[] routes)
        {
            if (delta is not null)
            {

                var Hosts = new HashSet<Togaf.Technology.Host>();
                var Events = new HashSet<Togaf.Business.Event>();
                var Systems = new HashSet<Togaf.Application.System>();
                var Services = new HashSet<Togaf.Service>();
                var Processs = new HashSet<Togaf.Business.Process>();
                var Products = new HashSet<Togaf.Business.Product>();
                var Platforms = new HashSet<Togaf.Technology.Platform>();
                var Functions = new HashSet<Togaf.Business.Function>();
                var Capabilitys = new HashSet<Togaf.Business.Capability>();
                var Organizations = new HashSet<Togaf.Organization>();
                long count = 0;
                DateTime? when = null;

                if (space.Hosts is IDeltaIndex<Togaf.Technology.Host> deltaHost)
                {
                    var targets = deltaHost.Delta(new Togaf.Technology.Host(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Technology.Host> itemHost && itemHost.Parent is not null)
                            targets.UnionWith(itemHost.AllParents());
                    }
                    Hosts.UnionWith(targets);
                }
                if (space.Events is IDeltaIndex<Togaf.Business.Event> deltaEvent)
                {
                    var targets = deltaEvent.Delta(new Togaf.Business.Event(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Business.Event> itemEvent && itemEvent.Parent is not null)
                            targets.UnionWith(itemEvent.AllParents());
                    }
                    Events.UnionWith(targets);
                }
                if (space.Systems is IDeltaIndex<Togaf.Application.System> deltaSystem)
                {
                    var targets = deltaSystem.Delta(new Togaf.Application.System(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Application.System> itemSystem && itemSystem.Parent is not null)
                            targets.UnionWith(itemSystem.AllParents());
                    }
                    Systems.UnionWith(targets);
                }
                if (space.Services is IDeltaIndex<Togaf.Service> deltaService)
                {
                    var targets = deltaService.Delta(new Togaf.Service(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Service> itemService && itemService.Parent is not null)
                            targets.UnionWith(itemService.AllParents());
                    }
                    Services.UnionWith(targets);
                }
                if (space.Processs is IDeltaIndex<Togaf.Business.Process> deltaProcess)
                {
                    var targets = deltaProcess.Delta(new Togaf.Business.Process(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Business.Process> itemProcess && itemProcess.Parent is not null)
                            targets.UnionWith(itemProcess.AllParents());
                    }
                    Processs.UnionWith(targets);
                }
                if (space.Products is IDeltaIndex<Togaf.Business.Product> deltaProduct)
                {
                    var targets = deltaProduct.Delta(new Togaf.Business.Product(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Business.Product> itemProduct && itemProduct.Parent is not null)
                            targets.UnionWith(itemProduct.AllParents());
                    }
                    Products.UnionWith(targets);
                }
                if (space.Platforms is IDeltaIndex<Togaf.Technology.Platform> deltaPlatform)
                {
                    var targets = deltaPlatform.Delta(new Togaf.Technology.Platform(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Technology.Platform> itemPlatform && itemPlatform.Parent is not null)
                            targets.UnionWith(itemPlatform.AllParents());
                    }
                    Platforms.UnionWith(targets);
                }
                if (space.Functions is IDeltaIndex<Togaf.Business.Function> deltaFunction)
                {
                    var targets = deltaFunction.Delta(new Togaf.Business.Function(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Business.Function> itemFunction && itemFunction.Parent is not null)
                            targets.UnionWith(itemFunction.AllParents());
                    }
                    Functions.UnionWith(targets);
                }
                if (space.Capabilitys is IDeltaIndex<Togaf.Business.Capability> deltaCapability)
                {
                    var targets = deltaCapability.Delta(new Togaf.Business.Capability(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Business.Capability> itemCapability && itemCapability.Parent is not null)
                            targets.UnionWith(itemCapability.AllParents());
                    }
                    Capabilitys.UnionWith(targets);
                }
                if (space.Organizations is IDeltaIndex<Togaf.Organization> deltaOrganization)
                {
                    var targets = deltaOrganization.Delta(new Togaf.Organization(), delta.Value, false).ToHashSet();
                    foreach (var target in targets)
                    {
                        if (target is ICubeHierarchy<Togaf.Organization> itemOrganization && itemOrganization.Parent is not null)
                            targets.UnionWith(itemOrganization.AllParents());
                    }
                    Organizations.UnionWith(targets);
                }

                for (int c = 0; c < routes.Length; c++)
                {
                    var route = routes[c];
                    foreach (var obj in route.DeltaObject(delta.Value))
                    {

                        if (obj is Togaf.Technology.Host itemHost)
                        {
                            Hosts.Add(itemHost);
                            if (itemHost is ICubeHierarchy<Togaf.Technology.Host> hier)
                                Hosts.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Business.Event itemEvent)
                        {
                            Events.Add(itemEvent);
                            if (itemEvent is ICubeHierarchy<Togaf.Business.Event> hier)
                                Events.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Application.System itemSystem)
                        {
                            Systems.Add(itemSystem);
                            if (itemSystem is ICubeHierarchy<Togaf.Application.System> hier)
                                Systems.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Service itemService)
                        {
                            Services.Add(itemService);
                            if (itemService is ICubeHierarchy<Togaf.Service> hier)
                                Services.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Business.Process itemProcess)
                        {
                            Processs.Add(itemProcess);
                            if (itemProcess is ICubeHierarchy<Togaf.Business.Process> hier)
                                Processs.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Business.Product itemProduct)
                        {
                            Products.Add(itemProduct);
                            if (itemProduct is ICubeHierarchy<Togaf.Business.Product> hier)
                                Products.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Technology.Platform itemPlatform)
                        {
                            Platforms.Add(itemPlatform);
                            if (itemPlatform is ICubeHierarchy<Togaf.Technology.Platform> hier)
                                Platforms.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Business.Function itemFunction)
                        {
                            Functions.Add(itemFunction);
                            if (itemFunction is ICubeHierarchy<Togaf.Business.Function> hier)
                                Functions.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Business.Capability itemCapability)
                        {
                            Capabilitys.Add(itemCapability);
                            if (itemCapability is ICubeHierarchy<Togaf.Business.Capability> hier)
                                Capabilitys.UnionWith(hier.AllParents());
                        }
                        if (obj is Togaf.Organization itemOrganization)
                        {
                            Organizations.Add(itemOrganization);
                            if (itemOrganization is ICubeHierarchy<Togaf.Organization> hier)
                                Organizations.UnionWith(hier.AllParents());
                        }
                    }
                }
                var predicate = PredicateBuilder.False<Togaf.Financial.Income_Cube>();

                if (Hosts.Count > 0) predicate = predicate.Or(c => c.Host != null && Hosts.Contains(c.Host));
                if (Events.Count > 0) predicate = predicate.Or(c => c.Event != null && Events.Contains(c.Event));
                if (Systems.Count > 0) predicate = predicate.Or(c => c.System != null && Systems.Contains(c.System));
                if (Services.Count > 0) predicate = predicate.Or(c => c.Service != null && Services.Contains(c.Service));
                if (Processs.Count > 0) predicate = predicate.Or(c => c.Process != null && Processs.Contains(c.Process));
                if (Products.Count > 0) predicate = predicate.Or(c => c.Product != null && Products.Contains(c.Product));
                if (Platforms.Count > 0) predicate = predicate.Or(c => c.Platform != null && Platforms.Contains(c.Platform));
                if (Functions.Count > 0) predicate = predicate.Or(c => c.Function != null && Functions.Contains(c.Function));
                if (Capabilitys.Count > 0) predicate = predicate.Or(c => c.Capability != null && Capabilitys.Contains(c.Capability));
                if (Organizations.Count > 0) predicate = predicate.Or(c => c.Organization != null && Organizations.Contains(c.Organization));

                var changes = space.Income_Cubes.Where(predicate).ToArray();
                var tasks = new Task<Togaf.Financial.Income_Cube?>[changes.Length];
                for (int c = 0; c < changes.Length; c++)
                {
                    var C = c;
                    tasks[C] = Task.Run(() => changes[C].Calculate() as Togaf.Financial.Income_Cube);
                }
                for (int c = 0; c < tasks.Length; c++)
                {
                    var C = c;
                    var result = await tasks[c];
                    if (result != null)
                    {
                        await space.Income_Cubes.BindAsync(result, false);
                        count++;
                    }
                }
                return (count, when);
            }
            else
                return await FullTogafFinancialIncome_Cube(space, database);
        }
        #endregion

        #region queries

        private IQueryable<Togaf.Complexity_Fact> Query(IQueryable<Togaf.Complexity> source, string? label)
        {
            return from row in source
                   group row by new
                   {

                       Host = row.Host_Dimension,
                       Event = row.Event_Dimension,
                       System = row.System_Dimension,
                       Service = row.Service_Dimension,
                       Process = row.Process_Dimension,
                       Product = row.Product_Dimension,
                       Platform = row.Platform_Dimension,
                       Function = row.Function_Dimension,
                       Capability = row.Capability_Dimension,
                       Organization = row.Organization_Dimension,
                   } into g
                   select new Togaf.Complexity_Fact
                   {
                       ContextLabel = label,

                       Host = g.Key.Host,
                       Event = g.Key.Event,
                       System = g.Key.System,
                       Service = g.Key.Service,
                       Process = g.Key.Process,
                       Product = g.Key.Product,
                       Platform = g.Key.Platform,
                       Function = g.Key.Function,
                       Capability = g.Key.Capability,
                       Organization = g.Key.Organization,

                       E = g.Sum(x => x.E),
                       N = g.Sum(x => x.N),
                       P = g.Sum(x => x.P),
                       Facts = g.Count(),
                       AsAt = g.Max(x => x.AsAt)
                   };
        }
        private IQueryable<Togaf.Financial.Cost_Fact> Query(IQueryable<Togaf.Financial.Cost> source, string? label)
        {
            return from row in source
                   group row by new
                   {

                       Host = row.Host_Dimension,
                       Event = row.Event_Dimension,
                       System = row.System_Dimension,
                       Service = row.Service_Dimension,
                       Process = row.Process_Dimension,
                       Product = row.Product_Dimension,
                       Platform = row.Platform_Dimension,
                       Function = row.Function_Dimension,
                       Capability = row.Capability_Dimension,
                       Organization = row.Organization_Dimension,
                   } into g
                   select new Togaf.Financial.Cost_Fact
                   {
                       ContextLabel = label,

                       Host = g.Key.Host,
                       Event = g.Key.Event,
                       System = g.Key.System,
                       Service = g.Key.Service,
                       Process = g.Key.Process,
                       Product = g.Key.Product,
                       Platform = g.Key.Platform,
                       Function = g.Key.Function,
                       Capability = g.Key.Capability,
                       Organization = g.Key.Organization,

                       RevX = g.Sum(x => x.RevX),
                       CapX = g.Sum(x => x.CapX),
                       OpeX = g.Sum(x => x.OpeX),
                       Hours = g.Sum(x => x.Hours),
                       Facts = g.Count(),
                       AsAt = g.Max(x => x.AsAt)
                   };
        }
        private IQueryable<Togaf.Financial.Income_Fact> Query(IQueryable<Togaf.Financial.Income> source, string? label)
        {
            return from row in source
                   group row by new
                   {

                       Host = row.Host_Dimension,
                       Event = row.Event_Dimension,
                       System = row.System_Dimension,
                       Service = row.Service_Dimension,
                       Process = row.Process_Dimension,
                       Product = row.Product_Dimension,
                       Platform = row.Platform_Dimension,
                       Function = row.Function_Dimension,
                       Capability = row.Capability_Dimension,
                       Organization = row.Organization_Dimension,
                   } into g
                   select new Togaf.Financial.Income_Fact
                   {
                       ContextLabel = label,

                       Host = g.Key.Host,
                       Event = g.Key.Event,
                       System = g.Key.System,
                       Service = g.Key.Service,
                       Process = g.Key.Process,
                       Product = g.Key.Product,
                       Platform = g.Key.Platform,
                       Function = g.Key.Function,
                       Capability = g.Key.Capability,
                       Organization = g.Key.Organization,

                       RevX = g.Sum(x => x.RevX),
                       CapX = g.Sum(x => x.CapX),
                       OpeX = g.Sum(x => x.OpeX),
                       Hours = g.Sum(x => x.Hours),
                       Facts = g.Count(),
                       AsAt = g.Max(x => x.AsAt)
                   };
        }
        #endregion

        #region aggregation

        private static Togaf.Complexity_Fact Subtract(Togaf.Complexity_Fact current, Togaf.Complexity_Fact history)
        {
            ArgumentNullException.ThrowIfNull(current, nameof(current));
            ArgumentNullException.ThrowIfNull(history, nameof(history));

            return new Togaf.Complexity_Fact(current)
            {

                E = current.E - history.E,
                N = current.N - history.N,
                P = current.P - history.P,
                Facts = current.Facts - history.Facts,
                AsAt = current.AsAt > history.AsAt ? current.AsAt : history.AsAt,
            };
        }

        private static Togaf.Financial.Cost_Fact Subtract(Togaf.Financial.Cost_Fact current, Togaf.Financial.Cost_Fact history)
        {
            ArgumentNullException.ThrowIfNull(current, nameof(current));
            ArgumentNullException.ThrowIfNull(history, nameof(history));

            return new Togaf.Financial.Cost_Fact(current)
            {

                RevX = current.RevX - history.RevX,
                CapX = current.CapX - history.CapX,
                OpeX = current.OpeX - history.OpeX,
                Hours = current.Hours - history.Hours,
                Facts = current.Facts - history.Facts,
                AsAt = current.AsAt > history.AsAt ? current.AsAt : history.AsAt,
            };
        }

        private static Togaf.Financial.Income_Fact Subtract(Togaf.Financial.Income_Fact current, Togaf.Financial.Income_Fact history)
        {
            ArgumentNullException.ThrowIfNull(current, nameof(current));
            ArgumentNullException.ThrowIfNull(history, nameof(history));

            return new Togaf.Financial.Income_Fact(current)
            {

                RevX = current.RevX - history.RevX,
                CapX = current.CapX - history.CapX,
                OpeX = current.OpeX - history.OpeX,
                Hours = current.Hours - history.Hours,
                Facts = current.Facts - history.Facts,
                AsAt = current.AsAt > history.AsAt ? current.AsAt : history.AsAt,
            };
        }


        private static Togaf.Complexity_Fact Add(Togaf.Complexity_Fact current, Togaf.Complexity_Fact delta)
        {
            ArgumentNullException.ThrowIfNull(current, nameof(current));
            ArgumentNullException.ThrowIfNull(delta, nameof(delta));

            return new Togaf.Complexity_Fact(current)
            {

                E = current.E + delta.E,
                N = current.N + delta.N,
                P = current.P + delta.P,
                Facts = current.Facts + delta.Facts,
                AsAt = current.AsAt > delta.AsAt ? current.AsAt : delta.AsAt
            };
        }
        private static Togaf.Complexity_Cube Add(Togaf.Complexity_Cube current, Togaf.Complexity_Fact delta)
        {
            ArgumentNullException.ThrowIfNull(current, nameof(current));
            ArgumentNullException.ThrowIfNull(delta, nameof(delta));

            return new Togaf.Complexity_Cube(current)
            {

                E = current.E + delta.E,
                N = current.N + delta.N,
                P = current.P + delta.P,
                Facts = current.Facts + delta.Facts,
                AsAt = current.AsAt > delta.AsAt ? current.AsAt : delta.AsAt
            };
        }
        private static Togaf.Financial.Cost_Fact Add(Togaf.Financial.Cost_Fact current, Togaf.Financial.Cost_Fact delta)
        {
            ArgumentNullException.ThrowIfNull(current, nameof(current));
            ArgumentNullException.ThrowIfNull(delta, nameof(delta));

            return new Togaf.Financial.Cost_Fact(current)
            {

                RevX = current.RevX + delta.RevX,
                CapX = current.CapX + delta.CapX,
                OpeX = current.OpeX + delta.OpeX,
                Hours = current.Hours + delta.Hours,
                Facts = current.Facts + delta.Facts,
                AsAt = current.AsAt > delta.AsAt ? current.AsAt : delta.AsAt
            };
        }
        private static Togaf.Financial.Cost_Cube Add(Togaf.Financial.Cost_Cube current, Togaf.Financial.Cost_Fact delta)
        {
            ArgumentNullException.ThrowIfNull(current, nameof(current));
            ArgumentNullException.ThrowIfNull(delta, nameof(delta));

            return new Togaf.Financial.Cost_Cube(current)
            {

                RevX = current.RevX + delta.RevX,
                CapX = current.CapX + delta.CapX,
                OpeX = current.OpeX + delta.OpeX,
                Hours = current.Hours + delta.Hours,
                Facts = current.Facts + delta.Facts,
                AsAt = current.AsAt > delta.AsAt ? current.AsAt : delta.AsAt
            };
        }
        private static Togaf.Financial.Income_Fact Add(Togaf.Financial.Income_Fact current, Togaf.Financial.Income_Fact delta)
        {
            ArgumentNullException.ThrowIfNull(current, nameof(current));
            ArgumentNullException.ThrowIfNull(delta, nameof(delta));

            return new Togaf.Financial.Income_Fact(current)
            {

                RevX = current.RevX + delta.RevX,
                CapX = current.CapX + delta.CapX,
                OpeX = current.OpeX + delta.OpeX,
                Hours = current.Hours + delta.Hours,
                Facts = current.Facts + delta.Facts,
                AsAt = current.AsAt > delta.AsAt ? current.AsAt : delta.AsAt
            };
        }
        private static Togaf.Financial.Income_Cube Add(Togaf.Financial.Income_Cube current, Togaf.Financial.Income_Fact delta)
        {
            ArgumentNullException.ThrowIfNull(current, nameof(current));
            ArgumentNullException.ThrowIfNull(delta, nameof(delta));

            return new Togaf.Financial.Income_Cube(current)
            {

                RevX = current.RevX + delta.RevX,
                CapX = current.CapX + delta.CapX,
                OpeX = current.OpeX + delta.OpeX,
                Hours = current.Hours + delta.Hours,
                Facts = current.Facts + delta.Facts,
                AsAt = current.AsAt > delta.AsAt ? current.AsAt : delta.AsAt
            };
        }
        #endregion

        #region helpers

        private static string CubeSlice(params ICubeDimension?[]? dimensions)
        {
            if (dimensions is null || dimensions.Length == 0) return string.Empty;
            var slices = new List<int>();
            for (int i = 0; i < dimensions.Length; i++)
            {
                if (dimensions[i] is null)
                    continue;
                else
                    slices.Add(int.Parse(dimensions[i]?.CubeSlice ?? "0"));
            }
            slices.Sort();
            return String.Join(',', slices);
        }
        private static DateTime? DeltaFrom(Database database, CubeType cubeType)
        {
            var full = database.Cube.SetSpace?.GetLast(new Cube { owner = database, CubeType = CubeType.Full })?.When;
            var dependency = database.Cube.SetSpace?.GetLast(new Cube { owner = database, CubeType = cubeType })?.When;

            if (full is not null && dependency is not null)
                return full < dependency ? dependency : full;
            else
                return full;

        }

        private async Task<(long rows, DateTime? when)> DeltaProcess(SubSpace subSpace, Database database, DateTime delta, IQueryable<Togaf.Complexity> source, CubeType cubeType)
        {
            var space = subSpace as Togaf.TogafSpace;
            if (space is null) throw new ArgumentException($"{nameof(subSpace)} is not an Togaf.Complexity_Cube");
            var start = DateTime.Now;
            long rowCount = 0;
            DateTime? now = null;

            HashSet<Togaf.Complexity_Fact>? currentCube = null;
            HashSet<Togaf.Complexity_Fact>? historyCube = null;
            var deltaCubes = new HashSet<Togaf.Complexity_Fact>();
            var updateCubes = new List<Togaf.Complexity_Cube>();

            var parameters = new SubSpaceParameters
            {
                Space = space,
                ContextLabel = space.ContextLabel,
            };

            using (var session = new Togaf.TogafSpace(parameters))
            {
                using (var snap = new Togaf.TogafSpace(parameters.WithAsAt(start)))
                {
                    var current = source.ToArray();

                    using (var historySnap = new Togaf.TogafSpace(parameters.WithAsAt(delta)))
                    {
                        var history =
                            (from row in current
                             let hist = historySnap.Complexitys.Get(row)
                             where hist is not null
                             select hist
                            ).ToArray();

                        historyCube = Query(history.AsQueryable(), space.ContextLabel).ToHashSet();
                        currentCube = Query(current.AsQueryable(), space.ContextLabel).ToHashSet();
                    }
                }

                foreach (var change in currentCube)
                {
                    // had a value
                    if (historyCube.TryGetValue(change, out var history))
                    {
                        var deltaFact = Subtract(change, history);
                        deltaCubes.Add(deltaFact);
                        var current = await session.Complexity_Facts.GetAsync(change);
                        if (current is not null)
                        {
                            current = Add(current, deltaFact);
                            await session.Complexity_Facts.BindAsync(current, true);
                            rowCount++;
                            if (change is not null && change.AsAt > now)
                                now = change.AsAt;
                        }
                    }
                    // new 
                    else
                    {
                        var current = await session.Complexity_Facts.GetAsync(change);
                        if (current is not null)
                        {
                            current = Add(current, change);
                        }
                        deltaCubes.Add(change);
                    }
                }

                foreach (var history in historyCube)
                {
                    // totals removed
                    if (!currentCube.Contains(history))
                    {
                        var deltaFact = Subtract(new Togaf.Complexity_Fact(), history);
                        deltaCubes.Add(deltaFact);
                        var current = await session.Complexity_Facts.GetAsync(history);
                        if (current is not null)
                        {
                            current = new Togaf.Complexity_Fact(current)
                            {
                                Deleted = true,
                            };
                            await session.Complexity_Facts.BindAsync(current);
                        }
                    }
                }

                await foreach (var row in session.Complexity_Cubes.FindAsync(new Togaf.Complexity_Cube()))
                {
                    foreach (var change in deltaCubes)
                    {
                        var apply = false;

                        if (!apply && change.Host is not null && row.Host == change.Host) apply = true;
                        if (!apply && change.Host is ICubeHierarchy<Togaf.Technology.Host> hierHost)
                            foreach (var parent in hierHost.AllParents())
                                if (row.Host == parent) apply = true;
                        if (!apply && change.Event is not null && row.Event == change.Event) apply = true;
                        if (!apply && change.Event is ICubeHierarchy<Togaf.Business.Event> hierEvent)
                            foreach (var parent in hierEvent.AllParents())
                                if (row.Event == parent) apply = true;
                        if (!apply && change.System is not null && row.System == change.System) apply = true;
                        if (!apply && change.System is ICubeHierarchy<Togaf.Application.System> hierSystem)
                            foreach (var parent in hierSystem.AllParents())
                                if (row.System == parent) apply = true;
                        if (!apply && change.Service is not null && row.Service == change.Service) apply = true;
                        if (!apply && change.Service is ICubeHierarchy<Togaf.Service> hierService)
                            foreach (var parent in hierService.AllParents())
                                if (row.Service == parent) apply = true;
                        if (!apply && change.Process is not null && row.Process == change.Process) apply = true;
                        if (!apply && change.Process is ICubeHierarchy<Togaf.Business.Process> hierProcess)
                            foreach (var parent in hierProcess.AllParents())
                                if (row.Process == parent) apply = true;
                        if (!apply && change.Product is not null && row.Product == change.Product) apply = true;
                        if (!apply && change.Product is ICubeHierarchy<Togaf.Business.Product> hierProduct)
                            foreach (var parent in hierProduct.AllParents())
                                if (row.Product == parent) apply = true;
                        if (!apply && change.Platform is not null && row.Platform == change.Platform) apply = true;
                        if (!apply && change.Platform is ICubeHierarchy<Togaf.Technology.Platform> hierPlatform)
                            foreach (var parent in hierPlatform.AllParents())
                                if (row.Platform == parent) apply = true;
                        if (!apply && change.Function is not null && row.Function == change.Function) apply = true;
                        if (!apply && change.Function is ICubeHierarchy<Togaf.Business.Function> hierFunction)
                            foreach (var parent in hierFunction.AllParents())
                                if (row.Function == parent) apply = true;
                        if (!apply && change.Capability is not null && row.Capability == change.Capability) apply = true;
                        if (!apply && change.Capability is ICubeHierarchy<Togaf.Business.Capability> hierCapability)
                            foreach (var parent in hierCapability.AllParents())
                                if (row.Capability == parent) apply = true;
                        if (!apply && change.Organization is not null && row.Organization == change.Organization) apply = true;
                        if (!apply && change.Organization is ICubeHierarchy<Togaf.Organization> hierOrganization)
                            foreach (var parent in hierOrganization.AllParents())
                                if (row.Organization == parent) apply = true;

                        if (apply)
                        {
                            var update = new Togaf.Complexity_Cube(row);
                            Add(update, change);
                            updateCubes.Add(update);
                            rowCount++;
                        }
                    }
                }
                var tasks = new List<Task<Result<Togaf.Complexity_Cube>>>();
                foreach (var update in updateCubes)
                    tasks.Add(session.Complexity_Cubes.BindAsync(update));
                Task.WaitAll(tasks);

                return (rowCount, now);
            }
        }
        private async Task<(long rows, DateTime? when)> DeltaProcess(SubSpace subSpace, Database database, DateTime delta, IQueryable<Togaf.Financial.Cost> source, CubeType cubeType)
        {
            var space = subSpace as Togaf.TogafSpace;
            if (space is null) throw new ArgumentException($"{nameof(subSpace)} is not an Togaf.Financial.Cost_Cube");
            var start = DateTime.Now;
            long rowCount = 0;
            DateTime? now = null;

            HashSet<Togaf.Financial.Cost_Fact>? currentCube = null;
            HashSet<Togaf.Financial.Cost_Fact>? historyCube = null;
            var deltaCubes = new HashSet<Togaf.Financial.Cost_Fact>();
            var updateCubes = new List<Togaf.Financial.Cost_Cube>();

            var parameters = new SubSpaceParameters
            {
                Space = space,
                ContextLabel = space.ContextLabel,
            };

            using (var session = new Togaf.TogafSpace(parameters))
            {
                using (var snap = new Togaf.TogafSpace(parameters.WithAsAt(start)))
                {
                    var current = source.ToArray();

                    using (var historySnap = new Togaf.TogafSpace(parameters.WithAsAt(delta)))
                    {
                        var history =
                            (from row in current
                             let hist = historySnap.Costs.Get(row)
                             where hist is not null
                             select hist
                            ).ToArray();

                        historyCube = Query(history.AsQueryable(), space.ContextLabel).ToHashSet();
                        currentCube = Query(current.AsQueryable(), space.ContextLabel).ToHashSet();
                    }
                }

                foreach (var change in currentCube)
                {
                    // had a value
                    if (historyCube.TryGetValue(change, out var history))
                    {
                        var deltaFact = Subtract(change, history);
                        deltaCubes.Add(deltaFact);
                        var current = await session.Cost_Facts.GetAsync(change);
                        if (current is not null)
                        {
                            current = Add(current, deltaFact);
                            await session.Cost_Facts.BindAsync(current, true);
                            rowCount++;
                            if (change is not null && change.AsAt > now)
                                now = change.AsAt;
                        }
                    }
                    // new 
                    else
                    {
                        var current = await session.Cost_Facts.GetAsync(change);
                        if (current is not null)
                        {
                            current = Add(current, change);
                        }
                        deltaCubes.Add(change);
                    }
                }

                foreach (var history in historyCube)
                {
                    // totals removed
                    if (!currentCube.Contains(history))
                    {
                        var deltaFact = Subtract(new Togaf.Financial.Cost_Fact(), history);
                        deltaCubes.Add(deltaFact);
                        var current = await session.Cost_Facts.GetAsync(history);
                        if (current is not null)
                        {
                            current = new Togaf.Financial.Cost_Fact(current)
                            {
                                Deleted = true,
                            };
                            await session.Cost_Facts.BindAsync(current);
                        }
                    }
                }

                await foreach (var row in session.Cost_Cubes.FindAsync(new Togaf.Financial.Cost_Cube()))
                {
                    foreach (var change in deltaCubes)
                    {
                        var apply = false;

                        if (!apply && change.Host is not null && row.Host == change.Host) apply = true;
                        if (!apply && change.Host is ICubeHierarchy<Togaf.Technology.Host> hierHost)
                            foreach (var parent in hierHost.AllParents())
                                if (row.Host == parent) apply = true;
                        if (!apply && change.Event is not null && row.Event == change.Event) apply = true;
                        if (!apply && change.Event is ICubeHierarchy<Togaf.Business.Event> hierEvent)
                            foreach (var parent in hierEvent.AllParents())
                                if (row.Event == parent) apply = true;
                        if (!apply && change.System is not null && row.System == change.System) apply = true;
                        if (!apply && change.System is ICubeHierarchy<Togaf.Application.System> hierSystem)
                            foreach (var parent in hierSystem.AllParents())
                                if (row.System == parent) apply = true;
                        if (!apply && change.Service is not null && row.Service == change.Service) apply = true;
                        if (!apply && change.Service is ICubeHierarchy<Togaf.Service> hierService)
                            foreach (var parent in hierService.AllParents())
                                if (row.Service == parent) apply = true;
                        if (!apply && change.Process is not null && row.Process == change.Process) apply = true;
                        if (!apply && change.Process is ICubeHierarchy<Togaf.Business.Process> hierProcess)
                            foreach (var parent in hierProcess.AllParents())
                                if (row.Process == parent) apply = true;
                        if (!apply && change.Product is not null && row.Product == change.Product) apply = true;
                        if (!apply && change.Product is ICubeHierarchy<Togaf.Business.Product> hierProduct)
                            foreach (var parent in hierProduct.AllParents())
                                if (row.Product == parent) apply = true;
                        if (!apply && change.Platform is not null && row.Platform == change.Platform) apply = true;
                        if (!apply && change.Platform is ICubeHierarchy<Togaf.Technology.Platform> hierPlatform)
                            foreach (var parent in hierPlatform.AllParents())
                                if (row.Platform == parent) apply = true;
                        if (!apply && change.Function is not null && row.Function == change.Function) apply = true;
                        if (!apply && change.Function is ICubeHierarchy<Togaf.Business.Function> hierFunction)
                            foreach (var parent in hierFunction.AllParents())
                                if (row.Function == parent) apply = true;
                        if (!apply && change.Capability is not null && row.Capability == change.Capability) apply = true;
                        if (!apply && change.Capability is ICubeHierarchy<Togaf.Business.Capability> hierCapability)
                            foreach (var parent in hierCapability.AllParents())
                                if (row.Capability == parent) apply = true;
                        if (!apply && change.Organization is not null && row.Organization == change.Organization) apply = true;
                        if (!apply && change.Organization is ICubeHierarchy<Togaf.Organization> hierOrganization)
                            foreach (var parent in hierOrganization.AllParents())
                                if (row.Organization == parent) apply = true;

                        if (apply)
                        {
                            var update = new Togaf.Financial.Cost_Cube(row);
                            Add(update, change);
                            updateCubes.Add(update);
                            rowCount++;
                        }
                    }
                }
                var tasks = new List<Task<Result<Togaf.Financial.Cost_Cube>>>();
                foreach (var update in updateCubes)
                    tasks.Add(session.Cost_Cubes.BindAsync(update));
                Task.WaitAll(tasks);

                return (rowCount, now);
            }
        }
        private async Task<(long rows, DateTime? when)> DeltaProcess(SubSpace subSpace, Database database, DateTime delta, IQueryable<Togaf.Financial.Income> source, CubeType cubeType)
        {
            var space = subSpace as Togaf.TogafSpace;
            if (space is null) throw new ArgumentException($"{nameof(subSpace)} is not an Togaf.Financial.Income_Cube");
            var start = DateTime.Now;
            long rowCount = 0;
            DateTime? now = null;

            HashSet<Togaf.Financial.Income_Fact>? currentCube = null;
            HashSet<Togaf.Financial.Income_Fact>? historyCube = null;
            var deltaCubes = new HashSet<Togaf.Financial.Income_Fact>();
            var updateCubes = new List<Togaf.Financial.Income_Cube>();

            var parameters = new SubSpaceParameters
            {
                Space = space,
                ContextLabel = space.ContextLabel,
            };

            using (var session = new Togaf.TogafSpace(parameters))
            {
                using (var snap = new Togaf.TogafSpace(parameters.WithAsAt(start)))
                {
                    var current = source.ToArray();

                    using (var historySnap = new Togaf.TogafSpace(parameters.WithAsAt(delta)))
                    {
                        var history =
                            (from row in current
                             let hist = historySnap.Incomes.Get(row)
                             where hist is not null
                             select hist
                            ).ToArray();

                        historyCube = Query(history.AsQueryable(), space.ContextLabel).ToHashSet();
                        currentCube = Query(current.AsQueryable(), space.ContextLabel).ToHashSet();
                    }
                }

                foreach (var change in currentCube)
                {
                    // had a value
                    if (historyCube.TryGetValue(change, out var history))
                    {
                        var deltaFact = Subtract(change, history);
                        deltaCubes.Add(deltaFact);
                        var current = await session.Income_Facts.GetAsync(change);
                        if (current is not null)
                        {
                            current = Add(current, deltaFact);
                            await session.Income_Facts.BindAsync(current, true);
                            rowCount++;
                            if (change is not null && change.AsAt > now)
                                now = change.AsAt;
                        }
                    }
                    // new 
                    else
                    {
                        var current = await session.Income_Facts.GetAsync(change);
                        if (current is not null)
                        {
                            current = Add(current, change);
                        }
                        deltaCubes.Add(change);
                    }
                }

                foreach (var history in historyCube)
                {
                    // totals removed
                    if (!currentCube.Contains(history))
                    {
                        var deltaFact = Subtract(new Togaf.Financial.Income_Fact(), history);
                        deltaCubes.Add(deltaFact);
                        var current = await session.Income_Facts.GetAsync(history);
                        if (current is not null)
                        {
                            current = new Togaf.Financial.Income_Fact(current)
                            {
                                Deleted = true,
                            };
                            await session.Income_Facts.BindAsync(current);
                        }
                    }
                }

                await foreach (var row in session.Income_Cubes.FindAsync(new Togaf.Financial.Income_Cube()))
                {
                    foreach (var change in deltaCubes)
                    {
                        var apply = false;

                        if (!apply && change.Host is not null && row.Host == change.Host) apply = true;
                        if (!apply && change.Host is ICubeHierarchy<Togaf.Technology.Host> hierHost)
                            foreach (var parent in hierHost.AllParents())
                                if (row.Host == parent) apply = true;
                        if (!apply && change.Event is not null && row.Event == change.Event) apply = true;
                        if (!apply && change.Event is ICubeHierarchy<Togaf.Business.Event> hierEvent)
                            foreach (var parent in hierEvent.AllParents())
                                if (row.Event == parent) apply = true;
                        if (!apply && change.System is not null && row.System == change.System) apply = true;
                        if (!apply && change.System is ICubeHierarchy<Togaf.Application.System> hierSystem)
                            foreach (var parent in hierSystem.AllParents())
                                if (row.System == parent) apply = true;
                        if (!apply && change.Service is not null && row.Service == change.Service) apply = true;
                        if (!apply && change.Service is ICubeHierarchy<Togaf.Service> hierService)
                            foreach (var parent in hierService.AllParents())
                                if (row.Service == parent) apply = true;
                        if (!apply && change.Process is not null && row.Process == change.Process) apply = true;
                        if (!apply && change.Process is ICubeHierarchy<Togaf.Business.Process> hierProcess)
                            foreach (var parent in hierProcess.AllParents())
                                if (row.Process == parent) apply = true;
                        if (!apply && change.Product is not null && row.Product == change.Product) apply = true;
                        if (!apply && change.Product is ICubeHierarchy<Togaf.Business.Product> hierProduct)
                            foreach (var parent in hierProduct.AllParents())
                                if (row.Product == parent) apply = true;
                        if (!apply && change.Platform is not null && row.Platform == change.Platform) apply = true;
                        if (!apply && change.Platform is ICubeHierarchy<Togaf.Technology.Platform> hierPlatform)
                            foreach (var parent in hierPlatform.AllParents())
                                if (row.Platform == parent) apply = true;
                        if (!apply && change.Function is not null && row.Function == change.Function) apply = true;
                        if (!apply && change.Function is ICubeHierarchy<Togaf.Business.Function> hierFunction)
                            foreach (var parent in hierFunction.AllParents())
                                if (row.Function == parent) apply = true;
                        if (!apply && change.Capability is not null && row.Capability == change.Capability) apply = true;
                        if (!apply && change.Capability is ICubeHierarchy<Togaf.Business.Capability> hierCapability)
                            foreach (var parent in hierCapability.AllParents())
                                if (row.Capability == parent) apply = true;
                        if (!apply && change.Organization is not null && row.Organization == change.Organization) apply = true;
                        if (!apply && change.Organization is ICubeHierarchy<Togaf.Organization> hierOrganization)
                            foreach (var parent in hierOrganization.AllParents())
                                if (row.Organization == parent) apply = true;

                        if (apply)
                        {
                            var update = new Togaf.Financial.Income_Cube(row);
                            update = Add(update, change);
                            updateCubes.Add(update);
                            rowCount++;
                        }
                    }
                }
                var tasks = new List<Task<Result<Togaf.Financial.Income_Cube>>>();
                foreach (var update in updateCubes)
                    tasks.Add(session.Income_Cubes.BindAsync(update));
                Task.WaitAll(tasks);

                return (rowCount, now);
            }
        }
        #endregion
    }
}