# catp.005.001.02-physical
```mermaid
classDiagram
    class ISO20022.Catp005001.Document {
        # Uri  : String
        + ATMRjct () : ISO20022.Catp005001.ATMRejectV02
        + Validation () = validation(validElement(ATMRjct))
    }
    class ISO20022.Catp005001.ATMRejectV02 {
        # owner  : ISO20022.Catp005001.Document
        + ATMRjct  : ISO20022.Catp005001.ATMReject2
        + Hdr  : ISO20022.Catp005001.Header33
        + Validation () = validation(validElement(ATMRjct),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Catp005001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ATMRjct|ISO20022.Catp005001.ATMRejectV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMRjct))|

---

## AspectImpl ISO20022.Catp005001.ATMRejectV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Catp005001.Document||||
|+|ATMRjct|ISO20022.Catp005001.ATMReject2||XmlElement()||
|+|Hdr|ISO20022.Catp005001.Header33||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ATMRjct),validElement(Hdr))|

