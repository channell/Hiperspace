# sese.005.001.09
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese005001.Account27 {
        + AcctSvcr  : ISO20022.Sese005001.PartyIdentification139
        + Id  : String
    }
    ISO20022.Sese005001.Account27 *-- ISO20022.Sese005001.PartyIdentification139
    class ISO20022.Sese005001.Account31 {
        + SubAcctDtls  : ISO20022.Sese005001.SubAccount5
        + Svcr  : ISO20022.Sese005001.PartyIdentification139
        + Dsgnt  : String
        + AcctNm  : String
        + Id  : String
    }
    ISO20022.Sese005001.Account31 *-- ISO20022.Sese005001.SubAccount5
    ISO20022.Sese005001.Account31 *-- ISO20022.Sese005001.PartyIdentification139
    class ISO20022.Sese005001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese005001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese005001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese005001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese005001.AdditionalReference10 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Sese005001.PartyIdentification139
        + Ref  : String
    }
    ISO20022.Sese005001.AdditionalReference10 *-- ISO20022.Sese005001.PartyIdentification139
    class ISO20022.Sese005001.AdditionalReference11 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Sese005001.PartyIdentification139
        + Ref  : String
    }
    ISO20022.Sese005001.AdditionalReference11 *-- ISO20022.Sese005001.PartyIdentification139
    class ISO20022.Sese005001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Sese005001.AlternatePartyIdentification7 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Sese005001.IdentificationType42Choice
    }
    ISO20022.Sese005001.AlternatePartyIdentification7 *-- ISO20022.Sese005001.IdentificationType42Choice
    class ISO20022.Sese005001.AlternateSecurityIdentification7 {
        + IdSrc  : ISO20022.Sese005001.IdentificationSource1Choice
        + Id  : String
    }
    ISO20022.Sese005001.AlternateSecurityIdentification7 *-- ISO20022.Sese005001.IdentificationSource1Choice
    class ISO20022.Sese005001.BeneficiaryCertificationCompletion1Code {
        PHYS = 1
        ELEC = 2
        NCER = 3
    }
    class ISO20022.Sese005001.BusinessFlowType1Code {
        DLPR = 1
        SLRP = 2
        SLDP = 3
    }
    class ISO20022.Sese005001.ChargeBasis2Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese005001.ChargeBasis2Choice *-- ISO20022.Sese005001.GenericIdentification47
    class ISO20022.Sese005001.ChargeBearer1Code {
        SHA = 1
        BEN = 2
        OUR = 3
    }
    class ISO20022.Sese005001.ChargeOrCommissionDiscount1 {
        + Bsis  : ISO20022.Sese005001.WaivingInstruction2Choice
        + Rate  : Decimal
        + Amt  : ISO20022.Sese005001.ActiveCurrencyAndAmount
    }
    ISO20022.Sese005001.ChargeOrCommissionDiscount1 *-- ISO20022.Sese005001.WaivingInstruction2Choice
    ISO20022.Sese005001.ChargeOrCommissionDiscount1 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    class ISO20022.Sese005001.ChargeOrCommissionDiscount2 {
        + Bsis  : ISO20022.Sese005001.WaivingInstruction2Choice
        + Rate  : Decimal
        + Amt  : ISO20022.Sese005001.ActiveCurrencyAndAmount
    }
    ISO20022.Sese005001.ChargeOrCommissionDiscount2 *-- ISO20022.Sese005001.WaivingInstruction2Choice
    ISO20022.Sese005001.ChargeOrCommissionDiscount2 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    class ISO20022.Sese005001.ChargePaymentMethod1Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese005001.ChargePaymentMethod1Choice *-- ISO20022.Sese005001.GenericIdentification47
    class ISO20022.Sese005001.ChargePaymentMethod1Code {
        UNIT = 1
        CASH = 2
    }
    class ISO20022.Sese005001.ChargeType5Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese005001.ChargeType5Choice *-- ISO20022.Sese005001.GenericIdentification47
    class ISO20022.Sese005001.ChargeType6Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese005001.ChargeType6Choice *-- ISO20022.Sese005001.GenericIdentification47
    class ISO20022.Sese005001.ContactIdentification2 {
        + EmailAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + GvnNm  : String
        + NmPrfx  : String
    }
    class ISO20022.Sese005001.CopyInformation5 {
        + OrgnlRcvr  : String
        + CpyInd  : String
    }
    class ISO20022.Sese005001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese005001.DateFormat1Choice {
        + DtTm  : DateTime
        + Cd  : String
        + Dt  : DateTime
    }
    class ISO20022.Sese005001.DeliverInformation21 {
        + ClntRef  : ISO20022.Sese005001.AdditionalReference10
        + PhysTrfDtls  : ISO20022.Sese005001.DeliveryParameters4
        + PhysTrf  : String
        + SttlmPtiesDtls  : ISO20022.Sese005001.FundSettlementParameters15
        + FXDtls  : global::System.Collections.Generic.List~ISO20022.Sese005001.ForeignExchangeTerms37~
        + IndvTax  : global::System.Collections.Generic.List~ISO20022.Sese005001.Tax38~
        + Fees  : global::System.Collections.Generic.List~ISO20022.Sese005001.Fees2~
        + NetAmt  : ISO20022.Sese005001.ActiveCurrencyAndAmount
        + StmpDty  : String
        + SttlmAmt  : ISO20022.Sese005001.ActiveCurrencyAndAmount
        + ReqdSttlmDt  : DateTime
        + ReqdTradDt  : DateTime
        + BnfcryCertfctnCmpltn  : String
        + IncmPref  : String
        + DmtrlsdInd  : String
        + SctiesForm  : String
        + IntrmyInf  : global::System.Collections.Generic.List~ISO20022.Sese005001.Intermediary43~
        + TrfrRegdAcct  : ISO20022.Sese005001.Account31
        + Trfr  : ISO20022.Sese005001.PartyIdentification139
    }
    ISO20022.Sese005001.DeliverInformation21 *-- ISO20022.Sese005001.AdditionalReference10
    ISO20022.Sese005001.DeliverInformation21 *-- ISO20022.Sese005001.DeliveryParameters4
    ISO20022.Sese005001.DeliverInformation21 *-- ISO20022.Sese005001.FundSettlementParameters15
    ISO20022.Sese005001.DeliverInformation21 *-- ISO20022.Sese005001.ForeignExchangeTerms37
    ISO20022.Sese005001.DeliverInformation21 *-- ISO20022.Sese005001.Tax38
    ISO20022.Sese005001.DeliverInformation21 *-- ISO20022.Sese005001.Fees2
    ISO20022.Sese005001.DeliverInformation21 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    ISO20022.Sese005001.DeliverInformation21 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    ISO20022.Sese005001.DeliverInformation21 *-- ISO20022.Sese005001.Intermediary43
    ISO20022.Sese005001.DeliverInformation21 *-- ISO20022.Sese005001.Account31
    ISO20022.Sese005001.DeliverInformation21 *-- ISO20022.Sese005001.PartyIdentification139
    class ISO20022.Sese005001.DeliveryParameters4 {
        + CtctPrsn  : ISO20022.Sese005001.ContactIdentification2
        + NmAndAdr  : ISO20022.Sese005001.NameAndAddress4
        + RegdAdrInd  : String
    }
    ISO20022.Sese005001.DeliveryParameters4 *-- ISO20022.Sese005001.ContactIdentification2
    ISO20022.Sese005001.DeliveryParameters4 *-- ISO20022.Sese005001.NameAndAddress4
    class ISO20022.Sese005001.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class ISO20022.Sese005001.ExemptionReason1Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese005001.ExemptionReason1Choice *-- ISO20022.Sese005001.GenericIdentification47
    class ISO20022.Sese005001.Extension1 {
        + Txt  : String
        + PlcAndNm  : String
    }
    class ISO20022.Sese005001.Fee5 {
        + InftvInd  : String
        + RcptId  : ISO20022.Sese005001.PartyIdentification139
        + NonStdSLARef  : String
        + ApldRate  : Decimal
        + ApldAmt  : ISO20022.Sese005001.ActiveCurrencyAndAmount
        + DscntDtls  : ISO20022.Sese005001.ChargeOrCommissionDiscount1
        + StdRate  : Decimal
        + StdAmt  : ISO20022.Sese005001.ActiveCurrencyAndAmount
        + Bsis  : ISO20022.Sese005001.ChargeBasis2Choice
        + Tp  : ISO20022.Sese005001.ChargeType5Choice
    }
    ISO20022.Sese005001.Fee5 *-- ISO20022.Sese005001.PartyIdentification139
    ISO20022.Sese005001.Fee5 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    ISO20022.Sese005001.Fee5 *-- ISO20022.Sese005001.ChargeOrCommissionDiscount1
    ISO20022.Sese005001.Fee5 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    ISO20022.Sese005001.Fee5 *-- ISO20022.Sese005001.ChargeBasis2Choice
    ISO20022.Sese005001.Fee5 *-- ISO20022.Sese005001.ChargeType5Choice
    class ISO20022.Sese005001.Fee7 {
        + RcptId  : ISO20022.Sese005001.PartyIdentification139
        + ChrgBr  : String
        + DscntDtls  : ISO20022.Sese005001.ChargeOrCommissionDiscount2
        + Amt  : ISO20022.Sese005001.ActiveCurrencyAndAmount
        + Bsis  : ISO20022.Sese005001.ChargeBasis2Choice
        + Tp  : ISO20022.Sese005001.ChargeType6Choice
    }
    ISO20022.Sese005001.Fee7 *-- ISO20022.Sese005001.PartyIdentification139
    ISO20022.Sese005001.Fee7 *-- ISO20022.Sese005001.ChargeOrCommissionDiscount2
    ISO20022.Sese005001.Fee7 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    ISO20022.Sese005001.Fee7 *-- ISO20022.Sese005001.ChargeBasis2Choice
    ISO20022.Sese005001.Fee7 *-- ISO20022.Sese005001.ChargeType6Choice
    class ISO20022.Sese005001.Fees2 {
        + IndvFee  : global::System.Collections.Generic.List~ISO20022.Sese005001.Fee7~
        + ComrclAgrmtRef  : String
    }
    ISO20022.Sese005001.Fees2 *-- ISO20022.Sese005001.Fee7
    class ISO20022.Sese005001.FinancialInstrument88 {
        + DmtrlsdInd  : String
        + DstrbtnPlcy  : String
        + SctiesForm  : String
        + ClssTp  : String
        + SplmtryId  : String
        + ShrtNm  : String
        + Nm  : String
        + Id  : ISO20022.Sese005001.SecurityIdentification25Choice
    }
    ISO20022.Sese005001.FinancialInstrument88 *-- ISO20022.Sese005001.SecurityIdentification25Choice
    class ISO20022.Sese005001.ForeignExchangeTerms37 {
        + QtgInstn  : ISO20022.Sese005001.PartyIdentification139
        + QtnDt  : DateTime
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
        + FrAmt  : ISO20022.Sese005001.ActiveCurrencyAndAmount
        + ToAmt  : ISO20022.Sese005001.ActiveCurrencyAndAmount
    }
    ISO20022.Sese005001.ForeignExchangeTerms37 *-- ISO20022.Sese005001.PartyIdentification139
    ISO20022.Sese005001.ForeignExchangeTerms37 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    ISO20022.Sese005001.ForeignExchangeTerms37 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    class ISO20022.Sese005001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Sese005001.FundSettlementParameters15 {
        + DlvrgSdDtls  : ISO20022.Sese005001.SettlementParties94
        + SctiesSttlmSysId  : String
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese005001.SettlementTransactionCondition30Choice~
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Sese005001.TradeTransactionCondition8Choice~
    }
    ISO20022.Sese005001.FundSettlementParameters15 *-- ISO20022.Sese005001.SettlementParties94
    ISO20022.Sese005001.FundSettlementParameters15 *-- ISO20022.Sese005001.SettlementTransactionCondition30Choice
    ISO20022.Sese005001.FundSettlementParameters15 *-- ISO20022.Sese005001.TradeTransactionCondition8Choice
    class ISO20022.Sese005001.FundSettlementParameters16 {
        + RcvgSdDtls  : ISO20022.Sese005001.SettlementParties94
        + SctiesSttlmSysId  : String
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese005001.SettlementTransactionCondition30Choice~
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Sese005001.TradeTransactionCondition8Choice~
    }
    ISO20022.Sese005001.FundSettlementParameters16 *-- ISO20022.Sese005001.SettlementParties94
    ISO20022.Sese005001.FundSettlementParameters16 *-- ISO20022.Sese005001.SettlementTransactionCondition30Choice
    ISO20022.Sese005001.FundSettlementParameters16 *-- ISO20022.Sese005001.TradeTransactionCondition8Choice
    class ISO20022.Sese005001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Sese005001.GenericIdentification27 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Sese005001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese005001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese005001.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese005001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Sese005001.GenericIdentification30
    }
    ISO20022.Sese005001.GenericIdentification78 *-- ISO20022.Sese005001.GenericIdentification30
    class ISO20022.Sese005001.HoldingsPlanType1Code {
        PLAR = 1
        SWIP = 2
        INVP = 3
    }
    class ISO20022.Sese005001.IdentificationSource1Choice {
        + Prtry  : String
        + Dmst  : String
    }
    class ISO20022.Sese005001.IdentificationType42Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese005001.IdentificationType42Choice *-- ISO20022.Sese005001.GenericIdentification30
    class ISO20022.Sese005001.IncomePreference2Code {
        SECU = 1
        CASH = 2
    }
    class ISO20022.Sese005001.Intermediary43 {
        + CtctPrsn  : ISO20022.Sese005001.ContactIdentification2
        + Role  : ISO20022.Sese005001.Role4Choice
        + Acct  : ISO20022.Sese005001.Account27
        + Id  : ISO20022.Sese005001.PartyIdentification139
    }
    ISO20022.Sese005001.Intermediary43 *-- ISO20022.Sese005001.ContactIdentification2
    ISO20022.Sese005001.Intermediary43 *-- ISO20022.Sese005001.Role4Choice
    ISO20022.Sese005001.Intermediary43 *-- ISO20022.Sese005001.Account27
    ISO20022.Sese005001.Intermediary43 *-- ISO20022.Sese005001.PartyIdentification139
    class ISO20022.Sese005001.InvestmentAccount71 {
        + SttlmPtiesDtls  : ISO20022.Sese005001.FundSettlementParameters16
        + SfkpgPlc  : ISO20022.Sese005001.SafekeepingPlaceFormat28Choice
        + BnfcryCertfctnCmpltn  : String
        + IncmPref  : String
        + DmtrlsdInd  : String
        + SctiesForm  : String
        + IntrmyInf  : global::System.Collections.Generic.List~ISO20022.Sese005001.Intermediary43~
        + SubAcctDtls  : ISO20022.Sese005001.SubAccount5
        + AcctSvcr  : ISO20022.Sese005001.PartyIdentification139
        + AcctDsgnt  : String
        + AcctNm  : String
        + AcctId  : String
        + OwnrId  : global::System.Collections.Generic.List~ISO20022.Sese005001.PartyIdentification139~
    }
    ISO20022.Sese005001.InvestmentAccount71 *-- ISO20022.Sese005001.FundSettlementParameters16
    ISO20022.Sese005001.InvestmentAccount71 *-- ISO20022.Sese005001.SafekeepingPlaceFormat28Choice
    ISO20022.Sese005001.InvestmentAccount71 *-- ISO20022.Sese005001.Intermediary43
    ISO20022.Sese005001.InvestmentAccount71 *-- ISO20022.Sese005001.SubAccount5
    ISO20022.Sese005001.InvestmentAccount71 *-- ISO20022.Sese005001.PartyIdentification139
    ISO20022.Sese005001.InvestmentAccount71 *-- ISO20022.Sese005001.PartyIdentification139
    class ISO20022.Sese005001.InvestmentFundFee1Code {
        PENA = 1
        REGF = 2
        UCIC = 3
        SWIT = 4
        SHIP = 5
        CHAR = 6
        PREM = 7
        POST = 8
        ADDF = 9
        INIT = 10
        FEND = 11
        DLEV = 12
        CBCH = 13
        CDSC = 14
        CDPL = 15
        COMM = 16
        BRKF = 17
        BEND = 18
    }
    class ISO20022.Sese005001.InvestmentFundFee2Code {
        SPCN = 1
        SHIP = 2
        REGF = 3
        POST = 4
        TRAN = 5
        FEND = 6
        BEND = 7
    }
    class ISO20022.Sese005001.InvestmentFundRole2Code {
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
    class ISO20022.Sese005001.MarketPracticeVersion1 {
        + Nb  : String
        + Dt  : String
        + Nm  : String
    }
    class ISO20022.Sese005001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Sese005001.NameAndAddress4 {
        + Adr  : ISO20022.Sese005001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Sese005001.NameAndAddress4 *-- ISO20022.Sese005001.PostalAddress1
    class ISO20022.Sese005001.NameAndAddress5 {
        + Adr  : ISO20022.Sese005001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Sese005001.NameAndAddress5 *-- ISO20022.Sese005001.PostalAddress1
    class ISO20022.Sese005001.NamePrefix1Code {
        MADM = 1
        MISS = 2
        MIST = 3
        DOCT = 4
    }
    class ISO20022.Sese005001.OtherAmount1 {
        + Amt  : ISO20022.Sese005001.ActiveCurrencyAndAmount
        + Tp  : ISO20022.Sese005001.OtherAmountType1Choice
    }
    ISO20022.Sese005001.OtherAmount1 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    ISO20022.Sese005001.OtherAmount1 *-- ISO20022.Sese005001.OtherAmountType1Choice
    class ISO20022.Sese005001.OtherAmountType1Choice {
        + PrtryCd  : ISO20022.Sese005001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Sese005001.OtherAmountType1Choice *-- ISO20022.Sese005001.GenericIdentification1
    class ISO20022.Sese005001.OtherAmountType1Code {
        SINT = 1
        PINT = 2
    }
    class ISO20022.Sese005001.PartyIdentification122Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese005001.NameAndAddress5
        + AnyBIC  : String
    }
    ISO20022.Sese005001.PartyIdentification122Choice *-- ISO20022.Sese005001.NameAndAddress5
    class ISO20022.Sese005001.PartyIdentification123Choice {
        + NmAndAdr  : ISO20022.Sese005001.NameAndAddress5
        + PrtryId  : ISO20022.Sese005001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese005001.PartyIdentification123Choice *-- ISO20022.Sese005001.NameAndAddress5
    ISO20022.Sese005001.PartyIdentification123Choice *-- ISO20022.Sese005001.GenericIdentification36
    class ISO20022.Sese005001.PartyIdentification125Choice {
        + NmAndAdr  : ISO20022.Sese005001.NameAndAddress5
        + PrtryId  : ISO20022.Sese005001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Sese005001.PartyIdentification125Choice *-- ISO20022.Sese005001.NameAndAddress5
    ISO20022.Sese005001.PartyIdentification125Choice *-- ISO20022.Sese005001.GenericIdentification1
    class ISO20022.Sese005001.PartyIdentification139 {
        + LEI  : String
        + Pty  : ISO20022.Sese005001.PartyIdentification125Choice
    }
    ISO20022.Sese005001.PartyIdentification139 *-- ISO20022.Sese005001.PartyIdentification125Choice
    class ISO20022.Sese005001.PartyIdentification141 {
        + AddtlInf  : ISO20022.Sese005001.PartyTextInformation1
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese005001.DateAndDateTime2Choice
        + AltrnId  : ISO20022.Sese005001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese005001.PartyIdentification122Choice
    }
    ISO20022.Sese005001.PartyIdentification141 *-- ISO20022.Sese005001.PartyTextInformation1
    ISO20022.Sese005001.PartyIdentification141 *-- ISO20022.Sese005001.DateAndDateTime2Choice
    ISO20022.Sese005001.PartyIdentification141 *-- ISO20022.Sese005001.AlternatePartyIdentification7
    ISO20022.Sese005001.PartyIdentification141 *-- ISO20022.Sese005001.PartyIdentification122Choice
    class ISO20022.Sese005001.PartyIdentificationAndAccount194 {
        + AddtlInf  : ISO20022.Sese005001.PartyTextInformation6
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese005001.DateAndDateTime2Choice
        + SfkpgAcct  : ISO20022.Sese005001.SecuritiesAccount19
        + AltrnId  : ISO20022.Sese005001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese005001.PartyIdentification123Choice
    }
    ISO20022.Sese005001.PartyIdentificationAndAccount194 *-- ISO20022.Sese005001.PartyTextInformation6
    ISO20022.Sese005001.PartyIdentificationAndAccount194 *-- ISO20022.Sese005001.DateAndDateTime2Choice
    ISO20022.Sese005001.PartyIdentificationAndAccount194 *-- ISO20022.Sese005001.SecuritiesAccount19
    ISO20022.Sese005001.PartyIdentificationAndAccount194 *-- ISO20022.Sese005001.AlternatePartyIdentification7
    ISO20022.Sese005001.PartyIdentificationAndAccount194 *-- ISO20022.Sese005001.PartyIdentification123Choice
    class ISO20022.Sese005001.PartyTextInformation1 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese005001.PartyTextInformation6 {
        + RegnAdr  : ISO20022.Sese005001.PostalAddress1
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    ISO20022.Sese005001.PartyTextInformation6 *-- ISO20022.Sese005001.PostalAddress1
    class ISO20022.Sese005001.PhysicalTransferType1Code {
        PHYS = 1
        DEMT = 2
    }
    class ISO20022.Sese005001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Sese005001.PriceMethod1Code {
        HIST = 1
        FORW = 2
    }
    class ISO20022.Sese005001.PriceValue1 {
        + Amt  : ISO20022.Sese005001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Sese005001.PriceValue1 *-- ISO20022.Sese005001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Sese005001.Quantity42Choice {
        + TrfRate  : Decimal
        + TtlUnitsNb  : Decimal
    }
    class ISO20022.Sese005001.Role4Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese005001.Role4Choice *-- ISO20022.Sese005001.GenericIdentification47
    class ISO20022.Sese005001.RoundingDirection2Code {
        RDWN = 1
        RDUP = 2
    }
    class ISO20022.Sese005001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Sese005001.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Sese005001.SafekeepingPlaceFormat28Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification78
        + TpAndId  : ISO20022.Sese005001.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Sese005001.SafekeepingPlaceTypeAndText6
    }
    ISO20022.Sese005001.SafekeepingPlaceFormat28Choice *-- ISO20022.Sese005001.GenericIdentification78
    ISO20022.Sese005001.SafekeepingPlaceFormat28Choice *-- ISO20022.Sese005001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Sese005001.SafekeepingPlaceFormat28Choice *-- ISO20022.Sese005001.SafekeepingPlaceTypeAndText6
    class ISO20022.Sese005001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese005001.SafekeepingPlaceTypeAndText6 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese005001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Sese005001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese005001.SecuritiesAccount19 *-- ISO20022.Sese005001.GenericIdentification30
    class ISO20022.Sese005001.SecurityIdentification25Choice {
        + OthrPrtryId  : ISO20022.Sese005001.AlternateSecurityIdentification7
        + Cmon  : String
        + Belgn  : String
        + SCVM  : String
        + Vlrn  : String
        + Dtch  : String
        + Wrtppr  : String
        + QUICK  : String
        + CTA  : String
        + Blmbrg  : String
        + TckrSymb  : String
        + RIC  : String
        + CUSIP  : String
        + SEDOL  : String
        + ISIN  : String
    }
    ISO20022.Sese005001.SecurityIdentification25Choice *-- ISO20022.Sese005001.AlternateSecurityIdentification7
    class ISO20022.Sese005001.SettlementDate1Code {
        WHIF = 1
        ENDC = 2
        ASAP = 3
    }
    class ISO20022.Sese005001.SettlementParties94 {
        + Pty5  : ISO20022.Sese005001.PartyIdentificationAndAccount194
        + Pty4  : ISO20022.Sese005001.PartyIdentificationAndAccount194
        + Pty3  : ISO20022.Sese005001.PartyIdentificationAndAccount194
        + Pty2  : ISO20022.Sese005001.PartyIdentificationAndAccount194
        + Pty1  : ISO20022.Sese005001.PartyIdentificationAndAccount194
        + Dpstry  : ISO20022.Sese005001.PartyIdentification141
    }
    ISO20022.Sese005001.SettlementParties94 *-- ISO20022.Sese005001.PartyIdentificationAndAccount194
    ISO20022.Sese005001.SettlementParties94 *-- ISO20022.Sese005001.PartyIdentificationAndAccount194
    ISO20022.Sese005001.SettlementParties94 *-- ISO20022.Sese005001.PartyIdentificationAndAccount194
    ISO20022.Sese005001.SettlementParties94 *-- ISO20022.Sese005001.PartyIdentificationAndAccount194
    ISO20022.Sese005001.SettlementParties94 *-- ISO20022.Sese005001.PartyIdentificationAndAccount194
    ISO20022.Sese005001.SettlementParties94 *-- ISO20022.Sese005001.PartyIdentification141
    class ISO20022.Sese005001.SettlementTransactionCondition11Code {
        NOMC = 1
    }
    class ISO20022.Sese005001.SettlementTransactionCondition30Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese005001.SettlementTransactionCondition30Choice *-- ISO20022.Sese005001.GenericIdentification30
    class ISO20022.Sese005001.StampDutyType2Code {
        SDRN = 1
        ASTD = 2
    }
    class ISO20022.Sese005001.SubAccount5 {
        + Chrtc  : String
        + Nm  : String
        + Id  : String
    }
    class ISO20022.Sese005001.Tax35 {
        + TaxClctnDtls  : ISO20022.Sese005001.TaxCalculationInformation10
        + RcptId  : ISO20022.Sese005001.PartyIdentification139
        + Ctry  : String
        + ApldRate  : Decimal
        + ApldAmt  : ISO20022.Sese005001.ActiveCurrencyAndAmount
        + Tp  : ISO20022.Sese005001.TaxType3Choice
    }
    ISO20022.Sese005001.Tax35 *-- ISO20022.Sese005001.TaxCalculationInformation10
    ISO20022.Sese005001.Tax35 *-- ISO20022.Sese005001.PartyIdentification139
    ISO20022.Sese005001.Tax35 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    ISO20022.Sese005001.Tax35 *-- ISO20022.Sese005001.TaxType3Choice
    class ISO20022.Sese005001.Tax38 {
        + TaxClctnDtls  : ISO20022.Sese005001.TaxCalculationInformation11
        + RcptId  : ISO20022.Sese005001.PartyIdentification139
        + XmptnRsn  : ISO20022.Sese005001.ExemptionReason1Choice
        + XmptnInd  : String
        + Ctry  : String
        + Amt  : ISO20022.Sese005001.ActiveCurrencyAndAmount
        + Bsis  : ISO20022.Sese005001.TaxBasis1Choice
        + Tp  : ISO20022.Sese005001.TaxType1Choice
    }
    ISO20022.Sese005001.Tax38 *-- ISO20022.Sese005001.TaxCalculationInformation11
    ISO20022.Sese005001.Tax38 *-- ISO20022.Sese005001.PartyIdentification139
    ISO20022.Sese005001.Tax38 *-- ISO20022.Sese005001.ExemptionReason1Choice
    ISO20022.Sese005001.Tax38 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    ISO20022.Sese005001.Tax38 *-- ISO20022.Sese005001.TaxBasis1Choice
    ISO20022.Sese005001.Tax38 *-- ISO20022.Sese005001.TaxType1Choice
    class ISO20022.Sese005001.TaxBasis1Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese005001.TaxBasis1Choice *-- ISO20022.Sese005001.GenericIdentification47
    class ISO20022.Sese005001.TaxCalculationInformation10 {
        + TaxblAmt  : ISO20022.Sese005001.ActiveCurrencyAndAmount
        + Bsis  : ISO20022.Sese005001.TaxBasis1Choice
    }
    ISO20022.Sese005001.TaxCalculationInformation10 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    ISO20022.Sese005001.TaxCalculationInformation10 *-- ISO20022.Sese005001.TaxBasis1Choice
    class ISO20022.Sese005001.TaxCalculationInformation11 {
        + TaxblAmt  : ISO20022.Sese005001.ActiveCurrencyAndAmount
        + Bsis  : ISO20022.Sese005001.TaxBasis1Choice
    }
    ISO20022.Sese005001.TaxCalculationInformation11 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    ISO20022.Sese005001.TaxCalculationInformation11 *-- ISO20022.Sese005001.TaxBasis1Choice
    class ISO20022.Sese005001.TaxExemptReason1Code {
        EIOP = 1
        EIFP = 2
        RCIP = 3
        RCRF = 4
        RIAN = 5
        RIRA = 6
        E457X = 7
        E403B = 8
        SIRA = 9
        E401K = 10
        PFSP = 11
        KEOG = 12
        IRAR = 13
        IRAC = 14
        DECP = 15
        NFQP = 16
        NFPI = 17
        ECYE = 18
        EPRY = 19
        EMCY = 20
        EMPY = 21
        ASTR = 22
        PRYP = 23
        CUYP = 24
        IISA = 25
        SISA = 26
        MISA = 27
        MASA = 28
        NONE = 29
    }
    class ISO20022.Sese005001.TaxType16Code {
        KAPA = 1
        NKAP = 2
        WITH = 3
        VATA = 4
        TRAX = 5
        TRAN = 6
        STEX = 7
        STAT = 8
        STAM = 9
        PROV = 10
        NATI = 11
        LOCL = 12
        LEVY = 13
        EUTR = 14
        CTAX = 15
        COAX = 16
    }
    class ISO20022.Sese005001.TaxType17Code {
        ZWIS = 1
        AKT2 = 2
        AKT1 = 3
        EUTR = 4
        COAX = 5
        GIFT = 6
        CTAX = 7
        SOSU = 8
        INHT = 9
        WTAX = 10
        STAM = 11
        INPO = 12
        NKAP = 13
        KAPA = 14
        WITH = 15
        STAT = 16
        NATI = 17
        PROV = 18
    }
    class ISO20022.Sese005001.TaxType1Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese005001.TaxType1Choice *-- ISO20022.Sese005001.GenericIdentification47
    class ISO20022.Sese005001.TaxType3Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese005001.TaxType3Choice *-- ISO20022.Sese005001.GenericIdentification47
    class ISO20022.Sese005001.TaxableIncomePerShareCalculated2Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese005001.TaxableIncomePerShareCalculated2Choice *-- ISO20022.Sese005001.GenericIdentification47
    class ISO20022.Sese005001.TaxableIncomePerShareCalculated2Code {
        UKWN = 1
        TSIN = 2
        TSIY = 3
    }
    class ISO20022.Sese005001.TaxationBasis2Code {
        PERU = 1
        FLAT = 2
    }
    class ISO20022.Sese005001.TaxationBasis5Code {
        PERU = 1
        NAVP = 2
        NEAM = 3
        GRAM = 4
        FLAT = 5
    }
    class ISO20022.Sese005001.TotalFeesAndTaxes42 {
        + IndvTax  : global::System.Collections.Generic.List~ISO20022.Sese005001.Tax35~
        + IndvFee  : global::System.Collections.Generic.List~ISO20022.Sese005001.Fee5~
        + ComrclAgrmtRef  : String
        + TtlTaxs  : ISO20022.Sese005001.ActiveCurrencyAndAmount
        + TtlFees  : ISO20022.Sese005001.ActiveCurrencyAndAmount
        + TtlOvrhdApld  : ISO20022.Sese005001.ActiveCurrencyAndAmount
    }
    ISO20022.Sese005001.TotalFeesAndTaxes42 *-- ISO20022.Sese005001.Tax35
    ISO20022.Sese005001.TotalFeesAndTaxes42 *-- ISO20022.Sese005001.Fee5
    ISO20022.Sese005001.TotalFeesAndTaxes42 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    ISO20022.Sese005001.TotalFeesAndTaxes42 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    ISO20022.Sese005001.TotalFeesAndTaxes42 *-- ISO20022.Sese005001.ActiveCurrencyAndAmount
    class ISO20022.Sese005001.TradeTransactionCondition5Code {
        CCPN = 1
        XCPN = 2
    }
    class ISO20022.Sese005001.TradeTransactionCondition8Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese005001.TradeTransactionCondition8Choice *-- ISO20022.Sese005001.GenericIdentification30
    class ISO20022.Sese005001.Transfer36 {
        + TrfExpnssPmtTp  : ISO20022.Sese005001.ChargePaymentMethod1Choice
        + NonStdSttlmInf  : String
        + OwnAcctTrfInd  : String
        + TrfCcy  : String
        + AvrgPric  : ISO20022.Sese005001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + OrgnlCost  : ISO20022.Sese005001.ActiveCurrencyAnd13DecimalAmount
        + Rndg  : String
        + UnitsDtls  : global::System.Collections.Generic.List~ISO20022.Sese005001.Unit12~
        + Qty  : ISO20022.Sese005001.Quantity42Choice
        + FinInstrmDtls  : ISO20022.Sese005001.FinancialInstrument88
        + HldgsPlanTp  : global::System.Collections.Generic.List~String~
        + TrfRsn  : ISO20022.Sese005001.TransferReason1Choice
        + TrfOrdrDtForm  : DateTime
        + ReqdSttlmDt  : DateTime
        + ReqdTrfDt  : ISO20022.Sese005001.DateFormat1Choice
        + BizFlowTp  : String
        + CtrPtyRef  : ISO20022.Sese005001.AdditionalReference10
        + ClntRef  : ISO20022.Sese005001.AdditionalReference10
        + TrfRef  : String
    }
    ISO20022.Sese005001.Transfer36 *-- ISO20022.Sese005001.ChargePaymentMethod1Choice
    ISO20022.Sese005001.Transfer36 *-- ISO20022.Sese005001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    ISO20022.Sese005001.Transfer36 *-- ISO20022.Sese005001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese005001.Transfer36 *-- ISO20022.Sese005001.Unit12
    ISO20022.Sese005001.Transfer36 *-- ISO20022.Sese005001.Quantity42Choice
    ISO20022.Sese005001.Transfer36 *-- ISO20022.Sese005001.FinancialInstrument88
    ISO20022.Sese005001.Transfer36 *-- ISO20022.Sese005001.TransferReason1Choice
    ISO20022.Sese005001.Transfer36 *-- ISO20022.Sese005001.DateFormat1Choice
    ISO20022.Sese005001.Transfer36 *-- ISO20022.Sese005001.AdditionalReference10
    ISO20022.Sese005001.Transfer36 *-- ISO20022.Sese005001.AdditionalReference10
    class ISO20022.Sese005001.TransferInFunction1Code {
        INST = 1
        ADRE = 2
    }
    class ISO20022.Sese005001.TransferInInstructionV09 {
        + Xtnsn  : global::System.Collections.Generic.List~ISO20022.Sese005001.Extension1~
        + CpyDtls  : ISO20022.Sese005001.CopyInformation5
        + MktPrctcVrsn  : ISO20022.Sese005001.MarketPracticeVersion1
        + SttlmDtls  : ISO20022.Sese005001.DeliverInformation21
        + AcctDtls  : ISO20022.Sese005001.InvestmentAccount71
        + TrfDtls  : global::System.Collections.Generic.List~ISO20022.Sese005001.Transfer36~
        + MstrRef  : String
        + Fctn  : String
        + RltdRef  : ISO20022.Sese005001.AdditionalReference10
        + PrvsRef  : ISO20022.Sese005001.AdditionalReference10
        + PoolRef  : ISO20022.Sese005001.AdditionalReference11
        + MsgId  : ISO20022.Sese005001.MessageIdentification1
    }
    ISO20022.Sese005001.TransferInInstructionV09 *-- ISO20022.Sese005001.Extension1
    ISO20022.Sese005001.TransferInInstructionV09 *-- ISO20022.Sese005001.CopyInformation5
    ISO20022.Sese005001.TransferInInstructionV09 *-- ISO20022.Sese005001.MarketPracticeVersion1
    ISO20022.Sese005001.TransferInInstructionV09 *-- ISO20022.Sese005001.DeliverInformation21
    ISO20022.Sese005001.TransferInInstructionV09 *-- ISO20022.Sese005001.InvestmentAccount71
    ISO20022.Sese005001.TransferInInstructionV09 *-- ISO20022.Sese005001.Transfer36
    ISO20022.Sese005001.TransferInInstructionV09 *-- ISO20022.Sese005001.AdditionalReference10
    ISO20022.Sese005001.TransferInInstructionV09 *-- ISO20022.Sese005001.AdditionalReference10
    ISO20022.Sese005001.TransferInInstructionV09 *-- ISO20022.Sese005001.AdditionalReference11
    ISO20022.Sese005001.TransferInInstructionV09 *-- ISO20022.Sese005001.MessageIdentification1
    class ISO20022.Sese005001.TransferReason1Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification27
        + Cd  : String
    }
    ISO20022.Sese005001.TransferReason1Choice *-- ISO20022.Sese005001.GenericIdentification27
    class ISO20022.Sese005001.TransferReason1Code {
        TRAN = 1
        TRAF = 2
        TRPE = 3
        TTDT = 4
        TPLD = 5
        TRAG = 6
        TRAI = 7
        TRAO = 8
        TRAT = 9
        TRAC = 10
        TRAU = 11
    }
    class ISO20022.Sese005001.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Sese005001.TypeOfPrice10Code {
        ACTU = 1
        DDVR = 2
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
    class ISO20022.Sese005001.TypeOfPrice46Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese005001.TypeOfPrice46Choice *-- ISO20022.Sese005001.GenericIdentification47
    class ISO20022.Sese005001.UKTaxGroupUnit1Code {
        GRP2 = 1
        GRP1 = 2
    }
    class ISO20022.Sese005001.Unit12 {
        + OthrAmt  : global::System.Collections.Generic.List~ISO20022.Sese005001.OtherAmount1~
        + TxOvrhd  : ISO20022.Sese005001.TotalFeesAndTaxes42
        + PricDtls  : ISO20022.Sese005001.UnitPrice23
        + Ref  : String
        + Grp1Or2Units  : String
        + CertNb  : global::System.Collections.Generic.List~String~
        + AcqstnDt  : DateTime
        + OrdrDt  : DateTime
        + UnitsNb  : Decimal
    }
    ISO20022.Sese005001.Unit12 *-- ISO20022.Sese005001.OtherAmount1
    ISO20022.Sese005001.Unit12 *-- ISO20022.Sese005001.TotalFeesAndTaxes42
    ISO20022.Sese005001.Unit12 *-- ISO20022.Sese005001.UnitPrice23
    class ISO20022.Sese005001.UnitPrice23 {
        + TaxblIncmPerShrClctd  : ISO20022.Sese005001.TaxableIncomePerShareCalculated2Choice
        + TaxblIncmPerShr  : ISO20022.Sese005001.ActiveCurrencyAnd13DecimalAmount
        + NbOfDaysAcrd  : Decimal
        + AcrdIntrstNAV  : ISO20022.Sese005001.ActiveOrHistoricCurrencyAndAmount
        + PricMtd  : String
        + Val  : ISO20022.Sese005001.PriceValue1
        + Tp  : ISO20022.Sese005001.TypeOfPrice46Choice
    }
    ISO20022.Sese005001.UnitPrice23 *-- ISO20022.Sese005001.TaxableIncomePerShareCalculated2Choice
    ISO20022.Sese005001.UnitPrice23 *-- ISO20022.Sese005001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese005001.UnitPrice23 *-- ISO20022.Sese005001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese005001.UnitPrice23 *-- ISO20022.Sese005001.PriceValue1
    ISO20022.Sese005001.UnitPrice23 *-- ISO20022.Sese005001.TypeOfPrice46Choice
    class ISO20022.Sese005001.WaivingInstruction1Code {
        WIUN = 1
        WICA = 2
    }
    class ISO20022.Sese005001.WaivingInstruction2Choice {
        + Prtry  : ISO20022.Sese005001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese005001.WaivingInstruction2Choice *-- ISO20022.Sese005001.GenericIdentification47
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

## Value ISO20022.Sese005001.Account27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|ISO20022.Sese005001.PartyIdentification139||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcr))|

---

## Value ISO20022.Sese005001.Account31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubAcctDtls|ISO20022.Sese005001.SubAccount5||XmlElement()||
|+|Svcr|ISO20022.Sese005001.PartyIdentification139||XmlElement()||
|+|Dsgnt|String||XmlElement()||
|+|AcctNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SubAcctDtls),validElement(Svcr))|

---

## Value ISO20022.Sese005001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese005001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese005001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese005001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese005001.AdditionalReference10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Sese005001.PartyIdentification139||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Value ISO20022.Sese005001.AdditionalReference11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Sese005001.PartyIdentification139||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Enum ISO20022.Sese005001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Sese005001.AlternatePartyIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Sese005001.IdentificationType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Sese005001.AlternateSecurityIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdSrc|ISO20022.Sese005001.IdentificationSource1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdSrc))|

---

## Enum ISO20022.Sese005001.BeneficiaryCertificationCompletion1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHYS|Int32||XmlEnum("""PHYS""")|1|
||ELEC|Int32||XmlEnum("""ELEC""")|2|
||NCER|Int32||XmlEnum("""NCER""")|3|

---

## Enum ISO20022.Sese005001.BusinessFlowType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLPR|Int32||XmlEnum("""DLPR""")|1|
||SLRP|Int32||XmlEnum("""SLRP""")|2|
||SLDP|Int32||XmlEnum("""SLDP""")|3|

---

## Value ISO20022.Sese005001.ChargeBasis2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese005001.ChargeBearer1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHA|Int32||XmlEnum("""SHA""")|1|
||BEN|Int32||XmlEnum("""BEN""")|2|
||OUR|Int32||XmlEnum("""OUR""")|3|

---

## Value ISO20022.Sese005001.ChargeOrCommissionDiscount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bsis|ISO20022.Sese005001.WaivingInstruction2Choice||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bsis),validElement(Amt))|

---

## Value ISO20022.Sese005001.ChargeOrCommissionDiscount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bsis|ISO20022.Sese005001.WaivingInstruction2Choice||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bsis),validElement(Amt))|

---

## Value ISO20022.Sese005001.ChargePaymentMethod1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese005001.ChargePaymentMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNIT|Int32||XmlEnum("""UNIT""")|1|
||CASH|Int32||XmlEnum("""CASH""")|2|

---

## Value ISO20022.Sese005001.ChargeType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese005001.ChargeType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese005001.ContactIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobNb""",MobNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Sese005001.CopyInformation5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlRcvr|String||XmlElement()||
|+|CpyInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""OrgnlRcvr""",OrgnlRcvr,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese005001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Sese005001.DateFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Cd|String||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Cd,Dt))|

---

## Value ISO20022.Sese005001.DeliverInformation21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClntRef|ISO20022.Sese005001.AdditionalReference10||XmlElement()||
|+|PhysTrfDtls|ISO20022.Sese005001.DeliveryParameters4||XmlElement()||
|+|PhysTrf|String||XmlElement()||
|+|SttlmPtiesDtls|ISO20022.Sese005001.FundSettlementParameters15||XmlElement()||
|+|FXDtls|global::System.Collections.Generic.List<ISO20022.Sese005001.ForeignExchangeTerms37>||XmlElement()||
|+|IndvTax|global::System.Collections.Generic.List<ISO20022.Sese005001.Tax38>||XmlElement()||
|+|Fees|global::System.Collections.Generic.List<ISO20022.Sese005001.Fees2>||XmlElement()||
|+|NetAmt|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
|+|StmpDty|String||XmlElement()||
|+|SttlmAmt|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
|+|ReqdSttlmDt|DateTime||XmlElement()||
|+|ReqdTradDt|DateTime||XmlElement()||
|+|BnfcryCertfctnCmpltn|String||XmlElement()||
|+|IncmPref|String||XmlElement()||
|+|DmtrlsdInd|String||XmlElement()||
|+|SctiesForm|String||XmlElement()||
|+|IntrmyInf|global::System.Collections.Generic.List<ISO20022.Sese005001.Intermediary43>||XmlElement()||
|+|TrfrRegdAcct|ISO20022.Sese005001.Account31||XmlElement()||
|+|Trfr|ISO20022.Sese005001.PartyIdentification139||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClntRef),validElement(PhysTrfDtls),validElement(SttlmPtiesDtls),validList("""FXDtls""",FXDtls),validElement(FXDtls),validList("""IndvTax""",IndvTax),validElement(IndvTax),validList("""Fees""",Fees),validElement(Fees),validElement(NetAmt),validElement(SttlmAmt),validList("""IntrmyInf""",IntrmyInf),validElement(IntrmyInf),validElement(TrfrRegdAcct),validElement(Trfr))|

---

## Value ISO20022.Sese005001.DeliveryParameters4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctPrsn|ISO20022.Sese005001.ContactIdentification2||XmlElement()||
|+|NmAndAdr|ISO20022.Sese005001.NameAndAddress4||XmlElement()||
|+|RegdAdrInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctPrsn),validElement(NmAndAdr))|

---

## Enum ISO20022.Sese005001.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||DIST|Int32||XmlEnum("""DIST""")|2|

---

## Type ISO20022.Sese005001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrfInInstr|ISO20022.Sese005001.TransferInInstructionV09||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrfInInstr))|

---

## Value ISO20022.Sese005001.ExemptionReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese005001.Extension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese005001.Fee5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InftvInd|String||XmlElement()||
|+|RcptId|ISO20022.Sese005001.PartyIdentification139||XmlElement()||
|+|NonStdSLARef|String||XmlElement()||
|+|ApldRate|Decimal||XmlElement()||
|+|ApldAmt|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
|+|DscntDtls|ISO20022.Sese005001.ChargeOrCommissionDiscount1||XmlElement()||
|+|StdRate|Decimal||XmlElement()||
|+|StdAmt|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
|+|Bsis|ISO20022.Sese005001.ChargeBasis2Choice||XmlElement()||
|+|Tp|ISO20022.Sese005001.ChargeType5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcptId),validElement(ApldAmt),validElement(DscntDtls),validElement(StdAmt),validElement(Bsis),validElement(Tp))|

---

## Value ISO20022.Sese005001.Fee7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcptId|ISO20022.Sese005001.PartyIdentification139||XmlElement()||
|+|ChrgBr|String||XmlElement()||
|+|DscntDtls|ISO20022.Sese005001.ChargeOrCommissionDiscount2||XmlElement()||
|+|Amt|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
|+|Bsis|ISO20022.Sese005001.ChargeBasis2Choice||XmlElement()||
|+|Tp|ISO20022.Sese005001.ChargeType6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcptId),validElement(DscntDtls),validElement(Amt),validElement(Bsis),validElement(Tp))|

---

## Value ISO20022.Sese005001.Fees2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndvFee|global::System.Collections.Generic.List<ISO20022.Sese005001.Fee7>||XmlElement()||
|+|ComrclAgrmtRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""IndvFee""",IndvFee),validElement(IndvFee))|

---

## Value ISO20022.Sese005001.FinancialInstrument88


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DmtrlsdInd|String||XmlElement()||
|+|DstrbtnPlcy|String||XmlElement()||
|+|SctiesForm|String||XmlElement()||
|+|ClssTp|String||XmlElement()||
|+|SplmtryId|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Sese005001.SecurityIdentification25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Sese005001.ForeignExchangeTerms37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtgInstn|ISO20022.Sese005001.PartyIdentification139||XmlElement()||
|+|QtnDt|DateTime||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
|+|FrAmt|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
|+|ToAmt|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtgInstn),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""),validElement(FrAmt),validElement(ToAmt))|

