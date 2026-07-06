# auth.065.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth065001.Document {
        # Uri  : String
        + CCPBckTstgDefRpt () : ISO20022.Auth065001.CCPBackTestingDefinitionReportV01
        + Validation () = validation(validElement(CCPBckTstgDefRpt))
    }
    class ISO20022.Auth065001.CCPBackTestingDefinitionReportV01 {
        # owner  : ISO20022.Auth065001.Document
        + SplmtryData  : List~ISO20022.Auth065001.SupplementaryData1~
        + Mthdlgy  : List~ISO20022.Auth065001.BackTestingMethodology1~
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Mthdlgy""",Mthdlgy),validList("""Mthdlgy""",Mthdlgy),validElement(Mthdlgy))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth065001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CCPBckTstgDefRpt|ISO20022.Auth065001.CCPBackTestingDefinitionReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CCPBckTstgDefRpt))|

---

## AspectImpl ISO20022.Auth065001.CCPBackTestingDefinitionReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth065001.Document||||
|+|SplmtryData|List<ISO20022.Auth065001.SupplementaryData1>||XmlElement()||
|+|Mthdlgy|List<ISO20022.Auth065001.BackTestingMethodology1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Mthdlgy""",Mthdlgy),validList("""Mthdlgy""",Mthdlgy),validElement(Mthdlgy))|

