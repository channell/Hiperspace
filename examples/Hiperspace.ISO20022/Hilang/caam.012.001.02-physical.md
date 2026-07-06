# caam.012.001.02-physical
```mermaid
classDiagram
    class ISO20022.Caam012001.Document {
        # Uri  : String
        + ATMXcptnAck () : ISO20022.Caam012001.ATMExceptionAcknowledgementV02
        + Validation () = validation(validElement(ATMXcptnAck))
    }
    class ISO20022.Caam012001.ATMExceptionAcknowledgementV02 {
        # owner  : ISO20022.Caam012001.Document
        + SctyTrlr  : ISO20022.Caam012001.ContentInformationType15
        + ATMXcptnAck  : ISO20022.Caam012001.ATMExceptionAcknowledgement2
        + PrtctdATMXcptnAck  : ISO20022.Caam012001.ContentInformationType10
        + Hdr  : ISO20022.Caam012001.Header32
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMXcptnAck),validElement(PrtctdATMXcptnAck),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caam012001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMXcptnAck|ISO20022.Caam012001.ATMExceptionAcknowledgementV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMXcptnAck))|

---

## AspectImpl ISO20022.Caam012001.ATMExceptionAcknowledgementV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caam012001.Document||||
|+|SctyTrlr|ISO20022.Caam012001.ContentInformationType15||XmlElement()||
|+|ATMXcptnAck|ISO20022.Caam012001.ATMExceptionAcknowledgement2||XmlElement()||
|+|PrtctdATMXcptnAck|ISO20022.Caam012001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam012001.Header32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMXcptnAck),validElement(PrtctdATMXcptnAck),validElement(Hdr))|

