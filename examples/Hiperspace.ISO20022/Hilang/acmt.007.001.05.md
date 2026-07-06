# acmt.007.001.05
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Acmt007001.AccountContract2 {
        + UrgcyFlg  : String
        + TrgtClsgDt  : DateTime
        + TrgtGoLiveDt  : DateTime
    }
    class ISO20022.Acmt007001.AccountIdentification4Choice {
        + Othr  : ISO20022.Acmt007001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Acmt007001.AccountIdentification4Choice *-- ISO20022.Acmt007001.GenericAccountIdentification1
    class ISO20022.Acmt007001.AccountOpeningRequestV05 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Acmt007001.SupplementaryData1~
        + DgtlSgntr  : global::System.Collections.Generic.List~ISO20022.Acmt007001.PartyAndSignature4~
        + RefAcct  : ISO20022.Acmt007001.CashAccount40
        + Grp  : global::System.Collections.Generic.List~ISO20022.Acmt007001.Group6~
        + Mndt  : global::System.Collections.Generic.List~ISO20022.Acmt007001.OperationMandate7~
        + Org  : ISO20022.Acmt007001.Organisation42
        + AcctSvcrId  : ISO20022.Acmt007001.BranchAndFinancialInstitutionIdentification8
        + UndrlygMstrAgrmt  : ISO20022.Acmt007001.ContractDocument1
        + CtrctDts  : ISO20022.Acmt007001.AccountContract2
        + Acct  : ISO20022.Acmt007001.CustomerAccount4
        + Fr  : ISO20022.Acmt007001.OrganisationIdentification39
        + Refs  : ISO20022.Acmt007001.References4
    }
    ISO20022.Acmt007001.AccountOpeningRequestV05 *-- ISO20022.Acmt007001.SupplementaryData1
    ISO20022.Acmt007001.AccountOpeningRequestV05 *-- ISO20022.Acmt007001.PartyAndSignature4
    ISO20022.Acmt007001.AccountOpeningRequestV05 *-- ISO20022.Acmt007001.CashAccount40
    ISO20022.Acmt007001.AccountOpeningRequestV05 *-- ISO20022.Acmt007001.Group6
    ISO20022.Acmt007001.AccountOpeningRequestV05 *-- ISO20022.Acmt007001.OperationMandate7
    ISO20022.Acmt007001.AccountOpeningRequestV05 *-- ISO20022.Acmt007001.Organisation42
    ISO20022.Acmt007001.AccountOpeningRequestV05 *-- ISO20022.Acmt007001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Acmt007001.AccountOpeningRequestV05 *-- ISO20022.Acmt007001.ContractDocument1
    ISO20022.Acmt007001.AccountOpeningRequestV05 *-- ISO20022.Acmt007001.AccountContract2
    ISO20022.Acmt007001.AccountOpeningRequestV05 *-- ISO20022.Acmt007001.CustomerAccount4
    ISO20022.Acmt007001.AccountOpeningRequestV05 *-- ISO20022.Acmt007001.OrganisationIdentification39
    ISO20022.Acmt007001.AccountOpeningRequestV05 *-- ISO20022.Acmt007001.References4
    class ISO20022.Acmt007001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt007001.AccountStatus3Code {
        FORM = 1
        DELE = 2
        DISA = 3
        ENAB = 4
    }
    class ISO20022.Acmt007001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Acmt007001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Acmt007001.AddressType3Choice {
        + Prtry  : ISO20022.Acmt007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Acmt007001.AddressType3Choice *-- ISO20022.Acmt007001.GenericIdentification30
    class ISO20022.Acmt007001.Authorisation2 {
        + MaxAmtByBlkSubmissn  : ISO20022.Acmt007001.FixedAmountOrUnlimited1Choice
        + MaxAmtByPrd  : global::System.Collections.Generic.List~ISO20022.Acmt007001.MaximumAmountByPeriod1~
        + MaxAmtByTx  : ISO20022.Acmt007001.FixedAmountOrUnlimited1Choice
    }
    ISO20022.Acmt007001.Authorisation2 *-- ISO20022.Acmt007001.FixedAmountOrUnlimited1Choice
    ISO20022.Acmt007001.Authorisation2 *-- ISO20022.Acmt007001.MaximumAmountByPeriod1
    ISO20022.Acmt007001.Authorisation2 *-- ISO20022.Acmt007001.FixedAmountOrUnlimited1Choice
    class ISO20022.Acmt007001.BankTransactionCodeStructure4 {
        + Prtry  : ISO20022.Acmt007001.ProprietaryBankTransactionCodeStructure1
        + Domn  : ISO20022.Acmt007001.BankTransactionCodeStructure5
    }
    ISO20022.Acmt007001.BankTransactionCodeStructure4 *-- ISO20022.Acmt007001.ProprietaryBankTransactionCodeStructure1
    ISO20022.Acmt007001.BankTransactionCodeStructure4 *-- ISO20022.Acmt007001.BankTransactionCodeStructure5
    class ISO20022.Acmt007001.BankTransactionCodeStructure5 {
        + Fmly  : ISO20022.Acmt007001.BankTransactionCodeStructure6
        + Cd  : String
    }
    ISO20022.Acmt007001.BankTransactionCodeStructure5 *-- ISO20022.Acmt007001.BankTransactionCodeStructure6
    class ISO20022.Acmt007001.BankTransactionCodeStructure6 {
        + SubFmlyCd  : String
        + Cd  : String
    }
    class ISO20022.Acmt007001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Acmt007001.BranchData5
        + FinInstnId  : ISO20022.Acmt007001.FinancialInstitutionIdentification23
    }
    ISO20022.Acmt007001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Acmt007001.BranchData5
    ISO20022.Acmt007001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Acmt007001.FinancialInstitutionIdentification23
    class ISO20022.Acmt007001.BranchData5 {
        + PstlAdr  : ISO20022.Acmt007001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Acmt007001.BranchData5 *-- ISO20022.Acmt007001.PostalAddress27
    class ISO20022.Acmt007001.CashAccount40 {
        + Prxy  : ISO20022.Acmt007001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Acmt007001.CashAccountType2Choice
        + Id  : ISO20022.Acmt007001.AccountIdentification4Choice
    }
    ISO20022.Acmt007001.CashAccount40 *-- ISO20022.Acmt007001.ProxyAccountIdentification1
    ISO20022.Acmt007001.CashAccount40 *-- ISO20022.Acmt007001.CashAccountType2Choice
    ISO20022.Acmt007001.CashAccount40 *-- ISO20022.Acmt007001.AccountIdentification4Choice
    class ISO20022.Acmt007001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt007001.Channel2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt007001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt007001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Acmt007001.ClearingSystemIdentification2Choice
    }
    ISO20022.Acmt007001.ClearingSystemMemberIdentification2 *-- ISO20022.Acmt007001.ClearingSystemIdentification2Choice
    class ISO20022.Acmt007001.CodeOrProprietary1Choice {
        + Prtry  : ISO20022.Acmt007001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Acmt007001.CodeOrProprietary1Choice *-- ISO20022.Acmt007001.GenericIdentification13
    class ISO20022.Acmt007001.CommunicationFormat1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt007001.CommunicationMethod2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt007001.CommunicationMethod2Code {
        POST = 1
        ONLI = 2
        FILE = 3
        FAXI = 4
        EMAL = 5
    }
    class ISO20022.Acmt007001.CommunicationMethod3Code {
        ONLI = 1
        FILE = 2
        PHON = 3
        POST = 4
        FAXI = 5
        EMAL = 6
    }
    class ISO20022.Acmt007001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt007001.OtherContact1~
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
    ISO20022.Acmt007001.Contact13 *-- ISO20022.Acmt007001.OtherContact1
    class ISO20022.Acmt007001.ContractDocument1 {
        + Vrsn  : String
        + SgnOffDt  : DateTime
        + Ref  : String
    }
    class ISO20022.Acmt007001.CustomerAccount4 {
        + Rstrctn  : global::System.Collections.Generic.List~ISO20022.Acmt007001.Restriction1~
        + ClsgDt  : DateTime
        + StmtFrqcyAndFrmt  : global::System.Collections.Generic.List~ISO20022.Acmt007001.StatementFrequencyAndForm1~
        + ClngNtfctnAmt  : Decimal
        + FlrNtfctnAmt  : Decimal
        + AcctPurp  : String
        + AvrgBal  : Decimal
        + MnthlyTxNb  : String
        + MnthlyRcvdVal  : Decimal
        + MnthlyPmtVal  : Decimal
        + Ccy  : String
        + Tp  : ISO20022.Acmt007001.CashAccountType2Choice
        + Sts  : String
        + Nm  : String
        + Id  : ISO20022.Acmt007001.AccountIdentification4Choice
    }
    ISO20022.Acmt007001.CustomerAccount4 *-- ISO20022.Acmt007001.Restriction1
    ISO20022.Acmt007001.CustomerAccount4 *-- ISO20022.Acmt007001.StatementFrequencyAndForm1
    ISO20022.Acmt007001.CustomerAccount4 *-- ISO20022.Acmt007001.CashAccountType2Choice
    ISO20022.Acmt007001.CustomerAccount4 *-- ISO20022.Acmt007001.AccountIdentification4Choice
    class ISO20022.Acmt007001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Acmt007001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt007001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Acmt007001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Acmt007001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Acmt007001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Acmt007001.FinancialInstitutionIdentification23 *-- ISO20022.Acmt007001.GenericFinancialIdentification1
    ISO20022.Acmt007001.FinancialInstitutionIdentification23 *-- ISO20022.Acmt007001.PostalAddress27
    ISO20022.Acmt007001.FinancialInstitutionIdentification23 *-- ISO20022.Acmt007001.ClearingSystemMemberIdentification2
    class ISO20022.Acmt007001.FixedAmountOrUnlimited1Choice {
        + NotLtd  : String
        + Amt  : ISO20022.Acmt007001.ActiveCurrencyAndAmount
    }
    ISO20022.Acmt007001.FixedAmountOrUnlimited1Choice *-- ISO20022.Acmt007001.ActiveCurrencyAndAmount
    class ISO20022.Acmt007001.Frequency7Code {
        INDA = 1
        WEEK = 2
        MOVE = 3
        TEND = 4
        MIAN = 5
        QURT = 6
        MNTH = 7
        DAIL = 8
        YEAR = 9
    }
    class ISO20022.Acmt007001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt007001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt007001.GenericAccountIdentification1 *-- ISO20022.Acmt007001.AccountSchemeName1Choice
    class ISO20022.Acmt007001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt007001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt007001.GenericFinancialIdentification1 *-- ISO20022.Acmt007001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Acmt007001.GenericIdentification13 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Acmt007001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Acmt007001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt007001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt007001.GenericOrganisationIdentification3 *-- ISO20022.Acmt007001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Acmt007001.GenericPersonIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt007001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt007001.GenericPersonIdentification2 *-- ISO20022.Acmt007001.PersonIdentificationSchemeName1Choice
    class ISO20022.Acmt007001.Group6 {
        + Pty  : global::System.Collections.Generic.List~ISO20022.Acmt007001.PartyAndCertificate6~
        + GrpId  : String
    }
    ISO20022.Acmt007001.Group6 *-- ISO20022.Acmt007001.PartyAndCertificate6
    class ISO20022.Acmt007001.MaximumAmountByPeriod1 {
        + NbOfDays  : String
        + MaxAmt  : ISO20022.Acmt007001.ActiveCurrencyAndAmount
    }
    ISO20022.Acmt007001.MaximumAmountByPeriod1 *-- ISO20022.Acmt007001.ActiveCurrencyAndAmount
    class ISO20022.Acmt007001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Acmt007001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Acmt007001.OperationMandate7 {
        + EndDt  : DateTime
        + StartDt  : DateTime
        + BkOpr  : global::System.Collections.Generic.List~ISO20022.Acmt007001.BankTransactionCodeStructure4~
        + MndtHldr  : global::System.Collections.Generic.List~ISO20022.Acmt007001.PartyAndAuthorisation7~
        + SgntrOrdrInd  : String
        + ReqrdSgntrNb  : String
        + AplblChanl  : global::System.Collections.Generic.List~ISO20022.Acmt007001.Channel2Choice~
        + Id  : String
    }
    ISO20022.Acmt007001.OperationMandate7 *-- ISO20022.Acmt007001.BankTransactionCodeStructure4
    ISO20022.Acmt007001.OperationMandate7 *-- ISO20022.Acmt007001.PartyAndAuthorisation7
    ISO20022.Acmt007001.OperationMandate7 *-- ISO20022.Acmt007001.Channel2Choice
    class ISO20022.Acmt007001.Organisation42 {
        + LglRprtv  : global::System.Collections.Generic.List~ISO20022.Acmt007001.PartyIdentification274~
        + Sndr  : global::System.Collections.Generic.List~ISO20022.Acmt007001.PartyIdentification274~
        + MainMndtHldr  : global::System.Collections.Generic.List~ISO20022.Acmt007001.PartyIdentification274~
        + TrsrMgr  : ISO20022.Acmt007001.PartyIdentification274
        + RprtvOffcr  : global::System.Collections.Generic.List~ISO20022.Acmt007001.PartyIdentification274~
        + OrgId  : ISO20022.Acmt007001.OrganisationIdentification39
        + BllgAdr  : ISO20022.Acmt007001.PostalAddress27
        + LglAdr  : ISO20022.Acmt007001.PostalAddress27
        + BizAdr  : ISO20022.Acmt007001.PostalAddress27
        + OprlAdr  : ISO20022.Acmt007001.PostalAddress27
        + RegnDt  : DateTime
        + CtryOfOpr  : String
        + TradgNm  : String
        + FullLglNm  : String
    }
    ISO20022.Acmt007001.Organisation42 *-- ISO20022.Acmt007001.PartyIdentification274
    ISO20022.Acmt007001.Organisation42 *-- ISO20022.Acmt007001.PartyIdentification274
    ISO20022.Acmt007001.Organisation42 *-- ISO20022.Acmt007001.PartyIdentification274
    ISO20022.Acmt007001.Organisation42 *-- ISO20022.Acmt007001.PartyIdentification274
    ISO20022.Acmt007001.Organisation42 *-- ISO20022.Acmt007001.PartyIdentification274
    ISO20022.Acmt007001.Organisation42 *-- ISO20022.Acmt007001.OrganisationIdentification39
    ISO20022.Acmt007001.Organisation42 *-- ISO20022.Acmt007001.PostalAddress27
    ISO20022.Acmt007001.Organisation42 *-- ISO20022.Acmt007001.PostalAddress27
    ISO20022.Acmt007001.Organisation42 *-- ISO20022.Acmt007001.PostalAddress27
    ISO20022.Acmt007001.Organisation42 *-- ISO20022.Acmt007001.PostalAddress27
    class ISO20022.Acmt007001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt007001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Acmt007001.OrganisationIdentification39 *-- ISO20022.Acmt007001.GenericOrganisationIdentification3
    class ISO20022.Acmt007001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt007001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Acmt007001.Party52Choice {
        + PrvtId  : ISO20022.Acmt007001.PersonIdentification18
        + OrgId  : ISO20022.Acmt007001.OrganisationIdentification39
    }
    ISO20022.Acmt007001.Party52Choice *-- ISO20022.Acmt007001.PersonIdentification18
    ISO20022.Acmt007001.Party52Choice *-- ISO20022.Acmt007001.OrganisationIdentification39
    class ISO20022.Acmt007001.PartyAndAuthorisation7 {
        + Authstn  : ISO20022.Acmt007001.Authorisation2
        + SgntrOrdr  : String
        + PtyOrGrp  : ISO20022.Acmt007001.PartyOrGroup3Choice
    }
    ISO20022.Acmt007001.PartyAndAuthorisation7 *-- ISO20022.Acmt007001.Authorisation2
    ISO20022.Acmt007001.PartyAndAuthorisation7 *-- ISO20022.Acmt007001.PartyOrGroup3Choice
    class ISO20022.Acmt007001.PartyAndCertificate6 {
        + Cert  : String
        + Pty  : ISO20022.Acmt007001.PartyIdentification272
    }
    ISO20022.Acmt007001.PartyAndCertificate6 *-- ISO20022.Acmt007001.PartyIdentification272
    class ISO20022.Acmt007001.PartyAndSignature4 {
        + Sgntr  : ISO20022.Acmt007001.SkipPayload
        + Pty  : ISO20022.Acmt007001.PartyIdentification272
    }
    ISO20022.Acmt007001.PartyAndSignature4 *-- ISO20022.Acmt007001.SkipPayload
    ISO20022.Acmt007001.PartyAndSignature4 *-- ISO20022.Acmt007001.PartyIdentification272
    class ISO20022.Acmt007001.PartyIdentification272 {
        + CtctDtls  : ISO20022.Acmt007001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Acmt007001.Party52Choice
        + PstlAdr  : ISO20022.Acmt007001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Acmt007001.PartyIdentification272 *-- ISO20022.Acmt007001.Contact13
    ISO20022.Acmt007001.PartyIdentification272 *-- ISO20022.Acmt007001.Party52Choice
    ISO20022.Acmt007001.PartyIdentification272 *-- ISO20022.Acmt007001.PostalAddress27
    class ISO20022.Acmt007001.PartyIdentification274 {
        + CtctDtls  : ISO20022.Acmt007001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Acmt007001.PersonIdentification18
        + PstlAdr  : ISO20022.Acmt007001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Acmt007001.PartyIdentification274 *-- ISO20022.Acmt007001.Contact13
    ISO20022.Acmt007001.PartyIdentification274 *-- ISO20022.Acmt007001.PersonIdentification18
    ISO20022.Acmt007001.PartyIdentification274 *-- ISO20022.Acmt007001.PostalAddress27
    class ISO20022.Acmt007001.PartyOrGroup3Choice {
        + Pty  : ISO20022.Acmt007001.PartyAndCertificate6
        + GrpId  : String
    }
    ISO20022.Acmt007001.PartyOrGroup3Choice *-- ISO20022.Acmt007001.PartyAndCertificate6
    class ISO20022.Acmt007001.PersonIdentification18 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt007001.GenericPersonIdentification2~
        + DtAndPlcOfBirth  : ISO20022.Acmt007001.DateAndPlaceOfBirth1
    }
    ISO20022.Acmt007001.PersonIdentification18 *-- ISO20022.Acmt007001.GenericPersonIdentification2
    ISO20022.Acmt007001.PersonIdentification18 *-- ISO20022.Acmt007001.DateAndPlaceOfBirth1
    class ISO20022.Acmt007001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt007001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Acmt007001.AddressType3Choice
    }
    ISO20022.Acmt007001.PostalAddress27 *-- ISO20022.Acmt007001.AddressType3Choice
    class ISO20022.Acmt007001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Acmt007001.ProprietaryBankTransactionCodeStructure1 {
        + Issr  : String
        + Cd  : String
    }
    class ISO20022.Acmt007001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Acmt007001.ProxyAccountType1Choice
    }
    ISO20022.Acmt007001.ProxyAccountIdentification1 *-- ISO20022.Acmt007001.ProxyAccountType1Choice
    class ISO20022.Acmt007001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt007001.References4 {
        + AttchdDocNm  : global::System.Collections.Generic.List~String~
        + PrcId  : ISO20022.Acmt007001.MessageIdentification1
        + MsgId  : ISO20022.Acmt007001.MessageIdentification1
    }
    ISO20022.Acmt007001.References4 *-- ISO20022.Acmt007001.MessageIdentification1
    ISO20022.Acmt007001.References4 *-- ISO20022.Acmt007001.MessageIdentification1
    class ISO20022.Acmt007001.Restriction1 {
        + VldUntil  : DateTime
        + VldFr  : DateTime
        + RstrctnTp  : ISO20022.Acmt007001.CodeOrProprietary1Choice
    }
    ISO20022.Acmt007001.Restriction1 *-- ISO20022.Acmt007001.CodeOrProprietary1Choice
    class ISO20022.Acmt007001.SkipPayload {
    }
    class ISO20022.Acmt007001.StatementFrequencyAndForm1 {
        + Frmt  : ISO20022.Acmt007001.CommunicationFormat1Choice
        + DlvryAdr  : String
        + ComMtd  : ISO20022.Acmt007001.CommunicationMethod2Choice
        + Frqcy  : String
    }
    ISO20022.Acmt007001.StatementFrequencyAndForm1 *-- ISO20022.Acmt007001.CommunicationFormat1Choice
    ISO20022.Acmt007001.StatementFrequencyAndForm1 *-- ISO20022.Acmt007001.CommunicationMethod2Choice
    class ISO20022.Acmt007001.SupplementaryData1 {
        + Envlp  : ISO20022.Acmt007001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Acmt007001.SupplementaryData1 *-- ISO20022.Acmt007001.SupplementaryDataEnvelope1
    class ISO20022.Acmt007001.SupplementaryDataEnvelope1 {
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

## Value ISO20022.Acmt007001.AccountContract2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UrgcyFlg|String||XmlElement()||
|+|TrgtClsgDt|DateTime||XmlElement()||
|+|TrgtGoLiveDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt007001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Acmt007001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Aspect ISO20022.Acmt007001.AccountOpeningRequestV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Acmt007001.SupplementaryData1>||XmlElement()||
|+|DgtlSgntr|global::System.Collections.Generic.List<ISO20022.Acmt007001.PartyAndSignature4>||XmlElement()||
|+|RefAcct|ISO20022.Acmt007001.CashAccount40||XmlElement()||
|+|Grp|global::System.Collections.Generic.List<ISO20022.Acmt007001.Group6>||XmlElement()||
|+|Mndt|global::System.Collections.Generic.List<ISO20022.Acmt007001.OperationMandate7>||XmlElement()||
|+|Org|ISO20022.Acmt007001.Organisation42||XmlElement()||
|+|AcctSvcrId|ISO20022.Acmt007001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|UndrlygMstrAgrmt|ISO20022.Acmt007001.ContractDocument1||XmlElement()||
|+|CtrctDts|ISO20022.Acmt007001.AccountContract2||XmlElement()||
|+|Acct|ISO20022.Acmt007001.CustomerAccount4||XmlElement()||
|+|Fr|ISO20022.Acmt007001.OrganisationIdentification39||XmlElement()||
|+|Refs|ISO20022.Acmt007001.References4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""DgtlSgntr""",DgtlSgntr),validElement(DgtlSgntr),validElement(RefAcct),validList("""Grp""",Grp),validElement(Grp),validList("""Mndt""",Mndt),validElement(Mndt),validElement(Org),validElement(AcctSvcrId),validElement(UndrlygMstrAgrmt),validElement(CtrctDts),validElement(Acct),validElement(Fr),validElement(Refs))|

---

## Value ISO20022.Acmt007001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt007001.AccountStatus3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FORM|Int32||XmlEnum("""FORM""")|1|
||DELE|Int32||XmlEnum("""DELE""")|2|
||DISA|Int32||XmlEnum("""DISA""")|3|
||ENAB|Int32||XmlEnum("""ENAB""")|4|

---

## Value ISO20022.Acmt007001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Acmt007001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Acmt007001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt007001.Authorisation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MaxAmtByBlkSubmissn|ISO20022.Acmt007001.FixedAmountOrUnlimited1Choice||XmlElement()||
|+|MaxAmtByPrd|global::System.Collections.Generic.List<ISO20022.Acmt007001.MaximumAmountByPeriod1>||XmlElement()||
|+|MaxAmtByTx|ISO20022.Acmt007001.FixedAmountOrUnlimited1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MaxAmtByBlkSubmissn),validList("""MaxAmtByPrd""",MaxAmtByPrd),validElement(MaxAmtByPrd),validElement(MaxAmtByTx))|

---

## Value ISO20022.Acmt007001.BankTransactionCodeStructure4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt007001.ProprietaryBankTransactionCodeStructure1||XmlElement()||
|+|Domn|ISO20022.Acmt007001.BankTransactionCodeStructure5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Domn))|

---

## Value ISO20022.Acmt007001.BankTransactionCodeStructure5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fmly|ISO20022.Acmt007001.BankTransactionCodeStructure6||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Fmly))|

---

## Value ISO20022.Acmt007001.BankTransactionCodeStructure6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubFmlyCd|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt007001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Acmt007001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Acmt007001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Acmt007001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Acmt007001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Acmt007001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Acmt007001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Acmt007001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Acmt007001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Acmt007001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt007001.Channel2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt007001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt007001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Acmt007001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Acmt007001.CodeOrProprietary1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt007001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt007001.CommunicationFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt007001.CommunicationMethod2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt007001.CommunicationMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||POST|Int32||XmlEnum("""POST""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||FILE|Int32||XmlEnum("""FILE""")|3|
||FAXI|Int32||XmlEnum("""FAXI""")|4|
||EMAL|Int32||XmlEnum("""EMAL""")|5|

---

## Enum ISO20022.Acmt007001.CommunicationMethod3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONLI|Int32||XmlEnum("""ONLI""")|1|
||FILE|Int32||XmlEnum("""FILE""")|2|
||PHON|Int32||XmlEnum("""PHON""")|3|
||POST|Int32||XmlEnum("""POST""")|4|
||FAXI|Int32||XmlEnum("""FAXI""")|5|
||EMAL|Int32||XmlEnum("""EMAL""")|6|

---

## Value ISO20022.Acmt007001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt007001.OtherContact1>||XmlElement()||
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

## Value ISO20022.Acmt007001.ContractDocument1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Vrsn|String||XmlElement()||
|+|SgnOffDt|DateTime||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt007001.CustomerAccount4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rstrctn|global::System.Collections.Generic.List<ISO20022.Acmt007001.Restriction1>||XmlElement()||
|+|ClsgDt|DateTime||XmlElement()||
|+|StmtFrqcyAndFrmt|global::System.Collections.Generic.List<ISO20022.Acmt007001.StatementFrequencyAndForm1>||XmlElement()||
|+|ClngNtfctnAmt|Decimal||XmlElement()||
|+|FlrNtfctnAmt|Decimal||XmlElement()||
|+|AcctPurp|String||XmlElement()||
|+|AvrgBal|Decimal||XmlElement()||
|+|MnthlyTxNb|String||XmlElement()||
|+|MnthlyRcvdVal|Decimal||XmlElement()||
|+|MnthlyPmtVal|Decimal||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Acmt007001.CashAccountType2Choice||XmlElement()||
|+|Sts|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|ISO20022.Acmt007001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rstrctn""",Rstrctn),validElement(Rstrctn),validList("""StmtFrqcyAndFrmt""",StmtFrqcyAndFrmt),validElement(StmtFrqcyAndFrmt),validPattern("""MnthlyTxNb""",MnthlyTxNb,"""[0-9]{1,5}"""),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Acmt007001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Type ISO20022.Acmt007001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOpngReq|ISO20022.Acmt007001.AccountOpeningRequestV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctOpngReq))|

---

## Value ISO20022.Acmt007001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt007001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Acmt007001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Acmt007001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Acmt007001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Acmt007001.FixedAmountOrUnlimited1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotLtd|String||XmlElement()||
|+|Amt|ISO20022.Acmt007001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""NotLtd""",NotLtd,"""UNLIMITED"""),validElement(Amt),validChoice(NotLtd,Amt))|

