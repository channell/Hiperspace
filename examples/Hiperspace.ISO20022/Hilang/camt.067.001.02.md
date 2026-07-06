# camt.067.001.02
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Camt067001.AccountIdentification4Choice {
        + Othr  : ISO20022.Camt067001.GenericAccountIdentification1
        + IBAN  : String
    }
    ISO20022.Camt067001.AccountIdentification4Choice *-- ISO20022.Camt067001.GenericAccountIdentification1
    class ISO20022.Camt067001.AccountSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt067001.AcknowledgedAcceptedStatus21Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Camt067001.AcknowledgementReason9~
        + NoSpcfdRsn  : String
    }
    ISO20022.Camt067001.AcknowledgedAcceptedStatus21Choice *-- ISO20022.Camt067001.AcknowledgementReason9
    class ISO20022.Camt067001.AcknowledgementReason12Choice {
        + Prtry  : ISO20022.Camt067001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt067001.AcknowledgementReason12Choice *-- ISO20022.Camt067001.GenericIdentification30
    class ISO20022.Camt067001.AcknowledgementReason5Code {
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
    class ISO20022.Camt067001.AcknowledgementReason9 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Camt067001.AcknowledgementReason12Choice
    }
    ISO20022.Camt067001.AcknowledgementReason9 *-- ISO20022.Camt067001.AcknowledgementReason12Choice
    class ISO20022.Camt067001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Camt067001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Camt067001.AddressType3Choice {
        + Prtry  : ISO20022.Camt067001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt067001.AddressType3Choice *-- ISO20022.Camt067001.GenericIdentification30
    class ISO20022.Camt067001.Amount2Choice {
        + AmtWthCcy  : ISO20022.Camt067001.ActiveCurrencyAndAmount
        + AmtWthtCcy  : Decimal
    }
    ISO20022.Camt067001.Amount2Choice *-- ISO20022.Camt067001.ActiveCurrencyAndAmount
    class ISO20022.Camt067001.AmountAndDirection5 {
        + CdtDbt  : String
        + Amt  : ISO20022.Camt067001.ActiveCurrencyAndAmount
    }
    ISO20022.Camt067001.AmountAndDirection5 *-- ISO20022.Camt067001.ActiveCurrencyAndAmount
    class ISO20022.Camt067001.AmountAndQuantityBreakdown1 {
        + CshSubBalTp  : ISO20022.Camt067001.GenericIdentification30
        + LotQty  : ISO20022.Camt067001.FinancialInstrumentQuantity1Choice
        + LotAmt  : ISO20022.Camt067001.AmountAndDirection5
        + LotNb  : ISO20022.Camt067001.GenericIdentification37
    }
    ISO20022.Camt067001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt067001.GenericIdentification30
    ISO20022.Camt067001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt067001.FinancialInstrumentQuantity1Choice
    ISO20022.Camt067001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt067001.AmountAndDirection5
    ISO20022.Camt067001.AmountAndQuantityBreakdown1 *-- ISO20022.Camt067001.GenericIdentification37
    class ISO20022.Camt067001.BranchAndFinancialInstitutionIdentification8 {
        + BrnchId  : ISO20022.Camt067001.BranchData5
        + FinInstnId  : ISO20022.Camt067001.FinancialInstitutionIdentification23
    }
    ISO20022.Camt067001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt067001.BranchData5
    ISO20022.Camt067001.BranchAndFinancialInstitutionIdentification8 *-- ISO20022.Camt067001.FinancialInstitutionIdentification23
    class ISO20022.Camt067001.BranchData5 {
        + PstlAdr  : ISO20022.Camt067001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + Id  : String
    }
    ISO20022.Camt067001.BranchData5 *-- ISO20022.Camt067001.PostalAddress27
    class ISO20022.Camt067001.CancellationReason19Choice {
        + Prtry  : ISO20022.Camt067001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt067001.CancellationReason19Choice *-- ISO20022.Camt067001.GenericIdentification30
    class ISO20022.Camt067001.CancellationReason9 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Camt067001.CancellationReason19Choice
    }
    ISO20022.Camt067001.CancellationReason9 *-- ISO20022.Camt067001.CancellationReason19Choice
    class ISO20022.Camt067001.CancellationStatus14Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Camt067001.CancellationReason9~
        + NoSpcfdRsn  : String
    }
    ISO20022.Camt067001.CancellationStatus14Choice *-- ISO20022.Camt067001.CancellationReason9
    class ISO20022.Camt067001.CancelledStatusReason13Code {
        CTHP = 1
        OTHR = 2
        SCEX = 3
        CORP = 4
        CANZ = 5
        CANT = 6
        CXLR = 7
        CSUB = 8
        CANS = 9
        CANI = 10
    }
    class ISO20022.Camt067001.CashAccount40 {
        + Prxy  : ISO20022.Camt067001.ProxyAccountIdentification1
        + Nm  : String
        + Ccy  : String
        + Tp  : ISO20022.Camt067001.CashAccountType2Choice
        + Id  : ISO20022.Camt067001.AccountIdentification4Choice
    }
    ISO20022.Camt067001.CashAccount40 *-- ISO20022.Camt067001.ProxyAccountIdentification1
    ISO20022.Camt067001.CashAccount40 *-- ISO20022.Camt067001.CashAccountType2Choice
    ISO20022.Camt067001.CashAccount40 *-- ISO20022.Camt067001.AccountIdentification4Choice
    class ISO20022.Camt067001.CashAccountType2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt067001.CashBalanceType3Choice {
        + Prtry  : ISO20022.Camt067001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt067001.CashBalanceType3Choice *-- ISO20022.Camt067001.GenericIdentification30
    class ISO20022.Camt067001.CashSubBalanceTypeAndQuantityBreakdown3 {
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Camt067001.AmountAndQuantityBreakdown1~
        + Tp  : ISO20022.Camt067001.CashBalanceType3Choice
    }
    ISO20022.Camt067001.CashSubBalanceTypeAndQuantityBreakdown3 *-- ISO20022.Camt067001.AmountAndQuantityBreakdown1
    ISO20022.Camt067001.CashSubBalanceTypeAndQuantityBreakdown3 *-- ISO20022.Camt067001.CashBalanceType3Choice
    class ISO20022.Camt067001.ClearingSystemIdentification2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt067001.ClearingSystemMemberIdentification2 {
        + MmbId  : String
        + ClrSysId  : ISO20022.Camt067001.ClearingSystemIdentification2Choice
    }
    ISO20022.Camt067001.ClearingSystemMemberIdentification2 *-- ISO20022.Camt067001.ClearingSystemIdentification2Choice
    class ISO20022.Camt067001.CopyDuplicate1Code {
        DUPL = 1
        COPY = 2
        CODU = 3
    }
    class ISO20022.Camt067001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Camt067001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Camt067001.DocumentIdentification51 {
        + MsgRcpt  : ISO20022.Camt067001.PartyIdentification136
        + MsgOrgtr  : ISO20022.Camt067001.PartyIdentification136
        + CpyDplct  : String
        + CreDtTm  : ISO20022.Camt067001.DateAndDateTime2Choice
        + Id  : String
    }
    ISO20022.Camt067001.DocumentIdentification51 *-- ISO20022.Camt067001.PartyIdentification136
    ISO20022.Camt067001.DocumentIdentification51 *-- ISO20022.Camt067001.PartyIdentification136
    ISO20022.Camt067001.DocumentIdentification51 *-- ISO20022.Camt067001.DateAndDateTime2Choice
    class ISO20022.Camt067001.FailingReason3Code {
        INBC = 1
        PRSY = 2
        CERT = 3
        SETS = 4
        REGT = 5
        PRCY = 6
        LIQU = 7
        LATE = 8
        LAAW = 9
        FROZ = 10
        DKNY = 11
        DISA = 12
        DENO = 13
        CLHT = 14
        BOTH = 15
        BENO = 16
        PHCK = 17
        OTHR = 18
        IAAD = 19
        MINO = 20
        CPEC = 21
        SBLO = 22
        CYCL = 23
        BATC = 24
        SDUT = 25
        REFS = 26
        NCON = 27
        MONY = 28
        LALO = 29
        LACK = 30
        LINK = 31
        INCA = 32
        FLIM = 33
        DEPO = 34
        COLL = 35
        YCOL = 36
        CMON = 37
        NOFX = 38
        PART = 39
        PREA = 40
        GLOB = 41
        MUNO = 42
        CLAC = 43
        NEWI = 44
        CHAS = 45
        BLOC = 46
        DOCC = 47
        MLAT = 48
        DOCY = 49
        STCD = 50
        PHSE = 51
        AWSH = 52
        OBJT = 53
        CAIS = 54
        CANR = 55
        ADEA = 56
        CLAT = 57
        BYIY = 58
        AWMO = 59
    }
    class ISO20022.Camt067001.FailingReason7 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Camt067001.FailingReason7Choice
    }
    ISO20022.Camt067001.FailingReason7 *-- ISO20022.Camt067001.FailingReason7Choice
    class ISO20022.Camt067001.FailingReason7Choice {
        + Prtry  : ISO20022.Camt067001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt067001.FailingReason7Choice *-- ISO20022.Camt067001.GenericIdentification30
    class ISO20022.Camt067001.FailingStatus9Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Camt067001.FailingReason7~
        + NoSpcfdRsn  : String
    }
    ISO20022.Camt067001.FailingStatus9Choice *-- ISO20022.Camt067001.FailingReason7
    class ISO20022.Camt067001.FinancialIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt067001.FinancialInstitutionIdentification23 {
        + Othr  : ISO20022.Camt067001.GenericFinancialIdentification1
        + PstlAdr  : ISO20022.Camt067001.PostalAddress27
        + Nm  : String
        + LEI  : String
        + ClrSysMmbId  : ISO20022.Camt067001.ClearingSystemMemberIdentification2
        + BICFI  : String
    }
    ISO20022.Camt067001.FinancialInstitutionIdentification23 *-- ISO20022.Camt067001.GenericFinancialIdentification1
    ISO20022.Camt067001.FinancialInstitutionIdentification23 *-- ISO20022.Camt067001.PostalAddress27
    ISO20022.Camt067001.FinancialInstitutionIdentification23 *-- ISO20022.Camt067001.ClearingSystemMemberIdentification2
    class ISO20022.Camt067001.FinancialInstrumentQuantity1Choice {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Camt067001.GenericAccountIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt067001.AccountSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt067001.GenericAccountIdentification1 *-- ISO20022.Camt067001.AccountSchemeName1Choice
    class ISO20022.Camt067001.GenericFinancialIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Camt067001.FinancialIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Camt067001.GenericFinancialIdentification1 *-- ISO20022.Camt067001.FinancialIdentificationSchemeName1Choice
    class ISO20022.Camt067001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt067001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt067001.GenericIdentification37 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Camt067001.IntraBalance5 {
        + InstrPrcgAddtlDtls  : String
        + Prty  : ISO20022.Camt067001.PriorityNumeric4Choice
        + CshSubBalId  : ISO20022.Camt067001.GenericIdentification37
        + BalTo  : ISO20022.Camt067001.CashSubBalanceTypeAndQuantityBreakdown3
        + BalFr  : ISO20022.Camt067001.CashSubBalanceTypeAndQuantityBreakdown3
        + SttlmDt  : ISO20022.Camt067001.DateAndDateTime2Choice
        + SttlmAmt  : ISO20022.Camt067001.Amount2Choice
    }
    ISO20022.Camt067001.IntraBalance5 *-- ISO20022.Camt067001.PriorityNumeric4Choice
    ISO20022.Camt067001.IntraBalance5 *-- ISO20022.Camt067001.GenericIdentification37
    ISO20022.Camt067001.IntraBalance5 *-- ISO20022.Camt067001.CashSubBalanceTypeAndQuantityBreakdown3
    ISO20022.Camt067001.IntraBalance5 *-- ISO20022.Camt067001.CashSubBalanceTypeAndQuantityBreakdown3
    ISO20022.Camt067001.IntraBalance5 *-- ISO20022.Camt067001.DateAndDateTime2Choice
    ISO20022.Camt067001.IntraBalance5 *-- ISO20022.Camt067001.Amount2Choice
    class ISO20022.Camt067001.IntraBalanceMovementStatusAdviceV02 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Camt067001.SupplementaryData1~
        + UndrlygIntraBal  : ISO20022.Camt067001.IntraBalance5
        + CshAcctSvcr  : ISO20022.Camt067001.BranchAndFinancialInstitutionIdentification8
        + CshAcctOwnr  : ISO20022.Camt067001.SystemPartyIdentification8
        + CshAcct  : ISO20022.Camt067001.CashAccount40
        + SttlmSts  : ISO20022.Camt067001.SettlementStatus16Choice
        + PrcgSts  : ISO20022.Camt067001.ProcessingStatus67Choice
        + TxId  : ISO20022.Camt067001.TransactionIdentifications24
        + Id  : ISO20022.Camt067001.DocumentIdentification51
    }
    ISO20022.Camt067001.IntraBalanceMovementStatusAdviceV02 *-- ISO20022.Camt067001.SupplementaryData1
    ISO20022.Camt067001.IntraBalanceMovementStatusAdviceV02 *-- ISO20022.Camt067001.IntraBalance5
    ISO20022.Camt067001.IntraBalanceMovementStatusAdviceV02 *-- ISO20022.Camt067001.BranchAndFinancialInstitutionIdentification8
    ISO20022.Camt067001.IntraBalanceMovementStatusAdviceV02 *-- ISO20022.Camt067001.SystemPartyIdentification8
    ISO20022.Camt067001.IntraBalanceMovementStatusAdviceV02 *-- ISO20022.Camt067001.CashAccount40
    ISO20022.Camt067001.IntraBalanceMovementStatusAdviceV02 *-- ISO20022.Camt067001.SettlementStatus16Choice
    ISO20022.Camt067001.IntraBalanceMovementStatusAdviceV02 *-- ISO20022.Camt067001.ProcessingStatus67Choice
    ISO20022.Camt067001.IntraBalanceMovementStatusAdviceV02 *-- ISO20022.Camt067001.TransactionIdentifications24
    ISO20022.Camt067001.IntraBalanceMovementStatusAdviceV02 *-- ISO20022.Camt067001.DocumentIdentification51
    class ISO20022.Camt067001.NameAndAddress5 {
        + Adr  : ISO20022.Camt067001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Camt067001.NameAndAddress5 *-- ISO20022.Camt067001.PostalAddress1
    class ISO20022.Camt067001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Camt067001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Camt067001.NameAndAddress5
        + PrtryId  : ISO20022.Camt067001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Camt067001.PartyIdentification120Choice *-- ISO20022.Camt067001.NameAndAddress5
    ISO20022.Camt067001.PartyIdentification120Choice *-- ISO20022.Camt067001.GenericIdentification36
    class ISO20022.Camt067001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Camt067001.PartyIdentification120Choice
    }
    ISO20022.Camt067001.PartyIdentification136 *-- ISO20022.Camt067001.PartyIdentification120Choice
    class ISO20022.Camt067001.PendingReason10Code {
        INBC = 1
        PRSY = 2
        CERT = 3
        SETS = 4
        REGT = 5
        PRCY = 6
        LIQU = 7
        LATE = 8
        LAAW = 9
        FROZ = 10
        DKNY = 11
        DISA = 12
        DENO = 13
        CLHT = 14
        BOTH = 15
        BENO = 16
        PHCK = 17
        OTHR = 18
        IAAD = 19
        MINO = 20
        CPEC = 21
        SBLO = 22
        CYCL = 23
        BATC = 24
        SDUT = 25
        REFS = 26
        NCON = 27
        MONY = 28
        LALO = 29
        LACK = 30
        FUTU = 31
        LINK = 32
        INCA = 33
        FLIM = 34
        DEPO = 35
        COLL = 36
        YCOL = 37
        CMON = 38
        NOFX = 39
        NMAS = 40
        PART = 41
        PREA = 42
        GLOB = 43
        MUNO = 44
        CLAC = 45
        NEWI = 46
        CHAS = 47
        BLOC = 48
        DOCC = 49
        DOCY = 50
        TAMM = 51
        PHSE = 52
        AWSH = 53
        REFU = 54
        CAIS = 55
        ADEA = 56
        AWMO = 57
    }
    class ISO20022.Camt067001.PendingReason14 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Camt067001.PendingReason26Choice
    }
    ISO20022.Camt067001.PendingReason14 *-- ISO20022.Camt067001.PendingReason26Choice
    class ISO20022.Camt067001.PendingReason26Choice {
        + Prtry  : ISO20022.Camt067001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt067001.PendingReason26Choice *-- ISO20022.Camt067001.GenericIdentification30
    class ISO20022.Camt067001.PendingStatus36Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Camt067001.PendingReason14~
        + NoSpcfdRsn  : String
    }
    ISO20022.Camt067001.PendingStatus36Choice *-- ISO20022.Camt067001.PendingReason14
    class ISO20022.Camt067001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Camt067001.PostalAddress27 {
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
        + AdrTp  : ISO20022.Camt067001.AddressType3Choice
    }
    ISO20022.Camt067001.PostalAddress27 *-- ISO20022.Camt067001.AddressType3Choice
    class ISO20022.Camt067001.PriorityNumeric4Choice {
        + Prtry  : ISO20022.Camt067001.GenericIdentification30
        + Nmrc  : String
    }
    ISO20022.Camt067001.PriorityNumeric4Choice *-- ISO20022.Camt067001.GenericIdentification30
    class ISO20022.Camt067001.ProcessingStatus67Choice {
        + Prtry  : ISO20022.Camt067001.ProprietaryStatusAndReason6
        + AckdAccptd  : ISO20022.Camt067001.AcknowledgedAcceptedStatus21Choice
        + Canc  : ISO20022.Camt067001.CancellationStatus14Choice
        + Rpr  : ISO20022.Camt067001.RejectionOrRepairStatus38Choice
        + Rjctd  : ISO20022.Camt067001.RejectionOrRepairStatus38Choice
    }
    ISO20022.Camt067001.ProcessingStatus67Choice *-- ISO20022.Camt067001.ProprietaryStatusAndReason6
    ISO20022.Camt067001.ProcessingStatus67Choice *-- ISO20022.Camt067001.AcknowledgedAcceptedStatus21Choice
    ISO20022.Camt067001.ProcessingStatus67Choice *-- ISO20022.Camt067001.CancellationStatus14Choice
    ISO20022.Camt067001.ProcessingStatus67Choice *-- ISO20022.Camt067001.RejectionOrRepairStatus38Choice
    ISO20022.Camt067001.ProcessingStatus67Choice *-- ISO20022.Camt067001.RejectionOrRepairStatus38Choice
    class ISO20022.Camt067001.ProprietaryReason4 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Camt067001.GenericIdentification30
    }
    ISO20022.Camt067001.ProprietaryReason4 *-- ISO20022.Camt067001.GenericIdentification30
    class ISO20022.Camt067001.ProprietaryStatusAndReason6 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Camt067001.ProprietaryReason4~
        + PrtrySts  : ISO20022.Camt067001.GenericIdentification30
    }
    ISO20022.Camt067001.ProprietaryStatusAndReason6 *-- ISO20022.Camt067001.ProprietaryReason4
    ISO20022.Camt067001.ProprietaryStatusAndReason6 *-- ISO20022.Camt067001.GenericIdentification30
    class ISO20022.Camt067001.ProxyAccountIdentification1 {
        + Id  : String
        + Tp  : ISO20022.Camt067001.ProxyAccountType1Choice
    }
    ISO20022.Camt067001.ProxyAccountIdentification1 *-- ISO20022.Camt067001.ProxyAccountType1Choice
    class ISO20022.Camt067001.ProxyAccountType1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Camt067001.RejectionAndRepairReason32Choice {
        + Prtry  : ISO20022.Camt067001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Camt067001.RejectionAndRepairReason32Choice *-- ISO20022.Camt067001.GenericIdentification30
    class ISO20022.Camt067001.RejectionOrRepairReason32 {
        + AddtlRsnInf  : String
        + Cd  : global::System.Collections.Generic.List~ISO20022.Camt067001.RejectionAndRepairReason32Choice~
    }
    ISO20022.Camt067001.RejectionOrRepairReason32 *-- ISO20022.Camt067001.RejectionAndRepairReason32Choice
    class ISO20022.Camt067001.RejectionOrRepairStatus38Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Camt067001.RejectionOrRepairReason32~
        + NoSpcfdRsn  : String
    }
    ISO20022.Camt067001.RejectionOrRepairStatus38Choice *-- ISO20022.Camt067001.RejectionOrRepairReason32
    class ISO20022.Camt067001.RejectionReason33Code {
        MUNO = 1
        MINO = 2
        DSEC = 3
        DQUA = 4
        OTHR = 5
        REFE = 6
        DDAT = 7
        CAEV = 8
        MONY = 9
        VALR = 10
        INVN = 11
        INVB = 12
        INVL = 13
        LATE = 14
        NCRR = 15
        DMON = 16
        ADEA = 17
        CASH = 18
    }
    class ISO20022.Camt067001.SettlementStatus16Choice {
        + Prtry  : ISO20022.Camt067001.ProprietaryStatusAndReason6
        + Flng  : ISO20022.Camt067001.FailingStatus9Choice
        + Pdg  : ISO20022.Camt067001.PendingStatus36Choice
    }
    ISO20022.Camt067001.SettlementStatus16Choice *-- ISO20022.Camt067001.ProprietaryStatusAndReason6
    ISO20022.Camt067001.SettlementStatus16Choice *-- ISO20022.Camt067001.FailingStatus9Choice
    ISO20022.Camt067001.SettlementStatus16Choice *-- ISO20022.Camt067001.PendingStatus36Choice
    class ISO20022.Camt067001.SupplementaryData1 {
        + Envlp  : ISO20022.Camt067001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Camt067001.SupplementaryData1 *-- ISO20022.Camt067001.SupplementaryDataEnvelope1
    class ISO20022.Camt067001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Camt067001.SystemPartyIdentification8 {
        + RspnsblPtyId  : ISO20022.Camt067001.PartyIdentification136
        + Id  : ISO20022.Camt067001.PartyIdentification136
    }
    ISO20022.Camt067001.SystemPartyIdentification8 *-- ISO20022.Camt067001.PartyIdentification136
    ISO20022.Camt067001.SystemPartyIdentification8 *-- ISO20022.Camt067001.PartyIdentification136
    class ISO20022.Camt067001.TransactionIdentifications24 {
        + PrcrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
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

## Value ISO20022.Camt067001.AccountIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt067001.GenericAccountIdentification1||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Othr,IBAN))|

---

## Value ISO20022.Camt067001.AccountSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt067001.AcknowledgedAcceptedStatus21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Camt067001.AcknowledgementReason9>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Camt067001.AcknowledgementReason12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt067001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Camt067001.AcknowledgementReason5Code


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

## Value ISO20022.Camt067001.AcknowledgementReason9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Camt067001.AcknowledgementReason12Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Camt067001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Camt067001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Camt067001.AddressType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt067001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt067001.Amount2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtWthCcy|ISO20022.Camt067001.ActiveCurrencyAndAmount||XmlElement()||
|+|AmtWthtCcy|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtWthCcy),validChoice(AmtWthCcy,AmtWthtCcy))|

