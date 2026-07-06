# camt.005.001.11
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt005001.AccountCashEntryReturnCriteria3 {
        + AcctOwnrInd  : String
        + AcctSvcrInd  : String
        + NtryDtInd  : String
        + NtryStsInd  : String
        + AcctCcyInd  : String
        + NtryAmtInd  : String
        + AcctTpInd  : String
        + NtryRefInd  : String
    }
    class ISO20022.Camt005001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt005001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt005001.AccountIdentification4Choice *-- ISO20022.Camt005001.GenericAccountIdentification1
    class ISO20022.Camt005001.AccountIdentificationSearchCriteria2Choice {
        + NCTTxt  : String
        + CTTxt  : String
        + EQ  : ISO20022.Camt005001.AccountIdentification4Choice
    }
    ISO20022.Camt005001.AccountIdentificationSearchCriteria2Choice *-- ISO20022.Camt005001.AccountIdentification4Choice
    class ISO20022.Camt005001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt005001.ActiveAmountRange3Choice {
        + CcyAndAmtRg  : ISO20022.Camt005001.ActiveCurrencyAndAmountRange3
        + ImpldCcyAndAmtRg  : ISO20022.Camt005001.ImpliedCurrencyAndAmountRange1
    }
    ISO20022.Camt005001.ActiveAmountRange3Choice *-- ISO20022.Camt005001.ActiveCurrencyAndAmountRange3
    ISO20022.Camt005001.ActiveAmountRange3Choice *-- ISO20022.Camt005001.ImpliedCurrencyAndAmountRange1
    class ISO20022.Camt005001.ActiveCurrencyAndAmountRange3 {
        + Ccy  : String
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt005001.ImpliedCurrencyAmountRange1Choice
    }
    ISO20022.Camt005001.ActiveCurrencyAndAmountRange3 *-- ISO20022.Camt005001.ImpliedCurrencyAmountRange1Choice
    class ISO20022.Camt005001.ActiveOrHistoricAmountRange2Choice {
        + CcyAndAmtRg  : ISO20022.Camt005001.ActiveOrHistoricCurrencyAndAmountRange2
        + ImpldCcyAndAmtRg  : ISO20022.Camt005001.ImpliedCurrencyAndAmountRange1
    }
    ISO20022.Camt005001.ActiveOrHistoricAmountRange2Choice *-- ISO20022.Camt005001.ActiveOrHistoricCurrencyAndAmountRange2
    ISO20022.Camt005001.ActiveOrHistoricAmountRange2Choice *-- ISO20022.Camt005001.ImpliedCurrencyAndAmountRange1
    class ISO20022.Camt005001.ActiveOrHistoricCurrencyAndAmountRange2 {
        + Ccy  : String
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt005001.ImpliedCurrencyAmountRange1Choice
    }
    ISO20022.Camt005001.ActiveOrHistoricCurrencyAndAmountRange2 *-- ISO20022.Camt005001.ImpliedCurrencyAmountRange1Choice
    class ISO20022.Camt005001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt005001.AddressType3Choice {
        + Prtry  : ISO20022.Camt005001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt005001.AddressType3Choice *-- ISO20022.Camt005001.GenericIdentification30
    class ISO20022.Camt005001.AmountRangeBoundary1 {
        + Incl  : String
        + BdryAmt  : Decimal
    }
    class ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Camt005001.BranchData5
        + FinInstnId  : ISO20022.Camt005001.FinancialInstitutionIdentification23
    }
    ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt005001.BranchData5
    ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt005001.FinancialInstitutionIdentification23
    class ISO20022.Camt005001.BranchData5 {
        + PstlAdr  : ISO20022.Camt005001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt005001.BranchData5 *-- ISO20022.Camt005001.PostalAddress27
    class ISO20022.Camt005001.CashAccountEntrySearch8 {
        + AcctSvcr  : ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
        + AcctOwnr  : ISO20022.Camt005001.PartyIdentification272
        + NtryDt  : global::System.Collections.Generic.List~ISO20022.Camt005001.DateAndDateTimeSearch3Choice~
        + NtrySts  : global::System.Collections.Generic.List~String~
        + CdtDbtInd  : String
        + NtryAmtCcy  : global::System.Collections.Generic.List~String~
        + NtryAmt  : global::System.Collections.Generic.List~ISO20022.Camt005001.ActiveOrHistoricAmountRange2Choice~
        + AcctId  : global::System.Collections.Generic.List~ISO20022.Camt005001.AccountIdentificationSearchCriteria2Choice~
    }
    ISO20022.Camt005001.CashAccountEntrySearch8 *-- ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt005001.CashAccountEntrySearch8 *-- ISO20022.Camt005001.PartyIdentification272
    ISO20022.Camt005001.CashAccountEntrySearch8 *-- ISO20022.Camt005001.DateAndDateTimeSearch3Choice
    ISO20022.Camt005001.CashAccountEntrySearch8 *-- ISO20022.Camt005001.ActiveOrHistoricAmountRange2Choice
    ISO20022.Camt005001.CashAccountEntrySearch8 *-- ISO20022.Camt005001.AccountIdentificationSearchCriteria2Choice
    class ISO20022.Camt005001.CashPaymentStatus2Code {
        FINL = 1
        PDNG = 2
    }
    class ISO20022.Camt005001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt005001.ClearingSystemIdentification3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt005001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt005001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt005001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt005001.ClearingSystemIdentification2Choice
    class ISO20022.Camt005001.Contact13 {
        + PrefrdMtd  : String
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt005001.OtherContact1~
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
    ISO20022.Camt005001.Contact13 *-- ISO20022.Camt005001.OtherContact1
    class ISO20022.Camt005001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Camt005001.DateAndDateTimeSearch3Choice {
        + DtSch  : ISO20022.Camt005001.DatePeriodSearch1Choice
        + DtTmSch  : ISO20022.Camt005001.DateTimePeriod1Choice
    }
    ISO20022.Camt005001.DateAndDateTimeSearch3Choice *-- ISO20022.Camt005001.DatePeriodSearch1Choice
    ISO20022.Camt005001.DateAndDateTimeSearch3Choice *-- ISO20022.Camt005001.DateTimePeriod1Choice
    class ISO20022.Camt005001.DateAndPlaceOfBirth1 {
        + CtryOfBirth  : String
        + CityOfBirth  : String
        + PrvcOfBirth  : String
        + BirthDt  : DateTime
    }
    class ISO20022.Camt005001.DatePeriod2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Camt005001.DatePeriodSearch1Choice {
        + NEQDt  : DateTime
        + EQDt  : DateTime
        + FrToDt  : ISO20022.Camt005001.DatePeriod2
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    ISO20022.Camt005001.DatePeriodSearch1Choice *-- ISO20022.Camt005001.DatePeriod2
    class ISO20022.Camt005001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Camt005001.DateTimePeriod1Choice {
        + DtTmRg  : ISO20022.Camt005001.DateTimePeriod1
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    ISO20022.Camt005001.DateTimePeriod1Choice *-- ISO20022.Camt005001.DateTimePeriod1
    class ISO20022.Camt005001.EntryStatus1Code {
        FUTR = 1
        PDNG = 2
        BOOK = 3
    }
    class ISO20022.Camt005001.FinalStatusCode {
        FNLD = 1
        CAND = 2
        RJTD = 3
        STLD = 4
    }
    class ISO20022.Camt005001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt005001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Camt005001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt005001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt005001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt005001.FinancialInstitutionIdentification23 *-- ISO20022.Camt005001.GenericFinancialIdentification1
    ISO20022.Camt005001.FinancialInstitutionIdentification23 *-- ISO20022.Camt005001.PostalAddress27
    ISO20022.Camt005001.FinancialInstitutionIdentification23 *-- ISO20022.Camt005001.ClearingSystemMemberIdentification2
    class ISO20022.Camt005001.FromToAmountRange1 {
        + ToAmt  : ISO20022.Camt005001.AmountRangeBoundary1
        + FrAmt  : ISO20022.Camt005001.AmountRangeBoundary1
    }
    ISO20022.Camt005001.FromToAmountRange1 *-- ISO20022.Camt005001.AmountRangeBoundary1
    ISO20022.Camt005001.FromToAmountRange1 *-- ISO20022.Camt005001.AmountRangeBoundary1
    class ISO20022.Camt005001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt005001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt005001.GenericAccountIdentification1 *-- ISO20022.Camt005001.AccountSchemeName1Choice
    class ISO20022.Camt005001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt005001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt005001.GenericFinancialIdentification1 *-- ISO20022.Camt005001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt005001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Camt005001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt005001.GenericOrganisationIdentification3 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt005001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt005001.GenericOrganisationIdentification3 *-- ISO20022.Camt005001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Camt005001.GenericPersonIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt005001.PersonIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt005001.GenericPersonIdentification2 *-- ISO20022.Camt005001.PersonIdentificationSchemeName1Choice
    class ISO20022.Camt005001.GetTransactionV11 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt005001.SupplementaryData1~
        + TxQryDef  : ISO20022.Camt005001.TransactionQuery8
        + MsgHdr  : ISO20022.Camt005001.MessageHeader9
    }
    ISO20022.Camt005001.GetTransactionV11 *-- ISO20022.Camt005001.SupplementaryData1
    ISO20022.Camt005001.GetTransactionV11 *-- ISO20022.Camt005001.TransactionQuery8
    ISO20022.Camt005001.GetTransactionV11 *-- ISO20022.Camt005001.MessageHeader9
    class ISO20022.Camt005001.ImpliedCurrencyAmountRange1Choice {
        + NEQAmt  : Decimal
        + EQAmt  : Decimal
        + FrToAmt  : ISO20022.Camt005001.FromToAmountRange1
        + ToAmt  : ISO20022.Camt005001.AmountRangeBoundary1
        + FrAmt  : ISO20022.Camt005001.AmountRangeBoundary1
    }
    ISO20022.Camt005001.ImpliedCurrencyAmountRange1Choice *-- ISO20022.Camt005001.FromToAmountRange1
    ISO20022.Camt005001.ImpliedCurrencyAmountRange1Choice *-- ISO20022.Camt005001.AmountRangeBoundary1
    ISO20022.Camt005001.ImpliedCurrencyAmountRange1Choice *-- ISO20022.Camt005001.AmountRangeBoundary1
    class ISO20022.Camt005001.ImpliedCurrencyAndAmountRange1 {
        + CdtDbtInd  : String
        + Amt  : ISO20022.Camt005001.ImpliedCurrencyAmountRange1Choice
    }
    ISO20022.Camt005001.ImpliedCurrencyAndAmountRange1 *-- ISO20022.Camt005001.ImpliedCurrencyAmountRange1Choice
    class ISO20022.Camt005001.Instruction1Code {
        TFRO = 1
        TTIL = 2
        PBEN = 3
    }
    class ISO20022.Camt005001.InstructionStatusReturnCriteria1 {
        + PmtInstrStsRsnInd  : String
        + PmtInstrStsDtTmInd  : String
        + PmtInstrStsInd  : String
    }
    class ISO20022.Camt005001.InstructionStatusSearch5 {
        + PrtryStsRsn  : String
        + PmtInstrStsDtTm  : ISO20022.Camt005001.DateTimePeriod1Choice
        + PmtInstrSts  : ISO20022.Camt005001.PaymentStatusCodeSearch2Choice
    }
    ISO20022.Camt005001.InstructionStatusSearch5 *-- ISO20022.Camt005001.DateTimePeriod1Choice
    ISO20022.Camt005001.InstructionStatusSearch5 *-- ISO20022.Camt005001.PaymentStatusCodeSearch2Choice
    class ISO20022.Camt005001.LongPaymentIdentification4 {
        + EndToEndId  : String
        + NtryTp  : String
        + InstdAgt  : ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
        + InstgAgt  : ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
        + PmtMtd  : ISO20022.Camt005001.PaymentOrigin1Choice
        + IntrBkSttlmDt  : DateTime
        + IntrBkSttlmAmt  : Decimal
        + UETR  : String
        + TxId  : String
    }
    ISO20022.Camt005001.LongPaymentIdentification4 *-- ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt005001.LongPaymentIdentification4 *-- ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt005001.LongPaymentIdentification4 *-- ISO20022.Camt005001.PaymentOrigin1Choice
    class ISO20022.Camt005001.MessageHeader9 {
        + ReqTp  : ISO20022.Camt005001.RequestType4Choice
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    ISO20022.Camt005001.MessageHeader9 *-- ISO20022.Camt005001.RequestType4Choice
    class ISO20022.Camt005001.NamePrefix2Code {
        MIKS = 1
        MIST = 2
        MISS = 3
        MADM = 4
        DOCT = 5
    }
    class ISO20022.Camt005001.OrganisationIdentification39 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt005001.GenericOrganisationIdentification3~
        + LEI  : String
        + AnyBIC  : String
    }
    ISO20022.Camt005001.OrganisationIdentification39 *-- ISO20022.Camt005001.GenericOrganisationIdentification3
    class ISO20022.Camt005001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt005001.OtherContact1 {
        + Id  : String
        + ChanlTp  : String
    }
    class ISO20022.Camt005001.Party50Choice {
        + Agt  : ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
        + Pty  : ISO20022.Camt005001.PartyIdentification272
    }
    ISO20022.Camt005001.Party50Choice *-- ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt005001.Party50Choice *-- ISO20022.Camt005001.PartyIdentification272
    class ISO20022.Camt005001.Party52Choice {
        + PrvtId  : ISO20022.Camt005001.PersonIdentification18
        + OrgId  : ISO20022.Camt005001.OrganisationIdentification39
    }
    ISO20022.Camt005001.Party52Choice *-- ISO20022.Camt005001.PersonIdentification18
    ISO20022.Camt005001.Party52Choice *-- ISO20022.Camt005001.OrganisationIdentification39
    class ISO20022.Camt005001.PartyIdentification272 {
        + CtctDtls  : ISO20022.Camt005001.Contact13
        + CtryOfRes  : String
        + Id  : ISO20022.Camt005001.Party52Choice
        + PstlAdr  : ISO20022.Camt005001.PostalAddress27
        + Nm  : String
    }
    ISO20022.Camt005001.PartyIdentification272 *-- ISO20022.Camt005001.Contact13
    ISO20022.Camt005001.PartyIdentification272 *-- ISO20022.Camt005001.Party52Choice
    ISO20022.Camt005001.PartyIdentification272 *-- ISO20022.Camt005001.PostalAddress27
    class ISO20022.Camt005001.PaymentIdentification8Choice {
        + PrtryId  : String
        + ShrtBizId  : ISO20022.Camt005001.ShortPaymentIdentification4
        + LngBizId  : ISO20022.Camt005001.LongPaymentIdentification4
        + QId  : ISO20022.Camt005001.QueueTransactionIdentification1
        + UETR  : String
        + TxId  : String
    }
    ISO20022.Camt005001.PaymentIdentification8Choice *-- ISO20022.Camt005001.ShortPaymentIdentification4
    ISO20022.Camt005001.PaymentIdentification8Choice *-- ISO20022.Camt005001.LongPaymentIdentification4
    ISO20022.Camt005001.PaymentIdentification8Choice *-- ISO20022.Camt005001.QueueTransactionIdentification1
    class ISO20022.Camt005001.PaymentInstrument1Code {
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
    class ISO20022.Camt005001.PaymentOrigin1Choice {
        + Instrm  : String
        + Prtry  : String
        + XMLMsgNm  : String
        + FINMT  : String
    }
    class ISO20022.Camt005001.PaymentReturnCriteria4 {
        + CdtrInd  : String
        + CdtrAgtInd  : String
        + IntrmyInd  : String
        + InstdRmbrsmntAgtInd  : String
        + InstgRmbrsmntAgtInd  : String
        + DbtrAgtInd  : String
        + DbtrInd  : String
        + PmtMtdInd  : String
        + EndToEndIdInd  : String
        + IntrBkSttlmDtInd  : String
        + TxIdInd  : String
        + PmtTpInd  : String
        + PmtMTInd  : String
        + InstrCpyInd  : String
        + PurpInd  : String
        + PrcgVldtyTmInd  : String
        + PrtyInd  : String
        + IntrBkSttlmAmtInd  : String
        + CdtDbtInd  : String
        + InstdAmtInd  : String
        + InstrStsRtrCrit  : ISO20022.Camt005001.InstructionStatusReturnCriteria1
        + InstrInd  : String
        + ReqdExctnDtInd  : String
        + MsgIdInd  : String
    }
    ISO20022.Camt005001.PaymentReturnCriteria4 *-- ISO20022.Camt005001.InstructionStatusReturnCriteria1
    class ISO20022.Camt005001.PaymentSearch10 {
        + Pties  : ISO20022.Camt005001.PaymentTransactionParty4
        + EndToEndId  : global::System.Collections.Generic.List~String~
        + IntrBkSttlmDt  : global::System.Collections.Generic.List~DateTime~
        + UETR  : global::System.Collections.Generic.List~String~
        + TxId  : global::System.Collections.Generic.List~String~
        + Instr  : global::System.Collections.Generic.List~String~
        + PrcgVldtyTm  : global::System.Collections.Generic.List~ISO20022.Camt005001.DateTimePeriod1Choice~
        + Prty  : global::System.Collections.Generic.List~ISO20022.Camt005001.Priority1Choice~
        + PmtTp  : global::System.Collections.Generic.List~ISO20022.Camt005001.PaymentType4Choice~
        + PmtMtd  : global::System.Collections.Generic.List~ISO20022.Camt005001.PaymentOrigin1Choice~
        + IntrBkSttlmAmtCcy  : global::System.Collections.Generic.List~String~
        + IntrBkSttlmAmt  : global::System.Collections.Generic.List~ISO20022.Camt005001.ActiveAmountRange3Choice~
        + CdtDbtInd  : String
        + InstdAmtCcy  : global::System.Collections.Generic.List~String~
        + InstdAmt  : global::System.Collections.Generic.List~ISO20022.Camt005001.ActiveOrHistoricAmountRange2Choice~
        + Sts  : global::System.Collections.Generic.List~ISO20022.Camt005001.InstructionStatusSearch5~
        + PmtId  : global::System.Collections.Generic.List~ISO20022.Camt005001.PaymentIdentification8Choice~
        + ReqdExctnDt  : global::System.Collections.Generic.List~ISO20022.Camt005001.DateAndDateTimeSearch3Choice~
        + MsgId  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Camt005001.PaymentSearch10 *-- ISO20022.Camt005001.PaymentTransactionParty4
    ISO20022.Camt005001.PaymentSearch10 *-- ISO20022.Camt005001.DateTimePeriod1Choice
    ISO20022.Camt005001.PaymentSearch10 *-- ISO20022.Camt005001.Priority1Choice
    ISO20022.Camt005001.PaymentSearch10 *-- ISO20022.Camt005001.PaymentType4Choice
    ISO20022.Camt005001.PaymentSearch10 *-- ISO20022.Camt005001.PaymentOrigin1Choice
    ISO20022.Camt005001.PaymentSearch10 *-- ISO20022.Camt005001.ActiveAmountRange3Choice
    ISO20022.Camt005001.PaymentSearch10 *-- ISO20022.Camt005001.ActiveOrHistoricAmountRange2Choice
    ISO20022.Camt005001.PaymentSearch10 *-- ISO20022.Camt005001.InstructionStatusSearch5
    ISO20022.Camt005001.PaymentSearch10 *-- ISO20022.Camt005001.PaymentIdentification8Choice
    ISO20022.Camt005001.PaymentSearch10 *-- ISO20022.Camt005001.DateAndDateTimeSearch3Choice
    class ISO20022.Camt005001.PaymentStatusCodeSearch2Choice {
        + PdgAndFnlSts  : String
        + FnlSts  : String
        + PdgSts  : String
    }
    class ISO20022.Camt005001.PaymentTransactionParty4 {
        + UltmtCdtr  : ISO20022.Camt005001.Party50Choice
        + Cdtr  : ISO20022.Camt005001.Party50Choice
        + CdtrAgt  : ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
        + IntrmyAgt3  : ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
        + IntrmyAgt2  : ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
        + IntrmyAgt1  : ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
        + InstdRmbrsmntAgt  : ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
        + InstgRmbrsmntAgt  : ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
        + DbtrAgt  : ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
        + Dbtr  : ISO20022.Camt005001.Party50Choice
        + UltmtDbtr  : ISO20022.Camt005001.Party50Choice
        + InstdAgt  : ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
        + InstgAgt  : ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    }
    ISO20022.Camt005001.PaymentTransactionParty4 *-- ISO20022.Camt005001.Party50Choice
    ISO20022.Camt005001.PaymentTransactionParty4 *-- ISO20022.Camt005001.Party50Choice
    ISO20022.Camt005001.PaymentTransactionParty4 *-- ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt005001.PaymentTransactionParty4 *-- ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt005001.PaymentTransactionParty4 *-- ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt005001.PaymentTransactionParty4 *-- ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt005001.PaymentTransactionParty4 *-- ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt005001.PaymentTransactionParty4 *-- ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt005001.PaymentTransactionParty4 *-- ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt005001.PaymentTransactionParty4 *-- ISO20022.Camt005001.Party50Choice
    ISO20022.Camt005001.PaymentTransactionParty4 *-- ISO20022.Camt005001.Party50Choice
    ISO20022.Camt005001.PaymentTransactionParty4 *-- ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt005001.PaymentTransactionParty4 *-- ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    class ISO20022.Camt005001.PaymentType3Code {
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
    class ISO20022.Camt005001.PaymentType4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt005001.PendingStatus4Code {
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
    class ISO20022.Camt005001.PersonIdentification18 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Camt005001.GenericPersonIdentification2~
        + DtAndPlcOfBirth  : ISO20022.Camt005001.DateAndPlaceOfBirth1
    }
    ISO20022.Camt005001.PersonIdentification18 *-- ISO20022.Camt005001.GenericPersonIdentification2
    ISO20022.Camt005001.PersonIdentification18 *-- ISO20022.Camt005001.DateAndPlaceOfBirth1
    class ISO20022.Camt005001.PersonIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt005001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Camt005001.AddressType3Choice
    }
    ISO20022.Camt005001.PostalAddress27 *-- ISO20022.Camt005001.AddressType3Choice
    class ISO20022.Camt005001.PreferredContactMethod2Code {
        PHON = 1
        ONLI = 2
        CELL = 3
        LETT = 4
        FAXX = 5
        MAIL = 6
    }
    class ISO20022.Camt005001.Priority1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt005001.Priority5Code {
        URGT = 1
        NORM = 2
        LOWW = 3
        HIGH = 4
    }
    class ISO20022.Camt005001.QueryType2Code {
        DELD = 1
        MODF = 2
        CHNG = 3
        ALLL = 4
    }
    class ISO20022.Camt005001.QueueTransactionIdentification1 {
        + PosInQ  : String
        + QId  : String
    }
    class ISO20022.Camt005001.ReportIndicator1Code {
        PRPR = 1
        STND = 2
    }
    class ISO20022.Camt005001.RequestType4Choice {
        + Prtry  : ISO20022.Camt005001.GenericIdentification1
        + Enqry  : String
        + PmtCtrl  : String
    }
    ISO20022.Camt005001.RequestType4Choice *-- ISO20022.Camt005001.GenericIdentification1
    class ISO20022.Camt005001.ShortPaymentIdentification4 {
        + InstgAgt  : ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
        + IntrBkSttlmDt  : DateTime
        + UETR  : String
        + TxId  : String
    }
    ISO20022.Camt005001.ShortPaymentIdentification4 *-- ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    class ISO20022.Camt005001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt005001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt005001.SupplementaryData1 *-- ISO20022.Camt005001.SupplementaryDataEnvelope1
    class ISO20022.Camt005001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Camt005001.SystemReturnCriteria2 {
        + AcctIdInd  : String
        + CtryIdInd  : String
        + MmbIdInd  : String
        + SysIdInd  : String
    }
    class ISO20022.Camt005001.SystemSearch5 {
        + AcctId  : ISO20022.Camt005001.AccountIdentification4Choice
        + Ctry  : String
        + MmbId  : global::System.Collections.Generic.List~ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8~
        + SysId  : global::System.Collections.Generic.List~ISO20022.Camt005001.ClearingSystemIdentification3Choice~
    }
    ISO20022.Camt005001.SystemSearch5 *-- ISO20022.Camt005001.AccountIdentification4Choice
    ISO20022.Camt005001.SystemSearch5 *-- ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt005001.SystemSearch5 *-- ISO20022.Camt005001.ClearingSystemIdentification3Choice
    class ISO20022.Camt005001.TransactionCriteria11 {
        + RtrCrit  : ISO20022.Camt005001.TransactionReturnCriteria5
        + StmtRpt  : String
        + SchCrit  : global::System.Collections.Generic.List~ISO20022.Camt005001.TransactionSearchCriteria11~
        + NewQryNm  : String
    }
    ISO20022.Camt005001.TransactionCriteria11 *-- ISO20022.Camt005001.TransactionReturnCriteria5
    ISO20022.Camt005001.TransactionCriteria11 *-- ISO20022.Camt005001.TransactionSearchCriteria11
    class ISO20022.Camt005001.TransactionCriteria8Choice {
        + NewCrit  : ISO20022.Camt005001.TransactionCriteria11
        + QryNm  : String
    }
    ISO20022.Camt005001.TransactionCriteria8Choice *-- ISO20022.Camt005001.TransactionCriteria11
    class ISO20022.Camt005001.TransactionQuery8 {
        + TxCrit  : ISO20022.Camt005001.TransactionCriteria8Choice
        + QryTp  : String
    }
    ISO20022.Camt005001.TransactionQuery8 *-- ISO20022.Camt005001.TransactionCriteria8Choice
    class ISO20022.Camt005001.TransactionReturnCriteria5 {
        + PmtRtrCrit  : ISO20022.Camt005001.PaymentReturnCriteria4
        + AcctCshNtryRtrCrit  : ISO20022.Camt005001.AccountCashEntryReturnCriteria3
        + PmtFrRtrCrit  : ISO20022.Camt005001.SystemReturnCriteria2
        + PmtToRtrCrit  : ISO20022.Camt005001.SystemReturnCriteria2
    }
    ISO20022.Camt005001.TransactionReturnCriteria5 *-- ISO20022.Camt005001.PaymentReturnCriteria4
    ISO20022.Camt005001.TransactionReturnCriteria5 *-- ISO20022.Camt005001.AccountCashEntryReturnCriteria3
    ISO20022.Camt005001.TransactionReturnCriteria5 *-- ISO20022.Camt005001.SystemReturnCriteria2
    ISO20022.Camt005001.TransactionReturnCriteria5 *-- ISO20022.Camt005001.SystemReturnCriteria2
    class ISO20022.Camt005001.TransactionSearchCriteria11 {
        + AcctNtrySch  : ISO20022.Camt005001.CashAccountEntrySearch8
        + PmtSch  : ISO20022.Camt005001.PaymentSearch10
        + PmtFr  : global::System.Collections.Generic.List~ISO20022.Camt005001.SystemSearch5~
        + PmtTo  : global::System.Collections.Generic.List~ISO20022.Camt005001.SystemSearch5~
    }
    ISO20022.Camt005001.TransactionSearchCriteria11 *-- ISO20022.Camt005001.CashAccountEntrySearch8
    ISO20022.Camt005001.TransactionSearchCriteria11 *-- ISO20022.Camt005001.PaymentSearch10
    ISO20022.Camt005001.TransactionSearchCriteria11 *-- ISO20022.Camt005001.SystemSearch5
    ISO20022.Camt005001.TransactionSearchCriteria11 *-- ISO20022.Camt005001.SystemSearch5
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

## Value ISO20022.Camt005001.AccountCashEntryReturnCriteria3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOwnrInd|String||XmlElement()||
|+|AcctSvcrInd|String||XmlElement()||
|+|NtryDtInd|String||XmlElement()||
|+|NtryStsInd|String||XmlElement()||
|+|AcctCcyInd|String||XmlElement()||
|+|NtryAmtInd|String||XmlElement()||
|+|AcctTpInd|String||XmlElement()||
|+|NtryRefInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt005001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt005001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt005001.AccountIdentificationSearchCriteria2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NCTTxt|String||XmlElement()||
|+|CTTxt|String||XmlElement()||
|+|EQ|ISO20022.Camt005001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EQ),validChoice(NCTTxt,CTTxt,EQ))|

---

## Value ISO20022.Camt005001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt005001.ActiveAmountRange3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyAndAmtRg|ISO20022.Camt005001.ActiveCurrencyAndAmountRange3||XmlElement()||
|+|ImpldCcyAndAmtRg|ISO20022.Camt005001.ImpliedCurrencyAndAmountRange1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CcyAndAmtRg),validElement(ImpldCcyAndAmtRg),validChoice(CcyAndAmtRg,ImpldCcyAndAmtRg))|

---

## Value ISO20022.Camt005001.ActiveCurrencyAndAmountRange3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt005001.ImpliedCurrencyAmountRange1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Amt))|

---

## Value ISO20022.Camt005001.ActiveOrHistoricAmountRange2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CcyAndAmtRg|ISO20022.Camt005001.ActiveOrHistoricCurrencyAndAmountRange2||XmlElement()||
|+|ImpldCcyAndAmtRg|ISO20022.Camt005001.ImpliedCurrencyAndAmountRange1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CcyAndAmtRg),validElement(ImpldCcyAndAmtRg),validChoice(CcyAndAmtRg,ImpldCcyAndAmtRg))|

