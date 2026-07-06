# semt.017.002.12-physical
```mermaid
classDiagram
    class ISO20022.Semt017002.Document {
        # Uri  : String
        + SctiesTxPstngRpt  : ISO20022.Semt017002.SecuritiesTransactionPostingReport002V12
        + Validation () = validation(validElement(SctiesTxPstngRpt))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Semt017002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctiesTxPstngRpt|ISO20022.Semt017002.SecuritiesTransactionPostingReport002V12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesTxPstngRpt))|

