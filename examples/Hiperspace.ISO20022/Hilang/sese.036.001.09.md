# sese.036.001.09
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese036001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese036001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese036001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Sese036001.AlternatePartyIdentification7 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Sese036001.IdentificationType42Choice
    }
    ISO20022.Sese036001.AlternatePartyIdentification7 *-- ISO20022.Sese036001.IdentificationType42Choice
    class ISO20022.Sese036001.AmountAndDirection21 {
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese036001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Sese036001.AmountAndDirection21 *-- ISO20022.Sese036001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese036001.AmountAndDirection49 {
        + FXDtls  : ISO20022.Sese036001.ForeignExchangeTerms23
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese036001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese036001.ActiveCurrencyAndAmount
    }
    ISO20022.Sese036001.AmountAndDirection49 *-- ISO20022.Sese036001.ForeignExchangeTerms23
    ISO20022.Sese036001.AmountAndDirection49 *-- ISO20022.Sese036001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese036001.AmountAndDirection49 *-- ISO20022.Sese036001.ActiveCurrencyAndAmount
    class ISO20022.Sese036001.AutoBorrowing1Code {
        YBOR = 1
        NBOR = 2
        LAMI = 3
    }
    class ISO20022.Sese036001.AutomaticBorrowing6Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese036001.AutomaticBorrowing6Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.BeneficialOwnership4Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese036001.BeneficialOwnership4Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Sese036001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese036001.BlockChainAddressWallet3 *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.BlockTrade1Code {
        BLCH = 1
        BLPA = 2
    }
    class ISO20022.Sese036001.BlockTrade4Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese036001.BlockTrade4Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.CashAccountIdentification9Choice {
        + Prtry  : String
        + BlckChainCshWllt  : ISO20022.Sese036001.BlockChainAddressWallet3
        + IBAN  : String
    }
    ISO20022.Sese036001.CashAccountIdentification9Choice *-- ISO20022.Sese036001.BlockChainAddressWallet3
    class ISO20022.Sese036001.CashSettlementSystem2Code {
        NETS = 1
        GROS = 2
    }
    class ISO20022.Sese036001.CashSettlementSystem4Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese036001.CashSettlementSystem4Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.CentralCounterPartyEligibility4Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese036001.CentralCounterPartyEligibility4Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese036001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese036001.DateCode18Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese036001.DateCode18Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.DateType5Code {
        OPEN = 1
    }
    class ISO20022.Sese036001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese036001.FXStandingInstruction4Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese036001.FXStandingInstruction4Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese036001.ForeignExchangeTerms23 {
        + RsltgAmt  : ISO20022.Sese036001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Sese036001.ForeignExchangeTerms23 *-- ISO20022.Sese036001.ActiveCurrencyAndAmount
    class ISO20022.Sese036001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese036001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese036001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Sese036001.GenericIdentification30
    }
    ISO20022.Sese036001.GenericIdentification78 *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese036001.IdentificationType42Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese036001.IdentificationType42Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.InterestComputationMethod2Code {
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
    class ISO20022.Sese036001.InterestComputationMethodFormat4Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese036001.InterestComputationMethodFormat4Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.LegalFramework1Code {
        FRAN = 1
    }
    class ISO20022.Sese036001.LegalFramework3Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese036001.LegalFramework3Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.MarketClientSide1Code {
        MAKT = 1
        CLNT = 2
    }
    class ISO20022.Sese036001.MarketClientSide6Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese036001.MarketClientSide6Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.NameAndAddress5 {
        + Adr  : ISO20022.Sese036001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Sese036001.NameAndAddress5 *-- ISO20022.Sese036001.PostalAddress1
    class ISO20022.Sese036001.NettingEligibility4Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese036001.NettingEligibility4Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.OtherIdentification1 {
        + Tp  : ISO20022.Sese036001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese036001.OtherIdentification1 *-- ISO20022.Sese036001.IdentificationSource3Choice
    class ISO20022.Sese036001.OwnershipLegalRestrictions1Code {
        RSTR = 1
        NRST = 2
        A144 = 3
    }
    class ISO20022.Sese036001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Sese036001.NameAndAddress5
        + PrtryId  : ISO20022.Sese036001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese036001.PartyIdentification120Choice *-- ISO20022.Sese036001.NameAndAddress5
    ISO20022.Sese036001.PartyIdentification120Choice *-- ISO20022.Sese036001.GenericIdentification36
    class ISO20022.Sese036001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Sese036001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese036001.PartyIdentification127Choice *-- ISO20022.Sese036001.GenericIdentification36
    class ISO20022.Sese036001.PartyIdentification144 {
        + LEI  : String
        + Id  : ISO20022.Sese036001.PartyIdentification127Choice
    }
    ISO20022.Sese036001.PartyIdentification144 *-- ISO20022.Sese036001.PartyIdentification127Choice
    class ISO20022.Sese036001.PartyIdentification257Choice {
        + DgtlLdgrId  : String
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese036001.NameAndAddress5
        + AnyBIC  : String
    }
    ISO20022.Sese036001.PartyIdentification257Choice *-- ISO20022.Sese036001.NameAndAddress5
    class ISO20022.Sese036001.PartyIdentification315 {
        + AddtlInf  : ISO20022.Sese036001.PartyTextInformation1
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese036001.DateAndDateTime2Choice
        + AltrnId  : ISO20022.Sese036001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese036001.PartyIdentification257Choice
    }
    ISO20022.Sese036001.PartyIdentification315 *-- ISO20022.Sese036001.PartyTextInformation1
    ISO20022.Sese036001.PartyIdentification315 *-- ISO20022.Sese036001.DateAndDateTime2Choice
    ISO20022.Sese036001.PartyIdentification315 *-- ISO20022.Sese036001.AlternatePartyIdentification7
    ISO20022.Sese036001.PartyIdentification315 *-- ISO20022.Sese036001.PartyIdentification257Choice
    class ISO20022.Sese036001.PartyIdentificationAndAccount199 {
        + AddtlInf  : ISO20022.Sese036001.PartyTextInformation1
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese036001.DateAndDateTime2Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese036001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese036001.SecuritiesAccount22
        + AltrnId  : ISO20022.Sese036001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese036001.PartyIdentification120Choice
    }
    ISO20022.Sese036001.PartyIdentificationAndAccount199 *-- ISO20022.Sese036001.PartyTextInformation1
    ISO20022.Sese036001.PartyIdentificationAndAccount199 *-- ISO20022.Sese036001.DateAndDateTime2Choice
    ISO20022.Sese036001.PartyIdentificationAndAccount199 *-- ISO20022.Sese036001.BlockChainAddressWallet3
    ISO20022.Sese036001.PartyIdentificationAndAccount199 *-- ISO20022.Sese036001.SecuritiesAccount22
    ISO20022.Sese036001.PartyIdentificationAndAccount199 *-- ISO20022.Sese036001.AlternatePartyIdentification7
    ISO20022.Sese036001.PartyIdentificationAndAccount199 *-- ISO20022.Sese036001.PartyIdentification120Choice
    class ISO20022.Sese036001.PartyTextInformation1 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese036001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Sese036001.PriorityNumeric4Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Nmrc  : String
    }
    ISO20022.Sese036001.PriorityNumeric4Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.QuantityAndAccount119 {
        + SfkpgPlc  : ISO20022.Sese036001.SafeKeepingPlace5
        + CshAcct  : ISO20022.Sese036001.CashAccountIdentification9Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese036001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese036001.SecuritiesAccount19
        + AcctOwnr  : ISO20022.Sese036001.PartyIdentification144
        + SttlmQty  : ISO20022.Sese036001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Sese036001.QuantityAndAccount119 *-- ISO20022.Sese036001.SafeKeepingPlace5
    ISO20022.Sese036001.QuantityAndAccount119 *-- ISO20022.Sese036001.CashAccountIdentification9Choice
    ISO20022.Sese036001.QuantityAndAccount119 *-- ISO20022.Sese036001.BlockChainAddressWallet3
    ISO20022.Sese036001.QuantityAndAccount119 *-- ISO20022.Sese036001.SecuritiesAccount19
    ISO20022.Sese036001.QuantityAndAccount119 *-- ISO20022.Sese036001.PartyIdentification144
    ISO20022.Sese036001.QuantityAndAccount119 *-- ISO20022.Sese036001.FinancialInstrumentQuantity33Choice
    class ISO20022.Sese036001.Rate2 {
        + Rate  : Decimal
        + Sgn  : String
    }
    class ISO20022.Sese036001.RateName1 {
        + RateNm  : String
        + Issr  : String
    }
    class ISO20022.Sese036001.RateOrName1Choice {
        + RateNm  : ISO20022.Sese036001.RateName1
        + Rate  : ISO20022.Sese036001.Rate2
    }
    ISO20022.Sese036001.RateOrName1Choice *-- ISO20022.Sese036001.RateName1
    ISO20022.Sese036001.RateOrName1Choice *-- ISO20022.Sese036001.Rate2
    class ISO20022.Sese036001.RateType1Code {
        VARI = 1
        FORF = 2
        FIXE = 3
    }
    class ISO20022.Sese036001.RateType35Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese036001.RateType35Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.RepurchaseType21Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese036001.RepurchaseType21Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.RepurchaseType8Code {
        CALL = 1
        RATE = 2
        ROLP = 3
        PADJ = 4
    }
    class ISO20022.Sese036001.Restriction5Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese036001.Restriction5Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.RevaluationIndicator3Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese036001.RevaluationIndicator3Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.SafeKeepingPlace5 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Sese036001.SafekeepingPlaceFormat41Choice
    }
    ISO20022.Sese036001.SafeKeepingPlace5 *-- ISO20022.Sese036001.SafekeepingPlaceFormat41Choice
    class ISO20022.Sese036001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Sese036001.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Sese036001.SafekeepingPlaceFormat41Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification78
        + TpAndId  : ISO20022.Sese036001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Sese036001.SafekeepingPlaceTypeAndText8
    }
    ISO20022.Sese036001.SafekeepingPlaceFormat41Choice *-- ISO20022.Sese036001.GenericIdentification78
    ISO20022.Sese036001.SafekeepingPlaceFormat41Choice *-- ISO20022.Sese036001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Sese036001.SafekeepingPlaceFormat41Choice *-- ISO20022.Sese036001.SafekeepingPlaceTypeAndText8
    class ISO20022.Sese036001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese036001.SafekeepingPlaceTypeAndText8 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese036001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Sese036001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese036001.SecuritiesAccount19 *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.SecuritiesAccount22 {
        + Nm  : String
        + Tp  : ISO20022.Sese036001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese036001.SecuritiesAccount22 *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.SecuritiesFinancingModificationInstructionV09 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese036001.SupplementaryData1~
        + OpngSttlmAmt  : ISO20022.Sese036001.AmountAndDirection49
        + RcvgSttlmPties  : ISO20022.Sese036001.SettlementParties127
        + DlvrgSttlmPties  : ISO20022.Sese036001.SettlementParties127
        + SttlmParams  : ISO20022.Sese036001.SettlementDetails148
        + SctiesFincgAddtlDtls  : ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58
        + QtyAndAcctDtls  : ISO20022.Sese036001.QuantityAndAccount119
        + FinInstrmId  : ISO20022.Sese036001.SecurityIdentification19
        + TradDtls  : ISO20022.Sese036001.SecuritiesTradeDetails100
        + TxTpAndModAddtlParams  : ISO20022.Sese036001.TransactionTypeAndAdditionalParameters23
    }
    ISO20022.Sese036001.SecuritiesFinancingModificationInstructionV09 *-- ISO20022.Sese036001.SupplementaryData1
    ISO20022.Sese036001.SecuritiesFinancingModificationInstructionV09 *-- ISO20022.Sese036001.AmountAndDirection49
    ISO20022.Sese036001.SecuritiesFinancingModificationInstructionV09 *-- ISO20022.Sese036001.SettlementParties127
    ISO20022.Sese036001.SecuritiesFinancingModificationInstructionV09 *-- ISO20022.Sese036001.SettlementParties127
    ISO20022.Sese036001.SecuritiesFinancingModificationInstructionV09 *-- ISO20022.Sese036001.SettlementDetails148
    ISO20022.Sese036001.SecuritiesFinancingModificationInstructionV09 *-- ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58
    ISO20022.Sese036001.SecuritiesFinancingModificationInstructionV09 *-- ISO20022.Sese036001.QuantityAndAccount119
    ISO20022.Sese036001.SecuritiesFinancingModificationInstructionV09 *-- ISO20022.Sese036001.SecurityIdentification19
    ISO20022.Sese036001.SecuritiesFinancingModificationInstructionV09 *-- ISO20022.Sese036001.SecuritiesTradeDetails100
    ISO20022.Sese036001.SecuritiesFinancingModificationInstructionV09 *-- ISO20022.Sese036001.TransactionTypeAndAdditionalParameters23
    class ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 {
        + ScndLegNrrtv  : String
        + TermntnTxAmt  : ISO20022.Sese036001.AmountAndDirection21
        + TermntnAmtPerPcOfColl  : ISO20022.Sese036001.AmountAndDirection21
        + PrmAmt  : ISO20022.Sese036001.AmountAndDirection21
        + FrftAmt  : ISO20022.Sese036001.AmountAndDirection21
        + AcrdIntrstAmt  : ISO20022.Sese036001.AmountAndDirection21
        + DealAmt  : ISO20022.Sese036001.AmountAndDirection21
        + LclBrkrComssn  : ISO20022.Sese036001.AmountAndDirection21
        + TtlNbOfCollInstrs  : String
        + TxCallDely  : String
        + Sprd  : ISO20022.Sese036001.Rate2
        + PricgRate  : ISO20022.Sese036001.RateOrName1Choice
        + ChrgsRate  : ISO20022.Sese036001.Rate2
        + SctiesHrcut  : ISO20022.Sese036001.Rate2
        + StockLnMrgn  : ISO20022.Sese036001.Rate2
        + RpRate  : ISO20022.Sese036001.Rate2
        + VarblRateSpprt  : ISO20022.Sese036001.RateName1
        + IntrstPmt  : String
        + MtrtyDtMod  : String
        + IntrstCmptnMtd  : ISO20022.Sese036001.InterestComputationMethodFormat4Choice
        + LglFrmwk  : ISO20022.Sese036001.LegalFramework3Choice
        + Rvaltn  : ISO20022.Sese036001.RevaluationIndicator3Choice
        + RateTp  : ISO20022.Sese036001.RateType35Choice
        + ComssnClctnDt  : ISO20022.Sese036001.DateAndDateTime2Choice
        + EarlstCallBckDt  : ISO20022.Sese036001.DateAndDateTime2Choice
        + RateChngDt  : ISO20022.Sese036001.DateAndDateTime2Choice
        + TermntnDt  : ISO20022.Sese036001.TerminationDate6Choice
        + ClsgLegId  : String
        + SctiesFincgUnqTxIdr  : String
        + SctiesFincgTradId  : String
    }
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.AmountAndDirection21
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.AmountAndDirection21
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.AmountAndDirection21
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.AmountAndDirection21
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.AmountAndDirection21
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.AmountAndDirection21
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.AmountAndDirection21
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.Rate2
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.RateOrName1Choice
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.Rate2
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.Rate2
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.Rate2
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.Rate2
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.RateName1
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.InterestComputationMethodFormat4Choice
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.LegalFramework3Choice
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.RevaluationIndicator3Choice
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.RateType35Choice
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.DateAndDateTime2Choice
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.DateAndDateTime2Choice
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.DateAndDateTime2Choice
    ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58 *-- ISO20022.Sese036001.TerminationDate6Choice
    class ISO20022.Sese036001.SecuritiesFinancingTransactionType2Code {
        SBBK = 1
        BSBK = 2
        SECL = 3
        SECB = 4
        RVPO = 5
        REPU = 6
    }
    class ISO20022.Sese036001.SecuritiesRTGS4Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese036001.SecuritiesRTGS4Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.SecuritiesTradeDetails100 {
        + InstrPrcgAddtlDtls  : String
        + NbOfDaysAcrd  : Decimal
        + OpngSttlmDt  : ISO20022.Sese036001.DateAndDateTime2Choice
        + TradDt  : ISO20022.Sese036001.DateAndDateTime2Choice
    }
    ISO20022.Sese036001.SecuritiesTradeDetails100 *-- ISO20022.Sese036001.DateAndDateTime2Choice
    ISO20022.Sese036001.SecuritiesTradeDetails100 *-- ISO20022.Sese036001.DateAndDateTime2Choice
    class ISO20022.Sese036001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese036001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Sese036001.SecurityIdentification19 *-- ISO20022.Sese036001.OtherIdentification1
    class ISO20022.Sese036001.SettlementDetails148 {
        + ElgblForColl  : String
        + PrtlSttlmInd  : String
        + AutomtcBrrwg  : ISO20022.Sese036001.AutomaticBorrowing6Choice
        + Trckg  : ISO20022.Sese036001.Tracking4Choice
        + CCPElgblty  : ISO20022.Sese036001.CentralCounterPartyEligibility4Choice
        + NetgElgblty  : ISO20022.Sese036001.NettingEligibility4Choice
        + SttlmSysMtd  : ISO20022.Sese036001.SettlementSystemMethod4Choice
        + LglRstrctns  : ISO20022.Sese036001.Restriction5Choice
        + BlckTrad  : ISO20022.Sese036001.BlockTrade4Choice
        + FxStgInstr  : ISO20022.Sese036001.FXStandingInstruction4Choice
        + MktClntSd  : ISO20022.Sese036001.MarketClientSide6Choice
        + TaxCpcty  : ISO20022.Sese036001.TaxCapacityParty4Choice
        + CshClrSys  : ISO20022.Sese036001.CashSettlementSystem4Choice
        + BnfclOwnrsh  : ISO20022.Sese036001.BeneficialOwnership4Choice
        + SctiesRTGS  : ISO20022.Sese036001.SecuritiesRTGS4Choice
        + StmpDtyTaxBsis  : ISO20022.Sese036001.GenericIdentification30
        + SttlgCpcty  : ISO20022.Sese036001.SettlingCapacity7Choice
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese036001.SettlementTransactionCondition18Choice~
        + Prty  : ISO20022.Sese036001.PriorityNumeric4Choice
        + HldInd  : String
    }
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.AutomaticBorrowing6Choice
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.Tracking4Choice
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.CentralCounterPartyEligibility4Choice
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.NettingEligibility4Choice
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.SettlementSystemMethod4Choice
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.Restriction5Choice
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.BlockTrade4Choice
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.FXStandingInstruction4Choice
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.MarketClientSide6Choice
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.TaxCapacityParty4Choice
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.CashSettlementSystem4Choice
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.BeneficialOwnership4Choice
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.SecuritiesRTGS4Choice
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.GenericIdentification30
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.SettlingCapacity7Choice
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.SettlementTransactionCondition18Choice
    ISO20022.Sese036001.SettlementDetails148 *-- ISO20022.Sese036001.PriorityNumeric4Choice
    class ISO20022.Sese036001.SettlementParties127 {
        + Pty5  : ISO20022.Sese036001.PartyIdentificationAndAccount199
        + Pty4  : ISO20022.Sese036001.PartyIdentificationAndAccount199
        + Pty3  : ISO20022.Sese036001.PartyIdentificationAndAccount199
        + Pty2  : ISO20022.Sese036001.PartyIdentificationAndAccount199
        + Pty1  : ISO20022.Sese036001.PartyIdentificationAndAccount199
        + Dpstry  : ISO20022.Sese036001.PartyIdentification315
    }
    ISO20022.Sese036001.SettlementParties127 *-- ISO20022.Sese036001.PartyIdentificationAndAccount199
    ISO20022.Sese036001.SettlementParties127 *-- ISO20022.Sese036001.PartyIdentificationAndAccount199
    ISO20022.Sese036001.SettlementParties127 *-- ISO20022.Sese036001.PartyIdentificationAndAccount199
    ISO20022.Sese036001.SettlementParties127 *-- ISO20022.Sese036001.PartyIdentificationAndAccount199
    ISO20022.Sese036001.SettlementParties127 *-- ISO20022.Sese036001.PartyIdentificationAndAccount199
    ISO20022.Sese036001.SettlementParties127 *-- ISO20022.Sese036001.PartyIdentification315
    class ISO20022.Sese036001.SettlementSystemMethod1Code {
        YSET = 1
        NSET = 2
    }
    class ISO20022.Sese036001.SettlementSystemMethod4Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese036001.SettlementSystemMethod4Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.SettlementTransactionCondition18Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese036001.SettlementTransactionCondition18Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.SettlementTransactionCondition5Code {
        PARQ = 1
        PARC = 2
        NPAR = 3
        PART = 4
    }
    class ISO20022.Sese036001.SettlementTransactionCondition6Code {
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
    class ISO20022.Sese036001.SettlingCapacity2Code {
        RISP = 1
        SPRI = 2
        CUST = 3
        SAGE = 4
    }
    class ISO20022.Sese036001.SettlingCapacity7Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese036001.SettlingCapacity7Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.SupplementaryData1 {
        + Envlp  : ISO20022.Sese036001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese036001.SupplementaryData1 *-- ISO20022.Sese036001.SupplementaryDataEnvelope1
    class ISO20022.Sese036001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese036001.TaxCapacityParty4Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese036001.TaxCapacityParty4Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.TaxLiability1Code {
        AGEN = 1
        PRIN = 2
    }
    class ISO20022.Sese036001.TerminationDate6Choice {
        + Cd  : ISO20022.Sese036001.DateCode18Choice
        + Dt  : ISO20022.Sese036001.DateAndDateTime2Choice
    }
    ISO20022.Sese036001.TerminationDate6Choice *-- ISO20022.Sese036001.DateCode18Choice
    ISO20022.Sese036001.TerminationDate6Choice *-- ISO20022.Sese036001.DateAndDateTime2Choice
    class ISO20022.Sese036001.Tracking4Choice {
        + Prtry  : ISO20022.Sese036001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Sese036001.Tracking4Choice *-- ISO20022.Sese036001.GenericIdentification30
    class ISO20022.Sese036001.TransactionTypeAndAdditionalParameters23 {
        + NonceId  : String
        + PoolId  : String
        + CmonId  : String
        + ModTp  : ISO20022.Sese036001.RepurchaseType21Choice
        + Pmt  : String
        + SctiesFincgTxTp  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    ISO20022.Sese036001.TransactionTypeAndAdditionalParameters23 *-- ISO20022.Sese036001.RepurchaseType21Choice
    class ISO20022.Sese036001.TypeOfIdentification1Code {
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

## Value ISO20022.Sese036001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese036001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese036001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Sese036001.AlternatePartyIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Sese036001.IdentificationType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Sese036001.AmountAndDirection21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese036001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Sese036001.AmountAndDirection49


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Sese036001.ForeignExchangeTerms23||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese036001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese036001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Enum ISO20022.Sese036001.AutoBorrowing1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YBOR|Int32||XmlEnum("""YBOR""")|1|
||NBOR|Int32||XmlEnum("""NBOR""")|2|
||LAMI|Int32||XmlEnum("""LAMI""")|3|

---

## Value ISO20022.Sese036001.AutomaticBorrowing6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036001.BeneficialOwnership4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese036001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Sese036001.BlockTrade1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BLCH|Int32||XmlEnum("""BLCH""")|1|
||BLPA|Int32||XmlEnum("""BLPA""")|2|

---

## Value ISO20022.Sese036001.BlockTrade4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036001.CashAccountIdentification9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|BlckChainCshWllt|ISO20022.Sese036001.BlockChainAddressWallet3||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainCshWllt),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,BlckChainCshWllt,IBAN))|

---

## Enum ISO20022.Sese036001.CashSettlementSystem2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETS|Int32||XmlEnum("""NETS""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Value ISO20022.Sese036001.CashSettlementSystem4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036001.CentralCounterPartyEligibility4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Enum ISO20022.Sese036001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese036001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Sese036001.DateCode18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese036001.DateType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEN|Int32||XmlEnum("""OPEN""")|1|

---

## Enum ISO20022.Sese036001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Type ISO20022.Sese036001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesFincgModInstr|ISO20022.Sese036001.SecuritiesFinancingModificationInstructionV09||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesFincgModInstr))|

---

## Value ISO20022.Sese036001.FXStandingInstruction4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese036001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese036001.ForeignExchangeTerms23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Sese036001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese036001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese036001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese036001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese036001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036001.IdentificationType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese036001.InterestComputationMethod2Code


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

## Value ISO20022.Sese036001.InterestComputationMethodFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese036001.LegalFramework1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRAN|Int32||XmlEnum("""FRAN""")|1|

---

## Value ISO20022.Sese036001.LegalFramework3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese036001.MarketClientSide1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MAKT|Int32||XmlEnum("""MAKT""")|1|
||CLNT|Int32||XmlEnum("""CLNT""")|2|

---

## Value ISO20022.Sese036001.MarketClientSide6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Sese036001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Sese036001.NettingEligibility4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese036001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese036001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Sese036001.OwnershipLegalRestrictions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSTR|Int32||XmlEnum("""RSTR""")|1|
||NRST|Int32||XmlEnum("""NRST""")|2|
||A144|Int32||XmlEnum("""A144""")|3|

---

## Value ISO20022.Sese036001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese036001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese036001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese036001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese036001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese036001.PartyIdentification144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese036001.PartyIdentification127Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese036001.PartyIdentification257Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese036001.NameAndAddress5||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(DgtlLdgrId,Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese036001.PartyIdentification315


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese036001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese036001.DateAndDateTime2Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese036001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese036001.PartyIdentification257Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese036001.PartyIdentificationAndAccount199


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese036001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese036001.DateAndDateTime2Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese036001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese036001.SecuritiesAccount22||XmlElement()||
|+|AltrnId|ISO20022.Sese036001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese036001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese036001.PartyTextInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese036001.PostalAddress1


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

## Value ISO20022.Sese036001.PriorityNumeric4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Nmrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""Nmrc""",Nmrc,"""[0-9]{4}"""),validChoice(Prtry,Nmrc))|

---

## Value ISO20022.Sese036001.QuantityAndAccount119


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SfkpgPlc|ISO20022.Sese036001.SafeKeepingPlace5||XmlElement()||
|+|CshAcct|ISO20022.Sese036001.CashAccountIdentification9Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese036001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese036001.SecuritiesAccount19||XmlElement()||
|+|AcctOwnr|ISO20022.Sese036001.PartyIdentification144||XmlElement()||
|+|SttlmQty|ISO20022.Sese036001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SfkpgPlc),validElement(CshAcct),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(SttlmQty))|

---

## Value ISO20022.Sese036001.Rate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Sgn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese036001.RateName1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese036001.RateOrName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateNm|ISO20022.Sese036001.RateName1||XmlElement()||
|+|Rate|ISO20022.Sese036001.Rate2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateNm),validElement(Rate),validChoice(RateNm,Rate))|

---

## Enum ISO20022.Sese036001.RateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|
||FORF|Int32||XmlEnum("""FORF""")|2|
||FIXE|Int32||XmlEnum("""FIXE""")|3|

---

## Value ISO20022.Sese036001.RateType35Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036001.RepurchaseType21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese036001.RepurchaseType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CALL|Int32||XmlEnum("""CALL""")|1|
||RATE|Int32||XmlEnum("""RATE""")|2|
||ROLP|Int32||XmlEnum("""ROLP""")|3|
||PADJ|Int32||XmlEnum("""PADJ""")|4|

---

## Value ISO20022.Sese036001.Restriction5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036001.RevaluationIndicator3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese036001.SafeKeepingPlace5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Sese036001.SafekeepingPlaceFormat41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Sese036001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Sese036001.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Sese036001.SafekeepingPlaceFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Sese036001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Sese036001.SafekeepingPlaceTypeAndText8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Sese036001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese036001.SafekeepingPlaceTypeAndText8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese036001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese036001.SecuritiesAccount22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Aspect ISO20022.Sese036001.SecuritiesFinancingModificationInstructionV09


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese036001.SupplementaryData1>||XmlElement()||
|+|OpngSttlmAmt|ISO20022.Sese036001.AmountAndDirection49||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese036001.SettlementParties127||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese036001.SettlementParties127||XmlElement()||
|+|SttlmParams|ISO20022.Sese036001.SettlementDetails148||XmlElement()||
|+|SctiesFincgAddtlDtls|ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58||XmlElement()||
|+|QtyAndAcctDtls|ISO20022.Sese036001.QuantityAndAccount119||XmlElement()||
|+|FinInstrmId|ISO20022.Sese036001.SecurityIdentification19||XmlElement()||
|+|TradDtls|ISO20022.Sese036001.SecuritiesTradeDetails100||XmlElement()||
|+|TxTpAndModAddtlParams|ISO20022.Sese036001.TransactionTypeAndAdditionalParameters23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(OpngSttlmAmt),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(SttlmParams),validElement(SctiesFincgAddtlDtls),validElement(QtyAndAcctDtls),validElement(FinInstrmId),validElement(TradDtls),validElement(TxTpAndModAddtlParams))|

---

## Value ISO20022.Sese036001.SecuritiesFinancingTransactionDetails58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndLegNrrtv|String||XmlElement()||
|+|TermntnTxAmt|ISO20022.Sese036001.AmountAndDirection21||XmlElement()||
|+|TermntnAmtPerPcOfColl|ISO20022.Sese036001.AmountAndDirection21||XmlElement()||
|+|PrmAmt|ISO20022.Sese036001.AmountAndDirection21||XmlElement()||
|+|FrftAmt|ISO20022.Sese036001.AmountAndDirection21||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Sese036001.AmountAndDirection21||XmlElement()||
|+|DealAmt|ISO20022.Sese036001.AmountAndDirection21||XmlElement()||
|+|LclBrkrComssn|ISO20022.Sese036001.AmountAndDirection21||XmlElement()||
|+|TtlNbOfCollInstrs|String||XmlElement()||
|+|TxCallDely|String||XmlElement()||
|+|Sprd|ISO20022.Sese036001.Rate2||XmlElement()||
|+|PricgRate|ISO20022.Sese036001.RateOrName1Choice||XmlElement()||
|+|ChrgsRate|ISO20022.Sese036001.Rate2||XmlElement()||
|+|SctiesHrcut|ISO20022.Sese036001.Rate2||XmlElement()||
|+|StockLnMrgn|ISO20022.Sese036001.Rate2||XmlElement()||
|+|RpRate|ISO20022.Sese036001.Rate2||XmlElement()||
|+|VarblRateSpprt|ISO20022.Sese036001.RateName1||XmlElement()||
|+|IntrstPmt|String||XmlElement()||
|+|MtrtyDtMod|String||XmlElement()||
|+|IntrstCmptnMtd|ISO20022.Sese036001.InterestComputationMethodFormat4Choice||XmlElement()||
|+|LglFrmwk|ISO20022.Sese036001.LegalFramework3Choice||XmlElement()||
|+|Rvaltn|ISO20022.Sese036001.RevaluationIndicator3Choice||XmlElement()||
|+|RateTp|ISO20022.Sese036001.RateType35Choice||XmlElement()||
|+|ComssnClctnDt|ISO20022.Sese036001.DateAndDateTime2Choice||XmlElement()||
|+|EarlstCallBckDt|ISO20022.Sese036001.DateAndDateTime2Choice||XmlElement()||
|+|RateChngDt|ISO20022.Sese036001.DateAndDateTime2Choice||XmlElement()||
|+|TermntnDt|ISO20022.Sese036001.TerminationDate6Choice||XmlElement()||
|+|ClsgLegId|String||XmlElement()||
|+|SctiesFincgUnqTxIdr|String||XmlElement()||
|+|SctiesFincgTradId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TermntnTxAmt),validElement(TermntnAmtPerPcOfColl),validElement(PrmAmt),validElement(FrftAmt),validElement(AcrdIntrstAmt),validElement(DealAmt),validElement(LclBrkrComssn),validPattern("""TtlNbOfCollInstrs""",TtlNbOfCollInstrs,"""[0-9]{3}"""),validPattern("""TxCallDely""",TxCallDely,"""[0-9]{3}"""),validElement(Sprd),validElement(PricgRate),validElement(ChrgsRate),validElement(SctiesHrcut),validElement(StockLnMrgn),validElement(RpRate),validElement(VarblRateSpprt),validElement(IntrstCmptnMtd),validElement(LglFrmwk),validElement(Rvaltn),validElement(RateTp),validElement(ComssnClctnDt),validElement(EarlstCallBckDt),validElement(RateChngDt),validElement(TermntnDt),validPattern("""SctiesFincgUnqTxIdr""",SctiesFincgUnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""))|

