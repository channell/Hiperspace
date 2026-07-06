# setr.012.001.05
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Setr012001.Account35 {
        + AcctSvcr  : ISO20022.Setr012001.PartyIdentification139
        + Id  : String
    }
    ISO20022.Setr012001.Account35 *-- ISO20022.Setr012001.PartyIdentification139
    class ISO20022.Setr012001.AccountIdentification4Choice {
        + Othr  : ISO20022.Setr012001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Setr012001.AccountIdentification4Choice *-- ISO20022.Setr012001.GenericAccountIdentification1
    class ISO20022.Setr012001.AccountIdentificationAndName5 {
        + Nm  : String
        + Id  : ISO20022.Setr012001.AccountIdentification4Choice
    }
    ISO20022.Setr012001.AccountIdentificationAndName5 *-- ISO20022.Setr012001.AccountIdentification4Choice
    class ISO20022.Setr012001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Setr012001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Setr012001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Setr012001.AdditionalReference10 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Setr012001.PartyIdentification139
        + Ref  : String
    }
    ISO20022.Setr012001.AdditionalReference10 *-- ISO20022.Setr012001.PartyIdentification139
    class ISO20022.Setr012001.AdditionalReference11 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Setr012001.PartyIdentification139
        + Ref  : String
    }
    ISO20022.Setr012001.AdditionalReference11 *-- ISO20022.Setr012001.PartyIdentification139
    class ISO20022.Setr012001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Setr012001.AlternateSecurityIdentification7 {
        + IdSrc  : ISO20022.Setr012001.IdentificationSource1Choice
        + Id  : String
    }
    ISO20022.Setr012001.AlternateSecurityIdentification7 *-- ISO20022.Setr012001.IdentificationSource1Choice
    class ISO20022.Setr012001.BestExecution1Code {
        BTEX = 1
    }
    class ISO20022.Setr012001.BranchData4 {
        + PstlAdr  : ISO20022.Setr012001.PostalAddress1
        + Nm  : String
        + Id  : String
    }
    ISO20022.Setr012001.BranchData4 *-- ISO20022.Setr012001.PostalAddress1
    class ISO20022.Setr012001.CancellationRight1Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.CancellationRight1Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.CancellationRight1Code {
        NOIN = 1
        NOWA = 2
        NOXO = 3
        VALI = 4
    }
    class ISO20022.Setr012001.CardType1Code {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Setr012001.ChargeBasis2Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.ChargeBasis2Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.ChargeOrCommissionDiscount1 {
        + Bsis  : ISO20022.Setr012001.WaivingInstruction2Choice
        + Rate  : Decimal
        + Amt  : ISO20022.Setr012001.ActiveCurrencyAndAmount
    }
    ISO20022.Setr012001.ChargeOrCommissionDiscount1 *-- ISO20022.Setr012001.WaivingInstruction2Choice
    ISO20022.Setr012001.ChargeOrCommissionDiscount1 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    class ISO20022.Setr012001.ChargeType5Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.ChargeType5Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.Cheque21 {
        + DrwrId  : ISO20022.Setr012001.PartyIdentification139
        + DrweeId  : ISO20022.Setr012001.FinancialInstitutionIdentification15
        + PyeeId  : ISO20022.Setr012001.PartyIdentification139
        + Nb  : String
    }
    ISO20022.Setr012001.Cheque21 *-- ISO20022.Setr012001.PartyIdentification139
    ISO20022.Setr012001.Cheque21 *-- ISO20022.Setr012001.FinancialInstitutionIdentification15
    ISO20022.Setr012001.Cheque21 *-- ISO20022.Setr012001.PartyIdentification139
    class ISO20022.Setr012001.ClearingSystemMemberIdentification4Choice {
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
    class ISO20022.Setr012001.ConductClassification1Code {
        STAN = 1
        RCLT = 2
        NSTA = 3
    }
    class ISO20022.Setr012001.CopyInformation5 {
        + OrgnlRcvr  : String
        + CpyInd  : String
    }
    class ISO20022.Setr012001.CountryAndResidentialStatusType2 {
        + ResdtlSts  : String
        + Ctry  : String
    }
    class ISO20022.Setr012001.CreditTransfer10 {
        + CdtrAcct  : ISO20022.Setr012001.AccountIdentificationAndName5
        + Cdtr  : ISO20022.Setr012001.PartyIdentification139
        + CdtrAgtAcct  : ISO20022.Setr012001.AccountIdentificationAndName5
        + CdtrAgt  : ISO20022.Setr012001.FinancialInstitutionIdentification15
        + IntrmyAgt2Acct  : ISO20022.Setr012001.AccountIdentificationAndName5
        + IntrmyAgt2  : ISO20022.Setr012001.FinancialInstitutionIdentification15
        + IntrmyAgt1Acct  : ISO20022.Setr012001.AccountIdentificationAndName5
        + IntrmyAgt1  : ISO20022.Setr012001.FinancialInstitutionIdentification15
        + DbtrAgtAcct  : ISO20022.Setr012001.AccountIdentificationAndName5
        + DbtrAgt  : ISO20022.Setr012001.FinancialInstitutionIdentification15
        + DbtrAcct  : ISO20022.Setr012001.AccountIdentificationAndName5
        + Dbtr  : ISO20022.Setr012001.PartyIdentification139
        + Ref  : String
    }
    ISO20022.Setr012001.CreditTransfer10 *-- ISO20022.Setr012001.AccountIdentificationAndName5
    ISO20022.Setr012001.CreditTransfer10 *-- ISO20022.Setr012001.PartyIdentification139
    ISO20022.Setr012001.CreditTransfer10 *-- ISO20022.Setr012001.AccountIdentificationAndName5
    ISO20022.Setr012001.CreditTransfer10 *-- ISO20022.Setr012001.FinancialInstitutionIdentification15
    ISO20022.Setr012001.CreditTransfer10 *-- ISO20022.Setr012001.AccountIdentificationAndName5
    ISO20022.Setr012001.CreditTransfer10 *-- ISO20022.Setr012001.FinancialInstitutionIdentification15
    ISO20022.Setr012001.CreditTransfer10 *-- ISO20022.Setr012001.AccountIdentificationAndName5
    ISO20022.Setr012001.CreditTransfer10 *-- ISO20022.Setr012001.FinancialInstitutionIdentification15
    ISO20022.Setr012001.CreditTransfer10 *-- ISO20022.Setr012001.AccountIdentificationAndName5
    ISO20022.Setr012001.CreditTransfer10 *-- ISO20022.Setr012001.FinancialInstitutionIdentification15
    ISO20022.Setr012001.CreditTransfer10 *-- ISO20022.Setr012001.AccountIdentificationAndName5
    ISO20022.Setr012001.CreditTransfer10 *-- ISO20022.Setr012001.PartyIdentification139
    class ISO20022.Setr012001.CustomerConductClassification1Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.CustomerConductClassification1Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Setr012001.DateFormat42Choice {
        + YrMnthDay  : DateTime
        + YrMnth  : String
    }
    class ISO20022.Setr012001.DeliveringPartiesAndAccount20 {
        + DlvrgAgtDtls  : ISO20022.Setr012001.PartyIdentificationAndAccount222
        + DlvrrsIntrmy2Dtls  : ISO20022.Setr012001.PartyIdentificationAndAccount222
        + DlvrrsIntrmy1Dtls  : ISO20022.Setr012001.PartyIdentificationAndAccount222
        + DlvrrsCtdnDtls  : ISO20022.Setr012001.PartyIdentificationAndAccount222
    }
    ISO20022.Setr012001.DeliveringPartiesAndAccount20 *-- ISO20022.Setr012001.PartyIdentificationAndAccount222
    ISO20022.Setr012001.DeliveringPartiesAndAccount20 *-- ISO20022.Setr012001.PartyIdentificationAndAccount222
    ISO20022.Setr012001.DeliveringPartiesAndAccount20 *-- ISO20022.Setr012001.PartyIdentificationAndAccount222
    ISO20022.Setr012001.DeliveringPartiesAndAccount20 *-- ISO20022.Setr012001.PartyIdentificationAndAccount222
    class ISO20022.Setr012001.DeliveryParameters3 {
        + IssdCertNb  : String
        + Adr  : ISO20022.Setr012001.NameAndAddress4
    }
    ISO20022.Setr012001.DeliveryParameters3 *-- ISO20022.Setr012001.NameAndAddress4
    class ISO20022.Setr012001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Setr012001.DirectDebitMandate8 {
        + MndtId  : String
        + RegnId  : String
        + CdtrAgtBrnch  : ISO20022.Setr012001.BranchData4
        + CdtrAgt  : ISO20022.Setr012001.FinancialInstitutionIdentification15
        + DbtrAgtBrnch  : ISO20022.Setr012001.BranchData4
        + DbtrAgt  : ISO20022.Setr012001.FinancialInstitutionIdentification15
        + Cdtr  : ISO20022.Setr012001.PartyIdentification139
        + DbtrNtlRegnNb  : String
        + DbtrTaxIdNb  : String
        + Dbtr  : ISO20022.Setr012001.PartyIdentification139
        + DbtrAcct  : ISO20022.Setr012001.AccountIdentificationAndName5
    }
    ISO20022.Setr012001.DirectDebitMandate8 *-- ISO20022.Setr012001.BranchData4
    ISO20022.Setr012001.DirectDebitMandate8 *-- ISO20022.Setr012001.FinancialInstitutionIdentification15
    ISO20022.Setr012001.DirectDebitMandate8 *-- ISO20022.Setr012001.BranchData4
    ISO20022.Setr012001.DirectDebitMandate8 *-- ISO20022.Setr012001.FinancialInstitutionIdentification15
    ISO20022.Setr012001.DirectDebitMandate8 *-- ISO20022.Setr012001.PartyIdentification139
    ISO20022.Setr012001.DirectDebitMandate8 *-- ISO20022.Setr012001.PartyIdentification139
    ISO20022.Setr012001.DirectDebitMandate8 *-- ISO20022.Setr012001.AccountIdentificationAndName5
    class ISO20022.Setr012001.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class ISO20022.Setr012001.EUCapitalGain2Code {
        UKWN = 1
        EUSO = 2
        EUSI = 3
    }
    class ISO20022.Setr012001.EUCapitalGain3Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.EUCapitalGain3Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.EUDividendStatus1Code {
        UKWN = 1
        DIVO = 2
        DIVI = 3
    }
    class ISO20022.Setr012001.EUDividendStatusType2Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.EUDividendStatusType2Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.Equalisation4 {
        + GrssAsstVal  : ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount
        + HghWtrmrk  : ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount
        + EqulstnCdtPerUnit  : ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount
        + DprctnDpstPerUnit  : ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount
        + CntngntLqdtnPerUnit  : ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount
        + EqulstnMthdlgyTp  : String
        + Rate  : Decimal
        + Amt  : ISO20022.Setr012001.ActiveCurrencyAndAmount
    }
    ISO20022.Setr012001.Equalisation4 *-- ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Setr012001.Equalisation4 *-- ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Setr012001.Equalisation4 *-- ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Setr012001.Equalisation4 *-- ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Setr012001.Equalisation4 *-- ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Setr012001.Equalisation4 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    class ISO20022.Setr012001.EqualisationMethodologyType1Code {
        EQCR = 1
        DDEP = 2
        COLI = 3
    }
    class ISO20022.Setr012001.ExemptionReason1Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.ExemptionReason1Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.Extension1 {
        + Txt  : String
        + PlcAndNm  : String
    }
    class ISO20022.Setr012001.Fee5 {
        + InftvInd  : String
        + RcptId  : ISO20022.Setr012001.PartyIdentification139
        + NonStdSLARef  : String
        + ApldRate  : Decimal
        + ApldAmt  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + DscntDtls  : ISO20022.Setr012001.ChargeOrCommissionDiscount1
        + StdRate  : Decimal
        + StdAmt  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + Bsis  : ISO20022.Setr012001.ChargeBasis2Choice
        + Tp  : ISO20022.Setr012001.ChargeType5Choice
    }
    ISO20022.Setr012001.Fee5 *-- ISO20022.Setr012001.PartyIdentification139
    ISO20022.Setr012001.Fee5 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.Fee5 *-- ISO20022.Setr012001.ChargeOrCommissionDiscount1
    ISO20022.Setr012001.Fee5 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.Fee5 *-- ISO20022.Setr012001.ChargeBasis2Choice
    ISO20022.Setr012001.Fee5 *-- ISO20022.Setr012001.ChargeType5Choice
    class ISO20022.Setr012001.FinancialAdvice1Code {
        UKWN = 1
        NREC = 2
        RECE = 3
    }
    class ISO20022.Setr012001.FinancialInstitutionIdentification15 {
        + LEI  : String
        + Pty  : ISO20022.Setr012001.FinancialInstitutionIdentification9Choice
    }
    ISO20022.Setr012001.FinancialInstitutionIdentification15 *-- ISO20022.Setr012001.FinancialInstitutionIdentification9Choice
    class ISO20022.Setr012001.FinancialInstitutionIdentification9Choice {
        + PrtryId  : String
        + ClrSysMmbId  : ISO20022.Setr012001.ClearingSystemMemberIdentification4Choice
        + BICFI  : String
        + NmAndAdr  : ISO20022.Setr012001.NameAndAddress5
    }
    ISO20022.Setr012001.FinancialInstitutionIdentification9Choice *-- ISO20022.Setr012001.ClearingSystemMemberIdentification4Choice
    ISO20022.Setr012001.FinancialInstitutionIdentification9Choice *-- ISO20022.Setr012001.NameAndAddress5
    class ISO20022.Setr012001.FinancialInstrument57 {
        + SrsId  : ISO20022.Setr012001.Series1
        + PdctGrp  : String
        + DstrbtnPlcy  : String
        + SctiesForm  : String
        + ClssTp  : String
        + SplmtryId  : String
        + ShrtNm  : String
        + Nm  : String
        + Id  : ISO20022.Setr012001.SecurityIdentification25Choice
    }
    ISO20022.Setr012001.FinancialInstrument57 *-- ISO20022.Setr012001.Series1
    ISO20022.Setr012001.FinancialInstrument57 *-- ISO20022.Setr012001.SecurityIdentification25Choice
    class ISO20022.Setr012001.ForeignExchangeTerms37 {
        + QtgInstn  : ISO20022.Setr012001.PartyIdentification139
        + QtnDt  : DateTime
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
        + FrAmt  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + ToAmt  : ISO20022.Setr012001.ActiveCurrencyAndAmount
    }
    ISO20022.Setr012001.ForeignExchangeTerms37 *-- ISO20022.Setr012001.PartyIdentification139
    ISO20022.Setr012001.ForeignExchangeTerms37 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.ForeignExchangeTerms37 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    class ISO20022.Setr012001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Setr012001.FundCashAccount2Code {
        SRSA = 1
        CPFS = 2
        CPFO = 3
        CASH = 4
    }
    class ISO20022.Setr012001.FundOrderType4Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.FundOrderType4Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.FundOrderType5Code {
        CWSP = 1
        SWSP = 2
        NCPN = 3
        NSPN = 4
    }
    class ISO20022.Setr012001.FundOrderType8Code {
        WIDP = 1
        STAF = 2
        RDIV = 3
        RGSU = 4
        RGSV = 5
        PREA = 6
        INVP = 7
        BEDB = 8
    }
    class ISO20022.Setr012001.FundSettlementParameters20 {
        + DlvrgSdDtls  : ISO20022.Setr012001.DeliveringPartiesAndAccount20
        + RcvgSdDtls  : ISO20022.Setr012001.ReceivingPartiesAndAccount20
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Setr012001.SettlementTransactionCondition30Choice~
        + TradTxCond  : global::System.Collections.Generic.List~ISO20022.Setr012001.TradeTransactionCondition8Choice~
        + SctiesSttlmSysId  : String
        + SfkpgPlc  : ISO20022.Setr012001.SafekeepingPlaceFormat40Choice
        + SttlmPlc  : ISO20022.Setr012001.PartyIdentification139
        + SttlmDt  : DateTime
    }
    ISO20022.Setr012001.FundSettlementParameters20 *-- ISO20022.Setr012001.DeliveringPartiesAndAccount20
    ISO20022.Setr012001.FundSettlementParameters20 *-- ISO20022.Setr012001.ReceivingPartiesAndAccount20
    ISO20022.Setr012001.FundSettlementParameters20 *-- ISO20022.Setr012001.SettlementTransactionCondition30Choice
    ISO20022.Setr012001.FundSettlementParameters20 *-- ISO20022.Setr012001.TradeTransactionCondition8Choice
    ISO20022.Setr012001.FundSettlementParameters20 *-- ISO20022.Setr012001.SafekeepingPlaceFormat40Choice
    ISO20022.Setr012001.FundSettlementParameters20 *-- ISO20022.Setr012001.PartyIdentification139
    class ISO20022.Setr012001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Setr012001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Setr012001.GenericAccountIdentification1 *-- ISO20022.Setr012001.AccountSchemeName1Choice
    class ISO20022.Setr012001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Setr012001.GenericIdentification164 {
        + Issr  : String
        + IdTp  : ISO20022.Setr012001.OtherIdentification3Choice
        + Id  : String
    }
    ISO20022.Setr012001.GenericIdentification164 *-- ISO20022.Setr012001.OtherIdentification3Choice
    class ISO20022.Setr012001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Setr012001.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Setr012001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Setr012001.GenericIdentification30
    }
    ISO20022.Setr012001.GenericIdentification78 *-- ISO20022.Setr012001.GenericIdentification30
    class ISO20022.Setr012001.IdentificationSource1Choice {
        + Prtry  : String
        + Dmst  : String
    }
    class ISO20022.Setr012001.IncomePreference1Code {
        DRIP = 1
        CASH = 2
    }
    class ISO20022.Setr012001.IndividualPerson32 {
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Setr012001.GenericIdentification164~
        + CtryAndResdtlSts  : ISO20022.Setr012001.CountryAndResidentialStatusType2
        + BirthDt  : DateTime
        + Nm  : String
    }
    ISO20022.Setr012001.IndividualPerson32 *-- ISO20022.Setr012001.GenericIdentification164
    ISO20022.Setr012001.IndividualPerson32 *-- ISO20022.Setr012001.CountryAndResidentialStatusType2
    class ISO20022.Setr012001.InformativeTax2 {
        + IndvTax  : global::System.Collections.Generic.List~ISO20022.Setr012001.Tax40~
        + PctgOfDebtClm  : Decimal
        + EUDvddSts  : ISO20022.Setr012001.EUDividendStatusType2Choice
        + EUCptlGn  : ISO20022.Setr012001.EUCapitalGain3Choice
        + TaxblIncmPerDvdd  : ISO20022.Setr012001.ActiveCurrencyAndAmount
    }
    ISO20022.Setr012001.InformativeTax2 *-- ISO20022.Setr012001.Tax40
    ISO20022.Setr012001.InformativeTax2 *-- ISO20022.Setr012001.EUDividendStatusType2Choice
    ISO20022.Setr012001.InformativeTax2 *-- ISO20022.Setr012001.EUCapitalGain3Choice
    ISO20022.Setr012001.InformativeTax2 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    class ISO20022.Setr012001.Intermediary49 {
        + Role  : ISO20022.Setr012001.InvestmentFundRole2Choice
        + TradgPtyCpcty  : String
        + OrdrOrgtrElgblty  : String
        + Acct  : ISO20022.Setr012001.Account35
        + Id  : ISO20022.Setr012001.PartyIdentification139
    }
    ISO20022.Setr012001.Intermediary49 *-- ISO20022.Setr012001.InvestmentFundRole2Choice
    ISO20022.Setr012001.Intermediary49 *-- ISO20022.Setr012001.Account35
    ISO20022.Setr012001.Intermediary49 *-- ISO20022.Setr012001.PartyIdentification139
    class ISO20022.Setr012001.InvestmentAccount60 {
        + Tp  : ISO20022.Setr012001.InvestmentAccountType1Choice
        + AcctId  : String
    }
    ISO20022.Setr012001.InvestmentAccount60 *-- ISO20022.Setr012001.InvestmentAccountType1Choice
    class ISO20022.Setr012001.InvestmentAccount78 {
        + SubAcctDtls  : ISO20022.Setr012001.SubAccount6
        + OrdrOrgtrElgblty  : String
        + AcctSvcr  : ISO20022.Setr012001.PartyIdentification139
        + OwnrId  : global::System.Collections.Generic.List~ISO20022.Setr012001.PartyIdentification139~
        + AcctDsgnt  : String
        + AcctNm  : String
        + AcctId  : String
    }
    ISO20022.Setr012001.InvestmentAccount78 *-- ISO20022.Setr012001.SubAccount6
    ISO20022.Setr012001.InvestmentAccount78 *-- ISO20022.Setr012001.PartyIdentification139
    ISO20022.Setr012001.InvestmentAccount78 *-- ISO20022.Setr012001.PartyIdentification139
    class ISO20022.Setr012001.InvestmentAccountType1Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.InvestmentAccountType1Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.InvestmentFundFee1Code {
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
    class ISO20022.Setr012001.InvestmentFundRole2Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.InvestmentFundRole2Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.InvestmentFundRole2Code {
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
    class ISO20022.Setr012001.InvestmentFundsOrderBreakdown2 {
        + Amt  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + OrdrBrkdwnTp  : ISO20022.Setr012001.OrderBreakdownType1Choice
    }
    ISO20022.Setr012001.InvestmentFundsOrderBreakdown2 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.InvestmentFundsOrderBreakdown2 *-- ISO20022.Setr012001.OrderBreakdownType1Choice
    class ISO20022.Setr012001.LateReport1Code {
        LAT2 = 1
        LAT1 = 2
    }
    class ISO20022.Setr012001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Setr012001.NameAndAddress4 {
        + Adr  : ISO20022.Setr012001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Setr012001.NameAndAddress4 *-- ISO20022.Setr012001.PostalAddress1
    class ISO20022.Setr012001.NameAndAddress5 {
        + Adr  : ISO20022.Setr012001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Setr012001.NameAndAddress5 *-- ISO20022.Setr012001.PostalAddress1
    class ISO20022.Setr012001.NegotiatedTrade1Code {
        UNKW = 1
        NNGO = 2
        NEGO = 3
    }
    class ISO20022.Setr012001.OrderBreakdownType1Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.OrderBreakdownType1Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.OrderOriginatorEligibility1Code {
        PROF = 1
        RETL = 2
        ELIG = 3
    }
    class ISO20022.Setr012001.OrderWaiver1 {
        + InfVal  : String
        + OrdrWvrRsn  : global::System.Collections.Generic.List~ISO20022.Setr012001.OrderWaiverReason3Choice~
    }
    ISO20022.Setr012001.OrderWaiver1 *-- ISO20022.Setr012001.OrderWaiverReason3Choice
    class ISO20022.Setr012001.OrderWaiverReason1Code {
        COMW = 1
        CUTO = 2
        BMIN = 3
        FEND = 4
        LATE = 5
    }
    class ISO20022.Setr012001.OrderWaiverReason3Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.OrderWaiverReason3Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.OtherIdentification3Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.OtherIdentification3Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.PartyIdentification125Choice {
        + NmAndAdr  : ISO20022.Setr012001.NameAndAddress5
        + PrtryId  : ISO20022.Setr012001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Setr012001.PartyIdentification125Choice *-- ISO20022.Setr012001.NameAndAddress5
    ISO20022.Setr012001.PartyIdentification125Choice *-- ISO20022.Setr012001.GenericIdentification1
    class ISO20022.Setr012001.PartyIdentification139 {
        + LEI  : String
        + Pty  : ISO20022.Setr012001.PartyIdentification125Choice
    }
    ISO20022.Setr012001.PartyIdentification139 *-- ISO20022.Setr012001.PartyIdentification125Choice
    class ISO20022.Setr012001.PartyIdentificationAndAccount222 {
        + AcctId  : String
        + PtyId  : ISO20022.Setr012001.PartyIdentification139
    }
    ISO20022.Setr012001.PartyIdentificationAndAccount222 *-- ISO20022.Setr012001.PartyIdentification139
    class ISO20022.Setr012001.PartyIdentificationType7Code {
        GIIN = 1
        INCL = 2
        NINV = 3
        EMID = 4
        DRLC = 5
        AREG = 6
        CPFA = 7
        ITIN = 8
        GTIN = 9
        GUNL = 10
        SRSA = 11
        SOCS = 12
        POCD = 13
        PASS = 14
        OTHR = 15
        NRIN = 16
        IDCD = 17
        ATIN = 18
    }
    class ISO20022.Setr012001.PaymentCard34 {
        + SeqNb  : String
        + SctyCd  : String
        + CardIssrId  : ISO20022.Setr012001.PartyIdentification139
        + CardIssrNm  : String
        + XpryDt  : String
        + StartDt  : String
        + HldrNm  : String
        + Nb  : String
        + Tp  : String
    }
    ISO20022.Setr012001.PaymentCard34 *-- ISO20022.Setr012001.PartyIdentification139
    class ISO20022.Setr012001.PaymentInstrument27Choice {
        + CshAcctDtls  : ISO20022.Setr012001.InvestmentAccount60
        + BkrsDrftDtls  : ISO20022.Setr012001.Cheque21
        + ChqDtls  : ISO20022.Setr012001.Cheque21
        + DrctDbtDtls  : ISO20022.Setr012001.DirectDebitMandate8
        + CdtTrfDtls  : ISO20022.Setr012001.CreditTransfer10
        + PmtCardDtls  : ISO20022.Setr012001.PaymentCard34
    }
    ISO20022.Setr012001.PaymentInstrument27Choice *-- ISO20022.Setr012001.InvestmentAccount60
    ISO20022.Setr012001.PaymentInstrument27Choice *-- ISO20022.Setr012001.Cheque21
    ISO20022.Setr012001.PaymentInstrument27Choice *-- ISO20022.Setr012001.Cheque21
    ISO20022.Setr012001.PaymentInstrument27Choice *-- ISO20022.Setr012001.DirectDebitMandate8
    ISO20022.Setr012001.PaymentInstrument27Choice *-- ISO20022.Setr012001.CreditTransfer10
    ISO20022.Setr012001.PaymentInstrument27Choice *-- ISO20022.Setr012001.PaymentCard34
    class ISO20022.Setr012001.PaymentTransaction162 {
        + PmtInstrm  : ISO20022.Setr012001.PaymentInstrument27Choice
    }
    ISO20022.Setr012001.PaymentTransaction162 *-- ISO20022.Setr012001.PaymentInstrument27Choice
    class ISO20022.Setr012001.PlaceOfTradeIdentification4Choice {
        + OverTheCntr  : String
        + Pty  : String
        + Xchg  : String
        + Ctry  : String
    }
    class ISO20022.Setr012001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Setr012001.PriceMethod1Code {
        HIST = 1
        FORW = 2
    }
    class ISO20022.Setr012001.PriceValue1 {
        + Amt  : ISO20022.Setr012001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Setr012001.PriceValue1 *-- ISO20022.Setr012001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Setr012001.ProfitAndLoss2Choice {
        + Loss  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + Prft  : ISO20022.Setr012001.ActiveCurrencyAndAmount
    }
    ISO20022.Setr012001.ProfitAndLoss2Choice *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.ProfitAndLoss2Choice *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    class ISO20022.Setr012001.ReceivingPartiesAndAccount20 {
        + RcvgAgtDtls  : ISO20022.Setr012001.PartyIdentificationAndAccount222
        + RcvrsIntrmy2Dtls  : ISO20022.Setr012001.PartyIdentificationAndAccount222
        + RcvrsIntrmy1Dtls  : ISO20022.Setr012001.PartyIdentificationAndAccount222
        + RcvrsCtdnDtls  : ISO20022.Setr012001.PartyIdentificationAndAccount222
    }
    ISO20022.Setr012001.ReceivingPartiesAndAccount20 *-- ISO20022.Setr012001.PartyIdentificationAndAccount222
    ISO20022.Setr012001.ReceivingPartiesAndAccount20 *-- ISO20022.Setr012001.PartyIdentificationAndAccount222
    ISO20022.Setr012001.ReceivingPartiesAndAccount20 *-- ISO20022.Setr012001.PartyIdentificationAndAccount222
    ISO20022.Setr012001.ReceivingPartiesAndAccount20 *-- ISO20022.Setr012001.PartyIdentificationAndAccount222
    class ISO20022.Setr012001.ResidentialStatus1Code {
        NRES = 1
        PRES = 2
        RESI = 3
    }
    class ISO20022.Setr012001.RoundingDirection2Code {
        RDWN = 1
        RDUP = 2
    }
    class ISO20022.Setr012001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Setr012001.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Setr012001.SafekeepingPlaceFormat40Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification78
        + TpAndId  : ISO20022.Setr012001.SafekeepingPlaceTypeAndAnyBICIdentifier3
        + Ctry  : String
        + Id  : ISO20022.Setr012001.SafekeepingPlaceTypeAndText6
    }
    ISO20022.Setr012001.SafekeepingPlaceFormat40Choice *-- ISO20022.Setr012001.GenericIdentification78
    ISO20022.Setr012001.SafekeepingPlaceFormat40Choice *-- ISO20022.Setr012001.SafekeepingPlaceTypeAndAnyBICIdentifier3
    ISO20022.Setr012001.SafekeepingPlaceFormat40Choice *-- ISO20022.Setr012001.SafekeepingPlaceTypeAndText6
    class ISO20022.Setr012001.SafekeepingPlaceTypeAndAnyBICIdentifier3 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Setr012001.SafekeepingPlaceTypeAndText6 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Setr012001.SecurityIdentification25Choice {
        + OthrPrtryId  : ISO20022.Setr012001.AlternateSecurityIdentification7
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
    ISO20022.Setr012001.SecurityIdentification25Choice *-- ISO20022.Setr012001.AlternateSecurityIdentification7
    class ISO20022.Setr012001.Series1 {
        + SrsNm  : String
        + SrsDt  : ISO20022.Setr012001.DateFormat42Choice
    }
    ISO20022.Setr012001.Series1 *-- ISO20022.Setr012001.DateFormat42Choice
    class ISO20022.Setr012001.SettlementTransactionCondition11Code {
        NOMC = 1
    }
    class ISO20022.Setr012001.SettlementTransactionCondition30Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr012001.SettlementTransactionCondition30Choice *-- ISO20022.Setr012001.GenericIdentification30
    class ISO20022.Setr012001.SignatureType1Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.SignatureType1Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.SignatureType2Code {
        ORIG = 1
        NONE = 2
        ELEC = 3
        DIGI = 4
    }
    class ISO20022.Setr012001.SourceOfCash1Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.SourceOfCash1Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.SourceOfCash1Code {
        WINS = 1
        SELF = 2
        SVGS = 3
        SALE = 4
        SEAQ = 5
        REPY = 6
        REDM = 7
        REST = 8
        INLQ = 9
        INHE = 10
        GIFT = 11
        EMIN = 12
        COMP = 13
        CASH = 14
        ALMY = 15
    }
    class ISO20022.Setr012001.SubAccount6 {
        + AcctDsgnt  : String
        + Chrtc  : String
        + Nm  : String
        + Id  : String
    }
    class ISO20022.Setr012001.SubscriptionExecution14 {
        + OrdrWvrDtls  : ISO20022.Setr012001.OrderWaiver1
        + SgntrTp  : ISO20022.Setr012001.SignatureType1Choice
        + TxChanlTp  : ISO20022.Setr012001.TransactionChannelType1Choice
        + CstmrCndctClssfctn  : ISO20022.Setr012001.CustomerConductClassification1Choice
        + SrcOfCsh  : global::System.Collections.Generic.List~ISO20022.Setr012001.SourceOfCash1Choice~
        + Equlstn  : ISO20022.Setr012001.Equalisation4
        + RltdPtyDtls  : global::System.Collections.Generic.List~ISO20022.Setr012001.Intermediary49~
        + LateRpt  : String
        + NgtdTrad  : String
        + FinAdvc  : String
        + StffClntBrkdwn  : global::System.Collections.Generic.List~ISO20022.Setr012001.InvestmentFundsOrderBreakdown2~
        + PrtlSttlmOfCsh  : Decimal
        + PrtlSttlmOfUnits  : Decimal
        + NonStdSttlmInf  : String
        + CshSttlmDtls  : ISO20022.Setr012001.PaymentTransaction162
        + SbcptIntrst  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + Rfnd  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + ReqdNAVCcy  : String
        + ReqdSttlmCcy  : String
        + PhysDlvryDtls  : ISO20022.Setr012001.DeliveryParameters3
        + PhysDlvryInd  : String
        + SttlmAndCtdyDtls  : ISO20022.Setr012001.FundSettlementParameters20
        + InftvTaxDtls  : ISO20022.Setr012001.InformativeTax2
        + TxOvrhd  : ISO20022.Setr012001.TotalFeesAndTaxes42
        + AcmltnRghtRef  : String
        + LttrInttRef  : String
        + IncmPref  : String
        + FXDtls  : global::System.Collections.Generic.List~ISO20022.Setr012001.ForeignExchangeTerms37~
        + IntrmPrftAmt  : ISO20022.Setr012001.ProfitAndLoss2Choice
        + CumDvddInd  : String
        + BestExctn  : String
        + PrtlyExctdInd  : String
        + SttlmMtd  : String
        + CshSttlmDt  : DateTime
        + SttlmAmt  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + InftvPricDtls  : global::System.Collections.Generic.List~ISO20022.Setr012001.UnitPrice22~
        + DealgPricDtls  : ISO20022.Setr012001.UnitPrice22
        + TradDtTm  : ISO20022.Setr012001.DateAndDateTime2Choice
        + GrssAmt  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + NetAmt  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + Rndg  : String
        + UnitsNb  : Decimal
        + SubAcctForHldg  : ISO20022.Setr012001.SubAccount6
        + FinInstrmDtls  : ISO20022.Setr012001.FinancialInstrument57
        + OrdrTp  : global::System.Collections.Generic.List~ISO20022.Setr012001.FundOrderType4Choice~
        + DealRef  : String
        + ClntRef  : String
        + OrdrRef  : String
    }
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.OrderWaiver1
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.SignatureType1Choice
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.TransactionChannelType1Choice
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.CustomerConductClassification1Choice
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.SourceOfCash1Choice
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.Equalisation4
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.Intermediary49
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.InvestmentFundsOrderBreakdown2
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.PaymentTransaction162
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.DeliveryParameters3
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.FundSettlementParameters20
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.InformativeTax2
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.TotalFeesAndTaxes42
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.ForeignExchangeTerms37
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.ProfitAndLoss2Choice
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.UnitPrice22
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.UnitPrice22
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.DateAndDateTime2Choice
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.SubAccount6
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.FinancialInstrument57
    ISO20022.Setr012001.SubscriptionExecution14 *-- ISO20022.Setr012001.FundOrderType4Choice
    class ISO20022.Setr012001.SubscriptionMultipleExecution6 {
        + BlkCshSttlmDtls  : ISO20022.Setr012001.PaymentTransaction162
        + TtlSttlmAmt  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + IndvExctnDtls  : global::System.Collections.Generic.List~ISO20022.Setr012001.SubscriptionExecution14~
        + BnfcryDtls  : global::System.Collections.Generic.List~ISO20022.Setr012001.IndividualPerson32~
        + InvstmtAcctDtls  : ISO20022.Setr012001.InvestmentAccount78
        + CxlRght  : ISO20022.Setr012001.CancellationRight1Choice
        + ReqdFutrTradDt  : DateTime
        + RcvdDtTm  : DateTime
        + OrdrDtTm  : DateTime
        + PlcOfTrad  : ISO20022.Setr012001.PlaceOfTradeIdentification4Choice
        + MstrRef  : String
        + AmdmntInd  : String
    }
    ISO20022.Setr012001.SubscriptionMultipleExecution6 *-- ISO20022.Setr012001.PaymentTransaction162
    ISO20022.Setr012001.SubscriptionMultipleExecution6 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.SubscriptionMultipleExecution6 *-- ISO20022.Setr012001.SubscriptionExecution14
    ISO20022.Setr012001.SubscriptionMultipleExecution6 *-- ISO20022.Setr012001.IndividualPerson32
    ISO20022.Setr012001.SubscriptionMultipleExecution6 *-- ISO20022.Setr012001.InvestmentAccount78
    ISO20022.Setr012001.SubscriptionMultipleExecution6 *-- ISO20022.Setr012001.CancellationRight1Choice
    ISO20022.Setr012001.SubscriptionMultipleExecution6 *-- ISO20022.Setr012001.PlaceOfTradeIdentification4Choice
    class ISO20022.Setr012001.SubscriptionOrderConfirmationV05 {
        + Xtnsn  : global::System.Collections.Generic.List~ISO20022.Setr012001.Extension1~
        + CpyDtls  : ISO20022.Setr012001.CopyInformation5
        + MltplExctnDtls  : ISO20022.Setr012001.SubscriptionMultipleExecution6
        + RltdRef  : ISO20022.Setr012001.AdditionalReference10
        + PrvsRef  : global::System.Collections.Generic.List~ISO20022.Setr012001.AdditionalReference10~
        + PoolRef  : ISO20022.Setr012001.AdditionalReference11
        + MsgId  : ISO20022.Setr012001.MessageIdentification1
    }
    ISO20022.Setr012001.SubscriptionOrderConfirmationV05 *-- ISO20022.Setr012001.Extension1
    ISO20022.Setr012001.SubscriptionOrderConfirmationV05 *-- ISO20022.Setr012001.CopyInformation5
    ISO20022.Setr012001.SubscriptionOrderConfirmationV05 *-- ISO20022.Setr012001.SubscriptionMultipleExecution6
    ISO20022.Setr012001.SubscriptionOrderConfirmationV05 *-- ISO20022.Setr012001.AdditionalReference10
    ISO20022.Setr012001.SubscriptionOrderConfirmationV05 *-- ISO20022.Setr012001.AdditionalReference10
    ISO20022.Setr012001.SubscriptionOrderConfirmationV05 *-- ISO20022.Setr012001.AdditionalReference11
    ISO20022.Setr012001.SubscriptionOrderConfirmationV05 *-- ISO20022.Setr012001.MessageIdentification1
    class ISO20022.Setr012001.Tax35 {
        + TaxClctnDtls  : ISO20022.Setr012001.TaxCalculationInformation10
        + RcptId  : ISO20022.Setr012001.PartyIdentification139
        + Ctry  : String
        + ApldRate  : Decimal
        + ApldAmt  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + Tp  : ISO20022.Setr012001.TaxType3Choice
    }
    ISO20022.Setr012001.Tax35 *-- ISO20022.Setr012001.TaxCalculationInformation10
    ISO20022.Setr012001.Tax35 *-- ISO20022.Setr012001.PartyIdentification139
    ISO20022.Setr012001.Tax35 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.Tax35 *-- ISO20022.Setr012001.TaxType3Choice
    class ISO20022.Setr012001.Tax40 {
        + TaxClctnDtls  : ISO20022.Setr012001.TaxCalculationInformation10
        + RcptId  : ISO20022.Setr012001.PartyIdentification139
        + XmptnRsn  : ISO20022.Setr012001.ExemptionReason1Choice
        + XmptnInd  : String
        + Ctry  : String
        + InftvRate  : Decimal
        + InftvAmt  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + Tp  : ISO20022.Setr012001.TaxType3Choice
    }
    ISO20022.Setr012001.Tax40 *-- ISO20022.Setr012001.TaxCalculationInformation10
    ISO20022.Setr012001.Tax40 *-- ISO20022.Setr012001.PartyIdentification139
    ISO20022.Setr012001.Tax40 *-- ISO20022.Setr012001.ExemptionReason1Choice
    ISO20022.Setr012001.Tax40 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.Tax40 *-- ISO20022.Setr012001.TaxType3Choice
    class ISO20022.Setr012001.TaxBasis1Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.TaxBasis1Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.TaxCalculationInformation10 {
        + TaxblAmt  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + Bsis  : ISO20022.Setr012001.TaxBasis1Choice
    }
    ISO20022.Setr012001.TaxCalculationInformation10 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.TaxCalculationInformation10 *-- ISO20022.Setr012001.TaxBasis1Choice
    class ISO20022.Setr012001.TaxExemptReason1Code {
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
    class ISO20022.Setr012001.TaxType17Code {
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
    class ISO20022.Setr012001.TaxType3Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.TaxType3Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.TaxableIncomePerShareCalculated2Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.TaxableIncomePerShareCalculated2Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.TaxableIncomePerShareCalculated2Code {
        UKWN = 1
        TSIN = 2
        TSIY = 3
    }
    class ISO20022.Setr012001.TaxationBasis2Code {
        PERU = 1
        FLAT = 2
    }
    class ISO20022.Setr012001.TaxationBasis5Code {
        PERU = 1
        NAVP = 2
        NEAM = 3
        GRAM = 4
        FLAT = 5
    }
    class ISO20022.Setr012001.TotalFeesAndTaxes42 {
        + IndvTax  : global::System.Collections.Generic.List~ISO20022.Setr012001.Tax35~
        + IndvFee  : global::System.Collections.Generic.List~ISO20022.Setr012001.Fee5~
        + ComrclAgrmtRef  : String
        + TtlTaxs  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + TtlFees  : ISO20022.Setr012001.ActiveCurrencyAndAmount
        + TtlOvrhdApld  : ISO20022.Setr012001.ActiveCurrencyAndAmount
    }
    ISO20022.Setr012001.TotalFeesAndTaxes42 *-- ISO20022.Setr012001.Tax35
    ISO20022.Setr012001.TotalFeesAndTaxes42 *-- ISO20022.Setr012001.Fee5
    ISO20022.Setr012001.TotalFeesAndTaxes42 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.TotalFeesAndTaxes42 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    ISO20022.Setr012001.TotalFeesAndTaxes42 *-- ISO20022.Setr012001.ActiveCurrencyAndAmount
    class ISO20022.Setr012001.TradeTransactionCondition5Code {
        CCPN = 1
        XCPN = 2
    }
    class ISO20022.Setr012001.TradeTransactionCondition8Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Setr012001.TradeTransactionCondition8Choice *-- ISO20022.Setr012001.GenericIdentification30
    class ISO20022.Setr012001.TradingCapacity8Code {
        PRIN = 1
        AGEN = 2
    }
    class ISO20022.Setr012001.TransactionChannel2Code {
        BRAN = 1
        HOBA = 2
        FIAD = 3
    }
    class ISO20022.Setr012001.TransactionChannelType1Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.TransactionChannelType1Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.TypeOfPrice10Code {
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
    class ISO20022.Setr012001.TypeOfPrice46Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.TypeOfPrice46Choice *-- ISO20022.Setr012001.GenericIdentification47
    class ISO20022.Setr012001.UnitPrice22 {
        + PricDiffRsn  : String
        + TaxblIncmPerShrClctd  : ISO20022.Setr012001.TaxableIncomePerShareCalculated2Choice
        + TaxblIncmPerShr  : ISO20022.Setr012001.ActiveCurrencyAnd13DecimalAmount
        + NbOfDaysAcrd  : Decimal
        + PricMtd  : String
        + Val  : ISO20022.Setr012001.PriceValue1
        + Tp  : ISO20022.Setr012001.TypeOfPrice46Choice
    }
    ISO20022.Setr012001.UnitPrice22 *-- ISO20022.Setr012001.TaxableIncomePerShareCalculated2Choice
    ISO20022.Setr012001.UnitPrice22 *-- ISO20022.Setr012001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Setr012001.UnitPrice22 *-- ISO20022.Setr012001.PriceValue1
    ISO20022.Setr012001.UnitPrice22 *-- ISO20022.Setr012001.TypeOfPrice46Choice
    class ISO20022.Setr012001.WaivingInstruction1Code {
        WIUN = 1
        WICA = 2
    }
    class ISO20022.Setr012001.WaivingInstruction2Choice {
        + Prtry  : ISO20022.Setr012001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Setr012001.WaivingInstruction2Choice *-- ISO20022.Setr012001.GenericIdentification47
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

## Value ISO20022.Setr012001.Account35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcr))|

---

## Value ISO20022.Setr012001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Setr012001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Setr012001.AccountIdentificationAndName5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Setr012001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Value ISO20022.Setr012001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr012001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Setr012001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Setr012001.AdditionalReference10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Value ISO20022.Setr012001.AdditionalReference11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Enum ISO20022.Setr012001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Setr012001.AlternateSecurityIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdSrc|ISO20022.Setr012001.IdentificationSource1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdSrc))|

---

## Enum ISO20022.Setr012001.BestExecution1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BTEX|Int32||XmlEnum("""BTEX""")|1|

---

## Value ISO20022.Setr012001.BranchData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Setr012001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr))|

---

## Value ISO20022.Setr012001.CancellationRight1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr012001.CancellationRight1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOIN|Int32||XmlEnum("""NOIN""")|1|
||NOWA|Int32||XmlEnum("""NOWA""")|2|
||NOXO|Int32||XmlEnum("""NOXO""")|3|
||VALI|Int32||XmlEnum("""VALI""")|4|

---

## Enum ISO20022.Setr012001.CardType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Setr012001.ChargeBasis2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr012001.ChargeOrCommissionDiscount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bsis|ISO20022.Setr012001.WaivingInstruction2Choice||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bsis),validElement(Amt))|

---

## Value ISO20022.Setr012001.ChargeType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr012001.Cheque21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DrwrId|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|DrweeId|ISO20022.Setr012001.FinancialInstitutionIdentification15||XmlElement()||
|+|PyeeId|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DrwrId),validElement(DrweeId),validElement(PyeeId))|

---

## Value ISO20022.Setr012001.ClearingSystemMemberIdentification4Choice


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

## Enum ISO20022.Setr012001.ConductClassification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||STAN|Int32||XmlEnum("""STAN""")|1|
||RCLT|Int32||XmlEnum("""RCLT""")|2|
||NSTA|Int32||XmlEnum("""NSTA""")|3|

---

## Value ISO20022.Setr012001.CopyInformation5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlRcvr|String||XmlElement()||
|+|CpyInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""OrgnlRcvr""",OrgnlRcvr,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Setr012001.CountryAndResidentialStatusType2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ResdtlSts|String||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Setr012001.CreditTransfer10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtrAcct|ISO20022.Setr012001.AccountIdentificationAndName5||XmlElement()||
|+|Cdtr|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|CdtrAgtAcct|ISO20022.Setr012001.AccountIdentificationAndName5||XmlElement()||
|+|CdtrAgt|ISO20022.Setr012001.FinancialInstitutionIdentification15||XmlElement()||
|+|IntrmyAgt2Acct|ISO20022.Setr012001.AccountIdentificationAndName5||XmlElement()||
|+|IntrmyAgt2|ISO20022.Setr012001.FinancialInstitutionIdentification15||XmlElement()||
|+|IntrmyAgt1Acct|ISO20022.Setr012001.AccountIdentificationAndName5||XmlElement()||
|+|IntrmyAgt1|ISO20022.Setr012001.FinancialInstitutionIdentification15||XmlElement()||
|+|DbtrAgtAcct|ISO20022.Setr012001.AccountIdentificationAndName5||XmlElement()||
|+|DbtrAgt|ISO20022.Setr012001.FinancialInstitutionIdentification15||XmlElement()||
|+|DbtrAcct|ISO20022.Setr012001.AccountIdentificationAndName5||XmlElement()||
|+|Dbtr|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtrAcct),validElement(Cdtr),validElement(CdtrAgtAcct),validElement(CdtrAgt),validElement(IntrmyAgt2Acct),validElement(IntrmyAgt2),validElement(IntrmyAgt1Acct),validElement(IntrmyAgt1),validElement(DbtrAgtAcct),validElement(DbtrAgt),validElement(DbtrAcct),validElement(Dbtr))|

---

## Value ISO20022.Setr012001.CustomerConductClassification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr012001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Setr012001.DateFormat42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|YrMnthDay|DateTime||XmlElement()||
|+|YrMnth|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(YrMnthDay,YrMnth))|

---

## Value ISO20022.Setr012001.DeliveringPartiesAndAccount20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DlvrgAgtDtls|ISO20022.Setr012001.PartyIdentificationAndAccount222||XmlElement()||
|+|DlvrrsIntrmy2Dtls|ISO20022.Setr012001.PartyIdentificationAndAccount222||XmlElement()||
|+|DlvrrsIntrmy1Dtls|ISO20022.Setr012001.PartyIdentificationAndAccount222||XmlElement()||
|+|DlvrrsCtdnDtls|ISO20022.Setr012001.PartyIdentificationAndAccount222||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DlvrgAgtDtls),validElement(DlvrrsIntrmy2Dtls),validElement(DlvrrsIntrmy1Dtls),validElement(DlvrrsCtdnDtls))|

---

## Value ISO20022.Setr012001.DeliveryParameters3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IssdCertNb|String||XmlElement()||
|+|Adr|ISO20022.Setr012001.NameAndAddress4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Setr012001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Value ISO20022.Setr012001.DirectDebitMandate8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MndtId|String||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|CdtrAgtBrnch|ISO20022.Setr012001.BranchData4||XmlElement()||
|+|CdtrAgt|ISO20022.Setr012001.FinancialInstitutionIdentification15||XmlElement()||
|+|DbtrAgtBrnch|ISO20022.Setr012001.BranchData4||XmlElement()||
|+|DbtrAgt|ISO20022.Setr012001.FinancialInstitutionIdentification15||XmlElement()||
|+|Cdtr|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|DbtrNtlRegnNb|String||XmlElement()||
|+|DbtrTaxIdNb|String||XmlElement()||
|+|Dbtr|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|DbtrAcct|ISO20022.Setr012001.AccountIdentificationAndName5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtrAgtBrnch),validElement(CdtrAgt),validElement(DbtrAgtBrnch),validElement(DbtrAgt),validElement(Cdtr),validElement(Dbtr),validElement(DbtrAcct))|

---

## Enum ISO20022.Setr012001.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||DIST|Int32||XmlEnum("""DIST""")|2|

---

## Type ISO20022.Setr012001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SbcptOrdrConf|ISO20022.Setr012001.SubscriptionOrderConfirmationV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SbcptOrdrConf))|

---

## Enum ISO20022.Setr012001.EUCapitalGain2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||EUSO|Int32||XmlEnum("""EUSO""")|2|
||EUSI|Int32||XmlEnum("""EUSI""")|3|

---

## Value ISO20022.Setr012001.EUCapitalGain3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr012001.EUDividendStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||DIVO|Int32||XmlEnum("""DIVO""")|2|
||DIVI|Int32||XmlEnum("""DIVI""")|3|

---

## Value ISO20022.Setr012001.EUDividendStatusType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr012001.Equalisation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GrssAsstVal|ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|HghWtrmrk|ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|EqulstnCdtPerUnit|ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|DprctnDpstPerUnit|ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CntngntLqdtnPerUnit|ISO20022.Setr012001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|EqulstnMthdlgyTp|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Amt|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GrssAsstVal),validElement(HghWtrmrk),validElement(EqulstnCdtPerUnit),validElement(DprctnDpstPerUnit),validElement(CntngntLqdtnPerUnit),validElement(Amt))|

---

## Enum ISO20022.Setr012001.EqualisationMethodologyType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EQCR|Int32||XmlEnum("""EQCR""")|1|
||DDEP|Int32||XmlEnum("""DDEP""")|2|
||COLI|Int32||XmlEnum("""COLI""")|3|

---

## Value ISO20022.Setr012001.ExemptionReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr012001.Extension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr012001.Fee5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InftvInd|String||XmlElement()||
|+|RcptId|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|NonStdSLARef|String||XmlElement()||
|+|ApldRate|Decimal||XmlElement()||
|+|ApldAmt|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|DscntDtls|ISO20022.Setr012001.ChargeOrCommissionDiscount1||XmlElement()||
|+|StdRate|Decimal||XmlElement()||
|+|StdAmt|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|Bsis|ISO20022.Setr012001.ChargeBasis2Choice||XmlElement()||
|+|Tp|ISO20022.Setr012001.ChargeType5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcptId),validElement(ApldAmt),validElement(DscntDtls),validElement(StdAmt),validElement(Bsis),validElement(Tp))|

---

## Enum ISO20022.Setr012001.FinancialAdvice1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||NREC|Int32||XmlEnum("""NREC""")|2|
||RECE|Int32||XmlEnum("""RECE""")|3|

---

## Value ISO20022.Setr012001.FinancialInstitutionIdentification15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Setr012001.FinancialInstitutionIdentification9Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Setr012001.FinancialInstitutionIdentification9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Setr012001.ClearingSystemMemberIdentification4Choice||XmlElement()||
|+|BICFI|String||XmlElement()||
|+|NmAndAdr|ISO20022.Setr012001.NameAndAddress5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z]{6,6}[A-Z2-9][A-NP-Z0-9]([A-Z0-9]{3,3}){0,1}"""),validElement(NmAndAdr),validChoice(PrtryId,ClrSysMmbId,BICFI,NmAndAdr))|

---

## Value ISO20022.Setr012001.FinancialInstrument57


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrsId|ISO20022.Setr012001.Series1||XmlElement()||
|+|PdctGrp|String||XmlElement()||
|+|DstrbtnPlcy|String||XmlElement()||
|+|SctiesForm|String||XmlElement()||
|+|ClssTp|String||XmlElement()||
|+|SplmtryId|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Setr012001.SecurityIdentification25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SrsId),validElement(Id))|

---

## Value ISO20022.Setr012001.ForeignExchangeTerms37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtgInstn|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|QtnDt|DateTime||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
|+|FrAmt|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|ToAmt|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtgInstn),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""),validElement(FrAmt),validElement(ToAmt))|

---

## Enum ISO20022.Setr012001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Enum ISO20022.Setr012001.FundCashAccount2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SRSA|Int32||XmlEnum("""SRSA""")|1|
||CPFS|Int32||XmlEnum("""CPFS""")|2|
||CPFO|Int32||XmlEnum("""CPFO""")|3|
||CASH|Int32||XmlEnum("""CASH""")|4|

---

## Value ISO20022.Setr012001.FundOrderType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr012001.FundOrderType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CWSP|Int32||XmlEnum("""CWSP""")|1|
||SWSP|Int32||XmlEnum("""SWSP""")|2|
||NCPN|Int32||XmlEnum("""NCPN""")|3|
||NSPN|Int32||XmlEnum("""NSPN""")|4|

---

## Enum ISO20022.Setr012001.FundOrderType8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WIDP|Int32||XmlEnum("""WIDP""")|1|
||STAF|Int32||XmlEnum("""STAF""")|2|
||RDIV|Int32||XmlEnum("""RDIV""")|3|
||RGSU|Int32||XmlEnum("""RGSU""")|4|
||RGSV|Int32||XmlEnum("""RGSV""")|5|
||PREA|Int32||XmlEnum("""PREA""")|6|
||INVP|Int32||XmlEnum("""INVP""")|7|
||BEDB|Int32||XmlEnum("""BEDB""")|8|

---

## Value ISO20022.Setr012001.FundSettlementParameters20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DlvrgSdDtls|ISO20022.Setr012001.DeliveringPartiesAndAccount20||XmlElement()||
|+|RcvgSdDtls|ISO20022.Setr012001.ReceivingPartiesAndAccount20||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Setr012001.SettlementTransactionCondition30Choice>||XmlElement()||
|+|TradTxCond|global::System.Collections.Generic.List<ISO20022.Setr012001.TradeTransactionCondition8Choice>||XmlElement()||
|+|SctiesSttlmSysId|String||XmlElement()||
|+|SfkpgPlc|ISO20022.Setr012001.SafekeepingPlaceFormat40Choice||XmlElement()||
|+|SttlmPlc|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|SttlmDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DlvrgSdDtls),validElement(RcvgSdDtls),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validList("""TradTxCond""",TradTxCond),validElement(TradTxCond),validElement(SfkpgPlc),validElement(SttlmPlc))|

