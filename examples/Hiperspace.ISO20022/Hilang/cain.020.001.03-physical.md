# cain.020.001.03-physical
```mermaid
classDiagram
    class ISO20022.Cain020001.Document {
        # Uri  : String
        + Amdmnt () : ISO20022.Cain020001.AmendmentV03
        + Validation () = validation(validElement(Amdmnt))
    }
    class ISO20022.Cain020001.AmendmentV03 {
        # owner  : ISO20022.Cain020001.Document
        + SctyTrlr  : ISO20022.Cain020001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Cain020001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Cain020001.ProtectedData2~
        + AddtlData  : List~ISO20022.Cain020001.AdditionalData2~
        + MsgAmdd  : String
        + OrgnlMsg  : String
        + TxId  : ISO20022.Cain020001.TransactionIdentification55
        + AmddData  : List~ISO20022.Cain020001.DetailedError1~
        + Rcncltn  : ISO20022.Cain020001.Reconciliation4
        + SttlmSvc  : ISO20022.Cain020001.SettlementService6
        + Jursdctn  : ISO20022.Cain020001.Jurisdiction2
        + Prgrmm  : List~ISO20022.Cain020001.ProgrammeMode5~
        + Dstn  : ISO20022.Cain020001.PartyIdentification286
        + Rcvr  : ISO20022.Cain020001.PartyIdentification286
        + Sndr  : ISO20022.Cain020001.PartyIdentification286
        + Orgtr  : ISO20022.Cain020001.PartyIdentification286
        + Hdr  : ISO20022.Cain020001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(TxId),validRequired("""AmddData""",AmddData),validList("""AmddData""",AmddData),validElement(AmddData),validElement(Rcncltn),validElement(SttlmSvc),validElement(Jursdctn),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Rcvr),validElement(Sndr),validElement(Orgtr),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Cain020001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|Amdmnt|ISO20022.Cain020001.AmendmentV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amdmnt))|

---

## AspectImpl ISO20022.Cain020001.AmendmentV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Cain020001.Document||||
|+|SctyTrlr|ISO20022.Cain020001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Cain020001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Cain020001.ProtectedData2>||XmlElement()||
|+|AddtlData|List<ISO20022.Cain020001.AdditionalData2>||XmlElement()||
|+|MsgAmdd|String||XmlElement()||
|+|OrgnlMsg|String||XmlElement()||
|+|TxId|ISO20022.Cain020001.TransactionIdentification55||XmlElement()||
|+|AmddData|List<ISO20022.Cain020001.DetailedError1>||XmlElement()||
|+|Rcncltn|ISO20022.Cain020001.Reconciliation4||XmlElement()||
|+|SttlmSvc|ISO20022.Cain020001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Cain020001.Jurisdiction2||XmlElement()||
|+|Prgrmm|List<ISO20022.Cain020001.ProgrammeMode5>||XmlElement()||
|+|Dstn|ISO20022.Cain020001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Cain020001.PartyIdentification286||XmlElement()||
|+|Sndr|ISO20022.Cain020001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Cain020001.PartyIdentification286||XmlElement()||
|+|Hdr|ISO20022.Cain020001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(TxId),validRequired("""AmddData""",AmddData),validList("""AmddData""",AmddData),validElement(AmddData),validElement(Rcncltn),validElement(SttlmSvc),validElement(Jursdctn),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Rcvr),validElement(Sndr),validElement(Orgtr),validElement(Hdr))|

