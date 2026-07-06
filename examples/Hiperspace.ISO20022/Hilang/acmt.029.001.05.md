# acmt.029.001.05
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Acmt029001.AccountIdentification4Choice {
        + Othr  : ISO20022.Acmt029001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Acmt029001.AccountIdentification4Choice *-- ISO20022.Acmt029001.GenericAccountIdentification1
    class ISO20022.Acmt029001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.AccountSwitchCancelExistingPaymentV05 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Acmt029001.SupplementaryData1~
        + DrctDbtInstr  : global::System.Collections.Generic.List~ISO20022.Acmt029001.DirectDebitInstructionDetails3~
        + PmtInstr  : global::System.Collections.Generic.List~ISO20022.Acmt029001.PaymentInstruction43~
        + OdAcct  : ISO20022.Acmt029001.CashAccount43
        + AcctSwtchDtls  : ISO20022.Acmt029001.AccountSwitchDetails1
        + MsgId  : ISO20022.Acmt029001.MessageIdentification1
    }
    ISO20022.Acmt029001.AccountSwitchCancelExistingPaymentV05 *-- ISO20022.Acmt029001.SupplementaryData1
    ISO20022.Acmt029001.AccountSwitchCancelExistingPaymentV05 *-- ISO20022.Acmt029001.DirectDebitInstructionDetails3
    ISO20022.Acmt029001.AccountSwitchCancelExistingPaymentV05 *-- ISO20022.Acmt029001.PaymentInstruction43
    ISO20022.Acmt029001.AccountSwitchCancelExistingPaymentV05 *-- ISO20022.Acmt029001.CashAccount43
    ISO20022.Acmt029001.AccountSwitchCancelExistingPaymentV05 *-- ISO20022.Acmt029001.AccountSwitchDetails1
    ISO20022.Acmt029001.AccountSwitchCancelExistingPaymentV05 *-- ISO20022.Acmt029001.MessageIdentification1
    class ISO20022.Acmt029001.AccountSwitchDetails1 {
        + Rspn  : global::System.Collections.Generic.List~ISO20022.Acmt029001.ResponseDetails1~
        + BalTrfWndw  : String
        + SwtchSts  : String
        + SwtchTp  : String
        + SwtchDt  : DateTime
        + SwtchRcvdDtTm  : DateTime
        + RtgUnqRefNb  : String
        + UnqRefNb  : String
    }
    ISO20022.Acmt029001.AccountSwitchDetails1 *-- ISO20022.Acmt029001.ResponseDetails1
    class ISO20022.Acmt029001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Acmt029001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Acmt029001.AddressType3Choice {
        + Prtry  : ISO20022.Acmt029001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Acmt029001.AddressType3Choice *-- ISO20022.Acmt029001.GenericIdentification30
    class ISO20022.Acmt029001.BalanceTransferWindow1Code {
        EARL = 1
        DAYH = 2
    }
    class ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Acmt029001.BranchData5
        + FinInstnId  : ISO20022.Acmt029001.FinancialInstitutionIdentification23
    }
    ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Acmt029001.BranchData5
    ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Acmt029001.FinancialInstitutionIdentification23
    class ISO20022.Acmt029001.BranchData5 {
        + PstlAdr  : ISO20022.Acmt029001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Acmt029001.BranchData5 *-- ISO20022.Acmt029001.PostalAddress27
    class ISO20022.Acmt029001.BusinessDayConvention1Code {
        PREC = 1
        FWNG = 2
    }
    class ISO20022.Acmt029001.CashAccount40 {
        + Prxy  : ISO20022.Acmt029001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Acmt029001.CashAccountType2Choice
        + Id  : ISO20022.Acmt029001.AccountIdentification4Choice
    }
    ISO20022.Acmt029001.CashAccount40 *-- ISO20022.Acmt029001.ProxyAccountIdentification1
    ISO20022.Acmt029001.CashAccount40 *-- ISO20022.Acmt029001.CashAccountType2Choice
    ISO20022.Acmt029001.CashAccount40 *-- ISO20022.Acmt029001.AccountIdentification4Choice
    class ISO20022.Acmt029001.CashAccount43 {
        + Svcr  : ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8
        + Ownr  : ISO20022.Acmt029001.PartyIdentification272
        + Prxy  : ISO20022.Acmt029001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Acmt029001.CashAccountType2Choice
        + Id  : ISO20022.Acmt029001.AccountIdentification4Choice
    }
    ISO20022.Acmt029001.CashAccount43 *-- ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Acmt029001.CashAccount43 *-- ISO20022.Acmt029001.PartyIdentification272
    ISO20022.Acmt029001.CashAccount43 *-- ISO20022.Acmt029001.ProxyAccountIdentification1
    ISO20022.Acmt029001.CashAccount43 *-- ISO20022.Acmt029001.CashAccountType2Choice
    ISO20022.Acmt029001.CashAccount43 *-- ISO20022.Acmt029001.AccountIdentification4Choice
    class ISO20022.Acmt029001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.CategoryPurpose1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.ChargeBearerType1Code {
        SLEV = 1
        SHAR = 2
        CRED = 3
        DEBT = 4
    }
    class ISO20022.Acmt029001.Cheque19 {
        + Sgntr  : global::System.Collections.Generic.List~String~
        + PrtLctn  : String
        + RgnlClrZone  : String
        + MemoFld  : global::System.Collections.Generic.List~String~
        + FrmsCd  : String
        + ChqMtrtyDt  : DateTime
        + InstrPrty  : String
        + DlvrTo  : ISO20022.Acmt029001.NameAndAddress18
        + DlvryMtd  : ISO20022.Acmt029001.ChequeDeliveryMethod1Choice
        + ChqFr  : ISO20022.Acmt029001.NameAndAddress18
        + ChqNb  : String
        + ChqTp  : String
    }
    ISO20022.Acmt029001.Cheque19 *-- ISO20022.Acmt029001.NameAndAddress18
    ISO20022.Acmt029001.Cheque19 *-- ISO20022.Acmt029001.ChequeDeliveryMethod1Choice
    ISO20022.Acmt029001.Cheque19 *-- ISO20022.Acmt029001.NameAndAddress18
    class ISO20022.Acmt029001.ChequeDelivery1Code {
        RGFA = 1
        RGCD = 2
        RGDB = 3
        PUFA = 4
        PUCD = 5
        PUDB = 6
        CRFA = 7
        CRCD = 8
        CRDB = 9
        MLFA = 10
        MLCD = 11
        MLDB = 12
    }
    class ISO20022.Acmt029001.ChequeDeliveryMethod1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.ChequeType2Code {
        ELDR = 1
        DRFT = 2
        BCHQ = 3
        CCCH = 4
        CCHQ = 5
    }
    class ISO20022.Acmt029001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Acmt029001.ClearingSystemIdentification2Choice
    }
    ISO20022.Acmt029001.ClearingSystemMemberIdentification2 *-- ISO20022.Acmt029001.ClearingSystemIdentification2Choice
    class ISO20022.Acmt029001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt029001.OtherContact1~
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
    ISO20022.Acmt029001.Contact13 *-- ISO20022.Acmt029001.OtherContact1
    class ISO20022.Acmt029001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Acmt029001.CreditTransferTransaction59 {
        + RmtInf  : ISO20022.Acmt029001.RemittanceInformation22
        + RltdRmtInf  : global::System.Collections.Generic.List~ISO20022.Acmt029001.RemittanceLocation9~
        + Tax  : ISO20022.Acmt029001.TaxData1
        + RgltryRptg  : global::System.Collections.Generic.List~ISO20022.Acmt029001.RegulatoryReporting3~
        + Purp  : ISO20022.Acmt029001.Purpose2Choice
        + InstrForCdtrAgt  : global::System.Collections.Generic.List~ISO20022.Acmt029001.InstructionForCreditorAgent3~
        + UltmtCdtr  : ISO20022.Acmt029001.PartyIdentification272
        + CdtrAcct  : ISO20022.Acmt029001.CashAccount40
        + Cdtr  : ISO20022.Acmt029001.PartyIdentification272
        + CdtrAgt  : ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8
        + IntrmyAgt3  : ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8
        + IntrmyAgt2  : ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8
        + IntrmyAgt1  : ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8
        + UltmtDbtr  : ISO20022.Acmt029001.PartyIdentification272
        + TrfInstr  : ISO20022.Acmt029001.TransferInstruction1
        + Frqcy  : ISO20022.Acmt029001.Frequency1
        + ChqInstr  : ISO20022.Acmt029001.Cheque19
        + ChrgBr  : String
        + Amt  : ISO20022.Acmt029001.ActiveCurrencyAndAmount
        + TaxRateMrkr  : String
        + PmtTpInf  : ISO20022.Acmt029001.PaymentTypeInformation26
        + PmtId  : ISO20022.Acmt029001.PaymentIdentification6
    }
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.RemittanceInformation22
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.RemittanceLocation9
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.TaxData1
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.RegulatoryReporting3
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.Purpose2Choice
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.InstructionForCreditorAgent3
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.PartyIdentification272
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.CashAccount40
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.PartyIdentification272
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.PartyIdentification272
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.TransferInstruction1
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.Frequency1
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.Cheque19
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.ActiveCurrencyAndAmount
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.PaymentTypeInformation26
    ISO20022.Acmt029001.CreditTransferTransaction59 *-- ISO20022.Acmt029001.PaymentIdentification6
    class ISO20022.Acmt029001.CreditorReferenceInformation3 {
        + Ref  : String
        + Tp  : ISO20022.Acmt029001.CreditorReferenceType3
    }
    ISO20022.Acmt029001.CreditorReferenceInformation3 *-- ISO20022.Acmt029001.CreditorReferenceType3
    class ISO20022.Acmt029001.CreditorReferenceType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.CreditorReferenceType3 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Acmt029001.CreditorReferenceType2Choice
    }
    ISO20022.Acmt029001.CreditorReferenceType3 *-- ISO20022.Acmt029001.CreditorReferenceType2Choice
    class ISO20022.Acmt029001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Acmt029001.DateAndType1 {
        + Dt  : DateTime
        + Tp  : ISO20022.Acmt029001.DateType2Choice
    }
    ISO20022.Acmt029001.DateAndType1 *-- ISO20022.Acmt029001.DateType2Choice
    class ISO20022.Acmt029001.DatePeriod2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Acmt029001.DateType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.DirectDebitInstructionDetails3 {
        + OthrDtls  : global::System.Collections.Generic.List~ISO20022.Acmt029001.TransferInstruction1~
        + LastColltnDt  : DateTime
        + LastColltnCcyAmt  : ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
        + Cdtr  : ISO20022.Acmt029001.PartyIdentification272
        + DrctDbtTrfblInd  : String
        + AutomtdDrctDbtInstrInd  : String
        + MndtId  : String
    }
    ISO20022.Acmt029001.DirectDebitInstructionDetails3 *-- ISO20022.Acmt029001.TransferInstruction1
    ISO20022.Acmt029001.DirectDebitInstructionDetails3 *-- ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Acmt029001.DirectDebitInstructionDetails3 *-- ISO20022.Acmt029001.PartyIdentification272
    class ISO20022.Acmt029001.DocumentAdjustment1 {
        + AddtlInf  : String
        + Rsn  : String
        + CdtDbtInd  : String
        + Amt  : ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Acmt029001.DocumentAdjustment1 *-- ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Acmt029001.DocumentAmount1 {
        + Amt  : ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
        + Tp  : ISO20022.Acmt029001.DocumentAmountType1Choice
    }
    ISO20022.Acmt029001.DocumentAmount1 *-- ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Acmt029001.DocumentAmount1 *-- ISO20022.Acmt029001.DocumentAmountType1Choice
    class ISO20022.Acmt029001.DocumentAmountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.DocumentLineIdentification1 {
        + RltdDt  : DateTime
        + Nb  : String
        + Tp  : ISO20022.Acmt029001.DocumentLineType1
    }
    ISO20022.Acmt029001.DocumentLineIdentification1 *-- ISO20022.Acmt029001.DocumentLineType1
    class ISO20022.Acmt029001.DocumentLineInformation2 {
        + Amt  : ISO20022.Acmt029001.RemittanceAmount4
        + Desc  : String
        + Id  : global::System.Collections.Generic.List~ISO20022.Acmt029001.DocumentLineIdentification1~
    }
    ISO20022.Acmt029001.DocumentLineInformation2 *-- ISO20022.Acmt029001.RemittanceAmount4
    ISO20022.Acmt029001.DocumentLineInformation2 *-- ISO20022.Acmt029001.DocumentLineIdentification1
    class ISO20022.Acmt029001.DocumentLineType1 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Acmt029001.DocumentLineType1Choice
    }
    ISO20022.Acmt029001.DocumentLineType1 *-- ISO20022.Acmt029001.DocumentLineType1Choice
    class ISO20022.Acmt029001.DocumentLineType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.DocumentType1 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Acmt029001.DocumentType2Choice
    }
    ISO20022.Acmt029001.DocumentType1 *-- ISO20022.Acmt029001.DocumentType2Choice
    class ISO20022.Acmt029001.DocumentType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.EndPoint1Choice {
        + LastPmtDt  : DateTime
        + NbOfPmts  : String
    }
    class ISO20022.Acmt029001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Acmt029001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Acmt029001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Acmt029001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Acmt029001.FinancialInstitutionIdentification23 *-- ISO20022.Acmt029001.GenericFinancialIdentification1
    ISO20022.Acmt029001.FinancialInstitutionIdentification23 *-- ISO20022.Acmt029001.PostalAddress27
    ISO20022.Acmt029001.FinancialInstitutionIdentification23 *-- ISO20022.Acmt029001.ClearingSystemMemberIdentification2
    class ISO20022.Acmt029001.Frequency1 {
        + NonWorkgDayAdjstmnt  : String
        + ReqdFrqcyPttrn  : ISO20022.Acmt029001.Frequency37Choice
        + EndPtChc  : ISO20022.Acmt029001.EndPoint1Choice
        + StartDt  : DateTime
        + Seq  : String
    }
    ISO20022.Acmt029001.Frequency1 *-- ISO20022.Acmt029001.Frequency37Choice
    ISO20022.Acmt029001.Frequency1 *-- ISO20022.Acmt029001.EndPoint1Choice
    class ISO20022.Acmt029001.Frequency10Code {
        QURT = 1
        MIAN = 2
        RATE = 3
        YEAR = 4
        NEVR = 5
    }
    class ISO20022.Acmt029001.Frequency37Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.Garnishment4 {
        + MplyeeTermntnInd  : String
        + FmlyMdclInsrncInd  : String
        + RmtdAmt  : ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
        + Dt  : DateTime
        + RefNb  : String
        + GrnshmtAdmstr  : ISO20022.Acmt029001.PartyIdentification272
        + Grnshee  : ISO20022.Acmt029001.PartyIdentification272
        + Tp  : ISO20022.Acmt029001.GarnishmentType1
    }
    ISO20022.Acmt029001.Garnishment4 *-- ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Acmt029001.Garnishment4 *-- ISO20022.Acmt029001.PartyIdentification272
    ISO20022.Acmt029001.Garnishment4 *-- ISO20022.Acmt029001.PartyIdentification272
    ISO20022.Acmt029001.Garnishment4 *-- ISO20022.Acmt029001.GarnishmentType1
    class ISO20022.Acmt029001.GarnishmentType1 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Acmt029001.GarnishmentType1Choice
    }
    ISO20022.Acmt029001.GarnishmentType1 *-- ISO20022.Acmt029001.GarnishmentType1Choice
    class ISO20022.Acmt029001.GarnishmentType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt029001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt029001.GenericAccountIdentification1 *-- ISO20022.Acmt029001.AccountSchemeName1Choice
    class ISO20022.Acmt029001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt029001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt029001.GenericFinancialIdentification1 *-- ISO20022.Acmt029001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Acmt029001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Acmt029001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt029001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt029001.GenericOrganisationIdentification3 *-- ISO20022.Acmt029001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Acmt029001.GenericPersonIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Acmt029001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Acmt029001.GenericPersonIdentification2 *-- ISO20022.Acmt029001.PersonIdentificationSchemeName1Choice
    class ISO20022.Acmt029001.InstructionForCreditorAgent3 {
        + InstrInf  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.LocalInstrument2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.MessageIdentification1 {
        + CreDtTm  : DateTime
        + Id  : String
    }
    class ISO20022.Acmt029001.NameAndAddress18 {
        + Adr  : ISO20022.Acmt029001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Acmt029001.NameAndAddress18 *-- ISO20022.Acmt029001.PostalAddress27
    class ISO20022.Acmt029001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Acmt029001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt029001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Acmt029001.OrganisationIdentification39 *-- ISO20022.Acmt029001.GenericOrganisationIdentification3
    class ISO20022.Acmt029001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Acmt029001.Party52Choice {
        + PrvtId  : ISO20022.Acmt029001.PersonIdentification18
        + OrgId  : ISO20022.Acmt029001.OrganisationIdentification39
    }
    ISO20022.Acmt029001.Party52Choice *-- ISO20022.Acmt029001.PersonIdentification18
    ISO20022.Acmt029001.Party52Choice *-- ISO20022.Acmt029001.OrganisationIdentification39
    class ISO20022.Acmt029001.PartyIdentification272 {
        + CtctDtls  : ISO20022.Acmt029001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Acmt029001.Party52Choice
        + PstlAdr  : ISO20022.Acmt029001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Acmt029001.PartyIdentification272 *-- ISO20022.Acmt029001.Contact13
    ISO20022.Acmt029001.PartyIdentification272 *-- ISO20022.Acmt029001.Party52Choice
    ISO20022.Acmt029001.PartyIdentification272 *-- ISO20022.Acmt029001.PostalAddress27
    class ISO20022.Acmt029001.PaymentIdentification6 {
        + UETR  : String
        + EndToEndId  : String
        + InstrId  : String
    }
    class ISO20022.Acmt029001.PaymentInstruction43 {
        + CdtTrfTxInf  : global::System.Collections.Generic.List~ISO20022.Acmt029001.CreditTransferTransaction59~
        + ChrgsAcctAgt  : ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8
        + ChrgsAcct  : ISO20022.Acmt029001.CashAccount40
        + ChrgBr  : String
        + UltmtDbtr  : ISO20022.Acmt029001.PartyIdentification272
        + InstrForDbtrAgt  : String
        + DbtrAgtAcct  : ISO20022.Acmt029001.CashAccount40
        + DbtrAgt  : ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8
        + DbtrAcct  : ISO20022.Acmt029001.CashAccount40
        + Dbtr  : ISO20022.Acmt029001.PartyIdentification272
        + PoolgAdjstmntDt  : DateTime
        + ReqdExctnDt  : DateTime
        + PmtTpInf  : ISO20022.Acmt029001.PaymentTypeInformation26
        + CtrlSum  : Decimal
        + NbOfTxs  : String
        + BtchBookg  : String
        + PmtMtd  : String
        + PmtInfId  : String
    }
    ISO20022.Acmt029001.PaymentInstruction43 *-- ISO20022.Acmt029001.CreditTransferTransaction59
    ISO20022.Acmt029001.PaymentInstruction43 *-- ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Acmt029001.PaymentInstruction43 *-- ISO20022.Acmt029001.CashAccount40
    ISO20022.Acmt029001.PaymentInstruction43 *-- ISO20022.Acmt029001.PartyIdentification272
    ISO20022.Acmt029001.PaymentInstruction43 *-- ISO20022.Acmt029001.CashAccount40
    ISO20022.Acmt029001.PaymentInstruction43 *-- ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Acmt029001.PaymentInstruction43 *-- ISO20022.Acmt029001.CashAccount40
    ISO20022.Acmt029001.PaymentInstruction43 *-- ISO20022.Acmt029001.PartyIdentification272
    ISO20022.Acmt029001.PaymentInstruction43 *-- ISO20022.Acmt029001.PaymentTypeInformation26
    class ISO20022.Acmt029001.PaymentMethod3Code {
        TRA = 1
        TRF = 2
        CHK = 3
    }
    class ISO20022.Acmt029001.PaymentTypeInformation26 {
        + CtgyPurp  : ISO20022.Acmt029001.CategoryPurpose1Choice
        + LclInstrm  : ISO20022.Acmt029001.LocalInstrument2Choice
        + SvcLvl  : global::System.Collections.Generic.List~ISO20022.Acmt029001.ServiceLevel8Choice~
        + InstrPrty  : String
    }
    ISO20022.Acmt029001.PaymentTypeInformation26 *-- ISO20022.Acmt029001.CategoryPurpose1Choice
    ISO20022.Acmt029001.PaymentTypeInformation26 *-- ISO20022.Acmt029001.LocalInstrument2Choice
    ISO20022.Acmt029001.PaymentTypeInformation26 *-- ISO20022.Acmt029001.ServiceLevel8Choice
    class ISO20022.Acmt029001.PersonIdentification18 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Acmt029001.GenericPersonIdentification2~
        + DtAndPlcOfBirth  : ISO20022.Acmt029001.DateAndPlaceOfBirth1
    }
    ISO20022.Acmt029001.PersonIdentification18 *-- ISO20022.Acmt029001.GenericPersonIdentification2
    ISO20022.Acmt029001.PersonIdentification18 *-- ISO20022.Acmt029001.DateAndPlaceOfBirth1
    class ISO20022.Acmt029001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Acmt029001.AddressType3Choice
    }
    ISO20022.Acmt029001.PostalAddress27 *-- ISO20022.Acmt029001.AddressType3Choice
    class ISO20022.Acmt029001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Acmt029001.Priority2Code {
        NORM = 1
        HIGH = 2
    }
    class ISO20022.Acmt029001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Acmt029001.ProxyAccountType1Choice
    }
    ISO20022.Acmt029001.ProxyAccountIdentification1 *-- ISO20022.Acmt029001.ProxyAccountType1Choice
    class ISO20022.Acmt029001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.Purpose2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.ReferredDocumentInformation8 {
        + LineDtls  : global::System.Collections.Generic.List~ISO20022.Acmt029001.DocumentLineInformation2~
        + RltdDt  : ISO20022.Acmt029001.DateAndType1
        + Nb  : String
        + Tp  : ISO20022.Acmt029001.DocumentType1
    }
    ISO20022.Acmt029001.ReferredDocumentInformation8 *-- ISO20022.Acmt029001.DocumentLineInformation2
    ISO20022.Acmt029001.ReferredDocumentInformation8 *-- ISO20022.Acmt029001.DateAndType1
    ISO20022.Acmt029001.ReferredDocumentInformation8 *-- ISO20022.Acmt029001.DocumentType1
    class ISO20022.Acmt029001.RegulatoryAuthority2 {
        + Ctry  : String
        + Nm  : String
    }
    class ISO20022.Acmt029001.RegulatoryReporting3 {
        + Dtls  : global::System.Collections.Generic.List~ISO20022.Acmt029001.StructuredRegulatoryReporting3~
        + Authrty  : ISO20022.Acmt029001.RegulatoryAuthority2
        + DbtCdtRptgInd  : String
    }
    ISO20022.Acmt029001.RegulatoryReporting3 *-- ISO20022.Acmt029001.StructuredRegulatoryReporting3
    ISO20022.Acmt029001.RegulatoryReporting3 *-- ISO20022.Acmt029001.RegulatoryAuthority2
    class ISO20022.Acmt029001.RegulatoryReportingType1Code {
        BOTH = 1
        DEBT = 2
        CRED = 3
    }
    class ISO20022.Acmt029001.RemittanceAmount4 {
        + AdjstmntAmtAndRsn  : global::System.Collections.Generic.List~ISO20022.Acmt029001.DocumentAdjustment1~
        + RmtAmtAndTp  : global::System.Collections.Generic.List~ISO20022.Acmt029001.DocumentAmount1~
    }
    ISO20022.Acmt029001.RemittanceAmount4 *-- ISO20022.Acmt029001.DocumentAdjustment1
    ISO20022.Acmt029001.RemittanceAmount4 *-- ISO20022.Acmt029001.DocumentAmount1
    class ISO20022.Acmt029001.RemittanceInformation22 {
        + Strd  : global::System.Collections.Generic.List~ISO20022.Acmt029001.StructuredRemittanceInformation18~
        + Ustrd  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Acmt029001.RemittanceInformation22 *-- ISO20022.Acmt029001.StructuredRemittanceInformation18
    class ISO20022.Acmt029001.RemittanceLocation9 {
        + RmtLctnPstlAdr  : ISO20022.Acmt029001.NameAndAddress18
        + RmtLctnElctrncAdr  : String
        + RmtLctnMtd  : String
        + RmtId  : String
    }
    ISO20022.Acmt029001.RemittanceLocation9 *-- ISO20022.Acmt029001.NameAndAddress18
    class ISO20022.Acmt029001.RemittanceLocationMethod2Code {
        SMSM = 1
        POST = 2
        EMAL = 3
        URID = 4
        EDIC = 5
        FAXI = 6
    }
    class ISO20022.Acmt029001.ResponseDetails1 {
        + AddtlDtls  : String
        + RspnCd  : String
    }
    class ISO20022.Acmt029001.ServiceLevel8Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Acmt029001.StructuredRegulatoryReporting3 {
        + Inf  : global::System.Collections.Generic.List~String~
        + Amt  : ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
        + Cd  : String
        + Ctry  : String
        + Dt  : DateTime
        + Tp  : String
    }
    ISO20022.Acmt029001.StructuredRegulatoryReporting3 *-- ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Acmt029001.StructuredRemittanceInformation18 {
        + AddtlRmtInf  : global::System.Collections.Generic.List~String~
        + GrnshmtRmt  : ISO20022.Acmt029001.Garnishment4
        + TaxRmt  : ISO20022.Acmt029001.TaxData1
        + Invcee  : ISO20022.Acmt029001.PartyIdentification272
        + Invcr  : ISO20022.Acmt029001.PartyIdentification272
        + CdtrRefInf  : ISO20022.Acmt029001.CreditorReferenceInformation3
        + RfrdDocAmt  : ISO20022.Acmt029001.RemittanceAmount4
        + RfrdDocInf  : global::System.Collections.Generic.List~ISO20022.Acmt029001.ReferredDocumentInformation8~
    }
    ISO20022.Acmt029001.StructuredRemittanceInformation18 *-- ISO20022.Acmt029001.Garnishment4
    ISO20022.Acmt029001.StructuredRemittanceInformation18 *-- ISO20022.Acmt029001.TaxData1
    ISO20022.Acmt029001.StructuredRemittanceInformation18 *-- ISO20022.Acmt029001.PartyIdentification272
    ISO20022.Acmt029001.StructuredRemittanceInformation18 *-- ISO20022.Acmt029001.PartyIdentification272
    ISO20022.Acmt029001.StructuredRemittanceInformation18 *-- ISO20022.Acmt029001.CreditorReferenceInformation3
    ISO20022.Acmt029001.StructuredRemittanceInformation18 *-- ISO20022.Acmt029001.RemittanceAmount4
    ISO20022.Acmt029001.StructuredRemittanceInformation18 *-- ISO20022.Acmt029001.ReferredDocumentInformation8
    class ISO20022.Acmt029001.SupplementaryData1 {
        + Envlp  : ISO20022.Acmt029001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Acmt029001.SupplementaryData1 *-- ISO20022.Acmt029001.SupplementaryDataEnvelope1
    class ISO20022.Acmt029001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Acmt029001.SwitchStatus1Code {
        TMTN = 1
        REQU = 2
        REJT = 3
        REDE = 4
        REDT = 5
        COMP = 6
        BTRS = 7
        BTRQ = 8
        ACPT = 9
    }
    class ISO20022.Acmt029001.SwitchType1Code {
        PART = 1
        FULL = 2
    }
    class ISO20022.Acmt029001.TaxAmount3 {
        + Dtls  : global::System.Collections.Generic.List~ISO20022.Acmt029001.TaxRecordDetails3~
        + TtlAmt  : ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
        + TaxblBaseAmt  : ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
        + Rate  : Decimal
    }
    ISO20022.Acmt029001.TaxAmount3 *-- ISO20022.Acmt029001.TaxRecordDetails3
    ISO20022.Acmt029001.TaxAmount3 *-- ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Acmt029001.TaxAmount3 *-- ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Acmt029001.TaxAuthorisation1 {
        + Nm  : String
        + Titl  : String
    }
    class ISO20022.Acmt029001.TaxData1 {
        + Rcrd  : global::System.Collections.Generic.List~ISO20022.Acmt029001.TaxRecord3~
        + SeqNb  : Decimal
        + Dt  : DateTime
        + TtlTaxAmt  : ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
        + TtlTaxblBaseAmt  : ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
        + Mtd  : String
        + RefNb  : String
        + AdmstnZone  : String
        + UltmtDbtr  : ISO20022.Acmt029001.TaxParty2
        + Dbtr  : ISO20022.Acmt029001.TaxParty2
        + Cdtr  : ISO20022.Acmt029001.TaxParty1
    }
    ISO20022.Acmt029001.TaxData1 *-- ISO20022.Acmt029001.TaxRecord3
    ISO20022.Acmt029001.TaxData1 *-- ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Acmt029001.TaxData1 *-- ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Acmt029001.TaxData1 *-- ISO20022.Acmt029001.TaxParty2
    ISO20022.Acmt029001.TaxData1 *-- ISO20022.Acmt029001.TaxParty2
    ISO20022.Acmt029001.TaxData1 *-- ISO20022.Acmt029001.TaxParty1
    class ISO20022.Acmt029001.TaxParty1 {
        + TaxTp  : String
        + RegnId  : String
        + TaxId  : String
    }
    class ISO20022.Acmt029001.TaxParty2 {
        + Authstn  : ISO20022.Acmt029001.TaxAuthorisation1
        + TaxTp  : String
        + RegnId  : String
        + TaxId  : String
    }
    ISO20022.Acmt029001.TaxParty2 *-- ISO20022.Acmt029001.TaxAuthorisation1
    class ISO20022.Acmt029001.TaxPeriod3 {
        + FrToDt  : ISO20022.Acmt029001.DatePeriod2
        + Tp  : String
        + Yr  : Int32
    }
    ISO20022.Acmt029001.TaxPeriod3 *-- ISO20022.Acmt029001.DatePeriod2
    class ISO20022.Acmt029001.TaxRateMarker1Code {
        GRSS = 1
        ALIT = 2
        ALPR = 3
    }
    class ISO20022.Acmt029001.TaxRecord3 {
        + AddtlInf  : String
        + TaxAmt  : ISO20022.Acmt029001.TaxAmount3
        + Prd  : ISO20022.Acmt029001.TaxPeriod3
        + FrmsCd  : String
        + CertId  : String
        + DbtrSts  : String
        + CtgyDtls  : String
        + Ctgy  : String
        + Tp  : String
    }
    ISO20022.Acmt029001.TaxRecord3 *-- ISO20022.Acmt029001.TaxAmount3
    ISO20022.Acmt029001.TaxRecord3 *-- ISO20022.Acmt029001.TaxPeriod3
    class ISO20022.Acmt029001.TaxRecordDetails3 {
        + Amt  : ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
        + Prd  : ISO20022.Acmt029001.TaxPeriod3
    }
    ISO20022.Acmt029001.TaxRecordDetails3 *-- ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Acmt029001.TaxRecordDetails3 *-- ISO20022.Acmt029001.TaxPeriod3
    class ISO20022.Acmt029001.TaxRecordPeriod1Code {
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
    class ISO20022.Acmt029001.TransferInstruction1 {
        + Desc  : String
        + StartDt  : DateTime
        + StartDtTm  : DateTime
        + Prtry  : String
        + Cd  : String
        + TrfInd  : String
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

## Value ISO20022.Acmt029001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Acmt029001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Acmt029001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Aspect ISO20022.Acmt029001.AccountSwitchCancelExistingPaymentV05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Acmt029001.SupplementaryData1>||XmlElement()||
|+|DrctDbtInstr|global::System.Collections.Generic.List<ISO20022.Acmt029001.DirectDebitInstructionDetails3>||XmlElement()||
|+|PmtInstr|global::System.Collections.Generic.List<ISO20022.Acmt029001.PaymentInstruction43>||XmlElement()||
|+|OdAcct|ISO20022.Acmt029001.CashAccount43||XmlElement()||
|+|AcctSwtchDtls|ISO20022.Acmt029001.AccountSwitchDetails1||XmlElement()||
|+|MsgId|ISO20022.Acmt029001.MessageIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""DrctDbtInstr""",DrctDbtInstr),validElement(DrctDbtInstr),validList("""PmtInstr""",PmtInstr),validElement(PmtInstr),validElement(OdAcct),validElement(AcctSwtchDtls),validElement(MsgId))|

---

## Value ISO20022.Acmt029001.AccountSwitchDetails1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rspn|global::System.Collections.Generic.List<ISO20022.Acmt029001.ResponseDetails1>||XmlElement()||
|+|BalTrfWndw|String||XmlElement()||
|+|SwtchSts|String||XmlElement()||
|+|SwtchTp|String||XmlElement()||
|+|SwtchDt|DateTime||XmlElement()||
|+|SwtchRcvdDtTm|DateTime||XmlElement()||
|+|RtgUnqRefNb|String||XmlElement()||
|+|UnqRefNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rspn""",Rspn),validElement(Rspn))|

---

## Value ISO20022.Acmt029001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Acmt029001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Acmt029001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Acmt029001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt029001.BalanceTransferWindow1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EARL|Int32||XmlEnum("""EARL""")|1|
||DAYH|Int32||XmlEnum("""DAYH""")|2|

---

## Value ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Acmt029001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Acmt029001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Acmt029001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Acmt029001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Enum ISO20022.Acmt029001.BusinessDayConvention1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREC|Int32||XmlEnum("""PREC""")|1|
||FWNG|Int32||XmlEnum("""FWNG""")|2|

---

## Value ISO20022.Acmt029001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Acmt029001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Acmt029001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Acmt029001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Acmt029001.CashAccount43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Svcr|ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Ownr|ISO20022.Acmt029001.PartyIdentification272||XmlElement()||
|+|Prxy|ISO20022.Acmt029001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Acmt029001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Acmt029001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Svcr),validElement(Ownr),validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Acmt029001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.CategoryPurpose1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt029001.ChargeBearerType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLEV|Int32||XmlEnum("""SLEV""")|1|
||SHAR|Int32||XmlEnum("""SHAR""")|2|
||CRED|Int32||XmlEnum("""CRED""")|3|
||DEBT|Int32||XmlEnum("""DEBT""")|4|

---

## Value ISO20022.Acmt029001.Cheque19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgntr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PrtLctn|String||XmlElement()||
|+|RgnlClrZone|String||XmlElement()||
|+|MemoFld|global::System.Collections.Generic.List<String>||XmlElement()||
|+|FrmsCd|String||XmlElement()||
|+|ChqMtrtyDt|DateTime||XmlElement()||
|+|InstrPrty|String||XmlElement()||
|+|DlvrTo|ISO20022.Acmt029001.NameAndAddress18||XmlElement()||
|+|DlvryMtd|ISO20022.Acmt029001.ChequeDeliveryMethod1Choice||XmlElement()||
|+|ChqFr|ISO20022.Acmt029001.NameAndAddress18||XmlElement()||
|+|ChqNb|String||XmlElement()||
|+|ChqTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""Sgntr""",Sgntr,5),validListMax("""MemoFld""",MemoFld,2),validElement(DlvrTo),validElement(DlvryMtd),validElement(ChqFr))|

---

## Enum ISO20022.Acmt029001.ChequeDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RGFA|Int32||XmlEnum("""RGFA""")|1|
||RGCD|Int32||XmlEnum("""RGCD""")|2|
||RGDB|Int32||XmlEnum("""RGDB""")|3|
||PUFA|Int32||XmlEnum("""PUFA""")|4|
||PUCD|Int32||XmlEnum("""PUCD""")|5|
||PUDB|Int32||XmlEnum("""PUDB""")|6|
||CRFA|Int32||XmlEnum("""CRFA""")|7|
||CRCD|Int32||XmlEnum("""CRCD""")|8|
||CRDB|Int32||XmlEnum("""CRDB""")|9|
||MLFA|Int32||XmlEnum("""MLFA""")|10|
||MLCD|Int32||XmlEnum("""MLCD""")|11|
||MLDB|Int32||XmlEnum("""MLDB""")|12|

---

## Value ISO20022.Acmt029001.ChequeDeliveryMethod1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Acmt029001.ChequeType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ELDR|Int32||XmlEnum("""ELDR""")|1|
||DRFT|Int32||XmlEnum("""DRFT""")|2|
||BCHQ|Int32||XmlEnum("""BCHQ""")|3|
||CCCH|Int32||XmlEnum("""CCCH""")|4|
||CCHQ|Int32||XmlEnum("""CCHQ""")|5|

---

## Value ISO20022.Acmt029001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Acmt029001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Acmt029001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt029001.OtherContact1>||XmlElement()||
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

## Enum ISO20022.Acmt029001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Acmt029001.CreditTransferTransaction59


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RmtInf|ISO20022.Acmt029001.RemittanceInformation22||XmlElement()||
|+|RltdRmtInf|global::System.Collections.Generic.List<ISO20022.Acmt029001.RemittanceLocation9>||XmlElement()||
|+|Tax|ISO20022.Acmt029001.TaxData1||XmlElement()||
|+|RgltryRptg|global::System.Collections.Generic.List<ISO20022.Acmt029001.RegulatoryReporting3>||XmlElement()||
|+|Purp|ISO20022.Acmt029001.Purpose2Choice||XmlElement()||
|+|InstrForCdtrAgt|global::System.Collections.Generic.List<ISO20022.Acmt029001.InstructionForCreditorAgent3>||XmlElement()||
|+|UltmtCdtr|ISO20022.Acmt029001.PartyIdentification272||XmlElement()||
|+|CdtrAcct|ISO20022.Acmt029001.CashAccount40||XmlElement()||
|+|Cdtr|ISO20022.Acmt029001.PartyIdentification272||XmlElement()||
|+|CdtrAgt|ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrmyAgt3|ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrmyAgt2|ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrmyAgt1|ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|UltmtDbtr|ISO20022.Acmt029001.PartyIdentification272||XmlElement()||
|+|TrfInstr|ISO20022.Acmt029001.TransferInstruction1||XmlElement()||
|+|Frqcy|ISO20022.Acmt029001.Frequency1||XmlElement()||
|+|ChqInstr|ISO20022.Acmt029001.Cheque19||XmlElement()||
|+|ChrgBr|String||XmlElement()||
|+|Amt|ISO20022.Acmt029001.ActiveCurrencyAndAmount||XmlElement()||
|+|TaxRateMrkr|String||XmlElement()||
|+|PmtTpInf|ISO20022.Acmt029001.PaymentTypeInformation26||XmlElement()||
|+|PmtId|ISO20022.Acmt029001.PaymentIdentification6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RmtInf),validList("""RltdRmtInf""",RltdRmtInf),validListMax("""RltdRmtInf""",RltdRmtInf,10),validElement(RltdRmtInf),validElement(Tax),validList("""RgltryRptg""",RgltryRptg),validListMax("""RgltryRptg""",RgltryRptg,10),validElement(RgltryRptg),validElement(Purp),validList("""InstrForCdtrAgt""",InstrForCdtrAgt),validElement(InstrForCdtrAgt),validElement(UltmtCdtr),validElement(CdtrAcct),validElement(Cdtr),validElement(CdtrAgt),validElement(IntrmyAgt3),validElement(IntrmyAgt2),validElement(IntrmyAgt1),validElement(UltmtDbtr),validElement(TrfInstr),validElement(Frqcy),validElement(ChqInstr),validElement(Amt),validElement(PmtTpInf),validElement(PmtId))|

---

## Value ISO20022.Acmt029001.CreditorReferenceInformation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|String||XmlElement()||
|+|Tp|ISO20022.Acmt029001.CreditorReferenceType3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Acmt029001.CreditorReferenceType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.CreditorReferenceType3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Acmt029001.CreditorReferenceType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Acmt029001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Acmt029001.DateAndType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dt|DateTime||XmlElement()||
|+|Tp|ISO20022.Acmt029001.DateType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Acmt029001.DatePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt029001.DateType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.DirectDebitInstructionDetails3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrDtls|global::System.Collections.Generic.List<ISO20022.Acmt029001.TransferInstruction1>||XmlElement()||
|+|LastColltnDt|DateTime||XmlElement()||
|+|LastColltnCcyAmt|ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Cdtr|ISO20022.Acmt029001.PartyIdentification272||XmlElement()||
|+|DrctDbtTrfblInd|String||XmlElement()||
|+|AutomtdDrctDbtInstrInd|String||XmlElement()||
|+|MndtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrDtls""",OthrDtls),validElement(OthrDtls),validElement(LastColltnCcyAmt),validElement(Cdtr))|