---

## Value ISO20022.Camt005001.ActiveOrHistoricCurrencyAndAmountRange2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt005001.ImpliedCurrencyAmountRange1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Amt))|

---

## Enum ISO20022.Camt005001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt005001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt005001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt005001.AmountRangeBoundary1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Incl|String||XmlElement()||
|+|BdryAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt005001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Camt005001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt005001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt005001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Camt005001.CashAccountEntrySearch8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|AcctOwnr|ISO20022.Camt005001.PartyIdentification272||XmlElement()||
|+|NtryDt|global::System.Collections.Generic.List<ISO20022.Camt005001.DateAndDateTimeSearch3Choice>||XmlElement()||
|+|NtrySts|global::System.Collections.Generic.List<String>||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|NtryAmtCcy|global::System.Collections.Generic.List<String>||XmlElement()||
|+|NtryAmt|global::System.Collections.Generic.List<ISO20022.Camt005001.ActiveOrHistoricAmountRange2Choice>||XmlElement()||
|+|AcctId|global::System.Collections.Generic.List<ISO20022.Camt005001.AccountIdentificationSearchCriteria2Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcr),validElement(AcctOwnr),validList("""NtryDt""",NtryDt),validElement(NtryDt),validPattern("""NtryAmtCcy""",NtryAmtCcy,"""[A-Z]{3,3}"""),validList("""NtryAmt""",NtryAmt),validElement(NtryAmt),validList("""AcctId""",AcctId),validElement(AcctId))|

