# sese.024.002.12
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese024002.AcknowledgedAcceptedStatus25Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese024002.AcknowledgementReason13~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese024002.AcknowledgedAcceptedStatus25Choice *-- ISO20022.Sese024002.AcknowledgementReason13
    class ISO20022.Sese024002.AcknowledgementReason13 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese024002.AcknowledgementReason16Choice
    }
    ISO20022.Sese024002.AcknowledgementReason13 *-- ISO20022.Sese024002.AcknowledgementReason16Choice
    class ISO20022.Sese024002.AcknowledgementReason16Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.AcknowledgementReason16Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.AcknowledgementReason5Code {
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
    class ISO20022.Sese024002.AmountAndDirection67 {
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese024002.RestrictedFINActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese024002.RestrictedFINActiveCurrencyAndAmount
    }
    ISO20022.Sese024002.AmountAndDirection67 *-- ISO20022.Sese024002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese024002.AmountAndDirection67 *-- ISO20022.Sese024002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese024002.BeneficialOwnership5Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese024002.BeneficialOwnership5Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Sese024002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese024002.BlockChainAddressWallet7 *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.BlockTrade1Code {
        BLCH = 1
        BLPA = 2
    }
    class ISO20022.Sese024002.BlockTrade5Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.BlockTrade5Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.CancellationReason24 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese024002.CancellationReason37Choice
    }
    ISO20022.Sese024002.CancellationReason24 *-- ISO20022.Sese024002.CancellationReason37Choice
    class ISO20022.Sese024002.CancellationReason37Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.CancellationReason37Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.CancellationStatus25Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese024002.CancellationReason24~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese024002.CancellationStatus25Choice *-- ISO20022.Sese024002.CancellationReason24
    class ISO20022.Sese024002.CancelledStatusReason16Code {
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
    class ISO20022.Sese024002.CashSettlementSystem2Code {
        NETS = 1
        GROS = 2
    }
    class ISO20022.Sese024002.CashSettlementSystem5Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.CashSettlementSystem5Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.CentralCounterPartyEligibility5Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese024002.CentralCounterPartyEligibility5Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese024002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese024002.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese024002.DateType4Code {
        UKWN = 1
        OPEN = 2
    }
    class ISO20022.Sese024002.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese024002.ExposureType12Code {
        TRCP = 1
        UDMS = 2
        TBAS = 3
        SWPT = 4
        SCIE = 5
        SCIR = 6
        SHSL = 7
        SLEB = 8
        SCRP = 9
        SBSC = 10
        SLOA = 11
        RVPO = 12
        REPO = 13
        OTCD = 14
        LIQU = 15
        OPTN = 16
        FUTR = 17
        FORW = 18
        FORX = 19
        FIXI = 20
        EXPT = 21
        EQUS = 22
        EXTD = 23
        EQPT = 24
        CRPR = 25
        CCIR = 26
        CRSP = 27
        CRTL = 28
        CRDS = 29
        COMM = 30
        CCPC = 31
        PAYM = 32
        BFWD = 33
    }
    class ISO20022.Sese024002.ExposureType24Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.ExposureType24Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.FailingReason12 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese024002.FailingReason17Choice
    }
    ISO20022.Sese024002.FailingReason12 *-- ISO20022.Sese024002.FailingReason17Choice
    class ISO20022.Sese024002.FailingReason17Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.FailingReason17Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.FailingReason4Code {
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
    class ISO20022.Sese024002.FailingStatus14Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese024002.FailingReason12~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese024002.FailingStatus14Choice *-- ISO20022.Sese024002.FailingReason12
    class ISO20022.Sese024002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese024002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese024002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese024002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Sese024002.GenericIdentification47
    }
    ISO20022.Sese024002.GenericIdentification85 *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.HoldIndicator7 {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese024002.RegistrationReason6~
        + Ind  : String
    }
    ISO20022.Sese024002.HoldIndicator7 *-- ISO20022.Sese024002.RegistrationReason6
    class ISO20022.Sese024002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese024002.LetterOfGuarantee5Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese024002.LetterOfGuarantee5Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.Linkages50 {
        + SctiesSttlmTxId  : String
        + PrcgPos  : ISO20022.Sese024002.ProcessingPosition23Choice
    }
    ISO20022.Sese024002.Linkages50 *-- ISO20022.Sese024002.ProcessingPosition23Choice
    class ISO20022.Sese024002.MarketClientSide1Code {
        MAKT = 1
        CLNT = 2
    }
    class ISO20022.Sese024002.MarketClientSide7Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.MarketClientSide7Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.MarketIdentification2Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese024002.MarketIdentification90 {
        + Tp  : ISO20022.Sese024002.MarketType16Choice
        + Id  : ISO20022.Sese024002.MarketIdentification2Choice
    }
    ISO20022.Sese024002.MarketIdentification90 *-- ISO20022.Sese024002.MarketType16Choice
    ISO20022.Sese024002.MarketIdentification90 *-- ISO20022.Sese024002.MarketIdentification2Choice
    class ISO20022.Sese024002.MarketType16Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.MarketType16Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Sese024002.MatchingStatus32Choice {
        + Prtry  : ISO20022.Sese024002.ProprietaryStatusAndReason7
        + Umtchd  : ISO20022.Sese024002.UnmatchedStatus21Choice
        + Mtchd  : ISO20022.Sese024002.ProprietaryReason5
    }
    ISO20022.Sese024002.MatchingStatus32Choice *-- ISO20022.Sese024002.ProprietaryStatusAndReason7
    ISO20022.Sese024002.MatchingStatus32Choice *-- ISO20022.Sese024002.UnmatchedStatus21Choice
    ISO20022.Sese024002.MatchingStatus32Choice *-- ISO20022.Sese024002.ProprietaryReason5
    class ISO20022.Sese024002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Sese024002.NettingEligibility5Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese024002.NettingEligibility5Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Sese024002.OriginalAndCurrentQuantities4 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Sese024002.OtherIdentification2 {
        + Tp  : ISO20022.Sese024002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese024002.OtherIdentification2 *-- ISO20022.Sese024002.IdentificationSource4Choice
    class ISO20022.Sese024002.OwnershipLegalRestrictions1Code {
        RSTR = 1
        NRST = 2
        A144 = 3
    }
    class ISO20022.Sese024002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Sese024002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese024002.PartyIdentification136Choice *-- ISO20022.Sese024002.GenericIdentification84
    class ISO20022.Sese024002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Sese024002.NameAndAddress12
        + PrtryId  : ISO20022.Sese024002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese024002.PartyIdentification137Choice *-- ISO20022.Sese024002.NameAndAddress12
    ISO20022.Sese024002.PartyIdentification137Choice *-- ISO20022.Sese024002.GenericIdentification84
    class ISO20022.Sese024002.PartyIdentification145Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese024002.NameAndAddress12
        + AnyBIC  : String
    }
    ISO20022.Sese024002.PartyIdentification145Choice *-- ISO20022.Sese024002.NameAndAddress12
    class ISO20022.Sese024002.PartyIdentification156 {
        + LEI  : String
        + Id  : ISO20022.Sese024002.PartyIdentification136Choice
    }
    ISO20022.Sese024002.PartyIdentification156 *-- ISO20022.Sese024002.PartyIdentification136Choice
    class ISO20022.Sese024002.PartyIdentification157 {
        + LEI  : String
        + Id  : ISO20022.Sese024002.PartyIdentification137Choice
    }
    ISO20022.Sese024002.PartyIdentification157 *-- ISO20022.Sese024002.PartyIdentification137Choice
    class ISO20022.Sese024002.PartyIdentification170 {
        + LEI  : String
        + Id  : ISO20022.Sese024002.PartyIdentification176Choice
    }
    ISO20022.Sese024002.PartyIdentification170 *-- ISO20022.Sese024002.PartyIdentification176Choice
    class ISO20022.Sese024002.PartyIdentification176Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese024002.NameAndAddress12
        + PrtryId  : ISO20022.Sese024002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese024002.PartyIdentification176Choice *-- ISO20022.Sese024002.NameAndAddress12
    ISO20022.Sese024002.PartyIdentification176Choice *-- ISO20022.Sese024002.GenericIdentification84
    class ISO20022.Sese024002.PartyIdentification191 {
        + PrcgId  : String
        + LEI  : String
        + Id  : ISO20022.Sese024002.PartyIdentification145Choice
    }
    ISO20022.Sese024002.PartyIdentification191 *-- ISO20022.Sese024002.PartyIdentification145Choice
    class ISO20022.Sese024002.PartyIdentificationAndAccount215 {
        + PrcgId  : String
        + BlckChainAdrOrWllt  : ISO20022.Sese024002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese024002.SecuritiesAccount30
        + LEI  : String
        + Id  : ISO20022.Sese024002.PartyIdentification137Choice
    }
    ISO20022.Sese024002.PartyIdentificationAndAccount215 *-- ISO20022.Sese024002.BlockChainAddressWallet7
    ISO20022.Sese024002.PartyIdentificationAndAccount215 *-- ISO20022.Sese024002.SecuritiesAccount30
    ISO20022.Sese024002.PartyIdentificationAndAccount215 *-- ISO20022.Sese024002.PartyIdentification137Choice
    class ISO20022.Sese024002.PendingProcessingReason16 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese024002.PendingProcessingReason18Choice
    }
    ISO20022.Sese024002.PendingProcessingReason16 *-- ISO20022.Sese024002.PendingProcessingReason18Choice
    class ISO20022.Sese024002.PendingProcessingReason18Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.PendingProcessingReason18Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.PendingProcessingReason4Code {
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
    class ISO20022.Sese024002.PendingProcessingStatus19Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese024002.PendingProcessingReason16~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese024002.PendingProcessingStatus19Choice *-- ISO20022.Sese024002.PendingProcessingReason16
    class ISO20022.Sese024002.PendingReason20 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese024002.PendingReason37Choice
    }
    ISO20022.Sese024002.PendingReason20 *-- ISO20022.Sese024002.PendingReason37Choice
    class ISO20022.Sese024002.PendingReason24Code {
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
    class ISO20022.Sese024002.PendingReason31 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese024002.PendingReason65Choice
    }
    ISO20022.Sese024002.PendingReason31 *-- ISO20022.Sese024002.PendingReason65Choice
    class ISO20022.Sese024002.PendingReason37Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.PendingReason37Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.PendingReason65Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.PendingReason65Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.PendingReason6Code {
        CDRE = 1
        CDCY = 2
        CDRG = 3
        OTHR = 4
        CONF = 5
        ADEA = 6
    }
    class ISO20022.Sese024002.PendingStatus46Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese024002.PendingReason20~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese024002.PendingStatus46Choice *-- ISO20022.Sese024002.PendingReason20
    class ISO20022.Sese024002.PendingStatus69Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese024002.PendingReason31~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese024002.PendingStatus69Choice *-- ISO20022.Sese024002.PendingReason31
    class ISO20022.Sese024002.PlaceOfClearingIdentification2 {
        + LEI  : String
        + Id  : String
    }
    class ISO20022.Sese024002.PlaceOfTradeIdentification2 {
        + LEI  : String
        + MktTpAndId  : ISO20022.Sese024002.MarketIdentification90
    }
    ISO20022.Sese024002.PlaceOfTradeIdentification2 *-- ISO20022.Sese024002.MarketIdentification90
    class ISO20022.Sese024002.ProcessingPosition23Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.ProcessingPosition23Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.ProcessingPosition5Code {
        INFO = 1
    }
    class ISO20022.Sese024002.ProcessingStatus94Choice {
        + ModReqd  : ISO20022.Sese024002.ProprietaryReason5
        + CxlReqd  : ISO20022.Sese024002.ProprietaryReason5
        + Prtry  : ISO20022.Sese024002.ProprietaryStatusAndReason7
        + PdgCxl  : ISO20022.Sese024002.PendingStatus46Choice
        + Canc  : ISO20022.Sese024002.CancellationStatus25Choice
        + Rpr  : ISO20022.Sese024002.RepairStatus16Choice
        + Rjctd  : ISO20022.Sese024002.RejectionStatus44Choice
        + PdgPrcg  : ISO20022.Sese024002.PendingProcessingStatus19Choice
        + AckdAccptd  : ISO20022.Sese024002.AcknowledgedAcceptedStatus25Choice
    }
    ISO20022.Sese024002.ProcessingStatus94Choice *-- ISO20022.Sese024002.ProprietaryReason5
    ISO20022.Sese024002.ProcessingStatus94Choice *-- ISO20022.Sese024002.ProprietaryReason5
    ISO20022.Sese024002.ProcessingStatus94Choice *-- ISO20022.Sese024002.ProprietaryStatusAndReason7
    ISO20022.Sese024002.ProcessingStatus94Choice *-- ISO20022.Sese024002.PendingStatus46Choice
    ISO20022.Sese024002.ProcessingStatus94Choice *-- ISO20022.Sese024002.CancellationStatus25Choice
    ISO20022.Sese024002.ProcessingStatus94Choice *-- ISO20022.Sese024002.RepairStatus16Choice
    ISO20022.Sese024002.ProcessingStatus94Choice *-- ISO20022.Sese024002.RejectionStatus44Choice
    ISO20022.Sese024002.ProcessingStatus94Choice *-- ISO20022.Sese024002.PendingProcessingStatus19Choice
    ISO20022.Sese024002.ProcessingStatus94Choice *-- ISO20022.Sese024002.AcknowledgedAcceptedStatus25Choice
    class ISO20022.Sese024002.ProprietaryReason5 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Sese024002.GenericIdentification47
    }
    ISO20022.Sese024002.ProprietaryReason5 *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.ProprietaryStatusAndReason7 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Sese024002.ProprietaryReason5~
        + PrtrySts  : ISO20022.Sese024002.GenericIdentification47
    }
    ISO20022.Sese024002.ProprietaryStatusAndReason7 *-- ISO20022.Sese024002.ProprietaryReason5
    ISO20022.Sese024002.ProprietaryStatusAndReason7 *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.Quantity54Choice {
        + OrgnlAndCurFace  : ISO20022.Sese024002.OriginalAndCurrentQuantities4
        + Qty  : ISO20022.Sese024002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Sese024002.Quantity54Choice *-- ISO20022.Sese024002.OriginalAndCurrentQuantities4
    ISO20022.Sese024002.Quantity54Choice *-- ISO20022.Sese024002.FinancialInstrumentQuantity36Choice
    class ISO20022.Sese024002.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese024002.Registration11Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.Registration11Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.Registration12Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.Registration12Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.Registration1Code {
        YREG = 1
        NREG = 2
    }
    class ISO20022.Sese024002.Registration2Code {
        CVAL = 1
        CDEL = 2
        CSDH = 3
        PTYH = 4
    }
    class ISO20022.Sese024002.RegistrationReason6 {
        + AddtlInf  : String
        + Cd  : ISO20022.Sese024002.Registration12Choice
    }
    ISO20022.Sese024002.RegistrationReason6 *-- ISO20022.Sese024002.Registration12Choice
    class ISO20022.Sese024002.RejectionReason50Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.RejectionReason50Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.RejectionReason65 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese024002.RejectionReason50Choice
    }
    ISO20022.Sese024002.RejectionReason65 *-- ISO20022.Sese024002.RejectionReason50Choice
    class ISO20022.Sese024002.RejectionReason75Code {
        PLIS = 1
        INVE = 2
        VALR = 3
        INVN = 4
        INVL = 5
        INVB = 6
        IEXE = 7
        DEPT = 8
        ICAG = 9
        ICUS = 10
        OTHR = 11
        INPS = 12
        SDUT = 13
        SETR = 14
        DDAT = 15
        CASY = 16
        CAEV = 17
        IIND = 18
        SETS = 19
        TXST = 20
        MUNO = 21
        BATC = 22
        MINO = 23
        DMON = 24
        REFE = 25
        PHYS = 26
        NCRR = 27
        RTGS = 28
        PLCE = 29
        DTRD = 30
        DDEA = 31
        CASH = 32
        LATE = 33
        DSEC = 34
        ADEA = 35
        DQUA = 36
        SAFE = 37
    }
    class ISO20022.Sese024002.RejectionStatus44Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese024002.RejectionReason65~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese024002.RejectionStatus44Choice *-- ISO20022.Sese024002.RejectionReason65
    class ISO20022.Sese024002.RepairReason12 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese024002.RepairReason14Choice
    }
    ISO20022.Sese024002.RepairReason12 *-- ISO20022.Sese024002.RepairReason14Choice
    class ISO20022.Sese024002.RepairReason14Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.RepairReason14Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.RepairReason4Code {
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
    class ISO20022.Sese024002.RepairStatus16Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese024002.RepairReason12~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese024002.RepairStatus16Choice *-- ISO20022.Sese024002.RepairReason12
    class ISO20022.Sese024002.RepurchaseType24Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.RepurchaseType24Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.RepurchaseType9Code {
        WTHD = 1
        TOPU = 2
        CADJ = 3
        ROLP = 4
        CALL = 5
        RATE = 6
        PADJ = 7
        PAIR = 8
    }
    class ISO20022.Sese024002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese024002.RestrictedFINActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese024002.Restriction6Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.Restriction6Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.SafeKeepingPlace4 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Sese024002.SafekeepingPlaceFormat39Choice
    }
    ISO20022.Sese024002.SafeKeepingPlace4 *-- ISO20022.Sese024002.SafekeepingPlaceFormat39Choice
    class ISO20022.Sese024002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Sese024002.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Sese024002.SafekeepingPlaceFormat39Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification85
        + TpAndId  : ISO20022.Sese024002.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Sese024002.SafekeepingPlaceTypeAndText15
    }
    ISO20022.Sese024002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese024002.GenericIdentification85
    ISO20022.Sese024002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese024002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Sese024002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese024002.SafekeepingPlaceTypeAndText15
    class ISO20022.Sese024002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese024002.SafekeepingPlaceTypeAndText15 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese024002.SecuritiesAccount30 {
        + Nm  : String
        + Tp  : ISO20022.Sese024002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese024002.SecuritiesAccount30 *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.SecuritiesRTGS5Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese024002.SecuritiesRTGS5Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.SecuritiesSettlementTransactionStatusAdvice002V12 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese024002.SupplementaryData1~
        + TxDtls  : ISO20022.Sese024002.TransactionDetails161
        + SttlmSts  : ISO20022.Sese024002.SettlementStatus31Choice
        + MtchgSts  : ISO20022.Sese024002.MatchingStatus32Choice
        + IfrrdMtchgSts  : ISO20022.Sese024002.MatchingStatus32Choice
        + PrcgSts  : ISO20022.Sese024002.ProcessingStatus94Choice
        + Lnkgs  : ISO20022.Sese024002.Linkages50
        + TxId  : ISO20022.Sese024002.TransactionIdentifications49
    }
    ISO20022.Sese024002.SecuritiesSettlementTransactionStatusAdvice002V12 *-- ISO20022.Sese024002.SupplementaryData1
    ISO20022.Sese024002.SecuritiesSettlementTransactionStatusAdvice002V12 *-- ISO20022.Sese024002.TransactionDetails161
    ISO20022.Sese024002.SecuritiesSettlementTransactionStatusAdvice002V12 *-- ISO20022.Sese024002.SettlementStatus31Choice
    ISO20022.Sese024002.SecuritiesSettlementTransactionStatusAdvice002V12 *-- ISO20022.Sese024002.MatchingStatus32Choice
    ISO20022.Sese024002.SecuritiesSettlementTransactionStatusAdvice002V12 *-- ISO20022.Sese024002.MatchingStatus32Choice
    ISO20022.Sese024002.SecuritiesSettlementTransactionStatusAdvice002V12 *-- ISO20022.Sese024002.ProcessingStatus94Choice
    ISO20022.Sese024002.SecuritiesSettlementTransactionStatusAdvice002V12 *-- ISO20022.Sese024002.Linkages50
    ISO20022.Sese024002.SecuritiesSettlementTransactionStatusAdvice002V12 *-- ISO20022.Sese024002.TransactionIdentifications49
    class ISO20022.Sese024002.SecuritiesTransactionType26Code {
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
    class ISO20022.Sese024002.SecuritiesTransactionType52Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.SecuritiesTransactionType52Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese024002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Sese024002.SecurityIdentification20 *-- ISO20022.Sese024002.OtherIdentification2
    class ISO20022.Sese024002.SettlementDate32Choice {
        + DtCd  : ISO20022.Sese024002.SettlementDateCode11Choice
        + Dt  : ISO20022.Sese024002.DateAndDateTime2Choice
    }
    ISO20022.Sese024002.SettlementDate32Choice *-- ISO20022.Sese024002.SettlementDateCode11Choice
    ISO20022.Sese024002.SettlementDate32Choice *-- ISO20022.Sese024002.DateAndDateTime2Choice
    class ISO20022.Sese024002.SettlementDateCode11Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.SettlementDateCode11Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.SettlementDetails210 {
        + ElgblForColl  : String
        + PrtlSttlmInd  : String
        + LttrOfGrnt  : ISO20022.Sese024002.LetterOfGuarantee5Choice
        + CCPElgblty  : ISO20022.Sese024002.CentralCounterPartyEligibility5Choice
        + NetgElgblty  : ISO20022.Sese024002.NettingEligibility5Choice
        + SttlmSysMtd  : ISO20022.Sese024002.SettlementSystemMethod5Choice
        + LglRstrctns  : ISO20022.Sese024002.Restriction6Choice
        + BlckTrad  : ISO20022.Sese024002.BlockTrade5Choice
        + MktClntSd  : ISO20022.Sese024002.MarketClientSide7Choice
        + RpTp  : ISO20022.Sese024002.RepurchaseType24Choice
        + TaxCpcty  : ISO20022.Sese024002.TaxCapacityParty5Choice
        + CshClrSys  : ISO20022.Sese024002.CashSettlementSystem5Choice
        + XpsrTp  : ISO20022.Sese024002.ExposureType24Choice
        + BnfclOwnrsh  : ISO20022.Sese024002.BeneficialOwnership5Choice
        + Regn  : ISO20022.Sese024002.Registration11Choice
        + SctiesRTGS  : ISO20022.Sese024002.SecuritiesRTGS5Choice
        + StmpDtyTaxBsis  : ISO20022.Sese024002.GenericIdentification47
        + SttlgCpcty  : ISO20022.Sese024002.SettlingCapacity8Choice
        + SctiesTxTp  : ISO20022.Sese024002.SecuritiesTransactionType52Choice
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese024002.SettlementTransactionCondition37Choice~
        + HldInd  : ISO20022.Sese024002.HoldIndicator7
    }
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.LetterOfGuarantee5Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.CentralCounterPartyEligibility5Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.NettingEligibility5Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.SettlementSystemMethod5Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.Restriction6Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.BlockTrade5Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.MarketClientSide7Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.RepurchaseType24Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.TaxCapacityParty5Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.CashSettlementSystem5Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.ExposureType24Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.BeneficialOwnership5Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.Registration11Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.SecuritiesRTGS5Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.GenericIdentification47
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.SettlingCapacity8Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.SecuritiesTransactionType52Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.SettlementTransactionCondition37Choice
    ISO20022.Sese024002.SettlementDetails210 *-- ISO20022.Sese024002.HoldIndicator7
    class ISO20022.Sese024002.SettlementParties109 {
        + Pty5  : ISO20022.Sese024002.PartyIdentificationAndAccount215
        + Pty4  : ISO20022.Sese024002.PartyIdentificationAndAccount215
        + Pty3  : ISO20022.Sese024002.PartyIdentificationAndAccount215
        + Pty2  : ISO20022.Sese024002.PartyIdentificationAndAccount215
        + Pty1  : ISO20022.Sese024002.PartyIdentificationAndAccount215
        + Dpstry  : ISO20022.Sese024002.PartyIdentification191
    }
    ISO20022.Sese024002.SettlementParties109 *-- ISO20022.Sese024002.PartyIdentificationAndAccount215
    ISO20022.Sese024002.SettlementParties109 *-- ISO20022.Sese024002.PartyIdentificationAndAccount215
    ISO20022.Sese024002.SettlementParties109 *-- ISO20022.Sese024002.PartyIdentificationAndAccount215
    ISO20022.Sese024002.SettlementParties109 *-- ISO20022.Sese024002.PartyIdentificationAndAccount215
    ISO20022.Sese024002.SettlementParties109 *-- ISO20022.Sese024002.PartyIdentificationAndAccount215
    ISO20022.Sese024002.SettlementParties109 *-- ISO20022.Sese024002.PartyIdentification191
    class ISO20022.Sese024002.SettlementStatus31Choice {
        + Prtry  : ISO20022.Sese024002.ProprietaryStatusAndReason7
        + Flng  : ISO20022.Sese024002.FailingStatus14Choice
        + Pdg  : ISO20022.Sese024002.PendingStatus69Choice
    }
    ISO20022.Sese024002.SettlementStatus31Choice *-- ISO20022.Sese024002.ProprietaryStatusAndReason7
    ISO20022.Sese024002.SettlementStatus31Choice *-- ISO20022.Sese024002.FailingStatus14Choice
    ISO20022.Sese024002.SettlementStatus31Choice *-- ISO20022.Sese024002.PendingStatus69Choice
    class ISO20022.Sese024002.SettlementSystemMethod1Code {
        YSET = 1
        NSET = 2
    }
    class ISO20022.Sese024002.SettlementSystemMethod5Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.SettlementSystemMethod5Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.SettlementTransactionCondition12Code {
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
    class ISO20022.Sese024002.SettlementTransactionCondition37Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.SettlementTransactionCondition37Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.SettlementTransactionCondition5Code {
        PARQ = 1
        PARC = 2
        NPAR = 3
        PART = 4
    }
    class ISO20022.Sese024002.SettlingCapacity2Code {
        RISP = 1
        SPRI = 2
        CUST = 3
        SAGE = 4
    }
    class ISO20022.Sese024002.SettlingCapacity8Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.SettlingCapacity8Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.SupplementaryData1 {
        + Envlp  : ISO20022.Sese024002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese024002.SupplementaryData1 *-- ISO20022.Sese024002.SupplementaryDataEnvelope1
    class ISO20022.Sese024002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese024002.TaxCapacityParty5Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.TaxCapacityParty5Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.TaxLiability1Code {
        AGEN = 1
        PRIN = 2
    }
    class ISO20022.Sese024002.TradeDate9Choice {
        + DtCd  : ISO20022.Sese024002.TradeDateCode4Choice
        + Dt  : ISO20022.Sese024002.DateAndDateTime2Choice
    }
    ISO20022.Sese024002.TradeDate9Choice *-- ISO20022.Sese024002.TradeDateCode4Choice
    ISO20022.Sese024002.TradeDate9Choice *-- ISO20022.Sese024002.DateAndDateTime2Choice
    class ISO20022.Sese024002.TradeDateCode4Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.TradeDateCode4Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.TransactionDetails161 {
        + SttlmInstrPrcgAddtlDtls  : String
        + QlfdFrgnIntrmy  : ISO20022.Sese024002.PartyIdentification157
        + Invstr  : ISO20022.Sese024002.PartyIdentification170
        + DlvrgSttlmPties  : ISO20022.Sese024002.SettlementParties109
        + RcvgSttlmPties  : ISO20022.Sese024002.SettlementParties109
        + SttlmParams  : ISO20022.Sese024002.SettlementDetails210
        + Pmt  : String
        + SctiesMvmntTp  : String
        + MtchdStsTmStmp  : DateTime
        + AckdStsTmStmp  : DateTime
        + TradDt  : ISO20022.Sese024002.TradeDate9Choice
        + SttlmDt  : ISO20022.Sese024002.SettlementDate32Choice
        + XpctdValDt  : ISO20022.Sese024002.DateAndDateTime2Choice
        + XpctdSttlmDt  : ISO20022.Sese024002.DateAndDateTime2Choice
        + LateDlvryDt  : ISO20022.Sese024002.DateAndDateTime2Choice
        + SttlmAmt  : ISO20022.Sese024002.AmountAndDirection67
        + PrtlyRlsdQty  : ISO20022.Sese024002.Quantity54Choice
        + SttlmQty  : ISO20022.Sese024002.Quantity54Choice
        + FinInstrmId  : ISO20022.Sese024002.SecurityIdentification20
        + PlcOfClr  : ISO20022.Sese024002.PlaceOfClearingIdentification2
        + PlcOfTrad  : ISO20022.Sese024002.PlaceOfTradeIdentification2
        + SfkpgPlc  : ISO20022.Sese024002.SafeKeepingPlace4
        + BlckChainAdrOrWllt  : ISO20022.Sese024002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese024002.SecuritiesAccount30
        + AcctOwnr  : ISO20022.Sese024002.PartyIdentification156
        + TrptyAgtSvcPrvdrCollInstrId  : String
        + ClntCollInstrId  : String
        + ClntTrptyCollTxId  : String
        + TrptyAgtSvcPrvdrCollTxId  : String
        + CorpActnEvtId  : String
        + PoolId  : String
        + TradId  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.PartyIdentification157
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.PartyIdentification170
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.SettlementParties109
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.SettlementParties109
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.SettlementDetails210
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.TradeDate9Choice
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.SettlementDate32Choice
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.DateAndDateTime2Choice
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.DateAndDateTime2Choice
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.DateAndDateTime2Choice
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.AmountAndDirection67
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.Quantity54Choice
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.Quantity54Choice
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.SecurityIdentification20
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.PlaceOfClearingIdentification2
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.PlaceOfTradeIdentification2
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.SafeKeepingPlace4
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.BlockChainAddressWallet7
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.SecuritiesAccount30
    ISO20022.Sese024002.TransactionDetails161 *-- ISO20022.Sese024002.PartyIdentification156
    class ISO20022.Sese024002.TransactionIdentifications49 {
        + NetgSvcPrvdrId  : String
        + CmonId  : String
        + PrcrTxId  : String
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    class ISO20022.Sese024002.UnmatchedReason11Code {
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
    class ISO20022.Sese024002.UnmatchedReason20 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese024002.UnmatchedReason27Choice
    }
    ISO20022.Sese024002.UnmatchedReason20 *-- ISO20022.Sese024002.UnmatchedReason27Choice
    class ISO20022.Sese024002.UnmatchedReason27Choice {
        + Prtry  : ISO20022.Sese024002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese024002.UnmatchedReason27Choice *-- ISO20022.Sese024002.GenericIdentification47
    class ISO20022.Sese024002.UnmatchedStatus21Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese024002.UnmatchedReason20~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese024002.UnmatchedStatus21Choice *-- ISO20022.Sese024002.UnmatchedReason20
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

## Value ISO20022.Sese024002.AcknowledgedAcceptedStatus25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese024002.AcknowledgementReason13>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese024002.AcknowledgementReason13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese024002.AcknowledgementReason16Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese024002.AcknowledgementReason16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese024002.AcknowledgementReason5Code


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

## Value ISO20022.Sese024002.AmountAndDirection67


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese024002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese024002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese024002.BeneficialOwnership5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese024002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Enum ISO20022.Sese024002.BlockTrade1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BLCH|Int32||XmlEnum("""BLCH""")|1|
||BLPA|Int32||XmlEnum("""BLPA""")|2|

---

## Value ISO20022.Sese024002.BlockTrade5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese024002.CancellationReason24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese024002.CancellationReason37Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese024002.CancellationReason37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese024002.CancellationStatus25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese024002.CancellationReason24>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese024002.CancelledStatusReason16Code


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

## Enum ISO20022.Sese024002.CashSettlementSystem2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETS|Int32||XmlEnum("""NETS""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Value ISO20022.Sese024002.CashSettlementSystem5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese024002.CentralCounterPartyEligibility5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Enum ISO20022.Sese024002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese024002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Sese024002.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese024002.DateType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||OPEN|Int32||XmlEnum("""OPEN""")|2|

---

## Enum ISO20022.Sese024002.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Type ISO20022.Sese024002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmTxStsAdvc|ISO20022.Sese024002.SecuritiesSettlementTransactionStatusAdvice002V12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmTxStsAdvc))|

---

## Enum ISO20022.Sese024002.ExposureType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRCP|Int32||XmlEnum("""TRCP""")|1|
||UDMS|Int32||XmlEnum("""UDMS""")|2|
||TBAS|Int32||XmlEnum("""TBAS""")|3|
||SWPT|Int32||XmlEnum("""SWPT""")|4|
||SCIE|Int32||XmlEnum("""SCIE""")|5|
||SCIR|Int32||XmlEnum("""SCIR""")|6|
||SHSL|Int32||XmlEnum("""SHSL""")|7|
||SLEB|Int32||XmlEnum("""SLEB""")|8|
||SCRP|Int32||XmlEnum("""SCRP""")|9|
||SBSC|Int32||XmlEnum("""SBSC""")|10|
||SLOA|Int32||XmlEnum("""SLOA""")|11|
||RVPO|Int32||XmlEnum("""RVPO""")|12|
||REPO|Int32||XmlEnum("""REPO""")|13|
||OTCD|Int32||XmlEnum("""OTCD""")|14|
||LIQU|Int32||XmlEnum("""LIQU""")|15|
||OPTN|Int32||XmlEnum("""OPTN""")|16|
||FUTR|Int32||XmlEnum("""FUTR""")|17|
||FORW|Int32||XmlEnum("""FORW""")|18|
||FORX|Int32||XmlEnum("""FORX""")|19|
||FIXI|Int32||XmlEnum("""FIXI""")|20|
||EXPT|Int32||XmlEnum("""EXPT""")|21|
||EQUS|Int32||XmlEnum("""EQUS""")|22|
||EXTD|Int32||XmlEnum("""EXTD""")|23|
||EQPT|Int32||XmlEnum("""EQPT""")|24|
||CRPR|Int32||XmlEnum("""CRPR""")|25|
||CCIR|Int32||XmlEnum("""CCIR""")|26|
||CRSP|Int32||XmlEnum("""CRSP""")|27|
||CRTL|Int32||XmlEnum("""CRTL""")|28|
||CRDS|Int32||XmlEnum("""CRDS""")|29|
||COMM|Int32||XmlEnum("""COMM""")|30|
||CCPC|Int32||XmlEnum("""CCPC""")|31|
||PAYM|Int32||XmlEnum("""PAYM""")|32|
||BFWD|Int32||XmlEnum("""BFWD""")|33|

---

## Value ISO20022.Sese024002.ExposureType24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese024002.FailingReason12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese024002.FailingReason17Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese024002.FailingReason17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese024002.FailingReason4Code


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

## Value ISO20022.Sese024002.FailingStatus14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese024002.FailingReason12>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese024002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese024002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese024002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese024002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Sese024002.HoldIndicator7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese024002.RegistrationReason6>||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rsn""",Rsn),validElement(Rsn))|

---

## Value ISO20022.Sese024002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese024002.LetterOfGuarantee5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese024002.Linkages50


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmTxId|String||XmlElement()||
|+|PrcgPos|ISO20022.Sese024002.ProcessingPosition23Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SctiesSttlmTxId""",SctiesSttlmTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(PrcgPos))|

---

## Enum ISO20022.Sese024002.MarketClientSide1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MAKT|Int32||XmlEnum("""MAKT""")|1|
||CLNT|Int32||XmlEnum("""CLNT""")|2|

---

## Value ISO20022.Sese024002.MarketClientSide7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese024002.MarketIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese024002.MarketIdentification90


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese024002.MarketType16Choice||XmlElement()||
|+|Id|ISO20022.Sese024002.MarketIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Sese024002.MarketType16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese024002.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Value ISO20022.Sese024002.MatchingStatus32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.ProprietaryStatusAndReason7||XmlElement()||
|+|Umtchd|ISO20022.Sese024002.UnmatchedStatus21Choice||XmlElement()||
|+|Mtchd|ISO20022.Sese024002.ProprietaryReason5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Umtchd),validElement(Mtchd),validChoice(Prtry,Umtchd,Mtchd))|

---

## Value ISO20022.Sese024002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Sese024002.NettingEligibility5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Enum ISO20022.Sese024002.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Sese024002.OriginalAndCurrentQuantities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese024002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese024002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Enum ISO20022.Sese024002.OwnershipLegalRestrictions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSTR|Int32||XmlEnum("""RSTR""")|1|
||NRST|Int32||XmlEnum("""NRST""")|2|
||A144|Int32||XmlEnum("""A144""")|3|

---

## Value ISO20022.Sese024002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese024002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese024002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese024002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese024002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese024002.PartyIdentification145Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese024002.NameAndAddress12||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese024002.PartyIdentification156


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese024002.PartyIdentification136Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese024002.PartyIdentification157


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese024002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese024002.PartyIdentification170


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese024002.PartyIdentification176Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese024002.PartyIdentification176Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese024002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese024002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese024002.PartyIdentification191


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese024002.PartyIdentification145Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese024002.PartyIdentificationAndAccount215


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese024002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese024002.SecuritiesAccount30||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese024002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese024002.PendingProcessingReason16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese024002.PendingProcessingReason18Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese024002.PendingProcessingReason18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese024002.PendingProcessingReason4Code


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

## Value ISO20022.Sese024002.PendingProcessingStatus19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese024002.PendingProcessingReason16>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese024002.PendingReason20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese024002.PendingReason37Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Enum ISO20022.Sese024002.PendingReason24Code


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

## Value ISO20022.Sese024002.PendingReason31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese024002.PendingReason65Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese024002.PendingReason37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese024002.PendingReason65Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese024002.PendingReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDRE|Int32||XmlEnum("""CDRE""")|1|
||CDCY|Int32||XmlEnum("""CDCY""")|2|
||CDRG|Int32||XmlEnum("""CDRG""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||CONF|Int32||XmlEnum("""CONF""")|5|
||ADEA|Int32||XmlEnum("""ADEA""")|6|

---

## Value ISO20022.Sese024002.PendingStatus46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese024002.PendingReason20>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese024002.PendingStatus69Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese024002.PendingReason31>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese024002.PlaceOfClearingIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese024002.PlaceOfTradeIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|MktTpAndId|ISO20022.Sese024002.MarketIdentification90||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(MktTpAndId))|

---

## Value ISO20022.Sese024002.ProcessingPosition23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese024002.ProcessingPosition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|

---

## Value ISO20022.Sese024002.ProcessingStatus94Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ModReqd|ISO20022.Sese024002.ProprietaryReason5||XmlElement()||
|+|CxlReqd|ISO20022.Sese024002.ProprietaryReason5||XmlElement()||
|+|Prtry|ISO20022.Sese024002.ProprietaryStatusAndReason7||XmlElement()||
|+|PdgCxl|ISO20022.Sese024002.PendingStatus46Choice||XmlElement()||
|+|Canc|ISO20022.Sese024002.CancellationStatus25Choice||XmlElement()||
|+|Rpr|ISO20022.Sese024002.RepairStatus16Choice||XmlElement()||
|+|Rjctd|ISO20022.Sese024002.RejectionStatus44Choice||XmlElement()||
|+|PdgPrcg|ISO20022.Sese024002.PendingProcessingStatus19Choice||XmlElement()||
|+|AckdAccptd|ISO20022.Sese024002.AcknowledgedAcceptedStatus25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ModReqd),validElement(CxlReqd),validElement(Prtry),validElement(PdgCxl),validElement(Canc),validElement(Rpr),validElement(Rjctd),validElement(PdgPrcg),validElement(AckdAccptd),validChoice(ModReqd,CxlReqd,Prtry,PdgCxl,Canc,Rpr,Rjctd,PdgPrcg,AckdAccptd))|

---

## Value ISO20022.Sese024002.ProprietaryReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Rsn))|

---

## Value ISO20022.Sese024002.ProprietaryStatusAndReason7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Sese024002.ProprietaryReason5>||XmlElement()||
|+|PrtrySts|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Sese024002.Quantity54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Sese024002.OriginalAndCurrentQuantities4||XmlElement()||
|+|Qty|ISO20022.Sese024002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Enum ISO20022.Sese024002.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Sese024002.Registration11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese024002.Registration12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese024002.Registration1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YREG|Int32||XmlEnum("""YREG""")|1|
||NREG|Int32||XmlEnum("""NREG""")|2|

---

## Enum ISO20022.Sese024002.Registration2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CVAL|Int32||XmlEnum("""CVAL""")|1|
||CDEL|Int32||XmlEnum("""CDEL""")|2|
||CSDH|Int32||XmlEnum("""CSDH""")|3|
||PTYH|Int32||XmlEnum("""PTYH""")|4|

---

## Value ISO20022.Sese024002.RegistrationReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|String||XmlElement()||
|+|Cd|ISO20022.Sese024002.Registration12Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlInf""",AddtlInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese024002.RejectionReason50Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese024002.RejectionReason65


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese024002.RejectionReason50Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Enum ISO20022.Sese024002.RejectionReason75Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PLIS|Int32||XmlEnum("""PLIS""")|1|
||INVE|Int32||XmlEnum("""INVE""")|2|
||VALR|Int32||XmlEnum("""VALR""")|3|
||INVN|Int32||XmlEnum("""INVN""")|4|
||INVL|Int32||XmlEnum("""INVL""")|5|
||INVB|Int32||XmlEnum("""INVB""")|6|
||IEXE|Int32||XmlEnum("""IEXE""")|7|
||DEPT|Int32||XmlEnum("""DEPT""")|8|
||ICAG|Int32||XmlEnum("""ICAG""")|9|
||ICUS|Int32||XmlEnum("""ICUS""")|10|
||OTHR|Int32||XmlEnum("""OTHR""")|11|
||INPS|Int32||XmlEnum("""INPS""")|12|
||SDUT|Int32||XmlEnum("""SDUT""")|13|
||SETR|Int32||XmlEnum("""SETR""")|14|
||DDAT|Int32||XmlEnum("""DDAT""")|15|
||CASY|Int32||XmlEnum("""CASY""")|16|
||CAEV|Int32||XmlEnum("""CAEV""")|17|
||IIND|Int32||XmlEnum("""IIND""")|18|
||SETS|Int32||XmlEnum("""SETS""")|19|
||TXST|Int32||XmlEnum("""TXST""")|20|
||MUNO|Int32||XmlEnum("""MUNO""")|21|
||BATC|Int32||XmlEnum("""BATC""")|22|
||MINO|Int32||XmlEnum("""MINO""")|23|
||DMON|Int32||XmlEnum("""DMON""")|24|
||REFE|Int32||XmlEnum("""REFE""")|25|
||PHYS|Int32||XmlEnum("""PHYS""")|26|
||NCRR|Int32||XmlEnum("""NCRR""")|27|
||RTGS|Int32||XmlEnum("""RTGS""")|28|
||PLCE|Int32||XmlEnum("""PLCE""")|29|
||DTRD|Int32||XmlEnum("""DTRD""")|30|
||DDEA|Int32||XmlEnum("""DDEA""")|31|
||CASH|Int32||XmlEnum("""CASH""")|32|
||LATE|Int32||XmlEnum("""LATE""")|33|
||DSEC|Int32||XmlEnum("""DSEC""")|34|
||ADEA|Int32||XmlEnum("""ADEA""")|35|
||DQUA|Int32||XmlEnum("""DQUA""")|36|
||SAFE|Int32||XmlEnum("""SAFE""")|37|

---

## Value ISO20022.Sese024002.RejectionStatus44Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese024002.RejectionReason65>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese024002.RepairReason12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese024002.RepairReason14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese024002.RepairReason14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese024002.RepairReason4Code


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

## Value ISO20022.Sese024002.RepairStatus16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese024002.RepairReason12>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese024002.RepurchaseType24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese024002.RepurchaseType9Code


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

## Value ISO20022.Sese024002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese024002.RestrictedFINActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese024002.Restriction6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese024002.SafeKeepingPlace4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Sese024002.SafekeepingPlaceFormat39Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Sese024002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Sese024002.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Sese024002.SafekeepingPlaceFormat39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Sese024002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Sese024002.SafekeepingPlaceTypeAndText15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Sese024002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese024002.SafekeepingPlaceTypeAndText15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese024002.SecuritiesAccount30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Sese024002.SecuritiesRTGS5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Aspect ISO20022.Sese024002.SecuritiesSettlementTransactionStatusAdvice002V12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese024002.SupplementaryData1>||XmlElement()||
|+|TxDtls|ISO20022.Sese024002.TransactionDetails161||XmlElement()||
|+|SttlmSts|ISO20022.Sese024002.SettlementStatus31Choice||XmlElement()||
|+|MtchgSts|ISO20022.Sese024002.MatchingStatus32Choice||XmlElement()||
|+|IfrrdMtchgSts|ISO20022.Sese024002.MatchingStatus32Choice||XmlElement()||
|+|PrcgSts|ISO20022.Sese024002.ProcessingStatus94Choice||XmlElement()||
|+|Lnkgs|ISO20022.Sese024002.Linkages50||XmlElement()||
|+|TxId|ISO20022.Sese024002.TransactionIdentifications49||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TxDtls),validElement(SttlmSts),validElement(MtchgSts),validElement(IfrrdMtchgSts),validElement(PrcgSts),validElement(Lnkgs),validElement(TxId))|

---

## Enum ISO20022.Sese024002.SecuritiesTransactionType26Code


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

## Value ISO20022.Sese024002.SecuritiesTransactionType52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese024002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese024002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese024002.SettlementDate32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese024002.SettlementDateCode11Choice||XmlElement()||
|+|Dt|ISO20022.Sese024002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese024002.SettlementDateCode11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese024002.SettlementDetails210


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ElgblForColl|String||XmlElement()||
|+|PrtlSttlmInd|String||XmlElement()||
|+|LttrOfGrnt|ISO20022.Sese024002.LetterOfGuarantee5Choice||XmlElement()||
|+|CCPElgblty|ISO20022.Sese024002.CentralCounterPartyEligibility5Choice||XmlElement()||
|+|NetgElgblty|ISO20022.Sese024002.NettingEligibility5Choice||XmlElement()||
|+|SttlmSysMtd|ISO20022.Sese024002.SettlementSystemMethod5Choice||XmlElement()||
|+|LglRstrctns|ISO20022.Sese024002.Restriction6Choice||XmlElement()||
|+|BlckTrad|ISO20022.Sese024002.BlockTrade5Choice||XmlElement()||
|+|MktClntSd|ISO20022.Sese024002.MarketClientSide7Choice||XmlElement()||
|+|RpTp|ISO20022.Sese024002.RepurchaseType24Choice||XmlElement()||
|+|TaxCpcty|ISO20022.Sese024002.TaxCapacityParty5Choice||XmlElement()||
|+|CshClrSys|ISO20022.Sese024002.CashSettlementSystem5Choice||XmlElement()||
|+|XpsrTp|ISO20022.Sese024002.ExposureType24Choice||XmlElement()||
|+|BnfclOwnrsh|ISO20022.Sese024002.BeneficialOwnership5Choice||XmlElement()||
|+|Regn|ISO20022.Sese024002.Registration11Choice||XmlElement()||
|+|SctiesRTGS|ISO20022.Sese024002.SecuritiesRTGS5Choice||XmlElement()||
|+|StmpDtyTaxBsis|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|SttlgCpcty|ISO20022.Sese024002.SettlingCapacity8Choice||XmlElement()||
|+|SctiesTxTp|ISO20022.Sese024002.SecuritiesTransactionType52Choice||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese024002.SettlementTransactionCondition37Choice>||XmlElement()||
|+|HldInd|ISO20022.Sese024002.HoldIndicator7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LttrOfGrnt),validElement(CCPElgblty),validElement(NetgElgblty),validElement(SttlmSysMtd),validElement(LglRstrctns),validElement(BlckTrad),validElement(MktClntSd),validElement(RpTp),validElement(TaxCpcty),validElement(CshClrSys),validElement(XpsrTp),validElement(BnfclOwnrsh),validElement(Regn),validElement(SctiesRTGS),validElement(StmpDtyTaxBsis),validElement(SttlgCpcty),validElement(SctiesTxTp),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond),validElement(HldInd))|

---

## Value ISO20022.Sese024002.SettlementParties109


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese024002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty4|ISO20022.Sese024002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty3|ISO20022.Sese024002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty2|ISO20022.Sese024002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty1|ISO20022.Sese024002.PartyIdentificationAndAccount215||XmlElement()||
|+|Dpstry|ISO20022.Sese024002.PartyIdentification191||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Value ISO20022.Sese024002.SettlementStatus31Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.ProprietaryStatusAndReason7||XmlElement()||
|+|Flng|ISO20022.Sese024002.FailingStatus14Choice||XmlElement()||
|+|Pdg|ISO20022.Sese024002.PendingStatus69Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Flng),validElement(Pdg),validChoice(Prtry,Flng,Pdg))|

---

## Enum ISO20022.Sese024002.SettlementSystemMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSET|Int32||XmlEnum("""YSET""")|1|
||NSET|Int32||XmlEnum("""NSET""")|2|

---

## Value ISO20022.Sese024002.SettlementSystemMethod5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese024002.SettlementTransactionCondition12Code


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

## Value ISO20022.Sese024002.SettlementTransactionCondition37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese024002.SettlementTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARQ|Int32||XmlEnum("""PARQ""")|1|
||PARC|Int32||XmlEnum("""PARC""")|2|
||NPAR|Int32||XmlEnum("""NPAR""")|3|
||PART|Int32||XmlEnum("""PART""")|4|

---

## Enum ISO20022.Sese024002.SettlingCapacity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RISP|Int32||XmlEnum("""RISP""")|1|
||SPRI|Int32||XmlEnum("""SPRI""")|2|
||CUST|Int32||XmlEnum("""CUST""")|3|
||SAGE|Int32||XmlEnum("""SAGE""")|4|

---

## Value ISO20022.Sese024002.SettlingCapacity8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese024002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese024002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese024002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese024002.TaxCapacityParty5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese024002.TaxLiability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGEN|Int32||XmlEnum("""AGEN""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Sese024002.TradeDate9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese024002.TradeDateCode4Choice||XmlElement()||
|+|Dt|ISO20022.Sese024002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese024002.TradeDateCode4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese024002.TransactionDetails161


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmInstrPrcgAddtlDtls|String||XmlElement()||
|+|QlfdFrgnIntrmy|ISO20022.Sese024002.PartyIdentification157||XmlElement()||
|+|Invstr|ISO20022.Sese024002.PartyIdentification170||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese024002.SettlementParties109||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese024002.SettlementParties109||XmlElement()||
|+|SttlmParams|ISO20022.Sese024002.SettlementDetails210||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
|+|MtchdStsTmStmp|DateTime||XmlElement()||
|+|AckdStsTmStmp|DateTime||XmlElement()||
|+|TradDt|ISO20022.Sese024002.TradeDate9Choice||XmlElement()||
|+|SttlmDt|ISO20022.Sese024002.SettlementDate32Choice||XmlElement()||
|+|XpctdValDt|ISO20022.Sese024002.DateAndDateTime2Choice||XmlElement()||
|+|XpctdSttlmDt|ISO20022.Sese024002.DateAndDateTime2Choice||XmlElement()||
|+|LateDlvryDt|ISO20022.Sese024002.DateAndDateTime2Choice||XmlElement()||
|+|SttlmAmt|ISO20022.Sese024002.AmountAndDirection67||XmlElement()||
|+|PrtlyRlsdQty|ISO20022.Sese024002.Quantity54Choice||XmlElement()||
|+|SttlmQty|ISO20022.Sese024002.Quantity54Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Sese024002.SecurityIdentification20||XmlElement()||
|+|PlcOfClr|ISO20022.Sese024002.PlaceOfClearingIdentification2||XmlElement()||
|+|PlcOfTrad|ISO20022.Sese024002.PlaceOfTradeIdentification2||XmlElement()||
|+|SfkpgPlc|ISO20022.Sese024002.SafeKeepingPlace4||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese024002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese024002.SecuritiesAccount30||XmlElement()||
|+|AcctOwnr|ISO20022.Sese024002.PartyIdentification156||XmlElement()||
|+|TrptyAgtSvcPrvdrCollInstrId|String||XmlElement()||
|+|ClntCollInstrId|String||XmlElement()||
|+|ClntTrptyCollTxId|String||XmlElement()||
|+|TrptyAgtSvcPrvdrCollTxId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|TradId|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SttlmInstrPrcgAddtlDtls""",SttlmInstrPrcgAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validElement(QlfdFrgnIntrmy),validElement(Invstr),validElement(DlvrgSttlmPties),validElement(RcvgSttlmPties),validElement(SttlmParams),validElement(TradDt),validElement(SttlmDt),validElement(XpctdValDt),validElement(XpctdSttlmDt),validElement(LateDlvryDt),validElement(SttlmAmt),validElement(PrtlyRlsdQty),validElement(SttlmQty),validElement(FinInstrmId),validElement(PlcOfClr),validElement(PlcOfTrad),validElement(SfkpgPlc),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validPattern("""TrptyAgtSvcPrvdrCollInstrId""",TrptyAgtSvcPrvdrCollInstrId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""ClntCollInstrId""",ClntCollInstrId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""ClntTrptyCollTxId""",ClntTrptyCollTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""TrptyAgtSvcPrvdrCollTxId""",TrptyAgtSvcPrvdrCollTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CorpActnEvtId""",CorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""PoolId""",PoolId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""TradId""",TradId,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,52}"""))|

---

## Value ISO20022.Sese024002.TransactionIdentifications49


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NetgSvcPrvdrId|String||XmlElement()||
|+|CmonId|String||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|CtrPtyMktInfrstrctrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""NetgSvcPrvdrId""",NetgSvcPrvdrId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CmonId""",CmonId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""PrcrTxId""",PrcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CtrPtyMktInfrstrctrTxId""",CtrPtyMktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktInfrstrctrTxId""",MktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrTxId""",AcctSvcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctOwnrTxId""",AcctOwnrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Sese024002.UnmatchedReason11Code


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

## Value ISO20022.Sese024002.UnmatchedReason20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese024002.UnmatchedReason27Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese024002.UnmatchedReason27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese024002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese024002.UnmatchedStatus21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese024002.UnmatchedReason20>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

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

