# Cousins-graph
```mermaid
classDiagram
    class Cousins.Edge2 {
        # From  : Node
        # To  : Node
        # TypeName  : String
        + Name  : String
    }
    class Cousins.Edge3 {
        # From  : Node
        # To  : Node
        # TypeName  : String
        + Name  : String
    }
    class Cousins.Edge4 {
        # From  : Node
        # To  : Node
        # TypeName  : String
        + Name  : String
    }
    class Cousins.Path {
        # From  : Node
        # To  : Node
        # TypeName  : String
        + Name  : String
        + Edge  : Edge
        + Source  : Cousins.Path
    }
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
|#|From|Node||||
|#|To|Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## View Cousins.Edge3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## View Cousins.Edge4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|TypeName|String||||
|+|Name|String||||

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

