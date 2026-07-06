# admi.004.001.02-physical
```mermaid
classDiagram
    class ISO20022.Admi004001.Document {
        # Uri  : String
        + SysEvtNtfctn () : ISO20022.Admi004001.SystemEventNotificationV02
        + Validation () = validation(validElement(SysEvtNtfctn))
    }
    class ISO20022.Admi004001.SystemEventNotificationV02 {
        # owner  : ISO20022.Admi004001.Document
        + EvtInf  : ISO20022.Admi004001.Event2
        + Validation () = validation(validElement(EvtInf))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Admi004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SysEvtNtfctn|ISO20022.Admi004001.SystemEventNotificationV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SysEvtNtfctn))|

---

## AspectImpl ISO20022.Admi004001.SystemEventNotificationV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Admi004001.Document||||
|+|EvtInf|ISO20022.Admi004001.Event2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EvtInf))|

