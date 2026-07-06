# camt.053.001.13
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt053001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt053001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt053001.AccountIdentification4Choice *-- ISO20022.Camt053001.GenericAccountIdentification1
    class ISO20022.Camt053001.AccountInterest4 {
        + Tax  : ISO20022.Camt053001.TaxCharges2
        + Rsn  : String
        + FrToDt  : ISO20022.Camt053001.DateTimePeriod1
        + Rate  : global::System.Collections.Generic.List~ISO20022.Camt053001.Rate4~
        + Tp  : ISO20022.Camt053001.InterestType1Choice
    }
    ISO20022.Camt053001.AccountInterest4 *-- ISO20022.Camt053001.TaxCharges2
    ISO20022.Camt053001.AccountInterest4 *-- ISO20022.Camt053001.DateTimePeriod1
    ISO20022.Camt053001.AccountInterest4 *-- ISO20022.Camt053001.Rate4
    ISO20022.Camt053001.AccountInterest4 *-- ISO20022.Camt053001.InterestType1Choice
    class ISO20022.Camt053001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.AccountStatement14 {
        + AddtlStmtInf  : String
        + Ntry  : global::System.Collections.Generic.List~ISO20022.Camt053001.ReportEntry15~
        + TxsSummry  : ISO20022.Camt053001.TotalTransactions6
        + Bal  : global::System.Collections.Generic.List~ISO20022.Camt053001.CashBalance8~
        + Intrst  : global::System.Collections.Generic.List~ISO20022.Camt053001.AccountInterest4~
        + RltdAcct  : ISO20022.Camt053001.CashAccount40
        + Acct  : ISO20022.Camt053001.CashAccount43
        + RptgSrc  : ISO20022.Camt053001.ReportingSource1Choice
        + CpyDplctInd  : String
        + FrToDt  : ISO20022.Camt053001.DateTimePeriod1
        + CreDtTm  : DateTime
        + LglSeqNb  : Decimal
        + RptgSeq  : ISO20022.Camt053001.SequenceRange1Choice
        + ElctrncSeqNb  : Decimal
        + StmtPgntn  : ISO20022.Camt053001.Pagination1
        + Id  : String
    }
    ISO20022.Camt053001.AccountStatement14 *-- ISO20022.Camt053001.ReportEntry15
    ISO20022.Camt053001.AccountStatement14 *-- ISO20022.Camt053001.TotalTransactions6
    ISO20022.Camt053001.AccountStatement14 *-- ISO20022.Camt053001.CashBalance8
    ISO20022.Camt053001.AccountStatement14 *-- ISO20022.Camt053001.AccountInterest4
    ISO20022.Camt053001.AccountStatement14 *-- ISO20022.Camt053001.CashAccount40
    ISO20022.Camt053001.AccountStatement14 *-- ISO20022.Camt053001.CashAccount43
    ISO20022.Camt053001.AccountStatement14 *-- ISO20022.Camt053001.ReportingSource1Choice
    ISO20022.Camt053001.AccountStatement14 *-- ISO20022.Camt053001.DateTimePeriod1
    ISO20022.Camt053001.AccountStatement14 *-- ISO20022.Camt053001.SequenceRange1Choice
    ISO20022.Camt053001.AccountStatement14 *-- ISO20022.Camt053001.Pagination1
    class ISO20022.Camt053001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt053001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmountRange2 {
        + Ccy  : String
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt053001.ImpliedCurrencyAmountRange1Choice
    }
    ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmountRange2 *-- ISO20022.Camt053001.ImpliedCurrencyAmountRange1Choice
    class ISO20022.Camt053001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt053001.AddressType3Choice {
        + Prtry  : ISO20022.Camt053001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt053001.AddressType3Choice *-- ISO20022.Camt053001.GenericIdentification30
    class ISO20022.Camt053001.AmountAndCurrencyExchange4 {
        + PrtryAmt  : global::System.Collections.Generic.List~ISO20022.Camt053001.AmountAndCurrencyExchangeDetails6~
        + AnncdPstngAmt  : ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5
        + CntrValAmt  : ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5
        + TxAmt  : ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5
        + InstdAmt  : ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5
    }
    ISO20022.Camt053001.AmountAndCurrencyExchange4 *-- ISO20022.Camt053001.AmountAndCurrencyExchangeDetails6
    ISO20022.Camt053001.AmountAndCurrencyExchange4 *-- ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5
    ISO20022.Camt053001.AmountAndCurrencyExchange4 *-- ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5
    ISO20022.Camt053001.AmountAndCurrencyExchange4 *-- ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5
    ISO20022.Camt053001.AmountAndCurrencyExchange4 *-- ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5
    class ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5 {
        + CcyXchg  : ISO20022.Camt053001.CurrencyExchange24
        + Amt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5 *-- ISO20022.Camt053001.CurrencyExchange24
    ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt053001.AmountAndCurrencyExchangeDetails6 {
        + CcyXchg  : ISO20022.Camt053001.CurrencyExchange24
        + Amt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + Tp  : String
    }
    ISO20022.Camt053001.AmountAndCurrencyExchangeDetails6 *-- ISO20022.Camt053001.CurrencyExchange24
    ISO20022.Camt053001.AmountAndCurrencyExchangeDetails6 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt053001.AmountAndDirection35 {
        + CdtDbtInd  : String
        + Amt  : Decimal
    }
    class ISO20022.Camt053001.AmountRangeBoundary1 {
        + Incl  : String
        + BdryAmt  : Decimal
    }
    class ISO20022.Camt053001.AttendanceContext1Code {
        UATT = 1
        SATT = 2
        ATTD = 3
    }
    class ISO20022.Camt053001.AuthenticationEntity1Code {
        MERC = 1
        AGNT = 2
        ICCD = 3
    }
    class ISO20022.Camt053001.AuthenticationMethod1Code {
        SCNL = 1
        SNCT = 2
        SCRT = 3
        MERC = 4
        MANU = 5
        PPSG = 6
        CPSG = 7
        FPIN = 8
        NPIN = 9
        BYPS = 10
        UKNW = 11
    }
    class ISO20022.Camt053001.BalanceSubType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.BalanceType10Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.BalanceType13 {
        + SubTp  : ISO20022.Camt053001.BalanceSubType1Choice
        + CdOrPrtry  : ISO20022.Camt053001.BalanceType10Choice
    }
    ISO20022.Camt053001.BalanceType13 *-- ISO20022.Camt053001.BalanceSubType1Choice
    ISO20022.Camt053001.BalanceType13 *-- ISO20022.Camt053001.BalanceType10Choice
    class ISO20022.Camt053001.BankToCustomerStatementV13 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt053001.SupplementaryData1~
        + Stmt  : global::System.Collections.Generic.List~ISO20022.Camt053001.AccountStatement14~
        + GrpHdr  : ISO20022.Camt053001.GroupHeader116
    }
    ISO20022.Camt053001.BankToCustomerStatementV13 *-- ISO20022.Camt053001.SupplementaryData1
    ISO20022.Camt053001.BankToCustomerStatementV13 *-- ISO20022.Camt053001.AccountStatement14
    ISO20022.Camt053001.BankToCustomerStatementV13 *-- ISO20022.Camt053001.GroupHeader116
    class ISO20022.Camt053001.BankTransactionCodeStructure4 {
        + Prtry  : ISO20022.Camt053001.ProprietaryBankTransactionCodeStructure1
        + Domn  : ISO20022.Camt053001.BankTransactionCodeStructure5
    }
    ISO20022.Camt053001.BankTransactionCodeStructure4 *-- ISO20022.Camt053001.ProprietaryBankTransactionCodeStructure1
    ISO20022.Camt053001.BankTransactionCodeStructure4 *-- ISO20022.Camt053001.BankTransactionCodeStructure5
    class ISO20022.Camt053001.BankTransactionCodeStructure5 {
        + Fmly  : ISO20022.Camt053001.BankTransactionCodeStructure6
        + Cd  : String
    }
    ISO20022.Camt053001.BankTransactionCodeStructure5 *-- ISO20022.Camt053001.BankTransactionCodeStructure6
    class ISO20022.Camt053001.BankTransactionCodeStructure6 {
        + SubFmlyCd  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.BatchInformation2 {
        + CdtDbtInd  : String
        + TtlAmt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + NbOfTxs  : String
        + PmtInfId  : String
        + MsgId  : String
    }
    ISO20022.Camt053001.BatchInformation2 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Camt053001.BranchData5
        + FinInstnId  : ISO20022.Camt053001.FinancialInstitutionIdentification23
    }
    ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt053001.BranchData5
    ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt053001.FinancialInstitutionIdentification23
    class ISO20022.Camt053001.BranchData5 {
        + PstlAdr  : ISO20022.Camt053001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt053001.BranchData5 *-- ISO20022.Camt053001.PostalAddress27
    class ISO20022.Camt053001.CSCManagement1Code {
        NCSC = 1
        UNRD = 2
        BYPS = 3
        PRST = 4
    }
    class ISO20022.Camt053001.CardAggregated2 {
        + TxDtRg  : ISO20022.Camt053001.DateOrDateTimePeriod1Choice
        + SeqNbRg  : ISO20022.Camt053001.CardSequenceNumberRange1
        + SaleRcncltnId  : String
        + TxCtgy  : String
        + AddtlSvc  : String
    }
    ISO20022.Camt053001.CardAggregated2 *-- ISO20022.Camt053001.DateOrDateTimePeriod1Choice
    ISO20022.Camt053001.CardAggregated2 *-- ISO20022.Camt053001.CardSequenceNumberRange1
    class ISO20022.Camt053001.CardDataReading1Code {
        ECTL = 1
        CTLS = 2
        DFLE = 3
        CICC = 4
        MGST = 5
        BRCD = 6
        PHYS = 7
        TAGC = 8
    }
    class ISO20022.Camt053001.CardEntry5 {
        + PrePdAcct  : ISO20022.Camt053001.CashAccount40
        + AggtdNtry  : ISO20022.Camt053001.CardAggregated2
        + POI  : ISO20022.Camt053001.PointOfInteraction1
        + Card  : ISO20022.Camt053001.PaymentCard4
    }
    ISO20022.Camt053001.CardEntry5 *-- ISO20022.Camt053001.CashAccount40
    ISO20022.Camt053001.CardEntry5 *-- ISO20022.Camt053001.CardAggregated2
    ISO20022.Camt053001.CardEntry5 *-- ISO20022.Camt053001.PointOfInteraction1
    ISO20022.Camt053001.CardEntry5 *-- ISO20022.Camt053001.PaymentCard4
    class ISO20022.Camt053001.CardIndividualTransaction2 {
        + VldtnSeqNb  : String
        + VldtnDt  : DateTime
        + Pdct  : ISO20022.Camt053001.Product2
        + TxId  : ISO20022.Camt053001.TransactionIdentifier1
        + SeqNb  : String
        + RePresntmntRsn  : String
        + SaleRefNb  : String
        + SaleRcncltnId  : String
        + TxCtgy  : String
        + AddtlSvc  : String
        + PmtCntxt  : ISO20022.Camt053001.PaymentContext3
        + ICCRltdData  : String
    }
    ISO20022.Camt053001.CardIndividualTransaction2 *-- ISO20022.Camt053001.Product2
    ISO20022.Camt053001.CardIndividualTransaction2 *-- ISO20022.Camt053001.TransactionIdentifier1
    ISO20022.Camt053001.CardIndividualTransaction2 *-- ISO20022.Camt053001.PaymentContext3
    class ISO20022.Camt053001.CardPaymentServiceType2Code {
        VCAU = 1
        UNAF = 2
        SOAF = 3
        RECP = 4
        PUCO = 5
        NRES = 6
        LOYT = 7
        INSP = 8
        GRTT = 9
        DCCV = 10
        AGGR = 11
    }
    class ISO20022.Camt053001.CardSecurityInformation1 {
        + CSCVal  : String
        + CSCMgmt  : String
    }
    class ISO20022.Camt053001.CardSequenceNumberRange1 {
        + LastTx  : String
        + FrstTx  : String
    }
    class ISO20022.Camt053001.CardTransaction18 {
        + PrePdAcct  : ISO20022.Camt053001.CashAccount40
        + Tx  : ISO20022.Camt053001.CardTransaction3Choice
        + POI  : ISO20022.Camt053001.PointOfInteraction1
        + Card  : ISO20022.Camt053001.PaymentCard4
    }
    ISO20022.Camt053001.CardTransaction18 *-- ISO20022.Camt053001.CashAccount40
    ISO20022.Camt053001.CardTransaction18 *-- ISO20022.Camt053001.CardTransaction3Choice
    ISO20022.Camt053001.CardTransaction18 *-- ISO20022.Camt053001.PointOfInteraction1
    ISO20022.Camt053001.CardTransaction18 *-- ISO20022.Camt053001.PaymentCard4
    class ISO20022.Camt053001.CardTransaction3Choice {
        + Indv  : ISO20022.Camt053001.CardIndividualTransaction2
        + Aggtd  : ISO20022.Camt053001.CardAggregated2
    }
    ISO20022.Camt053001.CardTransaction3Choice *-- ISO20022.Camt053001.CardIndividualTransaction2
    ISO20022.Camt053001.CardTransaction3Choice *-- ISO20022.Camt053001.CardAggregated2
    class ISO20022.Camt053001.CardholderAuthentication2 {
        + AuthntcnNtty  : String
        + AuthntcnMtd  : String
    }
    class ISO20022.Camt053001.CardholderVerificationCapability1Code {
        SCEC = 1
        CHDT = 2
        PKIS = 3
        APKI = 4
        FBIG = 5
        MNVR = 6
        FBIO = 7
        FDSG = 8
        FEPN = 9
        FCPN = 10
        NPIN = 11
        MNSG = 12
    }
    class ISO20022.Camt053001.CashAccount40 {
        + Prxy  : ISO20022.Camt053001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Camt053001.CashAccountType2Choice
        + Id  : ISO20022.Camt053001.AccountIdentification4Choice
    }
    ISO20022.Camt053001.CashAccount40 *-- ISO20022.Camt053001.ProxyAccountIdentification1
    ISO20022.Camt053001.CashAccount40 *-- ISO20022.Camt053001.CashAccountType2Choice
    ISO20022.Camt053001.CashAccount40 *-- ISO20022.Camt053001.AccountIdentification4Choice
    class ISO20022.Camt053001.CashAccount43 {
        + Svcr  : ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
        + Ownr  : ISO20022.Camt053001.PartyIdentification272
        + Prxy  : ISO20022.Camt053001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Camt053001.CashAccountType2Choice
        + Id  : ISO20022.Camt053001.AccountIdentification4Choice
    }
    ISO20022.Camt053001.CashAccount43 *-- ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt053001.CashAccount43 *-- ISO20022.Camt053001.PartyIdentification272
    ISO20022.Camt053001.CashAccount43 *-- ISO20022.Camt053001.ProxyAccountIdentification1
    ISO20022.Camt053001.CashAccount43 *-- ISO20022.Camt053001.CashAccountType2Choice
    ISO20022.Camt053001.CashAccount43 *-- ISO20022.Camt053001.AccountIdentification4Choice
    class ISO20022.Camt053001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.CashAvailability1 {
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + Dt  : ISO20022.Camt053001.CashAvailabilityDate1Choice
    }
    ISO20022.Camt053001.CashAvailability1 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt053001.CashAvailability1 *-- ISO20022.Camt053001.CashAvailabilityDate1Choice
    class ISO20022.Camt053001.CashAvailabilityDate1Choice {
        + ActlDt  : DateTime
        + NbOfDays  : String
    }
    class ISO20022.Camt053001.CashBalance8 {
        + Avlbty  : global::System.Collections.Generic.List~ISO20022.Camt053001.CashAvailability1~
        + Dt  : ISO20022.Camt053001.DateAndDateTime2Choice
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + CdtLine  : global::System.Collections.Generic.List~ISO20022.Camt053001.CreditLine3~
        + Tp  : ISO20022.Camt053001.BalanceType13
    }
    ISO20022.Camt053001.CashBalance8 *-- ISO20022.Camt053001.CashAvailability1
    ISO20022.Camt053001.CashBalance8 *-- ISO20022.Camt053001.DateAndDateTime2Choice
    ISO20022.Camt053001.CashBalance8 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt053001.CashBalance8 *-- ISO20022.Camt053001.CreditLine3
    ISO20022.Camt053001.CashBalance8 *-- ISO20022.Camt053001.BalanceType13
    class ISO20022.Camt053001.CashDeposit1 {
        + Amt  : ISO20022.Camt053001.ActiveCurrencyAndAmount
        + NbOfNotes  : String
        + NoteDnmtn  : ISO20022.Camt053001.ActiveCurrencyAndAmount
    }
    ISO20022.Camt053001.CashDeposit1 *-- ISO20022.Camt053001.ActiveCurrencyAndAmount
    ISO20022.Camt053001.CashDeposit1 *-- ISO20022.Camt053001.ActiveCurrencyAndAmount
    class ISO20022.Camt053001.CategoryPurpose1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.ChargeBearerType1Code {
        SLEV = 1
        SHAR = 2
        CRED = 3
        DEBT = 4
    }
    class ISO20022.Camt053001.ChargeType3Choice {
        + Prtry  : ISO20022.Camt053001.GenericIdentification3
        + Cd  : String
    }
    ISO20022.Camt053001.ChargeType3Choice *-- ISO20022.Camt053001.GenericIdentification3
    class ISO20022.Camt053001.Charges15 {
        + Rcrd  : global::System.Collections.Generic.List~ISO20022.Camt053001.ChargesRecord8~
        + TtlChrgsAndTaxAmt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt053001.Charges15 *-- ISO20022.Camt053001.ChargesRecord8
    ISO20022.Camt053001.Charges15 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt053001.ChargesRecord8 {
        + Tax  : ISO20022.Camt053001.TaxCharges2
        + Agt  : ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
        + Br  : String
        + Rate  : Decimal
        + Tp  : ISO20022.Camt053001.ChargeType3Choice
        + ChrgInclInd  : String
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt053001.ChargesRecord8 *-- ISO20022.Camt053001.TaxCharges2
    ISO20022.Camt053001.ChargesRecord8 *-- ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt053001.ChargesRecord8 *-- ISO20022.Camt053001.ChargeType3Choice
    ISO20022.Camt053001.ChargesRecord8 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt053001.ClearingChannel2Code {
        BOOK = 1
        MPNS = 2
        RTNS = 3
        RTGS = 4
    }
    class ISO20022.Camt053001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt053001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt053001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt053001.ClearingSystemIdentification2Choice
    class ISO20022.Camt053001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt053001.OtherContact1~
        + Dept  : String
        + Rspnsblty  : String
        + JobTitl  : String
        + EmailPurp  : String
        + EmailAdr  : String
        + URLAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + NmPrfx  : String
    }
    ISO20022.Camt053001.Contact13 *-- ISO20022.Camt053001.OtherContact1
    class ISO20022.Camt053001.CopyDuplicate1Code {
        DUPL = 1
        COPY = 2
        CODU = 3
    }
    class ISO20022.Camt053001.CorporateAction82 {
        + OffclCorpActnEvtId  : String
        + CorpActnEvtId  : String
        + EvtTp  : ISO20022.Camt053001.CorporateActionEventType104Choice
    }
    ISO20022.Camt053001.CorporateAction82 *-- ISO20022.Camt053001.CorporateActionEventType104Choice
    class ISO20022.Camt053001.CorporateActionEventType104Choice {
        + Prtry  : ISO20022.Camt053001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt053001.CorporateActionEventType104Choice *-- ISO20022.Camt053001.GenericIdentification30
    class ISO20022.Camt053001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Camt053001.CreditLine3 {
        + Dt  : ISO20022.Camt053001.DateAndDateTime2Choice
        + Amt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + Tp  : ISO20022.Camt053001.CreditLineType1Choice
        + Incl  : String
    }
    ISO20022.Camt053001.CreditLine3 *-- ISO20022.Camt053001.DateAndDateTime2Choice
    ISO20022.Camt053001.CreditLine3 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt053001.CreditLine3 *-- ISO20022.Camt053001.CreditLineType1Choice
    class ISO20022.Camt053001.CreditLineType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.CreditorReferenceInformation3 {
        + Ref  : String
        + Tp  : ISO20022.Camt053001.CreditorReferenceType3
    }
    ISO20022.Camt053001.CreditorReferenceInformation3 *-- ISO20022.Camt053001.CreditorReferenceType3
    class ISO20022.Camt053001.CreditorReferenceType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.CreditorReferenceType3 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Camt053001.CreditorReferenceType2Choice
    }
    ISO20022.Camt053001.CreditorReferenceType3 *-- ISO20022.Camt053001.CreditorReferenceType2Choice
    class ISO20022.Camt053001.CurrencyExchange24 {
        + XchgRateBase  : Decimal
        + QtnDt  : DateTime
        + CtrctId  : String
        + XchgRate  : Decimal
        + UnitCcy  : String
        + TrgtCcy  : String
        + SrcCcy  : String
    }
    class ISO20022.Camt053001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Camt053001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Camt053001.DateAndType1 {
        + Dt  : DateTime
        + Tp  : ISO20022.Camt053001.DateType2Choice
    }
    ISO20022.Camt053001.DateAndType1 *-- ISO20022.Camt053001.DateType2Choice
    class ISO20022.Camt053001.DateOrDateTimePeriod1Choice {
        + DtTm  : ISO20022.Camt053001.DateTimePeriod1
        + Dt  : ISO20022.Camt053001.DatePeriod2
    }
    ISO20022.Camt053001.DateOrDateTimePeriod1Choice *-- ISO20022.Camt053001.DateTimePeriod1
    ISO20022.Camt053001.DateOrDateTimePeriod1Choice *-- ISO20022.Camt053001.DatePeriod2
    class ISO20022.Camt053001.DatePeriod2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Camt053001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Camt053001.DateType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.DisplayCapabilities1 {
        + LineWidth  : String
        + NbOfLines  : String
        + DispTp  : String
    }
    class ISO20022.Camt053001.DocumentAdjustment1 {
        + AddtlInf  : String
        + Rsn  : String
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt053001.DocumentAdjustment1 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt053001.DocumentAmount1 {
        + Amt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + Tp  : ISO20022.Camt053001.DocumentAmountType1Choice
    }
    ISO20022.Camt053001.DocumentAmount1 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt053001.DocumentAmount1 *-- ISO20022.Camt053001.DocumentAmountType1Choice
    class ISO20022.Camt053001.DocumentAmountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.DocumentLineIdentification1 {
        + RltdDt  : DateTime
        + Nb  : String
        + Tp  : ISO20022.Camt053001.DocumentLineType1
    }
    ISO20022.Camt053001.DocumentLineIdentification1 *-- ISO20022.Camt053001.DocumentLineType1
    class ISO20022.Camt053001.DocumentLineInformation2 {
        + Amt  : ISO20022.Camt053001.RemittanceAmount4
        + Desc  : String
        + Id  : global::System.Collections.Generic.List~ISO20022.Camt053001.DocumentLineIdentification1~
    }
    ISO20022.Camt053001.DocumentLineInformation2 *-- ISO20022.Camt053001.RemittanceAmount4
    ISO20022.Camt053001.DocumentLineInformation2 *-- ISO20022.Camt053001.DocumentLineIdentification1
    class ISO20022.Camt053001.DocumentLineType1 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Camt053001.DocumentLineType1Choice
    }
    ISO20022.Camt053001.DocumentLineType1 *-- ISO20022.Camt053001.DocumentLineType1Choice
    class ISO20022.Camt053001.DocumentLineType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.DocumentType1 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Camt053001.DocumentType2Choice
    }
    ISO20022.Camt053001.DocumentType1 *-- ISO20022.Camt053001.DocumentType2Choice
    class ISO20022.Camt053001.DocumentType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.EntryDetails14 {
        + TxDtls  : global::System.Collections.Generic.List~ISO20022.Camt053001.EntryTransaction15~
        + Btch  : ISO20022.Camt053001.BatchInformation2
    }
    ISO20022.Camt053001.EntryDetails14 *-- ISO20022.Camt053001.EntryTransaction15
    ISO20022.Camt053001.EntryDetails14 *-- ISO20022.Camt053001.BatchInformation2
    class ISO20022.Camt053001.EntryStatus1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.EntryTransaction15 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt053001.SupplementaryData1~
        + AddtlTxInf  : String
        + InstrCpy  : String
        + CardTx  : ISO20022.Camt053001.CardTransaction18
        + CshDpst  : global::System.Collections.Generic.List~ISO20022.Camt053001.CashDeposit1~
        + UndrlygAllcn  : global::System.Collections.Generic.List~ISO20022.Camt053001.TransactionAllocation1~
        + SfkpgAcct  : ISO20022.Camt053001.SecuritiesAccount19
        + RltdCorpActn  : ISO20022.Camt053001.CorporateAction82
        + RtrInf  : ISO20022.Camt053001.PaymentReturnReason8
        + Tax  : ISO20022.Camt053001.TaxData1
        + FinInstrmId  : ISO20022.Camt053001.SecurityIdentification19
        + RltdQties  : global::System.Collections.Generic.List~ISO20022.Camt053001.TransactionQuantities4Choice~
        + RltdPric  : ISO20022.Camt053001.TransactionPrice4Choice
        + RltdDts  : ISO20022.Camt053001.TransactionDates3
        + RmtInf  : ISO20022.Camt053001.RemittanceInformation22
        + RltdRmtInf  : global::System.Collections.Generic.List~ISO20022.Camt053001.RemittanceLocation8~
        + Purp  : ISO20022.Camt053001.Purpose2Choice
        + PmtTpInf  : ISO20022.Camt053001.PaymentTypeInformation27
        + LclInstrm  : ISO20022.Camt053001.LocalInstrument2Choice
        + RltdAgts  : ISO20022.Camt053001.TransactionAgents6
        + RltdPties  : ISO20022.Camt053001.TransactionParties12
        + Intrst  : ISO20022.Camt053001.TransactionInterest4
        + Chrgs  : ISO20022.Camt053001.Charges15
        + BkTxCd  : ISO20022.Camt053001.BankTransactionCodeStructure4
        + Avlbty  : global::System.Collections.Generic.List~ISO20022.Camt053001.CashAvailability1~
        + AmtDtls  : ISO20022.Camt053001.AmountAndCurrencyExchange4
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + Refs  : ISO20022.Camt053001.TransactionReferences6
    }
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.SupplementaryData1
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.CardTransaction18
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.CashDeposit1
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.TransactionAllocation1
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.SecuritiesAccount19
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.CorporateAction82
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.PaymentReturnReason8
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.TaxData1
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.SecurityIdentification19
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.TransactionQuantities4Choice
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.TransactionPrice4Choice
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.TransactionDates3
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.RemittanceInformation22
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.RemittanceLocation8
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.Purpose2Choice
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.PaymentTypeInformation27
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.LocalInstrument2Choice
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.TransactionAgents6
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.TransactionParties12
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.TransactionInterest4
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.Charges15
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.BankTransactionCodeStructure4
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.CashAvailability1
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.AmountAndCurrencyExchange4
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt053001.EntryTransaction15 *-- ISO20022.Camt053001.TransactionReferences6
    class ISO20022.Camt053001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Camt053001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt053001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt053001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt053001.FinancialInstitutionIdentification23 *-- ISO20022.Camt053001.GenericFinancialIdentification1
    ISO20022.Camt053001.FinancialInstitutionIdentification23 *-- ISO20022.Camt053001.PostalAddress27
    ISO20022.Camt053001.FinancialInstitutionIdentification23 *-- ISO20022.Camt053001.ClearingSystemMemberIdentification2
    class ISO20022.Camt053001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Camt053001.FromToAmountRange1 {
        + ToAmt  : ISO20022.Camt053001.AmountRangeBoundary1
        + FrAmt  : ISO20022.Camt053001.AmountRangeBoundary1
    }
    ISO20022.Camt053001.FromToAmountRange1 *-- ISO20022.Camt053001.AmountRangeBoundary1
    ISO20022.Camt053001.FromToAmountRange1 *-- ISO20022.Camt053001.AmountRangeBoundary1
    class ISO20022.Camt053001.Garnishment4 {
        + MplyeeTermntnInd  : String
        + FmlyMdclInsrncInd  : String
        + RmtdAmt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + Dt  : DateTime
        + RefNb  : String
        + GrnshmtAdmstr  : ISO20022.Camt053001.PartyIdentification272
        + Grnshee  : ISO20022.Camt053001.PartyIdentification272
        + Tp  : ISO20022.Camt053001.GarnishmentType1
    }
    ISO20022.Camt053001.Garnishment4 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt053001.Garnishment4 *-- ISO20022.Camt053001.PartyIdentification272
    ISO20022.Camt053001.Garnishment4 *-- ISO20022.Camt053001.PartyIdentification272
    ISO20022.Camt053001.Garnishment4 *-- ISO20022.Camt053001.GarnishmentType1
    class ISO20022.Camt053001.GarnishmentType1 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Camt053001.GarnishmentType1Choice
    }
    ISO20022.Camt053001.GarnishmentType1 *-- ISO20022.Camt053001.GarnishmentType1Choice
    class ISO20022.Camt053001.GarnishmentType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt053001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt053001.GenericAccountIdentification1 *-- ISO20022.Camt053001.AccountSchemeName1Choice
    class ISO20022.Camt053001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt053001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt053001.GenericFinancialIdentification1 *-- ISO20022.Camt053001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt053001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Camt053001.GenericIdentification3 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt053001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt053001.GenericIdentification32 {
        + ShrtNm  : String
        + Issr  : String
        + Tp  : String
        + Id  : String
    }
    class ISO20022.Camt053001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt053001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt053001.GenericOrganisationIdentification3 *-- ISO20022.Camt053001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Camt053001.GenericPersonIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt053001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt053001.GenericPersonIdentification2 *-- ISO20022.Camt053001.PersonIdentificationSchemeName1Choice
    class ISO20022.Camt053001.GroupHeader116 {
        + AddtlInf  : String
        + OrgnlBizQry  : ISO20022.Camt053001.OriginalBusinessQuery1
        + MsgPgntn  : ISO20022.Camt053001.Pagination1
        + MsgRcpt  : ISO20022.Camt053001.PartyIdentification272
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Camt053001.GroupHeader116 *-- ISO20022.Camt053001.OriginalBusinessQuery1
    ISO20022.Camt053001.GroupHeader116 *-- ISO20022.Camt053001.Pagination1
    ISO20022.Camt053001.GroupHeader116 *-- ISO20022.Camt053001.PartyIdentification272
    class ISO20022.Camt053001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.ImpliedCurrencyAmountRange1Choice {
        + NEQAmt  : Decimal
        + EQAmt  : Decimal
        + FrToAmt  : ISO20022.Camt053001.FromToAmountRange1
        + ToAmt  : ISO20022.Camt053001.AmountRangeBoundary1
        + FrAmt  : ISO20022.Camt053001.AmountRangeBoundary1
    }
    ISO20022.Camt053001.ImpliedCurrencyAmountRange1Choice *-- ISO20022.Camt053001.FromToAmountRange1
    ISO20022.Camt053001.ImpliedCurrencyAmountRange1Choice *-- ISO20022.Camt053001.AmountRangeBoundary1
    ISO20022.Camt053001.ImpliedCurrencyAmountRange1Choice *-- ISO20022.Camt053001.AmountRangeBoundary1
    class ISO20022.Camt053001.InterestRecord2 {
        + Tax  : ISO20022.Camt053001.TaxCharges2
        + Rsn  : String
        + FrToDt  : ISO20022.Camt053001.DateTimePeriod1
        + Rate  : ISO20022.Camt053001.Rate4
        + Tp  : ISO20022.Camt053001.InterestType1Choice
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt053001.InterestRecord2 *-- ISO20022.Camt053001.TaxCharges2
    ISO20022.Camt053001.InterestRecord2 *-- ISO20022.Camt053001.DateTimePeriod1
    ISO20022.Camt053001.InterestRecord2 *-- ISO20022.Camt053001.Rate4
    ISO20022.Camt053001.InterestRecord2 *-- ISO20022.Camt053001.InterestType1Choice
    ISO20022.Camt053001.InterestRecord2 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt053001.InterestType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.InterestType1Code {
        OVRN = 1
        INDY = 2
    }
    class ISO20022.Camt053001.LocalInstrument2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.MessageIdentification2 {
        + MsgId  : String
        + MsgNmId  : String
    }
    class ISO20022.Camt053001.NameAndAddress18 {
        + Adr  : ISO20022.Camt053001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Camt053001.NameAndAddress18 *-- ISO20022.Camt053001.PostalAddress27
    class ISO20022.Camt053001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Camt053001.NumberAndSumOfTransactions1 {
        + Sum  : Decimal
        + NbOfNtries  : String
    }
    class ISO20022.Camt053001.NumberAndSumOfTransactions4 {
        + TtlNetNtry  : ISO20022.Camt053001.AmountAndDirection35
        + Sum  : Decimal
        + NbOfNtries  : String
    }
    ISO20022.Camt053001.NumberAndSumOfTransactions4 *-- ISO20022.Camt053001.AmountAndDirection35
    class ISO20022.Camt053001.OnLineCapability1Code {
        SMON = 1
        ONLN = 2
        OFLN = 3
    }
    class ISO20022.Camt053001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt053001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Camt053001.OrganisationIdentification39 *-- ISO20022.Camt053001.GenericOrganisationIdentification3
    class ISO20022.Camt053001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Camt053001.OriginalBusinessQuery1 {
        + CreDtTm  : DateTime
        + MsgNmId  : String
        + MsgId  : String
    }
    class ISO20022.Camt053001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Camt053001.OtherIdentification1 {
        + Tp  : ISO20022.Camt053001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Camt053001.OtherIdentification1 *-- ISO20022.Camt053001.IdentificationSource3Choice
    class ISO20022.Camt053001.POIComponentType1Code {
        PEDV = 1
        SECM = 2
        CHIT = 3
        MRIT = 4
        EMVO = 5
        EMVK = 6
        SOFT = 7
    }
    class ISO20022.Camt053001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Camt053001.Party50Choice {
        + Agt  : ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
        + Pty  : ISO20022.Camt053001.PartyIdentification272
    }
    ISO20022.Camt053001.Party50Choice *-- ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt053001.Party50Choice *-- ISO20022.Camt053001.PartyIdentification272
    class ISO20022.Camt053001.Party52Choice {
        + PrvtId  : ISO20022.Camt053001.PersonIdentification18
        + OrgId  : ISO20022.Camt053001.OrganisationIdentification39
    }
    ISO20022.Camt053001.Party52Choice *-- ISO20022.Camt053001.PersonIdentification18
    ISO20022.Camt053001.Party52Choice *-- ISO20022.Camt053001.OrganisationIdentification39
    class ISO20022.Camt053001.PartyIdentification272 {
        + CtctDtls  : ISO20022.Camt053001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Camt053001.Party52Choice
        + PstlAdr  : ISO20022.Camt053001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Camt053001.PartyIdentification272 *-- ISO20022.Camt053001.Contact13
    ISO20022.Camt053001.PartyIdentification272 *-- ISO20022.Camt053001.Party52Choice
    ISO20022.Camt053001.PartyIdentification272 *-- ISO20022.Camt053001.PostalAddress27
    class ISO20022.Camt053001.PartyType3Code {
        DLIS = 1
        CISS = 2
        ACQR = 3
        ITAG = 4
        ACCP = 5
        MERC = 6
        OPOI = 7
    }
    class ISO20022.Camt053001.PartyType4Code {
        TAXH = 1
        CISS = 2
        ACQR = 3
        ITAG = 4
        ACCP = 5
        MERC = 6
    }
    class ISO20022.Camt053001.PaymentCard4 {
        + AddtlCardData  : String
        + CardBrnd  : ISO20022.Camt053001.GenericIdentification1
        + CardCtryCd  : String
        + PlainCardData  : ISO20022.Camt053001.PlainCardData1
    }
    ISO20022.Camt053001.PaymentCard4 *-- ISO20022.Camt053001.GenericIdentification1
    ISO20022.Camt053001.PaymentCard4 *-- ISO20022.Camt053001.PlainCardData1
    class ISO20022.Camt053001.PaymentContext3 {
        + AuthntcnMtd  : ISO20022.Camt053001.CardholderAuthentication2
        + FllbckInd  : String
        + CardDataNtryMd  : String
        + AttndntLang  : String
        + AttndntMsgCpbl  : String
        + TxChanl  : String
        + TxEnvt  : String
        + AttndncCntxt  : String
        + OnLineCntxt  : String
        + CrdhldrPres  : String
        + CardPres  : String
    }
    ISO20022.Camt053001.PaymentContext3 *-- ISO20022.Camt053001.CardholderAuthentication2
    class ISO20022.Camt053001.PaymentReturnReason8 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + Rsn  : ISO20022.Camt053001.ReturnReason5Choice
        + Orgtr  : ISO20022.Camt053001.PartyIdentification272
        + OrgnlBkTxCd  : ISO20022.Camt053001.BankTransactionCodeStructure4
    }
    ISO20022.Camt053001.PaymentReturnReason8 *-- ISO20022.Camt053001.ReturnReason5Choice
    ISO20022.Camt053001.PaymentReturnReason8 *-- ISO20022.Camt053001.PartyIdentification272
    ISO20022.Camt053001.PaymentReturnReason8 *-- ISO20022.Camt053001.BankTransactionCodeStructure4
    class ISO20022.Camt053001.PaymentTypeInformation27 {
        + CtgyPurp  : ISO20022.Camt053001.CategoryPurpose1Choice
        + SeqTp  : String
        + LclInstrm  : ISO20022.Camt053001.LocalInstrument2Choice
        + SvcLvl  : global::System.Collections.Generic.List~ISO20022.Camt053001.ServiceLevel8Choice~
        + ClrChanl  : String
        + InstrPrty  : String
    }
    ISO20022.Camt053001.PaymentTypeInformation27 *-- ISO20022.Camt053001.CategoryPurpose1Choice
    ISO20022.Camt053001.PaymentTypeInformation27 *-- ISO20022.Camt053001.LocalInstrument2Choice
    ISO20022.Camt053001.PaymentTypeInformation27 *-- ISO20022.Camt053001.ServiceLevel8Choice
    class ISO20022.Camt053001.PersonIdentification18 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt053001.GenericPersonIdentification2~
        + DtAndPlcOfBirth  : ISO20022.Camt053001.DateAndPlaceOfBirth1
    }
    ISO20022.Camt053001.PersonIdentification18 *-- ISO20022.Camt053001.GenericPersonIdentification2
    ISO20022.Camt053001.PersonIdentification18 *-- ISO20022.Camt053001.DateAndPlaceOfBirth1
    class ISO20022.Camt053001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.PlainCardData1 {
        + CardSctyCd  : ISO20022.Camt053001.CardSecurityInformation1
        + TrckData  : global::System.Collections.Generic.List~ISO20022.Camt053001.TrackData1~
        + SvcCd  : String
        + XpryDt  : String
        + FctvDt  : String
        + CardSeqNb  : String
        + PAN  : String
    }
    ISO20022.Camt053001.PlainCardData1 *-- ISO20022.Camt053001.CardSecurityInformation1
    ISO20022.Camt053001.PlainCardData1 *-- ISO20022.Camt053001.TrackData1
    class ISO20022.Camt053001.PointOfInteraction1 {
        + Cmpnt  : global::System.Collections.Generic.List~ISO20022.Camt053001.PointOfInteractionComponent1~
        + Cpblties  : ISO20022.Camt053001.PointOfInteractionCapabilities1
        + GrpId  : String
        + SysNm  : String
        + Id  : ISO20022.Camt053001.GenericIdentification32
    }
    ISO20022.Camt053001.PointOfInteraction1 *-- ISO20022.Camt053001.PointOfInteractionComponent1
    ISO20022.Camt053001.PointOfInteraction1 *-- ISO20022.Camt053001.PointOfInteractionCapabilities1
    ISO20022.Camt053001.PointOfInteraction1 *-- ISO20022.Camt053001.GenericIdentification32
    class ISO20022.Camt053001.PointOfInteractionCapabilities1 {
        + PrtLineWidth  : String
        + DispCpblties  : global::System.Collections.Generic.List~ISO20022.Camt053001.DisplayCapabilities1~
        + OnLineCpblties  : String
        + CrdhldrVrfctnCpblties  : global::System.Collections.Generic.List~String~
        + CardRdngCpblties  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Camt053001.PointOfInteractionCapabilities1 *-- ISO20022.Camt053001.DisplayCapabilities1
    class ISO20022.Camt053001.PointOfInteractionComponent1 {
        + ApprvlNb  : global::System.Collections.Generic.List~String~
        + SrlNb  : String
        + VrsnNb  : String
        + Mdl  : String
        + ManfctrId  : String
        + POICmpntTp  : String
    }
    class ISO20022.Camt053001.PostalAddress27 {
        + AdrLine  : global::System.Collections.Generic.List~String~
        + Ctry  : String
        + CtrySubDvsn  : String
        + DstrctNm  : String
        + TwnLctnNm  : String
        + TwnNm  : String
        + PstCd  : String
        + Room  : String
        + PstBx  : String
        + UnitNb  : String
        + Flr  : String
        + BldgNm  : String
        + BldgNb  : String
        + StrtNm  : String
        + SubDept  : String
        + Dept  : String
        + CareOf  : String
        + AdrTp  : ISO20022.Camt053001.AddressType3Choice
    }
    ISO20022.Camt053001.PostalAddress27 *-- ISO20022.Camt053001.AddressType3Choice
    class ISO20022.Camt053001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Camt053001.Price7 {
        + Val  : ISO20022.Camt053001.PriceRateOrAmount3Choice
        + Tp  : ISO20022.Camt053001.YieldedOrValueType1Choice
    }
    ISO20022.Camt053001.Price7 *-- ISO20022.Camt053001.PriceRateOrAmount3Choice
    ISO20022.Camt053001.Price7 *-- ISO20022.Camt053001.YieldedOrValueType1Choice
    class ISO20022.Camt053001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Camt053001.PriceRateOrAmount3Choice *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Camt053001.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Camt053001.Priority2Code {
        NORM = 1
        HIGH = 2
    }
    class ISO20022.Camt053001.Product2 {
        + AddtlPdctInf  : String
        + TaxTp  : String
        + PdctAmt  : Decimal
        + UnitPric  : Decimal
        + PdctQty  : Decimal
        + UnitOfMeasr  : String
        + PdctCd  : String
    }
    class ISO20022.Camt053001.ProprietaryAgent5 {
        + Agt  : ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
        + Tp  : String
    }
    ISO20022.Camt053001.ProprietaryAgent5 *-- ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    class ISO20022.Camt053001.ProprietaryBankTransactionCodeStructure1 {
        + Issr  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.ProprietaryDate3 {
        + Dt  : ISO20022.Camt053001.DateAndDateTime2Choice
        + Tp  : String
    }
    ISO20022.Camt053001.ProprietaryDate3 *-- ISO20022.Camt053001.DateAndDateTime2Choice
    class ISO20022.Camt053001.ProprietaryParty6 {
        + Pty  : ISO20022.Camt053001.Party50Choice
        + Tp  : String
    }
    ISO20022.Camt053001.ProprietaryParty6 *-- ISO20022.Camt053001.Party50Choice
    class ISO20022.Camt053001.ProprietaryPrice2 {
        + Pric  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + Tp  : String
    }
    ISO20022.Camt053001.ProprietaryPrice2 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt053001.ProprietaryQuantity1 {
        + Qty  : String
        + Tp  : String
    }
    class ISO20022.Camt053001.ProprietaryReference1 {
        + Ref  : String
        + Tp  : String
    }
    class ISO20022.Camt053001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Camt053001.ProxyAccountType1Choice
    }
    ISO20022.Camt053001.ProxyAccountIdentification1 *-- ISO20022.Camt053001.ProxyAccountType1Choice
    class ISO20022.Camt053001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.Purpose2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.Rate4 {
        + VldtyRg  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmountRange2
        + Tp  : ISO20022.Camt053001.RateType4Choice
    }
    ISO20022.Camt053001.Rate4 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmountRange2
    ISO20022.Camt053001.Rate4 *-- ISO20022.Camt053001.RateType4Choice
    class ISO20022.Camt053001.RateType4Choice {
        + Othr  : String
        + Pctg  : Decimal
    }
    class ISO20022.Camt053001.References74Choice {
        + OthrTxId  : String
        + TradId  : String
        + CmonId  : String
        + PoolId  : String
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + IntraBalMvmntId  : String
        + IntraPosMvmntId  : String
        + SctiesSttlmTxId  : String
    }
    class ISO20022.Camt053001.ReferredDocumentInformation8 {
        + LineDtls  : global::System.Collections.Generic.List~ISO20022.Camt053001.DocumentLineInformation2~
        + RltdDt  : ISO20022.Camt053001.DateAndType1
        + Nb  : String
        + Tp  : ISO20022.Camt053001.DocumentType1
    }
    ISO20022.Camt053001.ReferredDocumentInformation8 *-- ISO20022.Camt053001.DocumentLineInformation2
    ISO20022.Camt053001.ReferredDocumentInformation8 *-- ISO20022.Camt053001.DateAndType1
    ISO20022.Camt053001.ReferredDocumentInformation8 *-- ISO20022.Camt053001.DocumentType1
    class ISO20022.Camt053001.RemittanceAmount4 {
        + AdjstmntAmtAndRsn  : global::System.Collections.Generic.List~ISO20022.Camt053001.DocumentAdjustment1~
        + RmtAmtAndTp  : global::System.Collections.Generic.List~ISO20022.Camt053001.DocumentAmount1~
    }
    ISO20022.Camt053001.RemittanceAmount4 *-- ISO20022.Camt053001.DocumentAdjustment1
    ISO20022.Camt053001.RemittanceAmount4 *-- ISO20022.Camt053001.DocumentAmount1
    class ISO20022.Camt053001.RemittanceInformation22 {
        + Strd  : global::System.Collections.Generic.List~ISO20022.Camt053001.StructuredRemittanceInformation18~
        + Ustrd  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Camt053001.RemittanceInformation22 *-- ISO20022.Camt053001.StructuredRemittanceInformation18
    class ISO20022.Camt053001.RemittanceLocation8 {
        + RmtLctnDtls  : global::System.Collections.Generic.List~ISO20022.Camt053001.RemittanceLocationData2~
        + RmtId  : String
    }
    ISO20022.Camt053001.RemittanceLocation8 *-- ISO20022.Camt053001.RemittanceLocationData2
    class ISO20022.Camt053001.RemittanceLocationData2 {
        + PstlAdr  : ISO20022.Camt053001.NameAndAddress18
        + ElctrncAdr  : String
        + Mtd  : String
    }
    ISO20022.Camt053001.RemittanceLocationData2 *-- ISO20022.Camt053001.NameAndAddress18
    class ISO20022.Camt053001.RemittanceLocationMethod2Code {
        SMSM = 1
        POST = 2
        EMAL = 3
        URID = 4
        EDIC = 5
        FAXI = 6
    }
    class ISO20022.Camt053001.ReportEntry15 {
        + AddtlNtryInf  : String
        + NtryDtls  : global::System.Collections.Generic.List~ISO20022.Camt053001.EntryDetails14~
        + CardTx  : ISO20022.Camt053001.CardEntry5
        + Intrst  : ISO20022.Camt053001.TransactionInterest4
        + TechInptChanl  : ISO20022.Camt053001.TechnicalInputChannel1Choice
        + Chrgs  : ISO20022.Camt053001.Charges15
        + AmtDtls  : ISO20022.Camt053001.AmountAndCurrencyExchange4
        + AddtlInfInd  : ISO20022.Camt053001.MessageIdentification2
        + ComssnWvrInd  : String
        + BkTxCd  : ISO20022.Camt053001.BankTransactionCodeStructure4
        + Avlbty  : global::System.Collections.Generic.List~ISO20022.Camt053001.CashAvailability1~
        + AcctSvcrRef  : String
        + ValDt  : ISO20022.Camt053001.DateAndDateTime2Choice
        + BookgDt  : ISO20022.Camt053001.DateAndDateTime2Choice
        + Sts  : ISO20022.Camt053001.EntryStatus1Choice
        + RvslInd  : String
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + NtryRef  : String
    }
    ISO20022.Camt053001.ReportEntry15 *-- ISO20022.Camt053001.EntryDetails14
    ISO20022.Camt053001.ReportEntry15 *-- ISO20022.Camt053001.CardEntry5
    ISO20022.Camt053001.ReportEntry15 *-- ISO20022.Camt053001.TransactionInterest4
    ISO20022.Camt053001.ReportEntry15 *-- ISO20022.Camt053001.TechnicalInputChannel1Choice
    ISO20022.Camt053001.ReportEntry15 *-- ISO20022.Camt053001.Charges15
    ISO20022.Camt053001.ReportEntry15 *-- ISO20022.Camt053001.AmountAndCurrencyExchange4
    ISO20022.Camt053001.ReportEntry15 *-- ISO20022.Camt053001.MessageIdentification2
    ISO20022.Camt053001.ReportEntry15 *-- ISO20022.Camt053001.BankTransactionCodeStructure4
    ISO20022.Camt053001.ReportEntry15 *-- ISO20022.Camt053001.CashAvailability1
    ISO20022.Camt053001.ReportEntry15 *-- ISO20022.Camt053001.DateAndDateTime2Choice
    ISO20022.Camt053001.ReportEntry15 *-- ISO20022.Camt053001.DateAndDateTime2Choice
    ISO20022.Camt053001.ReportEntry15 *-- ISO20022.Camt053001.EntryStatus1Choice
    ISO20022.Camt053001.ReportEntry15 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt053001.ReportingSource1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.ReturnReason5Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Camt053001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Camt053001.SecuritiesAccount19 *-- ISO20022.Camt053001.GenericIdentification30
    class ISO20022.Camt053001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Camt053001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Camt053001.SecurityIdentification19 *-- ISO20022.Camt053001.OtherIdentification1
    class ISO20022.Camt053001.SequenceRange1 {
        + ToSeq  : String
        + FrSeq  : String
    }
    class ISO20022.Camt053001.SequenceRange1Choice {
        + NEQSeq  : global::System.Collections.Generic.List~String~
        + EQSeq  : global::System.Collections.Generic.List~String~
        + FrToSeq  : global::System.Collections.Generic.List~ISO20022.Camt053001.SequenceRange1~
        + ToSeq  : String
        + FrSeq  : String
    }
    ISO20022.Camt053001.SequenceRange1Choice *-- ISO20022.Camt053001.SequenceRange1
    class ISO20022.Camt053001.SequenceType3Code {
        RPRE = 1
        OOFF = 2
        FNAL = 3
        RCUR = 4
        FRST = 5
    }
    class ISO20022.Camt053001.ServiceLevel8Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.StructuredRemittanceInformation18 {
        + AddtlRmtInf  : global::System.Collections.Generic.List~String~
        + GrnshmtRmt  : ISO20022.Camt053001.Garnishment4
        + TaxRmt  : ISO20022.Camt053001.TaxData1
        + Invcee  : ISO20022.Camt053001.PartyIdentification272
        + Invcr  : ISO20022.Camt053001.PartyIdentification272
        + CdtrRefInf  : ISO20022.Camt053001.CreditorReferenceInformation3
        + RfrdDocAmt  : ISO20022.Camt053001.RemittanceAmount4
        + RfrdDocInf  : global::System.Collections.Generic.List~ISO20022.Camt053001.ReferredDocumentInformation8~
    }
    ISO20022.Camt053001.StructuredRemittanceInformation18 *-- ISO20022.Camt053001.Garnishment4
    ISO20022.Camt053001.StructuredRemittanceInformation18 *-- ISO20022.Camt053001.TaxData1
    ISO20022.Camt053001.StructuredRemittanceInformation18 *-- ISO20022.Camt053001.PartyIdentification272
    ISO20022.Camt053001.StructuredRemittanceInformation18 *-- ISO20022.Camt053001.PartyIdentification272
    ISO20022.Camt053001.StructuredRemittanceInformation18 *-- ISO20022.Camt053001.CreditorReferenceInformation3
    ISO20022.Camt053001.StructuredRemittanceInformation18 *-- ISO20022.Camt053001.RemittanceAmount4
    ISO20022.Camt053001.StructuredRemittanceInformation18 *-- ISO20022.Camt053001.ReferredDocumentInformation8
    class ISO20022.Camt053001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt053001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt053001.SupplementaryData1 *-- ISO20022.Camt053001.SupplementaryDataEnvelope1
    class ISO20022.Camt053001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Camt053001.TaxAmount3 {
        + Dtls  : global::System.Collections.Generic.List~ISO20022.Camt053001.TaxRecordDetails3~
        + TtlAmt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + TaxblBaseAmt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + Rate  : Decimal
    }
    ISO20022.Camt053001.TaxAmount3 *-- ISO20022.Camt053001.TaxRecordDetails3
    ISO20022.Camt053001.TaxAmount3 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt053001.TaxAmount3 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt053001.TaxAuthorisation1 {
        + Nm  : String
        + Titl  : String
    }
    class ISO20022.Camt053001.TaxCharges2 {
        + Amt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + Rate  : Decimal
        + Id  : String
    }
    ISO20022.Camt053001.TaxCharges2 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt053001.TaxData1 {
        + Rcrd  : global::System.Collections.Generic.List~ISO20022.Camt053001.TaxRecord3~
        + SeqNb  : Decimal
        + Dt  : DateTime
        + TtlTaxAmt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + TtlTaxblBaseAmt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + Mtd  : String
        + RefNb  : String
        + AdmstnZone  : String
        + UltmtDbtr  : ISO20022.Camt053001.TaxParty2
        + Dbtr  : ISO20022.Camt053001.TaxParty2
        + Cdtr  : ISO20022.Camt053001.TaxParty1
    }
    ISO20022.Camt053001.TaxData1 *-- ISO20022.Camt053001.TaxRecord3
    ISO20022.Camt053001.TaxData1 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt053001.TaxData1 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt053001.TaxData1 *-- ISO20022.Camt053001.TaxParty2
    ISO20022.Camt053001.TaxData1 *-- ISO20022.Camt053001.TaxParty2
    ISO20022.Camt053001.TaxData1 *-- ISO20022.Camt053001.TaxParty1
    class ISO20022.Camt053001.TaxParty1 {
        + TaxTp  : String
        + RegnId  : String
        + TaxId  : String
    }
    class ISO20022.Camt053001.TaxParty2 {
        + Authstn  : ISO20022.Camt053001.TaxAuthorisation1
        + TaxTp  : String
        + RegnId  : String
        + TaxId  : String
    }
    ISO20022.Camt053001.TaxParty2 *-- ISO20022.Camt053001.TaxAuthorisation1
    class ISO20022.Camt053001.TaxPeriod3 {
        + FrToDt  : ISO20022.Camt053001.DatePeriod2
        + Tp  : String
        + Yr  : Int32
    }
    ISO20022.Camt053001.TaxPeriod3 *-- ISO20022.Camt053001.DatePeriod2
    class ISO20022.Camt053001.TaxRecord3 {
        + AddtlInf  : String
        + TaxAmt  : ISO20022.Camt053001.TaxAmount3
        + Prd  : ISO20022.Camt053001.TaxPeriod3
        + FrmsCd  : String
        + CertId  : String
        + DbtrSts  : String
        + CtgyDtls  : String
        + Ctgy  : String
        + Tp  : String
    }
    ISO20022.Camt053001.TaxRecord3 *-- ISO20022.Camt053001.TaxAmount3
    ISO20022.Camt053001.TaxRecord3 *-- ISO20022.Camt053001.TaxPeriod3
    class ISO20022.Camt053001.TaxRecordDetails3 {
        + Amt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
        + Prd  : ISO20022.Camt053001.TaxPeriod3
    }
    ISO20022.Camt053001.TaxRecordDetails3 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt053001.TaxRecordDetails3 *-- ISO20022.Camt053001.TaxPeriod3
    class ISO20022.Camt053001.TaxRecordPeriod1Code {
        HLF2 = 1
        HLF1 = 2
        QTR4 = 3
        QTR3 = 4
        QTR2 = 5
        QTR1 = 6
        MM12 = 7
        MM11 = 8
        MM10 = 9
        MM09 = 10
        MM08 = 11
        MM07 = 12
        MM06 = 13
        MM05 = 14
        MM04 = 15
        MM03 = 16
        MM02 = 17
        MM01 = 18
    }
    class ISO20022.Camt053001.TechnicalInputChannel1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt053001.TotalTransactions6 {
        + TtlNtriesPerBkTxCd  : global::System.Collections.Generic.List~ISO20022.Camt053001.TotalsPerBankTransactionCode5~
        + TtlDbtNtries  : ISO20022.Camt053001.NumberAndSumOfTransactions1
        + TtlCdtNtries  : ISO20022.Camt053001.NumberAndSumOfTransactions1
        + TtlNtries  : ISO20022.Camt053001.NumberAndSumOfTransactions4
    }
    ISO20022.Camt053001.TotalTransactions6 *-- ISO20022.Camt053001.TotalsPerBankTransactionCode5
    ISO20022.Camt053001.TotalTransactions6 *-- ISO20022.Camt053001.NumberAndSumOfTransactions1
    ISO20022.Camt053001.TotalTransactions6 *-- ISO20022.Camt053001.NumberAndSumOfTransactions1
    ISO20022.Camt053001.TotalTransactions6 *-- ISO20022.Camt053001.NumberAndSumOfTransactions4
    class ISO20022.Camt053001.TotalsPerBankTransactionCode5 {
        + Dt  : ISO20022.Camt053001.DateAndDateTime2Choice
        + Avlbty  : global::System.Collections.Generic.List~ISO20022.Camt053001.CashAvailability1~
        + BkTxCd  : ISO20022.Camt053001.BankTransactionCodeStructure4
        + FcstInd  : String
        + DbtNtries  : ISO20022.Camt053001.NumberAndSumOfTransactions1
        + CdtNtries  : ISO20022.Camt053001.NumberAndSumOfTransactions1
        + TtlNetNtry  : ISO20022.Camt053001.AmountAndDirection35
        + Sum  : Decimal
        + NbOfNtries  : String
    }
    ISO20022.Camt053001.TotalsPerBankTransactionCode5 *-- ISO20022.Camt053001.DateAndDateTime2Choice
    ISO20022.Camt053001.TotalsPerBankTransactionCode5 *-- ISO20022.Camt053001.CashAvailability1
    ISO20022.Camt053001.TotalsPerBankTransactionCode5 *-- ISO20022.Camt053001.BankTransactionCodeStructure4
    ISO20022.Camt053001.TotalsPerBankTransactionCode5 *-- ISO20022.Camt053001.NumberAndSumOfTransactions1
    ISO20022.Camt053001.TotalsPerBankTransactionCode5 *-- ISO20022.Camt053001.NumberAndSumOfTransactions1
    ISO20022.Camt053001.TotalsPerBankTransactionCode5 *-- ISO20022.Camt053001.AmountAndDirection35
    class ISO20022.Camt053001.TrackData1 {
        + TrckVal  : String
        + TrckNb  : String
    }
    class ISO20022.Camt053001.TransactionAgents6 {
        + Prtry  : global::System.Collections.Generic.List~ISO20022.Camt053001.ProprietaryAgent5~
        + SttlmPlc  : ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
        + IssgAgt  : ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
        + DlvrgAgt  : ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
        + RcvgAgt  : ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
        + IntrmyAgt3  : ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
        + IntrmyAgt2  : ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
        + IntrmyAgt1  : ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
        + CdtrAgt  : ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
        + DbtrAgt  : ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
        + InstdAgt  : ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
        + InstgAgt  : ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    }
    ISO20022.Camt053001.TransactionAgents6 *-- ISO20022.Camt053001.ProprietaryAgent5
    ISO20022.Camt053001.TransactionAgents6 *-- ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt053001.TransactionAgents6 *-- ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt053001.TransactionAgents6 *-- ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt053001.TransactionAgents6 *-- ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt053001.TransactionAgents6 *-- ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt053001.TransactionAgents6 *-- ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt053001.TransactionAgents6 *-- ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt053001.TransactionAgents6 *-- ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt053001.TransactionAgents6 *-- ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt053001.TransactionAgents6 *-- ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt053001.TransactionAgents6 *-- ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8
    class ISO20022.Camt053001.TransactionAllocation1 {
        + RltdRefs  : global::System.Collections.Generic.List~ISO20022.Camt053001.References74Choice~
        + Ref  : String
        + Purp  : ISO20022.Camt053001.Purpose2Choice
        + Acct  : ISO20022.Camt053001.CashAccount40
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt053001.TransactionAllocation1 *-- ISO20022.Camt053001.References74Choice
    ISO20022.Camt053001.TransactionAllocation1 *-- ISO20022.Camt053001.Purpose2Choice
    ISO20022.Camt053001.TransactionAllocation1 *-- ISO20022.Camt053001.CashAccount40
    ISO20022.Camt053001.TransactionAllocation1 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt053001.TransactionChannel1Code {
        TVPY = 1
        ECOM = 2
        TLPH = 3
        MAIL = 4
    }
    class ISO20022.Camt053001.TransactionDates3 {
        + Prtry  : global::System.Collections.Generic.List~ISO20022.Camt053001.ProprietaryDate3~
        + TxDtTm  : DateTime
        + EndDt  : DateTime
        + StartDt  : DateTime
        + IntrBkSttlmDt  : DateTime
        + TradDt  : DateTime
        + TradActvtyCtrctlSttlmDt  : DateTime
        + AccptncDtTm  : DateTime
    }
    ISO20022.Camt053001.TransactionDates3 *-- ISO20022.Camt053001.ProprietaryDate3
    class ISO20022.Camt053001.TransactionEnvironment1Code {
        PUBL = 1
        PRIV = 2
        MERC = 3
    }
    class ISO20022.Camt053001.TransactionIdentifier1 {
        + TxRef  : String
        + TxDtTm  : DateTime
    }
    class ISO20022.Camt053001.TransactionInterest4 {
        + Rcrd  : global::System.Collections.Generic.List~ISO20022.Camt053001.InterestRecord2~
        + TtlIntrstAndTaxAmt  : ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt053001.TransactionInterest4 *-- ISO20022.Camt053001.InterestRecord2
    ISO20022.Camt053001.TransactionInterest4 *-- ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt053001.TransactionParties12 {
        + Prtry  : global::System.Collections.Generic.List~ISO20022.Camt053001.ProprietaryParty6~
        + TradgPty  : ISO20022.Camt053001.Party50Choice
        + UltmtCdtr  : ISO20022.Camt053001.Party50Choice
        + CdtrAcct  : ISO20022.Camt053001.CashAccount40
        + Cdtr  : ISO20022.Camt053001.Party50Choice
        + UltmtDbtr  : ISO20022.Camt053001.Party50Choice
        + DbtrAcct  : ISO20022.Camt053001.CashAccount40
        + Dbtr  : ISO20022.Camt053001.Party50Choice
        + InitgPty  : ISO20022.Camt053001.Party50Choice
    }
    ISO20022.Camt053001.TransactionParties12 *-- ISO20022.Camt053001.ProprietaryParty6
    ISO20022.Camt053001.TransactionParties12 *-- ISO20022.Camt053001.Party50Choice
    ISO20022.Camt053001.TransactionParties12 *-- ISO20022.Camt053001.Party50Choice
    ISO20022.Camt053001.TransactionParties12 *-- ISO20022.Camt053001.CashAccount40
    ISO20022.Camt053001.TransactionParties12 *-- ISO20022.Camt053001.Party50Choice
    ISO20022.Camt053001.TransactionParties12 *-- ISO20022.Camt053001.Party50Choice
    ISO20022.Camt053001.TransactionParties12 *-- ISO20022.Camt053001.CashAccount40
    ISO20022.Camt053001.TransactionParties12 *-- ISO20022.Camt053001.Party50Choice
    ISO20022.Camt053001.TransactionParties12 *-- ISO20022.Camt053001.Party50Choice
    class ISO20022.Camt053001.TransactionPrice4Choice {
        + Prtry  : global::System.Collections.Generic.List~ISO20022.Camt053001.ProprietaryPrice2~
        + DealPric  : ISO20022.Camt053001.Price7
    }
    ISO20022.Camt053001.TransactionPrice4Choice *-- ISO20022.Camt053001.ProprietaryPrice2
    ISO20022.Camt053001.TransactionPrice4Choice *-- ISO20022.Camt053001.Price7
    class ISO20022.Camt053001.TransactionQuantities4Choice {
        + Prtry  : ISO20022.Camt053001.ProprietaryQuantity1
        + OrgnlAndCurFaceAmt  : ISO20022.Camt053001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Camt053001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Camt053001.TransactionQuantities4Choice *-- ISO20022.Camt053001.ProprietaryQuantity1
    ISO20022.Camt053001.TransactionQuantities4Choice *-- ISO20022.Camt053001.OriginalAndCurrentQuantities1
    ISO20022.Camt053001.TransactionQuantities4Choice *-- ISO20022.Camt053001.FinancialInstrumentQuantity33Choice
    class ISO20022.Camt053001.TransactionReferences6 {
        + Prtry  : global::System.Collections.Generic.List~ISO20022.Camt053001.ProprietaryReference1~
        + PrcgId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
        + ClrSysRef  : String
        + ChqNb  : String
        + MndtId  : String
        + TxId  : String
        + UETR  : String
        + EndToEndId  : String
        + InstrId  : String
        + PmtInfId  : String
        + AcctSvcrRef  : String
        + MsgId  : String
    }
    ISO20022.Camt053001.TransactionReferences6 *-- ISO20022.Camt053001.ProprietaryReference1
    class ISO20022.Camt053001.UnitOfMeasure1Code {
        ACRE = 1
        SQIN = 2
        SQFO = 3
        SQYA = 4
        SQMI = 5
        SMIL = 6
        SCMT = 7
        SMET = 8
        ARES = 9
        HECT = 10
        SQKI = 11
        YARD = 12
        KMET = 13
        MILE = 14
        USPI = 15
        GBPI = 16
        USQA = 17
        GBQA = 18
        USOU = 19
        GBOU = 20
        MILI = 21
        CELI = 22
        LITR = 23
        MMET = 24
        CMET = 25
        METR = 26
        PUND = 27
        KILO = 28
        INCH = 29
        GRAM = 30
        USGA = 31
        GBGA = 32
        FOOT = 33
        TONS = 34
        PIEC = 35
    }
    class ISO20022.Camt053001.UserInterface2Code {
        CDSP = 1
        MDSP = 2
    }
    class ISO20022.Camt053001.YieldedOrValueType1Choice {
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

## Value ISO20022.Camt053001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt053001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt053001.AccountInterest4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tax|ISO20022.Camt053001.TaxCharges2||XmlElement()||
|+|Rsn|String||XmlElement()||
|+|FrToDt|ISO20022.Camt053001.DateTimePeriod1||XmlElement()||
|+|Rate|global::System.Collections.Generic.List<ISO20022.Camt053001.Rate4>||XmlElement()||
|+|Tp|ISO20022.Camt053001.InterestType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tax),validElement(FrToDt),validList("""Rate""",Rate),validElement(Rate),validElement(Tp))|

---

## Value ISO20022.Camt053001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.AccountStatement14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlStmtInf|String||XmlElement()||
|+|Ntry|global::System.Collections.Generic.List<ISO20022.Camt053001.ReportEntry15>||XmlElement()||
|+|TxsSummry|ISO20022.Camt053001.TotalTransactions6||XmlElement()||
|+|Bal|global::System.Collections.Generic.List<ISO20022.Camt053001.CashBalance8>||XmlElement()||
|+|Intrst|global::System.Collections.Generic.List<ISO20022.Camt053001.AccountInterest4>||XmlElement()||
|+|RltdAcct|ISO20022.Camt053001.CashAccount40||XmlElement()||
|+|Acct|ISO20022.Camt053001.CashAccount43||XmlElement()||
|+|RptgSrc|ISO20022.Camt053001.ReportingSource1Choice||XmlElement()||
|+|CpyDplctInd|String||XmlElement()||
|+|FrToDt|ISO20022.Camt053001.DateTimePeriod1||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|LglSeqNb|Decimal||XmlElement()||
|+|RptgSeq|ISO20022.Camt053001.SequenceRange1Choice||XmlElement()||
|+|ElctrncSeqNb|Decimal||XmlElement()||
|+|StmtPgntn|ISO20022.Camt053001.Pagination1||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Ntry""",Ntry),validElement(Ntry),validElement(TxsSummry),validRequired("""Bal""",Bal),validList("""Bal""",Bal),validElement(Bal),validList("""Intrst""",Intrst),validElement(Intrst),validElement(RltdAcct),validElement(Acct),validElement(RptgSrc),validElement(FrToDt),validElement(RptgSeq),validElement(StmtPgntn))|

---

## Value ISO20022.Camt053001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Camt053001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmountRange2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt053001.ImpliedCurrencyAmountRange1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Amt))|

---

## Enum ISO20022.Camt053001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt053001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt053001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.AmountAndCurrencyExchange4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryAmt|global::System.Collections.Generic.List<ISO20022.Camt053001.AmountAndCurrencyExchangeDetails6>||XmlElement()||
|+|AnncdPstngAmt|ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5||XmlElement()||
|+|CntrValAmt|ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5||XmlElement()||
|+|TxAmt|ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5||XmlElement()||
|+|InstdAmt|ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryAmt""",PrtryAmt),validElement(PrtryAmt),validElement(AnncdPstngAmt),validElement(CntrValAmt),validElement(TxAmt),validElement(InstdAmt))|

---

## Value ISO20022.Camt053001.AmountAndCurrencyExchangeDetails5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyXchg|ISO20022.Camt053001.CurrencyExchange24||XmlElement()||
|+|Amt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CcyXchg),validElement(Amt))|

---

## Value ISO20022.Camt053001.AmountAndCurrencyExchangeDetails6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyXchg|ISO20022.Camt053001.CurrencyExchange24||XmlElement()||
|+|Amt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CcyXchg),validElement(Amt))|

---

## Value ISO20022.Camt053001.AmountAndDirection35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.AmountRangeBoundary1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Incl|String||XmlElement()||
|+|BdryAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Camt053001.AttendanceContext1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UATT|Int32||XmlEnum("""UATT""")|1|
||SATT|Int32||XmlEnum("""SATT""")|2|
||ATTD|Int32||XmlEnum("""ATTD""")|3|

---

## Enum ISO20022.Camt053001.AuthenticationEntity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MERC|Int32||XmlEnum("""MERC""")|1|
||AGNT|Int32||XmlEnum("""AGNT""")|2|
||ICCD|Int32||XmlEnum("""ICCD""")|3|

---

## Enum ISO20022.Camt053001.AuthenticationMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SCNL|Int32||XmlEnum("""SCNL""")|1|
||SNCT|Int32||XmlEnum("""SNCT""")|2|
||SCRT|Int32||XmlEnum("""SCRT""")|3|
||MERC|Int32||XmlEnum("""MERC""")|4|
||MANU|Int32||XmlEnum("""MANU""")|5|
||PPSG|Int32||XmlEnum("""PPSG""")|6|
||CPSG|Int32||XmlEnum("""CPSG""")|7|
||FPIN|Int32||XmlEnum("""FPIN""")|8|
||NPIN|Int32||XmlEnum("""NPIN""")|9|
||BYPS|Int32||XmlEnum("""BYPS""")|10|
||UKNW|Int32||XmlEnum("""UKNW""")|11|

---

## Value ISO20022.Camt053001.BalanceSubType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.BalanceType10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.BalanceType13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubTp|ISO20022.Camt053001.BalanceSubType1Choice||XmlElement()||
|+|CdOrPrtry|ISO20022.Camt053001.BalanceType10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SubTp),validElement(CdOrPrtry))|

