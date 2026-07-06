# auth.021.001.04
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Auth021001.AccountIdentification4Choice {
        + Othr  : ISO20022.Auth021001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Auth021001.AccountIdentification4Choice *-- ISO20022.Auth021001.GenericAccountIdentification1
    class ISO20022.Auth021001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth021001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Auth021001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Auth021001.AddressType3Choice {
        + Prtry  : ISO20022.Auth021001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Auth021001.AddressType3Choice *-- ISO20022.Auth021001.GenericIdentification30
    class ISO20022.Auth021001.BenchmarkCurveName2Code {
        BBSW = 1
        BUBO = 2
        CDOR = 3
        CIBO = 4
        EONA = 5
        EONS = 6
        EURI = 7
        EUUS = 8
        EUCH = 9
        FUSW = 10
        GCFR = 11
        ISDA = 12
        JIBA = 13
        LIBI = 14
        LIBO = 15
        MOSP = 16
        MAAA = 17
        NIBO = 18
        PFAN = 19
        PRBO = 20
        STBO = 21
        SWAP = 22
        TLBO = 23
        TIBO = 24
        TREA = 25
        WIBO = 26
    }
    class ISO20022.Auth021001.BenchmarkCurveName4Choice {
        + Nm  : String
        + Indx  : String
        + ISIN  : String
    }
    class ISO20022.Auth021001.BinaryFile1 {
        + InclBinryObjct  : String
        + CharSet  : String
        + NcodgTp  : String
        + MIMETp  : String
    }
    class ISO20022.Auth021001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Auth021001.BranchData5
        + FinInstnId  : ISO20022.Auth021001.FinancialInstitutionIdentification23
    }
    ISO20022.Auth021001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Auth021001.BranchData5
    ISO20022.Auth021001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Auth021001.FinancialInstitutionIdentification23
    class ISO20022.Auth021001.BranchData5 {
        + PstlAdr  : ISO20022.Auth021001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Auth021001.BranchData5 *-- ISO20022.Auth021001.PostalAddress27
    class ISO20022.Auth021001.CashCollateral5 {
        + Hrcut  : Decimal
        + CollVal  : ISO20022.Auth021001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + ValDt  : DateTime
        + MtrtyDt  : DateTime
        + DpstTp  : String
        + DpstAmt  : ISO20022.Auth021001.ActiveCurrencyAndAmount
        + AsstNb  : String
        + CshAcctId  : ISO20022.Auth021001.AccountIdentification4Choice
        + CollId  : String
    }
    ISO20022.Auth021001.CashCollateral5 *-- ISO20022.Auth021001.ActiveCurrencyAndAmount
    ISO20022.Auth021001.CashCollateral5 *-- ISO20022.Auth021001.ActiveCurrencyAndAmount
    ISO20022.Auth021001.CashCollateral5 *-- ISO20022.Auth021001.AccountIdentification4Choice
    class ISO20022.Auth021001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth021001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Auth021001.ClearingSystemIdentification2Choice
    }
    ISO20022.Auth021001.ClearingSystemMemberIdentification2 *-- ISO20022.Auth021001.ClearingSystemIdentification2Choice
    class ISO20022.Auth021001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Auth021001.OtherContact1~
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
    ISO20022.Auth021001.Contact13 *-- ISO20022.Auth021001.OtherContact1
    class ISO20022.Auth021001.ContractBalance1 {
        + CdtDbtInd  : String
        + Amt  : ISO20022.Auth021001.ActiveCurrencyAndAmount
        + Tp  : ISO20022.Auth021001.ContractBalanceType1Choice
    }
    ISO20022.Auth021001.ContractBalance1 *-- ISO20022.Auth021001.ActiveCurrencyAndAmount
    ISO20022.Auth021001.ContractBalance1 *-- ISO20022.Auth021001.ContractBalanceType1Choice
    class ISO20022.Auth021001.ContractBalanceType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth021001.ContractCollateral1 {
        + AddtlInf  : String
        + CollDesc  : global::System.Collections.Generic.List~ISO20022.Auth021001.CashCollateral5~
        + TtlAmt  : ISO20022.Auth021001.ActiveCurrencyAndAmount
    }
    ISO20022.Auth021001.ContractCollateral1 *-- ISO20022.Auth021001.CashCollateral5
    ISO20022.Auth021001.ContractCollateral1 *-- ISO20022.Auth021001.ActiveCurrencyAndAmount
    class ISO20022.Auth021001.ContractRegistrationAmendmentRequestV04 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth021001.SupplementaryData1~
        + CtrctRegnAmdmnt  : global::System.Collections.Generic.List~ISO20022.Auth021001.RegisteredContract16~
        + GrpHdr  : ISO20022.Auth021001.CurrencyControlHeader8
    }
    ISO20022.Auth021001.ContractRegistrationAmendmentRequestV04 *-- ISO20022.Auth021001.SupplementaryData1
    ISO20022.Auth021001.ContractRegistrationAmendmentRequestV04 *-- ISO20022.Auth021001.RegisteredContract16
    ISO20022.Auth021001.ContractRegistrationAmendmentRequestV04 *-- ISO20022.Auth021001.CurrencyControlHeader8
    class ISO20022.Auth021001.CreditDebit3Code {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Auth021001.CurrencyControlHeader8 {
        + FwdgAgt  : ISO20022.Auth021001.BranchAndFinancialInstitutionIdentification8
        + InitgPty  : ISO20022.Auth021001.PartyIdentification272
        + NbOfItms  : String
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Auth021001.CurrencyControlHeader8 *-- ISO20022.Auth021001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Auth021001.CurrencyControlHeader8 *-- ISO20022.Auth021001.PartyIdentification272
    class ISO20022.Auth021001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Auth021001.DepositType1Code {
        CALL = 1
        FITE = 2
    }
    class ISO20022.Auth021001.DocumentGeneralInformation5 {
        + AttchdBinryFile  : ISO20022.Auth021001.BinaryFile1
        + LkFileHash  : ISO20022.Auth021001.SignatureEnvelopeReference
        + URL  : String
        + IsseDt  : DateTime
        + SndrRcvrSeqId  : String
        + DocNm  : String
        + DocNb  : String
        + DocTp  : String
    }
    ISO20022.Auth021001.DocumentGeneralInformation5 *-- ISO20022.Auth021001.BinaryFile1
    ISO20022.Auth021001.DocumentGeneralInformation5 *-- ISO20022.Auth021001.SignatureEnvelopeReference
    class ISO20022.Auth021001.DocumentIdentification22 {
        + DtOfIsse  : DateTime
        + Id  : String
    }
    class ISO20022.Auth021001.ExchangeRate1 {
        + CtrctId  : String
        + RateTp  : String
        + XchgRate  : Decimal
        + UnitCcy  : String
    }
    class ISO20022.Auth021001.ExchangeRateType1Code {
        AGRD = 1
        SALE = 2
        SPOT = 3
    }
    class ISO20022.Auth021001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth021001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Auth021001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Auth021001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Auth021001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Auth021001.FinancialInstitutionIdentification23 *-- ISO20022.Auth021001.GenericFinancialIdentification1
    ISO20022.Auth021001.FinancialInstitutionIdentification23 *-- ISO20022.Auth021001.PostalAddress27
    ISO20022.Auth021001.FinancialInstitutionIdentification23 *-- ISO20022.Auth021001.ClearingSystemMemberIdentification2
    class ISO20022.Auth021001.FloatingInterestRate4 {
        + BsisPtSprd  : Decimal
        + Term  : ISO20022.Auth021001.InterestRateContractTerm1
        + RefRate  : ISO20022.Auth021001.BenchmarkCurveName4Choice
    }
    ISO20022.Auth021001.FloatingInterestRate4 *-- ISO20022.Auth021001.InterestRateContractTerm1
    ISO20022.Auth021001.FloatingInterestRate4 *-- ISO20022.Auth021001.BenchmarkCurveName4Choice
    class ISO20022.Auth021001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Auth021001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Auth021001.GenericAccountIdentification1 *-- ISO20022.Auth021001.AccountSchemeName1Choice
    class ISO20022.Auth021001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Auth021001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Auth021001.GenericFinancialIdentification1 *-- ISO20022.Auth021001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Auth021001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Auth021001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Auth021001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Auth021001.GenericOrganisationIdentification3 *-- ISO20022.Auth021001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Auth021001.GenericPersonIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Auth021001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Auth021001.GenericPersonIdentification2 *-- ISO20022.Auth021001.PersonIdentificationSchemeName1Choice
    class ISO20022.Auth021001.InterestPaymentDateRange1 {
        + DueDt  : DateTime
        + XpctdDt  : DateTime
        + IntrstSchdlId  : String
    }
    class ISO20022.Auth021001.InterestPaymentSchedule1 {
        + AddtlInf  : String
        + DueDt  : DateTime
        + XpctdDt  : DateTime
        + Amt  : ISO20022.Auth021001.ActiveCurrencyAndAmount
        + IntrstSchdlId  : String
    }
    ISO20022.Auth021001.InterestPaymentSchedule1 *-- ISO20022.Auth021001.ActiveCurrencyAndAmount
    class ISO20022.Auth021001.InterestRate2Choice {
        + Fltg  : ISO20022.Auth021001.FloatingInterestRate4
        + Fxd  : Decimal
    }
    ISO20022.Auth021001.InterestRate2Choice *-- ISO20022.Auth021001.FloatingInterestRate4
    class ISO20022.Auth021001.InterestRateContractTerm1 {
        + Val  : Decimal
        + Unit  : String
    }
    class ISO20022.Auth021001.LegalOrganisation2 {
        + RegnDt  : DateTime
        + EstblishmtDt  : DateTime
        + Nm  : String
        + Id  : String
    }
    class ISO20022.Auth021001.LoanContract4 {
        + Attchmnt  : global::System.Collections.Generic.List~ISO20022.Auth021001.DocumentGeneralInformation5~
        + SndctdLn  : global::System.Collections.Generic.List~ISO20022.Auth021001.SyndicatedLoan3~
        + Coll  : ISO20022.Auth021001.ContractCollateral1
        + IntraCpnyLn  : String
        + IntrstSchdl  : global::System.Collections.Generic.List~ISO20022.Auth021001.InterestPaymentSchedule1~
        + PmtSchdl  : global::System.Collections.Generic.List~ISO20022.Auth021001.PaymentSchedule1~
        + Trch  : global::System.Collections.Generic.List~ISO20022.Auth021001.LoanContractTranche1~
        + IntrstRate  : ISO20022.Auth021001.InterestRate2Choice
        + DrtnCd  : String
        + SpclConds  : ISO20022.Auth021001.SpecialCondition1
        + SttlmCcy  : String
        + StartDt  : DateTime
        + PrlngtnFlg  : String
        + MtrtyDt  : DateTime
        + Amt  : ISO20022.Auth021001.ActiveCurrencyAndAmount
        + Sellr  : global::System.Collections.Generic.List~ISO20022.Auth021001.TradeParty6~
        + Buyr  : global::System.Collections.Generic.List~ISO20022.Auth021001.TradeParty6~
        + LnTpId  : String
        + CtrctDocId  : ISO20022.Auth021001.DocumentIdentification22
    }
    ISO20022.Auth021001.LoanContract4 *-- ISO20022.Auth021001.DocumentGeneralInformation5
    ISO20022.Auth021001.LoanContract4 *-- ISO20022.Auth021001.SyndicatedLoan3
    ISO20022.Auth021001.LoanContract4 *-- ISO20022.Auth021001.ContractCollateral1
    ISO20022.Auth021001.LoanContract4 *-- ISO20022.Auth021001.InterestPaymentSchedule1
    ISO20022.Auth021001.LoanContract4 *-- ISO20022.Auth021001.PaymentSchedule1
    ISO20022.Auth021001.LoanContract4 *-- ISO20022.Auth021001.LoanContractTranche1
    ISO20022.Auth021001.LoanContract4 *-- ISO20022.Auth021001.InterestRate2Choice
    ISO20022.Auth021001.LoanContract4 *-- ISO20022.Auth021001.SpecialCondition1
    ISO20022.Auth021001.LoanContract4 *-- ISO20022.Auth021001.ActiveCurrencyAndAmount
    ISO20022.Auth021001.LoanContract4 *-- ISO20022.Auth021001.TradeParty6
    ISO20022.Auth021001.LoanContract4 *-- ISO20022.Auth021001.TradeParty6
    ISO20022.Auth021001.LoanContract4 *-- ISO20022.Auth021001.DocumentIdentification22
    class ISO20022.Auth021001.LoanContractTranche1 {
        + LastTrchInd  : String
        + DrtnCd  : String
        + DueDt  : DateTime
        + Amt  : ISO20022.Auth021001.ActiveCurrencyAndAmount
        + XpctdDt  : DateTime
        + TrchNb  : Decimal
    }
    ISO20022.Auth021001.LoanContractTranche1 *-- ISO20022.Auth021001.ActiveCurrencyAndAmount
    class ISO20022.Auth021001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Auth021001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Auth021001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Auth021001.OrganisationIdentification39 *-- ISO20022.Auth021001.GenericOrganisationIdentification3
    class ISO20022.Auth021001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth021001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Auth021001.Party52Choice {
        + PrvtId  : ISO20022.Auth021001.PersonIdentification18
        + OrgId  : ISO20022.Auth021001.OrganisationIdentification39
    }
    ISO20022.Auth021001.Party52Choice *-- ISO20022.Auth021001.PersonIdentification18
    ISO20022.Auth021001.Party52Choice *-- ISO20022.Auth021001.OrganisationIdentification39
    class ISO20022.Auth021001.PartyIdentification272 {
        + CtctDtls  : ISO20022.Auth021001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Auth021001.Party52Choice
        + PstlAdr  : ISO20022.Auth021001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Auth021001.PartyIdentification272 *-- ISO20022.Auth021001.Contact13
    ISO20022.Auth021001.PartyIdentification272 *-- ISO20022.Auth021001.Party52Choice
    ISO20022.Auth021001.PartyIdentification272 *-- ISO20022.Auth021001.PostalAddress27
    class ISO20022.Auth021001.PaymentSchedule1 {
        + AddtlInf  : String
        + DueDt  : DateTime
        + XpctdDt  : DateTime
        + Amt  : ISO20022.Auth021001.ActiveCurrencyAndAmount
        + PmtSchdlId  : String
    }
    ISO20022.Auth021001.PaymentSchedule1 *-- ISO20022.Auth021001.ActiveCurrencyAndAmount
    class ISO20022.Auth021001.PaymentScheduleType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth021001.PaymentScheduleType2Code {
        BOTH = 1
        ESTM = 2
        CNTR = 3
    }
    class ISO20022.Auth021001.PersonIdentification18 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Auth021001.GenericPersonIdentification2~
        + DtAndPlcOfBirth  : ISO20022.Auth021001.DateAndPlaceOfBirth1
    }
    ISO20022.Auth021001.PersonIdentification18 *-- ISO20022.Auth021001.GenericPersonIdentification2
    ISO20022.Auth021001.PersonIdentification18 *-- ISO20022.Auth021001.DateAndPlaceOfBirth1
    class ISO20022.Auth021001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Auth021001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Auth021001.AddressType3Choice
    }
    ISO20022.Auth021001.PostalAddress27 *-- ISO20022.Auth021001.AddressType3Choice
    class ISO20022.Auth021001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Auth021001.Priority2Code {
        NORM = 1
        HIGH = 2
    }
    class ISO20022.Auth021001.RateBasis1Code {
        YEAR = 1
        WEEK = 2
        MNTH = 3
        DAYS = 4
    }
    class ISO20022.Auth021001.RegisteredContract16 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth021001.SupplementaryData1~
        + RegdCtrctAmdmnt  : global::System.Collections.Generic.List~ISO20022.Auth021001.RegisteredContract17~
        + RegnAgt  : ISO20022.Auth021001.BranchAndFinancialInstitutionIdentification8
        + RptgPty  : ISO20022.Auth021001.TradeParty6
        + CtrctRegnAmdmntId  : String
    }
    ISO20022.Auth021001.RegisteredContract16 *-- ISO20022.Auth021001.SupplementaryData1
    ISO20022.Auth021001.RegisteredContract16 *-- ISO20022.Auth021001.RegisteredContract17
    ISO20022.Auth021001.RegisteredContract16 *-- ISO20022.Auth021001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Auth021001.RegisteredContract16 *-- ISO20022.Auth021001.TradeParty6
    class ISO20022.Auth021001.RegisteredContract17 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Auth021001.SupplementaryData1~
        + Attchmnt  : global::System.Collections.Generic.List~ISO20022.Auth021001.DocumentGeneralInformation5~
        + AddtlInf  : String
        + PmtSchdlTp  : ISO20022.Auth021001.PaymentScheduleType2Choice
        + CtrctBal  : global::System.Collections.Generic.List~ISO20022.Auth021001.ContractBalance1~
        + Ctrct  : ISO20022.Auth021001.UnderlyingContract4Choice
        + Prty  : String
        + OrgnlRegdCtrctId  : String
        + RegdCtrctAmdmntId  : String
    }
    ISO20022.Auth021001.RegisteredContract17 *-- ISO20022.Auth021001.SupplementaryData1
    ISO20022.Auth021001.RegisteredContract17 *-- ISO20022.Auth021001.DocumentGeneralInformation5
    ISO20022.Auth021001.RegisteredContract17 *-- ISO20022.Auth021001.PaymentScheduleType2Choice
    ISO20022.Auth021001.RegisteredContract17 *-- ISO20022.Auth021001.ContractBalance1
    ISO20022.Auth021001.RegisteredContract17 *-- ISO20022.Auth021001.UnderlyingContract4Choice
    class ISO20022.Auth021001.ShipmentDateRange1 {
        + LatstShipmntDt  : DateTime
        + EarlstShipmntDt  : DateTime
    }
    class ISO20022.Auth021001.ShipmentDateRange2 {
        + LatstShipmntDt  : DateTime
        + EarlstShipmntDt  : DateTime
        + SubQtyVal  : Decimal
    }
    class ISO20022.Auth021001.ShipmentSchedule2Choice {
        + ShipmntSubSchdl  : global::System.Collections.Generic.List~ISO20022.Auth021001.ShipmentDateRange2~
        + ShipmntDtRg  : ISO20022.Auth021001.ShipmentDateRange1
    }
    ISO20022.Auth021001.ShipmentSchedule2Choice *-- ISO20022.Auth021001.ShipmentDateRange2
    ISO20022.Auth021001.ShipmentSchedule2Choice *-- ISO20022.Auth021001.ShipmentDateRange1
    class ISO20022.Auth021001.SignatureEnvelopeReference {
    }
    class ISO20022.Auth021001.SpecialCondition1 {
        + PmtFrOthrAcct  : ISO20022.Auth021001.ActiveCurrencyAndAmount
        + IncmgAmtToOthrAcct  : ISO20022.Auth021001.ActiveCurrencyAndAmount
        + OutgngAmt  : ISO20022.Auth021001.ActiveCurrencyAndAmount
        + IncmgAmt  : ISO20022.Auth021001.ActiveCurrencyAndAmount
    }
    ISO20022.Auth021001.SpecialCondition1 *-- ISO20022.Auth021001.ActiveCurrencyAndAmount
    ISO20022.Auth021001.SpecialCondition1 *-- ISO20022.Auth021001.ActiveCurrencyAndAmount
    ISO20022.Auth021001.SpecialCondition1 *-- ISO20022.Auth021001.ActiveCurrencyAndAmount
    ISO20022.Auth021001.SpecialCondition1 *-- ISO20022.Auth021001.ActiveCurrencyAndAmount
    class ISO20022.Auth021001.SupplementaryData1 {
        + Envlp  : ISO20022.Auth021001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Auth021001.SupplementaryData1 *-- ISO20022.Auth021001.SupplementaryDataEnvelope1
    class ISO20022.Auth021001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Auth021001.SyndicatedLoan3 {
        + XchgRateInf  : ISO20022.Auth021001.ExchangeRate1
        + Shr  : Decimal
        + Amt  : ISO20022.Auth021001.ActiveCurrencyAndAmount
        + Lndr  : ISO20022.Auth021001.TradeParty6
        + Brrwr  : ISO20022.Auth021001.TradeParty6
    }
    ISO20022.Auth021001.SyndicatedLoan3 *-- ISO20022.Auth021001.ExchangeRate1
    ISO20022.Auth021001.SyndicatedLoan3 *-- ISO20022.Auth021001.ActiveCurrencyAndAmount
    ISO20022.Auth021001.SyndicatedLoan3 *-- ISO20022.Auth021001.TradeParty6
    ISO20022.Auth021001.SyndicatedLoan3 *-- ISO20022.Auth021001.TradeParty6
    class ISO20022.Auth021001.TaxExemptReason1Code {
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
    class ISO20022.Auth021001.TaxExemptionReasonFormat1Choice {
        + Strd  : String
        + Ustrd  : String
    }
    class ISO20022.Auth021001.TaxParty4 {
        + TaxXmptnRsn  : global::System.Collections.Generic.List~ISO20022.Auth021001.TaxExemptionReasonFormat1Choice~
        + RegnId  : String
        + TaxTp  : String
        + TaxId  : String
    }
    ISO20022.Auth021001.TaxParty4 *-- ISO20022.Auth021001.TaxExemptionReasonFormat1Choice
    class ISO20022.Auth021001.TradeContract4 {
        + Attchmnt  : global::System.Collections.Generic.List~ISO20022.Auth021001.DocumentGeneralInformation5~
        + ShipmntSchdl  : ISO20022.Auth021001.ShipmentSchedule2Choice
        + PmtSchdl  : ISO20022.Auth021001.InterestPaymentDateRange1
        + XchgRateInf  : ISO20022.Auth021001.ExchangeRate1
        + SttlmCcy  : String
        + StartDt  : DateTime
        + PrlngtnFlg  : String
        + MtrtyDt  : DateTime
        + Sellr  : global::System.Collections.Generic.List~ISO20022.Auth021001.TradeParty6~
        + Buyr  : global::System.Collections.Generic.List~ISO20022.Auth021001.TradeParty6~
        + Amt  : ISO20022.Auth021001.ActiveCurrencyAndAmount
        + TradTpId  : String
        + CtrctDocId  : ISO20022.Auth021001.DocumentIdentification22
    }
    ISO20022.Auth021001.TradeContract4 *-- ISO20022.Auth021001.DocumentGeneralInformation5
    ISO20022.Auth021001.TradeContract4 *-- ISO20022.Auth021001.ShipmentSchedule2Choice
    ISO20022.Auth021001.TradeContract4 *-- ISO20022.Auth021001.InterestPaymentDateRange1
    ISO20022.Auth021001.TradeContract4 *-- ISO20022.Auth021001.ExchangeRate1
    ISO20022.Auth021001.TradeContract4 *-- ISO20022.Auth021001.TradeParty6
    ISO20022.Auth021001.TradeContract4 *-- ISO20022.Auth021001.TradeParty6
    ISO20022.Auth021001.TradeContract4 *-- ISO20022.Auth021001.ActiveCurrencyAndAmount
    ISO20022.Auth021001.TradeContract4 *-- ISO20022.Auth021001.DocumentIdentification22
    class ISO20022.Auth021001.TradeParty6 {
        + TaxPty  : global::System.Collections.Generic.List~ISO20022.Auth021001.TaxParty4~
        + LglOrg  : ISO20022.Auth021001.LegalOrganisation2
        + PtyId  : ISO20022.Auth021001.PartyIdentification272
    }
    ISO20022.Auth021001.TradeParty6 *-- ISO20022.Auth021001.TaxParty4
    ISO20022.Auth021001.TradeParty6 *-- ISO20022.Auth021001.LegalOrganisation2
    ISO20022.Auth021001.TradeParty6 *-- ISO20022.Auth021001.PartyIdentification272
    class ISO20022.Auth021001.UnderlyingContract4Choice {
        + Trad  : ISO20022.Auth021001.TradeContract4
        + Ln  : ISO20022.Auth021001.LoanContract4
    }
    ISO20022.Auth021001.UnderlyingContract4Choice *-- ISO20022.Auth021001.TradeContract4
    ISO20022.Auth021001.UnderlyingContract4Choice *-- ISO20022.Auth021001.LoanContract4
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

## Value ISO20022.Auth021001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth021001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Auth021001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth021001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Auth021001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Auth021001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Auth021001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Auth021001.BenchmarkCurveName2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BBSW|Int32||XmlEnum("""BBSW""")|1|
||BUBO|Int32||XmlEnum("""BUBO""")|2|
||CDOR|Int32||XmlEnum("""CDOR""")|3|
||CIBO|Int32||XmlEnum("""CIBO""")|4|
||EONA|Int32||XmlEnum("""EONA""")|5|
||EONS|Int32||XmlEnum("""EONS""")|6|
||EURI|Int32||XmlEnum("""EURI""")|7|
||EUUS|Int32||XmlEnum("""EUUS""")|8|
||EUCH|Int32||XmlEnum("""EUCH""")|9|
||FUSW|Int32||XmlEnum("""FUSW""")|10|
||GCFR|Int32||XmlEnum("""GCFR""")|11|
||ISDA|Int32||XmlEnum("""ISDA""")|12|
||JIBA|Int32||XmlEnum("""JIBA""")|13|
||LIBI|Int32||XmlEnum("""LIBI""")|14|
||LIBO|Int32||XmlEnum("""LIBO""")|15|
||MOSP|Int32||XmlEnum("""MOSP""")|16|
||MAAA|Int32||XmlEnum("""MAAA""")|17|
||NIBO|Int32||XmlEnum("""NIBO""")|18|
||PFAN|Int32||XmlEnum("""PFAN""")|19|
||PRBO|Int32||XmlEnum("""PRBO""")|20|
||STBO|Int32||XmlEnum("""STBO""")|21|
||SWAP|Int32||XmlEnum("""SWAP""")|22|
||TLBO|Int32||XmlEnum("""TLBO""")|23|
||TIBO|Int32||XmlEnum("""TIBO""")|24|
||TREA|Int32||XmlEnum("""TREA""")|25|
||WIBO|Int32||XmlEnum("""WIBO""")|26|

---

## Value ISO20022.Auth021001.BenchmarkCurveName4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Indx|String||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""),validChoice(Nm,Indx,ISIN))|

---

## Value ISO20022.Auth021001.BinaryFile1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InclBinryObjct|String||XmlElement()||
|+|CharSet|String||XmlElement()||
|+|NcodgTp|String||XmlElement()||
|+|MIMETp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth021001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Auth021001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Auth021001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Auth021001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Auth021001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Auth021001.CashCollateral5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Hrcut|Decimal||XmlElement()||
|+|CollVal|ISO20022.Auth021001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|DpstTp|String||XmlElement()||
|+|DpstAmt|ISO20022.Auth021001.ActiveCurrencyAndAmount||XmlElement()||
|+|AsstNb|String||XmlElement()||
|+|CshAcctId|ISO20022.Auth021001.AccountIdentification4Choice||XmlElement()||
|+|CollId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollVal),validElement(DpstAmt),validElement(CshAcctId))|

