# seev.034.002.15-physical
```mermaid
classDiagram
    class ISO20022.Seev034002.Document {
        # Uri  : String
        + CorpActnInstrStsAdvc  : ISO20022.Seev034002.CorporateActionInstructionStatusAdvice002V15
        + Validation () = validation(validElement(CorpActnInstrStsAdvc))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Seev034002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CorpActnInstrStsAdvc|ISO20022.Seev034002.CorporateActionInstructionStatusAdvice002V15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnInstrStsAdvc))|

