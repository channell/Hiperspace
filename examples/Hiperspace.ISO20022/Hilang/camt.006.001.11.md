# camt.006.001.11
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt006001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt006001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt006001.AccountIdentification4Choice *-- ISO20022.Camt006001.GenericAccountIdentification1
    class ISO20022.Camt006001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt006001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt006001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt006001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt006001.AddressType3Choice {
        + Prtry  : ISO20022.Camt006001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt006001.AddressType3Choice *-- ISO20022.Camt006001.GenericIdentification30
    class ISO20022.Camt006001.Amount2Choice {
        + AmtWthCcy  : ISO20022.Camt006001.ActiveCurrencyAndAmount
        + AmtWthtCcy  : Decimal
    }
    ISO20022.Camt006001.Amount2Choice *-- ISO20022.Camt006001.ActiveCurrencyAndAmount
    class ISO20022.Camt006001.Amount3Choice {
        + AmtWthtCcy  : Decimal
        + AmtWthCcy  : ISO20022.Camt006001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Camt006001.Amount3Choice *-- ISO20022.Camt006001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Camt006001.BranchData5
        + FinInstnId  : ISO20022.Camt006001.FinancialInstitutionIdentification23
    }
    ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt006001.BranchData5
    ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt006001.FinancialInstitutionIdentification23
    class ISO20022.Camt006001.BranchData5 {
        + PstlAdr  : ISO20022.Camt006001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt006001.BranchData5 *-- ISO20022.Camt006001.PostalAddress27
    class ISO20022.Camt006001.CancelledStatusReason1Code {
        CSUB = 1
        CANS = 2
        CANI = 3
    }
    class ISO20022.Camt006001.CashAccount43 {
        + Svcr  : ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
        + Ownr  : ISO20022.Camt006001.PartyIdentification272
        + Prxy  : ISO20022.Camt006001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Camt006001.CashAccountType2Choice
        + Id  : ISO20022.Camt006001.AccountIdentification4Choice
    }
    ISO20022.Camt006001.CashAccount43 *-- ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt006001.CashAccount43 *-- ISO20022.Camt006001.PartyIdentification272
    ISO20022.Camt006001.CashAccount43 *-- ISO20022.Camt006001.ProxyAccountIdentification1
    ISO20022.Camt006001.CashAccount43 *-- ISO20022.Camt006001.CashAccountType2Choice
    ISO20022.Camt006001.CashAccount43 *-- ISO20022.Camt006001.AccountIdentification4Choice
    class ISO20022.Camt006001.CashAccountAndEntry5 {
        + Ntry  : ISO20022.Camt006001.CashEntry2
        + Acct  : ISO20022.Camt006001.CashAccount43
    }
    ISO20022.Camt006001.CashAccountAndEntry5 *-- ISO20022.Camt006001.CashEntry2
    ISO20022.Camt006001.CashAccountAndEntry5 *-- ISO20022.Camt006001.CashAccount43
    class ISO20022.Camt006001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt006001.CashEntry2 {
        + AddtlNtryInf  : global::System.Collections.Generic.List~String~
        + AcctSvcrRef  : Decimal
        + StmtId  : String
        + Id  : String
        + Sts  : String
        + Dt  : ISO20022.Camt006001.DateAndDateTime2Choice
        + Amt  : ISO20022.Camt006001.ActiveCurrencyAndAmount
    }
    ISO20022.Camt006001.CashEntry2 *-- ISO20022.Camt006001.DateAndDateTime2Choice
    ISO20022.Camt006001.CashEntry2 *-- ISO20022.Camt006001.ActiveCurrencyAndAmount
    class ISO20022.Camt006001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt006001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt006001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt006001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt006001.ClearingSystemIdentification2Choice
    class ISO20022.Camt006001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt006001.OtherContact1~
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
    ISO20022.Camt006001.Contact13 *-- ISO20022.Camt006001.OtherContact1
    class ISO20022.Camt006001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Camt006001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Camt006001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Camt006001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Camt006001.DateTimePeriod1Choice {
        + DtTmRg  : ISO20022.Camt006001.DateTimePeriod1
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    ISO20022.Camt006001.DateTimePeriod1Choice *-- ISO20022.Camt006001.DateTimePeriod1
    class ISO20022.Camt006001.EntryStatus1Code {
        FUTR = 1
        PDNG = 2
        BOOK = 3
    }
    class ISO20022.Camt006001.ErrorHandling3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt006001.ErrorHandling5 {
        + Desc  : String
        + Err  : ISO20022.Camt006001.ErrorHandling3Choice
    }
    ISO20022.Camt006001.ErrorHandling5 *-- ISO20022.Camt006001.ErrorHandling3Choice
    class ISO20022.Camt006001.FinalStatus1Code {
        FNLD = 1
        CAND = 2
        RJTD = 3
        STLD = 4
    }
    class ISO20022.Camt006001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt006001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Camt006001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt006001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt006001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt006001.FinancialInstitutionIdentification23 *-- ISO20022.Camt006001.GenericFinancialIdentification1
    ISO20022.Camt006001.FinancialInstitutionIdentification23 *-- ISO20022.Camt006001.PostalAddress27
    ISO20022.Camt006001.FinancialInstitutionIdentification23 *-- ISO20022.Camt006001.ClearingSystemMemberIdentification2
    class ISO20022.Camt006001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt006001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt006001.GenericAccountIdentification1 *-- ISO20022.Camt006001.AccountSchemeName1Choice
    class ISO20022.Camt006001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt006001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt006001.GenericFinancialIdentification1 *-- ISO20022.Camt006001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt006001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Camt006001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt006001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt006001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt006001.GenericOrganisationIdentification3 *-- ISO20022.Camt006001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Camt006001.GenericPersonIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt006001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt006001.GenericPersonIdentification2 *-- ISO20022.Camt006001.PersonIdentificationSchemeName1Choice
    class ISO20022.Camt006001.LongPaymentIdentification4 {
        + EndToEndId  : String
        + NtryTp  : String
        + InstdAgt  : ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
        + InstgAgt  : ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
        + PmtMtd  : ISO20022.Camt006001.PaymentOrigin1Choice
        + IntrBkSttlmDt  : DateTime
        + IntrBkSttlmAmt  : Decimal
        + UETR  : String
        + TxId  : String
    }
    ISO20022.Camt006001.LongPaymentIdentification4 *-- ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt006001.LongPaymentIdentification4 *-- ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt006001.LongPaymentIdentification4 *-- ISO20022.Camt006001.PaymentOrigin1Choice
    class ISO20022.Camt006001.MarketInfrastructureIdentification1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt006001.MessageHeader8 {
        + QryNm  : String
        + ReqTp  : ISO20022.Camt006001.RequestType4Choice
        + OrgnlBizQry  : ISO20022.Camt006001.OriginalBusinessQuery1
        + MsgPgntn  : ISO20022.Camt006001.Pagination1
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Camt006001.MessageHeader8 *-- ISO20022.Camt006001.RequestType4Choice
    ISO20022.Camt006001.MessageHeader8 *-- ISO20022.Camt006001.OriginalBusinessQuery1
    ISO20022.Camt006001.MessageHeader8 *-- ISO20022.Camt006001.Pagination1
    class ISO20022.Camt006001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Camt006001.NumberAndSumOfTransactions2 {
        + CdtDbtInd  : String
        + TtlNetNtryAmt  : Decimal
        + Sum  : Decimal
        + NbOfNtries  : String
    }
    class ISO20022.Camt006001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt006001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Camt006001.OrganisationIdentification39 *-- ISO20022.Camt006001.GenericOrganisationIdentification3
    class ISO20022.Camt006001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt006001.OriginalBusinessQuery1 {
        + CreDtTm  : DateTime
        + MsgNmId  : String
        + MsgId  : String
    }
    class ISO20022.Camt006001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Camt006001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Camt006001.Party50Choice {
        + Agt  : ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
        + Pty  : ISO20022.Camt006001.PartyIdentification272
    }
    ISO20022.Camt006001.Party50Choice *-- ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt006001.Party50Choice *-- ISO20022.Camt006001.PartyIdentification272
    class ISO20022.Camt006001.Party52Choice {
        + PrvtId  : ISO20022.Camt006001.PersonIdentification18
        + OrgId  : ISO20022.Camt006001.OrganisationIdentification39
    }
    ISO20022.Camt006001.Party52Choice *-- ISO20022.Camt006001.PersonIdentification18
    ISO20022.Camt006001.Party52Choice *-- ISO20022.Camt006001.OrganisationIdentification39
    class ISO20022.Camt006001.PartyIdentification272 {
        + CtctDtls  : ISO20022.Camt006001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Camt006001.Party52Choice
        + PstlAdr  : ISO20022.Camt006001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Camt006001.PartyIdentification272 *-- ISO20022.Camt006001.Contact13
    ISO20022.Camt006001.PartyIdentification272 *-- ISO20022.Camt006001.Party52Choice
    ISO20022.Camt006001.PartyIdentification272 *-- ISO20022.Camt006001.PostalAddress27
    class ISO20022.Camt006001.PaymentCommon6 {
        + PmtMtd  : ISO20022.Camt006001.PaymentOrigin1Choice
        + CdtDbtInd  : String
        + NtryDt  : ISO20022.Camt006001.DateAndDateTime2Choice
        + ReqdExctnDt  : ISO20022.Camt006001.DateAndDateTime2Choice
        + CmonSts  : global::System.Collections.Generic.List~ISO20022.Camt006001.PaymentStatus6~
        + PmtTo  : ISO20022.Camt006001.System3
        + PmtFr  : ISO20022.Camt006001.System3
    }
    ISO20022.Camt006001.PaymentCommon6 *-- ISO20022.Camt006001.PaymentOrigin1Choice
    ISO20022.Camt006001.PaymentCommon6 *-- ISO20022.Camt006001.DateAndDateTime2Choice
    ISO20022.Camt006001.PaymentCommon6 *-- ISO20022.Camt006001.DateAndDateTime2Choice
    ISO20022.Camt006001.PaymentCommon6 *-- ISO20022.Camt006001.PaymentStatus6
    ISO20022.Camt006001.PaymentCommon6 *-- ISO20022.Camt006001.System3
    ISO20022.Camt006001.PaymentCommon6 *-- ISO20022.Camt006001.System3
    class ISO20022.Camt006001.PaymentIdentification8Choice {
        + PrtryId  : String
        + ShrtBizId  : ISO20022.Camt006001.ShortPaymentIdentification4
        + LngBizId  : ISO20022.Camt006001.LongPaymentIdentification4
        + QId  : ISO20022.Camt006001.QueueTransactionIdentification1
        + UETR  : String
        + TxId  : String
    }
    ISO20022.Camt006001.PaymentIdentification8Choice *-- ISO20022.Camt006001.ShortPaymentIdentification4
    ISO20022.Camt006001.PaymentIdentification8Choice *-- ISO20022.Camt006001.LongPaymentIdentification4
    ISO20022.Camt006001.PaymentIdentification8Choice *-- ISO20022.Camt006001.QueueTransactionIdentification1
    class ISO20022.Camt006001.PaymentInstruction47 {
        + Pties  : ISO20022.Camt006001.PaymentTransactionParty4
        + EndToEndId  : String
        + IntrBkSttlmDt  : DateTime
        + TxId  : String
        + GnrtdOrdr  : String
        + Tp  : ISO20022.Camt006001.PaymentType4Choice
        + InstrCpy  : String
        + PrcgVldtyTm  : ISO20022.Camt006001.DateTimePeriod1Choice
        + Prty  : ISO20022.Camt006001.Priority1Choice
        + PmtMtd  : ISO20022.Camt006001.PaymentOrigin1Choice
        + Purp  : String
        + IntrBkSttlmAmt  : ISO20022.Camt006001.Amount2Choice
        + InstdAmt  : ISO20022.Camt006001.Amount3Choice
        + Sts  : global::System.Collections.Generic.List~ISO20022.Camt006001.PaymentStatus6~
        + ReqdExctnDt  : ISO20022.Camt006001.DateAndDateTime2Choice
        + MsgId  : String
    }
    ISO20022.Camt006001.PaymentInstruction47 *-- ISO20022.Camt006001.PaymentTransactionParty4
    ISO20022.Camt006001.PaymentInstruction47 *-- ISO20022.Camt006001.PaymentType4Choice
    ISO20022.Camt006001.PaymentInstruction47 *-- ISO20022.Camt006001.DateTimePeriod1Choice
    ISO20022.Camt006001.PaymentInstruction47 *-- ISO20022.Camt006001.Priority1Choice
    ISO20022.Camt006001.PaymentInstruction47 *-- ISO20022.Camt006001.PaymentOrigin1Choice
    ISO20022.Camt006001.PaymentInstruction47 *-- ISO20022.Camt006001.Amount2Choice
    ISO20022.Camt006001.PaymentInstruction47 *-- ISO20022.Camt006001.Amount3Choice
    ISO20022.Camt006001.PaymentInstruction47 *-- ISO20022.Camt006001.PaymentStatus6
    ISO20022.Camt006001.PaymentInstruction47 *-- ISO20022.Camt006001.DateAndDateTime2Choice
    class ISO20022.Camt006001.PaymentInstrument1Code {
        CAN = 1
        RTI = 2
        CCP = 3
        DCP = 4
        BKT = 5
        CHK = 6
        CCT = 7
        CDT = 8
        BCT = 9
        BDT = 10
    }
    class ISO20022.Camt006001.PaymentOrigin1Choice {
        + Instrm  : String
        + Prtry  : String
        + XMLMsgNm  : String
        + FINMT  : String
    }
    class ISO20022.Camt006001.PaymentStatus6 {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Camt006001.PaymentStatusReason1Choice~
        + DtTm  : ISO20022.Camt006001.DateAndDateTime2Choice
        + Cd  : ISO20022.Camt006001.PaymentStatusCode6Choice
    }
    ISO20022.Camt006001.PaymentStatus6 *-- ISO20022.Camt006001.PaymentStatusReason1Choice
    ISO20022.Camt006001.PaymentStatus6 *-- ISO20022.Camt006001.DateAndDateTime2Choice
    ISO20022.Camt006001.PaymentStatus6 *-- ISO20022.Camt006001.PaymentStatusCode6Choice
    class ISO20022.Camt006001.PaymentStatusCode6Choice {
        + Prtry  : String
        + Sttlm  : String
        + RTGS  : String
        + Fnl  : String
        + Pdg  : String
    }
    class ISO20022.Camt006001.PaymentStatusReason1Choice {
        + Prtry  : String
        + PrtryRjctn  : ISO20022.Camt006001.ProprietaryStatusJustification2
        + PdgSttlm  : String
        + PdgFlngSttlm  : String
        + Sspd  : String
        + Canc  : String
        + Umtchd  : String
    }
    ISO20022.Camt006001.PaymentStatusReason1Choice *-- ISO20022.Camt006001.ProprietaryStatusJustification2
    class ISO20022.Camt006001.PaymentTransactionParty4 {
        + UltmtCdtr  : ISO20022.Camt006001.Party50Choice
        + Cdtr  : ISO20022.Camt006001.Party50Choice
        + CdtrAgt  : ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
        + IntrmyAgt3  : ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
        + IntrmyAgt2  : ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
        + IntrmyAgt1  : ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
        + InstdRmbrsmntAgt  : ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
        + InstgRmbrsmntAgt  : ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
        + DbtrAgt  : ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
        + Dbtr  : ISO20022.Camt006001.Party50Choice
        + UltmtDbtr  : ISO20022.Camt006001.Party50Choice
        + InstdAgt  : ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
        + InstgAgt  : ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    }
    ISO20022.Camt006001.PaymentTransactionParty4 *-- ISO20022.Camt006001.Party50Choice
    ISO20022.Camt006001.PaymentTransactionParty4 *-- ISO20022.Camt006001.Party50Choice
    ISO20022.Camt006001.PaymentTransactionParty4 *-- ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt006001.PaymentTransactionParty4 *-- ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt006001.PaymentTransactionParty4 *-- ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt006001.PaymentTransactionParty4 *-- ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt006001.PaymentTransactionParty4 *-- ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt006001.PaymentTransactionParty4 *-- ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt006001.PaymentTransactionParty4 *-- ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt006001.PaymentTransactionParty4 *-- ISO20022.Camt006001.Party50Choice
    ISO20022.Camt006001.PaymentTransactionParty4 *-- ISO20022.Camt006001.Party50Choice
    ISO20022.Camt006001.PaymentTransactionParty4 *-- ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt006001.PaymentTransactionParty4 *-- ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    class ISO20022.Camt006001.PaymentType3Code {
        MGL = 1
        OND = 2
        TCP = 3
        LOR = 4
        LOA = 5
        TCS = 6
        TRP = 7
        STF = 8
        DPS = 9
        DPH = 10
        DPP = 11
        LIQ = 12
        LMT = 13
        TCH = 14
        EXP = 15
        DPN = 16
        DPG = 17
        CBP = 18
        CBH = 19
        CTR = 20
        CLS = 21
        BAL = 22
        BCK = 23
        CBS = 24
    }
    class ISO20022.Camt006001.PaymentType4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt006001.PendingFailingSettlement1Code {
        MUNO = 1
        CPEC = 2
        GLOB = 3
        PREA = 4
        GUAD = 5
        BATC = 6
        CYCL = 7
        SDUT = 8
        REFS = 9
        YCOL = 10
        NCON = 11
        MONY = 12
        LALO = 13
        CAIS = 14
        BYIY = 15
        LINK = 16
        INCA = 17
        NOFX = 18
        FLIM = 19
        DEPO = 20
        COLL = 21
        CMON = 22
        PART = 23
        CLAC = 24
        NEWI = 25
        CHAS = 26
        BLOC = 27
        DOCC = 28
        OBJT = 29
        MLAT = 30
        CANR = 31
        LATE = 32
        LACK = 33
        BENO = 34
        STCD = 35
        DKNY = 36
        SBLO = 37
        PHSE = 38
        MINO = 39
        CERT = 40
        CLAT = 41
        DOCY = 42
        LAAW = 43
        AWSH = 44
        AWMO = 45
    }
    class ISO20022.Camt006001.PendingSettlement2Code {
        PCAP = 1
        MINO = 2
        CPEC = 3
        SBLO = 4
        CYCL = 5
        BATC = 6
        SDUT = 7
        REFS = 8
        NCON = 9
        MONY = 10
        LALO = 11
        LACK = 12
        FUTU = 13
        LINK = 14
        INCA = 15
        NOFX = 16
        FLIM = 17
        DEPO = 18
        COLL = 19
        YCOL = 20
        CMON = 21
        NMAS = 22
        PART = 23
        GUAD = 24
        PREA = 25
        GLOB = 26
        MUNO = 27
        CLAC = 28
        NEWI = 29
        CHAS = 30
        BLOC = 31
        DOCC = 32
        DOCY = 33
        TAMM = 34
        PHSE = 35
        AWSH = 36
        REFU = 37
        CAIS = 38
        AWMO = 39
    }
    class ISO20022.Camt006001.PendingStatus4Code {
        SRML = 1
        AVLB = 2
        SRBL = 3
        RMLR = 4
        SMLR = 5
        PFST = 6
        PSTL = 7
        PCAN = 8
        SSPD = 9
        STLM = 10
        STLE = 11
        UMAC = 12
        INVD = 13
        AUTD = 14
        MATD = 15
        VALD = 16
        ACPD = 17
    }
    class ISO20022.Camt006001.PersonIdentification18 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt006001.GenericPersonIdentification2~
        + DtAndPlcOfBirth  : ISO20022.Camt006001.DateAndPlaceOfBirth1
    }
    ISO20022.Camt006001.PersonIdentification18 *-- ISO20022.Camt006001.GenericPersonIdentification2
    ISO20022.Camt006001.PersonIdentification18 *-- ISO20022.Camt006001.DateAndPlaceOfBirth1
    class ISO20022.Camt006001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt006001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Camt006001.AddressType3Choice
    }
    ISO20022.Camt006001.PostalAddress27 *-- ISO20022.Camt006001.AddressType3Choice
    class ISO20022.Camt006001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Camt006001.Priority1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt006001.Priority5Code {
        URGT = 1
        NORM = 2
        LOWW = 3
        HIGH = 4
    }
    class ISO20022.Camt006001.ProprietaryStatusJustification2 {
        + Rsn  : String
        + PrtryStsRsn  : String
    }
    class ISO20022.Camt006001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Camt006001.ProxyAccountType1Choice
    }
    ISO20022.Camt006001.ProxyAccountIdentification1 *-- ISO20022.Camt006001.ProxyAccountType1Choice
    class ISO20022.Camt006001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt006001.QueueTransactionIdentification1 {
        + PosInQ  : String
        + QId  : String
    }
    class ISO20022.Camt006001.RequestType4Choice {
        + Prtry  : ISO20022.Camt006001.GenericIdentification1
        + Enqry  : String
        + PmtCtrl  : String
    }
    ISO20022.Camt006001.RequestType4Choice *-- ISO20022.Camt006001.GenericIdentification1
    class ISO20022.Camt006001.ReturnTransactionV11 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt006001.SupplementaryData1~
        + RptOrErr  : ISO20022.Camt006001.TransactionReportOrError7Choice
        + MsgHdr  : ISO20022.Camt006001.MessageHeader8
    }
    ISO20022.Camt006001.ReturnTransactionV11 *-- ISO20022.Camt006001.SupplementaryData1
    ISO20022.Camt006001.ReturnTransactionV11 *-- ISO20022.Camt006001.TransactionReportOrError7Choice
    ISO20022.Camt006001.ReturnTransactionV11 *-- ISO20022.Camt006001.MessageHeader8
    class ISO20022.Camt006001.SecuritiesTransactionReferences1 {
        + PrcgId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    class ISO20022.Camt006001.ShortPaymentIdentification4 {
        + InstgAgt  : ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
        + IntrBkSttlmDt  : DateTime
        + UETR  : String
        + TxId  : String
    }
    ISO20022.Camt006001.ShortPaymentIdentification4 *-- ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    class ISO20022.Camt006001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt006001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt006001.SupplementaryData1 *-- ISO20022.Camt006001.SupplementaryDataEnvelope1
    class ISO20022.Camt006001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Camt006001.SuspendedStatusReason1Code {
        SUBS = 1
        SUBY = 2
    }
    class ISO20022.Camt006001.System3 {
        + AcctId  : ISO20022.Camt006001.AccountIdentification4Choice
        + Ctry  : String
        + MmbId  : ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
        + SysId  : ISO20022.Camt006001.MarketInfrastructureIdentification1Choice
    }
    ISO20022.Camt006001.System3 *-- ISO20022.Camt006001.AccountIdentification4Choice
    ISO20022.Camt006001.System3 *-- ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt006001.System3 *-- ISO20022.Camt006001.MarketInfrastructureIdentification1Choice
    class ISO20022.Camt006001.Transaction159 {
        + SctiesTxRefs  : ISO20022.Camt006001.SecuritiesTransactionReferences1
        + AcctNtry  : ISO20022.Camt006001.CashAccountAndEntry5
        + Pmt  : ISO20022.Camt006001.PaymentInstruction47
        + CdtDbtInd  : String
        + PmtFr  : ISO20022.Camt006001.System3
        + PmtTo  : ISO20022.Camt006001.System3
    }
    ISO20022.Camt006001.Transaction159 *-- ISO20022.Camt006001.SecuritiesTransactionReferences1
    ISO20022.Camt006001.Transaction159 *-- ISO20022.Camt006001.CashAccountAndEntry5
    ISO20022.Camt006001.Transaction159 *-- ISO20022.Camt006001.PaymentInstruction47
    ISO20022.Camt006001.Transaction159 *-- ISO20022.Camt006001.System3
    ISO20022.Camt006001.Transaction159 *-- ISO20022.Camt006001.System3
    class ISO20022.Camt006001.TransactionOrError6Choice {
        + BizErr  : global::System.Collections.Generic.List~ISO20022.Camt006001.ErrorHandling5~
        + Tx  : ISO20022.Camt006001.Transaction159
    }
    ISO20022.Camt006001.TransactionOrError6Choice *-- ISO20022.Camt006001.ErrorHandling5
    ISO20022.Camt006001.TransactionOrError6Choice *-- ISO20022.Camt006001.Transaction159
    class ISO20022.Camt006001.TransactionReport8 {
        + TxOrErr  : ISO20022.Camt006001.TransactionOrError6Choice
        + PmtId  : ISO20022.Camt006001.PaymentIdentification8Choice
    }
    ISO20022.Camt006001.TransactionReport8 *-- ISO20022.Camt006001.TransactionOrError6Choice
    ISO20022.Camt006001.TransactionReport8 *-- ISO20022.Camt006001.PaymentIdentification8Choice
    class ISO20022.Camt006001.TransactionReportOrError7Choice {
        + OprlErr  : global::System.Collections.Generic.List~ISO20022.Camt006001.ErrorHandling5~
        + BizRpt  : ISO20022.Camt006001.Transactions11
    }
    ISO20022.Camt006001.TransactionReportOrError7Choice *-- ISO20022.Camt006001.ErrorHandling5
    ISO20022.Camt006001.TransactionReportOrError7Choice *-- ISO20022.Camt006001.Transactions11
    class ISO20022.Camt006001.Transactions11 {
        + TxRpt  : global::System.Collections.Generic.List~ISO20022.Camt006001.TransactionReport8~
        + TxsSummry  : ISO20022.Camt006001.NumberAndSumOfTransactions2
        + PmtCmonInf  : ISO20022.Camt006001.PaymentCommon6
    }
    ISO20022.Camt006001.Transactions11 *-- ISO20022.Camt006001.TransactionReport8
    ISO20022.Camt006001.Transactions11 *-- ISO20022.Camt006001.NumberAndSumOfTransactions2
    ISO20022.Camt006001.Transactions11 *-- ISO20022.Camt006001.PaymentCommon6
    class ISO20022.Camt006001.UnmatchedStatusReason1Code {
        ICUS = 1
        TERM = 2
        LATE = 3
        DTRD = 4
        SAFE = 5
        NMAS = 6
        NCRR = 7
        IEXE = 8
        CHAR = 9
        CPCA = 10
        ICAG = 11
        RTGS = 12
        REGD = 13
        FORF = 14
        PODU = 15
        PLCE = 16
        FRAP = 17
        IIND = 18
        PHYS = 19
        REPP = 20
        REPA = 21
        RERT = 22
        CLAT = 23
        REPO = 24
        RSPR = 25
        DTRA = 26
        VASU = 27
        DSEC = 28
        SETR = 29
        CADE = 30
        DQUA = 31
        DDEA = 32
        DMON = 33
        DEPT = 34
        DELN = 35
        DDAT = 36
        CMIS = 37
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

## Value ISO20022.Camt006001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt006001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt006001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt006001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Camt006001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Camt006001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt006001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt006001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt006001.Amount2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtWthCcy|ISO20022.Camt006001.ActiveCurrencyAndAmount||XmlElement()||
|+|AmtWthtCcy|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtWthCcy),validChoice(AmtWthCcy,AmtWthtCcy))|

---

## Value ISO20022.Camt006001.Amount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtWthtCcy|Decimal||XmlElement()||
|+|AmtWthCcy|ISO20022.Camt006001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtWthCcy),validChoice(AmtWthtCcy,AmtWthCcy))|

