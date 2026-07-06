# camt.105.001.03-physical
```mermaid
classDiagram
    class ISO20022.Camt105001.Document {
        # Uri  : String
        + ChrgsPmtNtfctn () : ISO20022.Camt105001.ChargesPaymentNotificationV03
        + Validation () = validation(validElement(ChrgsPmtNtfctn))
    }
    class ISO20022.Camt105001.ChargesPaymentNotificationV03 {
        # owner  : ISO20022.Camt105001.Document
        + SplmtryData  : List~ISO20022.Camt105001.SupplementaryData1~
        + Chrgs  : ISO20022.Camt105001.Charges5Choice
        + GrpHdr  : ISO20022.Camt105001.GroupHeader126
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Chrgs),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt105001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ChrgsPmtNtfctn|ISO20022.Camt105001.ChargesPaymentNotificationV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ChrgsPmtNtfctn))|

---

## AspectImpl ISO20022.Camt105001.ChargesPaymentNotificationV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt105001.Document||||
|+|SplmtryData|List<ISO20022.Camt105001.SupplementaryData1>||XmlElement()||
|+|Chrgs|ISO20022.Camt105001.Charges5Choice||XmlElement()||
|+|GrpHdr|ISO20022.Camt105001.GroupHeader126||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Chrgs),validElement(GrpHdr))|