---

## Value ISO20022.Setr012001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Setr012001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Setr012001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr012001.GenericIdentification164


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|IdTp|ISO20022.Setr012001.OtherIdentification3Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdTp))|

---

## Value ISO20022.Setr012001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Setr012001.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Setr012001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Setr012001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Setr012001.IdentificationSource1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Dmst|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Dmst""",Dmst,"""[A-Z]{2,2}"""),validChoice(Prtry,Dmst))|

---

## Enum ISO20022.Setr012001.IncomePreference1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DRIP|Int32||XmlEnum("""DRIP""")|1|
||CASH|Int32||XmlEnum("""CASH""")|2|

---

## Value ISO20022.Setr012001.IndividualPerson32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Setr012001.GenericIdentification164>||XmlElement()||
|+|CtryAndResdtlSts|ISO20022.Setr012001.CountryAndResidentialStatusType2||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validElement(CtryAndResdtlSts))|

---

## Value ISO20022.Setr012001.InformativeTax2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndvTax|global::System.Collections.Generic.List<ISO20022.Setr012001.Tax40>||XmlElement()||
|+|PctgOfDebtClm|Decimal||XmlElement()||
|+|EUDvddSts|ISO20022.Setr012001.EUDividendStatusType2Choice||XmlElement()||
|+|EUCptlGn|ISO20022.Setr012001.EUCapitalGain3Choice||XmlElement()||
|+|TaxblIncmPerDvdd|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""IndvTax""",IndvTax),validElement(IndvTax),validElement(EUDvddSts),validElement(EUCptlGn),validElement(TaxblIncmPerDvdd))|

---

## Value ISO20022.Setr012001.Intermediary49


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Role|ISO20022.Setr012001.InvestmentFundRole2Choice||XmlElement()||
|+|TradgPtyCpcty|String||XmlElement()||
|+|OrdrOrgtrElgblty|String||XmlElement()||
|+|Acct|ISO20022.Setr012001.Account35||XmlElement()||
|+|Id|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Role),validElement(Acct),validElement(Id))|

---

## Value ISO20022.Setr012001.InvestmentAccount60


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Setr012001.InvestmentAccountType1Choice||XmlElement()||
|+|AcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Setr012001.InvestmentAccount78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubAcctDtls|ISO20022.Setr012001.SubAccount6||XmlElement()||
|+|OrdrOrgtrElgblty|String||XmlElement()||
|+|AcctSvcr|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|OwnrId|global::System.Collections.Generic.List<ISO20022.Setr012001.PartyIdentification139>||XmlElement()||
|+|AcctDsgnt|String||XmlElement()||
|+|AcctNm|String||XmlElement()||
|+|AcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SubAcctDtls),validElement(AcctSvcr),validList("""OwnrId""",OwnrId),validElement(OwnrId))|

---

## Value ISO20022.Setr012001.InvestmentAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr012001.InvestmentFundFee1Code


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

## Value ISO20022.Setr012001.InvestmentFundRole2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr012001.InvestmentFundRole2Code


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

## Value ISO20022.Setr012001.InvestmentFundsOrderBreakdown2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|OrdrBrkdwnTp|ISO20022.Setr012001.OrderBreakdownType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(OrdrBrkdwnTp))|

---

## Enum ISO20022.Setr012001.LateReport1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LAT2|Int32||XmlEnum("""LAT2""")|1|
||LAT1|Int32||XmlEnum("""LAT1""")|2|

---

## Value ISO20022.Setr012001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr012001.NameAndAddress4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Setr012001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Setr012001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Setr012001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Setr012001.NegotiatedTrade1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNKW|Int32||XmlEnum("""UNKW""")|1|
||NNGO|Int32||XmlEnum("""NNGO""")|2|
||NEGO|Int32||XmlEnum("""NEGO""")|3|

---

## Value ISO20022.Setr012001.OrderBreakdownType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr012001.OrderOriginatorEligibility1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROF|Int32||XmlEnum("""PROF""")|1|
||RETL|Int32||XmlEnum("""RETL""")|2|
||ELIG|Int32||XmlEnum("""ELIG""")|3|

---

## Value ISO20022.Setr012001.OrderWaiver1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InfVal|String||XmlElement()||
|+|OrdrWvrRsn|global::System.Collections.Generic.List<ISO20022.Setr012001.OrderWaiverReason3Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OrdrWvrRsn""",OrdrWvrRsn),validElement(OrdrWvrRsn))|

