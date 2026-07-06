# semt.018.001.14
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt018001.AcknowledgedAcceptedStatus21Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt018001.AcknowledgementReason9~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt018001.AcknowledgedAcceptedStatus21Choice *-- ISO20022.Semt018001.AcknowledgementReason9
    class ISO20022.Semt018001.AcknowledgementReason12Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.AcknowledgementReason12Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.AcknowledgementReason5Code {
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
    class ISO20022.Semt018001.AcknowledgementReason9 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt018001.AcknowledgementReason12Choice
    }
    ISO20022.Semt018001.AcknowledgementReason9 *-- ISO20022.Semt018001.AcknowledgementReason12Choice
    class ISO20022.Semt018001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt018001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt018001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Semt018001.AmountAndDirection51 {
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Semt018001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Semt018001.ActiveCurrencyAndAmount
    }
    ISO20022.Semt018001.AmountAndDirection51 *-- ISO20022.Semt018001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Semt018001.AmountAndDirection51 *-- ISO20022.Semt018001.ActiveCurrencyAndAmount
    class ISO20022.Semt018001.BeneficialOwnership4Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Semt018001.BeneficialOwnership4Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Semt018001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Semt018001.BlockChainAddressWallet3 *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.BlockTrade1Code {
        BLCH = 1
        BLPA = 2
    }
    class ISO20022.Semt018001.BlockTrade4Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.BlockTrade4Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.CancellationReason22 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt018001.CancellationReason36Choice
    }
    ISO20022.Semt018001.CancellationReason22 *-- ISO20022.Semt018001.CancellationReason36Choice
    class ISO20022.Semt018001.CancellationReason36Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.CancellationReason36Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.CancellationStatus24Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt018001.CancellationReason22~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt018001.CancellationStatus24Choice *-- ISO20022.Semt018001.CancellationReason22
    class ISO20022.Semt018001.CancelledStatusReason16Code {
        CORP = 1
        CANI = 2
        CANS = 3
        CSUB = 4
        CANT = 5
        CANZ = 6
        CTHP = 7
        BYIY = 8
        CXLR = 9
        OTHR = 10
        SCEX = 11
    }
    class ISO20022.Semt018001.CashSettlementSystem2Code {
        NETS = 1
        GROS = 2
    }
    class ISO20022.Semt018001.CashSettlementSystem4Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.CashSettlementSystem4Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.CentralCounterPartyEligibility4Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Semt018001.CentralCounterPartyEligibility4Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.CorporateActionEventType110Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.CorporateActionEventType110Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.CorporateActionEventType38Code {
        RCLA = 1
        TNDP = 2
        INFO = 3
        MTNG = 4
        ACCU = 5
        WRTH = 6
        WTRC = 7
        EXWA = 8
        SUSP = 9
        DLST = 10
        TEND = 11
        TREC = 12
        SPLF = 13
        DVSE = 14
        SOFF = 15
        SMAL = 16
        SHPR = 17
        DVSC = 18
        RHTS = 19
        SPLR = 20
        BIDS = 21
        REMK = 22
        REDO = 23
        BPUT = 24
        PRIO = 25
        PDEF = 26
        PLAC = 27
        PINK = 28
        PRED = 29
        PCAL = 30
        PARI = 31
        OTHR = 32
        ODLT = 33
        CERT = 34
        NOOF = 35
        MRGR = 36
        EXTM = 37
        LIQU = 38
        RHDI = 39
        INTR = 40
        PPMT = 41
        INCR = 42
        MCAL = 43
        REDM = 44
        EXOF = 45
        DTCH = 46
        DRAW = 47
        DRIP = 48
        DVOP = 49
        DSCL = 50
        DETI = 51
        DECR = 52
        CREV = 53
        CONV = 54
        CONS = 55
        CLSA = 56
        COOP = 57
        CHAN = 58
        DVCA = 59
        DRCA = 60
        CAPI = 61
        CAPG = 62
        CAPD = 63
        EXRI = 64
        BONU = 65
        DFLT = 66
        BRUP = 67
        ATTI = 68
        ACTV = 69
    }
    class ISO20022.Semt018001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Semt018001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Semt018001.DateType3Code {
        VARI = 1
    }
    class ISO20022.Semt018001.DateType4Code {
        UKWN = 1
        OPEN = 2
    }
    class ISO20022.Semt018001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Semt018001.EventFrequency4Code {
        WEEK = 1
        INDA = 2
        DAIL = 3
        MNTH = 4
        ADHO = 5
        YEAR = 6
    }
    class ISO20022.Semt018001.FailingReason11 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt018001.FailingReason16Choice
    }
    ISO20022.Semt018001.FailingReason11 *-- ISO20022.Semt018001.FailingReason16Choice
    class ISO20022.Semt018001.FailingReason16Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.FailingReason16Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.FailingReason4Code {
        PATD = 1
        PREL = 2
        INBC = 3
        CVAL = 4
        CSDH = 5
        CDLR = 6
        PRSY = 7
        CERT = 8
        SETS = 9
        REGT = 10
        PRCY = 11
        LIQU = 12
        LATE = 13
        LAAW = 14
        FROZ = 15
        DKNY = 16
        DISA = 17
        DENO = 18
        CLHT = 19
        BOTH = 20
        BENO = 21
        PHCK = 22
        OTHR = 23
        IAAD = 24
        MINO = 25
        CPEC = 26
        SBLO = 27
        CYCL = 28
        BATC = 29
        SDUT = 30
        REFS = 31
        NCON = 32
        MONY = 33
        LALO = 34
        LACK = 35
        LINK = 36
        INCA = 37
        FLIM = 38
        DEPO = 39
        COLL = 40
        YCOL = 41
        CMON = 42
        NOFX = 43
        PART = 44
        PREA = 45
        GLOB = 46
        MUNO = 47
        CLAC = 48
        NEWI = 49
        CHAS = 50
        BLOC = 51
        DOCC = 52
        MLAT = 53
        DOCY = 54
        STCD = 55
        PHSE = 56
        AWSH = 57
        OBJT = 58
        CAIS = 59
        CANR = 60
        ADEA = 61
        CLAT = 62
        BYIY = 63
        AWMO = 64
    }
    class ISO20022.Semt018001.FailingStatus13Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt018001.FailingReason11~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt018001.FailingStatus13Choice *-- ISO20022.Semt018001.FailingReason11
    class ISO20022.Semt018001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Semt018001.Frequency25Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.Frequency25Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.GeneratedReason3Code {
        TRAN = 1
        THRD = 2
        SPLI = 3
        RODE = 4
        OTHR = 5
        CLAI = 6
        COLL = 7
    }
    class ISO20022.Semt018001.GeneratedReason5 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt018001.GeneratedReasons5Choice
    }
    ISO20022.Semt018001.GeneratedReason5 *-- ISO20022.Semt018001.GeneratedReasons5Choice
    class ISO20022.Semt018001.GeneratedReasons5Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.GeneratedReasons5Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.GeneratedStatus7Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt018001.GeneratedReason5~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt018001.GeneratedStatus7Choice *-- ISO20022.Semt018001.GeneratedReason5
    class ISO20022.Semt018001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt018001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt018001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Semt018001.GenericIdentification30
    }
    ISO20022.Semt018001.GenericIdentification78 *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.HoldIndicator6 {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt018001.RegistrationReason5~
        + Ind  : String
    }
    ISO20022.Semt018001.HoldIndicator6 *-- ISO20022.Semt018001.RegistrationReason5
    class ISO20022.Semt018001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt018001.InstructionProcessingStatus42Choice {
        + ModReqd  : ISO20022.Semt018001.ProprietaryReason4
        + PdgCxl  : ISO20022.Semt018001.PendingStatus38Choice
        + Rpr  : ISO20022.Semt018001.RepairStatus12Choice
        + Gnrtd  : ISO20022.Semt018001.GeneratedStatus7Choice
        + Canc  : ISO20022.Semt018001.CancellationStatus24Choice
        + AckdAccptd  : ISO20022.Semt018001.AcknowledgedAcceptedStatus21Choice
        + CxlReqd  : ISO20022.Semt018001.ProprietaryReason4
        + PdgPrcg  : ISO20022.Semt018001.PendingProcessingStatus18Choice
    }
    ISO20022.Semt018001.InstructionProcessingStatus42Choice *-- ISO20022.Semt018001.ProprietaryReason4
    ISO20022.Semt018001.InstructionProcessingStatus42Choice *-- ISO20022.Semt018001.PendingStatus38Choice
    ISO20022.Semt018001.InstructionProcessingStatus42Choice *-- ISO20022.Semt018001.RepairStatus12Choice
    ISO20022.Semt018001.InstructionProcessingStatus42Choice *-- ISO20022.Semt018001.GeneratedStatus7Choice
    ISO20022.Semt018001.InstructionProcessingStatus42Choice *-- ISO20022.Semt018001.CancellationStatus24Choice
    ISO20022.Semt018001.InstructionProcessingStatus42Choice *-- ISO20022.Semt018001.AcknowledgedAcceptedStatus21Choice
    ISO20022.Semt018001.InstructionProcessingStatus42Choice *-- ISO20022.Semt018001.ProprietaryReason4
    ISO20022.Semt018001.InstructionProcessingStatus42Choice *-- ISO20022.Semt018001.PendingProcessingStatus18Choice
    class ISO20022.Semt018001.LetterOfGuarantee4Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Semt018001.LetterOfGuarantee4Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.MarketClientSide1Code {
        MAKT = 1
        CLNT = 2
    }
    class ISO20022.Semt018001.MarketClientSide6Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.MarketClientSide6Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.MarketIdentification1Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Semt018001.MarketIdentification84 {
        + Tp  : ISO20022.Semt018001.MarketType8Choice
        + Id  : ISO20022.Semt018001.MarketIdentification1Choice
    }
    ISO20022.Semt018001.MarketIdentification84 *-- ISO20022.Semt018001.MarketType8Choice
    ISO20022.Semt018001.MarketIdentification84 *-- ISO20022.Semt018001.MarketIdentification1Choice
    class ISO20022.Semt018001.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Semt018001.MarketType8Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.MarketType8Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.MatchingStatus24Choice {
        + Prtry  : ISO20022.Semt018001.ProprietaryStatusAndReason6
        + Umtchd  : ISO20022.Semt018001.UnmatchedStatus16Choice
        + Mtchd  : ISO20022.Semt018001.ProprietaryReason4
    }
    ISO20022.Semt018001.MatchingStatus24Choice *-- ISO20022.Semt018001.ProprietaryStatusAndReason6
    ISO20022.Semt018001.MatchingStatus24Choice *-- ISO20022.Semt018001.UnmatchedStatus16Choice
    ISO20022.Semt018001.MatchingStatus24Choice *-- ISO20022.Semt018001.ProprietaryReason4
    class ISO20022.Semt018001.NameAndAddress5 {
        + Adr  : ISO20022.Semt018001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Semt018001.NameAndAddress5 *-- ISO20022.Semt018001.PostalAddress1
    class ISO20022.Semt018001.NettingEligibility4Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Semt018001.NettingEligibility4Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Semt018001.Number3Choice {
        + Lng  : String
        + Shrt  : String
    }
    class ISO20022.Semt018001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Semt018001.OtherIdentification1 {
        + Tp  : ISO20022.Semt018001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Semt018001.OtherIdentification1 *-- ISO20022.Semt018001.IdentificationSource3Choice
    class ISO20022.Semt018001.OwnershipLegalRestrictions1Code {
        RSTR = 1
        NRST = 2
        A144 = 3
    }
    class ISO20022.Semt018001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Semt018001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Semt018001.NameAndAddress5
        + PrtryId  : ISO20022.Semt018001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Semt018001.PartyIdentification120Choice *-- ISO20022.Semt018001.NameAndAddress5
    ISO20022.Semt018001.PartyIdentification120Choice *-- ISO20022.Semt018001.GenericIdentification36
    class ISO20022.Semt018001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Semt018001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Semt018001.PartyIdentification127Choice *-- ISO20022.Semt018001.GenericIdentification36
    class ISO20022.Semt018001.PartyIdentification144 {
        + LEI  : String
        + Id  : ISO20022.Semt018001.PartyIdentification127Choice
    }
    ISO20022.Semt018001.PartyIdentification144 *-- ISO20022.Semt018001.PartyIdentification127Choice
    class ISO20022.Semt018001.PartyIdentification257Choice {
        + DgtlLdgrId  : String
        + Ctry  : String
        + NmAndAdr  : ISO20022.Semt018001.NameAndAddress5
        + AnyBIC  : String
    }
    ISO20022.Semt018001.PartyIdentification257Choice *-- ISO20022.Semt018001.NameAndAddress5
    class ISO20022.Semt018001.PartyIdentification314 {
        + PrcgId  : String
        + LEI  : String
        + Id  : ISO20022.Semt018001.PartyIdentification257Choice
    }
    ISO20022.Semt018001.PartyIdentification314 *-- ISO20022.Semt018001.PartyIdentification257Choice
    class ISO20022.Semt018001.PartyIdentificationAndAccount195 {
        + PrcgId  : String
        + BlckChainAdrOrWllt  : ISO20022.Semt018001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Semt018001.SecuritiesAccount19
        + LEI  : String
        + Id  : ISO20022.Semt018001.PartyIdentification120Choice
    }
    ISO20022.Semt018001.PartyIdentificationAndAccount195 *-- ISO20022.Semt018001.BlockChainAddressWallet3
    ISO20022.Semt018001.PartyIdentificationAndAccount195 *-- ISO20022.Semt018001.SecuritiesAccount19
    ISO20022.Semt018001.PartyIdentificationAndAccount195 *-- ISO20022.Semt018001.PartyIdentification120Choice
    class ISO20022.Semt018001.PendingProcessingReason15 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt018001.PendingProcessingReason17Choice
    }
    ISO20022.Semt018001.PendingProcessingReason15 *-- ISO20022.Semt018001.PendingProcessingReason17Choice
    class ISO20022.Semt018001.PendingProcessingReason17Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.PendingProcessingReason17Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.PendingProcessingReason4Code {
        PRSY = 1
        PREA = 2
        INBC = 3
        CDAC = 4
        CDLR = 5
        CDEL = 6
        CVAL = 7
        CSDH = 8
        CERT = 9
        LIQU = 10
        DENO = 11
        OTHR = 12
        MINO = 13
        MONY = 14
        LALO = 15
        LACK = 16
        NEXT = 17
        FLIM = 18
        COLL = 19
        YCOL = 20
        GLOB = 21
        MUNO = 22
        BLOC = 23
        NOFX = 24
        DOCY = 25
        CAIS = 26
        ADEA = 27
    }
    class ISO20022.Semt018001.PendingProcessingStatus18Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt018001.PendingProcessingReason15~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt018001.PendingProcessingStatus18Choice *-- ISO20022.Semt018001.PendingProcessingReason15
    class ISO20022.Semt018001.PendingReason16 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt018001.PendingReason28Choice
    }
    ISO20022.Semt018001.PendingReason16 *-- ISO20022.Semt018001.PendingReason28Choice
    class ISO20022.Semt018001.PendingReason24Code {
        PATD = 1
        PREL = 2
        INBC = 3
        CDLR = 4
        CVAL = 5
        CSDH = 6
        PRSY = 7
        CERT = 8
        SETS = 9
        REGT = 10
        PRCY = 11
        LIQU = 12
        LATE = 13
        LAAW = 14
        FROZ = 15
        DKNY = 16
        DISA = 17
        DENO = 18
        CLHT = 19
        BOTH = 20
        BENO = 21
        PHCK = 22
        OTHR = 23
        IAAD = 24
        MINO = 25
        CPEC = 26
        SBLO = 27
        BATC = 28
        SDUT = 29
        REFS = 30
        NCON = 31
        MONY = 32
        LALO = 33
        LACK = 34
        FUTU = 35
        LINK = 36
        INCA = 37
        FLIM = 38
        DEPO = 39
        COLL = 40
        YCOL = 41
        CMON = 42
        NOFX = 43
        NMAS = 44
        PART = 45
        PREA = 46
        GLOB = 47
        MUNO = 48
        CLAC = 49
        NEWI = 50
        CHAS = 51
        BLOC = 52
        DOCC = 53
        DOCY = 54
        TAMM = 55
        PHSE = 56
        AWSH = 57
        REFU = 58
        CAIS = 59
        ADEA = 60
        AWMO = 61
    }
    class ISO20022.Semt018001.PendingReason28Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.PendingReason28Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.PendingReason30 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt018001.PendingReason63Choice
    }
    ISO20022.Semt018001.PendingReason30 *-- ISO20022.Semt018001.PendingReason63Choice
    class ISO20022.Semt018001.PendingReason63Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.PendingReason63Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.PendingReason6Code {
        CDRE = 1
        CDCY = 2
        CDRG = 3
        OTHR = 4
        CONF = 5
        ADEA = 6
    }
    class ISO20022.Semt018001.PendingStatus38Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt018001.PendingReason16~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt018001.PendingStatus38Choice *-- ISO20022.Semt018001.PendingReason16
    class ISO20022.Semt018001.PendingStatus67Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt018001.PendingReason30~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt018001.PendingStatus67Choice *-- ISO20022.Semt018001.PendingReason30
    class ISO20022.Semt018001.PlaceOfClearingIdentification2 {
        + LEI  : String
        + Id  : String
    }
    class ISO20022.Semt018001.PlaceOfTradeIdentification1 {
        + LEI  : String
        + MktTpAndId  : ISO20022.Semt018001.MarketIdentification84
    }
    ISO20022.Semt018001.PlaceOfTradeIdentification1 *-- ISO20022.Semt018001.MarketIdentification84
    class ISO20022.Semt018001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Semt018001.ProprietaryReason4 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Semt018001.GenericIdentification30
    }
    ISO20022.Semt018001.ProprietaryReason4 *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.ProprietaryStatusAndReason6 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Semt018001.ProprietaryReason4~
        + PrtrySts  : ISO20022.Semt018001.GenericIdentification30
    }
    ISO20022.Semt018001.ProprietaryStatusAndReason6 *-- ISO20022.Semt018001.ProprietaryReason4
    ISO20022.Semt018001.ProprietaryStatusAndReason6 *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.Quantity51Choice {
        + OrgnlAndCurFace  : ISO20022.Semt018001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Semt018001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Semt018001.Quantity51Choice *-- ISO20022.Semt018001.OriginalAndCurrentQuantities1
    ISO20022.Semt018001.Quantity51Choice *-- ISO20022.Semt018001.FinancialInstrumentQuantity33Choice
    class ISO20022.Semt018001.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Semt018001.Registration10Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.Registration10Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.Registration1Code {
        YREG = 1
        NREG = 2
    }
    class ISO20022.Semt018001.Registration2Code {
        CVAL = 1
        CDEL = 2
        CSDH = 3
        PTYH = 4
    }
    class ISO20022.Semt018001.Registration9Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.Registration9Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.RegistrationReason5 {
        + AddtlInf  : String
        + Cd  : ISO20022.Semt018001.Registration10Choice
    }
    ISO20022.Semt018001.RegistrationReason5 *-- ISO20022.Semt018001.Registration10Choice
    class ISO20022.Semt018001.RepairReason10Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.RepairReason10Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.RepairReason4Code {
        ICUS = 1
        DEPT = 2
        ICAG = 3
        IEXE = 4
        OTHR = 5
        SDUT = 6
        INPS = 7
        TXST = 8
        SETS = 9
        SETR = 10
        SAFE = 11
        RTGS = 12
        REFE = 13
        PLCE = 14
        PHYS = 15
        NCRR = 16
        MUNO = 17
        MINO = 18
        IIND = 19
        DTRD = 20
        DSEC = 21
        DQUA = 22
        DMON = 23
        DDEA = 24
        DDAT = 25
        CASY = 26
        CASH = 27
        CAEV = 28
        BATC = 29
    }
    class ISO20022.Semt018001.RepairReason8 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt018001.RepairReason10Choice
    }
    ISO20022.Semt018001.RepairReason8 *-- ISO20022.Semt018001.RepairReason10Choice
    class ISO20022.Semt018001.RepairStatus12Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt018001.RepairReason8~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt018001.RepairStatus12Choice *-- ISO20022.Semt018001.RepairReason8
    class ISO20022.Semt018001.RepurchaseType22Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.RepurchaseType22Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.RepurchaseType9Code {
        WTHD = 1
        TOPU = 2
        CADJ = 3
        ROLP = 4
        CALL = 5
        RATE = 6
        PADJ = 7
        PAIR = 8
    }
    class ISO20022.Semt018001.Restriction5Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.Restriction5Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.SafeKeepingPlace5 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Semt018001.SafekeepingPlaceFormat41Choice
    }
    ISO20022.Semt018001.SafeKeepingPlace5 *-- ISO20022.Semt018001.SafekeepingPlaceFormat41Choice
    class ISO20022.Semt018001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Semt018001.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Semt018001.SafekeepingPlaceFormat41Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification78
        + TpAndId  : ISO20022.Semt018001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Semt018001.SafekeepingPlaceTypeAndText8
    }
    ISO20022.Semt018001.SafekeepingPlaceFormat41Choice *-- ISO20022.Semt018001.GenericIdentification78
    ISO20022.Semt018001.SafekeepingPlaceFormat41Choice *-- ISO20022.Semt018001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Semt018001.SafekeepingPlaceFormat41Choice *-- ISO20022.Semt018001.SafekeepingPlaceTypeAndText8
    class ISO20022.Semt018001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt018001.SafekeepingPlaceTypeAndText8 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt018001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Semt018001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Semt018001.SecuritiesAccount19 *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.SecuritiesRTGS4Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Semt018001.SecuritiesRTGS4Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.SecuritiesTransactionPendingReportV14 {
        + Txs  : global::System.Collections.Generic.List~ISO20022.Semt018001.Transaction163~
        + Sts  : global::System.Collections.Generic.List~ISO20022.Semt018001.StatusAndReason47~
        + BlckChainAdrOrWllt  : ISO20022.Semt018001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Semt018001.SecuritiesAccount19
        + AcctOwnr  : ISO20022.Semt018001.PartyIdentification144
        + StmtGnlDtls  : ISO20022.Semt018001.Statement64
        + Pgntn  : ISO20022.Semt018001.Pagination1
    }
    ISO20022.Semt018001.SecuritiesTransactionPendingReportV14 *-- ISO20022.Semt018001.Transaction163
    ISO20022.Semt018001.SecuritiesTransactionPendingReportV14 *-- ISO20022.Semt018001.StatusAndReason47
    ISO20022.Semt018001.SecuritiesTransactionPendingReportV14 *-- ISO20022.Semt018001.BlockChainAddressWallet3
    ISO20022.Semt018001.SecuritiesTransactionPendingReportV14 *-- ISO20022.Semt018001.SecuritiesAccount19
    ISO20022.Semt018001.SecuritiesTransactionPendingReportV14 *-- ISO20022.Semt018001.PartyIdentification144
    ISO20022.Semt018001.SecuritiesTransactionPendingReportV14 *-- ISO20022.Semt018001.Statement64
    ISO20022.Semt018001.SecuritiesTransactionPendingReportV14 *-- ISO20022.Semt018001.Pagination1
    class ISO20022.Semt018001.SecuritiesTransactionType26Code {
        REBL = 1
        REDI = 2
        SBBK = 3
        INSP = 4
        SLRE = 5
        ISSU = 6
        ETFT = 7
        CONV = 8
        SWIT = 9
        SWIF = 10
        AUTO = 11
        CLAI = 12
        CORP = 13
        SBRE = 14
        RELE = 15
        OWNI = 16
        FCTA = 17
        OWNE = 18
        CNCB = 19
        BYIY = 20
        TURN = 21
        TRVO = 22
        TRPO = 23
        TRAD = 24
        TBAC = 25
        SYND = 26
        SUBS = 27
        SECL = 28
        SECB = 29
        RVPO = 30
        RODE = 31
        REPU = 32
        REDM = 33
        REAL = 34
        PORT = 35
        PLAC = 36
        PAIR = 37
        NSYN = 38
        NETT = 39
        MKUP = 40
        MKDW = 41
        COLO = 42
        COLI = 43
        BSBK = 44
    }
    class ISO20022.Semt018001.SecuritiesTransactionType44Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.SecuritiesTransactionType44Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Semt018001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Semt018001.SecurityIdentification19 *-- ISO20022.Semt018001.OtherIdentification1
    class ISO20022.Semt018001.SettlementDate19Choice {
        + DtCd  : ISO20022.Semt018001.SettlementDateCode8Choice
        + Dt  : ISO20022.Semt018001.DateAndDateTime2Choice
    }
    ISO20022.Semt018001.SettlementDate19Choice *-- ISO20022.Semt018001.SettlementDateCode8Choice
    ISO20022.Semt018001.SettlementDate19Choice *-- ISO20022.Semt018001.DateAndDateTime2Choice
    class ISO20022.Semt018001.SettlementDateCode8Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.SettlementDateCode8Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.SettlementDetails184 {
        + PrtlSttlmInd  : String
        + LttrOfGrnt  : ISO20022.Semt018001.LetterOfGuarantee4Choice
        + CCPElgblty  : ISO20022.Semt018001.CentralCounterPartyEligibility4Choice
        + NetgElgblty  : ISO20022.Semt018001.NettingEligibility4Choice
        + SttlmSysMtd  : ISO20022.Semt018001.SettlementSystemMethod4Choice
        + LglRstrctns  : ISO20022.Semt018001.Restriction5Choice
        + BlckTrad  : ISO20022.Semt018001.BlockTrade4Choice
        + MktClntSd  : ISO20022.Semt018001.MarketClientSide6Choice
        + RpTp  : ISO20022.Semt018001.RepurchaseType22Choice
        + TaxCpcty  : ISO20022.Semt018001.TaxCapacityParty4Choice
        + CshClrSys  : ISO20022.Semt018001.CashSettlementSystem4Choice
        + BnfclOwnrsh  : ISO20022.Semt018001.BeneficialOwnership4Choice
        + Regn  : ISO20022.Semt018001.Registration9Choice
        + SctiesRTGS  : ISO20022.Semt018001.SecuritiesRTGS4Choice
        + StmpDtyTaxBsis  : ISO20022.Semt018001.GenericIdentification30
        + SttlgCpcty  : ISO20022.Semt018001.SettlingCapacity7Choice
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Semt018001.SettlementTransactionCondition34Choice~
        + HldInd  : ISO20022.Semt018001.HoldIndicator6
    }
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.LetterOfGuarantee4Choice
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.CentralCounterPartyEligibility4Choice
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.NettingEligibility4Choice
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.SettlementSystemMethod4Choice
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.Restriction5Choice
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.BlockTrade4Choice
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.MarketClientSide6Choice
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.RepurchaseType22Choice
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.TaxCapacityParty4Choice
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.CashSettlementSystem4Choice
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.BeneficialOwnership4Choice
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.Registration9Choice
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.SecuritiesRTGS4Choice
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.GenericIdentification30
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.SettlingCapacity7Choice
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.SettlementTransactionCondition34Choice
    ISO20022.Semt018001.SettlementDetails184 *-- ISO20022.Semt018001.HoldIndicator6
    class ISO20022.Semt018001.SettlementOrCorporateActionEvent34Choice {
        + CorpActnEvtTp  : ISO20022.Semt018001.CorporateActionEventType110Choice
        + SctiesTxTp  : ISO20022.Semt018001.SecuritiesTransactionType44Choice
    }
    ISO20022.Semt018001.SettlementOrCorporateActionEvent34Choice *-- ISO20022.Semt018001.CorporateActionEventType110Choice
    ISO20022.Semt018001.SettlementOrCorporateActionEvent34Choice *-- ISO20022.Semt018001.SecuritiesTransactionType44Choice
    class ISO20022.Semt018001.SettlementParties125 {
        + Pty5  : ISO20022.Semt018001.PartyIdentificationAndAccount195
        + Pty4  : ISO20022.Semt018001.PartyIdentificationAndAccount195
        + Pty3  : ISO20022.Semt018001.PartyIdentificationAndAccount195
        + Pty2  : ISO20022.Semt018001.PartyIdentificationAndAccount195
        + Pty1  : ISO20022.Semt018001.PartyIdentificationAndAccount195
        + Dpstry  : ISO20022.Semt018001.PartyIdentification314
    }
    ISO20022.Semt018001.SettlementParties125 *-- ISO20022.Semt018001.PartyIdentificationAndAccount195
    ISO20022.Semt018001.SettlementParties125 *-- ISO20022.Semt018001.PartyIdentificationAndAccount195
    ISO20022.Semt018001.SettlementParties125 *-- ISO20022.Semt018001.PartyIdentificationAndAccount195
    ISO20022.Semt018001.SettlementParties125 *-- ISO20022.Semt018001.PartyIdentificationAndAccount195
    ISO20022.Semt018001.SettlementParties125 *-- ISO20022.Semt018001.PartyIdentificationAndAccount195
    ISO20022.Semt018001.SettlementParties125 *-- ISO20022.Semt018001.PartyIdentification314
    class ISO20022.Semt018001.SettlementStatus30Choice {
        + Prtry  : ISO20022.Semt018001.ProprietaryStatusAndReason6
        + Flng  : ISO20022.Semt018001.FailingStatus13Choice
        + Pdg  : ISO20022.Semt018001.PendingStatus67Choice
    }
    ISO20022.Semt018001.SettlementStatus30Choice *-- ISO20022.Semt018001.ProprietaryStatusAndReason6
    ISO20022.Semt018001.SettlementStatus30Choice *-- ISO20022.Semt018001.FailingStatus13Choice
    ISO20022.Semt018001.SettlementStatus30Choice *-- ISO20022.Semt018001.PendingStatus67Choice
    class ISO20022.Semt018001.SettlementSystemMethod1Code {
        YSET = 1
        NSET = 2
    }
    class ISO20022.Semt018001.SettlementSystemMethod4Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.SettlementSystemMethod4Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.SettlementTransactionCondition12Code {
        BPSS = 1
        INTS = 2
        UNEX = 3
        TRIP = 4
        TRAN = 5
        SPST = 6
        SPDL = 7
        SHOR = 8
        RESI = 9
        RPTO = 10
        RHYP = 11
        PHYS = 12
        PENS = 13
        NACT = 14
        NOMC = 15
        KNOC = 16
        FRCL = 17
        EXPI = 18
        EXER = 19
        DRAW = 20
        DIRT = 21
        DLWM = 22
        CLEN = 23
        BUTC = 24
        ASGN = 25
        ADEA = 26
    }
    class ISO20022.Semt018001.SettlementTransactionCondition34Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.SettlementTransactionCondition34Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.SettlementTransactionCondition5Code {
        PARQ = 1
        PARC = 2
        NPAR = 3
        PART = 4
    }
    class ISO20022.Semt018001.SettlingCapacity2Code {
        RISP = 1
        SPRI = 2
        CUST = 3
        SAGE = 4
    }
    class ISO20022.Semt018001.SettlingCapacity7Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.SettlingCapacity7Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.Statement64 {
        + ActvtyInd  : String
        + StmtStr  : String
        + UpdTp  : ISO20022.Semt018001.UpdateType15Choice
        + Frqcy  : ISO20022.Semt018001.Frequency25Choice
        + StmtDtTm  : ISO20022.Semt018001.DateAndDateTime2Choice
        + StmtId  : String
        + QryRef  : String
        + RptNb  : ISO20022.Semt018001.Number3Choice
    }
    ISO20022.Semt018001.Statement64 *-- ISO20022.Semt018001.UpdateType15Choice
    ISO20022.Semt018001.Statement64 *-- ISO20022.Semt018001.Frequency25Choice
    ISO20022.Semt018001.Statement64 *-- ISO20022.Semt018001.DateAndDateTime2Choice
    ISO20022.Semt018001.Statement64 *-- ISO20022.Semt018001.Number3Choice
    class ISO20022.Semt018001.StatementStructure1Code {
        TRAN = 1
        STAT = 2
    }
    class ISO20022.Semt018001.StatementUpdateType1Code {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Semt018001.Status38Choice {
        + InstrPrcgSts  : ISO20022.Semt018001.InstructionProcessingStatus42Choice
        + SttlmSts  : ISO20022.Semt018001.SettlementStatus30Choice
        + IfrrdMtchgSts  : ISO20022.Semt018001.MatchingStatus24Choice
        + MtchgSts  : ISO20022.Semt018001.MatchingStatus24Choice
        + Prtry  : ISO20022.Semt018001.ProprietaryStatusAndReason6
    }
    ISO20022.Semt018001.Status38Choice *-- ISO20022.Semt018001.InstructionProcessingStatus42Choice
    ISO20022.Semt018001.Status38Choice *-- ISO20022.Semt018001.SettlementStatus30Choice
    ISO20022.Semt018001.Status38Choice *-- ISO20022.Semt018001.MatchingStatus24Choice
    ISO20022.Semt018001.Status38Choice *-- ISO20022.Semt018001.MatchingStatus24Choice
    ISO20022.Semt018001.Status38Choice *-- ISO20022.Semt018001.ProprietaryStatusAndReason6
    class ISO20022.Semt018001.StatusAndReason47 {
        + Tx  : global::System.Collections.Generic.List~ISO20022.Semt018001.Transaction162~
        + StsAndRsn  : ISO20022.Semt018001.Status38Choice
    }
    ISO20022.Semt018001.StatusAndReason47 *-- ISO20022.Semt018001.Transaction162
    ISO20022.Semt018001.StatusAndReason47 *-- ISO20022.Semt018001.Status38Choice
    class ISO20022.Semt018001.SupplementaryData1 {
        + Envlp  : ISO20022.Semt018001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Semt018001.SupplementaryData1 *-- ISO20022.Semt018001.SupplementaryDataEnvelope1
    class ISO20022.Semt018001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Semt018001.TaxCapacityParty4Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.TaxCapacityParty4Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.TaxLiability1Code {
        AGEN = 1
        PRIN = 2
    }
    class ISO20022.Semt018001.TradeDate8Choice {
        + DtCd  : ISO20022.Semt018001.TradeDateCode3Choice
        + Dt  : ISO20022.Semt018001.DateAndDateTime2Choice
    }
    ISO20022.Semt018001.TradeDate8Choice *-- ISO20022.Semt018001.TradeDateCode3Choice
    ISO20022.Semt018001.TradeDate8Choice *-- ISO20022.Semt018001.DateAndDateTime2Choice
    class ISO20022.Semt018001.TradeDateCode3Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.TradeDateCode3Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.Transaction162 {
        + TxDtls  : ISO20022.Semt018001.TransactionDetails170
        + TrptyAgtSvcPrvdrCollInstrId  : String
        + ClntCollInstrId  : String
        + ClntTrptyCollTxId  : String
        + TrptyAgtSvcPrvdrCollTxId  : String
        + CorpActnEvtId  : String
        + CmonId  : String
        + PoolId  : String
        + UnqTxIdr  : String
        + TradId  : String
        + PrcrTxId  : String
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    ISO20022.Semt018001.Transaction162 *-- ISO20022.Semt018001.TransactionDetails170
    class ISO20022.Semt018001.Transaction163 {
        + StsAndRsn  : global::System.Collections.Generic.List~ISO20022.Semt018001.Status38Choice~
        + TxDtls  : ISO20022.Semt018001.TransactionDetails170
        + TrptyAgtSvcPrvdrCollInstrId  : String
        + ClntCollInstrId  : String
        + ClntTrptyCollTxId  : String
        + TrptyAgtSvcPrvdrCollTxId  : String
        + CorpActnEvtId  : String
        + CmonId  : String
        + PoolId  : String
        + UnqTxIdr  : String
        + TradId  : String
        + PrcrTxId  : String
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    ISO20022.Semt018001.Transaction163 *-- ISO20022.Semt018001.Status38Choice
    ISO20022.Semt018001.Transaction163 *-- ISO20022.Semt018001.TransactionDetails170
    class ISO20022.Semt018001.TransactionActivity1Code {
        SETT = 1
        CORP = 2
        COLL = 3
        CLAI = 4
        BOLE = 5
    }
    class ISO20022.Semt018001.TransactionActivity3Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.TransactionActivity3Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.TransactionDetails170 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt018001.SupplementaryData1~
        + TxAddtlDtls  : String
        + RcvgSttlmPties  : ISO20022.Semt018001.SettlementParties125
        + DlvrgSttlmPties  : ISO20022.Semt018001.SettlementParties125
        + MtchdStsTmStmp  : DateTime
        + AckdStsTmStmp  : DateTime
        + XpctdValDt  : ISO20022.Semt018001.DateAndDateTime2Choice
        + LateDlvryDt  : ISO20022.Semt018001.DateAndDateTime2Choice
        + SttlmDt  : ISO20022.Semt018001.SettlementDate19Choice
        + XpctdSttlmDt  : ISO20022.Semt018001.DateAndDateTime2Choice
        + TradDt  : ISO20022.Semt018001.TradeDate8Choice
        + PstngAmt  : ISO20022.Semt018001.AmountAndDirection51
        + PrtlyRlsdQty  : ISO20022.Semt018001.Quantity51Choice
        + PstngQty  : ISO20022.Semt018001.Quantity51Choice
        + FinInstrmId  : ISO20022.Semt018001.SecurityIdentification19
        + PlcOfClr  : ISO20022.Semt018001.PlaceOfClearingIdentification2
        + SfkpgPlc  : ISO20022.Semt018001.SafeKeepingPlace5
        + PlcOfTrad  : ISO20022.Semt018001.PlaceOfTradeIdentification1
        + SttlmParams  : ISO20022.Semt018001.SettlementDetails184
        + Pmt  : String
        + SctiesMvmntTp  : String
        + SttlmTxOrCorpActnEvtTp  : ISO20022.Semt018001.SettlementOrCorporateActionEvent34Choice
        + TxActvty  : ISO20022.Semt018001.TransactionActivity3Choice
    }
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.SupplementaryData1
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.SettlementParties125
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.SettlementParties125
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.DateAndDateTime2Choice
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.DateAndDateTime2Choice
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.SettlementDate19Choice
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.DateAndDateTime2Choice
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.TradeDate8Choice
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.AmountAndDirection51
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.Quantity51Choice
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.Quantity51Choice
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.SecurityIdentification19
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.PlaceOfClearingIdentification2
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.SafeKeepingPlace5
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.PlaceOfTradeIdentification1
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.SettlementDetails184
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.SettlementOrCorporateActionEvent34Choice
    ISO20022.Semt018001.TransactionDetails170 *-- ISO20022.Semt018001.TransactionActivity3Choice
    class ISO20022.Semt018001.UnmatchedReason11Code {
        UNBR = 1
        DELN = 2
        DTRD = 3
        TXST = 4
        SETR = 5
        SETS = 6
        DDAT = 7
        DMON = 8
        SAFE = 9
        RTGS = 10
        REGD = 11
        IEXE = 12
        ICUS = 13
        ICAG = 14
        DEPT = 15
        PODU = 16
        PLCE = 17
        INPS = 18
        PLIS = 19
        PHYS = 20
        FRAP = 21
        OTHR = 22
        DTRA = 23
        NMAS = 24
        CMIS = 25
        MIME = 26
        LATE = 27
        LEOG = 28
        INVE = 29
        DQUA = 30
        DSEC = 31
        DCMX = 32
        DMCT = 33
        DDEA = 34
        NCRR = 35
        CLAT = 36
        CPCA = 37
        IIND = 38
        ACRU = 39
        ADEA = 40
    }
    class ISO20022.Semt018001.UnmatchedReason15 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt018001.UnmatchedReason21Choice
    }
    ISO20022.Semt018001.UnmatchedReason15 *-- ISO20022.Semt018001.UnmatchedReason21Choice
    class ISO20022.Semt018001.UnmatchedReason21Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.UnmatchedReason21Choice *-- ISO20022.Semt018001.GenericIdentification30
    class ISO20022.Semt018001.UnmatchedStatus16Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt018001.UnmatchedReason15~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt018001.UnmatchedStatus16Choice *-- ISO20022.Semt018001.UnmatchedReason15
    class ISO20022.Semt018001.UpdateType15Choice {
        + Prtry  : ISO20022.Semt018001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt018001.UpdateType15Choice *-- ISO20022.Semt018001.GenericIdentification30
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

## Value ISO20022.Semt018001.AcknowledgedAcceptedStatus21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt018001.AcknowledgementReason9>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt018001.AcknowledgementReason12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt018001.AcknowledgementReason5Code


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

## Value ISO20022.Semt018001.AcknowledgementReason9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt018001.AcknowledgementReason12Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt018001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt018001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Semt018001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Semt018001.AmountAndDirection51


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Semt018001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Semt018001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Semt018001.BeneficialOwnership4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Semt018001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Semt018001.BlockTrade1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BLCH|Int32||XmlEnum("""BLCH""")|1|
||BLPA|Int32||XmlEnum("""BLPA""")|2|

---

## Value ISO20022.Semt018001.BlockTrade4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.CancellationReason22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt018001.CancellationReason36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt018001.CancellationReason36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.CancellationStatus24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt018001.CancellationReason22>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Semt018001.CancelledStatusReason16Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CORP|Int32||XmlEnum("""CORP""")|1|
||CANI|Int32||XmlEnum("""CANI""")|2|
||CANS|Int32||XmlEnum("""CANS""")|3|
||CSUB|Int32||XmlEnum("""CSUB""")|4|
||CANT|Int32||XmlEnum("""CANT""")|5|
||CANZ|Int32||XmlEnum("""CANZ""")|6|
||CTHP|Int32||XmlEnum("""CTHP""")|7|
||BYIY|Int32||XmlEnum("""BYIY""")|8|
||CXLR|Int32||XmlEnum("""CXLR""")|9|
||OTHR|Int32||XmlEnum("""OTHR""")|10|
||SCEX|Int32||XmlEnum("""SCEX""")|11|

---

## Enum ISO20022.Semt018001.CashSettlementSystem2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETS|Int32||XmlEnum("""NETS""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Value ISO20022.Semt018001.CashSettlementSystem4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.CentralCounterPartyEligibility4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Semt018001.CorporateActionEventType110Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt018001.CorporateActionEventType38Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RCLA|Int32||XmlEnum("""RCLA""")|1|
||TNDP|Int32||XmlEnum("""TNDP""")|2|
||INFO|Int32||XmlEnum("""INFO""")|3|
||MTNG|Int32||XmlEnum("""MTNG""")|4|
||ACCU|Int32||XmlEnum("""ACCU""")|5|
||WRTH|Int32||XmlEnum("""WRTH""")|6|
||WTRC|Int32||XmlEnum("""WTRC""")|7|
||EXWA|Int32||XmlEnum("""EXWA""")|8|
||SUSP|Int32||XmlEnum("""SUSP""")|9|
||DLST|Int32||XmlEnum("""DLST""")|10|
||TEND|Int32||XmlEnum("""TEND""")|11|
||TREC|Int32||XmlEnum("""TREC""")|12|
||SPLF|Int32||XmlEnum("""SPLF""")|13|
||DVSE|Int32||XmlEnum("""DVSE""")|14|
||SOFF|Int32||XmlEnum("""SOFF""")|15|
||SMAL|Int32||XmlEnum("""SMAL""")|16|
||SHPR|Int32||XmlEnum("""SHPR""")|17|
||DVSC|Int32||XmlEnum("""DVSC""")|18|
||RHTS|Int32||XmlEnum("""RHTS""")|19|
||SPLR|Int32||XmlEnum("""SPLR""")|20|
||BIDS|Int32||XmlEnum("""BIDS""")|21|
||REMK|Int32||XmlEnum("""REMK""")|22|
||REDO|Int32||XmlEnum("""REDO""")|23|
||BPUT|Int32||XmlEnum("""BPUT""")|24|
||PRIO|Int32||XmlEnum("""PRIO""")|25|
||PDEF|Int32||XmlEnum("""PDEF""")|26|
||PLAC|Int32||XmlEnum("""PLAC""")|27|
||PINK|Int32||XmlEnum("""PINK""")|28|
||PRED|Int32||XmlEnum("""PRED""")|29|
||PCAL|Int32||XmlEnum("""PCAL""")|30|
||PARI|Int32||XmlEnum("""PARI""")|31|
||OTHR|Int32||XmlEnum("""OTHR""")|32|
||ODLT|Int32||XmlEnum("""ODLT""")|33|
||CERT|Int32||XmlEnum("""CERT""")|34|
||NOOF|Int32||XmlEnum("""NOOF""")|35|
||MRGR|Int32||XmlEnum("""MRGR""")|36|
||EXTM|Int32||XmlEnum("""EXTM""")|37|
||LIQU|Int32||XmlEnum("""LIQU""")|38|
||RHDI|Int32||XmlEnum("""RHDI""")|39|
||INTR|Int32||XmlEnum("""INTR""")|40|
||PPMT|Int32||XmlEnum("""PPMT""")|41|
||INCR|Int32||XmlEnum("""INCR""")|42|
||MCAL|Int32||XmlEnum("""MCAL""")|43|
||REDM|Int32||XmlEnum("""REDM""")|44|
||EXOF|Int32||XmlEnum("""EXOF""")|45|
||DTCH|Int32||XmlEnum("""DTCH""")|46|
||DRAW|Int32||XmlEnum("""DRAW""")|47|
||DRIP|Int32||XmlEnum("""DRIP""")|48|
||DVOP|Int32||XmlEnum("""DVOP""")|49|
||DSCL|Int32||XmlEnum("""DSCL""")|50|
||DETI|Int32||XmlEnum("""DETI""")|51|
||DECR|Int32||XmlEnum("""DECR""")|52|
||CREV|Int32||XmlEnum("""CREV""")|53|
||CONV|Int32||XmlEnum("""CONV""")|54|
||CONS|Int32||XmlEnum("""CONS""")|55|
||CLSA|Int32||XmlEnum("""CLSA""")|56|
||COOP|Int32||XmlEnum("""COOP""")|57|
||CHAN|Int32||XmlEnum("""CHAN""")|58|
||DVCA|Int32||XmlEnum("""DVCA""")|59|
||DRCA|Int32||XmlEnum("""DRCA""")|60|
||CAPI|Int32||XmlEnum("""CAPI""")|61|
||CAPG|Int32||XmlEnum("""CAPG""")|62|
||CAPD|Int32||XmlEnum("""CAPD""")|63|
||EXRI|Int32||XmlEnum("""EXRI""")|64|
||BONU|Int32||XmlEnum("""BONU""")|65|
||DFLT|Int32||XmlEnum("""DFLT""")|66|
||BRUP|Int32||XmlEnum("""BRUP""")|67|
||ATTI|Int32||XmlEnum("""ATTI""")|68|
||ACTV|Int32||XmlEnum("""ACTV""")|69|

---

## Enum ISO20022.Semt018001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Semt018001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Semt018001.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Semt018001.DateType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||OPEN|Int32||XmlEnum("""OPEN""")|2|

---

## Enum ISO20022.Semt018001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Type ISO20022.Semt018001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesTxPdgRpt|ISO20022.Semt018001.SecuritiesTransactionPendingReportV14||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesTxPdgRpt))|

---

## Enum ISO20022.Semt018001.EventFrequency4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||INDA|Int32||XmlEnum("""INDA""")|2|
||DAIL|Int32||XmlEnum("""DAIL""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||ADHO|Int32||XmlEnum("""ADHO""")|5|
||YEAR|Int32||XmlEnum("""YEAR""")|6|

---

## Value ISO20022.Semt018001.FailingReason11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt018001.FailingReason16Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt018001.FailingReason16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt018001.FailingReason4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PATD|Int32||XmlEnum("""PATD""")|1|
||PREL|Int32||XmlEnum("""PREL""")|2|
||INBC|Int32||XmlEnum("""INBC""")|3|
||CVAL|Int32||XmlEnum("""CVAL""")|4|
||CSDH|Int32||XmlEnum("""CSDH""")|5|
||CDLR|Int32||XmlEnum("""CDLR""")|6|
||PRSY|Int32||XmlEnum("""PRSY""")|7|
||CERT|Int32||XmlEnum("""CERT""")|8|
||SETS|Int32||XmlEnum("""SETS""")|9|
||REGT|Int32||XmlEnum("""REGT""")|10|
||PRCY|Int32||XmlEnum("""PRCY""")|11|
||LIQU|Int32||XmlEnum("""LIQU""")|12|
||LATE|Int32||XmlEnum("""LATE""")|13|
||LAAW|Int32||XmlEnum("""LAAW""")|14|
||FROZ|Int32||XmlEnum("""FROZ""")|15|
||DKNY|Int32||XmlEnum("""DKNY""")|16|
||DISA|Int32||XmlEnum("""DISA""")|17|
||DENO|Int32||XmlEnum("""DENO""")|18|
||CLHT|Int32||XmlEnum("""CLHT""")|19|
||BOTH|Int32||XmlEnum("""BOTH""")|20|
||BENO|Int32||XmlEnum("""BENO""")|21|
||PHCK|Int32||XmlEnum("""PHCK""")|22|
||OTHR|Int32||XmlEnum("""OTHR""")|23|
||IAAD|Int32||XmlEnum("""IAAD""")|24|
||MINO|Int32||XmlEnum("""MINO""")|25|
||CPEC|Int32||XmlEnum("""CPEC""")|26|
||SBLO|Int32||XmlEnum("""SBLO""")|27|
||CYCL|Int32||XmlEnum("""CYCL""")|28|
||BATC|Int32||XmlEnum("""BATC""")|29|
||SDUT|Int32||XmlEnum("""SDUT""")|30|
||REFS|Int32||XmlEnum("""REFS""")|31|
||NCON|Int32||XmlEnum("""NCON""")|32|
||MONY|Int32||XmlEnum("""MONY""")|33|
||LALO|Int32||XmlEnum("""LALO""")|34|
||LACK|Int32||XmlEnum("""LACK""")|35|
||LINK|Int32||XmlEnum("""LINK""")|36|
||INCA|Int32||XmlEnum("""INCA""")|37|
||FLIM|Int32||XmlEnum("""FLIM""")|38|
||DEPO|Int32||XmlEnum("""DEPO""")|39|
||COLL|Int32||XmlEnum("""COLL""")|40|
||YCOL|Int32||XmlEnum("""YCOL""")|41|
||CMON|Int32||XmlEnum("""CMON""")|42|
||NOFX|Int32||XmlEnum("""NOFX""")|43|
||PART|Int32||XmlEnum("""PART""")|44|
||PREA|Int32||XmlEnum("""PREA""")|45|
||GLOB|Int32||XmlEnum("""GLOB""")|46|
||MUNO|Int32||XmlEnum("""MUNO""")|47|
||CLAC|Int32||XmlEnum("""CLAC""")|48|
||NEWI|Int32||XmlEnum("""NEWI""")|49|
||CHAS|Int32||XmlEnum("""CHAS""")|50|
||BLOC|Int32||XmlEnum("""BLOC""")|51|
||DOCC|Int32||XmlEnum("""DOCC""")|52|
||MLAT|Int32||XmlEnum("""MLAT""")|53|
||DOCY|Int32||XmlEnum("""DOCY""")|54|
||STCD|Int32||XmlEnum("""STCD""")|55|
||PHSE|Int32||XmlEnum("""PHSE""")|56|
||AWSH|Int32||XmlEnum("""AWSH""")|57|
||OBJT|Int32||XmlEnum("""OBJT""")|58|
||CAIS|Int32||XmlEnum("""CAIS""")|59|
||CANR|Int32||XmlEnum("""CANR""")|60|
||ADEA|Int32||XmlEnum("""ADEA""")|61|
||CLAT|Int32||XmlEnum("""CLAT""")|62|
||BYIY|Int32||XmlEnum("""BYIY""")|63|
||AWMO|Int32||XmlEnum("""AWMO""")|64|

---

## Value ISO20022.Semt018001.FailingStatus13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt018001.FailingReason11>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt018001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Semt018001.Frequency25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt018001.GeneratedReason3Code


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

## Value ISO20022.Semt018001.GeneratedReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt018001.GeneratedReasons5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt018001.GeneratedReasons5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.GeneratedStatus7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt018001.GeneratedReason5>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt018001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt018001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt018001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt018001.HoldIndicator6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt018001.RegistrationReason5>||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rsn""",Rsn),validElement(Rsn))|

---

## Value ISO20022.Semt018001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.InstructionProcessingStatus42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ModReqd|ISO20022.Semt018001.ProprietaryReason4||XmlElement()||
|+|PdgCxl|ISO20022.Semt018001.PendingStatus38Choice||XmlElement()||
|+|Rpr|ISO20022.Semt018001.RepairStatus12Choice||XmlElement()||
|+|Gnrtd|ISO20022.Semt018001.GeneratedStatus7Choice||XmlElement()||
|+|Canc|ISO20022.Semt018001.CancellationStatus24Choice||XmlElement()||
|+|AckdAccptd|ISO20022.Semt018001.AcknowledgedAcceptedStatus21Choice||XmlElement()||
|+|CxlReqd|ISO20022.Semt018001.ProprietaryReason4||XmlElement()||
|+|PdgPrcg|ISO20022.Semt018001.PendingProcessingStatus18Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ModReqd),validElement(PdgCxl),validElement(Rpr),validElement(Gnrtd),validElement(Canc),validElement(AckdAccptd),validElement(CxlReqd),validElement(PdgPrcg),validChoice(ModReqd,PdgCxl,Rpr,Gnrtd,Canc,AckdAccptd,CxlReqd,PdgPrcg))|

