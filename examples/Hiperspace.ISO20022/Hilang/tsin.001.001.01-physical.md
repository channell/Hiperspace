# tsin.001.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsin001001.Document {
        # Uri  : String
        + InvcFincgReq () : ISO20022.Tsin001001.InvoiceFinancingRequestV01
        + Validation () = validation(validElement(InvcFincgReq))
    }
    class ISO20022.Tsin001001.InvoiceFinancingRequestV01 {
        # owner  : ISO20022.Tsin001001.Document
        + InvcReqInf  : List~ISO20022.Tsin001001.InvoiceRequestInformation1~
        + ReqGrpInf  : ISO20022.Tsin001001.RequestGroupInformation1
        + Validation () = validation(validRequired("""InvcReqInf""",InvcReqInf),validList("""InvcReqInf""",InvcReqInf),validElement(InvcReqInf),validElement(ReqGrpInf))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsin001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|InvcFincgReq|ISO20022.Tsin001001.InvoiceFinancingRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InvcFincgReq))|

---

## AspectImpl ISO20022.Tsin001001.InvoiceFinancingRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsin001001.Document||||
|+|InvcReqInf|List<ISO20022.Tsin001001.InvoiceRequestInformation1>||XmlElement()||
|+|ReqGrpInf|ISO20022.Tsin001001.RequestGroupInformation1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""InvcReqInf""",InvcReqInf),validList("""InvcReqInf""",InvcReqInf),validElement(InvcReqInf),validElement(ReqGrpInf))|

