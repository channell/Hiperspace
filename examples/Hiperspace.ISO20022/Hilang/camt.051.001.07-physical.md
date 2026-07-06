# camt.051.001.07-physical
```mermaid
classDiagram
    class ISO20022.Camt051001.Document {
        # Uri  : String
        + LqdtyDbtTrf () : ISO20022.Camt051001.LiquidityDebitTransferV07
        + Validation () = validation(validElement(LqdtyDbtTrf))
    }
    class ISO20022.Camt051001.LiquidityDebitTransferV07 {
        # owner  : ISO20022.Camt051001.Document
        + SplmtryData  : List~ISO20022.Camt051001.SupplementaryData1~
        + LqdtyDbtTrf  : ISO20022.Camt051001.LiquidityDebitTransfer4
        + MsgHdr  : ISO20022.Camt051001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(LqdtyDbtTrf),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt051001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|LqdtyDbtTrf|ISO20022.Camt051001.LiquidityDebitTransferV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LqdtyDbtTrf))|

---

## AspectImpl ISO20022.Camt051001.LiquidityDebitTransferV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt051001.Document||||
|+|SplmtryData|List<ISO20022.Camt051001.SupplementaryData1>||XmlElement()||
|+|LqdtyDbtTrf|ISO20022.Camt051001.LiquidityDebitTransfer4||XmlElement()||
|+|MsgHdr|ISO20022.Camt051001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(LqdtyDbtTrf),validElement(MsgHdr))|

