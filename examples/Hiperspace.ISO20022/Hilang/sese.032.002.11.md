# sese.032.002.11
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese032002.AcknowledgedAcceptedStatus25Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032002.AcknowledgementReason13~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese032002.AcknowledgedAcceptedStatus25Choice *-- ISO20022.Sese032002.AcknowledgementReason13
    class ISO20022.Sese032002.AcknowledgementReason13 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032002.AcknowledgementReason16Choice
    }
    ISO20022.Sese032002.AcknowledgementReason13 *-- ISO20022.Sese032002.AcknowledgementReason16Choice
    class ISO20022.Sese032002.AcknowledgementReason16Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.AcknowledgementReason16Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.AcknowledgementReason5Code {
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
    class ISO20022.Sese032002.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese032002.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese032002.AffirmationStatus1Code {
        NAFI = 1
        AFFI = 2
    }
    class ISO20022.Sese032002.AffirmationStatus9Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.AffirmationStatus9Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.AlternatePartyIdentification9 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Sese032002.IdentificationType44Choice
    }
    ISO20022.Sese032002.AlternatePartyIdentification9 *-- ISO20022.Sese032002.IdentificationType44Choice
    class ISO20022.Sese032002.AmountAndDirection44 {
        + FXDtls  : ISO20022.Sese032002.ForeignExchangeTerms23
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese032002.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese032002.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Sese032002.AmountAndDirection44 *-- ISO20022.Sese032002.ForeignExchangeTerms23
    ISO20022.Sese032002.AmountAndDirection44 *-- ISO20022.Sese032002.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese032002.AmountAndDirection44 *-- ISO20022.Sese032002.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese032002.AmountAndDirection58 {
        + FXDtls  : ISO20022.Sese032002.ForeignExchangeTerms27
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Sese032002.AmountAndDirection58 *-- ISO20022.Sese032002.ForeignExchangeTerms27
    ISO20022.Sese032002.AmountAndDirection58 *-- ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese032002.AmountAndDirection58 *-- ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese032002.AmountAndDirection96 {
        + ValDt  : ISO20022.Sese032002.DateAndDateTime2Choice
        + FXDtls  : ISO20022.Sese032002.ForeignExchangeTerms27
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese032002.RestrictedFINActiveCurrencyAndAmount
        + RsrchFeeInd  : String
        + BrkrgAmtInd  : String
        + StmpDtyInd  : String
        + AcrdIntrstInd  : String
    }
    ISO20022.Sese032002.AmountAndDirection96 *-- ISO20022.Sese032002.DateAndDateTime2Choice
    ISO20022.Sese032002.AmountAndDirection96 *-- ISO20022.Sese032002.ForeignExchangeTerms27
    ISO20022.Sese032002.AmountAndDirection96 *-- ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese032002.AmountAndDirection96 *-- ISO20022.Sese032002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese032002.AutoBorrowing1Code {
        YBOR = 1
        NBOR = 2
        LAMI = 3
    }
    class ISO20022.Sese032002.AutomaticBorrowing8Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.AutomaticBorrowing8Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.BeneficialOwnership5Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese032002.BeneficialOwnership5Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Sese032002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese032002.BlockChainAddressWallet7 *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.BlockTrade1Code {
        BLCH = 1
        BLPA = 2
    }
    class ISO20022.Sese032002.BlockTrade5Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.BlockTrade5Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.CashAccountIdentification6Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Sese032002.CashParties38 {
        + Intrmy  : ISO20022.Sese032002.PartyIdentificationAndAccount178
        + CdtrAgt  : ISO20022.Sese032002.PartyIdentificationAndAccount178
        + Cdtr  : ISO20022.Sese032002.PartyIdentificationAndAccount177
        + DbtrAgt  : ISO20022.Sese032002.PartyIdentificationAndAccount178
        + Dbtr  : ISO20022.Sese032002.PartyIdentificationAndAccount177
    }
    ISO20022.Sese032002.CashParties38 *-- ISO20022.Sese032002.PartyIdentificationAndAccount178
    ISO20022.Sese032002.CashParties38 *-- ISO20022.Sese032002.PartyIdentificationAndAccount178
    ISO20022.Sese032002.CashParties38 *-- ISO20022.Sese032002.PartyIdentificationAndAccount177
    ISO20022.Sese032002.CashParties38 *-- ISO20022.Sese032002.PartyIdentificationAndAccount178
    ISO20022.Sese032002.CashParties38 *-- ISO20022.Sese032002.PartyIdentificationAndAccount177
    class ISO20022.Sese032002.CashSettlementSystem2Code {
        NETS = 1
        GROS = 2
    }
    class ISO20022.Sese032002.CashSettlementSystem5Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.CashSettlementSystem5Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.CentralCounterPartyEligibility5Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese032002.CentralCounterPartyEligibility5Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.ClassificationType33Choice {
        + AltrnClssfctn  : ISO20022.Sese032002.GenericIdentification86
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Sese032002.ClassificationType33Choice *-- ISO20022.Sese032002.GenericIdentification86
    class ISO20022.Sese032002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese032002.CurrencyToBuyOrSell1Choice {
        + CcyToSell  : String
        + CcyToBuy  : String
    }
    class ISO20022.Sese032002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese032002.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese032002.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese032002.DeliveryReturn1Code {
        PARD = 1
        DUEB = 2
        SAFE = 3
        PART = 4
        DMON = 5
        DQUA = 6
        UNRE = 7
    }
    class ISO20022.Sese032002.DeliveryReturn4Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.DeliveryReturn4Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.DocumentNumber6Choice {
        + PrtryNb  : ISO20022.Sese032002.GenericIdentification86
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Sese032002.DocumentNumber6Choice *-- ISO20022.Sese032002.GenericIdentification86
    class ISO20022.Sese032002.Eligibility1Code {
        PROF = 1
        RETL = 2
        ELIG = 3
    }
    class ISO20022.Sese032002.EventFrequency3Code {
        WEEK = 1
        SEMI = 2
        QUTR = 3
        MNTH = 4
        YEAR = 5
    }
    class ISO20022.Sese032002.ExposureType12Code {
        TRCP = 1
        UDMS = 2
        TBAS = 3
        SWPT = 4
        SCIE = 5
        SCIR = 6
        SHSL = 7
        SLEB = 8
        SCRP = 9
        SBSC = 10
        SLOA = 11
        RVPO = 12
        REPO = 13
        OTCD = 14
        LIQU = 15
        OPTN = 16
        FUTR = 17
        FORW = 18
        FORX = 19
        FIXI = 20
        EXPT = 21
        EQUS = 22
        EXTD = 23
        EQPT = 24
        CRPR = 25
        CCIR = 26
        CRSP = 27
        CRTL = 28
        CRDS = 29
        COMM = 30
        CCPC = 31
        PAYM = 32
        BFWD = 33
    }
    class ISO20022.Sese032002.ExposureType24Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.ExposureType24Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.FXStandingInstruction5Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese032002.FXStandingInstruction5Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.FailingReason10 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032002.FailingReason11Choice
    }
    ISO20022.Sese032002.FailingReason10 *-- ISO20022.Sese032002.FailingReason11Choice
    class ISO20022.Sese032002.FailingReason11Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.FailingReason11Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.FailingReason2Code {
        INBC = 1
        CVAL = 2
        CSDH = 3
        CDLR = 4
        PRSY = 5
        CERT = 6
        SETS = 7
        REGT = 8
        PRCY = 9
        LIQU = 10
        LATE = 11
        LAAW = 12
        FROZ = 13
        DKNY = 14
        DISA = 15
        DENO = 16
        CLHT = 17
        BOTH = 18
        BENO = 19
        PHCK = 20
        OTHR = 21
        IAAD = 22
        MINO = 23
        CPEC = 24
        SBLO = 25
        CYCL = 26
        BATC = 27
        SDUT = 28
        REFS = 29
        NCON = 30
        MONY = 31
        LALO = 32
        LACK = 33
        LINK = 34
        INCA = 35
        FLIM = 36
        DEPO = 37
        COLL = 38
        YCOL = 39
        CMON = 40
        NOFX = 41
        PART = 42
        PREA = 43
        GLOB = 44
        MUNO = 45
        CLAC = 46
        NEWI = 47
        CHAS = 48
        BLOC = 49
        DOCC = 50
        MLAT = 51
        DOCY = 52
        STCD = 53
        PHSE = 54
        AWSH = 55
        OBJT = 56
        CAIS = 57
        CANR = 58
        ADEA = 59
        CLAT = 60
        BYIY = 61
        AWMO = 62
    }
    class ISO20022.Sese032002.FailingStatus12Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032002.FailingReason10~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese032002.FailingStatus12Choice *-- ISO20022.Sese032002.FailingReason10
    class ISO20022.Sese032002.FinancialInstrumentAttributes122 {
        + FinInstrmAttrAddtlDtls  : String
        + UndrlygFinInstrmId  : global::System.Collections.Generic.List~ISO20022.Sese032002.SecurityIdentification20~
        + CtrctSz  : ISO20022.Sese032002.FinancialInstrumentQuantity36Choice
        + MinNmnlQty  : ISO20022.Sese032002.FinancialInstrumentQuantity36Choice
        + StrkPric  : ISO20022.Sese032002.Price3
        + ConvsPric  : ISO20022.Sese032002.Price3
        + SbcptPric  : ISO20022.Sese032002.Price3
        + ExrcPric  : ISO20022.Sese032002.Price3
        + MktOrIndctvPric  : ISO20022.Sese032002.PriceType5Choice
        + PutblInd  : String
        + CllblInd  : String
        + VarblRateInd  : String
        + PoolNb  : ISO20022.Sese032002.GenericIdentification39
        + CpnAttchdNb  : ISO20022.Sese032002.Number23Choice
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
        + OptnTp  : ISO20022.Sese032002.OptionType7Choice
        + OptnStyle  : ISO20022.Sese032002.OptionStyle9Choice
        + ClssfctnTp  : ISO20022.Sese032002.ClassificationType33Choice
        + VarblRateChngFrqcy  : ISO20022.Sese032002.Frequency27Choice
        + PmtSts  : ISO20022.Sese032002.SecuritiesPaymentStatus6Choice
        + PmtFrqcy  : ISO20022.Sese032002.Frequency27Choice
        + RegnForm  : ISO20022.Sese032002.FormOfSecurity7Choice
        + DayCntBsis  : ISO20022.Sese032002.InterestComputationMethodFormat5Choice
        + PlcOfListg  : ISO20022.Sese032002.MarketIdentification4Choice
    }
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.SecurityIdentification20
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.FinancialInstrumentQuantity36Choice
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.FinancialInstrumentQuantity36Choice
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.Price3
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.Price3
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.Price3
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.Price3
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.PriceType5Choice
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.GenericIdentification39
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.Number23Choice
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.OptionType7Choice
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.OptionStyle9Choice
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.ClassificationType33Choice
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.Frequency27Choice
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.SecuritiesPaymentStatus6Choice
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.Frequency27Choice
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.FormOfSecurity7Choice
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.InterestComputationMethodFormat5Choice
    ISO20022.Sese032002.FinancialInstrumentAttributes122 *-- ISO20022.Sese032002.MarketIdentification4Choice
    class ISO20022.Sese032002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese032002.ForeignExchangeTerms23 {
        + RsltgAmt  : ISO20022.Sese032002.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Sese032002.ForeignExchangeTerms23 *-- ISO20022.Sese032002.ActiveCurrencyAndAmount
    class ISO20022.Sese032002.ForeignExchangeTerms27 {
        + RsltgAmt  : ISO20022.Sese032002.RestrictedFINActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Sese032002.ForeignExchangeTerms27 *-- ISO20022.Sese032002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese032002.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Sese032002.FormOfSecurity7Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.FormOfSecurity7Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.Frequency27Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.Frequency27Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.GeneratedReason3Code {
        TRAN = 1
        THRD = 2
        SPLI = 3
        RODE = 4
        OTHR = 5
        CLAI = 6
        COLL = 7
    }
    class ISO20022.Sese032002.GeneratedReason6 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032002.GeneratedReasons6Choice
    }
    ISO20022.Sese032002.GeneratedReason6 *-- ISO20022.Sese032002.GeneratedReasons6Choice
    class ISO20022.Sese032002.GeneratedReasons6Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.GeneratedReasons6Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.GenericIdentification18 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Sese032002.GenericIdentification39 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese032002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese032002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese032002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Sese032002.GenericIdentification47
    }
    ISO20022.Sese032002.GenericIdentification85 *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.GenericIdentification86 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese032002.HoldIndicator7 {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032002.RegistrationReason6~
        + Ind  : String
    }
    ISO20022.Sese032002.HoldIndicator7 *-- ISO20022.Sese032002.RegistrationReason6
    class ISO20022.Sese032002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese032002.IdentificationType44Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.IdentificationType44Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.InterestComputationMethod2Code {
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
    class ISO20022.Sese032002.InterestComputationMethodFormat5Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.InterestComputationMethodFormat5Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.InvestorCapacity5Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.InvestorCapacity5Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.LetterOfGuarantee5Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese032002.LetterOfGuarantee5Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.Linkages68 {
        + RefOwnr  : ISO20022.Sese032002.PartyIdentification136Choice
        + LkdQty  : ISO20022.Sese032002.PairedOrTurnedQuantity6Choice
        + Ref  : ISO20022.Sese032002.References78Choice
        + MsgNb  : ISO20022.Sese032002.DocumentNumber6Choice
        + PrcgPos  : ISO20022.Sese032002.ProcessingPosition10Choice
    }
    ISO20022.Sese032002.Linkages68 *-- ISO20022.Sese032002.PartyIdentification136Choice
    ISO20022.Sese032002.Linkages68 *-- ISO20022.Sese032002.PairedOrTurnedQuantity6Choice
    ISO20022.Sese032002.Linkages68 *-- ISO20022.Sese032002.References78Choice
    ISO20022.Sese032002.Linkages68 *-- ISO20022.Sese032002.DocumentNumber6Choice
    ISO20022.Sese032002.Linkages68 *-- ISO20022.Sese032002.ProcessingPosition10Choice
    class ISO20022.Sese032002.MarketClientSide1Code {
        MAKT = 1
        CLNT = 2
    }
    class ISO20022.Sese032002.MarketClientSide7Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.MarketClientSide7Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.MarketIdentification2Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese032002.MarketIdentification4Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese032002.MarketIdentification90 {
        + Tp  : ISO20022.Sese032002.MarketType16Choice
        + Id  : ISO20022.Sese032002.MarketIdentification2Choice
    }
    ISO20022.Sese032002.MarketIdentification90 *-- ISO20022.Sese032002.MarketType16Choice
    ISO20022.Sese032002.MarketIdentification90 *-- ISO20022.Sese032002.MarketIdentification2Choice
    class ISO20022.Sese032002.MarketType16Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.MarketType16Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Sese032002.MatchingStatus1Code {
        NMAT = 1
        MACH = 2
    }
    class ISO20022.Sese032002.MatchingStatus28Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.MatchingStatus28Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.MatchingStatus32Choice {
        + Prtry  : ISO20022.Sese032002.ProprietaryStatusAndReason7
        + Umtchd  : ISO20022.Sese032002.UnmatchedStatus21Choice
        + Mtchd  : ISO20022.Sese032002.ProprietaryReason5
    }
    ISO20022.Sese032002.MatchingStatus32Choice *-- ISO20022.Sese032002.ProprietaryStatusAndReason7
    ISO20022.Sese032002.MatchingStatus32Choice *-- ISO20022.Sese032002.UnmatchedStatus21Choice
    ISO20022.Sese032002.MatchingStatus32Choice *-- ISO20022.Sese032002.ProprietaryReason5
    class ISO20022.Sese032002.ModificationCancellationAllowed5Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese032002.ModificationCancellationAllowed5Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Sese032002.NettingEligibility5Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese032002.NettingEligibility5Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Sese032002.Number23Choice {
        + Lng  : ISO20022.Sese032002.GenericIdentification18
        + Shrt  : String
    }
    ISO20022.Sese032002.Number23Choice *-- ISO20022.Sese032002.GenericIdentification18
    class ISO20022.Sese032002.NumberCount2Choice {
        + TtlNb  : ISO20022.Sese032002.TotalNumber2
        + CurInstrNb  : String
    }
    ISO20022.Sese032002.NumberCount2Choice *-- ISO20022.Sese032002.TotalNumber2
    class ISO20022.Sese032002.OpeningClosing1Code {
        OPEP = 1
        CLOP = 2
    }
    class ISO20022.Sese032002.OpeningClosing4Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.OpeningClosing4Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Sese032002.OptionStyle9Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.OptionStyle9Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Sese032002.OptionType7Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.OptionType7Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.OriginalAndCurrentQuantities4 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Sese032002.OriginatorRole2Code {
        TAGT = 1
        INVE = 2
        MKTM = 3
        RMKT = 4
        MLTF = 5
        SINT = 6
    }
    class ISO20022.Sese032002.OtherAmounts43 {
        + RsrchFee  : ISO20022.Sese032002.AmountAndDirection44
        + AcrdCptlstnAmt  : ISO20022.Sese032002.AmountAndDirection58
        + CsmptnTax  : ISO20022.Sese032002.AmountAndDirection58
        + NetGnLoss  : ISO20022.Sese032002.AmountAndDirection58
        + WhldgTax  : ISO20022.Sese032002.AmountAndDirection58
        + ValAddedTax  : ISO20022.Sese032002.AmountAndDirection58
        + TxTax  : ISO20022.Sese032002.AmountAndDirection58
        + TrfTax  : ISO20022.Sese032002.AmountAndDirection58
        + StockXchgTax  : ISO20022.Sese032002.AmountAndDirection58
        + StmpDty  : ISO20022.Sese032002.AmountAndDirection58
        + SpclCncssn  : ISO20022.Sese032002.AmountAndDirection58
        + ShppgAmt  : ISO20022.Sese032002.AmountAndDirection58
        + RgltryAmt  : ISO20022.Sese032002.AmountAndDirection58
        + Othr  : ISO20022.Sese032002.AmountAndDirection58
        + Mrgn  : ISO20022.Sese032002.AmountAndDirection58
        + LclBrkrComssn  : ISO20022.Sese032002.AmountAndDirection58
        + LclTaxCtrySpcfc  : ISO20022.Sese032002.AmountAndDirection58
        + LclTax  : ISO20022.Sese032002.AmountAndDirection58
        + PmtLevyTax  : ISO20022.Sese032002.AmountAndDirection58
        + IsseDscntAllwnc  : ISO20022.Sese032002.AmountAndDirection58
        + ExctgBrkrAmt  : ISO20022.Sese032002.AmountAndDirection58
        + TradAmt  : ISO20022.Sese032002.AmountAndDirection58
        + CtryNtlFdrlTax  : ISO20022.Sese032002.AmountAndDirection58
        + ChrgsFees  : ISO20022.Sese032002.AmountAndDirection58
        + AcrdIntrstAmt  : ISO20022.Sese032002.AmountAndDirection58
    }
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection44
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    ISO20022.Sese032002.OtherAmounts43 *-- ISO20022.Sese032002.AmountAndDirection58
    class ISO20022.Sese032002.OtherIdentification2 {
        + Tp  : ISO20022.Sese032002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese032002.OtherIdentification2 *-- ISO20022.Sese032002.IdentificationSource4Choice
    class ISO20022.Sese032002.OtherParties44 {
        + Brkr  : ISO20022.Sese032002.PartyIdentificationAndAccount209
        + TrptyAgt  : ISO20022.Sese032002.PartyIdentificationAndAccount209
        + TradRgltr  : ISO20022.Sese032002.PartyIdentificationAndAccount181
        + StockXchg  : ISO20022.Sese032002.PartyIdentificationAndAccount181
        + QlfdFrgnIntrmy  : ISO20022.Sese032002.PartyIdentificationAndAccount209
        + Invstr  : global::System.Collections.Generic.List~ISO20022.Sese032002.PartyIdentificationAndAccount208~
    }
    ISO20022.Sese032002.OtherParties44 *-- ISO20022.Sese032002.PartyIdentificationAndAccount209
    ISO20022.Sese032002.OtherParties44 *-- ISO20022.Sese032002.PartyIdentificationAndAccount209
    ISO20022.Sese032002.OtherParties44 *-- ISO20022.Sese032002.PartyIdentificationAndAccount181
    ISO20022.Sese032002.OtherParties44 *-- ISO20022.Sese032002.PartyIdentificationAndAccount181
    ISO20022.Sese032002.OtherParties44 *-- ISO20022.Sese032002.PartyIdentificationAndAccount209
    ISO20022.Sese032002.OtherParties44 *-- ISO20022.Sese032002.PartyIdentificationAndAccount208
    class ISO20022.Sese032002.OwnershipLegalRestrictions1Code {
        RSTR = 1
        NRST = 2
        A144 = 3
    }
    class ISO20022.Sese032002.PairedOrTurnedQuantity6Choice {
        + TrndQty  : ISO20022.Sese032002.FinancialInstrumentQuantity36Choice
        + PairdOffQty  : ISO20022.Sese032002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Sese032002.PairedOrTurnedQuantity6Choice *-- ISO20022.Sese032002.FinancialInstrumentQuantity36Choice
    ISO20022.Sese032002.PairedOrTurnedQuantity6Choice *-- ISO20022.Sese032002.FinancialInstrumentQuantity36Choice
    class ISO20022.Sese032002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Sese032002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese032002.PartyIdentification136Choice *-- ISO20022.Sese032002.GenericIdentification84
    class ISO20022.Sese032002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Sese032002.NameAndAddress12
        + PrtryId  : ISO20022.Sese032002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese032002.PartyIdentification137Choice *-- ISO20022.Sese032002.NameAndAddress12
    ISO20022.Sese032002.PartyIdentification137Choice *-- ISO20022.Sese032002.GenericIdentification84
    class ISO20022.Sese032002.PartyIdentification145Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese032002.NameAndAddress12
        + AnyBIC  : String
    }
    ISO20022.Sese032002.PartyIdentification145Choice *-- ISO20022.Sese032002.NameAndAddress12
    class ISO20022.Sese032002.PartyIdentification147Choice {
        + PrtryId  : ISO20022.Sese032002.GenericIdentification84
        + NmAndAdr  : ISO20022.Sese032002.NameAndAddress12
        + BICFI  : String
    }
    ISO20022.Sese032002.PartyIdentification147Choice *-- ISO20022.Sese032002.GenericIdentification84
    ISO20022.Sese032002.PartyIdentification147Choice *-- ISO20022.Sese032002.NameAndAddress12
    class ISO20022.Sese032002.PartyIdentification156 {
        + LEI  : String
        + Id  : ISO20022.Sese032002.PartyIdentification136Choice
    }
    ISO20022.Sese032002.PartyIdentification156 *-- ISO20022.Sese032002.PartyIdentification136Choice
    class ISO20022.Sese032002.PartyIdentification162 {
        + AddtlInf  : ISO20022.Sese032002.PartyTextInformation3
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese032002.DateAndDateTime2Choice
        + AltrnId  : ISO20022.Sese032002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese032002.PartyIdentification145Choice
    }
    ISO20022.Sese032002.PartyIdentification162 *-- ISO20022.Sese032002.PartyTextInformation3
    ISO20022.Sese032002.PartyIdentification162 *-- ISO20022.Sese032002.DateAndDateTime2Choice
    ISO20022.Sese032002.PartyIdentification162 *-- ISO20022.Sese032002.AlternatePartyIdentification9
    ISO20022.Sese032002.PartyIdentification162 *-- ISO20022.Sese032002.PartyIdentification145Choice
    class ISO20022.Sese032002.PartyIdentificationAndAccount177 {
        + AddtlInf  : ISO20022.Sese032002.PartyTextInformation4
        + TaxAcct  : ISO20022.Sese032002.CashAccountIdentification6Choice
        + ComssnAcct  : ISO20022.Sese032002.CashAccountIdentification6Choice
        + ChrgsAcct  : ISO20022.Sese032002.CashAccountIdentification6Choice
        + CshAcct  : ISO20022.Sese032002.CashAccountIdentification6Choice
        + AltrnId  : ISO20022.Sese032002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese032002.PartyIdentification137Choice
    }
    ISO20022.Sese032002.PartyIdentificationAndAccount177 *-- ISO20022.Sese032002.PartyTextInformation4
    ISO20022.Sese032002.PartyIdentificationAndAccount177 *-- ISO20022.Sese032002.CashAccountIdentification6Choice
    ISO20022.Sese032002.PartyIdentificationAndAccount177 *-- ISO20022.Sese032002.CashAccountIdentification6Choice
    ISO20022.Sese032002.PartyIdentificationAndAccount177 *-- ISO20022.Sese032002.CashAccountIdentification6Choice
    ISO20022.Sese032002.PartyIdentificationAndAccount177 *-- ISO20022.Sese032002.CashAccountIdentification6Choice
    ISO20022.Sese032002.PartyIdentificationAndAccount177 *-- ISO20022.Sese032002.AlternatePartyIdentification9
    ISO20022.Sese032002.PartyIdentificationAndAccount177 *-- ISO20022.Sese032002.PartyIdentification137Choice
    class ISO20022.Sese032002.PartyIdentificationAndAccount178 {
        + AddtlInf  : ISO20022.Sese032002.PartyTextInformation4
        + TaxAcct  : ISO20022.Sese032002.CashAccountIdentification6Choice
        + ComssnAcct  : ISO20022.Sese032002.CashAccountIdentification6Choice
        + ChrgsAcct  : ISO20022.Sese032002.CashAccountIdentification6Choice
        + CshAcct  : ISO20022.Sese032002.CashAccountIdentification6Choice
        + AltrnId  : ISO20022.Sese032002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese032002.PartyIdentification147Choice
    }
    ISO20022.Sese032002.PartyIdentificationAndAccount178 *-- ISO20022.Sese032002.PartyTextInformation4
    ISO20022.Sese032002.PartyIdentificationAndAccount178 *-- ISO20022.Sese032002.CashAccountIdentification6Choice
    ISO20022.Sese032002.PartyIdentificationAndAccount178 *-- ISO20022.Sese032002.CashAccountIdentification6Choice
    ISO20022.Sese032002.PartyIdentificationAndAccount178 *-- ISO20022.Sese032002.CashAccountIdentification6Choice
    ISO20022.Sese032002.PartyIdentificationAndAccount178 *-- ISO20022.Sese032002.CashAccountIdentification6Choice
    ISO20022.Sese032002.PartyIdentificationAndAccount178 *-- ISO20022.Sese032002.AlternatePartyIdentification9
    ISO20022.Sese032002.PartyIdentificationAndAccount178 *-- ISO20022.Sese032002.PartyIdentification147Choice
    class ISO20022.Sese032002.PartyIdentificationAndAccount181 {
        + AddtlInf  : ISO20022.Sese032002.PartyTextInformation3
        + PrcgId  : String
        + AltrnId  : ISO20022.Sese032002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese032002.PartyIdentification137Choice
    }
    ISO20022.Sese032002.PartyIdentificationAndAccount181 *-- ISO20022.Sese032002.PartyTextInformation3
    ISO20022.Sese032002.PartyIdentificationAndAccount181 *-- ISO20022.Sese032002.AlternatePartyIdentification9
    ISO20022.Sese032002.PartyIdentificationAndAccount181 *-- ISO20022.Sese032002.PartyIdentification137Choice
    class ISO20022.Sese032002.PartyIdentificationAndAccount206 {
        + AddtlInf  : ISO20022.Sese032002.PartyTextInformation3
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese032002.DateAndDateTime2Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese032002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese032002.SecuritiesAccount30
        + AltrnId  : ISO20022.Sese032002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese032002.PartyIdentification137Choice
    }
    ISO20022.Sese032002.PartyIdentificationAndAccount206 *-- ISO20022.Sese032002.PartyTextInformation3
    ISO20022.Sese032002.PartyIdentificationAndAccount206 *-- ISO20022.Sese032002.DateAndDateTime2Choice
    ISO20022.Sese032002.PartyIdentificationAndAccount206 *-- ISO20022.Sese032002.BlockChainAddressWallet7
    ISO20022.Sese032002.PartyIdentificationAndAccount206 *-- ISO20022.Sese032002.SecuritiesAccount30
    ISO20022.Sese032002.PartyIdentificationAndAccount206 *-- ISO20022.Sese032002.AlternatePartyIdentification9
    ISO20022.Sese032002.PartyIdentificationAndAccount206 *-- ISO20022.Sese032002.PartyIdentification137Choice
    class ISO20022.Sese032002.PartyIdentificationAndAccount208 {
        + AddtlInf  : ISO20022.Sese032002.PartyTextInformation3
        + PrcgId  : String
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
        + Ntlty  : String
        + AltrnId  : ISO20022.Sese032002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese032002.PartyIdentification137Choice
    }
    ISO20022.Sese032002.PartyIdentificationAndAccount208 *-- ISO20022.Sese032002.PartyTextInformation3
    ISO20022.Sese032002.PartyIdentificationAndAccount208 *-- ISO20022.Sese032002.AlternatePartyIdentification9
    ISO20022.Sese032002.PartyIdentificationAndAccount208 *-- ISO20022.Sese032002.PartyIdentification137Choice
    class ISO20022.Sese032002.PartyIdentificationAndAccount209 {
        + AddtlInf  : ISO20022.Sese032002.PartyTextInformation3
        + PrcgId  : String
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
        + AltrnId  : ISO20022.Sese032002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese032002.PartyIdentification137Choice
    }
    ISO20022.Sese032002.PartyIdentificationAndAccount209 *-- ISO20022.Sese032002.PartyTextInformation3
    ISO20022.Sese032002.PartyIdentificationAndAccount209 *-- ISO20022.Sese032002.AlternatePartyIdentification9
    ISO20022.Sese032002.PartyIdentificationAndAccount209 *-- ISO20022.Sese032002.PartyIdentification137Choice
    class ISO20022.Sese032002.PartyTextInformation3 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese032002.PartyTextInformation4 {
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese032002.PendingProcessingReason12 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032002.PendingProcessingReason14Choice
    }
    ISO20022.Sese032002.PendingProcessingReason12 *-- ISO20022.Sese032002.PendingProcessingReason14Choice
    class ISO20022.Sese032002.PendingProcessingReason14Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.PendingProcessingReason14Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.PendingProcessingReason2Code {
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
    class ISO20022.Sese032002.PendingProcessingStatus15Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032002.PendingProcessingReason12~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese032002.PendingProcessingStatus15Choice *-- ISO20022.Sese032002.PendingProcessingReason12
    class ISO20022.Sese032002.PendingReason20 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032002.PendingReason37Choice
    }
    ISO20022.Sese032002.PendingReason20 *-- ISO20022.Sese032002.PendingReason37Choice
    class ISO20022.Sese032002.PendingReason24 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032002.PendingReason41Choice
    }
    ISO20022.Sese032002.PendingReason24 *-- ISO20022.Sese032002.PendingReason41Choice
    class ISO20022.Sese032002.PendingReason2Code {
        INBC = 1
        CDLR = 2
        CVAL = 3
        CSDH = 4
        PRSY = 5
        CERT = 6
        SETS = 7
        REGT = 8
        PRCY = 9
        LIQU = 10
        LATE = 11
        LAAW = 12
        FROZ = 13
        DKNY = 14
        DISA = 15
        DENO = 16
        CLHT = 17
        BOTH = 18
        BENO = 19
        PHCK = 20
        OTHR = 21
        IAAD = 22
        MINO = 23
        CPEC = 24
        SBLO = 25
        CYCL = 26
        BATC = 27
        SDUT = 28
        REFS = 29
        NCON = 30
        MONY = 31
        LALO = 32
        LACK = 33
        FUTU = 34
        LINK = 35
        INCA = 36
        FLIM = 37
        DEPO = 38
        COLL = 39
        YCOL = 40
        CMON = 41
        NOFX = 42
        NMAS = 43
        PART = 44
        PREA = 45
        GLOB = 46
        MUNO = 47
        CLAC = 48
        NEWI = 49
        CHAS = 50
        BLOC = 51
        DOCC = 52
        DOCY = 53
        TAMM = 54
        PHSE = 55
        AWSH = 56
        REFU = 57
        CAIS = 58
        ADEA = 59
        AWMO = 60
    }
    class ISO20022.Sese032002.PendingReason37Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.PendingReason37Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.PendingReason41Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.PendingReason41Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.PendingReason6Code {
        CDRE = 1
        CDCY = 2
        CDRG = 3
        OTHR = 4
        CONF = 5
        ADEA = 6
    }
    class ISO20022.Sese032002.PendingStatus46Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032002.PendingReason20~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese032002.PendingStatus46Choice *-- ISO20022.Sese032002.PendingReason20
    class ISO20022.Sese032002.PendingStatus50Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032002.PendingReason24~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese032002.PendingStatus50Choice *-- ISO20022.Sese032002.PendingReason24
    class ISO20022.Sese032002.PlaceOfClearingIdentification2 {
        + LEI  : String
        + Id  : String
    }
    class ISO20022.Sese032002.PlaceOfTradeIdentification2 {
        + LEI  : String
        + MktTpAndId  : ISO20022.Sese032002.MarketIdentification90
    }
    ISO20022.Sese032002.PlaceOfTradeIdentification2 *-- ISO20022.Sese032002.MarketIdentification90
    class ISO20022.Sese032002.Price11 {
        + Val  : ISO20022.Sese032002.PriceRateOrAmount1Choice
        + Tp  : ISO20022.Sese032002.YieldedOrValueType2Choice
    }
    ISO20022.Sese032002.Price11 *-- ISO20022.Sese032002.PriceRateOrAmount1Choice
    ISO20022.Sese032002.Price11 *-- ISO20022.Sese032002.YieldedOrValueType2Choice
    class ISO20022.Sese032002.Price3 {
        + Val  : ISO20022.Sese032002.PriceRateOrAmount1Choice
        + Tp  : ISO20022.Sese032002.YieldedOrValueType1Choice
    }
    ISO20022.Sese032002.Price3 *-- ISO20022.Sese032002.PriceRateOrAmount1Choice
    ISO20022.Sese032002.Price3 *-- ISO20022.Sese032002.YieldedOrValueType1Choice
    class ISO20022.Sese032002.PriceRateOrAmount1Choice {
        + Amt  : ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Sese032002.PriceRateOrAmount1Choice *-- ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Sese032002.PriceType5Choice {
        + Indctv  : ISO20022.Sese032002.Price3
        + Mkt  : ISO20022.Sese032002.Price3
    }
    ISO20022.Sese032002.PriceType5Choice *-- ISO20022.Sese032002.Price3
    ISO20022.Sese032002.PriceType5Choice *-- ISO20022.Sese032002.Price3
    class ISO20022.Sese032002.PriceValueType12Code {
        NEGA = 1
        PREM = 2
        PARV = 3
        DISC = 4
    }
    class ISO20022.Sese032002.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Sese032002.PriorityNumeric5Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Nmrc  : String
    }
    ISO20022.Sese032002.PriorityNumeric5Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.ProcessingPosition10Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.ProcessingPosition10Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Sese032002.ProcessingStatus62Choice {
        + CxlReqd  : ISO20022.Sese032002.ProprietaryReason5
        + Prtry  : ISO20022.Sese032002.ProprietaryStatusAndReason7
        + PdgCxl  : ISO20022.Sese032002.PendingStatus46Choice
        + Rpr  : ISO20022.Sese032002.RepairStatus16Choice
        + PdgPrcg  : ISO20022.Sese032002.PendingProcessingStatus15Choice
        + AckdAccptd  : ISO20022.Sese032002.AcknowledgedAcceptedStatus25Choice
    }
    ISO20022.Sese032002.ProcessingStatus62Choice *-- ISO20022.Sese032002.ProprietaryReason5
    ISO20022.Sese032002.ProcessingStatus62Choice *-- ISO20022.Sese032002.ProprietaryStatusAndReason7
    ISO20022.Sese032002.ProcessingStatus62Choice *-- ISO20022.Sese032002.PendingStatus46Choice
    ISO20022.Sese032002.ProcessingStatus62Choice *-- ISO20022.Sese032002.RepairStatus16Choice
    ISO20022.Sese032002.ProcessingStatus62Choice *-- ISO20022.Sese032002.PendingProcessingStatus15Choice
    ISO20022.Sese032002.ProcessingStatus62Choice *-- ISO20022.Sese032002.AcknowledgedAcceptedStatus25Choice
    class ISO20022.Sese032002.ProprietaryReason5 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Sese032002.GenericIdentification47
    }
    ISO20022.Sese032002.ProprietaryReason5 *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.ProprietaryStatusAndReason7 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Sese032002.ProprietaryReason5~
        + PrtrySts  : ISO20022.Sese032002.GenericIdentification47
    }
    ISO20022.Sese032002.ProprietaryStatusAndReason7 *-- ISO20022.Sese032002.ProprietaryReason5
    ISO20022.Sese032002.ProprietaryStatusAndReason7 *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.Quantity54Choice {
        + OrgnlAndCurFace  : ISO20022.Sese032002.OriginalAndCurrentQuantities4
        + Qty  : ISO20022.Sese032002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Sese032002.Quantity54Choice *-- ISO20022.Sese032002.OriginalAndCurrentQuantities4
    ISO20022.Sese032002.Quantity54Choice *-- ISO20022.Sese032002.FinancialInstrumentQuantity36Choice
    class ISO20022.Sese032002.QuantityAndAccount104 {
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Sese032002.QuantityBreakdown69~
        + SfkpgPlc  : ISO20022.Sese032002.SafeKeepingPlace4
        + CshAcct  : ISO20022.Sese032002.CashAccountIdentification6Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese032002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese032002.SecuritiesAccount30
        + AcctOwnr  : ISO20022.Sese032002.PartyIdentification156
        + DnmtnChc  : String
        + SttlmQty  : ISO20022.Sese032002.Quantity54Choice
    }
    ISO20022.Sese032002.QuantityAndAccount104 *-- ISO20022.Sese032002.QuantityBreakdown69
    ISO20022.Sese032002.QuantityAndAccount104 *-- ISO20022.Sese032002.SafeKeepingPlace4
    ISO20022.Sese032002.QuantityAndAccount104 *-- ISO20022.Sese032002.CashAccountIdentification6Choice
    ISO20022.Sese032002.QuantityAndAccount104 *-- ISO20022.Sese032002.BlockChainAddressWallet7
    ISO20022.Sese032002.QuantityAndAccount104 *-- ISO20022.Sese032002.SecuritiesAccount30
    ISO20022.Sese032002.QuantityAndAccount104 *-- ISO20022.Sese032002.PartyIdentification156
    ISO20022.Sese032002.QuantityAndAccount104 *-- ISO20022.Sese032002.Quantity54Choice
    class ISO20022.Sese032002.QuantityBreakdown69 {
        + TpOfPric  : ISO20022.Sese032002.TypeOfPrice32Choice
        + LotPric  : ISO20022.Sese032002.Price3
        + LotDtTm  : ISO20022.Sese032002.DateAndDateTime2Choice
        + LotQty  : ISO20022.Sese032002.FinancialInstrumentQuantity36Choice
        + LotNb  : ISO20022.Sese032002.GenericIdentification39
    }
    ISO20022.Sese032002.QuantityBreakdown69 *-- ISO20022.Sese032002.TypeOfPrice32Choice
    ISO20022.Sese032002.QuantityBreakdown69 *-- ISO20022.Sese032002.Price3
    ISO20022.Sese032002.QuantityBreakdown69 *-- ISO20022.Sese032002.DateAndDateTime2Choice
    ISO20022.Sese032002.QuantityBreakdown69 *-- ISO20022.Sese032002.FinancialInstrumentQuantity36Choice
    ISO20022.Sese032002.QuantityBreakdown69 *-- ISO20022.Sese032002.GenericIdentification39
    class ISO20022.Sese032002.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese032002.References78Choice {
        + OthrTxId  : String
        + PoolId  : String
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + IntraBalMvmntId  : String
        + IntraPosMvmntId  : String
        + SctiesSttlmTxId  : String
    }
    class ISO20022.Sese032002.Registration11Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.Registration11Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.Registration12Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.Registration12Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.Registration1Code {
        YREG = 1
        NREG = 2
    }
    class ISO20022.Sese032002.Registration2Code {
        CVAL = 1
        CDEL = 2
        CSDH = 3
        PTYH = 4
    }
    class ISO20022.Sese032002.RegistrationParameters7 {
        + CertNb  : global::System.Collections.Generic.List~ISO20022.Sese032002.SecuritiesCertificate5~
        + RegarAcct  : String
        + CertfctnDtTm  : ISO20022.Sese032002.DateAndDateTime2Choice
        + CertfctnId  : String
    }
    ISO20022.Sese032002.RegistrationParameters7 *-- ISO20022.Sese032002.SecuritiesCertificate5
    ISO20022.Sese032002.RegistrationParameters7 *-- ISO20022.Sese032002.DateAndDateTime2Choice
    class ISO20022.Sese032002.RegistrationReason6 {
        + AddtlInf  : String
        + Cd  : ISO20022.Sese032002.Registration12Choice
    }
    ISO20022.Sese032002.RegistrationReason6 *-- ISO20022.Sese032002.Registration12Choice
    class ISO20022.Sese032002.RepairReason12 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032002.RepairReason14Choice
    }
    ISO20022.Sese032002.RepairReason12 *-- ISO20022.Sese032002.RepairReason14Choice
    class ISO20022.Sese032002.RepairReason14Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.RepairReason14Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.RepairReason4Code {
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
    class ISO20022.Sese032002.RepairStatus16Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032002.RepairReason12~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese032002.RepairStatus16Choice *-- ISO20022.Sese032002.RepairReason12
    class ISO20022.Sese032002.Reporting2Code {
        DEFR = 1
        REGU = 2
        STEX = 3
    }
    class ISO20022.Sese032002.Reporting9Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.Reporting9Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.RepurchaseType10Code {
        WTHD = 1
        TOPU = 2
        CADJ = 3
        CALL = 4
        RATE = 5
        ROLP = 6
        PAIR = 7
    }
    class ISO20022.Sese032002.RepurchaseType26Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.RepurchaseType26Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese032002.Restriction6Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.Restriction6Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.SafeKeepingPlace4 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Sese032002.SafekeepingPlaceFormat39Choice
    }
    ISO20022.Sese032002.SafeKeepingPlace4 *-- ISO20022.Sese032002.SafekeepingPlaceFormat39Choice
    class ISO20022.Sese032002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Sese032002.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Sese032002.SafekeepingPlaceFormat39Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification85
        + TpAndId  : ISO20022.Sese032002.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Sese032002.SafekeepingPlaceTypeAndText15
    }
    ISO20022.Sese032002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese032002.GenericIdentification85
    ISO20022.Sese032002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese032002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Sese032002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese032002.SafekeepingPlaceTypeAndText15
    class ISO20022.Sese032002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese032002.SafekeepingPlaceTypeAndText15 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese032002.SecuritiesAccount30 {
        + Nm  : String
        + Tp  : ISO20022.Sese032002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese032002.SecuritiesAccount30 *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.SecuritiesCertificate5 {
        + SchmeNm  : String
        + Issr  : String
        + Nb  : String
    }
    class ISO20022.Sese032002.SecuritiesPaymentStatus1Code {
        PART = 1
        NILL = 2
        FULL = 3
    }
    class ISO20022.Sese032002.SecuritiesPaymentStatus6Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.SecuritiesPaymentStatus6Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.SecuritiesRTGS5Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese032002.SecuritiesRTGS5Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese032002.SupplementaryData1~
        + StsAndRsn  : ISO20022.Sese032002.StatusAndReason29
        + GnrtdRsn  : global::System.Collections.Generic.List~ISO20022.Sese032002.GeneratedReason6~
        + AddtlPhysOrRegnDtls  : ISO20022.Sese032002.RegistrationParameters7
        + OthrBizPties  : ISO20022.Sese032002.OtherParties44
        + OthrAmts  : ISO20022.Sese032002.OtherAmounts43
        + SttlmAmt  : ISO20022.Sese032002.AmountAndDirection96
        + CshPties  : ISO20022.Sese032002.CashParties38
        + RcvgSttlmPties  : ISO20022.Sese032002.SettlementParties105
        + DlvrgSttlmPties  : ISO20022.Sese032002.SettlementParties105
        + SttlmParams  : ISO20022.Sese032002.SettlementDetails212
        + QtyAndAcctDtls  : global::System.Collections.Generic.List~ISO20022.Sese032002.QuantityAndAccount104~
        + FinInstrmAttrbts  : ISO20022.Sese032002.FinancialInstrumentAttributes122
        + FinInstrmId  : ISO20022.Sese032002.SecurityIdentification20
        + TradDtls  : ISO20022.Sese032002.SecuritiesTradeDetails130
        + Lnkgs  : global::System.Collections.Generic.List~ISO20022.Sese032002.Linkages68~
        + NbCounts  : ISO20022.Sese032002.NumberCount2Choice
        + TxIdDtls  : ISO20022.Sese032002.SettlementTypeAndIdentification28
    }
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.SupplementaryData1
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.StatusAndReason29
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.GeneratedReason6
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.RegistrationParameters7
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.OtherParties44
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.OtherAmounts43
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.AmountAndDirection96
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.CashParties38
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.SettlementParties105
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.SettlementParties105
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.SettlementDetails212
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.QuantityAndAccount104
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.FinancialInstrumentAttributes122
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.SecurityIdentification20
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.SecuritiesTradeDetails130
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.Linkages68
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.NumberCount2Choice
    ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11 *-- ISO20022.Sese032002.SettlementTypeAndIdentification28
    class ISO20022.Sese032002.SecuritiesTradeDetails130 {
        + SttlmInstrPrcgAddtlDtls  : String
        + FxAddtlDtls  : String
        + AffirmSts  : ISO20022.Sese032002.AffirmationStatus9Choice
        + MtchgSts  : ISO20022.Sese032002.MatchingStatus28Choice
        + CcyToBuyOrSell  : ISO20022.Sese032002.CurrencyToBuyOrSell1Choice
        + TpOfPric  : ISO20022.Sese032002.TypeOfPrice32Choice
        + TradOrgtrRole  : ISO20022.Sese032002.TradeOriginator4Choice
        + InvstrCpcty  : ISO20022.Sese032002.InvestorCapacity5Choice
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Sese032002.TradeTransactionCondition6Choice~
        + Rptg  : global::System.Collections.Generic.List~ISO20022.Sese032002.Reporting9Choice~
        + OpngClsg  : ISO20022.Sese032002.OpeningClosing4Choice
        + NbOfDaysAcrd  : Decimal
        + DealPric  : ISO20022.Sese032002.Price11
        + MtchdStsTmStmp  : DateTime
        + AckdStsTmStmp  : DateTime
        + LateDlvryDt  : ISO20022.Sese032002.DateAndDateTime2Choice
        + SttlmDt  : ISO20022.Sese032002.SettlementDate20Choice
        + TradDt  : ISO20022.Sese032002.TradeDate9Choice
        + PlcOfClr  : ISO20022.Sese032002.PlaceOfClearingIdentification2
        + PlcOfTrad  : ISO20022.Sese032002.PlaceOfTradeIdentification2
        + CollTxId  : global::System.Collections.Generic.List~String~
        + TradId  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Sese032002.SecuritiesTradeDetails130 *-- ISO20022.Sese032002.AffirmationStatus9Choice
    ISO20022.Sese032002.SecuritiesTradeDetails130 *-- ISO20022.Sese032002.MatchingStatus28Choice
    ISO20022.Sese032002.SecuritiesTradeDetails130 *-- ISO20022.Sese032002.CurrencyToBuyOrSell1Choice
    ISO20022.Sese032002.SecuritiesTradeDetails130 *-- ISO20022.Sese032002.TypeOfPrice32Choice
    ISO20022.Sese032002.SecuritiesTradeDetails130 *-- ISO20022.Sese032002.TradeOriginator4Choice
    ISO20022.Sese032002.SecuritiesTradeDetails130 *-- ISO20022.Sese032002.InvestorCapacity5Choice
    ISO20022.Sese032002.SecuritiesTradeDetails130 *-- ISO20022.Sese032002.TradeTransactionCondition6Choice
    ISO20022.Sese032002.SecuritiesTradeDetails130 *-- ISO20022.Sese032002.Reporting9Choice
    ISO20022.Sese032002.SecuritiesTradeDetails130 *-- ISO20022.Sese032002.OpeningClosing4Choice
    ISO20022.Sese032002.SecuritiesTradeDetails130 *-- ISO20022.Sese032002.Price11
    ISO20022.Sese032002.SecuritiesTradeDetails130 *-- ISO20022.Sese032002.DateAndDateTime2Choice
    ISO20022.Sese032002.SecuritiesTradeDetails130 *-- ISO20022.Sese032002.SettlementDate20Choice
    ISO20022.Sese032002.SecuritiesTradeDetails130 *-- ISO20022.Sese032002.TradeDate9Choice
    ISO20022.Sese032002.SecuritiesTradeDetails130 *-- ISO20022.Sese032002.PlaceOfClearingIdentification2
    ISO20022.Sese032002.SecuritiesTradeDetails130 *-- ISO20022.Sese032002.PlaceOfTradeIdentification2
    class ISO20022.Sese032002.SecuritiesTransactionType26Code {
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
    class ISO20022.Sese032002.SecuritiesTransactionType52Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.SecuritiesTransactionType52Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese032002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Sese032002.SecurityIdentification20 *-- ISO20022.Sese032002.OtherIdentification2
    class ISO20022.Sese032002.SettlementDate20Choice {
        + DtCd  : ISO20022.Sese032002.SettlementDateCode9Choice
        + Dt  : ISO20022.Sese032002.DateAndDateTime2Choice
    }
    ISO20022.Sese032002.SettlementDate20Choice *-- ISO20022.Sese032002.SettlementDateCode9Choice
    ISO20022.Sese032002.SettlementDate20Choice *-- ISO20022.Sese032002.DateAndDateTime2Choice
    class ISO20022.Sese032002.SettlementDate4Code {
        WISS = 1
    }
    class ISO20022.Sese032002.SettlementDateCode9Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.SettlementDateCode9Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.SettlementDetails212 {
        + CshSubBalTp  : ISO20022.Sese032002.GenericIdentification47
        + SctiesSubBalTp  : ISO20022.Sese032002.GenericIdentification47
        + ElgblForColl  : String
        + ModCxlAllwd  : ISO20022.Sese032002.ModificationCancellationAllowed5Choice
        + RtrLeg  : String
        + LttrOfGrnt  : ISO20022.Sese032002.LetterOfGuarantee5Choice
        + AutomtcBrrwg  : ISO20022.Sese032002.AutomaticBorrowing8Choice
        + Trckg  : ISO20022.Sese032002.Tracking5Choice
        + StmpDtyTaxBsis  : ISO20022.Sese032002.GenericIdentification47
        + TaxCpcty  : ISO20022.Sese032002.TaxCapacityParty5Choice
        + SttlmSysMtd  : ISO20022.Sese032002.SettlementSystemMethod5Choice
        + SttlgCpcty  : ISO20022.Sese032002.SettlingCapacity8Choice
        + SctiesRTGS  : ISO20022.Sese032002.SecuritiesRTGS5Choice
        + LglRstrctns  : ISO20022.Sese032002.Restriction6Choice
        + RpTp  : ISO20022.Sese032002.RepurchaseType26Choice
        + Regn  : ISO20022.Sese032002.Registration11Choice
        + NetgElgblty  : ISO20022.Sese032002.NettingEligibility5Choice
        + MktClntSd  : ISO20022.Sese032002.MarketClientSide7Choice
        + FxStgInstr  : ISO20022.Sese032002.FXStandingInstruction5Choice
        + XpsrTp  : ISO20022.Sese032002.ExposureType24Choice
        + CshClrSys  : ISO20022.Sese032002.CashSettlementSystem5Choice
        + DlvryRtrRsn  : ISO20022.Sese032002.DeliveryReturn4Choice
        + CCPElgblty  : ISO20022.Sese032002.CentralCounterPartyEligibility5Choice
        + BlckTrad  : ISO20022.Sese032002.BlockTrade5Choice
        + BnfclOwnrsh  : ISO20022.Sese032002.BeneficialOwnership5Choice
        + PrtlSttlmInd  : String
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese032002.SettlementTransactionCondition29Choice~
        + SctiesTxTp  : ISO20022.Sese032002.SecuritiesTransactionType52Choice
        + Prty  : ISO20022.Sese032002.PriorityNumeric5Choice
        + HldInd  : ISO20022.Sese032002.HoldIndicator7
    }
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.GenericIdentification47
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.GenericIdentification47
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.ModificationCancellationAllowed5Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.LetterOfGuarantee5Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.AutomaticBorrowing8Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.Tracking5Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.GenericIdentification47
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.TaxCapacityParty5Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.SettlementSystemMethod5Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.SettlingCapacity8Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.SecuritiesRTGS5Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.Restriction6Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.RepurchaseType26Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.Registration11Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.NettingEligibility5Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.MarketClientSide7Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.FXStandingInstruction5Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.ExposureType24Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.CashSettlementSystem5Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.DeliveryReturn4Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.CentralCounterPartyEligibility5Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.BlockTrade5Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.BeneficialOwnership5Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.SettlementTransactionCondition29Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.SecuritiesTransactionType52Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.PriorityNumeric5Choice
    ISO20022.Sese032002.SettlementDetails212 *-- ISO20022.Sese032002.HoldIndicator7
    class ISO20022.Sese032002.SettlementParties105 {
        + Pty5  : ISO20022.Sese032002.PartyIdentificationAndAccount206
        + Pty4  : ISO20022.Sese032002.PartyIdentificationAndAccount206
        + Pty3  : ISO20022.Sese032002.PartyIdentificationAndAccount206
        + Pty2  : ISO20022.Sese032002.PartyIdentificationAndAccount206
        + Pty1  : ISO20022.Sese032002.PartyIdentificationAndAccount206
        + Dpstry  : ISO20022.Sese032002.PartyIdentification162
    }
    ISO20022.Sese032002.SettlementParties105 *-- ISO20022.Sese032002.PartyIdentificationAndAccount206
    ISO20022.Sese032002.SettlementParties105 *-- ISO20022.Sese032002.PartyIdentificationAndAccount206
    ISO20022.Sese032002.SettlementParties105 *-- ISO20022.Sese032002.PartyIdentificationAndAccount206
    ISO20022.Sese032002.SettlementParties105 *-- ISO20022.Sese032002.PartyIdentificationAndAccount206
    ISO20022.Sese032002.SettlementParties105 *-- ISO20022.Sese032002.PartyIdentificationAndAccount206
    ISO20022.Sese032002.SettlementParties105 *-- ISO20022.Sese032002.PartyIdentification162
    class ISO20022.Sese032002.SettlementStatus22Choice {
        + Prtry  : ISO20022.Sese032002.ProprietaryStatusAndReason7
        + Flng  : ISO20022.Sese032002.FailingStatus12Choice
        + Pdg  : ISO20022.Sese032002.PendingStatus50Choice
    }
    ISO20022.Sese032002.SettlementStatus22Choice *-- ISO20022.Sese032002.ProprietaryStatusAndReason7
    ISO20022.Sese032002.SettlementStatus22Choice *-- ISO20022.Sese032002.FailingStatus12Choice
    ISO20022.Sese032002.SettlementStatus22Choice *-- ISO20022.Sese032002.PendingStatus50Choice
    class ISO20022.Sese032002.SettlementSystemMethod1Code {
        YSET = 1
        NSET = 2
    }
    class ISO20022.Sese032002.SettlementSystemMethod5Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.SettlementSystemMethod5Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.SettlementTransactionCondition29Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.SettlementTransactionCondition29Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.SettlementTransactionCondition5Code {
        PARQ = 1
        PARC = 2
        NPAR = 3
        PART = 4
    }
    class ISO20022.Sese032002.SettlementTransactionCondition8Code {
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
    class ISO20022.Sese032002.SettlementTypeAndIdentification28 {
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
    class ISO20022.Sese032002.SettlingCapacity2Code {
        RISP = 1
        SPRI = 2
        CUST = 3
        SAGE = 4
    }
    class ISO20022.Sese032002.SettlingCapacity8Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.SettlingCapacity8Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.StatusAndReason29 {
        + SttlmSts  : ISO20022.Sese032002.SettlementStatus22Choice
        + MtchgSts  : ISO20022.Sese032002.MatchingStatus32Choice
        + IfrrdMtchgSts  : ISO20022.Sese032002.MatchingStatus32Choice
        + PrcgSts  : ISO20022.Sese032002.ProcessingStatus62Choice
    }
    ISO20022.Sese032002.StatusAndReason29 *-- ISO20022.Sese032002.SettlementStatus22Choice
    ISO20022.Sese032002.StatusAndReason29 *-- ISO20022.Sese032002.MatchingStatus32Choice
    ISO20022.Sese032002.StatusAndReason29 *-- ISO20022.Sese032002.MatchingStatus32Choice
    ISO20022.Sese032002.StatusAndReason29 *-- ISO20022.Sese032002.ProcessingStatus62Choice
    class ISO20022.Sese032002.SupplementaryData1 {
        + Envlp  : ISO20022.Sese032002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese032002.SupplementaryData1 *-- ISO20022.Sese032002.SupplementaryDataEnvelope1
    class ISO20022.Sese032002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese032002.TaxCapacityParty5Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.TaxCapacityParty5Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.TaxLiability1Code {
        AGEN = 1
        PRIN = 2
    }
    class ISO20022.Sese032002.TotalNumber2 {
        + TtlOfLkdInstrs  : String
        + CurInstrNb  : String
    }
    class ISO20022.Sese032002.Tracking5Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese032002.Tracking5Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.TradeDate9Choice {
        + DtCd  : ISO20022.Sese032002.TradeDateCode4Choice
        + Dt  : ISO20022.Sese032002.DateAndDateTime2Choice
    }
    ISO20022.Sese032002.TradeDate9Choice *-- ISO20022.Sese032002.TradeDateCode4Choice
    ISO20022.Sese032002.TradeDate9Choice *-- ISO20022.Sese032002.DateAndDateTime2Choice
    class ISO20022.Sese032002.TradeDateCode4Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.TradeDateCode4Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.TradeOriginator4Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.TradeOriginator4Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.TradeTransactionCondition4Code {
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
    class ISO20022.Sese032002.TradeTransactionCondition6Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.TradeTransactionCondition6Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Sese032002.TypeOfPrice14Code {
        AVER = 1
    }
    class ISO20022.Sese032002.TypeOfPrice32Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.TypeOfPrice32Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.UnmatchedReason11Code {
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
    class ISO20022.Sese032002.UnmatchedReason20 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese032002.UnmatchedReason27Choice
    }
    ISO20022.Sese032002.UnmatchedReason20 *-- ISO20022.Sese032002.UnmatchedReason27Choice
    class ISO20022.Sese032002.UnmatchedReason27Choice {
        + Prtry  : ISO20022.Sese032002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese032002.UnmatchedReason27Choice *-- ISO20022.Sese032002.GenericIdentification47
    class ISO20022.Sese032002.UnmatchedStatus21Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese032002.UnmatchedReason20~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese032002.UnmatchedStatus21Choice *-- ISO20022.Sese032002.UnmatchedReason20
    class ISO20022.Sese032002.YieldedOrValueType1Choice {
        + ValTp  : String
        + Yldd  : String
    }
    class ISO20022.Sese032002.YieldedOrValueType2Choice {
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

## Value ISO20022.Sese032002.AcknowledgedAcceptedStatus25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032002.AcknowledgementReason13>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese032002.AcknowledgementReason13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032002.AcknowledgementReason16Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese032002.AcknowledgementReason16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.AcknowledgementReason5Code


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

## Value ISO20022.Sese032002.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese032002.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese032002.AffirmationStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NAFI|Int32||XmlEnum("""NAFI""")|1|
||AFFI|Int32||XmlEnum("""AFFI""")|2|

---

## Value ISO20022.Sese032002.AffirmationStatus9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.AlternatePartyIdentification9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Sese032002.IdentificationType44Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AltrnId""",AltrnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Sese032002.AmountAndDirection44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Sese032002.ForeignExchangeTerms23||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese032002.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese032002.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese032002.AmountAndDirection58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Sese032002.ForeignExchangeTerms27||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese032002.AmountAndDirection96


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValDt|ISO20022.Sese032002.DateAndDateTime2Choice||XmlElement()||
|+|FXDtls|ISO20022.Sese032002.ForeignExchangeTerms27||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese032002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|RsrchFeeInd|String||XmlElement()||
|+|BrkrgAmtInd|String||XmlElement()||
|+|StmpDtyInd|String||XmlElement()||
|+|AcrdIntrstInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValDt),validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Enum ISO20022.Sese032002.AutoBorrowing1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YBOR|Int32||XmlEnum("""YBOR""")|1|
||NBOR|Int32||XmlEnum("""NBOR""")|2|
||LAMI|Int32||XmlEnum("""LAMI""")|3|

---

## Value ISO20022.Sese032002.AutomaticBorrowing8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.BeneficialOwnership5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese032002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Enum ISO20022.Sese032002.BlockTrade1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BLCH|Int32||XmlEnum("""BLCH""")|1|
||BLPA|Int32||XmlEnum("""BLPA""")|2|

---

## Value ISO20022.Sese032002.BlockTrade5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.CashAccountIdentification6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,34}"""),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Value ISO20022.Sese032002.CashParties38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Intrmy|ISO20022.Sese032002.PartyIdentificationAndAccount178||XmlElement()||
|+|CdtrAgt|ISO20022.Sese032002.PartyIdentificationAndAccount178||XmlElement()||
|+|Cdtr|ISO20022.Sese032002.PartyIdentificationAndAccount177||XmlElement()||
|+|DbtrAgt|ISO20022.Sese032002.PartyIdentificationAndAccount178||XmlElement()||
|+|Dbtr|ISO20022.Sese032002.PartyIdentificationAndAccount177||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Intrmy),validElement(CdtrAgt),validElement(Cdtr),validElement(DbtrAgt),validElement(Dbtr))|

---

## Enum ISO20022.Sese032002.CashSettlementSystem2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETS|Int32||XmlEnum("""NETS""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Value ISO20022.Sese032002.CashSettlementSystem5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.CentralCounterPartyEligibility5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese032002.ClassificationType33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Sese032002.GenericIdentification86||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Enum ISO20022.Sese032002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese032002.CurrencyToBuyOrSell1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyToSell|String||XmlElement()||
|+|CcyToBuy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CcyToSell""",CcyToSell,"""[A-Z]{3,3}"""),validPattern("""CcyToBuy""",CcyToBuy,"""[A-Z]{3,3}"""),validChoice(CcyToSell,CcyToBuy))|

---

## Value ISO20022.Sese032002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Sese032002.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese032002.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Enum ISO20022.Sese032002.DeliveryReturn1Code


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

## Value ISO20022.Sese032002.DeliveryReturn4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Type ISO20022.Sese032002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmTxGnrtnNtfctn|ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmTxGnrtnNtfctn))|

---

## Value ISO20022.Sese032002.DocumentNumber6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Sese032002.GenericIdentification86||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Enum ISO20022.Sese032002.Eligibility1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROF|Int32||XmlEnum("""PROF""")|1|
||RETL|Int32||XmlEnum("""RETL""")|2|
||ELIG|Int32||XmlEnum("""ELIG""")|3|

---

## Enum ISO20022.Sese032002.EventFrequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||SEMI|Int32||XmlEnum("""SEMI""")|2|
||QUTR|Int32||XmlEnum("""QUTR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|

---

## Enum ISO20022.Sese032002.ExposureType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRCP|Int32||XmlEnum("""TRCP""")|1|
||UDMS|Int32||XmlEnum("""UDMS""")|2|
||TBAS|Int32||XmlEnum("""TBAS""")|3|
||SWPT|Int32||XmlEnum("""SWPT""")|4|
||SCIE|Int32||XmlEnum("""SCIE""")|5|
||SCIR|Int32||XmlEnum("""SCIR""")|6|
||SHSL|Int32||XmlEnum("""SHSL""")|7|
||SLEB|Int32||XmlEnum("""SLEB""")|8|
||SCRP|Int32||XmlEnum("""SCRP""")|9|
||SBSC|Int32||XmlEnum("""SBSC""")|10|
||SLOA|Int32||XmlEnum("""SLOA""")|11|
||RVPO|Int32||XmlEnum("""RVPO""")|12|
||REPO|Int32||XmlEnum("""REPO""")|13|
||OTCD|Int32||XmlEnum("""OTCD""")|14|
||LIQU|Int32||XmlEnum("""LIQU""")|15|
||OPTN|Int32||XmlEnum("""OPTN""")|16|
||FUTR|Int32||XmlEnum("""FUTR""")|17|
||FORW|Int32||XmlEnum("""FORW""")|18|
||FORX|Int32||XmlEnum("""FORX""")|19|
||FIXI|Int32||XmlEnum("""FIXI""")|20|
||EXPT|Int32||XmlEnum("""EXPT""")|21|
||EQUS|Int32||XmlEnum("""EQUS""")|22|
||EXTD|Int32||XmlEnum("""EXTD""")|23|
||EQPT|Int32||XmlEnum("""EQPT""")|24|
||CRPR|Int32||XmlEnum("""CRPR""")|25|
||CCIR|Int32||XmlEnum("""CCIR""")|26|
||CRSP|Int32||XmlEnum("""CRSP""")|27|
||CRTL|Int32||XmlEnum("""CRTL""")|28|
||CRDS|Int32||XmlEnum("""CRDS""")|29|
||COMM|Int32||XmlEnum("""COMM""")|30|
||CCPC|Int32||XmlEnum("""CCPC""")|31|
||PAYM|Int32||XmlEnum("""PAYM""")|32|
||BFWD|Int32||XmlEnum("""BFWD""")|33|

---

## Value ISO20022.Sese032002.ExposureType24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.FXStandingInstruction5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese032002.FailingReason10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032002.FailingReason11Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese032002.FailingReason11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.FailingReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INBC|Int32||XmlEnum("""INBC""")|1|
||CVAL|Int32||XmlEnum("""CVAL""")|2|
||CSDH|Int32||XmlEnum("""CSDH""")|3|
||CDLR|Int32||XmlEnum("""CDLR""")|4|
||PRSY|Int32||XmlEnum("""PRSY""")|5|
||CERT|Int32||XmlEnum("""CERT""")|6|
||SETS|Int32||XmlEnum("""SETS""")|7|
||REGT|Int32||XmlEnum("""REGT""")|8|
||PRCY|Int32||XmlEnum("""PRCY""")|9|
||LIQU|Int32||XmlEnum("""LIQU""")|10|
||LATE|Int32||XmlEnum("""LATE""")|11|
||LAAW|Int32||XmlEnum("""LAAW""")|12|
||FROZ|Int32||XmlEnum("""FROZ""")|13|
||DKNY|Int32||XmlEnum("""DKNY""")|14|
||DISA|Int32||XmlEnum("""DISA""")|15|
||DENO|Int32||XmlEnum("""DENO""")|16|
||CLHT|Int32||XmlEnum("""CLHT""")|17|
||BOTH|Int32||XmlEnum("""BOTH""")|18|
||BENO|Int32||XmlEnum("""BENO""")|19|
||PHCK|Int32||XmlEnum("""PHCK""")|20|
||OTHR|Int32||XmlEnum("""OTHR""")|21|
||IAAD|Int32||XmlEnum("""IAAD""")|22|
||MINO|Int32||XmlEnum("""MINO""")|23|
||CPEC|Int32||XmlEnum("""CPEC""")|24|
||SBLO|Int32||XmlEnum("""SBLO""")|25|
||CYCL|Int32||XmlEnum("""CYCL""")|26|
||BATC|Int32||XmlEnum("""BATC""")|27|
||SDUT|Int32||XmlEnum("""SDUT""")|28|
||REFS|Int32||XmlEnum("""REFS""")|29|
||NCON|Int32||XmlEnum("""NCON""")|30|
||MONY|Int32||XmlEnum("""MONY""")|31|
||LALO|Int32||XmlEnum("""LALO""")|32|
||LACK|Int32||XmlEnum("""LACK""")|33|
||LINK|Int32||XmlEnum("""LINK""")|34|
||INCA|Int32||XmlEnum("""INCA""")|35|
||FLIM|Int32||XmlEnum("""FLIM""")|36|
||DEPO|Int32||XmlEnum("""DEPO""")|37|
||COLL|Int32||XmlEnum("""COLL""")|38|
||YCOL|Int32||XmlEnum("""YCOL""")|39|
||CMON|Int32||XmlEnum("""CMON""")|40|
||NOFX|Int32||XmlEnum("""NOFX""")|41|
||PART|Int32||XmlEnum("""PART""")|42|
||PREA|Int32||XmlEnum("""PREA""")|43|
||GLOB|Int32||XmlEnum("""GLOB""")|44|
||MUNO|Int32||XmlEnum("""MUNO""")|45|
||CLAC|Int32||XmlEnum("""CLAC""")|46|
||NEWI|Int32||XmlEnum("""NEWI""")|47|
||CHAS|Int32||XmlEnum("""CHAS""")|48|
||BLOC|Int32||XmlEnum("""BLOC""")|49|
||DOCC|Int32||XmlEnum("""DOCC""")|50|
||MLAT|Int32||XmlEnum("""MLAT""")|51|
||DOCY|Int32||XmlEnum("""DOCY""")|52|
||STCD|Int32||XmlEnum("""STCD""")|53|
||PHSE|Int32||XmlEnum("""PHSE""")|54|
||AWSH|Int32||XmlEnum("""AWSH""")|55|
||OBJT|Int32||XmlEnum("""OBJT""")|56|
||CAIS|Int32||XmlEnum("""CAIS""")|57|
||CANR|Int32||XmlEnum("""CANR""")|58|
||ADEA|Int32||XmlEnum("""ADEA""")|59|
||CLAT|Int32||XmlEnum("""CLAT""")|60|
||BYIY|Int32||XmlEnum("""BYIY""")|61|
||AWMO|Int32||XmlEnum("""AWMO""")|62|

---

## Value ISO20022.Sese032002.FailingStatus12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032002.FailingReason10>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese032002.FinancialInstrumentAttributes122


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmAttrAddtlDtls|String||XmlElement()||
|+|UndrlygFinInstrmId|global::System.Collections.Generic.List<ISO20022.Sese032002.SecurityIdentification20>||XmlElement()||
|+|CtrctSz|ISO20022.Sese032002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Sese032002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|StrkPric|ISO20022.Sese032002.Price3||XmlElement()||
|+|ConvsPric|ISO20022.Sese032002.Price3||XmlElement()||
|+|SbcptPric|ISO20022.Sese032002.Price3||XmlElement()||
|+|ExrcPric|ISO20022.Sese032002.Price3||XmlElement()||
|+|MktOrIndctvPric|ISO20022.Sese032002.PriceType5Choice||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|PoolNb|ISO20022.Sese032002.GenericIdentification39||XmlElement()||
|+|CpnAttchdNb|ISO20022.Sese032002.Number23Choice||XmlElement()||
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
|+|OptnTp|ISO20022.Sese032002.OptionType7Choice||XmlElement()||
|+|OptnStyle|ISO20022.Sese032002.OptionStyle9Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Sese032002.ClassificationType33Choice||XmlElement()||
|+|VarblRateChngFrqcy|ISO20022.Sese032002.Frequency27Choice||XmlElement()||
|+|PmtSts|ISO20022.Sese032002.SecuritiesPaymentStatus6Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Sese032002.Frequency27Choice||XmlElement()||
|+|RegnForm|ISO20022.Sese032002.FormOfSecurity7Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Sese032002.InterestComputationMethodFormat5Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Sese032002.MarketIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FinInstrmAttrAddtlDtls""",FinInstrmAttrAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validList("""UndrlygFinInstrmId""",UndrlygFinInstrmId),validElement(UndrlygFinInstrmId),validElement(CtrctSz),validElement(MinNmnlQty),validElement(StrkPric),validElement(ConvsPric),validElement(SbcptPric),validElement(ExrcPric),validElement(MktOrIndctvPric),validElement(PoolNb),validElement(CpnAttchdNb),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnTp),validElement(OptnStyle),validElement(ClssfctnTp),validElement(VarblRateChngFrqcy),validElement(PmtSts),validElement(PmtFrqcy),validElement(RegnForm),validElement(DayCntBsis),validElement(PlcOfListg))|

---

## Value ISO20022.Sese032002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese032002.ForeignExchangeTerms23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Sese032002.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese032002.ForeignExchangeTerms27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Sese032002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese032002.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Sese032002.FormOfSecurity7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.Frequency27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.GeneratedReason3Code


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

## Value ISO20022.Sese032002.GeneratedReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032002.GeneratedReasons6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese032002.GeneratedReasons6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.GenericIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese032002.GenericIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""([^/]+/)+([^/]+)\|([^/]*)"""),validPattern("""Id""",Id,"""([^/]+/)+([^/]+)\|([^/]*)"""))|

---

## Value ISO20022.Sese032002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese032002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese032002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Sese032002.GenericIdentification86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese032002.HoldIndicator7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032002.RegistrationReason6>||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rsn""",Rsn),validElement(Rsn))|

---

## Value ISO20022.Sese032002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.IdentificationType44Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.InterestComputationMethod2Code


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

## Value ISO20022.Sese032002.InterestComputationMethodFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.InvestorCapacity5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.LetterOfGuarantee5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese032002.Linkages68


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefOwnr|ISO20022.Sese032002.PartyIdentification136Choice||XmlElement()||
|+|LkdQty|ISO20022.Sese032002.PairedOrTurnedQuantity6Choice||XmlElement()||
|+|Ref|ISO20022.Sese032002.References78Choice||XmlElement()||
|+|MsgNb|ISO20022.Sese032002.DocumentNumber6Choice||XmlElement()||
|+|PrcgPos|ISO20022.Sese032002.ProcessingPosition10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefOwnr),validElement(LkdQty),validElement(Ref),validElement(MsgNb),validElement(PrcgPos))|

---

## Enum ISO20022.Sese032002.MarketClientSide1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MAKT|Int32||XmlEnum("""MAKT""")|1|
||CLNT|Int32||XmlEnum("""CLNT""")|2|

---

## Value ISO20022.Sese032002.MarketClientSide7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.MarketIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese032002.MarketIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese032002.MarketIdentification90


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese032002.MarketType16Choice||XmlElement()||
|+|Id|ISO20022.Sese032002.MarketIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Sese032002.MarketType16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Enum ISO20022.Sese032002.MatchingStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NMAT|Int32||XmlEnum("""NMAT""")|1|
||MACH|Int32||XmlEnum("""MACH""")|2|

---

## Value ISO20022.Sese032002.MatchingStatus28Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.MatchingStatus32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.ProprietaryStatusAndReason7||XmlElement()||
|+|Umtchd|ISO20022.Sese032002.UnmatchedStatus21Choice||XmlElement()||
|+|Mtchd|ISO20022.Sese032002.ProprietaryReason5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Umtchd),validElement(Mtchd),validChoice(Prtry,Umtchd,Mtchd))|