---

## Aspect ISO20022.Camt053001.BankToCustomerStatementV13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt053001.SupplementaryData1>||XmlElement()||
|+|Stmt|global::System.Collections.Generic.List<ISO20022.Camt053001.AccountStatement14>||XmlElement()||
|+|GrpHdr|ISO20022.Camt053001.GroupHeader116||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""Stmt""",Stmt),validList("""Stmt""",Stmt),validElement(Stmt),validElement(GrpHdr))|

---

## Value ISO20022.Camt053001.BankTransactionCodeStructure4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt053001.ProprietaryBankTransactionCodeStructure1||XmlElement()||
|+|Domn|ISO20022.Camt053001.BankTransactionCodeStructure5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Domn))|

---

## Value ISO20022.Camt053001.BankTransactionCodeStructure5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fmly|ISO20022.Camt053001.BankTransactionCodeStructure6||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Fmly))|

---

## Value ISO20022.Camt053001.BankTransactionCodeStructure6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubFmlyCd|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.BatchInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|TtlAmt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|NbOfTxs|String||XmlElement()||
|+|PmtInfId|String||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlAmt),validPattern("""NbOfTxs""",NbOfTxs,"""[0-9]{1,15}"""))|

---

## Value ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt053001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Camt053001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt053001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt053001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Enum ISO20022.Camt053001.CSCManagement1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NCSC|Int32||XmlEnum("""NCSC""")|1|
||UNRD|Int32||XmlEnum("""UNRD""")|2|
||BYPS|Int32||XmlEnum("""BYPS""")|3|
||PRST|Int32||XmlEnum("""PRST""")|4|

---

## Value ISO20022.Camt053001.CardAggregated2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxDtRg|ISO20022.Camt053001.DateOrDateTimePeriod1Choice||XmlElement()||
|+|SeqNbRg|ISO20022.Camt053001.CardSequenceNumberRange1||XmlElement()||
|+|SaleRcncltnId|String||XmlElement()||
|+|TxCtgy|String||XmlElement()||
|+|AddtlSvc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxDtRg),validElement(SeqNbRg))|

---

## Enum ISO20022.Camt053001.CardDataReading1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ECTL|Int32||XmlEnum("""ECTL""")|1|
||CTLS|Int32||XmlEnum("""CTLS""")|2|
||DFLE|Int32||XmlEnum("""DFLE""")|3|
||CICC|Int32||XmlEnum("""CICC""")|4|
||MGST|Int32||XmlEnum("""MGST""")|5|
||BRCD|Int32||XmlEnum("""BRCD""")|6|
||PHYS|Int32||XmlEnum("""PHYS""")|7|
||TAGC|Int32||XmlEnum("""TAGC""")|8|

---

## Value ISO20022.Camt053001.CardEntry5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrePdAcct|ISO20022.Camt053001.CashAccount40||XmlElement()||
|+|AggtdNtry|ISO20022.Camt053001.CardAggregated2||XmlElement()||
|+|POI|ISO20022.Camt053001.PointOfInteraction1||XmlElement()||
|+|Card|ISO20022.Camt053001.PaymentCard4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrePdAcct),validElement(AggtdNtry),validElement(POI),validElement(Card))|

---

## Value ISO20022.Camt053001.CardIndividualTransaction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VldtnSeqNb|String||XmlElement()||
|+|VldtnDt|DateTime||XmlElement()||
|+|Pdct|ISO20022.Camt053001.Product2||XmlElement()||
|+|TxId|ISO20022.Camt053001.TransactionIdentifier1||XmlElement()||
|+|SeqNb|String||XmlElement()||
|+|RePresntmntRsn|String||XmlElement()||
|+|SaleRefNb|String||XmlElement()||
|+|SaleRcncltnId|String||XmlElement()||
|+|TxCtgy|String||XmlElement()||
|+|AddtlSvc|String||XmlElement()||
|+|PmtCntxt|ISO20022.Camt053001.PaymentContext3||XmlElement()||
|+|ICCRltdData|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pdct),validElement(TxId),validElement(PmtCntxt))|

---

## Enum ISO20022.Camt053001.CardPaymentServiceType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VCAU|Int32||XmlEnum("""VCAU""")|1|
||UNAF|Int32||XmlEnum("""UNAF""")|2|
||SOAF|Int32||XmlEnum("""SOAF""")|3|
||RECP|Int32||XmlEnum("""RECP""")|4|
||PUCO|Int32||XmlEnum("""PUCO""")|5|
||NRES|Int32||XmlEnum("""NRES""")|6|
||LOYT|Int32||XmlEnum("""LOYT""")|7|
||INSP|Int32||XmlEnum("""INSP""")|8|
||GRTT|Int32||XmlEnum("""GRTT""")|9|
||DCCV|Int32||XmlEnum("""DCCV""")|10|
||AGGR|Int32||XmlEnum("""AGGR""")|11|

---

## Value ISO20022.Camt053001.CardSecurityInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CSCVal|String||XmlElement()||
|+|CSCMgmt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CSCVal""",CSCVal,"""[0-9]{3,4}"""))|