---

## Enum ISO20022.Acmt007001.Frequency7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDA|Int32||XmlEnum("""INDA""")|1|
||WEEK|Int32||XmlEnum("""WEEK""")|2|
||MOVE|Int32||XmlEnum("""MOVE""")|3|
||TEND|Int32||XmlEnum("""TEND""")|4|
||MIAN|Int32||XmlEnum("""MIAN""")|5|
||QURT|Int32||XmlEnum("""QURT""")|6|
||MNTH|Int32||XmlEnum("""MNTH""")|7|
||DAIL|Int32||XmlEnum("""DAIL""")|8|
||YEAR|Int32||XmlEnum("""YEAR""")|9|

---

## Value ISO20022.Acmt007001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt007001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt007001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt007001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt007001.GenericIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Acmt007001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Acmt007001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt007001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt007001.GenericPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt007001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt007001.Group6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty|global::System.Collections.Generic.List<ISO20022.Acmt007001.PartyAndCertificate6>||XmlElement()||
|+|GrpId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Pty""",Pty),validList("""Pty""",Pty),validElement(Pty),validPattern("""GrpId""",GrpId,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Acmt007001.MaximumAmountByPeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NbOfDays|String||XmlElement()||
|+|MaxAmt|ISO20022.Acmt007001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""NbOfDays""",NbOfDays,"""[0-9]{1,3}"""),validElement(MaxAmt))|

