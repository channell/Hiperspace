# caaa.002.001.14-physical
```mermaid
classDiagram
    class ISO20022.Caaa002001.Document {
        # Uri  : String
        + AccptrAuthstnRspn () : ISO20022.Caaa002001.AcceptorAuthorisationResponseV14
        + Validation () = validation(validElement(AccptrAuthstnRspn))
    }
    class ISO20022.Caaa002001.AcceptorAuthorisationResponseV14 {
        # owner  : ISO20022.Caaa002001.Document
        + SctyTrlr  : ISO20022.Caaa002001.ContentInformationType37
        + AuthstnRspn  : ISO20022.Caaa002001.AcceptorAuthorisationResponse14
        + Hdr  : ISO20022.Caaa002001.Header70
        + Validation () = validation(validElement(SctyTrlr),validElement(AuthstnRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caaa002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AccptrAuthstnRspn|ISO20022.Caaa002001.AcceptorAuthorisationResponseV14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrAuthstnRspn))|

---

## AspectImpl ISO20022.Caaa002001.AcceptorAuthorisationResponseV14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caaa002001.Document||||
|+|SctyTrlr|ISO20022.Caaa002001.ContentInformationType37||XmlElement()||
|+|AuthstnRspn|ISO20022.Caaa002001.AcceptorAuthorisationResponse14||XmlElement()||
|+|Hdr|ISO20022.Caaa002001.Header70||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(AuthstnRspn),validElement(Hdr))|

