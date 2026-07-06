# reda.021.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda021001.Document {
        # Uri  : String
        + SctiesAcctRpt () : ISO20022.Reda021001.SecuritiesAccountReportV01
        + Validation () = validation(validElement(SctiesAcctRpt))
    }
    class ISO20022.Reda021001.SecuritiesAccountReportV01 {
        # owner  : ISO20022.Reda021001.Document
        + SplmtryData  : List~ISO20022.Reda021001.SupplementaryData1~
        + RptOrErr  : ISO20022.Reda021001.SecuritiesAccountOrOperationalError3Choice
        + Pgntn  : ISO20022.Reda021001.Pagination1
        + MsgHdr  : ISO20022.Reda021001.MessageHeader3
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(Pgntn),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda021001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctiesAcctRpt|ISO20022.Reda021001.SecuritiesAccountReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesAcctRpt))|

---

## AspectImpl ISO20022.Reda021001.SecuritiesAccountReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda021001.Document||||
|+|SplmtryData|List<ISO20022.Reda021001.SupplementaryData1>||XmlElement()||
|+|RptOrErr|ISO20022.Reda021001.SecuritiesAccountOrOperationalError3Choice||XmlElement()||
|+|Pgntn|ISO20022.Reda021001.Pagination1||XmlElement()||
|+|MsgHdr|ISO20022.Reda021001.MessageHeader3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(Pgntn),validElement(MsgHdr))|

