# camt.073.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt073001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt073001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt073001.AccountIdentification4Choice *-- ISO20022.Camt073001.GenericAccountIdentification1
    class ISO20022.Camt073001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt073001.AcknowledgedAcceptedStatus21Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Camt073001.AcknowledgementReason9~
        + NoSpcfdRsn  : String
    }
    ISO20022.Camt073001.AcknowledgedAcceptedStatus21Choice *-- ISO20022.Camt073001.AcknowledgementReason9
    class ISO20022.Camt073001.AcknowledgementReason12Choice {
        + Prtry  : ISO20022.Camt073001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt073001.AcknowledgementReason12Choice *-- ISO20022.Camt073001.GenericIdentification30
    class ISO20022.Camt073001.AcknowledgementReason5Code {
        LATE = 1
        RQWV = 2
        NSTP = 3
        CDRE = 4
        CDRG = 5
        CDCY = 6
        OTHR = 7
        SMPG = 8
        ADEA = 9
    }
    class ISO20022.Camt073001.AcknowledgementReason9 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Camt073001.AcknowledgementReason12Choice
    }
    ISO20022.Camt073001.AcknowledgementReason9 *-- ISO20022.Camt073001.AcknowledgementReason12Choice
    class ISO20022.Camt073001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt073001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt073001.AddressType3Choice {
        + Prtry  : ISO20022.Camt073001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt073001.AddressType3Choice *-- ISO20022.Camt073001.GenericIdentification30
    class ISO20022.Camt073001.Amount2Choice {
        + AmtWthCcy  : ISO20022.Camt073001.ActiveCurrencyAndAmount
        + AmtWthtCcy  : Decimal
    }
    ISO20022.Camt073001.Amount2Choice *-- ISO20022.Camt073001.ActiveCurrencyAndAmount
    class ISO20022.Camt073001.AmountAndDirection5 {
        + CdtDbt  : String
        + Amt  : ISO20022.Camt073001.ActiveCurrencyAndAmount
    }
    ISO20022.Camt073001.AmountAndDirection5 *-- ISO20022.Camt073001.ActiveCurrencyAndAmount
    class ISO20022.Camt073001.AmountAndQuantityBreakdown1 {
        + CshSubBalTp  : ISO20022.Camt073001.GenericIdentification30
        + LotQty  : ISO20022.Camt073001.FinancialInstrumentQuantity1Choice
        + LotAmt  : ISO20022.Camt073001.AmountAndDirection5
        + LotNb  : ISO20022.Camt073001.GenericIdentification37
    }
    ISO20022.Camt073001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt073001.GenericIdentification30
    ISO20022.Camt073001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt073001.FinancialInstrumentQuantity1Choice
    ISO20022.Camt073001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt073001.AmountAndDirection5
    ISO20022.Camt073001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt073001.GenericIdentification37
    class ISO20022.Camt073001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Camt073001.BranchData5
        + FinInstnId  : ISO20022.Camt073001.FinancialInstitutionIdentification23
    }
    ISO20022.Camt073001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt073001.BranchData5
    ISO20022.Camt073001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt073001.FinancialInstitutionIdentification23
    class ISO20022.Camt073001.BranchData5 {
        + PstlAdr  : ISO20022.Camt073001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt073001.BranchData5 *-- ISO20022.Camt073001.PostalAddress27
    class ISO20022.Camt073001.CashAccount40 {
        + Prxy  : ISO20022.Camt073001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Camt073001.CashAccountType2Choice
        + Id  : ISO20022.Camt073001.AccountIdentification4Choice
    }
    ISO20022.Camt073001.CashAccount40 *-- ISO20022.Camt073001.ProxyAccountIdentification1
    ISO20022.Camt073001.CashAccount40 *-- ISO20022.Camt073001.CashAccountType2Choice
    ISO20022.Camt073001.CashAccount40 *-- ISO20022.Camt073001.AccountIdentification4Choice
    class ISO20022.Camt073001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt073001.CashBalanceType3Choice {
        + Prtry  : ISO20022.Camt073001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt073001.CashBalanceType3Choice *-- ISO20022.Camt073001.GenericIdentification30
    class ISO20022.Camt073001.CashSubBalanceTypeAndQuantityBreakdown3 {
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Camt073001.AmountAndQuantityBreakdown1~
        + Tp  : ISO20022.Camt073001.CashBalanceType3Choice
    }
    ISO20022.Camt073001.CashSubBalanceTypeAndQuantityBreakdown3 *-- ISO20022.Camt073001.AmountAndQuantityBreakdown1
    ISO20022.Camt073001.CashSubBalanceTypeAndQuantityBreakdown3 *-- ISO20022.Camt073001.CashBalanceType3Choice
    class ISO20022.Camt073001.ClearingChannel2Code {
        BOOK = 1
        MPNS = 2
        RTNS = 3
        RTGS = 4
    }
    class ISO20022.Camt073001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt073001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt073001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt073001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt073001.ClearingSystemIdentification2Choice
    class ISO20022.Camt073001.CopyDuplicate1Code {
        DUPL = 1
        COPY = 2
        CODU = 3
    }
    class ISO20022.Camt073001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Camt073001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Camt073001.DeniedReason11 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Camt073001.DeniedReason16Choice
    }
    ISO20022.Camt073001.DeniedReason11 *-- ISO20022.Camt073001.DeniedReason16Choice
    class ISO20022.Camt073001.DeniedReason16Choice {
        + Prtry  : ISO20022.Camt073001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt073001.DeniedReason16Choice *-- ISO20022.Camt073001.GenericIdentification30
    class ISO20022.Camt073001.DeniedReason4Code {
        CDRE = 1
        CDCY = 2
        CDRG = 3
        OTHR = 4
        LATE = 5
        DSET = 6
        DREP = 7
        DPRG = 8
        DCAN = 9
        ADEA = 10
    }
    class ISO20022.Camt073001.DeniedStatus16Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Camt073001.DeniedReason11~
        + NoSpcfdRsn  : String
    }
    ISO20022.Camt073001.DeniedStatus16Choice *-- ISO20022.Camt073001.DeniedReason11
    class ISO20022.Camt073001.DocumentIdentification51 {
        + MsgRcpt  : ISO20022.Camt073001.PartyIdentification136
        + MsgOrgtr  : ISO20022.Camt073001.PartyIdentification136
        + CpyDplct  : String
        + CreDtTm  : ISO20022.Camt073001.DateAndDateTime2Choice
        + Id  : String
    }
    ISO20022.Camt073001.DocumentIdentification51 *-- ISO20022.Camt073001.PartyIdentification136
    ISO20022.Camt073001.DocumentIdentification51 *-- ISO20022.Camt073001.PartyIdentification136
    ISO20022.Camt073001.DocumentIdentification51 *-- ISO20022.Camt073001.DateAndDateTime2Choice
    class ISO20022.Camt073001.DocumentNumber5Choice {
        + PrtryNb  : ISO20022.Camt073001.GenericIdentification36
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Camt073001.DocumentNumber5Choice *-- ISO20022.Camt073001.GenericIdentification36
    class ISO20022.Camt073001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt073001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Camt073001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt073001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt073001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt073001.FinancialInstitutionIdentification23 *-- ISO20022.Camt073001.GenericFinancialIdentification1
    ISO20022.Camt073001.FinancialInstitutionIdentification23 *-- ISO20022.Camt073001.PostalAddress27
    ISO20022.Camt073001.FinancialInstitutionIdentification23 *-- ISO20022.Camt073001.ClearingSystemMemberIdentification2
    class ISO20022.Camt073001.FinancialInstrumentQuantity1Choice {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Camt073001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt073001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt073001.GenericAccountIdentification1 *-- ISO20022.Camt073001.AccountSchemeName1Choice
    class ISO20022.Camt073001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt073001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt073001.GenericFinancialIdentification1 *-- ISO20022.Camt073001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt073001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt073001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt073001.GenericIdentification37 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt073001.IntraBalance5 {
        + InstrPrcgAddtlDtls  : String
        + Prty  : ISO20022.Camt073001.PriorityNumeric4Choice
        + CshSubBalId  : ISO20022.Camt073001.GenericIdentification37
        + BalTo  : ISO20022.Camt073001.CashSubBalanceTypeAndQuantityBreakdown3
        + BalFr  : ISO20022.Camt073001.CashSubBalanceTypeAndQuantityBreakdown3
        + SttlmDt  : ISO20022.Camt073001.DateAndDateTime2Choice
        + SttlmAmt  : ISO20022.Camt073001.Amount2Choice
    }
    ISO20022.Camt073001.IntraBalance5 *-- ISO20022.Camt073001.PriorityNumeric4Choice
    ISO20022.Camt073001.IntraBalance5 *-- ISO20022.Camt073001.GenericIdentification37
    ISO20022.Camt073001.IntraBalance5 *-- ISO20022.Camt073001.CashSubBalanceTypeAndQuantityBreakdown3
    ISO20022.Camt073001.IntraBalance5 *-- ISO20022.Camt073001.CashSubBalanceTypeAndQuantityBreakdown3
    ISO20022.Camt073001.IntraBalance5 *-- ISO20022.Camt073001.DateAndDateTime2Choice
    ISO20022.Camt073001.IntraBalance5 *-- ISO20022.Camt073001.Amount2Choice
    class ISO20022.Camt073001.IntraBalanceMovementModificationRequestStatusAdviceV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt073001.SupplementaryData1~
        + UndrlygIntraBal  : ISO20022.Camt073001.IntraBalance5
        + PrcgSts  : ISO20022.Camt073001.ProcessingStatus71Choice
        + ReqDtls  : ISO20022.Camt073001.RequestDetails22
        + CshAcctSvcr  : ISO20022.Camt073001.BranchAndFinancialInstitutionIdentification8
        + CshAcctOwnr  : ISO20022.Camt073001.SystemPartyIdentification8
        + CshAcct  : ISO20022.Camt073001.CashAccount40
        + ReqRef  : String
        + Id  : ISO20022.Camt073001.DocumentIdentification51
    }
    ISO20022.Camt073001.IntraBalanceMovementModificationRequestStatusAdviceV02 *-- ISO20022.Camt073001.SupplementaryData1
    ISO20022.Camt073001.IntraBalanceMovementModificationRequestStatusAdviceV02 *-- ISO20022.Camt073001.IntraBalance5
    ISO20022.Camt073001.IntraBalanceMovementModificationRequestStatusAdviceV02 *-- ISO20022.Camt073001.ProcessingStatus71Choice
    ISO20022.Camt073001.IntraBalanceMovementModificationRequestStatusAdviceV02 *-- ISO20022.Camt073001.RequestDetails22
    ISO20022.Camt073001.IntraBalanceMovementModificationRequestStatusAdviceV02 *-- ISO20022.Camt073001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt073001.IntraBalanceMovementModificationRequestStatusAdviceV02 *-- ISO20022.Camt073001.SystemPartyIdentification8
    ISO20022.Camt073001.IntraBalanceMovementModificationRequestStatusAdviceV02 *-- ISO20022.Camt073001.CashAccount40
    ISO20022.Camt073001.IntraBalanceMovementModificationRequestStatusAdviceV02 *-- ISO20022.Camt073001.DocumentIdentification51
    class ISO20022.Camt073001.LinkageType1Code {
        SOFT = 1
        UNLK = 2
        LINK = 3
    }
    class ISO20022.Camt073001.LinkageType3Choice {
        + Prtry  : ISO20022.Camt073001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt073001.LinkageType3Choice *-- ISO20022.Camt073001.GenericIdentification30
    class ISO20022.Camt073001.Linkages57 {
        + RefOwnr  : ISO20022.Camt073001.PartyIdentification127Choice
        + Ref  : ISO20022.Camt073001.References34Choice
        + MsgNb  : ISO20022.Camt073001.DocumentNumber5Choice
        + PrcgPos  : ISO20022.Camt073001.ProcessingPosition7Choice
    }
    ISO20022.Camt073001.Linkages57 *-- ISO20022.Camt073001.PartyIdentification127Choice
    ISO20022.Camt073001.Linkages57 *-- ISO20022.Camt073001.References34Choice
    ISO20022.Camt073001.Linkages57 *-- ISO20022.Camt073001.DocumentNumber5Choice
    ISO20022.Camt073001.Linkages57 *-- ISO20022.Camt073001.ProcessingPosition7Choice
    class ISO20022.Camt073001.NameAndAddress5 {
        + Adr  : ISO20022.Camt073001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Camt073001.NameAndAddress5 *-- ISO20022.Camt073001.PostalAddress1
    class ISO20022.Camt073001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Camt073001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Camt073001.NameAndAddress5
        + PrtryId  : ISO20022.Camt073001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Camt073001.PartyIdentification120Choice *-- ISO20022.Camt073001.NameAndAddress5
    ISO20022.Camt073001.PartyIdentification120Choice *-- ISO20022.Camt073001.GenericIdentification36
    class ISO20022.Camt073001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Camt073001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Camt073001.PartyIdentification127Choice *-- ISO20022.Camt073001.GenericIdentification36
    class ISO20022.Camt073001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Camt073001.PartyIdentification120Choice
    }
    ISO20022.Camt073001.PartyIdentification136 *-- ISO20022.Camt073001.PartyIdentification120Choice
    class ISO20022.Camt073001.PendingReason16 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Camt073001.PendingReason28Choice
    }
    ISO20022.Camt073001.PendingReason16 *-- ISO20022.Camt073001.PendingReason28Choice
    class ISO20022.Camt073001.PendingReason28Choice {
        + Prtry  : ISO20022.Camt073001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt073001.PendingReason28Choice *-- ISO20022.Camt073001.GenericIdentification30
    class ISO20022.Camt073001.PendingReason6Code {
        CDRE = 1
        CDCY = 2
        CDRG = 3
        OTHR = 4
        CONF = 5
        ADEA = 6
    }
    class ISO20022.Camt073001.PendingStatus38Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Camt073001.PendingReason16~
        + NoSpcfdRsn  : String
    }
    ISO20022.Camt073001.PendingStatus38Choice *-- ISO20022.Camt073001.PendingReason16
    class ISO20022.Camt073001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Camt073001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Camt073001.AddressType3Choice
    }
    ISO20022.Camt073001.PostalAddress27 *-- ISO20022.Camt073001.AddressType3Choice
    class ISO20022.Camt073001.PriorityNumeric4Choice {
        + Prtry  : ISO20022.Camt073001.GenericIdentification30
        + Nmrc  : String
    }
    ISO20022.Camt073001.PriorityNumeric4Choice *-- ISO20022.Camt073001.GenericIdentification30
    class ISO20022.Camt073001.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Camt073001.ProcessingPosition7Choice {
        + Prtry  : ISO20022.Camt073001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt073001.ProcessingPosition7Choice *-- ISO20022.Camt073001.GenericIdentification30
    class ISO20022.Camt073001.ProcessingStatus71Choice {
        + Prtry  : ISO20022.Camt073001.ProprietaryStatusAndReason6
        + Cmpltd  : ISO20022.Camt073001.ProprietaryReason4
        + Dnd  : ISO20022.Camt073001.DeniedStatus16Choice
        + Rpr  : ISO20022.Camt073001.RejectionOrRepairStatus39Choice
        + Rjctd  : ISO20022.Camt073001.RejectionOrRepairStatus40Choice
        + Pdg  : ISO20022.Camt073001.PendingStatus38Choice
        + AckdAccptd  : ISO20022.Camt073001.AcknowledgedAcceptedStatus21Choice
    }
    ISO20022.Camt073001.ProcessingStatus71Choice *-- ISO20022.Camt073001.ProprietaryStatusAndReason6
    ISO20022.Camt073001.ProcessingStatus71Choice *-- ISO20022.Camt073001.ProprietaryReason4
    ISO20022.Camt073001.ProcessingStatus71Choice *-- ISO20022.Camt073001.DeniedStatus16Choice
    ISO20022.Camt073001.ProcessingStatus71Choice *-- ISO20022.Camt073001.RejectionOrRepairStatus39Choice
    ISO20022.Camt073001.ProcessingStatus71Choice *-- ISO20022.Camt073001.RejectionOrRepairStatus40Choice
    ISO20022.Camt073001.ProcessingStatus71Choice *-- ISO20022.Camt073001.PendingStatus38Choice
    ISO20022.Camt073001.ProcessingStatus71Choice *-- ISO20022.Camt073001.AcknowledgedAcceptedStatus21Choice
    class ISO20022.Camt073001.ProprietaryReason4 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Camt073001.GenericIdentification30
    }
    ISO20022.Camt073001.ProprietaryReason4 *-- ISO20022.Camt073001.GenericIdentification30
    class ISO20022.Camt073001.ProprietaryStatusAndReason6 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Camt073001.ProprietaryReason4~
        + PrtrySts  : ISO20022.Camt073001.GenericIdentification30
    }
    ISO20022.Camt073001.ProprietaryStatusAndReason6 *-- ISO20022.Camt073001.ProprietaryReason4
    ISO20022.Camt073001.ProprietaryStatusAndReason6 *-- ISO20022.Camt073001.GenericIdentification30
    class ISO20022.Camt073001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Camt073001.ProxyAccountType1Choice
    }
    ISO20022.Camt073001.ProxyAccountIdentification1 *-- ISO20022.Camt073001.ProxyAccountType1Choice
    class ISO20022.Camt073001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt073001.References14 {
        + PoolId  : String
        + PrcrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    class ISO20022.Camt073001.References34Choice {
        + OthrTxId  : String
        + PoolId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + IntraBalMvmntId  : String
        + IntraPosMvmntId  : String
        + SctiesSttlmTxId  : String
    }
    class ISO20022.Camt073001.RejectionAndRepairReason33Choice {
        + Prtry  : ISO20022.Camt073001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt073001.RejectionAndRepairReason33Choice *-- ISO20022.Camt073001.GenericIdentification30
    class ISO20022.Camt073001.RejectionAndRepairReason34Choice {
        + Prtry  : ISO20022.Camt073001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt073001.RejectionAndRepairReason34Choice *-- ISO20022.Camt073001.GenericIdentification30
    class ISO20022.Camt073001.RejectionOrRepairReason33 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Camt073001.RejectionAndRepairReason33Choice
    }
    ISO20022.Camt073001.RejectionOrRepairReason33 *-- ISO20022.Camt073001.RejectionAndRepairReason33Choice
    class ISO20022.Camt073001.RejectionOrRepairReason34 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Camt073001.RejectionAndRepairReason34Choice
    }
    ISO20022.Camt073001.RejectionOrRepairReason34 *-- ISO20022.Camt073001.RejectionAndRepairReason34Choice
    class ISO20022.Camt073001.RejectionOrRepairStatus39Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Camt073001.RejectionOrRepairReason33~
        + NoSpcfdRsn  : String
    }
    ISO20022.Camt073001.RejectionOrRepairStatus39Choice *-- ISO20022.Camt073001.RejectionOrRepairReason33
    class ISO20022.Camt073001.RejectionOrRepairStatus40Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Camt073001.RejectionOrRepairReason34~
        + NoSpcfdRsn  : String
    }
    ISO20022.Camt073001.RejectionOrRepairStatus40Choice *-- ISO20022.Camt073001.RejectionOrRepairReason34
    class ISO20022.Camt073001.RejectionReason34Code {
        REFE = 1
        OTHR = 2
        NRGN = 3
        NRGM = 4
        CASH = 5
        LATE = 6
        ADEA = 7
    }
    class ISO20022.Camt073001.RejectionReason35Code {
        INVL = 1
        INVM = 2
        OTHR = 3
        NRGN = 4
        DDAT = 5
        LATE = 6
        REFE = 7
        ADEA = 8
        CASH = 9
    }
    class ISO20022.Camt073001.RequestDetails22 {
        + Lnkgs  : global::System.Collections.Generic.List~ISO20022.Camt073001.Linkages57~
        + ClrChanl  : String
        + PrtlSttlmInd  : String
        + OthrPrcg  : global::System.Collections.Generic.List~ISO20022.Camt073001.GenericIdentification30~
        + Prty  : ISO20022.Camt073001.PriorityNumeric4Choice
        + Lkg  : ISO20022.Camt073001.LinkageType3Choice
        + Ref  : ISO20022.Camt073001.References14
    }
    ISO20022.Camt073001.RequestDetails22 *-- ISO20022.Camt073001.Linkages57
    ISO20022.Camt073001.RequestDetails22 *-- ISO20022.Camt073001.GenericIdentification30
    ISO20022.Camt073001.RequestDetails22 *-- ISO20022.Camt073001.PriorityNumeric4Choice
    ISO20022.Camt073001.RequestDetails22 *-- ISO20022.Camt073001.LinkageType3Choice
    ISO20022.Camt073001.RequestDetails22 *-- ISO20022.Camt073001.References14
    class ISO20022.Camt073001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt073001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt073001.SupplementaryData1 *-- ISO20022.Camt073001.SupplementaryDataEnvelope1
    class ISO20022.Camt073001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Camt073001.SystemPartyIdentification8 {
        + RspnsblPtyId  : ISO20022.Camt073001.PartyIdentification136
        + Id  : ISO20022.Camt073001.PartyIdentification136
    }
    ISO20022.Camt073001.SystemPartyIdentification8 *-- ISO20022.Camt073001.PartyIdentification136
    ISO20022.Camt073001.SystemPartyIdentification8 *-- ISO20022.Camt073001.PartyIdentification136
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

