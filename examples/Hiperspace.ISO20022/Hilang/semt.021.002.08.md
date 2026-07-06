# semt.021.002.08
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt021002.AcknowledgementReason16Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.AcknowledgementReason16Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.AcknowledgementReason18Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.AcknowledgementReason18Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.AcknowledgementReason5Code {
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
    class ISO20022.Semt021002.AdditionalQueryParameters14 {
        + FinInstrmId  : global::System.Collections.Generic.List~ISO20022.Semt021002.SecurityIdentification20~
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt021002.Reason20Choice~
        + Sts  : ISO20022.Semt021002.Status22Choice
    }
    ISO20022.Semt021002.AdditionalQueryParameters14 *-- ISO20022.Semt021002.SecurityIdentification20
    ISO20022.Semt021002.AdditionalQueryParameters14 *-- ISO20022.Semt021002.Reason20Choice
    ISO20022.Semt021002.AdditionalQueryParameters14 *-- ISO20022.Semt021002.Status22Choice
    class ISO20022.Semt021002.AffirmationStatus1Code {
        NAFI = 1
        AFFI = 2
    }
    class ISO20022.Semt021002.AffirmationStatus9Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.AffirmationStatus9Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.AllocationSatus4Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.AllocationSatus4Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.AllocationStatus1Code {
        AOLP = 1
        AOLF = 2
    }
    class ISO20022.Semt021002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Semt021002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Semt021002.BlockChainAddressWallet7 *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.CancellationProcessingStatus1Code {
        REPR = 1
        REJT = 2
        PARF = 3
        PACK = 4
        INTE = 5
        EXCH = 6
        DEND = 7
        CANP = 8
        CAND = 9
    }
    class ISO20022.Semt021002.CancellationProcessingStatus8Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.CancellationProcessingStatus8Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.CancellationReason30Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.CancellationReason30Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.CancelledStatusReason12Code {
        CREG = 1
        CANO = 2
        OTHR = 3
        SCEX = 4
        CORP = 5
        CANZ = 6
        CANT = 7
        CXLR = 8
        CSUB = 9
        CANS = 10
        CANI = 11
    }
    class ISO20022.Semt021002.CorporateActionEventProcessingStatus1Code {
        RECD = 1
        PEND = 2
        COMP = 3
    }
    class ISO20022.Semt021002.CorporateActionEventProcessingStatus4Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.CorporateActionEventProcessingStatus4Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.CorporateActionEventStage2Code {
        LAPS = 1
        CLDE = 2
        WHOU = 3
        UNAC = 4
        APPD = 5
        SUAP = 6
        PWAL = 7
    }
    class ISO20022.Semt021002.CorporateActionEventStage4Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.CorporateActionEventStage4Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Semt021002.DateAndPeriod3Choice {
        + StmtPrd  : ISO20022.Semt021002.Period7Choice
        + StmtDt  : ISO20022.Semt021002.DateAndDateTime2Choice
    }
    ISO20022.Semt021002.DateAndPeriod3Choice *-- ISO20022.Semt021002.Period7Choice
    ISO20022.Semt021002.DateAndPeriod3Choice *-- ISO20022.Semt021002.DateAndDateTime2Choice
    class ISO20022.Semt021002.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Semt021002.DeniedReason23Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.DeniedReason23Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.DeniedReason7Code {
        OTHR = 1
        LATE = 2
        IPNC = 3
        DSET = 4
        DREP = 5
        DFOR = 6
        DPRG = 7
        DCAN = 8
        CDRG = 9
        CDRE = 10
        CDCY = 11
        DCAL = 12
        ADEA = 13
    }
    class ISO20022.Semt021002.DocumentNumber14 {
        + Nb  : ISO20022.Semt021002.DocumentNumber6Choice
    }
    ISO20022.Semt021002.DocumentNumber14 *-- ISO20022.Semt021002.DocumentNumber6Choice
    class ISO20022.Semt021002.DocumentNumber6Choice {
        + PrtryNb  : ISO20022.Semt021002.GenericIdentification86
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Semt021002.DocumentNumber6Choice *-- ISO20022.Semt021002.GenericIdentification86
    class ISO20022.Semt021002.EventFrequency4Code {
        WEEK = 1
        INDA = 2
        DAIL = 3
        MNTH = 4
        ADHO = 5
        YEAR = 6
    }
    class ISO20022.Semt021002.FailingReason15Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.FailingReason15Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.FailingReason1Code {
        PRSY = 1
        CERT = 2
        SETS = 3
        REGT = 4
        PRCY = 5
        LIQU = 6
        LATE = 7
        LAAW = 8
        FROZ = 9
        DKNY = 10
        DISA = 11
        DENO = 12
        CLHT = 13
        BOTH = 14
        BENO = 15
        PHCK = 16
        OTHR = 17
        IAAD = 18
        MINO = 19
        CPEC = 20
        SBLO = 21
        CYCL = 22
        BATC = 23
        SDUT = 24
        REFS = 25
        NCON = 26
        MONY = 27
        LALO = 28
        LACK = 29
        LINK = 30
        INCA = 31
        FLIM = 32
        DEPO = 33
        COLL = 34
        YCOL = 35
        CMON = 36
        NOFX = 37
        PART = 38
        PREA = 39
        GLOB = 40
        MUNO = 41
        CLAC = 42
        NEWI = 43
        CHAS = 44
        BLOC = 45
        DOCC = 46
        MLAT = 47
        DOCY = 48
        STCD = 49
        PHSE = 50
        AWSH = 51
        OBJT = 52
        CAIS = 53
        CANR = 54
        ADEA = 55
        CLAT = 56
        BYIY = 57
        AWMO = 58
    }
    class ISO20022.Semt021002.Frequency26Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.Frequency26Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.GeneratedReason3Code {
        TRAN = 1
        THRD = 2
        SPLI = 3
        RODE = 4
        OTHR = 5
        CLAI = 6
        COLL = 7
    }
    class ISO20022.Semt021002.GeneratedReasons6Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.GeneratedReasons6Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt021002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt021002.GenericIdentification86 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt021002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt021002.InstructionProcessingStatus1Code {
        MPRC = 1
        UNDE = 2
        TREA = 3
        SUSP = 4
        STIN = 5
        SESE = 6
        REPR = 7
        REJT = 8
        PPRC = 9
        PART = 10
        PAFI = 11
        PACK = 12
        OVER = 13
        OPOD = 14
        NOTC = 15
        INTE = 16
        FUTU = 17
        FORC = 18
        EXSE = 19
        EXCH = 20
        DONF = 21
        DONE = 22
        DFLA = 23
        CPRC = 24
        COSE = 25
        CGEN = 26
        CANP = 27
        CANO = 28
        CAND = 29
        CAN3 = 30
        CAN2 = 31
        CAN1 = 32
    }
    class ISO20022.Semt021002.InstructionProcessingStatus26Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.InstructionProcessingStatus26Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.MatchingStatus1Code {
        NMAT = 1
        MACH = 2
    }
    class ISO20022.Semt021002.MatchingStatus28Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.MatchingStatus28Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.OtherIdentification2 {
        + Tp  : ISO20022.Semt021002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Semt021002.OtherIdentification2 *-- ISO20022.Semt021002.IdentificationSource4Choice
    class ISO20022.Semt021002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Semt021002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Semt021002.PartyIdentification136Choice *-- ISO20022.Semt021002.GenericIdentification84
    class ISO20022.Semt021002.PartyIdentification156 {
        + LEI  : String
        + Id  : ISO20022.Semt021002.PartyIdentification136Choice
    }
    ISO20022.Semt021002.PartyIdentification156 *-- ISO20022.Semt021002.PartyIdentification136Choice
    class ISO20022.Semt021002.PendingCancellationReasons5Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.PendingCancellationReasons5Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.PendingProcessingReason13Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.PendingProcessingReason13Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.PendingProcessingReason1Code {
        CERT = 1
        LIQU = 2
        DENO = 3
        OTHR = 4
        MINO = 5
        MONY = 6
        LALO = 7
        LACK = 8
        NEXT = 9
        FLIM = 10
        COLL = 11
        YCOL = 12
        GLOB = 13
        MUNO = 14
        BLOC = 15
        NOFX = 16
        DOCY = 17
        CAIS = 18
        ADEA = 19
    }
    class ISO20022.Semt021002.PendingReason37Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.PendingReason37Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.PendingReason47Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.PendingReason47Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.PendingReason6Code {
        CDRE = 1
        CDCY = 2
        CDRG = 3
        OTHR = 4
        CONF = 5
        ADEA = 6
    }
    class ISO20022.Semt021002.PendingReason7Code {
        DQUA = 1
        OTHR = 2
        CONF = 3
        ADEA = 4
    }
    class ISO20022.Semt021002.PendingReason8Code {
        IPNC = 1
        OTHR = 2
        CDRE = 3
        CONF = 4
        CDRG = 5
        CDCY = 6
        PRSY = 7
        VLDA = 8
        SETS = 9
        REGT = 10
        PRCY = 11
        PENR = 12
        NSEC = 13
        NPAY = 14
        MCER = 15
        LIQU = 16
        LATE = 17
        LAAW = 18
        FROZ = 19
        DQUA = 20
        DKNY = 21
        DISA = 22
        DENO = 23
        CLHT = 24
        BOTH = 25
        BENO = 26
        PHCK = 27
        IAAD = 28
        MINO = 29
        CPEC = 30
        SBLO = 31
        CYCL = 32
        BATC = 33
        SDUT = 34
        REFS = 35
        NCON = 36
        MONY = 37
        LALO = 38
        LACK = 39
        FUTU = 40
        LINK = 41
        INCA = 42
        NOFX = 43
        FLIM = 44
        DEPO = 45
        COLL = 46
        YCOL = 47
        CMON = 48
        NMAS = 49
        PART = 50
        PREA = 51
        GLOB = 52
        MUNO = 53
        CLAC = 54
        NEWI = 55
        CHAS = 56
        BLOC = 57
        DOCC = 58
        DOCY = 59
        TAMM = 60
        PHSE = 61
        AWSH = 62
        REFU = 63
        CAIS = 64
        AUTH = 65
        ADEA = 66
        AWMO = 67
    }
    class ISO20022.Semt021002.Period2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Semt021002.Period7Choice {
        + FrDtToDt  : ISO20022.Semt021002.Period2
        + FrDtTmToDtTm  : ISO20022.Semt021002.DateTimePeriod1
    }
    ISO20022.Semt021002.Period7Choice *-- ISO20022.Semt021002.Period2
    ISO20022.Semt021002.Period7Choice *-- ISO20022.Semt021002.DateTimePeriod1
    class ISO20022.Semt021002.Reason20Choice {
        + UmtchdRsn  : ISO20022.Semt021002.UnmatchedReason29Choice
        + PdgModRsn  : ISO20022.Semt021002.PendingReason37Choice
        + RprRsn  : ISO20022.Semt021002.RepairReason18Choice
        + RjctnRsn  : ISO20022.Semt021002.RejectionReason51Choice
        + PdgPrcgRsn  : ISO20022.Semt021002.PendingProcessingReason13Choice
        + FlngRsn  : ISO20022.Semt021002.FailingReason15Choice
        + PdgRsn  : ISO20022.Semt021002.PendingReason47Choice
        + AckdAccptdRsn  : ISO20022.Semt021002.AcknowledgementReason16Choice
        + DndRsn  : ISO20022.Semt021002.DeniedReason23Choice
        + GnrtdRsn  : ISO20022.Semt021002.GeneratedReasons6Choice
        + PdgCxlRsn  : ISO20022.Semt021002.PendingCancellationReasons5Choice
        + CxlRsn  : ISO20022.Semt021002.CancellationReason30Choice
        + RepoCallAckRsn  : ISO20022.Semt021002.AcknowledgementReason18Choice
    }
    ISO20022.Semt021002.Reason20Choice *-- ISO20022.Semt021002.UnmatchedReason29Choice
    ISO20022.Semt021002.Reason20Choice *-- ISO20022.Semt021002.PendingReason37Choice
    ISO20022.Semt021002.Reason20Choice *-- ISO20022.Semt021002.RepairReason18Choice
    ISO20022.Semt021002.Reason20Choice *-- ISO20022.Semt021002.RejectionReason51Choice
    ISO20022.Semt021002.Reason20Choice *-- ISO20022.Semt021002.PendingProcessingReason13Choice
    ISO20022.Semt021002.Reason20Choice *-- ISO20022.Semt021002.FailingReason15Choice
    ISO20022.Semt021002.Reason20Choice *-- ISO20022.Semt021002.PendingReason47Choice
    ISO20022.Semt021002.Reason20Choice *-- ISO20022.Semt021002.AcknowledgementReason16Choice
    ISO20022.Semt021002.Reason20Choice *-- ISO20022.Semt021002.DeniedReason23Choice
    ISO20022.Semt021002.Reason20Choice *-- ISO20022.Semt021002.GeneratedReasons6Choice
    ISO20022.Semt021002.Reason20Choice *-- ISO20022.Semt021002.PendingCancellationReasons5Choice
    ISO20022.Semt021002.Reason20Choice *-- ISO20022.Semt021002.CancellationReason30Choice
    ISO20022.Semt021002.Reason20Choice *-- ISO20022.Semt021002.AcknowledgementReason18Choice
    class ISO20022.Semt021002.RegistrationProcessingStatus1Code {
        REJT = 1
        PACK = 2
    }
    class ISO20022.Semt021002.RegistrationProcessingStatus4Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.RegistrationProcessingStatus4Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.RejectionReason51Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.RejectionReason51Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.RejectionReason76Code {
        PLIS = 1
        INVE = 2
        IEXE = 3
        OTHR = 4
        DEPT = 5
        ICAG = 6
        ICUS = 7
        FORF = 8
        SDUT = 9
        INPS = 10
        VASU = 11
        TERM = 12
        SETR = 13
        FEEE = 14
        DORD = 15
        DISE = 16
        DISC = 17
        DDAT = 18
        CPTY = 19
        CONL = 20
        COMC = 21
        CASY = 22
        CAEV = 23
        BUSE = 24
        BREF = 25
        BPAR = 26
        ICOL = 27
        INNA = 28
        PLCE = 29
        IIND = 30
        DTRD = 31
        SETS = 32
        RSPR = 33
        RERT = 34
        REQM = 35
        RREA = 36
        REPP = 37
        REPO = 38
        REPA = 39
        TXST = 40
        REQW = 41
        MUNO = 42
        NRGN = 43
        OWNT = 44
        DDEA = 45
        CASH = 46
        CADE = 47
        BATC = 48
        MLEG = 49
        NRGM = 50
        MINO = 51
        SHAR = 52
        SIGN = 53
        STAM = 54
        STAT = 55
        EVNM = 56
        DPRG = 57
        DCAN = 58
        OPTY = 59
        DMON = 60
        OPNM = 61
        NMTY = 62
        LATE = 63
        LACK = 64
        REFE = 65
        PHYS = 66
        REFT = 67
        INVA = 68
        INTV = 69
        CANC = 70
        INIR = 71
        DADR = 72
        DSEC = 73
        NCRR = 74
        RTGS = 75
        ADEA = 76
        DQUA = 77
        SAFE = 78
        ULNK = 79
    }
    class ISO20022.Semt021002.RepairReason18Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.RepairReason18Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.RepairReason6Code {
        ULNK = 1
        NRGN = 2
        NRGM = 3
        INNA = 4
        FEEE = 5
        COMC = 6
        BUSE = 7
        ADEA = 8
        FORF = 9
        TERM = 10
        REPP = 11
        REPO = 12
        VASU = 13
        RSPR = 14
        RERT = 15
        CADE = 16
        REPA = 17
        ICUS = 18
        DEPT = 19
        ICAG = 20
        IEXE = 21
        OTHR = 22
        SDUT = 23
        INPS = 24
        TXST = 25
        SETS = 26
        SETR = 27
        SAFE = 28
        RTGS = 29
        REFE = 30
        PLCE = 31
        PHYS = 32
        NCRR = 33
        MUNO = 34
        MINO = 35
        IIND = 36
        DTRD = 37
        DSEC = 38
        DQUA = 39
        DMON = 40
        DDEA = 41
        DDAT = 42
        CASY = 43
        CASH = 44
        CAEV = 45
        BATC = 46
    }
    class ISO20022.Semt021002.ReplacementProcessingStatus1Code {
        REPR = 1
        REPL = 2
        REJT = 3
        PEND = 4
        PART = 5
        PACK = 6
        INTE = 7
        EXCH = 8
        DEND = 9
    }
    class ISO20022.Semt021002.ReplacementProcessingStatus9Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.ReplacementProcessingStatus9Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.RepoCallAcknowledgementReason2Code {
        ADEA = 1
        CALP = 2
        CALD = 3
    }
    class ISO20022.Semt021002.RepoCallRequestStatus10Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.RepoCallRequestStatus10Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.RepoCallRequestStatus1Code {
        DEND = 1
        CACK = 2
    }
    class ISO20022.Semt021002.ResponseStatus1Code {
        SUBR = 1
        REJT = 2
        ACCT = 3
        ACCP = 4
    }
    class ISO20022.Semt021002.ResponseStatus7Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.ResponseStatus7Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.SecuritiesAccount30 {
        + Nm  : String
        + Tp  : ISO20022.Semt021002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Semt021002.SecuritiesAccount30 *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.SecuritiesSettlementStatus2Code {
        PAIN = 1
        SETT = 2
        USET = 3
        PENF = 4
        PEND = 5
    }
    class ISO20022.Semt021002.SecuritiesStatementQuery002V08 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt021002.SupplementaryData1~
        + AddtlQryParams  : global::System.Collections.Generic.List~ISO20022.Semt021002.AdditionalQueryParameters14~
        + BlckChainAdrOrWllt  : ISO20022.Semt021002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Semt021002.SecuritiesAccount30
        + AcctOwnr  : ISO20022.Semt021002.PartyIdentification156
        + StmtGnlDtls  : ISO20022.Semt021002.Statement84
        + StmtReqd  : ISO20022.Semt021002.DocumentNumber14
    }
    ISO20022.Semt021002.SecuritiesStatementQuery002V08 *-- ISO20022.Semt021002.SupplementaryData1
    ISO20022.Semt021002.SecuritiesStatementQuery002V08 *-- ISO20022.Semt021002.AdditionalQueryParameters14
    ISO20022.Semt021002.SecuritiesStatementQuery002V08 *-- ISO20022.Semt021002.BlockChainAddressWallet7
    ISO20022.Semt021002.SecuritiesStatementQuery002V08 *-- ISO20022.Semt021002.SecuritiesAccount30
    ISO20022.Semt021002.SecuritiesStatementQuery002V08 *-- ISO20022.Semt021002.PartyIdentification156
    ISO20022.Semt021002.SecuritiesStatementQuery002V08 *-- ISO20022.Semt021002.Statement84
    ISO20022.Semt021002.SecuritiesStatementQuery002V08 *-- ISO20022.Semt021002.DocumentNumber14
    class ISO20022.Semt021002.SecuritiesStatementType1Code {
        ACCT = 1
        CUST = 2
    }
    class ISO20022.Semt021002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Semt021002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Semt021002.SecurityIdentification20 *-- ISO20022.Semt021002.OtherIdentification2
    class ISO20022.Semt021002.SettlementConditionModificationStatus1Code {
        MODC = 1
        DEND = 2
        MODP = 3
        REJT = 4
        PACK = 5
    }
    class ISO20022.Semt021002.SettlementConditionModificationStatus4Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.SettlementConditionModificationStatus4Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.SettlementStatus25Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.SettlementStatus25Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.Statement84 {
        + StmtTp  : ISO20022.Semt021002.StatementType6Choice
        + StmtBsis  : ISO20022.Semt021002.StatementBasis9Choice
        + UpdTp  : ISO20022.Semt021002.UpdateType16Choice
        + Frqcy  : ISO20022.Semt021002.Frequency26Choice
        + StmtDtOrPrd  : ISO20022.Semt021002.DateAndPeriod3Choice
    }
    ISO20022.Semt021002.Statement84 *-- ISO20022.Semt021002.StatementType6Choice
    ISO20022.Semt021002.Statement84 *-- ISO20022.Semt021002.StatementBasis9Choice
    ISO20022.Semt021002.Statement84 *-- ISO20022.Semt021002.UpdateType16Choice
    ISO20022.Semt021002.Statement84 *-- ISO20022.Semt021002.Frequency26Choice
    ISO20022.Semt021002.Statement84 *-- ISO20022.Semt021002.DateAndPeriod3Choice
    class ISO20022.Semt021002.StatementBasis1Code {
        TRAD = 1
        SETT = 2
        CONT = 3
    }
    class ISO20022.Semt021002.StatementBasis9Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.StatementBasis9Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.StatementType6Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.StatementType6Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.StatementUpdateType1Code {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Semt021002.Status22Choice {
        + SttlmCondModSts  : ISO20022.Semt021002.SettlementConditionModificationStatus4Choice
        + SttlmSts  : ISO20022.Semt021002.SettlementStatus25Choice
        + CxlPrcgSts  : ISO20022.Semt021002.CancellationProcessingStatus8Choice
        + RplcmntPrcgSts  : ISO20022.Semt021002.ReplacementProcessingStatus9Choice
        + RspnSts  : ISO20022.Semt021002.ResponseStatus7Choice
        + RegnPrcgSts  : ISO20022.Semt021002.RegistrationProcessingStatus4Choice
        + MtchgSts  : ISO20022.Semt021002.MatchingStatus28Choice
        + InstrPrcgSts  : ISO20022.Semt021002.InstructionProcessingStatus26Choice
        + IfrrdMtchgSts  : ISO20022.Semt021002.MatchingStatus28Choice
        + CorpActnEvtStag  : ISO20022.Semt021002.CorporateActionEventStage4Choice
        + CorpActnEvtPrcgSts  : ISO20022.Semt021002.CorporateActionEventProcessingStatus4Choice
        + RepoCallReqSts  : ISO20022.Semt021002.RepoCallRequestStatus10Choice
        + AllcnSts  : ISO20022.Semt021002.AllocationSatus4Choice
        + AffirmSts  : ISO20022.Semt021002.AffirmationStatus9Choice
    }
    ISO20022.Semt021002.Status22Choice *-- ISO20022.Semt021002.SettlementConditionModificationStatus4Choice
    ISO20022.Semt021002.Status22Choice *-- ISO20022.Semt021002.SettlementStatus25Choice
    ISO20022.Semt021002.Status22Choice *-- ISO20022.Semt021002.CancellationProcessingStatus8Choice
    ISO20022.Semt021002.Status22Choice *-- ISO20022.Semt021002.ReplacementProcessingStatus9Choice
    ISO20022.Semt021002.Status22Choice *-- ISO20022.Semt021002.ResponseStatus7Choice
    ISO20022.Semt021002.Status22Choice *-- ISO20022.Semt021002.RegistrationProcessingStatus4Choice
    ISO20022.Semt021002.Status22Choice *-- ISO20022.Semt021002.MatchingStatus28Choice
    ISO20022.Semt021002.Status22Choice *-- ISO20022.Semt021002.InstructionProcessingStatus26Choice
    ISO20022.Semt021002.Status22Choice *-- ISO20022.Semt021002.MatchingStatus28Choice
    ISO20022.Semt021002.Status22Choice *-- ISO20022.Semt021002.CorporateActionEventStage4Choice
    ISO20022.Semt021002.Status22Choice *-- ISO20022.Semt021002.CorporateActionEventProcessingStatus4Choice
    ISO20022.Semt021002.Status22Choice *-- ISO20022.Semt021002.RepoCallRequestStatus10Choice
    ISO20022.Semt021002.Status22Choice *-- ISO20022.Semt021002.AllocationSatus4Choice
    ISO20022.Semt021002.Status22Choice *-- ISO20022.Semt021002.AffirmationStatus9Choice
    class ISO20022.Semt021002.SupplementaryData1 {
        + Envlp  : ISO20022.Semt021002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Semt021002.SupplementaryData1 *-- ISO20022.Semt021002.SupplementaryDataEnvelope1
    class ISO20022.Semt021002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Semt021002.UnmatchedReason14Code {
        DMCT = 1
        DCMX = 2
        VASU = 3
        UNBR = 4
        DELN = 5
        DEAL = 6
        DTRD = 7
        TXST = 8
        SETR = 9
        SETS = 10
        DDAT = 11
        DMON = 12
        SAFE = 13
        RTGS = 14
        RSPR = 15
        RERT = 16
        REPO = 17
        REPP = 18
        CADE = 19
        REPA = 20
        REGD = 21
        IEXE = 22
        ICUS = 23
        ICAG = 24
        DEPT = 25
        PODU = 26
        PLCE = 27
        INPS = 28
        PLIS = 29
        PHYS = 30
        FRAP = 31
        OTHR = 32
        DTRA = 33
        NMAS = 34
        CMIS = 35
        MIME = 36
        MCAN = 37
        LATE = 38
        INVE = 39
        LEOG = 40
        FORF = 41
        DQUA = 42
        DSEC = 43
        EXEC = 44
        DDEA = 45
        NCRR = 46
        CLAT = 47
        CPCA = 48
        IIND = 49
        TERM = 50
        CHAR = 51
        ACRU = 52
        ADEA = 53
    }
    class ISO20022.Semt021002.UnmatchedReason29Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.UnmatchedReason29Choice *-- ISO20022.Semt021002.GenericIdentification47
    class ISO20022.Semt021002.UpdateType16Choice {
        + Prtry  : ISO20022.Semt021002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt021002.UpdateType16Choice *-- ISO20022.Semt021002.GenericIdentification47
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

## Value ISO20022.Semt021002.AcknowledgementReason16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt021002.AcknowledgementReason18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.AcknowledgementReason5Code


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

## Value ISO20022.Semt021002.AdditionalQueryParameters14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmId|global::System.Collections.Generic.List<ISO20022.Semt021002.SecurityIdentification20>||XmlElement()||
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt021002.Reason20Choice>||XmlElement()||
|+|Sts|ISO20022.Semt021002.Status22Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""FinInstrmId""",FinInstrmId),validElement(FinInstrmId),validList("""Rsn""",Rsn),validElement(Rsn),validElement(Sts))|

---

## Enum ISO20022.Semt021002.AffirmationStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NAFI|Int32||XmlEnum("""NAFI""")|1|
||AFFI|Int32||XmlEnum("""AFFI""")|2|

---

## Value ISO20022.Semt021002.AffirmationStatus9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt021002.AllocationSatus4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.AllocationStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AOLP|Int32||XmlEnum("""AOLP""")|1|
||AOLF|Int32||XmlEnum("""AOLF""")|2|

---

## Value ISO20022.Semt021002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Enum ISO20022.Semt021002.CancellationProcessingStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REPR|Int32||XmlEnum("""REPR""")|1|
||REJT|Int32||XmlEnum("""REJT""")|2|
||PARF|Int32||XmlEnum("""PARF""")|3|
||PACK|Int32||XmlEnum("""PACK""")|4|
||INTE|Int32||XmlEnum("""INTE""")|5|
||EXCH|Int32||XmlEnum("""EXCH""")|6|
||DEND|Int32||XmlEnum("""DEND""")|7|
||CANP|Int32||XmlEnum("""CANP""")|8|
||CAND|Int32||XmlEnum("""CAND""")|9|

---

## Value ISO20022.Semt021002.CancellationProcessingStatus8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt021002.CancellationReason30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.CancelledStatusReason12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CREG|Int32||XmlEnum("""CREG""")|1|
||CANO|Int32||XmlEnum("""CANO""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||SCEX|Int32||XmlEnum("""SCEX""")|4|
||CORP|Int32||XmlEnum("""CORP""")|5|
||CANZ|Int32||XmlEnum("""CANZ""")|6|
||CANT|Int32||XmlEnum("""CANT""")|7|
||CXLR|Int32||XmlEnum("""CXLR""")|8|
||CSUB|Int32||XmlEnum("""CSUB""")|9|
||CANS|Int32||XmlEnum("""CANS""")|10|
||CANI|Int32||XmlEnum("""CANI""")|11|

---

## Enum ISO20022.Semt021002.CorporateActionEventProcessingStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECD|Int32||XmlEnum("""RECD""")|1|
||PEND|Int32||XmlEnum("""PEND""")|2|
||COMP|Int32||XmlEnum("""COMP""")|3|

---

## Value ISO20022.Semt021002.CorporateActionEventProcessingStatus4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.CorporateActionEventStage2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LAPS|Int32||XmlEnum("""LAPS""")|1|
||CLDE|Int32||XmlEnum("""CLDE""")|2|
||WHOU|Int32||XmlEnum("""WHOU""")|3|
||UNAC|Int32||XmlEnum("""UNAC""")|4|
||APPD|Int32||XmlEnum("""APPD""")|5|
||SUAP|Int32||XmlEnum("""SUAP""")|6|
||PWAL|Int32||XmlEnum("""PWAL""")|7|

---

## Value ISO20022.Semt021002.CorporateActionEventStage4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt021002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Semt021002.DateAndPeriod3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StmtPrd|ISO20022.Semt021002.Period7Choice||XmlElement()||
|+|StmtDt|ISO20022.Semt021002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmtPrd),validElement(StmtDt),validChoice(StmtPrd,StmtDt))|

---

## Value ISO20022.Semt021002.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt021002.DeniedReason23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.DeniedReason7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||LATE|Int32||XmlEnum("""LATE""")|2|
||IPNC|Int32||XmlEnum("""IPNC""")|3|
||DSET|Int32||XmlEnum("""DSET""")|4|
||DREP|Int32||XmlEnum("""DREP""")|5|
||DFOR|Int32||XmlEnum("""DFOR""")|6|
||DPRG|Int32||XmlEnum("""DPRG""")|7|
||DCAN|Int32||XmlEnum("""DCAN""")|8|
||CDRG|Int32||XmlEnum("""CDRG""")|9|
||CDRE|Int32||XmlEnum("""CDRE""")|10|
||CDCY|Int32||XmlEnum("""CDCY""")|11|
||DCAL|Int32||XmlEnum("""DCAL""")|12|
||ADEA|Int32||XmlEnum("""ADEA""")|13|

---

## Type ISO20022.Semt021002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesStmtQry|ISO20022.Semt021002.SecuritiesStatementQuery002V08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesStmtQry))|

---

## Value ISO20022.Semt021002.DocumentNumber14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nb|ISO20022.Semt021002.DocumentNumber6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Nb))|

---

## Value ISO20022.Semt021002.DocumentNumber6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Semt021002.GenericIdentification86||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Enum ISO20022.Semt021002.EventFrequency4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||INDA|Int32||XmlEnum("""INDA""")|2|
||DAIL|Int32||XmlEnum("""DAIL""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||ADHO|Int32||XmlEnum("""ADHO""")|5|
||YEAR|Int32||XmlEnum("""YEAR""")|6|

---

## Value ISO20022.Semt021002.FailingReason15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.FailingReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRSY|Int32||XmlEnum("""PRSY""")|1|
||CERT|Int32||XmlEnum("""CERT""")|2|
||SETS|Int32||XmlEnum("""SETS""")|3|
||REGT|Int32||XmlEnum("""REGT""")|4|
||PRCY|Int32||XmlEnum("""PRCY""")|5|
||LIQU|Int32||XmlEnum("""LIQU""")|6|
||LATE|Int32||XmlEnum("""LATE""")|7|
||LAAW|Int32||XmlEnum("""LAAW""")|8|
||FROZ|Int32||XmlEnum("""FROZ""")|9|
||DKNY|Int32||XmlEnum("""DKNY""")|10|
||DISA|Int32||XmlEnum("""DISA""")|11|
||DENO|Int32||XmlEnum("""DENO""")|12|
||CLHT|Int32||XmlEnum("""CLHT""")|13|
||BOTH|Int32||XmlEnum("""BOTH""")|14|
||BENO|Int32||XmlEnum("""BENO""")|15|
||PHCK|Int32||XmlEnum("""PHCK""")|16|
||OTHR|Int32||XmlEnum("""OTHR""")|17|
||IAAD|Int32||XmlEnum("""IAAD""")|18|
||MINO|Int32||XmlEnum("""MINO""")|19|
||CPEC|Int32||XmlEnum("""CPEC""")|20|
||SBLO|Int32||XmlEnum("""SBLO""")|21|
||CYCL|Int32||XmlEnum("""CYCL""")|22|
||BATC|Int32||XmlEnum("""BATC""")|23|
||SDUT|Int32||XmlEnum("""SDUT""")|24|
||REFS|Int32||XmlEnum("""REFS""")|25|
||NCON|Int32||XmlEnum("""NCON""")|26|
||MONY|Int32||XmlEnum("""MONY""")|27|
||LALO|Int32||XmlEnum("""LALO""")|28|
||LACK|Int32||XmlEnum("""LACK""")|29|
||LINK|Int32||XmlEnum("""LINK""")|30|
||INCA|Int32||XmlEnum("""INCA""")|31|
||FLIM|Int32||XmlEnum("""FLIM""")|32|
||DEPO|Int32||XmlEnum("""DEPO""")|33|
||COLL|Int32||XmlEnum("""COLL""")|34|
||YCOL|Int32||XmlEnum("""YCOL""")|35|
||CMON|Int32||XmlEnum("""CMON""")|36|
||NOFX|Int32||XmlEnum("""NOFX""")|37|
||PART|Int32||XmlEnum("""PART""")|38|
||PREA|Int32||XmlEnum("""PREA""")|39|
||GLOB|Int32||XmlEnum("""GLOB""")|40|
||MUNO|Int32||XmlEnum("""MUNO""")|41|
||CLAC|Int32||XmlEnum("""CLAC""")|42|
||NEWI|Int32||XmlEnum("""NEWI""")|43|
||CHAS|Int32||XmlEnum("""CHAS""")|44|
||BLOC|Int32||XmlEnum("""BLOC""")|45|
||DOCC|Int32||XmlEnum("""DOCC""")|46|
||MLAT|Int32||XmlEnum("""MLAT""")|47|
||DOCY|Int32||XmlEnum("""DOCY""")|48|
||STCD|Int32||XmlEnum("""STCD""")|49|
||PHSE|Int32||XmlEnum("""PHSE""")|50|
||AWSH|Int32||XmlEnum("""AWSH""")|51|
||OBJT|Int32||XmlEnum("""OBJT""")|52|
||CAIS|Int32||XmlEnum("""CAIS""")|53|
||CANR|Int32||XmlEnum("""CANR""")|54|
||ADEA|Int32||XmlEnum("""ADEA""")|55|
||CLAT|Int32||XmlEnum("""CLAT""")|56|
||BYIY|Int32||XmlEnum("""BYIY""")|57|
||AWMO|Int32||XmlEnum("""AWMO""")|58|

---

## Value ISO20022.Semt021002.Frequency26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.GeneratedReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAN|Int32||XmlEnum("""TRAN""")|1|
||THRD|Int32||XmlEnum("""THRD""")|2|
||SPLI|Int32||XmlEnum("""SPLI""")|3|
||RODE|Int32||XmlEnum("""RODE""")|4|
||OTHR|Int32||XmlEnum("""OTHR""")|5|
||CLAI|Int32||XmlEnum("""CLAI""")|6|
||COLL|Int32||XmlEnum("""COLL""")|7|

---

## Value ISO20022.Semt021002.GeneratedReasons6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt021002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt021002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt021002.GenericIdentification86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt021002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.InstructionProcessingStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MPRC|Int32||XmlEnum("""MPRC""")|1|
||UNDE|Int32||XmlEnum("""UNDE""")|2|
||TREA|Int32||XmlEnum("""TREA""")|3|
||SUSP|Int32||XmlEnum("""SUSP""")|4|
||STIN|Int32||XmlEnum("""STIN""")|5|
||SESE|Int32||XmlEnum("""SESE""")|6|
||REPR|Int32||XmlEnum("""REPR""")|7|
||REJT|Int32||XmlEnum("""REJT""")|8|
||PPRC|Int32||XmlEnum("""PPRC""")|9|
||PART|Int32||XmlEnum("""PART""")|10|
||PAFI|Int32||XmlEnum("""PAFI""")|11|
||PACK|Int32||XmlEnum("""PACK""")|12|
||OVER|Int32||XmlEnum("""OVER""")|13|
||OPOD|Int32||XmlEnum("""OPOD""")|14|
||NOTC|Int32||XmlEnum("""NOTC""")|15|
||INTE|Int32||XmlEnum("""INTE""")|16|
||FUTU|Int32||XmlEnum("""FUTU""")|17|
||FORC|Int32||XmlEnum("""FORC""")|18|
||EXSE|Int32||XmlEnum("""EXSE""")|19|
||EXCH|Int32||XmlEnum("""EXCH""")|20|
||DONF|Int32||XmlEnum("""DONF""")|21|
||DONE|Int32||XmlEnum("""DONE""")|22|
||DFLA|Int32||XmlEnum("""DFLA""")|23|
||CPRC|Int32||XmlEnum("""CPRC""")|24|
||COSE|Int32||XmlEnum("""COSE""")|25|
||CGEN|Int32||XmlEnum("""CGEN""")|26|
||CANP|Int32||XmlEnum("""CANP""")|27|
||CANO|Int32||XmlEnum("""CANO""")|28|
||CAND|Int32||XmlEnum("""CAND""")|29|
||CAN3|Int32||XmlEnum("""CAN3""")|30|
||CAN2|Int32||XmlEnum("""CAN2""")|31|
||CAN1|Int32||XmlEnum("""CAN1""")|32|

---

## Value ISO20022.Semt021002.InstructionProcessingStatus26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.MatchingStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NMAT|Int32||XmlEnum("""NMAT""")|1|
||MACH|Int32||XmlEnum("""MACH""")|2|

---

## Value ISO20022.Semt021002.MatchingStatus28Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt021002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt021002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Semt021002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Semt021002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Semt021002.PartyIdentification156


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt021002.PartyIdentification136Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt021002.PendingCancellationReasons5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt021002.PendingProcessingReason13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.PendingProcessingReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CERT|Int32||XmlEnum("""CERT""")|1|
||LIQU|Int32||XmlEnum("""LIQU""")|2|
||DENO|Int32||XmlEnum("""DENO""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||MINO|Int32||XmlEnum("""MINO""")|5|
||MONY|Int32||XmlEnum("""MONY""")|6|
||LALO|Int32||XmlEnum("""LALO""")|7|
||LACK|Int32||XmlEnum("""LACK""")|8|
||NEXT|Int32||XmlEnum("""NEXT""")|9|
||FLIM|Int32||XmlEnum("""FLIM""")|10|
||COLL|Int32||XmlEnum("""COLL""")|11|
||YCOL|Int32||XmlEnum("""YCOL""")|12|
||GLOB|Int32||XmlEnum("""GLOB""")|13|
||MUNO|Int32||XmlEnum("""MUNO""")|14|
||BLOC|Int32||XmlEnum("""BLOC""")|15|
||NOFX|Int32||XmlEnum("""NOFX""")|16|
||DOCY|Int32||XmlEnum("""DOCY""")|17|
||CAIS|Int32||XmlEnum("""CAIS""")|18|
||ADEA|Int32||XmlEnum("""ADEA""")|19|

---

## Value ISO20022.Semt021002.PendingReason37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt021002.PendingReason47Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.PendingReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDRE|Int32||XmlEnum("""CDRE""")|1|
||CDCY|Int32||XmlEnum("""CDCY""")|2|
||CDRG|Int32||XmlEnum("""CDRG""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||CONF|Int32||XmlEnum("""CONF""")|5|
||ADEA|Int32||XmlEnum("""ADEA""")|6|

---

## Enum ISO20022.Semt021002.PendingReason7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DQUA|Int32||XmlEnum("""DQUA""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||CONF|Int32||XmlEnum("""CONF""")|3|
||ADEA|Int32||XmlEnum("""ADEA""")|4|

---

## Enum ISO20022.Semt021002.PendingReason8Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||IPNC|Int32||XmlEnum("""IPNC""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||CDRE|Int32||XmlEnum("""CDRE""")|3|
||CONF|Int32||XmlEnum("""CONF""")|4|
||CDRG|Int32||XmlEnum("""CDRG""")|5|
||CDCY|Int32||XmlEnum("""CDCY""")|6|
||PRSY|Int32||XmlEnum("""PRSY""")|7|
||VLDA|Int32||XmlEnum("""VLDA""")|8|
||SETS|Int32||XmlEnum("""SETS""")|9|
||REGT|Int32||XmlEnum("""REGT""")|10|
||PRCY|Int32||XmlEnum("""PRCY""")|11|
||PENR|Int32||XmlEnum("""PENR""")|12|
||NSEC|Int32||XmlEnum("""NSEC""")|13|
||NPAY|Int32||XmlEnum("""NPAY""")|14|
||MCER|Int32||XmlEnum("""MCER""")|15|
||LIQU|Int32||XmlEnum("""LIQU""")|16|
||LATE|Int32||XmlEnum("""LATE""")|17|
||LAAW|Int32||XmlEnum("""LAAW""")|18|
||FROZ|Int32||XmlEnum("""FROZ""")|19|
||DQUA|Int32||XmlEnum("""DQUA""")|20|
||DKNY|Int32||XmlEnum("""DKNY""")|21|
||DISA|Int32||XmlEnum("""DISA""")|22|
||DENO|Int32||XmlEnum("""DENO""")|23|
||CLHT|Int32||XmlEnum("""CLHT""")|24|
||BOTH|Int32||XmlEnum("""BOTH""")|25|
||BENO|Int32||XmlEnum("""BENO""")|26|
||PHCK|Int32||XmlEnum("""PHCK""")|27|
||IAAD|Int32||XmlEnum("""IAAD""")|28|
||MINO|Int32||XmlEnum("""MINO""")|29|
||CPEC|Int32||XmlEnum("""CPEC""")|30|
||SBLO|Int32||XmlEnum("""SBLO""")|31|
||CYCL|Int32||XmlEnum("""CYCL""")|32|
||BATC|Int32||XmlEnum("""BATC""")|33|
||SDUT|Int32||XmlEnum("""SDUT""")|34|
||REFS|Int32||XmlEnum("""REFS""")|35|
||NCON|Int32||XmlEnum("""NCON""")|36|
||MONY|Int32||XmlEnum("""MONY""")|37|
||LALO|Int32||XmlEnum("""LALO""")|38|
||LACK|Int32||XmlEnum("""LACK""")|39|
||FUTU|Int32||XmlEnum("""FUTU""")|40|
||LINK|Int32||XmlEnum("""LINK""")|41|
||INCA|Int32||XmlEnum("""INCA""")|42|
||NOFX|Int32||XmlEnum("""NOFX""")|43|
||FLIM|Int32||XmlEnum("""FLIM""")|44|
||DEPO|Int32||XmlEnum("""DEPO""")|45|
||COLL|Int32||XmlEnum("""COLL""")|46|
||YCOL|Int32||XmlEnum("""YCOL""")|47|
||CMON|Int32||XmlEnum("""CMON""")|48|
||NMAS|Int32||XmlEnum("""NMAS""")|49|
||PART|Int32||XmlEnum("""PART""")|50|
||PREA|Int32||XmlEnum("""PREA""")|51|
||GLOB|Int32||XmlEnum("""GLOB""")|52|
||MUNO|Int32||XmlEnum("""MUNO""")|53|
||CLAC|Int32||XmlEnum("""CLAC""")|54|
||NEWI|Int32||XmlEnum("""NEWI""")|55|
||CHAS|Int32||XmlEnum("""CHAS""")|56|
||BLOC|Int32||XmlEnum("""BLOC""")|57|
||DOCC|Int32||XmlEnum("""DOCC""")|58|
||DOCY|Int32||XmlEnum("""DOCY""")|59|
||TAMM|Int32||XmlEnum("""TAMM""")|60|
||PHSE|Int32||XmlEnum("""PHSE""")|61|
||AWSH|Int32||XmlEnum("""AWSH""")|62|
||REFU|Int32||XmlEnum("""REFU""")|63|
||CAIS|Int32||XmlEnum("""CAIS""")|64|
||AUTH|Int32||XmlEnum("""AUTH""")|65|
||ADEA|Int32||XmlEnum("""ADEA""")|66|
||AWMO|Int32||XmlEnum("""AWMO""")|67|

---

## Value ISO20022.Semt021002.Period2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt021002.Period7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrDtToDt|ISO20022.Semt021002.Period2||XmlElement()||
|+|FrDtTmToDtTm|ISO20022.Semt021002.DateTimePeriod1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrDtToDt),validElement(FrDtTmToDtTm),validChoice(FrDtToDt,FrDtTmToDtTm))|

---

## Value ISO20022.Semt021002.Reason20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UmtchdRsn|ISO20022.Semt021002.UnmatchedReason29Choice||XmlElement()||
|+|PdgModRsn|ISO20022.Semt021002.PendingReason37Choice||XmlElement()||
|+|RprRsn|ISO20022.Semt021002.RepairReason18Choice||XmlElement()||
|+|RjctnRsn|ISO20022.Semt021002.RejectionReason51Choice||XmlElement()||
|+|PdgPrcgRsn|ISO20022.Semt021002.PendingProcessingReason13Choice||XmlElement()||
|+|FlngRsn|ISO20022.Semt021002.FailingReason15Choice||XmlElement()||
|+|PdgRsn|ISO20022.Semt021002.PendingReason47Choice||XmlElement()||
|+|AckdAccptdRsn|ISO20022.Semt021002.AcknowledgementReason16Choice||XmlElement()||
|+|DndRsn|ISO20022.Semt021002.DeniedReason23Choice||XmlElement()||
|+|GnrtdRsn|ISO20022.Semt021002.GeneratedReasons6Choice||XmlElement()||
|+|PdgCxlRsn|ISO20022.Semt021002.PendingCancellationReasons5Choice||XmlElement()||
|+|CxlRsn|ISO20022.Semt021002.CancellationReason30Choice||XmlElement()||
|+|RepoCallAckRsn|ISO20022.Semt021002.AcknowledgementReason18Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UmtchdRsn),validElement(PdgModRsn),validElement(RprRsn),validElement(RjctnRsn),validElement(PdgPrcgRsn),validElement(FlngRsn),validElement(PdgRsn),validElement(AckdAccptdRsn),validElement(DndRsn),validElement(GnrtdRsn),validElement(PdgCxlRsn),validElement(CxlRsn),validElement(RepoCallAckRsn),validChoice(UmtchdRsn,PdgModRsn,RprRsn,RjctnRsn,PdgPrcgRsn,FlngRsn,PdgRsn,AckdAccptdRsn,DndRsn,GnrtdRsn,PdgCxlRsn,CxlRsn,RepoCallAckRsn))|

---

## Enum ISO20022.Semt021002.RegistrationProcessingStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REJT|Int32||XmlEnum("""REJT""")|1|
||PACK|Int32||XmlEnum("""PACK""")|2|

---

## Value ISO20022.Semt021002.RegistrationProcessingStatus4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt021002.RejectionReason51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.RejectionReason76Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PLIS|Int32||XmlEnum("""PLIS""")|1|
||INVE|Int32||XmlEnum("""INVE""")|2|
||IEXE|Int32||XmlEnum("""IEXE""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||DEPT|Int32||XmlEnum("""DEPT""")|5|
||ICAG|Int32||XmlEnum("""ICAG""")|6|
||ICUS|Int32||XmlEnum("""ICUS""")|7|
||FORF|Int32||XmlEnum("""FORF""")|8|
||SDUT|Int32||XmlEnum("""SDUT""")|9|
||INPS|Int32||XmlEnum("""INPS""")|10|
||VASU|Int32||XmlEnum("""VASU""")|11|
||TERM|Int32||XmlEnum("""TERM""")|12|
||SETR|Int32||XmlEnum("""SETR""")|13|
||FEEE|Int32||XmlEnum("""FEEE""")|14|
||DORD|Int32||XmlEnum("""DORD""")|15|
||DISE|Int32||XmlEnum("""DISE""")|16|
||DISC|Int32||XmlEnum("""DISC""")|17|
||DDAT|Int32||XmlEnum("""DDAT""")|18|
||CPTY|Int32||XmlEnum("""CPTY""")|19|
||CONL|Int32||XmlEnum("""CONL""")|20|
||COMC|Int32||XmlEnum("""COMC""")|21|
||CASY|Int32||XmlEnum("""CASY""")|22|
||CAEV|Int32||XmlEnum("""CAEV""")|23|
||BUSE|Int32||XmlEnum("""BUSE""")|24|
||BREF|Int32||XmlEnum("""BREF""")|25|
||BPAR|Int32||XmlEnum("""BPAR""")|26|
||ICOL|Int32||XmlEnum("""ICOL""")|27|
||INNA|Int32||XmlEnum("""INNA""")|28|
||PLCE|Int32||XmlEnum("""PLCE""")|29|
||IIND|Int32||XmlEnum("""IIND""")|30|
||DTRD|Int32||XmlEnum("""DTRD""")|31|
||SETS|Int32||XmlEnum("""SETS""")|32|
||RSPR|Int32||XmlEnum("""RSPR""")|33|
||RERT|Int32||XmlEnum("""RERT""")|34|
||REQM|Int32||XmlEnum("""REQM""")|35|
||RREA|Int32||XmlEnum("""RREA""")|36|
||REPP|Int32||XmlEnum("""REPP""")|37|
||REPO|Int32||XmlEnum("""REPO""")|38|
||REPA|Int32||XmlEnum("""REPA""")|39|
||TXST|Int32||XmlEnum("""TXST""")|40|
||REQW|Int32||XmlEnum("""REQW""")|41|
||MUNO|Int32||XmlEnum("""MUNO""")|42|
||NRGN|Int32||XmlEnum("""NRGN""")|43|
||OWNT|Int32||XmlEnum("""OWNT""")|44|
||DDEA|Int32||XmlEnum("""DDEA""")|45|
||CASH|Int32||XmlEnum("""CASH""")|46|
||CADE|Int32||XmlEnum("""CADE""")|47|
||BATC|Int32||XmlEnum("""BATC""")|48|
||MLEG|Int32||XmlEnum("""MLEG""")|49|
||NRGM|Int32||XmlEnum("""NRGM""")|50|
||MINO|Int32||XmlEnum("""MINO""")|51|
||SHAR|Int32||XmlEnum("""SHAR""")|52|
||SIGN|Int32||XmlEnum("""SIGN""")|53|
||STAM|Int32||XmlEnum("""STAM""")|54|
||STAT|Int32||XmlEnum("""STAT""")|55|
||EVNM|Int32||XmlEnum("""EVNM""")|56|
||DPRG|Int32||XmlEnum("""DPRG""")|57|
||DCAN|Int32||XmlEnum("""DCAN""")|58|
||OPTY|Int32||XmlEnum("""OPTY""")|59|
||DMON|Int32||XmlEnum("""DMON""")|60|
||OPNM|Int32||XmlEnum("""OPNM""")|61|
||NMTY|Int32||XmlEnum("""NMTY""")|62|
||LATE|Int32||XmlEnum("""LATE""")|63|
||LACK|Int32||XmlEnum("""LACK""")|64|
||REFE|Int32||XmlEnum("""REFE""")|65|
||PHYS|Int32||XmlEnum("""PHYS""")|66|
||REFT|Int32||XmlEnum("""REFT""")|67|
||INVA|Int32||XmlEnum("""INVA""")|68|
||INTV|Int32||XmlEnum("""INTV""")|69|
||CANC|Int32||XmlEnum("""CANC""")|70|
||INIR|Int32||XmlEnum("""INIR""")|71|
||DADR|Int32||XmlEnum("""DADR""")|72|
||DSEC|Int32||XmlEnum("""DSEC""")|73|
||NCRR|Int32||XmlEnum("""NCRR""")|74|
||RTGS|Int32||XmlEnum("""RTGS""")|75|
||ADEA|Int32||XmlEnum("""ADEA""")|76|
||DQUA|Int32||XmlEnum("""DQUA""")|77|
||SAFE|Int32||XmlEnum("""SAFE""")|78|
||ULNK|Int32||XmlEnum("""ULNK""")|79|

---

## Value ISO20022.Semt021002.RepairReason18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.RepairReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ULNK|Int32||XmlEnum("""ULNK""")|1|
||NRGN|Int32||XmlEnum("""NRGN""")|2|
||NRGM|Int32||XmlEnum("""NRGM""")|3|
||INNA|Int32||XmlEnum("""INNA""")|4|
||FEEE|Int32||XmlEnum("""FEEE""")|5|
||COMC|Int32||XmlEnum("""COMC""")|6|
||BUSE|Int32||XmlEnum("""BUSE""")|7|
||ADEA|Int32||XmlEnum("""ADEA""")|8|
||FORF|Int32||XmlEnum("""FORF""")|9|
||TERM|Int32||XmlEnum("""TERM""")|10|
||REPP|Int32||XmlEnum("""REPP""")|11|
||REPO|Int32||XmlEnum("""REPO""")|12|
||VASU|Int32||XmlEnum("""VASU""")|13|
||RSPR|Int32||XmlEnum("""RSPR""")|14|
||RERT|Int32||XmlEnum("""RERT""")|15|
||CADE|Int32||XmlEnum("""CADE""")|16|
||REPA|Int32||XmlEnum("""REPA""")|17|
||ICUS|Int32||XmlEnum("""ICUS""")|18|
||DEPT|Int32||XmlEnum("""DEPT""")|19|
||ICAG|Int32||XmlEnum("""ICAG""")|20|
||IEXE|Int32||XmlEnum("""IEXE""")|21|
||OTHR|Int32||XmlEnum("""OTHR""")|22|
||SDUT|Int32||XmlEnum("""SDUT""")|23|
||INPS|Int32||XmlEnum("""INPS""")|24|
||TXST|Int32||XmlEnum("""TXST""")|25|
||SETS|Int32||XmlEnum("""SETS""")|26|
||SETR|Int32||XmlEnum("""SETR""")|27|
||SAFE|Int32||XmlEnum("""SAFE""")|28|
||RTGS|Int32||XmlEnum("""RTGS""")|29|
||REFE|Int32||XmlEnum("""REFE""")|30|
||PLCE|Int32||XmlEnum("""PLCE""")|31|
||PHYS|Int32||XmlEnum("""PHYS""")|32|
||NCRR|Int32||XmlEnum("""NCRR""")|33|
||MUNO|Int32||XmlEnum("""MUNO""")|34|
||MINO|Int32||XmlEnum("""MINO""")|35|
||IIND|Int32||XmlEnum("""IIND""")|36|
||DTRD|Int32||XmlEnum("""DTRD""")|37|
||DSEC|Int32||XmlEnum("""DSEC""")|38|
||DQUA|Int32||XmlEnum("""DQUA""")|39|
||DMON|Int32||XmlEnum("""DMON""")|40|
||DDEA|Int32||XmlEnum("""DDEA""")|41|
||DDAT|Int32||XmlEnum("""DDAT""")|42|
||CASY|Int32||XmlEnum("""CASY""")|43|
||CASH|Int32||XmlEnum("""CASH""")|44|
||CAEV|Int32||XmlEnum("""CAEV""")|45|
||BATC|Int32||XmlEnum("""BATC""")|46|

---

## Enum ISO20022.Semt021002.ReplacementProcessingStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REPR|Int32||XmlEnum("""REPR""")|1|
||REPL|Int32||XmlEnum("""REPL""")|2|
||REJT|Int32||XmlEnum("""REJT""")|3|
||PEND|Int32||XmlEnum("""PEND""")|4|
||PART|Int32||XmlEnum("""PART""")|5|
||PACK|Int32||XmlEnum("""PACK""")|6|
||INTE|Int32||XmlEnum("""INTE""")|7|
||EXCH|Int32||XmlEnum("""EXCH""")|8|
||DEND|Int32||XmlEnum("""DEND""")|9|

---

## Value ISO20022.Semt021002.ReplacementProcessingStatus9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.RepoCallAcknowledgementReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ADEA|Int32||XmlEnum("""ADEA""")|1|
||CALP|Int32||XmlEnum("""CALP""")|2|
||CALD|Int32||XmlEnum("""CALD""")|3|

---

## Value ISO20022.Semt021002.RepoCallRequestStatus10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.RepoCallRequestStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DEND|Int32||XmlEnum("""DEND""")|1|
||CACK|Int32||XmlEnum("""CACK""")|2|

---

## Enum ISO20022.Semt021002.ResponseStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUBR|Int32||XmlEnum("""SUBR""")|1|
||REJT|Int32||XmlEnum("""REJT""")|2|
||ACCT|Int32||XmlEnum("""ACCT""")|3|
||ACCP|Int32||XmlEnum("""ACCP""")|4|

---

## Value ISO20022.Semt021002.ResponseStatus7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt021002.SecuritiesAccount30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Enum ISO20022.Semt021002.SecuritiesSettlementStatus2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PAIN|Int32||XmlEnum("""PAIN""")|1|
||SETT|Int32||XmlEnum("""SETT""")|2|
||USET|Int32||XmlEnum("""USET""")|3|
||PENF|Int32||XmlEnum("""PENF""")|4|
||PEND|Int32||XmlEnum("""PEND""")|5|

---

## Aspect ISO20022.Semt021002.SecuritiesStatementQuery002V08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt021002.SupplementaryData1>||XmlElement()||
|+|AddtlQryParams|global::System.Collections.Generic.List<ISO20022.Semt021002.AdditionalQueryParameters14>||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt021002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt021002.SecuritiesAccount30||XmlElement()||
|+|AcctOwnr|ISO20022.Semt021002.PartyIdentification156||XmlElement()||
|+|StmtGnlDtls|ISO20022.Semt021002.Statement84||XmlElement()||
|+|StmtReqd|ISO20022.Semt021002.DocumentNumber14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""AddtlQryParams""",AddtlQryParams),validElement(AddtlQryParams),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(StmtGnlDtls),validElement(StmtReqd))|

---

## Enum ISO20022.Semt021002.SecuritiesStatementType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCT|Int32||XmlEnum("""ACCT""")|1|
||CUST|Int32||XmlEnum("""CUST""")|2|

---

## Value ISO20022.Semt021002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Semt021002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Semt021002.SettlementConditionModificationStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MODC|Int32||XmlEnum("""MODC""")|1|
||DEND|Int32||XmlEnum("""DEND""")|2|
||MODP|Int32||XmlEnum("""MODP""")|3|
||REJT|Int32||XmlEnum("""REJT""")|4|
||PACK|Int32||XmlEnum("""PACK""")|5|

---

## Value ISO20022.Semt021002.SettlementConditionModificationStatus4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt021002.SettlementStatus25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt021002.Statement84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StmtTp|ISO20022.Semt021002.StatementType6Choice||XmlElement()||
|+|StmtBsis|ISO20022.Semt021002.StatementBasis9Choice||XmlElement()||
|+|UpdTp|ISO20022.Semt021002.UpdateType16Choice||XmlElement()||
|+|Frqcy|ISO20022.Semt021002.Frequency26Choice||XmlElement()||
|+|StmtDtOrPrd|ISO20022.Semt021002.DateAndPeriod3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmtTp),validElement(StmtBsis),validElement(UpdTp),validElement(Frqcy),validElement(StmtDtOrPrd))|