---

## Enum ISO20022.Sese005001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Sese005001.FundSettlementParameters15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DlvrgSdDtls|ISO20022.Sese005001.SettlementParties94||XmlElement()||
|+|SctiesSttlmSysId|String||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese005001.SettlementTransactionCondition30Choice>||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Sese005001.TradeTransactionCondition8Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DlvrgSdDtls),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond))|

---

## Value ISO20022.Sese005001.FundSettlementParameters16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcvgSdDtls|ISO20022.Sese005001.SettlementParties94||XmlElement()||
|+|SctiesSttlmSysId|String||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese005001.SettlementTransactionCondition30Choice>||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Sese005001.TradeTransactionCondition8Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcvgSdDtls),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond))|

---

## Value ISO20022.Sese005001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese005001.GenericIdentification27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Sese005001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese005001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese005001.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese005001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Sese005001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Sese005001.HoldingsPlanType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PLAR|Int32||XmlEnum("""PLAR""")|1|
||SWIP|Int32||XmlEnum("""SWIP""")|2|
||INVP|Int32||XmlEnum("""INVP""")|3|

---

## Value ISO20022.Sese005001.IdentificationSource1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Dmst|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Dmst""",Dmst,"""[A-Z]{2,2}"""),validChoice(Prtry,Dmst))|

