# trck.001.001.04
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Trck001001.AccountIdentification4Choice {
        + Othr  : ISO20022.Trck001001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Trck001001.AccountIdentification4Choice *-- ISO20022.Trck001001.GenericAccountIdentification1
    class ISO20022.Trck001001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Trck001001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Trck001001.AddressType3Choice {
        + Prtry  : ISO20022.Trck001001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Trck001001.AddressType3Choice *-- ISO20022.Trck001001.GenericIdentification30
    class ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6 {
        + BrnchId  : ISO20022.Trck001001.BranchData3
        + FinInstnId  : ISO20022.Trck001001.FinancialInstitutionIdentification18
    }
    ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6 *-- ISO20022.Trck001001.BranchData3
    ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6 *-- ISO20022.Trck001001.FinancialInstitutionIdentification18
    class ISO20022.Trck001001.BranchData3 {
        + PstlAdr  : ISO20022.Trck001001.PostalAddress24
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Trck001001.BranchData3 *-- ISO20022.Trck001001.PostalAddress24
    class ISO20022.Trck001001.CashAccount38 {
        + Prxy  : ISO20022.Trck001001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Trck001001.CashAccountType2Choice
        + Id  : ISO20022.Trck001001.AccountIdentification4Choice
    }
    ISO20022.Trck001001.CashAccount38 *-- ISO20022.Trck001001.ProxyAccountIdentification1
    ISO20022.Trck001001.CashAccount38 *-- ISO20022.Trck001001.CashAccountType2Choice
    ISO20022.Trck001001.CashAccount38 *-- ISO20022.Trck001001.AccountIdentification4Choice
    class ISO20022.Trck001001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.CategoryPurpose1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.ChargeBearerType1Code {
        SLEV = 1
        SHAR = 2
        CRED = 3
        DEBT = 4
    }
    class ISO20022.Trck001001.Charges7 {
        + Agt  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + Amt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Trck001001.Charges7 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.Charges7 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Trck001001.ClearingChannel2Code {
        BOOK = 1
        MPNS = 2
        RTNS = 3
        RTGS = 4
    }
    class ISO20022.Trck001001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.ClearingSystemIdentification3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Trck001001.ClearingSystemIdentification2Choice
    }
    ISO20022.Trck001001.ClearingSystemMemberIdentification2 *-- ISO20022.Trck001001.ClearingSystemIdentification2Choice
    class ISO20022.Trck001001.Contact4 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Trck001001.OtherContact1~
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
    ISO20022.Trck001001.Contact4 *-- ISO20022.Trck001001.OtherContact1
    class ISO20022.Trck001001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Trck001001.CreditTransferTransaction46 {
        + InstdAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + RmtInf  : ISO20022.Trck001001.RemittanceInformation16
        + Tax  : ISO20022.Trck001001.TaxInformation8
        + InstrForNxtAgt  : global::System.Collections.Generic.List~ISO20022.Trck001001.InstructionForNextAgent1~
        + InstrForCdtrAgt  : global::System.Collections.Generic.List~ISO20022.Trck001001.InstructionForCreditorAgent3~
        + UltmtCdtr  : ISO20022.Trck001001.PartyIdentification135
        + CdtrAcct  : ISO20022.Trck001001.CashAccount38
        + Cdtr  : ISO20022.Trck001001.PartyIdentification135
        + CdtrAgtAcct  : ISO20022.Trck001001.CashAccount38
        + CdtrAgt  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + IntrmyAgt3Acct  : ISO20022.Trck001001.CashAccount38
        + IntrmyAgt3  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + IntrmyAgt2Acct  : ISO20022.Trck001001.CashAccount38
        + IntrmyAgt2  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + IntrmyAgt1Acct  : ISO20022.Trck001001.CashAccount38
        + IntrmyAgt1  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + PrvsInstgAgt3Acct  : ISO20022.Trck001001.CashAccount38
        + PrvsInstgAgt3  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + PrvsInstgAgt2Acct  : ISO20022.Trck001001.CashAccount38
        + PrvsInstgAgt2  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + PrvsInstgAgt1Acct  : ISO20022.Trck001001.CashAccount38
        + PrvsInstgAgt1  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + DbtrAgtAcct  : ISO20022.Trck001001.CashAccount38
        + DbtrAgt  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + DbtrAcct  : ISO20022.Trck001001.CashAccount38
        + Dbtr  : ISO20022.Trck001001.PartyIdentification135
        + InitgPty  : ISO20022.Trck001001.PartyIdentification135
        + UltmtDbtr  : ISO20022.Trck001001.PartyIdentification135
    }
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.RemittanceInformation16
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.TaxInformation8
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.InstructionForNextAgent1
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.InstructionForCreditorAgent3
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.PartyIdentification135
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.PartyIdentification135
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.PartyIdentification135
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.PartyIdentification135
    ISO20022.Trck001001.CreditTransferTransaction46 *-- ISO20022.Trck001001.PartyIdentification135
    class ISO20022.Trck001001.CreditorReferenceInformation2 {
        + Ref  : String
        + Tp  : ISO20022.Trck001001.CreditorReferenceType2
    }
    ISO20022.Trck001001.CreditorReferenceInformation2 *-- ISO20022.Trck001001.CreditorReferenceType2
    class ISO20022.Trck001001.CreditorReferenceType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.CreditorReferenceType2 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Trck001001.CreditorReferenceType1Choice
    }
    ISO20022.Trck001001.CreditorReferenceType2 *-- ISO20022.Trck001001.CreditorReferenceType1Choice
    class ISO20022.Trck001001.CurrencyExchange13 {
        + UnitCcy  : String
        + XchgRate  : Decimal
        + TrgtCcy  : String
        + SrcCcy  : String
    }
    class ISO20022.Trck001001.CurrencyExchange15 {
        + UnitCcy  : String
        + XchgRate  : Decimal
        + TrgtCcy  : String
        + SrcCcy  : String
    }
    class ISO20022.Trck001001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Trck001001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Trck001001.DatePeriod2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Trck001001.DiscountAmountAndType1 {
        + Amt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + Tp  : ISO20022.Trck001001.DiscountAmountType1Choice
    }
    ISO20022.Trck001001.DiscountAmountAndType1 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.DiscountAmountAndType1 *-- ISO20022.Trck001001.DiscountAmountType1Choice
    class ISO20022.Trck001001.DiscountAmountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.DocumentAdjustment1 {
        + AddtlInf  : String
        + Rsn  : String
        + CdtDbtInd  : String
        + Amt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Trck001001.DocumentAdjustment1 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Trck001001.DocumentLineIdentification1 {
        + RltdDt  : DateTime
        + Nb  : String
        + Tp  : ISO20022.Trck001001.DocumentLineType1
    }
    ISO20022.Trck001001.DocumentLineIdentification1 *-- ISO20022.Trck001001.DocumentLineType1
    class ISO20022.Trck001001.DocumentLineInformation1 {
        + Amt  : ISO20022.Trck001001.RemittanceAmount3
        + Desc  : String
        + Id  : global::System.Collections.Generic.List~ISO20022.Trck001001.DocumentLineIdentification1~
    }
    ISO20022.Trck001001.DocumentLineInformation1 *-- ISO20022.Trck001001.RemittanceAmount3
    ISO20022.Trck001001.DocumentLineInformation1 *-- ISO20022.Trck001001.DocumentLineIdentification1
    class ISO20022.Trck001001.DocumentLineType1 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Trck001001.DocumentLineType1Choice
    }
    ISO20022.Trck001001.DocumentLineType1 *-- ISO20022.Trck001001.DocumentLineType1Choice
    class ISO20022.Trck001001.DocumentLineType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.DocumentType3Code {
        SCOR = 1
        PUOR = 2
        DISP = 3
        FXDR = 4
        RPIN = 5
        RADM = 6
    }
    class ISO20022.Trck001001.DocumentType6Code {
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
    class ISO20022.Trck001001.EquivalentAmount2 {
        + CcyOfTrf  : String
        + Amt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Trck001001.EquivalentAmount2 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Trck001001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.FinancialInstitutionIdentification18 {
        + Othr  : ISO20022.Trck001001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Trck001001.PostalAddress24
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Trck001001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Trck001001.FinancialInstitutionIdentification18 *-- ISO20022.Trck001001.GenericFinancialIdentification1
    ISO20022.Trck001001.FinancialInstitutionIdentification18 *-- ISO20022.Trck001001.PostalAddress24
    ISO20022.Trck001001.FinancialInstitutionIdentification18 *-- ISO20022.Trck001001.ClearingSystemMemberIdentification2
    class ISO20022.Trck001001.FinancialInstitutionIdentification21 {
        + Othr  : ISO20022.Trck001001.GenericFinancialIdentification1
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Trck001001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Trck001001.FinancialInstitutionIdentification21 *-- ISO20022.Trck001001.GenericFinancialIdentification1
    ISO20022.Trck001001.FinancialInstitutionIdentification21 *-- ISO20022.Trck001001.ClearingSystemMemberIdentification2
    class ISO20022.Trck001001.Garnishment3 {
        + MplyeeTermntnInd  : String
        + FmlyMdclInsrncInd  : String
        + RmtdAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + Dt  : DateTime
        + RefNb  : String
        + GrnshmtAdmstr  : ISO20022.Trck001001.PartyIdentification135
        + Grnshee  : ISO20022.Trck001001.PartyIdentification135
        + Tp  : ISO20022.Trck001001.GarnishmentType1
    }
    ISO20022.Trck001001.Garnishment3 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.Garnishment3 *-- ISO20022.Trck001001.PartyIdentification135
    ISO20022.Trck001001.Garnishment3 *-- ISO20022.Trck001001.PartyIdentification135
    ISO20022.Trck001001.Garnishment3 *-- ISO20022.Trck001001.GarnishmentType1
    class ISO20022.Trck001001.GarnishmentType1 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Trck001001.GarnishmentType1Choice
    }
    ISO20022.Trck001001.GarnishmentType1 *-- ISO20022.Trck001001.GarnishmentType1Choice
    class ISO20022.Trck001001.GarnishmentType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Trck001001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Trck001001.GenericAccountIdentification1 *-- ISO20022.Trck001001.AccountSchemeName1Choice
    class ISO20022.Trck001001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Trck001001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Trck001001.GenericFinancialIdentification1 *-- ISO20022.Trck001001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Trck001001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Trck001001.GenericOrganisationIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Trck001001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Trck001001.GenericOrganisationIdentification1 *-- ISO20022.Trck001001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Trck001001.GenericPersonIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Trck001001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Trck001001.GenericPersonIdentification1 *-- ISO20022.Trck001001.PersonIdentificationSchemeName1Choice
    class ISO20022.Trck001001.Instruction4Code {
        TELA = 1
        PHOA = 2
    }
    class ISO20022.Trck001001.InstructionForCreditorAgent3 {
        + InstrInf  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.InstructionForNextAgent1 {
        + InstrInf  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.LocalInstrument2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.NameAndAddress16 {
        + Adr  : ISO20022.Trck001001.PostalAddress24
        + Nm  : String
    }
    ISO20022.Trck001001.NameAndAddress16 *-- ISO20022.Trck001001.PostalAddress24
    class ISO20022.Trck001001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Trck001001.OrganisationIdentification29 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Trck001001.GenericOrganisationIdentification1~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Trck001001.OrganisationIdentification29 *-- ISO20022.Trck001001.GenericOrganisationIdentification1
    class ISO20022.Trck001001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.OriginalBusinessInstruction4 {
        + CreDtTm  : DateTime
        + MsgNmId  : String
        + MsgId  : String
    }
    class ISO20022.Trck001001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Trck001001.Party38Choice {
        + PrvtId  : ISO20022.Trck001001.PersonIdentification13
        + OrgId  : ISO20022.Trck001001.OrganisationIdentification29
    }
    ISO20022.Trck001001.Party38Choice *-- ISO20022.Trck001001.PersonIdentification13
    ISO20022.Trck001001.Party38Choice *-- ISO20022.Trck001001.OrganisationIdentification29
    class ISO20022.Trck001001.Party40Choice {
        + Agt  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + Pty  : ISO20022.Trck001001.PartyIdentification135
    }
    ISO20022.Trck001001.Party40Choice *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.Party40Choice *-- ISO20022.Trck001001.PartyIdentification135
    class ISO20022.Trck001001.PartyIdentification135 {
        + CtctDtls  : ISO20022.Trck001001.Contact4
        + CtryOfRes  : String
        + Id  : ISO20022.Trck001001.Party38Choice
        + PstlAdr  : ISO20022.Trck001001.PostalAddress24
        + Nm  : String
    }
    ISO20022.Trck001001.PartyIdentification135 *-- ISO20022.Trck001001.Contact4
    ISO20022.Trck001001.PartyIdentification135 *-- ISO20022.Trck001001.Party38Choice
    ISO20022.Trck001001.PartyIdentification135 *-- ISO20022.Trck001001.PostalAddress24
    class ISO20022.Trck001001.PaymentIdentification10 {
        + ClrSysRef  : String
        + UETR  : String
        + TxId  : String
        + EndToEndId  : String
        + InstrId  : String
    }
    class ISO20022.Trck001001.PaymentRejectReturnReason1 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + Rsn  : ISO20022.Trck001001.ReturnReason5Choice
    }
    ISO20022.Trck001001.PaymentRejectReturnReason1 *-- ISO20022.Trck001001.ReturnReason5Choice
    class ISO20022.Trck001001.PaymentScenario1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.PaymentStatusReason1 {
        + AddtlInf  : global::System.Collections.Generic.List~String~
        + Rsn  : ISO20022.Trck001001.StatusReason6Choice
    }
    ISO20022.Trck001001.PaymentStatusReason1 *-- ISO20022.Trck001001.StatusReason6Choice
    class ISO20022.Trck001001.PaymentStatusTrackerUpdateV04 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Trck001001.SupplementaryData1~
        + TrckrStsAndTx  : global::System.Collections.Generic.List~ISO20022.Trck001001.TrackerStatusAndTransaction19~
        + GrpHdr  : ISO20022.Trck001001.TrackerHeader6
    }
    ISO20022.Trck001001.PaymentStatusTrackerUpdateV04 *-- ISO20022.Trck001001.SupplementaryData1
    ISO20022.Trck001001.PaymentStatusTrackerUpdateV04 *-- ISO20022.Trck001001.TrackerStatusAndTransaction19
    ISO20022.Trck001001.PaymentStatusTrackerUpdateV04 *-- ISO20022.Trck001001.TrackerHeader6
    class ISO20022.Trck001001.PaymentTypeInformation28 {
        + CtgyPurp  : ISO20022.Trck001001.CategoryPurpose1Choice
        + LclInstrm  : ISO20022.Trck001001.LocalInstrument2Choice
        + SvcLvl  : global::System.Collections.Generic.List~ISO20022.Trck001001.ServiceLevel8Choice~
        + ClrChanl  : String
        + InstrPrty  : String
    }
    ISO20022.Trck001001.PaymentTypeInformation28 *-- ISO20022.Trck001001.CategoryPurpose1Choice
    ISO20022.Trck001001.PaymentTypeInformation28 *-- ISO20022.Trck001001.LocalInstrument2Choice
    ISO20022.Trck001001.PaymentTypeInformation28 *-- ISO20022.Trck001001.ServiceLevel8Choice
    class ISO20022.Trck001001.PersonIdentification13 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Trck001001.GenericPersonIdentification1~
        + DtAndPlcOfBirth  : ISO20022.Trck001001.DateAndPlaceOfBirth1
    }
    ISO20022.Trck001001.PersonIdentification13 *-- ISO20022.Trck001001.GenericPersonIdentification1
    ISO20022.Trck001001.PersonIdentification13 *-- ISO20022.Trck001001.DateAndPlaceOfBirth1
    class ISO20022.Trck001001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.PostalAddress24 {
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
        + AdrTp  : ISO20022.Trck001001.AddressType3Choice
    }
    ISO20022.Trck001001.PostalAddress24 *-- ISO20022.Trck001001.AddressType3Choice
    class ISO20022.Trck001001.PreferredContactMethod1Code {
        CELL = 1
        FAXX = 2
        PHON = 3
        MAIL = 4
        LETT = 5
    }
    class ISO20022.Trck001001.Priority2Code {
        NORM = 1
        HIGH = 2
    }
    class ISO20022.Trck001001.Priority3Code {
        NORM = 1
        HIGH = 2
        URGT = 3
    }
    class ISO20022.Trck001001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Trck001001.ProxyAccountType1Choice
    }
    ISO20022.Trck001001.ProxyAccountIdentification1 *-- ISO20022.Trck001001.ProxyAccountType1Choice
    class ISO20022.Trck001001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.Purpose2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.ReferredDocumentInformation7 {
        + LineDtls  : global::System.Collections.Generic.List~ISO20022.Trck001001.DocumentLineInformation1~
        + RltdDt  : DateTime
        + Nb  : String
        + Tp  : ISO20022.Trck001001.ReferredDocumentType4
    }
    ISO20022.Trck001001.ReferredDocumentInformation7 *-- ISO20022.Trck001001.DocumentLineInformation1
    ISO20022.Trck001001.ReferredDocumentInformation7 *-- ISO20022.Trck001001.ReferredDocumentType4
    class ISO20022.Trck001001.ReferredDocumentType3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.ReferredDocumentType4 {
        + Issr  : String
        + CdOrPrtry  : ISO20022.Trck001001.ReferredDocumentType3Choice
    }
    ISO20022.Trck001001.ReferredDocumentType4 *-- ISO20022.Trck001001.ReferredDocumentType3Choice
    class ISO20022.Trck001001.RegulatoryAuthority2 {
        + Ctry  : String
        + Nm  : String
    }
    class ISO20022.Trck001001.RegulatoryReporting3 {
        + Dtls  : global::System.Collections.Generic.List~ISO20022.Trck001001.StructuredRegulatoryReporting3~
        + Authrty  : ISO20022.Trck001001.RegulatoryAuthority2
        + DbtCdtRptgInd  : String
    }
    ISO20022.Trck001001.RegulatoryReporting3 *-- ISO20022.Trck001001.StructuredRegulatoryReporting3
    ISO20022.Trck001001.RegulatoryReporting3 *-- ISO20022.Trck001001.RegulatoryAuthority2
    class ISO20022.Trck001001.RegulatoryReportingType1Code {
        BOTH = 1
        DEBT = 2
        CRED = 3
    }
    class ISO20022.Trck001001.RelatedTransactionData1 {
        + SubUETR  : global::System.Collections.Generic.List~String~
        + MstrUETR  : String
    }
    class ISO20022.Trck001001.RemittanceAmount2 {
        + RmtdAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + AdjstmntAmtAndRsn  : global::System.Collections.Generic.List~ISO20022.Trck001001.DocumentAdjustment1~
        + TaxAmt  : global::System.Collections.Generic.List~ISO20022.Trck001001.TaxAmountAndType1~
        + CdtNoteAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + DscntApldAmt  : global::System.Collections.Generic.List~ISO20022.Trck001001.DiscountAmountAndType1~
        + DuePyblAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Trck001001.RemittanceAmount2 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.RemittanceAmount2 *-- ISO20022.Trck001001.DocumentAdjustment1
    ISO20022.Trck001001.RemittanceAmount2 *-- ISO20022.Trck001001.TaxAmountAndType1
    ISO20022.Trck001001.RemittanceAmount2 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.RemittanceAmount2 *-- ISO20022.Trck001001.DiscountAmountAndType1
    ISO20022.Trck001001.RemittanceAmount2 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Trck001001.RemittanceAmount3 {
        + RmtdAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + AdjstmntAmtAndRsn  : global::System.Collections.Generic.List~ISO20022.Trck001001.DocumentAdjustment1~
        + TaxAmt  : global::System.Collections.Generic.List~ISO20022.Trck001001.TaxAmountAndType1~
        + CdtNoteAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + DscntApldAmt  : global::System.Collections.Generic.List~ISO20022.Trck001001.DiscountAmountAndType1~
        + DuePyblAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Trck001001.RemittanceAmount3 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.RemittanceAmount3 *-- ISO20022.Trck001001.DocumentAdjustment1
    ISO20022.Trck001001.RemittanceAmount3 *-- ISO20022.Trck001001.TaxAmountAndType1
    ISO20022.Trck001001.RemittanceAmount3 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.RemittanceAmount3 *-- ISO20022.Trck001001.DiscountAmountAndType1
    ISO20022.Trck001001.RemittanceAmount3 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Trck001001.RemittanceInformation16 {
        + Strd  : global::System.Collections.Generic.List~ISO20022.Trck001001.StructuredRemittanceInformation16~
        + Ustrd  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Trck001001.RemittanceInformation16 *-- ISO20022.Trck001001.StructuredRemittanceInformation16
    class ISO20022.Trck001001.RemittanceLocation7 {
        + RmtLctnDtls  : global::System.Collections.Generic.List~ISO20022.Trck001001.RemittanceLocationData1~
        + RmtId  : String
    }
    ISO20022.Trck001001.RemittanceLocation7 *-- ISO20022.Trck001001.RemittanceLocationData1
    class ISO20022.Trck001001.RemittanceLocationData1 {
        + PstlAdr  : ISO20022.Trck001001.NameAndAddress16
        + ElctrncAdr  : String
        + Mtd  : String
    }
    ISO20022.Trck001001.RemittanceLocationData1 *-- ISO20022.Trck001001.NameAndAddress16
    class ISO20022.Trck001001.RemittanceLocationMethod2Code {
        SMSM = 1
        POST = 2
        EMAL = 3
        URID = 4
        EDIC = 5
        FAXI = 6
    }
    class ISO20022.Trck001001.ReturnReason5Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.ServiceLevel8Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.SettlementDateTimeIndication1 {
        + CdtDtTm  : DateTime
        + DbtDtTm  : DateTime
    }
    class ISO20022.Trck001001.SettlementInstruction9 {
        + ThrdRmbrsmntAgtAcct  : ISO20022.Trck001001.CashAccount38
        + ThrdRmbrsmntAgt  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + InstdRmbrsmntAgtAcct  : ISO20022.Trck001001.CashAccount38
        + InstdRmbrsmntAgt  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + InstgRmbrsmntAgtAcct  : ISO20022.Trck001001.CashAccount38
        + InstgRmbrsmntAgt  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + ClrSys  : ISO20022.Trck001001.ClearingSystemIdentification3Choice
        + SttlmAcct  : ISO20022.Trck001001.CashAccount38
        + SttlmMtd  : String
    }
    ISO20022.Trck001001.SettlementInstruction9 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.SettlementInstruction9 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.SettlementInstruction9 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.SettlementInstruction9 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.SettlementInstruction9 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.SettlementInstruction9 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.SettlementInstruction9 *-- ISO20022.Trck001001.ClearingSystemIdentification3Choice
    ISO20022.Trck001001.SettlementInstruction9 *-- ISO20022.Trck001001.CashAccount38
    class ISO20022.Trck001001.SettlementMethod1Code {
        CLRG = 1
        COVE = 2
        INGA = 3
        INDA = 4
    }
    class ISO20022.Trck001001.SettlementTimeRequest2 {
        + RjctTm  : DateTime
        + FrTm  : DateTime
        + TillTm  : DateTime
        + CLSTm  : DateTime
    }
    class ISO20022.Trck001001.StatusReason6Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.StructuredRegulatoryReporting3 {
        + Inf  : global::System.Collections.Generic.List~String~
        + Amt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + Cd  : String
        + Ctry  : String
        + Dt  : DateTime
        + Tp  : String
    }
    ISO20022.Trck001001.StructuredRegulatoryReporting3 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Trck001001.StructuredRemittanceInformation16 {
        + AddtlRmtInf  : global::System.Collections.Generic.List~String~
        + GrnshmtRmt  : ISO20022.Trck001001.Garnishment3
        + TaxRmt  : ISO20022.Trck001001.TaxInformation7
        + Invcee  : ISO20022.Trck001001.PartyIdentification135
        + Invcr  : ISO20022.Trck001001.PartyIdentification135
        + CdtrRefInf  : ISO20022.Trck001001.CreditorReferenceInformation2
        + RfrdDocAmt  : ISO20022.Trck001001.RemittanceAmount2
        + RfrdDocInf  : global::System.Collections.Generic.List~ISO20022.Trck001001.ReferredDocumentInformation7~
    }
    ISO20022.Trck001001.StructuredRemittanceInformation16 *-- ISO20022.Trck001001.Garnishment3
    ISO20022.Trck001001.StructuredRemittanceInformation16 *-- ISO20022.Trck001001.TaxInformation7
    ISO20022.Trck001001.StructuredRemittanceInformation16 *-- ISO20022.Trck001001.PartyIdentification135
    ISO20022.Trck001001.StructuredRemittanceInformation16 *-- ISO20022.Trck001001.PartyIdentification135
    ISO20022.Trck001001.StructuredRemittanceInformation16 *-- ISO20022.Trck001001.CreditorReferenceInformation2
    ISO20022.Trck001001.StructuredRemittanceInformation16 *-- ISO20022.Trck001001.RemittanceAmount2
    ISO20022.Trck001001.StructuredRemittanceInformation16 *-- ISO20022.Trck001001.ReferredDocumentInformation7
    class ISO20022.Trck001001.SupplementaryData1 {
        + Envlp  : ISO20022.Trck001001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Trck001001.SupplementaryData1 *-- ISO20022.Trck001001.SupplementaryDataEnvelope1
    class ISO20022.Trck001001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Trck001001.TaxAmount2 {
        + Dtls  : global::System.Collections.Generic.List~ISO20022.Trck001001.TaxRecordDetails2~
        + TtlAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + TaxblBaseAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + Rate  : Decimal
    }
    ISO20022.Trck001001.TaxAmount2 *-- ISO20022.Trck001001.TaxRecordDetails2
    ISO20022.Trck001001.TaxAmount2 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.TaxAmount2 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Trck001001.TaxAmountAndType1 {
        + Amt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + Tp  : ISO20022.Trck001001.TaxAmountType1Choice
    }
    ISO20022.Trck001001.TaxAmountAndType1 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.TaxAmountAndType1 *-- ISO20022.Trck001001.TaxAmountType1Choice
    class ISO20022.Trck001001.TaxAmountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Trck001001.TaxAuthorisation1 {
        + Nm  : String
        + Titl  : String
    }
    class ISO20022.Trck001001.TaxInformation7 {
        + Rcrd  : global::System.Collections.Generic.List~ISO20022.Trck001001.TaxRecord2~
        + SeqNb  : Decimal
        + Dt  : DateTime
        + TtlTaxAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + TtlTaxblBaseAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + Mtd  : String
        + RefNb  : String
        + AdmstnZone  : String
        + UltmtDbtr  : ISO20022.Trck001001.TaxParty2
        + Dbtr  : ISO20022.Trck001001.TaxParty2
        + Cdtr  : ISO20022.Trck001001.TaxParty1
    }
    ISO20022.Trck001001.TaxInformation7 *-- ISO20022.Trck001001.TaxRecord2
    ISO20022.Trck001001.TaxInformation7 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.TaxInformation7 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.TaxInformation7 *-- ISO20022.Trck001001.TaxParty2
    ISO20022.Trck001001.TaxInformation7 *-- ISO20022.Trck001001.TaxParty2
    ISO20022.Trck001001.TaxInformation7 *-- ISO20022.Trck001001.TaxParty1
    class ISO20022.Trck001001.TaxInformation8 {
        + Rcrd  : global::System.Collections.Generic.List~ISO20022.Trck001001.TaxRecord2~
        + SeqNb  : Decimal
        + Dt  : DateTime
        + TtlTaxAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + TtlTaxblBaseAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + Mtd  : String
        + RefNb  : String
        + AdmstnZone  : String
        + Dbtr  : ISO20022.Trck001001.TaxParty2
        + Cdtr  : ISO20022.Trck001001.TaxParty1
    }
    ISO20022.Trck001001.TaxInformation8 *-- ISO20022.Trck001001.TaxRecord2
    ISO20022.Trck001001.TaxInformation8 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.TaxInformation8 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.TaxInformation8 *-- ISO20022.Trck001001.TaxParty2
    ISO20022.Trck001001.TaxInformation8 *-- ISO20022.Trck001001.TaxParty1
    class ISO20022.Trck001001.TaxParty1 {
        + TaxTp  : String
        + RegnId  : String
        + TaxId  : String
    }
    class ISO20022.Trck001001.TaxParty2 {
        + Authstn  : ISO20022.Trck001001.TaxAuthorisation1
        + TaxTp  : String
        + RegnId  : String
        + TaxId  : String
    }
    ISO20022.Trck001001.TaxParty2 *-- ISO20022.Trck001001.TaxAuthorisation1
    class ISO20022.Trck001001.TaxPeriod2 {
        + FrToDt  : ISO20022.Trck001001.DatePeriod2
        + Tp  : String
        + Yr  : DateTime
    }
    ISO20022.Trck001001.TaxPeriod2 *-- ISO20022.Trck001001.DatePeriod2
    class ISO20022.Trck001001.TaxRecord2 {
        + AddtlInf  : String
        + TaxAmt  : ISO20022.Trck001001.TaxAmount2
        + Prd  : ISO20022.Trck001001.TaxPeriod2
        + FrmsCd  : String
        + CertId  : String
        + DbtrSts  : String
        + CtgyDtls  : String
        + Ctgy  : String
        + Tp  : String
    }
    ISO20022.Trck001001.TaxRecord2 *-- ISO20022.Trck001001.TaxAmount2
    ISO20022.Trck001001.TaxRecord2 *-- ISO20022.Trck001001.TaxPeriod2
    class ISO20022.Trck001001.TaxRecordDetails2 {
        + Amt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + Prd  : ISO20022.Trck001001.TaxPeriod2
    }
    ISO20022.Trck001001.TaxRecordDetails2 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.TaxRecordDetails2 *-- ISO20022.Trck001001.TaxPeriod2
    class ISO20022.Trck001001.TaxRecordPeriod1Code {
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
    class ISO20022.Trck001001.TrackerData8 {
        + PrevslyConfdDt  : ISO20022.Trck001001.DateAndDateTime2Choice
        + PrevslyConfdAmt  : ISO20022.Trck001001.ActiveCurrencyAndAmount
        + RmngToBeConfdAmt  : ISO20022.Trck001001.ActiveCurrencyAndAmount
        + RtrdConfdAmt  : ISO20022.Trck001001.ActiveCurrencyAndAmount
        + RtrdConfdDt  : ISO20022.Trck001001.DateAndDateTime2Choice
        + ConfdAmt  : ISO20022.Trck001001.ActiveCurrencyAndAmount
        + ConfdDt  : ISO20022.Trck001001.DateAndDateTime2Choice
    }
    ISO20022.Trck001001.TrackerData8 *-- ISO20022.Trck001001.DateAndDateTime2Choice
    ISO20022.Trck001001.TrackerData8 *-- ISO20022.Trck001001.ActiveCurrencyAndAmount
    ISO20022.Trck001001.TrackerData8 *-- ISO20022.Trck001001.ActiveCurrencyAndAmount
    ISO20022.Trck001001.TrackerData8 *-- ISO20022.Trck001001.ActiveCurrencyAndAmount
    ISO20022.Trck001001.TrackerData8 *-- ISO20022.Trck001001.DateAndDateTime2Choice
    ISO20022.Trck001001.TrackerData8 *-- ISO20022.Trck001001.ActiveCurrencyAndAmount
    ISO20022.Trck001001.TrackerData8 *-- ISO20022.Trck001001.DateAndDateTime2Choice
    class ISO20022.Trck001001.TrackerHeader6 {
        + SvcLvl  : ISO20022.Trck001001.ServiceLevel8Choice
        + TrckrInfrmdPty  : ISO20022.Trck001001.TrackerPartyIdentification2
        + TrckrInfrmgPty  : ISO20022.Trck001001.TrackerPartyIdentification2
        + NbOfTxs  : String
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Trck001001.TrackerHeader6 *-- ISO20022.Trck001001.ServiceLevel8Choice
    ISO20022.Trck001001.TrackerHeader6 *-- ISO20022.Trck001001.TrackerPartyIdentification2
    ISO20022.Trck001001.TrackerHeader6 *-- ISO20022.Trck001001.TrackerPartyIdentification2
    class ISO20022.Trck001001.TrackerParty2Choice {
        + FinInstnId  : ISO20022.Trck001001.FinancialInstitutionIdentification21
        + PrvtId  : ISO20022.Trck001001.PersonIdentification13
        + OrgId  : ISO20022.Trck001001.OrganisationIdentification29
    }
    ISO20022.Trck001001.TrackerParty2Choice *-- ISO20022.Trck001001.FinancialInstitutionIdentification21
    ISO20022.Trck001001.TrackerParty2Choice *-- ISO20022.Trck001001.PersonIdentification13
    ISO20022.Trck001001.TrackerParty2Choice *-- ISO20022.Trck001001.OrganisationIdentification29
    class ISO20022.Trck001001.TrackerPartyIdentification2 {
        + Id  : ISO20022.Trck001001.TrackerParty2Choice
        + PstlAdr  : ISO20022.Trck001001.PostalAddress24
        + Nm  : String
    }
    ISO20022.Trck001001.TrackerPartyIdentification2 *-- ISO20022.Trck001001.TrackerParty2Choice
    ISO20022.Trck001001.TrackerPartyIdentification2 *-- ISO20022.Trck001001.PostalAddress24
    class ISO20022.Trck001001.TrackerPaymentTransaction14 {
        + UndrlygCstmrCdtTrf  : ISO20022.Trck001001.CreditTransferTransaction46
        + RtrChain  : ISO20022.Trck001001.TransactionParties8
        + RjctRtrRsn  : global::System.Collections.Generic.List~ISO20022.Trck001001.PaymentRejectReturnReason1~
        + RmtInf  : ISO20022.Trck001001.RemittanceInformation16
        + RltdRmtInf  : global::System.Collections.Generic.List~ISO20022.Trck001001.RemittanceLocation7~
        + Tax  : ISO20022.Trck001001.TaxInformation8
        + RgltryRptg  : global::System.Collections.Generic.List~ISO20022.Trck001001.RegulatoryReporting3~
        + Purp  : ISO20022.Trck001001.Purpose2Choice
        + InstrForNxtAgt  : global::System.Collections.Generic.List~ISO20022.Trck001001.InstructionForNextAgent1~
        + InstrForCdtrAgt  : global::System.Collections.Generic.List~ISO20022.Trck001001.InstructionForCreditorAgent3~
        + UltmtCdtr  : ISO20022.Trck001001.PartyIdentification135
        + CdtrAcct  : ISO20022.Trck001001.CashAccount38
        + Cdtr  : ISO20022.Trck001001.Party40Choice
        + CdtrAgtAcct  : ISO20022.Trck001001.CashAccount38
        + CdtrAgt  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + DbtrAgtAcct  : ISO20022.Trck001001.CashAccount38
        + DbtrAgt  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + DbtrAcct  : ISO20022.Trck001001.CashAccount38
        + Dbtr  : ISO20022.Trck001001.Party40Choice
        + InitgPty  : ISO20022.Trck001001.PartyIdentification135
        + UltmtDbtr  : ISO20022.Trck001001.PartyIdentification135
        + IntrmyAgt3Acct  : ISO20022.Trck001001.CashAccount38
        + IntrmyAgt3  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + IntrmyAgt2Acct  : ISO20022.Trck001001.CashAccount38
        + IntrmyAgt2  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + IntrmyAgt1Acct  : ISO20022.Trck001001.CashAccount38
        + IntrmyAgt1  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + PrvsInstgAgt3Acct  : ISO20022.Trck001001.CashAccount38
        + PrvsInstgAgt3  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + PrvsInstgAgt2Acct  : ISO20022.Trck001001.CashAccount38
        + PrvsInstgAgt2  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + PrvsInstgAgt1Acct  : ISO20022.Trck001001.CashAccount38
        + PrvsInstgAgt1  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + DbtConfURLAdr  : String
        + TrckrData  : ISO20022.Trck001001.TrackerData8
        + TrckrRcrd  : global::System.Collections.Generic.List~ISO20022.Trck001001.TrackerRecord8~
        + ChrgsInf  : global::System.Collections.Generic.List~ISO20022.Trck001001.Charges7~
        + ChrgBr  : String
        + XchgRateData  : ISO20022.Trck001001.CurrencyExchange15
        + RtrdInstdAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + EqvtAmt  : ISO20022.Trck001001.EquivalentAmount2
        + InstdAmt  : ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
        + PoolgAdjstmntDt  : DateTime
        + AccptncDtTm  : DateTime
        + SttlmTmReq  : ISO20022.Trck001001.SettlementTimeRequest2
        + SttlmTmIndctn  : ISO20022.Trck001001.SettlementDateTimeIndication1
        + SttlmPrty  : String
        + ReqdExctnDt  : ISO20022.Trck001001.DateAndDateTime2Choice
        + IntrBkSttlmDt  : DateTime
        + RtrdIntrBkSttlmAmt  : ISO20022.Trck001001.ActiveCurrencyAndAmount
        + IntrBkSttlmAmt  : ISO20022.Trck001001.ActiveCurrencyAndAmount
        + InstdAgt  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + InstgAgt  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + SttlmInf  : ISO20022.Trck001001.SettlementInstruction9
        + PmtScnro  : ISO20022.Trck001001.PaymentScenario1Choice
        + PmtTpInf  : ISO20022.Trck001001.PaymentTypeInformation28
        + OrgnlEndToEndId  : String
        + OrgnlInstrId  : String
        + RltdPmtId  : ISO20022.Trck001001.RelatedTransactionData1
        + PmtId  : ISO20022.Trck001001.PaymentIdentification10
        + TechRcvr  : String
        + TechSndr  : String
        + TrckrInfrmdPty  : ISO20022.Trck001001.TrackerPartyIdentification2
        + TrckrInfrmgPty  : ISO20022.Trck001001.TrackerPartyIdentification2
        + TrckdMsgId  : ISO20022.Trck001001.OriginalBusinessInstruction4
    }
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.CreditTransferTransaction46
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.TransactionParties8
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.PaymentRejectReturnReason1
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.RemittanceInformation16
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.RemittanceLocation7
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.TaxInformation8
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.RegulatoryReporting3
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.Purpose2Choice
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.InstructionForNextAgent1
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.InstructionForCreditorAgent3
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.PartyIdentification135
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.Party40Choice
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.Party40Choice
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.PartyIdentification135
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.PartyIdentification135
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.TrackerData8
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.TrackerRecord8
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.Charges7
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.CurrencyExchange15
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.EquivalentAmount2
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.SettlementTimeRequest2
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.SettlementDateTimeIndication1
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.DateAndDateTime2Choice
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.ActiveCurrencyAndAmount
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.ActiveCurrencyAndAmount
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.SettlementInstruction9
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.PaymentScenario1Choice
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.PaymentTypeInformation28
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.RelatedTransactionData1
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.PaymentIdentification10
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.TrackerPartyIdentification2
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.TrackerPartyIdentification2
    ISO20022.Trck001001.TrackerPaymentTransaction14 *-- ISO20022.Trck001001.OriginalBusinessInstruction4
    class ISO20022.Trck001001.TrackerRecord8 {
        + PrcgDtTm  : DateTime
        + XchgRateData  : ISO20022.Trck001001.CurrencyExchange13
        + ChrgsAmt  : ISO20022.Trck001001.ActiveCurrencyAndAmount
        + ChrgBr  : String
        + IntrBkSttlmAmt  : ISO20022.Trck001001.ActiveCurrencyAndAmount
        + PtyOrAgtId  : ISO20022.Trck001001.TrackerPartyIdentification2
    }
    ISO20022.Trck001001.TrackerRecord8 *-- ISO20022.Trck001001.CurrencyExchange13
    ISO20022.Trck001001.TrackerRecord8 *-- ISO20022.Trck001001.ActiveCurrencyAndAmount
    ISO20022.Trck001001.TrackerRecord8 *-- ISO20022.Trck001001.ActiveCurrencyAndAmount
    ISO20022.Trck001001.TrackerRecord8 *-- ISO20022.Trck001001.TrackerPartyIdentification2
    class ISO20022.Trck001001.TrackerStatus1 {
        + RjctRtrRsn  : global::System.Collections.Generic.List~ISO20022.Trck001001.PaymentRejectReturnReason1~
        + StsRsn  : global::System.Collections.Generic.List~ISO20022.Trck001001.PaymentStatusReason1~
        + Dt  : ISO20022.Trck001001.DateAndDateTime2Choice
        + Sts  : String
    }
    ISO20022.Trck001001.TrackerStatus1 *-- ISO20022.Trck001001.PaymentRejectReturnReason1
    ISO20022.Trck001001.TrackerStatus1 *-- ISO20022.Trck001001.PaymentStatusReason1
    ISO20022.Trck001001.TrackerStatus1 *-- ISO20022.Trck001001.DateAndDateTime2Choice
    class ISO20022.Trck001001.TrackerStatusAndTransaction19 {
        + Tx  : global::System.Collections.Generic.List~ISO20022.Trck001001.TrackerPaymentTransaction14~
        + TxSts  : ISO20022.Trck001001.TrackerStatus1
    }
    ISO20022.Trck001001.TrackerStatusAndTransaction19 *-- ISO20022.Trck001001.TrackerPaymentTransaction14
    ISO20022.Trck001001.TrackerStatusAndTransaction19 *-- ISO20022.Trck001001.TrackerStatus1
    class ISO20022.Trck001001.TransactionParties8 {
        + UltmtCdtr  : ISO20022.Trck001001.Party40Choice
        + CdtrAcct  : ISO20022.Trck001001.CashAccount38
        + Cdtr  : ISO20022.Trck001001.Party40Choice
        + CdtrAgtAcct  : ISO20022.Trck001001.CashAccount38
        + CdtrAgt  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + IntrmyAgt3Acct  : ISO20022.Trck001001.CashAccount38
        + IntrmyAgt3  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + IntrmyAgt2Acct  : ISO20022.Trck001001.CashAccount38
        + IntrmyAgt2  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + IntrmyAgt1Acct  : ISO20022.Trck001001.CashAccount38
        + IntrmyAgt1  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + PrvsInstgAgt3Acct  : ISO20022.Trck001001.CashAccount38
        + PrvsInstgAgt3  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + PrvsInstgAgt2Acct  : ISO20022.Trck001001.CashAccount38
        + PrvsInstgAgt2  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + PrvsInstgAgt1Acct  : ISO20022.Trck001001.CashAccount38
        + PrvsInstgAgt1  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + DbtrAgtAcct  : ISO20022.Trck001001.CashAccount38
        + DbtrAgt  : ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
        + InitgPty  : ISO20022.Trck001001.Party40Choice
        + DbtrAcct  : ISO20022.Trck001001.CashAccount38
        + Dbtr  : ISO20022.Trck001001.Party40Choice
        + UltmtDbtr  : ISO20022.Trck001001.Party40Choice
    }
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.Party40Choice
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.Party40Choice
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.Party40Choice
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.CashAccount38
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.Party40Choice
    ISO20022.Trck001001.TransactionParties8 *-- ISO20022.Trck001001.Party40Choice
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

## Value ISO20022.Trck001001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Trck001001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Trck001001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Trck001001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Trck001001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Trck001001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Trck001001.BranchData3||XmlElement()||
|+|FinInstnId|ISO20022.Trck001001.FinancialInstitutionIdentification18||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Trck001001.BranchData3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Trck001001.PostalAddress24||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Trck001001.CashAccount38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Trck001001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Trck001001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Trck001001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Trck001001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.CategoryPurpose1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Trck001001.ChargeBearerType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SLEV|Int32||XmlEnum("""SLEV""")|1|
||SHAR|Int32||XmlEnum("""SHAR""")|2|
||CRED|Int32||XmlEnum("""CRED""")|3|
||DEBT|Int32||XmlEnum("""DEBT""")|4|

---

## Value ISO20022.Trck001001.Charges7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Agt|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|Amt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Agt),validElement(Amt))|

---

## Enum ISO20022.Trck001001.ClearingChannel2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOOK|Int32||XmlEnum("""BOOK""")|1|
||MPNS|Int32||XmlEnum("""MPNS""")|2|
||RTNS|Int32||XmlEnum("""RTNS""")|3|
||RTGS|Int32||XmlEnum("""RTGS""")|4|

---

## Value ISO20022.Trck001001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.ClearingSystemIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Trck001001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Trck001001.Contact4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Trck001001.OtherContact1>||XmlElement()||
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

## Enum ISO20022.Trck001001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Trck001001.CreditTransferTransaction46


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstdAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|RmtInf|ISO20022.Trck001001.RemittanceInformation16||XmlElement()||
|+|Tax|ISO20022.Trck001001.TaxInformation8||XmlElement()||
|+|InstrForNxtAgt|global::System.Collections.Generic.List<ISO20022.Trck001001.InstructionForNextAgent1>||XmlElement()||
|+|InstrForCdtrAgt|global::System.Collections.Generic.List<ISO20022.Trck001001.InstructionForCreditorAgent3>||XmlElement()||
|+|UltmtCdtr|ISO20022.Trck001001.PartyIdentification135||XmlElement()||
|+|CdtrAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|Cdtr|ISO20022.Trck001001.PartyIdentification135||XmlElement()||
|+|CdtrAgtAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|CdtrAgt|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|IntrmyAgt3Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|IntrmyAgt3|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|IntrmyAgt2Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|IntrmyAgt2|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|IntrmyAgt1Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|IntrmyAgt1|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|PrvsInstgAgt3Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|PrvsInstgAgt3|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|PrvsInstgAgt2Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|PrvsInstgAgt2|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|PrvsInstgAgt1Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|PrvsInstgAgt1|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|DbtrAgtAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|DbtrAgt|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|DbtrAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|Dbtr|ISO20022.Trck001001.PartyIdentification135||XmlElement()||
|+|InitgPty|ISO20022.Trck001001.PartyIdentification135||XmlElement()||
|+|UltmtDbtr|ISO20022.Trck001001.PartyIdentification135||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstdAmt),validElement(RmtInf),validElement(Tax),validList("""InstrForNxtAgt""",InstrForNxtAgt),validElement(InstrForNxtAgt),validList("""InstrForCdtrAgt""",InstrForCdtrAgt),validElement(InstrForCdtrAgt),validElement(UltmtCdtr),validElement(CdtrAcct),validElement(Cdtr),validElement(CdtrAgtAcct),validElement(CdtrAgt),validElement(IntrmyAgt3Acct),validElement(IntrmyAgt3),validElement(IntrmyAgt2Acct),validElement(IntrmyAgt2),validElement(IntrmyAgt1Acct),validElement(IntrmyAgt1),validElement(PrvsInstgAgt3Acct),validElement(PrvsInstgAgt3),validElement(PrvsInstgAgt2Acct),validElement(PrvsInstgAgt2),validElement(PrvsInstgAgt1Acct),validElement(PrvsInstgAgt1),validElement(DbtrAgtAcct),validElement(DbtrAgt),validElement(DbtrAcct),validElement(Dbtr),validElement(InitgPty),validElement(UltmtDbtr))|

---

## Value ISO20022.Trck001001.CreditorReferenceInformation2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|String||XmlElement()||
|+|Tp|ISO20022.Trck001001.CreditorReferenceType2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Trck001001.CreditorReferenceType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.CreditorReferenceType2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Trck001001.CreditorReferenceType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Trck001001.CurrencyExchange13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnitCcy|String||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|TrgtCcy|String||XmlElement()||
|+|SrcCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""),validPattern("""TrgtCcy""",TrgtCcy,"""[A-Z]{3,3}"""),validPattern("""SrcCcy""",SrcCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Trck001001.CurrencyExchange15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UnitCcy|String||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|TrgtCcy|String||XmlElement()||
|+|SrcCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""),validPattern("""TrgtCcy""",TrgtCcy,"""[A-Z]{3,3}"""),validPattern("""SrcCcy""",SrcCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Trck001001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Trck001001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Trck001001.DatePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Trck001001.DiscountAmountAndType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Trck001001.DiscountAmountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Tp))|

---

## Value ISO20022.Trck001001.DiscountAmountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Type ISO20022.Trck001001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtStsTrckrUpd|ISO20022.Trck001001.PaymentStatusTrackerUpdateV04||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtStsTrckrUpd))|

---

## Value ISO20022.Trck001001.DocumentAdjustment1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rsn|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Trck001001.DocumentLineIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RltdDt|DateTime||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|ISO20022.Trck001001.DocumentLineType1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Trck001001.DocumentLineInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Trck001001.RemittanceAmount3||XmlElement()||
|+|Desc|String||XmlElement()||
|+|Id|global::System.Collections.Generic.List<ISO20022.Trck001001.DocumentLineIdentification1>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validRequired("""Id""",Id),validList("""Id""",Id),validElement(Id))|

---

## Value ISO20022.Trck001001.DocumentLineType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Trck001001.DocumentLineType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Trck001001.DocumentLineType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Trck001001.DocumentType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SCOR|Int32||XmlEnum("""SCOR""")|1|
||PUOR|Int32||XmlEnum("""PUOR""")|2|
||DISP|Int32||XmlEnum("""DISP""")|3|
||FXDR|Int32||XmlEnum("""FXDR""")|4|
||RPIN|Int32||XmlEnum("""RPIN""")|5|
||RADM|Int32||XmlEnum("""RADM""")|6|

---

## Enum ISO20022.Trck001001.DocumentType6Code


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

## Value ISO20022.Trck001001.EquivalentAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyOfTrf|String||XmlElement()||
|+|Amt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CcyOfTrf""",CcyOfTrf,"""[A-Z]{3,3}"""),validElement(Amt))|

---

## Value ISO20022.Trck001001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.FinancialInstitutionIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Trck001001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Trck001001.PostalAddress24||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Trck001001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Trck001001.FinancialInstitutionIdentification21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Trck001001.GenericFinancialIdentification1||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Trck001001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Trck001001.Garnishment3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MplyeeTermntnInd|String||XmlElement()||
|+|FmlyMdclInsrncInd|String||XmlElement()||
|+|RmtdAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|GrnshmtAdmstr|ISO20022.Trck001001.PartyIdentification135||XmlElement()||
|+|Grnshee|ISO20022.Trck001001.PartyIdentification135||XmlElement()||
|+|Tp|ISO20022.Trck001001.GarnishmentType1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RmtdAmt),validElement(GrnshmtAdmstr),validElement(Grnshee),validElement(Tp))|

---

## Value ISO20022.Trck001001.GarnishmentType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Trck001001.GarnishmentType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Trck001001.GarnishmentType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Trck001001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Trck001001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Trck001001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Trck001001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Trck001001.GenericOrganisationIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Trck001001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Trck001001.GenericPersonIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Trck001001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Enum ISO20022.Trck001001.Instruction4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TELA|Int32||XmlEnum("""TELA""")|1|
||PHOA|Int32||XmlEnum("""PHOA""")|2|

---

## Value ISO20022.Trck001001.InstructionForCreditorAgent3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrInf|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Trck001001.InstructionForNextAgent1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrInf|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Trck001001.LocalInstrument2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.NameAndAddress16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Trck001001.PostalAddress24||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Trck001001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Trck001001.OrganisationIdentification29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Trck001001.GenericOrganisationIdentification1>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Trck001001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.OriginalBusinessInstruction4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgNmId|String||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Trck001001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Trck001001.Party38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Trck001001.PersonIdentification13||XmlElement()||
|+|OrgId|ISO20022.Trck001001.OrganisationIdentification29||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Trck001001.Party40Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Agt|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|Pty|ISO20022.Trck001001.PartyIdentification135||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Agt),validElement(Pty),validChoice(Agt,Pty))|

---

## Value ISO20022.Trck001001.PartyIdentification135


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Trck001001.Contact4||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Trck001001.Party38Choice||XmlElement()||
|+|PstlAdr|ISO20022.Trck001001.PostalAddress24||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Trck001001.PaymentIdentification10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClrSysRef|String||XmlElement()||
|+|UETR|String||XmlElement()||
|+|TxId|String||XmlElement()||
|+|EndToEndId|String||XmlElement()||
|+|InstrId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""UETR""",UETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""))|

---

## Value ISO20022.Trck001001.PaymentRejectReturnReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Rsn|ISO20022.Trck001001.ReturnReason5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Trck001001.PaymentScenario1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.PaymentStatusReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Rsn|ISO20022.Trck001001.StatusReason6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Aspect ISO20022.Trck001001.PaymentStatusTrackerUpdateV04


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Trck001001.SupplementaryData1>||XmlElement()||
|+|TrckrStsAndTx|global::System.Collections.Generic.List<ISO20022.Trck001001.TrackerStatusAndTransaction19>||XmlElement()||
|+|GrpHdr|ISO20022.Trck001001.TrackerHeader6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validRequired("""TrckrStsAndTx""",TrckrStsAndTx),validList("""TrckrStsAndTx""",TrckrStsAndTx),validElement(TrckrStsAndTx),validElement(GrpHdr))|

---

## Value ISO20022.Trck001001.PaymentTypeInformation28


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtgyPurp|ISO20022.Trck001001.CategoryPurpose1Choice||XmlElement()||
|+|LclInstrm|ISO20022.Trck001001.LocalInstrument2Choice||XmlElement()||
|+|SvcLvl|global::System.Collections.Generic.List<ISO20022.Trck001001.ServiceLevel8Choice>||XmlElement()||
|+|ClrChanl|String||XmlElement()||
|+|InstrPrty|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtgyPurp),validElement(LclInstrm),validList("""SvcLvl""",SvcLvl),validElement(SvcLvl))|