---

## Value ISO20022.Semt018001.LetterOfGuarantee4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Enum ISO20022.Semt018001.MarketClientSide1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MAKT|Int32||XmlEnum("""MAKT""")|1|
||CLNT|Int32||XmlEnum("""CLNT""")|2|

---

## Value ISO20022.Semt018001.MarketClientSide6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.MarketIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Semt018001.MarketIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt018001.MarketType8Choice||XmlElement()||
|+|Id|ISO20022.Semt018001.MarketIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Enum ISO20022.Semt018001.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Value ISO20022.Semt018001.MarketType8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.MatchingStatus24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.ProprietaryStatusAndReason6||XmlElement()||
|+|Umtchd|ISO20022.Semt018001.UnmatchedStatus16Choice||XmlElement()||
|+|Mtchd|ISO20022.Semt018001.ProprietaryReason4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Umtchd),validElement(Mtchd),validChoice(Prtry,Umtchd,Mtchd))|

---

## Value ISO20022.Semt018001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Semt018001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Semt018001.NettingEligibility4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Enum ISO20022.Semt018001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Semt018001.Number3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|String||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lng""",Lng,"""[0-9]{5}"""),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Value ISO20022.Semt018001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt018001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt018001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Semt018001.OwnershipLegalRestrictions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSTR|Int32||XmlEnum("""RSTR""")|1|
||NRST|Int32||XmlEnum("""NRST""")|2|
||A144|Int32||XmlEnum("""A144""")|3|

