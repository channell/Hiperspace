# auth.003.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth003001.InformationRequestStatusChangeNotificationV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth003001.SupplementaryData1~
        + CnfdtltySts  : String
        + OrgnlBizQry  : String
    }
    ISO20022.Auth003001.InformationRequestStatusChangeNotificationV01 *-- ISO20022.Auth003001.SupplementaryData1
    class ISO20022.Auth003001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth003001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth003001.SupplementaryData1 *-- ISO20022.Auth003001.SupplementaryDataEnvelope1
    class ISO20022.Auth003001.SupplementaryDataEnvelope1 {
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

## Type ISO20022.Auth003001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InfReqStsChngNtfctn|ISO20022.Auth003001.InformationRequestStatusChangeNotificationV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InfReqStsChngNtfctn))|

---

## Aspect ISO20022.Auth003001.InformationRequestStatusChangeNotificationV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth003001.SupplementaryData1>||XmlElement()||
|+|CnfdtltySts|String||XmlElement()||
|+|OrgnlBizQry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData))|

---

## Value ISO20022.Auth003001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth003001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth003001.SupplementaryDataEnvelope1


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

