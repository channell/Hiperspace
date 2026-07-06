# cain.019.001.03-physical
```mermaid
classDiagram
    class ISO20022.Cain019001.Document {
        # Uri  : String
        + VrfctnRspn () : ISO20022.Cain019001.VerificationResponseV03
        + Validation () = validation(validElement(VrfctnRspn))
    }
    class ISO20022.Cain019001.VerificationResponseV03 {
        # owner  : ISO20022.Cain019001.Document
        + SctyTrlr  : ISO20022.Cain019001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Cain019001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Cain019001.ProtectedData2~
        + StrngCstmrAuthntcn  : ISO20022.Cain019001.StrongCustomerAuthentication2
        + AddtlData  : List~ISO20022.Cain019001.AdditionalData2~
        + PrcgRslt  : ISO20022.Cain019001.ProcessingResult22
        + OrgnlRspnCd  : String
        + Rcncltn  : ISO20022.Cain019001.Reconciliation4
        + AddtlFee  : List~ISO20022.Cain019001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Cain019001.SettlementService6
        + Jursdctn  : ISO20022.Cain019001.Jurisdiction2
        + AcctBal  : List~ISO20022.Cain019001.AccountBalance3~
        + AddtlSvc  : List~ISO20022.Cain019001.AdditionalService2~
        + Instlmt  : ISO20022.Cain019001.Instalment6
        + SpclPrgrmmQlfctn  : List~ISO20022.Cain019001.SpecialProgrammeQualification2~
        + Rsk  : List~ISO20022.Cain019001.RiskContext3~
        + Vrfctn  : List~ISO20022.Cain019001.Verification7~
        + Crdhldr  : ISO20022.Cain019001.Cardholder22
        + Wllt  : ISO20022.Cain019001.Wallet3
        + Tkn  : ISO20022.Cain019001.Token3
        + ICCRltdData  : String
        + Cntxt  : ISO20022.Cain019001.Context20
        + Termnl  : ISO20022.Cain019001.Terminal8
        + Accptr  : ISO20022.Cain019001.PartyIdentification285
        + AddtlAmt  : List~ISO20022.Cain019001.AdditionalAmounts4~
        + TxAmts  : ISO20022.Cain019001.TransactionAmounts4
        + ConvsDtTm  : ISO20022.Cain019001.DateTime2
        + TxId  : ISO20022.Cain019001.TransactionIdentification54
        + Prgrmm  : List~ISO20022.Cain019001.ProgrammeMode5~
        + Dstn  : ISO20022.Cain019001.PartyIdentification286
        + Issr  : ISO20022.Cain019001.PartyIdentification286
        + Rcvr  : ISO20022.Cain019001.PartyIdentification286
        + AcctTo  : ISO20022.Cain019001.AccountDetails4
        + AcctFr  : ISO20022.Cain019001.AccountDetails4
        + Card  : ISO20022.Cain019001.CardData12
        + Sndr  : ISO20022.Cain019001.PartyIdentification286
        + Acqrr  : ISO20022.Cain019001.PartyIdentification286
        + Orgtr  : ISO20022.Cain019001.PartyIdentification286
        + TxChrtcs  : ISO20022.Cain019001.TransactionCharacteristics1
        + Hdr  : ISO20022.Cain019001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validElement(StrngCstmrAuthntcn),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""AcctBal""",AcctBal),validElement(AcctBal),validList("""AddtlSvc""",AddtlSvc),validElement(AddtlSvc),validElement(Instlmt),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validList("""Rsk""",Rsk),validElement(Rsk),validList("""Vrfctn""",Vrfctn),validElement(Vrfctn),validElement(Crdhldr),validElement(Wllt),validElement(Tkn),validPattern("""ICCRltdData""",ICCRltdData,"""([0-9A-F][0-9A-F]){1,10000}  """),validElement(Cntxt),validElement(Termnl),validElement(Accptr),validList("""AddtlAmt""",AddtlAmt),validElement(AddtlAmt),validElement(TxAmts),validElement(ConvsDtTm),validElement(TxId),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(AcctTo),validElement(AcctFr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Cain019001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|VrfctnRspn|ISO20022.Cain019001.VerificationResponseV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VrfctnRspn))|

---

## AspectImpl ISO20022.Cain019001.VerificationResponseV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Cain019001.Document||||
|+|SctyTrlr|ISO20022.Cain019001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Cain019001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Cain019001.ProtectedData2>||XmlElement()||
|+|StrngCstmrAuthntcn|ISO20022.Cain019001.StrongCustomerAuthentication2||XmlElement()||
|+|AddtlData|List<ISO20022.Cain019001.AdditionalData2>||XmlElement()||
|+|PrcgRslt|ISO20022.Cain019001.ProcessingResult22||XmlElement()||
|+|OrgnlRspnCd|String||XmlElement()||
|+|Rcncltn|ISO20022.Cain019001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Cain019001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Cain019001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Cain019001.Jurisdiction2||XmlElement()||
|+|AcctBal|List<ISO20022.Cain019001.AccountBalance3>||XmlElement()||
|+|AddtlSvc|List<ISO20022.Cain019001.AdditionalService2>||XmlElement()||
|+|Instlmt|ISO20022.Cain019001.Instalment6||XmlElement()||
|+|SpclPrgrmmQlfctn|List<ISO20022.Cain019001.SpecialProgrammeQualification2>||XmlElement()||
|+|Rsk|List<ISO20022.Cain019001.RiskContext3>||XmlElement()||
|+|Vrfctn|List<ISO20022.Cain019001.Verification7>||XmlElement()||
|+|Crdhldr|ISO20022.Cain019001.Cardholder22||XmlElement()||
|+|Wllt|ISO20022.Cain019001.Wallet3||XmlElement()||
|+|Tkn|ISO20022.Cain019001.Token3||XmlElement()||
|+|ICCRltdData|String||XmlElement()||
|+|Cntxt|ISO20022.Cain019001.Context20||XmlElement()||
|+|Termnl|ISO20022.Cain019001.Terminal8||XmlElement()||
|+|Accptr|ISO20022.Cain019001.PartyIdentification285||XmlElement()||
|+|AddtlAmt|List<ISO20022.Cain019001.AdditionalAmounts4>||XmlElement()||
|+|TxAmts|ISO20022.Cain019001.TransactionAmounts4||XmlElement()||
|+|ConvsDtTm|ISO20022.Cain019001.DateTime2||XmlElement()||
|+|TxId|ISO20022.Cain019001.TransactionIdentification54||XmlElement()||
|+|Prgrmm|List<ISO20022.Cain019001.ProgrammeMode5>||XmlElement()||
|+|Dstn|ISO20022.Cain019001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Cain019001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cain019001.PartyIdentification286||XmlElement()||
|+|AcctTo|ISO20022.Cain019001.AccountDetails4||XmlElement()||
|+|AcctFr|ISO20022.Cain019001.AccountDetails4||XmlElement()||
|+|Card|ISO20022.Cain019001.CardData12||XmlElement()||
|+|Sndr|ISO20022.Cain019001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Cain019001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cain019001.PartyIdentification286||XmlElement()||
|+|TxChrtcs|ISO20022.Cain019001.TransactionCharacteristics1||XmlElement()||
|+|Hdr|ISO20022.Cain019001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validElement(StrngCstmrAuthntcn),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""AcctBal""",AcctBal),validElement(AcctBal),validList("""AddtlSvc""",AddtlSvc),validElement(AddtlSvc),validElement(Instlmt),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validList("""Rsk""",Rsk),validElement(Rsk),validList("""Vrfctn""",Vrfctn),validElement(Vrfctn),validElement(Crdhldr),validElement(Wllt),validElement(Tkn),validPattern("""ICCRltdData""",ICCRltdData,"""([0-9A-F][0-9A-F]){1,10000}  """),validElement(Cntxt),validElement(Termnl),validElement(Accptr),validList("""AddtlAmt""",AddtlAmt),validElement(AddtlAmt),validElement(TxAmts),validElement(ConvsDtTm),validElement(TxId),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(AcctTo),validElement(AcctFr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs),validElement(Hdr))|

