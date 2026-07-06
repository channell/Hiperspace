# tsmt.035.001.03-physical
```mermaid
classDiagram
    class ISO20022.Tsmt035001.Document {
        # Uri  : String
        + StsXtnsnReq () : ISO20022.Tsmt035001.StatusExtensionRequestV03
        + Validation () = validation(validElement(StsXtnsnReq))
    }
    class ISO20022.Tsmt035001.StatusExtensionRequestV03 {
        # owner  : ISO20022.Tsmt035001.Document
        + StsToBeXtnded  : ISO20022.Tsmt035001.TransactionStatus5
        + SubmitrTxRef  : ISO20022.Tsmt035001.SimpleIdentificationInformation
        + TxId  : ISO20022.Tsmt035001.SimpleIdentificationInformation
        + ReqId  : ISO20022.Tsmt035001.MessageIdentification1
        + Validation () = validation(validElement(StsToBeXtnded),validElement(SubmitrTxRef),validElement(TxId),validElement(ReqId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt035001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|StsXtnsnReq|ISO20022.Tsmt035001.StatusExtensionRequestV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StsXtnsnReq))|

---

## AspectImpl ISO20022.Tsmt035001.StatusExtensionRequestV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt035001.Document||||
|+|StsToBeXtnded|ISO20022.Tsmt035001.TransactionStatus5||XmlElement()||
|+|SubmitrTxRef|ISO20022.Tsmt035001.SimpleIdentificationInformation||XmlElement()||
|+|TxId|ISO20022.Tsmt035001.SimpleIdentificationInformation||XmlElement()||
|+|ReqId|ISO20022.Tsmt035001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StsToBeXtnded),validElement(SubmitrTxRef),validElement(TxId),validElement(ReqId))|

