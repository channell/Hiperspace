# tsmt.022.001.02-physical
```mermaid
classDiagram
    class ISO20022.Tsmt022001.Document {
        # Uri  : String
        + MisMtchRjctn () : ISO20022.Tsmt022001.MisMatchRejectionV02
        + Validation () = validation(validElement(MisMtchRjctn))
    }
    class ISO20022.Tsmt022001.MisMatchRejectionV02 {
        # owner  : ISO20022.Tsmt022001.Document
        + RjctnRsn  : ISO20022.Tsmt022001.RejectionReason1Choice
        + DataSetMtchRptRef  : ISO20022.Tsmt022001.MessageIdentification1
        + SubmitrTxRef  : ISO20022.Tsmt022001.SimpleIdentificationInformation
        + TxId  : ISO20022.Tsmt022001.SimpleIdentificationInformation
        + RjctnId  : ISO20022.Tsmt022001.MessageIdentification1
        + Validation () = validation(validElement(RjctnRsn),validElement(DataSetMtchRptRef),validElement(SubmitrTxRef),validElement(TxId),validElement(RjctnId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt022001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|MisMtchRjctn|ISO20022.Tsmt022001.MisMatchRejectionV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MisMtchRjctn))|

---

## AspectImpl ISO20022.Tsmt022001.MisMatchRejectionV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt022001.Document||||
|+|RjctnRsn|ISO20022.Tsmt022001.RejectionReason1Choice||XmlElement()||
|+|DataSetMtchRptRef|ISO20022.Tsmt022001.MessageIdentification1||XmlElement()||
|+|SubmitrTxRef|ISO20022.Tsmt022001.SimpleIdentificationInformation||XmlElement()||
|+|TxId|ISO20022.Tsmt022001.SimpleIdentificationInformation||XmlElement()||
|+|RjctnId|ISO20022.Tsmt022001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RjctnRsn),validElement(DataSetMtchRptRef),validElement(SubmitrTxRef),validElement(TxId),validElement(RjctnId))|

