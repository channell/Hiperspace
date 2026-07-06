# setr.013.001.04
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Setr013001.Account22 {
        + AcctSvcr  : ISO20022.Setr013001.PartyIdentification113
        + Id  : String
    }
    ISO20022.Setr013001.Account22 *-- ISO20022.Setr013001.PartyIdentification113
    class ISO20022.Setr013001.AccountIdentification4Choice {
        + Othr  : ISO20022.Setr013001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Setr013001.AccountIdentification4Choice *-- ISO20022.Setr013001.GenericAccountIdentification1
    class ISO20022.Setr013001.AccountIdentificationAndName5 {
        + Nm  : String
        + Id  : ISO20022.Setr013001.AccountIdentification4Choice
    }
    ISO20022.Setr013001.AccountIdentificationAndName5 *-- ISO20022.Setr013001.AccountIdentification4Choice
    class ISO20022.Setr013001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Setr013001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Setr013001.AdditionalAmount1Choice {
        + RsltgCshOut  : ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount
        + AddtlCshIn  : ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Setr013001.AdditionalAmount1Choice *-- ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Setr013001.AdditionalAmount1Choice *-- ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Setr013001.AdditionalReference8 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Setr013001.PartyIdentification113
        + Ref  : String
    }
    ISO20022.Setr013001.AdditionalReference8 *-- ISO20022.Setr013001.PartyIdentification113
    class ISO20022.Setr013001.AdditionalReference9 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Setr013001.PartyIdentification113
        + Ref  : String
    }
    ISO20022.Setr013001.AdditionalReference9 *-- ISO20022.Setr013001.PartyIdentification113
    class ISO20022.Setr013001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Setr013001.AlternateSecurityIdentification7 {
        + IdSrc  : ISO20022.Setr013001.IdentificationSource1Choice
        + Id  : String
    }
    ISO20022.Setr013001.AlternateSecurityIdentification7 *-- ISO20022.Setr013001.IdentificationSource1Choice
    class ISO20022.Setr013001.BranchData {
        + PstlAdr  : ISO20022.Setr013001.PostalAddress1
        + Nm  : String
        + Id  : String
    }
    ISO20022.Setr013001.BranchData *-- ISO20022.Setr013001.PostalAddress1
    class ISO20022.Setr013001.CancellationRight1Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr013001.CancellationRight1Choice *-- ISO20022.Setr013001.GenericIdentification47
    class ISO20022.Setr013001.CancellationRight1Code {
        NOIN = 1
        NOWA = 2
        NOXO = 3
        VALI = 4
    }
    class ISO20022.Setr013001.CardType1Code {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Setr013001.CashInOrOut7Choice {
        + CshOutPmtInstrm  : ISO20022.Setr013001.PaymentInstrument21Choice
        + CshInPmtInstrm  : ISO20022.Setr013001.PaymentInstrument20Choice
    }
    ISO20022.Setr013001.CashInOrOut7Choice *-- ISO20022.Setr013001.PaymentInstrument21Choice
    ISO20022.Setr013001.CashInOrOut7Choice *-- ISO20022.Setr013001.PaymentInstrument20Choice
    class ISO20022.Setr013001.ChargeBasis2Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr013001.ChargeBasis2Choice *-- ISO20022.Setr013001.GenericIdentification47
    class ISO20022.Setr013001.ChargeOrCommissionDiscount1 {
        + Bsis  : ISO20022.Setr013001.WaivingInstruction2Choice
        + Rate  : Decimal
        + Amt  : ISO20022.Setr013001.ActiveCurrencyAndAmount
    }
    ISO20022.Setr013001.ChargeOrCommissionDiscount1 *-- ISO20022.Setr013001.WaivingInstruction2Choice
    ISO20022.Setr013001.ChargeOrCommissionDiscount1 *-- ISO20022.Setr013001.ActiveCurrencyAndAmount
    class ISO20022.Setr013001.ChargeType5Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr013001.ChargeType5Choice *-- ISO20022.Setr013001.GenericIdentification47
    class ISO20022.Setr013001.Cheque9 {
        + DrwrId  : ISO20022.Setr013001.PartyIdentification113
        + DrweeId  : ISO20022.Setr013001.FinancialInstitutionIdentification10
        + PyeeId  : ISO20022.Setr013001.PartyIdentification113
        + Nb  : String
    }
    ISO20022.Setr013001.Cheque9 *-- ISO20022.Setr013001.PartyIdentification113
    ISO20022.Setr013001.Cheque9 *-- ISO20022.Setr013001.FinancialInstitutionIdentification10
    ISO20022.Setr013001.Cheque9 *-- ISO20022.Setr013001.PartyIdentification113
    class ISO20022.Setr013001.ClearingSystemMemberIdentificationChoice {
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
    class ISO20022.Setr013001.ConductClassification1Code {
        STAN = 1
        RCLT = 2
        NSTA = 3
    }
    class ISO20022.Setr013001.CopyInformation4 {
        + OrgnlRcvr  : String
        + CpyInd  : String
    }
    class ISO20022.Setr013001.CreditTransfer8 {
        + CdtrAcct  : ISO20022.Setr013001.AccountIdentificationAndName5
        + Cdtr  : ISO20022.Setr013001.PartyIdentification113
        + CdtrAgtAcct  : ISO20022.Setr013001.AccountIdentificationAndName5
        + CdtrAgt  : ISO20022.Setr013001.FinancialInstitutionIdentification10
        + IntrmyAgt2Acct  : ISO20022.Setr013001.AccountIdentificationAndName5
        + IntrmyAgt2  : ISO20022.Setr013001.FinancialInstitutionIdentification10
        + IntrmyAgt1Acct  : ISO20022.Setr013001.AccountIdentificationAndName5
        + IntrmyAgt1  : ISO20022.Setr013001.FinancialInstitutionIdentification10
        + DbtrAgtAcct  : ISO20022.Setr013001.AccountIdentificationAndName5
        + DbtrAgt  : ISO20022.Setr013001.FinancialInstitutionIdentification10
        + DbtrAcct  : ISO20022.Setr013001.AccountIdentificationAndName5
        + Dbtr  : ISO20022.Setr013001.PartyIdentification113
        + Ref  : String
    }
    ISO20022.Setr013001.CreditTransfer8 *-- ISO20022.Setr013001.AccountIdentificationAndName5
    ISO20022.Setr013001.CreditTransfer8 *-- ISO20022.Setr013001.PartyIdentification113
    ISO20022.Setr013001.CreditTransfer8 *-- ISO20022.Setr013001.AccountIdentificationAndName5
    ISO20022.Setr013001.CreditTransfer8 *-- ISO20022.Setr013001.FinancialInstitutionIdentification10
    ISO20022.Setr013001.CreditTransfer8 *-- ISO20022.Setr013001.AccountIdentificationAndName5
    ISO20022.Setr013001.CreditTransfer8 *-- ISO20022.Setr013001.FinancialInstitutionIdentification10
    ISO20022.Setr013001.CreditTransfer8 *-- ISO20022.Setr013001.AccountIdentificationAndName5
    ISO20022.Setr013001.CreditTransfer8 *-- ISO20022.Setr013001.FinancialInstitutionIdentification10
    ISO20022.Setr013001.CreditTransfer8 *-- ISO20022.Setr013001.AccountIdentificationAndName5
    ISO20022.Setr013001.CreditTransfer8 *-- ISO20022.Setr013001.FinancialInstitutionIdentification10
    ISO20022.Setr013001.CreditTransfer8 *-- ISO20022.Setr013001.AccountIdentificationAndName5
    ISO20022.Setr013001.CreditTransfer8 *-- ISO20022.Setr013001.PartyIdentification113
    class ISO20022.Setr013001.CustomerConductClassification1Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr013001.CustomerConductClassification1Choice *-- ISO20022.Setr013001.GenericIdentification47
    class ISO20022.Setr013001.DateAndDateTimeChoice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Setr013001.DateFormat42Choice {
        + YrMnthDay  : DateTime
        + YrMnth  : String
    }
    class ISO20022.Setr013001.DeliveringPartiesAndAccount16 {
        + DlvrgAgtDtls  : ISO20022.Setr013001.PartyIdentificationAndAccount147
        + DlvrrsIntrmy2Dtls  : ISO20022.Setr013001.PartyIdentificationAndAccount147
        + DlvrrsIntrmy1Dtls  : ISO20022.Setr013001.PartyIdentificationAndAccount147
        + DlvrrsCtdnDtls  : ISO20022.Setr013001.PartyIdentificationAndAccount147
    }
    ISO20022.Setr013001.DeliveringPartiesAndAccount16 *-- ISO20022.Setr013001.PartyIdentificationAndAccount147
    ISO20022.Setr013001.DeliveringPartiesAndAccount16 *-- ISO20022.Setr013001.PartyIdentificationAndAccount147
    ISO20022.Setr013001.DeliveringPartiesAndAccount16 *-- ISO20022.Setr013001.PartyIdentificationAndAccount147
    ISO20022.Setr013001.DeliveringPartiesAndAccount16 *-- ISO20022.Setr013001.PartyIdentificationAndAccount147
    class ISO20022.Setr013001.DeliveryParameters3 {
        + IssdCertNb  : String
        + Adr  : ISO20022.Setr013001.NameAndAddress4
    }
    ISO20022.Setr013001.DeliveryParameters3 *-- ISO20022.Setr013001.NameAndAddress4
    class ISO20022.Setr013001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Setr013001.DirectDebitMandate6 {
        + MndtId  : String
        + RegnId  : String
        + CdtrAgtBrnch  : ISO20022.Setr013001.BranchData
        + CdtrAgt  : ISO20022.Setr013001.FinancialInstitutionIdentification10
        + DbtrAgtBrnch  : ISO20022.Setr013001.BranchData
        + DbtrAgt  : ISO20022.Setr013001.FinancialInstitutionIdentification10
        + Cdtr  : ISO20022.Setr013001.PartyIdentification113
        + DbtrNtlRegnNb  : String
        + DbtrTaxIdNb  : String
        + Dbtr  : ISO20022.Setr013001.PartyIdentification113
        + DbtrAcct  : ISO20022.Setr013001.AccountIdentificationAndName5
    }
    ISO20022.Setr013001.DirectDebitMandate6 *-- ISO20022.Setr013001.BranchData
    ISO20022.Setr013001.DirectDebitMandate6 *-- ISO20022.Setr013001.FinancialInstitutionIdentification10
    ISO20022.Setr013001.DirectDebitMandate6 *-- ISO20022.Setr013001.BranchData
    ISO20022.Setr013001.DirectDebitMandate6 *-- ISO20022.Setr013001.FinancialInstitutionIdentification10
    ISO20022.Setr013001.DirectDebitMandate6 *-- ISO20022.Setr013001.PartyIdentification113
    ISO20022.Setr013001.DirectDebitMandate6 *-- ISO20022.Setr013001.PartyIdentification113
    ISO20022.Setr013001.DirectDebitMandate6 *-- ISO20022.Setr013001.AccountIdentificationAndName5
    class ISO20022.Setr013001.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class ISO20022.Setr013001.Equalisation1 {
        + Rate  : Decimal
        + Amt  : ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Setr013001.Equalisation1 *-- ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Setr013001.ExemptionReason1Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr013001.ExemptionReason1Choice *-- ISO20022.Setr013001.GenericIdentification47
    class ISO20022.Setr013001.Extension1 {
        + Txt  : String
        + PlcAndNm  : String
    }
    class ISO20022.Setr013001.Fee1 {
        + RcptId  : ISO20022.Setr013001.PartyIdentification113
        + NonStdSLARef  : String
        + ReqdRate  : Decimal
        + ReqdAmt  : ISO20022.Setr013001.ActiveCurrencyAndAmount
        + DscntDtls  : ISO20022.Setr013001.ChargeOrCommissionDiscount1
        + StdRate  : Decimal
        + StdAmt  : ISO20022.Setr013001.ActiveCurrencyAndAmount
        + Bsis  : ISO20022.Setr013001.ChargeBasis2Choice
        + Tp  : ISO20022.Setr013001.ChargeType5Choice
    }
    ISO20022.Setr013001.Fee1 *-- ISO20022.Setr013001.PartyIdentification113
    ISO20022.Setr013001.Fee1 *-- ISO20022.Setr013001.ActiveCurrencyAndAmount
    ISO20022.Setr013001.Fee1 *-- ISO20022.Setr013001.ChargeOrCommissionDiscount1
    ISO20022.Setr013001.Fee1 *-- ISO20022.Setr013001.ActiveCurrencyAndAmount
    ISO20022.Setr013001.Fee1 *-- ISO20022.Setr013001.ChargeBasis2Choice
    ISO20022.Setr013001.Fee1 *-- ISO20022.Setr013001.ChargeType5Choice
    class ISO20022.Setr013001.FeeAndTax1 {
        + IndvTax  : global::System.Collections.Generic.List~ISO20022.Setr013001.Tax30~
        + IndvFee  : global::System.Collections.Generic.List~ISO20022.Setr013001.Fee1~
        + ComrclAgrmtRef  : String
    }
    ISO20022.Setr013001.FeeAndTax1 *-- ISO20022.Setr013001.Tax30
    ISO20022.Setr013001.FeeAndTax1 *-- ISO20022.Setr013001.Fee1
    class ISO20022.Setr013001.FinancialAdvice1Code {
        UKWN = 1
        NREC = 2
        RECE = 3
    }
    class ISO20022.Setr013001.FinancialInstitutionIdentification10 {
        + LEI  : String
        + Pty  : ISO20022.Setr013001.FinancialInstitutionIdentification8Choice
    }
    ISO20022.Setr013001.FinancialInstitutionIdentification10 *-- ISO20022.Setr013001.FinancialInstitutionIdentification8Choice
    class ISO20022.Setr013001.FinancialInstitutionIdentification8Choice {
        + PrtryId  : String
        + ClrSysMmbId  : ISO20022.Setr013001.ClearingSystemMemberIdentificationChoice
        + BICFI  : String
        + NmAndAdr  : ISO20022.Setr013001.NameAndAddress5
    }
    ISO20022.Setr013001.FinancialInstitutionIdentification8Choice *-- ISO20022.Setr013001.ClearingSystemMemberIdentificationChoice
    ISO20022.Setr013001.FinancialInstitutionIdentification8Choice *-- ISO20022.Setr013001.NameAndAddress5
    class ISO20022.Setr013001.FinancialInstrument57 {
        + SrsId  : ISO20022.Setr013001.Series1
        + PdctGrp  : String
        + DstrbtnPlcy  : String
        + SctiesForm  : String
        + ClssTp  : String
        + SplmtryId  : String
        + ShrtNm  : String
        + Nm  : String
        + Id  : ISO20022.Setr013001.SecurityIdentification25Choice
    }
    ISO20022.Setr013001.FinancialInstrument57 *-- ISO20022.Setr013001.Series1
    ISO20022.Setr013001.FinancialInstrument57 *-- ISO20022.Setr013001.SecurityIdentification25Choice
    class ISO20022.Setr013001.FinancialInstrumentQuantity26Choice {
        + GrssAmt  : ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount
        + NetAmt  : ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount
        + PctgOfTtlRedAmt  : Decimal
        + UnitsNb  : Decimal
    }
    ISO20022.Setr013001.FinancialInstrumentQuantity26Choice *-- ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Setr013001.FinancialInstrumentQuantity26Choice *-- ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Setr013001.FinancialInstrumentQuantity29Choice {
        + HldgsRedRate  : Decimal
        + GrssAmt  : ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount
        + NetAmt  : ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount
        + PctgOfTtlSbcptAmt  : Decimal
        + UnitsNb  : Decimal
    }
    ISO20022.Setr013001.FinancialInstrumentQuantity29Choice *-- ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Setr013001.FinancialInstrumentQuantity29Choice *-- ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Setr013001.ForeignExchangeTerms32 {
        + QtgInstn  : ISO20022.Setr013001.PartyIdentification113
        + QtnDt  : DateTime
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Setr013001.ForeignExchangeTerms32 *-- ISO20022.Setr013001.PartyIdentification113
    class ISO20022.Setr013001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Setr013001.FundCashAccount2Code {
        SRSA = 1
        CPFS = 2
        CPFO = 3
        CASH = 4
    }
    class ISO20022.Setr013001.FundSettlementParameters11 {
        + DlvrgSdDtls  : ISO20022.Setr013001.DeliveringPartiesAndAccount16
        + RcvgSdDtls  : ISO20022.Setr013001.ReceivingPartiesAndAccount16
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Setr013001.SettlementTransactionCondition30Choice~
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Setr013001.TradeTransactionCondition8Choice~
        + SctiesSttlmSysId  : String
        + SfkpgPlc  : ISO20022.Setr013001.SafekeepingPlaceFormat8Choice
        + SttlmPlc  : ISO20022.Setr013001.PartyIdentification113
        + SttlmDt  : DateTime
    }
    ISO20022.Setr013001.FundSettlementParameters11 *-- ISO20022.Setr013001.DeliveringPartiesAndAccount16
    ISO20022.Setr013001.FundSettlementParameters11 *-- ISO20022.Setr013001.ReceivingPartiesAndAccount16
    ISO20022.Setr013001.FundSettlementParameters11 *-- ISO20022.Setr013001.SettlementTransactionCondition30Choice
    ISO20022.Setr013001.FundSettlementParameters11 *-- ISO20022.Setr013001.TradeTransactionCondition8Choice
    ISO20022.Setr013001.FundSettlementParameters11 *-- ISO20022.Setr013001.SafekeepingPlaceFormat8Choice
    ISO20022.Setr013001.FundSettlementParameters11 *-- ISO20022.Setr013001.PartyIdentification113
    class ISO20022.Setr013001.FundSettlementParameters12 {
        + DlvrgSdDtls  : ISO20022.Setr013001.DeliveringPartiesAndAccount16
        + RcvgSdDtls  : ISO20022.Setr013001.ReceivingPartiesAndAccount16
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Setr013001.SettlementTransactionCondition30Choice~
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Setr013001.TradeTransactionCondition8Choice~
        + SctiesSttlmSysId  : String
        + SfkpgPlc  : ISO20022.Setr013001.SafekeepingPlaceFormat8Choice
        + SttlmPlc  : ISO20022.Setr013001.PartyIdentification113
        + SttlmDt  : DateTime
    }
    ISO20022.Setr013001.FundSettlementParameters12 *-- ISO20022.Setr013001.DeliveringPartiesAndAccount16
    ISO20022.Setr013001.FundSettlementParameters12 *-- ISO20022.Setr013001.ReceivingPartiesAndAccount16
    ISO20022.Setr013001.FundSettlementParameters12 *-- ISO20022.Setr013001.SettlementTransactionCondition30Choice
    ISO20022.Setr013001.FundSettlementParameters12 *-- ISO20022.Setr013001.TradeTransactionCondition8Choice
    ISO20022.Setr013001.FundSettlementParameters12 *-- ISO20022.Setr013001.SafekeepingPlaceFormat8Choice
    ISO20022.Setr013001.FundSettlementParameters12 *-- ISO20022.Setr013001.PartyIdentification113
    class ISO20022.Setr013001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Setr013001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Setr013001.GenericAccountIdentification1 *-- ISO20022.Setr013001.AccountSchemeName1Choice
    class ISO20022.Setr013001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Setr013001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Setr013001.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Setr013001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Setr013001.GenericIdentification30
    }
    ISO20022.Setr013001.GenericIdentification78 *-- ISO20022.Setr013001.GenericIdentification30
    class ISO20022.Setr013001.IdentificationSource1Choice {
        + Prtry  : String
        + Dmst  : String
    }
    class ISO20022.Setr013001.IncomePreference1Code {
        DRIP = 1
        CASH = 2
    }
    class ISO20022.Setr013001.Intermediary40 {
        + Role  : ISO20022.Setr013001.InvestmentFundRole2Choice
        + OrdrOrgtrElgblty  : String
        + Acct  : ISO20022.Setr013001.Account22
        + Id  : ISO20022.Setr013001.PartyIdentification113
    }
    ISO20022.Setr013001.Intermediary40 *-- ISO20022.Setr013001.InvestmentFundRole2Choice
    ISO20022.Setr013001.Intermediary40 *-- ISO20022.Setr013001.Account22
    ISO20022.Setr013001.Intermediary40 *-- ISO20022.Setr013001.PartyIdentification113
    class ISO20022.Setr013001.InvestmentAccount58 {
        + SubAcctDtls  : ISO20022.Setr013001.SubAccount6
        + OrdrOrgtrElgblty  : String
        + AcctSvcr  : ISO20022.Setr013001.PartyIdentification113
        + OwnrId  : global::System.Collections.Generic.List~ISO20022.Setr013001.PartyIdentification113~
        + AcctDsgnt  : String
        + AcctNm  : String
        + AcctId  : String
    }
    ISO20022.Setr013001.InvestmentAccount58 *-- ISO20022.Setr013001.SubAccount6
    ISO20022.Setr013001.InvestmentAccount58 *-- ISO20022.Setr013001.PartyIdentification113
    ISO20022.Setr013001.InvestmentAccount58 *-- ISO20022.Setr013001.PartyIdentification113
    class ISO20022.Setr013001.InvestmentAccount60 {
        + Tp  : ISO20022.Setr013001.InvestmentAccountType1Choice
        + AcctId  : String
    }
    ISO20022.Setr013001.InvestmentAccount60 *-- ISO20022.Setr013001.InvestmentAccountType1Choice
    class ISO20022.Setr013001.InvestmentAccountType1Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr013001.InvestmentAccountType1Choice *-- ISO20022.Setr013001.GenericIdentification47
    class ISO20022.Setr013001.InvestmentFundFee1Code {
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
    class ISO20022.Setr013001.InvestmentFundRole2Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr013001.InvestmentFundRole2Choice *-- ISO20022.Setr013001.GenericIdentification47
    class ISO20022.Setr013001.InvestmentFundRole2Code {
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
    class ISO20022.Setr013001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Setr013001.NameAndAddress4 {
        + Adr  : ISO20022.Setr013001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Setr013001.NameAndAddress4 *-- ISO20022.Setr013001.PostalAddress1
    class ISO20022.Setr013001.NameAndAddress5 {
        + Adr  : ISO20022.Setr013001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Setr013001.NameAndAddress5 *-- ISO20022.Setr013001.PostalAddress1
    class ISO20022.Setr013001.NegotiatedTrade1Code {
        UNKW = 1
        NNGO = 2
        NEGO = 3
    }
    class ISO20022.Setr013001.OrderOriginatorEligibility1Code {
        PROF = 1
        RETL = 2
        ELIG = 3
    }
    class ISO20022.Setr013001.OrderWaiver1 {
        + InfVal  : String
        + OrdrWvrRsn  : global::System.Collections.Generic.List~ISO20022.Setr013001.OrderWaiverReason3Choice~
    }
    ISO20022.Setr013001.OrderWaiver1 *-- ISO20022.Setr013001.OrderWaiverReason3Choice
    class ISO20022.Setr013001.OrderWaiverReason1Code {
        COMW = 1
        CUTO = 2
        BMIN = 3
        FEND = 4
        LATE = 5
    }
    class ISO20022.Setr013001.OrderWaiverReason3Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr013001.OrderWaiverReason3Choice *-- ISO20022.Setr013001.GenericIdentification47
    class ISO20022.Setr013001.Pagination {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Setr013001.PartyIdentification113 {
        + LEI  : String
        + Pty  : ISO20022.Setr013001.PartyIdentification90Choice
    }
    ISO20022.Setr013001.PartyIdentification113 *-- ISO20022.Setr013001.PartyIdentification90Choice
    class ISO20022.Setr013001.PartyIdentification90Choice {
        + NmAndAdr  : ISO20022.Setr013001.NameAndAddress5
        + PrtryId  : ISO20022.Setr013001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Setr013001.PartyIdentification90Choice *-- ISO20022.Setr013001.NameAndAddress5
    ISO20022.Setr013001.PartyIdentification90Choice *-- ISO20022.Setr013001.GenericIdentification1
    class ISO20022.Setr013001.PartyIdentificationAndAccount147 {
        + AcctId  : String
        + PtyId  : ISO20022.Setr013001.PartyIdentification113
    }
    ISO20022.Setr013001.PartyIdentificationAndAccount147 *-- ISO20022.Setr013001.PartyIdentification113
    class ISO20022.Setr013001.PaymentCard25 {
        + SeqNb  : String
        + SctyCd  : String
        + CardIssrId  : ISO20022.Setr013001.PartyIdentification113
        + CardIssrNm  : String
        + XpryDt  : String
        + StartDt  : String
        + HldrNm  : String
        + Nb  : String
        + Tp  : String
    }
    ISO20022.Setr013001.PaymentCard25 *-- ISO20022.Setr013001.PartyIdentification113
    class ISO20022.Setr013001.PaymentInstrument20Choice {
        + CshAcctDtls  : ISO20022.Setr013001.InvestmentAccount60
        + BkrsDrftDtls  : ISO20022.Setr013001.Cheque9
        + ChqDtls  : ISO20022.Setr013001.Cheque9
        + DrctDbtDtls  : ISO20022.Setr013001.DirectDebitMandate6
        + CdtTrfDtls  : ISO20022.Setr013001.CreditTransfer8
        + PmtCardDtls  : ISO20022.Setr013001.PaymentCard25
    }
    ISO20022.Setr013001.PaymentInstrument20Choice *-- ISO20022.Setr013001.InvestmentAccount60
    ISO20022.Setr013001.PaymentInstrument20Choice *-- ISO20022.Setr013001.Cheque9
    ISO20022.Setr013001.PaymentInstrument20Choice *-- ISO20022.Setr013001.Cheque9
    ISO20022.Setr013001.PaymentInstrument20Choice *-- ISO20022.Setr013001.DirectDebitMandate6
    ISO20022.Setr013001.PaymentInstrument20Choice *-- ISO20022.Setr013001.CreditTransfer8
    ISO20022.Setr013001.PaymentInstrument20Choice *-- ISO20022.Setr013001.PaymentCard25
    class ISO20022.Setr013001.PaymentInstrument21Choice {
        + CshAcctDtls  : ISO20022.Setr013001.InvestmentAccount60
        + BkrsDrftDtls  : ISO20022.Setr013001.Cheque9
        + ChqDtls  : ISO20022.Setr013001.Cheque9
        + CdtTrfDtls  : ISO20022.Setr013001.CreditTransfer8
    }
    ISO20022.Setr013001.PaymentInstrument21Choice *-- ISO20022.Setr013001.InvestmentAccount60
    ISO20022.Setr013001.PaymentInstrument21Choice *-- ISO20022.Setr013001.Cheque9
    ISO20022.Setr013001.PaymentInstrument21Choice *-- ISO20022.Setr013001.Cheque9
    ISO20022.Setr013001.PaymentInstrument21Choice *-- ISO20022.Setr013001.CreditTransfer8
    class ISO20022.Setr013001.PaymentTransaction71 {
        + CshInOrOut  : ISO20022.Setr013001.CashInOrOut7Choice
    }
    ISO20022.Setr013001.PaymentTransaction71 *-- ISO20022.Setr013001.CashInOrOut7Choice
    class ISO20022.Setr013001.PlaceOfTradeIdentification1Choice {
        + OverTheCntr  : String
        + Pty  : String
        + Xchg  : String
        + Ctry  : String
    }
    class ISO20022.Setr013001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Setr013001.ReceivingPartiesAndAccount16 {
        + RcvgAgtDtls  : ISO20022.Setr013001.PartyIdentificationAndAccount147
        + RcvrsIntrmy2Dtls  : ISO20022.Setr013001.PartyIdentificationAndAccount147
        + RcvrsIntrmy1Dtls  : ISO20022.Setr013001.PartyIdentificationAndAccount147
        + RcvrsCtdnDtls  : ISO20022.Setr013001.PartyIdentificationAndAccount147
    }
    ISO20022.Setr013001.ReceivingPartiesAndAccount16 *-- ISO20022.Setr013001.PartyIdentificationAndAccount147
    ISO20022.Setr013001.ReceivingPartiesAndAccount16 *-- ISO20022.Setr013001.PartyIdentificationAndAccount147
    ISO20022.Setr013001.ReceivingPartiesAndAccount16 *-- ISO20022.Setr013001.PartyIdentificationAndAccount147
    ISO20022.Setr013001.ReceivingPartiesAndAccount16 *-- ISO20022.Setr013001.PartyIdentificationAndAccount147
    class ISO20022.Setr013001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Setr013001.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Setr013001.SafekeepingPlaceFormat8Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification78
        + TpAndId  : ISO20022.Setr013001.SafekeepingPlaceTypeAndAnyBICIdentifier1
        + Ctry  : String
        + Id  : ISO20022.Setr013001.SafekeepingPlaceTypeAndText6
    }
    ISO20022.Setr013001.SafekeepingPlaceFormat8Choice *-- ISO20022.Setr013001.GenericIdentification78
    ISO20022.Setr013001.SafekeepingPlaceFormat8Choice *-- ISO20022.Setr013001.SafekeepingPlaceTypeAndAnyBICIdentifier1
    ISO20022.Setr013001.SafekeepingPlaceFormat8Choice *-- ISO20022.Setr013001.SafekeepingPlaceTypeAndText6
    class ISO20022.Setr013001.SafekeepingPlaceTypeAndAnyBICIdentifier1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Setr013001.SafekeepingPlaceTypeAndText6 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Setr013001.SecurityIdentification25Choice {
        + OthrPrtryId  : ISO20022.Setr013001.AlternateSecurityIdentification7
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
    ISO20022.Setr013001.SecurityIdentification25Choice *-- ISO20022.Setr013001.AlternateSecurityIdentification7
    class ISO20022.Setr013001.Series1 {
        + SrsNm  : String
        + SrsDt  : ISO20022.Setr013001.DateFormat42Choice
    }
    ISO20022.Setr013001.Series1 *-- ISO20022.Setr013001.DateFormat42Choice
    class ISO20022.Setr013001.SettlementTransactionCondition11Code {
        NOMC = 1
    }
    class ISO20022.Setr013001.SettlementTransactionCondition30Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr013001.SettlementTransactionCondition30Choice *-- ISO20022.Setr013001.GenericIdentification30
    class ISO20022.Setr013001.SignatureType1Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr013001.SignatureType1Choice *-- ISO20022.Setr013001.GenericIdentification47
    class ISO20022.Setr013001.SignatureType2Code {
        ORIG = 1
        NONE = 2
        ELEC = 3
        DIGI = 4
    }
    class ISO20022.Setr013001.SubAccount6 {
        + AcctDsgnt  : String
        + Chrtc  : String
        + Nm  : String
        + Id  : String
    }
    class ISO20022.Setr013001.SwitchOrder7 {
        + OrdrWvrDtls  : ISO20022.Setr013001.OrderWaiver1
        + SgntrTp  : ISO20022.Setr013001.SignatureType1Choice
        + TxChanlTp  : ISO20022.Setr013001.TransactionChannelType1Choice
        + CstmrCndctClssfctn  : ISO20022.Setr013001.CustomerConductClassification1Choice
        + NgtdTrad  : String
        + FinAdvc  : String
        + FXDtls  : ISO20022.Setr013001.ForeignExchangeTerms32
        + CshSttlmDtls  : ISO20022.Setr013001.PaymentTransaction71
        + SbcptLegDtls  : global::System.Collections.Generic.List~ISO20022.Setr013001.SwitchSubscriptionLegOrder6~
        + RedLegDtls  : global::System.Collections.Generic.List~ISO20022.Setr013001.SwitchRedemptionLegOrder6~
        + CxlRght  : ISO20022.Setr013001.CancellationRight1Choice
        + XpryDtTm  : ISO20022.Setr013001.DateAndDateTimeChoice
        + AddtlAmt  : ISO20022.Setr013001.AdditionalAmount1Choice
        + SttlmMtd  : String
        + CshSttlmDt  : DateTime
        + SttlmAmt  : ISO20022.Setr013001.ActiveCurrencyAndAmount
        + ReqdFutrTradDt  : DateTime
        + RltdPtyDtls  : global::System.Collections.Generic.List~ISO20022.Setr013001.Intermediary40~
        + InvstmtAcctDtls  : ISO20022.Setr013001.InvestmentAccount58
        + ClntRef  : String
        + OrdrRef  : String
        + PlcOfTrad  : ISO20022.Setr013001.PlaceOfTradeIdentification1Choice
        + OrdrDtTm  : DateTime
        + MstrRef  : String
    }
    ISO20022.Setr013001.SwitchOrder7 *-- ISO20022.Setr013001.OrderWaiver1
    ISO20022.Setr013001.SwitchOrder7 *-- ISO20022.Setr013001.SignatureType1Choice
    ISO20022.Setr013001.SwitchOrder7 *-- ISO20022.Setr013001.TransactionChannelType1Choice
    ISO20022.Setr013001.SwitchOrder7 *-- ISO20022.Setr013001.CustomerConductClassification1Choice
    ISO20022.Setr013001.SwitchOrder7 *-- ISO20022.Setr013001.ForeignExchangeTerms32
    ISO20022.Setr013001.SwitchOrder7 *-- ISO20022.Setr013001.PaymentTransaction71
    ISO20022.Setr013001.SwitchOrder7 *-- ISO20022.Setr013001.SwitchSubscriptionLegOrder6
    ISO20022.Setr013001.SwitchOrder7 *-- ISO20022.Setr013001.SwitchRedemptionLegOrder6
    ISO20022.Setr013001.SwitchOrder7 *-- ISO20022.Setr013001.CancellationRight1Choice
    ISO20022.Setr013001.SwitchOrder7 *-- ISO20022.Setr013001.DateAndDateTimeChoice
    ISO20022.Setr013001.SwitchOrder7 *-- ISO20022.Setr013001.AdditionalAmount1Choice
    ISO20022.Setr013001.SwitchOrder7 *-- ISO20022.Setr013001.ActiveCurrencyAndAmount
    ISO20022.Setr013001.SwitchOrder7 *-- ISO20022.Setr013001.Intermediary40
    ISO20022.Setr013001.SwitchOrder7 *-- ISO20022.Setr013001.InvestmentAccount58
    ISO20022.Setr013001.SwitchOrder7 *-- ISO20022.Setr013001.PlaceOfTradeIdentification1Choice
    class ISO20022.Setr013001.SwitchOrderV04 {
        + Xtnsn  : global::System.Collections.Generic.List~ISO20022.Setr013001.Extension1~
        + CpyDtls  : ISO20022.Setr013001.CopyInformation4
        + SwtchOrdrDtls  : global::System.Collections.Generic.List~ISO20022.Setr013001.SwitchOrder7~
        + MsgPgntn  : ISO20022.Setr013001.Pagination
        + PrvsRef  : global::System.Collections.Generic.List~ISO20022.Setr013001.AdditionalReference8~
        + PoolRef  : ISO20022.Setr013001.AdditionalReference9
        + MsgId  : ISO20022.Setr013001.MessageIdentification1
    }
    ISO20022.Setr013001.SwitchOrderV04 *-- ISO20022.Setr013001.Extension1
    ISO20022.Setr013001.SwitchOrderV04 *-- ISO20022.Setr013001.CopyInformation4
    ISO20022.Setr013001.SwitchOrderV04 *-- ISO20022.Setr013001.SwitchOrder7
    ISO20022.Setr013001.SwitchOrderV04 *-- ISO20022.Setr013001.Pagination
    ISO20022.Setr013001.SwitchOrderV04 *-- ISO20022.Setr013001.AdditionalReference8
    ISO20022.Setr013001.SwitchOrderV04 *-- ISO20022.Setr013001.AdditionalReference9
    ISO20022.Setr013001.SwitchOrderV04 *-- ISO20022.Setr013001.MessageIdentification1
    class ISO20022.Setr013001.SwitchRedemptionLegOrder6 {
        + Equlstn  : ISO20022.Setr013001.Equalisation1
        + NonStdSttlmInf  : String
        + PhysDlvryDtls  : ISO20022.Setr013001.DeliveryParameters3
        + PhysDlvryInd  : String
        + SttlmAndCtdyDtls  : ISO20022.Setr013001.FundSettlementParameters12
        + TxOvrhd  : ISO20022.Setr013001.FeeAndTax1
        + ReqdNAVCcy  : String
        + ReqdSttlmCcy  : String
        + Grp1Or2Units  : String
        + IncmPref  : String
        + InvstmtAcctDtls  : ISO20022.Setr013001.InvestmentAccount58
        + FinInstrmQtyChc  : ISO20022.Setr013001.FinancialInstrumentQuantity29Choice
        + FinInstrmDtls  : ISO20022.Setr013001.FinancialInstrument57
        + LegId  : String
    }
    ISO20022.Setr013001.SwitchRedemptionLegOrder6 *-- ISO20022.Setr013001.Equalisation1
    ISO20022.Setr013001.SwitchRedemptionLegOrder6 *-- ISO20022.Setr013001.DeliveryParameters3
    ISO20022.Setr013001.SwitchRedemptionLegOrder6 *-- ISO20022.Setr013001.FundSettlementParameters12
    ISO20022.Setr013001.SwitchRedemptionLegOrder6 *-- ISO20022.Setr013001.FeeAndTax1
    ISO20022.Setr013001.SwitchRedemptionLegOrder6 *-- ISO20022.Setr013001.InvestmentAccount58
    ISO20022.Setr013001.SwitchRedemptionLegOrder6 *-- ISO20022.Setr013001.FinancialInstrumentQuantity29Choice
    ISO20022.Setr013001.SwitchRedemptionLegOrder6 *-- ISO20022.Setr013001.FinancialInstrument57
    class ISO20022.Setr013001.SwitchSubscriptionLegOrder6 {
        + Equlstn  : ISO20022.Setr013001.Equalisation1
        + NonStdSttlmInf  : String
        + PhysDlvryDtls  : ISO20022.Setr013001.NameAndAddress4
        + PhysDlvryInd  : String
        + SttlmAndCtdyDtls  : ISO20022.Setr013001.FundSettlementParameters11
        + TxOvrhd  : ISO20022.Setr013001.FeeAndTax1
        + ReqdNAVCcy  : String
        + ReqdSttlmCcy  : String
        + IncmPref  : String
        + InvstmtAcctDtls  : ISO20022.Setr013001.InvestmentAccount58
        + FinInstrmQtyChc  : ISO20022.Setr013001.FinancialInstrumentQuantity26Choice
        + FinInstrmDtls  : ISO20022.Setr013001.FinancialInstrument57
        + LegId  : String
    }
    ISO20022.Setr013001.SwitchSubscriptionLegOrder6 *-- ISO20022.Setr013001.Equalisation1
    ISO20022.Setr013001.SwitchSubscriptionLegOrder6 *-- ISO20022.Setr013001.NameAndAddress4
    ISO20022.Setr013001.SwitchSubscriptionLegOrder6 *-- ISO20022.Setr013001.FundSettlementParameters11
    ISO20022.Setr013001.SwitchSubscriptionLegOrder6 *-- ISO20022.Setr013001.FeeAndTax1
    ISO20022.Setr013001.SwitchSubscriptionLegOrder6 *-- ISO20022.Setr013001.InvestmentAccount58
    ISO20022.Setr013001.SwitchSubscriptionLegOrder6 *-- ISO20022.Setr013001.FinancialInstrumentQuantity26Choice
    ISO20022.Setr013001.SwitchSubscriptionLegOrder6 *-- ISO20022.Setr013001.FinancialInstrument57
    class ISO20022.Setr013001.Tax30 {
        + TaxClctnDtls  : ISO20022.Setr013001.TaxCalculationInformation9
        + RcptId  : ISO20022.Setr013001.PartyIdentification113
        + XmptnRsn  : ISO20022.Setr013001.ExemptionReason1Choice
        + XmptnInd  : String
        + Ctry  : String
        + Tax  : ISO20022.Setr013001.TaxAmountOrRate4Choice
        + Tp  : ISO20022.Setr013001.TaxType3Choice
    }
    ISO20022.Setr013001.Tax30 *-- ISO20022.Setr013001.TaxCalculationInformation9
    ISO20022.Setr013001.Tax30 *-- ISO20022.Setr013001.PartyIdentification113
    ISO20022.Setr013001.Tax30 *-- ISO20022.Setr013001.ExemptionReason1Choice
    ISO20022.Setr013001.Tax30 *-- ISO20022.Setr013001.TaxAmountOrRate4Choice
    ISO20022.Setr013001.Tax30 *-- ISO20022.Setr013001.TaxType3Choice
    class ISO20022.Setr013001.TaxAmountOrRate4Choice {
        + Rate  : Decimal
        + Amt  : ISO20022.Setr013001.ActiveCurrencyAndAmount
    }
    ISO20022.Setr013001.TaxAmountOrRate4Choice *-- ISO20022.Setr013001.ActiveCurrencyAndAmount
    class ISO20022.Setr013001.TaxBasis1Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr013001.TaxBasis1Choice *-- ISO20022.Setr013001.GenericIdentification47
    class ISO20022.Setr013001.TaxCalculationInformation9 {
        + Bsis  : ISO20022.Setr013001.TaxBasis1Choice
    }
    ISO20022.Setr013001.TaxCalculationInformation9 *-- ISO20022.Setr013001.TaxBasis1Choice
    class ISO20022.Setr013001.TaxExemptReason1Code {
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
    class ISO20022.Setr013001.TaxType17Code {
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
    class ISO20022.Setr013001.TaxType3Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr013001.TaxType3Choice *-- ISO20022.Setr013001.GenericIdentification47
    class ISO20022.Setr013001.TaxationBasis2Code {
        PERU = 1
        FLAT = 2
    }
    class ISO20022.Setr013001.TaxationBasis5Code {
        PERU = 1
        NAVP = 2
        NEAM = 3
        GRAM = 4
        FLAT = 5
    }
    class ISO20022.Setr013001.TradeTransactionCondition5Code {
        CCPN = 1
        XCPN = 2
    }
    class ISO20022.Setr013001.TradeTransactionCondition8Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr013001.TradeTransactionCondition8Choice *-- ISO20022.Setr013001.GenericIdentification30
    class ISO20022.Setr013001.TransactionChannel2Code {
        BRAN = 1
        HOBA = 2
        FIAD = 3
    }
    class ISO20022.Setr013001.TransactionChannelType1Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr013001.TransactionChannelType1Choice *-- ISO20022.Setr013001.GenericIdentification47
    class ISO20022.Setr013001.UKTaxGroupUnit1Code {
        GRP2 = 1
        GRP1 = 2
    }
    class ISO20022.Setr013001.WaivingInstruction1Code {
        WIUN = 1
        WICA = 2
    }
    class ISO20022.Setr013001.WaivingInstruction2Choice {
        + Prtry  : ISO20022.Setr013001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr013001.WaivingInstruction2Choice *-- ISO20022.Setr013001.GenericIdentification47
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

## Value ISO20022.Setr013001.Account22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcr))|

---

## Value ISO20022.Setr013001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Setr013001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Setr013001.AccountIdentificationAndName5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Setr013001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Setr013001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr013001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Setr013001.AdditionalAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgCshOut|ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|AddtlCshIn|ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgCshOut),validElement(AddtlCshIn),validChoice(RsltgCshOut,AddtlCshIn))|

---

## Value ISO20022.Setr013001.AdditionalReference8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Value ISO20022.Setr013001.AdditionalReference9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Enum ISO20022.Setr013001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Setr013001.AlternateSecurityIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdSrc|ISO20022.Setr013001.IdentificationSource1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdSrc))|

---

## Value ISO20022.Setr013001.BranchData


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Setr013001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr))|

---

## Value ISO20022.Setr013001.CancellationRight1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr013001.CancellationRight1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOIN|Int32||XmlEnum("""NOIN""")|1|
||NOWA|Int32||XmlEnum("""NOWA""")|2|
||NOXO|Int32||XmlEnum("""NOXO""")|3|
||VALI|Int32||XmlEnum("""VALI""")|4|

---

## Enum ISO20022.Setr013001.CardType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Setr013001.CashInOrOut7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshOutPmtInstrm|ISO20022.Setr013001.PaymentInstrument21Choice||XmlElement()||
|+|CshInPmtInstrm|ISO20022.Setr013001.PaymentInstrument20Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshOutPmtInstrm),validElement(CshInPmtInstrm),validChoice(CshOutPmtInstrm,CshInPmtInstrm))|

---

## Value ISO20022.Setr013001.ChargeBasis2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr013001.ChargeOrCommissionDiscount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bsis|ISO20022.Setr013001.WaivingInstruction2Choice||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Setr013001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bsis),validElement(Amt))|

---

## Value ISO20022.Setr013001.ChargeType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr013001.Cheque9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DrwrId|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|DrweeId|ISO20022.Setr013001.FinancialInstitutionIdentification10||XmlElement()||
|+|PyeeId|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DrwrId),validElement(DrweeId),validElement(PyeeId))|

---

## Value ISO20022.Setr013001.ClearingSystemMemberIdentificationChoice


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

## Enum ISO20022.Setr013001.ConductClassification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||STAN|Int32||XmlEnum("""STAN""")|1|
||RCLT|Int32||XmlEnum("""RCLT""")|2|
||NSTA|Int32||XmlEnum("""NSTA""")|3|

---

## Value ISO20022.Setr013001.CopyInformation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlRcvr|String||XmlElement()||
|+|CpyInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""OrgnlRcvr""",OrgnlRcvr,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Setr013001.CreditTransfer8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtrAcct|ISO20022.Setr013001.AccountIdentificationAndName5||XmlElement()||
|+|Cdtr|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|CdtrAgtAcct|ISO20022.Setr013001.AccountIdentificationAndName5||XmlElement()||
|+|CdtrAgt|ISO20022.Setr013001.FinancialInstitutionIdentification10||XmlElement()||
|+|IntrmyAgt2Acct|ISO20022.Setr013001.AccountIdentificationAndName5||XmlElement()||
|+|IntrmyAgt2|ISO20022.Setr013001.FinancialInstitutionIdentification10||XmlElement()||
|+|IntrmyAgt1Acct|ISO20022.Setr013001.AccountIdentificationAndName5||XmlElement()||
|+|IntrmyAgt1|ISO20022.Setr013001.FinancialInstitutionIdentification10||XmlElement()||
|+|DbtrAgtAcct|ISO20022.Setr013001.AccountIdentificationAndName5||XmlElement()||
|+|DbtrAgt|ISO20022.Setr013001.FinancialInstitutionIdentification10||XmlElement()||
|+|DbtrAcct|ISO20022.Setr013001.AccountIdentificationAndName5||XmlElement()||
|+|Dbtr|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtrAcct),validElement(Cdtr),validElement(CdtrAgtAcct),validElement(CdtrAgt),validElement(IntrmyAgt2Acct),validElement(IntrmyAgt2),validElement(IntrmyAgt1Acct),validElement(IntrmyAgt1),validElement(DbtrAgtAcct),validElement(DbtrAgt),validElement(DbtrAcct),validElement(Dbtr))|

---

## Value ISO20022.Setr013001.CustomerConductClassification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr013001.DateAndDateTimeChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Setr013001.DateFormat42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|YrMnthDay|DateTime||XmlElement()||
|+|YrMnth|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(YrMnthDay,YrMnth))|

---

## Value ISO20022.Setr013001.DeliveringPartiesAndAccount16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DlvrgAgtDtls|ISO20022.Setr013001.PartyIdentificationAndAccount147||XmlElement()||
|+|DlvrrsIntrmy2Dtls|ISO20022.Setr013001.PartyIdentificationAndAccount147||XmlElement()||
|+|DlvrrsIntrmy1Dtls|ISO20022.Setr013001.PartyIdentificationAndAccount147||XmlElement()||
|+|DlvrrsCtdnDtls|ISO20022.Setr013001.PartyIdentificationAndAccount147||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DlvrgAgtDtls),validElement(DlvrrsIntrmy2Dtls),validElement(DlvrrsIntrmy1Dtls),validElement(DlvrrsCtdnDtls))|

---

## Value ISO20022.Setr013001.DeliveryParameters3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IssdCertNb|String||XmlElement()||
|+|Adr|ISO20022.Setr013001.NameAndAddress4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Setr013001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Value ISO20022.Setr013001.DirectDebitMandate6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MndtId|String||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|CdtrAgtBrnch|ISO20022.Setr013001.BranchData||XmlElement()||
|+|CdtrAgt|ISO20022.Setr013001.FinancialInstitutionIdentification10||XmlElement()||
|+|DbtrAgtBrnch|ISO20022.Setr013001.BranchData||XmlElement()||
|+|DbtrAgt|ISO20022.Setr013001.FinancialInstitutionIdentification10||XmlElement()||
|+|Cdtr|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|DbtrNtlRegnNb|String||XmlElement()||
|+|DbtrTaxIdNb|String||XmlElement()||
|+|Dbtr|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|DbtrAcct|ISO20022.Setr013001.AccountIdentificationAndName5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtrAgtBrnch),validElement(CdtrAgt),validElement(DbtrAgtBrnch),validElement(DbtrAgt),validElement(Cdtr),validElement(Dbtr),validElement(DbtrAcct))|

---

## Enum ISO20022.Setr013001.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||DIST|Int32||XmlEnum("""DIST""")|2|

---

## Type ISO20022.Setr013001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SwtchOrdr|ISO20022.Setr013001.SwitchOrderV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SwtchOrdr))|

---

## Value ISO20022.Setr013001.Equalisation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Setr013001.ExemptionReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr013001.Extension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr013001.Fee1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcptId|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|NonStdSLARef|String||XmlElement()||
|+|ReqdRate|Decimal||XmlElement()||
|+|ReqdAmt|ISO20022.Setr013001.ActiveCurrencyAndAmount||XmlElement()||
|+|DscntDtls|ISO20022.Setr013001.ChargeOrCommissionDiscount1||XmlElement()||
|+|StdRate|Decimal||XmlElement()||
|+|StdAmt|ISO20022.Setr013001.ActiveCurrencyAndAmount||XmlElement()||
|+|Bsis|ISO20022.Setr013001.ChargeBasis2Choice||XmlElement()||
|+|Tp|ISO20022.Setr013001.ChargeType5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcptId),validElement(ReqdAmt),validElement(DscntDtls),validElement(StdAmt),validElement(Bsis),validElement(Tp))|

---

## Value ISO20022.Setr013001.FeeAndTax1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndvTax|global::System.Collections.Generic.List<ISO20022.Setr013001.Tax30>||XmlElement()||
|+|IndvFee|global::System.Collections.Generic.List<ISO20022.Setr013001.Fee1>||XmlElement()||
|+|ComrclAgrmtRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""IndvTax""",IndvTax),validElement(IndvTax),validList("""IndvFee""",IndvFee),validElement(IndvFee))|

---

## Enum ISO20022.Setr013001.FinancialAdvice1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||NREC|Int32||XmlEnum("""NREC""")|2|
||RECE|Int32||XmlEnum("""RECE""")|3|

---

## Value ISO20022.Setr013001.FinancialInstitutionIdentification10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Setr013001.FinancialInstitutionIdentification8Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Setr013001.FinancialInstitutionIdentification8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Setr013001.ClearingSystemMemberIdentificationChoice||XmlElement()||
|+|BICFI|String||XmlElement()||
|+|NmAndAdr|ISO20022.Setr013001.NameAndAddress5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validElement(NmAndAdr),validChoice(PrtryId,ClrSysMmbId,BICFI,NmAndAdr))|

---

## Value ISO20022.Setr013001.FinancialInstrument57


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrsId|ISO20022.Setr013001.Series1||XmlElement()||
|+|PdctGrp|String||XmlElement()||
|+|DstrbtnPlcy|String||XmlElement()||
|+|SctiesForm|String||XmlElement()||
|+|ClssTp|String||XmlElement()||
|+|SplmtryId|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Setr013001.SecurityIdentification25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SrsId),validElement(Id))|

---

## Value ISO20022.Setr013001.FinancialInstrumentQuantity26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GrssAmt|ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|NetAmt|ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|PctgOfTtlRedAmt|Decimal||XmlElement()||
|+|UnitsNb|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GrssAmt),validElement(NetAmt),validChoice(GrssAmt,NetAmt,PctgOfTtlRedAmt,UnitsNb))|

