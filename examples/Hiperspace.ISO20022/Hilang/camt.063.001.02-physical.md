# camt.063.001.02-physical
```mermaid
classDiagram
    class ISO20022.Camt063001.Document {
        # Uri  : String
        + PayInEvtAck () : ISO20022.Camt063001.PayInEventAcknowledgementV02
        + Validation () = validation(validElement(PayInEvtAck))
    }
    class ISO20022.Camt063001.PayInEventAcknowledgementV02 {
        # owner  : ISO20022.Camt063001.Document
        + SplmtryData  : List~ISO20022.Camt063001.SupplementaryData1~
        + AckDtls  : ISO20022.Camt063001.AcknowledgementDetails1Choice
        + SttlmSsnIdr  : String
        + MsgId  : String
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AckDtls),validPattern("""SttlmSsnIdr""",SttlmSsnIdr,"""[a-zA-Z0-9]{4}"""))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt063001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PayInEvtAck|ISO20022.Camt063001.PayInEventAcknowledgementV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PayInEvtAck))|

---

## AspectImpl ISO20022.Camt063001.PayInEventAcknowledgementV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt063001.Document||||
|+|SplmtryData|List<ISO20022.Camt063001.SupplementaryData1>||XmlElement()||
|+|AckDtls|ISO20022.Camt063001.AcknowledgementDetails1Choice||XmlElement()||
|+|SttlmSsnIdr|String||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AckDtls),validPattern("""SttlmSsnIdr""",SttlmSsnIdr,"""[a-zA-Z0-9]{4}"""))|