---

## Value ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt006001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Camt006001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt006001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt006001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Enum ISO20022.Camt006001.CancelledStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CSUB|Int32||XmlEnum("""CSUB""")|1|
||CANS|Int32||XmlEnum("""CANS""")|2|
||CANI|Int32||XmlEnum("""CANI""")|3|

---

## Value ISO20022.Camt006001.CashAccount43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Svcr|ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Ownr|ISO20022.Camt006001.PartyIdentification272||XmlElement()||
|+|Prxy|ISO20022.Camt006001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Camt006001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Camt006001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Svcr),validElement(Ownr),validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Camt006001.CashAccountAndEntry5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ntry|ISO20022.Camt006001.CashEntry2||XmlElement()||
|+|Acct|ISO20022.Camt006001.CashAccount43||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Ntry),validElement(Acct))|

---

## Value ISO20022.Camt006001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt006001.CashEntry2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlNtryInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AcctSvcrRef|Decimal||XmlElement()||
|+|StmtId|String||XmlElement()||
|+|Id|String||XmlElement()||
|+|Sts|String||XmlElement()||
|+|Dt|ISO20022.Camt006001.DateAndDateTime2Choice||XmlElement()||
|+|Amt|ISO20022.Camt006001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Dt),validElement(Amt))|

