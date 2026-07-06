# sese.013.001.11
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese013001.Account27 {
        + AcctSvcr  : ISO20022.Sese013001.PartyIdentification139
        + Id  : String
    }
    ISO20022.Sese013001.Account27 *-- ISO20022.Sese013001.PartyIdentification139
    class ISO20022.Sese013001.Account28 {
        + SubAcctDtls  : ISO20022.Sese013001.SubAccount5
        + Svcr  : ISO20022.Sese013001.PartyIdentification132
        + AcctNm  : String
        + Dsgnt  : String
        + AcctId  : String
        + OwnrId  : ISO20022.Sese013001.PartyIdentification132
    }
    ISO20022.Sese013001.Account28 *-- ISO20022.Sese013001.SubAccount5
    ISO20022.Sese013001.Account28 *-- ISO20022.Sese013001.PartyIdentification132
    ISO20022.Sese013001.Account28 *-- ISO20022.Sese013001.PartyIdentification132
    class ISO20022.Sese013001.AccountIdentificationAndName6 {
        + Othr  : ISO20022.Sese013001.GenericAccountIdentification1
        + IBAN  : String
        + Nm  : String
    }
    ISO20022.Sese013001.AccountIdentificationAndName6 *-- ISO20022.Sese013001.GenericAccountIdentification1
    class ISO20022.Sese013001.AccountOwnershipType6Code {
        USUF = 1
        UNCO = 2
        SIGL = 3
        RGIC = 4
        OWNR = 5
        ONIS = 6
        NFPO = 7
        NOMI = 8
        LIPA = 9
        LLCO = 10
        JOIN = 11
        COMO = 12
        JOIT = 13
        GOVO = 14
        TRUS = 15
        PART = 16
        EURE = 17
        ENTR = 18
        CUST = 19
        CORP = 20
        BOWN = 21
    }
    class ISO20022.Sese013001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese013001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese013001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese013001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese013001.AdditionalInformation15 {
        + InfVal  : String
        + InfTp  : ISO20022.Sese013001.GenericIdentification36
    }
    ISO20022.Sese013001.AdditionalInformation15 *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.AdditionalReference10 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Sese013001.PartyIdentification139
        + Ref  : String
    }
    ISO20022.Sese013001.AdditionalReference10 *-- ISO20022.Sese013001.PartyIdentification139
    class ISO20022.Sese013001.AdditionalReference11 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Sese013001.PartyIdentification139
        + Ref  : String
    }
    ISO20022.Sese013001.AdditionalReference11 *-- ISO20022.Sese013001.PartyIdentification139
    class ISO20022.Sese013001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Sese013001.AllOtherCash1 {
        + Ccy  : String
        + Ind  : String
    }
    class ISO20022.Sese013001.AlternatePartyIdentification7 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Sese013001.IdentificationType42Choice
    }
    ISO20022.Sese013001.AlternatePartyIdentification7 *-- ISO20022.Sese013001.IdentificationType42Choice
    class ISO20022.Sese013001.AlternateSecurityIdentification7 {
        + IdSrc  : ISO20022.Sese013001.IdentificationSource1Choice
        + Id  : String
    }
    ISO20022.Sese013001.AlternateSecurityIdentification7 *-- ISO20022.Sese013001.IdentificationSource1Choice
    class ISO20022.Sese013001.BonusWithdrawal2 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese013001.AdditionalInformation15~
        + Ref  : String
        + Outsdng  : String
        + UclmdAmt  : ISO20022.Sese013001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rsn  : ISO20022.Sese013001.WithdrawalReason1Choice
        + Amt  : ISO20022.Sese013001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + TpOfAmt  : ISO20022.Sese013001.TypeOfAmount1Choice
    }
    ISO20022.Sese013001.BonusWithdrawal2 *-- ISO20022.Sese013001.AdditionalInformation15
    ISO20022.Sese013001.BonusWithdrawal2 *-- ISO20022.Sese013001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    ISO20022.Sese013001.BonusWithdrawal2 *-- ISO20022.Sese013001.WithdrawalReason1Choice
    ISO20022.Sese013001.BonusWithdrawal2 *-- ISO20022.Sese013001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    ISO20022.Sese013001.BonusWithdrawal2 *-- ISO20022.Sese013001.TypeOfAmount1Choice
    class ISO20022.Sese013001.BranchData2 {
        + PstlAdr  : ISO20022.Sese013001.PostalAddress6
        + Nm  : String
        + Id  : String
    }
    ISO20022.Sese013001.BranchData2 *-- ISO20022.Sese013001.PostalAddress6
    class ISO20022.Sese013001.BusinessFlowType1Code {
        DLPR = 1
        SLRP = 2
        SLDP = 3
    }
    class ISO20022.Sese013001.CashAll1 {
        + Ccy  : String
        + Ind  : String
    }
    class ISO20022.Sese013001.CashAsset3 {
        + AddtlInf  : ISO20022.Sese013001.AdditionalInformation15
        + TrfCcy  : String
        + HldgCcy  : String
        + CshAsstTp  : ISO20022.Sese013001.CashAssetType1Choice
    }
    ISO20022.Sese013001.CashAsset3 *-- ISO20022.Sese013001.AdditionalInformation15
    ISO20022.Sese013001.CashAsset3 *-- ISO20022.Sese013001.CashAssetType1Choice
    class ISO20022.Sese013001.CashAssetType1Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese013001.CashAssetType1Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.CashAssetType1Code {
        CSH1 = 1
        CSH2 = 2
    }
    class ISO20022.Sese013001.ChargeBasis2Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese013001.ChargeBasis2Choice *-- ISO20022.Sese013001.GenericIdentification47
    class ISO20022.Sese013001.ChargeOrCommissionDiscount1 {
        + Bsis  : ISO20022.Sese013001.WaivingInstruction2Choice
        + Rate  : Decimal
        + Amt  : ISO20022.Sese013001.ActiveCurrencyAndAmount
    }
    ISO20022.Sese013001.ChargeOrCommissionDiscount1 *-- ISO20022.Sese013001.WaivingInstruction2Choice
    ISO20022.Sese013001.ChargeOrCommissionDiscount1 *-- ISO20022.Sese013001.ActiveCurrencyAndAmount
    class ISO20022.Sese013001.ChargeType5Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese013001.ChargeType5Choice *-- ISO20022.Sese013001.GenericIdentification47
    class ISO20022.Sese013001.ClassificationType32Choice {
        + AltrnClssfctn  : ISO20022.Sese013001.GenericIdentification36
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Sese013001.ClassificationType32Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.ClearingSystemMemberIdentification2Choice {
        + OthrClrCdId  : String
        + PLKNR  : String
        + GRHEBIC  : String
        + INIFSC  : String
        + AUBSBs  : String
        + AUBSBx  : String
        + HKNCC  : String
        + ZANCC  : String
        + ESNCC  : String
        + DEBLZ  : String
        + CHSIC  : String
        + CACPA  : String
        + ATBLZ  : String
        + ITNCC  : String
        + RUCB  : String
        + PTNCC  : String
        + USFW  : String
        + CHBC  : String
        + USCH  : String
        + GBSC  : String
        + IENSC  : String
        + NZNCC  : String
        + USCHU  : String
    }
    class ISO20022.Sese013001.ClearingSystemMemberIdentification4Choice {
        + AUBSBs  : String
        + AUBSBx  : String
        + HKNCC  : String
        + ZANCC  : String
        + ESNCC  : String
        + DEBLZ  : String
        + CHSIC  : String
        + CACPA  : String
        + ATBLZ  : String
        + ITNCC  : String
        + RUCB  : String
        + PTNCC  : String
        + USFW  : String
        + CHBC  : String
        + USCH  : String
        + GBSC  : String
        + IENSC  : String
        + NZNCC  : String
        + USCHU  : String
    }
    class ISO20022.Sese013001.ContactIdentification2 {
        + EmailAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + GvnNm  : String
        + NmPrfx  : String
    }
    class ISO20022.Sese013001.Conversion1 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese013001.AdditionalInformation15~
        + TrgtScty  : ISO20022.Sese013001.FinancialInstrumentIdentification1
    }
    ISO20022.Sese013001.Conversion1 *-- ISO20022.Sese013001.AdditionalInformation15
    ISO20022.Sese013001.Conversion1 *-- ISO20022.Sese013001.FinancialInstrumentIdentification1
    class ISO20022.Sese013001.CreditTransfer9 {
        + CdtrAcct  : ISO20022.Sese013001.AccountIdentificationAndName6
        + Cdtr  : ISO20022.Sese013001.PartyIdentification132
        + CdtrAgtAcct  : ISO20022.Sese013001.AccountIdentificationAndName6
        + CdtrAgt  : ISO20022.Sese013001.FinancialInstitutionIdentification16
        + IntrmyAgt2Acct  : ISO20022.Sese013001.AccountIdentificationAndName6
        + IntrmyAgt2  : ISO20022.Sese013001.FinancialInstitutionIdentification16
        + IntrmyAgt1Acct  : ISO20022.Sese013001.AccountIdentificationAndName6
        + IntrmyAgt1  : ISO20022.Sese013001.FinancialInstitutionIdentification16
        + DbtrAgtAcct  : ISO20022.Sese013001.AccountIdentificationAndName6
        + DbtrAgt  : ISO20022.Sese013001.FinancialInstitutionIdentification16
        + DbtrAcct  : ISO20022.Sese013001.AccountIdentificationAndName6
        + Dbtr  : ISO20022.Sese013001.PartyIdentification132
    }
    ISO20022.Sese013001.CreditTransfer9 *-- ISO20022.Sese013001.AccountIdentificationAndName6
    ISO20022.Sese013001.CreditTransfer9 *-- ISO20022.Sese013001.PartyIdentification132
    ISO20022.Sese013001.CreditTransfer9 *-- ISO20022.Sese013001.AccountIdentificationAndName6
    ISO20022.Sese013001.CreditTransfer9 *-- ISO20022.Sese013001.FinancialInstitutionIdentification16
    ISO20022.Sese013001.CreditTransfer9 *-- ISO20022.Sese013001.AccountIdentificationAndName6
    ISO20022.Sese013001.CreditTransfer9 *-- ISO20022.Sese013001.FinancialInstitutionIdentification16
    ISO20022.Sese013001.CreditTransfer9 *-- ISO20022.Sese013001.AccountIdentificationAndName6
    ISO20022.Sese013001.CreditTransfer9 *-- ISO20022.Sese013001.FinancialInstitutionIdentification16
    ISO20022.Sese013001.CreditTransfer9 *-- ISO20022.Sese013001.AccountIdentificationAndName6
    ISO20022.Sese013001.CreditTransfer9 *-- ISO20022.Sese013001.FinancialInstitutionIdentification16
    ISO20022.Sese013001.CreditTransfer9 *-- ISO20022.Sese013001.AccountIdentificationAndName6
    ISO20022.Sese013001.CreditTransfer9 *-- ISO20022.Sese013001.PartyIdentification132
    class ISO20022.Sese013001.Crystallisation2 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese013001.AdditionalInformation15~
        + UcrstllsdAmt  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
        + CrstllsdAmt  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
        + UcrstllsdUnitsNb  : Decimal
        + CrstllsdUnitsNb  : Decimal
        + TrchId  : String
    }
    ISO20022.Sese013001.Crystallisation2 *-- ISO20022.Sese013001.AdditionalInformation15
    ISO20022.Sese013001.Crystallisation2 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese013001.Crystallisation2 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Sese013001.DateAndAmount2 {
        + Amt  : ISO20022.Sese013001.ActiveOrHistoricCurrencyAndAmount
        + Dt  : DateTime
    }
    ISO20022.Sese013001.DateAndAmount2 *-- ISO20022.Sese013001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese013001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese013001.DateQuarter1Choice {
        + Prd  : String
        + Dt  : DateTime
    }
    class ISO20022.Sese013001.DrawdownStatus1Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese013001.DrawdownStatus1Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.DrawdownStatus1Code {
        PART = 1
        NONE = 2
        FULL = 3
    }
    class ISO20022.Sese013001.DrawdownType2Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese013001.DrawdownType2Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.DrawdownType2Code {
        FLEX = 1
        CAPP = 2
        BOTH = 3
    }
    class ISO20022.Sese013001.Extension1 {
        + Txt  : String
        + PlcAndNm  : String
    }
    class ISO20022.Sese013001.Fee5 {
        + InftvInd  : String
        + RcptId  : ISO20022.Sese013001.PartyIdentification139
        + NonStdSLARef  : String
        + ApldRate  : Decimal
        + ApldAmt  : ISO20022.Sese013001.ActiveCurrencyAndAmount
        + DscntDtls  : ISO20022.Sese013001.ChargeOrCommissionDiscount1
        + StdRate  : Decimal
        + StdAmt  : ISO20022.Sese013001.ActiveCurrencyAndAmount
        + Bsis  : ISO20022.Sese013001.ChargeBasis2Choice
        + Tp  : ISO20022.Sese013001.ChargeType5Choice
    }
    ISO20022.Sese013001.Fee5 *-- ISO20022.Sese013001.PartyIdentification139
    ISO20022.Sese013001.Fee5 *-- ISO20022.Sese013001.ActiveCurrencyAndAmount
    ISO20022.Sese013001.Fee5 *-- ISO20022.Sese013001.ChargeOrCommissionDiscount1
    ISO20022.Sese013001.Fee5 *-- ISO20022.Sese013001.ActiveCurrencyAndAmount
    ISO20022.Sese013001.Fee5 *-- ISO20022.Sese013001.ChargeBasis2Choice
    ISO20022.Sese013001.Fee5 *-- ISO20022.Sese013001.ChargeType5Choice
    class ISO20022.Sese013001.FinancialInstitutionIdentification16 {
        + BrnchId  : ISO20022.Sese013001.BranchData2
        + PrtryId  : String
        + LEI  : String
        + NmAndAdr  : ISO20022.Sese013001.NameAndAddress5
        + ClrSysMmbId  : ISO20022.Sese013001.ClearingSystemMemberIdentification4Choice
        + BICFI  : String
    }
    ISO20022.Sese013001.FinancialInstitutionIdentification16 *-- ISO20022.Sese013001.BranchData2
    ISO20022.Sese013001.FinancialInstitutionIdentification16 *-- ISO20022.Sese013001.NameAndAddress5
    ISO20022.Sese013001.FinancialInstitutionIdentification16 *-- ISO20022.Sese013001.ClearingSystemMemberIdentification4Choice
    class ISO20022.Sese013001.FinancialInstrument100 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese013001.AdditionalInformation15~
        + TrfRsltsInChngOfBnfclOwnr  : String
        + AsstsHeldInOwnNm  : String
        + SttlmPtiesDtls  : ISO20022.Sese013001.FundSettlementParameters17
        + TaxValtnPt  : ISO20022.Sese013001.Tax36
        + CrstllstnDtls  : global::System.Collections.Generic.List~ISO20022.Sese013001.Crystallisation2~
        + PmtDtls  : ISO20022.Sese013001.PaymentInstrument14
        + FctvSttlmDt  : ISO20022.Sese013001.DateAndDateTime2Choice
        + FctvTrfDt  : ISO20022.Sese013001.DateAndDateTime2Choice
        + ReqdSttlmDt  : DateTime
        + ReqdTradDt  : DateTime
        + IntrmyInf  : global::System.Collections.Generic.List~ISO20022.Sese013001.Intermediary43~
        + Trfr  : ISO20022.Sese013001.Account28
        + TrfeeAcct  : ISO20022.Sese013001.Account28
        + LatstValtn  : ISO20022.Sese013001.DateAndAmount2
        + OrgnlCost  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
        + TtlBookVal  : ISO20022.Sese013001.DateAndAmount2
        + TrfCcy  : String
        + AvrgAcqstnPric  : ISO20022.Sese013001.ActiveCurrencyAndAmount
        + BizFlowTp  : String
        + CtrPtyRef  : ISO20022.Sese013001.AdditionalReference10
        + ClntRef  : ISO20022.Sese013001.AdditionalReference10
        + UnitsDtls  : global::System.Collections.Generic.List~ISO20022.Sese013001.Unit11~
        + Convs  : ISO20022.Sese013001.Conversion1
        + NotAvlbl  : String
        + AddtlAsst  : String
        + TrfTp  : ISO20022.Sese013001.TransferType2Choice
        + OrgnlPctgInstd  : Decimal
        + PrtlInstdQty  : String
        + Qty  : ISO20022.Sese013001.Quantity47
        + Instrm  : ISO20022.Sese013001.FinancialInstrument63Choice
        + LineId  : String
    }
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.AdditionalInformation15
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.FundSettlementParameters17
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.Tax36
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.Crystallisation2
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.PaymentInstrument14
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.DateAndDateTime2Choice
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.DateAndDateTime2Choice
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.Intermediary43
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.Account28
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.Account28
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.DateAndAmount2
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.DateAndAmount2
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.ActiveCurrencyAndAmount
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.AdditionalReference10
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.AdditionalReference10
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.Unit11
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.Conversion1
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.TransferType2Choice
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.Quantity47
    ISO20022.Sese013001.FinancialInstrument100 *-- ISO20022.Sese013001.FinancialInstrument63Choice
    class ISO20022.Sese013001.FinancialInstrument63Choice {
        + OthrAsst  : ISO20022.Sese013001.OtherAsset2
        + CshAsst  : ISO20022.Sese013001.CashAsset3
        + Scty  : ISO20022.Sese013001.FinancialInstrumentIdentification2
    }
    ISO20022.Sese013001.FinancialInstrument63Choice *-- ISO20022.Sese013001.OtherAsset2
    ISO20022.Sese013001.FinancialInstrument63Choice *-- ISO20022.Sese013001.CashAsset3
    ISO20022.Sese013001.FinancialInstrument63Choice *-- ISO20022.Sese013001.FinancialInstrumentIdentification2
    class ISO20022.Sese013001.FinancialInstrumentIdentification1 {
        + ShrtNm  : String
        + Nm  : String
        + Id  : ISO20022.Sese013001.SecurityIdentification25Choice
    }
    ISO20022.Sese013001.FinancialInstrumentIdentification1 *-- ISO20022.Sese013001.SecurityIdentification25Choice
    class ISO20022.Sese013001.FinancialInstrumentIdentification2 {
        + ClssfctnTp  : ISO20022.Sese013001.ClassificationType32Choice
        + ShrtNm  : String
        + Nm  : String
        + Id  : ISO20022.Sese013001.SecurityIdentification25Choice
    }
    ISO20022.Sese013001.FinancialInstrumentIdentification2 *-- ISO20022.Sese013001.ClassificationType32Choice
    ISO20022.Sese013001.FinancialInstrumentIdentification2 *-- ISO20022.Sese013001.SecurityIdentification25Choice
    class ISO20022.Sese013001.FundPortfolio7Choice {
        + Pnsn  : ISO20022.Sese013001.Pension5
        + GnlInvstmt  : ISO20022.Sese013001.GeneralInvestment2
        + TaxEffcntPdct  : ISO20022.Sese013001.TaxEfficientProduct7
    }
    ISO20022.Sese013001.FundPortfolio7Choice *-- ISO20022.Sese013001.Pension5
    ISO20022.Sese013001.FundPortfolio7Choice *-- ISO20022.Sese013001.GeneralInvestment2
    ISO20022.Sese013001.FundPortfolio7Choice *-- ISO20022.Sese013001.TaxEfficientProduct7
    class ISO20022.Sese013001.FundSettlementParameters17 {
        + DlvrgSdDtls  : ISO20022.Sese013001.SettlementParties94
        + RcvgSdDtls  : ISO20022.Sese013001.SettlementParties94
        + SctiesSttlmSysId  : String
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese013001.SettlementTransactionCondition30Choice~
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Sese013001.TradeTransactionCondition8Choice~
        + SfkpgPlc  : ISO20022.Sese013001.SafekeepingPlaceFormat28Choice
    }
    ISO20022.Sese013001.FundSettlementParameters17 *-- ISO20022.Sese013001.SettlementParties94
    ISO20022.Sese013001.FundSettlementParameters17 *-- ISO20022.Sese013001.SettlementParties94
    ISO20022.Sese013001.FundSettlementParameters17 *-- ISO20022.Sese013001.SettlementTransactionCondition30Choice
    ISO20022.Sese013001.FundSettlementParameters17 *-- ISO20022.Sese013001.TradeTransactionCondition8Choice
    ISO20022.Sese013001.FundSettlementParameters17 *-- ISO20022.Sese013001.SafekeepingPlaceFormat28Choice
    class ISO20022.Sese013001.GenderCode {
        FEMA = 1
        MALE = 2
    }
    class ISO20022.Sese013001.GeneralInvestment2 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese013001.AdditionalInformation15~
        + EstmtdVal  : ISO20022.Sese013001.DateAndAmount2
        + CurInvstmtAmt  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
        + OwnrshTp  : String
        + Tp  : ISO20022.Sese013001.GeneralInvestmentAccountType2Choice
    }
    ISO20022.Sese013001.GeneralInvestment2 *-- ISO20022.Sese013001.AdditionalInformation15
    ISO20022.Sese013001.GeneralInvestment2 *-- ISO20022.Sese013001.DateAndAmount2
    ISO20022.Sese013001.GeneralInvestment2 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese013001.GeneralInvestment2 *-- ISO20022.Sese013001.GeneralInvestmentAccountType2Choice
    class ISO20022.Sese013001.GeneralInvestmentAccountType2Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese013001.GeneralInvestmentAccountType2Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.GeneralInvestmentAccountType2Code {
        EQUI = 1
        ANYY = 2
    }
    class ISO20022.Sese013001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Sese013001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Sese013001.GenericAccountIdentification1 *-- ISO20022.Sese013001.AccountSchemeName1Choice
    class ISO20022.Sese013001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Sese013001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese013001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese013001.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese013001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Sese013001.GenericIdentification30
    }
    ISO20022.Sese013001.GenericIdentification78 *-- ISO20022.Sese013001.GenericIdentification30
    class ISO20022.Sese013001.HolderType1Code {
        TFOR = 1
        TFEE = 2
    }
    class ISO20022.Sese013001.IdentificationSource1Choice {
        + Prtry  : String
        + Dmst  : String
    }
    class ISO20022.Sese013001.IdentificationType42Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese013001.IdentificationType42Choice *-- ISO20022.Sese013001.GenericIdentification30
    class ISO20022.Sese013001.IndividualPerson8 {
        + IndvInvstrAdr  : ISO20022.Sese013001.PostalAddress1
        + SclSctyNb  : String
        + BirthDt  : DateTime
        + Gndr  : String
        + NmSfx  : String
        + NmPrfx  : String
        + GvnNm  : String
        + Nm  : String
    }
    ISO20022.Sese013001.IndividualPerson8 *-- ISO20022.Sese013001.PostalAddress1
    class ISO20022.Sese013001.InnovativeFinance1 {
        + Inf  : String
        + Tp  : ISO20022.Sese013001.GenericIdentification36
    }
    ISO20022.Sese013001.InnovativeFinance1 *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.Intermediary43 {
        + CtctPrsn  : ISO20022.Sese013001.ContactIdentification2
        + Role  : ISO20022.Sese013001.Role4Choice
        + Acct  : ISO20022.Sese013001.Account27
        + Id  : ISO20022.Sese013001.PartyIdentification139
    }
    ISO20022.Sese013001.Intermediary43 *-- ISO20022.Sese013001.ContactIdentification2
    ISO20022.Sese013001.Intermediary43 *-- ISO20022.Sese013001.Role4Choice
    ISO20022.Sese013001.Intermediary43 *-- ISO20022.Sese013001.Account27
    ISO20022.Sese013001.Intermediary43 *-- ISO20022.Sese013001.PartyIdentification139
    class ISO20022.Sese013001.InvestmentAccount69 {
        + Svcr  : ISO20022.Sese013001.PartyIdentification132
        + AcctNm  : String
        + Dsgnt  : String
        + Id  : String
    }
    ISO20022.Sese013001.InvestmentAccount69 *-- ISO20022.Sese013001.PartyIdentification132
    class ISO20022.Sese013001.InvestmentFundFee1Code {
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
    class ISO20022.Sese013001.InvestmentFundRole2Code {
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
    class ISO20022.Sese013001.LumpSumType1Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese013001.LumpSumType1Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.LumpSumType1Code {
        UFPL = 1
        PCLS = 2
        DEAB = 3
    }
    class ISO20022.Sese013001.MarketPracticeVersion1 {
        + Nb  : String
        + Dt  : String
        + Nm  : String
    }
    class ISO20022.Sese013001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Sese013001.MoneyPurchaseAnnualAllowance1 {
        + TrggrdDt  : DateTime
        + Trggrd  : String
    }
    class ISO20022.Sese013001.NameAndAddress5 {
        + Adr  : ISO20022.Sese013001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Sese013001.NameAndAddress5 *-- ISO20022.Sese013001.PostalAddress1
    class ISO20022.Sese013001.NamePrefix1Code {
        MADM = 1
        MISS = 2
        MIST = 3
        DOCT = 4
    }
    class ISO20022.Sese013001.Organisation36 {
        + CorpInvstrAdr  : ISO20022.Sese013001.PostalAddress1
        + NtlRegnNb  : String
        + TaxIdNb  : String
        + RegnDt  : DateTime
        + RegnCtry  : String
        + TaxtnCtry  : String
        + Purp  : String
        + Id  : ISO20022.Sese013001.PartyIdentification140
        + Nm  : String
    }
    ISO20022.Sese013001.Organisation36 *-- ISO20022.Sese013001.PostalAddress1
    ISO20022.Sese013001.Organisation36 *-- ISO20022.Sese013001.PartyIdentification140
    class ISO20022.Sese013001.OtherAmount1 {
        + Amt  : ISO20022.Sese013001.ActiveCurrencyAndAmount
        + Tp  : ISO20022.Sese013001.OtherAmountType1Choice
    }
    ISO20022.Sese013001.OtherAmount1 *-- ISO20022.Sese013001.ActiveCurrencyAndAmount
    ISO20022.Sese013001.OtherAmount1 *-- ISO20022.Sese013001.OtherAmountType1Choice
    class ISO20022.Sese013001.OtherAmount3 {
        + Amt  : ISO20022.Sese013001.ActiveCurrencyAndAmount
        + Tp  : ISO20022.Sese013001.GenericIdentification1
    }
    ISO20022.Sese013001.OtherAmount3 *-- ISO20022.Sese013001.ActiveCurrencyAndAmount
    ISO20022.Sese013001.OtherAmount3 *-- ISO20022.Sese013001.GenericIdentification1
    class ISO20022.Sese013001.OtherAmountType1Choice {
        + PrtryCd  : ISO20022.Sese013001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Sese013001.OtherAmountType1Choice *-- ISO20022.Sese013001.GenericIdentification1
    class ISO20022.Sese013001.OtherAmountType1Code {
        SINT = 1
        PINT = 2
    }
    class ISO20022.Sese013001.OtherAsset2 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese013001.AdditionalInformation15~
        + OthrId  : global::System.Collections.Generic.List~String~
        + Desc  : String
        + Nm  : String
        + Id  : String
        + OthrAsstTp  : ISO20022.Sese013001.OtherAsset2Choice
    }
    ISO20022.Sese013001.OtherAsset2 *-- ISO20022.Sese013001.AdditionalInformation15
    ISO20022.Sese013001.OtherAsset2 *-- ISO20022.Sese013001.OtherAsset2Choice
    class ISO20022.Sese013001.OtherAsset2Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese013001.OtherAsset2Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.OtherAsset2Code {
        TIPP = 1
        PROP = 2
        MOVE = 3
        EXIA = 4
        DIMA = 5
    }
    class ISO20022.Sese013001.PartyIdentification122Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese013001.NameAndAddress5
        + AnyBIC  : String
    }
    ISO20022.Sese013001.PartyIdentification122Choice *-- ISO20022.Sese013001.NameAndAddress5
    class ISO20022.Sese013001.PartyIdentification123Choice {
        + NmAndAdr  : ISO20022.Sese013001.NameAndAddress5
        + PrtryId  : ISO20022.Sese013001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese013001.PartyIdentification123Choice *-- ISO20022.Sese013001.NameAndAddress5
    ISO20022.Sese013001.PartyIdentification123Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.PartyIdentification125Choice {
        + NmAndAdr  : ISO20022.Sese013001.NameAndAddress5
        + PrtryId  : ISO20022.Sese013001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Sese013001.PartyIdentification125Choice *-- ISO20022.Sese013001.NameAndAddress5
    ISO20022.Sese013001.PartyIdentification125Choice *-- ISO20022.Sese013001.GenericIdentification1
    class ISO20022.Sese013001.PartyIdentification126Choice {
        + PrtryId  : ISO20022.Sese013001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Sese013001.PartyIdentification126Choice *-- ISO20022.Sese013001.GenericIdentification1
    class ISO20022.Sese013001.PartyIdentification132 {
        + LEI  : String
        + PrtryId  : ISO20022.Sese013001.GenericIdentification1
        + NmAndAdr  : ISO20022.Sese013001.NameAndAddress5
        + ClrSysMmbId  : ISO20022.Sese013001.ClearingSystemMemberIdentification2Choice
        + AnyBIC  : String
    }
    ISO20022.Sese013001.PartyIdentification132 *-- ISO20022.Sese013001.GenericIdentification1
    ISO20022.Sese013001.PartyIdentification132 *-- ISO20022.Sese013001.NameAndAddress5
    ISO20022.Sese013001.PartyIdentification132 *-- ISO20022.Sese013001.ClearingSystemMemberIdentification2Choice
    class ISO20022.Sese013001.PartyIdentification139 {
        + LEI  : String
        + Pty  : ISO20022.Sese013001.PartyIdentification125Choice
    }
    ISO20022.Sese013001.PartyIdentification139 *-- ISO20022.Sese013001.PartyIdentification125Choice
    class ISO20022.Sese013001.PartyIdentification140 {
        + LEI  : String
        + Pty  : ISO20022.Sese013001.PartyIdentification126Choice
    }
    ISO20022.Sese013001.PartyIdentification140 *-- ISO20022.Sese013001.PartyIdentification126Choice
    class ISO20022.Sese013001.PartyIdentification141 {
        + AddtlInf  : ISO20022.Sese013001.PartyTextInformation1
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese013001.DateAndDateTime2Choice
        + AltrnId  : ISO20022.Sese013001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese013001.PartyIdentification122Choice
    }
    ISO20022.Sese013001.PartyIdentification141 *-- ISO20022.Sese013001.PartyTextInformation1
    ISO20022.Sese013001.PartyIdentification141 *-- ISO20022.Sese013001.DateAndDateTime2Choice
    ISO20022.Sese013001.PartyIdentification141 *-- ISO20022.Sese013001.AlternatePartyIdentification7
    ISO20022.Sese013001.PartyIdentification141 *-- ISO20022.Sese013001.PartyIdentification122Choice
    class ISO20022.Sese013001.PartyIdentificationAndAccount194 {
        + AddtlInf  : ISO20022.Sese013001.PartyTextInformation6
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese013001.DateAndDateTime2Choice
        + SfkpgAcct  : ISO20022.Sese013001.SecuritiesAccount19
        + AltrnId  : ISO20022.Sese013001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Sese013001.PartyIdentification123Choice
    }
    ISO20022.Sese013001.PartyIdentificationAndAccount194 *-- ISO20022.Sese013001.PartyTextInformation6
    ISO20022.Sese013001.PartyIdentificationAndAccount194 *-- ISO20022.Sese013001.DateAndDateTime2Choice
    ISO20022.Sese013001.PartyIdentificationAndAccount194 *-- ISO20022.Sese013001.SecuritiesAccount19
    ISO20022.Sese013001.PartyIdentificationAndAccount194 *-- ISO20022.Sese013001.AlternatePartyIdentification7
    ISO20022.Sese013001.PartyIdentificationAndAccount194 *-- ISO20022.Sese013001.PartyIdentification123Choice
    class ISO20022.Sese013001.PartyTextInformation1 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese013001.PartyTextInformation6 {
        + RegnAdr  : ISO20022.Sese013001.PostalAddress1
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    ISO20022.Sese013001.PartyTextInformation6 *-- ISO20022.Sese013001.PostalAddress1
    class ISO20022.Sese013001.PaymentInstrument14 {
        + CdtTrfDtls  : ISO20022.Sese013001.CreditTransfer9
        + Ref  : String
    }
    ISO20022.Sese013001.PaymentInstrument14 *-- ISO20022.Sese013001.CreditTransfer9
    class ISO20022.Sese013001.Pension5 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese013001.AdditionalInformation15~
        + NonWrpprTrf  : String
        + BnftCrstllstnEvtOcrd  : String
        + ClntLftmAllwncPrtcn  : String
        + LftmAllwncPrtcn  : String
        + NonSfgrddGrntedBnfts  : String
        + SfgrdBnft  : String
        + MnyPurchsAnlAllwnc  : ISO20022.Sese013001.MoneyPurchaseAnnualAllowance1
        + RingFncdDrwdwnAssts  : String
        + PnsnOrdr  : global::System.Collections.Generic.List~ISO20022.Sese013001.PensionOrder1~
        + LumpSumTp  : global::System.Collections.Generic.List~ISO20022.Sese013001.LumpSumType1Choice~
        + Shrg  : String
        + RtrmntAge  : Decimal
        + RtrmntAgePrtcn  : String
        + ValOfPnsnPlcyOrPlanOrSchme  : ISO20022.Sese013001.DateAndAmount2
        + TaxFreeCshAmt  : ISO20022.Sese013001.DateAndAmount2
        + TaxFreeCshPrtcn  : String
        + BlckTrfRef  : String
        + BlckTrf  : String
        + EstmtdVal  : ISO20022.Sese013001.DateAndAmount2
        + NbOfDrwdwnTrnchs  : Decimal
        + DrwdwnTp  : ISO20022.Sese013001.DrawdownType2Choice
        + DrwdwnSts  : ISO20022.Sese013001.DrawdownStatus1Choice
        + DrwdwnTrchId  : String
        + TaxRef  : global::System.Collections.Generic.List~ISO20022.Sese013001.TaxReference1~
        + TrfScp  : ISO20022.Sese013001.PensionTransferScope1Choice
        + Tp  : ISO20022.Sese013001.PensionSchemeType3Choice
        + Id  : ISO20022.Sese013001.PensionPolicy1
    }
    ISO20022.Sese013001.Pension5 *-- ISO20022.Sese013001.AdditionalInformation15
    ISO20022.Sese013001.Pension5 *-- ISO20022.Sese013001.MoneyPurchaseAnnualAllowance1
    ISO20022.Sese013001.Pension5 *-- ISO20022.Sese013001.PensionOrder1
    ISO20022.Sese013001.Pension5 *-- ISO20022.Sese013001.LumpSumType1Choice
    ISO20022.Sese013001.Pension5 *-- ISO20022.Sese013001.DateAndAmount2
    ISO20022.Sese013001.Pension5 *-- ISO20022.Sese013001.DateAndAmount2
    ISO20022.Sese013001.Pension5 *-- ISO20022.Sese013001.DateAndAmount2
    ISO20022.Sese013001.Pension5 *-- ISO20022.Sese013001.DrawdownType2Choice
    ISO20022.Sese013001.Pension5 *-- ISO20022.Sese013001.DrawdownStatus1Choice
    ISO20022.Sese013001.Pension5 *-- ISO20022.Sese013001.TaxReference1
    ISO20022.Sese013001.Pension5 *-- ISO20022.Sese013001.PensionTransferScope1Choice
    ISO20022.Sese013001.Pension5 *-- ISO20022.Sese013001.PensionSchemeType3Choice
    ISO20022.Sese013001.Pension5 *-- ISO20022.Sese013001.PensionPolicy1
    class ISO20022.Sese013001.PensionOrder1 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese013001.AdditionalInformation15~
        + Tp  : ISO20022.Sese013001.PensionOrderType1Choice
    }
    ISO20022.Sese013001.PensionOrder1 *-- ISO20022.Sese013001.AdditionalInformation15
    ISO20022.Sese013001.PensionOrder1 *-- ISO20022.Sese013001.PensionOrderType1Choice
    class ISO20022.Sese013001.PensionOrderType1Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese013001.PensionOrderType1Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.PensionOrderType1Code {
        SHAR = 1
        EARM = 2
    }
    class ISO20022.Sese013001.PensionPolicy1 {
        + AddtlInf  : ISO20022.Sese013001.AdditionalInformation15
        + SubIdr  : String
        + Idr  : String
    }
    ISO20022.Sese013001.PensionPolicy1 *-- ISO20022.Sese013001.AdditionalInformation15
    class ISO20022.Sese013001.PensionSchemeType3Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese013001.PensionSchemeType3Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.PensionSchemeType3Code {
        NWRP = 1
        SSAS = 2
        SIPP = 3
        S32A = 4
        SC32 = 5
        REAN = 6
        ITPO = 7
        EPKA = 8
        PPNS = 9
        OCDC = 10
        OTPM = 11
        STKI = 12
        IPST = 13
        STKG = 14
        SIPG = 15
        GPPS = 16
        FAVC = 17
        EXPP = 18
        DBEN = 19
        AAVC = 20
    }
    class ISO20022.Sese013001.PensionTransferScope1Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese013001.PensionTransferScope1Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.PensionTransferScope1Code {
        UCRY = 1
        FULP = 2
        SDDT = 3
        CRYS = 4
    }
    class ISO20022.Sese013001.PersonIdentificationType7Code {
        ITIN = 1
        GTIN = 2
        ATIN = 3
    }
    class ISO20022.Sese013001.PortfolioTransfer10 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese013001.AdditionalInformation15~
        + FinInstrmAsstForTrf  : global::System.Collections.Generic.List~ISO20022.Sese013001.FinancialInstrument100~
        + PmtDtls  : ISO20022.Sese013001.PaymentInstrument14
        + TaxDt  : DateTime
        + RsdlCsh  : global::System.Collections.Generic.List~ISO20022.Sese013001.ResidualCash2~
        + CshAll  : global::System.Collections.Generic.List~ISO20022.Sese013001.CashAll1~
        + AllOthrCsh  : global::System.Collections.Generic.List~ISO20022.Sese013001.AllOtherCash1~
        + Prtfl  : ISO20022.Sese013001.FundPortfolio7Choice
        + ActlTrfDt  : DateTime
        + TrfConfId  : String
        + TrfInstrRef  : String
        + MstrRef  : String
    }
    ISO20022.Sese013001.PortfolioTransfer10 *-- ISO20022.Sese013001.AdditionalInformation15
    ISO20022.Sese013001.PortfolioTransfer10 *-- ISO20022.Sese013001.FinancialInstrument100
    ISO20022.Sese013001.PortfolioTransfer10 *-- ISO20022.Sese013001.PaymentInstrument14
    ISO20022.Sese013001.PortfolioTransfer10 *-- ISO20022.Sese013001.ResidualCash2
    ISO20022.Sese013001.PortfolioTransfer10 *-- ISO20022.Sese013001.CashAll1
    ISO20022.Sese013001.PortfolioTransfer10 *-- ISO20022.Sese013001.AllOtherCash1
    ISO20022.Sese013001.PortfolioTransfer10 *-- ISO20022.Sese013001.FundPortfolio7Choice
    class ISO20022.Sese013001.PortfolioTransferConfirmationV11 {
        + Xtnsn  : global::System.Collections.Generic.List~ISO20022.Sese013001.Extension1~
        + MktPrctcVrsn  : ISO20022.Sese013001.MarketPracticeVersion1
        + PdctTrf  : global::System.Collections.Generic.List~ISO20022.Sese013001.PortfolioTransfer10~
        + Trfee  : ISO20022.Sese013001.PartyIdentification132
        + NmneeAcct  : ISO20022.Sese013001.InvestmentAccount69
        + TrfrAcct  : ISO20022.Sese013001.InvestmentAccount69
        + OthrCorpInvstr  : global::System.Collections.Generic.List~ISO20022.Sese013001.Organisation36~
        + ScndryCorpInvstr  : ISO20022.Sese013001.Organisation36
        + PmryCorpInvstr  : ISO20022.Sese013001.Organisation36
        + OthrIndvInvstr  : global::System.Collections.Generic.List~ISO20022.Sese013001.IndividualPerson8~
        + ScndryIndvInvstr  : ISO20022.Sese013001.IndividualPerson8
        + RegdHldr  : ISO20022.Sese013001.IndividualPerson8
        + PmryIndvInvstr  : ISO20022.Sese013001.IndividualPerson8
        + RltdRef  : ISO20022.Sese013001.AdditionalReference10
        + PrvsRef  : ISO20022.Sese013001.AdditionalReference10
        + PoolRef  : ISO20022.Sese013001.AdditionalReference11
        + MsgRef  : ISO20022.Sese013001.MessageIdentification1
    }
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.Extension1
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.MarketPracticeVersion1
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.PortfolioTransfer10
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.PartyIdentification132
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.InvestmentAccount69
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.InvestmentAccount69
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.Organisation36
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.Organisation36
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.Organisation36
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.IndividualPerson8
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.IndividualPerson8
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.IndividualPerson8
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.IndividualPerson8
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.AdditionalReference10
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.AdditionalReference10
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.AdditionalReference11
    ISO20022.Sese013001.PortfolioTransferConfirmationV11 *-- ISO20022.Sese013001.MessageIdentification1
    class ISO20022.Sese013001.PortfolioWithdrawalReason1Code {
        FTRS = 1
    }
    class ISO20022.Sese013001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Sese013001.PostalAddress6 {
        + AdrLine  : global::System.Collections.Generic.List~String~
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + SubDept  : String
        + Dept  : String
        + AdrTp  : String
    }
    class ISO20022.Sese013001.PreviousYear1Choice {
        + SpcfcPrvsYrs  : global::System.Collections.Generic.List~Int32~
        + AllPrvsYrs  : String
    }
    class ISO20022.Sese013001.PreviousYear4 {
        + CshCmpntInd  : String
        + PrvsYrs  : ISO20022.Sese013001.PreviousYear1Choice
    }
    ISO20022.Sese013001.PreviousYear4 *-- ISO20022.Sese013001.PreviousYear1Choice
    class ISO20022.Sese013001.PriceMethod1Code {
        HIST = 1
        FORW = 2
    }
    class ISO20022.Sese013001.PriceValue1 {
        + Amt  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Sese013001.PriceValue1 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Sese013001.Quantity47 {
        + OthrAsst  : String
        + CshAmt  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + PctgRate  : Decimal
        + Unit  : Decimal
    }
    ISO20022.Sese013001.Quantity47 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Sese013001.ResidualCash2 {
        + Ccy  : String
        + Ind  : String
    }
    class ISO20022.Sese013001.Role4Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese013001.Role4Choice *-- ISO20022.Sese013001.GenericIdentification47
    class ISO20022.Sese013001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Sese013001.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Sese013001.SafekeepingPlaceFormat28Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification78
        + TpAndId  : ISO20022.Sese013001.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Sese013001.SafekeepingPlaceTypeAndText6
    }
    ISO20022.Sese013001.SafekeepingPlaceFormat28Choice *-- ISO20022.Sese013001.GenericIdentification78
    ISO20022.Sese013001.SafekeepingPlaceFormat28Choice *-- ISO20022.Sese013001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Sese013001.SafekeepingPlaceFormat28Choice *-- ISO20022.Sese013001.SafekeepingPlaceTypeAndText6
    class ISO20022.Sese013001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese013001.SafekeepingPlaceTypeAndText6 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese013001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Sese013001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese013001.SecuritiesAccount19 *-- ISO20022.Sese013001.GenericIdentification30
    class ISO20022.Sese013001.SecurityIdentification25Choice {
        + OthrPrtryId  : ISO20022.Sese013001.AlternateSecurityIdentification7
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
    ISO20022.Sese013001.SecurityIdentification25Choice *-- ISO20022.Sese013001.AlternateSecurityIdentification7
    class ISO20022.Sese013001.SettlementParties94 {
        + Pty5  : ISO20022.Sese013001.PartyIdentificationAndAccount194
        + Pty4  : ISO20022.Sese013001.PartyIdentificationAndAccount194
        + Pty3  : ISO20022.Sese013001.PartyIdentificationAndAccount194
        + Pty2  : ISO20022.Sese013001.PartyIdentificationAndAccount194
        + Pty1  : ISO20022.Sese013001.PartyIdentificationAndAccount194
        + Dpstry  : ISO20022.Sese013001.PartyIdentification141
    }
    ISO20022.Sese013001.SettlementParties94 *-- ISO20022.Sese013001.PartyIdentificationAndAccount194
    ISO20022.Sese013001.SettlementParties94 *-- ISO20022.Sese013001.PartyIdentificationAndAccount194
    ISO20022.Sese013001.SettlementParties94 *-- ISO20022.Sese013001.PartyIdentificationAndAccount194
    ISO20022.Sese013001.SettlementParties94 *-- ISO20022.Sese013001.PartyIdentificationAndAccount194
    ISO20022.Sese013001.SettlementParties94 *-- ISO20022.Sese013001.PartyIdentificationAndAccount194
    ISO20022.Sese013001.SettlementParties94 *-- ISO20022.Sese013001.PartyIdentification141
    class ISO20022.Sese013001.SettlementTransactionCondition11Code {
        NOMC = 1
    }
    class ISO20022.Sese013001.SettlementTransactionCondition30Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese013001.SettlementTransactionCondition30Choice *-- ISO20022.Sese013001.GenericIdentification30
    class ISO20022.Sese013001.SubAccount5 {
        + Chrtc  : String
        + Nm  : String
        + Id  : String
    }
    class ISO20022.Sese013001.SubscriptionInformation2 {
        + TtlAmtYrToDt  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
        + CshCmpnt  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
        + EqtyCmpnt  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
        + DtOfFrstSbcpt  : DateTime
    }
    ISO20022.Sese013001.SubscriptionInformation2 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese013001.SubscriptionInformation2 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese013001.SubscriptionInformation2 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Sese013001.Tax35 {
        + TaxClctnDtls  : ISO20022.Sese013001.TaxCalculationInformation10
        + RcptId  : ISO20022.Sese013001.PartyIdentification139
        + Ctry  : String
        + ApldRate  : Decimal
        + ApldAmt  : ISO20022.Sese013001.ActiveCurrencyAndAmount
        + Tp  : ISO20022.Sese013001.TaxType3Choice
    }
    ISO20022.Sese013001.Tax35 *-- ISO20022.Sese013001.TaxCalculationInformation10
    ISO20022.Sese013001.Tax35 *-- ISO20022.Sese013001.PartyIdentification139
    ISO20022.Sese013001.Tax35 *-- ISO20022.Sese013001.ActiveCurrencyAndAmount
    ISO20022.Sese013001.Tax35 *-- ISO20022.Sese013001.TaxType3Choice
    class ISO20022.Sese013001.Tax36 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese013001.AdditionalInformation15~
        + DtOrPrd  : ISO20022.Sese013001.DateQuarter1Choice
    }
    ISO20022.Sese013001.Tax36 *-- ISO20022.Sese013001.AdditionalInformation15
    ISO20022.Sese013001.Tax36 *-- ISO20022.Sese013001.DateQuarter1Choice
    class ISO20022.Sese013001.TaxBasis1Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese013001.TaxBasis1Choice *-- ISO20022.Sese013001.GenericIdentification47
    class ISO20022.Sese013001.TaxCalculationInformation10 {
        + TaxblAmt  : ISO20022.Sese013001.ActiveCurrencyAndAmount
        + Bsis  : ISO20022.Sese013001.TaxBasis1Choice
    }
    ISO20022.Sese013001.TaxCalculationInformation10 *-- ISO20022.Sese013001.ActiveCurrencyAndAmount
    ISO20022.Sese013001.TaxCalculationInformation10 *-- ISO20022.Sese013001.TaxBasis1Choice
    class ISO20022.Sese013001.TaxEfficientProduct7 {
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Sese013001.AdditionalInformation15~
        + EstmtdVal  : ISO20022.Sese013001.DateAndAmount2
        + CurInvstmtAmt  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
        + UusdTaxDdctn  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
        + TaxClctnBase  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
        + LwstInvstdAmtCurYr  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
        + InnvtvFinc  : global::System.Collections.Generic.List~ISO20022.Sese013001.InnovativeFinance1~
        + InvstmtsToFllwVal  : global::System.Collections.Generic.List~ISO20022.Sese013001.DateAndAmount2~
        + InvstrTaxRef  : ISO20022.Sese013001.TaxReference2
        + DtFrstQlfygAddtn  : DateTime
        + OthrAmt  : global::System.Collections.Generic.List~ISO20022.Sese013001.OtherAmount3~
        + TtlSbcptAmt  : ISO20022.Sese013001.ActiveCurrencyAndAmount
        + TrfrAltrnId  : String
        + WdrwlForResdtlPurchsPrgrs  : String
        + BnsOrWdrwl  : global::System.Collections.Generic.List~ISO20022.Sese013001.BonusWithdrawal2~
        + CurYrSbcptDtls  : ISO20022.Sese013001.SubscriptionInformation2
        + DtOfFrstSbcpt  : DateTime
        + PrvsYrsSbcptAmt  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
        + PrvsYrSbcptAmt  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
        + PrvsYrs  : ISO20022.Sese013001.PreviousYear4
        + CshCmpntInd  : String
        + CurYr  : String
        + TaxEffcntPdctTp  : ISO20022.Sese013001.TaxEfficientProductType2Choice
    }
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.AdditionalInformation15
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.DateAndAmount2
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.InnovativeFinance1
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.DateAndAmount2
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.TaxReference2
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.OtherAmount3
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.ActiveCurrencyAndAmount
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.BonusWithdrawal2
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.SubscriptionInformation2
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.PreviousYear4
    ISO20022.Sese013001.TaxEfficientProduct7 *-- ISO20022.Sese013001.TaxEfficientProductType2Choice
    class ISO20022.Sese013001.TaxEfficientProductType2Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese013001.TaxEfficientProductType2Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.TaxEfficientProductType2Code {
        EQUI = 1
        SCTF = 2
        CCTF = 3
        LISA = 4
        JISA = 5
        JCSH = 6
        INNF = 7
        HISA = 8
        GASK = 9
        GISK = 10
        FISA = 11
        CLIS = 12
        CASH = 13
    }
    class ISO20022.Sese013001.TaxReference1 {
        + HldrTp  : ISO20022.Sese013001.TaxReferenceParty1Choice
        + Ref  : String
        + TaxTp  : ISO20022.Sese013001.TaxReferenceType1Choice
    }
    ISO20022.Sese013001.TaxReference1 *-- ISO20022.Sese013001.TaxReferenceParty1Choice
    ISO20022.Sese013001.TaxReference1 *-- ISO20022.Sese013001.TaxReferenceType1Choice
    class ISO20022.Sese013001.TaxReference2 {
        + Ref  : String
        + Tp  : ISO20022.Sese013001.TaxReferenceType1Choice
    }
    ISO20022.Sese013001.TaxReference2 *-- ISO20022.Sese013001.TaxReferenceType1Choice
    class ISO20022.Sese013001.TaxReferenceParty1Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese013001.TaxReferenceParty1Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.TaxReferenceType1Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese013001.TaxReferenceType1Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.TaxType17Code {
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
    class ISO20022.Sese013001.TaxType3Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese013001.TaxType3Choice *-- ISO20022.Sese013001.GenericIdentification47
    class ISO20022.Sese013001.TaxWrapperAmountType1Code {
        WTHD = 1
        BONU = 2
    }
    class ISO20022.Sese013001.TaxableIncomePerShareCalculated2Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese013001.TaxableIncomePerShareCalculated2Choice *-- ISO20022.Sese013001.GenericIdentification47
    class ISO20022.Sese013001.TaxableIncomePerShareCalculated2Code {
        UKWN = 1
        TSIN = 2
        TSIY = 3
    }
    class ISO20022.Sese013001.TaxationBasis2Code {
        PERU = 1
        FLAT = 2
    }
    class ISO20022.Sese013001.TaxationBasis5Code {
        PERU = 1
        NAVP = 2
        NEAM = 3
        GRAM = 4
        FLAT = 5
    }
    class ISO20022.Sese013001.TotalFeesAndTaxes41 {
        + IndvTax  : global::System.Collections.Generic.List~ISO20022.Sese013001.Tax35~
        + IndvFee  : global::System.Collections.Generic.List~ISO20022.Sese013001.Fee5~
        + ComrclAgrmtRef  : String
        + TtlTaxs  : ISO20022.Sese013001.ActiveCurrencyAndAmount
        + TtlFees  : ISO20022.Sese013001.ActiveCurrencyAndAmount
        + TtlOvrhdApld  : ISO20022.Sese013001.ActiveCurrencyAndAmount
    }
    ISO20022.Sese013001.TotalFeesAndTaxes41 *-- ISO20022.Sese013001.Tax35
    ISO20022.Sese013001.TotalFeesAndTaxes41 *-- ISO20022.Sese013001.Fee5
    ISO20022.Sese013001.TotalFeesAndTaxes41 *-- ISO20022.Sese013001.ActiveCurrencyAndAmount
    ISO20022.Sese013001.TotalFeesAndTaxes41 *-- ISO20022.Sese013001.ActiveCurrencyAndAmount
    ISO20022.Sese013001.TotalFeesAndTaxes41 *-- ISO20022.Sese013001.ActiveCurrencyAndAmount
    class ISO20022.Sese013001.TradeTransactionCondition5Code {
        CCPN = 1
        XCPN = 2
    }
    class ISO20022.Sese013001.TradeTransactionCondition8Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese013001.TradeTransactionCondition8Choice *-- ISO20022.Sese013001.GenericIdentification30
    class ISO20022.Sese013001.TransferType2Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese013001.TransferType2Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.TransferType4Code {
        SECU = 1
        EXCL = 2
        CONV = 3
        CASH = 4
    }
    class ISO20022.Sese013001.TypeOfAmount1Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese013001.TypeOfAmount1Choice *-- ISO20022.Sese013001.GenericIdentification36
    class ISO20022.Sese013001.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Sese013001.TypeOfPrice10Code {
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
    class ISO20022.Sese013001.TypeOfPrice46Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese013001.TypeOfPrice46Choice *-- ISO20022.Sese013001.GenericIdentification47
    class ISO20022.Sese013001.UKTaxGroupUnit1Code {
        GRP2 = 1
        GRP1 = 2
    }
    class ISO20022.Sese013001.Unit11 {
        + OthrAmt  : global::System.Collections.Generic.List~ISO20022.Sese013001.OtherAmount1~
        + TxOvrhd  : ISO20022.Sese013001.TotalFeesAndTaxes41
        + PricDtls  : ISO20022.Sese013001.UnitPrice23
        + Ref  : String
        + Grp1Or2Units  : String
        + CertNb  : global::System.Collections.Generic.List~String~
        + AcqstnDt  : DateTime
        + OrdrDt  : DateTime
        + UnitsNb  : Decimal
    }
    ISO20022.Sese013001.Unit11 *-- ISO20022.Sese013001.OtherAmount1
    ISO20022.Sese013001.Unit11 *-- ISO20022.Sese013001.TotalFeesAndTaxes41
    ISO20022.Sese013001.Unit11 *-- ISO20022.Sese013001.UnitPrice23
    class ISO20022.Sese013001.UnitPrice23 {
        + TaxblIncmPerShrClctd  : ISO20022.Sese013001.TaxableIncomePerShareCalculated2Choice
        + TaxblIncmPerShr  : ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
        + NbOfDaysAcrd  : Decimal
        + AcrdIntrstNAV  : ISO20022.Sese013001.ActiveOrHistoricCurrencyAndAmount
        + PricMtd  : String
        + Val  : ISO20022.Sese013001.PriceValue1
        + Tp  : ISO20022.Sese013001.TypeOfPrice46Choice
    }
    ISO20022.Sese013001.UnitPrice23 *-- ISO20022.Sese013001.TaxableIncomePerShareCalculated2Choice
    ISO20022.Sese013001.UnitPrice23 *-- ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Sese013001.UnitPrice23 *-- ISO20022.Sese013001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese013001.UnitPrice23 *-- ISO20022.Sese013001.PriceValue1
    ISO20022.Sese013001.UnitPrice23 *-- ISO20022.Sese013001.TypeOfPrice46Choice
    class ISO20022.Sese013001.WaivingInstruction1Code {
        WIUN = 1
        WICA = 2
    }
    class ISO20022.Sese013001.WaivingInstruction2Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese013001.WaivingInstruction2Choice *-- ISO20022.Sese013001.GenericIdentification47
    class ISO20022.Sese013001.WithdrawalReason1Choice {
        + Prtry  : ISO20022.Sese013001.GenericIdentification36
        + Cd  : String
    }
    ISO20022.Sese013001.WithdrawalReason1Choice *-- ISO20022.Sese013001.GenericIdentification36
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

## Value ISO20022.Sese013001.Account27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|ISO20022.Sese013001.PartyIdentification139||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcr))|

---

## Value ISO20022.Sese013001.Account28


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubAcctDtls|ISO20022.Sese013001.SubAccount5||XmlElement()||
|+|Svcr|ISO20022.Sese013001.PartyIdentification132||XmlElement()||
|+|AcctNm|String||XmlElement()||
|+|Dsgnt|String||XmlElement()||
|+|AcctId|String||XmlElement()||
|+|OwnrId|ISO20022.Sese013001.PartyIdentification132||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SubAcctDtls),validElement(Svcr),validElement(OwnrId))|

---

## Value ISO20022.Sese013001.AccountIdentificationAndName6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Sese013001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""))|

---

## Enum ISO20022.Sese013001.AccountOwnershipType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||USUF|Int32||XmlEnum("""USUF""")|1|
||UNCO|Int32||XmlEnum("""UNCO""")|2|
||SIGL|Int32||XmlEnum("""SIGL""")|3|
||RGIC|Int32||XmlEnum("""RGIC""")|4|
||OWNR|Int32||XmlEnum("""OWNR""")|5|
||ONIS|Int32||XmlEnum("""ONIS""")|6|
||NFPO|Int32||XmlEnum("""NFPO""")|7|
||NOMI|Int32||XmlEnum("""NOMI""")|8|
||LIPA|Int32||XmlEnum("""LIPA""")|9|
||LLCO|Int32||XmlEnum("""LLCO""")|10|
||JOIN|Int32||XmlEnum("""JOIN""")|11|
||COMO|Int32||XmlEnum("""COMO""")|12|
||JOIT|Int32||XmlEnum("""JOIT""")|13|
||GOVO|Int32||XmlEnum("""GOVO""")|14|
||TRUS|Int32||XmlEnum("""TRUS""")|15|
||PART|Int32||XmlEnum("""PART""")|16|
||EURE|Int32||XmlEnum("""EURE""")|17|
||ENTR|Int32||XmlEnum("""ENTR""")|18|
||CUST|Int32||XmlEnum("""CUST""")|19|
||CORP|Int32||XmlEnum("""CORP""")|20|
||BOWN|Int32||XmlEnum("""BOWN""")|21|

---

## Value ISO20022.Sese013001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese013001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese013001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese013001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese013001.AdditionalInformation15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InfVal|String||XmlElement()||
|+|InfTp|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InfTp))|

---

## Value ISO20022.Sese013001.AdditionalReference10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Sese013001.PartyIdentification139||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Value ISO20022.Sese013001.AdditionalReference11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Sese013001.PartyIdentification139||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Enum ISO20022.Sese013001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Sese013001.AllOtherCash1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese013001.AlternatePartyIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Sese013001.IdentificationType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Sese013001.AlternateSecurityIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdSrc|ISO20022.Sese013001.IdentificationSource1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdSrc))|

---

## Value ISO20022.Sese013001.BonusWithdrawal2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese013001.AdditionalInformation15>||XmlElement()||
|+|Ref|String||XmlElement()||
|+|Outsdng|String||XmlElement()||
|+|UclmdAmt|ISO20022.Sese013001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rsn|ISO20022.Sese013001.WithdrawalReason1Choice||XmlElement()||
|+|Amt|ISO20022.Sese013001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|TpOfAmt|ISO20022.Sese013001.TypeOfAmount1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(UclmdAmt),validElement(Rsn),validElement(Amt),validElement(TpOfAmt))|

