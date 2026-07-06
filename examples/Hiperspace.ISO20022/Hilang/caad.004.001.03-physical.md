# caad.004.001.03-physical
```mermaid
classDiagram
    class ISO20022.Caad004001.Document {
        # Uri  : String
        + BtchTrfRspn () : ISO20022.Caad004001.BatchTransferResponseV03
        + Validation () = validation(validElement(BtchTrfRspn))
    }
    class ISO20022.Caad004001.BatchTransferResponseV03 {
        # owner  : ISO20022.Caad004001.Document
        + SctyTrlr  : ISO20022.Caad004001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Caad004001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Caad004001.ProtectedData2~
        + AddtlData  : List~ISO20022.Caad004001.AdditionalData2~
        + PrcgRslt  : ISO20022.Caad004001.ProcessingResult23
        + OrgnlRspnCd  : String
        + Rcncltn  : ISO20022.Caad004001.Reconciliation4
        + SttlmSvc  : ISO20022.Caad004001.SettlementService6
        + Jursdctn  : ISO20022.Caad004001.Jurisdiction2
        + Rcrd  : List~ISO20022.Caad004001.Record3~
        + AgtData  : List~ISO20022.Caad004001.AdditionalInformation21~
        + ClrCtrlTtls  : ISO20022.Caad004001.ClearingControlTotals3
        + ClrBtchData  : List~ISO20022.Caad004001.ClearingBatchData3~
        + LifeCyclId  : String
        + RtrvlRefNb  : String
        + TrnsmssnDtTm  : DateTime
        + SysTracAudtNb  : String
        + Prgrmm  : List~ISO20022.Caad004001.ProgrammeMode5~
        + Dstn  : ISO20022.Caad004001.PartyIdentification286
        + Orgtr  : ISO20022.Caad004001.PartyIdentification286
        + ReqAck  : String
        + BtchChcksm  : String
        + NbOfMsgs  : Decimal
        + OrgnlBtchId  : String
        + BtchId  : String
        + Hdr  : ISO20022.Caad004001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(Rcncltn),validElement(SttlmSvc),validElement(Jursdctn),validList("""Rcrd""",Rcrd),validElement(Rcrd),validList("""AgtData""",AgtData),validElement(AgtData),validElement(ClrCtrlTtls),validList("""ClrBtchData""",ClrBtchData),validElement(ClrBtchData),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Orgtr),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caad004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|BtchTrfRspn|ISO20022.Caad004001.BatchTransferResponseV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BtchTrfRspn))|

---

## AspectImpl ISO20022.Caad004001.BatchTransferResponseV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caad004001.Document||||
|+|SctyTrlr|ISO20022.Caad004001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Caad004001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Caad004001.ProtectedData2>||XmlElement()||
|+|AddtlData|List<ISO20022.Caad004001.AdditionalData2>||XmlElement()||
|+|PrcgRslt|ISO20022.Caad004001.ProcessingResult23||XmlElement()||
|+|OrgnlRspnCd|String||XmlElement()||
|+|Rcncltn|ISO20022.Caad004001.Reconciliation4||XmlElement()||
|+|SttlmSvc|ISO20022.Caad004001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Caad004001.Jurisdiction2||XmlElement()||
|+|Rcrd|List<ISO20022.Caad004001.Record3>||XmlElement()||
|+|AgtData|List<ISO20022.Caad004001.AdditionalInformation21>||XmlElement()||
|+|ClrCtrlTtls|ISO20022.Caad004001.ClearingControlTotals3||XmlElement()||
|+|ClrBtchData|List<ISO20022.Caad004001.ClearingBatchData3>||XmlElement()||
|+|LifeCyclId|String||XmlElement()||
|+|RtrvlRefNb|String||XmlElement()||
|+|TrnsmssnDtTm|DateTime||XmlElement()||
|+|SysTracAudtNb|String||XmlElement()||
|+|Prgrmm|List<ISO20022.Caad004001.ProgrammeMode5>||XmlElement()||
|+|Dstn|ISO20022.Caad004001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Caad004001.PartyIdentification286||XmlElement()||
|+|ReqAck|String||XmlElement()||
|+|BtchChcksm|String||XmlElement()||
|+|NbOfMsgs|Decimal||XmlElement()||
|+|OrgnlBtchId|String||XmlElement()||
|+|BtchId|String||XmlElement()||
|+|Hdr|ISO20022.Caad004001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(Rcncltn),validElement(SttlmSvc),validElement(Jursdctn),validList("""Rcrd""",Rcrd),validElement(Rcrd),validList("""AgtData""",AgtData),validElement(AgtData),validElement(ClrCtrlTtls),validList("""ClrBtchData""",ClrBtchData),validElement(ClrBtchData),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Orgtr),validElement(Hdr))|