---

## Enum ISO20022.Setr012001.OrderWaiverReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COMW|Int32||XmlEnum("""COMW""")|1|
||CUTO|Int32||XmlEnum("""CUTO""")|2|
||BMIN|Int32||XmlEnum("""BMIN""")|3|
||FEND|Int32||XmlEnum("""FEND""")|4|
||LATE|Int32||XmlEnum("""LATE""")|5|

---

## Value ISO20022.Setr012001.OrderWaiverReason3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr012001.OtherIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr012001.PartyIdentification125Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Setr012001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Setr012001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Setr012001.PartyIdentification139


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Setr012001.PartyIdentification125Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Setr012001.PartyIdentificationAndAccount222


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctId|String||XmlElement()||
|+|PtyId|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyId))|

---

## Enum ISO20022.Setr012001.PartyIdentificationType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GIIN|Int32||XmlEnum("""GIIN""")|1|
||INCL|Int32||XmlEnum("""INCL""")|2|
||NINV|Int32||XmlEnum("""NINV""")|3|
||EMID|Int32||XmlEnum("""EMID""")|4|
||DRLC|Int32||XmlEnum("""DRLC""")|5|
||AREG|Int32||XmlEnum("""AREG""")|6|
||CPFA|Int32||XmlEnum("""CPFA""")|7|
||ITIN|Int32||XmlEnum("""ITIN""")|8|
||GTIN|Int32||XmlEnum("""GTIN""")|9|
||GUNL|Int32||XmlEnum("""GUNL""")|10|
||SRSA|Int32||XmlEnum("""SRSA""")|11|
||SOCS|Int32||XmlEnum("""SOCS""")|12|
||POCD|Int32||XmlEnum("""POCD""")|13|
||PASS|Int32||XmlEnum("""PASS""")|14|
||OTHR|Int32||XmlEnum("""OTHR""")|15|
||NRIN|Int32||XmlEnum("""NRIN""")|16|
||IDCD|Int32||XmlEnum("""IDCD""")|17|
||ATIN|Int32||XmlEnum("""ATIN""")|18|

