# semt.002.001.12
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt002001.Account29 {
        + AcctSvcr  : ISO20022.Semt002001.PartyIdentification120Choice
        + Id  : ISO20022.Semt002001.AccountIdentification26
    }
    ISO20022.Semt002001.Account29 *-- ISO20022.Semt002001.PartyIdentification120Choice
    ISO20022.Semt002001.Account29 *-- ISO20022.Semt002001.AccountIdentification26
    class ISO20022.Semt002001.AccountIdentification26 {
        + Prtry  : ISO20022.Semt002001.SimpleIdentificationInformation4
    }
    ISO20022.Semt002001.AccountIdentification26 *-- ISO20022.Semt002001.SimpleIdentificationInformation4
    class ISO20022.Semt002001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt002001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt002001.AdditionalBalanceInformation20 {
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002001.QuantityBreakdown57~
        + SubBalAddtlDtls  : String
        + Qty  : ISO20022.Semt002001.Balance21
        + SubBalTp  : ISO20022.Semt002001.SubBalanceType12Choice
    }
    ISO20022.Semt002001.AdditionalBalanceInformation20 *-- ISO20022.Semt002001.QuantityBreakdown57
    ISO20022.Semt002001.AdditionalBalanceInformation20 *-- ISO20022.Semt002001.Balance21
    ISO20022.Semt002001.AdditionalBalanceInformation20 *-- ISO20022.Semt002001.SubBalanceType12Choice
    class ISO20022.Semt002001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Semt002001.AggregateBalanceInformation46 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt002001.SupplementaryData1~
        + HldgAddtlDtls  : String
        + BalAtSfkpgPlc  : global::System.Collections.Generic.List~ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43~
        + AddtlBalBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002001.AdditionalBalanceInformation20~
        + BalBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002001.SubBalanceInformation20~
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002001.QuantityBreakdown57~
        + InstrmCcyAmts  : ISO20022.Semt002001.BalanceAmounts3
        + AcctBaseCcyAmts  : ISO20022.Semt002001.BalanceAmounts3
        + DaysAcrd  : Decimal
        + FXDtls  : global::System.Collections.Generic.List~ISO20022.Semt002001.ForeignExchangeTerms34~
        + PricDtls  : global::System.Collections.Generic.List~ISO20022.Semt002001.PriceInformation29~
        + CorpActnOptnTp  : String
        + SfkpgPlc  : ISO20022.Semt002001.SafeKeepingPlace5
        + NotAvlblBal  : ISO20022.Semt002001.BalanceQuantity14Choice
        + AvlblBal  : ISO20022.Semt002001.Balance18
        + AggtBal  : ISO20022.Semt002001.Balance17
        + ValtnHrcutDtls  : ISO20022.Semt002001.BasicCollateralValuation1Details
        + InvstmtFndsFinInstrmAttrbts  : ISO20022.Semt002001.FinancialInstrument21
        + FinInstrmAttrbts  : ISO20022.Semt002001.FinancialInstrumentAttributes111
        + FinInstrmId  : ISO20022.Semt002001.SecurityIdentification19
    }
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.SupplementaryData1
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.AdditionalBalanceInformation20
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.SubBalanceInformation20
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.QuantityBreakdown57
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.BalanceAmounts3
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.BalanceAmounts3
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.ForeignExchangeTerms34
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.PriceInformation29
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.SafeKeepingPlace5
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.BalanceQuantity14Choice
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.Balance18
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.Balance17
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.BasicCollateralValuation1Details
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.FinancialInstrument21
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.FinancialInstrumentAttributes111
    ISO20022.Semt002001.AggregateBalanceInformation46 *-- ISO20022.Semt002001.SecurityIdentification19
    class ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43 {
        + HldgAddtlDtls  : String
        + AddtlBalBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002001.AdditionalBalanceInformation20~
        + BalBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002001.SubBalanceInformation20~
        + XpsrTp  : ISO20022.Semt002001.ExposureType25Choice
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002001.QuantityBreakdown57~
        + InstrmCcyAmts  : ISO20022.Semt002001.BalanceAmounts3
        + AcctBaseCcyAmts  : ISO20022.Semt002001.BalanceAmounts3
        + DaysAcrd  : Decimal
        + FXDtls  : global::System.Collections.Generic.List~ISO20022.Semt002001.ForeignExchangeTerms34~
        + PricDtls  : global::System.Collections.Generic.List~ISO20022.Semt002001.PriceInformation29~
        + NotAvlblBal  : ISO20022.Semt002001.BalanceQuantity14Choice
        + AvlblBal  : ISO20022.Semt002001.Balance18
        + AggtBal  : ISO20022.Semt002001.Balance17
        + Pldgee  : ISO20022.Semt002001.Pledgee3
        + PlcOfListg  : ISO20022.Semt002001.MarketIdentification3Choice
        + SfkpgPlc  : ISO20022.Semt002001.SafeKeepingPlace5
    }
    ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43 *-- ISO20022.Semt002001.AdditionalBalanceInformation20
    ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43 *-- ISO20022.Semt002001.SubBalanceInformation20
    ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43 *-- ISO20022.Semt002001.ExposureType25Choice
    ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43 *-- ISO20022.Semt002001.QuantityBreakdown57
    ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43 *-- ISO20022.Semt002001.BalanceAmounts3
    ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43 *-- ISO20022.Semt002001.BalanceAmounts3
    ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43 *-- ISO20022.Semt002001.ForeignExchangeTerms34
    ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43 *-- ISO20022.Semt002001.PriceInformation29
    ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43 *-- ISO20022.Semt002001.BalanceQuantity14Choice
    ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43 *-- ISO20022.Semt002001.Balance18
    ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43 *-- ISO20022.Semt002001.Balance17
    ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43 *-- ISO20022.Semt002001.Pledgee3
    ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43 *-- ISO20022.Semt002001.MarketIdentification3Choice
    ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43 *-- ISO20022.Semt002001.SafeKeepingPlace5
    class ISO20022.Semt002001.AmountAndDirection6 {
        + Sgn  : String
        + Amt  : ISO20022.Semt002001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Semt002001.AmountAndDirection6 *-- ISO20022.Semt002001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Semt002001.Balance16 {
        + Qty  : ISO20022.Semt002001.BalanceQuantity13Choice
        + ShrtLngInd  : String
    }
    ISO20022.Semt002001.Balance16 *-- ISO20022.Semt002001.BalanceQuantity13Choice
    class ISO20022.Semt002001.Balance17 {
        + Qty  : ISO20022.Semt002001.BalanceQuantity13Choice
        + ShrtLngInd  : String
    }
    ISO20022.Semt002001.Balance17 *-- ISO20022.Semt002001.BalanceQuantity13Choice
    class ISO20022.Semt002001.Balance18 {
        + Qty  : ISO20022.Semt002001.BalanceQuantity14Choice
        + ShrtLngInd  : String
    }
    ISO20022.Semt002001.Balance18 *-- ISO20022.Semt002001.BalanceQuantity14Choice
    class ISO20022.Semt002001.Balance21 {
        + Qty  : ISO20022.Semt002001.SubBalanceQuantity8Choice
        + ShrtLngInd  : String
    }
    ISO20022.Semt002001.Balance21 *-- ISO20022.Semt002001.SubBalanceQuantity8Choice
    class ISO20022.Semt002001.BalanceAmounts3 {
        + AcrdIntrstAmt  : ISO20022.Semt002001.AmountAndDirection6
        + ElgblCollVal  : ISO20022.Semt002001.AmountAndDirection6
        + BookVal  : ISO20022.Semt002001.AmountAndDirection6
        + PrvsHldgVal  : ISO20022.Semt002001.AmountAndDirection6
        + HldgVal  : ISO20022.Semt002001.AmountAndDirection6
    }
    ISO20022.Semt002001.BalanceAmounts3 *-- ISO20022.Semt002001.AmountAndDirection6
    ISO20022.Semt002001.BalanceAmounts3 *-- ISO20022.Semt002001.AmountAndDirection6
    ISO20022.Semt002001.BalanceAmounts3 *-- ISO20022.Semt002001.AmountAndDirection6
    ISO20022.Semt002001.BalanceAmounts3 *-- ISO20022.Semt002001.AmountAndDirection6
    ISO20022.Semt002001.BalanceAmounts3 *-- ISO20022.Semt002001.AmountAndDirection6
    class ISO20022.Semt002001.BalanceQuantity13Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification56
        + Qty  : ISO20022.Semt002001.Quantity51Choice
    }
    ISO20022.Semt002001.BalanceQuantity13Choice *-- ISO20022.Semt002001.GenericIdentification56
    ISO20022.Semt002001.BalanceQuantity13Choice *-- ISO20022.Semt002001.Quantity51Choice
    class ISO20022.Semt002001.BalanceQuantity14Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification56
        + Qty  : ISO20022.Semt002001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Semt002001.BalanceQuantity14Choice *-- ISO20022.Semt002001.GenericIdentification56
    ISO20022.Semt002001.BalanceQuantity14Choice *-- ISO20022.Semt002001.FinancialInstrumentQuantity33Choice
    class ISO20022.Semt002001.BasicCollateralValuation1Details {
        + HrcutSrc  : ISO20022.Semt002001.PartyIdentification15
        + ValtnHrcut  : Decimal
    }
    ISO20022.Semt002001.BasicCollateralValuation1Details *-- ISO20022.Semt002001.PartyIdentification15
    class ISO20022.Semt002001.BlockChainAddressWallet1 {
        + Dsgnt  : String
        + Nm  : String
        + Tp  : ISO20022.Semt002001.PurposeCode7Choice
        + Id  : String
    }
    ISO20022.Semt002001.BlockChainAddressWallet1 *-- ISO20022.Semt002001.PurposeCode7Choice
    class ISO20022.Semt002001.BlockChainAddressWallet2 {
        + Nm  : String
        + Tp  : ISO20022.Semt002001.PurposeCode7Choice
        + Id  : String
    }
    ISO20022.Semt002001.BlockChainAddressWallet2 *-- ISO20022.Semt002001.PurposeCode7Choice
    class ISO20022.Semt002001.ClassificationType32Choice {
        + AltrnClssfctn  : ISO20022.Semt002001.GenericIdentification36
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Semt002001.ClassificationType32Choice *-- ISO20022.Semt002001.GenericIdentification36
    class ISO20022.Semt002001.CorporateActionOption5Code {
        SECU = 1
        CASH = 2
    }
    class ISO20022.Semt002001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Semt002001.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class ISO20022.Semt002001.EventFrequency3Code {
        WEEK = 1
        SEMI = 2
        QUTR = 3
        MNTH = 4
        YEAR = 5
    }
    class ISO20022.Semt002001.EventFrequency7Code {
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
    class ISO20022.Semt002001.ExposureType15Code {
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
    class ISO20022.Semt002001.ExposureType25Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.ExposureType25Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.FinancialInstrument21 {
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
    class ISO20022.Semt002001.FinancialInstrumentAttributes111 {
        + FinInstrmAttrAddtlDtls  : String
        + UndrlygFinInstrmId  : global::System.Collections.Generic.List~ISO20022.Semt002001.SecurityIdentification19~
        + CtrctSz  : ISO20022.Semt002001.FinancialInstrumentQuantity33Choice
        + MinNmnlQty  : ISO20022.Semt002001.FinancialInstrumentQuantity33Choice
        + StrkPric  : ISO20022.Semt002001.Price7
        + ConvsPric  : ISO20022.Semt002001.Price7
        + SbcptPric  : ISO20022.Semt002001.Price7
        + ExrcPric  : ISO20022.Semt002001.Price7
        + MktOrIndctvPric  : ISO20022.Semt002001.PriceType4Choice
        + PutblInd  : String
        + CllblInd  : String
        + VarblRateInd  : String
        + PoolNb  : ISO20022.Semt002001.GenericIdentification37
        + CpnAttchdNb  : ISO20022.Semt002001.Number22Choice
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
        + OptnTp  : ISO20022.Semt002001.OptionType6Choice
        + OptnStyle  : ISO20022.Semt002001.OptionStyle8Choice
        + ClssfctnTp  : ISO20022.Semt002001.ClassificationType32Choice
        + VarblRateChngFrqcy  : ISO20022.Semt002001.Frequency23Choice
        + PmtSts  : ISO20022.Semt002001.SecuritiesPaymentStatus5Choice
        + PmtFrqcy  : ISO20022.Semt002001.Frequency23Choice
        + RegnForm  : ISO20022.Semt002001.FormOfSecurity6Choice
        + DayCntBsis  : ISO20022.Semt002001.InterestComputationMethodFormat4Choice
        + PlcOfListg  : ISO20022.Semt002001.MarketIdentification3Choice
    }
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.SecurityIdentification19
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.FinancialInstrumentQuantity33Choice
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.FinancialInstrumentQuantity33Choice
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.Price7
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.Price7
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.Price7
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.Price7
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.PriceType4Choice
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.GenericIdentification37
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.Number22Choice
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.OptionType6Choice
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.OptionStyle8Choice
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.ClassificationType32Choice
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.Frequency23Choice
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.SecuritiesPaymentStatus5Choice
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.Frequency23Choice
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.FormOfSecurity6Choice
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.InterestComputationMethodFormat4Choice
    ISO20022.Semt002001.FinancialInstrumentAttributes111 *-- ISO20022.Semt002001.MarketIdentification3Choice
    class ISO20022.Semt002001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Semt002001.ForeignExchangeTerms34 {
        + QtgInstn  : ISO20022.Semt002001.PartyIdentification120Choice
        + QtnDt  : DateTime
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Semt002001.ForeignExchangeTerms34 *-- ISO20022.Semt002001.PartyIdentification120Choice
    class ISO20022.Semt002001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Semt002001.FormOfSecurity6Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.FormOfSecurity6Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.Frequency22Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.Frequency22Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.Frequency23Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.Frequency23Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Semt002001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt002001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt002001.GenericIdentification37 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt002001.GenericIdentification56 {
        + Bal  : Decimal
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt002001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Semt002001.GenericIdentification30
    }
    ISO20022.Semt002001.GenericIdentification78 *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.GenericIdentification80 {
        + Id  : String
        + Tp  : ISO20022.Semt002001.GenericIdentification30
    }
    ISO20022.Semt002001.GenericIdentification80 *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt002001.InterestComputationMethod2Code {
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
    class ISO20022.Semt002001.InterestComputationMethodFormat4Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.InterestComputationMethodFormat4Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.Intermediary44 {
        + Acct  : ISO20022.Semt002001.Account29
        + Role  : ISO20022.Semt002001.Role6Choice
        + Id  : ISO20022.Semt002001.PartyIdentification136
    }
    ISO20022.Semt002001.Intermediary44 *-- ISO20022.Semt002001.Account29
    ISO20022.Semt002001.Intermediary44 *-- ISO20022.Semt002001.Role6Choice
    ISO20022.Semt002001.Intermediary44 *-- ISO20022.Semt002001.PartyIdentification136
    class ISO20022.Semt002001.InvestmentFundRole2Code {
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
    class ISO20022.Semt002001.MarketIdentification3Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Semt002001.MarketIdentification5Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Semt002001.MarketIdentification98 {
        + Tp  : ISO20022.Semt002001.MarketType19Choice
        + Id  : ISO20022.Semt002001.MarketIdentification5Choice
    }
    ISO20022.Semt002001.MarketIdentification98 *-- ISO20022.Semt002001.MarketType19Choice
    ISO20022.Semt002001.MarketIdentification98 *-- ISO20022.Semt002001.MarketIdentification5Choice
    class ISO20022.Semt002001.MarketType19Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.MarketType19Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.MarketType9Code {
        SCAS = 1
        VEND = 2
        THEO = 3
        LMAR = 4
        FUND = 5
    }
    class ISO20022.Semt002001.NameAndAddress5 {
        + Adr  : ISO20022.Semt002001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Semt002001.NameAndAddress5 *-- ISO20022.Semt002001.PostalAddress1
    class ISO20022.Semt002001.Number22Choice {
        + Lng  : ISO20022.Semt002001.GenericIdentification1
        + Shrt  : String
    }
    ISO20022.Semt002001.Number22Choice *-- ISO20022.Semt002001.GenericIdentification1
    class ISO20022.Semt002001.Number3Choice {
        + Lng  : String
        + Shrt  : String
    }
    class ISO20022.Semt002001.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Semt002001.OptionStyle8Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.OptionStyle8Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Semt002001.OptionType6Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.OptionType6Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Semt002001.OtherIdentification1 {
        + Tp  : ISO20022.Semt002001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Semt002001.OtherIdentification1 *-- ISO20022.Semt002001.IdentificationSource3Choice
    class ISO20022.Semt002001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Semt002001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Semt002001.NameAndAddress5
        + PrtryId  : ISO20022.Semt002001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Semt002001.PartyIdentification120Choice *-- ISO20022.Semt002001.NameAndAddress5
    ISO20022.Semt002001.PartyIdentification120Choice *-- ISO20022.Semt002001.GenericIdentification36
    class ISO20022.Semt002001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Semt002001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Semt002001.PartyIdentification127Choice *-- ISO20022.Semt002001.GenericIdentification36
    class ISO20022.Semt002001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Semt002001.PartyIdentification120Choice
    }
    ISO20022.Semt002001.PartyIdentification136 *-- ISO20022.Semt002001.PartyIdentification120Choice
    class ISO20022.Semt002001.PartyIdentification144 {
        + LEI  : String
        + Id  : ISO20022.Semt002001.PartyIdentification127Choice
    }
    ISO20022.Semt002001.PartyIdentification144 *-- ISO20022.Semt002001.PartyIdentification127Choice
    class ISO20022.Semt002001.PartyIdentification15 {
        + Id  : String
        + Ctry  : String
    }
    class ISO20022.Semt002001.Pledgee3 {
        + LEI  : String
        + PldgeeTpAndId  : ISO20022.Semt002001.PledgeeFormat5Choice
    }
    ISO20022.Semt002001.Pledgee3 *-- ISO20022.Semt002001.PledgeeFormat5Choice
    class ISO20022.Semt002001.PledgeeFormat5Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification80
        + Id  : ISO20022.Semt002001.PledgeeTypeAndText1
        + TpAndId  : ISO20022.Semt002001.PledgeeTypeAndAnyBICIdentifier2
    }
    ISO20022.Semt002001.PledgeeFormat5Choice *-- ISO20022.Semt002001.GenericIdentification80
    ISO20022.Semt002001.PledgeeFormat5Choice *-- ISO20022.Semt002001.PledgeeTypeAndText1
    ISO20022.Semt002001.PledgeeFormat5Choice *-- ISO20022.Semt002001.PledgeeTypeAndAnyBICIdentifier2
    class ISO20022.Semt002001.PledgeeType1Code {
        REGB = 1
        CPTY = 2
    }
    class ISO20022.Semt002001.PledgeeTypeAndAnyBICIdentifier2 {
        + PldgeeTp  : String
        + Id  : String
    }
    class ISO20022.Semt002001.PledgeeTypeAndText1 {
        + PldgeeTp  : String
        + Id  : String
    }
    class ISO20022.Semt002001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Semt002001.Price7 {
        + Val  : ISO20022.Semt002001.PriceRateOrAmount3Choice
        + Tp  : ISO20022.Semt002001.YieldedOrValueType1Choice
    }
    ISO20022.Semt002001.Price7 *-- ISO20022.Semt002001.PriceRateOrAmount3Choice
    ISO20022.Semt002001.Price7 *-- ISO20022.Semt002001.YieldedOrValueType1Choice
    class ISO20022.Semt002001.PriceInformation29 {
        + QtnDt  : ISO20022.Semt002001.DateAndDateTime2Choice
        + SrcOfPric  : ISO20022.Semt002001.MarketIdentification98
        + ValTp  : ISO20022.Semt002001.YieldedOrValueType1Choice
        + Val  : ISO20022.Semt002001.PriceRateOrAmountOrUnknown2Choice
        + Tp  : ISO20022.Semt002001.TypeOfPrice28Choice
    }
    ISO20022.Semt002001.PriceInformation29 *-- ISO20022.Semt002001.DateAndDateTime2Choice
    ISO20022.Semt002001.PriceInformation29 *-- ISO20022.Semt002001.MarketIdentification98
    ISO20022.Semt002001.PriceInformation29 *-- ISO20022.Semt002001.YieldedOrValueType1Choice
    ISO20022.Semt002001.PriceInformation29 *-- ISO20022.Semt002001.PriceRateOrAmountOrUnknown2Choice
    ISO20022.Semt002001.PriceInformation29 *-- ISO20022.Semt002001.TypeOfPrice28Choice
    class ISO20022.Semt002001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Semt002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Semt002001.PriceRateOrAmount3Choice *-- ISO20022.Semt002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Semt002001.PriceRateOrAmountOrUnknown2Choice {
        + UknwnInd  : String
        + Amt  : ISO20022.Semt002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Semt002001.PriceRateOrAmountOrUnknown2Choice *-- ISO20022.Semt002001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Semt002001.PriceType4Choice {
        + Indctv  : ISO20022.Semt002001.Price7
        + Mkt  : ISO20022.Semt002001.Price7
    }
    ISO20022.Semt002001.PriceType4Choice *-- ISO20022.Semt002001.Price7
    ISO20022.Semt002001.PriceType4Choice *-- ISO20022.Semt002001.Price7
    class ISO20022.Semt002001.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Semt002001.PurposeCode7Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.PurposeCode7Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.Quantity51Choice {
        + OrgnlAndCurFace  : ISO20022.Semt002001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Semt002001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Semt002001.Quantity51Choice *-- ISO20022.Semt002001.OriginalAndCurrentQuantities1
    ISO20022.Semt002001.Quantity51Choice *-- ISO20022.Semt002001.FinancialInstrumentQuantity33Choice
    class ISO20022.Semt002001.QuantityAndAvailability3 {
        + AvlbtyInd  : String
        + Qty  : ISO20022.Semt002001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Semt002001.QuantityAndAvailability3 *-- ISO20022.Semt002001.FinancialInstrumentQuantity33Choice
    class ISO20022.Semt002001.QuantityBreakdown57 {
        + TpOfPric  : ISO20022.Semt002001.TypeOfPrice29Choice
        + LotPric  : ISO20022.Semt002001.Price7
        + LotDtTm  : ISO20022.Semt002001.DateAndDateTime2Choice
        + LotQty  : ISO20022.Semt002001.Balance16
        + LotNb  : ISO20022.Semt002001.GenericIdentification37
    }
    ISO20022.Semt002001.QuantityBreakdown57 *-- ISO20022.Semt002001.TypeOfPrice29Choice
    ISO20022.Semt002001.QuantityBreakdown57 *-- ISO20022.Semt002001.Price7
    ISO20022.Semt002001.QuantityBreakdown57 *-- ISO20022.Semt002001.DateAndDateTime2Choice
    ISO20022.Semt002001.QuantityBreakdown57 *-- ISO20022.Semt002001.Balance16
    ISO20022.Semt002001.QuantityBreakdown57 *-- ISO20022.Semt002001.GenericIdentification37
    class ISO20022.Semt002001.Role6Choice {
        + Txt  : String
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.Role6Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.SafeKeepingPlace5 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Semt002001.SafekeepingPlaceFormat41Choice
    }
    ISO20022.Semt002001.SafeKeepingPlace5 *-- ISO20022.Semt002001.SafekeepingPlaceFormat41Choice
    class ISO20022.Semt002001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Semt002001.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Semt002001.SafekeepingPlaceFormat41Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification78
        + TpAndId  : ISO20022.Semt002001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Semt002001.SafekeepingPlaceTypeAndText8
    }
    ISO20022.Semt002001.SafekeepingPlaceFormat41Choice *-- ISO20022.Semt002001.GenericIdentification78
    ISO20022.Semt002001.SafekeepingPlaceFormat41Choice *-- ISO20022.Semt002001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Semt002001.SafekeepingPlaceFormat41Choice *-- ISO20022.Semt002001.SafekeepingPlaceTypeAndText8
    class ISO20022.Semt002001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt002001.SafekeepingPlaceTypeAndText8 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt002001.SecuritiesAccount25 {
        + Nm  : String
        + Tp  : ISO20022.Semt002001.PurposeCode7Choice
        + Id  : String
    }
    ISO20022.Semt002001.SecuritiesAccount25 *-- ISO20022.Semt002001.PurposeCode7Choice
    class ISO20022.Semt002001.SecuritiesAccount26 {
        + Dsgnt  : String
        + Nm  : String
        + Tp  : ISO20022.Semt002001.PurposeCode7Choice
        + Id  : String
    }
    ISO20022.Semt002001.SecuritiesAccount26 *-- ISO20022.Semt002001.PurposeCode7Choice
    class ISO20022.Semt002001.SecuritiesAccountPurposeType1Code {
        PHYS = 1
        DVPA = 2
        CEND = 3
        ABRD = 4
        SHOR = 5
        MARG = 6
    }
    class ISO20022.Semt002001.SecuritiesBalanceCustodyReportV12 {
        + AcctBaseCcyTtlAmts  : ISO20022.Semt002001.TotalValueInPageAndStatement1
        + SubAcctDtls  : global::System.Collections.Generic.List~ISO20022.Semt002001.SubAccountIdentification71~
        + BalForAcct  : global::System.Collections.Generic.List~ISO20022.Semt002001.AggregateBalanceInformation46~
        + IntrmyInf  : global::System.Collections.Generic.List~ISO20022.Semt002001.Intermediary44~
        + BlckChainAdrOrWllt  : ISO20022.Semt002001.BlockChainAddressWallet1
        + SfkpgAcct  : ISO20022.Semt002001.SecuritiesAccount26
        + AcctSvcr  : ISO20022.Semt002001.PartyIdentification136
        + AcctOwnr  : ISO20022.Semt002001.PartyIdentification144
        + StmtGnlDtls  : ISO20022.Semt002001.Statement73
        + Pgntn  : ISO20022.Semt002001.Pagination1
    }
    ISO20022.Semt002001.SecuritiesBalanceCustodyReportV12 *-- ISO20022.Semt002001.TotalValueInPageAndStatement1
    ISO20022.Semt002001.SecuritiesBalanceCustodyReportV12 *-- ISO20022.Semt002001.SubAccountIdentification71
    ISO20022.Semt002001.SecuritiesBalanceCustodyReportV12 *-- ISO20022.Semt002001.AggregateBalanceInformation46
    ISO20022.Semt002001.SecuritiesBalanceCustodyReportV12 *-- ISO20022.Semt002001.Intermediary44
    ISO20022.Semt002001.SecuritiesBalanceCustodyReportV12 *-- ISO20022.Semt002001.BlockChainAddressWallet1
    ISO20022.Semt002001.SecuritiesBalanceCustodyReportV12 *-- ISO20022.Semt002001.SecuritiesAccount26
    ISO20022.Semt002001.SecuritiesBalanceCustodyReportV12 *-- ISO20022.Semt002001.PartyIdentification136
    ISO20022.Semt002001.SecuritiesBalanceCustodyReportV12 *-- ISO20022.Semt002001.PartyIdentification144
    ISO20022.Semt002001.SecuritiesBalanceCustodyReportV12 *-- ISO20022.Semt002001.Statement73
    ISO20022.Semt002001.SecuritiesBalanceCustodyReportV12 *-- ISO20022.Semt002001.Pagination1
    class ISO20022.Semt002001.SecuritiesBalanceType12Code {
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
    class ISO20022.Semt002001.SecuritiesBalanceType7Code {
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
    class ISO20022.Semt002001.SecuritiesPaymentStatus1Code {
        PART = 1
        NILL = 2
        FULL = 3
    }
    class ISO20022.Semt002001.SecuritiesPaymentStatus5Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.SecuritiesPaymentStatus5Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Semt002001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Semt002001.SecurityIdentification19 *-- ISO20022.Semt002001.OtherIdentification1
    class ISO20022.Semt002001.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Semt002001.SimpleIdentificationInformation4 {
        + Id  : String
    }
    class ISO20022.Semt002001.Statement73 {
        + SctyIntrstOrSetOff  : String
        + SubAcctInd  : String
        + ActvtyInd  : String
        + StmtBsis  : ISO20022.Semt002001.StatementBasis7Choice
        + UpdTp  : ISO20022.Semt002001.UpdateType15Choice
        + Frqcy  : ISO20022.Semt002001.Frequency22Choice
        + StmtDtTm  : ISO20022.Semt002001.DateAndDateTime2Choice
        + StmtId  : String
        + QryRef  : String
        + RptNb  : ISO20022.Semt002001.Number3Choice
    }
    ISO20022.Semt002001.Statement73 *-- ISO20022.Semt002001.StatementBasis7Choice
    ISO20022.Semt002001.Statement73 *-- ISO20022.Semt002001.UpdateType15Choice
    ISO20022.Semt002001.Statement73 *-- ISO20022.Semt002001.Frequency22Choice
    ISO20022.Semt002001.Statement73 *-- ISO20022.Semt002001.DateAndDateTime2Choice
    ISO20022.Semt002001.Statement73 *-- ISO20022.Semt002001.Number3Choice
    class ISO20022.Semt002001.StatementBasis1Code {
        TRAD = 1
        SETT = 2
        CONT = 3
    }
    class ISO20022.Semt002001.StatementBasis7Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.StatementBasis7Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.StatementUpdateType1Code {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Semt002001.SubAccountIdentification71 {
        + BalForSubAcct  : global::System.Collections.Generic.List~ISO20022.Semt002001.AggregateBalanceInformation46~
        + ActvtyInd  : String
        + BlckChainAdrOrWllt  : ISO20022.Semt002001.BlockChainAddressWallet2
        + SfkpgAcct  : ISO20022.Semt002001.SecuritiesAccount25
        + AcctOwnr  : ISO20022.Semt002001.PartyIdentification144
    }
    ISO20022.Semt002001.SubAccountIdentification71 *-- ISO20022.Semt002001.AggregateBalanceInformation46
    ISO20022.Semt002001.SubAccountIdentification71 *-- ISO20022.Semt002001.BlockChainAddressWallet2
    ISO20022.Semt002001.SubAccountIdentification71 *-- ISO20022.Semt002001.SecuritiesAccount25
    ISO20022.Semt002001.SubAccountIdentification71 *-- ISO20022.Semt002001.PartyIdentification144
    class ISO20022.Semt002001.SubBalanceInformation20 {
        + AddtlBalBrkdwnDtls  : global::System.Collections.Generic.List~ISO20022.Semt002001.AdditionalBalanceInformation20~
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt002001.QuantityBreakdown57~
        + SubBalAddtlDtls  : String
        + Qty  : ISO20022.Semt002001.Balance21
        + SubBalTp  : ISO20022.Semt002001.SubBalanceType11Choice
    }
    ISO20022.Semt002001.SubBalanceInformation20 *-- ISO20022.Semt002001.AdditionalBalanceInformation20
    ISO20022.Semt002001.SubBalanceInformation20 *-- ISO20022.Semt002001.QuantityBreakdown57
    ISO20022.Semt002001.SubBalanceInformation20 *-- ISO20022.Semt002001.Balance21
    ISO20022.Semt002001.SubBalanceInformation20 *-- ISO20022.Semt002001.SubBalanceType11Choice
    class ISO20022.Semt002001.SubBalanceQuantity8Choice {
        + QtyAndAvlbty  : ISO20022.Semt002001.QuantityAndAvailability3
        + Prtry  : ISO20022.Semt002001.GenericIdentification56
        + Qty  : ISO20022.Semt002001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Semt002001.SubBalanceQuantity8Choice *-- ISO20022.Semt002001.QuantityAndAvailability3
    ISO20022.Semt002001.SubBalanceQuantity8Choice *-- ISO20022.Semt002001.GenericIdentification56
    ISO20022.Semt002001.SubBalanceQuantity8Choice *-- ISO20022.Semt002001.FinancialInstrumentQuantity33Choice
    class ISO20022.Semt002001.SubBalanceType11Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.SubBalanceType11Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.SubBalanceType12Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.SubBalanceType12Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.SupplementaryData1 {
        + Envlp  : ISO20022.Semt002001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Semt002001.SupplementaryData1 *-- ISO20022.Semt002001.SupplementaryDataEnvelope1
    class ISO20022.Semt002001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Semt002001.TotalValueInPageAndStatement1 {
        + TtlElgblCollVal  : ISO20022.Semt002001.AmountAndDirection6
        + TtlBookValOfStmt  : ISO20022.Semt002001.AmountAndDirection6
        + TtlHldgsValOfStmt  : ISO20022.Semt002001.AmountAndDirection6
        + TtlHldgsValOfPg  : ISO20022.Semt002001.AmountAndDirection6
    }
    ISO20022.Semt002001.TotalValueInPageAndStatement1 *-- ISO20022.Semt002001.AmountAndDirection6
    ISO20022.Semt002001.TotalValueInPageAndStatement1 *-- ISO20022.Semt002001.AmountAndDirection6
    ISO20022.Semt002001.TotalValueInPageAndStatement1 *-- ISO20022.Semt002001.AmountAndDirection6
    ISO20022.Semt002001.TotalValueInPageAndStatement1 *-- ISO20022.Semt002001.AmountAndDirection6
    class ISO20022.Semt002001.TypeOfPrice11Code {
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
    class ISO20022.Semt002001.TypeOfPrice14Code {
        AVER = 1
    }
    class ISO20022.Semt002001.TypeOfPrice28Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.TypeOfPrice28Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.TypeOfPrice29Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.TypeOfPrice29Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.UpdateType15Choice {
        + Prtry  : ISO20022.Semt002001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt002001.UpdateType15Choice *-- ISO20022.Semt002001.GenericIdentification30
    class ISO20022.Semt002001.YieldedOrValueType1Choice {
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

## Value ISO20022.Semt002001.Account29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|ISO20022.Semt002001.PartyIdentification120Choice||XmlElement()||
|+|Id|ISO20022.Semt002001.AccountIdentification26||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcr),validElement(Id))|

---

## Value ISO20022.Semt002001.AccountIdentification26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.SimpleIdentificationInformation4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry))|

---

## Value ISO20022.Semt002001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt002001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt002001.AdditionalBalanceInformation20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002001.QuantityBreakdown57>||XmlElement()||
|+|SubBalAddtlDtls|String||XmlElement()||
|+|Qty|ISO20022.Semt002001.Balance21||XmlElement()||
|+|SubBalTp|ISO20022.Semt002001.SubBalanceType12Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(Qty),validElement(SubBalTp))|

---

## Enum ISO20022.Semt002001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Semt002001.AggregateBalanceInformation46


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt002001.SupplementaryData1>||XmlElement()||
|+|HldgAddtlDtls|String||XmlElement()||
|+|BalAtSfkpgPlc|global::System.Collections.Generic.List<ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43>||XmlElement()||
|+|AddtlBalBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002001.AdditionalBalanceInformation20>||XmlElement()||
|+|BalBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002001.SubBalanceInformation20>||XmlElement()||
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002001.QuantityBreakdown57>||XmlElement()||
|+|InstrmCcyAmts|ISO20022.Semt002001.BalanceAmounts3||XmlElement()||
|+|AcctBaseCcyAmts|ISO20022.Semt002001.BalanceAmounts3||XmlElement()||
|+|DaysAcrd|Decimal||XmlElement()||
|+|FXDtls|global::System.Collections.Generic.List<ISO20022.Semt002001.ForeignExchangeTerms34>||XmlElement()||
|+|PricDtls|global::System.Collections.Generic.List<ISO20022.Semt002001.PriceInformation29>||XmlElement()||
|+|CorpActnOptnTp|String||XmlElement()||
|+|SfkpgPlc|ISO20022.Semt002001.SafeKeepingPlace5||XmlElement()||
|+|NotAvlblBal|ISO20022.Semt002001.BalanceQuantity14Choice||XmlElement()||
|+|AvlblBal|ISO20022.Semt002001.Balance18||XmlElement()||
|+|AggtBal|ISO20022.Semt002001.Balance17||XmlElement()||
|+|ValtnHrcutDtls|ISO20022.Semt002001.BasicCollateralValuation1Details||XmlElement()||
|+|InvstmtFndsFinInstrmAttrbts|ISO20022.Semt002001.FinancialInstrument21||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Semt002001.FinancialInstrumentAttributes111||XmlElement()||
|+|FinInstrmId|ISO20022.Semt002001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""BalAtSfkpgPlc""",BalAtSfkpgPlc),validElement(BalAtSfkpgPlc),validList("""AddtlBalBrkdwn""",AddtlBalBrkdwn),validElement(AddtlBalBrkdwn),validList("""BalBrkdwn""",BalBrkdwn),validElement(BalBrkdwn),validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(InstrmCcyAmts),validElement(AcctBaseCcyAmts),validList("""FXDtls""",FXDtls),validElement(FXDtls),validList("""PricDtls""",PricDtls),validElement(PricDtls),validElement(SfkpgPlc),validElement(NotAvlblBal),validElement(AvlblBal),validElement(AggtBal),validElement(ValtnHrcutDtls),validElement(InvstmtFndsFinInstrmAttrbts),validElement(FinInstrmAttrbts),validElement(FinInstrmId))|

---

## Value ISO20022.Semt002001.AggregateBalancePerSafekeepingPlace43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HldgAddtlDtls|String||XmlElement()||
|+|AddtlBalBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002001.AdditionalBalanceInformation20>||XmlElement()||
|+|BalBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002001.SubBalanceInformation20>||XmlElement()||
|+|XpsrTp|ISO20022.Semt002001.ExposureType25Choice||XmlElement()||
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002001.QuantityBreakdown57>||XmlElement()||
|+|InstrmCcyAmts|ISO20022.Semt002001.BalanceAmounts3||XmlElement()||
|+|AcctBaseCcyAmts|ISO20022.Semt002001.BalanceAmounts3||XmlElement()||
|+|DaysAcrd|Decimal||XmlElement()||
|+|FXDtls|global::System.Collections.Generic.List<ISO20022.Semt002001.ForeignExchangeTerms34>||XmlElement()||
|+|PricDtls|global::System.Collections.Generic.List<ISO20022.Semt002001.PriceInformation29>||XmlElement()||
|+|NotAvlblBal|ISO20022.Semt002001.BalanceQuantity14Choice||XmlElement()||
|+|AvlblBal|ISO20022.Semt002001.Balance18||XmlElement()||
|+|AggtBal|ISO20022.Semt002001.Balance17||XmlElement()||
|+|Pldgee|ISO20022.Semt002001.Pledgee3||XmlElement()||
|+|PlcOfListg|ISO20022.Semt002001.MarketIdentification3Choice||XmlElement()||
|+|SfkpgPlc|ISO20022.Semt002001.SafeKeepingPlace5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlBalBrkdwn""",AddtlBalBrkdwn),validElement(AddtlBalBrkdwn),validList("""BalBrkdwn""",BalBrkdwn),validElement(BalBrkdwn),validElement(XpsrTp),validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(InstrmCcyAmts),validElement(AcctBaseCcyAmts),validList("""FXDtls""",FXDtls),validElement(FXDtls),validList("""PricDtls""",PricDtls),validElement(PricDtls),validElement(NotAvlblBal),validElement(AvlblBal),validElement(AggtBal),validElement(Pldgee),validElement(PlcOfListg),validElement(SfkpgPlc))|

---

## Value ISO20022.Semt002001.AmountAndDirection6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Semt002001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Semt002001.Balance16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Semt002001.BalanceQuantity13Choice||XmlElement()||
|+|ShrtLngInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Semt002001.Balance17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Semt002001.BalanceQuantity13Choice||XmlElement()||
|+|ShrtLngInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Semt002001.Balance18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Semt002001.BalanceQuantity14Choice||XmlElement()||
|+|ShrtLngInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Semt002001.Balance21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Semt002001.SubBalanceQuantity8Choice||XmlElement()||
|+|ShrtLngInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Semt002001.BalanceAmounts3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcrdIntrstAmt|ISO20022.Semt002001.AmountAndDirection6||XmlElement()||
|+|ElgblCollVal|ISO20022.Semt002001.AmountAndDirection6||XmlElement()||
|+|BookVal|ISO20022.Semt002001.AmountAndDirection6||XmlElement()||
|+|PrvsHldgVal|ISO20022.Semt002001.AmountAndDirection6||XmlElement()||
|+|HldgVal|ISO20022.Semt002001.AmountAndDirection6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcrdIntrstAmt),validElement(ElgblCollVal),validElement(BookVal),validElement(PrvsHldgVal),validElement(HldgVal))|

---

## Value ISO20022.Semt002001.BalanceQuantity13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification56||XmlElement()||
|+|Qty|ISO20022.Semt002001.Quantity51Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Qty),validChoice(Prtry,Qty))|

---

## Value ISO20022.Semt002001.BalanceQuantity14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification56||XmlElement()||
|+|Qty|ISO20022.Semt002001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Qty),validChoice(Prtry,Qty))|

---

## Value ISO20022.Semt002001.BasicCollateralValuation1Details


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HrcutSrc|ISO20022.Semt002001.PartyIdentification15||XmlElement()||
|+|ValtnHrcut|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(HrcutSrc))|

---

## Value ISO20022.Semt002001.BlockChainAddressWallet1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dsgnt|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt002001.PurposeCode7Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt002001.BlockChainAddressWallet2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt002001.PurposeCode7Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt002001.ClassificationType32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Semt002001.GenericIdentification36||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Enum ISO20022.Semt002001.CorporateActionOption5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SECU|Int32||XmlEnum("""SECU""")|1|
||CASH|Int32||XmlEnum("""CASH""")|2|

---

## Value ISO20022.Semt002001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Semt002001.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||DIST|Int32||XmlEnum("""DIST""")|2|

---

## Type ISO20022.Semt002001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesBalCtdyRpt|ISO20022.Semt002001.SecuritiesBalanceCustodyReportV12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesBalCtdyRpt))|

---

## Enum ISO20022.Semt002001.EventFrequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||SEMI|Int32||XmlEnum("""SEMI""")|2|
||QUTR|Int32||XmlEnum("""QUTR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|

---

## Enum ISO20022.Semt002001.EventFrequency7Code


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

## Enum ISO20022.Semt002001.ExposureType15Code


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

## Value ISO20022.Semt002001.ExposureType25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002001.FinancialInstrument21


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
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RegdDstrbtnCtry""",RegdDstrbtnCtry,"""[A-Z]{2,2}"""),validPattern("""CtryOfDmcl""",CtryOfDmcl,"""[A-Z]{2,2}"""),validPattern("""ReqdNAVCcy""",ReqdNAVCcy,"""[A-Z]{3,3}"""),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validPattern("""BaseCcy""",BaseCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt002001.FinancialInstrumentAttributes111


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmAttrAddtlDtls|String||XmlElement()||
|+|UndrlygFinInstrmId|global::System.Collections.Generic.List<ISO20022.Semt002001.SecurityIdentification19>||XmlElement()||
|+|CtrctSz|ISO20022.Semt002001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Semt002001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|StrkPric|ISO20022.Semt002001.Price7||XmlElement()||
|+|ConvsPric|ISO20022.Semt002001.Price7||XmlElement()||
|+|SbcptPric|ISO20022.Semt002001.Price7||XmlElement()||
|+|ExrcPric|ISO20022.Semt002001.Price7||XmlElement()||
|+|MktOrIndctvPric|ISO20022.Semt002001.PriceType4Choice||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|PoolNb|ISO20022.Semt002001.GenericIdentification37||XmlElement()||
|+|CpnAttchdNb|ISO20022.Semt002001.Number22Choice||XmlElement()||
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
|+|OptnTp|ISO20022.Semt002001.OptionType6Choice||XmlElement()||
|+|OptnStyle|ISO20022.Semt002001.OptionStyle8Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Semt002001.ClassificationType32Choice||XmlElement()||
|+|VarblRateChngFrqcy|ISO20022.Semt002001.Frequency23Choice||XmlElement()||
|+|PmtSts|ISO20022.Semt002001.SecuritiesPaymentStatus5Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Semt002001.Frequency23Choice||XmlElement()||
|+|RegnForm|ISO20022.Semt002001.FormOfSecurity6Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Semt002001.InterestComputationMethodFormat4Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Semt002001.MarketIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""UndrlygFinInstrmId""",UndrlygFinInstrmId),validElement(UndrlygFinInstrmId),validElement(CtrctSz),validElement(MinNmnlQty),validElement(StrkPric),validElement(ConvsPric),validElement(SbcptPric),validElement(ExrcPric),validElement(MktOrIndctvPric),validElement(PoolNb),validElement(CpnAttchdNb),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnTp),validElement(OptnStyle),validElement(ClssfctnTp),validElement(VarblRateChngFrqcy),validElement(PmtSts),validElement(PmtFrqcy),validElement(RegnForm),validElement(DayCntBsis),validElement(PlcOfListg))|

---

## Value ISO20022.Semt002001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Semt002001.ForeignExchangeTerms34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtgInstn|ISO20022.Semt002001.PartyIdentification120Choice||XmlElement()||
|+|QtnDt|DateTime||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtgInstn),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Semt002001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Semt002001.FormOfSecurity6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002001.Frequency22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002001.Frequency23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt002001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt002001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt002001.GenericIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt002001.GenericIdentification56


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|Decimal||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt002001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt002001.GenericIdentification80


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt002001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt002001.InterestComputationMethod2Code


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

## Value ISO20022.Semt002001.InterestComputationMethodFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002001.Intermediary44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Acct|ISO20022.Semt002001.Account29||XmlElement()||
|+|Role|ISO20022.Semt002001.Role6Choice||XmlElement()||
|+|Id|ISO20022.Semt002001.PartyIdentification136||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Acct),validElement(Role),validElement(Id))|

---

## Enum ISO20022.Semt002001.InvestmentFundRole2Code


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

## Value ISO20022.Semt002001.MarketIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Semt002001.MarketIdentification5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Semt002001.MarketIdentification98


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt002001.MarketType19Choice||XmlElement()||
|+|Id|ISO20022.Semt002001.MarketIdentification5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Semt002001.MarketType19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt002001.MarketType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SCAS|Int32||XmlEnum("""SCAS""")|1|
||VEND|Int32||XmlEnum("""VEND""")|2|
||THEO|Int32||XmlEnum("""THEO""")|3|
||LMAR|Int32||XmlEnum("""LMAR""")|4|
||FUND|Int32||XmlEnum("""FUND""")|5|

---

## Value ISO20022.Semt002001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Semt002001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Semt002001.Number22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|ISO20022.Semt002001.GenericIdentification1||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lng),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Value ISO20022.Semt002001.Number3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|String||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lng""",Lng,"""[0-9]{5}"""),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Enum ISO20022.Semt002001.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Semt002001.OptionStyle8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt002001.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Semt002001.OptionType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt002001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt002001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt002001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Semt002001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Semt002001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Semt002001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Semt002001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Semt002001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Semt002001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt002001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt002001.PartyIdentification144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt002001.PartyIdentification127Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt002001.PartyIdentification15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Semt002001.Pledgee3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|PldgeeTpAndId|ISO20022.Semt002001.PledgeeFormat5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(PldgeeTpAndId))|

---

## Value ISO20022.Semt002001.PledgeeFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification80||XmlElement()||
|+|Id|ISO20022.Semt002001.PledgeeTypeAndText1||XmlElement()||
|+|TpAndId|ISO20022.Semt002001.PledgeeTypeAndAnyBICIdentifier2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Id),validElement(TpAndId),validChoice(Prtry,Id,TpAndId))|

---

## Enum ISO20022.Semt002001.PledgeeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGB|Int32||XmlEnum("""REGB""")|1|
||CPTY|Int32||XmlEnum("""CPTY""")|2|

---

## Value ISO20022.Semt002001.PledgeeTypeAndAnyBICIdentifier2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PldgeeTp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt002001.PledgeeTypeAndText1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PldgeeTp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt002001.PostalAddress1


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

## Value ISO20022.Semt002001.Price7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Semt002001.PriceRateOrAmount3Choice||XmlElement()||
|+|Tp|ISO20022.Semt002001.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Semt002001.PriceInformation29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtnDt|ISO20022.Semt002001.DateAndDateTime2Choice||XmlElement()||
|+|SrcOfPric|ISO20022.Semt002001.MarketIdentification98||XmlElement()||
|+|ValTp|ISO20022.Semt002001.YieldedOrValueType1Choice||XmlElement()||
|+|Val|ISO20022.Semt002001.PriceRateOrAmountOrUnknown2Choice||XmlElement()||
|+|Tp|ISO20022.Semt002001.TypeOfPrice28Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtnDt),validElement(SrcOfPric),validElement(ValTp),validElement(Val),validElement(Tp))|

