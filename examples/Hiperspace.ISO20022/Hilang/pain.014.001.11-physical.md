# pain.014.001.11-physical
```mermaid
classDiagram
    class ISO20022.Pain014001.Document {
        # Uri  : String
        + CdtrPmtActvtnReqStsRpt  : ISO20022.Pain014001.CreditorPaymentActivationRequestStatusReportV11
        + Validation () = validation(validElement(CdtrPmtActvtnReqStsRpt))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Pain014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CdtrPmtActvtnReqStsRpt|ISO20022.Pain014001.CreditorPaymentActivationRequestStatusReportV11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtrPmtActvtnReqStsRpt))|

