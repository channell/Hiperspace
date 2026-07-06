# caaa.011.001.14-physical
```mermaid
classDiagram
    class ISO20022.Caaa011001.Document {
        # Uri  : String
        + AccptrBtchTrf () : ISO20022.Caaa011001.AcceptorBatchTransferV14
        + Validation () = validation(validElement(AccptrBtchTrf))
    }
    class ISO20022.Caaa011001.AcceptorBatchTransferV14 {
        # owner  : ISO20022.Caaa011001.Document
        + SctyTrlr  : ISO20022.Caaa011001.ContentInformationType37
        + BtchTrf  : ISO20022.Caaa011001.CardPaymentBatchTransfer13
        + Hdr  : ISO20022.Caaa011001.Header56
        + Validation () = validation(validElement(SctyTrlr),validElement(BtchTrf),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caaa011001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AccptrBtchTrf|ISO20022.Caaa011001.AcceptorBatchTransferV14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrBtchTrf))|

---

## AspectImpl ISO20022.Caaa011001.AcceptorBatchTransferV14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caaa011001.Document||||
|+|SctyTrlr|ISO20022.Caaa011001.ContentInformationType37||XmlElement()||
|+|BtchTrf|ISO20022.Caaa011001.CardPaymentBatchTransfer13||XmlElement()||
|+|Hdr|ISO20022.Caaa011001.Header56||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(BtchTrf),validElement(Hdr))|

