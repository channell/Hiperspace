# caad.008.001.02-physical
```mermaid
classDiagram
    class ISO20022.Caad008001.Document {
        # Uri  : String
        + AdmstvInitn () : ISO20022.Caad008001.AdministrativeInitiationV02
        + Validation () = validation(validElement(AdmstvInitn))
    }
    class ISO20022.Caad008001.AdministrativeInitiationV02 {
        # owner  : ISO20022.Caad008001.Document
        + SctyTrlr  : ISO20022.Caad008001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Caad008001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Caad008001.ProtectedData2~
        + AddtlData  : List~ISO20022.Caad008001.AdditionalData2~
        + OrgnlTx  : List~ISO20022.Caad008001.OriginalTransaction3~
        + PrcgRslt  : ISO20022.Caad008001.ProcessingResult27
        + Rcncltn  : ISO20022.Caad008001.Reconciliation4
        + AddtlFee  : List~ISO20022.Caad008001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Caad008001.SettlementService5
        + Jursdctn  : ISO20022.Caad008001.Jurisdiction2
        + AddtlSvc  : List~ISO20022.Caad008001.AdditionalService2~
        + Instlmt  : ISO20022.Caad008001.Instalment6
        + SpclPrgrmmQlfctn  : List~ISO20022.Caad008001.SpecialProgrammeQualification2~
        + Rsk  : List~ISO20022.Caad008001.RiskContext3~
        + Vrfctn  : List~ISO20022.Caad008001.Verification6~
        + Cstmr  : ISO20022.Caad008001.Customer4
        + Crdhldr  : ISO20022.Caad008001.Cardholder22
        + Wllt  : ISO20022.Caad008001.Wallet3
        + CstmrDvc  : ISO20022.Caad008001.CustomerDevice5
        + Tkn  : ISO20022.Caad008001.Token2
        + Pyee  : ISO20022.Caad008001.PartyIdentification287
        + Pyer  : ISO20022.Caad008001.PartyIdentification287
        + ICCRltdData  : String
        + Cntxt  : ISO20022.Caad008001.Context19
        + POICmpnt  : List~ISO20022.Caad008001.PointOfInteractionComponent16~
        + Termnl  : ISO20022.Caad008001.Terminal7
        + Accptr  : ISO20022.Caad008001.PartyIdentification288
        + XchgRate  : List~ISO20022.Caad008001.ExchangeRateInformation5~
        + ConvsDtTm  : ISO20022.Caad008001.DateTime2
        + TxId  : ISO20022.Caad008001.TransactionIdentification56
        + Prgrmm  : ISO20022.Caad008001.ProgrammeMode4
        + Dstn  : ISO20022.Caad008001.PartyIdentification286
        + Issr  : ISO20022.Caad008001.PartyIdentification286
        + Rcvr  : ISO20022.Caad008001.PartyIdentification286
        + Card  : ISO20022.Caad008001.CardData11
        + Sndr  : ISO20022.Caad008001.PartyIdentification286
        + Acqrr  : ISO20022.Caad008001.PartyIdentification286
        + Orgtr  : ISO20022.Caad008001.PartyIdentification286
        + TxDesc  : String
        + LclData  : List~ISO20022.Caad008001.LocalData17~
        + TxtMsg  : String
        + AltrnMsgRsn  : List~String~
        + MsgRsn  : List~String~
        + OthrAdmstvTp  : String
        + AdmstvTp  : String
        + Hdr  : ISO20022.Caad008001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""OrgnlTx""",OrgnlTx),validElement(OrgnlTx),validElement(PrcgRslt),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""AddtlSvc""",AddtlSvc),validElement(AddtlSvc),validElement(Instlmt),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validList("""Rsk""",Rsk),validElement(Rsk),validList("""Vrfctn""",Vrfctn),validElement(Vrfctn),validElement(Cstmr),validElement(Crdhldr),validElement(Wllt),validElement(CstmrDvc),validElement(Tkn),validElement(Pyee),validElement(Pyer),validPattern("""ICCRltdData""",ICCRltdData,"""([0-9A-F][0-9A-F]){1,10000}  """),validElement(Cntxt),validList("""POICmpnt""",POICmpnt),validElement(POICmpnt),validElement(Termnl),validElement(Accptr),validList("""XchgRate""",XchgRate),validElement(XchgRate),validElement(ConvsDtTm),validElement(TxId),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validList("""LclData""",LclData),validElement(LclData),validPattern("""MsgRsn""",MsgRsn,"""[0-9]{4,4}"""),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caad008001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AdmstvInitn|ISO20022.Caad008001.AdministrativeInitiationV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AdmstvInitn))|

---

## AspectImpl ISO20022.Caad008001.AdministrativeInitiationV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caad008001.Document||||
|+|SctyTrlr|ISO20022.Caad008001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Caad008001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Caad008001.ProtectedData2>||XmlElement()||
|+|AddtlData|List<ISO20022.Caad008001.AdditionalData2>||XmlElement()||
|+|OrgnlTx|List<ISO20022.Caad008001.OriginalTransaction3>||XmlElement()||
|+|PrcgRslt|ISO20022.Caad008001.ProcessingResult27||XmlElement()||
|+|Rcncltn|ISO20022.Caad008001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Caad008001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Caad008001.SettlementService5||XmlElement()||
|+|Jursdctn|ISO20022.Caad008001.Jurisdiction2||XmlElement()||
|+|AddtlSvc|List<ISO20022.Caad008001.AdditionalService2>||XmlElement()||
|+|Instlmt|ISO20022.Caad008001.Instalment6||XmlElement()||
|+|SpclPrgrmmQlfctn|List<ISO20022.Caad008001.SpecialProgrammeQualification2>||XmlElement()||
|+|Rsk|List<ISO20022.Caad008001.RiskContext3>||XmlElement()||
|+|Vrfctn|List<ISO20022.Caad008001.Verification6>||XmlElement()||
|+|Cstmr|ISO20022.Caad008001.Customer4||XmlElement()||
|+|Crdhldr|ISO20022.Caad008001.Cardholder22||XmlElement()||
|+|Wllt|ISO20022.Caad008001.Wallet3||XmlElement()||
|+|CstmrDvc|ISO20022.Caad008001.CustomerDevice5||XmlElement()||
|+|Tkn|ISO20022.Caad008001.Token2||XmlElement()||
|+|Pyee|ISO20022.Caad008001.PartyIdentification287||XmlElement()||
|+|Pyer|ISO20022.Caad008001.PartyIdentification287||XmlElement()||
|+|ICCRltdData|String||XmlElement()||
|+|Cntxt|ISO20022.Caad008001.Context19||XmlElement()||
|+|POICmpnt|List<ISO20022.Caad008001.PointOfInteractionComponent16>||XmlElement()||
|+|Termnl|ISO20022.Caad008001.Terminal7||XmlElement()||
|+|Accptr|ISO20022.Caad008001.PartyIdentification288||XmlElement()||
|+|XchgRate|List<ISO20022.Caad008001.ExchangeRateInformation5>||XmlElement()||
|+|ConvsDtTm|ISO20022.Caad008001.DateTime2||XmlElement()||
|+|TxId|ISO20022.Caad008001.TransactionIdentification56||XmlElement()||
|+|Prgrmm|ISO20022.Caad008001.ProgrammeMode4||XmlElement()||
|+|Dstn|ISO20022.Caad008001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Caad008001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Caad008001.PartyIdentification286||XmlElement()||
|+|Card|ISO20022.Caad008001.CardData11||XmlElement()||
|+|Sndr|ISO20022.Caad008001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Caad008001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Caad008001.PartyIdentification286||XmlElement()||
|+|TxDesc|String||XmlElement()||
|+|LclData|List<ISO20022.Caad008001.LocalData17>||XmlElement()||
|+|TxtMsg|String||XmlElement()||
|+|AltrnMsgRsn|List<String>||XmlElement()||
|+|MsgRsn|List<String>||XmlElement()||
|+|OthrAdmstvTp|String||XmlElement()||
|+|AdmstvTp|String||XmlElement()||
|+|Hdr|ISO20022.Caad008001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validList("""OrgnlTx""",OrgnlTx),validElement(OrgnlTx),validElement(PrcgRslt),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""AddtlSvc""",AddtlSvc),validElement(AddtlSvc),validElement(Instlmt),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validList("""Rsk""",Rsk),validElement(Rsk),validList("""Vrfctn""",Vrfctn),validElement(Vrfctn),validElement(Cstmr),validElement(Crdhldr),validElement(Wllt),validElement(CstmrDvc),validElement(Tkn),validElement(Pyee),validElement(Pyer),validPattern("""ICCRltdData""",ICCRltdData,"""([0-9A-F][0-9A-F]){1,10000}  """),validElement(Cntxt),validList("""POICmpnt""",POICmpnt),validElement(POICmpnt),validElement(Termnl),validElement(Accptr),validList("""XchgRate""",XchgRate),validElement(XchgRate),validElement(ConvsDtTm),validElement(TxId),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validList("""LclData""",LclData),validElement(LclData),validPattern("""MsgRsn""",MsgRsn,"""[0-9]{4,4}"""),validElement(Hdr))|

