# pain.007.001.12-physical
```mermaid
classDiagram
    class ISO20022.Pain007001.Document {
        # Uri  : String
        + CstmrPmtRvsl () : ISO20022.Pain007001.CustomerPaymentReversalV12
        + Validation () = validation(validElement(CstmrPmtRvsl))
    }
    class ISO20022.Pain007001.CustomerPaymentReversalV12 {
        # owner  : ISO20022.Pain007001.Document
        + SplmtryData  : List~ISO20022.Pain007001.SupplementaryData1~
        + OrgnlPmtInfAndRvsl  : List~ISO20022.Pain007001.OriginalPaymentInstruction50~
        + OrgnlGrpInf  : ISO20022.Pain007001.OriginalGroupHeader20
        + GrpHdr  : ISO20022.Pain007001.GroupHeader124
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""OrgnlPmtInfAndRvsl""",OrgnlPmtInfAndRvsl),validElement(OrgnlPmtInfAndRvsl),validElement(OrgnlGrpInf),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Pain007001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CstmrPmtRvsl|ISO20022.Pain007001.CustomerPaymentReversalV12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CstmrPmtRvsl))|

---

## AspectImpl ISO20022.Pain007001.CustomerPaymentReversalV12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Pain007001.Document||||
|+|SplmtryData|List<ISO20022.Pain007001.SupplementaryData1>||XmlElement()||
|+|OrgnlPmtInfAndRvsl|List<ISO20022.Pain007001.OriginalPaymentInstruction50>||XmlElement()||
|+|OrgnlGrpInf|ISO20022.Pain007001.OriginalGroupHeader20||XmlElement()||
|+|GrpHdr|ISO20022.Pain007001.GroupHeader124||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""OrgnlPmtInfAndRvsl""",OrgnlPmtInfAndRvsl),validElement(OrgnlPmtInfAndRvsl),validElement(OrgnlGrpInf),validElement(GrpHdr))|

