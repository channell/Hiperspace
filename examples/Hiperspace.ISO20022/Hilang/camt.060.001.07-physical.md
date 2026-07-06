# camt.060.001.07-physical
```mermaid
classDiagram
    class ISO20022.Camt060001.Document {
        # Uri  : String
        + AcctRptgReq () : ISO20022.Camt060001.AccountReportingRequestV07
        + Validation () = validation(validElement(AcctRptgReq))
    }
    class ISO20022.Camt060001.AccountReportingRequestV07 {
        # owner  : ISO20022.Camt060001.Document
        + SplmtryData  : List~ISO20022.Camt060001.SupplementaryData1~
        + RptgReq  : List~ISO20022.Camt060001.ReportingRequest7~
        + GrpHdr  : ISO20022.Camt060001.GroupHeader117
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RptgReq""",RptgReq),validList("""RptgReq""",RptgReq),validElement(RptgReq),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt060001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AcctRptgReq|ISO20022.Camt060001.AccountReportingRequestV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctRptgReq))|

---

## AspectImpl ISO20022.Camt060001.AccountReportingRequestV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt060001.Document||||
|+|SplmtryData|List<ISO20022.Camt060001.SupplementaryData1>||XmlElement()||
|+|RptgReq|List<ISO20022.Camt060001.ReportingRequest7>||XmlElement()||
|+|GrpHdr|ISO20022.Camt060001.GroupHeader117||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RptgReq""",RptgReq),validList("""RptgReq""",RptgReq),validElement(RptgReq),validElement(GrpHdr))|

