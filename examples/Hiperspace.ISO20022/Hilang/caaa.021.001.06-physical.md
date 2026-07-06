# caaa.021.001.06-physical
```mermaid
classDiagram
    class ISO20022.Caaa021001.Document {
        # Uri  : String
        + TxAdvcRspn () : ISO20022.Caaa021001.TransactionAdviceResponseV06
        + Validation () = validation(validElement(TxAdvcRspn))
    }
    class ISO20022.Caaa021001.TransactionAdviceResponseV06 {
        # owner  : ISO20022.Caaa021001.Document
        + SctyTrlr  : ISO20022.Caaa021001.ContentInformationType37
        + TxAdvcRspn  : ISO20022.Caaa021001.AcceptorCompletionAdviceResponse13
        + Hdr  : ISO20022.Caaa021001.Header70
        + Validation () = validation(validElement(SctyTrlr),validElement(TxAdvcRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caaa021001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|TxAdvcRspn|ISO20022.Caaa021001.TransactionAdviceResponseV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxAdvcRspn))|

---

## AspectImpl ISO20022.Caaa021001.TransactionAdviceResponseV06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caaa021001.Document||||
|+|SctyTrlr|ISO20022.Caaa021001.ContentInformationType37||XmlElement()||
|+|TxAdvcRspn|ISO20022.Caaa021001.AcceptorCompletionAdviceResponse13||XmlElement()||
|+|Hdr|ISO20022.Caaa021001.Header70||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(TxAdvcRspn),validElement(Hdr))|

