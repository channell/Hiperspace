# camt.057.001.08-physical
```mermaid
classDiagram
    class ISO20022.Camt057001.Document {
        # Uri  : String
        + NtfctnToRcv () : ISO20022.Camt057001.NotificationToReceiveV08
        + Validation () = validation(validElement(NtfctnToRcv))
    }
    class ISO20022.Camt057001.NotificationToReceiveV08 {
        # owner  : ISO20022.Camt057001.Document
        + SplmtryData  : List~ISO20022.Camt057001.SupplementaryData1~
        + Ntfctn  : ISO20022.Camt057001.AccountNotification23
        + GrpHdr  : ISO20022.Camt057001.GroupHeader117
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Ntfctn),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt057001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|NtfctnToRcv|ISO20022.Camt057001.NotificationToReceiveV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NtfctnToRcv))|

---

## AspectImpl ISO20022.Camt057001.NotificationToReceiveV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt057001.Document||||
|+|SplmtryData|List<ISO20022.Camt057001.SupplementaryData1>||XmlElement()||
|+|Ntfctn|ISO20022.Camt057001.AccountNotification23||XmlElement()||
|+|GrpHdr|ISO20022.Camt057001.GroupHeader117||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Ntfctn),validElement(GrpHdr))|

