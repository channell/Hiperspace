# sese.038.001.10
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese038001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese038001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese038001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese038001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Sese038001.AffirmationStatus1Code {
        NAFI = 1
        AFFI = 2
    }
    class ISO20022.Sese038001.AffirmationStatus8Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.AffirmationStatus8Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.AlternatePartyIdentification7 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Sese038001.IdentificationType42Choice
    }
    ISO20022.Sese038001.AlternatePartyIdentification7 *-- ISO20022.Sese038001.IdentificationType42Choice
    class ISO20022.Sese038001.AmountAndDirection44 {
        + FXDtls  : ISO20022.Sese038001.ForeignExchangeTerms23
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese038001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese038001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Sese038001.AmountAndDirection44 *-- ISO20022.Sese038001.ForeignExchangeTerms23
    ISO20022.Sese038001.AmountAndDirection44 *-- ISO20022.Sese038001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese038001.AmountAndDirection44 *-- ISO20022.Sese038001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese038001.AmountAndDirection51 {
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese038001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese038001.ActiveCurrencyAndAmount
    }
    ISO20022.Sese038001.AmountAndDirection51 *-- ISO20022.Sese038001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese038001.AmountAndDirection51 *-- ISO20022.Sese038001.ActiveCurrencyAndAmount
    class ISO20022.Sese038001.AmountAndDirection95 {
        + ValDt  : ISO20022.Sese038001.DateAndDateTime2Choice
        + FXDtls  : ISO20022.Sese038001.ForeignExchangeTerms23
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese038001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese038001.ActiveCurrencyAndAmount
        + RsrchFeeInd  : String
        + BrkrgAmtInd  : String
        + StmpDtyInd  : String
        + AcrdIntrstInd  : String
    }
    ISO20022.Sese038001.AmountAndDirection95 *-- ISO20022.Sese038001.DateAndDateTime2Choice
    ISO20022.Sese038001.AmountAndDirection95 *-- ISO20022.Sese038001.ForeignExchangeTerms23
    ISO20022.Sese038001.AmountAndDirection95 *-- ISO20022.Sese038001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese038001.AmountAndDirection95 *-- ISO20022.Sese038001.ActiveCurrencyAndAmount
    class ISO20022.Sese038001.BeneficialOwnership4Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese038001.BeneficialOwnership4Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Sese038001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese038001.BlockChainAddressWallet3 *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.CashAccountIdentification5Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Sese038001.CashAccountIdentification9Choice {
        + Prtry  : String
        + BlckChainCshWllt  : ISO20022.Sese038001.BlockChainAddressWallet3
        + IBAN  : String
    }
    ISO20022.Sese038001.CashAccountIdentification9Choice *-- ISO20022.Sese038001.BlockChainAddressWallet3
    class ISO20022.Sese038001.CashParties41 {
        + Intrmy  : ISO20022.Sese038001.PartyIdentificationAndAccount224
        + CdtrAgt  : ISO20022.Sese038001.PartyIdentificationAndAccount224
        + Cdtr  : ISO20022.Sese038001.PartyIdentificationAndAccount223
        + DbtrAgt  : ISO20022.Sese038001.PartyIdentificationAndAccount224
        + Dbtr  : ISO20022.Sese038001.PartyIdentificationAndAccount223
    }
    ISO20022.Sese038001.CashParties41 *-- ISO20022.Sese038001.PartyIdentificationAndAccount224
    ISO20022.Sese038001.CashParties41 *-- ISO20022.Sese038001.PartyIdentificationAndAccount224
    ISO20022.Sese038001.CashParties41 *-- ISO20022.Sese038001.PartyIdentificationAndAccount223
    ISO20022.Sese038001.CashParties41 *-- ISO20022.Sese038001.PartyIdentificationAndAccount224
    ISO20022.Sese038001.CashParties41 *-- ISO20022.Sese038001.PartyIdentificationAndAccount223
    class ISO20022.Sese038001.CashSettlementSystem2Code {
        NETS = 1
        GROS = 2
    }
    class ISO20022.Sese038001.CashSettlementSystem4Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.CashSettlementSystem4Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.CentralCounterPartyEligibility4Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese038001.CentralCounterPartyEligibility4Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.ClassificationType32Choice {
        + AltrnClssfctn  : ISO20022.Sese038001.GenericIdentification36
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Sese038001.ClassificationType32Choice *-- ISO20022.Sese038001.GenericIdentification36
    class ISO20022.Sese038001.Counterparty15Choice {
        + Buyr  : ISO20022.Sese038001.PartyIdentificationAndAccount196
        + Sellr  : ISO20022.Sese038001.PartyIdentificationAndAccount196
    }
    ISO20022.Sese038001.Counterparty15Choice *-- ISO20022.Sese038001.PartyIdentificationAndAccount196
    ISO20022.Sese038001.Counterparty15Choice *-- ISO20022.Sese038001.PartyIdentificationAndAccount196
    class ISO20022.Sese038001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese038001.CurrencyToBuyOrSell1Choice {
        + CcyToSell  : String
        + CcyToBuy  : String
    }
    class ISO20022.Sese038001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese038001.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese038001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese038001.DeliveryReturn1Code {
        PARD = 1
        DUEB = 2
        SAFE = 3
        PART = 4
        DMON = 5
        DQUA = 6
        UNRE = 7
    }
    class ISO20022.Sese038001.DeliveryReturn3Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.DeliveryReturn3Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.DocumentNumber5Choice {
        + PrtryNb  : ISO20022.Sese038001.GenericIdentification36
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Sese038001.DocumentNumber5Choice *-- ISO20022.Sese038001.GenericIdentification36
    class ISO20022.Sese038001.Eligibility1Code {
        PROF = 1
        RETL = 2
        ELIG = 3
    }
    class ISO20022.Sese038001.EventFrequency3Code {
        WEEK = 1
        SEMI = 2
        QUTR = 3
        MNTH = 4
        YEAR = 5
    }
    class ISO20022.Sese038001.ExposureType15Code {
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
    class ISO20022.Sese038001.ExposureType25Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.ExposureType25Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.FXStandingInstruction4Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese038001.FXStandingInstruction4Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.FinancialInstrumentAttributes111 {
        + FinInstrmAttrAddtlDtls  : String
        + UndrlygFinInstrmId  : global::System.Collections.Generic.List~ISO20022.Sese038001.SecurityIdentification19~
        + CtrctSz  : ISO20022.Sese038001.FinancialInstrumentQuantity33Choice
        + MinNmnlQty  : ISO20022.Sese038001.FinancialInstrumentQuantity33Choice
        + StrkPric  : ISO20022.Sese038001.Price7
        + ConvsPric  : ISO20022.Sese038001.Price7
        + SbcptPric  : ISO20022.Sese038001.Price7
        + ExrcPric  : ISO20022.Sese038001.Price7
        + MktOrIndctvPric  : ISO20022.Sese038001.PriceType4Choice
        + PutblInd  : String
        + CllblInd  : String
        + VarblRateInd  : String
        + PoolNb  : ISO20022.Sese038001.GenericIdentification37
        + CpnAttchdNb  : ISO20022.Sese038001.Number22Choice
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
        + OptnTp  : ISO20022.Sese038001.OptionType6Choice
        + OptnStyle  : ISO20022.Sese038001.OptionStyle8Choice
        + ClssfctnTp  : ISO20022.Sese038001.ClassificationType32Choice
        + VarblRateChngFrqcy  : ISO20022.Sese038001.Frequency23Choice
        + PmtSts  : ISO20022.Sese038001.SecuritiesPaymentStatus5Choice
        + PmtFrqcy  : ISO20022.Sese038001.Frequency23Choice
        + RegnForm  : ISO20022.Sese038001.FormOfSecurity6Choice
        + DayCntBsis  : ISO20022.Sese038001.InterestComputationMethodFormat4Choice
        + PlcOfListg  : ISO20022.Sese038001.MarketIdentification3Choice
    }
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.SecurityIdentification19
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.FinancialInstrumentQuantity33Choice
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.FinancialInstrumentQuantity33Choice
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.Price7
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.Price7
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.Price7
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.Price7
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.PriceType4Choice
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.GenericIdentification37
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.Number22Choice
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.OptionType6Choice
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.OptionStyle8Choice
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.ClassificationType32Choice
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.Frequency23Choice
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.SecuritiesPaymentStatus5Choice
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.Frequency23Choice
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.FormOfSecurity6Choice
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.InterestComputationMethodFormat4Choice
    ISO20022.Sese038001.FinancialInstrumentAttributes111 *-- ISO20022.Sese038001.MarketIdentification3Choice
    class ISO20022.Sese038001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese038001.ForeignExchangeTerms23 {
        + RsltgAmt  : ISO20022.Sese038001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Sese038001.ForeignExchangeTerms23 *-- ISO20022.Sese038001.ActiveCurrencyAndAmount
    class ISO20022.Sese038001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Sese038001.FormOfSecurity6Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.FormOfSecurity6Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.Frequency23Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.Frequency23Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Sese038001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese038001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese038001.GenericIdentification37 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese038001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Sese038001.GenericIdentification30
    }
    ISO20022.Sese038001.GenericIdentification78 *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese038001.IdentificationType42Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.IdentificationType42Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.InterestComputationMethod2Code {
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
    class ISO20022.Sese038001.InterestComputationMethodFormat4Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.InterestComputationMethodFormat4Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.InvestorCapacity4Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.InvestorCapacity4Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.LetterOfGuarantee4Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese038001.LetterOfGuarantee4Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.Linkages40 {
        + Ref  : ISO20022.Sese038001.References47Choice
    }
    ISO20022.Sese038001.Linkages40 *-- ISO20022.Sese038001.References47Choice
    class ISO20022.Sese038001.Linkages63 {
        + LkdQty  : ISO20022.Sese038001.PairedOrTurnedQuantity5Choice
        + Ref  : ISO20022.Sese038001.References47Choice
        + MsgNb  : ISO20022.Sese038001.DocumentNumber5Choice
        + PrcgPos  : ISO20022.Sese038001.ProcessingPosition7Choice
    }
    ISO20022.Sese038001.Linkages63 *-- ISO20022.Sese038001.PairedOrTurnedQuantity5Choice
    ISO20022.Sese038001.Linkages63 *-- ISO20022.Sese038001.References47Choice
    ISO20022.Sese038001.Linkages63 *-- ISO20022.Sese038001.DocumentNumber5Choice
    ISO20022.Sese038001.Linkages63 *-- ISO20022.Sese038001.ProcessingPosition7Choice
    class ISO20022.Sese038001.MarketClientSide1Code {
        MAKT = 1
        CLNT = 2
    }
    class ISO20022.Sese038001.MarketClientSide6Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.MarketClientSide6Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.MarketIdentification1Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese038001.MarketIdentification3Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese038001.MarketIdentification84 {
        + Tp  : ISO20022.Sese038001.MarketType8Choice
        + Id  : ISO20022.Sese038001.MarketIdentification1Choice
    }
    ISO20022.Sese038001.MarketIdentification84 *-- ISO20022.Sese038001.MarketType8Choice
    ISO20022.Sese038001.MarketIdentification84 *-- ISO20022.Sese038001.MarketIdentification1Choice
    class ISO20022.Sese038001.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Sese038001.MarketType8Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.MarketType8Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.MatchingStatus1Code {
        NMAT = 1
        MACH = 2
    }
    class ISO20022.Sese038001.MatchingStatus27Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.MatchingStatus27Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.ModificationCancellationAllowed4Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese038001.ModificationCancellationAllowed4Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.NameAndAddress5 {
        + Adr  : ISO20022.Sese038001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Sese038001.NameAndAddress5 *-- ISO20022.Sese038001.PostalAddress1
    class ISO20022.Sese038001.NettingEligibility4Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese038001.NettingEligibility4Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.Number22Choice {
        + Lng  : ISO20022.Sese038001.GenericIdentification1
        + Shrt  : String
    }
    ISO20022.Sese038001.Number22Choice *-- ISO20022.Sese038001.GenericIdentification1
    class ISO20022.Sese038001.OpeningClosing1Code {
        OPEP = 1
        CLOP = 2
    }
    class ISO20022.Sese038001.OpeningClosing3Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.OpeningClosing3Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Sese038001.OptionStyle8Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.OptionStyle8Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Sese038001.OptionType6Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.OptionType6Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Sese038001.OriginatorRole2Code {
        TAGT = 1
        INVE = 2
        MKTM = 3
        RMKT = 4
        MLTF = 5
        SINT = 6
    }
    class ISO20022.Sese038001.OtherAmounts39 {
        + RsrchFee  : ISO20022.Sese038001.AmountAndDirection44
        + AcrdCptlstnAmt  : ISO20022.Sese038001.AmountAndDirection44
        + CsmptnTax  : ISO20022.Sese038001.AmountAndDirection44
        + NetGnLoss  : ISO20022.Sese038001.AmountAndDirection44
        + WhldgTax  : ISO20022.Sese038001.AmountAndDirection44
        + ValAddedTax  : ISO20022.Sese038001.AmountAndDirection44
        + TxTax  : ISO20022.Sese038001.AmountAndDirection44
        + TrfTax  : ISO20022.Sese038001.AmountAndDirection44
        + StockXchgTax  : ISO20022.Sese038001.AmountAndDirection44
        + StmpDty  : ISO20022.Sese038001.AmountAndDirection44
        + SpclCncssn  : ISO20022.Sese038001.AmountAndDirection44
        + ShppgAmt  : ISO20022.Sese038001.AmountAndDirection44
        + RgltryAmt  : ISO20022.Sese038001.AmountAndDirection44
        + Othr  : ISO20022.Sese038001.AmountAndDirection44
        + Mrgn  : ISO20022.Sese038001.AmountAndDirection44
        + LclBrkrComssn  : ISO20022.Sese038001.AmountAndDirection44
        + LclTaxCtrySpcfc  : ISO20022.Sese038001.AmountAndDirection44
        + LclTax  : ISO20022.Sese038001.AmountAndDirection44
        + PmtLevyTax  : ISO20022.Sese038001.AmountAndDirection44
        + IsseDscntAllwnc  : ISO20022.Sese038001.AmountAndDirection44
        + ExctgBrkrAmt  : ISO20022.Sese038001.AmountAndDirection44
        + TradAmt  : ISO20022.Sese038001.AmountAndDirection44
        + CtryNtlFdrlTax  : ISO20022.Sese038001.AmountAndDirection44
        + ChrgsFees  : ISO20022.Sese038001.AmountAndDirection44
        + AcrdIntrstAmt  : ISO20022.Sese038001.AmountAndDirection44
    }
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    ISO20022.Sese038001.OtherAmounts39 *-- ISO20022.Sese038001.AmountAndDirection44
    class ISO20022.Sese038001.OtherIdentification1 {
        + Tp  : ISO20022.Sese038001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese038001.OtherIdentification1 *-- ISO20022.Sese038001.IdentificationSource3Choice
    class ISO20022.Sese038001.OtherParties43 {
        + Brkr  : ISO20022.Sese038001.PartyIdentificationAndAccount198
        + TrptyAgt  : ISO20022.Sese038001.PartyIdentificationAndAccount198
        + TradRgltr  : ISO20022.Sese038001.PartyIdentificationAndAccount165
        + StockXchg  : ISO20022.Sese038001.PartyIdentificationAndAccount165
        + QlfdFrgnIntrmy  : ISO20022.Sese038001.PartyIdentificationAndAccount198
        + Invstr  : global::System.Collections.Generic.List~ISO20022.Sese038001.PartyIdentificationAndAccount197~
    }
    ISO20022.Sese038001.OtherParties43 *-- ISO20022.Sese038001.PartyIdentificationAndAccount198
    ISO20022.Sese038001.OtherParties43 *-- ISO20022.Sese038001.PartyIdentificationAndAccount198
    ISO20022.Sese038001.OtherParties43 *-- ISO20022.Sese038001.PartyIdentificationAndAccount165
    ISO20022.Sese038001.OtherParties43 *-- ISO20022.Sese038001.PartyIdentificationAndAccount165
    ISO20022.Sese038001.OtherParties43 *-- ISO20022.Sese038001.PartyIdentificationAndAccount198
    ISO20022.Sese038001.OtherParties43 *-- ISO20022.Sese038001.PartyIdentificationAndAccount197
    class ISO20022.Sese038001.OwnershipLegalRestrictions1Code {
        RSTR = 1
        NRST = 2
        A144 = 3
    }
    class ISO20022.Sese038001.PairedOrTurnedQuantity5Choice {
        + TrndQty  : ISO20022.Sese038001.FinancialInstrumentQuantity33Choice
        + PairdOffQty  : ISO20022.Sese038001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Sese038001.PairedOrTurnedQuantity5Choice *-- ISO20022.Sese038001.FinancialInstrumentQuantity33Choice
    ISO20022.Sese038001.PairedOrTurnedQuantity5Choice *-- ISO20022.Sese038001.FinancialInstrumentQuantity33Choice
    class ISO20022.Sese038001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Sese038001.NameAndAddress5
        + PrtryId  : ISO20022.Sese038001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese038001.PartyIdentification120Choice *-- ISO20022.Sese038001.NameAndAddress5
    ISO20022.Sese038001.PartyIdentification120Choice *-- ISO20022.Sese038001.GenericIdentification36
    class ISO20022.Sese038001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Sese038001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese038001.PartyIdentification127Choice *-- ISO20022.Sese038001.GenericIdentification36
    class ISO20022.Sese038001.PartyIdentification133Choice {
        + PrtryId  : ISO20022.Sese038001.GenericIdentification36
        + NmAndAdr  : ISO20022.Sese038001.NameAndAddress5
        + BICFI  : String
    }
    ISO20022.Sese038001.PartyIdentification133Choice *-- ISO20022.Sese038001.GenericIdentification36
    ISO20022.Sese038001.PartyIdentification133Choice *-- ISO20022.Sese038001.NameAndAddress5
    class ISO20022.Sese038001.PartyIdentification134Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese038001.NameAndAddress5
        + PrtryId  : ISO20022.Sese038001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese038001.PartyIdentification134Choice *-- ISO20022.Sese038001.NameAndAddress5
    ISO20022.Sese038001.PartyIdentification134Choice *-- ISO20022.Sese038001.GenericIdentification36
    class ISO20022.Sese038001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Sese038001.PartyIdentification120Choice
    }
    ISO20022.Sese038001.PartyIdentification136 *-- ISO20022.Sese038001.PartyIdentification120Choice
    class ISO20022.Sese038001.PartyIdentification144 {
        + LEI  : String
        + Id  : ISO20022.Sese038001.PartyIdentification127Choice
    }
    ISO20022.Sese038001.PartyIdentification144 *-- ISO20022.Sese038001.PartyIdentification127Choice
    class ISO20022.Sese038001.PartyIdentification149 {
        + LEI  : String
        + Id  : ISO20022.Sese038001.PartyIdentification134Choice
    }
    ISO20022.Sese038001.PartyIdentification149 *-- ISO20022.Sese038001.PartyIdentification134Choice
    class ISO20022.Sese038001.PartyIdentification257Choice {
        + DgtlLdgrId  : String
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese038001.NameAndAddress5
        + AnyBIC  : String
    }
    ISO20022.Sese038001.PartyIdentification257Choice *-- ISO20022.Sese038001.NameAndAddress5
    class ISO20022.Sese038001.PartyIdentification314 {
        + PrcgId  : String
        + LEI  : String
        + Id  : ISO20022.Sese038001.PartyIdentification257Choice
    }
    ISO20022.Sese038001.PartyIdentification314 *-- ISO20022.Sese038001.PartyIdentification257Choice
    class ISO20022.Sese038001.PartyIdentification315 {
        + AddtlInf  : ISO20022.Sese038001.PartyTextInformation1
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese038001.DateAndDateTime2Choice
        + AltrnId  : ISO20022.Sese038001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese038001.PartyIdentification257Choice
    }
    ISO20022.Sese038001.PartyIdentification315 *-- ISO20022.Sese038001.PartyTextInformation1
    ISO20022.Sese038001.PartyIdentification315 *-- ISO20022.Sese038001.DateAndDateTime2Choice
    ISO20022.Sese038001.PartyIdentification315 *-- ISO20022.Sese038001.AlternatePartyIdentification7
    ISO20022.Sese038001.PartyIdentification315 *-- ISO20022.Sese038001.PartyIdentification257Choice
    class ISO20022.Sese038001.PartyIdentificationAndAccount165 {
        + AddtlInf  : ISO20022.Sese038001.PartyTextInformation1
        + PrcgId  : String
        + AltrnId  : ISO20022.Sese038001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese038001.PartyIdentification120Choice
    }
    ISO20022.Sese038001.PartyIdentificationAndAccount165 *-- ISO20022.Sese038001.PartyTextInformation1
    ISO20022.Sese038001.PartyIdentificationAndAccount165 *-- ISO20022.Sese038001.AlternatePartyIdentification7
    ISO20022.Sese038001.PartyIdentificationAndAccount165 *-- ISO20022.Sese038001.PartyIdentification120Choice
    class ISO20022.Sese038001.PartyIdentificationAndAccount195 {
        + PrcgId  : String
        + BlckChainAdrOrWllt  : ISO20022.Sese038001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese038001.SecuritiesAccount19
        + LEI  : String
        + Id  : ISO20022.Sese038001.PartyIdentification120Choice
    }
    ISO20022.Sese038001.PartyIdentificationAndAccount195 *-- ISO20022.Sese038001.BlockChainAddressWallet3
    ISO20022.Sese038001.PartyIdentificationAndAccount195 *-- ISO20022.Sese038001.SecuritiesAccount19
    ISO20022.Sese038001.PartyIdentificationAndAccount195 *-- ISO20022.Sese038001.PartyIdentification120Choice
    class ISO20022.Sese038001.PartyIdentificationAndAccount196 {
        + AddtlInf  : ISO20022.Sese038001.PartyTextInformation1
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese038001.DateAndDateTime2Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese038001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese038001.SecuritiesAccount19
        + AltrnId  : ISO20022.Sese038001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese038001.PartyIdentification120Choice
    }
    ISO20022.Sese038001.PartyIdentificationAndAccount196 *-- ISO20022.Sese038001.PartyTextInformation1
    ISO20022.Sese038001.PartyIdentificationAndAccount196 *-- ISO20022.Sese038001.DateAndDateTime2Choice
    ISO20022.Sese038001.PartyIdentificationAndAccount196 *-- ISO20022.Sese038001.BlockChainAddressWallet3
    ISO20022.Sese038001.PartyIdentificationAndAccount196 *-- ISO20022.Sese038001.SecuritiesAccount19
    ISO20022.Sese038001.PartyIdentificationAndAccount196 *-- ISO20022.Sese038001.AlternatePartyIdentification7
    ISO20022.Sese038001.PartyIdentificationAndAccount196 *-- ISO20022.Sese038001.PartyIdentification120Choice
    class ISO20022.Sese038001.PartyIdentificationAndAccount197 {
        + AddtlInf  : ISO20022.Sese038001.PartyTextInformation1
        + PrcgId  : String
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
        + Ntlty  : String
        + AltrnId  : ISO20022.Sese038001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese038001.PartyIdentification120Choice
    }
    ISO20022.Sese038001.PartyIdentificationAndAccount197 *-- ISO20022.Sese038001.PartyTextInformation1
    ISO20022.Sese038001.PartyIdentificationAndAccount197 *-- ISO20022.Sese038001.AlternatePartyIdentification7
    ISO20022.Sese038001.PartyIdentificationAndAccount197 *-- ISO20022.Sese038001.PartyIdentification120Choice
    class ISO20022.Sese038001.PartyIdentificationAndAccount198 {
        + AddtlInf  : ISO20022.Sese038001.PartyTextInformation1
        + PrcgId  : String
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
        + AltrnId  : ISO20022.Sese038001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese038001.PartyIdentification120Choice
    }
    ISO20022.Sese038001.PartyIdentificationAndAccount198 *-- ISO20022.Sese038001.PartyTextInformation1
    ISO20022.Sese038001.PartyIdentificationAndAccount198 *-- ISO20022.Sese038001.AlternatePartyIdentification7
    ISO20022.Sese038001.PartyIdentificationAndAccount198 *-- ISO20022.Sese038001.PartyIdentification120Choice
    class ISO20022.Sese038001.PartyIdentificationAndAccount223 {
        + AddtlInf  : ISO20022.Sese038001.PartyTextInformation2
        + TaxAcct  : ISO20022.Sese038001.CashAccountIdentification5Choice
        + ComssnAcct  : ISO20022.Sese038001.CashAccountIdentification5Choice
        + ChrgsAcct  : ISO20022.Sese038001.CashAccountIdentification5Choice
        + CshAcct  : ISO20022.Sese038001.CashAccountIdentification9Choice
        + AltrnId  : ISO20022.Sese038001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese038001.PartyIdentification120Choice
    }
    ISO20022.Sese038001.PartyIdentificationAndAccount223 *-- ISO20022.Sese038001.PartyTextInformation2
    ISO20022.Sese038001.PartyIdentificationAndAccount223 *-- ISO20022.Sese038001.CashAccountIdentification5Choice
    ISO20022.Sese038001.PartyIdentificationAndAccount223 *-- ISO20022.Sese038001.CashAccountIdentification5Choice
    ISO20022.Sese038001.PartyIdentificationAndAccount223 *-- ISO20022.Sese038001.CashAccountIdentification5Choice
    ISO20022.Sese038001.PartyIdentificationAndAccount223 *-- ISO20022.Sese038001.CashAccountIdentification9Choice
    ISO20022.Sese038001.PartyIdentificationAndAccount223 *-- ISO20022.Sese038001.AlternatePartyIdentification7
    ISO20022.Sese038001.PartyIdentificationAndAccount223 *-- ISO20022.Sese038001.PartyIdentification120Choice
    class ISO20022.Sese038001.PartyIdentificationAndAccount224 {
        + AddtlInf  : ISO20022.Sese038001.PartyTextInformation2
        + TaxAcct  : ISO20022.Sese038001.CashAccountIdentification5Choice
        + ComssnAcct  : ISO20022.Sese038001.CashAccountIdentification5Choice
        + ChrgsAcct  : ISO20022.Sese038001.CashAccountIdentification5Choice
        + CshAcct  : ISO20022.Sese038001.CashAccountIdentification9Choice
        + AltrnId  : ISO20022.Sese038001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese038001.PartyIdentification133Choice
    }
    ISO20022.Sese038001.PartyIdentificationAndAccount224 *-- ISO20022.Sese038001.PartyTextInformation2
    ISO20022.Sese038001.PartyIdentificationAndAccount224 *-- ISO20022.Sese038001.CashAccountIdentification5Choice
    ISO20022.Sese038001.PartyIdentificationAndAccount224 *-- ISO20022.Sese038001.CashAccountIdentification5Choice
    ISO20022.Sese038001.PartyIdentificationAndAccount224 *-- ISO20022.Sese038001.CashAccountIdentification5Choice
    ISO20022.Sese038001.PartyIdentificationAndAccount224 *-- ISO20022.Sese038001.CashAccountIdentification9Choice
    ISO20022.Sese038001.PartyIdentificationAndAccount224 *-- ISO20022.Sese038001.AlternatePartyIdentification7
    ISO20022.Sese038001.PartyIdentificationAndAccount224 *-- ISO20022.Sese038001.PartyIdentification133Choice
    class ISO20022.Sese038001.PartyTextInformation1 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese038001.PartyTextInformation2 {
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese038001.PlaceOfClearingIdentification2 {
        + LEI  : String
        + Id  : String
    }
    class ISO20022.Sese038001.PlaceOfTradeIdentification1 {
        + LEI  : String
        + MktTpAndId  : ISO20022.Sese038001.MarketIdentification84
    }
    ISO20022.Sese038001.PlaceOfTradeIdentification1 *-- ISO20022.Sese038001.MarketIdentification84
    class ISO20022.Sese038001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Sese038001.Price10 {
        + Val  : ISO20022.Sese038001.PriceRateOrAmount3Choice
        + Tp  : ISO20022.Sese038001.YieldedOrValueType2Choice
    }
    ISO20022.Sese038001.Price10 *-- ISO20022.Sese038001.PriceRateOrAmount3Choice
    ISO20022.Sese038001.Price10 *-- ISO20022.Sese038001.YieldedOrValueType2Choice
    class ISO20022.Sese038001.Price7 {
        + Val  : ISO20022.Sese038001.PriceRateOrAmount3Choice
        + Tp  : ISO20022.Sese038001.YieldedOrValueType1Choice
    }
    ISO20022.Sese038001.Price7 *-- ISO20022.Sese038001.PriceRateOrAmount3Choice
    ISO20022.Sese038001.Price7 *-- ISO20022.Sese038001.YieldedOrValueType1Choice
    class ISO20022.Sese038001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Sese038001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Sese038001.PriceRateOrAmount3Choice *-- ISO20022.Sese038001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Sese038001.PriceType4Choice {
        + Indctv  : ISO20022.Sese038001.Price7
        + Mkt  : ISO20022.Sese038001.Price7
    }
    ISO20022.Sese038001.PriceType4Choice *-- ISO20022.Sese038001.Price7
    ISO20022.Sese038001.PriceType4Choice *-- ISO20022.Sese038001.Price7
    class ISO20022.Sese038001.PriceValueType12Code {
        NEGA = 1
        PREM = 2
        PARV = 3
        DISC = 4
    }
    class ISO20022.Sese038001.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Sese038001.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Sese038001.ProcessingPosition7Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.ProcessingPosition7Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.Quantity51Choice {
        + OrgnlAndCurFace  : ISO20022.Sese038001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Sese038001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Sese038001.Quantity51Choice *-- ISO20022.Sese038001.OriginalAndCurrentQuantities1
    ISO20022.Sese038001.Quantity51Choice *-- ISO20022.Sese038001.FinancialInstrumentQuantity33Choice
    class ISO20022.Sese038001.QuantityAndAccount113 {
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Sese038001.QuantityBreakdown62~
        + SfkpgPlc  : ISO20022.Sese038001.SafeKeepingPlace5
        + CshAcct  : ISO20022.Sese038001.CashAccountIdentification9Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese038001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese038001.SecuritiesAccount19
        + AcctOwnr  : ISO20022.Sese038001.PartyIdentification144
        + DnmtnChc  : String
        + SttlmQty  : ISO20022.Sese038001.Quantity51Choice
    }
    ISO20022.Sese038001.QuantityAndAccount113 *-- ISO20022.Sese038001.QuantityBreakdown62
    ISO20022.Sese038001.QuantityAndAccount113 *-- ISO20022.Sese038001.SafeKeepingPlace5
    ISO20022.Sese038001.QuantityAndAccount113 *-- ISO20022.Sese038001.CashAccountIdentification9Choice
    ISO20022.Sese038001.QuantityAndAccount113 *-- ISO20022.Sese038001.BlockChainAddressWallet3
    ISO20022.Sese038001.QuantityAndAccount113 *-- ISO20022.Sese038001.SecuritiesAccount19
    ISO20022.Sese038001.QuantityAndAccount113 *-- ISO20022.Sese038001.PartyIdentification144
    ISO20022.Sese038001.QuantityAndAccount113 *-- ISO20022.Sese038001.Quantity51Choice
    class ISO20022.Sese038001.QuantityAndAccount118 {
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Sese038001.QuantityBreakdown62~
        + SfkpgPlc  : ISO20022.Sese038001.SafeKeepingPlace5
        + CshAcct  : ISO20022.Sese038001.CashAccountIdentification9Choice
        + AcctOwnr  : ISO20022.Sese038001.PartyIdentification144
        + DnmtnChc  : String
    }
    ISO20022.Sese038001.QuantityAndAccount118 *-- ISO20022.Sese038001.QuantityBreakdown62
    ISO20022.Sese038001.QuantityAndAccount118 *-- ISO20022.Sese038001.SafeKeepingPlace5
    ISO20022.Sese038001.QuantityAndAccount118 *-- ISO20022.Sese038001.CashAccountIdentification9Choice
    ISO20022.Sese038001.QuantityAndAccount118 *-- ISO20022.Sese038001.PartyIdentification144
    class ISO20022.Sese038001.QuantityBreakdown62 {
        + TpOfPric  : ISO20022.Sese038001.TypeOfPrice29Choice
        + LotPric  : ISO20022.Sese038001.Price7
        + LotDtTm  : ISO20022.Sese038001.DateAndDateTime2Choice
        + LotQty  : ISO20022.Sese038001.FinancialInstrumentQuantity33Choice
        + LotNb  : ISO20022.Sese038001.GenericIdentification37
    }
    ISO20022.Sese038001.QuantityBreakdown62 *-- ISO20022.Sese038001.TypeOfPrice29Choice
    ISO20022.Sese038001.QuantityBreakdown62 *-- ISO20022.Sese038001.Price7
    ISO20022.Sese038001.QuantityBreakdown62 *-- ISO20022.Sese038001.DateAndDateTime2Choice
    ISO20022.Sese038001.QuantityBreakdown62 *-- ISO20022.Sese038001.FinancialInstrumentQuantity33Choice
    ISO20022.Sese038001.QuantityBreakdown62 *-- ISO20022.Sese038001.GenericIdentification37
    class ISO20022.Sese038001.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese038001.References47Choice {
        + OthrTxId  : String
        + AcctSvcrTxId  : String
        + IntraPosMvmntId  : String
        + PoolId  : String
        + SctiesSttlmTxId  : String
    }
    class ISO20022.Sese038001.Registration1Code {
        YREG = 1
        NREG = 2
    }
    class ISO20022.Sese038001.Registration9Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.Registration9Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.RegistrationParameters6 {
        + CertNb  : global::System.Collections.Generic.List~ISO20022.Sese038001.SecuritiesCertificate4~
        + RegarAcct  : String
        + CertfctnDtTm  : ISO20022.Sese038001.DateAndDateTime2Choice
        + CertfctnId  : String
    }
    ISO20022.Sese038001.RegistrationParameters6 *-- ISO20022.Sese038001.SecuritiesCertificate4
    ISO20022.Sese038001.RegistrationParameters6 *-- ISO20022.Sese038001.DateAndDateTime2Choice
    class ISO20022.Sese038001.Reporting2Code {
        DEFR = 1
        REGU = 2
        STEX = 3
    }
    class ISO20022.Sese038001.Reporting6Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.Reporting6Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.Restriction5Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.Restriction5Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.SafeKeepingPlace5 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Sese038001.SafekeepingPlaceFormat41Choice
    }
    ISO20022.Sese038001.SafeKeepingPlace5 *-- ISO20022.Sese038001.SafekeepingPlaceFormat41Choice
    class ISO20022.Sese038001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Sese038001.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Sese038001.SafekeepingPlaceFormat41Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification78
        + TpAndId  : ISO20022.Sese038001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Sese038001.SafekeepingPlaceTypeAndText8
    }
    ISO20022.Sese038001.SafekeepingPlaceFormat41Choice *-- ISO20022.Sese038001.GenericIdentification78
    ISO20022.Sese038001.SafekeepingPlaceFormat41Choice *-- ISO20022.Sese038001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Sese038001.SafekeepingPlaceFormat41Choice *-- ISO20022.Sese038001.SafekeepingPlaceTypeAndText8
    class ISO20022.Sese038001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese038001.SafekeepingPlaceTypeAndText8 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese038001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Sese038001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese038001.SecuritiesAccount19 *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.SecuritiesCertificate4 {
        + SchmeNm  : String
        + Issr  : String
        + Nb  : String
    }
    class ISO20022.Sese038001.SecuritiesPaymentStatus1Code {
        PART = 1
        NILL = 2
        FULL = 3
    }
    class ISO20022.Sese038001.SecuritiesPaymentStatus5Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.SecuritiesPaymentStatus5Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese038001.SupplementaryData1~
        + AddtlPhysOrRegnDtls  : ISO20022.Sese038001.RegistrationParameters6
        + OthrBizPties  : ISO20022.Sese038001.OtherParties43
        + OthrAmts  : ISO20022.Sese038001.OtherAmounts39
        + SttlmAmt  : ISO20022.Sese038001.AmountAndDirection95
        + CshPties  : ISO20022.Sese038001.CashParties41
        + RcvgSttlmPties  : ISO20022.Sese038001.SettlementParties98
        + DlvrgSttlmPties  : ISO20022.Sese038001.SettlementParties98
        + StgSttlmInstrDtls  : ISO20022.Sese038001.StandingSettlementInstruction20
        + SttlmParams  : ISO20022.Sese038001.SettlementDetails218
        + QtyAndAcctDtls  : ISO20022.Sese038001.QuantityAndAccount118
        + FinInstrmAttrbts  : ISO20022.Sese038001.FinancialInstrumentAttributes111
        + TradDtls  : ISO20022.Sese038001.SecuritiesTradeDetails146
        + Lnkgs  : global::System.Collections.Generic.List~ISO20022.Sese038001.Linkages63~
        + SttlmTpAndAddtlParams  : ISO20022.Sese038001.SettlementTypeAndAdditionalParameters13
    }
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 *-- ISO20022.Sese038001.SupplementaryData1
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 *-- ISO20022.Sese038001.RegistrationParameters6
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 *-- ISO20022.Sese038001.OtherParties43
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 *-- ISO20022.Sese038001.OtherAmounts39
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 *-- ISO20022.Sese038001.AmountAndDirection95
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 *-- ISO20022.Sese038001.CashParties41
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 *-- ISO20022.Sese038001.SettlementParties98
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 *-- ISO20022.Sese038001.SettlementParties98
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 *-- ISO20022.Sese038001.StandingSettlementInstruction20
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 *-- ISO20022.Sese038001.SettlementDetails218
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 *-- ISO20022.Sese038001.QuantityAndAccount118
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 *-- ISO20022.Sese038001.FinancialInstrumentAttributes111
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 *-- ISO20022.Sese038001.SecuritiesTradeDetails146
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 *-- ISO20022.Sese038001.Linkages63
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56 *-- ISO20022.Sese038001.SettlementTypeAndAdditionalParameters13
    class ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese038001.SupplementaryData1~
        + AddtlPhysOrRegnDtls  : ISO20022.Sese038001.RegistrationParameters6
        + OthrBizPties  : ISO20022.Sese038001.OtherParties43
        + OthrAmts  : ISO20022.Sese038001.OtherAmounts39
        + SttlmAmt  : ISO20022.Sese038001.AmountAndDirection95
        + CshPties  : ISO20022.Sese038001.CashParties41
        + RcvgSttlmPties  : ISO20022.Sese038001.SettlementParties126
        + DlvrgSttlmPties  : ISO20022.Sese038001.SettlementParties126
        + StgSttlmInstrDtls  : ISO20022.Sese038001.StandingSettlementInstruction20
        + SttlmParams  : ISO20022.Sese038001.SettlementDetails218
        + QtyAndAcctDtls  : ISO20022.Sese038001.QuantityAndAccount113
        + FinInstrmAttrbts  : ISO20022.Sese038001.FinancialInstrumentAttributes111
        + FinInstrmId  : ISO20022.Sese038001.SecurityIdentification19
        + TradDtls  : ISO20022.Sese038001.SecuritiesTradeDetails147
        + Lnkgs  : global::System.Collections.Generic.List~ISO20022.Sese038001.Linkages63~
        + SttlmTpAndAddtlParams  : ISO20022.Sese038001.SettlementTypeAndAdditionalParameters14
    }
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.SupplementaryData1
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.RegistrationParameters6
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.OtherParties43
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.OtherAmounts39
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.AmountAndDirection95
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.CashParties41
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.SettlementParties126
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.SettlementParties126
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.StandingSettlementInstruction20
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.SettlementDetails218
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.QuantityAndAccount113
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.FinancialInstrumentAttributes111
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.SecurityIdentification19
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.SecuritiesTradeDetails147
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.Linkages63
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57 *-- ISO20022.Sese038001.SettlementTypeAndAdditionalParameters14
    class ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese038001.SupplementaryData1~
        + AddtlPhysOrRegnDtls  : ISO20022.Sese038001.RegistrationParameters6
        + OthrBizPties  : ISO20022.Sese038001.OtherParties43
        + OthrAmts  : ISO20022.Sese038001.OtherAmounts39
        + SttlmAmt  : ISO20022.Sese038001.AmountAndDirection95
        + CshPties  : ISO20022.Sese038001.CashParties41
        + RcvgSttlmPties  : ISO20022.Sese038001.SettlementParties98
        + DlvrgSttlmPties  : ISO20022.Sese038001.SettlementParties98
        + StgSttlmInstrDtls  : ISO20022.Sese038001.StandingSettlementInstruction20
        + SttlmParams  : ISO20022.Sese038001.SettlementDetails218
        + QtyAndAcctDtls  : ISO20022.Sese038001.QuantityAndAccount118
        + FinInstrmAttrbts  : ISO20022.Sese038001.FinancialInstrumentAttributes111
        + TradDtls  : ISO20022.Sese038001.SecuritiesTradeDetails146
        + Lnkgs  : global::System.Collections.Generic.List~ISO20022.Sese038001.Linkages40~
        + SttlmTpAndAddtlParams  : ISO20022.Sese038001.SettlementTypeAndAdditionalParameters13
    }
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 *-- ISO20022.Sese038001.SupplementaryData1
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 *-- ISO20022.Sese038001.RegistrationParameters6
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 *-- ISO20022.Sese038001.OtherParties43
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 *-- ISO20022.Sese038001.OtherAmounts39
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 *-- ISO20022.Sese038001.AmountAndDirection95
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 *-- ISO20022.Sese038001.CashParties41
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 *-- ISO20022.Sese038001.SettlementParties98
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 *-- ISO20022.Sese038001.SettlementParties98
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 *-- ISO20022.Sese038001.StandingSettlementInstruction20
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 *-- ISO20022.Sese038001.SettlementDetails218
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 *-- ISO20022.Sese038001.QuantityAndAccount118
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 *-- ISO20022.Sese038001.FinancialInstrumentAttributes111
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 *-- ISO20022.Sese038001.SecuritiesTradeDetails146
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 *-- ISO20022.Sese038001.Linkages40
    ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58 *-- ISO20022.Sese038001.SettlementTypeAndAdditionalParameters13
    class ISO20022.Sese038001.SecuritiesSettlementTransactionModificationRequestV10 {
        + UpdTp  : global::System.Collections.Generic.List~ISO20022.Sese038001.UpdateType39Choice~
        + ModfdTxDtls  : ISO20022.Sese038001.TransactionDetails176
    }
    ISO20022.Sese038001.SecuritiesSettlementTransactionModificationRequestV10 *-- ISO20022.Sese038001.UpdateType39Choice
    ISO20022.Sese038001.SecuritiesSettlementTransactionModificationRequestV10 *-- ISO20022.Sese038001.TransactionDetails176
    class ISO20022.Sese038001.SecuritiesTradeDetails146 {
        + SttlmInstrPrcgAddtlDtls  : String
        + FxAddtlDtls  : String
        + AffirmSts  : ISO20022.Sese038001.AffirmationStatus8Choice
        + MtchgSts  : ISO20022.Sese038001.MatchingStatus27Choice
        + CcyToBuyOrSell  : ISO20022.Sese038001.CurrencyToBuyOrSell1Choice
        + TpOfPric  : ISO20022.Sese038001.TypeOfPrice29Choice
        + TradOrgtrRole  : ISO20022.Sese038001.TradeOriginator3Choice
        + InvstrCpcty  : ISO20022.Sese038001.InvestorCapacity4Choice
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Sese038001.TradeTransactionCondition5Choice~
        + Rptg  : global::System.Collections.Generic.List~ISO20022.Sese038001.Reporting6Choice~
        + OpngClsg  : ISO20022.Sese038001.OpeningClosing3Choice
        + NbOfDaysAcrd  : Decimal
        + DealPric  : ISO20022.Sese038001.Price10
        + LateDlvryDt  : ISO20022.Sese038001.DateAndDateTime2Choice
        + TradDt  : ISO20022.Sese038001.TradeDate8Choice
        + PlcOfClr  : ISO20022.Sese038001.PlaceOfClearingIdentification2
        + PlcOfTrad  : ISO20022.Sese038001.PlaceOfTradeIdentification1
        + CollTxId  : global::System.Collections.Generic.List~String~
        + UnqTxIdr  : String
        + TradId  : String
    }
    ISO20022.Sese038001.SecuritiesTradeDetails146 *-- ISO20022.Sese038001.AffirmationStatus8Choice
    ISO20022.Sese038001.SecuritiesTradeDetails146 *-- ISO20022.Sese038001.MatchingStatus27Choice
    ISO20022.Sese038001.SecuritiesTradeDetails146 *-- ISO20022.Sese038001.CurrencyToBuyOrSell1Choice
    ISO20022.Sese038001.SecuritiesTradeDetails146 *-- ISO20022.Sese038001.TypeOfPrice29Choice
    ISO20022.Sese038001.SecuritiesTradeDetails146 *-- ISO20022.Sese038001.TradeOriginator3Choice
    ISO20022.Sese038001.SecuritiesTradeDetails146 *-- ISO20022.Sese038001.InvestorCapacity4Choice
    ISO20022.Sese038001.SecuritiesTradeDetails146 *-- ISO20022.Sese038001.TradeTransactionCondition5Choice
    ISO20022.Sese038001.SecuritiesTradeDetails146 *-- ISO20022.Sese038001.Reporting6Choice
    ISO20022.Sese038001.SecuritiesTradeDetails146 *-- ISO20022.Sese038001.OpeningClosing3Choice
    ISO20022.Sese038001.SecuritiesTradeDetails146 *-- ISO20022.Sese038001.Price10
    ISO20022.Sese038001.SecuritiesTradeDetails146 *-- ISO20022.Sese038001.DateAndDateTime2Choice
    ISO20022.Sese038001.SecuritiesTradeDetails146 *-- ISO20022.Sese038001.TradeDate8Choice
    ISO20022.Sese038001.SecuritiesTradeDetails146 *-- ISO20022.Sese038001.PlaceOfClearingIdentification2
    ISO20022.Sese038001.SecuritiesTradeDetails146 *-- ISO20022.Sese038001.PlaceOfTradeIdentification1
    class ISO20022.Sese038001.SecuritiesTradeDetails147 {
        + SttlmInstrPrcgAddtlDtls  : String
        + FxAddtlDtls  : String
        + AffirmSts  : ISO20022.Sese038001.AffirmationStatus8Choice
        + MtchgSts  : ISO20022.Sese038001.MatchingStatus27Choice
        + CcyToBuyOrSell  : ISO20022.Sese038001.CurrencyToBuyOrSell1Choice
        + TpOfPric  : ISO20022.Sese038001.TypeOfPrice29Choice
        + TradOrgtrRole  : ISO20022.Sese038001.TradeOriginator3Choice
        + InvstrCpcty  : ISO20022.Sese038001.InvestorCapacity4Choice
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Sese038001.TradeTransactionCondition5Choice~
        + Rptg  : global::System.Collections.Generic.List~ISO20022.Sese038001.Reporting6Choice~
        + OpngClsg  : ISO20022.Sese038001.OpeningClosing3Choice
        + NbOfDaysAcrd  : Decimal
        + DealPric  : ISO20022.Sese038001.Price10
        + LateDlvryDt  : ISO20022.Sese038001.DateAndDateTime2Choice
        + SttlmDt  : ISO20022.Sese038001.SettlementDate17Choice
        + TradDt  : ISO20022.Sese038001.TradeDate8Choice
        + PlcOfClr  : ISO20022.Sese038001.PlaceOfClearingIdentification2
        + PlcOfTrad  : ISO20022.Sese038001.PlaceOfTradeIdentification1
        + CollTxId  : global::System.Collections.Generic.List~String~
        + UnqTxIdr  : String
        + TradId  : String
    }
    ISO20022.Sese038001.SecuritiesTradeDetails147 *-- ISO20022.Sese038001.AffirmationStatus8Choice
    ISO20022.Sese038001.SecuritiesTradeDetails147 *-- ISO20022.Sese038001.MatchingStatus27Choice
    ISO20022.Sese038001.SecuritiesTradeDetails147 *-- ISO20022.Sese038001.CurrencyToBuyOrSell1Choice
    ISO20022.Sese038001.SecuritiesTradeDetails147 *-- ISO20022.Sese038001.TypeOfPrice29Choice
    ISO20022.Sese038001.SecuritiesTradeDetails147 *-- ISO20022.Sese038001.TradeOriginator3Choice
    ISO20022.Sese038001.SecuritiesTradeDetails147 *-- ISO20022.Sese038001.InvestorCapacity4Choice
    ISO20022.Sese038001.SecuritiesTradeDetails147 *-- ISO20022.Sese038001.TradeTransactionCondition5Choice
    ISO20022.Sese038001.SecuritiesTradeDetails147 *-- ISO20022.Sese038001.Reporting6Choice
    ISO20022.Sese038001.SecuritiesTradeDetails147 *-- ISO20022.Sese038001.OpeningClosing3Choice
    ISO20022.Sese038001.SecuritiesTradeDetails147 *-- ISO20022.Sese038001.Price10
    ISO20022.Sese038001.SecuritiesTradeDetails147 *-- ISO20022.Sese038001.DateAndDateTime2Choice
    ISO20022.Sese038001.SecuritiesTradeDetails147 *-- ISO20022.Sese038001.SettlementDate17Choice
    ISO20022.Sese038001.SecuritiesTradeDetails147 *-- ISO20022.Sese038001.TradeDate8Choice
    ISO20022.Sese038001.SecuritiesTradeDetails147 *-- ISO20022.Sese038001.PlaceOfClearingIdentification2
    ISO20022.Sese038001.SecuritiesTradeDetails147 *-- ISO20022.Sese038001.PlaceOfTradeIdentification1
    class ISO20022.Sese038001.SecuritiesTransactionType28Code {
        INTT = 1
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
    class ISO20022.Sese038001.SecuritiesTransactionType59Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.SecuritiesTransactionType59Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese038001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Sese038001.SecurityIdentification19 *-- ISO20022.Sese038001.OtherIdentification1
    class ISO20022.Sese038001.SettlementDate17Choice {
        + DtCd  : ISO20022.Sese038001.SettlementDateCode7Choice
        + Dt  : ISO20022.Sese038001.DateAndDateTime2Choice
    }
    ISO20022.Sese038001.SettlementDate17Choice *-- ISO20022.Sese038001.SettlementDateCode7Choice
    ISO20022.Sese038001.SettlementDate17Choice *-- ISO20022.Sese038001.DateAndDateTime2Choice
    class ISO20022.Sese038001.SettlementDate4Code {
        WISS = 1
    }
    class ISO20022.Sese038001.SettlementDateCode7Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.SettlementDateCode7Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.SettlementDetails218 {
        + CshSubBalTp  : ISO20022.Sese038001.GenericIdentification30
        + SctiesSubBalTp  : ISO20022.Sese038001.GenericIdentification30
        + ElgblForColl  : String
        + ModCxlAllwd  : ISO20022.Sese038001.ModificationCancellationAllowed4Choice
        + RtrLeg  : String
        + LttrOfGrnt  : ISO20022.Sese038001.LetterOfGuarantee4Choice
        + Trckg  : ISO20022.Sese038001.Tracking4Choice
        + StmpDtyTaxBsis  : ISO20022.Sese038001.GenericIdentification30
        + TaxCpcty  : ISO20022.Sese038001.TaxCapacityParty4Choice
        + SttlgCpcty  : ISO20022.Sese038001.SettlingCapacity7Choice
        + LglRstrctns  : ISO20022.Sese038001.Restriction5Choice
        + Regn  : ISO20022.Sese038001.Registration9Choice
        + NetgElgblty  : ISO20022.Sese038001.NettingEligibility4Choice
        + MktClntSd  : ISO20022.Sese038001.MarketClientSide6Choice
        + FxStgInstr  : ISO20022.Sese038001.FXStandingInstruction4Choice
        + XpsrTp  : ISO20022.Sese038001.ExposureType25Choice
        + CshClrSys  : ISO20022.Sese038001.CashSettlementSystem4Choice
        + DlvryRtrRsn  : ISO20022.Sese038001.DeliveryReturn3Choice
        + CCPElgblty  : ISO20022.Sese038001.CentralCounterPartyEligibility4Choice
        + BnfclOwnrsh  : ISO20022.Sese038001.BeneficialOwnership4Choice
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese038001.SettlementTransactionCondition16Choice~
        + SctiesTxTp  : ISO20022.Sese038001.SecuritiesTransactionType59Choice
    }
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.GenericIdentification30
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.GenericIdentification30
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.ModificationCancellationAllowed4Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.LetterOfGuarantee4Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.Tracking4Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.GenericIdentification30
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.TaxCapacityParty4Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.SettlingCapacity7Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.Restriction5Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.Registration9Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.NettingEligibility4Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.MarketClientSide6Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.FXStandingInstruction4Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.ExposureType25Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.CashSettlementSystem4Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.DeliveryReturn3Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.CentralCounterPartyEligibility4Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.BeneficialOwnership4Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.SettlementTransactionCondition16Choice
    ISO20022.Sese038001.SettlementDetails218 *-- ISO20022.Sese038001.SecuritiesTransactionType59Choice
    class ISO20022.Sese038001.SettlementParties125 {
        + Pty5  : ISO20022.Sese038001.PartyIdentificationAndAccount195
        + Pty4  : ISO20022.Sese038001.PartyIdentificationAndAccount195
        + Pty3  : ISO20022.Sese038001.PartyIdentificationAndAccount195
        + Pty2  : ISO20022.Sese038001.PartyIdentificationAndAccount195
        + Pty1  : ISO20022.Sese038001.PartyIdentificationAndAccount195
        + Dpstry  : ISO20022.Sese038001.PartyIdentification314
    }
    ISO20022.Sese038001.SettlementParties125 *-- ISO20022.Sese038001.PartyIdentificationAndAccount195
    ISO20022.Sese038001.SettlementParties125 *-- ISO20022.Sese038001.PartyIdentificationAndAccount195
    ISO20022.Sese038001.SettlementParties125 *-- ISO20022.Sese038001.PartyIdentificationAndAccount195
    ISO20022.Sese038001.SettlementParties125 *-- ISO20022.Sese038001.PartyIdentificationAndAccount195
    ISO20022.Sese038001.SettlementParties125 *-- ISO20022.Sese038001.PartyIdentificationAndAccount195
    ISO20022.Sese038001.SettlementParties125 *-- ISO20022.Sese038001.PartyIdentification314
    class ISO20022.Sese038001.SettlementParties126 {
        + Pty5  : ISO20022.Sese038001.PartyIdentificationAndAccount196
        + Pty4  : ISO20022.Sese038001.PartyIdentificationAndAccount196
        + Pty3  : ISO20022.Sese038001.PartyIdentificationAndAccount196
        + Pty2  : ISO20022.Sese038001.PartyIdentificationAndAccount196
        + Pty1  : ISO20022.Sese038001.PartyIdentificationAndAccount196
        + Dpstry  : ISO20022.Sese038001.PartyIdentification315
    }
    ISO20022.Sese038001.SettlementParties126 *-- ISO20022.Sese038001.PartyIdentificationAndAccount196
    ISO20022.Sese038001.SettlementParties126 *-- ISO20022.Sese038001.PartyIdentificationAndAccount196
    ISO20022.Sese038001.SettlementParties126 *-- ISO20022.Sese038001.PartyIdentificationAndAccount196
    ISO20022.Sese038001.SettlementParties126 *-- ISO20022.Sese038001.PartyIdentificationAndAccount196
    ISO20022.Sese038001.SettlementParties126 *-- ISO20022.Sese038001.PartyIdentificationAndAccount196
    ISO20022.Sese038001.SettlementParties126 *-- ISO20022.Sese038001.PartyIdentification315
    class ISO20022.Sese038001.SettlementParties98 {
        + Pty5  : ISO20022.Sese038001.PartyIdentificationAndAccount196
        + Pty4  : ISO20022.Sese038001.PartyIdentificationAndAccount196
        + Pty3  : ISO20022.Sese038001.PartyIdentificationAndAccount196
        + Pty2  : ISO20022.Sese038001.PartyIdentificationAndAccount196
    }
    ISO20022.Sese038001.SettlementParties98 *-- ISO20022.Sese038001.PartyIdentificationAndAccount196
    ISO20022.Sese038001.SettlementParties98 *-- ISO20022.Sese038001.PartyIdentificationAndAccount196
    ISO20022.Sese038001.SettlementParties98 *-- ISO20022.Sese038001.PartyIdentificationAndAccount196
    ISO20022.Sese038001.SettlementParties98 *-- ISO20022.Sese038001.PartyIdentificationAndAccount196
    class ISO20022.Sese038001.SettlementStandingInstructionDatabase1Code {
        VEND = 1
        BRKR = 2
        INTE = 3
    }
    class ISO20022.Sese038001.SettlementStandingInstructionDatabase4Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.SettlementStandingInstructionDatabase4Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.SettlementTransactionCondition10Code {
        UNEX = 1
        TRIP = 2
        TRAN = 3
        SPST = 4
        SPDL = 5
        SHOR = 6
        RESI = 7
        RPTO = 8
        RHYP = 9
        PHYS = 10
        PENS = 11
        NACT = 12
        NOMC = 13
        KNOC = 14
        FRCL = 15
        EXPI = 16
        EXER = 17
        DRAW = 18
        DIRT = 19
        DLWM = 20
        CLEN = 21
        BUTC = 22
        ASGN = 23
        ADEA = 24
    }
    class ISO20022.Sese038001.SettlementTransactionCondition16Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.SettlementTransactionCondition16Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.SettlementTypeAndAdditionalParameters13 {
        + RcncltnInd  : String
        + CorpActnEvtId  : String
        + CmonId  : String
    }
    class ISO20022.Sese038001.SettlementTypeAndAdditionalParameters14 {
        + RcncltnInd  : String
        + CorpActnEvtId  : String
        + CmonId  : String
        + Pmt  : String
        + SctiesMvmntTp  : String
    }
    class ISO20022.Sese038001.SettlementTypeAndIdentification18 {
        + Pmt  : String
        + SctiesMvmntTp  : String
        + TxId  : String
    }
    class ISO20022.Sese038001.SettlingCapacity2Code {
        RISP = 1
        SPRI = 2
        CUST = 3
        SAGE = 4
    }
    class ISO20022.Sese038001.SettlingCapacity7Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.SettlingCapacity7Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.StandingSettlementInstruction20 {
        + OthrRcvgSttlmPties  : ISO20022.Sese038001.SettlementParties126
        + OthrDlvrgSttlmPties  : ISO20022.Sese038001.SettlementParties126
        + Vndr  : ISO20022.Sese038001.PartyIdentification136
        + CtrPty  : ISO20022.Sese038001.Counterparty15Choice
        + SttlmStgInstrDB  : ISO20022.Sese038001.SettlementStandingInstructionDatabase4Choice
    }
    ISO20022.Sese038001.StandingSettlementInstruction20 *-- ISO20022.Sese038001.SettlementParties126
    ISO20022.Sese038001.StandingSettlementInstruction20 *-- ISO20022.Sese038001.SettlementParties126
    ISO20022.Sese038001.StandingSettlementInstruction20 *-- ISO20022.Sese038001.PartyIdentification136
    ISO20022.Sese038001.StandingSettlementInstruction20 *-- ISO20022.Sese038001.Counterparty15Choice
    ISO20022.Sese038001.StandingSettlementInstruction20 *-- ISO20022.Sese038001.SettlementStandingInstructionDatabase4Choice
    class ISO20022.Sese038001.SupplementaryData1 {
        + Envlp  : ISO20022.Sese038001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese038001.SupplementaryData1 *-- ISO20022.Sese038001.SupplementaryDataEnvelope1
    class ISO20022.Sese038001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese038001.TaxCapacityParty4Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.TaxCapacityParty4Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.TaxLiability1Code {
        AGEN = 1
        PRIN = 2
    }
    class ISO20022.Sese038001.Tracking4Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese038001.Tracking4Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.TradeDate8Choice {
        + DtCd  : ISO20022.Sese038001.TradeDateCode3Choice
        + Dt  : ISO20022.Sese038001.DateAndDateTime2Choice
    }
    ISO20022.Sese038001.TradeDate8Choice *-- ISO20022.Sese038001.TradeDateCode3Choice
    ISO20022.Sese038001.TradeDate8Choice *-- ISO20022.Sese038001.DateAndDateTime2Choice
    class ISO20022.Sese038001.TradeDateCode3Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.TradeDateCode3Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.TradeOriginator3Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.TradeOriginator3Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.TradeTransactionCondition4Code {
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
    class ISO20022.Sese038001.TradeTransactionCondition5Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.TradeTransactionCondition5Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.TransactionDetails172 {
        + Invstr  : ISO20022.Sese038001.PartyIdentification149
        + RcvgSttlmPties  : ISO20022.Sese038001.SettlementParties125
        + DlvrgSttlmPties  : ISO20022.Sese038001.SettlementParties125
        + SttlmAmt  : ISO20022.Sese038001.AmountAndDirection51
        + SttlmQty  : ISO20022.Sese038001.Quantity51Choice
        + SttlmDt  : ISO20022.Sese038001.SettlementDate17Choice
        + TradDt  : ISO20022.Sese038001.TradeDate8Choice
        + FinInstrmId  : ISO20022.Sese038001.SecurityIdentification19
    }
    ISO20022.Sese038001.TransactionDetails172 *-- ISO20022.Sese038001.PartyIdentification149
    ISO20022.Sese038001.TransactionDetails172 *-- ISO20022.Sese038001.SettlementParties125
    ISO20022.Sese038001.TransactionDetails172 *-- ISO20022.Sese038001.SettlementParties125
    ISO20022.Sese038001.TransactionDetails172 *-- ISO20022.Sese038001.AmountAndDirection51
    ISO20022.Sese038001.TransactionDetails172 *-- ISO20022.Sese038001.Quantity51Choice
    ISO20022.Sese038001.TransactionDetails172 *-- ISO20022.Sese038001.SettlementDate17Choice
    ISO20022.Sese038001.TransactionDetails172 *-- ISO20022.Sese038001.TradeDate8Choice
    ISO20022.Sese038001.TransactionDetails172 *-- ISO20022.Sese038001.SecurityIdentification19
    class ISO20022.Sese038001.TransactionDetails176 {
        + TxDtls  : ISO20022.Sese038001.TransactionDetails172
        + BlckChainAdrOrWllt  : ISO20022.Sese038001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese038001.SecuritiesAccount19
        + AcctOwnr  : ISO20022.Sese038001.PartyIdentification144
        + OthrTxId  : String
        + PrcrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : ISO20022.Sese038001.SettlementTypeAndIdentification18
    }
    ISO20022.Sese038001.TransactionDetails176 *-- ISO20022.Sese038001.TransactionDetails172
    ISO20022.Sese038001.TransactionDetails176 *-- ISO20022.Sese038001.BlockChainAddressWallet3
    ISO20022.Sese038001.TransactionDetails176 *-- ISO20022.Sese038001.SecuritiesAccount19
    ISO20022.Sese038001.TransactionDetails176 *-- ISO20022.Sese038001.PartyIdentification144
    ISO20022.Sese038001.TransactionDetails176 *-- ISO20022.Sese038001.SettlementTypeAndIdentification18
    class ISO20022.Sese038001.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Sese038001.TypeOfPrice14Code {
        AVER = 1
    }
    class ISO20022.Sese038001.TypeOfPrice29Choice {
        + Prtry  : ISO20022.Sese038001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese038001.TypeOfPrice29Choice *-- ISO20022.Sese038001.GenericIdentification30
    class ISO20022.Sese038001.UpdateType39Choice {
        + Mod  : ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57
        + Deltn  : ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58
        + Addtn  : ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56
    }
    ISO20022.Sese038001.UpdateType39Choice *-- ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57
    ISO20022.Sese038001.UpdateType39Choice *-- ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58
    ISO20022.Sese038001.UpdateType39Choice *-- ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56
    class ISO20022.Sese038001.YieldedOrValueType1Choice {
        + ValTp  : String
        + Yldd  : String
    }
    class ISO20022.Sese038001.YieldedOrValueType2Choice {
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

## Value ISO20022.Sese038001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese038001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese038001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese038001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Enum ISO20022.Sese038001.AffirmationStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NAFI|Int32||XmlEnum("""NAFI""")|1|
||AFFI|Int32||XmlEnum("""AFFI""")|2|

---

## Value ISO20022.Sese038001.AffirmationStatus8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.AlternatePartyIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Sese038001.IdentificationType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Sese038001.AmountAndDirection44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Sese038001.ForeignExchangeTerms23||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese038001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese038001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese038001.AmountAndDirection51


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese038001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese038001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese038001.AmountAndDirection95


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValDt|ISO20022.Sese038001.DateAndDateTime2Choice||XmlElement()||
|+|FXDtls|ISO20022.Sese038001.ForeignExchangeTerms23||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese038001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese038001.ActiveCurrencyAndAmount||XmlElement()||
|+|RsrchFeeInd|String||XmlElement()||
|+|BrkrgAmtInd|String||XmlElement()||
|+|StmpDtyInd|String||XmlElement()||
|+|AcrdIntrstInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValDt),validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese038001.BeneficialOwnership4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese038001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese038001.CashAccountIdentification5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Value ISO20022.Sese038001.CashAccountIdentification9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|BlckChainCshWllt|ISO20022.Sese038001.BlockChainAddressWallet3||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainCshWllt),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,BlckChainCshWllt,IBAN))|

---

## Value ISO20022.Sese038001.CashParties41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Intrmy|ISO20022.Sese038001.PartyIdentificationAndAccount224||XmlElement()||
|+|CdtrAgt|ISO20022.Sese038001.PartyIdentificationAndAccount224||XmlElement()||
|+|Cdtr|ISO20022.Sese038001.PartyIdentificationAndAccount223||XmlElement()||
|+|DbtrAgt|ISO20022.Sese038001.PartyIdentificationAndAccount224||XmlElement()||
|+|Dbtr|ISO20022.Sese038001.PartyIdentificationAndAccount223||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Intrmy),validElement(CdtrAgt),validElement(Cdtr),validElement(DbtrAgt),validElement(Dbtr))|

---

## Enum ISO20022.Sese038001.CashSettlementSystem2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETS|Int32||XmlEnum("""NETS""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Value ISO20022.Sese038001.CashSettlementSystem4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.CentralCounterPartyEligibility4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese038001.ClassificationType32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Sese038001.GenericIdentification36||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Value ISO20022.Sese038001.Counterparty15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Buyr|ISO20022.Sese038001.PartyIdentificationAndAccount196||XmlElement()||
|+|Sellr|ISO20022.Sese038001.PartyIdentificationAndAccount196||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Buyr),validElement(Sellr),validChoice(Buyr,Sellr))|

---

## Enum ISO20022.Sese038001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese038001.CurrencyToBuyOrSell1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyToSell|String||XmlElement()||
|+|CcyToBuy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CcyToSell""",CcyToSell,"""[A-Z]{3,3}"""),validPattern("""CcyToBuy""",CcyToBuy,"""[A-Z]{3,3}"""),validChoice(CcyToSell,CcyToBuy))|

---

## Value ISO20022.Sese038001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Sese038001.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese038001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Enum ISO20022.Sese038001.DeliveryReturn1Code


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

## Value ISO20022.Sese038001.DeliveryReturn3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Type ISO20022.Sese038001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmTxModReq|ISO20022.Sese038001.SecuritiesSettlementTransactionModificationRequestV10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmTxModReq))|

---

## Value ISO20022.Sese038001.DocumentNumber5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Sese038001.GenericIdentification36||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Enum ISO20022.Sese038001.Eligibility1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROF|Int32||XmlEnum("""PROF""")|1|
||RETL|Int32||XmlEnum("""RETL""")|2|
||ELIG|Int32||XmlEnum("""ELIG""")|3|

---

## Enum ISO20022.Sese038001.EventFrequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||SEMI|Int32||XmlEnum("""SEMI""")|2|
||QUTR|Int32||XmlEnum("""QUTR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|

---

## Enum ISO20022.Sese038001.ExposureType15Code


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

## Value ISO20022.Sese038001.ExposureType25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.FXStandingInstruction4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese038001.FinancialInstrumentAttributes111


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmAttrAddtlDtls|String||XmlElement()||
|+|UndrlygFinInstrmId|global::System.Collections.Generic.List<ISO20022.Sese038001.SecurityIdentification19>||XmlElement()||
|+|CtrctSz|ISO20022.Sese038001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Sese038001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|StrkPric|ISO20022.Sese038001.Price7||XmlElement()||
|+|ConvsPric|ISO20022.Sese038001.Price7||XmlElement()||
|+|SbcptPric|ISO20022.Sese038001.Price7||XmlElement()||
|+|ExrcPric|ISO20022.Sese038001.Price7||XmlElement()||
|+|MktOrIndctvPric|ISO20022.Sese038001.PriceType4Choice||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|PoolNb|ISO20022.Sese038001.GenericIdentification37||XmlElement()||
|+|CpnAttchdNb|ISO20022.Sese038001.Number22Choice||XmlElement()||
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
|+|OptnTp|ISO20022.Sese038001.OptionType6Choice||XmlElement()||
|+|OptnStyle|ISO20022.Sese038001.OptionStyle8Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Sese038001.ClassificationType32Choice||XmlElement()||
|+|VarblRateChngFrqcy|ISO20022.Sese038001.Frequency23Choice||XmlElement()||
|+|PmtSts|ISO20022.Sese038001.SecuritiesPaymentStatus5Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Sese038001.Frequency23Choice||XmlElement()||
|+|RegnForm|ISO20022.Sese038001.FormOfSecurity6Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Sese038001.InterestComputationMethodFormat4Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Sese038001.MarketIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""UndrlygFinInstrmId""",UndrlygFinInstrmId),validElement(UndrlygFinInstrmId),validElement(CtrctSz),validElement(MinNmnlQty),validElement(StrkPric),validElement(ConvsPric),validElement(SbcptPric),validElement(ExrcPric),validElement(MktOrIndctvPric),validElement(PoolNb),validElement(CpnAttchdNb),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnTp),validElement(OptnStyle),validElement(ClssfctnTp),validElement(VarblRateChngFrqcy),validElement(PmtSts),validElement(PmtFrqcy),validElement(RegnForm),validElement(DayCntBsis),validElement(PlcOfListg))|

---

## Value ISO20022.Sese038001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese038001.ForeignExchangeTerms23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Sese038001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese038001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Sese038001.FormOfSecurity6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.Frequency23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese038001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese038001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese038001.GenericIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese038001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese038001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.IdentificationType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese038001.InterestComputationMethod2Code


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

## Value ISO20022.Sese038001.InterestComputationMethodFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.InvestorCapacity4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.LetterOfGuarantee4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese038001.Linkages40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|ISO20022.Sese038001.References47Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ref))|

---

## Value ISO20022.Sese038001.Linkages63


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkdQty|ISO20022.Sese038001.PairedOrTurnedQuantity5Choice||XmlElement()||
|+|Ref|ISO20022.Sese038001.References47Choice||XmlElement()||
|+|MsgNb|ISO20022.Sese038001.DocumentNumber5Choice||XmlElement()||
|+|PrcgPos|ISO20022.Sese038001.ProcessingPosition7Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkdQty),validElement(Ref),validElement(MsgNb),validElement(PrcgPos))|

---

## Enum ISO20022.Sese038001.MarketClientSide1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MAKT|Int32||XmlEnum("""MAKT""")|1|
||CLNT|Int32||XmlEnum("""CLNT""")|2|

---

## Value ISO20022.Sese038001.MarketClientSide6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.MarketIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese038001.MarketIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese038001.MarketIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese038001.MarketType8Choice||XmlElement()||
|+|Id|ISO20022.Sese038001.MarketIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Enum ISO20022.Sese038001.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Value ISO20022.Sese038001.MarketType8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese038001.MatchingStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NMAT|Int32||XmlEnum("""NMAT""")|1|
||MACH|Int32||XmlEnum("""MACH""")|2|

---

## Value ISO20022.Sese038001.MatchingStatus27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.ModificationCancellationAllowed4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese038001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Sese038001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Sese038001.NettingEligibility4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese038001.Number22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|ISO20022.Sese038001.GenericIdentification1||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lng),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Enum ISO20022.Sese038001.OpeningClosing1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEP|Int32||XmlEnum("""OPEP""")|1|
||CLOP|Int32||XmlEnum("""CLOP""")|2|

---

## Value ISO20022.Sese038001.OpeningClosing3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese038001.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Sese038001.OptionStyle8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese038001.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Sese038001.OptionType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Sese038001.OriginatorRole2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAGT|Int32||XmlEnum("""TAGT""")|1|
||INVE|Int32||XmlEnum("""INVE""")|2|
||MKTM|Int32||XmlEnum("""MKTM""")|3|
||RMKT|Int32||XmlEnum("""RMKT""")|4|
||MLTF|Int32||XmlEnum("""MLTF""")|5|
||SINT|Int32||XmlEnum("""SINT""")|6|

---

## Value ISO20022.Sese038001.OtherAmounts39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsrchFee|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|AcrdCptlstnAmt|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|CsmptnTax|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|NetGnLoss|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|WhldgTax|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|ValAddedTax|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|TxTax|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|TrfTax|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|StockXchgTax|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|StmpDty|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|SpclCncssn|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|ShppgAmt|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|RgltryAmt|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|Othr|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|Mrgn|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|LclBrkrComssn|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|LclTaxCtrySpcfc|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|LclTax|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|PmtLevyTax|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|IsseDscntAllwnc|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|ExctgBrkrAmt|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|TradAmt|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|CtryNtlFdrlTax|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|ChrgsFees|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Sese038001.AmountAndDirection44||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsrchFee),validElement(AcrdCptlstnAmt),validElement(CsmptnTax),validElement(NetGnLoss),validElement(WhldgTax),validElement(ValAddedTax),validElement(TxTax),validElement(TrfTax),validElement(StockXchgTax),validElement(StmpDty),validElement(SpclCncssn),validElement(ShppgAmt),validElement(RgltryAmt),validElement(Othr),validElement(Mrgn),validElement(LclBrkrComssn),validElement(LclTaxCtrySpcfc),validElement(LclTax),validElement(PmtLevyTax),validElement(IsseDscntAllwnc),validElement(ExctgBrkrAmt),validElement(TradAmt),validElement(CtryNtlFdrlTax),validElement(ChrgsFees),validElement(AcrdIntrstAmt))|

---

## Value ISO20022.Sese038001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese038001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese038001.OtherParties43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Brkr|ISO20022.Sese038001.PartyIdentificationAndAccount198||XmlElement()||
|+|TrptyAgt|ISO20022.Sese038001.PartyIdentificationAndAccount198||XmlElement()||
|+|TradRgltr|ISO20022.Sese038001.PartyIdentificationAndAccount165||XmlElement()||
|+|StockXchg|ISO20022.Sese038001.PartyIdentificationAndAccount165||XmlElement()||
|+|QlfdFrgnIntrmy|ISO20022.Sese038001.PartyIdentificationAndAccount198||XmlElement()||
|+|Invstr|global::System.Collections.Generic.List<ISO20022.Sese038001.PartyIdentificationAndAccount197>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Brkr),validElement(TrptyAgt),validElement(TradRgltr),validElement(StockXchg),validElement(QlfdFrgnIntrmy),validList("""Invstr""",Invstr),validElement(Invstr))|

---

## Enum ISO20022.Sese038001.OwnershipLegalRestrictions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSTR|Int32||XmlEnum("""RSTR""")|1|
||NRST|Int32||XmlEnum("""NRST""")|2|
||A144|Int32||XmlEnum("""A144""")|3|

---

## Value ISO20022.Sese038001.PairedOrTurnedQuantity5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrndQty|ISO20022.Sese038001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|PairdOffQty|ISO20022.Sese038001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrndQty),validElement(PairdOffQty),validChoice(TrndQty,PairdOffQty))|

---

## Value ISO20022.Sese038001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese038001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese038001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese038001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese038001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese038001.PartyIdentification133Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese038001.GenericIdentification36||XmlElement()||
|+|NmAndAdr|ISO20022.Sese038001.NameAndAddress5||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validElement(NmAndAdr),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,NmAndAdr,BICFI))|

---

## Value ISO20022.Sese038001.PartyIdentification134Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese038001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese038001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese038001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese038001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese038001.PartyIdentification144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese038001.PartyIdentification127Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese038001.PartyIdentification149


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese038001.PartyIdentification134Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese038001.PartyIdentification257Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese038001.NameAndAddress5||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(DgtlLdgrId,Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese038001.PartyIdentification314


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese038001.PartyIdentification257Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese038001.PartyIdentification315


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese038001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese038001.DateAndDateTime2Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese038001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese038001.PartyIdentification257Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese038001.PartyIdentificationAndAccount165


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese038001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|AltrnId|ISO20022.Sese038001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese038001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese038001.PartyIdentificationAndAccount195


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese038001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese038001.SecuritiesAccount19||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese038001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese038001.PartyIdentificationAndAccount196


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese038001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese038001.DateAndDateTime2Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese038001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese038001.SecuritiesAccount19||XmlElement()||
|+|AltrnId|ISO20022.Sese038001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese038001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese038001.PartyIdentificationAndAccount197


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese038001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|Ntlty|String||XmlElement()||
|+|AltrnId|ISO20022.Sese038001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese038001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""Ntlty""",Ntlty,"""[A-Z]{2,2}"""),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese038001.PartyIdentificationAndAccount198


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese038001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|AltrnId|ISO20022.Sese038001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese038001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese038001.PartyIdentificationAndAccount223


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese038001.PartyTextInformation2||XmlElement()||
|+|TaxAcct|ISO20022.Sese038001.CashAccountIdentification5Choice||XmlElement()||
|+|ComssnAcct|ISO20022.Sese038001.CashAccountIdentification5Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Sese038001.CashAccountIdentification5Choice||XmlElement()||
|+|CshAcct|ISO20022.Sese038001.CashAccountIdentification9Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese038001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese038001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(TaxAcct),validElement(ComssnAcct),validElement(ChrgsAcct),validElement(CshAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese038001.PartyIdentificationAndAccount224


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese038001.PartyTextInformation2||XmlElement()||
|+|TaxAcct|ISO20022.Sese038001.CashAccountIdentification5Choice||XmlElement()||
|+|ComssnAcct|ISO20022.Sese038001.CashAccountIdentification5Choice||XmlElement()||
|+|ChrgsAcct|ISO20022.Sese038001.CashAccountIdentification5Choice||XmlElement()||
|+|CshAcct|ISO20022.Sese038001.CashAccountIdentification9Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese038001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese038001.PartyIdentification133Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(TaxAcct),validElement(ComssnAcct),validElement(ChrgsAcct),validElement(CshAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese038001.PartyTextInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese038001.PartyTextInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese038001.PlaceOfClearingIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese038001.PlaceOfTradeIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|MktTpAndId|ISO20022.Sese038001.MarketIdentification84||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(MktTpAndId))|

---

## Value ISO20022.Sese038001.PostalAddress1


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

## Value ISO20022.Sese038001.Price10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Sese038001.PriceRateOrAmount3Choice||XmlElement()||
|+|Tp|ISO20022.Sese038001.YieldedOrValueType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Sese038001.Price7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Sese038001.PriceRateOrAmount3Choice||XmlElement()||
|+|Tp|ISO20022.Sese038001.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Sese038001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese038001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Sese038001.PriceType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indctv|ISO20022.Sese038001.Price7||XmlElement()||
|+|Mkt|ISO20022.Sese038001.Price7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indctv),validElement(Mkt),validChoice(Indctv,Mkt))|

