# tsmt.031.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Tsmt031001.BaselineStatus3Code {
        DARQ = 1
        SERQ = 2
        SCRQ = 3
        CLRQ = 4
        RARQ = 5
        AMRQ = 6
        COMP = 7
        ACTV = 8
        ESTD = 9
        PMTC = 10
        CLSD = 11
        PROP = 12
    }
    class ISO20022.Tsmt031001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Tsmt031001.SimpleIdentificationInformation {
        + Id  : String
    }
    class ISO20022.Tsmt031001.StatusExtensionRequestAcceptanceV03 {
        + XtndedSts  : ISO20022.Tsmt031001.TransactionStatus4
        + SubmitrTxRef  : ISO20022.Tsmt031001.SimpleIdentificationInformation
        + TxId  : ISO20022.Tsmt031001.SimpleIdentificationInformation
        + AccptncId  : ISO20022.Tsmt031001.MessageIdentification1
    }
    ISO20022.Tsmt031001.StatusExtensionRequestAcceptanceV03 *-- ISO20022.Tsmt031001.TransactionStatus4
    ISO20022.Tsmt031001.StatusExtensionRequestAcceptanceV03 *-- ISO20022.Tsmt031001.SimpleIdentificationInformation
    ISO20022.Tsmt031001.StatusExtensionRequestAcceptanceV03 *-- ISO20022.Tsmt031001.SimpleIdentificationInformation
    ISO20022.Tsmt031001.StatusExtensionRequestAcceptanceV03 *-- ISO20022.Tsmt031001.MessageIdentification1
    class ISO20022.Tsmt031001.TransactionStatus4 {
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

## Enum ISO20022.Tsmt031001.BaselineStatus3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DARQ|Int32||XmlEnum("""DARQ""")|1|
||SERQ|Int32||XmlEnum("""SERQ""")|2|
||SCRQ|Int32||XmlEnum("""SCRQ""")|3|
||CLRQ|Int32||XmlEnum("""CLRQ""")|4|
||RARQ|Int32||XmlEnum("""RARQ""")|5|
||AMRQ|Int32||XmlEnum("""AMRQ""")|6|
||COMP|Int32||XmlEnum("""COMP""")|7|
||ACTV|Int32||XmlEnum("""ACTV""")|8|
||ESTD|Int32||XmlEnum("""ESTD""")|9|
||PMTC|Int32||XmlEnum("""PMTC""")|10|
||CLSD|Int32||XmlEnum("""CLSD""")|11|
||PROP|Int32||XmlEnum("""PROP""")|12|

---

## Type ISO20022.Tsmt031001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StsXtnsnReqAccptnc|ISO20022.Tsmt031001.StatusExtensionRequestAcceptanceV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StsXtnsnReqAccptnc))|

---

## Value ISO20022.Tsmt031001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Tsmt031001.SimpleIdentificationInformation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Aspect ISO20022.Tsmt031001.StatusExtensionRequestAcceptanceV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XtndedSts|ISO20022.Tsmt031001.TransactionStatus4||XmlElement()||
|+|SubmitrTxRef|ISO20022.Tsmt031001.SimpleIdentificationInformation||XmlElement()||
|+|TxId|ISO20022.Tsmt031001.SimpleIdentificationInformation||XmlElement()||
|+|AccptncId|ISO20022.Tsmt031001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XtndedSts),validElement(SubmitrTxRef),validElement(TxId),validElement(AccptncId))|

---

## Value ISO20022.Tsmt031001.TransactionStatus4


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

