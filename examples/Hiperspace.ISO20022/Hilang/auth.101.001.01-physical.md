# auth.101.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth101001.Document {
        # Uri  : String
        + SttlmFlsAnlRpt () : ISO20022.Auth101001.SettlementFailsAnnualReportV01
        + Validation () = validation(validElement(SttlmFlsAnlRpt))
    }
    class ISO20022.Auth101001.SettlementFailsAnnualReportV01 {
        # owner  : ISO20022.Auth101001.Document
        + SplmtryData  : List~ISO20022.Auth101001.SupplementaryData1~
        + AnlAggt  : ISO20022.Auth101001.SettlementFailsData4
        + RptHdr  : ISO20022.Auth101001.SettlementFailsReportHeader2
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AnlAggt),validElement(RptHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth101001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SttlmFlsAnlRpt|ISO20022.Auth101001.SettlementFailsAnnualReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmFlsAnlRpt))|

---

## AspectImpl ISO20022.Auth101001.SettlementFailsAnnualReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth101001.Document||||
|+|SplmtryData|List<ISO20022.Auth101001.SupplementaryData1>||XmlElement()||
|+|AnlAggt|ISO20022.Auth101001.SettlementFailsData4||XmlElement()||
|+|RptHdr|ISO20022.Auth101001.SettlementFailsReportHeader2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AnlAggt),validElement(RptHdr))|

