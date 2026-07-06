# sese.027.002.07-physical
```mermaid
classDiagram
    class ISO20022.Sese027002.Document {
        # Uri  : String
        + SctiesTxCxlReqStsAdvc  : ISO20022.Sese027002.SecuritiesTransactionCancellationRequestStatusAdvice002V07
        + Validation () = validation(validElement(SctiesTxCxlReqStsAdvc))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Sese027002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctiesTxCxlReqStsAdvc|ISO20022.Sese027002.SecuritiesTransactionCancellationRequestStatusAdvice002V07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesTxCxlReqStsAdvc))|

