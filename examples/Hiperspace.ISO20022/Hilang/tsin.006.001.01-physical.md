# tsin.006.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsin006001.Document {
        # Uri  : String
        + InvcAssgnmtReq () : ISO20022.Tsin006001.InvoiceAssignmentRequestV01
        + Validation () = validation(validElement(InvcAssgnmtReq))
    }
    class ISO20022.Tsin006001.InvoiceAssignmentRequestV01 {
        # owner  : ISO20022.Tsin006001.Document
        + AttchdMsg  : List~ISO20022.Tsin006001.EncapsulatedBusinessMessage1~
        + CtrlSum  : Decimal
        + ItmCnt  : String
        + AssgnmtCnt  : String
        + AssgnmtList  : List~ISO20022.Tsin006001.FinancingItemList1~
        + Hdr  : ISO20022.Tsin006001.BusinessLetter1
        + Validation () = validation(validList("""AttchdMsg""",AttchdMsg),validElement(AttchdMsg),validPattern("""ItmCnt""",ItmCnt,"""[0-9]{1,15}"""),validPattern("""AssgnmtCnt""",AssgnmtCnt,"""[0-9]{1,15}"""),validRequired("""AssgnmtList""",AssgnmtList),validList("""AssgnmtList""",AssgnmtList),validElement(AssgnmtList),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsin006001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|InvcAssgnmtReq|ISO20022.Tsin006001.InvoiceAssignmentRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InvcAssgnmtReq))|

---

## AspectImpl ISO20022.Tsin006001.InvoiceAssignmentRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsin006001.Document||||
|+|AttchdMsg|List<ISO20022.Tsin006001.EncapsulatedBusinessMessage1>||XmlElement()||
|+|CtrlSum|Decimal||XmlElement()||
|+|ItmCnt|String||XmlElement()||
|+|AssgnmtCnt|String||XmlElement()||
|+|AssgnmtList|List<ISO20022.Tsin006001.FinancingItemList1>||XmlElement()||
|+|Hdr|ISO20022.Tsin006001.BusinessLetter1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AttchdMsg""",AttchdMsg),validElement(AttchdMsg),validPattern("""ItmCnt""",ItmCnt,"""[0-9]{1,15}"""),validPattern("""AssgnmtCnt""",AssgnmtCnt,"""[0-9]{1,15}"""),validRequired("""AssgnmtList""",AssgnmtList),validList("""AssgnmtList""",AssgnmtList),validElement(AssgnmtList),validElement(Hdr))|

