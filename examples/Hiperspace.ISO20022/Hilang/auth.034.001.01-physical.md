# auth.034.001.01-physical
```mermaid
classDiagram
    class ISO20022.Auth034001.Document {
        # Uri  : String
        + InvcTaxRpt () : ISO20022.Auth034001.InvoiceTaxReportV01
        + Validation () = validation(validElement(InvcTaxRpt))
    }
    class ISO20022.Auth034001.InvoiceTaxReportV01 {
        # owner  : ISO20022.Auth034001.Document
        + SplmtryData  : List~ISO20022.Auth034001.SupplementaryData1~
        + TaxRpt  : List~ISO20022.Auth034001.TaxReport1~
        + InvcTaxRptHdr  : ISO20022.Auth034001.TaxReportHeader1
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""TaxRpt""",TaxRpt),validList("""TaxRpt""",TaxRpt),validElement(TaxRpt),validElement(InvcTaxRptHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth034001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|InvcTaxRpt|ISO20022.Auth034001.InvoiceTaxReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InvcTaxRpt))|

---

## AspectImpl ISO20022.Auth034001.InvoiceTaxReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth034001.Document||||
|+|SplmtryData|List<ISO20022.Auth034001.SupplementaryData1>||XmlElement()||
|+|TaxRpt|List<ISO20022.Auth034001.TaxReport1>||XmlElement()||
|+|InvcTaxRptHdr|ISO20022.Auth034001.TaxReportHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""TaxRpt""",TaxRpt),validList("""TaxRpt""",TaxRpt),validElement(TaxRpt),validElement(InvcTaxRptHdr))|

