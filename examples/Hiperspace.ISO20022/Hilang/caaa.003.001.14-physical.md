# caaa.003.001.14-physical
```mermaid
classDiagram
    class ISO20022.Caaa003001.Document {
        # Uri  : String
        + AccptrCmpltnAdvc () : ISO20022.Caaa003001.AcceptorCompletionAdviceV14
        + Validation () = validation(validElement(AccptrCmpltnAdvc))
    }
    class ISO20022.Caaa003001.AcceptorCompletionAdviceV14 {
        # owner  : ISO20022.Caaa003001.Document
        + SctyTrlr  : ISO20022.Caaa003001.ContentInformationType37
        + CmpltnAdvc  : ISO20022.Caaa003001.AcceptorCompletionAdvice14
        + Hdr  : ISO20022.Caaa003001.Header70
        + Validation () = validation(validElement(SctyTrlr),validElement(CmpltnAdvc),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caaa003001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AccptrCmpltnAdvc|ISO20022.Caaa003001.AcceptorCompletionAdviceV14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrCmpltnAdvc))|

---

## AspectImpl ISO20022.Caaa003001.AcceptorCompletionAdviceV14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caaa003001.Document||||
|+|SctyTrlr|ISO20022.Caaa003001.ContentInformationType37||XmlElement()||
|+|CmpltnAdvc|ISO20022.Caaa003001.AcceptorCompletionAdvice14||XmlElement()||
|+|Hdr|ISO20022.Caaa003001.Header70||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(CmpltnAdvc),validElement(Hdr))|

