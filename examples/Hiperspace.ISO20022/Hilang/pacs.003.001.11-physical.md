# pacs.003.001.11-physical
```mermaid
classDiagram
    class ISO20022.Pacs003001.Document {
        # Uri  : String
        + FIToFICstmrDrctDbt () : ISO20022.Pacs003001.FIToFICustomerDirectDebitV11
        + Validation () = validation(validElement(FIToFICstmrDrctDbt))
    }
    class ISO20022.Pacs003001.FIToFICustomerDirectDebitV11 {
        # owner  : ISO20022.Pacs003001.Document
        + SplmtryData  : List~ISO20022.Pacs003001.SupplementaryData1~
        + DrctDbtTxInf  : List~ISO20022.Pacs003001.DirectDebitTransactionInformation31~
        + GrpHdr  : ISO20022.Pacs003001.GroupHeader125
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""DrctDbtTxInf""",DrctDbtTxInf),validList("""DrctDbtTxInf""",DrctDbtTxInf),validElement(DrctDbtTxInf),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Pacs003001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|FIToFICstmrDrctDbt|ISO20022.Pacs003001.FIToFICustomerDirectDebitV11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FIToFICstmrDrctDbt))|

---

## AspectImpl ISO20022.Pacs003001.FIToFICustomerDirectDebitV11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Pacs003001.Document||||
|+|SplmtryData|List<ISO20022.Pacs003001.SupplementaryData1>||XmlElement()||
|+|DrctDbtTxInf|List<ISO20022.Pacs003001.DirectDebitTransactionInformation31>||XmlElement()||
|+|GrpHdr|ISO20022.Pacs003001.GroupHeader125||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""DrctDbtTxInf""",DrctDbtTxInf),validList("""DrctDbtTxInf""",DrctDbtTxInf),validElement(DrctDbtTxInf),validElement(GrpHdr))|