---

## Value ISO20022.Semt018001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Semt018001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Semt018001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Semt018001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Semt018001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Semt018001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Semt018001.PartyIdentification144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt018001.PartyIdentification127Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt018001.PartyIdentification257Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Semt018001.NameAndAddress5||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(DgtlLdgrId,Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Semt018001.PartyIdentification314


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt018001.PartyIdentification257Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt018001.PartyIdentificationAndAccount195


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt018001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt018001.SecuritiesAccount19||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt018001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt018001.PendingProcessingReason15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt018001.PendingProcessingReason17Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt018001.PendingProcessingReason17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt018001.PendingProcessingReason4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRSY|Int32||XmlEnum("""PRSY""")|1|
||PREA|Int32||XmlEnum("""PREA""")|2|
||INBC|Int32||XmlEnum("""INBC""")|3|
||CDAC|Int32||XmlEnum("""CDAC""")|4|
||CDLR|Int32||XmlEnum("""CDLR""")|5|
||CDEL|Int32||XmlEnum("""CDEL""")|6|
||CVAL|Int32||XmlEnum("""CVAL""")|7|
||CSDH|Int32||XmlEnum("""CSDH""")|8|
||CERT|Int32||XmlEnum("""CERT""")|9|
||LIQU|Int32||XmlEnum("""LIQU""")|10|
||DENO|Int32||XmlEnum("""DENO""")|11|
||OTHR|Int32||XmlEnum("""OTHR""")|12|
||MINO|Int32||XmlEnum("""MINO""")|13|
||MONY|Int32||XmlEnum("""MONY""")|14|
||LALO|Int32||XmlEnum("""LALO""")|15|
||LACK|Int32||XmlEnum("""LACK""")|16|
||NEXT|Int32||XmlEnum("""NEXT""")|17|
||FLIM|Int32||XmlEnum("""FLIM""")|18|
||COLL|Int32||XmlEnum("""COLL""")|19|
||YCOL|Int32||XmlEnum("""YCOL""")|20|
||GLOB|Int32||XmlEnum("""GLOB""")|21|
||MUNO|Int32||XmlEnum("""MUNO""")|22|
||BLOC|Int32||XmlEnum("""BLOC""")|23|
||NOFX|Int32||XmlEnum("""NOFX""")|24|
||DOCY|Int32||XmlEnum("""DOCY""")|25|
||CAIS|Int32||XmlEnum("""CAIS""")|26|
||ADEA|Int32||XmlEnum("""ADEA""")|27|

