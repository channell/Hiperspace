# auth.066.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth066001.Document {
        # Uri  : String
        + CCPBckTstgRsltRpt () : ISO20022.Auth066001.CCPBackTestingResultReportV01
        + Validation () = validation(validElement(CCPBckTstgRsltRpt))
    }
    class ISO20022.Auth066001.CCPBackTestingResultReportV01 {
        # owner  : ISO20022.Auth066001.Document
        + SplmtryData  : List~ISO20022.Auth066001.SupplementaryData1~
        + MnthlyRslt  : List~ISO20022.Auth066001.MonthlyResult1~
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""MnthlyRslt""",MnthlyRslt),validList("""MnthlyRslt""",MnthlyRslt),validElement(MnthlyRslt))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth066001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CCPBckTstgRsltRpt|ISO20022.Auth066001.CCPBackTestingResultReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CCPBckTstgRsltRpt))|

---

## AspectImpl ISO20022.Auth066001.CCPBackTestingResultReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth066001.Document||||
|+|SplmtryData|List<ISO20022.Auth066001.SupplementaryData1>||XmlElement()||
|+|MnthlyRslt|List<ISO20022.Auth066001.MonthlyResult1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""MnthlyRslt""",MnthlyRslt),validList("""MnthlyRslt""",MnthlyRslt),validElement(MnthlyRslt))|

