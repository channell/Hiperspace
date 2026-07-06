# casr.001.001.03-physical
```mermaid
classDiagram
    class ISO20022.Casr001001.Document {
        # Uri  : String
        + SttlmRptgInitn () : ISO20022.Casr001001.SettlementReportingInitiationV03
        + Validation () = validation(validElement(SttlmRptgInitn))
    }
    class ISO20022.Casr001001.SettlementReportingInitiationV03 {
        # owner  : ISO20022.Casr001001.Document
        + SctyTrlr  : ISO20022.Casr001001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Casr001001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Casr001001.ProtectedData2~
        + AddtlData  : List~ISO20022.Casr001001.AdditionalData2~
        + TxDesc  : String
        + Rcncltn  : ISO20022.Casr001001.Reconciliation4
        + AddtlFee  : List~ISO20022.Casr001001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Casr001001.SettlementService6
        + Jursdctn  : ISO20022.Casr001001.Jurisdiction2
        + FndsTrfAmt  : ISO20022.Casr001001.Amount17
        + TtlSttlmAmt  : ISO20022.Casr001001.SettlementCategoryTotal2
        + OthrSttlmTtls  : ISO20022.Casr001001.SettlementCategoryTotal3
        + IssrSttlmTtls  : ISO20022.Casr001001.SettlementCategoryTotal3
        + AcqrrSttlmTtls  : ISO20022.Casr001001.SettlementCategoryTotal3
        + AltrnMsgRsn  : List~String~
        + MsgRsn  : List~String~
        + OthrSttlmRptTp  : String
        + SttlmRptTp  : String
        + LifeCyclId  : String
        + RtrvlRefNb  : String
        + TrnsmssnDtTm  : DateTime
        + SysTracAudtNb  : String
        + Prgrmm  : List~ISO20022.Casr001001.ProgrammeMode5~
        + OthrInstn  : ISO20022.Casr001001.PartyIdentification285
        + FI  : ISO20022.Casr001001.FinancialInstitution9
        + Dstn  : ISO20022.Casr001001.PartyIdentification286
        + Rcvr  : ISO20022.Casr001001.PartyIdentification286
        + Sndr  : ISO20022.Casr001001.PartyIdentification286
        + Orgtr  : ISO20022.Casr001001.PartyIdentification286
        + SttlmInstn  : ISO20022.Casr001001.PartyIdentification286
        + Hdr  : ISO20022.Casr001001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(FndsTrfAmt),validElement(TtlSttlmAmt),validElement(OthrSttlmTtls),validElement(IssrSttlmTtls),validElement(AcqrrSttlmTtls),validPattern("""MsgRsn""",MsgRsn,"""[0-9]{4,4}"""),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(OthrInstn),validElement(FI),validElement(Dstn),validElement(Rcvr),validElement(Sndr),validElement(Orgtr),validElement(SttlmInstn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Casr001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SttlmRptgInitn|ISO20022.Casr001001.SettlementReportingInitiationV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmRptgInitn))|

---

## AspectImpl ISO20022.Casr001001.SettlementReportingInitiationV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Casr001001.Document||||
|+|SctyTrlr|ISO20022.Casr001001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Casr001001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Casr001001.ProtectedData2>||XmlElement()||
|+|AddtlData|List<ISO20022.Casr001001.AdditionalData2>||XmlElement()||
|+|TxDesc|String||XmlElement()||
|+|Rcncltn|ISO20022.Casr001001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Casr001001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Casr001001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Casr001001.Jurisdiction2||XmlElement()||
|+|FndsTrfAmt|ISO20022.Casr001001.Amount17||XmlElement()||
|+|TtlSttlmAmt|ISO20022.Casr001001.SettlementCategoryTotal2||XmlElement()||
|+|OthrSttlmTtls|ISO20022.Casr001001.SettlementCategoryTotal3||XmlElement()||
|+|IssrSttlmTtls|ISO20022.Casr001001.SettlementCategoryTotal3||XmlElement()||
|+|AcqrrSttlmTtls|ISO20022.Casr001001.SettlementCategoryTotal3||XmlElement()||
|+|AltrnMsgRsn|List<String>||XmlElement()||
|+|MsgRsn|List<String>||XmlElement()||
|+|OthrSttlmRptTp|String||XmlElement()||
|+|SttlmRptTp|String||XmlElement()||
|+|LifeCyclId|String||XmlElement()||
|+|RtrvlRefNb|String||XmlElement()||
|+|TrnsmssnDtTm|DateTime||XmlElement()||
|+|SysTracAudtNb|String||XmlElement()||
|+|Prgrmm|List<ISO20022.Casr001001.ProgrammeMode5>||XmlElement()||
|+|OthrInstn|ISO20022.Casr001001.PartyIdentification285||XmlElement()||
|+|FI|ISO20022.Casr001001.FinancialInstitution9||XmlElement()||
|+|Dstn|ISO20022.Casr001001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Casr001001.PartyIdentification286||XmlElement()||
|+|Sndr|ISO20022.Casr001001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Casr001001.PartyIdentification286||XmlElement()||
|+|SttlmInstn|ISO20022.Casr001001.PartyIdentification286||XmlElement()||
|+|Hdr|ISO20022.Casr001001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(FndsTrfAmt),validElement(TtlSttlmAmt),validElement(OthrSttlmTtls),validElement(IssrSttlmTtls),validElement(AcqrrSttlmTtls),validPattern("""MsgRsn""",MsgRsn,"""[0-9]{4,4}"""),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(OthrInstn),validElement(FI),validElement(Dstn),validElement(Rcvr),validElement(Sndr),validElement(Orgtr),validElement(SttlmInstn),validElement(Hdr))|

