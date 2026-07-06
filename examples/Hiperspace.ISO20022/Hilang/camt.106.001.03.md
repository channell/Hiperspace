# camt.106.001.03
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt106001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt106001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt106001.AccountIdentification4Choice *-- ISO20022.Camt106001.GenericAccountIdentification1
    class ISO20022.Camt106001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt106001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt106001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt106001.AddressType3Choice {
        + Prtry  : ISO20022.Camt106001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt106001.AddressType3Choice *-- ISO20022.Camt106001.GenericIdentification30
    class ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Camt106001.BranchData5
        + FinInstnId  : ISO20022.Camt106001.FinancialInstitutionIdentification23
    }
    ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt106001.BranchData5
    ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt106001.FinancialInstitutionIdentification23
    class ISO20022.Camt106001.BranchData5 {
        + PstlAdr  : ISO20022.Camt106001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt106001.BranchData5 *-- ISO20022.Camt106001.PostalAddress27
    class ISO20022.Camt106001.CashAccount40 {
        + Prxy  : ISO20022.Camt106001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Camt106001.CashAccountType2Choice
        + Id  : ISO20022.Camt106001.AccountIdentification4Choice
    }
    ISO20022.Camt106001.CashAccount40 *-- ISO20022.Camt106001.ProxyAccountIdentification1
    ISO20022.Camt106001.CashAccount40 *-- ISO20022.Camt106001.CashAccountType2Choice
    ISO20022.Camt106001.CashAccount40 *-- ISO20022.Camt106001.AccountIdentification4Choice
    class ISO20022.Camt106001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt106001.ChargeType3Choice {
        + Prtry  : ISO20022.Camt106001.GenericIdentification3
        + Cd  : String
    }
    ISO20022.Camt106001.ChargeType3Choice *-- ISO20022.Camt106001.GenericIdentification3
    class ISO20022.Camt106001.Charges6Choice {
        + PerTp  : global::System.Collections.Generic.List~ISO20022.Camt106001.ChargesPerType6~
        + PerTx  : ISO20022.Camt106001.ChargesPerTransaction6
        + Sngl  : ISO20022.Camt106001.ChargesRecord12
    }
    ISO20022.Camt106001.Charges6Choice *-- ISO20022.Camt106001.ChargesPerType6
    ISO20022.Camt106001.Charges6Choice *-- ISO20022.Camt106001.ChargesPerTransaction6
    ISO20022.Camt106001.Charges6Choice *-- ISO20022.Camt106001.ChargesRecord12
    class ISO20022.Camt106001.ChargesBreakdown1 {
        + Tp  : ISO20022.Camt106001.ChargeType3Choice
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt106001.ActiveCurrencyAndAmount
    }
    ISO20022.Camt106001.ChargesBreakdown1 *-- ISO20022.Camt106001.ChargeType3Choice
    ISO20022.Camt106001.ChargesBreakdown1 *-- ISO20022.Camt106001.ActiveCurrencyAndAmount
    class ISO20022.Camt106001.ChargesPaymentRequestV03 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt106001.SupplementaryData1~
        + Chrgs  : ISO20022.Camt106001.Charges6Choice
        + GrpHdr  : ISO20022.Camt106001.GroupHeader130
    }
    ISO20022.Camt106001.ChargesPaymentRequestV03 *-- ISO20022.Camt106001.SupplementaryData1
    ISO20022.Camt106001.ChargesPaymentRequestV03 *-- ISO20022.Camt106001.Charges6Choice
    ISO20022.Camt106001.ChargesPaymentRequestV03 *-- ISO20022.Camt106001.GroupHeader130
    class ISO20022.Camt106001.ChargesPerTransaction6 {
        + AddtlInf  : String
        + Rcrd  : global::System.Collections.Generic.List~ISO20022.Camt106001.ChargesPerTransactionRecord6~
        + ChrgsAcctAgtAcct  : ISO20022.Camt106001.CashAccount40
        + ChrgsAcctAgt  : ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
        + TtlChrgsPerTx  : ISO20022.Camt106001.TotalCharges7
        + ChrgsId  : String
    }
    ISO20022.Camt106001.ChargesPerTransaction6 *-- ISO20022.Camt106001.ChargesPerTransactionRecord6
    ISO20022.Camt106001.ChargesPerTransaction6 *-- ISO20022.Camt106001.CashAccount40
    ISO20022.Camt106001.ChargesPerTransaction6 *-- ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt106001.ChargesPerTransaction6 *-- ISO20022.Camt106001.TotalCharges7
    class ISO20022.Camt106001.ChargesPerTransactionRecord6 {
        + AddtlInf  : String
        + InstrForInstdAgt  : ISO20022.Camt106001.InstructionForInstructedAgent1
        + ChrgsAcctAgtAcct  : ISO20022.Camt106001.CashAccount40
        + ChrgsAcctAgt  : ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
        + DbtrAgtAcct  : ISO20022.Camt106001.CashAccount40
        + DbtrAgt  : ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
        + DbtrAcct  : ISO20022.Camt106001.CashAccount40
        + Dbtr  : ISO20022.Camt106001.PartyIdentification272
        + ValDt  : ISO20022.Camt106001.DateAndDateTime2Choice
        + ChrgsBrkdwn  : global::System.Collections.Generic.List~ISO20022.Camt106001.ChargesBreakdown1~
        + TtlChrgsPerRcrd  : ISO20022.Camt106001.TotalCharges8
        + UndrlygTx  : ISO20022.Camt106001.TransactionReferences7
        + SttlmInstr  : ISO20022.Camt106001.SettlementInstruction19
        + ChrgsRqstr  : ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
        + RcrdId  : String
    }
    ISO20022.Camt106001.ChargesPerTransactionRecord6 *-- ISO20022.Camt106001.InstructionForInstructedAgent1
    ISO20022.Camt106001.ChargesPerTransactionRecord6 *-- ISO20022.Camt106001.CashAccount40
    ISO20022.Camt106001.ChargesPerTransactionRecord6 *-- ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt106001.ChargesPerTransactionRecord6 *-- ISO20022.Camt106001.CashAccount40
    ISO20022.Camt106001.ChargesPerTransactionRecord6 *-- ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt106001.ChargesPerTransactionRecord6 *-- ISO20022.Camt106001.CashAccount40
    ISO20022.Camt106001.ChargesPerTransactionRecord6 *-- ISO20022.Camt106001.PartyIdentification272
    ISO20022.Camt106001.ChargesPerTransactionRecord6 *-- ISO20022.Camt106001.DateAndDateTime2Choice
    ISO20022.Camt106001.ChargesPerTransactionRecord6 *-- ISO20022.Camt106001.ChargesBreakdown1
    ISO20022.Camt106001.ChargesPerTransactionRecord6 *-- ISO20022.Camt106001.TotalCharges8
    ISO20022.Camt106001.ChargesPerTransactionRecord6 *-- ISO20022.Camt106001.TransactionReferences7
    ISO20022.Camt106001.ChargesPerTransactionRecord6 *-- ISO20022.Camt106001.SettlementInstruction19
    ISO20022.Camt106001.ChargesPerTransactionRecord6 *-- ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
    class ISO20022.Camt106001.ChargesPerType6 {
        + AddtlInf  : String
        + Rcrd  : global::System.Collections.Generic.List~ISO20022.Camt106001.ChargesPerTypeRecord6~
        + Tp  : ISO20022.Camt106001.ChargeType3Choice
        + ChrgsAcctAgtAcct  : ISO20022.Camt106001.CashAccount40
        + ChrgsAcctAgt  : ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
        + TtlChrgsPerChrgTp  : ISO20022.Camt106001.TotalCharges7
        + ChrgsId  : String
    }
    ISO20022.Camt106001.ChargesPerType6 *-- ISO20022.Camt106001.ChargesPerTypeRecord6
    ISO20022.Camt106001.ChargesPerType6 *-- ISO20022.Camt106001.ChargeType3Choice
    ISO20022.Camt106001.ChargesPerType6 *-- ISO20022.Camt106001.CashAccount40
    ISO20022.Camt106001.ChargesPerType6 *-- ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt106001.ChargesPerType6 *-- ISO20022.Camt106001.TotalCharges7
    class ISO20022.Camt106001.ChargesPerTypeRecord6 {
        + AddtlInf  : String
        + InstrForInstdAgt  : ISO20022.Camt106001.InstructionForInstructedAgent1
        + ChrgsAcctAgtAcct  : ISO20022.Camt106001.CashAccount40
        + ChrgsAcctAgt  : ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
        + DbtrAgtAcct  : ISO20022.Camt106001.CashAccount40
        + DbtrAgt  : ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
        + DbtrAcct  : ISO20022.Camt106001.CashAccount40
        + Dbtr  : ISO20022.Camt106001.PartyIdentification272
        + ValDt  : ISO20022.Camt106001.DateAndDateTime2Choice
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt106001.ActiveCurrencyAndAmount
        + UndrlygTx  : ISO20022.Camt106001.TransactionReferences7
        + SttlmInstr  : ISO20022.Camt106001.SettlementInstruction19
        + ChrgsRqstr  : ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
        + RcrdId  : String
    }
    ISO20022.Camt106001.ChargesPerTypeRecord6 *-- ISO20022.Camt106001.InstructionForInstructedAgent1
    ISO20022.Camt106001.ChargesPerTypeRecord6 *-- ISO20022.Camt106001.CashAccount40
    ISO20022.Camt106001.ChargesPerTypeRecord6 *-- ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt106001.ChargesPerTypeRecord6 *-- ISO20022.Camt106001.CashAccount40
    ISO20022.Camt106001.ChargesPerTypeRecord6 *-- ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt106001.ChargesPerTypeRecord6 *-- ISO20022.Camt106001.CashAccount40
    ISO20022.Camt106001.ChargesPerTypeRecord6 *-- ISO20022.Camt106001.PartyIdentification272
    ISO20022.Camt106001.ChargesPerTypeRecord6 *-- ISO20022.Camt106001.DateAndDateTime2Choice
    ISO20022.Camt106001.ChargesPerTypeRecord6 *-- ISO20022.Camt106001.ActiveCurrencyAndAmount
    ISO20022.Camt106001.ChargesPerTypeRecord6 *-- ISO20022.Camt106001.TransactionReferences7
    ISO20022.Camt106001.ChargesPerTypeRecord6 *-- ISO20022.Camt106001.SettlementInstruction19
    ISO20022.Camt106001.ChargesPerTypeRecord6 *-- ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
    class ISO20022.Camt106001.ChargesRecord12 {
        + AddtlInf  : String
        + InstrForInstdAgt  : ISO20022.Camt106001.InstructionForInstructedAgent1
        + Tp  : ISO20022.Camt106001.ChargeType3Choice
        + ChrgsAcctAgtAcct  : ISO20022.Camt106001.CashAccount40
        + ChrgsAcctAgt  : ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
        + DbtrAgtAcct  : ISO20022.Camt106001.CashAccount40
        + DbtrAgt  : ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
        + DbtrAcct  : ISO20022.Camt106001.CashAccount40
        + Dbtr  : ISO20022.Camt106001.PartyIdentification272
        + ValDt  : ISO20022.Camt106001.DateAndDateTime2Choice
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt106001.ActiveCurrencyAndAmount
        + UndrlygTx  : ISO20022.Camt106001.TransactionReferences7
        + SttlmInstr  : ISO20022.Camt106001.SettlementInstruction19
        + ChrgsRqstr  : ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
        + RcrdId  : String
        + ChrgsId  : String
    }
    ISO20022.Camt106001.ChargesRecord12 *-- ISO20022.Camt106001.InstructionForInstructedAgent1
    ISO20022.Camt106001.ChargesRecord12 *-- ISO20022.Camt106001.ChargeType3Choice
    ISO20022.Camt106001.ChargesRecord12 *-- ISO20022.Camt106001.CashAccount40
    ISO20022.Camt106001.ChargesRecord12 *-- ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt106001.ChargesRecord12 *-- ISO20022.Camt106001.CashAccount40
    ISO20022.Camt106001.ChargesRecord12 *-- ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt106001.ChargesRecord12 *-- ISO20022.Camt106001.CashAccount40
    ISO20022.Camt106001.ChargesRecord12 *-- ISO20022.Camt106001.PartyIdentification272
    ISO20022.Camt106001.ChargesRecord12 *-- ISO20022.Camt106001.DateAndDateTime2Choice
    ISO20022.Camt106001.ChargesRecord12 *-- ISO20022.Camt106001.ActiveCurrencyAndAmount
    ISO20022.Camt106001.ChargesRecord12 *-- ISO20022.Camt106001.TransactionReferences7
    ISO20022.Camt106001.ChargesRecord12 *-- ISO20022.Camt106001.SettlementInstruction19
    ISO20022.Camt106001.ChargesRecord12 *-- ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
    class ISO20022.Camt106001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt106001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt106001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt106001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt106001.ClearingSystemIdentification2Choice
    class ISO20022.Camt106001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt106001.OtherContact1~
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
    ISO20022.Camt106001.Contact13 *-- ISO20022.Camt106001.OtherContact1
    class ISO20022.Camt106001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Camt106001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Camt106001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Camt106001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt106001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Camt106001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt106001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt106001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt106001.FinancialInstitutionIdentification23 *-- ISO20022.Camt106001.GenericFinancialIdentification1
    ISO20022.Camt106001.FinancialInstitutionIdentification23 *-- ISO20022.Camt106001.PostalAddress27
    ISO20022.Camt106001.FinancialInstitutionIdentification23 *-- ISO20022.Camt106001.ClearingSystemMemberIdentification2
    class ISO20022.Camt106001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt106001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt106001.GenericAccountIdentification1 *-- ISO20022.Camt106001.AccountSchemeName1Choice
    class ISO20022.Camt106001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt106001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt106001.GenericFinancialIdentification1 *-- ISO20022.Camt106001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt106001.GenericIdentification3 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt106001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt106001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt106001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt106001.GenericOrganisationIdentification3 *-- ISO20022.Camt106001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Camt106001.GenericPersonIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt106001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt106001.GenericPersonIdentification2 *-- ISO20022.Camt106001.PersonIdentificationSchemeName1Choice
    class ISO20022.Camt106001.GroupHeader130 {
        + ChrgsAcctAgtAcct  : ISO20022.Camt106001.CashAccount40
        + ChrgsAcctAgt  : ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
        + TtlChrgs  : ISO20022.Camt106001.TotalCharges7
        + SttlmInstr  : ISO20022.Camt106001.SettlementInstruction19
        + ChrgsRqstr  : ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Camt106001.GroupHeader130 *-- ISO20022.Camt106001.CashAccount40
    ISO20022.Camt106001.GroupHeader130 *-- ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt106001.GroupHeader130 *-- ISO20022.Camt106001.TotalCharges7
    ISO20022.Camt106001.GroupHeader130 *-- ISO20022.Camt106001.SettlementInstruction19
    ISO20022.Camt106001.GroupHeader130 *-- ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
    class ISO20022.Camt106001.InstructionForInstructedAgent1 {
        + InstrInf  : String
        + Cd  : String
    }
    class ISO20022.Camt106001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Camt106001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt106001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Camt106001.OrganisationIdentification39 *-- ISO20022.Camt106001.GenericOrganisationIdentification3
    class ISO20022.Camt106001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt106001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Camt106001.Party52Choice {
        + PrvtId  : ISO20022.Camt106001.PersonIdentification18
        + OrgId  : ISO20022.Camt106001.OrganisationIdentification39
    }
    ISO20022.Camt106001.Party52Choice *-- ISO20022.Camt106001.PersonIdentification18
    ISO20022.Camt106001.Party52Choice *-- ISO20022.Camt106001.OrganisationIdentification39
    class ISO20022.Camt106001.PartyIdentification272 {
        + CtctDtls  : ISO20022.Camt106001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Camt106001.Party52Choice
        + PstlAdr  : ISO20022.Camt106001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Camt106001.PartyIdentification272 *-- ISO20022.Camt106001.Contact13
    ISO20022.Camt106001.PartyIdentification272 *-- ISO20022.Camt106001.Party52Choice
    ISO20022.Camt106001.PartyIdentification272 *-- ISO20022.Camt106001.PostalAddress27
    class ISO20022.Camt106001.PersonIdentification18 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt106001.GenericPersonIdentification2~
        + DtAndPlcOfBirth  : ISO20022.Camt106001.DateAndPlaceOfBirth1
    }
    ISO20022.Camt106001.PersonIdentification18 *-- ISO20022.Camt106001.GenericPersonIdentification2
    ISO20022.Camt106001.PersonIdentification18 *-- ISO20022.Camt106001.DateAndPlaceOfBirth1
    class ISO20022.Camt106001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt106001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Camt106001.AddressType3Choice
    }
    ISO20022.Camt106001.PostalAddress27 *-- ISO20022.Camt106001.AddressType3Choice
    class ISO20022.Camt106001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Camt106001.ProprietaryReference1 {
        + Ref  : String
        + Tp  : String
    }
    class ISO20022.Camt106001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Camt106001.ProxyAccountType1Choice
    }
    ISO20022.Camt106001.ProxyAccountIdentification1 *-- ISO20022.Camt106001.ProxyAccountType1Choice
    class ISO20022.Camt106001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt106001.SettlementInstruction19 {
        + CdtrAcct  : ISO20022.Camt106001.CashAccount40
        + Cdtr  : ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
        + CdtrAgtAcct  : ISO20022.Camt106001.CashAccount40
        + CdtrAgt  : ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
        + ReqdSttlmDt  : DateTime
    }
    ISO20022.Camt106001.SettlementInstruction19 *-- ISO20022.Camt106001.CashAccount40
    ISO20022.Camt106001.SettlementInstruction19 *-- ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt106001.SettlementInstruction19 *-- ISO20022.Camt106001.CashAccount40
    ISO20022.Camt106001.SettlementInstruction19 *-- ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8
    class ISO20022.Camt106001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt106001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt106001.SupplementaryData1 *-- ISO20022.Camt106001.SupplementaryDataEnvelope1
    class ISO20022.Camt106001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Camt106001.TotalCharges7 {
        + CdtDbtInd  : String
        + TtlChrgsAmt  : ISO20022.Camt106001.ActiveCurrencyAndAmount
        + CtrlSum  : Decimal
        + NbOfChrgsRcrds  : String
    }
    ISO20022.Camt106001.TotalCharges7 *-- ISO20022.Camt106001.ActiveCurrencyAndAmount
    class ISO20022.Camt106001.TotalCharges8 {
        + CdtDbtInd  : String
        + TtlChrgsAmt  : ISO20022.Camt106001.ActiveCurrencyAndAmount
        + CtrlSum  : Decimal
        + NbOfChrgsBrkdwnItms  : String
    }
    ISO20022.Camt106001.TotalCharges8 *-- ISO20022.Camt106001.ActiveCurrencyAndAmount
    class ISO20022.Camt106001.TransactionReferences7 {
        + Prtry  : global::System.Collections.Generic.List~ISO20022.Camt106001.ProprietaryReference1~
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
        + MsgNmId  : String
        + MsgId  : String
    }
    ISO20022.Camt106001.TransactionReferences7 *-- ISO20022.Camt106001.ProprietaryReference1
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