---

## Value ISO20022.Sese013001.BranchData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Sese013001.PostalAddress6||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr))|

---

## Enum ISO20022.Sese013001.BusinessFlowType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLPR|Int32||XmlEnum("""DLPR""")|1|
||SLRP|Int32||XmlEnum("""SLRP""")|2|
||SLDP|Int32||XmlEnum("""SLDP""")|3|

---

## Value ISO20022.Sese013001.CashAll1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese013001.CashAsset3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese013001.AdditionalInformation15||XmlElement()||
|+|TrfCcy|String||XmlElement()||
|+|HldgCcy|String||XmlElement()||
|+|CshAsstTp|ISO20022.Sese013001.CashAssetType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""TrfCcy""",TrfCcy,"""[A-Z]{3,3}"""),validPattern("""HldgCcy""",HldgCcy,"""[A-Z]{3,3}"""),validElement(CshAsstTp))|

---

## Value ISO20022.Sese013001.CashAssetType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.CashAssetType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSH1|Int32||XmlEnum("""CSH1""")|1|
||CSH2|Int32||XmlEnum("""CSH2""")|2|

---

## Value ISO20022.Sese013001.ChargeBasis2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese013001.ChargeOrCommissionDiscount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bsis|ISO20022.Sese013001.WaivingInstruction2Choice||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Sese013001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bsis),validElement(Amt))|

---

## Value ISO20022.Sese013001.ChargeType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese013001.ClassificationType32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Value ISO20022.Sese013001.ClearingSystemMemberIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrClrCdId|String||XmlElement()||
|+|PLKNR|String||XmlElement()||
|+|GRHEBIC|String||XmlElement()||
|+|INIFSC|String||XmlElement()||
|+|AUBSBs|String||XmlElement()||
|+|AUBSBx|String||XmlElement()||
|+|HKNCC|String||XmlElement()||
|+|ZANCC|String||XmlElement()||
|+|ESNCC|String||XmlElement()||
|+|DEBLZ|String||XmlElement()||
|+|CHSIC|String||XmlElement()||
|+|CACPA|String||XmlElement()||
|+|ATBLZ|String||XmlElement()||
|+|ITNCC|String||XmlElement()||
|+|RUCB|String||XmlElement()||
|+|PTNCC|String||XmlElement()||
|+|USFW|String||XmlElement()||
|+|CHBC|String||XmlElement()||
|+|USCH|String||XmlElement()||
|+|GBSC|String||XmlElement()||
|+|IENSC|String||XmlElement()||
|+|NZNCC|String||XmlElement()||
|+|USCHU|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PLKNR""",PLKNR,"""PL[0-9]{8,8}"""),validPattern("""GRHEBIC""",GRHEBIC,"""GR[0-9]{7,7}"""),validPattern("""INIFSC""",INIFSC,"""IN[a-zA-Z0-9]{11,11}"""),validPattern("""AUBSBs""",AUBSBs,"""AU[0-9]{6,6}"""),validPattern("""AUBSBx""",AUBSBx,"""AU[0-9]{6,6}"""),validPattern("""HKNCC""",HKNCC,"""HK[0-9]{3,3}"""),validPattern("""ZANCC""",ZANCC,"""ZA[0-9]{6,6}"""),validPattern("""ESNCC""",ESNCC,"""ES[0-9]{8,9}"""),validPattern("""DEBLZ""",DEBLZ,"""BL[0-9]{8,8}"""),validPattern("""CHSIC""",CHSIC,"""SW[0-9]{6,6}"""),validPattern("""CACPA""",CACPA,"""CA[0-9]{9,9}"""),validPattern("""ATBLZ""",ATBLZ,"""AT[0-9]{5,5}"""),validPattern("""ITNCC""",ITNCC,"""IT[0-9]{10,10}"""),validPattern("""RUCB""",RUCB,"""RU[0-9]{9,9}"""),validPattern("""PTNCC""",PTNCC,"""PT[0-9]{8,8}"""),validPattern("""USFW""",USFW,"""FW[0-9]{9,9}"""),validPattern("""CHBC""",CHBC,"""SW[0-9]{3,5}"""),validPattern("""USCH""",USCH,"""CP[0-9]{4,4}"""),validPattern("""GBSC""",GBSC,"""SC[0-9]{6,6}"""),validPattern("""IENSC""",IENSC,"""IE[0-9]{6,6}"""),validPattern("""NZNCC""",NZNCC,"""NZ[0-9]{6,6}"""),validPattern("""USCHU""",USCHU,"""CH[0-9]{6,6}"""),validChoice(OthrClrCdId,PLKNR,GRHEBIC,INIFSC,AUBSBs,AUBSBx,HKNCC,ZANCC,ESNCC,DEBLZ,CHSIC,CACPA,ATBLZ,ITNCC,RUCB,PTNCC,USFW,CHBC,USCH,GBSC,IENSC,NZNCC,USCHU))|

