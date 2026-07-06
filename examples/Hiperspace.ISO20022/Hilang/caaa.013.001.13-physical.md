# caaa.013.001.13-physical
```mermaid
classDiagram
    class ISO20022.Caaa013001.Document {
        # Uri  : String
        + AccptrDgnstcReq () : ISO20022.Caaa013001.AcceptorDiagnosticRequestV13
        + Validation () = validation(validElement(AccptrDgnstcReq))
    }
    class ISO20022.Caaa013001.AcceptorDiagnosticRequestV13 {
        # owner  : ISO20022.Caaa013001.Document
        + SctyTrlr  : ISO20022.Caaa013001.ContentInformationType37
        + DgnstcReq  : ISO20022.Caaa013001.AcceptorDiagnosticRequest13
        + Hdr  : ISO20022.Caaa013001.Header70
        + Validation () = validation(validElement(SctyTrlr),validElement(DgnstcReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caaa013001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AccptrDgnstcReq|ISO20022.Caaa013001.AcceptorDiagnosticRequestV13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrDgnstcReq))|

---

## AspectImpl ISO20022.Caaa013001.AcceptorDiagnosticRequestV13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caaa013001.Document||||
|+|SctyTrlr|ISO20022.Caaa013001.ContentInformationType37||XmlElement()||
|+|DgnstcReq|ISO20022.Caaa013001.AcceptorDiagnosticRequest13||XmlElement()||
|+|Hdr|ISO20022.Caaa013001.Header70||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(DgnstcReq),validElement(Hdr))|

