# seev.037.002.16
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev037002.Account12Choice {
        + TaxAcct  : ISO20022.Seev037002.CashAccountIdentification6Choice
        + ChrgsAcct  : ISO20022.Seev037002.CashAccountIdentification6Choice
        + CshAcct  : ISO20022.Seev037002.CashAccountIdentification14Choice
    }
    ISO20022.Seev037002.Account12Choice *-- ISO20022.Seev037002.CashAccountIdentification6Choice
    ISO20022.Seev037002.Account12Choice *-- ISO20022.Seev037002.CashAccountIdentification6Choice
    ISO20022.Seev037002.Account12Choice *-- ISO20022.Seev037002.CashAccountIdentification14Choice
    class ISO20022.Seev037002.AccountAndBalance54 {
        + ConfdBal  : ISO20022.Seev037002.BalanceFormat14Choice
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
    }
    ISO20022.Seev037002.AccountAndBalance54 *-- ISO20022.Seev037002.BalanceFormat14Choice
    class ISO20022.Seev037002.AdditionalBusinessProcess7Code {
        FPRE = 1
        PPRE = 2
        PPUT = 3
        SCHM = 4
        NPLE = 5
        NAMC = 6
        CONS = 7
        CNTR = 8
        ATXF = 9
        ACLA = 10
        TAXR = 11
        CLAI = 12
    }
    class ISO20022.Seev037002.AdditionalBusinessProcessFormat14Choice {
        + Prtry  : ISO20022.Seev037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev037002.AdditionalBusinessProcessFormat14Choice *-- ISO20022.Seev037002.GenericIdentification47
    class ISO20022.Seev037002.BalanceFormat14Choice {
        + NotElgblBal  : ISO20022.Seev037002.SignedQuantityFormat13
        + ElgblBal  : ISO20022.Seev037002.SignedQuantityFormat13
        + Bal  : ISO20022.Seev037002.SignedQuantityFormat12
    }
    ISO20022.Seev037002.BalanceFormat14Choice *-- ISO20022.Seev037002.SignedQuantityFormat13
    ISO20022.Seev037002.BalanceFormat14Choice *-- ISO20022.Seev037002.SignedQuantityFormat13
    ISO20022.Seev037002.BalanceFormat14Choice *-- ISO20022.Seev037002.SignedQuantityFormat12
    class ISO20022.Seev037002.BlockChainAddressWallet11 {
        + Nm  : String
        + Tp  : ISO20022.Seev037002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Seev037002.BlockChainAddressWallet11 *-- ISO20022.Seev037002.GenericIdentification47
    class ISO20022.Seev037002.CashAccountIdentification14Choice {
        + Prtry  : String
        + BlckChainCshWllt  : ISO20022.Seev037002.BlockChainAddressWallet11
        + IBAN  : String
    }
    ISO20022.Seev037002.CashAccountIdentification14Choice *-- ISO20022.Seev037002.BlockChainAddressWallet11
    class ISO20022.Seev037002.CashAccountIdentification6Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Seev037002.CashOption112 {
        + PstngAmt  : ISO20022.Seev037002.RestrictedFINActiveCurrencyAndAmount
        + ValDt  : DateTime
        + OrgnlPstngDt  : ISO20022.Seev037002.DateAndDateTime2Choice
        + PstngDt  : ISO20022.Seev037002.DateAndDateTime2Choice
        + Acct  : ISO20022.Seev037002.Account12Choice
        + CdtDbtInd  : String
    }
    ISO20022.Seev037002.CashOption112 *-- ISO20022.Seev037002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev037002.CashOption112 *-- ISO20022.Seev037002.DateAndDateTime2Choice
    ISO20022.Seev037002.CashOption112 *-- ISO20022.Seev037002.DateAndDateTime2Choice
    ISO20022.Seev037002.CashOption112 *-- ISO20022.Seev037002.Account12Choice
    class ISO20022.Seev037002.CorporateAction78 {
        + LtryTp  : ISO20022.Seev037002.LotteryTypeFormat5Choice
        + IntrmdtSctiesDstrbtnTp  : ISO20022.Seev037002.IntermediateSecuritiesDistributionTypeFormat18Choice
        + AddtlBizPrcInd  : ISO20022.Seev037002.AdditionalBusinessProcessFormat14Choice
        + EvtStag  : ISO20022.Seev037002.CorporateActionEventStageFormat15Choice
        + DtDtls  : ISO20022.Seev037002.CorporateActionDate89
    }
    ISO20022.Seev037002.CorporateAction78 *-- ISO20022.Seev037002.LotteryTypeFormat5Choice
    ISO20022.Seev037002.CorporateAction78 *-- ISO20022.Seev037002.IntermediateSecuritiesDistributionTypeFormat18Choice
    ISO20022.Seev037002.CorporateAction78 *-- ISO20022.Seev037002.AdditionalBusinessProcessFormat14Choice
    ISO20022.Seev037002.CorporateAction78 *-- ISO20022.Seev037002.CorporateActionEventStageFormat15Choice
    ISO20022.Seev037002.CorporateAction78 *-- ISO20022.Seev037002.CorporateActionDate89
    class ISO20022.Seev037002.CorporateActionDate89 {
        + ExDvddDt  : ISO20022.Seev037002.DateFormat41Choice
        + RcrdDt  : ISO20022.Seev037002.DateFormat41Choice
    }
    ISO20022.Seev037002.CorporateActionDate89 *-- ISO20022.Seev037002.DateFormat41Choice
    ISO20022.Seev037002.CorporateActionDate89 *-- ISO20022.Seev037002.DateFormat41Choice
    class ISO20022.Seev037002.CorporateActionEventReference4 {
        + LkgTp  : ISO20022.Seev037002.ProcessingPosition10Choice
        + EvtId  : ISO20022.Seev037002.CorporateActionEventReference4Choice
    }
    ISO20022.Seev037002.CorporateActionEventReference4 *-- ISO20022.Seev037002.ProcessingPosition10Choice
    ISO20022.Seev037002.CorporateActionEventReference4 *-- ISO20022.Seev037002.CorporateActionEventReference4Choice
    class ISO20022.Seev037002.CorporateActionEventReference4Choice {
        + LkdCorpActnId  : String
        + LkdOffclCorpActnEvtId  : String
    }
    class ISO20022.Seev037002.CorporateActionEventStage4Code {
        RESC = 1
        PART = 2
        FULL = 3
    }
    class ISO20022.Seev037002.CorporateActionEventStageFormat15Choice {
        + Prtry  : ISO20022.Seev037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev037002.CorporateActionEventStageFormat15Choice *-- ISO20022.Seev037002.GenericIdentification47
    class ISO20022.Seev037002.CorporateActionEventType123Choice {
        + Prtry  : ISO20022.Seev037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev037002.CorporateActionEventType123Choice *-- ISO20022.Seev037002.GenericIdentification47
    class ISO20022.Seev037002.CorporateActionEventType37Code {
        RCLA = 1
        TNDP = 2
        MTNG = 3
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
    class ISO20022.Seev037002.CorporateActionGeneralInformation193 {
        + FrctnlQty  : ISO20022.Seev037002.FinancialInstrumentQuantity36Choice
        + FinInstrmId  : ISO20022.Seev037002.SecurityIdentification20
        + EvtTp  : ISO20022.Seev037002.CorporateActionEventType123Choice
        + ClssActnNb  : String
        + OffclCorpActnEvtId  : String
        + CorpActnEvtId  : String
    }
    ISO20022.Seev037002.CorporateActionGeneralInformation193 *-- ISO20022.Seev037002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev037002.CorporateActionGeneralInformation193 *-- ISO20022.Seev037002.SecurityIdentification20
    ISO20022.Seev037002.CorporateActionGeneralInformation193 *-- ISO20022.Seev037002.CorporateActionEventType123Choice
    class ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev037002.SupplementaryData1~
        + SubPngAgt  : global::System.Collections.Generic.List~ISO20022.Seev037002.PartyIdentification137Choice~
        + PngAgt  : global::System.Collections.Generic.List~ISO20022.Seev037002.PartyIdentification137Choice~
        + IssrAgt  : global::System.Collections.Generic.List~ISO20022.Seev037002.PartyIdentification137Choice~
        + AddtlInf  : ISO20022.Seev037002.CorporateActionNarrative35
        + CorpActnConfDtls  : ISO20022.Seev037002.CorporateActionOption246
        + CorpActnDtls  : ISO20022.Seev037002.CorporateAction78
        + AcctDtls  : ISO20022.Seev037002.AccountAndBalance54
        + CorpActnGnlInf  : ISO20022.Seev037002.CorporateActionGeneralInformation193
        + TxId  : ISO20022.Seev037002.TransactionIdentification1
        + RvslRsn  : ISO20022.Seev037002.CorporateActionReversalReason10
        + EvtsLkg  : global::System.Collections.Generic.List~ISO20022.Seev037002.CorporateActionEventReference4~
        + OthrDocId  : global::System.Collections.Generic.List~ISO20022.Seev037002.DocumentIdentification38~
        + MvmntConfId  : ISO20022.Seev037002.DocumentIdentification37
    }
    ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16 *-- ISO20022.Seev037002.SupplementaryData1
    ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16 *-- ISO20022.Seev037002.PartyIdentification137Choice
    ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16 *-- ISO20022.Seev037002.PartyIdentification137Choice
    ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16 *-- ISO20022.Seev037002.PartyIdentification137Choice
    ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16 *-- ISO20022.Seev037002.CorporateActionNarrative35
    ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16 *-- ISO20022.Seev037002.CorporateActionOption246
    ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16 *-- ISO20022.Seev037002.CorporateAction78
    ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16 *-- ISO20022.Seev037002.AccountAndBalance54
    ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16 *-- ISO20022.Seev037002.CorporateActionGeneralInformation193
    ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16 *-- ISO20022.Seev037002.TransactionIdentification1
    ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16 *-- ISO20022.Seev037002.CorporateActionReversalReason10
    ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16 *-- ISO20022.Seev037002.CorporateActionEventReference4
    ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16 *-- ISO20022.Seev037002.DocumentIdentification38
    ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16 *-- ISO20022.Seev037002.DocumentIdentification37
    class ISO20022.Seev037002.CorporateActionNarrative35 {
        + TaxtnConds  : global::System.Collections.Generic.List~String~
        + PtyCtctNrrtv  : global::System.Collections.Generic.List~String~
        + NrrtvVrsn  : global::System.Collections.Generic.List~String~
        + AddtlTxt  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Seev037002.CorporateActionOption12Code {
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
        MKUP = 11
        MKDW = 12
        LAPS = 13
        EXER = 14
        CTEN = 15
        CONY = 16
        CONN = 17
        CEXC = 18
        CASH = 19
        CASE = 20
        BUYA = 21
        BSPL = 22
        ABST = 23
    }
    class ISO20022.Seev037002.CorporateActionOption246 {
        + CshMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev037002.CashOption112~
        + SctiesMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev037002.SecuritiesOption86~
        + OptnTp  : ISO20022.Seev037002.CorporateActionOption39Choice
        + OptnNb  : ISO20022.Seev037002.OptionNumber1Choice
    }
    ISO20022.Seev037002.CorporateActionOption246 *-- ISO20022.Seev037002.CashOption112
    ISO20022.Seev037002.CorporateActionOption246 *-- ISO20022.Seev037002.SecuritiesOption86
    ISO20022.Seev037002.CorporateActionOption246 *-- ISO20022.Seev037002.CorporateActionOption39Choice
    ISO20022.Seev037002.CorporateActionOption246 *-- ISO20022.Seev037002.OptionNumber1Choice
    class ISO20022.Seev037002.CorporateActionOption39Choice {
        + Prtry  : ISO20022.Seev037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev037002.CorporateActionOption39Choice *-- ISO20022.Seev037002.GenericIdentification47
    class ISO20022.Seev037002.CorporateActionReversalReason10 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Seev037002.CorporateActionReversalReason12Choice
    }
    ISO20022.Seev037002.CorporateActionReversalReason10 *-- ISO20022.Seev037002.CorporateActionReversalReason12Choice
    class ISO20022.Seev037002.CorporateActionReversalReason12Choice {
        + Prtry  : ISO20022.Seev037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev037002.CorporateActionReversalReason12Choice *-- ISO20022.Seev037002.GenericIdentification47
    class ISO20022.Seev037002.CorporateActionReversalReason3Code {
        OTHR = 1
        UPAY = 2
        IVAD = 3
        IPRI = 4
        IPCU = 5
        IETR = 6
        IRED = 7
        FNRC = 8
        DCBD = 9
    }
    class ISO20022.Seev037002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Seev037002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Seev037002.DateCode22Choice {
        + Prtry  : ISO20022.Seev037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev037002.DateCode22Choice *-- ISO20022.Seev037002.GenericIdentification47
    class ISO20022.Seev037002.DateFormat41Choice {
        + DtCd  : ISO20022.Seev037002.DateCode22Choice
        + Dt  : DateTime
    }
    ISO20022.Seev037002.DateFormat41Choice *-- ISO20022.Seev037002.DateCode22Choice
    class ISO20022.Seev037002.DateType8Code {
        ONGO = 1
        UKWN = 2
    }
    class ISO20022.Seev037002.DocumentIdentification37 {
        + LkgTp  : ISO20022.Seev037002.ProcessingPosition10Choice
        + Id  : String
    }
    ISO20022.Seev037002.DocumentIdentification37 *-- ISO20022.Seev037002.ProcessingPosition10Choice
    class ISO20022.Seev037002.DocumentIdentification38 {
        + LkgTp  : ISO20022.Seev037002.ProcessingPosition10Choice
        + DocNb  : ISO20022.Seev037002.DocumentNumber6Choice
        + Id  : ISO20022.Seev037002.DocumentIdentification4Choice
    }
    ISO20022.Seev037002.DocumentIdentification38 *-- ISO20022.Seev037002.ProcessingPosition10Choice
    ISO20022.Seev037002.DocumentIdentification38 *-- ISO20022.Seev037002.DocumentNumber6Choice
    ISO20022.Seev037002.DocumentIdentification38 *-- ISO20022.Seev037002.DocumentIdentification4Choice
    class ISO20022.Seev037002.DocumentIdentification4Choice {
        + AcctOwnrDocId  : String
        + AcctSvcrDocId  : String
    }
    class ISO20022.Seev037002.DocumentNumber6Choice {
        + PrtryNb  : ISO20022.Seev037002.GenericIdentification86
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Seev037002.DocumentNumber6Choice *-- ISO20022.Seev037002.GenericIdentification86
    class ISO20022.Seev037002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev037002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev037002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev037002.GenericIdentification86 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev037002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev037002.IntermediateSecuritiesDistributionTypeFormat18Choice {
        + Prtry  : ISO20022.Seev037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev037002.IntermediateSecuritiesDistributionTypeFormat18Choice *-- ISO20022.Seev037002.GenericIdentification47
    class ISO20022.Seev037002.IntermediateSecurityDistributionType5Code {
        MRGR = 1
        EXOF = 2
        BONU = 3
        SPLF = 4
        SOFF = 5
        LIQU = 6
        INTR = 7
        DVSE = 8
        DVSC = 9
        PRIO = 10
        EXRI = 11
        DVOP = 12
        DVCA = 13
        DRIP = 14
        BIDS = 15
    }
    class ISO20022.Seev037002.LotteryType1Code {
        SUPP = 1
        ORIG = 2
    }
    class ISO20022.Seev037002.LotteryTypeFormat5Choice {
        + Prtry  : ISO20022.Seev037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev037002.LotteryTypeFormat5Choice *-- ISO20022.Seev037002.GenericIdentification47
    class ISO20022.Seev037002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Seev037002.OptionNumber1Choice {
        + Cd  : String
        + Nb  : String
    }
    class ISO20022.Seev037002.OptionNumber1Code {
        UNSO = 1
    }
    class ISO20022.Seev037002.OriginalAndCurrentQuantities4 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Seev037002.OtherIdentification2 {
        + Tp  : ISO20022.Seev037002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev037002.OtherIdentification2 *-- ISO20022.Seev037002.IdentificationSource4Choice
    class ISO20022.Seev037002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Seev037002.NameAndAddress12
        + PrtryId  : ISO20022.Seev037002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Seev037002.PartyIdentification137Choice *-- ISO20022.Seev037002.NameAndAddress12
    ISO20022.Seev037002.PartyIdentification137Choice *-- ISO20022.Seev037002.GenericIdentification84
    class ISO20022.Seev037002.ProcessingPosition10Choice {
        + Prtry  : ISO20022.Seev037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev037002.ProcessingPosition10Choice *-- ISO20022.Seev037002.GenericIdentification47
    class ISO20022.Seev037002.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Seev037002.ProprietaryQuantity9 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
    }
    class ISO20022.Seev037002.Quantity53Choice {
        + PrtryQty  : ISO20022.Seev037002.ProprietaryQuantity9
        + Qty  : ISO20022.Seev037002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Seev037002.Quantity53Choice *-- ISO20022.Seev037002.ProprietaryQuantity9
    ISO20022.Seev037002.Quantity53Choice *-- ISO20022.Seev037002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev037002.Quantity54Choice {
        + OrgnlAndCurFace  : ISO20022.Seev037002.OriginalAndCurrentQuantities4
        + Qty  : ISO20022.Seev037002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Seev037002.Quantity54Choice *-- ISO20022.Seev037002.OriginalAndCurrentQuantities4
    ISO20022.Seev037002.Quantity54Choice *-- ISO20022.Seev037002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev037002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev037002.SecuritiesOption86 {
        + OrgnlPstngDt  : ISO20022.Seev037002.DateAndDateTime2Choice
        + PstngDt  : ISO20022.Seev037002.DateAndDateTime2Choice
        + PstngQty  : ISO20022.Seev037002.Quantity54Choice
        + CdtDbtInd  : String
        + FinInstrmId  : ISO20022.Seev037002.SecurityIdentification20
    }
    ISO20022.Seev037002.SecuritiesOption86 *-- ISO20022.Seev037002.DateAndDateTime2Choice
    ISO20022.Seev037002.SecuritiesOption86 *-- ISO20022.Seev037002.DateAndDateTime2Choice
    ISO20022.Seev037002.SecuritiesOption86 *-- ISO20022.Seev037002.Quantity54Choice
    ISO20022.Seev037002.SecuritiesOption86 *-- ISO20022.Seev037002.SecurityIdentification20
    class ISO20022.Seev037002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev037002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Seev037002.SecurityIdentification20 *-- ISO20022.Seev037002.OtherIdentification2
    class ISO20022.Seev037002.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Seev037002.SignedQuantityFormat12 {
        + QtyChc  : ISO20022.Seev037002.Quantity53Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev037002.SignedQuantityFormat12 *-- ISO20022.Seev037002.Quantity53Choice
    class ISO20022.Seev037002.SignedQuantityFormat13 {
        + Qty  : ISO20022.Seev037002.FinancialInstrumentQuantity36Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev037002.SignedQuantityFormat13 *-- ISO20022.Seev037002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev037002.SupplementaryData1 {
        + Envlp  : ISO20022.Seev037002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev037002.SupplementaryData1 *-- ISO20022.Seev037002.SupplementaryDataEnvelope1
    class ISO20022.Seev037002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Seev037002.TransactionIdentification1 {
        + MktInfrstrctrTxId  : String
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

## Value ISO20022.Seev037002.Account12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxAcct|ISO20022.Seev037002.CashAccountIdentification6Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Seev037002.CashAccountIdentification6Choice||XmlElement()||
|+|CshAcct|ISO20022.Seev037002.CashAccountIdentification14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxAcct),validElement(ChrgsAcct),validElement(CshAcct),validChoice(TaxAcct,ChrgsAcct,CshAcct))|

---

## Value ISO20022.Seev037002.AccountAndBalance54


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ConfdBal|ISO20022.Seev037002.BalanceFormat14Choice||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ConfdBal),validPattern("""BlckChainAdrOrWllt""",BlckChainAdrOrWllt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""SfkpgAcct""",SfkpgAcct,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Enum ISO20022.Seev037002.AdditionalBusinessProcess7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FPRE|Int32||XmlEnum("""FPRE""")|1|
||PPRE|Int32||XmlEnum("""PPRE""")|2|
||PPUT|Int32||XmlEnum("""PPUT""")|3|
||SCHM|Int32||XmlEnum("""SCHM""")|4|
||NPLE|Int32||XmlEnum("""NPLE""")|5|
||NAMC|Int32||XmlEnum("""NAMC""")|6|
||CONS|Int32||XmlEnum("""CONS""")|7|
||CNTR|Int32||XmlEnum("""CNTR""")|8|
||ATXF|Int32||XmlEnum("""ATXF""")|9|
||ACLA|Int32||XmlEnum("""ACLA""")|10|
||TAXR|Int32||XmlEnum("""TAXR""")|11|
||CLAI|Int32||XmlEnum("""CLAI""")|12|

---

## Value ISO20022.Seev037002.AdditionalBusinessProcessFormat14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev037002.BalanceFormat14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotElgblBal|ISO20022.Seev037002.SignedQuantityFormat13||XmlElement()||
|+|ElgblBal|ISO20022.Seev037002.SignedQuantityFormat13||XmlElement()||
|+|Bal|ISO20022.Seev037002.SignedQuantityFormat12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotElgblBal),validElement(ElgblBal),validElement(Bal),validChoice(NotElgblBal,ElgblBal,Bal))|

---

## Value ISO20022.Seev037002.BlockChainAddressWallet11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Seev037002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev037002.CashAccountIdentification14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|BlckChainCshWllt|ISO20022.Seev037002.BlockChainAddressWallet11||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,34}"""),validElement(BlckChainCshWllt),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,BlckChainCshWllt,IBAN))|

---

## Value ISO20022.Seev037002.CashAccountIdentification6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,34}"""),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Value ISO20022.Seev037002.CashOption112


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstngAmt|ISO20022.Seev037002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|OrgnlPstngDt|ISO20022.Seev037002.DateAndDateTime2Choice||XmlElement()||
|+|PstngDt|ISO20022.Seev037002.DateAndDateTime2Choice||XmlElement()||
|+|Acct|ISO20022.Seev037002.Account12Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstngAmt),validElement(OrgnlPstngDt),validElement(PstngDt),validElement(Acct))|

---

## Value ISO20022.Seev037002.CorporateAction78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LtryTp|ISO20022.Seev037002.LotteryTypeFormat5Choice||XmlElement()||
|+|IntrmdtSctiesDstrbtnTp|ISO20022.Seev037002.IntermediateSecuritiesDistributionTypeFormat18Choice||XmlElement()||
|+|AddtlBizPrcInd|ISO20022.Seev037002.AdditionalBusinessProcessFormat14Choice||XmlElement()||
|+|EvtStag|ISO20022.Seev037002.CorporateActionEventStageFormat15Choice||XmlElement()||
|+|DtDtls|ISO20022.Seev037002.CorporateActionDate89||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LtryTp),validElement(IntrmdtSctiesDstrbtnTp),validElement(AddtlBizPrcInd),validElement(EvtStag),validElement(DtDtls))|

---

## Value ISO20022.Seev037002.CorporateActionDate89


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ExDvddDt|ISO20022.Seev037002.DateFormat41Choice||XmlElement()||
|+|RcrdDt|ISO20022.Seev037002.DateFormat41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ExDvddDt),validElement(RcrdDt))|

---

## Value ISO20022.Seev037002.CorporateActionEventReference4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev037002.ProcessingPosition10Choice||XmlElement()||
|+|EvtId|ISO20022.Seev037002.CorporateActionEventReference4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(EvtId))|

---

## Value ISO20022.Seev037002.CorporateActionEventReference4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkdCorpActnId|String||XmlElement()||
|+|LkdOffclCorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LkdCorpActnId""",LkdCorpActnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""LkdOffclCorpActnEvtId""",LkdOffclCorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validChoice(LkdCorpActnId,LkdOffclCorpActnEvtId))|

---

## Enum ISO20022.Seev037002.CorporateActionEventStage4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RESC|Int32||XmlEnum("""RESC""")|1|
||PART|Int32||XmlEnum("""PART""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Seev037002.CorporateActionEventStageFormat15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev037002.CorporateActionEventType123Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev037002.CorporateActionEventType37Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RCLA|Int32||XmlEnum("""RCLA""")|1|
||TNDP|Int32||XmlEnum("""TNDP""")|2|
||MTNG|Int32||XmlEnum("""MTNG""")|3|
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

## Value ISO20022.Seev037002.CorporateActionGeneralInformation193


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrctnlQty|ISO20022.Seev037002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Seev037002.SecurityIdentification20||XmlElement()||
|+|EvtTp|ISO20022.Seev037002.CorporateActionEventType123Choice||XmlElement()||
|+|ClssActnNb|String||XmlElement()||
|+|OffclCorpActnEvtId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrctnlQty),validElement(FinInstrmId),validElement(EvtTp),validPattern("""ClssActnNb""",ClssActnNb,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""OffclCorpActnEvtId""",OffclCorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CorpActnEvtId""",CorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Aspect ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev037002.SupplementaryData1>||XmlElement()||
|+|SubPngAgt|global::System.Collections.Generic.List<ISO20022.Seev037002.PartyIdentification137Choice>||XmlElement()||
|+|PngAgt|global::System.Collections.Generic.List<ISO20022.Seev037002.PartyIdentification137Choice>||XmlElement()||
|+|IssrAgt|global::System.Collections.Generic.List<ISO20022.Seev037002.PartyIdentification137Choice>||XmlElement()||
|+|AddtlInf|ISO20022.Seev037002.CorporateActionNarrative35||XmlElement()||
|+|CorpActnConfDtls|ISO20022.Seev037002.CorporateActionOption246||XmlElement()||
|+|CorpActnDtls|ISO20022.Seev037002.CorporateAction78||XmlElement()||
|+|AcctDtls|ISO20022.Seev037002.AccountAndBalance54||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev037002.CorporateActionGeneralInformation193||XmlElement()||
|+|TxId|ISO20022.Seev037002.TransactionIdentification1||XmlElement()||
|+|RvslRsn|ISO20022.Seev037002.CorporateActionReversalReason10||XmlElement()||
|+|EvtsLkg|global::System.Collections.Generic.List<ISO20022.Seev037002.CorporateActionEventReference4>||XmlElement()||
|+|OthrDocId|global::System.Collections.Generic.List<ISO20022.Seev037002.DocumentIdentification38>||XmlElement()||
|+|MvmntConfId|ISO20022.Seev037002.DocumentIdentification37||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""SubPngAgt""",SubPngAgt),validElement(SubPngAgt),validList("""PngAgt""",PngAgt),validElement(PngAgt),validList("""IssrAgt""",IssrAgt),validElement(IssrAgt),validElement(AddtlInf),validElement(CorpActnConfDtls),validElement(CorpActnDtls),validElement(AcctDtls),validElement(CorpActnGnlInf),validElement(TxId),validElement(RvslRsn),validList("""EvtsLkg""",EvtsLkg),validElement(EvtsLkg),validList("""OthrDocId""",OthrDocId),validElement(OthrDocId),validElement(MvmntConfId))|

---

## Value ISO20022.Seev037002.CorporateActionNarrative35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxtnConds|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PtyCtctNrrtv|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NrrtvVrsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AddtlTxt|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TaxtnConds""",TaxtnConds,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""PtyCtctNrrtv""",PtyCtctNrrtv,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""NrrtvVrsn""",NrrtvVrsn,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""AddtlTxt""",AddtlTxt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Enum ISO20022.Seev037002.CorporateActionOption12Code


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
||MKUP|Int32||XmlEnum("""MKUP""")|11|
||MKDW|Int32||XmlEnum("""MKDW""")|12|
||LAPS|Int32||XmlEnum("""LAPS""")|13|
||EXER|Int32||XmlEnum("""EXER""")|14|
||CTEN|Int32||XmlEnum("""CTEN""")|15|
||CONY|Int32||XmlEnum("""CONY""")|16|
||CONN|Int32||XmlEnum("""CONN""")|17|
||CEXC|Int32||XmlEnum("""CEXC""")|18|
||CASH|Int32||XmlEnum("""CASH""")|19|
||CASE|Int32||XmlEnum("""CASE""")|20|
||BUYA|Int32||XmlEnum("""BUYA""")|21|
||BSPL|Int32||XmlEnum("""BSPL""")|22|
||ABST|Int32||XmlEnum("""ABST""")|23|

---

## Value ISO20022.Seev037002.CorporateActionOption246


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev037002.CashOption112>||XmlElement()||
|+|SctiesMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev037002.SecuritiesOption86>||XmlElement()||
|+|OptnTp|ISO20022.Seev037002.CorporateActionOption39Choice||XmlElement()||
|+|OptnNb|ISO20022.Seev037002.OptionNumber1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CshMvmntDtls""",CshMvmntDtls),validElement(CshMvmntDtls),validList("""SctiesMvmntDtls""",SctiesMvmntDtls),validElement(SctiesMvmntDtls),validElement(OptnTp),validElement(OptnNb))|

---

## Value ISO20022.Seev037002.CorporateActionOption39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev037002.CorporateActionReversalReason10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Seev037002.CorporateActionReversalReason12Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,256}"""),validElement(Rsn))|

---

## Value ISO20022.Seev037002.CorporateActionReversalReason12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev037002.CorporateActionReversalReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||UPAY|Int32||XmlEnum("""UPAY""")|2|
||IVAD|Int32||XmlEnum("""IVAD""")|3|
||IPRI|Int32||XmlEnum("""IPRI""")|4|
||IPCU|Int32||XmlEnum("""IPCU""")|5|
||IETR|Int32||XmlEnum("""IETR""")|6|
||IRED|Int32||XmlEnum("""IRED""")|7|
||FNRC|Int32||XmlEnum("""FNRC""")|8|
||DCBD|Int32||XmlEnum("""DCBD""")|9|

---

## Enum ISO20022.Seev037002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Seev037002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Seev037002.DateCode22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev037002.DateFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev037002.DateCode22Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Seev037002.DateType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Type ISO20022.Seev037002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnMvmntRvslAdvc|ISO20022.Seev037002.CorporateActionMovementReversalAdvice002V16||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnMvmntRvslAdvc))|

---

## Value ISO20022.Seev037002.DocumentIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev037002.ProcessingPosition10Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev037002.DocumentIdentification38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev037002.ProcessingPosition10Choice||XmlElement()||
|+|DocNb|ISO20022.Seev037002.DocumentNumber6Choice||XmlElement()||
|+|Id|ISO20022.Seev037002.DocumentIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(DocNb),validElement(Id))|

