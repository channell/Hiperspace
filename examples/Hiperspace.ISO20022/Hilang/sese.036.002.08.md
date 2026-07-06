# sese.036.002.08
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese036002.AlternatePartyIdentification9 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Sese036002.IdentificationType44Choice
    }
    ISO20022.Sese036002.AlternatePartyIdentification9 *-- ISO20022.Sese036002.IdentificationType44Choice
    class ISO20022.Sese036002.AmountAndDirection59 {
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese036002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Sese036002.AmountAndDirection59 *-- ISO20022.Sese036002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese036002.AmountAndDirection66 {
        + FXDtls  : ISO20022.Sese036002.ForeignExchangeTerms27
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese036002.RestrictedFINActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese036002.RestrictedFINActiveCurrencyAndAmount
    }
    ISO20022.Sese036002.AmountAndDirection66 *-- ISO20022.Sese036002.ForeignExchangeTerms27
    ISO20022.Sese036002.AmountAndDirection66 *-- ISO20022.Sese036002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese036002.AmountAndDirection66 *-- ISO20022.Sese036002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese036002.AutoBorrowing1Code {
        YBOR = 1
        NBOR = 2
        LAMI = 3
    }
    class ISO20022.Sese036002.AutomaticBorrowing8Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese036002.AutomaticBorrowing8Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.BeneficialOwnership5Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese036002.BeneficialOwnership5Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Sese036002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese036002.BlockChainAddressWallet7 *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.BlockTrade1Code {
        BLCH = 1
        BLPA = 2
    }
    class ISO20022.Sese036002.BlockTrade5Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese036002.BlockTrade5Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.CashAccountIdentification6Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Sese036002.CashSettlementSystem2Code {
        NETS = 1
        GROS = 2
    }
    class ISO20022.Sese036002.CashSettlementSystem5Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese036002.CashSettlementSystem5Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.CentralCounterPartyEligibility5Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese036002.CentralCounterPartyEligibility5Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese036002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese036002.DateCode32Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese036002.DateCode32Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.DateType5Code {
        OPEN = 1
    }
    class ISO20022.Sese036002.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese036002.FXStandingInstruction5Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese036002.FXStandingInstruction5Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese036002.ForeignExchangeTerms27 {
        + RsltgAmt  : ISO20022.Sese036002.RestrictedFINActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Sese036002.ForeignExchangeTerms27 *-- ISO20022.Sese036002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese036002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese036002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese036002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Sese036002.GenericIdentification47
    }
    ISO20022.Sese036002.GenericIdentification85 *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese036002.IdentificationType44Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese036002.IdentificationType44Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.InterestComputationMethod2Code {
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
    class ISO20022.Sese036002.InterestComputationMethodFormat5Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese036002.InterestComputationMethodFormat5Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.LegalFramework1Code {
        FRAN = 1
    }
    class ISO20022.Sese036002.LegalFramework4Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese036002.LegalFramework4Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.MarketClientSide1Code {
        MAKT = 1
        CLNT = 2
    }
    class ISO20022.Sese036002.MarketClientSide7Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese036002.MarketClientSide7Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Sese036002.NettingEligibility5Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese036002.NettingEligibility5Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.OtherIdentification2 {
        + Tp  : ISO20022.Sese036002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese036002.OtherIdentification2 *-- ISO20022.Sese036002.IdentificationSource4Choice
    class ISO20022.Sese036002.OwnershipLegalRestrictions1Code {
        RSTR = 1
        NRST = 2
        A144 = 3
    }
    class ISO20022.Sese036002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Sese036002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese036002.PartyIdentification136Choice *-- ISO20022.Sese036002.GenericIdentification84
    class ISO20022.Sese036002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Sese036002.NameAndAddress12
        + PrtryId  : ISO20022.Sese036002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese036002.PartyIdentification137Choice *-- ISO20022.Sese036002.NameAndAddress12
    ISO20022.Sese036002.PartyIdentification137Choice *-- ISO20022.Sese036002.GenericIdentification84
    class ISO20022.Sese036002.PartyIdentification145Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese036002.NameAndAddress12
        + AnyBIC  : String
    }
    ISO20022.Sese036002.PartyIdentification145Choice *-- ISO20022.Sese036002.NameAndAddress12
    class ISO20022.Sese036002.PartyIdentification156 {
        + LEI  : String
        + Id  : ISO20022.Sese036002.PartyIdentification136Choice
    }
    ISO20022.Sese036002.PartyIdentification156 *-- ISO20022.Sese036002.PartyIdentification136Choice
    class ISO20022.Sese036002.PartyIdentification162 {
        + AddtlInf  : ISO20022.Sese036002.PartyTextInformation3
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese036002.DateAndDateTime2Choice
        + AltrnId  : ISO20022.Sese036002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese036002.PartyIdentification145Choice
    }
    ISO20022.Sese036002.PartyIdentification162 *-- ISO20022.Sese036002.PartyTextInformation3
    ISO20022.Sese036002.PartyIdentification162 *-- ISO20022.Sese036002.DateAndDateTime2Choice
    ISO20022.Sese036002.PartyIdentification162 *-- ISO20022.Sese036002.AlternatePartyIdentification9
    ISO20022.Sese036002.PartyIdentification162 *-- ISO20022.Sese036002.PartyIdentification145Choice
    class ISO20022.Sese036002.PartyIdentificationAndAccount213 {
        + AddtlInf  : ISO20022.Sese036002.PartyTextInformation3
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese036002.DateAndDateTime2Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese036002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese036002.SecuritiesAccount37
        + AltrnId  : ISO20022.Sese036002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese036002.PartyIdentification137Choice
    }
    ISO20022.Sese036002.PartyIdentificationAndAccount213 *-- ISO20022.Sese036002.PartyTextInformation3
    ISO20022.Sese036002.PartyIdentificationAndAccount213 *-- ISO20022.Sese036002.DateAndDateTime2Choice
    ISO20022.Sese036002.PartyIdentificationAndAccount213 *-- ISO20022.Sese036002.BlockChainAddressWallet7
    ISO20022.Sese036002.PartyIdentificationAndAccount213 *-- ISO20022.Sese036002.SecuritiesAccount37
    ISO20022.Sese036002.PartyIdentificationAndAccount213 *-- ISO20022.Sese036002.AlternatePartyIdentification9
    ISO20022.Sese036002.PartyIdentificationAndAccount213 *-- ISO20022.Sese036002.PartyIdentification137Choice
    class ISO20022.Sese036002.PartyTextInformation3 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese036002.PriorityNumeric5Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Nmrc  : String
    }
    ISO20022.Sese036002.PriorityNumeric5Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.QuantityAndAccount105 {
        + SfkpgPlc  : ISO20022.Sese036002.SafeKeepingPlace4
        + CshAcct  : ISO20022.Sese036002.CashAccountIdentification6Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese036002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese036002.SecuritiesAccount30
        + AcctOwnr  : ISO20022.Sese036002.PartyIdentification156
        + SttlmQty  : ISO20022.Sese036002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Sese036002.QuantityAndAccount105 *-- ISO20022.Sese036002.SafeKeepingPlace4
    ISO20022.Sese036002.QuantityAndAccount105 *-- ISO20022.Sese036002.CashAccountIdentification6Choice
    ISO20022.Sese036002.QuantityAndAccount105 *-- ISO20022.Sese036002.BlockChainAddressWallet7
    ISO20022.Sese036002.QuantityAndAccount105 *-- ISO20022.Sese036002.SecuritiesAccount30
    ISO20022.Sese036002.QuantityAndAccount105 *-- ISO20022.Sese036002.PartyIdentification156
    ISO20022.Sese036002.QuantityAndAccount105 *-- ISO20022.Sese036002.FinancialInstrumentQuantity36Choice
    class ISO20022.Sese036002.Rate2 {
        + Rate  : Decimal
        + Sgn  : String
    }
    class ISO20022.Sese036002.RateName2 {
        + RateNm  : String
        + Issr  : String
    }
    class ISO20022.Sese036002.RateOrName2Choice {
        + RateNm  : ISO20022.Sese036002.RateName2
        + Rate  : ISO20022.Sese036002.Rate2
    }
    ISO20022.Sese036002.RateOrName2Choice *-- ISO20022.Sese036002.RateName2
    ISO20022.Sese036002.RateOrName2Choice *-- ISO20022.Sese036002.Rate2
    class ISO20022.Sese036002.RateType1Code {
        VARI = 1
        FORF = 2
        FIXE = 3
    }
    class ISO20022.Sese036002.RateType67Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese036002.RateType67Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.RepurchaseType31Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese036002.RepurchaseType31Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.RepurchaseType8Code {
        CALL = 1
        RATE = 2
        ROLP = 3
        PADJ = 4
    }
    class ISO20022.Sese036002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese036002.RestrictedFINActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese036002.Restriction6Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese036002.Restriction6Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.RevaluationIndicator4Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese036002.RevaluationIndicator4Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.SafeKeepingPlace4 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Sese036002.SafekeepingPlaceFormat39Choice
    }
    ISO20022.Sese036002.SafeKeepingPlace4 *-- ISO20022.Sese036002.SafekeepingPlaceFormat39Choice
    class ISO20022.Sese036002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Sese036002.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Sese036002.SafekeepingPlaceFormat39Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification85
        + TpAndId  : ISO20022.Sese036002.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Sese036002.SafekeepingPlaceTypeAndText15
    }
    ISO20022.Sese036002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese036002.GenericIdentification85
    ISO20022.Sese036002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese036002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Sese036002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese036002.SafekeepingPlaceTypeAndText15
    class ISO20022.Sese036002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese036002.SafekeepingPlaceTypeAndText15 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese036002.SecuritiesAccount30 {
        + Nm  : String
        + Tp  : ISO20022.Sese036002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese036002.SecuritiesAccount30 *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.SecuritiesAccount37 {
        + Nm  : String
        + Tp  : ISO20022.Sese036002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese036002.SecuritiesAccount37 *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.SecuritiesFinancingModificationInstruction002V08 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese036002.SupplementaryData1~
        + OpngSttlmAmt  : ISO20022.Sese036002.AmountAndDirection66
        + RcvgSttlmPties  : ISO20022.Sese036002.SettlementParties107
        + DlvrgSttlmPties  : ISO20022.Sese036002.SettlementParties107
        + SttlmParams  : ISO20022.Sese036002.SettlementDetails172
        + SctiesFincgAddtlDtls  : ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48
        + QtyAndAcctDtls  : ISO20022.Sese036002.QuantityAndAccount105
        + FinInstrmId  : ISO20022.Sese036002.SecurityIdentification20
        + TradDtls  : ISO20022.Sese036002.SecuritiesTradeDetails103
        + TxTpAndModAddtlParams  : ISO20022.Sese036002.TransactionTypeAndAdditionalParameters20
    }
    ISO20022.Sese036002.SecuritiesFinancingModificationInstruction002V08 *-- ISO20022.Sese036002.SupplementaryData1
    ISO20022.Sese036002.SecuritiesFinancingModificationInstruction002V08 *-- ISO20022.Sese036002.AmountAndDirection66
    ISO20022.Sese036002.SecuritiesFinancingModificationInstruction002V08 *-- ISO20022.Sese036002.SettlementParties107
    ISO20022.Sese036002.SecuritiesFinancingModificationInstruction002V08 *-- ISO20022.Sese036002.SettlementParties107
    ISO20022.Sese036002.SecuritiesFinancingModificationInstruction002V08 *-- ISO20022.Sese036002.SettlementDetails172
    ISO20022.Sese036002.SecuritiesFinancingModificationInstruction002V08 *-- ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48
    ISO20022.Sese036002.SecuritiesFinancingModificationInstruction002V08 *-- ISO20022.Sese036002.QuantityAndAccount105
    ISO20022.Sese036002.SecuritiesFinancingModificationInstruction002V08 *-- ISO20022.Sese036002.SecurityIdentification20
    ISO20022.Sese036002.SecuritiesFinancingModificationInstruction002V08 *-- ISO20022.Sese036002.SecuritiesTradeDetails103
    ISO20022.Sese036002.SecuritiesFinancingModificationInstruction002V08 *-- ISO20022.Sese036002.TransactionTypeAndAdditionalParameters20
    class ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 {
        + ScndLegNrrtv  : String
        + TermntnTxAmt  : ISO20022.Sese036002.AmountAndDirection59
        + TermntnAmtPerPcOfColl  : ISO20022.Sese036002.AmountAndDirection59
        + PrmAmt  : ISO20022.Sese036002.AmountAndDirection59
        + FrftAmt  : ISO20022.Sese036002.AmountAndDirection59
        + AcrdIntrstAmt  : ISO20022.Sese036002.AmountAndDirection59
        + DealAmt  : ISO20022.Sese036002.AmountAndDirection59
        + LclBrkrComssn  : ISO20022.Sese036002.AmountAndDirection59
        + TtlNbOfCollInstrs  : String
        + TxCallDely  : String
        + Sprd  : ISO20022.Sese036002.Rate2
        + PricgRate  : ISO20022.Sese036002.RateOrName2Choice
        + ChrgsRate  : ISO20022.Sese036002.Rate2
        + SctiesHrcut  : ISO20022.Sese036002.Rate2
        + StockLnMrgn  : ISO20022.Sese036002.Rate2
        + RpRate  : ISO20022.Sese036002.Rate2
        + VarblRateSpprt  : ISO20022.Sese036002.RateName2
        + IntrstPmt  : String
        + MtrtyDtMod  : String
        + IntrstCmptnMtd  : ISO20022.Sese036002.InterestComputationMethodFormat5Choice
        + LglFrmwk  : ISO20022.Sese036002.LegalFramework4Choice
        + Rvaltn  : ISO20022.Sese036002.RevaluationIndicator4Choice
        + RateTp  : ISO20022.Sese036002.RateType67Choice
        + ComssnClctnDt  : ISO20022.Sese036002.DateAndDateTime2Choice
        + EarlstCallBckDt  : ISO20022.Sese036002.DateAndDateTime2Choice
        + RateChngDt  : ISO20022.Sese036002.DateAndDateTime2Choice
        + TermntnDt  : ISO20022.Sese036002.TerminationDate7Choice
        + ClsgLegId  : String
        + SctiesFincgTradId  : String
    }
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.AmountAndDirection59
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.AmountAndDirection59
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.AmountAndDirection59
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.AmountAndDirection59
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.AmountAndDirection59
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.AmountAndDirection59
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.AmountAndDirection59
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.Rate2
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.RateOrName2Choice
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.Rate2
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.Rate2
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.Rate2
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.Rate2
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.RateName2
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.InterestComputationMethodFormat5Choice
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.LegalFramework4Choice
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.RevaluationIndicator4Choice
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.RateType67Choice
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.DateAndDateTime2Choice
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.DateAndDateTime2Choice
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.DateAndDateTime2Choice
    ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48 *-- ISO20022.Sese036002.TerminationDate7Choice
    class ISO20022.Sese036002.SecuritiesFinancingTransactionType2Code {
        SBBK = 1
        BSBK = 2
        SECL = 3
        SECB = 4
        RVPO = 5
        REPU = 6
    }
    class ISO20022.Sese036002.SecuritiesRTGS5Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese036002.SecuritiesRTGS5Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.SecuritiesTradeDetails103 {
        + InstrPrcgAddtlDtls  : String
        + NbOfDaysAcrd  : Decimal
        + OpngSttlmDt  : ISO20022.Sese036002.DateAndDateTime2Choice
        + TradDt  : ISO20022.Sese036002.DateAndDateTime2Choice
    }
    ISO20022.Sese036002.SecuritiesTradeDetails103 *-- ISO20022.Sese036002.DateAndDateTime2Choice
    ISO20022.Sese036002.SecuritiesTradeDetails103 *-- ISO20022.Sese036002.DateAndDateTime2Choice
    class ISO20022.Sese036002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese036002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Sese036002.SecurityIdentification20 *-- ISO20022.Sese036002.OtherIdentification2
    class ISO20022.Sese036002.SettlementDetails172 {
        + ElgblForColl  : String
        + PrtlSttlmInd  : String
        + AutomtcBrrwg  : ISO20022.Sese036002.AutomaticBorrowing8Choice
        + Trckg  : ISO20022.Sese036002.Tracking5Choice
        + CCPElgblty  : ISO20022.Sese036002.CentralCounterPartyEligibility5Choice
        + NetgElgblty  : ISO20022.Sese036002.NettingEligibility5Choice
        + SttlmSysMtd  : ISO20022.Sese036002.SettlementSystemMethod5Choice
        + LglRstrctns  : ISO20022.Sese036002.Restriction6Choice
        + BlckTrad  : ISO20022.Sese036002.BlockTrade5Choice
        + FxStgInstr  : ISO20022.Sese036002.FXStandingInstruction5Choice
        + MktClntSd  : ISO20022.Sese036002.MarketClientSide7Choice
        + TaxCpcty  : ISO20022.Sese036002.TaxCapacityParty5Choice
        + CshClrSys  : ISO20022.Sese036002.CashSettlementSystem5Choice
        + BnfclOwnrsh  : ISO20022.Sese036002.BeneficialOwnership5Choice
        + SctiesRTGS  : ISO20022.Sese036002.SecuritiesRTGS5Choice
        + StmpDtyTaxBsis  : ISO20022.Sese036002.GenericIdentification47
        + SttlgCpcty  : ISO20022.Sese036002.SettlingCapacity8Choice
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese036002.SettlementTransactionCondition22Choice~
        + Prty  : ISO20022.Sese036002.PriorityNumeric5Choice
        + HldInd  : String
    }
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.AutomaticBorrowing8Choice
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.Tracking5Choice
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.CentralCounterPartyEligibility5Choice
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.NettingEligibility5Choice
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.SettlementSystemMethod5Choice
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.Restriction6Choice
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.BlockTrade5Choice
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.FXStandingInstruction5Choice
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.MarketClientSide7Choice
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.TaxCapacityParty5Choice
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.CashSettlementSystem5Choice
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.BeneficialOwnership5Choice
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.SecuritiesRTGS5Choice
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.GenericIdentification47
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.SettlingCapacity8Choice
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.SettlementTransactionCondition22Choice
    ISO20022.Sese036002.SettlementDetails172 *-- ISO20022.Sese036002.PriorityNumeric5Choice
    class ISO20022.Sese036002.SettlementParties107 {
        + Pty5  : ISO20022.Sese036002.PartyIdentificationAndAccount213
        + Pty4  : ISO20022.Sese036002.PartyIdentificationAndAccount213
        + Pty3  : ISO20022.Sese036002.PartyIdentificationAndAccount213
        + Pty2  : ISO20022.Sese036002.PartyIdentificationAndAccount213
        + Pty1  : ISO20022.Sese036002.PartyIdentificationAndAccount213
        + Dpstry  : ISO20022.Sese036002.PartyIdentification162
    }
    ISO20022.Sese036002.SettlementParties107 *-- ISO20022.Sese036002.PartyIdentificationAndAccount213
    ISO20022.Sese036002.SettlementParties107 *-- ISO20022.Sese036002.PartyIdentificationAndAccount213
    ISO20022.Sese036002.SettlementParties107 *-- ISO20022.Sese036002.PartyIdentificationAndAccount213
    ISO20022.Sese036002.SettlementParties107 *-- ISO20022.Sese036002.PartyIdentificationAndAccount213
    ISO20022.Sese036002.SettlementParties107 *-- ISO20022.Sese036002.PartyIdentificationAndAccount213
    ISO20022.Sese036002.SettlementParties107 *-- ISO20022.Sese036002.PartyIdentification162
    class ISO20022.Sese036002.SettlementSystemMethod1Code {
        YSET = 1
        NSET = 2
    }
    class ISO20022.Sese036002.SettlementSystemMethod5Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese036002.SettlementSystemMethod5Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.SettlementTransactionCondition22Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese036002.SettlementTransactionCondition22Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.SettlementTransactionCondition5Code {
        PARQ = 1
        PARC = 2
        NPAR = 3
        PART = 4
    }
    class ISO20022.Sese036002.SettlementTransactionCondition6Code {
        ADEA = 1
        RHYP = 2
        TRAN = 3
        NOMC = 4
        TRIP = 5
        UNEX = 6
        PENS = 7
        EXPI = 8
        SPST = 9
        SPDL = 10
        SHOR = 11
        RESI = 12
        PHYS = 13
        KNOC = 14
        FRCL = 15
        EXER = 16
        DRAW = 17
        DLWM = 18
        DIRT = 19
        CLEN = 20
        BUTC = 21
        ASGN = 22
    }
    class ISO20022.Sese036002.SettlingCapacity2Code {
        RISP = 1
        SPRI = 2
        CUST = 3
        SAGE = 4
    }
    class ISO20022.Sese036002.SettlingCapacity8Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese036002.SettlingCapacity8Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.SupplementaryData1 {
        + Envlp  : ISO20022.Sese036002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese036002.SupplementaryData1 *-- ISO20022.Sese036002.SupplementaryDataEnvelope1
    class ISO20022.Sese036002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese036002.TaxCapacityParty5Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese036002.TaxCapacityParty5Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.TaxLiability1Code {
        AGEN = 1
        PRIN = 2
    }
    class ISO20022.Sese036002.TerminationDate7Choice {
        + Cd  : ISO20022.Sese036002.DateCode32Choice
        + Dt  : ISO20022.Sese036002.DateAndDateTime2Choice
    }
    ISO20022.Sese036002.TerminationDate7Choice *-- ISO20022.Sese036002.DateCode32Choice
    ISO20022.Sese036002.TerminationDate7Choice *-- ISO20022.Sese036002.DateAndDateTime2Choice
    class ISO20022.Sese036002.Tracking5Choice {
        + Prtry  : ISO20022.Sese036002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese036002.Tracking5Choice *-- ISO20022.Sese036002.GenericIdentification47
    class ISO20022.Sese036002.TransactionTypeAndAdditionalParameters20 {
        + PoolId  : String
        + CmonId  : String
        + ModTp  : ISO20022.Sese036002.RepurchaseType31Choice
        + Pmt  : String
        + SctiesFincgTxTp  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    ISO20022.Sese036002.TransactionTypeAndAdditionalParameters20 *-- ISO20022.Sese036002.RepurchaseType31Choice
    class ISO20022.Sese036002.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
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

## Value ISO20022.Sese036002.AlternatePartyIdentification9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Sese036002.IdentificationType44Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AltrnId""",AltrnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Sese036002.AmountAndDirection59


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese036002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Sese036002.AmountAndDirection66


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Sese036002.ForeignExchangeTerms27||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese036002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Enum ISO20022.Sese036002.AutoBorrowing1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YBOR|Int32||XmlEnum("""YBOR""")|1|
||NBOR|Int32||XmlEnum("""NBOR""")|2|
||LAMI|Int32||XmlEnum("""LAMI""")|3|

---

## Value ISO20022.Sese036002.AutomaticBorrowing8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036002.BeneficialOwnership5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese036002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Enum ISO20022.Sese036002.BlockTrade1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BLCH|Int32||XmlEnum("""BLCH""")|1|
||BLPA|Int32||XmlEnum("""BLPA""")|2|

---

## Value ISO20022.Sese036002.BlockTrade5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036002.CashAccountIdentification6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,34}"""),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Enum ISO20022.Sese036002.CashSettlementSystem2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETS|Int32||XmlEnum("""NETS""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Value ISO20022.Sese036002.CashSettlementSystem5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036002.CentralCounterPartyEligibility5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Enum ISO20022.Sese036002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese036002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Sese036002.DateCode32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese036002.DateType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEN|Int32||XmlEnum("""OPEN""")|1|

---

## Enum ISO20022.Sese036002.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Type ISO20022.Sese036002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesFincgModInstr|ISO20022.Sese036002.SecuritiesFinancingModificationInstruction002V08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesFincgModInstr))|

---

## Value ISO20022.Sese036002.FXStandingInstruction5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese036002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese036002.ForeignExchangeTerms27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Sese036002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese036002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese036002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese036002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Sese036002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036002.IdentificationType44Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese036002.InterestComputationMethod2Code


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

## Value ISO20022.Sese036002.InterestComputationMethodFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese036002.LegalFramework1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRAN|Int32||XmlEnum("""FRAN""")|1|

---

## Value ISO20022.Sese036002.LegalFramework4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese036002.MarketClientSide1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MAKT|Int32||XmlEnum("""MAKT""")|1|
||CLNT|Int32||XmlEnum("""CLNT""")|2|

---

## Value ISO20022.Sese036002.MarketClientSide7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Sese036002.NettingEligibility5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese036002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese036002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Enum ISO20022.Sese036002.OwnershipLegalRestrictions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSTR|Int32||XmlEnum("""RSTR""")|1|
||NRST|Int32||XmlEnum("""NRST""")|2|
||A144|Int32||XmlEnum("""A144""")|3|

---

## Value ISO20022.Sese036002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese036002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese036002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese036002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese036002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese036002.PartyIdentification145Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese036002.NameAndAddress12||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese036002.PartyIdentification156


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese036002.PartyIdentification136Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese036002.PartyIdentification162


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese036002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese036002.DateAndDateTime2Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese036002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese036002.PartyIdentification145Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(PrcgDt),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese036002.PartyIdentificationAndAccount213


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese036002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese036002.DateAndDateTime2Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese036002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese036002.SecuritiesAccount37||XmlElement()||
|+|AltrnId|ISO20022.Sese036002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese036002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(PrcgDt),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese036002.PartyTextInformation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RegnDtls""",RegnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""PtyCtctDtls""",PtyCtctDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""DclrtnDtls""",DclrtnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Value ISO20022.Sese036002.PriorityNumeric5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Nmrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""Nmrc""",Nmrc,"""[0-9]{4}"""),validChoice(Prtry,Nmrc))|

---

## Value ISO20022.Sese036002.QuantityAndAccount105


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgPlc|ISO20022.Sese036002.SafeKeepingPlace4||XmlElement()||
|+|CshAcct|ISO20022.Sese036002.CashAccountIdentification6Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese036002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese036002.SecuritiesAccount30||XmlElement()||
|+|AcctOwnr|ISO20022.Sese036002.PartyIdentification156||XmlElement()||
|+|SttlmQty|ISO20022.Sese036002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SfkpgPlc),validElement(CshAcct),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(SttlmQty))|

