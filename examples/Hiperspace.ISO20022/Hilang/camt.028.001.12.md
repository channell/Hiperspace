# camt.028.001.12
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt028001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt028001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt028001.AccountIdentification4Choice *-- ISO20022.Camt028001.GenericAccountIdentification1
    class ISO20022.Camt028001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt028001.AdditionalPaymentInformationV12 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt028001.SupplementaryData1~
        + Inf  : ISO20022.Camt028001.PaymentComplementaryInformation11
        + Undrlyg  : ISO20022.Camt028001.UnderlyingTransaction8Choice
        + Case  : ISO20022.Camt028001.Case6
        + Assgnmt  : ISO20022.Camt028001.CaseAssignment6
    }
    ISO20022.Camt028001.AdditionalPaymentInformationV12 *-- ISO20022.Camt028001.SupplementaryData1
    ISO20022.Camt028001.AdditionalPaymentInformationV12 *-- ISO20022.Camt028001.PaymentComplementaryInformation11
    ISO20022.Camt028001.AdditionalPaymentInformationV12 *-- ISO20022.Camt028001.UnderlyingTransaction8Choice
    ISO20022.Camt028001.AdditionalPaymentInformationV12 *-- ISO20022.Camt028001.Case6
    ISO20022.Camt028001.AdditionalPaymentInformationV12 *-- ISO20022.Camt028001.CaseAssignment6
    class ISO20022.Camt028001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt028001.AddressType3Choice {
        + Prtry  : ISO20022.Camt028001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt028001.AddressType3Choice *-- ISO20022.Camt028001.GenericIdentification30
    class ISO20022.Camt028001.AmendmentInformationDetails15 {
        + OrgnlTrckgDays  : String
        + OrgnlRsn  : ISO20022.Camt028001.MandateSetupReason1Choice
        + OrgnlFrqcy  : ISO20022.Camt028001.Frequency36Choice
        + OrgnlFnlColltnDt  : DateTime
        + OrgnlDbtrAgtAcct  : ISO20022.Camt028001.CashAccount40
        + OrgnlDbtrAgt  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + OrgnlDbtrAcct  : ISO20022.Camt028001.CashAccount40
        + OrgnlDbtr  : ISO20022.Camt028001.PartyIdentification272
        + OrgnlCdtrAgtAcct  : ISO20022.Camt028001.CashAccount40
        + OrgnlCdtrAgt  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + OrgnlCdtrSchmeId  : ISO20022.Camt028001.PartyIdentification272
        + OrgnlMndtId  : String
    }
    ISO20022.Camt028001.AmendmentInformationDetails15 *-- ISO20022.Camt028001.MandateSetupReason1Choice
    ISO20022.Camt028001.AmendmentInformationDetails15 *-- ISO20022.Camt028001.Frequency36Choice
    ISO20022.Camt028001.AmendmentInformationDetails15 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.AmendmentInformationDetails15 *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.AmendmentInformationDetails15 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.AmendmentInformationDetails15 *-- ISO20022.Camt028001.PartyIdentification272
    ISO20022.Camt028001.AmendmentInformationDetails15 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.AmendmentInformationDetails15 *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.AmendmentInformationDetails15 *-- ISO20022.Camt028001.PartyIdentification272
    class ISO20022.Camt028001.AmountType4Choice {
        + EqvtAmt  : ISO20022.Camt028001.EquivalentAmount2
        + InstdAmt  : ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt028001.AmountType4Choice *-- ISO20022.Camt028001.EquivalentAmount2
    ISO20022.Camt028001.AmountType4Choice *-- ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Camt028001.BranchData5
        + FinInstnId  : ISO20022.Camt028001.FinancialInstitutionIdentification23
    }
    ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt028001.BranchData5
    ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt028001.FinancialInstitutionIdentification23
    class ISO20022.Camt028001.BranchData5 {
        + PstlAdr  : ISO20022.Camt028001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt028001.BranchData5 *-- ISO20022.Camt028001.PostalAddress27
    class ISO20022.Camt028001.Case6 {
        + ReopCaseIndctn  : String
        + Cretr  : ISO20022.Camt028001.Party50Choice
        + Id  : String
    }
    ISO20022.Camt028001.Case6 *-- ISO20022.Camt028001.Party50Choice
    class ISO20022.Camt028001.CaseAssignment6 {
        + CreDtTm  : DateTime
        + Assgne  : ISO20022.Camt028001.Party50Choice
        + Assgnr  : ISO20022.Camt028001.Party50Choice
        + Id  : String
    }
    ISO20022.Camt028001.CaseAssignment6 *-- ISO20022.Camt028001.Party50Choice
    ISO20022.Camt028001.CaseAssignment6 *-- ISO20022.Camt028001.Party50Choice
    class ISO20022.Camt028001.CashAccount40 {
        + Prxy  : ISO20022.Camt028001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Camt028001.CashAccountType2Choice
        + Id  : ISO20022.Camt028001.AccountIdentification4Choice
    }
    ISO20022.Camt028001.CashAccount40 *-- ISO20022.Camt028001.ProxyAccountIdentification1
    ISO20022.Camt028001.CashAccount40 *-- ISO20022.Camt028001.CashAccountType2Choice
    ISO20022.Camt028001.CashAccount40 *-- ISO20022.Camt028001.AccountIdentification4Choice
    class ISO20022.Camt028001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.CategoryPurpose1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.ChargeBearerType1Code {
        SLEV = 1
        SHAR = 2
        CRED = 3
        DEBT = 4
    }
    class ISO20022.Camt028001.ClearingChannel2Code {
        BOOK = 1
        MPNS = 2
        RTNS = 3
        RTGS = 4
    }
    class ISO20022.Camt028001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.ClearingSystemIdentification3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt028001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt028001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt028001.ClearingSystemIdentification2Choice
    class ISO20022.Camt028001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt028001.OtherContact1~
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
    ISO20022.Camt028001.Contact13 *-- ISO20022.Camt028001.OtherContact1
    class ISO20022.Camt028001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Camt028001.CreditTransferMandateData1 {
        + Rsn  : ISO20022.Camt028001.MandateSetupReason1Choice
        + Frqcy  : ISO20022.Camt028001.Frequency36Choice
        + FnlPmtDt  : DateTime
        + FrstPmtDt  : DateTime
        + ElctrncSgntr  : String
        + DtOfVrfctn  : DateTime
        + DtOfSgntr  : DateTime
        + Tp  : ISO20022.Camt028001.MandateTypeInformation2
        + MndtId  : String
    }
    ISO20022.Camt028001.CreditTransferMandateData1 *-- ISO20022.Camt028001.MandateSetupReason1Choice
    ISO20022.Camt028001.CreditTransferMandateData1 *-- ISO20022.Camt028001.Frequency36Choice
    ISO20022.Camt028001.CreditTransferMandateData1 *-- ISO20022.Camt028001.MandateTypeInformation2
    class ISO20022.Camt028001.CreditorReferenceInformation3 {
        + Ref  : String
        + Tp  : ISO20022.Camt028001.CreditorReferenceType3
    }
    ISO20022.Camt028001.CreditorReferenceInformation3 *-- ISO20022.Camt028001.CreditorReferenceType3
    class ISO20022.Camt028001.CreditorReferenceType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.CreditorReferenceType3 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Camt028001.CreditorReferenceType2Choice
    }
    ISO20022.Camt028001.CreditorReferenceType3 *-- ISO20022.Camt028001.CreditorReferenceType2Choice
    class ISO20022.Camt028001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Camt028001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Camt028001.DateAndType1 {
        + Dt  : DateTime
        + Tp  : ISO20022.Camt028001.DateType2Choice
    }
    ISO20022.Camt028001.DateAndType1 *-- ISO20022.Camt028001.DateType2Choice
    class ISO20022.Camt028001.DatePeriod2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Camt028001.DateType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.DocumentAdjustment1 {
        + AddtlInf  : String
        + Rsn  : String
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt028001.DocumentAdjustment1 *-- ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt028001.DocumentAmount1 {
        + Amt  : ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
        + Tp  : ISO20022.Camt028001.DocumentAmountType1Choice
    }
    ISO20022.Camt028001.DocumentAmount1 *-- ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt028001.DocumentAmount1 *-- ISO20022.Camt028001.DocumentAmountType1Choice
    class ISO20022.Camt028001.DocumentAmountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.DocumentLineIdentification1 {
        + RltdDt  : DateTime
        + Nb  : String
        + Tp  : ISO20022.Camt028001.DocumentLineType1
    }
    ISO20022.Camt028001.DocumentLineIdentification1 *-- ISO20022.Camt028001.DocumentLineType1
    class ISO20022.Camt028001.DocumentLineInformation2 {
        + Amt  : ISO20022.Camt028001.RemittanceAmount4
        + Desc  : String
        + Id  : global::System.Collections.Generic.List~ISO20022.Camt028001.DocumentLineIdentification1~
    }
    ISO20022.Camt028001.DocumentLineInformation2 *-- ISO20022.Camt028001.RemittanceAmount4
    ISO20022.Camt028001.DocumentLineInformation2 *-- ISO20022.Camt028001.DocumentLineIdentification1
    class ISO20022.Camt028001.DocumentLineType1 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Camt028001.DocumentLineType1Choice
    }
    ISO20022.Camt028001.DocumentLineType1 *-- ISO20022.Camt028001.DocumentLineType1Choice
    class ISO20022.Camt028001.DocumentLineType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.DocumentType1 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Camt028001.DocumentType2Choice
    }
    ISO20022.Camt028001.DocumentType1 *-- ISO20022.Camt028001.DocumentType2Choice
    class ISO20022.Camt028001.DocumentType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.EquivalentAmount2 {
        + CcyOfTrf  : String
        + Amt  : ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt028001.EquivalentAmount2 *-- ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt028001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Camt028001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt028001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt028001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt028001.FinancialInstitutionIdentification23 *-- ISO20022.Camt028001.GenericFinancialIdentification1
    ISO20022.Camt028001.FinancialInstitutionIdentification23 *-- ISO20022.Camt028001.PostalAddress27
    ISO20022.Camt028001.FinancialInstitutionIdentification23 *-- ISO20022.Camt028001.ClearingSystemMemberIdentification2
    class ISO20022.Camt028001.Frequency36Choice {
        + PtInTm  : ISO20022.Camt028001.FrequencyAndMoment1
        + Prd  : ISO20022.Camt028001.FrequencyPeriod1
        + Tp  : String
    }
    ISO20022.Camt028001.Frequency36Choice *-- ISO20022.Camt028001.FrequencyAndMoment1
    ISO20022.Camt028001.Frequency36Choice *-- ISO20022.Camt028001.FrequencyPeriod1
    class ISO20022.Camt028001.Frequency6Code {
        FRTN = 1
        INDA = 2
        ADHO = 3
        DAIL = 4
        WEEK = 5
        MIAN = 6
        QURT = 7
        MNTH = 8
        YEAR = 9
    }
    class ISO20022.Camt028001.FrequencyAndMoment1 {
        + PtInTm  : String
        + Tp  : String
    }
    class ISO20022.Camt028001.FrequencyPeriod1 {
        + CntPerPrd  : Decimal
        + Tp  : String
    }
    class ISO20022.Camt028001.Garnishment4 {
        + MplyeeTermntnInd  : String
        + FmlyMdclInsrncInd  : String
        + RmtdAmt  : ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
        + Dt  : DateTime
        + RefNb  : String
        + GrnshmtAdmstr  : ISO20022.Camt028001.PartyIdentification272
        + Grnshee  : ISO20022.Camt028001.PartyIdentification272
        + Tp  : ISO20022.Camt028001.GarnishmentType1
    }
    ISO20022.Camt028001.Garnishment4 *-- ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt028001.Garnishment4 *-- ISO20022.Camt028001.PartyIdentification272
    ISO20022.Camt028001.Garnishment4 *-- ISO20022.Camt028001.PartyIdentification272
    ISO20022.Camt028001.Garnishment4 *-- ISO20022.Camt028001.GarnishmentType1
    class ISO20022.Camt028001.GarnishmentType1 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Camt028001.GarnishmentType1Choice
    }
    ISO20022.Camt028001.GarnishmentType1 *-- ISO20022.Camt028001.GarnishmentType1Choice
    class ISO20022.Camt028001.GarnishmentType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt028001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt028001.GenericAccountIdentification1 *-- ISO20022.Camt028001.AccountSchemeName1Choice
    class ISO20022.Camt028001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt028001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt028001.GenericFinancialIdentification1 *-- ISO20022.Camt028001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt028001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt028001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt028001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt028001.GenericOrganisationIdentification3 *-- ISO20022.Camt028001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Camt028001.GenericPersonIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt028001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt028001.GenericPersonIdentification2 *-- ISO20022.Camt028001.PersonIdentificationSchemeName1Choice
    class ISO20022.Camt028001.Instruction4Code {
        TELA = 1
        PHOA = 2
    }
    class ISO20022.Camt028001.InstructionForCreditorAgent3 {
        + InstrInf  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.InstructionForNextAgent1 {
        + InstrInf  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.LocalInstrument2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.MandateClassification1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.MandateClassification1Code {
        VARI = 1
        USGB = 2
        FIXE = 3
    }
    class ISO20022.Camt028001.MandateRelatedData3Choice {
        + CdtTrfMndt  : ISO20022.Camt028001.CreditTransferMandateData1
        + DrctDbtMndt  : ISO20022.Camt028001.MandateRelatedInformation16
    }
    ISO20022.Camt028001.MandateRelatedData3Choice *-- ISO20022.Camt028001.CreditTransferMandateData1
    ISO20022.Camt028001.MandateRelatedData3Choice *-- ISO20022.Camt028001.MandateRelatedInformation16
    class ISO20022.Camt028001.MandateRelatedInformation16 {
        + TrckgDays  : String
        + Rsn  : ISO20022.Camt028001.MandateSetupReason1Choice
        + Frqcy  : ISO20022.Camt028001.Frequency36Choice
        + FnlColltnDt  : DateTime
        + FrstColltnDt  : DateTime
        + ElctrncSgntr  : String
        + AmdmntInfDtls  : ISO20022.Camt028001.AmendmentInformationDetails15
        + AmdmntInd  : String
        + DtOfSgntr  : DateTime
        + MndtId  : String
    }
    ISO20022.Camt028001.MandateRelatedInformation16 *-- ISO20022.Camt028001.MandateSetupReason1Choice
    ISO20022.Camt028001.MandateRelatedInformation16 *-- ISO20022.Camt028001.Frequency36Choice
    ISO20022.Camt028001.MandateRelatedInformation16 *-- ISO20022.Camt028001.AmendmentInformationDetails15
    class ISO20022.Camt028001.MandateSetupReason1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.MandateTypeInformation2 {
        + Clssfctn  : ISO20022.Camt028001.MandateClassification1Choice
        + CtgyPurp  : ISO20022.Camt028001.CategoryPurpose1Choice
        + LclInstrm  : ISO20022.Camt028001.LocalInstrument2Choice
        + SvcLvl  : ISO20022.Camt028001.ServiceLevel8Choice
    }
    ISO20022.Camt028001.MandateTypeInformation2 *-- ISO20022.Camt028001.MandateClassification1Choice
    ISO20022.Camt028001.MandateTypeInformation2 *-- ISO20022.Camt028001.CategoryPurpose1Choice
    ISO20022.Camt028001.MandateTypeInformation2 *-- ISO20022.Camt028001.LocalInstrument2Choice
    ISO20022.Camt028001.MandateTypeInformation2 *-- ISO20022.Camt028001.ServiceLevel8Choice
    class ISO20022.Camt028001.NameAndAddress18 {
        + Adr  : ISO20022.Camt028001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Camt028001.NameAndAddress18 *-- ISO20022.Camt028001.PostalAddress27
    class ISO20022.Camt028001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Camt028001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt028001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Camt028001.OrganisationIdentification39 *-- ISO20022.Camt028001.GenericOrganisationIdentification3
    class ISO20022.Camt028001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.OriginalGroupInformation29 {
        + OrgnlCreDtTm  : DateTime
        + OrgnlMsgNmId  : String
        + OrgnlMsgId  : String
    }
    class ISO20022.Camt028001.OriginalTransactionReference42 {
        + Purp  : ISO20022.Camt028001.Purpose2Choice
        + UltmtCdtr  : ISO20022.Camt028001.Party50Choice
        + CdtrAcct  : ISO20022.Camt028001.CashAccount40
        + Cdtr  : ISO20022.Camt028001.Party50Choice
        + CdtrAgtAcct  : ISO20022.Camt028001.CashAccount40
        + CdtrAgt  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + DbtrAgtAcct  : ISO20022.Camt028001.CashAccount40
        + DbtrAgt  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + DbtrAcct  : ISO20022.Camt028001.CashAccount40
        + Dbtr  : ISO20022.Camt028001.Party50Choice
        + UltmtDbtr  : ISO20022.Camt028001.Party50Choice
        + RmtInf  : ISO20022.Camt028001.RemittanceInformation22
        + MndtRltdInf  : ISO20022.Camt028001.MandateRelatedData3Choice
        + PmtMtd  : String
        + PmtTpInf  : ISO20022.Camt028001.PaymentTypeInformation27
        + SttlmInf  : ISO20022.Camt028001.SettlementInstruction15
        + CdtrSchmeId  : ISO20022.Camt028001.PartyIdentification272
        + ReqdExctnDt  : ISO20022.Camt028001.DateAndDateTime2Choice
        + ReqdColltnDt  : DateTime
        + IntrBkSttlmDt  : DateTime
        + Amt  : ISO20022.Camt028001.AmountType4Choice
        + IntrBkSttlmAmt  : ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.Purpose2Choice
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.Party50Choice
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.Party50Choice
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.Party50Choice
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.Party50Choice
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.RemittanceInformation22
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.MandateRelatedData3Choice
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.PaymentTypeInformation27
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.SettlementInstruction15
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.PartyIdentification272
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.DateAndDateTime2Choice
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.AmountType4Choice
    ISO20022.Camt028001.OriginalTransactionReference42 *-- ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt028001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Camt028001.Party50Choice {
        + Agt  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + Pty  : ISO20022.Camt028001.PartyIdentification272
    }
    ISO20022.Camt028001.Party50Choice *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.Party50Choice *-- ISO20022.Camt028001.PartyIdentification272
    class ISO20022.Camt028001.Party52Choice {
        + PrvtId  : ISO20022.Camt028001.PersonIdentification18
        + OrgId  : ISO20022.Camt028001.OrganisationIdentification39
    }
    ISO20022.Camt028001.Party52Choice *-- ISO20022.Camt028001.PersonIdentification18
    ISO20022.Camt028001.Party52Choice *-- ISO20022.Camt028001.OrganisationIdentification39
    class ISO20022.Camt028001.PartyIdentification272 {
        + CtctDtls  : ISO20022.Camt028001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Camt028001.Party52Choice
        + PstlAdr  : ISO20022.Camt028001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Camt028001.PartyIdentification272 *-- ISO20022.Camt028001.Contact13
    ISO20022.Camt028001.PartyIdentification272 *-- ISO20022.Camt028001.Party52Choice
    ISO20022.Camt028001.PartyIdentification272 *-- ISO20022.Camt028001.PostalAddress27
    class ISO20022.Camt028001.PaymentComplementaryInformation11 {
        + RmtInf  : ISO20022.Camt028001.RemittanceInformation22
        + RltdRmtInf  : global::System.Collections.Generic.List~ISO20022.Camt028001.RemittanceLocation8~
        + InstrForCdtrAgt  : global::System.Collections.Generic.List~ISO20022.Camt028001.InstructionForCreditorAgent3~
        + InstrForNxtAgt  : global::System.Collections.Generic.List~ISO20022.Camt028001.InstructionForNextAgent1~
        + PrvsInstgAgt3Acct  : ISO20022.Camt028001.CashAccount40
        + PrvsInstgAgt3  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + PrvsInstgAgt2Acct  : ISO20022.Camt028001.CashAccount40
        + PrvsInstgAgt2  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + PrvsInstgAgt1Acct  : ISO20022.Camt028001.CashAccount40
        + PrvsInstgAgt1  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + InstrForDbtrAgt  : String
        + Purp  : ISO20022.Camt028001.Purpose2Choice
        + UltmtCdtr  : ISO20022.Camt028001.PartyIdentification272
        + CdtrAcct  : ISO20022.Camt028001.CashAccount40
        + Cdtr  : ISO20022.Camt028001.PartyIdentification272
        + CdtrAgtAcct  : ISO20022.Camt028001.CashAccount40
        + CdtrAgt  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + IntrmyAgt3Acct  : ISO20022.Camt028001.CashAccount40
        + IntrmyAgt3  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + IntrmyAgt2Acct  : ISO20022.Camt028001.CashAccount40
        + IntrmyAgt2  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + IntrmyAgt1Acct  : ISO20022.Camt028001.CashAccount40
        + IntrmyAgt1  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + SttlmInf  : ISO20022.Camt028001.SettlementInstruction15
        + DbtrAgtAcct  : ISO20022.Camt028001.CashAccount40
        + DbtrAgt  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + DbtrAcct  : ISO20022.Camt028001.CashAccount40
        + Dbtr  : ISO20022.Camt028001.PartyIdentification272
        + UltmtDbtr  : ISO20022.Camt028001.PartyIdentification272
        + ChrgBr  : String
        + IntrBkSttlmAmt  : ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
        + Amt  : ISO20022.Camt028001.AmountType4Choice
        + IntrBkSttlmDt  : DateTime
        + ReqdColltnDt  : DateTime
        + ReqdExctnDt  : ISO20022.Camt028001.DateAndDateTime2Choice
        + PmtTpInf  : ISO20022.Camt028001.PaymentTypeInformation27
        + TxId  : String
        + EndToEndId  : String
        + InstrId  : String
    }
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.RemittanceInformation22
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.RemittanceLocation8
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.InstructionForCreditorAgent3
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.InstructionForNextAgent1
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.Purpose2Choice
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.PartyIdentification272
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.PartyIdentification272
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.SettlementInstruction15
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.PartyIdentification272
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.PartyIdentification272
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.AmountType4Choice
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.DateAndDateTime2Choice
    ISO20022.Camt028001.PaymentComplementaryInformation11 *-- ISO20022.Camt028001.PaymentTypeInformation27
    class ISO20022.Camt028001.PaymentMethod4Code {
        TRA = 1
        DD = 2
        TRF = 3
        CHK = 4
    }
    class ISO20022.Camt028001.PaymentTypeInformation27 {
        + CtgyPurp  : ISO20022.Camt028001.CategoryPurpose1Choice
        + SeqTp  : String
        + LclInstrm  : ISO20022.Camt028001.LocalInstrument2Choice
        + SvcLvl  : global::System.Collections.Generic.List~ISO20022.Camt028001.ServiceLevel8Choice~
        + ClrChanl  : String
        + InstrPrty  : String
    }
    ISO20022.Camt028001.PaymentTypeInformation27 *-- ISO20022.Camt028001.CategoryPurpose1Choice
    ISO20022.Camt028001.PaymentTypeInformation27 *-- ISO20022.Camt028001.LocalInstrument2Choice
    ISO20022.Camt028001.PaymentTypeInformation27 *-- ISO20022.Camt028001.ServiceLevel8Choice
    class ISO20022.Camt028001.PersonIdentification18 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt028001.GenericPersonIdentification2~
        + DtAndPlcOfBirth  : ISO20022.Camt028001.DateAndPlaceOfBirth1
    }
    ISO20022.Camt028001.PersonIdentification18 *-- ISO20022.Camt028001.GenericPersonIdentification2
    ISO20022.Camt028001.PersonIdentification18 *-- ISO20022.Camt028001.DateAndPlaceOfBirth1
    class ISO20022.Camt028001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Camt028001.AddressType3Choice
    }
    ISO20022.Camt028001.PostalAddress27 *-- ISO20022.Camt028001.AddressType3Choice
    class ISO20022.Camt028001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Camt028001.Priority2Code {
        NORM = 1
        HIGH = 2
    }
    class ISO20022.Camt028001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Camt028001.ProxyAccountType1Choice
    }
    ISO20022.Camt028001.ProxyAccountIdentification1 *-- ISO20022.Camt028001.ProxyAccountType1Choice
    class ISO20022.Camt028001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.Purpose2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.ReferredDocumentInformation8 {
        + LineDtls  : global::System.Collections.Generic.List~ISO20022.Camt028001.DocumentLineInformation2~
        + RltdDt  : ISO20022.Camt028001.DateAndType1
        + Nb  : String
        + Tp  : ISO20022.Camt028001.DocumentType1
    }
    ISO20022.Camt028001.ReferredDocumentInformation8 *-- ISO20022.Camt028001.DocumentLineInformation2
    ISO20022.Camt028001.ReferredDocumentInformation8 *-- ISO20022.Camt028001.DateAndType1
    ISO20022.Camt028001.ReferredDocumentInformation8 *-- ISO20022.Camt028001.DocumentType1
    class ISO20022.Camt028001.RemittanceAmount4 {
        + AdjstmntAmtAndRsn  : global::System.Collections.Generic.List~ISO20022.Camt028001.DocumentAdjustment1~
        + RmtAmtAndTp  : global::System.Collections.Generic.List~ISO20022.Camt028001.DocumentAmount1~
    }
    ISO20022.Camt028001.RemittanceAmount4 *-- ISO20022.Camt028001.DocumentAdjustment1
    ISO20022.Camt028001.RemittanceAmount4 *-- ISO20022.Camt028001.DocumentAmount1
    class ISO20022.Camt028001.RemittanceInformation22 {
        + Strd  : global::System.Collections.Generic.List~ISO20022.Camt028001.StructuredRemittanceInformation18~
        + Ustrd  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Camt028001.RemittanceInformation22 *-- ISO20022.Camt028001.StructuredRemittanceInformation18
    class ISO20022.Camt028001.RemittanceLocation8 {
        + RmtLctnDtls  : global::System.Collections.Generic.List~ISO20022.Camt028001.RemittanceLocationData2~
        + RmtId  : String
    }
    ISO20022.Camt028001.RemittanceLocation8 *-- ISO20022.Camt028001.RemittanceLocationData2
    class ISO20022.Camt028001.RemittanceLocationData2 {
        + PstlAdr  : ISO20022.Camt028001.NameAndAddress18
        + ElctrncAdr  : String
        + Mtd  : String
    }
    ISO20022.Camt028001.RemittanceLocationData2 *-- ISO20022.Camt028001.NameAndAddress18
    class ISO20022.Camt028001.RemittanceLocationMethod2Code {
        SMSM = 1
        POST = 2
        EMAL = 3
        URID = 4
        EDIC = 5
        FAXI = 6
    }
    class ISO20022.Camt028001.SequenceType3Code {
        RPRE = 1
        OOFF = 2
        FNAL = 3
        RCUR = 4
        FRST = 5
    }
    class ISO20022.Camt028001.ServiceLevel8Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt028001.SettlementInstruction15 {
        + ThrdRmbrsmntAgtAcct  : ISO20022.Camt028001.CashAccount40
        + ThrdRmbrsmntAgt  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + InstdRmbrsmntAgtAcct  : ISO20022.Camt028001.CashAccount40
        + InstdRmbrsmntAgt  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + InstgRmbrsmntAgtAcct  : ISO20022.Camt028001.CashAccount40
        + InstgRmbrsmntAgt  : ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
        + ClrSys  : ISO20022.Camt028001.ClearingSystemIdentification3Choice
        + SttlmAcct  : ISO20022.Camt028001.CashAccount40
        + SttlmMtd  : String
    }
    ISO20022.Camt028001.SettlementInstruction15 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.SettlementInstruction15 *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.SettlementInstruction15 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.SettlementInstruction15 *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.SettlementInstruction15 *-- ISO20022.Camt028001.CashAccount40
    ISO20022.Camt028001.SettlementInstruction15 *-- ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt028001.SettlementInstruction15 *-- ISO20022.Camt028001.ClearingSystemIdentification3Choice
    ISO20022.Camt028001.SettlementInstruction15 *-- ISO20022.Camt028001.CashAccount40
    class ISO20022.Camt028001.SettlementMethod1Code {
        CLRG = 1
        COVE = 2
        INGA = 3
        INDA = 4
    }
    class ISO20022.Camt028001.StructuredRemittanceInformation18 {
        + AddtlRmtInf  : global::System.Collections.Generic.List~String~
        + GrnshmtRmt  : ISO20022.Camt028001.Garnishment4
        + TaxRmt  : ISO20022.Camt028001.TaxData1
        + Invcee  : ISO20022.Camt028001.PartyIdentification272
        + Invcr  : ISO20022.Camt028001.PartyIdentification272
        + CdtrRefInf  : ISO20022.Camt028001.CreditorReferenceInformation3
        + RfrdDocAmt  : ISO20022.Camt028001.RemittanceAmount4
        + RfrdDocInf  : global::System.Collections.Generic.List~ISO20022.Camt028001.ReferredDocumentInformation8~
    }
    ISO20022.Camt028001.StructuredRemittanceInformation18 *-- ISO20022.Camt028001.Garnishment4
    ISO20022.Camt028001.StructuredRemittanceInformation18 *-- ISO20022.Camt028001.TaxData1
    ISO20022.Camt028001.StructuredRemittanceInformation18 *-- ISO20022.Camt028001.PartyIdentification272
    ISO20022.Camt028001.StructuredRemittanceInformation18 *-- ISO20022.Camt028001.PartyIdentification272
    ISO20022.Camt028001.StructuredRemittanceInformation18 *-- ISO20022.Camt028001.CreditorReferenceInformation3
    ISO20022.Camt028001.StructuredRemittanceInformation18 *-- ISO20022.Camt028001.RemittanceAmount4
    ISO20022.Camt028001.StructuredRemittanceInformation18 *-- ISO20022.Camt028001.ReferredDocumentInformation8
    class ISO20022.Camt028001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt028001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt028001.SupplementaryData1 *-- ISO20022.Camt028001.SupplementaryDataEnvelope1
    class ISO20022.Camt028001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Camt028001.TaxAmount3 {
        + Dtls  : global::System.Collections.Generic.List~ISO20022.Camt028001.TaxRecordDetails3~
        + TtlAmt  : ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
        + TaxblBaseAmt  : ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
        + Rate  : Decimal
    }
    ISO20022.Camt028001.TaxAmount3 *-- ISO20022.Camt028001.TaxRecordDetails3
    ISO20022.Camt028001.TaxAmount3 *-- ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt028001.TaxAmount3 *-- ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt028001.TaxAuthorisation1 {
        + Nm  : String
        + Titl  : String
    }
    class ISO20022.Camt028001.TaxData1 {
        + Rcrd  : global::System.Collections.Generic.List~ISO20022.Camt028001.TaxRecord3~
        + SeqNb  : Decimal
        + Dt  : DateTime
        + TtlTaxAmt  : ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
        + TtlTaxblBaseAmt  : ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
        + Mtd  : String
        + RefNb  : String
        + AdmstnZone  : String
        + UltmtDbtr  : ISO20022.Camt028001.TaxParty2
        + Dbtr  : ISO20022.Camt028001.TaxParty2
        + Cdtr  : ISO20022.Camt028001.TaxParty1
    }
    ISO20022.Camt028001.TaxData1 *-- ISO20022.Camt028001.TaxRecord3
    ISO20022.Camt028001.TaxData1 *-- ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt028001.TaxData1 *-- ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt028001.TaxData1 *-- ISO20022.Camt028001.TaxParty2
    ISO20022.Camt028001.TaxData1 *-- ISO20022.Camt028001.TaxParty2
    ISO20022.Camt028001.TaxData1 *-- ISO20022.Camt028001.TaxParty1
    class ISO20022.Camt028001.TaxParty1 {
        + TaxTp  : String
        + RegnId  : String
        + TaxId  : String
    }
    class ISO20022.Camt028001.TaxParty2 {
        + Authstn  : ISO20022.Camt028001.TaxAuthorisation1
        + TaxTp  : String
        + RegnId  : String
        + TaxId  : String
    }
    ISO20022.Camt028001.TaxParty2 *-- ISO20022.Camt028001.TaxAuthorisation1
    class ISO20022.Camt028001.TaxPeriod3 {
        + FrToDt  : ISO20022.Camt028001.DatePeriod2
        + Tp  : String
        + Yr  : Int32
    }
    ISO20022.Camt028001.TaxPeriod3 *-- ISO20022.Camt028001.DatePeriod2
    class ISO20022.Camt028001.TaxRecord3 {
        + AddtlInf  : String
        + TaxAmt  : ISO20022.Camt028001.TaxAmount3
        + Prd  : ISO20022.Camt028001.TaxPeriod3
        + FrmsCd  : String
        + CertId  : String
        + DbtrSts  : String
        + CtgyDtls  : String
        + Ctgy  : String
        + Tp  : String
    }
    ISO20022.Camt028001.TaxRecord3 *-- ISO20022.Camt028001.TaxAmount3
    ISO20022.Camt028001.TaxRecord3 *-- ISO20022.Camt028001.TaxPeriod3
    class ISO20022.Camt028001.TaxRecordDetails3 {
        + Amt  : ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
        + Prd  : ISO20022.Camt028001.TaxPeriod3
    }
    ISO20022.Camt028001.TaxRecordDetails3 *-- ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt028001.TaxRecordDetails3 *-- ISO20022.Camt028001.TaxPeriod3
    class ISO20022.Camt028001.TaxRecordPeriod1Code {
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
    class ISO20022.Camt028001.UnderlyingGroupInformation1 {
        + OrgnlMsgDlvryChanl  : String
        + OrgnlCreDtTm  : DateTime
        + OrgnlMsgNmId  : String
        + OrgnlMsgId  : String
    }
    class ISO20022.Camt028001.UnderlyingPaymentInstruction9 {
        + OrgnlSvcLvl  : ISO20022.Camt028001.ServiceLevel8Choice
        + OrgnlTxRef  : ISO20022.Camt028001.OriginalTransactionReference42
        + ReqdColltnDt  : DateTime
        + ReqdExctnDt  : ISO20022.Camt028001.DateAndDateTime2Choice
        + OrgnlInstdAmt  : ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
        + OrgnlUETR  : String
        + OrgnlEndToEndId  : String
        + OrgnlInstrId  : String
        + OrgnlPmtInfId  : String
        + OrgnlGrpInf  : ISO20022.Camt028001.UnderlyingGroupInformation1
    }
    ISO20022.Camt028001.UnderlyingPaymentInstruction9 *-- ISO20022.Camt028001.ServiceLevel8Choice
    ISO20022.Camt028001.UnderlyingPaymentInstruction9 *-- ISO20022.Camt028001.OriginalTransactionReference42
    ISO20022.Camt028001.UnderlyingPaymentInstruction9 *-- ISO20022.Camt028001.DateAndDateTime2Choice
    ISO20022.Camt028001.UnderlyingPaymentInstruction9 *-- ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt028001.UnderlyingPaymentInstruction9 *-- ISO20022.Camt028001.UnderlyingGroupInformation1
    class ISO20022.Camt028001.UnderlyingPaymentTransaction8 {
        + OrgnlSvcLvl  : ISO20022.Camt028001.ServiceLevel8Choice
        + OrgnlTxRef  : ISO20022.Camt028001.OriginalTransactionReference42
        + OrgnlIntrBkSttlmDt  : DateTime
        + OrgnlIntrBkSttlmAmt  : ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
        + OrgnlUETR  : String
        + OrgnlTxId  : String
        + OrgnlEndToEndId  : String
        + OrgnlInstrId  : String
        + OrgnlGrpInf  : ISO20022.Camt028001.UnderlyingGroupInformation1
    }
    ISO20022.Camt028001.UnderlyingPaymentTransaction8 *-- ISO20022.Camt028001.ServiceLevel8Choice
    ISO20022.Camt028001.UnderlyingPaymentTransaction8 *-- ISO20022.Camt028001.OriginalTransactionReference42
    ISO20022.Camt028001.UnderlyingPaymentTransaction8 *-- ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt028001.UnderlyingPaymentTransaction8 *-- ISO20022.Camt028001.UnderlyingGroupInformation1
    class ISO20022.Camt028001.UnderlyingStatementEntry3 {
        + OrgnlUETR  : String
        + OrgnlNtryId  : String
        + OrgnlStmtId  : String
        + OrgnlGrpInf  : ISO20022.Camt028001.OriginalGroupInformation29
    }
    ISO20022.Camt028001.UnderlyingStatementEntry3 *-- ISO20022.Camt028001.OriginalGroupInformation29
    class ISO20022.Camt028001.UnderlyingTransaction8Choice {
        + StmtNtry  : ISO20022.Camt028001.UnderlyingStatementEntry3
        + IntrBk  : ISO20022.Camt028001.UnderlyingPaymentTransaction8
        + Initn  : ISO20022.Camt028001.UnderlyingPaymentInstruction9
    }
    ISO20022.Camt028001.UnderlyingTransaction8Choice *-- ISO20022.Camt028001.UnderlyingStatementEntry3
    ISO20022.Camt028001.UnderlyingTransaction8Choice *-- ISO20022.Camt028001.UnderlyingPaymentTransaction8
    ISO20022.Camt028001.UnderlyingTransaction8Choice *-- ISO20022.Camt028001.UnderlyingPaymentInstruction9
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

## Value ISO20022.Camt028001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt028001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt028001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Aspect ISO20022.Camt028001.AdditionalPaymentInformationV12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt028001.SupplementaryData1>||XmlElement()||
|+|Inf|ISO20022.Camt028001.PaymentComplementaryInformation11||XmlElement()||
|+|Undrlyg|ISO20022.Camt028001.UnderlyingTransaction8Choice||XmlElement()||
|+|Case|ISO20022.Camt028001.Case6||XmlElement()||
|+|Assgnmt|ISO20022.Camt028001.CaseAssignment6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Inf),validElement(Undrlyg),validElement(Case),validElement(Assgnmt))|

---

## Enum ISO20022.Camt028001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt028001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt028001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.AmendmentInformationDetails15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlTrckgDays|String||XmlElement()||
|+|OrgnlRsn|ISO20022.Camt028001.MandateSetupReason1Choice||XmlElement()||
|+|OrgnlFrqcy|ISO20022.Camt028001.Frequency36Choice||XmlElement()||
|+|OrgnlFnlColltnDt|DateTime||XmlElement()||
|+|OrgnlDbtrAgtAcct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|OrgnlDbtrAgt|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|OrgnlDbtrAcct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|OrgnlDbtr|ISO20022.Camt028001.PartyIdentification272||XmlElement()||
|+|OrgnlCdtrAgtAcct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|OrgnlCdtrAgt|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|OrgnlCdtrSchmeId|ISO20022.Camt028001.PartyIdentification272||XmlElement()||
|+|OrgnlMndtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""OrgnlTrckgDays""",OrgnlTrckgDays,"""[0-9]{2}"""),validElement(OrgnlRsn),validElement(OrgnlFrqcy),validElement(OrgnlDbtrAgtAcct),validElement(OrgnlDbtrAgt),validElement(OrgnlDbtrAcct),validElement(OrgnlDbtr),validElement(OrgnlCdtrAgtAcct),validElement(OrgnlCdtrAgt),validElement(OrgnlCdtrSchmeId))|

---

## Value ISO20022.Camt028001.AmountType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EqvtAmt|ISO20022.Camt028001.EquivalentAmount2||XmlElement()||
|+|InstdAmt|ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EqvtAmt),validElement(InstdAmt),validChoice(EqvtAmt,InstdAmt))|

---

## Value ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt028001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Camt028001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt028001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt028001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Camt028001.Case6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ReopCaseIndctn|String||XmlElement()||
|+|Cretr|ISO20022.Camt028001.Party50Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cretr))|

---

## Value ISO20022.Camt028001.CaseAssignment6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Assgne|ISO20022.Camt028001.Party50Choice||XmlElement()||
|+|Assgnr|ISO20022.Camt028001.Party50Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Assgne),validElement(Assgnr))|

---

## Value ISO20022.Camt028001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Camt028001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Camt028001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Camt028001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Camt028001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.CategoryPurpose1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt028001.ChargeBearerType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLEV|Int32||XmlEnum("""SLEV""")|1|
||SHAR|Int32||XmlEnum("""SHAR""")|2|
||CRED|Int32||XmlEnum("""CRED""")|3|
||DEBT|Int32||XmlEnum("""DEBT""")|4|

---

## Enum ISO20022.Camt028001.ClearingChannel2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOOK|Int32||XmlEnum("""BOOK""")|1|
||MPNS|Int32||XmlEnum("""MPNS""")|2|
||RTNS|Int32||XmlEnum("""RTNS""")|3|
||RTGS|Int32||XmlEnum("""RTGS""")|4|

---

## Value ISO20022.Camt028001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.ClearingSystemIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt028001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Camt028001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt028001.OtherContact1>||XmlElement()||
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

## Enum ISO20022.Camt028001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Camt028001.CreditTransferMandateData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|ISO20022.Camt028001.MandateSetupReason1Choice||XmlElement()||
|+|Frqcy|ISO20022.Camt028001.Frequency36Choice||XmlElement()||
|+|FnlPmtDt|DateTime||XmlElement()||
|+|FrstPmtDt|DateTime||XmlElement()||
|+|ElctrncSgntr|String||XmlElement()||
|+|DtOfVrfctn|DateTime||XmlElement()||
|+|DtOfSgntr|DateTime||XmlElement()||
|+|Tp|ISO20022.Camt028001.MandateTypeInformation2||XmlElement()||
|+|MndtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn),validElement(Frqcy),validElement(Tp))|

---

## Value ISO20022.Camt028001.CreditorReferenceInformation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|String||XmlElement()||
|+|Tp|ISO20022.Camt028001.CreditorReferenceType3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt028001.CreditorReferenceType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.CreditorReferenceType3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Camt028001.CreditorReferenceType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Camt028001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Camt028001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Camt028001.DateAndType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dt|DateTime||XmlElement()||
|+|Tp|ISO20022.Camt028001.DateType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt028001.DatePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt028001.DateType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Type ISO20022.Camt028001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlPmtInf|ISO20022.Camt028001.AdditionalPaymentInformationV12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlPmtInf))|

---

## Value ISO20022.Camt028001.DocumentAdjustment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Camt028001.DocumentAmount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Camt028001.DocumentAmountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Tp))|

---

## Value ISO20022.Camt028001.DocumentAmountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.DocumentLineIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltdDt|DateTime||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|ISO20022.Camt028001.DocumentLineType1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt028001.DocumentLineInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt028001.RemittanceAmount4||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Id|global::System.Collections.Generic.List<ISO20022.Camt028001.DocumentLineIdentification1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validRequired("""Id""",Id),validList("""Id""",Id),validElement(Id))|

---

## Value ISO20022.Camt028001.DocumentLineType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Camt028001.DocumentLineType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Camt028001.DocumentLineType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.DocumentType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Camt028001.DocumentType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Camt028001.DocumentType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.EquivalentAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyOfTrf|String||XmlElement()||
|+|Amt|ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CcyOfTrf""",CcyOfTrf,"""[A-Z]{3,3}"""),validElement(Amt))|

