# reda.022.001.02-physical
```mermaid
classDiagram
    class ISO20022.Reda022001.Document {
        # Uri  : String
        + PtyModReq () : ISO20022.Reda022001.PartyModificationRequestV02
        + Validation () = validation(validElement(PtyModReq))
    }
    class ISO20022.Reda022001.PartyModificationRequestV02 {
        # owner  : ISO20022.Reda022001.Document
        + SplmtryData  : List~ISO20022.Reda022001.SupplementaryData1~
        + Mod  : List~ISO20022.Reda022001.SystemPartyModification3~
        + SysPtyId  : ISO20022.Reda022001.SystemPartyIdentification8
        + MsgHdr  : ISO20022.Reda022001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Mod""",Mod),validList("""Mod""",Mod),validElement(Mod),validElement(SysPtyId),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda022001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PtyModReq|ISO20022.Reda022001.PartyModificationRequestV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyModReq))|

---

## AspectImpl ISO20022.Reda022001.PartyModificationRequestV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda022001.Document||||
|+|SplmtryData|List<ISO20022.Reda022001.SupplementaryData1>||XmlElement()||
|+|Mod|List<ISO20022.Reda022001.SystemPartyModification3>||XmlElement()||
|+|SysPtyId|ISO20022.Reda022001.SystemPartyIdentification8||XmlElement()||
|+|MsgHdr|ISO20022.Reda022001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Mod""",Mod),validList("""Mod""",Mod),validElement(Mod),validElement(SysPtyId),validElement(MsgHdr))|

