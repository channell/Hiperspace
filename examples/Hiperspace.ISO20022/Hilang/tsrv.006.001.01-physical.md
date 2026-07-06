# tsrv.006.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsrv006001.Document {
        # Uri  : String
        + UdrtkgAmdmntAdvc () : ISO20022.Tsrv006001.UndertakingAmendmentAdviceV01
        + Validation () = validation(validElement(UdrtkgAmdmntAdvc))
    }
    class ISO20022.Tsrv006001.UndertakingAmendmentAdviceV01 {
        # owner  : ISO20022.Tsrv006001.Document
        + DgtlSgntr  : ISO20022.Tsrv006001.PartyAndSignature2
        + BkToBkInf  : List~String~
        + UdrtkgAmdmntAdvcDtls  : ISO20022.Tsrv006001.Amendment2
        + DtOfAdvc  : DateTime
        + ScndAdvsgPty  : ISO20022.Tsrv006001.PartyIdentification43
        + AdvsgPty  : ISO20022.Tsrv006001.PartyIdentification43
        + Validation () = validation(validElement(DgtlSgntr),validListMax("""BkToBkInf""",BkToBkInf,5),validElement(UdrtkgAmdmntAdvcDtls),validElement(ScndAdvsgPty),validElement(AdvsgPty))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsrv006001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|UdrtkgAmdmntAdvc|ISO20022.Tsrv006001.UndertakingAmendmentAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UdrtkgAmdmntAdvc))|

---

## AspectImpl ISO20022.Tsrv006001.UndertakingAmendmentAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsrv006001.Document||||
|+|DgtlSgntr|ISO20022.Tsrv006001.PartyAndSignature2||XmlElement()||
|+|BkToBkInf|List<String>||XmlElement()||
|+|UdrtkgAmdmntAdvcDtls|ISO20022.Tsrv006001.Amendment2||XmlElement()||
|+|DtOfAdvc|DateTime||XmlElement()||
|+|ScndAdvsgPty|ISO20022.Tsrv006001.PartyIdentification43||XmlElement()||
|+|AdvsgPty|ISO20022.Tsrv006001.PartyIdentification43||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validListMax("""BkToBkInf""",BkToBkInf,5),validElement(UdrtkgAmdmntAdvcDtls),validElement(ScndAdvsgPty),validElement(AdvsgPty))|

