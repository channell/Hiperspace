# camt.111.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt111001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt111001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt111001.AccountIdentification4Choice *-- ISO20022.Camt111001.GenericAccountIdentification1
    class ISO20022.Camt111001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt111001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt111001.AddressType3Choice {
        + Prtry  : ISO20022.Camt111001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt111001.AddressType3Choice *-- ISO20022.Camt111001.GenericIdentification30
    class ISO20022.Camt111001.AdjustmentCompensation1 {
        + Rsn  : String
        + IntrstRate  : Decimal
        + Prd  : ISO20022.Camt111001.DatePeriod5
        + CompstnAcct  : ISO20022.Camt111001.CashAccount40
        + CompstnAgt  : ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
        + AmtDue  : ISO20022.Camt111001.ActiveCurrencyAndAmount
        + DueChrgs  : ISO20022.Camt111001.ActiveCurrencyAndAmount
        + InitlAmt  : ISO20022.Camt111001.ActiveCurrencyAndAmount
    }
    ISO20022.Camt111001.AdjustmentCompensation1 *-- ISO20022.Camt111001.DatePeriod5
    ISO20022.Camt111001.AdjustmentCompensation1 *-- ISO20022.Camt111001.CashAccount40
    ISO20022.Camt111001.AdjustmentCompensation1 *-- ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Camt111001.AdjustmentCompensation1 *-- ISO20022.Camt111001.ActiveCurrencyAndAmount
    ISO20022.Camt111001.AdjustmentCompensation1 *-- ISO20022.Camt111001.ActiveCurrencyAndAmount
    ISO20022.Camt111001.AdjustmentCompensation1 *-- ISO20022.Camt111001.ActiveCurrencyAndAmount
    class ISO20022.Camt111001.AmendmentInformationDetails14 {
        + OrgnlTrckgDays  : String
        + OrgnlRsn  : ISO20022.Camt111001.MandateSetupReason1Choice
        + OrgnlFrqcy  : ISO20022.Camt111001.Frequency36Choice
        + OrgnlFnlColltnDt  : DateTime
        + OrgnlDbtrAgtAcct  : ISO20022.Camt111001.CashAccount40
        + OrgnlDbtrAgt  : ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
        + OrgnlDbtrAcct  : ISO20022.Camt111001.CashAccount40
        + OrgnlDbtr  : ISO20022.Camt111001.PartyIdentification135
        + OrgnlCdtrAgtAcct  : ISO20022.Camt111001.CashAccount40
        + OrgnlCdtrAgt  : ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
        + OrgnlCdtrSchmeId  : ISO20022.Camt111001.PartyIdentification135
        + OrgnlMndtId  : String
    }
    ISO20022.Camt111001.AmendmentInformationDetails14 *-- ISO20022.Camt111001.MandateSetupReason1Choice
    ISO20022.Camt111001.AmendmentInformationDetails14 *-- ISO20022.Camt111001.Frequency36Choice
    ISO20022.Camt111001.AmendmentInformationDetails14 *-- ISO20022.Camt111001.CashAccount40
    ISO20022.Camt111001.AmendmentInformationDetails14 *-- ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Camt111001.AmendmentInformationDetails14 *-- ISO20022.Camt111001.CashAccount40
    ISO20022.Camt111001.AmendmentInformationDetails14 *-- ISO20022.Camt111001.PartyIdentification135
    ISO20022.Camt111001.AmendmentInformationDetails14 *-- ISO20022.Camt111001.CashAccount40
    ISO20022.Camt111001.AmendmentInformationDetails14 *-- ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Camt111001.AmendmentInformationDetails14 *-- ISO20022.Camt111001.PartyIdentification135
    class ISO20022.Camt111001.AmountType4Choice {
        + EqvtAmt  : ISO20022.Camt111001.EquivalentAmount2
        + InstdAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt111001.AmountType4Choice *-- ISO20022.Camt111001.EquivalentAmount2
    ISO20022.Camt111001.AmountType4Choice *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt111001.BookingConfirmation5 {
        + Rsn  : String
        + Chrgs  : ISO20022.Camt111001.Charges6
        + Refs  : ISO20022.Camt111001.TransactionReferences6
        + ValDt  : ISO20022.Camt111001.DateAndDateTime2Choice
        + BookgDt  : ISO20022.Camt111001.DateAndDateTime2Choice
        + Acct  : ISO20022.Camt111001.CashAccount40
        + XchgRate  : Decimal
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt111001.BookingConfirmation5 *-- ISO20022.Camt111001.Charges6
    ISO20022.Camt111001.BookingConfirmation5 *-- ISO20022.Camt111001.TransactionReferences6
    ISO20022.Camt111001.BookingConfirmation5 *-- ISO20022.Camt111001.DateAndDateTime2Choice
    ISO20022.Camt111001.BookingConfirmation5 *-- ISO20022.Camt111001.DateAndDateTime2Choice
    ISO20022.Camt111001.BookingConfirmation5 *-- ISO20022.Camt111001.CashAccount40
    ISO20022.Camt111001.BookingConfirmation5 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6 {
        + BrnchId  : ISO20022.Camt111001.BranchData3
        + FinInstnId  : ISO20022.Camt111001.FinancialInstitutionIdentification18
    }
    ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6 *-- ISO20022.Camt111001.BranchData3
    ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6 *-- ISO20022.Camt111001.FinancialInstitutionIdentification18
    class ISO20022.Camt111001.BranchData3 {
        + PstlAdr  : ISO20022.Camt111001.PostalAddress24
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt111001.BranchData3 *-- ISO20022.Camt111001.PostalAddress24
    class ISO20022.Camt111001.CashAccount40 {
        + Prxy  : ISO20022.Camt111001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Camt111001.CashAccountType2Choice
        + Id  : ISO20022.Camt111001.AccountIdentification4Choice
    }
    ISO20022.Camt111001.CashAccount40 *-- ISO20022.Camt111001.ProxyAccountIdentification1
    ISO20022.Camt111001.CashAccount40 *-- ISO20022.Camt111001.CashAccountType2Choice
    ISO20022.Camt111001.CashAccount40 *-- ISO20022.Camt111001.AccountIdentification4Choice
    class ISO20022.Camt111001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.CategoryPurpose1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.ChargeBearerType1Code {
        SLEV = 1
        SHAR = 2
        CRED = 3
        DEBT = 4
    }
    class ISO20022.Camt111001.ChargeType3Choice {
        + Prtry  : ISO20022.Camt111001.GenericIdentification3
        + Cd  : String
    }
    ISO20022.Camt111001.ChargeType3Choice *-- ISO20022.Camt111001.GenericIdentification3
    class ISO20022.Camt111001.Charges6 {
        + Rcrd  : global::System.Collections.Generic.List~ISO20022.Camt111001.ChargesRecord3~
        + TtlChrgsAndTaxAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt111001.Charges6 *-- ISO20022.Camt111001.ChargesRecord3
    ISO20022.Camt111001.Charges6 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt111001.ChargesRecord3 {
        + Tax  : ISO20022.Camt111001.TaxCharges2
        + Agt  : ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
        + Br  : String
        + Rate  : Decimal
        + Tp  : ISO20022.Camt111001.ChargeType3Choice
        + ChrgInclInd  : String
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt111001.ChargesRecord3 *-- ISO20022.Camt111001.TaxCharges2
    ISO20022.Camt111001.ChargesRecord3 *-- ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Camt111001.ChargesRecord3 *-- ISO20022.Camt111001.ChargeType3Choice
    ISO20022.Camt111001.ChargesRecord3 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt111001.ClearingChannel2Code {
        BOOK = 1
        MPNS = 2
        RTNS = 3
        RTGS = 4
    }
    class ISO20022.Camt111001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.ClearingSystemIdentification3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt111001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt111001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt111001.ClearingSystemIdentification2Choice
    class ISO20022.Camt111001.CompensationResponse1 {
        + Rsn  : String
        + IntrstRate  : Decimal
        + Prd  : ISO20022.Camt111001.DatePeriod2
        + XpctdValDt  : DateTime
        + AmtDue  : ISO20022.Camt111001.ActiveCurrencyAndAmount
        + PdChrgs  : ISO20022.Camt111001.ActiveCurrencyAndAmount
        + InitlAmt  : ISO20022.Camt111001.ActiveCurrencyAndAmount
        + Grantd  : String
    }
    ISO20022.Camt111001.CompensationResponse1 *-- ISO20022.Camt111001.DatePeriod2
    ISO20022.Camt111001.CompensationResponse1 *-- ISO20022.Camt111001.ActiveCurrencyAndAmount
    ISO20022.Camt111001.CompensationResponse1 *-- ISO20022.Camt111001.ActiveCurrencyAndAmount
    ISO20022.Camt111001.CompensationResponse1 *-- ISO20022.Camt111001.ActiveCurrencyAndAmount
    class ISO20022.Camt111001.Contact4 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt111001.OtherContact1~
        + Dept  : String
        + Rspnsblty  : String
        + JobTitl  : String
        + EmailPurp  : String
        + EmailAdr  : String
        + FaxNb  : String
        + MobNb  : String
        + PhneNb  : String
        + Nm  : String
        + NmPrfx  : String
    }
    ISO20022.Camt111001.Contact4 *-- ISO20022.Camt111001.OtherContact1
    class ISO20022.Camt111001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Camt111001.CreditTransferMandateData1 {
        + Rsn  : ISO20022.Camt111001.MandateSetupReason1Choice
        + Frqcy  : ISO20022.Camt111001.Frequency36Choice
        + FnlPmtDt  : DateTime
        + FrstPmtDt  : DateTime
        + ElctrncSgntr  : String
        + DtOfVrfctn  : DateTime
        + DtOfSgntr  : DateTime
        + Tp  : ISO20022.Camt111001.MandateTypeInformation2
        + MndtId  : String
    }
    ISO20022.Camt111001.CreditTransferMandateData1 *-- ISO20022.Camt111001.MandateSetupReason1Choice
    ISO20022.Camt111001.CreditTransferMandateData1 *-- ISO20022.Camt111001.Frequency36Choice
    ISO20022.Camt111001.CreditTransferMandateData1 *-- ISO20022.Camt111001.MandateTypeInformation2
    class ISO20022.Camt111001.CreditorReferenceInformation2 {
        + Ref  : String
        + Tp  : ISO20022.Camt111001.CreditorReferenceType2
    }
    ISO20022.Camt111001.CreditorReferenceInformation2 *-- ISO20022.Camt111001.CreditorReferenceType2
    class ISO20022.Camt111001.CreditorReferenceType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.CreditorReferenceType2 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Camt111001.CreditorReferenceType1Choice
    }
    ISO20022.Camt111001.CreditorReferenceType2 *-- ISO20022.Camt111001.CreditorReferenceType1Choice
    class ISO20022.Camt111001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Camt111001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Camt111001.DatePeriod2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Camt111001.DatePeriod5 {
        + ReqdValDt  : DateTime
        + CurValDt  : DateTime
    }
    class ISO20022.Camt111001.DebitAuthorisationConfirmation3 {
        + Rsn  : String
        + CmonTxId  : String
        + ValDtToDbt  : DateTime
        + Acct  : ISO20022.Camt111001.CashAccount40
        + AmtToDbt  : ISO20022.Camt111001.ActiveCurrencyAndAmount
        + DbtAuthstn  : String
    }
    ISO20022.Camt111001.DebitAuthorisationConfirmation3 *-- ISO20022.Camt111001.CashAccount40
    ISO20022.Camt111001.DebitAuthorisationConfirmation3 *-- ISO20022.Camt111001.ActiveCurrencyAndAmount
    class ISO20022.Camt111001.DiscountAmountAndType1 {
        + Amt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + Tp  : ISO20022.Camt111001.DiscountAmountType1Choice
    }
    ISO20022.Camt111001.DiscountAmountAndType1 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.DiscountAmountAndType1 *-- ISO20022.Camt111001.DiscountAmountType1Choice
    class ISO20022.Camt111001.DiscountAmountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.Document12 {
        + Nclsr  : String
        + DgtlSgntr  : ISO20022.Camt111001.PartyAndSignature3
        + FileNm  : String
        + Frmt  : ISO20022.Camt111001.DocumentFormat1Choice
        + LangCd  : String
        + Nm  : String
        + IsseDt  : ISO20022.Camt111001.DateAndDateTime2Choice
        + Id  : String
        + Tp  : ISO20022.Camt111001.DocumentType1Choice
    }
    ISO20022.Camt111001.Document12 *-- ISO20022.Camt111001.PartyAndSignature3
    ISO20022.Camt111001.Document12 *-- ISO20022.Camt111001.DocumentFormat1Choice
    ISO20022.Camt111001.Document12 *-- ISO20022.Camt111001.DateAndDateTime2Choice
    ISO20022.Camt111001.Document12 *-- ISO20022.Camt111001.DocumentType1Choice
    class ISO20022.Camt111001.DocumentAdjustment1 {
        + AddtlInf  : String
        + Rsn  : String
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt111001.DocumentAdjustment1 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt111001.DocumentFormat1Choice {
        + Prtry  : ISO20022.Camt111001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Camt111001.DocumentFormat1Choice *-- ISO20022.Camt111001.GenericIdentification1
    class ISO20022.Camt111001.DocumentLineIdentification1 {
        + RltdDt  : DateTime
        + Nb  : String
        + Tp  : ISO20022.Camt111001.DocumentLineType1
    }
    ISO20022.Camt111001.DocumentLineIdentification1 *-- ISO20022.Camt111001.DocumentLineType1
    class ISO20022.Camt111001.DocumentLineInformation1 {
        + Amt  : ISO20022.Camt111001.RemittanceAmount3
        + Desc  : String
        + Id  : global::System.Collections.Generic.List~ISO20022.Camt111001.DocumentLineIdentification1~
    }
    ISO20022.Camt111001.DocumentLineInformation1 *-- ISO20022.Camt111001.RemittanceAmount3
    ISO20022.Camt111001.DocumentLineInformation1 *-- ISO20022.Camt111001.DocumentLineIdentification1
    class ISO20022.Camt111001.DocumentLineType1 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Camt111001.DocumentLineType1Choice
    }
    ISO20022.Camt111001.DocumentLineType1 *-- ISO20022.Camt111001.DocumentLineType1Choice
    class ISO20022.Camt111001.DocumentLineType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.DocumentType1Choice {
        + Prtry  : ISO20022.Camt111001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Camt111001.DocumentType1Choice *-- ISO20022.Camt111001.GenericIdentification1
    class ISO20022.Camt111001.DocumentType3Code {
        SCOR = 1
        PUOR = 2
        DISP = 3
        FXDR = 4
        RPIN = 5
        RADM = 6
    }
    class ISO20022.Camt111001.DocumentType6Code {
        PUOR = 1
        TSUT = 2
        AROI = 3
        VCHR = 4
        BOLD = 5
        DISP = 6
        SOAC = 7
        CMCN = 8
        SBIN = 9
        HIRI = 10
        DEBN = 11
        CREN = 12
        CINV = 13
        DNFA = 14
        CNFA = 15
        MSIN = 16
    }
    class ISO20022.Camt111001.EquivalentAmount2 {
        + CcyOfTrf  : String
        + Amt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt111001.EquivalentAmount2 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt111001.FileData1 {
        + FileLctnElctrncAdr  : String
        + NtwkRef  : String
        + FileNm  : String
        + Frmt  : ISO20022.Camt111001.DocumentFormat1Choice
        + IsseDt  : ISO20022.Camt111001.DateAndDateTime2Choice
        + Id  : String
        + Tp  : ISO20022.Camt111001.DocumentType1Choice
    }
    ISO20022.Camt111001.FileData1 *-- ISO20022.Camt111001.DocumentFormat1Choice
    ISO20022.Camt111001.FileData1 *-- ISO20022.Camt111001.DateAndDateTime2Choice
    ISO20022.Camt111001.FileData1 *-- ISO20022.Camt111001.DocumentType1Choice
    class ISO20022.Camt111001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.FinancialInstitutionIdentification18 {
        + Othr  : ISO20022.Camt111001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt111001.PostalAddress24
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt111001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt111001.FinancialInstitutionIdentification18 *-- ISO20022.Camt111001.GenericFinancialIdentification1
    ISO20022.Camt111001.FinancialInstitutionIdentification18 *-- ISO20022.Camt111001.PostalAddress24
    ISO20022.Camt111001.FinancialInstitutionIdentification18 *-- ISO20022.Camt111001.ClearingSystemMemberIdentification2
    class ISO20022.Camt111001.Frequency36Choice {
        + PtInTm  : ISO20022.Camt111001.FrequencyAndMoment1
        + Prd  : ISO20022.Camt111001.FrequencyPeriod1
        + Tp  : String
    }
    ISO20022.Camt111001.Frequency36Choice *-- ISO20022.Camt111001.FrequencyAndMoment1
    ISO20022.Camt111001.Frequency36Choice *-- ISO20022.Camt111001.FrequencyPeriod1
    class ISO20022.Camt111001.Frequency6Code {
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
    class ISO20022.Camt111001.FrequencyAndMoment1 {
        + PtInTm  : String
        + Tp  : String
    }
    class ISO20022.Camt111001.FrequencyPeriod1 {
        + CntPerPrd  : Decimal
        + Tp  : String
    }
    class ISO20022.Camt111001.Garnishment3 {
        + MplyeeTermntnInd  : String
        + FmlyMdclInsrncInd  : String
        + RmtdAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + Dt  : DateTime
        + RefNb  : String
        + GrnshmtAdmstr  : ISO20022.Camt111001.PartyIdentification135
        + Grnshee  : ISO20022.Camt111001.PartyIdentification135
        + Tp  : ISO20022.Camt111001.GarnishmentType1
    }
    ISO20022.Camt111001.Garnishment3 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.Garnishment3 *-- ISO20022.Camt111001.PartyIdentification135
    ISO20022.Camt111001.Garnishment3 *-- ISO20022.Camt111001.PartyIdentification135
    ISO20022.Camt111001.Garnishment3 *-- ISO20022.Camt111001.GarnishmentType1
    class ISO20022.Camt111001.GarnishmentType1 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Camt111001.GarnishmentType1Choice
    }
    ISO20022.Camt111001.GarnishmentType1 *-- ISO20022.Camt111001.GarnishmentType1Choice
    class ISO20022.Camt111001.GarnishmentType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt111001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt111001.GenericAccountIdentification1 *-- ISO20022.Camt111001.AccountSchemeName1Choice
    class ISO20022.Camt111001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt111001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt111001.GenericFinancialIdentification1 *-- ISO20022.Camt111001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt111001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Camt111001.GenericIdentification3 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt111001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt111001.GenericOrganisationIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt111001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt111001.GenericOrganisationIdentification1 *-- ISO20022.Camt111001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Camt111001.GenericPersonIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt111001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt111001.GenericPersonIdentification1 *-- ISO20022.Camt111001.PersonIdentificationSchemeName1Choice
    class ISO20022.Camt111001.InvestigationActionReason1 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + Rsn  : ISO20022.Camt111001.InvestigationActionReason1Choice
        + Orgtr  : ISO20022.Camt111001.PartyIdentification135
    }
    ISO20022.Camt111001.InvestigationActionReason1 *-- ISO20022.Camt111001.InvestigationActionReason1Choice
    ISO20022.Camt111001.InvestigationActionReason1 *-- ISO20022.Camt111001.PartyIdentification135
    class ISO20022.Camt111001.InvestigationActionReason1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.InvestigationData6 {
        + RspnOrgtr  : ISO20022.Camt111001.Party40Choice
        + RltdFileData  : global::System.Collections.Generic.List~ISO20022.Camt111001.FileData1~
        + NclsdFile  : global::System.Collections.Generic.List~ISO20022.Camt111001.Document12~
        + RltdInvstgtnData  : ISO20022.Camt111001.RelatedInvestigationData1
        + RspnData  : ISO20022.Camt111001.InvestigationDataRecord7Choice
        + OrgnlInvstgtnRsnSubTp  : ISO20022.Camt111001.InvestigationReasonSubType1Choice
        + OrgnlInvstgtnRsn  : ISO20022.Camt111001.InvestigationReason1Choice
        + OrgnlInvstgtnSeq  : Decimal
    }
    ISO20022.Camt111001.InvestigationData6 *-- ISO20022.Camt111001.Party40Choice
    ISO20022.Camt111001.InvestigationData6 *-- ISO20022.Camt111001.FileData1
    ISO20022.Camt111001.InvestigationData6 *-- ISO20022.Camt111001.Document12
    ISO20022.Camt111001.InvestigationData6 *-- ISO20022.Camt111001.RelatedInvestigationData1
    ISO20022.Camt111001.InvestigationData6 *-- ISO20022.Camt111001.InvestigationDataRecord7Choice
    ISO20022.Camt111001.InvestigationData6 *-- ISO20022.Camt111001.InvestigationReasonSubType1Choice
    ISO20022.Camt111001.InvestigationData6 *-- ISO20022.Camt111001.InvestigationReason1Choice
    class ISO20022.Camt111001.InvestigationDataRecord7Choice {
        + RspnNrrtv  : String
        + TxData  : global::System.Collections.Generic.List~ISO20022.Camt111001.TransactionAmendment1~
        + TxSts  : ISO20022.Camt111001.PaymentTransactionStatus1
        + Conf  : ISO20022.Camt111001.BookingConfirmation5
        + Valtn  : ISO20022.Camt111001.AdjustmentCompensation1
        + Compstn  : ISO20022.Camt111001.CompensationResponse1
        + DbtAuthstn  : ISO20022.Camt111001.DebitAuthorisationConfirmation3
    }
    ISO20022.Camt111001.InvestigationDataRecord7Choice *-- ISO20022.Camt111001.TransactionAmendment1
    ISO20022.Camt111001.InvestigationDataRecord7Choice *-- ISO20022.Camt111001.PaymentTransactionStatus1
    ISO20022.Camt111001.InvestigationDataRecord7Choice *-- ISO20022.Camt111001.BookingConfirmation5
    ISO20022.Camt111001.InvestigationDataRecord7Choice *-- ISO20022.Camt111001.AdjustmentCompensation1
    ISO20022.Camt111001.InvestigationDataRecord7Choice *-- ISO20022.Camt111001.CompensationResponse1
    ISO20022.Camt111001.InvestigationDataRecord7Choice *-- ISO20022.Camt111001.DebitAuthorisationConfirmation3
    class ISO20022.Camt111001.InvestigationLocationData1 {
        + PstlAdr  : ISO20022.Camt111001.NameAndAddress16
        + ElctrncAdr  : String
        + Mtd  : String
    }
    ISO20022.Camt111001.InvestigationLocationData1 *-- ISO20022.Camt111001.NameAndAddress16
    class ISO20022.Camt111001.InvestigationLocationMethod1Code {
        URID = 1
        SMSM = 2
        POST = 3
        FAXI = 4
        EMAL = 5
        EDIC = 6
    }
    class ISO20022.Camt111001.InvestigationReason1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.InvestigationReasonSubType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.InvestigationRequest3 {
        + SvcLvl  : global::System.Collections.Generic.List~ISO20022.Camt111001.InvestigationServiceLevel1Choice~
        + XpctdRspndr  : ISO20022.Camt111001.Party40Choice
        + ReqOrgtr  : ISO20022.Camt111001.Party40Choice
        + Rspndr  : ISO20022.Camt111001.Party40Choice
        + Rqstr  : ISO20022.Camt111001.Party40Choice
        + Undrlyg  : ISO20022.Camt111001.UnderlyingData2Choice
        + UndrlygInstrm  : ISO20022.Camt111001.UnderlyingInvestigationInstrument1Choice
        + InvstgtnSubTp  : ISO20022.Camt111001.InvestigationSubType1Choice
        + InvstgtnTp  : ISO20022.Camt111001.InvestigationType1Choice
        + ReqActn  : ISO20022.Camt111001.InvestigationRequestAction1
        + EIR  : String
        + RspndrInvstgtnId  : String
        + RqstrInvstgtnId  : String
        + MsgId  : String
    }
    ISO20022.Camt111001.InvestigationRequest3 *-- ISO20022.Camt111001.InvestigationServiceLevel1Choice
    ISO20022.Camt111001.InvestigationRequest3 *-- ISO20022.Camt111001.Party40Choice
    ISO20022.Camt111001.InvestigationRequest3 *-- ISO20022.Camt111001.Party40Choice
    ISO20022.Camt111001.InvestigationRequest3 *-- ISO20022.Camt111001.Party40Choice
    ISO20022.Camt111001.InvestigationRequest3 *-- ISO20022.Camt111001.Party40Choice
    ISO20022.Camt111001.InvestigationRequest3 *-- ISO20022.Camt111001.UnderlyingData2Choice
    ISO20022.Camt111001.InvestigationRequest3 *-- ISO20022.Camt111001.UnderlyingInvestigationInstrument1Choice
    ISO20022.Camt111001.InvestigationRequest3 *-- ISO20022.Camt111001.InvestigationSubType1Choice
    ISO20022.Camt111001.InvestigationRequest3 *-- ISO20022.Camt111001.InvestigationType1Choice
    ISO20022.Camt111001.InvestigationRequest3 *-- ISO20022.Camt111001.InvestigationRequestAction1
    class ISO20022.Camt111001.InvestigationRequestAction1 {
        + ActnRsn  : ISO20022.Camt111001.InvestigationActionReason1
        + Actn  : ISO20022.Camt111001.InvestigationRequestAction1Choice
    }
    ISO20022.Camt111001.InvestigationRequestAction1 *-- ISO20022.Camt111001.InvestigationActionReason1
    ISO20022.Camt111001.InvestigationRequestAction1 *-- ISO20022.Camt111001.InvestigationRequestAction1Choice
    class ISO20022.Camt111001.InvestigationRequestAction1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.InvestigationResponse9 {
        + InvstgtnData  : global::System.Collections.Generic.List~ISO20022.Camt111001.InvestigationData6~
        + NxtRspndr  : ISO20022.Camt111001.Party40Choice
        + InvstgtnSts  : ISO20022.Camt111001.InvestigationStatus2
        + RspndrInvstgtnId  : String
        + MsgId  : String
    }
    ISO20022.Camt111001.InvestigationResponse9 *-- ISO20022.Camt111001.InvestigationData6
    ISO20022.Camt111001.InvestigationResponse9 *-- ISO20022.Camt111001.Party40Choice
    ISO20022.Camt111001.InvestigationResponse9 *-- ISO20022.Camt111001.InvestigationStatus2
    class ISO20022.Camt111001.InvestigationResponseV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt111001.SupplementaryData1~
        + OrgnlInvstgtnReq  : ISO20022.Camt111001.InvestigationRequest3
        + InvstgtnRspn  : ISO20022.Camt111001.InvestigationResponse9
    }
    ISO20022.Camt111001.InvestigationResponseV02 *-- ISO20022.Camt111001.SupplementaryData1
    ISO20022.Camt111001.InvestigationResponseV02 *-- ISO20022.Camt111001.InvestigationRequest3
    ISO20022.Camt111001.InvestigationResponseV02 *-- ISO20022.Camt111001.InvestigationResponse9
    class ISO20022.Camt111001.InvestigationServiceLevel1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.InvestigationStatus2 {
        + StsRsn  : ISO20022.Camt111001.InvestigationStatusReason1Choice
        + Sts  : String
    }
    ISO20022.Camt111001.InvestigationStatus2 *-- ISO20022.Camt111001.InvestigationStatusReason1Choice
    class ISO20022.Camt111001.InvestigationStatusReason1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.InvestigationSubType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.InvestigationType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.LocalInstrument2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.MandateClassification1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.MandateClassification1Code {
        VARI = 1
        USGB = 2
        FIXE = 3
    }
    class ISO20022.Camt111001.MandateRelatedData2Choice {
        + CdtTrfMndt  : ISO20022.Camt111001.CreditTransferMandateData1
        + DrctDbtMndt  : ISO20022.Camt111001.MandateRelatedInformation15
    }
    ISO20022.Camt111001.MandateRelatedData2Choice *-- ISO20022.Camt111001.CreditTransferMandateData1
    ISO20022.Camt111001.MandateRelatedData2Choice *-- ISO20022.Camt111001.MandateRelatedInformation15
    class ISO20022.Camt111001.MandateRelatedInformation15 {
        + TrckgDays  : String
        + Rsn  : ISO20022.Camt111001.MandateSetupReason1Choice
        + Frqcy  : ISO20022.Camt111001.Frequency36Choice
        + FnlColltnDt  : DateTime
        + FrstColltnDt  : DateTime
        + ElctrncSgntr  : String
        + AmdmntInfDtls  : ISO20022.Camt111001.AmendmentInformationDetails14
        + AmdmntInd  : String
        + DtOfSgntr  : DateTime
        + MndtId  : String
    }
    ISO20022.Camt111001.MandateRelatedInformation15 *-- ISO20022.Camt111001.MandateSetupReason1Choice
    ISO20022.Camt111001.MandateRelatedInformation15 *-- ISO20022.Camt111001.Frequency36Choice
    ISO20022.Camt111001.MandateRelatedInformation15 *-- ISO20022.Camt111001.AmendmentInformationDetails14
    class ISO20022.Camt111001.MandateSetupReason1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.MandateTypeInformation2 {
        + Clssfctn  : ISO20022.Camt111001.MandateClassification1Choice
        + CtgyPurp  : ISO20022.Camt111001.CategoryPurpose1Choice
        + LclInstrm  : ISO20022.Camt111001.LocalInstrument2Choice
        + SvcLvl  : ISO20022.Camt111001.ServiceLevel8Choice
    }
    ISO20022.Camt111001.MandateTypeInformation2 *-- ISO20022.Camt111001.MandateClassification1Choice
    ISO20022.Camt111001.MandateTypeInformation2 *-- ISO20022.Camt111001.CategoryPurpose1Choice
    ISO20022.Camt111001.MandateTypeInformation2 *-- ISO20022.Camt111001.LocalInstrument2Choice
    ISO20022.Camt111001.MandateTypeInformation2 *-- ISO20022.Camt111001.ServiceLevel8Choice
    class ISO20022.Camt111001.NameAndAddress16 {
        + Adr  : ISO20022.Camt111001.PostalAddress24
        + Nm  : String
    }
    ISO20022.Camt111001.NameAndAddress16 *-- ISO20022.Camt111001.PostalAddress24
    class ISO20022.Camt111001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Camt111001.OrganisationIdentification29 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt111001.GenericOrganisationIdentification1~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Camt111001.OrganisationIdentification29 *-- ISO20022.Camt111001.GenericOrganisationIdentification1
    class ISO20022.Camt111001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.OriginalGroupInformation29 {
        + OrgnlCreDtTm  : DateTime
        + OrgnlMsgNmId  : String
        + OrgnlMsgId  : String
    }
    class ISO20022.Camt111001.OriginalTransactionReference35 {
        + Purp  : ISO20022.Camt111001.Purpose2Choice
        + UltmtCdtr  : ISO20022.Camt111001.Party40Choice
        + CdtrAcct  : ISO20022.Camt111001.CashAccount40
        + Cdtr  : ISO20022.Camt111001.Party40Choice
        + CdtrAgtAcct  : ISO20022.Camt111001.CashAccount40
        + CdtrAgt  : ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
        + DbtrAgtAcct  : ISO20022.Camt111001.CashAccount40
        + DbtrAgt  : ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
        + DbtrAcct  : ISO20022.Camt111001.CashAccount40
        + Dbtr  : ISO20022.Camt111001.Party40Choice
        + UltmtDbtr  : ISO20022.Camt111001.Party40Choice
        + RmtInf  : ISO20022.Camt111001.RemittanceInformation21
        + MndtRltdInf  : ISO20022.Camt111001.MandateRelatedData2Choice
        + PmtMtd  : String
        + PmtTpInf  : ISO20022.Camt111001.PaymentTypeInformation27
        + SttlmInf  : ISO20022.Camt111001.SettlementInstruction11
        + CdtrSchmeId  : ISO20022.Camt111001.PartyIdentification135
        + ReqdExctnDt  : ISO20022.Camt111001.DateAndDateTime2Choice
        + ReqdColltnDt  : DateTime
        + IntrBkSttlmDt  : DateTime
        + Amt  : ISO20022.Camt111001.AmountType4Choice
        + IntrBkSttlmAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.Purpose2Choice
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.Party40Choice
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.CashAccount40
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.Party40Choice
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.CashAccount40
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.CashAccount40
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.CashAccount40
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.Party40Choice
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.Party40Choice
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.RemittanceInformation21
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.MandateRelatedData2Choice
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.PaymentTypeInformation27
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.SettlementInstruction11
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.PartyIdentification135
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.DateAndDateTime2Choice
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.AmountType4Choice
    ISO20022.Camt111001.OriginalTransactionReference35 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt111001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Camt111001.Party38Choice {
        + PrvtId  : ISO20022.Camt111001.PersonIdentification13
        + OrgId  : ISO20022.Camt111001.OrganisationIdentification29
    }
    ISO20022.Camt111001.Party38Choice *-- ISO20022.Camt111001.PersonIdentification13
    ISO20022.Camt111001.Party38Choice *-- ISO20022.Camt111001.OrganisationIdentification29
    class ISO20022.Camt111001.Party40Choice {
        + Agt  : ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
        + Pty  : ISO20022.Camt111001.PartyIdentification135
    }
    ISO20022.Camt111001.Party40Choice *-- ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Camt111001.Party40Choice *-- ISO20022.Camt111001.PartyIdentification135
    class ISO20022.Camt111001.PartyAndSignature3 {
        + Sgntr  : ISO20022.Camt111001.SkipPayload
        + Pty  : ISO20022.Camt111001.PartyIdentification135
    }
    ISO20022.Camt111001.PartyAndSignature3 *-- ISO20022.Camt111001.SkipPayload
    ISO20022.Camt111001.PartyAndSignature3 *-- ISO20022.Camt111001.PartyIdentification135
    class ISO20022.Camt111001.PartyIdentification135 {
        + CtctDtls  : ISO20022.Camt111001.Contact4
        + CtryOfRes  : String
        + Id  : ISO20022.Camt111001.Party38Choice
        + PstlAdr  : ISO20022.Camt111001.PostalAddress24
        + Nm  : String
    }
    ISO20022.Camt111001.PartyIdentification135 *-- ISO20022.Camt111001.Contact4
    ISO20022.Camt111001.PartyIdentification135 *-- ISO20022.Camt111001.Party38Choice
    ISO20022.Camt111001.PartyIdentification135 *-- ISO20022.Camt111001.PostalAddress24
    class ISO20022.Camt111001.PaymentMethod4Code {
        TRA = 1
        DD = 2
        TRF = 3
        CHK = 4
    }
    class ISO20022.Camt111001.PaymentTransactionStatus1 {
        + StsRsnInf  : global::System.Collections.Generic.List~ISO20022.Camt111001.StatusReasonInformation12~
        + Sts  : ISO20022.Camt111001.TransactionStatus1Choice
    }
    ISO20022.Camt111001.PaymentTransactionStatus1 *-- ISO20022.Camt111001.StatusReasonInformation12
    ISO20022.Camt111001.PaymentTransactionStatus1 *-- ISO20022.Camt111001.TransactionStatus1Choice
    class ISO20022.Camt111001.PaymentTypeInformation27 {
        + CtgyPurp  : ISO20022.Camt111001.CategoryPurpose1Choice
        + SeqTp  : String
        + LclInstrm  : ISO20022.Camt111001.LocalInstrument2Choice
        + SvcLvl  : global::System.Collections.Generic.List~ISO20022.Camt111001.ServiceLevel8Choice~
        + ClrChanl  : String
        + InstrPrty  : String
    }
    ISO20022.Camt111001.PaymentTypeInformation27 *-- ISO20022.Camt111001.CategoryPurpose1Choice
    ISO20022.Camt111001.PaymentTypeInformation27 *-- ISO20022.Camt111001.LocalInstrument2Choice
    ISO20022.Camt111001.PaymentTypeInformation27 *-- ISO20022.Camt111001.ServiceLevel8Choice
    class ISO20022.Camt111001.PersonIdentification13 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt111001.GenericPersonIdentification1~
        + DtAndPlcOfBirth  : ISO20022.Camt111001.DateAndPlaceOfBirth1
    }
    ISO20022.Camt111001.PersonIdentification13 *-- ISO20022.Camt111001.GenericPersonIdentification1
    ISO20022.Camt111001.PersonIdentification13 *-- ISO20022.Camt111001.DateAndPlaceOfBirth1
    class ISO20022.Camt111001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.PostalAddress24 {
        + AdrLine  : global::System.Collections.Generic.List~String~
        + Ctry  : String
        + CtrySubDvsn  : String
        + DstrctNm  : String
        + TwnLctnNm  : String
        + TwnNm  : String
        + PstCd  : String
        + Room  : String
        + PstBx  : String
        + Flr  : String
        + BldgNm  : String
        + BldgNb  : String
        + StrtNm  : String
        + SubDept  : String
        + Dept  : String
        + AdrTp  : ISO20022.Camt111001.AddressType3Choice
    }
    ISO20022.Camt111001.PostalAddress24 *-- ISO20022.Camt111001.AddressType3Choice
    class ISO20022.Camt111001.PreferredContactMethod1Code {
        CELL = 1
        FAXX = 2
        PHON = 3
        MAIL = 4
        LETT = 5
    }
    class ISO20022.Camt111001.Priority2Code {
        NORM = 1
        HIGH = 2
    }
    class ISO20022.Camt111001.ProprietaryReference1 {
        + Ref  : String
        + Tp  : String
    }
    class ISO20022.Camt111001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Camt111001.ProxyAccountType1Choice
    }
    ISO20022.Camt111001.ProxyAccountIdentification1 *-- ISO20022.Camt111001.ProxyAccountType1Choice
    class ISO20022.Camt111001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.Purpose2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.ReferredDocumentInformation7 {
        + LineDtls  : global::System.Collections.Generic.List~ISO20022.Camt111001.DocumentLineInformation1~
        + RltdDt  : DateTime
        + Nb  : String
        + Tp  : ISO20022.Camt111001.ReferredDocumentType4
    }
    ISO20022.Camt111001.ReferredDocumentInformation7 *-- ISO20022.Camt111001.DocumentLineInformation1
    ISO20022.Camt111001.ReferredDocumentInformation7 *-- ISO20022.Camt111001.ReferredDocumentType4
    class ISO20022.Camt111001.ReferredDocumentType3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.ReferredDocumentType4 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Camt111001.ReferredDocumentType3Choice
    }
    ISO20022.Camt111001.ReferredDocumentType4 *-- ISO20022.Camt111001.ReferredDocumentType3Choice
    class ISO20022.Camt111001.RelatedInvestigationData1 {
        + Lctn  : global::System.Collections.Generic.List~ISO20022.Camt111001.InvestigationLocationData1~
        + InvstgtnId  : String
    }
    ISO20022.Camt111001.RelatedInvestigationData1 *-- ISO20022.Camt111001.InvestigationLocationData1
    class ISO20022.Camt111001.Remittance1 {
        + Rltd  : global::System.Collections.Generic.List~ISO20022.Camt111001.RemittanceLocation7~
        + Strd  : global::System.Collections.Generic.List~ISO20022.Camt111001.StructuredRemittanceInformation16~
        + Ustrd  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Camt111001.Remittance1 *-- ISO20022.Camt111001.RemittanceLocation7
    ISO20022.Camt111001.Remittance1 *-- ISO20022.Camt111001.StructuredRemittanceInformation16
    class ISO20022.Camt111001.RemittanceAmount2 {
        + RmtdAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + AdjstmntAmtAndRsn  : global::System.Collections.Generic.List~ISO20022.Camt111001.DocumentAdjustment1~
        + TaxAmt  : global::System.Collections.Generic.List~ISO20022.Camt111001.TaxAmountAndType1~
        + CdtNoteAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + DscntApldAmt  : global::System.Collections.Generic.List~ISO20022.Camt111001.DiscountAmountAndType1~
        + DuePyblAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt111001.RemittanceAmount2 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.RemittanceAmount2 *-- ISO20022.Camt111001.DocumentAdjustment1
    ISO20022.Camt111001.RemittanceAmount2 *-- ISO20022.Camt111001.TaxAmountAndType1
    ISO20022.Camt111001.RemittanceAmount2 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.RemittanceAmount2 *-- ISO20022.Camt111001.DiscountAmountAndType1
    ISO20022.Camt111001.RemittanceAmount2 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt111001.RemittanceAmount3 {
        + RmtdAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + AdjstmntAmtAndRsn  : global::System.Collections.Generic.List~ISO20022.Camt111001.DocumentAdjustment1~
        + TaxAmt  : global::System.Collections.Generic.List~ISO20022.Camt111001.TaxAmountAndType1~
        + CdtNoteAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + DscntApldAmt  : global::System.Collections.Generic.List~ISO20022.Camt111001.DiscountAmountAndType1~
        + DuePyblAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt111001.RemittanceAmount3 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.RemittanceAmount3 *-- ISO20022.Camt111001.DocumentAdjustment1
    ISO20022.Camt111001.RemittanceAmount3 *-- ISO20022.Camt111001.TaxAmountAndType1
    ISO20022.Camt111001.RemittanceAmount3 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.RemittanceAmount3 *-- ISO20022.Camt111001.DiscountAmountAndType1
    ISO20022.Camt111001.RemittanceAmount3 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt111001.RemittanceInformation21 {
        + Strd  : global::System.Collections.Generic.List~ISO20022.Camt111001.StructuredRemittanceInformation17~
        + Ustrd  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Camt111001.RemittanceInformation21 *-- ISO20022.Camt111001.StructuredRemittanceInformation17
    class ISO20022.Camt111001.RemittanceLocation7 {
        + RmtLctnDtls  : global::System.Collections.Generic.List~ISO20022.Camt111001.RemittanceLocationData1~
        + RmtId  : String
    }
    ISO20022.Camt111001.RemittanceLocation7 *-- ISO20022.Camt111001.RemittanceLocationData1
    class ISO20022.Camt111001.RemittanceLocationData1 {
        + PstlAdr  : ISO20022.Camt111001.NameAndAddress16
        + ElctrncAdr  : String
        + Mtd  : String
    }
    ISO20022.Camt111001.RemittanceLocationData1 *-- ISO20022.Camt111001.NameAndAddress16
    class ISO20022.Camt111001.RemittanceLocationMethod2Code {
        SMSM = 1
        POST = 2
        EMAL = 3
        URID = 4
        EDIC = 5
        FAXI = 6
    }
    class ISO20022.Camt111001.SequenceType3Code {
        RPRE = 1
        OOFF = 2
        FNAL = 3
        RCUR = 4
        FRST = 5
    }
    class ISO20022.Camt111001.ServiceLevel8Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.SettlementInstruction11 {
        + ThrdRmbrsmntAgtAcct  : ISO20022.Camt111001.CashAccount40
        + ThrdRmbrsmntAgt  : ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
        + InstdRmbrsmntAgtAcct  : ISO20022.Camt111001.CashAccount40
        + InstdRmbrsmntAgt  : ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
        + InstgRmbrsmntAgtAcct  : ISO20022.Camt111001.CashAccount40
        + InstgRmbrsmntAgt  : ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
        + ClrSys  : ISO20022.Camt111001.ClearingSystemIdentification3Choice
        + SttlmAcct  : ISO20022.Camt111001.CashAccount40
        + SttlmMtd  : String
    }
    ISO20022.Camt111001.SettlementInstruction11 *-- ISO20022.Camt111001.CashAccount40
    ISO20022.Camt111001.SettlementInstruction11 *-- ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Camt111001.SettlementInstruction11 *-- ISO20022.Camt111001.CashAccount40
    ISO20022.Camt111001.SettlementInstruction11 *-- ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Camt111001.SettlementInstruction11 *-- ISO20022.Camt111001.CashAccount40
    ISO20022.Camt111001.SettlementInstruction11 *-- ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Camt111001.SettlementInstruction11 *-- ISO20022.Camt111001.ClearingSystemIdentification3Choice
    ISO20022.Camt111001.SettlementInstruction11 *-- ISO20022.Camt111001.CashAccount40
    class ISO20022.Camt111001.SettlementMethod1Code {
        CLRG = 1
        COVE = 2
        INGA = 3
        INDA = 4
    }
    class ISO20022.Camt111001.SkipPayload {
    }
    class ISO20022.Camt111001.StatusReason6Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.StatusReasonInformation12 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + Rsn  : ISO20022.Camt111001.StatusReason6Choice
        + Orgtr  : ISO20022.Camt111001.PartyIdentification135
    }
    ISO20022.Camt111001.StatusReasonInformation12 *-- ISO20022.Camt111001.StatusReason6Choice
    ISO20022.Camt111001.StatusReasonInformation12 *-- ISO20022.Camt111001.PartyIdentification135
    class ISO20022.Camt111001.StructuredRemittanceInformation16 {
        + AddtlRmtInf  : global::System.Collections.Generic.List~String~
        + GrnshmtRmt  : ISO20022.Camt111001.Garnishment3
        + TaxRmt  : ISO20022.Camt111001.TaxInformation7
        + Invcee  : ISO20022.Camt111001.PartyIdentification135
        + Invcr  : ISO20022.Camt111001.PartyIdentification135
        + CdtrRefInf  : ISO20022.Camt111001.CreditorReferenceInformation2
        + RfrdDocAmt  : ISO20022.Camt111001.RemittanceAmount2
        + RfrdDocInf  : global::System.Collections.Generic.List~ISO20022.Camt111001.ReferredDocumentInformation7~
    }
    ISO20022.Camt111001.StructuredRemittanceInformation16 *-- ISO20022.Camt111001.Garnishment3
    ISO20022.Camt111001.StructuredRemittanceInformation16 *-- ISO20022.Camt111001.TaxInformation7
    ISO20022.Camt111001.StructuredRemittanceInformation16 *-- ISO20022.Camt111001.PartyIdentification135
    ISO20022.Camt111001.StructuredRemittanceInformation16 *-- ISO20022.Camt111001.PartyIdentification135
    ISO20022.Camt111001.StructuredRemittanceInformation16 *-- ISO20022.Camt111001.CreditorReferenceInformation2
    ISO20022.Camt111001.StructuredRemittanceInformation16 *-- ISO20022.Camt111001.RemittanceAmount2
    ISO20022.Camt111001.StructuredRemittanceInformation16 *-- ISO20022.Camt111001.ReferredDocumentInformation7
    class ISO20022.Camt111001.StructuredRemittanceInformation17 {
        + AddtlRmtInf  : global::System.Collections.Generic.List~String~
        + GrnshmtRmt  : ISO20022.Camt111001.Garnishment3
        + TaxRmt  : ISO20022.Camt111001.TaxData1
        + Invcee  : ISO20022.Camt111001.PartyIdentification135
        + Invcr  : ISO20022.Camt111001.PartyIdentification135
        + CdtrRefInf  : ISO20022.Camt111001.CreditorReferenceInformation2
        + RfrdDocAmt  : ISO20022.Camt111001.RemittanceAmount2
        + RfrdDocInf  : global::System.Collections.Generic.List~ISO20022.Camt111001.ReferredDocumentInformation7~
    }
    ISO20022.Camt111001.StructuredRemittanceInformation17 *-- ISO20022.Camt111001.Garnishment3
    ISO20022.Camt111001.StructuredRemittanceInformation17 *-- ISO20022.Camt111001.TaxData1
    ISO20022.Camt111001.StructuredRemittanceInformation17 *-- ISO20022.Camt111001.PartyIdentification135
    ISO20022.Camt111001.StructuredRemittanceInformation17 *-- ISO20022.Camt111001.PartyIdentification135
    ISO20022.Camt111001.StructuredRemittanceInformation17 *-- ISO20022.Camt111001.CreditorReferenceInformation2
    ISO20022.Camt111001.StructuredRemittanceInformation17 *-- ISO20022.Camt111001.RemittanceAmount2
    ISO20022.Camt111001.StructuredRemittanceInformation17 *-- ISO20022.Camt111001.ReferredDocumentInformation7
    class ISO20022.Camt111001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt111001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt111001.SupplementaryData1 *-- ISO20022.Camt111001.SupplementaryDataEnvelope1
    class ISO20022.Camt111001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Camt111001.TaxAmount2 {
        + Dtls  : global::System.Collections.Generic.List~ISO20022.Camt111001.TaxRecordDetails2~
        + TtlAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + TaxblBaseAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + Rate  : Decimal
    }
    ISO20022.Camt111001.TaxAmount2 *-- ISO20022.Camt111001.TaxRecordDetails2
    ISO20022.Camt111001.TaxAmount2 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.TaxAmount2 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt111001.TaxAmount3 {
        + Dtls  : global::System.Collections.Generic.List~ISO20022.Camt111001.TaxRecordDetails3~
        + TtlAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + TaxblBaseAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + Rate  : Decimal
    }
    ISO20022.Camt111001.TaxAmount3 *-- ISO20022.Camt111001.TaxRecordDetails3
    ISO20022.Camt111001.TaxAmount3 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.TaxAmount3 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt111001.TaxAmountAndType1 {
        + Amt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + Tp  : ISO20022.Camt111001.TaxAmountType1Choice
    }
    ISO20022.Camt111001.TaxAmountAndType1 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.TaxAmountAndType1 *-- ISO20022.Camt111001.TaxAmountType1Choice
    class ISO20022.Camt111001.TaxAmountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.TaxAuthorisation1 {
        + Nm  : String
        + Titl  : String
    }
    class ISO20022.Camt111001.TaxCharges2 {
        + Amt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + Rate  : Decimal
        + Id  : String
    }
    ISO20022.Camt111001.TaxCharges2 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt111001.TaxData1 {
        + Rcrd  : global::System.Collections.Generic.List~ISO20022.Camt111001.TaxRecord3~
        + SeqNb  : Decimal
        + Dt  : DateTime
        + TtlTaxAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + TtlTaxblBaseAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + Mtd  : String
        + RefNb  : String
        + AdmstnZone  : String
        + UltmtDbtr  : ISO20022.Camt111001.TaxParty2
        + Dbtr  : ISO20022.Camt111001.TaxParty2
        + Cdtr  : ISO20022.Camt111001.TaxParty1
    }
    ISO20022.Camt111001.TaxData1 *-- ISO20022.Camt111001.TaxRecord3
    ISO20022.Camt111001.TaxData1 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.TaxData1 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.TaxData1 *-- ISO20022.Camt111001.TaxParty2
    ISO20022.Camt111001.TaxData1 *-- ISO20022.Camt111001.TaxParty2
    ISO20022.Camt111001.TaxData1 *-- ISO20022.Camt111001.TaxParty1
    class ISO20022.Camt111001.TaxInformation7 {
        + Rcrd  : global::System.Collections.Generic.List~ISO20022.Camt111001.TaxRecord2~
        + SeqNb  : Decimal
        + Dt  : DateTime
        + TtlTaxAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + TtlTaxblBaseAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + Mtd  : String
        + RefNb  : String
        + AdmstnZone  : String
        + UltmtDbtr  : ISO20022.Camt111001.TaxParty2
        + Dbtr  : ISO20022.Camt111001.TaxParty2
        + Cdtr  : ISO20022.Camt111001.TaxParty1
    }
    ISO20022.Camt111001.TaxInformation7 *-- ISO20022.Camt111001.TaxRecord2
    ISO20022.Camt111001.TaxInformation7 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.TaxInformation7 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.TaxInformation7 *-- ISO20022.Camt111001.TaxParty2
    ISO20022.Camt111001.TaxInformation7 *-- ISO20022.Camt111001.TaxParty2
    ISO20022.Camt111001.TaxInformation7 *-- ISO20022.Camt111001.TaxParty1
    class ISO20022.Camt111001.TaxParty1 {
        + TaxTp  : String
        + RegnId  : String
        + TaxId  : String
    }
    class ISO20022.Camt111001.TaxParty2 {
        + Authstn  : ISO20022.Camt111001.TaxAuthorisation1
        + TaxTp  : String
        + RegnId  : String
        + TaxId  : String
    }
    ISO20022.Camt111001.TaxParty2 *-- ISO20022.Camt111001.TaxAuthorisation1
    class ISO20022.Camt111001.TaxPeriod2 {
        + FrToDt  : ISO20022.Camt111001.DatePeriod2
        + Tp  : String
        + Yr  : DateTime
    }
    ISO20022.Camt111001.TaxPeriod2 *-- ISO20022.Camt111001.DatePeriod2
    class ISO20022.Camt111001.TaxPeriod3 {
        + FrToDt  : ISO20022.Camt111001.DatePeriod2
        + Tp  : String
        + Yr  : Int32
    }
    ISO20022.Camt111001.TaxPeriod3 *-- ISO20022.Camt111001.DatePeriod2
    class ISO20022.Camt111001.TaxRecord2 {
        + AddtlInf  : String
        + TaxAmt  : ISO20022.Camt111001.TaxAmount2
        + Prd  : ISO20022.Camt111001.TaxPeriod2
        + FrmsCd  : String
        + CertId  : String
        + DbtrSts  : String
        + CtgyDtls  : String
        + Ctgy  : String
        + Tp  : String
    }
    ISO20022.Camt111001.TaxRecord2 *-- ISO20022.Camt111001.TaxAmount2
    ISO20022.Camt111001.TaxRecord2 *-- ISO20022.Camt111001.TaxPeriod2
    class ISO20022.Camt111001.TaxRecord3 {
        + AddtlInf  : String
        + TaxAmt  : ISO20022.Camt111001.TaxAmount3
        + Prd  : ISO20022.Camt111001.TaxPeriod3
        + FrmsCd  : String
        + CertId  : String
        + DbtrSts  : String
        + CtgyDtls  : String
        + Ctgy  : String
        + Tp  : String
    }
    ISO20022.Camt111001.TaxRecord3 *-- ISO20022.Camt111001.TaxAmount3
    ISO20022.Camt111001.TaxRecord3 *-- ISO20022.Camt111001.TaxPeriod3
    class ISO20022.Camt111001.TaxRecordDetails2 {
        + Amt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + Prd  : ISO20022.Camt111001.TaxPeriod2
    }
    ISO20022.Camt111001.TaxRecordDetails2 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.TaxRecordDetails2 *-- ISO20022.Camt111001.TaxPeriod2
    class ISO20022.Camt111001.TaxRecordDetails3 {
        + Amt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + Prd  : ISO20022.Camt111001.TaxPeriod3
    }
    ISO20022.Camt111001.TaxRecordDetails3 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.TaxRecordDetails3 *-- ISO20022.Camt111001.TaxPeriod3
    class ISO20022.Camt111001.TaxRecordPeriod1Code {
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
    class ISO20022.Camt111001.TransactionAmendment1 {
        + Rcrd  : ISO20022.Camt111001.TransactionAmendment1Choice
        + Pth  : String
    }
    ISO20022.Camt111001.TransactionAmendment1 *-- ISO20022.Camt111001.TransactionAmendment1Choice
    class ISO20022.Camt111001.TransactionAmendment1Choice {
        + Othr  : String
        + Rmt  : ISO20022.Camt111001.Remittance1
        + Pty  : ISO20022.Camt111001.PartyIdentification135
        + DtTm  : DateTime
        + Dt  : DateTime
        + Cd  : String
        + CshAcct  : ISO20022.Camt111001.CashAccount40
        + BICFI  : String
        + AnyBIC  : String
        + Amt  : ISO20022.Camt111001.ActiveCurrencyAndAmount
        + Agt  : ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
    }
    ISO20022.Camt111001.TransactionAmendment1Choice *-- ISO20022.Camt111001.Remittance1
    ISO20022.Camt111001.TransactionAmendment1Choice *-- ISO20022.Camt111001.PartyIdentification135
    ISO20022.Camt111001.TransactionAmendment1Choice *-- ISO20022.Camt111001.CashAccount40
    ISO20022.Camt111001.TransactionAmendment1Choice *-- ISO20022.Camt111001.ActiveCurrencyAndAmount
    ISO20022.Camt111001.TransactionAmendment1Choice *-- ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6
    class ISO20022.Camt111001.TransactionReferences6 {
        + Prtry  : global::System.Collections.Generic.List~ISO20022.Camt111001.ProprietaryReference1~
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
    ISO20022.Camt111001.TransactionReferences6 *-- ISO20022.Camt111001.ProprietaryReference1
    class ISO20022.Camt111001.TransactionStatus1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.UnderlyingData2Choice {
        + Othr  : ISO20022.Camt111001.GenericIdentification1
        + Acct  : ISO20022.Camt111001.CashAccount40
        + StmtNtry  : ISO20022.Camt111001.UnderlyingStatementEntry5
        + IntrBk  : ISO20022.Camt111001.UnderlyingPaymentTransaction7
        + Initn  : ISO20022.Camt111001.UnderlyingPaymentInstruction8
    }
    ISO20022.Camt111001.UnderlyingData2Choice *-- ISO20022.Camt111001.GenericIdentification1
    ISO20022.Camt111001.UnderlyingData2Choice *-- ISO20022.Camt111001.CashAccount40
    ISO20022.Camt111001.UnderlyingData2Choice *-- ISO20022.Camt111001.UnderlyingStatementEntry5
    ISO20022.Camt111001.UnderlyingData2Choice *-- ISO20022.Camt111001.UnderlyingPaymentTransaction7
    ISO20022.Camt111001.UnderlyingData2Choice *-- ISO20022.Camt111001.UnderlyingPaymentInstruction8
    class ISO20022.Camt111001.UnderlyingGroupInformation1 {
        + OrgnlMsgDlvryChanl  : String
        + OrgnlCreDtTm  : DateTime
        + OrgnlMsgNmId  : String
        + OrgnlMsgId  : String
    }
    class ISO20022.Camt111001.UnderlyingInvestigationInstrument1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt111001.UnderlyingPaymentInstruction8 {
        + OrgnlSvcLvl  : ISO20022.Camt111001.ServiceLevel8Choice
        + OrgnlTxRef  : ISO20022.Camt111001.OriginalTransactionReference35
        + ReqdColltnDt  : DateTime
        + ReqdExctnDt  : ISO20022.Camt111001.DateAndDateTime2Choice
        + OrgnlInstdAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + OrgnlUETR  : String
        + OrgnlEndToEndId  : String
        + OrgnlInstrId  : String
        + OrgnlPmtInfId  : String
        + OrgnlGrpInf  : ISO20022.Camt111001.UnderlyingGroupInformation1
    }
    ISO20022.Camt111001.UnderlyingPaymentInstruction8 *-- ISO20022.Camt111001.ServiceLevel8Choice
    ISO20022.Camt111001.UnderlyingPaymentInstruction8 *-- ISO20022.Camt111001.OriginalTransactionReference35
    ISO20022.Camt111001.UnderlyingPaymentInstruction8 *-- ISO20022.Camt111001.DateAndDateTime2Choice
    ISO20022.Camt111001.UnderlyingPaymentInstruction8 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.UnderlyingPaymentInstruction8 *-- ISO20022.Camt111001.UnderlyingGroupInformation1
    class ISO20022.Camt111001.UnderlyingPaymentTransaction7 {
        + OrgnlSvcLvl  : ISO20022.Camt111001.ServiceLevel8Choice
        + OrgnlTxRef  : ISO20022.Camt111001.OriginalTransactionReference35
        + OrgnlIntrBkSttlmDt  : DateTime
        + OrgnlIntrBkSttlmAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + OrgnlUETR  : String
        + OrgnlTxId  : String
        + OrgnlEndToEndId  : String
        + OrgnlInstrId  : String
        + OrgnlGrpInf  : ISO20022.Camt111001.UnderlyingGroupInformation1
    }
    ISO20022.Camt111001.UnderlyingPaymentTransaction7 *-- ISO20022.Camt111001.ServiceLevel8Choice
    ISO20022.Camt111001.UnderlyingPaymentTransaction7 *-- ISO20022.Camt111001.OriginalTransactionReference35
    ISO20022.Camt111001.UnderlyingPaymentTransaction7 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.UnderlyingPaymentTransaction7 *-- ISO20022.Camt111001.UnderlyingGroupInformation1
    class ISO20022.Camt111001.UnderlyingStatementEntry5 {
        + OrgnlNtryValDt  : ISO20022.Camt111001.DateAndDateTime2Choice
        + OrgnlNtryAmt  : ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
        + OrgnlUETR  : String
        + OrgnlNtryRef  : String
        + OrgnlStmtId  : String
        + OrgnlGrpInf  : ISO20022.Camt111001.OriginalGroupInformation29
        + OrgnlAcct  : ISO20022.Camt111001.CashAccount40
    }
    ISO20022.Camt111001.UnderlyingStatementEntry5 *-- ISO20022.Camt111001.DateAndDateTime2Choice
    ISO20022.Camt111001.UnderlyingStatementEntry5 *-- ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Camt111001.UnderlyingStatementEntry5 *-- ISO20022.Camt111001.OriginalGroupInformation29
    ISO20022.Camt111001.UnderlyingStatementEntry5 *-- ISO20022.Camt111001.CashAccount40
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

## Value ISO20022.Camt111001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt111001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt111001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Camt111001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt111001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt111001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.AdjustmentCompensation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|String||XmlElement()||
|+|IntrstRate|Decimal||XmlElement()||
|+|Prd|ISO20022.Camt111001.DatePeriod5||XmlElement()||
|+|CompstnAcct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|CompstnAgt|ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|AmtDue|ISO20022.Camt111001.ActiveCurrencyAndAmount||XmlElement()||
|+|DueChrgs|ISO20022.Camt111001.ActiveCurrencyAndAmount||XmlElement()||
|+|InitlAmt|ISO20022.Camt111001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prd),validElement(CompstnAcct),validElement(CompstnAgt),validElement(AmtDue),validElement(DueChrgs),validElement(InitlAmt))|

---

## Value ISO20022.Camt111001.AmendmentInformationDetails14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlTrckgDays|String||XmlElement()||
|+|OrgnlRsn|ISO20022.Camt111001.MandateSetupReason1Choice||XmlElement()||
|+|OrgnlFrqcy|ISO20022.Camt111001.Frequency36Choice||XmlElement()||
|+|OrgnlFnlColltnDt|DateTime||XmlElement()||
|+|OrgnlDbtrAgtAcct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|OrgnlDbtrAgt|ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|OrgnlDbtrAcct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|OrgnlDbtr|ISO20022.Camt111001.PartyIdentification135||XmlElement()||
|+|OrgnlCdtrAgtAcct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|OrgnlCdtrAgt|ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|OrgnlCdtrSchmeId|ISO20022.Camt111001.PartyIdentification135||XmlElement()||
|+|OrgnlMndtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""OrgnlTrckgDays""",OrgnlTrckgDays,"""[0-9]{2}"""),validElement(OrgnlRsn),validElement(OrgnlFrqcy),validElement(OrgnlDbtrAgtAcct),validElement(OrgnlDbtrAgt),validElement(OrgnlDbtrAcct),validElement(OrgnlDbtr),validElement(OrgnlCdtrAgtAcct),validElement(OrgnlCdtrAgt),validElement(OrgnlCdtrSchmeId))|

---

## Value ISO20022.Camt111001.AmountType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EqvtAmt|ISO20022.Camt111001.EquivalentAmount2||XmlElement()||
|+|InstdAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EqvtAmt),validElement(InstdAmt),validChoice(EqvtAmt,InstdAmt))|

---

## Value ISO20022.Camt111001.BookingConfirmation5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|String||XmlElement()||
|+|Chrgs|ISO20022.Camt111001.Charges6||XmlElement()||
|+|Refs|ISO20022.Camt111001.TransactionReferences6||XmlElement()||
|+|ValDt|ISO20022.Camt111001.DateAndDateTime2Choice||XmlElement()||
|+|BookgDt|ISO20022.Camt111001.DateAndDateTime2Choice||XmlElement()||
|+|Acct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Chrgs),validElement(Refs),validElement(ValDt),validElement(BookgDt),validElement(Acct),validElement(Amt))|

---

## Value ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt111001.BranchData3||XmlElement()||
|+|FinInstnId|ISO20022.Camt111001.FinancialInstitutionIdentification18||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt111001.BranchData3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt111001.PostalAddress24||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Camt111001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Camt111001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Camt111001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Camt111001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Camt111001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.CategoryPurpose1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt111001.ChargeBearerType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLEV|Int32||XmlEnum("""SLEV""")|1|
||SHAR|Int32||XmlEnum("""SHAR""")|2|
||CRED|Int32||XmlEnum("""CRED""")|3|
||DEBT|Int32||XmlEnum("""DEBT""")|4|

---

## Value ISO20022.Camt111001.ChargeType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt111001.GenericIdentification3||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.Charges6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rcrd|global::System.Collections.Generic.List<ISO20022.Camt111001.ChargesRecord3>||XmlElement()||
|+|TtlChrgsAndTaxAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rcrd""",Rcrd),validElement(Rcrd),validElement(TtlChrgsAndTaxAmt))|

---

## Value ISO20022.Camt111001.ChargesRecord3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tax|ISO20022.Camt111001.TaxCharges2||XmlElement()||
|+|Agt|ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|Br|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Tp|ISO20022.Camt111001.ChargeType3Choice||XmlElement()||
|+|ChrgInclInd|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tax),validElement(Agt),validElement(Tp),validElement(Amt))|

---

## Enum ISO20022.Camt111001.ClearingChannel2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOOK|Int32||XmlEnum("""BOOK""")|1|
||MPNS|Int32||XmlEnum("""MPNS""")|2|
||RTNS|Int32||XmlEnum("""RTNS""")|3|
||RTGS|Int32||XmlEnum("""RTGS""")|4|

---

## Value ISO20022.Camt111001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.ClearingSystemIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt111001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Camt111001.CompensationResponse1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|String||XmlElement()||
|+|IntrstRate|Decimal||XmlElement()||
|+|Prd|ISO20022.Camt111001.DatePeriod2||XmlElement()||
|+|XpctdValDt|DateTime||XmlElement()||
|+|AmtDue|ISO20022.Camt111001.ActiveCurrencyAndAmount||XmlElement()||
|+|PdChrgs|ISO20022.Camt111001.ActiveCurrencyAndAmount||XmlElement()||
|+|InitlAmt|ISO20022.Camt111001.ActiveCurrencyAndAmount||XmlElement()||
|+|Grantd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prd),validElement(AmtDue),validElement(PdChrgs),validElement(InitlAmt))|

---

## Value ISO20022.Camt111001.Contact4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt111001.OtherContact1>||XmlElement()||
|+|Dept|String||XmlElement()||
|+|Rspnsblty|String||XmlElement()||
|+|JobTitl|String||XmlElement()||
|+|EmailPurp|String||XmlElement()||
|+|EmailAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|MobNb|String||XmlElement()||
|+|PhneNb|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|NmPrfx|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""MobNb""",MobNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""PhneNb""",PhneNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Enum ISO20022.Camt111001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Camt111001.CreditTransferMandateData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|ISO20022.Camt111001.MandateSetupReason1Choice||XmlElement()||
|+|Frqcy|ISO20022.Camt111001.Frequency36Choice||XmlElement()||
|+|FnlPmtDt|DateTime||XmlElement()||
|+|FrstPmtDt|DateTime||XmlElement()||
|+|ElctrncSgntr|String||XmlElement()||
|+|DtOfVrfctn|DateTime||XmlElement()||
|+|DtOfSgntr|DateTime||XmlElement()||
|+|Tp|ISO20022.Camt111001.MandateTypeInformation2||XmlElement()||
|+|MndtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn),validElement(Frqcy),validElement(Tp))|

---

## Value ISO20022.Camt111001.CreditorReferenceInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|String||XmlElement()||
|+|Tp|ISO20022.Camt111001.CreditorReferenceType2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt111001.CreditorReferenceType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.CreditorReferenceType2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Camt111001.CreditorReferenceType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Camt111001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Camt111001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Camt111001.DatePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt111001.DatePeriod5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ReqdValDt|DateTime||XmlElement()||
|+|CurValDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt111001.DebitAuthorisationConfirmation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|String||XmlElement()||
|+|CmonTxId|String||XmlElement()||
|+|ValDtToDbt|DateTime||XmlElement()||
|+|Acct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|AmtToDbt|ISO20022.Camt111001.ActiveCurrencyAndAmount||XmlElement()||
|+|DbtAuthstn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Acct),validElement(AmtToDbt))|

---

## Value ISO20022.Camt111001.DiscountAmountAndType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Camt111001.DiscountAmountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Tp))|

---

## Value ISO20022.Camt111001.DiscountAmountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Type ISO20022.Camt111001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InvstgtnRspn|ISO20022.Camt111001.InvestigationResponseV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InvstgtnRspn))|

---

## Value ISO20022.Camt111001.Document12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nclsr|String||XmlElement()||
|+|DgtlSgntr|ISO20022.Camt111001.PartyAndSignature3||XmlElement()||
|+|FileNm|String||XmlElement()||
|+|Frmt|ISO20022.Camt111001.DocumentFormat1Choice||XmlElement()||
|+|LangCd|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|IsseDt|ISO20022.Camt111001.DateAndDateTime2Choice||XmlElement()||
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Camt111001.DocumentType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DgtlSgntr),validElement(Frmt),validElement(IsseDt),validElement(Tp))|

