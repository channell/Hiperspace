# auth.056.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth056001.Document {
        # Uri  : String
        + CCPMmbOblgtnsRpt () : ISO20022.Auth056001.CCPMemberObligationsReportV01
        + Validation () = validation(validElement(CCPMmbOblgtnsRpt))
    }
    class ISO20022.Auth056001.CCPMemberObligationsReportV01 {
        # owner  : ISO20022.Auth056001.Document
        + SplmtryData  : List~ISO20022.Auth056001.SupplementaryData1~
        + SttlmAcct  : List~ISO20022.Auth056001.SettlementAccount1~
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""SttlmAcct""",SttlmAcct),validList("""SttlmAcct""",SttlmAcct),validElement(SttlmAcct))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth056001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CCPMmbOblgtnsRpt|ISO20022.Auth056001.CCPMemberObligationsReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CCPMmbOblgtnsRpt))|

---

## AspectImpl ISO20022.Auth056001.CCPMemberObligationsReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth056001.Document||||
|+|SplmtryData|List<ISO20022.Auth056001.SupplementaryData1>||XmlElement()||
|+|SttlmAcct|List<ISO20022.Auth056001.SettlementAccount1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""SttlmAcct""",SttlmAcct),validList("""SttlmAcct""",SttlmAcct),validElement(SttlmAcct))|

