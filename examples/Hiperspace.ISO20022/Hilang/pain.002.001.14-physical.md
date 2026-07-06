# pain.002.001.14-physical
```mermaid
classDiagram
    class ISO20022.Pain002001.Document {
        # Uri  : String
        + CstmrPmtStsRpt () : ISO20022.Pain002001.CustomerPaymentStatusReportV14
        + Validation () = validation(validElement(CstmrPmtStsRpt))
    }
    class ISO20022.Pain002001.CustomerPaymentStatusReportV14 {
        # owner  : ISO20022.Pain002001.Document
        + SplmtryData  : List~ISO20022.Pain002001.SupplementaryData1~
        + OrgnlPmtInfAndSts  : List~ISO20022.Pain002001.OriginalPaymentInstruction51~
        + OrgnlGrpInfAndSts  : ISO20022.Pain002001.OriginalGroupHeader22
        + GrpHdr  : ISO20022.Pain002001.GroupHeader128
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""OrgnlPmtInfAndSts""",OrgnlPmtInfAndSts),validElement(OrgnlPmtInfAndSts),validElement(OrgnlGrpInfAndSts),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Pain002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CstmrPmtStsRpt|ISO20022.Pain002001.CustomerPaymentStatusReportV14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CstmrPmtStsRpt))|

---

## AspectImpl ISO20022.Pain002001.CustomerPaymentStatusReportV14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Pain002001.Document||||
|+|SplmtryData|List<ISO20022.Pain002001.SupplementaryData1>||XmlElement()||
|+|OrgnlPmtInfAndSts|List<ISO20022.Pain002001.OriginalPaymentInstruction51>||XmlElement()||
|+|OrgnlGrpInfAndSts|ISO20022.Pain002001.OriginalGroupHeader22||XmlElement()||
|+|GrpHdr|ISO20022.Pain002001.GroupHeader128||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""OrgnlPmtInfAndSts""",OrgnlPmtInfAndSts),validElement(OrgnlPmtInfAndSts),validElement(OrgnlGrpInfAndSts),validElement(GrpHdr))|