---

## Value ISO20022.Trck001001.PersonIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Trck001001.GenericPersonIdentification1>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Trck001001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Trck001001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.PostalAddress24


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
|+|AdrTp|ISO20022.Trck001001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Trck001001.PreferredContactMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CELL|Int32||XmlEnum("""CELL""")|1|
||FAXX|Int32||XmlEnum("""FAXX""")|2|
||PHON|Int32||XmlEnum("""PHON""")|3|
||MAIL|Int32||XmlEnum("""MAIL""")|4|
||LETT|Int32||XmlEnum("""LETT""")|5|

---

## Enum ISO20022.Trck001001.Priority2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORM|Int32||XmlEnum("""NORM""")|1|
||HIGH|Int32||XmlEnum("""HIGH""")|2|

---

## Enum ISO20022.Trck001001.Priority3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORM|Int32||XmlEnum("""NORM""")|1|
||HIGH|Int32||XmlEnum("""HIGH""")|2|
||URGT|Int32||XmlEnum("""URGT""")|3|

---

## Value ISO20022.Trck001001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Trck001001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Trck001001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.Purpose2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.ReferredDocumentInformation7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LineDtls|global::System.Collections.Generic.List<ISO20022.Trck001001.DocumentLineInformation1>||XmlElement()||
|+|RltdDt|DateTime||XmlElement()||
|+|Nb|String||XmlElement()||
|+|Tp|ISO20022.Trck001001.ReferredDocumentType4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""LineDtls""",LineDtls),validElement(LineDtls),validElement(Tp))|

---

## Value ISO20022.Trck001001.ReferredDocumentType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.ReferredDocumentType4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|CdOrPrtry|ISO20022.Trck001001.ReferredDocumentType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdOrPrtry))|

---

## Value ISO20022.Trck001001.RegulatoryAuthority2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Trck001001.RegulatoryReporting3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|global::System.Collections.Generic.List<ISO20022.Trck001001.StructuredRegulatoryReporting3>||XmlElement()||
|+|Authrty|ISO20022.Trck001001.RegulatoryAuthority2||XmlElement()||
|+|DbtCdtRptgInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dtls""",Dtls),validElement(Dtls),validElement(Authrty))|