---

## Value ISO20022.Auth021001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth021001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Auth021001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Auth021001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Auth021001.OtherContact1>||XmlElement()||
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

## Value ISO20022.Auth021001.ContractBalance1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Auth021001.ActiveCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Auth021001.ContractBalanceType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Tp))|

---

## Value ISO20022.Auth021001.ContractBalanceType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth021001.ContractCollateral1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|CollDesc|global::System.Collections.Generic.List<ISO20022.Auth021001.CashCollateral5>||XmlElement()||
|+|TtlAmt|ISO20022.Auth021001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CollDesc""",CollDesc),validElement(CollDesc),validElement(TtlAmt))|

---

## Aspect ISO20022.Auth021001.ContractRegistrationAmendmentRequestV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth021001.SupplementaryData1>||XmlElement()||
|+|CtrctRegnAmdmnt|global::System.Collections.Generic.List<ISO20022.Auth021001.RegisteredContract16>||XmlElement()||
|+|GrpHdr|ISO20022.Auth021001.CurrencyControlHeader8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""CtrctRegnAmdmnt""",CtrctRegnAmdmnt),validList("""CtrctRegnAmdmnt""",CtrctRegnAmdmnt),validElement(CtrctRegnAmdmnt),validElement(GrpHdr))|

---

## Enum ISO20022.Auth021001.CreditDebit3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Auth021001.CurrencyControlHeader8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FwdgAgt|ISO20022.Auth021001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InitgPty|ISO20022.Auth021001.PartyIdentification272||XmlElement()||
|+|NbOfItms|String||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FwdgAgt),validElement(InitgPty),validPattern("""NbOfItms""",NbOfItms,"""[0-9]{1,15}"""))|

