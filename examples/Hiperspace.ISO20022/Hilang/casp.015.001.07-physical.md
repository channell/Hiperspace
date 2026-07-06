# casp.015.001.07-physical
```mermaid
classDiagram
    class ISO20022.Casp015001.Document {
        # Uri  : String
        + SaleToPOIMsgStsRspn () : ISO20022.Casp015001.SaleToPOIMessageStatusResponseV07
        + Validation () = validation(validElement(SaleToPOIMsgStsRspn))
    }
    class ISO20022.Casp015001.SaleToPOIMessageStatusResponseV07 {
        # owner  : ISO20022.Casp015001.Document
        + SctyTrlr  : ISO20022.Casp015001.ContentInformationType38
        + StsRspn  : ISO20022.Casp015001.MessageStatusResponse9
        + Hdr  : ISO20022.Casp015001.Header41
        + Validation () = validation(validElement(SctyTrlr),validElement(StsRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Casp015001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SaleToPOIMsgStsRspn|ISO20022.Casp015001.SaleToPOIMessageStatusResponseV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SaleToPOIMsgStsRspn))|

---

## AspectImpl ISO20022.Casp015001.SaleToPOIMessageStatusResponseV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Casp015001.Document||||
|+|SctyTrlr|ISO20022.Casp015001.ContentInformationType38||XmlElement()||
|+|StsRspn|ISO20022.Casp015001.MessageStatusResponse9||XmlElement()||
|+|Hdr|ISO20022.Casp015001.Header41||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(StsRspn),validElement(Hdr))|

