# camt.019.001.07-physical
```mermaid
classDiagram
    class ISO20022.Camt019001.Document {
        # Uri  : String
        + RtrBizDayInf () : ISO20022.Camt019001.ReturnBusinessDayInformationV07
        + Validation () = validation(validElement(RtrBizDayInf))
    }
    class ISO20022.Camt019001.ReturnBusinessDayInformationV07 {
        # owner  : ISO20022.Camt019001.Document
        + SplmtryData  : List~ISO20022.Camt019001.SupplementaryData1~
        + RptOrErr  : ISO20022.Camt019001.BusinessDayReportOrError9Choice
        + MsgHdr  : ISO20022.Camt019001.MessageHeader7
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt019001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RtrBizDayInf|ISO20022.Camt019001.ReturnBusinessDayInformationV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RtrBizDayInf))|

---

## AspectImpl ISO20022.Camt019001.ReturnBusinessDayInformationV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt019001.Document||||
|+|SplmtryData|List<ISO20022.Camt019001.SupplementaryData1>||XmlElement()||
|+|RptOrErr|ISO20022.Camt019001.BusinessDayReportOrError9Choice||XmlElement()||
|+|MsgHdr|ISO20022.Camt019001.MessageHeader7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))|

