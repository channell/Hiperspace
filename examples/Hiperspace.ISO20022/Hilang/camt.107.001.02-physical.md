# camt.107.001.02-physical
```mermaid
classDiagram
    class ISO20022.Camt107001.Document {
        # Uri  : String
        + ChqPresntmntNtfctn () : ISO20022.Camt107001.ChequePresentmentNotificationV02
        + Validation () = validation(validElement(ChqPresntmntNtfctn))
    }
    class ISO20022.Camt107001.ChequePresentmentNotificationV02 {
        # owner  : ISO20022.Camt107001.Document
        + SplmtryData  : List~ISO20022.Camt107001.SupplementaryData1~
        + Chq  : List~ISO20022.Camt107001.Cheque17~
        + GrpHdr  : ISO20022.Camt107001.GroupHeader103
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

## EntityImpl ISO20022.Camt107001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ChqPresntmntNtfctn|ISO20022.Camt107001.ChequePresentmentNotificationV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ChqPresntmntNtfctn))|

---

## AspectImpl ISO20022.Camt107001.ChequePresentmentNotificationV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt107001.Document||||
|+|SplmtryData|List<ISO20022.Camt107001.SupplementaryData1>||XmlElement()||
|+|Chq|List<ISO20022.Camt107001.Cheque17>||XmlElement()||
|+|GrpHdr|ISO20022.Camt107001.GroupHeader103||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Chq""",Chq),validList("""Chq""",Chq),validElement(Chq),validElement(GrpHdr))|

