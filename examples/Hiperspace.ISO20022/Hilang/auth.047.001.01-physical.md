# auth.047.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth047001.Document {
        # Uri  : String
        + FinInstrmRptgCtryCdRpt  : ISO20022.Auth047001.FinancialInstrumentReportingCountryCodeReportV01
        + Validation () = validation(validElement(FinInstrmRptgCtryCdRpt))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth047001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|FinInstrmRptgCtryCdRpt|ISO20022.Auth047001.FinancialInstrumentReportingCountryCodeReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmRptgCtryCdRpt))|

