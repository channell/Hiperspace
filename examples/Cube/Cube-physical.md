# Cube-physical
```mermaid
classDiagram
    class Banking.Book {
        # Id  : String
        + Trades (Book = ) : Banking.Trade
    }
    class Banking.EQ.Trade {
        # Id  : String
        + Book  : Banking.Book
        + Value  : Decimal
    }
    Banking.EQ.Trade --> Banking.Book
    class Banking.FI.Trade {
        # Id  : String
        + Book  : Banking.Book
        + Value  : Decimal
    }
    Banking.FI.Trade --> Banking.Book
    class Banking.FX.Trade {
        # Id  : String
        + Book  : Banking.Book
        + Value  : Decimal
    }
    Banking.FX.Trade --> Banking.Book
    class Cube.Account {
        # Id  : String
        + Customer  : Cube.Customer
        + FirstAccount (Account = ) : First.Acc
    }
    Cube.Account --> Cube.Customer
    class Cube.Contract {
        # Id  : Int64
        + Deleted  = false
        + Quantity  : Decimal
        + Instrument  : Cube.Instrument
        + Portfolio  : Cube.Portfolio
        + Account  : Cube.Account
        + Market () = Instrument?.Market
        + Value () = (Quantity * Market)
        + StdDev () = Value
        + Percentile () = Value
        + Avg () = Value
        + Sector_Dimension () = Account?.Customer?.Sector
        + Country_Dimension () = Instrument?.Country
        + Product_Dimension () = Instrument?.Product
        + Portfolio_Dimension () = Portfolio
    }
    Cube.Contract --> Cube.Instrument
    Cube.Contract --> Cube.Portfolio
    Cube.Contract --> Cube.Account
    class Cube.Contract_Cube {
        # CubeSlice  : String
        # ContextLabel  : String
        # Sector  : Cube.Sector
        # Country  : Cube.Country
        # Product  : Cube.Product
        # Portfolio  : Cube.Portfolio
        + Value  : Decimal
        + StdDev  : Double
        + Percentile  : Double
        + Avg_Sum  : Decimal
        + Deleted  = false
        + Facts  : Int64
        + CubeName () = cubename(Sector,Country,Product,Portfolio)
        + CubeDimensions () = cubedimensions(Sector,Country,Product,Portfolio)
        + DrillDowns() () = drilldownEdges()
        + Avg () = (Avg_Sum / Facts)
    }
    Cube.Contract_Cube --> Cube.Sector
    Cube.Contract_Cube --> Cube.Country
    Cube.Contract_Cube --> Cube.Product
    Cube.Contract_Cube --> Cube.Portfolio
    class Cube.Contract_Fact {
        # ContextLabel  : String
        # Sector  : Cube.Sector
        # Country  : Cube.Country
        # Product  : Cube.Product
        # Portfolio  : Cube.Portfolio
        + Value  : Decimal
        + StdDev_Vector  : Hiperspace.Vector
        + Percentile_Vector  : Hiperspace.Vector
        + Avg_Sum  : Decimal
        + Deleted  = false
        + Facts  : Int64
        + CubeName () = cubename(Sector,Country,Product,Portfolio)
        + CubeDimensions () = cubedimensions(Sector,Country,Product,Portfolio)
        + DrillDowns() () = drilldownEdges()
        + Avg () = (Avg_Sum / Facts)
        + StdDev () = stddev(StdDev_Vector)
        + Percentile () = percentile(Percentile_Vector,95)
    }
    Cube.Contract_Fact --> Cube.Sector
    Cube.Contract_Fact --> Cube.Country
    Cube.Contract_Fact --> Cube.Product
    Cube.Contract_Fact --> Cube.Portfolio
    class Cube.Country {
        # ISO  : String
        + Contract_Cube (CubeSlice = """13""", Country = this, ContextLabel = contextlabel()) : Cube.Contract_Cube
        + Instruments (Country = ) : Cube.Instrument
    }
    class Cube.Customer {
        # Id  : String
        + Sector  : Cube.Sector
        + Accounts (Customer = ) : Cube.Account
        + FirstAccount () : Cube.CustomerFirstAccount
    }
    Cube.Customer --> Cube.Sector
    Cube.Customer o-- Cube.CustomerFirstAccount
    class Cube.CustomerFirstAccount {
        # owner  : Cube.Customer
        + Account  : Cube.Account
    }
    Cube.CustomerFirstAccount --> Cube.Account
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
    class Cube.Portfolio {
        # Id  : String
        + Parent  : Cube.Portfolio
        + Tier  : Int32
        + Contract_Cube (CubeSlice = """11""", Portfolio = this, ContextLabel = contextlabel()) : Cube.Contract_Cube
        + Children (Parent = ) : Cube.Portfolio
    }
    class Cube.Price {
        # owner  : Cube.Instrument
        + Market  : Decimal
    }
    class Cube.Product {
        # Id  : String
        + Parent  : Cube.Product
        + Tier  : Int32
        + Contract_Cube (CubeSlice = """25""", Product = this, ContextLabel = contextlabel()) : Cube.Contract_Cube
        + Children (Parent = ) : Cube.Product
        + ProductInstruments (Product = ) : Cube.Instrument
    }
    class Cube.Sector {
        # Id  : Int32
        + Name  : String
        + Parent  : Cube.Sector
        + Tier  : Int32
        + Contract_Cube (CubeSlice = """19""", Sector = this, ContextLabel = contextlabel()) : Cube.Contract_Cube
        + Children (Parent = ) : Cube.Sector
        + Customers (Sector = ) : Cube.Customer
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl Banking.Book


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|String||||
||Trades|Banking.Trade|||Book = |

---

## EntityImpl Banking.EQ.Trade


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|String||||
|+|Book|Banking.Book||AlternateIndex("""Banking.EQ.Trade""", 145), AlternateIndex("""Banking.FI.Trade""", 143), AlternateIndex("""Banking.FX.Trade""", 144), AlternateIndex("""Banking.Trade""", 58)||
|+|Value|Decimal||CubeMeasure(Aggregate?.Sum)||

---

## EntityImpl Banking.FI.Trade


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|String||||
|+|Book|Banking.Book||AlternateIndex("""Banking.EQ.Trade""", 145), AlternateIndex("""Banking.FI.Trade""", 143), AlternateIndex("""Banking.FX.Trade""", 144), AlternateIndex("""Banking.Trade""", 58)||
|+|Value|Decimal||CubeMeasure(Aggregate?.Sum)||

---

## EntityImpl Banking.FX.Trade


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|String||||
|+|Book|Banking.Book||AlternateIndex("""Banking.EQ.Trade""", 145), AlternateIndex("""Banking.FI.Trade""", 143), AlternateIndex("""Banking.FX.Trade""", 144), AlternateIndex("""Banking.Trade""", 58)||
|+|Value|Decimal||CubeMeasure(Aggregate?.Sum)||

---

## EntityImpl Cube.Account


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|String||||
|+|Customer|Cube.Customer||||
||FirstAccount|First.Acc|||Account = |

---

## EntityImpl Cube.Contract


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Int64||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|Quantity|Decimal||||
|+|Instrument|Cube.Instrument||||
|+|Portfolio|Cube.Portfolio||||
|+|Account|Cube.Account||||
||Market|Some(Decimal)|||Instrument?.Market|
||Value|Some(Decimal)||CubeMeasure(Aggregate?.Sum)|(Quantity * Market)|
||StdDev|Some(Decimal)||CubeMeasure(Aggregate?.StdDev)|Value|
||Percentile|Some(Decimal)||CubeMeasure(Aggregate?.Percentile, 95)|Value|
||Avg|Some(Decimal)||CubeMeasure(Aggregate?.Average)|Value|
||Sector_Dimension|Some(Cube.Sector)|||Account?.Customer?.Sector|
||Country_Dimension|Some(Cube.Country)|||Instrument?.Country|
||Product_Dimension|Some(Cube.Product)|||Instrument?.Product|
||Portfolio_Dimension|Some(Cube.Portfolio)|||Portfolio|

---

## EntityImpl Cube.Contract_Cube


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|CubeSlice|String||||
|#|ContextLabel|String||||
|#|Sector|Cube.Sector||CubeDimensionReference()||
|#|Country|Cube.Country||CubeDimensionReference()||
|#|Product|Cube.Product||CubeDimensionReference()||
|#|Portfolio|Cube.Portfolio||CubeDimensionReference()||
|+|Value|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|StdDev|Double||CubeMeasure(Aggregate?.StdVector)||
|+|Percentile|Double||CubeMeasure(Aggregate?.PerVector, 95)||
|+|Avg_Sum|Decimal||CubeMeasure(Aggregate?.AverageTotal)||
||Deleted|Some(Boolean)|The cube fact has been deleted||false|
|+|Facts|Int64|Number of Facts this Cube/Fact is calculated from|||
||CubeName|Some(String)|||cubename(Sector,Country,Product,Portfolio)|
||CubeDimensions|Some(Int32)|||cubedimensions(Sector,Country,Product,Portfolio)|
||DrillDowns()|Some(global::System.Collections.Generic.HashSet<Hiperspace.Edge>)|Drilldown to Edges||drilldownEdges()|
||Avg|Some(Decimal)||CubeMeasure(Aggregate?.Average)|(Avg_Sum / Facts)|

---

## EntityImpl Cube.Contract_Fact


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|ContextLabel|String||||
|#|Sector|Cube.Sector||CubeDimensionReference()||
|#|Country|Cube.Country||CubeDimensionReference()||
|#|Product|Cube.Product||CubeDimensionReference()||
|#|Portfolio|Cube.Portfolio||CubeDimensionReference()||
|+|Value|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|StdDev_Vector|Hiperspace.Vector||CubeMeasure(Aggregate?.StdVector)||
|+|Percentile_Vector|Hiperspace.Vector||CubeMeasure(Aggregate?.PerVector, 95)||
|+|Avg_Sum|Decimal||CubeMeasure(Aggregate?.AverageTotal)||
||Deleted|Some(Boolean)|The cube fact has been deleted||false|
|+|Facts|Int64|Number of Facts this Cube/Fact is calculated from|||
||CubeName|Some(String)|||cubename(Sector,Country,Product,Portfolio)|
||CubeDimensions|Some(Int32)|||cubedimensions(Sector,Country,Product,Portfolio)|
||DrillDowns()|Some(global::System.Collections.Generic.HashSet<Hiperspace.Edge>)|Drilldown to Edges||drilldownEdges()|
||Avg|Some(Decimal)||CubeMeasure(Aggregate?.Average)|(Avg_Sum / Facts)|
||StdDev|Some(Double)||CubeMeasure(Aggregate?.StdDev)|stddev(StdDev_Vector)|
||Percentile|Some(Double)||CubeMeasure(Aggregate?.Percentile)|percentile(Percentile_Vector,95)|

---

## EntityImpl Cube.Country


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|ISO|String||||
||Contract_Cube|Cube.Contract_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """13""", Country = this, ContextLabel = contextlabel()|
||Instruments|Cube.Instrument|||Country = |

---

## EntityImpl Cube.Customer


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|String||||
|+|Sector|Cube.Sector||||
||Accounts|Cube.Account|||Customer = |
|+|FirstAccount|Cube.CustomerFirstAccount||||

---

## AspectImpl Cube.CustomerFirstAccount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Cube.Customer||||
|+|Account|Cube.Account||AlternateIndex("""Cube.CustomerFirstAccount""", 78)||

---

## EntityImpl Cube.Instrument


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|ISIN|String||||
|+|Country|Cube.Country||||
|+|Product|Cube.Product||||
|+|Price|Cube.Price||||
||Market|Some(Decimal)|||Price?.Market|

---

## EntityImpl Cube.Portfolio


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|String||||
|+|Parent|Cube.Portfolio||||
|+|Tier|Int32||||
||Contract_Cube|Cube.Contract_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """11""", Portfolio = this, ContextLabel = contextlabel()|
||Children|Cube.Portfolio|||Parent = |

---

## AspectImpl Cube.Price


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Cube.Instrument||||
|+|Market|Decimal||||

---

## EntityImpl Cube.Product


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|String||||
|+|Parent|Cube.Product||||
|+|Tier|Int32||||
||Contract_Cube|Cube.Contract_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """25""", Product = this, ContextLabel = contextlabel()|
||Children|Cube.Product|||Parent = |
||ProductInstruments|Cube.Instrument|||Product = |

---

## EntityImpl Cube.Sector


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Int32||||
|+|Name|String||||
|+|Parent|Cube.Sector||||
|+|Tier|Int32||||
||Contract_Cube|Cube.Contract_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """19""", Sector = this, ContextLabel = contextlabel()|
||Children|Cube.Sector|||Parent = |
||Customers|Cube.Customer|||Sector = |

