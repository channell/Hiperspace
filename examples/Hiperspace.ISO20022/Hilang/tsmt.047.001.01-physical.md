# tsmt.047.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsmt047001.Document {
        # Uri  : String
        + SpclReq () : ISO20022.Tsmt047001.SpecialRequestV01
        + Validation () = validation(validElement(SpclReq))
    }
    class ISO20022.Tsmt047001.SpecialRequestV01 {
        # owner  : ISO20022.Tsmt047001.Document
        + Ntfctn  : ISO20022.Tsmt047001.Notification1
        + SubmitrTxRef  : ISO20022.Tsmt047001.SimpleIdentificationInformation
        + TxId  : ISO20022.Tsmt047001.SimpleIdentificationInformation
        + ReqId  : ISO20022.Tsmt047001.MessageIdentification1
        + Validation () = validation(validElement(Ntfctn),validElement(SubmitrTxRef),validElement(TxId),validElement(ReqId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt047001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SpclReq|ISO20022.Tsmt047001.SpecialRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SpclReq))|

---

## AspectImpl ISO20022.Tsmt047001.SpecialRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt047001.Document||||
|+|Ntfctn|ISO20022.Tsmt047001.Notification1||XmlElement()||
|+|SubmitrTxRef|ISO20022.Tsmt047001.SimpleIdentificationInformation||XmlElement()||
|+|TxId|ISO20022.Tsmt047001.SimpleIdentificationInformation||XmlElement()||
|+|ReqId|ISO20022.Tsmt047001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntfctn),validElement(SubmitrTxRef),validElement(TxId),validElement(ReqId))|