---

## Value ISO20022.Sese005001.IdentificationType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese005001.IncomePreference2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SECU|Int32||XmlEnum("""SECU""")|1|
||CASH|Int32||XmlEnum("""CASH""")|2|

---

## Value ISO20022.Sese005001.Intermediary43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctPrsn|ISO20022.Sese005001.ContactIdentification2||XmlElement()||
|+|Role|ISO20022.Sese005001.Role4Choice||XmlElement()||
|+|Acct|ISO20022.Sese005001.Account27||XmlElement()||
|+|Id|ISO20022.Sese005001.PartyIdentification139||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctPrsn),validElement(Role),validElement(Acct),validElement(Id))|

---

## Value ISO20022.Sese005001.InvestmentAccount71


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmPtiesDtls|ISO20022.Sese005001.FundSettlementParameters16||XmlElement()||
|+|SfkpgPlc|ISO20022.Sese005001.SafekeepingPlaceFormat28Choice||XmlElement()||
|+|BnfcryCertfctnCmpltn|String||XmlElement()||
|+|IncmPref|String||XmlElement()||
|+|DmtrlsdInd|String||XmlElement()||
|+|SctiesForm|String||XmlElement()||
|+|IntrmyInf|global::System.Collections.Generic.List<ISO20022.Sese005001.Intermediary43>||XmlElement()||
|+|SubAcctDtls|ISO20022.Sese005001.SubAccount5||XmlElement()||
|+|AcctSvcr|ISO20022.Sese005001.PartyIdentification139||XmlElement()||
|+|AcctDsgnt|String||XmlElement()||
|+|AcctNm|String||XmlElement()||
|+|AcctId|String||XmlElement()||
|+|OwnrId|global::System.Collections.Generic.List<ISO20022.Sese005001.PartyIdentification139>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmPtiesDtls),validElement(SfkpgPlc),validList("""IntrmyInf""",IntrmyInf),validElement(IntrmyInf),validElement(SubAcctDtls),validElement(AcctSvcr),validList("""OwnrId""",OwnrId),validElement(OwnrId))|

