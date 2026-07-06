# sese.037.001.08
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese037001.AcknowledgedAcceptedStatus32Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese037001.AcknowledgementReason20~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese037001.AcknowledgedAcceptedStatus32Choice *-- ISO20022.Sese037001.AcknowledgementReason20
    class ISO20022.Sese037001.AcknowledgementReason20 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese037001.AcknowledgementReason23Choice
    }
    ISO20022.Sese037001.AcknowledgementReason20 *-- ISO20022.Sese037001.AcknowledgementReason23Choice
    class ISO20022.Sese037001.AcknowledgementReason23Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.AcknowledgementReason23Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.AcknowledgementReason9Code {
        OTHR = 1
    }
    class ISO20022.Sese037001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese037001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese037001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese037001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Sese037001.AlternatePartyIdentification7 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Sese037001.IdentificationType42Choice
    }
    ISO20022.Sese037001.AlternatePartyIdentification7 *-- ISO20022.Sese037001.IdentificationType42Choice
    class ISO20022.Sese037001.AmountAndDirection44 {
        + FXDtls  : ISO20022.Sese037001.ForeignExchangeTerms23
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese037001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese037001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Sese037001.AmountAndDirection44 *-- ISO20022.Sese037001.ForeignExchangeTerms23
    ISO20022.Sese037001.AmountAndDirection44 *-- ISO20022.Sese037001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese037001.AmountAndDirection44 *-- ISO20022.Sese037001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese037001.AmountAndDirection52 {
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese037001.ActiveCurrencyAndAmount
    }
    ISO20022.Sese037001.AmountAndDirection52 *-- ISO20022.Sese037001.ActiveCurrencyAndAmount
    class ISO20022.Sese037001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Sese037001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese037001.BlockChainAddressWallet3 *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.ClassificationType32Choice {
        + AltrnClssfctn  : ISO20022.Sese037001.GenericIdentification36
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Sese037001.ClassificationType32Choice *-- ISO20022.Sese037001.GenericIdentification36
    class ISO20022.Sese037001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese037001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese037001.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese037001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese037001.EventFrequency3Code {
        WEEK = 1
        SEMI = 2
        QUTR = 3
        MNTH = 4
        YEAR = 5
    }
    class ISO20022.Sese037001.FinancialInstrumentAttributes111 {
        + FinInstrmAttrAddtlDtls  : String
        + UndrlygFinInstrmId  : global::System.Collections.Generic.List~ISO20022.Sese037001.SecurityIdentification19~
        + CtrctSz  : ISO20022.Sese037001.FinancialInstrumentQuantity33Choice
        + MinNmnlQty  : ISO20022.Sese037001.FinancialInstrumentQuantity33Choice
        + StrkPric  : ISO20022.Sese037001.Price7
        + ConvsPric  : ISO20022.Sese037001.Price7
        + SbcptPric  : ISO20022.Sese037001.Price7
        + ExrcPric  : ISO20022.Sese037001.Price7
        + MktOrIndctvPric  : ISO20022.Sese037001.PriceType4Choice
        + PutblInd  : String
        + CllblInd  : String
        + VarblRateInd  : String
        + PoolNb  : ISO20022.Sese037001.GenericIdentification37
        + CpnAttchdNb  : ISO20022.Sese037001.Number22Choice
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
        + OptnTp  : ISO20022.Sese037001.OptionType6Choice
        + OptnStyle  : ISO20022.Sese037001.OptionStyle8Choice
        + ClssfctnTp  : ISO20022.Sese037001.ClassificationType32Choice
        + VarblRateChngFrqcy  : ISO20022.Sese037001.Frequency23Choice
        + PmtSts  : ISO20022.Sese037001.SecuritiesPaymentStatus5Choice
        + PmtFrqcy  : ISO20022.Sese037001.Frequency23Choice
        + RegnForm  : ISO20022.Sese037001.FormOfSecurity6Choice
        + DayCntBsis  : ISO20022.Sese037001.InterestComputationMethodFormat4Choice
        + PlcOfListg  : ISO20022.Sese037001.MarketIdentification3Choice
    }
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.SecurityIdentification19
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.FinancialInstrumentQuantity33Choice
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.FinancialInstrumentQuantity33Choice
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.Price7
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.Price7
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.Price7
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.Price7
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.PriceType4Choice
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.GenericIdentification37
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.Number22Choice
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.OptionType6Choice
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.OptionStyle8Choice
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.ClassificationType32Choice
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.Frequency23Choice
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.SecuritiesPaymentStatus5Choice
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.Frequency23Choice
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.FormOfSecurity6Choice
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.InterestComputationMethodFormat4Choice
    ISO20022.Sese037001.FinancialInstrumentAttributes111 *-- ISO20022.Sese037001.MarketIdentification3Choice
    class ISO20022.Sese037001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese037001.ForeignExchangeTerms23 {
        + RsltgAmt  : ISO20022.Sese037001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Sese037001.ForeignExchangeTerms23 *-- ISO20022.Sese037001.ActiveCurrencyAndAmount
    class ISO20022.Sese037001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Sese037001.FormOfSecurity6Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.FormOfSecurity6Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.Frequency23Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.Frequency23Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Sese037001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese037001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese037001.GenericIdentification37 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese037001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese037001.IdentificationType42Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.IdentificationType42Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.InterestComputationMethod2Code {
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
    class ISO20022.Sese037001.InterestComputationMethodFormat4Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.InterestComputationMethodFormat4Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.MarketIdentification3Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese037001.NameAndAddress5 {
        + Adr  : ISO20022.Sese037001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Sese037001.NameAndAddress5 *-- ISO20022.Sese037001.PostalAddress1
    class ISO20022.Sese037001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Sese037001.Number22Choice {
        + Lng  : ISO20022.Sese037001.GenericIdentification1
        + Shrt  : String
    }
    ISO20022.Sese037001.Number22Choice *-- ISO20022.Sese037001.GenericIdentification1
    class ISO20022.Sese037001.Number3Choice {
        + Lng  : String
        + Shrt  : String
    }
    class ISO20022.Sese037001.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Sese037001.OptionStyle8Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.OptionStyle8Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Sese037001.OptionType6Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.OptionType6Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.OtherAmounts29 {
        + AcrdCptlstnAmt  : ISO20022.Sese037001.AmountAndDirection44
        + CsmptnTax  : ISO20022.Sese037001.AmountAndDirection44
        + WhldgTax  : ISO20022.Sese037001.AmountAndDirection44
        + ValAddedTax  : ISO20022.Sese037001.AmountAndDirection44
        + TxTax  : ISO20022.Sese037001.AmountAndDirection44
        + TrfTax  : ISO20022.Sese037001.AmountAndDirection44
        + StockXchgTax  : ISO20022.Sese037001.AmountAndDirection44
        + StmpDty  : ISO20022.Sese037001.AmountAndDirection44
        + ShppgAmt  : ISO20022.Sese037001.AmountAndDirection44
        + RgltryAmt  : ISO20022.Sese037001.AmountAndDirection44
        + Othr  : ISO20022.Sese037001.AmountAndDirection44
        + LclTax  : ISO20022.Sese037001.AmountAndDirection44
        + PmtLevyTax  : ISO20022.Sese037001.AmountAndDirection44
        + CtryNtlFdrlTax  : ISO20022.Sese037001.AmountAndDirection44
        + ChrgsFees  : ISO20022.Sese037001.AmountAndDirection44
        + AcrdIntrstAmt  : ISO20022.Sese037001.AmountAndDirection44
    }
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    ISO20022.Sese037001.OtherAmounts29 *-- ISO20022.Sese037001.AmountAndDirection44
    class ISO20022.Sese037001.OtherIdentification1 {
        + Tp  : ISO20022.Sese037001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese037001.OtherIdentification1 *-- ISO20022.Sese037001.IdentificationSource3Choice
    class ISO20022.Sese037001.OtherParties39 {
        + TradRgltr  : ISO20022.Sese037001.PartyIdentification136
        + StockXchg  : ISO20022.Sese037001.PartyIdentification136
        + Invstr  : ISO20022.Sese037001.PartyIdentification149
    }
    ISO20022.Sese037001.OtherParties39 *-- ISO20022.Sese037001.PartyIdentification136
    ISO20022.Sese037001.OtherParties39 *-- ISO20022.Sese037001.PartyIdentification136
    ISO20022.Sese037001.OtherParties39 *-- ISO20022.Sese037001.PartyIdentification149
    class ISO20022.Sese037001.OwnershipLegalRestrictions1Code {
        RSTR = 1
        NRST = 2
        A144 = 3
    }
    class ISO20022.Sese037001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Sese037001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Sese037001.NameAndAddress5
        + PrtryId  : ISO20022.Sese037001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese037001.PartyIdentification120Choice *-- ISO20022.Sese037001.NameAndAddress5
    ISO20022.Sese037001.PartyIdentification120Choice *-- ISO20022.Sese037001.GenericIdentification36
    class ISO20022.Sese037001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Sese037001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese037001.PartyIdentification127Choice *-- ISO20022.Sese037001.GenericIdentification36
    class ISO20022.Sese037001.PartyIdentification134Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese037001.NameAndAddress5
        + PrtryId  : ISO20022.Sese037001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese037001.PartyIdentification134Choice *-- ISO20022.Sese037001.NameAndAddress5
    ISO20022.Sese037001.PartyIdentification134Choice *-- ISO20022.Sese037001.GenericIdentification36
    class ISO20022.Sese037001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Sese037001.PartyIdentification120Choice
    }
    ISO20022.Sese037001.PartyIdentification136 *-- ISO20022.Sese037001.PartyIdentification120Choice
    class ISO20022.Sese037001.PartyIdentification144 {
        + LEI  : String
        + Id  : ISO20022.Sese037001.PartyIdentification127Choice
    }
    ISO20022.Sese037001.PartyIdentification144 *-- ISO20022.Sese037001.PartyIdentification127Choice
    class ISO20022.Sese037001.PartyIdentification149 {
        + LEI  : String
        + Id  : ISO20022.Sese037001.PartyIdentification134Choice
    }
    ISO20022.Sese037001.PartyIdentification149 *-- ISO20022.Sese037001.PartyIdentification134Choice
    class ISO20022.Sese037001.PartyIdentification257Choice {
        + DgtlLdgrId  : String
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese037001.NameAndAddress5
        + AnyBIC  : String
    }
    ISO20022.Sese037001.PartyIdentification257Choice *-- ISO20022.Sese037001.NameAndAddress5
    class ISO20022.Sese037001.PartyIdentification315 {
        + AddtlInf  : ISO20022.Sese037001.PartyTextInformation1
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese037001.DateAndDateTime2Choice
        + AltrnId  : ISO20022.Sese037001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese037001.PartyIdentification257Choice
    }
    ISO20022.Sese037001.PartyIdentification315 *-- ISO20022.Sese037001.PartyTextInformation1
    ISO20022.Sese037001.PartyIdentification315 *-- ISO20022.Sese037001.DateAndDateTime2Choice
    ISO20022.Sese037001.PartyIdentification315 *-- ISO20022.Sese037001.AlternatePartyIdentification7
    ISO20022.Sese037001.PartyIdentification315 *-- ISO20022.Sese037001.PartyIdentification257Choice
    class ISO20022.Sese037001.PartyIdentificationAndAccount196 {
        + AddtlInf  : ISO20022.Sese037001.PartyTextInformation1
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese037001.DateAndDateTime2Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese037001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese037001.SecuritiesAccount19
        + AltrnId  : ISO20022.Sese037001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese037001.PartyIdentification120Choice
    }
    ISO20022.Sese037001.PartyIdentificationAndAccount196 *-- ISO20022.Sese037001.PartyTextInformation1
    ISO20022.Sese037001.PartyIdentificationAndAccount196 *-- ISO20022.Sese037001.DateAndDateTime2Choice
    ISO20022.Sese037001.PartyIdentificationAndAccount196 *-- ISO20022.Sese037001.BlockChainAddressWallet3
    ISO20022.Sese037001.PartyIdentificationAndAccount196 *-- ISO20022.Sese037001.SecuritiesAccount19
    ISO20022.Sese037001.PartyIdentificationAndAccount196 *-- ISO20022.Sese037001.AlternatePartyIdentification7
    ISO20022.Sese037001.PartyIdentificationAndAccount196 *-- ISO20022.Sese037001.PartyIdentification120Choice
    class ISO20022.Sese037001.PartyTextInformation1 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese037001.PendingFailingReason1Code {
        OTHR = 1
    }
    class ISO20022.Sese037001.PendingProcessingReason14 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese037001.PendingProcessingReason16Choice
    }
    ISO20022.Sese037001.PendingProcessingReason14 *-- ISO20022.Sese037001.PendingProcessingReason16Choice
    class ISO20022.Sese037001.PendingProcessingReason16Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.PendingProcessingReason16Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.PendingProcessingStatus17Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese037001.PendingProcessingReason14~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese037001.PendingProcessingStatus17Choice *-- ISO20022.Sese037001.PendingProcessingReason14
    class ISO20022.Sese037001.PortfolioTransferNotificationV08 {
        + TrfNtfctnDtls  : global::System.Collections.Generic.List~ISO20022.Sese037001.SecuritiesTradeDetails148~
        + BlckChainAdrOrWllt  : ISO20022.Sese037001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese037001.SecuritiesAccount19
        + AcctOwnr  : ISO20022.Sese037001.PartyIdentification144
        + StmtGnlDtls  : ISO20022.Sese037001.Statement62
        + Pgntn  : ISO20022.Sese037001.Pagination1
    }
    ISO20022.Sese037001.PortfolioTransferNotificationV08 *-- ISO20022.Sese037001.SecuritiesTradeDetails148
    ISO20022.Sese037001.PortfolioTransferNotificationV08 *-- ISO20022.Sese037001.BlockChainAddressWallet3
    ISO20022.Sese037001.PortfolioTransferNotificationV08 *-- ISO20022.Sese037001.SecuritiesAccount19
    ISO20022.Sese037001.PortfolioTransferNotificationV08 *-- ISO20022.Sese037001.PartyIdentification144
    ISO20022.Sese037001.PortfolioTransferNotificationV08 *-- ISO20022.Sese037001.Statement62
    ISO20022.Sese037001.PortfolioTransferNotificationV08 *-- ISO20022.Sese037001.Pagination1
    class ISO20022.Sese037001.PortfolioTransferStatus2Choice {
        + Prtry  : ISO20022.Sese037001.ProprietaryStatusAndReason6
        + Rjctd  : ISO20022.Sese037001.RejectionStatus30Choice
        + PdgPrcg  : ISO20022.Sese037001.PendingProcessingStatus17Choice
        + AckdAccptd  : ISO20022.Sese037001.AcknowledgedAcceptedStatus32Choice
    }
    ISO20022.Sese037001.PortfolioTransferStatus2Choice *-- ISO20022.Sese037001.ProprietaryStatusAndReason6
    ISO20022.Sese037001.PortfolioTransferStatus2Choice *-- ISO20022.Sese037001.RejectionStatus30Choice
    ISO20022.Sese037001.PortfolioTransferStatus2Choice *-- ISO20022.Sese037001.PendingProcessingStatus17Choice
    ISO20022.Sese037001.PortfolioTransferStatus2Choice *-- ISO20022.Sese037001.AcknowledgedAcceptedStatus32Choice
    class ISO20022.Sese037001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Sese037001.Price7 {
        + Val  : ISO20022.Sese037001.PriceRateOrAmount3Choice
        + Tp  : ISO20022.Sese037001.YieldedOrValueType1Choice
    }
    ISO20022.Sese037001.Price7 *-- ISO20022.Sese037001.PriceRateOrAmount3Choice
    ISO20022.Sese037001.Price7 *-- ISO20022.Sese037001.YieldedOrValueType1Choice
    class ISO20022.Sese037001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Sese037001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Sese037001.PriceRateOrAmount3Choice *-- ISO20022.Sese037001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Sese037001.PriceType4Choice {
        + Indctv  : ISO20022.Sese037001.Price7
        + Mkt  : ISO20022.Sese037001.Price7
    }
    ISO20022.Sese037001.PriceType4Choice *-- ISO20022.Sese037001.Price7
    ISO20022.Sese037001.PriceType4Choice *-- ISO20022.Sese037001.Price7
    class ISO20022.Sese037001.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Sese037001.ProprietaryReason4 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Sese037001.GenericIdentification30
    }
    ISO20022.Sese037001.ProprietaryReason4 *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.ProprietaryStatusAndReason6 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Sese037001.ProprietaryReason4~
        + PrtrySts  : ISO20022.Sese037001.GenericIdentification30
    }
    ISO20022.Sese037001.ProprietaryStatusAndReason6 *-- ISO20022.Sese037001.ProprietaryReason4
    ISO20022.Sese037001.ProprietaryStatusAndReason6 *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.Quantity48 {
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Sese037001.QuantityBreakdown62~
        + CertNb  : global::System.Collections.Generic.List~ISO20022.Sese037001.SecuritiesCertificate4~
        + DnmtnChc  : String
        + SttlmQty  : ISO20022.Sese037001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Sese037001.Quantity48 *-- ISO20022.Sese037001.QuantityBreakdown62
    ISO20022.Sese037001.Quantity48 *-- ISO20022.Sese037001.SecuritiesCertificate4
    ISO20022.Sese037001.Quantity48 *-- ISO20022.Sese037001.FinancialInstrumentQuantity33Choice
    class ISO20022.Sese037001.QuantityBreakdown62 {
        + TpOfPric  : ISO20022.Sese037001.TypeOfPrice29Choice
        + LotPric  : ISO20022.Sese037001.Price7
        + LotDtTm  : ISO20022.Sese037001.DateAndDateTime2Choice
        + LotQty  : ISO20022.Sese037001.FinancialInstrumentQuantity33Choice
        + LotNb  : ISO20022.Sese037001.GenericIdentification37
    }
    ISO20022.Sese037001.QuantityBreakdown62 *-- ISO20022.Sese037001.TypeOfPrice29Choice
    ISO20022.Sese037001.QuantityBreakdown62 *-- ISO20022.Sese037001.Price7
    ISO20022.Sese037001.QuantityBreakdown62 *-- ISO20022.Sese037001.DateAndDateTime2Choice
    ISO20022.Sese037001.QuantityBreakdown62 *-- ISO20022.Sese037001.FinancialInstrumentQuantity33Choice
    ISO20022.Sese037001.QuantityBreakdown62 *-- ISO20022.Sese037001.GenericIdentification37
    class ISO20022.Sese037001.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese037001.Registration1Code {
        YREG = 1
        NREG = 2
    }
    class ISO20022.Sese037001.Registration9Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.Registration9Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.RejectionReason37Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.RejectionReason37Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.RejectionReason49 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese037001.RejectionReason37Choice
    }
    ISO20022.Sese037001.RejectionReason49 *-- ISO20022.Sese037001.RejectionReason37Choice
    class ISO20022.Sese037001.RejectionReason55Code {
        DSEC = 1
        SSID = 2
        SAFE = 3
        PODU = 4
        OTHR = 5
        DQUA = 6
        CAEV = 7
        BENO = 8
    }
    class ISO20022.Sese037001.RejectionStatus30Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese037001.RejectionReason49~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese037001.RejectionStatus30Choice *-- ISO20022.Sese037001.RejectionReason49
    class ISO20022.Sese037001.Reporting1Code {
        REGU = 1
        STEX = 2
    }
    class ISO20022.Sese037001.Reporting7Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.Reporting7Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.Restriction5Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.Restriction5Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Sese037001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese037001.SecuritiesAccount19 *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.SecuritiesCertificate4 {
        + SchmeNm  : String
        + Issr  : String
        + Nb  : String
    }
    class ISO20022.Sese037001.SecuritiesPaymentStatus1Code {
        PART = 1
        NILL = 2
        FULL = 3
    }
    class ISO20022.Sese037001.SecuritiesPaymentStatus5Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.SecuritiesPaymentStatus5Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.SecuritiesRTGS4Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese037001.SecuritiesRTGS4Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.SecuritiesTradeDetails148 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese037001.SupplementaryData1~
        + OthrBizPties  : ISO20022.Sese037001.OtherParties39
        + OthrAmts  : ISO20022.Sese037001.OtherAmounts29
        + SttlmAmt  : ISO20022.Sese037001.AmountAndDirection52
        + RcvgSttlmPties  : ISO20022.Sese037001.SettlementParties128
        + DlvrgSttlmPties  : ISO20022.Sese037001.SettlementParties128
        + SttlmParams  : ISO20022.Sese037001.SettlementDetails100
        + QtyDtls  : ISO20022.Sese037001.Quantity48
        + Rptg  : global::System.Collections.Generic.List~ISO20022.Sese037001.Reporting7Choice~
        + FinInstrmAttrbts  : ISO20022.Sese037001.FinancialInstrumentAttributes111
        + FinInstrmId  : ISO20022.Sese037001.SecurityIdentification19
        + NbOfDaysAcrd  : Decimal
        + SttlmDt  : ISO20022.Sese037001.SettlementDate17Choice
        + TradDt  : ISO20022.Sese037001.TradeDate8Choice
        + Sts  : ISO20022.Sese037001.PortfolioTransferStatus2Choice
        + Pmt  : String
        + SctiesMvmntTp  : String
        + CmonId  : String
        + NtfctnRcvrTxId  : String
        + NtfctnSndrTxId  : String
    }
    ISO20022.Sese037001.SecuritiesTradeDetails148 *-- ISO20022.Sese037001.SupplementaryData1
    ISO20022.Sese037001.SecuritiesTradeDetails148 *-- ISO20022.Sese037001.OtherParties39
    ISO20022.Sese037001.SecuritiesTradeDetails148 *-- ISO20022.Sese037001.OtherAmounts29
    ISO20022.Sese037001.SecuritiesTradeDetails148 *-- ISO20022.Sese037001.AmountAndDirection52
    ISO20022.Sese037001.SecuritiesTradeDetails148 *-- ISO20022.Sese037001.SettlementParties128
    ISO20022.Sese037001.SecuritiesTradeDetails148 *-- ISO20022.Sese037001.SettlementParties128
    ISO20022.Sese037001.SecuritiesTradeDetails148 *-- ISO20022.Sese037001.SettlementDetails100
    ISO20022.Sese037001.SecuritiesTradeDetails148 *-- ISO20022.Sese037001.Quantity48
    ISO20022.Sese037001.SecuritiesTradeDetails148 *-- ISO20022.Sese037001.Reporting7Choice
    ISO20022.Sese037001.SecuritiesTradeDetails148 *-- ISO20022.Sese037001.FinancialInstrumentAttributes111
    ISO20022.Sese037001.SecuritiesTradeDetails148 *-- ISO20022.Sese037001.SecurityIdentification19
    ISO20022.Sese037001.SecuritiesTradeDetails148 *-- ISO20022.Sese037001.SettlementDate17Choice
    ISO20022.Sese037001.SecuritiesTradeDetails148 *-- ISO20022.Sese037001.TradeDate8Choice
    ISO20022.Sese037001.SecuritiesTradeDetails148 *-- ISO20022.Sese037001.PortfolioTransferStatus2Choice
    class ISO20022.Sese037001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese037001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Sese037001.SecurityIdentification19 *-- ISO20022.Sese037001.OtherIdentification1
    class ISO20022.Sese037001.SettlementDate17Choice {
        + DtCd  : ISO20022.Sese037001.SettlementDateCode7Choice
        + Dt  : ISO20022.Sese037001.DateAndDateTime2Choice
    }
    ISO20022.Sese037001.SettlementDate17Choice *-- ISO20022.Sese037001.SettlementDateCode7Choice
    ISO20022.Sese037001.SettlementDate17Choice *-- ISO20022.Sese037001.DateAndDateTime2Choice
    class ISO20022.Sese037001.SettlementDate4Code {
        WISS = 1
    }
    class ISO20022.Sese037001.SettlementDateCode7Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.SettlementDateCode7Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.SettlementDetails100 {
        + StmpDtyTaxBsis  : ISO20022.Sese037001.GenericIdentification30
        + TaxCpcty  : ISO20022.Sese037001.TaxCapacityParty4Choice
        + SttlmSysMtd  : ISO20022.Sese037001.SettlementSystemMethod4Choice
        + SctiesRTGS  : ISO20022.Sese037001.SecuritiesRTGS4Choice
        + LglRstrctns  : ISO20022.Sese037001.Restriction5Choice
        + Regn  : ISO20022.Sese037001.Registration9Choice
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese037001.SettlementTransactionCondition19Choice~
    }
    ISO20022.Sese037001.SettlementDetails100 *-- ISO20022.Sese037001.GenericIdentification30
    ISO20022.Sese037001.SettlementDetails100 *-- ISO20022.Sese037001.TaxCapacityParty4Choice
    ISO20022.Sese037001.SettlementDetails100 *-- ISO20022.Sese037001.SettlementSystemMethod4Choice
    ISO20022.Sese037001.SettlementDetails100 *-- ISO20022.Sese037001.SecuritiesRTGS4Choice
    ISO20022.Sese037001.SettlementDetails100 *-- ISO20022.Sese037001.Restriction5Choice
    ISO20022.Sese037001.SettlementDetails100 *-- ISO20022.Sese037001.Registration9Choice
    ISO20022.Sese037001.SettlementDetails100 *-- ISO20022.Sese037001.SettlementTransactionCondition19Choice
    class ISO20022.Sese037001.SettlementParties128 {
        + Pty5  : ISO20022.Sese037001.PartyIdentificationAndAccount196
        + Pty4  : ISO20022.Sese037001.PartyIdentificationAndAccount196
        + Pty3  : ISO20022.Sese037001.PartyIdentificationAndAccount196
        + Pty2  : ISO20022.Sese037001.PartyIdentificationAndAccount196
        + Pty1  : ISO20022.Sese037001.PartyIdentificationAndAccount196
        + Dpstry  : ISO20022.Sese037001.PartyIdentification315
    }
    ISO20022.Sese037001.SettlementParties128 *-- ISO20022.Sese037001.PartyIdentificationAndAccount196
    ISO20022.Sese037001.SettlementParties128 *-- ISO20022.Sese037001.PartyIdentificationAndAccount196
    ISO20022.Sese037001.SettlementParties128 *-- ISO20022.Sese037001.PartyIdentificationAndAccount196
    ISO20022.Sese037001.SettlementParties128 *-- ISO20022.Sese037001.PartyIdentificationAndAccount196
    ISO20022.Sese037001.SettlementParties128 *-- ISO20022.Sese037001.PartyIdentificationAndAccount196
    ISO20022.Sese037001.SettlementParties128 *-- ISO20022.Sese037001.PartyIdentification315
    class ISO20022.Sese037001.SettlementSystemMethod1Code {
        YSET = 1
        NSET = 2
    }
    class ISO20022.Sese037001.SettlementSystemMethod4Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.SettlementSystemMethod4Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.SettlementTransactionCondition19Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.SettlementTransactionCondition19Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.SettlementTransactionCondition3Code {
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
    class ISO20022.Sese037001.Statement62 {
        + ActvtyInd  : String
        + UpdTp  : ISO20022.Sese037001.UpdateType15Choice
        + StmtDtTm  : ISO20022.Sese037001.DateAndDateTime2Choice
        + StmtId  : String
        + RptNb  : ISO20022.Sese037001.Number3Choice
        + CtrPtyPrtflTrfNtfctnRef  : String
    }
    ISO20022.Sese037001.Statement62 *-- ISO20022.Sese037001.UpdateType15Choice
    ISO20022.Sese037001.Statement62 *-- ISO20022.Sese037001.DateAndDateTime2Choice
    ISO20022.Sese037001.Statement62 *-- ISO20022.Sese037001.Number3Choice
    class ISO20022.Sese037001.StatementUpdateType1Code {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Sese037001.SupplementaryData1 {
        + Envlp  : ISO20022.Sese037001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese037001.SupplementaryData1 *-- ISO20022.Sese037001.SupplementaryDataEnvelope1
    class ISO20022.Sese037001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese037001.TaxCapacityParty4Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.TaxCapacityParty4Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.TaxLiability1Code {
        AGEN = 1
        PRIN = 2
    }
    class ISO20022.Sese037001.TradeDate8Choice {
        + DtCd  : ISO20022.Sese037001.TradeDateCode3Choice
        + Dt  : ISO20022.Sese037001.DateAndDateTime2Choice
    }
    ISO20022.Sese037001.TradeDate8Choice *-- ISO20022.Sese037001.TradeDateCode3Choice
    ISO20022.Sese037001.TradeDate8Choice *-- ISO20022.Sese037001.DateAndDateTime2Choice
    class ISO20022.Sese037001.TradeDateCode3Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.TradeDateCode3Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Sese037001.TypeOfPrice14Code {
        AVER = 1
    }
    class ISO20022.Sese037001.TypeOfPrice29Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.TypeOfPrice29Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.UpdateType15Choice {
        + Prtry  : ISO20022.Sese037001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese037001.UpdateType15Choice *-- ISO20022.Sese037001.GenericIdentification30
    class ISO20022.Sese037001.YieldedOrValueType1Choice {
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

## Value ISO20022.Sese037001.AcknowledgedAcceptedStatus32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese037001.AcknowledgementReason20>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese037001.AcknowledgementReason20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese037001.AcknowledgementReason23Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese037001.AcknowledgementReason23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese037001.AcknowledgementReason9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|

---

## Value ISO20022.Sese037001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese037001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese037001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese037001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Sese037001.AlternatePartyIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Sese037001.IdentificationType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Sese037001.AmountAndDirection44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Sese037001.ForeignExchangeTerms23||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese037001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese037001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese037001.AmountAndDirection52


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese037001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Sese037001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese037001.ClassificationType32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Sese037001.GenericIdentification36||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Enum ISO20022.Sese037001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese037001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Sese037001.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese037001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Type ISO20022.Sese037001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtflTrfNtfctn|ISO20022.Sese037001.PortfolioTransferNotificationV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtflTrfNtfctn))|

---

## Enum ISO20022.Sese037001.EventFrequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||SEMI|Int32||XmlEnum("""SEMI""")|2|
||QUTR|Int32||XmlEnum("""QUTR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|

---

## Value ISO20022.Sese037001.FinancialInstrumentAttributes111


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmAttrAddtlDtls|String||XmlElement()||
|+|UndrlygFinInstrmId|global::System.Collections.Generic.List<ISO20022.Sese037001.SecurityIdentification19>||XmlElement()||
|+|CtrctSz|ISO20022.Sese037001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Sese037001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|StrkPric|ISO20022.Sese037001.Price7||XmlElement()||
|+|ConvsPric|ISO20022.Sese037001.Price7||XmlElement()||
|+|SbcptPric|ISO20022.Sese037001.Price7||XmlElement()||
|+|ExrcPric|ISO20022.Sese037001.Price7||XmlElement()||
|+|MktOrIndctvPric|ISO20022.Sese037001.PriceType4Choice||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|PoolNb|ISO20022.Sese037001.GenericIdentification37||XmlElement()||
|+|CpnAttchdNb|ISO20022.Sese037001.Number22Choice||XmlElement()||
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
|+|OptnTp|ISO20022.Sese037001.OptionType6Choice||XmlElement()||
|+|OptnStyle|ISO20022.Sese037001.OptionStyle8Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Sese037001.ClassificationType32Choice||XmlElement()||
|+|VarblRateChngFrqcy|ISO20022.Sese037001.Frequency23Choice||XmlElement()||
|+|PmtSts|ISO20022.Sese037001.SecuritiesPaymentStatus5Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Sese037001.Frequency23Choice||XmlElement()||
|+|RegnForm|ISO20022.Sese037001.FormOfSecurity6Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Sese037001.InterestComputationMethodFormat4Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Sese037001.MarketIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""UndrlygFinInstrmId""",UndrlygFinInstrmId),validElement(UndrlygFinInstrmId),validElement(CtrctSz),validElement(MinNmnlQty),validElement(StrkPric),validElement(ConvsPric),validElement(SbcptPric),validElement(ExrcPric),validElement(MktOrIndctvPric),validElement(PoolNb),validElement(CpnAttchdNb),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnTp),validElement(OptnStyle),validElement(ClssfctnTp),validElement(VarblRateChngFrqcy),validElement(PmtSts),validElement(PmtFrqcy),validElement(RegnForm),validElement(DayCntBsis),validElement(PlcOfListg))|

---

## Value ISO20022.Sese037001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese037001.ForeignExchangeTerms23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Sese037001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese037001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Sese037001.FormOfSecurity6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037001.Frequency23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese037001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese037001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese037001.GenericIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese037001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037001.IdentificationType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese037001.InterestComputationMethod2Code


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

## Value ISO20022.Sese037001.InterestComputationMethodFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037001.MarketIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese037001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Sese037001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Sese037001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Sese037001.Number22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|ISO20022.Sese037001.GenericIdentification1||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lng),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Value ISO20022.Sese037001.Number3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|String||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lng""",Lng,"""[0-9]{5}"""),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Enum ISO20022.Sese037001.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Sese037001.OptionStyle8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese037001.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Sese037001.OptionType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037001.OtherAmounts29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcrdCptlstnAmt|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
|+|CsmptnTax|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
|+|WhldgTax|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
|+|ValAddedTax|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
|+|TxTax|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
|+|TrfTax|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
|+|StockXchgTax|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
|+|StmpDty|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
|+|ShppgAmt|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
|+|RgltryAmt|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
|+|Othr|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
|+|LclTax|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
|+|PmtLevyTax|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
|+|CtryNtlFdrlTax|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
|+|ChrgsFees|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Sese037001.AmountAndDirection44||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcrdCptlstnAmt),validElement(CsmptnTax),validElement(WhldgTax),validElement(ValAddedTax),validElement(TxTax),validElement(TrfTax),validElement(StockXchgTax),validElement(StmpDty),validElement(ShppgAmt),validElement(RgltryAmt),validElement(Othr),validElement(LclTax),validElement(PmtLevyTax),validElement(CtryNtlFdrlTax),validElement(ChrgsFees),validElement(AcrdIntrstAmt))|