## Value ISO20022.Camt073001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt073001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt073001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt073001.AcknowledgedAcceptedStatus21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Camt073001.AcknowledgementReason9>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Camt073001.AcknowledgementReason12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt073001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt073001.AcknowledgementReason5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LATE|Int32||XmlEnum("""LATE""")|1|
||RQWV|Int32||XmlEnum("""RQWV""")|2|
||NSTP|Int32||XmlEnum("""NSTP""")|3|
||CDRE|Int32||XmlEnum("""CDRE""")|4|
||CDRG|Int32||XmlEnum("""CDRG""")|5|
||CDCY|Int32||XmlEnum("""CDCY""")|6|
||OTHR|Int32||XmlEnum("""OTHR""")|7|
||SMPG|Int32||XmlEnum("""SMPG""")|8|
||ADEA|Int32||XmlEnum("""ADEA""")|9|

---

## Value ISO20022.Camt073001.AcknowledgementReason9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Camt073001.AcknowledgementReason12Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Camt073001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Camt073001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt073001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt073001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt073001.Amount2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtWthCcy|ISO20022.Camt073001.ActiveCurrencyAndAmount||XmlElement()||
|+|AmtWthtCcy|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtWthCcy),validChoice(AmtWthCcy,AmtWthtCcy))|

---