---

## Value ISO20022.Camt067001.AmountAndDirection5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbt|String||XmlElement()||
|+|Amt|ISO20022.Camt067001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Camt067001.AmountAndQuantityBreakdown1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshSubBalTp|ISO20022.Camt067001.GenericIdentification30||XmlElement()||
|+|LotQty|ISO20022.Camt067001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|LotAmt|ISO20022.Camt067001.AmountAndDirection5||XmlElement()||
|+|LotNb|ISO20022.Camt067001.GenericIdentification37||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshSubBalTp),validElement(LotQty),validElement(LotAmt),validElement(LotNb))|

---

## Value ISO20022.Camt067001.BranchAndFinancialInstitutionIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BrnchId|ISO20022.Camt067001.BranchData5||XmlElement()||
|+|FinInstnId|ISO20022.Camt067001.FinancialInstitutionIdentification23||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BrnchId),validElement(FinInstnId))|

---

## Value ISO20022.Camt067001.BranchData5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PstlAdr|ISO20022.Camt067001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""))|

---

## Value ISO20022.Camt067001.CancellationReason19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt067001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt067001.CancellationReason9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Camt067001.CancellationReason19Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Camt067001.CancellationStatus14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Camt067001.CancellationReason9>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Camt067001.CancelledStatusReason13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CTHP|Int32||XmlEnum("""CTHP""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||SCEX|Int32||XmlEnum("""SCEX""")|3|
||CORP|Int32||XmlEnum("""CORP""")|4|
||CANZ|Int32||XmlEnum("""CANZ""")|5|
||CANT|Int32||XmlEnum("""CANT""")|6|
||CXLR|Int32||XmlEnum("""CXLR""")|7|
||CSUB|Int32||XmlEnum("""CSUB""")|8|
||CANS|Int32||XmlEnum("""CANS""")|9|
||CANI|Int32||XmlEnum("""CANI""")|10|

