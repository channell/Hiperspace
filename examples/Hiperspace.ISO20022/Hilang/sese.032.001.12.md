# sese.032.001.12
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese032001.AcknowledgedAcceptedStatus21Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032001.AcknowledgementReason9~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese032001.AcknowledgedAcceptedStatus21Choice *-- ISO20022.Sese032001.AcknowledgementReason9
    class ISO20022.Sese032001.AcknowledgementReason12Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.AcknowledgementReason12Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.AcknowledgementReason5Code {
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
    class ISO20022.Sese032001.AcknowledgementReason9 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032001.AcknowledgementReason12Choice
    }
    ISO20022.Sese032001.AcknowledgementReason9 *-- ISO20022.Sese032001.AcknowledgementReason12Choice
    class ISO20022.Sese032001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese032001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese032001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese032001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Sese032001.AffirmationStatus1Code {
        NAFI = 1
        AFFI = 2
    }
    class ISO20022.Sese032001.AffirmationStatus8Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.AffirmationStatus8Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.AlternatePartyIdentification7 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Sese032001.IdentificationType42Choice
    }
    ISO20022.Sese032001.AlternatePartyIdentification7 *-- ISO20022.Sese032001.IdentificationType42Choice
    class ISO20022.Sese032001.AmountAndDirection44 {
        + FXDtls  : ISO20022.Sese032001.ForeignExchangeTerms23
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese032001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese032001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Sese032001.AmountAndDirection44 *-- ISO20022.Sese032001.ForeignExchangeTerms23
    ISO20022.Sese032001.AmountAndDirection44 *-- ISO20022.Sese032001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese032001.AmountAndDirection44 *-- ISO20022.Sese032001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese032001.AmountAndDirection94 {
        + ValDt  : ISO20022.Sese032001.DateAndDateTime2Choice
        + FXDtls  : ISO20022.Sese032001.ForeignExchangeTerms23
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese032001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese032001.ActiveCurrencyAndAmount
        + RsrchFeeInd  : String
        + BrkrgAmtInd  : String
        + StmpDtyInd  : String
        + AcrdIntrstInd  : String
    }
    ISO20022.Sese032001.AmountAndDirection94 *-- ISO20022.Sese032001.DateAndDateTime2Choice
    ISO20022.Sese032001.AmountAndDirection94 *-- ISO20022.Sese032001.ForeignExchangeTerms23
    ISO20022.Sese032001.AmountAndDirection94 *-- ISO20022.Sese032001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese032001.AmountAndDirection94 *-- ISO20022.Sese032001.ActiveCurrencyAndAmount
    class ISO20022.Sese032001.AutoBorrowing1Code {
        YBOR = 1
        NBOR = 2
        LAMI = 3
    }
    class ISO20022.Sese032001.AutomaticBorrowing6Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.AutomaticBorrowing6Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.BeneficialOwnership4Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese032001.BeneficialOwnership4Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Sese032001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese032001.BlockChainAddressWallet3 *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.BlockTrade1Code {
        BLCH = 1
        BLPA = 2
    }
    class ISO20022.Sese032001.BlockTrade4Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.BlockTrade4Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.CashAccountIdentification5Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Sese032001.CashAccountIdentification9Choice {
        + Prtry  : String
        + BlckChainCshWllt  : ISO20022.Sese032001.BlockChainAddressWallet3
        + IBAN  : String
    }
    ISO20022.Sese032001.CashAccountIdentification9Choice *-- ISO20022.Sese032001.BlockChainAddressWallet3
    class ISO20022.Sese032001.CashParties41 {
        + Intrmy  : ISO20022.Sese032001.PartyIdentificationAndAccount224
        + CdtrAgt  : ISO20022.Sese032001.PartyIdentificationAndAccount224
        + Cdtr  : ISO20022.Sese032001.PartyIdentificationAndAccount223
        + DbtrAgt  : ISO20022.Sese032001.PartyIdentificationAndAccount224
        + Dbtr  : ISO20022.Sese032001.PartyIdentificationAndAccount223
    }
    ISO20022.Sese032001.CashParties41 *-- ISO20022.Sese032001.PartyIdentificationAndAccount224
    ISO20022.Sese032001.CashParties41 *-- ISO20022.Sese032001.PartyIdentificationAndAccount224
    ISO20022.Sese032001.CashParties41 *-- ISO20022.Sese032001.PartyIdentificationAndAccount223
    ISO20022.Sese032001.CashParties41 *-- ISO20022.Sese032001.PartyIdentificationAndAccount224
    ISO20022.Sese032001.CashParties41 *-- ISO20022.Sese032001.PartyIdentificationAndAccount223
    class ISO20022.Sese032001.CashSettlementSystem2Code {
        NETS = 1
        GROS = 2
    }
    class ISO20022.Sese032001.CashSettlementSystem4Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.CashSettlementSystem4Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.CentralCounterPartyEligibility4Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese032001.CentralCounterPartyEligibility4Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.ClassificationType32Choice {
        + AltrnClssfctn  : ISO20022.Sese032001.GenericIdentification36
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Sese032001.ClassificationType32Choice *-- ISO20022.Sese032001.GenericIdentification36
    class ISO20022.Sese032001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese032001.CurrencyToBuyOrSell1Choice {
        + CcyToSell  : String
        + CcyToBuy  : String
    }
    class ISO20022.Sese032001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese032001.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese032001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese032001.DeliveryReturn1Code {
        PARD = 1
        DUEB = 2
        SAFE = 3
        PART = 4
        DMON = 5
        DQUA = 6
        UNRE = 7
    }
    class ISO20022.Sese032001.DeliveryReturn3Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.DeliveryReturn3Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.DocumentNumber5Choice {
        + PrtryNb  : ISO20022.Sese032001.GenericIdentification36
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Sese032001.DocumentNumber5Choice *-- ISO20022.Sese032001.GenericIdentification36
    class ISO20022.Sese032001.Eligibility1Code {
        PROF = 1
        RETL = 2
        ELIG = 3
    }
    class ISO20022.Sese032001.EventFrequency3Code {
        WEEK = 1
        SEMI = 2
        QUTR = 3
        MNTH = 4
        YEAR = 5
    }
    class ISO20022.Sese032001.ExposureType15Code {
        CBCO = 1
        TRCP = 2
        UDMS = 3
        TBAS = 4
        SWPT = 5
        SCIE = 6
        SCIR = 7
        SHSL = 8
        SLEB = 9
        SCRP = 10
        SBSC = 11
        SLOA = 12
        RVPO = 13
        REPO = 14
        OTCD = 15
        LIQU = 16
        OPTN = 17
        FUTR = 18
        FORW = 19
        FORX = 20
        FIXI = 21
        EXPT = 22
        EQUS = 23
        EXTD = 24
        EQPT = 25
        CRPR = 26
        CCIR = 27
        CRSP = 28
        CRTL = 29
        CRDS = 30
        COMM = 31
        CCPC = 32
        PAYM = 33
        BFWD = 34
    }
    class ISO20022.Sese032001.ExposureType25Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.ExposureType25Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.FXStandingInstruction4Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese032001.FXStandingInstruction4Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.FailingReason13 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032001.FailingReason18Choice
    }
    ISO20022.Sese032001.FailingReason13 *-- ISO20022.Sese032001.FailingReason18Choice
    class ISO20022.Sese032001.FailingReason18Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.FailingReason18Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.FailingReason5Code {
        PREL = 1
        PATD = 2
        INBC = 3
        CVAL = 4
        CSDH = 5
        CDLR = 6
        PRSY = 7
        CERT = 8
        SETS = 9
        REGT = 10
        PRCY = 11
        LIQU = 12
        LATE = 13
        LAAW = 14
        FROZ = 15
        DKNY = 16
        DISA = 17
        DENO = 18
        CLHT = 19
        BOTH = 20
        BENO = 21
        PHCK = 22
        OTHR = 23
        IAAD = 24
        MINO = 25
        CPEC = 26
        SBLO = 27
        CYCL = 28
        BATC = 29
        SDUT = 30
        REFS = 31
        NCON = 32
        MONY = 33
        LALO = 34
        LACK = 35
        LINK = 36
        INCA = 37
        FLIM = 38
        DEPO = 39
        COLL = 40
        YCOL = 41
        CMON = 42
        NOFX = 43
        PART = 44
        PREA = 45
        GLOB = 46
        MUNO = 47
        CLAC = 48
        NEWI = 49
        CHAS = 50
        BLOC = 51
        DOCC = 52
        MLAT = 53
        DOCY = 54
        STCD = 55
        PHSE = 56
        AWSH = 57
        OBJT = 58
        CAIS = 59
        CANR = 60
        ADEA = 61
        CLAT = 62
        BYIY = 63
        AWMO = 64
    }
    class ISO20022.Sese032001.FailingStatus15Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032001.FailingReason13~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese032001.FailingStatus15Choice *-- ISO20022.Sese032001.FailingReason13
    class ISO20022.Sese032001.FinancialInstrumentAttributes111 {
        + FinInstrmAttrAddtlDtls  : String
        + UndrlygFinInstrmId  : global::System.Collections.Generic.List~ISO20022.Sese032001.SecurityIdentification19~
        + CtrctSz  : ISO20022.Sese032001.FinancialInstrumentQuantity33Choice
        + MinNmnlQty  : ISO20022.Sese032001.FinancialInstrumentQuantity33Choice
        + StrkPric  : ISO20022.Sese032001.Price7
        + ConvsPric  : ISO20022.Sese032001.Price7
        + SbcptPric  : ISO20022.Sese032001.Price7
        + ExrcPric  : ISO20022.Sese032001.Price7
        + MktOrIndctvPric  : ISO20022.Sese032001.PriceType4Choice
        + PutblInd  : String
        + CllblInd  : String
        + VarblRateInd  : String
        + PoolNb  : ISO20022.Sese032001.GenericIdentification37
        + CpnAttchdNb  : ISO20022.Sese032001.Number22Choice
        + IndxRateBsis  : Decimal
        + NxtIntrstRate  : Decimal
        + YldToMtrtyRate  : Decimal
        + IntrstRate  : Decimal
        + NxtFctr  : Decimal
        + CurFctr  : Decimal
        + PrvsFctr  : Decimal
        + FrstPmtDt  : DateTime
        + DtdDt  : DateTime
        + PutblDt  : DateTime
        + NxtCllblDt  : DateTime
        + IsseDt  : DateTime
        + MtrtyDt  : DateTime
        + FltgRateFxgDt  : DateTime
        + XpryDt  : DateTime
        + CpnDt  : DateTime
        + DnmtnCcy  : String
        + OptnTp  : ISO20022.Sese032001.OptionType6Choice
        + OptnStyle  : ISO20022.Sese032001.OptionStyle8Choice
        + ClssfctnTp  : ISO20022.Sese032001.ClassificationType32Choice
        + VarblRateChngFrqcy  : ISO20022.Sese032001.Frequency23Choice
        + PmtSts  : ISO20022.Sese032001.SecuritiesPaymentStatus5Choice
        + PmtFrqcy  : ISO20022.Sese032001.Frequency23Choice
        + RegnForm  : ISO20022.Sese032001.FormOfSecurity6Choice
        + DayCntBsis  : ISO20022.Sese032001.InterestComputationMethodFormat4Choice
        + PlcOfListg  : ISO20022.Sese032001.MarketIdentification3Choice
    }
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.SecurityIdentification19
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.FinancialInstrumentQuantity33Choice
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.FinancialInstrumentQuantity33Choice
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.Price7
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.Price7
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.Price7
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.Price7
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.PriceType4Choice
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.GenericIdentification37
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.Number22Choice
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.OptionType6Choice
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.OptionStyle8Choice
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.ClassificationType32Choice
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.Frequency23Choice
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.SecuritiesPaymentStatus5Choice
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.Frequency23Choice
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.FormOfSecurity6Choice
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.InterestComputationMethodFormat4Choice
    ISO20022.Sese032001.FinancialInstrumentAttributes111 *-- ISO20022.Sese032001.MarketIdentification3Choice
    class ISO20022.Sese032001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese032001.ForeignExchangeTerms23 {
        + RsltgAmt  : ISO20022.Sese032001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Sese032001.ForeignExchangeTerms23 *-- ISO20022.Sese032001.ActiveCurrencyAndAmount
    class ISO20022.Sese032001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Sese032001.FormOfSecurity6Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.FormOfSecurity6Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.Frequency23Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.Frequency23Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.GeneratedReason3Code {
        TRAN = 1
        THRD = 2
        SPLI = 3
        RODE = 4
        OTHR = 5
        CLAI = 6
        COLL = 7
    }
    class ISO20022.Sese032001.GeneratedReason5 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032001.GeneratedReasons5Choice
    }
    ISO20022.Sese032001.GeneratedReason5 *-- ISO20022.Sese032001.GeneratedReasons5Choice
    class ISO20022.Sese032001.GeneratedReasons5Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.GeneratedReasons5Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Sese032001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese032001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese032001.GenericIdentification37 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese032001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Sese032001.GenericIdentification30
    }
    ISO20022.Sese032001.GenericIdentification78 *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.HoldIndicator6 {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032001.RegistrationReason5~
        + Ind  : String
    }
    ISO20022.Sese032001.HoldIndicator6 *-- ISO20022.Sese032001.RegistrationReason5
    class ISO20022.Sese032001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese032001.IdentificationType42Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.IdentificationType42Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.InterestComputationMethod2Code {
        NARR = 1
        A014 = 2
        A013 = 3
        A012 = 4
        A011 = 5
        A010 = 6
        A009 = 7
        A008 = 8
        A007 = 9
        A006 = 10
        A005 = 11
        A004 = 12
        A003 = 13
        A002 = 14
        A001 = 15
    }
    class ISO20022.Sese032001.InterestComputationMethodFormat4Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.InterestComputationMethodFormat4Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.InvestorCapacity4Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.InvestorCapacity4Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.LetterOfGuarantee4Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese032001.LetterOfGuarantee4Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.Linkages61 {
        + RefOwnr  : ISO20022.Sese032001.PartyIdentification127Choice
        + LkdQty  : ISO20022.Sese032001.PairedOrTurnedQuantity5Choice
        + Ref  : ISO20022.Sese032001.References73Choice
        + MsgNb  : ISO20022.Sese032001.DocumentNumber5Choice
        + PrcgPos  : ISO20022.Sese032001.ProcessingPosition7Choice
    }
    ISO20022.Sese032001.Linkages61 *-- ISO20022.Sese032001.PartyIdentification127Choice
    ISO20022.Sese032001.Linkages61 *-- ISO20022.Sese032001.PairedOrTurnedQuantity5Choice
    ISO20022.Sese032001.Linkages61 *-- ISO20022.Sese032001.References73Choice
    ISO20022.Sese032001.Linkages61 *-- ISO20022.Sese032001.DocumentNumber5Choice
    ISO20022.Sese032001.Linkages61 *-- ISO20022.Sese032001.ProcessingPosition7Choice
    class ISO20022.Sese032001.MarketClientSide1Code {
        MAKT = 1
        CLNT = 2
    }
    class ISO20022.Sese032001.MarketClientSide6Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.MarketClientSide6Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.MarketIdentification1Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese032001.MarketIdentification3Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese032001.MarketIdentification84 {
        + Tp  : ISO20022.Sese032001.MarketType8Choice
        + Id  : ISO20022.Sese032001.MarketIdentification1Choice
    }
    ISO20022.Sese032001.MarketIdentification84 *-- ISO20022.Sese032001.MarketType8Choice
    ISO20022.Sese032001.MarketIdentification84 *-- ISO20022.Sese032001.MarketIdentification1Choice
    class ISO20022.Sese032001.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Sese032001.MarketType8Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.MarketType8Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.MatchingStatus1Code {
        NMAT = 1
        MACH = 2
    }
    class ISO20022.Sese032001.MatchingStatus24Choice {
        + Prtry  : ISO20022.Sese032001.ProprietaryStatusAndReason6
        + Umtchd  : ISO20022.Sese032001.UnmatchedStatus16Choice
        + Mtchd  : ISO20022.Sese032001.ProprietaryReason4
    }
    ISO20022.Sese032001.MatchingStatus24Choice *-- ISO20022.Sese032001.ProprietaryStatusAndReason6
    ISO20022.Sese032001.MatchingStatus24Choice *-- ISO20022.Sese032001.UnmatchedStatus16Choice
    ISO20022.Sese032001.MatchingStatus24Choice *-- ISO20022.Sese032001.ProprietaryReason4
    class ISO20022.Sese032001.MatchingStatus27Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.MatchingStatus27Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.ModificationCancellationAllowed4Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese032001.ModificationCancellationAllowed4Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.NameAndAddress5 {
        + Adr  : ISO20022.Sese032001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Sese032001.NameAndAddress5 *-- ISO20022.Sese032001.PostalAddress1
    class ISO20022.Sese032001.NettingEligibility4Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese032001.NettingEligibility4Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.NetworkFee1 {
        + NtwkFeeQty  : Decimal
        + FinInstrmId  : ISO20022.Sese032001.SecurityIdentification19
    }
    ISO20022.Sese032001.NetworkFee1 *-- ISO20022.Sese032001.SecurityIdentification19
    class ISO20022.Sese032001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Sese032001.Number22Choice {
        + Lng  : ISO20022.Sese032001.GenericIdentification1
        + Shrt  : String
    }
    ISO20022.Sese032001.Number22Choice *-- ISO20022.Sese032001.GenericIdentification1
    class ISO20022.Sese032001.NumberCount2Choice {
        + TtlNb  : ISO20022.Sese032001.TotalNumber2
        + CurInstrNb  : String
    }
    ISO20022.Sese032001.NumberCount2Choice *-- ISO20022.Sese032001.TotalNumber2
    class ISO20022.Sese032001.OpeningClosing1Code {
        OPEP = 1
        CLOP = 2
    }
    class ISO20022.Sese032001.OpeningClosing3Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.OpeningClosing3Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Sese032001.OptionStyle8Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.OptionStyle8Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Sese032001.OptionType6Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.OptionType6Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Sese032001.OriginatorRole2Code {
        TAGT = 1
        INVE = 2
        MKTM = 3
        RMKT = 4
        MLTF = 5
        SINT = 6
    }
    class ISO20022.Sese032001.OtherAmounts45 {
        + NtwkFee  : ISO20022.Sese032001.AmountAndDirection44
        + RsrchFee  : ISO20022.Sese032001.AmountAndDirection44
        + AcrdCptlstnAmt  : ISO20022.Sese032001.AmountAndDirection44
        + CsmptnTax  : ISO20022.Sese032001.AmountAndDirection44
        + NetGnLoss  : ISO20022.Sese032001.AmountAndDirection44
        + WhldgTax  : ISO20022.Sese032001.AmountAndDirection44
        + ValAddedTax  : ISO20022.Sese032001.AmountAndDirection44
        + TxTax  : ISO20022.Sese032001.AmountAndDirection44
        + TrfTax  : ISO20022.Sese032001.AmountAndDirection44
        + StockXchgTax  : ISO20022.Sese032001.AmountAndDirection44
        + StmpDty  : ISO20022.Sese032001.AmountAndDirection44
        + SpclCncssn  : ISO20022.Sese032001.AmountAndDirection44
        + ShppgAmt  : ISO20022.Sese032001.AmountAndDirection44
        + RgltryAmt  : ISO20022.Sese032001.AmountAndDirection44
        + Othr  : ISO20022.Sese032001.AmountAndDirection44
        + Mrgn  : ISO20022.Sese032001.AmountAndDirection44
        + LclBrkrComssn  : ISO20022.Sese032001.AmountAndDirection44
        + LclTaxCtrySpcfc  : ISO20022.Sese032001.AmountAndDirection44
        + LclTax  : ISO20022.Sese032001.AmountAndDirection44
        + PmtLevyTax  : ISO20022.Sese032001.AmountAndDirection44
        + IsseDscntAllwnc  : ISO20022.Sese032001.AmountAndDirection44
        + ExctgBrkrAmt  : ISO20022.Sese032001.AmountAndDirection44
        + TradAmt  : ISO20022.Sese032001.AmountAndDirection44
        + CtryNtlFdrlTax  : ISO20022.Sese032001.AmountAndDirection44
        + ChrgsFees  : ISO20022.Sese032001.AmountAndDirection44
        + AcrdIntrstAmt  : ISO20022.Sese032001.AmountAndDirection44
    }
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    ISO20022.Sese032001.OtherAmounts45 *-- ISO20022.Sese032001.AmountAndDirection44
    class ISO20022.Sese032001.OtherIdentification1 {
        + Tp  : ISO20022.Sese032001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese032001.OtherIdentification1 *-- ISO20022.Sese032001.IdentificationSource3Choice
    class ISO20022.Sese032001.OtherParties43 {
        + Brkr  : ISO20022.Sese032001.PartyIdentificationAndAccount198
        + TrptyAgt  : ISO20022.Sese032001.PartyIdentificationAndAccount198
        + TradRgltr  : ISO20022.Sese032001.PartyIdentificationAndAccount165
        + StockXchg  : ISO20022.Sese032001.PartyIdentificationAndAccount165
        + QlfdFrgnIntrmy  : ISO20022.Sese032001.PartyIdentificationAndAccount198
        + Invstr  : global::System.Collections.Generic.List~ISO20022.Sese032001.PartyIdentificationAndAccount197~
    }
    ISO20022.Sese032001.OtherParties43 *-- ISO20022.Sese032001.PartyIdentificationAndAccount198
    ISO20022.Sese032001.OtherParties43 *-- ISO20022.Sese032001.PartyIdentificationAndAccount198
    ISO20022.Sese032001.OtherParties43 *-- ISO20022.Sese032001.PartyIdentificationAndAccount165
    ISO20022.Sese032001.OtherParties43 *-- ISO20022.Sese032001.PartyIdentificationAndAccount165
    ISO20022.Sese032001.OtherParties43 *-- ISO20022.Sese032001.PartyIdentificationAndAccount198
    ISO20022.Sese032001.OtherParties43 *-- ISO20022.Sese032001.PartyIdentificationAndAccount197
    class ISO20022.Sese032001.OwnershipLegalRestrictions1Code {
        RSTR = 1
        NRST = 2
        A144 = 3
    }
    class ISO20022.Sese032001.PairedOrTurnedQuantity5Choice {
        + TrndQty  : ISO20022.Sese032001.FinancialInstrumentQuantity33Choice
        + PairdOffQty  : ISO20022.Sese032001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Sese032001.PairedOrTurnedQuantity5Choice *-- ISO20022.Sese032001.FinancialInstrumentQuantity33Choice
    ISO20022.Sese032001.PairedOrTurnedQuantity5Choice *-- ISO20022.Sese032001.FinancialInstrumentQuantity33Choice
    class ISO20022.Sese032001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Sese032001.NameAndAddress5
        + PrtryId  : ISO20022.Sese032001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese032001.PartyIdentification120Choice *-- ISO20022.Sese032001.NameAndAddress5
    ISO20022.Sese032001.PartyIdentification120Choice *-- ISO20022.Sese032001.GenericIdentification36
    class ISO20022.Sese032001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Sese032001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese032001.PartyIdentification127Choice *-- ISO20022.Sese032001.GenericIdentification36
    class ISO20022.Sese032001.PartyIdentification133Choice {
        + PrtryId  : ISO20022.Sese032001.GenericIdentification36
        + NmAndAdr  : ISO20022.Sese032001.NameAndAddress5
        + BICFI  : String
    }
    ISO20022.Sese032001.PartyIdentification133Choice *-- ISO20022.Sese032001.GenericIdentification36
    ISO20022.Sese032001.PartyIdentification133Choice *-- ISO20022.Sese032001.NameAndAddress5
    class ISO20022.Sese032001.PartyIdentification144 {
        + LEI  : String
        + Id  : ISO20022.Sese032001.PartyIdentification127Choice
    }
    ISO20022.Sese032001.PartyIdentification144 *-- ISO20022.Sese032001.PartyIdentification127Choice
    class ISO20022.Sese032001.PartyIdentification257Choice {
        + DgtlLdgrId  : String
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese032001.NameAndAddress5
        + AnyBIC  : String
    }
    ISO20022.Sese032001.PartyIdentification257Choice *-- ISO20022.Sese032001.NameAndAddress5
    class ISO20022.Sese032001.PartyIdentification315 {
        + AddtlInf  : ISO20022.Sese032001.PartyTextInformation1
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese032001.DateAndDateTime2Choice
        + AltrnId  : ISO20022.Sese032001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese032001.PartyIdentification257Choice
    }
    ISO20022.Sese032001.PartyIdentification315 *-- ISO20022.Sese032001.PartyTextInformation1
    ISO20022.Sese032001.PartyIdentification315 *-- ISO20022.Sese032001.DateAndDateTime2Choice
    ISO20022.Sese032001.PartyIdentification315 *-- ISO20022.Sese032001.AlternatePartyIdentification7
    ISO20022.Sese032001.PartyIdentification315 *-- ISO20022.Sese032001.PartyIdentification257Choice
    class ISO20022.Sese032001.PartyIdentificationAndAccount165 {
        + AddtlInf  : ISO20022.Sese032001.PartyTextInformation1
        + PrcgId  : String
        + AltrnId  : ISO20022.Sese032001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese032001.PartyIdentification120Choice
    }
    ISO20022.Sese032001.PartyIdentificationAndAccount165 *-- ISO20022.Sese032001.PartyTextInformation1
    ISO20022.Sese032001.PartyIdentificationAndAccount165 *-- ISO20022.Sese032001.AlternatePartyIdentification7
    ISO20022.Sese032001.PartyIdentificationAndAccount165 *-- ISO20022.Sese032001.PartyIdentification120Choice
    class ISO20022.Sese032001.PartyIdentificationAndAccount196 {
        + AddtlInf  : ISO20022.Sese032001.PartyTextInformation1
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese032001.DateAndDateTime2Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese032001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese032001.SecuritiesAccount19
        + AltrnId  : ISO20022.Sese032001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese032001.PartyIdentification120Choice
    }
    ISO20022.Sese032001.PartyIdentificationAndAccount196 *-- ISO20022.Sese032001.PartyTextInformation1
    ISO20022.Sese032001.PartyIdentificationAndAccount196 *-- ISO20022.Sese032001.DateAndDateTime2Choice
    ISO20022.Sese032001.PartyIdentificationAndAccount196 *-- ISO20022.Sese032001.BlockChainAddressWallet3
    ISO20022.Sese032001.PartyIdentificationAndAccount196 *-- ISO20022.Sese032001.SecuritiesAccount19
    ISO20022.Sese032001.PartyIdentificationAndAccount196 *-- ISO20022.Sese032001.AlternatePartyIdentification7
    ISO20022.Sese032001.PartyIdentificationAndAccount196 *-- ISO20022.Sese032001.PartyIdentification120Choice
    class ISO20022.Sese032001.PartyIdentificationAndAccount197 {
        + AddtlInf  : ISO20022.Sese032001.PartyTextInformation1
        + PrcgId  : String
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
        + Ntlty  : String
        + AltrnId  : ISO20022.Sese032001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese032001.PartyIdentification120Choice
    }
    ISO20022.Sese032001.PartyIdentificationAndAccount197 *-- ISO20022.Sese032001.PartyTextInformation1
    ISO20022.Sese032001.PartyIdentificationAndAccount197 *-- ISO20022.Sese032001.AlternatePartyIdentification7
    ISO20022.Sese032001.PartyIdentificationAndAccount197 *-- ISO20022.Sese032001.PartyIdentification120Choice
    class ISO20022.Sese032001.PartyIdentificationAndAccount198 {
        + AddtlInf  : ISO20022.Sese032001.PartyTextInformation1
        + PrcgId  : String
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
        + AltrnId  : ISO20022.Sese032001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese032001.PartyIdentification120Choice
    }
    ISO20022.Sese032001.PartyIdentificationAndAccount198 *-- ISO20022.Sese032001.PartyTextInformation1
    ISO20022.Sese032001.PartyIdentificationAndAccount198 *-- ISO20022.Sese032001.AlternatePartyIdentification7
    ISO20022.Sese032001.PartyIdentificationAndAccount198 *-- ISO20022.Sese032001.PartyIdentification120Choice
    class ISO20022.Sese032001.PartyIdentificationAndAccount223 {
        + AddtlInf  : ISO20022.Sese032001.PartyTextInformation2
        + TaxAcct  : ISO20022.Sese032001.CashAccountIdentification5Choice
        + ComssnAcct  : ISO20022.Sese032001.CashAccountIdentification5Choice
        + ChrgsAcct  : ISO20022.Sese032001.CashAccountIdentification5Choice
        + CshAcct  : ISO20022.Sese032001.CashAccountIdentification9Choice
        + AltrnId  : ISO20022.Sese032001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese032001.PartyIdentification120Choice
    }
    ISO20022.Sese032001.PartyIdentificationAndAccount223 *-- ISO20022.Sese032001.PartyTextInformation2
    ISO20022.Sese032001.PartyIdentificationAndAccount223 *-- ISO20022.Sese032001.CashAccountIdentification5Choice
    ISO20022.Sese032001.PartyIdentificationAndAccount223 *-- ISO20022.Sese032001.CashAccountIdentification5Choice
    ISO20022.Sese032001.PartyIdentificationAndAccount223 *-- ISO20022.Sese032001.CashAccountIdentification5Choice
    ISO20022.Sese032001.PartyIdentificationAndAccount223 *-- ISO20022.Sese032001.CashAccountIdentification9Choice
    ISO20022.Sese032001.PartyIdentificationAndAccount223 *-- ISO20022.Sese032001.AlternatePartyIdentification7
    ISO20022.Sese032001.PartyIdentificationAndAccount223 *-- ISO20022.Sese032001.PartyIdentification120Choice
    class ISO20022.Sese032001.PartyIdentificationAndAccount224 {
        + AddtlInf  : ISO20022.Sese032001.PartyTextInformation2
        + TaxAcct  : ISO20022.Sese032001.CashAccountIdentification5Choice
        + ComssnAcct  : ISO20022.Sese032001.CashAccountIdentification5Choice
        + ChrgsAcct  : ISO20022.Sese032001.CashAccountIdentification5Choice
        + CshAcct  : ISO20022.Sese032001.CashAccountIdentification9Choice
        + AltrnId  : ISO20022.Sese032001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese032001.PartyIdentification133Choice
    }
    ISO20022.Sese032001.PartyIdentificationAndAccount224 *-- ISO20022.Sese032001.PartyTextInformation2
    ISO20022.Sese032001.PartyIdentificationAndAccount224 *-- ISO20022.Sese032001.CashAccountIdentification5Choice
    ISO20022.Sese032001.PartyIdentificationAndAccount224 *-- ISO20022.Sese032001.CashAccountIdentification5Choice
    ISO20022.Sese032001.PartyIdentificationAndAccount224 *-- ISO20022.Sese032001.CashAccountIdentification5Choice
    ISO20022.Sese032001.PartyIdentificationAndAccount224 *-- ISO20022.Sese032001.CashAccountIdentification9Choice
    ISO20022.Sese032001.PartyIdentificationAndAccount224 *-- ISO20022.Sese032001.AlternatePartyIdentification7
    ISO20022.Sese032001.PartyIdentificationAndAccount224 *-- ISO20022.Sese032001.PartyIdentification133Choice
    class ISO20022.Sese032001.PartyTextInformation1 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese032001.PartyTextInformation2 {
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese032001.PendingProcessingReason10Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.PendingProcessingReason10Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.PendingProcessingReason2Code {
        INBC = 1
        CDAC = 2
        CDLR = 3
        CDEL = 4
        CVAL = 5
        CSDH = 6
        CERT = 7
        LIQU = 8
        DENO = 9
        OTHR = 10
        MINO = 11
        MONY = 12
        LALO = 13
        LACK = 14
        NEXT = 15
        FLIM = 16
        COLL = 17
        YCOL = 18
        GLOB = 19
        MUNO = 20
        BLOC = 21
        NOFX = 22
        DOCY = 23
        CAIS = 24
        ADEA = 25
    }
    class ISO20022.Sese032001.PendingProcessingReason8 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032001.PendingProcessingReason10Choice
    }
    ISO20022.Sese032001.PendingProcessingReason8 *-- ISO20022.Sese032001.PendingProcessingReason10Choice
    class ISO20022.Sese032001.PendingProcessingStatus11Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032001.PendingProcessingReason8~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese032001.PendingProcessingStatus11Choice *-- ISO20022.Sese032001.PendingProcessingReason8
    class ISO20022.Sese032001.PendingReason16 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032001.PendingReason28Choice
    }
    ISO20022.Sese032001.PendingReason16 *-- ISO20022.Sese032001.PendingReason28Choice
    class ISO20022.Sese032001.PendingReason28Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.PendingReason28Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.PendingReason28Code {
        PREL = 1
        PATD = 2
        INBC = 3
        CDLR = 4
        CVAL = 5
        CSDH = 6
        PRSY = 7
        CERT = 8
        SETS = 9
        REGT = 10
        PRCY = 11
        LIQU = 12
        LATE = 13
        LAAW = 14
        FROZ = 15
        DKNY = 16
        DISA = 17
        DENO = 18
        CLHT = 19
        BOTH = 20
        BENO = 21
        PHCK = 22
        OTHR = 23
        IAAD = 24
        MINO = 25
        CPEC = 26
        SBLO = 27
        CYCL = 28
        BATC = 29
        SDUT = 30
        REFS = 31
        NCON = 32
        MONY = 33
        LALO = 34
        LACK = 35
        FUTU = 36
        LINK = 37
        INCA = 38
        FLIM = 39
        DEPO = 40
        COLL = 41
        YCOL = 42
        CMON = 43
        NOFX = 44
        NMAS = 45
        PART = 46
        PREA = 47
        GLOB = 48
        MUNO = 49
        CLAC = 50
        NEWI = 51
        CHAS = 52
        BLOC = 53
        DOCC = 54
        DOCY = 55
        TAMM = 56
        PHSE = 57
        AWSH = 58
        REFU = 59
        CAIS = 60
        ADEA = 61
        AWMO = 62
    }
    class ISO20022.Sese032001.PendingReason32 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032001.PendingReason69Choice
    }
    ISO20022.Sese032001.PendingReason32 *-- ISO20022.Sese032001.PendingReason69Choice
    class ISO20022.Sese032001.PendingReason69Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.PendingReason69Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.PendingReason6Code {
        CDRE = 1
        CDCY = 2
        CDRG = 3
        OTHR = 4
        CONF = 5
        ADEA = 6
    }
    class ISO20022.Sese032001.PendingStatus38Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032001.PendingReason16~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese032001.PendingStatus38Choice *-- ISO20022.Sese032001.PendingReason16
    class ISO20022.Sese032001.PendingStatus73Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032001.PendingReason32~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese032001.PendingStatus73Choice *-- ISO20022.Sese032001.PendingReason32
    class ISO20022.Sese032001.PlaceOfClearingIdentification2 {
        + LEI  : String
        + Id  : String
    }
    class ISO20022.Sese032001.PlaceOfTradeIdentification1 {
        + LEI  : String
        + MktTpAndId  : ISO20022.Sese032001.MarketIdentification84
    }
    ISO20022.Sese032001.PlaceOfTradeIdentification1 *-- ISO20022.Sese032001.MarketIdentification84
    class ISO20022.Sese032001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Sese032001.Price10 {
        + Val  : ISO20022.Sese032001.PriceRateOrAmount3Choice
        + Tp  : ISO20022.Sese032001.YieldedOrValueType2Choice
    }
    ISO20022.Sese032001.Price10 *-- ISO20022.Sese032001.PriceRateOrAmount3Choice
    ISO20022.Sese032001.Price10 *-- ISO20022.Sese032001.YieldedOrValueType2Choice
    class ISO20022.Sese032001.Price7 {
        + Val  : ISO20022.Sese032001.PriceRateOrAmount3Choice
        + Tp  : ISO20022.Sese032001.YieldedOrValueType1Choice
    }
    ISO20022.Sese032001.Price7 *-- ISO20022.Sese032001.PriceRateOrAmount3Choice
    ISO20022.Sese032001.Price7 *-- ISO20022.Sese032001.YieldedOrValueType1Choice
    class ISO20022.Sese032001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Sese032001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Sese032001.PriceRateOrAmount3Choice *-- ISO20022.Sese032001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Sese032001.PriceType4Choice {
        + Indctv  : ISO20022.Sese032001.Price7
        + Mkt  : ISO20022.Sese032001.Price7
    }
    ISO20022.Sese032001.PriceType4Choice *-- ISO20022.Sese032001.Price7
    ISO20022.Sese032001.PriceType4Choice *-- ISO20022.Sese032001.Price7
    class ISO20022.Sese032001.PriceValueType12Code {
        NEGA = 1
        PREM = 2
        PARV = 3
        DISC = 4
    }
    class ISO20022.Sese032001.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Sese032001.PriorityNumeric4Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Nmrc  : String
    }
    ISO20022.Sese032001.PriorityNumeric4Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Sese032001.ProcessingPosition7Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.ProcessingPosition7Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.ProcessingStatus52Choice {
        + CxlReqd  : ISO20022.Sese032001.ProprietaryReason4
        + Prtry  : ISO20022.Sese032001.ProprietaryStatusAndReason6
        + PdgCxl  : ISO20022.Sese032001.PendingStatus38Choice
        + Rpr  : ISO20022.Sese032001.RepairStatus12Choice
        + PdgPrcg  : ISO20022.Sese032001.PendingProcessingStatus11Choice
        + AckdAccptd  : ISO20022.Sese032001.AcknowledgedAcceptedStatus21Choice
    }
    ISO20022.Sese032001.ProcessingStatus52Choice *-- ISO20022.Sese032001.ProprietaryReason4
    ISO20022.Sese032001.ProcessingStatus52Choice *-- ISO20022.Sese032001.ProprietaryStatusAndReason6
    ISO20022.Sese032001.ProcessingStatus52Choice *-- ISO20022.Sese032001.PendingStatus38Choice
    ISO20022.Sese032001.ProcessingStatus52Choice *-- ISO20022.Sese032001.RepairStatus12Choice
    ISO20022.Sese032001.ProcessingStatus52Choice *-- ISO20022.Sese032001.PendingProcessingStatus11Choice
    ISO20022.Sese032001.ProcessingStatus52Choice *-- ISO20022.Sese032001.AcknowledgedAcceptedStatus21Choice
    class ISO20022.Sese032001.ProprietaryReason4 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Sese032001.GenericIdentification30
    }
    ISO20022.Sese032001.ProprietaryReason4 *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.ProprietaryStatusAndReason6 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Sese032001.ProprietaryReason4~
        + PrtrySts  : ISO20022.Sese032001.GenericIdentification30
    }
    ISO20022.Sese032001.ProprietaryStatusAndReason6 *-- ISO20022.Sese032001.ProprietaryReason4
    ISO20022.Sese032001.ProprietaryStatusAndReason6 *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.Quantity51Choice {
        + OrgnlAndCurFace  : ISO20022.Sese032001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Sese032001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Sese032001.Quantity51Choice *-- ISO20022.Sese032001.OriginalAndCurrentQuantities1
    ISO20022.Sese032001.Quantity51Choice *-- ISO20022.Sese032001.FinancialInstrumentQuantity33Choice
    class ISO20022.Sese032001.QuantityAndAccount117 {
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Sese032001.QuantityBreakdown62~
        + SfkpgPlc  : ISO20022.Sese032001.SafeKeepingPlace5
        + CshAcct  : ISO20022.Sese032001.CashAccountIdentification9Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese032001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese032001.SecuritiesAccount19
        + AcctOwnr  : ISO20022.Sese032001.PartyIdentification144
        + DnmtnChc  : String
        + SttlmQty  : ISO20022.Sese032001.Quantity51Choice
    }
    ISO20022.Sese032001.QuantityAndAccount117 *-- ISO20022.Sese032001.QuantityBreakdown62
    ISO20022.Sese032001.QuantityAndAccount117 *-- ISO20022.Sese032001.SafeKeepingPlace5
    ISO20022.Sese032001.QuantityAndAccount117 *-- ISO20022.Sese032001.CashAccountIdentification9Choice
    ISO20022.Sese032001.QuantityAndAccount117 *-- ISO20022.Sese032001.BlockChainAddressWallet3
    ISO20022.Sese032001.QuantityAndAccount117 *-- ISO20022.Sese032001.SecuritiesAccount19
    ISO20022.Sese032001.QuantityAndAccount117 *-- ISO20022.Sese032001.PartyIdentification144
    ISO20022.Sese032001.QuantityAndAccount117 *-- ISO20022.Sese032001.Quantity51Choice
    class ISO20022.Sese032001.QuantityBreakdown62 {
        + TpOfPric  : ISO20022.Sese032001.TypeOfPrice29Choice
        + LotPric  : ISO20022.Sese032001.Price7
        + LotDtTm  : ISO20022.Sese032001.DateAndDateTime2Choice
        + LotQty  : ISO20022.Sese032001.FinancialInstrumentQuantity33Choice
        + LotNb  : ISO20022.Sese032001.GenericIdentification37
    }
    ISO20022.Sese032001.QuantityBreakdown62 *-- ISO20022.Sese032001.TypeOfPrice29Choice
    ISO20022.Sese032001.QuantityBreakdown62 *-- ISO20022.Sese032001.Price7
    ISO20022.Sese032001.QuantityBreakdown62 *-- ISO20022.Sese032001.DateAndDateTime2Choice
    ISO20022.Sese032001.QuantityBreakdown62 *-- ISO20022.Sese032001.FinancialInstrumentQuantity33Choice
    ISO20022.Sese032001.QuantityBreakdown62 *-- ISO20022.Sese032001.GenericIdentification37
    class ISO20022.Sese032001.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese032001.References73Choice {
        + OthrTxId  : String
        + PoolId  : String
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + IntraBalMvmntId  : String
        + IntraPosMvmntId  : String
        + SctiesSttlmTxId  : String
    }
    class ISO20022.Sese032001.Registration10Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.Registration10Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.Registration1Code {
        YREG = 1
        NREG = 2
    }
    class ISO20022.Sese032001.Registration2Code {
        CVAL = 1
        CDEL = 2
        CSDH = 3
        PTYH = 4
    }
    class ISO20022.Sese032001.Registration9Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.Registration9Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.RegistrationParameters6 {
        + CertNb  : global::System.Collections.Generic.List~ISO20022.Sese032001.SecuritiesCertificate4~
        + RegarAcct  : String
        + CertfctnDtTm  : ISO20022.Sese032001.DateAndDateTime2Choice
        + CertfctnId  : String
    }
    ISO20022.Sese032001.RegistrationParameters6 *-- ISO20022.Sese032001.SecuritiesCertificate4
    ISO20022.Sese032001.RegistrationParameters6 *-- ISO20022.Sese032001.DateAndDateTime2Choice
    class ISO20022.Sese032001.RegistrationReason5 {
        + AddtlInf  : String
        + Cd  : ISO20022.Sese032001.Registration10Choice
    }
    ISO20022.Sese032001.RegistrationReason5 *-- ISO20022.Sese032001.Registration10Choice
    class ISO20022.Sese032001.RepairReason10Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.RepairReason10Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.RepairReason4Code {
        ICUS = 1
        DEPT = 2
        ICAG = 3
        IEXE = 4
        OTHR = 5
        SDUT = 6
        INPS = 7
        TXST = 8
        SETS = 9
        SETR = 10
        SAFE = 11
        RTGS = 12
        REFE = 13
        PLCE = 14
        PHYS = 15
        NCRR = 16
        MUNO = 17
        MINO = 18
        IIND = 19
        DTRD = 20
        DSEC = 21
        DQUA = 22
        DMON = 23
        DDEA = 24
        DDAT = 25
        CASY = 26
        CASH = 27
        CAEV = 28
        BATC = 29
    }
    class ISO20022.Sese032001.RepairReason8 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032001.RepairReason10Choice
    }
    ISO20022.Sese032001.RepairReason8 *-- ISO20022.Sese032001.RepairReason10Choice
    class ISO20022.Sese032001.RepairStatus12Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032001.RepairReason8~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese032001.RepairStatus12Choice *-- ISO20022.Sese032001.RepairReason8
    class ISO20022.Sese032001.Reporting2Code {
        DEFR = 1
        REGU = 2
        STEX = 3
    }
    class ISO20022.Sese032001.Reporting6Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.Reporting6Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.RepurchaseType10Code {
        WTHD = 1
        TOPU = 2
        CADJ = 3
        CALL = 4
        RATE = 5
        ROLP = 6
        PAIR = 7
    }
    class ISO20022.Sese032001.RepurchaseType23Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.RepurchaseType23Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.Restriction5Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.Restriction5Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.SafeKeepingPlace5 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Sese032001.SafekeepingPlaceFormat41Choice
    }
    ISO20022.Sese032001.SafeKeepingPlace5 *-- ISO20022.Sese032001.SafekeepingPlaceFormat41Choice
    class ISO20022.Sese032001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Sese032001.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Sese032001.SafekeepingPlaceFormat41Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification78
        + TpAndId  : ISO20022.Sese032001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Sese032001.SafekeepingPlaceTypeAndText8
    }
    ISO20022.Sese032001.SafekeepingPlaceFormat41Choice *-- ISO20022.Sese032001.GenericIdentification78
    ISO20022.Sese032001.SafekeepingPlaceFormat41Choice *-- ISO20022.Sese032001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Sese032001.SafekeepingPlaceFormat41Choice *-- ISO20022.Sese032001.SafekeepingPlaceTypeAndText8
    class ISO20022.Sese032001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese032001.SafekeepingPlaceTypeAndText8 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese032001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Sese032001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese032001.SecuritiesAccount19 *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.SecuritiesCertificate4 {
        + SchmeNm  : String
        + Issr  : String
        + Nb  : String
    }
    class ISO20022.Sese032001.SecuritiesPaymentStatus1Code {
        PART = 1
        NILL = 2
        FULL = 3
    }
    class ISO20022.Sese032001.SecuritiesPaymentStatus5Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.SecuritiesPaymentStatus5Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.SecuritiesRTGS4Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese032001.SecuritiesRTGS4Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese032001.SupplementaryData1~
        + StsAndRsn  : ISO20022.Sese032001.StatusAndReason48
        + GnrtdRsn  : global::System.Collections.Generic.List~ISO20022.Sese032001.GeneratedReason5~
        + AddtlPhysOrRegnDtls  : ISO20022.Sese032001.RegistrationParameters6
        + OthrBizPties  : ISO20022.Sese032001.OtherParties43
        + DgtlNtwkFee  : ISO20022.Sese032001.NetworkFee1
        + OthrAmts  : ISO20022.Sese032001.OtherAmounts45
        + SttlmAmt  : ISO20022.Sese032001.AmountAndDirection94
        + CshPties  : ISO20022.Sese032001.CashParties41
        + RcvgSttlmPties  : ISO20022.Sese032001.SettlementParties126
        + DlvrgSttlmPties  : ISO20022.Sese032001.SettlementParties126
        + SttlmParams  : ISO20022.Sese032001.SettlementDetails217
        + QtyAndAcctDtls  : global::System.Collections.Generic.List~ISO20022.Sese032001.QuantityAndAccount117~
        + FinInstrmAttrbts  : ISO20022.Sese032001.FinancialInstrumentAttributes111
        + FinInstrmId  : ISO20022.Sese032001.SecurityIdentification19
        + TradDtls  : ISO20022.Sese032001.SecuritiesTradeDetails145
        + Lnkgs  : global::System.Collections.Generic.List~ISO20022.Sese032001.Linkages61~
        + NbCounts  : ISO20022.Sese032001.NumberCount2Choice
        + TxIdDtls  : ISO20022.Sese032001.SettlementTypeAndIdentification29
    }
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.SupplementaryData1
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.StatusAndReason48
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.GeneratedReason5
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.RegistrationParameters6
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.OtherParties43
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.NetworkFee1
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.OtherAmounts45
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.AmountAndDirection94
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.CashParties41
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.SettlementParties126
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.SettlementParties126
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.SettlementDetails217
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.QuantityAndAccount117
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.FinancialInstrumentAttributes111
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.SecurityIdentification19
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.SecuritiesTradeDetails145
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.Linkages61
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.NumberCount2Choice
    ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12 *-- ISO20022.Sese032001.SettlementTypeAndIdentification29
    class ISO20022.Sese032001.SecuritiesTradeDetails145 {
        + SttlmInstrPrcgAddtlDtls  : String
        + FxAddtlDtls  : String
        + AffirmSts  : ISO20022.Sese032001.AffirmationStatus8Choice
        + MtchgSts  : ISO20022.Sese032001.MatchingStatus27Choice
        + CcyToBuyOrSell  : ISO20022.Sese032001.CurrencyToBuyOrSell1Choice
        + TpOfPric  : ISO20022.Sese032001.TypeOfPrice29Choice
        + TradOrgtrRole  : ISO20022.Sese032001.TradeOriginator3Choice
        + InvstrCpcty  : ISO20022.Sese032001.InvestorCapacity4Choice
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Sese032001.TradeTransactionCondition5Choice~
        + Rptg  : global::System.Collections.Generic.List~ISO20022.Sese032001.Reporting6Choice~
        + OpngClsg  : ISO20022.Sese032001.OpeningClosing3Choice
        + NbOfDaysAcrd  : Decimal
        + DealPric  : ISO20022.Sese032001.Price10
        + MtchdStsTmStmp  : DateTime
        + AckdStsTmStmp  : DateTime
        + LateDlvryDt  : ISO20022.Sese032001.DateAndDateTime2Choice
        + SttlmDt  : ISO20022.Sese032001.SettlementDate17Choice
        + TradDt  : ISO20022.Sese032001.TradeDate8Choice
        + PlcOfClr  : ISO20022.Sese032001.PlaceOfClearingIdentification2
        + PlcOfTrad  : ISO20022.Sese032001.PlaceOfTradeIdentification1
        + CollTxId  : global::System.Collections.Generic.List~String~
        + UnqTxIdr  : String
        + TradId  : String
    }
    ISO20022.Sese032001.SecuritiesTradeDetails145 *-- ISO20022.Sese032001.AffirmationStatus8Choice
    ISO20022.Sese032001.SecuritiesTradeDetails145 *-- ISO20022.Sese032001.MatchingStatus27Choice
    ISO20022.Sese032001.SecuritiesTradeDetails145 *-- ISO20022.Sese032001.CurrencyToBuyOrSell1Choice
    ISO20022.Sese032001.SecuritiesTradeDetails145 *-- ISO20022.Sese032001.TypeOfPrice29Choice
    ISO20022.Sese032001.SecuritiesTradeDetails145 *-- ISO20022.Sese032001.TradeOriginator3Choice
    ISO20022.Sese032001.SecuritiesTradeDetails145 *-- ISO20022.Sese032001.InvestorCapacity4Choice
    ISO20022.Sese032001.SecuritiesTradeDetails145 *-- ISO20022.Sese032001.TradeTransactionCondition5Choice
    ISO20022.Sese032001.SecuritiesTradeDetails145 *-- ISO20022.Sese032001.Reporting6Choice
    ISO20022.Sese032001.SecuritiesTradeDetails145 *-- ISO20022.Sese032001.OpeningClosing3Choice
    ISO20022.Sese032001.SecuritiesTradeDetails145 *-- ISO20022.Sese032001.Price10
    ISO20022.Sese032001.SecuritiesTradeDetails145 *-- ISO20022.Sese032001.DateAndDateTime2Choice
    ISO20022.Sese032001.SecuritiesTradeDetails145 *-- ISO20022.Sese032001.SettlementDate17Choice
    ISO20022.Sese032001.SecuritiesTradeDetails145 *-- ISO20022.Sese032001.TradeDate8Choice
    ISO20022.Sese032001.SecuritiesTradeDetails145 *-- ISO20022.Sese032001.PlaceOfClearingIdentification2
    ISO20022.Sese032001.SecuritiesTradeDetails145 *-- ISO20022.Sese032001.PlaceOfTradeIdentification1
    class ISO20022.Sese032001.SecuritiesTransactionType26Code {
        REBL = 1
        REDI = 2
        SBBK = 3
        INSP = 4
        SLRE = 5
        ISSU = 6
        ETFT = 7
        CONV = 8
        SWIT = 9
        SWIF = 10
        AUTO = 11
        CLAI = 12
        CORP = 13
        SBRE = 14
        RELE = 15
        OWNI = 16
        FCTA = 17
        OWNE = 18
        CNCB = 19
        BYIY = 20
        TURN = 21
        TRVO = 22
        TRPO = 23
        TRAD = 24
        TBAC = 25
        SYND = 26
        SUBS = 27
        SECL = 28
        SECB = 29
        RVPO = 30
        RODE = 31
        REPU = 32
        REDM = 33
        REAL = 34
        PORT = 35
        PLAC = 36
        PAIR = 37
        NSYN = 38
        NETT = 39
        MKUP = 40
        MKDW = 41
        COLO = 42
        COLI = 43
        BSBK = 44
    }
    class ISO20022.Sese032001.SecuritiesTransactionType44Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.SecuritiesTransactionType44Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese032001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Sese032001.SecurityIdentification19 *-- ISO20022.Sese032001.OtherIdentification1
    class ISO20022.Sese032001.SettlementDate17Choice {
        + DtCd  : ISO20022.Sese032001.SettlementDateCode7Choice
        + Dt  : ISO20022.Sese032001.DateAndDateTime2Choice
    }
    ISO20022.Sese032001.SettlementDate17Choice *-- ISO20022.Sese032001.SettlementDateCode7Choice
    ISO20022.Sese032001.SettlementDate17Choice *-- ISO20022.Sese032001.DateAndDateTime2Choice
    class ISO20022.Sese032001.SettlementDate4Code {
        WISS = 1
    }
    class ISO20022.Sese032001.SettlementDateCode7Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.SettlementDateCode7Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.SettlementDetails217 {
        + CshSubBalTp  : ISO20022.Sese032001.GenericIdentification30
        + SctiesSubBalTp  : ISO20022.Sese032001.GenericIdentification30
        + ElgblForColl  : String
        + ModCxlAllwd  : ISO20022.Sese032001.ModificationCancellationAllowed4Choice
        + RtrLeg  : String
        + LttrOfGrnt  : ISO20022.Sese032001.LetterOfGuarantee4Choice
        + AutomtcBrrwg  : ISO20022.Sese032001.AutomaticBorrowing6Choice
        + Trckg  : ISO20022.Sese032001.Tracking4Choice
        + StmpDtyTaxBsis  : ISO20022.Sese032001.GenericIdentification30
        + TaxCpcty  : ISO20022.Sese032001.TaxCapacityParty4Choice
        + SttlmSysMtd  : ISO20022.Sese032001.SettlementSystemMethod4Choice
        + SttlgCpcty  : ISO20022.Sese032001.SettlingCapacity7Choice
        + SctiesRTGS  : ISO20022.Sese032001.SecuritiesRTGS4Choice
        + LglRstrctns  : ISO20022.Sese032001.Restriction5Choice
        + RpTp  : ISO20022.Sese032001.RepurchaseType23Choice
        + Regn  : ISO20022.Sese032001.Registration9Choice
        + NetgElgblty  : ISO20022.Sese032001.NettingEligibility4Choice
        + MktClntSd  : ISO20022.Sese032001.MarketClientSide6Choice
        + FxStgInstr  : ISO20022.Sese032001.FXStandingInstruction4Choice
        + XpsrTp  : ISO20022.Sese032001.ExposureType25Choice
        + CshClrSys  : ISO20022.Sese032001.CashSettlementSystem4Choice
        + DlvryRtrRsn  : ISO20022.Sese032001.DeliveryReturn3Choice
        + CCPElgblty  : ISO20022.Sese032001.CentralCounterPartyEligibility4Choice
        + BlckTrad  : ISO20022.Sese032001.BlockTrade4Choice
        + BnfclOwnrsh  : ISO20022.Sese032001.BeneficialOwnership4Choice
        + PrtlSttlmInd  : String
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese032001.SettlementTransactionCondition20Choice~
        + SctiesTxTp  : ISO20022.Sese032001.SecuritiesTransactionType44Choice
        + Prty  : ISO20022.Sese032001.PriorityNumeric4Choice
        + HldInd  : ISO20022.Sese032001.HoldIndicator6
    }
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.GenericIdentification30
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.GenericIdentification30
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.ModificationCancellationAllowed4Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.LetterOfGuarantee4Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.AutomaticBorrowing6Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.Tracking4Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.GenericIdentification30
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.TaxCapacityParty4Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.SettlementSystemMethod4Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.SettlingCapacity7Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.SecuritiesRTGS4Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.Restriction5Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.RepurchaseType23Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.Registration9Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.NettingEligibility4Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.MarketClientSide6Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.FXStandingInstruction4Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.ExposureType25Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.CashSettlementSystem4Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.DeliveryReturn3Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.CentralCounterPartyEligibility4Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.BlockTrade4Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.BeneficialOwnership4Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.SettlementTransactionCondition20Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.SecuritiesTransactionType44Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.PriorityNumeric4Choice
    ISO20022.Sese032001.SettlementDetails217 *-- ISO20022.Sese032001.HoldIndicator6
    class ISO20022.Sese032001.SettlementParties126 {
        + Pty5  : ISO20022.Sese032001.PartyIdentificationAndAccount196
        + Pty4  : ISO20022.Sese032001.PartyIdentificationAndAccount196
        + Pty3  : ISO20022.Sese032001.PartyIdentificationAndAccount196
        + Pty2  : ISO20022.Sese032001.PartyIdentificationAndAccount196
        + Pty1  : ISO20022.Sese032001.PartyIdentificationAndAccount196
        + Dpstry  : ISO20022.Sese032001.PartyIdentification315
    }
    ISO20022.Sese032001.SettlementParties126 *-- ISO20022.Sese032001.PartyIdentificationAndAccount196
    ISO20022.Sese032001.SettlementParties126 *-- ISO20022.Sese032001.PartyIdentificationAndAccount196
    ISO20022.Sese032001.SettlementParties126 *-- ISO20022.Sese032001.PartyIdentificationAndAccount196
    ISO20022.Sese032001.SettlementParties126 *-- ISO20022.Sese032001.PartyIdentificationAndAccount196
    ISO20022.Sese032001.SettlementParties126 *-- ISO20022.Sese032001.PartyIdentificationAndAccount196
    ISO20022.Sese032001.SettlementParties126 *-- ISO20022.Sese032001.PartyIdentification315
    class ISO20022.Sese032001.SettlementStatus32Choice {
        + Prtry  : ISO20022.Sese032001.ProprietaryStatusAndReason6
        + Flng  : ISO20022.Sese032001.FailingStatus15Choice
        + Pdg  : ISO20022.Sese032001.PendingStatus73Choice
    }
    ISO20022.Sese032001.SettlementStatus32Choice *-- ISO20022.Sese032001.ProprietaryStatusAndReason6
    ISO20022.Sese032001.SettlementStatus32Choice *-- ISO20022.Sese032001.FailingStatus15Choice
    ISO20022.Sese032001.SettlementStatus32Choice *-- ISO20022.Sese032001.PendingStatus73Choice
    class ISO20022.Sese032001.SettlementSystemMethod1Code {
        YSET = 1
        NSET = 2
    }
    class ISO20022.Sese032001.SettlementSystemMethod4Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.SettlementSystemMethod4Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.SettlementTransactionCondition20Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.SettlementTransactionCondition20Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.SettlementTransactionCondition5Code {
        PARQ = 1
        PARC = 2
        NPAR = 3
        PART = 4
    }
    class ISO20022.Sese032001.SettlementTransactionCondition8Code {
        RPTO = 1
        ADEA = 2
        RHYP = 3
        TRAN = 4
        NOMC = 5
        TRIP = 6
        UNEX = 7
        PENS = 8
        EXPI = 9
        SPST = 10
        SPDL = 11
        SHOR = 12
        RESI = 13
        PHYS = 14
        KNOC = 15
        FRCL = 16
        EXER = 17
        DRAW = 18
        DLWM = 19
        DIRT = 20
        CLEN = 21
        BUTC = 22
        ASGN = 23
    }
    class ISO20022.Sese032001.SettlementTypeAndIdentification29 {
        + NonceId  : String
        + CorpActnEvtId  : String
        + PoolId  : String
        + CmonId  : String
        + Pmt  : String
        + SctiesMvmntTp  : String
        + PrcrTxId  : String
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    class ISO20022.Sese032001.SettlingCapacity2Code {
        RISP = 1
        SPRI = 2
        CUST = 3
        SAGE = 4
    }
    class ISO20022.Sese032001.SettlingCapacity7Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.SettlingCapacity7Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.StatusAndReason48 {
        + SttlmSts  : ISO20022.Sese032001.SettlementStatus32Choice
        + MtchgSts  : ISO20022.Sese032001.MatchingStatus24Choice
        + IfrrdMtchgSts  : ISO20022.Sese032001.MatchingStatus24Choice
        + PrcgSts  : ISO20022.Sese032001.ProcessingStatus52Choice
    }
    ISO20022.Sese032001.StatusAndReason48 *-- ISO20022.Sese032001.SettlementStatus32Choice
    ISO20022.Sese032001.StatusAndReason48 *-- ISO20022.Sese032001.MatchingStatus24Choice
    ISO20022.Sese032001.StatusAndReason48 *-- ISO20022.Sese032001.MatchingStatus24Choice
    ISO20022.Sese032001.StatusAndReason48 *-- ISO20022.Sese032001.ProcessingStatus52Choice
    class ISO20022.Sese032001.SupplementaryData1 {
        + Envlp  : ISO20022.Sese032001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese032001.SupplementaryData1 *-- ISO20022.Sese032001.SupplementaryDataEnvelope1
    class ISO20022.Sese032001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese032001.TaxCapacityParty4Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.TaxCapacityParty4Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.TaxLiability1Code {
        AGEN = 1
        PRIN = 2
    }
    class ISO20022.Sese032001.TotalNumber2 {
        + TtlOfLkdInstrs  : String
        + CurInstrNb  : String
    }
    class ISO20022.Sese032001.Tracking4Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese032001.Tracking4Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.TradeDate8Choice {
        + DtCd  : ISO20022.Sese032001.TradeDateCode3Choice
        + Dt  : ISO20022.Sese032001.DateAndDateTime2Choice
    }
    ISO20022.Sese032001.TradeDate8Choice *-- ISO20022.Sese032001.TradeDateCode3Choice
    ISO20022.Sese032001.TradeDate8Choice *-- ISO20022.Sese032001.DateAndDateTime2Choice
    class ISO20022.Sese032001.TradeDateCode3Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.TradeDateCode3Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.TradeOriginator3Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.TradeOriginator3Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.TradeTransactionCondition4Code {
        BCPD = 1
        NMPR = 2
        NEGO = 3
        MAPR = 4
        BCBN = 5
        BCBL = 6
        BCFD = 7
        BCRP = 8
        BCRO = 9
        GTDL = 10
        SPEX = 11
        SPCU = 12
        XWAR = 13
        CWAR = 14
        XRTS = 15
        CRTS = 16
        XDIV = 17
        CDIV = 18
        XCPN = 19
        CCPN = 20
        XBNS = 21
        CBNS = 22
    }
    class ISO20022.Sese032001.TradeTransactionCondition5Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.TradeTransactionCondition5Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Sese032001.TypeOfPrice14Code {
        AVER = 1
    }
    class ISO20022.Sese032001.TypeOfPrice29Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.TypeOfPrice29Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.UnmatchedReason11Code {
        UNBR = 1
        DELN = 2
        DTRD = 3
        TXST = 4
        SETR = 5
        SETS = 6
        DDAT = 7
        DMON = 8
        SAFE = 9
        RTGS = 10
        REGD = 11
        IEXE = 12
        ICUS = 13
        ICAG = 14
        DEPT = 15
        PODU = 16
        PLCE = 17
        INPS = 18
        PLIS = 19
        PHYS = 20
        FRAP = 21
        OTHR = 22
        DTRA = 23
        NMAS = 24
        CMIS = 25
        MIME = 26
        LATE = 27
        LEOG = 28
        INVE = 29
        DQUA = 30
        DSEC = 31
        DCMX = 32
        DMCT = 33
        DDEA = 34
        NCRR = 35
        CLAT = 36
        CPCA = 37
        IIND = 38
        ACRU = 39
        ADEA = 40
    }
    class ISO20022.Sese032001.UnmatchedReason15 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032001.UnmatchedReason21Choice
    }
    ISO20022.Sese032001.UnmatchedReason15 *-- ISO20022.Sese032001.UnmatchedReason21Choice
    class ISO20022.Sese032001.UnmatchedReason21Choice {
        + Prtry  : ISO20022.Sese032001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese032001.UnmatchedReason21Choice *-- ISO20022.Sese032001.GenericIdentification30
    class ISO20022.Sese032001.UnmatchedStatus16Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032001.UnmatchedReason15~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese032001.UnmatchedStatus16Choice *-- ISO20022.Sese032001.UnmatchedReason15
    class ISO20022.Sese032001.YieldedOrValueType1Choice {
        + ValTp  : String
        + Yldd  : String
    }
    class ISO20022.Sese032001.YieldedOrValueType2Choice {
        + ValTp  : String
        + Yldd  : String
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

## Value ISO20022.Sese032001.AcknowledgedAcceptedStatus21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032001.AcknowledgementReason9>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese032001.AcknowledgementReason12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.AcknowledgementReason5Code


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

## Value ISO20022.Sese032001.AcknowledgementReason9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032001.AcknowledgementReason12Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese032001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese032001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese032001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese032001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Enum ISO20022.Sese032001.AffirmationStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NAFI|Int32||XmlEnum("""NAFI""")|1|
||AFFI|Int32||XmlEnum("""AFFI""")|2|

---

## Value ISO20022.Sese032001.AffirmationStatus8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.AlternatePartyIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Sese032001.IdentificationType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Sese032001.AmountAndDirection44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Sese032001.ForeignExchangeTerms23||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese032001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese032001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese032001.AmountAndDirection94


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValDt|ISO20022.Sese032001.DateAndDateTime2Choice||XmlElement()||
|+|FXDtls|ISO20022.Sese032001.ForeignExchangeTerms23||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese032001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese032001.ActiveCurrencyAndAmount||XmlElement()||
|+|RsrchFeeInd|String||XmlElement()||
|+|BrkrgAmtInd|String||XmlElement()||
|+|StmpDtyInd|String||XmlElement()||
|+|AcrdIntrstInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValDt),validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Enum ISO20022.Sese032001.AutoBorrowing1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YBOR|Int32||XmlEnum("""YBOR""")|1|
||NBOR|Int32||XmlEnum("""NBOR""")|2|
||LAMI|Int32||XmlEnum("""LAMI""")|3|

---

## Value ISO20022.Sese032001.AutomaticBorrowing6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.BeneficialOwnership4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese032001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Sese032001.BlockTrade1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BLCH|Int32||XmlEnum("""BLCH""")|1|
||BLPA|Int32||XmlEnum("""BLPA""")|2|

---

## Value ISO20022.Sese032001.BlockTrade4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.CashAccountIdentification5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Value ISO20022.Sese032001.CashAccountIdentification9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|BlckChainCshWllt|ISO20022.Sese032001.BlockChainAddressWallet3||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainCshWllt),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,BlckChainCshWllt,IBAN))|

---

## Value ISO20022.Sese032001.CashParties41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Intrmy|ISO20022.Sese032001.PartyIdentificationAndAccount224||XmlElement()||
|+|CdtrAgt|ISO20022.Sese032001.PartyIdentificationAndAccount224||XmlElement()||
|+|Cdtr|ISO20022.Sese032001.PartyIdentificationAndAccount223||XmlElement()||
|+|DbtrAgt|ISO20022.Sese032001.PartyIdentificationAndAccount224||XmlElement()||
|+|Dbtr|ISO20022.Sese032001.PartyIdentificationAndAccount223||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Intrmy),validElement(CdtrAgt),validElement(Cdtr),validElement(DbtrAgt),validElement(Dbtr))|

