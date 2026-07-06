# acmt.034.001.05-physical
```mermaid
classDiagram
    class ISO20022.Acmt034001.Document {
        # Uri  : String
        + AcctSwtchReqPmt () : ISO20022.Acmt034001.AccountSwitchRequestPaymentV05
        + Validation () = validation(validElement(AcctSwtchReqPmt))
    }
    class ISO20022.Acmt034001.AccountSwitchRequestPaymentV05 {
        # owner  : ISO20022.Acmt034001.Document
        + SplmtryData  : List~ISO20022.Acmt034001.SupplementaryData1~
        + CdtInstr  : ISO20022.Acmt034001.CreditTransferTransaction59
        + OdAcct  : ISO20022.Acmt034001.CashAccount43
        + AcctSwtchDtls  : ISO20022.Acmt034001.AccountSwitchDetails1
        + MsgId  : ISO20022.Acmt034001.MessageIdentification1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CdtInstr),validElement(OdAcct),validElement(AcctSwtchDtls),validElement(MsgId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Acmt034001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AcctSwtchReqPmt|ISO20022.Acmt034001.AccountSwitchRequestPaymentV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSwtchReqPmt))|

---

## AspectImpl ISO20022.Acmt034001.AccountSwitchRequestPaymentV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Acmt034001.Document||||
|+|SplmtryData|List<ISO20022.Acmt034001.SupplementaryData1>||XmlElement()||
|+|CdtInstr|ISO20022.Acmt034001.CreditTransferTransaction59||XmlElement()||
|+|OdAcct|ISO20022.Acmt034001.CashAccount43||XmlElement()||
|+|AcctSwtchDtls|ISO20022.Acmt034001.AccountSwitchDetails1||XmlElement()||
|+|MsgId|ISO20022.Acmt034001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CdtInstr),validElement(OdAcct),validElement(AcctSwtchDtls),validElement(MsgId))|