---

## Value ISO20022.Camt067001.CashAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prxy|ISO20022.Camt067001.ProxyAccountIdentification1||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Ccy|String||XmlElement()||
|+|Tp|ISO20022.Camt067001.CashAccountType2Choice||XmlElement()||
|+|Id|ISO20022.Camt067001.AccountIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prxy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(Tp),validElement(Id))|

---

## Value ISO20022.Camt067001.CashAccountType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt067001.CashBalanceType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt067001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt067001.CashSubBalanceTypeAndQuantityBreakdown3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Camt067001.AmountAndQuantityBreakdown1>||XmlElement()||
|+|Tp|ISO20022.Camt067001.CashBalanceType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(Tp))|

---

## Value ISO20022.Camt067001.ClearingSystemIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt067001.ClearingSystemMemberIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MmbId|String||XmlElement()||
|+|ClrSysId|ISO20022.Camt067001.ClearingSystemIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClrSysId))|

---

## Enum ISO20022.Camt067001.CopyDuplicate1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DUPL|Int32||XmlEnum("""DUPL""")|1|
||COPY|Int32||XmlEnum("""COPY""")|2|
||CODU|Int32||XmlEnum("""CODU""")|3|

---

## Enum ISO20022.Camt067001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Camt067001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Type ISO20022.Camt067001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntraBalMvmntStsAdvc|ISO20022.Camt067001.IntraBalanceMovementStatusAdviceV02||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntraBalMvmntStsAdvc))|

