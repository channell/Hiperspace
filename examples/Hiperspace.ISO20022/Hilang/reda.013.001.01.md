# reda.013.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Reda013001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Reda013001.MessageHeader1 {
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    class ISO20022.Reda013001.OtherIdentification1 {
        + Tp  : ISO20022.Reda013001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Reda013001.OtherIdentification1 *-- ISO20022.Reda013001.IdentificationSource3Choice
    class ISO20022.Reda013001.SecurityDeletionRequestV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Reda013001.SupplementaryData1~
        + FinInstrmId  : ISO20022.Reda013001.SecurityIdentification39
        + MsgHdr  : ISO20022.Reda013001.MessageHeader1
    }
    ISO20022.Reda013001.SecurityDeletionRequestV01 *-- ISO20022.Reda013001.SupplementaryData1
    ISO20022.Reda013001.SecurityDeletionRequestV01 *-- ISO20022.Reda013001.SecurityIdentification39
    ISO20022.Reda013001.SecurityDeletionRequestV01 *-- ISO20022.Reda013001.MessageHeader1
    class ISO20022.Reda013001.SecurityIdentification39 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Reda013001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Reda013001.SecurityIdentification39 *-- ISO20022.Reda013001.OtherIdentification1
    class ISO20022.Reda013001.SupplementaryData1 {
        + Envlp  : ISO20022.Reda013001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Reda013001.SupplementaryData1 *-- ISO20022.Reda013001.SupplementaryDataEnvelope1
    class ISO20022.Reda013001.SupplementaryDataEnvelope1 {
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

## Type ISO20022.Reda013001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyDeltnReq|ISO20022.Reda013001.SecurityDeletionRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyDeltnReq))|

---

## Value ISO20022.Reda013001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda013001.MessageHeader1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda013001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Reda013001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Aspect ISO20022.Reda013001.SecurityDeletionRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Reda013001.SupplementaryData1>||XmlElement()||
|+|FinInstrmId|ISO20022.Reda013001.SecurityIdentification39||XmlElement()||
|+|MsgHdr|ISO20022.Reda013001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(FinInstrmId),validElement(MsgHdr))|

---

## Value ISO20022.Reda013001.SecurityIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Reda013001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Reda013001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Reda013001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Reda013001.SupplementaryDataEnvelope1


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