---

## Value ISO20022.Semt018001.PendingProcessingStatus18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt018001.PendingProcessingReason15>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt018001.PendingReason16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt018001.PendingReason28Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Enum ISO20022.Semt018001.PendingReason24Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PATD|Int32||XmlEnum("""PATD""")|1|
||PREL|Int32||XmlEnum("""PREL""")|2|
||INBC|Int32||XmlEnum("""INBC""")|3|
||CDLR|Int32||XmlEnum("""CDLR""")|4|
||CVAL|Int32||XmlEnum("""CVAL""")|5|
||CSDH|Int32||XmlEnum("""CSDH""")|6|
||PRSY|Int32||XmlEnum("""PRSY""")|7|
||CERT|Int32||XmlEnum("""CERT""")|8|
||SETS|Int32||XmlEnum("""SETS""")|9|
||REGT|Int32||XmlEnum("""REGT""")|10|
||PRCY|Int32||XmlEnum("""PRCY""")|11|
||LIQU|Int32||XmlEnum("""LIQU""")|12|
||LATE|Int32||XmlEnum("""LATE""")|13|
||LAAW|Int32||XmlEnum("""LAAW""")|14|
||FROZ|Int32||XmlEnum("""FROZ""")|15|
||DKNY|Int32||XmlEnum("""DKNY""")|16|
||DISA|Int32||XmlEnum("""DISA""")|17|
||DENO|Int32||XmlEnum("""DENO""")|18|
||CLHT|Int32||XmlEnum("""CLHT""")|19|
||BOTH|Int32||XmlEnum("""BOTH""")|20|
||BENO|Int32||XmlEnum("""BENO""")|21|
||PHCK|Int32||XmlEnum("""PHCK""")|22|
||OTHR|Int32||XmlEnum("""OTHR""")|23|
||IAAD|Int32||XmlEnum("""IAAD""")|24|
||MINO|Int32||XmlEnum("""MINO""")|25|
||CPEC|Int32||XmlEnum("""CPEC""")|26|
||SBLO|Int32||XmlEnum("""SBLO""")|27|
||BATC|Int32||XmlEnum("""BATC""")|28|
||SDUT|Int32||XmlEnum("""SDUT""")|29|
||REFS|Int32||XmlEnum("""REFS""")|30|
||NCON|Int32||XmlEnum("""NCON""")|31|
||MONY|Int32||XmlEnum("""MONY""")|32|
||LALO|Int32||XmlEnum("""LALO""")|33|
||LACK|Int32||XmlEnum("""LACK""")|34|
||FUTU|Int32||XmlEnum("""FUTU""")|35|
||LINK|Int32||XmlEnum("""LINK""")|36|
||INCA|Int32||XmlEnum("""INCA""")|37|
||FLIM|Int32||XmlEnum("""FLIM""")|38|
||DEPO|Int32||XmlEnum("""DEPO""")|39|
||COLL|Int32||XmlEnum("""COLL""")|40|
||YCOL|Int32||XmlEnum("""YCOL""")|41|
||CMON|Int32||XmlEnum("""CMON""")|42|
||NOFX|Int32||XmlEnum("""NOFX""")|43|
||NMAS|Int32||XmlEnum("""NMAS""")|44|
||PART|Int32||XmlEnum("""PART""")|45|
||PREA|Int32||XmlEnum("""PREA""")|46|
||GLOB|Int32||XmlEnum("""GLOB""")|47|
||MUNO|Int32||XmlEnum("""MUNO""")|48|
||CLAC|Int32||XmlEnum("""CLAC""")|49|
||NEWI|Int32||XmlEnum("""NEWI""")|50|
||CHAS|Int32||XmlEnum("""CHAS""")|51|
||BLOC|Int32||XmlEnum("""BLOC""")|52|
||DOCC|Int32||XmlEnum("""DOCC""")|53|
||DOCY|Int32||XmlEnum("""DOCY""")|54|
||TAMM|Int32||XmlEnum("""TAMM""")|55|
||PHSE|Int32||XmlEnum("""PHSE""")|56|
||AWSH|Int32||XmlEnum("""AWSH""")|57|
||REFU|Int32||XmlEnum("""REFU""")|58|
||CAIS|Int32||XmlEnum("""CAIS""")|59|
||ADEA|Int32||XmlEnum("""ADEA""")|60|
||AWMO|Int32||XmlEnum("""AWMO""")|61|

