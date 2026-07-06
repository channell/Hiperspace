# pacs.028.001.06-physical
```mermaid
classDiagram
    class ISO20022.Pacs028001.Document {
        # Uri  : String
        + FIToFIPmtStsReq () : ISO20022.Pacs028001.FIToFIPaymentStatusRequestV06
        + Validation () = validation(validElement(FIToFIPmtStsReq))
    }
    class ISO20022.Pacs028001.FIToFIPaymentStatusRequestV06 {
        # owner  : ISO20022.Pacs028001.Document
        + SplmtryData  : List~ISO20022.Pacs028001.SupplementaryData1~
        + TxInf  : List~ISO20022.Pacs028001.PaymentTransaction158~
        + OrgnlGrpInf  : List~ISO20022.Pacs028001.OriginalGroupInformation27~
        + GrpHdr  : ISO20022.Pacs028001.GroupHeader109
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""TxInf""",TxInf),validElement(TxInf),validList("""OrgnlGrpInf""",OrgnlGrpInf),validElement(OrgnlGrpInf),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Pacs028001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|FIToFIPmtStsReq|ISO20022.Pacs028001.FIToFIPaymentStatusRequestV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FIToFIPmtStsReq))|

---

## AspectImpl ISO20022.Pacs028001.FIToFIPaymentStatusRequestV06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Pacs028001.Document||||
|+|SplmtryData|List<ISO20022.Pacs028001.SupplementaryData1>||XmlElement()||
|+|TxInf|List<ISO20022.Pacs028001.PaymentTransaction158>||XmlElement()||
|+|OrgnlGrpInf|List<ISO20022.Pacs028001.OriginalGroupInformation27>||XmlElement()||
|+|GrpHdr|ISO20022.Pacs028001.GroupHeader109||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""TxInf""",TxInf),validElement(TxInf),validList("""OrgnlGrpInf""",OrgnlGrpInf),validElement(OrgnlGrpInf),validElement(GrpHdr))|

