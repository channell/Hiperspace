# pain.008.001.11-physical
```mermaid
classDiagram
    class ISO20022.Pain008001.Document {
        # Uri  : String
        + CstmrDrctDbtInitn () : ISO20022.Pain008001.CustomerDirectDebitInitiationV11
        + Validation () = validation(validElement(CstmrDrctDbtInitn))
    }
    class ISO20022.Pain008001.CustomerDirectDebitInitiationV11 {
        # owner  : ISO20022.Pain008001.Document
        + SplmtryData  : List~ISO20022.Pain008001.SupplementaryData1~
        + PmtInf  : List~ISO20022.Pain008001.PaymentInstruction45~
        + GrpHdr  : ISO20022.Pain008001.GroupHeader118
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""PmtInf""",PmtInf),validList("""PmtInf""",PmtInf),validElement(PmtInf),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Pain008001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CstmrDrctDbtInitn|ISO20022.Pain008001.CustomerDirectDebitInitiationV11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CstmrDrctDbtInitn))|

---

## AspectImpl ISO20022.Pain008001.CustomerDirectDebitInitiationV11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Pain008001.Document||||
|+|SplmtryData|List<ISO20022.Pain008001.SupplementaryData1>||XmlElement()||
|+|PmtInf|List<ISO20022.Pain008001.PaymentInstruction45>||XmlElement()||
|+|GrpHdr|ISO20022.Pain008001.GroupHeader118||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""PmtInf""",PmtInf),validList("""PmtInf""",PmtInf),validElement(PmtInf),validElement(GrpHdr))|