---

## Value ISO20022.Camt053001.CardSequenceNumberRange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastTx|String||XmlElement()||
|+|FrstTx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.CardTransaction18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrePdAcct|ISO20022.Camt053001.CashAccount40||XmlElement()||
|+|Tx|ISO20022.Camt053001.CardTransaction3Choice||XmlElement()||
|+|POI|ISO20022.Camt053001.PointOfInteraction1||XmlElement()||
|+|Card|ISO20022.Camt053001.PaymentCard4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrePdAcct),validElement(Tx),validElement(POI),validElement(Card))|

---

## Value ISO20022.Camt053001.CardTransaction3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indv|ISO20022.Camt053001.CardIndividualTransaction2||XmlElement()||
|+|Aggtd|ISO20022.Camt053001.CardAggregated2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indv),validElement(Aggtd),validChoice(Indv,Aggtd))|

---

## Value ISO20022.Camt053001.CardholderAuthentication2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthntcnNtty|String||XmlElement()||
|+|AuthntcnMtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Camt053001.CardholderVerificationCapability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SCEC|Int32||XmlEnum("""SCEC""")|1|
||CHDT|Int32||XmlEnum("""CHDT""")|2|
||PKIS|Int32||XmlEnum("""PKIS""")|3|
||APKI|Int32||XmlEnum("""APKI""")|4|
||FBIG|Int32||XmlEnum("""FBIG""")|5|
||MNVR|Int32||XmlEnum("""MNVR""")|6|
||FBIO|Int32||XmlEnum("""FBIO""")|7|
||FDSG|Int32||XmlEnum("""FDSG""")|8|
||FEPN|Int32||XmlEnum("""FEPN""")|9|
||FCPN|Int32||XmlEnum("""FCPN""")|10|
||NPIN|Int32||XmlEnum("""NPIN""")|11|
||MNSG|Int32||XmlEnum("""MNSG""")|12|

