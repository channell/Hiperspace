# reda.015.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda015001.Document {
        # Uri  : String
        + PtyQry () : ISO20022.Reda015001.PartyQueryV01
        + Validation () = validation(validElement(PtyQry))
    }
    class ISO20022.Reda015001.PartyQueryV01 {
        # owner  : ISO20022.Reda015001.Document
        + SplmtryData  : List~ISO20022.Reda015001.SupplementaryData1~
        + RtrCrit  : ISO20022.Reda015001.PartyDataReturnCriteria2
        + SchCrit  : ISO20022.Reda015001.PartyDataSearchCriteria2
        + MsgHdr  : ISO20022.Reda015001.MessageHeader2
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

## EntityImpl ISO20022.Reda015001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PtyQry|ISO20022.Reda015001.PartyQueryV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyQry))|

---

## AspectImpl ISO20022.Reda015001.PartyQueryV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda015001.Document||||
|+|SplmtryData|List<ISO20022.Reda015001.SupplementaryData1>||XmlElement()||
|+|RtrCrit|ISO20022.Reda015001.PartyDataReturnCriteria2||XmlElement()||
|+|SchCrit|ISO20022.Reda015001.PartyDataSearchCriteria2||XmlElement()||
|+|MsgHdr|ISO20022.Reda015001.MessageHeader2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RtrCrit),validElement(SchCrit),validElement(MsgHdr))|

