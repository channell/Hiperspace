# camt.004.001.10
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt004001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt004001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt004001.AccountIdentification4Choice *-- ISO20022.Camt004001.GenericAccountIdentification1
    class ISO20022.Camt004001.AccountOrBusinessError6Choice {
        + BizErr  : global::System.Collections.Generic.List~ISO20022.Camt004001.ErrorHandling5~
        + Acct  : ISO20022.Camt004001.CashAccountData1
    }
    ISO20022.Camt004001.AccountOrBusinessError6Choice *-- ISO20022.Camt004001.ErrorHandling5
    ISO20022.Camt004001.AccountOrBusinessError6Choice *-- ISO20022.Camt004001.CashAccountData1
    class ISO20022.Camt004001.AccountOrOperationalError6Choice {
        + OprlErr  : global::System.Collections.Generic.List~ISO20022.Camt004001.ErrorHandling5~
        + AcctRpt  : global::System.Collections.Generic.List~ISO20022.Camt004001.AccountReport35~
    }
    ISO20022.Camt004001.AccountOrOperationalError6Choice *-- ISO20022.Camt004001.ErrorHandling5
    ISO20022.Camt004001.AccountOrOperationalError6Choice *-- ISO20022.Camt004001.AccountReport35
    class ISO20022.Camt004001.AccountReport35 {
        + AcctOrErr  : ISO20022.Camt004001.AccountOrBusinessError6Choice
        + AcctId  : ISO20022.Camt004001.AccountIdentification4Choice
    }
    ISO20022.Camt004001.AccountReport35 *-- ISO20022.Camt004001.AccountOrBusinessError6Choice
    ISO20022.Camt004001.AccountReport35 *-- ISO20022.Camt004001.AccountIdentification4Choice
    class ISO20022.Camt004001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt004001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt004001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt004001.AddressType3Choice {
        + Prtry  : ISO20022.Camt004001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt004001.AddressType3Choice *-- ISO20022.Camt004001.GenericIdentification30
    class ISO20022.Camt004001.Amount2Choice {
        + AmtWthCcy  : ISO20022.Camt004001.ActiveCurrencyAndAmount
        + AmtWthtCcy  : Decimal
    }
    ISO20022.Camt004001.Amount2Choice *-- ISO20022.Camt004001.ActiveCurrencyAndAmount
    class ISO20022.Camt004001.BalanceRestrictionType1 {
        + PrcgTp  : ISO20022.Camt004001.ProcessingType1Choice
        + Desc  : String
        + Tp  : ISO20022.Camt004001.GenericIdentification1
    }
    ISO20022.Camt004001.BalanceRestrictionType1 *-- ISO20022.Camt004001.ProcessingType1Choice
    ISO20022.Camt004001.BalanceRestrictionType1 *-- ISO20022.Camt004001.GenericIdentification1
    class ISO20022.Camt004001.BalanceStatus1Code {
        STLD = 1
        PDNG = 2
    }
    class ISO20022.Camt004001.BalanceType11Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt004001.BalanceType9Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt004001.BilateralLimit4 {
        + BilBal  : global::System.Collections.Generic.List~ISO20022.Camt004001.CashBalance11~
        + CdtDbtInd  : String
        + LmtAmt  : ISO20022.Camt004001.Amount2Choice
        + CtrPtyId  : ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8
    }
    ISO20022.Camt004001.BilateralLimit4 *-- ISO20022.Camt004001.CashBalance11
    ISO20022.Camt004001.BilateralLimit4 *-- ISO20022.Camt004001.Amount2Choice
    ISO20022.Camt004001.BilateralLimit4 *-- ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8
    class ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Camt004001.BranchData5
        + FinInstnId  : ISO20022.Camt004001.FinancialInstitutionIdentification23
    }
    ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt004001.BranchData5
    ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt004001.FinancialInstitutionIdentification23
    class ISO20022.Camt004001.BranchData5 {
        + PstlAdr  : ISO20022.Camt004001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt004001.BranchData5 *-- ISO20022.Camt004001.PostalAddress27
    class ISO20022.Camt004001.CashAccount40 {
        + Prxy  : ISO20022.Camt004001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Camt004001.CashAccountType2Choice
        + Id  : ISO20022.Camt004001.AccountIdentification4Choice
    }
    ISO20022.Camt004001.CashAccount40 *-- ISO20022.Camt004001.ProxyAccountIdentification1
    ISO20022.Camt004001.CashAccount40 *-- ISO20022.Camt004001.CashAccountType2Choice
    ISO20022.Camt004001.CashAccount40 *-- ISO20022.Camt004001.AccountIdentification4Choice
    class ISO20022.Camt004001.CashAccountData1 {
        + StgOrdr  : global::System.Collections.Generic.List~ISO20022.Camt004001.StandingOrder11~
        + CurBilLmt  : global::System.Collections.Generic.List~ISO20022.Camt004001.BilateralLimit4~
        + MulBal  : global::System.Collections.Generic.List~ISO20022.Camt004001.CashBalance13~
        + Svcr  : ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8
        + Ownr  : ISO20022.Camt004001.PartyIdentification272
        + CurMulLmt  : ISO20022.Camt004001.Limit5
        + Prxy  : ISO20022.Camt004001.ProxyAccountIdentification1
        + Ccy  : String
        + Tp  : ISO20022.Camt004001.CashAccountType2Choice
        + Nm  : String
    }
    ISO20022.Camt004001.CashAccountData1 *-- ISO20022.Camt004001.StandingOrder11
    ISO20022.Camt004001.CashAccountData1 *-- ISO20022.Camt004001.BilateralLimit4
    ISO20022.Camt004001.CashAccountData1 *-- ISO20022.Camt004001.CashBalance13
    ISO20022.Camt004001.CashAccountData1 *-- ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt004001.CashAccountData1 *-- ISO20022.Camt004001.PartyIdentification272
    ISO20022.Camt004001.CashAccountData1 *-- ISO20022.Camt004001.Limit5
    ISO20022.Camt004001.CashAccountData1 *-- ISO20022.Camt004001.ProxyAccountIdentification1
    ISO20022.Camt004001.CashAccountData1 *-- ISO20022.Camt004001.CashAccountType2Choice
    class ISO20022.Camt004001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt004001.CashBalance11 {
        + NbOfPmts  : Decimal
        + ValDt  : ISO20022.Camt004001.DateAndDateTime2Choice
        + Sts  : String
        + Tp  : ISO20022.Camt004001.BalanceType9Choice
        + CdtDbtInd  : String
        + Amt  : Decimal
    }
    ISO20022.Camt004001.CashBalance11 *-- ISO20022.Camt004001.DateAndDateTime2Choice
    ISO20022.Camt004001.CashBalance11 *-- ISO20022.Camt004001.BalanceType9Choice
    class ISO20022.Camt004001.CashBalance13 {
        + RstrctnTp  : ISO20022.Camt004001.BalanceRestrictionType1
        + NbOfPmts  : Decimal
        + PrcgDt  : ISO20022.Camt004001.DateAndDateTime2Choice
        + ValDt  : ISO20022.Camt004001.DateAndDateTime2Choice
        + Sts  : String
        + Tp  : ISO20022.Camt004001.BalanceType11Choice
        + CdtDbtInd  : String
        + Amt  : Decimal
    }
    ISO20022.Camt004001.CashBalance13 *-- ISO20022.Camt004001.BalanceRestrictionType1
    ISO20022.Camt004001.CashBalance13 *-- ISO20022.Camt004001.DateAndDateTime2Choice
    ISO20022.Camt004001.CashBalance13 *-- ISO20022.Camt004001.DateAndDateTime2Choice
    ISO20022.Camt004001.CashBalance13 *-- ISO20022.Camt004001.BalanceType11Choice
    class ISO20022.Camt004001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt004001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt004001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt004001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt004001.ClearingSystemIdentification2Choice
    class ISO20022.Camt004001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt004001.OtherContact1~
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
    ISO20022.Camt004001.Contact13 *-- ISO20022.Camt004001.OtherContact1
    class ISO20022.Camt004001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Camt004001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Camt004001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Camt004001.DatePeriod3 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Camt004001.ErrorHandling3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt004001.ErrorHandling5 {
        + Desc  : String
        + Err  : ISO20022.Camt004001.ErrorHandling3Choice
    }
    ISO20022.Camt004001.ErrorHandling5 *-- ISO20022.Camt004001.ErrorHandling3Choice
    class ISO20022.Camt004001.EventType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt004001.ExecutionType1Choice {
        + Evt  : ISO20022.Camt004001.EventType1Choice
        + Tm  : DateTime
    }
    ISO20022.Camt004001.ExecutionType1Choice *-- ISO20022.Camt004001.EventType1Choice
    class ISO20022.Camt004001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt004001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Camt004001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt004001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt004001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt004001.FinancialInstitutionIdentification23 *-- ISO20022.Camt004001.GenericFinancialIdentification1
    ISO20022.Camt004001.FinancialInstitutionIdentification23 *-- ISO20022.Camt004001.PostalAddress27
    ISO20022.Camt004001.FinancialInstitutionIdentification23 *-- ISO20022.Camt004001.ClearingSystemMemberIdentification2
    class ISO20022.Camt004001.Frequency2Code {
        OVNG = 1
        INDA = 2
        ADHO = 3
        DAIL = 4
        WEEK = 5
        MIAN = 6
        QURT = 7
        MNTH = 8
        YEAR = 9
    }
    class ISO20022.Camt004001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt004001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt004001.GenericAccountIdentification1 *-- ISO20022.Camt004001.AccountSchemeName1Choice
    class ISO20022.Camt004001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt004001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt004001.GenericFinancialIdentification1 *-- ISO20022.Camt004001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt004001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Camt004001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt004001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt004001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt004001.GenericOrganisationIdentification3 *-- ISO20022.Camt004001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Camt004001.GenericPersonIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt004001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt004001.GenericPersonIdentification2 *-- ISO20022.Camt004001.PersonIdentificationSchemeName1Choice
    class ISO20022.Camt004001.Limit5 {
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt004001.Amount2Choice
    }
    ISO20022.Camt004001.Limit5 *-- ISO20022.Camt004001.Amount2Choice
    class ISO20022.Camt004001.MessageHeader7 {
        + QryNm  : String
        + OrgnlBizQry  : ISO20022.Camt004001.OriginalBusinessQuery1
        + ReqTp  : ISO20022.Camt004001.RequestType4Choice
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Camt004001.MessageHeader7 *-- ISO20022.Camt004001.OriginalBusinessQuery1
    ISO20022.Camt004001.MessageHeader7 *-- ISO20022.Camt004001.RequestType4Choice
    class ISO20022.Camt004001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Camt004001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt004001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Camt004001.OrganisationIdentification39 *-- ISO20022.Camt004001.GenericOrganisationIdentification3
    class ISO20022.Camt004001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt004001.OriginalBusinessQuery1 {
        + CreDtTm  : DateTime
        + MsgNmId  : String
        + MsgId  : String
    }
    class ISO20022.Camt004001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Camt004001.Party52Choice {
        + PrvtId  : ISO20022.Camt004001.PersonIdentification18
        + OrgId  : ISO20022.Camt004001.OrganisationIdentification39
    }
    ISO20022.Camt004001.Party52Choice *-- ISO20022.Camt004001.PersonIdentification18
    ISO20022.Camt004001.Party52Choice *-- ISO20022.Camt004001.OrganisationIdentification39
    class ISO20022.Camt004001.PartyIdentification272 {
        + CtctDtls  : ISO20022.Camt004001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Camt004001.Party52Choice
        + PstlAdr  : ISO20022.Camt004001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Camt004001.PartyIdentification272 *-- ISO20022.Camt004001.Contact13
    ISO20022.Camt004001.PartyIdentification272 *-- ISO20022.Camt004001.Party52Choice
    ISO20022.Camt004001.PartyIdentification272 *-- ISO20022.Camt004001.PostalAddress27
    class ISO20022.Camt004001.PersonIdentification18 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt004001.GenericPersonIdentification2~
        + DtAndPlcOfBirth  : ISO20022.Camt004001.DateAndPlaceOfBirth1
    }
    ISO20022.Camt004001.PersonIdentification18 *-- ISO20022.Camt004001.GenericPersonIdentification2
    ISO20022.Camt004001.PersonIdentification18 *-- ISO20022.Camt004001.DateAndPlaceOfBirth1
    class ISO20022.Camt004001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt004001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Camt004001.AddressType3Choice
    }
    ISO20022.Camt004001.PostalAddress27 *-- ISO20022.Camt004001.AddressType3Choice
    class ISO20022.Camt004001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Camt004001.ProcessingType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt004001.ProcessingType1Code {
        CSDB = 1
        COLD = 2
        DLVR = 3
        EFAC = 4
        EARM = 5
        BLCK = 6
        RSVT = 7
        CVHD = 8
        RJCT = 9
    }
    class ISO20022.Camt004001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Camt004001.ProxyAccountType1Choice
    }
    ISO20022.Camt004001.ProxyAccountIdentification1 *-- ISO20022.Camt004001.ProxyAccountType1Choice
    class ISO20022.Camt004001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt004001.RequestType4Choice {
        + Prtry  : ISO20022.Camt004001.GenericIdentification1
        + Enqry  : String
        + PmtCtrl  : String
    }
    ISO20022.Camt004001.RequestType4Choice *-- ISO20022.Camt004001.GenericIdentification1
    class ISO20022.Camt004001.ReturnAccountV10 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt004001.SupplementaryData1~
        + RptOrErr  : ISO20022.Camt004001.AccountOrOperationalError6Choice
        + MsgHdr  : ISO20022.Camt004001.MessageHeader7
    }
    ISO20022.Camt004001.ReturnAccountV10 *-- ISO20022.Camt004001.SupplementaryData1
    ISO20022.Camt004001.ReturnAccountV10 *-- ISO20022.Camt004001.AccountOrOperationalError6Choice
    ISO20022.Camt004001.ReturnAccountV10 *-- ISO20022.Camt004001.MessageHeader7
    class ISO20022.Camt004001.StandingOrder11 {
        + ZeroSweepInd  : String
        + TtlsPerStgOrdr  : ISO20022.Camt004001.StandingOrderTotalAmount1
        + DbtrAcct  : ISO20022.Camt004001.CashAccount40
        + Dbtr  : ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8
        + CdtrAcct  : ISO20022.Camt004001.CashAccount40
        + Cdtr  : ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8
        + ExctnTp  : ISO20022.Camt004001.ExecutionType1Choice
        + LkSetOrdrSeq  : Decimal
        + LkSetOrdrId  : String
        + LkSetId  : String
        + RspnsblPty  : ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8
        + SysMmb  : ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8
        + VldtyPrd  : ISO20022.Camt004001.DatePeriod3
        + Frqcy  : String
        + Ref  : String
        + AssoctdPoolAcct  : ISO20022.Camt004001.AccountIdentification4Choice
        + Tp  : ISO20022.Camt004001.StandingOrderType1Choice
        + Ccy  : String
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt004001.Amount2Choice
    }
    ISO20022.Camt004001.StandingOrder11 *-- ISO20022.Camt004001.StandingOrderTotalAmount1
    ISO20022.Camt004001.StandingOrder11 *-- ISO20022.Camt004001.CashAccount40
    ISO20022.Camt004001.StandingOrder11 *-- ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt004001.StandingOrder11 *-- ISO20022.Camt004001.CashAccount40
    ISO20022.Camt004001.StandingOrder11 *-- ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt004001.StandingOrder11 *-- ISO20022.Camt004001.ExecutionType1Choice
    ISO20022.Camt004001.StandingOrder11 *-- ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt004001.StandingOrder11 *-- ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt004001.StandingOrder11 *-- ISO20022.Camt004001.DatePeriod3
    ISO20022.Camt004001.StandingOrder11 *-- ISO20022.Camt004001.AccountIdentification4Choice
    ISO20022.Camt004001.StandingOrder11 *-- ISO20022.Camt004001.StandingOrderType1Choice
    ISO20022.Camt004001.StandingOrder11 *-- ISO20022.Camt004001.Amount2Choice
    class ISO20022.Camt004001.StandingOrderTotalAmount1 {
        + PdgStgOrdr  : ISO20022.Camt004001.TotalAmountAndCurrency1
        + SetStgOrdr  : ISO20022.Camt004001.TotalAmountAndCurrency1
        + PdgPrdfndOrdr  : ISO20022.Camt004001.TotalAmountAndCurrency1
        + SetPrdfndOrdr  : ISO20022.Camt004001.TotalAmountAndCurrency1
    }
    ISO20022.Camt004001.StandingOrderTotalAmount1 *-- ISO20022.Camt004001.TotalAmountAndCurrency1
    ISO20022.Camt004001.StandingOrderTotalAmount1 *-- ISO20022.Camt004001.TotalAmountAndCurrency1
    ISO20022.Camt004001.StandingOrderTotalAmount1 *-- ISO20022.Camt004001.TotalAmountAndCurrency1
    ISO20022.Camt004001.StandingOrderTotalAmount1 *-- ISO20022.Camt004001.TotalAmountAndCurrency1
    class ISO20022.Camt004001.StandingOrderType1Choice {
        + Prtry  : ISO20022.Camt004001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Camt004001.StandingOrderType1Choice *-- ISO20022.Camt004001.GenericIdentification1
    class ISO20022.Camt004001.StandingOrderType1Code {
        PSTO = 1
        USTO = 2
    }
    class ISO20022.Camt004001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt004001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt004001.SupplementaryData1 *-- ISO20022.Camt004001.SupplementaryDataEnvelope1
    class ISO20022.Camt004001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Camt004001.SystemBalanceType2Code {
        AIDR = 1
        ADWR = 2
        DWRD = 3
        IRDR = 4
        IRLT = 5
        SAPP = 6
        BSCC = 7
        BSCD = 8
        REPC = 9
        REPD = 10
        SAPC = 11
        SAPD = 12
        OTCN = 13
        OTCG = 14
        OTCC = 15
        NSET = 16
        LACK = 17
        DSET = 18
        XCHN = 19
        XCHC = 20
        CUSA = 21
        SCOU = 22
        SCOL = 23
        FCOU = 24
        FCOL = 25
        REJB = 26
        FUTB = 27
        DPBL = 28
        CPBL = 29
        TPBL = 30
        DOHB = 31
        COHB = 32
        TOHB = 33
        CCPS = 34
        XCHG = 35
        PIPO = 36
        FUND = 37
        COLC = 38
        FORC = 39
        CUST = 40
        OTHB = 41
        BLOC = 42
        FSET = 43
        NOTE = 44
        THRE = 45
        DBIT = 46
        PRAV = 47
        ADJT = 48
        XDBT = 49
        XCRD = 50
        DLOD = 51
        XPCD = 52
        BLCK = 53
        PYMT = 54
        EAST = 55
        CRDT = 56
        LTSF = 57
        AVLB = 58
        LRLD = 59
        PDNG = 60
        CRRT = 61
        BOOK = 62
        CLSG = 63
        INTM = 64
        OPNG = 65
    }
    class ISO20022.Camt004001.TotalAmountAndCurrency1 {
        + Ccy  : String
        + CdtDbtInd  : String
        + TtlAmt  : Decimal
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

## Value ISO20022.Camt004001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt004001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt004001.AccountOrBusinessError6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BizErr|global::System.Collections.Generic.List<ISO20022.Camt004001.ErrorHandling5>||XmlElement()||
|+|Acct|ISO20022.Camt004001.CashAccountData1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""BizErr""",BizErr),validList("""BizErr""",BizErr),validElement(BizErr),validElement(Acct),validChoice(BizErr,Acct))|

---

## Value ISO20022.Camt004001.AccountOrOperationalError6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OprlErr|global::System.Collections.Generic.List<ISO20022.Camt004001.ErrorHandling5>||XmlElement()||
|+|AcctRpt|global::System.Collections.Generic.List<ISO20022.Camt004001.AccountReport35>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""OprlErr""",OprlErr),validList("""OprlErr""",OprlErr),validElement(OprlErr),validRequired("""AcctRpt""",AcctRpt),validList("""AcctRpt""",AcctRpt),validElement(AcctRpt),validChoice(OprlErr,AcctRpt))|

