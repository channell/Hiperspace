# sese.037.002.07
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese037002.AcknowledgedAcceptedStatus32Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese037002.AcknowledgementReason20~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese037002.AcknowledgedAcceptedStatus32Choice *-- ISO20022.Sese037002.AcknowledgementReason20
    class ISO20022.Sese037002.AcknowledgementReason20 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese037002.AcknowledgementReason23Choice
    }
    ISO20022.Sese037002.AcknowledgementReason20 *-- ISO20022.Sese037002.AcknowledgementReason23Choice
    class ISO20022.Sese037002.AcknowledgementReason23Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037002.AcknowledgementReason23Choice *-- ISO20022.Sese037002.GenericIdentification30
    class ISO20022.Sese037002.AcknowledgementReason9Code {
        OTHR = 1
    }
    class ISO20022.Sese037002.AlternatePartyIdentification9 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Sese037002.IdentificationType44Choice
    }
    ISO20022.Sese037002.AlternatePartyIdentification9 *-- ISO20022.Sese037002.IdentificationType44Choice
    class ISO20022.Sese037002.AmountAndDirection57 {
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese037002.RestrictedFINActiveCurrencyAndAmount
    }
    ISO20022.Sese037002.AmountAndDirection57 *-- ISO20022.Sese037002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese037002.AmountAndDirection58 {
        + FXDtls  : ISO20022.Sese037002.ForeignExchangeTerms27
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese037002.RestrictedFINActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese037002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Sese037002.AmountAndDirection58 *-- ISO20022.Sese037002.ForeignExchangeTerms27
    ISO20022.Sese037002.AmountAndDirection58 *-- ISO20022.Sese037002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese037002.AmountAndDirection58 *-- ISO20022.Sese037002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese037002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Sese037002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese037002.BlockChainAddressWallet7 *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.ClassificationType33Choice {
        + AltrnClssfctn  : ISO20022.Sese037002.GenericIdentification86
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Sese037002.ClassificationType33Choice *-- ISO20022.Sese037002.GenericIdentification86
    class ISO20022.Sese037002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese037002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese037002.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese037002.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese037002.EventFrequency3Code {
        WEEK = 1
        SEMI = 2
        QUTR = 3
        MNTH = 4
        YEAR = 5
    }
    class ISO20022.Sese037002.FinancialInstrumentAttributes122 {
        + FinInstrmAttrAddtlDtls  : String
        + UndrlygFinInstrmId  : global::System.Collections.Generic.List~ISO20022.Sese037002.SecurityIdentification20~
        + CtrctSz  : ISO20022.Sese037002.FinancialInstrumentQuantity36Choice
        + MinNmnlQty  : ISO20022.Sese037002.FinancialInstrumentQuantity36Choice
        + StrkPric  : ISO20022.Sese037002.Price3
        + ConvsPric  : ISO20022.Sese037002.Price3
        + SbcptPric  : ISO20022.Sese037002.Price3
        + ExrcPric  : ISO20022.Sese037002.Price3
        + MktOrIndctvPric  : ISO20022.Sese037002.PriceType5Choice
        + PutblInd  : String
        + CllblInd  : String
        + VarblRateInd  : String
        + PoolNb  : ISO20022.Sese037002.GenericIdentification39
        + CpnAttchdNb  : ISO20022.Sese037002.Number23Choice
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
        + OptnTp  : ISO20022.Sese037002.OptionType7Choice
        + OptnStyle  : ISO20022.Sese037002.OptionStyle9Choice
        + ClssfctnTp  : ISO20022.Sese037002.ClassificationType33Choice
        + VarblRateChngFrqcy  : ISO20022.Sese037002.Frequency27Choice
        + PmtSts  : ISO20022.Sese037002.SecuritiesPaymentStatus6Choice
        + PmtFrqcy  : ISO20022.Sese037002.Frequency27Choice
        + RegnForm  : ISO20022.Sese037002.FormOfSecurity7Choice
        + DayCntBsis  : ISO20022.Sese037002.InterestComputationMethodFormat5Choice
        + PlcOfListg  : ISO20022.Sese037002.MarketIdentification4Choice
    }
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.SecurityIdentification20
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.FinancialInstrumentQuantity36Choice
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.FinancialInstrumentQuantity36Choice
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.Price3
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.Price3
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.Price3
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.Price3
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.PriceType5Choice
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.GenericIdentification39
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.Number23Choice
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.OptionType7Choice
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.OptionStyle9Choice
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.ClassificationType33Choice
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.Frequency27Choice
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.SecuritiesPaymentStatus6Choice
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.Frequency27Choice
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.FormOfSecurity7Choice
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.InterestComputationMethodFormat5Choice
    ISO20022.Sese037002.FinancialInstrumentAttributes122 *-- ISO20022.Sese037002.MarketIdentification4Choice
    class ISO20022.Sese037002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese037002.ForeignExchangeTerms27 {
        + RsltgAmt  : ISO20022.Sese037002.RestrictedFINActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Sese037002.ForeignExchangeTerms27 *-- ISO20022.Sese037002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese037002.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Sese037002.FormOfSecurity7Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.FormOfSecurity7Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.Frequency27Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.Frequency27Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.GenericIdentification18 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Sese037002.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese037002.GenericIdentification39 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese037002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese037002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese037002.GenericIdentification86 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese037002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese037002.IdentificationType44Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.IdentificationType44Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.InterestComputationMethod2Code {
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
    class ISO20022.Sese037002.InterestComputationMethodFormat5Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.InterestComputationMethodFormat5Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.MarketIdentification4Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese037002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Sese037002.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Sese037002.Number23Choice {
        + Lng  : ISO20022.Sese037002.GenericIdentification18
        + Shrt  : String
    }
    ISO20022.Sese037002.Number23Choice *-- ISO20022.Sese037002.GenericIdentification18
    class ISO20022.Sese037002.Number3Choice {
        + Lng  : String
        + Shrt  : String
    }
    class ISO20022.Sese037002.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Sese037002.OptionStyle9Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.OptionStyle9Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Sese037002.OptionType7Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.OptionType7Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.OtherAmounts33 {
        + AcrdCptlstnAmt  : ISO20022.Sese037002.AmountAndDirection58
        + CsmptnTax  : ISO20022.Sese037002.AmountAndDirection58
        + WhldgTax  : ISO20022.Sese037002.AmountAndDirection58
        + ValAddedTax  : ISO20022.Sese037002.AmountAndDirection58
        + TxTax  : ISO20022.Sese037002.AmountAndDirection58
        + TrfTax  : ISO20022.Sese037002.AmountAndDirection58
        + StockXchgTax  : ISO20022.Sese037002.AmountAndDirection58
        + StmpDty  : ISO20022.Sese037002.AmountAndDirection58
        + ShppgAmt  : ISO20022.Sese037002.AmountAndDirection58
        + RgltryAmt  : ISO20022.Sese037002.AmountAndDirection58
        + Othr  : ISO20022.Sese037002.AmountAndDirection58
        + LclTax  : ISO20022.Sese037002.AmountAndDirection58
        + PmtLevyTax  : ISO20022.Sese037002.AmountAndDirection58
        + CtryNtlFdrlTax  : ISO20022.Sese037002.AmountAndDirection58
        + ChrgsFees  : ISO20022.Sese037002.AmountAndDirection58
        + AcrdIntrstAmt  : ISO20022.Sese037002.AmountAndDirection58
    }
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    ISO20022.Sese037002.OtherAmounts33 *-- ISO20022.Sese037002.AmountAndDirection58
    class ISO20022.Sese037002.OtherIdentification2 {
        + Tp  : ISO20022.Sese037002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese037002.OtherIdentification2 *-- ISO20022.Sese037002.IdentificationSource4Choice
    class ISO20022.Sese037002.OtherParties42 {
        + TradRgltr  : ISO20022.Sese037002.PartyIdentification157
        + StockXchg  : ISO20022.Sese037002.PartyIdentification157
        + Invstr  : ISO20022.Sese037002.PartyIdentification170
    }
    ISO20022.Sese037002.OtherParties42 *-- ISO20022.Sese037002.PartyIdentification157
    ISO20022.Sese037002.OtherParties42 *-- ISO20022.Sese037002.PartyIdentification157
    ISO20022.Sese037002.OtherParties42 *-- ISO20022.Sese037002.PartyIdentification170
    class ISO20022.Sese037002.OwnershipLegalRestrictions1Code {
        RSTR = 1
        NRST = 2
        A144 = 3
    }
    class ISO20022.Sese037002.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Sese037002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Sese037002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese037002.PartyIdentification136Choice *-- ISO20022.Sese037002.GenericIdentification84
    class ISO20022.Sese037002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Sese037002.NameAndAddress12
        + PrtryId  : ISO20022.Sese037002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese037002.PartyIdentification137Choice *-- ISO20022.Sese037002.NameAndAddress12
    ISO20022.Sese037002.PartyIdentification137Choice *-- ISO20022.Sese037002.GenericIdentification84
    class ISO20022.Sese037002.PartyIdentification145Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese037002.NameAndAddress12
        + AnyBIC  : String
    }
    ISO20022.Sese037002.PartyIdentification145Choice *-- ISO20022.Sese037002.NameAndAddress12
    class ISO20022.Sese037002.PartyIdentification156 {
        + LEI  : String
        + Id  : ISO20022.Sese037002.PartyIdentification136Choice
    }
    ISO20022.Sese037002.PartyIdentification156 *-- ISO20022.Sese037002.PartyIdentification136Choice
    class ISO20022.Sese037002.PartyIdentification157 {
        + LEI  : String
        + Id  : ISO20022.Sese037002.PartyIdentification137Choice
    }
    ISO20022.Sese037002.PartyIdentification157 *-- ISO20022.Sese037002.PartyIdentification137Choice
    class ISO20022.Sese037002.PartyIdentification162 {
        + AddtlInf  : ISO20022.Sese037002.PartyTextInformation3
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese037002.DateAndDateTime2Choice
        + AltrnId  : ISO20022.Sese037002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese037002.PartyIdentification145Choice
    }
    ISO20022.Sese037002.PartyIdentification162 *-- ISO20022.Sese037002.PartyTextInformation3
    ISO20022.Sese037002.PartyIdentification162 *-- ISO20022.Sese037002.DateAndDateTime2Choice
    ISO20022.Sese037002.PartyIdentification162 *-- ISO20022.Sese037002.AlternatePartyIdentification9
    ISO20022.Sese037002.PartyIdentification162 *-- ISO20022.Sese037002.PartyIdentification145Choice
    class ISO20022.Sese037002.PartyIdentification170 {
        + LEI  : String
        + Id  : ISO20022.Sese037002.PartyIdentification176Choice
    }
    ISO20022.Sese037002.PartyIdentification170 *-- ISO20022.Sese037002.PartyIdentification176Choice
    class ISO20022.Sese037002.PartyIdentification176Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese037002.NameAndAddress12
        + PrtryId  : ISO20022.Sese037002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese037002.PartyIdentification176Choice *-- ISO20022.Sese037002.NameAndAddress12
    ISO20022.Sese037002.PartyIdentification176Choice *-- ISO20022.Sese037002.GenericIdentification84
    class ISO20022.Sese037002.PartyIdentificationAndAccount206 {
        + AddtlInf  : ISO20022.Sese037002.PartyTextInformation3
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese037002.DateAndDateTime2Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese037002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese037002.SecuritiesAccount30
        + AltrnId  : ISO20022.Sese037002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese037002.PartyIdentification137Choice
    }
    ISO20022.Sese037002.PartyIdentificationAndAccount206 *-- ISO20022.Sese037002.PartyTextInformation3
    ISO20022.Sese037002.PartyIdentificationAndAccount206 *-- ISO20022.Sese037002.DateAndDateTime2Choice
    ISO20022.Sese037002.PartyIdentificationAndAccount206 *-- ISO20022.Sese037002.BlockChainAddressWallet7
    ISO20022.Sese037002.PartyIdentificationAndAccount206 *-- ISO20022.Sese037002.SecuritiesAccount30
    ISO20022.Sese037002.PartyIdentificationAndAccount206 *-- ISO20022.Sese037002.AlternatePartyIdentification9
    ISO20022.Sese037002.PartyIdentificationAndAccount206 *-- ISO20022.Sese037002.PartyIdentification137Choice
    class ISO20022.Sese037002.PartyTextInformation3 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese037002.PendingFailingReason1Code {
        OTHR = 1
    }
    class ISO20022.Sese037002.PendingProcessingReason14 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese037002.PendingProcessingReason16Choice
    }
    ISO20022.Sese037002.PendingProcessingReason14 *-- ISO20022.Sese037002.PendingProcessingReason16Choice
    class ISO20022.Sese037002.PendingProcessingReason16Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037002.PendingProcessingReason16Choice *-- ISO20022.Sese037002.GenericIdentification30
    class ISO20022.Sese037002.PendingProcessingStatus17Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese037002.PendingProcessingReason14~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese037002.PendingProcessingStatus17Choice *-- ISO20022.Sese037002.PendingProcessingReason14
    class ISO20022.Sese037002.PortfolioTransferNotification002V07 {
        + TrfNtfctnDtls  : global::System.Collections.Generic.List~ISO20022.Sese037002.SecuritiesTradeDetails139~
        + BlckChainAdrOrWllt  : ISO20022.Sese037002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese037002.SecuritiesAccount30
        + AcctOwnr  : ISO20022.Sese037002.PartyIdentification156
        + StmtGnlDtls  : ISO20022.Sese037002.Statement68
        + Pgntn  : ISO20022.Sese037002.Pagination1
    }
    ISO20022.Sese037002.PortfolioTransferNotification002V07 *-- ISO20022.Sese037002.SecuritiesTradeDetails139
    ISO20022.Sese037002.PortfolioTransferNotification002V07 *-- ISO20022.Sese037002.BlockChainAddressWallet7
    ISO20022.Sese037002.PortfolioTransferNotification002V07 *-- ISO20022.Sese037002.SecuritiesAccount30
    ISO20022.Sese037002.PortfolioTransferNotification002V07 *-- ISO20022.Sese037002.PartyIdentification156
    ISO20022.Sese037002.PortfolioTransferNotification002V07 *-- ISO20022.Sese037002.Statement68
    ISO20022.Sese037002.PortfolioTransferNotification002V07 *-- ISO20022.Sese037002.Pagination1
    class ISO20022.Sese037002.PortfolioTransferStatus2Choice {
        + Prtry  : ISO20022.Sese037002.ProprietaryStatusAndReason6
        + Rjctd  : ISO20022.Sese037002.RejectionStatus30Choice
        + PdgPrcg  : ISO20022.Sese037002.PendingProcessingStatus17Choice
        + AckdAccptd  : ISO20022.Sese037002.AcknowledgedAcceptedStatus32Choice
    }
    ISO20022.Sese037002.PortfolioTransferStatus2Choice *-- ISO20022.Sese037002.ProprietaryStatusAndReason6
    ISO20022.Sese037002.PortfolioTransferStatus2Choice *-- ISO20022.Sese037002.RejectionStatus30Choice
    ISO20022.Sese037002.PortfolioTransferStatus2Choice *-- ISO20022.Sese037002.PendingProcessingStatus17Choice
    ISO20022.Sese037002.PortfolioTransferStatus2Choice *-- ISO20022.Sese037002.AcknowledgedAcceptedStatus32Choice
    class ISO20022.Sese037002.Price3 {
        + Val  : ISO20022.Sese037002.PriceRateOrAmount1Choice
        + Tp  : ISO20022.Sese037002.YieldedOrValueType1Choice
    }
    ISO20022.Sese037002.Price3 *-- ISO20022.Sese037002.PriceRateOrAmount1Choice
    ISO20022.Sese037002.Price3 *-- ISO20022.Sese037002.YieldedOrValueType1Choice
    class ISO20022.Sese037002.PriceRateOrAmount1Choice {
        + Amt  : ISO20022.Sese037002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Sese037002.PriceRateOrAmount1Choice *-- ISO20022.Sese037002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Sese037002.PriceType5Choice {
        + Indctv  : ISO20022.Sese037002.Price3
        + Mkt  : ISO20022.Sese037002.Price3
    }
    ISO20022.Sese037002.PriceType5Choice *-- ISO20022.Sese037002.Price3
    ISO20022.Sese037002.PriceType5Choice *-- ISO20022.Sese037002.Price3
    class ISO20022.Sese037002.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Sese037002.ProprietaryReason4 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Sese037002.GenericIdentification30
    }
    ISO20022.Sese037002.ProprietaryReason4 *-- ISO20022.Sese037002.GenericIdentification30
    class ISO20022.Sese037002.ProprietaryStatusAndReason6 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Sese037002.ProprietaryReason4~
        + PrtrySts  : ISO20022.Sese037002.GenericIdentification30
    }
    ISO20022.Sese037002.ProprietaryStatusAndReason6 *-- ISO20022.Sese037002.ProprietaryReason4
    ISO20022.Sese037002.ProprietaryStatusAndReason6 *-- ISO20022.Sese037002.GenericIdentification30
    class ISO20022.Sese037002.Quantity49 {
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Sese037002.QuantityBreakdown69~
        + CertNb  : global::System.Collections.Generic.List~ISO20022.Sese037002.SecuritiesCertificate5~
        + DnmtnChc  : String
        + SttlmQty  : ISO20022.Sese037002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Sese037002.Quantity49 *-- ISO20022.Sese037002.QuantityBreakdown69
    ISO20022.Sese037002.Quantity49 *-- ISO20022.Sese037002.SecuritiesCertificate5
    ISO20022.Sese037002.Quantity49 *-- ISO20022.Sese037002.FinancialInstrumentQuantity36Choice
    class ISO20022.Sese037002.QuantityBreakdown69 {
        + TpOfPric  : ISO20022.Sese037002.TypeOfPrice32Choice
        + LotPric  : ISO20022.Sese037002.Price3
        + LotDtTm  : ISO20022.Sese037002.DateAndDateTime2Choice
        + LotQty  : ISO20022.Sese037002.FinancialInstrumentQuantity36Choice
        + LotNb  : ISO20022.Sese037002.GenericIdentification39
    }
    ISO20022.Sese037002.QuantityBreakdown69 *-- ISO20022.Sese037002.TypeOfPrice32Choice
    ISO20022.Sese037002.QuantityBreakdown69 *-- ISO20022.Sese037002.Price3
    ISO20022.Sese037002.QuantityBreakdown69 *-- ISO20022.Sese037002.DateAndDateTime2Choice
    ISO20022.Sese037002.QuantityBreakdown69 *-- ISO20022.Sese037002.FinancialInstrumentQuantity36Choice
    ISO20022.Sese037002.QuantityBreakdown69 *-- ISO20022.Sese037002.GenericIdentification39
    class ISO20022.Sese037002.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese037002.Registration11Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.Registration11Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.Registration1Code {
        YREG = 1
        NREG = 2
    }
    class ISO20022.Sese037002.RejectionReason37Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037002.RejectionReason37Choice *-- ISO20022.Sese037002.GenericIdentification30
    class ISO20022.Sese037002.RejectionReason49 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese037002.RejectionReason37Choice
    }
    ISO20022.Sese037002.RejectionReason49 *-- ISO20022.Sese037002.RejectionReason37Choice
    class ISO20022.Sese037002.RejectionReason55Code {
        DSEC = 1
        SSID = 2
        SAFE = 3
        PODU = 4
        OTHR = 5
        DQUA = 6
        CAEV = 7
        BENO = 8
    }
    class ISO20022.Sese037002.RejectionStatus30Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese037002.RejectionReason49~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese037002.RejectionStatus30Choice *-- ISO20022.Sese037002.RejectionReason49
    class ISO20022.Sese037002.Reporting1Code {
        REGU = 1
        STEX = 2
    }
    class ISO20022.Sese037002.Reporting8Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.Reporting8Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese037002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese037002.RestrictedFINActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese037002.Restriction6Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.Restriction6Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.SecuritiesAccount30 {
        + Nm  : String
        + Tp  : ISO20022.Sese037002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese037002.SecuritiesAccount30 *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.SecuritiesCertificate5 {
        + SchmeNm  : String
        + Issr  : String
        + Nb  : String
    }
    class ISO20022.Sese037002.SecuritiesPaymentStatus1Code {
        PART = 1
        NILL = 2
        FULL = 3
    }
    class ISO20022.Sese037002.SecuritiesPaymentStatus6Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.SecuritiesPaymentStatus6Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.SecuritiesRTGS5Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese037002.SecuritiesRTGS5Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.SecuritiesTradeDetails139 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese037002.SupplementaryData1~
        + OthrBizPties  : ISO20022.Sese037002.OtherParties42
        + OthrAmts  : ISO20022.Sese037002.OtherAmounts33
        + SttlmAmt  : ISO20022.Sese037002.AmountAndDirection57
        + RcvgSttlmPties  : ISO20022.Sese037002.SettlementParties104
        + DlvrgSttlmPties  : ISO20022.Sese037002.SettlementParties104
        + SttlmParams  : ISO20022.Sese037002.SettlementDetails103
        + QtyDtls  : ISO20022.Sese037002.Quantity49
        + Rptg  : global::System.Collections.Generic.List~ISO20022.Sese037002.Reporting8Choice~
        + FinInstrmAttrbts  : ISO20022.Sese037002.FinancialInstrumentAttributes122
        + FinInstrmId  : ISO20022.Sese037002.SecurityIdentification20
        + NbOfDaysAcrd  : Decimal
        + SttlmDt  : ISO20022.Sese037002.SettlementDate20Choice
        + TradDt  : ISO20022.Sese037002.TradeDate9Choice
        + Sts  : ISO20022.Sese037002.PortfolioTransferStatus2Choice
        + Pmt  : String
        + SctiesMvmntTp  : String
        + CmonId  : String
        + NtfctnRcvrTxId  : String
        + NtfctnSndrTxId  : String
    }
    ISO20022.Sese037002.SecuritiesTradeDetails139 *-- ISO20022.Sese037002.SupplementaryData1
    ISO20022.Sese037002.SecuritiesTradeDetails139 *-- ISO20022.Sese037002.OtherParties42
    ISO20022.Sese037002.SecuritiesTradeDetails139 *-- ISO20022.Sese037002.OtherAmounts33
    ISO20022.Sese037002.SecuritiesTradeDetails139 *-- ISO20022.Sese037002.AmountAndDirection57
    ISO20022.Sese037002.SecuritiesTradeDetails139 *-- ISO20022.Sese037002.SettlementParties104
    ISO20022.Sese037002.SecuritiesTradeDetails139 *-- ISO20022.Sese037002.SettlementParties104
    ISO20022.Sese037002.SecuritiesTradeDetails139 *-- ISO20022.Sese037002.SettlementDetails103
    ISO20022.Sese037002.SecuritiesTradeDetails139 *-- ISO20022.Sese037002.Quantity49
    ISO20022.Sese037002.SecuritiesTradeDetails139 *-- ISO20022.Sese037002.Reporting8Choice
    ISO20022.Sese037002.SecuritiesTradeDetails139 *-- ISO20022.Sese037002.FinancialInstrumentAttributes122
    ISO20022.Sese037002.SecuritiesTradeDetails139 *-- ISO20022.Sese037002.SecurityIdentification20
    ISO20022.Sese037002.SecuritiesTradeDetails139 *-- ISO20022.Sese037002.SettlementDate20Choice
    ISO20022.Sese037002.SecuritiesTradeDetails139 *-- ISO20022.Sese037002.TradeDate9Choice
    ISO20022.Sese037002.SecuritiesTradeDetails139 *-- ISO20022.Sese037002.PortfolioTransferStatus2Choice
    class ISO20022.Sese037002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese037002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Sese037002.SecurityIdentification20 *-- ISO20022.Sese037002.OtherIdentification2
    class ISO20022.Sese037002.SettlementDate20Choice {
        + DtCd  : ISO20022.Sese037002.SettlementDateCode9Choice
        + Dt  : ISO20022.Sese037002.DateAndDateTime2Choice
    }
    ISO20022.Sese037002.SettlementDate20Choice *-- ISO20022.Sese037002.SettlementDateCode9Choice
    ISO20022.Sese037002.SettlementDate20Choice *-- ISO20022.Sese037002.DateAndDateTime2Choice
    class ISO20022.Sese037002.SettlementDate4Code {
        WISS = 1
    }
    class ISO20022.Sese037002.SettlementDateCode9Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.SettlementDateCode9Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.SettlementDetails103 {
        + StmpDtyTaxBsis  : ISO20022.Sese037002.GenericIdentification47
        + TaxCpcty  : ISO20022.Sese037002.TaxCapacityParty5Choice
        + SttlmSysMtd  : ISO20022.Sese037002.SettlementSystemMethod5Choice
        + SctiesRTGS  : ISO20022.Sese037002.SecuritiesRTGS5Choice
        + LglRstrctns  : ISO20022.Sese037002.Restriction6Choice
        + Regn  : ISO20022.Sese037002.Registration11Choice
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese037002.SettlementTransactionCondition21Choice~
    }
    ISO20022.Sese037002.SettlementDetails103 *-- ISO20022.Sese037002.GenericIdentification47
    ISO20022.Sese037002.SettlementDetails103 *-- ISO20022.Sese037002.TaxCapacityParty5Choice
    ISO20022.Sese037002.SettlementDetails103 *-- ISO20022.Sese037002.SettlementSystemMethod5Choice
    ISO20022.Sese037002.SettlementDetails103 *-- ISO20022.Sese037002.SecuritiesRTGS5Choice
    ISO20022.Sese037002.SettlementDetails103 *-- ISO20022.Sese037002.Restriction6Choice
    ISO20022.Sese037002.SettlementDetails103 *-- ISO20022.Sese037002.Registration11Choice
    ISO20022.Sese037002.SettlementDetails103 *-- ISO20022.Sese037002.SettlementTransactionCondition21Choice
    class ISO20022.Sese037002.SettlementParties104 {
        + Pty5  : ISO20022.Sese037002.PartyIdentificationAndAccount206
        + Pty4  : ISO20022.Sese037002.PartyIdentificationAndAccount206
        + Pty3  : ISO20022.Sese037002.PartyIdentificationAndAccount206
        + Pty2  : ISO20022.Sese037002.PartyIdentificationAndAccount206
        + Pty1  : ISO20022.Sese037002.PartyIdentificationAndAccount206
        + Dpstry  : ISO20022.Sese037002.PartyIdentification162
    }
    ISO20022.Sese037002.SettlementParties104 *-- ISO20022.Sese037002.PartyIdentificationAndAccount206
    ISO20022.Sese037002.SettlementParties104 *-- ISO20022.Sese037002.PartyIdentificationAndAccount206
    ISO20022.Sese037002.SettlementParties104 *-- ISO20022.Sese037002.PartyIdentificationAndAccount206
    ISO20022.Sese037002.SettlementParties104 *-- ISO20022.Sese037002.PartyIdentificationAndAccount206
    ISO20022.Sese037002.SettlementParties104 *-- ISO20022.Sese037002.PartyIdentificationAndAccount206
    ISO20022.Sese037002.SettlementParties104 *-- ISO20022.Sese037002.PartyIdentification162
    class ISO20022.Sese037002.SettlementSystemMethod1Code {
        YSET = 1
        NSET = 2
    }
    class ISO20022.Sese037002.SettlementSystemMethod5Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.SettlementSystemMethod5Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.SettlementTransactionCondition21Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.SettlementTransactionCondition21Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.SettlementTransactionCondition3Code {
        UNEX = 1
        SPST = 2
        SPDL = 3
        RESI = 4
        PHYS = 5
        KNOC = 6
        FRCL = 7
        EXER = 8
        DRAW = 9
        DLWM = 10
        DIRT = 11
        CLEN = 12
        ASGN = 13
    }
    class ISO20022.Sese037002.Statement68 {
        + ActvtyInd  : String
        + UpdTp  : ISO20022.Sese037002.UpdateType16Choice
        + StmtDtTm  : ISO20022.Sese037002.DateAndDateTime2Choice
        + StmtId  : String
        + RptNb  : ISO20022.Sese037002.Number3Choice
        + CtrPtyPrtflTrfNtfctnRef  : String
    }
    ISO20022.Sese037002.Statement68 *-- ISO20022.Sese037002.UpdateType16Choice
    ISO20022.Sese037002.Statement68 *-- ISO20022.Sese037002.DateAndDateTime2Choice
    ISO20022.Sese037002.Statement68 *-- ISO20022.Sese037002.Number3Choice
    class ISO20022.Sese037002.StatementUpdateType1Code {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Sese037002.SupplementaryData1 {
        + Envlp  : ISO20022.Sese037002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese037002.SupplementaryData1 *-- ISO20022.Sese037002.SupplementaryDataEnvelope1
    class ISO20022.Sese037002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese037002.TaxCapacityParty5Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.TaxCapacityParty5Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.TaxLiability1Code {
        AGEN = 1
        PRIN = 2
    }
    class ISO20022.Sese037002.TradeDate9Choice {
        + DtCd  : ISO20022.Sese037002.TradeDateCode4Choice
        + Dt  : ISO20022.Sese037002.DateAndDateTime2Choice
    }
    ISO20022.Sese037002.TradeDate9Choice *-- ISO20022.Sese037002.TradeDateCode4Choice
    ISO20022.Sese037002.TradeDate9Choice *-- ISO20022.Sese037002.DateAndDateTime2Choice
    class ISO20022.Sese037002.TradeDateCode4Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.TradeDateCode4Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Sese037002.TypeOfPrice14Code {
        AVER = 1
    }
    class ISO20022.Sese037002.TypeOfPrice32Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.TypeOfPrice32Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.UpdateType16Choice {
        + Prtry  : ISO20022.Sese037002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese037002.UpdateType16Choice *-- ISO20022.Sese037002.GenericIdentification47
    class ISO20022.Sese037002.YieldedOrValueType1Choice {
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

## Value ISO20022.Sese037002.AcknowledgedAcceptedStatus32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese037002.AcknowledgementReason20>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese037002.AcknowledgementReason20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese037002.AcknowledgementReason23Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese037002.AcknowledgementReason23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese037002.AcknowledgementReason9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|

---

## Value ISO20022.Sese037002.AlternatePartyIdentification9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Sese037002.IdentificationType44Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AltrnId""",AltrnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Sese037002.AmountAndDirection57


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese037002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Sese037002.AmountAndDirection58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Sese037002.ForeignExchangeTerms27||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese037002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese037002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese037002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Sese037002.ClassificationType33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Sese037002.GenericIdentification86||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Enum ISO20022.Sese037002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese037002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Sese037002.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese037002.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Type ISO20022.Sese037002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtflTrfNtfctn|ISO20022.Sese037002.PortfolioTransferNotification002V07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtflTrfNtfctn))|

---

## Enum ISO20022.Sese037002.EventFrequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||SEMI|Int32||XmlEnum("""SEMI""")|2|
||QUTR|Int32||XmlEnum("""QUTR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|

---

## Value ISO20022.Sese037002.FinancialInstrumentAttributes122


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmAttrAddtlDtls|String||XmlElement()||
|+|UndrlygFinInstrmId|global::System.Collections.Generic.List<ISO20022.Sese037002.SecurityIdentification20>||XmlElement()||
|+|CtrctSz|ISO20022.Sese037002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Sese037002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|StrkPric|ISO20022.Sese037002.Price3||XmlElement()||
|+|ConvsPric|ISO20022.Sese037002.Price3||XmlElement()||
|+|SbcptPric|ISO20022.Sese037002.Price3||XmlElement()||
|+|ExrcPric|ISO20022.Sese037002.Price3||XmlElement()||
|+|MktOrIndctvPric|ISO20022.Sese037002.PriceType5Choice||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|PoolNb|ISO20022.Sese037002.GenericIdentification39||XmlElement()||
|+|CpnAttchdNb|ISO20022.Sese037002.Number23Choice||XmlElement()||
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
|+|OptnTp|ISO20022.Sese037002.OptionType7Choice||XmlElement()||
|+|OptnStyle|ISO20022.Sese037002.OptionStyle9Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Sese037002.ClassificationType33Choice||XmlElement()||
|+|VarblRateChngFrqcy|ISO20022.Sese037002.Frequency27Choice||XmlElement()||
|+|PmtSts|ISO20022.Sese037002.SecuritiesPaymentStatus6Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Sese037002.Frequency27Choice||XmlElement()||
|+|RegnForm|ISO20022.Sese037002.FormOfSecurity7Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Sese037002.InterestComputationMethodFormat5Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Sese037002.MarketIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FinInstrmAttrAddtlDtls""",FinInstrmAttrAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validList("""UndrlygFinInstrmId""",UndrlygFinInstrmId),validElement(UndrlygFinInstrmId),validElement(CtrctSz),validElement(MinNmnlQty),validElement(StrkPric),validElement(ConvsPric),validElement(SbcptPric),validElement(ExrcPric),validElement(MktOrIndctvPric),validElement(PoolNb),validElement(CpnAttchdNb),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnTp),validElement(OptnStyle),validElement(ClssfctnTp),validElement(VarblRateChngFrqcy),validElement(PmtSts),validElement(PmtFrqcy),validElement(RegnForm),validElement(DayCntBsis),validElement(PlcOfListg))|

---

## Value ISO20022.Sese037002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese037002.ForeignExchangeTerms27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Sese037002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese037002.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Sese037002.FormOfSecurity7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037002.Frequency27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037002.GenericIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese037002.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese037002.GenericIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""([^/]+/)+([^/]+)\|([^/]*)"""),validPattern("""Id""",Id,"""([^/]+/)+([^/]+)\|([^/]*)"""))|

---

## Value ISO20022.Sese037002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese037002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese037002.GenericIdentification86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese037002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037002.IdentificationType44Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese037002.InterestComputationMethod2Code


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

## Value ISO20022.Sese037002.InterestComputationMethodFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037002.MarketIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese037002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Enum ISO20022.Sese037002.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Sese037002.Number23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|ISO20022.Sese037002.GenericIdentification18||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lng),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Value ISO20022.Sese037002.Number3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|String||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lng""",Lng,"""[0-9]{5}"""),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Enum ISO20022.Sese037002.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Sese037002.OptionStyle9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese037002.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Sese037002.OptionType7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037002.OtherAmounts33


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcrdCptlstnAmt|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
|+|CsmptnTax|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
|+|WhldgTax|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
|+|ValAddedTax|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
|+|TxTax|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
|+|TrfTax|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
|+|StockXchgTax|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
|+|StmpDty|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
|+|ShppgAmt|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
|+|RgltryAmt|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
|+|Othr|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
|+|LclTax|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
|+|PmtLevyTax|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
|+|CtryNtlFdrlTax|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
|+|ChrgsFees|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Sese037002.AmountAndDirection58||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcrdCptlstnAmt),validElement(CsmptnTax),validElement(WhldgTax),validElement(ValAddedTax),validElement(TxTax),validElement(TrfTax),validElement(StockXchgTax),validElement(StmpDty),validElement(ShppgAmt),validElement(RgltryAmt),validElement(Othr),validElement(LclTax),validElement(PmtLevyTax),validElement(CtryNtlFdrlTax),validElement(ChrgsFees),validElement(AcrdIntrstAmt))|

---

## Value ISO20022.Sese037002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese037002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Sese037002.OtherParties42


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TradRgltr|ISO20022.Sese037002.PartyIdentification157||XmlElement()||
|+|StockXchg|ISO20022.Sese037002.PartyIdentification157||XmlElement()||
|+|Invstr|ISO20022.Sese037002.PartyIdentification170||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TradRgltr),validElement(StockXchg),validElement(Invstr))|

