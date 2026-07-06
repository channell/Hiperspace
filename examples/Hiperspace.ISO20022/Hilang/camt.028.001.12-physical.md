# camt.028.001.12-physical
```mermaid
classDiagram
    class ISO20022.Camt028001.Document {
        # Uri  : String
        + AddtlPmtInf () : ISO20022.Camt028001.AdditionalPaymentInformationV12
        + Validation () = validation(validElement(AddtlPmtInf))
    }
    class ISO20022.Camt028001.AdditionalPaymentInformationV12 {
        # owner  : ISO20022.Camt028001.Document
        + SplmtryData  : List~ISO20022.Camt028001.SupplementaryData1~
        + Inf  : ISO20022.Camt028001.PaymentComplementaryInformation11
        + Undrlyg  : ISO20022.Camt028001.UnderlyingTransaction8Choice
        + Case  : ISO20022.Camt028001.Case6
        + Assgnmt  : ISO20022.Camt028001.CaseAssignment6
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Inf),validElement(Undrlyg),validElement(Case),validElement(Assgnmt))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Camt028001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AddtlPmtInf|ISO20022.Camt028001.AdditionalPaymentInformationV12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlPmtInf))|

---

## AspectImpl ISO20022.Camt028001.AdditionalPaymentInformationV12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Camt028001.Document||||
|+|SplmtryData|List<ISO20022.Camt028001.SupplementaryData1>||XmlElement()||
|+|Inf|ISO20022.Camt028001.PaymentComplementaryInformation11||XmlElement()||
|+|Undrlyg|ISO20022.Camt028001.UnderlyingTransaction8Choice||XmlElement()||
|+|Case|ISO20022.Camt028001.Case6||XmlElement()||
|+|Assgnmt|ISO20022.Camt028001.CaseAssignment6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Inf),validElement(Undrlyg),validElement(Case),validElement(Assgnmt))|