---

## Value ISO20022.Sese032002.ModificationCancellationAllowed5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese032002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Sese032002.NettingEligibility5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Enum ISO20022.Sese032002.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Sese032002.Number23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|ISO20022.Sese032002.GenericIdentification18||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lng),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Value ISO20022.Sese032002.NumberCount2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlNb|ISO20022.Sese032002.TotalNumber2||XmlElement()||
|+|CurInstrNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlNb),validPattern("""CurInstrNb""",CurInstrNb,"""[0-9]{1,6}"""),validChoice(TtlNb,CurInstrNb))|

---

## Enum ISO20022.Sese032002.OpeningClosing1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEP|Int32||XmlEnum("""OPEP""")|1|
||CLOP|Int32||XmlEnum("""CLOP""")|2|

---

## Value ISO20022.Sese032002.OpeningClosing4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Sese032002.OptionStyle9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Sese032002.OptionType7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.OriginalAndCurrentQuantities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Sese032002.OriginatorRole2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAGT|Int32||XmlEnum("""TAGT""")|1|
||INVE|Int32||XmlEnum("""INVE""")|2|
||MKTM|Int32||XmlEnum("""MKTM""")|3|
||RMKT|Int32||XmlEnum("""RMKT""")|4|
||MLTF|Int32||XmlEnum("""MLTF""")|5|
||SINT|Int32||XmlEnum("""SINT""")|6|