---

## Value ISO20022.Camt004001.AccountReport35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOrErr|ISO20022.Camt004001.AccountOrBusinessError6Choice||XmlElement()||
|+|AcctId|ISO20022.Camt004001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctOrErr),validElement(AcctId))|

---

## Value ISO20022.Camt004001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt004001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Camt004001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt004001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt004001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt004001.Amount2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtWthCcy|ISO20022.Camt004001.ActiveCurrencyAndAmount||XmlElement()||
|+|AmtWthtCcy|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtWthCcy),validChoice(AmtWthCcy,AmtWthtCcy))|

---

## Value ISO20022.Camt004001.BalanceRestrictionType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgTp|ISO20022.Camt004001.ProcessingType1Choice||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Tp|ISO20022.Camt004001.GenericIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrcgTp),validElement(Tp))|

---

## Enum ISO20022.Camt004001.BalanceStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||STLD|Int32||XmlEnum("""STLD""")|1|
||PDNG|Int32||XmlEnum("""PDNG""")|2|

---

## Value ISO20022.Camt004001.BalanceType11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt004001.BalanceType9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt004001.BilateralLimit4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BilBal|global::System.Collections.Generic.List<ISO20022.Camt004001.CashBalance11>||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|LmtAmt|ISO20022.Camt004001.Amount2Choice||XmlElement()||
|+|CtrPtyId|ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""BilBal""",BilBal),validElement(BilBal),validElement(LmtAmt),validElement(CtrPtyId))|

---

## Value ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt004001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Camt004001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt004001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt004001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Camt004001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Camt004001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Camt004001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Camt004001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Camt004001.CashAccountData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StgOrdr|global::System.Collections.Generic.List<ISO20022.Camt004001.StandingOrder11>||XmlElement()||
|+|CurBilLmt|global::System.Collections.Generic.List<ISO20022.Camt004001.BilateralLimit4>||XmlElement()||
|+|MulBal|global::System.Collections.Generic.List<ISO20022.Camt004001.CashBalance13>||XmlElement()||
|+|Svcr|ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Ownr|ISO20022.Camt004001.PartyIdentification272||XmlElement()||
|+|CurMulLmt|ISO20022.Camt004001.Limit5||XmlElement()||
|+|Prxy|ISO20022.Camt004001.ProxyAccountIdentification1||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Camt004001.CashAccountType2Choice||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""StgOrdr""",StgOrdr),validElement(StgOrdr),validList("""CurBilLmt""",CurBilLmt),validElement(CurBilLmt),validList("""MulBal""",MulBal),validElement(MulBal),validElement(Svcr),validElement(Ownr),validElement(CurMulLmt),validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp))|