---

## Value ISO20022.Setr012001.PaymentCard34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SeqNb|String||XmlElement()||
|+|SctyCd|String||XmlElement()||
|+|CardIssrId|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|CardIssrNm|String||XmlElement()||
|+|XpryDt|String||XmlElement()||
|+|StartDt|String||XmlElement()||
|+|HldrNm|String||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CardIssrId))|

---

## Value ISO20022.Setr012001.PaymentInstrument27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshAcctDtls|ISO20022.Setr012001.InvestmentAccount60||XmlElement()||
|+|BkrsDrftDtls|ISO20022.Setr012001.Cheque21||XmlElement()||
|+|ChqDtls|ISO20022.Setr012001.Cheque21||XmlElement()||
|+|DrctDbtDtls|ISO20022.Setr012001.DirectDebitMandate8||XmlElement()||
|+|CdtTrfDtls|ISO20022.Setr012001.CreditTransfer10||XmlElement()||
|+|PmtCardDtls|ISO20022.Setr012001.PaymentCard34||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshAcctDtls),validElement(BkrsDrftDtls),validElement(ChqDtls),validElement(DrctDbtDtls),validElement(CdtTrfDtls),validElement(PmtCardDtls),validChoice(CshAcctDtls,BkrsDrftDtls,ChqDtls,DrctDbtDtls,CdtTrfDtls,PmtCardDtls))|

