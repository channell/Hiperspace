# pain.012.001.08-physical
```mermaid
classDiagram
    class ISO20022.Pain012001.Document {
        # Uri  : String
        + MndtAccptncRpt () : ISO20022.Pain012001.MandateAcceptanceReportV08
        + Validation () = validation(validElement(MndtAccptncRpt))
    }
    class ISO20022.Pain012001.MandateAcceptanceReportV08 {
        # owner  : ISO20022.Pain012001.Document
        + SplmtryData  : List~ISO20022.Pain012001.SupplementaryData1~
        + UndrlygAccptncDtls  : List~ISO20022.Pain012001.MandateAcceptance8~
        + GrpHdr  : ISO20022.Pain012001.GroupHeader110
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""UndrlygAccptncDtls""",UndrlygAccptncDtls),validList("""UndrlygAccptncDtls""",UndrlygAccptncDtls),validElement(UndrlygAccptncDtls),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Pain012001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|MndtAccptncRpt|ISO20022.Pain012001.MandateAcceptanceReportV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MndtAccptncRpt))|

---

## AspectImpl ISO20022.Pain012001.MandateAcceptanceReportV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Pain012001.Document||||
|+|SplmtryData|List<ISO20022.Pain012001.SupplementaryData1>||XmlElement()||
|+|UndrlygAccptncDtls|List<ISO20022.Pain012001.MandateAcceptance8>||XmlElement()||
|+|GrpHdr|ISO20022.Pain012001.GroupHeader110||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""UndrlygAccptncDtls""",UndrlygAccptncDtls),validList("""UndrlygAccptncDtls""",UndrlygAccptncDtls),validElement(UndrlygAccptncDtls),validElement(GrpHdr))|

