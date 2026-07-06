# reda.017.001.02-physical
```mermaid
classDiagram
    class ISO20022.Reda017001.Document {
        # Uri  : String
        + PtyRpt () : ISO20022.Reda017001.PartyReportV02
        + Validation () = validation(validElement(PtyRpt))
    }
    class ISO20022.Reda017001.PartyReportV02 {
        # owner  : ISO20022.Reda017001.Document
        + SplmtryData  : List~ISO20022.Reda017001.SupplementaryData1~
        + RptOrErr  : ISO20022.Reda017001.PartyOrOperationalError4Choice
        + MsgHdr  : ISO20022.Reda017001.MessageHeader3
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

## EntityImpl ISO20022.Reda017001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PtyRpt|ISO20022.Reda017001.PartyReportV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyRpt))|

---

## AspectImpl ISO20022.Reda017001.PartyReportV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda017001.Document||||
|+|SplmtryData|List<ISO20022.Reda017001.SupplementaryData1>||XmlElement()||
|+|RptOrErr|ISO20022.Reda017001.PartyOrOperationalError4Choice||XmlElement()||
|+|MsgHdr|ISO20022.Reda017001.MessageHeader3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))|