---

## Value ISO20022.Auth021001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Enum ISO20022.Auth021001.DepositType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CALL|Int32||XmlEnum("""CALL""")|1|
||FITE|Int32||XmlEnum("""FITE""")|2|

---

## Type ISO20022.Auth021001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrctRegnAmdmntReq|ISO20022.Auth021001.ContractRegistrationAmendmentRequestV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrctRegnAmdmntReq))|

---

## Value ISO20022.Auth021001.DocumentGeneralInformation5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AttchdBinryFile|ISO20022.Auth021001.BinaryFile1||XmlElement()||
|+|LkFileHash|ISO20022.Auth021001.SignatureEnvelopeReference||XmlElement()||
|+|URL|String||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|SndrRcvrSeqId|String||XmlElement()||
|+|DocNm|String||XmlElement()||
|+|DocNb|String||XmlElement()||
|+|DocTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AttchdBinryFile),validElement(LkFileHash))|

---

## Value ISO20022.Auth021001.DocumentIdentification22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtOfIsse|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth021001.ExchangeRate1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrctId|String||XmlElement()||
|+|RateTp|String||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Auth021001.ExchangeRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGRD|Int32||XmlEnum("""AGRD""")|1|
||SALE|Int32||XmlEnum("""SALE""")|2|
||SPOT|Int32||XmlEnum("""SPOT""")|3|

