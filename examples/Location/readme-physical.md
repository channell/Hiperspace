# readme
```mermaid
classDiagram
    class Edge2 {
        # From  : Node
        # To  : Node
        # TypeName  : String
        + Name  : String
    }
    class Hiperspace.VectorSpace {
        # owner  : Any
        + Vector  : Hiperspace.Vector
    }
    Hiperspace.VectorSpace *-- Hiperspace.Vector
    class Graph.Route {
        # Name  : String
        + Rules  : HashSet~Graph.Rule~
    }
    Graph.Route *-- Graph.Rule
    class Graph.Rule {
        # FromType  : String
        # ToType  : String
        # EdgeType  : String
    }
    class Location.PathMessage {
        # Node  : Node
        # Route  : Graph.Route
        # Length  : Int32
        # Targets  : HashSet~String~
        + Edges  : HashSet~Graph.HiperEdge~
    }
    Location.PathMessage *-- Graph.Route
    Location.PathMessage *-- String
    Location.PathMessage *-- Graph.HiperEdge
    class Location.Country {
        # Code  : String
        + VectorSpace () : Location.CountryVectorSpace
        + AirPorts (Country = this) : Location.Airport
    }
    Location.Country o-- Location.CountryVectorSpace
    class Location.Airport {
        # Country  : Location.Country
        # Code  : String
        + VectorSpace () : Location.AirportVectorSpace
    }
    Location.Airport --> Location.Country
    Location.Airport o-- Location.AirportVectorSpace
    Location.Airport ..|> Edge2
    class Location.AirportVectorSpace {
        # owner  : Location.Airport
        + Vector  : Hiperspace.Vector
    }
    Location.AirportVectorSpace *-- Hiperspace.Vector
    Location.AirportVectorSpace ..|> Hiperspace.VectorSpace
    class Location.CountryVectorSpace {
        # owner  : Location.Country
        + Vector  : Hiperspace.Vector
    }
    Location.CountryVectorSpace *-- Hiperspace.Vector
    Location.CountryVectorSpace ..|> Hiperspace.VectorSpace
```

---

## View Edge2


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## View Hiperspace.VectorSpace
 Aspect used to search for similar entities

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Any|owner of the segment/aspect as an object|||
|+|Vector|Hiperspace.Vector||||

---

## Value Graph.Route
Route across a graph of edge/node to form an HiperEdge

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Name|String||||
|+|Rules|HashSet<Graph.Rule>||||

---

## Value Graph.Rule
A rule for a route that matched as a type of Edge to a HiperEdge, e.g. { Name = 'relation', Rules = [{FromType = 'Person', ToType = 'Person', EdgeType = 'Mother'}]}

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|FromType|String||||
|#|ToType|String||||
|#|EdgeType|String||||

---

## Message Location.PathMessage
Remote execution of path requests

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Node|Node||||
|#|Route|Graph.Route||||
|#|Length|Int32||||
|#|Targets|HashSet<String>||||
|+|Edges|HashSet<Graph.HiperEdge>||||

---

## EntityImpl Location.Country
National Country

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Code|String||||
|+|VectorSpace|Location.CountryVectorSpace||||
||AirPorts|Location.Airport|||Country = this|

---

## EntityImpl Location.Airport
Airport within a country

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Country|Location.Country||||
|#|Code|String||||
|+|VectorSpace|Location.AirportVectorSpace||||

---

## AspectImpl Location.AirportVectorSpace
Airport within a country

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Location.Airport||||
|+|Vector|Hiperspace.Vector||||

---

## AspectImpl Location.CountryVectorSpace
National Country

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Location.Country||||
|+|Vector|Hiperspace.Vector||||

