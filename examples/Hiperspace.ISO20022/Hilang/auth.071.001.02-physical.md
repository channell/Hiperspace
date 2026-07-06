# auth.071.001.02-physical
```mermaid
classDiagram
    class ISO20022.Auth071001.Document {
        # Uri  : String
        + SctiesFincgRptgTxReusdCollDataRpt  : ISO20022.Auth071001.SecuritiesFinancingReportingTransactionReusedCollateralDataReportV02
        + Validation () = validation(validElement(SctiesFincgRptgTxReusdCollDataRpt))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth071001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctiesFincgRptgTxReusdCollDataRpt|ISO20022.Auth071001.SecuritiesFinancingReportingTransactionReusedCollateralDataReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesFincgRptgTxReusdCollDataRpt))|