---

## Enum ISO20022.Trck001001.RegulatoryReportingType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOTH|Int32||XmlEnum("""BOTH""")|1|
||DEBT|Int32||XmlEnum("""DEBT""")|2|
||CRED|Int32||XmlEnum("""CRED""")|3|

---

## Value ISO20022.Trck001001.RelatedTransactionData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubUETR|global::System.Collections.Generic.List<String>||XmlElement()||
|+|MstrUETR|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SubUETR""",SubUETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""),validPattern("""MstrUETR""",MstrUETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""))|

---

## Value ISO20022.Trck001001.RemittanceAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RmtdAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|AdjstmntAmtAndRsn|global::System.Collections.Generic.List<ISO20022.Trck001001.DocumentAdjustment1>||XmlElement()||
|+|TaxAmt|global::System.Collections.Generic.List<ISO20022.Trck001001.TaxAmountAndType1>||XmlElement()||
|+|CdtNoteAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|DscntApldAmt|global::System.Collections.Generic.List<ISO20022.Trck001001.DiscountAmountAndType1>||XmlElement()||
|+|DuePyblAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RmtdAmt),validList("""AdjstmntAmtAndRsn""",AdjstmntAmtAndRsn),validElement(AdjstmntAmtAndRsn),validList("""TaxAmt""",TaxAmt),validElement(TaxAmt),validElement(CdtNoteAmt),validList("""DscntApldAmt""",DscntApldAmt),validElement(DscntApldAmt),validElement(DuePyblAmt))|

---

## Value ISO20022.Trck001001.RemittanceAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RmtdAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|AdjstmntAmtAndRsn|global::System.Collections.Generic.List<ISO20022.Trck001001.DocumentAdjustment1>||XmlElement()||
|+|TaxAmt|global::System.Collections.Generic.List<ISO20022.Trck001001.TaxAmountAndType1>||XmlElement()||
|+|CdtNoteAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|DscntApldAmt|global::System.Collections.Generic.List<ISO20022.Trck001001.DiscountAmountAndType1>||XmlElement()||
|+|DuePyblAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RmtdAmt),validList("""AdjstmntAmtAndRsn""",AdjstmntAmtAndRsn),validElement(AdjstmntAmtAndRsn),validList("""TaxAmt""",TaxAmt),validElement(TaxAmt),validElement(CdtNoteAmt),validList("""DscntApldAmt""",DscntApldAmt),validElement(DscntApldAmt),validElement(DuePyblAmt))|

---

## Value ISO20022.Trck001001.RemittanceInformation16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Strd|global::System.Collections.Generic.List<ISO20022.Trck001001.StructuredRemittanceInformation16>||XmlElement()||
|+|Ustrd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Strd""",Strd),validElement(Strd))|

