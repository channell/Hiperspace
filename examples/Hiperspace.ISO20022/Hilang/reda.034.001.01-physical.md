# reda.034.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda034001.Document {
        # Uri  : String
        + SctiesAudtTrlRpt () : ISO20022.Reda034001.SecuritiesAuditTrailReportV01
        + Validation () = validation(validElement(SctiesAudtTrlRpt))
    }
    class ISO20022.Reda034001.SecuritiesAuditTrailReportV01 {
        # owner  : ISO20022.Reda034001.Document
        + SplmtryData  : List~ISO20022.Reda034001.SupplementaryData1~
        + RptOrErr  : ISO20022.Reda034001.SecuritiesAuditTrailOrOperationalError4Choice
        + MsgHdr  : ISO20022.Reda034001.MessageHeader12
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

## EntityImpl ISO20022.Reda034001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctiesAudtTrlRpt|ISO20022.Reda034001.SecuritiesAuditTrailReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesAudtTrlRpt))|

---

## AspectImpl ISO20022.Reda034001.SecuritiesAuditTrailReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda034001.Document||||
|+|SplmtryData|List<ISO20022.Reda034001.SupplementaryData1>||XmlElement()||
|+|RptOrErr|ISO20022.Reda034001.SecuritiesAuditTrailOrOperationalError4Choice||XmlElement()||
|+|MsgHdr|ISO20022.Reda034001.MessageHeader12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))|

