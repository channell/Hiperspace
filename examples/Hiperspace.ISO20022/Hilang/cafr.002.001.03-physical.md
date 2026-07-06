# cafr.002.001.03-physical
```mermaid
classDiagram
    class ISO20022.Cafr002001.Document {
        # Uri  : String
        + FrdRptgRspn () : ISO20022.Cafr002001.FraudReportingResponseV03
        + Validation () = validation(validElement(FrdRptgRspn))
    }
    class ISO20022.Cafr002001.FraudReportingResponseV03 {
        # owner  : ISO20022.Cafr002001.Document
        + SctyTrlr  : ISO20022.Cafr002001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Cafr002001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Cafr002001.ProtectedData2~
        + OrgnlRspnCd  : String
        + PrcgRslt  : ISO20022.Cafr002001.ProcessingResult23
        + AddtlData  : List~ISO20022.Cafr002001.AdditionalData2~
        + Rcncltn  : ISO20022.Cafr002001.Reconciliation4
        + AddtlFee  : List~ISO20022.Cafr002001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Cafr002001.SettlementService6
        + Jursdctn  : ISO20022.Cafr002001.Jurisdiction2
        + Crdhldr  : ISO20022.Cafr002001.Cardholder22
        + Tkn  : ISO20022.Cafr002001.Token2
        + Prgrmm  : ISO20022.Cafr002001.ProgrammeMode5
        + Dstn  : ISO20022.Cafr002001.PartyIdentification286
        + Issr  : ISO20022.Cafr002001.PartyIdentification286
        + Rcvr  : ISO20022.Cafr002001.PartyIdentification286
        + FrdTxId  : String
        + Card  : ISO20022.Cafr002001.CardData15
        + Sndr  : ISO20022.Cafr002001.PartyIdentification286
        + Acqrr  : ISO20022.Cafr002001.PartyIdentification286
        + Orgtr  : ISO20022.Cafr002001.PartyIdentification286
        + Hdr  : ISO20022.Cafr002001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(PrcgRslt),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(Crdhldr),validElement(Tkn),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Cafr002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|FrdRptgRspn|ISO20022.Cafr002001.FraudReportingResponseV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrdRptgRspn))|

---

## AspectImpl ISO20022.Cafr002001.FraudReportingResponseV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Cafr002001.Document||||
|+|SctyTrlr|ISO20022.Cafr002001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Cafr002001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Cafr002001.ProtectedData2>||XmlElement()||
|+|OrgnlRspnCd|String||XmlElement()||
|+|PrcgRslt|ISO20022.Cafr002001.ProcessingResult23||XmlElement()||
|+|AddtlData|List<ISO20022.Cafr002001.AdditionalData2>||XmlElement()||
|+|Rcncltn|ISO20022.Cafr002001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Cafr002001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Cafr002001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Cafr002001.Jurisdiction2||XmlElement()||
|+|Crdhldr|ISO20022.Cafr002001.Cardholder22||XmlElement()||
|+|Tkn|ISO20022.Cafr002001.Token2||XmlElement()||
|+|Prgrmm|ISO20022.Cafr002001.ProgrammeMode5||XmlElement()||
|+|Dstn|ISO20022.Cafr002001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Cafr002001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cafr002001.PartyIdentification286||XmlElement()||
|+|FrdTxId|String||XmlElement()||
|+|Card|ISO20022.Cafr002001.CardData15||XmlElement()||
|+|Sndr|ISO20022.Cafr002001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Cafr002001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cafr002001.PartyIdentification286||XmlElement()||
|+|Hdr|ISO20022.Cafr002001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validPattern("""OrgnlRspnCd""",OrgnlRspnCd,"""[0-9A-Z]{2,2}"""),validElement(PrcgRslt),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(Crdhldr),validElement(Tkn),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(Hdr))|

