# acmt.037.001.02-physical
```mermaid
classDiagram
    class ISO20022.Acmt037001.Document {
        # Uri  : String
        + AcctSwtchTechRjctn () : ISO20022.Acmt037001.AccountSwitchTechnicalRejectionV02
        + Validation () = validation(validElement(AcctSwtchTechRjctn))
    }
    class ISO20022.Acmt037001.AccountSwitchTechnicalRejectionV02 {
        # owner  : ISO20022.Acmt037001.Document
        + SplmtryData  : List~ISO20022.Acmt037001.SupplementaryData1~
        + AcctSwtchDtls  : ISO20022.Acmt037001.AccountSwitchDetails1
        + MsgId  : ISO20022.Acmt037001.MessageIdentification1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AcctSwtchDtls),validElement(MsgId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Acmt037001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AcctSwtchTechRjctn|ISO20022.Acmt037001.AccountSwitchTechnicalRejectionV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSwtchTechRjctn))|

---

## AspectImpl ISO20022.Acmt037001.AccountSwitchTechnicalRejectionV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Acmt037001.Document||||
|+|SplmtryData|List<ISO20022.Acmt037001.SupplementaryData1>||XmlElement()||
|+|AcctSwtchDtls|ISO20022.Acmt037001.AccountSwitchDetails1||XmlElement()||
|+|MsgId|ISO20022.Acmt037001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AcctSwtchDtls),validElement(MsgId))|