---

## Value ISO20022.Sese036002.Rate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Sgn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese036002.RateName2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RateNm""",RateNm,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""Issr""",Issr,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,8}"""))|

---

## Value ISO20022.Sese036002.RateOrName2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateNm|ISO20022.Sese036002.RateName2||XmlElement()||
|+|Rate|ISO20022.Sese036002.Rate2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateNm),validElement(Rate),validChoice(RateNm,Rate))|

---

## Enum ISO20022.Sese036002.RateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|
||FORF|Int32||XmlEnum("""FORF""")|2|
||FIXE|Int32||XmlEnum("""FIXE""")|3|

---

## Value ISO20022.Sese036002.RateType67Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036002.RepurchaseType31Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese036002.RepurchaseType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CALL|Int32||XmlEnum("""CALL""")|1|
||RATE|Int32||XmlEnum("""RATE""")|2|
||ROLP|Int32||XmlEnum("""ROLP""")|3|
||PADJ|Int32||XmlEnum("""PADJ""")|4|

---

## Value ISO20022.Sese036002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese036002.RestrictedFINActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese036002.Restriction6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036002.RevaluationIndicator4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese036002.SafeKeepingPlace4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Sese036002.SafekeepingPlaceFormat39Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Sese036002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Sese036002.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Sese036002.SafekeepingPlaceFormat39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Sese036002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Sese036002.SafekeepingPlaceTypeAndText15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Sese036002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese036002.SafekeepingPlaceTypeAndText15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese036002.SecuritiesAccount30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Sese036002.SecuritiesAccount37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Aspect ISO20022.Sese036002.SecuritiesFinancingModificationInstruction002V08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese036002.SupplementaryData1>||XmlElement()||
|+|OpngSttlmAmt|ISO20022.Sese036002.AmountAndDirection66||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese036002.SettlementParties107||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese036002.SettlementParties107||XmlElement()||
|+|SttlmParams|ISO20022.Sese036002.SettlementDetails172||XmlElement()||
|+|SctiesFincgAddtlDtls|ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48||XmlElement()||
|+|QtyAndAcctDtls|ISO20022.Sese036002.QuantityAndAccount105||XmlElement()||
|+|FinInstrmId|ISO20022.Sese036002.SecurityIdentification20||XmlElement()||
|+|TradDtls|ISO20022.Sese036002.SecuritiesTradeDetails103||XmlElement()||
|+|TxTpAndModAddtlParams|ISO20022.Sese036002.TransactionTypeAndAdditionalParameters20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(OpngSttlmAmt),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(SttlmParams),validElement(SctiesFincgAddtlDtls),validElement(QtyAndAcctDtls),validElement(FinInstrmId),validElement(TradDtls),validElement(TxTpAndModAddtlParams))|

