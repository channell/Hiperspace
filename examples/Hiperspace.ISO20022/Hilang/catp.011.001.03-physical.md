# catp.011.001.03-physical
```mermaid
classDiagram
    class ISO20022.Catp011001.Document {
        # Uri  : String
        + ATMPINMgmtRspn () : ISO20022.Catp011001.ATMPINManagementResponseV03
        + Validation () = validation(validElement(ATMPINMgmtRspn))
    }
    class ISO20022.Catp011001.ATMPINManagementResponseV03 {
        # owner  : ISO20022.Catp011001.Document
        + SctyTrlr  : ISO20022.Catp011001.ContentInformationType15
        + ATMPINMgmtRspn  : ISO20022.Catp011001.ATMPINManagementResponse3
        + PrtctdATMPINMgmtRspn  : ISO20022.Catp011001.ContentInformationType10
        + Hdr  : ISO20022.Catp011001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMPINMgmtRspn),validElement(PrtctdATMPINMgmtRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catp011001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMPINMgmtRspn|ISO20022.Catp011001.ATMPINManagementResponseV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMPINMgmtRspn))|

---

## AspectImpl ISO20022.Catp011001.ATMPINManagementResponseV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catp011001.Document||||
|+|SctyTrlr|ISO20022.Catp011001.ContentInformationType15||XmlElement()||
|+|ATMPINMgmtRspn|ISO20022.Catp011001.ATMPINManagementResponse3||XmlElement()||
|+|PrtctdATMPINMgmtRspn|ISO20022.Catp011001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Catp011001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMPINMgmtRspn),validElement(PrtctdATMPINMgmtRspn),validElement(Hdr))|

