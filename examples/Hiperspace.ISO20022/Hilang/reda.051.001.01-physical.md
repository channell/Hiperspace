# reda.051.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda051001.Document {
        # Uri  : String
        + AcctLkStsAdvc () : ISO20022.Reda051001.AccountLinkStatusAdviceV01
        + Validation () = validation(validElement(AcctLkStsAdvc))
    }
    class ISO20022.Reda051001.AccountLinkStatusAdviceV01 {
        # owner  : ISO20022.Reda051001.Document
        + SplmtryData  : List~ISO20022.Reda051001.SupplementaryData1~
        + AcctLkId  : ISO20022.Reda051001.AccountLink8
        + AcctLkSts  : ISO20022.Reda051001.AccountLinkStatus1
        + MsgHdr  : ISO20022.Reda051001.MessageHeader12
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AcctLkId),validElement(AcctLkSts),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda051001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AcctLkStsAdvc|ISO20022.Reda051001.AccountLinkStatusAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctLkStsAdvc))|

---

## AspectImpl ISO20022.Reda051001.AccountLinkStatusAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda051001.Document||||
|+|SplmtryData|List<ISO20022.Reda051001.SupplementaryData1>||XmlElement()||
|+|AcctLkId|ISO20022.Reda051001.AccountLink8||XmlElement()||
|+|AcctLkSts|ISO20022.Reda051001.AccountLinkStatus1||XmlElement()||
|+|MsgHdr|ISO20022.Reda051001.MessageHeader12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AcctLkId),validElement(AcctLkSts),validElement(MsgHdr))|