---

## Value ISO20022.Sese036002.SecuritiesFinancingTransactionDetails48


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLegNrrtv|String||XmlElement()||
|+|TermntnTxAmt|ISO20022.Sese036002.AmountAndDirection59||XmlElement()||
|+|TermntnAmtPerPcOfColl|ISO20022.Sese036002.AmountAndDirection59||XmlElement()||
|+|PrmAmt|ISO20022.Sese036002.AmountAndDirection59||XmlElement()||
|+|FrftAmt|ISO20022.Sese036002.AmountAndDirection59||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Sese036002.AmountAndDirection59||XmlElement()||
|+|DealAmt|ISO20022.Sese036002.AmountAndDirection59||XmlElement()||
|+|LclBrkrComssn|ISO20022.Sese036002.AmountAndDirection59||XmlElement()||
|+|TtlNbOfCollInstrs|String||XmlElement()||
|+|TxCallDely|String||XmlElement()||
|+|Sprd|ISO20022.Sese036002.Rate2||XmlElement()||
|+|PricgRate|ISO20022.Sese036002.RateOrName2Choice||XmlElement()||
|+|ChrgsRate|ISO20022.Sese036002.Rate2||XmlElement()||
|+|SctiesHrcut|ISO20022.Sese036002.Rate2||XmlElement()||
|+|StockLnMrgn|ISO20022.Sese036002.Rate2||XmlElement()||
|+|RpRate|ISO20022.Sese036002.Rate2||XmlElement()||
|+|VarblRateSpprt|ISO20022.Sese036002.RateName2||XmlElement()||
|+|IntrstPmt|String||XmlElement()||
|+|MtrtyDtMod|String||XmlElement()||
|+|IntrstCmptnMtd|ISO20022.Sese036002.InterestComputationMethodFormat5Choice||XmlElement()||
|+|LglFrmwk|ISO20022.Sese036002.LegalFramework4Choice||XmlElement()||
|+|Rvaltn|ISO20022.Sese036002.RevaluationIndicator4Choice||XmlElement()||
|+|RateTp|ISO20022.Sese036002.RateType67Choice||XmlElement()||
|+|ComssnClctnDt|ISO20022.Sese036002.DateAndDateTime2Choice||XmlElement()||
|+|EarlstCallBckDt|ISO20022.Sese036002.DateAndDateTime2Choice||XmlElement()||
|+|RateChngDt|ISO20022.Sese036002.DateAndDateTime2Choice||XmlElement()||
|+|TermntnDt|ISO20022.Sese036002.TerminationDate7Choice||XmlElement()||
|+|ClsgLegId|String||XmlElement()||
|+|SctiesFincgTradId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ScndLegNrrtv""",ScndLegNrrtv,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validElement(TermntnTxAmt),validElement(TermntnAmtPerPcOfColl),validElement(PrmAmt),validElement(FrftAmt),validElement(AcrdIntrstAmt),validElement(DealAmt),validElement(LclBrkrComssn),validPattern("""TtlNbOfCollInstrs""",TtlNbOfCollInstrs,"""[0-9]{3}"""),validPattern("""TxCallDely""",TxCallDely,"""[0-9]{3}"""),validElement(Sprd),validElement(PricgRate),validElement(ChrgsRate),validElement(SctiesHrcut),validElement(StockLnMrgn),validElement(RpRate),validElement(VarblRateSpprt),validElement(IntrstCmptnMtd),validElement(LglFrmwk),validElement(Rvaltn),validElement(RateTp),validElement(ComssnClctnDt),validElement(EarlstCallBckDt),validElement(RateChngDt),validElement(TermntnDt),validPattern("""ClsgLegId""",ClsgLegId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""SctiesFincgTradId""",SctiesFincgTradId,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,52}"""))|

---

## Enum ISO20022.Sese036002.SecuritiesFinancingTransactionType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SBBK|Int32||XmlEnum("""SBBK""")|1|
||BSBK|Int32||XmlEnum("""BSBK""")|2|
||SECL|Int32||XmlEnum("""SECL""")|3|
||SECB|Int32||XmlEnum("""SECB""")|4|
||RVPO|Int32||XmlEnum("""RVPO""")|5|
||REPU|Int32||XmlEnum("""REPU""")|6|

---

## Value ISO20022.Sese036002.SecuritiesRTGS5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese036002.SecuritiesTradeDetails103


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrPrcgAddtlDtls|String||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|OpngSttlmDt|ISO20022.Sese036002.DateAndDateTime2Choice||XmlElement()||
|+|TradDt|ISO20022.Sese036002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""InstrPrcgAddtlDtls""",InstrPrcgAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validElement(OpngSttlmDt),validElement(TradDt))|

