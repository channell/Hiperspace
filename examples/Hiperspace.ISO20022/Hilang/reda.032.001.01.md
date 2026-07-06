# reda.032.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Reda032001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Reda032001.MessageHeader1 {
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    class ISO20022.Reda032001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Reda032001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Reda032001.SecuritiesAccount19 *-- ISO20022.Reda032001.GenericIdentification30
    class ISO20022.Reda032001.SecuritiesAccountDeletionRequestV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Reda032001.SupplementaryData1~
        + AcctId  : ISO20022.Reda032001.SecuritiesAccount19
        + MsgHdr  : ISO20022.Reda032001.MessageHeader1
    }
    ISO20022.Reda032001.SecuritiesAccountDeletionRequestV01 *-- ISO20022.Reda032001.SupplementaryData1
    ISO20022.Reda032001.SecuritiesAccountDeletionRequestV01 *-- ISO20022.Reda032001.SecuritiesAccount19
    ISO20022.Reda032001.SecuritiesAccountDeletionRequestV01 *-- ISO20022.Reda032001.MessageHeader1
    class ISO20022.Reda032001.SupplementaryData1 {
        + Envlp  : ISO20022.Reda032001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Reda032001.SupplementaryData1 *-- ISO20022.Reda032001.SupplementaryDataEnvelope1
    class ISO20022.Reda032001.SupplementaryDataEnvelope1 {
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

## Type ISO20022.Reda032001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesAcctDeltnReq|ISO20022.Reda032001.SecuritiesAccountDeletionRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesAcctDeltnReq))|

---

## Value ISO20022.Reda032001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Reda032001.MessageHeader1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda032001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Reda032001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Aspect ISO20022.Reda032001.SecuritiesAccountDeletionRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Reda032001.SupplementaryData1>||XmlElement()||
|+|AcctId|ISO20022.Reda032001.SecuritiesAccount19||XmlElement()||
|+|MsgHdr|ISO20022.Reda032001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AcctId),validElement(MsgHdr))|

---

## Value ISO20022.Reda032001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Reda032001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Reda032001.SupplementaryDataEnvelope1


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

