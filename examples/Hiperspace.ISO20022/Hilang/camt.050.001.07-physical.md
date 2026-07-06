# camt.050.001.07-physical
```mermaid
classDiagram
    class ISO20022.Camt050001.Document {
        # Uri  : String
        + LqdtyCdtTrf () : ISO20022.Camt050001.LiquidityCreditTransferV07
        + Validation () = validation(validElement(LqdtyCdtTrf))
    }
    class ISO20022.Camt050001.LiquidityCreditTransferV07 {
        # owner  : ISO20022.Camt050001.Document
        + SplmtryData  : List~ISO20022.Camt050001.SupplementaryData1~
        + LqdtyCdtTrf  : ISO20022.Camt050001.LiquidityCreditTransfer4
        + MsgHdr  : ISO20022.Camt050001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(LqdtyCdtTrf),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt050001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|LqdtyCdtTrf|ISO20022.Camt050001.LiquidityCreditTransferV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LqdtyCdtTrf))|

---

## AspectImpl ISO20022.Camt050001.LiquidityCreditTransferV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt050001.Document||||
|+|SplmtryData|List<ISO20022.Camt050001.SupplementaryData1>||XmlElement()||
|+|LqdtyCdtTrf|ISO20022.Camt050001.LiquidityCreditTransfer4||XmlElement()||
|+|MsgHdr|ISO20022.Camt050001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(LqdtyCdtTrf),validElement(MsgHdr))|

