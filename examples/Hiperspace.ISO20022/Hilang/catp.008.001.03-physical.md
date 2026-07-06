# catp.008.001.03-physical
```mermaid
classDiagram
    class ISO20022.Catp008001.Document {
        # Uri  : String
        + ATMCmpltnAdvc () : ISO20022.Catp008001.ATMCompletionAdviceV03
        + Validation () = validation(validElement(ATMCmpltnAdvc))
    }
    class ISO20022.Catp008001.ATMCompletionAdviceV03 {
        # owner  : ISO20022.Catp008001.Document
        + SctyTrlr  : ISO20022.Catp008001.ContentInformationType15
        + ATMCmpltnAdvc  : ISO20022.Catp008001.ATMCompletionAdvice3
        + PrtctdATMCmpltnAdvc  : ISO20022.Catp008001.ContentInformationType10
        + Hdr  : ISO20022.Catp008001.Header32
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMCmpltnAdvc),validElement(PrtctdATMCmpltnAdvc),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catp008001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMCmpltnAdvc|ISO20022.Catp008001.ATMCompletionAdviceV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMCmpltnAdvc))|

---

## AspectImpl ISO20022.Catp008001.ATMCompletionAdviceV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catp008001.Document||||
|+|SctyTrlr|ISO20022.Catp008001.ContentInformationType15||XmlElement()||
|+|ATMCmpltnAdvc|ISO20022.Catp008001.ATMCompletionAdvice3||XmlElement()||
|+|PrtctdATMCmpltnAdvc|ISO20022.Catp008001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Catp008001.Header32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMCmpltnAdvc),validElement(PrtctdATMCmpltnAdvc),validElement(Hdr))|

