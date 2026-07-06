# tsmt.029.001.02-physical
```mermaid
classDiagram
    class ISO20022.Tsmt029001.Document {
        # Uri  : String
        + StsChngReqRjctn () : ISO20022.Tsmt029001.StatusChangeRequestRejectionV02
        + Validation () = validation(validElement(StsChngReqRjctn))
    }
    class ISO20022.Tsmt029001.StatusChangeRequestRejectionV02 {
        # owner  : ISO20022.Tsmt029001.Document
        + RjctnRsn  : ISO20022.Tsmt029001.Reason2
        + RjctdStsChng  : ISO20022.Tsmt029001.TransactionStatus3
        + SubmitrTxRef  : ISO20022.Tsmt029001.SimpleIdentificationInformation
        + TxId  : ISO20022.Tsmt029001.SimpleIdentificationInformation
        + RjctnId  : ISO20022.Tsmt029001.MessageIdentification1
        + Validation () = validation(validElement(RjctnRsn),validElement(RjctdStsChng),validElement(SubmitrTxRef),validElement(TxId),validElement(RjctnId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt029001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|StsChngReqRjctn|ISO20022.Tsmt029001.StatusChangeRequestRejectionV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StsChngReqRjctn))|

---

## AspectImpl ISO20022.Tsmt029001.StatusChangeRequestRejectionV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt029001.Document||||
|+|RjctnRsn|ISO20022.Tsmt029001.Reason2||XmlElement()||
|+|RjctdStsChng|ISO20022.Tsmt029001.TransactionStatus3||XmlElement()||
|+|SubmitrTxRef|ISO20022.Tsmt029001.SimpleIdentificationInformation||XmlElement()||
|+|TxId|ISO20022.Tsmt029001.SimpleIdentificationInformation||XmlElement()||
|+|RjctnId|ISO20022.Tsmt029001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RjctnRsn),validElement(RjctdStsChng),validElement(SubmitrTxRef),validElement(TxId),validElement(RjctnId))|

