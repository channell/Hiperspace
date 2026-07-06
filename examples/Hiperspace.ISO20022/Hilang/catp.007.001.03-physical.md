# catp.007.001.03-physical
```mermaid
classDiagram
    class ISO20022.Catp007001.Document {
        # Uri  : String
        + ATMNqryRspn () : ISO20022.Catp007001.ATMInquiryResponseV03
        + Validation () = validation(validElement(ATMNqryRspn))
    }
    class ISO20022.Catp007001.ATMInquiryResponseV03 {
        # owner  : ISO20022.Catp007001.Document
        + SctyTrlr  : ISO20022.Catp007001.ContentInformationType15
        + ATMNqryRspn  : ISO20022.Catp007001.ATMInquiryResponse3
        + PrtctdATMNqryRspn  : ISO20022.Catp007001.ContentInformationType10
        + Hdr  : ISO20022.Catp007001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMNqryRspn),validElement(PrtctdATMNqryRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catp007001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMNqryRspn|ISO20022.Catp007001.ATMInquiryResponseV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMNqryRspn))|

---

## AspectImpl ISO20022.Catp007001.ATMInquiryResponseV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catp007001.Document||||
|+|SctyTrlr|ISO20022.Catp007001.ContentInformationType15||XmlElement()||
|+|ATMNqryRspn|ISO20022.Catp007001.ATMInquiryResponse3||XmlElement()||
|+|PrtctdATMNqryRspn|ISO20022.Catp007001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Catp007001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMNqryRspn),validElement(PrtctdATMNqryRspn),validElement(Hdr))|