---

## Value ISO20022.Camt053001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Camt053001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Camt053001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Camt053001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Camt053001.CashAccount43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Svcr|ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Ownr|ISO20022.Camt053001.PartyIdentification272||XmlElement()||
|+|Prxy|ISO20022.Camt053001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Camt053001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Camt053001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Svcr),validElement(Ownr),validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Camt053001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.CashAvailability1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Dt|ISO20022.Camt053001.CashAvailabilityDate1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Dt))|

---

## Value ISO20022.Camt053001.CashAvailabilityDate1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ActlDt|DateTime||XmlElement()||
|+|NbOfDays|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""NbOfDays""",NbOfDays,"""[\+]{0,1}[0-9]{1,15}"""),validChoice(ActlDt,NbOfDays))|

---

## Value ISO20022.Camt053001.CashBalance8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Avlbty|global::System.Collections.Generic.List<ISO20022.Camt053001.CashAvailability1>||XmlElement()||
|+|Dt|ISO20022.Camt053001.DateAndDateTime2Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtLine|global::System.Collections.Generic.List<ISO20022.Camt053001.CreditLine3>||XmlElement()||
|+|Tp|ISO20022.Camt053001.BalanceType13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Avlbty""",Avlbty),validElement(Avlbty),validElement(Dt),validElement(Amt),validList("""CdtLine""",CdtLine),validElement(CdtLine),validElement(Tp))|

