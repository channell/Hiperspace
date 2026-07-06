# camt.027.001.10-physical
```mermaid
classDiagram
    class ISO20022.Camt027001.Document {
        # Uri  : String
        + ClmNonRct () : ISO20022.Camt027001.ClaimNonReceiptV10
        + Validation () = validation(validElement(ClmNonRct))
    }
    class ISO20022.Camt027001.ClaimNonReceiptV10 {
        # owner  : ISO20022.Camt027001.Document
        + SplmtryData  : List~ISO20022.Camt027001.SupplementaryData1~
        + InstrForAssgne  : ISO20022.Camt027001.InstructionForAssignee1
        + CoverDtls  : ISO20022.Camt027001.MissingCover6
        + Undrlyg  : ISO20022.Camt027001.UnderlyingTransaction8Choice
        + Case  : ISO20022.Camt027001.Case6
        + Assgnmt  : ISO20022.Camt027001.CaseAssignment6
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(InstrForAssgne),validElement(CoverDtls),validElement(Undrlyg),validElement(Case),validElement(Assgnmt))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt027001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ClmNonRct|ISO20022.Camt027001.ClaimNonReceiptV10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClmNonRct))|

---

## AspectImpl ISO20022.Camt027001.ClaimNonReceiptV10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt027001.Document||||
|+|SplmtryData|List<ISO20022.Camt027001.SupplementaryData1>||XmlElement()||
|+|InstrForAssgne|ISO20022.Camt027001.InstructionForAssignee1||XmlElement()||
|+|CoverDtls|ISO20022.Camt027001.MissingCover6||XmlElement()||
|+|Undrlyg|ISO20022.Camt027001.UnderlyingTransaction8Choice||XmlElement()||
|+|Case|ISO20022.Camt027001.Case6||XmlElement()||
|+|Assgnmt|ISO20022.Camt027001.CaseAssignment6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(InstrForAssgne),validElement(CoverDtls),validElement(Undrlyg),validElement(Case),validElement(Assgnmt))|