---

## Enum ISO20022.Sese005001.InvestmentFundFee1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PENA|Int32||XmlEnum("""PENA""")|1|
||REGF|Int32||XmlEnum("""REGF""")|2|
||UCIC|Int32||XmlEnum("""UCIC""")|3|
||SWIT|Int32||XmlEnum("""SWIT""")|4|
||SHIP|Int32||XmlEnum("""SHIP""")|5|
||CHAR|Int32||XmlEnum("""CHAR""")|6|
||PREM|Int32||XmlEnum("""PREM""")|7|
||POST|Int32||XmlEnum("""POST""")|8|
||ADDF|Int32||XmlEnum("""ADDF""")|9|
||INIT|Int32||XmlEnum("""INIT""")|10|
||FEND|Int32||XmlEnum("""FEND""")|11|
||DLEV|Int32||XmlEnum("""DLEV""")|12|
||CBCH|Int32||XmlEnum("""CBCH""")|13|
||CDSC|Int32||XmlEnum("""CDSC""")|14|
||CDPL|Int32||XmlEnum("""CDPL""")|15|
||COMM|Int32||XmlEnum("""COMM""")|16|
||BRKF|Int32||XmlEnum("""BRKF""")|17|
||BEND|Int32||XmlEnum("""BEND""")|18|