---

## Value ISO20022.Sese032002.OtherAmounts43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsrchFee|ISO20022.Sese032002.AmountAndDirection44||XmlElement()||
|+|AcrdCptlstnAmt|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|CsmptnTax|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|NetGnLoss|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|WhldgTax|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|ValAddedTax|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|TxTax|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|TrfTax|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|StockXchgTax|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|StmpDty|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|SpclCncssn|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|ShppgAmt|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|RgltryAmt|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|Othr|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|Mrgn|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|LclBrkrComssn|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|LclTaxCtrySpcfc|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|LclTax|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|PmtLevyTax|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|IsseDscntAllwnc|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|ExctgBrkrAmt|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|TradAmt|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|CtryNtlFdrlTax|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|ChrgsFees|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Sese032002.AmountAndDirection58||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsrchFee),validElement(AcrdCptlstnAmt),validElement(CsmptnTax),validElement(NetGnLoss),validElement(WhldgTax),validElement(ValAddedTax),validElement(TxTax),validElement(TrfTax),validElement(StockXchgTax),validElement(StmpDty),validElement(SpclCncssn),validElement(ShppgAmt),validElement(RgltryAmt),validElement(Othr),validElement(Mrgn),validElement(LclBrkrComssn),validElement(LclTaxCtrySpcfc),validElement(LclTax),validElement(PmtLevyTax),validElement(IsseDscntAllwnc),validElement(ExctgBrkrAmt),validElement(TradAmt),validElement(CtryNtlFdrlTax),validElement(ChrgsFees),validElement(AcrdIntrstAmt))|