---

## Enum ISO20022.Camt005001.CashPaymentStatus2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FINL|Int32||XmlEnum("""FINL""")|1|
||PDNG|Int32||XmlEnum("""PDNG""")|2|

---

## Value ISO20022.Camt005001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt005001.ClearingSystemIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt005001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt005001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Value ISO20022.Camt005001.Contact13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrefrdMtd|String||XmlElement()||
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt005001.OtherContact1>||XmlElement()||
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

## Enum ISO20022.Camt005001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Camt005001.DateAndDateTimeSearch3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtSch|ISO20022.Camt005001.DatePeriodSearch1Choice||XmlElement()||
|+|DtTmSch|ISO20022.Camt005001.DateTimePeriod1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtSch),validElement(DtTmSch),validChoice(DtSch,DtTmSch))|

---

## Value ISO20022.Camt005001.DateAndPlaceOfBirth1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtryOfBirth|String||XmlElement()||
|+|CityOfBirth|String||XmlElement()||
|+|PrvcOfBirth|String||XmlElement()||
|+|BirthDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CtryOfBirth""",CtryOfBirth,"""[A-Z]{2,2}"""))|

---

## Value ISO20022.Camt005001.DatePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt005001.DatePeriodSearch1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NEQDt|DateTime||XmlElement()||
|+|EQDt|DateTime||XmlElement()||
|+|FrToDt|ISO20022.Camt005001.DatePeriod2||XmlElement()||
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToDt),validChoice(NEQDt,EQDt,FrToDt,ToDt,FrDt))|

---

## Value ISO20022.Camt005001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt005001.DateTimePeriod1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTmRg|ISO20022.Camt005001.DateTimePeriod1||XmlElement()||
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtTmRg),validChoice(DtTmRg,ToDtTm,FrDtTm))|

---

## Type ISO20022.Camt005001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GetTx|ISO20022.Camt005001.GetTransactionV11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GetTx))|

---

## Enum ISO20022.Camt005001.EntryStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FUTR|Int32||XmlEnum("""FUTR""")|1|
||PDNG|Int32||XmlEnum("""PDNG""")|2|
||BOOK|Int32||XmlEnum("""BOOK""")|3|

---

## Enum ISO20022.Camt005001.FinalStatusCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FNLD|Int32||XmlEnum("""FNLD""")|1|
||CAND|Int32||XmlEnum("""CAND""")|2|
||RJTD|Int32||XmlEnum("""RJTD""")|3|
||STLD|Int32||XmlEnum("""STLD""")|4|

---

## Value ISO20022.Camt005001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt005001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt005001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt005001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt005001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt005001.FromToAmountRange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToAmt|ISO20022.Camt005001.AmountRangeBoundary1||XmlElement()||
|+|FrAmt|ISO20022.Camt005001.AmountRangeBoundary1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ToAmt),validElement(FrAmt))|

---

## Value ISO20022.Camt005001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt005001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt005001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt005001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt005001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt005001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt005001.GenericOrganisationIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt005001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt005001.GenericPersonIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt005001.PersonIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Aspect ISO20022.Camt005001.GetTransactionV11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt005001.SupplementaryData1>||XmlElement()||
|+|TxQryDef|ISO20022.Camt005001.TransactionQuery8||XmlElement()||
|+|MsgHdr|ISO20022.Camt005001.MessageHeader9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TxQryDef),validElement(MsgHdr))|

---

## Value ISO20022.Camt005001.ImpliedCurrencyAmountRange1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NEQAmt|Decimal||XmlElement()||
|+|EQAmt|Decimal||XmlElement()||
|+|FrToAmt|ISO20022.Camt005001.FromToAmountRange1||XmlElement()||
|+|ToAmt|ISO20022.Camt005001.AmountRangeBoundary1||XmlElement()||
|+|FrAmt|ISO20022.Camt005001.AmountRangeBoundary1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrToAmt),validElement(ToAmt),validElement(FrAmt),validChoice(NEQAmt,EQAmt,FrToAmt,ToAmt,FrAmt))|

---

## Value ISO20022.Camt005001.ImpliedCurrencyAndAmountRange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Camt005001.ImpliedCurrencyAmountRange1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Enum ISO20022.Camt005001.Instruction1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TFRO|Int32||XmlEnum("""TFRO""")|1|
||TTIL|Int32||XmlEnum("""TTIL""")|2|
||PBEN|Int32||XmlEnum("""PBEN""")|3|

---

## Value ISO20022.Camt005001.InstructionStatusReturnCriteria1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtInstrStsRsnInd|String||XmlElement()||
|+|PmtInstrStsDtTmInd|String||XmlElement()||
|+|PmtInstrStsInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt005001.InstructionStatusSearch5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryStsRsn|String||XmlElement()||
|+|PmtInstrStsDtTm|ISO20022.Camt005001.DateTimePeriod1Choice||XmlElement()||
|+|PmtInstrSts|ISO20022.Camt005001.PaymentStatusCodeSearch2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrtryStsRsn""",PrtryStsRsn,"""[a-zA-Z0-9]{1,4}"""),validElement(PmtInstrStsDtTm),validElement(PmtInstrSts))|

