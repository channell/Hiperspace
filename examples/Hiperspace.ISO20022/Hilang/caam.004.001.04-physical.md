# caam.004.001.04-physical
```mermaid
classDiagram
    class ISO20022.Caam004001.Document {
        # Uri  : String
        + ATMKeyDwnldRspn () : ISO20022.Caam004001.ATMKeyDownloadResponseV04
        + Validation () = validation(validElement(ATMKeyDwnldRspn))
    }
    class ISO20022.Caam004001.ATMKeyDownloadResponseV04 {
        # owner  : ISO20022.Caam004001.Document
        + SctyTrlr  : ISO20022.Caam004001.ContentInformationType13
        + ATMKeyDwnldRspn  : ISO20022.Caam004001.ATMKeyDownloadResponse5
        + PrtctdATMKeyDwnldRspn  : ISO20022.Caam004001.ContentInformationType10
        + Hdr  : ISO20022.Caam004001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMKeyDwnldRspn),validElement(PrtctdATMKeyDwnldRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caam004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMKeyDwnldRspn|ISO20022.Caam004001.ATMKeyDownloadResponseV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMKeyDwnldRspn))|

---

## AspectImpl ISO20022.Caam004001.ATMKeyDownloadResponseV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caam004001.Document||||
|+|SctyTrlr|ISO20022.Caam004001.ContentInformationType13||XmlElement()||
|+|ATMKeyDwnldRspn|ISO20022.Caam004001.ATMKeyDownloadResponse5||XmlElement()||
|+|PrtctdATMKeyDwnldRspn|ISO20022.Caam004001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam004001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMKeyDwnldRspn),validElement(PrtctdATMKeyDwnldRspn),validElement(Hdr))|

