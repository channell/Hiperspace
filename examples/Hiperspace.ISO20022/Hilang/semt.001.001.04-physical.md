# semt.001.001.04-physical
```mermaid
classDiagram
    class ISO20022.Semt001001.Document {
        # Uri  : String
        + SctiesMsgRjctn () : ISO20022.Semt001001.SecuritiesMessageRejectionV04
        + Validation () = validation(validElement(SctiesMsgRjctn))
    }
    class ISO20022.Semt001001.SecuritiesMessageRejectionV04 {
        # owner  : ISO20022.Semt001001.Document
        + Rsn  : ISO20022.Semt001001.RejectionReason69
        + RltdRef  : ISO20022.Semt001001.AdditionalReference14
        + Validation () = validation(validElement(Rsn),validElement(RltdRef))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Semt001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctiesMsgRjctn|ISO20022.Semt001001.SecuritiesMessageRejectionV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesMsgRjctn))|

---

## AspectImpl ISO20022.Semt001001.SecuritiesMessageRejectionV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Semt001001.Document||||
|+|Rsn|ISO20022.Semt001001.RejectionReason69||XmlElement()||
|+|RltdRef|ISO20022.Semt001001.AdditionalReference14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn),validElement(RltdRef))|

