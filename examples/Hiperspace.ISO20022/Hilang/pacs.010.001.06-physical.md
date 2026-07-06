# pacs.010.001.06-physical
```mermaid
classDiagram
    class ISO20022.Pacs010001.Document {
        # Uri  : String
        + FIDrctDbt () : ISO20022.Pacs010001.FinancialInstitutionDirectDebitV06
        + Validation () = validation(validElement(FIDrctDbt))
    }
    class ISO20022.Pacs010001.FinancialInstitutionDirectDebitV06 {
        # owner  : ISO20022.Pacs010001.Document
        + SplmtryData  : List~ISO20022.Pacs010001.SupplementaryData1~
        + CdtInstr  : List~ISO20022.Pacs010001.CreditTransferTransaction66~
        + GrpHdr  : ISO20022.Pacs010001.GroupHeader119
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""CdtInstr""",CdtInstr),validList("""CdtInstr""",CdtInstr),validElement(CdtInstr),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Pacs010001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|FIDrctDbt|ISO20022.Pacs010001.FinancialInstitutionDirectDebitV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FIDrctDbt))|

---

## AspectImpl ISO20022.Pacs010001.FinancialInstitutionDirectDebitV06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Pacs010001.Document||||
|+|SplmtryData|List<ISO20022.Pacs010001.SupplementaryData1>||XmlElement()||
|+|CdtInstr|List<ISO20022.Pacs010001.CreditTransferTransaction66>||XmlElement()||
|+|GrpHdr|ISO20022.Pacs010001.GroupHeader119||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""CdtInstr""",CdtInstr),validList("""CdtInstr""",CdtInstr),validElement(CdtInstr),validElement(GrpHdr))|

