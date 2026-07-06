# seev.039.001.13
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev039001.AccountIdentification10 {
        + IdCd  : String
    }
    class ISO20022.Seev039001.AccountIdentification69 {
        + SfkpgPlc  : ISO20022.Seev039001.SafekeepingPlaceFormat42Choice
        + AcctOwnr  : ISO20022.Seev039001.PartyIdentification127Choice
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
    }
    ISO20022.Seev039001.AccountIdentification69 *-- ISO20022.Seev039001.SafekeepingPlaceFormat42Choice
    ISO20022.Seev039001.AccountIdentification69 *-- ISO20022.Seev039001.PartyIdentification127Choice
    class ISO20022.Seev039001.AccountIdentification73Choice {
        + AcctsList  : global::System.Collections.Generic.List~ISO20022.Seev039001.AccountIdentification69~
        + ForAllAccts  : ISO20022.Seev039001.AccountIdentification10
    }
    ISO20022.Seev039001.AccountIdentification73Choice *-- ISO20022.Seev039001.AccountIdentification69
    ISO20022.Seev039001.AccountIdentification73Choice *-- ISO20022.Seev039001.AccountIdentification10
    class ISO20022.Seev039001.AdditionalBusinessProcess8Code {
        PPRE = 1
        PPUT = 2
        FPRE = 3
        CONS = 4
    }
    class ISO20022.Seev039001.AdditionalBusinessProcessFormat15Choice {
        + Prtry  : ISO20022.Seev039001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev039001.AdditionalBusinessProcessFormat15Choice *-- ISO20022.Seev039001.GenericIdentification30
    class ISO20022.Seev039001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Seev039001.CorporateAction72 {
        + LtryTp  : ISO20022.Seev039001.LotteryTypeFormat4Choice
        + AddtlBizPrcInd  : global::System.Collections.Generic.List~ISO20022.Seev039001.AdditionalBusinessProcessFormat15Choice~
        + EvtStag  : ISO20022.Seev039001.CorporateActionEventStageFormat14Choice
        + DtDtls  : ISO20022.Seev039001.CorporateActionDate86
    }
    ISO20022.Seev039001.CorporateAction72 *-- ISO20022.Seev039001.LotteryTypeFormat4Choice
    ISO20022.Seev039001.CorporateAction72 *-- ISO20022.Seev039001.AdditionalBusinessProcessFormat15Choice
    ISO20022.Seev039001.CorporateAction72 *-- ISO20022.Seev039001.CorporateActionEventStageFormat14Choice
    ISO20022.Seev039001.CorporateAction72 *-- ISO20022.Seev039001.CorporateActionDate86
    class ISO20022.Seev039001.CorporateActionCancellation3 {
        + PrcgSts  : ISO20022.Seev039001.CorporateActionEventStatus1
        + CxlRsn  : String
        + CxlRsnCd  : String
    }
    ISO20022.Seev039001.CorporateActionCancellation3 *-- ISO20022.Seev039001.CorporateActionEventStatus1
    class ISO20022.Seev039001.CorporateActionCancellationAdviceV13 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev039001.SupplementaryData1~
        + InfAgt  : ISO20022.Seev039001.PartyIdentification120Choice
        + SlctnAgt  : global::System.Collections.Generic.List~ISO20022.Seev039001.PartyIdentification120Choice~
        + DrpAgt  : ISO20022.Seev039001.PartyIdentification120Choice
        + PhysSctiesAgt  : ISO20022.Seev039001.PartyIdentification120Choice
        + RsellngAgt  : global::System.Collections.Generic.List~ISO20022.Seev039001.PartyIdentification120Choice~
        + Regar  : ISO20022.Seev039001.PartyIdentification120Choice
        + SubPngAgt  : global::System.Collections.Generic.List~ISO20022.Seev039001.PartyIdentification120Choice~
        + PngAgt  : global::System.Collections.Generic.List~ISO20022.Seev039001.PartyIdentification120Choice~
        + IssrAgt  : global::System.Collections.Generic.List~ISO20022.Seev039001.PartyIdentification120Choice~
        + AddtlTxt  : global::System.Collections.Generic.List~String~
        + CorpActnDtls  : ISO20022.Seev039001.CorporateAction72
        + AcctsDtls  : ISO20022.Seev039001.AccountIdentification73Choice
        + CorpActnGnlInf  : ISO20022.Seev039001.CorporateActionGeneralInformation174
        + CxlAdvcGnlInf  : ISO20022.Seev039001.CorporateActionCancellation3
    }
    ISO20022.Seev039001.CorporateActionCancellationAdviceV13 *-- ISO20022.Seev039001.SupplementaryData1
    ISO20022.Seev039001.CorporateActionCancellationAdviceV13 *-- ISO20022.Seev039001.PartyIdentification120Choice
    ISO20022.Seev039001.CorporateActionCancellationAdviceV13 *-- ISO20022.Seev039001.PartyIdentification120Choice
    ISO20022.Seev039001.CorporateActionCancellationAdviceV13 *-- ISO20022.Seev039001.PartyIdentification120Choice
    ISO20022.Seev039001.CorporateActionCancellationAdviceV13 *-- ISO20022.Seev039001.PartyIdentification120Choice
    ISO20022.Seev039001.CorporateActionCancellationAdviceV13 *-- ISO20022.Seev039001.PartyIdentification120Choice
    ISO20022.Seev039001.CorporateActionCancellationAdviceV13 *-- ISO20022.Seev039001.PartyIdentification120Choice
    ISO20022.Seev039001.CorporateActionCancellationAdviceV13 *-- ISO20022.Seev039001.PartyIdentification120Choice
    ISO20022.Seev039001.CorporateActionCancellationAdviceV13 *-- ISO20022.Seev039001.PartyIdentification120Choice
    ISO20022.Seev039001.CorporateActionCancellationAdviceV13 *-- ISO20022.Seev039001.PartyIdentification120Choice
    ISO20022.Seev039001.CorporateActionCancellationAdviceV13 *-- ISO20022.Seev039001.CorporateAction72
    ISO20022.Seev039001.CorporateActionCancellationAdviceV13 *-- ISO20022.Seev039001.AccountIdentification73Choice
    ISO20022.Seev039001.CorporateActionCancellationAdviceV13 *-- ISO20022.Seev039001.CorporateActionGeneralInformation174
    ISO20022.Seev039001.CorporateActionCancellationAdviceV13 *-- ISO20022.Seev039001.CorporateActionCancellation3
    class ISO20022.Seev039001.CorporateActionCancellationReason1Code {
        PROC = 1
        WITH = 2
    }
    class ISO20022.Seev039001.CorporateActionDate86 {
        + ExDvddDt  : ISO20022.Seev039001.DateFormat30Choice
        + RcrdDt  : ISO20022.Seev039001.DateFormat30Choice
    }
    ISO20022.Seev039001.CorporateActionDate86 *-- ISO20022.Seev039001.DateFormat30Choice
    ISO20022.Seev039001.CorporateActionDate86 *-- ISO20022.Seev039001.DateFormat30Choice
    class ISO20022.Seev039001.CorporateActionEventStage4Code {
        RESC = 1
        PART = 2
        FULL = 3
    }
    class ISO20022.Seev039001.CorporateActionEventStageFormat14Choice {
        + Prtry  : ISO20022.Seev039001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev039001.CorporateActionEventStageFormat14Choice *-- ISO20022.Seev039001.GenericIdentification30
    class ISO20022.Seev039001.CorporateActionEventStatus1 {
        + EvtConfSts  : String
        + EvtCmpltnsSts  : String
    }
    class ISO20022.Seev039001.CorporateActionEventType107Choice {
        + Prtry  : ISO20022.Seev039001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev039001.CorporateActionEventType107Choice *-- ISO20022.Seev039001.GenericIdentification30
    class ISO20022.Seev039001.CorporateActionEventType35Code {
        RCLA = 1
        TNDP = 2
        INFO = 3
        ACCU = 4
        WRTH = 5
        WTRC = 6
        EXWA = 7
        SUSP = 8
        DLST = 9
        TEND = 10
        TREC = 11
        SPLF = 12
        DVSE = 13
        SOFF = 14
        SMAL = 15
        SHPR = 16
        DVSC = 17
        RHTS = 18
        SPLR = 19
        BIDS = 20
        REMK = 21
        REDO = 22
        BPUT = 23
        PRIO = 24
        PDEF = 25
        PLAC = 26
        PINK = 27
        PRED = 28
        PCAL = 29
        PARI = 30
        OTHR = 31
        ODLT = 32
        CERT = 33
        NOOF = 34
        MRGR = 35
        EXTM = 36
        LIQU = 37
        RHDI = 38
        INTR = 39
        PPMT = 40
        INCR = 41
        MCAL = 42
        REDM = 43
        EXOF = 44
        DTCH = 45
        DRAW = 46
        DRIP = 47
        DVOP = 48
        DSCL = 49
        DETI = 50
        DECR = 51
        CREV = 52
        CONV = 53
        CONS = 54
        CLSA = 55
        COOP = 56
        CHAN = 57
        DVCA = 58
        DRCA = 59
        CAPI = 60
        CAPG = 61
        CAPD = 62
        EXRI = 63
        BONU = 64
        DFLT = 65
        BRUP = 66
        ATTI = 67
        ACTV = 68
    }
    class ISO20022.Seev039001.CorporateActionGeneralInformation174 {
        + FinInstrmId  : ISO20022.Seev039001.SecurityIdentification19
        + MndtryVlntryEvtTp  : ISO20022.Seev039001.CorporateActionMandatoryVoluntary3Choice
        + EvtTp  : ISO20022.Seev039001.CorporateActionEventType107Choice
        + ClssActnNb  : String
        + OffclCorpActnEvtId  : String
        + CorpActnEvtId  : String
    }
    ISO20022.Seev039001.CorporateActionGeneralInformation174 *-- ISO20022.Seev039001.SecurityIdentification19
    ISO20022.Seev039001.CorporateActionGeneralInformation174 *-- ISO20022.Seev039001.CorporateActionMandatoryVoluntary3Choice
    ISO20022.Seev039001.CorporateActionGeneralInformation174 *-- ISO20022.Seev039001.CorporateActionEventType107Choice
    class ISO20022.Seev039001.CorporateActionMandatoryVoluntary1Code {
        VOLU = 1
        CHOS = 2
        MAND = 3
    }
    class ISO20022.Seev039001.CorporateActionMandatoryVoluntary3Choice {
        + Prtry  : ISO20022.Seev039001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev039001.CorporateActionMandatoryVoluntary3Choice *-- ISO20022.Seev039001.GenericIdentification30
    class ISO20022.Seev039001.DateCode19Choice {
        + Prtry  : ISO20022.Seev039001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev039001.DateCode19Choice *-- ISO20022.Seev039001.GenericIdentification30
    class ISO20022.Seev039001.DateFormat30Choice {
        + DtCd  : ISO20022.Seev039001.DateCode19Choice
        + Dt  : DateTime
    }
    ISO20022.Seev039001.DateFormat30Choice *-- ISO20022.Seev039001.DateCode19Choice
    class ISO20022.Seev039001.DateType8Code {
        ONGO = 1
        UKWN = 2
    }
    class ISO20022.Seev039001.EventCompletenessStatus1Code {
        INCO = 1
        COMP = 2
    }
    class ISO20022.Seev039001.EventConfirmationStatus1Code {
        UCON = 1
        CONF = 2
    }
    class ISO20022.Seev039001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev039001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev039001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Seev039001.GenericIdentification30
    }
    ISO20022.Seev039001.GenericIdentification78 *-- ISO20022.Seev039001.GenericIdentification30
    class ISO20022.Seev039001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev039001.LotteryType1Code {
        SUPP = 1
        ORIG = 2
    }
    class ISO20022.Seev039001.LotteryTypeFormat4Choice {
        + Prtry  : ISO20022.Seev039001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev039001.LotteryTypeFormat4Choice *-- ISO20022.Seev039001.GenericIdentification30
    class ISO20022.Seev039001.NameAndAddress5 {
        + Adr  : ISO20022.Seev039001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Seev039001.NameAndAddress5 *-- ISO20022.Seev039001.PostalAddress1
    class ISO20022.Seev039001.OtherIdentification1 {
        + Tp  : ISO20022.Seev039001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev039001.OtherIdentification1 *-- ISO20022.Seev039001.IdentificationSource3Choice
    class ISO20022.Seev039001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Seev039001.NameAndAddress5
        + PrtryId  : ISO20022.Seev039001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Seev039001.PartyIdentification120Choice *-- ISO20022.Seev039001.NameAndAddress5
    ISO20022.Seev039001.PartyIdentification120Choice *-- ISO20022.Seev039001.GenericIdentification36
    class ISO20022.Seev039001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Seev039001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Seev039001.PartyIdentification127Choice *-- ISO20022.Seev039001.GenericIdentification36
    class ISO20022.Seev039001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Seev039001.SafekeepingAccountIdentification1Code {
        GENR = 1
    }
    class ISO20022.Seev039001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Seev039001.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Seev039001.SafekeepingPlaceFormat42Choice {
        + Prtry  : ISO20022.Seev039001.GenericIdentification78
        + TpAndId  : ISO20022.Seev039001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev039001.SafekeepingPlaceTypeAndText6
    }
    ISO20022.Seev039001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev039001.GenericIdentification78
    ISO20022.Seev039001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev039001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev039001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev039001.SafekeepingPlaceTypeAndText6
    class ISO20022.Seev039001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev039001.SafekeepingPlaceTypeAndText6 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev039001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev039001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Seev039001.SecurityIdentification19 *-- ISO20022.Seev039001.OtherIdentification1
    class ISO20022.Seev039001.SupplementaryData1 {
        + Envlp  : ISO20022.Seev039001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev039001.SupplementaryData1 *-- ISO20022.Seev039001.SupplementaryDataEnvelope1
    class ISO20022.Seev039001.SupplementaryDataEnvelope1 {
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

## Value ISO20022.Seev039001.AccountIdentification10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev039001.AccountIdentification69


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgPlc|ISO20022.Seev039001.SafekeepingPlaceFormat42Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Seev039001.PartyIdentification127Choice||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SfkpgPlc),validElement(AcctOwnr))|

---

## Value ISO20022.Seev039001.AccountIdentification73Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctsList|global::System.Collections.Generic.List<ISO20022.Seev039001.AccountIdentification69>||XmlElement()||
|+|ForAllAccts|ISO20022.Seev039001.AccountIdentification10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""AcctsList""",AcctsList),validList("""AcctsList""",AcctsList),validElement(AcctsList),validElement(ForAllAccts),validChoice(AcctsList,ForAllAccts))|

---

## Enum ISO20022.Seev039001.AdditionalBusinessProcess8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PPRE|Int32||XmlEnum("""PPRE""")|1|
||PPUT|Int32||XmlEnum("""PPUT""")|2|
||FPRE|Int32||XmlEnum("""FPRE""")|3|
||CONS|Int32||XmlEnum("""CONS""")|4|

---

## Value ISO20022.Seev039001.AdditionalBusinessProcessFormat15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev039001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev039001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Seev039001.CorporateAction72


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LtryTp|ISO20022.Seev039001.LotteryTypeFormat4Choice||XmlElement()||
|+|AddtlBizPrcInd|global::System.Collections.Generic.List<ISO20022.Seev039001.AdditionalBusinessProcessFormat15Choice>||XmlElement()||
|+|EvtStag|ISO20022.Seev039001.CorporateActionEventStageFormat14Choice||XmlElement()||
|+|DtDtls|ISO20022.Seev039001.CorporateActionDate86||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LtryTp),validList("""AddtlBizPrcInd""",AddtlBizPrcInd),validElement(AddtlBizPrcInd),validElement(EvtStag),validElement(DtDtls))|

---

## Value ISO20022.Seev039001.CorporateActionCancellation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgSts|ISO20022.Seev039001.CorporateActionEventStatus1||XmlElement()||
|+|CxlRsn|String||XmlElement()||
|+|CxlRsnCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrcgSts))|

---

## Aspect ISO20022.Seev039001.CorporateActionCancellationAdviceV13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev039001.SupplementaryData1>||XmlElement()||
|+|InfAgt|ISO20022.Seev039001.PartyIdentification120Choice||XmlElement()||
|+|SlctnAgt|global::System.Collections.Generic.List<ISO20022.Seev039001.PartyIdentification120Choice>||XmlElement()||
|+|DrpAgt|ISO20022.Seev039001.PartyIdentification120Choice||XmlElement()||
|+|PhysSctiesAgt|ISO20022.Seev039001.PartyIdentification120Choice||XmlElement()||
|+|RsellngAgt|global::System.Collections.Generic.List<ISO20022.Seev039001.PartyIdentification120Choice>||XmlElement()||
|+|Regar|ISO20022.Seev039001.PartyIdentification120Choice||XmlElement()||
|+|SubPngAgt|global::System.Collections.Generic.List<ISO20022.Seev039001.PartyIdentification120Choice>||XmlElement()||
|+|PngAgt|global::System.Collections.Generic.List<ISO20022.Seev039001.PartyIdentification120Choice>||XmlElement()||
|+|IssrAgt|global::System.Collections.Generic.List<ISO20022.Seev039001.PartyIdentification120Choice>||XmlElement()||
|+|AddtlTxt|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CorpActnDtls|ISO20022.Seev039001.CorporateAction72||XmlElement()||
|+|AcctsDtls|ISO20022.Seev039001.AccountIdentification73Choice||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev039001.CorporateActionGeneralInformation174||XmlElement()||
|+|CxlAdvcGnlInf|ISO20022.Seev039001.CorporateActionCancellation3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(InfAgt),validList("""SlctnAgt""",SlctnAgt),validElement(SlctnAgt),validElement(DrpAgt),validElement(PhysSctiesAgt),validList("""RsellngAgt""",RsellngAgt),validElement(RsellngAgt),validElement(Regar),validList("""SubPngAgt""",SubPngAgt),validElement(SubPngAgt),validList("""PngAgt""",PngAgt),validElement(PngAgt),validList("""IssrAgt""",IssrAgt),validElement(IssrAgt),validElement(CorpActnDtls),validElement(AcctsDtls),validElement(CorpActnGnlInf),validElement(CxlAdvcGnlInf))|

---

## Enum ISO20022.Seev039001.CorporateActionCancellationReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROC|Int32||XmlEnum("""PROC""")|1|
||WITH|Int32||XmlEnum("""WITH""")|2|

---

## Value ISO20022.Seev039001.CorporateActionDate86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ExDvddDt|ISO20022.Seev039001.DateFormat30Choice||XmlElement()||
|+|RcrdDt|ISO20022.Seev039001.DateFormat30Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ExDvddDt),validElement(RcrdDt))|

---

## Enum ISO20022.Seev039001.CorporateActionEventStage4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RESC|Int32||XmlEnum("""RESC""")|1|
||PART|Int32||XmlEnum("""PART""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Seev039001.CorporateActionEventStageFormat14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev039001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev039001.CorporateActionEventStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EvtConfSts|String||XmlElement()||
|+|EvtCmpltnsSts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev039001.CorporateActionEventType107Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev039001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev039001.CorporateActionEventType35Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RCLA|Int32||XmlEnum("""RCLA""")|1|
||TNDP|Int32||XmlEnum("""TNDP""")|2|
||INFO|Int32||XmlEnum("""INFO""")|3|
||ACCU|Int32||XmlEnum("""ACCU""")|4|
||WRTH|Int32||XmlEnum("""WRTH""")|5|
||WTRC|Int32||XmlEnum("""WTRC""")|6|
||EXWA|Int32||XmlEnum("""EXWA""")|7|
||SUSP|Int32||XmlEnum("""SUSP""")|8|
||DLST|Int32||XmlEnum("""DLST""")|9|
||TEND|Int32||XmlEnum("""TEND""")|10|
||TREC|Int32||XmlEnum("""TREC""")|11|
||SPLF|Int32||XmlEnum("""SPLF""")|12|
||DVSE|Int32||XmlEnum("""DVSE""")|13|
||SOFF|Int32||XmlEnum("""SOFF""")|14|
||SMAL|Int32||XmlEnum("""SMAL""")|15|
||SHPR|Int32||XmlEnum("""SHPR""")|16|
||DVSC|Int32||XmlEnum("""DVSC""")|17|
||RHTS|Int32||XmlEnum("""RHTS""")|18|
||SPLR|Int32||XmlEnum("""SPLR""")|19|
||BIDS|Int32||XmlEnum("""BIDS""")|20|
||REMK|Int32||XmlEnum("""REMK""")|21|
||REDO|Int32||XmlEnum("""REDO""")|22|
||BPUT|Int32||XmlEnum("""BPUT""")|23|
||PRIO|Int32||XmlEnum("""PRIO""")|24|
||PDEF|Int32||XmlEnum("""PDEF""")|25|
||PLAC|Int32||XmlEnum("""PLAC""")|26|
||PINK|Int32||XmlEnum("""PINK""")|27|
||PRED|Int32||XmlEnum("""PRED""")|28|
||PCAL|Int32||XmlEnum("""PCAL""")|29|
||PARI|Int32||XmlEnum("""PARI""")|30|
||OTHR|Int32||XmlEnum("""OTHR""")|31|
||ODLT|Int32||XmlEnum("""ODLT""")|32|
||CERT|Int32||XmlEnum("""CERT""")|33|
||NOOF|Int32||XmlEnum("""NOOF""")|34|
||MRGR|Int32||XmlEnum("""MRGR""")|35|
||EXTM|Int32||XmlEnum("""EXTM""")|36|
||LIQU|Int32||XmlEnum("""LIQU""")|37|
||RHDI|Int32||XmlEnum("""RHDI""")|38|
||INTR|Int32||XmlEnum("""INTR""")|39|
||PPMT|Int32||XmlEnum("""PPMT""")|40|
||INCR|Int32||XmlEnum("""INCR""")|41|
||MCAL|Int32||XmlEnum("""MCAL""")|42|
||REDM|Int32||XmlEnum("""REDM""")|43|
||EXOF|Int32||XmlEnum("""EXOF""")|44|
||DTCH|Int32||XmlEnum("""DTCH""")|45|
||DRAW|Int32||XmlEnum("""DRAW""")|46|
||DRIP|Int32||XmlEnum("""DRIP""")|47|
||DVOP|Int32||XmlEnum("""DVOP""")|48|
||DSCL|Int32||XmlEnum("""DSCL""")|49|
||DETI|Int32||XmlEnum("""DETI""")|50|
||DECR|Int32||XmlEnum("""DECR""")|51|
||CREV|Int32||XmlEnum("""CREV""")|52|
||CONV|Int32||XmlEnum("""CONV""")|53|
||CONS|Int32||XmlEnum("""CONS""")|54|
||CLSA|Int32||XmlEnum("""CLSA""")|55|
||COOP|Int32||XmlEnum("""COOP""")|56|
||CHAN|Int32||XmlEnum("""CHAN""")|57|
||DVCA|Int32||XmlEnum("""DVCA""")|58|
||DRCA|Int32||XmlEnum("""DRCA""")|59|
||CAPI|Int32||XmlEnum("""CAPI""")|60|
||CAPG|Int32||XmlEnum("""CAPG""")|61|
||CAPD|Int32||XmlEnum("""CAPD""")|62|
||EXRI|Int32||XmlEnum("""EXRI""")|63|
||BONU|Int32||XmlEnum("""BONU""")|64|
||DFLT|Int32||XmlEnum("""DFLT""")|65|
||BRUP|Int32||XmlEnum("""BRUP""")|66|
||ATTI|Int32||XmlEnum("""ATTI""")|67|
||ACTV|Int32||XmlEnum("""ACTV""")|68|

---

## Value ISO20022.Seev039001.CorporateActionGeneralInformation174


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmId|ISO20022.Seev039001.SecurityIdentification19||XmlElement()||
|+|MndtryVlntryEvtTp|ISO20022.Seev039001.CorporateActionMandatoryVoluntary3Choice||XmlElement()||
|+|EvtTp|ISO20022.Seev039001.CorporateActionEventType107Choice||XmlElement()||
|+|ClssActnNb|String||XmlElement()||
|+|OffclCorpActnEvtId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmId),validElement(MndtryVlntryEvtTp),validElement(EvtTp))|

---

## Enum ISO20022.Seev039001.CorporateActionMandatoryVoluntary1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VOLU|Int32||XmlEnum("""VOLU""")|1|
||CHOS|Int32||XmlEnum("""CHOS""")|2|
||MAND|Int32||XmlEnum("""MAND""")|3|

---

## Value ISO20022.Seev039001.CorporateActionMandatoryVoluntary3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev039001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev039001.DateCode19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev039001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev039001.DateFormat30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev039001.DateCode19Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Seev039001.DateType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Type ISO20022.Seev039001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnCxlAdvc|ISO20022.Seev039001.CorporateActionCancellationAdviceV13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnCxlAdvc))|

---

## Enum ISO20022.Seev039001.EventCompletenessStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INCO|Int32||XmlEnum("""INCO""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Enum ISO20022.Seev039001.EventConfirmationStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UCON|Int32||XmlEnum("""UCON""")|1|
||CONF|Int32||XmlEnum("""CONF""")|2|

---

## Value ISO20022.Seev039001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev039001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev039001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Seev039001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev039001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev039001.LotteryType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUPP|Int32||XmlEnum("""SUPP""")|1|
||ORIG|Int32||XmlEnum("""ORIG""")|2|

---

## Value ISO20022.Seev039001.LotteryTypeFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev039001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev039001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev039001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Seev039001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev039001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev039001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Seev039001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Seev039001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Seev039001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev039001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Seev039001.PostalAddress1


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

## Enum ISO20022.Seev039001.SafekeepingAccountIdentification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GENR|Int32||XmlEnum("""GENR""")|1|

---

## Enum ISO20022.Seev039001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Seev039001.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Value ISO20022.Seev039001.SafekeepingPlaceFormat42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev039001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Seev039001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev039001.SafekeepingPlaceTypeAndText6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev039001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Seev039001.SafekeepingPlaceTypeAndText6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev039001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev039001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Seev039001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev039001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev039001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

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

