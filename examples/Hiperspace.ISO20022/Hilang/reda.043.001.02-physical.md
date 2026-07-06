# reda.043.001.02-physical
```mermaid
classDiagram
    class ISO20022.Reda043001.Document {
        # Uri  : String
        + PtyAudtTrlRpt () : ISO20022.Reda043001.PartyAuditTrailReportV02
        + Validation () = validation(validElement(PtyAudtTrlRpt))
    }
    class ISO20022.Reda043001.PartyAuditTrailReportV02 {
        # owner  : ISO20022.Reda043001.Document
        + SplmtryData  : List~ISO20022.Reda043001.SupplementaryData1~
        + RptOrErr  : ISO20022.Reda043001.PartyAuditTrailOrError3Choice
        + MsgHdr  : ISO20022.Reda043001.MessageHeader12
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

## EntityImpl ISO20022.Reda043001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PtyAudtTrlRpt|ISO20022.Reda043001.PartyAuditTrailReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyAudtTrlRpt))|

---

## AspectImpl ISO20022.Reda043001.PartyAuditTrailReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda043001.Document||||
|+|SplmtryData|List<ISO20022.Reda043001.SupplementaryData1>||XmlElement()||
|+|RptOrErr|ISO20022.Reda043001.PartyAuditTrailOrError3Choice||XmlElement()||
|+|MsgHdr|ISO20022.Reda043001.MessageHeader12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))|

