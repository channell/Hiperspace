# casp.013.001.02-physical
```mermaid
classDiagram
    class ISO20022.Casp013001.Document {
        # Uri  : String
        + SaleToPOIMsgRjctn () : ISO20022.Casp013001.SaleToPOIMessageRejectionV02
        + Validation () = validation(validElement(SaleToPOIMsgRjctn))
    }
    class ISO20022.Casp013001.SaleToPOIMessageRejectionV02 {
        # owner  : ISO20022.Casp013001.Document
        + Rjct  : ISO20022.Casp013001.AcceptorRejection2
        + Hdr  : ISO20022.Casp013001.Header41
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

## EntityImpl ISO20022.Casp013001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SaleToPOIMsgRjctn|ISO20022.Casp013001.SaleToPOIMessageRejectionV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SaleToPOIMsgRjctn))|

---

## AspectImpl ISO20022.Casp013001.SaleToPOIMessageRejectionV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Casp013001.Document||||
|+|Rjct|ISO20022.Casp013001.AcceptorRejection2||XmlElement()||
|+|Hdr|ISO20022.Casp013001.Header41||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rjct),validElement(Hdr))|