---

## Value ISO20022.Camt053001.CashDeposit1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt053001.ActiveCurrencyAndAmount||XmlElement()||
|+|NbOfNotes|String||XmlElement()||
|+|NoteDnmtn|ISO20022.Camt053001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validPattern("""NbOfNotes""",NbOfNotes,"""[0-9]{1,15}"""),validElement(NoteDnmtn))|

---

## Value ISO20022.Camt053001.CategoryPurpose1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt053001.ChargeBearerType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLEV|Int32||XmlEnum("""SLEV""")|1|
||SHAR|Int32||XmlEnum("""SHAR""")|2|
||CRED|Int32||XmlEnum("""CRED""")|3|
||DEBT|Int32||XmlEnum("""DEBT""")|4|

---

## Value ISO20022.Camt053001.ChargeType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt053001.GenericIdentification3||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.Charges15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rcrd|global::System.Collections.Generic.List<ISO20022.Camt053001.ChargesRecord8>||XmlElement()||
|+|TtlChrgsAndTaxAmt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rcrd""",Rcrd),validElement(Rcrd),validElement(TtlChrgsAndTaxAmt))|

---

## Value ISO20022.Camt053001.ChargesRecord8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tax|ISO20022.Camt053001.TaxCharges2||XmlElement()||
|+|Agt|ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Br|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Tp|ISO20022.Camt053001.ChargeType3Choice||XmlElement()||
|+|ChrgInclInd|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tax),validElement(Agt),validElement(Tp),validElement(Amt))|

---

## Enum ISO20022.Camt053001.ClearingChannel2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOOK|Int32||XmlEnum("""BOOK""")|1|
||MPNS|Int32||XmlEnum("""MPNS""")|2|
||RTNS|Int32||XmlEnum("""RTNS""")|3|
||RTGS|Int32||XmlEnum("""RTGS""")|4|

---

## Value ISO20022.Camt053001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt053001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Camt053001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt053001.OtherContact1>||XmlElement()||
|+|Dept|String||XmlElement()||
|+|Rspnsblty|String||XmlElement()||
|+|JobTitl|String||XmlElement()||
|+|EmailPurp|String||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|URLAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobNb""",MobNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Enum ISO20022.Camt053001.CopyDuplicate1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DUPL|Int32||XmlEnum("""DUPL""")|1|
||COPY|Int32||XmlEnum("""COPY""")|2|
||CODU|Int32||XmlEnum("""CODU""")|3|

