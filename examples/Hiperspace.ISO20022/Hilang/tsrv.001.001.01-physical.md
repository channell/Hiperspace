# tsrv.001.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsrv001001.Document {
        # Uri  : String
        + UdrtkgIssnc () : ISO20022.Tsrv001001.UndertakingIssuanceV01
        + Validation () = validation(validElement(UdrtkgIssnc))
    }
    class ISO20022.Tsrv001001.UndertakingIssuanceV01 {
        # owner  : ISO20022.Tsrv001001.Document
        + DgtlSgntr  : List~ISO20022.Tsrv001001.PartyAndSignature2~
        + BkToBkInf  : List~String~
        + BkToBnfcryInf  : List~String~
        + UdrtkgIssncDtls  : ISO20022.Tsrv001001.Undertaking3
        + Validation () = validation(validList("""DgtlSgntr""",DgtlSgntr),validElement(DgtlSgntr),validListMax("""BkToBkInf""",BkToBkInf,5),validListMax("""BkToBnfcryInf""",BkToBnfcryInf,5),validElement(UdrtkgIssncDtls))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsrv001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|UdrtkgIssnc|ISO20022.Tsrv001001.UndertakingIssuanceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UdrtkgIssnc))|

---

## AspectImpl ISO20022.Tsrv001001.UndertakingIssuanceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsrv001001.Document||||
|+|DgtlSgntr|List<ISO20022.Tsrv001001.PartyAndSignature2>||XmlElement()||
|+|BkToBkInf|List<String>||XmlElement()||
|+|BkToBnfcryInf|List<String>||XmlElement()||
|+|UdrtkgIssncDtls|ISO20022.Tsrv001001.Undertaking3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DgtlSgntr""",DgtlSgntr),validElement(DgtlSgntr),validListMax("""BkToBkInf""",BkToBkInf,5),validListMax("""BkToBnfcryInf""",BkToBnfcryInf,5),validElement(UdrtkgIssncDtls))|

