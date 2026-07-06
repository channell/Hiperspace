# reda.064.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Reda064001.CalendarQueryV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Reda064001.SupplementaryData1~
        + SchCrit  : global::System.Collections.Generic.List~ISO20022.Reda064001.CalendarSearchCriteria1~
        + MsgHdr  : ISO20022.Reda064001.MessageHeader9
    }
    ISO20022.Reda064001.CalendarQueryV02 *-- ISO20022.Reda064001.SupplementaryData1
    ISO20022.Reda064001.CalendarQueryV02 *-- ISO20022.Reda064001.CalendarSearchCriteria1
    ISO20022.Reda064001.CalendarQueryV02 *-- ISO20022.Reda064001.MessageHeader9
    class ISO20022.Reda064001.CalendarSearchCriteria1 {
        + Svc  : ISO20022.Reda064001.SystemAndCurrency1
        + Mnth  : String
        + Yr  : Int32
    }
    ISO20022.Reda064001.CalendarSearchCriteria1 *-- ISO20022.Reda064001.SystemAndCurrency1
    class ISO20022.Reda064001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Reda064001.MarketInfrastructureIdentification1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Reda064001.MessageHeader9 {
        + ReqTp  : ISO20022.Reda064001.RequestType4Choice
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Reda064001.MessageHeader9 *-- ISO20022.Reda064001.RequestType4Choice
    class ISO20022.Reda064001.RequestType4Choice {
        + Prtry  : ISO20022.Reda064001.GenericIdentification1
        + Enqry  : String
        + PmtCtrl  : String
    }
    ISO20022.Reda064001.RequestType4Choice *-- ISO20022.Reda064001.GenericIdentification1
    class ISO20022.Reda064001.SupplementaryData1 {
        + Envlp  : ISO20022.Reda064001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Reda064001.SupplementaryData1 *-- ISO20022.Reda064001.SupplementaryDataEnvelope1
    class ISO20022.Reda064001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Reda064001.SystemAndCurrency1 {
        + SysCcy  : String
        + SysId  : ISO20022.Reda064001.SystemIdentification2Choice
    }
    ISO20022.Reda064001.SystemAndCurrency1 *-- ISO20022.Reda064001.SystemIdentification2Choice
    class ISO20022.Reda064001.SystemIdentification2Choice {
        + Ctry  : String
        + MktInfrstrctrId  : ISO20022.Reda064001.MarketInfrastructureIdentification1Choice
    }
    ISO20022.Reda064001.SystemIdentification2Choice *-- ISO20022.Reda064001.MarketInfrastructureIdentification1Choice
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

## Aspect ISO20022.Reda064001.CalendarQueryV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Reda064001.SupplementaryData1>||XmlElement()||
|+|SchCrit|global::System.Collections.Generic.List<ISO20022.Reda064001.CalendarSearchCriteria1>||XmlElement()||
|+|MsgHdr|ISO20022.Reda064001.MessageHeader9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""SchCrit""",SchCrit),validElement(SchCrit),validElement(MsgHdr))|

---

## Value ISO20022.Reda064001.CalendarSearchCriteria1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Svc|ISO20022.Reda064001.SystemAndCurrency1||XmlElement()||
|+|Mnth|String||XmlElement()||
|+|Yr|Int32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Svc))|

---

## Type ISO20022.Reda064001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CalQry|ISO20022.Reda064001.CalendarQueryV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CalQry))|

---

## Value ISO20022.Reda064001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda064001.MarketInfrastructureIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda064001.MessageHeader9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ReqTp|ISO20022.Reda064001.RequestType4Choice||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqTp))|

---

## Value ISO20022.Reda064001.RequestType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda064001.GenericIdentification1||XmlElement()||
|+|Enqry|String||XmlElement()||
|+|PmtCtrl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Enqry,PmtCtrl))|

---

## Value ISO20022.Reda064001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Reda064001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Reda064001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda064001.SystemAndCurrency1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SysCcy|String||XmlElement()||
|+|SysId|ISO20022.Reda064001.SystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SysCcy""",SysCcy,"""[A-Z]{3,3}"""),validElement(SysId))|

---

## Value ISO20022.Reda064001.SystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|MktInfrstrctrId|ISO20022.Reda064001.MarketInfrastructureIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(MktInfrstrctrId),validChoice(Ctry,MktInfrstrctrId))|

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

