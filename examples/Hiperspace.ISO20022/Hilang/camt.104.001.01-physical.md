# camt.104.001.01-physical
```mermaid
classDiagram
    class ISO20022.Camt104001.Document {
        # Uri  : String
        + CretMmb () : ISO20022.Camt104001.CreateMemberV01
        + Validation () = validation(validElement(CretMmb))
    }
    class ISO20022.Camt104001.CreateMemberV01 {
        # owner  : ISO20022.Camt104001.Document
        + SplmtryData  : List~ISO20022.Camt104001.SupplementaryData1~
        + ValSet  : ISO20022.Camt104001.Member6
        + MmbId  : ISO20022.Camt104001.MemberIdentification3Choice
        + MsgHdr  : ISO20022.Camt104001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(ValSet),validElement(MmbId),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt104001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CretMmb|ISO20022.Camt104001.CreateMemberV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CretMmb))|

---

## AspectImpl ISO20022.Camt104001.CreateMemberV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt104001.Document||||
|+|SplmtryData|List<ISO20022.Camt104001.SupplementaryData1>||XmlElement()||
|+|ValSet|ISO20022.Camt104001.Member6||XmlElement()||
|+|MmbId|ISO20022.Camt104001.MemberIdentification3Choice||XmlElement()||
|+|MsgHdr|ISO20022.Camt104001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(ValSet),validElement(MmbId),validElement(MsgHdr))|

