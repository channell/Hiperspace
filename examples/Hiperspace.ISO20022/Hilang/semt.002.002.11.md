# semt.002.002.11
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt002002.Account30 {
        + AcctSvcr  : ISO20022.Semt002002.PartyIdentification137Choice
        + Id  : ISO20022.Semt002002.AccountIdentification4
    }
    ISO20022.Semt002002.Account30 *-- ISO20022.Semt002002.PartyIdentification137Choice
    ISO20022.Semt002002.Account30 *-- ISO20022.Semt002002.AccountIdentification4
    class ISO20022.Semt002002.AccountIdentification4 {
        + Prtry  : ISO20022.Semt002002.SimpleIdentificationInformation1
    }
    ISO20022.Semt002002.AccountIdentification4 *-- ISO20022.Semt002002.SimpleIdentificationInformation1
    class ISO20022.Semt002002.AdditionalBalanceInformation24 {
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002002.QuantityBreakdown71~
        + SubBalAddtlDtls  : String
        + Qty  : ISO20022.Semt002002.Balance27
        + SubBalTp  : ISO20022.Semt002002.SubBalanceType14Choice
    }
    ISO20022.Semt002002.AdditionalBalanceInformation24 *-- ISO20022.Semt002002.QuantityBreakdown71
    ISO20022.Semt002002.AdditionalBalanceInformation24 *-- ISO20022.Semt002002.Balance27
    ISO20022.Semt002002.AdditionalBalanceInformation24 *-- ISO20022.Semt002002.SubBalanceType14Choice
    class ISO20022.Semt002002.AggregateBalanceInformation44 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt002002.SupplementaryData1~
        + HldgAddtlDtls  : String
        + BalAtSfkpgPlc  : global::System.Collections.Generic.List~ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41~
        + AddtlBalBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002002.AdditionalBalanceInformation24~
        + BalBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002002.SubBalanceInformation24~
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002002.QuantityBreakdown71~
        + InstrmCcyAmts  : ISO20022.Semt002002.BalanceAmounts4
        + AcctBaseCcyAmts  : ISO20022.Semt002002.BalanceAmounts4
        + DaysAcrd  : Decimal
        + FXDtls  : global::System.Collections.Generic.List~ISO20022.Semt002002.ForeignExchangeTerms35~
        + PricDtls  : global::System.Collections.Generic.List~ISO20022.Semt002002.PriceInformation22~
        + CorpActnOptnTp  : String
        + SfkpgPlc  : ISO20022.Semt002002.SafeKeepingPlace4
        + NotAvlblBal  : ISO20022.Semt002002.BalanceQuantity17Choice
        + AvlblBal  : ISO20022.Semt002002.Balance25
        + AggtBal  : ISO20022.Semt002002.Balance22
        + ValtnHrcutDtls  : ISO20022.Semt002002.BasicCollateralValuation1Details
        + InvstmtFndsFinInstrmAttrbts  : ISO20022.Semt002002.FinancialInstrument22
        + FinInstrmAttrbts  : ISO20022.Semt002002.FinancialInstrumentAttributes122
        + FinInstrmId  : ISO20022.Semt002002.SecurityIdentification20
    }
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.SupplementaryData1
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.AdditionalBalanceInformation24
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.SubBalanceInformation24
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.QuantityBreakdown71
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.BalanceAmounts4
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.BalanceAmounts4
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.ForeignExchangeTerms35
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.PriceInformation22
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.SafeKeepingPlace4
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.BalanceQuantity17Choice
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.Balance25
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.Balance22
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.BasicCollateralValuation1Details
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.FinancialInstrument22
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.FinancialInstrumentAttributes122
    ISO20022.Semt002002.AggregateBalanceInformation44 *-- ISO20022.Semt002002.SecurityIdentification20
    class ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41 {
        + HldgAddtlDtls  : String
        + AddtlBalBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002002.AdditionalBalanceInformation24~
        + BalBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002002.SubBalanceInformation24~
        + XpsrTp  : ISO20022.Semt002002.ExposureType24Choice
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002002.QuantityBreakdown71~
        + InstrmCcyAmts  : ISO20022.Semt002002.BalanceAmounts4
        + AcctBaseCcyAmts  : ISO20022.Semt002002.BalanceAmounts4
        + DaysAcrd  : Decimal
        + FXDtls  : global::System.Collections.Generic.List~ISO20022.Semt002002.ForeignExchangeTerms35~
        + PricDtls  : global::System.Collections.Generic.List~ISO20022.Semt002002.PriceInformation22~
        + NotAvlblBal  : ISO20022.Semt002002.BalanceQuantity17Choice
        + AvlblBal  : ISO20022.Semt002002.Balance25
        + AggtBal  : ISO20022.Semt002002.Balance22
        + Pldgee  : ISO20022.Semt002002.Pledgee4
        + PlcOfListg  : ISO20022.Semt002002.MarketIdentification4Choice
        + SfkpgPlc  : ISO20022.Semt002002.SafeKeepingPlace4
    }
    ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41 *-- ISO20022.Semt002002.AdditionalBalanceInformation24
    ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41 *-- ISO20022.Semt002002.SubBalanceInformation24
    ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41 *-- ISO20022.Semt002002.ExposureType24Choice
    ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41 *-- ISO20022.Semt002002.QuantityBreakdown71
    ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41 *-- ISO20022.Semt002002.BalanceAmounts4
    ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41 *-- ISO20022.Semt002002.BalanceAmounts4
    ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41 *-- ISO20022.Semt002002.ForeignExchangeTerms35
    ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41 *-- ISO20022.Semt002002.PriceInformation22
    ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41 *-- ISO20022.Semt002002.BalanceQuantity17Choice
    ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41 *-- ISO20022.Semt002002.Balance25
    ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41 *-- ISO20022.Semt002002.Balance22
    ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41 *-- ISO20022.Semt002002.Pledgee4
    ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41 *-- ISO20022.Semt002002.MarketIdentification4Choice
    ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41 *-- ISO20022.Semt002002.SafeKeepingPlace4
    class ISO20022.Semt002002.AmountAndDirection14 {
        + Sgn  : String
        + Amt  : ISO20022.Semt002002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Semt002002.AmountAndDirection14 *-- ISO20022.Semt002002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    class ISO20022.Semt002002.Balance22 {
        + Qty  : ISO20022.Semt002002.BalanceQuantity15Choice
        + ShrtLngInd  : String
    }
    ISO20022.Semt002002.Balance22 *-- ISO20022.Semt002002.BalanceQuantity15Choice
    class ISO20022.Semt002002.Balance23 {
        + Qty  : ISO20022.Semt002002.BalanceQuantity15Choice
        + ShrtLngInd  : String
    }
    ISO20022.Semt002002.Balance23 *-- ISO20022.Semt002002.BalanceQuantity15Choice
    class ISO20022.Semt002002.Balance25 {
        + Qty  : ISO20022.Semt002002.BalanceQuantity17Choice
        + ShrtLngInd  : String
    }
    ISO20022.Semt002002.Balance25 *-- ISO20022.Semt002002.BalanceQuantity17Choice
    class ISO20022.Semt002002.Balance27 {
        + Qty  : ISO20022.Semt002002.SubBalanceQuantity9Choice
        + ShrtLngInd  : String
    }
    ISO20022.Semt002002.Balance27 *-- ISO20022.Semt002002.SubBalanceQuantity9Choice
    class ISO20022.Semt002002.BalanceAmounts4 {
        + AcrdIntrstAmt  : ISO20022.Semt002002.AmountAndDirection14
        + ElgblCollVal  : ISO20022.Semt002002.AmountAndDirection14
        + BookVal  : ISO20022.Semt002002.AmountAndDirection14
        + PrvsHldgVal  : ISO20022.Semt002002.AmountAndDirection14
        + HldgVal  : ISO20022.Semt002002.AmountAndDirection14
    }
    ISO20022.Semt002002.BalanceAmounts4 *-- ISO20022.Semt002002.AmountAndDirection14
    ISO20022.Semt002002.BalanceAmounts4 *-- ISO20022.Semt002002.AmountAndDirection14
    ISO20022.Semt002002.BalanceAmounts4 *-- ISO20022.Semt002002.AmountAndDirection14
    ISO20022.Semt002002.BalanceAmounts4 *-- ISO20022.Semt002002.AmountAndDirection14
    ISO20022.Semt002002.BalanceAmounts4 *-- ISO20022.Semt002002.AmountAndDirection14
    class ISO20022.Semt002002.BalanceQuantity15Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification144
        + Qty  : ISO20022.Semt002002.Quantity54Choice
    }
    ISO20022.Semt002002.BalanceQuantity15Choice *-- ISO20022.Semt002002.GenericIdentification144
    ISO20022.Semt002002.BalanceQuantity15Choice *-- ISO20022.Semt002002.Quantity54Choice
    class ISO20022.Semt002002.BalanceQuantity17Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification144
        + Qty  : ISO20022.Semt002002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Semt002002.BalanceQuantity17Choice *-- ISO20022.Semt002002.GenericIdentification144
    ISO20022.Semt002002.BalanceQuantity17Choice *-- ISO20022.Semt002002.FinancialInstrumentQuantity36Choice
    class ISO20022.Semt002002.BasicCollateralValuation1Details {
        + HrcutSrc  : ISO20022.Semt002002.PartyIdentification15
        + ValtnHrcut  : Decimal
    }
    ISO20022.Semt002002.BasicCollateralValuation1Details *-- ISO20022.Semt002002.PartyIdentification15
    class ISO20022.Semt002002.BlockChainAddressWallet10 {
        + Dsgnt  : String
        + Nm  : String
        + Tp  : ISO20022.Semt002002.PurposeCode8Choice
        + Id  : String
    }
    ISO20022.Semt002002.BlockChainAddressWallet10 *-- ISO20022.Semt002002.PurposeCode8Choice
    class ISO20022.Semt002002.BlockChainAddressWallet6 {
        + Nm  : String
        + Tp  : ISO20022.Semt002002.PurposeCode7Choice
        + Id  : String
    }
    ISO20022.Semt002002.BlockChainAddressWallet6 *-- ISO20022.Semt002002.PurposeCode7Choice
    class ISO20022.Semt002002.ClassificationType33Choice {
        + AltrnClssfctn  : ISO20022.Semt002002.GenericIdentification86
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Semt002002.ClassificationType33Choice *-- ISO20022.Semt002002.GenericIdentification86
    class ISO20022.Semt002002.CorporateActionOption5Code {
        SECU = 1
        CASH = 2
    }
    class ISO20022.Semt002002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Semt002002.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class ISO20022.Semt002002.EventFrequency3Code {
        WEEK = 1
        SEMI = 2
        QUTR = 3
        MNTH = 4
        YEAR = 5
    }
    class ISO20022.Semt002002.EventFrequency7Code {
        ONDE = 1
        OVNG = 2
        TWMN = 3
        TOWK = 4
        TOMN = 5
        QUTR = 6
        SEMI = 7
        WEEK = 8
        INDA = 9
        DAIL = 10
        MNTH = 11
        ADHO = 12
        YEAR = 13
    }
    class ISO20022.Semt002002.ExposureType12Code {
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
    class ISO20022.Semt002002.ExposureType24Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.ExposureType24Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.FinancialInstrument22 {
        + RegdDstrbtnCtry  : global::System.Collections.Generic.List~String~
        + CtryOfDmcl  : String
        + DualFndInd  : String
        + ReqdNAVCcy  : String
        + DnmtnCcy  : String
        + BaseCcy  : String
        + UmbrllNm  : String
        + PdctGrp  : String
        + DstrbtnPlcy  : String
        + SctiesForm  : String
        + ClssTp  : String
    }
    class ISO20022.Semt002002.FinancialInstrumentAttributes122 {
        + FinInstrmAttrAddtlDtls  : String
        + UndrlygFinInstrmId  : global::System.Collections.Generic.List~ISO20022.Semt002002.SecurityIdentification20~
        + CtrctSz  : ISO20022.Semt002002.FinancialInstrumentQuantity36Choice
        + MinNmnlQty  : ISO20022.Semt002002.FinancialInstrumentQuantity36Choice
        + StrkPric  : ISO20022.Semt002002.Price3
        + ConvsPric  : ISO20022.Semt002002.Price3
        + SbcptPric  : ISO20022.Semt002002.Price3
        + ExrcPric  : ISO20022.Semt002002.Price3
        + MktOrIndctvPric  : ISO20022.Semt002002.PriceType5Choice
        + PutblInd  : String
        + CllblInd  : String
        + VarblRateInd  : String
        + PoolNb  : ISO20022.Semt002002.GenericIdentification39
        + CpnAttchdNb  : ISO20022.Semt002002.Number23Choice
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
        + OptnTp  : ISO20022.Semt002002.OptionType7Choice
        + OptnStyle  : ISO20022.Semt002002.OptionStyle9Choice
        + ClssfctnTp  : ISO20022.Semt002002.ClassificationType33Choice
        + VarblRateChngFrqcy  : ISO20022.Semt002002.Frequency27Choice
        + PmtSts  : ISO20022.Semt002002.SecuritiesPaymentStatus6Choice
        + PmtFrqcy  : ISO20022.Semt002002.Frequency27Choice
        + RegnForm  : ISO20022.Semt002002.FormOfSecurity7Choice
        + DayCntBsis  : ISO20022.Semt002002.InterestComputationMethodFormat5Choice
        + PlcOfListg  : ISO20022.Semt002002.MarketIdentification4Choice
    }
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.SecurityIdentification20
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.FinancialInstrumentQuantity36Choice
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.FinancialInstrumentQuantity36Choice
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.Price3
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.Price3
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.Price3
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.Price3
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.PriceType5Choice
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.GenericIdentification39
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.Number23Choice
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.OptionType7Choice
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.OptionStyle9Choice
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.ClassificationType33Choice
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.Frequency27Choice
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.SecuritiesPaymentStatus6Choice
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.Frequency27Choice
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.FormOfSecurity7Choice
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.InterestComputationMethodFormat5Choice
    ISO20022.Semt002002.FinancialInstrumentAttributes122 *-- ISO20022.Semt002002.MarketIdentification4Choice
    class ISO20022.Semt002002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Semt002002.ForeignExchangeTerms35 {
        + QtgInstn  : ISO20022.Semt002002.PartyIdentification137Choice
        + QtnDt  : DateTime
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Semt002002.ForeignExchangeTerms35 *-- ISO20022.Semt002002.PartyIdentification137Choice
    class ISO20022.Semt002002.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Semt002002.FormOfSecurity7Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.FormOfSecurity7Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.Frequency27Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.Frequency27Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.Frequency34Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.Frequency34Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.GenericIdentification144 {
        + Bal  : Decimal
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt002002.GenericIdentification18 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Semt002002.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt002002.GenericIdentification39 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt002002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt002002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt002002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Semt002002.GenericIdentification47
    }
    ISO20022.Semt002002.GenericIdentification85 *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.GenericIdentification86 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt002002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt002002.InterestComputationMethod2Code {
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
    class ISO20022.Semt002002.InterestComputationMethodFormat5Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.InterestComputationMethodFormat5Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.Intermediary45 {
        + Acct  : ISO20022.Semt002002.Account30
        + Role  : ISO20022.Semt002002.Role7Choice
        + Id  : ISO20022.Semt002002.PartyIdentification157
    }
    ISO20022.Semt002002.Intermediary45 *-- ISO20022.Semt002002.Account30
    ISO20022.Semt002002.Intermediary45 *-- ISO20022.Semt002002.Role7Choice
    ISO20022.Semt002002.Intermediary45 *-- ISO20022.Semt002002.PartyIdentification157
    class ISO20022.Semt002002.InvestmentFundRole2Code {
        TRAN = 1
        UCL2 = 2
        UCL1 = 3
        CONC = 4
        DIST = 5
        INTR = 6
        TRAG = 7
        REGI = 8
        FMCO = 9
    }
    class ISO20022.Semt002002.MarketIdentification2Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Semt002002.MarketIdentification4Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Semt002002.MarketIdentification91 {
        + Tp  : ISO20022.Semt002002.MarketType17Choice
        + Id  : ISO20022.Semt002002.MarketIdentification2Choice
    }
    ISO20022.Semt002002.MarketIdentification91 *-- ISO20022.Semt002002.MarketType17Choice
    ISO20022.Semt002002.MarketIdentification91 *-- ISO20022.Semt002002.MarketIdentification2Choice
    class ISO20022.Semt002002.MarketType17Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.MarketType17Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.MarketType4Code {
        VEND = 1
        THEO = 2
        LMAR = 3
        FUND = 4
    }
    class ISO20022.Semt002002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Semt002002.Number23Choice {
        + Lng  : ISO20022.Semt002002.GenericIdentification18
        + Shrt  : String
    }
    ISO20022.Semt002002.Number23Choice *-- ISO20022.Semt002002.GenericIdentification18
    class ISO20022.Semt002002.Number3Choice {
        + Lng  : String
        + Shrt  : String
    }
    class ISO20022.Semt002002.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Semt002002.OptionStyle9Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.OptionStyle9Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Semt002002.OptionType7Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.OptionType7Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.OriginalAndCurrentQuantities4 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Semt002002.OtherIdentification2 {
        + Tp  : ISO20022.Semt002002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Semt002002.OtherIdentification2 *-- ISO20022.Semt002002.IdentificationSource4Choice
    class ISO20022.Semt002002.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Semt002002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Semt002002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Semt002002.PartyIdentification136Choice *-- ISO20022.Semt002002.GenericIdentification84
    class ISO20022.Semt002002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Semt002002.NameAndAddress12
        + PrtryId  : ISO20022.Semt002002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Semt002002.PartyIdentification137Choice *-- ISO20022.Semt002002.NameAndAddress12
    ISO20022.Semt002002.PartyIdentification137Choice *-- ISO20022.Semt002002.GenericIdentification84
    class ISO20022.Semt002002.PartyIdentification15 {
        + Id  : String
        + Ctry  : String
    }
    class ISO20022.Semt002002.PartyIdentification156 {
        + LEI  : String
        + Id  : ISO20022.Semt002002.PartyIdentification136Choice
    }
    ISO20022.Semt002002.PartyIdentification156 *-- ISO20022.Semt002002.PartyIdentification136Choice
    class ISO20022.Semt002002.PartyIdentification157 {
        + LEI  : String
        + Id  : ISO20022.Semt002002.PartyIdentification137Choice
    }
    ISO20022.Semt002002.PartyIdentification157 *-- ISO20022.Semt002002.PartyIdentification137Choice
    class ISO20022.Semt002002.Pledgee4 {
        + LEI  : String
        + PldgeeTpAndId  : ISO20022.Semt002002.PledgeeFormat6Choice
    }
    ISO20022.Semt002002.Pledgee4 *-- ISO20022.Semt002002.PledgeeFormat6Choice
    class ISO20022.Semt002002.PledgeeFormat6Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification85
        + Id  : ISO20022.Semt002002.PledgeeTypeAndText2
        + TpAndId  : ISO20022.Semt002002.PledgeeTypeAndAnyBICIdentifier2
    }
    ISO20022.Semt002002.PledgeeFormat6Choice *-- ISO20022.Semt002002.GenericIdentification85
    ISO20022.Semt002002.PledgeeFormat6Choice *-- ISO20022.Semt002002.PledgeeTypeAndText2
    ISO20022.Semt002002.PledgeeFormat6Choice *-- ISO20022.Semt002002.PledgeeTypeAndAnyBICIdentifier2
    class ISO20022.Semt002002.PledgeeType1Code {
        REGB = 1
        CPTY = 2
    }
    class ISO20022.Semt002002.PledgeeTypeAndAnyBICIdentifier2 {
        + PldgeeTp  : String
        + Id  : String
    }
    class ISO20022.Semt002002.PledgeeTypeAndText2 {
        + PldgeeTp  : String
        + Id  : String
    }
    class ISO20022.Semt002002.Price3 {
        + Val  : ISO20022.Semt002002.PriceRateOrAmount1Choice
        + Tp  : ISO20022.Semt002002.YieldedOrValueType1Choice
    }
    ISO20022.Semt002002.Price3 *-- ISO20022.Semt002002.PriceRateOrAmount1Choice
    ISO20022.Semt002002.Price3 *-- ISO20022.Semt002002.YieldedOrValueType1Choice
    class ISO20022.Semt002002.PriceInformation22 {
        + QtnDt  : ISO20022.Semt002002.DateAndDateTime2Choice
        + SrcOfPric  : ISO20022.Semt002002.MarketIdentification91
        + ValTp  : ISO20022.Semt002002.YieldedOrValueType1Choice
        + Val  : ISO20022.Semt002002.PriceRateOrAmountOrUnknown3Choice
        + Tp  : ISO20022.Semt002002.TypeOfPrice33Choice
    }
    ISO20022.Semt002002.PriceInformation22 *-- ISO20022.Semt002002.DateAndDateTime2Choice
    ISO20022.Semt002002.PriceInformation22 *-- ISO20022.Semt002002.MarketIdentification91
    ISO20022.Semt002002.PriceInformation22 *-- ISO20022.Semt002002.YieldedOrValueType1Choice
    ISO20022.Semt002002.PriceInformation22 *-- ISO20022.Semt002002.PriceRateOrAmountOrUnknown3Choice
    ISO20022.Semt002002.PriceInformation22 *-- ISO20022.Semt002002.TypeOfPrice33Choice
    class ISO20022.Semt002002.PriceRateOrAmount1Choice {
        + Amt  : ISO20022.Semt002002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Semt002002.PriceRateOrAmount1Choice *-- ISO20022.Semt002002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Semt002002.PriceRateOrAmountOrUnknown3Choice {
        + UknwnInd  : String
        + Amt  : ISO20022.Semt002002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Semt002002.PriceRateOrAmountOrUnknown3Choice *-- ISO20022.Semt002002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Semt002002.PriceType5Choice {
        + Indctv  : ISO20022.Semt002002.Price3
        + Mkt  : ISO20022.Semt002002.Price3
    }
    ISO20022.Semt002002.PriceType5Choice *-- ISO20022.Semt002002.Price3
    ISO20022.Semt002002.PriceType5Choice *-- ISO20022.Semt002002.Price3
    class ISO20022.Semt002002.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Semt002002.PurposeCode7Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002002.PurposeCode7Choice *-- ISO20022.Semt002002.GenericIdentification30
    class ISO20022.Semt002002.PurposeCode8Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.PurposeCode8Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.Quantity54Choice {
        + OrgnlAndCurFace  : ISO20022.Semt002002.OriginalAndCurrentQuantities4
        + Qty  : ISO20022.Semt002002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Semt002002.Quantity54Choice *-- ISO20022.Semt002002.OriginalAndCurrentQuantities4
    ISO20022.Semt002002.Quantity54Choice *-- ISO20022.Semt002002.FinancialInstrumentQuantity36Choice
    class ISO20022.Semt002002.QuantityAndAvailability4 {
        + AvlbtyInd  : String
        + Qty  : ISO20022.Semt002002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Semt002002.QuantityAndAvailability4 *-- ISO20022.Semt002002.FinancialInstrumentQuantity36Choice
    class ISO20022.Semt002002.QuantityBreakdown71 {
        + TpOfPric  : ISO20022.Semt002002.TypeOfPrice32Choice
        + LotPric  : ISO20022.Semt002002.Price3
        + LotDtTm  : ISO20022.Semt002002.DateAndDateTime2Choice
        + LotQty  : ISO20022.Semt002002.Balance23
        + LotNb  : ISO20022.Semt002002.GenericIdentification39
    }
    ISO20022.Semt002002.QuantityBreakdown71 *-- ISO20022.Semt002002.TypeOfPrice32Choice
    ISO20022.Semt002002.QuantityBreakdown71 *-- ISO20022.Semt002002.Price3
    ISO20022.Semt002002.QuantityBreakdown71 *-- ISO20022.Semt002002.DateAndDateTime2Choice
    ISO20022.Semt002002.QuantityBreakdown71 *-- ISO20022.Semt002002.Balance23
    ISO20022.Semt002002.QuantityBreakdown71 *-- ISO20022.Semt002002.GenericIdentification39
    class ISO20022.Semt002002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt002002.RestrictedFINActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt002002.Role7Choice {
        + Txt  : String
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.Role7Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.SafeKeepingPlace4 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Semt002002.SafekeepingPlaceFormat39Choice
    }
    ISO20022.Semt002002.SafeKeepingPlace4 *-- ISO20022.Semt002002.SafekeepingPlaceFormat39Choice
    class ISO20022.Semt002002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Semt002002.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Semt002002.SafekeepingPlaceFormat39Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification85
        + TpAndId  : ISO20022.Semt002002.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Semt002002.SafekeepingPlaceTypeAndText15
    }
    ISO20022.Semt002002.SafekeepingPlaceFormat39Choice *-- ISO20022.Semt002002.GenericIdentification85
    ISO20022.Semt002002.SafekeepingPlaceFormat39Choice *-- ISO20022.Semt002002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Semt002002.SafekeepingPlaceFormat39Choice *-- ISO20022.Semt002002.SafekeepingPlaceTypeAndText15
    class ISO20022.Semt002002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt002002.SafekeepingPlaceTypeAndText15 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt002002.SecuritiesAccount34 {
        + Nm  : String
        + Tp  : ISO20022.Semt002002.PurposeCode8Choice
        + Id  : String
    }
    ISO20022.Semt002002.SecuritiesAccount34 *-- ISO20022.Semt002002.PurposeCode8Choice
    class ISO20022.Semt002002.SecuritiesAccount42 {
        + Dsgnt  : String
        + Nm  : String
        + Tp  : ISO20022.Semt002002.PurposeCode8Choice
        + Id  : String
    }
    ISO20022.Semt002002.SecuritiesAccount42 *-- ISO20022.Semt002002.PurposeCode8Choice
    class ISO20022.Semt002002.SecuritiesAccountPurposeType1Code {
        PHYS = 1
        DVPA = 2
        CEND = 3
        ABRD = 4
        SHOR = 5
        MARG = 6
    }
    class ISO20022.Semt002002.SecuritiesBalanceCustodyReport002V11 {
        + AcctBaseCcyTtlAmts  : ISO20022.Semt002002.TotalValueInPageAndStatement3
        + SubAcctDtls  : global::System.Collections.Generic.List~ISO20022.Semt002002.SubAccountIdentification69~
        + BalForAcct  : global::System.Collections.Generic.List~ISO20022.Semt002002.AggregateBalanceInformation44~
        + IntrmyInf  : global::System.Collections.Generic.List~ISO20022.Semt002002.Intermediary45~
        + BlckChainAdrOrWllt  : ISO20022.Semt002002.BlockChainAddressWallet10
        + SfkpgAcct  : ISO20022.Semt002002.SecuritiesAccount42
        + AcctSvcr  : ISO20022.Semt002002.PartyIdentification157
        + AcctOwnr  : ISO20022.Semt002002.PartyIdentification156
        + StmtGnlDtls  : ISO20022.Semt002002.Statement77
        + Pgntn  : ISO20022.Semt002002.Pagination1
    }
    ISO20022.Semt002002.SecuritiesBalanceCustodyReport002V11 *-- ISO20022.Semt002002.TotalValueInPageAndStatement3
    ISO20022.Semt002002.SecuritiesBalanceCustodyReport002V11 *-- ISO20022.Semt002002.SubAccountIdentification69
    ISO20022.Semt002002.SecuritiesBalanceCustodyReport002V11 *-- ISO20022.Semt002002.AggregateBalanceInformation44
    ISO20022.Semt002002.SecuritiesBalanceCustodyReport002V11 *-- ISO20022.Semt002002.Intermediary45
    ISO20022.Semt002002.SecuritiesBalanceCustodyReport002V11 *-- ISO20022.Semt002002.BlockChainAddressWallet10
    ISO20022.Semt002002.SecuritiesBalanceCustodyReport002V11 *-- ISO20022.Semt002002.SecuritiesAccount42
    ISO20022.Semt002002.SecuritiesBalanceCustodyReport002V11 *-- ISO20022.Semt002002.PartyIdentification157
    ISO20022.Semt002002.SecuritiesBalanceCustodyReport002V11 *-- ISO20022.Semt002002.PartyIdentification156
    ISO20022.Semt002002.SecuritiesBalanceCustodyReport002V11 *-- ISO20022.Semt002002.Statement77
    ISO20022.Semt002002.SecuritiesBalanceCustodyReport002V11 *-- ISO20022.Semt002002.Pagination1
    class ISO20022.Semt002002.SecuritiesBalanceType12Code {
        BTRA = 1
        WDOC = 2
        DRAW = 3
        TRAN = 4
        OTHR = 5
        RSTR = 6
        REGO = 7
        PLED = 8
        PENR = 9
        PEND = 10
        PEDA = 11
        PECA = 12
        MARG = 13
        LORE = 14
        LODE = 15
        LOAN = 16
        COLO = 17
        COLI = 18
        BORE = 19
        BODE = 20
        BORR = 21
        BLOV = 22
        BLOT = 23
        BLCA = 24
        AWAS = 25
        BLOK = 26
    }
    class ISO20022.Semt002002.SecuritiesBalanceType7Code {
        QUAS = 1
        ISSU = 2
        UNRG = 3
        SPOS = 4
        NOMI = 5
        DIRT = 6
        CLEN = 7
        OTHR = 8
        COLA = 9
    }
    class ISO20022.Semt002002.SecuritiesPaymentStatus1Code {
        PART = 1
        NILL = 2
        FULL = 3
    }
    class ISO20022.Semt002002.SecuritiesPaymentStatus6Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.SecuritiesPaymentStatus6Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Semt002002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Semt002002.SecurityIdentification20 *-- ISO20022.Semt002002.OtherIdentification2
    class ISO20022.Semt002002.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Semt002002.SimpleIdentificationInformation1 {
        + Id  : String
    }
    class ISO20022.Semt002002.Statement77 {
        + SctyIntrstOrSetOff  : String
        + SubAcctInd  : String
        + ActvtyInd  : String
        + StmtBsis  : ISO20022.Semt002002.StatementBasis9Choice
        + UpdTp  : ISO20022.Semt002002.UpdateType16Choice
        + Frqcy  : ISO20022.Semt002002.Frequency34Choice
        + StmtDtTm  : ISO20022.Semt002002.DateAndDateTime2Choice
        + StmtId  : String
        + QryRef  : String
        + RptNb  : ISO20022.Semt002002.Number3Choice
    }
    ISO20022.Semt002002.Statement77 *-- ISO20022.Semt002002.StatementBasis9Choice
    ISO20022.Semt002002.Statement77 *-- ISO20022.Semt002002.UpdateType16Choice
    ISO20022.Semt002002.Statement77 *-- ISO20022.Semt002002.Frequency34Choice
    ISO20022.Semt002002.Statement77 *-- ISO20022.Semt002002.DateAndDateTime2Choice
    ISO20022.Semt002002.Statement77 *-- ISO20022.Semt002002.Number3Choice
    class ISO20022.Semt002002.StatementBasis1Code {
        TRAD = 1
        SETT = 2
        CONT = 3
    }
    class ISO20022.Semt002002.StatementBasis9Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.StatementBasis9Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.StatementUpdateType1Code {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Semt002002.SubAccountIdentification69 {
        + BalForSubAcct  : global::System.Collections.Generic.List~ISO20022.Semt002002.AggregateBalanceInformation44~
        + ActvtyInd  : String
        + BlckChainAdrOrWllt  : ISO20022.Semt002002.BlockChainAddressWallet6
        + SfkpgAcct  : ISO20022.Semt002002.SecuritiesAccount34
        + AcctOwnr  : ISO20022.Semt002002.PartyIdentification156
    }
    ISO20022.Semt002002.SubAccountIdentification69 *-- ISO20022.Semt002002.AggregateBalanceInformation44
    ISO20022.Semt002002.SubAccountIdentification69 *-- ISO20022.Semt002002.BlockChainAddressWallet6
    ISO20022.Semt002002.SubAccountIdentification69 *-- ISO20022.Semt002002.SecuritiesAccount34
    ISO20022.Semt002002.SubAccountIdentification69 *-- ISO20022.Semt002002.PartyIdentification156
    class ISO20022.Semt002002.SubBalanceInformation24 {
        + AddtlBalBrkdwnDtls  : global::System.Collections.Generic.List~ISO20022.Semt002002.AdditionalBalanceInformation24~
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002002.QuantityBreakdown71~
        + SubBalAddtlDtls  : String
        + Qty  : ISO20022.Semt002002.Balance27
        + SubBalTp  : ISO20022.Semt002002.SubBalanceType13Choice
    }
    ISO20022.Semt002002.SubBalanceInformation24 *-- ISO20022.Semt002002.AdditionalBalanceInformation24
    ISO20022.Semt002002.SubBalanceInformation24 *-- ISO20022.Semt002002.QuantityBreakdown71
    ISO20022.Semt002002.SubBalanceInformation24 *-- ISO20022.Semt002002.Balance27
    ISO20022.Semt002002.SubBalanceInformation24 *-- ISO20022.Semt002002.SubBalanceType13Choice
    class ISO20022.Semt002002.SubBalanceQuantity9Choice {
        + QtyAndAvlbty  : ISO20022.Semt002002.QuantityAndAvailability4
        + Prtry  : ISO20022.Semt002002.GenericIdentification144
        + Qty  : ISO20022.Semt002002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Semt002002.SubBalanceQuantity9Choice *-- ISO20022.Semt002002.QuantityAndAvailability4
    ISO20022.Semt002002.SubBalanceQuantity9Choice *-- ISO20022.Semt002002.GenericIdentification144
    ISO20022.Semt002002.SubBalanceQuantity9Choice *-- ISO20022.Semt002002.FinancialInstrumentQuantity36Choice
    class ISO20022.Semt002002.SubBalanceType13Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.SubBalanceType13Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.SubBalanceType14Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.SubBalanceType14Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.SupplementaryData1 {
        + Envlp  : ISO20022.Semt002002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Semt002002.SupplementaryData1 *-- ISO20022.Semt002002.SupplementaryDataEnvelope1
    class ISO20022.Semt002002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Semt002002.TotalValueInPageAndStatement3 {
        + TtlElgblCollVal  : ISO20022.Semt002002.AmountAndDirection14
        + TtlBookValOfStmt  : ISO20022.Semt002002.AmountAndDirection14
        + TtlHldgsValOfStmt  : ISO20022.Semt002002.AmountAndDirection14
        + TtlHldgsValOfPg  : ISO20022.Semt002002.AmountAndDirection14
    }
    ISO20022.Semt002002.TotalValueInPageAndStatement3 *-- ISO20022.Semt002002.AmountAndDirection14
    ISO20022.Semt002002.TotalValueInPageAndStatement3 *-- ISO20022.Semt002002.AmountAndDirection14
    ISO20022.Semt002002.TotalValueInPageAndStatement3 *-- ISO20022.Semt002002.AmountAndDirection14
    ISO20022.Semt002002.TotalValueInPageAndStatement3 *-- ISO20022.Semt002002.AmountAndDirection14
    class ISO20022.Semt002002.TypeOfPrice11Code {
        INDC = 1
        MRKT = 2
        SWIC = 3
        RINV = 4
        MIDD = 5
        SWNG = 6
        INTE = 7
        CANC = 8
        CREA = 9
        NAVL = 10
        OFFR = 11
        BIDE = 12
    }
    class ISO20022.Semt002002.TypeOfPrice14Code {
        AVER = 1
    }
    class ISO20022.Semt002002.TypeOfPrice32Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.TypeOfPrice32Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.TypeOfPrice33Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.TypeOfPrice33Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.UpdateType16Choice {
        + Prtry  : ISO20022.Semt002002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt002002.UpdateType16Choice *-- ISO20022.Semt002002.GenericIdentification47
    class ISO20022.Semt002002.YieldedOrValueType1Choice {
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

## Value ISO20022.Semt002002.Account30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|ISO20022.Semt002002.PartyIdentification137Choice||XmlElement()||
|+|Id|ISO20022.Semt002002.AccountIdentification4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcr),validElement(Id))|

---

## Value ISO20022.Semt002002.AccountIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.SimpleIdentificationInformation1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry))|

---

## Value ISO20022.Semt002002.AdditionalBalanceInformation24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002002.QuantityBreakdown71>||XmlElement()||
|+|SubBalAddtlDtls|String||XmlElement()||
|+|Qty|ISO20022.Semt002002.Balance27||XmlElement()||
|+|SubBalTp|ISO20022.Semt002002.SubBalanceType14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validPattern("""SubBalAddtlDtls""",SubBalAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validElement(Qty),validElement(SubBalTp))|

---

## Value ISO20022.Semt002002.AggregateBalanceInformation44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt002002.SupplementaryData1>||XmlElement()||
|+|HldgAddtlDtls|String||XmlElement()||
|+|BalAtSfkpgPlc|global::System.Collections.Generic.List<ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41>||XmlElement()||
|+|AddtlBalBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002002.AdditionalBalanceInformation24>||XmlElement()||
|+|BalBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002002.SubBalanceInformation24>||XmlElement()||
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002002.QuantityBreakdown71>||XmlElement()||
|+|InstrmCcyAmts|ISO20022.Semt002002.BalanceAmounts4||XmlElement()||
|+|AcctBaseCcyAmts|ISO20022.Semt002002.BalanceAmounts4||XmlElement()||
|+|DaysAcrd|Decimal||XmlElement()||
|+|FXDtls|global::System.Collections.Generic.List<ISO20022.Semt002002.ForeignExchangeTerms35>||XmlElement()||
|+|PricDtls|global::System.Collections.Generic.List<ISO20022.Semt002002.PriceInformation22>||XmlElement()||
|+|CorpActnOptnTp|String||XmlElement()||
|+|SfkpgPlc|ISO20022.Semt002002.SafeKeepingPlace4||XmlElement()||
|+|NotAvlblBal|ISO20022.Semt002002.BalanceQuantity17Choice||XmlElement()||
|+|AvlblBal|ISO20022.Semt002002.Balance25||XmlElement()||
|+|AggtBal|ISO20022.Semt002002.Balance22||XmlElement()||
|+|ValtnHrcutDtls|ISO20022.Semt002002.BasicCollateralValuation1Details||XmlElement()||
|+|InvstmtFndsFinInstrmAttrbts|ISO20022.Semt002002.FinancialInstrument22||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Semt002002.FinancialInstrumentAttributes122||XmlElement()||
|+|FinInstrmId|ISO20022.Semt002002.SecurityIdentification20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validPattern("""HldgAddtlDtls""",HldgAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validList("""BalAtSfkpgPlc""",BalAtSfkpgPlc),validElement(BalAtSfkpgPlc),validList("""AddtlBalBrkdwn""",AddtlBalBrkdwn),validElement(AddtlBalBrkdwn),validList("""BalBrkdwn""",BalBrkdwn),validElement(BalBrkdwn),validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(InstrmCcyAmts),validElement(AcctBaseCcyAmts),validList("""FXDtls""",FXDtls),validElement(FXDtls),validList("""PricDtls""",PricDtls),validElement(PricDtls),validElement(SfkpgPlc),validElement(NotAvlblBal),validElement(AvlblBal),validElement(AggtBal),validElement(ValtnHrcutDtls),validElement(InvstmtFndsFinInstrmAttrbts),validElement(FinInstrmAttrbts),validElement(FinInstrmId))|

---

## Value ISO20022.Semt002002.AggregateBalancePerSafekeepingPlace41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HldgAddtlDtls|String||XmlElement()||
|+|AddtlBalBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002002.AdditionalBalanceInformation24>||XmlElement()||
|+|BalBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002002.SubBalanceInformation24>||XmlElement()||
|+|XpsrTp|ISO20022.Semt002002.ExposureType24Choice||XmlElement()||
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002002.QuantityBreakdown71>||XmlElement()||
|+|InstrmCcyAmts|ISO20022.Semt002002.BalanceAmounts4||XmlElement()||
|+|AcctBaseCcyAmts|ISO20022.Semt002002.BalanceAmounts4||XmlElement()||
|+|DaysAcrd|Decimal||XmlElement()||
|+|FXDtls|global::System.Collections.Generic.List<ISO20022.Semt002002.ForeignExchangeTerms35>||XmlElement()||
|+|PricDtls|global::System.Collections.Generic.List<ISO20022.Semt002002.PriceInformation22>||XmlElement()||
|+|NotAvlblBal|ISO20022.Semt002002.BalanceQuantity17Choice||XmlElement()||
|+|AvlblBal|ISO20022.Semt002002.Balance25||XmlElement()||
|+|AggtBal|ISO20022.Semt002002.Balance22||XmlElement()||
|+|Pldgee|ISO20022.Semt002002.Pledgee4||XmlElement()||
|+|PlcOfListg|ISO20022.Semt002002.MarketIdentification4Choice||XmlElement()||
|+|SfkpgPlc|ISO20022.Semt002002.SafeKeepingPlace4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""HldgAddtlDtls""",HldgAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validList("""AddtlBalBrkdwn""",AddtlBalBrkdwn),validElement(AddtlBalBrkdwn),validList("""BalBrkdwn""",BalBrkdwn),validElement(BalBrkdwn),validElement(XpsrTp),validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(InstrmCcyAmts),validElement(AcctBaseCcyAmts),validList("""FXDtls""",FXDtls),validElement(FXDtls),validList("""PricDtls""",PricDtls),validElement(PricDtls),validElement(NotAvlblBal),validElement(AvlblBal),validElement(AggtBal),validElement(Pldgee),validElement(PlcOfListg),validElement(SfkpgPlc))|

---

## Value ISO20022.Semt002002.AmountAndDirection14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Semt002002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Semt002002.Balance22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Semt002002.BalanceQuantity15Choice||XmlElement()||
|+|ShrtLngInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Semt002002.Balance23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Semt002002.BalanceQuantity15Choice||XmlElement()||
|+|ShrtLngInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Semt002002.Balance25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Semt002002.BalanceQuantity17Choice||XmlElement()||
|+|ShrtLngInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Semt002002.Balance27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Semt002002.SubBalanceQuantity9Choice||XmlElement()||
|+|ShrtLngInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Semt002002.BalanceAmounts4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcrdIntrstAmt|ISO20022.Semt002002.AmountAndDirection14||XmlElement()||
|+|ElgblCollVal|ISO20022.Semt002002.AmountAndDirection14||XmlElement()||
|+|BookVal|ISO20022.Semt002002.AmountAndDirection14||XmlElement()||
|+|PrvsHldgVal|ISO20022.Semt002002.AmountAndDirection14||XmlElement()||
|+|HldgVal|ISO20022.Semt002002.AmountAndDirection14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcrdIntrstAmt),validElement(ElgblCollVal),validElement(BookVal),validElement(PrvsHldgVal),validElement(HldgVal))|

---

## Value ISO20022.Semt002002.BalanceQuantity15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification144||XmlElement()||
|+|Qty|ISO20022.Semt002002.Quantity54Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Qty),validChoice(Prtry,Qty))|

---

## Value ISO20022.Semt002002.BalanceQuantity17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification144||XmlElement()||
|+|Qty|ISO20022.Semt002002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Qty),validChoice(Prtry,Qty))|

---

## Value ISO20022.Semt002002.BasicCollateralValuation1Details


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HrcutSrc|ISO20022.Semt002002.PartyIdentification15||XmlElement()||
|+|ValtnHrcut|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(HrcutSrc))|

---

## Value ISO20022.Semt002002.BlockChainAddressWallet10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dsgnt|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt002002.PurposeCode8Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Dsgnt""",Dsgnt,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Semt002002.BlockChainAddressWallet6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt002002.PurposeCode7Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Semt002002.ClassificationType33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Semt002002.GenericIdentification86||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Enum ISO20022.Semt002002.CorporateActionOption5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SECU|Int32||XmlEnum("""SECU""")|1|
||CASH|Int32||XmlEnum("""CASH""")|2|

---

## Value ISO20022.Semt002002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Semt002002.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||DIST|Int32||XmlEnum("""DIST""")|2|

---

## Type ISO20022.Semt002002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesBalCtdyRpt|ISO20022.Semt002002.SecuritiesBalanceCustodyReport002V11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesBalCtdyRpt))|

---

## Enum ISO20022.Semt002002.EventFrequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||SEMI|Int32||XmlEnum("""SEMI""")|2|
||QUTR|Int32||XmlEnum("""QUTR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|

---

## Enum ISO20022.Semt002002.EventFrequency7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONDE|Int32||XmlEnum("""ONDE""")|1|
||OVNG|Int32||XmlEnum("""OVNG""")|2|
||TWMN|Int32||XmlEnum("""TWMN""")|3|
||TOWK|Int32||XmlEnum("""TOWK""")|4|
||TOMN|Int32||XmlEnum("""TOMN""")|5|
||QUTR|Int32||XmlEnum("""QUTR""")|6|
||SEMI|Int32||XmlEnum("""SEMI""")|7|
||WEEK|Int32||XmlEnum("""WEEK""")|8|
||INDA|Int32||XmlEnum("""INDA""")|9|
||DAIL|Int32||XmlEnum("""DAIL""")|10|
||MNTH|Int32||XmlEnum("""MNTH""")|11|
||ADHO|Int32||XmlEnum("""ADHO""")|12|
||YEAR|Int32||XmlEnum("""YEAR""")|13|

---

## Enum ISO20022.Semt002002.ExposureType12Code


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

## Value ISO20022.Semt002002.ExposureType24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002002.FinancialInstrument22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegdDstrbtnCtry|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CtryOfDmcl|String||XmlElement()||
|+|DualFndInd|String||XmlElement()||
|+|ReqdNAVCcy|String||XmlElement()||
|+|DnmtnCcy|String||XmlElement()||
|+|BaseCcy|String||XmlElement()||
|+|UmbrllNm|String||XmlElement()||
|+|PdctGrp|String||XmlElement()||
|+|DstrbtnPlcy|String||XmlElement()||
|+|SctiesForm|String||XmlElement()||
|+|ClssTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RegdDstrbtnCtry""",RegdDstrbtnCtry,"""[A-Z]{2,2}"""),validPattern("""CtryOfDmcl""",CtryOfDmcl,"""[A-Z]{2,2}"""),validPattern("""ReqdNAVCcy""",ReqdNAVCcy,"""[A-Z]{3,3}"""),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validPattern("""BaseCcy""",BaseCcy,"""[A-Z]{3,3}"""),validPattern("""PdctGrp""",PdctGrp,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Semt002002.FinancialInstrumentAttributes122


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmAttrAddtlDtls|String||XmlElement()||
|+|UndrlygFinInstrmId|global::System.Collections.Generic.List<ISO20022.Semt002002.SecurityIdentification20>||XmlElement()||
|+|CtrctSz|ISO20022.Semt002002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Semt002002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|StrkPric|ISO20022.Semt002002.Price3||XmlElement()||
|+|ConvsPric|ISO20022.Semt002002.Price3||XmlElement()||
|+|SbcptPric|ISO20022.Semt002002.Price3||XmlElement()||
|+|ExrcPric|ISO20022.Semt002002.Price3||XmlElement()||
|+|MktOrIndctvPric|ISO20022.Semt002002.PriceType5Choice||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|PoolNb|ISO20022.Semt002002.GenericIdentification39||XmlElement()||
|+|CpnAttchdNb|ISO20022.Semt002002.Number23Choice||XmlElement()||
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
|+|OptnTp|ISO20022.Semt002002.OptionType7Choice||XmlElement()||
|+|OptnStyle|ISO20022.Semt002002.OptionStyle9Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Semt002002.ClassificationType33Choice||XmlElement()||
|+|VarblRateChngFrqcy|ISO20022.Semt002002.Frequency27Choice||XmlElement()||
|+|PmtSts|ISO20022.Semt002002.SecuritiesPaymentStatus6Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Semt002002.Frequency27Choice||XmlElement()||
|+|RegnForm|ISO20022.Semt002002.FormOfSecurity7Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Semt002002.InterestComputationMethodFormat5Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Semt002002.MarketIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FinInstrmAttrAddtlDtls""",FinInstrmAttrAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validList("""UndrlygFinInstrmId""",UndrlygFinInstrmId),validElement(UndrlygFinInstrmId),validElement(CtrctSz),validElement(MinNmnlQty),validElement(StrkPric),validElement(ConvsPric),validElement(SbcptPric),validElement(ExrcPric),validElement(MktOrIndctvPric),validElement(PoolNb),validElement(CpnAttchdNb),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnTp),validElement(OptnStyle),validElement(ClssfctnTp),validElement(VarblRateChngFrqcy),validElement(PmtSts),validElement(PmtFrqcy),validElement(RegnForm),validElement(DayCntBsis),validElement(PlcOfListg))|

---

## Value ISO20022.Semt002002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Semt002002.ForeignExchangeTerms35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtgInstn|ISO20022.Semt002002.PartyIdentification137Choice||XmlElement()||
|+|QtnDt|DateTime||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtgInstn),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Semt002002.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Semt002002.FormOfSecurity7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002002.Frequency27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002002.Frequency34Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002002.GenericIdentification144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|Decimal||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt002002.GenericIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt002002.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt002002.GenericIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""([^/]+/)+([^/]+)\|([^/]*)"""),validPattern("""Id""",Id,"""([^/]+/)+([^/]+)\|([^/]*)"""))|

---

## Value ISO20022.Semt002002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt002002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt002002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Semt002002.GenericIdentification86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt002002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt002002.InterestComputationMethod2Code


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

## Value ISO20022.Semt002002.InterestComputationMethodFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002002.Intermediary45


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Acct|ISO20022.Semt002002.Account30||XmlElement()||
|+|Role|ISO20022.Semt002002.Role7Choice||XmlElement()||
|+|Id|ISO20022.Semt002002.PartyIdentification157||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Acct),validElement(Role),validElement(Id))|

---

## Enum ISO20022.Semt002002.InvestmentFundRole2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAN|Int32||XmlEnum("""TRAN""")|1|
||UCL2|Int32||XmlEnum("""UCL2""")|2|
||UCL1|Int32||XmlEnum("""UCL1""")|3|
||CONC|Int32||XmlEnum("""CONC""")|4|
||DIST|Int32||XmlEnum("""DIST""")|5|
||INTR|Int32||XmlEnum("""INTR""")|6|
||TRAG|Int32||XmlEnum("""TRAG""")|7|
||REGI|Int32||XmlEnum("""REGI""")|8|
||FMCO|Int32||XmlEnum("""FMCO""")|9|

---

## Value ISO20022.Semt002002.MarketIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Semt002002.MarketIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Semt002002.MarketIdentification91


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt002002.MarketType17Choice||XmlElement()||
|+|Id|ISO20022.Semt002002.MarketIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Semt002002.MarketType17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt002002.MarketType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VEND|Int32||XmlEnum("""VEND""")|1|
||THEO|Int32||XmlEnum("""THEO""")|2|
||LMAR|Int32||XmlEnum("""LMAR""")|3|
||FUND|Int32||XmlEnum("""FUND""")|4|

---

## Value ISO20022.Semt002002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Semt002002.Number23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|ISO20022.Semt002002.GenericIdentification18||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lng),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Value ISO20022.Semt002002.Number3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|String||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lng""",Lng,"""[0-9]{5}"""),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Enum ISO20022.Semt002002.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Semt002002.OptionStyle9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt002002.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Semt002002.OptionType7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002002.OriginalAndCurrentQuantities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt002002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt002002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Semt002002.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Semt002002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Semt002002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Semt002002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Semt002002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Semt002002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Semt002002.PartyIdentification15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Semt002002.PartyIdentification156


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt002002.PartyIdentification136Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt002002.PartyIdentification157


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt002002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt002002.Pledgee4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|PldgeeTpAndId|ISO20022.Semt002002.PledgeeFormat6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(PldgeeTpAndId))|

---

## Value ISO20022.Semt002002.PledgeeFormat6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification85||XmlElement()||
|+|Id|ISO20022.Semt002002.PledgeeTypeAndText2||XmlElement()||
|+|TpAndId|ISO20022.Semt002002.PledgeeTypeAndAnyBICIdentifier2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Id),validElement(TpAndId),validChoice(Prtry,Id,TpAndId))|

---

## Enum ISO20022.Semt002002.PledgeeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGB|Int32||XmlEnum("""REGB""")|1|
||CPTY|Int32||XmlEnum("""CPTY""")|2|

---

## Value ISO20022.Semt002002.PledgeeTypeAndAnyBICIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PldgeeTp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt002002.PledgeeTypeAndText2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PldgeeTp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([^/]+/)+([^/]+)\|([^/]*)"""))|

---

## Value ISO20022.Semt002002.Price3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Semt002002.PriceRateOrAmount1Choice||XmlElement()||
|+|Tp|ISO20022.Semt002002.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Semt002002.PriceInformation22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtnDt|ISO20022.Semt002002.DateAndDateTime2Choice||XmlElement()||
|+|SrcOfPric|ISO20022.Semt002002.MarketIdentification91||XmlElement()||
|+|ValTp|ISO20022.Semt002002.YieldedOrValueType1Choice||XmlElement()||
|+|Val|ISO20022.Semt002002.PriceRateOrAmountOrUnknown3Choice||XmlElement()||
|+|Tp|ISO20022.Semt002002.TypeOfPrice33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtnDt),validElement(SrcOfPric),validElement(ValTp),validElement(Val),validElement(Tp))|

---

## Value ISO20022.Semt002002.PriceRateOrAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Semt002002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Semt002002.PriceRateOrAmountOrUnknown3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UknwnInd|String||XmlElement()||
|+|Amt|ISO20022.Semt002002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(UknwnInd,Amt,Rate))|

---

## Value ISO20022.Semt002002.PriceType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indctv|ISO20022.Semt002002.Price3||XmlElement()||
|+|Mkt|ISO20022.Semt002002.Price3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indctv),validElement(Mkt),validChoice(Indctv,Mkt))|

