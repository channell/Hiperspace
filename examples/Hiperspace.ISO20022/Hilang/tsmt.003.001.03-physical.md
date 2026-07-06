# tsmt.003.001.03-physical
```mermaid
classDiagram
    class ISO20022.Tsmt003001.Document {
        # Uri  : String
        + ActvtyReqRpt () : ISO20022.Tsmt003001.ActivityReportRequestV03
        + Validation () = validation(validElement(ActvtyReqRpt))
    }
    class ISO20022.Tsmt003001.ActivityReportRequestV03 {
        # owner  : ISO20022.Tsmt003001.Document
        + RptPrd  : ISO20022.Tsmt003001.DateTimePeriodDetails1
        + NttiesToBeRptd  : List~ISO20022.Tsmt003001.BICIdentification1~
        + ReqId  : ISO20022.Tsmt003001.MessageIdentification1
        + Validation () = validation(validElement(RptPrd),validList("""NttiesToBeRptd""",NttiesToBeRptd),validElement(NttiesToBeRptd),validElement(ReqId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt003001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ActvtyReqRpt|ISO20022.Tsmt003001.ActivityReportRequestV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ActvtyReqRpt))|

---

## AspectImpl ISO20022.Tsmt003001.ActivityReportRequestV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt003001.Document||||
|+|RptPrd|ISO20022.Tsmt003001.DateTimePeriodDetails1||XmlElement()||
|+|NttiesToBeRptd|List<ISO20022.Tsmt003001.BICIdentification1>||XmlElement()||
|+|ReqId|ISO20022.Tsmt003001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RptPrd),validList("""NttiesToBeRptd""",NttiesToBeRptd),validElement(NttiesToBeRptd),validElement(ReqId))|