---

## Value ISO20022.Trck001001.RemittanceLocation7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RmtLctnDtls|global::System.Collections.Generic.List<ISO20022.Trck001001.RemittanceLocationData1>||XmlElement()||
|+|RmtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RmtLctnDtls""",RmtLctnDtls),validElement(RmtLctnDtls))|

---

## Value ISO20022.Trck001001.RemittanceLocationData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Trck001001.NameAndAddress16||XmlElement()||
|+|ElctrncAdr|String||XmlElement()||
|+|Mtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr))|

---

## Enum ISO20022.Trck001001.RemittanceLocationMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SMSM|Int32||XmlEnum("""SMSM""")|1|
||POST|Int32||XmlEnum("""POST""")|2|
||EMAL|Int32||XmlEnum("""EMAL""")|3|
||URID|Int32||XmlEnum("""URID""")|4|
||EDIC|Int32||XmlEnum("""EDIC""")|5|
||FAXI|Int32||XmlEnum("""FAXI""")|6|

---

## Value ISO20022.Trck001001.ReturnReason5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.ServiceLevel8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.SettlementDateTimeIndication1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDtTm|DateTime||XmlElement()||
|+|DbtDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Trck001001.SettlementInstruction9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ThrdRmbrsmntAgtAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|ThrdRmbrsmntAgt|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|InstdRmbrsmntAgtAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|InstdRmbrsmntAgt|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|InstgRmbrsmntAgtAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|InstgRmbrsmntAgt|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|ClrSys|ISO20022.Trck001001.ClearingSystemIdentification3Choice||XmlElement()||
|+|SttlmAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|SttlmMtd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ThrdRmbrsmntAgtAcct),validElement(ThrdRmbrsmntAgt),validElement(InstdRmbrsmntAgtAcct),validElement(InstdRmbrsmntAgt),validElement(InstgRmbrsmntAgtAcct),validElement(InstgRmbrsmntAgt),validElement(ClrSys),validElement(SttlmAcct))|

---

## Enum ISO20022.Trck001001.SettlementMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CLRG|Int32||XmlEnum("""CLRG""")|1|
||COVE|Int32||XmlEnum("""COVE""")|2|
||INGA|Int32||XmlEnum("""INGA""")|3|
||INDA|Int32||XmlEnum("""INDA""")|4|

---

## Value ISO20022.Trck001001.SettlementTimeRequest2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RjctTm|DateTime||XmlElement()||
|+|FrTm|DateTime||XmlElement()||
|+|TillTm|DateTime||XmlElement()||
|+|CLSTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Trck001001.StatusReason6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.StructuredRegulatoryReporting3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Inf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Amt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Cd|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Trck001001.StructuredRemittanceInformation16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRmtInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|GrnshmtRmt|ISO20022.Trck001001.Garnishment3||XmlElement()||
|+|TaxRmt|ISO20022.Trck001001.TaxInformation7||XmlElement()||
|+|Invcee|ISO20022.Trck001001.PartyIdentification135||XmlElement()||
|+|Invcr|ISO20022.Trck001001.PartyIdentification135||XmlElement()||
|+|CdtrRefInf|ISO20022.Trck001001.CreditorReferenceInformation2||XmlElement()||
|+|RfrdDocAmt|ISO20022.Trck001001.RemittanceAmount2||XmlElement()||
|+|RfrdDocInf|global::System.Collections.Generic.List<ISO20022.Trck001001.ReferredDocumentInformation7>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AddtlRmtInf""",AddtlRmtInf,3),validElement(GrnshmtRmt),validElement(TaxRmt),validElement(Invcee),validElement(Invcr),validElement(CdtrRefInf),validElement(RfrdDocAmt),validList("""RfrdDocInf""",RfrdDocInf),validElement(RfrdDocInf))|

