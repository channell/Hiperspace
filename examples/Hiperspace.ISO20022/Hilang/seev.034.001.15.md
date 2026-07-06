# seev.034.001.15
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev034001.AcceptedReason10Choice {
        + Prtry  : ISO20022.Seev034001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev034001.AcceptedReason10Choice *-- ISO20022.Seev034001.GenericIdentification30
    class ISO20022.Seev034001.AcceptedStatus2 {
        + AccptdRsn  : ISO20022.Seev034001.AcceptedStatus8Choice
        + AccptdQty  : ISO20022.Seev034001.Quantity51Choice
    }
    ISO20022.Seev034001.AcceptedStatus2 *-- ISO20022.Seev034001.AcceptedStatus8Choice
    ISO20022.Seev034001.AcceptedStatus2 *-- ISO20022.Seev034001.Quantity51Choice
    class ISO20022.Seev034001.AcceptedStatus8Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev034001.AcceptedStatusReason9~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev034001.AcceptedStatus8Choice *-- ISO20022.Seev034001.AcceptedStatusReason9
    class ISO20022.Seev034001.AcceptedStatusReason9 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev034001.AcceptedReason10Choice
    }
    ISO20022.Seev034001.AcceptedStatusReason9 *-- ISO20022.Seev034001.AcceptedReason10Choice
    class ISO20022.Seev034001.AcknowledgementReason7Code {
        OTHR = 1
        NSTP = 2
    }
    class ISO20022.Seev034001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev034001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Seev034001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Seev034001.BlockChainAddressWallet3 *-- ISO20022.Seev034001.GenericIdentification30
    class ISO20022.Seev034001.CancelledReason8Choice {
        + Prtry  : ISO20022.Seev034001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev034001.CancelledReason8Choice *-- ISO20022.Seev034001.GenericIdentification30
    class ISO20022.Seev034001.CancelledStatus12Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev034001.CancelledStatusReason11~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev034001.CancelledStatus12Choice *-- ISO20022.Seev034001.CancelledStatusReason11
    class ISO20022.Seev034001.CancelledStatus5 {
        + CxlRsn  : ISO20022.Seev034001.CancelledStatus12Choice
        + CancQty  : ISO20022.Seev034001.Quantity51Choice
    }
    ISO20022.Seev034001.CancelledStatus5 *-- ISO20022.Seev034001.CancelledStatus12Choice
    ISO20022.Seev034001.CancelledStatus5 *-- ISO20022.Seev034001.Quantity51Choice
    class ISO20022.Seev034001.CancelledStatusReason11 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev034001.CancelledReason8Choice
    }
    ISO20022.Seev034001.CancelledStatusReason11 *-- ISO20022.Seev034001.CancelledReason8Choice
    class ISO20022.Seev034001.CancelledStatusReason6Code {
        OTHR = 1
        CSUB = 2
        CANS = 3
        CANO = 4
        CANI = 5
    }
    class ISO20022.Seev034001.CashAccountIdentification9Choice {
        + Prtry  : String
        + BlckChainCshWllt  : ISO20022.Seev034001.BlockChainAddressWallet3
        + IBAN  : String
    }
    ISO20022.Seev034001.CashAccountIdentification9Choice *-- ISO20022.Seev034001.BlockChainAddressWallet3
    class ISO20022.Seev034001.CorporateActionEventType112Choice {
        + Prtry  : ISO20022.Seev034001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev034001.CorporateActionEventType112Choice *-- ISO20022.Seev034001.GenericIdentification30
    class ISO20022.Seev034001.CorporateActionEventType40Code {
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
    class ISO20022.Seev034001.CorporateActionGeneralInformation182 {
        + EvtTp  : ISO20022.Seev034001.CorporateActionEventType112Choice
        + ClssActnNb  : String
        + OffclCorpActnEvtId  : String
        + CorpActnEvtId  : String
    }
    ISO20022.Seev034001.CorporateActionGeneralInformation182 *-- ISO20022.Seev034001.CorporateActionEventType112Choice
    class ISO20022.Seev034001.CorporateActionInstructionStatusAdviceV15 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev034001.SupplementaryData1~
        + AddtlInf  : ISO20022.Seev034001.CorporateActionNarrative10
        + PrtctInstr  : ISO20022.Seev034001.ProtectInstruction2
        + CorpActnInstr  : ISO20022.Seev034001.CorporateActionOption238
        + InstrPrcgSts  : global::System.Collections.Generic.List~ISO20022.Seev034001.InstructionProcessingStatus55Choice~
        + CorpActnGnlInf  : ISO20022.Seev034001.CorporateActionGeneralInformation182
        + OthrDocId  : global::System.Collections.Generic.List~ISO20022.Seev034001.DocumentIdentification33~
        + InstrId  : ISO20022.Seev034001.DocumentIdentification9
    }
    ISO20022.Seev034001.CorporateActionInstructionStatusAdviceV15 *-- ISO20022.Seev034001.SupplementaryData1
    ISO20022.Seev034001.CorporateActionInstructionStatusAdviceV15 *-- ISO20022.Seev034001.CorporateActionNarrative10
    ISO20022.Seev034001.CorporateActionInstructionStatusAdviceV15 *-- ISO20022.Seev034001.ProtectInstruction2
    ISO20022.Seev034001.CorporateActionInstructionStatusAdviceV15 *-- ISO20022.Seev034001.CorporateActionOption238
    ISO20022.Seev034001.CorporateActionInstructionStatusAdviceV15 *-- ISO20022.Seev034001.InstructionProcessingStatus55Choice
    ISO20022.Seev034001.CorporateActionInstructionStatusAdviceV15 *-- ISO20022.Seev034001.CorporateActionGeneralInformation182
    ISO20022.Seev034001.CorporateActionInstructionStatusAdviceV15 *-- ISO20022.Seev034001.DocumentIdentification33
    ISO20022.Seev034001.CorporateActionInstructionStatusAdviceV15 *-- ISO20022.Seev034001.DocumentIdentification9
    class ISO20022.Seev034001.CorporateActionNarrative10 {
        + PtyCtctNrrtv  : global::System.Collections.Generic.List~String~
        + AddtlTxt  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Seev034001.CorporateActionOption17Code {
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
    class ISO20022.Seev034001.CorporateActionOption238 {
        + SlctnDealrFeeInd  : String
        + StsCshAmt  : ISO20022.Seev034001.ActiveCurrencyAndAmount
        + StsQty  : ISO20022.Seev034001.Quantity51Choice
        + PrtctBal  : ISO20022.Seev034001.SignedQuantityFormat11
        + UinstdBal  : ISO20022.Seev034001.SignedQuantityFormat11
        + InstdBal  : ISO20022.Seev034001.SignedQuantityFormat11
        + TtlElgblBal  : ISO20022.Seev034001.SignedQuantityFormat11
        + FinInstrmId  : ISO20022.Seev034001.SecurityIdentification19
        + SfkpgPlc  : ISO20022.Seev034001.SafekeepingPlaceFormat42Choice
        + CshAcct  : ISO20022.Seev034001.CashAccountIdentification9Choice
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
        + AcctOwnr  : ISO20022.Seev034001.PartyIdentification127Choice
        + OptnFeatrs  : ISO20022.Seev034001.OptionFeaturesFormat25Choice
        + OptnTp  : ISO20022.Seev034001.CorporateActionOption41Choice
        + OptnNb  : ISO20022.Seev034001.OptionNumber1Choice
    }
    ISO20022.Seev034001.CorporateActionOption238 *-- ISO20022.Seev034001.ActiveCurrencyAndAmount
    ISO20022.Seev034001.CorporateActionOption238 *-- ISO20022.Seev034001.Quantity51Choice
    ISO20022.Seev034001.CorporateActionOption238 *-- ISO20022.Seev034001.SignedQuantityFormat11
    ISO20022.Seev034001.CorporateActionOption238 *-- ISO20022.Seev034001.SignedQuantityFormat11
    ISO20022.Seev034001.CorporateActionOption238 *-- ISO20022.Seev034001.SignedQuantityFormat11
    ISO20022.Seev034001.CorporateActionOption238 *-- ISO20022.Seev034001.SignedQuantityFormat11
    ISO20022.Seev034001.CorporateActionOption238 *-- ISO20022.Seev034001.SecurityIdentification19
    ISO20022.Seev034001.CorporateActionOption238 *-- ISO20022.Seev034001.SafekeepingPlaceFormat42Choice
    ISO20022.Seev034001.CorporateActionOption238 *-- ISO20022.Seev034001.CashAccountIdentification9Choice
    ISO20022.Seev034001.CorporateActionOption238 *-- ISO20022.Seev034001.PartyIdentification127Choice
    ISO20022.Seev034001.CorporateActionOption238 *-- ISO20022.Seev034001.OptionFeaturesFormat25Choice
    ISO20022.Seev034001.CorporateActionOption238 *-- ISO20022.Seev034001.CorporateActionOption41Choice
    ISO20022.Seev034001.CorporateActionOption238 *-- ISO20022.Seev034001.OptionNumber1Choice
    class ISO20022.Seev034001.CorporateActionOption41Choice {
        + Prtry  : ISO20022.Seev034001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev034001.CorporateActionOption41Choice *-- ISO20022.Seev034001.GenericIdentification30
    class ISO20022.Seev034001.DocumentIdentification33 {
        + DocNb  : ISO20022.Seev034001.DocumentNumber5Choice
        + Id  : ISO20022.Seev034001.DocumentIdentification3Choice
    }
    ISO20022.Seev034001.DocumentIdentification33 *-- ISO20022.Seev034001.DocumentNumber5Choice
    ISO20022.Seev034001.DocumentIdentification33 *-- ISO20022.Seev034001.DocumentIdentification3Choice
    class ISO20022.Seev034001.DocumentIdentification3Choice {
        + AcctOwnrDocId  : String
        + AcctSvcrDocId  : String
    }
    class ISO20022.Seev034001.DocumentIdentification9 {
        + Id  : String
    }
    class ISO20022.Seev034001.DocumentNumber5Choice {
        + PrtryNb  : ISO20022.Seev034001.GenericIdentification36
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Seev034001.DocumentNumber5Choice *-- ISO20022.Seev034001.GenericIdentification36
    class ISO20022.Seev034001.FinancialInstrumentQuantity18Choice {
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev034001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev034001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev034001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev034001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Seev034001.GenericIdentification30
    }
    ISO20022.Seev034001.GenericIdentification78 *-- ISO20022.Seev034001.GenericIdentification30
    class ISO20022.Seev034001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev034001.InstructionProcessingStatus55Choice {
        + PrtrySts  : ISO20022.Seev034001.ProprietaryStatusAndReason6
        + RcvdByIssrOrOfferr  : ISO20022.Seev034001.NoSpecifiedReason1
        + StgInstr  : ISO20022.Seev034001.NoSpecifiedReason1
        + DfltActn  : ISO20022.Seev034001.NoSpecifiedReason1
        + Rtrd  : ISO20022.Seev034001.ReturnedStatus2Choice
        + Pdg  : ISO20022.Seev034001.PendingStatus1
        + Rjctd  : ISO20022.Seev034001.RejectedStatus11
        + Fwdd  : ISO20022.Seev034001.NoSpecifiedReason1
        + AccptdForFrthrPrcg  : ISO20022.Seev034001.AcceptedStatus2
        + Canc  : ISO20022.Seev034001.CancelledStatus5
    }
    ISO20022.Seev034001.InstructionProcessingStatus55Choice *-- ISO20022.Seev034001.ProprietaryStatusAndReason6
    ISO20022.Seev034001.InstructionProcessingStatus55Choice *-- ISO20022.Seev034001.NoSpecifiedReason1
    ISO20022.Seev034001.InstructionProcessingStatus55Choice *-- ISO20022.Seev034001.NoSpecifiedReason1
    ISO20022.Seev034001.InstructionProcessingStatus55Choice *-- ISO20022.Seev034001.NoSpecifiedReason1
    ISO20022.Seev034001.InstructionProcessingStatus55Choice *-- ISO20022.Seev034001.ReturnedStatus2Choice
    ISO20022.Seev034001.InstructionProcessingStatus55Choice *-- ISO20022.Seev034001.PendingStatus1
    ISO20022.Seev034001.InstructionProcessingStatus55Choice *-- ISO20022.Seev034001.RejectedStatus11
    ISO20022.Seev034001.InstructionProcessingStatus55Choice *-- ISO20022.Seev034001.NoSpecifiedReason1
    ISO20022.Seev034001.InstructionProcessingStatus55Choice *-- ISO20022.Seev034001.AcceptedStatus2
    ISO20022.Seev034001.InstructionProcessingStatus55Choice *-- ISO20022.Seev034001.CancelledStatus5
    class ISO20022.Seev034001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Seev034001.NoSpecifiedReason1 {
        + NoSpcfdRsn  : String
    }
    class ISO20022.Seev034001.OptionFeatures12Code {
        OPLF = 1
    }
    class ISO20022.Seev034001.OptionFeaturesFormat25Choice {
        + Prtry  : ISO20022.Seev034001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev034001.OptionFeaturesFormat25Choice *-- ISO20022.Seev034001.GenericIdentification30
    class ISO20022.Seev034001.OptionNumber1Choice {
        + Cd  : String
        + Nb  : String
    }
    class ISO20022.Seev034001.OptionNumber1Code {
        UNSO = 1
    }
    class ISO20022.Seev034001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Seev034001.OtherIdentification1 {
        + Tp  : ISO20022.Seev034001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev034001.OtherIdentification1 *-- ISO20022.Seev034001.IdentificationSource3Choice
    class ISO20022.Seev034001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Seev034001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Seev034001.PartyIdentification127Choice *-- ISO20022.Seev034001.GenericIdentification36
    class ISO20022.Seev034001.PendingReason27Code {
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
    class ISO20022.Seev034001.PendingReason66Choice {
        + Prtry  : ISO20022.Seev034001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev034001.PendingReason66Choice *-- ISO20022.Seev034001.GenericIdentification30
    class ISO20022.Seev034001.PendingStatus1 {
        + PdgRsn  : ISO20022.Seev034001.PendingStatus71Choice
        + PdgQty  : ISO20022.Seev034001.Quantity51Choice
    }
    ISO20022.Seev034001.PendingStatus1 *-- ISO20022.Seev034001.PendingStatus71Choice
    ISO20022.Seev034001.PendingStatus1 *-- ISO20022.Seev034001.Quantity51Choice
    class ISO20022.Seev034001.PendingStatus71Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev034001.PendingStatusReason27~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev034001.PendingStatus71Choice *-- ISO20022.Seev034001.PendingStatusReason27
    class ISO20022.Seev034001.PendingStatusReason27 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev034001.PendingReason66Choice
    }
    ISO20022.Seev034001.PendingStatusReason27 *-- ISO20022.Seev034001.PendingReason66Choice
    class ISO20022.Seev034001.ProprietaryQuantity8 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
    }
    class ISO20022.Seev034001.ProprietaryReason4 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Seev034001.GenericIdentification30
    }
    ISO20022.Seev034001.ProprietaryReason4 *-- ISO20022.Seev034001.GenericIdentification30
    class ISO20022.Seev034001.ProprietaryStatusAndReason6 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Seev034001.ProprietaryReason4~
        + PrtrySts  : ISO20022.Seev034001.GenericIdentification30
    }
    ISO20022.Seev034001.ProprietaryStatusAndReason6 *-- ISO20022.Seev034001.ProprietaryReason4
    ISO20022.Seev034001.ProprietaryStatusAndReason6 *-- ISO20022.Seev034001.GenericIdentification30
    class ISO20022.Seev034001.ProtectInstruction2 {
        + UcvrdPrtctQty  : ISO20022.Seev034001.FinancialInstrumentQuantity18Choice
        + PrtctDt  : DateTime
        + PrtctSfkpgAcct  : String
        + TxId  : String
        + PrtctTxSts  : String
        + TxTp  : String
    }
    ISO20022.Seev034001.ProtectInstruction2 *-- ISO20022.Seev034001.FinancialInstrumentQuantity18Choice
    class ISO20022.Seev034001.ProtectInstructionStatus3Code {
        EXPI = 1
        COVR = 2
        OPEN = 3
    }
    class ISO20022.Seev034001.ProtectTransactionType2Code {
        COVR = 1
        COVP = 2
        PROT = 3
    }
    class ISO20022.Seev034001.Quantity48Choice {
        + PrtryQty  : ISO20022.Seev034001.ProprietaryQuantity8
        + Qty  : ISO20022.Seev034001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Seev034001.Quantity48Choice *-- ISO20022.Seev034001.ProprietaryQuantity8
    ISO20022.Seev034001.Quantity48Choice *-- ISO20022.Seev034001.FinancialInstrumentQuantity33Choice
    class ISO20022.Seev034001.Quantity51Choice {
        + OrgnlAndCurFace  : ISO20022.Seev034001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Seev034001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Seev034001.Quantity51Choice *-- ISO20022.Seev034001.OriginalAndCurrentQuantities1
    ISO20022.Seev034001.Quantity51Choice *-- ISO20022.Seev034001.FinancialInstrumentQuantity33Choice
    class ISO20022.Seev034001.RejectedReason60Choice {
        + Prtry  : ISO20022.Seev034001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev034001.RejectedReason60Choice *-- ISO20022.Seev034001.GenericIdentification30
    class ISO20022.Seev034001.RejectedStatus11 {
        + RjctdRsn  : ISO20022.Seev034001.RejectedStatus56Choice
        + RjctdQty  : ISO20022.Seev034001.Quantity51Choice
    }
    ISO20022.Seev034001.RejectedStatus11 *-- ISO20022.Seev034001.RejectedStatus56Choice
    ISO20022.Seev034001.RejectedStatus11 *-- ISO20022.Seev034001.Quantity51Choice
    class ISO20022.Seev034001.RejectedStatus56Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev034001.RejectedStatusReason56~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev034001.RejectedStatus56Choice *-- ISO20022.Seev034001.RejectedStatusReason56
    class ISO20022.Seev034001.RejectedStatusReason56 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev034001.RejectedReason60Choice
    }
    ISO20022.Seev034001.RejectedStatusReason56 *-- ISO20022.Seev034001.RejectedReason60Choice
    class ISO20022.Seev034001.RejectionReason85Code {
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
    class ISO20022.Seev034001.ReturnedReason2Choice {
        + Prtry  : ISO20022.Seev034001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev034001.ReturnedReason2Choice *-- ISO20022.Seev034001.GenericIdentification30
    class ISO20022.Seev034001.ReturnedStatus1Code {
        PROR = 1
        NARR = 2
    }
    class ISO20022.Seev034001.ReturnedStatus2Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Seev034001.ReturnedStatusReason2~
        + NoSpcfdRsn  : String
    }
    ISO20022.Seev034001.ReturnedStatus2Choice *-- ISO20022.Seev034001.ReturnedStatusReason2
    class ISO20022.Seev034001.ReturnedStatusReason2 {
        + AddtlRsnInf  : String
        + RsnCd  : ISO20022.Seev034001.ReturnedReason2Choice
    }
    ISO20022.Seev034001.ReturnedStatusReason2 *-- ISO20022.Seev034001.ReturnedReason2Choice
    class ISO20022.Seev034001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Seev034001.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Seev034001.SafekeepingPlaceFormat42Choice {
        + Prtry  : ISO20022.Seev034001.GenericIdentification78
        + TpAndId  : ISO20022.Seev034001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev034001.SafekeepingPlaceTypeAndText6
    }
    ISO20022.Seev034001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev034001.GenericIdentification78
    ISO20022.Seev034001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev034001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev034001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev034001.SafekeepingPlaceTypeAndText6
    class ISO20022.Seev034001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev034001.SafekeepingPlaceTypeAndText6 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev034001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev034001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Seev034001.SecurityIdentification19 *-- ISO20022.Seev034001.OtherIdentification1
    class ISO20022.Seev034001.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Seev034001.SignedQuantityFormat11 {
        + QtyChc  : ISO20022.Seev034001.Quantity48Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev034001.SignedQuantityFormat11 *-- ISO20022.Seev034001.Quantity48Choice
    class ISO20022.Seev034001.SupplementaryData1 {
        + Envlp  : ISO20022.Seev034001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev034001.SupplementaryData1 *-- ISO20022.Seev034001.SupplementaryDataEnvelope1
    class ISO20022.Seev034001.SupplementaryDataEnvelope1 {
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

## Value ISO20022.Seev034001.AcceptedReason10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev034001.AcceptedStatus2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AccptdRsn|ISO20022.Seev034001.AcceptedStatus8Choice||XmlElement()||
|+|AccptdQty|ISO20022.Seev034001.Quantity51Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AccptdRsn),validElement(AccptdQty))|

---

## Value ISO20022.Seev034001.AcceptedStatus8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev034001.AcceptedStatusReason9>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev034001.AcceptedStatusReason9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev034001.AcceptedReason10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsnCd))|

---

## Enum ISO20022.Seev034001.AcknowledgementReason7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||NSTP|Int32||XmlEnum("""NSTP""")|2|

---

## Value ISO20022.Seev034001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev034001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Seev034001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev034001.CancelledReason8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev034001.CancelledStatus12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev034001.CancelledStatusReason11>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev034001.CancelledStatus5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CxlRsn|ISO20022.Seev034001.CancelledStatus12Choice||XmlElement()||
|+|CancQty|ISO20022.Seev034001.Quantity51Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CxlRsn),validElement(CancQty))|

---

## Value ISO20022.Seev034001.CancelledStatusReason11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev034001.CancelledReason8Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsnCd))|

---

## Enum ISO20022.Seev034001.CancelledStatusReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||CSUB|Int32||XmlEnum("""CSUB""")|2|
||CANS|Int32||XmlEnum("""CANS""")|3|
||CANO|Int32||XmlEnum("""CANO""")|4|
||CANI|Int32||XmlEnum("""CANI""")|5|

---

## Value ISO20022.Seev034001.CashAccountIdentification9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|BlckChainCshWllt|ISO20022.Seev034001.BlockChainAddressWallet3||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainCshWllt),validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,BlckChainCshWllt,IBAN))|

---

## Value ISO20022.Seev034001.CorporateActionEventType112Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev034001.CorporateActionEventType40Code


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

## Value ISO20022.Seev034001.CorporateActionGeneralInformation182


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|EvtTp|ISO20022.Seev034001.CorporateActionEventType112Choice||XmlElement()||
|+|ClssActnNb|String||XmlElement()||
|+|OffclCorpActnEvtId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(EvtTp))|

---

## Aspect ISO20022.Seev034001.CorporateActionInstructionStatusAdviceV15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev034001.SupplementaryData1>||XmlElement()||
|+|AddtlInf|ISO20022.Seev034001.CorporateActionNarrative10||XmlElement()||
|+|PrtctInstr|ISO20022.Seev034001.ProtectInstruction2||XmlElement()||
|+|CorpActnInstr|ISO20022.Seev034001.CorporateActionOption238||XmlElement()||
|+|InstrPrcgSts|global::System.Collections.Generic.List<ISO20022.Seev034001.InstructionProcessingStatus55Choice>||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev034001.CorporateActionGeneralInformation182||XmlElement()||
|+|OthrDocId|global::System.Collections.Generic.List<ISO20022.Seev034001.DocumentIdentification33>||XmlElement()||
|+|InstrId|ISO20022.Seev034001.DocumentIdentification9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AddtlInf),validElement(PrtctInstr),validElement(CorpActnInstr),validRequired("""InstrPrcgSts""",InstrPrcgSts),validList("""InstrPrcgSts""",InstrPrcgSts),validElement(InstrPrcgSts),validElement(CorpActnGnlInf),validList("""OthrDocId""",OthrDocId),validElement(OthrDocId),validElement(InstrId))|

---

## Value ISO20022.Seev034001.CorporateActionNarrative10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCtctNrrtv|global::System.Collections.Generic.List<String>||XmlElement()||
|+|AddtlTxt|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev034001.CorporateActionOption17Code


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

## Value ISO20022.Seev034001.CorporateActionOption238


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SlctnDealrFeeInd|String||XmlElement()||
|+|StsCshAmt|ISO20022.Seev034001.ActiveCurrencyAndAmount||XmlElement()||
|+|StsQty|ISO20022.Seev034001.Quantity51Choice||XmlElement()||
|+|PrtctBal|ISO20022.Seev034001.SignedQuantityFormat11||XmlElement()||
|+|UinstdBal|ISO20022.Seev034001.SignedQuantityFormat11||XmlElement()||
|+|InstdBal|ISO20022.Seev034001.SignedQuantityFormat11||XmlElement()||
|+|TtlElgblBal|ISO20022.Seev034001.SignedQuantityFormat11||XmlElement()||
|+|FinInstrmId|ISO20022.Seev034001.SecurityIdentification19||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev034001.SafekeepingPlaceFormat42Choice||XmlElement()||
|+|CshAcct|ISO20022.Seev034001.CashAccountIdentification9Choice||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
|+|AcctOwnr|ISO20022.Seev034001.PartyIdentification127Choice||XmlElement()||
|+|OptnFeatrs|ISO20022.Seev034001.OptionFeaturesFormat25Choice||XmlElement()||
|+|OptnTp|ISO20022.Seev034001.CorporateActionOption41Choice||XmlElement()||
|+|OptnNb|ISO20022.Seev034001.OptionNumber1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StsCshAmt),validElement(StsQty),validElement(PrtctBal),validElement(UinstdBal),validElement(InstdBal),validElement(TtlElgblBal),validElement(FinInstrmId),validElement(SfkpgPlc),validElement(CshAcct),validElement(AcctOwnr),validElement(OptnFeatrs),validElement(OptnTp),validElement(OptnNb))|

---

## Value ISO20022.Seev034001.CorporateActionOption41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Type ISO20022.Seev034001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnInstrStsAdvc|ISO20022.Seev034001.CorporateActionInstructionStatusAdviceV15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnInstrStsAdvc))|

---

## Value ISO20022.Seev034001.DocumentIdentification33


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DocNb|ISO20022.Seev034001.DocumentNumber5Choice||XmlElement()||
|+|Id|ISO20022.Seev034001.DocumentIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DocNb),validElement(Id))|