---

## Enum ISO20022.Sese032001.CashSettlementSystem2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETS|Int32||XmlEnum("""NETS""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Value ISO20022.Sese032001.CashSettlementSystem4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.CentralCounterPartyEligibility4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese032001.ClassificationType32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Sese032001.GenericIdentification36||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Enum ISO20022.Sese032001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese032001.CurrencyToBuyOrSell1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyToSell|String||XmlElement()||
|+|CcyToBuy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CcyToSell""",CcyToSell,"""[A-Z]{3,3}"""),validPattern("""CcyToBuy""",CcyToBuy,"""[A-Z]{3,3}"""),validChoice(CcyToSell,CcyToBuy))|

---

## Value ISO20022.Sese032001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Sese032001.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese032001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Enum ISO20022.Sese032001.DeliveryReturn1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARD|Int32||XmlEnum("""PARD""")|1|
||DUEB|Int32||XmlEnum("""DUEB""")|2|
||SAFE|Int32||XmlEnum("""SAFE""")|3|
||PART|Int32||XmlEnum("""PART""")|4|
||DMON|Int32||XmlEnum("""DMON""")|5|
||DQUA|Int32||XmlEnum("""DQUA""")|6|
||UNRE|Int32||XmlEnum("""UNRE""")|7|

---

## Value ISO20022.Sese032001.DeliveryReturn3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Type ISO20022.Sese032001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmTxGnrtnNtfctn|ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmTxGnrtnNtfctn))|

---

## Value ISO20022.Sese032001.DocumentNumber5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Sese032001.GenericIdentification36||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Enum ISO20022.Sese032001.Eligibility1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROF|Int32||XmlEnum("""PROF""")|1|
||RETL|Int32||XmlEnum("""RETL""")|2|
||ELIG|Int32||XmlEnum("""ELIG""")|3|

---

## Enum ISO20022.Sese032001.EventFrequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||SEMI|Int32||XmlEnum("""SEMI""")|2|
||QUTR|Int32||XmlEnum("""QUTR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|

