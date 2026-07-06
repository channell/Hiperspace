# camt.087.001.09-physical
```mermaid
classDiagram
    class ISO20022.Camt087001.Document {
        # Uri  : String
        + ReqToModfyPmt () : ISO20022.Camt087001.RequestToModifyPaymentV09
        + Validation () = validation(validElement(ReqToModfyPmt))
    }
    class ISO20022.Camt087001.RequestToModifyPaymentV09 {
        # owner  : ISO20022.Camt087001.Document
        + SplmtryData  : List~ISO20022.Camt087001.SupplementaryData1~
        + InstrForAssgne  : ISO20022.Camt087001.InstructionForAssignee1
        + Mod  : ISO20022.Camt087001.RequestedModification11
        + Undrlyg  : ISO20022.Camt087001.UnderlyingTransaction8Choice
        + Case  : ISO20022.Camt087001.Case6
        + Assgnmt  : ISO20022.Camt087001.CaseAssignment6
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(InstrForAssgne),validElement(Mod),validElement(Undrlyg),validElement(Case),validElement(Assgnmt))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt087001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ReqToModfyPmt|ISO20022.Camt087001.RequestToModifyPaymentV09||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqToModfyPmt))|

---

## AspectImpl ISO20022.Camt087001.RequestToModifyPaymentV09


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt087001.Document||||
|+|SplmtryData|List<ISO20022.Camt087001.SupplementaryData1>||XmlElement()||
|+|InstrForAssgne|ISO20022.Camt087001.InstructionForAssignee1||XmlElement()||
|+|Mod|ISO20022.Camt087001.RequestedModification11||XmlElement()||
|+|Undrlyg|ISO20022.Camt087001.UnderlyingTransaction8Choice||XmlElement()||
|+|Case|ISO20022.Camt087001.Case6||XmlElement()||
|+|Assgnmt|ISO20022.Camt087001.CaseAssignment6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(InstrForAssgne),validElement(Mod),validElement(Undrlyg),validElement(Case),validElement(Assgnmt))|