---

## Value ISO20022.Semt018001.PendingReason28Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.PendingReason30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt018001.PendingReason63Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt018001.PendingReason63Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt018001.PendingReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDRE|Int32||XmlEnum("""CDRE""")|1|
||CDCY|Int32||XmlEnum("""CDCY""")|2|
||CDRG|Int32||XmlEnum("""CDRG""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||CONF|Int32||XmlEnum("""CONF""")|5|
||ADEA|Int32||XmlEnum("""ADEA""")|6|

---

## Value ISO20022.Semt018001.PendingStatus38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt018001.PendingReason16>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt018001.PendingStatus67Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt018001.PendingReason30>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt018001.PlaceOfClearingIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt018001.PlaceOfTradeIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|MktTpAndId|ISO20022.Semt018001.MarketIdentification84||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(MktTpAndId))|

---

## Value ISO20022.Semt018001.PostalAddress1


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

## Value ISO20022.Semt018001.ProprietaryReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Semt018001.ProprietaryStatusAndReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Semt018001.ProprietaryReason4>||XmlElement()||
|+|PrtrySts|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Semt018001.Quantity51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Semt018001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Semt018001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Enum ISO20022.Semt018001.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Semt018001.Registration10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt018001.Registration1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YREG|Int32||XmlEnum("""YREG""")|1|
||NREG|Int32||XmlEnum("""NREG""")|2|

---

## Enum ISO20022.Semt018001.Registration2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CVAL|Int32||XmlEnum("""CVAL""")|1|
||CDEL|Int32||XmlEnum("""CDEL""")|2|
||CSDH|Int32||XmlEnum("""CSDH""")|3|
||PTYH|Int32||XmlEnum("""PTYH""")|4|

---

## Value ISO20022.Semt018001.Registration9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.RegistrationReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Cd|ISO20022.Semt018001.Registration10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt018001.RepairReason10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt018001.RepairReason4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ICUS|Int32||XmlEnum("""ICUS""")|1|
||DEPT|Int32||XmlEnum("""DEPT""")|2|
||ICAG|Int32||XmlEnum("""ICAG""")|3|
||IEXE|Int32||XmlEnum("""IEXE""")|4|
||OTHR|Int32||XmlEnum("""OTHR""")|5|
||SDUT|Int32||XmlEnum("""SDUT""")|6|
||INPS|Int32||XmlEnum("""INPS""")|7|
||TXST|Int32||XmlEnum("""TXST""")|8|
||SETS|Int32||XmlEnum("""SETS""")|9|
||SETR|Int32||XmlEnum("""SETR""")|10|
||SAFE|Int32||XmlEnum("""SAFE""")|11|
||RTGS|Int32||XmlEnum("""RTGS""")|12|
||REFE|Int32||XmlEnum("""REFE""")|13|
||PLCE|Int32||XmlEnum("""PLCE""")|14|
||PHYS|Int32||XmlEnum("""PHYS""")|15|
||NCRR|Int32||XmlEnum("""NCRR""")|16|
||MUNO|Int32||XmlEnum("""MUNO""")|17|
||MINO|Int32||XmlEnum("""MINO""")|18|
||IIND|Int32||XmlEnum("""IIND""")|19|
||DTRD|Int32||XmlEnum("""DTRD""")|20|
||DSEC|Int32||XmlEnum("""DSEC""")|21|
||DQUA|Int32||XmlEnum("""DQUA""")|22|
||DMON|Int32||XmlEnum("""DMON""")|23|
||DDEA|Int32||XmlEnum("""DDEA""")|24|
||DDAT|Int32||XmlEnum("""DDAT""")|25|
||CASY|Int32||XmlEnum("""CASY""")|26|
||CASH|Int32||XmlEnum("""CASH""")|27|
||CAEV|Int32||XmlEnum("""CAEV""")|28|
||BATC|Int32||XmlEnum("""BATC""")|29|

---

## Value ISO20022.Semt018001.RepairReason8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt018001.RepairReason10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt018001.RepairStatus12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt018001.RepairReason8>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt018001.RepurchaseType22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt018001.RepurchaseType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WTHD|Int32||XmlEnum("""WTHD""")|1|
||TOPU|Int32||XmlEnum("""TOPU""")|2|
||CADJ|Int32||XmlEnum("""CADJ""")|3|
||ROLP|Int32||XmlEnum("""ROLP""")|4|
||CALL|Int32||XmlEnum("""CALL""")|5|
||RATE|Int32||XmlEnum("""RATE""")|6|
||PADJ|Int32||XmlEnum("""PADJ""")|7|
||PAIR|Int32||XmlEnum("""PAIR""")|8|

---

## Value ISO20022.Semt018001.Restriction5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.SafeKeepingPlace5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Semt018001.SafekeepingPlaceFormat41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Semt018001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Semt018001.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Semt018001.SafekeepingPlaceFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Semt018001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Semt018001.SafekeepingPlaceTypeAndText8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Semt018001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt018001.SafekeepingPlaceTypeAndText8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt018001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt018001.SecuritiesRTGS4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Aspect ISO20022.Semt018001.SecuritiesTransactionPendingReportV14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txs|global::System.Collections.Generic.List<ISO20022.Semt018001.Transaction163>||XmlElement()||
|+|Sts|global::System.Collections.Generic.List<ISO20022.Semt018001.StatusAndReason47>||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt018001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt018001.SecuritiesAccount19||XmlElement()||
|+|AcctOwnr|ISO20022.Semt018001.PartyIdentification144||XmlElement()||
|+|StmtGnlDtls|ISO20022.Semt018001.Statement64||XmlElement()||
|+|Pgntn|ISO20022.Semt018001.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Txs""",Txs),validElement(Txs),validList("""Sts""",Sts),validElement(Sts),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(StmtGnlDtls),validElement(Pgntn))|

