# remt.002.001.03-physical
```mermaid
classDiagram
    class ISO20022.Remt002001.Document {
        # Uri  : String
        + RmtLctnAdvc () : ISO20022.Remt002001.RemittanceLocationAdviceV03
        + Validation () = validation(validElement(RmtLctnAdvc))
    }
    class ISO20022.Remt002001.RemittanceLocationAdviceV03 {
        # owner  : ISO20022.Remt002001.Document
        + SplmtryData  : List~ISO20022.Remt002001.SupplementaryData1~
        + RmtLctn  : List~ISO20022.Remt002001.RemittanceLocation10~
        + GrpHdr  : ISO20022.Remt002001.GroupHeader122
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RmtLctn""",RmtLctn),validList("""RmtLctn""",RmtLctn),validElement(RmtLctn),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Remt002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RmtLctnAdvc|ISO20022.Remt002001.RemittanceLocationAdviceV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RmtLctnAdvc))|

---

## AspectImpl ISO20022.Remt002001.RemittanceLocationAdviceV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Remt002001.Document||||
|+|SplmtryData|List<ISO20022.Remt002001.SupplementaryData1>||XmlElement()||
|+|RmtLctn|List<ISO20022.Remt002001.RemittanceLocation10>||XmlElement()||
|+|GrpHdr|ISO20022.Remt002001.GroupHeader122||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RmtLctn""",RmtLctn),validList("""RmtLctn""",RmtLctn),validElement(RmtLctn),validElement(GrpHdr))|

