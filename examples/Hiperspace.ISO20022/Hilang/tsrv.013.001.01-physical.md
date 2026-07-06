# tsrv.013.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsrv013001.Document {
        # Uri  : String
        + UdrtkgDmnd () : ISO20022.Tsrv013001.UndertakingDemandV01
        + Validation () = validation(validElement(UdrtkgDmnd))
    }
    class ISO20022.Tsrv013001.UndertakingDemandV01 {
        # owner  : ISO20022.Tsrv013001.Document
        + DgtlSgntr  : ISO20022.Tsrv013001.PartyAndSignature2
        + BkToBkInf  : List~String~
        + UdrtkgDmndDtls  : ISO20022.Tsrv013001.Demand1
        + Validation () = validation(validElement(DgtlSgntr),validListMax("""BkToBkInf""",BkToBkInf,5),validElement(UdrtkgDmndDtls))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsrv013001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|UdrtkgDmnd|ISO20022.Tsrv013001.UndertakingDemandV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UdrtkgDmnd))|

---

## AspectImpl ISO20022.Tsrv013001.UndertakingDemandV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsrv013001.Document||||
|+|DgtlSgntr|ISO20022.Tsrv013001.PartyAndSignature2||XmlElement()||
|+|BkToBkInf|List<String>||XmlElement()||
|+|UdrtkgDmndDtls|ISO20022.Tsrv013001.Demand1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validListMax("""BkToBkInf""",BkToBkInf,5),validElement(UdrtkgDmndDtls))|