---

## Enum ISO20022.Semt018001.SecuritiesTransactionType26Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REBL|Int32||XmlEnum("""REBL""")|1|
||REDI|Int32||XmlEnum("""REDI""")|2|
||SBBK|Int32||XmlEnum("""SBBK""")|3|
||INSP|Int32||XmlEnum("""INSP""")|4|
||SLRE|Int32||XmlEnum("""SLRE""")|5|
||ISSU|Int32||XmlEnum("""ISSU""")|6|
||ETFT|Int32||XmlEnum("""ETFT""")|7|
||CONV|Int32||XmlEnum("""CONV""")|8|
||SWIT|Int32||XmlEnum("""SWIT""")|9|
||SWIF|Int32||XmlEnum("""SWIF""")|10|
||AUTO|Int32||XmlEnum("""AUTO""")|11|
||CLAI|Int32||XmlEnum("""CLAI""")|12|
||CORP|Int32||XmlEnum("""CORP""")|13|
||SBRE|Int32||XmlEnum("""SBRE""")|14|
||RELE|Int32||XmlEnum("""RELE""")|15|
||OWNI|Int32||XmlEnum("""OWNI""")|16|
||FCTA|Int32||XmlEnum("""FCTA""")|17|
||OWNE|Int32||XmlEnum("""OWNE""")|18|
||CNCB|Int32||XmlEnum("""CNCB""")|19|
||BYIY|Int32||XmlEnum("""BYIY""")|20|
||TURN|Int32||XmlEnum("""TURN""")|21|
||TRVO|Int32||XmlEnum("""TRVO""")|22|
||TRPO|Int32||XmlEnum("""TRPO""")|23|
||TRAD|Int32||XmlEnum("""TRAD""")|24|
||TBAC|Int32||XmlEnum("""TBAC""")|25|
||SYND|Int32||XmlEnum("""SYND""")|26|
||SUBS|Int32||XmlEnum("""SUBS""")|27|
||SECL|Int32||XmlEnum("""SECL""")|28|
||SECB|Int32||XmlEnum("""SECB""")|29|
||RVPO|Int32||XmlEnum("""RVPO""")|30|
||RODE|Int32||XmlEnum("""RODE""")|31|
||REPU|Int32||XmlEnum("""REPU""")|32|
||REDM|Int32||XmlEnum("""REDM""")|33|
||REAL|Int32||XmlEnum("""REAL""")|34|
||PORT|Int32||XmlEnum("""PORT""")|35|
||PLAC|Int32||XmlEnum("""PLAC""")|36|
||PAIR|Int32||XmlEnum("""PAIR""")|37|
||NSYN|Int32||XmlEnum("""NSYN""")|38|
||NETT|Int32||XmlEnum("""NETT""")|39|
||MKUP|Int32||XmlEnum("""MKUP""")|40|
||MKDW|Int32||XmlEnum("""MKDW""")|41|
||COLO|Int32||XmlEnum("""COLO""")|42|
||COLI|Int32||XmlEnum("""COLI""")|43|
||BSBK|Int32||XmlEnum("""BSBK""")|44|

