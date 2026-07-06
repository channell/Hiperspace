# reda.006.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda006001.Document {
        # Uri  : String
        + SctyCreReq () : ISO20022.Reda006001.SecurityCreationRequestV01
        + Validation () = validation(validElement(SctyCreReq))
    }
    class ISO20022.Reda006001.SecurityCreationRequestV01 {
        # owner  : ISO20022.Reda006001.Document
        + SplmtryData  : List~ISO20022.Reda006001.SupplementaryData1~
        + Scty  : ISO20022.Reda006001.SecurityAttributes10
        + MsgHdr  : ISO20022.Reda006001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Scty),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda006001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctyCreReq|ISO20022.Reda006001.SecurityCreationRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyCreReq))|

---

## AspectImpl ISO20022.Reda006001.SecurityCreationRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda006001.Document||||
|+|SplmtryData|List<ISO20022.Reda006001.SupplementaryData1>||XmlElement()||
|+|Scty|ISO20022.Reda006001.SecurityAttributes10||XmlElement()||
|+|MsgHdr|ISO20022.Reda006001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Scty),validElement(MsgHdr))|

