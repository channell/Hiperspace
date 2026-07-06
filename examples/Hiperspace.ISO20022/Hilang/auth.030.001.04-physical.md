# auth.030.001.04-physical
```mermaid
classDiagram
    class ISO20022.Auth030001.Document {
        # Uri  : String
        + DerivsTradRpt () : ISO20022.Auth030001.DerivativesTradeReportV04
        + Validation () = validation(validElement(DerivsTradRpt))
    }
    class ISO20022.Auth030001.DerivativesTradeReportV04 {
        # owner  : ISO20022.Auth030001.Document
        + SplmtryData  : List~ISO20022.Auth030001.SupplementaryData1~
        + TradData  : ISO20022.Auth030001.TradeData59Choice
        + RptHdr  : ISO20022.Auth030001.TradeReportHeader4
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TradData),validElement(RptHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth030001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|DerivsTradRpt|ISO20022.Auth030001.DerivativesTradeReportV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DerivsTradRpt))|

---

## AspectImpl ISO20022.Auth030001.DerivativesTradeReportV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth030001.Document||||
|+|SplmtryData|List<ISO20022.Auth030001.SupplementaryData1>||XmlElement()||
|+|TradData|ISO20022.Auth030001.TradeData59Choice||XmlElement()||
|+|RptHdr|ISO20022.Auth030001.TradeReportHeader4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TradData),validElement(RptHdr))|