---

## Value ISO20022.Camt111001.DocumentAdjustment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Camt111001.DocumentFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt111001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.DocumentLineIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltdDt|DateTime||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|ISO20022.Camt111001.DocumentLineType1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt111001.DocumentLineInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt111001.RemittanceAmount3||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Id|global::System.Collections.Generic.List<ISO20022.Camt111001.DocumentLineIdentification1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validRequired("""Id""",Id),validList("""Id""",Id),validElement(Id))|

---

## Value ISO20022.Camt111001.DocumentLineType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Camt111001.DocumentLineType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Camt111001.DocumentLineType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.DocumentType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt111001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt111001.DocumentType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SCOR|Int32||XmlEnum("""SCOR""")|1|
||PUOR|Int32||XmlEnum("""PUOR""")|2|
||DISP|Int32||XmlEnum("""DISP""")|3|
||FXDR|Int32||XmlEnum("""FXDR""")|4|
||RPIN|Int32||XmlEnum("""RPIN""")|5|
||RADM|Int32||XmlEnum("""RADM""")|6|

---

## Enum ISO20022.Camt111001.DocumentType6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUOR|Int32||XmlEnum("""PUOR""")|1|
||TSUT|Int32||XmlEnum("""TSUT""")|2|
||AROI|Int32||XmlEnum("""AROI""")|3|
||VCHR|Int32||XmlEnum("""VCHR""")|4|
||BOLD|Int32||XmlEnum("""BOLD""")|5|
||DISP|Int32||XmlEnum("""DISP""")|6|
||SOAC|Int32||XmlEnum("""SOAC""")|7|
||CMCN|Int32||XmlEnum("""CMCN""")|8|
||SBIN|Int32||XmlEnum("""SBIN""")|9|
||HIRI|Int32||XmlEnum("""HIRI""")|10|
||DEBN|Int32||XmlEnum("""DEBN""")|11|
||CREN|Int32||XmlEnum("""CREN""")|12|
||CINV|Int32||XmlEnum("""CINV""")|13|
||DNFA|Int32||XmlEnum("""DNFA""")|14|
||CNFA|Int32||XmlEnum("""CNFA""")|15|
||MSIN|Int32||XmlEnum("""MSIN""")|16|

---

## Value ISO20022.Camt111001.EquivalentAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyOfTrf|String||XmlElement()||
|+|Amt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CcyOfTrf""",CcyOfTrf,"""[A-Z]{3,3}"""),validElement(Amt))|

---

## Value ISO20022.Camt111001.FileData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FileLctnElctrncAdr|String||XmlElement()||
|+|NtwkRef|String||XmlElement()||
|+|FileNm|String||XmlElement()||
|+|Frmt|ISO20022.Camt111001.DocumentFormat1Choice||XmlElement()||
|+|IsseDt|ISO20022.Camt111001.DateAndDateTime2Choice||XmlElement()||
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Camt111001.DocumentType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Frmt),validElement(IsseDt),validElement(Tp))|

---

## Value ISO20022.Camt111001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.FinancialInstitutionIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt111001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt111001.PostalAddress24||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt111001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt111001.Frequency36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtInTm|ISO20022.Camt111001.FrequencyAndMoment1||XmlElement()||
|+|Prd|ISO20022.Camt111001.FrequencyPeriod1||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtInTm),validElement(Prd),validChoice(PtInTm,Prd,Tp))|

---

## Enum ISO20022.Camt111001.Frequency6Code


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

## Value ISO20022.Camt111001.FrequencyAndMoment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtInTm|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PtInTm""",PtInTm,"""[0-9]{2}"""))|

---

## Value ISO20022.Camt111001.FrequencyPeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CntPerPrd|Decimal||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt111001.Garnishment3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MplyeeTermntnInd|String||XmlElement()||
|+|FmlyMdclInsrncInd|String||XmlElement()||
|+|RmtdAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|GrnshmtAdmstr|ISO20022.Camt111001.PartyIdentification135||XmlElement()||
|+|Grnshee|ISO20022.Camt111001.PartyIdentification135||XmlElement()||
|+|Tp|ISO20022.Camt111001.GarnishmentType1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RmtdAmt),validElement(GrnshmtAdmstr),validElement(Grnshee),validElement(Tp))|

---

## Value ISO20022.Camt111001.GarnishmentType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Camt111001.GarnishmentType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Camt111001.GarnishmentType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt111001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt111001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt111001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt111001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt111001.GenericIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt111001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt111001.GenericOrganisationIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt111001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt111001.GenericPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt111001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt111001.InvestigationActionReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Rsn|ISO20022.Camt111001.InvestigationActionReason1Choice||XmlElement()||
|+|Orgtr|ISO20022.Camt111001.PartyIdentification135||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn),validElement(Orgtr))|

---

## Value ISO20022.Camt111001.InvestigationActionReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.InvestigationData6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RspnOrgtr|ISO20022.Camt111001.Party40Choice||XmlElement()||
|+|RltdFileData|global::System.Collections.Generic.List<ISO20022.Camt111001.FileData1>||XmlElement()||
|+|NclsdFile|global::System.Collections.Generic.List<ISO20022.Camt111001.Document12>||XmlElement()||
|+|RltdInvstgtnData|ISO20022.Camt111001.RelatedInvestigationData1||XmlElement()||
|+|RspnData|ISO20022.Camt111001.InvestigationDataRecord7Choice||XmlElement()||
|+|OrgnlInvstgtnRsnSubTp|ISO20022.Camt111001.InvestigationReasonSubType1Choice||XmlElement()||
|+|OrgnlInvstgtnRsn|ISO20022.Camt111001.InvestigationReason1Choice||XmlElement()||
|+|OrgnlInvstgtnSeq|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RspnOrgtr),validList("""RltdFileData""",RltdFileData),validElement(RltdFileData),validList("""NclsdFile""",NclsdFile),validElement(NclsdFile),validElement(RltdInvstgtnData),validElement(RspnData),validElement(OrgnlInvstgtnRsnSubTp),validElement(OrgnlInvstgtnRsn))|

