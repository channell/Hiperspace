# sese.020.002.07-physical
```mermaid
classDiagram
    class ISO20022.Sese020002.Document {
        # Uri  : String
        + SctiesTxCxlReq  : ISO20022.Sese020002.SecuritiesTransactionCancellationRequest002V07
        + Validation () = validation(validElement(SctiesTxCxlReq))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Sese020002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctiesTxCxlReq|ISO20022.Sese020002.SecuritiesTransactionCancellationRequest002V07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesTxCxlReq))|

