# camt.036.001.06-physical
```mermaid
classDiagram
    class ISO20022.Camt036001.Document {
        # Uri  : String
        + DbtAuthstnRspn () : ISO20022.Camt036001.DebitAuthorisationResponseV06
        + Validation () = validation(validElement(DbtAuthstnRspn))
    }
    class ISO20022.Camt036001.DebitAuthorisationResponseV06 {
        # owner  : ISO20022.Camt036001.Document
        + SplmtryData  : List~ISO20022.Camt036001.SupplementaryData1~
        + Conf  : ISO20022.Camt036001.DebitAuthorisationConfirmation2
        + Case  : ISO20022.Camt036001.Case6
        + Assgnmt  : ISO20022.Camt036001.CaseAssignment6
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Conf),validElement(Case),validElement(Assgnmt))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt036001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|DbtAuthstnRspn|ISO20022.Camt036001.DebitAuthorisationResponseV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DbtAuthstnRspn))|

---

## AspectImpl ISO20022.Camt036001.DebitAuthorisationResponseV06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt036001.Document||||
|+|SplmtryData|List<ISO20022.Camt036001.SupplementaryData1>||XmlElement()||
|+|Conf|ISO20022.Camt036001.DebitAuthorisationConfirmation2||XmlElement()||
|+|Case|ISO20022.Camt036001.Case6||XmlElement()||
|+|Assgnmt|ISO20022.Camt036001.CaseAssignment6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Conf),validElement(Case),validElement(Assgnmt))|

