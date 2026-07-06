# acmt.001.001.08
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Acmt001001.Account23 {
        + RltdAcctDtls  : ISO20022.Acmt001001.GenericIdentification1
        + AcctId  : String
    }
    ISO20022.Acmt001001.Account23 *-- ISO20022.Acmt001001.GenericIdentification1
    class ISO20022.Acmt001001.Account32 {
        + AcctSvcr  : ISO20022.Acmt001001.PartyIdentification125Choice
        + Id  : String
    }
    ISO20022.Acmt001001.Account32 *-- ISO20022.Acmt001001.PartyIdentification125Choice
    class ISO20022.Acmt001001.AccountDesignation1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.AccountDesignation1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.AccountIdentification4Choice {
        + Othr  : ISO20022.Acmt001001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Acmt001001.AccountIdentification4Choice *-- ISO20022.Acmt001001.GenericAccountIdentification1
    class ISO20022.Acmt001001.AccountIdentificationAndName5 {
        + Nm  : String
        + Id  : ISO20022.Acmt001001.AccountIdentification4Choice
    }
    ISO20022.Acmt001001.AccountIdentificationAndName5 *-- ISO20022.Acmt001001.AccountIdentification4Choice
    class ISO20022.Acmt001001.AccountOpeningInstructionV08 {
        + Xtnsn  : global::System.Collections.Generic.List~ISO20022.Acmt001001.Extension1~
        + MktPrctcVrsn  : ISO20022.Acmt001001.MarketPracticeVersion1
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Acmt001001.AdditiononalInformation13~
        + SvcLvlAgrmt  : global::System.Collections.Generic.List~ISO20022.Acmt001001.DocumentToSend4~
        + CshSttlm  : global::System.Collections.Generic.List~ISO20022.Acmt001001.CashSettlement3~
        + WdrwlInvstmtPlan  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestmentPlan17~
        + SvgsInvstmtPlan  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestmentPlan17~
        + NewIsseAllcn  : ISO20022.Acmt001001.NewIssueAllocation2
        + Plcmnt  : ISO20022.Acmt001001.ReferredAgent3
        + Intrmies  : global::System.Collections.Generic.List~ISO20022.Acmt001001.Intermediary46~
        + AcctPties  : ISO20022.Acmt001001.AccountParties17
        + InvstmtAcct  : ISO20022.Acmt001001.InvestmentAccount73
        + InstrDtls  : ISO20022.Acmt001001.InvestmentAccountOpening4
        + PrvsRef  : ISO20022.Acmt001001.AdditionalReference13
        + OrdrRef  : ISO20022.Acmt001001.InvestmentFundOrder4
        + MsgId  : ISO20022.Acmt001001.MessageIdentification1
    }
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.Extension1
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.MarketPracticeVersion1
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.AdditiononalInformation13
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.DocumentToSend4
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.CashSettlement3
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.InvestmentPlan17
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.InvestmentPlan17
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.NewIssueAllocation2
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.ReferredAgent3
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.Intermediary46
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.AccountParties17
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.InvestmentAccount73
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.InvestmentAccountOpening4
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.AdditionalReference13
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.InvestmentFundOrder4
    ISO20022.Acmt001001.AccountOpeningInstructionV08 *-- ISO20022.Acmt001001.MessageIdentification1
    class ISO20022.Acmt001001.AccountOpeningType1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.AccountOpeningType1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.AccountOpeningType1Code {
        SUPA = 1
        NEWA = 2
    }
    class ISO20022.Acmt001001.AccountOwnershipType4Code {
        SIGL = 1
        RGIC = 2
        ONIS = 3
        NFPO = 4
        NOMI = 5
        LLCO = 6
        JOIN = 7
        COMO = 8
        JOIT = 9
        GOVO = 10
        TRUS = 11
        PART = 12
        EURE = 13
        CUST = 14
        CORP = 15
        ENTR = 16
        LIPA = 17
        UNCO = 18
    }
    class ISO20022.Acmt001001.AccountParties12Choice {
        + JntOwnr  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16~
        + Nmnee  : ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
        + Trstee  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16~
        + PmryOwnr  : ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    }
    ISO20022.Acmt001001.AccountParties12Choice *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    ISO20022.Acmt001001.AccountParties12Choice *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    ISO20022.Acmt001001.AccountParties12Choice *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    ISO20022.Acmt001001.AccountParties12Choice *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    class ISO20022.Acmt001001.AccountParties17 {
        + RegdShrhldrNm  : ISO20022.Acmt001001.RegisteredShareholderName1Choice
        + Prtctr  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16~
        + SnrMggOffcl  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16~
        + Sttlr  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16~
        + Grntr  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16~
        + OthrPty  : global::System.Collections.Generic.List~ISO20022.Acmt001001.ExtendedParty14~
        + Admstr  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16~
        + SucssrOnDth  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16~
        + CtdnForMnr  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16~
        + LglGuardn  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16~
        + PwrOfAttny  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16~
        + Bnfcry  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16~
        + ScndryOwnr  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16~
        + PrncplAcctPty  : ISO20022.Acmt001001.AccountParties12Choice
    }
    ISO20022.Acmt001001.AccountParties17 *-- ISO20022.Acmt001001.RegisteredShareholderName1Choice
    ISO20022.Acmt001001.AccountParties17 *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    ISO20022.Acmt001001.AccountParties17 *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    ISO20022.Acmt001001.AccountParties17 *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    ISO20022.Acmt001001.AccountParties17 *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    ISO20022.Acmt001001.AccountParties17 *-- ISO20022.Acmt001001.ExtendedParty14
    ISO20022.Acmt001001.AccountParties17 *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    ISO20022.Acmt001001.AccountParties17 *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    ISO20022.Acmt001001.AccountParties17 *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    ISO20022.Acmt001001.AccountParties17 *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    ISO20022.Acmt001001.AccountParties17 *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    ISO20022.Acmt001001.AccountParties17 *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    ISO20022.Acmt001001.AccountParties17 *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    ISO20022.Acmt001001.AccountParties17 *-- ISO20022.Acmt001001.AccountParties12Choice
    class ISO20022.Acmt001001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt001001.AccountType2Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.AccountType2Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.AccountUsageType2Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.AccountUsageType2Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.AccountUsageType2Code {
        TRDP = 1
        SETP = 2
        ISSP = 3
        INVE = 4
    }
    class ISO20022.Acmt001001.AccountingStatus1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.AccountingStatus1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.AccountingStatus1Code {
        NDOM = 1
        YDOM = 2
    }
    class ISO20022.Acmt001001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Acmt001001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Acmt001001.AdditionalReference13 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Acmt001001.PartyIdentification125Choice
        + Ref  : String
    }
    ISO20022.Acmt001001.AdditionalReference13 *-- ISO20022.Acmt001001.PartyIdentification125Choice
    class ISO20022.Acmt001001.AdditiononalInformation13 {
        + Prd  : ISO20022.Acmt001001.DateTimePeriod2
        + Sts  : ISO20022.Acmt001001.RestrictionStatus1Choice
        + Rgltr  : ISO20022.Acmt001001.PartyIdentification125Choice
        + Tp  : String
        + AcctVldtn  : String
        + AddtlInf  : String
        + Lmttn  : String
    }
    ISO20022.Acmt001001.AdditiononalInformation13 *-- ISO20022.Acmt001001.DateTimePeriod2
    ISO20022.Acmt001001.AdditiononalInformation13 *-- ISO20022.Acmt001001.RestrictionStatus1Choice
    ISO20022.Acmt001001.AdditiononalInformation13 *-- ISO20022.Acmt001001.PartyIdentification125Choice
    class ISO20022.Acmt001001.AddressType1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.AddressType1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.AddressType1Code {
        BIZZ = 1
        HOME = 2
    }
    class ISO20022.Acmt001001.AddressType2Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.AddressType2Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Acmt001001.AlternateSecurityIdentification7 {
        + IdSrc  : ISO20022.Acmt001001.IdentificationSource1Choice
        + Id  : String
    }
    ISO20022.Acmt001001.AlternateSecurityIdentification7 *-- ISO20022.Acmt001001.IdentificationSource1Choice
    class ISO20022.Acmt001001.BlockedHoldingDetails2 {
        + HldgCertNb  : String
        + PrtlHldgUnits  : Decimal
        + BlckdHldg  : String
    }
    class ISO20022.Acmt001001.BlockedReason2Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.BlockedReason2Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.BlockedReason2Code {
        TRAN = 1
        SANC = 2
        TRPE = 3
        PLDG = 4
        PCOM = 5
        MORT = 6
        CNFS = 7
        CMMT = 8
        BKRP = 9
    }
    class ISO20022.Acmt001001.BlockedStatusReason2 {
        + AddtlInf  : String
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Acmt001001.BlockedReason2Choice~
        + Blckd  : String
        + TxTp  : ISO20022.Acmt001001.TransactionType5Choice
    }
    ISO20022.Acmt001001.BlockedStatusReason2 *-- ISO20022.Acmt001001.BlockedReason2Choice
    ISO20022.Acmt001001.BlockedStatusReason2 *-- ISO20022.Acmt001001.TransactionType5Choice
    class ISO20022.Acmt001001.BlockedStatusReason2Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Acmt001001.BlockedStatusReason2~
        + NoSpcfdRsn  : String
    }
    ISO20022.Acmt001001.BlockedStatusReason2Choice *-- ISO20022.Acmt001001.BlockedStatusReason2
    class ISO20022.Acmt001001.BranchData4 {
        + PstlAdr  : ISO20022.Acmt001001.PostalAddress1
        + Nm  : String
        + Id  : String
    }
    ISO20022.Acmt001001.BranchData4 *-- ISO20022.Acmt001001.PostalAddress1
    class ISO20022.Acmt001001.CRSForm1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.CRSForm1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.CRSFormType1Code {
        CER7 = 1
        CER2 = 2
        CER1 = 3
        CER8 = 4
        CER6 = 5
        CER5 = 6
        CER3 = 7
        CER4 = 8
    }
    class ISO20022.Acmt001001.CRSSource1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.CRSSource1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.CRSSourceStatus1Code {
        DECL = 1
        CALC = 2
    }
    class ISO20022.Acmt001001.CRSStatus1Code {
        C114 = 1
        C113 = 2
        C112 = 3
        C111 = 4
        C110 = 5
        C109 = 6
        C108 = 7
        C107 = 8
        C106 = 9
        C105 = 10
        C104 = 11
        C103 = 12
        C102 = 13
        C101 = 14
    }
    class ISO20022.Acmt001001.CRSStatus3Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.CRSStatus3Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.CRSStatus4 {
        + XcptnlRptgCtry  : String
        + Src  : ISO20022.Acmt001001.CRSSource1Choice
        + Tp  : ISO20022.Acmt001001.CRSStatus3Choice
    }
    ISO20022.Acmt001001.CRSStatus4 *-- ISO20022.Acmt001001.CRSSource1Choice
    ISO20022.Acmt001001.CRSStatus4 *-- ISO20022.Acmt001001.CRSStatus3Choice
    class ISO20022.Acmt001001.CardType1Code {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Acmt001001.CashAccount204 {
        + DvddPctg  : Decimal
        + CshAcctDsgnt  : ISO20022.Acmt001001.AccountDesignation1Choice
        + CshAcctPurp  : ISO20022.Acmt001001.CashAccountType3Choice
        + SttlmInstrRsn  : ISO20022.Acmt001001.SettlementInstructionReason1Choice
        + CdtDbt  : String
        + InvstmtAcctTp  : ISO20022.Acmt001001.AccountType2Choice
        + AcctOwnrOthrId  : global::System.Collections.Generic.List~ISO20022.Acmt001001.GenericIdentification82~
        + AcctSvcrBrnch  : ISO20022.Acmt001001.BranchData4
        + AcctSvcr  : ISO20022.Acmt001001.FinancialInstitutionIdentification11Choice
        + AcctOwnr  : ISO20022.Acmt001001.PartyIdentification125Choice
        + Id  : ISO20022.Acmt001001.AccountIdentificationAndName5
        + SttlmCcy  : String
    }
    ISO20022.Acmt001001.CashAccount204 *-- ISO20022.Acmt001001.AccountDesignation1Choice
    ISO20022.Acmt001001.CashAccount204 *-- ISO20022.Acmt001001.CashAccountType3Choice
    ISO20022.Acmt001001.CashAccount204 *-- ISO20022.Acmt001001.SettlementInstructionReason1Choice
    ISO20022.Acmt001001.CashAccount204 *-- ISO20022.Acmt001001.AccountType2Choice
    ISO20022.Acmt001001.CashAccount204 *-- ISO20022.Acmt001001.GenericIdentification82
    ISO20022.Acmt001001.CashAccount204 *-- ISO20022.Acmt001001.BranchData4
    ISO20022.Acmt001001.CashAccount204 *-- ISO20022.Acmt001001.FinancialInstitutionIdentification11Choice
    ISO20022.Acmt001001.CashAccount204 *-- ISO20022.Acmt001001.PartyIdentification125Choice
    ISO20022.Acmt001001.CashAccount204 *-- ISO20022.Acmt001001.AccountIdentificationAndName5
    class ISO20022.Acmt001001.CashAccountType3Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.CashAccountType3Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.CashAccountType5Code {
        SEGT = 1
        MARR = 2
        SETT = 3
        COLL = 4
        LEND = 5
    }
    class ISO20022.Acmt001001.CashSettlement3 {
        + OthrCshSttlmDtls  : global::System.Collections.Generic.List~ISO20022.Acmt001001.PaymentInstrument17~
        + CshAcctDtls  : global::System.Collections.Generic.List~ISO20022.Acmt001001.CashAccount204~
    }
    ISO20022.Acmt001001.CashSettlement3 *-- ISO20022.Acmt001001.PaymentInstrument17
    ISO20022.Acmt001001.CashSettlement3 *-- ISO20022.Acmt001001.CashAccount204
    class ISO20022.Acmt001001.CertificateType2Code {
        PKIC = 1
        PRAD = 2
        PASS = 3
        LREF = 4
        INCU = 5
        IDEN = 6
        GOST = 7
        DFOR = 8
        DVLC = 9
        AMLC = 10
    }
    class ISO20022.Acmt001001.CertificationType1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.CertificationType1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.Cheque4 {
        + PyeeId  : ISO20022.Acmt001001.NameAndAddress5
    }
    ISO20022.Acmt001001.Cheque4 *-- ISO20022.Acmt001001.NameAndAddress5
    class ISO20022.Acmt001001.CitizenshipInformation2 {
        + MnrInd  : String
        + Ntlty  : String
    }
    class ISO20022.Acmt001001.CivilStatus1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.CivilStatus1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.CivilStatus1Code {
        WIDO = 1
        UNIO = 2
        SING = 3
        SEPA = 4
        MARR = 5
        LDIV = 6
        DIVO = 7
    }
    class ISO20022.Acmt001001.ClearingSystemMemberIdentification4Choice {
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
    class ISO20022.Acmt001001.Collateral1Code {
        NCOL = 1
        COLL = 2
    }
    class ISO20022.Acmt001001.CommunicationAddress6 {
        + URLAdr  : String
        + TlxAdr  : String
        + FaxNb  : String
        + Mob  : String
        + Phne  : String
        + Email  : String
        + AdrTp  : ISO20022.Acmt001001.AddressType1Choice
    }
    ISO20022.Acmt001001.CommunicationAddress6 *-- ISO20022.Acmt001001.AddressType1Choice
    class ISO20022.Acmt001001.CommunicationMethod1Code {
        PROP = 1
        EMAL = 2
        FAXI = 3
        SWMX = 4
        SWMT = 5
    }
    class ISO20022.Acmt001001.CommunicationMethod3Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.CommunicationMethod3Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.CompanyLink1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.CompanyLink1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.CompanyLink1Code {
        RELA = 1
        PCOM = 2
        MEMB = 3
        PART = 4
        BROK = 5
        AGEN = 6
    }
    class ISO20022.Acmt001001.ConductClassification1Code {
        STAN = 1
        RCLT = 2
        NSTA = 3
    }
    class ISO20022.Acmt001001.ConsolidationType1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.ConsolidationType1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.ConsolidationType1Code {
        PART = 1
        GENL = 2
    }
    class ISO20022.Acmt001001.CountryAndResidentialStatusType2 {
        + ResdtlSts  : String
        + Ctry  : String
    }
    class ISO20022.Acmt001001.CreditDebit3Code {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Acmt001001.CustomerConductClassification1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.CustomerConductClassification1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.DataBaseCheck1 {
        + Id  : String
        + DBChck  : String
    }
    class ISO20022.Acmt001001.DateAndAmount1 {
        + Amt  : ISO20022.Acmt001001.ActiveCurrencyAndAmount
        + Dt  : DateTime
    }
    ISO20022.Acmt001001.DateAndAmount1 *-- ISO20022.Acmt001001.ActiveCurrencyAndAmount
    class ISO20022.Acmt001001.DateAndDateTime1Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Acmt001001.DateTimePeriod2 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Acmt001001.DeMinimus1Choice {
        + DeMnmsNotAplbl  : ISO20022.Acmt001001.DeMinimusNotApplicable1
        + DeMnmsAplbl  : ISO20022.Acmt001001.DeMinimusApplicable1
    }
    ISO20022.Acmt001001.DeMinimus1Choice *-- ISO20022.Acmt001001.DeMinimusNotApplicable1
    ISO20022.Acmt001001.DeMinimus1Choice *-- ISO20022.Acmt001001.DeMinimusApplicable1
    class ISO20022.Acmt001001.DeMinimusApplicable1 {
        + Pctg  : Decimal
        + NewIssePrmssn  : String
    }
    class ISO20022.Acmt001001.DeMinimusNotApplicable1 {
        + RstrctdPrsnRsn  : String
    }
    class ISO20022.Acmt001001.DirectDebitMandate7 {
        + MndtId  : String
        + RegnId  : String
        + CdtrAgtBrnch  : ISO20022.Acmt001001.BranchData4
        + CdtrAgt  : ISO20022.Acmt001001.FinancialInstitutionIdentification11Choice
        + DbtrAgtBrnch  : ISO20022.Acmt001001.BranchData4
        + DbtrAgt  : ISO20022.Acmt001001.FinancialInstitutionIdentification11Choice
        + Cdtr  : ISO20022.Acmt001001.PartyIdentification125Choice
        + DbtrNtlRegnNb  : String
        + DbtrTaxIdNb  : String
        + Dbtr  : ISO20022.Acmt001001.PartyIdentification125Choice
        + DbtrAcct  : ISO20022.Acmt001001.AccountIdentificationAndName5
    }
    ISO20022.Acmt001001.DirectDebitMandate7 *-- ISO20022.Acmt001001.BranchData4
    ISO20022.Acmt001001.DirectDebitMandate7 *-- ISO20022.Acmt001001.FinancialInstitutionIdentification11Choice
    ISO20022.Acmt001001.DirectDebitMandate7 *-- ISO20022.Acmt001001.BranchData4
    ISO20022.Acmt001001.DirectDebitMandate7 *-- ISO20022.Acmt001001.FinancialInstitutionIdentification11Choice
    ISO20022.Acmt001001.DirectDebitMandate7 *-- ISO20022.Acmt001001.PartyIdentification125Choice
    ISO20022.Acmt001001.DirectDebitMandate7 *-- ISO20022.Acmt001001.PartyIdentification125Choice
    ISO20022.Acmt001001.DirectDebitMandate7 *-- ISO20022.Acmt001001.AccountIdentificationAndName5
    class ISO20022.Acmt001001.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class ISO20022.Acmt001001.DocumentToSend4 {
        + MtdOfTrnsmssn  : ISO20022.Acmt001001.CommunicationMethod3Choice
        + Rcpt  : ISO20022.Acmt001001.PartyIdentification125Choice
        + Tp  : String
    }
    ISO20022.Acmt001001.DocumentToSend4 *-- ISO20022.Acmt001001.CommunicationMethod3Choice
    ISO20022.Acmt001001.DocumentToSend4 *-- ISO20022.Acmt001001.PartyIdentification125Choice
    class ISO20022.Acmt001001.Eligible1Code {
        NELI = 1
        ELIG = 2
    }
    class ISO20022.Acmt001001.EventFrequency10Code {
        ADHO = 1
        DAIL = 2
    }
    class ISO20022.Acmt001001.EventFrequency1Code {
        ONDE = 1
        OVNG = 2
        INDA = 3
        ADHO = 4
        DAIL = 5
        WEEK = 6
        TOWK = 7
        TWMN = 8
        MNTH = 9
        TOMN = 10
        QUTR = 11
        SEMI = 12
        YEAR = 13
    }
    class ISO20022.Acmt001001.EventFrequency8Code {
        WEEK = 1
        TWMN = 2
        SEMI = 3
        QUTR = 4
        OVNG = 5
        ONDE = 6
        MNTH = 7
        INDA = 8
        TYEA = 9
        TOWK = 10
        TOMN = 11
        FOMN = 12
        DAIL = 13
        YEAR = 14
        ADHO = 15
    }
    class ISO20022.Acmt001001.EventFrequency9Code {
        NONE = 1
        ONDE = 2
        OVNG = 3
        INDA = 4
        ADHO = 5
        DAIL = 6
        WEEK = 7
        TOWK = 8
        TWMN = 9
        MNTH = 10
        TOMN = 11
        QUTR = 12
        SEMI = 13
        YEAR = 14
    }
    class ISO20022.Acmt001001.ExtendedParty14 {
        + OthrPtyDtls  : ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
        + XtndedPtyRole  : String
    }
    ISO20022.Acmt001001.ExtendedParty14 *-- ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16
    class ISO20022.Acmt001001.Extension1 {
        + Txt  : String
        + PlcAndNm  : String
    }
    class ISO20022.Acmt001001.FATCAForm1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.FATCAForm1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.FATCAFormType1Code {
        CER6 = 1
        CER4 = 2
        CER3 = 3
        CER2 = 4
        CER1 = 5
        CER7 = 6
        CER5 = 7
    }
    class ISO20022.Acmt001001.FATCASource1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.FATCASource1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.FATCASourceStatus1Code {
        DECL = 1
        CALC = 2
    }
    class ISO20022.Acmt001001.FATCAStatus1Code {
        F206 = 1
        F205 = 2
        F204 = 3
        F203 = 4
        F202 = 5
        F201 = 6
        F105 = 7
        F104 = 8
        F103 = 9
        F102 = 10
        F101 = 11
    }
    class ISO20022.Acmt001001.FATCAStatus2 {
        + Src  : ISO20022.Acmt001001.FATCASource1Choice
        + Tp  : ISO20022.Acmt001001.FATCAStatus2Choice
    }
    ISO20022.Acmt001001.FATCAStatus2 *-- ISO20022.Acmt001001.FATCASource1Choice
    ISO20022.Acmt001001.FATCAStatus2 *-- ISO20022.Acmt001001.FATCAStatus2Choice
    class ISO20022.Acmt001001.FATCAStatus2Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.FATCAStatus2Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.FinancialInstitutionIdentification11Choice {
        + PrtryId  : ISO20022.Acmt001001.SimpleIdentificationInformation4
        + ClrSysMmbId  : ISO20022.Acmt001001.ClearingSystemMemberIdentification4Choice
        + BICFI  : String
        + NmAndAdr  : ISO20022.Acmt001001.NameAndAddress5
    }
    ISO20022.Acmt001001.FinancialInstitutionIdentification11Choice *-- ISO20022.Acmt001001.SimpleIdentificationInformation4
    ISO20022.Acmt001001.FinancialInstitutionIdentification11Choice *-- ISO20022.Acmt001001.ClearingSystemMemberIdentification4Choice
    ISO20022.Acmt001001.FinancialInstitutionIdentification11Choice *-- ISO20022.Acmt001001.NameAndAddress5
    class ISO20022.Acmt001001.FinancialInstrument87 {
        + OprlSts  : String
        + FndIntntn  : String
        + FndOwnrsh  : String
        + ThrdPtyRghts  : ISO20022.Acmt001001.ThirdPartyRights2
        + Coll  : String
        + Pldgg  : String
        + BlckdHldgDtls  : ISO20022.Acmt001001.BlockedHoldingDetails2
        + PdctGrp  : String
        + DstrbtnPlcy  : String
        + SctiesForm  : String
        + ClssTp  : String
        + SplmtryId  : String
        + ShrtNm  : String
        + Nm  : String
        + Id  : ISO20022.Acmt001001.SecurityIdentification25Choice
    }
    ISO20022.Acmt001001.FinancialInstrument87 *-- ISO20022.Acmt001001.ThirdPartyRights2
    ISO20022.Acmt001001.FinancialInstrument87 *-- ISO20022.Acmt001001.BlockedHoldingDetails2
    ISO20022.Acmt001001.FinancialInstrument87 *-- ISO20022.Acmt001001.SecurityIdentification25Choice
    class ISO20022.Acmt001001.FiscalYear1Choice {
        + EndDt  : DateTime
        + StartDt  : DateTime
    }
    class ISO20022.Acmt001001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Acmt001001.Frequency20Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.Frequency20Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.FundCashAccount4Code {
        CPEN = 1
        PPEN = 2
        CSDP = 3
        CSDM = 4
        ICSA = 5
        TOFF = 6
        CSDO = 7
        SRSA = 8
        CPFS = 9
        CPFO = 10
        HEDG = 11
    }
    class ISO20022.Acmt001001.FundIntention1Code {
        NQUA = 1
        YQUA = 2
    }
    class ISO20022.Acmt001001.FundOwnership1Code {
        NALL = 1
        YALL = 2
    }
    class ISO20022.Acmt001001.GDPRData1 {
        + CnsntDt  : DateTime
        + CnsntInd  : String
        + CnsntTp  : ISO20022.Acmt001001.GDPRDataConsent1Choice
    }
    ISO20022.Acmt001001.GDPRData1 *-- ISO20022.Acmt001001.GDPRDataConsent1Choice
    class ISO20022.Acmt001001.GDPRDataConsent1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.GDPRDataConsent1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.GDPRDataConsent1Code {
        DP02 = 1
        DP01 = 2
        DP03 = 3
        DP00 = 4
    }
    class ISO20022.Acmt001001.Gender1Code {
        MALE = 1
        FEMA = 2
    }
    class ISO20022.Acmt001001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt001001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt001001.GenericAccountIdentification1 *-- ISO20022.Acmt001001.AccountSchemeName1Choice
    class ISO20022.Acmt001001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Acmt001001.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Acmt001001.GenericIdentification82 {
        + IssrCtry  : String
        + Stat  : String
        + XpryDt  : DateTime
        + IsseDt  : DateTime
        + Issr  : String
        + Tp  : ISO20022.Acmt001001.OtherIdentification3Choice
        + Id  : String
    }
    ISO20022.Acmt001001.GenericIdentification82 *-- ISO20022.Acmt001001.OtherIdentification3Choice
    class ISO20022.Acmt001001.HighFrequencyTradingProfile1 {
        + CnsldtnTp  : ISO20022.Acmt001001.ConsolidationType1Choice
        + SttlmFrqcy  : ISO20022.Acmt001001.SettlementFrequency1Choice
        + Dt  : DateTime
    }
    ISO20022.Acmt001001.HighFrequencyTradingProfile1 *-- ISO20022.Acmt001001.ConsolidationType1Choice
    ISO20022.Acmt001001.HighFrequencyTradingProfile1 *-- ISO20022.Acmt001001.SettlementFrequency1Choice
    class ISO20022.Acmt001001.Holding1Code {
        PRTH = 1
        NPRH = 2
        CERT = 3
    }
    class ISO20022.Acmt001001.IdentificationSource1Choice {
        + Prtry  : String
        + Dmst  : String
    }
    class ISO20022.Acmt001001.IncomePreference2Code {
        SECU = 1
        CASH = 2
    }
    class ISO20022.Acmt001001.IndividualPerson29 {
        + PstlAdr  : global::System.Collections.Generic.List~ISO20022.Acmt001001.PostalAddress21~
        + Nm  : String
        + MddlNm  : String
        + GvnNm  : String
        + NmPrfx  : ISO20022.Acmt001001.NamePrefix1Choice
    }
    ISO20022.Acmt001001.IndividualPerson29 *-- ISO20022.Acmt001001.PostalAddress21
    ISO20022.Acmt001001.IndividualPerson29 *-- ISO20022.Acmt001001.NamePrefix1Choice
    class ISO20022.Acmt001001.IndividualPerson37 {
        + GDPRData  : global::System.Collections.Generic.List~ISO20022.Acmt001001.GDPRData1~
        + FmlyInf  : ISO20022.Acmt001001.PersonalInformation1
        + EdctnLvl  : String
        + CvlSts  : ISO20022.Acmt001001.CivilStatus1Choice
        + DthDt  : DateTime
        + PltclyXpsdPrsn  : ISO20022.Acmt001001.PoliticallyExposedPerson1
        + BizFctn  : String
        + EmplngCpny  : String
        + Ctznsh  : global::System.Collections.Generic.List~ISO20022.Acmt001001.CitizenshipInformation2~
        + PstlAdr  : global::System.Collections.Generic.List~ISO20022.Acmt001001.PostalAddress21~
        + Prfssn  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + CtryOfBirth  : String
        + BirthDt  : DateTime
        + Gndr  : String
        + NmSfx  : String
        + Nm  : String
        + MddlNm  : String
        + GvnNm  : String
        + NmPrfx  : ISO20022.Acmt001001.NamePrefix1Choice
    }
    ISO20022.Acmt001001.IndividualPerson37 *-- ISO20022.Acmt001001.GDPRData1
    ISO20022.Acmt001001.IndividualPerson37 *-- ISO20022.Acmt001001.PersonalInformation1
    ISO20022.Acmt001001.IndividualPerson37 *-- ISO20022.Acmt001001.CivilStatus1Choice
    ISO20022.Acmt001001.IndividualPerson37 *-- ISO20022.Acmt001001.PoliticallyExposedPerson1
    ISO20022.Acmt001001.IndividualPerson37 *-- ISO20022.Acmt001001.CitizenshipInformation2
    ISO20022.Acmt001001.IndividualPerson37 *-- ISO20022.Acmt001001.PostalAddress21
    ISO20022.Acmt001001.IndividualPerson37 *-- ISO20022.Acmt001001.NamePrefix1Choice
    class ISO20022.Acmt001001.InformationDistribution1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.InformationDistribution1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.InformationDistribution2Code {
        PAPR = 1
        NONE = 2
        ELEC = 3
    }
    class ISO20022.Acmt001001.InitialAmount1Choice {
        + Amt  : ISO20022.Acmt001001.ActiveCurrencyAndAmount
        + InitlNbOfInstlmts  : Decimal
    }
    ISO20022.Acmt001001.InitialAmount1Choice *-- ISO20022.Acmt001001.ActiveCurrencyAndAmount
    class ISO20022.Acmt001001.Insurance1Code {
        PDIS = 1
        LIFE = 2
    }
    class ISO20022.Acmt001001.InsuranceType2Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.InsuranceType2Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.Intermediary46 {
        + NmAndAdr  : ISO20022.Acmt001001.NameAndAddress4
        + ScndryComAdr  : global::System.Collections.Generic.List~ISO20022.Acmt001001.CommunicationAddress6~
        + PmryComAdr  : global::System.Collections.Generic.List~ISO20022.Acmt001001.CommunicationAddress6~
        + Role  : ISO20022.Acmt001001.PartyRole2Choice
        + WvdTrlrComssnInd  : String
        + Acct  : ISO20022.Acmt001001.Account32
        + LglNttyIdr  : String
        + Id  : ISO20022.Acmt001001.PartyIdentification177Choice
    }
    ISO20022.Acmt001001.Intermediary46 *-- ISO20022.Acmt001001.NameAndAddress4
    ISO20022.Acmt001001.Intermediary46 *-- ISO20022.Acmt001001.CommunicationAddress6
    ISO20022.Acmt001001.Intermediary46 *-- ISO20022.Acmt001001.CommunicationAddress6
    ISO20022.Acmt001001.Intermediary46 *-- ISO20022.Acmt001001.PartyRole2Choice
    ISO20022.Acmt001001.Intermediary46 *-- ISO20022.Acmt001001.Account32
    ISO20022.Acmt001001.Intermediary46 *-- ISO20022.Acmt001001.PartyIdentification177Choice
    class ISO20022.Acmt001001.InvestmentAccount73 {
        + FsclYr  : ISO20022.Acmt001001.FiscalYear1Choice
        + InvstrPrfl  : global::System.Collections.Generic.List~ISO20022.Acmt001001.InvestorProfile2~
        + Lblty  : ISO20022.Acmt001001.Liability1Choice
        + PrcgOrdr  : String
        + NegInd  : String
        + ClsgDt  : ISO20022.Acmt001001.DateAndDateTime1Choice
        + OpngDt  : ISO20022.Acmt001001.DateAndDateTime1Choice
        + AcctgSts  : ISO20022.Acmt001001.AccountingStatus1Choice
        + PwrOfAttnyLvlOfCtrl  : ISO20022.Acmt001001.LevelOfControl1Choice
        + ThrdPtyRghts  : ISO20022.Acmt001001.ThirdPartyRights2
        + Coll  : String
        + Pldgg  : String
        + InvstmtAcctCtgy  : ISO20022.Acmt001001.InvestmentAccountCategory1Choice
        + TxChanlTp  : ISO20022.Acmt001001.TransactionChannelType1Choice
        + AcctSgntrDtTm  : ISO20022.Acmt001001.DateAndDateTime1Choice
        + FrgnStsCertfctn  : String
        + AcctUsgTp  : ISO20022.Acmt001001.AccountUsageType2Choice
        + BlckdSts  : ISO20022.Acmt001001.BlockedStatusReason2Choice
        + AcctSvcr  : ISO20022.Acmt001001.PartyIdentification125Choice
        + RndgDtls  : ISO20022.Acmt001001.RoundingParameters1
        + FinInstrmDtls  : global::System.Collections.Generic.List~ISO20022.Acmt001001.FinancialInstrument87~
        + FndFmlyNm  : String
        + ReqrdSgntriesNb  : Decimal
        + AcmltnRghtRef  : String
        + LttrInttDtls  : ISO20022.Acmt001001.LetterIntent1
        + TaxRptg  : global::System.Collections.Generic.List~ISO20022.Acmt001001.TaxReporting3~
        + TaxWhldgMtd  : String
        + RinvstmtDtls  : global::System.Collections.Generic.List~ISO20022.Acmt001001.Reinvestment4~
        + IncmPref  : String
        + Lang  : String
        + RefCcy  : String
        + StmtFrqcy  : ISO20022.Acmt001001.StatementFrequencyReason2Choice
        + TaxXmptn  : ISO20022.Acmt001001.TaxExemptionReason2Choice
        + OwnrshTp  : ISO20022.Acmt001001.OwnershipType2Choice
        + Tp  : ISO20022.Acmt001001.AccountType2Choice
        + Dsgnt  : String
        + Nm  : String
        + Id  : String
    }
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.FiscalYear1Choice
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.InvestorProfile2
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.Liability1Choice
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.DateAndDateTime1Choice
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.DateAndDateTime1Choice
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.AccountingStatus1Choice
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.LevelOfControl1Choice
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.ThirdPartyRights2
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.InvestmentAccountCategory1Choice
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.TransactionChannelType1Choice
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.DateAndDateTime1Choice
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.AccountUsageType2Choice
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.BlockedStatusReason2Choice
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.PartyIdentification125Choice
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.RoundingParameters1
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.FinancialInstrument87
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.LetterIntent1
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.TaxReporting3
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.Reinvestment4
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.StatementFrequencyReason2Choice
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.TaxExemptionReason2Choice
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.OwnershipType2Choice
    ISO20022.Acmt001001.InvestmentAccount73 *-- ISO20022.Acmt001001.AccountType2Choice
    class ISO20022.Acmt001001.InvestmentAccountCategory1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.InvestmentAccountCategory1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.InvestmentAccountCategory1Code {
        RETA = 1
        MAND = 2
    }
    class ISO20022.Acmt001001.InvestmentAccountOpening4 {
        + ExstgAcctId  : global::System.Collections.Generic.List~ISO20022.Acmt001001.Account23~
        + CtrPtyRef  : ISO20022.Acmt001001.AdditionalReference13
        + ClntRef  : String
        + AcctApplId  : String
        + OpngTp  : ISO20022.Acmt001001.AccountOpeningType1Choice
    }
    ISO20022.Acmt001001.InvestmentAccountOpening4 *-- ISO20022.Acmt001001.Account23
    ISO20022.Acmt001001.InvestmentAccountOpening4 *-- ISO20022.Acmt001001.AdditionalReference13
    ISO20022.Acmt001001.InvestmentAccountOpening4 *-- ISO20022.Acmt001001.AccountOpeningType1Choice
    class ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 {
        + CtrlgPty  : String
        + AddtlInf  : global::System.Collections.Generic.List~ISO20022.Acmt001001.AdditiononalInformation13~
        + AcctgSts  : ISO20022.Acmt001001.AccountingStatus1Choice
        + AddtlRgltryInf  : ISO20022.Acmt001001.RegulatoryInformation1
        + ScndryComAdr  : global::System.Collections.Generic.List~ISO20022.Acmt001001.CommunicationAddress6~
        + PmryComAdr  : global::System.Collections.Generic.List~ISO20022.Acmt001001.CommunicationAddress6~
        + ElctrncMlngSvcRef  : String
        + CpnyLk  : ISO20022.Acmt001001.CompanyLink1Choice
        + WorkgCptl  : ISO20022.Acmt001001.DateAndAmount1
        + EqtyVal  : ISO20022.Acmt001001.DateAndAmount1
        + MntryWlth  : ISO20022.Acmt001001.DateAndAmount1
        + CtryAndResdtlSts  : ISO20022.Acmt001001.CountryAndResidentialStatusType2
        + MailTp  : ISO20022.Acmt001001.MailType1Choice
        + Lang  : String
        + TaxRptg  : global::System.Collections.Generic.List~ISO20022.Acmt001001.TaxReporting3~
        + TaxXmptn  : ISO20022.Acmt001001.TaxExemptionReason2Choice
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Acmt001001.GenericIdentification82~
        + CRSRptgDt  : DateTime
        + CRSSts  : global::System.Collections.Generic.List~ISO20022.Acmt001001.CRSStatus4~
        + CRSFormTp  : global::System.Collections.Generic.List~ISO20022.Acmt001001.CRSForm1Choice~
        + FATCARptgDt  : DateTime
        + FATCASts  : global::System.Collections.Generic.List~ISO20022.Acmt001001.FATCAStatus2~
        + FATCAFormTp  : global::System.Collections.Generic.List~ISO20022.Acmt001001.FATCAForm1Choice~
        + Ntfctn  : global::System.Collections.Generic.List~ISO20022.Acmt001001.Notification2~
        + MiFIDClssfctn  : ISO20022.Acmt001001.MiFIDClassification1
        + SgntryRghtInd  : String
        + FsclXmptn  : String
        + ClntId  : String
        + OwnrshBnfcryRate  : ISO20022.Acmt001001.OwnershipBeneficiaryRate1
        + InvstrPrflVldtn  : global::System.Collections.Generic.List~ISO20022.Acmt001001.PartyProfileInformation5~
        + MnyLndrgChck  : ISO20022.Acmt001001.MoneyLaunderingCheck1Choice
        + Pty  : ISO20022.Acmt001001.Party47Choice
    }
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.AdditiononalInformation13
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.AccountingStatus1Choice
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.RegulatoryInformation1
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.CommunicationAddress6
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.CommunicationAddress6
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.CompanyLink1Choice
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.DateAndAmount1
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.DateAndAmount1
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.DateAndAmount1
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.CountryAndResidentialStatusType2
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.MailType1Choice
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.TaxReporting3
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.TaxExemptionReason2Choice
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.GenericIdentification82
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.CRSStatus4
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.CRSForm1Choice
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.FATCAStatus2
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.FATCAForm1Choice
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.Notification2
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.MiFIDClassification1
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.OwnershipBeneficiaryRate1
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.PartyProfileInformation5
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.MoneyLaunderingCheck1Choice
    ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16 *-- ISO20022.Acmt001001.Party47Choice
    class ISO20022.Acmt001001.InvestmentFundOrder4 {
        + MstrRef  : String
        + OrdrRef  : String
    }
    class ISO20022.Acmt001001.InvestmentFundRole6Code {
        TRAN = 1
        TRAG = 2
        REGI = 3
        PAYI = 4
        INVS = 5
        INVE = 6
        INTR = 7
        FTAG = 8
        FNBR = 9
        FMCO = 10
        FIAG = 11
        FIAD = 12
        FACT = 13
        DIST = 14
        DATP = 15
        CUST = 16
        CONC = 17
        CACO = 18
    }
    class ISO20022.Acmt001001.InvestmentFundRole7Code {
        INVS = 1
        INVE = 2
        FACT = 3
        CACO = 4
        CUST = 5
        TRAG = 6
        PAYI = 7
        INTR = 8
        FMCO = 9
        DIST = 10
        CONC = 11
    }
    class ISO20022.Acmt001001.InvestmentFundTransactionType1Code {
        SUAA = 1
        SSPL = 2
        RDIV = 3
        RWPL = 4
        REAA = 5
        OTHR = 6
        INSP = 7
        DIVI = 8
        CROO = 9
        CROI = 10
        CAEV = 11
        DIVP = 12
        CWIT = 13
        CDEP = 14
        REDM = 15
        SUBS = 16
        TOUT = 17
        TRIN = 18
        SWIO = 19
        BUYI = 20
        SELL = 21
        ALLL = 22
    }
    class ISO20022.Acmt001001.InvestmentPlan17 {
        + InstlmtMgrRole  : ISO20022.Acmt001001.PartyRole4Choice
        + PlanSts  : ISO20022.Acmt001001.PlanStatus2Choice
        + InsrncCover  : ISO20022.Acmt001001.InsuranceType2Choice
        + SLAChrgAndComssnRef  : String
        + PdctId  : String
        + RltdCtrctRef  : String
        + CtrctRef  : String
        + CshSttlm  : global::System.Collections.Generic.List~ISO20022.Acmt001001.CashSettlement3~
        + SctyDtls  : global::System.Collections.Generic.List~ISO20022.Acmt001001.Repartition6~
        + RndgDrctn  : String
        + TtlNbOfInstlmts  : Decimal
        + InitlAmt  : ISO20022.Acmt001001.InitialAmount1Choice
        + IncmPref  : String
        + GrssAmtInd  : String
        + Qty  : ISO20022.Acmt001001.UnitsOrAmount1Choice
        + EndDt  : DateTime
        + StartDt  : DateTime
        + Frqcy  : ISO20022.Acmt001001.Frequency20Choice
    }
    ISO20022.Acmt001001.InvestmentPlan17 *-- ISO20022.Acmt001001.PartyRole4Choice
    ISO20022.Acmt001001.InvestmentPlan17 *-- ISO20022.Acmt001001.PlanStatus2Choice
    ISO20022.Acmt001001.InvestmentPlan17 *-- ISO20022.Acmt001001.InsuranceType2Choice
    ISO20022.Acmt001001.InvestmentPlan17 *-- ISO20022.Acmt001001.CashSettlement3
    ISO20022.Acmt001001.InvestmentPlan17 *-- ISO20022.Acmt001001.Repartition6
    ISO20022.Acmt001001.InvestmentPlan17 *-- ISO20022.Acmt001001.InitialAmount1Choice
    ISO20022.Acmt001001.InvestmentPlan17 *-- ISO20022.Acmt001001.UnitsOrAmount1Choice
    ISO20022.Acmt001001.InvestmentPlan17 *-- ISO20022.Acmt001001.Frequency20Choice
    class ISO20022.Acmt001001.InvestorProfile2 {
        + MktMakr  : ISO20022.Acmt001001.MarketMakerProfile2
        + HghFrqcyTradg  : ISO20022.Acmt001001.HighFrequencyTradingProfile1
        + Trsr  : ISO20022.Acmt001001.TreasuryProfile1
        + Sts  : ISO20022.Acmt001001.InvestorProfileStatus1Choice
        + Tp  : ISO20022.Acmt001001.ProfileType1Choice
    }
    ISO20022.Acmt001001.InvestorProfile2 *-- ISO20022.Acmt001001.MarketMakerProfile2
    ISO20022.Acmt001001.InvestorProfile2 *-- ISO20022.Acmt001001.HighFrequencyTradingProfile1
    ISO20022.Acmt001001.InvestorProfile2 *-- ISO20022.Acmt001001.TreasuryProfile1
    ISO20022.Acmt001001.InvestorProfile2 *-- ISO20022.Acmt001001.InvestorProfileStatus1Choice
    ISO20022.Acmt001001.InvestorProfile2 *-- ISO20022.Acmt001001.ProfileType1Choice
    class ISO20022.Acmt001001.InvestorProfileStatus1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.InvestorProfileStatus1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.InvestorProfileStatus1Code {
        SUPS = 1
        PEND = 2
        PSUS = 3
        NAPP = 4
        ANLY = 5
        ADMI = 6
        ENBG = 7
        ENAB = 8
        DISG = 9
        DISA = 10
    }
    class ISO20022.Acmt001001.KYCCheckType1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.KYCCheckType1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.KnowYourCustomerCheckType1Code {
        SIMP = 1
        ORDN = 2
        ENHA = 3
    }
    class ISO20022.Acmt001001.LetterIntent1 {
        + EndDt  : DateTime
        + StartDt  : DateTime
        + Amt  : ISO20022.Acmt001001.ActiveCurrencyAnd13DecimalAmount
        + LttrInttRef  : String
    }
    ISO20022.Acmt001001.LetterIntent1 *-- ISO20022.Acmt001001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Acmt001001.LevelOfControl1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.LevelOfControl1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.LevelOfControl1Code {
        VIEW = 1
        TRAN = 2
    }
    class ISO20022.Acmt001001.Liability1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.Liability1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.Liability1Code {
        BROK = 1
        INVE = 2
    }
    class ISO20022.Acmt001001.MailType1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.MailType1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.MailType1Code {
        REGM = 1
        ORDM = 2
        AIRM = 3
    }
    class ISO20022.Acmt001001.MarketMakerProfile2 {
        + Dscnt  : Decimal
        + MaxSprd  : Decimal
        + Cmplc  : String
        + CtrctPrd  : ISO20022.Acmt001001.DateTimePeriod2
    }
    ISO20022.Acmt001001.MarketMakerProfile2 *-- ISO20022.Acmt001001.DateTimePeriod2
    class ISO20022.Acmt001001.MarketPracticeVersion1 {
        + Nb  : String
        + Dt  : String
        + Nm  : String
    }
    class ISO20022.Acmt001001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Acmt001001.MiFIDClassification1 {
        + Nrrtv  : String
        + Clssfctn  : String
    }
    class ISO20022.Acmt001001.MoneyLaunderingCheck1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.MoneyLaunderingCheck1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.MoneyLaunderingCheck1Code {
        POEP = 1
        AUTH = 2
        CLMO = 3
        EXEM = 4
        NOTC = 5
        PASS = 6
    }
    class ISO20022.Acmt001001.NameAndAddress4 {
        + Adr  : ISO20022.Acmt001001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Acmt001001.NameAndAddress4 *-- ISO20022.Acmt001001.PostalAddress1
    class ISO20022.Acmt001001.NameAndAddress5 {
        + Adr  : ISO20022.Acmt001001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Acmt001001.NameAndAddress5 *-- ISO20022.Acmt001001.PostalAddress1
    class ISO20022.Acmt001001.NamePrefix1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.NamePrefix1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.NamePrefix1Code {
        MADM = 1
        MISS = 2
        MIST = 3
        DOCT = 4
    }
    class ISO20022.Acmt001001.NewIssueAllocation2 {
        + DeMnms  : ISO20022.Acmt001001.DeMinimus1Choice
        + XmptPrsnRsn  : String
        + Rstrctd  : String
    }
    ISO20022.Acmt001001.NewIssueAllocation2 *-- ISO20022.Acmt001001.DeMinimus1Choice
    class ISO20022.Acmt001001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Acmt001001.Notification2 {
        + DstrbtnTp  : ISO20022.Acmt001001.InformationDistribution1Choice
        + Reqrd  : String
        + NtfctnTp  : String
    }
    ISO20022.Acmt001001.Notification2 *-- ISO20022.Acmt001001.InformationDistribution1Choice
    class ISO20022.Acmt001001.OperationalStatus1Code {
        SPEC = 1
        ENAB = 2
    }
    class ISO20022.Acmt001001.OrderOriginatorEligibility1Code {
        PROF = 1
        RETL = 2
        ELIG = 3
    }
    class ISO20022.Acmt001001.Organisation23 {
        + PstlAdr  : global::System.Collections.Generic.List~ISO20022.Acmt001001.PostalAddress21~
        + ShrtNm  : String
        + Nm  : String
    }
    ISO20022.Acmt001001.Organisation23 *-- ISO20022.Acmt001001.PostalAddress21
    class ISO20022.Acmt001001.Organisation39 {
        + PlcOfListg  : global::System.Collections.Generic.List~String~
        + TpOfOrg  : ISO20022.Acmt001001.OrganisationType1Choice
        + PstlAdr  : global::System.Collections.Generic.List~ISO20022.Acmt001001.PostalAddress21~
        + RegnDt  : DateTime
        + RegnCtry  : String
        + Purp  : String
        + LglNttyIdr  : String
        + Id  : ISO20022.Acmt001001.PartyIdentification177Choice
        + ShrtNm  : String
        + Nm  : String
    }
    ISO20022.Acmt001001.Organisation39 *-- ISO20022.Acmt001001.OrganisationType1Choice
    ISO20022.Acmt001001.Organisation39 *-- ISO20022.Acmt001001.PostalAddress21
    ISO20022.Acmt001001.Organisation39 *-- ISO20022.Acmt001001.PartyIdentification177Choice
    class ISO20022.Acmt001001.OrganisationType1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.OrganisationType1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.OrganisationType1Code {
        PFUN = 1
        PUBL = 2
        PRIV = 3
        IFUN = 4
    }
    class ISO20022.Acmt001001.OtherIdentification3Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.OtherIdentification3Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.OwnershipBeneficiaryRate1 {
        + Frctn  : String
        + Rate  : Decimal
    }
    class ISO20022.Acmt001001.OwnershipType2Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.OwnershipType2Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.Party47Choice {
        + IndvPrsn  : ISO20022.Acmt001001.IndividualPerson37
        + Org  : ISO20022.Acmt001001.Organisation39
    }
    ISO20022.Acmt001001.Party47Choice *-- ISO20022.Acmt001001.IndividualPerson37
    ISO20022.Acmt001001.Party47Choice *-- ISO20022.Acmt001001.Organisation39
    class ISO20022.Acmt001001.PartyIdentification125Choice {
        + NmAndAdr  : ISO20022.Acmt001001.NameAndAddress5
        + PrtryId  : ISO20022.Acmt001001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Acmt001001.PartyIdentification125Choice *-- ISO20022.Acmt001001.NameAndAddress5
    ISO20022.Acmt001001.PartyIdentification125Choice *-- ISO20022.Acmt001001.GenericIdentification1
    class ISO20022.Acmt001001.PartyIdentification177Choice {
        + PrtryId  : ISO20022.Acmt001001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Acmt001001.PartyIdentification177Choice *-- ISO20022.Acmt001001.GenericIdentification1
    class ISO20022.Acmt001001.PartyIdentificationType7Code {
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
    class ISO20022.Acmt001001.PartyProfileInformation5 {
        + KnowYourCstmrDBChck  : ISO20022.Acmt001001.DataBaseCheck1
        + KnowYourCstmrChckTp  : ISO20022.Acmt001001.KYCCheckType1Choice
        + RskLvl  : ISO20022.Acmt001001.RiskLevel2Choice
        + CstmrCndctClssfctn  : ISO20022.Acmt001001.CustomerConductClassification1Choice
        + SrcOfWlth  : String
        + SlryRg  : String
        + NxtRvsnDt  : DateTime
        + ChckngFrqcy  : String
        + ChckngDt  : DateTime
        + CertTp  : ISO20022.Acmt001001.CertificationType1Choice
        + RspnsblPty  : String
        + ChckngPty  : String
        + VldtngPty  : String
        + CertfctnInd  : String
    }
    ISO20022.Acmt001001.PartyProfileInformation5 *-- ISO20022.Acmt001001.DataBaseCheck1
    ISO20022.Acmt001001.PartyProfileInformation5 *-- ISO20022.Acmt001001.KYCCheckType1Choice
    ISO20022.Acmt001001.PartyProfileInformation5 *-- ISO20022.Acmt001001.RiskLevel2Choice
    ISO20022.Acmt001001.PartyProfileInformation5 *-- ISO20022.Acmt001001.CustomerConductClassification1Choice
    ISO20022.Acmt001001.PartyProfileInformation5 *-- ISO20022.Acmt001001.CertificationType1Choice
    class ISO20022.Acmt001001.PartyRole1Code {
        INVS = 1
        CUST = 2
    }
    class ISO20022.Acmt001001.PartyRole2Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.PartyRole2Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.PartyRole4Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.PartyRole4Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.PartyRole5Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.PartyRole5Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.PaymentCard29 {
        + SeqNb  : String
        + SctyCd  : String
        + CardIssrId  : ISO20022.Acmt001001.PartyIdentification125Choice
        + CardIssrNm  : String
        + XpryDt  : String
        + StartDt  : String
        + HldrNm  : String
        + Nb  : String
        + Tp  : String
    }
    ISO20022.Acmt001001.PaymentCard29 *-- ISO20022.Acmt001001.PartyIdentification125Choice
    class ISO20022.Acmt001001.PaymentInstrument17 {
        + IntrstPmtInstrm  : ISO20022.Acmt001001.PaymentInstrument19Choice
        + SvgsPlanPmtInstrm  : ISO20022.Acmt001001.PaymentInstrument24Choice
        + DvddPmtInstrm  : ISO20022.Acmt001001.PaymentInstrument19Choice
        + RedPmtInstrm  : ISO20022.Acmt001001.PaymentInstrument19Choice
        + SbcptPmtInstrm  : ISO20022.Acmt001001.PaymentInstrument24Choice
        + DvddPctg  : Decimal
        + SttlmCcy  : String
    }
    ISO20022.Acmt001001.PaymentInstrument17 *-- ISO20022.Acmt001001.PaymentInstrument19Choice
    ISO20022.Acmt001001.PaymentInstrument17 *-- ISO20022.Acmt001001.PaymentInstrument24Choice
    ISO20022.Acmt001001.PaymentInstrument17 *-- ISO20022.Acmt001001.PaymentInstrument19Choice
    ISO20022.Acmt001001.PaymentInstrument17 *-- ISO20022.Acmt001001.PaymentInstrument19Choice
    ISO20022.Acmt001001.PaymentInstrument17 *-- ISO20022.Acmt001001.PaymentInstrument24Choice
    class ISO20022.Acmt001001.PaymentInstrument19Choice {
        + BkrsDrftDtls  : ISO20022.Acmt001001.Cheque4
        + ChqDtls  : ISO20022.Acmt001001.Cheque4
    }
    ISO20022.Acmt001001.PaymentInstrument19Choice *-- ISO20022.Acmt001001.Cheque4
    ISO20022.Acmt001001.PaymentInstrument19Choice *-- ISO20022.Acmt001001.Cheque4
    class ISO20022.Acmt001001.PaymentInstrument24Choice {
        + BkrsDrft  : String
        + Chq  : String
        + DrctDbtDtls  : ISO20022.Acmt001001.DirectDebitMandate7
        + PmtCardDtls  : ISO20022.Acmt001001.PaymentCard29
    }
    ISO20022.Acmt001001.PaymentInstrument24Choice *-- ISO20022.Acmt001001.DirectDebitMandate7
    ISO20022.Acmt001001.PaymentInstrument24Choice *-- ISO20022.Acmt001001.PaymentCard29
    class ISO20022.Acmt001001.PersonalInformation1 {
        + NmOfPrtnr  : String
        + MdnNmOfMthr  : String
        + NmOfFthr  : String
    }
    class ISO20022.Acmt001001.PlanStatus1Code {
        SUSP = 1
        CLOS = 2
        ACTV = 3
    }
    class ISO20022.Acmt001001.PlanStatus2Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.PlanStatus2Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.PoliticalExposureType2Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.PoliticalExposureType2Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.PoliticalExposureType2Code {
        PEXF = 1
        PEXD = 2
        YPEX = 3
        NPEX = 4
    }
    class ISO20022.Acmt001001.PoliticallyExposedPerson1 {
        + PltclyXpsdPrsnSts  : ISO20022.Acmt001001.PoliticallyExposedPersonStatus1Choice
        + PltclyXpsdPrsnTp  : ISO20022.Acmt001001.PoliticalExposureType2Choice
    }
    ISO20022.Acmt001001.PoliticallyExposedPerson1 *-- ISO20022.Acmt001001.PoliticallyExposedPersonStatus1Choice
    ISO20022.Acmt001001.PoliticallyExposedPerson1 *-- ISO20022.Acmt001001.PoliticalExposureType2Choice
    class ISO20022.Acmt001001.PoliticallyExposedPersonStatus1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.PoliticallyExposedPersonStatus1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.PoliticallyExposedPersonStatus1Code {
        PE02 = 1
        PE01 = 2
        PE03 = 3
    }
    class ISO20022.Acmt001001.PositionEffect3Code {
        LIFO = 1
        FIFO = 2
    }
    class ISO20022.Acmt001001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Acmt001001.PostalAddress21 {
        + Ctry  : String
        + Stat  : String
        + TwnNm  : String
        + Vllg  : String
        + DstrctNm  : String
        + PstCd  : String
        + SuiteId  : String
        + Flr  : String
        + SdInBldg  : String
        + PstBx  : String
        + BldgNm  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + CareOf  : String
        + RegnAdrInd  : String
        + MlngInd  : String
        + AdrTp  : ISO20022.Acmt001001.AddressType2Choice
    }
    ISO20022.Acmt001001.PostalAddress21 *-- ISO20022.Acmt001001.AddressType2Choice
    class ISO20022.Acmt001001.ProfileType1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.ProfileType1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.ProfileType1Code {
        TREA = 1
        MAKE = 2
        HFTR = 3
        HEDG = 4
    }
    class ISO20022.Acmt001001.Provided1Code {
        PROV = 1
        NPRO = 2
    }
    class ISO20022.Acmt001001.Rank1Code {
        SECO = 1
        PRIM = 2
    }
    class ISO20022.Acmt001001.Referred1Code {
        UKNW = 1
        NRFR = 2
        REFR = 3
    }
    class ISO20022.Acmt001001.ReferredAgent3 {
        + RfrdPlcmntAgt  : ISO20022.Acmt001001.PartyIdentification125Choice
        + Rfrd  : String
    }
    ISO20022.Acmt001001.ReferredAgent3 *-- ISO20022.Acmt001001.PartyIdentification125Choice
    class ISO20022.Acmt001001.RegisteredShareholderName1Choice {
        + Org  : ISO20022.Acmt001001.Organisation23
        + IndvPrsn  : ISO20022.Acmt001001.IndividualPerson29
    }
    ISO20022.Acmt001001.RegisteredShareholderName1Choice *-- ISO20022.Acmt001001.Organisation23
    ISO20022.Acmt001001.RegisteredShareholderName1Choice *-- ISO20022.Acmt001001.IndividualPerson29
    class ISO20022.Acmt001001.RegulatoryInformation1 {
        + Othr  : String
        + Grp  : String
        + Brnch  : String
        + Sctr  : String
    }
    class ISO20022.Acmt001001.Reinvestment4 {
        + RinvstmtPctg  : Decimal
        + ReqdNAVCcy  : String
        + FinInstrmDtls  : ISO20022.Acmt001001.FinancialInstrument87
    }
    ISO20022.Acmt001001.Reinvestment4 *-- ISO20022.Acmt001001.FinancialInstrument87
    class ISO20022.Acmt001001.Repartition6 {
        + CcyOfPlan  : String
        + FinInstrm  : ISO20022.Acmt001001.FinancialInstrument87
        + Qty  : ISO20022.Acmt001001.UnitsOrAmountOrPercentage1Choice
    }
    ISO20022.Acmt001001.Repartition6 *-- ISO20022.Acmt001001.FinancialInstrument87
    ISO20022.Acmt001001.Repartition6 *-- ISO20022.Acmt001001.UnitsOrAmountOrPercentage1Choice
    class ISO20022.Acmt001001.ResidentialStatus1Code {
        NRES = 1
        PRES = 2
        RESI = 3
    }
    class ISO20022.Acmt001001.RestrictionStatus1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.RestrictionStatus1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.RestrictionStatus1Code {
        INAC = 1
        ACTV = 2
    }
    class ISO20022.Acmt001001.RiskLevel1Code {
        MEDM = 1
        LOWW = 2
        HIGH = 3
    }
    class ISO20022.Acmt001001.RiskLevel2Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.RiskLevel2Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.RoundingDirection1Code {
        DIST = 1
        STAN = 2
        RDWN = 3
        RDUP = 4
    }
    class ISO20022.Acmt001001.RoundingParameters1 {
        + RndgDrctn  : String
        + RndgMdlus  : Decimal
    }
    class ISO20022.Acmt001001.SecurityIdentification25Choice {
        + OthrPrtryId  : ISO20022.Acmt001001.AlternateSecurityIdentification7
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
    ISO20022.Acmt001001.SecurityIdentification25Choice *-- ISO20022.Acmt001001.AlternateSecurityIdentification7
    class ISO20022.Acmt001001.SettlementFrequency1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.SettlementFrequency1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.SettlementInstructionReason1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.SettlementInstructionReason1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.SettlementInstructionReason1Code {
        CORP = 1
        WTHP = 2
        SUBS = 3
        SELL = 4
        BUYI = 5
        SAVE = 6
        REDM = 7
        SAVP = 8
        INTE = 9
        DIVI = 10
        CHAR = 11
        CSHO = 12
        ALLL = 13
        CSHI = 14
    }
    class ISO20022.Acmt001001.SimpleIdentificationInformation4 {
        + Id  : String
    }
    class ISO20022.Acmt001001.StatementFrequencyReason2Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.StatementFrequencyReason2Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.TaxExemptReason3Code {
        OANR = 1
        TANR = 2
        ADMI = 3
        RIHO = 4
        REFU = 5
        PENF = 6
        ORDR = 7
        FORP = 8
        DOME = 9
        DIPL = 10
        ASSO = 11
        MINO = 12
        INCA = 13
        FORE = 14
        EIOP = 15
        EIFP = 16
        RCIP = 17
        RCRF = 18
        RIAN = 19
        RIRA = 20
        E457X = 21
        E403B = 22
        SIRA = 23
        E401K = 24
        PFSP = 25
        KEOG = 26
        IRAR = 27
        IRAC = 28
        DECP = 29
        NFQP = 30
        NFPI = 31
        ECYE = 32
        EPRY = 33
        EMCY = 34
        EMPY = 35
        ASTR = 36
        PRYP = 37
        CUYP = 38
        IISA = 39
        SISA = 40
        MISA = 41
        MASA = 42
        NONE = 43
    }
    class ISO20022.Acmt001001.TaxExemptionReason2Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.TaxExemptionReason2Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.TaxReporting3 {
        + Desc  : String
        + CshAcctDtls  : ISO20022.Acmt001001.CashAccount204
        + TaxRcpt  : ISO20022.Acmt001001.PartyIdentification125Choice
        + TaxPyer  : ISO20022.Acmt001001.PartyIdentification125Choice
        + TaxRate  : Decimal
        + TaxtnCtry  : String
    }
    ISO20022.Acmt001001.TaxReporting3 *-- ISO20022.Acmt001001.CashAccount204
    ISO20022.Acmt001001.TaxReporting3 *-- ISO20022.Acmt001001.PartyIdentification125Choice
    ISO20022.Acmt001001.TaxReporting3 *-- ISO20022.Acmt001001.PartyIdentification125Choice
    class ISO20022.Acmt001001.TaxWithholdingMethod3Code {
        WTRE = 1
        WTHD = 2
        WHCO = 3
        CRTF = 4
        REPT = 5
        EXMT = 6
        ACCT = 7
        INVE = 8
        MITX = 9
    }
    class ISO20022.Acmt001001.ThirdPartyRights2 {
        + Desc  : String
        + Amt  : ISO20022.Acmt001001.ActiveCurrencyAndAmount
        + LglNttyIdr  : String
        + Hldr  : ISO20022.Acmt001001.PartyIdentification125Choice
        + DtTm  : DateTime
        + Tp  : String
    }
    ISO20022.Acmt001001.ThirdPartyRights2 *-- ISO20022.Acmt001001.ActiveCurrencyAndAmount
    ISO20022.Acmt001001.ThirdPartyRights2 *-- ISO20022.Acmt001001.PartyIdentification125Choice
    class ISO20022.Acmt001001.TransactionChannel2Code {
        BRAN = 1
        HOBA = 2
        FIAD = 3
    }
    class ISO20022.Acmt001001.TransactionChannelType1Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.TransactionChannelType1Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.TransactionType5Choice {
        + Prtry  : ISO20022.Acmt001001.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Acmt001001.TransactionType5Choice *-- ISO20022.Acmt001001.GenericIdentification47
    class ISO20022.Acmt001001.TreasuryProfile1 {
        + Rate  : Decimal
        + TradrTp  : ISO20022.Acmt001001.PartyRole5Choice
        + Dt  : DateTime
    }
    ISO20022.Acmt001001.TreasuryProfile1 *-- ISO20022.Acmt001001.PartyRole5Choice
    class ISO20022.Acmt001001.UnitsOrAmount1Choice {
        + Unit  : Decimal
        + Amt  : ISO20022.Acmt001001.ActiveCurrencyAndAmount
    }
    ISO20022.Acmt001001.UnitsOrAmount1Choice *-- ISO20022.Acmt001001.ActiveCurrencyAndAmount
    class ISO20022.Acmt001001.UnitsOrAmountOrPercentage1Choice {
        + Pctg  : Decimal
        + Unit  : Decimal
        + Amt  : ISO20022.Acmt001001.ActiveCurrencyAndAmount
    }
    ISO20022.Acmt001001.UnitsOrAmountOrPercentage1Choice *-- ISO20022.Acmt001001.ActiveCurrencyAndAmount
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

## Value ISO20022.Acmt001001.Account23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltdAcctDtls|ISO20022.Acmt001001.GenericIdentification1||XmlElement()||
|+|AcctId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RltdAcctDtls))|

---

## Value ISO20022.Acmt001001.Account32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|ISO20022.Acmt001001.PartyIdentification125Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcr))|

---

## Value ISO20022.Acmt001001.AccountDesignation1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Acmt001001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Acmt001001.AccountIdentificationAndName5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Acmt001001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id))|

---

## Aspect ISO20022.Acmt001001.AccountOpeningInstructionV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Xtnsn|global::System.Collections.Generic.List<ISO20022.Acmt001001.Extension1>||XmlElement()||
|+|MktPrctcVrsn|ISO20022.Acmt001001.MarketPracticeVersion1||XmlElement()||
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Acmt001001.AdditiononalInformation13>||XmlElement()||
|+|SvcLvlAgrmt|global::System.Collections.Generic.List<ISO20022.Acmt001001.DocumentToSend4>||XmlElement()||
|+|CshSttlm|global::System.Collections.Generic.List<ISO20022.Acmt001001.CashSettlement3>||XmlElement()||
|+|WdrwlInvstmtPlan|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestmentPlan17>||XmlElement()||
|+|SvgsInvstmtPlan|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestmentPlan17>||XmlElement()||
|+|NewIsseAllcn|ISO20022.Acmt001001.NewIssueAllocation2||XmlElement()||
|+|Plcmnt|ISO20022.Acmt001001.ReferredAgent3||XmlElement()||
|+|Intrmies|global::System.Collections.Generic.List<ISO20022.Acmt001001.Intermediary46>||XmlElement()||
|+|AcctPties|ISO20022.Acmt001001.AccountParties17||XmlElement()||
|+|InvstmtAcct|ISO20022.Acmt001001.InvestmentAccount73||XmlElement()||
|+|InstrDtls|ISO20022.Acmt001001.InvestmentAccountOpening4||XmlElement()||
|+|PrvsRef|ISO20022.Acmt001001.AdditionalReference13||XmlElement()||
|+|OrdrRef|ISO20022.Acmt001001.InvestmentFundOrder4||XmlElement()||
|+|MsgId|ISO20022.Acmt001001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Xtnsn""",Xtnsn),validElement(Xtnsn),validElement(MktPrctcVrsn),validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validList("""SvcLvlAgrmt""",SvcLvlAgrmt),validListMax("""SvcLvlAgrmt""",SvcLvlAgrmt,30),validElement(SvcLvlAgrmt),validList("""CshSttlm""",CshSttlm),validListMax("""CshSttlm""",CshSttlm,8),validElement(CshSttlm),validList("""WdrwlInvstmtPlan""",WdrwlInvstmtPlan),validListMax("""WdrwlInvstmtPlan""",WdrwlInvstmtPlan,10),validElement(WdrwlInvstmtPlan),validList("""SvgsInvstmtPlan""",SvgsInvstmtPlan),validListMax("""SvgsInvstmtPlan""",SvgsInvstmtPlan,50),validElement(SvgsInvstmtPlan),validElement(NewIsseAllcn),validElement(Plcmnt),validList("""Intrmies""",Intrmies),validElement(Intrmies),validElement(AcctPties),validElement(InvstmtAcct),validElement(InstrDtls),validElement(PrvsRef),validElement(OrdrRef),validElement(MsgId))|

---

## Value ISO20022.Acmt001001.AccountOpeningType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.AccountOpeningType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUPA|Int32||XmlEnum("""SUPA""")|1|
||NEWA|Int32||XmlEnum("""NEWA""")|2|

---

## Enum ISO20022.Acmt001001.AccountOwnershipType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SIGL|Int32||XmlEnum("""SIGL""")|1|
||RGIC|Int32||XmlEnum("""RGIC""")|2|
||ONIS|Int32||XmlEnum("""ONIS""")|3|
||NFPO|Int32||XmlEnum("""NFPO""")|4|
||NOMI|Int32||XmlEnum("""NOMI""")|5|
||LLCO|Int32||XmlEnum("""LLCO""")|6|
||JOIN|Int32||XmlEnum("""JOIN""")|7|
||COMO|Int32||XmlEnum("""COMO""")|8|
||JOIT|Int32||XmlEnum("""JOIT""")|9|
||GOVO|Int32||XmlEnum("""GOVO""")|10|
||TRUS|Int32||XmlEnum("""TRUS""")|11|
||PART|Int32||XmlEnum("""PART""")|12|
||EURE|Int32||XmlEnum("""EURE""")|13|
||CUST|Int32||XmlEnum("""CUST""")|14|
||CORP|Int32||XmlEnum("""CORP""")|15|
||ENTR|Int32||XmlEnum("""ENTR""")|16|
||LIPA|Int32||XmlEnum("""LIPA""")|17|
||UNCO|Int32||XmlEnum("""UNCO""")|18|

---

## Value ISO20022.Acmt001001.AccountParties12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|JntOwnr|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16>||XmlElement()||
|+|Nmnee|ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16||XmlElement()||
|+|Trstee|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16>||XmlElement()||
|+|PmryOwnr|ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""JntOwnr""",JntOwnr),validList("""JntOwnr""",JntOwnr),validListMax("""JntOwnr""",JntOwnr,5),validElement(JntOwnr),validElement(Nmnee),validRequired("""Trstee""",Trstee),validList("""Trstee""",Trstee),validListMax("""Trstee""",Trstee,5),validElement(Trstee),validElement(PmryOwnr),validChoice(JntOwnr,Nmnee,Trstee,PmryOwnr))|

---

## Value ISO20022.Acmt001001.AccountParties17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegdShrhldrNm|ISO20022.Acmt001001.RegisteredShareholderName1Choice||XmlElement()||
|+|Prtctr|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16>||XmlElement()||
|+|SnrMggOffcl|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16>||XmlElement()||
|+|Sttlr|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16>||XmlElement()||
|+|Grntr|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16>||XmlElement()||
|+|OthrPty|global::System.Collections.Generic.List<ISO20022.Acmt001001.ExtendedParty14>||XmlElement()||
|+|Admstr|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16>||XmlElement()||
|+|SucssrOnDth|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16>||XmlElement()||
|+|CtdnForMnr|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16>||XmlElement()||
|+|LglGuardn|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16>||XmlElement()||
|+|PwrOfAttny|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16>||XmlElement()||
|+|Bnfcry|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16>||XmlElement()||
|+|ScndryOwnr|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16>||XmlElement()||
|+|PrncplAcctPty|ISO20022.Acmt001001.AccountParties12Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RegdShrhldrNm),validList("""Prtctr""",Prtctr),validElement(Prtctr),validList("""SnrMggOffcl""",SnrMggOffcl),validElement(SnrMggOffcl),validList("""Sttlr""",Sttlr),validElement(Sttlr),validList("""Grntr""",Grntr),validElement(Grntr),validList("""OthrPty""",OthrPty),validElement(OthrPty),validList("""Admstr""",Admstr),validElement(Admstr),validList("""SucssrOnDth""",SucssrOnDth),validElement(SucssrOnDth),validList("""CtdnForMnr""",CtdnForMnr),validElement(CtdnForMnr),validList("""LglGuardn""",LglGuardn),validElement(LglGuardn),validList("""PwrOfAttny""",PwrOfAttny),validElement(PwrOfAttny),validList("""Bnfcry""",Bnfcry),validElement(Bnfcry),validList("""ScndryOwnr""",ScndryOwnr),validElement(ScndryOwnr),validElement(PrncplAcctPty))|

---

## Value ISO20022.Acmt001001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.AccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.AccountUsageType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.AccountUsageType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRDP|Int32||XmlEnum("""TRDP""")|1|
||SETP|Int32||XmlEnum("""SETP""")|2|
||ISSP|Int32||XmlEnum("""ISSP""")|3|
||INVE|Int32||XmlEnum("""INVE""")|4|

---

## Value ISO20022.Acmt001001.AccountingStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.AccountingStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NDOM|Int32||XmlEnum("""NDOM""")|1|
||YDOM|Int32||XmlEnum("""YDOM""")|2|

---

## Value ISO20022.Acmt001001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Acmt001001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Acmt001001.AdditionalReference13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Acmt001001.PartyIdentification125Choice||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Value ISO20022.Acmt001001.AdditiononalInformation13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prd|ISO20022.Acmt001001.DateTimePeriod2||XmlElement()||
|+|Sts|ISO20022.Acmt001001.RestrictionStatus1Choice||XmlElement()||
|+|Rgltr|ISO20022.Acmt001001.PartyIdentification125Choice||XmlElement()||
|+|Tp|String||XmlElement()||
|+|AcctVldtn|String||XmlElement()||
|+|AddtlInf|String||XmlElement()||
|+|Lmttn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prd),validElement(Sts),validElement(Rgltr))|

---

## Value ISO20022.Acmt001001.AddressType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.AddressType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BIZZ|Int32||XmlEnum("""BIZZ""")|1|
||HOME|Int32||XmlEnum("""HOME""")|2|

---

## Value ISO20022.Acmt001001.AddressType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Acmt001001.AlternateSecurityIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IdSrc|ISO20022.Acmt001001.IdentificationSource1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IdSrc))|

---

## Value ISO20022.Acmt001001.BlockedHoldingDetails2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|HldgCertNb|String||XmlElement()||
|+|PrtlHldgUnits|Decimal||XmlElement()||
|+|BlckdHldg|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt001001.BlockedReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.BlockedReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAN|Int32||XmlEnum("""TRAN""")|1|
||SANC|Int32||XmlEnum("""SANC""")|2|
||TRPE|Int32||XmlEnum("""TRPE""")|3|
||PLDG|Int32||XmlEnum("""PLDG""")|4|
||PCOM|Int32||XmlEnum("""PCOM""")|5|
||MORT|Int32||XmlEnum("""MORT""")|6|
||CNFS|Int32||XmlEnum("""CNFS""")|7|
||CMMT|Int32||XmlEnum("""CMMT""")|8|
||BKRP|Int32||XmlEnum("""BKRP""")|9|

---

## Value ISO20022.Acmt001001.BlockedStatusReason2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Acmt001001.BlockedReason2Choice>||XmlElement()||
|+|Blckd|String||XmlElement()||
|+|TxTp|ISO20022.Acmt001001.TransactionType5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rsn""",Rsn),validElement(Rsn),validElement(TxTp))|

---

## Value ISO20022.Acmt001001.BlockedStatusReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Acmt001001.BlockedStatusReason2>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Acmt001001.BranchData4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Acmt001001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr))|

---

## Value ISO20022.Acmt001001.CRSForm1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.CRSFormType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CER7|Int32||XmlEnum("""CER7""")|1|
||CER2|Int32||XmlEnum("""CER2""")|2|
||CER1|Int32||XmlEnum("""CER1""")|3|
||CER8|Int32||XmlEnum("""CER8""")|4|
||CER6|Int32||XmlEnum("""CER6""")|5|
||CER5|Int32||XmlEnum("""CER5""")|6|
||CER3|Int32||XmlEnum("""CER3""")|7|
||CER4|Int32||XmlEnum("""CER4""")|8|

---

## Value ISO20022.Acmt001001.CRSSource1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.CRSSourceStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DECL|Int32||XmlEnum("""DECL""")|1|
||CALC|Int32||XmlEnum("""CALC""")|2|

---

## Enum ISO20022.Acmt001001.CRSStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||C114|Int32||XmlEnum("""C114""")|1|
||C113|Int32||XmlEnum("""C113""")|2|
||C112|Int32||XmlEnum("""C112""")|3|
||C111|Int32||XmlEnum("""C111""")|4|
||C110|Int32||XmlEnum("""C110""")|5|
||C109|Int32||XmlEnum("""C109""")|6|
||C108|Int32||XmlEnum("""C108""")|7|
||C107|Int32||XmlEnum("""C107""")|8|
||C106|Int32||XmlEnum("""C106""")|9|
||C105|Int32||XmlEnum("""C105""")|10|
||C104|Int32||XmlEnum("""C104""")|11|
||C103|Int32||XmlEnum("""C103""")|12|
||C102|Int32||XmlEnum("""C102""")|13|
||C101|Int32||XmlEnum("""C101""")|14|

---

## Value ISO20022.Acmt001001.CRSStatus3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.CRSStatus4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XcptnlRptgCtry|String||XmlElement()||
|+|Src|ISO20022.Acmt001001.CRSSource1Choice||XmlElement()||
|+|Tp|ISO20022.Acmt001001.CRSStatus3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""XcptnlRptgCtry""",XcptnlRptgCtry,"""[A-Z]{2,2}"""),validElement(Src),validElement(Tp))|

