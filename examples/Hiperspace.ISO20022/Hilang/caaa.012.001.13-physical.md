# caaa.012.001.13-physical
```mermaid
classDiagram
    class ISO20022.Caaa012001.Document {
        # Uri  : String
        + AccptrBtchTrfRspn () : ISO20022.Caaa012001.AcceptorBatchTransferResponseV13
        + Validation () = validation(validElement(AccptrBtchTrfRspn))
    }
    class ISO20022.Caaa012001.AcceptorBatchTransferResponseV13 {
        # owner  : ISO20022.Caaa012001.Document
        + SctyTrlr  : ISO20022.Caaa012001.ContentInformationType37
        + BtchTrfRspn  : ISO20022.Caaa012001.CardPaymentBatchTransferResponse12
        + Hdr  : ISO20022.Caaa012001.Header56
        + Validation () = validation(validElement(SctyTrlr),validElement(BtchTrfRspn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caaa012001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AccptrBtchTrfRspn|ISO20022.Caaa012001.AcceptorBatchTransferResponseV13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptrBtchTrfRspn))|

---

## AspectImpl ISO20022.Caaa012001.AcceptorBatchTransferResponseV13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caaa012001.Document||||
|+|SctyTrlr|ISO20022.Caaa012001.ContentInformationType37||XmlElement()||
|+|BtchTrfRspn|ISO20022.Caaa012001.CardPaymentBatchTransferResponse12||XmlElement()||
|+|Hdr|ISO20022.Caaa012001.Header56||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(BtchTrfRspn),validElement(Hdr))|

