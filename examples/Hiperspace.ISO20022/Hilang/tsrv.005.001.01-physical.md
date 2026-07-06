# tsrv.005.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsrv005001.Document {
        # Uri  : String
        + UdrtkgAmdmnt () : ISO20022.Tsrv005001.UndertakingAmendmentV01
        + Validation () = validation(validElement(UdrtkgAmdmnt))
    }
    class ISO20022.Tsrv005001.UndertakingAmendmentV01 {
        # owner  : ISO20022.Tsrv005001.Document
        + DgtlSgntr  : List~ISO20022.Tsrv005001.PartyAndSignature2~
        + BkToBkInf  : List~String~
        + UdrtkgAmdmntDtls  : ISO20022.Tsrv005001.Amendment1
        + Validation () = validation(validList("""DgtlSgntr""",DgtlSgntr),validElement(DgtlSgntr),validListMax("""BkToBkInf""",BkToBkInf,5),validElement(UdrtkgAmdmntDtls))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsrv005001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|UdrtkgAmdmnt|ISO20022.Tsrv005001.UndertakingAmendmentV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UdrtkgAmdmnt))|

---

## AspectImpl ISO20022.Tsrv005001.UndertakingAmendmentV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsrv005001.Document||||
|+|DgtlSgntr|List<ISO20022.Tsrv005001.PartyAndSignature2>||XmlElement()||
|+|BkToBkInf|List<String>||XmlElement()||
|+|UdrtkgAmdmntDtls|ISO20022.Tsrv005001.Amendment1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DgtlSgntr""",DgtlSgntr),validElement(DgtlSgntr),validListMax("""BkToBkInf""",BkToBkInf,5),validElement(UdrtkgAmdmntDtls))|

