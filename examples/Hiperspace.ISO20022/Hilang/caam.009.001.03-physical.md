# caam.009.001.03-physical
```mermaid
classDiagram
    class ISO20022.Caam009001.Document {
        # Uri  : String
        + ATMRcncltnAdvc () : ISO20022.Caam009001.ATMReconciliationAdviceV03
        + Validation () = validation(validElement(ATMRcncltnAdvc))
    }
    class ISO20022.Caam009001.ATMReconciliationAdviceV03 {
        # owner  : ISO20022.Caam009001.Document
        + SctyTrlr  : ISO20022.Caam009001.ContentInformationType15
        + ATMRcncltnAdvc  : ISO20022.Caam009001.ATMReconciliationAdvice3
        + PrtctdATMRcncltnAdvc  : ISO20022.Caam009001.ContentInformationType10
        + Hdr  : ISO20022.Caam009001.Header32
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMRcncltnAdvc),validElement(PrtctdATMRcncltnAdvc),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caam009001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMRcncltnAdvc|ISO20022.Caam009001.ATMReconciliationAdviceV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMRcncltnAdvc))|

---

## AspectImpl ISO20022.Caam009001.ATMReconciliationAdviceV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caam009001.Document||||
|+|SctyTrlr|ISO20022.Caam009001.ContentInformationType15||XmlElement()||
|+|ATMRcncltnAdvc|ISO20022.Caam009001.ATMReconciliationAdvice3||XmlElement()||
|+|PrtctdATMRcncltnAdvc|ISO20022.Caam009001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam009001.Header32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMRcncltnAdvc),validElement(PrtctdATMRcncltnAdvc),validElement(Hdr))|