---

## Value ISO20022.Setr013001.FinancialInstrumentQuantity29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HldgsRedRate|Decimal||XmlElement()||
|+|GrssAmt|ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|NetAmt|ISO20022.Setr013001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|PctgOfTtlSbcptAmt|Decimal||XmlElement()||
|+|UnitsNb|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GrssAmt),validElement(NetAmt),validChoice(HldgsRedRate,GrssAmt,NetAmt,PctgOfTtlSbcptAmt,UnitsNb))|

---

## Value ISO20022.Setr013001.ForeignExchangeTerms32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtgInstn|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|QtnDt|DateTime||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtgInstn),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Setr013001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Enum ISO20022.Setr013001.FundCashAccount2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SRSA|Int32||XmlEnum("""SRSA""")|1|
||CPFS|Int32||XmlEnum("""CPFS""")|2|
||CPFO|Int32||XmlEnum("""CPFO""")|3|
||CASH|Int32||XmlEnum("""CASH""")|4|

---

## Value ISO20022.Setr013001.FundSettlementParameters11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DlvrgSdDtls|ISO20022.Setr013001.DeliveringPartiesAndAccount16||XmlElement()||
|+|RcvgSdDtls|ISO20022.Setr013001.ReceivingPartiesAndAccount16||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Setr013001.SettlementTransactionCondition30Choice>||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Setr013001.TradeTransactionCondition8Choice>||XmlElement()||
|+|SctiesSttlmSysId|String||XmlElement()||
|+|SfkpgPlc|ISO20022.Setr013001.SafekeepingPlaceFormat8Choice||XmlElement()||
|+|SttlmPlc|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|SttlmDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DlvrgSdDtls),validElement(RcvgSdDtls),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond),validElement(SfkpgPlc),validElement(SttlmPlc))|

