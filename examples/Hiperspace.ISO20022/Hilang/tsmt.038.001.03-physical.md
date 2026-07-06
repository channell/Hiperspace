# tsmt.038.001.03-physical
```mermaid
classDiagram
    class ISO20022.Tsmt038001.Document {
        # Uri  : String
        + StsRptReq () : ISO20022.Tsmt038001.StatusReportRequestV03
        + Validation () = validation(validElement(StsRptReq))
    }
    class ISO20022.Tsmt038001.StatusReportRequestV03 {
        # owner  : ISO20022.Tsmt038001.Document
        + NttiesToBeRptd  : List~ISO20022.Tsmt038001.BICIdentification1~
        + ReqId  : ISO20022.Tsmt038001.MessageIdentification1
        + Validation () = validation(validList("""NttiesToBeRptd""",NttiesToBeRptd),validElement(NttiesToBeRptd),validElement(ReqId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt038001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|StsRptReq|ISO20022.Tsmt038001.StatusReportRequestV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StsRptReq))|

---

## AspectImpl ISO20022.Tsmt038001.StatusReportRequestV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt038001.Document||||
|+|NttiesToBeRptd|List<ISO20022.Tsmt038001.BICIdentification1>||XmlElement()||
|+|ReqId|ISO20022.Tsmt038001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""NttiesToBeRptd""",NttiesToBeRptd),validElement(NttiesToBeRptd),validElement(ReqId))|

