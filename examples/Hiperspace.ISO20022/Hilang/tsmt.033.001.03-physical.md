# tsmt.033.001.03-physical
```mermaid
classDiagram
    class ISO20022.Tsmt033001.Document {
        # Uri  : String
        + StsXtnsnReqRjctn () : ISO20022.Tsmt033001.StatusExtensionRequestRejectionV03
        + Validation () = validation(validElement(StsXtnsnReqRjctn))
    }
    class ISO20022.Tsmt033001.StatusExtensionRequestRejectionV03 {
        # owner  : ISO20022.Tsmt033001.Document
        + RjctnRsn  : ISO20022.Tsmt033001.Reason2
        + StsNotToBeXtnded  : ISO20022.Tsmt033001.TransactionStatus4
        + SubmitrTxRef  : ISO20022.Tsmt033001.SimpleIdentificationInformation
        + TxId  : ISO20022.Tsmt033001.SimpleIdentificationInformation
        + RjctnId  : ISO20022.Tsmt033001.MessageIdentification1
        + Validation () = validation(validElement(RjctnRsn),validElement(StsNotToBeXtnded),validElement(SubmitrTxRef),validElement(TxId),validElement(RjctnId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt033001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|StsXtnsnReqRjctn|ISO20022.Tsmt033001.StatusExtensionRequestRejectionV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StsXtnsnReqRjctn))|

---

## AspectImpl ISO20022.Tsmt033001.StatusExtensionRequestRejectionV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt033001.Document||||
|+|RjctnRsn|ISO20022.Tsmt033001.Reason2||XmlElement()||
|+|StsNotToBeXtnded|ISO20022.Tsmt033001.TransactionStatus4||XmlElement()||
|+|SubmitrTxRef|ISO20022.Tsmt033001.SimpleIdentificationInformation||XmlElement()||
|+|TxId|ISO20022.Tsmt033001.SimpleIdentificationInformation||XmlElement()||
|+|RjctnId|ISO20022.Tsmt033001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RjctnRsn),validElement(StsNotToBeXtnded),validElement(SubmitrTxRef),validElement(TxId),validElement(RjctnId))|