---

## Value ISO20022.Camt004001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt004001.CashBalance11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NbOfPmts|Decimal||XmlElement()||
|+|ValDt|ISO20022.Camt004001.DateAndDateTime2Choice||XmlElement()||
|+|Sts|String||XmlElement()||
|+|Tp|ISO20022.Camt004001.BalanceType9Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValDt),validElement(Tp))|

---

## Value ISO20022.Camt004001.CashBalance13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RstrctnTp|ISO20022.Camt004001.BalanceRestrictionType1||XmlElement()||
|+|NbOfPmts|Decimal||XmlElement()||
|+|PrcgDt|ISO20022.Camt004001.DateAndDateTime2Choice||XmlElement()||
|+|ValDt|ISO20022.Camt004001.DateAndDateTime2Choice||XmlElement()||
|+|Sts|String||XmlElement()||
|+|Tp|ISO20022.Camt004001.BalanceType11Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RstrctnTp),validElement(PrcgDt),validElement(ValDt),validElement(Tp))|

---

## Value ISO20022.Camt004001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt004001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt004001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Camt004001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt004001.OtherContact1>||XmlElement()||
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

## Enum ISO20022.Camt004001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Camt004001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Camt004001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Camt004001.DatePeriod3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Camt004001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RtrAcct|ISO20022.Camt004001.ReturnAccountV10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RtrAcct))|