---

## Value ISO20022.Camt005001.LongPaymentIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EndToEndId|String||XmlElement()||
|+|NtryTp|String||XmlElement()||
|+|InstdAgt|ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InstgAgt|ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|PmtMtd|ISO20022.Camt005001.PaymentOrigin1Choice||XmlElement()||
|+|IntrBkSttlmDt|DateTime||XmlElement()||
|+|IntrBkSttlmAmt|Decimal||XmlElement()||
|+|UETR|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""NtryTp""",NtryTp,"""[BEOVW]{1,1}[0-9]{2,2}\|DUM"""),validElement(InstdAgt),validElement(InstgAgt),validElement(PmtMtd),validPattern("""UETR""",UETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""))|

---

## Value ISO20022.Camt005001.MessageHeader9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ReqTp|ISO20022.Camt005001.RequestType4Choice||XmlElement()||
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqTp))|

---

## Enum ISO20022.Camt005001.NamePrefix2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MIKS|Int32||XmlEnum("""MIKS""")|1|
||MIST|Int32||XmlEnum("""MIST""")|2|
||MISS|Int32||XmlEnum("""MISS""")|3|
||MADM|Int32||XmlEnum("""MADM""")|4|
||DOCT|Int32||XmlEnum("""DOCT""")|5|

---

## Value ISO20022.Camt005001.OrganisationIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt005001.GenericOrganisationIdentification3>||XmlElement()||
|+|LEI|String||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt005001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt005001.OtherContact1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|ChanlTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt005001.Party50Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Agt|ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Pty|ISO20022.Camt005001.PartyIdentification272||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Agt),validElement(Pty),validChoice(Agt,Pty))|

---

## Value ISO20022.Camt005001.Party52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrvtId|ISO20022.Camt005001.PersonIdentification18||XmlElement()||
|+|OrgId|ISO20022.Camt005001.OrganisationIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrvtId),validElement(OrgId),validChoice(PrvtId,OrgId))|

---

## Value ISO20022.Camt005001.PartyIdentification272


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtctDtls|ISO20022.Camt005001.Contact13||XmlElement()||
|+|CtryOfRes|String||XmlElement()||
|+|Id|ISO20022.Camt005001.Party52Choice||XmlElement()||
|+|PstlAdr|ISO20022.Camt005001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtctDtls),validPattern("""CtryOfRes""",CtryOfRes,"""[A-Z]{2,2}"""),validElement(Id),validElement(PstlAdr))|

---

## Value ISO20022.Camt005001.PaymentIdentification8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|String||XmlElement()||
|+|ShrtBizId|ISO20022.Camt005001.ShortPaymentIdentification4||XmlElement()||
|+|LngBizId|ISO20022.Camt005001.LongPaymentIdentification4||XmlElement()||
|+|QId|ISO20022.Camt005001.QueueTransactionIdentification1||XmlElement()||
|+|UETR|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ShrtBizId),validElement(LngBizId),validElement(QId),validPattern("""UETR""",UETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""),validChoice(PrtryId,ShrtBizId,LngBizId,QId,UETR,TxId))|

---

## Enum ISO20022.Camt005001.PaymentInstrument1Code


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

## Value ISO20022.Camt005001.PaymentOrigin1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Instrm|String||XmlElement()||
|+|Prtry|String||XmlElement()||
|+|XMLMsgNm|String||XmlElement()||
|+|FINMT|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FINMT""",FINMT,"""[0-9]{1,3}"""),validChoice(Instrm,Prtry,XMLMsgNm,FINMT))|

