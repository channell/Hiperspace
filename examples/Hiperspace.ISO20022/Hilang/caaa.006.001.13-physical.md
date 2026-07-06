# caaa.006.001.13-physical
```mermaid
classDiagram
    class ISO20022.Caaa006001.Document {
        # Uri  : String
        + AccptrCxlRspn () : ISO20022.Caaa006001.AcceptorCancellationResponseV13
        + Validation () = validation(validElement(AccptrCxlRspn))
    }
    class ISO20022.Caaa006001.AcceptorCancellationResponseV13 {
        # owner  : ISO20022.Caaa006001.Document
        + SctyTrlr  : ISO20022.Caaa006001.ContentInformationType37
        + CxlRspn  : ISO20022.Caaa006001.AcceptorCancellationResponse13
        + Hdr  : ISO20022.Caaa006001.Header70
        + Validation () = validation(validElement(SctyTrlr),validElement(CxlRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caaa006001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AccptrCxlRspn|ISO20022.Caaa006001.AcceptorCancellationResponseV13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrCxlRspn))|

---

## AspectImpl ISO20022.Caaa006001.AcceptorCancellationResponseV13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caaa006001.Document||||
|+|SctyTrlr|ISO20022.Caaa006001.ContentInformationType37||XmlElement()||
|+|CxlRspn|ISO20022.Caaa006001.AcceptorCancellationResponse13||XmlElement()||
|+|Hdr|ISO20022.Caaa006001.Header70||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(CxlRspn),validElement(Hdr))|

