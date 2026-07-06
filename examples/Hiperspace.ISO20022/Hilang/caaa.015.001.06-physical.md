# caaa.015.001.06-physical
```mermaid
classDiagram
    class ISO20022.Caaa015001.Document {
        # Uri  : String
        + AccptrRjctn () : ISO20022.Caaa015001.AcceptorRejectionV06
        + Validation () = validation(validElement(AccptrRjctn))
    }
    class ISO20022.Caaa015001.AcceptorRejectionV06 {
        # owner  : ISO20022.Caaa015001.Document
        + Rjct  : ISO20022.Caaa015001.AcceptorRejection2
        + Hdr  : ISO20022.Caaa015001.Header57
        + Validation () = validation(validElement(Rjct),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caaa015001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AccptrRjctn|ISO20022.Caaa015001.AcceptorRejectionV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrRjctn))|

---

## AspectImpl ISO20022.Caaa015001.AcceptorRejectionV06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caaa015001.Document||||
|+|Rjct|ISO20022.Caaa015001.AcceptorRejection2||XmlElement()||
|+|Hdr|ISO20022.Caaa015001.Header57||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rjct),validElement(Hdr))|