---

## Value ISO20022.Camt053001.CorporateAction82


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OffclCorpActnEvtId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
|+|EvtTp|ISO20022.Camt053001.CorporateActionEventType104Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EvtTp))|

---

## Value ISO20022.Camt053001.CorporateActionEventType104Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt053001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt053001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Camt053001.CreditLine3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dt|ISO20022.Camt053001.DateAndDateTime2Choice||XmlElement()||
|+|Amt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Camt053001.CreditLineType1Choice||XmlElement()||
|+|Incl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dt),validElement(Amt),validElement(Tp))|

---

## Value ISO20022.Camt053001.CreditLineType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.CreditorReferenceInformation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|String||XmlElement()||
|+|Tp|ISO20022.Camt053001.CreditorReferenceType3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt053001.CreditorReferenceType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.CreditorReferenceType3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Camt053001.CreditorReferenceType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Camt053001.CurrencyExchange24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XchgRateBase|Decimal||XmlElement()||
|+|QtnDt|DateTime||XmlElement()||
|+|CtrctId|String||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|UnitCcy|String||XmlElement()||
|+|TrgtCcy|String||XmlElement()||
|+|SrcCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""),validPattern("""TrgtCcy""",TrgtCcy,"""[A-Z]{3,3}"""),validPattern("""SrcCcy""",SrcCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Camt053001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Camt053001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Camt053001.DateAndType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dt|DateTime||XmlElement()||
|+|Tp|ISO20022.Camt053001.DateType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt053001.DateOrDateTimePeriod1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|ISO20022.Camt053001.DateTimePeriod1||XmlElement()||
|+|Dt|ISO20022.Camt053001.DatePeriod2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtTm),validElement(Dt),validChoice(DtTm,Dt))|

---

## Value ISO20022.Camt053001.DatePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.DateType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.DisplayCapabilities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LineWidth|String||XmlElement()||
|+|NbOfLines|String||XmlElement()||
|+|DispTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LineWidth""",LineWidth,"""[0-9]{1,3}"""),validPattern("""NbOfLines""",NbOfLines,"""[0-9]{1,3}"""))|

---

## Type ISO20022.Camt053001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BkToCstmrStmt|ISO20022.Camt053001.BankToCustomerStatementV13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BkToCstmrStmt))|

---

## Value ISO20022.Camt053001.DocumentAdjustment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Camt053001.DocumentAmount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Camt053001.DocumentAmountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Tp))|

---

## Value ISO20022.Camt053001.DocumentAmountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.DocumentLineIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltdDt|DateTime||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|ISO20022.Camt053001.DocumentLineType1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt053001.DocumentLineInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt053001.RemittanceAmount4||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Id|global::System.Collections.Generic.List<ISO20022.Camt053001.DocumentLineIdentification1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validRequired("""Id""",Id),validList("""Id""",Id),validElement(Id))|

---

## Value ISO20022.Camt053001.DocumentLineType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Camt053001.DocumentLineType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Camt053001.DocumentLineType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.DocumentType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Camt053001.DocumentType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Camt053001.DocumentType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.EntryDetails14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxDtls|global::System.Collections.Generic.List<ISO20022.Camt053001.EntryTransaction15>||XmlElement()||
|+|Btch|ISO20022.Camt053001.BatchInformation2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TxDtls""",TxDtls),validElement(TxDtls),validElement(Btch))|

---

## Value ISO20022.Camt053001.EntryStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.EntryTransaction15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt053001.SupplementaryData1>||XmlElement()||
|+|AddtlTxInf|String||XmlElement()||
|+|InstrCpy|String||XmlElement()||
|+|CardTx|ISO20022.Camt053001.CardTransaction18||XmlElement()||
|+|CshDpst|global::System.Collections.Generic.List<ISO20022.Camt053001.CashDeposit1>||XmlElement()||
|+|UndrlygAllcn|global::System.Collections.Generic.List<ISO20022.Camt053001.TransactionAllocation1>||XmlElement()||
|+|SfkpgAcct|ISO20022.Camt053001.SecuritiesAccount19||XmlElement()||
|+|RltdCorpActn|ISO20022.Camt053001.CorporateAction82||XmlElement()||
|+|RtrInf|ISO20022.Camt053001.PaymentReturnReason8||XmlElement()||
|+|Tax|ISO20022.Camt053001.TaxData1||XmlElement()||
|+|FinInstrmId|ISO20022.Camt053001.SecurityIdentification19||XmlElement()||
|+|RltdQties|global::System.Collections.Generic.List<ISO20022.Camt053001.TransactionQuantities4Choice>||XmlElement()||
|+|RltdPric|ISO20022.Camt053001.TransactionPrice4Choice||XmlElement()||
|+|RltdDts|ISO20022.Camt053001.TransactionDates3||XmlElement()||
|+|RmtInf|ISO20022.Camt053001.RemittanceInformation22||XmlElement()||
|+|RltdRmtInf|global::System.Collections.Generic.List<ISO20022.Camt053001.RemittanceLocation8>||XmlElement()||
|+|Purp|ISO20022.Camt053001.Purpose2Choice||XmlElement()||
|+|PmtTpInf|ISO20022.Camt053001.PaymentTypeInformation27||XmlElement()||
|+|LclInstrm|ISO20022.Camt053001.LocalInstrument2Choice||XmlElement()||
|+|RltdAgts|ISO20022.Camt053001.TransactionAgents6||XmlElement()||
|+|RltdPties|ISO20022.Camt053001.TransactionParties12||XmlElement()||
|+|Intrst|ISO20022.Camt053001.TransactionInterest4||XmlElement()||
|+|Chrgs|ISO20022.Camt053001.Charges15||XmlElement()||
|+|BkTxCd|ISO20022.Camt053001.BankTransactionCodeStructure4||XmlElement()||
|+|Avlbty|global::System.Collections.Generic.List<ISO20022.Camt053001.CashAvailability1>||XmlElement()||
|+|AmtDtls|ISO20022.Camt053001.AmountAndCurrencyExchange4||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Refs|ISO20022.Camt053001.TransactionReferences6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CardTx),validList("""CshDpst""",CshDpst),validElement(CshDpst),validList("""UndrlygAllcn""",UndrlygAllcn),validElement(UndrlygAllcn),validElement(SfkpgAcct),validElement(RltdCorpActn),validElement(RtrInf),validElement(Tax),validElement(FinInstrmId),validList("""RltdQties""",RltdQties),validElement(RltdQties),validElement(RltdPric),validElement(RltdDts),validElement(RmtInf),validList("""RltdRmtInf""",RltdRmtInf),validListMax("""RltdRmtInf""",RltdRmtInf,10),validElement(RltdRmtInf),validElement(Purp),validElement(PmtTpInf),validElement(LclInstrm),validElement(RltdAgts),validElement(RltdPties),validElement(Intrst),validElement(Chrgs),validElement(BkTxCd),validList("""Avlbty""",Avlbty),validElement(Avlbty),validElement(AmtDtls),validElement(Amt),validElement(Refs))|

---

## Value ISO20022.Camt053001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt053001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt053001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt053001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt053001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Camt053001.FromToAmountRange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToAmt|ISO20022.Camt053001.AmountRangeBoundary1||XmlElement()||
|+|FrAmt|ISO20022.Camt053001.AmountRangeBoundary1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ToAmt),validElement(FrAmt))|

---

## Value ISO20022.Camt053001.Garnishment4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MplyeeTermntnInd|String||XmlElement()||
|+|FmlyMdclInsrncInd|String||XmlElement()||
|+|RmtdAmt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|GrnshmtAdmstr|ISO20022.Camt053001.PartyIdentification272||XmlElement()||
|+|Grnshee|ISO20022.Camt053001.PartyIdentification272||XmlElement()||
|+|Tp|ISO20022.Camt053001.GarnishmentType1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RmtdAmt),validElement(GrnshmtAdmstr),validElement(Grnshee),validElement(Tp))|

---

## Value ISO20022.Camt053001.GarnishmentType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Camt053001.GarnishmentType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Camt053001.GarnishmentType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt053001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt053001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt053001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt053001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.GenericIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt053001.GenericIdentification32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShrtNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt053001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt053001.GenericPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt053001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt053001.GroupHeader116


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|OrgnlBizQry|ISO20022.Camt053001.OriginalBusinessQuery1||XmlElement()||
|+|MsgPgntn|ISO20022.Camt053001.Pagination1||XmlElement()||
|+|MsgRcpt|ISO20022.Camt053001.PartyIdentification272||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlBizQry),validElement(MsgPgntn),validElement(MsgRcpt))|

---

## Value ISO20022.Camt053001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.ImpliedCurrencyAmountRange1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NEQAmt|Decimal||XmlElement()||
|+|EQAmt|Decimal||XmlElement()||
|+|FrToAmt|ISO20022.Camt053001.FromToAmountRange1||XmlElement()||
|+|ToAmt|ISO20022.Camt053001.AmountRangeBoundary1||XmlElement()||
|+|FrAmt|ISO20022.Camt053001.AmountRangeBoundary1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToAmt),validElement(ToAmt),validElement(FrAmt),validChoice(NEQAmt,EQAmt,FrToAmt,ToAmt,FrAmt))|

---

## Value ISO20022.Camt053001.InterestRecord2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tax|ISO20022.Camt053001.TaxCharges2||XmlElement()||
|+|Rsn|String||XmlElement()||
|+|FrToDt|ISO20022.Camt053001.DateTimePeriod1||XmlElement()||
|+|Rate|ISO20022.Camt053001.Rate4||XmlElement()||
|+|Tp|ISO20022.Camt053001.InterestType1Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tax),validElement(FrToDt),validElement(Rate),validElement(Tp),validElement(Amt))|

---

## Value ISO20022.Camt053001.InterestType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt053001.InterestType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OVRN|Int32||XmlEnum("""OVRN""")|1|
||INDY|Int32||XmlEnum("""INDY""")|2|

