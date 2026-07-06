# pacs.007.001.13-physical
```mermaid
classDiagram
    class ISO20022.Pacs007001.Document {
        # Uri  : String
        + FIToFIPmtRvsl () : ISO20022.Pacs007001.FIToFIPaymentReversalV13
        + Validation () = validation(validElement(FIToFIPmtRvsl))
    }
    class ISO20022.Pacs007001.FIToFIPaymentReversalV13 {
        # owner  : ISO20022.Pacs007001.Document
        + SplmtryData  : List~ISO20022.Pacs007001.SupplementaryData1~
        + TxInf  : List~ISO20022.Pacs007001.PaymentTransaction149~
        + OrgnlGrpInf  : ISO20022.Pacs007001.OriginalGroupHeader20
        + GrpHdr  : ISO20022.Pacs007001.GroupHeader127
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""TxInf""",TxInf),validElement(TxInf),validElement(OrgnlGrpInf),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Pacs007001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|FIToFIPmtRvsl|ISO20022.Pacs007001.FIToFIPaymentReversalV13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FIToFIPmtRvsl))|

---

## AspectImpl ISO20022.Pacs007001.FIToFIPaymentReversalV13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Pacs007001.Document||||
|+|SplmtryData|List<ISO20022.Pacs007001.SupplementaryData1>||XmlElement()||
|+|TxInf|List<ISO20022.Pacs007001.PaymentTransaction149>||XmlElement()||
|+|OrgnlGrpInf|ISO20022.Pacs007001.OriginalGroupHeader20||XmlElement()||
|+|GrpHdr|ISO20022.Pacs007001.GroupHeader127||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""TxInf""",TxInf),validElement(TxInf),validElement(OrgnlGrpInf),validElement(GrpHdr))|