---

## Value ISO20022.Camt004001.ErrorHandling3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt004001.ErrorHandling5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|Err|ISO20022.Camt004001.ErrorHandling3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Err))|

---

## Value ISO20022.Camt004001.EventType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt004001.ExecutionType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Evt|ISO20022.Camt004001.EventType1Choice||XmlElement()||
|+|Tm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Evt),validChoice(Evt,Tm))|

---

## Value ISO20022.Camt004001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt004001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt004001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt004001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt004001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Enum ISO20022.Camt004001.Frequency2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OVNG|Int32||XmlEnum("""OVNG""")|1|
||INDA|Int32||XmlEnum("""INDA""")|2|
||ADHO|Int32||XmlEnum("""ADHO""")|3|
||DAIL|Int32||XmlEnum("""DAIL""")|4|
||WEEK|Int32||XmlEnum("""WEEK""")|5|
||MIAN|Int32||XmlEnum("""MIAN""")|6|
||QURT|Int32||XmlEnum("""QURT""")|7|
||MNTH|Int32||XmlEnum("""MNTH""")|8|
||YEAR|Int32||XmlEnum("""YEAR""")|9|

---

## Value ISO20022.Camt004001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt004001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt004001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt004001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt004001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt004001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt004001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt004001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt004001.GenericPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt004001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt004001.Limit5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt004001.Amount2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Camt004001.MessageHeader7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QryNm|String||XmlElement()||
|+|OrgnlBizQry|ISO20022.Camt004001.OriginalBusinessQuery1||XmlElement()||
|+|ReqTp|ISO20022.Camt004001.RequestType4Choice||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlBizQry),validElement(ReqTp))|