---

## Value ISO20022.Seev034001.DocumentIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOwnrDocId|String||XmlElement()||
|+|AcctSvcrDocId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AcctOwnrDocId,AcctSvcrDocId))|

---

## Value ISO20022.Seev034001.DocumentIdentification9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev034001.DocumentNumber5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Seev034001.GenericIdentification36||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Value ISO20022.Seev034001.FinancialInstrumentQuantity18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(FaceAmt,Unit))|

---

## Value ISO20022.Seev034001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Seev034001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev034001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev034001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Seev034001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev034001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev034001.InstructionProcessingStatus55Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtrySts|ISO20022.Seev034001.ProprietaryStatusAndReason6||XmlElement()||
|+|RcvdByIssrOrOfferr|ISO20022.Seev034001.NoSpecifiedReason1||XmlElement()||
|+|StgInstr|ISO20022.Seev034001.NoSpecifiedReason1||XmlElement()||
|+|DfltActn|ISO20022.Seev034001.NoSpecifiedReason1||XmlElement()||
|+|Rtrd|ISO20022.Seev034001.ReturnedStatus2Choice||XmlElement()||
|+|Pdg|ISO20022.Seev034001.PendingStatus1||XmlElement()||
|+|Rjctd|ISO20022.Seev034001.RejectedStatus11||XmlElement()||
|+|Fwdd|ISO20022.Seev034001.NoSpecifiedReason1||XmlElement()||
|+|AccptdForFrthrPrcg|ISO20022.Seev034001.AcceptedStatus2||XmlElement()||
|+|Canc|ISO20022.Seev034001.CancelledStatus5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtrySts),validElement(RcvdByIssrOrOfferr),validElement(StgInstr),validElement(DfltActn),validElement(Rtrd),validElement(Pdg),validElement(Rjctd),validElement(Fwdd),validElement(AccptdForFrthrPrcg),validElement(Canc),validChoice(PrtrySts,RcvdByIssrOrOfferr,StgInstr,DfltActn,Rtrd,Pdg,Rjctd,Fwdd,AccptdForFrthrPrcg,Canc))|