---

## Value ISO20022.Semt002001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Semt002001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Semt002001.PriceRateOrAmountOrUnknown2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UknwnInd|String||XmlElement()||
|+|Amt|ISO20022.Semt002001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(UknwnInd,Amt,Rate))|

---

## Value ISO20022.Semt002001.PriceType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indctv|ISO20022.Semt002001.Price7||XmlElement()||
|+|Mkt|ISO20022.Semt002001.Price7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indctv),validElement(Mkt),validChoice(Indctv,Mkt))|

---

## Enum ISO20022.Semt002001.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Semt002001.PurposeCode7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002001.Quantity51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Semt002001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Semt002001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Semt002001.QuantityAndAvailability3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AvlbtyInd|String||XmlElement()||
|+|Qty|ISO20022.Semt002001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Semt002001.QuantityBreakdown57


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TpOfPric|ISO20022.Semt002001.TypeOfPrice29Choice||XmlElement()||
|+|LotPric|ISO20022.Semt002001.Price7||XmlElement()||
|+|LotDtTm|ISO20022.Semt002001.DateAndDateTime2Choice||XmlElement()||
|+|LotQty|ISO20022.Semt002001.Balance16||XmlElement()||
|+|LotNb|ISO20022.Semt002001.GenericIdentification37||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TpOfPric),validElement(LotPric),validElement(LotDtTm),validElement(LotQty),validElement(LotNb))|

