# caaa.020.001.06-physical
```mermaid
classDiagram
    class ISO20022.Caaa020001.Document {
        # Uri  : String
        + TxAdvc () : ISO20022.Caaa020001.TransactionAdviceV06
        + Validation () = validation(validElement(TxAdvc))
    }
    class ISO20022.Caaa020001.TransactionAdviceV06 {
        # owner  : ISO20022.Caaa020001.Document
        + SctyTrlr  : ISO20022.Caaa020001.ContentInformationType37
        + TxAdvc  : ISO20022.Caaa020001.AcceptorCompletionAdvice14
        + Hdr  : ISO20022.Caaa020001.Header70
        + Validation () = validation(validElement(SctyTrlr),validElement(TxAdvc),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caaa020001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|TxAdvc|ISO20022.Caaa020001.TransactionAdviceV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxAdvc))|

---

## AspectImpl ISO20022.Caaa020001.TransactionAdviceV06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caaa020001.Document||||
|+|SctyTrlr|ISO20022.Caaa020001.ContentInformationType37||XmlElement()||
|+|TxAdvc|ISO20022.Caaa020001.AcceptorCompletionAdvice14||XmlElement()||
|+|Hdr|ISO20022.Caaa020001.Header70||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(TxAdvc),validElement(Hdr))|