---

## Value ISO20022.Camt006001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt006001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt006001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Camt006001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt006001.OtherContact1>||XmlElement()||
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

## Enum ISO20022.Camt006001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Camt006001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Camt006001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Camt006001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt006001.DateTimePeriod1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTmRg|ISO20022.Camt006001.DateTimePeriod1||XmlElement()||
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtTmRg),validChoice(DtTmRg,ToDtTm,FrDtTm))|

---

## Type ISO20022.Camt006001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RtrTx|ISO20022.Camt006001.ReturnTransactionV11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RtrTx))|

---

## Enum ISO20022.Camt006001.EntryStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FUTR|Int32||XmlEnum("""FUTR""")|1|
||PDNG|Int32||XmlEnum("""PDNG""")|2|
||BOOK|Int32||XmlEnum("""BOOK""")|3|

---

## Value ISO20022.Camt006001.ErrorHandling3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt006001.ErrorHandling5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|Err|ISO20022.Camt006001.ErrorHandling3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Err))|

---

## Enum ISO20022.Camt006001.FinalStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FNLD|Int32||XmlEnum("""FNLD""")|1|
||CAND|Int32||XmlEnum("""CAND""")|2|
||RJTD|Int32||XmlEnum("""RJTD""")|3|
||STLD|Int32||XmlEnum("""STLD""")|4|