---

## Type ISO20022.Acmt029001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSwtchCclExstgPmt|ISO20022.Acmt029001.AccountSwitchCancelExistingPaymentV05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSwtchCclExstgPmt))|

---

## Value ISO20022.Acmt029001.DocumentAdjustment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Acmt029001.DocumentAmount1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Acmt029001.DocumentAmountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Tp))|

---

## Value ISO20022.Acmt029001.DocumentAmountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.DocumentLineIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltdDt|DateTime||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|ISO20022.Acmt029001.DocumentLineType1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Acmt029001.DocumentLineInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Acmt029001.RemittanceAmount4||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Id|global::System.Collections.Generic.List<ISO20022.Acmt029001.DocumentLineIdentification1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validRequired("""Id""",Id),validList("""Id""",Id),validElement(Id))|

---

## Value ISO20022.Acmt029001.DocumentLineType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Acmt029001.DocumentLineType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Acmt029001.DocumentLineType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.DocumentType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Acmt029001.DocumentType2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Acmt029001.DocumentType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.EndPoint1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPmtDt|DateTime||XmlElement()||
|+|NbOfPmts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(LastPmtDt,NbOfPmts))|

---

## Value ISO20022.Acmt029001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Acmt029001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Acmt029001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Acmt029001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Acmt029001.Frequency1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NonWorkgDayAdjstmnt|String||XmlElement()||
|+|ReqdFrqcyPttrn|ISO20022.Acmt029001.Frequency37Choice||XmlElement()||
|+|EndPtChc|ISO20022.Acmt029001.EndPoint1Choice||XmlElement()||
|+|StartDt|DateTime||XmlElement()||
|+|Seq|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqdFrqcyPttrn),validElement(EndPtChc),validPattern("""Seq""",Seq,"""[0-9]{1,3}"""))|

