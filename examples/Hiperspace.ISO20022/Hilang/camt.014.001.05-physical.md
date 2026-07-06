# camt.014.001.05-physical
```mermaid
classDiagram
    class ISO20022.Camt014001.Document {
        # Uri  : String
        + RtrMmb () : ISO20022.Camt014001.ReturnMemberV05
        + Validation () = validation(validElement(RtrMmb))
    }
    class ISO20022.Camt014001.ReturnMemberV05 {
        # owner  : ISO20022.Camt014001.Document
        + SplmtryData  : List~ISO20022.Camt014001.SupplementaryData1~
        + RptOrErr  : ISO20022.Camt014001.MemberReportOrError7Choice
        + MsgHdr  : ISO20022.Camt014001.MessageHeader7
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RtrMmb|ISO20022.Camt014001.ReturnMemberV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RtrMmb))|

---

## AspectImpl ISO20022.Camt014001.ReturnMemberV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt014001.Document||||
|+|SplmtryData|List<ISO20022.Camt014001.SupplementaryData1>||XmlElement()||
|+|RptOrErr|ISO20022.Camt014001.MemberReportOrError7Choice||XmlElement()||
|+|MsgHdr|ISO20022.Camt014001.MessageHeader7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))|

