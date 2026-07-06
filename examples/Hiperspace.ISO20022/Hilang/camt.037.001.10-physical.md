# camt.037.001.10-physical
```mermaid
classDiagram
    class ISO20022.Camt037001.Document {
        # Uri  : String
        + DbtAuthstnReq () : ISO20022.Camt037001.DebitAuthorisationRequestV10
        + Validation () = validation(validElement(DbtAuthstnReq))
    }
    class ISO20022.Camt037001.DebitAuthorisationRequestV10 {
        # owner  : ISO20022.Camt037001.Document
        + SplmtryData  : List~ISO20022.Camt037001.SupplementaryData1~
        + Dtl  : ISO20022.Camt037001.DebitAuthorisation2
        + Undrlyg  : ISO20022.Camt037001.UnderlyingTransaction8Choice
        + Case  : ISO20022.Camt037001.Case6
        + Assgnmt  : ISO20022.Camt037001.CaseAssignment6
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Dtl),validElement(Undrlyg),validElement(Case),validElement(Assgnmt))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt037001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|DbtAuthstnReq|ISO20022.Camt037001.DebitAuthorisationRequestV10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DbtAuthstnReq))|

---

## AspectImpl ISO20022.Camt037001.DebitAuthorisationRequestV10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt037001.Document||||
|+|SplmtryData|List<ISO20022.Camt037001.SupplementaryData1>||XmlElement()||
|+|Dtl|ISO20022.Camt037001.DebitAuthorisation2||XmlElement()||
|+|Undrlyg|ISO20022.Camt037001.UnderlyingTransaction8Choice||XmlElement()||
|+|Case|ISO20022.Camt037001.Case6||XmlElement()||
|+|Assgnmt|ISO20022.Camt037001.CaseAssignment6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Dtl),validElement(Undrlyg),validElement(Case),validElement(Assgnmt))|