---

## Value ISO20022.Sese013001.ClearingSystemMemberIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AUBSBs|String||XmlElement()||
|+|AUBSBx|String||XmlElement()||
|+|HKNCC|String||XmlElement()||
|+|ZANCC|String||XmlElement()||
|+|ESNCC|String||XmlElement()||
|+|DEBLZ|String||XmlElement()||
|+|CHSIC|String||XmlElement()||
|+|CACPA|String||XmlElement()||
|+|ATBLZ|String||XmlElement()||
|+|ITNCC|String||XmlElement()||
|+|RUCB|String||XmlElement()||
|+|PTNCC|String||XmlElement()||
|+|USFW|String||XmlElement()||
|+|CHBC|String||XmlElement()||
|+|USCH|String||XmlElement()||
|+|GBSC|String||XmlElement()||
|+|IENSC|String||XmlElement()||
|+|NZNCC|String||XmlElement()||
|+|USCHU|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AUBSBs""",AUBSBs,"""AU[0-9]{6,6}"""),validPattern("""AUBSBx""",AUBSBx,"""AU[0-9]{6,6}"""),validPattern("""HKNCC""",HKNCC,"""HK[0-9]{3,3}"""),validPattern("""ZANCC""",ZANCC,"""ZA[0-9]{6,6}"""),validPattern("""ESNCC""",ESNCC,"""ES[0-9]{8,9}"""),validPattern("""DEBLZ""",DEBLZ,"""BL[0-9]{8,8}"""),validPattern("""CHSIC""",CHSIC,"""SW[0-9]{6,6}"""),validPattern("""CACPA""",CACPA,"""CA[0-9]{9,9}"""),validPattern("""ATBLZ""",ATBLZ,"""AT[0-9]{5,5}"""),validPattern("""ITNCC""",ITNCC,"""IT[0-9]{10,10}"""),validPattern("""RUCB""",RUCB,"""RU[0-9]{9,9}"""),validPattern("""PTNCC""",PTNCC,"""PT[0-9]{8,8}"""),validPattern("""USFW""",USFW,"""FW[0-9]{9,9}"""),validPattern("""CHBC""",CHBC,"""SW[0-9]{3,5}"""),validPattern("""USCH""",USCH,"""CP[0-9]{4,4}"""),validPattern("""GBSC""",GBSC,"""SC[0-9]{6,6}"""),validPattern("""IENSC""",IENSC,"""IE[0-9]{6,6}"""),validPattern("""NZNCC""",NZNCC,"""NZ[0-9]{6,6}"""),validPattern("""USCHU""",USCHU,"""CH[0-9]{6,6}"""),validChoice(AUBSBs,AUBSBx,HKNCC,ZANCC,ESNCC,DEBLZ,CHSIC,CACPA,ATBLZ,ITNCC,RUCB,PTNCC,USFW,CHBC,USCH,GBSC,IENSC,NZNCC,USCHU))|

---

## Value ISO20022.Sese013001.ContactIdentification2


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

## Value ISO20022.Sese013001.Conversion1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese013001.AdditionalInformation15>||XmlElement()||
|+|TrgtScty|ISO20022.Sese013001.FinancialInstrumentIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(TrgtScty))|

---

## Value ISO20022.Sese013001.CreditTransfer9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtrAcct|ISO20022.Sese013001.AccountIdentificationAndName6||XmlElement()||
|+|Cdtr|ISO20022.Sese013001.PartyIdentification132||XmlElement()||
|+|CdtrAgtAcct|ISO20022.Sese013001.AccountIdentificationAndName6||XmlElement()||
|+|CdtrAgt|ISO20022.Sese013001.FinancialInstitutionIdentification16||XmlElement()||
|+|IntrmyAgt2Acct|ISO20022.Sese013001.AccountIdentificationAndName6||XmlElement()||
|+|IntrmyAgt2|ISO20022.Sese013001.FinancialInstitutionIdentification16||XmlElement()||
|+|IntrmyAgt1Acct|ISO20022.Sese013001.AccountIdentificationAndName6||XmlElement()||
|+|IntrmyAgt1|ISO20022.Sese013001.FinancialInstitutionIdentification16||XmlElement()||
|+|DbtrAgtAcct|ISO20022.Sese013001.AccountIdentificationAndName6||XmlElement()||
|+|DbtrAgt|ISO20022.Sese013001.FinancialInstitutionIdentification16||XmlElement()||
|+|DbtrAcct|ISO20022.Sese013001.AccountIdentificationAndName6||XmlElement()||
|+|Dbtr|ISO20022.Sese013001.PartyIdentification132||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtrAcct),validElement(Cdtr),validElement(CdtrAgtAcct),validElement(CdtrAgt),validElement(IntrmyAgt2Acct),validElement(IntrmyAgt2),validElement(IntrmyAgt1Acct),validElement(IntrmyAgt1),validElement(DbtrAgtAcct),validElement(DbtrAgt),validElement(DbtrAcct),validElement(Dbtr))|

---

## Value ISO20022.Sese013001.Crystallisation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese013001.AdditionalInformation15>||XmlElement()||
|+|UcrstllsdAmt|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|CrstllsdAmt|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|UcrstllsdUnitsNb|Decimal||XmlElement()||
|+|CrstllsdUnitsNb|Decimal||XmlElement()||
|+|TrchId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(UcrstllsdAmt),validElement(CrstllsdAmt))|

---

## Value ISO20022.Sese013001.DateAndAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese013001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Sese013001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Sese013001.DateQuarter1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prd|String||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prd,Dt))|

---

## Type ISO20022.Sese013001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtflTrfConf|ISO20022.Sese013001.PortfolioTransferConfirmationV11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtflTrfConf))|

---

## Value ISO20022.Sese013001.DrawdownStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.DrawdownStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NONE|Int32||XmlEnum("""NONE""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Sese013001.DrawdownType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.DrawdownType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FLEX|Int32||XmlEnum("""FLEX""")|1|
||CAPP|Int32||XmlEnum("""CAPP""")|2|
||BOTH|Int32||XmlEnum("""BOTH""")|3|