---

## Enum ISO20022.Sese032001.ExposureType15Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CBCO|Int32||XmlEnum("""CBCO""")|1|
||TRCP|Int32||XmlEnum("""TRCP""")|2|
||UDMS|Int32||XmlEnum("""UDMS""")|3|
||TBAS|Int32||XmlEnum("""TBAS""")|4|
||SWPT|Int32||XmlEnum("""SWPT""")|5|
||SCIE|Int32||XmlEnum("""SCIE""")|6|
||SCIR|Int32||XmlEnum("""SCIR""")|7|
||SHSL|Int32||XmlEnum("""SHSL""")|8|
||SLEB|Int32||XmlEnum("""SLEB""")|9|
||SCRP|Int32||XmlEnum("""SCRP""")|10|
||SBSC|Int32||XmlEnum("""SBSC""")|11|
||SLOA|Int32||XmlEnum("""SLOA""")|12|
||RVPO|Int32||XmlEnum("""RVPO""")|13|
||REPO|Int32||XmlEnum("""REPO""")|14|
||OTCD|Int32||XmlEnum("""OTCD""")|15|
||LIQU|Int32||XmlEnum("""LIQU""")|16|
||OPTN|Int32||XmlEnum("""OPTN""")|17|
||FUTR|Int32||XmlEnum("""FUTR""")|18|
||FORW|Int32||XmlEnum("""FORW""")|19|
||FORX|Int32||XmlEnum("""FORX""")|20|
||FIXI|Int32||XmlEnum("""FIXI""")|21|
||EXPT|Int32||XmlEnum("""EXPT""")|22|
||EQUS|Int32||XmlEnum("""EQUS""")|23|
||EXTD|Int32||XmlEnum("""EXTD""")|24|
||EQPT|Int32||XmlEnum("""EQPT""")|25|
||CRPR|Int32||XmlEnum("""CRPR""")|26|
||CCIR|Int32||XmlEnum("""CCIR""")|27|
||CRSP|Int32||XmlEnum("""CRSP""")|28|
||CRTL|Int32||XmlEnum("""CRTL""")|29|
||CRDS|Int32||XmlEnum("""CRDS""")|30|
||COMM|Int32||XmlEnum("""COMM""")|31|
||CCPC|Int32||XmlEnum("""CCPC""")|32|
||PAYM|Int32||XmlEnum("""PAYM""")|33|
||BFWD|Int32||XmlEnum("""BFWD""")|34|