---

## Value ISO20022.Camt067001.DocumentIdentification51


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgRcpt|ISO20022.Camt067001.PartyIdentification136||XmlElement()||
|+|MsgOrgtr|ISO20022.Camt067001.PartyIdentification136||XmlElement()||
|+|CpyDplct|String||XmlElement()||
|+|CreDtTm|ISO20022.Camt067001.DateAndDateTime2Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MsgRcpt),validElement(MsgOrgtr),validElement(CreDtTm))|

---

## Enum ISO20022.Camt067001.FailingReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INBC|Int32||XmlEnum("""INBC""")|1|
||PRSY|Int32||XmlEnum("""PRSY""")|2|
||CERT|Int32||XmlEnum("""CERT""")|3|
||SETS|Int32||XmlEnum("""SETS""")|4|
||REGT|Int32||XmlEnum("""REGT""")|5|
||PRCY|Int32||XmlEnum("""PRCY""")|6|
||LIQU|Int32||XmlEnum("""LIQU""")|7|
||LATE|Int32||XmlEnum("""LATE""")|8|
||LAAW|Int32||XmlEnum("""LAAW""")|9|
||FROZ|Int32||XmlEnum("""FROZ""")|10|
||DKNY|Int32||XmlEnum("""DKNY""")|11|
||DISA|Int32||XmlEnum("""DISA""")|12|
||DENO|Int32||XmlEnum("""DENO""")|13|
||CLHT|Int32||XmlEnum("""CLHT""")|14|
||BOTH|Int32||XmlEnum("""BOTH""")|15|
||BENO|Int32||XmlEnum("""BENO""")|16|
||PHCK|Int32||XmlEnum("""PHCK""")|17|
||OTHR|Int32||XmlEnum("""OTHR""")|18|
||IAAD|Int32||XmlEnum("""IAAD""")|19|
||MINO|Int32||XmlEnum("""MINO""")|20|
||CPEC|Int32||XmlEnum("""CPEC""")|21|
||SBLO|Int32||XmlEnum("""SBLO""")|22|
||CYCL|Int32||XmlEnum("""CYCL""")|23|
||BATC|Int32||XmlEnum("""BATC""")|24|
||SDUT|Int32||XmlEnum("""SDUT""")|25|
||REFS|Int32||XmlEnum("""REFS""")|26|
||NCON|Int32||XmlEnum("""NCON""")|27|
||MONY|Int32||XmlEnum("""MONY""")|28|
||LALO|Int32||XmlEnum("""LALO""")|29|
||LACK|Int32||XmlEnum("""LACK""")|30|
||LINK|Int32||XmlEnum("""LINK""")|31|
||INCA|Int32||XmlEnum("""INCA""")|32|
||FLIM|Int32||XmlEnum("""FLIM""")|33|
||DEPO|Int32||XmlEnum("""DEPO""")|34|
||COLL|Int32||XmlEnum("""COLL""")|35|
||YCOL|Int32||XmlEnum("""YCOL""")|36|
||CMON|Int32||XmlEnum("""CMON""")|37|
||NOFX|Int32||XmlEnum("""NOFX""")|38|
||PART|Int32||XmlEnum("""PART""")|39|
||PREA|Int32||XmlEnum("""PREA""")|40|
||GLOB|Int32||XmlEnum("""GLOB""")|41|
||MUNO|Int32||XmlEnum("""MUNO""")|42|
||CLAC|Int32||XmlEnum("""CLAC""")|43|
||NEWI|Int32||XmlEnum("""NEWI""")|44|
||CHAS|Int32||XmlEnum("""CHAS""")|45|
||BLOC|Int32||XmlEnum("""BLOC""")|46|
||DOCC|Int32||XmlEnum("""DOCC""")|47|
||MLAT|Int32||XmlEnum("""MLAT""")|48|
||DOCY|Int32||XmlEnum("""DOCY""")|49|
||STCD|Int32||XmlEnum("""STCD""")|50|
||PHSE|Int32||XmlEnum("""PHSE""")|51|
||AWSH|Int32||XmlEnum("""AWSH""")|52|
||OBJT|Int32||XmlEnum("""OBJT""")|53|
||CAIS|Int32||XmlEnum("""CAIS""")|54|
||CANR|Int32||XmlEnum("""CANR""")|55|
||ADEA|Int32||XmlEnum("""ADEA""")|56|
||CLAT|Int32||XmlEnum("""CLAT""")|57|
||BYIY|Int32||XmlEnum("""BYIY""")|58|
||AWMO|Int32||XmlEnum("""AWMO""")|59|

