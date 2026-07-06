# camt.030.001.06-physical
```mermaid
classDiagram
    class ISO20022.Camt030001.Document {
        # Uri  : String
        + NtfctnOfCaseAssgnmt () : ISO20022.Camt030001.NotificationOfCaseAssignmentV06
        + Validation () = validation(validElement(NtfctnOfCaseAssgnmt))
    }
    class ISO20022.Camt030001.NotificationOfCaseAssignmentV06 {
        # owner  : ISO20022.Camt030001.Document
        + SplmtryData  : List~ISO20022.Camt030001.SupplementaryData1~
        + Ntfctn  : ISO20022.Camt030001.CaseForwardingNotification3
        + Assgnmt  : ISO20022.Camt030001.CaseAssignment6
        + Case  : ISO20022.Camt030001.Case6
        + Hdr  : ISO20022.Camt030001.ReportHeader7
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Ntfctn),validElement(Assgnmt),validElement(Case),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt030001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|NtfctnOfCaseAssgnmt|ISO20022.Camt030001.NotificationOfCaseAssignmentV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NtfctnOfCaseAssgnmt))|

---

## AspectImpl ISO20022.Camt030001.NotificationOfCaseAssignmentV06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt030001.Document||||
|+|SplmtryData|List<ISO20022.Camt030001.SupplementaryData1>||XmlElement()||
|+|Ntfctn|ISO20022.Camt030001.CaseForwardingNotification3||XmlElement()||
|+|Assgnmt|ISO20022.Camt030001.CaseAssignment6||XmlElement()||
|+|Case|ISO20022.Camt030001.Case6||XmlElement()||
|+|Hdr|ISO20022.Camt030001.ReportHeader7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Ntfctn),validElement(Assgnmt),validElement(Case),validElement(Hdr))|

