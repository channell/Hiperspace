# camt.033.001.07-physical
```mermaid
classDiagram
    class ISO20022.Camt033001.Document {
        # Uri  : String
        + ReqForDplct () : ISO20022.Camt033001.RequestForDuplicateV07
        + Validation () = validation(validElement(ReqForDplct))
    }
    class ISO20022.Camt033001.RequestForDuplicateV07 {
        # owner  : ISO20022.Camt033001.Document
        + SplmtryData  : List~ISO20022.Camt033001.SupplementaryData1~
        + Case  : ISO20022.Camt033001.Case6
        + Assgnmt  : ISO20022.Camt033001.CaseAssignment6
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Case),validElement(Assgnmt))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt033001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ReqForDplct|ISO20022.Camt033001.RequestForDuplicateV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqForDplct))|

---

## AspectImpl ISO20022.Camt033001.RequestForDuplicateV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt033001.Document||||
|+|SplmtryData|List<ISO20022.Camt033001.SupplementaryData1>||XmlElement()||
|+|Case|ISO20022.Camt033001.Case6||XmlElement()||
|+|Assgnmt|ISO20022.Camt033001.CaseAssignment6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Case),validElement(Assgnmt))|