---

## Value ISO20022.Camt005001.PaymentReturnCriteria4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtrInd|String||XmlElement()||
|+|CdtrAgtInd|String||XmlElement()||
|+|IntrmyInd|String||XmlElement()||
|+|InstdRmbrsmntAgtInd|String||XmlElement()||
|+|InstgRmbrsmntAgtInd|String||XmlElement()||
|+|DbtrAgtInd|String||XmlElement()||
|+|DbtrInd|String||XmlElement()||
|+|PmtMtdInd|String||XmlElement()||
|+|EndToEndIdInd|String||XmlElement()||
|+|IntrBkSttlmDtInd|String||XmlElement()||
|+|TxIdInd|String||XmlElement()||
|+|PmtTpInd|String||XmlElement()||
|+|PmtMTInd|String||XmlElement()||
|+|InstrCpyInd|String||XmlElement()||
|+|PurpInd|String||XmlElement()||
|+|PrcgVldtyTmInd|String||XmlElement()||
|+|PrtyInd|String||XmlElement()||
|+|IntrBkSttlmAmtInd|String||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|InstdAmtInd|String||XmlElement()||
|+|InstrStsRtrCrit|ISO20022.Camt005001.InstructionStatusReturnCriteria1||XmlElement()||
|+|InstrInd|String||XmlElement()||
|+|ReqdExctnDtInd|String||XmlElement()||
|+|MsgIdInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstrStsRtrCrit))|

