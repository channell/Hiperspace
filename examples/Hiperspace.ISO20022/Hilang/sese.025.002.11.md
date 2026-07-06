# sese.025.002.11
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese025002.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese025002.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese025002.AdditionalParameters31 {
        + TrptyAgtSvcPrvdrCollInstrId  : String
        + ClntCollInstrId  : String
        + ClntTrptyCollTxId  : String
        + TrptyAgtSvcPrvdrCollTxId  : String
        + PrvsPrtlConfId  : String
        + PrtlSttlm  : String
        + PreConf  : String
    }
    class ISO20022.Sese025002.AlternatePartyIdentification9 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Sese025002.IdentificationType44Choice
    }
    ISO20022.Sese025002.AlternatePartyIdentification9 *-- ISO20022.Sese025002.IdentificationType44Choice
    class ISO20022.Sese025002.AmountAndDirection44 {
        + FXDtls  : ISO20022.Sese025002.ForeignExchangeTerms23
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese025002.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese025002.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Sese025002.AmountAndDirection44 *-- ISO20022.Sese025002.ForeignExchangeTerms23
    ISO20022.Sese025002.AmountAndDirection44 *-- ISO20022.Sese025002.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese025002.AmountAndDirection44 *-- ISO20022.Sese025002.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese025002.AmountAndDirection57 {
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese025002.RestrictedFINActiveCurrencyAndAmount
    }
    ISO20022.Sese025002.AmountAndDirection57 *-- ISO20022.Sese025002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese025002.AmountAndDirection58 {
        + FXDtls  : ISO20022.Sese025002.ForeignExchangeTerms27
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Sese025002.AmountAndDirection58 *-- ISO20022.Sese025002.ForeignExchangeTerms27
    ISO20022.Sese025002.AmountAndDirection58 *-- ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese025002.AmountAndDirection58 *-- ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese025002.AmountAndDirection96 {
        + ValDt  : ISO20022.Sese025002.DateAndDateTime2Choice
        + FXDtls  : ISO20022.Sese025002.ForeignExchangeTerms27
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese025002.RestrictedFINActiveCurrencyAndAmount
        + RsrchFeeInd  : String
        + BrkrgAmtInd  : String
        + StmpDtyInd  : String
        + AcrdIntrstInd  : String
    }
    ISO20022.Sese025002.AmountAndDirection96 *-- ISO20022.Sese025002.DateAndDateTime2Choice
    ISO20022.Sese025002.AmountAndDirection96 *-- ISO20022.Sese025002.ForeignExchangeTerms27
    ISO20022.Sese025002.AmountAndDirection96 *-- ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese025002.AmountAndDirection96 *-- ISO20022.Sese025002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese025002.AutoBorrowing1Code {
        YBOR = 1
        NBOR = 2
        LAMI = 3
    }
    class ISO20022.Sese025002.AutomaticBorrowing8Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.AutomaticBorrowing8Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.BeneficialOwnership5Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese025002.BeneficialOwnership5Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Sese025002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese025002.BlockChainAddressWallet7 *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.BlockTrade1Code {
        BLCH = 1
        BLPA = 2
    }
    class ISO20022.Sese025002.BlockTrade5Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.BlockTrade5Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.CashAccountIdentification6Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Sese025002.CashParties38 {
        + Intrmy  : ISO20022.Sese025002.PartyIdentificationAndAccount178
        + CdtrAgt  : ISO20022.Sese025002.PartyIdentificationAndAccount178
        + Cdtr  : ISO20022.Sese025002.PartyIdentificationAndAccount177
        + DbtrAgt  : ISO20022.Sese025002.PartyIdentificationAndAccount178
        + Dbtr  : ISO20022.Sese025002.PartyIdentificationAndAccount177
    }
    ISO20022.Sese025002.CashParties38 *-- ISO20022.Sese025002.PartyIdentificationAndAccount178
    ISO20022.Sese025002.CashParties38 *-- ISO20022.Sese025002.PartyIdentificationAndAccount178
    ISO20022.Sese025002.CashParties38 *-- ISO20022.Sese025002.PartyIdentificationAndAccount177
    ISO20022.Sese025002.CashParties38 *-- ISO20022.Sese025002.PartyIdentificationAndAccount178
    ISO20022.Sese025002.CashParties38 *-- ISO20022.Sese025002.PartyIdentificationAndAccount177
    class ISO20022.Sese025002.CashSettlementSystem2Code {
        NETS = 1
        GROS = 2
    }
    class ISO20022.Sese025002.CashSettlementSystem5Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.CashSettlementSystem5Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.CentralCounterPartyEligibility5Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese025002.CentralCounterPartyEligibility5Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.ClassificationType33Choice {
        + AltrnClssfctn  : ISO20022.Sese025002.GenericIdentification86
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Sese025002.ClassificationType33Choice *-- ISO20022.Sese025002.GenericIdentification86
    class ISO20022.Sese025002.Counterparty16Choice {
        + Buyr  : ISO20022.Sese025002.PartyIdentificationAndAccount206
        + Sellr  : ISO20022.Sese025002.PartyIdentificationAndAccount206
    }
    ISO20022.Sese025002.Counterparty16Choice *-- ISO20022.Sese025002.PartyIdentificationAndAccount206
    ISO20022.Sese025002.Counterparty16Choice *-- ISO20022.Sese025002.PartyIdentificationAndAccount206
    class ISO20022.Sese025002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese025002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese025002.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese025002.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese025002.Eligibility1Code {
        PROF = 1
        RETL = 2
        ELIG = 3
    }
    class ISO20022.Sese025002.EventFrequency3Code {
        WEEK = 1
        SEMI = 2
        QUTR = 3
        MNTH = 4
        YEAR = 5
    }
    class ISO20022.Sese025002.ExposureType12Code {
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
    class ISO20022.Sese025002.ExposureType24Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.ExposureType24Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.FinancialInstrumentAttributes122 {
        + FinInstrmAttrAddtlDtls  : String
        + UndrlygFinInstrmId  : global::System.Collections.Generic.List~ISO20022.Sese025002.SecurityIdentification20~
        + CtrctSz  : ISO20022.Sese025002.FinancialInstrumentQuantity36Choice
        + MinNmnlQty  : ISO20022.Sese025002.FinancialInstrumentQuantity36Choice
        + StrkPric  : ISO20022.Sese025002.Price3
        + ConvsPric  : ISO20022.Sese025002.Price3
        + SbcptPric  : ISO20022.Sese025002.Price3
        + ExrcPric  : ISO20022.Sese025002.Price3
        + MktOrIndctvPric  : ISO20022.Sese025002.PriceType5Choice
        + PutblInd  : String
        + CllblInd  : String
        + VarblRateInd  : String
        + PoolNb  : ISO20022.Sese025002.GenericIdentification39
        + CpnAttchdNb  : ISO20022.Sese025002.Number23Choice
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
        + OptnTp  : ISO20022.Sese025002.OptionType7Choice
        + OptnStyle  : ISO20022.Sese025002.OptionStyle9Choice
        + ClssfctnTp  : ISO20022.Sese025002.ClassificationType33Choice
        + VarblRateChngFrqcy  : ISO20022.Sese025002.Frequency27Choice
        + PmtSts  : ISO20022.Sese025002.SecuritiesPaymentStatus6Choice
        + PmtFrqcy  : ISO20022.Sese025002.Frequency27Choice
        + RegnForm  : ISO20022.Sese025002.FormOfSecurity7Choice
        + DayCntBsis  : ISO20022.Sese025002.InterestComputationMethodFormat5Choice
        + PlcOfListg  : ISO20022.Sese025002.MarketIdentification4Choice
    }
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.SecurityIdentification20
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.FinancialInstrumentQuantity36Choice
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.FinancialInstrumentQuantity36Choice
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.Price3
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.Price3
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.Price3
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.Price3
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.PriceType5Choice
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.GenericIdentification39
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.Number23Choice
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.OptionType7Choice
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.OptionStyle9Choice
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.ClassificationType33Choice
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.Frequency27Choice
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.SecuritiesPaymentStatus6Choice
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.Frequency27Choice
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.FormOfSecurity7Choice
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.InterestComputationMethodFormat5Choice
    ISO20022.Sese025002.FinancialInstrumentAttributes122 *-- ISO20022.Sese025002.MarketIdentification4Choice
    class ISO20022.Sese025002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese025002.ForeignExchangeTerms23 {
        + RsltgAmt  : ISO20022.Sese025002.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Sese025002.ForeignExchangeTerms23 *-- ISO20022.Sese025002.ActiveCurrencyAndAmount
    class ISO20022.Sese025002.ForeignExchangeTerms27 {
        + RsltgAmt  : ISO20022.Sese025002.RestrictedFINActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Sese025002.ForeignExchangeTerms27 *-- ISO20022.Sese025002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese025002.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Sese025002.FormOfSecurity7Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.FormOfSecurity7Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.Frequency27Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.Frequency27Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.GenericIdentification18 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Sese025002.GenericIdentification39 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese025002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese025002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese025002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Sese025002.GenericIdentification47
    }
    ISO20022.Sese025002.GenericIdentification85 *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.GenericIdentification86 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese025002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese025002.IdentificationType44Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.IdentificationType44Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.InterestComputationMethod2Code {
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
    class ISO20022.Sese025002.InterestComputationMethodFormat5Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.InterestComputationMethodFormat5Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.InvestorCapacity5Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.InvestorCapacity5Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.LetterOfGuarantee5Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese025002.LetterOfGuarantee5Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.Linkages50 {
        + SctiesSttlmTxId  : String
        + PrcgPos  : ISO20022.Sese025002.ProcessingPosition23Choice
    }
    ISO20022.Sese025002.Linkages50 *-- ISO20022.Sese025002.ProcessingPosition23Choice
    class ISO20022.Sese025002.MarketClientSide1Code {
        MAKT = 1
        CLNT = 2
    }
    class ISO20022.Sese025002.MarketClientSide7Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.MarketClientSide7Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.MarketIdentification2Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese025002.MarketIdentification4Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese025002.MarketIdentification90 {
        + Tp  : ISO20022.Sese025002.MarketType16Choice
        + Id  : ISO20022.Sese025002.MarketIdentification2Choice
    }
    ISO20022.Sese025002.MarketIdentification90 *-- ISO20022.Sese025002.MarketType16Choice
    ISO20022.Sese025002.MarketIdentification90 *-- ISO20022.Sese025002.MarketIdentification2Choice
    class ISO20022.Sese025002.MarketType16Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.MarketType16Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Sese025002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Sese025002.NettingEligibility5Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese025002.NettingEligibility5Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.Number23Choice {
        + Lng  : ISO20022.Sese025002.GenericIdentification18
        + Shrt  : String
    }
    ISO20022.Sese025002.Number23Choice *-- ISO20022.Sese025002.GenericIdentification18
    class ISO20022.Sese025002.OpeningClosing1Code {
        OPEP = 1
        CLOP = 2
    }
    class ISO20022.Sese025002.OpeningClosing4Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.OpeningClosing4Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Sese025002.OptionStyle9Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.OptionStyle9Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Sese025002.OptionType7Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.OptionType7Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.OriginalAndCurrentQuantities4 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Sese025002.OriginatorRole2Code {
        TAGT = 1
        INVE = 2
        MKTM = 3
        RMKT = 4
        MLTF = 5
        SINT = 6
    }
    class ISO20022.Sese025002.OtherAmounts44 {
        + RsrchFee  : ISO20022.Sese025002.AmountAndDirection44
        + CollMntrAmt  : ISO20022.Sese025002.AmountAndDirection58
        + BookVal  : ISO20022.Sese025002.AmountAndDirection58
        + AcrdCptlstnAmt  : ISO20022.Sese025002.AmountAndDirection58
        + CsmptnTax  : ISO20022.Sese025002.AmountAndDirection58
        + NetGnLoss  : ISO20022.Sese025002.AmountAndDirection58
        + WhldgTax  : ISO20022.Sese025002.AmountAndDirection58
        + ValAddedTax  : ISO20022.Sese025002.AmountAndDirection58
        + TxTax  : ISO20022.Sese025002.AmountAndDirection58
        + TrfTax  : ISO20022.Sese025002.AmountAndDirection58
        + StockXchgTax  : ISO20022.Sese025002.AmountAndDirection58
        + StmpDty  : ISO20022.Sese025002.AmountAndDirection58
        + SpclCncssn  : ISO20022.Sese025002.AmountAndDirection58
        + ShppgAmt  : ISO20022.Sese025002.AmountAndDirection58
        + RgltryAmt  : ISO20022.Sese025002.AmountAndDirection58
        + Othr  : ISO20022.Sese025002.AmountAndDirection58
        + Mrgn  : ISO20022.Sese025002.AmountAndDirection58
        + LclBrkrComssn  : ISO20022.Sese025002.AmountAndDirection58
        + LclTaxCtrySpcfc  : ISO20022.Sese025002.AmountAndDirection58
        + LclTax  : ISO20022.Sese025002.AmountAndDirection58
        + PmtLevyTax  : ISO20022.Sese025002.AmountAndDirection58
        + IsseDscntAllwnc  : ISO20022.Sese025002.AmountAndDirection58
        + ExctgBrkrAmt  : ISO20022.Sese025002.AmountAndDirection58
        + TradAmt  : ISO20022.Sese025002.AmountAndDirection58
        + CtryNtlFdrlTax  : ISO20022.Sese025002.AmountAndDirection58
        + ChrgsFees  : ISO20022.Sese025002.AmountAndDirection58
        + AcrdIntrstAmt  : ISO20022.Sese025002.AmountAndDirection58
    }
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection44
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    ISO20022.Sese025002.OtherAmounts44 *-- ISO20022.Sese025002.AmountAndDirection58
    class ISO20022.Sese025002.OtherIdentification2 {
        + Tp  : ISO20022.Sese025002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese025002.OtherIdentification2 *-- ISO20022.Sese025002.IdentificationSource4Choice
    class ISO20022.Sese025002.OtherParties44 {
        + Brkr  : ISO20022.Sese025002.PartyIdentificationAndAccount209
        + TrptyAgt  : ISO20022.Sese025002.PartyIdentificationAndAccount209
        + TradRgltr  : ISO20022.Sese025002.PartyIdentificationAndAccount181
        + StockXchg  : ISO20022.Sese025002.PartyIdentificationAndAccount181
        + QlfdFrgnIntrmy  : ISO20022.Sese025002.PartyIdentificationAndAccount209
        + Invstr  : global::System.Collections.Generic.List~ISO20022.Sese025002.PartyIdentificationAndAccount208~
    }
    ISO20022.Sese025002.OtherParties44 *-- ISO20022.Sese025002.PartyIdentificationAndAccount209
    ISO20022.Sese025002.OtherParties44 *-- ISO20022.Sese025002.PartyIdentificationAndAccount209
    ISO20022.Sese025002.OtherParties44 *-- ISO20022.Sese025002.PartyIdentificationAndAccount181
    ISO20022.Sese025002.OtherParties44 *-- ISO20022.Sese025002.PartyIdentificationAndAccount181
    ISO20022.Sese025002.OtherParties44 *-- ISO20022.Sese025002.PartyIdentificationAndAccount209
    ISO20022.Sese025002.OtherParties44 *-- ISO20022.Sese025002.PartyIdentificationAndAccount208
    class ISO20022.Sese025002.OwnershipLegalRestrictions1Code {
        RSTR = 1
        NRST = 2
        A144 = 3
    }
    class ISO20022.Sese025002.PartialSettlement2Code {
        PARC = 1
        PAIN = 2
    }
    class ISO20022.Sese025002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Sese025002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese025002.PartyIdentification136Choice *-- ISO20022.Sese025002.GenericIdentification84
    class ISO20022.Sese025002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Sese025002.NameAndAddress12
        + PrtryId  : ISO20022.Sese025002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese025002.PartyIdentification137Choice *-- ISO20022.Sese025002.NameAndAddress12
    ISO20022.Sese025002.PartyIdentification137Choice *-- ISO20022.Sese025002.GenericIdentification84
    class ISO20022.Sese025002.PartyIdentification145Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese025002.NameAndAddress12
        + AnyBIC  : String
    }
    ISO20022.Sese025002.PartyIdentification145Choice *-- ISO20022.Sese025002.NameAndAddress12
    class ISO20022.Sese025002.PartyIdentification147Choice {
        + PrtryId  : ISO20022.Sese025002.GenericIdentification84
        + NmAndAdr  : ISO20022.Sese025002.NameAndAddress12
        + BICFI  : String
    }
    ISO20022.Sese025002.PartyIdentification147Choice *-- ISO20022.Sese025002.GenericIdentification84
    ISO20022.Sese025002.PartyIdentification147Choice *-- ISO20022.Sese025002.NameAndAddress12
    class ISO20022.Sese025002.PartyIdentification156 {
        + LEI  : String
        + Id  : ISO20022.Sese025002.PartyIdentification136Choice
    }
    ISO20022.Sese025002.PartyIdentification156 *-- ISO20022.Sese025002.PartyIdentification136Choice
    class ISO20022.Sese025002.PartyIdentification157 {
        + LEI  : String
        + Id  : ISO20022.Sese025002.PartyIdentification137Choice
    }
    ISO20022.Sese025002.PartyIdentification157 *-- ISO20022.Sese025002.PartyIdentification137Choice
    class ISO20022.Sese025002.PartyIdentification162 {
        + AddtlInf  : ISO20022.Sese025002.PartyTextInformation3
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese025002.DateAndDateTime2Choice
        + AltrnId  : ISO20022.Sese025002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese025002.PartyIdentification145Choice
    }
    ISO20022.Sese025002.PartyIdentification162 *-- ISO20022.Sese025002.PartyTextInformation3
    ISO20022.Sese025002.PartyIdentification162 *-- ISO20022.Sese025002.DateAndDateTime2Choice
    ISO20022.Sese025002.PartyIdentification162 *-- ISO20022.Sese025002.AlternatePartyIdentification9
    ISO20022.Sese025002.PartyIdentification162 *-- ISO20022.Sese025002.PartyIdentification145Choice
    class ISO20022.Sese025002.PartyIdentificationAndAccount177 {
        + AddtlInf  : ISO20022.Sese025002.PartyTextInformation4
        + TaxAcct  : ISO20022.Sese025002.CashAccountIdentification6Choice
        + ComssnAcct  : ISO20022.Sese025002.CashAccountIdentification6Choice
        + ChrgsAcct  : ISO20022.Sese025002.CashAccountIdentification6Choice
        + CshAcct  : ISO20022.Sese025002.CashAccountIdentification6Choice
        + AltrnId  : ISO20022.Sese025002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese025002.PartyIdentification137Choice
    }
    ISO20022.Sese025002.PartyIdentificationAndAccount177 *-- ISO20022.Sese025002.PartyTextInformation4
    ISO20022.Sese025002.PartyIdentificationAndAccount177 *-- ISO20022.Sese025002.CashAccountIdentification6Choice
    ISO20022.Sese025002.PartyIdentificationAndAccount177 *-- ISO20022.Sese025002.CashAccountIdentification6Choice
    ISO20022.Sese025002.PartyIdentificationAndAccount177 *-- ISO20022.Sese025002.CashAccountIdentification6Choice
    ISO20022.Sese025002.PartyIdentificationAndAccount177 *-- ISO20022.Sese025002.CashAccountIdentification6Choice
    ISO20022.Sese025002.PartyIdentificationAndAccount177 *-- ISO20022.Sese025002.AlternatePartyIdentification9
    ISO20022.Sese025002.PartyIdentificationAndAccount177 *-- ISO20022.Sese025002.PartyIdentification137Choice
    class ISO20022.Sese025002.PartyIdentificationAndAccount178 {
        + AddtlInf  : ISO20022.Sese025002.PartyTextInformation4
        + TaxAcct  : ISO20022.Sese025002.CashAccountIdentification6Choice
        + ComssnAcct  : ISO20022.Sese025002.CashAccountIdentification6Choice
        + ChrgsAcct  : ISO20022.Sese025002.CashAccountIdentification6Choice
        + CshAcct  : ISO20022.Sese025002.CashAccountIdentification6Choice
        + AltrnId  : ISO20022.Sese025002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese025002.PartyIdentification147Choice
    }
    ISO20022.Sese025002.PartyIdentificationAndAccount178 *-- ISO20022.Sese025002.PartyTextInformation4
    ISO20022.Sese025002.PartyIdentificationAndAccount178 *-- ISO20022.Sese025002.CashAccountIdentification6Choice
    ISO20022.Sese025002.PartyIdentificationAndAccount178 *-- ISO20022.Sese025002.CashAccountIdentification6Choice
    ISO20022.Sese025002.PartyIdentificationAndAccount178 *-- ISO20022.Sese025002.CashAccountIdentification6Choice
    ISO20022.Sese025002.PartyIdentificationAndAccount178 *-- ISO20022.Sese025002.CashAccountIdentification6Choice
    ISO20022.Sese025002.PartyIdentificationAndAccount178 *-- ISO20022.Sese025002.AlternatePartyIdentification9
    ISO20022.Sese025002.PartyIdentificationAndAccount178 *-- ISO20022.Sese025002.PartyIdentification147Choice
    class ISO20022.Sese025002.PartyIdentificationAndAccount181 {
        + AddtlInf  : ISO20022.Sese025002.PartyTextInformation3
        + PrcgId  : String
        + AltrnId  : ISO20022.Sese025002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese025002.PartyIdentification137Choice
    }
    ISO20022.Sese025002.PartyIdentificationAndAccount181 *-- ISO20022.Sese025002.PartyTextInformation3
    ISO20022.Sese025002.PartyIdentificationAndAccount181 *-- ISO20022.Sese025002.AlternatePartyIdentification9
    ISO20022.Sese025002.PartyIdentificationAndAccount181 *-- ISO20022.Sese025002.PartyIdentification137Choice
    class ISO20022.Sese025002.PartyIdentificationAndAccount206 {
        + AddtlInf  : ISO20022.Sese025002.PartyTextInformation3
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese025002.DateAndDateTime2Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese025002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese025002.SecuritiesAccount30
        + AltrnId  : ISO20022.Sese025002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese025002.PartyIdentification137Choice
    }
    ISO20022.Sese025002.PartyIdentificationAndAccount206 *-- ISO20022.Sese025002.PartyTextInformation3
    ISO20022.Sese025002.PartyIdentificationAndAccount206 *-- ISO20022.Sese025002.DateAndDateTime2Choice
    ISO20022.Sese025002.PartyIdentificationAndAccount206 *-- ISO20022.Sese025002.BlockChainAddressWallet7
    ISO20022.Sese025002.PartyIdentificationAndAccount206 *-- ISO20022.Sese025002.SecuritiesAccount30
    ISO20022.Sese025002.PartyIdentificationAndAccount206 *-- ISO20022.Sese025002.AlternatePartyIdentification9
    ISO20022.Sese025002.PartyIdentificationAndAccount206 *-- ISO20022.Sese025002.PartyIdentification137Choice
    class ISO20022.Sese025002.PartyIdentificationAndAccount208 {
        + AddtlInf  : ISO20022.Sese025002.PartyTextInformation3
        + PrcgId  : String
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
        + Ntlty  : String
        + AltrnId  : ISO20022.Sese025002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese025002.PartyIdentification137Choice
    }
    ISO20022.Sese025002.PartyIdentificationAndAccount208 *-- ISO20022.Sese025002.PartyTextInformation3
    ISO20022.Sese025002.PartyIdentificationAndAccount208 *-- ISO20022.Sese025002.AlternatePartyIdentification9
    ISO20022.Sese025002.PartyIdentificationAndAccount208 *-- ISO20022.Sese025002.PartyIdentification137Choice
    class ISO20022.Sese025002.PartyIdentificationAndAccount209 {
        + AddtlInf  : ISO20022.Sese025002.PartyTextInformation3
        + PrcgId  : String
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
        + AltrnId  : ISO20022.Sese025002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese025002.PartyIdentification137Choice
    }
    ISO20022.Sese025002.PartyIdentificationAndAccount209 *-- ISO20022.Sese025002.PartyTextInformation3
    ISO20022.Sese025002.PartyIdentificationAndAccount209 *-- ISO20022.Sese025002.AlternatePartyIdentification9
    ISO20022.Sese025002.PartyIdentificationAndAccount209 *-- ISO20022.Sese025002.PartyIdentification137Choice
    class ISO20022.Sese025002.PartyTextInformation3 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese025002.PartyTextInformation4 {
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese025002.PlaceOfClearingIdentification2 {
        + LEI  : String
        + Id  : String
    }
    class ISO20022.Sese025002.PlaceOfTradeIdentification2 {
        + LEI  : String
        + MktTpAndId  : ISO20022.Sese025002.MarketIdentification90
    }
    ISO20022.Sese025002.PlaceOfTradeIdentification2 *-- ISO20022.Sese025002.MarketIdentification90
    class ISO20022.Sese025002.PreConfirmation1Code {
        PRSE = 1
        PRCA = 2
    }
    class ISO20022.Sese025002.Price11 {
        + Val  : ISO20022.Sese025002.PriceRateOrAmount1Choice
        + Tp  : ISO20022.Sese025002.YieldedOrValueType2Choice
    }
    ISO20022.Sese025002.Price11 *-- ISO20022.Sese025002.PriceRateOrAmount1Choice
    ISO20022.Sese025002.Price11 *-- ISO20022.Sese025002.YieldedOrValueType2Choice
    class ISO20022.Sese025002.Price3 {
        + Val  : ISO20022.Sese025002.PriceRateOrAmount1Choice
        + Tp  : ISO20022.Sese025002.YieldedOrValueType1Choice
    }
    ISO20022.Sese025002.Price3 *-- ISO20022.Sese025002.PriceRateOrAmount1Choice
    ISO20022.Sese025002.Price3 *-- ISO20022.Sese025002.YieldedOrValueType1Choice
    class ISO20022.Sese025002.PriceRateOrAmount1Choice {
        + Amt  : ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Sese025002.PriceRateOrAmount1Choice *-- ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Sese025002.PriceType5Choice {
        + Indctv  : ISO20022.Sese025002.Price3
        + Mkt  : ISO20022.Sese025002.Price3
    }
    ISO20022.Sese025002.PriceType5Choice *-- ISO20022.Sese025002.Price3
    ISO20022.Sese025002.PriceType5Choice *-- ISO20022.Sese025002.Price3
    class ISO20022.Sese025002.PriceValueType12Code {
        NEGA = 1
        PREM = 2
        PARV = 3
        DISC = 4
    }
    class ISO20022.Sese025002.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Sese025002.PriorityNumeric5Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Nmrc  : String
    }
    ISO20022.Sese025002.PriorityNumeric5Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.ProcessingPosition23Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.ProcessingPosition23Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.ProcessingPosition5Code {
        INFO = 1
    }
    class ISO20022.Sese025002.Quantity54Choice {
        + OrgnlAndCurFace  : ISO20022.Sese025002.OriginalAndCurrentQuantities4
        + Qty  : ISO20022.Sese025002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Sese025002.Quantity54Choice *-- ISO20022.Sese025002.OriginalAndCurrentQuantities4
    ISO20022.Sese025002.Quantity54Choice *-- ISO20022.Sese025002.FinancialInstrumentQuantity36Choice
    class ISO20022.Sese025002.QuantityAndAccount108 {
        + SfkpgPlc  : ISO20022.Sese025002.SafeKeepingPlace4
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Sese025002.QuantityBreakdown75~
        + CshAcct  : ISO20022.Sese025002.CashAccountIdentification6Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese025002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese025002.SecuritiesAccount30
        + AcctOwnr  : ISO20022.Sese025002.PartyIdentification156
        + DnmtnChc  : String
        + RmngToBeSttldAmt  : ISO20022.Sese025002.AmountAndDirection57
        + PrevslySttldAmt  : ISO20022.Sese025002.AmountAndDirection57
        + RmngToBeSttldQty  : ISO20022.Sese025002.FinancialInstrumentQuantity36Choice
        + PrevslySttldQty  : ISO20022.Sese025002.FinancialInstrumentQuantity36Choice
        + SttldQty  : ISO20022.Sese025002.Quantity54Choice
    }
    ISO20022.Sese025002.QuantityAndAccount108 *-- ISO20022.Sese025002.SafeKeepingPlace4
    ISO20022.Sese025002.QuantityAndAccount108 *-- ISO20022.Sese025002.QuantityBreakdown75
    ISO20022.Sese025002.QuantityAndAccount108 *-- ISO20022.Sese025002.CashAccountIdentification6Choice
    ISO20022.Sese025002.QuantityAndAccount108 *-- ISO20022.Sese025002.BlockChainAddressWallet7
    ISO20022.Sese025002.QuantityAndAccount108 *-- ISO20022.Sese025002.SecuritiesAccount30
    ISO20022.Sese025002.QuantityAndAccount108 *-- ISO20022.Sese025002.PartyIdentification156
    ISO20022.Sese025002.QuantityAndAccount108 *-- ISO20022.Sese025002.AmountAndDirection57
    ISO20022.Sese025002.QuantityAndAccount108 *-- ISO20022.Sese025002.AmountAndDirection57
    ISO20022.Sese025002.QuantityAndAccount108 *-- ISO20022.Sese025002.FinancialInstrumentQuantity36Choice
    ISO20022.Sese025002.QuantityAndAccount108 *-- ISO20022.Sese025002.FinancialInstrumentQuantity36Choice
    ISO20022.Sese025002.QuantityAndAccount108 *-- ISO20022.Sese025002.Quantity54Choice
    class ISO20022.Sese025002.QuantityBreakdown75 {
        + TpOfPric  : ISO20022.Sese025002.TypeOfPrice32Choice
        + LotPric  : ISO20022.Sese025002.Price3
        + LotDtTm  : ISO20022.Sese025002.DateAndDateTime2Choice
        + SctiesSubBalTp  : ISO20022.Sese025002.GenericIdentification47
        + LotQty  : ISO20022.Sese025002.FinancialInstrumentQuantity36Choice
        + LotNb  : ISO20022.Sese025002.GenericIdentification39
    }
    ISO20022.Sese025002.QuantityBreakdown75 *-- ISO20022.Sese025002.TypeOfPrice32Choice
    ISO20022.Sese025002.QuantityBreakdown75 *-- ISO20022.Sese025002.Price3
    ISO20022.Sese025002.QuantityBreakdown75 *-- ISO20022.Sese025002.DateAndDateTime2Choice
    ISO20022.Sese025002.QuantityBreakdown75 *-- ISO20022.Sese025002.GenericIdentification47
    ISO20022.Sese025002.QuantityBreakdown75 *-- ISO20022.Sese025002.FinancialInstrumentQuantity36Choice
    ISO20022.Sese025002.QuantityBreakdown75 *-- ISO20022.Sese025002.GenericIdentification39
    class ISO20022.Sese025002.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese025002.Registration11Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.Registration11Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.Registration1Code {
        YREG = 1
        NREG = 2
    }
    class ISO20022.Sese025002.RegistrationParameters7 {
        + CertNb  : global::System.Collections.Generic.List~ISO20022.Sese025002.SecuritiesCertificate5~
        + RegarAcct  : String
        + CertfctnDtTm  : ISO20022.Sese025002.DateAndDateTime2Choice
        + CertfctnId  : String
    }
    ISO20022.Sese025002.RegistrationParameters7 *-- ISO20022.Sese025002.SecuritiesCertificate5
    ISO20022.Sese025002.RegistrationParameters7 *-- ISO20022.Sese025002.DateAndDateTime2Choice
    class ISO20022.Sese025002.Reporting2Code {
        DEFR = 1
        REGU = 2
        STEX = 3
    }
    class ISO20022.Sese025002.Reporting9Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.Reporting9Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.RepurchaseType24Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.RepurchaseType24Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.RepurchaseType9Code {
        WTHD = 1
        TOPU = 2
        CADJ = 3
        ROLP = 4
        CALL = 5
        RATE = 6
        PADJ = 7
        PAIR = 8
    }
    class ISO20022.Sese025002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese025002.Restriction6Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.Restriction6Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.SafeKeepingPlace4 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Sese025002.SafekeepingPlaceFormat39Choice
    }
    ISO20022.Sese025002.SafeKeepingPlace4 *-- ISO20022.Sese025002.SafekeepingPlaceFormat39Choice
    class ISO20022.Sese025002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Sese025002.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Sese025002.SafekeepingPlaceFormat39Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification85
        + TpAndId  : ISO20022.Sese025002.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Sese025002.SafekeepingPlaceTypeAndText15
    }
    ISO20022.Sese025002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese025002.GenericIdentification85
    ISO20022.Sese025002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese025002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Sese025002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese025002.SafekeepingPlaceTypeAndText15
    class ISO20022.Sese025002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese025002.SafekeepingPlaceTypeAndText15 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese025002.SecuritiesAccount30 {
        + Nm  : String
        + Tp  : ISO20022.Sese025002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese025002.SecuritiesAccount30 *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.SecuritiesCertificate5 {
        + SchmeNm  : String
        + Issr  : String
        + Nb  : String
    }
    class ISO20022.Sese025002.SecuritiesPaymentStatus1Code {
        PART = 1
        NILL = 2
        FULL = 3
    }
    class ISO20022.Sese025002.SecuritiesPaymentStatus6Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.SecuritiesPaymentStatus6Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.SecuritiesRTGS5Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese025002.SecuritiesRTGS5Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese025002.SupplementaryData1~
        + AddtlPhysOrRegnDtls  : ISO20022.Sese025002.RegistrationParameters7
        + OthrBizPties  : ISO20022.Sese025002.OtherParties44
        + OthrAmts  : ISO20022.Sese025002.OtherAmounts44
        + SttldAmt  : ISO20022.Sese025002.AmountAndDirection96
        + CshPties  : ISO20022.Sese025002.CashParties38
        + RcvgSttlmPties  : ISO20022.Sese025002.SettlementParties105
        + DlvrgSttlmPties  : ISO20022.Sese025002.SettlementParties105
        + StgSttlmInstrDtls  : ISO20022.Sese025002.StandingSettlementInstruction19
        + SttlmParams  : ISO20022.Sese025002.SettlementDetails211
        + QtyAndAcctDtls  : ISO20022.Sese025002.QuantityAndAccount108
        + FinInstrmAttrbts  : ISO20022.Sese025002.FinancialInstrumentAttributes122
        + FinInstrmId  : ISO20022.Sese025002.SecurityIdentification20
        + TradDtls  : ISO20022.Sese025002.SecuritiesTradeDetails128
        + AddtlParams  : ISO20022.Sese025002.AdditionalParameters31
        + Lnkgs  : ISO20022.Sese025002.Linkages50
        + TxIdDtls  : ISO20022.Sese025002.SettlementTypeAndIdentification28
    }
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.SupplementaryData1
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.RegistrationParameters7
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.OtherParties44
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.OtherAmounts44
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.AmountAndDirection96
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.CashParties38
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.SettlementParties105
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.SettlementParties105
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.StandingSettlementInstruction19
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.SettlementDetails211
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.QuantityAndAccount108
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.FinancialInstrumentAttributes122
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.SecurityIdentification20
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.SecuritiesTradeDetails128
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.AdditionalParameters31
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.Linkages50
    ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11 *-- ISO20022.Sese025002.SettlementTypeAndIdentification28
    class ISO20022.Sese025002.SecuritiesTradeDetails128 {
        + SttlmInstrPrcgAddtlDtls  : String
        + FxAddtlDtls  : String
        + TpOfPric  : ISO20022.Sese025002.TypeOfPrice32Choice
        + TradOrgtrRole  : ISO20022.Sese025002.TradeOriginator4Choice
        + InvstrCpcty  : ISO20022.Sese025002.InvestorCapacity5Choice
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Sese025002.TradeTransactionCondition6Choice~
        + Rptg  : global::System.Collections.Generic.List~ISO20022.Sese025002.Reporting9Choice~
        + OpngClsg  : ISO20022.Sese025002.OpeningClosing4Choice
        + NbOfDaysAcrd  : Decimal
        + DealPric  : ISO20022.Sese025002.Price11
        + FctvSttlmDt  : ISO20022.Sese025002.SettlementDate22Choice
        + SttlmDt  : ISO20022.Sese025002.SettlementDate20Choice
        + TradDt  : ISO20022.Sese025002.TradeDate9Choice
        + PlcOfClr  : ISO20022.Sese025002.PlaceOfClearingIdentification2
        + PlcOfTrad  : ISO20022.Sese025002.PlaceOfTradeIdentification2
        + CollTxId  : global::System.Collections.Generic.List~String~
        + TradId  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Sese025002.SecuritiesTradeDetails128 *-- ISO20022.Sese025002.TypeOfPrice32Choice
    ISO20022.Sese025002.SecuritiesTradeDetails128 *-- ISO20022.Sese025002.TradeOriginator4Choice
    ISO20022.Sese025002.SecuritiesTradeDetails128 *-- ISO20022.Sese025002.InvestorCapacity5Choice
    ISO20022.Sese025002.SecuritiesTradeDetails128 *-- ISO20022.Sese025002.TradeTransactionCondition6Choice
    ISO20022.Sese025002.SecuritiesTradeDetails128 *-- ISO20022.Sese025002.Reporting9Choice
    ISO20022.Sese025002.SecuritiesTradeDetails128 *-- ISO20022.Sese025002.OpeningClosing4Choice
    ISO20022.Sese025002.SecuritiesTradeDetails128 *-- ISO20022.Sese025002.Price11
    ISO20022.Sese025002.SecuritiesTradeDetails128 *-- ISO20022.Sese025002.SettlementDate22Choice
    ISO20022.Sese025002.SecuritiesTradeDetails128 *-- ISO20022.Sese025002.SettlementDate20Choice
    ISO20022.Sese025002.SecuritiesTradeDetails128 *-- ISO20022.Sese025002.TradeDate9Choice
    ISO20022.Sese025002.SecuritiesTradeDetails128 *-- ISO20022.Sese025002.PlaceOfClearingIdentification2
    ISO20022.Sese025002.SecuritiesTradeDetails128 *-- ISO20022.Sese025002.PlaceOfTradeIdentification2
    class ISO20022.Sese025002.SecuritiesTransactionType25Code {
        REBL = 1
        ETFT = 2
        SWIT = 3
        SWIF = 4
        AUTO = 5
        CORP = 6
        CLAI = 7
        TURN = 8
        TRVO = 9
        TRPO = 10
        TRAD = 11
        TBAC = 12
        SYND = 13
        SUBS = 14
        SLRE = 15
        SECL = 16
        SECB = 17
        SBRE = 18
        SBBK = 19
        RVPO = 20
        RODE = 21
        REPU = 22
        RELE = 23
        REDM = 24
        REDI = 25
        REAL = 26
        PORT = 27
        PLAC = 28
        PAIR = 29
        OWNI = 30
        OWNE = 31
        NSYN = 32
        NETT = 33
        MKUP = 34
        MKDW = 35
        ISSU = 36
        INSP = 37
        FCTA = 38
        CONV = 39
        COLO = 40
        COLI = 41
        CNCB = 42
        BYIY = 43
        BSBK = 44
    }
    class ISO20022.Sese025002.SecuritiesTransactionType51Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.SecuritiesTransactionType51Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese025002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Sese025002.SecurityIdentification20 *-- ISO20022.Sese025002.OtherIdentification2
    class ISO20022.Sese025002.SettlementDate20Choice {
        + DtCd  : ISO20022.Sese025002.SettlementDateCode9Choice
        + Dt  : ISO20022.Sese025002.DateAndDateTime2Choice
    }
    ISO20022.Sese025002.SettlementDate20Choice *-- ISO20022.Sese025002.SettlementDateCode9Choice
    ISO20022.Sese025002.SettlementDate20Choice *-- ISO20022.Sese025002.DateAndDateTime2Choice
    class ISO20022.Sese025002.SettlementDate22Choice {
        + DtCd  : ISO20022.Sese025002.GenericIdentification47
        + Dt  : ISO20022.Sese025002.DateAndDateTime2Choice
    }
    ISO20022.Sese025002.SettlementDate22Choice *-- ISO20022.Sese025002.GenericIdentification47
    ISO20022.Sese025002.SettlementDate22Choice *-- ISO20022.Sese025002.DateAndDateTime2Choice
    class ISO20022.Sese025002.SettlementDate4Code {
        WISS = 1
    }
    class ISO20022.Sese025002.SettlementDateCode9Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.SettlementDateCode9Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.SettlementDetails211 {
        + CshSubBalTp  : ISO20022.Sese025002.GenericIdentification47
        + SctiesSubBalTp  : ISO20022.Sese025002.GenericIdentification47
        + ElgblForColl  : String
        + LttrOfGrnt  : ISO20022.Sese025002.LetterOfGuarantee5Choice
        + AutomtcBrrwg  : ISO20022.Sese025002.AutomaticBorrowing8Choice
        + StmpDtyTaxBsis  : ISO20022.Sese025002.GenericIdentification47
        + TaxCpcty  : ISO20022.Sese025002.TaxCapacityParty5Choice
        + SttlmSysMtd  : ISO20022.Sese025002.SettlementSystemMethod5Choice
        + SttlgCpcty  : ISO20022.Sese025002.SettlingCapacity8Choice
        + SctiesRTGS  : ISO20022.Sese025002.SecuritiesRTGS5Choice
        + LglRstrctns  : ISO20022.Sese025002.Restriction6Choice
        + RpTp  : ISO20022.Sese025002.RepurchaseType24Choice
        + Regn  : ISO20022.Sese025002.Registration11Choice
        + NetgElgblty  : ISO20022.Sese025002.NettingEligibility5Choice
        + MktClntSd  : ISO20022.Sese025002.MarketClientSide7Choice
        + XpsrTp  : ISO20022.Sese025002.ExposureType24Choice
        + CshClrSys  : ISO20022.Sese025002.CashSettlementSystem5Choice
        + CCPElgblty  : ISO20022.Sese025002.CentralCounterPartyEligibility5Choice
        + BlckTrad  : ISO20022.Sese025002.BlockTrade5Choice
        + BnfclOwnrsh  : ISO20022.Sese025002.BeneficialOwnership5Choice
        + PrtlSttlmInd  : String
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese025002.SettlementTransactionCondition37Choice~
        + SctiesTxTp  : ISO20022.Sese025002.SecuritiesTransactionType51Choice
        + Prty  : ISO20022.Sese025002.PriorityNumeric5Choice
    }
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.GenericIdentification47
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.GenericIdentification47
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.LetterOfGuarantee5Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.AutomaticBorrowing8Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.GenericIdentification47
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.TaxCapacityParty5Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.SettlementSystemMethod5Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.SettlingCapacity8Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.SecuritiesRTGS5Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.Restriction6Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.RepurchaseType24Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.Registration11Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.NettingEligibility5Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.MarketClientSide7Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.ExposureType24Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.CashSettlementSystem5Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.CentralCounterPartyEligibility5Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.BlockTrade5Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.BeneficialOwnership5Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.SettlementTransactionCondition37Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.SecuritiesTransactionType51Choice
    ISO20022.Sese025002.SettlementDetails211 *-- ISO20022.Sese025002.PriorityNumeric5Choice
    class ISO20022.Sese025002.SettlementParties105 {
        + Pty5  : ISO20022.Sese025002.PartyIdentificationAndAccount206
        + Pty4  : ISO20022.Sese025002.PartyIdentificationAndAccount206
        + Pty3  : ISO20022.Sese025002.PartyIdentificationAndAccount206
        + Pty2  : ISO20022.Sese025002.PartyIdentificationAndAccount206
        + Pty1  : ISO20022.Sese025002.PartyIdentificationAndAccount206
        + Dpstry  : ISO20022.Sese025002.PartyIdentification162
    }
    ISO20022.Sese025002.SettlementParties105 *-- ISO20022.Sese025002.PartyIdentificationAndAccount206
    ISO20022.Sese025002.SettlementParties105 *-- ISO20022.Sese025002.PartyIdentificationAndAccount206
    ISO20022.Sese025002.SettlementParties105 *-- ISO20022.Sese025002.PartyIdentificationAndAccount206
    ISO20022.Sese025002.SettlementParties105 *-- ISO20022.Sese025002.PartyIdentificationAndAccount206
    ISO20022.Sese025002.SettlementParties105 *-- ISO20022.Sese025002.PartyIdentificationAndAccount206
    ISO20022.Sese025002.SettlementParties105 *-- ISO20022.Sese025002.PartyIdentification162
    class ISO20022.Sese025002.SettlementStandingInstructionDatabase1Code {
        VEND = 1
        BRKR = 2
        INTE = 3
    }
    class ISO20022.Sese025002.SettlementStandingInstructionDatabase5Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.SettlementStandingInstructionDatabase5Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.SettlementSystemMethod1Code {
        YSET = 1
        NSET = 2
    }
    class ISO20022.Sese025002.SettlementSystemMethod5Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.SettlementSystemMethod5Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.SettlementTransactionCondition12Code {
        BPSS = 1
        INTS = 2
        UNEX = 3
        TRIP = 4
        TRAN = 5
        SPST = 6
        SPDL = 7
        SHOR = 8
        RESI = 9
        RPTO = 10
        RHYP = 11
        PHYS = 12
        PENS = 13
        NACT = 14
        NOMC = 15
        KNOC = 16
        FRCL = 17
        EXPI = 18
        EXER = 19
        DRAW = 20
        DIRT = 21
        DLWM = 22
        CLEN = 23
        BUTC = 24
        ASGN = 25
        ADEA = 26
    }
    class ISO20022.Sese025002.SettlementTransactionCondition37Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.SettlementTransactionCondition37Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.SettlementTransactionCondition5Code {
        PARQ = 1
        PARC = 2
        NPAR = 3
        PART = 4
    }
    class ISO20022.Sese025002.SettlementTypeAndIdentification28 {
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
    class ISO20022.Sese025002.SettlingCapacity2Code {
        RISP = 1
        SPRI = 2
        CUST = 3
        SAGE = 4
    }
    class ISO20022.Sese025002.SettlingCapacity8Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.SettlingCapacity8Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.StandingSettlementInstruction19 {
        + OthrRcvgSttlmPties  : ISO20022.Sese025002.SettlementParties105
        + OthrDlvrgSttlmPties  : ISO20022.Sese025002.SettlementParties105
        + Vndr  : ISO20022.Sese025002.PartyIdentification157
        + CtrPty  : ISO20022.Sese025002.Counterparty16Choice
        + SttlmStgInstrDB  : ISO20022.Sese025002.SettlementStandingInstructionDatabase5Choice
    }
    ISO20022.Sese025002.StandingSettlementInstruction19 *-- ISO20022.Sese025002.SettlementParties105
    ISO20022.Sese025002.StandingSettlementInstruction19 *-- ISO20022.Sese025002.SettlementParties105
    ISO20022.Sese025002.StandingSettlementInstruction19 *-- ISO20022.Sese025002.PartyIdentification157
    ISO20022.Sese025002.StandingSettlementInstruction19 *-- ISO20022.Sese025002.Counterparty16Choice
    ISO20022.Sese025002.StandingSettlementInstruction19 *-- ISO20022.Sese025002.SettlementStandingInstructionDatabase5Choice
    class ISO20022.Sese025002.SupplementaryData1 {
        + Envlp  : ISO20022.Sese025002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese025002.SupplementaryData1 *-- ISO20022.Sese025002.SupplementaryDataEnvelope1
    class ISO20022.Sese025002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese025002.TaxCapacityParty5Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.TaxCapacityParty5Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.TaxLiability1Code {
        AGEN = 1
        PRIN = 2
    }
    class ISO20022.Sese025002.TradeDate9Choice {
        + DtCd  : ISO20022.Sese025002.TradeDateCode4Choice
        + Dt  : ISO20022.Sese025002.DateAndDateTime2Choice
    }
    ISO20022.Sese025002.TradeDate9Choice *-- ISO20022.Sese025002.TradeDateCode4Choice
    ISO20022.Sese025002.TradeDate9Choice *-- ISO20022.Sese025002.DateAndDateTime2Choice
    class ISO20022.Sese025002.TradeDateCode4Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.TradeDateCode4Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.TradeOriginator4Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.TradeOriginator4Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.TradeTransactionCondition4Code {
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
    class ISO20022.Sese025002.TradeTransactionCondition6Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.TradeTransactionCondition6Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Sese025002.TypeOfPrice14Code {
        AVER = 1
    }
    class ISO20022.Sese025002.TypeOfPrice32Choice {
        + Prtry  : ISO20022.Sese025002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese025002.TypeOfPrice32Choice *-- ISO20022.Sese025002.GenericIdentification47
    class ISO20022.Sese025002.YieldedOrValueType1Choice {
        + ValTp  : String
        + Yldd  : String
    }
    class ISO20022.Sese025002.YieldedOrValueType2Choice {
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

## Value ISO20022.Sese025002.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese025002.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese025002.AdditionalParameters31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrptyAgtSvcPrvdrCollInstrId|String||XmlElement()||
|+|ClntCollInstrId|String||XmlElement()||
|+|ClntTrptyCollTxId|String||XmlElement()||
|+|TrptyAgtSvcPrvdrCollTxId|String||XmlElement()||
|+|PrvsPrtlConfId|String||XmlElement()||
|+|PrtlSttlm|String||XmlElement()||
|+|PreConf|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TrptyAgtSvcPrvdrCollInstrId""",TrptyAgtSvcPrvdrCollInstrId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""ClntCollInstrId""",ClntCollInstrId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""ClntTrptyCollTxId""",ClntTrptyCollTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""TrptyAgtSvcPrvdrCollTxId""",TrptyAgtSvcPrvdrCollTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""PrvsPrtlConfId""",PrvsPrtlConfId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese025002.AlternatePartyIdentification9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Sese025002.IdentificationType44Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AltrnId""",AltrnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Sese025002.AmountAndDirection44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Sese025002.ForeignExchangeTerms23||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese025002.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese025002.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese025002.AmountAndDirection57


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese025002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Sese025002.AmountAndDirection58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Sese025002.ForeignExchangeTerms27||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese025002.AmountAndDirection96


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValDt|ISO20022.Sese025002.DateAndDateTime2Choice||XmlElement()||
|+|FXDtls|ISO20022.Sese025002.ForeignExchangeTerms27||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese025002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|RsrchFeeInd|String||XmlElement()||
|+|BrkrgAmtInd|String||XmlElement()||
|+|StmpDtyInd|String||XmlElement()||
|+|AcrdIntrstInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValDt),validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Enum ISO20022.Sese025002.AutoBorrowing1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YBOR|Int32||XmlEnum("""YBOR""")|1|
||NBOR|Int32||XmlEnum("""NBOR""")|2|
||LAMI|Int32||XmlEnum("""LAMI""")|3|

---

## Value ISO20022.Sese025002.AutomaticBorrowing8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.BeneficialOwnership5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese025002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Enum ISO20022.Sese025002.BlockTrade1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BLCH|Int32||XmlEnum("""BLCH""")|1|
||BLPA|Int32||XmlEnum("""BLPA""")|2|

---

## Value ISO20022.Sese025002.BlockTrade5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.CashAccountIdentification6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,34}"""),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Value ISO20022.Sese025002.CashParties38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Intrmy|ISO20022.Sese025002.PartyIdentificationAndAccount178||XmlElement()||
|+|CdtrAgt|ISO20022.Sese025002.PartyIdentificationAndAccount178||XmlElement()||
|+|Cdtr|ISO20022.Sese025002.PartyIdentificationAndAccount177||XmlElement()||
|+|DbtrAgt|ISO20022.Sese025002.PartyIdentificationAndAccount178||XmlElement()||
|+|Dbtr|ISO20022.Sese025002.PartyIdentificationAndAccount177||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Intrmy),validElement(CdtrAgt),validElement(Cdtr),validElement(DbtrAgt),validElement(Dbtr))|

---

## Enum ISO20022.Sese025002.CashSettlementSystem2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETS|Int32||XmlEnum("""NETS""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Value ISO20022.Sese025002.CashSettlementSystem5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.CentralCounterPartyEligibility5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese025002.ClassificationType33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Sese025002.GenericIdentification86||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Value ISO20022.Sese025002.Counterparty16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Buyr|ISO20022.Sese025002.PartyIdentificationAndAccount206||XmlElement()||
|+|Sellr|ISO20022.Sese025002.PartyIdentificationAndAccount206||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Buyr),validElement(Sellr),validChoice(Buyr,Sellr))|

---

## Enum ISO20022.Sese025002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese025002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Sese025002.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese025002.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Type ISO20022.Sese025002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmTxConf|ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmTxConf))|

---

## Enum ISO20022.Sese025002.Eligibility1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROF|Int32||XmlEnum("""PROF""")|1|
||RETL|Int32||XmlEnum("""RETL""")|2|
||ELIG|Int32||XmlEnum("""ELIG""")|3|

---

## Enum ISO20022.Sese025002.EventFrequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||SEMI|Int32||XmlEnum("""SEMI""")|2|
||QUTR|Int32||XmlEnum("""QUTR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|

---

## Enum ISO20022.Sese025002.ExposureType12Code


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

## Value ISO20022.Sese025002.ExposureType24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.FinancialInstrumentAttributes122


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmAttrAddtlDtls|String||XmlElement()||
|+|UndrlygFinInstrmId|global::System.Collections.Generic.List<ISO20022.Sese025002.SecurityIdentification20>||XmlElement()||
|+|CtrctSz|ISO20022.Sese025002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Sese025002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|StrkPric|ISO20022.Sese025002.Price3||XmlElement()||
|+|ConvsPric|ISO20022.Sese025002.Price3||XmlElement()||
|+|SbcptPric|ISO20022.Sese025002.Price3||XmlElement()||
|+|ExrcPric|ISO20022.Sese025002.Price3||XmlElement()||
|+|MktOrIndctvPric|ISO20022.Sese025002.PriceType5Choice||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|PoolNb|ISO20022.Sese025002.GenericIdentification39||XmlElement()||
|+|CpnAttchdNb|ISO20022.Sese025002.Number23Choice||XmlElement()||
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
|+|OptnTp|ISO20022.Sese025002.OptionType7Choice||XmlElement()||
|+|OptnStyle|ISO20022.Sese025002.OptionStyle9Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Sese025002.ClassificationType33Choice||XmlElement()||
|+|VarblRateChngFrqcy|ISO20022.Sese025002.Frequency27Choice||XmlElement()||
|+|PmtSts|ISO20022.Sese025002.SecuritiesPaymentStatus6Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Sese025002.Frequency27Choice||XmlElement()||
|+|RegnForm|ISO20022.Sese025002.FormOfSecurity7Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Sese025002.InterestComputationMethodFormat5Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Sese025002.MarketIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FinInstrmAttrAddtlDtls""",FinInstrmAttrAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validList("""UndrlygFinInstrmId""",UndrlygFinInstrmId),validElement(UndrlygFinInstrmId),validElement(CtrctSz),validElement(MinNmnlQty),validElement(StrkPric),validElement(ConvsPric),validElement(SbcptPric),validElement(ExrcPric),validElement(MktOrIndctvPric),validElement(PoolNb),validElement(CpnAttchdNb),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnTp),validElement(OptnStyle),validElement(ClssfctnTp),validElement(VarblRateChngFrqcy),validElement(PmtSts),validElement(PmtFrqcy),validElement(RegnForm),validElement(DayCntBsis),validElement(PlcOfListg))|

---

## Value ISO20022.Sese025002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese025002.ForeignExchangeTerms23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Sese025002.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese025002.ForeignExchangeTerms27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Sese025002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese025002.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Sese025002.FormOfSecurity7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.Frequency27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.GenericIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese025002.GenericIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""([^/]+/)+([^/]+)\|([^/]*)"""),validPattern("""Id""",Id,"""([^/]+/)+([^/]+)\|([^/]*)"""))|

---

## Value ISO20022.Sese025002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese025002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese025002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Sese025002.GenericIdentification86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese025002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.IdentificationType44Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese025002.InterestComputationMethod2Code


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

## Value ISO20022.Sese025002.InterestComputationMethodFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.InvestorCapacity5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.LetterOfGuarantee5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese025002.Linkages50


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmTxId|String||XmlElement()||
|+|PrcgPos|ISO20022.Sese025002.ProcessingPosition23Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SctiesSttlmTxId""",SctiesSttlmTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(PrcgPos))|

---

## Enum ISO20022.Sese025002.MarketClientSide1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MAKT|Int32||XmlEnum("""MAKT""")|1|
||CLNT|Int32||XmlEnum("""CLNT""")|2|

---

## Value ISO20022.Sese025002.MarketClientSide7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.MarketIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese025002.MarketIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese025002.MarketIdentification90


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese025002.MarketType16Choice||XmlElement()||
|+|Id|ISO20022.Sese025002.MarketIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Sese025002.MarketType16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese025002.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Value ISO20022.Sese025002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Sese025002.NettingEligibility5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese025002.Number23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|ISO20022.Sese025002.GenericIdentification18||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lng),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Enum ISO20022.Sese025002.OpeningClosing1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEP|Int32||XmlEnum("""OPEP""")|1|
||CLOP|Int32||XmlEnum("""CLOP""")|2|

---

## Value ISO20022.Sese025002.OpeningClosing4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese025002.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Sese025002.OptionStyle9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese025002.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Sese025002.OptionType7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.OriginalAndCurrentQuantities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Sese025002.OriginatorRole2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAGT|Int32||XmlEnum("""TAGT""")|1|
||INVE|Int32||XmlEnum("""INVE""")|2|
||MKTM|Int32||XmlEnum("""MKTM""")|3|
||RMKT|Int32||XmlEnum("""RMKT""")|4|
||MLTF|Int32||XmlEnum("""MLTF""")|5|
||SINT|Int32||XmlEnum("""SINT""")|6|

---

## Value ISO20022.Sese025002.OtherAmounts44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsrchFee|ISO20022.Sese025002.AmountAndDirection44||XmlElement()||
|+|CollMntrAmt|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|BookVal|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|AcrdCptlstnAmt|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|CsmptnTax|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|NetGnLoss|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|WhldgTax|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|ValAddedTax|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|TxTax|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|TrfTax|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|StockXchgTax|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|StmpDty|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|SpclCncssn|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|ShppgAmt|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|RgltryAmt|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|Othr|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|Mrgn|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|LclBrkrComssn|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|LclTaxCtrySpcfc|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|LclTax|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|PmtLevyTax|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|IsseDscntAllwnc|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|ExctgBrkrAmt|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|TradAmt|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|CtryNtlFdrlTax|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|ChrgsFees|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Sese025002.AmountAndDirection58||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsrchFee),validElement(CollMntrAmt),validElement(BookVal),validElement(AcrdCptlstnAmt),validElement(CsmptnTax),validElement(NetGnLoss),validElement(WhldgTax),validElement(ValAddedTax),validElement(TxTax),validElement(TrfTax),validElement(StockXchgTax),validElement(StmpDty),validElement(SpclCncssn),validElement(ShppgAmt),validElement(RgltryAmt),validElement(Othr),validElement(Mrgn),validElement(LclBrkrComssn),validElement(LclTaxCtrySpcfc),validElement(LclTax),validElement(PmtLevyTax),validElement(IsseDscntAllwnc),validElement(ExctgBrkrAmt),validElement(TradAmt),validElement(CtryNtlFdrlTax),validElement(ChrgsFees),validElement(AcrdIntrstAmt))|

---

## Value ISO20022.Sese025002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese025002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Sese025002.OtherParties44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Brkr|ISO20022.Sese025002.PartyIdentificationAndAccount209||XmlElement()||
|+|TrptyAgt|ISO20022.Sese025002.PartyIdentificationAndAccount209||XmlElement()||
|+|TradRgltr|ISO20022.Sese025002.PartyIdentificationAndAccount181||XmlElement()||
|+|StockXchg|ISO20022.Sese025002.PartyIdentificationAndAccount181||XmlElement()||
|+|QlfdFrgnIntrmy|ISO20022.Sese025002.PartyIdentificationAndAccount209||XmlElement()||
|+|Invstr|global::System.Collections.Generic.List<ISO20022.Sese025002.PartyIdentificationAndAccount208>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Brkr),validElement(TrptyAgt),validElement(TradRgltr),validElement(StockXchg),validElement(QlfdFrgnIntrmy),validList("""Invstr""",Invstr),validElement(Invstr))|

---

## Enum ISO20022.Sese025002.OwnershipLegalRestrictions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSTR|Int32||XmlEnum("""RSTR""")|1|
||NRST|Int32||XmlEnum("""NRST""")|2|
||A144|Int32||XmlEnum("""A144""")|3|

---

## Enum ISO20022.Sese025002.PartialSettlement2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARC|Int32||XmlEnum("""PARC""")|1|
||PAIN|Int32||XmlEnum("""PAIN""")|2|

---

## Value ISO20022.Sese025002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese025002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese025002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese025002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese025002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese025002.PartyIdentification145Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese025002.NameAndAddress12||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese025002.PartyIdentification147Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese025002.GenericIdentification84||XmlElement()||
|+|NmAndAdr|ISO20022.Sese025002.NameAndAddress12||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validElement(NmAndAdr),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,NmAndAdr,BICFI))|

---

## Value ISO20022.Sese025002.PartyIdentification156


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese025002.PartyIdentification136Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese025002.PartyIdentification157


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese025002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese025002.PartyIdentification162


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese025002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese025002.DateAndDateTime2Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese025002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese025002.PartyIdentification145Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(PrcgDt),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese025002.PartyIdentificationAndAccount177


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese025002.PartyTextInformation4||XmlElement()||
|+|TaxAcct|ISO20022.Sese025002.CashAccountIdentification6Choice||XmlElement()||
|+|ComssnAcct|ISO20022.Sese025002.CashAccountIdentification6Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Sese025002.CashAccountIdentification6Choice||XmlElement()||
|+|CshAcct|ISO20022.Sese025002.CashAccountIdentification6Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese025002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese025002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(TaxAcct),validElement(ComssnAcct),validElement(ChrgsAcct),validElement(CshAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese025002.PartyIdentificationAndAccount178


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese025002.PartyTextInformation4||XmlElement()||
|+|TaxAcct|ISO20022.Sese025002.CashAccountIdentification6Choice||XmlElement()||
|+|ComssnAcct|ISO20022.Sese025002.CashAccountIdentification6Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Sese025002.CashAccountIdentification6Choice||XmlElement()||
|+|CshAcct|ISO20022.Sese025002.CashAccountIdentification6Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese025002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese025002.PartyIdentification147Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(TaxAcct),validElement(ComssnAcct),validElement(ChrgsAcct),validElement(CshAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese025002.PartyIdentificationAndAccount181


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese025002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|AltrnId|ISO20022.Sese025002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese025002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese025002.PartyIdentificationAndAccount206


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese025002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese025002.DateAndDateTime2Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese025002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese025002.SecuritiesAccount30||XmlElement()||
|+|AltrnId|ISO20022.Sese025002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese025002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(PrcgDt),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese025002.PartyIdentificationAndAccount208


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese025002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|Ntlty|String||XmlElement()||
|+|AltrnId|ISO20022.Sese025002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese025002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""BlckChainAdrOrWllt""",BlckChainAdrOrWllt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""SfkpgAcct""",SfkpgAcct,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validPattern("""Ntlty""",Ntlty,"""[A-Z]{2,2}"""),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese025002.PartyIdentificationAndAccount209


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese025002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|AltrnId|ISO20022.Sese025002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese025002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""BlckChainAdrOrWllt""",BlckChainAdrOrWllt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""SfkpgAcct""",SfkpgAcct,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese025002.PartyTextInformation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RegnDtls""",RegnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""PtyCtctDtls""",PtyCtctDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""DclrtnDtls""",DclrtnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Value ISO20022.Sese025002.PartyTextInformation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PtyCtctDtls""",PtyCtctDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""DclrtnDtls""",DclrtnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Value ISO20022.Sese025002.PlaceOfClearingIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese025002.PlaceOfTradeIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|MktTpAndId|ISO20022.Sese025002.MarketIdentification90||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(MktTpAndId))|

---

## Enum ISO20022.Sese025002.PreConfirmation1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRSE|Int32||XmlEnum("""PRSE""")|1|
||PRCA|Int32||XmlEnum("""PRCA""")|2|

---

## Value ISO20022.Sese025002.Price11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Sese025002.PriceRateOrAmount1Choice||XmlElement()||
|+|Tp|ISO20022.Sese025002.YieldedOrValueType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Sese025002.Price3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Sese025002.PriceRateOrAmount1Choice||XmlElement()||
|+|Tp|ISO20022.Sese025002.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Sese025002.PriceRateOrAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Sese025002.PriceType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indctv|ISO20022.Sese025002.Price3||XmlElement()||
|+|Mkt|ISO20022.Sese025002.Price3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indctv),validElement(Mkt),validChoice(Indctv,Mkt))|

---

## Enum ISO20022.Sese025002.PriceValueType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NEGA|Int32||XmlEnum("""NEGA""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||PARV|Int32||XmlEnum("""PARV""")|3|
||DISC|Int32||XmlEnum("""DISC""")|4|

---

## Enum ISO20022.Sese025002.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Sese025002.PriorityNumeric5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Nmrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""Nmrc""",Nmrc,"""[0-9]{4}"""),validChoice(Prtry,Nmrc))|

---

## Value ISO20022.Sese025002.ProcessingPosition23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese025002.ProcessingPosition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|

---

## Value ISO20022.Sese025002.Quantity54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Sese025002.OriginalAndCurrentQuantities4||XmlElement()||
|+|Qty|ISO20022.Sese025002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Sese025002.QuantityAndAccount108


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgPlc|ISO20022.Sese025002.SafeKeepingPlace4||XmlElement()||
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Sese025002.QuantityBreakdown75>||XmlElement()||
|+|CshAcct|ISO20022.Sese025002.CashAccountIdentification6Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese025002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese025002.SecuritiesAccount30||XmlElement()||
|+|AcctOwnr|ISO20022.Sese025002.PartyIdentification156||XmlElement()||
|+|DnmtnChc|String||XmlElement()||
|+|RmngToBeSttldAmt|ISO20022.Sese025002.AmountAndDirection57||XmlElement()||
|+|PrevslySttldAmt|ISO20022.Sese025002.AmountAndDirection57||XmlElement()||
|+|RmngToBeSttldQty|ISO20022.Sese025002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|PrevslySttldQty|ISO20022.Sese025002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|SttldQty|ISO20022.Sese025002.Quantity54Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SfkpgPlc),validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(CshAcct),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validPattern("""DnmtnChc""",DnmtnChc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(RmngToBeSttldAmt),validElement(PrevslySttldAmt),validElement(RmngToBeSttldQty),validElement(PrevslySttldQty),validElement(SttldQty))|

---

## Value ISO20022.Sese025002.QuantityBreakdown75


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TpOfPric|ISO20022.Sese025002.TypeOfPrice32Choice||XmlElement()||
|+|LotPric|ISO20022.Sese025002.Price3||XmlElement()||
|+|LotDtTm|ISO20022.Sese025002.DateAndDateTime2Choice||XmlElement()||
|+|SctiesSubBalTp|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|LotQty|ISO20022.Sese025002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|LotNb|ISO20022.Sese025002.GenericIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TpOfPric),validElement(LotPric),validElement(LotDtTm),validElement(SctiesSubBalTp),validElement(LotQty),validElement(LotNb))|

