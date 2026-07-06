# catp.001.001.03-physical
```mermaid
classDiagram
    class ISO20022.Catp001001.Document {
        # Uri  : String
        + ATMWdrwlReq () : ISO20022.Catp001001.ATMWithdrawalRequestV03
        + Validation () = validation(validElement(ATMWdrwlReq))
    }
    class ISO20022.Catp001001.ATMWithdrawalRequestV03 {
        # owner  : ISO20022.Catp001001.Document
        + SctyTrlr  : ISO20022.Catp001001.ContentInformationType15
        + ATMWdrwlReq  : ISO20022.Catp001001.ATMWithdrawalRequest3
        + PrtctdATMWdrwlReq  : ISO20022.Catp001001.ContentInformationType10
        + Hdr  : ISO20022.Catp001001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMWdrwlReq),validElement(PrtctdATMWdrwlReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catp001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMWdrwlReq|ISO20022.Catp001001.ATMWithdrawalRequestV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMWdrwlReq))|

---

## AspectImpl ISO20022.Catp001001.ATMWithdrawalRequestV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catp001001.Document||||
|+|SctyTrlr|ISO20022.Catp001001.ContentInformationType15||XmlElement()||
|+|ATMWdrwlReq|ISO20022.Catp001001.ATMWithdrawalRequest3||XmlElement()||
|+|PrtctdATMWdrwlReq|ISO20022.Catp001001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Catp001001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMWdrwlReq),validElement(PrtctdATMWdrwlReq),validElement(Hdr))|

