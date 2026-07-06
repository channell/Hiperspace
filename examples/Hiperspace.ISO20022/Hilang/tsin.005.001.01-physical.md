# tsin.005.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsin005001.Document {
        # Uri  : String
        + UdrtkgAppl () : ISO20022.Tsin005001.UndertakingApplicationV01
        + Validation () = validation(validElement(UdrtkgAppl))
    }
    class ISO20022.Tsin005001.UndertakingApplicationV01 {
        # owner  : ISO20022.Tsin005001.Document
        + DgtlSgntr  : ISO20022.Tsin005001.PartyAndSignature2
        + InstrsToBk  : List~String~
        + UdrtkgApplDtls  : ISO20022.Tsin005001.Undertaking1
        + Validation () = validation(validElement(DgtlSgntr),validListMax("""InstrsToBk""",InstrsToBk,5),validElement(UdrtkgApplDtls))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsin005001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|UdrtkgAppl|ISO20022.Tsin005001.UndertakingApplicationV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UdrtkgAppl))|

---

## AspectImpl ISO20022.Tsin005001.UndertakingApplicationV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsin005001.Document||||
|+|DgtlSgntr|ISO20022.Tsin005001.PartyAndSignature2||XmlElement()||
|+|InstrsToBk|List<String>||XmlElement()||
|+|UdrtkgApplDtls|ISO20022.Tsin005001.Undertaking1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validListMax("""InstrsToBk""",InstrsToBk,5),validElement(UdrtkgApplDtls))|

