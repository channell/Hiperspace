# auth.061.001.02-physical
```mermaid
classDiagram
    class ISO20022.Auth061001.Document {
        # Uri  : String
        + CCPInvstmtsRpt () : ISO20022.Auth061001.CCPInvestmentsReportV02
        + Validation () = validation(validElement(CCPInvstmtsRpt))
    }
    class ISO20022.Auth061001.CCPInvestmentsReportV02 {
        # owner  : ISO20022.Auth061001.Document
        + SplmtryData  : List~ISO20022.Auth061001.SupplementaryData1~
        + Invstmt  : List~ISO20022.Auth061001.Investment2Choice~
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Invstmt""",Invstmt),validList("""Invstmt""",Invstmt),validElement(Invstmt))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth061001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CCPInvstmtsRpt|ISO20022.Auth061001.CCPInvestmentsReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CCPInvstmtsRpt))|

---

## AspectImpl ISO20022.Auth061001.CCPInvestmentsReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth061001.Document||||
|+|SplmtryData|List<ISO20022.Auth061001.SupplementaryData1>||XmlElement()||
|+|Invstmt|List<ISO20022.Auth061001.Investment2Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Invstmt""",Invstmt),validList("""Invstmt""",Invstmt),validElement(Invstmt))|