## Value ISO20022.Camt073001.AmountAndDirection5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbt|String||XmlElement()||
|+|Amt|ISO20022.Camt073001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Camt073001.AmountAndQuantityBreakdown1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshSubBalTp|ISO20022.Camt073001.GenericIdentification30||XmlElement()||
|+|LotQty|ISO20022.Camt073001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|LotAmt|ISO20022.Camt073001.AmountAndDirection5||XmlElement()||
|+|LotNb|ISO20022.Camt073001.GenericIdentification37||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshSubBalTp),validElement(LotQty),validElement(LotAmt),validElement(LotNb))|

---

## Value ISO20022.Camt073001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt073001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Camt073001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt073001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt073001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Camt073001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Camt073001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Camt073001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Camt073001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Camt073001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt073001.CashBalanceType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt073001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt073001.CashSubBalanceTypeAndQuantityBreakdown3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Camt073001.AmountAndQuantityBreakdown1>||XmlElement()||
|+|Tp|ISO20022.Camt073001.CashBalanceType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(Tp))|

---

## Enum ISO20022.Camt073001.ClearingChannel2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOOK|Int32||XmlEnum("""BOOK""")|1|
||MPNS|Int32||XmlEnum("""MPNS""")|2|
||RTNS|Int32||XmlEnum("""RTNS""")|3|
||RTGS|Int32||XmlEnum("""RTGS""")|4|

