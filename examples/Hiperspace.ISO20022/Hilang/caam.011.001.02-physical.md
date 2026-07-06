# caam.011.001.02-physical
```mermaid
classDiagram
    class ISO20022.Caam011001.Document {
        # Uri  : String
        + ATMXcptnAdvc () : ISO20022.Caam011001.ATMExceptionAdviceV02
        + Validation () = validation(validElement(ATMXcptnAdvc))
    }
    class ISO20022.Caam011001.ATMExceptionAdviceV02 {
        # owner  : ISO20022.Caam011001.Document
        + SctyTrlr  : ISO20022.Caam011001.ContentInformationType15
        + ATMXcptnAdvc  : ISO20022.Caam011001.ATMExceptionAdvice2
        + PrtctdATMXcptnAdvc  : ISO20022.Caam011001.ContentInformationType10
        + Hdr  : ISO20022.Caam011001.Header32
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMXcptnAdvc),validElement(PrtctdATMXcptnAdvc),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caam011001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMXcptnAdvc|ISO20022.Caam011001.ATMExceptionAdviceV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMXcptnAdvc))|

---

## AspectImpl ISO20022.Caam011001.ATMExceptionAdviceV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caam011001.Document||||
|+|SctyTrlr|ISO20022.Caam011001.ContentInformationType15||XmlElement()||
|+|ATMXcptnAdvc|ISO20022.Caam011001.ATMExceptionAdvice2||XmlElement()||
|+|PrtctdATMXcptnAdvc|ISO20022.Caam011001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam011001.Header32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMXcptnAdvc),validElement(PrtctdATMXcptnAdvc),validElement(Hdr))|

