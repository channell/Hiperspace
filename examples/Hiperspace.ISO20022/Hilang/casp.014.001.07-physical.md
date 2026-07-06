# casp.014.001.07-physical
```mermaid
classDiagram
    class ISO20022.Casp014001.Document {
        # Uri  : String
        + SaleToPOIMsgStsReq () : ISO20022.Casp014001.SaleToPOIMessageStatusRequestV07
        + Validation () = validation(validElement(SaleToPOIMsgStsReq))
    }
    class ISO20022.Casp014001.SaleToPOIMessageStatusRequestV07 {
        # owner  : ISO20022.Casp014001.Document
        + SctyTrlr  : ISO20022.Casp014001.ContentInformationType38
        + StsReq  : ISO20022.Casp014001.MessageStatusRequest8
        + Hdr  : ISO20022.Casp014001.Header41
        + Validation () = validation(validElement(SctyTrlr),validElement(StsReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Casp014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SaleToPOIMsgStsReq|ISO20022.Casp014001.SaleToPOIMessageStatusRequestV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SaleToPOIMsgStsReq))|

---

## AspectImpl ISO20022.Casp014001.SaleToPOIMessageStatusRequestV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Casp014001.Document||||
|+|SctyTrlr|ISO20022.Casp014001.ContentInformationType38||XmlElement()||
|+|StsReq|ISO20022.Casp014001.MessageStatusRequest8||XmlElement()||
|+|Hdr|ISO20022.Casp014001.Header41||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(StsReq),validElement(Hdr))|

