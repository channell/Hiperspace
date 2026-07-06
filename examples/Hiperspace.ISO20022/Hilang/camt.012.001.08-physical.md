# camt.012.001.08-physical
```mermaid
classDiagram
    class ISO20022.Camt012001.Document {
        # Uri  : String
        + DelLmt () : ISO20022.Camt012001.DeleteLimitV08
        + Validation () = validation(validElement(DelLmt))
    }
    class ISO20022.Camt012001.DeleteLimitV08 {
        # owner  : ISO20022.Camt012001.Document
        + SplmtryData  : List~ISO20022.Camt012001.SupplementaryData1~
        + LmtDtls  : ISO20022.Camt012001.LimitStructure3Choice
        + MsgHdr  : ISO20022.Camt012001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(LmtDtls),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt012001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|DelLmt|ISO20022.Camt012001.DeleteLimitV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DelLmt))|

---

## AspectImpl ISO20022.Camt012001.DeleteLimitV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt012001.Document||||
|+|SplmtryData|List<ISO20022.Camt012001.SupplementaryData1>||XmlElement()||
|+|LmtDtls|ISO20022.Camt012001.LimitStructure3Choice||XmlElement()||
|+|MsgHdr|ISO20022.Camt012001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(LmtDtls),validElement(MsgHdr))|

