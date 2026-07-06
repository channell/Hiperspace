# catp.002.001.03-physical
```mermaid
classDiagram
    class ISO20022.Catp002001.Document {
        # Uri  : String
        + ATMWdrwlRspn () : ISO20022.Catp002001.ATMWithdrawalResponseV03
        + Validation () = validation(validElement(ATMWdrwlRspn))
    }
    class ISO20022.Catp002001.ATMWithdrawalResponseV03 {
        # owner  : ISO20022.Catp002001.Document
        + SctyTrlr  : ISO20022.Catp002001.ContentInformationType15
        + ATMWdrwlRspn  : ISO20022.Catp002001.ATMWithdrawalResponse3
        + PrtctdATMWdrwlRspn  : ISO20022.Catp002001.ContentInformationType10
        + Hdr  : ISO20022.Catp002001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMWdrwlRspn),validElement(PrtctdATMWdrwlRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catp002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMWdrwlRspn|ISO20022.Catp002001.ATMWithdrawalResponseV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMWdrwlRspn))|

---

## AspectImpl ISO20022.Catp002001.ATMWithdrawalResponseV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catp002001.Document||||
|+|SctyTrlr|ISO20022.Catp002001.ContentInformationType15||XmlElement()||
|+|ATMWdrwlRspn|ISO20022.Catp002001.ATMWithdrawalResponse3||XmlElement()||
|+|PrtctdATMWdrwlRspn|ISO20022.Catp002001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Catp002001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMWdrwlRspn),validElement(PrtctdATMWdrwlRspn),validElement(Hdr))|