---

## Enum ISO20022.Seev034001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Seev034001.NoSpecifiedReason1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev034001.OptionFeatures12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPLF|Int32||XmlEnum("""OPLF""")|1|

---

## Value ISO20022.Seev034001.OptionFeaturesFormat25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev034001.OptionNumber1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nb""",Nb,"""[0-9]{3}"""),validChoice(Cd,Nb))|

---

## Enum ISO20022.Seev034001.OptionNumber1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNSO|Int32||XmlEnum("""UNSO""")|1|

---

## Value ISO20022.Seev034001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev034001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev034001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev034001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev034001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Enum ISO20022.Seev034001.PendingReason27Code


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

## Value ISO20022.Seev034001.PendingReason66Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev034001.PendingStatus1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PdgRsn|ISO20022.Seev034001.PendingStatus71Choice||XmlElement()||
|+|PdgQty|ISO20022.Seev034001.Quantity51Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PdgRsn),validElement(PdgQty))|

---

## Value ISO20022.Seev034001.PendingStatus71Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev034001.PendingStatusReason27>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev034001.PendingStatusReason27


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev034001.PendingReason66Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsnCd))|

---

## Value ISO20022.Seev034001.ProprietaryQuantity8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev034001.ProprietaryReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Seev034001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Seev034001.ProprietaryStatusAndReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Seev034001.ProprietaryReason4>||XmlElement()||
|+|PrtrySts|ISO20022.Seev034001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Seev034001.ProtectInstruction2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UcvrdPrtctQty|ISO20022.Seev034001.FinancialInstrumentQuantity18Choice||XmlElement()||
|+|PrtctDt|DateTime||XmlElement()||
|+|PrtctSfkpgAcct|String||XmlElement()||
|+|TxId|String||XmlElement()||
|+|PrtctTxSts|String||XmlElement()||
|+|TxTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UcvrdPrtctQty))|

