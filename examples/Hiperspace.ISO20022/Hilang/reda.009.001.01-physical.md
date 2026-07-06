# reda.009.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda009001.Document {
        # Uri  : String
        + SctyActvtyAdvc () : ISO20022.Reda009001.SecurityActivityAdviceV01
        + Validation () = validation(validElement(SctyActvtyAdvc))
    }
    class ISO20022.Reda009001.SecurityActivityAdviceV01 {
        # owner  : ISO20022.Reda009001.Document
        + SplmtryData  : List~ISO20022.Reda009001.SupplementaryData1~
        + SctyActvty  : ISO20022.Reda009001.SecurityStatement3
        + Pgntn  : ISO20022.Reda009001.Pagination1
        + MsgHdr  : ISO20022.Reda009001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SctyActvty),validElement(Pgntn),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda009001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctyActvtyAdvc|ISO20022.Reda009001.SecurityActivityAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyActvtyAdvc))|

---

## AspectImpl ISO20022.Reda009001.SecurityActivityAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda009001.Document||||
|+|SplmtryData|List<ISO20022.Reda009001.SupplementaryData1>||XmlElement()||
|+|SctyActvty|ISO20022.Reda009001.SecurityStatement3||XmlElement()||
|+|Pgntn|ISO20022.Reda009001.Pagination1||XmlElement()||
|+|MsgHdr|ISO20022.Reda009001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SctyActvty),validElement(Pgntn),validElement(MsgHdr))|

