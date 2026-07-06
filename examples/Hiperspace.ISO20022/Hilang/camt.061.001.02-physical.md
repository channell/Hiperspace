# camt.061.001.02-physical
```mermaid
classDiagram
    class ISO20022.Camt061001.Document {
        # Uri  : String
        + PayInCall () : ISO20022.Camt061001.PayInCallV02
        + Validation () = validation(validElement(PayInCall))
    }
    class ISO20022.Camt061001.PayInCallV02 {
        # owner  : ISO20022.Camt061001.Document
        + SplmtryData  : List~ISO20022.Camt061001.SupplementaryData1~
        + SttlmSsnIdr  : String
        + RptData  : ISO20022.Camt061001.ReportData5
        + PtyId  : ISO20022.Camt061001.PartyIdentification73Choice
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validPattern("""SttlmSsnIdr""",SttlmSsnIdr,"""[a-zA-Z0-9]{4}"""),validElement(RptData),validElement(PtyId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt061001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PayInCall|ISO20022.Camt061001.PayInCallV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PayInCall))|

---

## AspectImpl ISO20022.Camt061001.PayInCallV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt061001.Document||||
|+|SplmtryData|List<ISO20022.Camt061001.SupplementaryData1>||XmlElement()||
|+|SttlmSsnIdr|String||XmlElement()||
|+|RptData|ISO20022.Camt061001.ReportData5||XmlElement()||
|+|PtyId|ISO20022.Camt061001.PartyIdentification73Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validPattern("""SttlmSsnIdr""",SttlmSsnIdr,"""[a-zA-Z0-9]{4}"""),validElement(RptData),validElement(PtyId))|

