# camt.013.001.04-physical
```mermaid
classDiagram
    class ISO20022.Camt013001.Document {
        # Uri  : String
        + GetMmb () : ISO20022.Camt013001.GetMemberV04
        + Validation () = validation(validElement(GetMmb))
    }
    class ISO20022.Camt013001.GetMemberV04 {
        # owner  : ISO20022.Camt013001.Document
        + SplmtryData  : List~ISO20022.Camt013001.SupplementaryData1~
        + MmbQryDef  : ISO20022.Camt013001.MemberQueryDefinition4
        + MsgHdr  : ISO20022.Camt013001.MessageHeader9
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(MmbQryDef),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt013001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|GetMmb|ISO20022.Camt013001.GetMemberV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GetMmb))|

---

## AspectImpl ISO20022.Camt013001.GetMemberV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt013001.Document||||
|+|SplmtryData|List<ISO20022.Camt013001.SupplementaryData1>||XmlElement()||
|+|MmbQryDef|ISO20022.Camt013001.MemberQueryDefinition4||XmlElement()||
|+|MsgHdr|ISO20022.Camt013001.MessageHeader9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(MmbQryDef),validElement(MsgHdr))|

