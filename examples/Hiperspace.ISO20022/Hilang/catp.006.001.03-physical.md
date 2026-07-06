# catp.006.001.03-physical
```mermaid
classDiagram
    class ISO20022.Catp006001.Document {
        # Uri  : String
        + ATMNqryReq () : ISO20022.Catp006001.ATMInquiryRequestV03
        + Validation () = validation(validElement(ATMNqryReq))
    }
    class ISO20022.Catp006001.ATMInquiryRequestV03 {
        # owner  : ISO20022.Catp006001.Document
        + SctyTrlr  : ISO20022.Catp006001.ContentInformationType15
        + ATMNqryReq  : ISO20022.Catp006001.ATMInquiryRequest3
        + PrtctdATMNqryReq  : ISO20022.Catp006001.ContentInformationType10
        + Hdr  : ISO20022.Catp006001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMNqryReq),validElement(PrtctdATMNqryReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catp006001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMNqryReq|ISO20022.Catp006001.ATMInquiryRequestV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMNqryReq))|

---

## AspectImpl ISO20022.Catp006001.ATMInquiryRequestV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catp006001.Document||||
|+|SctyTrlr|ISO20022.Catp006001.ContentInformationType15||XmlElement()||
|+|ATMNqryReq|ISO20022.Catp006001.ATMInquiryRequest3||XmlElement()||
|+|PrtctdATMNqryReq|ISO20022.Catp006001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Catp006001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMNqryReq),validElement(PrtctdATMNqryReq),validElement(Hdr))|