---

## Value ISO20022.Camt028001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt028001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt028001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt028001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt028001.Frequency36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtInTm|ISO20022.Camt028001.FrequencyAndMoment1||XmlElement()||
|+|Prd|ISO20022.Camt028001.FrequencyPeriod1||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtInTm),validElement(Prd),validChoice(PtInTm,Prd,Tp))|

---

## Enum ISO20022.Camt028001.Frequency6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FRTN|Int32||XmlEnum("""FRTN""")|1|
||INDA|Int32||XmlEnum("""INDA""")|2|
||ADHO|Int32||XmlEnum("""ADHO""")|3|
||DAIL|Int32||XmlEnum("""DAIL""")|4|
||WEEK|Int32||XmlEnum("""WEEK""")|5|
||MIAN|Int32||XmlEnum("""MIAN""")|6|
||QURT|Int32||XmlEnum("""QURT""")|7|
||MNTH|Int32||XmlEnum("""MNTH""")|8|
||YEAR|Int32||XmlEnum("""YEAR""")|9|

---

## Value ISO20022.Camt028001.FrequencyAndMoment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtInTm|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PtInTm""",PtInTm,"""[0-9]{2}"""))|

---

## Value ISO20022.Camt028001.FrequencyPeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CntPerPrd|Decimal||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt028001.Garnishment4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MplyeeTermntnInd|String||XmlElement()||
|+|FmlyMdclInsrncInd|String||XmlElement()||
|+|RmtdAmt|ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|GrnshmtAdmstr|ISO20022.Camt028001.PartyIdentification272||XmlElement()||
|+|Grnshee|ISO20022.Camt028001.PartyIdentification272||XmlElement()||
|+|Tp|ISO20022.Camt028001.GarnishmentType1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RmtdAmt),validElement(GrnshmtAdmstr),validElement(Grnshee),validElement(Tp))|

