# reda.035.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Reda035001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Reda035001.MessageHeader1 {
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    class ISO20022.Reda035001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Reda035001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Reda035001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Reda035001.SecuritiesAccount19 *-- ISO20022.Reda035001.GenericIdentification30
    class ISO20022.Reda035001.SecuritiesAccountActivityAdviceV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Reda035001.SupplementaryData1~
        + SctiesAcctActvty  : ISO20022.Reda035001.SecuritiesAccountStatement2
        + Pgntn  : ISO20022.Reda035001.Pagination1
        + MsgHdr  : ISO20022.Reda035001.MessageHeader1
    }
    ISO20022.Reda035001.SecuritiesAccountActivityAdviceV01 *-- ISO20022.Reda035001.SupplementaryData1
    ISO20022.Reda035001.SecuritiesAccountActivityAdviceV01 *-- ISO20022.Reda035001.SecuritiesAccountStatement2
    ISO20022.Reda035001.SecuritiesAccountActivityAdviceV01 *-- ISO20022.Reda035001.Pagination1
    ISO20022.Reda035001.SecuritiesAccountActivityAdviceV01 *-- ISO20022.Reda035001.MessageHeader1
    class ISO20022.Reda035001.SecuritiesAccountReferenceDataChange2 {
        + OprTmStmp  : DateTime
        + NewFldVal  : String
        + OdFldVal  : String
        + FldNm  : String
        + SctiesAcctId  : ISO20022.Reda035001.SecuritiesAccount19
    }
    ISO20022.Reda035001.SecuritiesAccountReferenceDataChange2 *-- ISO20022.Reda035001.SecuritiesAccount19
    class ISO20022.Reda035001.SecuritiesAccountStatement2 {
        + Chng  : global::System.Collections.Generic.List~ISO20022.Reda035001.SecuritiesAccountReferenceDataChange2~
        + SysDt  : DateTime
    }
    ISO20022.Reda035001.SecuritiesAccountStatement2 *-- ISO20022.Reda035001.SecuritiesAccountReferenceDataChange2
    class ISO20022.Reda035001.SupplementaryData1 {
        + Envlp  : ISO20022.Reda035001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Reda035001.SupplementaryData1 *-- ISO20022.Reda035001.SupplementaryDataEnvelope1
    class ISO20022.Reda035001.SupplementaryDataEnvelope1 {
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

## Type ISO20022.Reda035001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesAcctActvtyAdvc|ISO20022.Reda035001.SecuritiesAccountActivityAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesAcctActvtyAdvc))|

---

## Value ISO20022.Reda035001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Reda035001.MessageHeader1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda035001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Reda035001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Reda035001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Aspect ISO20022.Reda035001.SecuritiesAccountActivityAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Reda035001.SupplementaryData1>||XmlElement()||
|+|SctiesAcctActvty|ISO20022.Reda035001.SecuritiesAccountStatement2||XmlElement()||
|+|Pgntn|ISO20022.Reda035001.Pagination1||XmlElement()||
|+|MsgHdr|ISO20022.Reda035001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SctiesAcctActvty),validElement(Pgntn),validElement(MsgHdr))|

---

## Value ISO20022.Reda035001.SecuritiesAccountReferenceDataChange2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OprTmStmp|DateTime||XmlElement()||
|+|NewFldVal|String||XmlElement()||
|+|OdFldVal|String||XmlElement()||
|+|FldNm|String||XmlElement()||
|+|SctiesAcctId|ISO20022.Reda035001.SecuritiesAccount19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesAcctId))|

---

## Value ISO20022.Reda035001.SecuritiesAccountStatement2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Chng|global::System.Collections.Generic.List<ISO20022.Reda035001.SecuritiesAccountReferenceDataChange2>||XmlElement()||
|+|SysDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Chng""",Chng),validElement(Chng))|

---

## Value ISO20022.Reda035001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Reda035001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Reda035001.SupplementaryDataEnvelope1


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