---

## Value ISO20022.Sese032002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese032002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Sese032002.OtherParties44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Brkr|ISO20022.Sese032002.PartyIdentificationAndAccount209||XmlElement()||
|+|TrptyAgt|ISO20022.Sese032002.PartyIdentificationAndAccount209||XmlElement()||
|+|TradRgltr|ISO20022.Sese032002.PartyIdentificationAndAccount181||XmlElement()||
|+|StockXchg|ISO20022.Sese032002.PartyIdentificationAndAccount181||XmlElement()||
|+|QlfdFrgnIntrmy|ISO20022.Sese032002.PartyIdentificationAndAccount209||XmlElement()||
|+|Invstr|global::System.Collections.Generic.List<ISO20022.Sese032002.PartyIdentificationAndAccount208>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Brkr),validElement(TrptyAgt),validElement(TradRgltr),validElement(StockXchg),validElement(QlfdFrgnIntrmy),validList("""Invstr""",Invstr),validElement(Invstr))|

---

## Enum ISO20022.Sese032002.OwnershipLegalRestrictions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSTR|Int32||XmlEnum("""RSTR""")|1|
||NRST|Int32||XmlEnum("""NRST""")|2|
||A144|Int32||XmlEnum("""A144""")|3|

---

## Value ISO20022.Sese032002.PairedOrTurnedQuantity6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrndQty|ISO20022.Sese032002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|PairdOffQty|ISO20022.Sese032002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrndQty),validElement(PairdOffQty),validChoice(TrndQty,PairdOffQty))|