---

## Value ISO20022.Camt006001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt006001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt006001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt006001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt006001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt006001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt006001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt006001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt006001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt006001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt006001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt006001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt006001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt006001.GenericPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt006001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt006001.LongPaymentIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EndToEndId|String||XmlElement()||
|+|NtryTp|String||XmlElement()||
|+|InstdAgt|ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InstgAgt|ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|PmtMtd|ISO20022.Camt006001.PaymentOrigin1Choice||XmlElement()||
|+|IntrBkSttlmDt|DateTime||XmlElement()||
|+|IntrBkSttlmAmt|Decimal||XmlElement()||
|+|UETR|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""NtryTp""",NtryTp,"""[BEOVW]{1,1}[0-9]{2,2}\|DUM"""),validElement(InstdAgt),validElement(InstgAgt),validElement(PmtMtd),validPattern("""UETR""",UETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""))|

---

## Value ISO20022.Camt006001.MarketInfrastructureIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt006001.MessageHeader8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QryNm|String||XmlElement()||
|+|ReqTp|ISO20022.Camt006001.RequestType4Choice||XmlElement()||
|+|OrgnlBizQry|ISO20022.Camt006001.OriginalBusinessQuery1||XmlElement()||
|+|MsgPgntn|ISO20022.Camt006001.Pagination1||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqTp),validElement(OrgnlBizQry),validElement(MsgPgntn))|

---

## Enum ISO20022.Camt006001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Camt006001.NumberAndSumOfTransactions2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|TtlNetNtryAmt|Decimal||XmlElement()||
|+|Sum|Decimal||XmlElement()||
|+|NbOfNtries|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""NbOfNtries""",NbOfNtries,"""[0-9]{1,15}"""))|

