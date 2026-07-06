# canm.004.001.04-physical
```mermaid
classDiagram
    class ISO20022.Canm004001.Document {
        # Uri  : String
        + KeyXchgRspn () : ISO20022.Canm004001.KeyExchangeResponseV04
        + Validation () = validation(validElement(KeyXchgRspn))
    }
    class ISO20022.Canm004001.KeyExchangeResponseV04 {
        # owner  : ISO20022.Canm004001.Document
        + SctyTrlr  : ISO20022.Canm004001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Canm004001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Canm004001.ProtectedData2~
        + PrcgRslt  : ISO20022.Canm004001.ProcessingResult23
        + OrgnlRspnCd  : String
        + AddtlData  : List~ISO20022.Canm004001.AdditionalData2~
        + Rcncltn  : ISO20022.Canm004001.Reconciliation4
        + AddtlFee  : List~ISO20022.Canm004001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Canm004001.SettlementService6
        + Jursdctn  : ISO20022.Canm004001.Jurisdiction2
        + KeyXchgData  : ISO20022.Canm004001.KeyExchangeData1
        + OthrKeyXchgTp  : String
        + KeyXchgTp  : String
        + LifeCyclId  : String
        + RtrvlRefNb  : String
        + TrnsmssnDtTm  : DateTime
        + SysTracAudtNb  : String
        + Prgrmm  : ISO20022.Canm004001.ProgrammeMode5
        + AltrnMsgRsn  : List~String~
        + MsgRsn  : List~String~
        + OthrKeyXchgFctn  : String
        + KeyXchgFctn  : String
        + Hdr  : ISO20022.Canm004001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validElement(PrcgRslt),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(KeyXchgData),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validElement(Prgrmm),validPattern("""MsgRsn""",MsgRsn,"""[0-9]{4,4}"""),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Canm004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|KeyXchgRspn|ISO20022.Canm004001.KeyExchangeResponseV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KeyXchgRspn))|

---

## AspectImpl ISO20022.Canm004001.KeyExchangeResponseV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Canm004001.Document||||
|+|SctyTrlr|ISO20022.Canm004001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Canm004001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Canm004001.ProtectedData2>||XmlElement()||
|+|PrcgRslt|ISO20022.Canm004001.ProcessingResult23||XmlElement()||
|+|OrgnlRspnCd|String||XmlElement()||
|+|AddtlData|List<ISO20022.Canm004001.AdditionalData2>||XmlElement()||
|+|Rcncltn|ISO20022.Canm004001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Canm004001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Canm004001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Canm004001.Jurisdiction2||XmlElement()||
|+|KeyXchgData|ISO20022.Canm004001.KeyExchangeData1||XmlElement()||
|+|OthrKeyXchgTp|String||XmlElement()||
|+|KeyXchgTp|String||XmlElement()||
|+|LifeCyclId|String||XmlElement()||
|+|RtrvlRefNb|String||XmlElement()||
|+|TrnsmssnDtTm|DateTime||XmlElement()||
|+|SysTracAudtNb|String||XmlElement()||
|+|Prgrmm|ISO20022.Canm004001.ProgrammeMode5||XmlElement()||
|+|AltrnMsgRsn|List<String>||XmlElement()||
|+|MsgRsn|List<String>||XmlElement()||
|+|OthrKeyXchgFctn|String||XmlElement()||
|+|KeyXchgFctn|String||XmlElement()||
|+|Hdr|ISO20022.Canm004001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validElement(PrcgRslt),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(KeyXchgData),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validElement(Prgrmm),validPattern("""MsgRsn""",MsgRsn,"""[0-9]{4,4}"""),validElement(Hdr))|

