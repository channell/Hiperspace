# colr.016.001.05-physical
```mermaid
classDiagram
    class ISO20022.Colr016001.Document {
        # Uri  : String
        + CollAndXpsrRpt () : ISO20022.Colr016001.CollateralAndExposureReportV05
        + Validation () = validation(validElement(CollAndXpsrRpt))
    }
    class ISO20022.Colr016001.CollateralAndExposureReportV05 {
        # owner  : ISO20022.Colr016001.Document
        + SplmtryData  : List~ISO20022.Colr016001.SupplementaryData1~
        + CollRpt  : List~ISO20022.Colr016001.Collateral53~
        + Agrmt  : ISO20022.Colr016001.Agreement4
        + Oblgtn  : ISO20022.Colr016001.Obligation11
        + Pgntn  : ISO20022.Colr016001.Pagination1
        + RptParams  : ISO20022.Colr016001.ReportParameters6
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""CollRpt""",CollRpt),validList("""CollRpt""",CollRpt),validElement(CollRpt),validElement(Agrmt),validElement(Oblgtn),validElement(Pgntn),validElement(RptParams))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Colr016001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CollAndXpsrRpt|ISO20022.Colr016001.CollateralAndExposureReportV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollAndXpsrRpt))|

---

## AspectImpl ISO20022.Colr016001.CollateralAndExposureReportV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Colr016001.Document||||
|+|SplmtryData|List<ISO20022.Colr016001.SupplementaryData1>||XmlElement()||
|+|CollRpt|List<ISO20022.Colr016001.Collateral53>||XmlElement()||
|+|Agrmt|ISO20022.Colr016001.Agreement4||XmlElement()||
|+|Oblgtn|ISO20022.Colr016001.Obligation11||XmlElement()||
|+|Pgntn|ISO20022.Colr016001.Pagination1||XmlElement()||
|+|RptParams|ISO20022.Colr016001.ReportParameters6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""CollRpt""",CollRpt),validList("""CollRpt""",CollRpt),validElement(CollRpt),validElement(Agrmt),validElement(Oblgtn),validElement(Pgntn),validElement(RptParams))|