---

## Value ISO20022.Auth021001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth021001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Auth021001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Auth021001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Auth021001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Auth021001.FloatingInterestRate4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BsisPtSprd|Decimal||XmlElement()||
|+|Term|ISO20022.Auth021001.InterestRateContractTerm1||XmlElement()||
|+|RefRate|ISO20022.Auth021001.BenchmarkCurveName4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Term),validElement(RefRate))|

---

## Value ISO20022.Auth021001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Auth021001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Auth021001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Auth021001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Auth021001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Auth021001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Auth021001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Auth021001.GenericPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Auth021001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Auth021001.InterestPaymentDateRange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DueDt|DateTime||XmlElement()||
|+|XpctdDt|DateTime||XmlElement()||
|+|IntrstSchdlId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth021001.InterestPaymentSchedule1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|DueDt|DateTime||XmlElement()||
|+|XpctdDt|DateTime||XmlElement()||
|+|Amt|ISO20022.Auth021001.ActiveCurrencyAndAmount||XmlElement()||
|+|IntrstSchdlId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth021001.InterestRate2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Fltg|ISO20022.Auth021001.FloatingInterestRate4||XmlElement()||
|+|Fxd|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Fltg),validChoice(Fltg,Fxd))|

---

## Value ISO20022.Auth021001.InterestRateContractTerm1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|Decimal||XmlElement()||
|+|Unit|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth021001.LegalOrganisation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDt|DateTime||XmlElement()||
|+|EstblishmtDt|DateTime||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth021001.LoanContract4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Attchmnt|global::System.Collections.Generic.List<ISO20022.Auth021001.DocumentGeneralInformation5>||XmlElement()||
|+|SndctdLn|global::System.Collections.Generic.List<ISO20022.Auth021001.SyndicatedLoan3>||XmlElement()||
|+|Coll|ISO20022.Auth021001.ContractCollateral1||XmlElement()||
|+|IntraCpnyLn|String||XmlElement()||
|+|IntrstSchdl|global::System.Collections.Generic.List<ISO20022.Auth021001.InterestPaymentSchedule1>||XmlElement()||
|+|PmtSchdl|global::System.Collections.Generic.List<ISO20022.Auth021001.PaymentSchedule1>||XmlElement()||
|+|Trch|global::System.Collections.Generic.List<ISO20022.Auth021001.LoanContractTranche1>||XmlElement()||
|+|IntrstRate|ISO20022.Auth021001.InterestRate2Choice||XmlElement()||
|+|DrtnCd|String||XmlElement()||
|+|SpclConds|ISO20022.Auth021001.SpecialCondition1||XmlElement()||
|+|SttlmCcy|String||XmlElement()||
|+|StartDt|DateTime||XmlElement()||
|+|PrlngtnFlg|String||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|Amt|ISO20022.Auth021001.ActiveCurrencyAndAmount||XmlElement()||
|+|Sellr|global::System.Collections.Generic.List<ISO20022.Auth021001.TradeParty6>||XmlElement()||
|+|Buyr|global::System.Collections.Generic.List<ISO20022.Auth021001.TradeParty6>||XmlElement()||
|+|LnTpId|String||XmlElement()||
|+|CtrctDocId|ISO20022.Auth021001.DocumentIdentification22||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Attchmnt""",Attchmnt),validElement(Attchmnt),validList("""SndctdLn""",SndctdLn),validElement(SndctdLn),validElement(Coll),validList("""IntrstSchdl""",IntrstSchdl),validElement(IntrstSchdl),validList("""PmtSchdl""",PmtSchdl),validElement(PmtSchdl),validList("""Trch""",Trch),validElement(Trch),validElement(IntrstRate),validPattern("""DrtnCd""",DrtnCd,"""[0-9]"""),validElement(SpclConds),validPattern("""SttlmCcy""",SttlmCcy,"""[A-Z]{3,3}"""),validElement(Amt),validRequired("""Sellr""",Sellr),validList("""Sellr""",Sellr),validElement(Sellr),validRequired("""Buyr""",Buyr),validList("""Buyr""",Buyr),validElement(Buyr),validElement(CtrctDocId))|

---

## Value ISO20022.Auth021001.LoanContractTranche1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastTrchInd|String||XmlElement()||
|+|DrtnCd|String||XmlElement()||
|+|DueDt|DateTime||XmlElement()||
|+|Amt|ISO20022.Auth021001.ActiveCurrencyAndAmount||XmlElement()||
|+|XpctdDt|DateTime||XmlElement()||
|+|TrchNb|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DrtnCd""",DrtnCd,"""[0-9]"""),validElement(Amt))|