---

## Enum ISO20022.Sese038001.PriceValueType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NEGA|Int32||XmlEnum("""NEGA""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||PARV|Int32||XmlEnum("""PARV""")|3|
||DISC|Int32||XmlEnum("""DISC""")|4|

---

## Enum ISO20022.Sese038001.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Enum ISO20022.Sese038001.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Sese038001.ProcessingPosition7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.Quantity51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Sese038001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Sese038001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Sese038001.QuantityAndAccount113


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Sese038001.QuantityBreakdown62>||XmlElement()||
|+|SfkpgPlc|ISO20022.Sese038001.SafeKeepingPlace5||XmlElement()||
|+|CshAcct|ISO20022.Sese038001.CashAccountIdentification9Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese038001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese038001.SecuritiesAccount19||XmlElement()||
|+|AcctOwnr|ISO20022.Sese038001.PartyIdentification144||XmlElement()||
|+|DnmtnChc|String||XmlElement()||
|+|SttlmQty|ISO20022.Sese038001.Quantity51Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(SfkpgPlc),validElement(CshAcct),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(SttlmQty))|

---

## Value ISO20022.Sese038001.QuantityAndAccount118


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Sese038001.QuantityBreakdown62>||XmlElement()||
|+|SfkpgPlc|ISO20022.Sese038001.SafeKeepingPlace5||XmlElement()||
|+|CshAcct|ISO20022.Sese038001.CashAccountIdentification9Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Sese038001.PartyIdentification144||XmlElement()||
|+|DnmtnChc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(SfkpgPlc),validElement(CshAcct),validElement(AcctOwnr))|

