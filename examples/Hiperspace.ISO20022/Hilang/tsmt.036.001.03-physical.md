# tsmt.036.001.03-physical
```mermaid
classDiagram
    class ISO20022.Tsmt036001.Document {
        # Uri  : String
        + StsXtnsnReqNtfctn  : ISO20022.Tsmt036001.StatusExtensionRequestNotificationV03
        + Validation () = validation(validElement(StsXtnsnReqNtfctn))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt036001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|StsXtnsnReqNtfctn|ISO20022.Tsmt036001.StatusExtensionRequestNotificationV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StsXtnsnReqNtfctn))|