---

## Enum ISO20022.Sese005001.InvestmentFundFee2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SPCN|Int32||XmlEnum("""SPCN""")|1|
||SHIP|Int32||XmlEnum("""SHIP""")|2|
||REGF|Int32||XmlEnum("""REGF""")|3|
||POST|Int32||XmlEnum("""POST""")|4|
||TRAN|Int32||XmlEnum("""TRAN""")|5|
||FEND|Int32||XmlEnum("""FEND""")|6|
||BEND|Int32||XmlEnum("""BEND""")|7|

---

## Enum ISO20022.Sese005001.InvestmentFundRole2Code


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

## Value ISO20022.Sese005001.MarketPracticeVersion1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nb|String||XmlElement()||
|+|Dt|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese005001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese005001.NameAndAddress4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Sese005001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Sese005001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Sese005001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Sese005001.NamePrefix1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MADM|Int32||XmlEnum("""MADM""")|1|
||MISS|Int32||XmlEnum("""MISS""")|2|
||MIST|Int32||XmlEnum("""MIST""")|3|
||DOCT|Int32||XmlEnum("""DOCT""")|4|

---

## Value ISO20022.Sese005001.OtherAmount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Sese005001.OtherAmountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Tp))|

---

## Value ISO20022.Sese005001.OtherAmountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryCd|ISO20022.Sese005001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryCd),validChoice(PrtryCd,Cd))|