---

## Value ISO20022.Trck001001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Trck001001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Trck001001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Trck001001.TaxAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dtls|global::System.Collections.Generic.List<ISO20022.Trck001001.TaxRecordDetails2>||XmlElement()||
|+|TtlAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TaxblBaseAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Dtls""",Dtls),validElement(Dtls),validElement(TtlAmt),validElement(TaxblBaseAmt))|

---

## Value ISO20022.Trck001001.TaxAmountAndType1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Tp|ISO20022.Trck001001.TaxAmountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Tp))|

---

## Value ISO20022.Trck001001.TaxAmountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Trck001001.TaxAuthorisation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Titl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Trck001001.TaxInformation7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rcrd|global::System.Collections.Generic.List<ISO20022.Trck001001.TaxRecord2>||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|TtlTaxAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlTaxblBaseAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Mtd|String||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|AdmstnZone|String||XmlElement()||
|+|UltmtDbtr|ISO20022.Trck001001.TaxParty2||XmlElement()||
|+|Dbtr|ISO20022.Trck001001.TaxParty2||XmlElement()||
|+|Cdtr|ISO20022.Trck001001.TaxParty1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rcrd""",Rcrd),validElement(Rcrd),validElement(TtlTaxAmt),validElement(TtlTaxblBaseAmt),validElement(UltmtDbtr),validElement(Dbtr),validElement(Cdtr))|