---

## Value ISO20022.Sese038001.QuantityBreakdown62


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TpOfPric|ISO20022.Sese038001.TypeOfPrice29Choice||XmlElement()||
|+|LotPric|ISO20022.Sese038001.Price7||XmlElement()||
|+|LotDtTm|ISO20022.Sese038001.DateAndDateTime2Choice||XmlElement()||
|+|LotQty|ISO20022.Sese038001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|LotNb|ISO20022.Sese038001.GenericIdentification37||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TpOfPric),validElement(LotPric),validElement(LotDtTm),validElement(LotQty),validElement(LotNb))|

---

## Enum ISO20022.Sese038001.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Sese038001.References47Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|IntraPosMvmntId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|SctiesSttlmTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OthrTxId,AcctSvcrTxId,IntraPosMvmntId,PoolId,SctiesSttlmTxId))|

---

## Enum ISO20022.Sese038001.Registration1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YREG|Int32||XmlEnum("""YREG""")|1|
||NREG|Int32||XmlEnum("""NREG""")|2|

---

## Value ISO20022.Sese038001.Registration9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.RegistrationParameters6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertNb|global::System.Collections.Generic.List<ISO20022.Sese038001.SecuritiesCertificate4>||XmlElement()||
|+|RegarAcct|String||XmlElement()||
|+|CertfctnDtTm|ISO20022.Sese038001.DateAndDateTime2Choice||XmlElement()||
|+|CertfctnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CertNb""",CertNb),validElement(CertNb),validElement(CertfctnDtTm))|

---

## Enum ISO20022.Sese038001.Reporting2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DEFR|Int32||XmlEnum("""DEFR""")|1|
||REGU|Int32||XmlEnum("""REGU""")|2|
||STEX|Int32||XmlEnum("""STEX""")|3|

---

## Value ISO20022.Sese038001.Reporting6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.Restriction5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.SafeKeepingPlace5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Sese038001.SafekeepingPlaceFormat41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Sese038001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Sese038001.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Sese038001.SafekeepingPlaceFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Sese038001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Sese038001.SafekeepingPlaceTypeAndText8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Sese038001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese038001.SafekeepingPlaceTypeAndText8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese038001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese038001.SecuritiesCertificate4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Sese038001.SecuritiesPaymentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NILL|Int32||XmlEnum("""NILL""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Sese038001.SecuritiesPaymentStatus5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese038001.SupplementaryData1>||XmlElement()||
|+|AddtlPhysOrRegnDtls|ISO20022.Sese038001.RegistrationParameters6||XmlElement()||
|+|OthrBizPties|ISO20022.Sese038001.OtherParties43||XmlElement()||
|+|OthrAmts|ISO20022.Sese038001.OtherAmounts39||XmlElement()||
|+|SttlmAmt|ISO20022.Sese038001.AmountAndDirection95||XmlElement()||
|+|CshPties|ISO20022.Sese038001.CashParties41||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese038001.SettlementParties98||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese038001.SettlementParties98||XmlElement()||
|+|StgSttlmInstrDtls|ISO20022.Sese038001.StandingSettlementInstruction20||XmlElement()||
|+|SttlmParams|ISO20022.Sese038001.SettlementDetails218||XmlElement()||
|+|QtyAndAcctDtls|ISO20022.Sese038001.QuantityAndAccount118||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Sese038001.FinancialInstrumentAttributes111||XmlElement()||
|+|TradDtls|ISO20022.Sese038001.SecuritiesTradeDetails146||XmlElement()||
|+|Lnkgs|global::System.Collections.Generic.List<ISO20022.Sese038001.Linkages63>||XmlElement()||
|+|SttlmTpAndAddtlParams|ISO20022.Sese038001.SettlementTypeAndAdditionalParameters13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AddtlPhysOrRegnDtls),validElement(OthrBizPties),validElement(OthrAmts),validElement(SttlmAmt),validElement(CshPties),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(StgSttlmInstrDtls),validElement(SttlmParams),validElement(QtyAndAcctDtls),validElement(FinInstrmAttrbts),validElement(TradDtls),validList("""Lnkgs""",Lnkgs),validElement(Lnkgs),validElement(SttlmTpAndAddtlParams))|

