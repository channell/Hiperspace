# reda.020.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda020001.Document {
        # Uri  : String
        + SctiesAcctStsAdvc () : ISO20022.Reda020001.SecuritiesAccountStatusAdviceV01
        + Validation () = validation(validElement(SctiesAcctStsAdvc))
    }
    class ISO20022.Reda020001.SecuritiesAccountStatusAdviceV01 {
        # owner  : ISO20022.Reda020001.Document
        + SplmtryData  : List~ISO20022.Reda020001.SupplementaryData1~
        + SctiesAcctSts  : ISO20022.Reda020001.SecuritiesAccountStatus2
        + MsgHdr  : ISO20022.Reda020001.MessageHeader12
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SctiesAcctSts),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda020001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctiesAcctStsAdvc|ISO20022.Reda020001.SecuritiesAccountStatusAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesAcctStsAdvc))|

---

## AspectImpl ISO20022.Reda020001.SecuritiesAccountStatusAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda020001.Document||||
|+|SplmtryData|List<ISO20022.Reda020001.SupplementaryData1>||XmlElement()||
|+|SctiesAcctSts|ISO20022.Reda020001.SecuritiesAccountStatus2||XmlElement()||
|+|MsgHdr|ISO20022.Reda020001.MessageHeader12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SctiesAcctSts),validElement(MsgHdr))|