---

## Value ISO20022.Camt067001.FailingReason7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Camt067001.FailingReason7Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Camt067001.FailingReason7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt067001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt067001.FailingStatus9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Camt067001.FailingReason7>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Camt067001.FinancialIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt067001.FinancialInstitutionIdentification23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|ISO20022.Camt067001.GenericFinancialIdentification1||XmlElement()||
|+|PstlAdr|ISO20022.Camt067001.PostalAddress27||XmlElement()||
|+|Nm|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|ClrSysMmbId|ISO20022.Camt067001.ClearingSystemMemberIdentification2||XmlElement()||
|+|BICFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Othr),validElement(PstlAdr),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(ClrSysMmbId),validPattern("""BICFI""",BICFI,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Camt067001.FinancialInstrumentQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Camt067001.GenericAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt067001.AccountSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt067001.GenericFinancialIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Camt067001.FinancialIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Camt067001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Camt067001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt067001.GenericIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt067001.IntraBalance5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrPrcgAddtlDtls|String||XmlElement()||
|+|Prty|ISO20022.Camt067001.PriorityNumeric4Choice||XmlElement()||
|+|CshSubBalId|ISO20022.Camt067001.GenericIdentification37||XmlElement()||
|+|BalTo|ISO20022.Camt067001.CashSubBalanceTypeAndQuantityBreakdown3||XmlElement()||
|+|BalFr|ISO20022.Camt067001.CashSubBalanceTypeAndQuantityBreakdown3||XmlElement()||
|+|SttlmDt|ISO20022.Camt067001.DateAndDateTime2Choice||XmlElement()||
|+|SttlmAmt|ISO20022.Camt067001.Amount2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prty),validElement(CshSubBalId),validElement(BalTo),validElement(BalFr),validElement(SttlmDt),validElement(SttlmAmt))|

