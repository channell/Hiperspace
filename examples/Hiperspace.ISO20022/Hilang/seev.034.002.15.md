# seev.034.002.15
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev034002.AcceptedReason15Choice {
        + Prtry  : ISO20022.Seev034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev034002.AcceptedReason15Choice *-- ISO20022.Seev034002.GenericIdentification47
    class ISO20022.Seev034002.AcceptedStatus13Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev034002.AcceptedStatusReason14~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev034002.AcceptedStatus13Choice *-- ISO20022.Seev034002.AcceptedStatusReason14
    class ISO20022.Seev034002.AcceptedStatus3 {
        + AccptdRsn  : ISO20022.Seev034002.AcceptedStatus13Choice
        + AccptdQty  : ISO20022.Seev034002.Quantity54Choice
    }
    ISO20022.Seev034002.AcceptedStatus3 *-- ISO20022.Seev034002.AcceptedStatus13Choice
    ISO20022.Seev034002.AcceptedStatus3 *-- ISO20022.Seev034002.Quantity54Choice
    class ISO20022.Seev034002.AcceptedStatusReason14 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev034002.AcceptedReason15Choice
    }
    ISO20022.Seev034002.AcceptedStatusReason14 *-- ISO20022.Seev034002.AcceptedReason15Choice
    class ISO20022.Seev034002.AcknowledgementReason7Code {
        OTHR = 1
        NSTP = 2
    }
    class ISO20022.Seev034002.BlockChainAddressWallet11 {
        + Nm  : String
        + Tp  : ISO20022.Seev034002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Seev034002.BlockChainAddressWallet11 *-- ISO20022.Seev034002.GenericIdentification47
    class ISO20022.Seev034002.CancelledReason13Choice {
        + Prtry  : ISO20022.Seev034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev034002.CancelledReason13Choice *-- ISO20022.Seev034002.GenericIdentification47
    class ISO20022.Seev034002.CancelledStatus17Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev034002.CancelledStatusReason17~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev034002.CancelledStatus17Choice *-- ISO20022.Seev034002.CancelledStatusReason17
    class ISO20022.Seev034002.CancelledStatus6 {
        + CxlRsn  : ISO20022.Seev034002.CancelledStatus17Choice
        + CancQty  : ISO20022.Seev034002.Quantity54Choice
    }
    ISO20022.Seev034002.CancelledStatus6 *-- ISO20022.Seev034002.CancelledStatus17Choice
    ISO20022.Seev034002.CancelledStatus6 *-- ISO20022.Seev034002.Quantity54Choice
    class ISO20022.Seev034002.CancelledStatusReason17 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev034002.CancelledReason13Choice
    }
    ISO20022.Seev034002.CancelledStatusReason17 *-- ISO20022.Seev034002.CancelledReason13Choice
    class ISO20022.Seev034002.CancelledStatusReason6Code {
        OTHR = 1
        CSUB = 2
        CANS = 3
        CANO = 4
        CANI = 5
    }
    class ISO20022.Seev034002.CashAccountIdentification11Choice {
        + Prtry  : String
        + BlckChainCshWllt  : ISO20022.Seev034002.BlockChainAddressWallet11
        + IBAN  : String
    }
    ISO20022.Seev034002.CashAccountIdentification11Choice *-- ISO20022.Seev034002.BlockChainAddressWallet11
    class ISO20022.Seev034002.CorporateActionEventType118Choice {
        + Prtry  : ISO20022.Seev034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev034002.CorporateActionEventType118Choice *-- ISO20022.Seev034002.GenericIdentification47
    class ISO20022.Seev034002.CorporateActionEventType40Code {
        ACCU = 1
        WRTH = 2
        WTRC = 3
        EXWA = 4
        SUSP = 5
        DLST = 6
        TEND = 7
        TREC = 8
        SPLF = 9
        DVSE = 10
        SOFF = 11
        SMAL = 12
        SHPR = 13
        DVSC = 14
        RHTS = 15
        SPLR = 16
        BIDS = 17
        REMK = 18
        REDO = 19
        BPUT = 20
        PRIO = 21
        PDEF = 22
        PLAC = 23
        PINK = 24
        PRED = 25
        PCAL = 26
        PARI = 27
        OTHR = 28
        ODLT = 29
        CERT = 30
        NOOF = 31
        MRGR = 32
        EXTM = 33
        LIQU = 34
        RHDI = 35
        INTR = 36
        PPMT = 37
        INCR = 38
        MCAL = 39
        REDM = 40
        EXOF = 41
        DTCH = 42
        DRAW = 43
        DRIP = 44
        DVOP = 45
        DSCL = 46
        DETI = 47
        DECR = 48
        CREV = 49
        CONV = 50
        CONS = 51
        CLSA = 52
        COOP = 53
        CHAN = 54
        DVCA = 55
        DRCA = 56
        CAPI = 57
        CAPG = 58
        CAPD = 59
        EXRI = 60
        BONU = 61
        DFLT = 62
        BRUP = 63
        ATTI = 64
        ACTV = 65
    }
    class ISO20022.Seev034002.CorporateActionGeneralInformation188 {
        + EvtTp  : ISO20022.Seev034002.CorporateActionEventType118Choice
        + ClssActnNb  : String
        + OffclCorpActnEvtId  : String
        + CorpActnEvtId  : String
    }
    ISO20022.Seev034002.CorporateActionGeneralInformation188 *-- ISO20022.Seev034002.CorporateActionEventType118Choice
    class ISO20022.Seev034002.CorporateActionInstructionStatusAdvice002V15 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev034002.SupplementaryData1~
        + AddtlInf  : ISO20022.Seev034002.CorporateActionNarrative19
        + PrtctInstr  : ISO20022.Seev034002.ProtectInstruction6
        + CorpActnInstr  : ISO20022.Seev034002.CorporateActionOption242
        + InstrPrcgSts  : global::System.Collections.Generic.List~ISO20022.Seev034002.InstructionProcessingStatus58Choice~
        + CorpActnGnlInf  : ISO20022.Seev034002.CorporateActionGeneralInformation188
        + OthrDocId  : global::System.Collections.Generic.List~ISO20022.Seev034002.DocumentIdentification34~
        + InstrId  : ISO20022.Seev034002.DocumentIdentification17
    }
    ISO20022.Seev034002.CorporateActionInstructionStatusAdvice002V15 *-- ISO20022.Seev034002.SupplementaryData1
    ISO20022.Seev034002.CorporateActionInstructionStatusAdvice002V15 *-- ISO20022.Seev034002.CorporateActionNarrative19
    ISO20022.Seev034002.CorporateActionInstructionStatusAdvice002V15 *-- ISO20022.Seev034002.ProtectInstruction6
    ISO20022.Seev034002.CorporateActionInstructionStatusAdvice002V15 *-- ISO20022.Seev034002.CorporateActionOption242
    ISO20022.Seev034002.CorporateActionInstructionStatusAdvice002V15 *-- ISO20022.Seev034002.InstructionProcessingStatus58Choice
    ISO20022.Seev034002.CorporateActionInstructionStatusAdvice002V15 *-- ISO20022.Seev034002.CorporateActionGeneralInformation188
    ISO20022.Seev034002.CorporateActionInstructionStatusAdvice002V15 *-- ISO20022.Seev034002.DocumentIdentification34
    ISO20022.Seev034002.CorporateActionInstructionStatusAdvice002V15 *-- ISO20022.Seev034002.DocumentIdentification17
    class ISO20022.Seev034002.CorporateActionNarrative19 {
        + PtyCtctNrrtv  : global::System.Collections.Generic.List~String~
        + AddtlTxt  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Seev034002.CorporateActionOption17Code {
        BOBD = 1
        PRUN = 2
        TAXI = 3
        SLLE = 4
        SECU = 5
        QINV = 6
        OVER = 7
        OTHR = 8
        OFFR = 9
        NOQU = 10
        NOAC = 11
        MPUT = 12
        MKUP = 13
        MKDW = 14
        LAPS = 15
        EXER = 16
        CTEN = 17
        CONY = 18
        CONN = 19
        CEXC = 20
        CASH = 21
        CASE = 22
        BUYA = 23
        BSPL = 24
        ABST = 25
    }
    class ISO20022.Seev034002.CorporateActionOption242 {
        + SlctnDealrFeeInd  : String
        + StsCshAmt  : ISO20022.Seev034002.RestrictedFINActiveCurrencyAndAmount
        + StsQty  : ISO20022.Seev034002.Quantity54Choice
        + PrtctBal  : ISO20022.Seev034002.SignedQuantityFormat11
        + UinstdBal  : ISO20022.Seev034002.SignedQuantityFormat12
        + InstdBal  : ISO20022.Seev034002.SignedQuantityFormat12
        + TtlElgblBal  : ISO20022.Seev034002.SignedQuantityFormat12
        + FinInstrmId  : ISO20022.Seev034002.SecurityIdentification20
        + SfkpgPlc  : ISO20022.Seev034002.SafekeepingPlaceFormat47Choice
        + CshAcct  : ISO20022.Seev034002.CashAccountIdentification11Choice
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
        + AcctOwnr  : ISO20022.Seev034002.PartyIdentification136Choice
        + OptnFeatrs  : ISO20022.Seev034002.OptionFeaturesFormat27Choice
        + OptnTp  : ISO20022.Seev034002.CorporateActionOption42Choice
        + OptnNb  : ISO20022.Seev034002.OptionNumber1Choice
    }
    ISO20022.Seev034002.CorporateActionOption242 *-- ISO20022.Seev034002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev034002.CorporateActionOption242 *-- ISO20022.Seev034002.Quantity54Choice
    ISO20022.Seev034002.CorporateActionOption242 *-- ISO20022.Seev034002.SignedQuantityFormat11
    ISO20022.Seev034002.CorporateActionOption242 *-- ISO20022.Seev034002.SignedQuantityFormat12
    ISO20022.Seev034002.CorporateActionOption242 *-- ISO20022.Seev034002.SignedQuantityFormat12
    ISO20022.Seev034002.CorporateActionOption242 *-- ISO20022.Seev034002.SignedQuantityFormat12
    ISO20022.Seev034002.CorporateActionOption242 *-- ISO20022.Seev034002.SecurityIdentification20
    ISO20022.Seev034002.CorporateActionOption242 *-- ISO20022.Seev034002.SafekeepingPlaceFormat47Choice
    ISO20022.Seev034002.CorporateActionOption242 *-- ISO20022.Seev034002.CashAccountIdentification11Choice
    ISO20022.Seev034002.CorporateActionOption242 *-- ISO20022.Seev034002.PartyIdentification136Choice
    ISO20022.Seev034002.CorporateActionOption242 *-- ISO20022.Seev034002.OptionFeaturesFormat27Choice
    ISO20022.Seev034002.CorporateActionOption242 *-- ISO20022.Seev034002.CorporateActionOption42Choice
    ISO20022.Seev034002.CorporateActionOption242 *-- ISO20022.Seev034002.OptionNumber1Choice
    class ISO20022.Seev034002.CorporateActionOption42Choice {
        + Prtry  : ISO20022.Seev034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev034002.CorporateActionOption42Choice *-- ISO20022.Seev034002.GenericIdentification47
    class ISO20022.Seev034002.DocumentIdentification17 {
        + Id  : String
    }
    class ISO20022.Seev034002.DocumentIdentification34 {
        + DocNb  : ISO20022.Seev034002.DocumentNumber6Choice
        + Id  : ISO20022.Seev034002.DocumentIdentification4Choice
    }
    ISO20022.Seev034002.DocumentIdentification34 *-- ISO20022.Seev034002.DocumentNumber6Choice
    ISO20022.Seev034002.DocumentIdentification34 *-- ISO20022.Seev034002.DocumentIdentification4Choice
    class ISO20022.Seev034002.DocumentIdentification4Choice {
        + AcctOwnrDocId  : String
        + AcctSvcrDocId  : String
    }
    class ISO20022.Seev034002.DocumentNumber6Choice {
        + PrtryNb  : ISO20022.Seev034002.GenericIdentification86
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Seev034002.DocumentNumber6Choice *-- ISO20022.Seev034002.GenericIdentification86
    class ISO20022.Seev034002.FinancialInstrumentQuantity31Choice {
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev034002.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev034002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev034002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev034002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev034002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Seev034002.GenericIdentification47
    }
    ISO20022.Seev034002.GenericIdentification85 *-- ISO20022.Seev034002.GenericIdentification47
    class ISO20022.Seev034002.GenericIdentification86 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev034002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev034002.InstructionProcessingStatus58Choice {
        + PrtrySts  : ISO20022.Seev034002.ProprietaryStatusAndReason7
        + RcvdByIssrOrOfferr  : ISO20022.Seev034002.NoSpecifiedReason1
        + StgInstr  : ISO20022.Seev034002.NoSpecifiedReason1
        + DfltActn  : ISO20022.Seev034002.NoSpecifiedReason1
        + Rtrd  : ISO20022.Seev034002.ReturnedStatus1Choice
        + Pdg  : ISO20022.Seev034002.PendingStatus2
        + Rjctd  : ISO20022.Seev034002.RejectedStatus12
        + Fwdd  : ISO20022.Seev034002.NoSpecifiedReason1
        + AccptdForFrthrPrcg  : ISO20022.Seev034002.AcceptedStatus3
        + Canc  : ISO20022.Seev034002.CancelledStatus6
    }
    ISO20022.Seev034002.InstructionProcessingStatus58Choice *-- ISO20022.Seev034002.ProprietaryStatusAndReason7
    ISO20022.Seev034002.InstructionProcessingStatus58Choice *-- ISO20022.Seev034002.NoSpecifiedReason1
    ISO20022.Seev034002.InstructionProcessingStatus58Choice *-- ISO20022.Seev034002.NoSpecifiedReason1
    ISO20022.Seev034002.InstructionProcessingStatus58Choice *-- ISO20022.Seev034002.NoSpecifiedReason1
    ISO20022.Seev034002.InstructionProcessingStatus58Choice *-- ISO20022.Seev034002.ReturnedStatus1Choice
    ISO20022.Seev034002.InstructionProcessingStatus58Choice *-- ISO20022.Seev034002.PendingStatus2
    ISO20022.Seev034002.InstructionProcessingStatus58Choice *-- ISO20022.Seev034002.RejectedStatus12
    ISO20022.Seev034002.InstructionProcessingStatus58Choice *-- ISO20022.Seev034002.NoSpecifiedReason1
    ISO20022.Seev034002.InstructionProcessingStatus58Choice *-- ISO20022.Seev034002.AcceptedStatus3
    ISO20022.Seev034002.InstructionProcessingStatus58Choice *-- ISO20022.Seev034002.CancelledStatus6
    class ISO20022.Seev034002.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Seev034002.NoSpecifiedReason1 {
        + NoSpcfdRsn  : String
    }
    class ISO20022.Seev034002.OptionFeatures12Code {
        OPLF = 1
    }
    class ISO20022.Seev034002.OptionFeaturesFormat27Choice {
        + Prtry  : ISO20022.Seev034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev034002.OptionFeaturesFormat27Choice *-- ISO20022.Seev034002.GenericIdentification47
    class ISO20022.Seev034002.OptionNumber1Choice {
        + Cd  : String
        + Nb  : String
    }
    class ISO20022.Seev034002.OptionNumber1Code {
        UNSO = 1
    }
    class ISO20022.Seev034002.OriginalAndCurrentQuantities4 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Seev034002.OtherIdentification2 {
        + Tp  : ISO20022.Seev034002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev034002.OtherIdentification2 *-- ISO20022.Seev034002.IdentificationSource4Choice
    class ISO20022.Seev034002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Seev034002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Seev034002.PartyIdentification136Choice *-- ISO20022.Seev034002.GenericIdentification84
    class ISO20022.Seev034002.PendingReason27Code {
        IPED = 1
        IPAW = 2
        BSTR = 3
        SNAV = 4
        MTAX = 5
        NTAX = 6
        ITAX = 7
        DQCS = 8
        CERT = 9
        PENR = 10
        DQUA = 11
        LATE = 12
        LACK = 13
        MONY = 14
        MCER = 15
        FULL = 16
        OTHR = 17
        ADEA = 18
    }
    class ISO20022.Seev034002.PendingReason72Choice {
        + Prtry  : ISO20022.Seev034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev034002.PendingReason72Choice *-- ISO20022.Seev034002.GenericIdentification47
    class ISO20022.Seev034002.PendingStatus2 {
        + PdgRsn  : ISO20022.Seev034002.PendingStatus76Choice
        + PdgQty  : ISO20022.Seev034002.Quantity54Choice
    }
    ISO20022.Seev034002.PendingStatus2 *-- ISO20022.Seev034002.PendingStatus76Choice
    ISO20022.Seev034002.PendingStatus2 *-- ISO20022.Seev034002.Quantity54Choice
    class ISO20022.Seev034002.PendingStatus76Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev034002.PendingStatusReason31~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev034002.PendingStatus76Choice *-- ISO20022.Seev034002.PendingStatusReason31
    class ISO20022.Seev034002.PendingStatusReason31 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev034002.PendingReason72Choice
    }
    ISO20022.Seev034002.PendingStatusReason31 *-- ISO20022.Seev034002.PendingReason72Choice
    class ISO20022.Seev034002.ProprietaryQuantity8 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
    }
    class ISO20022.Seev034002.ProprietaryQuantity9 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
    }
    class ISO20022.Seev034002.ProprietaryReason5 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Seev034002.GenericIdentification47
    }
    ISO20022.Seev034002.ProprietaryReason5 *-- ISO20022.Seev034002.GenericIdentification47
    class ISO20022.Seev034002.ProprietaryStatusAndReason7 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Seev034002.ProprietaryReason5~
        + PrtrySts  : ISO20022.Seev034002.GenericIdentification47
    }
    ISO20022.Seev034002.ProprietaryStatusAndReason7 *-- ISO20022.Seev034002.ProprietaryReason5
    ISO20022.Seev034002.ProprietaryStatusAndReason7 *-- ISO20022.Seev034002.GenericIdentification47
    class ISO20022.Seev034002.ProtectInstruction6 {
        + UcvrdPrtctQty  : ISO20022.Seev034002.FinancialInstrumentQuantity31Choice
        + PrtctDt  : DateTime
        + PrtctSfkpgAcct  : String
        + TxId  : String
        + PrtctTxSts  : String
        + TxTp  : String
    }
    ISO20022.Seev034002.ProtectInstruction6 *-- ISO20022.Seev034002.FinancialInstrumentQuantity31Choice
    class ISO20022.Seev034002.ProtectInstructionStatus3Code {
        EXPI = 1
        COVR = 2
        OPEN = 3
    }
    class ISO20022.Seev034002.ProtectTransactionType2Code {
        COVR = 1
        COVP = 2
        PROT = 3
    }
    class ISO20022.Seev034002.Quantity48Choice {
        + PrtryQty  : ISO20022.Seev034002.ProprietaryQuantity8
        + Qty  : ISO20022.Seev034002.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Seev034002.Quantity48Choice *-- ISO20022.Seev034002.ProprietaryQuantity8
    ISO20022.Seev034002.Quantity48Choice *-- ISO20022.Seev034002.FinancialInstrumentQuantity33Choice
    class ISO20022.Seev034002.Quantity53Choice {
        + PrtryQty  : ISO20022.Seev034002.ProprietaryQuantity9
        + Qty  : ISO20022.Seev034002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Seev034002.Quantity53Choice *-- ISO20022.Seev034002.ProprietaryQuantity9
    ISO20022.Seev034002.Quantity53Choice *-- ISO20022.Seev034002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev034002.Quantity54Choice {
        + OrgnlAndCurFace  : ISO20022.Seev034002.OriginalAndCurrentQuantities4
        + Qty  : ISO20022.Seev034002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Seev034002.Quantity54Choice *-- ISO20022.Seev034002.OriginalAndCurrentQuantities4
    ISO20022.Seev034002.Quantity54Choice *-- ISO20022.Seev034002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev034002.RejectedReason63Choice {
        + Prtry  : ISO20022.Seev034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev034002.RejectedReason63Choice *-- ISO20022.Seev034002.GenericIdentification47
    class ISO20022.Seev034002.RejectedStatus12 {
        + RjctdRsn  : ISO20022.Seev034002.RejectedStatus61Choice
        + RjctdQty  : ISO20022.Seev034002.Quantity54Choice
    }
    ISO20022.Seev034002.RejectedStatus12 *-- ISO20022.Seev034002.RejectedStatus61Choice
    ISO20022.Seev034002.RejectedStatus12 *-- ISO20022.Seev034002.Quantity54Choice
    class ISO20022.Seev034002.RejectedStatus61Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev034002.RejectedStatusReason60~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev034002.RejectedStatus61Choice *-- ISO20022.Seev034002.RejectedStatusReason60
    class ISO20022.Seev034002.RejectedStatusReason60 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev034002.RejectedReason63Choice
    }
    ISO20022.Seev034002.RejectedStatusReason60 *-- ISO20022.Seev034002.RejectedReason63Choice
    class ISO20022.Seev034002.RejectionReason85Code {
        IPED = 1
        REJA = 2
        IPAW = 3
        TRTI = 4
        PROT = 5
        PRON = 6
        PROI = 7
        DUPL = 8
        CTCT = 9
        BSTR = 10
        ISOL = 11
        MTAX = 12
        NTAX = 13
        ITAX = 14
        SHAR = 15
        DQBI = 16
        DQBV = 17
        IRDQ = 18
        DQAM = 19
        DQCC = 20
        DQCS = 21
        EVNM = 22
        SAFE = 23
        REFT = 24
        DQUA = 25
        OTHR = 26
        OPNM = 27
        INTV = 28
        CANC = 29
        FULL = 30
        NMTY = 31
        LATE = 32
        LACK = 33
        DSEC = 34
        ULNK = 35
        OPTY = 36
        INVA = 37
        CERT = 38
        ADEA = 39
    }
    class ISO20022.Seev034002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev034002.ReturnedReason1Choice {
        + Prtry  : ISO20022.Seev034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev034002.ReturnedReason1Choice *-- ISO20022.Seev034002.GenericIdentification47
    class ISO20022.Seev034002.ReturnedStatus1Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev034002.ReturnedStatusReason1~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev034002.ReturnedStatus1Choice *-- ISO20022.Seev034002.ReturnedStatusReason1
    class ISO20022.Seev034002.ReturnedStatus1Code {
        PROR = 1
        NARR = 2
    }
    class ISO20022.Seev034002.ReturnedStatusReason1 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev034002.ReturnedReason1Choice
    }
    ISO20022.Seev034002.ReturnedStatusReason1 *-- ISO20022.Seev034002.ReturnedReason1Choice
    class ISO20022.Seev034002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Seev034002.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Seev034002.SafekeepingPlaceFormat47Choice {
        + Prtry  : ISO20022.Seev034002.GenericIdentification85
        + TpAndId  : ISO20022.Seev034002.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev034002.SafekeepingPlaceTypeAndText9
    }
    ISO20022.Seev034002.SafekeepingPlaceFormat47Choice *-- ISO20022.Seev034002.GenericIdentification85
    ISO20022.Seev034002.SafekeepingPlaceFormat47Choice *-- ISO20022.Seev034002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev034002.SafekeepingPlaceFormat47Choice *-- ISO20022.Seev034002.SafekeepingPlaceTypeAndText9
    class ISO20022.Seev034002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev034002.SafekeepingPlaceTypeAndText9 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev034002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev034002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Seev034002.SecurityIdentification20 *-- ISO20022.Seev034002.OtherIdentification2
    class ISO20022.Seev034002.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Seev034002.SignedQuantityFormat11 {
        + QtyChc  : ISO20022.Seev034002.Quantity48Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev034002.SignedQuantityFormat11 *-- ISO20022.Seev034002.Quantity48Choice
    class ISO20022.Seev034002.SignedQuantityFormat12 {
        + QtyChc  : ISO20022.Seev034002.Quantity53Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev034002.SignedQuantityFormat12 *-- ISO20022.Seev034002.Quantity53Choice
    class ISO20022.Seev034002.SupplementaryData1 {
        + Envlp  : ISO20022.Seev034002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev034002.SupplementaryData1 *-- ISO20022.Seev034002.SupplementaryDataEnvelope1
    class ISO20022.Seev034002.SupplementaryDataEnvelope1 {
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

## Value ISO20022.Seev034002.AcceptedReason15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev034002.AcceptedStatus13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev034002.AcceptedStatusReason14>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev034002.AcceptedStatus3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AccptdRsn|ISO20022.Seev034002.AcceptedStatus13Choice||XmlElement()||
|+|AccptdQty|ISO20022.Seev034002.Quantity54Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptdRsn),validElement(AccptdQty))|

---

## Value ISO20022.Seev034002.AcceptedStatusReason14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev034002.AcceptedReason15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(RsnCd))|

---

## Enum ISO20022.Seev034002.AcknowledgementReason7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||NSTP|Int32||XmlEnum("""NSTP""")|2|

---

## Value ISO20022.Seev034002.BlockChainAddressWallet11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Seev034002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev034002.CancelledReason13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev034002.CancelledStatus17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev034002.CancelledStatusReason17>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev034002.CancelledStatus6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CxlRsn|ISO20022.Seev034002.CancelledStatus17Choice||XmlElement()||
|+|CancQty|ISO20022.Seev034002.Quantity54Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CxlRsn),validElement(CancQty))|

---

## Value ISO20022.Seev034002.CancelledStatusReason17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev034002.CancelledReason13Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(RsnCd))|

---

## Enum ISO20022.Seev034002.CancelledStatusReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||CSUB|Int32||XmlEnum("""CSUB""")|2|
||CANS|Int32||XmlEnum("""CANS""")|3|
||CANO|Int32||XmlEnum("""CANO""")|4|
||CANI|Int32||XmlEnum("""CANI""")|5|

---

## Value ISO20022.Seev034002.CashAccountIdentification11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|BlckChainCshWllt|ISO20022.Seev034002.BlockChainAddressWallet11||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,34}"""),validElement(BlckChainCshWllt),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,BlckChainCshWllt,IBAN))|

---

## Value ISO20022.Seev034002.CorporateActionEventType118Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev034002.CorporateActionEventType40Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||WRTH|Int32||XmlEnum("""WRTH""")|2|
||WTRC|Int32||XmlEnum("""WTRC""")|3|
||EXWA|Int32||XmlEnum("""EXWA""")|4|
||SUSP|Int32||XmlEnum("""SUSP""")|5|
||DLST|Int32||XmlEnum("""DLST""")|6|
||TEND|Int32||XmlEnum("""TEND""")|7|
||TREC|Int32||XmlEnum("""TREC""")|8|
||SPLF|Int32||XmlEnum("""SPLF""")|9|
||DVSE|Int32||XmlEnum("""DVSE""")|10|
||SOFF|Int32||XmlEnum("""SOFF""")|11|
||SMAL|Int32||XmlEnum("""SMAL""")|12|
||SHPR|Int32||XmlEnum("""SHPR""")|13|
||DVSC|Int32||XmlEnum("""DVSC""")|14|
||RHTS|Int32||XmlEnum("""RHTS""")|15|
||SPLR|Int32||XmlEnum("""SPLR""")|16|
||BIDS|Int32||XmlEnum("""BIDS""")|17|
||REMK|Int32||XmlEnum("""REMK""")|18|
||REDO|Int32||XmlEnum("""REDO""")|19|
||BPUT|Int32||XmlEnum("""BPUT""")|20|
||PRIO|Int32||XmlEnum("""PRIO""")|21|
||PDEF|Int32||XmlEnum("""PDEF""")|22|
||PLAC|Int32||XmlEnum("""PLAC""")|23|
||PINK|Int32||XmlEnum("""PINK""")|24|
||PRED|Int32||XmlEnum("""PRED""")|25|
||PCAL|Int32||XmlEnum("""PCAL""")|26|
||PARI|Int32||XmlEnum("""PARI""")|27|
||OTHR|Int32||XmlEnum("""OTHR""")|28|
||ODLT|Int32||XmlEnum("""ODLT""")|29|
||CERT|Int32||XmlEnum("""CERT""")|30|
||NOOF|Int32||XmlEnum("""NOOF""")|31|
||MRGR|Int32||XmlEnum("""MRGR""")|32|
||EXTM|Int32||XmlEnum("""EXTM""")|33|
||LIQU|Int32||XmlEnum("""LIQU""")|34|
||RHDI|Int32||XmlEnum("""RHDI""")|35|
||INTR|Int32||XmlEnum("""INTR""")|36|
||PPMT|Int32||XmlEnum("""PPMT""")|37|
||INCR|Int32||XmlEnum("""INCR""")|38|
||MCAL|Int32||XmlEnum("""MCAL""")|39|
||REDM|Int32||XmlEnum("""REDM""")|40|
||EXOF|Int32||XmlEnum("""EXOF""")|41|
||DTCH|Int32||XmlEnum("""DTCH""")|42|
||DRAW|Int32||XmlEnum("""DRAW""")|43|
||DRIP|Int32||XmlEnum("""DRIP""")|44|
||DVOP|Int32||XmlEnum("""DVOP""")|45|
||DSCL|Int32||XmlEnum("""DSCL""")|46|
||DETI|Int32||XmlEnum("""DETI""")|47|
||DECR|Int32||XmlEnum("""DECR""")|48|
||CREV|Int32||XmlEnum("""CREV""")|49|
||CONV|Int32||XmlEnum("""CONV""")|50|
||CONS|Int32||XmlEnum("""CONS""")|51|
||CLSA|Int32||XmlEnum("""CLSA""")|52|
||COOP|Int32||XmlEnum("""COOP""")|53|
||CHAN|Int32||XmlEnum("""CHAN""")|54|
||DVCA|Int32||XmlEnum("""DVCA""")|55|
||DRCA|Int32||XmlEnum("""DRCA""")|56|
||CAPI|Int32||XmlEnum("""CAPI""")|57|
||CAPG|Int32||XmlEnum("""CAPG""")|58|
||CAPD|Int32||XmlEnum("""CAPD""")|59|
||EXRI|Int32||XmlEnum("""EXRI""")|60|
||BONU|Int32||XmlEnum("""BONU""")|61|
||DFLT|Int32||XmlEnum("""DFLT""")|62|
||BRUP|Int32||XmlEnum("""BRUP""")|63|
||ATTI|Int32||XmlEnum("""ATTI""")|64|
||ACTV|Int32||XmlEnum("""ACTV""")|65|

---

## Value ISO20022.Seev034002.CorporateActionGeneralInformation188


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EvtTp|ISO20022.Seev034002.CorporateActionEventType118Choice||XmlElement()||
|+|ClssActnNb|String||XmlElement()||
|+|OffclCorpActnEvtId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EvtTp),validPattern("""ClssActnNb""",ClssActnNb,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""OffclCorpActnEvtId""",OffclCorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CorpActnEvtId""",CorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Aspect ISO20022.Seev034002.CorporateActionInstructionStatusAdvice002V15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev034002.SupplementaryData1>||XmlElement()||
|+|AddtlInf|ISO20022.Seev034002.CorporateActionNarrative19||XmlElement()||
|+|PrtctInstr|ISO20022.Seev034002.ProtectInstruction6||XmlElement()||
|+|CorpActnInstr|ISO20022.Seev034002.CorporateActionOption242||XmlElement()||
|+|InstrPrcgSts|global::System.Collections.Generic.List<ISO20022.Seev034002.InstructionProcessingStatus58Choice>||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev034002.CorporateActionGeneralInformation188||XmlElement()||
|+|OthrDocId|global::System.Collections.Generic.List<ISO20022.Seev034002.DocumentIdentification34>||XmlElement()||
|+|InstrId|ISO20022.Seev034002.DocumentIdentification17||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AddtlInf),validElement(PrtctInstr),validElement(CorpActnInstr),validRequired("""InstrPrcgSts""",InstrPrcgSts),validList("""InstrPrcgSts""",InstrPrcgSts),validElement(InstrPrcgSts),validElement(CorpActnGnlInf),validList("""OthrDocId""",OthrDocId),validElement(OthrDocId),validElement(InstrId))|

---

## Value ISO20022.Seev034002.CorporateActionNarrative19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCtctNrrtv|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AddtlTxt|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PtyCtctNrrtv""",PtyCtctNrrtv,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""AddtlTxt""",AddtlTxt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Enum ISO20022.Seev034002.CorporateActionOption17Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOBD|Int32||XmlEnum("""BOBD""")|1|
||PRUN|Int32||XmlEnum("""PRUN""")|2|
||TAXI|Int32||XmlEnum("""TAXI""")|3|
||SLLE|Int32||XmlEnum("""SLLE""")|4|
||SECU|Int32||XmlEnum("""SECU""")|5|
||QINV|Int32||XmlEnum("""QINV""")|6|
||OVER|Int32||XmlEnum("""OVER""")|7|
||OTHR|Int32||XmlEnum("""OTHR""")|8|
||OFFR|Int32||XmlEnum("""OFFR""")|9|
||NOQU|Int32||XmlEnum("""NOQU""")|10|
||NOAC|Int32||XmlEnum("""NOAC""")|11|
||MPUT|Int32||XmlEnum("""MPUT""")|12|
||MKUP|Int32||XmlEnum("""MKUP""")|13|
||MKDW|Int32||XmlEnum("""MKDW""")|14|
||LAPS|Int32||XmlEnum("""LAPS""")|15|
||EXER|Int32||XmlEnum("""EXER""")|16|
||CTEN|Int32||XmlEnum("""CTEN""")|17|
||CONY|Int32||XmlEnum("""CONY""")|18|
||CONN|Int32||XmlEnum("""CONN""")|19|
||CEXC|Int32||XmlEnum("""CEXC""")|20|
||CASH|Int32||XmlEnum("""CASH""")|21|
||CASE|Int32||XmlEnum("""CASE""")|22|
||BUYA|Int32||XmlEnum("""BUYA""")|23|
||BSPL|Int32||XmlEnum("""BSPL""")|24|
||ABST|Int32||XmlEnum("""ABST""")|25|

---

## Value ISO20022.Seev034002.CorporateActionOption242


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SlctnDealrFeeInd|String||XmlElement()||
|+|StsCshAmt|ISO20022.Seev034002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|StsQty|ISO20022.Seev034002.Quantity54Choice||XmlElement()||
|+|PrtctBal|ISO20022.Seev034002.SignedQuantityFormat11||XmlElement()||
|+|UinstdBal|ISO20022.Seev034002.SignedQuantityFormat12||XmlElement()||
|+|InstdBal|ISO20022.Seev034002.SignedQuantityFormat12||XmlElement()||
|+|TtlElgblBal|ISO20022.Seev034002.SignedQuantityFormat12||XmlElement()||
|+|FinInstrmId|ISO20022.Seev034002.SecurityIdentification20||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev034002.SafekeepingPlaceFormat47Choice||XmlElement()||
|+|CshAcct|ISO20022.Seev034002.CashAccountIdentification11Choice||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|AcctOwnr|ISO20022.Seev034002.PartyIdentification136Choice||XmlElement()||
|+|OptnFeatrs|ISO20022.Seev034002.OptionFeaturesFormat27Choice||XmlElement()||
|+|OptnTp|ISO20022.Seev034002.CorporateActionOption42Choice||XmlElement()||
|+|OptnNb|ISO20022.Seev034002.OptionNumber1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StsCshAmt),validElement(StsQty),validElement(PrtctBal),validElement(UinstdBal),validElement(InstdBal),validElement(TtlElgblBal),validElement(FinInstrmId),validElement(SfkpgPlc),validElement(CshAcct),validPattern("""BlckChainAdrOrWllt""",BlckChainAdrOrWllt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""SfkpgAcct""",SfkpgAcct,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validElement(AcctOwnr),validElement(OptnFeatrs),validElement(OptnTp),validElement(OptnNb))|

---

## Value ISO20022.Seev034002.CorporateActionOption42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Type ISO20022.Seev034002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnInstrStsAdvc|ISO20022.Seev034002.CorporateActionInstructionStatusAdvice002V15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnInstrStsAdvc))|

---

## Value ISO20022.Seev034002.DocumentIdentification17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev034002.DocumentIdentification34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DocNb|ISO20022.Seev034002.DocumentNumber6Choice||XmlElement()||
|+|Id|ISO20022.Seev034002.DocumentIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DocNb),validElement(Id))|

---

## Value ISO20022.Seev034002.DocumentIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOwnrDocId|String||XmlElement()||
|+|AcctSvcrDocId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AcctOwnrDocId""",AcctOwnrDocId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrDocId""",AcctSvcrDocId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validChoice(AcctOwnrDocId,AcctSvcrDocId))|

---

## Value ISO20022.Seev034002.DocumentNumber6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Seev034002.GenericIdentification86||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Value ISO20022.Seev034002.FinancialInstrumentQuantity31Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(FaceAmt,Unit))|

---

## Value ISO20022.Seev034002.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev034002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev034002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev034002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev034002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Seev034002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Seev034002.GenericIdentification86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev034002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev034002.InstructionProcessingStatus58Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtrySts|ISO20022.Seev034002.ProprietaryStatusAndReason7||XmlElement()||
|+|RcvdByIssrOrOfferr|ISO20022.Seev034002.NoSpecifiedReason1||XmlElement()||
|+|StgInstr|ISO20022.Seev034002.NoSpecifiedReason1||XmlElement()||
|+|DfltActn|ISO20022.Seev034002.NoSpecifiedReason1||XmlElement()||
|+|Rtrd|ISO20022.Seev034002.ReturnedStatus1Choice||XmlElement()||
|+|Pdg|ISO20022.Seev034002.PendingStatus2||XmlElement()||
|+|Rjctd|ISO20022.Seev034002.RejectedStatus12||XmlElement()||
|+|Fwdd|ISO20022.Seev034002.NoSpecifiedReason1||XmlElement()||
|+|AccptdForFrthrPrcg|ISO20022.Seev034002.AcceptedStatus3||XmlElement()||
|+|Canc|ISO20022.Seev034002.CancelledStatus6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtrySts),validElement(RcvdByIssrOrOfferr),validElement(StgInstr),validElement(DfltActn),validElement(Rtrd),validElement(Pdg),validElement(Rjctd),validElement(Fwdd),validElement(AccptdForFrthrPrcg),validElement(Canc),validChoice(PrtrySts,RcvdByIssrOrOfferr,StgInstr,DfltActn,Rtrd,Pdg,Rjctd,Fwdd,AccptdForFrthrPrcg,Canc))|

---

## Enum ISO20022.Seev034002.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Seev034002.NoSpecifiedReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev034002.OptionFeatures12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPLF|Int32||XmlEnum("""OPLF""")|1|

---

## Value ISO20022.Seev034002.OptionFeaturesFormat27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev034002.OptionNumber1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nb""",Nb,"""[0-9]{3}"""),validChoice(Cd,Nb))|

---

## Enum ISO20022.Seev034002.OptionNumber1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNSO|Int32||XmlEnum("""UNSO""")|1|

---

## Value ISO20022.Seev034002.OriginalAndCurrentQuantities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev034002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev034002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Seev034002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev034002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Enum ISO20022.Seev034002.PendingReason27Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||IPED|Int32||XmlEnum("""IPED""")|1|
||IPAW|Int32||XmlEnum("""IPAW""")|2|
||BSTR|Int32||XmlEnum("""BSTR""")|3|
||SNAV|Int32||XmlEnum("""SNAV""")|4|
||MTAX|Int32||XmlEnum("""MTAX""")|5|
||NTAX|Int32||XmlEnum("""NTAX""")|6|
||ITAX|Int32||XmlEnum("""ITAX""")|7|
||DQCS|Int32||XmlEnum("""DQCS""")|8|
||CERT|Int32||XmlEnum("""CERT""")|9|
||PENR|Int32||XmlEnum("""PENR""")|10|
||DQUA|Int32||XmlEnum("""DQUA""")|11|
||LATE|Int32||XmlEnum("""LATE""")|12|
||LACK|Int32||XmlEnum("""LACK""")|13|
||MONY|Int32||XmlEnum("""MONY""")|14|
||MCER|Int32||XmlEnum("""MCER""")|15|
||FULL|Int32||XmlEnum("""FULL""")|16|
||OTHR|Int32||XmlEnum("""OTHR""")|17|
||ADEA|Int32||XmlEnum("""ADEA""")|18|

---

## Value ISO20022.Seev034002.PendingReason72Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev034002.PendingStatus2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PdgRsn|ISO20022.Seev034002.PendingStatus76Choice||XmlElement()||
|+|PdgQty|ISO20022.Seev034002.Quantity54Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PdgRsn),validElement(PdgQty))|