---

## Value ISO20022.Seev037002.DocumentIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOwnrDocId|String||XmlElement()||
|+|AcctSvcrDocId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AcctOwnrDocId""",AcctOwnrDocId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrDocId""",AcctSvcrDocId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validChoice(AcctOwnrDocId,AcctSvcrDocId))|

---

## Value ISO20022.Seev037002.DocumentNumber6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Seev037002.GenericIdentification86||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Value ISO20022.Seev037002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev037002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev037002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev037002.GenericIdentification86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev037002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev037002.IntermediateSecuritiesDistributionTypeFormat18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev037002.IntermediateSecurityDistributionType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MRGR|Int32||XmlEnum("""MRGR""")|1|
||EXOF|Int32||XmlEnum("""EXOF""")|2|
||BONU|Int32||XmlEnum("""BONU""")|3|
||SPLF|Int32||XmlEnum("""SPLF""")|4|
||SOFF|Int32||XmlEnum("""SOFF""")|5|
||LIQU|Int32||XmlEnum("""LIQU""")|6|
||INTR|Int32||XmlEnum("""INTR""")|7|
||DVSE|Int32||XmlEnum("""DVSE""")|8|
||DVSC|Int32||XmlEnum("""DVSC""")|9|
||PRIO|Int32||XmlEnum("""PRIO""")|10|
||EXRI|Int32||XmlEnum("""EXRI""")|11|
||DVOP|Int32||XmlEnum("""DVOP""")|12|
||DVCA|Int32||XmlEnum("""DVCA""")|13|
||DRIP|Int32||XmlEnum("""DRIP""")|14|
||BIDS|Int32||XmlEnum("""BIDS""")|15|