---

## Enum ISO20022.Sese037002.OwnershipLegalRestrictions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSTR|Int32||XmlEnum("""RSTR""")|1|
||NRST|Int32||XmlEnum("""NRST""")|2|
||A144|Int32||XmlEnum("""A144""")|3|

---

## Value ISO20022.Sese037002.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Sese037002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese037002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese037002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese037002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese037002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese037002.PartyIdentification145Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese037002.NameAndAddress12||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese037002.PartyIdentification156


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese037002.PartyIdentification136Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese037002.PartyIdentification157


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese037002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese037002.PartyIdentification162


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese037002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese037002.DateAndDateTime2Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese037002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese037002.PartyIdentification145Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(PrcgDt),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese037002.PartyIdentification170


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese037002.PartyIdentification176Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese037002.PartyIdentification176Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese037002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese037002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese037002.PartyIdentificationAndAccount206


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese037002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese037002.DateAndDateTime2Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese037002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese037002.SecuritiesAccount30||XmlElement()||
|+|AltrnId|ISO20022.Sese037002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese037002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(PrcgDt),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese037002.PartyTextInformation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RegnDtls""",RegnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""PtyCtctDtls""",PtyCtctDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""DclrtnDtls""",DclrtnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Enum ISO20022.Sese037002.PendingFailingReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|

---

## Value ISO20022.Sese037002.PendingProcessingReason14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese037002.PendingProcessingReason16Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese037002.PendingProcessingReason16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037002.PendingProcessingStatus17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese037002.PendingProcessingReason14>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Aspect ISO20022.Sese037002.PortfolioTransferNotification002V07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrfNtfctnDtls|global::System.Collections.Generic.List<ISO20022.Sese037002.SecuritiesTradeDetails139>||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese037002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese037002.SecuritiesAccount30||XmlElement()||
|+|AcctOwnr|ISO20022.Sese037002.PartyIdentification156||XmlElement()||
|+|StmtGnlDtls|ISO20022.Sese037002.Statement68||XmlElement()||
|+|Pgntn|ISO20022.Sese037002.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TrfNtfctnDtls""",TrfNtfctnDtls),validElement(TrfNtfctnDtls),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(StmtGnlDtls),validElement(Pgntn))|