---

## Enum ISO20022.Seev034001.ProtectInstructionStatus3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXPI|Int32||XmlEnum("""EXPI""")|1|
||COVR|Int32||XmlEnum("""COVR""")|2|
||OPEN|Int32||XmlEnum("""OPEN""")|3|

---

## Enum ISO20022.Seev034001.ProtectTransactionType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COVR|Int32||XmlEnum("""COVR""")|1|
||COVP|Int32||XmlEnum("""COVP""")|2|
||PROT|Int32||XmlEnum("""PROT""")|3|

---

## Value ISO20022.Seev034001.Quantity48Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev034001.ProprietaryQuantity8||XmlElement()||
|+|Qty|ISO20022.Seev034001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(Qty),validChoice(PrtryQty,Qty))|

---

## Value ISO20022.Seev034001.Quantity51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Seev034001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Seev034001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Seev034001.RejectedReason60Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev034001.RejectedStatus11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RjctdRsn|ISO20022.Seev034001.RejectedStatus56Choice||XmlElement()||
|+|RjctdQty|ISO20022.Seev034001.Quantity51Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RjctdRsn),validElement(RjctdQty))|

---

## Value ISO20022.Seev034001.RejectedStatus56Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev034001.RejectedStatusReason56>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev034001.RejectedStatusReason56


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev034001.RejectedReason60Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsnCd))|

---

## Enum ISO20022.Seev034001.RejectionReason85Code


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

## Value ISO20022.Seev034001.ReturnedReason2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev034001.ReturnedStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROR|Int32||XmlEnum("""PROR""")|1|
||NARR|Int32||XmlEnum("""NARR""")|2|

---

## Value ISO20022.Seev034001.ReturnedStatus2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Seev034001.ReturnedStatusReason2>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Seev034001.ReturnedStatusReason2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|RsnCd|ISO20022.Seev034001.ReturnedReason2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsnCd))|

---

## Enum ISO20022.Seev034001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Seev034001.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Value ISO20022.Seev034001.SafekeepingPlaceFormat42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev034001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Seev034001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev034001.SafekeepingPlaceTypeAndText6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev034001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Seev034001.SafekeepingPlaceTypeAndText6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev034001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev034001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Seev034001.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Seev034001.SignedQuantityFormat11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyChc|ISO20022.Seev034001.Quantity48Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyChc))|

---

## Value ISO20022.Seev034001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev034001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev034001.SupplementaryDataEnvelope1


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

