# admi.007.001.01-physical
```mermaid
classDiagram
    class ISO20022.Admi007001.Document {
        # Uri  : String
        + RctAck () : ISO20022.Admi007001.ReceiptAcknowledgementV01
        + Validation () = validation(validElement(RctAck))
    }
    class ISO20022.Admi007001.ReceiptAcknowledgementV01 {
        # owner  : ISO20022.Admi007001.Document
        + SplmtryData  : List~ISO20022.Admi007001.SupplementaryData1~
        + Rpt  : List~ISO20022.Admi007001.ReceiptAcknowledgementReport2~
        + MsgId  : ISO20022.Admi007001.MessageHeader10
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Rpt""",Rpt),validList("""Rpt""",Rpt),validElement(Rpt),validElement(MsgId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Admi007001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RctAck|ISO20022.Admi007001.ReceiptAcknowledgementV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RctAck))|

---

## AspectImpl ISO20022.Admi007001.ReceiptAcknowledgementV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Admi007001.Document||||
|+|SplmtryData|List<ISO20022.Admi007001.SupplementaryData1>||XmlElement()||
|+|Rpt|List<ISO20022.Admi007001.ReceiptAcknowledgementReport2>||XmlElement()||
|+|MsgId|ISO20022.Admi007001.MessageHeader10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Rpt""",Rpt),validList("""Rpt""",Rpt),validElement(Rpt),validElement(MsgId))|