---

## Enum ISO20022.Acmt001001.CardType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Acmt001001.CashAccount204


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DvddPctg|Decimal||XmlElement()||
|+|CshAcctDsgnt|ISO20022.Acmt001001.AccountDesignation1Choice||XmlElement()||
|+|CshAcctPurp|ISO20022.Acmt001001.CashAccountType3Choice||XmlElement()||
|+|SttlmInstrRsn|ISO20022.Acmt001001.SettlementInstructionReason1Choice||XmlElement()||
|+|CdtDbt|String||XmlElement()||
|+|InvstmtAcctTp|ISO20022.Acmt001001.AccountType2Choice||XmlElement()||
|+|AcctOwnrOthrId|global::System.Collections.Generic.List<ISO20022.Acmt001001.GenericIdentification82>||XmlElement()||
|+|AcctSvcrBrnch|ISO20022.Acmt001001.BranchData4||XmlElement()||
|+|AcctSvcr|ISO20022.Acmt001001.FinancialInstitutionIdentification11Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Acmt001001.PartyIdentification125Choice||XmlElement()||
|+|Id|ISO20022.Acmt001001.AccountIdentificationAndName5||XmlElement()||
|+|SttlmCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshAcctDsgnt),validElement(CshAcctPurp),validElement(SttlmInstrRsn),validElement(InvstmtAcctTp),validList("""AcctOwnrOthrId""",AcctOwnrOthrId),validElement(AcctOwnrOthrId),validElement(AcctSvcrBrnch),validElement(AcctSvcr),validElement(AcctOwnr),validElement(Id),validPattern("""SttlmCcy""",SttlmCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Acmt001001.CashAccountType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.CashAccountType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SEGT|Int32||XmlEnum("""SEGT""")|1|
||MARR|Int32||XmlEnum("""MARR""")|2|
||SETT|Int32||XmlEnum("""SETT""")|3|
||COLL|Int32||XmlEnum("""COLL""")|4|
||LEND|Int32||XmlEnum("""LEND""")|5|

---

## Value ISO20022.Acmt001001.CashSettlement3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrCshSttlmDtls|global::System.Collections.Generic.List<ISO20022.Acmt001001.PaymentInstrument17>||XmlElement()||
|+|CshAcctDtls|global::System.Collections.Generic.List<ISO20022.Acmt001001.CashAccount204>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrCshSttlmDtls""",OthrCshSttlmDtls),validElement(OthrCshSttlmDtls),validList("""CshAcctDtls""",CshAcctDtls),validElement(CshAcctDtls))|

---

## Enum ISO20022.Acmt001001.CertificateType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PKIC|Int32||XmlEnum("""PKIC""")|1|
||PRAD|Int32||XmlEnum("""PRAD""")|2|
||PASS|Int32||XmlEnum("""PASS""")|3|
||LREF|Int32||XmlEnum("""LREF""")|4|
||INCU|Int32||XmlEnum("""INCU""")|5|
||IDEN|Int32||XmlEnum("""IDEN""")|6|
||GOST|Int32||XmlEnum("""GOST""")|7|
||DFOR|Int32||XmlEnum("""DFOR""")|8|
||DVLC|Int32||XmlEnum("""DVLC""")|9|
||AMLC|Int32||XmlEnum("""AMLC""")|10|

---

## Value ISO20022.Acmt001001.CertificationType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.Cheque4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PyeeId|ISO20022.Acmt001001.NameAndAddress5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PyeeId))|

---

## Value ISO20022.Acmt001001.CitizenshipInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MnrInd|String||XmlElement()||
|+|Ntlty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt001001.CivilStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.CivilStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WIDO|Int32||XmlEnum("""WIDO""")|1|
||UNIO|Int32||XmlEnum("""UNIO""")|2|
||SING|Int32||XmlEnum("""SING""")|3|
||SEPA|Int32||XmlEnum("""SEPA""")|4|
||MARR|Int32||XmlEnum("""MARR""")|5|
||LDIV|Int32||XmlEnum("""LDIV""")|6|
||DIVO|Int32||XmlEnum("""DIVO""")|7|

---

## Value ISO20022.Acmt001001.ClearingSystemMemberIdentification4Choice


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

## Enum ISO20022.Acmt001001.Collateral1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NCOL|Int32||XmlEnum("""NCOL""")|1|
||COLL|Int32||XmlEnum("""COLL""")|2|

---

## Value ISO20022.Acmt001001.CommunicationAddress6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|URLAdr|String||XmlElement()||
|+|TlxAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|Mob|String||XmlElement()||
|+|Phne|String||XmlElement()||
|+|Email|String||XmlElement()||
|+|AdrTp|ISO20022.Acmt001001.AddressType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""Mob""",Mob,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""Phne""",Phne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validElement(AdrTp))|

---

## Enum ISO20022.Acmt001001.CommunicationMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROP|Int32||XmlEnum("""PROP""")|1|
||EMAL|Int32||XmlEnum("""EMAL""")|2|
||FAXI|Int32||XmlEnum("""FAXI""")|3|
||SWMX|Int32||XmlEnum("""SWMX""")|4|
||SWMT|Int32||XmlEnum("""SWMT""")|5|

---

## Value ISO20022.Acmt001001.CommunicationMethod3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.CompanyLink1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.CompanyLink1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RELA|Int32||XmlEnum("""RELA""")|1|
||PCOM|Int32||XmlEnum("""PCOM""")|2|
||MEMB|Int32||XmlEnum("""MEMB""")|3|
||PART|Int32||XmlEnum("""PART""")|4|
||BROK|Int32||XmlEnum("""BROK""")|5|
||AGEN|Int32||XmlEnum("""AGEN""")|6|

---

## Enum ISO20022.Acmt001001.ConductClassification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||STAN|Int32||XmlEnum("""STAN""")|1|
||RCLT|Int32||XmlEnum("""RCLT""")|2|
||NSTA|Int32||XmlEnum("""NSTA""")|3|

---

## Value ISO20022.Acmt001001.ConsolidationType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.ConsolidationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||GENL|Int32||XmlEnum("""GENL""")|2|

---

## Value ISO20022.Acmt001001.CountryAndResidentialStatusType2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ResdtlSts|String||XmlElement()||
|+|Ctry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Enum ISO20022.Acmt001001.CreditDebit3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Acmt001001.CustomerConductClassification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.DataBaseCheck1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|DBChck|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt001001.DateAndAmount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Acmt001001.ActiveCurrencyAndAmount||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Acmt001001.DateAndDateTime1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Acmt001001.DateTimePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt001001.DeMinimus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DeMnmsNotAplbl|ISO20022.Acmt001001.DeMinimusNotApplicable1||XmlElement()||
|+|DeMnmsAplbl|ISO20022.Acmt001001.DeMinimusApplicable1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DeMnmsNotAplbl),validElement(DeMnmsAplbl),validChoice(DeMnmsNotAplbl,DeMnmsAplbl))|

---

## Value ISO20022.Acmt001001.DeMinimusApplicable1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pctg|Decimal||XmlElement()||
|+|NewIssePrmssn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt001001.DeMinimusNotApplicable1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RstrctdPrsnRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt001001.DirectDebitMandate7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MndtId|String||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|CdtrAgtBrnch|ISO20022.Acmt001001.BranchData4||XmlElement()||
|+|CdtrAgt|ISO20022.Acmt001001.FinancialInstitutionIdentification11Choice||XmlElement()||
|+|DbtrAgtBrnch|ISO20022.Acmt001001.BranchData4||XmlElement()||
|+|DbtrAgt|ISO20022.Acmt001001.FinancialInstitutionIdentification11Choice||XmlElement()||
|+|Cdtr|ISO20022.Acmt001001.PartyIdentification125Choice||XmlElement()||
|+|DbtrNtlRegnNb|String||XmlElement()||
|+|DbtrTaxIdNb|String||XmlElement()||
|+|Dbtr|ISO20022.Acmt001001.PartyIdentification125Choice||XmlElement()||
|+|DbtrAcct|ISO20022.Acmt001001.AccountIdentificationAndName5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtrAgtBrnch),validElement(CdtrAgt),validElement(DbtrAgtBrnch),validElement(DbtrAgt),validElement(Cdtr),validElement(Dbtr),validElement(DbtrAcct))|

---

## Enum ISO20022.Acmt001001.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||DIST|Int32||XmlEnum("""DIST""")|2|

---

## Type ISO20022.Acmt001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOpngInstr|ISO20022.Acmt001001.AccountOpeningInstructionV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctOpngInstr))|

---

## Value ISO20022.Acmt001001.DocumentToSend4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MtdOfTrnsmssn|ISO20022.Acmt001001.CommunicationMethod3Choice||XmlElement()||
|+|Rcpt|ISO20022.Acmt001001.PartyIdentification125Choice||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MtdOfTrnsmssn),validElement(Rcpt))|

---

## Enum ISO20022.Acmt001001.Eligible1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NELI|Int32||XmlEnum("""NELI""")|1|
||ELIG|Int32||XmlEnum("""ELIG""")|2|

---

## Enum ISO20022.Acmt001001.EventFrequency10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ADHO|Int32||XmlEnum("""ADHO""")|1|
||DAIL|Int32||XmlEnum("""DAIL""")|2|

---

## Enum ISO20022.Acmt001001.EventFrequency1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONDE|Int32||XmlEnum("""ONDE""")|1|
||OVNG|Int32||XmlEnum("""OVNG""")|2|
||INDA|Int32||XmlEnum("""INDA""")|3|
||ADHO|Int32||XmlEnum("""ADHO""")|4|
||DAIL|Int32||XmlEnum("""DAIL""")|5|
||WEEK|Int32||XmlEnum("""WEEK""")|6|
||TOWK|Int32||XmlEnum("""TOWK""")|7|
||TWMN|Int32||XmlEnum("""TWMN""")|8|
||MNTH|Int32||XmlEnum("""MNTH""")|9|
||TOMN|Int32||XmlEnum("""TOMN""")|10|
||QUTR|Int32||XmlEnum("""QUTR""")|11|
||SEMI|Int32||XmlEnum("""SEMI""")|12|
||YEAR|Int32||XmlEnum("""YEAR""")|13|

---

## Enum ISO20022.Acmt001001.EventFrequency8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||TWMN|Int32||XmlEnum("""TWMN""")|2|
||SEMI|Int32||XmlEnum("""SEMI""")|3|
||QUTR|Int32||XmlEnum("""QUTR""")|4|
||OVNG|Int32||XmlEnum("""OVNG""")|5|
||ONDE|Int32||XmlEnum("""ONDE""")|6|
||MNTH|Int32||XmlEnum("""MNTH""")|7|
||INDA|Int32||XmlEnum("""INDA""")|8|
||TYEA|Int32||XmlEnum("""TYEA""")|9|
||TOWK|Int32||XmlEnum("""TOWK""")|10|
||TOMN|Int32||XmlEnum("""TOMN""")|11|
||FOMN|Int32||XmlEnum("""FOMN""")|12|
||DAIL|Int32||XmlEnum("""DAIL""")|13|
||YEAR|Int32||XmlEnum("""YEAR""")|14|
||ADHO|Int32||XmlEnum("""ADHO""")|15|

---

## Enum ISO20022.Acmt001001.EventFrequency9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NONE|Int32||XmlEnum("""NONE""")|1|
||ONDE|Int32||XmlEnum("""ONDE""")|2|
||OVNG|Int32||XmlEnum("""OVNG""")|3|
||INDA|Int32||XmlEnum("""INDA""")|4|
||ADHO|Int32||XmlEnum("""ADHO""")|5|
||DAIL|Int32||XmlEnum("""DAIL""")|6|
||WEEK|Int32||XmlEnum("""WEEK""")|7|
||TOWK|Int32||XmlEnum("""TOWK""")|8|
||TWMN|Int32||XmlEnum("""TWMN""")|9|
||MNTH|Int32||XmlEnum("""MNTH""")|10|
||TOMN|Int32||XmlEnum("""TOMN""")|11|
||QUTR|Int32||XmlEnum("""QUTR""")|12|
||SEMI|Int32||XmlEnum("""SEMI""")|13|
||YEAR|Int32||XmlEnum("""YEAR""")|14|

---

## Value ISO20022.Acmt001001.ExtendedParty14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPtyDtls|ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16||XmlElement()||
|+|XtndedPtyRole|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OthrPtyDtls))|

---

## Value ISO20022.Acmt001001.Extension1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt001001.FATCAForm1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.FATCAFormType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CER6|Int32||XmlEnum("""CER6""")|1|
||CER4|Int32||XmlEnum("""CER4""")|2|
||CER3|Int32||XmlEnum("""CER3""")|3|
||CER2|Int32||XmlEnum("""CER2""")|4|
||CER1|Int32||XmlEnum("""CER1""")|5|
||CER7|Int32||XmlEnum("""CER7""")|6|
||CER5|Int32||XmlEnum("""CER5""")|7|

---

## Value ISO20022.Acmt001001.FATCASource1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.FATCASourceStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DECL|Int32||XmlEnum("""DECL""")|1|
||CALC|Int32||XmlEnum("""CALC""")|2|

---

## Enum ISO20022.Acmt001001.FATCAStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||F206|Int32||XmlEnum("""F206""")|1|
||F205|Int32||XmlEnum("""F205""")|2|
||F204|Int32||XmlEnum("""F204""")|3|
||F203|Int32||XmlEnum("""F203""")|4|
||F202|Int32||XmlEnum("""F202""")|5|
||F201|Int32||XmlEnum("""F201""")|6|
||F105|Int32||XmlEnum("""F105""")|7|
||F104|Int32||XmlEnum("""F104""")|8|
||F103|Int32||XmlEnum("""F103""")|9|
||F102|Int32||XmlEnum("""F102""")|10|
||F101|Int32||XmlEnum("""F101""")|11|

---

## Value ISO20022.Acmt001001.FATCAStatus2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Src|ISO20022.Acmt001001.FATCASource1Choice||XmlElement()||
|+|Tp|ISO20022.Acmt001001.FATCAStatus2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Src),validElement(Tp))|

---

## Value ISO20022.Acmt001001.FATCAStatus2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.FinancialInstitutionIdentification11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Acmt001001.SimpleIdentificationInformation4||XmlElement()||
|+|ClrSysMmbId|ISO20022.Acmt001001.ClearingSystemMemberIdentification4Choice||XmlElement()||
|+|BICFI|String||XmlElement()||
|+|NmAndAdr|ISO20022.Acmt001001.NameAndAddress5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(NmAndAdr),validChoice(PrtryId,ClrSysMmbId,BICFI,NmAndAdr))|

---

## Value ISO20022.Acmt001001.FinancialInstrument87


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OprlSts|String||XmlElement()||
|+|FndIntntn|String||XmlElement()||
|+|FndOwnrsh|String||XmlElement()||
|+|ThrdPtyRghts|ISO20022.Acmt001001.ThirdPartyRights2||XmlElement()||
|+|Coll|String||XmlElement()||
|+|Pldgg|String||XmlElement()||
|+|BlckdHldgDtls|ISO20022.Acmt001001.BlockedHoldingDetails2||XmlElement()||
|+|PdctGrp|String||XmlElement()||
|+|DstrbtnPlcy|String||XmlElement()||
|+|SctiesForm|String||XmlElement()||
|+|ClssTp|String||XmlElement()||
|+|SplmtryId|String||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Acmt001001.SecurityIdentification25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ThrdPtyRghts),validElement(BlckdHldgDtls),validElement(Id))|

---

## Value ISO20022.Acmt001001.FiscalYear1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EndDt|DateTime||XmlElement()||
|+|StartDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(EndDt,StartDt))|

---

## Enum ISO20022.Acmt001001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Acmt001001.Frequency20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.FundCashAccount4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CPEN|Int32||XmlEnum("""CPEN""")|1|
||PPEN|Int32||XmlEnum("""PPEN""")|2|
||CSDP|Int32||XmlEnum("""CSDP""")|3|
||CSDM|Int32||XmlEnum("""CSDM""")|4|
||ICSA|Int32||XmlEnum("""ICSA""")|5|
||TOFF|Int32||XmlEnum("""TOFF""")|6|
||CSDO|Int32||XmlEnum("""CSDO""")|7|
||SRSA|Int32||XmlEnum("""SRSA""")|8|
||CPFS|Int32||XmlEnum("""CPFS""")|9|
||CPFO|Int32||XmlEnum("""CPFO""")|10|
||HEDG|Int32||XmlEnum("""HEDG""")|11|

---

## Enum ISO20022.Acmt001001.FundIntention1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NQUA|Int32||XmlEnum("""NQUA""")|1|
||YQUA|Int32||XmlEnum("""YQUA""")|2|

---

## Enum ISO20022.Acmt001001.FundOwnership1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NALL|Int32||XmlEnum("""NALL""")|1|
||YALL|Int32||XmlEnum("""YALL""")|2|

---

## Value ISO20022.Acmt001001.GDPRData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CnsntDt|DateTime||XmlElement()||
|+|CnsntInd|String||XmlElement()||
|+|CnsntTp|ISO20022.Acmt001001.GDPRDataConsent1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CnsntTp))|

---

## Value ISO20022.Acmt001001.GDPRDataConsent1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.GDPRDataConsent1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DP02|Int32||XmlEnum("""DP02""")|1|
||DP01|Int32||XmlEnum("""DP01""")|2|
||DP03|Int32||XmlEnum("""DP03""")|3|
||DP00|Int32||XmlEnum("""DP00""")|4|

---

## Enum ISO20022.Acmt001001.Gender1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MALE|Int32||XmlEnum("""MALE""")|1|
||FEMA|Int32||XmlEnum("""FEMA""")|2|

---

## Value ISO20022.Acmt001001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt001001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt001001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt001001.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Acmt001001.GenericIdentification82


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IssrCtry|String||XmlElement()||
|+|Stat|String||XmlElement()||
|+|XpryDt|DateTime||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Tp|ISO20022.Acmt001001.OtherIdentification3Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IssrCtry""",IssrCtry,"""[A-Z]{2,2}"""),validElement(Tp))|