---

## Value ISO20022.Sese037002.PortfolioTransferStatus2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.ProprietaryStatusAndReason6||XmlElement()||
|+|Rjctd|ISO20022.Sese037002.RejectionStatus30Choice||XmlElement()||
|+|PdgPrcg|ISO20022.Sese037002.PendingProcessingStatus17Choice||XmlElement()||
|+|AckdAccptd|ISO20022.Sese037002.AcknowledgedAcceptedStatus32Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Rjctd),validElement(PdgPrcg),validElement(AckdAccptd),validChoice(Prtry,Rjctd,PdgPrcg,AckdAccptd))|

---

## Value ISO20022.Sese037002.Price3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Sese037002.PriceRateOrAmount1Choice||XmlElement()||
|+|Tp|ISO20022.Sese037002.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Sese037002.PriceRateOrAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese037002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Sese037002.PriceType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indctv|ISO20022.Sese037002.Price3||XmlElement()||
|+|Mkt|ISO20022.Sese037002.Price3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indctv),validElement(Mkt),validChoice(Indctv,Mkt))|

---

## Enum ISO20022.Sese037002.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Sese037002.ProprietaryReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Sese037002.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Sese037002.ProprietaryStatusAndReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Sese037002.ProprietaryReason4>||XmlElement()||
|+|PrtrySts|ISO20022.Sese037002.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Sese037002.Quantity49


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Sese037002.QuantityBreakdown69>||XmlElement()||
|+|CertNb|global::System.Collections.Generic.List<ISO20022.Sese037002.SecuritiesCertificate5>||XmlElement()||
|+|DnmtnChc|String||XmlElement()||
|+|SttlmQty|ISO20022.Sese037002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validList("""CertNb""",CertNb),validElement(CertNb),validPattern("""DnmtnChc""",DnmtnChc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(SttlmQty))|

