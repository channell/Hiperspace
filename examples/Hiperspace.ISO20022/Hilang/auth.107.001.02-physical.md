# auth.107.001.02-physical
```mermaid
classDiagram
    class ISO20022.Auth107001.Document {
        # Uri  : String
        + DerivsTradStatRpt () : ISO20022.Auth107001.DerivativesTradeStateReportV02
        + Validation () = validation(validElement(DerivsTradStatRpt))
    }
    class ISO20022.Auth107001.DerivativesTradeStateReportV02 {
        # owner  : ISO20022.Auth107001.Document
        + SplmtryData  : List~ISO20022.Auth107001.SupplementaryData1~
        + TradData  : ISO20022.Auth107001.TradeData60Choice
        + RptHdr  : ISO20022.Auth107001.TradeReportHeader4
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

## EntityImpl ISO20022.Auth107001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|DerivsTradStatRpt|ISO20022.Auth107001.DerivativesTradeStateReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DerivsTradStatRpt))|

---

## AspectImpl ISO20022.Auth107001.DerivativesTradeStateReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth107001.Document||||
|+|SplmtryData|List<ISO20022.Auth107001.SupplementaryData1>||XmlElement()||
|+|TradData|ISO20022.Auth107001.TradeData60Choice||XmlElement()||
|+|RptHdr|ISO20022.Auth107001.TradeReportHeader4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TradData),validElement(RptHdr))|