---

## Value ISO20022.Sese013001.Extension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese013001.Fee5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InftvInd|String||XmlElement()||
|+|RcptId|ISO20022.Sese013001.PartyIdentification139||XmlElement()||
|+|NonStdSLARef|String||XmlElement()||
|+|ApldRate|Decimal||XmlElement()||
|+|ApldAmt|ISO20022.Sese013001.ActiveCurrencyAndAmount||XmlElement()||
|+|DscntDtls|ISO20022.Sese013001.ChargeOrCommissionDiscount1||XmlElement()||
|+|StdRate|Decimal||XmlElement()||
|+|StdAmt|ISO20022.Sese013001.ActiveCurrencyAndAmount||XmlElement()||
|+|Bsis|ISO20022.Sese013001.ChargeBasis2Choice||XmlElement()||
|+|Tp|ISO20022.Sese013001.ChargeType5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcptId),validElement(ApldAmt),validElement(DscntDtls),validElement(StdAmt),validElement(Bsis),validElement(Tp))|

---

## Value ISO20022.Sese013001.FinancialInstitutionIdentification16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Sese013001.BranchData2||XmlElement()||
|+|PrtryId|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese013001.NameAndAddress5||XmlElement()||
|+|ClrSysMmbId|ISO20022.Sese013001.ClearingSystemMemberIdentification4Choice||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(NmAndAdr),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese013001.FinancialInstrument100


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese013001.AdditionalInformation15>||XmlElement()||
|+|TrfRsltsInChngOfBnfclOwnr|String||XmlElement()||
|+|AsstsHeldInOwnNm|String||XmlElement()||
|+|SttlmPtiesDtls|ISO20022.Sese013001.FundSettlementParameters17||XmlElement()||
|+|TaxValtnPt|ISO20022.Sese013001.Tax36||XmlElement()||
|+|CrstllstnDtls|global::System.Collections.Generic.List<ISO20022.Sese013001.Crystallisation2>||XmlElement()||
|+|PmtDtls|ISO20022.Sese013001.PaymentInstrument14||XmlElement()||
|+|FctvSttlmDt|ISO20022.Sese013001.DateAndDateTime2Choice||XmlElement()||
|+|FctvTrfDt|ISO20022.Sese013001.DateAndDateTime2Choice||XmlElement()||
|+|ReqdSttlmDt|DateTime||XmlElement()||
|+|ReqdTradDt|DateTime||XmlElement()||
|+|IntrmyInf|global::System.Collections.Generic.List<ISO20022.Sese013001.Intermediary43>||XmlElement()||
|+|Trfr|ISO20022.Sese013001.Account28||XmlElement()||
|+|TrfeeAcct|ISO20022.Sese013001.Account28||XmlElement()||
|+|LatstValtn|ISO20022.Sese013001.DateAndAmount2||XmlElement()||
|+|OrgnlCost|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|TtlBookVal|ISO20022.Sese013001.DateAndAmount2||XmlElement()||
|+|TrfCcy|String||XmlElement()||
|+|AvrgAcqstnPric|ISO20022.Sese013001.ActiveCurrencyAndAmount||XmlElement()||
|+|BizFlowTp|String||XmlElement()||
|+|CtrPtyRef|ISO20022.Sese013001.AdditionalReference10||XmlElement()||
|+|ClntRef|ISO20022.Sese013001.AdditionalReference10||XmlElement()||
|+|UnitsDtls|global::System.Collections.Generic.List<ISO20022.Sese013001.Unit11>||XmlElement()||
|+|Convs|ISO20022.Sese013001.Conversion1||XmlElement()||
|+|NotAvlbl|String||XmlElement()||
|+|AddtlAsst|String||XmlElement()||
|+|TrfTp|ISO20022.Sese013001.TransferType2Choice||XmlElement()||
|+|OrgnlPctgInstd|Decimal||XmlElement()||
|+|PrtlInstdQty|String||XmlElement()||
|+|Qty|ISO20022.Sese013001.Quantity47||XmlElement()||
|+|Instrm|ISO20022.Sese013001.FinancialInstrument63Choice||XmlElement()||
|+|LineId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(SttlmPtiesDtls),validElement(TaxValtnPt),validList("""CrstllstnDtls""",CrstllstnDtls),validElement(CrstllstnDtls),validElement(PmtDtls),validElement(FctvSttlmDt),validElement(FctvTrfDt),validList("""IntrmyInf""",IntrmyInf),validElement(IntrmyInf),validElement(Trfr),validElement(TrfeeAcct),validElement(LatstValtn),validElement(OrgnlCost),validElement(TtlBookVal),validPattern("""TrfCcy""",TrfCcy,"""[A-Z]{3,3}"""),validElement(AvrgAcqstnPric),validElement(CtrPtyRef),validElement(ClntRef),validList("""UnitsDtls""",UnitsDtls),validElement(UnitsDtls),validElement(Convs),validElement(TrfTp),validElement(Qty),validElement(Instrm))|

