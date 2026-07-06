# reda.056.001.01-physical
```mermaid
classDiagram
    class ISO20022.Reda056001.Document {
        # Uri  : String
        + StgSttlmInstr () : ISO20022.Reda056001.StandingSettlementInstructionV01
        + Validation () = validation(validElement(StgSttlmInstr))
    }
    class ISO20022.Reda056001.StandingSettlementInstructionV01 {
        # owner  : ISO20022.Reda056001.Document
        + SplmtryData  : List~ISO20022.Reda056001.SupplementaryData1~
        + SttlmDtls  : ISO20022.Reda056001.SecuritiesOrCash1Choice
        + SttlmCcy  : String
        + MktId  : ISO20022.Reda056001.MarketIdentificationOrCashPurpose1Choice
        + AcctId  : List~ISO20022.Reda056001.AccountIdentification26~
        + FctvDtDtls  : ISO20022.Reda056001.EffectiveDate1
        + MsgRefId  : String
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SttlmDtls),validPattern("""SttlmCcy""",SttlmCcy,"""[A-Z]{3,3}"""),validElement(MktId),validRequired("""AcctId""",AcctId),validList("""AcctId""",AcctId),validElement(AcctId),validElement(FctvDtDtls))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Reda056001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|StgSttlmInstr|ISO20022.Reda056001.StandingSettlementInstructionV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StgSttlmInstr))|

---

## AspectImpl ISO20022.Reda056001.StandingSettlementInstructionV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Reda056001.Document||||
|+|SplmtryData|List<ISO20022.Reda056001.SupplementaryData1>||XmlElement()||
|+|SttlmDtls|ISO20022.Reda056001.SecuritiesOrCash1Choice||XmlElement()||
|+|SttlmCcy|String||XmlElement()||
|+|MktId|ISO20022.Reda056001.MarketIdentificationOrCashPurpose1Choice||XmlElement()||
|+|AcctId|List<ISO20022.Reda056001.AccountIdentification26>||XmlElement()||
|+|FctvDtDtls|ISO20022.Reda056001.EffectiveDate1||XmlElement()||
|+|MsgRefId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(SttlmDtls),validPattern("""SttlmCcy""",SttlmCcy,"""[A-Z]{3,3}"""),validElement(MktId),validRequired("""AcctId""",AcctId),validList("""AcctId""",AcctId),validElement(AcctId),validElement(FctvDtDtls))|

