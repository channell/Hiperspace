# semt.021.002.08-physical
```mermaid
classDiagram
    class ISO20022.Semt021002.Document {
        # Uri  : String
        + SctiesStmtQry () : ISO20022.Semt021002.SecuritiesStatementQuery002V08
        + Validation () = validation(validElement(SctiesStmtQry))
    }
    class ISO20022.Semt021002.SecuritiesStatementQuery002V08 {
        # owner  : ISO20022.Semt021002.Document
        + SplmtryData  : List~ISO20022.Semt021002.SupplementaryData1~
        + AddtlQryParams  : List~ISO20022.Semt021002.AdditionalQueryParameters14~
        + BlckChainAdrOrWllt  : ISO20022.Semt021002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Semt021002.SecuritiesAccount30
        + AcctOwnr  : ISO20022.Semt021002.PartyIdentification156
        + StmtGnlDtls  : ISO20022.Semt021002.Statement84
        + StmtReqd  : ISO20022.Semt021002.DocumentNumber14
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""AddtlQryParams""",AddtlQryParams),validElement(AddtlQryParams),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(StmtGnlDtls),validElement(StmtReqd))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Semt021002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctiesStmtQry|ISO20022.Semt021002.SecuritiesStatementQuery002V08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesStmtQry))|

---

## AspectImpl ISO20022.Semt021002.SecuritiesStatementQuery002V08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Semt021002.Document||||
|+|SplmtryData|List<ISO20022.Semt021002.SupplementaryData1>||XmlElement()||
|+|AddtlQryParams|List<ISO20022.Semt021002.AdditionalQueryParameters14>||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt021002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt021002.SecuritiesAccount30||XmlElement()||
|+|AcctOwnr|ISO20022.Semt021002.PartyIdentification156||XmlElement()||
|+|StmtGnlDtls|ISO20022.Semt021002.Statement84||XmlElement()||
|+|StmtReqd|ISO20022.Semt021002.DocumentNumber14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""AddtlQryParams""",AddtlQryParams),validElement(AddtlQryParams),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(StmtGnlDtls),validElement(StmtReqd))|