---

## Value ISO20022.Sese013001.FinancialInstrument63Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrAsst|ISO20022.Sese013001.OtherAsset2||XmlElement()||
|+|CshAsst|ISO20022.Sese013001.CashAsset3||XmlElement()||
|+|Scty|ISO20022.Sese013001.FinancialInstrumentIdentification2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrAsst),validElement(CshAsst),validElement(Scty),validChoice(OthrAsst,CshAsst,Scty))|

---

## Value ISO20022.Sese013001.FinancialInstrumentIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Sese013001.SecurityIdentification25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Sese013001.FinancialInstrumentIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClssfctnTp|ISO20022.Sese013001.ClassificationType32Choice||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Sese013001.SecurityIdentification25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClssfctnTp),validElement(Id))|

---

## Value ISO20022.Sese013001.FundPortfolio7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pnsn|ISO20022.Sese013001.Pension5||XmlElement()||
|+|GnlInvstmt|ISO20022.Sese013001.GeneralInvestment2||XmlElement()||
|+|TaxEffcntPdct|ISO20022.Sese013001.TaxEfficientProduct7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pnsn),validElement(GnlInvstmt),validElement(TaxEffcntPdct),validChoice(Pnsn,GnlInvstmt,TaxEffcntPdct))|

---

## Value ISO20022.Sese013001.FundSettlementParameters17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DlvrgSdDtls|ISO20022.Sese013001.SettlementParties94||XmlElement()||
|+|RcvgSdDtls|ISO20022.Sese013001.SettlementParties94||XmlElement()||
|+|SctiesSttlmSysId|String||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese013001.SettlementTransactionCondition30Choice>||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Sese013001.TradeTransactionCondition8Choice>||XmlElement()||
|+|SfkpgPlc|ISO20022.Sese013001.SafekeepingPlaceFormat28Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DlvrgSdDtls),validElement(RcvgSdDtls),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond),validElement(SfkpgPlc))|

