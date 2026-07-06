# camt.053.001.13-physical
```mermaid
classDiagram
    class ISO20022.Camt053001.Document {
        # Uri  : String
        + BkToCstmrStmt () : ISO20022.Camt053001.BankToCustomerStatementV13
        + Validation () = validation(validElement(BkToCstmrStmt))
    }
    class ISO20022.Camt053001.BankToCustomerStatementV13 {
        # owner  : ISO20022.Camt053001.Document
        + SplmtryData  : List~ISO20022.Camt053001.SupplementaryData1~
        + Stmt  : List~ISO20022.Camt053001.AccountStatement14~
        + GrpHdr  : ISO20022.Camt053001.GroupHeader116
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Stmt""",Stmt),validList("""Stmt""",Stmt),validElement(Stmt),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt053001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|BkToCstmrStmt|ISO20022.Camt053001.BankToCustomerStatementV13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BkToCstmrStmt))|

---

## AspectImpl ISO20022.Camt053001.BankToCustomerStatementV13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt053001.Document||||
|+|SplmtryData|List<ISO20022.Camt053001.SupplementaryData1>||XmlElement()||
|+|Stmt|List<ISO20022.Camt053001.AccountStatement14>||XmlElement()||
|+|GrpHdr|ISO20022.Camt053001.GroupHeader116||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Stmt""",Stmt),validList("""Stmt""",Stmt),validElement(Stmt),validElement(GrpHdr))|