## Value ISO20022.Camt106001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt106001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt106001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt106001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Camt106001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt106001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt106001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt106001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Camt106001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt106001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt106001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Camt106001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Camt106001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Camt106001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Camt106001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Camt106001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt106001.ChargeType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt106001.GenericIdentification3||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt106001.Charges6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PerTp|global::System.Collections.Generic.List<ISO20022.Camt106001.ChargesPerType6>||XmlElement()||
|+|PerTx|ISO20022.Camt106001.ChargesPerTransaction6||XmlElement()||
|+|Sngl|ISO20022.Camt106001.ChargesRecord12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""PerTp""",PerTp),validList("""PerTp""",PerTp),validElement(PerTp),validElement(PerTx),validElement(Sngl),validChoice(PerTp,PerTx,Sngl))|

---

## Value ISO20022.Camt106001.ChargesBreakdown1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Camt106001.ChargeType3Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt106001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Amt))|

---

## Aspect ISO20022.Camt106001.ChargesPaymentRequestV03


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt106001.SupplementaryData1>||XmlElement()||
|+|Chrgs|ISO20022.Camt106001.Charges6Choice||XmlElement()||
|+|GrpHdr|ISO20022.Camt106001.GroupHeader130||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Chrgs),validElement(GrpHdr))|

---

## Value ISO20022.Camt106001.ChargesPerTransaction6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rcrd|global::System.Collections.Generic.List<ISO20022.Camt106001.ChargesPerTransactionRecord6>||XmlElement()||
|+|ChrgsAcctAgtAcct|ISO20022.Camt106001.CashAccount40||XmlElement()||
|+|ChrgsAcctAgt|ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|TtlChrgsPerTx|ISO20022.Camt106001.TotalCharges7||XmlElement()||
|+|ChrgsId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rcrd""",Rcrd),validList("""Rcrd""",Rcrd),validElement(Rcrd),validElement(ChrgsAcctAgtAcct),validElement(ChrgsAcctAgt),validElement(TtlChrgsPerTx))|