---

## Value ISO20022.Sese032001.ExposureType25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.FXStandingInstruction4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese032001.FailingReason13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032001.FailingReason18Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese032001.FailingReason18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.FailingReason5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREL|Int32||XmlEnum("""PREL""")|1|
||PATD|Int32||XmlEnum("""PATD""")|2|
||INBC|Int32||XmlEnum("""INBC""")|3|
||CVAL|Int32||XmlEnum("""CVAL""")|4|
||CSDH|Int32||XmlEnum("""CSDH""")|5|
||CDLR|Int32||XmlEnum("""CDLR""")|6|
||PRSY|Int32||XmlEnum("""PRSY""")|7|
||CERT|Int32||XmlEnum("""CERT""")|8|
||SETS|Int32||XmlEnum("""SETS""")|9|
||REGT|Int32||XmlEnum("""REGT""")|10|
||PRCY|Int32||XmlEnum("""PRCY""")|11|
||LIQU|Int32||XmlEnum("""LIQU""")|12|
||LATE|Int32||XmlEnum("""LATE""")|13|
||LAAW|Int32||XmlEnum("""LAAW""")|14|
||FROZ|Int32||XmlEnum("""FROZ""")|15|
||DKNY|Int32||XmlEnum("""DKNY""")|16|
||DISA|Int32||XmlEnum("""DISA""")|17|
||DENO|Int32||XmlEnum("""DENO""")|18|
||CLHT|Int32||XmlEnum("""CLHT""")|19|
||BOTH|Int32||XmlEnum("""BOTH""")|20|
||BENO|Int32||XmlEnum("""BENO""")|21|
||PHCK|Int32||XmlEnum("""PHCK""")|22|
||OTHR|Int32||XmlEnum("""OTHR""")|23|
||IAAD|Int32||XmlEnum("""IAAD""")|24|
||MINO|Int32||XmlEnum("""MINO""")|25|
||CPEC|Int32||XmlEnum("""CPEC""")|26|
||SBLO|Int32||XmlEnum("""SBLO""")|27|
||CYCL|Int32||XmlEnum("""CYCL""")|28|
||BATC|Int32||XmlEnum("""BATC""")|29|
||SDUT|Int32||XmlEnum("""SDUT""")|30|
||REFS|Int32||XmlEnum("""REFS""")|31|
||NCON|Int32||XmlEnum("""NCON""")|32|
||MONY|Int32||XmlEnum("""MONY""")|33|
||LALO|Int32||XmlEnum("""LALO""")|34|
||LACK|Int32||XmlEnum("""LACK""")|35|
||LINK|Int32||XmlEnum("""LINK""")|36|
||INCA|Int32||XmlEnum("""INCA""")|37|
||FLIM|Int32||XmlEnum("""FLIM""")|38|
||DEPO|Int32||XmlEnum("""DEPO""")|39|
||COLL|Int32||XmlEnum("""COLL""")|40|
||YCOL|Int32||XmlEnum("""YCOL""")|41|
||CMON|Int32||XmlEnum("""CMON""")|42|
||NOFX|Int32||XmlEnum("""NOFX""")|43|
||PART|Int32||XmlEnum("""PART""")|44|
||PREA|Int32||XmlEnum("""PREA""")|45|
||GLOB|Int32||XmlEnum("""GLOB""")|46|
||MUNO|Int32||XmlEnum("""MUNO""")|47|
||CLAC|Int32||XmlEnum("""CLAC""")|48|
||NEWI|Int32||XmlEnum("""NEWI""")|49|
||CHAS|Int32||XmlEnum("""CHAS""")|50|
||BLOC|Int32||XmlEnum("""BLOC""")|51|
||DOCC|Int32||XmlEnum("""DOCC""")|52|
||MLAT|Int32||XmlEnum("""MLAT""")|53|
||DOCY|Int32||XmlEnum("""DOCY""")|54|
||STCD|Int32||XmlEnum("""STCD""")|55|
||PHSE|Int32||XmlEnum("""PHSE""")|56|
||AWSH|Int32||XmlEnum("""AWSH""")|57|
||OBJT|Int32||XmlEnum("""OBJT""")|58|
||CAIS|Int32||XmlEnum("""CAIS""")|59|
||CANR|Int32||XmlEnum("""CANR""")|60|
||ADEA|Int32||XmlEnum("""ADEA""")|61|
||CLAT|Int32||XmlEnum("""CLAT""")|62|
||BYIY|Int32||XmlEnum("""BYIY""")|63|
||AWMO|Int32||XmlEnum("""AWMO""")|64|

