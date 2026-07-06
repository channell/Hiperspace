# auth.062.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth062001.CCPLiquidityStressTestingDefinitionReportV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth062001.SupplementaryData1~
        + LqdtyStrssScnroDef  : global::System.Collections.Generic.List~ISO20022.Auth062001.LiquidityStressScenarioDefinition1~
    }
    ISO20022.Auth062001.CCPLiquidityStressTestingDefinitionReportV01 *-- ISO20022.Auth062001.SupplementaryData1
    ISO20022.Auth062001.CCPLiquidityStressTestingDefinitionReportV01 *-- ISO20022.Auth062001.LiquidityStressScenarioDefinition1
    class ISO20022.Auth062001.GenericIdentification168 {
        + SchmeNm  : String
        + Issr  : String
        + Desc  : String
        + Id  : String
    }
    class ISO20022.Auth062001.LiquidityStressScenarioDefinition1 {
        + StrssCcy  : String
        + Tp  : String
        + Desc  : String
        + Id  : ISO20022.Auth062001.GenericIdentification168
    }
    ISO20022.Auth062001.LiquidityStressScenarioDefinition1 *-- ISO20022.Auth062001.GenericIdentification168
    class ISO20022.Auth062001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth062001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth062001.SupplementaryData1 *-- ISO20022.Auth062001.SupplementaryDataEnvelope1
    class ISO20022.Auth062001.SupplementaryDataEnvelope1 {
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

## Aspect ISO20022.Auth062001.CCPLiquidityStressTestingDefinitionReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth062001.SupplementaryData1>||XmlElement()||
|+|LqdtyStrssScnroDef|global::System.Collections.Generic.List<ISO20022.Auth062001.LiquidityStressScenarioDefinition1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""LqdtyStrssScnroDef""",LqdtyStrssScnroDef),validList("""LqdtyStrssScnroDef""",LqdtyStrssScnroDef),validElement(LqdtyStrssScnroDef))|

---

## Type ISO20022.Auth062001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CCPLqdtyStrssTstgDefRpt|ISO20022.Auth062001.CCPLiquidityStressTestingDefinitionReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CCPLqdtyStrssTstgDefRpt))|

---

## Value ISO20022.Auth062001.GenericIdentification168


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth062001.LiquidityStressScenarioDefinition1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StrssCcy|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Id|ISO20022.Auth062001.GenericIdentification168||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""StrssCcy""",StrssCcy,"""[A-Z]{3,3}"""),validElement(Id))|

---

## Value ISO20022.Auth062001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth062001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth062001.SupplementaryDataEnvelope1


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