---

## Value ISO20022.Camt111001.InvestigationDataRecord7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RspnNrrtv|String||XmlElement()||
|+|TxData|global::System.Collections.Generic.List<ISO20022.Camt111001.TransactionAmendment1>||XmlElement()||
|+|TxSts|ISO20022.Camt111001.PaymentTransactionStatus1||XmlElement()||
|+|Conf|ISO20022.Camt111001.BookingConfirmation5||XmlElement()||
|+|Valtn|ISO20022.Camt111001.AdjustmentCompensation1||XmlElement()||
|+|Compstn|ISO20022.Camt111001.CompensationResponse1||XmlElement()||
|+|DbtAuthstn|ISO20022.Camt111001.DebitAuthorisationConfirmation3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""TxData""",TxData),validList("""TxData""",TxData),validElement(TxData),validElement(TxSts),validElement(Conf),validElement(Valtn),validElement(Compstn),validElement(DbtAuthstn),validChoice(RspnNrrtv,TxData,TxSts,Conf,Valtn,Compstn,DbtAuthstn))|

---

## Value ISO20022.Camt111001.InvestigationLocationData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt111001.NameAndAddress16||XmlElement()||
|+|ElctrncAdr|String||XmlElement()||
|+|Mtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr))|

---

## Enum ISO20022.Camt111001.InvestigationLocationMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||URID|Int32||XmlEnum("""URID""")|1|
||SMSM|Int32||XmlEnum("""SMSM""")|2|
||POST|Int32||XmlEnum("""POST""")|3|
||FAXI|Int32||XmlEnum("""FAXI""")|4|
||EMAL|Int32||XmlEnum("""EMAL""")|5|
||EDIC|Int32||XmlEnum("""EDIC""")|6|

---

## Value ISO20022.Camt111001.InvestigationReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.InvestigationReasonSubType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.InvestigationRequest3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SvcLvl|global::System.Collections.Generic.List<ISO20022.Camt111001.InvestigationServiceLevel1Choice>||XmlElement()||
|+|XpctdRspndr|ISO20022.Camt111001.Party40Choice||XmlElement()||
|+|ReqOrgtr|ISO20022.Camt111001.Party40Choice||XmlElement()||
|+|Rspndr|ISO20022.Camt111001.Party40Choice||XmlElement()||
|+|Rqstr|ISO20022.Camt111001.Party40Choice||XmlElement()||
|+|Undrlyg|ISO20022.Camt111001.UnderlyingData2Choice||XmlElement()||
|+|UndrlygInstrm|ISO20022.Camt111001.UnderlyingInvestigationInstrument1Choice||XmlElement()||
|+|InvstgtnSubTp|ISO20022.Camt111001.InvestigationSubType1Choice||XmlElement()||
|+|InvstgtnTp|ISO20022.Camt111001.InvestigationType1Choice||XmlElement()||
|+|ReqActn|ISO20022.Camt111001.InvestigationRequestAction1||XmlElement()||
|+|EIR|String||XmlElement()||
|+|RspndrInvstgtnId|String||XmlElement()||
|+|RqstrInvstgtnId|String||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SvcLvl""",SvcLvl),validElement(SvcLvl),validElement(XpctdRspndr),validElement(ReqOrgtr),validElement(Rspndr),validElement(Rqstr),validElement(Undrlyg),validElement(UndrlygInstrm),validElement(InvstgtnSubTp),validElement(InvstgtnTp),validElement(ReqActn),validPattern("""EIR""",EIR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""))|

---

## Value ISO20022.Camt111001.InvestigationRequestAction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ActnRsn|ISO20022.Camt111001.InvestigationActionReason1||XmlElement()||
|+|Actn|ISO20022.Camt111001.InvestigationRequestAction1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ActnRsn),validElement(Actn))|

---

