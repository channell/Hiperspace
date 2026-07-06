# caam.008.001.01-physical
```mermaid
classDiagram
    class ISO20022.Caam008001.Document {
        # Uri  : String
        + HstToATMAck () : ISO20022.Caam008001.HostToATMAcknowledgementV01
        + Validation () = validation(validElement(HstToATMAck))
    }
    class ISO20022.Caam008001.HostToATMAcknowledgementV01 {
        # owner  : ISO20022.Caam008001.Document
        + SctyTrlr  : ISO20022.Caam008001.ContentInformationType15
        + HstToATMAck  : ISO20022.Caam008001.HostToATMAcknowledgement1
        + PrtctdHstToATMAck  : ISO20022.Caam008001.ContentInformationType10
        + Hdr  : ISO20022.Caam008001.Header20
        + Validation () = validation(validElement(SctyTrlr),validElement(HstToATMAck),validElement(PrtctdHstToATMAck),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caam008001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|HstToATMAck|ISO20022.Caam008001.HostToATMAcknowledgementV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(HstToATMAck))|

---

## AspectImpl ISO20022.Caam008001.HostToATMAcknowledgementV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caam008001.Document||||
|+|SctyTrlr|ISO20022.Caam008001.ContentInformationType15||XmlElement()||
|+|HstToATMAck|ISO20022.Caam008001.HostToATMAcknowledgement1||XmlElement()||
|+|PrtctdHstToATMAck|ISO20022.Caam008001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam008001.Header20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(HstToATMAck),validElement(PrtctdHstToATMAck),validElement(Hdr))|