---

## Value ISO20022.Camt005001.PaymentSearch10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pties|ISO20022.Camt005001.PaymentTransactionParty4||XmlElement()||
|+|EndToEndId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|IntrBkSttlmDt|global::System.Collections.Generic.List<DateTime>||XmlElement()||
|+|UETR|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TxId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|Instr|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PrcgVldtyTm|global::System.Collections.Generic.List<ISO20022.Camt005001.DateTimePeriod1Choice>||XmlElement()||
|+|Prty|global::System.Collections.Generic.List<ISO20022.Camt005001.Priority1Choice>||XmlElement()||
|+|PmtTp|global::System.Collections.Generic.List<ISO20022.Camt005001.PaymentType4Choice>||XmlElement()||
|+|PmtMtd|global::System.Collections.Generic.List<ISO20022.Camt005001.PaymentOrigin1Choice>||XmlElement()||
|+|IntrBkSttlmAmtCcy|global::System.Collections.Generic.List<String>||XmlElement()||
|+|IntrBkSttlmAmt|global::System.Collections.Generic.List<ISO20022.Camt005001.ActiveAmountRange3Choice>||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|InstdAmtCcy|global::System.Collections.Generic.List<String>||XmlElement()||
|+|InstdAmt|global::System.Collections.Generic.List<ISO20022.Camt005001.ActiveOrHistoricAmountRange2Choice>||XmlElement()||
|+|Sts|global::System.Collections.Generic.List<ISO20022.Camt005001.InstructionStatusSearch5>||XmlElement()||
|+|PmtId|global::System.Collections.Generic.List<ISO20022.Camt005001.PaymentIdentification8Choice>||XmlElement()||
|+|ReqdExctnDt|global::System.Collections.Generic.List<ISO20022.Camt005001.DateAndDateTimeSearch3Choice>||XmlElement()||
|+|MsgId|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pties),validPattern("""UETR""",UETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""),validList("""PrcgVldtyTm""",PrcgVldtyTm),validElement(PrcgVldtyTm),validList("""Prty""",Prty),validElement(Prty),validList("""PmtTp""",PmtTp),validElement(PmtTp),validList("""PmtMtd""",PmtMtd),validElement(PmtMtd),validPattern("""IntrBkSttlmAmtCcy""",IntrBkSttlmAmtCcy,"""[A-Z]{3,3}"""),validList("""IntrBkSttlmAmt""",IntrBkSttlmAmt),validElement(IntrBkSttlmAmt),validPattern("""InstdAmtCcy""",InstdAmtCcy,"""[A-Z]{3,3}"""),validList("""InstdAmt""",InstdAmt),validElement(InstdAmt),validList("""Sts""",Sts),validElement(Sts),validList("""PmtId""",PmtId),validElement(PmtId),validList("""ReqdExctnDt""",ReqdExctnDt),validElement(ReqdExctnDt))|