---

## Value ISO20022.Setr012001.PaymentTransaction162


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtInstrm|ISO20022.Setr012001.PaymentInstrument27Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtInstrm))|

---

## Value ISO20022.Setr012001.PlaceOfTradeIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OverTheCntr|String||XmlElement()||
|+|Pty|String||XmlElement()||
|+|Xchg|String||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Pty""",Pty,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validPattern("""Xchg""",Xchg,"""[A-Z0-9]{4,4}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validChoice(OverTheCntr,Pty,Xchg,Ctry))|

---

## Value ISO20022.Setr012001.PostalAddress1


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

## Enum ISO20022.Setr012001.PriceMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HIST|Int32||XmlEnum("""HIST""")|1|
||FORW|Int32||XmlEnum("""FORW""")|2|

---

## Value ISO20022.Setr012001.PriceValue1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Setr012001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Setr012001.ProfitAndLoss2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Loss|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|Prft|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Loss),validElement(Prft),validChoice(Loss,Prft))|

---

## Value ISO20022.Setr012001.ReceivingPartiesAndAccount20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RcvgAgtDtls|ISO20022.Setr012001.PartyIdentificationAndAccount222||XmlElement()||
|+|RcvrsIntrmy2Dtls|ISO20022.Setr012001.PartyIdentificationAndAccount222||XmlElement()||
|+|RcvrsIntrmy1Dtls|ISO20022.Setr012001.PartyIdentificationAndAccount222||XmlElement()||
|+|RcvrsCtdnDtls|ISO20022.Setr012001.PartyIdentificationAndAccount222||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcvgAgtDtls),validElement(RcvrsIntrmy2Dtls),validElement(RcvrsIntrmy1Dtls),validElement(RcvrsCtdnDtls))|

