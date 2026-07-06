# catp.014.001.02-physical
```mermaid
classDiagram
    class ISO20022.Catp014001.Document {
        # Uri  : String
        + ATMDpstCmpltnAdvc () : ISO20022.Catp014001.ATMDepositCompletionAdviceV02
        + Validation () = validation(validElement(ATMDpstCmpltnAdvc))
    }
    class ISO20022.Catp014001.ATMDepositCompletionAdviceV02 {
        # owner  : ISO20022.Catp014001.Document
        + SctyTrlr  : ISO20022.Catp014001.ContentInformationType15
        + ATMDpstCmpltnAdvc  : ISO20022.Catp014001.ATMDepositCompletionAdvice2
        + PrtctdATMDpstCmpltnAdvc  : ISO20022.Catp014001.ContentInformationType10
        + Hdr  : ISO20022.Catp014001.Header32
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMDpstCmpltnAdvc),validElement(PrtctdATMDpstCmpltnAdvc),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catp014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMDpstCmpltnAdvc|ISO20022.Catp014001.ATMDepositCompletionAdviceV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMDpstCmpltnAdvc))|

---

## AspectImpl ISO20022.Catp014001.ATMDepositCompletionAdviceV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catp014001.Document||||
|+|SctyTrlr|ISO20022.Catp014001.ContentInformationType15||XmlElement()||
|+|ATMDpstCmpltnAdvc|ISO20022.Catp014001.ATMDepositCompletionAdvice2||XmlElement()||
|+|PrtctdATMDpstCmpltnAdvc|ISO20022.Catp014001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Catp014001.Header32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMDpstCmpltnAdvc),validElement(PrtctdATMDpstCmpltnAdvc),validElement(Hdr))|

