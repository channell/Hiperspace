# tsmt.004.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Tsmt004001.ActivityReportSetUpRequestV02 {
        + UTCOffset  : ISO20022.Tsmt004001.UTCOffset1
        + ReqId  : ISO20022.Tsmt004001.MessageIdentification1
    }
    ISO20022.Tsmt004001.ActivityReportSetUpRequestV02 *-- ISO20022.Tsmt004001.UTCOffset1
    ISO20022.Tsmt004001.ActivityReportSetUpRequestV02 *-- ISO20022.Tsmt004001.MessageIdentification1
    class ISO20022.Tsmt004001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Tsmt004001.UTCOffset1 {
        + NbOfHrs  : DateTime
        + Sgn  : String
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

## Aspect ISO20022.Tsmt004001.ActivityReportSetUpRequestV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UTCOffset|ISO20022.Tsmt004001.UTCOffset1||XmlElement()||
|+|ReqId|ISO20022.Tsmt004001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UTCOffset),validElement(ReqId))|

---

## Type ISO20022.Tsmt004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ActvtyRptSetUpReq|ISO20022.Tsmt004001.ActivityReportSetUpRequestV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ActvtyRptSetUpReq))|

---

## Value ISO20022.Tsmt004001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt004001.UTCOffset1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NbOfHrs|DateTime||XmlElement()||
|+|Sgn|String||XmlElement()||
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

