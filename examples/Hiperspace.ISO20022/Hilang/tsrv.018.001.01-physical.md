# tsrv.018.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsrv018001.Document {
        # Uri  : String
        + TradStsRpt () : ISO20022.Tsrv018001.TradeStatusReportV01
        + Validation () = validation(validElement(TradStsRpt))
    }
    class ISO20022.Tsrv018001.TradeStatusReportV01 {
        # owner  : ISO20022.Tsrv018001.Document
        + DgtlSgntr  : ISO20022.Tsrv018001.PartyAndSignature2
        + TradStsAdvcDtls  : ISO20022.Tsrv018001.TradeStatusReport1
        + Validation () = validation(validElement(DgtlSgntr),validElement(TradStsAdvcDtls))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsrv018001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|TradStsRpt|ISO20022.Tsrv018001.TradeStatusReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TradStsRpt))|

---

## AspectImpl ISO20022.Tsrv018001.TradeStatusReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsrv018001.Document||||
|+|DgtlSgntr|ISO20022.Tsrv018001.PartyAndSignature2||XmlElement()||
|+|TradStsAdvcDtls|ISO20022.Tsrv018001.TradeStatusReport1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validElement(TradStsAdvcDtls))|

