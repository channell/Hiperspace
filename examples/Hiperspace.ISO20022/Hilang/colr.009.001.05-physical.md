# colr.009.001.05-physical
```mermaid
classDiagram
    class ISO20022.Colr009001.Document {
        # Uri  : String
        + MrgnCallDsptNtfctn () : ISO20022.Colr009001.MarginCallDisputeNotificationV05
        + Validation () = validation(validElement(MrgnCallDsptNtfctn))
    }
    class ISO20022.Colr009001.MarginCallDisputeNotificationV05 {
        # owner  : ISO20022.Colr009001.Document
        + SplmtryData  : List~ISO20022.Colr009001.SupplementaryData1~
        + DsptNtfctn  : ISO20022.Colr009001.DisputeNotification2Choice
        + Oblgtn  : ISO20022.Colr009001.Obligation9
        + TxId  : String
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(DsptNtfctn),validElement(Oblgtn))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Colr009001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|MrgnCallDsptNtfctn|ISO20022.Colr009001.MarginCallDisputeNotificationV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MrgnCallDsptNtfctn))|

---

## AspectImpl ISO20022.Colr009001.MarginCallDisputeNotificationV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Colr009001.Document||||
|+|SplmtryData|List<ISO20022.Colr009001.SupplementaryData1>||XmlElement()||
|+|DsptNtfctn|ISO20022.Colr009001.DisputeNotification2Choice||XmlElement()||
|+|Oblgtn|ISO20022.Colr009001.Obligation9||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(DsptNtfctn),validElement(Oblgtn))|