---

## Value ISO20022.Camt006001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt006001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt006001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt006001.OriginalBusinessQuery1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgNmId|String||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt006001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt006001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Camt006001.Party50Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Agt|ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Pty|ISO20022.Camt006001.PartyIdentification272||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Agt),validElement(Pty),validChoice(Agt,Pty))|

---

## Value ISO20022.Camt006001.Party52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Camt006001.PersonIdentification18||XmlElement()||
|+|OrgId|ISO20022.Camt006001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Camt006001.PartyIdentification272


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Camt006001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Camt006001.Party52Choice||XmlElement()||
|+|PstlAdr|ISO20022.Camt006001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Camt006001.PaymentCommon6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtMtd|ISO20022.Camt006001.PaymentOrigin1Choice||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|NtryDt|ISO20022.Camt006001.DateAndDateTime2Choice||XmlElement()||
|+|ReqdExctnDt|ISO20022.Camt006001.DateAndDateTime2Choice||XmlElement()||
|+|CmonSts|global::System.Collections.Generic.List<ISO20022.Camt006001.PaymentStatus6>||XmlElement()||
|+|PmtTo|ISO20022.Camt006001.System3||XmlElement()||
|+|PmtFr|ISO20022.Camt006001.System3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtMtd),validElement(NtryDt),validElement(ReqdExctnDt),validList("""CmonSts""",CmonSts),validElement(CmonSts),validElement(PmtTo),validElement(PmtFr))|

---

## Value ISO20022.Camt006001.PaymentIdentification8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|String||XmlElement()||
|+|ShrtBizId|ISO20022.Camt006001.ShortPaymentIdentification4||XmlElement()||
|+|LngBizId|ISO20022.Camt006001.LongPaymentIdentification4||XmlElement()||
|+|QId|ISO20022.Camt006001.QueueTransactionIdentification1||XmlElement()||
|+|UETR|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ShrtBizId),validElement(LngBizId),validElement(QId),validPattern("""UETR""",UETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""),validChoice(PrtryId,ShrtBizId,LngBizId,QId,UETR,TxId))|

---

