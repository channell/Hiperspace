# reda.031.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda031001.Document {
        # Uri  : String
        + PtyDeltnReq () : ISO20022.Reda031001.PartyDeletionRequestV01
        + Validation () = validation(validElement(PtyDeltnReq))
    }
    class ISO20022.Reda031001.PartyDeletionRequestV01 {
        # owner  : ISO20022.Reda031001.Document
        + SplmtryData  : List~ISO20022.Reda031001.SupplementaryData1~
        + SysPtyId  : ISO20022.Reda031001.SystemPartyIdentification8
        + MsgHdr  : ISO20022.Reda031001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SysPtyId),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda031001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PtyDeltnReq|ISO20022.Reda031001.PartyDeletionRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyDeltnReq))|

---

## AspectImpl ISO20022.Reda031001.PartyDeletionRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda031001.Document||||
|+|SplmtryData|List<ISO20022.Reda031001.SupplementaryData1>||XmlElement()||
|+|SysPtyId|ISO20022.Reda031001.SystemPartyIdentification8||XmlElement()||
|+|MsgHdr|ISO20022.Reda031001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SysPtyId),validElement(MsgHdr))|