---

## Enum ISO20022.Acmt029001.Frequency10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||QURT|Int32||XmlEnum("""QURT""")|1|
||MIAN|Int32||XmlEnum("""MIAN""")|2|
||RATE|Int32||XmlEnum("""RATE""")|3|
||YEAR|Int32||XmlEnum("""YEAR""")|4|
||NEVR|Int32||XmlEnum("""NEVR""")|5|

---

## Value ISO20022.Acmt029001.Frequency37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.Garnishment4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MplyeeTermntnInd|String||XmlElement()||
|+|FmlyMdclInsrncInd|String||XmlElement()||
|+|RmtdAmt|ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|GrnshmtAdmstr|ISO20022.Acmt029001.PartyIdentification272||XmlElement()||
|+|Grnshee|ISO20022.Acmt029001.PartyIdentification272||XmlElement()||
|+|Tp|ISO20022.Acmt029001.GarnishmentType1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RmtdAmt),validElement(GrnshmtAdmstr),validElement(Grnshee),validElement(Tp))|

---

## Value ISO20022.Acmt029001.GarnishmentType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Acmt029001.GarnishmentType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Acmt029001.GarnishmentType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt029001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt029001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt029001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt029001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Acmt029001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt029001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt029001.GenericPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Acmt029001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Acmt029001.InstructionForCreditorAgent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrInf|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt029001.LocalInstrument2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.MessageIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt029001.NameAndAddress18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Acmt029001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Acmt029001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Acmt029001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt029001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Acmt029001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt029001.Party52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Acmt029001.PersonIdentification18||XmlElement()||
|+|OrgId|ISO20022.Acmt029001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Acmt029001.PartyIdentification272


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Acmt029001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Acmt029001.Party52Choice||XmlElement()||
|+|PstlAdr|ISO20022.Acmt029001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Acmt029001.PaymentIdentification6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UETR|String||XmlElement()||
|+|EndToEndId|String||XmlElement()||
|+|InstrId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""UETR""",UETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""))|

---

## Value ISO20022.Acmt029001.PaymentInstruction43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtTrfTxInf|global::System.Collections.Generic.List<ISO20022.Acmt029001.CreditTransferTransaction59>||XmlElement()||
|+|ChrgsAcctAgt|ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|ChrgsAcct|ISO20022.Acmt029001.CashAccount40||XmlElement()||
|+|ChrgBr|String||XmlElement()||
|+|UltmtDbtr|ISO20022.Acmt029001.PartyIdentification272||XmlElement()||
|+|InstrForDbtrAgt|String||XmlElement()||
|+|DbtrAgtAcct|ISO20022.Acmt029001.CashAccount40||XmlElement()||
|+|DbtrAgt|ISO20022.Acmt029001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|DbtrAcct|ISO20022.Acmt029001.CashAccount40||XmlElement()||
|+|Dbtr|ISO20022.Acmt029001.PartyIdentification272||XmlElement()||
|+|PoolgAdjstmntDt|DateTime||XmlElement()||
|+|ReqdExctnDt|DateTime||XmlElement()||
|+|PmtTpInf|ISO20022.Acmt029001.PaymentTypeInformation26||XmlElement()||
|+|CtrlSum|Decimal||XmlElement()||
|+|NbOfTxs|String||XmlElement()||
|+|BtchBookg|String||XmlElement()||
|+|PmtMtd|String||XmlElement()||
|+|PmtInfId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""CdtTrfTxInf""",CdtTrfTxInf),validList("""CdtTrfTxInf""",CdtTrfTxInf),validElement(CdtTrfTxInf),validElement(ChrgsAcctAgt),validElement(ChrgsAcct),validElement(UltmtDbtr),validElement(DbtrAgtAcct),validElement(DbtrAgt),validElement(DbtrAcct),validElement(Dbtr),validElement(PmtTpInf),validPattern("""NbOfTxs""",NbOfTxs,"""[0-9]{1,15}"""))|

