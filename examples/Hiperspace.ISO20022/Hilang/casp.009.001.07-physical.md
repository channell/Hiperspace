# casp.009.001.07-physical
```mermaid
classDiagram
    class ISO20022.Casp009001.Document {
        # Uri  : String
        + SaleToPOIRptReq () : ISO20022.Casp009001.SaleToPOIReportRequestV07
        + Validation () = validation(validElement(SaleToPOIRptReq))
    }
    class ISO20022.Casp009001.SaleToPOIReportRequestV07 {
        # owner  : ISO20022.Casp009001.Document
        + SctyTrlr  : ISO20022.Casp009001.ContentInformationType38
        + RptReq  : ISO20022.Casp009001.ReportRequest8
        + Hdr  : ISO20022.Casp009001.Header41
        + Validation () = validation(validElement(SctyTrlr),validElement(RptReq),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Casp009001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SaleToPOIRptReq|ISO20022.Casp009001.SaleToPOIReportRequestV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SaleToPOIRptReq))|

---

## AspectImpl ISO20022.Casp009001.SaleToPOIReportRequestV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Casp009001.Document||||
|+|SctyTrlr|ISO20022.Casp009001.ContentInformationType38||XmlElement()||
|+|RptReq|ISO20022.Casp009001.ReportRequest8||XmlElement()||
|+|Hdr|ISO20022.Casp009001.Header41||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validElement(RptReq),validElement(Hdr))|