---

## Value ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese038001.SupplementaryData1>||XmlElement()||
|+|AddtlPhysOrRegnDtls|ISO20022.Sese038001.RegistrationParameters6||XmlElement()||
|+|OthrBizPties|ISO20022.Sese038001.OtherParties43||XmlElement()||
|+|OthrAmts|ISO20022.Sese038001.OtherAmounts39||XmlElement()||
|+|SttlmAmt|ISO20022.Sese038001.AmountAndDirection95||XmlElement()||
|+|CshPties|ISO20022.Sese038001.CashParties41||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese038001.SettlementParties126||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese038001.SettlementParties126||XmlElement()||
|+|StgSttlmInstrDtls|ISO20022.Sese038001.StandingSettlementInstruction20||XmlElement()||
|+|SttlmParams|ISO20022.Sese038001.SettlementDetails218||XmlElement()||
|+|QtyAndAcctDtls|ISO20022.Sese038001.QuantityAndAccount113||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Sese038001.FinancialInstrumentAttributes111||XmlElement()||
|+|FinInstrmId|ISO20022.Sese038001.SecurityIdentification19||XmlElement()||
|+|TradDtls|ISO20022.Sese038001.SecuritiesTradeDetails147||XmlElement()||
|+|Lnkgs|global::System.Collections.Generic.List<ISO20022.Sese038001.Linkages63>||XmlElement()||
|+|SttlmTpAndAddtlParams|ISO20022.Sese038001.SettlementTypeAndAdditionalParameters14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AddtlPhysOrRegnDtls),validElement(OthrBizPties),validElement(OthrAmts),validElement(SttlmAmt),validElement(CshPties),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(StgSttlmInstrDtls),validElement(SttlmParams),validElement(QtyAndAcctDtls),validElement(FinInstrmAttrbts),validElement(FinInstrmId),validElement(TradDtls),validList("""Lnkgs""",Lnkgs),validElement(Lnkgs),validElement(SttlmTpAndAddtlParams))|

