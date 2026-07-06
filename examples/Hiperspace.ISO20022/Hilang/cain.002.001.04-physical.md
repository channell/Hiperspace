# cain.002.001.04-physical
```mermaid
classDiagram
    class ISO20022.Cain002001.Document {
        # Uri  : String
        + AuthstnRspn () : ISO20022.Cain002001.AuthorisationResponseV04
        + Validation () = validation(validElement(AuthstnRspn))
    }
    class ISO20022.Cain002001.AuthorisationResponseV04 {
        # owner  : ISO20022.Cain002001.Document
        + SctyTrlr  : ISO20022.Cain002001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Cain002001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Cain002001.ProtectedData2~
        + StrngCstmrAuthntcn  : ISO20022.Cain002001.StrongCustomerAuthentication2
        + AddtlData  : List~ISO20022.Cain002001.AdditionalData2~
        + AdddmData  : ISO20022.Cain002001.AddendumData7
        + PrcgRslt  : ISO20022.Cain002001.ProcessingResult22
        + Rcncltn  : ISO20022.Cain002001.Reconciliation4
        + AddtlFee  : List~ISO20022.Cain002001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Cain002001.SettlementService6
        + Jursdctn  : ISO20022.Cain002001.Jurisdiction2
        + AcctBal  : List~ISO20022.Cain002001.AccountBalance3~
        + AddtlSvc  : List~ISO20022.Cain002001.AdditionalService2~
        + Instlmt  : ISO20022.Cain002001.Instalment6
        + SpclPrgrmmQlfctn  : List~ISO20022.Cain002001.SpecialProgrammeQualification2~
        + Rsk  : List~ISO20022.Cain002001.RiskContext3~
        + Vrfctn  : List~ISO20022.Cain002001.Verification7~
        + Crdhldr  : ISO20022.Cain002001.Cardholder22
        + Wllt  : ISO20022.Cain002001.Wallet3
        + Tkn  : ISO20022.Cain002001.Token2
        + ICCRltdData  : String
        + Cntxt  : ISO20022.Cain002001.Context20
        + Termnl  : ISO20022.Cain002001.Terminal8
        + Accptr  : ISO20022.Cain002001.PartyIdentification285
        + OrgnlDataElmts  : ISO20022.Cain002001.OriginalDataElements3
        + AddtlAmt  : List~ISO20022.Cain002001.AdditionalAmounts4~
        + TxAmts  : ISO20022.Cain002001.TransactionAmounts3
        + ConvsDtTm  : ISO20022.Cain002001.DateTime2
        + TxId  : ISO20022.Cain002001.TransactionIdentification57
        + Prgrmm  : ISO20022.Cain002001.ProgrammeMode5
        + Dstn  : ISO20022.Cain002001.PartyIdentification286
        + Issr  : ISO20022.Cain002001.PartyIdentification286
        + Rcvr  : ISO20022.Cain002001.PartyIdentification286
        + AcctTo  : ISO20022.Cain002001.AccountDetails4
        + AcctFr  : ISO20022.Cain002001.AccountDetails4
        + Card  : ISO20022.Cain002001.CardData12
        + Sndr  : ISO20022.Cain002001.PartyIdentification286
        + Acqrr  : ISO20022.Cain002001.PartyIdentification286
        + Orgtr  : ISO20022.Cain002001.PartyIdentification286
        + TxChrtcs  : ISO20022.Cain002001.TransactionCharacteristics1
        + Hdr  : ISO20022.Cain002001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validElement(StrngCstmrAuthntcn),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(AdddmData),validElement(PrcgRslt),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""AcctBal""",AcctBal),validElement(AcctBal),validList("""AddtlSvc""",AddtlSvc),validElement(AddtlSvc),validElement(Instlmt),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validList("""Rsk""",Rsk),validElement(Rsk),validList("""Vrfctn""",Vrfctn),validElement(Vrfctn),validElement(Crdhldr),validElement(Wllt),validElement(Tkn),validPattern("""ICCRltdData""",ICCRltdData,"""([0-9A-F][0-9A-F]){1,10000}  """),validElement(Cntxt),validElement(Termnl),validElement(Accptr),validElement(OrgnlDataElmts),validList("""AddtlAmt""",AddtlAmt),validElement(AddtlAmt),validElement(TxAmts),validElement(ConvsDtTm),validElement(TxId),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(AcctTo),validElement(AcctFr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Cain002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AuthstnRspn|ISO20022.Cain002001.AuthorisationResponseV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AuthstnRspn))|

---

## AspectImpl ISO20022.Cain002001.AuthorisationResponseV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Cain002001.Document||||
|+|SctyTrlr|ISO20022.Cain002001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Cain002001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Cain002001.ProtectedData2>||XmlElement()||
|+|StrngCstmrAuthntcn|ISO20022.Cain002001.StrongCustomerAuthentication2||XmlElement()||
|+|AddtlData|List<ISO20022.Cain002001.AdditionalData2>||XmlElement()||
|+|AdddmData|ISO20022.Cain002001.AddendumData7||XmlElement()||
|+|PrcgRslt|ISO20022.Cain002001.ProcessingResult22||XmlElement()||
|+|Rcncltn|ISO20022.Cain002001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Cain002001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Cain002001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Cain002001.Jurisdiction2||XmlElement()||
|+|AcctBal|List<ISO20022.Cain002001.AccountBalance3>||XmlElement()||
|+|AddtlSvc|List<ISO20022.Cain002001.AdditionalService2>||XmlElement()||
|+|Instlmt|ISO20022.Cain002001.Instalment6||XmlElement()||
|+|SpclPrgrmmQlfctn|List<ISO20022.Cain002001.SpecialProgrammeQualification2>||XmlElement()||
|+|Rsk|List<ISO20022.Cain002001.RiskContext3>||XmlElement()||
|+|Vrfctn|List<ISO20022.Cain002001.Verification7>||XmlElement()||
|+|Crdhldr|ISO20022.Cain002001.Cardholder22||XmlElement()||
|+|Wllt|ISO20022.Cain002001.Wallet3||XmlElement()||
|+|Tkn|ISO20022.Cain002001.Token2||XmlElement()||
|+|ICCRltdData|String||XmlElement()||
|+|Cntxt|ISO20022.Cain002001.Context20||XmlElement()||
|+|Termnl|ISO20022.Cain002001.Terminal8||XmlElement()||
|+|Accptr|ISO20022.Cain002001.PartyIdentification285||XmlElement()||
|+|OrgnlDataElmts|ISO20022.Cain002001.OriginalDataElements3||XmlElement()||
|+|AddtlAmt|List<ISO20022.Cain002001.AdditionalAmounts4>||XmlElement()||
|+|TxAmts|ISO20022.Cain002001.TransactionAmounts3||XmlElement()||
|+|ConvsDtTm|ISO20022.Cain002001.DateTime2||XmlElement()||
|+|TxId|ISO20022.Cain002001.TransactionIdentification57||XmlElement()||
|+|Prgrmm|ISO20022.Cain002001.ProgrammeMode5||XmlElement()||
|+|Dstn|ISO20022.Cain002001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Cain002001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cain002001.PartyIdentification286||XmlElement()||
|+|AcctTo|ISO20022.Cain002001.AccountDetails4||XmlElement()||
|+|AcctFr|ISO20022.Cain002001.AccountDetails4||XmlElement()||
|+|Card|ISO20022.Cain002001.CardData12||XmlElement()||
|+|Sndr|ISO20022.Cain002001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Cain002001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cain002001.PartyIdentification286||XmlElement()||
|+|TxChrtcs|ISO20022.Cain002001.TransactionCharacteristics1||XmlElement()||
|+|Hdr|ISO20022.Cain002001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validElement(StrngCstmrAuthntcn),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(AdddmData),validElement(PrcgRslt),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""AcctBal""",AcctBal),validElement(AcctBal),validList("""AddtlSvc""",AddtlSvc),validElement(AddtlSvc),validElement(Instlmt),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validList("""Rsk""",Rsk),validElement(Rsk),validList("""Vrfctn""",Vrfctn),validElement(Vrfctn),validElement(Crdhldr),validElement(Wllt),validElement(Tkn),validPattern("""ICCRltdData""",ICCRltdData,"""([0-9A-F][0-9A-F]){1,10000}  """),validElement(Cntxt),validElement(Termnl),validElement(Accptr),validElement(OrgnlDataElmts),validList("""AddtlAmt""",AddtlAmt),validElement(AddtlAmt),validElement(TxAmts),validElement(ConvsDtTm),validElement(TxId),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(AcctTo),validElement(AcctFr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs),validElement(Hdr))|

