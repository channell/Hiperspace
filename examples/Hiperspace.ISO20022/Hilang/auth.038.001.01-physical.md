# auth.038.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth038001.Document {
        # Uri  : String
        + InvcTaxRptStsAdvc () : ISO20022.Auth038001.InvoiceTaxReportStatusAdviceV01
        + Validation () = validation(validElement(InvcTaxRptStsAdvc))
    }
    class ISO20022.Auth038001.InvoiceTaxReportStatusAdviceV01 {
        # owner  : ISO20022.Auth038001.Document
        + SplmtryData  : List~ISO20022.Auth038001.SupplementaryData1~
        + TxSts  : List~ISO20022.Auth038001.InvoiceTaxReportTransactionStatus1~
        + StsRptHdr  : ISO20022.Auth038001.InvoiceTaxStatusReportHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""TxSts""",TxSts),validElement(TxSts),validElement(StsRptHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth038001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|InvcTaxRptStsAdvc|ISO20022.Auth038001.InvoiceTaxReportStatusAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InvcTaxRptStsAdvc))|

---

## AspectImpl ISO20022.Auth038001.InvoiceTaxReportStatusAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth038001.Document||||
|+|SplmtryData|List<ISO20022.Auth038001.SupplementaryData1>||XmlElement()||
|+|TxSts|List<ISO20022.Auth038001.InvoiceTaxReportTransactionStatus1>||XmlElement()||
|+|StsRptHdr|ISO20022.Auth038001.InvoiceTaxStatusReportHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""TxSts""",TxSts),validElement(TxSts),validElement(StsRptHdr))|

