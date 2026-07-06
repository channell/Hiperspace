# reda.065.001.02-physical
```mermaid
classDiagram
    class ISO20022.Reda065001.Document {
        # Uri  : String
        + CalRpt () : ISO20022.Reda065001.CalendarReportV02
        + Validation () = validation(validElement(CalRpt))
    }
    class ISO20022.Reda065001.CalendarReportV02 {
        # owner  : ISO20022.Reda065001.Document
        + SplmtryData  : List~ISO20022.Reda065001.SupplementaryData1~
        + RptOrErr  : ISO20022.Reda065001.CalendarReportOrError1Choice
        + MsgHdr  : ISO20022.Reda065001.MessageHeader11
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda065001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CalRpt|ISO20022.Reda065001.CalendarReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CalRpt))|

---

## AspectImpl ISO20022.Reda065001.CalendarReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda065001.Document||||
|+|SplmtryData|List<ISO20022.Reda065001.SupplementaryData1>||XmlElement()||
|+|RptOrErr|ISO20022.Reda065001.CalendarReportOrError1Choice||XmlElement()||
|+|MsgHdr|ISO20022.Reda065001.MessageHeader11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))|