---

## Value ISO20022.Camt028001.GarnishmentType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Camt028001.GarnishmentType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Camt028001.GarnishmentType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt028001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt028001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt028001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt028001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt028001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt028001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt028001.GenericPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt028001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Enum ISO20022.Camt028001.Instruction4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TELA|Int32||XmlEnum("""TELA""")|1|
||PHOA|Int32||XmlEnum("""PHOA""")|2|

---

## Value ISO20022.Camt028001.InstructionForCreditorAgent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrInf|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt028001.InstructionForNextAgent1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrInf|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt028001.LocalInstrument2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.MandateClassification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt028001.MandateClassification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|
||USGB|Int32||XmlEnum("""USGB""")|2|
||FIXE|Int32||XmlEnum("""FIXE""")|3|

---

## Value ISO20022.Camt028001.MandateRelatedData3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtTrfMndt|ISO20022.Camt028001.CreditTransferMandateData1||XmlElement()||
|+|DrctDbtMndt|ISO20022.Camt028001.MandateRelatedInformation16||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtTrfMndt),validElement(DrctDbtMndt),validChoice(CdtTrfMndt,DrctDbtMndt))|

---

## Value ISO20022.Camt028001.MandateRelatedInformation16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrckgDays|String||XmlElement()||
|+|Rsn|ISO20022.Camt028001.MandateSetupReason1Choice||XmlElement()||
|+|Frqcy|ISO20022.Camt028001.Frequency36Choice||XmlElement()||
|+|FnlColltnDt|DateTime||XmlElement()||
|+|FrstColltnDt|DateTime||XmlElement()||
|+|ElctrncSgntr|String||XmlElement()||
|+|AmdmntInfDtls|ISO20022.Camt028001.AmendmentInformationDetails15||XmlElement()||
|+|AmdmntInd|String||XmlElement()||
|+|DtOfSgntr|DateTime||XmlElement()||
|+|MndtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TrckgDays""",TrckgDays,"""[0-9]{2}"""),validElement(Rsn),validElement(Frqcy),validElement(AmdmntInfDtls))|

---

## Value ISO20022.Camt028001.MandateSetupReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.MandateTypeInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Clssfctn|ISO20022.Camt028001.MandateClassification1Choice||XmlElement()||
|+|CtgyPurp|ISO20022.Camt028001.CategoryPurpose1Choice||XmlElement()||
|+|LclInstrm|ISO20022.Camt028001.LocalInstrument2Choice||XmlElement()||
|+|SvcLvl|ISO20022.Camt028001.ServiceLevel8Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Clssfctn),validElement(CtgyPurp),validElement(LclInstrm),validElement(SvcLvl))|

---

## Value ISO20022.Camt028001.NameAndAddress18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Camt028001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Camt028001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Camt028001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt028001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt028001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.OriginalGroupInformation29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlCreDtTm|DateTime||XmlElement()||
|+|OrgnlMsgNmId|String||XmlElement()||
|+|OrgnlMsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt028001.OriginalTransactionReference42


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Purp|ISO20022.Camt028001.Purpose2Choice||XmlElement()||
|+|UltmtCdtr|ISO20022.Camt028001.Party50Choice||XmlElement()||
|+|CdtrAcct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|Cdtr|ISO20022.Camt028001.Party50Choice||XmlElement()||
|+|CdtrAgtAcct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|CdtrAgt|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|DbtrAgtAcct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|DbtrAgt|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|DbtrAcct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|Dbtr|ISO20022.Camt028001.Party50Choice||XmlElement()||
|+|UltmtDbtr|ISO20022.Camt028001.Party50Choice||XmlElement()||
|+|RmtInf|ISO20022.Camt028001.RemittanceInformation22||XmlElement()||
|+|MndtRltdInf|ISO20022.Camt028001.MandateRelatedData3Choice||XmlElement()||
|+|PmtMtd|String||XmlElement()||
|+|PmtTpInf|ISO20022.Camt028001.PaymentTypeInformation27||XmlElement()||
|+|SttlmInf|ISO20022.Camt028001.SettlementInstruction15||XmlElement()||
|+|CdtrSchmeId|ISO20022.Camt028001.PartyIdentification272||XmlElement()||
|+|ReqdExctnDt|ISO20022.Camt028001.DateAndDateTime2Choice||XmlElement()||
|+|ReqdColltnDt|DateTime||XmlElement()||
|+|IntrBkSttlmDt|DateTime||XmlElement()||
|+|Amt|ISO20022.Camt028001.AmountType4Choice||XmlElement()||
|+|IntrBkSttlmAmt|ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Purp),validElement(UltmtCdtr),validElement(CdtrAcct),validElement(Cdtr),validElement(CdtrAgtAcct),validElement(CdtrAgt),validElement(DbtrAgtAcct),validElement(DbtrAgt),validElement(DbtrAcct),validElement(Dbtr),validElement(UltmtDbtr),validElement(RmtInf),validElement(MndtRltdInf),validElement(PmtTpInf),validElement(SttlmInf),validElement(CdtrSchmeId),validElement(ReqdExctnDt),validElement(Amt),validElement(IntrBkSttlmAmt))|

---

## Value ISO20022.Camt028001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt028001.Party50Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Agt|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Pty|ISO20022.Camt028001.PartyIdentification272||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Agt),validElement(Pty),validChoice(Agt,Pty))|

---

## Value ISO20022.Camt028001.Party52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Camt028001.PersonIdentification18||XmlElement()||
|+|OrgId|ISO20022.Camt028001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Camt028001.PartyIdentification272


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Camt028001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Camt028001.Party52Choice||XmlElement()||
|+|PstlAdr|ISO20022.Camt028001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Camt028001.PaymentComplementaryInformation11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RmtInf|ISO20022.Camt028001.RemittanceInformation22||XmlElement()||
|+|RltdRmtInf|global::System.Collections.Generic.List<ISO20022.Camt028001.RemittanceLocation8>||XmlElement()||
|+|InstrForCdtrAgt|global::System.Collections.Generic.List<ISO20022.Camt028001.InstructionForCreditorAgent3>||XmlElement()||
|+|InstrForNxtAgt|global::System.Collections.Generic.List<ISO20022.Camt028001.InstructionForNextAgent1>||XmlElement()||
|+|PrvsInstgAgt3Acct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|PrvsInstgAgt3|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|PrvsInstgAgt2Acct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|PrvsInstgAgt2|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|PrvsInstgAgt1Acct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|PrvsInstgAgt1|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InstrForDbtrAgt|String||XmlElement()||
|+|Purp|ISO20022.Camt028001.Purpose2Choice||XmlElement()||
|+|UltmtCdtr|ISO20022.Camt028001.PartyIdentification272||XmlElement()||
|+|CdtrAcct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|Cdtr|ISO20022.Camt028001.PartyIdentification272||XmlElement()||
|+|CdtrAgtAcct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|CdtrAgt|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrmyAgt3Acct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|IntrmyAgt3|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrmyAgt2Acct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|IntrmyAgt2|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrmyAgt1Acct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|IntrmyAgt1|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|SttlmInf|ISO20022.Camt028001.SettlementInstruction15||XmlElement()||
|+|DbtrAgtAcct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|DbtrAgt|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|DbtrAcct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|Dbtr|ISO20022.Camt028001.PartyIdentification272||XmlElement()||
|+|UltmtDbtr|ISO20022.Camt028001.PartyIdentification272||XmlElement()||
|+|ChrgBr|String||XmlElement()||
|+|IntrBkSttlmAmt|ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Amt|ISO20022.Camt028001.AmountType4Choice||XmlElement()||
|+|IntrBkSttlmDt|DateTime||XmlElement()||
|+|ReqdColltnDt|DateTime||XmlElement()||
|+|ReqdExctnDt|ISO20022.Camt028001.DateAndDateTime2Choice||XmlElement()||
|+|PmtTpInf|ISO20022.Camt028001.PaymentTypeInformation27||XmlElement()||
|+|TxId|String||XmlElement()||
|+|EndToEndId|String||XmlElement()||
|+|InstrId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RmtInf),validList("""RltdRmtInf""",RltdRmtInf),validListMax("""RltdRmtInf""",RltdRmtInf,10),validElement(RltdRmtInf),validList("""InstrForCdtrAgt""",InstrForCdtrAgt),validElement(InstrForCdtrAgt),validList("""InstrForNxtAgt""",InstrForNxtAgt),validElement(InstrForNxtAgt),validElement(PrvsInstgAgt3Acct),validElement(PrvsInstgAgt3),validElement(PrvsInstgAgt2Acct),validElement(PrvsInstgAgt2),validElement(PrvsInstgAgt1Acct),validElement(PrvsInstgAgt1),validElement(Purp),validElement(UltmtCdtr),validElement(CdtrAcct),validElement(Cdtr),validElement(CdtrAgtAcct),validElement(CdtrAgt),validElement(IntrmyAgt3Acct),validElement(IntrmyAgt3),validElement(IntrmyAgt2Acct),validElement(IntrmyAgt2),validElement(IntrmyAgt1Acct),validElement(IntrmyAgt1),validElement(SttlmInf),validElement(DbtrAgtAcct),validElement(DbtrAgt),validElement(DbtrAcct),validElement(Dbtr),validElement(UltmtDbtr),validElement(IntrBkSttlmAmt),validElement(Amt),validElement(ReqdExctnDt),validElement(PmtTpInf))|

---

## Enum ISO20022.Camt028001.PaymentMethod4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRA|Int32||XmlEnum("""TRA""")|1|
||DD|Int32||XmlEnum("""DD""")|2|
||TRF|Int32||XmlEnum("""TRF""")|3|
||CHK|Int32||XmlEnum("""CHK""")|4|

---

## Value ISO20022.Camt028001.PaymentTypeInformation27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtgyPurp|ISO20022.Camt028001.CategoryPurpose1Choice||XmlElement()||
|+|SeqTp|String||XmlElement()||
|+|LclInstrm|ISO20022.Camt028001.LocalInstrument2Choice||XmlElement()||
|+|SvcLvl|global::System.Collections.Generic.List<ISO20022.Camt028001.ServiceLevel8Choice>||XmlElement()||
|+|ClrChanl|String||XmlElement()||
|+|InstrPrty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtgyPurp),validElement(LclInstrm),validList("""SvcLvl""",SvcLvl),validElement(SvcLvl))|

---

## Value ISO20022.Camt028001.PersonIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt028001.GenericPersonIdentification2>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Camt028001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Camt028001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.PostalAddress27


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
|+|AdrTp|ISO20022.Camt028001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Camt028001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Enum ISO20022.Camt028001.Priority2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORM|Int32||XmlEnum("""NORM""")|1|
||HIGH|Int32||XmlEnum("""HIGH""")|2|

---

## Value ISO20022.Camt028001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Camt028001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt028001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.Purpose2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.ReferredDocumentInformation8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LineDtls|global::System.Collections.Generic.List<ISO20022.Camt028001.DocumentLineInformation2>||XmlElement()||
|+|RltdDt|ISO20022.Camt028001.DateAndType1||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|ISO20022.Camt028001.DocumentType1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LineDtls""",LineDtls),validElement(LineDtls),validElement(RltdDt),validElement(Tp))|