---

## Value ISO20022.Semt002001.Role6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Txt,Prtry,Cd))|

---

## Value ISO20022.Semt002001.SafeKeepingPlace5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Semt002001.SafekeepingPlaceFormat41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Semt002001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Semt002001.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Semt002001.SafekeepingPlaceFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Semt002001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Semt002001.SafekeepingPlaceTypeAndText8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Semt002001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt002001.SafekeepingPlaceTypeAndText8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt002001.SecuritiesAccount25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt002001.PurposeCode7Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt002001.SecuritiesAccount26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dsgnt|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt002001.PurposeCode7Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Semt002001.SecuritiesAccountPurposeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHYS|Int32||XmlEnum("""PHYS""")|1|
||DVPA|Int32||XmlEnum("""DVPA""")|2|
||CEND|Int32||XmlEnum("""CEND""")|3|
||ABRD|Int32||XmlEnum("""ABRD""")|4|
||SHOR|Int32||XmlEnum("""SHOR""")|5|
||MARG|Int32||XmlEnum("""MARG""")|6|

---

## Aspect ISO20022.Semt002001.SecuritiesBalanceCustodyReportV12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctBaseCcyTtlAmts|ISO20022.Semt002001.TotalValueInPageAndStatement1||XmlElement()||
|+|SubAcctDtls|global::System.Collections.Generic.List<ISO20022.Semt002001.SubAccountIdentification71>||XmlElement()||
|+|BalForAcct|global::System.Collections.Generic.List<ISO20022.Semt002001.AggregateBalanceInformation46>||XmlElement()||
|+|IntrmyInf|global::System.Collections.Generic.List<ISO20022.Semt002001.Intermediary44>||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt002001.BlockChainAddressWallet1||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt002001.SecuritiesAccount26||XmlElement()||
|+|AcctSvcr|ISO20022.Semt002001.PartyIdentification136||XmlElement()||
|+|AcctOwnr|ISO20022.Semt002001.PartyIdentification144||XmlElement()||
|+|StmtGnlDtls|ISO20022.Semt002001.Statement73||XmlElement()||
|+|Pgntn|ISO20022.Semt002001.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctBaseCcyTtlAmts),validList("""SubAcctDtls""",SubAcctDtls),validElement(SubAcctDtls),validList("""BalForAcct""",BalForAcct),validElement(BalForAcct),validList("""IntrmyInf""",IntrmyInf),validListMax("""IntrmyInf""",IntrmyInf,10),validElement(IntrmyInf),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctSvcr),validElement(AcctOwnr),validElement(StmtGnlDtls),validElement(Pgntn))|

