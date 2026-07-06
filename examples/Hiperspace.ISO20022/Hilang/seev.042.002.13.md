# seev.042.002.13
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev042002.AccountIdentification74 {
        + CorpActnEvtAndBal  : global::System.Collections.Generic.List~ISO20022.Seev042002.CorporateActionEventAndBalance27~
        + SfkpgPlc  : ISO20022.Seev042002.SafekeepingPlaceFormat46Choice
        + AcctOwnr  : ISO20022.Seev042002.PartyIdentification136Choice
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
    }
    ISO20022.Seev042002.AccountIdentification74 *-- ISO20022.Seev042002.CorporateActionEventAndBalance27
    ISO20022.Seev042002.AccountIdentification74 *-- ISO20022.Seev042002.SafekeepingPlaceFormat46Choice
    ISO20022.Seev042002.AccountIdentification74 *-- ISO20022.Seev042002.PartyIdentification136Choice
    class ISO20022.Seev042002.AmountPrice5 {
        + PricVal  : ISO20022.Seev042002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev042002.AmountPrice5 *-- ISO20022.Seev042002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev042002.AmountPriceType1Code {
        PREM = 1
        PLOT = 2
        DISC = 3
        ACTU = 4
    }
    class ISO20022.Seev042002.BalanceFormat14Choice {
        + NotElgblBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + ElgblBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + Bal  : ISO20022.Seev042002.SignedQuantityFormat12
    }
    ISO20022.Seev042002.BalanceFormat14Choice *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.BalanceFormat14Choice *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.BalanceFormat14Choice *-- ISO20022.Seev042002.SignedQuantityFormat12
    class ISO20022.Seev042002.CancelledReason11Choice {
        + Prtry  : ISO20022.Seev042002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev042002.CancelledReason11Choice *-- ISO20022.Seev042002.GenericIdentification47
    class ISO20022.Seev042002.CancelledStatus15Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev042002.CancelledStatusReason14~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev042002.CancelledStatus15Choice *-- ISO20022.Seev042002.CancelledStatusReason14
    class ISO20022.Seev042002.CancelledStatusReason14 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev042002.CancelledReason11Choice
    }
    ISO20022.Seev042002.CancelledStatusReason14 *-- ISO20022.Seev042002.CancelledReason11Choice
    class ISO20022.Seev042002.CancelledStatusReason6Code {
        OTHR = 1
        CSUB = 2
        CANS = 3
        CANO = 4
        CANI = 5
    }
    class ISO20022.Seev042002.CorporateActionBalance51 {
        + PdgRctBal  : global::System.Collections.Generic.List~ISO20022.Seev042002.PendingBalance8~
        + PdgDlvryBal  : global::System.Collections.Generic.List~ISO20022.Seev042002.PendingBalance8~
        + OblgtdBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + RegdBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + InTrnsShipmntBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + TradDtPosBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + StrtPosBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + SttlmPosBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + OutForRegnBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + OnLnBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + CollOutBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + CollInBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + BrrwdBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + BlckdBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + TtlInstdBalDtls  : ISO20022.Seev042002.InstructedBalance21
        + UinstdBal  : ISO20022.Seev042002.BalanceFormat14Choice
        + TtlElgblBal  : ISO20022.Seev042002.Quantity80Choice
    }
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.PendingBalance8
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.PendingBalance8
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.InstructedBalance21
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.BalanceFormat14Choice
    ISO20022.Seev042002.CorporateActionBalance51 *-- ISO20022.Seev042002.Quantity80Choice
    class ISO20022.Seev042002.CorporateActionEventAndBalance27 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev042002.SupplementaryData1~
        + Bal  : ISO20022.Seev042002.CorporateActionBalance51
        + UndrlygScty  : ISO20022.Seev042002.SecurityIdentification20
        + GnlInf  : ISO20022.Seev042002.EventInformation18
    }
    ISO20022.Seev042002.CorporateActionEventAndBalance27 *-- ISO20022.Seev042002.SupplementaryData1
    ISO20022.Seev042002.CorporateActionEventAndBalance27 *-- ISO20022.Seev042002.CorporateActionBalance51
    ISO20022.Seev042002.CorporateActionEventAndBalance27 *-- ISO20022.Seev042002.SecurityIdentification20
    ISO20022.Seev042002.CorporateActionEventAndBalance27 *-- ISO20022.Seev042002.EventInformation18
    class ISO20022.Seev042002.CorporateActionEventDeadlines4 {
        + CoverPrtctDdln  : ISO20022.Seev042002.DateFormat49Choice
        + PrtctDdln  : ISO20022.Seev042002.DateFormat49Choice
        + MktDdln  : ISO20022.Seev042002.DateFormat49Choice
        + RspnDdln  : ISO20022.Seev042002.DateFormat54Choice
        + EarlyRspnDdln  : ISO20022.Seev042002.DateFormat49Choice
    }
    ISO20022.Seev042002.CorporateActionEventDeadlines4 *-- ISO20022.Seev042002.DateFormat49Choice
    ISO20022.Seev042002.CorporateActionEventDeadlines4 *-- ISO20022.Seev042002.DateFormat49Choice
    ISO20022.Seev042002.CorporateActionEventDeadlines4 *-- ISO20022.Seev042002.DateFormat49Choice
    ISO20022.Seev042002.CorporateActionEventDeadlines4 *-- ISO20022.Seev042002.DateFormat54Choice
    ISO20022.Seev042002.CorporateActionEventDeadlines4 *-- ISO20022.Seev042002.DateFormat49Choice
    class ISO20022.Seev042002.CorporateActionEventType117Choice {
        + Prtry  : ISO20022.Seev042002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev042002.CorporateActionEventType117Choice *-- ISO20022.Seev042002.GenericIdentification47
    class ISO20022.Seev042002.CorporateActionEventType40Code {
        ACCU = 1
        WRTH = 2
        WTRC = 3
        EXWA = 4
        SUSP = 5
        DLST = 6
        TEND = 7
        TREC = 8
        SPLF = 9
        DVSE = 10
        SOFF = 11
        SMAL = 12
        SHPR = 13
        DVSC = 14
        RHTS = 15
        SPLR = 16
        BIDS = 17
        REMK = 18
        REDO = 19
        BPUT = 20
        PRIO = 21
        PDEF = 22
        PLAC = 23
        PINK = 24
        PRED = 25
        PCAL = 26
        PARI = 27
        OTHR = 28
        ODLT = 29
        CERT = 30
        NOOF = 31
        MRGR = 32
        EXTM = 33
        LIQU = 34
        RHDI = 35
        INTR = 36
        PPMT = 37
        INCR = 38
        MCAL = 39
        REDM = 40
        EXOF = 41
        DTCH = 42
        DRAW = 43
        DRIP = 44
        DVOP = 45
        DSCL = 46
        DETI = 47
        DECR = 48
        CREV = 49
        CONV = 50
        CONS = 51
        CLSA = 52
        COOP = 53
        CHAN = 54
        DVCA = 55
        DRCA = 56
        CAPI = 57
        CAPG = 58
        CAPD = 59
        EXRI = 60
        BONU = 61
        DFLT = 62
        BRUP = 63
        ATTI = 64
        ACTV = 65
    }
    class ISO20022.Seev042002.CorporateActionInstructionStatementReport002V13 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev042002.SupplementaryData1~
        + AcctAndStmtDtls  : global::System.Collections.Generic.List~ISO20022.Seev042002.AccountIdentification74~
        + StmtGnlDtls  : ISO20022.Seev042002.Statement75
        + Pgntn  : ISO20022.Seev042002.Pagination1
    }
    ISO20022.Seev042002.CorporateActionInstructionStatementReport002V13 *-- ISO20022.Seev042002.SupplementaryData1
    ISO20022.Seev042002.CorporateActionInstructionStatementReport002V13 *-- ISO20022.Seev042002.AccountIdentification74
    ISO20022.Seev042002.CorporateActionInstructionStatementReport002V13 *-- ISO20022.Seev042002.Statement75
    ISO20022.Seev042002.CorporateActionInstructionStatementReport002V13 *-- ISO20022.Seev042002.Pagination1
    class ISO20022.Seev042002.CorporateActionMandatoryVoluntary1Code {
        VOLU = 1
        CHOS = 2
        MAND = 3
    }
    class ISO20022.Seev042002.CorporateActionMandatoryVoluntary4Choice {
        + Prtry  : ISO20022.Seev042002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev042002.CorporateActionMandatoryVoluntary4Choice *-- ISO20022.Seev042002.GenericIdentification47
    class ISO20022.Seev042002.CorporateActionOption11Code {
        PRUN = 1
        SLLE = 2
        SECU = 3
        QINV = 4
        OVER = 5
        OTHR = 6
        OFFR = 7
        NOQU = 8
        NOAC = 9
        MPUT = 10
        LAPS = 11
        EXER = 12
        CTEN = 13
        CONY = 14
        CONN = 15
        CEXC = 16
        CASH = 17
        CASE = 18
        BUYA = 19
        BSPL = 20
        ABST = 21
    }
    class ISO20022.Seev042002.CorporateActionOption36Choice {
        + Prtry  : ISO20022.Seev042002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev042002.CorporateActionOption36Choice *-- ISO20022.Seev042002.GenericIdentification47
    class ISO20022.Seev042002.CorporateActionStatementReportingType1Code {
        SAME = 1
        MASE = 2
    }
    class ISO20022.Seev042002.CorporateActionStatementType2Code {
        BALI = 1
        BALO = 2
        ALLL = 3
        MISS = 4
    }
    class ISO20022.Seev042002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Seev042002.DateCode22Choice {
        + Prtry  : ISO20022.Seev042002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev042002.DateCode22Choice *-- ISO20022.Seev042002.GenericIdentification47
    class ISO20022.Seev042002.DateCode26Choice {
        + Prtry  : ISO20022.Seev042002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev042002.DateCode26Choice *-- ISO20022.Seev042002.GenericIdentification47
    class ISO20022.Seev042002.DateCodeAndTimeFormat4 {
        + Tm  : DateTime
        + DtCd  : ISO20022.Seev042002.DateCode26Choice
    }
    ISO20022.Seev042002.DateCodeAndTimeFormat4 *-- ISO20022.Seev042002.DateCode26Choice
    class ISO20022.Seev042002.DateFormat49Choice {
        + DtCd  : ISO20022.Seev042002.DateCode22Choice
        + Dt  : ISO20022.Seev042002.DateAndDateTime2Choice
    }
    ISO20022.Seev042002.DateFormat49Choice *-- ISO20022.Seev042002.DateCode22Choice
    ISO20022.Seev042002.DateFormat49Choice *-- ISO20022.Seev042002.DateAndDateTime2Choice
    class ISO20022.Seev042002.DateFormat54Choice {
        + DtCd  : ISO20022.Seev042002.DateCode22Choice
        + DtCdAndTm  : ISO20022.Seev042002.DateCodeAndTimeFormat4
        + Dt  : ISO20022.Seev042002.DateAndDateTime2Choice
    }
    ISO20022.Seev042002.DateFormat54Choice *-- ISO20022.Seev042002.DateCode22Choice
    ISO20022.Seev042002.DateFormat54Choice *-- ISO20022.Seev042002.DateCodeAndTimeFormat4
    ISO20022.Seev042002.DateFormat54Choice *-- ISO20022.Seev042002.DateAndDateTime2Choice
    class ISO20022.Seev042002.DateOrDateTimePeriod1Choice {
        + DtTm  : ISO20022.Seev042002.DateTimePeriod1
        + Dt  : ISO20022.Seev042002.DatePeriod2
    }
    ISO20022.Seev042002.DateOrDateTimePeriod1Choice *-- ISO20022.Seev042002.DateTimePeriod1
    ISO20022.Seev042002.DateOrDateTimePeriod1Choice *-- ISO20022.Seev042002.DatePeriod2
    class ISO20022.Seev042002.DatePeriod2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Seev042002.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Seev042002.DateType7Code {
        ONGO = 1
    }
    class ISO20022.Seev042002.DateType8Code {
        ONGO = 1
        UKWN = 2
    }
    class ISO20022.Seev042002.DefaultProcessingOrStandingInstruction2Choice {
        + StgInstrInd  : String
        + DfltOptnInd  : String
    }
    class ISO20022.Seev042002.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Seev042002.EventFrequency4Code {
        WEEK = 1
        INDA = 2
        DAIL = 3
        MNTH = 4
        ADHO = 5
        YEAR = 6
    }
    class ISO20022.Seev042002.EventInformation18 {
        + LastNtfctnId  : ISO20022.Seev042002.NotificationIdentification6
        + MndtryVlntryEvtTp  : ISO20022.Seev042002.CorporateActionMandatoryVoluntary4Choice
        + EvtTp  : ISO20022.Seev042002.CorporateActionEventType117Choice
        + OffclCorpActnEvtId  : String
        + CorpActnEvtId  : String
    }
    ISO20022.Seev042002.EventInformation18 *-- ISO20022.Seev042002.NotificationIdentification6
    ISO20022.Seev042002.EventInformation18 *-- ISO20022.Seev042002.CorporateActionMandatoryVoluntary4Choice
    ISO20022.Seev042002.EventInformation18 *-- ISO20022.Seev042002.CorporateActionEventType117Choice
    class ISO20022.Seev042002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev042002.Frequency26Choice {
        + Prtry  : ISO20022.Seev042002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev042002.Frequency26Choice *-- ISO20022.Seev042002.GenericIdentification47
    class ISO20022.Seev042002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev042002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev042002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Seev042002.GenericIdentification47
    }
    ISO20022.Seev042002.GenericIdentification85 *-- ISO20022.Seev042002.GenericIdentification47
    class ISO20022.Seev042002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev042002.InstructedBalance21 {
        + OptnDtls  : global::System.Collections.Generic.List~ISO20022.Seev042002.InstructedCorporateActionOption22~
        + TtlPrtctInstrBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + TtlRjctdInstrBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + TtlPdgInstrBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + TtlCancInstrBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + TtlAccptdInstrBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + TtlInstdBal  : ISO20022.Seev042002.BalanceFormat14Choice
    }
    ISO20022.Seev042002.InstructedBalance21 *-- ISO20022.Seev042002.InstructedCorporateActionOption22
    ISO20022.Seev042002.InstructedBalance21 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.InstructedBalance21 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.InstructedBalance21 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.InstructedBalance21 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.InstructedBalance21 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.InstructedBalance21 *-- ISO20022.Seev042002.BalanceFormat14Choice
    class ISO20022.Seev042002.InstructedCorporateActionOption22 {
        + OptnInstrDtls  : global::System.Collections.Generic.List~ISO20022.Seev042002.OptionInstructionDetails12~
        + EvtDdlns  : ISO20022.Seev042002.CorporateActionEventDeadlines4
        + OptnPrtctInstrBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + OptnRtrdInstdBal  : ISO20022.Seev042002.SignedQuantityFormat16
        + OptnRjctdInstrBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + OptnPdgInstrBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + OptnCancInstrBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + OptnAccptdInstdBal  : ISO20022.Seev042002.SignedQuantityFormat13
        + DfltActn  : ISO20022.Seev042002.DefaultProcessingOrStandingInstruction2Choice
        + InstdBal  : ISO20022.Seev042002.BalanceFormat14Choice
        + OptnTp  : ISO20022.Seev042002.CorporateActionOption36Choice
        + OptnNb  : String
    }
    ISO20022.Seev042002.InstructedCorporateActionOption22 *-- ISO20022.Seev042002.OptionInstructionDetails12
    ISO20022.Seev042002.InstructedCorporateActionOption22 *-- ISO20022.Seev042002.CorporateActionEventDeadlines4
    ISO20022.Seev042002.InstructedCorporateActionOption22 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.InstructedCorporateActionOption22 *-- ISO20022.Seev042002.SignedQuantityFormat16
    ISO20022.Seev042002.InstructedCorporateActionOption22 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.InstructedCorporateActionOption22 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.InstructedCorporateActionOption22 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.InstructedCorporateActionOption22 *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.InstructedCorporateActionOption22 *-- ISO20022.Seev042002.DefaultProcessingOrStandingInstruction2Choice
    ISO20022.Seev042002.InstructedCorporateActionOption22 *-- ISO20022.Seev042002.BalanceFormat14Choice
    ISO20022.Seev042002.InstructedCorporateActionOption22 *-- ISO20022.Seev042002.CorporateActionOption36Choice
    class ISO20022.Seev042002.InstructionProcessingStatus57Choice {
        + Rtrd  : ISO20022.Seev042002.ReturnedStatus1Choice
        + Ucvrd  : ISO20022.Seev042002.NoSpecifiedReason1
        + Cvrd  : ISO20022.Seev042002.NoSpecifiedReason1
        + PdgCxl  : ISO20022.Seev042002.PendingCancellationStatus16Choice
        + Pdg  : ISO20022.Seev042002.PendingStatus72Choice
        + Rjctd  : ISO20022.Seev042002.RejectedStatus59Choice
        + AccptdForFrthrPrcg  : ISO20022.Seev042002.NoSpecifiedReason1
        + Canc  : ISO20022.Seev042002.CancelledStatus15Choice
        + Accptd  : ISO20022.Seev042002.NoSpecifiedReason1
    }
    ISO20022.Seev042002.InstructionProcessingStatus57Choice *-- ISO20022.Seev042002.ReturnedStatus1Choice
    ISO20022.Seev042002.InstructionProcessingStatus57Choice *-- ISO20022.Seev042002.NoSpecifiedReason1
    ISO20022.Seev042002.InstructionProcessingStatus57Choice *-- ISO20022.Seev042002.NoSpecifiedReason1
    ISO20022.Seev042002.InstructionProcessingStatus57Choice *-- ISO20022.Seev042002.PendingCancellationStatus16Choice
    ISO20022.Seev042002.InstructionProcessingStatus57Choice *-- ISO20022.Seev042002.PendingStatus72Choice
    ISO20022.Seev042002.InstructionProcessingStatus57Choice *-- ISO20022.Seev042002.RejectedStatus59Choice
    ISO20022.Seev042002.InstructionProcessingStatus57Choice *-- ISO20022.Seev042002.NoSpecifiedReason1
    ISO20022.Seev042002.InstructionProcessingStatus57Choice *-- ISO20022.Seev042002.CancelledStatus15Choice
    ISO20022.Seev042002.InstructionProcessingStatus57Choice *-- ISO20022.Seev042002.NoSpecifiedReason1
    class ISO20022.Seev042002.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Seev042002.NoSpecifiedReason1 {
        + NoSpcfdRsn  : String
    }
    class ISO20022.Seev042002.NotificationIdentification6 {
        + CreDtTm  : ISO20022.Seev042002.DateAndDateTime2Choice
        + Id  : String
    }
    ISO20022.Seev042002.NotificationIdentification6 *-- ISO20022.Seev042002.DateAndDateTime2Choice
    class ISO20022.Seev042002.OptionInstructionDetails12 {
        + InstrSts  : ISO20022.Seev042002.InstructionProcessingStatus57Choice
        + InstrNrrtv  : String
        + CstmrRef  : String
        + CondlQty  : ISO20022.Seev042002.FinancialInstrumentQuantity36Choice
        + BidPric  : ISO20022.Seev042002.PriceFormat82Choice
        + CoverPrtctDt  : DateTime
        + PrtctDt  : DateTime
        + InstrDt  : DateTime
        + InstrQty  : ISO20022.Seev042002.FinancialInstrumentQuantity36Choice
        + PrtctInd  : String
        + InstrSeqNb  : String
        + InstrId  : String
    }
    ISO20022.Seev042002.OptionInstructionDetails12 *-- ISO20022.Seev042002.InstructionProcessingStatus57Choice
    ISO20022.Seev042002.OptionInstructionDetails12 *-- ISO20022.Seev042002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev042002.OptionInstructionDetails12 *-- ISO20022.Seev042002.PriceFormat82Choice
    ISO20022.Seev042002.OptionInstructionDetails12 *-- ISO20022.Seev042002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev042002.OriginalAndCurrentQuantities7 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev042002.OtherIdentification2 {
        + Tp  : ISO20022.Seev042002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev042002.OtherIdentification2 *-- ISO20022.Seev042002.IdentificationSource4Choice
    class ISO20022.Seev042002.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Seev042002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Seev042002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Seev042002.PartyIdentification136Choice *-- ISO20022.Seev042002.GenericIdentification84
    class ISO20022.Seev042002.PendingBalance8 {
        + PdgTxs  : global::System.Collections.Generic.List~ISO20022.Seev042002.SettlementTypeAndIdentification26~
        + Bal  : ISO20022.Seev042002.SignedQuantityFormat13
    }
    ISO20022.Seev042002.PendingBalance8 *-- ISO20022.Seev042002.SettlementTypeAndIdentification26
    ISO20022.Seev042002.PendingBalance8 *-- ISO20022.Seev042002.SignedQuantityFormat13
    class ISO20022.Seev042002.PendingCancellationReason5Code {
        OTHR = 1
        LATE = 2
        DQCS = 3
        DQUA = 4
        ADEA = 5
    }
    class ISO20022.Seev042002.PendingCancellationReason6Choice {
        + Prtry  : ISO20022.Seev042002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev042002.PendingCancellationReason6Choice *-- ISO20022.Seev042002.GenericIdentification47
    class ISO20022.Seev042002.PendingCancellationStatus16Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev042002.PendingCancellationStatusReason9~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev042002.PendingCancellationStatus16Choice *-- ISO20022.Seev042002.PendingCancellationStatusReason9
    class ISO20022.Seev042002.PendingCancellationStatusReason9 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev042002.PendingCancellationReason6Choice
    }
    ISO20022.Seev042002.PendingCancellationStatusReason9 *-- ISO20022.Seev042002.PendingCancellationReason6Choice
    class ISO20022.Seev042002.PendingReason27Code {
        IPED = 1
        IPAW = 2
        BSTR = 3
        SNAV = 4
        MTAX = 5
        NTAX = 6
        ITAX = 7
        DQCS = 8
        CERT = 9
        PENR = 10
        DQUA = 11
        LATE = 12
        LACK = 13
        MONY = 14
        MCER = 15
        FULL = 16
        OTHR = 17
        ADEA = 18
    }
    class ISO20022.Seev042002.PendingReason68Choice {
        + Prtry  : ISO20022.Seev042002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev042002.PendingReason68Choice *-- ISO20022.Seev042002.GenericIdentification47
    class ISO20022.Seev042002.PendingStatus72Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev042002.PendingStatusReason28~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev042002.PendingStatus72Choice *-- ISO20022.Seev042002.PendingStatusReason28
    class ISO20022.Seev042002.PendingStatusReason28 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev042002.PendingReason68Choice
    }
    ISO20022.Seev042002.PendingStatusReason28 *-- ISO20022.Seev042002.PendingReason68Choice
    class ISO20022.Seev042002.PercentagePrice2 {
        + PricVal  : Decimal
        + PctgPricTp  : String
    }
    class ISO20022.Seev042002.PriceFormat82Choice {
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev042002.AmountPrice5
        + PctgPric  : ISO20022.Seev042002.PercentagePrice2
    }
    ISO20022.Seev042002.PriceFormat82Choice *-- ISO20022.Seev042002.AmountPrice5
    ISO20022.Seev042002.PriceFormat82Choice *-- ISO20022.Seev042002.PercentagePrice2
    class ISO20022.Seev042002.PriceRateType3Code {
        YIEL = 1
        PRCT = 2
        PREM = 3
        DISC = 4
    }
    class ISO20022.Seev042002.PriceValueType10Code {
        UKWN = 1
    }
    class ISO20022.Seev042002.ProprietaryQuantity10 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev042002.ProprietaryQuantity9 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
    }
    class ISO20022.Seev042002.ProtectTransactionType2Code {
        COVR = 1
        COVP = 2
        PROT = 3
    }
    class ISO20022.Seev042002.Quantity53Choice {
        + PrtryQty  : ISO20022.Seev042002.ProprietaryQuantity9
        + Qty  : ISO20022.Seev042002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Seev042002.Quantity53Choice *-- ISO20022.Seev042002.ProprietaryQuantity9
    ISO20022.Seev042002.Quantity53Choice *-- ISO20022.Seev042002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev042002.Quantity57Choice {
        + SgndQty  : ISO20022.Seev042002.SignedQuantityFormat13
        + OrgnlAndCurFaceAmt  : ISO20022.Seev042002.OriginalAndCurrentQuantities7
    }
    ISO20022.Seev042002.Quantity57Choice *-- ISO20022.Seev042002.SignedQuantityFormat13
    ISO20022.Seev042002.Quantity57Choice *-- ISO20022.Seev042002.OriginalAndCurrentQuantities7
    class ISO20022.Seev042002.Quantity80Choice {
        + PrtryQty  : ISO20022.Seev042002.ProprietaryQuantity10
        + QtyChc  : ISO20022.Seev042002.Quantity57Choice
    }
    ISO20022.Seev042002.Quantity80Choice *-- ISO20022.Seev042002.ProprietaryQuantity10
    ISO20022.Seev042002.Quantity80Choice *-- ISO20022.Seev042002.Quantity57Choice
    class ISO20022.Seev042002.RejectedReason61Choice {
        + Prtry  : ISO20022.Seev042002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev042002.RejectedReason61Choice *-- ISO20022.Seev042002.GenericIdentification47
    class ISO20022.Seev042002.RejectedStatus59Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev042002.RejectedStatusReason58~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev042002.RejectedStatus59Choice *-- ISO20022.Seev042002.RejectedStatusReason58
    class ISO20022.Seev042002.RejectedStatusReason58 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev042002.RejectedReason61Choice
    }
    ISO20022.Seev042002.RejectedStatusReason58 *-- ISO20022.Seev042002.RejectedReason61Choice
    class ISO20022.Seev042002.RejectionReason86Code {
        IPED = 1
        IPAW = 2
        REJA = 3
        TRTI = 4
        PRON = 5
        PROT = 6
        PROI = 7
        DUPL = 8
        CTCT = 9
        BSTR = 10
        SHAR = 11
        INIR = 12
        DPRG = 13
        DCAN = 14
        DQBI = 15
        DQBV = 16
        IRDQ = 17
        DQAM = 18
        DQCC = 19
        DQCS = 20
        EVNM = 21
        SAFE = 22
        REFT = 23
        DQUA = 24
        OTHR = 25
        OPNM = 26
        INTV = 27
        CANC = 28
        FULL = 29
        NMTY = 30
        LATE = 31
        LACK = 32
        DSEC = 33
        ULNK = 34
        OPTY = 35
        INVA = 36
        CERT = 37
        ADEA = 38
    }
    class ISO20022.Seev042002.RestrictedFINActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev042002.ReturnedReason1Choice {
        + Prtry  : ISO20022.Seev042002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev042002.ReturnedReason1Choice *-- ISO20022.Seev042002.GenericIdentification47
    class ISO20022.Seev042002.ReturnedStatus1Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev042002.ReturnedStatusReason1~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev042002.ReturnedStatus1Choice *-- ISO20022.Seev042002.ReturnedStatusReason1
    class ISO20022.Seev042002.ReturnedStatus1Code {
        PROR = 1
        NARR = 2
    }
    class ISO20022.Seev042002.ReturnedStatusReason1 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev042002.ReturnedReason1Choice
    }
    ISO20022.Seev042002.ReturnedStatusReason1 *-- ISO20022.Seev042002.ReturnedReason1Choice
    class ISO20022.Seev042002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Seev042002.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Seev042002.SafekeepingPlaceFormat46Choice {
        + Prtry  : ISO20022.Seev042002.GenericIdentification85
        + TpAndId  : ISO20022.Seev042002.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev042002.SafekeepingPlaceTypeAndText9
    }
    ISO20022.Seev042002.SafekeepingPlaceFormat46Choice *-- ISO20022.Seev042002.GenericIdentification85
    ISO20022.Seev042002.SafekeepingPlaceFormat46Choice *-- ISO20022.Seev042002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev042002.SafekeepingPlaceFormat46Choice *-- ISO20022.Seev042002.SafekeepingPlaceTypeAndText9
    class ISO20022.Seev042002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev042002.SafekeepingPlaceTypeAndText9 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev042002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev042002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Seev042002.SecurityIdentification20 *-- ISO20022.Seev042002.OtherIdentification2
    class ISO20022.Seev042002.SettlementTypeAndIdentification26 {
        + SttlmDt  : ISO20022.Seev042002.DateAndDateTime2Choice
        + TxId  : String
        + Pmt  : String
    }
    ISO20022.Seev042002.SettlementTypeAndIdentification26 *-- ISO20022.Seev042002.DateAndDateTime2Choice
    class ISO20022.Seev042002.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Seev042002.SignedQuantityFormat12 {
        + QtyChc  : ISO20022.Seev042002.Quantity53Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev042002.SignedQuantityFormat12 *-- ISO20022.Seev042002.Quantity53Choice
    class ISO20022.Seev042002.SignedQuantityFormat13 {
        + Qty  : ISO20022.Seev042002.FinancialInstrumentQuantity36Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev042002.SignedQuantityFormat13 *-- ISO20022.Seev042002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev042002.SignedQuantityFormat16 {
        + Qty  : ISO20022.Seev042002.FinancialInstrumentQuantity36Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev042002.SignedQuantityFormat16 *-- ISO20022.Seev042002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev042002.Statement75 {
        + NtfctnDdlnPrd  : ISO20022.Seev042002.DateOrDateTimePeriod1Choice
        + ActvtyInd  : String
        + UpdTp  : ISO20022.Seev042002.UpdateType16Choice
        + Frqcy  : ISO20022.Seev042002.Frequency26Choice
        + StmtDtTm  : ISO20022.Seev042002.DateAndDateTime2Choice
        + RptNb  : String
        + InstrAggtnPrd  : ISO20022.Seev042002.DatePeriod2
        + StmtId  : String
        + RptgTp  : String
        + StmtTp  : String
    }
    ISO20022.Seev042002.Statement75 *-- ISO20022.Seev042002.DateOrDateTimePeriod1Choice
    ISO20022.Seev042002.Statement75 *-- ISO20022.Seev042002.UpdateType16Choice
    ISO20022.Seev042002.Statement75 *-- ISO20022.Seev042002.Frequency26Choice
    ISO20022.Seev042002.Statement75 *-- ISO20022.Seev042002.DateAndDateTime2Choice
    ISO20022.Seev042002.Statement75 *-- ISO20022.Seev042002.DatePeriod2
    class ISO20022.Seev042002.StatementUpdateType1Code {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Seev042002.SupplementaryData1 {
        + Envlp  : ISO20022.Seev042002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev042002.SupplementaryData1 *-- ISO20022.Seev042002.SupplementaryDataEnvelope1
    class ISO20022.Seev042002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Seev042002.UpdateType16Choice {
        + Prtry  : ISO20022.Seev042002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev042002.UpdateType16Choice *-- ISO20022.Seev042002.GenericIdentification47
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

## Value ISO20022.Seev042002.AccountIdentification74


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnEvtAndBal|global::System.Collections.Generic.List<ISO20022.Seev042002.CorporateActionEventAndBalance27>||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev042002.SafekeepingPlaceFormat46Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Seev042002.PartyIdentification136Choice||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CorpActnEvtAndBal""",CorpActnEvtAndBal),validElement(CorpActnEvtAndBal),validElement(SfkpgPlc),validElement(AcctOwnr),validPattern("""BlckChainAdrOrWllt""",BlckChainAdrOrWllt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""SfkpgAcct""",SfkpgAcct,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Seev042002.AmountPrice5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev042002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Enum ISO20022.Seev042002.AmountPriceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREM|Int32||XmlEnum("""PREM""")|1|
||PLOT|Int32||XmlEnum("""PLOT""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|
||ACTU|Int32||XmlEnum("""ACTU""")|4|

---

## Value ISO20022.Seev042002.BalanceFormat14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotElgblBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|ElgblBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|Bal|ISO20022.Seev042002.SignedQuantityFormat12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotElgblBal),validElement(ElgblBal),validElement(Bal),validChoice(NotElgblBal,ElgblBal,Bal))|

---

## Value ISO20022.Seev042002.CancelledReason11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev042002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev042002.CancelledStatus15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev042002.CancelledStatusReason14>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev042002.CancelledStatusReason14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev042002.CancelledReason11Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(RsnCd))|

---

## Enum ISO20022.Seev042002.CancelledStatusReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||CSUB|Int32||XmlEnum("""CSUB""")|2|
||CANS|Int32||XmlEnum("""CANS""")|3|
||CANO|Int32||XmlEnum("""CANO""")|4|
||CANI|Int32||XmlEnum("""CANI""")|5|

---

## Value ISO20022.Seev042002.CorporateActionBalance51


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PdgRctBal|global::System.Collections.Generic.List<ISO20022.Seev042002.PendingBalance8>||XmlElement()||
|+|PdgDlvryBal|global::System.Collections.Generic.List<ISO20022.Seev042002.PendingBalance8>||XmlElement()||
|+|OblgtdBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|RegdBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|InTrnsShipmntBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|TradDtPosBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|StrtPosBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|SttlmPosBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|OutForRegnBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|OnLnBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|CollOutBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|CollInBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|BrrwdBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|BlckdBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|TtlInstdBalDtls|ISO20022.Seev042002.InstructedBalance21||XmlElement()||
|+|UinstdBal|ISO20022.Seev042002.BalanceFormat14Choice||XmlElement()||
|+|TtlElgblBal|ISO20022.Seev042002.Quantity80Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PdgRctBal""",PdgRctBal),validElement(PdgRctBal),validList("""PdgDlvryBal""",PdgDlvryBal),validElement(PdgDlvryBal),validElement(OblgtdBal),validElement(RegdBal),validElement(InTrnsShipmntBal),validElement(TradDtPosBal),validElement(StrtPosBal),validElement(SttlmPosBal),validElement(OutForRegnBal),validElement(OnLnBal),validElement(CollOutBal),validElement(CollInBal),validElement(BrrwdBal),validElement(BlckdBal),validElement(TtlInstdBalDtls),validElement(UinstdBal),validElement(TtlElgblBal))|

---

## Value ISO20022.Seev042002.CorporateActionEventAndBalance27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev042002.SupplementaryData1>||XmlElement()||
|+|Bal|ISO20022.Seev042002.CorporateActionBalance51||XmlElement()||
|+|UndrlygScty|ISO20022.Seev042002.SecurityIdentification20||XmlElement()||
|+|GnlInf|ISO20022.Seev042002.EventInformation18||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Bal),validElement(UndrlygScty),validElement(GnlInf))|

---

## Value ISO20022.Seev042002.CorporateActionEventDeadlines4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CoverPrtctDdln|ISO20022.Seev042002.DateFormat49Choice||XmlElement()||
|+|PrtctDdln|ISO20022.Seev042002.DateFormat49Choice||XmlElement()||
|+|MktDdln|ISO20022.Seev042002.DateFormat49Choice||XmlElement()||
|+|RspnDdln|ISO20022.Seev042002.DateFormat54Choice||XmlElement()||
|+|EarlyRspnDdln|ISO20022.Seev042002.DateFormat49Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CoverPrtctDdln),validElement(PrtctDdln),validElement(MktDdln),validElement(RspnDdln),validElement(EarlyRspnDdln))|

---

## Value ISO20022.Seev042002.CorporateActionEventType117Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev042002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev042002.CorporateActionEventType40Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||WRTH|Int32||XmlEnum("""WRTH""")|2|
||WTRC|Int32||XmlEnum("""WTRC""")|3|
||EXWA|Int32||XmlEnum("""EXWA""")|4|
||SUSP|Int32||XmlEnum("""SUSP""")|5|
||DLST|Int32||XmlEnum("""DLST""")|6|
||TEND|Int32||XmlEnum("""TEND""")|7|
||TREC|Int32||XmlEnum("""TREC""")|8|
||SPLF|Int32||XmlEnum("""SPLF""")|9|
||DVSE|Int32||XmlEnum("""DVSE""")|10|
||SOFF|Int32||XmlEnum("""SOFF""")|11|
||SMAL|Int32||XmlEnum("""SMAL""")|12|
||SHPR|Int32||XmlEnum("""SHPR""")|13|
||DVSC|Int32||XmlEnum("""DVSC""")|14|
||RHTS|Int32||XmlEnum("""RHTS""")|15|
||SPLR|Int32||XmlEnum("""SPLR""")|16|
||BIDS|Int32||XmlEnum("""BIDS""")|17|
||REMK|Int32||XmlEnum("""REMK""")|18|
||REDO|Int32||XmlEnum("""REDO""")|19|
||BPUT|Int32||XmlEnum("""BPUT""")|20|
||PRIO|Int32||XmlEnum("""PRIO""")|21|
||PDEF|Int32||XmlEnum("""PDEF""")|22|
||PLAC|Int32||XmlEnum("""PLAC""")|23|
||PINK|Int32||XmlEnum("""PINK""")|24|
||PRED|Int32||XmlEnum("""PRED""")|25|
||PCAL|Int32||XmlEnum("""PCAL""")|26|
||PARI|Int32||XmlEnum("""PARI""")|27|
||OTHR|Int32||XmlEnum("""OTHR""")|28|
||ODLT|Int32||XmlEnum("""ODLT""")|29|
||CERT|Int32||XmlEnum("""CERT""")|30|
||NOOF|Int32||XmlEnum("""NOOF""")|31|
||MRGR|Int32||XmlEnum("""MRGR""")|32|
||EXTM|Int32||XmlEnum("""EXTM""")|33|
||LIQU|Int32||XmlEnum("""LIQU""")|34|
||RHDI|Int32||XmlEnum("""RHDI""")|35|
||INTR|Int32||XmlEnum("""INTR""")|36|
||PPMT|Int32||XmlEnum("""PPMT""")|37|
||INCR|Int32||XmlEnum("""INCR""")|38|
||MCAL|Int32||XmlEnum("""MCAL""")|39|
||REDM|Int32||XmlEnum("""REDM""")|40|
||EXOF|Int32||XmlEnum("""EXOF""")|41|
||DTCH|Int32||XmlEnum("""DTCH""")|42|
||DRAW|Int32||XmlEnum("""DRAW""")|43|
||DRIP|Int32||XmlEnum("""DRIP""")|44|
||DVOP|Int32||XmlEnum("""DVOP""")|45|
||DSCL|Int32||XmlEnum("""DSCL""")|46|
||DETI|Int32||XmlEnum("""DETI""")|47|
||DECR|Int32||XmlEnum("""DECR""")|48|
||CREV|Int32||XmlEnum("""CREV""")|49|
||CONV|Int32||XmlEnum("""CONV""")|50|
||CONS|Int32||XmlEnum("""CONS""")|51|
||CLSA|Int32||XmlEnum("""CLSA""")|52|
||COOP|Int32||XmlEnum("""COOP""")|53|
||CHAN|Int32||XmlEnum("""CHAN""")|54|
||DVCA|Int32||XmlEnum("""DVCA""")|55|
||DRCA|Int32||XmlEnum("""DRCA""")|56|
||CAPI|Int32||XmlEnum("""CAPI""")|57|
||CAPG|Int32||XmlEnum("""CAPG""")|58|
||CAPD|Int32||XmlEnum("""CAPD""")|59|
||EXRI|Int32||XmlEnum("""EXRI""")|60|
||BONU|Int32||XmlEnum("""BONU""")|61|
||DFLT|Int32||XmlEnum("""DFLT""")|62|
||BRUP|Int32||XmlEnum("""BRUP""")|63|
||ATTI|Int32||XmlEnum("""ATTI""")|64|
||ACTV|Int32||XmlEnum("""ACTV""")|65|

---

## Aspect ISO20022.Seev042002.CorporateActionInstructionStatementReport002V13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev042002.SupplementaryData1>||XmlElement()||
|+|AcctAndStmtDtls|global::System.Collections.Generic.List<ISO20022.Seev042002.AccountIdentification74>||XmlElement()||
|+|StmtGnlDtls|ISO20022.Seev042002.Statement75||XmlElement()||
|+|Pgntn|ISO20022.Seev042002.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""AcctAndStmtDtls""",AcctAndStmtDtls),validList("""AcctAndStmtDtls""",AcctAndStmtDtls),validElement(AcctAndStmtDtls),validElement(StmtGnlDtls),validElement(Pgntn))|

---

## Enum ISO20022.Seev042002.CorporateActionMandatoryVoluntary1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VOLU|Int32||XmlEnum("""VOLU""")|1|
||CHOS|Int32||XmlEnum("""CHOS""")|2|
||MAND|Int32||XmlEnum("""MAND""")|3|

---

## Value ISO20022.Seev042002.CorporateActionMandatoryVoluntary4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev042002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev042002.CorporateActionOption11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRUN|Int32||XmlEnum("""PRUN""")|1|
||SLLE|Int32||XmlEnum("""SLLE""")|2|
||SECU|Int32||XmlEnum("""SECU""")|3|
||QINV|Int32||XmlEnum("""QINV""")|4|
||OVER|Int32||XmlEnum("""OVER""")|5|
||OTHR|Int32||XmlEnum("""OTHR""")|6|
||OFFR|Int32||XmlEnum("""OFFR""")|7|
||NOQU|Int32||XmlEnum("""NOQU""")|8|
||NOAC|Int32||XmlEnum("""NOAC""")|9|
||MPUT|Int32||XmlEnum("""MPUT""")|10|
||LAPS|Int32||XmlEnum("""LAPS""")|11|
||EXER|Int32||XmlEnum("""EXER""")|12|
||CTEN|Int32||XmlEnum("""CTEN""")|13|
||CONY|Int32||XmlEnum("""CONY""")|14|
||CONN|Int32||XmlEnum("""CONN""")|15|
||CEXC|Int32||XmlEnum("""CEXC""")|16|
||CASH|Int32||XmlEnum("""CASH""")|17|
||CASE|Int32||XmlEnum("""CASE""")|18|
||BUYA|Int32||XmlEnum("""BUYA""")|19|
||BSPL|Int32||XmlEnum("""BSPL""")|20|
||ABST|Int32||XmlEnum("""ABST""")|21|

---

## Value ISO20022.Seev042002.CorporateActionOption36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev042002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev042002.CorporateActionStatementReportingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SAME|Int32||XmlEnum("""SAME""")|1|
||MASE|Int32||XmlEnum("""MASE""")|2|

---

## Enum ISO20022.Seev042002.CorporateActionStatementType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BALI|Int32||XmlEnum("""BALI""")|1|
||BALO|Int32||XmlEnum("""BALO""")|2|
||ALLL|Int32||XmlEnum("""ALLL""")|3|
||MISS|Int32||XmlEnum("""MISS""")|4|

---

## Value ISO20022.Seev042002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Seev042002.DateCode22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev042002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev042002.DateCode26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev042002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev042002.DateCodeAndTimeFormat4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tm|DateTime||XmlElement()||
|+|DtCd|ISO20022.Seev042002.DateCode26Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd))|

---

## Value ISO20022.Seev042002.DateFormat49Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev042002.DateCode22Choice||XmlElement()||
|+|Dt|ISO20022.Seev042002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Seev042002.DateFormat54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev042002.DateCode22Choice||XmlElement()||
|+|DtCdAndTm|ISO20022.Seev042002.DateCodeAndTimeFormat4||XmlElement()||
|+|Dt|ISO20022.Seev042002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(DtCdAndTm),validElement(Dt),validChoice(DtCd,DtCdAndTm,Dt))|

---

## Value ISO20022.Seev042002.DateOrDateTimePeriod1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|ISO20022.Seev042002.DateTimePeriod1||XmlElement()||
|+|Dt|ISO20022.Seev042002.DatePeriod2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtTm),validElement(Dt),validChoice(DtTm,Dt))|

---

## Value ISO20022.Seev042002.DatePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev042002.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev042002.DateType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|

---

## Enum ISO20022.Seev042002.DateType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Value ISO20022.Seev042002.DefaultProcessingOrStandingInstruction2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StgInstrInd|String||XmlElement()||
|+|DfltOptnInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(StgInstrInd,DfltOptnInd))|

---

## Enum ISO20022.Seev042002.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Type ISO20022.Seev042002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnInstrStmtRpt|ISO20022.Seev042002.CorporateActionInstructionStatementReport002V13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnInstrStmtRpt))|

---

## Enum ISO20022.Seev042002.EventFrequency4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||INDA|Int32||XmlEnum("""INDA""")|2|
||DAIL|Int32||XmlEnum("""DAIL""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||ADHO|Int32||XmlEnum("""ADHO""")|5|
||YEAR|Int32||XmlEnum("""YEAR""")|6|

---

## Value ISO20022.Seev042002.EventInformation18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastNtfctnId|ISO20022.Seev042002.NotificationIdentification6||XmlElement()||
|+|MndtryVlntryEvtTp|ISO20022.Seev042002.CorporateActionMandatoryVoluntary4Choice||XmlElement()||
|+|EvtTp|ISO20022.Seev042002.CorporateActionEventType117Choice||XmlElement()||
|+|OffclCorpActnEvtId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LastNtfctnId),validElement(MndtryVlntryEvtTp),validElement(EvtTp),validPattern("""OffclCorpActnEvtId""",OffclCorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CorpActnEvtId""",CorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev042002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev042002.Frequency26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev042002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev042002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev042002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev042002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Seev042002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Seev042002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev042002.InstructedBalance21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OptnDtls|global::System.Collections.Generic.List<ISO20022.Seev042002.InstructedCorporateActionOption22>||XmlElement()||
|+|TtlPrtctInstrBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|TtlRjctdInstrBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|TtlPdgInstrBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|TtlCancInstrBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|TtlAccptdInstrBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|TtlInstdBal|ISO20022.Seev042002.BalanceFormat14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OptnDtls""",OptnDtls),validElement(OptnDtls),validElement(TtlPrtctInstrBal),validElement(TtlRjctdInstrBal),validElement(TtlPdgInstrBal),validElement(TtlCancInstrBal),validElement(TtlAccptdInstrBal),validElement(TtlInstdBal))|

---

## Value ISO20022.Seev042002.InstructedCorporateActionOption22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OptnInstrDtls|global::System.Collections.Generic.List<ISO20022.Seev042002.OptionInstructionDetails12>||XmlElement()||
|+|EvtDdlns|ISO20022.Seev042002.CorporateActionEventDeadlines4||XmlElement()||
|+|OptnPrtctInstrBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|OptnRtrdInstdBal|ISO20022.Seev042002.SignedQuantityFormat16||XmlElement()||
|+|OptnRjctdInstrBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|OptnPdgInstrBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|OptnCancInstrBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|OptnAccptdInstdBal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|DfltActn|ISO20022.Seev042002.DefaultProcessingOrStandingInstruction2Choice||XmlElement()||
|+|InstdBal|ISO20022.Seev042002.BalanceFormat14Choice||XmlElement()||
|+|OptnTp|ISO20022.Seev042002.CorporateActionOption36Choice||XmlElement()||
|+|OptnNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OptnInstrDtls""",OptnInstrDtls),validElement(OptnInstrDtls),validElement(EvtDdlns),validElement(OptnPrtctInstrBal),validElement(OptnRtrdInstdBal),validElement(OptnRjctdInstrBal),validElement(OptnPdgInstrBal),validElement(OptnCancInstrBal),validElement(OptnAccptdInstdBal),validElement(DfltActn),validElement(InstdBal),validElement(OptnTp),validPattern("""OptnNb""",OptnNb,"""[0-9]{3}"""))|

---

## Value ISO20022.Seev042002.InstructionProcessingStatus57Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rtrd|ISO20022.Seev042002.ReturnedStatus1Choice||XmlElement()||
|+|Ucvrd|ISO20022.Seev042002.NoSpecifiedReason1||XmlElement()||
|+|Cvrd|ISO20022.Seev042002.NoSpecifiedReason1||XmlElement()||
|+|PdgCxl|ISO20022.Seev042002.PendingCancellationStatus16Choice||XmlElement()||
|+|Pdg|ISO20022.Seev042002.PendingStatus72Choice||XmlElement()||
|+|Rjctd|ISO20022.Seev042002.RejectedStatus59Choice||XmlElement()||
|+|AccptdForFrthrPrcg|ISO20022.Seev042002.NoSpecifiedReason1||XmlElement()||
|+|Canc|ISO20022.Seev042002.CancelledStatus15Choice||XmlElement()||
|+|Accptd|ISO20022.Seev042002.NoSpecifiedReason1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rtrd),validElement(Ucvrd),validElement(Cvrd),validElement(PdgCxl),validElement(Pdg),validElement(Rjctd),validElement(AccptdForFrthrPrcg),validElement(Canc),validElement(Accptd),validChoice(Rtrd,Ucvrd,Cvrd,PdgCxl,Pdg,Rjctd,AccptdForFrthrPrcg,Canc,Accptd))|

---

## Enum ISO20022.Seev042002.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Seev042002.NoSpecifiedReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev042002.NotificationIdentification6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|ISO20022.Seev042002.DateAndDateTime2Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CreDtTm),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev042002.OptionInstructionDetails12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrSts|ISO20022.Seev042002.InstructionProcessingStatus57Choice||XmlElement()||
|+|InstrNrrtv|String||XmlElement()||
|+|CstmrRef|String||XmlElement()||
|+|CondlQty|ISO20022.Seev042002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|BidPric|ISO20022.Seev042002.PriceFormat82Choice||XmlElement()||
|+|CoverPrtctDt|DateTime||XmlElement()||
|+|PrtctDt|DateTime||XmlElement()||
|+|InstrDt|DateTime||XmlElement()||
|+|InstrQty|ISO20022.Seev042002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|PrtctInd|String||XmlElement()||
|+|InstrSeqNb|String||XmlElement()||
|+|InstrId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstrSts),validPattern("""InstrNrrtv""",InstrNrrtv,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""CstmrRef""",CstmrRef,"""([^/]+/)+([^/]+)\|([^/]*)"""),validElement(CondlQty),validElement(BidPric),validElement(InstrQty),validPattern("""InstrSeqNb""",InstrSeqNb,"""[0-9]{1,3}"""))|

---

## Value ISO20022.Seev042002.OriginalAndCurrentQuantities7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev042002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev042002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Seev042002.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Seev042002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev042002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Seev042002.PendingBalance8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PdgTxs|global::System.Collections.Generic.List<ISO20022.Seev042002.SettlementTypeAndIdentification26>||XmlElement()||
|+|Bal|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PdgTxs""",PdgTxs),validElement(PdgTxs),validElement(Bal))|

---

## Enum ISO20022.Seev042002.PendingCancellationReason5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||LATE|Int32||XmlEnum("""LATE""")|2|
||DQCS|Int32||XmlEnum("""DQCS""")|3|
||DQUA|Int32||XmlEnum("""DQUA""")|4|
||ADEA|Int32||XmlEnum("""ADEA""")|5|

---

## Value ISO20022.Seev042002.PendingCancellationReason6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev042002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev042002.PendingCancellationStatus16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev042002.PendingCancellationStatusReason9>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev042002.PendingCancellationStatusReason9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev042002.PendingCancellationReason6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsnCd))|

---

## Enum ISO20022.Seev042002.PendingReason27Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||IPED|Int32||XmlEnum("""IPED""")|1|
||IPAW|Int32||XmlEnum("""IPAW""")|2|
||BSTR|Int32||XmlEnum("""BSTR""")|3|
||SNAV|Int32||XmlEnum("""SNAV""")|4|
||MTAX|Int32||XmlEnum("""MTAX""")|5|
||NTAX|Int32||XmlEnum("""NTAX""")|6|
||ITAX|Int32||XmlEnum("""ITAX""")|7|
||DQCS|Int32||XmlEnum("""DQCS""")|8|
||CERT|Int32||XmlEnum("""CERT""")|9|
||PENR|Int32||XmlEnum("""PENR""")|10|
||DQUA|Int32||XmlEnum("""DQUA""")|11|
||LATE|Int32||XmlEnum("""LATE""")|12|
||LACK|Int32||XmlEnum("""LACK""")|13|
||MONY|Int32||XmlEnum("""MONY""")|14|
||MCER|Int32||XmlEnum("""MCER""")|15|
||FULL|Int32||XmlEnum("""FULL""")|16|
||OTHR|Int32||XmlEnum("""OTHR""")|17|
||ADEA|Int32||XmlEnum("""ADEA""")|18|

---

## Value ISO20022.Seev042002.PendingReason68Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev042002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev042002.PendingStatus72Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev042002.PendingStatusReason28>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev042002.PendingStatusReason28


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev042002.PendingReason68Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(RsnCd))|

---

## Value ISO20022.Seev042002.PercentagePrice2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|Decimal||XmlElement()||
|+|PctgPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev042002.PriceFormat82Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev042002.AmountPrice5||XmlElement()||
|+|PctgPric|ISO20022.Seev042002.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validElement(PctgPric),validChoice(NotSpcfdPric,AmtPric,PctgPric))|

---

## Enum ISO20022.Seev042002.PriceRateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YIEL|Int32||XmlEnum("""YIEL""")|1|
||PRCT|Int32||XmlEnum("""PRCT""")|2|
||PREM|Int32||XmlEnum("""PREM""")|3|
||DISC|Int32||XmlEnum("""DISC""")|4|

---

## Enum ISO20022.Seev042002.PriceValueType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Value ISO20022.Seev042002.ProprietaryQuantity10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev042002.ProprietaryQuantity9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Enum ISO20022.Seev042002.ProtectTransactionType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COVR|Int32||XmlEnum("""COVR""")|1|
||COVP|Int32||XmlEnum("""COVP""")|2|
||PROT|Int32||XmlEnum("""PROT""")|3|

---

## Value ISO20022.Seev042002.Quantity53Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev042002.ProprietaryQuantity9||XmlElement()||
|+|Qty|ISO20022.Seev042002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(Qty),validChoice(PrtryQty,Qty))|

---

## Value ISO20022.Seev042002.Quantity57Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SgndQty|ISO20022.Seev042002.SignedQuantityFormat13||XmlElement()||
|+|OrgnlAndCurFaceAmt|ISO20022.Seev042002.OriginalAndCurrentQuantities7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgndQty),validElement(OrgnlAndCurFaceAmt),validChoice(SgndQty,OrgnlAndCurFaceAmt))|

---

## Value ISO20022.Seev042002.Quantity80Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev042002.ProprietaryQuantity10||XmlElement()||
|+|QtyChc|ISO20022.Seev042002.Quantity57Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(QtyChc),validChoice(PrtryQty,QtyChc))|

---

## Value ISO20022.Seev042002.RejectedReason61Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev042002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev042002.RejectedStatus59Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev042002.RejectedStatusReason58>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev042002.RejectedStatusReason58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev042002.RejectedReason61Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsnCd))|

---

## Enum ISO20022.Seev042002.RejectionReason86Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||IPED|Int32||XmlEnum("""IPED""")|1|
||IPAW|Int32||XmlEnum("""IPAW""")|2|
||REJA|Int32||XmlEnum("""REJA""")|3|
||TRTI|Int32||XmlEnum("""TRTI""")|4|
||PRON|Int32||XmlEnum("""PRON""")|5|
||PROT|Int32||XmlEnum("""PROT""")|6|
||PROI|Int32||XmlEnum("""PROI""")|7|
||DUPL|Int32||XmlEnum("""DUPL""")|8|
||CTCT|Int32||XmlEnum("""CTCT""")|9|
||BSTR|Int32||XmlEnum("""BSTR""")|10|
||SHAR|Int32||XmlEnum("""SHAR""")|11|
||INIR|Int32||XmlEnum("""INIR""")|12|
||DPRG|Int32||XmlEnum("""DPRG""")|13|
||DCAN|Int32||XmlEnum("""DCAN""")|14|
||DQBI|Int32||XmlEnum("""DQBI""")|15|
||DQBV|Int32||XmlEnum("""DQBV""")|16|
||IRDQ|Int32||XmlEnum("""IRDQ""")|17|
||DQAM|Int32||XmlEnum("""DQAM""")|18|
||DQCC|Int32||XmlEnum("""DQCC""")|19|
||DQCS|Int32||XmlEnum("""DQCS""")|20|
||EVNM|Int32||XmlEnum("""EVNM""")|21|
||SAFE|Int32||XmlEnum("""SAFE""")|22|
||REFT|Int32||XmlEnum("""REFT""")|23|
||DQUA|Int32||XmlEnum("""DQUA""")|24|
||OTHR|Int32||XmlEnum("""OTHR""")|25|
||OPNM|Int32||XmlEnum("""OPNM""")|26|
||INTV|Int32||XmlEnum("""INTV""")|27|
||CANC|Int32||XmlEnum("""CANC""")|28|
||FULL|Int32||XmlEnum("""FULL""")|29|
||NMTY|Int32||XmlEnum("""NMTY""")|30|
||LATE|Int32||XmlEnum("""LATE""")|31|
||LACK|Int32||XmlEnum("""LACK""")|32|
||DSEC|Int32||XmlEnum("""DSEC""")|33|
||ULNK|Int32||XmlEnum("""ULNK""")|34|
||OPTY|Int32||XmlEnum("""OPTY""")|35|
||INVA|Int32||XmlEnum("""INVA""")|36|
||CERT|Int32||XmlEnum("""CERT""")|37|
||ADEA|Int32||XmlEnum("""ADEA""")|38|

---

## Value ISO20022.Seev042002.RestrictedFINActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev042002.ReturnedReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev042002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev042002.ReturnedStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev042002.ReturnedStatusReason1>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Seev042002.ReturnedStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROR|Int32||XmlEnum("""PROR""")|1|
||NARR|Int32||XmlEnum("""NARR""")|2|

---

## Value ISO20022.Seev042002.ReturnedStatusReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev042002.ReturnedReason1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(RsnCd))|

---

## Enum ISO20022.Seev042002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Seev042002.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Value ISO20022.Seev042002.SafekeepingPlaceFormat46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev042002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Seev042002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev042002.SafekeepingPlaceTypeAndText9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev042002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Seev042002.SafekeepingPlaceTypeAndText9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev042002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev042002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Seev042002.SettlementTypeAndIdentification26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmDt|ISO20022.Seev042002.DateAndDateTime2Choice||XmlElement()||
|+|TxId|String||XmlElement()||
|+|Pmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmDt),validPattern("""TxId""",TxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Seev042002.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Seev042002.SignedQuantityFormat12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyChc|ISO20022.Seev042002.Quantity53Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyChc))|

---

## Value ISO20022.Seev042002.SignedQuantityFormat13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Seev042002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Seev042002.SignedQuantityFormat16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Seev042002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Seev042002.Statement75


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtfctnDdlnPrd|ISO20022.Seev042002.DateOrDateTimePeriod1Choice||XmlElement()||
|+|ActvtyInd|String||XmlElement()||
|+|UpdTp|ISO20022.Seev042002.UpdateType16Choice||XmlElement()||
|+|Frqcy|ISO20022.Seev042002.Frequency26Choice||XmlElement()||
|+|StmtDtTm|ISO20022.Seev042002.DateAndDateTime2Choice||XmlElement()||
|+|RptNb|String||XmlElement()||
|+|InstrAggtnPrd|ISO20022.Seev042002.DatePeriod2||XmlElement()||
|+|StmtId|String||XmlElement()||
|+|RptgTp|String||XmlElement()||
|+|StmtTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NtfctnDdlnPrd),validElement(UpdTp),validElement(Frqcy),validElement(StmtDtTm),validPattern("""RptNb""",RptNb,"""[0-9]{1,5}"""),validElement(InstrAggtnPrd),validPattern("""StmtId""",StmtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Seev042002.StatementUpdateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Seev042002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev042002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev042002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev042002.UpdateType16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev042002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

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

