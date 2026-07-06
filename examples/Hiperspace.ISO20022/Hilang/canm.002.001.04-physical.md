# canm.002.001.04-physical
```mermaid
classDiagram
    class ISO20022.Canm002001.Document {
        # Uri  : String
        + NtwkMgmtRspn () : ISO20022.Canm002001.NetworkManagementResponseV04
        + Validation () = validation(validElement(NtwkMgmtRspn))
    }
    class ISO20022.Canm002001.NetworkManagementResponseV04 {
        # owner  : ISO20022.Canm002001.Document
        + SctyTrlr  : ISO20022.Canm002001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Canm002001.SupplementaryData1~
        + OrgnlRspnCd  : String
        + PrcgRslt  : ISO20022.Canm002001.ProcessingResult23
        + AddtlData  : List~ISO20022.Canm002001.AdditionalData2~
        + TxDesc  : String
        + Rcncltn  : ISO20022.Canm002001.Reconciliation4
        + AddtlFee  : List~ISO20022.Canm002001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Canm002001.SettlementService6
        + Jursdctn  : ISO20022.Canm002001.Jurisdiction2
        + LifeCyclId  : String
        + RtrvlRefNb  : String
        + TrnsmssnDtTm  : DateTime
        + SysTracAudtNb  : String
        + MaxNbOfMsgs  : Decimal
        + NbOfMsgs  : Decimal
        + Prgrmm  : ISO20022.Canm002001.ProgrammeMode5
        + AltrnMsgRsn  : List~String~
        + MsgRsn  : List~String~
        + OthrNtwkMgmtTp  : String
        + NtwkMgmtTp  : String
        + Hdr  : ISO20022.Canm002001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(PrcgRslt),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validElement(Prgrmm),validPattern("""MsgRsn""",MsgRsn,"""[0-9]{4,4}"""),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Canm002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|NtwkMgmtRspn|ISO20022.Canm002001.NetworkManagementResponseV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NtwkMgmtRspn))|

---

## AspectImpl ISO20022.Canm002001.NetworkManagementResponseV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Canm002001.Document||||
|+|SctyTrlr|ISO20022.Canm002001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Canm002001.SupplementaryData1>||XmlElement()||
|+|OrgnlRspnCd|String||XmlElement()||
|+|PrcgRslt|ISO20022.Canm002001.ProcessingResult23||XmlElement()||
|+|AddtlData|List<ISO20022.Canm002001.AdditionalData2>||XmlElement()||
|+|TxDesc|String||XmlElement()||
|+|Rcncltn|ISO20022.Canm002001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Canm002001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Canm002001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Canm002001.Jurisdiction2||XmlElement()||
|+|LifeCyclId|String||XmlElement()||
|+|RtrvlRefNb|String||XmlElement()||
|+|TrnsmssnDtTm|DateTime||XmlElement()||
|+|SysTracAudtNb|String||XmlElement()||
|+|MaxNbOfMsgs|Decimal||XmlElement()||
|+|NbOfMsgs|Decimal||XmlElement()||
|+|Prgrmm|ISO20022.Canm002001.ProgrammeMode5||XmlElement()||
|+|AltrnMsgRsn|List<String>||XmlElement()||
|+|MsgRsn|List<String>||XmlElement()||
|+|OthrNtwkMgmtTp|String||XmlElement()||
|+|NtwkMgmtTp|String||XmlElement()||
|+|Hdr|ISO20022.Canm002001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(PrcgRslt),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validElement(Prgrmm),validPattern("""MsgRsn""",MsgRsn,"""[0-9]{4,4}"""),validElement(Hdr))|