---

## Enum ISO20022.Semt002001.SecuritiesBalanceType12Code


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

## Enum ISO20022.Semt002001.SecuritiesBalanceType7Code


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

## Enum ISO20022.Semt002001.SecuritiesPaymentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NILL|Int32||XmlEnum("""NILL""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Semt002001.SecuritiesPaymentStatus5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Semt002001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Semt002001.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Semt002001.SimpleIdentificationInformation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt002001.Statement73


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyIntrstOrSetOff|String||XmlElement()||
|+|SubAcctInd|String||XmlElement()||
|+|ActvtyInd|String||XmlElement()||
|+|StmtBsis|ISO20022.Semt002001.StatementBasis7Choice||XmlElement()||
|+|UpdTp|ISO20022.Semt002001.UpdateType15Choice||XmlElement()||
|+|Frqcy|ISO20022.Semt002001.Frequency22Choice||XmlElement()||
|+|StmtDtTm|ISO20022.Semt002001.DateAndDateTime2Choice||XmlElement()||
|+|StmtId|String||XmlElement()||
|+|QryRef|String||XmlElement()||
|+|RptNb|ISO20022.Semt002001.Number3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmtBsis),validElement(UpdTp),validElement(Frqcy),validElement(StmtDtTm),validElement(RptNb))|