---

## Value ISO20022.Sese037001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese037001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese037001.OtherParties39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TradRgltr|ISO20022.Sese037001.PartyIdentification136||XmlElement()||
|+|StockXchg|ISO20022.Sese037001.PartyIdentification136||XmlElement()||
|+|Invstr|ISO20022.Sese037001.PartyIdentification149||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TradRgltr),validElement(StockXchg),validElement(Invstr))|

---

## Enum ISO20022.Sese037001.OwnershipLegalRestrictions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSTR|Int32||XmlEnum("""RSTR""")|1|
||NRST|Int32||XmlEnum("""NRST""")|2|
||A144|Int32||XmlEnum("""A144""")|3|

---

## Value ISO20022.Sese037001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Sese037001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese037001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese037001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese037001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese037001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese037001.PartyIdentification134Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese037001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese037001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese037001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese037001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese037001.PartyIdentification144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese037001.PartyIdentification127Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese037001.PartyIdentification149


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese037001.PartyIdentification134Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese037001.PartyIdentification257Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese037001.NameAndAddress5||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(DgtlLdgrId,Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese037001.PartyIdentification315


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese037001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese037001.DateAndDateTime2Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese037001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese037001.PartyIdentification257Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese037001.PartyIdentificationAndAccount196


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese037001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese037001.DateAndDateTime2Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese037001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese037001.SecuritiesAccount19||XmlElement()||
|+|AltrnId|ISO20022.Sese037001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese037001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese037001.PartyTextInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Sese037001.PendingFailingReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|

---

## Value ISO20022.Sese037001.PendingProcessingReason14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese037001.PendingProcessingReason16Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese037001.PendingProcessingReason16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037001.PendingProcessingStatus17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese037001.PendingProcessingReason14>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Aspect ISO20022.Sese037001.PortfolioTransferNotificationV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrfNtfctnDtls|global::System.Collections.Generic.List<ISO20022.Sese037001.SecuritiesTradeDetails148>||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese037001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese037001.SecuritiesAccount19||XmlElement()||
|+|AcctOwnr|ISO20022.Sese037001.PartyIdentification144||XmlElement()||
|+|StmtGnlDtls|ISO20022.Sese037001.Statement62||XmlElement()||
|+|Pgntn|ISO20022.Sese037001.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TrfNtfctnDtls""",TrfNtfctnDtls),validElement(TrfNtfctnDtls),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(StmtGnlDtls),validElement(Pgntn))|

---

## Value ISO20022.Sese037001.PortfolioTransferStatus2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.ProprietaryStatusAndReason6||XmlElement()||
|+|Rjctd|ISO20022.Sese037001.RejectionStatus30Choice||XmlElement()||
|+|PdgPrcg|ISO20022.Sese037001.PendingProcessingStatus17Choice||XmlElement()||
|+|AckdAccptd|ISO20022.Sese037001.AcknowledgedAcceptedStatus32Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Rjctd),validElement(PdgPrcg),validElement(AckdAccptd),validChoice(Prtry,Rjctd,PdgPrcg,AckdAccptd))|

---

## Value ISO20022.Sese037001.PostalAddress1


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

## Value ISO20022.Sese037001.Price7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Sese037001.PriceRateOrAmount3Choice||XmlElement()||
|+|Tp|ISO20022.Sese037001.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Sese037001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese037001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Sese037001.PriceType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indctv|ISO20022.Sese037001.Price7||XmlElement()||
|+|Mkt|ISO20022.Sese037001.Price7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indctv),validElement(Mkt),validChoice(Indctv,Mkt))|

---

## Enum ISO20022.Sese037001.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Sese037001.ProprietaryReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Sese037001.ProprietaryStatusAndReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Sese037001.ProprietaryReason4>||XmlElement()||
|+|PrtrySts|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Sese037001.Quantity48


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Sese037001.QuantityBreakdown62>||XmlElement()||
|+|CertNb|global::System.Collections.Generic.List<ISO20022.Sese037001.SecuritiesCertificate4>||XmlElement()||
|+|DnmtnChc|String||XmlElement()||
|+|SttlmQty|ISO20022.Sese037001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validList("""CertNb""",CertNb),validElement(CertNb),validElement(SttlmQty))|

---

## Value ISO20022.Sese037001.QuantityBreakdown62


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TpOfPric|ISO20022.Sese037001.TypeOfPrice29Choice||XmlElement()||
|+|LotPric|ISO20022.Sese037001.Price7||XmlElement()||
|+|LotDtTm|ISO20022.Sese037001.DateAndDateTime2Choice||XmlElement()||
|+|LotQty|ISO20022.Sese037001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|LotNb|ISO20022.Sese037001.GenericIdentification37||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TpOfPric),validElement(LotPric),validElement(LotDtTm),validElement(LotQty),validElement(LotNb))|

---

## Enum ISO20022.Sese037001.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Enum ISO20022.Sese037001.Registration1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YREG|Int32||XmlEnum("""YREG""")|1|
||NREG|Int32||XmlEnum("""NREG""")|2|

---

## Value ISO20022.Sese037001.Registration9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037001.RejectionReason37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037001.RejectionReason49


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese037001.RejectionReason37Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Enum ISO20022.Sese037001.RejectionReason55Code


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

## Value ISO20022.Sese037001.RejectionStatus30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese037001.RejectionReason49>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese037001.Reporting1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGU|Int32||XmlEnum("""REGU""")|1|
||STEX|Int32||XmlEnum("""STEX""")|2|

---

## Value ISO20022.Sese037001.Reporting7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037001.Restriction5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese037001.SecuritiesCertificate4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Sese037001.SecuritiesPaymentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NILL|Int32||XmlEnum("""NILL""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Sese037001.SecuritiesPaymentStatus5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037001.SecuritiesRTGS4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese037001.SecuritiesTradeDetails148


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese037001.SupplementaryData1>||XmlElement()||
|+|OthrBizPties|ISO20022.Sese037001.OtherParties39||XmlElement()||
|+|OthrAmts|ISO20022.Sese037001.OtherAmounts29||XmlElement()||
|+|SttlmAmt|ISO20022.Sese037001.AmountAndDirection52||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese037001.SettlementParties128||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese037001.SettlementParties128||XmlElement()||
|+|SttlmParams|ISO20022.Sese037001.SettlementDetails100||XmlElement()||
|+|QtyDtls|ISO20022.Sese037001.Quantity48||XmlElement()||
|+|Rptg|global::System.Collections.Generic.List<ISO20022.Sese037001.Reporting7Choice>||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Sese037001.FinancialInstrumentAttributes111||XmlElement()||
|+|FinInstrmId|ISO20022.Sese037001.SecurityIdentification19||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|SttlmDt|ISO20022.Sese037001.SettlementDate17Choice||XmlElement()||
|+|TradDt|ISO20022.Sese037001.TradeDate8Choice||XmlElement()||
|+|Sts|ISO20022.Sese037001.PortfolioTransferStatus2Choice||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
|+|CmonId|String||XmlElement()||
|+|NtfctnRcvrTxId|String||XmlElement()||
|+|NtfctnSndrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(OthrBizPties),validElement(OthrAmts),validElement(SttlmAmt),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(SttlmParams),validElement(QtyDtls),validList("""Rptg""",Rptg),validElement(Rptg),validElement(FinInstrmAttrbts),validElement(FinInstrmId),validElement(SttlmDt),validElement(TradDt),validElement(Sts))|