---

## Value ISO20022.Seev034002.PendingStatus76Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev034002.PendingStatusReason31>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev034002.PendingStatusReason31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev034002.PendingReason72Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(RsnCd))|

---

## Value ISO20022.Seev034002.ProprietaryQuantity8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev034002.ProprietaryQuantity9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev034002.ProprietaryReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Seev034002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Rsn))|

---

## Value ISO20022.Seev034002.ProprietaryStatusAndReason7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Seev034002.ProprietaryReason5>||XmlElement()||
|+|PrtrySts|ISO20022.Seev034002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Seev034002.ProtectInstruction6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UcvrdPrtctQty|ISO20022.Seev034002.FinancialInstrumentQuantity31Choice||XmlElement()||
|+|PrtctDt|DateTime||XmlElement()||
|+|PrtctSfkpgAcct|String||XmlElement()||
|+|TxId|String||XmlElement()||
|+|PrtctTxSts|String||XmlElement()||
|+|TxTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UcvrdPrtctQty),validPattern("""PrtctSfkpgAcct""",PrtctSfkpgAcct,"""([^/]+/)+([^/]+)\|([^/]*)"""))|

---

## Enum ISO20022.Seev034002.ProtectInstructionStatus3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXPI|Int32||XmlEnum("""EXPI""")|1|
||COVR|Int32||XmlEnum("""COVR""")|2|
||OPEN|Int32||XmlEnum("""OPEN""")|3|

