# seev.027.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev027001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Seev027001.AgentCAStandingInstructionStatusAdviceV01 {
        + StgInstrCxlReqSts  : ISO20022.Seev027001.StandingInstructionCancellationStatus1Choice
        + StgInstrReqSts  : ISO20022.Seev027001.StandingInstructionStatus1Choice
        + StgInstrGnlInf  : ISO20022.Seev027001.CorporateActionStandingInstructionGeneralInformation1
        + AgtCAStgInstrCxlReqId  : ISO20022.Seev027001.DocumentIdentification8
        + AgtCAStgInstrReqId  : ISO20022.Seev027001.DocumentIdentification8
        + Id  : ISO20022.Seev027001.DocumentIdentification8
    }
    ISO20022.Seev027001.AgentCAStandingInstructionStatusAdviceV01 *-- ISO20022.Seev027001.StandingInstructionCancellationStatus1Choice
    ISO20022.Seev027001.AgentCAStandingInstructionStatusAdviceV01 *-- ISO20022.Seev027001.StandingInstructionStatus1Choice
    ISO20022.Seev027001.AgentCAStandingInstructionStatusAdviceV01 *-- ISO20022.Seev027001.CorporateActionStandingInstructionGeneralInformation1
    ISO20022.Seev027001.AgentCAStandingInstructionStatusAdviceV01 *-- ISO20022.Seev027001.DocumentIdentification8
    ISO20022.Seev027001.AgentCAStandingInstructionStatusAdviceV01 *-- ISO20022.Seev027001.DocumentIdentification8
    ISO20022.Seev027001.AgentCAStandingInstructionStatusAdviceV01 *-- ISO20022.Seev027001.DocumentIdentification8
    class ISO20022.Seev027001.AlternateSecurityIdentification3 {
        + PrtryIdSrc  : String
        + DmstIdSrc  : String
        + Id  : String
    }
    class ISO20022.Seev027001.CorporateActionEventType2Code {
        OTHR = 1
        WTRC = 2
        WRTH = 3
        TREC = 4
        TEND = 5
        SUSP = 6
        SPLR = 7
        SPLF = 8
        SOFF = 9
        SMAL = 10
        SHPR = 11
        RHTS = 12
        RHDI = 13
        REMK = 14
        REDO = 15
        REDM = 16
        PRIO = 17
        PRII = 18
        PRED = 19
        PPMT = 20
        PLAC = 21
        PINK = 22
        PDEF = 23
        PCAL = 24
        PARI = 25
        ODLT = 26
        MRGR = 27
        MCAL = 28
        LIQU = 29
        INTR = 30
        INCR = 31
        EXWA = 32
        EXTM = 33
        EXRI = 34
        EXOF = 35
        DVSE = 36
        DVSC = 37
        DVOP = 38
        DVCA = 39
        DTCH = 40
        DSCL = 41
        DRIP = 42
        DRAW = 43
        DLST = 44
        DFLT = 45
        DETI = 46
        DECR = 47
        COOP = 48
        CONV = 49
        CONS = 50
        CLSA = 51
        CHAN = 52
        CERT = 53
        CAPI = 54
        CAPG = 55
        BRUP = 56
        BPUT = 57
        BONU = 58
        BIDS = 59
        ATTI = 60
        ACTV = 61
    }
    class ISO20022.Seev027001.CorporateActionEventType2FormatChoice {
        + Prtry  : ISO20022.Seev027001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev027001.CorporateActionEventType2FormatChoice *-- ISO20022.Seev027001.GenericIdentification13
    class ISO20022.Seev027001.CorporateActionStandingInstructionCancellationProcessingStatus1 {
        + AddtlInf  : String
        + Sts  : ISO20022.Seev027001.ProcessedStatus4FormatChoice
    }
    ISO20022.Seev027001.CorporateActionStandingInstructionCancellationProcessingStatus1 *-- ISO20022.Seev027001.ProcessedStatus4FormatChoice
    class ISO20022.Seev027001.CorporateActionStandingInstructionCancellationRejectionStatus1 {
        + AddtlInf  : String
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev027001.RejectionReason10FormatChoice~
    }
    ISO20022.Seev027001.CorporateActionStandingInstructionCancellationRejectionStatus1 *-- ISO20022.Seev027001.RejectionReason10FormatChoice
    class ISO20022.Seev027001.CorporateActionStandingInstructionGeneralInformation1 {
        + UndrlygScty  : ISO20022.Seev027001.FinancialInstrumentDescription3
        + AcctDtls  : global::System.Collections.Generic.List~ISO20022.Seev027001.IncludedAccount1~
        + ClntStgInstrId  : String
        + InstgPtyId  : ISO20022.Seev027001.PartyIdentification2Choice
        + EvtTp  : global::System.Collections.Generic.List~ISO20022.Seev027001.CorporateActionEventType2FormatChoice~
        + StgInstrTp  : String
    }
    ISO20022.Seev027001.CorporateActionStandingInstructionGeneralInformation1 *-- ISO20022.Seev027001.FinancialInstrumentDescription3
    ISO20022.Seev027001.CorporateActionStandingInstructionGeneralInformation1 *-- ISO20022.Seev027001.IncludedAccount1
    ISO20022.Seev027001.CorporateActionStandingInstructionGeneralInformation1 *-- ISO20022.Seev027001.PartyIdentification2Choice
    ISO20022.Seev027001.CorporateActionStandingInstructionGeneralInformation1 *-- ISO20022.Seev027001.CorporateActionEventType2FormatChoice
    class ISO20022.Seev027001.CorporateActionStandingInstructionProcessingStatus1 {
        + AddtlInf  : String
        + Sts  : ISO20022.Seev027001.ProcessedStatus3FormatChoice
    }
    ISO20022.Seev027001.CorporateActionStandingInstructionProcessingStatus1 *-- ISO20022.Seev027001.ProcessedStatus3FormatChoice
    class ISO20022.Seev027001.CorporateActionStandingInstructionRejectionStatus1 {
        + AddtlInf  : String
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev027001.RejectionReason20FormatChoice~
    }
    ISO20022.Seev027001.CorporateActionStandingInstructionRejectionStatus1 *-- ISO20022.Seev027001.RejectionReason20FormatChoice
    class ISO20022.Seev027001.DocumentIdentification8 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Seev027001.FinancialInstrumentDescription3 {
        + SfkpgPlc  : ISO20022.Seev027001.PartyIdentification2Choice
        + PlcOfListg  : String
        + SctyId  : ISO20022.Seev027001.SecurityIdentification7
    }
    ISO20022.Seev027001.FinancialInstrumentDescription3 *-- ISO20022.Seev027001.PartyIdentification2Choice
    ISO20022.Seev027001.FinancialInstrumentDescription3 *-- ISO20022.Seev027001.SecurityIdentification7
    class ISO20022.Seev027001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Seev027001.GenericIdentification13 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Seev027001.IncludedAccount1 {
        + InclInd  : String
        + SctiesAcctId  : String
    }
    class ISO20022.Seev027001.NameAndAddress5 {
        + Adr  : ISO20022.Seev027001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Seev027001.NameAndAddress5 *-- ISO20022.Seev027001.PostalAddress1
    class ISO20022.Seev027001.PartyIdentification2Choice {
        + NmAndAdr  : ISO20022.Seev027001.NameAndAddress5
        + PrtryId  : ISO20022.Seev027001.GenericIdentification1
        + BICOrBEI  : String
    }
    ISO20022.Seev027001.PartyIdentification2Choice *-- ISO20022.Seev027001.NameAndAddress5
    ISO20022.Seev027001.PartyIdentification2Choice *-- ISO20022.Seev027001.GenericIdentification1
    class ISO20022.Seev027001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Seev027001.ProcessedStatus3Code {
        PACK = 1
        PEND = 2
        RECE = 3
    }
    class ISO20022.Seev027001.ProcessedStatus3FormatChoice {
        + Prtry  : ISO20022.Seev027001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev027001.ProcessedStatus3FormatChoice *-- ISO20022.Seev027001.GenericIdentification13
    class ISO20022.Seev027001.ProcessedStatus4Code {
        PEND = 1
        COMP = 2
        RECE = 3
    }
    class ISO20022.Seev027001.ProcessedStatus4FormatChoice {
        + Prtry  : ISO20022.Seev027001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev027001.ProcessedStatus4FormatChoice *-- ISO20022.Seev027001.GenericIdentification13
    class ISO20022.Seev027001.RejectionReason10Code {
        FAIL = 1
    }
    class ISO20022.Seev027001.RejectionReason10FormatChoice {
        + Prtry  : ISO20022.Seev027001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev027001.RejectionReason10FormatChoice *-- ISO20022.Seev027001.GenericIdentification13
    class ISO20022.Seev027001.RejectionReason20Code {
        NOHO = 1
        STAN = 2
        CORR = 3
        CASA = 4
        FAIL = 5
    }
    class ISO20022.Seev027001.RejectionReason20FormatChoice {
        + Prtry  : ISO20022.Seev027001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev027001.RejectionReason20FormatChoice *-- ISO20022.Seev027001.GenericIdentification13
    class ISO20022.Seev027001.SecurityIdentification7 {
        + Desc  : String
        + OthrId  : ISO20022.Seev027001.AlternateSecurityIdentification3
        + ISIN  : String
    }
    ISO20022.Seev027001.SecurityIdentification7 *-- ISO20022.Seev027001.AlternateSecurityIdentification3
    class ISO20022.Seev027001.StandingInstructionCancellationStatus1Choice {
        + RjctdSts  : ISO20022.Seev027001.CorporateActionStandingInstructionCancellationRejectionStatus1
        + PrcdSts  : ISO20022.Seev027001.CorporateActionStandingInstructionCancellationProcessingStatus1
    }
    ISO20022.Seev027001.StandingInstructionCancellationStatus1Choice *-- ISO20022.Seev027001.CorporateActionStandingInstructionCancellationRejectionStatus1
    ISO20022.Seev027001.StandingInstructionCancellationStatus1Choice *-- ISO20022.Seev027001.CorporateActionStandingInstructionCancellationProcessingStatus1
    class ISO20022.Seev027001.StandingInstructionStatus1Choice {
        + RjctdSts  : ISO20022.Seev027001.CorporateActionStandingInstructionRejectionStatus1
        + PrcdSts  : ISO20022.Seev027001.CorporateActionStandingInstructionProcessingStatus1
    }
    ISO20022.Seev027001.StandingInstructionStatus1Choice *-- ISO20022.Seev027001.CorporateActionStandingInstructionRejectionStatus1
    ISO20022.Seev027001.StandingInstructionStatus1Choice *-- ISO20022.Seev027001.CorporateActionStandingInstructionProcessingStatus1
    class ISO20022.Seev027001.StandingInstructionType1Code {
        SECU = 1
        PAYM = 2
        CASH = 3
    }
    class Hiperspace.Node {
        # SKey  : String
        + TypeName  : String
        + Name  : String
        + Froms (From = this) : Hiperspace.Edge
        + Tos (To = this) : Hiperspace.Edge
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## View Hiperspace.Edge
edge between nodes

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Hiperspace.Node||||
|#|To|Hiperspace.Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## Enum ISO20022.Seev027001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Aspect ISO20022.Seev027001.AgentCAStandingInstructionStatusAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StgInstrCxlReqSts|ISO20022.Seev027001.StandingInstructionCancellationStatus1Choice||XmlElement()||
|+|StgInstrReqSts|ISO20022.Seev027001.StandingInstructionStatus1Choice||XmlElement()||
|+|StgInstrGnlInf|ISO20022.Seev027001.CorporateActionStandingInstructionGeneralInformation1||XmlElement()||
|+|AgtCAStgInstrCxlReqId|ISO20022.Seev027001.DocumentIdentification8||XmlElement()||
|+|AgtCAStgInstrReqId|ISO20022.Seev027001.DocumentIdentification8||XmlElement()||
|+|Id|ISO20022.Seev027001.DocumentIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StgInstrCxlReqSts),validElement(StgInstrReqSts),validElement(StgInstrGnlInf),validElement(AgtCAStgInstrCxlReqId),validElement(AgtCAStgInstrReqId),validElement(Id),validChoice(StgInstrCxlReqSts,StgInstrReqSts,StgInstrGnlInf,AgtCAStgInstrCxlReqId,AgtCAStgInstrReqId,Id))|

---

## Value ISO20022.Seev027001.AlternateSecurityIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryIdSrc|String||XmlElement()||
|+|DmstIdSrc|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DmstIdSrc""",DmstIdSrc,"""[A-Z]{2,2}"""),validChoice(PrtryIdSrc,DmstIdSrc,Id))|

---

## Enum ISO20022.Seev027001.CorporateActionEventType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||WTRC|Int32||XmlEnum("""WTRC""")|2|
||WRTH|Int32||XmlEnum("""WRTH""")|3|
||TREC|Int32||XmlEnum("""TREC""")|4|
||TEND|Int32||XmlEnum("""TEND""")|5|
||SUSP|Int32||XmlEnum("""SUSP""")|6|
||SPLR|Int32||XmlEnum("""SPLR""")|7|
||SPLF|Int32||XmlEnum("""SPLF""")|8|
||SOFF|Int32||XmlEnum("""SOFF""")|9|
||SMAL|Int32||XmlEnum("""SMAL""")|10|
||SHPR|Int32||XmlEnum("""SHPR""")|11|
||RHTS|Int32||XmlEnum("""RHTS""")|12|
||RHDI|Int32||XmlEnum("""RHDI""")|13|
||REMK|Int32||XmlEnum("""REMK""")|14|
||REDO|Int32||XmlEnum("""REDO""")|15|
||REDM|Int32||XmlEnum("""REDM""")|16|
||PRIO|Int32||XmlEnum("""PRIO""")|17|
||PRII|Int32||XmlEnum("""PRII""")|18|
||PRED|Int32||XmlEnum("""PRED""")|19|
||PPMT|Int32||XmlEnum("""PPMT""")|20|
||PLAC|Int32||XmlEnum("""PLAC""")|21|
||PINK|Int32||XmlEnum("""PINK""")|22|
||PDEF|Int32||XmlEnum("""PDEF""")|23|
||PCAL|Int32||XmlEnum("""PCAL""")|24|
||PARI|Int32||XmlEnum("""PARI""")|25|
||ODLT|Int32||XmlEnum("""ODLT""")|26|
||MRGR|Int32||XmlEnum("""MRGR""")|27|
||MCAL|Int32||XmlEnum("""MCAL""")|28|
||LIQU|Int32||XmlEnum("""LIQU""")|29|
||INTR|Int32||XmlEnum("""INTR""")|30|
||INCR|Int32||XmlEnum("""INCR""")|31|
||EXWA|Int32||XmlEnum("""EXWA""")|32|
||EXTM|Int32||XmlEnum("""EXTM""")|33|
||EXRI|Int32||XmlEnum("""EXRI""")|34|
||EXOF|Int32||XmlEnum("""EXOF""")|35|
||DVSE|Int32||XmlEnum("""DVSE""")|36|
||DVSC|Int32||XmlEnum("""DVSC""")|37|
||DVOP|Int32||XmlEnum("""DVOP""")|38|
||DVCA|Int32||XmlEnum("""DVCA""")|39|
||DTCH|Int32||XmlEnum("""DTCH""")|40|
||DSCL|Int32||XmlEnum("""DSCL""")|41|
||DRIP|Int32||XmlEnum("""DRIP""")|42|
||DRAW|Int32||XmlEnum("""DRAW""")|43|
||DLST|Int32||XmlEnum("""DLST""")|44|
||DFLT|Int32||XmlEnum("""DFLT""")|45|
||DETI|Int32||XmlEnum("""DETI""")|46|
||DECR|Int32||XmlEnum("""DECR""")|47|
||COOP|Int32||XmlEnum("""COOP""")|48|
||CONV|Int32||XmlEnum("""CONV""")|49|
||CONS|Int32||XmlEnum("""CONS""")|50|
||CLSA|Int32||XmlEnum("""CLSA""")|51|
||CHAN|Int32||XmlEnum("""CHAN""")|52|
||CERT|Int32||XmlEnum("""CERT""")|53|
||CAPI|Int32||XmlEnum("""CAPI""")|54|
||CAPG|Int32||XmlEnum("""CAPG""")|55|
||BRUP|Int32||XmlEnum("""BRUP""")|56|
||BPUT|Int32||XmlEnum("""BPUT""")|57|
||BONU|Int32||XmlEnum("""BONU""")|58|
||BIDS|Int32||XmlEnum("""BIDS""")|59|
||ATTI|Int32||XmlEnum("""ATTI""")|60|
||ACTV|Int32||XmlEnum("""ACTV""")|61|

---

## Value ISO20022.Seev027001.CorporateActionEventType2FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev027001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev027001.CorporateActionStandingInstructionCancellationProcessingStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Sts|ISO20022.Seev027001.ProcessedStatus4FormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sts))|

---

## Value ISO20022.Seev027001.CorporateActionStandingInstructionCancellationRejectionStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev027001.RejectionReason10FormatChoice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn))|

---

## Value ISO20022.Seev027001.CorporateActionStandingInstructionGeneralInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UndrlygScty|ISO20022.Seev027001.FinancialInstrumentDescription3||XmlElement()||
|+|AcctDtls|global::System.Collections.Generic.List<ISO20022.Seev027001.IncludedAccount1>||XmlElement()||
|+|ClntStgInstrId|String||XmlElement()||
|+|InstgPtyId|ISO20022.Seev027001.PartyIdentification2Choice||XmlElement()||
|+|EvtTp|global::System.Collections.Generic.List<ISO20022.Seev027001.CorporateActionEventType2FormatChoice>||XmlElement()||
|+|StgInstrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UndrlygScty),validList("""AcctDtls""",AcctDtls),validElement(AcctDtls),validElement(InstgPtyId),validList("""EvtTp""",EvtTp),validElement(EvtTp))|

---

## Value ISO20022.Seev027001.CorporateActionStandingInstructionProcessingStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Sts|ISO20022.Seev027001.ProcessedStatus3FormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sts))|

---

## Value ISO20022.Seev027001.CorporateActionStandingInstructionRejectionStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev027001.RejectionReason20FormatChoice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn))|

---

## Type ISO20022.Seev027001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AgtCAStgInstrStsAdvc|ISO20022.Seev027001.AgentCAStandingInstructionStatusAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AgtCAStgInstrStsAdvc))|

---

## Value ISO20022.Seev027001.DocumentIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev027001.FinancialInstrumentDescription3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgPlc|ISO20022.Seev027001.PartyIdentification2Choice||XmlElement()||
|+|PlcOfListg|String||XmlElement()||
|+|SctyId|ISO20022.Seev027001.SecurityIdentification7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SfkpgPlc),validPattern("""PlcOfListg""",PlcOfListg,"""[A-Z0-9]{4,4}"""),validElement(SctyId))|

---

## Value ISO20022.Seev027001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev027001.GenericIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Seev027001.IncludedAccount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InclInd|String||XmlElement()||
|+|SctiesAcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev027001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev027001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Seev027001.PartyIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Seev027001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Seev027001.GenericIdentification1||XmlElement()||
|+|BICOrBEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""BICOrBEI""",BICOrBEI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,BICOrBEI))|

---

## Value ISO20022.Seev027001.PostalAddress1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AdrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validListMax("""AdrLine""",AdrLine,5))|

---

## Enum ISO20022.Seev027001.ProcessedStatus3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PACK|Int32||XmlEnum("""PACK""")|1|
||PEND|Int32||XmlEnum("""PEND""")|2|
||RECE|Int32||XmlEnum("""RECE""")|3|

---

## Value ISO20022.Seev027001.ProcessedStatus3FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev027001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev027001.ProcessedStatus4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PEND|Int32||XmlEnum("""PEND""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|
||RECE|Int32||XmlEnum("""RECE""")|3|

---

## Value ISO20022.Seev027001.ProcessedStatus4FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev027001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev027001.RejectionReason10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FAIL|Int32||XmlEnum("""FAIL""")|1|

---

## Value ISO20022.Seev027001.RejectionReason10FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev027001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev027001.RejectionReason20Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOHO|Int32||XmlEnum("""NOHO""")|1|
||STAN|Int32||XmlEnum("""STAN""")|2|
||CORR|Int32||XmlEnum("""CORR""")|3|
||CASA|Int32||XmlEnum("""CASA""")|4|
||FAIL|Int32||XmlEnum("""FAIL""")|5|

---

## Value ISO20022.Seev027001.RejectionReason20FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev027001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev027001.SecurityIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|ISO20022.Seev027001.AlternateSecurityIdentification3||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z0-9]{12,12}"""),validChoice(Desc,OthrId,ISIN))|

---

## Value ISO20022.Seev027001.StandingInstructionCancellationStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RjctdSts|ISO20022.Seev027001.CorporateActionStandingInstructionCancellationRejectionStatus1||XmlElement()||
|+|PrcdSts|ISO20022.Seev027001.CorporateActionStandingInstructionCancellationProcessingStatus1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RjctdSts),validElement(PrcdSts),validChoice(RjctdSts,PrcdSts))|

---

## Value ISO20022.Seev027001.StandingInstructionStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RjctdSts|ISO20022.Seev027001.CorporateActionStandingInstructionRejectionStatus1||XmlElement()||
|+|PrcdSts|ISO20022.Seev027001.CorporateActionStandingInstructionProcessingStatus1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RjctdSts),validElement(PrcdSts),validChoice(RjctdSts,PrcdSts))|

---

## Enum ISO20022.Seev027001.StandingInstructionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SECU|Int32||XmlEnum("""SECU""")|1|
||PAYM|Int32||XmlEnum("""PAYM""")|2|
||CASH|Int32||XmlEnum("""CASH""")|3|

---

## View Hiperspace.Node
node in a graph view of data

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|SKey|String||||
|+|TypeName|String||||
|+|Name|String||||
||Froms|Hiperspace.Edge|||From = this|
||Tos|Hiperspace.Edge|||To = this|

