# readme
```mermaid
classDiagram
    class Cube.Edges {
        # From  : Node
        # To  : Node
        # FromTypeName  : String
        # ToTypeName  : String
        + Name  : String
    }
    class Cube.Portfolio {
        # Id  : String
        + Parent  : Cube.Portfolio
        + Tier  : Int32
        + Children (Parent = this) : Cube.Portfolio
    }
    Cube.Portfolio ..|> Cube.Edges
    class Cube.Country {
        # ISO  : String
        + Instruments (Country = this) : Cube.Instrument
    }
    class Cube.Sector {
        # Id  : Int32
        + Name  : String
        + Parent  : Cube.Sector
        + Tier  : Int32
        + Children (Parent = this) : Cube.Sector
        + Customers (Sector = this) : Cube.Customer
    }
    Cube.Sector ..|> Cube.Edges
    class Cube.Product {
        # Id  : String
        + Parent  : Cube.Product
        + Tier  : Int32
        + Children (Parent = this) : Cube.Product
        + ProductInstruments (Product = this) : Cube.Instrument
    }
    Cube.Product ..|> Cube.Edges
    class Cube.Account {
        # Id  : String
        + Customer  : Cube.Customer
        + FirstAccount (Account = this) : First.Acc
    }
    Cube.Account --> Cube.Customer
    Cube.Account ..|> Cube.Edges
    class Cube.Customer {
        # Id  : String
        + Sector  : Cube.Sector
        + Accounts (Customer = this) : Cube.Account
        + FirstAccount () : First.Acc
    }
    Cube.Customer --> Cube.Sector
    Cube.Customer o-- First.Acc
    Cube.Customer ..|> Cube.Edges
    class First.Acc {
        + Account  : Cube.Account
    }
    First.Acc --> Cube.Account
    class Cube.Price {
        + Market  : Decimal
    }
    class Cube.Instrument {
        # ISIN  : String
        + Country  : Cube.Country
        + Product  : Cube.Product
        + Price () : Cube.Price
        + Market () = Price?.Market
    }
    Cube.Instrument --> Cube.Country
    Cube.Instrument --> Cube.Product
    Cube.Instrument o-- Cube.Price
    Cube.Instrument ..|> Cube.Edges
    class Cube.Contract {
        # Id  : Int64
        + Quantity  : Decimal
        + Instrument  : Cube.Instrument
        + Portfolio  : Cube.Portfolio
        + Account  : Cube.Account
        + Market () = Instrument?.Market
        + Value () = (Quantity * Market)
        + StdDev () = Value
    }
    Cube.Contract --> Cube.Instrument
    Cube.Contract --> Cube.Portfolio
    Cube.Contract --> Cube.Account
    Cube.Contract ..|> Valued
    class Valued {
        # name  : String
        + Value  : Decimal
    }
    class Banking.Trade {
        # Id  : String
        + Book  : Banking.Book
    }
    Banking.Trade --> Banking.Book
    class Banking.Book {
        # Id  : String
        + Trades (Book = this) : Banking.Trade
    }
```

---

## View Cube.Edges
Bidirectional Edge, implemented with two Cube.Edges

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|FromTypeName|String||||
|#|ToTypeName|String||||
|+|Name|String||||

---

## Entity Cube.Portfolio


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|String||||
|+|Parent|Cube.Portfolio||||
|+|Tier|Int32||||
||Children|Cube.Portfolio|||Parent = this|

---

## Entity Cube.Country


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|ISO|String||||
||Instruments|Cube.Instrument|||Country = this|

---

## Entity Cube.Sector


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Int32||||
|+|Name|String||||
|+|Parent|Cube.Sector||||
|+|Tier|Int32||||
||Children|Cube.Sector|||Parent = this|
||Customers|Cube.Customer|||Sector = this|

---

## Entity Cube.Product


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|String||||
|+|Parent|Cube.Product||||
|+|Tier|Int32||||
||Children|Cube.Product|||Parent = this|
||ProductInstruments|Cube.Instrument|||Product = this|

---

## Entity Cube.Account


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|String||||
|+|Customer|Cube.Customer||||
||FirstAccount|First.Acc|||Account = this|

---

## Entity Cube.Customer


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|String||||
|+|Sector|Cube.Sector||||
||Accounts|Cube.Account|||Customer = this|
|+|FirstAccount|First.Acc||||

---

## Aspect First.Acc


||Name|Type|*|@|=|
|-|-|-|-|-|
|+|Account|Cube.Account||AlternateIndex("Cube.CustomerFirstAccount", 78)||

---

## Aspect Cube.Price


||Name|Type|*|@|=|
|-|-|-|-|-|
|+|Market|Decimal||||

---

## Entity Cube.Instrument


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|ISIN|String||||
|+|Country|Cube.Country||||
|+|Product|Cube.Product||||
|+|Price|Cube.Price||||
||Market||||Price?.Market|

---

## Entity Cube.Contract


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Int64||||
|+|Quantity|Decimal||||
|+|Instrument|Cube.Instrument||||
|+|Portfolio|Cube.Portfolio||||
|+|Account|Cube.Account||||
||Market||||Instrument?.Market|
||Value|||CubeMeasure(Aggregate?.Sum)|(Quantity * Market)|
||StdDev|||CubeMeasure(Aggregate?.StdDev)|Value|

---

## View Valued


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|name|String||||
|+|Value|Decimal||||

---

## View Banking.Trade


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|String||||
|+|Book|Banking.Book||AlternateIndex("Banking.EQ.Trade", 60), AlternateIndex("Banking.FI.Trade", 56), AlternateIndex("Banking.FX.Trade", 58), AlternateIndex("Banking.EQ.Trade", 96), AlternateIndex("Banking.FI.Trade", 94), AlternateIndex("Banking.FX.Trade", 95)||

---

## Entity Banking.Book


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|String||||
||Trades|Banking.Trade|||Book = this|

