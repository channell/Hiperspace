# camt.063.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt063001.AcknowledgementDetails1Choice {
        + PayInCallRef  : String
        + PayInSchdlRef  : String
    }
    class ISO20022.Camt063001.PayInEventAcknowledgementV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt063001.SupplementaryData1~
        + AckDtls  : ISO20022.Camt063001.AcknowledgementDetails1Choice
        + SttlmSsnIdr  : String
        + MsgId  : String
    }
    ISO20022.Camt063001.PayInEventAcknowledgementV02 *-- ISO20022.Camt063001.SupplementaryData1
    ISO20022.Camt063001.PayInEventAcknowledgementV02 *-- ISO20022.Camt063001.AcknowledgementDetails1Choice
    class ISO20022.Camt063001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt063001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt063001.SupplementaryData1 *-- ISO20022.Camt063001.SupplementaryDataEnvelope1
    class ISO20022.Camt063001.SupplementaryDataEnvelope1 {
    }
    class Hiperspace.Node {
        # SKey  : String
        + TypeName  : String
        + Name  : String
        + Froms (From = this) : Hiperspace.Edge
        + Tos (To = this) : Hiperspace.Edge
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## View Hiperspace.Edge
edge between nodes

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Hiperspace.Node||||
|#|To|Hiperspace.Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## Value ISO20022.Camt063001.AcknowledgementDetails1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PayInCallRef|String||XmlElement()||
|+|PayInSchdlRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(PayInCallRef,PayInSchdlRef))|

---

## Type ISO20022.Camt063001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PayInEvtAck|ISO20022.Camt063001.PayInEventAcknowledgementV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PayInEvtAck))|

---

## Aspect ISO20022.Camt063001.PayInEventAcknowledgementV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt063001.SupplementaryData1>||XmlElement()||
|+|AckDtls|ISO20022.Camt063001.AcknowledgementDetails1Choice||XmlElement()||
|+|SttlmSsnIdr|String||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AckDtls),validPattern("""SttlmSsnIdr""",SttlmSsnIdr,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt063001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt063001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt063001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## View Hiperspace.Node
node in a graph view of data

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|SKey|String||||
|+|TypeName|String||||
|+|Name|String||||
||Froms|Hiperspace.Edge|||From = this|
||Tos|Hiperspace.Edge|||To = this|

