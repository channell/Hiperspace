# acmt.036.001.01-physical
```mermaid
classDiagram
    class ISO20022.Acmt036001.Document {
        # Uri  : String
        + AcctSwtchTermntnSwtch  : ISO20022.Acmt036001.AccountSwitchTerminationSwitchV01
        + Validation () = validation(validElement(AcctSwtchTermntnSwtch))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Acmt036001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AcctSwtchTermntnSwtch|ISO20022.Acmt036001.AccountSwitchTerminationSwitchV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSwtchTermntnSwtch))|