---

## Value ISO20022.Camt053001.LocalInstrument2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.MessageIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgId|String||XmlElement()||
|+|MsgNmId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.NameAndAddress18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Camt053001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Camt053001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Camt053001.NumberAndSumOfTransactions1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sum|Decimal||XmlElement()||
|+|NbOfNtries|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""NbOfNtries""",NbOfNtries,"""[0-9]{1,15}"""))|

---

## Value ISO20022.Camt053001.NumberAndSumOfTransactions4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlNetNtry|ISO20022.Camt053001.AmountAndDirection35||XmlElement()||
|+|Sum|Decimal||XmlElement()||
|+|NbOfNtries|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlNetNtry),validPattern("""NbOfNtries""",NbOfNtries,"""[0-9]{1,15}"""))|

---

## Enum ISO20022.Camt053001.OnLineCapability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SMON|Int32||XmlEnum("""SMON""")|1|
||ONLN|Int32||XmlEnum("""ONLN""")|2|
||OFLN|Int32||XmlEnum("""OFLN""")|3|

---

## Value ISO20022.Camt053001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt053001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt053001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.OriginalBusinessQuery1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgNmId|String||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Camt053001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Camt053001.POIComponentType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PEDV|Int32||XmlEnum("""PEDV""")|1|
||SECM|Int32||XmlEnum("""SECM""")|2|
||CHIT|Int32||XmlEnum("""CHIT""")|3|
||MRIT|Int32||XmlEnum("""MRIT""")|4|
||EMVO|Int32||XmlEnum("""EMVO""")|5|
||EMVK|Int32||XmlEnum("""EMVK""")|6|
||SOFT|Int32||XmlEnum("""SOFT""")|7|

---

## Value ISO20022.Camt053001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Camt053001.Party50Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Agt|ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Pty|ISO20022.Camt053001.PartyIdentification272||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Agt),validElement(Pty),validChoice(Agt,Pty))|

---

## Value ISO20022.Camt053001.Party52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Camt053001.PersonIdentification18||XmlElement()||
|+|OrgId|ISO20022.Camt053001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Camt053001.PartyIdentification272


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Camt053001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Camt053001.Party52Choice||XmlElement()||
|+|PstlAdr|ISO20022.Camt053001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Enum ISO20022.Camt053001.PartyType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLIS|Int32||XmlEnum("""DLIS""")|1|
||CISS|Int32||XmlEnum("""CISS""")|2|
||ACQR|Int32||XmlEnum("""ACQR""")|3|
||ITAG|Int32||XmlEnum("""ITAG""")|4|
||ACCP|Int32||XmlEnum("""ACCP""")|5|
||MERC|Int32||XmlEnum("""MERC""")|6|
||OPOI|Int32||XmlEnum("""OPOI""")|7|

---

## Enum ISO20022.Camt053001.PartyType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAXH|Int32||XmlEnum("""TAXH""")|1|
||CISS|Int32||XmlEnum("""CISS""")|2|
||ACQR|Int32||XmlEnum("""ACQR""")|3|
||ITAG|Int32||XmlEnum("""ITAG""")|4|
||ACCP|Int32||XmlEnum("""ACCP""")|5|
||MERC|Int32||XmlEnum("""MERC""")|6|

---

## Value ISO20022.Camt053001.PaymentCard4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlCardData|String||XmlElement()||
|+|CardBrnd|ISO20022.Camt053001.GenericIdentification1||XmlElement()||
|+|CardCtryCd|String||XmlElement()||
|+|PlainCardData|ISO20022.Camt053001.PlainCardData1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CardBrnd),validPattern("""CardCtryCd""",CardCtryCd,"""[0-9]{3}"""),validElement(PlainCardData))|

---

## Value ISO20022.Camt053001.PaymentContext3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AuthntcnMtd|ISO20022.Camt053001.CardholderAuthentication2||XmlElement()||
|+|FllbckInd|String||XmlElement()||
|+|CardDataNtryMd|String||XmlElement()||
|+|AttndntLang|String||XmlElement()||
|+|AttndntMsgCpbl|String||XmlElement()||
|+|TxChanl|String||XmlElement()||
|+|TxEnvt|String||XmlElement()||
|+|AttndncCntxt|String||XmlElement()||
|+|OnLineCntxt|String||XmlElement()||
|+|CrdhldrPres|String||XmlElement()||
|+|CardPres|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AuthntcnMtd),validPattern("""AttndntLang""",AttndntLang,"""[a-z]{2,2}"""))|

---

## Value ISO20022.Camt053001.PaymentReturnReason8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Rsn|ISO20022.Camt053001.ReturnReason5Choice||XmlElement()||
|+|Orgtr|ISO20022.Camt053001.PartyIdentification272||XmlElement()||
|+|OrgnlBkTxCd|ISO20022.Camt053001.BankTransactionCodeStructure4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn),validElement(Orgtr),validElement(OrgnlBkTxCd))|

---

## Value ISO20022.Camt053001.PaymentTypeInformation27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtgyPurp|ISO20022.Camt053001.CategoryPurpose1Choice||XmlElement()||
|+|SeqTp|String||XmlElement()||
|+|LclInstrm|ISO20022.Camt053001.LocalInstrument2Choice||XmlElement()||
|+|SvcLvl|global::System.Collections.Generic.List<ISO20022.Camt053001.ServiceLevel8Choice>||XmlElement()||
|+|ClrChanl|String||XmlElement()||
|+|InstrPrty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtgyPurp),validElement(LclInstrm),validList("""SvcLvl""",SvcLvl),validElement(SvcLvl))|

---

## Value ISO20022.Camt053001.PersonIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt053001.GenericPersonIdentification2>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Camt053001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Camt053001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.PlainCardData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CardSctyCd|ISO20022.Camt053001.CardSecurityInformation1||XmlElement()||
|+|TrckData|global::System.Collections.Generic.List<ISO20022.Camt053001.TrackData1>||XmlElement()||
|+|SvcCd|String||XmlElement()||
|+|XpryDt|String||XmlElement()||
|+|FctvDt|String||XmlElement()||
|+|CardSeqNb|String||XmlElement()||
|+|PAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CardSctyCd),validList("""TrckData""",TrckData),validElement(TrckData),validPattern("""SvcCd""",SvcCd,"""[0-9]{3}"""),validPattern("""CardSeqNb""",CardSeqNb,"""[0-9]{2,3}"""),validPattern("""PAN""",PAN,"""[0-9]{8,28}"""))|

---

## Value ISO20022.Camt053001.PointOfInteraction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cmpnt|global::System.Collections.Generic.List<ISO20022.Camt053001.PointOfInteractionComponent1>||XmlElement()||
|+|Cpblties|ISO20022.Camt053001.PointOfInteractionCapabilities1||XmlElement()||
|+|GrpId|String||XmlElement()||
|+|SysNm|String||XmlElement()||
|+|Id|ISO20022.Camt053001.GenericIdentification32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Cmpnt""",Cmpnt),validElement(Cmpnt),validElement(Cpblties),validElement(Id))|

---

## Value ISO20022.Camt053001.PointOfInteractionCapabilities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtLineWidth|String||XmlElement()||
|+|DispCpblties|global::System.Collections.Generic.List<ISO20022.Camt053001.DisplayCapabilities1>||XmlElement()||
|+|OnLineCpblties|String||XmlElement()||
|+|CrdhldrVrfctnCpblties|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CardRdngCpblties|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrtLineWidth""",PrtLineWidth,"""[0-9]{1,3}"""),validList("""DispCpblties""",DispCpblties),validElement(DispCpblties))|

---

## Value ISO20022.Camt053001.PointOfInteractionComponent1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ApprvlNb|global::System.Collections.Generic.List<String>||XmlElement()||
|+|SrlNb|String||XmlElement()||
|+|VrsnNb|String||XmlElement()||
|+|Mdl|String||XmlElement()||
|+|ManfctrId|String||XmlElement()||
|+|POICmpntTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.PostalAddress27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|DstrctNm|String||XmlElement()||
|+|TwnLctnNm|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|Room|String||XmlElement()||
|+|PstBx|String||XmlElement()||
|+|UnitNb|String||XmlElement()||
|+|Flr|String||XmlElement()||
|+|BldgNm|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|SubDept|String||XmlElement()||
|+|Dept|String||XmlElement()||
|+|CareOf|String||XmlElement()||
|+|AdrTp|ISO20022.Camt053001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Camt053001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Value ISO20022.Camt053001.Price7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Camt053001.PriceRateOrAmount3Choice||XmlElement()||
|+|Tp|ISO20022.Camt053001.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Camt053001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Enum ISO20022.Camt053001.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Enum ISO20022.Camt053001.Priority2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORM|Int32||XmlEnum("""NORM""")|1|
||HIGH|Int32||XmlEnum("""HIGH""")|2|

---

## Value ISO20022.Camt053001.Product2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlPdctInf|String||XmlElement()||
|+|TaxTp|String||XmlElement()||
|+|PdctAmt|Decimal||XmlElement()||
|+|UnitPric|Decimal||XmlElement()||
|+|PdctQty|Decimal||XmlElement()||
|+|UnitOfMeasr|String||XmlElement()||
|+|PdctCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.ProprietaryAgent5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Agt|ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Agt))|

---

## Value ISO20022.Camt053001.ProprietaryBankTransactionCodeStructure1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.ProprietaryDate3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dt|ISO20022.Camt053001.DateAndDateTime2Choice||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dt))|

---

## Value ISO20022.Camt053001.ProprietaryParty6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty|ISO20022.Camt053001.Party50Choice||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty))|

---

## Value ISO20022.Camt053001.ProprietaryPrice2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pric|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pric))|

---

## Value ISO20022.Camt053001.ProprietaryQuantity1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.ProprietaryReference1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Camt053001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt053001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.Purpose2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.Rate4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VldtyRg|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmountRange2||XmlElement()||
|+|Tp|ISO20022.Camt053001.RateType4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(VldtyRg),validElement(Tp))|

---

## Value ISO20022.Camt053001.RateType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|String||XmlElement()||
|+|Pctg|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Othr,Pctg))|

---

## Value ISO20022.Camt053001.References74Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrTxId|String||XmlElement()||
|+|TradId|String||XmlElement()||
|+|CmonId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|CtrPtyMktInfrstrctrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|IntraBalMvmntId|String||XmlElement()||
|+|IntraPosMvmntId|String||XmlElement()||
|+|SctiesSttlmTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OthrTxId,TradId,CmonId,PoolId,CtrPtyMktInfrstrctrTxId,MktInfrstrctrTxId,AcctSvcrTxId,IntraBalMvmntId,IntraPosMvmntId,SctiesSttlmTxId))|

---

## Value ISO20022.Camt053001.ReferredDocumentInformation8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LineDtls|global::System.Collections.Generic.List<ISO20022.Camt053001.DocumentLineInformation2>||XmlElement()||
|+|RltdDt|ISO20022.Camt053001.DateAndType1||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|ISO20022.Camt053001.DocumentType1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LineDtls""",LineDtls),validElement(LineDtls),validElement(RltdDt),validElement(Tp))|

---

## Value ISO20022.Camt053001.RemittanceAmount4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdjstmntAmtAndRsn|global::System.Collections.Generic.List<ISO20022.Camt053001.DocumentAdjustment1>||XmlElement()||
|+|RmtAmtAndTp|global::System.Collections.Generic.List<ISO20022.Camt053001.DocumentAmount1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AdjstmntAmtAndRsn""",AdjstmntAmtAndRsn),validElement(AdjstmntAmtAndRsn),validList("""RmtAmtAndTp""",RmtAmtAndTp),validElement(RmtAmtAndTp))|

---

## Value ISO20022.Camt053001.RemittanceInformation22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Strd|global::System.Collections.Generic.List<ISO20022.Camt053001.StructuredRemittanceInformation18>||XmlElement()||
|+|Ustrd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Strd""",Strd),validElement(Strd))|

---

## Value ISO20022.Camt053001.RemittanceLocation8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RmtLctnDtls|global::System.Collections.Generic.List<ISO20022.Camt053001.RemittanceLocationData2>||XmlElement()||
|+|RmtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RmtLctnDtls""",RmtLctnDtls),validElement(RmtLctnDtls))|

---

## Value ISO20022.Camt053001.RemittanceLocationData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt053001.NameAndAddress18||XmlElement()||
|+|ElctrncAdr|String||XmlElement()||
|+|Mtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr))|

---

## Enum ISO20022.Camt053001.RemittanceLocationMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SMSM|Int32||XmlEnum("""SMSM""")|1|
||POST|Int32||XmlEnum("""POST""")|2|
||EMAL|Int32||XmlEnum("""EMAL""")|3|
||URID|Int32||XmlEnum("""URID""")|4|
||EDIC|Int32||XmlEnum("""EDIC""")|5|
||FAXI|Int32||XmlEnum("""FAXI""")|6|

---

## Value ISO20022.Camt053001.ReportEntry15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlNtryInf|String||XmlElement()||
|+|NtryDtls|global::System.Collections.Generic.List<ISO20022.Camt053001.EntryDetails14>||XmlElement()||
|+|CardTx|ISO20022.Camt053001.CardEntry5||XmlElement()||
|+|Intrst|ISO20022.Camt053001.TransactionInterest4||XmlElement()||
|+|TechInptChanl|ISO20022.Camt053001.TechnicalInputChannel1Choice||XmlElement()||
|+|Chrgs|ISO20022.Camt053001.Charges15||XmlElement()||
|+|AmtDtls|ISO20022.Camt053001.AmountAndCurrencyExchange4||XmlElement()||
|+|AddtlInfInd|ISO20022.Camt053001.MessageIdentification2||XmlElement()||
|+|ComssnWvrInd|String||XmlElement()||
|+|BkTxCd|ISO20022.Camt053001.BankTransactionCodeStructure4||XmlElement()||
|+|Avlbty|global::System.Collections.Generic.List<ISO20022.Camt053001.CashAvailability1>||XmlElement()||
|+|AcctSvcrRef|String||XmlElement()||
|+|ValDt|ISO20022.Camt053001.DateAndDateTime2Choice||XmlElement()||
|+|BookgDt|ISO20022.Camt053001.DateAndDateTime2Choice||XmlElement()||
|+|Sts|ISO20022.Camt053001.EntryStatus1Choice||XmlElement()||
|+|RvslInd|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|NtryRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""NtryDtls""",NtryDtls),validElement(NtryDtls),validElement(CardTx),validElement(Intrst),validElement(TechInptChanl),validElement(Chrgs),validElement(AmtDtls),validElement(AddtlInfInd),validElement(BkTxCd),validList("""Avlbty""",Avlbty),validElement(Avlbty),validElement(ValDt),validElement(BookgDt),validElement(Sts),validElement(Amt))|

---