---

## Value ISO20022.Sese036002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese036002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese036002.SettlementDetails172


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ElgblForColl|String||XmlElement()||
|+|PrtlSttlmInd|String||XmlElement()||
|+|AutomtcBrrwg|ISO20022.Sese036002.AutomaticBorrowing8Choice||XmlElement()||
|+|Trckg|ISO20022.Sese036002.Tracking5Choice||XmlElement()||
|+|CCPElgblty|ISO20022.Sese036002.CentralCounterPartyEligibility5Choice||XmlElement()||
|+|NetgElgblty|ISO20022.Sese036002.NettingEligibility5Choice||XmlElement()||
|+|SttlmSysMtd|ISO20022.Sese036002.SettlementSystemMethod5Choice||XmlElement()||
|+|LglRstrctns|ISO20022.Sese036002.Restriction6Choice||XmlElement()||
|+|BlckTrad|ISO20022.Sese036002.BlockTrade5Choice||XmlElement()||
|+|FxStgInstr|ISO20022.Sese036002.FXStandingInstruction5Choice||XmlElement()||
|+|MktClntSd|ISO20022.Sese036002.MarketClientSide7Choice||XmlElement()||
|+|TaxCpcty|ISO20022.Sese036002.TaxCapacityParty5Choice||XmlElement()||
|+|CshClrSys|ISO20022.Sese036002.CashSettlementSystem5Choice||XmlElement()||
|+|BnfclOwnrsh|ISO20022.Sese036002.BeneficialOwnership5Choice||XmlElement()||
|+|SctiesRTGS|ISO20022.Sese036002.SecuritiesRTGS5Choice||XmlElement()||
|+|StmpDtyTaxBsis|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|SttlgCpcty|ISO20022.Sese036002.SettlingCapacity8Choice||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese036002.SettlementTransactionCondition22Choice>||XmlElement()||
|+|Prty|ISO20022.Sese036002.PriorityNumeric5Choice||XmlElement()||
|+|HldInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AutomtcBrrwg),validElement(Trckg),validElement(CCPElgblty),validElement(NetgElgblty),validElement(SttlmSysMtd),validElement(LglRstrctns),validElement(BlckTrad),validElement(FxStgInstr),validElement(MktClntSd),validElement(TaxCpcty),validElement(CshClrSys),validElement(BnfclOwnrsh),validElement(SctiesRTGS),validElement(StmpDtyTaxBsis),validElement(SttlgCpcty),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validElement(Prty))|

