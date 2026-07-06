# setr.018.001.04-physical
```mermaid
classDiagram
    class ISO20022.Setr018001.Document {
        # Uri  : String
        + ReqForOrdrStsRpt () : ISO20022.Setr018001.RequestForOrderStatusReportV04
        + Validation () = validation(validElement(ReqForOrdrStsRpt))
    }
    class ISO20022.Setr018001.RequestForOrderStatusReportV04 {
        # owner  : ISO20022.Setr018001.Document
        + Xtnsn  : List~ISO20022.Setr018001.Extension1~
        + ReqDtls  : List~ISO20022.Setr018001.MessageAndBusinessReference10~
        + MsgId  : ISO20022.Setr018001.MessageIdentification1
        + Validation () = validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validRequired("""ReqDtls""",ReqDtls),validList("""ReqDtls""",ReqDtls),validElement(ReqDtls),validElement(MsgId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Setr018001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ReqForOrdrStsRpt|ISO20022.Setr018001.RequestForOrderStatusReportV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqForOrdrStsRpt))|

---

## AspectImpl ISO20022.Setr018001.RequestForOrderStatusReportV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Setr018001.Document||||
|+|Xtnsn|List<ISO20022.Setr018001.Extension1>||XmlElement()||
|+|ReqDtls|List<ISO20022.Setr018001.MessageAndBusinessReference10>||XmlElement()||
|+|MsgId|ISO20022.Setr018001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validRequired("""ReqDtls""",ReqDtls),validList("""ReqDtls""",ReqDtls),validElement(ReqDtls),validElement(MsgId))|

