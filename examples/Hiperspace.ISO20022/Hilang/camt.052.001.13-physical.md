# camt.052.001.13-physical
```mermaid
classDiagram
    class ISO20022.Camt052001.Document {
        # Uri  : String
        + BkToCstmrAcctRpt () : ISO20022.Camt052001.BankToCustomerAccountReportV13
        + Validation () = validation(validElement(BkToCstmrAcctRpt))
    }
    class ISO20022.Camt052001.BankToCustomerAccountReportV13 {
        # owner  : ISO20022.Camt052001.Document
        + SplmtryData  : List~ISO20022.Camt052001.SupplementaryData1~
        + Rpt  : List~ISO20022.Camt052001.AccountReport37~
        + GrpHdr  : ISO20022.Camt052001.GroupHeader116
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Rpt""",Rpt),validList("""Rpt""",Rpt),validElement(Rpt),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt052001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|BkToCstmrAcctRpt|ISO20022.Camt052001.BankToCustomerAccountReportV13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BkToCstmrAcctRpt))|

---

## AspectImpl ISO20022.Camt052001.BankToCustomerAccountReportV13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt052001.Document||||
|+|SplmtryData|List<ISO20022.Camt052001.SupplementaryData1>||XmlElement()||
|+|Rpt|List<ISO20022.Camt052001.AccountReport37>||XmlElement()||
|+|GrpHdr|ISO20022.Camt052001.GroupHeader116||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Rpt""",Rpt),validList("""Rpt""",Rpt),validElement(Rpt),validElement(GrpHdr))|

