# tsmt.004.001.02-physical
```mermaid
classDiagram
    class ISO20022.Tsmt004001.Document {
        # Uri  : String
        + ActvtyRptSetUpReq () : ISO20022.Tsmt004001.ActivityReportSetUpRequestV02
        + Validation () = validation(validElement(ActvtyRptSetUpReq))
    }
    class ISO20022.Tsmt004001.ActivityReportSetUpRequestV02 {
        # owner  : ISO20022.Tsmt004001.Document
        + UTCOffset  : ISO20022.Tsmt004001.UTCOffset1
        + ReqId  : ISO20022.Tsmt004001.MessageIdentification1
        + Validation () = validation(validElement(UTCOffset),validElement(ReqId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ActvtyRptSetUpReq|ISO20022.Tsmt004001.ActivityReportSetUpRequestV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ActvtyRptSetUpReq))|

---

## AspectImpl ISO20022.Tsmt004001.ActivityReportSetUpRequestV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt004001.Document||||
|+|UTCOffset|ISO20022.Tsmt004001.UTCOffset1||XmlElement()||
|+|ReqId|ISO20022.Tsmt004001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UTCOffset),validElement(ReqId))|