---

## Enum ISO20022.Seev037002.LotteryType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUPP|Int32||XmlEnum("""SUPP""")|1|
||ORIG|Int32||XmlEnum("""ORIG""")|2|

---

## Value ISO20022.Seev037002.LotteryTypeFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev037002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Seev037002.OptionNumber1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nb""",Nb,"""[0-9]{3}"""),validChoice(Cd,Nb))|

---

## Enum ISO20022.Seev037002.OptionNumber1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNSO|Int32||XmlEnum("""UNSO""")|1|

---

## Value ISO20022.Seev037002.OriginalAndCurrentQuantities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev037002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev037002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Seev037002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Seev037002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Seev037002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Seev037002.ProcessingPosition10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev037002.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Seev037002.ProprietaryQuantity9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev037002.Quantity53Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev037002.ProprietaryQuantity9||XmlElement()||
|+|Qty|ISO20022.Seev037002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(Qty),validChoice(PrtryQty,Qty))|

---

## Value ISO20022.Seev037002.Quantity54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Seev037002.OriginalAndCurrentQuantities4||XmlElement()||
|+|Qty|ISO20022.Seev037002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Seev037002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev037002.SecuritiesOption86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlPstngDt|ISO20022.Seev037002.DateAndDateTime2Choice||XmlElement()||
|+|PstngDt|ISO20022.Seev037002.DateAndDateTime2Choice||XmlElement()||
|+|PstngQty|ISO20022.Seev037002.Quantity54Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|FinInstrmId|ISO20022.Seev037002.SecurityIdentification20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlPstngDt),validElement(PstngDt),validElement(PstngQty),validElement(FinInstrmId))|

---

## Value ISO20022.Seev037002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev037002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Seev037002.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Seev037002.SignedQuantityFormat12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyChc|ISO20022.Seev037002.Quantity53Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyChc))|

---

## Value ISO20022.Seev037002.SignedQuantityFormat13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Seev037002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Seev037002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev037002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev037002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev037002.TransactionIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktInfrstrctrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktInfrstrctrTxId""",MktInfrstrctrTxId,"""([^/]+/)+([^/]+)\|([^/]*)"""))|

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

