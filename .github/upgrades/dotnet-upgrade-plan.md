# .NET 10.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that an .NET 10.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 10.0 upgrade.

3. Upgrade Plan\Plan\Plan.csproj
4. Upgrade Hiperspace.Sparx\Hiperspace.Sparx.csproj
5. Upgrade Account\Account.csproj
6. Upgrade Hiperspace.RBAC\Hiperspace.RBAC.csproj
7. Upgrade Location\Location.csproj
8. Upgrade util\util.fsproj
9. Upgrade SocialMedia\SocialMedia.csproj
10. Upgrade Cube\Cube.csproj
11. Upgrade ..\\..\\HiperspaceHost\\Hiperspace\\Hiperspace.Remote\\Hiperspace.Remote.csproj
12. Upgrade Invoice\Invoice.csproj
13. Upgrade CousinProblem\CousinProblem.csproj
14. Upgrade QL\QL.csproj
15. Upgrade Account.Test\Account.Test.fsproj
16. Upgrade SQLServerGraphSample\SQLServerGraphSample.csproj
17. Upgrade Hiperspace.RBAC.Test\Hiperspace.RBAC.Test.fsproj
18. Upgrade Plan\Plan.Test\Plan.Test.fsproj
19. Upgrade Location.Test\Location.Test.fsproj
20. Upgrade TOGAF\TOGAF.csproj
21. Upgrade benchmark\benchmark.fsproj

## Settings

### Excluded projects

Table below contains projects that do belong to the dependency graph for selected projects and should not be included in the upgrade.

| Project name                                   | Description                 |
|:-----------------------------------------------|:---------------------------:|

(No projects are excluded)

### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                                | Current Version     | New Version | Description                                   |
|:--------------------------------------------|:-------------------:|:-----------:|:----------------------------------------------|
| Microsoft.EntityFrameworkCore               |   9.0.10            |  10.0.0     | Recommended update for .NET 10 and compatibility |
| Microsoft.EntityFrameworkCore.Relational    |   9.0.10            |  10.0.0     | Recommended update for .NET 10 and compatibility |
| Microsoft.EntityFrameworkCore.SqlServer     |   9.0.9             |  10.0.0     | Recommended update for .NET 10 and compatibility |
| System.CodeDom                               |   9.0.10            |  10.0.0     | Replacement package available for .NET 10      |
| System.Text.Json                             |   9.0.10            |  10.0.0     | Replacement package available for .NET 10      |

### Project upgrade details
This section contains details about each project upgrade and modifications that need to be done in the project.

#### Plan\Plan\Plan.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

NuGet packages changes:
  - `System.Text.Json` should be updated from `9.0.10` to `10.0.0`

Other changes:
  - Verify code that depends on System.Text.Json for any API surface changes.

#### Hiperspace.Sparx\Hiperspace.Sparx.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

NuGet packages changes:
  - `Microsoft.EntityFrameworkCore` should be updated from `9.0.10` to `10.0.0`
  - `Microsoft.EntityFrameworkCore.Relational` should be updated from `9.0.10` to `10.0.0`
  - `System.Text.Json` should be updated from `9.0.10` to `10.0.0`

Other changes:
  - Run EF Core API compatibility checks after package updates.

#### Account\Account.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

Other changes:
  - No NuGet package changes identified by analysis; verify transitive dependencies.

#### Hiperspace.RBAC\Hiperspace.RBAC.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

Other changes:
  - No NuGet package changes identified by analysis; run build and tests.

#### Location\Location.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

Other changes:
  - No NuGet package changes identified by analysis; run build and tests.

#### util\util.fsproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

NuGet packages changes:
  - `Microsoft.EntityFrameworkCore.SqlServer` should be updated from `9.0.9` to `10.0.0`

Other changes:
  - Verify EF SQL Server usage and connection APIs.

#### SocialMedia\SocialMedia.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

Other changes:
  - No NuGet package changes identified by analysis; run build and tests.

#### Cube\Cube.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

NuGet packages changes:
  - `System.CodeDom` should be updated from `9.0.10` to `10.0.0`
  - `System.Text.Json` should be updated from `9.0.10` to `10.0.0`

Other changes:
  - Verify any code generation or CodeDOM usages for API changes.

#### ..\\..\\HiperspaceHost\\Hiperspace\\Hiperspace.Remote\\Hiperspace.Remote.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

Other changes:
  - This project is outside the examples solution directory; ensure repository boundaries and references are correct.

#### Invoice\Invoice.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

Other changes:
  - No NuGet package changes identified by analysis; run build and tests.

#### CousinProblem\CousinProblem.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

NuGet packages changes:
  - `System.CodeDom` should be updated from `9.0.10` to `10.0.0`
  - `System.Text.Json` should be updated from `9.0.10` to `10.0.0`

Other changes:
  - Verify serialization and CodeDOM usage.

#### QL\QL.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

Other changes:
  - No NuGet package changes identified by analysis; run build and tests.

#### Account.Test\Account.Test.fsproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

Other changes:
  - Run tests after upgrade.

#### SQLServerGraphSample\SQLServerGraphSample.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

Other changes:
  - Run build and tests after upgrade.

#### Hiperspace.RBAC.Test\Hiperspace.RBAC.Test.fsproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

Other changes:
  - Run tests after upgrade.

#### Plan\Plan.Test\Plan.Test.fsproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

NuGet packages changes:
  - `System.Text.Json` should be updated from `9.0.10` to `10.0.0`

Other changes:
  - Run tests after upgrade.

#### Location.Test\Location.Test.fsproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

NuGet packages changes:
  - `System.Text.Json` should be updated from `9.0.10` to `10.0.0`

Other changes:
  - Run tests after upgrade.

#### TOGAF\TOGAF.csproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

Other changes:
  - Run build and tests after upgrade.

#### benchmark\benchmark.fsproj modifications

Project properties changes:
  - Target framework should be changed from `net9.0` to `net10.0`

Other changes:
  - Run build and tests after upgrade.
