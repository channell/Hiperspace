# pain.013.001.11-physical
```mermaid
classDiagram
    class ISO20022.Pain013001.Document {
        # Uri  : String
        + CdtrPmtActvtnReq  : ISO20022.Pain013001.CreditorPaymentActivationRequestV11
        + Validation () = validation(validElement(CdtrPmtActvtnReq))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Pain013001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CdtrPmtActvtnReq|ISO20022.Pain013001.CreditorPaymentActivationRequestV11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtrPmtActvtnReq))|

