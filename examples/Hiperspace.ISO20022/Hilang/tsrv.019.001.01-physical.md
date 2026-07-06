# tsrv.019.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsrv019001.Document {
        # Uri  : String
        + UdrtkgStsRpt () : ISO20022.Tsrv019001.UndertakingStatusReportV01
        + Validation () = validation(validElement(UdrtkgStsRpt))
    }
    class ISO20022.Tsrv019001.UndertakingStatusReportV01 {
        # owner  : ISO20022.Tsrv019001.Document
        + DgtlSgntr  : ISO20022.Tsrv019001.PartyAndSignature2
        + UdrtkgStsRptDtls  : ISO20022.Tsrv019001.UndertakingStatusAdvice1
        + Validation () = validation(validElement(DgtlSgntr),validElement(UdrtkgStsRptDtls))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsrv019001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|UdrtkgStsRpt|ISO20022.Tsrv019001.UndertakingStatusReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UdrtkgStsRpt))|

---

## AspectImpl ISO20022.Tsrv019001.UndertakingStatusReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsrv019001.Document||||
|+|DgtlSgntr|ISO20022.Tsrv019001.PartyAndSignature2||XmlElement()||
|+|UdrtkgStsRptDtls|ISO20022.Tsrv019001.UndertakingStatusAdvice1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validElement(UdrtkgStsRptDtls))|

