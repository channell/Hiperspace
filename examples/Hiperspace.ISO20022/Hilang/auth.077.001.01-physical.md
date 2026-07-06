# auth.077.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth077001.Document {
        # Uri  : String
        + FinBchmkRpt () : ISO20022.Auth077001.FinancialBenchmarkReportV01
        + Validation () = validation(validElement(FinBchmkRpt))
    }
    class ISO20022.Auth077001.FinancialBenchmarkReportV01 {
        # owner  : ISO20022.Auth077001.Document
        + SplmtryData  : List~ISO20022.Auth077001.SupplementaryData1~
        + BchmkData  : List~ISO20022.Auth077001.BenchmarkReport1Choice~
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""BchmkData""",BchmkData),validList("""BchmkData""",BchmkData),validElement(BchmkData))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth077001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|FinBchmkRpt|ISO20022.Auth077001.FinancialBenchmarkReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinBchmkRpt))|

---

## AspectImpl ISO20022.Auth077001.FinancialBenchmarkReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth077001.Document||||
|+|SplmtryData|List<ISO20022.Auth077001.SupplementaryData1>||XmlElement()||
|+|BchmkData|List<ISO20022.Auth077001.BenchmarkReport1Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""BchmkData""",BchmkData),validList("""BchmkData""",BchmkData),validElement(BchmkData))|