---

## Enum ISO20022.Sese036001.SecuritiesFinancingTransactionType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SBBK|Int32||XmlEnum("""SBBK""")|1|
||BSBK|Int32||XmlEnum("""BSBK""")|2|
||SECL|Int32||XmlEnum("""SECL""")|3|
||SECB|Int32||XmlEnum("""SECB""")|4|
||RVPO|Int32||XmlEnum("""RVPO""")|5|
||REPU|Int32||XmlEnum("""REPU""")|6|

---

## Value ISO20022.Sese036001.SecuritiesRTGS4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese036001.SecuritiesTradeDetails100


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrPrcgAddtlDtls|String||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|OpngSttlmDt|ISO20022.Sese036001.DateAndDateTime2Choice||XmlElement()||
|+|TradDt|ISO20022.Sese036001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OpngSttlmDt),validElement(TradDt))|

---

## Value ISO20022.Sese036001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese036001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese036001.SettlementDetails148


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ElgblForColl|String||XmlElement()||
|+|PrtlSttlmInd|String||XmlElement()||
|+|AutomtcBrrwg|ISO20022.Sese036001.AutomaticBorrowing6Choice||XmlElement()||
|+|Trckg|ISO20022.Sese036001.Tracking4Choice||XmlElement()||
|+|CCPElgblty|ISO20022.Sese036001.CentralCounterPartyEligibility4Choice||XmlElement()||
|+|NetgElgblty|ISO20022.Sese036001.NettingEligibility4Choice||XmlElement()||
|+|SttlmSysMtd|ISO20022.Sese036001.SettlementSystemMethod4Choice||XmlElement()||
|+|LglRstrctns|ISO20022.Sese036001.Restriction5Choice||XmlElement()||
|+|BlckTrad|ISO20022.Sese036001.BlockTrade4Choice||XmlElement()||
|+|FxStgInstr|ISO20022.Sese036001.FXStandingInstruction4Choice||XmlElement()||
|+|MktClntSd|ISO20022.Sese036001.MarketClientSide6Choice||XmlElement()||
|+|TaxCpcty|ISO20022.Sese036001.TaxCapacityParty4Choice||XmlElement()||
|+|CshClrSys|ISO20022.Sese036001.CashSettlementSystem4Choice||XmlElement()||
|+|BnfclOwnrsh|ISO20022.Sese036001.BeneficialOwnership4Choice||XmlElement()||
|+|SctiesRTGS|ISO20022.Sese036001.SecuritiesRTGS4Choice||XmlElement()||
|+|StmpDtyTaxBsis|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|SttlgCpcty|ISO20022.Sese036001.SettlingCapacity7Choice||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese036001.SettlementTransactionCondition18Choice>||XmlElement()||
|+|Prty|ISO20022.Sese036001.PriorityNumeric4Choice||XmlElement()||
|+|HldInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AutomtcBrrwg),validElement(Trckg),validElement(CCPElgblty),validElement(NetgElgblty),validElement(SttlmSysMtd),validElement(LglRstrctns),validElement(BlckTrad),validElement(FxStgInstr),validElement(MktClntSd),validElement(TaxCpcty),validElement(CshClrSys),validElement(BnfclOwnrsh),validElement(SctiesRTGS),validElement(StmpDtyTaxBsis),validElement(SttlgCpcty),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validElement(Prty))|

