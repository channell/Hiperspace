# setr.005.001.04-physical
```mermaid
classDiagram
    class ISO20022.Setr005001.Document {
        # Uri  : String
        + RedOrdrCxlReq  : ISO20022.Setr005001.RedemptionOrderCancellationRequestV04
        + Validation () = validation(validElement(RedOrdrCxlReq))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Setr005001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RedOrdrCxlReq|ISO20022.Setr005001.RedemptionOrderCancellationRequestV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RedOrdrCxlReq))|