---

## Value ISO20022.Sese032001.FailingStatus15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032001.FailingReason13>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese032001.FinancialInstrumentAttributes111


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmAttrAddtlDtls|String||XmlElement()||
|+|UndrlygFinInstrmId|global::System.Collections.Generic.List<ISO20022.Sese032001.SecurityIdentification19>||XmlElement()||
|+|CtrctSz|ISO20022.Sese032001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Sese032001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|StrkPric|ISO20022.Sese032001.Price7||XmlElement()||
|+|ConvsPric|ISO20022.Sese032001.Price7||XmlElement()||
|+|SbcptPric|ISO20022.Sese032001.Price7||XmlElement()||
|+|ExrcPric|ISO20022.Sese032001.Price7||XmlElement()||
|+|MktOrIndctvPric|ISO20022.Sese032001.PriceType4Choice||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|PoolNb|ISO20022.Sese032001.GenericIdentification37||XmlElement()||
|+|CpnAttchdNb|ISO20022.Sese032001.Number22Choice||XmlElement()||
|+|IndxRateBsis|Decimal||XmlElement()||
|+|NxtIntrstRate|Decimal||XmlElement()||
|+|YldToMtrtyRate|Decimal||XmlElement()||
|+|IntrstRate|Decimal||XmlElement()||
|+|NxtFctr|Decimal||XmlElement()||
|+|CurFctr|Decimal||XmlElement()||
|+|PrvsFctr|Decimal||XmlElement()||
|+|FrstPmtDt|DateTime||XmlElement()||
|+|DtdDt|DateTime||XmlElement()||
|+|PutblDt|DateTime||XmlElement()||
|+|NxtCllblDt|DateTime||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|FltgRateFxgDt|DateTime||XmlElement()||
|+|XpryDt|DateTime||XmlElement()||
|+|CpnDt|DateTime||XmlElement()||
|+|DnmtnCcy|String||XmlElement()||
|+|OptnTp|ISO20022.Sese032001.OptionType6Choice||XmlElement()||
|+|OptnStyle|ISO20022.Sese032001.OptionStyle8Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Sese032001.ClassificationType32Choice||XmlElement()||
|+|VarblRateChngFrqcy|ISO20022.Sese032001.Frequency23Choice||XmlElement()||
|+|PmtSts|ISO20022.Sese032001.SecuritiesPaymentStatus5Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Sese032001.Frequency23Choice||XmlElement()||
|+|RegnForm|ISO20022.Sese032001.FormOfSecurity6Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Sese032001.InterestComputationMethodFormat4Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Sese032001.MarketIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""UndrlygFinInstrmId""",UndrlygFinInstrmId),validElement(UndrlygFinInstrmId),validElement(CtrctSz),validElement(MinNmnlQty),validElement(StrkPric),validElement(ConvsPric),validElement(SbcptPric),validElement(ExrcPric),validElement(MktOrIndctvPric),validElement(PoolNb),validElement(CpnAttchdNb),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnTp),validElement(OptnStyle),validElement(ClssfctnTp),validElement(VarblRateChngFrqcy),validElement(PmtSts),validElement(PmtFrqcy),validElement(RegnForm),validElement(DayCntBsis),validElement(PlcOfListg))|

---

## Value ISO20022.Sese032001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese032001.ForeignExchangeTerms23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Sese032001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese032001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Sese032001.FormOfSecurity6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.Frequency23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.GeneratedReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAN|Int32||XmlEnum("""TRAN""")|1|
||THRD|Int32||XmlEnum("""THRD""")|2|
||SPLI|Int32||XmlEnum("""SPLI""")|3|
||RODE|Int32||XmlEnum("""RODE""")|4|
||OTHR|Int32||XmlEnum("""OTHR""")|5|
||CLAI|Int32||XmlEnum("""CLAI""")|6|
||COLL|Int32||XmlEnum("""COLL""")|7|

---

## Value ISO20022.Sese032001.GeneratedReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032001.GeneratedReasons5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese032001.GeneratedReasons5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese032001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese032001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese032001.GenericIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese032001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese032001.HoldIndicator6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032001.RegistrationReason5>||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rsn""",Rsn),validElement(Rsn))|