---

## Enum ISO20022.Semt021002.StatementBasis1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAD|Int32||XmlEnum("""TRAD""")|1|
||SETT|Int32||XmlEnum("""SETT""")|2|
||CONT|Int32||XmlEnum("""CONT""")|3|

---

## Value ISO20022.Semt021002.StatementBasis9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt021002.StatementType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt021002.StatementUpdateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Semt021002.Status22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmCondModSts|ISO20022.Semt021002.SettlementConditionModificationStatus4Choice||XmlElement()||
|+|SttlmSts|ISO20022.Semt021002.SettlementStatus25Choice||XmlElement()||
|+|CxlPrcgSts|ISO20022.Semt021002.CancellationProcessingStatus8Choice||XmlElement()||
|+|RplcmntPrcgSts|ISO20022.Semt021002.ReplacementProcessingStatus9Choice||XmlElement()||
|+|RspnSts|ISO20022.Semt021002.ResponseStatus7Choice||XmlElement()||
|+|RegnPrcgSts|ISO20022.Semt021002.RegistrationProcessingStatus4Choice||XmlElement()||
|+|MtchgSts|ISO20022.Semt021002.MatchingStatus28Choice||XmlElement()||
|+|InstrPrcgSts|ISO20022.Semt021002.InstructionProcessingStatus26Choice||XmlElement()||
|+|IfrrdMtchgSts|ISO20022.Semt021002.MatchingStatus28Choice||XmlElement()||
|+|CorpActnEvtStag|ISO20022.Semt021002.CorporateActionEventStage4Choice||XmlElement()||
|+|CorpActnEvtPrcgSts|ISO20022.Semt021002.CorporateActionEventProcessingStatus4Choice||XmlElement()||
|+|RepoCallReqSts|ISO20022.Semt021002.RepoCallRequestStatus10Choice||XmlElement()||
|+|AllcnSts|ISO20022.Semt021002.AllocationSatus4Choice||XmlElement()||
|+|AffirmSts|ISO20022.Semt021002.AffirmationStatus9Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SttlmCondModSts),validElement(SttlmSts),validElement(CxlPrcgSts),validElement(RplcmntPrcgSts),validElement(RspnSts),validElement(RegnPrcgSts),validElement(MtchgSts),validElement(InstrPrcgSts),validElement(IfrrdMtchgSts),validElement(CorpActnEvtStag),validElement(CorpActnEvtPrcgSts),validElement(RepoCallReqSts),validElement(AllcnSts),validElement(AffirmSts),validChoice(SttlmCondModSts,SttlmSts,CxlPrcgSts,RplcmntPrcgSts,RspnSts,RegnPrcgSts,MtchgSts,InstrPrcgSts,IfrrdMtchgSts,CorpActnEvtStag,CorpActnEvtPrcgSts,RepoCallReqSts,AllcnSts,AffirmSts))|