---

## Value ISO20022.Semt018001.SecuritiesTransactionType44Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Semt018001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Semt018001.SettlementDate19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Semt018001.SettlementDateCode8Choice||XmlElement()||
|+|Dt|ISO20022.Semt018001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Semt018001.SettlementDateCode8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.SettlementDetails184


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtlSttlmInd|String||XmlElement()||
|+|LttrOfGrnt|ISO20022.Semt018001.LetterOfGuarantee4Choice||XmlElement()||
|+|CCPElgblty|ISO20022.Semt018001.CentralCounterPartyEligibility4Choice||XmlElement()||
|+|NetgElgblty|ISO20022.Semt018001.NettingEligibility4Choice||XmlElement()||
|+|SttlmSysMtd|ISO20022.Semt018001.SettlementSystemMethod4Choice||XmlElement()||
|+|LglRstrctns|ISO20022.Semt018001.Restriction5Choice||XmlElement()||
|+|BlckTrad|ISO20022.Semt018001.BlockTrade4Choice||XmlElement()||
|+|MktClntSd|ISO20022.Semt018001.MarketClientSide6Choice||XmlElement()||
|+|RpTp|ISO20022.Semt018001.RepurchaseType22Choice||XmlElement()||
|+|TaxCpcty|ISO20022.Semt018001.TaxCapacityParty4Choice||XmlElement()||
|+|CshClrSys|ISO20022.Semt018001.CashSettlementSystem4Choice||XmlElement()||
|+|BnfclOwnrsh|ISO20022.Semt018001.BeneficialOwnership4Choice||XmlElement()||
|+|Regn|ISO20022.Semt018001.Registration9Choice||XmlElement()||
|+|SctiesRTGS|ISO20022.Semt018001.SecuritiesRTGS4Choice||XmlElement()||
|+|StmpDtyTaxBsis|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|SttlgCpcty|ISO20022.Semt018001.SettlingCapacity7Choice||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Semt018001.SettlementTransactionCondition34Choice>||XmlElement()||
|+|HldInd|ISO20022.Semt018001.HoldIndicator6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LttrOfGrnt),validElement(CCPElgblty),validElement(NetgElgblty),validElement(SttlmSysMtd),validElement(LglRstrctns),validElement(BlckTrad),validElement(MktClntSd),validElement(RpTp),validElement(TaxCpcty),validElement(CshClrSys),validElement(BnfclOwnrsh),validElement(Regn),validElement(SctiesRTGS),validElement(StmpDtyTaxBsis),validElement(SttlgCpcty),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validElement(HldInd))|

---

## Value ISO20022.Semt018001.SettlementOrCorporateActionEvent34Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnEvtTp|ISO20022.Semt018001.CorporateActionEventType110Choice||XmlElement()||
|+|SctiesTxTp|ISO20022.Semt018001.SecuritiesTransactionType44Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnEvtTp),validElement(SctiesTxTp),validChoice(CorpActnEvtTp,SctiesTxTp))|

---

## Value ISO20022.Semt018001.SettlementParties125


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Semt018001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty4|ISO20022.Semt018001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty3|ISO20022.Semt018001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty2|ISO20022.Semt018001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty1|ISO20022.Semt018001.PartyIdentificationAndAccount195||XmlElement()||
|+|Dpstry|ISO20022.Semt018001.PartyIdentification314||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Value ISO20022.Semt018001.SettlementStatus30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.ProprietaryStatusAndReason6||XmlElement()||
|+|Flng|ISO20022.Semt018001.FailingStatus13Choice||XmlElement()||
|+|Pdg|ISO20022.Semt018001.PendingStatus67Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Flng),validElement(Pdg),validChoice(Prtry,Flng,Pdg))|

---

## Enum ISO20022.Semt018001.SettlementSystemMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSET|Int32||XmlEnum("""YSET""")|1|
||NSET|Int32||XmlEnum("""NSET""")|2|

---

## Value ISO20022.Semt018001.SettlementSystemMethod4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt018001.SettlementTransactionCondition12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BPSS|Int32||XmlEnum("""BPSS""")|1|
||INTS|Int32||XmlEnum("""INTS""")|2|
||UNEX|Int32||XmlEnum("""UNEX""")|3|
||TRIP|Int32||XmlEnum("""TRIP""")|4|
||TRAN|Int32||XmlEnum("""TRAN""")|5|
||SPST|Int32||XmlEnum("""SPST""")|6|
||SPDL|Int32||XmlEnum("""SPDL""")|7|
||SHOR|Int32||XmlEnum("""SHOR""")|8|
||RESI|Int32||XmlEnum("""RESI""")|9|
||RPTO|Int32||XmlEnum("""RPTO""")|10|
||RHYP|Int32||XmlEnum("""RHYP""")|11|
||PHYS|Int32||XmlEnum("""PHYS""")|12|
||PENS|Int32||XmlEnum("""PENS""")|13|
||NACT|Int32||XmlEnum("""NACT""")|14|
||NOMC|Int32||XmlEnum("""NOMC""")|15|
||KNOC|Int32||XmlEnum("""KNOC""")|16|
||FRCL|Int32||XmlEnum("""FRCL""")|17|
||EXPI|Int32||XmlEnum("""EXPI""")|18|
||EXER|Int32||XmlEnum("""EXER""")|19|
||DRAW|Int32||XmlEnum("""DRAW""")|20|
||DIRT|Int32||XmlEnum("""DIRT""")|21|
||DLWM|Int32||XmlEnum("""DLWM""")|22|
||CLEN|Int32||XmlEnum("""CLEN""")|23|
||BUTC|Int32||XmlEnum("""BUTC""")|24|
||ASGN|Int32||XmlEnum("""ASGN""")|25|
||ADEA|Int32||XmlEnum("""ADEA""")|26|

