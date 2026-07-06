# camt.039.001.06-physical
```mermaid
classDiagram
    class ISO20022.Camt039001.Document {
        # Uri  : String
        + CaseStsRpt () : ISO20022.Camt039001.CaseStatusReportV06
        + Validation () = validation(validElement(CaseStsRpt))
    }
    class ISO20022.Camt039001.CaseStatusReportV06 {
        # owner  : ISO20022.Camt039001.Document
        + SplmtryData  : List~ISO20022.Camt039001.SupplementaryData1~
        + NewAssgnmt  : ISO20022.Camt039001.CaseAssignment6
        + Sts  : ISO20022.Camt039001.CaseStatus2
        + Case  : ISO20022.Camt039001.Case6
        + Hdr  : ISO20022.Camt039001.ReportHeader7
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(NewAssgnmt),validElement(Sts),validElement(Case),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt039001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CaseStsRpt|ISO20022.Camt039001.CaseStatusReportV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CaseStsRpt))|

---

## AspectImpl ISO20022.Camt039001.CaseStatusReportV06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt039001.Document||||
|+|SplmtryData|List<ISO20022.Camt039001.SupplementaryData1>||XmlElement()||
|+|NewAssgnmt|ISO20022.Camt039001.CaseAssignment6||XmlElement()||
|+|Sts|ISO20022.Camt039001.CaseStatus2||XmlElement()||
|+|Case|ISO20022.Camt039001.Case6||XmlElement()||
|+|Hdr|ISO20022.Camt039001.ReportHeader7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(NewAssgnmt),validElement(Sts),validElement(Case),validElement(Hdr))|