---

## Value ISO20022.Acmt007001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Acmt007001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Acmt007001.OperationMandate7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EndDt|DateTime||XmlElement()||
|+|StartDt|DateTime||XmlElement()||
|+|BkOpr|global::System.Collections.Generic.List<ISO20022.Acmt007001.BankTransactionCodeStructure4>||XmlElement()||
|+|MndtHldr|global::System.Collections.Generic.List<ISO20022.Acmt007001.PartyAndAuthorisation7>||XmlElement()||
|+|SgntrOrdrInd|String||XmlElement()||
|+|ReqrdSgntrNb|String||XmlElement()||
|+|AplblChanl|global::System.Collections.Generic.List<ISO20022.Acmt007001.Channel2Choice>||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""BkOpr""",BkOpr),validList("""BkOpr""",BkOpr),validElement(BkOpr),validList("""MndtHldr""",MndtHldr),validElement(MndtHldr),validPattern("""ReqrdSgntrNb""",ReqrdSgntrNb,"""[\+]{0,1}[0-9]{1,15}"""),validRequired("""AplblChanl""",AplblChanl),validList("""AplblChanl""",AplblChanl),validElement(AplblChanl))|

---

## Value ISO20022.Acmt007001.Organisation42


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LglRprtv|global::System.Collections.Generic.List<ISO20022.Acmt007001.PartyIdentification274>||XmlElement()||
|+|Sndr|global::System.Collections.Generic.List<ISO20022.Acmt007001.PartyIdentification274>||XmlElement()||
|+|MainMndtHldr|global::System.Collections.Generic.List<ISO20022.Acmt007001.PartyIdentification274>||XmlElement()||
|+|TrsrMgr|ISO20022.Acmt007001.PartyIdentification274||XmlElement()||
|+|RprtvOffcr|global::System.Collections.Generic.List<ISO20022.Acmt007001.PartyIdentification274>||XmlElement()||
|+|OrgId|ISO20022.Acmt007001.OrganisationIdentification39||XmlElement()||
|+|BllgAdr|ISO20022.Acmt007001.PostalAddress27||XmlElement()||
|+|LglAdr|ISO20022.Acmt007001.PostalAddress27||XmlElement()||
|+|BizAdr|ISO20022.Acmt007001.PostalAddress27||XmlElement()||
|+|OprlAdr|ISO20022.Acmt007001.PostalAddress27||XmlElement()||
|+|RegnDt|DateTime||XmlElement()||
|+|CtryOfOpr|String||XmlElement()||
|+|TradgNm|String||XmlElement()||
|+|FullLglNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LglRprtv""",LglRprtv),validElement(LglRprtv),validList("""Sndr""",Sndr),validElement(Sndr),validList("""MainMndtHldr""",MainMndtHldr),validElement(MainMndtHldr),validElement(TrsrMgr),validList("""RprtvOffcr""",RprtvOffcr),validElement(RprtvOffcr),validElement(OrgId),validElement(BllgAdr),validElement(LglAdr),validElement(BizAdr),validElement(OprlAdr),validPattern("""CtryOfOpr""",CtryOfOpr,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Acmt007001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt007001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Acmt007001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt007001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt007001.Party52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Acmt007001.PersonIdentification18||XmlElement()||
|+|OrgId|ISO20022.Acmt007001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Acmt007001.PartyAndAuthorisation7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Authstn|ISO20022.Acmt007001.Authorisation2||XmlElement()||
|+|SgntrOrdr|String||XmlElement()||
|+|PtyOrGrp|ISO20022.Acmt007001.PartyOrGroup3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Authstn),validPattern("""SgntrOrdr""",SgntrOrdr,"""[\+]{0,1}[0-9]{1,15}"""),validElement(PtyOrGrp))|