---

## Value ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese038001.SupplementaryData1>||XmlElement()||
|+|AddtlPhysOrRegnDtls|ISO20022.Sese038001.RegistrationParameters6||XmlElement()||
|+|OthrBizPties|ISO20022.Sese038001.OtherParties43||XmlElement()||
|+|OthrAmts|ISO20022.Sese038001.OtherAmounts39||XmlElement()||
|+|SttlmAmt|ISO20022.Sese038001.AmountAndDirection95||XmlElement()||
|+|CshPties|ISO20022.Sese038001.CashParties41||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese038001.SettlementParties98||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese038001.SettlementParties98||XmlElement()||
|+|StgSttlmInstrDtls|ISO20022.Sese038001.StandingSettlementInstruction20||XmlElement()||
|+|SttlmParams|ISO20022.Sese038001.SettlementDetails218||XmlElement()||
|+|QtyAndAcctDtls|ISO20022.Sese038001.QuantityAndAccount118||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Sese038001.FinancialInstrumentAttributes111||XmlElement()||
|+|TradDtls|ISO20022.Sese038001.SecuritiesTradeDetails146||XmlElement()||
|+|Lnkgs|global::System.Collections.Generic.List<ISO20022.Sese038001.Linkages40>||XmlElement()||
|+|SttlmTpAndAddtlParams|ISO20022.Sese038001.SettlementTypeAndAdditionalParameters13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AddtlPhysOrRegnDtls),validElement(OthrBizPties),validElement(OthrAmts),validElement(SttlmAmt),validElement(CshPties),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(StgSttlmInstrDtls),validElement(SttlmParams),validElement(QtyAndAcctDtls),validElement(FinInstrmAttrbts),validElement(TradDtls),validList("""Lnkgs""",Lnkgs),validElement(Lnkgs),validElement(SttlmTpAndAddtlParams))|