---

## Enum ISO20022.Semt002001.StatementBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAD|Int32||XmlEnum("""TRAD""")|1|
||SETT|Int32||XmlEnum("""SETT""")|2|
||CONT|Int32||XmlEnum("""CONT""")|3|

---

## Value ISO20022.Semt002001.StatementBasis7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt002001.StatementUpdateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Semt002001.SubAccountIdentification71


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BalForSubAcct|global::System.Collections.Generic.List<ISO20022.Semt002001.AggregateBalanceInformation46>||XmlElement()||
|+|ActvtyInd|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt002001.BlockChainAddressWallet2||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt002001.SecuritiesAccount25||XmlElement()||
|+|AcctOwnr|ISO20022.Semt002001.PartyIdentification144||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""BalForSubAcct""",BalForSubAcct),validElement(BalForSubAcct),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr))|

---

## Value ISO20022.Semt002001.SubBalanceInformation20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlBalBrkdwnDtls|global::System.Collections.Generic.List<ISO20022.Semt002001.AdditionalBalanceInformation20>||XmlElement()||
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt002001.QuantityBreakdown57>||XmlElement()||
|+|SubBalAddtlDtls|String||XmlElement()||
|+|Qty|ISO20022.Semt002001.Balance21||XmlElement()||
|+|SubBalTp|ISO20022.Semt002001.SubBalanceType11Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlBalBrkdwnDtls""",AddtlBalBrkdwnDtls),validElement(AddtlBalBrkdwnDtls),validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(Qty),validElement(SubBalTp))|