---

## Value ISO20022.Camt106001.ChargesPerTransactionRecord6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|InstrForInstdAgt|ISO20022.Camt106001.InstructionForInstructedAgent1||XmlElement()||
|+|ChrgsAcctAgtAcct|ISO20022.Camt106001.CashAccount40||XmlElement()||
|+|ChrgsAcctAgt|ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|DbtrAgtAcct|ISO20022.Camt106001.CashAccount40||XmlElement()||
|+|DbtrAgt|ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|DbtrAcct|ISO20022.Camt106001.CashAccount40||XmlElement()||
|+|Dbtr|ISO20022.Camt106001.PartyIdentification272||XmlElement()||
|+|ValDt|ISO20022.Camt106001.DateAndDateTime2Choice||XmlElement()||
|+|ChrgsBrkdwn|global::System.Collections.Generic.List<ISO20022.Camt106001.ChargesBreakdown1>||XmlElement()||
|+|TtlChrgsPerRcrd|ISO20022.Camt106001.TotalCharges8||XmlElement()||
|+|UndrlygTx|ISO20022.Camt106001.TransactionReferences7||XmlElement()||
|+|SttlmInstr|ISO20022.Camt106001.SettlementInstruction19||XmlElement()||
|+|ChrgsRqstr|ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|RcrdId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstrForInstdAgt),validElement(ChrgsAcctAgtAcct),validElement(ChrgsAcctAgt),validElement(DbtrAgtAcct),validElement(DbtrAgt),validElement(DbtrAcct),validElement(Dbtr),validElement(ValDt),validRequired("""ChrgsBrkdwn""",ChrgsBrkdwn),validList("""ChrgsBrkdwn""",ChrgsBrkdwn),validElement(ChrgsBrkdwn),validElement(TtlChrgsPerRcrd),validElement(UndrlygTx),validElement(SttlmInstr),validElement(ChrgsRqstr))|