---

## Value ISO20022.Sese032002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese032002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese032002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese032002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese032002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese032002.PartyIdentification145Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese032002.NameAndAddress12||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese032002.PartyIdentification147Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese032002.GenericIdentification84||XmlElement()||
|+|NmAndAdr|ISO20022.Sese032002.NameAndAddress12||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validElement(NmAndAdr),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,NmAndAdr,BICFI))|

---

## Value ISO20022.Sese032002.PartyIdentification156


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032002.PartyIdentification136Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032002.PartyIdentification162


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese032002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese032002.DateAndDateTime2Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese032002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032002.PartyIdentification145Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(PrcgDt),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032002.PartyIdentificationAndAccount177


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese032002.PartyTextInformation4||XmlElement()||
|+|TaxAcct|ISO20022.Sese032002.CashAccountIdentification6Choice||XmlElement()||
|+|ComssnAcct|ISO20022.Sese032002.CashAccountIdentification6Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Sese032002.CashAccountIdentification6Choice||XmlElement()||
|+|CshAcct|ISO20022.Sese032002.CashAccountIdentification6Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese032002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(TaxAcct),validElement(ComssnAcct),validElement(ChrgsAcct),validElement(CshAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032002.PartyIdentificationAndAccount178


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese032002.PartyTextInformation4||XmlElement()||
|+|TaxAcct|ISO20022.Sese032002.CashAccountIdentification6Choice||XmlElement()||
|+|ComssnAcct|ISO20022.Sese032002.CashAccountIdentification6Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Sese032002.CashAccountIdentification6Choice||XmlElement()||
|+|CshAcct|ISO20022.Sese032002.CashAccountIdentification6Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese032002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032002.PartyIdentification147Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(TaxAcct),validElement(ComssnAcct),validElement(ChrgsAcct),validElement(CshAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032002.PartyIdentificationAndAccount181


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese032002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|AltrnId|ISO20022.Sese032002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032002.PartyIdentificationAndAccount206


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese032002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese032002.DateAndDateTime2Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese032002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese032002.SecuritiesAccount30||XmlElement()||
|+|AltrnId|ISO20022.Sese032002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(PrcgDt),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032002.PartyIdentificationAndAccount208


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese032002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|Ntlty|String||XmlElement()||
|+|AltrnId|ISO20022.Sese032002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""BlckChainAdrOrWllt""",BlckChainAdrOrWllt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""SfkpgAcct""",SfkpgAcct,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validPattern("""Ntlty""",Ntlty,"""[A-Z]{2,2}"""),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032002.PartyIdentificationAndAccount209


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese032002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|AltrnId|ISO20022.Sese032002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese032002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""BlckChainAdrOrWllt""",BlckChainAdrOrWllt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""SfkpgAcct""",SfkpgAcct,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese032002.PartyTextInformation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RegnDtls""",RegnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""PtyCtctDtls""",PtyCtctDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""DclrtnDtls""",DclrtnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Value ISO20022.Sese032002.PartyTextInformation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PtyCtctDtls""",PtyCtctDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""DclrtnDtls""",DclrtnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Value ISO20022.Sese032002.PendingProcessingReason12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032002.PendingProcessingReason14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese032002.PendingProcessingReason14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.PendingProcessingReason2Code


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

## Value ISO20022.Sese032002.PendingProcessingStatus15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032002.PendingProcessingReason12>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese032002.PendingReason20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032002.PendingReason37Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese032002.PendingReason24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032002.PendingReason41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Enum ISO20022.Sese032002.PendingReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INBC|Int32||XmlEnum("""INBC""")|1|
||CDLR|Int32||XmlEnum("""CDLR""")|2|
||CVAL|Int32||XmlEnum("""CVAL""")|3|
||CSDH|Int32||XmlEnum("""CSDH""")|4|
||PRSY|Int32||XmlEnum("""PRSY""")|5|
||CERT|Int32||XmlEnum("""CERT""")|6|
||SETS|Int32||XmlEnum("""SETS""")|7|
||REGT|Int32||XmlEnum("""REGT""")|8|
||PRCY|Int32||XmlEnum("""PRCY""")|9|
||LIQU|Int32||XmlEnum("""LIQU""")|10|
||LATE|Int32||XmlEnum("""LATE""")|11|
||LAAW|Int32||XmlEnum("""LAAW""")|12|
||FROZ|Int32||XmlEnum("""FROZ""")|13|
||DKNY|Int32||XmlEnum("""DKNY""")|14|
||DISA|Int32||XmlEnum("""DISA""")|15|
||DENO|Int32||XmlEnum("""DENO""")|16|
||CLHT|Int32||XmlEnum("""CLHT""")|17|
||BOTH|Int32||XmlEnum("""BOTH""")|18|
||BENO|Int32||XmlEnum("""BENO""")|19|
||PHCK|Int32||XmlEnum("""PHCK""")|20|
||OTHR|Int32||XmlEnum("""OTHR""")|21|
||IAAD|Int32||XmlEnum("""IAAD""")|22|
||MINO|Int32||XmlEnum("""MINO""")|23|
||CPEC|Int32||XmlEnum("""CPEC""")|24|
||SBLO|Int32||XmlEnum("""SBLO""")|25|
||CYCL|Int32||XmlEnum("""CYCL""")|26|
||BATC|Int32||XmlEnum("""BATC""")|27|
||SDUT|Int32||XmlEnum("""SDUT""")|28|
||REFS|Int32||XmlEnum("""REFS""")|29|
||NCON|Int32||XmlEnum("""NCON""")|30|
||MONY|Int32||XmlEnum("""MONY""")|31|
||LALO|Int32||XmlEnum("""LALO""")|32|
||LACK|Int32||XmlEnum("""LACK""")|33|
||FUTU|Int32||XmlEnum("""FUTU""")|34|
||LINK|Int32||XmlEnum("""LINK""")|35|
||INCA|Int32||XmlEnum("""INCA""")|36|
||FLIM|Int32||XmlEnum("""FLIM""")|37|
||DEPO|Int32||XmlEnum("""DEPO""")|38|
||COLL|Int32||XmlEnum("""COLL""")|39|
||YCOL|Int32||XmlEnum("""YCOL""")|40|
||CMON|Int32||XmlEnum("""CMON""")|41|
||NOFX|Int32||XmlEnum("""NOFX""")|42|
||NMAS|Int32||XmlEnum("""NMAS""")|43|
||PART|Int32||XmlEnum("""PART""")|44|
||PREA|Int32||XmlEnum("""PREA""")|45|
||GLOB|Int32||XmlEnum("""GLOB""")|46|
||MUNO|Int32||XmlEnum("""MUNO""")|47|
||CLAC|Int32||XmlEnum("""CLAC""")|48|
||NEWI|Int32||XmlEnum("""NEWI""")|49|
||CHAS|Int32||XmlEnum("""CHAS""")|50|
||BLOC|Int32||XmlEnum("""BLOC""")|51|
||DOCC|Int32||XmlEnum("""DOCC""")|52|
||DOCY|Int32||XmlEnum("""DOCY""")|53|
||TAMM|Int32||XmlEnum("""TAMM""")|54|
||PHSE|Int32||XmlEnum("""PHSE""")|55|
||AWSH|Int32||XmlEnum("""AWSH""")|56|
||REFU|Int32||XmlEnum("""REFU""")|57|
||CAIS|Int32||XmlEnum("""CAIS""")|58|
||ADEA|Int32||XmlEnum("""ADEA""")|59|
||AWMO|Int32||XmlEnum("""AWMO""")|60|

---

## Value ISO20022.Sese032002.PendingReason37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.PendingReason41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.PendingReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDRE|Int32||XmlEnum("""CDRE""")|1|
||CDCY|Int32||XmlEnum("""CDCY""")|2|
||CDRG|Int32||XmlEnum("""CDRG""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||CONF|Int32||XmlEnum("""CONF""")|5|
||ADEA|Int32||XmlEnum("""ADEA""")|6|

---

## Value ISO20022.Sese032002.PendingStatus46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032002.PendingReason20>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese032002.PendingStatus50Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032002.PendingReason24>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese032002.PlaceOfClearingIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese032002.PlaceOfTradeIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|MktTpAndId|ISO20022.Sese032002.MarketIdentification90||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(MktTpAndId))|

---

## Value ISO20022.Sese032002.Price11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Sese032002.PriceRateOrAmount1Choice||XmlElement()||
|+|Tp|ISO20022.Sese032002.YieldedOrValueType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Sese032002.Price3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Sese032002.PriceRateOrAmount1Choice||XmlElement()||
|+|Tp|ISO20022.Sese032002.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Sese032002.PriceRateOrAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Sese032002.PriceType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indctv|ISO20022.Sese032002.Price3||XmlElement()||
|+|Mkt|ISO20022.Sese032002.Price3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indctv),validElement(Mkt),validChoice(Indctv,Mkt))|