---

## Value ISO20022.Acmt001001.HighFrequencyTradingProfile1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CnsldtnTp|ISO20022.Acmt001001.ConsolidationType1Choice||XmlElement()||
|+|SttlmFrqcy|ISO20022.Acmt001001.SettlementFrequency1Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CnsldtnTp),validElement(SttlmFrqcy))|

---

## Enum ISO20022.Acmt001001.Holding1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRTH|Int32||XmlEnum("""PRTH""")|1|
||NPRH|Int32||XmlEnum("""NPRH""")|2|
||CERT|Int32||XmlEnum("""CERT""")|3|

---

## Value ISO20022.Acmt001001.IdentificationSource1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Dmst|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Dmst""",Dmst,"""[A-Z]{2,2}"""),validChoice(Prtry,Dmst))|

---

## Enum ISO20022.Acmt001001.IncomePreference2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SECU|Int32||XmlEnum("""SECU""")|1|
||CASH|Int32||XmlEnum("""CASH""")|2|

---

## Value ISO20022.Acmt001001.IndividualPerson29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|global::System.Collections.Generic.List<ISO20022.Acmt001001.PostalAddress21>||XmlElement()||
|+|Nm|String||XmlElement()||
|+|MddlNm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|NmPrfx|ISO20022.Acmt001001.NamePrefix1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""PstlAdr""",PstlAdr),validList("""PstlAdr""",PstlAdr),validListMax("""PstlAdr""",PstlAdr,5),validElement(PstlAdr),validElement(NmPrfx))|

---

## Value ISO20022.Acmt001001.IndividualPerson37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GDPRData|global::System.Collections.Generic.List<ISO20022.Acmt001001.GDPRData1>||XmlElement()||
|+|FmlyInf|ISO20022.Acmt001001.PersonalInformation1||XmlElement()||
|+|EdctnLvl|String||XmlElement()||
|+|CvlSts|ISO20022.Acmt001001.CivilStatus1Choice||XmlElement()||
|+|DthDt|DateTime||XmlElement()||
|+|PltclyXpsdPrsn|ISO20022.Acmt001001.PoliticallyExposedPerson1||XmlElement()||
|+|BizFctn|String||XmlElement()||
|+|EmplngCpny|String||XmlElement()||
|+|Ctznsh|global::System.Collections.Generic.List<ISO20022.Acmt001001.CitizenshipInformation2>||XmlElement()||
|+|PstlAdr|global::System.Collections.Generic.List<ISO20022.Acmt001001.PostalAddress21>||XmlElement()||
|+|Prfssn|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|CtryOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
|+|Gndr|String||XmlElement()||
|+|NmSfx|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|MddlNm|String||XmlElement()||
|+|GvnNm|String||XmlElement()||
|+|NmPrfx|ISO20022.Acmt001001.NamePrefix1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""GDPRData""",GDPRData),validElement(GDPRData),validElement(FmlyInf),validElement(CvlSts),validElement(PltclyXpsdPrsn),validList("""Ctznsh""",Ctznsh),validListMax("""Ctznsh""",Ctznsh,3),validElement(Ctznsh),validRequired("""PstlAdr""",PstlAdr),validList("""PstlAdr""",PstlAdr),validListMax("""PstlAdr""",PstlAdr,10),validElement(PstlAdr),validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""),validElement(NmPrfx))|

