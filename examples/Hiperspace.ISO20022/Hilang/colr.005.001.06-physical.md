# colr.005.001.06-physical
```mermaid
classDiagram
    class ISO20022.Colr005001.Document {
        # Uri  : String
        + CollMgmtCxlReq  : ISO20022.Colr005001.CollateralManagementCancellationRequestV06
        + Validation () = validation(validElement(CollMgmtCxlReq))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Colr005001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CollMgmtCxlReq|ISO20022.Colr005001.CollateralManagementCancellationRequestV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollMgmtCxlReq))|