---

## Value ISO20022.Trck001001.TaxInformation8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rcrd|global::System.Collections.Generic.List<ISO20022.Trck001001.TaxRecord2>||XmlElement()||
|+|SeqNb|Decimal||XmlElement()||
|+|Dt|DateTime||XmlElement()||
|+|TtlTaxAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlTaxblBaseAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Mtd|String||XmlElement()||
|+|RefNb|String||XmlElement()||
|+|AdmstnZone|String||XmlElement()||
|+|Dbtr|ISO20022.Trck001001.TaxParty2||XmlElement()||
|+|Cdtr|ISO20022.Trck001001.TaxParty1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rcrd""",Rcrd),validElement(Rcrd),validElement(TtlTaxAmt),validElement(TtlTaxblBaseAmt),validElement(Dbtr),validElement(Cdtr))|

---

## Value ISO20022.Trck001001.TaxParty1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxTp|String||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|TaxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Trck001001.TaxParty2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Authstn|ISO20022.Trck001001.TaxAuthorisation1||XmlElement()||
|+|TaxTp|String||XmlElement()||
|+|RegnId|String||XmlElement()||
|+|TaxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Authstn))|

---

## Value ISO20022.Trck001001.TaxPeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrToDt|ISO20022.Trck001001.DatePeriod2||XmlElement()||
|+|Tp|String||XmlElement()||
|+|Yr|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToDt))|

---

## Value ISO20022.Trck001001.TaxRecord2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|TaxAmt|ISO20022.Trck001001.TaxAmount2||XmlElement()||
|+|Prd|ISO20022.Trck001001.TaxPeriod2||XmlElement()||
|+|FrmsCd|String||XmlElement()||
|+|CertId|String||XmlElement()||
|+|DbtrSts|String||XmlElement()||
|+|CtgyDtls|String||XmlElement()||
|+|Ctgy|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TaxAmt),validElement(Prd))|

---

## Value ISO20022.Trck001001.TaxRecordDetails2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Prd|ISO20022.Trck001001.TaxPeriod2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(Prd))|

---

## Enum ISO20022.Trck001001.TaxRecordPeriod1Code


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

## Value ISO20022.Trck001001.TrackerData8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrevslyConfdDt|ISO20022.Trck001001.DateAndDateTime2Choice||XmlElement()||
|+|PrevslyConfdAmt|ISO20022.Trck001001.ActiveCurrencyAndAmount||XmlElement()||
|+|RmngToBeConfdAmt|ISO20022.Trck001001.ActiveCurrencyAndAmount||XmlElement()||
|+|RtrdConfdAmt|ISO20022.Trck001001.ActiveCurrencyAndAmount||XmlElement()||
|+|RtrdConfdDt|ISO20022.Trck001001.DateAndDateTime2Choice||XmlElement()||
|+|ConfdAmt|ISO20022.Trck001001.ActiveCurrencyAndAmount||XmlElement()||
|+|ConfdDt|ISO20022.Trck001001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrevslyConfdDt),validElement(PrevslyConfdAmt),validElement(RmngToBeConfdAmt),validElement(RtrdConfdAmt),validElement(RtrdConfdDt),validElement(ConfdAmt),validElement(ConfdDt))|

---

## Value ISO20022.Trck001001.TrackerHeader6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SvcLvl|ISO20022.Trck001001.ServiceLevel8Choice||XmlElement()||
|+|TrckrInfrmdPty|ISO20022.Trck001001.TrackerPartyIdentification2||XmlElement()||
|+|TrckrInfrmgPty|ISO20022.Trck001001.TrackerPartyIdentification2||XmlElement()||
|+|NbOfTxs|String||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SvcLvl),validElement(TrckrInfrmdPty),validElement(TrckrInfrmgPty),validPattern("""NbOfTxs""",NbOfTxs,"""[0-9]{1,15}"""))|

---

## Value ISO20022.Trck001001.TrackerParty2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstnId|ISO20022.Trck001001.FinancialInstitutionIdentification21||XmlElement()||
|+|PrvtId|ISO20022.Trck001001.PersonIdentification13||XmlElement()||
|+|OrgId|ISO20022.Trck001001.OrganisationIdentification29||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstnId),validElement(PrvtId),validElement(OrgId),validChoice(FinInstnId,PrvtId,OrgId))|

---

## Value ISO20022.Trck001001.TrackerPartyIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|ISO20022.Trck001001.TrackerParty2Choice||XmlElement()||
|+|PstlAdr|ISO20022.Trck001001.PostalAddress24||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Trck001001.TrackerPaymentTransaction14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UndrlygCstmrCdtTrf|ISO20022.Trck001001.CreditTransferTransaction46||XmlElement()||
|+|RtrChain|ISO20022.Trck001001.TransactionParties8||XmlElement()||
|+|RjctRtrRsn|global::System.Collections.Generic.List<ISO20022.Trck001001.PaymentRejectReturnReason1>||XmlElement()||
|+|RmtInf|ISO20022.Trck001001.RemittanceInformation16||XmlElement()||
|+|RltdRmtInf|global::System.Collections.Generic.List<ISO20022.Trck001001.RemittanceLocation7>||XmlElement()||
|+|Tax|ISO20022.Trck001001.TaxInformation8||XmlElement()||
|+|RgltryRptg|global::System.Collections.Generic.List<ISO20022.Trck001001.RegulatoryReporting3>||XmlElement()||
|+|Purp|ISO20022.Trck001001.Purpose2Choice||XmlElement()||
|+|InstrForNxtAgt|global::System.Collections.Generic.List<ISO20022.Trck001001.InstructionForNextAgent1>||XmlElement()||
|+|InstrForCdtrAgt|global::System.Collections.Generic.List<ISO20022.Trck001001.InstructionForCreditorAgent3>||XmlElement()||
|+|UltmtCdtr|ISO20022.Trck001001.PartyIdentification135||XmlElement()||
|+|CdtrAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|Cdtr|ISO20022.Trck001001.Party40Choice||XmlElement()||
|+|CdtrAgtAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|CdtrAgt|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|DbtrAgtAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|DbtrAgt|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|DbtrAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|Dbtr|ISO20022.Trck001001.Party40Choice||XmlElement()||
|+|InitgPty|ISO20022.Trck001001.PartyIdentification135||XmlElement()||
|+|UltmtDbtr|ISO20022.Trck001001.PartyIdentification135||XmlElement()||
|+|IntrmyAgt3Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|IntrmyAgt3|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|IntrmyAgt2Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|IntrmyAgt2|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|IntrmyAgt1Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|IntrmyAgt1|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|PrvsInstgAgt3Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|PrvsInstgAgt3|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|PrvsInstgAgt2Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|PrvsInstgAgt2|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|PrvsInstgAgt1Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|PrvsInstgAgt1|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|DbtConfURLAdr|String||XmlElement()||
|+|TrckrData|ISO20022.Trck001001.TrackerData8||XmlElement()||
|+|TrckrRcrd|global::System.Collections.Generic.List<ISO20022.Trck001001.TrackerRecord8>||XmlElement()||
|+|ChrgsInf|global::System.Collections.Generic.List<ISO20022.Trck001001.Charges7>||XmlElement()||
|+|ChrgBr|String||XmlElement()||
|+|XchgRateData|ISO20022.Trck001001.CurrencyExchange15||XmlElement()||
|+|RtrdInstdAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|EqvtAmt|ISO20022.Trck001001.EquivalentAmount2||XmlElement()||
|+|InstdAmt|ISO20022.Trck001001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|PoolgAdjstmntDt|DateTime||XmlElement()||
|+|AccptncDtTm|DateTime||XmlElement()||
|+|SttlmTmReq|ISO20022.Trck001001.SettlementTimeRequest2||XmlElement()||
|+|SttlmTmIndctn|ISO20022.Trck001001.SettlementDateTimeIndication1||XmlElement()||
|+|SttlmPrty|String||XmlElement()||
|+|ReqdExctnDt|ISO20022.Trck001001.DateAndDateTime2Choice||XmlElement()||
|+|IntrBkSttlmDt|DateTime||XmlElement()||
|+|RtrdIntrBkSttlmAmt|ISO20022.Trck001001.ActiveCurrencyAndAmount||XmlElement()||
|+|IntrBkSttlmAmt|ISO20022.Trck001001.ActiveCurrencyAndAmount||XmlElement()||
|+|InstdAgt|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|InstgAgt|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|SttlmInf|ISO20022.Trck001001.SettlementInstruction9||XmlElement()||
|+|PmtScnro|ISO20022.Trck001001.PaymentScenario1Choice||XmlElement()||
|+|PmtTpInf|ISO20022.Trck001001.PaymentTypeInformation28||XmlElement()||
|+|OrgnlEndToEndId|String||XmlElement()||
|+|OrgnlInstrId|String||XmlElement()||
|+|RltdPmtId|ISO20022.Trck001001.RelatedTransactionData1||XmlElement()||
|+|PmtId|ISO20022.Trck001001.PaymentIdentification10||XmlElement()||
|+|TechRcvr|String||XmlElement()||
|+|TechSndr|String||XmlElement()||
|+|TrckrInfrmdPty|ISO20022.Trck001001.TrackerPartyIdentification2||XmlElement()||
|+|TrckrInfrmgPty|ISO20022.Trck001001.TrackerPartyIdentification2||XmlElement()||
|+|TrckdMsgId|ISO20022.Trck001001.OriginalBusinessInstruction4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UndrlygCstmrCdtTrf),validElement(RtrChain),validList("""RjctRtrRsn""",RjctRtrRsn),validElement(RjctRtrRsn),validElement(RmtInf),validList("""RltdRmtInf""",RltdRmtInf),validListMax("""RltdRmtInf""",RltdRmtInf,10),validElement(RltdRmtInf),validElement(Tax),validList("""RgltryRptg""",RgltryRptg),validListMax("""RgltryRptg""",RgltryRptg,10),validElement(RgltryRptg),validElement(Purp),validList("""InstrForNxtAgt""",InstrForNxtAgt),validElement(InstrForNxtAgt),validList("""InstrForCdtrAgt""",InstrForCdtrAgt),validElement(InstrForCdtrAgt),validElement(UltmtCdtr),validElement(CdtrAcct),validElement(Cdtr),validElement(CdtrAgtAcct),validElement(CdtrAgt),validElement(DbtrAgtAcct),validElement(DbtrAgt),validElement(DbtrAcct),validElement(Dbtr),validElement(InitgPty),validElement(UltmtDbtr),validElement(IntrmyAgt3Acct),validElement(IntrmyAgt3),validElement(IntrmyAgt2Acct),validElement(IntrmyAgt2),validElement(IntrmyAgt1Acct),validElement(IntrmyAgt1),validElement(PrvsInstgAgt3Acct),validElement(PrvsInstgAgt3),validElement(PrvsInstgAgt2Acct),validElement(PrvsInstgAgt2),validElement(PrvsInstgAgt1Acct),validElement(PrvsInstgAgt1),validElement(TrckrData),validList("""TrckrRcrd""",TrckrRcrd),validElement(TrckrRcrd),validList("""ChrgsInf""",ChrgsInf),validElement(ChrgsInf),validElement(XchgRateData),validElement(RtrdInstdAmt),validElement(EqvtAmt),validElement(InstdAmt),validElement(SttlmTmReq),validElement(SttlmTmIndctn),validElement(ReqdExctnDt),validElement(RtrdIntrBkSttlmAmt),validElement(IntrBkSttlmAmt),validElement(InstdAgt),validElement(InstgAgt),validElement(SttlmInf),validElement(PmtScnro),validElement(PmtTpInf),validElement(RltdPmtId),validElement(PmtId),validPattern("""TechRcvr""",TechRcvr,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validPattern("""TechSndr""",TechSndr,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validElement(TrckrInfrmdPty),validElement(TrckrInfrmgPty),validElement(TrckdMsgId))|

---

## Value ISO20022.Trck001001.TrackerRecord8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgDtTm|DateTime||XmlElement()||
|+|XchgRateData|ISO20022.Trck001001.CurrencyExchange13||XmlElement()||
|+|ChrgsAmt|ISO20022.Trck001001.ActiveCurrencyAndAmount||XmlElement()||
|+|ChrgBr|String||XmlElement()||
|+|IntrBkSttlmAmt|ISO20022.Trck001001.ActiveCurrencyAndAmount||XmlElement()||
|+|PtyOrAgtId|ISO20022.Trck001001.TrackerPartyIdentification2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(XchgRateData),validElement(ChrgsAmt),validElement(IntrBkSttlmAmt),validElement(PtyOrAgtId))|

---

## Value ISO20022.Trck001001.TrackerStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RjctRtrRsn|global::System.Collections.Generic.List<ISO20022.Trck001001.PaymentRejectReturnReason1>||XmlElement()||
|+|StsRsn|global::System.Collections.Generic.List<ISO20022.Trck001001.PaymentStatusReason1>||XmlElement()||
|+|Dt|ISO20022.Trck001001.DateAndDateTime2Choice||XmlElement()||
|+|Sts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""RjctRtrRsn""",RjctRtrRsn),validElement(RjctRtrRsn),validList("""StsRsn""",StsRsn),validElement(StsRsn),validElement(Dt))|

