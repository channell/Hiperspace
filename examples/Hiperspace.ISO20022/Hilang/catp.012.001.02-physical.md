# catp.012.001.02-physical
```mermaid
classDiagram
    class ISO20022.Catp012001.Document {
        # Uri  : String
        + ATMDpstReq () : ISO20022.Catp012001.ATMDepositRequestV02
        + Validation () = validation(validElement(ATMDpstReq))
    }
    class ISO20022.Catp012001.ATMDepositRequestV02 {
        # owner  : ISO20022.Catp012001.Document
        + SctyTrlr  : ISO20022.Catp012001.ContentInformationType15
        + ATMDpstReq  : ISO20022.Catp012001.ATMDepositRequest2
        + PrtctdATMDpstReq  : ISO20022.Catp012001.ContentInformationType10
        + Hdr  : ISO20022.Catp012001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMDpstReq),validElement(PrtctdATMDpstReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catp012001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMDpstReq|ISO20022.Catp012001.ATMDepositRequestV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMDpstReq))|

---

## AspectImpl ISO20022.Catp012001.ATMDepositRequestV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catp012001.Document||||
|+|SctyTrlr|ISO20022.Catp012001.ContentInformationType15||XmlElement()||
|+|ATMDpstReq|ISO20022.Catp012001.ATMDepositRequest2||XmlElement()||
|+|PrtctdATMDpstReq|ISO20022.Catp012001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Catp012001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMDpstReq),validElement(PrtctdATMDpstReq),validElement(Hdr))|