---

## Enum ISO20022.Sese005001.OtherAmountType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SINT|Int32||XmlEnum("""SINT""")|1|
||PINT|Int32||XmlEnum("""PINT""")|2|

---

## Value ISO20022.Sese005001.PartyIdentification122Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese005001.NameAndAddress5||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese005001.PartyIdentification123Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese005001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese005001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese005001.PartyIdentification125Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese005001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese005001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese005001.PartyIdentification139


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Sese005001.PartyIdentification125Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Sese005001.PartyIdentification141


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese005001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese005001.DateAndDateTime2Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese005001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese005001.PartyIdentification122Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese005001.PartyIdentificationAndAccount194


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese005001.PartyTextInformation6||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese005001.DateAndDateTime2Choice||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese005001.SecuritiesAccount19||XmlElement()||
|+|AltrnId|ISO20022.Sese005001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese005001.PartyIdentification123Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese005001.PartyTextInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese005001.PartyTextInformation6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnAdr|ISO20022.Sese005001.PostalAddress1||XmlElement()||
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RegnAdr))|

---

## Enum ISO20022.Sese005001.PhysicalTransferType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHYS|Int32||XmlEnum("""PHYS""")|1|
||DEMT|Int32||XmlEnum("""DEMT""")|2|

