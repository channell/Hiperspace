# auth.066.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth066001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth066001.CCPBackTestingResultReportV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth066001.SupplementaryData1~
        + MnthlyRslt  : global::System.Collections.Generic.List~ISO20022.Auth066001.MonthlyResult1~
    }
    ISO20022.Auth066001.CCPBackTestingResultReportV01 *-- ISO20022.Auth066001.SupplementaryData1
    ISO20022.Auth066001.CCPBackTestingResultReportV01 *-- ISO20022.Auth066001.MonthlyResult1
    class ISO20022.Auth066001.GenericIdentification165 {
        + SchmeNm  : String
        + Issr  : String
        + Desc  : String
        + Id  : String
    }
    class ISO20022.Auth066001.MonthlyResult1 {
        + LrgstXcptnId  : ISO20022.Auth066001.GenericIdentification165
        + AvrgXcptn  : ISO20022.Auth066001.ActiveCurrencyAndAmount
        + LrgstXcptn  : ISO20022.Auth066001.ActiveCurrencyAndAmount
        + Cvrg  : Decimal
        + NbOfXcptns  : Decimal
        + NbOfObsrvtns  : Decimal
    }
    ISO20022.Auth066001.MonthlyResult1 *-- ISO20022.Auth066001.GenericIdentification165
    ISO20022.Auth066001.MonthlyResult1 *-- ISO20022.Auth066001.ActiveCurrencyAndAmount
    ISO20022.Auth066001.MonthlyResult1 *-- ISO20022.Auth066001.ActiveCurrencyAndAmount
    class ISO20022.Auth066001.SchemeIdentificationType1Code {
        CLIM = 1
        POSI = 2
        COLL = 3
        MARG = 4
    }
    class ISO20022.Auth066001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth066001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth066001.SupplementaryData1 *-- ISO20022.Auth066001.SupplementaryDataEnvelope1
    class ISO20022.Auth066001.SupplementaryDataEnvelope1 {
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

## Value ISO20022.Auth066001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Aspect ISO20022.Auth066001.CCPBackTestingResultReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth066001.SupplementaryData1>||XmlElement()||
|+|MnthlyRslt|global::System.Collections.Generic.List<ISO20022.Auth066001.MonthlyResult1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""MnthlyRslt""",MnthlyRslt),validList("""MnthlyRslt""",MnthlyRslt),validElement(MnthlyRslt))|

---

## Type ISO20022.Auth066001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CCPBckTstgRsltRpt|ISO20022.Auth066001.CCPBackTestingResultReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CCPBckTstgRsltRpt))|

---

## Value ISO20022.Auth066001.GenericIdentification165


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth066001.MonthlyResult1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LrgstXcptnId|ISO20022.Auth066001.GenericIdentification165||XmlElement()||
|+|AvrgXcptn|ISO20022.Auth066001.ActiveCurrencyAndAmount||XmlElement()||
|+|LrgstXcptn|ISO20022.Auth066001.ActiveCurrencyAndAmount||XmlElement()||
|+|Cvrg|Decimal||XmlElement()||
|+|NbOfXcptns|Decimal||XmlElement()||
|+|NbOfObsrvtns|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LrgstXcptnId),validElement(AvrgXcptn),validElement(LrgstXcptn))|

---

## Enum ISO20022.Auth066001.SchemeIdentificationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CLIM|Int32||XmlEnum("""CLIM""")|1|
||POSI|Int32||XmlEnum("""POSI""")|2|
||COLL|Int32||XmlEnum("""COLL""")|3|
||MARG|Int32||XmlEnum("""MARG""")|4|

---

## Value ISO20022.Auth066001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth066001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth066001.SupplementaryDataEnvelope1


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

