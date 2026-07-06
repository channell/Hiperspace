# tsmt.042.001.03-physical
```mermaid
classDiagram
    class ISO20022.Tsmt042001.Document {
        # Uri  : String
        + TxRptReq () : ISO20022.Tsmt042001.TransactionReportRequestV03
        + Validation () = validation(validElement(TxRptReq))
    }
    class ISO20022.Tsmt042001.TransactionReportRequestV03 {
        # owner  : ISO20022.Tsmt042001.Document
        + RptSpcfctn  : ISO20022.Tsmt042001.ReportSpecification4
        + ReqId  : ISO20022.Tsmt042001.MessageIdentification1
        + Validation () = validation(validElement(RptSpcfctn),validElement(ReqId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsmt042001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|TxRptReq|ISO20022.Tsmt042001.TransactionReportRequestV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxRptReq))|

---

## AspectImpl ISO20022.Tsmt042001.TransactionReportRequestV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsmt042001.Document||||
|+|RptSpcfctn|ISO20022.Tsmt042001.ReportSpecification4||XmlElement()||
|+|ReqId|ISO20022.Tsmt042001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RptSpcfctn),validElement(ReqId))|

