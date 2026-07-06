# auth.112.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth112001.Document {
        # Uri  : String
        + CCPIntrprbltyRpt () : ISO20022.Auth112001.CCPInteroperabilityReportV01
        + Validation () = validation(validElement(CCPIntrprbltyRpt))
    }
    class ISO20022.Auth112001.CCPInteroperabilityReportV01 {
        # owner  : ISO20022.Auth112001.Document
        + SplmtryData  : List~ISO20022.Auth112001.SupplementaryData1~
        + IntrprbltyCCP  : List~ISO20022.Auth112001.InteroperabilityCCP1~
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""IntrprbltyCCP""",IntrprbltyCCP),validList("""IntrprbltyCCP""",IntrprbltyCCP),validElement(IntrprbltyCCP))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth112001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CCPIntrprbltyRpt|ISO20022.Auth112001.CCPInteroperabilityReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CCPIntrprbltyRpt))|

---

## AspectImpl ISO20022.Auth112001.CCPInteroperabilityReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth112001.Document||||
|+|SplmtryData|List<ISO20022.Auth112001.SupplementaryData1>||XmlElement()||
|+|IntrprbltyCCP|List<ISO20022.Auth112001.InteroperabilityCCP1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""IntrprbltyCCP""",IntrprbltyCCP),validList("""IntrprbltyCCP""",IntrprbltyCCP),validElement(IntrprbltyCCP))|

