# Hiperspace
Hiperspace is an Object technology that uses a key-addressable store to expand an application data-model beyond the limits of memory 
that can be directly referenced in main memory. 

Elements are not duplicated or changed to match database shapes.  
Elements are serialized directly using `Protocol Buffers` to and from key/value structure for storage in memory stores including CXL
expanded and pooled memory, shared cache, local SSD or key-value durable databases.  
Elements that are not currently being used are released from main memory, and transparently (and quickly) reloaded when referenced. 
Memory stores allow petabytes of data to be addressed.

All Hiperspace objects are immutable, but versioning provides the experience of mutability without the cache-coherency that would require constant server lookup.

## Hiperspace vs Relational Database
// * Summary *

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
Intel Core i9-9980HK CPU 2.40GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

| Method      | Mean            | Error           | StdDev          |
|------------ |----------------:|----------------:|----------------:|
| Load        | 12,262,692.6 us |   715,060.23 us | 2,005,105.54 us |
| CountRocks  | 17,353,641.0 us |    341,246.2 us |  665,574,600 us |
| CountSQL    | 84,193,776.9 us | 1,636,317.08 us | 2,184,436.31 us |
| UpdateRocks |        491.2 us |         7.41 us |         6.57 us |
| UpdateSQL   |      4,113.3 us |        71.36 us |        63.26 us |
| JSONRocks   | 59,447,597.0 us |    879,269.1 us |    779,449.2 us |
| JSONSQL     | 91,045,615.6 us | 1,815,004.73 us | 2,017,372.94 us |

Source Sparx EA database consisted of 623248 observations (1319 packages, 42433 classes, 208599 attributes, 370897 methods) gathered from reverse engineering of .NET framework and Java JRE.

Stored in local a 968 MB SQL/Server 2019 database and a 197 MB RocksDB directory database, producing a 3Gb JSON file when exported to JSON text 

Entity Framework has been optimized to use non-tracking proxies and no lazy loading, but is slower than Hiperspace
* Hiperspace takes 20% of the time to count all observations (traversing object-graph)
* Hiperspace takes 12% of the time to update a range of rows (40) 
* Hiperspace takes 65% of the time to export model to JSON (most time dedicated to JSON serialization
* Interestingly, it was faster to export entire model to Hiperspace, and traverse than to recursively count though SQL/Server 

## Direct RocksDB vs remote

As an embedded store RocksDB can be written by a single process (or multiple when opened read-only). [Rockshare C++ gRPC Server](https://github.com/channell/Hiperspace/tree/master/cpp/rockshare) enables shared write to a RocksDB hiperspace over a TCP socket connection.
The additional network latency takes 2.3 times as long for a full scan of the hiperspace, but  ~half the time of a relational database.  

|Time|Note|Elapsed|Factor|
|-|-|-|-|
|26:14.2|Opening RocksDB|||
|26:34.1|Count of objects is 579821|00:19.8||
|26:34.1|Opening Remote RocksDB|||
|27:20.8|Count of objects is 579821|00:46.7|2.36|
|27:20.8|Opening database|||
|28:44.6|Count of objects is 579821|01:23.5|4.21|
|28:44.6|Finish|||

## Comparison with a document DB 
was not undertaken because the size of the document exceeds storage limitations.  Splitting the document into 42433 separate documents is not expected to compare favorably with a relational database and would present problems for connections between classes 
[GridFS](https://www.mongodb.com/docs/manual/core/gridfs/)

[Sparx UML documentation](https://channell.github.io/Hiperspace/doc/)

[Comparison of SQL/Server graph with Hiperspace graph](./examples/SQLServerGraphSample/readme.md)
