# catp.003.001.03-physical
```mermaid
classDiagram
    class ISO20022.Catp003001.Document {
        # Uri  : String
        + ATMWdrwlCmpltnAdvc () : ISO20022.Catp003001.ATMWithdrawalCompletionAdviceV03
        + Validation () = validation(validElement(ATMWdrwlCmpltnAdvc))
    }
    class ISO20022.Catp003001.ATMWithdrawalCompletionAdviceV03 {
        # owner  : ISO20022.Catp003001.Document
        + SctyTrlr  : ISO20022.Catp003001.ContentInformationType15
        + ATMWdrwlCmpltnAdvc  : ISO20022.Catp003001.ATMWithdrawalCompletionAdvice3
        + PrtctdATMWdrwlCmpltnAdvc  : ISO20022.Catp003001.ContentInformationType10
        + Hdr  : ISO20022.Catp003001.Header32
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMWdrwlCmpltnAdvc),validElement(PrtctdATMWdrwlCmpltnAdvc),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catp003001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMWdrwlCmpltnAdvc|ISO20022.Catp003001.ATMWithdrawalCompletionAdviceV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMWdrwlCmpltnAdvc))|

---

## AspectImpl ISO20022.Catp003001.ATMWithdrawalCompletionAdviceV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catp003001.Document||||
|+|SctyTrlr|ISO20022.Catp003001.ContentInformationType15||XmlElement()||
|+|ATMWdrwlCmpltnAdvc|ISO20022.Catp003001.ATMWithdrawalCompletionAdvice3||XmlElement()||
|+|PrtctdATMWdrwlCmpltnAdvc|ISO20022.Catp003001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Catp003001.Header32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMWdrwlCmpltnAdvc),validElement(PrtctdATMWdrwlCmpltnAdvc),validElement(Hdr))|