---

## Value ISO20022.Camt005001.PaymentStatusCodeSearch2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PdgAndFnlSts|String||XmlElement()||
|+|FnlSts|String||XmlElement()||
|+|PdgSts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(PdgAndFnlSts,FnlSts,PdgSts))|

---

## Value ISO20022.Camt005001.PaymentTransactionParty4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UltmtCdtr|ISO20022.Camt005001.Party50Choice||XmlElement()||
|+|Cdtr|ISO20022.Camt005001.Party50Choice||XmlElement()||
|+|CdtrAgt|ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrmyAgt3|ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrmyAgt2|ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrmyAgt1|ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InstdRmbrsmntAgt|ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InstgRmbrsmntAgt|ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|DbtrAgt|ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|Dbtr|ISO20022.Camt005001.Party50Choice||XmlElement()||
|+|UltmtDbtr|ISO20022.Camt005001.Party50Choice||XmlElement()||
|+|InstdAgt|ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|InstgAgt|ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UltmtCdtr),validElement(Cdtr),validElement(CdtrAgt),validElement(IntrmyAgt3),validElement(IntrmyAgt2),validElement(IntrmyAgt1),validElement(InstdRmbrsmntAgt),validElement(InstgRmbrsmntAgt),validElement(DbtrAgt),validElement(Dbtr),validElement(UltmtDbtr),validElement(InstdAgt),validElement(InstgAgt))|