---

## Value ISO20022.Semt021002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Semt021002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Semt021002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Semt021002.UnmatchedReason14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DMCT|Int32||XmlEnum("""DMCT""")|1|
||DCMX|Int32||XmlEnum("""DCMX""")|2|
||VASU|Int32||XmlEnum("""VASU""")|3|
||UNBR|Int32||XmlEnum("""UNBR""")|4|
||DELN|Int32||XmlEnum("""DELN""")|5|
||DEAL|Int32||XmlEnum("""DEAL""")|6|
||DTRD|Int32||XmlEnum("""DTRD""")|7|
||TXST|Int32||XmlEnum("""TXST""")|8|
||SETR|Int32||XmlEnum("""SETR""")|9|
||SETS|Int32||XmlEnum("""SETS""")|10|
||DDAT|Int32||XmlEnum("""DDAT""")|11|
||DMON|Int32||XmlEnum("""DMON""")|12|
||SAFE|Int32||XmlEnum("""SAFE""")|13|
||RTGS|Int32||XmlEnum("""RTGS""")|14|
||RSPR|Int32||XmlEnum("""RSPR""")|15|
||RERT|Int32||XmlEnum("""RERT""")|16|
||REPO|Int32||XmlEnum("""REPO""")|17|
||REPP|Int32||XmlEnum("""REPP""")|18|
||CADE|Int32||XmlEnum("""CADE""")|19|
||REPA|Int32||XmlEnum("""REPA""")|20|
||REGD|Int32||XmlEnum("""REGD""")|21|
||IEXE|Int32||XmlEnum("""IEXE""")|22|
||ICUS|Int32||XmlEnum("""ICUS""")|23|
||ICAG|Int32||XmlEnum("""ICAG""")|24|
||DEPT|Int32||XmlEnum("""DEPT""")|25|
||PODU|Int32||XmlEnum("""PODU""")|26|
||PLCE|Int32||XmlEnum("""PLCE""")|27|
||INPS|Int32||XmlEnum("""INPS""")|28|
||PLIS|Int32||XmlEnum("""PLIS""")|29|
||PHYS|Int32||XmlEnum("""PHYS""")|30|
||FRAP|Int32||XmlEnum("""FRAP""")|31|
||OTHR|Int32||XmlEnum("""OTHR""")|32|
||DTRA|Int32||XmlEnum("""DTRA""")|33|
||NMAS|Int32||XmlEnum("""NMAS""")|34|
||CMIS|Int32||XmlEnum("""CMIS""")|35|
||MIME|Int32||XmlEnum("""MIME""")|36|
||MCAN|Int32||XmlEnum("""MCAN""")|37|
||LATE|Int32||XmlEnum("""LATE""")|38|
||INVE|Int32||XmlEnum("""INVE""")|39|
||LEOG|Int32||XmlEnum("""LEOG""")|40|
||FORF|Int32||XmlEnum("""FORF""")|41|
||DQUA|Int32||XmlEnum("""DQUA""")|42|
||DSEC|Int32||XmlEnum("""DSEC""")|43|
||EXEC|Int32||XmlEnum("""EXEC""")|44|
||DDEA|Int32||XmlEnum("""DDEA""")|45|
||NCRR|Int32||XmlEnum("""NCRR""")|46|
||CLAT|Int32||XmlEnum("""CLAT""")|47|
||CPCA|Int32||XmlEnum("""CPCA""")|48|
||IIND|Int32||XmlEnum("""IIND""")|49|
||TERM|Int32||XmlEnum("""TERM""")|50|
||CHAR|Int32||XmlEnum("""CHAR""")|51|
||ACRU|Int32||XmlEnum("""ACRU""")|52|
||ADEA|Int32||XmlEnum("""ADEA""")|53|

---

## Value ISO20022.Semt021002.UnmatchedReason29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt021002.UpdateType16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt021002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

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

