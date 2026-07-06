# camt.064.001.01-physical
```mermaid
classDiagram
    class ISO20022.Camt064001.Document {
        # Uri  : String
        + LmtUtlstnJrnlQry () : ISO20022.Camt064001.LimitUtilisationJournalQueryV01
        + Validation () = validation(validElement(LmtUtlstnJrnlQry))
    }
    class ISO20022.Camt064001.LimitUtilisationJournalQueryV01 {
        # owner  : ISO20022.Camt064001.Document
        + SplmtryData  : List~ISO20022.Camt064001.SupplementaryData1~
        + SchCrit  : ISO20022.Camt064001.LimitUtilisationJournalSearchCriteria2
        + MsgHdr  : ISO20022.Camt064001.MessageHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SchCrit),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt064001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|LmtUtlstnJrnlQry|ISO20022.Camt064001.LimitUtilisationJournalQueryV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LmtUtlstnJrnlQry))|

---

## AspectImpl ISO20022.Camt064001.LimitUtilisationJournalQueryV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt064001.Document||||
|+|SplmtryData|List<ISO20022.Camt064001.SupplementaryData1>||XmlElement()||
|+|SchCrit|ISO20022.Camt064001.LimitUtilisationJournalSearchCriteria2||XmlElement()||
|+|MsgHdr|ISO20022.Camt064001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SchCrit),validElement(MsgHdr))|