---

## Enum ISO20022.Camt004001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Camt004001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt004001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt004001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt004001.OriginalBusinessQuery1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgNmId|String||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt004001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt004001.Party52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Camt004001.PersonIdentification18||XmlElement()||
|+|OrgId|ISO20022.Camt004001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Camt004001.PartyIdentification272


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Camt004001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Camt004001.Party52Choice||XmlElement()||
|+|PstlAdr|ISO20022.Camt004001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Camt004001.PersonIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt004001.GenericPersonIdentification2>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Camt004001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Camt004001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt004001.PostalAddress27


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
|+|AdrTp|ISO20022.Camt004001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Camt004001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Value ISO20022.Camt004001.ProcessingType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt004001.ProcessingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSDB|Int32||XmlEnum("""CSDB""")|1|
||COLD|Int32||XmlEnum("""COLD""")|2|
||DLVR|Int32||XmlEnum("""DLVR""")|3|
||EFAC|Int32||XmlEnum("""EFAC""")|4|
||EARM|Int32||XmlEnum("""EARM""")|5|
||BLCK|Int32||XmlEnum("""BLCK""")|6|
||RSVT|Int32||XmlEnum("""RSVT""")|7|
||CVHD|Int32||XmlEnum("""CVHD""")|8|
||RJCT|Int32||XmlEnum("""RJCT""")|9|

