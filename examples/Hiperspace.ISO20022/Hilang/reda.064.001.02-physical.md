# reda.064.001.02-physical
```mermaid
classDiagram
    class ISO20022.Reda064001.Document {
        # Uri  : String
        + CalQry () : ISO20022.Reda064001.CalendarQueryV02
        + Validation () = validation(validElement(CalQry))
    }
    class ISO20022.Reda064001.CalendarQueryV02 {
        # owner  : ISO20022.Reda064001.Document
        + SplmtryData  : List~ISO20022.Reda064001.SupplementaryData1~
        + SchCrit  : List~ISO20022.Reda064001.CalendarSearchCriteria1~
        + MsgHdr  : ISO20022.Reda064001.MessageHeader9
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""SchCrit""",SchCrit),validElement(SchCrit),validElement(MsgHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda064001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CalQry|ISO20022.Reda064001.CalendarQueryV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CalQry))|

---

## AspectImpl ISO20022.Reda064001.CalendarQueryV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda064001.Document||||
|+|SplmtryData|List<ISO20022.Reda064001.SupplementaryData1>||XmlElement()||
|+|SchCrit|List<ISO20022.Reda064001.CalendarSearchCriteria1>||XmlElement()||
|+|MsgHdr|ISO20022.Reda064001.MessageHeader9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""SchCrit""",SchCrit),validElement(SchCrit),validElement(MsgHdr))|