---

## Enum ISO20022.Semt002002.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Semt002002.PurposeCode7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002002.PurposeCode8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002002.Quantity54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Semt002002.OriginalAndCurrentQuantities4||XmlElement()||
|+|Qty|ISO20022.Semt002002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Semt002002.QuantityAndAvailability4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AvlbtyInd|String||XmlElement()||
|+|Qty|ISO20022.Semt002002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Semt002002.QuantityBreakdown71


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TpOfPric|ISO20022.Semt002002.TypeOfPrice32Choice||XmlElement()||
|+|LotPric|ISO20022.Semt002002.Price3||XmlElement()||
|+|LotDtTm|ISO20022.Semt002002.DateAndDateTime2Choice||XmlElement()||
|+|LotQty|ISO20022.Semt002002.Balance23||XmlElement()||
|+|LotNb|ISO20022.Semt002002.GenericIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TpOfPric),validElement(LotPric),validElement(LotDtTm),validElement(LotQty),validElement(LotNb))|

---

## Value ISO20022.Semt002002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt002002.RestrictedFINActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt002002.Role7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Txt""",Txt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validElement(Prtry),validChoice(Txt,Prtry,Cd))|

---

## Value ISO20022.Semt002002.SafeKeepingPlace4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Semt002002.SafekeepingPlaceFormat39Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Semt002002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Semt002002.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Semt002002.SafekeepingPlaceFormat39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Semt002002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Semt002002.SafekeepingPlaceTypeAndText15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Semt002002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt002002.SafekeepingPlaceTypeAndText15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt002002.SecuritiesAccount34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt002002.PurposeCode8Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Semt002002.SecuritiesAccount42


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dsgnt|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt002002.PurposeCode8Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Dsgnt""",Dsgnt,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Enum ISO20022.Semt002002.SecuritiesAccountPurposeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHYS|Int32||XmlEnum("""PHYS""")|1|
||DVPA|Int32||XmlEnum("""DVPA""")|2|
||CEND|Int32||XmlEnum("""CEND""")|3|
||ABRD|Int32||XmlEnum("""ABRD""")|4|
||SHOR|Int32||XmlEnum("""SHOR""")|5|
||MARG|Int32||XmlEnum("""MARG""")|6|

---

## Aspect ISO20022.Semt002002.SecuritiesBalanceCustodyReport002V11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctBaseCcyTtlAmts|ISO20022.Semt002002.TotalValueInPageAndStatement3||XmlElement()||
|+|SubAcctDtls|global::System.Collections.Generic.List<ISO20022.Semt002002.SubAccountIdentification69>||XmlElement()||
|+|BalForAcct|global::System.Collections.Generic.List<ISO20022.Semt002002.AggregateBalanceInformation44>||XmlElement()||
|+|IntrmyInf|global::System.Collections.Generic.List<ISO20022.Semt002002.Intermediary45>||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt002002.BlockChainAddressWallet10||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt002002.SecuritiesAccount42||XmlElement()||
|+|AcctSvcr|ISO20022.Semt002002.PartyIdentification157||XmlElement()||
|+|AcctOwnr|ISO20022.Semt002002.PartyIdentification156||XmlElement()||
|+|StmtGnlDtls|ISO20022.Semt002002.Statement77||XmlElement()||
|+|Pgntn|ISO20022.Semt002002.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctBaseCcyTtlAmts),validList("""SubAcctDtls""",SubAcctDtls),validElement(SubAcctDtls),validList("""BalForAcct""",BalForAcct),validElement(BalForAcct),validList("""IntrmyInf""",IntrmyInf),validListMax("""IntrmyInf""",IntrmyInf,10),validElement(IntrmyInf),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctSvcr),validElement(AcctOwnr),validElement(StmtGnlDtls),validElement(Pgntn))|

---

## Enum ISO20022.Semt002002.SecuritiesBalanceType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BTRA|Int32||XmlEnum("""BTRA""")|1|
||WDOC|Int32||XmlEnum("""WDOC""")|2|
||DRAW|Int32||XmlEnum("""DRAW""")|3|
||TRAN|Int32||XmlEnum("""TRAN""")|4|
||OTHR|Int32||XmlEnum("""OTHR""")|5|
||RSTR|Int32||XmlEnum("""RSTR""")|6|
||REGO|Int32||XmlEnum("""REGO""")|7|
||PLED|Int32||XmlEnum("""PLED""")|8|
||PENR|Int32||XmlEnum("""PENR""")|9|
||PEND|Int32||XmlEnum("""PEND""")|10|
||PEDA|Int32||XmlEnum("""PEDA""")|11|
||PECA|Int32||XmlEnum("""PECA""")|12|
||MARG|Int32||XmlEnum("""MARG""")|13|
||LORE|Int32||XmlEnum("""LORE""")|14|
||LODE|Int32||XmlEnum("""LODE""")|15|
||LOAN|Int32||XmlEnum("""LOAN""")|16|
||COLO|Int32||XmlEnum("""COLO""")|17|
||COLI|Int32||XmlEnum("""COLI""")|18|
||BORE|Int32||XmlEnum("""BORE""")|19|
||BODE|Int32||XmlEnum("""BODE""")|20|
||BORR|Int32||XmlEnum("""BORR""")|21|
||BLOV|Int32||XmlEnum("""BLOV""")|22|
||BLOT|Int32||XmlEnum("""BLOT""")|23|
||BLCA|Int32||XmlEnum("""BLCA""")|24|
||AWAS|Int32||XmlEnum("""AWAS""")|25|
||BLOK|Int32||XmlEnum("""BLOK""")|26|

---

## Enum ISO20022.Semt002002.SecuritiesBalanceType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||QUAS|Int32||XmlEnum("""QUAS""")|1|
||ISSU|Int32||XmlEnum("""ISSU""")|2|
||UNRG|Int32||XmlEnum("""UNRG""")|3|
||SPOS|Int32||XmlEnum("""SPOS""")|4|
||NOMI|Int32||XmlEnum("""NOMI""")|5|
||DIRT|Int32||XmlEnum("""DIRT""")|6|
||CLEN|Int32||XmlEnum("""CLEN""")|7|
||OTHR|Int32||XmlEnum("""OTHR""")|8|
||COLA|Int32||XmlEnum("""COLA""")|9|

---

## Enum ISO20022.Semt002002.SecuritiesPaymentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NILL|Int32||XmlEnum("""NILL""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Semt002002.SecuritiesPaymentStatus6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Semt002002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Semt002002.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Semt002002.SimpleIdentificationInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Semt002002.Statement77


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyIntrstOrSetOff|String||XmlElement()||
|+|SubAcctInd|String||XmlElement()||
|+|ActvtyInd|String||XmlElement()||
|+|StmtBsis|ISO20022.Semt002002.StatementBasis9Choice||XmlElement()||
|+|UpdTp|ISO20022.Semt002002.UpdateType16Choice||XmlElement()||
|+|Frqcy|ISO20022.Semt002002.Frequency34Choice||XmlElement()||
|+|StmtDtTm|ISO20022.Semt002002.DateAndDateTime2Choice||XmlElement()||
|+|StmtId|String||XmlElement()||
|+|QryRef|String||XmlElement()||
|+|RptNb|ISO20022.Semt002002.Number3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmtBsis),validElement(UpdTp),validElement(Frqcy),validElement(StmtDtTm),validPattern("""StmtId""",StmtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""QryRef""",QryRef,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(RptNb))|

---

## Enum ISO20022.Semt002002.StatementBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAD|Int32||XmlEnum("""TRAD""")|1|
||SETT|Int32||XmlEnum("""SETT""")|2|
||CONT|Int32||XmlEnum("""CONT""")|3|

---

## Value ISO20022.Semt002002.StatementBasis9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt002002.StatementUpdateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Semt002002.SubAccountIdentification69


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BalForSubAcct|global::System.Collections.Generic.List<ISO20022.Semt002002.AggregateBalanceInformation44>||XmlElement()||
|+|ActvtyInd|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt002002.BlockChainAddressWallet6||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt002002.SecuritiesAccount34||XmlElement()||
|+|AcctOwnr|ISO20022.Semt002002.PartyIdentification156||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""BalForSubAcct""",BalForSubAcct),validElement(BalForSubAcct),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr))|

