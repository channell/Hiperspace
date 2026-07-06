# casp.001.001.07-physical
```mermaid
classDiagram
    class ISO20022.Casp001001.Document {
        # Uri  : String
        + SaleToPOISvcReq () : ISO20022.Casp001001.SaleToPOIServiceRequestV07
        + Validation () = validation(validElement(SaleToPOISvcReq))
    }
    class ISO20022.Casp001001.SaleToPOIServiceRequestV07 {
        # owner  : ISO20022.Casp001001.Document
        + SctyTrlr  : ISO20022.Casp001001.ContentInformationType38
        + SvcReq  : ISO20022.Casp001001.ServiceRequest8
        + Hdr  : ISO20022.Casp001001.Header41
        + Validation () = validation(validElement(SctyTrlr),validElement(SvcReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Casp001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SaleToPOISvcReq|ISO20022.Casp001001.SaleToPOIServiceRequestV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SaleToPOISvcReq))|

---

## AspectImpl ISO20022.Casp001001.SaleToPOIServiceRequestV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Casp001001.Document||||
|+|SctyTrlr|ISO20022.Casp001001.ContentInformationType38||XmlElement()||
|+|SvcReq|ISO20022.Casp001001.ServiceRequest8||XmlElement()||
|+|Hdr|ISO20022.Casp001001.Header41||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(SvcReq),validElement(Hdr))|

