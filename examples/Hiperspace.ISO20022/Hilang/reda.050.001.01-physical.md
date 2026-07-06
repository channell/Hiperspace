# reda.050.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda050001.Document {
        # Uri  : String
        + AcctLkMntncReq () : ISO20022.Reda050001.AccountLinkMaintenanceRequestV01
        + Validation () = validation(validElement(AcctLkMntncReq))
    }
    class ISO20022.Reda050001.AccountLinkMaintenanceRequestV01 {
        # owner  : ISO20022.Reda050001.Document
        + SplmtryData  : List~ISO20022.Reda050001.SupplementaryData1~
        + Upd  : ISO20022.Reda050001.AccountLinkUpdate2
        + AcctLkId  : ISO20022.Reda050001.AccountLink8
        + MsgHdr  : ISO20022.Reda050001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Upd),validElement(AcctLkId),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda050001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AcctLkMntncReq|ISO20022.Reda050001.AccountLinkMaintenanceRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctLkMntncReq))|

---

## AspectImpl ISO20022.Reda050001.AccountLinkMaintenanceRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda050001.Document||||
|+|SplmtryData|List<ISO20022.Reda050001.SupplementaryData1>||XmlElement()||
|+|Upd|ISO20022.Reda050001.AccountLinkUpdate2||XmlElement()||
|+|AcctLkId|ISO20022.Reda050001.AccountLink8||XmlElement()||
|+|MsgHdr|ISO20022.Reda050001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Upd),validElement(AcctLkId),validElement(MsgHdr))|