---

## Enum ISO20022.Camt005001.PaymentType3Code


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

## Value ISO20022.Camt005001.PaymentType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt005001.PendingStatus4Code


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

## Value ISO20022.Camt005001.PersonIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Camt005001.GenericPersonIdentification2>||XmlElement()||
|+|DtAndPlcOfBirth|ISO20022.Camt005001.DateAndPlaceOfBirth1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validElement(DtAndPlcOfBirth))|

---

## Value ISO20022.Camt005001.PersonIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt005001.PostalAddress27


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
|+|AdrTp|ISO20022.Camt005001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Enum ISO20022.Camt005001.PreferredContactMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHON|Int32||XmlEnum("""PHON""")|1|
||ONLI|Int32||XmlEnum("""ONLI""")|2|
||CELL|Int32||XmlEnum("""CELL""")|3|
||LETT|Int32||XmlEnum("""LETT""")|4|
||FAXX|Int32||XmlEnum("""FAXX""")|5|
||MAIL|Int32||XmlEnum("""MAIL""")|6|

---

## Value ISO20022.Camt005001.Priority1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt005001.Priority5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||URGT|Int32||XmlEnum("""URGT""")|1|
||NORM|Int32||XmlEnum("""NORM""")|2|
||LOWW|Int32||XmlEnum("""LOWW""")|3|
||HIGH|Int32||XmlEnum("""HIGH""")|4|

---

## Enum ISO20022.Camt005001.QueryType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELD|Int32||XmlEnum("""DELD""")|1|
||MODF|Int32||XmlEnum("""MODF""")|2|
||CHNG|Int32||XmlEnum("""CHNG""")|3|
||ALLL|Int32||XmlEnum("""ALLL""")|4|

---

## Value ISO20022.Camt005001.QueueTransactionIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PosInQ|String||XmlElement()||
|+|QId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Camt005001.ReportIndicator1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRPR|Int32||XmlEnum("""PRPR""")|1|
||STND|Int32||XmlEnum("""STND""")|2|

---

## Value ISO20022.Camt005001.RequestType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt005001.GenericIdentification1||XmlElement()||
|+|Enqry|String||XmlElement()||
|+|PmtCtrl|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Enqry,PmtCtrl))|

---

## Value ISO20022.Camt005001.ShortPaymentIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstgAgt|ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|IntrBkSttlmDt|DateTime||XmlElement()||
|+|UETR|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstgAgt),validPattern("""UETR""",UETR,"""[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89ab][a-f0-9]{3}-[a-f0-9]{12}"""))|

---

## Value ISO20022.Camt005001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt005001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt005001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt005001.SystemReturnCriteria2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctIdInd|String||XmlElement()||
|+|CtryIdInd|String||XmlElement()||
|+|MmbIdInd|String||XmlElement()||
|+|SysIdInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt005001.SystemSearch5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctId|ISO20022.Camt005001.AccountIdentification4Choice||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|MmbId|global::System.Collections.Generic.List<ISO20022.Camt005001.BranchAndFinancialInstitutionIdentification8>||XmlElement()||
|+|SysId|global::System.Collections.Generic.List<ISO20022.Camt005001.ClearingSystemIdentification3Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validList("""MmbId""",MmbId),validElement(MmbId),validList("""SysId""",SysId),validElement(SysId))|

---

## Value ISO20022.Camt005001.TransactionCriteria11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RtrCrit|ISO20022.Camt005001.TransactionReturnCriteria5||XmlElement()||
|+|StmtRpt|String||XmlElement()||
|+|SchCrit|global::System.Collections.Generic.List<ISO20022.Camt005001.TransactionSearchCriteria11>||XmlElement()||
|+|NewQryNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RtrCrit),validList("""SchCrit""",SchCrit),validElement(SchCrit))|

---

## Value ISO20022.Camt005001.TransactionCriteria8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NewCrit|ISO20022.Camt005001.TransactionCriteria11||XmlElement()||
|+|QryNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NewCrit),validChoice(NewCrit,QryNm))|

---

## Value ISO20022.Camt005001.TransactionQuery8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxCrit|ISO20022.Camt005001.TransactionCriteria8Choice||XmlElement()||
|+|QryTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxCrit))|

---

## Value ISO20022.Camt005001.TransactionReturnCriteria5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmtRtrCrit|ISO20022.Camt005001.PaymentReturnCriteria4||XmlElement()||
|+|AcctCshNtryRtrCrit|ISO20022.Camt005001.AccountCashEntryReturnCriteria3||XmlElement()||
|+|PmtFrRtrCrit|ISO20022.Camt005001.SystemReturnCriteria2||XmlElement()||
|+|PmtToRtrCrit|ISO20022.Camt005001.SystemReturnCriteria2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PmtRtrCrit),validElement(AcctCshNtryRtrCrit),validElement(PmtFrRtrCrit),validElement(PmtToRtrCrit))|

---

## Value ISO20022.Camt005001.TransactionSearchCriteria11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctNtrySch|ISO20022.Camt005001.CashAccountEntrySearch8||XmlElement()||
|+|PmtSch|ISO20022.Camt005001.PaymentSearch10||XmlElement()||
|+|PmtFr|global::System.Collections.Generic.List<ISO20022.Camt005001.SystemSearch5>||XmlElement()||
|+|PmtTo|global::System.Collections.Generic.List<ISO20022.Camt005001.SystemSearch5>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctNtrySch),validElement(PmtSch),validList("""PmtFr""",PmtFr),validElement(PmtFr),validList("""PmtTo""",PmtTo),validElement(PmtTo))|

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

