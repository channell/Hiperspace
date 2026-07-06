# cain.026.001.03-physical
```mermaid
classDiagram
    class ISO20022.Cain026001.Document {
        # Uri  : String
        + AdddmRspn () : ISO20022.Cain026001.AddendumResponseV03
        + Validation () = validation(validElement(AdddmRspn))
    }
    class ISO20022.Cain026001.AddendumResponseV03 {
        # owner  : ISO20022.Cain026001.Document
        + SctyTrlr  : ISO20022.Cain026001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Cain026001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Cain026001.ProtectedData2~
        + AddtlData  : List~ISO20022.Cain026001.AdditionalData2~
        + PrcgRslt  : ISO20022.Cain026001.ProcessingResult23
        + Rcncltn  : ISO20022.Cain026001.Reconciliation4
        + AddtlFee  : List~ISO20022.Cain026001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Cain026001.SettlementService6
        + Jursdctn  : ISO20022.Cain026001.Jurisdiction2
        + Accptr  : ISO20022.Cain026001.PartyIdentification285
        + Tkn  : ISO20022.Cain026001.Token2
        + OrgnlDataElmts  : ISO20022.Cain026001.OriginalDataElements3
        + TxId  : ISO20022.Cain026001.TransactionIdentification53
        + Prgrmm  : List~ISO20022.Cain026001.ProgrammeMode5~
        + Dstn  : ISO20022.Cain026001.PartyIdentification286
        + Issr  : ISO20022.Cain026001.PartyIdentification286
        + Rcvr  : ISO20022.Cain026001.PartyIdentification286
        + Card  : ISO20022.Cain026001.CardData14
        + Sndr  : ISO20022.Cain026001.PartyIdentification286
        + Acqrr  : ISO20022.Cain026001.PartyIdentification286
        + Orgtr  : ISO20022.Cain026001.PartyIdentification286
        + TxDesc  : String
        + Hdr  : ISO20022.Cain026001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(Accptr),validElement(Tkn),validElement(OrgnlDataElmts),validElement(TxId),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Cain026001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|AdddmRspn|ISO20022.Cain026001.AddendumResponseV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AdddmRspn))|

---

## AspectImpl ISO20022.Cain026001.AddendumResponseV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Cain026001.Document||||
|+|SctyTrlr|ISO20022.Cain026001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Cain026001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Cain026001.ProtectedData2>||XmlElement()||
|+|AddtlData|List<ISO20022.Cain026001.AdditionalData2>||XmlElement()||
|+|PrcgRslt|ISO20022.Cain026001.ProcessingResult23||XmlElement()||
|+|Rcncltn|ISO20022.Cain026001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Cain026001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Cain026001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Cain026001.Jurisdiction2||XmlElement()||
|+|Accptr|ISO20022.Cain026001.PartyIdentification285||XmlElement()||
|+|Tkn|ISO20022.Cain026001.Token2||XmlElement()||
|+|OrgnlDataElmts|ISO20022.Cain026001.OriginalDataElements3||XmlElement()||
|+|TxId|ISO20022.Cain026001.TransactionIdentification53||XmlElement()||
|+|Prgrmm|List<ISO20022.Cain026001.ProgrammeMode5>||XmlElement()||
|+|Dstn|ISO20022.Cain026001.PartyIdentification286||XmlElement()||
|+|Issr|ISO20022.Cain026001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cain026001.PartyIdentification286||XmlElement()||
|+|Card|ISO20022.Cain026001.CardData14||XmlElement()||
|+|Sndr|ISO20022.Cain026001.PartyIdentification286||XmlElement()||
|+|Acqrr|ISO20022.Cain026001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cain026001.PartyIdentification286||XmlElement()||
|+|TxDesc|String||XmlElement()||
|+|Hdr|ISO20022.Cain026001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(PrcgRslt),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validElement(Accptr),validElement(Tkn),validElement(OrgnlDataElmts),validElement(TxId),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Issr),validElement(Rcvr),validElement(Card),validElement(Sndr),validElement(Acqrr),validElement(Orgtr),validElement(Hdr))|