---

## Aspect ISO20022.Camt067001.IntraBalanceMovementStatusAdviceV02


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Camt067001.SupplementaryData1>||XmlElement()||
|+|UndrlygIntraBal|ISO20022.Camt067001.IntraBalance5||XmlElement()||
|+|CshAcctSvcr|ISO20022.Camt067001.BranchAndFinancialInstitutionIdentification8||XmlElement()||
|+|CshAcctOwnr|ISO20022.Camt067001.SystemPartyIdentification8||XmlElement()||
|+|CshAcct|ISO20022.Camt067001.CashAccount40||XmlElement()||
|+|SttlmSts|ISO20022.Camt067001.SettlementStatus16Choice||XmlElement()||
|+|PrcgSts|ISO20022.Camt067001.ProcessingStatus67Choice||XmlElement()||
|+|TxId|ISO20022.Camt067001.TransactionIdentifications24||XmlElement()||
|+|Id|ISO20022.Camt067001.DocumentIdentification51||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(UndrlygIntraBal),validElement(CshAcctSvcr),validElement(CshAcctOwnr),validElement(CshAcct),validElement(SttlmSts),validElement(PrcgSts),validElement(TxId),validElement(Id))|

---

## Value ISO20022.Camt067001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Camt067001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Camt067001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Camt067001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Camt067001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Camt067001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Camt067001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Camt067001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Enum ISO20022.Camt067001.PendingReason10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INBC|Int32||XmlEnum("""INBC""")|1|
||PRSY|Int32||XmlEnum("""PRSY""")|2|
||CERT|Int32||XmlEnum("""CERT""")|3|
||SETS|Int32||XmlEnum("""SETS""")|4|
||REGT|Int32||XmlEnum("""REGT""")|5|
||PRCY|Int32||XmlEnum("""PRCY""")|6|
||LIQU|Int32||XmlEnum("""LIQU""")|7|
||LATE|Int32||XmlEnum("""LATE""")|8|
||LAAW|Int32||XmlEnum("""LAAW""")|9|
||FROZ|Int32||XmlEnum("""FROZ""")|10|
||DKNY|Int32||XmlEnum("""DKNY""")|11|
||DISA|Int32||XmlEnum("""DISA""")|12|
||DENO|Int32||XmlEnum("""DENO""")|13|
||CLHT|Int32||XmlEnum("""CLHT""")|14|
||BOTH|Int32||XmlEnum("""BOTH""")|15|
||BENO|Int32||XmlEnum("""BENO""")|16|
||PHCK|Int32||XmlEnum("""PHCK""")|17|
||OTHR|Int32||XmlEnum("""OTHR""")|18|
||IAAD|Int32||XmlEnum("""IAAD""")|19|
||MINO|Int32||XmlEnum("""MINO""")|20|
||CPEC|Int32||XmlEnum("""CPEC""")|21|
||SBLO|Int32||XmlEnum("""SBLO""")|22|
||CYCL|Int32||XmlEnum("""CYCL""")|23|
||BATC|Int32||XmlEnum("""BATC""")|24|
||SDUT|Int32||XmlEnum("""SDUT""")|25|
||REFS|Int32||XmlEnum("""REFS""")|26|
||NCON|Int32||XmlEnum("""NCON""")|27|
||MONY|Int32||XmlEnum("""MONY""")|28|
||LALO|Int32||XmlEnum("""LALO""")|29|
||LACK|Int32||XmlEnum("""LACK""")|30|
||FUTU|Int32||XmlEnum("""FUTU""")|31|
||LINK|Int32||XmlEnum("""LINK""")|32|
||INCA|Int32||XmlEnum("""INCA""")|33|
||FLIM|Int32||XmlEnum("""FLIM""")|34|
||DEPO|Int32||XmlEnum("""DEPO""")|35|
||COLL|Int32||XmlEnum("""COLL""")|36|
||YCOL|Int32||XmlEnum("""YCOL""")|37|
||CMON|Int32||XmlEnum("""CMON""")|38|
||NOFX|Int32||XmlEnum("""NOFX""")|39|
||NMAS|Int32||XmlEnum("""NMAS""")|40|
||PART|Int32||XmlEnum("""PART""")|41|
||PREA|Int32||XmlEnum("""PREA""")|42|
||GLOB|Int32||XmlEnum("""GLOB""")|43|
||MUNO|Int32||XmlEnum("""MUNO""")|44|
||CLAC|Int32||XmlEnum("""CLAC""")|45|
||NEWI|Int32||XmlEnum("""NEWI""")|46|
||CHAS|Int32||XmlEnum("""CHAS""")|47|
||BLOC|Int32||XmlEnum("""BLOC""")|48|
||DOCC|Int32||XmlEnum("""DOCC""")|49|
||DOCY|Int32||XmlEnum("""DOCY""")|50|
||TAMM|Int32||XmlEnum("""TAMM""")|51|
||PHSE|Int32||XmlEnum("""PHSE""")|52|
||AWSH|Int32||XmlEnum("""AWSH""")|53|
||REFU|Int32||XmlEnum("""REFU""")|54|
||CAIS|Int32||XmlEnum("""CAIS""")|55|
||ADEA|Int32||XmlEnum("""ADEA""")|56|
||AWMO|Int32||XmlEnum("""AWMO""")|57|