---

## Value ISO20022.Trck001001.TrackerStatusAndTransaction19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|global::System.Collections.Generic.List<ISO20022.Trck001001.TrackerPaymentTransaction14>||XmlElement()||
|+|TxSts|ISO20022.Trck001001.TrackerStatus1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Tx""",Tx),validList("""Tx""",Tx),validElement(Tx),validElement(TxSts))|

---

## Value ISO20022.Trck001001.TransactionParties8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UltmtCdtr|ISO20022.Trck001001.Party40Choice||XmlElement()||
|+|CdtrAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|Cdtr|ISO20022.Trck001001.Party40Choice||XmlElement()||
|+|CdtrAgtAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|CdtrAgt|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|IntrmyAgt3Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|IntrmyAgt3|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|IntrmyAgt2Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|IntrmyAgt2|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|IntrmyAgt1Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|IntrmyAgt1|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|PrvsInstgAgt3Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|PrvsInstgAgt3|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|PrvsInstgAgt2Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|PrvsInstgAgt2|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|PrvsInstgAgt1Acct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|PrvsInstgAgt1|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|DbtrAgtAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|DbtrAgt|ISO20022.Trck001001.BranchAndFinancialInstitutionIdentification6||XmlElement()||
|+|InitgPty|ISO20022.Trck001001.Party40Choice||XmlElement()||
|+|DbtrAcct|ISO20022.Trck001001.CashAccount38||XmlElement()||
|+|Dbtr|ISO20022.Trck001001.Party40Choice||XmlElement()||
|+|UltmtDbtr|ISO20022.Trck001001.Party40Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UltmtCdtr),validElement(CdtrAcct),validElement(Cdtr),validElement(CdtrAgtAcct),validElement(CdtrAgt),validElement(IntrmyAgt3Acct),validElement(IntrmyAgt3),validElement(IntrmyAgt2Acct),validElement(IntrmyAgt2),validElement(IntrmyAgt1Acct),validElement(IntrmyAgt1),validElement(PrvsInstgAgt3Acct),validElement(PrvsInstgAgt3),validElement(PrvsInstgAgt2Acct),validElement(PrvsInstgAgt2),validElement(PrvsInstgAgt1Acct),validElement(PrvsInstgAgt1),validElement(DbtrAgtAcct),validElement(DbtrAgt),validElement(InitgPty),validElement(DbtrAcct),validElement(Dbtr),validElement(UltmtDbtr))|

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

