# reda.014.001.02-physical
```mermaid
classDiagram
    class ISO20022.Reda014001.Document {
        # Uri  : String
        + PtyCreReq () : ISO20022.Reda014001.PartyCreationRequestV02
        + Validation () = validation(validElement(PtyCreReq))
    }
    class ISO20022.Reda014001.PartyCreationRequestV02 {
        # owner  : ISO20022.Reda014001.Document
        + SplmtryData  : List~ISO20022.Reda014001.SupplementaryData1~
        + Pty  : ISO20022.Reda014001.SystemParty7
        + MsgHdr  : ISO20022.Reda014001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Pty),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PtyCreReq|ISO20022.Reda014001.PartyCreationRequestV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyCreReq))|

---

## AspectImpl ISO20022.Reda014001.PartyCreationRequestV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda014001.Document||||
|+|SplmtryData|List<ISO20022.Reda014001.SupplementaryData1>||XmlElement()||
|+|Pty|ISO20022.Reda014001.SystemParty7||XmlElement()||
|+|MsgHdr|ISO20022.Reda014001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Pty),validElement(MsgHdr))|

