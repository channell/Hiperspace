# camt.035.001.06-physical
```mermaid
classDiagram
    class ISO20022.Camt035001.Document {
        # Uri  : String
        + PrtryFrmtInvstgtn () : ISO20022.Camt035001.ProprietaryFormatInvestigationV06
        + Validation () = validation(validElement(PrtryFrmtInvstgtn))
    }
    class ISO20022.Camt035001.ProprietaryFormatInvestigationV06 {
        # owner  : ISO20022.Camt035001.Document
        + SplmtryData  : List~ISO20022.Camt035001.SupplementaryData1~
        + PrtryData  : ISO20022.Camt035001.ProprietaryData7
        + Case  : ISO20022.Camt035001.Case6
        + Assgnmt  : ISO20022.Camt035001.CaseAssignment6
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(PrtryData),validElement(Case),validElement(Assgnmt))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt035001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|PrtryFrmtInvstgtn|ISO20022.Camt035001.ProprietaryFormatInvestigationV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryFrmtInvstgtn))|

---

## AspectImpl ISO20022.Camt035001.ProprietaryFormatInvestigationV06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt035001.Document||||
|+|SplmtryData|List<ISO20022.Camt035001.SupplementaryData1>||XmlElement()||
|+|PrtryData|ISO20022.Camt035001.ProprietaryData7||XmlElement()||
|+|Case|ISO20022.Camt035001.Case6||XmlElement()||
|+|Assgnmt|ISO20022.Camt035001.CaseAssignment6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(PrtryData),validElement(Case),validElement(Assgnmt))|