---

## Value ISO20022.Camt004001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Camt004001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt004001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt004001.RequestType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt004001.GenericIdentification1||XmlElement()||
|+|Enqry|String||XmlElement()||
|+|PmtCtrl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Enqry,PmtCtrl))|

---

## Aspect ISO20022.Camt004001.ReturnAccountV10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt004001.SupplementaryData1>||XmlElement()||
|+|RptOrErr|ISO20022.Camt004001.AccountOrOperationalError6Choice||XmlElement()||
|+|MsgHdr|ISO20022.Camt004001.MessageHeader7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))|

---

## Value ISO20022.Camt004001.StandingOrder11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ZeroSweepInd|String||XmlElement()||
|+|TtlsPerStgOrdr|ISO20022.Camt004001.StandingOrderTotalAmount1||XmlElement()||
|+|DbtrAcct|ISO20022.Camt004001.CashAccount40||XmlElement()||
|+|Dbtr|ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|CdtrAcct|ISO20022.Camt004001.CashAccount40||XmlElement()||
|+|Cdtr|ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|ExctnTp|ISO20022.Camt004001.ExecutionType1Choice||XmlElement()||
|+|LkSetOrdrSeq|Decimal||XmlElement()||
|+|LkSetOrdrId|String||XmlElement()||
|+|LkSetId|String||XmlElement()||
|+|RspnsblPty|ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|SysMmb|ISO20022.Camt004001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|VldtyPrd|ISO20022.Camt004001.DatePeriod3||XmlElement()||
|+|Frqcy|String||XmlElement()||
|+|Ref|String||XmlElement()||
|+|AssoctdPoolAcct|ISO20022.Camt004001.AccountIdentification4Choice||XmlElement()||
|+|Tp|ISO20022.Camt004001.StandingOrderType1Choice||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt004001.Amount2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlsPerStgOrdr),validElement(DbtrAcct),validElement(Dbtr),validElement(CdtrAcct),validElement(Cdtr),validElement(ExctnTp),validElement(RspnsblPty),validElement(SysMmb),validElement(VldtyPrd),validElement(AssoctdPoolAcct),validElement(Tp),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Amt))|