---

## Value ISO20022.Sese037002.QuantityBreakdown69


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TpOfPric|ISO20022.Sese037002.TypeOfPrice32Choice||XmlElement()||
|+|LotPric|ISO20022.Sese037002.Price3||XmlElement()||
|+|LotDtTm|ISO20022.Sese037002.DateAndDateTime2Choice||XmlElement()||
|+|LotQty|ISO20022.Sese037002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|LotNb|ISO20022.Sese037002.GenericIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TpOfPric),validElement(LotPric),validElement(LotDtTm),validElement(LotQty),validElement(LotNb))|

---

## Enum ISO20022.Sese037002.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Sese037002.Registration11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese037002.Registration1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YREG|Int32||XmlEnum("""YREG""")|1|
||NREG|Int32||XmlEnum("""NREG""")|2|

---

## Value ISO20022.Sese037002.RejectionReason37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037002.RejectionReason49


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese037002.RejectionReason37Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Enum ISO20022.Sese037002.RejectionReason55Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DSEC|Int32||XmlEnum("""DSEC""")|1|
||SSID|Int32||XmlEnum("""SSID""")|2|
||SAFE|Int32||XmlEnum("""SAFE""")|3|
||PODU|Int32||XmlEnum("""PODU""")|4|
||OTHR|Int32||XmlEnum("""OTHR""")|5|
||DQUA|Int32||XmlEnum("""DQUA""")|6|
||CAEV|Int32||XmlEnum("""CAEV""")|7|
||BENO|Int32||XmlEnum("""BENO""")|8|

