# cain.003.001.04-physical
```mermaid
classDiagram
    class ISO20022.Cain003001.Document {
        # Uri  : String
        + FinInitn () : ISO20022.Cain003001.FinancialInitiationV04
        + Validation () = validation(validElement(FinInitn))
    }
    class ISO20022.Cain003001.FinancialInitiationV04 {
        # owner  : ISO20022.Cain003001.Document
        + SctyTrlr  : ISO20022.Cain003001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Cain003001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Cain003001.ProtectedData2~
        + StrngCstmrAuthntcn  : ISO20022.Cain003001.StrongCustomerAuthentication2
        + AddtlData  : List~ISO20022.Cain003001.AdditionalData2~
        + AdddmData  : ISO20022.Cain003001.AddendumData6
        + OrgnlTx  : ISO20022.Cain003001.OriginalTransaction3
        + PrcgRslt  : ISO20022.Cain003001.ProcessingResult27
        + Dcmnttn  : List~ISO20022.Cain003001.DisputeDocumentation1~
        + DsptData  : List~ISO20022.Cain003001.DisputeData4~
        + Rcncltn  : ISO20022.Cain003001.Reconciliation4
        + AddtlFee  : List~ISO20022.Cain003001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Cain003001.SettlementService5
        + Jursdctn  : ISO20022.Cain003001.Jurisdiction2
        + DpstDtls  : List~ISO20022.Cain003001.DepositDetails3~
        + FndsSvcs  : ISO20022.Cain003001.FundingService3
        + AddtlSvc  : List~ISO20022.Cain003001.AdditionalService2~
        + AcctBal  : List~ISO20022.Cain003001.AccountBalance3~
        + Instlmt  : ISO20022.Cain003001.Instalment6
        + SpclPrgrmmQlfctn  : List~ISO20022.Cain003001.SpecialProgrammeQualification2~
        + Rsk  : List~ISO20022.Cain003001.RiskContext3~
        + Vrfctn  : List~ISO20022.Cain003001.Verification6~
        + Cstmr  : ISO20022.Cain003001.Customer4
        + Crdhldr  : ISO20022.Cain003001.Cardholder22
        + Wllt  : ISO20022.Cain003001.Wallet3
        + CstmrDvc  : ISO20022.Cain003001.CustomerDevice5
        + Tkn  : ISO20022.Cain003001.Token2
        + Pyee  : ISO20022.Cain003001.PartyIdentification287
        + Pyer  : ISO20022.Cain003001.PartyIdentification287
        + ICCRltdData  : String
        + Cntxt  : ISO20022.Cain003001.Context19
        + POICmpnt  : List~ISO20022.Cain003001.PointOfInteractionComponent16~
        + Termnl  : ISO20022.Cain003001.Terminal7
        + Accptr  : ISO20022.Cain003001.PartyIdentification288
        + OrgnlDataElmts  : ISO20022.Cain003001.OriginalDataElements3
        + AddtlAmt  : List~ISO20022.Cain003001.AdditionalAmounts4~
        + TxAmts  : ISO20022.Cain003001.TransactionAmounts3
        + XchgRate  : List~ISO20022.Cain003001.ExchangeRateInformation5~
        + ConvsDtTm  : ISO20022.Cain003001.DateTime2
        + TxId  : ISO20022.Cain003001.TransactionIdentification55
        + Prgrmm  : ISO20022.Cain003001.ProgrammeMode4
        + Dstn  : ISO20022.Cain003001.PartyIdentification286
        + Issr  : ISO20022.Cain003001.PartyIdentification286
        + Rcvr  : ISO20022.Cain003001.PartyIdentification286
        + AcctTo  : ISO20022.Cain003001.AccountDetails4
        + AcctFr  : ISO20022.Cain003001.AccountDetails4
        + Card  : ISO20022.Cain003001.CardData11
        + Sndr  : ISO20022.Cain003001.PartyIdentification286
        + Acqrr  : ISO20022.Cain003001.PartyIdentification286
        + Orgtr  : ISO20022.Cain003001.PartyIdentification286
        + TxChrtcs  : ISO20022.Cain003001.TransactionCharacteristics1
        + Hdr  : ISO20022.Cain003001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validElement(StrngCstmrAuthntcn),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(AdddmData),validElement(OrgnlTx),validElement(PrcgRslt),validList("""Dcmnttn""",Dcmnttn),validElement(Dcmnttn),validList("""DsptData""",DsptData),validElement(DsptData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""DpstDtls""",DpstDtls),validElement(DpstDtls),validElement(FndsSvcs),validList("""AddtlSvc""",AddtlSvc),validElement(AddtlSvc),validList("""AcctBal""",AcctBal),validElement(AcctBal),validElement(Instlmt),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validList("""Rsk""",Rsk),validElement(Rsk),validList("""Vrfctn""",Vrfctn),validElement(Vrfctn),validElement(Cstmr),validElement(Crdhldr),validElement(Wllt),validElement(CstmrDvc),validElement(Tkn),validElement(Pyee),validElement(Pyer),validPattern("""ICCRltdData""",ICCRltdData,"""([0-9A-F][0-9A-F]){1,10000}  """),validElement(Cntxt),validList("""POICmpnt""",POICmpnt),validElement(POICmpnt),validElement(Termnl),validElement(Accptr),validElement(OrgnlDataElmts),validList("""AddtlAmt""",AddtlAmt),validElement(AddtlAmt),validElement(TxAmts),validList("""XchgRate""",XchgRate),validElement(XchgRate),validElement(ConvsDtTm),validElement(TxId),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(AcctTo),validElement(AcctFr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Cain003001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|FinInitn|ISO20022.Cain003001.FinancialInitiationV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInitn))|

---

## AspectImpl ISO20022.Cain003001.FinancialInitiationV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Cain003001.Document||||
|+|SctyTrlr|ISO20022.Cain003001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Cain003001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Cain003001.ProtectedData2>||XmlElement()||
|+|StrngCstmrAuthntcn|ISO20022.Cain003001.StrongCustomerAuthentication2||XmlElement()||
|+|AddtlData|List<ISO20022.Cain003001.AdditionalData2>||XmlElement()||
|+|AdddmData|ISO20022.Cain003001.AddendumData6||XmlElement()||
|+|OrgnlTx|ISO20022.Cain003001.OriginalTransaction3||XmlElement()||
|+|PrcgRslt|ISO20022.Cain003001.ProcessingResult27||XmlElement()||
|+|Dcmnttn|List<ISO20022.Cain003001.DisputeDocumentation1>||XmlElement()||
|+|DsptData|List<ISO20022.Cain003001.DisputeData4>||XmlElement()||
|+|Rcncltn|ISO20022.Cain003001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Cain003001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Cain003001.SettlementService5||XmlElement()||
|+|Jursdctn|ISO20022.Cain003001.Jurisdiction2||XmlElement()||
|+|DpstDtls|List<ISO20022.Cain003001.DepositDetails3>||XmlElement()||
|+|FndsSvcs|ISO20022.Cain003001.FundingService3||XmlElement()||
|+|AddtlSvc|List<ISO20022.Cain003001.AdditionalService2>||XmlElement()||
|+|AcctBal|List<ISO20022.Cain003001.AccountBalance3>||XmlElement()||
|+|Instlmt|ISO20022.Cain003001.Instalment6||XmlElement()||
|+|SpclPrgrmmQlfctn|List<ISO20022.Cain003001.SpecialProgrammeQualification2>||XmlElement()||
|+|Rsk|List<ISO20022.Cain003001.RiskContext3>||XmlElement()||
|+|Vrfctn|List<ISO20022.Cain003001.Verification6>||XmlElement()||
|+|Cstmr|ISO20022.Cain003001.Customer4||XmlElement()||
|+|Crdhldr|ISO20022.Cain003001.Cardholder22||XmlElement()||
|+|Wllt|ISO20022.Cain003001.Wallet3||XmlElement()||
|+|CstmrDvc|ISO20022.Cain003001.CustomerDevice5||XmlElement()||
|+|Tkn|ISO20022.Cain003001.Token2||XmlElement()||
|+|Pyee|ISO20022.Cain003001.PartyIdentification287||XmlElement()||
|+|Pyer|ISO20022.Cain003001.PartyIdentification287||XmlElement()||
|+|ICCRltdData|String||XmlElement()||
|+|Cntxt|ISO20022.Cain003001.Context19||XmlElement()||
|+|POICmpnt|List<ISO20022.Cain003001.PointOfInteractionComponent16>||XmlElement()||
|+|Termnl|ISO20022.Cain003001.Terminal7||XmlElement()||
|+|Accptr|ISO20022.Cain003001.PartyIdentification288||XmlElement()||
|+|OrgnlDataElmts|ISO20022.Cain003001.OriginalDataElements3||XmlElement()||
|+|AddtlAmt|List<ISO20022.Cain003001.AdditionalAmounts4>||XmlElement()||
|+|TxAmts|ISO20022.Cain003001.TransactionAmounts3||XmlElement()||
|+|XchgRate|List<ISO20022.Cain003001.ExchangeRateInformation5>||XmlElement()||
|+|ConvsDtTm|ISO20022.Cain003001.DateTime2||XmlElement()||
|+|TxId|ISO20022.Cain003001.TransactionIdentification55||XmlElement()||
|+|Prgrmm|ISO20022.Cain003001.ProgrammeMode4||XmlElement()||
|+|Dstn|ISO20022.Cain003001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Cain003001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cain003001.PartyIdentification286||XmlElement()||
|+|AcctTo|ISO20022.Cain003001.AccountDetails4||XmlElement()||
|+|AcctFr|ISO20022.Cain003001.AccountDetails4||XmlElement()||
|+|Card|ISO20022.Cain003001.CardData11||XmlElement()||
|+|Sndr|ISO20022.Cain003001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Cain003001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cain003001.PartyIdentification286||XmlElement()||
|+|TxChrtcs|ISO20022.Cain003001.TransactionCharacteristics1||XmlElement()||
|+|Hdr|ISO20022.Cain003001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validElement(StrngCstmrAuthntcn),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(AdddmData),validElement(OrgnlTx),validElement(PrcgRslt),validList("""Dcmnttn""",Dcmnttn),validElement(Dcmnttn),validList("""DsptData""",DsptData),validElement(DsptData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""DpstDtls""",DpstDtls),validElement(DpstDtls),validElement(FndsSvcs),validList("""AddtlSvc""",AddtlSvc),validElement(AddtlSvc),validList("""AcctBal""",AcctBal),validElement(AcctBal),validElement(Instlmt),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validList("""Rsk""",Rsk),validElement(Rsk),validList("""Vrfctn""",Vrfctn),validElement(Vrfctn),validElement(Cstmr),validElement(Crdhldr),validElement(Wllt),validElement(CstmrDvc),validElement(Tkn),validElement(Pyee),validElement(Pyer),validPattern("""ICCRltdData""",ICCRltdData,"""([0-9A-F][0-9A-F]){1,10000}  """),validElement(Cntxt),validList("""POICmpnt""",POICmpnt),validElement(POICmpnt),validElement(Termnl),validElement(Accptr),validElement(OrgnlDataElmts),validList("""AddtlAmt""",AddtlAmt),validElement(AddtlAmt),validElement(TxAmts),validList("""XchgRate""",XchgRate),validElement(XchgRate),validElement(ConvsDtTm),validElement(TxId),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(AcctTo),validElement(AcctFr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs),validElement(Hdr))|