---

## Enum ISO20022.Acmt029001.PaymentMethod3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRA|Int32||XmlEnum("""TRA""")|1|
||TRF|Int32||XmlEnum("""TRF""")|2|
||CHK|Int32||XmlEnum("""CHK""")|3|

---

## Value ISO20022.Acmt029001.PaymentTypeInformation26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtgyPurp|ISO20022.Acmt029001.CategoryPurpose1Choice||XmlElement()||
|+|LclInstrm|ISO20022.Acmt029001.LocalInstrument2Choice||XmlElement()||
|+|SvcLvl|global::System.Collections.Generic.List<ISO20022.Acmt029001.ServiceLevel8Choice>||XmlElement()||
|+|InstrPrty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtgyPurp),validElement(LclInstrm),validList("""SvcLvl""",SvcLvl),validElement(SvcLvl))|

---

## Value ISO20022.Acmt029001.PersonIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Acmt029001.GenericPersonIdentification2>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Acmt029001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Acmt029001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.PostalAddress27


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
|+|AdrTp|ISO20022.Acmt029001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Acmt029001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Enum ISO20022.Acmt029001.Priority2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORM|Int32||XmlEnum("""NORM""")|1|
||HIGH|Int32||XmlEnum("""HIGH""")|2|

---

## Value ISO20022.Acmt029001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Acmt029001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Acmt029001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.Purpose2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.ReferredDocumentInformation8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LineDtls|global::System.Collections.Generic.List<ISO20022.Acmt029001.DocumentLineInformation2>||XmlElement()||
|+|RltdDt|ISO20022.Acmt029001.DateAndType1||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|ISO20022.Acmt029001.DocumentType1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LineDtls""",LineDtls),validElement(LineDtls),validElement(RltdDt),validElement(Tp))|

---

## Value ISO20022.Acmt029001.RegulatoryAuthority2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Acmt029001.RegulatoryReporting3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|global::System.Collections.Generic.List<ISO20022.Acmt029001.StructuredRegulatoryReporting3>||XmlElement()||
|+|Authrty|ISO20022.Acmt029001.RegulatoryAuthority2||XmlElement()||
|+|DbtCdtRptgInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dtls""",Dtls),validElement(Dtls),validElement(Authrty))|

