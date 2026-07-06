# auth.100.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth100001.Document {
        # Uri  : String
        + SttlmFlsMnthlyRpt () : ISO20022.Auth100001.SettlementFailsMonthlyReportV01
        + Validation () = validation(validElement(SttlmFlsMnthlyRpt))
    }
    class ISO20022.Auth100001.SettlementFailsMonthlyReportV01 {
        # owner  : ISO20022.Auth100001.Document
        + SplmtryData  : List~ISO20022.Auth100001.SupplementaryData1~
        + DalyData  : List~ISO20022.Auth100001.SettlementFailsDailyData3~
        + MnthlyAggt  : ISO20022.Auth100001.SettlementFailsData3
        + RptHdr  : ISO20022.Auth100001.SettlementFailsReportHeader2
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""DalyData""",DalyData),validList("""DalyData""",DalyData),validElement(DalyData),validElement(MnthlyAggt),validElement(RptHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth100001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SttlmFlsMnthlyRpt|ISO20022.Auth100001.SettlementFailsMonthlyReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmFlsMnthlyRpt))|

---

## AspectImpl ISO20022.Auth100001.SettlementFailsMonthlyReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth100001.Document||||
|+|SplmtryData|List<ISO20022.Auth100001.SupplementaryData1>||XmlElement()||
|+|DalyData|List<ISO20022.Auth100001.SettlementFailsDailyData3>||XmlElement()||
|+|MnthlyAggt|ISO20022.Auth100001.SettlementFailsData3||XmlElement()||
|+|RptHdr|ISO20022.Auth100001.SettlementFailsReportHeader2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""DalyData""",DalyData),validList("""DalyData""",DalyData),validElement(DalyData),validElement(MnthlyAggt),validElement(RptHdr))|

