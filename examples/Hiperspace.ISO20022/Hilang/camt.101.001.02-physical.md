# camt.101.001.02-physical
```mermaid
classDiagram
    class ISO20022.Camt101001.Document {
        # Uri  : String
        + CretLmt () : ISO20022.Camt101001.CreateLimitV02
        + Validation () = validation(validElement(CretLmt))
    }
    class ISO20022.Camt101001.CreateLimitV02 {
        # owner  : ISO20022.Camt101001.Document
        + SplmtryData  : List~ISO20022.Camt101001.SupplementaryData1~
        + LmtData  : List~ISO20022.Camt101001.LimitStructure6~
        + MsgHdr  : ISO20022.Camt101001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""LmtData""",LmtData),validList("""LmtData""",LmtData),validElement(LmtData),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt101001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CretLmt|ISO20022.Camt101001.CreateLimitV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CretLmt))|

---

## AspectImpl ISO20022.Camt101001.CreateLimitV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt101001.Document||||
|+|SplmtryData|List<ISO20022.Camt101001.SupplementaryData1>||XmlElement()||
|+|LmtData|List<ISO20022.Camt101001.LimitStructure6>||XmlElement()||
|+|MsgHdr|ISO20022.Camt101001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""LmtData""",LmtData),validList("""LmtData""",LmtData),validElement(LmtData),validElement(MsgHdr))|