---

## Value ISO20022.Sese037001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese037001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese037001.SettlementDate17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese037001.SettlementDateCode7Choice||XmlElement()||
|+|Dt|ISO20022.Sese037001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Sese037001.SettlementDate4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WISS|Int32||XmlEnum("""WISS""")|1|

---

## Value ISO20022.Sese037001.SettlementDateCode7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037001.SettlementDetails100


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StmpDtyTaxBsis|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|TaxCpcty|ISO20022.Sese037001.TaxCapacityParty4Choice||XmlElement()||
|+|SttlmSysMtd|ISO20022.Sese037001.SettlementSystemMethod4Choice||XmlElement()||
|+|SctiesRTGS|ISO20022.Sese037001.SecuritiesRTGS4Choice||XmlElement()||
|+|LglRstrctns|ISO20022.Sese037001.Restriction5Choice||XmlElement()||
|+|Regn|ISO20022.Sese037001.Registration9Choice||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese037001.SettlementTransactionCondition19Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmpDtyTaxBsis),validElement(TaxCpcty),validElement(SttlmSysMtd),validElement(SctiesRTGS),validElement(LglRstrctns),validElement(Regn),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond))|

---

## Value ISO20022.Sese037001.SettlementParties128


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese037001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty4|ISO20022.Sese037001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty3|ISO20022.Sese037001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty2|ISO20022.Sese037001.PartyIdentificationAndAccount196||XmlElement()||
|+|Pty1|ISO20022.Sese037001.PartyIdentificationAndAccount196||XmlElement()||
|+|Dpstry|ISO20022.Sese037001.PartyIdentification315||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Sese037001.SettlementSystemMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSET|Int32||XmlEnum("""YSET""")|1|
||NSET|Int32||XmlEnum("""NSET""")|2|