## Value ISO20022.Camt053001.ReportingSource1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.ReturnReason5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Camt053001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt053001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Camt053001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Camt053001.SequenceRange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToSeq|String||XmlElement()||
|+|FrSeq|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.SequenceRange1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NEQSeq|global::System.Collections.Generic.List<String>||XmlElement()||
|+|EQSeq|global::System.Collections.Generic.List<String>||XmlElement()||
|+|FrToSeq|global::System.Collections.Generic.List<ISO20022.Camt053001.SequenceRange1>||XmlElement()||
|+|ToSeq|String||XmlElement()||
|+|FrSeq|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""NEQSeq""",NEQSeq),validRequired("""EQSeq""",EQSeq),validRequired("""FrToSeq""",FrToSeq),validList("""FrToSeq""",FrToSeq),validElement(FrToSeq),validChoice(NEQSeq,EQSeq,FrToSeq,ToSeq,FrSeq))|

---

## Enum ISO20022.Camt053001.SequenceType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RPRE|Int32||XmlEnum("""RPRE""")|1|
||OOFF|Int32||XmlEnum("""OOFF""")|2|
||FNAL|Int32||XmlEnum("""FNAL""")|3|
||RCUR|Int32||XmlEnum("""RCUR""")|4|
||FRST|Int32||XmlEnum("""FRST""")|5|

---

## Value ISO20022.Camt053001.ServiceLevel8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.StructuredRemittanceInformation18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRmtInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|GrnshmtRmt|ISO20022.Camt053001.Garnishment4||XmlElement()||
|+|TaxRmt|ISO20022.Camt053001.TaxData1||XmlElement()||
|+|Invcee|ISO20022.Camt053001.PartyIdentification272||XmlElement()||
|+|Invcr|ISO20022.Camt053001.PartyIdentification272||XmlElement()||
|+|CdtrRefInf|ISO20022.Camt053001.CreditorReferenceInformation3||XmlElement()||
|+|RfrdDocAmt|ISO20022.Camt053001.RemittanceAmount4||XmlElement()||
|+|RfrdDocInf|global::System.Collections.Generic.List<ISO20022.Camt053001.ReferredDocumentInformation8>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlRmtInf""",AddtlRmtInf,3),validElement(GrnshmtRmt),validElement(TaxRmt),validElement(Invcee),validElement(Invcr),validElement(CdtrRefInf),validElement(RfrdDocAmt),validList("""RfrdDocInf""",RfrdDocInf),validElement(RfrdDocInf))|

---

## Value ISO20022.Camt053001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt053001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt053001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.TaxAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|global::System.Collections.Generic.List<ISO20022.Camt053001.TaxRecordDetails3>||XmlElement()||
|+|TtlAmt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TaxblBaseAmt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dtls""",Dtls),validElement(Dtls),validElement(TtlAmt),validElement(TaxblBaseAmt))|

---

## Value ISO20022.Camt053001.TaxAuthorisation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Titl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.TaxCharges2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Camt053001.TaxData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rcrd|global::System.Collections.Generic.List<ISO20022.Camt053001.TaxRecord3>||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|TtlTaxAmt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlTaxblBaseAmt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Mtd|String||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|AdmstnZone|String||XmlElement()||
|+|UltmtDbtr|ISO20022.Camt053001.TaxParty2||XmlElement()||
|+|Dbtr|ISO20022.Camt053001.TaxParty2||XmlElement()||
|+|Cdtr|ISO20022.Camt053001.TaxParty1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rcrd""",Rcrd),validElement(Rcrd),validElement(TtlTaxAmt),validElement(TtlTaxblBaseAmt),validElement(UltmtDbtr),validElement(Dbtr),validElement(Cdtr))|

---

## Value ISO20022.Camt053001.TaxParty1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxTp|String||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|TaxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.TaxParty2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Authstn|ISO20022.Camt053001.TaxAuthorisation1||XmlElement()||
|+|TaxTp|String||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|TaxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Authstn))|

---

## Value ISO20022.Camt053001.TaxPeriod3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrToDt|ISO20022.Camt053001.DatePeriod2||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Yr|Int32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToDt))|

---

## Value ISO20022.Camt053001.TaxRecord3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|TaxAmt|ISO20022.Camt053001.TaxAmount3||XmlElement()||
|+|Prd|ISO20022.Camt053001.TaxPeriod3||XmlElement()||
|+|FrmsCd|String||XmlElement()||
|+|CertId|String||XmlElement()||
|+|DbtrSts|String||XmlElement()||
|+|CtgyDtls|String||XmlElement()||
|+|Ctgy|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxAmt),validElement(Prd))|

---

## Value ISO20022.Camt053001.TaxRecordDetails3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Prd|ISO20022.Camt053001.TaxPeriod3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Prd))|

---

## Enum ISO20022.Camt053001.TaxRecordPeriod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HLF2|Int32||XmlEnum("""HLF2""")|1|
||HLF1|Int32||XmlEnum("""HLF1""")|2|
||QTR4|Int32||XmlEnum("""QTR4""")|3|
||QTR3|Int32||XmlEnum("""QTR3""")|4|
||QTR2|Int32||XmlEnum("""QTR2""")|5|
||QTR1|Int32||XmlEnum("""QTR1""")|6|
||MM12|Int32||XmlEnum("""MM12""")|7|
||MM11|Int32||XmlEnum("""MM11""")|8|
||MM10|Int32||XmlEnum("""MM10""")|9|
||MM09|Int32||XmlEnum("""MM09""")|10|
||MM08|Int32||XmlEnum("""MM08""")|11|
||MM07|Int32||XmlEnum("""MM07""")|12|
||MM06|Int32||XmlEnum("""MM06""")|13|
||MM05|Int32||XmlEnum("""MM05""")|14|
||MM04|Int32||XmlEnum("""MM04""")|15|
||MM03|Int32||XmlEnum("""MM03""")|16|
||MM02|Int32||XmlEnum("""MM02""")|17|
||MM01|Int32||XmlEnum("""MM01""")|18|

---

## Value ISO20022.Camt053001.TechnicalInputChannel1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt053001.TotalTransactions6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlNtriesPerBkTxCd|global::System.Collections.Generic.List<ISO20022.Camt053001.TotalsPerBankTransactionCode5>||XmlElement()||
|+|TtlDbtNtries|ISO20022.Camt053001.NumberAndSumOfTransactions1||XmlElement()||
|+|TtlCdtNtries|ISO20022.Camt053001.NumberAndSumOfTransactions1||XmlElement()||
|+|TtlNtries|ISO20022.Camt053001.NumberAndSumOfTransactions4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TtlNtriesPerBkTxCd""",TtlNtriesPerBkTxCd),validElement(TtlNtriesPerBkTxCd),validElement(TtlDbtNtries),validElement(TtlCdtNtries),validElement(TtlNtries))|

---

## Value ISO20022.Camt053001.TotalsPerBankTransactionCode5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dt|ISO20022.Camt053001.DateAndDateTime2Choice||XmlElement()||
|+|Avlbty|global::System.Collections.Generic.List<ISO20022.Camt053001.CashAvailability1>||XmlElement()||
|+|BkTxCd|ISO20022.Camt053001.BankTransactionCodeStructure4||XmlElement()||
|+|FcstInd|String||XmlElement()||
|+|DbtNtries|ISO20022.Camt053001.NumberAndSumOfTransactions1||XmlElement()||
|+|CdtNtries|ISO20022.Camt053001.NumberAndSumOfTransactions1||XmlElement()||
|+|TtlNetNtry|ISO20022.Camt053001.AmountAndDirection35||XmlElement()||
|+|Sum|Decimal||XmlElement()||
|+|NbOfNtries|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dt),validList("""Avlbty""",Avlbty),validElement(Avlbty),validElement(BkTxCd),validElement(DbtNtries),validElement(CdtNtries),validElement(TtlNetNtry),validPattern("""NbOfNtries""",NbOfNtries,"""[0-9]{1,15}"""))|

---

## Value ISO20022.Camt053001.TrackData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrckVal|String||XmlElement()||
|+|TrckNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TrckNb""",TrckNb,"""[0-9]"""))|

---

## Value ISO20022.Camt053001.TransactionAgents6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|global::System.Collections.Generic.List<ISO20022.Camt053001.ProprietaryAgent5>||XmlElement()||
|+|SttlmPlc|ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IssgAgt|ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|DlvrgAgt|ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|RcvgAgt|ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrmyAgt3|ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrmyAgt2|ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrmyAgt1|ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|CdtrAgt|ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|DbtrAgt|ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InstdAgt|ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InstgAgt|ISO20022.Camt053001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Prtry""",Prtry),validElement(Prtry),validElement(SttlmPlc),validElement(IssgAgt),validElement(DlvrgAgt),validElement(RcvgAgt),validElement(IntrmyAgt3),validElement(IntrmyAgt2),validElement(IntrmyAgt1),validElement(CdtrAgt),validElement(DbtrAgt),validElement(InstdAgt),validElement(InstgAgt))|

---

## Value ISO20022.Camt053001.TransactionAllocation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltdRefs|global::System.Collections.Generic.List<ISO20022.Camt053001.References74Choice>||XmlElement()||
|+|Ref|String||XmlElement()||
|+|Purp|ISO20022.Camt053001.Purpose2Choice||XmlElement()||
|+|Acct|ISO20022.Camt053001.CashAccount40||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RltdRefs""",RltdRefs),validElement(RltdRefs),validElement(Purp),validElement(Acct),validElement(Amt))|

---

## Enum ISO20022.Camt053001.TransactionChannel1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TVPY|Int32||XmlEnum("""TVPY""")|1|
||ECOM|Int32||XmlEnum("""ECOM""")|2|
||TLPH|Int32||XmlEnum("""TLPH""")|3|
||MAIL|Int32||XmlEnum("""MAIL""")|4|

---

## Value ISO20022.Camt053001.TransactionDates3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|global::System.Collections.Generic.List<ISO20022.Camt053001.ProprietaryDate3>||XmlElement()||
|+|TxDtTm|DateTime||XmlElement()||
|+|EndDt|DateTime||XmlElement()||
|+|StartDt|DateTime||XmlElement()||
|+|IntrBkSttlmDt|DateTime||XmlElement()||
|+|TradDt|DateTime||XmlElement()||
|+|TradActvtyCtrctlSttlmDt|DateTime||XmlElement()||
|+|AccptncDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Prtry""",Prtry),validElement(Prtry))|

---

## Enum ISO20022.Camt053001.TransactionEnvironment1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUBL|Int32||XmlEnum("""PUBL""")|1|
||PRIV|Int32||XmlEnum("""PRIV""")|2|
||MERC|Int32||XmlEnum("""MERC""")|3|

---

## Value ISO20022.Camt053001.TransactionIdentifier1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxRef|String||XmlElement()||
|+|TxDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt053001.TransactionInterest4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rcrd|global::System.Collections.Generic.List<ISO20022.Camt053001.InterestRecord2>||XmlElement()||
|+|TtlIntrstAndTaxAmt|ISO20022.Camt053001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rcrd""",Rcrd),validElement(Rcrd),validElement(TtlIntrstAndTaxAmt))|

---

## Value ISO20022.Camt053001.TransactionParties12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|global::System.Collections.Generic.List<ISO20022.Camt053001.ProprietaryParty6>||XmlElement()||
|+|TradgPty|ISO20022.Camt053001.Party50Choice||XmlElement()||
|+|UltmtCdtr|ISO20022.Camt053001.Party50Choice||XmlElement()||
|+|CdtrAcct|ISO20022.Camt053001.CashAccount40||XmlElement()||
|+|Cdtr|ISO20022.Camt053001.Party50Choice||XmlElement()||
|+|UltmtDbtr|ISO20022.Camt053001.Party50Choice||XmlElement()||
|+|DbtrAcct|ISO20022.Camt053001.CashAccount40||XmlElement()||
|+|Dbtr|ISO20022.Camt053001.Party50Choice||XmlElement()||
|+|InitgPty|ISO20022.Camt053001.Party50Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Prtry""",Prtry),validElement(Prtry),validElement(TradgPty),validElement(UltmtCdtr),validElement(CdtrAcct),validElement(Cdtr),validElement(UltmtDbtr),validElement(DbtrAcct),validElement(Dbtr),validElement(InitgPty))|

---

## Value ISO20022.Camt053001.TransactionPrice4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|global::System.Collections.Generic.List<ISO20022.Camt053001.ProprietaryPrice2>||XmlElement()||
|+|DealPric|ISO20022.Camt053001.Price7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Prtry""",Prtry),validList("""Prtry""",Prtry),validElement(Prtry),validElement(DealPric),validChoice(Prtry,DealPric))|

---

## Value ISO20022.Camt053001.TransactionQuantities4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt053001.ProprietaryQuantity1||XmlElement()||
|+|OrgnlAndCurFaceAmt|ISO20022.Camt053001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Camt053001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(OrgnlAndCurFaceAmt),validElement(Qty),validChoice(Prtry,OrgnlAndCurFaceAmt,Qty))|

---

## Value ISO20022.Camt053001.TransactionReferences6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|global::System.Collections.Generic.List<ISO20022.Camt053001.ProprietaryReference1>||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
|+|ClrSysRef|String||XmlElement()||
|+|ChqNb|String||XmlElement()||
|+|MndtId|String||XmlElement()||
|+|TxId|String||XmlElement()||
|+|UETR|String||XmlElement()||
|+|EndToEndId|String||XmlElement()||
|+|InstrId|String||XmlElement()||
|+|PmtInfId|String||XmlElement()||
|+|AcctSvcrRef|String||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Prtry""",Prtry),validElement(Prtry),validPattern("""UETR""",UETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""))|

---

## Enum ISO20022.Camt053001.UnitOfMeasure1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACRE|Int32||XmlEnum("""ACRE""")|1|
||SQIN|Int32||XmlEnum("""SQIN""")|2|
||SQFO|Int32||XmlEnum("""SQFO""")|3|
||SQYA|Int32||XmlEnum("""SQYA""")|4|
||SQMI|Int32||XmlEnum("""SQMI""")|5|
||SMIL|Int32||XmlEnum("""SMIL""")|6|
||SCMT|Int32||XmlEnum("""SCMT""")|7|
||SMET|Int32||XmlEnum("""SMET""")|8|
||ARES|Int32||XmlEnum("""ARES""")|9|
||HECT|Int32||XmlEnum("""HECT""")|10|
||SQKI|Int32||XmlEnum("""SQKI""")|11|
||YARD|Int32||XmlEnum("""YARD""")|12|
||KMET|Int32||XmlEnum("""KMET""")|13|
||MILE|Int32||XmlEnum("""MILE""")|14|
||USPI|Int32||XmlEnum("""USPI""")|15|
||GBPI|Int32||XmlEnum("""GBPI""")|16|
||USQA|Int32||XmlEnum("""USQA""")|17|
||GBQA|Int32||XmlEnum("""GBQA""")|18|
||USOU|Int32||XmlEnum("""USOU""")|19|
||GBOU|Int32||XmlEnum("""GBOU""")|20|
||MILI|Int32||XmlEnum("""MILI""")|21|
||CELI|Int32||XmlEnum("""CELI""")|22|
||LITR|Int32||XmlEnum("""LITR""")|23|
||MMET|Int32||XmlEnum("""MMET""")|24|
||CMET|Int32||XmlEnum("""CMET""")|25|
||METR|Int32||XmlEnum("""METR""")|26|
||PUND|Int32||XmlEnum("""PUND""")|27|
||KILO|Int32||XmlEnum("""KILO""")|28|
||INCH|Int32||XmlEnum("""INCH""")|29|
||GRAM|Int32||XmlEnum("""GRAM""")|30|
||USGA|Int32||XmlEnum("""USGA""")|31|
||GBGA|Int32||XmlEnum("""GBGA""")|32|
||FOOT|Int32||XmlEnum("""FOOT""")|33|
||TONS|Int32||XmlEnum("""TONS""")|34|
||PIEC|Int32||XmlEnum("""PIEC""")|35|

---

## Enum ISO20022.Camt053001.UserInterface2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDSP|Int32||XmlEnum("""CDSP""")|1|
||MDSP|Int32||XmlEnum("""MDSP""")|2|

---

## Value ISO20022.Camt053001.YieldedOrValueType1Choice


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

