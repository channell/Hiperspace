# auth.029.001.05-physical
```mermaid
classDiagram
    class ISO20022.Auth029001.Document {
        # Uri  : String
        + DerivsTradRptQry () : ISO20022.Auth029001.DerivativesTradeReportQueryV05
        + Validation () = validation(validElement(DerivsTradRptQry))
    }
    class ISO20022.Auth029001.DerivativesTradeReportQueryV05 {
        # owner  : ISO20022.Auth029001.Document
        + SplmtryData  : List~ISO20022.Auth029001.SupplementaryData1~
        + TradQryData  : ISO20022.Auth029001.TradeReportQuery18Choice
        + RqstngAuthrty  : ISO20022.Auth029001.PartyIdentification121Choice
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TradQryData),validElement(RqstngAuthrty))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth029001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|DerivsTradRptQry|ISO20022.Auth029001.DerivativesTradeReportQueryV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DerivsTradRptQry))|

---

## AspectImpl ISO20022.Auth029001.DerivativesTradeReportQueryV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth029001.Document||||
|+|SplmtryData|List<ISO20022.Auth029001.SupplementaryData1>||XmlElement()||
|+|TradQryData|ISO20022.Auth029001.TradeReportQuery18Choice||XmlElement()||
|+|RqstngAuthrty|ISO20022.Auth029001.PartyIdentification121Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TradQryData),validElement(RqstngAuthrty))|