---

## Value ISO20022.Setr013001.FundSettlementParameters12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DlvrgSdDtls|ISO20022.Setr013001.DeliveringPartiesAndAccount16||XmlElement()||
|+|RcvgSdDtls|ISO20022.Setr013001.ReceivingPartiesAndAccount16||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Setr013001.SettlementTransactionCondition30Choice>||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Setr013001.TradeTransactionCondition8Choice>||XmlElement()||
|+|SctiesSttlmSysId|String||XmlElement()||
|+|SfkpgPlc|ISO20022.Setr013001.SafekeepingPlaceFormat8Choice||XmlElement()||
|+|SttlmPlc|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|SttlmDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DlvrgSdDtls),validElement(RcvgSdDtls),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond),validElement(SfkpgPlc),validElement(SttlmPlc))|

---

## Value ISO20022.Setr013001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Setr013001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Setr013001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr013001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Setr013001.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Setr013001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Setr013001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Setr013001.IdentificationSource1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Dmst|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Dmst""",Dmst,"""[A-Z]{2,2}"""),validChoice(Prtry,Dmst))|

---

## Enum ISO20022.Setr013001.IncomePreference1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DRIP|Int32||XmlEnum("""DRIP""")|1|
||CASH|Int32||XmlEnum("""CASH""")|2|