---

## Enum ISO20022.Acmt029001.RegulatoryReportingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOTH|Int32||XmlEnum("""BOTH""")|1|
||DEBT|Int32||XmlEnum("""DEBT""")|2|
||CRED|Int32||XmlEnum("""CRED""")|3|

---

## Value ISO20022.Acmt029001.RemittanceAmount4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AdjstmntAmtAndRsn|global::System.Collections.Generic.List<ISO20022.Acmt029001.DocumentAdjustment1>||XmlElement()||
|+|RmtAmtAndTp|global::System.Collections.Generic.List<ISO20022.Acmt029001.DocumentAmount1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AdjstmntAmtAndRsn""",AdjstmntAmtAndRsn),validElement(AdjstmntAmtAndRsn),validList("""RmtAmtAndTp""",RmtAmtAndTp),validElement(RmtAmtAndTp))|

---

## Value ISO20022.Acmt029001.RemittanceInformation22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Strd|global::System.Collections.Generic.List<ISO20022.Acmt029001.StructuredRemittanceInformation18>||XmlElement()||
|+|Ustrd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Strd""",Strd),validElement(Strd))|

---

## Value ISO20022.Acmt029001.RemittanceLocation9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RmtLctnPstlAdr|ISO20022.Acmt029001.NameAndAddress18||XmlElement()||
|+|RmtLctnElctrncAdr|String||XmlElement()||
|+|RmtLctnMtd|String||XmlElement()||
|+|RmtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RmtLctnPstlAdr))|