---

## Enum ISO20022.Sese013001.GenderCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FEMA|Int32||XmlEnum("""FEMA""")|1|
||MALE|Int32||XmlEnum("""MALE""")|2|

---

## Value ISO20022.Sese013001.GeneralInvestment2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese013001.AdditionalInformation15>||XmlElement()||
|+|EstmtdVal|ISO20022.Sese013001.DateAndAmount2||XmlElement()||
|+|CurInvstmtAmt|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|OwnrshTp|String||XmlElement()||
|+|Tp|ISO20022.Sese013001.GeneralInvestmentAccountType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(EstmtdVal),validElement(CurInvstmtAmt),validElement(Tp))|

---

## Value ISO20022.Sese013001.GeneralInvestmentAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.GeneralInvestmentAccountType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EQUI|Int32||XmlEnum("""EQUI""")|1|
||ANYY|Int32||XmlEnum("""ANYY""")|2|

---

## Value ISO20022.Sese013001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Sese013001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Sese013001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese013001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese013001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese013001.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese013001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Sese013001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Sese013001.HolderType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TFOR|Int32||XmlEnum("""TFOR""")|1|
||TFEE|Int32||XmlEnum("""TFEE""")|2|

---

## Value ISO20022.Sese013001.IdentificationSource1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Dmst|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Dmst""",Dmst,"""[A-Z]{2,2}"""),validChoice(Prtry,Dmst))|

---

## Value ISO20022.Sese013001.IdentificationType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese013001.IndividualPerson8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndvInvstrAdr|ISO20022.Sese013001.PostalAddress1||XmlElement()||
|+|SclSctyNb|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
|+|Gndr|String||XmlElement()||
|+|NmSfx|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IndvInvstrAdr))|

---

## Value ISO20022.Sese013001.InnovativeFinance1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Inf|String||XmlElement()||
|+|Tp|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese013001.Intermediary43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctPrsn|ISO20022.Sese013001.ContactIdentification2||XmlElement()||
|+|Role|ISO20022.Sese013001.Role4Choice||XmlElement()||
|+|Acct|ISO20022.Sese013001.Account27||XmlElement()||
|+|Id|ISO20022.Sese013001.PartyIdentification139||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctPrsn),validElement(Role),validElement(Acct),validElement(Id))|

---

## Value ISO20022.Sese013001.InvestmentAccount69


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Svcr|ISO20022.Sese013001.PartyIdentification132||XmlElement()||
|+|AcctNm|String||XmlElement()||
|+|Dsgnt|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Svcr))|

