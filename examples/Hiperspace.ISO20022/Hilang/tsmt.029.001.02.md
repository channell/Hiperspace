# tsmt.029.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Tsmt029001.BaselineStatus2Code {
        ACTV = 1
        CLSD = 2
        COMP = 3
    }
    class ISO20022.Tsmt029001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Tsmt029001.Reason2 {
        + Desc  : String
    }
    class ISO20022.Tsmt029001.SimpleIdentificationInformation {
        + Id  : String
    }
    class ISO20022.Tsmt029001.StatusChangeRequestRejectionV02 {
        + RjctnRsn  : ISO20022.Tsmt029001.Reason2
        + RjctdStsChng  : ISO20022.Tsmt029001.TransactionStatus3
        + SubmitrTxRef  : ISO20022.Tsmt029001.SimpleIdentificationInformation
        + TxId  : ISO20022.Tsmt029001.SimpleIdentificationInformation
        + RjctnId  : ISO20022.Tsmt029001.MessageIdentification1
    }
    ISO20022.Tsmt029001.StatusChangeRequestRejectionV02 *-- ISO20022.Tsmt029001.Reason2
    ISO20022.Tsmt029001.StatusChangeRequestRejectionV02 *-- ISO20022.Tsmt029001.TransactionStatus3
    ISO20022.Tsmt029001.StatusChangeRequestRejectionV02 *-- ISO20022.Tsmt029001.SimpleIdentificationInformation
    ISO20022.Tsmt029001.StatusChangeRequestRejectionV02 *-- ISO20022.Tsmt029001.SimpleIdentificationInformation
    ISO20022.Tsmt029001.StatusChangeRequestRejectionV02 *-- ISO20022.Tsmt029001.MessageIdentification1
    class ISO20022.Tsmt029001.TransactionStatus3 {
        + Sts  : String
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

## Enum ISO20022.Tsmt029001.BaselineStatus2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACTV|Int32||XmlEnum("""ACTV""")|1|
||CLSD|Int32||XmlEnum("""CLSD""")|2|
||COMP|Int32||XmlEnum("""COMP""")|3|

---

## Type ISO20022.Tsmt029001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StsChngReqRjctn|ISO20022.Tsmt029001.StatusChangeRequestRejectionV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StsChngReqRjctn))|

---

## Value ISO20022.Tsmt029001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt029001.Reason2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt029001.SimpleIdentificationInformation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Aspect ISO20022.Tsmt029001.StatusChangeRequestRejectionV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RjctnRsn|ISO20022.Tsmt029001.Reason2||XmlElement()||
|+|RjctdStsChng|ISO20022.Tsmt029001.TransactionStatus3||XmlElement()||
|+|SubmitrTxRef|ISO20022.Tsmt029001.SimpleIdentificationInformation||XmlElement()||
|+|TxId|ISO20022.Tsmt029001.SimpleIdentificationInformation||XmlElement()||
|+|RjctnId|ISO20022.Tsmt029001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RjctnRsn),validElement(RjctdStsChng),validElement(SubmitrTxRef),validElement(TxId),validElement(RjctnId))|

---

## Value ISO20022.Tsmt029001.TransactionStatus3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sts|String||XmlElement()||
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

