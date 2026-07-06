# trck.001.001.04-physical
```mermaid
classDiagram
    class ISO20022.Trck001001.Document {
        # Uri  : String
        + PmtStsTrckrUpd () : ISO20022.Trck001001.PaymentStatusTrackerUpdateV04
        + Validation () = validation(validElement(PmtStsTrckrUpd))
    }
    class ISO20022.Trck001001.PaymentStatusTrackerUpdateV04 {
        # owner  : ISO20022.Trck001001.Document
        + SplmtryData  : List~ISO20022.Trck001001.SupplementaryData1~
        + TrckrStsAndTx  : List~ISO20022.Trck001001.TrackerStatusAndTransaction19~
        + GrpHdr  : ISO20022.Trck001001.TrackerHeader6
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

## EntityImpl ISO20022.Trck001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PmtStsTrckrUpd|ISO20022.Trck001001.PaymentStatusTrackerUpdateV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtStsTrckrUpd))|

---

## AspectImpl ISO20022.Trck001001.PaymentStatusTrackerUpdateV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Trck001001.Document||||
|+|SplmtryData|List<ISO20022.Trck001001.SupplementaryData1>||XmlElement()||
|+|TrckrStsAndTx|List<ISO20022.Trck001001.TrackerStatusAndTransaction19>||XmlElement()||
|+|GrpHdr|ISO20022.Trck001001.TrackerHeader6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""TrckrStsAndTx""",TrckrStsAndTx),validList("""TrckrStsAndTx""",TrckrStsAndTx),validElement(TrckrStsAndTx),validElement(GrpHdr))|