---

## Value ISO20022.Setr013001.Intermediary40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Role|ISO20022.Setr013001.InvestmentFundRole2Choice||XmlElement()||
|+|OrdrOrgtrElgblty|String||XmlElement()||
|+|Acct|ISO20022.Setr013001.Account22||XmlElement()||
|+|Id|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Role),validElement(Acct),validElement(Id))|

---

## Value ISO20022.Setr013001.InvestmentAccount58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubAcctDtls|ISO20022.Setr013001.SubAccount6||XmlElement()||
|+|OrdrOrgtrElgblty|String||XmlElement()||
|+|AcctSvcr|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|OwnrId|global::System.Collections.Generic.List<ISO20022.Setr013001.PartyIdentification113>||XmlElement()||
|+|AcctDsgnt|String||XmlElement()||
|+|AcctNm|String||XmlElement()||
|+|AcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SubAcctDtls),validElement(AcctSvcr),validList("""OwnrId""",OwnrId),validElement(OwnrId))|

---

## Value ISO20022.Setr013001.InvestmentAccount60


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Setr013001.InvestmentAccountType1Choice||XmlElement()||
|+|AcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Setr013001.InvestmentAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr013001.InvestmentFundFee1Code


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

## Value ISO20022.Setr013001.InvestmentFundRole2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr013001.InvestmentFundRole2Code


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