---

## Value ISO20022.Camt028001.RemittanceAmount4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdjstmntAmtAndRsn|global::System.Collections.Generic.List<ISO20022.Camt028001.DocumentAdjustment1>||XmlElement()||
|+|RmtAmtAndTp|global::System.Collections.Generic.List<ISO20022.Camt028001.DocumentAmount1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AdjstmntAmtAndRsn""",AdjstmntAmtAndRsn),validElement(AdjstmntAmtAndRsn),validList("""RmtAmtAndTp""",RmtAmtAndTp),validElement(RmtAmtAndTp))|

---

## Value ISO20022.Camt028001.RemittanceInformation22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Strd|global::System.Collections.Generic.List<ISO20022.Camt028001.StructuredRemittanceInformation18>||XmlElement()||
|+|Ustrd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Strd""",Strd),validElement(Strd))|

---

## Value ISO20022.Camt028001.RemittanceLocation8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RmtLctnDtls|global::System.Collections.Generic.List<ISO20022.Camt028001.RemittanceLocationData2>||XmlElement()||
|+|RmtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RmtLctnDtls""",RmtLctnDtls),validElement(RmtLctnDtls))|

---

## Value ISO20022.Camt028001.RemittanceLocationData2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt028001.NameAndAddress18||XmlElement()||
|+|ElctrncAdr|String||XmlElement()||
|+|Mtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr))|

---

## Enum ISO20022.Camt028001.RemittanceLocationMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SMSM|Int32||XmlEnum("""SMSM""")|1|
||POST|Int32||XmlEnum("""POST""")|2|
||EMAL|Int32||XmlEnum("""EMAL""")|3|
||URID|Int32||XmlEnum("""URID""")|4|
||EDIC|Int32||XmlEnum("""EDIC""")|5|
||FAXI|Int32||XmlEnum("""FAXI""")|6|

---

## Enum ISO20022.Camt028001.SequenceType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RPRE|Int32||XmlEnum("""RPRE""")|1|
||OOFF|Int32||XmlEnum("""OOFF""")|2|
||FNAL|Int32||XmlEnum("""FNAL""")|3|
||RCUR|Int32||XmlEnum("""RCUR""")|4|
||FRST|Int32||XmlEnum("""FRST""")|5|

---

## Value ISO20022.Camt028001.ServiceLevel8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt028001.SettlementInstruction15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ThrdRmbrsmntAgtAcct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|ThrdRmbrsmntAgt|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InstdRmbrsmntAgtAcct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|InstdRmbrsmntAgt|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InstgRmbrsmntAgtAcct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|InstgRmbrsmntAgt|ISO20022.Camt028001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|ClrSys|ISO20022.Camt028001.ClearingSystemIdentification3Choice||XmlElement()||
|+|SttlmAcct|ISO20022.Camt028001.CashAccount40||XmlElement()||
|+|SttlmMtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ThrdRmbrsmntAgtAcct),validElement(ThrdRmbrsmntAgt),validElement(InstdRmbrsmntAgtAcct),validElement(InstdRmbrsmntAgt),validElement(InstgRmbrsmntAgtAcct),validElement(InstgRmbrsmntAgt),validElement(ClrSys),validElement(SttlmAcct))|

---

## Enum ISO20022.Camt028001.SettlementMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CLRG|Int32||XmlEnum("""CLRG""")|1|
||COVE|Int32||XmlEnum("""COVE""")|2|
||INGA|Int32||XmlEnum("""INGA""")|3|
||INDA|Int32||XmlEnum("""INDA""")|4|

---

## Value ISO20022.Camt028001.StructuredRemittanceInformation18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRmtInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|GrnshmtRmt|ISO20022.Camt028001.Garnishment4||XmlElement()||
|+|TaxRmt|ISO20022.Camt028001.TaxData1||XmlElement()||
|+|Invcee|ISO20022.Camt028001.PartyIdentification272||XmlElement()||
|+|Invcr|ISO20022.Camt028001.PartyIdentification272||XmlElement()||
|+|CdtrRefInf|ISO20022.Camt028001.CreditorReferenceInformation3||XmlElement()||
|+|RfrdDocAmt|ISO20022.Camt028001.RemittanceAmount4||XmlElement()||
|+|RfrdDocInf|global::System.Collections.Generic.List<ISO20022.Camt028001.ReferredDocumentInformation8>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlRmtInf""",AddtlRmtInf,3),validElement(GrnshmtRmt),validElement(TaxRmt),validElement(Invcee),validElement(Invcr),validElement(CdtrRefInf),validElement(RfrdDocAmt),validList("""RfrdDocInf""",RfrdDocInf),validElement(RfrdDocInf))|

