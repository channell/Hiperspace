# reda.024.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda024001.Document {
        # Uri  : String
        + CollValCreReq () : ISO20022.Reda024001.CollateralValueCreationRequestV01
        + Validation () = validation(validElement(CollValCreReq))
    }
    class ISO20022.Reda024001.CollateralValueCreationRequestV01 {
        # owner  : ISO20022.Reda024001.Document
        + SplmtryData  : List~ISO20022.Reda024001.SupplementaryData1~
        + PtyId  : ISO20022.Reda024001.SystemPartyIdentification2Choice
        + CollVal  : List~ISO20022.Reda024001.CollateralValue5~
        + MsgHdr  : ISO20022.Reda024001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(PtyId),validRequired("""CollVal""",CollVal),validList("""CollVal""",CollVal),validElement(CollVal),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda024001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CollValCreReq|ISO20022.Reda024001.CollateralValueCreationRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollValCreReq))|

---

## AspectImpl ISO20022.Reda024001.CollateralValueCreationRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda024001.Document||||
|+|SplmtryData|List<ISO20022.Reda024001.SupplementaryData1>||XmlElement()||
|+|PtyId|ISO20022.Reda024001.SystemPartyIdentification2Choice||XmlElement()||
|+|CollVal|List<ISO20022.Reda024001.CollateralValue5>||XmlElement()||
|+|MsgHdr|ISO20022.Reda024001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(PtyId),validRequired("""CollVal""",CollVal),validList("""CollVal""",CollVal),validElement(CollVal),validElement(MsgHdr))|