---

## Value ISO20022.Camt073001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt073001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt073001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Enum ISO20022.Camt073001.CopyDuplicate1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DUPL|Int32||XmlEnum("""DUPL""")|1|
||COPY|Int32||XmlEnum("""COPY""")|2|
||CODU|Int32||XmlEnum("""CODU""")|3|

---

## Enum ISO20022.Camt073001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Camt073001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Camt073001.DeniedReason11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Camt073001.DeniedReason16Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Camt073001.DeniedReason16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt073001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt073001.DeniedReason4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDRE|Int32||XmlEnum("""CDRE""")|1|
||CDCY|Int32||XmlEnum("""CDCY""")|2|
||CDRG|Int32||XmlEnum("""CDRG""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||LATE|Int32||XmlEnum("""LATE""")|5|
||DSET|Int32||XmlEnum("""DSET""")|6|
||DREP|Int32||XmlEnum("""DREP""")|7|
||DPRG|Int32||XmlEnum("""DPRG""")|8|
||DCAN|Int32||XmlEnum("""DCAN""")|9|
||ADEA|Int32||XmlEnum("""ADEA""")|10|

---

## Value ISO20022.Camt073001.DeniedStatus16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Camt073001.DeniedReason11>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Type ISO20022.Camt073001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntraBalMvmntModReqStsAdvc|ISO20022.Camt073001.IntraBalanceMovementModificationRequestStatusAdviceV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntraBalMvmntModReqStsAdvc))|

---

## Value ISO20022.Camt073001.DocumentIdentification51


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgRcpt|ISO20022.Camt073001.PartyIdentification136||XmlElement()||
|+|MsgOrgtr|ISO20022.Camt073001.PartyIdentification136||XmlElement()||
|+|CpyDplct|String||XmlElement()||
|+|CreDtTm|ISO20022.Camt073001.DateAndDateTime2Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MsgRcpt),validElement(MsgOrgtr),validElement(CreDtTm))|

---

## Value ISO20022.Camt073001.DocumentNumber5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Camt073001.GenericIdentification36||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Value ISO20022.Camt073001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt073001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt073001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt073001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt073001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt073001.FinancialInstrumentQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Camt073001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt073001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt073001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt073001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt073001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt073001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt073001.GenericIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt073001.IntraBalance5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrPrcgAddtlDtls|String||XmlElement()||
|+|Prty|ISO20022.Camt073001.PriorityNumeric4Choice||XmlElement()||
|+|CshSubBalId|ISO20022.Camt073001.GenericIdentification37||XmlElement()||
|+|BalTo|ISO20022.Camt073001.CashSubBalanceTypeAndQuantityBreakdown3||XmlElement()||
|+|BalFr|ISO20022.Camt073001.CashSubBalanceTypeAndQuantityBreakdown3||XmlElement()||
|+|SttlmDt|ISO20022.Camt073001.DateAndDateTime2Choice||XmlElement()||
|+|SttlmAmt|ISO20022.Camt073001.Amount2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prty),validElement(CshSubBalId),validElement(BalTo),validElement(BalFr),validElement(SttlmDt),validElement(SttlmAmt))|

---

## Aspect ISO20022.Camt073001.IntraBalanceMovementModificationRequestStatusAdviceV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt073001.SupplementaryData1>||XmlElement()||
|+|UndrlygIntraBal|ISO20022.Camt073001.IntraBalance5||XmlElement()||
|+|PrcgSts|ISO20022.Camt073001.ProcessingStatus71Choice||XmlElement()||
|+|ReqDtls|ISO20022.Camt073001.RequestDetails22||XmlElement()||
|+|CshAcctSvcr|ISO20022.Camt073001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|CshAcctOwnr|ISO20022.Camt073001.SystemPartyIdentification8||XmlElement()||
|+|CshAcct|ISO20022.Camt073001.CashAccount40||XmlElement()||
|+|ReqRef|String||XmlElement()||
|+|Id|ISO20022.Camt073001.DocumentIdentification51||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(UndrlygIntraBal),validElement(PrcgSts),validElement(ReqDtls),validElement(CshAcctSvcr),validElement(CshAcctOwnr),validElement(CshAcct),validElement(Id))|

---

## Enum ISO20022.Camt073001.LinkageType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SOFT|Int32||XmlEnum("""SOFT""")|1|
||UNLK|Int32||XmlEnum("""UNLK""")|2|
||LINK|Int32||XmlEnum("""LINK""")|3|

---

## Value ISO20022.Camt073001.LinkageType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt073001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt073001.Linkages57


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefOwnr|ISO20022.Camt073001.PartyIdentification127Choice||XmlElement()||
|+|Ref|ISO20022.Camt073001.References34Choice||XmlElement()||
|+|MsgNb|ISO20022.Camt073001.DocumentNumber5Choice||XmlElement()||
|+|PrcgPos|ISO20022.Camt073001.ProcessingPosition7Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefOwnr),validElement(Ref),validElement(MsgNb),validElement(PrcgPos))|

---

## Value ISO20022.Camt073001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Camt073001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Camt073001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Camt073001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Camt073001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Camt073001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Camt073001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Camt073001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Camt073001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Camt073001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Camt073001.PendingReason16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Camt073001.PendingReason28Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Camt073001.PendingReason28Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt073001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt073001.PendingReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDRE|Int32||XmlEnum("""CDRE""")|1|
||CDCY|Int32||XmlEnum("""CDCY""")|2|
||CDRG|Int32||XmlEnum("""CDRG""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||CONF|Int32||XmlEnum("""CONF""")|5|
||ADEA|Int32||XmlEnum("""ADEA""")|6|

---

## Value ISO20022.Camt073001.PendingStatus38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Camt073001.PendingReason16>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Camt073001.PostalAddress1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|CtrySubDvsn|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|BldgNb|String||XmlElement()||
|+|StrtNm|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AdrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validListMax("""AdrLine""",AdrLine,5))|