## Value ISO20022.Camt006001.PaymentInstruction47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pties|ISO20022.Camt006001.PaymentTransactionParty4||XmlElement()||
|+|EndToEndId|String||XmlElement()||
|+|IntrBkSttlmDt|DateTime||XmlElement()||
|+|TxId|String||XmlElement()||
|+|GnrtdOrdr|String||XmlElement()||
|+|Tp|ISO20022.Camt006001.PaymentType4Choice||XmlElement()||
|+|InstrCpy|String||XmlElement()||
|+|PrcgVldtyTm|ISO20022.Camt006001.DateTimePeriod1Choice||XmlElement()||
|+|Prty|ISO20022.Camt006001.Priority1Choice||XmlElement()||
|+|PmtMtd|ISO20022.Camt006001.PaymentOrigin1Choice||XmlElement()||
|+|Purp|String||XmlElement()||
|+|IntrBkSttlmAmt|ISO20022.Camt006001.Amount2Choice||XmlElement()||
|+|InstdAmt|ISO20022.Camt006001.Amount3Choice||XmlElement()||
|+|Sts|global::System.Collections.Generic.List<ISO20022.Camt006001.PaymentStatus6>||XmlElement()||
|+|ReqdExctnDt|ISO20022.Camt006001.DateAndDateTime2Choice||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pties),validElement(Tp),validElement(PrcgVldtyTm),validElement(Prty),validElement(PmtMtd),validElement(IntrBkSttlmAmt),validElement(InstdAmt),validList("""Sts""",Sts),validElement(Sts),validElement(ReqdExctnDt))|

---

## Enum ISO20022.Camt006001.PaymentInstrument1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CAN|Int32||XmlEnum("""CAN""")|1|
||RTI|Int32||XmlEnum("""RTI""")|2|
||CCP|Int32||XmlEnum("""CCP""")|3|
||DCP|Int32||XmlEnum("""DCP""")|4|
||BKT|Int32||XmlEnum("""BKT""")|5|
||CHK|Int32||XmlEnum("""CHK""")|6|
||CCT|Int32||XmlEnum("""CCT""")|7|
||CDT|Int32||XmlEnum("""CDT""")|8|
||BCT|Int32||XmlEnum("""BCT""")|9|
||BDT|Int32||XmlEnum("""BDT""")|10|

---

## Value ISO20022.Camt006001.PaymentOrigin1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Instrm|String||XmlElement()||
|+|Prtry|String||XmlElement()||
|+|XMLMsgNm|String||XmlElement()||
|+|FINMT|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FINMT""",FINMT,"""[0-9]{1,3}"""),validChoice(Instrm,Prtry,XMLMsgNm,FINMT))|

---

## Value ISO20022.Camt006001.PaymentStatus6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Camt006001.PaymentStatusReason1Choice>||XmlElement()||
|+|DtTm|ISO20022.Camt006001.DateAndDateTime2Choice||XmlElement()||
|+|Cd|ISO20022.Camt006001.PaymentStatusCode6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rsn""",Rsn),validElement(Rsn),validElement(DtTm),validElement(Cd))|

---

## Value ISO20022.Camt006001.PaymentStatusCode6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Sttlm|String||XmlElement()||
|+|RTGS|String||XmlElement()||
|+|Fnl|String||XmlElement()||
|+|Pdg|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Sttlm""",Sttlm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""RTGS""",RTGS,"""[a-zA-Z0-9]{1,4}"""),validChoice(Prtry,Sttlm,RTGS,Fnl,Pdg))|

---

## Value ISO20022.Camt006001.PaymentStatusReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|PrtryRjctn|ISO20022.Camt006001.ProprietaryStatusJustification2||XmlElement()||
|+|PdgSttlm|String||XmlElement()||
|+|PdgFlngSttlm|String||XmlElement()||
|+|Sspd|String||XmlElement()||
|+|Canc|String||XmlElement()||
|+|Umtchd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryRjctn),validChoice(Prtry,PrtryRjctn,PdgSttlm,PdgFlngSttlm,Sspd,Canc,Umtchd))|

---

## Value ISO20022.Camt006001.PaymentTransactionParty4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UltmtCdtr|ISO20022.Camt006001.Party50Choice||XmlElement()||
|+|Cdtr|ISO20022.Camt006001.Party50Choice||XmlElement()||
|+|CdtrAgt|ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrmyAgt3|ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrmyAgt2|ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrmyAgt1|ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InstdRmbrsmntAgt|ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InstgRmbrsmntAgt|ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|DbtrAgt|ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Dbtr|ISO20022.Camt006001.Party50Choice||XmlElement()||
|+|UltmtDbtr|ISO20022.Camt006001.Party50Choice||XmlElement()||
|+|InstdAgt|ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InstgAgt|ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UltmtCdtr),validElement(Cdtr),validElement(CdtrAgt),validElement(IntrmyAgt3),validElement(IntrmyAgt2),validElement(IntrmyAgt1),validElement(InstdRmbrsmntAgt),validElement(InstgRmbrsmntAgt),validElement(DbtrAgt),validElement(Dbtr),validElement(UltmtDbtr),validElement(InstdAgt),validElement(InstgAgt))|

---

## Enum ISO20022.Camt006001.PaymentType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MGL|Int32||XmlEnum("""MGL""")|1|
||OND|Int32||XmlEnum("""OND""")|2|
||TCP|Int32||XmlEnum("""TCP""")|3|
||LOR|Int32||XmlEnum("""LOR""")|4|
||LOA|Int32||XmlEnum("""LOA""")|5|
||TCS|Int32||XmlEnum("""TCS""")|6|
||TRP|Int32||XmlEnum("""TRP""")|7|
||STF|Int32||XmlEnum("""STF""")|8|
||DPS|Int32||XmlEnum("""DPS""")|9|
||DPH|Int32||XmlEnum("""DPH""")|10|
||DPP|Int32||XmlEnum("""DPP""")|11|
||LIQ|Int32||XmlEnum("""LIQ""")|12|
||LMT|Int32||XmlEnum("""LMT""")|13|
||TCH|Int32||XmlEnum("""TCH""")|14|
||EXP|Int32||XmlEnum("""EXP""")|15|
||DPN|Int32||XmlEnum("""DPN""")|16|
||DPG|Int32||XmlEnum("""DPG""")|17|
||CBP|Int32||XmlEnum("""CBP""")|18|
||CBH|Int32||XmlEnum("""CBH""")|19|
||CTR|Int32||XmlEnum("""CTR""")|20|
||CLS|Int32||XmlEnum("""CLS""")|21|
||BAL|Int32||XmlEnum("""BAL""")|22|
||BCK|Int32||XmlEnum("""BCK""")|23|
||CBS|Int32||XmlEnum("""CBS""")|24|

---

