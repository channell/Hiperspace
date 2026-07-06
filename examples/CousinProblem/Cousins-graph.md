# Cousins-graph
```mermaid
classDiagram
    class Cousins.Edge2 {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class Cousins.Edge3 {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class Cousins.Edge4 {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class Cousins.Path {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
        + Edge  : Hiperspace.Edge
        + Source  : Cousins.Path
    }
    class Cousins.Person {
        # Name  : String
        + Deleted  = false
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
    Cousins.Person ..|> Cousins.Edge2
    Cousins.Person ..|> Cousins.Edge3
    Cousins.Person ..|> Cousins.Edge4
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## View Cousins.Edge2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Hiperspace.Node||||
|#|To|Hiperspace.Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## View Cousins.Edge3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Hiperspace.Node||||
|#|To|Hiperspace.Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## View Cousins.Edge4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Hiperspace.Node||||
|#|To|Hiperspace.Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## EntityImpl Cousins.Path


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Hiperspace.Node||||
|#|To|Hiperspace.Node||||
|#|TypeName|String||||
|+|Name|String||||
|+|Edge|Hiperspace.Edge||||
|+|Source|Cousins.Path||||

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
||TypeName|Some(String)|||"""Person"""|
||FatherChild|Cousins.Person|||Father = |
||MotherChild|Cousins.Person|||Mother = |
||Relatives|Some(global::System.Collections.Generic.List<Path>)||Once()|relation()|
|+|Stored|Graph.TransitiveSegment||||
||AllRelatives|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)||Once()|allrelation()|

