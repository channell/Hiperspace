# reda.004.001.07-physical
```mermaid
classDiagram
    class ISO20022.Reda004001.Document {
        # Uri  : String
        + FndRefDataRpt () : ISO20022.Reda004001.FundReferenceDataReportV07
        + Validation () = validation(validElement(FndRefDataRpt))
    }
    class ISO20022.Reda004001.FundReferenceDataReportV07 {
        # owner  : ISO20022.Reda004001.Document
        + Rpt  : List~ISO20022.Reda004001.FundReferenceDataReport5~
        + FndRefDataRptId  : String
        + RltdRef  : ISO20022.Reda004001.AdditionalReference10
        + PrvsRef  : List~ISO20022.Reda004001.AdditionalReference10~
        + MsgId  : ISO20022.Reda004001.MessageIdentification1
        + Validation () = validation(validRequired("""Rpt""",Rpt),validList("""Rpt""",Rpt),validElement(Rpt),validElement(RltdRef),validList("""PrvsRef""",PrvsRef),validElement(PrvsRef),validElement(MsgId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|FndRefDataRpt|ISO20022.Reda004001.FundReferenceDataReportV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FndRefDataRpt))|

---

## AspectImpl ISO20022.Reda004001.FundReferenceDataReportV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda004001.Document||||
|+|Rpt|List<ISO20022.Reda004001.FundReferenceDataReport5>||XmlElement()||
|+|FndRefDataRptId|String||XmlElement()||
|+|RltdRef|ISO20022.Reda004001.AdditionalReference10||XmlElement()||
|+|PrvsRef|List<ISO20022.Reda004001.AdditionalReference10>||XmlElement()||
|+|MsgId|ISO20022.Reda004001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rpt""",Rpt),validList("""Rpt""",Rpt),validElement(Rpt),validElement(RltdRef),validList("""PrvsRef""",PrvsRef),validElement(PrvsRef),validElement(MsgId))|