## Value ISO20022.Camt006001.PaymentType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt006001.PendingFailingSettlement1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MUNO|Int32||XmlEnum("""MUNO""")|1|
||CPEC|Int32||XmlEnum("""CPEC""")|2|
||GLOB|Int32||XmlEnum("""GLOB""")|3|
||PREA|Int32||XmlEnum("""PREA""")|4|
||GUAD|Int32||XmlEnum("""GUAD""")|5|
||BATC|Int32||XmlEnum("""BATC""")|6|
||CYCL|Int32||XmlEnum("""CYCL""")|7|
||SDUT|Int32||XmlEnum("""SDUT""")|8|
||REFS|Int32||XmlEnum("""REFS""")|9|
||YCOL|Int32||XmlEnum("""YCOL""")|10|
||NCON|Int32||XmlEnum("""NCON""")|11|
||MONY|Int32||XmlEnum("""MONY""")|12|
||LALO|Int32||XmlEnum("""LALO""")|13|
||CAIS|Int32||XmlEnum("""CAIS""")|14|
||BYIY|Int32||XmlEnum("""BYIY""")|15|
||LINK|Int32||XmlEnum("""LINK""")|16|
||INCA|Int32||XmlEnum("""INCA""")|17|
||NOFX|Int32||XmlEnum("""NOFX""")|18|
||FLIM|Int32||XmlEnum("""FLIM""")|19|
||DEPO|Int32||XmlEnum("""DEPO""")|20|
||COLL|Int32||XmlEnum("""COLL""")|21|
||CMON|Int32||XmlEnum("""CMON""")|22|
||PART|Int32||XmlEnum("""PART""")|23|
||CLAC|Int32||XmlEnum("""CLAC""")|24|
||NEWI|Int32||XmlEnum("""NEWI""")|25|
||CHAS|Int32||XmlEnum("""CHAS""")|26|
||BLOC|Int32||XmlEnum("""BLOC""")|27|
||DOCC|Int32||XmlEnum("""DOCC""")|28|
||OBJT|Int32||XmlEnum("""OBJT""")|29|
||MLAT|Int32||XmlEnum("""MLAT""")|30|
||CANR|Int32||XmlEnum("""CANR""")|31|
||LATE|Int32||XmlEnum("""LATE""")|32|
||LACK|Int32||XmlEnum("""LACK""")|33|
||BENO|Int32||XmlEnum("""BENO""")|34|
||STCD|Int32||XmlEnum("""STCD""")|35|
||DKNY|Int32||XmlEnum("""DKNY""")|36|
||SBLO|Int32||XmlEnum("""SBLO""")|37|
||PHSE|Int32||XmlEnum("""PHSE""")|38|
||MINO|Int32||XmlEnum("""MINO""")|39|
||CERT|Int32||XmlEnum("""CERT""")|40|
||CLAT|Int32||XmlEnum("""CLAT""")|41|
||DOCY|Int32||XmlEnum("""DOCY""")|42|
||LAAW|Int32||XmlEnum("""LAAW""")|43|
||AWSH|Int32||XmlEnum("""AWSH""")|44|
||AWMO|Int32||XmlEnum("""AWMO""")|45|

---

## Enum ISO20022.Camt006001.PendingSettlement2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PCAP|Int32||XmlEnum("""PCAP""")|1|
||MINO|Int32||XmlEnum("""MINO""")|2|
||CPEC|Int32||XmlEnum("""CPEC""")|3|
||SBLO|Int32||XmlEnum("""SBLO""")|4|
||CYCL|Int32||XmlEnum("""CYCL""")|5|
||BATC|Int32||XmlEnum("""BATC""")|6|
||SDUT|Int32||XmlEnum("""SDUT""")|7|
||REFS|Int32||XmlEnum("""REFS""")|8|
||NCON|Int32||XmlEnum("""NCON""")|9|
||MONY|Int32||XmlEnum("""MONY""")|10|
||LALO|Int32||XmlEnum("""LALO""")|11|
||LACK|Int32||XmlEnum("""LACK""")|12|
||FUTU|Int32||XmlEnum("""FUTU""")|13|
||LINK|Int32||XmlEnum("""LINK""")|14|
||INCA|Int32||XmlEnum("""INCA""")|15|
||NOFX|Int32||XmlEnum("""NOFX""")|16|
||FLIM|Int32||XmlEnum("""FLIM""")|17|
||DEPO|Int32||XmlEnum("""DEPO""")|18|
||COLL|Int32||XmlEnum("""COLL""")|19|
||YCOL|Int32||XmlEnum("""YCOL""")|20|
||CMON|Int32||XmlEnum("""CMON""")|21|
||NMAS|Int32||XmlEnum("""NMAS""")|22|
||PART|Int32||XmlEnum("""PART""")|23|
||GUAD|Int32||XmlEnum("""GUAD""")|24|
||PREA|Int32||XmlEnum("""PREA""")|25|
||GLOB|Int32||XmlEnum("""GLOB""")|26|
||MUNO|Int32||XmlEnum("""MUNO""")|27|
||CLAC|Int32||XmlEnum("""CLAC""")|28|
||NEWI|Int32||XmlEnum("""NEWI""")|29|
||CHAS|Int32||XmlEnum("""CHAS""")|30|
||BLOC|Int32||XmlEnum("""BLOC""")|31|
||DOCC|Int32||XmlEnum("""DOCC""")|32|
||DOCY|Int32||XmlEnum("""DOCY""")|33|
||TAMM|Int32||XmlEnum("""TAMM""")|34|
||PHSE|Int32||XmlEnum("""PHSE""")|35|
||AWSH|Int32||XmlEnum("""AWSH""")|36|
||REFU|Int32||XmlEnum("""REFU""")|37|
||CAIS|Int32||XmlEnum("""CAIS""")|38|
||AWMO|Int32||XmlEnum("""AWMO""")|39|

---

## Enum ISO20022.Camt006001.PendingStatus4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SRML|Int32||XmlEnum("""SRML""")|1|
||AVLB|Int32||XmlEnum("""AVLB""")|2|
||SRBL|Int32||XmlEnum("""SRBL""")|3|
||RMLR|Int32||XmlEnum("""RMLR""")|4|
||SMLR|Int32||XmlEnum("""SMLR""")|5|
||PFST|Int32||XmlEnum("""PFST""")|6|
||PSTL|Int32||XmlEnum("""PSTL""")|7|
||PCAN|Int32||XmlEnum("""PCAN""")|8|
||SSPD|Int32||XmlEnum("""SSPD""")|9|
||STLM|Int32||XmlEnum("""STLM""")|10|
||STLE|Int32||XmlEnum("""STLE""")|11|
||UMAC|Int32||XmlEnum("""UMAC""")|12|
||INVD|Int32||XmlEnum("""INVD""")|13|
||AUTD|Int32||XmlEnum("""AUTD""")|14|
||MATD|Int32||XmlEnum("""MATD""")|15|
||VALD|Int32||XmlEnum("""VALD""")|16|
||ACPD|Int32||XmlEnum("""ACPD""")|17|

---

