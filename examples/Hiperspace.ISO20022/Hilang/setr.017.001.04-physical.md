# setr.017.001.04-physical
```mermaid
classDiagram
    class ISO20022.Setr017001.Document {
        # Uri  : String
        + OrdrCxlStsRpt () : ISO20022.Setr017001.OrderCancellationStatusReportV04
        + Validation () = validation(validElement(OrdrCxlStsRpt))
    }
    class ISO20022.Setr017001.OrderCancellationStatusReportV04 {
        # owner  : ISO20022.Setr017001.Document
        + Xtnsn  : List~ISO20022.Setr017001.Extension1~
        + StsRpt  : ISO20022.Setr017001.Status26Choice
        + Ref  : ISO20022.Setr017001.References61Choice
        + MsgId  : ISO20022.Setr017001.MessageIdentification1
        + Validation () = validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(StsRpt),validElement(Ref),validElement(MsgId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Setr017001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|OrdrCxlStsRpt|ISO20022.Setr017001.OrderCancellationStatusReportV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrdrCxlStsRpt))|

---

## AspectImpl ISO20022.Setr017001.OrderCancellationStatusReportV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Setr017001.Document||||
|+|Xtnsn|List<ISO20022.Setr017001.Extension1>||XmlElement()||
|+|StsRpt|ISO20022.Setr017001.Status26Choice||XmlElement()||
|+|Ref|ISO20022.Setr017001.References61Choice||XmlElement()||
|+|MsgId|ISO20022.Setr017001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(StsRpt),validElement(Ref),validElement(MsgId))|

