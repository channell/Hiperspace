# readme
```mermaid
classDiagram
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
    class Acc.PathMessage {
        # Node  : Node
        # Route  : Graph.Route
        # Length  : Int32
        # Targets  : HashSet~String~
        + Edges  : HashSet~Graph.HiperEdge~
    }
    Acc.PathMessage *-- Graph.Route
    Acc.PathMessage *-- String
    Acc.PathMessage *-- Graph.HiperEdge
    class Acc.Sector {
        # Name  : String
        + Deleted  = false
        + Description  : String
        + Transaction_Cube (CubeSlice = "30", Sector = this, ContextLabel = contextlabel(this)) : Acc.Transaction_Cube
        + Customers (Sector = this) : Acc.Customer
    }
    class Acc.Customer {
        # Name  : String
        + Deleted  = false
        + Address  : String
        + SSN  : String
        + Parent  : Acc.Customer
        + Sector  : Acc.Sector
        + Tier  : Int32
        + Transaction_Cube (CubeSlice = "3", Customer = this, ContextLabel = contextlabel(this)) : Acc.Transaction_Cube
        + Accounts () : Acc.Account
        + Children (Parent = this) : Acc.Customer
    }
    Acc.Customer --> Acc.Sector
    Acc.Customer o-- Acc.Account
    class Acc.Transaction {
        # owner  : Acc.Account
        # At  : DateTime
        + Deleted  = false
        + Amount  : Decimal
        + Payee  : String
        + Receipient  : Acc.Customer
        + Debit () = debit(Amount)
        + Credit () = credit(Amount)
        + Amount2 () = Amount
        + Sector_Dimension () = owner?.owner?.Sector
        + Account_Dimension () = owner
        + Customer_Dimension () = owner?.owner
    }
    Acc.Transaction --> Acc.Customer
    class Acc.Account {
        # owner  : Acc.Customer
        # Title  : String
        + Deleted  = false
        + Opened  : DateTime
        + Closed  : DateTime
        + Transaction_Cube (CubeSlice = "20", Account = this, ContextLabel = contextlabel(this)) : Acc.Transaction_Cube
        + Transactions () : Acc.Transaction
        + Balance () : Acc.Balance
        + CurrentBalance () = deltasum(Transactions.Amount)
        + Debit () = sum(Transactions.Debit)
        + Credit () = sum(Transactions.Credit)
    }
    Acc.Account o-- Acc.Transaction
    Acc.Account o-- Acc.Balance
    class Acc.Balance {
        # owner  : Acc.Account
        + Deleted  = false
        + When  : DateTime
        + Current  : Decimal
    }
    class Acc.Transaction_Fact {
        # ContextLabel  : String
        # Sector  : Acc.Sector
        # Account  : Acc.Account
        # Customer  : Acc.Customer
        + Amount  : Decimal
        + Amount2_Sum  : Decimal
        + Deleted  = false
        + Facts  : Int64
        + CubeName () = cubename(Sector,Account,Customer)
        + Amount2 () = (Amount2_Sum / Facts)
        + Debit () = debit(Amount)
        + Credit () = credit(Amount)
    }
    Acc.Transaction_Fact --> Acc.Sector
    Acc.Transaction_Fact o-- Acc.Account
    Acc.Transaction_Fact --> Acc.Customer
    class API.CustomerActivity {
        # Customer  : Acc.Customer
        + CustomerTree  : List~Acc.Customer~
        + Sector  : List~Acc.Sector~
        + Accounts  : List~Acc.Account~
        + Cube  : List~Acc.Transaction_Cube~
        + Facts  : List~Acc.Transaction_Fact~
    }
    API.CustomerActivity --> Acc.Customer
    API.CustomerActivity *-- Acc.Customer
    API.CustomerActivity *-- Acc.Sector
    API.CustomerActivity *-- Acc.Account
    API.CustomerActivity *-- Acc.Transaction_Cube
    API.CustomerActivity *-- Acc.Transaction_Fact
```

---

## Value Graph.Route
Route across a graph of edge/node to form an HiperEdge

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Name|String||||
|+|Rules|HashSet<Graph.Rule>||||

---

## Value Graph.Rule
A rule for a route that matched as a type of Edge to a HiperEdge, e.g. { Name = 'relation', Rules = [{FromType = 'Person', ToType = 'Person', EdgeType = 'Mother'}]}

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|FromType|String||||
|#|ToType|String||||
|#|EdgeType|String||||