## Value ISO20022.Camt111001.InvestigationRequestAction1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.InvestigationResponse9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InvstgtnData|global::System.Collections.Generic.List<ISO20022.Camt111001.InvestigationData6>||XmlElement()||
|+|NxtRspndr|ISO20022.Camt111001.Party40Choice||XmlElement()||
|+|InvstgtnSts|ISO20022.Camt111001.InvestigationStatus2||XmlElement()||
|+|RspndrInvstgtnId|String||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""InvstgtnData""",InvstgtnData),validElement(InvstgtnData),validElement(NxtRspndr),validElement(InvstgtnSts))|

---

## Aspect ISO20022.Camt111001.InvestigationResponseV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt111001.SupplementaryData1>||XmlElement()||
|+|OrgnlInvstgtnReq|ISO20022.Camt111001.InvestigationRequest3||XmlElement()||
|+|InvstgtnRspn|ISO20022.Camt111001.InvestigationResponse9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(OrgnlInvstgtnReq),validElement(InvstgtnRspn))|

---

## Value ISO20022.Camt111001.InvestigationServiceLevel1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.InvestigationStatus2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StsRsn|ISO20022.Camt111001.InvestigationStatusReason1Choice||XmlElement()||
|+|Sts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StsRsn))|

---

## Value ISO20022.Camt111001.InvestigationStatusReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.InvestigationSubType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.InvestigationType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.LocalInstrument2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.MandateClassification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt111001.MandateClassification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|
||USGB|Int32||XmlEnum("""USGB""")|2|
||FIXE|Int32||XmlEnum("""FIXE""")|3|

---

## Value ISO20022.Camt111001.MandateRelatedData2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtTrfMndt|ISO20022.Camt111001.CreditTransferMandateData1||XmlElement()||
|+|DrctDbtMndt|ISO20022.Camt111001.MandateRelatedInformation15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtTrfMndt),validElement(DrctDbtMndt),validChoice(CdtTrfMndt,DrctDbtMndt))|

---

## Value ISO20022.Camt111001.MandateRelatedInformation15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrckgDays|String||XmlElement()||
|+|Rsn|ISO20022.Camt111001.MandateSetupReason1Choice||XmlElement()||
|+|Frqcy|ISO20022.Camt111001.Frequency36Choice||XmlElement()||
|+|FnlColltnDt|DateTime||XmlElement()||
|+|FrstColltnDt|DateTime||XmlElement()||
|+|ElctrncSgntr|String||XmlElement()||
|+|AmdmntInfDtls|ISO20022.Camt111001.AmendmentInformationDetails14||XmlElement()||
|+|AmdmntInd|String||XmlElement()||
|+|DtOfSgntr|DateTime||XmlElement()||
|+|MndtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TrckgDays""",TrckgDays,"""[0-9]{2}"""),validElement(Rsn),validElement(Frqcy),validElement(AmdmntInfDtls))|

---

## Value ISO20022.Camt111001.MandateSetupReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.MandateTypeInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Clssfctn|ISO20022.Camt111001.MandateClassification1Choice||XmlElement()||
|+|CtgyPurp|ISO20022.Camt111001.CategoryPurpose1Choice||XmlElement()||
|+|LclInstrm|ISO20022.Camt111001.LocalInstrument2Choice||XmlElement()||
|+|SvcLvl|ISO20022.Camt111001.ServiceLevel8Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Clssfctn),validElement(CtgyPurp),validElement(LclInstrm),validElement(SvcLvl))|

---

## Value ISO20022.Camt111001.NameAndAddress16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Camt111001.PostalAddress24||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Camt111001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Camt111001.OrganisationIdentification29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt111001.GenericOrganisationIdentification1>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt111001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.OriginalGroupInformation29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlCreDtTm|DateTime||XmlElement()||
|+|OrgnlMsgNmId|String||XmlElement()||
|+|OrgnlMsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt111001.OriginalTransactionReference35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Purp|ISO20022.Camt111001.Purpose2Choice||XmlElement()||
|+|UltmtCdtr|ISO20022.Camt111001.Party40Choice||XmlElement()||
|+|CdtrAcct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|Cdtr|ISO20022.Camt111001.Party40Choice||XmlElement()||
|+|CdtrAgtAcct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|CdtrAgt|ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|DbtrAgtAcct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|DbtrAgt|ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|DbtrAcct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|Dbtr|ISO20022.Camt111001.Party40Choice||XmlElement()||
|+|UltmtDbtr|ISO20022.Camt111001.Party40Choice||XmlElement()||
|+|RmtInf|ISO20022.Camt111001.RemittanceInformation21||XmlElement()||
|+|MndtRltdInf|ISO20022.Camt111001.MandateRelatedData2Choice||XmlElement()||
|+|PmtMtd|String||XmlElement()||
|+|PmtTpInf|ISO20022.Camt111001.PaymentTypeInformation27||XmlElement()||
|+|SttlmInf|ISO20022.Camt111001.SettlementInstruction11||XmlElement()||
|+|CdtrSchmeId|ISO20022.Camt111001.PartyIdentification135||XmlElement()||
|+|ReqdExctnDt|ISO20022.Camt111001.DateAndDateTime2Choice||XmlElement()||
|+|ReqdColltnDt|DateTime||XmlElement()||
|+|IntrBkSttlmDt|DateTime||XmlElement()||
|+|Amt|ISO20022.Camt111001.AmountType4Choice||XmlElement()||
|+|IntrBkSttlmAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Purp),validElement(UltmtCdtr),validElement(CdtrAcct),validElement(Cdtr),validElement(CdtrAgtAcct),validElement(CdtrAgt),validElement(DbtrAgtAcct),validElement(DbtrAgt),validElement(DbtrAcct),validElement(Dbtr),validElement(UltmtDbtr),validElement(RmtInf),validElement(MndtRltdInf),validElement(PmtTpInf),validElement(SttlmInf),validElement(CdtrSchmeId),validElement(ReqdExctnDt),validElement(Amt),validElement(IntrBkSttlmAmt))|

---

## Value ISO20022.Camt111001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt111001.Party38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Camt111001.PersonIdentification13||XmlElement()||
|+|OrgId|ISO20022.Camt111001.OrganisationIdentification29||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Camt111001.Party40Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Agt|ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|Pty|ISO20022.Camt111001.PartyIdentification135||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Agt),validElement(Pty),validChoice(Agt,Pty))|

---

## Value ISO20022.Camt111001.PartyAndSignature3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgntr|ISO20022.Camt111001.SkipPayload||XmlElement()||
|+|Pty|ISO20022.Camt111001.PartyIdentification135||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Sgntr),validElement(Pty))|

---

## Value ISO20022.Camt111001.PartyIdentification135


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Camt111001.Contact4||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Camt111001.Party38Choice||XmlElement()||
|+|PstlAdr|ISO20022.Camt111001.PostalAddress24||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Enum ISO20022.Camt111001.PaymentMethod4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRA|Int32||XmlEnum("""TRA""")|1|
||DD|Int32||XmlEnum("""DD""")|2|
||TRF|Int32||XmlEnum("""TRF""")|3|
||CHK|Int32||XmlEnum("""CHK""")|4|

---

## Value ISO20022.Camt111001.PaymentTransactionStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StsRsnInf|global::System.Collections.Generic.List<ISO20022.Camt111001.StatusReasonInformation12>||XmlElement()||
|+|Sts|ISO20022.Camt111001.TransactionStatus1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""StsRsnInf""",StsRsnInf),validElement(StsRsnInf),validElement(Sts))|

---

## Value ISO20022.Camt111001.PaymentTypeInformation27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtgyPurp|ISO20022.Camt111001.CategoryPurpose1Choice||XmlElement()||
|+|SeqTp|String||XmlElement()||
|+|LclInstrm|ISO20022.Camt111001.LocalInstrument2Choice||XmlElement()||
|+|SvcLvl|global::System.Collections.Generic.List<ISO20022.Camt111001.ServiceLevel8Choice>||XmlElement()||
|+|ClrChanl|String||XmlElement()||
|+|InstrPrty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtgyPurp),validElement(LclInstrm),validList("""SvcLvl""",SvcLvl),validElement(SvcLvl))|

---

## Value ISO20022.Camt111001.PersonIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt111001.GenericPersonIdentification1>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Camt111001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Camt111001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.PostalAddress24


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
|+|Flr|String||XmlElement()||
|+|BldgNm|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|SubDept|String||XmlElement()||
|+|Dept|String||XmlElement()||
|+|AdrTp|ISO20022.Camt111001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Camt111001.PreferredContactMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CELL|Int32||XmlEnum("""CELL""")|1|
||FAXX|Int32||XmlEnum("""FAXX""")|2|
||PHON|Int32||XmlEnum("""PHON""")|3|
||MAIL|Int32||XmlEnum("""MAIL""")|4|
||LETT|Int32||XmlEnum("""LETT""")|5|

---

## Enum ISO20022.Camt111001.Priority2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORM|Int32||XmlEnum("""NORM""")|1|
||HIGH|Int32||XmlEnum("""HIGH""")|2|

---

## Value ISO20022.Camt111001.ProprietaryReference1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt111001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Camt111001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt111001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.Purpose2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.ReferredDocumentInformation7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LineDtls|global::System.Collections.Generic.List<ISO20022.Camt111001.DocumentLineInformation1>||XmlElement()||
|+|RltdDt|DateTime||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|ISO20022.Camt111001.ReferredDocumentType4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LineDtls""",LineDtls),validElement(LineDtls),validElement(Tp))|

---

## Value ISO20022.Camt111001.ReferredDocumentType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.ReferredDocumentType4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Camt111001.ReferredDocumentType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Camt111001.RelatedInvestigationData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lctn|global::System.Collections.Generic.List<ISO20022.Camt111001.InvestigationLocationData1>||XmlElement()||
|+|InvstgtnId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Lctn""",Lctn),validElement(Lctn))|

---

## Value ISO20022.Camt111001.Remittance1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rltd|global::System.Collections.Generic.List<ISO20022.Camt111001.RemittanceLocation7>||XmlElement()||
|+|Strd|global::System.Collections.Generic.List<ISO20022.Camt111001.StructuredRemittanceInformation16>||XmlElement()||
|+|Ustrd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rltd""",Rltd),validListMax("""Rltd""",Rltd,10),validElement(Rltd),validList("""Strd""",Strd),validElement(Strd))|

---

## Value ISO20022.Camt111001.RemittanceAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RmtdAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|AdjstmntAmtAndRsn|global::System.Collections.Generic.List<ISO20022.Camt111001.DocumentAdjustment1>||XmlElement()||
|+|TaxAmt|global::System.Collections.Generic.List<ISO20022.Camt111001.TaxAmountAndType1>||XmlElement()||
|+|CdtNoteAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|DscntApldAmt|global::System.Collections.Generic.List<ISO20022.Camt111001.DiscountAmountAndType1>||XmlElement()||
|+|DuePyblAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RmtdAmt),validList("""AdjstmntAmtAndRsn""",AdjstmntAmtAndRsn),validElement(AdjstmntAmtAndRsn),validList("""TaxAmt""",TaxAmt),validElement(TaxAmt),validElement(CdtNoteAmt),validList("""DscntApldAmt""",DscntApldAmt),validElement(DscntApldAmt),validElement(DuePyblAmt))|

---

## Value ISO20022.Camt111001.RemittanceAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RmtdAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|AdjstmntAmtAndRsn|global::System.Collections.Generic.List<ISO20022.Camt111001.DocumentAdjustment1>||XmlElement()||
|+|TaxAmt|global::System.Collections.Generic.List<ISO20022.Camt111001.TaxAmountAndType1>||XmlElement()||
|+|CdtNoteAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|DscntApldAmt|global::System.Collections.Generic.List<ISO20022.Camt111001.DiscountAmountAndType1>||XmlElement()||
|+|DuePyblAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RmtdAmt),validList("""AdjstmntAmtAndRsn""",AdjstmntAmtAndRsn),validElement(AdjstmntAmtAndRsn),validList("""TaxAmt""",TaxAmt),validElement(TaxAmt),validElement(CdtNoteAmt),validList("""DscntApldAmt""",DscntApldAmt),validElement(DscntApldAmt),validElement(DuePyblAmt))|

---

## Value ISO20022.Camt111001.RemittanceInformation21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Strd|global::System.Collections.Generic.List<ISO20022.Camt111001.StructuredRemittanceInformation17>||XmlElement()||
|+|Ustrd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Strd""",Strd),validElement(Strd))|

---

## Value ISO20022.Camt111001.RemittanceLocation7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RmtLctnDtls|global::System.Collections.Generic.List<ISO20022.Camt111001.RemittanceLocationData1>||XmlElement()||
|+|RmtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RmtLctnDtls""",RmtLctnDtls),validElement(RmtLctnDtls))|

---

## Value ISO20022.Camt111001.RemittanceLocationData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt111001.NameAndAddress16||XmlElement()||
|+|ElctrncAdr|String||XmlElement()||
|+|Mtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr))|

---

## Enum ISO20022.Camt111001.RemittanceLocationMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SMSM|Int32||XmlEnum("""SMSM""")|1|
||POST|Int32||XmlEnum("""POST""")|2|
||EMAL|Int32||XmlEnum("""EMAL""")|3|
||URID|Int32||XmlEnum("""URID""")|4|
||EDIC|Int32||XmlEnum("""EDIC""")|5|
||FAXI|Int32||XmlEnum("""FAXI""")|6|

