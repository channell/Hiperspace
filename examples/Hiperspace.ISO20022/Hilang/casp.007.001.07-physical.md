# casp.007.001.07-physical
```mermaid
classDiagram
    class ISO20022.Casp007001.Document {
        # Uri  : String
        + SaleToPOIAdmstvReq () : ISO20022.Casp007001.SaleToPOIAdministrativeRequestV07
        + Validation () = validation(validElement(SaleToPOIAdmstvReq))
    }
    class ISO20022.Casp007001.SaleToPOIAdministrativeRequestV07 {
        # owner  : ISO20022.Casp007001.Document
        + SctyTrlr  : ISO20022.Casp007001.ContentInformationType38
        + AdmstvReq  : ISO20022.Casp007001.AdministrativeRequest8
        + Hdr  : ISO20022.Casp007001.Header41
        + Validation () = validation(validElement(SctyTrlr),validElement(AdmstvReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Casp007001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SaleToPOIAdmstvReq|ISO20022.Casp007001.SaleToPOIAdministrativeRequestV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SaleToPOIAdmstvReq))|

---

## AspectImpl ISO20022.Casp007001.SaleToPOIAdministrativeRequestV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Casp007001.Document||||
|+|SctyTrlr|ISO20022.Casp007001.ContentInformationType38||XmlElement()||
|+|AdmstvReq|ISO20022.Casp007001.AdministrativeRequest8||XmlElement()||
|+|Hdr|ISO20022.Casp007001.Header41||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(AdmstvReq),validElement(Hdr))|

