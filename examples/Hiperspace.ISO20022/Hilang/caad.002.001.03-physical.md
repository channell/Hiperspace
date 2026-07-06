# caad.002.001.03-physical
```mermaid
classDiagram
    class ISO20022.Caad002001.Document {
        # Uri  : String
        + BtchMgmtRspn () : ISO20022.Caad002001.BatchManagementResponseV03
        + Validation () = validation(validElement(BtchMgmtRspn))
    }
    class ISO20022.Caad002001.BatchManagementResponseV03 {
        # owner  : ISO20022.Caad002001.Document
        + SctyTrlr  : ISO20022.Caad002001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Caad002001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Caad002001.ProtectedData2~
        + AddtlData  : List~ISO20022.Caad002001.AdditionalData2~
        + PrcgRslt  : ISO20022.Caad002001.ProcessingResult23
        + OrgnlRspnCd  : String
        + Rcncltn  : ISO20022.Caad002001.Reconciliation4
        + AddtlFee  : List~ISO20022.Caad002001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Caad002001.SettlementService6
        + Jursdctn  : ISO20022.Caad002001.Jurisdiction2
        + Crrctn  : ISO20022.Caad002001.CorrectionIdentification1
        + LifeCyclId  : String
        + RtrvlRefNb  : String
        + TrnsmssnDtTm  : DateTime
        + SysTracAudtNb  : String
        + Prgrmm  : List~ISO20022.Caad002001.ProgrammeMode5~
        + Dstn  : ISO20022.Caad002001.PartyIdentification286
        + Rcvr  : ISO20022.Caad002001.PartyIdentification286
        + Sndr  : ISO20022.Caad002001.PartyIdentification286
        + Orgtr  : ISO20022.Caad002001.PartyIdentification286
        + Conttn  : String
        + PostvAck  : String
        + MsgsBfrAck  : Decimal
        + ReqAck  : String
        + BtchChcksm  : String
        + ColltnChcksm  : String
        + ChckptId  : String
        + BtchIdList  : List~String~
        + ColltnIdList  : List~String~
        + MsgSeqNb  : String
        + RmngMsgsInColltn  : Decimal
        + NbOfMsgs  : Decimal
        + NbOfBtchsInColltn  : Decimal
        + OrgnlBtchId  : String
        + OrgnlColltnId  : String
        + ColltnSz  : Decimal
        + BtchId  : String
        + ColltnId  : String
        + OthrBtchMgmtTp  : String
        + BtchMgmtTp  : String
        + Hdr  : ISO20022.Caad002001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(Crrctn),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Rcvr),validElement(Sndr),validElement(Orgtr),validPattern("""MsgSeqNb""",MsgSeqNb,"""[0-9]{1,15}"""),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caad002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|BtchMgmtRspn|ISO20022.Caad002001.BatchManagementResponseV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BtchMgmtRspn))|

---

## AspectImpl ISO20022.Caad002001.BatchManagementResponseV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caad002001.Document||||
|+|SctyTrlr|ISO20022.Caad002001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Caad002001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Caad002001.ProtectedData2>||XmlElement()||
|+|AddtlData|List<ISO20022.Caad002001.AdditionalData2>||XmlElement()||
|+|PrcgRslt|ISO20022.Caad002001.ProcessingResult23||XmlElement()||
|+|OrgnlRspnCd|String||XmlElement()||
|+|Rcncltn|ISO20022.Caad002001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Caad002001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Caad002001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Caad002001.Jurisdiction2||XmlElement()||
|+|Crrctn|ISO20022.Caad002001.CorrectionIdentification1||XmlElement()||
|+|LifeCyclId|String||XmlElement()||
|+|RtrvlRefNb|String||XmlElement()||
|+|TrnsmssnDtTm|DateTime||XmlElement()||
|+|SysTracAudtNb|String||XmlElement()||
|+|Prgrmm|List<ISO20022.Caad002001.ProgrammeMode5>||XmlElement()||
|+|Dstn|ISO20022.Caad002001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Caad002001.PartyIdentification286||XmlElement()||
|+|Sndr|ISO20022.Caad002001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Caad002001.PartyIdentification286||XmlElement()||
|+|Conttn|String||XmlElement()||
|+|PostvAck|String||XmlElement()||
|+|MsgsBfrAck|Decimal||XmlElement()||
|+|ReqAck|String||XmlElement()||
|+|BtchChcksm|String||XmlElement()||
|+|ColltnChcksm|String||XmlElement()||
|+|ChckptId|String||XmlElement()||
|+|BtchIdList|List<String>||XmlElement()||
|+|ColltnIdList|List<String>||XmlElement()||
|+|MsgSeqNb|String||XmlElement()||
|+|RmngMsgsInColltn|Decimal||XmlElement()||
|+|NbOfMsgs|Decimal||XmlElement()||
|+|NbOfBtchsInColltn|Decimal||XmlElement()||
|+|OrgnlBtchId|String||XmlElement()||
|+|OrgnlColltnId|String||XmlElement()||
|+|ColltnSz|Decimal||XmlElement()||
|+|BtchId|String||XmlElement()||
|+|ColltnId|String||XmlElement()||
|+|OthrBtchMgmtTp|String||XmlElement()||
|+|BtchMgmtTp|String||XmlElement()||
|+|Hdr|ISO20022.Caad002001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(Crrctn),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Rcvr),validElement(Sndr),validElement(Orgtr),validPattern("""MsgSeqNb""",MsgSeqNb,"""[0-9]{1,15}"""),validElement(Hdr))|

