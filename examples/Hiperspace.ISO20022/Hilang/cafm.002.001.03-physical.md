# cafm.002.001.03-physical
```mermaid
classDiagram
    class ISO20022.Cafm002001.Document {
        # Uri  : String
        + FileActnRspn () : ISO20022.Cafm002001.FileActionResponseV03
        + Validation () = validation(validElement(FileActnRspn))
    }
    class ISO20022.Cafm002001.FileActionResponseV03 {
        # owner  : ISO20022.Cafm002001.Document
        + SctyTrlr  : ISO20022.Cafm002001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Cafm002001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Cafm002001.ProtectedData2~
        + RspnCd  : String
        + AddtlData  : List~ISO20022.Cafm002001.AdditionalData2~
        + Rcncltn  : ISO20022.Cafm002001.Reconciliation4
        + AddtlFee  : List~ISO20022.Cafm002001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Cafm002001.SettlementService6
        + Jursdctn  : ISO20022.Cafm002001.Jurisdiction2
        + Crdhldr  : ISO20022.Cafm002001.Cardholder22
        + Wllt  : ISO20022.Cafm002001.Wallet3
        + CstmrDvc  : ISO20022.Cafm002001.CustomerDevice5
        + Tkn  : ISO20022.Cafm002001.Token2
        + Pyee  : ISO20022.Cafm002001.PartyIdentification287
        + Pyer  : ISO20022.Cafm002001.PartyIdentification287
        + POICmpnt  : List~ISO20022.Cafm002001.PointOfInteractionComponent16~
        + Termnl  : ISO20022.Cafm002001.Terminal7
        + Accptr  : ISO20022.Cafm002001.PartyIdentification284
        + Crrctn  : ISO20022.Cafm002001.CorrectionIdentification1
        + FileSctyCd  : String
        + ActnDt  : DateTime
        + DataRcrd  : ISO20022.Cafm002001.DataRecord1Choice
        + Frmt  : String
        + FileNm  : String
        + LifeCyclId  : String
        + RtrvlRefNb  : String
        + TrnsmssnDtTm  : DateTime
        + SysTracAudtNb  : String
        + Prgrmm  : ISO20022.Cafm002001.ProgrammeMode5
        + Dstn  : ISO20022.Cafm002001.PartyIdentification286
        + Issr  : ISO20022.Cafm002001.PartyIdentification286
        + Rcvr  : ISO20022.Cafm002001.PartyIdentification286
        + Card  : ISO20022.Cafm002001.CardData15
        + Sndr  : ISO20022.Cafm002001.PartyIdentification286
        + Acqrr  : ISO20022.Cafm002001.PartyIdentification286
        + Orgtr  : ISO20022.Cafm002001.PartyIdentification286
        + Hdr  : ISO20022.Cafm002001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validPattern("""RspnCd""",RspnCd,"""[0-9A-Z]{2,2}"""),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(Crdhldr),validElement(Wllt),validElement(CstmrDvc),validElement(Tkn),validElement(Pyee),validElement(Pyer),validList("""POICmpnt""",POICmpnt),validElement(POICmpnt),validElement(Termnl),validElement(Accptr),validElement(Crrctn),validElement(DataRcrd),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Cafm002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|FileActnRspn|ISO20022.Cafm002001.FileActionResponseV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FileActnRspn))|

---

## AspectImpl ISO20022.Cafm002001.FileActionResponseV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Cafm002001.Document||||
|+|SctyTrlr|ISO20022.Cafm002001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Cafm002001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Cafm002001.ProtectedData2>||XmlElement()||
|+|RspnCd|String||XmlElement()||
|+|AddtlData|List<ISO20022.Cafm002001.AdditionalData2>||XmlElement()||
|+|Rcncltn|ISO20022.Cafm002001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Cafm002001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Cafm002001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Cafm002001.Jurisdiction2||XmlElement()||
|+|Crdhldr|ISO20022.Cafm002001.Cardholder22||XmlElement()||
|+|Wllt|ISO20022.Cafm002001.Wallet3||XmlElement()||
|+|CstmrDvc|ISO20022.Cafm002001.CustomerDevice5||XmlElement()||
|+|Tkn|ISO20022.Cafm002001.Token2||XmlElement()||
|+|Pyee|ISO20022.Cafm002001.PartyIdentification287||XmlElement()||
|+|Pyer|ISO20022.Cafm002001.PartyIdentification287||XmlElement()||
|+|POICmpnt|List<ISO20022.Cafm002001.PointOfInteractionComponent16>||XmlElement()||
|+|Termnl|ISO20022.Cafm002001.Terminal7||XmlElement()||
|+|Accptr|ISO20022.Cafm002001.PartyIdentification284||XmlElement()||
|+|Crrctn|ISO20022.Cafm002001.CorrectionIdentification1||XmlElement()||
|+|FileSctyCd|String||XmlElement()||
|+|ActnDt|DateTime||XmlElement()||
|+|DataRcrd|ISO20022.Cafm002001.DataRecord1Choice||XmlElement()||
|+|Frmt|String||XmlElement()||
|+|FileNm|String||XmlElement()||
|+|LifeCyclId|String||XmlElement()||
|+|RtrvlRefNb|String||XmlElement()||
|+|TrnsmssnDtTm|DateTime||XmlElement()||
|+|SysTracAudtNb|String||XmlElement()||
|+|Prgrmm|ISO20022.Cafm002001.ProgrammeMode5||XmlElement()||
|+|Dstn|ISO20022.Cafm002001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Cafm002001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cafm002001.PartyIdentification286||XmlElement()||
|+|Card|ISO20022.Cafm002001.CardData15||XmlElement()||
|+|Sndr|ISO20022.Cafm002001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Cafm002001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cafm002001.PartyIdentification286||XmlElement()||
|+|Hdr|ISO20022.Cafm002001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validPattern("""RspnCd""",RspnCd,"""[0-9A-Z]{2,2}"""),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(Crdhldr),validElement(Wllt),validElement(CstmrDvc),validElement(Tkn),validElement(Pyee),validElement(Pyer),validList("""POICmpnt""",POICmpnt),validElement(POICmpnt),validElement(Termnl),validElement(Accptr),validElement(Crrctn),validElement(DataRcrd),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(Hdr))|