---

## Value ISO20022.Camt028001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt028001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt028001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt028001.TaxAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|global::System.Collections.Generic.List<ISO20022.Camt028001.TaxRecordDetails3>||XmlElement()||
|+|TtlAmt|ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TaxblBaseAmt|ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dtls""",Dtls),validElement(Dtls),validElement(TtlAmt),validElement(TaxblBaseAmt))|

---

## Value ISO20022.Camt028001.TaxAuthorisation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Titl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt028001.TaxData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rcrd|global::System.Collections.Generic.List<ISO20022.Camt028001.TaxRecord3>||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|TtlTaxAmt|ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlTaxblBaseAmt|ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Mtd|String||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|AdmstnZone|String||XmlElement()||
|+|UltmtDbtr|ISO20022.Camt028001.TaxParty2||XmlElement()||
|+|Dbtr|ISO20022.Camt028001.TaxParty2||XmlElement()||
|+|Cdtr|ISO20022.Camt028001.TaxParty1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rcrd""",Rcrd),validElement(Rcrd),validElement(TtlTaxAmt),validElement(TtlTaxblBaseAmt),validElement(UltmtDbtr),validElement(Dbtr),validElement(Cdtr))|

---

## Value ISO20022.Camt028001.TaxParty1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxTp|String||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|TaxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt028001.TaxParty2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Authstn|ISO20022.Camt028001.TaxAuthorisation1||XmlElement()||
|+|TaxTp|String||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|TaxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Authstn))|