---

## Value ISO20022.Semt002002.SubBalanceInformation24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlBalBrkdwnDtls|global::System.Collections.Generic.List<ISO20022.Semt002002.AdditionalBalanceInformation24>||XmlElement()||
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002002.QuantityBreakdown71>||XmlElement()||
|+|SubBalAddtlDtls|String||XmlElement()||
|+|Qty|ISO20022.Semt002002.Balance27||XmlElement()||
|+|SubBalTp|ISO20022.Semt002002.SubBalanceType13Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlBalBrkdwnDtls""",AddtlBalBrkdwnDtls),validElement(AddtlBalBrkdwnDtls),validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validPattern("""SubBalAddtlDtls""",SubBalAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validElement(Qty),validElement(SubBalTp))|

---

## Value ISO20022.Semt002002.SubBalanceQuantity9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyAndAvlbty|ISO20022.Semt002002.QuantityAndAvailability4||XmlElement()||
|+|Prtry|ISO20022.Semt002002.GenericIdentification144||XmlElement()||
|+|Qty|ISO20022.Semt002002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyAndAvlbty),validElement(Prtry),validElement(Qty),validChoice(QtyAndAvlbty,Prtry,Qty))|

---

## Value ISO20022.Semt002002.SubBalanceType13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002002.SubBalanceType14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Semt002002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Semt002002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt002002.TotalValueInPageAndStatement3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlElgblCollVal|ISO20022.Semt002002.AmountAndDirection14||XmlElement()||
|+|TtlBookValOfStmt|ISO20022.Semt002002.AmountAndDirection14||XmlElement()||
|+|TtlHldgsValOfStmt|ISO20022.Semt002002.AmountAndDirection14||XmlElement()||
|+|TtlHldgsValOfPg|ISO20022.Semt002002.AmountAndDirection14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlElgblCollVal),validElement(TtlBookValOfStmt),validElement(TtlHldgsValOfStmt),validElement(TtlHldgsValOfPg))|

---

## Enum ISO20022.Semt002002.TypeOfPrice11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDC|Int32||XmlEnum("""INDC""")|1|
||MRKT|Int32||XmlEnum("""MRKT""")|2|
||SWIC|Int32||XmlEnum("""SWIC""")|3|
||RINV|Int32||XmlEnum("""RINV""")|4|
||MIDD|Int32||XmlEnum("""MIDD""")|5|
||SWNG|Int32||XmlEnum("""SWNG""")|6|
||INTE|Int32||XmlEnum("""INTE""")|7|
||CANC|Int32||XmlEnum("""CANC""")|8|
||CREA|Int32||XmlEnum("""CREA""")|9|
||NAVL|Int32||XmlEnum("""NAVL""")|10|
||OFFR|Int32||XmlEnum("""OFFR""")|11|
||BIDE|Int32||XmlEnum("""BIDE""")|12|

---

## Enum ISO20022.Semt002002.TypeOfPrice14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AVER|Int32||XmlEnum("""AVER""")|1|

---

## Value ISO20022.Semt002002.TypeOfPrice32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002002.TypeOfPrice33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002002.UpdateType16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002002.YieldedOrValueType1Choice


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

