# camt.011.001.08-physical
```mermaid
classDiagram
    class ISO20022.Camt011001.Document {
        # Uri  : String
        + ModfyLmt () : ISO20022.Camt011001.ModifyLimitV08
        + Validation () = validation(validElement(ModfyLmt))
    }
    class ISO20022.Camt011001.ModifyLimitV08 {
        # owner  : ISO20022.Camt011001.Document
        + SplmtryData  : List~ISO20022.Camt011001.SupplementaryData1~
        + LmtDtls  : List~ISO20022.Camt011001.LimitStructure5~
        + MsgHdr  : ISO20022.Camt011001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""LmtDtls""",LmtDtls),validElement(LmtDtls),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt011001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ModfyLmt|ISO20022.Camt011001.ModifyLimitV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ModfyLmt))|

---

## AspectImpl ISO20022.Camt011001.ModifyLimitV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt011001.Document||||
|+|SplmtryData|List<ISO20022.Camt011001.SupplementaryData1>||XmlElement()||
|+|LmtDtls|List<ISO20022.Camt011001.LimitStructure5>||XmlElement()||
|+|MsgHdr|ISO20022.Camt011001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""LmtDtls""",LmtDtls),validElement(LmtDtls),validElement(MsgHdr))|