---

## Enum ISO20022.Sese013001.InvestmentFundFee1Code


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

## Enum ISO20022.Sese013001.InvestmentFundRole2Code


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

## Value ISO20022.Sese013001.LumpSumType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.LumpSumType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UFPL|Int32||XmlEnum("""UFPL""")|1|
||PCLS|Int32||XmlEnum("""PCLS""")|2|
||DEAB|Int32||XmlEnum("""DEAB""")|3|

---

## Value ISO20022.Sese013001.MarketPracticeVersion1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nb|String||XmlElement()||
|+|Dt|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese013001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese013001.MoneyPurchaseAnnualAllowance1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrggrdDt|DateTime||XmlElement()||
|+|Trggrd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese013001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Sese013001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Sese013001.NamePrefix1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MADM|Int32||XmlEnum("""MADM""")|1|
||MISS|Int32||XmlEnum("""MISS""")|2|
||MIST|Int32||XmlEnum("""MIST""")|3|
||DOCT|Int32||XmlEnum("""DOCT""")|4|

---

## Value ISO20022.Sese013001.Organisation36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpInvstrAdr|ISO20022.Sese013001.PostalAddress1||XmlElement()||
|+|NtlRegnNb|String||XmlElement()||
|+|TaxIdNb|String||XmlElement()||
|+|RegnDt|DateTime||XmlElement()||
|+|RegnCtry|String||XmlElement()||
|+|TaxtnCtry|String||XmlElement()||
|+|Purp|String||XmlElement()||
|+|Id|ISO20022.Sese013001.PartyIdentification140||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpInvstrAdr),validPattern("""RegnCtry""",RegnCtry,"""[A-Z]{2,2}"""),validPattern("""TaxtnCtry""",TaxtnCtry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese013001.OtherAmount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese013001.ActiveCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Sese013001.OtherAmountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Tp))|

---

## Value ISO20022.Sese013001.OtherAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese013001.ActiveCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Sese013001.GenericIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Tp))|

---

## Value ISO20022.Sese013001.OtherAmountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryCd|ISO20022.Sese013001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryCd),validChoice(PrtryCd,Cd))|

---

## Enum ISO20022.Sese013001.OtherAmountType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SINT|Int32||XmlEnum("""SINT""")|1|
||PINT|Int32||XmlEnum("""PINT""")|2|

---

## Value ISO20022.Sese013001.OtherAsset2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese013001.AdditionalInformation15>||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|OthrAsstTp|ISO20022.Sese013001.OtherAsset2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validListMax("""OthrId""",OthrId,5),validElement(OthrAsstTp))|

---

## Value ISO20022.Sese013001.OtherAsset2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.OtherAsset2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TIPP|Int32||XmlEnum("""TIPP""")|1|
||PROP|Int32||XmlEnum("""PROP""")|2|
||MOVE|Int32||XmlEnum("""MOVE""")|3|
||EXIA|Int32||XmlEnum("""EXIA""")|4|
||DIMA|Int32||XmlEnum("""DIMA""")|5|

---

## Value ISO20022.Sese013001.PartyIdentification122Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese013001.NameAndAddress5||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese013001.PartyIdentification123Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese013001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese013001.PartyIdentification125Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese013001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese013001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese013001.PartyIdentification126Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese013001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese013001.PartyIdentification132


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|PrtryId|ISO20022.Sese013001.GenericIdentification1||XmlElement()||
|+|NmAndAdr|ISO20022.Sese013001.NameAndAddress5||XmlElement()||
|+|ClrSysMmbId|ISO20022.Sese013001.ClearingSystemMemberIdentification2Choice||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(PrtryId),validElement(NmAndAdr),validElement(ClrSysMmbId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese013001.PartyIdentification139


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Sese013001.PartyIdentification125Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Sese013001.PartyIdentification140


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Sese013001.PartyIdentification126Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Sese013001.PartyIdentification141


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese013001.PartyTextInformation1||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese013001.DateAndDateTime2Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese013001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese013001.PartyIdentification122Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese013001.PartyIdentificationAndAccount194


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese013001.PartyTextInformation6||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese013001.DateAndDateTime2Choice||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese013001.SecuritiesAccount19||XmlElement()||
|+|AltrnId|ISO20022.Sese013001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese013001.PartyIdentification123Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PrcgDt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese013001.PartyTextInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese013001.PartyTextInformation6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnAdr|ISO20022.Sese013001.PostalAddress1||XmlElement()||
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RegnAdr))|

---

## Value ISO20022.Sese013001.PaymentInstrument14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtTrfDtls|ISO20022.Sese013001.CreditTransfer9||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtTrfDtls))|

---

## Value ISO20022.Sese013001.Pension5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese013001.AdditionalInformation15>||XmlElement()||
|+|NonWrpprTrf|String||XmlElement()||
|+|BnftCrstllstnEvtOcrd|String||XmlElement()||
|+|ClntLftmAllwncPrtcn|String||XmlElement()||
|+|LftmAllwncPrtcn|String||XmlElement()||
|+|NonSfgrddGrntedBnfts|String||XmlElement()||
|+|SfgrdBnft|String||XmlElement()||
|+|MnyPurchsAnlAllwnc|ISO20022.Sese013001.MoneyPurchaseAnnualAllowance1||XmlElement()||
|+|RingFncdDrwdwnAssts|String||XmlElement()||
|+|PnsnOrdr|global::System.Collections.Generic.List<ISO20022.Sese013001.PensionOrder1>||XmlElement()||
|+|LumpSumTp|global::System.Collections.Generic.List<ISO20022.Sese013001.LumpSumType1Choice>||XmlElement()||
|+|Shrg|String||XmlElement()||
|+|RtrmntAge|Decimal||XmlElement()||
|+|RtrmntAgePrtcn|String||XmlElement()||
|+|ValOfPnsnPlcyOrPlanOrSchme|ISO20022.Sese013001.DateAndAmount2||XmlElement()||
|+|TaxFreeCshAmt|ISO20022.Sese013001.DateAndAmount2||XmlElement()||
|+|TaxFreeCshPrtcn|String||XmlElement()||
|+|BlckTrfRef|String||XmlElement()||
|+|BlckTrf|String||XmlElement()||
|+|EstmtdVal|ISO20022.Sese013001.DateAndAmount2||XmlElement()||
|+|NbOfDrwdwnTrnchs|Decimal||XmlElement()||
|+|DrwdwnTp|ISO20022.Sese013001.DrawdownType2Choice||XmlElement()||
|+|DrwdwnSts|ISO20022.Sese013001.DrawdownStatus1Choice||XmlElement()||
|+|DrwdwnTrchId|String||XmlElement()||
|+|TaxRef|global::System.Collections.Generic.List<ISO20022.Sese013001.TaxReference1>||XmlElement()||
|+|TrfScp|ISO20022.Sese013001.PensionTransferScope1Choice||XmlElement()||
|+|Tp|ISO20022.Sese013001.PensionSchemeType3Choice||XmlElement()||
|+|Id|ISO20022.Sese013001.PensionPolicy1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(MnyPurchsAnlAllwnc),validList("""PnsnOrdr""",PnsnOrdr),validElement(PnsnOrdr),validList("""LumpSumTp""",LumpSumTp),validElement(LumpSumTp),validElement(ValOfPnsnPlcyOrPlanOrSchme),validElement(TaxFreeCshAmt),validElement(EstmtdVal),validElement(DrwdwnTp),validElement(DrwdwnSts),validList("""TaxRef""",TaxRef),validElement(TaxRef),validElement(TrfScp),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Sese013001.PensionOrder1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese013001.AdditionalInformation15>||XmlElement()||
|+|Tp|ISO20022.Sese013001.PensionOrderType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(Tp))|

---

## Value ISO20022.Sese013001.PensionOrderType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.PensionOrderType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHAR|Int32||XmlEnum("""SHAR""")|1|
||EARM|Int32||XmlEnum("""EARM""")|2|

---

## Value ISO20022.Sese013001.PensionPolicy1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese013001.AdditionalInformation15||XmlElement()||
|+|SubIdr|String||XmlElement()||
|+|Idr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf))|

---

## Value ISO20022.Sese013001.PensionSchemeType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.PensionSchemeType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NWRP|Int32||XmlEnum("""NWRP""")|1|
||SSAS|Int32||XmlEnum("""SSAS""")|2|
||SIPP|Int32||XmlEnum("""SIPP""")|3|
||S32A|Int32||XmlEnum("""S32A""")|4|
||SC32|Int32||XmlEnum("""SC32""")|5|
||REAN|Int32||XmlEnum("""REAN""")|6|
||ITPO|Int32||XmlEnum("""ITPO""")|7|
||EPKA|Int32||XmlEnum("""EPKA""")|8|
||PPNS|Int32||XmlEnum("""PPNS""")|9|
||OCDC|Int32||XmlEnum("""OCDC""")|10|
||OTPM|Int32||XmlEnum("""OTPM""")|11|
||STKI|Int32||XmlEnum("""STKI""")|12|
||IPST|Int32||XmlEnum("""IPST""")|13|
||STKG|Int32||XmlEnum("""STKG""")|14|
||SIPG|Int32||XmlEnum("""SIPG""")|15|
||GPPS|Int32||XmlEnum("""GPPS""")|16|
||FAVC|Int32||XmlEnum("""FAVC""")|17|
||EXPP|Int32||XmlEnum("""EXPP""")|18|
||DBEN|Int32||XmlEnum("""DBEN""")|19|
||AAVC|Int32||XmlEnum("""AAVC""")|20|

---

## Value ISO20022.Sese013001.PensionTransferScope1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.PensionTransferScope1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UCRY|Int32||XmlEnum("""UCRY""")|1|
||FULP|Int32||XmlEnum("""FULP""")|2|
||SDDT|Int32||XmlEnum("""SDDT""")|3|
||CRYS|Int32||XmlEnum("""CRYS""")|4|

---

## Enum ISO20022.Sese013001.PersonIdentificationType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ITIN|Int32||XmlEnum("""ITIN""")|1|
||GTIN|Int32||XmlEnum("""GTIN""")|2|
||ATIN|Int32||XmlEnum("""ATIN""")|3|

---

## Value ISO20022.Sese013001.PortfolioTransfer10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese013001.AdditionalInformation15>||XmlElement()||
|+|FinInstrmAsstForTrf|global::System.Collections.Generic.List<ISO20022.Sese013001.FinancialInstrument100>||XmlElement()||
|+|PmtDtls|ISO20022.Sese013001.PaymentInstrument14||XmlElement()||
|+|TaxDt|DateTime||XmlElement()||
|+|RsdlCsh|global::System.Collections.Generic.List<ISO20022.Sese013001.ResidualCash2>||XmlElement()||
|+|CshAll|global::System.Collections.Generic.List<ISO20022.Sese013001.CashAll1>||XmlElement()||
|+|AllOthrCsh|global::System.Collections.Generic.List<ISO20022.Sese013001.AllOtherCash1>||XmlElement()||
|+|Prtfl|ISO20022.Sese013001.FundPortfolio7Choice||XmlElement()||
|+|ActlTrfDt|DateTime||XmlElement()||
|+|TrfConfId|String||XmlElement()||
|+|TrfInstrRef|String||XmlElement()||
|+|MstrRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validList("""FinInstrmAsstForTrf""",FinInstrmAsstForTrf),validElement(FinInstrmAsstForTrf),validElement(PmtDtls),validList("""RsdlCsh""",RsdlCsh),validElement(RsdlCsh),validList("""CshAll""",CshAll),validElement(CshAll),validList("""AllOthrCsh""",AllOthrCsh),validElement(AllOthrCsh),validElement(Prtfl))|

---

## Aspect ISO20022.Sese013001.PortfolioTransferConfirmationV11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xtnsn|global::System.Collections.Generic.List<ISO20022.Sese013001.Extension1>||XmlElement()||
|+|MktPrctcVrsn|ISO20022.Sese013001.MarketPracticeVersion1||XmlElement()||
|+|PdctTrf|global::System.Collections.Generic.List<ISO20022.Sese013001.PortfolioTransfer10>||XmlElement()||
|+|Trfee|ISO20022.Sese013001.PartyIdentification132||XmlElement()||
|+|NmneeAcct|ISO20022.Sese013001.InvestmentAccount69||XmlElement()||
|+|TrfrAcct|ISO20022.Sese013001.InvestmentAccount69||XmlElement()||
|+|OthrCorpInvstr|global::System.Collections.Generic.List<ISO20022.Sese013001.Organisation36>||XmlElement()||
|+|ScndryCorpInvstr|ISO20022.Sese013001.Organisation36||XmlElement()||
|+|PmryCorpInvstr|ISO20022.Sese013001.Organisation36||XmlElement()||
|+|OthrIndvInvstr|global::System.Collections.Generic.List<ISO20022.Sese013001.IndividualPerson8>||XmlElement()||
|+|ScndryIndvInvstr|ISO20022.Sese013001.IndividualPerson8||XmlElement()||
|+|RegdHldr|ISO20022.Sese013001.IndividualPerson8||XmlElement()||
|+|PmryIndvInvstr|ISO20022.Sese013001.IndividualPerson8||XmlElement()||
|+|RltdRef|ISO20022.Sese013001.AdditionalReference10||XmlElement()||
|+|PrvsRef|ISO20022.Sese013001.AdditionalReference10||XmlElement()||
|+|PoolRef|ISO20022.Sese013001.AdditionalReference11||XmlElement()||
|+|MsgRef|ISO20022.Sese013001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(MktPrctcVrsn),validRequired("""PdctTrf""",PdctTrf),validList("""PdctTrf""",PdctTrf),validElement(PdctTrf),validElement(Trfee),validElement(NmneeAcct),validElement(TrfrAcct),validList("""OthrCorpInvstr""",OthrCorpInvstr),validElement(OthrCorpInvstr),validElement(ScndryCorpInvstr),validElement(PmryCorpInvstr),validList("""OthrIndvInvstr""",OthrIndvInvstr),validElement(OthrIndvInvstr),validElement(ScndryIndvInvstr),validElement(RegdHldr),validElement(PmryIndvInvstr),validElement(RltdRef),validElement(PrvsRef),validElement(PoolRef),validElement(MsgRef))|

