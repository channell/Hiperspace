# seev.037.001.16
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev037001.Account10Choice {
        + TaxAcct  : ISO20022.Seev037001.CashAccountIdentification5Choice
        + ChrgsAcct  : ISO20022.Seev037001.CashAccountIdentification5Choice
        + CshAcct  : ISO20022.Seev037001.CashAccountIdentification9Choice
    }
    ISO20022.Seev037001.Account10Choice *-- ISO20022.Seev037001.CashAccountIdentification5Choice
    ISO20022.Seev037001.Account10Choice *-- ISO20022.Seev037001.CashAccountIdentification5Choice
    ISO20022.Seev037001.Account10Choice *-- ISO20022.Seev037001.CashAccountIdentification9Choice
    class ISO20022.Seev037001.AccountAndBalance50 {
        + ConfdBal  : ISO20022.Seev037001.BalanceFormat11Choice
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
    }
    ISO20022.Seev037001.AccountAndBalance50 *-- ISO20022.Seev037001.BalanceFormat11Choice
    class ISO20022.Seev037001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev037001.AdditionalBusinessProcess7Code {
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
    class ISO20022.Seev037001.AdditionalBusinessProcessFormat11Choice {
        + Prtry  : ISO20022.Seev037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev037001.AdditionalBusinessProcessFormat11Choice *-- ISO20022.Seev037001.GenericIdentification30
    class ISO20022.Seev037001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Seev037001.BalanceFormat11Choice {
        + NotElgblBal  : ISO20022.Seev037001.SignedQuantityFormat10
        + ElgblBal  : ISO20022.Seev037001.SignedQuantityFormat10
        + Bal  : ISO20022.Seev037001.SignedQuantityFormat11
    }
    ISO20022.Seev037001.BalanceFormat11Choice *-- ISO20022.Seev037001.SignedQuantityFormat10
    ISO20022.Seev037001.BalanceFormat11Choice *-- ISO20022.Seev037001.SignedQuantityFormat10
    ISO20022.Seev037001.BalanceFormat11Choice *-- ISO20022.Seev037001.SignedQuantityFormat11
    class ISO20022.Seev037001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Seev037001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Seev037001.BlockChainAddressWallet3 *-- ISO20022.Seev037001.GenericIdentification30
    class ISO20022.Seev037001.CashAccountIdentification5Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Seev037001.CashAccountIdentification9Choice {
        + Prtry  : String
        + BlckChainCshWllt  : ISO20022.Seev037001.BlockChainAddressWallet3
        + IBAN  : String
    }
    ISO20022.Seev037001.CashAccountIdentification9Choice *-- ISO20022.Seev037001.BlockChainAddressWallet3
    class ISO20022.Seev037001.CashOption109 {
        + PstngAmt  : ISO20022.Seev037001.ActiveCurrencyAndAmount
        + ValDt  : DateTime
        + OrgnlPstngDt  : ISO20022.Seev037001.DateAndDateTime2Choice
        + PstngDt  : ISO20022.Seev037001.DateAndDateTime2Choice
        + Acct  : ISO20022.Seev037001.Account10Choice
        + CdtDbtInd  : String
    }
    ISO20022.Seev037001.CashOption109 *-- ISO20022.Seev037001.ActiveCurrencyAndAmount
    ISO20022.Seev037001.CashOption109 *-- ISO20022.Seev037001.DateAndDateTime2Choice
    ISO20022.Seev037001.CashOption109 *-- ISO20022.Seev037001.DateAndDateTime2Choice
    ISO20022.Seev037001.CashOption109 *-- ISO20022.Seev037001.Account10Choice
    class ISO20022.Seev037001.CorporateAction70 {
        + LtryTp  : ISO20022.Seev037001.LotteryTypeFormat4Choice
        + IntrmdtSctiesDstrbtnTp  : ISO20022.Seev037001.IntermediateSecuritiesDistributionTypeFormat15Choice
        + AddtlBizPrcInd  : ISO20022.Seev037001.AdditionalBusinessProcessFormat11Choice
        + EvtStag  : ISO20022.Seev037001.CorporateActionEventStageFormat14Choice
        + DtDtls  : ISO20022.Seev037001.CorporateActionDate86
    }
    ISO20022.Seev037001.CorporateAction70 *-- ISO20022.Seev037001.LotteryTypeFormat4Choice
    ISO20022.Seev037001.CorporateAction70 *-- ISO20022.Seev037001.IntermediateSecuritiesDistributionTypeFormat15Choice
    ISO20022.Seev037001.CorporateAction70 *-- ISO20022.Seev037001.AdditionalBusinessProcessFormat11Choice
    ISO20022.Seev037001.CorporateAction70 *-- ISO20022.Seev037001.CorporateActionEventStageFormat14Choice
    ISO20022.Seev037001.CorporateAction70 *-- ISO20022.Seev037001.CorporateActionDate86
    class ISO20022.Seev037001.CorporateActionDate86 {
        + ExDvddDt  : ISO20022.Seev037001.DateFormat30Choice
        + RcrdDt  : ISO20022.Seev037001.DateFormat30Choice
    }
    ISO20022.Seev037001.CorporateActionDate86 *-- ISO20022.Seev037001.DateFormat30Choice
    ISO20022.Seev037001.CorporateActionDate86 *-- ISO20022.Seev037001.DateFormat30Choice
    class ISO20022.Seev037001.CorporateActionEventReference3 {
        + LkgTp  : ISO20022.Seev037001.ProcessingPosition7Choice
        + EvtId  : ISO20022.Seev037001.CorporateActionEventReference3Choice
    }
    ISO20022.Seev037001.CorporateActionEventReference3 *-- ISO20022.Seev037001.ProcessingPosition7Choice
    ISO20022.Seev037001.CorporateActionEventReference3 *-- ISO20022.Seev037001.CorporateActionEventReference3Choice
    class ISO20022.Seev037001.CorporateActionEventReference3Choice {
        + LkdCorpActnId  : String
        + LkdOffclCorpActnEvtId  : String
    }
    class ISO20022.Seev037001.CorporateActionEventStage4Code {
        RESC = 1
        PART = 2
        FULL = 3
    }
    class ISO20022.Seev037001.CorporateActionEventStageFormat14Choice {
        + Prtry  : ISO20022.Seev037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev037001.CorporateActionEventStageFormat14Choice *-- ISO20022.Seev037001.GenericIdentification30
    class ISO20022.Seev037001.CorporateActionEventType109Choice {
        + Prtry  : ISO20022.Seev037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev037001.CorporateActionEventType109Choice *-- ISO20022.Seev037001.GenericIdentification30
    class ISO20022.Seev037001.CorporateActionEventType37Code {
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
    class ISO20022.Seev037001.CorporateActionGeneralInformation179 {
        + FrctnlQty  : ISO20022.Seev037001.FinancialInstrumentQuantity33Choice
        + FinInstrmId  : ISO20022.Seev037001.SecurityIdentification19
        + EvtTp  : ISO20022.Seev037001.CorporateActionEventType109Choice
        + ClssActnNb  : String
        + OffclCorpActnEvtId  : String
        + CorpActnEvtId  : String
    }
    ISO20022.Seev037001.CorporateActionGeneralInformation179 *-- ISO20022.Seev037001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev037001.CorporateActionGeneralInformation179 *-- ISO20022.Seev037001.SecurityIdentification19
    ISO20022.Seev037001.CorporateActionGeneralInformation179 *-- ISO20022.Seev037001.CorporateActionEventType109Choice
    class ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev037001.SupplementaryData1~
        + SubPngAgt  : global::System.Collections.Generic.List~ISO20022.Seev037001.PartyIdentification120Choice~
        + PngAgt  : global::System.Collections.Generic.List~ISO20022.Seev037001.PartyIdentification120Choice~
        + IssrAgt  : global::System.Collections.Generic.List~ISO20022.Seev037001.PartyIdentification120Choice~
        + AddtlInf  : ISO20022.Seev037001.CorporateActionNarrative31
        + CorpActnConfDtls  : ISO20022.Seev037001.CorporateActionOption240
        + CorpActnDtls  : ISO20022.Seev037001.CorporateAction70
        + AcctDtls  : ISO20022.Seev037001.AccountAndBalance50
        + CorpActnGnlInf  : ISO20022.Seev037001.CorporateActionGeneralInformation179
        + TxId  : ISO20022.Seev037001.TransactionIdentification15
        + RvslRsn  : ISO20022.Seev037001.CorporateActionReversalReason8
        + EvtsLkg  : global::System.Collections.Generic.List~ISO20022.Seev037001.CorporateActionEventReference3~
        + OthrDocId  : global::System.Collections.Generic.List~ISO20022.Seev037001.DocumentIdentification32~
        + MvmntConfId  : ISO20022.Seev037001.DocumentIdentification31
    }
    ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16 *-- ISO20022.Seev037001.SupplementaryData1
    ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16 *-- ISO20022.Seev037001.PartyIdentification120Choice
    ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16 *-- ISO20022.Seev037001.PartyIdentification120Choice
    ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16 *-- ISO20022.Seev037001.PartyIdentification120Choice
    ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16 *-- ISO20022.Seev037001.CorporateActionNarrative31
    ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16 *-- ISO20022.Seev037001.CorporateActionOption240
    ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16 *-- ISO20022.Seev037001.CorporateAction70
    ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16 *-- ISO20022.Seev037001.AccountAndBalance50
    ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16 *-- ISO20022.Seev037001.CorporateActionGeneralInformation179
    ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16 *-- ISO20022.Seev037001.TransactionIdentification15
    ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16 *-- ISO20022.Seev037001.CorporateActionReversalReason8
    ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16 *-- ISO20022.Seev037001.CorporateActionEventReference3
    ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16 *-- ISO20022.Seev037001.DocumentIdentification32
    ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16 *-- ISO20022.Seev037001.DocumentIdentification31
    class ISO20022.Seev037001.CorporateActionNarrative31 {
        + TaxtnConds  : global::System.Collections.Generic.List~String~
        + PtyCtctNrrtv  : global::System.Collections.Generic.List~String~
        + NrrtvVrsn  : global::System.Collections.Generic.List~String~
        + AddtlTxt  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Seev037001.CorporateActionOption12Code {
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
    class ISO20022.Seev037001.CorporateActionOption240 {
        + CshMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev037001.CashOption109~
        + SctiesMvmntDtls  : global::System.Collections.Generic.List~ISO20022.Seev037001.SecuritiesOption80~
        + OptnTp  : ISO20022.Seev037001.CorporateActionOption33Choice
        + OptnNb  : ISO20022.Seev037001.OptionNumber1Choice
    }
    ISO20022.Seev037001.CorporateActionOption240 *-- ISO20022.Seev037001.CashOption109
    ISO20022.Seev037001.CorporateActionOption240 *-- ISO20022.Seev037001.SecuritiesOption80
    ISO20022.Seev037001.CorporateActionOption240 *-- ISO20022.Seev037001.CorporateActionOption33Choice
    ISO20022.Seev037001.CorporateActionOption240 *-- ISO20022.Seev037001.OptionNumber1Choice
    class ISO20022.Seev037001.CorporateActionOption33Choice {
        + Prtry  : ISO20022.Seev037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev037001.CorporateActionOption33Choice *-- ISO20022.Seev037001.GenericIdentification30
    class ISO20022.Seev037001.CorporateActionReversalReason10Choice {
        + Prtry  : ISO20022.Seev037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev037001.CorporateActionReversalReason10Choice *-- ISO20022.Seev037001.GenericIdentification30
    class ISO20022.Seev037001.CorporateActionReversalReason3Code {
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
    class ISO20022.Seev037001.CorporateActionReversalReason8 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Seev037001.CorporateActionReversalReason10Choice
    }
    ISO20022.Seev037001.CorporateActionReversalReason8 *-- ISO20022.Seev037001.CorporateActionReversalReason10Choice
    class ISO20022.Seev037001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Seev037001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Seev037001.DateCode19Choice {
        + Prtry  : ISO20022.Seev037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev037001.DateCode19Choice *-- ISO20022.Seev037001.GenericIdentification30
    class ISO20022.Seev037001.DateFormat30Choice {
        + DtCd  : ISO20022.Seev037001.DateCode19Choice
        + Dt  : DateTime
    }
    ISO20022.Seev037001.DateFormat30Choice *-- ISO20022.Seev037001.DateCode19Choice
    class ISO20022.Seev037001.DateType8Code {
        ONGO = 1
        UKWN = 2
    }
    class ISO20022.Seev037001.DocumentIdentification31 {
        + LkgTp  : ISO20022.Seev037001.ProcessingPosition7Choice
        + Id  : String
    }
    ISO20022.Seev037001.DocumentIdentification31 *-- ISO20022.Seev037001.ProcessingPosition7Choice
    class ISO20022.Seev037001.DocumentIdentification32 {
        + LkgTp  : ISO20022.Seev037001.ProcessingPosition7Choice
        + DocNb  : ISO20022.Seev037001.DocumentNumber5Choice
        + Id  : ISO20022.Seev037001.DocumentIdentification3Choice
    }
    ISO20022.Seev037001.DocumentIdentification32 *-- ISO20022.Seev037001.ProcessingPosition7Choice
    ISO20022.Seev037001.DocumentIdentification32 *-- ISO20022.Seev037001.DocumentNumber5Choice
    ISO20022.Seev037001.DocumentIdentification32 *-- ISO20022.Seev037001.DocumentIdentification3Choice
    class ISO20022.Seev037001.DocumentIdentification3Choice {
        + AcctOwnrDocId  : String
        + AcctSvcrDocId  : String
    }
    class ISO20022.Seev037001.DocumentNumber5Choice {
        + PrtryNb  : ISO20022.Seev037001.GenericIdentification36
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Seev037001.DocumentNumber5Choice *-- ISO20022.Seev037001.GenericIdentification36
    class ISO20022.Seev037001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev037001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev037001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev037001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev037001.IntermediateSecuritiesDistributionTypeFormat15Choice {
        + Prtry  : ISO20022.Seev037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev037001.IntermediateSecuritiesDistributionTypeFormat15Choice *-- ISO20022.Seev037001.GenericIdentification30
    class ISO20022.Seev037001.IntermediateSecurityDistributionType5Code {
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
    class ISO20022.Seev037001.LotteryType1Code {
        SUPP = 1
        ORIG = 2
    }
    class ISO20022.Seev037001.LotteryTypeFormat4Choice {
        + Prtry  : ISO20022.Seev037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev037001.LotteryTypeFormat4Choice *-- ISO20022.Seev037001.GenericIdentification30
    class ISO20022.Seev037001.NameAndAddress5 {
        + Adr  : ISO20022.Seev037001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Seev037001.NameAndAddress5 *-- ISO20022.Seev037001.PostalAddress1
    class ISO20022.Seev037001.OptionNumber1Choice {
        + Cd  : String
        + Nb  : String
    }
    class ISO20022.Seev037001.OptionNumber1Code {
        UNSO = 1
    }
    class ISO20022.Seev037001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Seev037001.OtherIdentification1 {
        + Tp  : ISO20022.Seev037001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev037001.OtherIdentification1 *-- ISO20022.Seev037001.IdentificationSource3Choice
    class ISO20022.Seev037001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Seev037001.NameAndAddress5
        + PrtryId  : ISO20022.Seev037001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Seev037001.PartyIdentification120Choice *-- ISO20022.Seev037001.NameAndAddress5
    ISO20022.Seev037001.PartyIdentification120Choice *-- ISO20022.Seev037001.GenericIdentification36
    class ISO20022.Seev037001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Seev037001.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Seev037001.ProcessingPosition7Choice {
        + Prtry  : ISO20022.Seev037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev037001.ProcessingPosition7Choice *-- ISO20022.Seev037001.GenericIdentification30
    class ISO20022.Seev037001.ProprietaryQuantity8 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
    }
    class ISO20022.Seev037001.Quantity48Choice {
        + PrtryQty  : ISO20022.Seev037001.ProprietaryQuantity8
        + Qty  : ISO20022.Seev037001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Seev037001.Quantity48Choice *-- ISO20022.Seev037001.ProprietaryQuantity8
    ISO20022.Seev037001.Quantity48Choice *-- ISO20022.Seev037001.FinancialInstrumentQuantity33Choice
    class ISO20022.Seev037001.Quantity51Choice {
        + OrgnlAndCurFace  : ISO20022.Seev037001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Seev037001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Seev037001.Quantity51Choice *-- ISO20022.Seev037001.OriginalAndCurrentQuantities1
    ISO20022.Seev037001.Quantity51Choice *-- ISO20022.Seev037001.FinancialInstrumentQuantity33Choice
    class ISO20022.Seev037001.SecuritiesOption80 {
        + OrgnlPstngDt  : ISO20022.Seev037001.DateAndDateTime2Choice
        + PstngDt  : ISO20022.Seev037001.DateAndDateTime2Choice
        + PstngQty  : ISO20022.Seev037001.Quantity51Choice
        + CdtDbtInd  : String
        + FinInstrmId  : ISO20022.Seev037001.SecurityIdentification19
    }
    ISO20022.Seev037001.SecuritiesOption80 *-- ISO20022.Seev037001.DateAndDateTime2Choice
    ISO20022.Seev037001.SecuritiesOption80 *-- ISO20022.Seev037001.DateAndDateTime2Choice
    ISO20022.Seev037001.SecuritiesOption80 *-- ISO20022.Seev037001.Quantity51Choice
    ISO20022.Seev037001.SecuritiesOption80 *-- ISO20022.Seev037001.SecurityIdentification19
    class ISO20022.Seev037001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev037001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Seev037001.SecurityIdentification19 *-- ISO20022.Seev037001.OtherIdentification1
    class ISO20022.Seev037001.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Seev037001.SignedQuantityFormat10 {
        + Qty  : ISO20022.Seev037001.FinancialInstrumentQuantity33Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev037001.SignedQuantityFormat10 *-- ISO20022.Seev037001.FinancialInstrumentQuantity33Choice
    class ISO20022.Seev037001.SignedQuantityFormat11 {
        + QtyChc  : ISO20022.Seev037001.Quantity48Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev037001.SignedQuantityFormat11 *-- ISO20022.Seev037001.Quantity48Choice
    class ISO20022.Seev037001.SupplementaryData1 {
        + Envlp  : ISO20022.Seev037001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev037001.SupplementaryData1 *-- ISO20022.Seev037001.SupplementaryDataEnvelope1
    class ISO20022.Seev037001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Seev037001.TransactionIdentification15 {
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

## Value ISO20022.Seev037001.Account10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxAcct|ISO20022.Seev037001.CashAccountIdentification5Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Seev037001.CashAccountIdentification5Choice||XmlElement()||
|+|CshAcct|ISO20022.Seev037001.CashAccountIdentification9Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxAcct),validElement(ChrgsAcct),validElement(CshAcct),validChoice(TaxAcct,ChrgsAcct,CshAcct))|

---

## Value ISO20022.Seev037001.AccountAndBalance50


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ConfdBal|ISO20022.Seev037001.BalanceFormat11Choice||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ConfdBal))|

---

## Value ISO20022.Seev037001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev037001.AdditionalBusinessProcess7Code


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

## Value ISO20022.Seev037001.AdditionalBusinessProcessFormat11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev037001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Seev037001.BalanceFormat11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotElgblBal|ISO20022.Seev037001.SignedQuantityFormat10||XmlElement()||
|+|ElgblBal|ISO20022.Seev037001.SignedQuantityFormat10||XmlElement()||
|+|Bal|ISO20022.Seev037001.SignedQuantityFormat11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotElgblBal),validElement(ElgblBal),validElement(Bal),validChoice(NotElgblBal,ElgblBal,Bal))|

---

## Value ISO20022.Seev037001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Seev037001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev037001.CashAccountIdentification5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Value ISO20022.Seev037001.CashAccountIdentification9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|BlckChainCshWllt|ISO20022.Seev037001.BlockChainAddressWallet3||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainCshWllt),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,BlckChainCshWllt,IBAN))|

---

## Value ISO20022.Seev037001.CashOption109


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstngAmt|ISO20022.Seev037001.ActiveCurrencyAndAmount||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|OrgnlPstngDt|ISO20022.Seev037001.DateAndDateTime2Choice||XmlElement()||
|+|PstngDt|ISO20022.Seev037001.DateAndDateTime2Choice||XmlElement()||
|+|Acct|ISO20022.Seev037001.Account10Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstngAmt),validElement(OrgnlPstngDt),validElement(PstngDt),validElement(Acct))|

---

## Value ISO20022.Seev037001.CorporateAction70


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LtryTp|ISO20022.Seev037001.LotteryTypeFormat4Choice||XmlElement()||
|+|IntrmdtSctiesDstrbtnTp|ISO20022.Seev037001.IntermediateSecuritiesDistributionTypeFormat15Choice||XmlElement()||
|+|AddtlBizPrcInd|ISO20022.Seev037001.AdditionalBusinessProcessFormat11Choice||XmlElement()||
|+|EvtStag|ISO20022.Seev037001.CorporateActionEventStageFormat14Choice||XmlElement()||
|+|DtDtls|ISO20022.Seev037001.CorporateActionDate86||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LtryTp),validElement(IntrmdtSctiesDstrbtnTp),validElement(AddtlBizPrcInd),validElement(EvtStag),validElement(DtDtls))|

---

## Value ISO20022.Seev037001.CorporateActionDate86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ExDvddDt|ISO20022.Seev037001.DateFormat30Choice||XmlElement()||
|+|RcrdDt|ISO20022.Seev037001.DateFormat30Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ExDvddDt),validElement(RcrdDt))|

---

## Value ISO20022.Seev037001.CorporateActionEventReference3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev037001.ProcessingPosition7Choice||XmlElement()||
|+|EvtId|ISO20022.Seev037001.CorporateActionEventReference3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(EvtId))|

---

## Value ISO20022.Seev037001.CorporateActionEventReference3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkdCorpActnId|String||XmlElement()||
|+|LkdOffclCorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(LkdCorpActnId,LkdOffclCorpActnEvtId))|

---

## Enum ISO20022.Seev037001.CorporateActionEventStage4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RESC|Int32||XmlEnum("""RESC""")|1|
||PART|Int32||XmlEnum("""PART""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Seev037001.CorporateActionEventStageFormat14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev037001.CorporateActionEventType109Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev037001.CorporateActionEventType37Code


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

## Value ISO20022.Seev037001.CorporateActionGeneralInformation179


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrctnlQty|ISO20022.Seev037001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Seev037001.SecurityIdentification19||XmlElement()||
|+|EvtTp|ISO20022.Seev037001.CorporateActionEventType109Choice||XmlElement()||
|+|ClssActnNb|String||XmlElement()||
|+|OffclCorpActnEvtId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrctnlQty),validElement(FinInstrmId),validElement(EvtTp))|

---

## Aspect ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev037001.SupplementaryData1>||XmlElement()||
|+|SubPngAgt|global::System.Collections.Generic.List<ISO20022.Seev037001.PartyIdentification120Choice>||XmlElement()||
|+|PngAgt|global::System.Collections.Generic.List<ISO20022.Seev037001.PartyIdentification120Choice>||XmlElement()||
|+|IssrAgt|global::System.Collections.Generic.List<ISO20022.Seev037001.PartyIdentification120Choice>||XmlElement()||
|+|AddtlInf|ISO20022.Seev037001.CorporateActionNarrative31||XmlElement()||
|+|CorpActnConfDtls|ISO20022.Seev037001.CorporateActionOption240||XmlElement()||
|+|CorpActnDtls|ISO20022.Seev037001.CorporateAction70||XmlElement()||
|+|AcctDtls|ISO20022.Seev037001.AccountAndBalance50||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev037001.CorporateActionGeneralInformation179||XmlElement()||
|+|TxId|ISO20022.Seev037001.TransactionIdentification15||XmlElement()||
|+|RvslRsn|ISO20022.Seev037001.CorporateActionReversalReason8||XmlElement()||
|+|EvtsLkg|global::System.Collections.Generic.List<ISO20022.Seev037001.CorporateActionEventReference3>||XmlElement()||
|+|OthrDocId|global::System.Collections.Generic.List<ISO20022.Seev037001.DocumentIdentification32>||XmlElement()||
|+|MvmntConfId|ISO20022.Seev037001.DocumentIdentification31||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""SubPngAgt""",SubPngAgt),validElement(SubPngAgt),validList("""PngAgt""",PngAgt),validElement(PngAgt),validList("""IssrAgt""",IssrAgt),validElement(IssrAgt),validElement(AddtlInf),validElement(CorpActnConfDtls),validElement(CorpActnDtls),validElement(AcctDtls),validElement(CorpActnGnlInf),validElement(TxId),validElement(RvslRsn),validList("""EvtsLkg""",EvtsLkg),validElement(EvtsLkg),validList("""OthrDocId""",OthrDocId),validElement(OthrDocId),validElement(MvmntConfId))|

---

## Value ISO20022.Seev037001.CorporateActionNarrative31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxtnConds|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PtyCtctNrrtv|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NrrtvVrsn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AddtlTxt|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev037001.CorporateActionOption12Code


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

## Value ISO20022.Seev037001.CorporateActionOption240


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev037001.CashOption109>||XmlElement()||
|+|SctiesMvmntDtls|global::System.Collections.Generic.List<ISO20022.Seev037001.SecuritiesOption80>||XmlElement()||
|+|OptnTp|ISO20022.Seev037001.CorporateActionOption33Choice||XmlElement()||
|+|OptnNb|ISO20022.Seev037001.OptionNumber1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CshMvmntDtls""",CshMvmntDtls),validElement(CshMvmntDtls),validList("""SctiesMvmntDtls""",SctiesMvmntDtls),validElement(SctiesMvmntDtls),validElement(OptnTp),validElement(OptnNb))|

---

## Value ISO20022.Seev037001.CorporateActionOption33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev037001.CorporateActionReversalReason10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev037001.CorporateActionReversalReason3Code


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

## Value ISO20022.Seev037001.CorporateActionReversalReason8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Seev037001.CorporateActionReversalReason10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Enum ISO20022.Seev037001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Seev037001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Seev037001.DateCode19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev037001.DateFormat30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Seev037001.DateCode19Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Seev037001.DateType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONGO|Int32||XmlEnum("""ONGO""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|

---

## Type ISO20022.Seev037001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnMvmntRvslAdvc|ISO20022.Seev037001.CorporateActionMovementReversalAdviceV16||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnMvmntRvslAdvc))|

---

## Value ISO20022.Seev037001.DocumentIdentification31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev037001.ProcessingPosition7Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp))|

---

## Value ISO20022.Seev037001.DocumentIdentification32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev037001.ProcessingPosition7Choice||XmlElement()||
|+|DocNb|ISO20022.Seev037001.DocumentNumber5Choice||XmlElement()||
|+|Id|ISO20022.Seev037001.DocumentIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(DocNb),validElement(Id))|

---

## Value ISO20022.Seev037001.DocumentIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOwnrDocId|String||XmlElement()||
|+|AcctSvcrDocId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AcctOwnrDocId,AcctSvcrDocId))|

---

## Value ISO20022.Seev037001.DocumentNumber5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Seev037001.GenericIdentification36||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Value ISO20022.Seev037001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev037001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev037001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev037001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev037001.IntermediateSecuritiesDistributionTypeFormat15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev037001.IntermediateSecurityDistributionType5Code


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

## Enum ISO20022.Seev037001.LotteryType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUPP|Int32||XmlEnum("""SUPP""")|1|
||ORIG|Int32||XmlEnum("""ORIG""")|2|

---

## Value ISO20022.Seev037001.LotteryTypeFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev037001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev037001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Seev037001.OptionNumber1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nb""",Nb,"""[0-9]{3}"""),validChoice(Cd,Nb))|

---

## Enum ISO20022.Seev037001.OptionNumber1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNSO|Int32||XmlEnum("""UNSO""")|1|

---

## Value ISO20022.Seev037001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev037001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev037001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev037001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Seev037001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Seev037001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Seev037001.PostalAddress1


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

## Enum ISO20022.Seev037001.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Seev037001.ProcessingPosition7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev037001.ProprietaryQuantity8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev037001.Quantity48Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev037001.ProprietaryQuantity8||XmlElement()||
|+|Qty|ISO20022.Seev037001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(Qty),validChoice(PrtryQty,Qty))|

---

## Value ISO20022.Seev037001.Quantity51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Seev037001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Seev037001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Seev037001.SecuritiesOption80


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlPstngDt|ISO20022.Seev037001.DateAndDateTime2Choice||XmlElement()||
|+|PstngDt|ISO20022.Seev037001.DateAndDateTime2Choice||XmlElement()||
|+|PstngQty|ISO20022.Seev037001.Quantity51Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|FinInstrmId|ISO20022.Seev037001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlPstngDt),validElement(PstngDt),validElement(PstngQty),validElement(FinInstrmId))|

---

## Value ISO20022.Seev037001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev037001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Seev037001.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Seev037001.SignedQuantityFormat10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Seev037001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Seev037001.SignedQuantityFormat11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyChc|ISO20022.Seev037001.Quantity48Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyChc))|

---

## Value ISO20022.Seev037001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev037001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev037001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev037001.TransactionIdentification15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktInfrstrctrTxId|String||XmlElement()||
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

