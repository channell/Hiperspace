# auth.054.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth054001.Document {
        # Uri  : String
        + CCPClrMmbRpt () : ISO20022.Auth054001.CCPClearingMemberReportV01
        + Validation () = validation(validElement(CCPClrMmbRpt))
    }
    class ISO20022.Auth054001.CCPClearingMemberReportV01 {
        # owner  : ISO20022.Auth054001.Document
        + SplmtryData  : List~ISO20022.Auth054001.SupplementaryData1~
        + ClrMmb  : List~ISO20022.Auth054001.ClearingMember1~
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""ClrMmb""",ClrMmb),validList("""ClrMmb""",ClrMmb),validElement(ClrMmb))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth054001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CCPClrMmbRpt|ISO20022.Auth054001.CCPClearingMemberReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CCPClrMmbRpt))|

---

## AspectImpl ISO20022.Auth054001.CCPClearingMemberReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth054001.Document||||
|+|SplmtryData|List<ISO20022.Auth054001.SupplementaryData1>||XmlElement()||
|+|ClrMmb|List<ISO20022.Auth054001.ClearingMember1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""ClrMmb""",ClrMmb),validList("""ClrMmb""",ClrMmb),validElement(ClrMmb))|

