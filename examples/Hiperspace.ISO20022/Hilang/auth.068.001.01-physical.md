# auth.068.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth068001.Document {
        # Uri  : String
        + CCPAcctPosRpt () : ISO20022.Auth068001.CCPAccountPositionReportV01
        + Validation () = validation(validElement(CCPAcctPosRpt))
    }
    class ISO20022.Auth068001.CCPAccountPositionReportV01 {
        # owner  : ISO20022.Auth068001.Document
        + SplmtryData  : List~ISO20022.Auth068001.SupplementaryData1~
        + Prtfl  : List~ISO20022.Auth068001.PositionAccount2~
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Prtfl""",Prtfl),validList("""Prtfl""",Prtfl),validElement(Prtfl))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth068001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CCPAcctPosRpt|ISO20022.Auth068001.CCPAccountPositionReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CCPAcctPosRpt))|

---

## AspectImpl ISO20022.Auth068001.CCPAccountPositionReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth068001.Document||||
|+|SplmtryData|List<ISO20022.Auth068001.SupplementaryData1>||XmlElement()||
|+|Prtfl|List<ISO20022.Auth068001.PositionAccount2>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Prtfl""",Prtfl),validList("""Prtfl""",Prtfl),validElement(Prtfl))|

