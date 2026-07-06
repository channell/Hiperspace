# auth.113.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth113001.Document {
        # Uri  : String
        + OrdrBookRpt () : ISO20022.Auth113001.OrderBookReportV01
        + Validation () = validation(validElement(OrdrBookRpt))
    }
    class ISO20022.Auth113001.OrderBookReportV01 {
        # owner  : ISO20022.Auth113001.Document
        + SplmtryData  : List~ISO20022.Auth113001.SupplementaryData1~
        + OrdrRpt  : List~ISO20022.Auth113001.OrderReport2Choice~
        + RptHdr  : ISO20022.Auth113001.SecuritiesMarketReportHeader3
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""OrdrRpt""",OrdrRpt),validList("""OrdrRpt""",OrdrRpt),validElement(OrdrRpt),validElement(RptHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth113001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|OrdrBookRpt|ISO20022.Auth113001.OrderBookReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrdrBookRpt))|

---

## AspectImpl ISO20022.Auth113001.OrderBookReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth113001.Document||||
|+|SplmtryData|List<ISO20022.Auth113001.SupplementaryData1>||XmlElement()||
|+|OrdrRpt|List<ISO20022.Auth113001.OrderReport2Choice>||XmlElement()||
|+|RptHdr|ISO20022.Auth113001.SecuritiesMarketReportHeader3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""OrdrRpt""",OrdrRpt),validList("""OrdrRpt""",OrdrRpt),validElement(OrdrRpt),validElement(RptHdr))|