---

## Value ISO20022.Acmt001001.InformationDistribution1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.InformationDistribution2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PAPR|Int32||XmlEnum("""PAPR""")|1|
||NONE|Int32||XmlEnum("""NONE""")|2|
||ELEC|Int32||XmlEnum("""ELEC""")|3|

---

## Value ISO20022.Acmt001001.InitialAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Acmt001001.ActiveCurrencyAndAmount||XmlElement()||
|+|InitlNbOfInstlmts|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,InitlNbOfInstlmts))|

---

## Enum ISO20022.Acmt001001.Insurance1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PDIS|Int32||XmlEnum("""PDIS""")|1|
||LIFE|Int32||XmlEnum("""LIFE""")|2|

---

## Value ISO20022.Acmt001001.InsuranceType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.Intermediary46


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Acmt001001.NameAndAddress4||XmlElement()||
|+|ScndryComAdr|global::System.Collections.Generic.List<ISO20022.Acmt001001.CommunicationAddress6>||XmlElement()||
|+|PmryComAdr|global::System.Collections.Generic.List<ISO20022.Acmt001001.CommunicationAddress6>||XmlElement()||
|+|Role|ISO20022.Acmt001001.PartyRole2Choice||XmlElement()||
|+|WvdTrlrComssnInd|String||XmlElement()||
|+|Acct|ISO20022.Acmt001001.Account32||XmlElement()||
|+|LglNttyIdr|String||XmlElement()||
|+|Id|ISO20022.Acmt001001.PartyIdentification177Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validList("""ScndryComAdr""",ScndryComAdr),validElement(ScndryComAdr),validList("""PmryComAdr""",PmryComAdr),validElement(PmryComAdr),validElement(Role),validElement(Acct),validPattern("""LglNttyIdr""",LglNttyIdr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Acmt001001.InvestmentAccount73


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FsclYr|ISO20022.Acmt001001.FiscalYear1Choice||XmlElement()||
|+|InvstrPrfl|global::System.Collections.Generic.List<ISO20022.Acmt001001.InvestorProfile2>||XmlElement()||
|+|Lblty|ISO20022.Acmt001001.Liability1Choice||XmlElement()||
|+|PrcgOrdr|String||XmlElement()||
|+|NegInd|String||XmlElement()||
|+|ClsgDt|ISO20022.Acmt001001.DateAndDateTime1Choice||XmlElement()||
|+|OpngDt|ISO20022.Acmt001001.DateAndDateTime1Choice||XmlElement()||
|+|AcctgSts|ISO20022.Acmt001001.AccountingStatus1Choice||XmlElement()||
|+|PwrOfAttnyLvlOfCtrl|ISO20022.Acmt001001.LevelOfControl1Choice||XmlElement()||
|+|ThrdPtyRghts|ISO20022.Acmt001001.ThirdPartyRights2||XmlElement()||
|+|Coll|String||XmlElement()||
|+|Pldgg|String||XmlElement()||
|+|InvstmtAcctCtgy|ISO20022.Acmt001001.InvestmentAccountCategory1Choice||XmlElement()||
|+|TxChanlTp|ISO20022.Acmt001001.TransactionChannelType1Choice||XmlElement()||
|+|AcctSgntrDtTm|ISO20022.Acmt001001.DateAndDateTime1Choice||XmlElement()||
|+|FrgnStsCertfctn|String||XmlElement()||
|+|AcctUsgTp|ISO20022.Acmt001001.AccountUsageType2Choice||XmlElement()||
|+|BlckdSts|ISO20022.Acmt001001.BlockedStatusReason2Choice||XmlElement()||
|+|AcctSvcr|ISO20022.Acmt001001.PartyIdentification125Choice||XmlElement()||
|+|RndgDtls|ISO20022.Acmt001001.RoundingParameters1||XmlElement()||
|+|FinInstrmDtls|global::System.Collections.Generic.List<ISO20022.Acmt001001.FinancialInstrument87>||XmlElement()||
|+|FndFmlyNm|String||XmlElement()||
|+|ReqrdSgntriesNb|Decimal||XmlElement()||
|+|AcmltnRghtRef|String||XmlElement()||
|+|LttrInttDtls|ISO20022.Acmt001001.LetterIntent1||XmlElement()||
|+|TaxRptg|global::System.Collections.Generic.List<ISO20022.Acmt001001.TaxReporting3>||XmlElement()||
|+|TaxWhldgMtd|String||XmlElement()||
|+|RinvstmtDtls|global::System.Collections.Generic.List<ISO20022.Acmt001001.Reinvestment4>||XmlElement()||
|+|IncmPref|String||XmlElement()||
|+|Lang|String||XmlElement()||
|+|RefCcy|String||XmlElement()||
|+|StmtFrqcy|ISO20022.Acmt001001.StatementFrequencyReason2Choice||XmlElement()||
|+|TaxXmptn|ISO20022.Acmt001001.TaxExemptionReason2Choice||XmlElement()||
|+|OwnrshTp|ISO20022.Acmt001001.OwnershipType2Choice||XmlElement()||
|+|Tp|ISO20022.Acmt001001.AccountType2Choice||XmlElement()||
|+|Dsgnt|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FsclYr),validList("""InvstrPrfl""",InvstrPrfl),validElement(InvstrPrfl),validElement(Lblty),validElement(ClsgDt),validElement(OpngDt),validElement(AcctgSts),validElement(PwrOfAttnyLvlOfCtrl),validElement(ThrdPtyRghts),validElement(InvstmtAcctCtgy),validElement(TxChanlTp),validElement(AcctSgntrDtTm),validElement(AcctUsgTp),validElement(BlckdSts),validElement(AcctSvcr),validElement(RndgDtls),validList("""FinInstrmDtls""",FinInstrmDtls),validElement(FinInstrmDtls),validElement(LttrInttDtls),validList("""TaxRptg""",TaxRptg),validElement(TaxRptg),validList("""RinvstmtDtls""",RinvstmtDtls),validElement(RinvstmtDtls),validPattern("""RefCcy""",RefCcy,"""[A-Z]{3,3}"""),validElement(StmtFrqcy),validElement(TaxXmptn),validElement(OwnrshTp),validElement(Tp))|

