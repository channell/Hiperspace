# tsrv.002.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsrv002001.Document {
        # Uri  : String
        + UdrtkgIssncAdvc () : ISO20022.Tsrv002001.UndertakingIssuanceAdviceV01
        + Validation () = validation(validElement(UdrtkgIssncAdvc))
    }
    class ISO20022.Tsrv002001.UndertakingIssuanceAdviceV01 {
        # owner  : ISO20022.Tsrv002001.Document
        + DgtlSgntr  : ISO20022.Tsrv002001.PartyAndSignature2
        + BkToBkInf  : List~String~
        + UdrtkgIssncAdvcDtls  : ISO20022.Tsrv002001.UndertakingAdvice1
        + DtOfAdvc  : ISO20022.Tsrv002001.DateAndDateTimeChoice
        + ScndAdvsgPty  : ISO20022.Tsrv002001.PartyIdentification43
        + AdvsgPty  : ISO20022.Tsrv002001.PartyIdentification43
        + Validation () = validation(validElement(DgtlSgntr),validListMax("""BkToBkInf""",BkToBkInf,5),validElement(UdrtkgIssncAdvcDtls),validElement(DtOfAdvc),validElement(ScndAdvsgPty),validElement(AdvsgPty))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsrv002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|UdrtkgIssncAdvc|ISO20022.Tsrv002001.UndertakingIssuanceAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UdrtkgIssncAdvc))|

---

## AspectImpl ISO20022.Tsrv002001.UndertakingIssuanceAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsrv002001.Document||||
|+|DgtlSgntr|ISO20022.Tsrv002001.PartyAndSignature2||XmlElement()||
|+|BkToBkInf|List<String>||XmlElement()||
|+|UdrtkgIssncAdvcDtls|ISO20022.Tsrv002001.UndertakingAdvice1||XmlElement()||
|+|DtOfAdvc|ISO20022.Tsrv002001.DateAndDateTimeChoice||XmlElement()||
|+|ScndAdvsgPty|ISO20022.Tsrv002001.PartyIdentification43||XmlElement()||
|+|AdvsgPty|ISO20022.Tsrv002001.PartyIdentification43||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validListMax("""BkToBkInf""",BkToBkInf,5),validElement(UdrtkgIssncAdvcDtls),validElement(DtOfAdvc),validElement(ScndAdvsgPty),validElement(AdvsgPty))|

