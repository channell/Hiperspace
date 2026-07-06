# caaa.010.001.12-physical
```mermaid
classDiagram
    class ISO20022.Caaa010001.Document {
        # Uri  : String
        + AccptrRcncltnRspn () : ISO20022.Caaa010001.AcceptorReconciliationResponseV12
        + Validation () = validation(validElement(AccptrRcncltnRspn))
    }
    class ISO20022.Caaa010001.AcceptorReconciliationResponseV12 {
        # owner  : ISO20022.Caaa010001.Document
        + SctyTrlr  : ISO20022.Caaa010001.ContentInformationType37
        + RcncltnRspn  : ISO20022.Caaa010001.AcceptorReconciliationResponse11
        + Hdr  : ISO20022.Caaa010001.Header70
        + Validation () = validation(validElement(SctyTrlr),validElement(RcncltnRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caaa010001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AccptrRcncltnRspn|ISO20022.Caaa010001.AcceptorReconciliationResponseV12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrRcncltnRspn))|

---

## AspectImpl ISO20022.Caaa010001.AcceptorReconciliationResponseV12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caaa010001.Document||||
|+|SctyTrlr|ISO20022.Caaa010001.ContentInformationType37||XmlElement()||
|+|RcncltnRspn|ISO20022.Caaa010001.AcceptorReconciliationResponse11||XmlElement()||
|+|Hdr|ISO20022.Caaa010001.Header70||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(RcncltnRspn),validElement(Hdr))|