---

## Enum ISO20022.Seev034002.ProtectTransactionType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COVR|Int32||XmlEnum("""COVR""")|1|
||COVP|Int32||XmlEnum("""COVP""")|2|
||PROT|Int32||XmlEnum("""PROT""")|3|

---

## Value ISO20022.Seev034002.Quantity48Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev034002.ProprietaryQuantity8||XmlElement()||
|+|Qty|ISO20022.Seev034002.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(Qty),validChoice(PrtryQty,Qty))|

---

## Value ISO20022.Seev034002.Quantity53Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev034002.ProprietaryQuantity9||XmlElement()||
|+|Qty|ISO20022.Seev034002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(Qty),validChoice(PrtryQty,Qty))|

---

## Value ISO20022.Seev034002.Quantity54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Seev034002.OriginalAndCurrentQuantities4||XmlElement()||
|+|Qty|ISO20022.Seev034002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Seev034002.RejectedReason63Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev034002.RejectedStatus12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RjctdRsn|ISO20022.Seev034002.RejectedStatus61Choice||XmlElement()||
|+|RjctdQty|ISO20022.Seev034002.Quantity54Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RjctdRsn),validElement(RjctdQty))|

---

## Value ISO20022.Seev034002.RejectedStatus61Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev034002.RejectedStatusReason60>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev034002.RejectedStatusReason60


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev034002.RejectedReason63Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(RsnCd))|

