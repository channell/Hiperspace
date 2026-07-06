# seev.033.001.13-physical
```mermaid
classDiagram
    class ISO20022.Seev033001.Document {
        # Uri  : String
        + CorpActnInstr () : ISO20022.Seev033001.CorporateActionInstructionV13
        + Validation () = validation(validElement(CorpActnInstr))
    }
    class ISO20022.Seev033001.CorporateActionInstructionV13 {
        # owner  : ISO20022.Seev033001.Document
        + SplmtryData  : List~ISO20022.Seev033001.SupplementaryData1~
        + AddtlInf  : ISO20022.Seev033001.CorporateActionNarrative30
        + PrtctInstr  : ISO20022.Seev033001.ProtectInstruction1
        + CorpActnInstr  : ISO20022.Seev033001.CorporateActionOption237
        + BnfclOwnrDtls  : List~ISO20022.Seev033001.PartyIdentification313~
        + AcctDtls  : ISO20022.Seev033001.AccountAndBalance61
        + CorpActnGnlInf  : ISO20022.Seev033001.CorporateActionGeneralInformation180
        + EvtsLkg  : List~ISO20022.Seev033001.CorporateActionEventReference3~
        + OthrDocId  : List~ISO20022.Seev033001.DocumentIdentification32~
        + InstrCxlReqId  : ISO20022.Seev033001.DocumentIdentification31
        + CancInstrId  : ISO20022.Seev033001.DocumentIdentification31
        + ChngInstrInd  : String
        + Validation () = validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AddtlInf),validElement(PrtctInstr),validElement(CorpActnInstr),validList("""BnfclOwnrDtls""",BnfclOwnrDtls),validElement(BnfclOwnrDtls),validElement(AcctDtls),validElement(CorpActnGnlInf),validList("""EvtsLkg""",EvtsLkg),validElement(EvtsLkg),validList("""OthrDocId""",OthrDocId),validElement(OthrDocId),validElement(InstrCxlReqId),validElement(CancInstrId))
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl ISO20022.Seev033001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Uri|String||XmlIgnore(), JsonIgnore()||
|+|CorpActnInstr|ISO20022.Seev033001.CorporateActionInstructionV13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnInstr))|

---

## AspectImpl ISO20022.Seev033001.CorporateActionInstructionV13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|ISO20022.Seev033001.Document||||
|+|SplmtryData|List<ISO20022.Seev033001.SupplementaryData1>||XmlElement()||
|+|AddtlInf|ISO20022.Seev033001.CorporateActionNarrative30||XmlElement()||
|+|PrtctInstr|ISO20022.Seev033001.ProtectInstruction1||XmlElement()||
|+|CorpActnInstr|ISO20022.Seev033001.CorporateActionOption237||XmlElement()||
|+|BnfclOwnrDtls|List<ISO20022.Seev033001.PartyIdentification313>||XmlElement()||
|+|AcctDtls|ISO20022.Seev033001.AccountAndBalance61||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev033001.CorporateActionGeneralInformation180||XmlElement()||
|+|EvtsLkg|List<ISO20022.Seev033001.CorporateActionEventReference3>||XmlElement()||
|+|OthrDocId|List<ISO20022.Seev033001.DocumentIdentification32>||XmlElement()||
|+|InstrCxlReqId|ISO20022.Seev033001.DocumentIdentification31||XmlElement()||
|+|CancInstrId|ISO20022.Seev033001.DocumentIdentification31||XmlElement()||
|+|ChngInstrInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AddtlInf),validElement(PrtctInstr),validElement(CorpActnInstr),validList("""BnfclOwnrDtls""",BnfclOwnrDtls),validElement(BnfclOwnrDtls),validElement(AcctDtls),validElement(CorpActnGnlInf),validList("""EvtsLkg""",EvtsLkg),validElement(EvtsLkg),validList("""OthrDocId""",OthrDocId),validElement(OthrDocId),validElement(InstrCxlReqId),validElement(CancInstrId))|

