# tsrv.010.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsrv010001.Document {
        # Uri  : String
        + UdrtkgNonXtnsnReq () : ISO20022.Tsrv010001.UndertakingNonExtensionRequestV01
        + Validation () = validation(validElement(UdrtkgNonXtnsnReq))
    }
    class ISO20022.Tsrv010001.UndertakingNonExtensionRequestV01 {
        # owner  : ISO20022.Tsrv010001.Document
        + DgtlSgntr  : ISO20022.Tsrv010001.PartyAndSignature2
        + UdrtkgNonXtnsnReqDtls  : ISO20022.Tsrv010001.UndertakingNonExtensionRequest1
        + Validation () = validation(validElement(DgtlSgntr),validElement(UdrtkgNonXtnsnReqDtls))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsrv010001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|UdrtkgNonXtnsnReq|ISO20022.Tsrv010001.UndertakingNonExtensionRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UdrtkgNonXtnsnReq))|

---

## AspectImpl ISO20022.Tsrv010001.UndertakingNonExtensionRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsrv010001.Document||||
|+|DgtlSgntr|ISO20022.Tsrv010001.PartyAndSignature2||XmlElement()||
|+|UdrtkgNonXtnsnReqDtls|ISO20022.Tsrv010001.UndertakingNonExtensionRequest1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validElement(UdrtkgNonXtnsnReqDtls))|

