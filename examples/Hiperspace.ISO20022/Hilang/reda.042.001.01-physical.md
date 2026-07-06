# reda.042.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda042001.Document {
        # Uri  : String
        + PtyAudtTrlQry () : ISO20022.Reda042001.PartyAuditTrailQueryV01
        + Validation () = validation(validElement(PtyAudtTrlQry))
    }
    class ISO20022.Reda042001.PartyAuditTrailQueryV01 {
        # owner  : ISO20022.Reda042001.Document
        + SplmtryData  : List~ISO20022.Reda042001.SupplementaryData1~
        + SchCrit  : ISO20022.Reda042001.PartyAuditTrailSearchCriteria2
        + MsgHdr  : ISO20022.Reda042001.MessageHeader1
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

## EntityImpl ISO20022.Reda042001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PtyAudtTrlQry|ISO20022.Reda042001.PartyAuditTrailQueryV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyAudtTrlQry))|

---

## AspectImpl ISO20022.Reda042001.PartyAuditTrailQueryV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda042001.Document||||
|+|SplmtryData|List<ISO20022.Reda042001.SupplementaryData1>||XmlElement()||
|+|SchCrit|ISO20022.Reda042001.PartyAuditTrailSearchCriteria2||XmlElement()||
|+|MsgHdr|ISO20022.Reda042001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SchCrit),validElement(MsgHdr))|