---

## Value ISO20022.Sese032001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.IdentificationType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.InterestComputationMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NARR|Int32||XmlEnum("""NARR""")|1|
||A014|Int32||XmlEnum("""A014""")|2|
||A013|Int32||XmlEnum("""A013""")|3|
||A012|Int32||XmlEnum("""A012""")|4|
||A011|Int32||XmlEnum("""A011""")|5|
||A010|Int32||XmlEnum("""A010""")|6|
||A009|Int32||XmlEnum("""A009""")|7|
||A008|Int32||XmlEnum("""A008""")|8|
||A007|Int32||XmlEnum("""A007""")|9|
||A006|Int32||XmlEnum("""A006""")|10|
||A005|Int32||XmlEnum("""A005""")|11|
||A004|Int32||XmlEnum("""A004""")|12|
||A003|Int32||XmlEnum("""A003""")|13|
||A002|Int32||XmlEnum("""A002""")|14|
||A001|Int32||XmlEnum("""A001""")|15|

---

## Value ISO20022.Sese032001.InterestComputationMethodFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.InvestorCapacity4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.LetterOfGuarantee4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese032001.Linkages61


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefOwnr|ISO20022.Sese032001.PartyIdentification127Choice||XmlElement()||
|+|LkdQty|ISO20022.Sese032001.PairedOrTurnedQuantity5Choice||XmlElement()||
|+|Ref|ISO20022.Sese032001.References73Choice||XmlElement()||
|+|MsgNb|ISO20022.Sese032001.DocumentNumber5Choice||XmlElement()||
|+|PrcgPos|ISO20022.Sese032001.ProcessingPosition7Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefOwnr),validElement(LkdQty),validElement(Ref),validElement(MsgNb),validElement(PrcgPos))|

---

## Enum ISO20022.Sese032001.MarketClientSide1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MAKT|Int32||XmlEnum("""MAKT""")|1|
||CLNT|Int32||XmlEnum("""CLNT""")|2|

---

## Value ISO20022.Sese032001.MarketClientSide6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.MarketIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese032001.MarketIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese032001.MarketIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese032001.MarketType8Choice||XmlElement()||
|+|Id|ISO20022.Sese032001.MarketIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Enum ISO20022.Sese032001.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Value ISO20022.Sese032001.MarketType8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.MatchingStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NMAT|Int32||XmlEnum("""NMAT""")|1|
||MACH|Int32||XmlEnum("""MACH""")|2|

---

## Value ISO20022.Sese032001.MatchingStatus24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.ProprietaryStatusAndReason6||XmlElement()||
|+|Umtchd|ISO20022.Sese032001.UnmatchedStatus16Choice||XmlElement()||
|+|Mtchd|ISO20022.Sese032001.ProprietaryReason4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Umtchd),validElement(Mtchd),validChoice(Prtry,Umtchd,Mtchd))|

---

## Value ISO20022.Sese032001.MatchingStatus27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.ModificationCancellationAllowed4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese032001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Sese032001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Sese032001.NettingEligibility4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese032001.NetworkFee1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtwkFeeQty|Decimal||XmlElement()||
|+|FinInstrmId|ISO20022.Sese032001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmId))|

---

## Enum ISO20022.Sese032001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Sese032001.Number22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|ISO20022.Sese032001.GenericIdentification1||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lng),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Value ISO20022.Sese032001.NumberCount2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlNb|ISO20022.Sese032001.TotalNumber2||XmlElement()||
|+|CurInstrNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlNb),validPattern("""CurInstrNb""",CurInstrNb,"""[0-9]{1,6}"""),validChoice(TtlNb,CurInstrNb))|

---

## Enum ISO20022.Sese032001.OpeningClosing1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEP|Int32||XmlEnum("""OPEP""")|1|
||CLOP|Int32||XmlEnum("""CLOP""")|2|

---

## Value ISO20022.Sese032001.OpeningClosing3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Sese032001.OptionStyle8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Sese032001.OptionType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Sese032001.OriginatorRole2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAGT|Int32||XmlEnum("""TAGT""")|1|
||INVE|Int32||XmlEnum("""INVE""")|2|
||MKTM|Int32||XmlEnum("""MKTM""")|3|
||RMKT|Int32||XmlEnum("""RMKT""")|4|
||MLTF|Int32||XmlEnum("""MLTF""")|5|
||SINT|Int32||XmlEnum("""SINT""")|6|

---

## Value ISO20022.Sese032001.OtherAmounts45


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NtwkFee|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|RsrchFee|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|AcrdCptlstnAmt|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|CsmptnTax|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|NetGnLoss|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|WhldgTax|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|ValAddedTax|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|TxTax|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|TrfTax|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|StockXchgTax|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|StmpDty|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|SpclCncssn|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|ShppgAmt|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|RgltryAmt|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|Othr|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|Mrgn|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|LclBrkrComssn|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|LclTaxCtrySpcfc|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|LclTax|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|PmtLevyTax|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|IsseDscntAllwnc|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|ExctgBrkrAmt|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|TradAmt|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|CtryNtlFdrlTax|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|ChrgsFees|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Sese032001.AmountAndDirection44||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NtwkFee),validElement(RsrchFee),validElement(AcrdCptlstnAmt),validElement(CsmptnTax),validElement(NetGnLoss),validElement(WhldgTax),validElement(ValAddedTax),validElement(TxTax),validElement(TrfTax),validElement(StockXchgTax),validElement(StmpDty),validElement(SpclCncssn),validElement(ShppgAmt),validElement(RgltryAmt),validElement(Othr),validElement(Mrgn),validElement(LclBrkrComssn),validElement(LclTaxCtrySpcfc),validElement(LclTax),validElement(PmtLevyTax),validElement(IsseDscntAllwnc),validElement(ExctgBrkrAmt),validElement(TradAmt),validElement(CtryNtlFdrlTax),validElement(ChrgsFees),validElement(AcrdIntrstAmt))|

---

## Value ISO20022.Sese032001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese032001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese032001.OtherParties43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Brkr|ISO20022.Sese032001.PartyIdentificationAndAccount198||XmlElement()||
|+|TrptyAgt|ISO20022.Sese032001.PartyIdentificationAndAccount198||XmlElement()||
|+|TradRgltr|ISO20022.Sese032001.PartyIdentificationAndAccount165||XmlElement()||
|+|StockXchg|ISO20022.Sese032001.PartyIdentificationAndAccount165||XmlElement()||
|+|QlfdFrgnIntrmy|ISO20022.Sese032001.PartyIdentificationAndAccount198||XmlElement()||
|+|Invstr|global::System.Collections.Generic.List<ISO20022.Sese032001.PartyIdentificationAndAccount197>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Brkr),validElement(TrptyAgt),validElement(TradRgltr),validElement(StockXchg),validElement(QlfdFrgnIntrmy),validList("""Invstr""",Invstr),validElement(Invstr))|

---

## Enum ISO20022.Sese032001.OwnershipLegalRestrictions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSTR|Int32||XmlEnum("""RSTR""")|1|
||NRST|Int32||XmlEnum("""NRST""")|2|
||A144|Int32||XmlEnum("""A144""")|3|

---

## Value ISO20022.Sese032001.PairedOrTurnedQuantity5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrndQty|ISO20022.Sese032001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|PairdOffQty|ISO20022.Sese032001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrndQty),validElement(PairdOffQty),validChoice(TrndQty,PairdOffQty))|

---

## Value ISO20022.Sese032001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese032001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese032001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese032001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese032001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese032001.PartyIdentification133Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese032001.GenericIdentification36||XmlElement()||
|+|NmAndAdr|ISO20022.Sese032001.NameAndAddress5||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validElement(NmAndAdr),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,NmAndAdr,BICFI))|

---

## Value ISO20022.Sese032001.PartyIdentification144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032001.PartyIdentification127Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032001.PartyIdentification257Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese032001.NameAndAddress5||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(DgtlLdgrId,Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese032001.PartyIdentification315


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese032001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese032001.DateAndDateTime2Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese032001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032001.PartyIdentification257Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032001.PartyIdentificationAndAccount165


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese032001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|AltrnId|ISO20022.Sese032001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032001.PartyIdentificationAndAccount196


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese032001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese032001.DateAndDateTime2Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese032001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese032001.SecuritiesAccount19||XmlElement()||
|+|AltrnId|ISO20022.Sese032001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032001.PartyIdentificationAndAccount197


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese032001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|Ntlty|String||XmlElement()||
|+|AltrnId|ISO20022.Sese032001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""Ntlty""",Ntlty,"""[A-Z]{2,2}"""),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032001.PartyIdentificationAndAccount198


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese032001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|AltrnId|ISO20022.Sese032001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032001.PartyIdentificationAndAccount223


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese032001.PartyTextInformation2||XmlElement()||
|+|TaxAcct|ISO20022.Sese032001.CashAccountIdentification5Choice||XmlElement()||
|+|ComssnAcct|ISO20022.Sese032001.CashAccountIdentification5Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Sese032001.CashAccountIdentification5Choice||XmlElement()||
|+|CshAcct|ISO20022.Sese032001.CashAccountIdentification9Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese032001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(TaxAcct),validElement(ComssnAcct),validElement(ChrgsAcct),validElement(CshAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032001.PartyIdentificationAndAccount224


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese032001.PartyTextInformation2||XmlElement()||
|+|TaxAcct|ISO20022.Sese032001.CashAccountIdentification5Choice||XmlElement()||
|+|ComssnAcct|ISO20022.Sese032001.CashAccountIdentification5Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Sese032001.CashAccountIdentification5Choice||XmlElement()||
|+|CshAcct|ISO20022.Sese032001.CashAccountIdentification9Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese032001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032001.PartyIdentification133Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(TaxAcct),validElement(ComssnAcct),validElement(ChrgsAcct),validElement(CshAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032001.PartyTextInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese032001.PartyTextInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese032001.PendingProcessingReason10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.PendingProcessingReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INBC|Int32||XmlEnum("""INBC""")|1|
||CDAC|Int32||XmlEnum("""CDAC""")|2|
||CDLR|Int32||XmlEnum("""CDLR""")|3|
||CDEL|Int32||XmlEnum("""CDEL""")|4|
||CVAL|Int32||XmlEnum("""CVAL""")|5|
||CSDH|Int32||XmlEnum("""CSDH""")|6|
||CERT|Int32||XmlEnum("""CERT""")|7|
||LIQU|Int32||XmlEnum("""LIQU""")|8|
||DENO|Int32||XmlEnum("""DENO""")|9|
||OTHR|Int32||XmlEnum("""OTHR""")|10|
||MINO|Int32||XmlEnum("""MINO""")|11|
||MONY|Int32||XmlEnum("""MONY""")|12|
||LALO|Int32||XmlEnum("""LALO""")|13|
||LACK|Int32||XmlEnum("""LACK""")|14|
||NEXT|Int32||XmlEnum("""NEXT""")|15|
||FLIM|Int32||XmlEnum("""FLIM""")|16|
||COLL|Int32||XmlEnum("""COLL""")|17|
||YCOL|Int32||XmlEnum("""YCOL""")|18|
||GLOB|Int32||XmlEnum("""GLOB""")|19|
||MUNO|Int32||XmlEnum("""MUNO""")|20|
||BLOC|Int32||XmlEnum("""BLOC""")|21|
||NOFX|Int32||XmlEnum("""NOFX""")|22|
||DOCY|Int32||XmlEnum("""DOCY""")|23|
||CAIS|Int32||XmlEnum("""CAIS""")|24|
||ADEA|Int32||XmlEnum("""ADEA""")|25|

---

## Value ISO20022.Sese032001.PendingProcessingReason8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032001.PendingProcessingReason10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese032001.PendingProcessingStatus11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032001.PendingProcessingReason8>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese032001.PendingReason16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032001.PendingReason28Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese032001.PendingReason28Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.PendingReason28Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREL|Int32||XmlEnum("""PREL""")|1|
||PATD|Int32||XmlEnum("""PATD""")|2|
||INBC|Int32||XmlEnum("""INBC""")|3|
||CDLR|Int32||XmlEnum("""CDLR""")|4|
||CVAL|Int32||XmlEnum("""CVAL""")|5|
||CSDH|Int32||XmlEnum("""CSDH""")|6|
||PRSY|Int32||XmlEnum("""PRSY""")|7|
||CERT|Int32||XmlEnum("""CERT""")|8|
||SETS|Int32||XmlEnum("""SETS""")|9|
||REGT|Int32||XmlEnum("""REGT""")|10|
||PRCY|Int32||XmlEnum("""PRCY""")|11|
||LIQU|Int32||XmlEnum("""LIQU""")|12|
||LATE|Int32||XmlEnum("""LATE""")|13|
||LAAW|Int32||XmlEnum("""LAAW""")|14|
||FROZ|Int32||XmlEnum("""FROZ""")|15|
||DKNY|Int32||XmlEnum("""DKNY""")|16|
||DISA|Int32||XmlEnum("""DISA""")|17|
||DENO|Int32||XmlEnum("""DENO""")|18|
||CLHT|Int32||XmlEnum("""CLHT""")|19|
||BOTH|Int32||XmlEnum("""BOTH""")|20|
||BENO|Int32||XmlEnum("""BENO""")|21|
||PHCK|Int32||XmlEnum("""PHCK""")|22|
||OTHR|Int32||XmlEnum("""OTHR""")|23|
||IAAD|Int32||XmlEnum("""IAAD""")|24|
||MINO|Int32||XmlEnum("""MINO""")|25|
||CPEC|Int32||XmlEnum("""CPEC""")|26|
||SBLO|Int32||XmlEnum("""SBLO""")|27|
||CYCL|Int32||XmlEnum("""CYCL""")|28|
||BATC|Int32||XmlEnum("""BATC""")|29|
||SDUT|Int32||XmlEnum("""SDUT""")|30|
||REFS|Int32||XmlEnum("""REFS""")|31|
||NCON|Int32||XmlEnum("""NCON""")|32|
||MONY|Int32||XmlEnum("""MONY""")|33|
||LALO|Int32||XmlEnum("""LALO""")|34|
||LACK|Int32||XmlEnum("""LACK""")|35|
||FUTU|Int32||XmlEnum("""FUTU""")|36|
||LINK|Int32||XmlEnum("""LINK""")|37|
||INCA|Int32||XmlEnum("""INCA""")|38|
||FLIM|Int32||XmlEnum("""FLIM""")|39|
||DEPO|Int32||XmlEnum("""DEPO""")|40|
||COLL|Int32||XmlEnum("""COLL""")|41|
||YCOL|Int32||XmlEnum("""YCOL""")|42|
||CMON|Int32||XmlEnum("""CMON""")|43|
||NOFX|Int32||XmlEnum("""NOFX""")|44|
||NMAS|Int32||XmlEnum("""NMAS""")|45|
||PART|Int32||XmlEnum("""PART""")|46|
||PREA|Int32||XmlEnum("""PREA""")|47|
||GLOB|Int32||XmlEnum("""GLOB""")|48|
||MUNO|Int32||XmlEnum("""MUNO""")|49|
||CLAC|Int32||XmlEnum("""CLAC""")|50|
||NEWI|Int32||XmlEnum("""NEWI""")|51|
||CHAS|Int32||XmlEnum("""CHAS""")|52|
||BLOC|Int32||XmlEnum("""BLOC""")|53|
||DOCC|Int32||XmlEnum("""DOCC""")|54|
||DOCY|Int32||XmlEnum("""DOCY""")|55|
||TAMM|Int32||XmlEnum("""TAMM""")|56|
||PHSE|Int32||XmlEnum("""PHSE""")|57|
||AWSH|Int32||XmlEnum("""AWSH""")|58|
||REFU|Int32||XmlEnum("""REFU""")|59|
||CAIS|Int32||XmlEnum("""CAIS""")|60|
||ADEA|Int32||XmlEnum("""ADEA""")|61|
||AWMO|Int32||XmlEnum("""AWMO""")|62|

---

## Value ISO20022.Sese032001.PendingReason32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032001.PendingReason69Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese032001.PendingReason69Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.PendingReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDRE|Int32||XmlEnum("""CDRE""")|1|
||CDCY|Int32||XmlEnum("""CDCY""")|2|
||CDRG|Int32||XmlEnum("""CDRG""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||CONF|Int32||XmlEnum("""CONF""")|5|
||ADEA|Int32||XmlEnum("""ADEA""")|6|