---

## Value ISO20022.Camt028001.TaxPeriod3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrToDt|ISO20022.Camt028001.DatePeriod2||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Yr|Int32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToDt))|

---

## Value ISO20022.Camt028001.TaxRecord3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|TaxAmt|ISO20022.Camt028001.TaxAmount3||XmlElement()||
|+|Prd|ISO20022.Camt028001.TaxPeriod3||XmlElement()||
|+|FrmsCd|String||XmlElement()||
|+|CertId|String||XmlElement()||
|+|DbtrSts|String||XmlElement()||
|+|CtgyDtls|String||XmlElement()||
|+|Ctgy|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxAmt),validElement(Prd))|

---

## Value ISO20022.Camt028001.TaxRecordDetails3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Prd|ISO20022.Camt028001.TaxPeriod3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Prd))|

---

## Enum ISO20022.Camt028001.TaxRecordPeriod1Code


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

## Value ISO20022.Camt028001.UnderlyingGroupInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlMsgDlvryChanl|String||XmlElement()||
|+|OrgnlCreDtTm|DateTime||XmlElement()||
|+|OrgnlMsgNmId|String||XmlElement()||
|+|OrgnlMsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt028001.UnderlyingPaymentInstruction9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlSvcLvl|ISO20022.Camt028001.ServiceLevel8Choice||XmlElement()||
|+|OrgnlTxRef|ISO20022.Camt028001.OriginalTransactionReference42||XmlElement()||
|+|ReqdColltnDt|DateTime||XmlElement()||
|+|ReqdExctnDt|ISO20022.Camt028001.DateAndDateTime2Choice||XmlElement()||
|+|OrgnlInstdAmt|ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|OrgnlUETR|String||XmlElement()||
|+|OrgnlEndToEndId|String||XmlElement()||
|+|OrgnlInstrId|String||XmlElement()||
|+|OrgnlPmtInfId|String||XmlElement()||
|+|OrgnlGrpInf|ISO20022.Camt028001.UnderlyingGroupInformation1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlSvcLvl),validElement(OrgnlTxRef),validElement(ReqdExctnDt),validElement(OrgnlInstdAmt),validPattern("""OrgnlUETR""",OrgnlUETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""),validElement(OrgnlGrpInf))|