---

## Value ISO20022.Sese005001.PostalAddress1


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

## Enum ISO20022.Sese005001.PriceMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HIST|Int32||XmlEnum("""HIST""")|1|
||FORW|Int32||XmlEnum("""FORW""")|2|

---

## Value ISO20022.Sese005001.PriceValue1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese005001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Sese005001.Quantity42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrfRate|Decimal||XmlElement()||
|+|TtlUnitsNb|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(TrfRate,TtlUnitsNb))|

---

## Value ISO20022.Sese005001.Role4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese005001.RoundingDirection2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RDWN|Int32||XmlEnum("""RDWN""")|1|
||RDUP|Int32||XmlEnum("""RDUP""")|2|

---

## Enum ISO20022.Sese005001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Sese005001.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Value ISO20022.Sese005001.SafekeepingPlaceFormat28Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Sese005001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Sese005001.SafekeepingPlaceTypeAndText6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Sese005001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese005001.SafekeepingPlaceTypeAndText6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese005001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese005001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese005001.SecurityIdentification25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPrtryId|ISO20022.Sese005001.AlternateSecurityIdentification7||XmlElement()||
|+|Cmon|String||XmlElement()||
|+|Belgn|String||XmlElement()||
|+|SCVM|String||XmlElement()||
|+|Vlrn|String||XmlElement()||
|+|Dtch|String||XmlElement()||
|+|Wrtppr|String||XmlElement()||
|+|QUICK|String||XmlElement()||
|+|CTA|String||XmlElement()||
|+|Blmbrg|String||XmlElement()||
|+|TckrSymb|String||XmlElement()||
|+|RIC|String||XmlElement()||
|+|CUSIP|String||XmlElement()||
|+|SEDOL|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPrtryId),validPattern("""Blmbrg""",Blmbrg,"""(BBG)[BCDFGHJKLMNPQRSTVWXYZ\d]{8}\d"""),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(OthrPrtryId,Cmon,Belgn,SCVM,Vlrn,Dtch,Wrtppr,QUICK,CTA,Blmbrg,TckrSymb,RIC,CUSIP,SEDOL,ISIN))|

---

## Enum ISO20022.Sese005001.SettlementDate1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WHIF|Int32||XmlEnum("""WHIF""")|1|
||ENDC|Int32||XmlEnum("""ENDC""")|2|
||ASAP|Int32||XmlEnum("""ASAP""")|3|

---

## Value ISO20022.Sese005001.SettlementParties94


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese005001.PartyIdentificationAndAccount194||XmlElement()||
|+|Pty4|ISO20022.Sese005001.PartyIdentificationAndAccount194||XmlElement()||
|+|Pty3|ISO20022.Sese005001.PartyIdentificationAndAccount194||XmlElement()||
|+|Pty2|ISO20022.Sese005001.PartyIdentificationAndAccount194||XmlElement()||
|+|Pty1|ISO20022.Sese005001.PartyIdentificationAndAccount194||XmlElement()||
|+|Dpstry|ISO20022.Sese005001.PartyIdentification141||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Sese005001.SettlementTransactionCondition11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOMC|Int32||XmlEnum("""NOMC""")|1|

---

## Value ISO20022.Sese005001.SettlementTransactionCondition30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese005001.StampDutyType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SDRN|Int32||XmlEnum("""SDRN""")|1|
||ASTD|Int32||XmlEnum("""ASTD""")|2|

---

## Value ISO20022.Sese005001.SubAccount5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Chrtc|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese005001.Tax35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxClctnDtls|ISO20022.Sese005001.TaxCalculationInformation10||XmlElement()||
|+|RcptId|ISO20022.Sese005001.PartyIdentification139||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|ApldRate|Decimal||XmlElement()||
|+|ApldAmt|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Sese005001.TaxType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxClctnDtls),validElement(RcptId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(ApldAmt),validElement(Tp))|

---

## Value ISO20022.Sese005001.Tax38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxClctnDtls|ISO20022.Sese005001.TaxCalculationInformation11||XmlElement()||
|+|RcptId|ISO20022.Sese005001.PartyIdentification139||XmlElement()||
|+|XmptnRsn|ISO20022.Sese005001.ExemptionReason1Choice||XmlElement()||
|+|XmptnInd|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Amt|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
|+|Bsis|ISO20022.Sese005001.TaxBasis1Choice||XmlElement()||
|+|Tp|ISO20022.Sese005001.TaxType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxClctnDtls),validElement(RcptId),validElement(XmptnRsn),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Amt),validElement(Bsis),validElement(Tp))|

---

## Value ISO20022.Sese005001.TaxBasis1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese005001.TaxCalculationInformation10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxblAmt|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
|+|Bsis|ISO20022.Sese005001.TaxBasis1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxblAmt),validElement(Bsis))|

---

## Value ISO20022.Sese005001.TaxCalculationInformation11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxblAmt|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
|+|Bsis|ISO20022.Sese005001.TaxBasis1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxblAmt),validElement(Bsis))|

---

## Enum ISO20022.Sese005001.TaxExemptReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EIOP|Int32||XmlEnum("""EIOP""")|1|
||EIFP|Int32||XmlEnum("""EIFP""")|2|
||RCIP|Int32||XmlEnum("""RCIP""")|3|
||RCRF|Int32||XmlEnum("""RCRF""")|4|
||RIAN|Int32||XmlEnum("""RIAN""")|5|
||RIRA|Int32||XmlEnum("""RIRA""")|6|
||E457X|Int32||XmlEnum("""457X""")|7|
||E403B|Int32||XmlEnum("""403B""")|8|
||SIRA|Int32||XmlEnum("""SIRA""")|9|
||E401K|Int32||XmlEnum("""401K""")|10|
||PFSP|Int32||XmlEnum("""PFSP""")|11|
||KEOG|Int32||XmlEnum("""KEOG""")|12|
||IRAR|Int32||XmlEnum("""IRAR""")|13|
||IRAC|Int32||XmlEnum("""IRAC""")|14|
||DECP|Int32||XmlEnum("""DECP""")|15|
||NFQP|Int32||XmlEnum("""NFQP""")|16|
||NFPI|Int32||XmlEnum("""NFPI""")|17|
||ECYE|Int32||XmlEnum("""ECYE""")|18|
||EPRY|Int32||XmlEnum("""EPRY""")|19|
||EMCY|Int32||XmlEnum("""EMCY""")|20|
||EMPY|Int32||XmlEnum("""EMPY""")|21|
||ASTR|Int32||XmlEnum("""ASTR""")|22|
||PRYP|Int32||XmlEnum("""PRYP""")|23|
||CUYP|Int32||XmlEnum("""CUYP""")|24|
||IISA|Int32||XmlEnum("""IISA""")|25|
||SISA|Int32||XmlEnum("""SISA""")|26|
||MISA|Int32||XmlEnum("""MISA""")|27|
||MASA|Int32||XmlEnum("""MASA""")|28|
||NONE|Int32||XmlEnum("""NONE""")|29|

---

