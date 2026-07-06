# reda.041.001.02-physical
```mermaid
classDiagram
    class ISO20022.Reda041001.Document {
        # Uri  : String
        + PtyActvtyAdvc () : ISO20022.Reda041001.PartyActivityAdviceV02
        + Validation () = validation(validElement(PtyActvtyAdvc))
    }
    class ISO20022.Reda041001.PartyActivityAdviceV02 {
        # owner  : ISO20022.Reda041001.Document
        + SplmtryData  : List~ISO20022.Reda041001.SupplementaryData1~
        + PtyActvty  : ISO20022.Reda041001.PartyStatement3
        + MsgHdr  : ISO20022.Reda041001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(PtyActvty),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda041001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PtyActvtyAdvc|ISO20022.Reda041001.PartyActivityAdviceV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyActvtyAdvc))|

---

## AspectImpl ISO20022.Reda041001.PartyActivityAdviceV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda041001.Document||||
|+|SplmtryData|List<ISO20022.Reda041001.SupplementaryData1>||XmlElement()||
|+|PtyActvty|ISO20022.Reda041001.PartyStatement3||XmlElement()||
|+|MsgHdr|ISO20022.Reda041001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(PtyActvty),validElement(MsgHdr))|

