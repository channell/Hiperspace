# reda.019.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda019001.Document {
        # Uri  : String
        + SctiesAcctQry () : ISO20022.Reda019001.SecuritiesAccountQueryV01
        + Validation () = validation(validElement(SctiesAcctQry))
    }
    class ISO20022.Reda019001.SecuritiesAccountQueryV01 {
        # owner  : ISO20022.Reda019001.Document
        + SplmtryData  : List~ISO20022.Reda019001.SupplementaryData1~
        + RtrCrit  : ISO20022.Reda019001.SecuritiesAccountReturnCriteria1
        + SchCrit  : ISO20022.Reda019001.SecuritiesAccountSearchCriteria2
        + MsgHdr  : ISO20022.Reda019001.MessageHeader2
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RtrCrit),validElement(SchCrit),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda019001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SctiesAcctQry|ISO20022.Reda019001.SecuritiesAccountQueryV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesAcctQry))|

---

## AspectImpl ISO20022.Reda019001.SecuritiesAccountQueryV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda019001.Document||||
|+|SplmtryData|List<ISO20022.Reda019001.SupplementaryData1>||XmlElement()||
|+|RtrCrit|ISO20022.Reda019001.SecuritiesAccountReturnCriteria1||XmlElement()||
|+|SchCrit|ISO20022.Reda019001.SecuritiesAccountSearchCriteria2||XmlElement()||
|+|MsgHdr|ISO20022.Reda019001.MessageHeader2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RtrCrit),validElement(SchCrit),validElement(MsgHdr))|

