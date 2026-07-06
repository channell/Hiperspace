# caam.016.001.01-physical
```mermaid
classDiagram
    class ISO20022.Caam016001.Document {
        # Uri  : String
        + ATMRcncltnRspn () : ISO20022.Caam016001.ATMReconciliationResponseV01
        + Validation () = validation(validElement(ATMRcncltnRspn))
    }
    class ISO20022.Caam016001.ATMReconciliationResponseV01 {
        # owner  : ISO20022.Caam016001.Document
        + SctyTrlr  : ISO20022.Caam016001.ContentInformationType15
        + ATMRcncltnRspn  : ISO20022.Caam016001.ATMReconciliationRequestComponent1
        + PrtctdATMRcncltnRspn  : ISO20022.Caam016001.ContentInformationType10
        + Hdr  : ISO20022.Caam016001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMRcncltnRspn),validElement(PrtctdATMRcncltnRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caam016001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMRcncltnRspn|ISO20022.Caam016001.ATMReconciliationResponseV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMRcncltnRspn))|

---

## AspectImpl ISO20022.Caam016001.ATMReconciliationResponseV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caam016001.Document||||
|+|SctyTrlr|ISO20022.Caam016001.ContentInformationType15||XmlElement()||
|+|ATMRcncltnRspn|ISO20022.Caam016001.ATMReconciliationRequestComponent1||XmlElement()||
|+|PrtctdATMRcncltnRspn|ISO20022.Caam016001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam016001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMRcncltnRspn),validElement(PrtctdATMRcncltnRspn),validElement(Hdr))|