---

## Aspect ISO20022.Sese038001.SecuritiesSettlementTransactionModificationRequestV10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UpdTp|global::System.Collections.Generic.List<ISO20022.Sese038001.UpdateType39Choice>||XmlElement()||
|+|ModfdTxDtls|ISO20022.Sese038001.TransactionDetails176||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""UpdTp""",UpdTp),validList("""UpdTp""",UpdTp),validListMax("""UpdTp""",UpdTp,3),validElement(UpdTp),validElement(ModfdTxDtls))|

---

## Value ISO20022.Sese038001.SecuritiesTradeDetails146


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmInstrPrcgAddtlDtls|String||XmlElement()||
|+|FxAddtlDtls|String||XmlElement()||
|+|AffirmSts|ISO20022.Sese038001.AffirmationStatus8Choice||XmlElement()||
|+|MtchgSts|ISO20022.Sese038001.MatchingStatus27Choice||XmlElement()||
|+|CcyToBuyOrSell|ISO20022.Sese038001.CurrencyToBuyOrSell1Choice||XmlElement()||
|+|TpOfPric|ISO20022.Sese038001.TypeOfPrice29Choice||XmlElement()||
|+|TradOrgtrRole|ISO20022.Sese038001.TradeOriginator3Choice||XmlElement()||
|+|InvstrCpcty|ISO20022.Sese038001.InvestorCapacity4Choice||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Sese038001.TradeTransactionCondition5Choice>||XmlElement()||
|+|Rptg|global::System.Collections.Generic.List<ISO20022.Sese038001.Reporting6Choice>||XmlElement()||
|+|OpngClsg|ISO20022.Sese038001.OpeningClosing3Choice||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|DealPric|ISO20022.Sese038001.Price10||XmlElement()||
|+|LateDlvryDt|ISO20022.Sese038001.DateAndDateTime2Choice||XmlElement()||
|+|TradDt|ISO20022.Sese038001.TradeDate8Choice||XmlElement()||
|+|PlcOfClr|ISO20022.Sese038001.PlaceOfClearingIdentification2||XmlElement()||
|+|PlcOfTrad|ISO20022.Sese038001.PlaceOfTradeIdentification1||XmlElement()||
|+|CollTxId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
|+|TradId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AffirmSts),validElement(MtchgSts),validElement(CcyToBuyOrSell),validElement(TpOfPric),validElement(TradOrgtrRole),validElement(InvstrCpcty),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond),validList("""Rptg""",Rptg),validElement(Rptg),validElement(OpngClsg),validElement(DealPric),validElement(LateDlvryDt),validElement(TradDt),validElement(PlcOfClr),validElement(PlcOfTrad),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""))|

---

## Value ISO20022.Sese038001.SecuritiesTradeDetails147


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmInstrPrcgAddtlDtls|String||XmlElement()||
|+|FxAddtlDtls|String||XmlElement()||
|+|AffirmSts|ISO20022.Sese038001.AffirmationStatus8Choice||XmlElement()||
|+|MtchgSts|ISO20022.Sese038001.MatchingStatus27Choice||XmlElement()||
|+|CcyToBuyOrSell|ISO20022.Sese038001.CurrencyToBuyOrSell1Choice||XmlElement()||
|+|TpOfPric|ISO20022.Sese038001.TypeOfPrice29Choice||XmlElement()||
|+|TradOrgtrRole|ISO20022.Sese038001.TradeOriginator3Choice||XmlElement()||
|+|InvstrCpcty|ISO20022.Sese038001.InvestorCapacity4Choice||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Sese038001.TradeTransactionCondition5Choice>||XmlElement()||
|+|Rptg|global::System.Collections.Generic.List<ISO20022.Sese038001.Reporting6Choice>||XmlElement()||
|+|OpngClsg|ISO20022.Sese038001.OpeningClosing3Choice||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|DealPric|ISO20022.Sese038001.Price10||XmlElement()||
|+|LateDlvryDt|ISO20022.Sese038001.DateAndDateTime2Choice||XmlElement()||
|+|SttlmDt|ISO20022.Sese038001.SettlementDate17Choice||XmlElement()||
|+|TradDt|ISO20022.Sese038001.TradeDate8Choice||XmlElement()||
|+|PlcOfClr|ISO20022.Sese038001.PlaceOfClearingIdentification2||XmlElement()||
|+|PlcOfTrad|ISO20022.Sese038001.PlaceOfTradeIdentification1||XmlElement()||
|+|CollTxId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
|+|TradId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AffirmSts),validElement(MtchgSts),validElement(CcyToBuyOrSell),validElement(TpOfPric),validElement(TradOrgtrRole),validElement(InvstrCpcty),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond),validList("""Rptg""",Rptg),validElement(Rptg),validElement(OpngClsg),validElement(DealPric),validElement(LateDlvryDt),validElement(SttlmDt),validElement(TradDt),validElement(PlcOfClr),validElement(PlcOfTrad),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""))|

---

## Enum ISO20022.Sese038001.SecuritiesTransactionType28Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INTT|Int32||XmlEnum("""INTT""")|1|
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

## Value ISO20022.Sese038001.SecuritiesTransactionType59Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese038001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese038001.SettlementDate17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese038001.SettlementDateCode7Choice||XmlElement()||
|+|Dt|ISO20022.Sese038001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Sese038001.SettlementDate4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WISS|Int32||XmlEnum("""WISS""")|1|

---

## Value ISO20022.Sese038001.SettlementDateCode7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.SettlementDetails218


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshSubBalTp|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|SctiesSubBalTp|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|ElgblForColl|String||XmlElement()||
|+|ModCxlAllwd|ISO20022.Sese038001.ModificationCancellationAllowed4Choice||XmlElement()||
|+|RtrLeg|String||XmlElement()||
|+|LttrOfGrnt|ISO20022.Sese038001.LetterOfGuarantee4Choice||XmlElement()||
|+|Trckg|ISO20022.Sese038001.Tracking4Choice||XmlElement()||
|+|StmpDtyTaxBsis|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|TaxCpcty|ISO20022.Sese038001.TaxCapacityParty4Choice||XmlElement()||
|+|SttlgCpcty|ISO20022.Sese038001.SettlingCapacity7Choice||XmlElement()||
|+|LglRstrctns|ISO20022.Sese038001.Restriction5Choice||XmlElement()||
|+|Regn|ISO20022.Sese038001.Registration9Choice||XmlElement()||
|+|NetgElgblty|ISO20022.Sese038001.NettingEligibility4Choice||XmlElement()||
|+|MktClntSd|ISO20022.Sese038001.MarketClientSide6Choice||XmlElement()||
|+|FxStgInstr|ISO20022.Sese038001.FXStandingInstruction4Choice||XmlElement()||
|+|XpsrTp|ISO20022.Sese038001.ExposureType25Choice||XmlElement()||
|+|CshClrSys|ISO20022.Sese038001.CashSettlementSystem4Choice||XmlElement()||
|+|DlvryRtrRsn|ISO20022.Sese038001.DeliveryReturn3Choice||XmlElement()||
|+|CCPElgblty|ISO20022.Sese038001.CentralCounterPartyEligibility4Choice||XmlElement()||
|+|BnfclOwnrsh|ISO20022.Sese038001.BeneficialOwnership4Choice||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese038001.SettlementTransactionCondition16Choice>||XmlElement()||
|+|SctiesTxTp|ISO20022.Sese038001.SecuritiesTransactionType59Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshSubBalTp),validElement(SctiesSubBalTp),validElement(ModCxlAllwd),validElement(LttrOfGrnt),validElement(Trckg),validElement(StmpDtyTaxBsis),validElement(TaxCpcty),validElement(SttlgCpcty),validElement(LglRstrctns),validElement(Regn),validElement(NetgElgblty),validElement(MktClntSd),validElement(FxStgInstr),validElement(XpsrTp),validElement(CshClrSys),validElement(DlvryRtrRsn),validElement(CCPElgblty),validElement(BnfclOwnrsh),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validElement(SctiesTxTp))|

---

## Value ISO20022.Sese038001.SettlementParties125


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese038001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty4|ISO20022.Sese038001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty3|ISO20022.Sese038001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty2|ISO20022.Sese038001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty1|ISO20022.Sese038001.PartyIdentificationAndAccount195||XmlElement()||
|+|Dpstry|ISO20022.Sese038001.PartyIdentification314||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Value ISO20022.Sese038001.SettlementParties126


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese038001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty4|ISO20022.Sese038001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty3|ISO20022.Sese038001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty2|ISO20022.Sese038001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty1|ISO20022.Sese038001.PartyIdentificationAndAccount196||XmlElement()||
|+|Dpstry|ISO20022.Sese038001.PartyIdentification315||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Value ISO20022.Sese038001.SettlementParties98


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese038001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty4|ISO20022.Sese038001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty3|ISO20022.Sese038001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty2|ISO20022.Sese038001.PartyIdentificationAndAccount196||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2))|

---

## Enum ISO20022.Sese038001.SettlementStandingInstructionDatabase1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VEND|Int32||XmlEnum("""VEND""")|1|
||BRKR|Int32||XmlEnum("""BRKR""")|2|
||INTE|Int32||XmlEnum("""INTE""")|3|

---

## Value ISO20022.Sese038001.SettlementStandingInstructionDatabase4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese038001.SettlementTransactionCondition10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNEX|Int32||XmlEnum("""UNEX""")|1|
||TRIP|Int32||XmlEnum("""TRIP""")|2|
||TRAN|Int32||XmlEnum("""TRAN""")|3|
||SPST|Int32||XmlEnum("""SPST""")|4|
||SPDL|Int32||XmlEnum("""SPDL""")|5|
||SHOR|Int32||XmlEnum("""SHOR""")|6|
||RESI|Int32||XmlEnum("""RESI""")|7|
||RPTO|Int32||XmlEnum("""RPTO""")|8|
||RHYP|Int32||XmlEnum("""RHYP""")|9|
||PHYS|Int32||XmlEnum("""PHYS""")|10|
||PENS|Int32||XmlEnum("""PENS""")|11|
||NACT|Int32||XmlEnum("""NACT""")|12|
||NOMC|Int32||XmlEnum("""NOMC""")|13|
||KNOC|Int32||XmlEnum("""KNOC""")|14|
||FRCL|Int32||XmlEnum("""FRCL""")|15|
||EXPI|Int32||XmlEnum("""EXPI""")|16|
||EXER|Int32||XmlEnum("""EXER""")|17|
||DRAW|Int32||XmlEnum("""DRAW""")|18|
||DIRT|Int32||XmlEnum("""DIRT""")|19|
||DLWM|Int32||XmlEnum("""DLWM""")|20|
||CLEN|Int32||XmlEnum("""CLEN""")|21|
||BUTC|Int32||XmlEnum("""BUTC""")|22|
||ASGN|Int32||XmlEnum("""ASGN""")|23|
||ADEA|Int32||XmlEnum("""ADEA""")|24|

---

## Value ISO20022.Sese038001.SettlementTransactionCondition16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.SettlementTypeAndAdditionalParameters13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcncltnInd|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
|+|CmonId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese038001.SettlementTypeAndAdditionalParameters14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcncltnInd|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
|+|CmonId|String||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese038001.SettlementTypeAndIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Sese038001.SettlingCapacity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RISP|Int32||XmlEnum("""RISP""")|1|
||SPRI|Int32||XmlEnum("""SPRI""")|2|
||CUST|Int32||XmlEnum("""CUST""")|3|
||SAGE|Int32||XmlEnum("""SAGE""")|4|

---

## Value ISO20022.Sese038001.SettlingCapacity7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.StandingSettlementInstruction20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrRcvgSttlmPties|ISO20022.Sese038001.SettlementParties126||XmlElement()||
|+|OthrDlvrgSttlmPties|ISO20022.Sese038001.SettlementParties126||XmlElement()||
|+|Vndr|ISO20022.Sese038001.PartyIdentification136||XmlElement()||
|+|CtrPty|ISO20022.Sese038001.Counterparty15Choice||XmlElement()||
|+|SttlmStgInstrDB|ISO20022.Sese038001.SettlementStandingInstructionDatabase4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrRcvgSttlmPties),validElement(OthrDlvrgSttlmPties),validElement(Vndr),validElement(CtrPty),validElement(SttlmStgInstrDB))|

---

## Value ISO20022.Sese038001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese038001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese038001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese038001.TaxCapacityParty4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese038001.TaxLiability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGEN|Int32||XmlEnum("""AGEN""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Sese038001.Tracking4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese038001.TradeDate8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese038001.TradeDateCode3Choice||XmlElement()||
|+|Dt|ISO20022.Sese038001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese038001.TradeDateCode3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.TradeOriginator3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese038001.TradeTransactionCondition4Code


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

