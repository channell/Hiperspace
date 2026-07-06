# tsrv.004.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsrv004001.Document {
        # Uri  : String
        + UdrtkgAmdmntReq () : ISO20022.Tsrv004001.UndertakingAmendmentRequestV01
        + Validation () = validation(validElement(UdrtkgAmdmntReq))
    }
    class ISO20022.Tsrv004001.UndertakingAmendmentRequestV01 {
        # owner  : ISO20022.Tsrv004001.Document
        + DgtlSgntr  : ISO20022.Tsrv004001.PartyAndSignature2
        + InstrsToBk  : List~String~
        + UdrtkgAmdmntReqDtls  : ISO20022.Tsrv004001.Amendment3
        + Validation () = validation(validElement(DgtlSgntr),validListMax("""InstrsToBk""",InstrsToBk,5),validElement(UdrtkgAmdmntReqDtls))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsrv004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|UdrtkgAmdmntReq|ISO20022.Tsrv004001.UndertakingAmendmentRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UdrtkgAmdmntReq))|

---

## AspectImpl ISO20022.Tsrv004001.UndertakingAmendmentRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsrv004001.Document||||
|+|DgtlSgntr|ISO20022.Tsrv004001.PartyAndSignature2||XmlElement()||
|+|InstrsToBk|List<String>||XmlElement()||
|+|UdrtkgAmdmntReqDtls|ISO20022.Tsrv004001.Amendment3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validListMax("""InstrsToBk""",InstrsToBk,5),validElement(UdrtkgAmdmntReqDtls))|

