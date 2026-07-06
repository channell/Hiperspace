# auth.022.001.04-physical
```mermaid
classDiagram
    class ISO20022.Auth022001.Document {
        # Uri  : String
        + CtrctRegnStmt () : ISO20022.Auth022001.ContractRegistrationStatementV04
        + Validation () = validation(validElement(CtrctRegnStmt))
    }
    class ISO20022.Auth022001.ContractRegistrationStatementV04 {
        # owner  : ISO20022.Auth022001.Document
        + SplmtryData  : List~ISO20022.Auth022001.SupplementaryData1~
        + Stmt  : List~ISO20022.Auth022001.ContractRegistrationStatement4~
        + GrpHdr  : ISO20022.Auth022001.CurrencyControlHeader7
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

## EntityImpl ISO20022.Auth022001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CtrctRegnStmt|ISO20022.Auth022001.ContractRegistrationStatementV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrctRegnStmt))|

---

## AspectImpl ISO20022.Auth022001.ContractRegistrationStatementV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth022001.Document||||
|+|SplmtryData|List<ISO20022.Auth022001.SupplementaryData1>||XmlElement()||
|+|Stmt|List<ISO20022.Auth022001.ContractRegistrationStatement4>||XmlElement()||
|+|GrpHdr|ISO20022.Auth022001.CurrencyControlHeader7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Stmt""",Stmt),validList("""Stmt""",Stmt),validElement(Stmt),validElement(GrpHdr))|

