# caaa.001.001.14-physical
```mermaid
classDiagram
    class ISO20022.Caaa001001.Document {
        # Uri  : String
        + AccptrAuthstnReq () : ISO20022.Caaa001001.AcceptorAuthorisationRequestV14
        + Validation () = validation(validElement(AccptrAuthstnReq))
    }
    class ISO20022.Caaa001001.AcceptorAuthorisationRequestV14 {
        # owner  : ISO20022.Caaa001001.Document
        + SctyTrlr  : ISO20022.Caaa001001.ContentInformationType37
        + AuthstnReq  : ISO20022.Caaa001001.AcceptorAuthorisationRequest14
        + Hdr  : ISO20022.Caaa001001.Header70
        + Validation () = validation(validElement(SctyTrlr),validElement(AuthstnReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caaa001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AccptrAuthstnReq|ISO20022.Caaa001001.AcceptorAuthorisationRequestV14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrAuthstnReq))|

---

## AspectImpl ISO20022.Caaa001001.AcceptorAuthorisationRequestV14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caaa001001.Document||||
|+|SctyTrlr|ISO20022.Caaa001001.ContentInformationType37||XmlElement()||
|+|AuthstnReq|ISO20022.Caaa001001.AcceptorAuthorisationRequest14||XmlElement()||
|+|Hdr|ISO20022.Caaa001001.Header70||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(AuthstnReq),validElement(Hdr))|

