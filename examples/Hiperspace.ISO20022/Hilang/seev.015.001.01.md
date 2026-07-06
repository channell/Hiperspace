# seev.015.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev015001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Seev015001.AgentCAElectionStatusAdviceV01 {
        + ElctnAmdmntReqSts  : ISO20022.Seev015001.ElectionAmendmentStatus1Choice
        + ElctnCxlReqSts  : ISO20022.Seev015001.ElectionCancellationStatus1Choice
        + ElctnAdvcSts  : ISO20022.Seev015001.ElectionAdviceStatus1Choice
        + CorpActnGnlInf  : ISO20022.Seev015001.CorporateActionInformation1
        + AgtCAElctnAmdmntReqId  : ISO20022.Seev015001.DocumentIdentification8
        + AgtCAElctnCxlReqId  : ISO20022.Seev015001.DocumentIdentification8
        + AgtCAElctnAdvcId  : ISO20022.Seev015001.DocumentIdentification8
        + Id  : ISO20022.Seev015001.DocumentIdentification8
    }
    ISO20022.Seev015001.AgentCAElectionStatusAdviceV01 *-- ISO20022.Seev015001.ElectionAmendmentStatus1Choice
    ISO20022.Seev015001.AgentCAElectionStatusAdviceV01 *-- ISO20022.Seev015001.ElectionCancellationStatus1Choice
    ISO20022.Seev015001.AgentCAElectionStatusAdviceV01 *-- ISO20022.Seev015001.ElectionAdviceStatus1Choice
    ISO20022.Seev015001.AgentCAElectionStatusAdviceV01 *-- ISO20022.Seev015001.CorporateActionInformation1
    ISO20022.Seev015001.AgentCAElectionStatusAdviceV01 *-- ISO20022.Seev015001.DocumentIdentification8
    ISO20022.Seev015001.AgentCAElectionStatusAdviceV01 *-- ISO20022.Seev015001.DocumentIdentification8
    ISO20022.Seev015001.AgentCAElectionStatusAdviceV01 *-- ISO20022.Seev015001.DocumentIdentification8
    ISO20022.Seev015001.AgentCAElectionStatusAdviceV01 *-- ISO20022.Seev015001.DocumentIdentification8
    class ISO20022.Seev015001.AlternateSecurityIdentification3 {
        + PrtryIdSrc  : String
        + DmstIdSrc  : String
        + Id  : String
    }
    class ISO20022.Seev015001.CorporateActionAmendmentProcessingStatus1 {
        + AddtlInf  : String
        + Sts  : ISO20022.Seev015001.ProcessedStatus5FormatChoice
    }
    ISO20022.Seev015001.CorporateActionAmendmentProcessingStatus1 *-- ISO20022.Seev015001.ProcessedStatus5FormatChoice
    class ISO20022.Seev015001.CorporateActionAmendmentRejectionStatus1 {
        + AddtlInf  : String
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev015001.RejectionReason8FormatChoice~
    }
    ISO20022.Seev015001.CorporateActionAmendmentRejectionStatus1 *-- ISO20022.Seev015001.RejectionReason8FormatChoice
    class ISO20022.Seev015001.CorporateActionCancellationProcessingStatus1 {
        + AddtlInf  : String
        + Sts  : ISO20022.Seev015001.ProcessedStatus5FormatChoice
    }
    ISO20022.Seev015001.CorporateActionCancellationProcessingStatus1 *-- ISO20022.Seev015001.ProcessedStatus5FormatChoice
    class ISO20022.Seev015001.CorporateActionCancellationRejectionStatus1 {
        + AddtlInf  : String
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev015001.RejectionReason9FormatChoice~
    }
    ISO20022.Seev015001.CorporateActionCancellationRejectionStatus1 *-- ISO20022.Seev015001.RejectionReason9FormatChoice
    class ISO20022.Seev015001.CorporateActionEventProcessingType1Code {
        REOR = 1
        DISN = 2
        GENL = 3
    }
    class ISO20022.Seev015001.CorporateActionEventProcessingType1FormatChoice {
        + Prtry  : ISO20022.Seev015001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev015001.CorporateActionEventProcessingType1FormatChoice *-- ISO20022.Seev015001.GenericIdentification13
    class ISO20022.Seev015001.CorporateActionEventType2Code {
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
    class ISO20022.Seev015001.CorporateActionEventType2FormatChoice {
        + Prtry  : ISO20022.Seev015001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev015001.CorporateActionEventType2FormatChoice *-- ISO20022.Seev015001.GenericIdentification13
    class ISO20022.Seev015001.CorporateActionInformation1 {
        + UndrlygScty  : ISO20022.Seev015001.FinancialInstrumentDescription3
        + EvtPrcgTp  : ISO20022.Seev015001.CorporateActionEventProcessingType1FormatChoice
        + MndtryVlntryEvtTp  : ISO20022.Seev015001.CorporateActionMandatoryVoluntary1FormatChoice
        + EvtTp  : ISO20022.Seev015001.CorporateActionEventType2FormatChoice
        + CorpActnPrcgId  : String
        + IssrCorpActnId  : String
        + AgtId  : ISO20022.Seev015001.PartyIdentification2Choice
    }
    ISO20022.Seev015001.CorporateActionInformation1 *-- ISO20022.Seev015001.FinancialInstrumentDescription3
    ISO20022.Seev015001.CorporateActionInformation1 *-- ISO20022.Seev015001.CorporateActionEventProcessingType1FormatChoice
    ISO20022.Seev015001.CorporateActionInformation1 *-- ISO20022.Seev015001.CorporateActionMandatoryVoluntary1FormatChoice
    ISO20022.Seev015001.CorporateActionInformation1 *-- ISO20022.Seev015001.CorporateActionEventType2FormatChoice
    ISO20022.Seev015001.CorporateActionInformation1 *-- ISO20022.Seev015001.PartyIdentification2Choice
    class ISO20022.Seev015001.CorporateActionInstructionProcessingStatus1 {
        + AddtlInf  : String
        + Sts  : ISO20022.Seev015001.ProcessedStatus3FormatChoice
    }
    ISO20022.Seev015001.CorporateActionInstructionProcessingStatus1 *-- ISO20022.Seev015001.ProcessedStatus3FormatChoice
    class ISO20022.Seev015001.CorporateActionInstructionRejectionStatus1 {
        + AddtlInf  : String
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev015001.RejectionReason18FormatChoice~
    }
    ISO20022.Seev015001.CorporateActionInstructionRejectionStatus1 *-- ISO20022.Seev015001.RejectionReason18FormatChoice
    class ISO20022.Seev015001.CorporateActionMandatoryVoluntary1Code {
        VOLU = 1
        CHOS = 2
        MAND = 3
    }
    class ISO20022.Seev015001.CorporateActionMandatoryVoluntary1FormatChoice {
        + Prtry  : ISO20022.Seev015001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev015001.CorporateActionMandatoryVoluntary1FormatChoice *-- ISO20022.Seev015001.GenericIdentification13
    class ISO20022.Seev015001.DocumentIdentification8 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Seev015001.ElectionAdviceStatus1Choice {
        + RjctdSts  : ISO20022.Seev015001.CorporateActionInstructionRejectionStatus1
        + PrcdSts  : ISO20022.Seev015001.CorporateActionInstructionProcessingStatus1
    }
    ISO20022.Seev015001.ElectionAdviceStatus1Choice *-- ISO20022.Seev015001.CorporateActionInstructionRejectionStatus1
    ISO20022.Seev015001.ElectionAdviceStatus1Choice *-- ISO20022.Seev015001.CorporateActionInstructionProcessingStatus1
    class ISO20022.Seev015001.ElectionAmendmentStatus1Choice {
        + RjctdSts  : ISO20022.Seev015001.CorporateActionAmendmentRejectionStatus1
        + PrcdSts  : ISO20022.Seev015001.CorporateActionAmendmentProcessingStatus1
    }
    ISO20022.Seev015001.ElectionAmendmentStatus1Choice *-- ISO20022.Seev015001.CorporateActionAmendmentRejectionStatus1
    ISO20022.Seev015001.ElectionAmendmentStatus1Choice *-- ISO20022.Seev015001.CorporateActionAmendmentProcessingStatus1
    class ISO20022.Seev015001.ElectionCancellationStatus1Choice {
        + RjctdSts  : ISO20022.Seev015001.CorporateActionCancellationRejectionStatus1
        + PrcdSts  : ISO20022.Seev015001.CorporateActionCancellationProcessingStatus1
    }
    ISO20022.Seev015001.ElectionCancellationStatus1Choice *-- ISO20022.Seev015001.CorporateActionCancellationRejectionStatus1
    ISO20022.Seev015001.ElectionCancellationStatus1Choice *-- ISO20022.Seev015001.CorporateActionCancellationProcessingStatus1
    class ISO20022.Seev015001.FinancialInstrumentDescription3 {
        + SfkpgPlc  : ISO20022.Seev015001.PartyIdentification2Choice
        + PlcOfListg  : String
        + SctyId  : ISO20022.Seev015001.SecurityIdentification7
    }
    ISO20022.Seev015001.FinancialInstrumentDescription3 *-- ISO20022.Seev015001.PartyIdentification2Choice
    ISO20022.Seev015001.FinancialInstrumentDescription3 *-- ISO20022.Seev015001.SecurityIdentification7
    class ISO20022.Seev015001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Seev015001.GenericIdentification13 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Seev015001.NameAndAddress5 {
        + Adr  : ISO20022.Seev015001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Seev015001.NameAndAddress5 *-- ISO20022.Seev015001.PostalAddress1
    class ISO20022.Seev015001.PartyIdentification2Choice {
        + NmAndAdr  : ISO20022.Seev015001.NameAndAddress5
        + PrtryId  : ISO20022.Seev015001.GenericIdentification1
        + BICOrBEI  : String
    }
    ISO20022.Seev015001.PartyIdentification2Choice *-- ISO20022.Seev015001.NameAndAddress5
    ISO20022.Seev015001.PartyIdentification2Choice *-- ISO20022.Seev015001.GenericIdentification1
    class ISO20022.Seev015001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Seev015001.ProcessedStatus3Code {
        PACK = 1
        PEND = 2
        RECE = 3
    }
    class ISO20022.Seev015001.ProcessedStatus3FormatChoice {
        + Prtry  : ISO20022.Seev015001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev015001.ProcessedStatus3FormatChoice *-- ISO20022.Seev015001.GenericIdentification13
    class ISO20022.Seev015001.ProcessedStatus5Code {
        PACK = 1
        RECE = 2
    }
    class ISO20022.Seev015001.ProcessedStatus5FormatChoice {
        + Prtry  : ISO20022.Seev015001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev015001.ProcessedStatus5FormatChoice *-- ISO20022.Seev015001.GenericIdentification13
    class ISO20022.Seev015001.RejectionReason18Code {
        LATT = 1
        INHO = 2
        FAIL = 3
    }
    class ISO20022.Seev015001.RejectionReason18FormatChoice {
        + Prtry  : ISO20022.Seev015001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev015001.RejectionReason18FormatChoice *-- ISO20022.Seev015001.GenericIdentification13
    class ISO20022.Seev015001.RejectionReason8Code {
        FAIL = 1
        ELEC = 2
        LATT = 3
        NAMD = 4
    }
    class ISO20022.Seev015001.RejectionReason8FormatChoice {
        + Prtry  : ISO20022.Seev015001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev015001.RejectionReason8FormatChoice *-- ISO20022.Seev015001.GenericIdentification13
    class ISO20022.Seev015001.RejectionReason9Code {
        FAIL = 1
        ELEC = 2
        LATT = 3
        NCAN = 4
    }
    class ISO20022.Seev015001.RejectionReason9FormatChoice {
        + Prtry  : ISO20022.Seev015001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev015001.RejectionReason9FormatChoice *-- ISO20022.Seev015001.GenericIdentification13
    class ISO20022.Seev015001.SecurityIdentification7 {
        + Desc  : String
        + OthrId  : ISO20022.Seev015001.AlternateSecurityIdentification3
        + ISIN  : String
    }
    ISO20022.Seev015001.SecurityIdentification7 *-- ISO20022.Seev015001.AlternateSecurityIdentification3
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

## Enum ISO20022.Seev015001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Aspect ISO20022.Seev015001.AgentCAElectionStatusAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ElctnAmdmntReqSts|ISO20022.Seev015001.ElectionAmendmentStatus1Choice||XmlElement()||
|+|ElctnCxlReqSts|ISO20022.Seev015001.ElectionCancellationStatus1Choice||XmlElement()||
|+|ElctnAdvcSts|ISO20022.Seev015001.ElectionAdviceStatus1Choice||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev015001.CorporateActionInformation1||XmlElement()||
|+|AgtCAElctnAmdmntReqId|ISO20022.Seev015001.DocumentIdentification8||XmlElement()||
|+|AgtCAElctnCxlReqId|ISO20022.Seev015001.DocumentIdentification8||XmlElement()||
|+|AgtCAElctnAdvcId|ISO20022.Seev015001.DocumentIdentification8||XmlElement()||
|+|Id|ISO20022.Seev015001.DocumentIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ElctnAmdmntReqSts),validElement(ElctnCxlReqSts),validElement(ElctnAdvcSts),validElement(CorpActnGnlInf),validElement(AgtCAElctnAmdmntReqId),validElement(AgtCAElctnCxlReqId),validElement(AgtCAElctnAdvcId),validElement(Id),validChoice(ElctnAmdmntReqSts,ElctnCxlReqSts,ElctnAdvcSts,CorpActnGnlInf,AgtCAElctnAmdmntReqId,AgtCAElctnCxlReqId,AgtCAElctnAdvcId,Id))|

---

## Value ISO20022.Seev015001.AlternateSecurityIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryIdSrc|String||XmlElement()||
|+|DmstIdSrc|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DmstIdSrc""",DmstIdSrc,"""[A-Z]{2,2}"""),validChoice(PrtryIdSrc,DmstIdSrc,Id))|

---

## Value ISO20022.Seev015001.CorporateActionAmendmentProcessingStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Sts|ISO20022.Seev015001.ProcessedStatus5FormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sts))|

---

## Value ISO20022.Seev015001.CorporateActionAmendmentRejectionStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev015001.RejectionReason8FormatChoice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn))|

---

## Value ISO20022.Seev015001.CorporateActionCancellationProcessingStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Sts|ISO20022.Seev015001.ProcessedStatus5FormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sts))|

---

## Value ISO20022.Seev015001.CorporateActionCancellationRejectionStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev015001.RejectionReason9FormatChoice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn))|

---

## Enum ISO20022.Seev015001.CorporateActionEventProcessingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REOR|Int32||XmlEnum("""REOR""")|1|
||DISN|Int32||XmlEnum("""DISN""")|2|
||GENL|Int32||XmlEnum("""GENL""")|3|

---

## Value ISO20022.Seev015001.CorporateActionEventProcessingType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev015001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev015001.CorporateActionEventType2Code


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

## Value ISO20022.Seev015001.CorporateActionEventType2FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev015001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev015001.CorporateActionInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UndrlygScty|ISO20022.Seev015001.FinancialInstrumentDescription3||XmlElement()||
|+|EvtPrcgTp|ISO20022.Seev015001.CorporateActionEventProcessingType1FormatChoice||XmlElement()||
|+|MndtryVlntryEvtTp|ISO20022.Seev015001.CorporateActionMandatoryVoluntary1FormatChoice||XmlElement()||
|+|EvtTp|ISO20022.Seev015001.CorporateActionEventType2FormatChoice||XmlElement()||
|+|CorpActnPrcgId|String||XmlElement()||
|+|IssrCorpActnId|String||XmlElement()||
|+|AgtId|ISO20022.Seev015001.PartyIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UndrlygScty),validElement(EvtPrcgTp),validElement(MndtryVlntryEvtTp),validElement(EvtTp),validElement(AgtId))|

---

## Value ISO20022.Seev015001.CorporateActionInstructionProcessingStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Sts|ISO20022.Seev015001.ProcessedStatus3FormatChoice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sts))|

---

## Value ISO20022.Seev015001.CorporateActionInstructionRejectionStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev015001.RejectionReason18FormatChoice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn))|

---

## Enum ISO20022.Seev015001.CorporateActionMandatoryVoluntary1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VOLU|Int32||XmlEnum("""VOLU""")|1|
||CHOS|Int32||XmlEnum("""CHOS""")|2|
||MAND|Int32||XmlEnum("""MAND""")|3|

---

## Value ISO20022.Seev015001.CorporateActionMandatoryVoluntary1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev015001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Type ISO20022.Seev015001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AgtCAElctnStsAdvc|ISO20022.Seev015001.AgentCAElectionStatusAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AgtCAElctnStsAdvc))|

---

## Value ISO20022.Seev015001.DocumentIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev015001.ElectionAdviceStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RjctdSts|ISO20022.Seev015001.CorporateActionInstructionRejectionStatus1||XmlElement()||
|+|PrcdSts|ISO20022.Seev015001.CorporateActionInstructionProcessingStatus1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RjctdSts),validElement(PrcdSts),validChoice(RjctdSts,PrcdSts))|

---

## Value ISO20022.Seev015001.ElectionAmendmentStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RjctdSts|ISO20022.Seev015001.CorporateActionAmendmentRejectionStatus1||XmlElement()||
|+|PrcdSts|ISO20022.Seev015001.CorporateActionAmendmentProcessingStatus1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RjctdSts),validElement(PrcdSts),validChoice(RjctdSts,PrcdSts))|

---

## Value ISO20022.Seev015001.ElectionCancellationStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RjctdSts|ISO20022.Seev015001.CorporateActionCancellationRejectionStatus1||XmlElement()||
|+|PrcdSts|ISO20022.Seev015001.CorporateActionCancellationProcessingStatus1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RjctdSts),validElement(PrcdSts),validChoice(RjctdSts,PrcdSts))|

---

## Value ISO20022.Seev015001.FinancialInstrumentDescription3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgPlc|ISO20022.Seev015001.PartyIdentification2Choice||XmlElement()||
|+|PlcOfListg|String||XmlElement()||
|+|SctyId|ISO20022.Seev015001.SecurityIdentification7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SfkpgPlc),validPattern("""PlcOfListg""",PlcOfListg,"""[A-Z0-9]{4,4}"""),validElement(SctyId))|

---

## Value ISO20022.Seev015001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev015001.GenericIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Seev015001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev015001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Seev015001.PartyIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Seev015001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Seev015001.GenericIdentification1||XmlElement()||
|+|BICOrBEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""BICOrBEI""",BICOrBEI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,BICOrBEI))|

---

## Value ISO20022.Seev015001.PostalAddress1


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

## Enum ISO20022.Seev015001.ProcessedStatus3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PACK|Int32||XmlEnum("""PACK""")|1|
||PEND|Int32||XmlEnum("""PEND""")|2|
||RECE|Int32||XmlEnum("""RECE""")|3|

---

## Value ISO20022.Seev015001.ProcessedStatus3FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev015001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev015001.ProcessedStatus5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PACK|Int32||XmlEnum("""PACK""")|1|
||RECE|Int32||XmlEnum("""RECE""")|2|

---

## Value ISO20022.Seev015001.ProcessedStatus5FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev015001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev015001.RejectionReason18Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LATT|Int32||XmlEnum("""LATT""")|1|
||INHO|Int32||XmlEnum("""INHO""")|2|
||FAIL|Int32||XmlEnum("""FAIL""")|3|

---

## Value ISO20022.Seev015001.RejectionReason18FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev015001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev015001.RejectionReason8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FAIL|Int32||XmlEnum("""FAIL""")|1|
||ELEC|Int32||XmlEnum("""ELEC""")|2|
||LATT|Int32||XmlEnum("""LATT""")|3|
||NAMD|Int32||XmlEnum("""NAMD""")|4|

---

## Value ISO20022.Seev015001.RejectionReason8FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev015001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev015001.RejectionReason9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FAIL|Int32||XmlEnum("""FAIL""")|1|
||ELEC|Int32||XmlEnum("""ELEC""")|2|
||LATT|Int32||XmlEnum("""LATT""")|3|
||NCAN|Int32||XmlEnum("""NCAN""")|4|

---

## Value ISO20022.Seev015001.RejectionReason9FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev015001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev015001.SecurityIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|ISO20022.Seev015001.AlternateSecurityIdentification3||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z0-9]{12,12}"""),validChoice(Desc,OthrId,ISIN))|

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

