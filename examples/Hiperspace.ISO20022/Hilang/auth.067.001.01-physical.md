# auth.067.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth067001.Document {
        # Uri  : String
        + CCPCollRpt () : ISO20022.Auth067001.CCPCollateralReportV01
        + Validation () = validation(validElement(CCPCollRpt))
    }
    class ISO20022.Auth067001.CCPCollateralReportV01 {
        # owner  : ISO20022.Auth067001.Document
        + SplmtryData  : List~ISO20022.Auth067001.SupplementaryData1~
        + CollAcctOwnr  : List~ISO20022.Auth067001.CollateralAccount4~
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""CollAcctOwnr""",CollAcctOwnr),validList("""CollAcctOwnr""",CollAcctOwnr),validElement(CollAcctOwnr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth067001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CCPCollRpt|ISO20022.Auth067001.CCPCollateralReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CCPCollRpt))|

---

## AspectImpl ISO20022.Auth067001.CCPCollateralReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth067001.Document||||
|+|SplmtryData|List<ISO20022.Auth067001.SupplementaryData1>||XmlElement()||
|+|CollAcctOwnr|List<ISO20022.Auth067001.CollateralAccount4>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""CollAcctOwnr""",CollAcctOwnr),validList("""CollAcctOwnr""",CollAcctOwnr),validElement(CollAcctOwnr))|