---

## Enum ISO20022.Auth021001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Auth021001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Auth021001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Auth021001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth021001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth021001.Party52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Auth021001.PersonIdentification18||XmlElement()||
|+|OrgId|ISO20022.Auth021001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Auth021001.PartyIdentification272


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Auth021001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Auth021001.Party52Choice||XmlElement()||
|+|PstlAdr|ISO20022.Auth021001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Auth021001.PaymentSchedule1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|DueDt|DateTime||XmlElement()||
|+|XpctdDt|DateTime||XmlElement()||
|+|Amt|ISO20022.Auth021001.ActiveCurrencyAndAmount||XmlElement()||
|+|PmtSchdlId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Auth021001.PaymentScheduleType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Auth021001.PaymentScheduleType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOTH|Int32||XmlEnum("""BOTH""")|1|
||ESTM|Int32||XmlEnum("""ESTM""")|2|
||CNTR|Int32||XmlEnum("""CNTR""")|3|

---

## Value ISO20022.Auth021001.PersonIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Auth021001.GenericPersonIdentification2>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Auth021001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Auth021001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Auth021001.PostalAddress27


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
|+|AdrTp|ISO20022.Auth021001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Auth021001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Enum ISO20022.Auth021001.Priority2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORM|Int32||XmlEnum("""NORM""")|1|
||HIGH|Int32||XmlEnum("""HIGH""")|2|

