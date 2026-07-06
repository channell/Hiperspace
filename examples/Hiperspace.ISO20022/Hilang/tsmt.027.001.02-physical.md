# tsmt.027.001.02-physical
```mermaid
classDiagram
    class ISO20022.Tsmt027001.Document {
        # Uri  : String
        + StsChngReqAccptnc () : ISO20022.Tsmt027001.StatusChangeRequestAcceptanceV02
        + Validation () = validation(validElement(StsChngReqAccptnc))
    }
    class ISO20022.Tsmt027001.StatusChangeRequestAcceptanceV02 {
        # owner  : ISO20022.Tsmt027001.Document
        + AccptdSts  : ISO20022.Tsmt027001.TransactionStatus3
        + SubmitrTxRef  : ISO20022.Tsmt027001.SimpleIdentificationInformation
        + TxId  : ISO20022.Tsmt027001.SimpleIdentificationInformation
        + AccptncId  : ISO20022.Tsmt027001.MessageIdentification1
        + Validation () = validation(validElement(AccptdSts),validElement(SubmitrTxRef),validElement(TxId),validElement(AccptncId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt027001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|StsChngReqAccptnc|ISO20022.Tsmt027001.StatusChangeRequestAcceptanceV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StsChngReqAccptnc))|

---

## AspectImpl ISO20022.Tsmt027001.StatusChangeRequestAcceptanceV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt027001.Document||||
|+|AccptdSts|ISO20022.Tsmt027001.TransactionStatus3||XmlElement()||
|+|SubmitrTxRef|ISO20022.Tsmt027001.SimpleIdentificationInformation||XmlElement()||
|+|TxId|ISO20022.Tsmt027001.SimpleIdentificationInformation||XmlElement()||
|+|AccptncId|ISO20022.Tsmt027001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptdSts),validElement(SubmitrTxRef),validElement(TxId),validElement(AccptncId))|

