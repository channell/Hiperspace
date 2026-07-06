# Cousins
```mermaid
classDiagram
    class Cousins.Gender {
        Female = 1
        Male = 2
    }
    class Cousins.Path {
        + Edge  : Hiperspace.Edge
        + Source  : Cousins.Path
    }
    Cousins.Path --|> Hiperspace.Edge
    Cousins.Path ..|> Hiperspace.Edge
    class Cousins.Person {
        # Name  : String
        + Gender  : Cousins.Gender
        + Mother  : Cousins.Person
        + Father  : Cousins.Person
        + Email  : String
        + TypeName () = """Person"""
        + FatherChild (Father = ) : Cousins.Person
        + MotherChild (Mother = ) : Cousins.Person
        + Relatives () = relation()
        + Stored () : Graph.TransitiveSegment
        + AllRelatives () = allrelation()
    }
    Cousins.Person --> Cousins.Gender
    Cousins.Person o-- Graph.TransitiveSegment
    Cousins.Person ..|> Hiperspace.Node
    Cousins.Person ..|> Hiperspace.Edge
    Cousins.Person ..|> Graph.HiperEdge
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class Graph.HiperEdge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
        + Edge  : Hiperspace.Edge
        + Source  : Graph.HiperEdge
        + Width  = 1
        + Length  = 1
    }
    class Graph.TransitiveSegment {
        # Route  : Graph.Route
        + Length  : Int32
        + Targets  : global::System.Collections.Generic.HashSet~String~
        + Paths () = Paths(owner,Route,Length,Targets)
    }
    Graph.TransitiveSegment *-- Graph.Route
    class Hiperspace.Node {
        # SKey  : String
        + TypeName  : String
        + Name  : String
        + Froms (From = ) : Hiperspace.Edge
        + Tos (To = ) : Hiperspace.Edge
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## Enum Cousins.Gender


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Female|Int32|||1|
||Male|Int32|||2|

---

## Entity Cousins.Path


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Edge|Hiperspace.Edge||||
|+|Source|Cousins.Path||||

---

## Entity Cousins.Person


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Name|String||||
|+|Gender|Cousins.Gender||||
|+|Mother|Cousins.Person||||
|+|Father|Cousins.Person||||
|+|Email|String||||
||TypeName|Some(String)|||"""Person"""|
||FatherChild|Cousins.Person|||Father = |
||MotherChild|Cousins.Person|||Mother = |
||Relatives|Some(global::System.Collections.Generic.List<Path>)||Once()|relation()|
|+|Stored|Graph.TransitiveSegment||||
||AllRelatives|Some(Set<Graph.HiperEdge>)||Once()|allrelation()|

---

## View Hiperspace.Edge
edge between nodes

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Hiperspace.Node||||
|#|To|Hiperspace.Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## View Graph.HiperEdge
Path from one Node to another Node over a number of routes

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Hiperspace.Node||||
|#|To|Hiperspace.Node||||
|#|TypeName|String||||
|+|Name|String||||
|+|Edge|Hiperspace.Edge|The Edge that provides the end of this Path|||
|+|Source|Graph.HiperEdge|The shortest source Path that this path extends|||
||Width|Some(Int32)|The number of distict paths between the Nodes||1|
||Length|Some(Int32)|The shortest number of Edges in the Path||1|

---

## Segment Graph.TransitiveSegment


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Route|Graph.Route||||
|+|Length|Int32||||
|+|Targets|global::System.Collections.Generic.HashSet<String>||||
||Paths|Some(Set<Graph.HiperEdge>)||Once()|Paths(owner,Route,Length,Targets)|

---

## View Hiperspace.Node
node in a graph view of data

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|SKey|String||||
|+|TypeName|String||||
|+|Name|String||||
||Froms|Hiperspace.Edge|||From = |
||Tos|Hiperspace.Edge|||To = |