---

## Value ISO20022.Sese036002.SettlementParties107


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese036002.PartyIdentificationAndAccount213||XmlElement()||
|+|Pty4|ISO20022.Sese036002.PartyIdentificationAndAccount213||XmlElement()||
|+|Pty3|ISO20022.Sese036002.PartyIdentificationAndAccount213||XmlElement()||
|+|Pty2|ISO20022.Sese036002.PartyIdentificationAndAccount213||XmlElement()||
|+|Pty1|ISO20022.Sese036002.PartyIdentificationAndAccount213||XmlElement()||
|+|Dpstry|ISO20022.Sese036002.PartyIdentification162||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Sese036002.SettlementSystemMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSET|Int32||XmlEnum("""YSET""")|1|
||NSET|Int32||XmlEnum("""NSET""")|2|

---

## Value ISO20022.Sese036002.SettlementSystemMethod5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036002.SettlementTransactionCondition22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese036002.SettlementTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARQ|Int32||XmlEnum("""PARQ""")|1|
||PARC|Int32||XmlEnum("""PARC""")|2|
||NPAR|Int32||XmlEnum("""NPAR""")|3|
||PART|Int32||XmlEnum("""PART""")|4|

---

## Enum ISO20022.Sese036002.SettlementTransactionCondition6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ADEA|Int32||XmlEnum("""ADEA""")|1|
||RHYP|Int32||XmlEnum("""RHYP""")|2|
||TRAN|Int32||XmlEnum("""TRAN""")|3|
||NOMC|Int32||XmlEnum("""NOMC""")|4|
||TRIP|Int32||XmlEnum("""TRIP""")|5|
||UNEX|Int32||XmlEnum("""UNEX""")|6|
||PENS|Int32||XmlEnum("""PENS""")|7|
||EXPI|Int32||XmlEnum("""EXPI""")|8|
||SPST|Int32||XmlEnum("""SPST""")|9|
||SPDL|Int32||XmlEnum("""SPDL""")|10|
||SHOR|Int32||XmlEnum("""SHOR""")|11|
||RESI|Int32||XmlEnum("""RESI""")|12|
||PHYS|Int32||XmlEnum("""PHYS""")|13|
||KNOC|Int32||XmlEnum("""KNOC""")|14|
||FRCL|Int32||XmlEnum("""FRCL""")|15|
||EXER|Int32||XmlEnum("""EXER""")|16|
||DRAW|Int32||XmlEnum("""DRAW""")|17|
||DLWM|Int32||XmlEnum("""DLWM""")|18|
||DIRT|Int32||XmlEnum("""DIRT""")|19|
||CLEN|Int32||XmlEnum("""CLEN""")|20|
||BUTC|Int32||XmlEnum("""BUTC""")|21|
||ASGN|Int32||XmlEnum("""ASGN""")|22|

