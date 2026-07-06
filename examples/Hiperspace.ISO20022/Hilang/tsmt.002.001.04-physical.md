# tsmt.002.001.04-physical
```mermaid
classDiagram
    class ISO20022.Tsmt002001.Document {
        # Uri  : String
        + ActvtyRpt () : ISO20022.Tsmt002001.ActivityReportV04
        + Validation () = validation(validElement(ActvtyRpt))
    }
    class ISO20022.Tsmt002001.ActivityReportV04 {
        # owner  : ISO20022.Tsmt002001.Document
        + Rpt  : List~ISO20022.Tsmt002001.ActivityReportItems3~
        + RltdMsgRef  : ISO20022.Tsmt002001.MessageIdentification1
        + RptId  : ISO20022.Tsmt002001.MessageIdentification1
        + Validation () = validation(validList("""Rpt""",Rpt),validElement(Rpt),validElement(RltdMsgRef),validElement(RptId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ActvtyRpt|ISO20022.Tsmt002001.ActivityReportV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ActvtyRpt))|

---

## AspectImpl ISO20022.Tsmt002001.ActivityReportV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt002001.Document||||
|+|Rpt|List<ISO20022.Tsmt002001.ActivityReportItems3>||XmlElement()||
|+|RltdMsgRef|ISO20022.Tsmt002001.MessageIdentification1||XmlElement()||
|+|RptId|ISO20022.Tsmt002001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rpt""",Rpt),validElement(Rpt),validElement(RltdMsgRef),validElement(RptId))|