---

## Enum ISO20022.Auth021001.RateBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YEAR|Int32||XmlEnum("""YEAR""")|1|
||WEEK|Int32||XmlEnum("""WEEK""")|2|
||MNTH|Int32||XmlEnum("""MNTH""")|3|
||DAYS|Int32||XmlEnum("""DAYS""")|4|

---

## Value ISO20022.Auth021001.RegisteredContract16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth021001.SupplementaryData1>||XmlElement()||
|+|RegdCtrctAmdmnt|global::System.Collections.Generic.List<ISO20022.Auth021001.RegisteredContract17>||XmlElement()||
|+|RegnAgt|ISO20022.Auth021001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|RptgPty|ISO20022.Auth021001.TradeParty6||XmlElement()||
|+|CtrctRegnAmdmntId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""RegdCtrctAmdmnt""",RegdCtrctAmdmnt),validList("""RegdCtrctAmdmnt""",RegdCtrctAmdmnt),validElement(RegdCtrctAmdmnt),validElement(RegnAgt),validElement(RptgPty))|

---

## Value ISO20022.Auth021001.RegisteredContract17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Auth021001.SupplementaryData1>||XmlElement()||
|+|Attchmnt|global::System.Collections.Generic.List<ISO20022.Auth021001.DocumentGeneralInformation5>||XmlElement()||
|+|AddtlInf|String||XmlElement()||
|+|PmtSchdlTp|ISO20022.Auth021001.PaymentScheduleType2Choice||XmlElement()||
|+|CtrctBal|global::System.Collections.Generic.List<ISO20022.Auth021001.ContractBalance1>||XmlElement()||
|+|Ctrct|ISO20022.Auth021001.UnderlyingContract4Choice||XmlElement()||
|+|Prty|String||XmlElement()||
|+|OrgnlRegdCtrctId|String||XmlElement()||
|+|RegdCtrctAmdmntId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""Attchmnt""",Attchmnt),validElement(Attchmnt),validElement(PmtSchdlTp),validList("""CtrctBal""",CtrctBal),validElement(CtrctBal),validElement(Ctrct))|

