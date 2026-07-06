# remt.001.001.06-physical
```mermaid
classDiagram
    class ISO20022.Remt001001.Document {
        # Uri  : String
        + RmtAdvc () : ISO20022.Remt001001.RemittanceAdviceV06
        + Validation () = validation(validElement(RmtAdvc))
    }
    class ISO20022.Remt001001.RemittanceAdviceV06 {
        # owner  : ISO20022.Remt001001.Document
        + SplmtryData  : List~ISO20022.Remt001001.SupplementaryData1~
        + RmtInf  : List~ISO20022.Remt001001.RemittanceInformation23~
        + GrpHdr  : ISO20022.Remt001001.GroupHeader122
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RmtInf""",RmtInf),validList("""RmtInf""",RmtInf),validElement(RmtInf),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Remt001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RmtAdvc|ISO20022.Remt001001.RemittanceAdviceV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RmtAdvc))|

---

## AspectImpl ISO20022.Remt001001.RemittanceAdviceV06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Remt001001.Document||||
|+|SplmtryData|List<ISO20022.Remt001001.SupplementaryData1>||XmlElement()||
|+|RmtInf|List<ISO20022.Remt001001.RemittanceInformation23>||XmlElement()||
|+|GrpHdr|ISO20022.Remt001001.GroupHeader122||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RmtInf""",RmtInf),validList("""RmtInf""",RmtInf),validElement(RmtInf),validElement(GrpHdr))|

