# trck.002.001.03-physical
```mermaid
classDiagram
    class ISO20022.Trck002001.Document {
        # Uri  : String
        + PmtStsTrckrRpt () : ISO20022.Trck002001.PaymentStatusTrackerReportV03
        + Validation () = validation(validElement(PmtStsTrckrRpt))
    }
    class ISO20022.Trck002001.PaymentStatusTrackerReportV03 {
        # owner  : ISO20022.Trck002001.Document
        + SplmtryData  : List~ISO20022.Trck002001.SupplementaryData1~
        + TrckrStsAndTx  : List~ISO20022.Trck002001.TrackerStatusAndTransaction18~
        + GrpHdr  : ISO20022.Trck002001.TrackerHeader5
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""TrckrStsAndTx""",TrckrStsAndTx),validList("""TrckrStsAndTx""",TrckrStsAndTx),validElement(TrckrStsAndTx),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Trck002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PmtStsTrckrRpt|ISO20022.Trck002001.PaymentStatusTrackerReportV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtStsTrckrRpt))|

---

## AspectImpl ISO20022.Trck002001.PaymentStatusTrackerReportV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Trck002001.Document||||
|+|SplmtryData|List<ISO20022.Trck002001.SupplementaryData1>||XmlElement()||
|+|TrckrStsAndTx|List<ISO20022.Trck002001.TrackerStatusAndTransaction18>||XmlElement()||
|+|GrpHdr|ISO20022.Trck002001.TrackerHeader5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""TrckrStsAndTx""",TrckrStsAndTx),validList("""TrckrStsAndTx""",TrckrStsAndTx),validElement(TrckrStsAndTx),validElement(GrpHdr))|