---

## Value ISO20022.Camt073001.PostalAddress27


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
|+|AdrTp|ISO20022.Camt073001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Value ISO20022.Camt073001.PriorityNumeric4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt073001.GenericIdentification30||XmlElement()||
|+|Nmrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""Nmrc""",Nmrc,"""[0-9]{4}"""),validChoice(Prtry,Nmrc))|

---

## Enum ISO20022.Camt073001.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Camt073001.ProcessingPosition7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt073001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt073001.ProcessingStatus71Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt073001.ProprietaryStatusAndReason6||XmlElement()||
|+|Cmpltd|ISO20022.Camt073001.ProprietaryReason4||XmlElement()||
|+|Dnd|ISO20022.Camt073001.DeniedStatus16Choice||XmlElement()||
|+|Rpr|ISO20022.Camt073001.RejectionOrRepairStatus39Choice||XmlElement()||
|+|Rjctd|ISO20022.Camt073001.RejectionOrRepairStatus40Choice||XmlElement()||
|+|Pdg|ISO20022.Camt073001.PendingStatus38Choice||XmlElement()||
|+|AckdAccptd|ISO20022.Camt073001.AcknowledgedAcceptedStatus21Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Cmpltd),validElement(Dnd),validElement(Rpr),validElement(Rjctd),validElement(Pdg),validElement(AckdAccptd),validChoice(Prtry,Cmpltd,Dnd,Rpr,Rjctd,Pdg,AckdAccptd))|

---

## Value ISO20022.Camt073001.ProprietaryReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Camt073001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Camt073001.ProprietaryStatusAndReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Camt073001.ProprietaryReason4>||XmlElement()||
|+|PrtrySts|ISO20022.Camt073001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Camt073001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Camt073001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt073001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt073001.References14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PoolId|String||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt073001.References34Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrTxId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|IntraBalMvmntId|String||XmlElement()||
|+|IntraPosMvmntId|String||XmlElement()||
|+|SctiesSttlmTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(OthrTxId,PoolId,MktInfrstrctrTxId,AcctSvcrTxId,IntraBalMvmntId,IntraPosMvmntId,SctiesSttlmTxId))|

---

## Value ISO20022.Camt073001.RejectionAndRepairReason33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt073001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt073001.RejectionAndRepairReason34Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt073001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt073001.RejectionOrRepairReason33


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Camt073001.RejectionAndRepairReason33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Camt073001.RejectionOrRepairReason34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Camt073001.RejectionAndRepairReason34Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Camt073001.RejectionOrRepairStatus39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Camt073001.RejectionOrRepairReason33>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Camt073001.RejectionOrRepairStatus40Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Camt073001.RejectionOrRepairReason34>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Camt073001.RejectionReason34Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REFE|Int32||XmlEnum("""REFE""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||NRGN|Int32||XmlEnum("""NRGN""")|3|
||NRGM|Int32||XmlEnum("""NRGM""")|4|
||CASH|Int32||XmlEnum("""CASH""")|5|
||LATE|Int32||XmlEnum("""LATE""")|6|
||ADEA|Int32||XmlEnum("""ADEA""")|7|

