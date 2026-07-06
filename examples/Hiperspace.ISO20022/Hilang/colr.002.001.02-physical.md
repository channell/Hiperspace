# colr.002.001.02-physical
```mermaid
classDiagram
    class ISO20022.Colr002001.Document {
        # Uri  : String
        + CollValRpt () : ISO20022.Colr002001.CollateralValueReportV02
        + Validation () = validation(validElement(CollValRpt))
    }
    class ISO20022.Colr002001.CollateralValueReportV02 {
        # owner  : ISO20022.Colr002001.Document
        + SplmtryData  : List~ISO20022.Colr002001.SupplementaryData1~
        + RptOrErr  : ISO20022.Colr002001.CollateralValueReportOrError7Choice
        + MsgHdr  : ISO20022.Colr002001.MessageHeader3
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

## EntityImpl ISO20022.Colr002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CollValRpt|ISO20022.Colr002001.CollateralValueReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollValRpt))|

---

## AspectImpl ISO20022.Colr002001.CollateralValueReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Colr002001.Document||||
|+|SplmtryData|List<ISO20022.Colr002001.SupplementaryData1>||XmlElement()||
|+|RptOrErr|ISO20022.Colr002001.CollateralValueReportOrError7Choice||XmlElement()||
|+|MsgHdr|ISO20022.Colr002001.MessageHeader3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))|

