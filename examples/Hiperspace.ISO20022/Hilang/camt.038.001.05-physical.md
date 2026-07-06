# camt.038.001.05-physical
```mermaid
classDiagram
    class ISO20022.Camt038001.Document {
        # Uri  : String
        + CaseStsRptReq () : ISO20022.Camt038001.CaseStatusReportRequestV05
        + Validation () = validation(validElement(CaseStsRptReq))
    }
    class ISO20022.Camt038001.CaseStatusReportRequestV05 {
        # owner  : ISO20022.Camt038001.Document
        + SplmtryData  : List~ISO20022.Camt038001.SupplementaryData1~
        + Case  : ISO20022.Camt038001.Case6
        + ReqHdr  : ISO20022.Camt038001.ReportHeader7
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Case),validElement(ReqHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt038001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CaseStsRptReq|ISO20022.Camt038001.CaseStatusReportRequestV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CaseStsRptReq))|

---

## AspectImpl ISO20022.Camt038001.CaseStatusReportRequestV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt038001.Document||||
|+|SplmtryData|List<ISO20022.Camt038001.SupplementaryData1>||XmlElement()||
|+|Case|ISO20022.Camt038001.Case6||XmlElement()||
|+|ReqHdr|ISO20022.Camt038001.ReportHeader7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Case),validElement(ReqHdr))|

