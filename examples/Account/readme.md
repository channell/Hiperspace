# readme
```mermaid
classDiagram
    class Acc.Sector {
        # Name  : String
        + Description  : String
        + Customers (Sector = this) : Acc.Customer
    }
    class Acc.Customer {
        # Name  : String
        + Address  : String
        + SSN  : String
        + Parent  : Acc.Customer
        + Sector  : Acc.Sector
        + Tier  : Int32
        + Accounts () : Acc.Account
        + Children (Parent = this) : Acc.Customer
    }
    Acc.Customer --> Acc.Sector
    Acc.Customer o-- Acc.Account
    class Acc.Transaction {
        # At  : DateTime
        + Amount  : Decimal
        + Payee  : String
        + Receipient  : Acc.Customer
        + Debit () = debit(Amount)
        + Credit () = credit(Amount)
        + Amount2 () = Amount
    }
    Acc.Transaction --> Acc.Customer
    class Acc.Account {
        # Title  : String
        + Opened  : DateTime
        + Closed  : DateTime
        + Transactions () : Acc.Transaction
        + Balance () : Acc.Balance
        + CurrentBalance () = deltasum(Transactions.Amount)
        + Debit () = sum(Transactions.Debit)
        + Credit () = sum(Transactions.Credit)
    }
    Acc.Account o-- Acc.Transaction
    Acc.Account o-- Acc.Balance
    class Acc.Balance {
        + When  : DateTime
        + Current  : Decimal
    }
    class API.CustomerActivity {
        # Customer  : Acc.Customer
        + CustomerTree  : List~Acc.Customer~
        + Sector  : List~Acc.Sector~
        + Accounts  : List~Acc.Account~
        + Cube  : List~Acc.Transaction_Cube~
        + Facts  : List~Acc.Transaction_Fact~
    }
    API.CustomerActivity --> Acc.Customer
```

---

## Entity Acc.Sector


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Name|String|name of the sector|||
|+|Description|String|description of the sector|||
||Customers|Acc.Customer|customers in this sector||Sector = this|

---

## Entity Acc.Customer
A Customer

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Name|String| name  of the customer|||
|+|Address|String||||
|+|SSN|String||||
|+|Parent|Acc.Customer||||
|+|Sector|Acc.Sector||||
|+|Tier|Int32||||
|+|Accounts|Acc.Account|Account that the customer owns|||
||Children|Acc.Customer|||Parent = this|

---

## Segment Acc.Transaction
a transaction against account

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|At|DateTime|when the transaction was authorised|||
|+|Amount|Decimal|debt or credit to account, with respect to the customer position|CubeMeasure(Aggregate?.Sum)||
|+|Payee|String|who it was paid to|||
|+|Receipient|Acc.Customer||||
||Debit|||CubeExtent()|debit(Amount)|
||Credit|||CubeExtent()|credit(Amount)|
||Amount2|||CubeMeasure(Aggregate?.Average)|Amount|

---

## Segment Acc.Account
An Account for a customer

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Title|String||||
|+|Opened|DateTime||||
|+|Closed|DateTime||||
|+|Transactions|Acc.Transaction|transactions against the account|||
|+|Balance|Acc.Balance|the last closing balance|||
||CurrentBalance|||CubeMeasure(Aggregate?.Sum)|deltasum(Transactions.Amount)|
||Debit||||sum(Transactions.Debit)|
||Credit||||sum(Transactions.Credit)|

---

## Aspect Acc.Balance
 Balance is the rolled up value for the account computed for a time

||Name|Type|*|@|=|
|-|-|-|-|-|
|+|When|DateTime|DateTime of the max balance|||
|+|Current|Decimal|Current closing balance at time When|||

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

