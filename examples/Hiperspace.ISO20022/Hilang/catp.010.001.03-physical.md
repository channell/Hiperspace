# catp.010.001.03-physical
```mermaid
classDiagram
    class ISO20022.Catp010001.Document {
        # Uri  : String
        + ATMPINMgmtReq () : ISO20022.Catp010001.ATMPINManagementRequestV03
        + Validation () = validation(validElement(ATMPINMgmtReq))
    }
    class ISO20022.Catp010001.ATMPINManagementRequestV03 {
        # owner  : ISO20022.Catp010001.Document
        + SctyTrlr  : ISO20022.Catp010001.ContentInformationType15
        + ATMPINMgmtReq  : ISO20022.Catp010001.ATMPINManagementRequest3
        + PrtctdATMPINMgmtReq  : ISO20022.Catp010001.ContentInformationType10
        + Hdr  : ISO20022.Catp010001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMPINMgmtReq),validElement(PrtctdATMPINMgmtReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catp010001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMPINMgmtReq|ISO20022.Catp010001.ATMPINManagementRequestV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMPINMgmtReq))|

---

## AspectImpl ISO20022.Catp010001.ATMPINManagementRequestV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catp010001.Document||||
|+|SctyTrlr|ISO20022.Catp010001.ContentInformationType15||XmlElement()||
|+|ATMPINMgmtReq|ISO20022.Catp010001.ATMPINManagementRequest3||XmlElement()||
|+|PrtctdATMPINMgmtReq|ISO20022.Catp010001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Catp010001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMPINMgmtReq),validElement(PrtctdATMPINMgmtReq),validElement(Hdr))|