---

## Value ISO20022.Acmt001001.InvestmentAccountCategory1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.InvestmentAccountCategory1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RETA|Int32||XmlEnum("""RETA""")|1|
||MAND|Int32||XmlEnum("""MAND""")|2|

---

## Value ISO20022.Acmt001001.InvestmentAccountOpening4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ExstgAcctId|global::System.Collections.Generic.List<ISO20022.Acmt001001.Account23>||XmlElement()||
|+|CtrPtyRef|ISO20022.Acmt001001.AdditionalReference13||XmlElement()||
|+|ClntRef|String||XmlElement()||
|+|AcctApplId|String||XmlElement()||
|+|OpngTp|ISO20022.Acmt001001.AccountOpeningType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""ExstgAcctId""",ExstgAcctId),validElement(ExstgAcctId),validElement(CtrPtyRef),validElement(OpngTp))|

---

## Value ISO20022.Acmt001001.InvestmentAccountOwnershipInformation16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrlgPty|String||XmlElement()||
|+|AddtlInf|global::System.Collections.Generic.List<ISO20022.Acmt001001.AdditiononalInformation13>||XmlElement()||
|+|AcctgSts|ISO20022.Acmt001001.AccountingStatus1Choice||XmlElement()||
|+|AddtlRgltryInf|ISO20022.Acmt001001.RegulatoryInformation1||XmlElement()||
|+|ScndryComAdr|global::System.Collections.Generic.List<ISO20022.Acmt001001.CommunicationAddress6>||XmlElement()||
|+|PmryComAdr|global::System.Collections.Generic.List<ISO20022.Acmt001001.CommunicationAddress6>||XmlElement()||
|+|ElctrncMlngSvcRef|String||XmlElement()||
|+|CpnyLk|ISO20022.Acmt001001.CompanyLink1Choice||XmlElement()||
|+|WorkgCptl|ISO20022.Acmt001001.DateAndAmount1||XmlElement()||
|+|EqtyVal|ISO20022.Acmt001001.DateAndAmount1||XmlElement()||
|+|MntryWlth|ISO20022.Acmt001001.DateAndAmount1||XmlElement()||
|+|CtryAndResdtlSts|ISO20022.Acmt001001.CountryAndResidentialStatusType2||XmlElement()||
|+|MailTp|ISO20022.Acmt001001.MailType1Choice||XmlElement()||
|+|Lang|String||XmlElement()||
|+|TaxRptg|global::System.Collections.Generic.List<ISO20022.Acmt001001.TaxReporting3>||XmlElement()||
|+|TaxXmptn|ISO20022.Acmt001001.TaxExemptionReason2Choice||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Acmt001001.GenericIdentification82>||XmlElement()||
|+|CRSRptgDt|DateTime||XmlElement()||
|+|CRSSts|global::System.Collections.Generic.List<ISO20022.Acmt001001.CRSStatus4>||XmlElement()||
|+|CRSFormTp|global::System.Collections.Generic.List<ISO20022.Acmt001001.CRSForm1Choice>||XmlElement()||
|+|FATCARptgDt|DateTime||XmlElement()||
|+|FATCASts|global::System.Collections.Generic.List<ISO20022.Acmt001001.FATCAStatus2>||XmlElement()||
|+|FATCAFormTp|global::System.Collections.Generic.List<ISO20022.Acmt001001.FATCAForm1Choice>||XmlElement()||
|+|Ntfctn|global::System.Collections.Generic.List<ISO20022.Acmt001001.Notification2>||XmlElement()||
|+|MiFIDClssfctn|ISO20022.Acmt001001.MiFIDClassification1||XmlElement()||
|+|SgntryRghtInd|String||XmlElement()||
|+|FsclXmptn|String||XmlElement()||
|+|ClntId|String||XmlElement()||
|+|OwnrshBnfcryRate|ISO20022.Acmt001001.OwnershipBeneficiaryRate1||XmlElement()||
|+|InvstrPrflVldtn|global::System.Collections.Generic.List<ISO20022.Acmt001001.PartyProfileInformation5>||XmlElement()||
|+|MnyLndrgChck|ISO20022.Acmt001001.MoneyLaunderingCheck1Choice||XmlElement()||
|+|Pty|ISO20022.Acmt001001.Party47Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlInf""",AddtlInf),validElement(AddtlInf),validElement(AcctgSts),validElement(AddtlRgltryInf),validList("""ScndryComAdr""",ScndryComAdr),validElement(ScndryComAdr),validList("""PmryComAdr""",PmryComAdr),validElement(PmryComAdr),validElement(CpnyLk),validElement(WorkgCptl),validElement(EqtyVal),validElement(MntryWlth),validElement(CtryAndResdtlSts),validElement(MailTp),validList("""TaxRptg""",TaxRptg),validElement(TaxRptg),validElement(TaxXmptn),validList("""OthrId""",OthrId),validElement(OthrId),validList("""CRSSts""",CRSSts),validElement(CRSSts),validList("""CRSFormTp""",CRSFormTp),validElement(CRSFormTp),validList("""FATCASts""",FATCASts),validElement(FATCASts),validList("""FATCAFormTp""",FATCAFormTp),validElement(FATCAFormTp),validList("""Ntfctn""",Ntfctn),validElement(Ntfctn),validElement(MiFIDClssfctn),validElement(OwnrshBnfcryRate),validList("""InvstrPrflVldtn""",InvstrPrflVldtn),validElement(InvstrPrflVldtn),validElement(MnyLndrgChck),validElement(Pty))|

