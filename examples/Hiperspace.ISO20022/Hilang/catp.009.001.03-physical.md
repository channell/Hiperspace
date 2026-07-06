# catp.009.001.03-physical
```mermaid
classDiagram
    class ISO20022.Catp009001.Document {
        # Uri  : String
        + ATMCmpltnAck () : ISO20022.Catp009001.ATMCompletionAcknowledgementV03
        + Validation () = validation(validElement(ATMCmpltnAck))
    }
    class ISO20022.Catp009001.ATMCompletionAcknowledgementV03 {
        # owner  : ISO20022.Catp009001.Document
        + SctyTrlr  : ISO20022.Catp009001.ContentInformationType15
        + ATMCmpltnAck  : ISO20022.Catp009001.ATMCompletionAcknowledgement3
        + PrtctdATMCmpltnAck  : ISO20022.Catp009001.ContentInformationType10
        + Hdr  : ISO20022.Catp009001.Header32
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMCmpltnAck),validElement(PrtctdATMCmpltnAck),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catp009001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMCmpltnAck|ISO20022.Catp009001.ATMCompletionAcknowledgementV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMCmpltnAck))|

---

## AspectImpl ISO20022.Catp009001.ATMCompletionAcknowledgementV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catp009001.Document||||
|+|SctyTrlr|ISO20022.Catp009001.ContentInformationType15||XmlElement()||
|+|ATMCmpltnAck|ISO20022.Catp009001.ATMCompletionAcknowledgement3||XmlElement()||
|+|PrtctdATMCmpltnAck|ISO20022.Catp009001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Catp009001.Header32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMCmpltnAck),validElement(PrtctdATMCmpltnAck),validElement(Hdr))|

