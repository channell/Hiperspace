# seev.038.002.09-physical
```mermaid
classDiagram
    class ISO20022.Seev038002.Document {
        # Uri  : String
        + CorpActnNrrtv () : ISO20022.Seev038002.CorporateActionNarrative002V09
        + Validation () = validation(validElement(CorpActnNrrtv))
    }
    class ISO20022.Seev038002.CorporateActionNarrative002V09 {
        # owner  : ISO20022.Seev038002.Document
        + SplmtryData  : List~ISO20022.Seev038002.SupplementaryData1~
        + AddtlInf  : List~String~
        + CorpActnGnlInf  : ISO20022.Seev038002.CorporateActionGeneralInformation102
        + UndrlygScty  : ISO20022.Seev038002.SecurityIdentification20
        + AcctDtls  : ISO20022.Seev038002.AccountIdentification77Choice
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""AddtlInf""",AddtlInf),validPattern("""AddtlInf""",AddtlInf,"""[0-9a-zA-Z!"%&\*;~~ \.,\(\)\n\r/='\+:\?@#\{\-_]{1,8000}"""),validElement(CorpActnGnlInf),validElement(UndrlygScty),validElement(AcctDtls))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Seev038002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CorpActnNrrtv|ISO20022.Seev038002.CorporateActionNarrative002V09||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnNrrtv))|

---

## AspectImpl ISO20022.Seev038002.CorporateActionNarrative002V09


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Seev038002.Document||||
|+|SplmtryData|List<ISO20022.Seev038002.SupplementaryData1>||XmlElement()||
|+|AddtlInf|List<String>||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev038002.CorporateActionGeneralInformation102||XmlElement()||
|+|UndrlygScty|ISO20022.Seev038002.SecurityIdentification20||XmlElement()||
|+|AcctDtls|ISO20022.Seev038002.AccountIdentification77Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""AddtlInf""",AddtlInf),validPattern("""AddtlInf""",AddtlInf,"""[0-9a-zA-Z!"%&\*;<> \.,\(\)\n\r/='\+:\?@#\{\-_]{1,8000}"""),validElement(CorpActnGnlInf),validElement(UndrlygScty),validElement(AcctDtls))|