---

## Value ISO20022.Acmt001001.InvestmentFundOrder4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MstrRef|String||XmlElement()||
|+|OrdrRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Acmt001001.InvestmentFundRole6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAN|Int32||XmlEnum("""TRAN""")|1|
||TRAG|Int32||XmlEnum("""TRAG""")|2|
||REGI|Int32||XmlEnum("""REGI""")|3|
||PAYI|Int32||XmlEnum("""PAYI""")|4|
||INVS|Int32||XmlEnum("""INVS""")|5|
||INVE|Int32||XmlEnum("""INVE""")|6|
||INTR|Int32||XmlEnum("""INTR""")|7|
||FTAG|Int32||XmlEnum("""FTAG""")|8|
||FNBR|Int32||XmlEnum("""FNBR""")|9|
||FMCO|Int32||XmlEnum("""FMCO""")|10|
||FIAG|Int32||XmlEnum("""FIAG""")|11|
||FIAD|Int32||XmlEnum("""FIAD""")|12|
||FACT|Int32||XmlEnum("""FACT""")|13|
||DIST|Int32||XmlEnum("""DIST""")|14|
||DATP|Int32||XmlEnum("""DATP""")|15|
||CUST|Int32||XmlEnum("""CUST""")|16|
||CONC|Int32||XmlEnum("""CONC""")|17|
||CACO|Int32||XmlEnum("""CACO""")|18|

