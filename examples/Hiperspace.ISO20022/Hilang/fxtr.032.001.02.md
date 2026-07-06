# fxtr.032.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Fxtr032001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Fxtr032001.DateFormat45Choice {
        + NotSpcfdDt  : String
        + Dt  : ISO20022.Fxtr032001.DateAndDateTime2Choice
    }
    ISO20022.Fxtr032001.DateFormat45Choice *-- ISO20022.Fxtr032001.DateAndDateTime2Choice
    class ISO20022.Fxtr032001.DateType8Code {
        ONGO = 1
        UKWN = 2
    }
    class ISO20022.Fxtr032001.ForeignExchangeTradeCaptureReportRequestV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Fxtr032001.SupplementaryData1~
        + QryParamVal  : String
        + QryPgSz  : String
        + QryEndId  : String
        + QryTradId  : String
        + QryPrd  : ISO20022.Fxtr032001.Period12
        + QryByPrd  : String
        + QryStartNb  : String
        + QryTp  : String
        + QryOrdrSts  : String
        + QryReqId  : ISO20022.Fxtr032001.MessageIdentification1
    }
    ISO20022.Fxtr032001.ForeignExchangeTradeCaptureReportRequestV02 *-- ISO20022.Fxtr032001.SupplementaryData1
    ISO20022.Fxtr032001.ForeignExchangeTradeCaptureReportRequestV02 *-- ISO20022.Fxtr032001.Period12
    ISO20022.Fxtr032001.ForeignExchangeTradeCaptureReportRequestV02 *-- ISO20022.Fxtr032001.MessageIdentification1
    class ISO20022.Fxtr032001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Fxtr032001.Period12 {
        + EndDt  : ISO20022.Fxtr032001.DateFormat45Choice
        + StartDt  : ISO20022.Fxtr032001.DateFormat45Choice
    }
    ISO20022.Fxtr032001.Period12 *-- ISO20022.Fxtr032001.DateFormat45Choice
    ISO20022.Fxtr032001.Period12 *-- ISO20022.Fxtr032001.DateFormat45Choice
    class ISO20022.Fxtr032001.QueryDataType1Code {
        QOTD = 1
        QFXT = 2
    }
    class ISO20022.Fxtr032001.QueryOrderStatus1Code {
        QUAO = 1
        QPEO = 2
        QFEO = 3
        QOFP = 4
        QUCO = 5
    }
    class ISO20022.Fxtr032001.SupplementaryData1 {
        + Envlp  : ISO20022.Fxtr032001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Fxtr032001.SupplementaryData1 *-- ISO20022.Fxtr032001.SupplementaryDataEnvelope1
    class ISO20022.Fxtr032001.SupplementaryDataEnvelope1 {
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

## Value ISO20022.Fxtr032001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Fxtr032001.DateFormat45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdDt|String||XmlElement()||
|+|Dt|ISO20022.Fxtr032001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dt),validChoice(NotSpcfdDt,Dt))|

---

## Enum ISO20022.Fxtr032001.DateType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Type ISO20022.Fxtr032001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXTradCaptrRptReq|ISO20022.Fxtr032001.ForeignExchangeTradeCaptureReportRequestV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXTradCaptrRptReq))|

---

## Aspect ISO20022.Fxtr032001.ForeignExchangeTradeCaptureReportRequestV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Fxtr032001.SupplementaryData1>||XmlElement()||
|+|QryParamVal|String||XmlElement()||
|+|QryPgSz|String||XmlElement()||
|+|QryEndId|String||XmlElement()||
|+|QryTradId|String||XmlElement()||
|+|QryPrd|ISO20022.Fxtr032001.Period12||XmlElement()||
|+|QryByPrd|String||XmlElement()||
|+|QryStartNb|String||XmlElement()||
|+|QryTp|String||XmlElement()||
|+|QryOrdrSts|String||XmlElement()||
|+|QryReqId|ISO20022.Fxtr032001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validPattern("""QryPgSz""",QryPgSz,"""[0-9]{1,35}"""),validElement(QryPrd),validPattern("""QryStartNb""",QryStartNb,"""[0-9]{1,35}"""),validElement(QryReqId))|

---

## Value ISO20022.Fxtr032001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Fxtr032001.Period12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EndDt|ISO20022.Fxtr032001.DateFormat45Choice||XmlElement()||
|+|StartDt|ISO20022.Fxtr032001.DateFormat45Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EndDt),validElement(StartDt))|

---

## Enum ISO20022.Fxtr032001.QueryDataType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||QOTD|Int32||XmlEnum("""QOTD""")|1|
||QFXT|Int32||XmlEnum("""QFXT""")|2|

---

## Enum ISO20022.Fxtr032001.QueryOrderStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||QUAO|Int32||XmlEnum("""QUAO""")|1|
||QPEO|Int32||XmlEnum("""QPEO""")|2|
||QFEO|Int32||XmlEnum("""QFEO""")|3|
||QOFP|Int32||XmlEnum("""QOFP""")|4|
||QUCO|Int32||XmlEnum("""QUCO""")|5|

---

## Value ISO20022.Fxtr032001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Fxtr032001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Fxtr032001.SupplementaryDataEnvelope1


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