---

## Value ISO20022.Camt028001.UnderlyingPaymentTransaction8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlSvcLvl|ISO20022.Camt028001.ServiceLevel8Choice||XmlElement()||
|+|OrgnlTxRef|ISO20022.Camt028001.OriginalTransactionReference42||XmlElement()||
|+|OrgnlIntrBkSttlmDt|DateTime||XmlElement()||
|+|OrgnlIntrBkSttlmAmt|ISO20022.Camt028001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|OrgnlUETR|String||XmlElement()||
|+|OrgnlTxId|String||XmlElement()||
|+|OrgnlEndToEndId|String||XmlElement()||
|+|OrgnlInstrId|String||XmlElement()||
|+|OrgnlGrpInf|ISO20022.Camt028001.UnderlyingGroupInformation1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlSvcLvl),validElement(OrgnlTxRef),validElement(OrgnlIntrBkSttlmAmt),validPattern("""OrgnlUETR""",OrgnlUETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""),validElement(OrgnlGrpInf))|

---

## Value ISO20022.Camt028001.UnderlyingStatementEntry3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlUETR|String||XmlElement()||
|+|OrgnlNtryId|String||XmlElement()||
|+|OrgnlStmtId|String||XmlElement()||
|+|OrgnlGrpInf|ISO20022.Camt028001.OriginalGroupInformation29||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""OrgnlUETR""",OrgnlUETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""),validElement(OrgnlGrpInf))|

---

## Value ISO20022.Camt028001.UnderlyingTransaction8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StmtNtry|ISO20022.Camt028001.UnderlyingStatementEntry3||XmlElement()||
|+|IntrBk|ISO20022.Camt028001.UnderlyingPaymentTransaction8||XmlElement()||
|+|Initn|ISO20022.Camt028001.UnderlyingPaymentInstruction9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmtNtry),validElement(IntrBk),validElement(Initn),validChoice(StmtNtry,IntrBk,Initn))|

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

