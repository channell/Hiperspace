# camt.102.001.03-physical
```mermaid
classDiagram
    class ISO20022.Camt102001.Document {
        # Uri  : String
        + CretStgOrdr () : ISO20022.Camt102001.CreateStandingOrderV03
        + Validation () = validation(validElement(CretStgOrdr))
    }
    class ISO20022.Camt102001.CreateStandingOrderV03 {
        # owner  : ISO20022.Camt102001.Document
        + SplmtryData  : List~ISO20022.Camt102001.SupplementaryData1~
        + ValSet  : ISO20022.Camt102001.StandingOrder10
        + StgOrdrId  : ISO20022.Camt102001.StandingOrderIdentification8
        + MsgHdr  : ISO20022.Camt102001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(ValSet),validElement(StgOrdrId),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt102001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CretStgOrdr|ISO20022.Camt102001.CreateStandingOrderV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CretStgOrdr))|

---

## AspectImpl ISO20022.Camt102001.CreateStandingOrderV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt102001.Document||||
|+|SplmtryData|List<ISO20022.Camt102001.SupplementaryData1>||XmlElement()||
|+|ValSet|ISO20022.Camt102001.StandingOrder10||XmlElement()||
|+|StgOrdrId|ISO20022.Camt102001.StandingOrderIdentification8||XmlElement()||
|+|MsgHdr|ISO20022.Camt102001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(ValSet),validElement(StgOrdrId),validElement(MsgHdr))|