---

## Value ISO20022.Semt018001.SettlementTransactionCondition34Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt018001.SettlementTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARQ|Int32||XmlEnum("""PARQ""")|1|
||PARC|Int32||XmlEnum("""PARC""")|2|
||NPAR|Int32||XmlEnum("""NPAR""")|3|
||PART|Int32||XmlEnum("""PART""")|4|

---

## Enum ISO20022.Semt018001.SettlingCapacity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RISP|Int32||XmlEnum("""RISP""")|1|
||SPRI|Int32||XmlEnum("""SPRI""")|2|
||CUST|Int32||XmlEnum("""CUST""")|3|
||SAGE|Int32||XmlEnum("""SAGE""")|4|

---

## Value ISO20022.Semt018001.SettlingCapacity7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.Statement64


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ActvtyInd|String||XmlElement()||
|+|StmtStr|String||XmlElement()||
|+|UpdTp|ISO20022.Semt018001.UpdateType15Choice||XmlElement()||
|+|Frqcy|ISO20022.Semt018001.Frequency25Choice||XmlElement()||
|+|StmtDtTm|ISO20022.Semt018001.DateAndDateTime2Choice||XmlElement()||
|+|StmtId|String||XmlElement()||
|+|QryRef|String||XmlElement()||
|+|RptNb|ISO20022.Semt018001.Number3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UpdTp),validElement(Frqcy),validElement(StmtDtTm),validElement(RptNb))|

---

## Enum ISO20022.Semt018001.StatementStructure1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAN|Int32||XmlEnum("""TRAN""")|1|
||STAT|Int32||XmlEnum("""STAT""")|2|

---

## Enum ISO20022.Semt018001.StatementUpdateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Semt018001.Status38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrPrcgSts|ISO20022.Semt018001.InstructionProcessingStatus42Choice||XmlElement()||
|+|SttlmSts|ISO20022.Semt018001.SettlementStatus30Choice||XmlElement()||
|+|IfrrdMtchgSts|ISO20022.Semt018001.MatchingStatus24Choice||XmlElement()||
|+|MtchgSts|ISO20022.Semt018001.MatchingStatus24Choice||XmlElement()||
|+|Prtry|ISO20022.Semt018001.ProprietaryStatusAndReason6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstrPrcgSts),validElement(SttlmSts),validElement(IfrrdMtchgSts),validElement(MtchgSts),validElement(Prtry),validChoice(InstrPrcgSts,SttlmSts,IfrrdMtchgSts,MtchgSts,Prtry))|

---

## Value ISO20022.Semt018001.StatusAndReason47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|global::System.Collections.Generic.List<ISO20022.Semt018001.Transaction162>||XmlElement()||
|+|StsAndRsn|ISO20022.Semt018001.Status38Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Tx""",Tx),validElement(Tx),validElement(StsAndRsn))|

---

## Value ISO20022.Semt018001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Semt018001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Semt018001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt018001.TaxCapacityParty4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt018001.TaxLiability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGEN|Int32||XmlEnum("""AGEN""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Semt018001.TradeDate8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Semt018001.TradeDateCode3Choice||XmlElement()||
|+|Dt|ISO20022.Semt018001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Semt018001.TradeDateCode3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.Transaction162


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxDtls|ISO20022.Semt018001.TransactionDetails170||XmlElement()||
|+|TrptyAgtSvcPrvdrCollInstrId|String||XmlElement()||
|+|ClntCollInstrId|String||XmlElement()||
|+|ClntTrptyCollTxId|String||XmlElement()||
|+|TrptyAgtSvcPrvdrCollTxId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
|+|CmonId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
|+|TradId|String||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|CtrPtyMktInfrstrctrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TxDtls),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""))|

---

## Value ISO20022.Semt018001.Transaction163


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StsAndRsn|global::System.Collections.Generic.List<ISO20022.Semt018001.Status38Choice>||XmlElement()||
|+|TxDtls|ISO20022.Semt018001.TransactionDetails170||XmlElement()||
|+|TrptyAgtSvcPrvdrCollInstrId|String||XmlElement()||
|+|ClntCollInstrId|String||XmlElement()||
|+|ClntTrptyCollTxId|String||XmlElement()||
|+|TrptyAgtSvcPrvdrCollTxId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
|+|CmonId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
|+|TradId|String||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|CtrPtyMktInfrstrctrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""StsAndRsn""",StsAndRsn),validElement(StsAndRsn),validElement(TxDtls),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""))|

---

## Enum ISO20022.Semt018001.TransactionActivity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SETT|Int32||XmlEnum("""SETT""")|1|
||CORP|Int32||XmlEnum("""CORP""")|2|
||COLL|Int32||XmlEnum("""COLL""")|3|
||CLAI|Int32||XmlEnum("""CLAI""")|4|
||BOLE|Int32||XmlEnum("""BOLE""")|5|

---

## Value ISO20022.Semt018001.TransactionActivity3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.TransactionDetails170


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt018001.SupplementaryData1>||XmlElement()||
|+|TxAddtlDtls|String||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Semt018001.SettlementParties125||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Semt018001.SettlementParties125||XmlElement()||
|+|MtchdStsTmStmp|DateTime||XmlElement()||
|+|AckdStsTmStmp|DateTime||XmlElement()||
|+|XpctdValDt|ISO20022.Semt018001.DateAndDateTime2Choice||XmlElement()||
|+|LateDlvryDt|ISO20022.Semt018001.DateAndDateTime2Choice||XmlElement()||
|+|SttlmDt|ISO20022.Semt018001.SettlementDate19Choice||XmlElement()||
|+|XpctdSttlmDt|ISO20022.Semt018001.DateAndDateTime2Choice||XmlElement()||
|+|TradDt|ISO20022.Semt018001.TradeDate8Choice||XmlElement()||
|+|PstngAmt|ISO20022.Semt018001.AmountAndDirection51||XmlElement()||
|+|PrtlyRlsdQty|ISO20022.Semt018001.Quantity51Choice||XmlElement()||
|+|PstngQty|ISO20022.Semt018001.Quantity51Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Semt018001.SecurityIdentification19||XmlElement()||
|+|PlcOfClr|ISO20022.Semt018001.PlaceOfClearingIdentification2||XmlElement()||
|+|SfkpgPlc|ISO20022.Semt018001.SafeKeepingPlace5||XmlElement()||
|+|PlcOfTrad|ISO20022.Semt018001.PlaceOfTradeIdentification1||XmlElement()||
|+|SttlmParams|ISO20022.Semt018001.SettlementDetails184||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
|+|SttlmTxOrCorpActnEvtTp|ISO20022.Semt018001.SettlementOrCorporateActionEvent34Choice||XmlElement()||
|+|TxActvty|ISO20022.Semt018001.TransactionActivity3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(XpctdValDt),validElement(LateDlvryDt),validElement(SttlmDt),validElement(XpctdSttlmDt),validElement(TradDt),validElement(PstngAmt),validElement(PrtlyRlsdQty),validElement(PstngQty),validElement(FinInstrmId),validElement(PlcOfClr),validElement(SfkpgPlc),validElement(PlcOfTrad),validElement(SttlmParams),validElement(SttlmTxOrCorpActnEvtTp),validElement(TxActvty))|

---

## Enum ISO20022.Semt018001.UnmatchedReason11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNBR|Int32||XmlEnum("""UNBR""")|1|
||DELN|Int32||XmlEnum("""DELN""")|2|
||DTRD|Int32||XmlEnum("""DTRD""")|3|
||TXST|Int32||XmlEnum("""TXST""")|4|
||SETR|Int32||XmlEnum("""SETR""")|5|
||SETS|Int32||XmlEnum("""SETS""")|6|
||DDAT|Int32||XmlEnum("""DDAT""")|7|
||DMON|Int32||XmlEnum("""DMON""")|8|
||SAFE|Int32||XmlEnum("""SAFE""")|9|
||RTGS|Int32||XmlEnum("""RTGS""")|10|
||REGD|Int32||XmlEnum("""REGD""")|11|
||IEXE|Int32||XmlEnum("""IEXE""")|12|
||ICUS|Int32||XmlEnum("""ICUS""")|13|
||ICAG|Int32||XmlEnum("""ICAG""")|14|
||DEPT|Int32||XmlEnum("""DEPT""")|15|
||PODU|Int32||XmlEnum("""PODU""")|16|
||PLCE|Int32||XmlEnum("""PLCE""")|17|
||INPS|Int32||XmlEnum("""INPS""")|18|
||PLIS|Int32||XmlEnum("""PLIS""")|19|
||PHYS|Int32||XmlEnum("""PHYS""")|20|
||FRAP|Int32||XmlEnum("""FRAP""")|21|
||OTHR|Int32||XmlEnum("""OTHR""")|22|
||DTRA|Int32||XmlEnum("""DTRA""")|23|
||NMAS|Int32||XmlEnum("""NMAS""")|24|
||CMIS|Int32||XmlEnum("""CMIS""")|25|
||MIME|Int32||XmlEnum("""MIME""")|26|
||LATE|Int32||XmlEnum("""LATE""")|27|
||LEOG|Int32||XmlEnum("""LEOG""")|28|
||INVE|Int32||XmlEnum("""INVE""")|29|
||DQUA|Int32||XmlEnum("""DQUA""")|30|
||DSEC|Int32||XmlEnum("""DSEC""")|31|
||DCMX|Int32||XmlEnum("""DCMX""")|32|
||DMCT|Int32||XmlEnum("""DMCT""")|33|
||DDEA|Int32||XmlEnum("""DDEA""")|34|
||NCRR|Int32||XmlEnum("""NCRR""")|35|
||CLAT|Int32||XmlEnum("""CLAT""")|36|
||CPCA|Int32||XmlEnum("""CPCA""")|37|
||IIND|Int32||XmlEnum("""IIND""")|38|
||ACRU|Int32||XmlEnum("""ACRU""")|39|
||ADEA|Int32||XmlEnum("""ADEA""")|40|

---

## Value ISO20022.Semt018001.UnmatchedReason15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt018001.UnmatchedReason21Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt018001.UnmatchedReason21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt018001.UnmatchedStatus16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt018001.UnmatchedReason15>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt018001.UpdateType15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt018001.GenericIdentification30||XmlElement()||
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

