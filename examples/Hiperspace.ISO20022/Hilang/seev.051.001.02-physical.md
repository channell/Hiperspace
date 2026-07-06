# seev.051.001.02-physical
```mermaid
classDiagram
    class ISO20022.Seev051001.Document {
        # Uri  : String
        + MktClmCxlReq () : ISO20022.Seev051001.MarketClaimCancellationRequestV02
        + Validation () = validation(validElement(MktClmCxlReq))
    }
    class ISO20022.Seev051001.MarketClaimCancellationRequestV02 {
        # owner  : ISO20022.Seev051001.Document
        + SplmtryData  : List~ISO20022.Seev051001.SupplementaryData1~
        + AcctDtls  : ISO20022.Seev051001.AccountIdentification70
        + CorpActnGnlInf  : ISO20022.Seev051001.CorporateActionGeneralInformation181
        + TxRef  : ISO20022.Seev051001.References26
        + MktClmCreId  : ISO20022.Seev051001.DocumentIdentification9
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AcctDtls),validElement(CorpActnGnlInf),validElement(TxRef),validElement(MktClmCreId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Seev051001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|MktClmCxlReq|ISO20022.Seev051001.MarketClaimCancellationRequestV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktClmCxlReq))|

---

## AspectImpl ISO20022.Seev051001.MarketClaimCancellationRequestV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Seev051001.Document||||
|+|SplmtryData|List<ISO20022.Seev051001.SupplementaryData1>||XmlElement()||
|+|AcctDtls|ISO20022.Seev051001.AccountIdentification70||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev051001.CorporateActionGeneralInformation181||XmlElement()||
|+|TxRef|ISO20022.Seev051001.References26||XmlElement()||
|+|MktClmCreId|ISO20022.Seev051001.DocumentIdentification9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AcctDtls),validElement(CorpActnGnlInf),validElement(TxRef),validElement(MktClmCreId))|

