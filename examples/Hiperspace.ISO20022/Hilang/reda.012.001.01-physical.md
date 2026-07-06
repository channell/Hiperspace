# reda.012.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda012001.Document {
        # Uri  : String
        + SctyRpt () : ISO20022.Reda012001.SecurityReportV01
        + Validation () = validation(validElement(SctyRpt))
    }
    class ISO20022.Reda012001.SecurityReportV01 {
        # owner  : ISO20022.Reda012001.Document
        + SplmtryData  : List~ISO20022.Reda012001.SupplementaryData1~
        + SctyRptOrErr  : ISO20022.Reda012001.SecurityOrOperationalError4Choice
        + Pgntn  : ISO20022.Reda012001.Pagination1
        + MsgHdr  : ISO20022.Reda012001.MessageHeader12
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SctyRptOrErr),validElement(Pgntn),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda012001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctyRpt|ISO20022.Reda012001.SecurityReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyRpt))|

---

## AspectImpl ISO20022.Reda012001.SecurityReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda012001.Document||||
|+|SplmtryData|List<ISO20022.Reda012001.SupplementaryData1>||XmlElement()||
|+|SctyRptOrErr|ISO20022.Reda012001.SecurityOrOperationalError4Choice||XmlElement()||
|+|Pgntn|ISO20022.Reda012001.Pagination1||XmlElement()||
|+|MsgHdr|ISO20022.Reda012001.MessageHeader12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SctyRptOrErr),validElement(Pgntn),validElement(MsgHdr))|

