# tsin.008.001.01-physical
```mermaid
classDiagram
    class ISO20022.Tsin008001.Document {
        # Uri  : String
        + InvcAssgnmtNtfctn () : ISO20022.Tsin008001.InvoiceAssignmentNotificationV01
        + Validation () = validation(validElement(InvcAssgnmtNtfctn))
    }
    class ISO20022.Tsin008001.InvoiceAssignmentNotificationV01 {
        # owner  : ISO20022.Tsin008001.Document
        + AttchdMsg  : List~ISO20022.Tsin008001.EncapsulatedBusinessMessage1~
        + CtrlSum  : Decimal
        + ItmCnt  : String
        + NtfctnCnt  : String
        + NtfctnList  : List~ISO20022.Tsin008001.FinancingItemList1~
        + Hdr  : ISO20022.Tsin008001.BusinessLetter1
        + Validation () = validation(validList("""AttchdMsg""",AttchdMsg),validElement(AttchdMsg),validPattern("""ItmCnt""",ItmCnt,"""[0-9]{1,15}"""),validPattern("""NtfctnCnt""",NtfctnCnt,"""[0-9]{1,15}"""),validRequired("""NtfctnList""",NtfctnList),validList("""NtfctnList""",NtfctnList),validElement(NtfctnList),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Tsin008001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|InvcAssgnmtNtfctn|ISO20022.Tsin008001.InvoiceAssignmentNotificationV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InvcAssgnmtNtfctn))|

---

## AspectImpl ISO20022.Tsin008001.InvoiceAssignmentNotificationV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Tsin008001.Document||||
|+|AttchdMsg|List<ISO20022.Tsin008001.EncapsulatedBusinessMessage1>||XmlElement()||
|+|CtrlSum|Decimal||XmlElement()||
|+|ItmCnt|String||XmlElement()||
|+|NtfctnCnt|String||XmlElement()||
|+|NtfctnList|List<ISO20022.Tsin008001.FinancingItemList1>||XmlElement()||
|+|Hdr|ISO20022.Tsin008001.BusinessLetter1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AttchdMsg""",AttchdMsg),validElement(AttchdMsg),validPattern("""ItmCnt""",ItmCnt,"""[0-9]{1,15}"""),validPattern("""NtfctnCnt""",NtfctnCnt,"""[0-9]{1,15}"""),validRequired("""NtfctnList""",NtfctnList),validList("""NtfctnList""",NtfctnList),validElement(NtfctnList),validElement(Hdr))|