---

## Value ISO20022.Auth021001.ShipmentDateRange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LatstShipmntDt|DateTime||XmlElement()||
|+|EarlstShipmntDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth021001.ShipmentDateRange2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LatstShipmntDt|DateTime||XmlElement()||
|+|EarlstShipmntDt|DateTime||XmlElement()||
|+|SubQtyVal|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth021001.ShipmentSchedule2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ShipmntSubSchdl|global::System.Collections.Generic.List<ISO20022.Auth021001.ShipmentDateRange2>||XmlElement()||
|+|ShipmntDtRg|ISO20022.Auth021001.ShipmentDateRange1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""ShipmntSubSchdl""",ShipmntSubSchdl),validListMin("""ShipmntSubSchdl""",ShipmntSubSchdl,2),validElement(ShipmntSubSchdl),validElement(ShipmntDtRg),validChoice(ShipmntSubSchdl,ShipmntDtRg))|

---

## Value ISO20022.Auth021001.SignatureEnvelopeReference


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth021001.SpecialCondition1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtFrOthrAcct|ISO20022.Auth021001.ActiveCurrencyAndAmount||XmlElement()||
|+|IncmgAmtToOthrAcct|ISO20022.Auth021001.ActiveCurrencyAndAmount||XmlElement()||
|+|OutgngAmt|ISO20022.Auth021001.ActiveCurrencyAndAmount||XmlElement()||
|+|IncmgAmt|ISO20022.Auth021001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtFrOthrAcct),validElement(IncmgAmtToOthrAcct),validElement(OutgngAmt),validElement(IncmgAmt))|

---

## Value ISO20022.Auth021001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Auth021001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Auth021001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Auth021001.SyndicatedLoan3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XchgRateInf|ISO20022.Auth021001.ExchangeRate1||XmlElement()||
|+|Shr|Decimal||XmlElement()||
|+|Amt|ISO20022.Auth021001.ActiveCurrencyAndAmount||XmlElement()||
|+|Lndr|ISO20022.Auth021001.TradeParty6||XmlElement()||
|+|Brrwr|ISO20022.Auth021001.TradeParty6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XchgRateInf),validElement(Amt),validElement(Lndr),validElement(Brrwr))|

---

## Enum ISO20022.Auth021001.TaxExemptReason1Code


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

## Value ISO20022.Auth021001.TaxExemptionReasonFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Strd|String||XmlElement()||
|+|Ustrd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Strd,Ustrd))|

---

## Value ISO20022.Auth021001.TaxParty4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxXmptnRsn|global::System.Collections.Generic.List<ISO20022.Auth021001.TaxExemptionReasonFormat1Choice>||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|TaxTp|String||XmlElement()||
|+|TaxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TaxXmptnRsn""",TaxXmptnRsn),validElement(TaxXmptnRsn))|