---

## Value ISO20022.Sese037001.SettlementSystemMethod4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037001.SettlementTransactionCondition19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese037001.SettlementTransactionCondition3Code


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

## Value ISO20022.Sese037001.Statement62


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ActvtyInd|String||XmlElement()||
|+|UpdTp|ISO20022.Sese037001.UpdateType15Choice||XmlElement()||
|+|StmtDtTm|ISO20022.Sese037001.DateAndDateTime2Choice||XmlElement()||
|+|StmtId|String||XmlElement()||
|+|RptNb|ISO20022.Sese037001.Number3Choice||XmlElement()||
|+|CtrPtyPrtflTrfNtfctnRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UpdTp),validElement(StmtDtTm),validElement(RptNb))|

---

## Enum ISO20022.Sese037001.StatementUpdateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Sese037001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese037001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese037001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese037001.TaxCapacityParty4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese037001.TaxLiability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGEN|Int32||XmlEnum("""AGEN""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Sese037001.TradeDate8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese037001.TradeDateCode3Choice||XmlElement()||
|+|Dt|ISO20022.Sese037001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese037001.TradeDateCode3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese037001.TypeOfIdentification1Code


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

## Enum ISO20022.Sese037001.TypeOfPrice14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AVER|Int32||XmlEnum("""AVER""")|1|

---

## Value ISO20022.Sese037001.TypeOfPrice29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037001.UpdateType15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese037001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese037001.YieldedOrValueType1Choice


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