---

## Enum ISO20022.Sese032002.PriceValueType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NEGA|Int32||XmlEnum("""NEGA""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||PARV|Int32||XmlEnum("""PARV""")|3|
||DISC|Int32||XmlEnum("""DISC""")|4|

---

## Enum ISO20022.Sese032002.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Sese032002.PriorityNumeric5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Nmrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""Nmrc""",Nmrc,"""[0-9]{4}"""),validChoice(Prtry,Nmrc))|

---

## Value ISO20022.Sese032002.ProcessingPosition10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Sese032002.ProcessingStatus62Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CxlReqd|ISO20022.Sese032002.ProprietaryReason5||XmlElement()||
|+|Prtry|ISO20022.Sese032002.ProprietaryStatusAndReason7||XmlElement()||
|+|PdgCxl|ISO20022.Sese032002.PendingStatus46Choice||XmlElement()||
|+|Rpr|ISO20022.Sese032002.RepairStatus16Choice||XmlElement()||
|+|PdgPrcg|ISO20022.Sese032002.PendingProcessingStatus15Choice||XmlElement()||
|+|AckdAccptd|ISO20022.Sese032002.AcknowledgedAcceptedStatus25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CxlReqd),validElement(Prtry),validElement(PdgCxl),validElement(Rpr),validElement(PdgPrcg),validElement(AckdAccptd),validChoice(CxlReqd,Prtry,PdgCxl,Rpr,PdgPrcg,AckdAccptd))|