## Enum ISO20022.Sese005001.TaxType16Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||KAPA|Int32||XmlEnum("""KAPA""")|1|
||NKAP|Int32||XmlEnum("""NKAP""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||VATA|Int32||XmlEnum("""VATA""")|4|
||TRAX|Int32||XmlEnum("""TRAX""")|5|
||TRAN|Int32||XmlEnum("""TRAN""")|6|
||STEX|Int32||XmlEnum("""STEX""")|7|
||STAT|Int32||XmlEnum("""STAT""")|8|
||STAM|Int32||XmlEnum("""STAM""")|9|
||PROV|Int32||XmlEnum("""PROV""")|10|
||NATI|Int32||XmlEnum("""NATI""")|11|
||LOCL|Int32||XmlEnum("""LOCL""")|12|
||LEVY|Int32||XmlEnum("""LEVY""")|13|
||EUTR|Int32||XmlEnum("""EUTR""")|14|
||CTAX|Int32||XmlEnum("""CTAX""")|15|
||COAX|Int32||XmlEnum("""COAX""")|16|

---

## Enum ISO20022.Sese005001.TaxType17Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ZWIS|Int32||XmlEnum("""ZWIS""")|1|
||AKT2|Int32||XmlEnum("""AKT2""")|2|
||AKT1|Int32||XmlEnum("""AKT1""")|3|
||EUTR|Int32||XmlEnum("""EUTR""")|4|
||COAX|Int32||XmlEnum("""COAX""")|5|
||GIFT|Int32||XmlEnum("""GIFT""")|6|
||CTAX|Int32||XmlEnum("""CTAX""")|7|
||SOSU|Int32||XmlEnum("""SOSU""")|8|
||INHT|Int32||XmlEnum("""INHT""")|9|
||WTAX|Int32||XmlEnum("""WTAX""")|10|
||STAM|Int32||XmlEnum("""STAM""")|11|
||INPO|Int32||XmlEnum("""INPO""")|12|
||NKAP|Int32||XmlEnum("""NKAP""")|13|
||KAPA|Int32||XmlEnum("""KAPA""")|14|
||WITH|Int32||XmlEnum("""WITH""")|15|
||STAT|Int32||XmlEnum("""STAT""")|16|
||NATI|Int32||XmlEnum("""NATI""")|17|
||PROV|Int32||XmlEnum("""PROV""")|18|

---

## Value ISO20022.Sese005001.TaxType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese005001.TaxType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese005001.TaxableIncomePerShareCalculated2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese005001.TaxableIncomePerShareCalculated2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||TSIN|Int32||XmlEnum("""TSIN""")|2|
||TSIY|Int32||XmlEnum("""TSIY""")|3|

---

## Enum ISO20022.Sese005001.TaxationBasis2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PERU|Int32||XmlEnum("""PERU""")|1|
||FLAT|Int32||XmlEnum("""FLAT""")|2|

---

## Enum ISO20022.Sese005001.TaxationBasis5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PERU|Int32||XmlEnum("""PERU""")|1|
||NAVP|Int32||XmlEnum("""NAVP""")|2|
||NEAM|Int32||XmlEnum("""NEAM""")|3|
||GRAM|Int32||XmlEnum("""GRAM""")|4|
||FLAT|Int32||XmlEnum("""FLAT""")|5|

---

## Value ISO20022.Sese005001.TotalFeesAndTaxes42


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndvTax|global::System.Collections.Generic.List<ISO20022.Sese005001.Tax35>||XmlElement()||
|+|IndvFee|global::System.Collections.Generic.List<ISO20022.Sese005001.Fee5>||XmlElement()||
|+|ComrclAgrmtRef|String||XmlElement()||
|+|TtlTaxs|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlFees|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlOvrhdApld|ISO20022.Sese005001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""IndvTax""",IndvTax),validElement(IndvTax),validList("""IndvFee""",IndvFee),validElement(IndvFee),validElement(TtlTaxs),validElement(TtlFees),validElement(TtlOvrhdApld))|

---

## Enum ISO20022.Sese005001.TradeTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CCPN|Int32||XmlEnum("""CCPN""")|1|
||XCPN|Int32||XmlEnum("""XCPN""")|2|

---

## Value ISO20022.Sese005001.TradeTransactionCondition8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese005001.Transfer36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrfExpnssPmtTp|ISO20022.Sese005001.ChargePaymentMethod1Choice||XmlElement()||
|+|NonStdSttlmInf|String||XmlElement()||
|+|OwnAcctTrfInd|String||XmlElement()||
|+|TrfCcy|String||XmlElement()||
|+|AvrgPric|ISO20022.Sese005001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|OrgnlCost|ISO20022.Sese005001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rndg|String||XmlElement()||
|+|UnitsDtls|global::System.Collections.Generic.List<ISO20022.Sese005001.Unit12>||XmlElement()||
|+|Qty|ISO20022.Sese005001.Quantity42Choice||XmlElement()||
|+|FinInstrmDtls|ISO20022.Sese005001.FinancialInstrument88||XmlElement()||
|+|HldgsPlanTp|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TrfRsn|ISO20022.Sese005001.TransferReason1Choice||XmlElement()||
|+|TrfOrdrDtForm|DateTime||XmlElement()||
|+|ReqdSttlmDt|DateTime||XmlElement()||
|+|ReqdTrfDt|ISO20022.Sese005001.DateFormat1Choice||XmlElement()||
|+|BizFlowTp|String||XmlElement()||
|+|CtrPtyRef|ISO20022.Sese005001.AdditionalReference10||XmlElement()||
|+|ClntRef|ISO20022.Sese005001.AdditionalReference10||XmlElement()||
|+|TrfRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrfExpnssPmtTp),validPattern("""TrfCcy""",TrfCcy,"""[A-Z]{3,3}"""),validElement(AvrgPric),validElement(OrgnlCost),validList("""UnitsDtls""",UnitsDtls),validElement(UnitsDtls),validElement(Qty),validElement(FinInstrmDtls),validListMax("""HldgsPlanTp""",HldgsPlanTp,3),validElement(TrfRsn),validElement(ReqdTrfDt),validElement(CtrPtyRef),validElement(ClntRef))|

---

## Enum ISO20022.Sese005001.TransferInFunction1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INST|Int32||XmlEnum("""INST""")|1|
||ADRE|Int32||XmlEnum("""ADRE""")|2|

---

## Aspect ISO20022.Sese005001.TransferInInstructionV09


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xtnsn|global::System.Collections.Generic.List<ISO20022.Sese005001.Extension1>||XmlElement()||
|+|CpyDtls|ISO20022.Sese005001.CopyInformation5||XmlElement()||
|+|MktPrctcVrsn|ISO20022.Sese005001.MarketPracticeVersion1||XmlElement()||
|+|SttlmDtls|ISO20022.Sese005001.DeliverInformation21||XmlElement()||
|+|AcctDtls|ISO20022.Sese005001.InvestmentAccount71||XmlElement()||
|+|TrfDtls|global::System.Collections.Generic.List<ISO20022.Sese005001.Transfer36>||XmlElement()||
|+|MstrRef|String||XmlElement()||
|+|Fctn|String||XmlElement()||
|+|RltdRef|ISO20022.Sese005001.AdditionalReference10||XmlElement()||
|+|PrvsRef|ISO20022.Sese005001.AdditionalReference10||XmlElement()||
|+|PoolRef|ISO20022.Sese005001.AdditionalReference11||XmlElement()||
|+|MsgId|ISO20022.Sese005001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(CpyDtls),validElement(MktPrctcVrsn),validElement(SttlmDtls),validElement(AcctDtls),validRequired("""TrfDtls""",TrfDtls),validList("""TrfDtls""",TrfDtls),validElement(TrfDtls),validElement(RltdRef),validElement(PrvsRef),validElement(PoolRef),validElement(MsgId))|

---

## Value ISO20022.Sese005001.TransferReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification27||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese005001.TransferReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAN|Int32||XmlEnum("""TRAN""")|1|
||TRAF|Int32||XmlEnum("""TRAF""")|2|
||TRPE|Int32||XmlEnum("""TRPE""")|3|
||TTDT|Int32||XmlEnum("""TTDT""")|4|
||TPLD|Int32||XmlEnum("""TPLD""")|5|
||TRAG|Int32||XmlEnum("""TRAG""")|6|
||TRAI|Int32||XmlEnum("""TRAI""")|7|
||TRAO|Int32||XmlEnum("""TRAO""")|8|
||TRAT|Int32||XmlEnum("""TRAT""")|9|
||TRAC|Int32||XmlEnum("""TRAC""")|10|
||TRAU|Int32||XmlEnum("""TRAU""")|11|

---

## Enum ISO20022.Sese005001.TypeOfIdentification1Code


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

## Enum ISO20022.Sese005001.TypeOfPrice10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACTU|Int32||XmlEnum("""ACTU""")|1|
||DDVR|Int32||XmlEnum("""DDVR""")|2|
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

## Value ISO20022.Sese005001.TypeOfPrice46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese005001.UKTaxGroupUnit1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GRP2|Int32||XmlEnum("""GRP2""")|1|
||GRP1|Int32||XmlEnum("""GRP1""")|2|

---

## Value ISO20022.Sese005001.Unit12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrAmt|global::System.Collections.Generic.List<ISO20022.Sese005001.OtherAmount1>||XmlElement()||
|+|TxOvrhd|ISO20022.Sese005001.TotalFeesAndTaxes42||XmlElement()||
|+|PricDtls|ISO20022.Sese005001.UnitPrice23||XmlElement()||
|+|Ref|String||XmlElement()||
|+|Grp1Or2Units|String||XmlElement()||
|+|CertNb|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AcqstnDt|DateTime||XmlElement()||
|+|OrdrDt|DateTime||XmlElement()||
|+|UnitsNb|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrAmt""",OthrAmt),validElement(OthrAmt),validElement(TxOvrhd),validElement(PricDtls))|

---

## Value ISO20022.Sese005001.UnitPrice23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxblIncmPerShrClctd|ISO20022.Sese005001.TaxableIncomePerShareCalculated2Choice||XmlElement()||
|+|TaxblIncmPerShr|ISO20022.Sese005001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|AcrdIntrstNAV|ISO20022.Sese005001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|PricMtd|String||XmlElement()||
|+|Val|ISO20022.Sese005001.PriceValue1||XmlElement()||
|+|Tp|ISO20022.Sese005001.TypeOfPrice46Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxblIncmPerShrClctd),validElement(TaxblIncmPerShr),validElement(AcrdIntrstNAV),validElement(Val),validElement(Tp))|

---

## Enum ISO20022.Sese005001.WaivingInstruction1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WIUN|Int32||XmlEnum("""WIUN""")|1|
||WICA|Int32||XmlEnum("""WICA""")|2|

---

## Value ISO20022.Sese005001.WaivingInstruction2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese005001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

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

