# auth.026.001.04-physical
```mermaid
classDiagram
    class ISO20022.Auth026001.Document {
        # Uri  : String
        + CcyCtrlReqOrLttr () : ISO20022.Auth026001.CurrencyControlRequestOrLetterV04
        + Validation () = validation(validElement(CcyCtrlReqOrLttr))
    }
    class ISO20022.Auth026001.CurrencyControlRequestOrLetterV04 {
        # owner  : ISO20022.Auth026001.Document
        + SplmtryData  : List~ISO20022.Auth026001.SupplementaryData1~
        + ReqOrLttr  : List~ISO20022.Auth026001.SupportingDocumentRequestOrLetter4~
        + GrpHdr  : ISO20022.Auth026001.CurrencyControlHeader9
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""ReqOrLttr""",ReqOrLttr),validList("""ReqOrLttr""",ReqOrLttr),validElement(ReqOrLttr),validElement(GrpHdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Auth026001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CcyCtrlReqOrLttr|ISO20022.Auth026001.CurrencyControlRequestOrLetterV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CcyCtrlReqOrLttr))|

---

## AspectImpl ISO20022.Auth026001.CurrencyControlRequestOrLetterV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Auth026001.Document||||
|+|SplmtryData|List<ISO20022.Auth026001.SupplementaryData1>||XmlElement()||
|+|ReqOrLttr|List<ISO20022.Auth026001.SupportingDocumentRequestOrLetter4>||XmlElement()||
|+|GrpHdr|ISO20022.Auth026001.CurrencyControlHeader9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""ReqOrLttr""",ReqOrLttr),validList("""ReqOrLttr""",ReqOrLttr),validElement(ReqOrLttr),validElement(GrpHdr))|