---

## Value ISO20022.Sese032001.PendingStatus38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032001.PendingReason16>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese032001.PendingStatus73Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032001.PendingReason32>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese032001.PlaceOfClearingIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese032001.PlaceOfTradeIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|MktTpAndId|ISO20022.Sese032001.MarketIdentification84||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(MktTpAndId))|

---

## Value ISO20022.Sese032001.PostalAddress1


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

## Value ISO20022.Sese032001.Price10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Sese032001.PriceRateOrAmount3Choice||XmlElement()||
|+|Tp|ISO20022.Sese032001.YieldedOrValueType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Sese032001.Price7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Sese032001.PriceRateOrAmount3Choice||XmlElement()||
|+|Tp|ISO20022.Sese032001.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Sese032001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese032001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Sese032001.PriceType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indctv|ISO20022.Sese032001.Price7||XmlElement()||
|+|Mkt|ISO20022.Sese032001.Price7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indctv),validElement(Mkt),validChoice(Indctv,Mkt))|

---

## Enum ISO20022.Sese032001.PriceValueType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NEGA|Int32||XmlEnum("""NEGA""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||PARV|Int32||XmlEnum("""PARV""")|3|
||DISC|Int32||XmlEnum("""DISC""")|4|

---

## Enum ISO20022.Sese032001.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Sese032001.PriorityNumeric4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Nmrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""Nmrc""",Nmrc,"""[0-9]{4}"""),validChoice(Prtry,Nmrc))|

---

## Enum ISO20022.Sese032001.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Sese032001.ProcessingPosition7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.ProcessingStatus52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CxlReqd|ISO20022.Sese032001.ProprietaryReason4||XmlElement()||
|+|Prtry|ISO20022.Sese032001.ProprietaryStatusAndReason6||XmlElement()||
|+|PdgCxl|ISO20022.Sese032001.PendingStatus38Choice||XmlElement()||
|+|Rpr|ISO20022.Sese032001.RepairStatus12Choice||XmlElement()||
|+|PdgPrcg|ISO20022.Sese032001.PendingProcessingStatus11Choice||XmlElement()||
|+|AckdAccptd|ISO20022.Sese032001.AcknowledgedAcceptedStatus21Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CxlReqd),validElement(Prtry),validElement(PdgCxl),validElement(Rpr),validElement(PdgPrcg),validElement(AckdAccptd),validChoice(CxlReqd,Prtry,PdgCxl,Rpr,PdgPrcg,AckdAccptd))|

---

## Value ISO20022.Sese032001.ProprietaryReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Sese032001.ProprietaryStatusAndReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Sese032001.ProprietaryReason4>||XmlElement()||
|+|PrtrySts|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Sese032001.Quantity51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Sese032001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Sese032001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Sese032001.QuantityAndAccount117


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Sese032001.QuantityBreakdown62>||XmlElement()||
|+|SfkpgPlc|ISO20022.Sese032001.SafeKeepingPlace5||XmlElement()||
|+|CshAcct|ISO20022.Sese032001.CashAccountIdentification9Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese032001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese032001.SecuritiesAccount19||XmlElement()||
|+|AcctOwnr|ISO20022.Sese032001.PartyIdentification144||XmlElement()||
|+|DnmtnChc|String||XmlElement()||
|+|SttlmQty|ISO20022.Sese032001.Quantity51Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(SfkpgPlc),validElement(CshAcct),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(SttlmQty))|

---

## Value ISO20022.Sese032001.QuantityBreakdown62


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TpOfPric|ISO20022.Sese032001.TypeOfPrice29Choice||XmlElement()||
|+|LotPric|ISO20022.Sese032001.Price7||XmlElement()||
|+|LotDtTm|ISO20022.Sese032001.DateAndDateTime2Choice||XmlElement()||
|+|LotQty|ISO20022.Sese032001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|LotNb|ISO20022.Sese032001.GenericIdentification37||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TpOfPric),validElement(LotPric),validElement(LotDtTm),validElement(LotQty),validElement(LotNb))|

---

## Enum ISO20022.Sese032001.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Sese032001.References73Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrTxId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|CtrPtyMktInfrstrctrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|IntraBalMvmntId|String||XmlElement()||
|+|IntraPosMvmntId|String||XmlElement()||
|+|SctiesSttlmTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OthrTxId,PoolId,CtrPtyMktInfrstrctrTxId,MktInfrstrctrTxId,AcctSvcrTxId,IntraBalMvmntId,IntraPosMvmntId,SctiesSttlmTxId))|

---

## Value ISO20022.Sese032001.Registration10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.Registration1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YREG|Int32||XmlEnum("""YREG""")|1|
||NREG|Int32||XmlEnum("""NREG""")|2|

---

## Enum ISO20022.Sese032001.Registration2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CVAL|Int32||XmlEnum("""CVAL""")|1|
||CDEL|Int32||XmlEnum("""CDEL""")|2|
||CSDH|Int32||XmlEnum("""CSDH""")|3|
||PTYH|Int32||XmlEnum("""PTYH""")|4|

---

## Value ISO20022.Sese032001.Registration9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.RegistrationParameters6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertNb|global::System.Collections.Generic.List<ISO20022.Sese032001.SecuritiesCertificate4>||XmlElement()||
|+|RegarAcct|String||XmlElement()||
|+|CertfctnDtTm|ISO20022.Sese032001.DateAndDateTime2Choice||XmlElement()||
|+|CertfctnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CertNb""",CertNb),validElement(CertNb),validElement(CertfctnDtTm))|

---

## Value ISO20022.Sese032001.RegistrationReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032001.Registration10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese032001.RepairReason10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.RepairReason4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ICUS|Int32||XmlEnum("""ICUS""")|1|
||DEPT|Int32||XmlEnum("""DEPT""")|2|
||ICAG|Int32||XmlEnum("""ICAG""")|3|
||IEXE|Int32||XmlEnum("""IEXE""")|4|
||OTHR|Int32||XmlEnum("""OTHR""")|5|
||SDUT|Int32||XmlEnum("""SDUT""")|6|
||INPS|Int32||XmlEnum("""INPS""")|7|
||TXST|Int32||XmlEnum("""TXST""")|8|
||SETS|Int32||XmlEnum("""SETS""")|9|
||SETR|Int32||XmlEnum("""SETR""")|10|
||SAFE|Int32||XmlEnum("""SAFE""")|11|
||RTGS|Int32||XmlEnum("""RTGS""")|12|
||REFE|Int32||XmlEnum("""REFE""")|13|
||PLCE|Int32||XmlEnum("""PLCE""")|14|
||PHYS|Int32||XmlEnum("""PHYS""")|15|
||NCRR|Int32||XmlEnum("""NCRR""")|16|
||MUNO|Int32||XmlEnum("""MUNO""")|17|
||MINO|Int32||XmlEnum("""MINO""")|18|
||IIND|Int32||XmlEnum("""IIND""")|19|
||DTRD|Int32||XmlEnum("""DTRD""")|20|
||DSEC|Int32||XmlEnum("""DSEC""")|21|
||DQUA|Int32||XmlEnum("""DQUA""")|22|
||DMON|Int32||XmlEnum("""DMON""")|23|
||DDEA|Int32||XmlEnum("""DDEA""")|24|
||DDAT|Int32||XmlEnum("""DDAT""")|25|
||CASY|Int32||XmlEnum("""CASY""")|26|
||CASH|Int32||XmlEnum("""CASH""")|27|
||CAEV|Int32||XmlEnum("""CAEV""")|28|
||BATC|Int32||XmlEnum("""BATC""")|29|

---

## Value ISO20022.Sese032001.RepairReason8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032001.RepairReason10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese032001.RepairStatus12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032001.RepairReason8>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese032001.Reporting2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DEFR|Int32||XmlEnum("""DEFR""")|1|
||REGU|Int32||XmlEnum("""REGU""")|2|
||STEX|Int32||XmlEnum("""STEX""")|3|

---

## Value ISO20022.Sese032001.Reporting6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.RepurchaseType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WTHD|Int32||XmlEnum("""WTHD""")|1|
||TOPU|Int32||XmlEnum("""TOPU""")|2|
||CADJ|Int32||XmlEnum("""CADJ""")|3|
||CALL|Int32||XmlEnum("""CALL""")|4|
||RATE|Int32||XmlEnum("""RATE""")|5|
||ROLP|Int32||XmlEnum("""ROLP""")|6|
||PAIR|Int32||XmlEnum("""PAIR""")|7|

---

## Value ISO20022.Sese032001.RepurchaseType23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.Restriction5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.SafeKeepingPlace5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Sese032001.SafekeepingPlaceFormat41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Sese032001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Sese032001.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Sese032001.SafekeepingPlaceFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Sese032001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Sese032001.SafekeepingPlaceTypeAndText8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Sese032001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese032001.SafekeepingPlaceTypeAndText8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese032001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese032001.SecuritiesCertificate4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Sese032001.SecuritiesPaymentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NILL|Int32||XmlEnum("""NILL""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Sese032001.SecuritiesPaymentStatus5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.SecuritiesRTGS4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Aspect ISO20022.Sese032001.SecuritiesSettlementTransactionGenerationNotificationV12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese032001.SupplementaryData1>||XmlElement()||
|+|StsAndRsn|ISO20022.Sese032001.StatusAndReason48||XmlElement()||
|+|GnrtdRsn|global::System.Collections.Generic.List<ISO20022.Sese032001.GeneratedReason5>||XmlElement()||
|+|AddtlPhysOrRegnDtls|ISO20022.Sese032001.RegistrationParameters6||XmlElement()||
|+|OthrBizPties|ISO20022.Sese032001.OtherParties43||XmlElement()||
|+|DgtlNtwkFee|ISO20022.Sese032001.NetworkFee1||XmlElement()||
|+|OthrAmts|ISO20022.Sese032001.OtherAmounts45||XmlElement()||
|+|SttlmAmt|ISO20022.Sese032001.AmountAndDirection94||XmlElement()||
|+|CshPties|ISO20022.Sese032001.CashParties41||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese032001.SettlementParties126||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese032001.SettlementParties126||XmlElement()||
|+|SttlmParams|ISO20022.Sese032001.SettlementDetails217||XmlElement()||
|+|QtyAndAcctDtls|global::System.Collections.Generic.List<ISO20022.Sese032001.QuantityAndAccount117>||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Sese032001.FinancialInstrumentAttributes111||XmlElement()||
|+|FinInstrmId|ISO20022.Sese032001.SecurityIdentification19||XmlElement()||
|+|TradDtls|ISO20022.Sese032001.SecuritiesTradeDetails145||XmlElement()||
|+|Lnkgs|global::System.Collections.Generic.List<ISO20022.Sese032001.Linkages61>||XmlElement()||
|+|NbCounts|ISO20022.Sese032001.NumberCount2Choice||XmlElement()||
|+|TxIdDtls|ISO20022.Sese032001.SettlementTypeAndIdentification29||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(StsAndRsn),validList("""GnrtdRsn""",GnrtdRsn),validElement(GnrtdRsn),validElement(AddtlPhysOrRegnDtls),validElement(OthrBizPties),validElement(DgtlNtwkFee),validElement(OthrAmts),validElement(SttlmAmt),validElement(CshPties),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(SttlmParams),validRequired("""QtyAndAcctDtls""",QtyAndAcctDtls),validList("""QtyAndAcctDtls""",QtyAndAcctDtls),validElement(QtyAndAcctDtls),validElement(FinInstrmAttrbts),validElement(FinInstrmId),validElement(TradDtls),validList("""Lnkgs""",Lnkgs),validElement(Lnkgs),validElement(NbCounts),validElement(TxIdDtls))|

---

## Value ISO20022.Sese032001.SecuritiesTradeDetails145


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmInstrPrcgAddtlDtls|String||XmlElement()||
|+|FxAddtlDtls|String||XmlElement()||
|+|AffirmSts|ISO20022.Sese032001.AffirmationStatus8Choice||XmlElement()||
|+|MtchgSts|ISO20022.Sese032001.MatchingStatus27Choice||XmlElement()||
|+|CcyToBuyOrSell|ISO20022.Sese032001.CurrencyToBuyOrSell1Choice||XmlElement()||
|+|TpOfPric|ISO20022.Sese032001.TypeOfPrice29Choice||XmlElement()||
|+|TradOrgtrRole|ISO20022.Sese032001.TradeOriginator3Choice||XmlElement()||
|+|InvstrCpcty|ISO20022.Sese032001.InvestorCapacity4Choice||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Sese032001.TradeTransactionCondition5Choice>||XmlElement()||
|+|Rptg|global::System.Collections.Generic.List<ISO20022.Sese032001.Reporting6Choice>||XmlElement()||
|+|OpngClsg|ISO20022.Sese032001.OpeningClosing3Choice||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|DealPric|ISO20022.Sese032001.Price10||XmlElement()||
|+|MtchdStsTmStmp|DateTime||XmlElement()||
|+|AckdStsTmStmp|DateTime||XmlElement()||
|+|LateDlvryDt|ISO20022.Sese032001.DateAndDateTime2Choice||XmlElement()||
|+|SttlmDt|ISO20022.Sese032001.SettlementDate17Choice||XmlElement()||
|+|TradDt|ISO20022.Sese032001.TradeDate8Choice||XmlElement()||
|+|PlcOfClr|ISO20022.Sese032001.PlaceOfClearingIdentification2||XmlElement()||
|+|PlcOfTrad|ISO20022.Sese032001.PlaceOfTradeIdentification1||XmlElement()||
|+|CollTxId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
|+|TradId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AffirmSts),validElement(MtchgSts),validElement(CcyToBuyOrSell),validElement(TpOfPric),validElement(TradOrgtrRole),validElement(InvstrCpcty),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond),validList("""Rptg""",Rptg),validElement(Rptg),validElement(OpngClsg),validElement(DealPric),validElement(LateDlvryDt),validElement(SttlmDt),validElement(TradDt),validElement(PlcOfClr),validElement(PlcOfTrad),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""))|

---

