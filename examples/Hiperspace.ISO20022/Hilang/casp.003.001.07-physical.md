# casp.003.001.07-physical
```mermaid
classDiagram
    class ISO20022.Casp003001.Document {
        # Uri  : String
        + SaleToPOIRcncltnReq () : ISO20022.Casp003001.SaleToPOIReconciliationRequestV07
        + Validation () = validation(validElement(SaleToPOIRcncltnReq))
    }
    class ISO20022.Casp003001.SaleToPOIReconciliationRequestV07 {
        # owner  : ISO20022.Casp003001.Document
        + SctyTrlr  : ISO20022.Casp003001.ContentInformationType38
        + RcncltnReq  : ISO20022.Casp003001.ReconciliationRequest8
        + Hdr  : ISO20022.Casp003001.Header41
        + Validation () = validation(validElement(SctyTrlr),validElement(RcncltnReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Casp003001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SaleToPOIRcncltnReq|ISO20022.Casp003001.SaleToPOIReconciliationRequestV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SaleToPOIRcncltnReq))|

---

## AspectImpl ISO20022.Casp003001.SaleToPOIReconciliationRequestV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Casp003001.Document||||
|+|SctyTrlr|ISO20022.Casp003001.ContentInformationType38||XmlElement()||
|+|RcncltnReq|ISO20022.Casp003001.ReconciliationRequest8||XmlElement()||
|+|Hdr|ISO20022.Casp003001.Header41||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(RcncltnReq),validElement(Hdr))|