---

## Enum ISO20022.Camt111001.SequenceType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RPRE|Int32||XmlEnum("""RPRE""")|1|
||OOFF|Int32||XmlEnum("""OOFF""")|2|
||FNAL|Int32||XmlEnum("""FNAL""")|3|
||RCUR|Int32||XmlEnum("""RCUR""")|4|
||FRST|Int32||XmlEnum("""FRST""")|5|

---

## Value ISO20022.Camt111001.ServiceLevel8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.SettlementInstruction11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ThrdRmbrsmntAgtAcct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|ThrdRmbrsmntAgt|ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|InstdRmbrsmntAgtAcct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|InstdRmbrsmntAgt|ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|InstgRmbrsmntAgtAcct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|InstgRmbrsmntAgt|ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|ClrSys|ISO20022.Camt111001.ClearingSystemIdentification3Choice||XmlElement()||
|+|SttlmAcct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|SttlmMtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ThrdRmbrsmntAgtAcct),validElement(ThrdRmbrsmntAgt),validElement(InstdRmbrsmntAgtAcct),validElement(InstdRmbrsmntAgt),validElement(InstgRmbrsmntAgtAcct),validElement(InstgRmbrsmntAgt),validElement(ClrSys),validElement(SttlmAcct))|

---

## Enum ISO20022.Camt111001.SettlementMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CLRG|Int32||XmlEnum("""CLRG""")|1|
||COVE|Int32||XmlEnum("""COVE""")|2|
||INGA|Int32||XmlEnum("""INGA""")|3|
||INDA|Int32||XmlEnum("""INDA""")|4|

---

## Value ISO20022.Camt111001.SkipPayload


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt111001.StatusReason6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.StatusReasonInformation12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Rsn|ISO20022.Camt111001.StatusReason6Choice||XmlElement()||
|+|Orgtr|ISO20022.Camt111001.PartyIdentification135||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn),validElement(Orgtr))|

---

## Value ISO20022.Camt111001.StructuredRemittanceInformation16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRmtInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|GrnshmtRmt|ISO20022.Camt111001.Garnishment3||XmlElement()||
|+|TaxRmt|ISO20022.Camt111001.TaxInformation7||XmlElement()||
|+|Invcee|ISO20022.Camt111001.PartyIdentification135||XmlElement()||
|+|Invcr|ISO20022.Camt111001.PartyIdentification135||XmlElement()||
|+|CdtrRefInf|ISO20022.Camt111001.CreditorReferenceInformation2||XmlElement()||
|+|RfrdDocAmt|ISO20022.Camt111001.RemittanceAmount2||XmlElement()||
|+|RfrdDocInf|global::System.Collections.Generic.List<ISO20022.Camt111001.ReferredDocumentInformation7>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlRmtInf""",AddtlRmtInf,3),validElement(GrnshmtRmt),validElement(TaxRmt),validElement(Invcee),validElement(Invcr),validElement(CdtrRefInf),validElement(RfrdDocAmt),validList("""RfrdDocInf""",RfrdDocInf),validElement(RfrdDocInf))|

---

## Value ISO20022.Camt111001.StructuredRemittanceInformation17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRmtInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|GrnshmtRmt|ISO20022.Camt111001.Garnishment3||XmlElement()||
|+|TaxRmt|ISO20022.Camt111001.TaxData1||XmlElement()||
|+|Invcee|ISO20022.Camt111001.PartyIdentification135||XmlElement()||
|+|Invcr|ISO20022.Camt111001.PartyIdentification135||XmlElement()||
|+|CdtrRefInf|ISO20022.Camt111001.CreditorReferenceInformation2||XmlElement()||
|+|RfrdDocAmt|ISO20022.Camt111001.RemittanceAmount2||XmlElement()||
|+|RfrdDocInf|global::System.Collections.Generic.List<ISO20022.Camt111001.ReferredDocumentInformation7>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlRmtInf""",AddtlRmtInf,3),validElement(GrnshmtRmt),validElement(TaxRmt),validElement(Invcee),validElement(Invcr),validElement(CdtrRefInf),validElement(RfrdDocAmt),validList("""RfrdDocInf""",RfrdDocInf),validElement(RfrdDocInf))|

---

## Value ISO20022.Camt111001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt111001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt111001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt111001.TaxAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|global::System.Collections.Generic.List<ISO20022.Camt111001.TaxRecordDetails2>||XmlElement()||
|+|TtlAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TaxblBaseAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dtls""",Dtls),validElement(Dtls),validElement(TtlAmt),validElement(TaxblBaseAmt))|

---

## Value ISO20022.Camt111001.TaxAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|global::System.Collections.Generic.List<ISO20022.Camt111001.TaxRecordDetails3>||XmlElement()||
|+|TtlAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TaxblBaseAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dtls""",Dtls),validElement(Dtls),validElement(TtlAmt),validElement(TaxblBaseAmt))|

---

## Value ISO20022.Camt111001.TaxAmountAndType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Camt111001.TaxAmountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Tp))|

---

## Value ISO20022.Camt111001.TaxAmountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.TaxAuthorisation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Titl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt111001.TaxCharges2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Camt111001.TaxData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rcrd|global::System.Collections.Generic.List<ISO20022.Camt111001.TaxRecord3>||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|TtlTaxAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlTaxblBaseAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Mtd|String||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|AdmstnZone|String||XmlElement()||
|+|UltmtDbtr|ISO20022.Camt111001.TaxParty2||XmlElement()||
|+|Dbtr|ISO20022.Camt111001.TaxParty2||XmlElement()||
|+|Cdtr|ISO20022.Camt111001.TaxParty1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rcrd""",Rcrd),validElement(Rcrd),validElement(TtlTaxAmt),validElement(TtlTaxblBaseAmt),validElement(UltmtDbtr),validElement(Dbtr),validElement(Cdtr))|

---

## Value ISO20022.Camt111001.TaxInformation7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rcrd|global::System.Collections.Generic.List<ISO20022.Camt111001.TaxRecord2>||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|TtlTaxAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlTaxblBaseAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Mtd|String||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|AdmstnZone|String||XmlElement()||
|+|UltmtDbtr|ISO20022.Camt111001.TaxParty2||XmlElement()||
|+|Dbtr|ISO20022.Camt111001.TaxParty2||XmlElement()||
|+|Cdtr|ISO20022.Camt111001.TaxParty1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rcrd""",Rcrd),validElement(Rcrd),validElement(TtlTaxAmt),validElement(TtlTaxblBaseAmt),validElement(UltmtDbtr),validElement(Dbtr),validElement(Cdtr))|

---

## Value ISO20022.Camt111001.TaxParty1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxTp|String||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|TaxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt111001.TaxParty2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Authstn|ISO20022.Camt111001.TaxAuthorisation1||XmlElement()||
|+|TaxTp|String||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|TaxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Authstn))|

---

## Value ISO20022.Camt111001.TaxPeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrToDt|ISO20022.Camt111001.DatePeriod2||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Yr|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToDt))|

---

## Value ISO20022.Camt111001.TaxPeriod3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrToDt|ISO20022.Camt111001.DatePeriod2||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Yr|Int32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToDt))|

---

## Value ISO20022.Camt111001.TaxRecord2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|TaxAmt|ISO20022.Camt111001.TaxAmount2||XmlElement()||
|+|Prd|ISO20022.Camt111001.TaxPeriod2||XmlElement()||
|+|FrmsCd|String||XmlElement()||
|+|CertId|String||XmlElement()||
|+|DbtrSts|String||XmlElement()||
|+|CtgyDtls|String||XmlElement()||
|+|Ctgy|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxAmt),validElement(Prd))|

---

## Value ISO20022.Camt111001.TaxRecord3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|TaxAmt|ISO20022.Camt111001.TaxAmount3||XmlElement()||
|+|Prd|ISO20022.Camt111001.TaxPeriod3||XmlElement()||
|+|FrmsCd|String||XmlElement()||
|+|CertId|String||XmlElement()||
|+|DbtrSts|String||XmlElement()||
|+|CtgyDtls|String||XmlElement()||
|+|Ctgy|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxAmt),validElement(Prd))|

---

## Value ISO20022.Camt111001.TaxRecordDetails2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Prd|ISO20022.Camt111001.TaxPeriod2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Prd))|

---

## Value ISO20022.Camt111001.TaxRecordDetails3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Prd|ISO20022.Camt111001.TaxPeriod3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Prd))|

---

## Enum ISO20022.Camt111001.TaxRecordPeriod1Code


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

## Value ISO20022.Camt111001.TransactionAmendment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rcrd|ISO20022.Camt111001.TransactionAmendment1Choice||XmlElement()||
|+|Pth|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rcrd))|

---

## Value ISO20022.Camt111001.TransactionAmendment1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|String||XmlElement()||
|+|Rmt|ISO20022.Camt111001.Remittance1||XmlElement()||
|+|Pty|ISO20022.Camt111001.PartyIdentification135||XmlElement()||
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|Cd|String||XmlElement()||
|+|CshAcct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|BICFI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
|+|Amt|ISO20022.Camt111001.ActiveCurrencyAndAmount||XmlElement()||
|+|Agt|ISO20022.Camt111001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rmt),validElement(Pty),validElement(CshAcct),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(Amt),validElement(Agt),validChoice(Othr,Rmt,Pty,DtTm,Dt,Cd,CshAcct,BICFI,AnyBIC,Amt,Agt))|

---

## Value ISO20022.Camt111001.TransactionReferences6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|global::System.Collections.Generic.List<ISO20022.Camt111001.ProprietaryReference1>||XmlElement()||
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

## Value ISO20022.Camt111001.TransactionStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.UnderlyingData2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt111001.GenericIdentification1||XmlElement()||
|+|Acct|ISO20022.Camt111001.CashAccount40||XmlElement()||
|+|StmtNtry|ISO20022.Camt111001.UnderlyingStatementEntry5||XmlElement()||
|+|IntrBk|ISO20022.Camt111001.UnderlyingPaymentTransaction7||XmlElement()||
|+|Initn|ISO20022.Camt111001.UnderlyingPaymentInstruction8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(Acct),validElement(StmtNtry),validElement(IntrBk),validElement(Initn),validChoice(Othr,Acct,StmtNtry,IntrBk,Initn))|

---

## Value ISO20022.Camt111001.UnderlyingGroupInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlMsgDlvryChanl|String||XmlElement()||
|+|OrgnlCreDtTm|DateTime||XmlElement()||
|+|OrgnlMsgNmId|String||XmlElement()||
|+|OrgnlMsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt111001.UnderlyingInvestigationInstrument1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt111001.UnderlyingPaymentInstruction8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlSvcLvl|ISO20022.Camt111001.ServiceLevel8Choice||XmlElement()||
|+|OrgnlTxRef|ISO20022.Camt111001.OriginalTransactionReference35||XmlElement()||
|+|ReqdColltnDt|DateTime||XmlElement()||
|+|ReqdExctnDt|ISO20022.Camt111001.DateAndDateTime2Choice||XmlElement()||
|+|OrgnlInstdAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|OrgnlUETR|String||XmlElement()||
|+|OrgnlEndToEndId|String||XmlElement()||
|+|OrgnlInstrId|String||XmlElement()||
|+|OrgnlPmtInfId|String||XmlElement()||
|+|OrgnlGrpInf|ISO20022.Camt111001.UnderlyingGroupInformation1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlSvcLvl),validElement(OrgnlTxRef),validElement(ReqdExctnDt),validElement(OrgnlInstdAmt),validPattern("""OrgnlUETR""",OrgnlUETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""),validElement(OrgnlGrpInf))|

---

## Value ISO20022.Camt111001.UnderlyingPaymentTransaction7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlSvcLvl|ISO20022.Camt111001.ServiceLevel8Choice||XmlElement()||
|+|OrgnlTxRef|ISO20022.Camt111001.OriginalTransactionReference35||XmlElement()||
|+|OrgnlIntrBkSttlmDt|DateTime||XmlElement()||
|+|OrgnlIntrBkSttlmAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|OrgnlUETR|String||XmlElement()||
|+|OrgnlTxId|String||XmlElement()||
|+|OrgnlEndToEndId|String||XmlElement()||
|+|OrgnlInstrId|String||XmlElement()||
|+|OrgnlGrpInf|ISO20022.Camt111001.UnderlyingGroupInformation1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlSvcLvl),validElement(OrgnlTxRef),validElement(OrgnlIntrBkSttlmAmt),validPattern("""OrgnlUETR""",OrgnlUETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""),validElement(OrgnlGrpInf))|

---

## Value ISO20022.Camt111001.UnderlyingStatementEntry5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlNtryValDt|ISO20022.Camt111001.DateAndDateTime2Choice||XmlElement()||
|+|OrgnlNtryAmt|ISO20022.Camt111001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|OrgnlUETR|String||XmlElement()||
|+|OrgnlNtryRef|String||XmlElement()||
|+|OrgnlStmtId|String||XmlElement()||
|+|OrgnlGrpInf|ISO20022.Camt111001.OriginalGroupInformation29||XmlElement()||
|+|OrgnlAcct|ISO20022.Camt111001.CashAccount40||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlNtryValDt),validElement(OrgnlNtryAmt),validPattern("""OrgnlUETR""",OrgnlUETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""),validElement(OrgnlGrpInf),validElement(OrgnlAcct))|

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