---

## Enum ISO20022.Setr012001.ResidentialStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NRES|Int32||XmlEnum("""NRES""")|1|
||PRES|Int32||XmlEnum("""PRES""")|2|
||RESI|Int32||XmlEnum("""RESI""")|3|

---

## Enum ISO20022.Setr012001.RoundingDirection2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RDWN|Int32||XmlEnum("""RDWN""")|1|
||RDUP|Int32||XmlEnum("""RDUP""")|2|

---

## Enum ISO20022.Setr012001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Setr012001.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Value ISO20022.Setr012001.SafekeepingPlaceFormat40Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Setr012001.SafekeepingPlaceTypeAndAnyBICIdentifier3||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Setr012001.SafekeepingPlaceTypeAndText6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Setr012001.SafekeepingPlaceTypeAndAnyBICIdentifier3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Setr012001.SafekeepingPlaceTypeAndText6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr012001.SecurityIdentification25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPrtryId|ISO20022.Setr012001.AlternateSecurityIdentification7||XmlElement()||
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

## Value ISO20022.Setr012001.Series1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrsNm|String||XmlElement()||
|+|SrsDt|ISO20022.Setr012001.DateFormat42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SrsDt))|

---

## Enum ISO20022.Setr012001.SettlementTransactionCondition11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NOMC|Int32||XmlEnum("""NOMC""")|1|

