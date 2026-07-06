# caam.003.001.04-physical
```mermaid
classDiagram
    class ISO20022.Caam003001.Document {
        # Uri  : String
        + ATMKeyDwnldReq () : ISO20022.Caam003001.ATMKeyDownloadRequestV04
        + Validation () = validation(validElement(ATMKeyDwnldReq))
    }
    class ISO20022.Caam003001.ATMKeyDownloadRequestV04 {
        # owner  : ISO20022.Caam003001.Document
        + SctyTrlr  : ISO20022.Caam003001.ContentInformationType13
        + ATMKeyDwnldReq  : ISO20022.Caam003001.ATMKeyDownloadRequest5
        + PrtctdATMKeyDwnldReq  : ISO20022.Caam003001.ContentInformationType10
        + Hdr  : ISO20022.Caam003001.Header31
        + Validation () = validation(validElement(SctyTrlr),validElement(ATMKeyDwnldReq),validElement(PrtctdATMKeyDwnldReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caam003001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMKeyDwnldReq|ISO20022.Caam003001.ATMKeyDownloadRequestV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMKeyDwnldReq))|

---

## AspectImpl ISO20022.Caam003001.ATMKeyDownloadRequestV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caam003001.Document||||
|+|SctyTrlr|ISO20022.Caam003001.ContentInformationType13||XmlElement()||
|+|ATMKeyDwnldReq|ISO20022.Caam003001.ATMKeyDownloadRequest5||XmlElement()||
|+|PrtctdATMKeyDwnldReq|ISO20022.Caam003001.ContentInformationType10||XmlElement()||
|+|Hdr|ISO20022.Caam003001.Header31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(ATMKeyDwnldReq),validElement(PrtctdATMKeyDwnldReq),validElement(Hdr))|

