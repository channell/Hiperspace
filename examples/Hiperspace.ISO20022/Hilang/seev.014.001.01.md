# seev.014.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev014001.AccountIdentification2Choice {
        + SctiesAcctId  : String
        + CshAcctId  : String
    }
    class ISO20022.Seev014001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev014001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Seev014001.AgentCAElectionCancellationRequestV01 {
        + ElctnDtls  : ISO20022.Seev014001.CorporateActionElection3
        + CorpActnGnlInf  : ISO20022.Seev014001.CorporateActionInformation1
        + AgtCAElctnAdvcId  : ISO20022.Seev014001.DocumentIdentification8
        + Id  : ISO20022.Seev014001.DocumentIdentification8
    }
    ISO20022.Seev014001.AgentCAElectionCancellationRequestV01 *-- ISO20022.Seev014001.CorporateActionElection3
    ISO20022.Seev014001.AgentCAElectionCancellationRequestV01 *-- ISO20022.Seev014001.CorporateActionInformation1
    ISO20022.Seev014001.AgentCAElectionCancellationRequestV01 *-- ISO20022.Seev014001.DocumentIdentification8
    ISO20022.Seev014001.AgentCAElectionCancellationRequestV01 *-- ISO20022.Seev014001.DocumentIdentification8
    class ISO20022.Seev014001.AlternateSecurityIdentification3 {
        + PrtryIdSrc  : String
        + DmstIdSrc  : String
        + Id  : String
    }
    class ISO20022.Seev014001.CashAccount19 {
        + AcctId  : ISO20022.Seev014001.AccountIdentification2Choice
        + AcctOwnrId  : ISO20022.Seev014001.PartyIdentification2Choice
        + CdtDbtInd  : String
    }
    ISO20022.Seev014001.CashAccount19 *-- ISO20022.Seev014001.AccountIdentification2Choice
    ISO20022.Seev014001.CashAccount19 *-- ISO20022.Seev014001.PartyIdentification2Choice
    class ISO20022.Seev014001.CorporateActionCashMovements2 {
        + AcctDtls  : global::System.Collections.Generic.List~ISO20022.Seev014001.CashAccount19~
        + PstngAmt  : ISO20022.Seev014001.ActiveCurrencyAndAmount
        + PstngDtTm  : ISO20022.Seev014001.DateAndDateTimeChoice
        + PstngId  : String
    }
    ISO20022.Seev014001.CorporateActionCashMovements2 *-- ISO20022.Seev014001.CashAccount19
    ISO20022.Seev014001.CorporateActionCashMovements2 *-- ISO20022.Seev014001.ActiveCurrencyAndAmount
    ISO20022.Seev014001.CorporateActionCashMovements2 *-- ISO20022.Seev014001.DateAndDateTimeChoice
    class ISO20022.Seev014001.CorporateActionElection3 {
        + SctiesMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev014001.CorporateActionSecuritiesMovement2~
        + CshMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev014001.CorporateActionCashMovements2~
        + PropsdRate  : Decimal
        + InstdSctiesQtyToRcv  : ISO20022.Seev014001.UnitOrFaceAmount1Choice
        + InstdUndrlygSctiesQty  : ISO20022.Seev014001.UnitOrFaceAmount1Choice
        + OptnNb  : String
        + OptnTp  : ISO20022.Seev014001.CorporateActionOption1FormatChoice
        + AcctDtls  : ISO20022.Seev014001.SecuritiesAccount7
    }
    ISO20022.Seev014001.CorporateActionElection3 *-- ISO20022.Seev014001.CorporateActionSecuritiesMovement2
    ISO20022.Seev014001.CorporateActionElection3 *-- ISO20022.Seev014001.CorporateActionCashMovements2
    ISO20022.Seev014001.CorporateActionElection3 *-- ISO20022.Seev014001.UnitOrFaceAmount1Choice
    ISO20022.Seev014001.CorporateActionElection3 *-- ISO20022.Seev014001.UnitOrFaceAmount1Choice
    ISO20022.Seev014001.CorporateActionElection3 *-- ISO20022.Seev014001.CorporateActionOption1FormatChoice
    ISO20022.Seev014001.CorporateActionElection3 *-- ISO20022.Seev014001.SecuritiesAccount7
    class ISO20022.Seev014001.CorporateActionEventProcessingType1Code {
        REOR = 1
        DISN = 2
        GENL = 3
    }
    class ISO20022.Seev014001.CorporateActionEventProcessingType1FormatChoice {
        + Prtry  : ISO20022.Seev014001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev014001.CorporateActionEventProcessingType1FormatChoice *-- ISO20022.Seev014001.GenericIdentification13
    class ISO20022.Seev014001.CorporateActionEventType2Code {
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
    class ISO20022.Seev014001.CorporateActionEventType2FormatChoice {
        + Prtry  : ISO20022.Seev014001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev014001.CorporateActionEventType2FormatChoice *-- ISO20022.Seev014001.GenericIdentification13
    class ISO20022.Seev014001.CorporateActionInformation1 {
        + UndrlygScty  : ISO20022.Seev014001.FinancialInstrumentDescription3
        + EvtPrcgTp  : ISO20022.Seev014001.CorporateActionEventProcessingType1FormatChoice
        + MndtryVlntryEvtTp  : ISO20022.Seev014001.CorporateActionMandatoryVoluntary1FormatChoice
        + EvtTp  : ISO20022.Seev014001.CorporateActionEventType2FormatChoice
        + CorpActnPrcgId  : String
        + IssrCorpActnId  : String
        + AgtId  : ISO20022.Seev014001.PartyIdentification2Choice
    }
    ISO20022.Seev014001.CorporateActionInformation1 *-- ISO20022.Seev014001.FinancialInstrumentDescription3
    ISO20022.Seev014001.CorporateActionInformation1 *-- ISO20022.Seev014001.CorporateActionEventProcessingType1FormatChoice
    ISO20022.Seev014001.CorporateActionInformation1 *-- ISO20022.Seev014001.CorporateActionMandatoryVoluntary1FormatChoice
    ISO20022.Seev014001.CorporateActionInformation1 *-- ISO20022.Seev014001.CorporateActionEventType2FormatChoice
    ISO20022.Seev014001.CorporateActionInformation1 *-- ISO20022.Seev014001.PartyIdentification2Choice
    class ISO20022.Seev014001.CorporateActionMandatoryVoluntary1Code {
        VOLU = 1
        CHOS = 2
        MAND = 3
    }
    class ISO20022.Seev014001.CorporateActionMandatoryVoluntary1FormatChoice {
        + Prtry  : ISO20022.Seev014001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev014001.CorporateActionMandatoryVoluntary1FormatChoice *-- ISO20022.Seev014001.GenericIdentification13
    class ISO20022.Seev014001.CorporateActionOption1FormatChoice {
        + Prtry  : ISO20022.Seev014001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev014001.CorporateActionOption1FormatChoice *-- ISO20022.Seev014001.GenericIdentification13
    class ISO20022.Seev014001.CorporateActionOptionType1Code {
        QINV = 1
        OTHR = 2
        NOQU = 3
        SPLI = 4
        SLLE = 5
        SECU = 6
        OVER = 7
        OFFR = 8
        NOAC = 9
        MPUT = 10
        LAPS = 11
        EXER = 12
        CONY = 13
        CONN = 14
        CTEN = 15
        CEXC = 16
        CASH = 17
        CASE = 18
        BUYA = 19
        BSPL = 20
    }
    class ISO20022.Seev014001.CorporateActionSecuritiesMovement2 {
        + AcctDtls  : global::System.Collections.Generic.List~ISO20022.Seev014001.SecuritiesAccount9~
        + PstngQty  : ISO20022.Seev014001.UnitOrFaceAmount1Choice
        + PstngId  : String
        + PstngDtTm  : ISO20022.Seev014001.DateAndDateTimeChoice
        + SctyId  : ISO20022.Seev014001.SecurityIdentification7
    }
    ISO20022.Seev014001.CorporateActionSecuritiesMovement2 *-- ISO20022.Seev014001.SecuritiesAccount9
    ISO20022.Seev014001.CorporateActionSecuritiesMovement2 *-- ISO20022.Seev014001.UnitOrFaceAmount1Choice
    ISO20022.Seev014001.CorporateActionSecuritiesMovement2 *-- ISO20022.Seev014001.DateAndDateTimeChoice
    ISO20022.Seev014001.CorporateActionSecuritiesMovement2 *-- ISO20022.Seev014001.SecurityIdentification7
    class ISO20022.Seev014001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Seev014001.DateAndDateTimeChoice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Seev014001.DocumentIdentification8 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Seev014001.FinancialInstrumentDescription3 {
        + SfkpgPlc  : ISO20022.Seev014001.PartyIdentification2Choice
        + PlcOfListg  : String
        + SctyId  : ISO20022.Seev014001.SecurityIdentification7
    }
    ISO20022.Seev014001.FinancialInstrumentDescription3 *-- ISO20022.Seev014001.PartyIdentification2Choice
    ISO20022.Seev014001.FinancialInstrumentDescription3 *-- ISO20022.Seev014001.SecurityIdentification7
    class ISO20022.Seev014001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Seev014001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Seev014001.GenericIdentification13 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Seev014001.NameAndAddress5 {
        + Adr  : ISO20022.Seev014001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Seev014001.NameAndAddress5 *-- ISO20022.Seev014001.PostalAddress1
    class ISO20022.Seev014001.PartyIdentification2Choice {
        + NmAndAdr  : ISO20022.Seev014001.NameAndAddress5
        + PrtryId  : ISO20022.Seev014001.GenericIdentification1
        + BICOrBEI  : String
    }
    ISO20022.Seev014001.PartyIdentification2Choice *-- ISO20022.Seev014001.NameAndAddress5
    ISO20022.Seev014001.PartyIdentification2Choice *-- ISO20022.Seev014001.GenericIdentification1
    class ISO20022.Seev014001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Seev014001.SecuritiesAccount7 {
        + AcctId  : String
        + AcctOwnrId  : ISO20022.Seev014001.PartyIdentification2Choice
    }
    ISO20022.Seev014001.SecuritiesAccount7 *-- ISO20022.Seev014001.PartyIdentification2Choice
    class ISO20022.Seev014001.SecuritiesAccount9 {
        + SctyHldgForm  : String
        + OptnNb  : String
        + OptnTp  : ISO20022.Seev014001.CorporateActionOption1FormatChoice
        + BalTp  : ISO20022.Seev014001.SecuritiesBalanceType10FormatChoice
        + AcctId  : String
        + AcctOwnrId  : ISO20022.Seev014001.PartyIdentification2Choice
        + CdtDbtInd  : String
    }
    ISO20022.Seev014001.SecuritiesAccount9 *-- ISO20022.Seev014001.CorporateActionOption1FormatChoice
    ISO20022.Seev014001.SecuritiesAccount9 *-- ISO20022.Seev014001.SecuritiesBalanceType10FormatChoice
    ISO20022.Seev014001.SecuritiesAccount9 *-- ISO20022.Seev014001.PartyIdentification2Choice
    class ISO20022.Seev014001.SecuritiesBalanceType10Code {
        RREM = 1
        RDIS = 2
        REST = 3
        AVLB = 4
    }
    class ISO20022.Seev014001.SecuritiesBalanceType10FormatChoice {
        + Prtry  : ISO20022.Seev014001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Seev014001.SecuritiesBalanceType10FormatChoice *-- ISO20022.Seev014001.GenericIdentification13
    class ISO20022.Seev014001.SecurityIdentification7 {
        + Desc  : String
        + OthrId  : ISO20022.Seev014001.AlternateSecurityIdentification3
        + ISIN  : String
    }
    ISO20022.Seev014001.SecurityIdentification7 *-- ISO20022.Seev014001.AlternateSecurityIdentification3
    class ISO20022.Seev014001.UnitOrFaceAmount1Choice {
        + FaceAmt  : ISO20022.Seev014001.ActiveCurrencyAndAmount
        + Unit  : Decimal
    }
    ISO20022.Seev014001.UnitOrFaceAmount1Choice *-- ISO20022.Seev014001.ActiveCurrencyAndAmount
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

## Value ISO20022.Seev014001.AccountIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesAcctId|String||XmlElement()||
|+|CshAcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(SctiesAcctId,CshAcctId))|

---

## Value ISO20022.Seev014001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev014001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Aspect ISO20022.Seev014001.AgentCAElectionCancellationRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ElctnDtls|ISO20022.Seev014001.CorporateActionElection3||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev014001.CorporateActionInformation1||XmlElement()||
|+|AgtCAElctnAdvcId|ISO20022.Seev014001.DocumentIdentification8||XmlElement()||
|+|Id|ISO20022.Seev014001.DocumentIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ElctnDtls),validElement(CorpActnGnlInf),validElement(AgtCAElctnAdvcId),validElement(Id))|

---

## Value ISO20022.Seev014001.AlternateSecurityIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryIdSrc|String||XmlElement()||
|+|DmstIdSrc|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DmstIdSrc""",DmstIdSrc,"""[A-Z]{2,2}"""),validChoice(PrtryIdSrc,DmstIdSrc,Id))|

---

## Value ISO20022.Seev014001.CashAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctId|ISO20022.Seev014001.AccountIdentification2Choice||XmlElement()||
|+|AcctOwnrId|ISO20022.Seev014001.PartyIdentification2Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctId),validElement(AcctOwnrId))|

---

## Value ISO20022.Seev014001.CorporateActionCashMovements2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctDtls|global::System.Collections.Generic.List<ISO20022.Seev014001.CashAccount19>||XmlElement()||
|+|PstngAmt|ISO20022.Seev014001.ActiveCurrencyAndAmount||XmlElement()||
|+|PstngDtTm|ISO20022.Seev014001.DateAndDateTimeChoice||XmlElement()||
|+|PstngId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""AcctDtls""",AcctDtls),validList("""AcctDtls""",AcctDtls),validListMax("""AcctDtls""",AcctDtls,2),validElement(AcctDtls),validElement(PstngAmt),validElement(PstngDtTm))|

---

## Value ISO20022.Seev014001.CorporateActionElection3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev014001.CorporateActionSecuritiesMovement2>||XmlElement()||
|+|CshMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev014001.CorporateActionCashMovements2>||XmlElement()||
|+|PropsdRate|Decimal||XmlElement()||
|+|InstdSctiesQtyToRcv|ISO20022.Seev014001.UnitOrFaceAmount1Choice||XmlElement()||
|+|InstdUndrlygSctiesQty|ISO20022.Seev014001.UnitOrFaceAmount1Choice||XmlElement()||
|+|OptnNb|String||XmlElement()||
|+|OptnTp|ISO20022.Seev014001.CorporateActionOption1FormatChoice||XmlElement()||
|+|AcctDtls|ISO20022.Seev014001.SecuritiesAccount7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SctiesMvmntDtls""",SctiesMvmntDtls),validElement(SctiesMvmntDtls),validList("""CshMvmntDtls""",CshMvmntDtls),validElement(CshMvmntDtls),validElement(InstdSctiesQtyToRcv),validElement(InstdUndrlygSctiesQty),validPattern("""OptnNb""",OptnNb,"""[0-9]{3}"""),validElement(OptnTp),validElement(AcctDtls))|

---

## Enum ISO20022.Seev014001.CorporateActionEventProcessingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REOR|Int32||XmlEnum("""REOR""")|1|
||DISN|Int32||XmlEnum("""DISN""")|2|
||GENL|Int32||XmlEnum("""GENL""")|3|

---

## Value ISO20022.Seev014001.CorporateActionEventProcessingType1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev014001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev014001.CorporateActionEventType2Code


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

## Value ISO20022.Seev014001.CorporateActionEventType2FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev014001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev014001.CorporateActionInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UndrlygScty|ISO20022.Seev014001.FinancialInstrumentDescription3||XmlElement()||
|+|EvtPrcgTp|ISO20022.Seev014001.CorporateActionEventProcessingType1FormatChoice||XmlElement()||
|+|MndtryVlntryEvtTp|ISO20022.Seev014001.CorporateActionMandatoryVoluntary1FormatChoice||XmlElement()||
|+|EvtTp|ISO20022.Seev014001.CorporateActionEventType2FormatChoice||XmlElement()||
|+|CorpActnPrcgId|String||XmlElement()||
|+|IssrCorpActnId|String||XmlElement()||
|+|AgtId|ISO20022.Seev014001.PartyIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UndrlygScty),validElement(EvtPrcgTp),validElement(MndtryVlntryEvtTp),validElement(EvtTp),validElement(AgtId))|

---

## Enum ISO20022.Seev014001.CorporateActionMandatoryVoluntary1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VOLU|Int32||XmlEnum("""VOLU""")|1|
||CHOS|Int32||XmlEnum("""CHOS""")|2|
||MAND|Int32||XmlEnum("""MAND""")|3|

---

## Value ISO20022.Seev014001.CorporateActionMandatoryVoluntary1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev014001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev014001.CorporateActionOption1FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev014001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev014001.CorporateActionOptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||QINV|Int32||XmlEnum("""QINV""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||NOQU|Int32||XmlEnum("""NOQU""")|3|
||SPLI|Int32||XmlEnum("""SPLI""")|4|
||SLLE|Int32||XmlEnum("""SLLE""")|5|
||SECU|Int32||XmlEnum("""SECU""")|6|
||OVER|Int32||XmlEnum("""OVER""")|7|
||OFFR|Int32||XmlEnum("""OFFR""")|8|
||NOAC|Int32||XmlEnum("""NOAC""")|9|
||MPUT|Int32||XmlEnum("""MPUT""")|10|
||LAPS|Int32||XmlEnum("""LAPS""")|11|
||EXER|Int32||XmlEnum("""EXER""")|12|
||CONY|Int32||XmlEnum("""CONY""")|13|
||CONN|Int32||XmlEnum("""CONN""")|14|
||CTEN|Int32||XmlEnum("""CTEN""")|15|
||CEXC|Int32||XmlEnum("""CEXC""")|16|
||CASH|Int32||XmlEnum("""CASH""")|17|
||CASE|Int32||XmlEnum("""CASE""")|18|
||BUYA|Int32||XmlEnum("""BUYA""")|19|
||BSPL|Int32||XmlEnum("""BSPL""")|20|

---

## Value ISO20022.Seev014001.CorporateActionSecuritiesMovement2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctDtls|global::System.Collections.Generic.List<ISO20022.Seev014001.SecuritiesAccount9>||XmlElement()||
|+|PstngQty|ISO20022.Seev014001.UnitOrFaceAmount1Choice||XmlElement()||
|+|PstngId|String||XmlElement()||
|+|PstngDtTm|ISO20022.Seev014001.DateAndDateTimeChoice||XmlElement()||
|+|SctyId|ISO20022.Seev014001.SecurityIdentification7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""AcctDtls""",AcctDtls),validList("""AcctDtls""",AcctDtls),validListMax("""AcctDtls""",AcctDtls,2),validElement(AcctDtls),validElement(PstngQty),validElement(PstngDtTm),validElement(SctyId))|

---

## Enum ISO20022.Seev014001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Seev014001.DateAndDateTimeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Type ISO20022.Seev014001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AgtCAElctnCxlReq|ISO20022.Seev014001.AgentCAElectionCancellationRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AgtCAElctnCxlReq))|

---

## Value ISO20022.Seev014001.DocumentIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev014001.FinancialInstrumentDescription3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgPlc|ISO20022.Seev014001.PartyIdentification2Choice||XmlElement()||
|+|PlcOfListg|String||XmlElement()||
|+|SctyId|ISO20022.Seev014001.SecurityIdentification7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SfkpgPlc),validPattern("""PlcOfListg""",PlcOfListg,"""[A-Z0-9]{4,4}"""),validElement(SctyId))|

---

## Enum ISO20022.Seev014001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Seev014001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev014001.GenericIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Seev014001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev014001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Seev014001.PartyIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Seev014001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Seev014001.GenericIdentification1||XmlElement()||
|+|BICOrBEI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""BICOrBEI""",BICOrBEI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,BICOrBEI))|

