# readme
```mermaid
classDiagram
    class Location.Country {
        # Code  : String
        + AirPorts (Country = this) : Location.Airport
    }
    Location.Country --|> HasVectorSpace
    class Location.Airport {
        # Country  : Location.Country
        # Code  : String
    }
    Location.Airport --|> HasVectorSpace
    Location.Airport --> Location.Country
```

---

## Entity Location.Country
National Country

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Code|String||||
||AirPorts|Location.Airport|||Country = this|

---

## Entity Location.Airport
Airport within a country

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Country|Location.Country||||
|#|Code|String||||