## Value ISO20022.Camt006001.PersonIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt006001.GenericPersonIdentification2>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Camt006001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Camt006001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt006001.PostalAddress27


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
|+|AdrTp|ISO20022.Camt006001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Camt006001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Value ISO20022.Camt006001.Priority1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt006001.Priority5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||URGT|Int32||XmlEnum("""URGT""")|1|
||NORM|Int32||XmlEnum("""NORM""")|2|
||LOWW|Int32||XmlEnum("""LOWW""")|3|
||HIGH|Int32||XmlEnum("""HIGH""")|4|

---

## Value ISO20022.Camt006001.ProprietaryStatusJustification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|String||XmlElement()||
|+|PrtryStsRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrtryStsRsn""",PrtryStsRsn,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Camt006001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Camt006001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt006001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt006001.QueueTransactionIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PosInQ|String||XmlElement()||
|+|QId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt006001.RequestType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt006001.GenericIdentification1||XmlElement()||
|+|Enqry|String||XmlElement()||
|+|PmtCtrl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Enqry,PmtCtrl))|

---

## Aspect ISO20022.Camt006001.ReturnTransactionV11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt006001.SupplementaryData1>||XmlElement()||
|+|RptOrErr|ISO20022.Camt006001.TransactionReportOrError7Choice||XmlElement()||
|+|MsgHdr|ISO20022.Camt006001.MessageHeader8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RptOrErr),validElement(MsgHdr))|

---

## Value ISO20022.Camt006001.SecuritiesTransactionReferences1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt006001.ShortPaymentIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstgAgt|ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrBkSttlmDt|DateTime||XmlElement()||
|+|UETR|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstgAgt),validPattern("""UETR""",UETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""))|

---

## Value ISO20022.Camt006001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt006001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt006001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Camt006001.SuspendedStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUBS|Int32||XmlEnum("""SUBS""")|1|
||SUBY|Int32||XmlEnum("""SUBY""")|2|

---

## Value ISO20022.Camt006001.System3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctId|ISO20022.Camt006001.AccountIdentification4Choice||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|MmbId|ISO20022.Camt006001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|SysId|ISO20022.Camt006001.MarketInfrastructureIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(MmbId),validElement(SysId))|

---

## Value ISO20022.Camt006001.Transaction159


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesTxRefs|ISO20022.Camt006001.SecuritiesTransactionReferences1||XmlElement()||
|+|AcctNtry|ISO20022.Camt006001.CashAccountAndEntry5||XmlElement()||
|+|Pmt|ISO20022.Camt006001.PaymentInstruction47||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|PmtFr|ISO20022.Camt006001.System3||XmlElement()||
|+|PmtTo|ISO20022.Camt006001.System3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesTxRefs),validElement(AcctNtry),validElement(Pmt),validElement(PmtFr),validElement(PmtTo))|

---

## Value ISO20022.Camt006001.TransactionOrError6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BizErr|global::System.Collections.Generic.List<ISO20022.Camt006001.ErrorHandling5>||XmlElement()||
|+|Tx|ISO20022.Camt006001.Transaction159||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""BizErr""",BizErr),validList("""BizErr""",BizErr),validElement(BizErr),validElement(Tx),validChoice(BizErr,Tx))|

---

## Value ISO20022.Camt006001.TransactionReport8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxOrErr|ISO20022.Camt006001.TransactionOrError6Choice||XmlElement()||
|+|PmtId|ISO20022.Camt006001.PaymentIdentification8Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxOrErr),validElement(PmtId))|

---

## Value ISO20022.Camt006001.TransactionReportOrError7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OprlErr|global::System.Collections.Generic.List<ISO20022.Camt006001.ErrorHandling5>||XmlElement()||
|+|BizRpt|ISO20022.Camt006001.Transactions11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""OprlErr""",OprlErr),validList("""OprlErr""",OprlErr),validElement(OprlErr),validElement(BizRpt),validChoice(OprlErr,BizRpt))|

---

## Value ISO20022.Camt006001.Transactions11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxRpt|global::System.Collections.Generic.List<ISO20022.Camt006001.TransactionReport8>||XmlElement()||
|+|TxsSummry|ISO20022.Camt006001.NumberAndSumOfTransactions2||XmlElement()||
|+|PmtCmonInf|ISO20022.Camt006001.PaymentCommon6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""TxRpt""",TxRpt),validList("""TxRpt""",TxRpt),validElement(TxRpt),validElement(TxsSummry),validElement(PmtCmonInf))|

---

## Enum ISO20022.Camt006001.UnmatchedStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ICUS|Int32||XmlEnum("""ICUS""")|1|
||TERM|Int32||XmlEnum("""TERM""")|2|
||LATE|Int32||XmlEnum("""LATE""")|3|
||DTRD|Int32||XmlEnum("""DTRD""")|4|
||SAFE|Int32||XmlEnum("""SAFE""")|5|
||NMAS|Int32||XmlEnum("""NMAS""")|6|
||NCRR|Int32||XmlEnum("""NCRR""")|7|
||IEXE|Int32||XmlEnum("""IEXE""")|8|
||CHAR|Int32||XmlEnum("""CHAR""")|9|
||CPCA|Int32||XmlEnum("""CPCA""")|10|
||ICAG|Int32||XmlEnum("""ICAG""")|11|
||RTGS|Int32||XmlEnum("""RTGS""")|12|
||REGD|Int32||XmlEnum("""REGD""")|13|
||FORF|Int32||XmlEnum("""FORF""")|14|
||PODU|Int32||XmlEnum("""PODU""")|15|
||PLCE|Int32||XmlEnum("""PLCE""")|16|
||FRAP|Int32||XmlEnum("""FRAP""")|17|
||IIND|Int32||XmlEnum("""IIND""")|18|
||PHYS|Int32||XmlEnum("""PHYS""")|19|
||REPP|Int32||XmlEnum("""REPP""")|20|
||REPA|Int32||XmlEnum("""REPA""")|21|
||RERT|Int32||XmlEnum("""RERT""")|22|
||CLAT|Int32||XmlEnum("""CLAT""")|23|
||REPO|Int32||XmlEnum("""REPO""")|24|
||RSPR|Int32||XmlEnum("""RSPR""")|25|
||DTRA|Int32||XmlEnum("""DTRA""")|26|
||VASU|Int32||XmlEnum("""VASU""")|27|
||DSEC|Int32||XmlEnum("""DSEC""")|28|
||SETR|Int32||XmlEnum("""SETR""")|29|
||CADE|Int32||XmlEnum("""CADE""")|30|
||DQUA|Int32||XmlEnum("""DQUA""")|31|
||DDEA|Int32||XmlEnum("""DDEA""")|32|
||DMON|Int32||XmlEnum("""DMON""")|33|
||DEPT|Int32||XmlEnum("""DEPT""")|34|
||DELN|Int32||XmlEnum("""DELN""")|35|
||DDAT|Int32||XmlEnum("""DDAT""")|36|
||CMIS|Int32||XmlEnum("""CMIS""")|37|

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