---

## Value ISO20022.Sese032002.ProprietaryReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Rsn))|

---

## Value ISO20022.Sese032002.ProprietaryStatusAndReason7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Sese032002.ProprietaryReason5>||XmlElement()||
|+|PrtrySts|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Sese032002.Quantity54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Sese032002.OriginalAndCurrentQuantities4||XmlElement()||
|+|Qty|ISO20022.Sese032002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Sese032002.QuantityAndAccount104


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Sese032002.QuantityBreakdown69>||XmlElement()||
|+|SfkpgPlc|ISO20022.Sese032002.SafeKeepingPlace4||XmlElement()||
|+|CshAcct|ISO20022.Sese032002.CashAccountIdentification6Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese032002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese032002.SecuritiesAccount30||XmlElement()||
|+|AcctOwnr|ISO20022.Sese032002.PartyIdentification156||XmlElement()||
|+|DnmtnChc|String||XmlElement()||
|+|SttlmQty|ISO20022.Sese032002.Quantity54Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(SfkpgPlc),validElement(CshAcct),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validPattern("""DnmtnChc""",DnmtnChc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(SttlmQty))|

---

## Value ISO20022.Sese032002.QuantityBreakdown69


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TpOfPric|ISO20022.Sese032002.TypeOfPrice32Choice||XmlElement()||
|+|LotPric|ISO20022.Sese032002.Price3||XmlElement()||
|+|LotDtTm|ISO20022.Sese032002.DateAndDateTime2Choice||XmlElement()||
|+|LotQty|ISO20022.Sese032002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|LotNb|ISO20022.Sese032002.GenericIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TpOfPric),validElement(LotPric),validElement(LotDtTm),validElement(LotQty),validElement(LotNb))|

---

## Enum ISO20022.Sese032002.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Sese032002.References78Choice


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
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""OthrTxId""",OthrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""PoolId""",PoolId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CtrPtyMktInfrstrctrTxId""",CtrPtyMktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktInfrstrctrTxId""",MktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrTxId""",AcctSvcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""IntraBalMvmntId""",IntraBalMvmntId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""IntraPosMvmntId""",IntraPosMvmntId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""SctiesSttlmTxId""",SctiesSttlmTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validChoice(OthrTxId,PoolId,CtrPtyMktInfrstrctrTxId,MktInfrstrctrTxId,AcctSvcrTxId,IntraBalMvmntId,IntraPosMvmntId,SctiesSttlmTxId))|

---

## Value ISO20022.Sese032002.Registration11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.Registration12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.Registration1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YREG|Int32||XmlEnum("""YREG""")|1|
||NREG|Int32||XmlEnum("""NREG""")|2|

---

## Enum ISO20022.Sese032002.Registration2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CVAL|Int32||XmlEnum("""CVAL""")|1|
||CDEL|Int32||XmlEnum("""CDEL""")|2|
||CSDH|Int32||XmlEnum("""CSDH""")|3|
||PTYH|Int32||XmlEnum("""PTYH""")|4|

---

## Value ISO20022.Sese032002.RegistrationParameters7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertNb|global::System.Collections.Generic.List<ISO20022.Sese032002.SecuritiesCertificate5>||XmlElement()||
|+|RegarAcct|String||XmlElement()||
|+|CertfctnDtTm|ISO20022.Sese032002.DateAndDateTime2Choice||XmlElement()||
|+|CertfctnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CertNb""",CertNb),validElement(CertNb),validPattern("""RegarAcct""",RegarAcct,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validElement(CertfctnDtTm),validPattern("""CertfctnId""",CertfctnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese032002.RegistrationReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032002.Registration12Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlInf""",AddtlInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese032002.RepairReason12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032002.RepairReason14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese032002.RepairReason14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.RepairReason4Code


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

## Value ISO20022.Sese032002.RepairStatus16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032002.RepairReason12>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese032002.Reporting2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DEFR|Int32||XmlEnum("""DEFR""")|1|
||REGU|Int32||XmlEnum("""REGU""")|2|
||STEX|Int32||XmlEnum("""STEX""")|3|

---

## Value ISO20022.Sese032002.Reporting9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.RepurchaseType10Code


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

