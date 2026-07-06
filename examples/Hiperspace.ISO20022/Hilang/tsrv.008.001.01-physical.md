# tsrv.008.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsrv008001.Document {
        # Uri  : String
        + UdrtkgAmdmntRspn () : ISO20022.Tsrv008001.UndertakingAmendmentResponseV01
        + Validation () = validation(validElement(UdrtkgAmdmntRspn))
    }
    class ISO20022.Tsrv008001.UndertakingAmendmentResponseV01 {
        # owner  : ISO20022.Tsrv008001.Document
        + DgtlSgntr  : ISO20022.Tsrv008001.PartyAndSignature2
        + UdrtkgAmdmntRspnDtls  : ISO20022.Tsrv008001.Amendment7
        + Validation () = validation(validElement(DgtlSgntr),validElement(UdrtkgAmdmntRspnDtls))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsrv008001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|UdrtkgAmdmntRspn|ISO20022.Tsrv008001.UndertakingAmendmentResponseV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UdrtkgAmdmntRspn))|

---

## AspectImpl ISO20022.Tsrv008001.UndertakingAmendmentResponseV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsrv008001.Document||||
|+|DgtlSgntr|ISO20022.Tsrv008001.PartyAndSignature2||XmlElement()||
|+|UdrtkgAmdmntRspnDtls|ISO20022.Tsrv008001.Amendment7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validElement(UdrtkgAmdmntRspnDtls))|

