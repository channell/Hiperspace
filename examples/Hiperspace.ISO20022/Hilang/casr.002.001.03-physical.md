# casr.002.001.03-physical
```mermaid
classDiagram
    class ISO20022.Casr002001.Document {
        # Uri  : String
        + SttlmRptgRspn () : ISO20022.Casr002001.SettlementReportingResponseV03
        + Validation () = validation(validElement(SttlmRptgRspn))
    }
    class ISO20022.Casr002001.SettlementReportingResponseV03 {
        # owner  : ISO20022.Casr002001.Document
        + SctyTrlr  : ISO20022.Casr002001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Casr002001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Casr002001.ProtectedData2~
        + AddtlData  : List~ISO20022.Casr002001.AdditionalData2~
        + PrcgRslt  : ISO20022.Casr002001.ProcessingResult23
        + OrgnlRspnCd  : String
        + TxDesc  : String
        + Rcncltn  : ISO20022.Casr002001.Reconciliation4
        + AddtlFee  : List~ISO20022.Casr002001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Casr002001.SettlementService6
        + Jursdctn  : ISO20022.Casr002001.Jurisdiction2
        + LifeCyclId  : String
        + RtrvlRefNb  : String
        + TrnsmssnDtTm  : DateTime
        + SysTracAudtNb  : String
        + Prgrmm  : List~ISO20022.Casr002001.ProgrammeMode5~
        + OthrInstn  : ISO20022.Casr002001.PartyIdentification285
        + FI  : ISO20022.Casr002001.FinancialInstitution9
        + Dstn  : ISO20022.Casr002001.PartyIdentification286
        + Rcvr  : ISO20022.Casr002001.PartyIdentification286
        + Sndr  : ISO20022.Casr002001.PartyIdentification286
        + Orgtr  : ISO20022.Casr002001.PartyIdentification286
        + SttlmInstn  : ISO20022.Casr002001.PartyIdentification286
        + Hdr  : ISO20022.Casr002001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(OthrInstn),validElement(FI),validElement(Dstn),validElement(Rcvr),validElement(Sndr),validElement(Orgtr),validElement(SttlmInstn),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Casr002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|SttlmRptgRspn|ISO20022.Casr002001.SettlementReportingResponseV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmRptgRspn))|

---

## AspectImpl ISO20022.Casr002001.SettlementReportingResponseV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Casr002001.Document||||
|+|SctyTrlr|ISO20022.Casr002001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Casr002001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Casr002001.ProtectedData2>||XmlElement()||
|+|AddtlData|List<ISO20022.Casr002001.AdditionalData2>||XmlElement()||
|+|PrcgRslt|ISO20022.Casr002001.ProcessingResult23||XmlElement()||
|+|OrgnlRspnCd|String||XmlElement()||
|+|TxDesc|String||XmlElement()||
|+|Rcncltn|ISO20022.Casr002001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Casr002001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Casr002001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Casr002001.Jurisdiction2||XmlElement()||
|+|LifeCyclId|String||XmlElement()||
|+|RtrvlRefNb|String||XmlElement()||
|+|TrnsmssnDtTm|DateTime||XmlElement()||
|+|SysTracAudtNb|String||XmlElement()||
|+|Prgrmm|List<ISO20022.Casr002001.ProgrammeMode5>||XmlElement()||
|+|OthrInstn|ISO20022.Casr002001.PartyIdentification285||XmlElement()||
|+|FI|ISO20022.Casr002001.FinancialInstitution9||XmlElement()||
|+|Dstn|ISO20022.Casr002001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Casr002001.PartyIdentification286||XmlElement()||
|+|Sndr|ISO20022.Casr002001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Casr002001.PartyIdentification286||XmlElement()||
|+|SttlmInstn|ISO20022.Casr002001.PartyIdentification286||XmlElement()||
|+|Hdr|ISO20022.Casr002001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(OthrInstn),validElement(FI),validElement(Dstn),validElement(Rcvr),validElement(Sndr),validElement(Orgtr),validElement(SttlmInstn),validElement(Hdr))|