## Value ISO20022.Sese038001.TradeTransactionCondition5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.TransactionDetails172


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Invstr|ISO20022.Sese038001.PartyIdentification149||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese038001.SettlementParties125||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese038001.SettlementParties125||XmlElement()||
|+|SttlmAmt|ISO20022.Sese038001.AmountAndDirection51||XmlElement()||
|+|SttlmQty|ISO20022.Sese038001.Quantity51Choice||XmlElement()||
|+|SttlmDt|ISO20022.Sese038001.SettlementDate17Choice||XmlElement()||
|+|TradDt|ISO20022.Sese038001.TradeDate8Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Sese038001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Invstr),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(SttlmAmt),validElement(SttlmQty),validElement(SttlmDt),validElement(TradDt),validElement(FinInstrmId))|

---

## Value ISO20022.Sese038001.TransactionDetails176


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxDtls|ISO20022.Sese038001.TransactionDetails172||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese038001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese038001.SecuritiesAccount19||XmlElement()||
|+|AcctOwnr|ISO20022.Sese038001.PartyIdentification144||XmlElement()||
|+|OthrTxId|String||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|ISO20022.Sese038001.SettlementTypeAndIdentification18||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxDtls),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(AcctOwnrTxId))|

---

## Enum ISO20022.Sese038001.TypeOfIdentification1Code


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

## Enum ISO20022.Sese038001.TypeOfPrice14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AVER|Int32||XmlEnum("""AVER""")|1|

---

## Value ISO20022.Sese038001.TypeOfPrice29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese038001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese038001.UpdateType39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Mod|ISO20022.Sese038001.SecuritiesSettlementTransactionDetails57||XmlElement()||
|+|Deltn|ISO20022.Sese038001.SecuritiesSettlementTransactionDetails58||XmlElement()||
|+|Addtn|ISO20022.Sese038001.SecuritiesSettlementTransactionDetails56||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Mod),validElement(Deltn),validElement(Addtn),validChoice(Mod,Deltn,Addtn))|

---

## Value ISO20022.Sese038001.YieldedOrValueType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValTp|String||XmlElement()||
|+|Yldd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(ValTp,Yldd))|

---

## Value ISO20022.Sese038001.YieldedOrValueType2Choice


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

