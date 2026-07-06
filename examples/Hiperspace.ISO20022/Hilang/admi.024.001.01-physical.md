# admi.024.001.01-physical
```mermaid
classDiagram
    class ISO20022.Admi024001.Document {
        # Uri  : String
        + NtfctnOfCrspdc () : ISO20022.Admi024001.NotificationOfCorrespondenceV01
        + Validation () = validation(validElement(NtfctnOfCrspdc))
    }
    class ISO20022.Admi024001.NotificationOfCorrespondenceV01 {
        # owner  : ISO20022.Admi024001.Document
        + SplmtryData  : List~ISO20022.Admi024001.SupplementaryData1~
        + NtfctnData  : List~ISO20022.Admi024001.CorrespondenceNotification1~
        + GrpHdr  : ISO20022.Admi024001.GroupHeader129
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""NtfctnData""",NtfctnData),validList("""NtfctnData""",NtfctnData),validElement(NtfctnData),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Admi024001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|NtfctnOfCrspdc|ISO20022.Admi024001.NotificationOfCorrespondenceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NtfctnOfCrspdc))|

---

## AspectImpl ISO20022.Admi024001.NotificationOfCorrespondenceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Admi024001.Document||||
|+|SplmtryData|List<ISO20022.Admi024001.SupplementaryData1>||XmlElement()||
|+|NtfctnData|List<ISO20022.Admi024001.CorrespondenceNotification1>||XmlElement()||
|+|GrpHdr|ISO20022.Admi024001.GroupHeader129||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""NtfctnData""",NtfctnData),validList("""NtfctnData""",NtfctnData),validElement(NtfctnData),validElement(GrpHdr))|