---

## Value ISO20022.Sese036001.SettlementParties127


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese036001.PartyIdentificationAndAccount199||XmlElement()||
|+|Pty4|ISO20022.Sese036001.PartyIdentificationAndAccount199||XmlElement()||
|+|Pty3|ISO20022.Sese036001.PartyIdentificationAndAccount199||XmlElement()||
|+|Pty2|ISO20022.Sese036001.PartyIdentificationAndAccount199||XmlElement()||
|+|Pty1|ISO20022.Sese036001.PartyIdentificationAndAccount199||XmlElement()||
|+|Dpstry|ISO20022.Sese036001.PartyIdentification315||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Sese036001.SettlementSystemMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSET|Int32||XmlEnum("""YSET""")|1|
||NSET|Int32||XmlEnum("""NSET""")|2|

---

## Value ISO20022.Sese036001.SettlementSystemMethod4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036001.SettlementTransactionCondition18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese036001.SettlementTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARQ|Int32||XmlEnum("""PARQ""")|1|
||PARC|Int32||XmlEnum("""PARC""")|2|
||NPAR|Int32||XmlEnum("""NPAR""")|3|
||PART|Int32||XmlEnum("""PART""")|4|

---

## Enum ISO20022.Sese036001.SettlementTransactionCondition6Code


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

## Enum ISO20022.Sese036001.SettlingCapacity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RISP|Int32||XmlEnum("""RISP""")|1|
||SPRI|Int32||XmlEnum("""SPRI""")|2|
||CUST|Int32||XmlEnum("""CUST""")|3|
||SAGE|Int32||XmlEnum("""SAGE""")|4|

---

## Value ISO20022.Sese036001.SettlingCapacity7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese036001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese036001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese036001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese036001.TaxCapacityParty4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese036001.TaxLiability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGEN|Int32||XmlEnum("""AGEN""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Sese036001.TerminationDate6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|ISO20022.Sese036001.DateCode18Choice||XmlElement()||
|+|Dt|ISO20022.Sese036001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd),validElement(Dt),validChoice(Cd,Dt))|

---

## Value ISO20022.Sese036001.Tracking4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese036001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese036001.TransactionTypeAndAdditionalParameters23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonceId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|CmonId|String||XmlElement()||
|+|ModTp|ISO20022.Sese036001.RepurchaseType21Choice||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesFincgTxTp|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ModTp))|

---

## Enum ISO20022.Sese036001.TypeOfIdentification1Code


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

