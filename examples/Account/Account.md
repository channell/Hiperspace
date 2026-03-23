# Account
```mermaid
classDiagram
    class API.CustomerActivity {
        # Customer  : Acc.Customer
        + CustomerTree  : List~Acc.Customer~
        + Sector  : List~Acc.Sector~
        + Accounts  : List~Acc.Account~
        + Cube  : List~Acc.Transaction_Cube~
        + Facts  : List~Acc.Transaction_Fact~
    }
    API.CustomerActivity --> Acc.Customer
    class Acc.Sector {
        # Name  : String
        + Description  : String
        + Customers (Sector = this) : Acc.Customer
    }
    class Acc.Balance {
        + When  : DateTime
        + Current  : Decimal
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
    class Acc.Transaction {
        # At  : DateTime
        + Amount  : Decimal
        + Payee  : String
        + Receipient  : Acc.Customer
        + Debit () = debit(Amount)
        + Credit () = credit(Amount)
        + Amount2 () = Amount
    }
    class Edge {
        # From  : Node
        # To  : Node
        # TypeName  : String
        + Name  : String
    }
    class Node {
        # SKey  : String
        + TypeName  : String
        + Name  : String
        + Froms (From = this) : Edge
        + Tos (To = this) : Edge
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## Message API.CustomerActivity


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Customer|Acc.Customer||||
|+|CustomerTree|List<Acc.Customer>||||
|+|Sector|List<Acc.Sector>||||
|+|Accounts|List<Acc.Account>||||
|+|Cube|List<Acc.Transaction_Cube>||||
|+|Facts|List<Acc.Transaction_Fact>||||

---

## Entity Acc.Sector


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Name|String|name of the sector|||
|+|Description|String|description of the sector|||
||Customers|Acc.Customer|customers in this sector||Sector = this|

---

## Aspect Acc.Balance
 Balance is the rolled up value for the account computed for a time

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|When|DateTime|DateTime of the max balance|||
|+|Current|Decimal|Current closing balance at time When|||

---

## Entity Acc.Customer
A Customer

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Name|String| name  of the customer|||
|+|Address|String||||
|+|SSN|String||||
|+|Parent|Acc.Customer||||
|+|Sector|Acc.Sector||||
|+|Tier|Int32||||
|+|Accounts|Acc.Account|Account that the customer owns|||
||Children|Acc.Customer|||Parent = this|

---

## Segment Acc.Account
An Account for a customer

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Title|String||||
|+|Opened|DateTime||||
|+|Closed|DateTime||||
|+|Transactions|Acc.Transaction|transactions against the account|||
|+|Balance|Acc.Balance|the last closing balance|||
||CurrentBalance|Some(Decimal)||CubeMeasure(Aggregate?.Sum)|deltasum(Transactions.Amount)|
||Debit|Some(Decimal)|||sum(Transactions.Debit)|
||Credit|Some(Decimal)|||sum(Transactions.Credit)|

---

## Segment Acc.Transaction
a transaction against account

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|At|DateTime|when the transaction was authorised|||
|+|Amount|Decimal|debt or credit to account, with respect to the customer position|CubeMeasure(Aggregate?.Sum)||
|+|Payee|String|who it was paid to|||
|+|Receipient|Acc.Customer||||
||Debit|Some(Decimal)||CubeExtent()|debit(Amount)|
||Credit|Some(Decimal)||CubeExtent()|credit(Amount)|
||Amount2|Some(Decimal)||CubeMeasure(Aggregate?.Average)|Amount|

---

## View Edge
edge between nodes

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## View Node
node in a graph view of data

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|SKey|String||||
|+|TypeName|String||||
|+|Name|String||||
||Froms|Edge|||From = this|
||Tos|Edge|||To = this|