---

## Enum ISO20022.Seev034002.RejectionReason85Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||IPED|Int32||XmlEnum("""IPED""")|1|
||REJA|Int32||XmlEnum("""REJA""")|2|
||IPAW|Int32||XmlEnum("""IPAW""")|3|
||TRTI|Int32||XmlEnum("""TRTI""")|4|
||PROT|Int32||XmlEnum("""PROT""")|5|
||PRON|Int32||XmlEnum("""PRON""")|6|
||PROI|Int32||XmlEnum("""PROI""")|7|
||DUPL|Int32||XmlEnum("""DUPL""")|8|
||CTCT|Int32||XmlEnum("""CTCT""")|9|
||BSTR|Int32||XmlEnum("""BSTR""")|10|
||ISOL|Int32||XmlEnum("""ISOL""")|11|
||MTAX|Int32||XmlEnum("""MTAX""")|12|
||NTAX|Int32||XmlEnum("""NTAX""")|13|
||ITAX|Int32||XmlEnum("""ITAX""")|14|
||SHAR|Int32||XmlEnum("""SHAR""")|15|
||DQBI|Int32||XmlEnum("""DQBI""")|16|
||DQBV|Int32||XmlEnum("""DQBV""")|17|
||IRDQ|Int32||XmlEnum("""IRDQ""")|18|
||DQAM|Int32||XmlEnum("""DQAM""")|19|
||DQCC|Int32||XmlEnum("""DQCC""")|20|
||DQCS|Int32||XmlEnum("""DQCS""")|21|
||EVNM|Int32||XmlEnum("""EVNM""")|22|
||SAFE|Int32||XmlEnum("""SAFE""")|23|
||REFT|Int32||XmlEnum("""REFT""")|24|
||DQUA|Int32||XmlEnum("""DQUA""")|25|
||OTHR|Int32||XmlEnum("""OTHR""")|26|
||OPNM|Int32||XmlEnum("""OPNM""")|27|
||INTV|Int32||XmlEnum("""INTV""")|28|
||CANC|Int32||XmlEnum("""CANC""")|29|
||FULL|Int32||XmlEnum("""FULL""")|30|
||NMTY|Int32||XmlEnum("""NMTY""")|31|
||LATE|Int32||XmlEnum("""LATE""")|32|
||LACK|Int32||XmlEnum("""LACK""")|33|
||DSEC|Int32||XmlEnum("""DSEC""")|34|
||ULNK|Int32||XmlEnum("""ULNK""")|35|
||OPTY|Int32||XmlEnum("""OPTY""")|36|
||INVA|Int32||XmlEnum("""INVA""")|37|
||CERT|Int32||XmlEnum("""CERT""")|38|
||ADEA|Int32||XmlEnum("""ADEA""")|39|

---

## Value ISO20022.Seev034002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev034002.ReturnedReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev034002.ReturnedStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev034002.ReturnedStatusReason1>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Seev034002.ReturnedStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROR|Int32||XmlEnum("""PROR""")|1|
||NARR|Int32||XmlEnum("""NARR""")|2|

---

## Value ISO20022.Seev034002.ReturnedStatusReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev034002.ReturnedReason1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(RsnCd))|

---

## Enum ISO20022.Seev034002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Seev034002.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Value ISO20022.Seev034002.SafekeepingPlaceFormat47Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Seev034002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev034002.SafekeepingPlaceTypeAndText9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev034002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Seev034002.SafekeepingPlaceTypeAndText9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev034002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev034002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Seev034002.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Seev034002.SignedQuantityFormat11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyChc|ISO20022.Seev034002.Quantity48Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyChc))|

---

## Value ISO20022.Seev034002.SignedQuantityFormat12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyChc|ISO20022.Seev034002.Quantity53Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyChc))|

---

## Value ISO20022.Seev034002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev034002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev034002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
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