## Enum ISO20022.Sese032001.SecuritiesTransactionType26Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REBL|Int32||XmlEnum("""REBL""")|1|
||REDI|Int32||XmlEnum("""REDI""")|2|
||SBBK|Int32||XmlEnum("""SBBK""")|3|
||INSP|Int32||XmlEnum("""INSP""")|4|
||SLRE|Int32||XmlEnum("""SLRE""")|5|
||ISSU|Int32||XmlEnum("""ISSU""")|6|
||ETFT|Int32||XmlEnum("""ETFT""")|7|
||CONV|Int32||XmlEnum("""CONV""")|8|
||SWIT|Int32||XmlEnum("""SWIT""")|9|
||SWIF|Int32||XmlEnum("""SWIF""")|10|
||AUTO|Int32||XmlEnum("""AUTO""")|11|
||CLAI|Int32||XmlEnum("""CLAI""")|12|
||CORP|Int32||XmlEnum("""CORP""")|13|
||SBRE|Int32||XmlEnum("""SBRE""")|14|
||RELE|Int32||XmlEnum("""RELE""")|15|
||OWNI|Int32||XmlEnum("""OWNI""")|16|
||FCTA|Int32||XmlEnum("""FCTA""")|17|
||OWNE|Int32||XmlEnum("""OWNE""")|18|
||CNCB|Int32||XmlEnum("""CNCB""")|19|
||BYIY|Int32||XmlEnum("""BYIY""")|20|
||TURN|Int32||XmlEnum("""TURN""")|21|
||TRVO|Int32||XmlEnum("""TRVO""")|22|
||TRPO|Int32||XmlEnum("""TRPO""")|23|
||TRAD|Int32||XmlEnum("""TRAD""")|24|
||TBAC|Int32||XmlEnum("""TBAC""")|25|
||SYND|Int32||XmlEnum("""SYND""")|26|
||SUBS|Int32||XmlEnum("""SUBS""")|27|
||SECL|Int32||XmlEnum("""SECL""")|28|
||SECB|Int32||XmlEnum("""SECB""")|29|
||RVPO|Int32||XmlEnum("""RVPO""")|30|
||RODE|Int32||XmlEnum("""RODE""")|31|
||REPU|Int32||XmlEnum("""REPU""")|32|
||REDM|Int32||XmlEnum("""REDM""")|33|
||REAL|Int32||XmlEnum("""REAL""")|34|
||PORT|Int32||XmlEnum("""PORT""")|35|
||PLAC|Int32||XmlEnum("""PLAC""")|36|
||PAIR|Int32||XmlEnum("""PAIR""")|37|
||NSYN|Int32||XmlEnum("""NSYN""")|38|
||NETT|Int32||XmlEnum("""NETT""")|39|
||MKUP|Int32||XmlEnum("""MKUP""")|40|
||MKDW|Int32||XmlEnum("""MKDW""")|41|
||COLO|Int32||XmlEnum("""COLO""")|42|
||COLI|Int32||XmlEnum("""COLI""")|43|
||BSBK|Int32||XmlEnum("""BSBK""")|44|

---

## Value ISO20022.Sese032001.SecuritiesTransactionType44Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese032001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese032001.SettlementDate17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese032001.SettlementDateCode7Choice||XmlElement()||
|+|Dt|ISO20022.Sese032001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Sese032001.SettlementDate4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WISS|Int32||XmlEnum("""WISS""")|1|

---

## Value ISO20022.Sese032001.SettlementDateCode7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.SettlementDetails217


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshSubBalTp|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|SctiesSubBalTp|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|ElgblForColl|String||XmlElement()||
|+|ModCxlAllwd|ISO20022.Sese032001.ModificationCancellationAllowed4Choice||XmlElement()||
|+|RtrLeg|String||XmlElement()||
|+|LttrOfGrnt|ISO20022.Sese032001.LetterOfGuarantee4Choice||XmlElement()||
|+|AutomtcBrrwg|ISO20022.Sese032001.AutomaticBorrowing6Choice||XmlElement()||
|+|Trckg|ISO20022.Sese032001.Tracking4Choice||XmlElement()||
|+|StmpDtyTaxBsis|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|TaxCpcty|ISO20022.Sese032001.TaxCapacityParty4Choice||XmlElement()||
|+|SttlmSysMtd|ISO20022.Sese032001.SettlementSystemMethod4Choice||XmlElement()||
|+|SttlgCpcty|ISO20022.Sese032001.SettlingCapacity7Choice||XmlElement()||
|+|SctiesRTGS|ISO20022.Sese032001.SecuritiesRTGS4Choice||XmlElement()||
|+|LglRstrctns|ISO20022.Sese032001.Restriction5Choice||XmlElement()||
|+|RpTp|ISO20022.Sese032001.RepurchaseType23Choice||XmlElement()||
|+|Regn|ISO20022.Sese032001.Registration9Choice||XmlElement()||
|+|NetgElgblty|ISO20022.Sese032001.NettingEligibility4Choice||XmlElement()||
|+|MktClntSd|ISO20022.Sese032001.MarketClientSide6Choice||XmlElement()||
|+|FxStgInstr|ISO20022.Sese032001.FXStandingInstruction4Choice||XmlElement()||
|+|XpsrTp|ISO20022.Sese032001.ExposureType25Choice||XmlElement()||
|+|CshClrSys|ISO20022.Sese032001.CashSettlementSystem4Choice||XmlElement()||
|+|DlvryRtrRsn|ISO20022.Sese032001.DeliveryReturn3Choice||XmlElement()||
|+|CCPElgblty|ISO20022.Sese032001.CentralCounterPartyEligibility4Choice||XmlElement()||
|+|BlckTrad|ISO20022.Sese032001.BlockTrade4Choice||XmlElement()||
|+|BnfclOwnrsh|ISO20022.Sese032001.BeneficialOwnership4Choice||XmlElement()||
|+|PrtlSttlmInd|String||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese032001.SettlementTransactionCondition20Choice>||XmlElement()||
|+|SctiesTxTp|ISO20022.Sese032001.SecuritiesTransactionType44Choice||XmlElement()||
|+|Prty|ISO20022.Sese032001.PriorityNumeric4Choice||XmlElement()||
|+|HldInd|ISO20022.Sese032001.HoldIndicator6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshSubBalTp),validElement(SctiesSubBalTp),validElement(ModCxlAllwd),validElement(LttrOfGrnt),validElement(AutomtcBrrwg),validElement(Trckg),validElement(StmpDtyTaxBsis),validElement(TaxCpcty),validElement(SttlmSysMtd),validElement(SttlgCpcty),validElement(SctiesRTGS),validElement(LglRstrctns),validElement(RpTp),validElement(Regn),validElement(NetgElgblty),validElement(MktClntSd),validElement(FxStgInstr),validElement(XpsrTp),validElement(CshClrSys),validElement(DlvryRtrRsn),validElement(CCPElgblty),validElement(BlckTrad),validElement(BnfclOwnrsh),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validElement(SctiesTxTp),validElement(Prty),validElement(HldInd))|

---

## Value ISO20022.Sese032001.SettlementParties126


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese032001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty4|ISO20022.Sese032001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty3|ISO20022.Sese032001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty2|ISO20022.Sese032001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty1|ISO20022.Sese032001.PartyIdentificationAndAccount196||XmlElement()||
|+|Dpstry|ISO20022.Sese032001.PartyIdentification315||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Value ISO20022.Sese032001.SettlementStatus32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.ProprietaryStatusAndReason6||XmlElement()||
|+|Flng|ISO20022.Sese032001.FailingStatus15Choice||XmlElement()||
|+|Pdg|ISO20022.Sese032001.PendingStatus73Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Flng),validElement(Pdg),validChoice(Prtry,Flng,Pdg))|

---

## Enum ISO20022.Sese032001.SettlementSystemMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSET|Int32||XmlEnum("""YSET""")|1|
||NSET|Int32||XmlEnum("""NSET""")|2|

---

## Value ISO20022.Sese032001.SettlementSystemMethod4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.SettlementTransactionCondition20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.SettlementTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARQ|Int32||XmlEnum("""PARQ""")|1|
||PARC|Int32||XmlEnum("""PARC""")|2|
||NPAR|Int32||XmlEnum("""NPAR""")|3|
||PART|Int32||XmlEnum("""PART""")|4|

---

## Enum ISO20022.Sese032001.SettlementTransactionCondition8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RPTO|Int32||XmlEnum("""RPTO""")|1|
||ADEA|Int32||XmlEnum("""ADEA""")|2|
||RHYP|Int32||XmlEnum("""RHYP""")|3|
||TRAN|Int32||XmlEnum("""TRAN""")|4|
||NOMC|Int32||XmlEnum("""NOMC""")|5|
||TRIP|Int32||XmlEnum("""TRIP""")|6|
||UNEX|Int32||XmlEnum("""UNEX""")|7|
||PENS|Int32||XmlEnum("""PENS""")|8|
||EXPI|Int32||XmlEnum("""EXPI""")|9|
||SPST|Int32||XmlEnum("""SPST""")|10|
||SPDL|Int32||XmlEnum("""SPDL""")|11|
||SHOR|Int32||XmlEnum("""SHOR""")|12|
||RESI|Int32||XmlEnum("""RESI""")|13|
||PHYS|Int32||XmlEnum("""PHYS""")|14|
||KNOC|Int32||XmlEnum("""KNOC""")|15|
||FRCL|Int32||XmlEnum("""FRCL""")|16|
||EXER|Int32||XmlEnum("""EXER""")|17|
||DRAW|Int32||XmlEnum("""DRAW""")|18|
||DLWM|Int32||XmlEnum("""DLWM""")|19|
||DIRT|Int32||XmlEnum("""DIRT""")|20|
||CLEN|Int32||XmlEnum("""CLEN""")|21|
||BUTC|Int32||XmlEnum("""BUTC""")|22|
||ASGN|Int32||XmlEnum("""ASGN""")|23|

---

## Value ISO20022.Sese032001.SettlementTypeAndIdentification29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonceId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|CmonId|String||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|CtrPtyMktInfrstrctrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Sese032001.SettlingCapacity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RISP|Int32||XmlEnum("""RISP""")|1|
||SPRI|Int32||XmlEnum("""SPRI""")|2|
||CUST|Int32||XmlEnum("""CUST""")|3|
||SAGE|Int32||XmlEnum("""SAGE""")|4|

---

## Value ISO20022.Sese032001.SettlingCapacity7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.StatusAndReason48


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmSts|ISO20022.Sese032001.SettlementStatus32Choice||XmlElement()||
|+|MtchgSts|ISO20022.Sese032001.MatchingStatus24Choice||XmlElement()||
|+|IfrrdMtchgSts|ISO20022.Sese032001.MatchingStatus24Choice||XmlElement()||
|+|PrcgSts|ISO20022.Sese032001.ProcessingStatus52Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmSts),validElement(MtchgSts),validElement(IfrrdMtchgSts),validElement(PrcgSts))|

---

## Value ISO20022.Sese032001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese032001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese032001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese032001.TaxCapacityParty4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.TaxLiability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGEN|Int32||XmlEnum("""AGEN""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Sese032001.TotalNumber2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlOfLkdInstrs|String||XmlElement()||
|+|CurInstrNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TtlOfLkdInstrs""",TtlOfLkdInstrs,"""[0-9]{1,6}"""),validPattern("""CurInstrNb""",CurInstrNb,"""[0-9]{1,6}"""))|

---

## Value ISO20022.Sese032001.Tracking4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese032001.TradeDate8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese032001.TradeDateCode3Choice||XmlElement()||
|+|Dt|ISO20022.Sese032001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese032001.TradeDateCode3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.TradeOriginator3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.TradeTransactionCondition4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BCPD|Int32||XmlEnum("""BCPD""")|1|
||NMPR|Int32||XmlEnum("""NMPR""")|2|
||NEGO|Int32||XmlEnum("""NEGO""")|3|
||MAPR|Int32||XmlEnum("""MAPR""")|4|
||BCBN|Int32||XmlEnum("""BCBN""")|5|
||BCBL|Int32||XmlEnum("""BCBL""")|6|
||BCFD|Int32||XmlEnum("""BCFD""")|7|
||BCRP|Int32||XmlEnum("""BCRP""")|8|
||BCRO|Int32||XmlEnum("""BCRO""")|9|
||GTDL|Int32||XmlEnum("""GTDL""")|10|
||SPEX|Int32||XmlEnum("""SPEX""")|11|
||SPCU|Int32||XmlEnum("""SPCU""")|12|
||XWAR|Int32||XmlEnum("""XWAR""")|13|
||CWAR|Int32||XmlEnum("""CWAR""")|14|
||XRTS|Int32||XmlEnum("""XRTS""")|15|
||CRTS|Int32||XmlEnum("""CRTS""")|16|
||XDIV|Int32||XmlEnum("""XDIV""")|17|
||CDIV|Int32||XmlEnum("""CDIV""")|18|
||XCPN|Int32||XmlEnum("""XCPN""")|19|
||CCPN|Int32||XmlEnum("""CCPN""")|20|
||XBNS|Int32||XmlEnum("""XBNS""")|21|
||CBNS|Int32||XmlEnum("""CBNS""")|22|

---

## Value ISO20022.Sese032001.TradeTransactionCondition5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.TypeOfIdentification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXID|Int32||XmlEnum("""TXID""")|1|
||FIIN|Int32||XmlEnum("""FIIN""")|2|
||DRLC|Int32||XmlEnum("""DRLC""")|3|
||CORP|Int32||XmlEnum("""CORP""")|4|
||CHTY|Int32||XmlEnum("""CHTY""")|5|
||CCPT|Int32||XmlEnum("""CCPT""")|6|
||ARNU|Int32||XmlEnum("""ARNU""")|7|

---

## Enum ISO20022.Sese032001.TypeOfPrice14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AVER|Int32||XmlEnum("""AVER""")|1|

---

## Value ISO20022.Sese032001.TypeOfPrice29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032001.UnmatchedReason11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNBR|Int32||XmlEnum("""UNBR""")|1|
||DELN|Int32||XmlEnum("""DELN""")|2|
||DTRD|Int32||XmlEnum("""DTRD""")|3|
||TXST|Int32||XmlEnum("""TXST""")|4|
||SETR|Int32||XmlEnum("""SETR""")|5|
||SETS|Int32||XmlEnum("""SETS""")|6|
||DDAT|Int32||XmlEnum("""DDAT""")|7|
||DMON|Int32||XmlEnum("""DMON""")|8|
||SAFE|Int32||XmlEnum("""SAFE""")|9|
||RTGS|Int32||XmlEnum("""RTGS""")|10|
||REGD|Int32||XmlEnum("""REGD""")|11|
||IEXE|Int32||XmlEnum("""IEXE""")|12|
||ICUS|Int32||XmlEnum("""ICUS""")|13|
||ICAG|Int32||XmlEnum("""ICAG""")|14|
||DEPT|Int32||XmlEnum("""DEPT""")|15|
||PODU|Int32||XmlEnum("""PODU""")|16|
||PLCE|Int32||XmlEnum("""PLCE""")|17|
||INPS|Int32||XmlEnum("""INPS""")|18|
||PLIS|Int32||XmlEnum("""PLIS""")|19|
||PHYS|Int32||XmlEnum("""PHYS""")|20|
||FRAP|Int32||XmlEnum("""FRAP""")|21|
||OTHR|Int32||XmlEnum("""OTHR""")|22|
||DTRA|Int32||XmlEnum("""DTRA""")|23|
||NMAS|Int32||XmlEnum("""NMAS""")|24|
||CMIS|Int32||XmlEnum("""CMIS""")|25|
||MIME|Int32||XmlEnum("""MIME""")|26|
||LATE|Int32||XmlEnum("""LATE""")|27|
||LEOG|Int32||XmlEnum("""LEOG""")|28|
||INVE|Int32||XmlEnum("""INVE""")|29|
||DQUA|Int32||XmlEnum("""DQUA""")|30|
||DSEC|Int32||XmlEnum("""DSEC""")|31|
||DCMX|Int32||XmlEnum("""DCMX""")|32|
||DMCT|Int32||XmlEnum("""DMCT""")|33|
||DDEA|Int32||XmlEnum("""DDEA""")|34|
||NCRR|Int32||XmlEnum("""NCRR""")|35|
||CLAT|Int32||XmlEnum("""CLAT""")|36|
||CPCA|Int32||XmlEnum("""CPCA""")|37|
||IIND|Int32||XmlEnum("""IIND""")|38|
||ACRU|Int32||XmlEnum("""ACRU""")|39|
||ADEA|Int32||XmlEnum("""ADEA""")|40|

---

## Value ISO20022.Sese032001.UnmatchedReason15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032001.UnmatchedReason21Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese032001.UnmatchedReason21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032001.UnmatchedStatus16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032001.UnmatchedReason15>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese032001.YieldedOrValueType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValTp|String||XmlElement()||
|+|Yldd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(ValTp,Yldd))|

---

## Value ISO20022.Sese032001.YieldedOrValueType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValTp|String||XmlElement()||
|+|Yldd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(ValTp,Yldd))|

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

