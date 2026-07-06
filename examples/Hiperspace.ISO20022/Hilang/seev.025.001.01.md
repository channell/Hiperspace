# seev.025.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev025001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Seev025001.AgentCAStandingInstructionRequestV01 {
        + CtctDtls  : ISO20022.Seev025001.ContactPerson1
        + StgInstrDtls  : ISO20022.Seev025001.CorporateActionStandingInstruction1
        + StgInstrGnlInf  : ISO20022.Seev025001.CorporateActionStandingInstructionGeneralInformation1
        + Id  : ISO20022.Seev025001.DocumentIdentification8
    }
    ISO20022.Seev025001.AgentCAStandingInstructionRequestV01 *-- ISO20022.Seev025001.ContactPerson1
    ISO20022.Seev025001.AgentCAStandingInstructionRequestV01 *-- ISO20022.Seev025001.CorporateActionStandingInstruction1
    ISO20022.Seev025001.AgentCAStandingInstructionRequestV01 *-- ISO20022.Seev025001.CorporateActionStandingInstructionGeneralInformation1
    ISO20022.Seev025001.AgentCAStandingInstructionRequestV01 *-- ISO20022.Seev025001.DocumentIdentification8
    class ISO20022.Seev025001.AlternateSecurityIdentification3 {
        + PrtryIdSrc  : String
        + DmstIdSrc  : String
        + Id  : String
    }
    class ISO20022.Seev025001.CashAccount17 {
        + CrspdtBkId  : String
        + AcctOwnrId  : ISO20022.Seev025001.PartyIdentification2Choice
        + PmtCcy  : String
        + AcctId  : ISO20022.Seev025001.CashAccountIdentification1Choice
    }
    ISO20022.Seev025001.CashAccount17 *-- ISO20022.Seev025001.PartyIdentification2Choice
    ISO20022.Seev025001.CashAccount17 *-- ISO20022.Seev025001.CashAccountIdentification1Choice
    class ISO20022.Seev025001.CashAccountIdentification1Choice {
        + DmstAcct  : ISO20022.Seev025001.SimpleIdentificationInformation
        + UPIC  : String
        + BBAN  : String
        + IBAN  : String
    }
    ISO20022.Seev025001.CashAccountIdentification1Choice *-- ISO20022.Seev025001.SimpleIdentificationInformation
    class ISO20022.Seev025001.ContactIdentification4 {
        + EmailAdr  : String
        + FaxNb  : String
        + PhneNb  : String
        + Role  : String
        + GvnNm  : String
        + NmPrfx  : String
        + Nm  : String
    }
    class ISO20022.Seev025001.ContactPerson1 {
        + InstnId  : ISO20022.Seev025001.PartyIdentification2Choice
        + CtctPrsn  : ISO20022.Seev025001.ContactIdentification4
    }
    ISO20022.Seev025001.ContactPerson1 *-- ISO20022.Seev025001.PartyIdentification2Choice
    ISO20022.Seev025001.ContactPerson1 *-- ISO20022.Seev025001.ContactIdentification4
    class ISO20022.Seev025001.CorporateActionEventType2Code {
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
    class ISO20022.Seev025001.CorporateActionEventType2FormatChoice {
        + Prtry  : ISO20022.Seev025001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev025001.CorporateActionEventType2FormatChoice *-- ISO20022.Seev025001.GenericIdentification13
    class ISO20022.Seev025001.CorporateActionStandingInstruction1 {
        + AddtlInf  : String
        + SctiesDstrbtnDtls  : ISO20022.Seev025001.SecuritiesAccount6
        + CshDstrbtnDtls  : ISO20022.Seev025001.CashAccount17
        + NetOrGrss  : String
    }
    ISO20022.Seev025001.CorporateActionStandingInstruction1 *-- ISO20022.Seev025001.SecuritiesAccount6
    ISO20022.Seev025001.CorporateActionStandingInstruction1 *-- ISO20022.Seev025001.CashAccount17
    class ISO20022.Seev025001.CorporateActionStandingInstructionGeneralInformation1 {
        + UndrlygScty  : ISO20022.Seev025001.FinancialInstrumentDescription3
        + AcctDtls  : global::System.Collections.Generic.List~ISO20022.Seev025001.IncludedAccount1~
        + ClntStgInstrId  : String
        + InstgPtyId  : ISO20022.Seev025001.PartyIdentification2Choice
        + EvtTp  : global::System.Collections.Generic.List~ISO20022.Seev025001.CorporateActionEventType2FormatChoice~
        + StgInstrTp  : String
    }
    ISO20022.Seev025001.CorporateActionStandingInstructionGeneralInformation1 *-- ISO20022.Seev025001.FinancialInstrumentDescription3
    ISO20022.Seev025001.CorporateActionStandingInstructionGeneralInformation1 *-- ISO20022.Seev025001.IncludedAccount1
    ISO20022.Seev025001.CorporateActionStandingInstructionGeneralInformation1 *-- ISO20022.Seev025001.PartyIdentification2Choice
    ISO20022.Seev025001.CorporateActionStandingInstructionGeneralInformation1 *-- ISO20022.Seev025001.CorporateActionEventType2FormatChoice
    class ISO20022.Seev025001.DocumentIdentification8 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Seev025001.FinancialInstrumentDescription3 {
        + SfkpgPlc  : ISO20022.Seev025001.PartyIdentification2Choice
        + PlcOfListg  : String
        + SctyId  : ISO20022.Seev025001.SecurityIdentification7
    }
    ISO20022.Seev025001.FinancialInstrumentDescription3 *-- ISO20022.Seev025001.PartyIdentification2Choice
    ISO20022.Seev025001.FinancialInstrumentDescription3 *-- ISO20022.Seev025001.SecurityIdentification7
    class ISO20022.Seev025001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Seev025001.GenericIdentification13 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Seev025001.IncludedAccount1 {
        + InclInd  : String
        + SctiesAcctId  : String
    }
    class ISO20022.Seev025001.NameAndAddress5 {
        + Adr  : ISO20022.Seev025001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Seev025001.NameAndAddress5 *-- ISO20022.Seev025001.PostalAddress1
    class ISO20022.Seev025001.NamePrefix1Code {
        MADM = 1
        MISS = 2
        MIST = 3
        DOCT = 4
    }
    class ISO20022.Seev025001.PartyIdentification2Choice {
        + NmAndAdr  : ISO20022.Seev025001.NameAndAddress5
        + PrtryId  : ISO20022.Seev025001.GenericIdentification1
        + BICOrBEI  : String
    }
    ISO20022.Seev025001.PartyIdentification2Choice *-- ISO20022.Seev025001.NameAndAddress5
    ISO20022.Seev025001.PartyIdentification2Choice *-- ISO20022.Seev025001.GenericIdentification1
    class ISO20022.Seev025001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Seev025001.SecuritiesAccount6 {
        + RegnDtls  : String
        + SfkpgPlc  : ISO20022.Seev025001.PartyIdentification2Choice
        + AcctOwnrId  : ISO20022.Seev025001.PartyIdentification2Choice
        + SctiesAcctId  : String
        + SctyId  : ISO20022.Seev025001.SecurityIdentification7
    }
    ISO20022.Seev025001.SecuritiesAccount6 *-- ISO20022.Seev025001.PartyIdentification2Choice
    ISO20022.Seev025001.SecuritiesAccount6 *-- ISO20022.Seev025001.PartyIdentification2Choice
    ISO20022.Seev025001.SecuritiesAccount6 *-- ISO20022.Seev025001.SecurityIdentification7
    class ISO20022.Seev025001.SecurityIdentification7 {
        + Desc  : String
        + OthrId  : ISO20022.Seev025001.AlternateSecurityIdentification3
        + ISIN  : String
    }
    ISO20022.Seev025001.SecurityIdentification7 *-- ISO20022.Seev025001.AlternateSecurityIdentification3
    class ISO20022.Seev025001.SimpleIdentificationInformation {
        + Id  : String
    }
    class ISO20022.Seev025001.StandingInstructionGrossNet1Code {
        NETT = 1
        GROS = 2
    }
    class ISO20022.Seev025001.StandingInstructionType1Code {
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

## Enum ISO20022.Seev025001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Aspect ISO20022.Seev025001.AgentCAStandingInstructionRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Seev025001.ContactPerson1||XmlElement()||
|+|StgInstrDtls|ISO20022.Seev025001.CorporateActionStandingInstruction1||XmlElement()||
|+|StgInstrGnlInf|ISO20022.Seev025001.CorporateActionStandingInstructionGeneralInformation1||XmlElement()||
|+|Id|ISO20022.Seev025001.DocumentIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validElement(StgInstrDtls),validElement(StgInstrGnlInf),validElement(Id))|

---

## Value ISO20022.Seev025001.AlternateSecurityIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryIdSrc|String||XmlElement()||
|+|DmstIdSrc|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DmstIdSrc""",DmstIdSrc,"""[A-Z]{2,2}"""),validChoice(PrtryIdSrc,DmstIdSrc,Id))|

---

## Value ISO20022.Seev025001.CashAccount17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CrspdtBkId|String||XmlElement()||
|+|AcctOwnrId|ISO20022.Seev025001.PartyIdentification2Choice||XmlElement()||
|+|PmtCcy|String||XmlElement()||
|+|AcctId|ISO20022.Seev025001.CashAccountIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CrspdtBkId""",CrspdtBkId,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validElement(AcctOwnrId),validPattern("""PmtCcy""",PmtCcy,"""[A-Z]{3,3}"""),validElement(AcctId))|

---

## Value ISO20022.Seev025001.CashAccountIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DmstAcct|ISO20022.Seev025001.SimpleIdentificationInformation||XmlElement()||
|+|UPIC|String||XmlElement()||
|+|BBAN|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DmstAcct),validPattern("""UPIC""",UPIC,"""[0-9]{8,17}"""),validPattern("""BBAN""",BBAN,"""[a-zA-Z0-9]{1,30}"""),validPattern("""IBAN""",IBAN,"""[a-zA-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(DmstAcct,UPIC,BBAN,IBAN))|

---

## Value ISO20022.Seev025001.ContactIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Role|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Seev025001.ContactPerson1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstnId|ISO20022.Seev025001.PartyIdentification2Choice||XmlElement()||
|+|CtctPrsn|ISO20022.Seev025001.ContactIdentification4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstnId),validElement(CtctPrsn))|

---

## Enum ISO20022.Seev025001.CorporateActionEventType2Code


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

## Value ISO20022.Seev025001.CorporateActionEventType2FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev025001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev025001.CorporateActionStandingInstruction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|SctiesDstrbtnDtls|ISO20022.Seev025001.SecuritiesAccount6||XmlElement()||
|+|CshDstrbtnDtls|ISO20022.Seev025001.CashAccount17||XmlElement()||
|+|NetOrGrss|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesDstrbtnDtls),validElement(CshDstrbtnDtls),validChoice(AddtlInf,SctiesDstrbtnDtls,CshDstrbtnDtls,NetOrGrss))|

---

## Value ISO20022.Seev025001.CorporateActionStandingInstructionGeneralInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UndrlygScty|ISO20022.Seev025001.FinancialInstrumentDescription3||XmlElement()||
|+|AcctDtls|global::System.Collections.Generic.List<ISO20022.Seev025001.IncludedAccount1>||XmlElement()||
|+|ClntStgInstrId|String||XmlElement()||
|+|InstgPtyId|ISO20022.Seev025001.PartyIdentification2Choice||XmlElement()||
|+|EvtTp|global::System.Collections.Generic.List<ISO20022.Seev025001.CorporateActionEventType2FormatChoice>||XmlElement()||
|+|StgInstrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UndrlygScty),validList("""AcctDtls""",AcctDtls),validElement(AcctDtls),validElement(InstgPtyId),validList("""EvtTp""",EvtTp),validElement(EvtTp))|

---

## Type ISO20022.Seev025001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AgtCAStgInstrReq|ISO20022.Seev025001.AgentCAStandingInstructionRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AgtCAStgInstrReq))|

---

## Value ISO20022.Seev025001.DocumentIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev025001.FinancialInstrumentDescription3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgPlc|ISO20022.Seev025001.PartyIdentification2Choice||XmlElement()||
|+|PlcOfListg|String||XmlElement()||
|+|SctyId|ISO20022.Seev025001.SecurityIdentification7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SfkpgPlc),validPattern("""PlcOfListg""",PlcOfListg,"""[A-Z0-9]{4,4}"""),validElement(SctyId))|

---

## Value ISO20022.Seev025001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev025001.GenericIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Seev025001.IncludedAccount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InclInd|String||XmlElement()||
|+|SctiesAcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev025001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev025001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Seev025001.NamePrefix1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MADM|Int32||XmlEnum("""MADM""")|1|
||MISS|Int32||XmlEnum("""MISS""")|2|
||MIST|Int32||XmlEnum("""MIST""")|3|
||DOCT|Int32||XmlEnum("""DOCT""")|4|

---

## Value ISO20022.Seev025001.PartyIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Seev025001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Seev025001.GenericIdentification1||XmlElement()||
|+|BICOrBEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""BICOrBEI""",BICOrBEI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,BICOrBEI))|

---

## Value ISO20022.Seev025001.PostalAddress1


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

## Value ISO20022.Seev025001.SecuritiesAccount6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev025001.PartyIdentification2Choice||XmlElement()||
|+|AcctOwnrId|ISO20022.Seev025001.PartyIdentification2Choice||XmlElement()||
|+|SctiesAcctId|String||XmlElement()||
|+|SctyId|ISO20022.Seev025001.SecurityIdentification7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SfkpgPlc),validElement(AcctOwnrId),validElement(SctyId))|

---

## Value ISO20022.Seev025001.SecurityIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|ISO20022.Seev025001.AlternateSecurityIdentification3||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z0-9]{12,12}"""),validChoice(Desc,OthrId,ISIN))|

---

## Value ISO20022.Seev025001.SimpleIdentificationInformation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev025001.StandingInstructionGrossNet1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETT|Int32||XmlEnum("""NETT""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Enum ISO20022.Seev025001.StandingInstructionType1Code


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

