# tsrv.003.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsrv003001.Document {
        # Uri  : String
        + UdrtkgIssncNtfctn () : ISO20022.Tsrv003001.UndertakingIssuanceNotificationV01
        + Validation () = validation(validElement(UdrtkgIssncNtfctn))
    }
    class ISO20022.Tsrv003001.UndertakingIssuanceNotificationV01 {
        # owner  : ISO20022.Tsrv003001.Document
        + DgtlSgntr  : ISO20022.Tsrv003001.PartyAndSignature2
        + UdrtkgIssncNtfctnDtls  : ISO20022.Tsrv003001.UndertakingAdvice2
        + Validation () = validation(validElement(DgtlSgntr),validElement(UdrtkgIssncNtfctnDtls))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsrv003001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|UdrtkgIssncNtfctn|ISO20022.Tsrv003001.UndertakingIssuanceNotificationV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UdrtkgIssncNtfctn))|

---

## AspectImpl ISO20022.Tsrv003001.UndertakingIssuanceNotificationV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsrv003001.Document||||
|+|DgtlSgntr|ISO20022.Tsrv003001.PartyAndSignature2||XmlElement()||
|+|UdrtkgIssncNtfctnDtls|ISO20022.Tsrv003001.UndertakingAdvice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validElement(UdrtkgIssncNtfctnDtls))|

