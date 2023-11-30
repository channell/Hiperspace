# Sparx Model

Sparks enterprise architect is the leading architecture modeling tool in the world. There are many reasons why it leads, but one of them (my reason) is that it uses a relational database to store the model. Within the enterprise architect tool, the database is queried directly to provide searches, for document generation and HTML views. More information about sparks can be at found [Sparx Systems]( https:[JsonIgnore]parxsystems.com/).
For complex reporting scenarios, the database can be queried directly, In this example, we are using it to create a graph view of a model to track changes over time.
Note and edge are special views that are common to all Hiperspace models. Views in Hiperspace are a union of all {entity, segment, aspect} that are equivalent to each view type.

## Nodes

In this example node is a union all view of {Sparx.EA.Resource, Sparx.EA.Diagram, Sparx.EA.Attribute, Sparx.EA.Package, Sparx.EA.Element, Sparx.EA.ElementRequirements, Sparx.EA.ElementOperations}. In this example edge is a union all view of {Sparx.EA.DiagramObject, Sparx.EA.Connector, Sparx.EA.Attribute, Sparx.EA.Package, Sparx.EA.Element, Sparx.EA.ElementRequirements, Sparx.EA.ElementResources, Sparx.EA.ElementOperations}
`Node` and `Edge` allow the model to be treated as a graph database without duplicating the data. 

## Domain specific database

The Assembly creates a domain specific database that provides access to the data Using familiar LINQ expressions or Find/Get operations on the `SparxSpace` sets. Searches within the model use a simple rule-based optimizer that uses the first available index that matches the template object.
As an example, addition (partial class) properties are provided for each object So the model can be used with entity framework core for interaction with a database.
All hiperspace objects are immutable, but versions provide the capability to update the ‘latest view’ of the data.  Each version of object provides a `GetVersions` method that returns a list of all the history. By opening the Subspace with `AsAt` parameter the view of the model at that time can be viewed.

# Example of a complex document

An entire architecture model can be viewed as a document, a catalog of documents, but unlike a document database data is not duplicated and updates only apply to the parts that have changed.

# navigation

The entire model can be traversed as if it was in memory using key references, but when an object escapes the context of a subspace, it becomes a regular object that can be JSON serialized without recursively pulling references that have not already been brought into memory.

# Storage

The [Hiperspace.Rocks]( https://www.nuget.org/packages/Hiperspace.Rocks) can be used to durably store the content of the Hiperspace to SSD or CXL memory, but any key/value store can be used with a simple Hiperspace driver

![Rosyln generated code] (/doc/Screenshots/Rosyln.png)