---

## Value ISO20022.Camt067001.PendingReason14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Camt067001.PendingReason26Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Camt067001.PendingReason26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt067001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt067001.PendingStatus36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Camt067001.PendingReason14>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Camt067001.PostalAddress1


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

## Value ISO20022.Camt067001.PostalAddress27


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
|+|AdrTp|ISO20022.Camt067001.AddressType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validListMax("""AdrLine""",AdrLine,7),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(AdrTp))|

---

## Value ISO20022.Camt067001.PriorityNumeric4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt067001.GenericIdentification30||XmlElement()||
|+|Nmrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""Nmrc""",Nmrc,"""[0-9]{4}"""),validChoice(Prtry,Nmrc))|

---

## Value ISO20022.Camt067001.ProcessingStatus67Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt067001.ProprietaryStatusAndReason6||XmlElement()||
|+|AckdAccptd|ISO20022.Camt067001.AcknowledgedAcceptedStatus21Choice||XmlElement()||
|+|Canc|ISO20022.Camt067001.CancellationStatus14Choice||XmlElement()||
|+|Rpr|ISO20022.Camt067001.RejectionOrRepairStatus38Choice||XmlElement()||
|+|Rjctd|ISO20022.Camt067001.RejectionOrRepairStatus38Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(AckdAccptd),validElement(Canc),validElement(Rpr),validElement(Rjctd),validChoice(Prtry,AckdAccptd,Canc,Rpr,Rjctd))|

---

## Value ISO20022.Camt067001.ProprietaryReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Camt067001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Camt067001.ProprietaryStatusAndReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Camt067001.ProprietaryReason4>||XmlElement()||
|+|PrtrySts|ISO20022.Camt067001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Camt067001.ProxyAccountIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Camt067001.ProxyAccountType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Camt067001.ProxyAccountType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt067001.RejectionAndRepairReason32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt067001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Camt067001.RejectionOrRepairReason32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|global::System.Collections.Generic.List<ISO20022.Camt067001.RejectionAndRepairReason32Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Cd""",Cd),validElement(Cd))|

