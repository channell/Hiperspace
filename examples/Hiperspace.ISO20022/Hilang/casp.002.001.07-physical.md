# casp.002.001.07-physical
```mermaid
classDiagram
    class ISO20022.Casp002001.Document {
        # Uri  : String
        + SaleToPOISvcRspn () : ISO20022.Casp002001.SaleToPOIServiceResponseV07
        + Validation () = validation(validElement(SaleToPOISvcRspn))
    }
    class ISO20022.Casp002001.SaleToPOIServiceResponseV07 {
        # owner  : ISO20022.Casp002001.Document
        + SctyTrlr  : ISO20022.Casp002001.ContentInformationType38
        + SvcRspn  : ISO20022.Casp002001.ServiceResponse9
        + Hdr  : ISO20022.Casp002001.Header41
        + Validation () = validation(validElement(SctyTrlr),validElement(SvcRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Casp002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SaleToPOISvcRspn|ISO20022.Casp002001.SaleToPOIServiceResponseV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SaleToPOISvcRspn))|

---

## AspectImpl ISO20022.Casp002001.SaleToPOIServiceResponseV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Casp002001.Document||||
|+|SctyTrlr|ISO20022.Casp002001.ContentInformationType38||XmlElement()||
|+|SvcRspn|ISO20022.Casp002001.ServiceResponse9||XmlElement()||
|+|Hdr|ISO20022.Casp002001.Header41||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(SvcRspn),validElement(Hdr))|

