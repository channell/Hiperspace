# reda.033.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda033001.Document {
        # Uri  : String
        + SctiesAudtTrlQry () : ISO20022.Reda033001.SecuritiesAuditTrailQueryV01
        + Validation () = validation(validElement(SctiesAudtTrlQry))
    }
    class ISO20022.Reda033001.SecuritiesAuditTrailQueryV01 {
        # owner  : ISO20022.Reda033001.Document
        + SplmtryData  : List~ISO20022.Reda033001.SupplementaryData1~
        + SchCrit  : ISO20022.Reda033001.SecuritiesAuditTrailSearchCriteria4
        + MsgHdr  : ISO20022.Reda033001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SchCrit),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda033001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctiesAudtTrlQry|ISO20022.Reda033001.SecuritiesAuditTrailQueryV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesAudtTrlQry))|

---

## AspectImpl ISO20022.Reda033001.SecuritiesAuditTrailQueryV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda033001.Document||||
|+|SplmtryData|List<ISO20022.Reda033001.SupplementaryData1>||XmlElement()||
|+|SchCrit|ISO20022.Reda033001.SecuritiesAuditTrailSearchCriteria4||XmlElement()||
|+|MsgHdr|ISO20022.Reda033001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SchCrit),validElement(MsgHdr))|