---

## Value ISO20022.Seev014001.PostalAddress1


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

## Value ISO20022.Seev014001.SecuritiesAccount7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctId|String||XmlElement()||
|+|AcctOwnrId|ISO20022.Seev014001.PartyIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctOwnrId))|

---

## Value ISO20022.Seev014001.SecuritiesAccount9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyHldgForm|String||XmlElement()||
|+|OptnNb|String||XmlElement()||
|+|OptnTp|ISO20022.Seev014001.CorporateActionOption1FormatChoice||XmlElement()||
|+|BalTp|ISO20022.Seev014001.SecuritiesBalanceType10FormatChoice||XmlElement()||
|+|AcctId|String||XmlElement()||
|+|AcctOwnrId|ISO20022.Seev014001.PartyIdentification2Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""OptnNb""",OptnNb,"""[0-9]{3}"""),validElement(OptnTp),validElement(BalTp),validElement(AcctOwnrId))|

---

## Enum ISO20022.Seev014001.SecuritiesBalanceType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RREM|Int32||XmlEnum("""RREM""")|1|
||RDIS|Int32||XmlEnum("""RDIS""")|2|
||REST|Int32||XmlEnum("""REST""")|3|
||AVLB|Int32||XmlEnum("""AVLB""")|4|

---

## Value ISO20022.Seev014001.SecuritiesBalanceType10FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev014001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev014001.SecurityIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|ISO20022.Seev014001.AlternateSecurityIdentification3||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z0-9]{12,12}"""),validChoice(Desc,OthrId,ISIN))|

---

## Value ISO20022.Seev014001.UnitOrFaceAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FaceAmt|ISO20022.Seev014001.ActiveCurrencyAndAmount||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FaceAmt),validChoice(FaceAmt,Unit))|

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

