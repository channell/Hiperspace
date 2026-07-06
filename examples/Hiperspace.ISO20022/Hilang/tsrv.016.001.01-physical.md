# tsrv.016.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsrv016001.Document {
        # Uri  : String
        + DmndRfslNtfctn () : ISO20022.Tsrv016001.DemandRefusalNotificationV01
        + Validation () = validation(validElement(DmndRfslNtfctn))
    }
    class ISO20022.Tsrv016001.DemandRefusalNotificationV01 {
        # owner  : ISO20022.Tsrv016001.Document
        + DgtlSgntr  : ISO20022.Tsrv016001.PartyAndSignature2
        + DmndRfslNtfctnDtls  : List~ISO20022.Tsrv016001.DemandRefusal1~
        + Validation () = validation(validElement(DgtlSgntr),validList("""DmndRfslNtfctnDtls""",DmndRfslNtfctnDtls),validElement(DmndRfslNtfctnDtls))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsrv016001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|DmndRfslNtfctn|ISO20022.Tsrv016001.DemandRefusalNotificationV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DmndRfslNtfctn))|

---

## AspectImpl ISO20022.Tsrv016001.DemandRefusalNotificationV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsrv016001.Document||||
|+|DgtlSgntr|ISO20022.Tsrv016001.PartyAndSignature2||XmlElement()||
|+|DmndRfslNtfctnDtls|List<ISO20022.Tsrv016001.DemandRefusal1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validList("""DmndRfslNtfctnDtls""",DmndRfslNtfctnDtls),validElement(DmndRfslNtfctnDtls))|

