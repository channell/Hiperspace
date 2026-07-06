# tsmt.046.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsmt046001.Document {
        # Uri  : String
        + InttToPayRpt () : ISO20022.Tsmt046001.IntentToPayReportV01
        + Validation () = validation(validElement(InttToPayRpt))
    }
    class ISO20022.Tsmt046001.IntentToPayReportV01 {
        # owner  : ISO20022.Tsmt046001.Document
        + RptdItms  : List~ISO20022.Tsmt046001.ReportLine1~
        + RptId  : ISO20022.Tsmt046001.MessageIdentification1
        + Validation () = validation(validList("""RptdItms""",RptdItms),validElement(RptdItms),validElement(RptId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt046001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|InttToPayRpt|ISO20022.Tsmt046001.IntentToPayReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InttToPayRpt))|

---

## AspectImpl ISO20022.Tsmt046001.IntentToPayReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt046001.Document||||
|+|RptdItms|List<ISO20022.Tsmt046001.ReportLine1>||XmlElement()||
|+|RptId|ISO20022.Tsmt046001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RptdItms""",RptdItms),validElement(RptdItms),validElement(RptId))|

