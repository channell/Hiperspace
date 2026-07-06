# reda.016.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda016001.Document {
        # Uri  : String
        + PtyStsAdvc () : ISO20022.Reda016001.PartyStatusAdviceV01
        + Validation () = validation(validElement(PtyStsAdvc))
    }
    class ISO20022.Reda016001.PartyStatusAdviceV01 {
        # owner  : ISO20022.Reda016001.Document
        + SplmtryData  : List~ISO20022.Reda016001.SupplementaryData1~
        + PtySts  : ISO20022.Reda016001.PartyStatus2
        + MsgHdr  : ISO20022.Reda016001.MessageHeader12
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(PtySts),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda016001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PtyStsAdvc|ISO20022.Reda016001.PartyStatusAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyStsAdvc))|

---

## AspectImpl ISO20022.Reda016001.PartyStatusAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda016001.Document||||
|+|SplmtryData|List<ISO20022.Reda016001.SupplementaryData1>||XmlElement()||
|+|PtySts|ISO20022.Reda016001.PartyStatus2||XmlElement()||
|+|MsgHdr|ISO20022.Reda016001.MessageHeader12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(PtySts),validElement(MsgHdr))|

