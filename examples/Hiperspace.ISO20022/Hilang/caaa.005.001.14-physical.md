# caaa.005.001.14-physical
```mermaid
classDiagram
    class ISO20022.Caaa005001.Document {
        # Uri  : String
        + AccptrCxlReq () : ISO20022.Caaa005001.AcceptorCancellationRequestV14
        + Validation () = validation(validElement(AccptrCxlReq))
    }
    class ISO20022.Caaa005001.AcceptorCancellationRequestV14 {
        # owner  : ISO20022.Caaa005001.Document
        + SctyTrlr  : ISO20022.Caaa005001.ContentInformationType37
        + CxlReq  : ISO20022.Caaa005001.AcceptorCancellationRequest14
        + Hdr  : ISO20022.Caaa005001.Header70
        + Validation () = validation(validElement(SctyTrlr),validElement(CxlReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caaa005001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AccptrCxlReq|ISO20022.Caaa005001.AcceptorCancellationRequestV14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrCxlReq))|

---

## AspectImpl ISO20022.Caaa005001.AcceptorCancellationRequestV14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caaa005001.Document||||
|+|SctyTrlr|ISO20022.Caaa005001.ContentInformationType37||XmlElement()||
|+|CxlReq|ISO20022.Caaa005001.AcceptorCancellationRequest14||XmlElement()||
|+|Hdr|ISO20022.Caaa005001.Header70||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(CxlReq),validElement(Hdr))|

