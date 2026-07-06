# casp.016.001.07-physical
```mermaid
classDiagram
    class ISO20022.Casp016001.Document {
        # Uri  : String
        + SaleToPOIDvcReq () : ISO20022.Casp016001.SaleToPOIDeviceRequestV07
        + Validation () = validation(validElement(SaleToPOIDvcReq))
    }
    class ISO20022.Casp016001.SaleToPOIDeviceRequestV07 {
        # owner  : ISO20022.Casp016001.Document
        + SctyTrlr  : ISO20022.Casp016001.ContentInformationType38
        + DvcReq  : ISO20022.Casp016001.DeviceRequest8
        + Hdr  : ISO20022.Casp016001.Header41
        + Validation () = validation(validElement(SctyTrlr),validElement(DvcReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Casp016001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SaleToPOIDvcReq|ISO20022.Casp016001.SaleToPOIDeviceRequestV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SaleToPOIDvcReq))|

---

## AspectImpl ISO20022.Casp016001.SaleToPOIDeviceRequestV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Casp016001.Document||||
|+|SctyTrlr|ISO20022.Casp016001.ContentInformationType38||XmlElement()||
|+|DvcReq|ISO20022.Casp016001.DeviceRequest8||XmlElement()||
|+|Hdr|ISO20022.Casp016001.Header41||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(DvcReq),validElement(Hdr))|