---

## Enum ISO20022.Acmt029001.RemittanceLocationMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SMSM|Int32||XmlEnum("""SMSM""")|1|
||POST|Int32||XmlEnum("""POST""")|2|
||EMAL|Int32||XmlEnum("""EMAL""")|3|
||URID|Int32||XmlEnum("""URID""")|4|
||EDIC|Int32||XmlEnum("""EDIC""")|5|
||FAXI|Int32||XmlEnum("""FAXI""")|6|

---

## Value ISO20022.Acmt029001.ResponseDetails1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlDtls|String||XmlElement()||
|+|RspnCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt029001.ServiceLevel8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Acmt029001.StructuredRegulatoryReporting3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Inf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Amt|ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Cd|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Acmt029001.StructuredRemittanceInformation18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRmtInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|GrnshmtRmt|ISO20022.Acmt029001.Garnishment4||XmlElement()||
|+|TaxRmt|ISO20022.Acmt029001.TaxData1||XmlElement()||
|+|Invcee|ISO20022.Acmt029001.PartyIdentification272||XmlElement()||
|+|Invcr|ISO20022.Acmt029001.PartyIdentification272||XmlElement()||
|+|CdtrRefInf|ISO20022.Acmt029001.CreditorReferenceInformation3||XmlElement()||
|+|RfrdDocAmt|ISO20022.Acmt029001.RemittanceAmount4||XmlElement()||
|+|RfrdDocInf|global::System.Collections.Generic.List<ISO20022.Acmt029001.ReferredDocumentInformation8>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlRmtInf""",AddtlRmtInf,3),validElement(GrnshmtRmt),validElement(TaxRmt),validElement(Invcee),validElement(Invcr),validElement(CdtrRefInf),validElement(RfrdDocAmt),validList("""RfrdDocInf""",RfrdDocInf),validElement(RfrdDocInf))|

---

## Value ISO20022.Acmt029001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Acmt029001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Acmt029001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Acmt029001.SwitchStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TMTN|Int32||XmlEnum("""TMTN""")|1|
||REQU|Int32||XmlEnum("""REQU""")|2|
||REJT|Int32||XmlEnum("""REJT""")|3|
||REDE|Int32||XmlEnum("""REDE""")|4|
||REDT|Int32||XmlEnum("""REDT""")|5|
||COMP|Int32||XmlEnum("""COMP""")|6|
||BTRS|Int32||XmlEnum("""BTRS""")|7|
||BTRQ|Int32||XmlEnum("""BTRQ""")|8|
||ACPT|Int32||XmlEnum("""ACPT""")|9|

---

## Enum ISO20022.Acmt029001.SwitchType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||FULL|Int32||XmlEnum("""FULL""")|2|

---

## Value ISO20022.Acmt029001.TaxAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|global::System.Collections.Generic.List<ISO20022.Acmt029001.TaxRecordDetails3>||XmlElement()||
|+|TtlAmt|ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TaxblBaseAmt|ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dtls""",Dtls),validElement(Dtls),validElement(TtlAmt),validElement(TaxblBaseAmt))|

