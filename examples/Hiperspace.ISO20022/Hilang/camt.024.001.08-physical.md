# camt.024.001.08-physical
```mermaid
classDiagram
    class ISO20022.Camt024001.Document {
        # Uri  : String
        + ModfyStgOrdr () : ISO20022.Camt024001.ModifyStandingOrderV08
        + Validation () = validation(validElement(ModfyStgOrdr))
    }
    class ISO20022.Camt024001.ModifyStandingOrderV08 {
        # owner  : ISO20022.Camt024001.Document
        + SplmtryData  : List~ISO20022.Camt024001.SupplementaryData1~
        + NewStgOrdrValSet  : ISO20022.Camt024001.StandingOrder10
        + StgOrdrId  : ISO20022.Camt024001.StandingOrderIdentification8
        + MsgHdr  : ISO20022.Camt024001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(NewStgOrdrValSet),validElement(StgOrdrId),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt024001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ModfyStgOrdr|ISO20022.Camt024001.ModifyStandingOrderV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ModfyStgOrdr))|

---

## AspectImpl ISO20022.Camt024001.ModifyStandingOrderV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt024001.Document||||
|+|SplmtryData|List<ISO20022.Camt024001.SupplementaryData1>||XmlElement()||
|+|NewStgOrdrValSet|ISO20022.Camt024001.StandingOrder10||XmlElement()||
|+|StgOrdrId|ISO20022.Camt024001.StandingOrderIdentification8||XmlElement()||
|+|MsgHdr|ISO20022.Camt024001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(NewStgOrdrValSet),validElement(StgOrdrId),validElement(MsgHdr))|

