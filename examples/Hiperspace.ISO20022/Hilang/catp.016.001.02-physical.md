# catp.016.001.02-physical
```mermaid
classDiagram
    class ISO20022.Catp016001.Document {
        # Uri  : String
        + ATMTrfReq () : ISO20022.Catp016001.ATMTransferRequestV02
        + Validation () = validation(validElement(ATMTrfReq))
    }
    class ISO20022.Catp016001.ATMTransferRequestV02 {
        # owner  : ISO20022.Catp016001.Document
        + SctyTrlr  : ISO20022.Catp016001.ContentInformationType15
        + ATMTrfReq  : ISO20022.Catp016001.ATMTransferRequest2
        + PrtctdATMTrfReq  : ISO20022.Catp016001.ContentInformationType10
        + Hdr  : ISO20022.Catp016001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMTrfReq),validElement(PrtctdATMTrfReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catp016001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMTrfReq|ISO20022.Catp016001.ATMTransferRequestV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMTrfReq))|

---

## AspectImpl ISO20022.Catp016001.ATMTransferRequestV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catp016001.Document||||
|+|SctyTrlr|ISO20022.Catp016001.ContentInformationType15||XmlElement()||
|+|ATMTrfReq|ISO20022.Catp016001.ATMTransferRequest2||XmlElement()||
|+|PrtctdATMTrfReq|ISO20022.Catp016001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Catp016001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMTrfReq),validElement(PrtctdATMTrfReq),validElement(Hdr))|

