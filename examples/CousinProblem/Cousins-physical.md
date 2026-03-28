# Cousins-physical
```mermaid
classDiagram
    class Cousins.Path {
        # From  : Node
        # To  : Node
        # TypeName  : String
        + Name  : String
        + Edge  : Edge
        + Source  : Cousins.Path
    }
    class Graph.TransitiveSegment {
        # owner  : Cousins.Person
        # Route  : Graph.Route
        + Length  : Int32
        + Targets  : HashSet~String~
        + Paths () = Paths(owner,Route,Length,Targets)
    }
    Graph.TransitiveSegment *-- Graph.Route
    class Cousins.Person {
        # Name  : String
        + Deleted  = false
        + Gender  : Cousins.Gender
        + Mother  : Cousins.Person
        + Father  : Cousins.Person
        + Email  : String
        + TypeName () = "Person"
        + FatherChild (Father = this) : Cousins.Person
        + MotherChild (Mother = this) : Cousins.Person
        + Relatives () = relation(this)
        + Stored () : Graph.TransitiveSegment
        + AllRelatives () = allrelation(this)
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl Cousins.Path


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|TypeName|String||||
|+|Name|String||||
|+|Edge|Edge||||
|+|Source|Cousins.Path||||

---

## SegmentImpl Graph.TransitiveSegment


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Cousins.Person||||
|#|Route|Graph.Route||||
|+|Length|Int32||||
|+|Targets|HashSet<String>||||
||Paths|Some(HashSet<Graph.HiperEdge>)||Once()|Paths(owner,Route,Length,Targets)|

---

## EntityImpl Cousins.Person


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Name|String||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|Gender|Cousins.Gender||||
|+|Mother|Cousins.Person||||
|+|Father|Cousins.Person||||
|+|Email|String||||
||TypeName|Some(String)|||"Person"|
||FatherChild|Cousins.Person|||Father = this|
||MotherChild|Cousins.Person|||Mother = this|
||Relatives|Some(List<Path>)||Once()|relation(this)|
|+|Stored|Graph.TransitiveSegment||||
||AllRelatives|Some(HashSet<Graph.HiperEdge>)||Once()|allrelation(this)|