---

## Value ISO20022.Acmt007001.PartyAndCertificate6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cert|String||XmlElement()||
|+|Pty|ISO20022.Acmt007001.PartyIdentification272||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty))|

---

## Value ISO20022.Acmt007001.PartyAndSignature4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgntr|ISO20022.Acmt007001.SkipPayload||XmlElement()||
|+|Pty|ISO20022.Acmt007001.PartyIdentification272||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sgntr),validElement(Pty))|

---

## Value ISO20022.Acmt007001.PartyIdentification272


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Acmt007001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Acmt007001.Party52Choice||XmlElement()||
|+|PstlAdr|ISO20022.Acmt007001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Acmt007001.PartyIdentification274


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Acmt007001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Acmt007001.PersonIdentification18||XmlElement()||
|+|PstlAdr|ISO20022.Acmt007001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Acmt007001.PartyOrGroup3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty|ISO20022.Acmt007001.PartyAndCertificate6||XmlElement()||
|+|GrpId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty),validPattern("""GrpId""",GrpId,"""[a-zA-Z0-9]{1,4}"""),validChoice(Pty,GrpId))|

---

## Value ISO20022.Acmt007001.PersonIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt007001.GenericPersonIdentification2>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Acmt007001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Acmt007001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt007001.PostalAddress27


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
|+|AdrTp|ISO20022.Acmt007001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Acmt007001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Value ISO20022.Acmt007001.ProprietaryBankTransactionCodeStructure1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt007001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Acmt007001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Acmt007001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt007001.References4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttchdDocNm|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PrcId|ISO20022.Acmt007001.MessageIdentification1||XmlElement()||
|+|MsgId|ISO20022.Acmt007001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrcId),validElement(MsgId))|

---

## Value ISO20022.Acmt007001.Restriction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VldUntil|DateTime||XmlElement()||
|+|VldFr|DateTime||XmlElement()||
|+|RstrctnTp|ISO20022.Acmt007001.CodeOrProprietary1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RstrctnTp))|

---

## Value ISO20022.Acmt007001.SkipPayload


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt007001.StatementFrequencyAndForm1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Frmt|ISO20022.Acmt007001.CommunicationFormat1Choice||XmlElement()||
|+|DlvryAdr|String||XmlElement()||
|+|ComMtd|ISO20022.Acmt007001.CommunicationMethod2Choice||XmlElement()||
|+|Frqcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Frmt),validElement(ComMtd))|

---

## Value ISO20022.Acmt007001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Acmt007001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Acmt007001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

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