---

## Value ISO20022.Sese037002.RejectionStatus30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese037002.RejectionReason49>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese037002.Reporting1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGU|Int32||XmlEnum("""REGU""")|1|
||STEX|Int32||XmlEnum("""STEX""")|2|

---

## Value ISO20022.Sese037002.Reporting8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese037002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese037002.RestrictedFINActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese037002.Restriction6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037002.SecuritiesAccount30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Sese037002.SecuritiesCertificate5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Nb""",Nb,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Sese037002.SecuritiesPaymentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NILL|Int32||XmlEnum("""NILL""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Sese037002.SecuritiesPaymentStatus6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037002.SecuritiesRTGS5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese037002.SecuritiesTradeDetails139


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese037002.SupplementaryData1>||XmlElement()||
|+|OthrBizPties|ISO20022.Sese037002.OtherParties42||XmlElement()||
|+|OthrAmts|ISO20022.Sese037002.OtherAmounts33||XmlElement()||
|+|SttlmAmt|ISO20022.Sese037002.AmountAndDirection57||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese037002.SettlementParties104||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese037002.SettlementParties104||XmlElement()||
|+|SttlmParams|ISO20022.Sese037002.SettlementDetails103||XmlElement()||
|+|QtyDtls|ISO20022.Sese037002.Quantity49||XmlElement()||
|+|Rptg|global::System.Collections.Generic.List<ISO20022.Sese037002.Reporting8Choice>||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Sese037002.FinancialInstrumentAttributes122||XmlElement()||
|+|FinInstrmId|ISO20022.Sese037002.SecurityIdentification20||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|SttlmDt|ISO20022.Sese037002.SettlementDate20Choice||XmlElement()||
|+|TradDt|ISO20022.Sese037002.TradeDate9Choice||XmlElement()||
|+|Sts|ISO20022.Sese037002.PortfolioTransferStatus2Choice||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
|+|CmonId|String||XmlElement()||
|+|NtfctnRcvrTxId|String||XmlElement()||
|+|NtfctnSndrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(OthrBizPties),validElement(OthrAmts),validElement(SttlmAmt),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(SttlmParams),validElement(QtyDtls),validList("""Rptg""",Rptg),validElement(Rptg),validElement(FinInstrmAttrbts),validElement(FinInstrmId),validElement(SttlmDt),validElement(TradDt),validElement(Sts),validPattern("""CmonId""",CmonId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""NtfctnRcvrTxId""",NtfctnRcvrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""NtfctnSndrTxId""",NtfctnSndrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese037002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese037002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese037002.SettlementDate20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese037002.SettlementDateCode9Choice||XmlElement()||
|+|Dt|ISO20022.Sese037002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Sese037002.SettlementDate4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WISS|Int32||XmlEnum("""WISS""")|1|

---

## Value ISO20022.Sese037002.SettlementDateCode9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037002.SettlementDetails103


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StmpDtyTaxBsis|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|TaxCpcty|ISO20022.Sese037002.TaxCapacityParty5Choice||XmlElement()||
|+|SttlmSysMtd|ISO20022.Sese037002.SettlementSystemMethod5Choice||XmlElement()||
|+|SctiesRTGS|ISO20022.Sese037002.SecuritiesRTGS5Choice||XmlElement()||
|+|LglRstrctns|ISO20022.Sese037002.Restriction6Choice||XmlElement()||
|+|Regn|ISO20022.Sese037002.Registration11Choice||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese037002.SettlementTransactionCondition21Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmpDtyTaxBsis),validElement(TaxCpcty),validElement(SttlmSysMtd),validElement(SctiesRTGS),validElement(LglRstrctns),validElement(Regn),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond))|

