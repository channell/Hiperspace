# cain.018.001.03-physical
```mermaid
classDiagram
    class ISO20022.Cain018001.Document {
        # Uri  : String
        + VrfctnInitn () : ISO20022.Cain018001.VerificationInitiationV03
        + Validation () = validation(validElement(VrfctnInitn))
    }
    class ISO20022.Cain018001.VerificationInitiationV03 {
        # owner  : ISO20022.Cain018001.Document
        + SctyTrlr  : ISO20022.Cain018001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Cain018001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Cain018001.ProtectedData2~
        + StrngCstmrAuthntcn  : ISO20022.Cain018001.StrongCustomerAuthentication2
        + AddtlData  : List~ISO20022.Cain018001.AdditionalData2~
        + PrcgRslt  : ISO20022.Cain018001.ProcessingResult27
        + OrgnlRspnCd  : String
        + Rcncltn  : ISO20022.Cain018001.Reconciliation4
        + AddtlFee  : List~ISO20022.Cain018001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Cain018001.SettlementService5
        + Jursdctn  : ISO20022.Cain018001.Jurisdiction2
        + FndsSvcs  : ISO20022.Cain018001.FundingService3
        + AddtlSvc  : List~ISO20022.Cain018001.AdditionalService2~
        + Instlmt  : ISO20022.Cain018001.Instalment6
        + SpclPrgrmmQlfctn  : List~ISO20022.Cain018001.SpecialProgrammeQualification2~
        + Rsk  : List~ISO20022.Cain018001.RiskContext3~
        + Vrfctn  : List~ISO20022.Cain018001.Verification6~
        + Crdhldr  : ISO20022.Cain018001.Cardholder22
        + Wllt  : ISO20022.Cain018001.Wallet3
        + CstmrDvc  : ISO20022.Cain018001.CustomerDevice5
        + Tkn  : ISO20022.Cain018001.Token3
        + ICCRltdData  : String
        + Pyee  : ISO20022.Cain018001.PartyIdentification287
        + Pyer  : ISO20022.Cain018001.PartyIdentification287
        + Cntxt  : ISO20022.Cain018001.Context23
        + POICmpnt  : List~ISO20022.Cain018001.PointOfInteractionComponent16~
        + Termnl  : ISO20022.Cain018001.Terminal7
        + Accptr  : ISO20022.Cain018001.PartyIdentification288
        + AddtlAmt  : List~ISO20022.Cain018001.AdditionalAmounts4~
        + TxAmts  : ISO20022.Cain018001.TransactionAmounts4
        + XchgRate  : List~ISO20022.Cain018001.ExchangeRateInformation5~
        + ConvsDtTm  : ISO20022.Cain018001.DateTime2
        + TxId  : ISO20022.Cain018001.TransactionIdentification54
        + Prgrmm  : ISO20022.Cain018001.ProgrammeMode4
        + Dstn  : ISO20022.Cain018001.PartyIdentification286
        + Issr  : ISO20022.Cain018001.PartyIdentification286
        + Rcvr  : ISO20022.Cain018001.PartyIdentification286
        + AcctTo  : ISO20022.Cain018001.AccountDetails4
        + AcctFr  : ISO20022.Cain018001.AccountDetails4
        + Card  : ISO20022.Cain018001.CardData11
        + Sndr  : ISO20022.Cain018001.PartyIdentification286
        + Acqrr  : ISO20022.Cain018001.PartyIdentification286
        + Orgtr  : ISO20022.Cain018001.PartyIdentification286
        + TxChrtcs  : ISO20022.Cain018001.TransactionCharacteristics1
        + Hdr  : ISO20022.Cain018001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validElement(StrngCstmrAuthntcn),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(FndsSvcs),validList("""AddtlSvc""",AddtlSvc),validElement(AddtlSvc),validElement(Instlmt),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validList("""Rsk""",Rsk),validElement(Rsk),validList("""Vrfctn""",Vrfctn),validElement(Vrfctn),validElement(Crdhldr),validElement(Wllt),validElement(CstmrDvc),validElement(Tkn),validPattern("""ICCRltdData""",ICCRltdData,"""([0-9A-F][0-9A-F]){1,10000}  """),validElement(Pyee),validElement(Pyer),validElement(Cntxt),validList("""POICmpnt""",POICmpnt),validElement(POICmpnt),validElement(Termnl),validElement(Accptr),validList("""AddtlAmt""",AddtlAmt),validElement(AddtlAmt),validElement(TxAmts),validList("""XchgRate""",XchgRate),validElement(XchgRate),validElement(ConvsDtTm),validElement(TxId),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(AcctTo),validElement(AcctFr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Cain018001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|VrfctnInitn|ISO20022.Cain018001.VerificationInitiationV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VrfctnInitn))|

---

## AspectImpl ISO20022.Cain018001.VerificationInitiationV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Cain018001.Document||||
|+|SctyTrlr|ISO20022.Cain018001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Cain018001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Cain018001.ProtectedData2>||XmlElement()||
|+|StrngCstmrAuthntcn|ISO20022.Cain018001.StrongCustomerAuthentication2||XmlElement()||
|+|AddtlData|List<ISO20022.Cain018001.AdditionalData2>||XmlElement()||
|+|PrcgRslt|ISO20022.Cain018001.ProcessingResult27||XmlElement()||
|+|OrgnlRspnCd|String||XmlElement()||
|+|Rcncltn|ISO20022.Cain018001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Cain018001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Cain018001.SettlementService5||XmlElement()||
|+|Jursdctn|ISO20022.Cain018001.Jurisdiction2||XmlElement()||
|+|FndsSvcs|ISO20022.Cain018001.FundingService3||XmlElement()||
|+|AddtlSvc|List<ISO20022.Cain018001.AdditionalService2>||XmlElement()||
|+|Instlmt|ISO20022.Cain018001.Instalment6||XmlElement()||
|+|SpclPrgrmmQlfctn|List<ISO20022.Cain018001.SpecialProgrammeQualification2>||XmlElement()||
|+|Rsk|List<ISO20022.Cain018001.RiskContext3>||XmlElement()||
|+|Vrfctn|List<ISO20022.Cain018001.Verification6>||XmlElement()||
|+|Crdhldr|ISO20022.Cain018001.Cardholder22||XmlElement()||
|+|Wllt|ISO20022.Cain018001.Wallet3||XmlElement()||
|+|CstmrDvc|ISO20022.Cain018001.CustomerDevice5||XmlElement()||
|+|Tkn|ISO20022.Cain018001.Token3||XmlElement()||
|+|ICCRltdData|String||XmlElement()||
|+|Pyee|ISO20022.Cain018001.PartyIdentification287||XmlElement()||
|+|Pyer|ISO20022.Cain018001.PartyIdentification287||XmlElement()||
|+|Cntxt|ISO20022.Cain018001.Context23||XmlElement()||
|+|POICmpnt|List<ISO20022.Cain018001.PointOfInteractionComponent16>||XmlElement()||
|+|Termnl|ISO20022.Cain018001.Terminal7||XmlElement()||
|+|Accptr|ISO20022.Cain018001.PartyIdentification288||XmlElement()||
|+|AddtlAmt|List<ISO20022.Cain018001.AdditionalAmounts4>||XmlElement()||
|+|TxAmts|ISO20022.Cain018001.TransactionAmounts4||XmlElement()||
|+|XchgRate|List<ISO20022.Cain018001.ExchangeRateInformation5>||XmlElement()||
|+|ConvsDtTm|ISO20022.Cain018001.DateTime2||XmlElement()||
|+|TxId|ISO20022.Cain018001.TransactionIdentification54||XmlElement()||
|+|Prgrmm|ISO20022.Cain018001.ProgrammeMode4||XmlElement()||
|+|Dstn|ISO20022.Cain018001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Cain018001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cain018001.PartyIdentification286||XmlElement()||
|+|AcctTo|ISO20022.Cain018001.AccountDetails4||XmlElement()||
|+|AcctFr|ISO20022.Cain018001.AccountDetails4||XmlElement()||
|+|Card|ISO20022.Cain018001.CardData11||XmlElement()||
|+|Sndr|ISO20022.Cain018001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Cain018001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cain018001.PartyIdentification286||XmlElement()||
|+|TxChrtcs|ISO20022.Cain018001.TransactionCharacteristics1||XmlElement()||
|+|Hdr|ISO20022.Cain018001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validElement(StrngCstmrAuthntcn),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(FndsSvcs),validList("""AddtlSvc""",AddtlSvc),validElement(AddtlSvc),validElement(Instlmt),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validList("""Rsk""",Rsk),validElement(Rsk),validList("""Vrfctn""",Vrfctn),validElement(Vrfctn),validElement(Crdhldr),validElement(Wllt),validElement(CstmrDvc),validElement(Tkn),validPattern("""ICCRltdData""",ICCRltdData,"""([0-9A-F][0-9A-F]){1,10000}  """),validElement(Pyee),validElement(Pyer),validElement(Cntxt),validList("""POICmpnt""",POICmpnt),validElement(POICmpnt),validElement(Termnl),validElement(Accptr),validList("""AddtlAmt""",AddtlAmt),validElement(AddtlAmt),validElement(TxAmts),validList("""XchgRate""",XchgRate),validElement(XchgRate),validElement(ConvsDtTm),validElement(TxId),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(AcctTo),validElement(AcctFr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs),validElement(Hdr))|

