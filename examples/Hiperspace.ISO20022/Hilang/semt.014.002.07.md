# semt.014.002.07
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt014002.AcknowledgedAcceptedStatus25Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt014002.AcknowledgementReason13~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt014002.AcknowledgedAcceptedStatus25Choice *-- ISO20022.Semt014002.AcknowledgementReason13
    class ISO20022.Semt014002.AcknowledgementReason13 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt014002.AcknowledgementReason16Choice
    }
    ISO20022.Semt014002.AcknowledgementReason13 *-- ISO20022.Semt014002.AcknowledgementReason16Choice
    class ISO20022.Semt014002.AcknowledgementReason16Choice {
        + Prtry  : ISO20022.Semt014002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt014002.AcknowledgementReason16Choice *-- ISO20022.Semt014002.GenericIdentification47
    class ISO20022.Semt014002.AcknowledgementReason5Code {
        LATE = 1
        RQWV = 2
        NSTP = 3
        CDRE = 4
        CDRG = 5
        CDCY = 6
        OTHR = 7
        SMPG = 8
        ADEA = 9
    }
    class ISO20022.Semt014002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Semt014002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Semt014002.BlockChainAddressWallet7 *-- ISO20022.Semt014002.GenericIdentification47
    class ISO20022.Semt014002.CancellationReason24 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt014002.CancellationReason37Choice
    }
    ISO20022.Semt014002.CancellationReason24 *-- ISO20022.Semt014002.CancellationReason37Choice
    class ISO20022.Semt014002.CancellationReason37Choice {
        + Prtry  : ISO20022.Semt014002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt014002.CancellationReason37Choice *-- ISO20022.Semt014002.GenericIdentification47
    class ISO20022.Semt014002.CancellationStatus25Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt014002.CancellationReason24~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt014002.CancellationStatus25Choice *-- ISO20022.Semt014002.CancellationReason24
    class ISO20022.Semt014002.CancelledStatusReason16Code {
        CORP = 1
        CANI = 2
        CANS = 3
        CSUB = 4
        CANT = 5
        CANZ = 6
        CTHP = 7
        BYIY = 8
        CXLR = 9
        OTHR = 10
        SCEX = 11
    }
    class ISO20022.Semt014002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Semt014002.FailingReason10Choice {
        + Prtry  : ISO20022.Semt014002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt014002.FailingReason10Choice *-- ISO20022.Semt014002.GenericIdentification47
    class ISO20022.Semt014002.FailingReason3Code {
        INBC = 1
        PRSY = 2
        CERT = 3
        SETS = 4
        REGT = 5
        PRCY = 6
        LIQU = 7
        LATE = 8
        LAAW = 9
        FROZ = 10
        DKNY = 11
        DISA = 12
        DENO = 13
        CLHT = 14
        BOTH = 15
        BENO = 16
        PHCK = 17
        OTHR = 18
        IAAD = 19
        MINO = 20
        CPEC = 21
        SBLO = 22
        CYCL = 23
        BATC = 24
        SDUT = 25
        REFS = 26
        NCON = 27
        MONY = 28
        LALO = 29
        LACK = 30
        LINK = 31
        INCA = 32
        FLIM = 33
        DEPO = 34
        COLL = 35
        YCOL = 36
        CMON = 37
        NOFX = 38
        PART = 39
        PREA = 40
        GLOB = 41
        MUNO = 42
        CLAC = 43
        NEWI = 44
        CHAS = 45
        BLOC = 46
        DOCC = 47
        MLAT = 48
        DOCY = 49
        STCD = 50
        PHSE = 51
        AWSH = 52
        OBJT = 53
        CAIS = 54
        CANR = 55
        ADEA = 56
        CLAT = 57
        BYIY = 58
        AWMO = 59
    }
    class ISO20022.Semt014002.FailingReason9 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt014002.FailingReason10Choice
    }
    ISO20022.Semt014002.FailingReason9 *-- ISO20022.Semt014002.FailingReason10Choice
    class ISO20022.Semt014002.FailingStatus11Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt014002.FailingReason9~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt014002.FailingStatus11Choice *-- ISO20022.Semt014002.FailingReason9
    class ISO20022.Semt014002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Semt014002.GenericIdentification39 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt014002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt014002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt014002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt014002.IntraPositionDetails64 {
        + BalTo  : ISO20022.Semt014002.SecuritiesBalanceType11Choice
        + BalFr  : ISO20022.Semt014002.SecuritiesBalanceType11Choice
        + AckdStsTmStmp  : DateTime
        + SttlmDt  : ISO20022.Semt014002.DateAndDateTime2Choice
        + LotNb  : ISO20022.Semt014002.GenericIdentification39
        + SttlmQty  : ISO20022.Semt014002.FinancialInstrumentQuantity36Choice
        + FinInstrmId  : ISO20022.Semt014002.SecurityIdentification20
        + BlckChainAdrOrWllt  : ISO20022.Semt014002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Semt014002.SecuritiesAccount30
        + AcctOwnr  : ISO20022.Semt014002.PartyIdentification136Choice
        + PoolId  : String
    }
    ISO20022.Semt014002.IntraPositionDetails64 *-- ISO20022.Semt014002.SecuritiesBalanceType11Choice
    ISO20022.Semt014002.IntraPositionDetails64 *-- ISO20022.Semt014002.SecuritiesBalanceType11Choice
    ISO20022.Semt014002.IntraPositionDetails64 *-- ISO20022.Semt014002.DateAndDateTime2Choice
    ISO20022.Semt014002.IntraPositionDetails64 *-- ISO20022.Semt014002.GenericIdentification39
    ISO20022.Semt014002.IntraPositionDetails64 *-- ISO20022.Semt014002.FinancialInstrumentQuantity36Choice
    ISO20022.Semt014002.IntraPositionDetails64 *-- ISO20022.Semt014002.SecurityIdentification20
    ISO20022.Semt014002.IntraPositionDetails64 *-- ISO20022.Semt014002.BlockChainAddressWallet7
    ISO20022.Semt014002.IntraPositionDetails64 *-- ISO20022.Semt014002.SecuritiesAccount30
    ISO20022.Semt014002.IntraPositionDetails64 *-- ISO20022.Semt014002.PartyIdentification136Choice
    class ISO20022.Semt014002.IntraPositionMovementStatusAdvice002V07 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt014002.SupplementaryData1~
        + TxDtls  : ISO20022.Semt014002.IntraPositionDetails64
        + SttlmSts  : ISO20022.Semt014002.SettlementStatus20Choice
        + PrcgSts  : ISO20022.Semt014002.IntraPositionProcessingStatus10Choice
        + TxId  : ISO20022.Semt014002.TransactionIdentifications34
    }
    ISO20022.Semt014002.IntraPositionMovementStatusAdvice002V07 *-- ISO20022.Semt014002.SupplementaryData1
    ISO20022.Semt014002.IntraPositionMovementStatusAdvice002V07 *-- ISO20022.Semt014002.IntraPositionDetails64
    ISO20022.Semt014002.IntraPositionMovementStatusAdvice002V07 *-- ISO20022.Semt014002.SettlementStatus20Choice
    ISO20022.Semt014002.IntraPositionMovementStatusAdvice002V07 *-- ISO20022.Semt014002.IntraPositionProcessingStatus10Choice
    ISO20022.Semt014002.IntraPositionMovementStatusAdvice002V07 *-- ISO20022.Semt014002.TransactionIdentifications34
    class ISO20022.Semt014002.IntraPositionProcessingStatus10Choice {
        + Prtry  : ISO20022.Semt014002.ProprietaryStatusAndReason7
        + AckdAccptd  : ISO20022.Semt014002.AcknowledgedAcceptedStatus25Choice
        + Canc  : ISO20022.Semt014002.CancellationStatus25Choice
        + Rpr  : ISO20022.Semt014002.RejectionOrRepairStatus45Choice
        + Rjctd  : ISO20022.Semt014002.RejectionOrRepairStatus45Choice
    }
    ISO20022.Semt014002.IntraPositionProcessingStatus10Choice *-- ISO20022.Semt014002.ProprietaryStatusAndReason7
    ISO20022.Semt014002.IntraPositionProcessingStatus10Choice *-- ISO20022.Semt014002.AcknowledgedAcceptedStatus25Choice
    ISO20022.Semt014002.IntraPositionProcessingStatus10Choice *-- ISO20022.Semt014002.CancellationStatus25Choice
    ISO20022.Semt014002.IntraPositionProcessingStatus10Choice *-- ISO20022.Semt014002.RejectionOrRepairStatus45Choice
    ISO20022.Semt014002.IntraPositionProcessingStatus10Choice *-- ISO20022.Semt014002.RejectionOrRepairStatus45Choice
    class ISO20022.Semt014002.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Semt014002.OtherIdentification2 {
        + Tp  : ISO20022.Semt014002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Semt014002.OtherIdentification2 *-- ISO20022.Semt014002.IdentificationSource4Choice
    class ISO20022.Semt014002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Semt014002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Semt014002.PartyIdentification136Choice *-- ISO20022.Semt014002.GenericIdentification84
    class ISO20022.Semt014002.PendingReason10Code {
        INBC = 1
        PRSY = 2
        CERT = 3
        SETS = 4
        REGT = 5
        PRCY = 6
        LIQU = 7
        LATE = 8
        LAAW = 9
        FROZ = 10
        DKNY = 11
        DISA = 12
        DENO = 13
        CLHT = 14
        BOTH = 15
        BENO = 16
        PHCK = 17
        OTHR = 18
        IAAD = 19
        MINO = 20
        CPEC = 21
        SBLO = 22
        CYCL = 23
        BATC = 24
        SDUT = 25
        REFS = 26
        NCON = 27
        MONY = 28
        LALO = 29
        LACK = 30
        FUTU = 31
        LINK = 32
        INCA = 33
        FLIM = 34
        DEPO = 35
        COLL = 36
        YCOL = 37
        CMON = 38
        NOFX = 39
        NMAS = 40
        PART = 41
        PREA = 42
        GLOB = 43
        MUNO = 44
        CLAC = 45
        NEWI = 46
        CHAS = 47
        BLOC = 48
        DOCC = 49
        DOCY = 50
        TAMM = 51
        PHSE = 52
        AWSH = 53
        REFU = 54
        CAIS = 55
        ADEA = 56
        AWMO = 57
    }
    class ISO20022.Semt014002.PendingReason19 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt014002.PendingReason36Choice
    }
    ISO20022.Semt014002.PendingReason19 *-- ISO20022.Semt014002.PendingReason36Choice
    class ISO20022.Semt014002.PendingReason36Choice {
        + Prtry  : ISO20022.Semt014002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt014002.PendingReason36Choice *-- ISO20022.Semt014002.GenericIdentification47
    class ISO20022.Semt014002.PendingStatus45Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt014002.PendingReason19~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt014002.PendingStatus45Choice *-- ISO20022.Semt014002.PendingReason19
    class ISO20022.Semt014002.ProprietaryReason5 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Semt014002.GenericIdentification47
    }
    ISO20022.Semt014002.ProprietaryReason5 *-- ISO20022.Semt014002.GenericIdentification47
    class ISO20022.Semt014002.ProprietaryStatusAndReason7 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Semt014002.ProprietaryReason5~
        + PrtrySts  : ISO20022.Semt014002.GenericIdentification47
    }
    ISO20022.Semt014002.ProprietaryStatusAndReason7 *-- ISO20022.Semt014002.ProprietaryReason5
    ISO20022.Semt014002.ProprietaryStatusAndReason7 *-- ISO20022.Semt014002.GenericIdentification47
    class ISO20022.Semt014002.RejectionAndRepairReason40Choice {
        + Prtry  : ISO20022.Semt014002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt014002.RejectionAndRepairReason40Choice *-- ISO20022.Semt014002.GenericIdentification47
    class ISO20022.Semt014002.RejectionOrRepairReason40 {
        + AddtlRsnInf  : String
        + Cd  : global::System.Collections.Generic.List~ISO20022.Semt014002.RejectionAndRepairReason40Choice~
    }
    ISO20022.Semt014002.RejectionOrRepairReason40 *-- ISO20022.Semt014002.RejectionAndRepairReason40Choice
    class ISO20022.Semt014002.RejectionOrRepairStatus45Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt014002.RejectionOrRepairReason40~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt014002.RejectionOrRepairStatus45Choice *-- ISO20022.Semt014002.RejectionOrRepairReason40
    class ISO20022.Semt014002.RejectionReason69Code {
        VALR = 1
        MUNO = 2
        MINO = 3
        INVN = 4
        INVL = 5
        INVB = 6
        DSEC = 7
        DQUA = 8
        OTHR = 9
        REFE = 10
        DDAT = 11
        CAEV = 12
        LATE = 13
        ADEA = 14
        SAFE = 15
    }
    class ISO20022.Semt014002.SecuritiesAccount30 {
        + Nm  : String
        + Tp  : ISO20022.Semt014002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Semt014002.SecuritiesAccount30 *-- ISO20022.Semt014002.GenericIdentification47
    class ISO20022.Semt014002.SecuritiesBalanceType11Choice {
        + Prtry  : ISO20022.Semt014002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt014002.SecuritiesBalanceType11Choice *-- ISO20022.Semt014002.GenericIdentification47
    class ISO20022.Semt014002.SecuritiesBalanceType13Code {
        COLA = 1
        QUAS = 2
        ISSU = 3
        UNRG = 4
        SPOS = 5
        OTHR = 6
        RSTR = 7
        REGO = 8
        PLED = 9
        NOMI = 10
        AVAI = 11
        AWAS = 12
        BLOK = 13
    }
    class ISO20022.Semt014002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Semt014002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Semt014002.SecurityIdentification20 *-- ISO20022.Semt014002.OtherIdentification2
    class ISO20022.Semt014002.SettlementStatus20Choice {
        + Prtry  : ISO20022.Semt014002.ProprietaryStatusAndReason7
        + Flng  : ISO20022.Semt014002.FailingStatus11Choice
        + Pdg  : ISO20022.Semt014002.PendingStatus45Choice
    }
    ISO20022.Semt014002.SettlementStatus20Choice *-- ISO20022.Semt014002.ProprietaryStatusAndReason7
    ISO20022.Semt014002.SettlementStatus20Choice *-- ISO20022.Semt014002.FailingStatus11Choice
    ISO20022.Semt014002.SettlementStatus20Choice *-- ISO20022.Semt014002.PendingStatus45Choice
    class ISO20022.Semt014002.SupplementaryData1 {
        + Envlp  : ISO20022.Semt014002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Semt014002.SupplementaryData1 *-- ISO20022.Semt014002.SupplementaryDataEnvelope1
    class ISO20022.Semt014002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Semt014002.TransactionIdentifications34 {
        + PrcrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
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

## Value ISO20022.Semt014002.AcknowledgedAcceptedStatus25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt014002.AcknowledgementReason13>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt014002.AcknowledgementReason13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt014002.AcknowledgementReason16Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt014002.AcknowledgementReason16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt014002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt014002.AcknowledgementReason5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LATE|Int32||XmlEnum("""LATE""")|1|
||RQWV|Int32||XmlEnum("""RQWV""")|2|
||NSTP|Int32||XmlEnum("""NSTP""")|3|
||CDRE|Int32||XmlEnum("""CDRE""")|4|
||CDRG|Int32||XmlEnum("""CDRG""")|5|
||CDCY|Int32||XmlEnum("""CDCY""")|6|
||OTHR|Int32||XmlEnum("""OTHR""")|7|
||SMPG|Int32||XmlEnum("""SMPG""")|8|
||ADEA|Int32||XmlEnum("""ADEA""")|9|

---

## Value ISO20022.Semt014002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt014002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Semt014002.CancellationReason24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt014002.CancellationReason37Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt014002.CancellationReason37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt014002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt014002.CancellationStatus25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt014002.CancellationReason24>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Semt014002.CancelledStatusReason16Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CORP|Int32||XmlEnum("""CORP""")|1|
||CANI|Int32||XmlEnum("""CANI""")|2|
||CANS|Int32||XmlEnum("""CANS""")|3|
||CSUB|Int32||XmlEnum("""CSUB""")|4|
||CANT|Int32||XmlEnum("""CANT""")|5|
||CANZ|Int32||XmlEnum("""CANZ""")|6|
||CTHP|Int32||XmlEnum("""CTHP""")|7|
||BYIY|Int32||XmlEnum("""BYIY""")|8|
||CXLR|Int32||XmlEnum("""CXLR""")|9|
||OTHR|Int32||XmlEnum("""OTHR""")|10|
||SCEX|Int32||XmlEnum("""SCEX""")|11|

---

## Value ISO20022.Semt014002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Type ISO20022.Semt014002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntraPosMvmntStsAdvc|ISO20022.Semt014002.IntraPositionMovementStatusAdvice002V07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntraPosMvmntStsAdvc))|

---

## Value ISO20022.Semt014002.FailingReason10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt014002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt014002.FailingReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INBC|Int32||XmlEnum("""INBC""")|1|
||PRSY|Int32||XmlEnum("""PRSY""")|2|
||CERT|Int32||XmlEnum("""CERT""")|3|
||SETS|Int32||XmlEnum("""SETS""")|4|
||REGT|Int32||XmlEnum("""REGT""")|5|
||PRCY|Int32||XmlEnum("""PRCY""")|6|
||LIQU|Int32||XmlEnum("""LIQU""")|7|
||LATE|Int32||XmlEnum("""LATE""")|8|
||LAAW|Int32||XmlEnum("""LAAW""")|9|
||FROZ|Int32||XmlEnum("""FROZ""")|10|
||DKNY|Int32||XmlEnum("""DKNY""")|11|
||DISA|Int32||XmlEnum("""DISA""")|12|
||DENO|Int32||XmlEnum("""DENO""")|13|
||CLHT|Int32||XmlEnum("""CLHT""")|14|
||BOTH|Int32||XmlEnum("""BOTH""")|15|
||BENO|Int32||XmlEnum("""BENO""")|16|
||PHCK|Int32||XmlEnum("""PHCK""")|17|
||OTHR|Int32||XmlEnum("""OTHR""")|18|
||IAAD|Int32||XmlEnum("""IAAD""")|19|
||MINO|Int32||XmlEnum("""MINO""")|20|
||CPEC|Int32||XmlEnum("""CPEC""")|21|
||SBLO|Int32||XmlEnum("""SBLO""")|22|
||CYCL|Int32||XmlEnum("""CYCL""")|23|
||BATC|Int32||XmlEnum("""BATC""")|24|
||SDUT|Int32||XmlEnum("""SDUT""")|25|
||REFS|Int32||XmlEnum("""REFS""")|26|
||NCON|Int32||XmlEnum("""NCON""")|27|
||MONY|Int32||XmlEnum("""MONY""")|28|
||LALO|Int32||XmlEnum("""LALO""")|29|
||LACK|Int32||XmlEnum("""LACK""")|30|
||LINK|Int32||XmlEnum("""LINK""")|31|
||INCA|Int32||XmlEnum("""INCA""")|32|
||FLIM|Int32||XmlEnum("""FLIM""")|33|
||DEPO|Int32||XmlEnum("""DEPO""")|34|
||COLL|Int32||XmlEnum("""COLL""")|35|
||YCOL|Int32||XmlEnum("""YCOL""")|36|
||CMON|Int32||XmlEnum("""CMON""")|37|
||NOFX|Int32||XmlEnum("""NOFX""")|38|
||PART|Int32||XmlEnum("""PART""")|39|
||PREA|Int32||XmlEnum("""PREA""")|40|
||GLOB|Int32||XmlEnum("""GLOB""")|41|
||MUNO|Int32||XmlEnum("""MUNO""")|42|
||CLAC|Int32||XmlEnum("""CLAC""")|43|
||NEWI|Int32||XmlEnum("""NEWI""")|44|
||CHAS|Int32||XmlEnum("""CHAS""")|45|
||BLOC|Int32||XmlEnum("""BLOC""")|46|
||DOCC|Int32||XmlEnum("""DOCC""")|47|
||MLAT|Int32||XmlEnum("""MLAT""")|48|
||DOCY|Int32||XmlEnum("""DOCY""")|49|
||STCD|Int32||XmlEnum("""STCD""")|50|
||PHSE|Int32||XmlEnum("""PHSE""")|51|
||AWSH|Int32||XmlEnum("""AWSH""")|52|
||OBJT|Int32||XmlEnum("""OBJT""")|53|
||CAIS|Int32||XmlEnum("""CAIS""")|54|
||CANR|Int32||XmlEnum("""CANR""")|55|
||ADEA|Int32||XmlEnum("""ADEA""")|56|
||CLAT|Int32||XmlEnum("""CLAT""")|57|
||BYIY|Int32||XmlEnum("""BYIY""")|58|
||AWMO|Int32||XmlEnum("""AWMO""")|59|

---

## Value ISO20022.Semt014002.FailingReason9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt014002.FailingReason10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt014002.FailingStatus11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt014002.FailingReason9>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt014002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Semt014002.GenericIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""([^/]+/)+([^/]+)\|([^/]*)"""),validPattern("""Id""",Id,"""([^/]+/)+([^/]+)\|([^/]*)"""))|

---

## Value ISO20022.Semt014002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt014002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt014002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt014002.IntraPositionDetails64


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BalTo|ISO20022.Semt014002.SecuritiesBalanceType11Choice||XmlElement()||
|+|BalFr|ISO20022.Semt014002.SecuritiesBalanceType11Choice||XmlElement()||
|+|AckdStsTmStmp|DateTime||XmlElement()||
|+|SttlmDt|ISO20022.Semt014002.DateAndDateTime2Choice||XmlElement()||
|+|LotNb|ISO20022.Semt014002.GenericIdentification39||XmlElement()||
|+|SttlmQty|ISO20022.Semt014002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Semt014002.SecurityIdentification20||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt014002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt014002.SecuritiesAccount30||XmlElement()||
|+|AcctOwnr|ISO20022.Semt014002.PartyIdentification136Choice||XmlElement()||
|+|PoolId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BalTo),validElement(BalFr),validElement(SttlmDt),validElement(LotNb),validElement(SttlmQty),validElement(FinInstrmId),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validPattern("""PoolId""",PoolId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Aspect ISO20022.Semt014002.IntraPositionMovementStatusAdvice002V07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt014002.SupplementaryData1>||XmlElement()||
|+|TxDtls|ISO20022.Semt014002.IntraPositionDetails64||XmlElement()||
|+|SttlmSts|ISO20022.Semt014002.SettlementStatus20Choice||XmlElement()||
|+|PrcgSts|ISO20022.Semt014002.IntraPositionProcessingStatus10Choice||XmlElement()||
|+|TxId|ISO20022.Semt014002.TransactionIdentifications34||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TxDtls),validElement(SttlmSts),validElement(PrcgSts),validElement(TxId))|

---

## Value ISO20022.Semt014002.IntraPositionProcessingStatus10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt014002.ProprietaryStatusAndReason7||XmlElement()||
|+|AckdAccptd|ISO20022.Semt014002.AcknowledgedAcceptedStatus25Choice||XmlElement()||
|+|Canc|ISO20022.Semt014002.CancellationStatus25Choice||XmlElement()||
|+|Rpr|ISO20022.Semt014002.RejectionOrRepairStatus45Choice||XmlElement()||
|+|Rjctd|ISO20022.Semt014002.RejectionOrRepairStatus45Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(AckdAccptd),validElement(Canc),validElement(Rpr),validElement(Rjctd),validChoice(Prtry,AckdAccptd,Canc,Rpr,Rjctd))|

---

## Enum ISO20022.Semt014002.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Semt014002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt014002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Semt014002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Semt014002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Enum ISO20022.Semt014002.PendingReason10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INBC|Int32||XmlEnum("""INBC""")|1|
||PRSY|Int32||XmlEnum("""PRSY""")|2|
||CERT|Int32||XmlEnum("""CERT""")|3|
||SETS|Int32||XmlEnum("""SETS""")|4|
||REGT|Int32||XmlEnum("""REGT""")|5|
||PRCY|Int32||XmlEnum("""PRCY""")|6|
||LIQU|Int32||XmlEnum("""LIQU""")|7|
||LATE|Int32||XmlEnum("""LATE""")|8|
||LAAW|Int32||XmlEnum("""LAAW""")|9|
||FROZ|Int32||XmlEnum("""FROZ""")|10|
||DKNY|Int32||XmlEnum("""DKNY""")|11|
||DISA|Int32||XmlEnum("""DISA""")|12|
||DENO|Int32||XmlEnum("""DENO""")|13|
||CLHT|Int32||XmlEnum("""CLHT""")|14|
||BOTH|Int32||XmlEnum("""BOTH""")|15|
||BENO|Int32||XmlEnum("""BENO""")|16|
||PHCK|Int32||XmlEnum("""PHCK""")|17|
||OTHR|Int32||XmlEnum("""OTHR""")|18|
||IAAD|Int32||XmlEnum("""IAAD""")|19|
||MINO|Int32||XmlEnum("""MINO""")|20|
||CPEC|Int32||XmlEnum("""CPEC""")|21|
||SBLO|Int32||XmlEnum("""SBLO""")|22|
||CYCL|Int32||XmlEnum("""CYCL""")|23|
||BATC|Int32||XmlEnum("""BATC""")|24|
||SDUT|Int32||XmlEnum("""SDUT""")|25|
||REFS|Int32||XmlEnum("""REFS""")|26|
||NCON|Int32||XmlEnum("""NCON""")|27|
||MONY|Int32||XmlEnum("""MONY""")|28|
||LALO|Int32||XmlEnum("""LALO""")|29|
||LACK|Int32||XmlEnum("""LACK""")|30|
||FUTU|Int32||XmlEnum("""FUTU""")|31|
||LINK|Int32||XmlEnum("""LINK""")|32|
||INCA|Int32||XmlEnum("""INCA""")|33|
||FLIM|Int32||XmlEnum("""FLIM""")|34|
||DEPO|Int32||XmlEnum("""DEPO""")|35|
||COLL|Int32||XmlEnum("""COLL""")|36|
||YCOL|Int32||XmlEnum("""YCOL""")|37|
||CMON|Int32||XmlEnum("""CMON""")|38|
||NOFX|Int32||XmlEnum("""NOFX""")|39|
||NMAS|Int32||XmlEnum("""NMAS""")|40|
||PART|Int32||XmlEnum("""PART""")|41|
||PREA|Int32||XmlEnum("""PREA""")|42|
||GLOB|Int32||XmlEnum("""GLOB""")|43|
||MUNO|Int32||XmlEnum("""MUNO""")|44|
||CLAC|Int32||XmlEnum("""CLAC""")|45|
||NEWI|Int32||XmlEnum("""NEWI""")|46|
||CHAS|Int32||XmlEnum("""CHAS""")|47|
||BLOC|Int32||XmlEnum("""BLOC""")|48|
||DOCC|Int32||XmlEnum("""DOCC""")|49|
||DOCY|Int32||XmlEnum("""DOCY""")|50|
||TAMM|Int32||XmlEnum("""TAMM""")|51|
||PHSE|Int32||XmlEnum("""PHSE""")|52|
||AWSH|Int32||XmlEnum("""AWSH""")|53|
||REFU|Int32||XmlEnum("""REFU""")|54|
||CAIS|Int32||XmlEnum("""CAIS""")|55|
||ADEA|Int32||XmlEnum("""ADEA""")|56|
||AWMO|Int32||XmlEnum("""AWMO""")|57|

---

## Value ISO20022.Semt014002.PendingReason19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt014002.PendingReason36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt014002.PendingReason36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt014002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt014002.PendingStatus45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt014002.PendingReason19>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt014002.ProprietaryReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Semt014002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Rsn))|

---

## Value ISO20022.Semt014002.ProprietaryStatusAndReason7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Semt014002.ProprietaryReason5>||XmlElement()||
|+|PrtrySts|ISO20022.Semt014002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Semt014002.RejectionAndRepairReason40Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt014002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt014002.RejectionOrRepairReason40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|global::System.Collections.Generic.List<ISO20022.Semt014002.RejectionAndRepairReason40Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validList("""Cd""",Cd),validElement(Cd))|

---

## Value ISO20022.Semt014002.RejectionOrRepairStatus45Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt014002.RejectionOrRepairReason40>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Semt014002.RejectionReason69Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VALR|Int32||XmlEnum("""VALR""")|1|
||MUNO|Int32||XmlEnum("""MUNO""")|2|
||MINO|Int32||XmlEnum("""MINO""")|3|
||INVN|Int32||XmlEnum("""INVN""")|4|
||INVL|Int32||XmlEnum("""INVL""")|5|
||INVB|Int32||XmlEnum("""INVB""")|6|
||DSEC|Int32||XmlEnum("""DSEC""")|7|
||DQUA|Int32||XmlEnum("""DQUA""")|8|
||OTHR|Int32||XmlEnum("""OTHR""")|9|
||REFE|Int32||XmlEnum("""REFE""")|10|
||DDAT|Int32||XmlEnum("""DDAT""")|11|
||CAEV|Int32||XmlEnum("""CAEV""")|12|
||LATE|Int32||XmlEnum("""LATE""")|13|
||ADEA|Int32||XmlEnum("""ADEA""")|14|
||SAFE|Int32||XmlEnum("""SAFE""")|15|

---

## Value ISO20022.Semt014002.SecuritiesAccount30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt014002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Semt014002.SecuritiesBalanceType11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt014002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt014002.SecuritiesBalanceType13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COLA|Int32||XmlEnum("""COLA""")|1|
||QUAS|Int32||XmlEnum("""QUAS""")|2|
||ISSU|Int32||XmlEnum("""ISSU""")|3|
||UNRG|Int32||XmlEnum("""UNRG""")|4|
||SPOS|Int32||XmlEnum("""SPOS""")|5|
||OTHR|Int32||XmlEnum("""OTHR""")|6|
||RSTR|Int32||XmlEnum("""RSTR""")|7|
||REGO|Int32||XmlEnum("""REGO""")|8|
||PLED|Int32||XmlEnum("""PLED""")|9|
||NOMI|Int32||XmlEnum("""NOMI""")|10|
||AVAI|Int32||XmlEnum("""AVAI""")|11|
||AWAS|Int32||XmlEnum("""AWAS""")|12|
||BLOK|Int32||XmlEnum("""BLOK""")|13|

---

## Value ISO20022.Semt014002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Semt014002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Semt014002.SettlementStatus20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt014002.ProprietaryStatusAndReason7||XmlElement()||
|+|Flng|ISO20022.Semt014002.FailingStatus11Choice||XmlElement()||
|+|Pdg|ISO20022.Semt014002.PendingStatus45Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Flng),validElement(Pdg),validChoice(Prtry,Flng,Pdg))|

---

## Value ISO20022.Semt014002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Semt014002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Semt014002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt014002.TransactionIdentifications34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrcrTxId""",PrcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktInfrstrctrTxId""",MktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrTxId""",AcctSvcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctOwnrTxId""",AcctOwnrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

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