---

## Value ISO20022.Setr012001.SettlementTransactionCondition30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr012001.SignatureType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr012001.SignatureType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ORIG|Int32||XmlEnum("""ORIG""")|1|
||NONE|Int32||XmlEnum("""NONE""")|2|
||ELEC|Int32||XmlEnum("""ELEC""")|3|
||DIGI|Int32||XmlEnum("""DIGI""")|4|

---

## Value ISO20022.Setr012001.SourceOfCash1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr012001.SourceOfCash1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WINS|Int32||XmlEnum("""WINS""")|1|
||SELF|Int32||XmlEnum("""SELF""")|2|
||SVGS|Int32||XmlEnum("""SVGS""")|3|
||SALE|Int32||XmlEnum("""SALE""")|4|
||SEAQ|Int32||XmlEnum("""SEAQ""")|5|
||REPY|Int32||XmlEnum("""REPY""")|6|
||REDM|Int32||XmlEnum("""REDM""")|7|
||REST|Int32||XmlEnum("""REST""")|8|
||INLQ|Int32||XmlEnum("""INLQ""")|9|
||INHE|Int32||XmlEnum("""INHE""")|10|
||GIFT|Int32||XmlEnum("""GIFT""")|11|
||EMIN|Int32||XmlEnum("""EMIN""")|12|
||COMP|Int32||XmlEnum("""COMP""")|13|
||CASH|Int32||XmlEnum("""CASH""")|14|
||ALMY|Int32||XmlEnum("""ALMY""")|15|

---

