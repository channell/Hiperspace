# caaa.014.001.12-physical
```mermaid
classDiagram
    class ISO20022.Caaa014001.Document {
        # Uri  : String
        + AccptrDgnstcRspn () : ISO20022.Caaa014001.AcceptorDiagnosticResponseV12
        + Validation () = validation(validElement(AccptrDgnstcRspn))
    }
    class ISO20022.Caaa014001.AcceptorDiagnosticResponseV12 {
        # owner  : ISO20022.Caaa014001.Document
        + SctyTrlr  : ISO20022.Caaa014001.ContentInformationType37
        + DgnstcRspn  : ISO20022.Caaa014001.AcceptorDiagnosticResponse11
        + Hdr  : ISO20022.Caaa014001.Header70
        + Validation () = validation(validElement(SctyTrlr),validElement(DgnstcRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caaa014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AccptrDgnstcRspn|ISO20022.Caaa014001.AcceptorDiagnosticResponseV12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrDgnstcRspn))|

---

## AspectImpl ISO20022.Caaa014001.AcceptorDiagnosticResponseV12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caaa014001.Document||||
|+|SctyTrlr|ISO20022.Caaa014001.ContentInformationType37||XmlElement()||
|+|DgnstcRspn|ISO20022.Caaa014001.AcceptorDiagnosticResponse11||XmlElement()||
|+|Hdr|ISO20022.Caaa014001.Header70||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(DgnstcRspn),validElement(Hdr))|