---

## Value ISO20022.Sese037002.SettlementParties104


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese037002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty4|ISO20022.Sese037002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty3|ISO20022.Sese037002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty2|ISO20022.Sese037002.PartyIdentificationAndAccount206||XmlElement()||
|+|Pty1|ISO20022.Sese037002.PartyIdentificationAndAccount206||XmlElement()||
|+|Dpstry|ISO20022.Sese037002.PartyIdentification162||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Sese037002.SettlementSystemMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSET|Int32||XmlEnum("""YSET""")|1|
||NSET|Int32||XmlEnum("""NSET""")|2|

---

## Value ISO20022.Sese037002.SettlementSystemMethod5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037002.SettlementTransactionCondition21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese037002.SettlementTransactionCondition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNEX|Int32||XmlEnum("""UNEX""")|1|
||SPST|Int32||XmlEnum("""SPST""")|2|
||SPDL|Int32||XmlEnum("""SPDL""")|3|
||RESI|Int32||XmlEnum("""RESI""")|4|
||PHYS|Int32||XmlEnum("""PHYS""")|5|
||KNOC|Int32||XmlEnum("""KNOC""")|6|
||FRCL|Int32||XmlEnum("""FRCL""")|7|
||EXER|Int32||XmlEnum("""EXER""")|8|
||DRAW|Int32||XmlEnum("""DRAW""")|9|
||DLWM|Int32||XmlEnum("""DLWM""")|10|
||DIRT|Int32||XmlEnum("""DIRT""")|11|
||CLEN|Int32||XmlEnum("""CLEN""")|12|
||ASGN|Int32||XmlEnum("""ASGN""")|13|

