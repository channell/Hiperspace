# caaa.018.001.09-physical
```mermaid
classDiagram
    class ISO20022.Caaa018001.Document {
        # Uri  : String
        + AccptrCcyConvsAdvc  : ISO20022.Caaa018001.AcceptorCurrencyConversionAdviceV09
        + Validation () = validation(validElement(AccptrCcyConvsAdvc))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caaa018001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AccptrCcyConvsAdvc|ISO20022.Caaa018001.AcceptorCurrencyConversionAdviceV09||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrCcyConvsAdvc))|