---

## Enum ISO20022.Acmt001001.InvestmentFundRole7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INVS|Int32||XmlEnum("""INVS""")|1|
||INVE|Int32||XmlEnum("""INVE""")|2|
||FACT|Int32||XmlEnum("""FACT""")|3|
||CACO|Int32||XmlEnum("""CACO""")|4|
||CUST|Int32||XmlEnum("""CUST""")|5|
||TRAG|Int32||XmlEnum("""TRAG""")|6|
||PAYI|Int32||XmlEnum("""PAYI""")|7|
||INTR|Int32||XmlEnum("""INTR""")|8|
||FMCO|Int32||XmlEnum("""FMCO""")|9|
||DIST|Int32||XmlEnum("""DIST""")|10|
||CONC|Int32||XmlEnum("""CONC""")|11|

---

## Enum ISO20022.Acmt001001.InvestmentFundTransactionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUAA|Int32||XmlEnum("""SUAA""")|1|
||SSPL|Int32||XmlEnum("""SSPL""")|2|
||RDIV|Int32||XmlEnum("""RDIV""")|3|
||RWPL|Int32||XmlEnum("""RWPL""")|4|
||REAA|Int32||XmlEnum("""REAA""")|5|
||OTHR|Int32||XmlEnum("""OTHR""")|6|
||INSP|Int32||XmlEnum("""INSP""")|7|
||DIVI|Int32||XmlEnum("""DIVI""")|8|
||CROO|Int32||XmlEnum("""CROO""")|9|
||CROI|Int32||XmlEnum("""CROI""")|10|
||CAEV|Int32||XmlEnum("""CAEV""")|11|
||DIVP|Int32||XmlEnum("""DIVP""")|12|
||CWIT|Int32||XmlEnum("""CWIT""")|13|
||CDEP|Int32||XmlEnum("""CDEP""")|14|
||REDM|Int32||XmlEnum("""REDM""")|15|
||SUBS|Int32||XmlEnum("""SUBS""")|16|
||TOUT|Int32||XmlEnum("""TOUT""")|17|
||TRIN|Int32||XmlEnum("""TRIN""")|18|
||SWIO|Int32||XmlEnum("""SWIO""")|19|
||BUYI|Int32||XmlEnum("""BUYI""")|20|
||SELL|Int32||XmlEnum("""SELL""")|21|
||ALLL|Int32||XmlEnum("""ALLL""")|22|

---

## Value ISO20022.Acmt001001.InvestmentPlan17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstlmtMgrRole|ISO20022.Acmt001001.PartyRole4Choice||XmlElement()||
|+|PlanSts|ISO20022.Acmt001001.PlanStatus2Choice||XmlElement()||
|+|InsrncCover|ISO20022.Acmt001001.InsuranceType2Choice||XmlElement()||
|+|SLAChrgAndComssnRef|String||XmlElement()||
|+|PdctId|String||XmlElement()||
|+|RltdCtrctRef|String||XmlElement()||
|+|CtrctRef|String||XmlElement()||
|+|CshSttlm|global::System.Collections.Generic.List<ISO20022.Acmt001001.CashSettlement3>||XmlElement()||
|+|SctyDtls|global::System.Collections.Generic.List<ISO20022.Acmt001001.Repartition6>||XmlElement()||
|+|RndgDrctn|String||XmlElement()||
|+|TtlNbOfInstlmts|Decimal||XmlElement()||
|+|InitlAmt|ISO20022.Acmt001001.InitialAmount1Choice||XmlElement()||
|+|IncmPref|String||XmlElement()||
|+|GrssAmtInd|String||XmlElement()||
|+|Qty|ISO20022.Acmt001001.UnitsOrAmount1Choice||XmlElement()||
|+|EndDt|DateTime||XmlElement()||
|+|StartDt|DateTime||XmlElement()||
|+|Frqcy|ISO20022.Acmt001001.Frequency20Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstlmtMgrRole),validElement(PlanSts),validElement(InsrncCover),validList("""CshSttlm""",CshSttlm),validListMax("""CshSttlm""",CshSttlm,8),validElement(CshSttlm),validRequired("""SctyDtls""",SctyDtls),validList("""SctyDtls""",SctyDtls),validListMax("""SctyDtls""",SctyDtls,50),validElement(SctyDtls),validElement(InitlAmt),validElement(Qty),validElement(Frqcy))|

---

## Value ISO20022.Acmt001001.InvestorProfile2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktMakr|ISO20022.Acmt001001.MarketMakerProfile2||XmlElement()||
|+|HghFrqcyTradg|ISO20022.Acmt001001.HighFrequencyTradingProfile1||XmlElement()||
|+|Trsr|ISO20022.Acmt001001.TreasuryProfile1||XmlElement()||
|+|Sts|ISO20022.Acmt001001.InvestorProfileStatus1Choice||XmlElement()||
|+|Tp|ISO20022.Acmt001001.ProfileType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktMakr),validElement(HghFrqcyTradg),validElement(Trsr),validElement(Sts),validElement(Tp))|

---

## Value ISO20022.Acmt001001.InvestorProfileStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.InvestorProfileStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUPS|Int32||XmlEnum("""SUPS""")|1|
||PEND|Int32||XmlEnum("""PEND""")|2|
||PSUS|Int32||XmlEnum("""PSUS""")|3|
||NAPP|Int32||XmlEnum("""NAPP""")|4|
||ANLY|Int32||XmlEnum("""ANLY""")|5|
||ADMI|Int32||XmlEnum("""ADMI""")|6|
||ENBG|Int32||XmlEnum("""ENBG""")|7|
||ENAB|Int32||XmlEnum("""ENAB""")|8|
||DISG|Int32||XmlEnum("""DISG""")|9|
||DISA|Int32||XmlEnum("""DISA""")|10|

---

## Value ISO20022.Acmt001001.KYCCheckType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.KnowYourCustomerCheckType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SIMP|Int32||XmlEnum("""SIMP""")|1|
||ORDN|Int32||XmlEnum("""ORDN""")|2|
||ENHA|Int32||XmlEnum("""ENHA""")|3|

---

## Value ISO20022.Acmt001001.LetterIntent1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EndDt|DateTime||XmlElement()||
|+|StartDt|DateTime||XmlElement()||
|+|Amt|ISO20022.Acmt001001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|LttrInttRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Acmt001001.LevelOfControl1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.LevelOfControl1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VIEW|Int32||XmlEnum("""VIEW""")|1|
||TRAN|Int32||XmlEnum("""TRAN""")|2|

---

## Value ISO20022.Acmt001001.Liability1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.Liability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BROK|Int32||XmlEnum("""BROK""")|1|
||INVE|Int32||XmlEnum("""INVE""")|2|

---

## Value ISO20022.Acmt001001.MailType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.MailType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGM|Int32||XmlEnum("""REGM""")|1|
||ORDM|Int32||XmlEnum("""ORDM""")|2|
||AIRM|Int32||XmlEnum("""AIRM""")|3|

---

## Value ISO20022.Acmt001001.MarketMakerProfile2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dscnt|Decimal||XmlElement()||
|+|MaxSprd|Decimal||XmlElement()||
|+|Cmplc|String||XmlElement()||
|+|CtrctPrd|ISO20022.Acmt001001.DateTimePeriod2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrctPrd))|

---

## Value ISO20022.Acmt001001.MarketPracticeVersion1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nb|String||XmlElement()||
|+|Dt|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt001001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt001001.MiFIDClassification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nrrtv|String||XmlElement()||
|+|Clssfctn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt001001.MoneyLaunderingCheck1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.MoneyLaunderingCheck1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POEP|Int32||XmlEnum("""POEP""")|1|
||AUTH|Int32||XmlEnum("""AUTH""")|2|
||CLMO|Int32||XmlEnum("""CLMO""")|3|
||EXEM|Int32||XmlEnum("""EXEM""")|4|
||NOTC|Int32||XmlEnum("""NOTC""")|5|
||PASS|Int32||XmlEnum("""PASS""")|6|

---

## Value ISO20022.Acmt001001.NameAndAddress4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Acmt001001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Acmt001001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Acmt001001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Acmt001001.NamePrefix1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.NamePrefix1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MADM|Int32||XmlEnum("""MADM""")|1|
||MISS|Int32||XmlEnum("""MISS""")|2|
||MIST|Int32||XmlEnum("""MIST""")|3|
||DOCT|Int32||XmlEnum("""DOCT""")|4|

---

## Value ISO20022.Acmt001001.NewIssueAllocation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DeMnms|ISO20022.Acmt001001.DeMinimus1Choice||XmlElement()||
|+|XmptPrsnRsn|String||XmlElement()||
|+|Rstrctd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DeMnms))|

---

## Enum ISO20022.Acmt001001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Acmt001001.Notification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DstrbtnTp|ISO20022.Acmt001001.InformationDistribution1Choice||XmlElement()||
|+|Reqrd|String||XmlElement()||
|+|NtfctnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DstrbtnTp))|

---

## Enum ISO20022.Acmt001001.OperationalStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SPEC|Int32||XmlEnum("""SPEC""")|1|
||ENAB|Int32||XmlEnum("""ENAB""")|2|

---

## Enum ISO20022.Acmt001001.OrderOriginatorEligibility1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROF|Int32||XmlEnum("""PROF""")|1|
||RETL|Int32||XmlEnum("""RETL""")|2|
||ELIG|Int32||XmlEnum("""ELIG""")|3|

---

## Value ISO20022.Acmt001001.Organisation23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|global::System.Collections.Generic.List<ISO20022.Acmt001001.PostalAddress21>||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""PstlAdr""",PstlAdr),validList("""PstlAdr""",PstlAdr),validListMax("""PstlAdr""",PstlAdr,5),validElement(PstlAdr))|

---

