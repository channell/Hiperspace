# camt.026.001.10-physical
```mermaid
classDiagram
    class ISO20022.Camt026001.Document {
        # Uri  : String
        + UblToApply () : ISO20022.Camt026001.UnableToApplyV10
        + Validation () = validation(validElement(UblToApply))
    }
    class ISO20022.Camt026001.UnableToApplyV10 {
        # owner  : ISO20022.Camt026001.Document
        + SplmtryData  : List~ISO20022.Camt026001.SupplementaryData1~
        + Justfn  : ISO20022.Camt026001.UnableToApplyJustification4Choice
        + Undrlyg  : ISO20022.Camt026001.UnderlyingTransaction8Choice
        + Case  : ISO20022.Camt026001.Case6
        + Assgnmt  : ISO20022.Camt026001.CaseAssignment6
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Justfn),validElement(Undrlyg),validElement(Case),validElement(Assgnmt))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt026001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|UblToApply|ISO20022.Camt026001.UnableToApplyV10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UblToApply))|

---

## AspectImpl ISO20022.Camt026001.UnableToApplyV10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt026001.Document||||
|+|SplmtryData|List<ISO20022.Camt026001.SupplementaryData1>||XmlElement()||
|+|Justfn|ISO20022.Camt026001.UnableToApplyJustification4Choice||XmlElement()||
|+|Undrlyg|ISO20022.Camt026001.UnderlyingTransaction8Choice||XmlElement()||
|+|Case|ISO20022.Camt026001.Case6||XmlElement()||
|+|Assgnmt|ISO20022.Camt026001.CaseAssignment6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Justfn),validElement(Undrlyg),validElement(Case),validElement(Assgnmt))|