---

## Enum ISO20022.Sese036002.SettlingCapacity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RISP|Int32||XmlEnum("""RISP""")|1|
||SPRI|Int32||XmlEnum("""SPRI""")|2|
||CUST|Int32||XmlEnum("""CUST""")|3|
||SAGE|Int32||XmlEnum("""SAGE""")|4|

---

## Value ISO20022.Sese036002.SettlingCapacity8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese036002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese036002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese036002.TaxCapacityParty5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese036002.TaxLiability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGEN|Int32||XmlEnum("""AGEN""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Sese036002.TerminationDate7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|ISO20022.Sese036002.DateCode32Choice||XmlElement()||
|+|Dt|ISO20022.Sese036002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd),validElement(Dt),validChoice(Cd,Dt))|

---

## Value ISO20022.Sese036002.Tracking5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese036002.TransactionTypeAndAdditionalParameters20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PoolId|String||XmlElement()||
|+|CmonId|String||XmlElement()||
|+|ModTp|ISO20022.Sese036002.RepurchaseType31Choice||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesFincgTxTp|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PoolId""",PoolId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CmonId""",CmonId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(ModTp),validPattern("""AcctSvcrTxId""",AcctSvcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctOwnrTxId""",AcctOwnrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Sese036002.TypeOfIdentification1Code


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

## View Hiperspace.Node
node in a graph view of data

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|SKey|String||||
|+|TypeName|String||||
|+|Name|String||||
||Froms|Hiperspace.Edge|||From = this|
||Tos|Hiperspace.Edge|||To = this|

