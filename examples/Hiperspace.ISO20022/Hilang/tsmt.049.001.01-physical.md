# tsmt.049.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsmt049001.Document {
        # Uri  : String
        + RoleAndBaselnAccptnc () : ISO20022.Tsmt049001.RoleAndBaselineAcceptanceV01
        + Validation () = validation(validElement(RoleAndBaselnAccptnc))
    }
    class ISO20022.Tsmt049001.RoleAndBaselineAcceptanceV01 {
        # owner  : ISO20022.Tsmt049001.Document
        + TxId  : ISO20022.Tsmt049001.SimpleIdentificationInformation
        + RltdMsgRef  : ISO20022.Tsmt049001.MessageIdentification1
        + AccptncId  : ISO20022.Tsmt049001.MessageIdentification1
        + Validation () = validation(validElement(TxId),validElement(RltdMsgRef),validElement(AccptncId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt049001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RoleAndBaselnAccptnc|ISO20022.Tsmt049001.RoleAndBaselineAcceptanceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RoleAndBaselnAccptnc))|

---

## AspectImpl ISO20022.Tsmt049001.RoleAndBaselineAcceptanceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt049001.Document||||
|+|TxId|ISO20022.Tsmt049001.SimpleIdentificationInformation||XmlElement()||
|+|RltdMsgRef|ISO20022.Tsmt049001.MessageIdentification1||XmlElement()||
|+|AccptncId|ISO20022.Tsmt049001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxId),validElement(RltdMsgRef),validElement(AccptncId))|

