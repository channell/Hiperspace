# camt.015.001.04-physical
```mermaid
classDiagram
    class ISO20022.Camt015001.Document {
        # Uri  : String
        + ModfyMmb () : ISO20022.Camt015001.ModifyMemberV04
        + Validation () = validation(validElement(ModfyMmb))
    }
    class ISO20022.Camt015001.ModifyMemberV04 {
        # owner  : ISO20022.Camt015001.Document
        + SplmtryData  : List~ISO20022.Camt015001.SupplementaryData1~
        + NewMmbValSet  : ISO20022.Camt015001.Member6
        + MmbId  : ISO20022.Camt015001.MemberIdentification3Choice
        + MsgHdr  : ISO20022.Camt015001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(NewMmbValSet),validElement(MmbId),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt015001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ModfyMmb|ISO20022.Camt015001.ModifyMemberV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ModfyMmb))|

---

## AspectImpl ISO20022.Camt015001.ModifyMemberV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt015001.Document||||
|+|SplmtryData|List<ISO20022.Camt015001.SupplementaryData1>||XmlElement()||
|+|NewMmbValSet|ISO20022.Camt015001.Member6||XmlElement()||
|+|MmbId|ISO20022.Camt015001.MemberIdentification3Choice||XmlElement()||
|+|MsgHdr|ISO20022.Camt015001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(NewMmbValSet),validElement(MmbId),validElement(MsgHdr))|