---

## Enum ISO20022.Sese013001.PortfolioWithdrawalReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FTRS|Int32||XmlEnum("""FTRS""")|1|

---

## Value ISO20022.Sese013001.PostalAddress1


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

## Value ISO20022.Sese013001.PostalAddress6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|SubDept|String||XmlElement()||
|+|Dept|String||XmlElement()||
|+|AdrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Sese013001.PreviousYear1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SpcfcPrvsYrs|global::System.Collections.Generic.List<Int32>||XmlElement()||
|+|AllPrvsYrs|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""SpcfcPrvsYrs""",SpcfcPrvsYrs),validPattern("""AllPrvsYrs""",AllPrvsYrs,"""ALL"""),validChoice(SpcfcPrvsYrs,AllPrvsYrs))|

---

## Value ISO20022.Sese013001.PreviousYear4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshCmpntInd|String||XmlElement()||
|+|PrvsYrs|ISO20022.Sese013001.PreviousYear1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvsYrs))|

---

## Enum ISO20022.Sese013001.PriceMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HIST|Int32||XmlEnum("""HIST""")|1|
||FORW|Int32||XmlEnum("""FORW""")|2|

---

## Value ISO20022.Sese013001.PriceValue1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Sese013001.Quantity47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrAsst|String||XmlElement()||
|+|CshAmt|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|PctgRate|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshAmt))|

---

## Value ISO20022.Sese013001.ResidualCash2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese013001.Role4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Sese013001.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Value ISO20022.Sese013001.SafekeepingPlaceFormat28Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Sese013001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Sese013001.SafekeepingPlaceTypeAndText6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Sese013001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese013001.SafekeepingPlaceTypeAndText6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese013001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese013001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese013001.SecurityIdentification25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPrtryId|ISO20022.Sese013001.AlternateSecurityIdentification7||XmlElement()||
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

## Value ISO20022.Sese013001.SettlementParties94


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese013001.PartyIdentificationAndAccount194||XmlElement()||
|+|Pty4|ISO20022.Sese013001.PartyIdentificationAndAccount194||XmlElement()||
|+|Pty3|ISO20022.Sese013001.PartyIdentificationAndAccount194||XmlElement()||
|+|Pty2|ISO20022.Sese013001.PartyIdentificationAndAccount194||XmlElement()||
|+|Pty1|ISO20022.Sese013001.PartyIdentificationAndAccount194||XmlElement()||
|+|Dpstry|ISO20022.Sese013001.PartyIdentification141||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Sese013001.SettlementTransactionCondition11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOMC|Int32||XmlEnum("""NOMC""")|1|

---

## Value ISO20022.Sese013001.SettlementTransactionCondition30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese013001.SubAccount5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Chrtc|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese013001.SubscriptionInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlAmtYrToDt|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|CshCmpnt|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|EqtyCmpnt|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|DtOfFrstSbcpt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlAmtYrToDt),validElement(CshCmpnt),validElement(EqtyCmpnt))|

---

## Value ISO20022.Sese013001.Tax35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxClctnDtls|ISO20022.Sese013001.TaxCalculationInformation10||XmlElement()||
|+|RcptId|ISO20022.Sese013001.PartyIdentification139||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|ApldRate|Decimal||XmlElement()||
|+|ApldAmt|ISO20022.Sese013001.ActiveCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Sese013001.TaxType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxClctnDtls),validElement(RcptId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(ApldAmt),validElement(Tp))|

---

## Value ISO20022.Sese013001.Tax36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese013001.AdditionalInformation15>||XmlElement()||
|+|DtOrPrd|ISO20022.Sese013001.DateQuarter1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(DtOrPrd))|

---

## Value ISO20022.Sese013001.TaxBasis1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese013001.TaxCalculationInformation10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxblAmt|ISO20022.Sese013001.ActiveCurrencyAndAmount||XmlElement()||
|+|Bsis|ISO20022.Sese013001.TaxBasis1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxblAmt),validElement(Bsis))|

---

## Value ISO20022.Sese013001.TaxEfficientProduct7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Sese013001.AdditionalInformation15>||XmlElement()||
|+|EstmtdVal|ISO20022.Sese013001.DateAndAmount2||XmlElement()||
|+|CurInvstmtAmt|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|UusdTaxDdctn|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|TaxClctnBase|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|LwstInvstdAmtCurYr|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|InnvtvFinc|global::System.Collections.Generic.List<ISO20022.Sese013001.InnovativeFinance1>||XmlElement()||
|+|InvstmtsToFllwVal|global::System.Collections.Generic.List<ISO20022.Sese013001.DateAndAmount2>||XmlElement()||
|+|InvstrTaxRef|ISO20022.Sese013001.TaxReference2||XmlElement()||
|+|DtFrstQlfygAddtn|DateTime||XmlElement()||
|+|OthrAmt|global::System.Collections.Generic.List<ISO20022.Sese013001.OtherAmount3>||XmlElement()||
|+|TtlSbcptAmt|ISO20022.Sese013001.ActiveCurrencyAndAmount||XmlElement()||
|+|TrfrAltrnId|String||XmlElement()||
|+|WdrwlForResdtlPurchsPrgrs|String||XmlElement()||
|+|BnsOrWdrwl|global::System.Collections.Generic.List<ISO20022.Sese013001.BonusWithdrawal2>||XmlElement()||
|+|CurYrSbcptDtls|ISO20022.Sese013001.SubscriptionInformation2||XmlElement()||
|+|DtOfFrstSbcpt|DateTime||XmlElement()||
|+|PrvsYrsSbcptAmt|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|PrvsYrSbcptAmt|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|PrvsYrs|ISO20022.Sese013001.PreviousYear4||XmlElement()||
|+|CshCmpntInd|String||XmlElement()||
|+|CurYr|String||XmlElement()||
|+|TaxEffcntPdctTp|ISO20022.Sese013001.TaxEfficientProductType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(EstmtdVal),validElement(CurInvstmtAmt),validElement(UusdTaxDdctn),validElement(TaxClctnBase),validElement(LwstInvstdAmtCurYr),validList("""InnvtvFinc""",InnvtvFinc),validElement(InnvtvFinc),validList("""InvstmtsToFllwVal""",InvstmtsToFllwVal),validElement(InvstmtsToFllwVal),validElement(InvstrTaxRef),validList("""OthrAmt""",OthrAmt),validElement(OthrAmt),validElement(TtlSbcptAmt),validList("""BnsOrWdrwl""",BnsOrWdrwl),validElement(BnsOrWdrwl),validElement(CurYrSbcptDtls),validElement(PrvsYrsSbcptAmt),validElement(PrvsYrSbcptAmt),validElement(PrvsYrs),validElement(TaxEffcntPdctTp))|

---

## Value ISO20022.Sese013001.TaxEfficientProductType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.TaxEfficientProductType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EQUI|Int32||XmlEnum("""EQUI""")|1|
||SCTF|Int32||XmlEnum("""SCTF""")|2|
||CCTF|Int32||XmlEnum("""CCTF""")|3|
||LISA|Int32||XmlEnum("""LISA""")|4|
||JISA|Int32||XmlEnum("""JISA""")|5|
||JCSH|Int32||XmlEnum("""JCSH""")|6|
||INNF|Int32||XmlEnum("""INNF""")|7|
||HISA|Int32||XmlEnum("""HISA""")|8|
||GASK|Int32||XmlEnum("""GASK""")|9|
||GISK|Int32||XmlEnum("""GISK""")|10|
||FISA|Int32||XmlEnum("""FISA""")|11|
||CLIS|Int32||XmlEnum("""CLIS""")|12|
||CASH|Int32||XmlEnum("""CASH""")|13|

---

## Value ISO20022.Sese013001.TaxReference1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HldrTp|ISO20022.Sese013001.TaxReferenceParty1Choice||XmlElement()||
|+|Ref|String||XmlElement()||
|+|TaxTp|ISO20022.Sese013001.TaxReferenceType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(HldrTp),validElement(TaxTp))|

---

## Value ISO20022.Sese013001.TaxReference2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|String||XmlElement()||
|+|Tp|ISO20022.Sese013001.TaxReferenceType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese013001.TaxReferenceParty1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese013001.TaxReferenceType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.TaxType17Code


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

## Value ISO20022.Sese013001.TaxType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.TaxWrapperAmountType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WTHD|Int32||XmlEnum("""WTHD""")|1|
||BONU|Int32||XmlEnum("""BONU""")|2|

---

## Value ISO20022.Sese013001.TaxableIncomePerShareCalculated2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.TaxableIncomePerShareCalculated2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||TSIN|Int32||XmlEnum("""TSIN""")|2|
||TSIY|Int32||XmlEnum("""TSIY""")|3|

---

## Enum ISO20022.Sese013001.TaxationBasis2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PERU|Int32||XmlEnum("""PERU""")|1|
||FLAT|Int32||XmlEnum("""FLAT""")|2|

---

## Enum ISO20022.Sese013001.TaxationBasis5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PERU|Int32||XmlEnum("""PERU""")|1|
||NAVP|Int32||XmlEnum("""NAVP""")|2|
||NEAM|Int32||XmlEnum("""NEAM""")|3|
||GRAM|Int32||XmlEnum("""GRAM""")|4|
||FLAT|Int32||XmlEnum("""FLAT""")|5|

---

## Value ISO20022.Sese013001.TotalFeesAndTaxes41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndvTax|global::System.Collections.Generic.List<ISO20022.Sese013001.Tax35>||XmlElement()||
|+|IndvFee|global::System.Collections.Generic.List<ISO20022.Sese013001.Fee5>||XmlElement()||
|+|ComrclAgrmtRef|String||XmlElement()||
|+|TtlTaxs|ISO20022.Sese013001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlFees|ISO20022.Sese013001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlOvrhdApld|ISO20022.Sese013001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""IndvTax""",IndvTax),validElement(IndvTax),validList("""IndvFee""",IndvFee),validElement(IndvFee),validElement(TtlTaxs),validElement(TtlFees),validElement(TtlOvrhdApld))|

---

## Enum ISO20022.Sese013001.TradeTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CCPN|Int32||XmlEnum("""CCPN""")|1|
||XCPN|Int32||XmlEnum("""XCPN""")|2|

---

## Value ISO20022.Sese013001.TradeTransactionCondition8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese013001.TransferType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.TransferType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SECU|Int32||XmlEnum("""SECU""")|1|
||EXCL|Int32||XmlEnum("""EXCL""")|2|
||CONV|Int32||XmlEnum("""CONV""")|3|
||CASH|Int32||XmlEnum("""CASH""")|4|

---

## Value ISO20022.Sese013001.TypeOfAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.TypeOfIdentification1Code


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

## Enum ISO20022.Sese013001.TypeOfPrice10Code


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

## Value ISO20022.Sese013001.TypeOfPrice46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese013001.UKTaxGroupUnit1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GRP2|Int32||XmlEnum("""GRP2""")|1|
||GRP1|Int32||XmlEnum("""GRP1""")|2|

---

## Value ISO20022.Sese013001.Unit11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrAmt|global::System.Collections.Generic.List<ISO20022.Sese013001.OtherAmount1>||XmlElement()||
|+|TxOvrhd|ISO20022.Sese013001.TotalFeesAndTaxes41||XmlElement()||
|+|PricDtls|ISO20022.Sese013001.UnitPrice23||XmlElement()||
|+|Ref|String||XmlElement()||
|+|Grp1Or2Units|String||XmlElement()||
|+|CertNb|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AcqstnDt|DateTime||XmlElement()||
|+|OrdrDt|DateTime||XmlElement()||
|+|UnitsNb|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrAmt""",OthrAmt),validElement(OthrAmt),validElement(TxOvrhd),validElement(PricDtls))|

---

## Value ISO20022.Sese013001.UnitPrice23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxblIncmPerShrClctd|ISO20022.Sese013001.TaxableIncomePerShareCalculated2Choice||XmlElement()||
|+|TaxblIncmPerShr|ISO20022.Sese013001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|AcrdIntrstNAV|ISO20022.Sese013001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|PricMtd|String||XmlElement()||
|+|Val|ISO20022.Sese013001.PriceValue1||XmlElement()||
|+|Tp|ISO20022.Sese013001.TypeOfPrice46Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxblIncmPerShrClctd),validElement(TaxblIncmPerShr),validElement(AcrdIntrstNAV),validElement(Val),validElement(Tp))|

---

## Enum ISO20022.Sese013001.WaivingInstruction1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WIUN|Int32||XmlEnum("""WIUN""")|1|
||WICA|Int32||XmlEnum("""WICA""")|2|

---

## Value ISO20022.Sese013001.WaivingInstruction2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese013001.WithdrawalReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese013001.GenericIdentification36||XmlElement()||
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

