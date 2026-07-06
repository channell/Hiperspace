# camt.108.001.02-physical
```mermaid
classDiagram
    class ISO20022.Camt108001.Document {
        # Uri  : String
        + ChqCxlOrStopReq () : ISO20022.Camt108001.ChequeCancellationOrStopRequestV02
        + Validation () = validation(validElement(ChqCxlOrStopReq))
    }
    class ISO20022.Camt108001.ChequeCancellationOrStopRequestV02 {
        # owner  : ISO20022.Camt108001.Document
        + SplmtryData  : List~ISO20022.Camt108001.SupplementaryData1~
        + Chq  : List~ISO20022.Camt108001.Cheque20~
        + GrpHdr  : ISO20022.Camt108001.GroupHeader103
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Chq""",Chq),validList("""Chq""",Chq),validElement(Chq),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt108001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ChqCxlOrStopReq|ISO20022.Camt108001.ChequeCancellationOrStopRequestV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ChqCxlOrStopReq))|

---

## AspectImpl ISO20022.Camt108001.ChequeCancellationOrStopRequestV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt108001.Document||||
|+|SplmtryData|List<ISO20022.Camt108001.SupplementaryData1>||XmlElement()||
|+|Chq|List<ISO20022.Camt108001.Cheque20>||XmlElement()||
|+|GrpHdr|ISO20022.Camt108001.GroupHeader103||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Chq""",Chq),validList("""Chq""",Chq),validElement(Chq),validElement(GrpHdr))|