---

## Value ISO20022.Semt002001.SubBalanceQuantity8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyAndAvlbty|ISO20022.Semt002001.QuantityAndAvailability3||XmlElement()||
|+|Prtry|ISO20022.Semt002001.GenericIdentification56||XmlElement()||
|+|Qty|ISO20022.Semt002001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyAndAvlbty),validElement(Prtry),validElement(Qty),validChoice(QtyAndAvlbty,Prtry,Qty))|

---

## Value ISO20022.Semt002001.SubBalanceType11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002001.SubBalanceType12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Semt002001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Semt002001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt002001.TotalValueInPageAndStatement1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlElgblCollVal|ISO20022.Semt002001.AmountAndDirection6||XmlElement()||
|+|TtlBookValOfStmt|ISO20022.Semt002001.AmountAndDirection6||XmlElement()||
|+|TtlHldgsValOfStmt|ISO20022.Semt002001.AmountAndDirection6||XmlElement()||
|+|TtlHldgsValOfPg|ISO20022.Semt002001.AmountAndDirection6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlElgblCollVal),validElement(TtlBookValOfStmt),validElement(TtlHldgsValOfStmt),validElement(TtlHldgsValOfPg))|

---

## Enum ISO20022.Semt002001.TypeOfPrice11Code


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

## Enum ISO20022.Semt002001.TypeOfPrice14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AVER|Int32||XmlEnum("""AVER""")|1|

---

## Value ISO20022.Semt002001.TypeOfPrice28Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002001.TypeOfPrice29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002001.UpdateType15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt002001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt002001.YieldedOrValueType1Choice


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

