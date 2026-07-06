# camt.070.001.06-physical
```mermaid
classDiagram
    class ISO20022.Camt070001.Document {
        # Uri  : String
        + RtrStgOrdr () : ISO20022.Camt070001.ReturnStandingOrderV06
        + Validation () = validation(validElement(RtrStgOrdr))
    }
    class ISO20022.Camt070001.ReturnStandingOrderV06 {
        # owner  : ISO20022.Camt070001.Document
        + SplmtryData  : List~ISO20022.Camt070001.SupplementaryData1~
        + RptOrErr  : ISO20022.Camt070001.StandingOrderOrError9Choice
        + MsgHdr  : ISO20022.Camt070001.MessageHeader6
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

## EntityImpl ISO20022.Camt070001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RtrStgOrdr|ISO20022.Camt070001.ReturnStandingOrderV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RtrStgOrdr))|

---

## AspectImpl ISO20022.Camt070001.ReturnStandingOrderV06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt070001.Document||||
|+|SplmtryData|List<ISO20022.Camt070001.SupplementaryData1>||XmlElement()||
|+|RptOrErr|ISO20022.Camt070001.StandingOrderOrError9Choice||XmlElement()||
|+|MsgHdr|ISO20022.Camt070001.MessageHeader6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))|

