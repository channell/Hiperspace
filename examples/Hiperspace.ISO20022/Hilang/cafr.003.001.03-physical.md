# cafr.003.001.03-physical
```mermaid
classDiagram
    class ISO20022.Cafr003001.Document {
        # Uri  : String
        + FrdDspstnInitn () : ISO20022.Cafr003001.FraudDispositionInitiationV03
        + Validation () = validation(validElement(FrdDspstnInitn))
    }
    class ISO20022.Cafr003001.FraudDispositionInitiationV03 {
        # owner  : ISO20022.Cafr003001.Document
        + SctyTrlr  : ISO20022.Cafr003001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Cafr003001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Cafr003001.ProtectedData2~
        + AddtlData  : List~ISO20022.Cafr003001.AdditionalData2~
        + Rcncltn  : ISO20022.Cafr003001.Reconciliation4
        + AddtlFee  : List~ISO20022.Cafr003001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Cafr003001.SettlementService6
        + Jursdctn  : ISO20022.Cafr003001.Jurisdiction2
        + Crdhldr  : ISO20022.Cafr003001.Cardholder22
        + Tkn  : ISO20022.Cafr003001.Token2
        + AddtlInf  : List~ISO20022.Cafr003001.AdditionalInformation30~
        + Prgrmm  : ISO20022.Cafr003001.ProgrammeMode5
        + Dstn  : ISO20022.Cafr003001.PartyIdentification286
        + Issr  : ISO20022.Cafr003001.PartyIdentification286
        + Rcvr  : ISO20022.Cafr003001.PartyIdentification286
        + FrdTxId  : String
        + Card  : ISO20022.Cafr003001.CardData15
        + Sndr  : ISO20022.Cafr003001.PartyIdentification286
        + Acqrr  : ISO20022.Cafr003001.PartyIdentification286
        + Orgtr  : ISO20022.Cafr003001.PartyIdentification286
        + FrdDspstnSts  : ISO20022.Cafr003001.FraudDispositionStatus2
        + RptdFrd  : ISO20022.Cafr003001.ReportedFraud5
        + Hdr  : ISO20022.Cafr003001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(Crdhldr),validElement(Tkn),validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(FrdDspstnSts),validElement(RptdFrd),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Cafr003001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|FrdDspstnInitn|ISO20022.Cafr003001.FraudDispositionInitiationV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrdDspstnInitn))|

---

## AspectImpl ISO20022.Cafr003001.FraudDispositionInitiationV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Cafr003001.Document||||
|+|SctyTrlr|ISO20022.Cafr003001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Cafr003001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Cafr003001.ProtectedData2>||XmlElement()||
|+|AddtlData|List<ISO20022.Cafr003001.AdditionalData2>||XmlElement()||
|+|Rcncltn|ISO20022.Cafr003001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Cafr003001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Cafr003001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Cafr003001.Jurisdiction2||XmlElement()||
|+|Crdhldr|ISO20022.Cafr003001.Cardholder22||XmlElement()||
|+|Tkn|ISO20022.Cafr003001.Token2||XmlElement()||
|+|AddtlInf|List<ISO20022.Cafr003001.AdditionalInformation30>||XmlElement()||
|+|Prgrmm|ISO20022.Cafr003001.ProgrammeMode5||XmlElement()||
|+|Dstn|ISO20022.Cafr003001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Cafr003001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cafr003001.PartyIdentification286||XmlElement()||
|+|FrdTxId|String||XmlElement()||
|+|Card|ISO20022.Cafr003001.CardData15||XmlElement()||
|+|Sndr|ISO20022.Cafr003001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Cafr003001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cafr003001.PartyIdentification286||XmlElement()||
|+|FrdDspstnSts|ISO20022.Cafr003001.FraudDispositionStatus2||XmlElement()||
|+|RptdFrd|ISO20022.Cafr003001.ReportedFraud5||XmlElement()||
|+|Hdr|ISO20022.Cafr003001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(Crdhldr),validElement(Tkn),validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(FrdDspstnSts),validElement(RptdFrd),validElement(Hdr))|