---

## Enum ISO20022.Camt073001.RejectionReason35Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INVL|Int32||XmlEnum("""INVL""")|1|
||INVM|Int32||XmlEnum("""INVM""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||NRGN|Int32||XmlEnum("""NRGN""")|4|
||DDAT|Int32||XmlEnum("""DDAT""")|5|
||LATE|Int32||XmlEnum("""LATE""")|6|
||REFE|Int32||XmlEnum("""REFE""")|7|
||ADEA|Int32||XmlEnum("""ADEA""")|8|
||CASH|Int32||XmlEnum("""CASH""")|9|

---

## Value ISO20022.Camt073001.RequestDetails22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lnkgs|global::System.Collections.Generic.List<ISO20022.Camt073001.Linkages57>||XmlElement()||
|+|ClrChanl|String||XmlElement()||
|+|PrtlSttlmInd|String||XmlElement()||
|+|OthrPrcg|global::System.Collections.Generic.List<ISO20022.Camt073001.GenericIdentification30>||XmlElement()||
|+|Prty|ISO20022.Camt073001.PriorityNumeric4Choice||XmlElement()||
|+|Lkg|ISO20022.Camt073001.LinkageType3Choice||XmlElement()||
|+|Ref|ISO20022.Camt073001.References14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Lnkgs""",Lnkgs),validElement(Lnkgs),validList("""OthrPrcg""",OthrPrcg),validElement(OthrPrcg),validElement(Prty),validElement(Lkg),validElement(Ref))|

---

## Value ISO20022.Camt073001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt073001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt073001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt073001.SystemPartyIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RspnsblPtyId|ISO20022.Camt073001.PartyIdentification136||XmlElement()||
|+|Id|ISO20022.Camt073001.PartyIdentification136||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RspnsblPtyId),validElement(Id))|

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