---

## Value ISO20022.Acmt029001.TaxAuthorisation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Titl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt029001.TaxData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rcrd|global::System.Collections.Generic.List<ISO20022.Acmt029001.TaxRecord3>||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|TtlTaxAmt|ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlTaxblBaseAmt|ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Mtd|String||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|AdmstnZone|String||XmlElement()||
|+|UltmtDbtr|ISO20022.Acmt029001.TaxParty2||XmlElement()||
|+|Dbtr|ISO20022.Acmt029001.TaxParty2||XmlElement()||
|+|Cdtr|ISO20022.Acmt029001.TaxParty1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rcrd""",Rcrd),validElement(Rcrd),validElement(TtlTaxAmt),validElement(TtlTaxblBaseAmt),validElement(UltmtDbtr),validElement(Dbtr),validElement(Cdtr))|

---

## Value ISO20022.Acmt029001.TaxParty1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxTp|String||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|TaxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Acmt029001.TaxParty2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Authstn|ISO20022.Acmt029001.TaxAuthorisation1||XmlElement()||
|+|TaxTp|String||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|TaxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Authstn))|

---

## Value ISO20022.Acmt029001.TaxPeriod3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrToDt|ISO20022.Acmt029001.DatePeriod2||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Yr|Int32||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToDt))|

---

## Enum ISO20022.Acmt029001.TaxRateMarker1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GRSS|Int32||XmlEnum("""GRSS""")|1|
||ALIT|Int32||XmlEnum("""ALIT""")|2|
||ALPR|Int32||XmlEnum("""ALPR""")|3|

---

## Value ISO20022.Acmt029001.TaxRecord3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|TaxAmt|ISO20022.Acmt029001.TaxAmount3||XmlElement()||
|+|Prd|ISO20022.Acmt029001.TaxPeriod3||XmlElement()||
|+|FrmsCd|String||XmlElement()||
|+|CertId|String||XmlElement()||
|+|DbtrSts|String||XmlElement()||
|+|CtgyDtls|String||XmlElement()||
|+|Ctgy|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxAmt),validElement(Prd))|

---

## Value ISO20022.Acmt029001.TaxRecordDetails3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Acmt029001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Prd|ISO20022.Acmt029001.TaxPeriod3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Prd))|

---

## Enum ISO20022.Acmt029001.TaxRecordPeriod1Code


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

## Value ISO20022.Acmt029001.TransferInstruction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|StartDt|DateTime||XmlElement()||
|+|StartDtTm|DateTime||XmlElement()||
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
|+|TrfInd|String||XmlElement()||
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

