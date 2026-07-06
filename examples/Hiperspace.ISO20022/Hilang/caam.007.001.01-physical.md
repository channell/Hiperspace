# caam.007.001.01-physical
```mermaid
classDiagram
    class ISO20022.Caam007001.Document {
        # Uri  : String
        + HstToATMReq () : ISO20022.Caam007001.HostToATMRequestV01
        + Validation () = validation(validElement(HstToATMReq))
    }
    class ISO20022.Caam007001.HostToATMRequestV01 {
        # owner  : ISO20022.Caam007001.Document
        + SctyTrlr  : ISO20022.Caam007001.ContentInformationType15
        + HstToATMReq  : ISO20022.Caam007001.HostToATMRequest1
        + PrtctdHstToATMReq  : ISO20022.Caam007001.ContentInformationType10
        + Hdr  : ISO20022.Caam007001.Header20
        + Validation () = validation(validElement(SctyTrlr),validElement(HstToATMReq),validElement(PrtctdHstToATMReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caam007001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|HstToATMReq|ISO20022.Caam007001.HostToATMRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(HstToATMReq))|

---

## AspectImpl ISO20022.Caam007001.HostToATMRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caam007001.Document||||
|+|SctyTrlr|ISO20022.Caam007001.ContentInformationType15||XmlElement()||
|+|HstToATMReq|ISO20022.Caam007001.HostToATMRequest1||XmlElement()||
|+|PrtctdHstToATMReq|ISO20022.Caam007001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam007001.Header20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(HstToATMReq),validElement(PrtctdHstToATMReq),validElement(Hdr))|

