# camt.069.001.05-physical
```mermaid
classDiagram
    class ISO20022.Camt069001.Document {
        # Uri  : String
        + GetStgOrdr () : ISO20022.Camt069001.GetStandingOrderV05
        + Validation () = validation(validElement(GetStgOrdr))
    }
    class ISO20022.Camt069001.GetStandingOrderV05 {
        # owner  : ISO20022.Camt069001.Document
        + SplmtryData  : List~ISO20022.Camt069001.SupplementaryData1~
        + StgOrdrQryDef  : ISO20022.Camt069001.StandingOrderQuery5
        + MsgHdr  : ISO20022.Camt069001.MessageHeader4
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(StgOrdrQryDef),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt069001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|GetStgOrdr|ISO20022.Camt069001.GetStandingOrderV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GetStgOrdr))|

---

## AspectImpl ISO20022.Camt069001.GetStandingOrderV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt069001.Document||||
|+|SplmtryData|List<ISO20022.Camt069001.SupplementaryData1>||XmlElement()||
|+|StgOrdrQryDef|ISO20022.Camt069001.StandingOrderQuery5||XmlElement()||
|+|MsgHdr|ISO20022.Camt069001.MessageHeader4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(StgOrdrQryDef),validElement(MsgHdr))|