## Value ISO20022.Acmt001001.Organisation39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PlcOfListg|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TpOfOrg|ISO20022.Acmt001001.OrganisationType1Choice||XmlElement()||
|+|PstlAdr|global::System.Collections.Generic.List<ISO20022.Acmt001001.PostalAddress21>||XmlElement()||
|+|RegnDt|DateTime||XmlElement()||
|+|RegnCtry|String||XmlElement()||
|+|Purp|String||XmlElement()||
|+|LglNttyIdr|String||XmlElement()||
|+|Id|ISO20022.Acmt001001.PartyIdentification177Choice||XmlElement()||
|+|ShrtNm|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PlcOfListg""",PlcOfListg,"""[A-Z0-9]{4,4}"""),validElement(TpOfOrg),validList("""PstlAdr""",PstlAdr),validListMax("""PstlAdr""",PstlAdr,10),validElement(PstlAdr),validPattern("""RegnCtry""",RegnCtry,"""[A-Z]{2,2}"""),validPattern("""LglNttyIdr""",LglNttyIdr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Acmt001001.OrganisationType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.OrganisationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PFUN|Int32||XmlEnum("""PFUN""")|1|
||PUBL|Int32||XmlEnum("""PUBL""")|2|
||PRIV|Int32||XmlEnum("""PRIV""")|3|
||IFUN|Int32||XmlEnum("""IFUN""")|4|

---

## Value ISO20022.Acmt001001.OtherIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.OwnershipBeneficiaryRate1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Frctn|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt001001.OwnershipType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.Party47Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndvPrsn|ISO20022.Acmt001001.IndividualPerson37||XmlElement()||
|+|Org|ISO20022.Acmt001001.Organisation39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IndvPrsn),validElement(Org),validChoice(IndvPrsn,Org))|

---

## Value ISO20022.Acmt001001.PartyIdentification125Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Acmt001001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Acmt001001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Acmt001001.PartyIdentification177Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Acmt001001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Enum ISO20022.Acmt001001.PartyIdentificationType7Code


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

## Value ISO20022.Acmt001001.PartyProfileInformation5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|KnowYourCstmrDBChck|ISO20022.Acmt001001.DataBaseCheck1||XmlElement()||
|+|KnowYourCstmrChckTp|ISO20022.Acmt001001.KYCCheckType1Choice||XmlElement()||
|+|RskLvl|ISO20022.Acmt001001.RiskLevel2Choice||XmlElement()||
|+|CstmrCndctClssfctn|ISO20022.Acmt001001.CustomerConductClassification1Choice||XmlElement()||
|+|SrcOfWlth|String||XmlElement()||
|+|SlryRg|String||XmlElement()||
|+|NxtRvsnDt|DateTime||XmlElement()||
|+|ChckngFrqcy|String||XmlElement()||
|+|ChckngDt|DateTime||XmlElement()||
|+|CertTp|ISO20022.Acmt001001.CertificationType1Choice||XmlElement()||
|+|RspnsblPty|String||XmlElement()||
|+|ChckngPty|String||XmlElement()||
|+|VldtngPty|String||XmlElement()||
|+|CertfctnInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(KnowYourCstmrDBChck),validElement(KnowYourCstmrChckTp),validElement(RskLvl),validElement(CstmrCndctClssfctn),validElement(CertTp))|

---

## Enum ISO20022.Acmt001001.PartyRole1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INVS|Int32||XmlEnum("""INVS""")|1|
||CUST|Int32||XmlEnum("""CUST""")|2|

---

## Value ISO20022.Acmt001001.PartyRole2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.PartyRole4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.PartyRole5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.PaymentCard29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SeqNb|String||XmlElement()||
|+|SctyCd|String||XmlElement()||
|+|CardIssrId|ISO20022.Acmt001001.PartyIdentification125Choice||XmlElement()||
|+|CardIssrNm|String||XmlElement()||
|+|XpryDt|String||XmlElement()||
|+|StartDt|String||XmlElement()||
|+|HldrNm|String||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CardIssrId))|

---

## Value ISO20022.Acmt001001.PaymentInstrument17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntrstPmtInstrm|ISO20022.Acmt001001.PaymentInstrument19Choice||XmlElement()||
|+|SvgsPlanPmtInstrm|ISO20022.Acmt001001.PaymentInstrument24Choice||XmlElement()||
|+|DvddPmtInstrm|ISO20022.Acmt001001.PaymentInstrument19Choice||XmlElement()||
|+|RedPmtInstrm|ISO20022.Acmt001001.PaymentInstrument19Choice||XmlElement()||
|+|SbcptPmtInstrm|ISO20022.Acmt001001.PaymentInstrument24Choice||XmlElement()||
|+|DvddPctg|Decimal||XmlElement()||
|+|SttlmCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntrstPmtInstrm),validElement(SvgsPlanPmtInstrm),validElement(DvddPmtInstrm),validElement(RedPmtInstrm),validElement(SbcptPmtInstrm),validPattern("""SttlmCcy""",SttlmCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Acmt001001.PaymentInstrument19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BkrsDrftDtls|ISO20022.Acmt001001.Cheque4||XmlElement()||
|+|ChqDtls|ISO20022.Acmt001001.Cheque4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BkrsDrftDtls),validElement(ChqDtls),validChoice(BkrsDrftDtls,ChqDtls))|

---

## Value ISO20022.Acmt001001.PaymentInstrument24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BkrsDrft|String||XmlElement()||
|+|Chq|String||XmlElement()||
|+|DrctDbtDtls|ISO20022.Acmt001001.DirectDebitMandate7||XmlElement()||
|+|PmtCardDtls|ISO20022.Acmt001001.PaymentCard29||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DrctDbtDtls),validElement(PmtCardDtls),validChoice(BkrsDrft,Chq,DrctDbtDtls,PmtCardDtls))|

---

## Value ISO20022.Acmt001001.PersonalInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmOfPrtnr|String||XmlElement()||
|+|MdnNmOfMthr|String||XmlElement()||
|+|NmOfFthr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Acmt001001.PlanStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUSP|Int32||XmlEnum("""SUSP""")|1|
||CLOS|Int32||XmlEnum("""CLOS""")|2|
||ACTV|Int32||XmlEnum("""ACTV""")|3|

---

## Value ISO20022.Acmt001001.PlanStatus2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.PoliticalExposureType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.PoliticalExposureType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PEXF|Int32||XmlEnum("""PEXF""")|1|
||PEXD|Int32||XmlEnum("""PEXD""")|2|
||YPEX|Int32||XmlEnum("""YPEX""")|3|
||NPEX|Int32||XmlEnum("""NPEX""")|4|

---

## Value ISO20022.Acmt001001.PoliticallyExposedPerson1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PltclyXpsdPrsnSts|ISO20022.Acmt001001.PoliticallyExposedPersonStatus1Choice||XmlElement()||
|+|PltclyXpsdPrsnTp|ISO20022.Acmt001001.PoliticalExposureType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PltclyXpsdPrsnSts),validElement(PltclyXpsdPrsnTp))|

---

## Value ISO20022.Acmt001001.PoliticallyExposedPersonStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.PoliticallyExposedPersonStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PE02|Int32||XmlEnum("""PE02""")|1|
||PE01|Int32||XmlEnum("""PE01""")|2|
||PE03|Int32||XmlEnum("""PE03""")|3|

---

## Enum ISO20022.Acmt001001.PositionEffect3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LIFO|Int32||XmlEnum("""LIFO""")|1|
||FIFO|Int32||XmlEnum("""FIFO""")|2|

---

## Value ISO20022.Acmt001001.PostalAddress1


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

## Value ISO20022.Acmt001001.PostalAddress21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Stat|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|Vllg|String||XmlElement()||
|+|DstrctNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|SuiteId|String||XmlElement()||
|+|Flr|String||XmlElement()||
|+|SdInBldg|String||XmlElement()||
|+|PstBx|String||XmlElement()||
|+|BldgNm|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CareOf|String||XmlElement()||
|+|RegnAdrInd|String||XmlElement()||
|+|MlngInd|String||XmlElement()||
|+|AdrTp|ISO20022.Acmt001001.AddressType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validListMax("""AdrLine""",AdrLine,5),validElement(AdrTp))|

---

## Value ISO20022.Acmt001001.ProfileType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.ProfileType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TREA|Int32||XmlEnum("""TREA""")|1|
||MAKE|Int32||XmlEnum("""MAKE""")|2|
||HFTR|Int32||XmlEnum("""HFTR""")|3|
||HEDG|Int32||XmlEnum("""HEDG""")|4|

---

## Enum ISO20022.Acmt001001.Provided1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROV|Int32||XmlEnum("""PROV""")|1|
||NPRO|Int32||XmlEnum("""NPRO""")|2|

---

## Enum ISO20022.Acmt001001.Rank1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SECO|Int32||XmlEnum("""SECO""")|1|
||PRIM|Int32||XmlEnum("""PRIM""")|2|

---

## Enum ISO20022.Acmt001001.Referred1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKNW|Int32||XmlEnum("""UKNW""")|1|
||NRFR|Int32||XmlEnum("""NRFR""")|2|
||REFR|Int32||XmlEnum("""REFR""")|3|

---

## Value ISO20022.Acmt001001.ReferredAgent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RfrdPlcmntAgt|ISO20022.Acmt001001.PartyIdentification125Choice||XmlElement()||
|+|Rfrd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RfrdPlcmntAgt))|

---

## Value ISO20022.Acmt001001.RegisteredShareholderName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Org|ISO20022.Acmt001001.Organisation23||XmlElement()||
|+|IndvPrsn|ISO20022.Acmt001001.IndividualPerson29||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Org),validElement(IndvPrsn),validChoice(Org,IndvPrsn))|

---

## Value ISO20022.Acmt001001.RegulatoryInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|String||XmlElement()||
|+|Grp|String||XmlElement()||
|+|Brnch|String||XmlElement()||
|+|Sctr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt001001.Reinvestment4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RinvstmtPctg|Decimal||XmlElement()||
|+|ReqdNAVCcy|String||XmlElement()||
|+|FinInstrmDtls|ISO20022.Acmt001001.FinancialInstrument87||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ReqdNAVCcy""",ReqdNAVCcy,"""[A-Z]{3,3}"""),validElement(FinInstrmDtls))|

---

## Value ISO20022.Acmt001001.Repartition6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyOfPlan|String||XmlElement()||
|+|FinInstrm|ISO20022.Acmt001001.FinancialInstrument87||XmlElement()||
|+|Qty|ISO20022.Acmt001001.UnitsOrAmountOrPercentage1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CcyOfPlan""",CcyOfPlan,"""[A-Z]{3,3}"""),validElement(FinInstrm),validElement(Qty))|

---

## Enum ISO20022.Acmt001001.ResidentialStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NRES|Int32||XmlEnum("""NRES""")|1|
||PRES|Int32||XmlEnum("""PRES""")|2|
||RESI|Int32||XmlEnum("""RESI""")|3|

---

## Value ISO20022.Acmt001001.RestrictionStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.RestrictionStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INAC|Int32||XmlEnum("""INAC""")|1|
||ACTV|Int32||XmlEnum("""ACTV""")|2|

---

## Enum ISO20022.Acmt001001.RiskLevel1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MEDM|Int32||XmlEnum("""MEDM""")|1|
||LOWW|Int32||XmlEnum("""LOWW""")|2|
||HIGH|Int32||XmlEnum("""HIGH""")|3|

---

## Value ISO20022.Acmt001001.RiskLevel2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.RoundingDirection1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIST|Int32||XmlEnum("""DIST""")|1|
||STAN|Int32||XmlEnum("""STAN""")|2|
||RDWN|Int32||XmlEnum("""RDWN""")|3|
||RDUP|Int32||XmlEnum("""RDUP""")|4|

---

## Value ISO20022.Acmt001001.RoundingParameters1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RndgDrctn|String||XmlElement()||
|+|RndgMdlus|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt001001.SecurityIdentification25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrPrtryId|ISO20022.Acmt001001.AlternateSecurityIdentification7||XmlElement()||
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

## Value ISO20022.Acmt001001.SettlementFrequency1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.SettlementInstructionReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.SettlementInstructionReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CORP|Int32||XmlEnum("""CORP""")|1|
||WTHP|Int32||XmlEnum("""WTHP""")|2|
||SUBS|Int32||XmlEnum("""SUBS""")|3|
||SELL|Int32||XmlEnum("""SELL""")|4|
||BUYI|Int32||XmlEnum("""BUYI""")|5|
||SAVE|Int32||XmlEnum("""SAVE""")|6|
||REDM|Int32||XmlEnum("""REDM""")|7|
||SAVP|Int32||XmlEnum("""SAVP""")|8|
||INTE|Int32||XmlEnum("""INTE""")|9|
||DIVI|Int32||XmlEnum("""DIVI""")|10|
||CHAR|Int32||XmlEnum("""CHAR""")|11|
||CSHO|Int32||XmlEnum("""CSHO""")|12|
||ALLL|Int32||XmlEnum("""ALLL""")|13|
||CSHI|Int32||XmlEnum("""CSHI""")|14|

---

## Value ISO20022.Acmt001001.SimpleIdentificationInformation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt001001.StatementFrequencyReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt001001.TaxExemptReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OANR|Int32||XmlEnum("""OANR""")|1|
||TANR|Int32||XmlEnum("""TANR""")|2|
||ADMI|Int32||XmlEnum("""ADMI""")|3|
||RIHO|Int32||XmlEnum("""RIHO""")|4|
||REFU|Int32||XmlEnum("""REFU""")|5|
||PENF|Int32||XmlEnum("""PENF""")|6|
||ORDR|Int32||XmlEnum("""ORDR""")|7|
||FORP|Int32||XmlEnum("""FORP""")|8|
||DOME|Int32||XmlEnum("""DOME""")|9|
||DIPL|Int32||XmlEnum("""DIPL""")|10|
||ASSO|Int32||XmlEnum("""ASSO""")|11|
||MINO|Int32||XmlEnum("""MINO""")|12|
||INCA|Int32||XmlEnum("""INCA""")|13|
||FORE|Int32||XmlEnum("""FORE""")|14|
||EIOP|Int32||XmlEnum("""EIOP""")|15|
||EIFP|Int32||XmlEnum("""EIFP""")|16|
||RCIP|Int32||XmlEnum("""RCIP""")|17|
||RCRF|Int32||XmlEnum("""RCRF""")|18|
||RIAN|Int32||XmlEnum("""RIAN""")|19|
||RIRA|Int32||XmlEnum("""RIRA""")|20|
||E457X|Int32||XmlEnum("""457X""")|21|
||E403B|Int32||XmlEnum("""403B""")|22|
||SIRA|Int32||XmlEnum("""SIRA""")|23|
||E401K|Int32||XmlEnum("""401K""")|24|
||PFSP|Int32||XmlEnum("""PFSP""")|25|
||KEOG|Int32||XmlEnum("""KEOG""")|26|
||IRAR|Int32||XmlEnum("""IRAR""")|27|
||IRAC|Int32||XmlEnum("""IRAC""")|28|
||DECP|Int32||XmlEnum("""DECP""")|29|
||NFQP|Int32||XmlEnum("""NFQP""")|30|
||NFPI|Int32||XmlEnum("""NFPI""")|31|
||ECYE|Int32||XmlEnum("""ECYE""")|32|
||EPRY|Int32||XmlEnum("""EPRY""")|33|
||EMCY|Int32||XmlEnum("""EMCY""")|34|
||EMPY|Int32||XmlEnum("""EMPY""")|35|
||ASTR|Int32||XmlEnum("""ASTR""")|36|
||PRYP|Int32||XmlEnum("""PRYP""")|37|
||CUYP|Int32||XmlEnum("""CUYP""")|38|
||IISA|Int32||XmlEnum("""IISA""")|39|
||SISA|Int32||XmlEnum("""SISA""")|40|
||MISA|Int32||XmlEnum("""MISA""")|41|
||MASA|Int32||XmlEnum("""MASA""")|42|
||NONE|Int32||XmlEnum("""NONE""")|43|

---

## Value ISO20022.Acmt001001.TaxExemptionReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.TaxReporting3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|CshAcctDtls|ISO20022.Acmt001001.CashAccount204||XmlElement()||
|+|TaxRcpt|ISO20022.Acmt001001.PartyIdentification125Choice||XmlElement()||
|+|TaxPyer|ISO20022.Acmt001001.PartyIdentification125Choice||XmlElement()||
|+|TaxRate|Decimal||XmlElement()||
|+|TaxtnCtry|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshAcctDtls),validElement(TaxRcpt),validElement(TaxPyer),validPattern("""TaxtnCtry""",TaxtnCtry,"""[A-Z]{2,2}"""))|

---

## Enum ISO20022.Acmt001001.TaxWithholdingMethod3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WTRE|Int32||XmlEnum("""WTRE""")|1|
||WTHD|Int32||XmlEnum("""WTHD""")|2|
||WHCO|Int32||XmlEnum("""WHCO""")|3|
||CRTF|Int32||XmlEnum("""CRTF""")|4|
||REPT|Int32||XmlEnum("""REPT""")|5|
||EXMT|Int32||XmlEnum("""EXMT""")|6|
||ACCT|Int32||XmlEnum("""ACCT""")|7|
||INVE|Int32||XmlEnum("""INVE""")|8|
||MITX|Int32||XmlEnum("""MITX""")|9|

---

## Value ISO20022.Acmt001001.ThirdPartyRights2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|Amt|ISO20022.Acmt001001.ActiveCurrencyAndAmount||XmlElement()||
|+|LglNttyIdr|String||XmlElement()||
|+|Hldr|ISO20022.Acmt001001.PartyIdentification125Choice||XmlElement()||
|+|DtTm|DateTime||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validPattern("""LglNttyIdr""",LglNttyIdr,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Hldr))|

---

## Enum ISO20022.Acmt001001.TransactionChannel2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BRAN|Int32||XmlEnum("""BRAN""")|1|
||HOBA|Int32||XmlEnum("""HOBA""")|2|
||FIAD|Int32||XmlEnum("""FIAD""")|3|

---

## Value ISO20022.Acmt001001.TransactionChannelType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.TransactionType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt001001.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt001001.TreasuryProfile1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|TradrTp|ISO20022.Acmt001001.PartyRole5Choice||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TradrTp))|

---

## Value ISO20022.Acmt001001.UnitsOrAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Unit|Decimal||XmlElement()||
|+|Amt|ISO20022.Acmt001001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Unit,Amt))|

---

## Value ISO20022.Acmt001001.UnitsOrAmountOrPercentage1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pctg|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
|+|Amt|ISO20022.Acmt001001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Pctg,Unit,Amt))|

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