---

## Value ISO20022.Sese037002.Statement68


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ActvtyInd|String||XmlElement()||
|+|UpdTp|ISO20022.Sese037002.UpdateType16Choice||XmlElement()||
|+|StmtDtTm|ISO20022.Sese037002.DateAndDateTime2Choice||XmlElement()||
|+|StmtId|String||XmlElement()||
|+|RptNb|ISO20022.Sese037002.Number3Choice||XmlElement()||
|+|CtrPtyPrtflTrfNtfctnRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UpdTp),validElement(StmtDtTm),validPattern("""StmtId""",StmtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(RptNb),validPattern("""CtrPtyPrtflTrfNtfctnRef""",CtrPtyPrtflTrfNtfctnRef,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Sese037002.StatementUpdateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Sese037002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese037002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese037002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese037002.TaxCapacityParty5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese037002.TaxLiability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGEN|Int32||XmlEnum("""AGEN""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Sese037002.TradeDate9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese037002.TradeDateCode4Choice||XmlElement()||
|+|Dt|ISO20022.Sese037002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese037002.TradeDateCode4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese037002.TypeOfIdentification1Code


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

## Enum ISO20022.Sese037002.TypeOfPrice14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AVER|Int32||XmlEnum("""AVER""")|1|

---

## Value ISO20022.Sese037002.TypeOfPrice32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037002.UpdateType16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037002.YieldedOrValueType1Choice


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