## Value ISO20022.Sese032002.RepurchaseType26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese032002.RestrictedFINActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese032002.Restriction6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.SafeKeepingPlace4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Sese032002.SafekeepingPlaceFormat39Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Sese032002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Sese032002.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Sese032002.SafekeepingPlaceFormat39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Sese032002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Sese032002.SafekeepingPlaceTypeAndText15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Sese032002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese032002.SafekeepingPlaceTypeAndText15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese032002.SecuritiesAccount30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Sese032002.SecuritiesCertificate5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Nb""",Nb,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Sese032002.SecuritiesPaymentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NILL|Int32||XmlEnum("""NILL""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Sese032002.SecuritiesPaymentStatus6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.SecuritiesRTGS5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Aspect ISO20022.Sese032002.SecuritiesSettlementTransactionGenerationNotification002V11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese032002.SupplementaryData1>||XmlElement()||
|+|StsAndRsn|ISO20022.Sese032002.StatusAndReason29||XmlElement()||
|+|GnrtdRsn|global::System.Collections.Generic.List<ISO20022.Sese032002.GeneratedReason6>||XmlElement()||
|+|AddtlPhysOrRegnDtls|ISO20022.Sese032002.RegistrationParameters7||XmlElement()||
|+|OthrBizPties|ISO20022.Sese032002.OtherParties44||XmlElement()||
|+|OthrAmts|ISO20022.Sese032002.OtherAmounts43||XmlElement()||
|+|SttlmAmt|ISO20022.Sese032002.AmountAndDirection96||XmlElement()||
|+|CshPties|ISO20022.Sese032002.CashParties38||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese032002.SettlementParties105||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese032002.SettlementParties105||XmlElement()||
|+|SttlmParams|ISO20022.Sese032002.SettlementDetails212||XmlElement()||
|+|QtyAndAcctDtls|global::System.Collections.Generic.List<ISO20022.Sese032002.QuantityAndAccount104>||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Sese032002.FinancialInstrumentAttributes122||XmlElement()||
|+|FinInstrmId|ISO20022.Sese032002.SecurityIdentification20||XmlElement()||
|+|TradDtls|ISO20022.Sese032002.SecuritiesTradeDetails130||XmlElement()||
|+|Lnkgs|global::System.Collections.Generic.List<ISO20022.Sese032002.Linkages68>||XmlElement()||
|+|NbCounts|ISO20022.Sese032002.NumberCount2Choice||XmlElement()||
|+|TxIdDtls|ISO20022.Sese032002.SettlementTypeAndIdentification28||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(StsAndRsn),validList("""GnrtdRsn""",GnrtdRsn),validElement(GnrtdRsn),validElement(AddtlPhysOrRegnDtls),validElement(OthrBizPties),validElement(OthrAmts),validElement(SttlmAmt),validElement(CshPties),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(SttlmParams),validRequired("""QtyAndAcctDtls""",QtyAndAcctDtls),validList("""QtyAndAcctDtls""",QtyAndAcctDtls),validElement(QtyAndAcctDtls),validElement(FinInstrmAttrbts),validElement(FinInstrmId),validElement(TradDtls),validList("""Lnkgs""",Lnkgs),validElement(Lnkgs),validElement(NbCounts),validElement(TxIdDtls))|

---

## Value ISO20022.Sese032002.SecuritiesTradeDetails130


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmInstrPrcgAddtlDtls|String||XmlElement()||
|+|FxAddtlDtls|String||XmlElement()||
|+|AffirmSts|ISO20022.Sese032002.AffirmationStatus9Choice||XmlElement()||
|+|MtchgSts|ISO20022.Sese032002.MatchingStatus28Choice||XmlElement()||
|+|CcyToBuyOrSell|ISO20022.Sese032002.CurrencyToBuyOrSell1Choice||XmlElement()||
|+|TpOfPric|ISO20022.Sese032002.TypeOfPrice32Choice||XmlElement()||
|+|TradOrgtrRole|ISO20022.Sese032002.TradeOriginator4Choice||XmlElement()||
|+|InvstrCpcty|ISO20022.Sese032002.InvestorCapacity5Choice||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Sese032002.TradeTransactionCondition6Choice>||XmlElement()||
|+|Rptg|global::System.Collections.Generic.List<ISO20022.Sese032002.Reporting9Choice>||XmlElement()||
|+|OpngClsg|ISO20022.Sese032002.OpeningClosing4Choice||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|DealPric|ISO20022.Sese032002.Price11||XmlElement()||
|+|MtchdStsTmStmp|DateTime||XmlElement()||
|+|AckdStsTmStmp|DateTime||XmlElement()||
|+|LateDlvryDt|ISO20022.Sese032002.DateAndDateTime2Choice||XmlElement()||
|+|SttlmDt|ISO20022.Sese032002.SettlementDate20Choice||XmlElement()||
|+|TradDt|ISO20022.Sese032002.TradeDate9Choice||XmlElement()||
|+|PlcOfClr|ISO20022.Sese032002.PlaceOfClearingIdentification2||XmlElement()||
|+|PlcOfTrad|ISO20022.Sese032002.PlaceOfTradeIdentification2||XmlElement()||
|+|CollTxId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TradId|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SttlmInstrPrcgAddtlDtls""",SttlmInstrPrcgAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""FxAddtlDtls""",FxAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validElement(AffirmSts),validElement(MtchgSts),validElement(CcyToBuyOrSell),validElement(TpOfPric),validElement(TradOrgtrRole),validElement(InvstrCpcty),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond),validList("""Rptg""",Rptg),validElement(Rptg),validElement(OpngClsg),validElement(DealPric),validElement(LateDlvryDt),validElement(SttlmDt),validElement(TradDt),validElement(PlcOfClr),validElement(PlcOfTrad),validPattern("""CollTxId""",CollTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""TradId""",TradId,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,52}"""))|

---

## Enum ISO20022.Sese032002.SecuritiesTransactionType26Code


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

## Value ISO20022.Sese032002.SecuritiesTransactionType52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese032002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese032002.SettlementDate20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese032002.SettlementDateCode9Choice||XmlElement()||
|+|Dt|ISO20022.Sese032002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Sese032002.SettlementDate4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WISS|Int32||XmlEnum("""WISS""")|1|

---

## Value ISO20022.Sese032002.SettlementDateCode9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.SettlementDetails212


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshSubBalTp|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|SctiesSubBalTp|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|ElgblForColl|String||XmlElement()||
|+|ModCxlAllwd|ISO20022.Sese032002.ModificationCancellationAllowed5Choice||XmlElement()||
|+|RtrLeg|String||XmlElement()||
|+|LttrOfGrnt|ISO20022.Sese032002.LetterOfGuarantee5Choice||XmlElement()||
|+|AutomtcBrrwg|ISO20022.Sese032002.AutomaticBorrowing8Choice||XmlElement()||
|+|Trckg|ISO20022.Sese032002.Tracking5Choice||XmlElement()||
|+|StmpDtyTaxBsis|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|TaxCpcty|ISO20022.Sese032002.TaxCapacityParty5Choice||XmlElement()||
|+|SttlmSysMtd|ISO20022.Sese032002.SettlementSystemMethod5Choice||XmlElement()||
|+|SttlgCpcty|ISO20022.Sese032002.SettlingCapacity8Choice||XmlElement()||
|+|SctiesRTGS|ISO20022.Sese032002.SecuritiesRTGS5Choice||XmlElement()||
|+|LglRstrctns|ISO20022.Sese032002.Restriction6Choice||XmlElement()||
|+|RpTp|ISO20022.Sese032002.RepurchaseType26Choice||XmlElement()||
|+|Regn|ISO20022.Sese032002.Registration11Choice||XmlElement()||
|+|NetgElgblty|ISO20022.Sese032002.NettingEligibility5Choice||XmlElement()||
|+|MktClntSd|ISO20022.Sese032002.MarketClientSide7Choice||XmlElement()||
|+|FxStgInstr|ISO20022.Sese032002.FXStandingInstruction5Choice||XmlElement()||
|+|XpsrTp|ISO20022.Sese032002.ExposureType24Choice||XmlElement()||
|+|CshClrSys|ISO20022.Sese032002.CashSettlementSystem5Choice||XmlElement()||
|+|DlvryRtrRsn|ISO20022.Sese032002.DeliveryReturn4Choice||XmlElement()||
|+|CCPElgblty|ISO20022.Sese032002.CentralCounterPartyEligibility5Choice||XmlElement()||
|+|BlckTrad|ISO20022.Sese032002.BlockTrade5Choice||XmlElement()||
|+|BnfclOwnrsh|ISO20022.Sese032002.BeneficialOwnership5Choice||XmlElement()||
|+|PrtlSttlmInd|String||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese032002.SettlementTransactionCondition29Choice>||XmlElement()||
|+|SctiesTxTp|ISO20022.Sese032002.SecuritiesTransactionType52Choice||XmlElement()||
|+|Prty|ISO20022.Sese032002.PriorityNumeric5Choice||XmlElement()||
|+|HldInd|ISO20022.Sese032002.HoldIndicator7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshSubBalTp),validElement(SctiesSubBalTp),validElement(ModCxlAllwd),validElement(LttrOfGrnt),validElement(AutomtcBrrwg),validElement(Trckg),validElement(StmpDtyTaxBsis),validElement(TaxCpcty),validElement(SttlmSysMtd),validElement(SttlgCpcty),validElement(SctiesRTGS),validElement(LglRstrctns),validElement(RpTp),validElement(Regn),validElement(NetgElgblty),validElement(MktClntSd),validElement(FxStgInstr),validElement(XpsrTp),validElement(CshClrSys),validElement(DlvryRtrRsn),validElement(CCPElgblty),validElement(BlckTrad),validElement(BnfclOwnrsh),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validElement(SctiesTxTp),validElement(Prty),validElement(HldInd))|

---

## Value ISO20022.Sese032002.SettlementParties105


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese032002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty4|ISO20022.Sese032002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty3|ISO20022.Sese032002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty2|ISO20022.Sese032002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty1|ISO20022.Sese032002.PartyIdentificationAndAccount206||XmlElement()||
|+|Dpstry|ISO20022.Sese032002.PartyIdentification162||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Value ISO20022.Sese032002.SettlementStatus22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.ProprietaryStatusAndReason7||XmlElement()||
|+|Flng|ISO20022.Sese032002.FailingStatus12Choice||XmlElement()||
|+|Pdg|ISO20022.Sese032002.PendingStatus50Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Flng),validElement(Pdg),validChoice(Prtry,Flng,Pdg))|

---

## Enum ISO20022.Sese032002.SettlementSystemMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSET|Int32||XmlEnum("""YSET""")|1|
||NSET|Int32||XmlEnum("""NSET""")|2|

---

## Value ISO20022.Sese032002.SettlementSystemMethod5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.SettlementTransactionCondition29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.SettlementTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARQ|Int32||XmlEnum("""PARQ""")|1|
||PARC|Int32||XmlEnum("""PARC""")|2|
||NPAR|Int32||XmlEnum("""NPAR""")|3|
||PART|Int32||XmlEnum("""PART""")|4|

---

## Enum ISO20022.Sese032002.SettlementTransactionCondition8Code


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

## Value ISO20022.Sese032002.SettlementTypeAndIdentification28


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
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
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CorpActnEvtId""",CorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""PoolId""",PoolId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CmonId""",CmonId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""PrcrTxId""",PrcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CtrPtyMktInfrstrctrTxId""",CtrPtyMktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktInfrstrctrTxId""",MktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrTxId""",AcctSvcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctOwnrTxId""",AcctOwnrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Sese032002.SettlingCapacity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RISP|Int32||XmlEnum("""RISP""")|1|
||SPRI|Int32||XmlEnum("""SPRI""")|2|
||CUST|Int32||XmlEnum("""CUST""")|3|
||SAGE|Int32||XmlEnum("""SAGE""")|4|

---

## Value ISO20022.Sese032002.SettlingCapacity8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.StatusAndReason29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmSts|ISO20022.Sese032002.SettlementStatus22Choice||XmlElement()||
|+|MtchgSts|ISO20022.Sese032002.MatchingStatus32Choice||XmlElement()||
|+|IfrrdMtchgSts|ISO20022.Sese032002.MatchingStatus32Choice||XmlElement()||
|+|PrcgSts|ISO20022.Sese032002.ProcessingStatus62Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmSts),validElement(MtchgSts),validElement(IfrrdMtchgSts),validElement(PrcgSts))|

---

## Value ISO20022.Sese032002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese032002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese032002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese032002.TaxCapacityParty5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.TaxLiability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGEN|Int32||XmlEnum("""AGEN""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Sese032002.TotalNumber2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlOfLkdInstrs|String||XmlElement()||
|+|CurInstrNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TtlOfLkdInstrs""",TtlOfLkdInstrs,"""[0-9]{1,6}"""),validPattern("""CurInstrNb""",CurInstrNb,"""[0-9]{1,6}"""))|

---

## Value ISO20022.Sese032002.Tracking5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese032002.TradeDate9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese032002.TradeDateCode4Choice||XmlElement()||
|+|Dt|ISO20022.Sese032002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese032002.TradeDateCode4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.TradeOriginator4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.TradeTransactionCondition4Code


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

## Value ISO20022.Sese032002.TradeTransactionCondition6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.TypeOfIdentification1Code


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

## Enum ISO20022.Sese032002.TypeOfPrice14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AVER|Int32||XmlEnum("""AVER""")|1|

---

## Value ISO20022.Sese032002.TypeOfPrice32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese032002.UnmatchedReason11Code


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

## Value ISO20022.Sese032002.UnmatchedReason20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese032002.UnmatchedReason27Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese032002.UnmatchedReason27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese032002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese032002.UnmatchedStatus21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese032002.UnmatchedReason20>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese032002.YieldedOrValueType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValTp|String||XmlElement()||
|+|Yldd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(ValTp,Yldd))|

---

## Value ISO20022.Sese032002.YieldedOrValueType2Choice


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

