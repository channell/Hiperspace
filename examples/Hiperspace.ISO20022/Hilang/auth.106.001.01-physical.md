# auth.106.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth106001.Document {
        # Uri  : String
        + DerivsTradWrnngsRpt () : ISO20022.Auth106001.DerivativesTradeWarningsReportV01
        + Validation () = validation(validElement(DerivsTradWrnngsRpt))
    }
    class ISO20022.Auth106001.DerivativesTradeWarningsReportV01 {
        # owner  : ISO20022.Auth106001.Document
        + SplmtryData  : List~ISO20022.Auth106001.SupplementaryData1~
        + WrnngsSttstcs  : ISO20022.Auth106001.StatisticsPerCounterparty16Choice
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(WrnngsSttstcs))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth106001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|DerivsTradWrnngsRpt|ISO20022.Auth106001.DerivativesTradeWarningsReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DerivsTradWrnngsRpt))|

---

## AspectImpl ISO20022.Auth106001.DerivativesTradeWarningsReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth106001.Document||||
|+|SplmtryData|List<ISO20022.Auth106001.SupplementaryData1>||XmlElement()||
|+|WrnngsSttstcs|ISO20022.Auth106001.StatisticsPerCounterparty16Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(WrnngsSttstcs))|

