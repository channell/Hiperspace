# cain.014.001.03-physical
```mermaid
classDiagram
    class ISO20022.Cain014001.Document {
        # Uri  : String
        + RtrvlFlfmtInitn () : ISO20022.Cain014001.RetrievalFulfilmentInitiationV03
        + Validation () = validation(validElement(RtrvlFlfmtInitn))
    }
    class ISO20022.Cain014001.RetrievalFulfilmentInitiationV03 {
        # owner  : ISO20022.Cain014001.Document
        + SctyTrlr  : ISO20022.Cain014001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Cain014001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Cain014001.ProtectedData2~
        + AddtlData  : List~ISO20022.Cain014001.AdditionalData2~
        + PrcgRslt  : ISO20022.Cain014001.ProcessingResult25
        + RtrvlFlfmtInstrs  : List~ISO20022.Cain014001.RetrievalFulfilmentInstructions3~
        + OrgnlTx  : ISO20022.Cain014001.OriginalTransaction3
        + DsptData  : List~ISO20022.Cain014001.DisputeData4~
        + Rcncltn  : ISO20022.Cain014001.Reconciliation4
        + AddtlFee  : List~ISO20022.Cain014001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Cain014001.SettlementService6
        + Jursdctn  : ISO20022.Cain014001.Jurisdiction2
        + SpclPrgrmmQlfctn  : List~ISO20022.Cain014001.SpecialProgrammeQualification2~
        + Wllt  : ISO20022.Cain014001.Wallet3
        + Tkn  : ISO20022.Cain014001.Token2
        + Pyee  : ISO20022.Cain014001.PartyIdentification287
        + Pyer  : ISO20022.Cain014001.PartyIdentification287
        + Cntxt  : ISO20022.Cain014001.Context24
        + Termnl  : ISO20022.Cain014001.Terminal8
        + Accptr  : ISO20022.Cain014001.PartyIdentification285
        + ConvsDtTm  : ISO20022.Cain014001.DateTime2
        + TxId  : ISO20022.Cain014001.TransactionIdentification54
        + Prgrmm  : List~ISO20022.Cain014001.ProgrammeMode5~
        + Dstn  : ISO20022.Cain014001.PartyIdentification286
        + Issr  : ISO20022.Cain014001.PartyIdentification286
        + Rcvr  : ISO20022.Cain014001.PartyIdentification286
        + Card  : ISO20022.Cain014001.CardData13
        + Sndr  : ISO20022.Cain014001.PartyIdentification286
        + Acqrr  : ISO20022.Cain014001.PartyIdentification286
        + Orgtr  : ISO20022.Cain014001.PartyIdentification286
        + TxChrtcs  : ISO20022.Cain014001.TransactionCharacteristics3
        + Hdr  : ISO20022.Cain014001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validList("""RtrvlFlfmtInstrs""",RtrvlFlfmtInstrs),validElement(RtrvlFlfmtInstrs),validElement(OrgnlTx),validRequired("""DsptData""",DsptData),validList("""DsptData""",DsptData),validElement(DsptData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validElement(Wllt),validElement(Tkn),validElement(Pyee),validElement(Pyer),validElement(Cntxt),validElement(Termnl),validElement(Accptr),validElement(ConvsDtTm),validElement(TxId),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Cain014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RtrvlFlfmtInitn|ISO20022.Cain014001.RetrievalFulfilmentInitiationV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RtrvlFlfmtInitn))|

---

## AspectImpl ISO20022.Cain014001.RetrievalFulfilmentInitiationV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Cain014001.Document||||
|+|SctyTrlr|ISO20022.Cain014001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Cain014001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Cain014001.ProtectedData2>||XmlElement()||
|+|AddtlData|List<ISO20022.Cain014001.AdditionalData2>||XmlElement()||
|+|PrcgRslt|ISO20022.Cain014001.ProcessingResult25||XmlElement()||
|+|RtrvlFlfmtInstrs|List<ISO20022.Cain014001.RetrievalFulfilmentInstructions3>||XmlElement()||
|+|OrgnlTx|ISO20022.Cain014001.OriginalTransaction3||XmlElement()||
|+|DsptData|List<ISO20022.Cain014001.DisputeData4>||XmlElement()||
|+|Rcncltn|ISO20022.Cain014001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Cain014001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Cain014001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Cain014001.Jurisdiction2||XmlElement()||
|+|SpclPrgrmmQlfctn|List<ISO20022.Cain014001.SpecialProgrammeQualification2>||XmlElement()||
|+|Wllt|ISO20022.Cain014001.Wallet3||XmlElement()||
|+|Tkn|ISO20022.Cain014001.Token2||XmlElement()||
|+|Pyee|ISO20022.Cain014001.PartyIdentification287||XmlElement()||
|+|Pyer|ISO20022.Cain014001.PartyIdentification287||XmlElement()||
|+|Cntxt|ISO20022.Cain014001.Context24||XmlElement()||
|+|Termnl|ISO20022.Cain014001.Terminal8||XmlElement()||
|+|Accptr|ISO20022.Cain014001.PartyIdentification285||XmlElement()||
|+|ConvsDtTm|ISO20022.Cain014001.DateTime2||XmlElement()||
|+|TxId|ISO20022.Cain014001.TransactionIdentification54||XmlElement()||
|+|Prgrmm|List<ISO20022.Cain014001.ProgrammeMode5>||XmlElement()||
|+|Dstn|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|Card|ISO20022.Cain014001.CardData13||XmlElement()||
|+|Sndr|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cain014001.PartyIdentification286||XmlElement()||
|+|TxChrtcs|ISO20022.Cain014001.TransactionCharacteristics3||XmlElement()||
|+|Hdr|ISO20022.Cain014001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validList("""RtrvlFlfmtInstrs""",RtrvlFlfmtInstrs),validElement(RtrvlFlfmtInstrs),validElement(OrgnlTx),validRequired("""DsptData""",DsptData),validList("""DsptData""",DsptData),validElement(DsptData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""SpclPrgrmmQlfctn""",SpclPrgrmmQlfctn),validElement(SpclPrgrmmQlfctn),validElement(Wllt),validElement(Tkn),validElement(Pyee),validElement(Pyer),validElement(Cntxt),validElement(Termnl),validElement(Accptr),validElement(ConvsDtTm),validElement(TxId),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs),validElement(Hdr))|