## Value ISO20022.Setr012001.SubAccount6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctDsgnt|String||XmlElement()||
|+|Chrtc|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Setr012001.SubscriptionExecution14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrdrWvrDtls|ISO20022.Setr012001.OrderWaiver1||XmlElement()||
|+|SgntrTp|ISO20022.Setr012001.SignatureType1Choice||XmlElement()||
|+|TxChanlTp|ISO20022.Setr012001.TransactionChannelType1Choice||XmlElement()||
|+|CstmrCndctClssfctn|ISO20022.Setr012001.CustomerConductClassification1Choice||XmlElement()||
|+|SrcOfCsh|global::System.Collections.Generic.List<ISO20022.Setr012001.SourceOfCash1Choice>||XmlElement()||
|+|Equlstn|ISO20022.Setr012001.Equalisation4||XmlElement()||
|+|RltdPtyDtls|global::System.Collections.Generic.List<ISO20022.Setr012001.Intermediary49>||XmlElement()||
|+|LateRpt|String||XmlElement()||
|+|NgtdTrad|String||XmlElement()||
|+|FinAdvc|String||XmlElement()||
|+|StffClntBrkdwn|global::System.Collections.Generic.List<ISO20022.Setr012001.InvestmentFundsOrderBreakdown2>||XmlElement()||
|+|PrtlSttlmOfCsh|Decimal||XmlElement()||
|+|PrtlSttlmOfUnits|Decimal||XmlElement()||
|+|NonStdSttlmInf|String||XmlElement()||
|+|CshSttlmDtls|ISO20022.Setr012001.PaymentTransaction162||XmlElement()||
|+|SbcptIntrst|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|Rfnd|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|ReqdNAVCcy|String||XmlElement()||
|+|ReqdSttlmCcy|String||XmlElement()||
|+|PhysDlvryDtls|ISO20022.Setr012001.DeliveryParameters3||XmlElement()||
|+|PhysDlvryInd|String||XmlElement()||
|+|SttlmAndCtdyDtls|ISO20022.Setr012001.FundSettlementParameters20||XmlElement()||
|+|InftvTaxDtls|ISO20022.Setr012001.InformativeTax2||XmlElement()||
|+|TxOvrhd|ISO20022.Setr012001.TotalFeesAndTaxes42||XmlElement()||
|+|AcmltnRghtRef|String||XmlElement()||
|+|LttrInttRef|String||XmlElement()||
|+|IncmPref|String||XmlElement()||
|+|FXDtls|global::System.Collections.Generic.List<ISO20022.Setr012001.ForeignExchangeTerms37>||XmlElement()||
|+|IntrmPrftAmt|ISO20022.Setr012001.ProfitAndLoss2Choice||XmlElement()||
|+|CumDvddInd|String||XmlElement()||
|+|BestExctn|String||XmlElement()||
|+|PrtlyExctdInd|String||XmlElement()||
|+|SttlmMtd|String||XmlElement()||
|+|CshSttlmDt|DateTime||XmlElement()||
|+|SttlmAmt|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|InftvPricDtls|global::System.Collections.Generic.List<ISO20022.Setr012001.UnitPrice22>||XmlElement()||
|+|DealgPricDtls|ISO20022.Setr012001.UnitPrice22||XmlElement()||
|+|TradDtTm|ISO20022.Setr012001.DateAndDateTime2Choice||XmlElement()||
|+|GrssAmt|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|NetAmt|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|Rndg|String||XmlElement()||
|+|UnitsNb|Decimal||XmlElement()||
|+|SubAcctForHldg|ISO20022.Setr012001.SubAccount6||XmlElement()||
|+|FinInstrmDtls|ISO20022.Setr012001.FinancialInstrument57||XmlElement()||
|+|OrdrTp|global::System.Collections.Generic.List<ISO20022.Setr012001.FundOrderType4Choice>||XmlElement()||
|+|DealRef|String||XmlElement()||
|+|ClntRef|String||XmlElement()||
|+|OrdrRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrdrWvrDtls),validElement(SgntrTp),validElement(TxChanlTp),validElement(CstmrCndctClssfctn),validList("""SrcOfCsh""",SrcOfCsh),validElement(SrcOfCsh),validElement(Equlstn),validList("""RltdPtyDtls""",RltdPtyDtls),validListMax("""RltdPtyDtls""",RltdPtyDtls,10),validElement(RltdPtyDtls),validList("""StffClntBrkdwn""",StffClntBrkdwn),validListMax("""StffClntBrkdwn""",StffClntBrkdwn,4),validElement(StffClntBrkdwn),validElement(CshSttlmDtls),validElement(SbcptIntrst),validElement(Rfnd),validPattern("""ReqdNAVCcy""",ReqdNAVCcy,"""[A-Z]{3,3}"""),validPattern("""ReqdSttlmCcy""",ReqdSttlmCcy,"""[A-Z]{3,3}"""),validElement(PhysDlvryDtls),validElement(SttlmAndCtdyDtls),validElement(InftvTaxDtls),validElement(TxOvrhd),validList("""FXDtls""",FXDtls),validElement(FXDtls),validElement(IntrmPrftAmt),validElement(SttlmAmt),validList("""InftvPricDtls""",InftvPricDtls),validListMax("""InftvPricDtls""",InftvPricDtls,2),validElement(InftvPricDtls),validElement(DealgPricDtls),validElement(TradDtTm),validElement(GrssAmt),validElement(NetAmt),validElement(SubAcctForHldg),validElement(FinInstrmDtls),validList("""OrdrTp""",OrdrTp),validListMax("""OrdrTp""",OrdrTp,10),validElement(OrdrTp))|

---

## Value ISO20022.Setr012001.SubscriptionMultipleExecution6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BlkCshSttlmDtls|ISO20022.Setr012001.PaymentTransaction162||XmlElement()||
|+|TtlSttlmAmt|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|IndvExctnDtls|global::System.Collections.Generic.List<ISO20022.Setr012001.SubscriptionExecution14>||XmlElement()||
|+|BnfcryDtls|global::System.Collections.Generic.List<ISO20022.Setr012001.IndividualPerson32>||XmlElement()||
|+|InvstmtAcctDtls|ISO20022.Setr012001.InvestmentAccount78||XmlElement()||
|+|CxlRght|ISO20022.Setr012001.CancellationRight1Choice||XmlElement()||
|+|ReqdFutrTradDt|DateTime||XmlElement()||
|+|RcvdDtTm|DateTime||XmlElement()||
|+|OrdrDtTm|DateTime||XmlElement()||
|+|PlcOfTrad|ISO20022.Setr012001.PlaceOfTradeIdentification4Choice||XmlElement()||
|+|MstrRef|String||XmlElement()||
|+|AmdmntInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlkCshSttlmDtls),validElement(TtlSttlmAmt),validRequired("""IndvExctnDtls""",IndvExctnDtls),validList("""IndvExctnDtls""",IndvExctnDtls),validElement(IndvExctnDtls),validList("""BnfcryDtls""",BnfcryDtls),validElement(BnfcryDtls),validElement(InvstmtAcctDtls),validElement(CxlRght),validElement(PlcOfTrad))|

---

## Aspect ISO20022.Setr012001.SubscriptionOrderConfirmationV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xtnsn|global::System.Collections.Generic.List<ISO20022.Setr012001.Extension1>||XmlElement()||
|+|CpyDtls|ISO20022.Setr012001.CopyInformation5||XmlElement()||
|+|MltplExctnDtls|ISO20022.Setr012001.SubscriptionMultipleExecution6||XmlElement()||
|+|RltdRef|ISO20022.Setr012001.AdditionalReference10||XmlElement()||
|+|PrvsRef|global::System.Collections.Generic.List<ISO20022.Setr012001.AdditionalReference10>||XmlElement()||
|+|PoolRef|ISO20022.Setr012001.AdditionalReference11||XmlElement()||
|+|MsgId|ISO20022.Setr012001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(CpyDtls),validElement(MltplExctnDtls),validElement(RltdRef),validList("""PrvsRef""",PrvsRef),validElement(PrvsRef),validElement(PoolRef),validElement(MsgId))|

---

## Value ISO20022.Setr012001.Tax35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxClctnDtls|ISO20022.Setr012001.TaxCalculationInformation10||XmlElement()||
|+|RcptId|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|ApldRate|Decimal||XmlElement()||
|+|ApldAmt|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Setr012001.TaxType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxClctnDtls),validElement(RcptId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(ApldAmt),validElement(Tp))|

---

## Value ISO20022.Setr012001.Tax40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxClctnDtls|ISO20022.Setr012001.TaxCalculationInformation10||XmlElement()||
|+|RcptId|ISO20022.Setr012001.PartyIdentification139||XmlElement()||
|+|XmptnRsn|ISO20022.Setr012001.ExemptionReason1Choice||XmlElement()||
|+|XmptnInd|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|InftvRate|Decimal||XmlElement()||
|+|InftvAmt|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Setr012001.TaxType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxClctnDtls),validElement(RcptId),validElement(XmptnRsn),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(InftvAmt),validElement(Tp))|

---

## Value ISO20022.Setr012001.TaxBasis1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr012001.TaxCalculationInformation10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxblAmt|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|Bsis|ISO20022.Setr012001.TaxBasis1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxblAmt),validElement(Bsis))|

---

## Enum ISO20022.Setr012001.TaxExemptReason1Code


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

## Enum ISO20022.Setr012001.TaxType17Code


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

## Value ISO20022.Setr012001.TaxType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr012001.TaxableIncomePerShareCalculated2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr012001.TaxableIncomePerShareCalculated2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||TSIN|Int32||XmlEnum("""TSIN""")|2|
||TSIY|Int32||XmlEnum("""TSIY""")|3|

---

## Enum ISO20022.Setr012001.TaxationBasis2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PERU|Int32||XmlEnum("""PERU""")|1|
||FLAT|Int32||XmlEnum("""FLAT""")|2|

---

## Enum ISO20022.Setr012001.TaxationBasis5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PERU|Int32||XmlEnum("""PERU""")|1|
||NAVP|Int32||XmlEnum("""NAVP""")|2|
||NEAM|Int32||XmlEnum("""NEAM""")|3|
||GRAM|Int32||XmlEnum("""GRAM""")|4|
||FLAT|Int32||XmlEnum("""FLAT""")|5|

---

## Value ISO20022.Setr012001.TotalFeesAndTaxes42


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndvTax|global::System.Collections.Generic.List<ISO20022.Setr012001.Tax35>||XmlElement()||
|+|IndvFee|global::System.Collections.Generic.List<ISO20022.Setr012001.Fee5>||XmlElement()||
|+|ComrclAgrmtRef|String||XmlElement()||
|+|TtlTaxs|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlFees|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
|+|TtlOvrhdApld|ISO20022.Setr012001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""IndvTax""",IndvTax),validElement(IndvTax),validList("""IndvFee""",IndvFee),validElement(IndvFee),validElement(TtlTaxs),validElement(TtlFees),validElement(TtlOvrhdApld))|

---

## Enum ISO20022.Setr012001.TradeTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CCPN|Int32||XmlEnum("""CCPN""")|1|
||XCPN|Int32||XmlEnum("""XCPN""")|2|

---

## Value ISO20022.Setr012001.TradeTransactionCondition8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr012001.TradingCapacity8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRIN|Int32||XmlEnum("""PRIN""")|1|
||AGEN|Int32||XmlEnum("""AGEN""")|2|

---

## Enum ISO20022.Setr012001.TransactionChannel2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BRAN|Int32||XmlEnum("""BRAN""")|1|
||HOBA|Int32||XmlEnum("""HOBA""")|2|
||FIAD|Int32||XmlEnum("""FIAD""")|3|

---

## Value ISO20022.Setr012001.TransactionChannelType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Setr012001.TypeOfPrice10Code


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

## Value ISO20022.Setr012001.TypeOfPrice46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Setr012001.UnitPrice22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricDiffRsn|String||XmlElement()||
|+|TaxblIncmPerShrClctd|ISO20022.Setr012001.TaxableIncomePerShareCalculated2Choice||XmlElement()||
|+|TaxblIncmPerShr|ISO20022.Setr012001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|PricMtd|String||XmlElement()||
|+|Val|ISO20022.Setr012001.PriceValue1||XmlElement()||
|+|Tp|ISO20022.Setr012001.TypeOfPrice46Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxblIncmPerShrClctd),validElement(TaxblIncmPerShr),validElement(Val),validElement(Tp))|

---

## Enum ISO20022.Setr012001.WaivingInstruction1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WIUN|Int32||XmlEnum("""WIUN""")|1|
||WICA|Int32||XmlEnum("""WICA""")|2|

---

## Value ISO20022.Setr012001.WaivingInstruction2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Setr012001.GenericIdentification47||XmlElement()||
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

