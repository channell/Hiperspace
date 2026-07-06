# caad.005.001.04-physical
```mermaid
classDiagram
    class ISO20022.Caad005001.Document {
        # Uri  : String
        + RcncltnInitn () : ISO20022.Caad005001.ReconciliationInitiationV04
        + Validation () = validation(validElement(RcncltnInitn))
    }
    class ISO20022.Caad005001.ReconciliationInitiationV04 {
        # owner  : ISO20022.Caad005001.Document
        + SctyTrlr  : ISO20022.Caad005001.ContentInformationType41
        + SplmtryData  : List~ISO20022.Caad005001.SupplementaryData1~
        + PrtctdData  : List~ISO20022.Caad005001.ProtectedData2~
        + PrcgRslt  : ISO20022.Caad005001.ProcessingResult26
        + AddtlData  : List~ISO20022.Caad005001.AdditionalData2~
        + Rcncltn  : ISO20022.Caad005001.Reconciliation4
        + AddtlFee  : List~ISO20022.Caad005001.AdditionalFee3~
        + SttlmSvc  : ISO20022.Caad005001.SettlementService6
        + Jursdctn  : ISO20022.Caad005001.Jurisdiction2
        + RcncltnTtls  : List~ISO20022.Caad005001.TransactionTotals14~
        + LifeCyclId  : String
        + RtrvlRefNb  : String
        + TrnsmssnDtTm  : DateTime
        + SysTracAudtNb  : String
        + Prgrmm  : List~ISO20022.Caad005001.ProgrammeMode5~
        + Dstn  : ISO20022.Caad005001.PartyIdentification286
        + Rcvr  : ISO20022.Caad005001.PartyIdentification286
        + Sndr  : ISO20022.Caad005001.PartyIdentification286
        + Orgtr  : ISO20022.Caad005001.PartyIdentification286
        + ReqdCcy  : List~String~
        + OthrRcncltnTp  : String
        + RcncltnTp  : String
        + OthrRcncltnActvtyTp  : String
        + RcncltnActvtyTp  : String
        + RcncltnFctn  : String
        + Hdr  : ISO20022.Caad005001.Header71
        + Validation () = validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validElement(PrcgRslt),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""RcncltnTtls""",RcncltnTtls),validElement(RcncltnTtls),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Rcvr),validElement(Sndr),validElement(Orgtr),validPattern("""ReqdCcy""",ReqdCcy,"""[0-9]{3}"""),validElement(Hdr))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Caad005001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|RcncltnInitn|ISO20022.Caad005001.ReconciliationInitiationV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcncltnInitn))|

---

## AspectImpl ISO20022.Caad005001.ReconciliationInitiationV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Caad005001.Document||||
|+|SctyTrlr|ISO20022.Caad005001.ContentInformationType41||XmlElement()||
|+|SplmtryData|List<ISO20022.Caad005001.SupplementaryData1>||XmlElement()||
|+|PrtctdData|List<ISO20022.Caad005001.ProtectedData2>||XmlElement()||
|+|PrcgRslt|ISO20022.Caad005001.ProcessingResult26||XmlElement()||
|+|AddtlData|List<ISO20022.Caad005001.AdditionalData2>||XmlElement()||
|+|Rcncltn|ISO20022.Caad005001.Reconciliation4||XmlElement()||
|+|AddtlFee|List<ISO20022.Caad005001.AdditionalFee3>||XmlElement()||
|+|SttlmSvc|ISO20022.Caad005001.SettlementService6||XmlElement()||
|+|Jursdctn|ISO20022.Caad005001.Jurisdiction2||XmlElement()||
|+|RcncltnTtls|List<ISO20022.Caad005001.TransactionTotals14>||XmlElement()||
|+|LifeCyclId|String||XmlElement()||
|+|RtrvlRefNb|String||XmlElement()||
|+|TrnsmssnDtTm|DateTime||XmlElement()||
|+|SysTracAudtNb|String||XmlElement()||
|+|Prgrmm|List<ISO20022.Caad005001.ProgrammeMode5>||XmlElement()||
|+|Dstn|ISO20022.Caad005001.PartyIdentification286||XmlElement()||
|+|Rcvr|ISO20022.Caad005001.PartyIdentification286||XmlElement()||
|+|Sndr|ISO20022.Caad005001.PartyIdentification286||XmlElement()||
|+|Orgtr|ISO20022.Caad005001.PartyIdentification286||XmlElement()||
|+|ReqdCcy|List<String>||XmlElement()||
|+|OthrRcncltnTp|String||XmlElement()||
|+|RcncltnTp|String||XmlElement()||
|+|OthrRcncltnActvtyTp|String||XmlElement()||
|+|RcncltnActvtyTp|String||XmlElement()||
|+|RcncltnFctn|String||XmlElement()||
|+|Hdr|ISO20022.Caad005001.Header71||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyTrlr),validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""PrtctdData""",PrtctdData),validElement(PrtctdData),validElement(PrcgRslt),validList("""AddtlData""",AddtlData),validElement(AddtlData),validElement(Rcncltn),validList("""AddtlFee""",AddtlFee),validElement(AddtlFee),validElement(SttlmSvc),validElement(Jursdctn),validList("""RcncltnTtls""",RcncltnTtls),validElement(RcncltnTtls),validPattern("""SysTracAudtNb""",SysTracAudtNb,"""[0-9]{1,12}"""),validList("""Prgrmm""",Prgrmm),validElement(Prgrmm),validElement(Dstn),validElement(Rcvr),validElement(Sndr),validElement(Orgtr),validPattern("""ReqdCcy""",ReqdCcy,"""[0-9]{3}"""),validElement(Hdr))|

