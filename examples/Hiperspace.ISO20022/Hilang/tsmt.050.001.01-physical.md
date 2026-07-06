# tsmt.050.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsmt050001.Document {
        # Uri  : String
        + RoleAndBaselnRjctn () : ISO20022.Tsmt050001.RoleAndBaselineRejectionV01
        + Validation () = validation(validElement(RoleAndBaselnRjctn))
    }
    class ISO20022.Tsmt050001.RoleAndBaselineRejectionV01 {
        # owner  : ISO20022.Tsmt050001.Document
        + RjctnRsn  : ISO20022.Tsmt050001.Reason2
        + TxId  : ISO20022.Tsmt050001.SimpleIdentificationInformation
        + RltdMsgRef  : ISO20022.Tsmt050001.MessageIdentification1
        + RjctnId  : ISO20022.Tsmt050001.MessageIdentification1
        + Validation () = validation(validElement(RjctnRsn),validElement(TxId),validElement(RltdMsgRef),validElement(RjctnId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt050001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RoleAndBaselnRjctn|ISO20022.Tsmt050001.RoleAndBaselineRejectionV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RoleAndBaselnRjctn))|

---

## AspectImpl ISO20022.Tsmt050001.RoleAndBaselineRejectionV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt050001.Document||||
|+|RjctnRsn|ISO20022.Tsmt050001.Reason2||XmlElement()||
|+|TxId|ISO20022.Tsmt050001.SimpleIdentificationInformation||XmlElement()||
|+|RltdMsgRef|ISO20022.Tsmt050001.MessageIdentification1||XmlElement()||
|+|RjctnId|ISO20022.Tsmt050001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RjctnRsn),validElement(TxId),validElement(RltdMsgRef),validElement(RjctnId))|

