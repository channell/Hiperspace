# acmt.027.001.05-physical
```mermaid
classDiagram
    class ISO20022.Acmt027001.Document {
        # Uri  : String
        + AcctSwtchInfReq () : ISO20022.Acmt027001.AccountSwitchInformationRequestV05
        + Validation () = validation(validElement(AcctSwtchInfReq))
    }
    class ISO20022.Acmt027001.AccountSwitchInformationRequestV05 {
        # owner  : ISO20022.Acmt027001.Document
        + SplmtryData  : List~ISO20022.Acmt027001.SupplementaryData1~
        + BalTrf  : List~ISO20022.Acmt027001.BalanceTransfer5~
        + OdAcct  : ISO20022.Acmt027001.CashAccount43
        + NewAcct  : ISO20022.Acmt027001.NewAccount4
        + AcctSwtchDtls  : ISO20022.Acmt027001.AccountSwitchDetails1
        + MsgId  : ISO20022.Acmt027001.MessageIdentification1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""BalTrf""",BalTrf),validElement(BalTrf),validElement(OdAcct),validElement(NewAcct),validElement(AcctSwtchDtls),validElement(MsgId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Acmt027001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AcctSwtchInfReq|ISO20022.Acmt027001.AccountSwitchInformationRequestV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSwtchInfReq))|

---

## AspectImpl ISO20022.Acmt027001.AccountSwitchInformationRequestV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Acmt027001.Document||||
|+|SplmtryData|List<ISO20022.Acmt027001.SupplementaryData1>||XmlElement()||
|+|BalTrf|List<ISO20022.Acmt027001.BalanceTransfer5>||XmlElement()||
|+|OdAcct|ISO20022.Acmt027001.CashAccount43||XmlElement()||
|+|NewAcct|ISO20022.Acmt027001.NewAccount4||XmlElement()||
|+|AcctSwtchDtls|ISO20022.Acmt027001.AccountSwitchDetails1||XmlElement()||
|+|MsgId|ISO20022.Acmt027001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""BalTrf""",BalTrf),validElement(BalTrf),validElement(OdAcct),validElement(NewAcct),validElement(AcctSwtchDtls),validElement(MsgId))|

