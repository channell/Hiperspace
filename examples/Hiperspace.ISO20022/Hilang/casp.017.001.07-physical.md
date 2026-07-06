# casp.017.001.07-physical
```mermaid
classDiagram
    class ISO20022.Casp017001.Document {
        # Uri  : String
        + SaleToPOIDvcRspn () : ISO20022.Casp017001.SaleToPOIDeviceResponseV07
        + Validation () = validation(validElement(SaleToPOIDvcRspn))
    }
    class ISO20022.Casp017001.SaleToPOIDeviceResponseV07 {
        # owner  : ISO20022.Casp017001.Document
        + SctyTrlr  : ISO20022.Casp017001.ContentInformationType38
        + DvcRspn  : ISO20022.Casp017001.DeviceResponse8
        + Hdr  : ISO20022.Casp017001.Header41
        + Validation () = validation(validElement(SctyTrlr),validElement(DvcRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Casp017001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SaleToPOIDvcRspn|ISO20022.Casp017001.SaleToPOIDeviceResponseV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SaleToPOIDvcRspn))|

---

## AspectImpl ISO20022.Casp017001.SaleToPOIDeviceResponseV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Casp017001.Document||||
|+|SctyTrlr|ISO20022.Casp017001.ContentInformationType38||XmlElement()||
|+|DvcRspn|ISO20022.Casp017001.DeviceResponse8||XmlElement()||
|+|Hdr|ISO20022.Casp017001.Header41||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(DvcRspn),validElement(Hdr))|

