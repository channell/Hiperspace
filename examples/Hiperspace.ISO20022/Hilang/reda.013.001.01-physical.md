# reda.013.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda013001.Document {
        # Uri  : String
        + SctyDeltnReq () : ISO20022.Reda013001.SecurityDeletionRequestV01
        + Validation () = validation(validElement(SctyDeltnReq))
    }
    class ISO20022.Reda013001.SecurityDeletionRequestV01 {
        # owner  : ISO20022.Reda013001.Document
        + SplmtryData  : List~ISO20022.Reda013001.SupplementaryData1~
        + FinInstrmId  : ISO20022.Reda013001.SecurityIdentification39
        + MsgHdr  : ISO20022.Reda013001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(FinInstrmId),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda013001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctyDeltnReq|ISO20022.Reda013001.SecurityDeletionRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyDeltnReq))|

---

## AspectImpl ISO20022.Reda013001.SecurityDeletionRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda013001.Document||||
|+|SplmtryData|List<ISO20022.Reda013001.SupplementaryData1>||XmlElement()||
|+|FinInstrmId|ISO20022.Reda013001.SecurityIdentification39||XmlElement()||
|+|MsgHdr|ISO20022.Reda013001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(FinInstrmId),validElement(MsgHdr))|

