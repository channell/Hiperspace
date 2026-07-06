# auth.069.001.02-physical
```mermaid
classDiagram
    class ISO20022.Auth069001.Document {
        # Uri  : String
        + CCPClrdPdctRpt () : ISO20022.Auth069001.CCPClearedProductReportV02
        + Validation () = validation(validElement(CCPClrdPdctRpt))
    }
    class ISO20022.Auth069001.CCPClearedProductReportV02 {
        # owner  : ISO20022.Auth069001.Document
        + SplmtryData  : List~ISO20022.Auth069001.SupplementaryData1~
        + ClrdPdct  : List~ISO20022.Auth069001.ClearedProduct2~
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""ClrdPdct""",ClrdPdct),validList("""ClrdPdct""",ClrdPdct),validElement(ClrdPdct))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth069001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CCPClrdPdctRpt|ISO20022.Auth069001.CCPClearedProductReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CCPClrdPdctRpt))|

---

## AspectImpl ISO20022.Auth069001.CCPClearedProductReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth069001.Document||||
|+|SplmtryData|List<ISO20022.Auth069001.SupplementaryData1>||XmlElement()||
|+|ClrdPdct|List<ISO20022.Auth069001.ClearedProduct2>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""ClrdPdct""",ClrdPdct),validList("""ClrdPdct""",ClrdPdct),validElement(ClrdPdct))|