---

## Value ISO20022.Auth021001.TradeContract4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Attchmnt|global::System.Collections.Generic.List<ISO20022.Auth021001.DocumentGeneralInformation5>||XmlElement()||
|+|ShipmntSchdl|ISO20022.Auth021001.ShipmentSchedule2Choice||XmlElement()||
|+|PmtSchdl|ISO20022.Auth021001.InterestPaymentDateRange1||XmlElement()||
|+|XchgRateInf|ISO20022.Auth021001.ExchangeRate1||XmlElement()||
|+|SttlmCcy|String||XmlElement()||
|+|StartDt|DateTime||XmlElement()||
|+|PrlngtnFlg|String||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|Sellr|global::System.Collections.Generic.List<ISO20022.Auth021001.TradeParty6>||XmlElement()||
|+|Buyr|global::System.Collections.Generic.List<ISO20022.Auth021001.TradeParty6>||XmlElement()||
|+|Amt|ISO20022.Auth021001.ActiveCurrencyAndAmount||XmlElement()||
|+|TradTpId|String||XmlElement()||
|+|CtrctDocId|ISO20022.Auth021001.DocumentIdentification22||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Attchmnt""",Attchmnt),validElement(Attchmnt),validElement(ShipmntSchdl),validElement(PmtSchdl),validElement(XchgRateInf),validPattern("""SttlmCcy""",SttlmCcy,"""[A-Z]{3,3}"""),validRequired("""Sellr""",Sellr),validList("""Sellr""",Sellr),validElement(Sellr),validRequired("""Buyr""",Buyr),validList("""Buyr""",Buyr),validElement(Buyr),validElement(Amt),validElement(CtrctDocId))|

---

## Value ISO20022.Auth021001.TradeParty6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxPty|global::System.Collections.Generic.List<ISO20022.Auth021001.TaxParty4>||XmlElement()||
|+|LglOrg|ISO20022.Auth021001.LegalOrganisation2||XmlElement()||
|+|PtyId|ISO20022.Auth021001.PartyIdentification272||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TaxPty""",TaxPty),validElement(TaxPty),validElement(LglOrg),validElement(PtyId))|

---

## Value ISO20022.Auth021001.UnderlyingContract4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Trad|ISO20022.Auth021001.TradeContract4||XmlElement()||
|+|Ln|ISO20022.Auth021001.LoanContract4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Trad),validElement(Ln),validChoice(Trad,Ln))|

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

