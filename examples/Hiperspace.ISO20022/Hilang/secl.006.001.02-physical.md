# secl.006.001.02-physical
```mermaid
classDiagram
    class ISO20022.Secl006001.Document {
        # Uri  : String
        + DfltFndCntrbtnRpt () : ISO20022.Secl006001.DefaultFundContributionReportV02
        + Validation () = validation(validElement(DfltFndCntrbtnRpt))
    }
    class ISO20022.Secl006001.DefaultFundContributionReportV02 {
        # owner  : ISO20022.Secl006001.Document
        + SplmtryData  : List~ISO20022.Secl006001.SupplementaryData1~
        + RptDtls  : List~ISO20022.Secl006001.DefaultFundReport1~
        + ClrMmb  : ISO20022.Secl006001.PartyIdentification35Choice
        + RptParams  : ISO20022.Secl006001.ReportParameters2
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RptDtls""",RptDtls),validList("""RptDtls""",RptDtls),validElement(RptDtls),validElement(ClrMmb),validElement(RptParams))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Secl006001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|DfltFndCntrbtnRpt|ISO20022.Secl006001.DefaultFundContributionReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DfltFndCntrbtnRpt))|

---

## AspectImpl ISO20022.Secl006001.DefaultFundContributionReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Secl006001.Document||||
|+|SplmtryData|List<ISO20022.Secl006001.SupplementaryData1>||XmlElement()||
|+|RptDtls|List<ISO20022.Secl006001.DefaultFundReport1>||XmlElement()||
|+|ClrMmb|ISO20022.Secl006001.PartyIdentification35Choice||XmlElement()||
|+|RptParams|ISO20022.Secl006001.ReportParameters2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RptDtls""",RptDtls),validList("""RptDtls""",RptDtls),validElement(RptDtls),validElement(ClrMmb),validElement(RptParams))|