---

## Value ISO20022.Camt004001.StandingOrderTotalAmount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PdgStgOrdr|ISO20022.Camt004001.TotalAmountAndCurrency1||XmlElement()||
|+|SetStgOrdr|ISO20022.Camt004001.TotalAmountAndCurrency1||XmlElement()||
|+|PdgPrdfndOrdr|ISO20022.Camt004001.TotalAmountAndCurrency1||XmlElement()||
|+|SetPrdfndOrdr|ISO20022.Camt004001.TotalAmountAndCurrency1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PdgStgOrdr),validElement(SetStgOrdr),validElement(PdgPrdfndOrdr),validElement(SetPrdfndOrdr))|

---

## Value ISO20022.Camt004001.StandingOrderType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt004001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt004001.StandingOrderType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PSTO|Int32||XmlEnum("""PSTO""")|1|
||USTO|Int32||XmlEnum("""USTO""")|2|

---

## Value ISO20022.Camt004001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt004001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt004001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Camt004001.SystemBalanceType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AIDR|Int32||XmlEnum("""AIDR""")|1|
||ADWR|Int32||XmlEnum("""ADWR""")|2|
||DWRD|Int32||XmlEnum("""DWRD""")|3|
||IRDR|Int32||XmlEnum("""IRDR""")|4|
||IRLT|Int32||XmlEnum("""IRLT""")|5|
||SAPP|Int32||XmlEnum("""SAPP""")|6|
||BSCC|Int32||XmlEnum("""BSCC""")|7|
||BSCD|Int32||XmlEnum("""BSCD""")|8|
||REPC|Int32||XmlEnum("""REPC""")|9|
||REPD|Int32||XmlEnum("""REPD""")|10|
||SAPC|Int32||XmlEnum("""SAPC""")|11|
||SAPD|Int32||XmlEnum("""SAPD""")|12|
||OTCN|Int32||XmlEnum("""OTCN""")|13|
||OTCG|Int32||XmlEnum("""OTCG""")|14|
||OTCC|Int32||XmlEnum("""OTCC""")|15|
||NSET|Int32||XmlEnum("""NSET""")|16|
||LACK|Int32||XmlEnum("""LACK""")|17|
||DSET|Int32||XmlEnum("""DSET""")|18|
||XCHN|Int32||XmlEnum("""XCHN""")|19|
||XCHC|Int32||XmlEnum("""XCHC""")|20|
||CUSA|Int32||XmlEnum("""CUSA""")|21|
||SCOU|Int32||XmlEnum("""SCOU""")|22|
||SCOL|Int32||XmlEnum("""SCOL""")|23|
||FCOU|Int32||XmlEnum("""FCOU""")|24|
||FCOL|Int32||XmlEnum("""FCOL""")|25|
||REJB|Int32||XmlEnum("""REJB""")|26|
||FUTB|Int32||XmlEnum("""FUTB""")|27|
||DPBL|Int32||XmlEnum("""DPBL""")|28|
||CPBL|Int32||XmlEnum("""CPBL""")|29|
||TPBL|Int32||XmlEnum("""TPBL""")|30|
||DOHB|Int32||XmlEnum("""DOHB""")|31|
||COHB|Int32||XmlEnum("""COHB""")|32|
||TOHB|Int32||XmlEnum("""TOHB""")|33|
||CCPS|Int32||XmlEnum("""CCPS""")|34|
||XCHG|Int32||XmlEnum("""XCHG""")|35|
||PIPO|Int32||XmlEnum("""PIPO""")|36|
||FUND|Int32||XmlEnum("""FUND""")|37|
||COLC|Int32||XmlEnum("""COLC""")|38|
||FORC|Int32||XmlEnum("""FORC""")|39|
||CUST|Int32||XmlEnum("""CUST""")|40|
||OTHB|Int32||XmlEnum("""OTHB""")|41|
||BLOC|Int32||XmlEnum("""BLOC""")|42|
||FSET|Int32||XmlEnum("""FSET""")|43|
||NOTE|Int32||XmlEnum("""NOTE""")|44|
||THRE|Int32||XmlEnum("""THRE""")|45|
||DBIT|Int32||XmlEnum("""DBIT""")|46|
||PRAV|Int32||XmlEnum("""PRAV""")|47|
||ADJT|Int32||XmlEnum("""ADJT""")|48|
||XDBT|Int32||XmlEnum("""XDBT""")|49|
||XCRD|Int32||XmlEnum("""XCRD""")|50|
||DLOD|Int32||XmlEnum("""DLOD""")|51|
||XPCD|Int32||XmlEnum("""XPCD""")|52|
||BLCK|Int32||XmlEnum("""BLCK""")|53|
||PYMT|Int32||XmlEnum("""PYMT""")|54|
||EAST|Int32||XmlEnum("""EAST""")|55|
||CRDT|Int32||XmlEnum("""CRDT""")|56|
||LTSF|Int32||XmlEnum("""LTSF""")|57|
||AVLB|Int32||XmlEnum("""AVLB""")|58|
||LRLD|Int32||XmlEnum("""LRLD""")|59|
||PDNG|Int32||XmlEnum("""PDNG""")|60|
||CRRT|Int32||XmlEnum("""CRRT""")|61|
||BOOK|Int32||XmlEnum("""BOOK""")|62|
||CLSG|Int32||XmlEnum("""CLSG""")|63|
||INTM|Int32||XmlEnum("""INTM""")|64|
||OPNG|Int32||XmlEnum("""OPNG""")|65|

---

## Value ISO20022.Camt004001.TotalAmountAndCurrency1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|TtlAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

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