---

## Message Acc.PathMessage
Remote execution of path requests

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Node|Node||||
|#|Route|Graph.Route||||
|#|Length|Int32||||
|#|Targets|HashSet<String>||||
|+|Edges|HashSet<Graph.HiperEdge>||||

---

## EntityImpl Acc.Sector


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Name|String|name of the sector|||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|Description|String|description of the sector|||
||Transaction_Cube|Acc.Transaction_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "30", Sector = this, ContextLabel = contextlabel(this)|
||Customers|Acc.Customer|customers in this sector||Sector = this|

---

## EntityImpl Acc.Customer
A Customer

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Name|String| name  of the customer|||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|Address|String||||
|+|SSN|String||||
|+|Parent|Acc.Customer||||
|+|Sector|Acc.Sector||||
|+|Tier|Int32||||
||Transaction_Cube|Acc.Transaction_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "3", Customer = this, ContextLabel = contextlabel(this)|
|+|Accounts|Acc.Account|Account that the customer owns|||
||Children|Acc.Customer|||Parent = this|

---

## SegmentImpl Acc.Transaction
A Customer

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Acc.Account||||
|#|At|DateTime|when the transaction was authorised|||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|Amount|Decimal|debt or credit to account, with respect to the customer position|CubeMeasure(Aggregate?.Sum)||
|+|Payee|String|who it was paid to|||
|+|Receipient|Acc.Customer||||
||Debit|Some(Decimal)||CubeExtent()|debit(Amount)|
||Credit|Some(Decimal)||CubeExtent()|credit(Amount)|
||Amount2|Some(Decimal)||CubeMeasure(Aggregate?.Average)|Amount|
||Sector_Dimension|Some(Acc.Sector)|||owner?.owner?.Sector|
||Account_Dimension|Some(Acc.Account)|||owner|
||Customer_Dimension|Some(Acc.Customer)|||owner?.owner|

---

## SegmentImpl Acc.Account
A Customer

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Acc.Customer||||
|#|Title|String||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|Opened|DateTime||||
|+|Closed|DateTime||||
||Transaction_Cube|Acc.Transaction_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "20", Account = this, ContextLabel = contextlabel(this)|
|+|Transactions|Acc.Transaction|transactions against the account|||
|+|Balance|Acc.Balance|the last closing balance|||
||CurrentBalance|Some(Decimal)||CubeMeasure(Aggregate?.Sum)|deltasum(Transactions.Amount)|
||Debit|Some(Decimal)|||sum(Transactions.Debit)|
||Credit|Some(Decimal)|||sum(Transactions.Credit)|

---

## AspectImpl Acc.Balance
A Customer

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Acc.Account||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|When|DateTime|DateTime of the max balance|||
|+|Current|Decimal|Current closing balance at time When|||

---

## EntityImpl Acc.Transaction_Fact
A Customer

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|ContextLabel|String||||
|#|Sector|Acc.Sector||CubeDimensionReference()||
|#|Account|Acc.Account|A Customer|CubeDimensionReference()||
|#|Customer|Acc.Customer|A Customer|CubeDimensionReference()||
|+|Amount|Decimal|debt or credit to account, with respect to the customer position|CubeMeasure(Aggregate?.Sum)||
|+|Amount2_Sum|Decimal||CubeMeasure(Aggregate?.AverageTotal)||
||Deleted|Some(Boolean)|The cube fact has been deleted||false|
|+|Facts|Int64|Indicate that the Cube Slice is a Fact|||
||CubeName|Some(String)|||cubename(Sector,Account,Customer)|
||Amount2|Some(Decimal)||CubeMeasure(Aggregate?.Average)|(Amount2_Sum / Facts)|
||Debit|Some(Decimal)||CubeExtent()|debit(Amount)|
||Credit|Some(Decimal)||CubeExtent()|credit(Amount)|

---

## Message API.CustomerActivity


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Customer|Acc.Customer||||
|+|CustomerTree|List<Acc.Customer>||||
|+|Sector|List<Acc.Sector>||||
|+|Accounts|List<Acc.Account>||||
|+|Cube|List<Acc.Transaction_Cube>||||
|+|Facts|List<Acc.Transaction_Fact>||||

