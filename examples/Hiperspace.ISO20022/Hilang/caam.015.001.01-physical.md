# caam.015.001.01-physical
```mermaid
classDiagram
    class ISO20022.Caam015001.Document {
        # Uri  : String
        + ATMRcncltnReq () : ISO20022.Caam015001.ATMReconciliationRequestV01
        + Validation () = validation(validElement(ATMRcncltnReq))
    }
    class ISO20022.Caam015001.ATMReconciliationRequestV01 {
        # owner  : ISO20022.Caam015001.Document
        + SctyTrlr  : ISO20022.Caam015001.ContentInformationType15
        + ATMRcncltnReq  : ISO20022.Caam015001.ATMReconciliationRequestComponent1
        + PrtctdATMRcncltnReq  : ISO20022.Caam015001.ContentInformationType10
        + Hdr  : ISO20022.Caam015001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMRcncltnReq),validElement(PrtctdATMRcncltnReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caam015001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMRcncltnReq|ISO20022.Caam015001.ATMReconciliationRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMRcncltnReq))|

---

## AspectImpl ISO20022.Caam015001.ATMReconciliationRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caam015001.Document||||
|+|SctyTrlr|ISO20022.Caam015001.ContentInformationType15||XmlElement()||
|+|ATMRcncltnReq|ISO20022.Caam015001.ATMReconciliationRequestComponent1||XmlElement()||
|+|PrtctdATMRcncltnReq|ISO20022.Caam015001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam015001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMRcncltnReq),validElement(PrtctdATMRcncltnReq),validElement(Hdr))|

