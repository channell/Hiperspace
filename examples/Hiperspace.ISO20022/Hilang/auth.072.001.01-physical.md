# auth.072.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth072001.Document {
        # Uri  : String
        + SttlmIntlrRpt () : ISO20022.Auth072001.SettlementInternaliserReportV01
        + Validation () = validation(validElement(SttlmIntlrRpt))
    }
    class ISO20022.Auth072001.SettlementInternaliserReportV01 {
        # owner  : ISO20022.Auth072001.Document
        + SplmtryData  : List~ISO20022.Auth072001.SupplementaryData1~
        + IssrCSD  : List~ISO20022.Auth072001.IssuerCSDReport1~
        + SttlmIntlr  : ISO20022.Auth072001.SettlementInternaliser1
        + RptHdr  : ISO20022.Auth072001.SettlementInternaliserReportHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""IssrCSD""",IssrCSD),validList("""IssrCSD""",IssrCSD),validElement(IssrCSD),validElement(SttlmIntlr),validElement(RptHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth072001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SttlmIntlrRpt|ISO20022.Auth072001.SettlementInternaliserReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmIntlrRpt))|

---

## AspectImpl ISO20022.Auth072001.SettlementInternaliserReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth072001.Document||||
|+|SplmtryData|List<ISO20022.Auth072001.SupplementaryData1>||XmlElement()||
|+|IssrCSD|List<ISO20022.Auth072001.IssuerCSDReport1>||XmlElement()||
|+|SttlmIntlr|ISO20022.Auth072001.SettlementInternaliser1||XmlElement()||
|+|RptHdr|ISO20022.Auth072001.SettlementInternaliserReportHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""IssrCSD""",IssrCSD),validList("""IssrCSD""",IssrCSD),validElement(IssrCSD),validElement(SttlmIntlr),validElement(RptHdr))|