---

## Value ISO20022.Camt106001.ChargesPerType6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Rcrd|global::System.Collections.Generic.List<ISO20022.Camt106001.ChargesPerTypeRecord6>||XmlElement()||
|+|Tp|ISO20022.Camt106001.ChargeType3Choice||XmlElement()||
|+|ChrgsAcctAgtAcct|ISO20022.Camt106001.CashAccount40||XmlElement()||
|+|ChrgsAcctAgt|ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|TtlChrgsPerChrgTp|ISO20022.Camt106001.TotalCharges7||XmlElement()||
|+|ChrgsId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rcrd""",Rcrd),validList("""Rcrd""",Rcrd),validElement(Rcrd),validElement(Tp),validElement(ChrgsAcctAgtAcct),validElement(ChrgsAcctAgt),validElement(TtlChrgsPerChrgTp))|

---

## Value ISO20022.Camt106001.ChargesPerTypeRecord6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|InstrForInstdAgt|ISO20022.Camt106001.InstructionForInstructedAgent1||XmlElement()||
|+|ChrgsAcctAgtAcct|ISO20022.Camt106001.CashAccount40||XmlElement()||
|+|ChrgsAcctAgt|ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|DbtrAgtAcct|ISO20022.Camt106001.CashAccount40||XmlElement()||
|+|DbtrAgt|ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|DbtrAcct|ISO20022.Camt106001.CashAccount40||XmlElement()||
|+|Dbtr|ISO20022.Camt106001.PartyIdentification272||XmlElement()||
|+|ValDt|ISO20022.Camt106001.DateAndDateTime2Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt106001.ActiveCurrencyAndAmount||XmlElement()||
|+|UndrlygTx|ISO20022.Camt106001.TransactionReferences7||XmlElement()||
|+|SttlmInstr|ISO20022.Camt106001.SettlementInstruction19||XmlElement()||
|+|ChrgsRqstr|ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|RcrdId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstrForInstdAgt),validElement(ChrgsAcctAgtAcct),validElement(ChrgsAcctAgt),validElement(DbtrAgtAcct),validElement(DbtrAgt),validElement(DbtrAcct),validElement(Dbtr),validElement(ValDt),validElement(Amt),validElement(UndrlygTx),validElement(SttlmInstr),validElement(ChrgsRqstr))|

---

## Value ISO20022.Camt106001.ChargesRecord12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|InstrForInstdAgt|ISO20022.Camt106001.InstructionForInstructedAgent1||XmlElement()||
|+|Tp|ISO20022.Camt106001.ChargeType3Choice||XmlElement()||
|+|ChrgsAcctAgtAcct|ISO20022.Camt106001.CashAccount40||XmlElement()||
|+|ChrgsAcctAgt|ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|DbtrAgtAcct|ISO20022.Camt106001.CashAccount40||XmlElement()||
|+|DbtrAgt|ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|DbtrAcct|ISO20022.Camt106001.CashAccount40||XmlElement()||
|+|Dbtr|ISO20022.Camt106001.PartyIdentification272||XmlElement()||
|+|ValDt|ISO20022.Camt106001.DateAndDateTime2Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt106001.ActiveCurrencyAndAmount||XmlElement()||
|+|UndrlygTx|ISO20022.Camt106001.TransactionReferences7||XmlElement()||
|+|SttlmInstr|ISO20022.Camt106001.SettlementInstruction19||XmlElement()||
|+|ChrgsRqstr|ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|RcrdId|String||XmlElement()||
|+|ChrgsId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstrForInstdAgt),validElement(Tp),validElement(ChrgsAcctAgtAcct),validElement(ChrgsAcctAgt),validElement(DbtrAgtAcct),validElement(DbtrAgt),validElement(DbtrAcct),validElement(Dbtr),validElement(ValDt),validElement(Amt),validElement(UndrlygTx),validElement(SttlmInstr),validElement(ChrgsRqstr))|

---

## Value ISO20022.Camt106001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt106001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt106001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Camt106001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt106001.OtherContact1>||XmlElement()||
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

## Enum ISO20022.Camt106001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Camt106001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Camt106001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Type ISO20022.Camt106001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ChrgsPmtReq|ISO20022.Camt106001.ChargesPaymentRequestV03||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ChrgsPmtReq))|

---

## Value ISO20022.Camt106001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt106001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt106001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt106001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt106001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt106001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt106001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt106001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt106001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt106001.GenericIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt106001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt106001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt106001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt106001.GenericPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt106001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt106001.GroupHeader130


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ChrgsAcctAgtAcct|ISO20022.Camt106001.CashAccount40||XmlElement()||
|+|ChrgsAcctAgt|ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|TtlChrgs|ISO20022.Camt106001.TotalCharges7||XmlElement()||
|+|SttlmInstr|ISO20022.Camt106001.SettlementInstruction19||XmlElement()||
|+|ChrgsRqstr|ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ChrgsAcctAgtAcct),validElement(ChrgsAcctAgt),validElement(TtlChrgs),validElement(SttlmInstr),validElement(ChrgsRqstr))|

---

## Value ISO20022.Camt106001.InstructionForInstructedAgent1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrInf|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Camt106001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Camt106001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt106001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt106001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt106001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt106001.Party52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Camt106001.PersonIdentification18||XmlElement()||
|+|OrgId|ISO20022.Camt106001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Camt106001.PartyIdentification272


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Camt106001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Camt106001.Party52Choice||XmlElement()||
|+|PstlAdr|ISO20022.Camt106001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Camt106001.PersonIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt106001.GenericPersonIdentification2>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Camt106001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Camt106001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt106001.PostalAddress27


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
|+|AdrTp|ISO20022.Camt106001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Camt106001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Value ISO20022.Camt106001.ProprietaryReference1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ref|String||XmlElement()||
|+|Tp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt106001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Camt106001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt106001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt106001.SettlementInstruction19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtrAcct|ISO20022.Camt106001.CashAccount40||XmlElement()||
|+|Cdtr|ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|CdtrAgtAcct|ISO20022.Camt106001.CashAccount40||XmlElement()||
|+|CdtrAgt|ISO20022.Camt106001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|ReqdSttlmDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CdtrAcct),validElement(Cdtr),validElement(CdtrAgtAcct),validElement(CdtrAgt))|

---

## Value ISO20022.Camt106001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt106001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt106001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt106001.TotalCharges7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|TtlChrgsAmt|ISO20022.Camt106001.ActiveCurrencyAndAmount||XmlElement()||
|+|CtrlSum|Decimal||XmlElement()||
|+|NbOfChrgsRcrds|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlChrgsAmt),validPattern("""NbOfChrgsRcrds""",NbOfChrgsRcrds,"""[0-9]{1,15}"""))|

---

## Value ISO20022.Camt106001.TotalCharges8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|TtlChrgsAmt|ISO20022.Camt106001.ActiveCurrencyAndAmount||XmlElement()||
|+|CtrlSum|Decimal||XmlElement()||
|+|NbOfChrgsBrkdwnItms|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlChrgsAmt),validPattern("""NbOfChrgsBrkdwnItms""",NbOfChrgsBrkdwnItms,"""[0-9]{1,15}"""))|

---

## Value ISO20022.Camt106001.TransactionReferences7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|global::System.Collections.Generic.List<ISO20022.Camt106001.ProprietaryReference1>||XmlElement()||
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
|+|MsgNmId|String||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Prtry""",Prtry),validElement(Prtry),validPattern("""UETR""",UETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""))|

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

