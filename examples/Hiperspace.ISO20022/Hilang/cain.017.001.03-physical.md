# cain.017.001.03-physical
```mermaid
classDiagram
    class ISO20022.Cain017001.Document {
        # Uri  : String
        + NqryRspn () : ISO20022.Cain017001.InquiryResponseV03
        + Validation () = validation(validElement(NqryRspn))
    }
    class ISO20022.Cain017001.InquiryResponseV03 {
        # owner  : ISO20022.Cain017001.Document
        + SctyTrlr  : ISO20022.Cain017001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Cain017001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Cain017001.ProtectedData2~
        + StrngCstmrAuthntcn  : ISO20022.Cain017001.StrongCustomerAuthentication2
        + AddtlData  : List~ISO20022.Cain017001.AdditionalData2~
        + PrcgRslt  : ISO20022.Cain017001.ProcessingResult22
        + OrgnlRspnCd  : String
        + Rcncltn  : ISO20022.Cain017001.Reconciliation4
        + AddtlFee  : List~ISO20022.Cain017001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Cain017001.SettlementService6
        + Jursdctn  : ISO20022.Cain017001.Jurisdiction2
        + AcctStmtData  : List~ISO20022.Cain017001.AccountStatementData3~
        + AcctBal  : List~ISO20022.Cain017001.AccountBalance3~
        + AddtlSvc  : List~ISO20022.Cain017001.AdditionalService2~
        + Instlmt  : ISO20022.Cain017001.Instalment6
        + SpclPrgrmmQlfctn  : List~ISO20022.Cain017001.SpecialProgrammeQualification2~
        + Rsk  : List~ISO20022.Cain017001.RiskContext3~
        + Vrfctn  : List~ISO20022.Cain017001.Verification7~
        + Crdhldr  : ISO20022.Cain017001.Cardholder22
        + Tkn  : ISO20022.Cain017001.Token2
        + Wllt  : ISO20022.Cain017001.Wallet3
        + ICCRltdData  : String
        + Cntxt  : ISO20022.Cain017001.Context20
        + Termnl  : ISO20022.Cain017001.Terminal8
        + Accptr  : ISO20022.Cain017001.PartyIdentification285
        + AddtlAmt  : List~ISO20022.Cain017001.AdditionalAmounts4~
        + ConvsDtTm  : ISO20022.Cain017001.DateTime2
        + TxAmts  : ISO20022.Cain017001.TransactionAmounts4
        + TxId  : ISO20022.Cain017001.TransactionIdentification54
        + CardPrgrmm  : List~ISO20022.Cain017001.ProgrammeMode5~
        + Dstn  : ISO20022.Cain017001.PartyIdentification286
        + Issr  : ISO20022.Cain017001.PartyIdentification286
        + Rcvr  : ISO20022.Cain017001.PartyIdentification286
        + AcctFr  : ISO20022.Cain017001.AccountDetails4
        + Card  : ISO20022.Cain017001.CardData12
        + Sndr  : ISO20022.Cain017001.PartyIdentification286
        + Acqrr  : ISO20022.Cain017001.PartyIdentification286
        + Orgtr  : ISO20022.Cain017001.PartyIdentification286
        + TxChrtcs  : ISO20022.Cain017001.TransactionCharacteristics2
        + Hdr  : ISO20022.Cain017001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validElement(StrngCstmrAuthntcn),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""AcctStmtData""",AcctStmtData),validElement(AcctStmtData),validList("""AcctBal""",AcctBal),validElement(AcctBal),validList("""AddtlSvc""",AddtlSvc),validElement(AddtlSvc),validElement(Instlmt),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validList("""Rsk""",Rsk),validElement(Rsk),validList("""Vrfctn""",Vrfctn),validElement(Vrfctn),validElement(Crdhldr),validElement(Tkn),validElement(Wllt),validPattern("""ICCRltdData""",ICCRltdData,"""([0-9A-F][0-9A-F]){1,10000}  """),validElement(Cntxt),validElement(Termnl),validElement(Accptr),validList("""AddtlAmt""",AddtlAmt),validElement(AddtlAmt),validElement(ConvsDtTm),validElement(TxAmts),validElement(TxId),validList("""CardPrgrmm""",CardPrgrmm),validElement(CardPrgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(AcctFr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Cain017001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|NqryRspn|ISO20022.Cain017001.InquiryResponseV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NqryRspn))|

---

## AspectImpl ISO20022.Cain017001.InquiryResponseV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Cain017001.Document||||
|+|SctyTrlr|ISO20022.Cain017001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Cain017001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Cain017001.ProtectedData2>||XmlElement()||
|+|StrngCstmrAuthntcn|ISO20022.Cain017001.StrongCustomerAuthentication2||XmlElement()||
|+|AddtlData|List<ISO20022.Cain017001.AdditionalData2>||XmlElement()||
|+|PrcgRslt|ISO20022.Cain017001.ProcessingResult22||XmlElement()||
|+|OrgnlRspnCd|String||XmlElement()||
|+|Rcncltn|ISO20022.Cain017001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Cain017001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Cain017001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Cain017001.Jurisdiction2||XmlElement()||
|+|AcctStmtData|List<ISO20022.Cain017001.AccountStatementData3>||XmlElement()||
|+|AcctBal|List<ISO20022.Cain017001.AccountBalance3>||XmlElement()||
|+|AddtlSvc|List<ISO20022.Cain017001.AdditionalService2>||XmlElement()||
|+|Instlmt|ISO20022.Cain017001.Instalment6||XmlElement()||
|+|SpclPrgrmmQlfctn|List<ISO20022.Cain017001.SpecialProgrammeQualification2>||XmlElement()||
|+|Rsk|List<ISO20022.Cain017001.RiskContext3>||XmlElement()||
|+|Vrfctn|List<ISO20022.Cain017001.Verification7>||XmlElement()||
|+|Crdhldr|ISO20022.Cain017001.Cardholder22||XmlElement()||
|+|Tkn|ISO20022.Cain017001.Token2||XmlElement()||
|+|Wllt|ISO20022.Cain017001.Wallet3||XmlElement()||
|+|ICCRltdData|String||XmlElement()||
|+|Cntxt|ISO20022.Cain017001.Context20||XmlElement()||
|+|Termnl|ISO20022.Cain017001.Terminal8||XmlElement()||
|+|Accptr|ISO20022.Cain017001.PartyIdentification285||XmlElement()||
|+|AddtlAmt|List<ISO20022.Cain017001.AdditionalAmounts4>||XmlElement()||
|+|ConvsDtTm|ISO20022.Cain017001.DateTime2||XmlElement()||
|+|TxAmts|ISO20022.Cain017001.TransactionAmounts4||XmlElement()||
|+|TxId|ISO20022.Cain017001.TransactionIdentification54||XmlElement()||
|+|CardPrgrmm|List<ISO20022.Cain017001.ProgrammeMode5>||XmlElement()||
|+|Dstn|ISO20022.Cain017001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Cain017001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cain017001.PartyIdentification286||XmlElement()||
|+|AcctFr|ISO20022.Cain017001.AccountDetails4||XmlElement()||
|+|Card|ISO20022.Cain017001.CardData12||XmlElement()||
|+|Sndr|ISO20022.Cain017001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Cain017001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cain017001.PartyIdentification286||XmlElement()||
|+|TxChrtcs|ISO20022.Cain017001.TransactionCharacteristics2||XmlElement()||
|+|Hdr|ISO20022.Cain017001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validElement(StrngCstmrAuthntcn),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""AcctStmtData""",AcctStmtData),validElement(AcctStmtData),validList("""AcctBal""",AcctBal),validElement(AcctBal),validList("""AddtlSvc""",AddtlSvc),validElement(AddtlSvc),validElement(Instlmt),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validList("""Rsk""",Rsk),validElement(Rsk),validList("""Vrfctn""",Vrfctn),validElement(Vrfctn),validElement(Crdhldr),validElement(Tkn),validElement(Wllt),validPattern("""ICCRltdData""",ICCRltdData,"""([0-9A-F][0-9A-F]){1,10000}  """),validElement(Cntxt),validElement(Termnl),validElement(Accptr),validList("""AddtlAmt""",AddtlAmt),validElement(AddtlAmt),validElement(ConvsDtTm),validElement(TxAmts),validElement(TxId),validList("""CardPrgrmm""",CardPrgrmm),validElement(CardPrgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(AcctFr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs),validElement(Hdr))|

