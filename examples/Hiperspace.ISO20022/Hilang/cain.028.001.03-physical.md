# cain.028.001.03-physical
```mermaid
classDiagram
    class ISO20022.Cain028001.Document {
        # Uri  : String
        + ChrgBckRspn () : ISO20022.Cain028001.ChargeBackResponseV03
        + Validation () = validation(validElement(ChrgBckRspn))
    }
    class ISO20022.Cain028001.ChargeBackResponseV03 {
        # owner  : ISO20022.Cain028001.Document
        + SctyTrlr  : ISO20022.Cain028001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Cain028001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Cain028001.ProtectedData2~
        + AddtlData  : List~ISO20022.Cain028001.AdditionalData2~
        + PrcgRslt  : ISO20022.Cain028001.ProcessingResult23
        + Dcmnttn  : List~ISO20022.Cain028001.DisputeDocumentation1~
        + DsptData  : List~ISO20022.Cain028001.DisputeData4~
        + Rcncltn  : ISO20022.Cain028001.Reconciliation4
        + AddtlFee  : List~ISO20022.Cain028001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Cain028001.SettlementService6
        + Jursdctn  : ISO20022.Cain028001.Jurisdiction2
        + Tkn  : ISO20022.Cain028001.Token2
        + OrgnlTxAmts  : ISO20022.Cain028001.OriginalTransactionAmounts3
        + Cntxt  : ISO20022.Cain028001.Context22
        + Termnl  : ISO20022.Cain028001.Terminal8
        + Accptr  : ISO20022.Cain028001.PartyIdentification285
        + TxAmts  : ISO20022.Cain028001.TransactionAmounts3
        + ConvsDtTm  : ISO20022.Cain028001.DateTime2
        + TxId  : ISO20022.Cain028001.TransactionIdentification55
        + Prgrmm  : List~ISO20022.Cain028001.ProgrammeMode5~
        + Dstn  : ISO20022.Cain028001.PartyIdentification286
        + Issr  : ISO20022.Cain028001.PartyIdentification286
        + Rcvr  : ISO20022.Cain028001.PartyIdentification286
        + Card  : ISO20022.Cain028001.CardData13
        + Sndr  : ISO20022.Cain028001.PartyIdentification286
        + Acqrr  : ISO20022.Cain028001.PartyIdentification286
        + Orgtr  : ISO20022.Cain028001.PartyIdentification286
        + TxChrtcs  : ISO20022.Cain028001.TransactionCharacteristics3
        + Hdr  : ISO20022.Cain028001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validList("""Dcmnttn""",Dcmnttn),validElement(Dcmnttn),validRequired("""DsptData""",DsptData),validList("""DsptData""",DsptData),validElement(DsptData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(Tkn),validElement(OrgnlTxAmts),validElement(Cntxt),validElement(Termnl),validElement(Accptr),validElement(TxAmts),validElement(ConvsDtTm),validElement(TxId),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Cain028001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|ChrgBckRspn|ISO20022.Cain028001.ChargeBackResponseV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ChrgBckRspn))|

---

## AspectImpl ISO20022.Cain028001.ChargeBackResponseV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Cain028001.Document||||
|+|SctyTrlr|ISO20022.Cain028001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Cain028001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Cain028001.ProtectedData2>||XmlElement()||
|+|AddtlData|List<ISO20022.Cain028001.AdditionalData2>||XmlElement()||
|+|PrcgRslt|ISO20022.Cain028001.ProcessingResult23||XmlElement()||
|+|Dcmnttn|List<ISO20022.Cain028001.DisputeDocumentation1>||XmlElement()||
|+|DsptData|List<ISO20022.Cain028001.DisputeData4>||XmlElement()||
|+|Rcncltn|ISO20022.Cain028001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Cain028001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Cain028001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Cain028001.Jurisdiction2||XmlElement()||
|+|Tkn|ISO20022.Cain028001.Token2||XmlElement()||
|+|OrgnlTxAmts|ISO20022.Cain028001.OriginalTransactionAmounts3||XmlElement()||
|+|Cntxt|ISO20022.Cain028001.Context22||XmlElement()||
|+|Termnl|ISO20022.Cain028001.Terminal8||XmlElement()||
|+|Accptr|ISO20022.Cain028001.PartyIdentification285||XmlElement()||
|+|TxAmts|ISO20022.Cain028001.TransactionAmounts3||XmlElement()||
|+|ConvsDtTm|ISO20022.Cain028001.DateTime2||XmlElement()||
|+|TxId|ISO20022.Cain028001.TransactionIdentification55||XmlElement()||
|+|Prgrmm|List<ISO20022.Cain028001.ProgrammeMode5>||XmlElement()||
|+|Dstn|ISO20022.Cain028001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Cain028001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cain028001.PartyIdentification286||XmlElement()||
|+|Card|ISO20022.Cain028001.CardData13||XmlElement()||
|+|Sndr|ISO20022.Cain028001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Cain028001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cain028001.PartyIdentification286||XmlElement()||
|+|TxChrtcs|ISO20022.Cain028001.TransactionCharacteristics3||XmlElement()||
|+|Hdr|ISO20022.Cain028001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validList("""Dcmnttn""",Dcmnttn),validElement(Dcmnttn),validRequired("""DsptData""",DsptData),validList("""DsptData""",DsptData),validElement(DsptData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(Tkn),validElement(OrgnlTxAmts),validElement(Cntxt),validElement(Termnl),validElement(Accptr),validElement(TxAmts),validElement(ConvsDtTm),validElement(TxId),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(TxChrtcs),validElement(Hdr))|

