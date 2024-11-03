# Hiperspace.SQL
Hiperspace.SQL is a full SQL query engine for Hiperspace, supporting the full range of joins, aggregations, and subqueries.

Hiperspace.SQL provides the same query functionality as a .NET client can use with LINQ queries, but without the need to write code in C#/F#

Hiperspace fully supports point-in-time "time travel" queries that are not possible with Python Data-Frames or DuckDB

## Features
- Hiperspace.SQL is not limited to queries of columns within a table, but supports the full navigation of properties of Hiperspace elements
- Where a column is a complex object it is returned as a JSON object
- Executing a batch of SQL statements return columnar data frames (dictionary of column-name and array of values)
- Explain SQL returns the execution plan, detailing the SetSPaces accessed and keys used for search (Key, Index, Scan)
- The Parquet method returns a Parquet file that can be used with any Apache Parquet library, or added to DuckDB OLAP store

## Data Dictionary

### SCHEMA_TABLE
| Column Name | Data Type | Description |
|-------------|-----------|-------------|
| TABLE_NAME |string|The name of the table|
| TABLE_TYPE |string|The type of the table in SCHEMA_PROPERTY|

### SCHEMA_COLUMN
| Column Name | Data Type | Description |
|-------------|-----------|-------------|
| TABLE_NAME |string|The name of the table|
| COLUMN_NAME |string|The name of the column|
| COLUMN_TYPE |string|The type of the table in SCHEMA_PROPERTY|

### SCHEMA_PROPERTY
| Column Name | Data Type | Description |
|-------------|-----------|-------------|
| TYPE_NAME |string|The Type Name|
| PROPERTY_NAME |string|The name of each property|
| PROPERTY_TYPE |string|reference to SCHEMA_PROPERTY.TYPE_NAME |

## Examples 

Simple query
```
SELECT p.Name, p.Gender FROM Persons as p WHERE p.Name = 'Lucy'
```

Query parameters
```
SELECT p.Name, p.Gender FROM Persons as p WHERE p.Name = :name
```
Query batches
```
SELECT p.Name, p.Gender FROM Persons as p WHERE p.Name = :name;
SELECT Name as name, Father as father from   Persons ;
```
Joins
```
SELECT  p.Name, f.Name as Father, f.Father as GrandFather
FROM    Persons as p 
join    Persons as f on p.Father.Name = f.Name
WHERE   p.Name = :name
```
Aggregates
```
select  p.Father.Name, count(p.Name) as Children
from    Persons as p
group by p.Father.Name as f
having count(*) > 1;
```
Like expressions
```
select  p.Father.Name, count(p.Name) as Children
from    Persons as p
where   Name like 'L%' and Name like '%y' or (Name like '%u%' and Name like '_uc_')
group by p.Father.Name as f
having count(*) > 1;
```
Null handling
```
select  p.Name, p.Father.Name
from    Persons as p
where   Name is not null
```
in query
```
SELECT p.Name, p.Gender 
FROM Persons as p 
WHERE p.Gender in (select p2.Gender from Persons as p2 where p2.Name = 'Lucy')
```
union 
```
SELECT p.Name, p.Gender 
FROM Persons as p 
WHERE p.Name in ('Lucy', 'Mark')
union 
SELECT p.Name, p.Gender 
FROM Persons as p 
WHERE p.Name in ('Eve', 'Mary')
```
inline view 
```
SELECT p.Name, p.Gender 
FROM Persons as p 
join (select p2.Gender from Persons as p2 where p2.Name = 'Lucy') as p3 on p.Gender = p3.Gender
```

dictionary query
```
select * from SCHEMA_TABLES;
select * from SCHEMA_COLUMNS;
select * from SCHEMA_PROPERTIES;
```

## API

The Hiperspace.SQL API can be called from any language that supports
DOTNET interop, including Python (using pythonnet).  Access via the Hiperspace.SQL.Engine object 
that is constructed with a reference to any domain space.

### Explain
Provides a detailed breakdown of the query execution plan
```
member engine.Explain (source, parameters : IDictionary<string,obj>) : string array = 
```

### Execute
Executes the SQL queries and returns an array of Data Frames
```
member engine.Execute (source , parameters : IDictionary<string,obj>) : IDictionary<string, obj array> array  =
```

### Parquet
Executes the SQL queries will a n array of filenames (one for each statement) and returns the filenames after 
writing the results to the Apache Parquet files.
```
member this.Parquet (source, fileNames, parameters : IDictionary<string,obj>): string array = 
```