## Value ISO20022.Setr013001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr013001.NameAndAddress4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Setr013001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Setr013001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Setr013001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Setr013001.NegotiatedTrade1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNKW|Int32||XmlEnum("""UNKW""")|1|
||NNGO|Int32||XmlEnum("""NNGO""")|2|
||NEGO|Int32||XmlEnum("""NEGO""")|3|

---

## Enum ISO20022.Setr013001.OrderOriginatorEligibility1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROF|Int32||XmlEnum("""PROF""")|1|
||RETL|Int32||XmlEnum("""RETL""")|2|
||ELIG|Int32||XmlEnum("""ELIG""")|3|

---

## Value ISO20022.Setr013001.OrderWaiver1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InfVal|String||XmlElement()||
|+|OrdrWvrRsn|global::System.Collections.Generic.List<ISO20022.Setr013001.OrderWaiverReason3Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OrdrWvrRsn""",OrdrWvrRsn),validElement(OrdrWvrRsn))|

---

## Enum ISO20022.Setr013001.OrderWaiverReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COMW|Int32||XmlEnum("""COMW""")|1|
||CUTO|Int32||XmlEnum("""CUTO""")|2|
||BMIN|Int32||XmlEnum("""BMIN""")|3|
||FEND|Int32||XmlEnum("""FEND""")|4|
||LATE|Int32||XmlEnum("""LATE""")|5|

---

## Value ISO20022.Setr013001.OrderWaiverReason3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr013001.Pagination


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Setr013001.PartyIdentification113


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Setr013001.PartyIdentification90Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Setr013001.PartyIdentification90Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Setr013001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Setr013001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Setr013001.PartyIdentificationAndAccount147


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctId|String||XmlElement()||
|+|PtyId|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyId))|

---

## Value ISO20022.Setr013001.PaymentCard25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SeqNb|String||XmlElement()||
|+|SctyCd|String||XmlElement()||
|+|CardIssrId|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|CardIssrNm|String||XmlElement()||
|+|XpryDt|String||XmlElement()||
|+|StartDt|String||XmlElement()||
|+|HldrNm|String||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CardIssrId))|

---

## Value ISO20022.Setr013001.PaymentInstrument20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshAcctDtls|ISO20022.Setr013001.InvestmentAccount60||XmlElement()||
|+|BkrsDrftDtls|ISO20022.Setr013001.Cheque9||XmlElement()||
|+|ChqDtls|ISO20022.Setr013001.Cheque9||XmlElement()||
|+|DrctDbtDtls|ISO20022.Setr013001.DirectDebitMandate6||XmlElement()||
|+|CdtTrfDtls|ISO20022.Setr013001.CreditTransfer8||XmlElement()||
|+|PmtCardDtls|ISO20022.Setr013001.PaymentCard25||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshAcctDtls),validElement(BkrsDrftDtls),validElement(ChqDtls),validElement(DrctDbtDtls),validElement(CdtTrfDtls),validElement(PmtCardDtls),validChoice(CshAcctDtls,BkrsDrftDtls,ChqDtls,DrctDbtDtls,CdtTrfDtls,PmtCardDtls))|

---

## Value ISO20022.Setr013001.PaymentInstrument21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshAcctDtls|ISO20022.Setr013001.InvestmentAccount60||XmlElement()||
|+|BkrsDrftDtls|ISO20022.Setr013001.Cheque9||XmlElement()||
|+|ChqDtls|ISO20022.Setr013001.Cheque9||XmlElement()||
|+|CdtTrfDtls|ISO20022.Setr013001.CreditTransfer8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshAcctDtls),validElement(BkrsDrftDtls),validElement(ChqDtls),validElement(CdtTrfDtls),validChoice(CshAcctDtls,BkrsDrftDtls,ChqDtls,CdtTrfDtls))|

---

## Value ISO20022.Setr013001.PaymentTransaction71


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshInOrOut|ISO20022.Setr013001.CashInOrOut7Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshInOrOut))|

---

## Value ISO20022.Setr013001.PlaceOfTradeIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OverTheCntr|String||XmlElement()||
|+|Pty|String||XmlElement()||
|+|Xchg|String||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Pty""",Pty,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validPattern("""Xchg""",Xchg,"""[A-Z0-9]{4,4}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validChoice(OverTheCntr,Pty,Xchg,Ctry))|

---

## Value ISO20022.Setr013001.PostalAddress1


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

## Value ISO20022.Setr013001.ReceivingPartiesAndAccount16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcvgAgtDtls|ISO20022.Setr013001.PartyIdentificationAndAccount147||XmlElement()||
|+|RcvrsIntrmy2Dtls|ISO20022.Setr013001.PartyIdentificationAndAccount147||XmlElement()||
|+|RcvrsIntrmy1Dtls|ISO20022.Setr013001.PartyIdentificationAndAccount147||XmlElement()||
|+|RcvrsCtdnDtls|ISO20022.Setr013001.PartyIdentificationAndAccount147||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcvgAgtDtls),validElement(RcvrsIntrmy2Dtls),validElement(RcvrsIntrmy1Dtls),validElement(RcvrsCtdnDtls))|

---

## Enum ISO20022.Setr013001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Setr013001.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Value ISO20022.Setr013001.SafekeepingPlaceFormat8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Setr013001.SafekeepingPlaceTypeAndAnyBICIdentifier1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Setr013001.SafekeepingPlaceTypeAndText6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Setr013001.SafekeepingPlaceTypeAndAnyBICIdentifier1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Setr013001.SafekeepingPlaceTypeAndText6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr013001.SecurityIdentification25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPrtryId|ISO20022.Setr013001.AlternateSecurityIdentification7||XmlElement()||
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

## Value ISO20022.Setr013001.Series1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrsNm|String||XmlElement()||
|+|SrsDt|ISO20022.Setr013001.DateFormat42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SrsDt))|

---

## Enum ISO20022.Setr013001.SettlementTransactionCondition11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOMC|Int32||XmlEnum("""NOMC""")|1|

---

## Value ISO20022.Setr013001.SettlementTransactionCondition30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr013001.SignatureType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr013001.SignatureType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ORIG|Int32||XmlEnum("""ORIG""")|1|
||NONE|Int32||XmlEnum("""NONE""")|2|
||ELEC|Int32||XmlEnum("""ELEC""")|3|
||DIGI|Int32||XmlEnum("""DIGI""")|4|

---

## Value ISO20022.Setr013001.SubAccount6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctDsgnt|String||XmlElement()||
|+|Chrtc|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr013001.SwitchOrder7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrdrWvrDtls|ISO20022.Setr013001.OrderWaiver1||XmlElement()||
|+|SgntrTp|ISO20022.Setr013001.SignatureType1Choice||XmlElement()||
|+|TxChanlTp|ISO20022.Setr013001.TransactionChannelType1Choice||XmlElement()||
|+|CstmrCndctClssfctn|ISO20022.Setr013001.CustomerConductClassification1Choice||XmlElement()||
|+|NgtdTrad|String||XmlElement()||
|+|FinAdvc|String||XmlElement()||
|+|FXDtls|ISO20022.Setr013001.ForeignExchangeTerms32||XmlElement()||
|+|CshSttlmDtls|ISO20022.Setr013001.PaymentTransaction71||XmlElement()||
|+|SbcptLegDtls|global::System.Collections.Generic.List<ISO20022.Setr013001.SwitchSubscriptionLegOrder6>||XmlElement()||
|+|RedLegDtls|global::System.Collections.Generic.List<ISO20022.Setr013001.SwitchRedemptionLegOrder6>||XmlElement()||
|+|CxlRght|ISO20022.Setr013001.CancellationRight1Choice||XmlElement()||
|+|XpryDtTm|ISO20022.Setr013001.DateAndDateTimeChoice||XmlElement()||
|+|AddtlAmt|ISO20022.Setr013001.AdditionalAmount1Choice||XmlElement()||
|+|SttlmMtd|String||XmlElement()||
|+|CshSttlmDt|DateTime||XmlElement()||
|+|SttlmAmt|ISO20022.Setr013001.ActiveCurrencyAndAmount||XmlElement()||
|+|ReqdFutrTradDt|DateTime||XmlElement()||
|+|RltdPtyDtls|global::System.Collections.Generic.List<ISO20022.Setr013001.Intermediary40>||XmlElement()||
|+|InvstmtAcctDtls|ISO20022.Setr013001.InvestmentAccount58||XmlElement()||
|+|ClntRef|String||XmlElement()||
|+|OrdrRef|String||XmlElement()||
|+|PlcOfTrad|ISO20022.Setr013001.PlaceOfTradeIdentification1Choice||XmlElement()||
|+|OrdrDtTm|DateTime||XmlElement()||
|+|MstrRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrdrWvrDtls),validElement(SgntrTp),validElement(TxChanlTp),validElement(CstmrCndctClssfctn),validElement(FXDtls),validElement(CshSttlmDtls),validRequired("""SbcptLegDtls""",SbcptLegDtls),validList("""SbcptLegDtls""",SbcptLegDtls),validElement(SbcptLegDtls),validRequired("""RedLegDtls""",RedLegDtls),validList("""RedLegDtls""",RedLegDtls),validElement(RedLegDtls),validElement(CxlRght),validElement(XpryDtTm),validElement(AddtlAmt),validElement(SttlmAmt),validList("""RltdPtyDtls""",RltdPtyDtls),validListMax("""RltdPtyDtls""",RltdPtyDtls,10),validElement(RltdPtyDtls),validElement(InvstmtAcctDtls),validElement(PlcOfTrad))|

---

## Aspect ISO20022.Setr013001.SwitchOrderV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xtnsn|global::System.Collections.Generic.List<ISO20022.Setr013001.Extension1>||XmlElement()||
|+|CpyDtls|ISO20022.Setr013001.CopyInformation4||XmlElement()||
|+|SwtchOrdrDtls|global::System.Collections.Generic.List<ISO20022.Setr013001.SwitchOrder7>||XmlElement()||
|+|MsgPgntn|ISO20022.Setr013001.Pagination||XmlElement()||
|+|PrvsRef|global::System.Collections.Generic.List<ISO20022.Setr013001.AdditionalReference8>||XmlElement()||
|+|PoolRef|ISO20022.Setr013001.AdditionalReference9||XmlElement()||
|+|MsgId|ISO20022.Setr013001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(CpyDtls),validRequired("""SwtchOrdrDtls""",SwtchOrdrDtls),validList("""SwtchOrdrDtls""",SwtchOrdrDtls),validElement(SwtchOrdrDtls),validElement(MsgPgntn),validList("""PrvsRef""",PrvsRef),validElement(PrvsRef),validElement(PoolRef),validElement(MsgId))|

---

## Value ISO20022.Setr013001.SwitchRedemptionLegOrder6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Equlstn|ISO20022.Setr013001.Equalisation1||XmlElement()||
|+|NonStdSttlmInf|String||XmlElement()||
|+|PhysDlvryDtls|ISO20022.Setr013001.DeliveryParameters3||XmlElement()||
|+|PhysDlvryInd|String||XmlElement()||
|+|SttlmAndCtdyDtls|ISO20022.Setr013001.FundSettlementParameters12||XmlElement()||
|+|TxOvrhd|ISO20022.Setr013001.FeeAndTax1||XmlElement()||
|+|ReqdNAVCcy|String||XmlElement()||
|+|ReqdSttlmCcy|String||XmlElement()||
|+|Grp1Or2Units|String||XmlElement()||
|+|IncmPref|String||XmlElement()||
|+|InvstmtAcctDtls|ISO20022.Setr013001.InvestmentAccount58||XmlElement()||
|+|FinInstrmQtyChc|ISO20022.Setr013001.FinancialInstrumentQuantity29Choice||XmlElement()||
|+|FinInstrmDtls|ISO20022.Setr013001.FinancialInstrument57||XmlElement()||
|+|LegId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Equlstn),validElement(PhysDlvryDtls),validElement(SttlmAndCtdyDtls),validElement(TxOvrhd),validPattern("""ReqdNAVCcy""",ReqdNAVCcy,"""[A-Z]{3,3}"""),validPattern("""ReqdSttlmCcy""",ReqdSttlmCcy,"""[A-Z]{3,3}"""),validElement(InvstmtAcctDtls),validElement(FinInstrmQtyChc),validElement(FinInstrmDtls))|

---

## Value ISO20022.Setr013001.SwitchSubscriptionLegOrder6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Equlstn|ISO20022.Setr013001.Equalisation1||XmlElement()||
|+|NonStdSttlmInf|String||XmlElement()||
|+|PhysDlvryDtls|ISO20022.Setr013001.NameAndAddress4||XmlElement()||
|+|PhysDlvryInd|String||XmlElement()||
|+|SttlmAndCtdyDtls|ISO20022.Setr013001.FundSettlementParameters11||XmlElement()||
|+|TxOvrhd|ISO20022.Setr013001.FeeAndTax1||XmlElement()||
|+|ReqdNAVCcy|String||XmlElement()||
|+|ReqdSttlmCcy|String||XmlElement()||
|+|IncmPref|String||XmlElement()||
|+|InvstmtAcctDtls|ISO20022.Setr013001.InvestmentAccount58||XmlElement()||
|+|FinInstrmQtyChc|ISO20022.Setr013001.FinancialInstrumentQuantity26Choice||XmlElement()||
|+|FinInstrmDtls|ISO20022.Setr013001.FinancialInstrument57||XmlElement()||
|+|LegId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Equlstn),validElement(PhysDlvryDtls),validElement(SttlmAndCtdyDtls),validElement(TxOvrhd),validPattern("""ReqdNAVCcy""",ReqdNAVCcy,"""[A-Z]{3,3}"""),validPattern("""ReqdSttlmCcy""",ReqdSttlmCcy,"""[A-Z]{3,3}"""),validElement(InvstmtAcctDtls),validElement(FinInstrmQtyChc),validElement(FinInstrmDtls))|

---

## Value ISO20022.Setr013001.Tax30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxClctnDtls|ISO20022.Setr013001.TaxCalculationInformation9||XmlElement()||
|+|RcptId|ISO20022.Setr013001.PartyIdentification113||XmlElement()||
|+|XmptnRsn|ISO20022.Setr013001.ExemptionReason1Choice||XmlElement()||
|+|XmptnInd|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Tax|ISO20022.Setr013001.TaxAmountOrRate4Choice||XmlElement()||
|+|Tp|ISO20022.Setr013001.TaxType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxClctnDtls),validElement(RcptId),validElement(XmptnRsn),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Tax),validElement(Tp))|

---

## Value ISO20022.Setr013001.TaxAmountOrRate4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Setr013001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Rate,Amt))|

---

## Value ISO20022.Setr013001.TaxBasis1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr013001.TaxCalculationInformation9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bsis|ISO20022.Setr013001.TaxBasis1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bsis))|

---

## Enum ISO20022.Setr013001.TaxExemptReason1Code


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

## Enum ISO20022.Setr013001.TaxType17Code


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

## Value ISO20022.Setr013001.TaxType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr013001.TaxationBasis2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PERU|Int32||XmlEnum("""PERU""")|1|
||FLAT|Int32||XmlEnum("""FLAT""")|2|

---

## Enum ISO20022.Setr013001.TaxationBasis5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PERU|Int32||XmlEnum("""PERU""")|1|
||NAVP|Int32||XmlEnum("""NAVP""")|2|
||NEAM|Int32||XmlEnum("""NEAM""")|3|
||GRAM|Int32||XmlEnum("""GRAM""")|4|
||FLAT|Int32||XmlEnum("""FLAT""")|5|

---

## Enum ISO20022.Setr013001.TradeTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CCPN|Int32||XmlEnum("""CCPN""")|1|
||XCPN|Int32||XmlEnum("""XCPN""")|2|

---

## Value ISO20022.Setr013001.TradeTransactionCondition8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr013001.TransactionChannel2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BRAN|Int32||XmlEnum("""BRAN""")|1|
||HOBA|Int32||XmlEnum("""HOBA""")|2|
||FIAD|Int32||XmlEnum("""FIAD""")|3|

---

## Value ISO20022.Setr013001.TransactionChannelType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr013001.UKTaxGroupUnit1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GRP2|Int32||XmlEnum("""GRP2""")|1|
||GRP1|Int32||XmlEnum("""GRP1""")|2|

---

## Enum ISO20022.Setr013001.WaivingInstruction1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WIUN|Int32||XmlEnum("""WIUN""")|1|
||WICA|Int32||XmlEnum("""WICA""")|2|

---

## Value ISO20022.Setr013001.WaivingInstruction2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr013001.GenericIdentification47||XmlElement()||
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