---

## Value ISO20022.Camt067001.RejectionOrRepairStatus38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Camt067001.RejectionOrRepairReason32>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Camt067001.RejectionReason33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MUNO|Int32||XmlEnum("""MUNO""")|1|
||MINO|Int32||XmlEnum("""MINO""")|2|
||DSEC|Int32||XmlEnum("""DSEC""")|3|
||DQUA|Int32||XmlEnum("""DQUA""")|4|
||OTHR|Int32||XmlEnum("""OTHR""")|5|
||REFE|Int32||XmlEnum("""REFE""")|6|
||DDAT|Int32||XmlEnum("""DDAT""")|7|
||CAEV|Int32||XmlEnum("""CAEV""")|8|
||MONY|Int32||XmlEnum("""MONY""")|9|
||VALR|Int32||XmlEnum("""VALR""")|10|
||INVN|Int32||XmlEnum("""INVN""")|11|
||INVB|Int32||XmlEnum("""INVB""")|12|
||INVL|Int32||XmlEnum("""INVL""")|13|
||LATE|Int32||XmlEnum("""LATE""")|14|
||NCRR|Int32||XmlEnum("""NCRR""")|15|
||DMON|Int32||XmlEnum("""DMON""")|16|
||ADEA|Int32||XmlEnum("""ADEA""")|17|
||CASH|Int32||XmlEnum("""CASH""")|18|

---

## Value ISO20022.Camt067001.SettlementStatus16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Camt067001.ProprietaryStatusAndReason6||XmlElement()||
|+|Flng|ISO20022.Camt067001.FailingStatus9Choice||XmlElement()||
|+|Pdg|ISO20022.Camt067001.PendingStatus36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Flng),validElement(Pdg),validChoice(Prtry,Flng,Pdg))|

---

## Value ISO20022.Camt067001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Camt067001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Camt067001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Camt067001.SystemPartyIdentification8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RspnsblPtyId|ISO20022.Camt067001.PartyIdentification136||XmlElement()||
|+|Id|ISO20022.Camt067001.PartyIdentification136||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RspnsblPtyId),validElement(Id))|

---

## Value ISO20022.Camt067001.TransactionIdentifications24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
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