---

## Enum ISO20022.Sese025002.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Sese025002.Registration11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese025002.Registration1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YREG|Int32||XmlEnum("""YREG""")|1|
||NREG|Int32||XmlEnum("""NREG""")|2|

---

## Value ISO20022.Sese025002.RegistrationParameters7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertNb|global::System.Collections.Generic.List<ISO20022.Sese025002.SecuritiesCertificate5>||XmlElement()||
|+|RegarAcct|String||XmlElement()||
|+|CertfctnDtTm|ISO20022.Sese025002.DateAndDateTime2Choice||XmlElement()||
|+|CertfctnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CertNb""",CertNb),validElement(CertNb),validPattern("""RegarAcct""",RegarAcct,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validElement(CertfctnDtTm),validPattern("""CertfctnId""",CertfctnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Sese025002.Reporting2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DEFR|Int32||XmlEnum("""DEFR""")|1|
||REGU|Int32||XmlEnum("""REGU""")|2|
||STEX|Int32||XmlEnum("""STEX""")|3|

---

## Value ISO20022.Sese025002.Reporting9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.RepurchaseType24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese025002.RepurchaseType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WTHD|Int32||XmlEnum("""WTHD""")|1|
||TOPU|Int32||XmlEnum("""TOPU""")|2|
||CADJ|Int32||XmlEnum("""CADJ""")|3|
||ROLP|Int32||XmlEnum("""ROLP""")|4|
||CALL|Int32||XmlEnum("""CALL""")|5|
||RATE|Int32||XmlEnum("""RATE""")|6|
||PADJ|Int32||XmlEnum("""PADJ""")|7|
||PAIR|Int32||XmlEnum("""PAIR""")|8|

---

## Value ISO20022.Sese025002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese025002.RestrictedFINActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese025002.Restriction6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.SafeKeepingPlace4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Sese025002.SafekeepingPlaceFormat39Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Sese025002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Sese025002.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Sese025002.SafekeepingPlaceFormat39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Sese025002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Sese025002.SafekeepingPlaceTypeAndText15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Sese025002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese025002.SafekeepingPlaceTypeAndText15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese025002.SecuritiesAccount30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Sese025002.SecuritiesCertificate5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Nb""",Nb,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Sese025002.SecuritiesPaymentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NILL|Int32||XmlEnum("""NILL""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Sese025002.SecuritiesPaymentStatus6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.SecuritiesRTGS5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Aspect ISO20022.Sese025002.SecuritiesSettlementTransactionConfirmation002V11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese025002.SupplementaryData1>||XmlElement()||
|+|AddtlPhysOrRegnDtls|ISO20022.Sese025002.RegistrationParameters7||XmlElement()||
|+|OthrBizPties|ISO20022.Sese025002.OtherParties44||XmlElement()||
|+|OthrAmts|ISO20022.Sese025002.OtherAmounts44||XmlElement()||
|+|SttldAmt|ISO20022.Sese025002.AmountAndDirection96||XmlElement()||
|+|CshPties|ISO20022.Sese025002.CashParties38||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese025002.SettlementParties105||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese025002.SettlementParties105||XmlElement()||
|+|StgSttlmInstrDtls|ISO20022.Sese025002.StandingSettlementInstruction19||XmlElement()||
|+|SttlmParams|ISO20022.Sese025002.SettlementDetails211||XmlElement()||
|+|QtyAndAcctDtls|ISO20022.Sese025002.QuantityAndAccount108||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Sese025002.FinancialInstrumentAttributes122||XmlElement()||
|+|FinInstrmId|ISO20022.Sese025002.SecurityIdentification20||XmlElement()||
|+|TradDtls|ISO20022.Sese025002.SecuritiesTradeDetails128||XmlElement()||
|+|AddtlParams|ISO20022.Sese025002.AdditionalParameters31||XmlElement()||
|+|Lnkgs|ISO20022.Sese025002.Linkages50||XmlElement()||
|+|TxIdDtls|ISO20022.Sese025002.SettlementTypeAndIdentification28||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AddtlPhysOrRegnDtls),validElement(OthrBizPties),validElement(OthrAmts),validElement(SttldAmt),validElement(CshPties),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(StgSttlmInstrDtls),validElement(SttlmParams),validElement(QtyAndAcctDtls),validElement(FinInstrmAttrbts),validElement(FinInstrmId),validElement(TradDtls),validElement(AddtlParams),validElement(Lnkgs),validElement(TxIdDtls))|

---

## Value ISO20022.Sese025002.SecuritiesTradeDetails128


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmInstrPrcgAddtlDtls|String||XmlElement()||
|+|FxAddtlDtls|String||XmlElement()||
|+|TpOfPric|ISO20022.Sese025002.TypeOfPrice32Choice||XmlElement()||
|+|TradOrgtrRole|ISO20022.Sese025002.TradeOriginator4Choice||XmlElement()||
|+|InvstrCpcty|ISO20022.Sese025002.InvestorCapacity5Choice||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Sese025002.TradeTransactionCondition6Choice>||XmlElement()||
|+|Rptg|global::System.Collections.Generic.List<ISO20022.Sese025002.Reporting9Choice>||XmlElement()||
|+|OpngClsg|ISO20022.Sese025002.OpeningClosing4Choice||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|DealPric|ISO20022.Sese025002.Price11||XmlElement()||
|+|FctvSttlmDt|ISO20022.Sese025002.SettlementDate22Choice||XmlElement()||
|+|SttlmDt|ISO20022.Sese025002.SettlementDate20Choice||XmlElement()||
|+|TradDt|ISO20022.Sese025002.TradeDate9Choice||XmlElement()||
|+|PlcOfClr|ISO20022.Sese025002.PlaceOfClearingIdentification2||XmlElement()||
|+|PlcOfTrad|ISO20022.Sese025002.PlaceOfTradeIdentification2||XmlElement()||
|+|CollTxId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TradId|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SttlmInstrPrcgAddtlDtls""",SttlmInstrPrcgAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""FxAddtlDtls""",FxAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validElement(TpOfPric),validElement(TradOrgtrRole),validElement(InvstrCpcty),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond),validList("""Rptg""",Rptg),validElement(Rptg),validElement(OpngClsg),validElement(DealPric),validElement(FctvSttlmDt),validElement(SttlmDt),validElement(TradDt),validElement(PlcOfClr),validElement(PlcOfTrad),validPattern("""CollTxId""",CollTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""TradId""",TradId,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,52}"""))|

---

## Enum ISO20022.Sese025002.SecuritiesTransactionType25Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REBL|Int32||XmlEnum("""REBL""")|1|
||ETFT|Int32||XmlEnum("""ETFT""")|2|
||SWIT|Int32||XmlEnum("""SWIT""")|3|
||SWIF|Int32||XmlEnum("""SWIF""")|4|
||AUTO|Int32||XmlEnum("""AUTO""")|5|
||CORP|Int32||XmlEnum("""CORP""")|6|
||CLAI|Int32||XmlEnum("""CLAI""")|7|
||TURN|Int32||XmlEnum("""TURN""")|8|
||TRVO|Int32||XmlEnum("""TRVO""")|9|
||TRPO|Int32||XmlEnum("""TRPO""")|10|
||TRAD|Int32||XmlEnum("""TRAD""")|11|
||TBAC|Int32||XmlEnum("""TBAC""")|12|
||SYND|Int32||XmlEnum("""SYND""")|13|
||SUBS|Int32||XmlEnum("""SUBS""")|14|
||SLRE|Int32||XmlEnum("""SLRE""")|15|
||SECL|Int32||XmlEnum("""SECL""")|16|
||SECB|Int32||XmlEnum("""SECB""")|17|
||SBRE|Int32||XmlEnum("""SBRE""")|18|
||SBBK|Int32||XmlEnum("""SBBK""")|19|
||RVPO|Int32||XmlEnum("""RVPO""")|20|
||RODE|Int32||XmlEnum("""RODE""")|21|
||REPU|Int32||XmlEnum("""REPU""")|22|
||RELE|Int32||XmlEnum("""RELE""")|23|
||REDM|Int32||XmlEnum("""REDM""")|24|
||REDI|Int32||XmlEnum("""REDI""")|25|
||REAL|Int32||XmlEnum("""REAL""")|26|
||PORT|Int32||XmlEnum("""PORT""")|27|
||PLAC|Int32||XmlEnum("""PLAC""")|28|
||PAIR|Int32||XmlEnum("""PAIR""")|29|
||OWNI|Int32||XmlEnum("""OWNI""")|30|
||OWNE|Int32||XmlEnum("""OWNE""")|31|
||NSYN|Int32||XmlEnum("""NSYN""")|32|
||NETT|Int32||XmlEnum("""NETT""")|33|
||MKUP|Int32||XmlEnum("""MKUP""")|34|
||MKDW|Int32||XmlEnum("""MKDW""")|35|
||ISSU|Int32||XmlEnum("""ISSU""")|36|
||INSP|Int32||XmlEnum("""INSP""")|37|
||FCTA|Int32||XmlEnum("""FCTA""")|38|
||CONV|Int32||XmlEnum("""CONV""")|39|
||COLO|Int32||XmlEnum("""COLO""")|40|
||COLI|Int32||XmlEnum("""COLI""")|41|
||CNCB|Int32||XmlEnum("""CNCB""")|42|
||BYIY|Int32||XmlEnum("""BYIY""")|43|
||BSBK|Int32||XmlEnum("""BSBK""")|44|

---

## Value ISO20022.Sese025002.SecuritiesTransactionType51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese025002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese025002.SettlementDate20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese025002.SettlementDateCode9Choice||XmlElement()||
|+|Dt|ISO20022.Sese025002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese025002.SettlementDate22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Dt|ISO20022.Sese025002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Sese025002.SettlementDate4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WISS|Int32||XmlEnum("""WISS""")|1|

---

## Value ISO20022.Sese025002.SettlementDateCode9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.SettlementDetails211


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshSubBalTp|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|SctiesSubBalTp|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|ElgblForColl|String||XmlElement()||
|+|LttrOfGrnt|ISO20022.Sese025002.LetterOfGuarantee5Choice||XmlElement()||
|+|AutomtcBrrwg|ISO20022.Sese025002.AutomaticBorrowing8Choice||XmlElement()||
|+|StmpDtyTaxBsis|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|TaxCpcty|ISO20022.Sese025002.TaxCapacityParty5Choice||XmlElement()||
|+|SttlmSysMtd|ISO20022.Sese025002.SettlementSystemMethod5Choice||XmlElement()||
|+|SttlgCpcty|ISO20022.Sese025002.SettlingCapacity8Choice||XmlElement()||
|+|SctiesRTGS|ISO20022.Sese025002.SecuritiesRTGS5Choice||XmlElement()||
|+|LglRstrctns|ISO20022.Sese025002.Restriction6Choice||XmlElement()||
|+|RpTp|ISO20022.Sese025002.RepurchaseType24Choice||XmlElement()||
|+|Regn|ISO20022.Sese025002.Registration11Choice||XmlElement()||
|+|NetgElgblty|ISO20022.Sese025002.NettingEligibility5Choice||XmlElement()||
|+|MktClntSd|ISO20022.Sese025002.MarketClientSide7Choice||XmlElement()||
|+|XpsrTp|ISO20022.Sese025002.ExposureType24Choice||XmlElement()||
|+|CshClrSys|ISO20022.Sese025002.CashSettlementSystem5Choice||XmlElement()||
|+|CCPElgblty|ISO20022.Sese025002.CentralCounterPartyEligibility5Choice||XmlElement()||
|+|BlckTrad|ISO20022.Sese025002.BlockTrade5Choice||XmlElement()||
|+|BnfclOwnrsh|ISO20022.Sese025002.BeneficialOwnership5Choice||XmlElement()||
|+|PrtlSttlmInd|String||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese025002.SettlementTransactionCondition37Choice>||XmlElement()||
|+|SctiesTxTp|ISO20022.Sese025002.SecuritiesTransactionType51Choice||XmlElement()||
|+|Prty|ISO20022.Sese025002.PriorityNumeric5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshSubBalTp),validElement(SctiesSubBalTp),validElement(LttrOfGrnt),validElement(AutomtcBrrwg),validElement(StmpDtyTaxBsis),validElement(TaxCpcty),validElement(SttlmSysMtd),validElement(SttlgCpcty),validElement(SctiesRTGS),validElement(LglRstrctns),validElement(RpTp),validElement(Regn),validElement(NetgElgblty),validElement(MktClntSd),validElement(XpsrTp),validElement(CshClrSys),validElement(CCPElgblty),validElement(BlckTrad),validElement(BnfclOwnrsh),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validElement(SctiesTxTp),validElement(Prty))|

---

## Value ISO20022.Sese025002.SettlementParties105


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese025002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty4|ISO20022.Sese025002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty3|ISO20022.Sese025002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty2|ISO20022.Sese025002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty1|ISO20022.Sese025002.PartyIdentificationAndAccount206||XmlElement()||
|+|Dpstry|ISO20022.Sese025002.PartyIdentification162||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Sese025002.SettlementStandingInstructionDatabase1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VEND|Int32||XmlEnum("""VEND""")|1|
||BRKR|Int32||XmlEnum("""BRKR""")|2|
||INTE|Int32||XmlEnum("""INTE""")|3|

---

## Value ISO20022.Sese025002.SettlementStandingInstructionDatabase5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese025002.SettlementSystemMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSET|Int32||XmlEnum("""YSET""")|1|
||NSET|Int32||XmlEnum("""NSET""")|2|

---

## Value ISO20022.Sese025002.SettlementSystemMethod5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese025002.SettlementTransactionCondition12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BPSS|Int32||XmlEnum("""BPSS""")|1|
||INTS|Int32||XmlEnum("""INTS""")|2|
||UNEX|Int32||XmlEnum("""UNEX""")|3|
||TRIP|Int32||XmlEnum("""TRIP""")|4|
||TRAN|Int32||XmlEnum("""TRAN""")|5|
||SPST|Int32||XmlEnum("""SPST""")|6|
||SPDL|Int32||XmlEnum("""SPDL""")|7|
||SHOR|Int32||XmlEnum("""SHOR""")|8|
||RESI|Int32||XmlEnum("""RESI""")|9|
||RPTO|Int32||XmlEnum("""RPTO""")|10|
||RHYP|Int32||XmlEnum("""RHYP""")|11|
||PHYS|Int32||XmlEnum("""PHYS""")|12|
||PENS|Int32||XmlEnum("""PENS""")|13|
||NACT|Int32||XmlEnum("""NACT""")|14|
||NOMC|Int32||XmlEnum("""NOMC""")|15|
||KNOC|Int32||XmlEnum("""KNOC""")|16|
||FRCL|Int32||XmlEnum("""FRCL""")|17|
||EXPI|Int32||XmlEnum("""EXPI""")|18|
||EXER|Int32||XmlEnum("""EXER""")|19|
||DRAW|Int32||XmlEnum("""DRAW""")|20|
||DIRT|Int32||XmlEnum("""DIRT""")|21|
||DLWM|Int32||XmlEnum("""DLWM""")|22|
||CLEN|Int32||XmlEnum("""CLEN""")|23|
||BUTC|Int32||XmlEnum("""BUTC""")|24|
||ASGN|Int32||XmlEnum("""ASGN""")|25|
||ADEA|Int32||XmlEnum("""ADEA""")|26|

---

## Value ISO20022.Sese025002.SettlementTransactionCondition37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese025002.SettlementTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARQ|Int32||XmlEnum("""PARQ""")|1|
||PARC|Int32||XmlEnum("""PARC""")|2|
||NPAR|Int32||XmlEnum("""NPAR""")|3|
||PART|Int32||XmlEnum("""PART""")|4|

---

## Value ISO20022.Sese025002.SettlementTypeAndIdentification28


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

## Enum ISO20022.Sese025002.SettlingCapacity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RISP|Int32||XmlEnum("""RISP""")|1|
||SPRI|Int32||XmlEnum("""SPRI""")|2|
||CUST|Int32||XmlEnum("""CUST""")|3|
||SAGE|Int32||XmlEnum("""SAGE""")|4|

---

## Value ISO20022.Sese025002.SettlingCapacity8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.StandingSettlementInstruction19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrRcvgSttlmPties|ISO20022.Sese025002.SettlementParties105||XmlElement()||
|+|OthrDlvrgSttlmPties|ISO20022.Sese025002.SettlementParties105||XmlElement()||
|+|Vndr|ISO20022.Sese025002.PartyIdentification157||XmlElement()||
|+|CtrPty|ISO20022.Sese025002.Counterparty16Choice||XmlElement()||
|+|SttlmStgInstrDB|ISO20022.Sese025002.SettlementStandingInstructionDatabase5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrRcvgSttlmPties),validElement(OthrDlvrgSttlmPties),validElement(Vndr),validElement(CtrPty),validElement(SttlmStgInstrDB))|

---

## Value ISO20022.Sese025002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese025002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese025002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese025002.TaxCapacityParty5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese025002.TaxLiability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGEN|Int32||XmlEnum("""AGEN""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Sese025002.TradeDate9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese025002.TradeDateCode4Choice||XmlElement()||
|+|Dt|ISO20022.Sese025002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese025002.TradeDateCode4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.TradeOriginator4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese025002.TradeTransactionCondition4Code


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

## Value ISO20022.Sese025002.TradeTransactionCondition6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese025002.TypeOfIdentification1Code


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

## Enum ISO20022.Sese025002.TypeOfPrice14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AVER|Int32||XmlEnum("""AVER""")|1|

---

## Value ISO20022.Sese025002.TypeOfPrice32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese025002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese025002.YieldedOrValueType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValTp|String||XmlElement()||
|+|Yldd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(ValTp,Yldd))|

---

## Value ISO20022.Sese025002.YieldedOrValueType2Choice


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

