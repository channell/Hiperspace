# semt.022.002.05
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt022002.AcknowledgedAcceptedStatus25Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.AcknowledgementReason13~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.AcknowledgedAcceptedStatus25Choice *-- ISO20022.Semt022002.AcknowledgementReason13
    class ISO20022.Semt022002.AcknowledgedAcceptedStatus30Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.AcknowledgementReason18~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.AcknowledgedAcceptedStatus30Choice *-- ISO20022.Semt022002.AcknowledgementReason18
    class ISO20022.Semt022002.AcknowledgedAcceptedStatus31Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.AcknowledgementReason19~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.AcknowledgedAcceptedStatus31Choice *-- ISO20022.Semt022002.AcknowledgementReason19
    class ISO20022.Semt022002.AcknowledgementReason13 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.AcknowledgementReason16Choice
    }
    ISO20022.Semt022002.AcknowledgementReason13 *-- ISO20022.Semt022002.AcknowledgementReason16Choice
    class ISO20022.Semt022002.AcknowledgementReason16Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.AcknowledgementReason16Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.AcknowledgementReason18 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.AcknowledgementReason21Choice
    }
    ISO20022.Semt022002.AcknowledgementReason18 *-- ISO20022.Semt022002.AcknowledgementReason21Choice
    class ISO20022.Semt022002.AcknowledgementReason19 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.AcknowledgementReason22Choice
    }
    ISO20022.Semt022002.AcknowledgementReason19 *-- ISO20022.Semt022002.AcknowledgementReason22Choice
    class ISO20022.Semt022002.AcknowledgementReason21Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.AcknowledgementReason21Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.AcknowledgementReason22Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.AcknowledgementReason22Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.AcknowledgementReason3Code {
        OTHR = 1
        SMPG = 2
        ADEA = 3
    }
    class ISO20022.Semt022002.AcknowledgementReason5Code {
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
    class ISO20022.Semt022002.AcknowledgementReason6Code {
        LATE = 1
        NSTP = 2
        OTHR = 3
        SMPG = 4
        ADEA = 5
    }
    class ISO20022.Semt022002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Semt022002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Semt022002.BlockChainAddressWallet7 *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.CancellationReason18 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.CancellationReason28Choice
    }
    ISO20022.Semt022002.CancellationReason18 *-- ISO20022.Semt022002.CancellationReason28Choice
    class ISO20022.Semt022002.CancellationReason24 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.CancellationReason37Choice
    }
    ISO20022.Semt022002.CancellationReason24 *-- ISO20022.Semt022002.CancellationReason37Choice
    class ISO20022.Semt022002.CancellationReason28Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.CancellationReason28Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.CancellationReason37Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.CancellationReason37Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.CancellationStatus20Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.CancellationReason18~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.CancellationStatus20Choice *-- ISO20022.Semt022002.CancellationReason18
    class ISO20022.Semt022002.CancellationStatus25Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.CancellationReason24~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.CancellationStatus25Choice *-- ISO20022.Semt022002.CancellationReason24
    class ISO20022.Semt022002.CancelledStatusReason16Code {
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
    class ISO20022.Semt022002.CancelledStatusReason5Code {
        OTHR = 1
        CANI = 2
    }
    class ISO20022.Semt022002.DeniedReason16 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.DeniedReason21Choice
    }
    ISO20022.Semt022002.DeniedReason16 *-- ISO20022.Semt022002.DeniedReason21Choice
    class ISO20022.Semt022002.DeniedReason17 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.DeniedReason24Choice
    }
    ISO20022.Semt022002.DeniedReason17 *-- ISO20022.Semt022002.DeniedReason24Choice
    class ISO20022.Semt022002.DeniedReason21Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.DeniedReason21Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.DeniedReason24Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.DeniedReason24Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.DeniedReason4Code {
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
    class ISO20022.Semt022002.DeniedReason6Code {
        CDRG = 1
        OTHR = 2
        LATE = 3
        DREP = 4
        DPRG = 5
        DSET = 6
        DCAN = 7
        CDRE = 8
        CDCY = 9
        ADEA = 10
    }
    class ISO20022.Semt022002.DeniedStatus19Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.DeniedReason17~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.DeniedStatus19Choice *-- ISO20022.Semt022002.DeniedReason17
    class ISO20022.Semt022002.DeniedStatus21Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.DeniedReason16~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.DeniedStatus21Choice *-- ISO20022.Semt022002.DeniedReason16
    class ISO20022.Semt022002.FailingReason10 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.FailingReason11Choice
    }
    ISO20022.Semt022002.FailingReason10 *-- ISO20022.Semt022002.FailingReason11Choice
    class ISO20022.Semt022002.FailingReason11Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.FailingReason11Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.FailingReason2Code {
        INBC = 1
        CVAL = 2
        CSDH = 3
        CDLR = 4
        PRSY = 5
        CERT = 6
        SETS = 7
        REGT = 8
        PRCY = 9
        LIQU = 10
        LATE = 11
        LAAW = 12
        FROZ = 13
        DKNY = 14
        DISA = 15
        DENO = 16
        CLHT = 17
        BOTH = 18
        BENO = 19
        PHCK = 20
        OTHR = 21
        IAAD = 22
        MINO = 23
        CPEC = 24
        SBLO = 25
        CYCL = 26
        BATC = 27
        SDUT = 28
        REFS = 29
        NCON = 30
        MONY = 31
        LALO = 32
        LACK = 33
        LINK = 34
        INCA = 35
        FLIM = 36
        DEPO = 37
        COLL = 38
        YCOL = 39
        CMON = 40
        NOFX = 41
        PART = 42
        PREA = 43
        GLOB = 44
        MUNO = 45
        CLAC = 46
        NEWI = 47
        CHAS = 48
        BLOC = 49
        DOCC = 50
        MLAT = 51
        DOCY = 52
        STCD = 53
        PHSE = 54
        AWSH = 55
        OBJT = 56
        CAIS = 57
        CANR = 58
        ADEA = 59
        CLAT = 60
        BYIY = 61
        AWMO = 62
    }
    class ISO20022.Semt022002.FailingStatus12Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.FailingReason10~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.FailingStatus12Choice *-- ISO20022.Semt022002.FailingReason10
    class ISO20022.Semt022002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt022002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt022002.GenericOrganisationIdentification2 {
        + Issr  : String
        + SchmeNm  : ISO20022.Semt022002.OrganisationIdentificationSchemeName2Choice
        + Id  : String
    }
    ISO20022.Semt022002.GenericOrganisationIdentification2 *-- ISO20022.Semt022002.OrganisationIdentificationSchemeName2Choice
    class ISO20022.Semt022002.MatchingStatus30Choice {
        + Prtry  : ISO20022.Semt022002.ProprietaryStatusAndReason7
        + Umtchd  : ISO20022.Semt022002.UnmatchedStatus20Choice
        + Mtchd  : ISO20022.Semt022002.ProprietaryReason5
    }
    ISO20022.Semt022002.MatchingStatus30Choice *-- ISO20022.Semt022002.ProprietaryStatusAndReason7
    ISO20022.Semt022002.MatchingStatus30Choice *-- ISO20022.Semt022002.UnmatchedStatus20Choice
    ISO20022.Semt022002.MatchingStatus30Choice *-- ISO20022.Semt022002.ProprietaryReason5
    class ISO20022.Semt022002.ModificationProcessingStatus11Choice {
        + Prtry  : ISO20022.Semt022002.ProprietaryStatusAndReason7
        + Modfd  : ISO20022.Semt022002.ModificationStatus5Choice
        + Rprd  : ISO20022.Semt022002.RepairStatus17Choice
        + Rjctd  : ISO20022.Semt022002.RejectionStatus42Choice
        + Dnd  : ISO20022.Semt022002.DeniedStatus19Choice
        + PdgPrcg  : ISO20022.Semt022002.PendingProcessingStatus16Choice
        + AckdAccptd  : ISO20022.Semt022002.AcknowledgedAcceptedStatus30Choice
    }
    ISO20022.Semt022002.ModificationProcessingStatus11Choice *-- ISO20022.Semt022002.ProprietaryStatusAndReason7
    ISO20022.Semt022002.ModificationProcessingStatus11Choice *-- ISO20022.Semt022002.ModificationStatus5Choice
    ISO20022.Semt022002.ModificationProcessingStatus11Choice *-- ISO20022.Semt022002.RepairStatus17Choice
    ISO20022.Semt022002.ModificationProcessingStatus11Choice *-- ISO20022.Semt022002.RejectionStatus42Choice
    ISO20022.Semt022002.ModificationProcessingStatus11Choice *-- ISO20022.Semt022002.DeniedStatus19Choice
    ISO20022.Semt022002.ModificationProcessingStatus11Choice *-- ISO20022.Semt022002.PendingProcessingStatus16Choice
    ISO20022.Semt022002.ModificationProcessingStatus11Choice *-- ISO20022.Semt022002.AcknowledgedAcceptedStatus30Choice
    class ISO20022.Semt022002.ModificationReason5 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.ModificationReason5Choice
    }
    ISO20022.Semt022002.ModificationReason5 *-- ISO20022.Semt022002.ModificationReason5Choice
    class ISO20022.Semt022002.ModificationReason5Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.ModificationReason5Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.ModificationStatus5Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.ModificationReason5~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.ModificationStatus5Choice *-- ISO20022.Semt022002.ModificationReason5
    class ISO20022.Semt022002.ModifiedStatusReason1Code {
        OTHR = 1
        MDBY = 2
    }
    class ISO20022.Semt022002.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Semt022002.OrganisationIdentification32 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Semt022002.GenericOrganisationIdentification2~
        + AnyBIC  : String
    }
    ISO20022.Semt022002.OrganisationIdentification32 *-- ISO20022.Semt022002.GenericOrganisationIdentification2
    class ISO20022.Semt022002.OrganisationIdentificationSchemeName2Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt022002.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Semt022002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Semt022002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Semt022002.PartyIdentification136Choice *-- ISO20022.Semt022002.GenericIdentification84
    class ISO20022.Semt022002.PartyIdentification156 {
        + LEI  : String
        + Id  : ISO20022.Semt022002.PartyIdentification136Choice
    }
    ISO20022.Semt022002.PartyIdentification156 *-- ISO20022.Semt022002.PartyIdentification136Choice
    class ISO20022.Semt022002.PendingProcessingReason12 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.PendingProcessingReason14Choice
    }
    ISO20022.Semt022002.PendingProcessingReason12 *-- ISO20022.Semt022002.PendingProcessingReason14Choice
    class ISO20022.Semt022002.PendingProcessingReason13 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.PendingProcessingReason15Choice
    }
    ISO20022.Semt022002.PendingProcessingReason13 *-- ISO20022.Semt022002.PendingProcessingReason15Choice
    class ISO20022.Semt022002.PendingProcessingReason14Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.PendingProcessingReason14Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.PendingProcessingReason15Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.PendingProcessingReason15Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.PendingProcessingReason2Code {
        INBC = 1
        CDAC = 2
        CDLR = 3
        CDEL = 4
        CVAL = 5
        CSDH = 6
        CERT = 7
        LIQU = 8
        DENO = 9
        OTHR = 10
        MINO = 11
        MONY = 12
        LALO = 13
        LACK = 14
        NEXT = 15
        FLIM = 16
        COLL = 17
        YCOL = 18
        GLOB = 19
        MUNO = 20
        BLOC = 21
        NOFX = 22
        DOCY = 23
        CAIS = 24
        ADEA = 25
    }
    class ISO20022.Semt022002.PendingProcessingReason3Code {
        CERT = 1
        DENO = 2
        OTHR = 3
        MINO = 4
        NEXT = 5
        MUNO = 6
        BLOC = 7
        ADEA = 8
    }
    class ISO20022.Semt022002.PendingProcessingStatus15Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.PendingProcessingReason12~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.PendingProcessingStatus15Choice *-- ISO20022.Semt022002.PendingProcessingReason12
    class ISO20022.Semt022002.PendingProcessingStatus16Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.PendingProcessingReason13~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.PendingProcessingStatus16Choice *-- ISO20022.Semt022002.PendingProcessingReason13
    class ISO20022.Semt022002.PendingReason20 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.PendingReason37Choice
    }
    ISO20022.Semt022002.PendingReason20 *-- ISO20022.Semt022002.PendingReason37Choice
    class ISO20022.Semt022002.PendingReason24 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.PendingReason41Choice
    }
    ISO20022.Semt022002.PendingReason24 *-- ISO20022.Semt022002.PendingReason41Choice
    class ISO20022.Semt022002.PendingReason25 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.PendingReason42Choice
    }
    ISO20022.Semt022002.PendingReason25 *-- ISO20022.Semt022002.PendingReason42Choice
    class ISO20022.Semt022002.PendingReason2Code {
        INBC = 1
        CDLR = 2
        CVAL = 3
        CSDH = 4
        PRSY = 5
        CERT = 6
        SETS = 7
        REGT = 8
        PRCY = 9
        LIQU = 10
        LATE = 11
        LAAW = 12
        FROZ = 13
        DKNY = 14
        DISA = 15
        DENO = 16
        CLHT = 17
        BOTH = 18
        BENO = 19
        PHCK = 20
        OTHR = 21
        IAAD = 22
        MINO = 23
        CPEC = 24
        SBLO = 25
        CYCL = 26
        BATC = 27
        SDUT = 28
        REFS = 29
        NCON = 30
        MONY = 31
        LALO = 32
        LACK = 33
        FUTU = 34
        LINK = 35
        INCA = 36
        FLIM = 37
        DEPO = 38
        COLL = 39
        YCOL = 40
        CMON = 41
        NOFX = 42
        NMAS = 43
        PART = 44
        PREA = 45
        GLOB = 46
        MUNO = 47
        CLAC = 48
        NEWI = 49
        CHAS = 50
        BLOC = 51
        DOCC = 52
        DOCY = 53
        TAMM = 54
        PHSE = 55
        AWSH = 56
        REFU = 57
        CAIS = 58
        ADEA = 59
        AWMO = 60
    }
    class ISO20022.Semt022002.PendingReason37Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.PendingReason37Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.PendingReason41Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.PendingReason41Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.PendingReason42Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.PendingReason42Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.PendingReason6Code {
        CDRE = 1
        CDCY = 2
        CDRG = 3
        OTHR = 4
        CONF = 5
        ADEA = 6
    }
    class ISO20022.Semt022002.PendingReason9Code {
        INBC = 1
        CDAC = 2
        CDRE = 3
        CDCY = 4
        CDRG = 5
        OTHR = 6
        CONF = 7
        ADEA = 8
    }
    class ISO20022.Semt022002.PendingStatus46Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.PendingReason20~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.PendingStatus46Choice *-- ISO20022.Semt022002.PendingReason20
    class ISO20022.Semt022002.PendingStatus50Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.PendingReason24~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.PendingStatus50Choice *-- ISO20022.Semt022002.PendingReason24
    class ISO20022.Semt022002.PendingStatus51Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.PendingReason25~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.PendingStatus51Choice *-- ISO20022.Semt022002.PendingReason25
    class ISO20022.Semt022002.ProcessingStatus92Choice {
        + ModReqd  : ISO20022.Semt022002.ProprietaryReason5
        + CxlReqd  : ISO20022.Semt022002.ProprietaryReason5
        + Prtry  : ISO20022.Semt022002.ProprietaryStatusAndReason7
        + PdgCxl  : ISO20022.Semt022002.PendingStatus46Choice
        + Canc  : ISO20022.Semt022002.CancellationStatus25Choice
        + Rpr  : ISO20022.Semt022002.RepairStatus16Choice
        + Rjctd  : ISO20022.Semt022002.RejectionStatus41Choice
        + PdgPrcg  : ISO20022.Semt022002.PendingProcessingStatus15Choice
        + AckdAccptd  : ISO20022.Semt022002.AcknowledgedAcceptedStatus25Choice
    }
    ISO20022.Semt022002.ProcessingStatus92Choice *-- ISO20022.Semt022002.ProprietaryReason5
    ISO20022.Semt022002.ProcessingStatus92Choice *-- ISO20022.Semt022002.ProprietaryReason5
    ISO20022.Semt022002.ProcessingStatus92Choice *-- ISO20022.Semt022002.ProprietaryStatusAndReason7
    ISO20022.Semt022002.ProcessingStatus92Choice *-- ISO20022.Semt022002.PendingStatus46Choice
    ISO20022.Semt022002.ProcessingStatus92Choice *-- ISO20022.Semt022002.CancellationStatus25Choice
    ISO20022.Semt022002.ProcessingStatus92Choice *-- ISO20022.Semt022002.RepairStatus16Choice
    ISO20022.Semt022002.ProcessingStatus92Choice *-- ISO20022.Semt022002.RejectionStatus41Choice
    ISO20022.Semt022002.ProcessingStatus92Choice *-- ISO20022.Semt022002.PendingProcessingStatus15Choice
    ISO20022.Semt022002.ProcessingStatus92Choice *-- ISO20022.Semt022002.AcknowledgedAcceptedStatus25Choice
    class ISO20022.Semt022002.ProcessingStatus93Choice {
        + Canc  : ISO20022.Semt022002.CancellationStatus20Choice
        + Dnd  : ISO20022.Semt022002.DeniedStatus21Choice
        + Prtry  : ISO20022.Semt022002.ProprietaryStatusAndReason7
        + AckdAccptd  : ISO20022.Semt022002.AcknowledgedAcceptedStatus31Choice
        + Rpr  : ISO20022.Semt022002.RejectionOrRepairStatus46Choice
        + Rjctd  : ISO20022.Semt022002.RejectionOrRepairStatus47Choice
        + PdgCxl  : ISO20022.Semt022002.PendingStatus51Choice
    }
    ISO20022.Semt022002.ProcessingStatus93Choice *-- ISO20022.Semt022002.CancellationStatus20Choice
    ISO20022.Semt022002.ProcessingStatus93Choice *-- ISO20022.Semt022002.DeniedStatus21Choice
    ISO20022.Semt022002.ProcessingStatus93Choice *-- ISO20022.Semt022002.ProprietaryStatusAndReason7
    ISO20022.Semt022002.ProcessingStatus93Choice *-- ISO20022.Semt022002.AcknowledgedAcceptedStatus31Choice
    ISO20022.Semt022002.ProcessingStatus93Choice *-- ISO20022.Semt022002.RejectionOrRepairStatus46Choice
    ISO20022.Semt022002.ProcessingStatus93Choice *-- ISO20022.Semt022002.RejectionOrRepairStatus47Choice
    ISO20022.Semt022002.ProcessingStatus93Choice *-- ISO20022.Semt022002.PendingStatus51Choice
    class ISO20022.Semt022002.ProprietaryReason5 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Semt022002.GenericIdentification47
    }
    ISO20022.Semt022002.ProprietaryReason5 *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.ProprietaryStatusAndReason7 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.ProprietaryReason5~
        + PrtrySts  : ISO20022.Semt022002.GenericIdentification47
    }
    ISO20022.Semt022002.ProprietaryStatusAndReason7 *-- ISO20022.Semt022002.ProprietaryReason5
    ISO20022.Semt022002.ProprietaryStatusAndReason7 *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.RejectionAndRepairReason41Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.RejectionAndRepairReason41Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.RejectionAndRepairReason42Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.RejectionAndRepairReason42Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.RejectionOrRepairReason41 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.RejectionAndRepairReason41Choice
    }
    ISO20022.Semt022002.RejectionOrRepairReason41 *-- ISO20022.Semt022002.RejectionAndRepairReason41Choice
    class ISO20022.Semt022002.RejectionOrRepairReason42 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.RejectionAndRepairReason42Choice
    }
    ISO20022.Semt022002.RejectionOrRepairReason42 *-- ISO20022.Semt022002.RejectionAndRepairReason42Choice
    class ISO20022.Semt022002.RejectionOrRepairStatus46Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.RejectionOrRepairReason41~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.RejectionOrRepairStatus46Choice *-- ISO20022.Semt022002.RejectionOrRepairReason41
    class ISO20022.Semt022002.RejectionOrRepairStatus47Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.RejectionOrRepairReason42~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.RejectionOrRepairStatus47Choice *-- ISO20022.Semt022002.RejectionOrRepairReason42
    class ISO20022.Semt022002.RejectionReason47Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.RejectionReason47Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.RejectionReason48Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.RejectionReason48Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.RejectionReason62 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.RejectionReason47Choice
    }
    ISO20022.Semt022002.RejectionReason62 *-- ISO20022.Semt022002.RejectionReason47Choice
    class ISO20022.Semt022002.RejectionReason63 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.RejectionReason48Choice
    }
    ISO20022.Semt022002.RejectionReason63 *-- ISO20022.Semt022002.RejectionReason48Choice
    class ISO20022.Semt022002.RejectionReason71Code {
        INVL = 1
        INVM = 2
        REFE = 3
        OTHR = 4
        NRGN = 5
        NRGM = 6
        SAFE = 7
        LATE = 8
        ADEA = 9
    }
    class ISO20022.Semt022002.RejectionReason72Code {
        VALR = 1
        INVN = 2
        INVB = 3
        INVL = 4
        IEXE = 5
        DEPT = 6
        ICAG = 7
        ICUS = 8
        OTHR = 9
        INPS = 10
        SDUT = 11
        SETR = 12
        DDAT = 13
        CASY = 14
        CAEV = 15
        IIND = 16
        SETS = 17
        TXST = 18
        MUNO = 19
        BATC = 20
        MINO = 21
        DMON = 22
        REFE = 23
        PHYS = 24
        NCRR = 25
        RTGS = 26
        PLCE = 27
        DTRD = 28
        DDEA = 29
        CASH = 30
        LATE = 31
        DSEC = 32
        ADEA = 33
        DQUA = 34
        SAFE = 35
    }
    class ISO20022.Semt022002.RejectionReason73Code {
        VALR = 1
        INVN = 2
        INVL = 3
        INVB = 4
        IEXE = 5
        DEPT = 6
        ICAG = 7
        ICUS = 8
        OTHR = 9
        INPS = 10
        SDUT = 11
        SETR = 12
        DDAT = 13
        CASY = 14
        CAEV = 15
        IIND = 16
        SETS = 17
        TXST = 18
        MUNO = 19
        BATC = 20
        MINO = 21
        DMON = 22
        REFE = 23
        PHYS = 24
        NCRR = 25
        RTGS = 26
        PLCE = 27
        DTRD = 28
        DDEA = 29
        CASH = 30
        LATE = 31
        DSEC = 32
        ADEA = 33
        DQUA = 34
        SAFE = 35
    }
    class ISO20022.Semt022002.RejectionReason74Code {
        OTHR = 1
        NRGM = 2
        REFE = 3
        NRGN = 4
        LATE = 5
        ADEA = 6
        SAFE = 7
    }
    class ISO20022.Semt022002.RejectionStatus41Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.RejectionReason62~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.RejectionStatus41Choice *-- ISO20022.Semt022002.RejectionReason62
    class ISO20022.Semt022002.RejectionStatus42Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.RejectionReason63~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.RejectionStatus42Choice *-- ISO20022.Semt022002.RejectionReason63
    class ISO20022.Semt022002.RepairReason12 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.RepairReason14Choice
    }
    ISO20022.Semt022002.RepairReason12 *-- ISO20022.Semt022002.RepairReason14Choice
    class ISO20022.Semt022002.RepairReason13 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.RepairReason14Choice
    }
    ISO20022.Semt022002.RepairReason13 *-- ISO20022.Semt022002.RepairReason14Choice
    class ISO20022.Semt022002.RepairReason14Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.RepairReason14Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.RepairReason4Code {
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
    class ISO20022.Semt022002.RepairStatus16Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.RepairReason12~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.RepairStatus16Choice *-- ISO20022.Semt022002.RepairReason12
    class ISO20022.Semt022002.RepairStatus17Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.RepairReason13~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.RepairStatus17Choice *-- ISO20022.Semt022002.RepairReason13
    class ISO20022.Semt022002.SecuritiesAccount37 {
        + Nm  : String
        + Tp  : ISO20022.Semt022002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Semt022002.SecuritiesAccount37 *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.SecuritiesSettlementTransactionAuditTrailReport002V05 {
        + StsTrl  : global::System.Collections.Generic.List~ISO20022.Semt022002.StatusTrail11~
        + AcctOwnr  : ISO20022.Semt022002.PartyIdentification156
        + BlckChainAdrOrWllt  : ISO20022.Semt022002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Semt022002.SecuritiesAccount37
        + TxId  : ISO20022.Semt022002.TransactionIdentifications34
        + QryRef  : String
        + Pgntn  : ISO20022.Semt022002.Pagination1
    }
    ISO20022.Semt022002.SecuritiesSettlementTransactionAuditTrailReport002V05 *-- ISO20022.Semt022002.StatusTrail11
    ISO20022.Semt022002.SecuritiesSettlementTransactionAuditTrailReport002V05 *-- ISO20022.Semt022002.PartyIdentification156
    ISO20022.Semt022002.SecuritiesSettlementTransactionAuditTrailReport002V05 *-- ISO20022.Semt022002.BlockChainAddressWallet7
    ISO20022.Semt022002.SecuritiesSettlementTransactionAuditTrailReport002V05 *-- ISO20022.Semt022002.SecuritiesAccount37
    ISO20022.Semt022002.SecuritiesSettlementTransactionAuditTrailReport002V05 *-- ISO20022.Semt022002.TransactionIdentifications34
    ISO20022.Semt022002.SecuritiesSettlementTransactionAuditTrailReport002V05 *-- ISO20022.Semt022002.Pagination1
    class ISO20022.Semt022002.SettlementStatus22Choice {
        + Prtry  : ISO20022.Semt022002.ProprietaryStatusAndReason7
        + Flng  : ISO20022.Semt022002.FailingStatus12Choice
        + Pdg  : ISO20022.Semt022002.PendingStatus50Choice
    }
    ISO20022.Semt022002.SettlementStatus22Choice *-- ISO20022.Semt022002.ProprietaryStatusAndReason7
    ISO20022.Semt022002.SettlementStatus22Choice *-- ISO20022.Semt022002.FailingStatus12Choice
    ISO20022.Semt022002.SettlementStatus22Choice *-- ISO20022.Semt022002.PendingStatus50Choice
    class ISO20022.Semt022002.StatusTrail11 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt022002.SupplementaryData1~
        + Sttld  : ISO20022.Semt022002.ProprietaryReason5
        + CxlSts  : ISO20022.Semt022002.ProcessingStatus93Choice
        + ModPrcgSts  : ISO20022.Semt022002.ModificationProcessingStatus11Choice
        + SttlmSts  : ISO20022.Semt022002.SettlementStatus22Choice
        + MtchgSts  : ISO20022.Semt022002.MatchingStatus30Choice
        + IfrrdMtchgSts  : ISO20022.Semt022002.MatchingStatus30Choice
        + PrcgSts  : ISO20022.Semt022002.ProcessingStatus92Choice
        + UsrId  : String
        + SndgOrgId  : ISO20022.Semt022002.OrganisationIdentification32
        + StsDt  : DateTime
    }
    ISO20022.Semt022002.StatusTrail11 *-- ISO20022.Semt022002.SupplementaryData1
    ISO20022.Semt022002.StatusTrail11 *-- ISO20022.Semt022002.ProprietaryReason5
    ISO20022.Semt022002.StatusTrail11 *-- ISO20022.Semt022002.ProcessingStatus93Choice
    ISO20022.Semt022002.StatusTrail11 *-- ISO20022.Semt022002.ModificationProcessingStatus11Choice
    ISO20022.Semt022002.StatusTrail11 *-- ISO20022.Semt022002.SettlementStatus22Choice
    ISO20022.Semt022002.StatusTrail11 *-- ISO20022.Semt022002.MatchingStatus30Choice
    ISO20022.Semt022002.StatusTrail11 *-- ISO20022.Semt022002.MatchingStatus30Choice
    ISO20022.Semt022002.StatusTrail11 *-- ISO20022.Semt022002.ProcessingStatus92Choice
    ISO20022.Semt022002.StatusTrail11 *-- ISO20022.Semt022002.OrganisationIdentification32
    class ISO20022.Semt022002.SupplementaryData1 {
        + Envlp  : ISO20022.Semt022002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Semt022002.SupplementaryData1 *-- ISO20022.Semt022002.SupplementaryDataEnvelope1
    class ISO20022.Semt022002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Semt022002.TransactionIdentifications34 {
        + PrcrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    class ISO20022.Semt022002.UnmatchedReason12Code {
        DCMX = 1
        DMCT = 2
        DDAT = 3
        UNBR = 4
        DELN = 5
        DTRD = 6
        TXST = 7
        SETR = 8
        SETS = 9
        DMON = 10
        SAFE = 11
        RTGS = 12
        REGD = 13
        IEXE = 14
        ICUS = 15
        ICAG = 16
        DEPT = 17
        PODU = 18
        PLCE = 19
        INPS = 20
        PHYS = 21
        FRAP = 22
        OTHR = 23
        DTRA = 24
        NMAS = 25
        CMIS = 26
        MIME = 27
        LATE = 28
        LEOG = 29
        DQUA = 30
        DSEC = 31
        DDEA = 32
        NCRR = 33
        CLAT = 34
        CPCA = 35
        IIND = 36
        ACRU = 37
        ADEA = 38
    }
    class ISO20022.Semt022002.UnmatchedReason19 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022002.UnmatchedReason26Choice
    }
    ISO20022.Semt022002.UnmatchedReason19 *-- ISO20022.Semt022002.UnmatchedReason26Choice
    class ISO20022.Semt022002.UnmatchedReason26Choice {
        + Prtry  : ISO20022.Semt022002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt022002.UnmatchedReason26Choice *-- ISO20022.Semt022002.GenericIdentification47
    class ISO20022.Semt022002.UnmatchedStatus20Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022002.UnmatchedReason19~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022002.UnmatchedStatus20Choice *-- ISO20022.Semt022002.UnmatchedReason19
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

## Value ISO20022.Semt022002.AcknowledgedAcceptedStatus25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.AcknowledgementReason13>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.AcknowledgedAcceptedStatus30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.AcknowledgementReason18>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.AcknowledgedAcceptedStatus31Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.AcknowledgementReason19>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.AcknowledgementReason13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.AcknowledgementReason16Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.AcknowledgementReason16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022002.AcknowledgementReason18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.AcknowledgementReason21Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.AcknowledgementReason19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.AcknowledgementReason22Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.AcknowledgementReason21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022002.AcknowledgementReason22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt022002.AcknowledgementReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||SMPG|Int32||XmlEnum("""SMPG""")|2|
||ADEA|Int32||XmlEnum("""ADEA""")|3|

---

## Enum ISO20022.Semt022002.AcknowledgementReason5Code


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

## Enum ISO20022.Semt022002.AcknowledgementReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LATE|Int32||XmlEnum("""LATE""")|1|
||NSTP|Int32||XmlEnum("""NSTP""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||SMPG|Int32||XmlEnum("""SMPG""")|4|
||ADEA|Int32||XmlEnum("""ADEA""")|5|

---

## Value ISO20022.Semt022002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Semt022002.CancellationReason18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.CancellationReason28Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.CancellationReason24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.CancellationReason37Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.CancellationReason28Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022002.CancellationReason37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022002.CancellationStatus20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.CancellationReason18>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.CancellationStatus25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.CancellationReason24>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Semt022002.CancelledStatusReason16Code


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

## Enum ISO20022.Semt022002.CancelledStatusReason5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||CANI|Int32||XmlEnum("""CANI""")|2|

---

## Value ISO20022.Semt022002.DeniedReason16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.DeniedReason21Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.DeniedReason17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.DeniedReason24Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.DeniedReason21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022002.DeniedReason24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt022002.DeniedReason4Code


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

## Enum ISO20022.Semt022002.DeniedReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDRG|Int32||XmlEnum("""CDRG""")|1|
||OTHR|Int32||XmlEnum("""OTHR""")|2|
||LATE|Int32||XmlEnum("""LATE""")|3|
||DREP|Int32||XmlEnum("""DREP""")|4|
||DPRG|Int32||XmlEnum("""DPRG""")|5|
||DSET|Int32||XmlEnum("""DSET""")|6|
||DCAN|Int32||XmlEnum("""DCAN""")|7|
||CDRE|Int32||XmlEnum("""CDRE""")|8|
||CDCY|Int32||XmlEnum("""CDCY""")|9|
||ADEA|Int32||XmlEnum("""ADEA""")|10|

---

## Value ISO20022.Semt022002.DeniedStatus19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.DeniedReason17>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.DeniedStatus21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.DeniedReason16>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Type ISO20022.Semt022002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmTxAudtTrlRpt|ISO20022.Semt022002.SecuritiesSettlementTransactionAuditTrailReport002V05||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmTxAudtTrlRpt))|

---

## Value ISO20022.Semt022002.FailingReason10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.FailingReason11Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.FailingReason11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt022002.FailingReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INBC|Int32||XmlEnum("""INBC""")|1|
||CVAL|Int32||XmlEnum("""CVAL""")|2|
||CSDH|Int32||XmlEnum("""CSDH""")|3|
||CDLR|Int32||XmlEnum("""CDLR""")|4|
||PRSY|Int32||XmlEnum("""PRSY""")|5|
||CERT|Int32||XmlEnum("""CERT""")|6|
||SETS|Int32||XmlEnum("""SETS""")|7|
||REGT|Int32||XmlEnum("""REGT""")|8|
||PRCY|Int32||XmlEnum("""PRCY""")|9|
||LIQU|Int32||XmlEnum("""LIQU""")|10|
||LATE|Int32||XmlEnum("""LATE""")|11|
||LAAW|Int32||XmlEnum("""LAAW""")|12|
||FROZ|Int32||XmlEnum("""FROZ""")|13|
||DKNY|Int32||XmlEnum("""DKNY""")|14|
||DISA|Int32||XmlEnum("""DISA""")|15|
||DENO|Int32||XmlEnum("""DENO""")|16|
||CLHT|Int32||XmlEnum("""CLHT""")|17|
||BOTH|Int32||XmlEnum("""BOTH""")|18|
||BENO|Int32||XmlEnum("""BENO""")|19|
||PHCK|Int32||XmlEnum("""PHCK""")|20|
||OTHR|Int32||XmlEnum("""OTHR""")|21|
||IAAD|Int32||XmlEnum("""IAAD""")|22|
||MINO|Int32||XmlEnum("""MINO""")|23|
||CPEC|Int32||XmlEnum("""CPEC""")|24|
||SBLO|Int32||XmlEnum("""SBLO""")|25|
||CYCL|Int32||XmlEnum("""CYCL""")|26|
||BATC|Int32||XmlEnum("""BATC""")|27|
||SDUT|Int32||XmlEnum("""SDUT""")|28|
||REFS|Int32||XmlEnum("""REFS""")|29|
||NCON|Int32||XmlEnum("""NCON""")|30|
||MONY|Int32||XmlEnum("""MONY""")|31|
||LALO|Int32||XmlEnum("""LALO""")|32|
||LACK|Int32||XmlEnum("""LACK""")|33|
||LINK|Int32||XmlEnum("""LINK""")|34|
||INCA|Int32||XmlEnum("""INCA""")|35|
||FLIM|Int32||XmlEnum("""FLIM""")|36|
||DEPO|Int32||XmlEnum("""DEPO""")|37|
||COLL|Int32||XmlEnum("""COLL""")|38|
||YCOL|Int32||XmlEnum("""YCOL""")|39|
||CMON|Int32||XmlEnum("""CMON""")|40|
||NOFX|Int32||XmlEnum("""NOFX""")|41|
||PART|Int32||XmlEnum("""PART""")|42|
||PREA|Int32||XmlEnum("""PREA""")|43|
||GLOB|Int32||XmlEnum("""GLOB""")|44|
||MUNO|Int32||XmlEnum("""MUNO""")|45|
||CLAC|Int32||XmlEnum("""CLAC""")|46|
||NEWI|Int32||XmlEnum("""NEWI""")|47|
||CHAS|Int32||XmlEnum("""CHAS""")|48|
||BLOC|Int32||XmlEnum("""BLOC""")|49|
||DOCC|Int32||XmlEnum("""DOCC""")|50|
||MLAT|Int32||XmlEnum("""MLAT""")|51|
||DOCY|Int32||XmlEnum("""DOCY""")|52|
||STCD|Int32||XmlEnum("""STCD""")|53|
||PHSE|Int32||XmlEnum("""PHSE""")|54|
||AWSH|Int32||XmlEnum("""AWSH""")|55|
||OBJT|Int32||XmlEnum("""OBJT""")|56|
||CAIS|Int32||XmlEnum("""CAIS""")|57|
||CANR|Int32||XmlEnum("""CANR""")|58|
||ADEA|Int32||XmlEnum("""ADEA""")|59|
||CLAT|Int32||XmlEnum("""CLAT""")|60|
||BYIY|Int32||XmlEnum("""BYIY""")|61|
||AWMO|Int32||XmlEnum("""AWMO""")|62|

---

## Value ISO20022.Semt022002.FailingStatus12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.FailingReason10>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt022002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt022002.GenericOrganisationIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Semt022002.OrganisationIdentificationSchemeName2Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validElement(SchmeNm),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Semt022002.MatchingStatus30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.ProprietaryStatusAndReason7||XmlElement()||
|+|Umtchd|ISO20022.Semt022002.UnmatchedStatus20Choice||XmlElement()||
|+|Mtchd|ISO20022.Semt022002.ProprietaryReason5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Umtchd),validElement(Mtchd),validChoice(Prtry,Umtchd,Mtchd))|

---

## Value ISO20022.Semt022002.ModificationProcessingStatus11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.ProprietaryStatusAndReason7||XmlElement()||
|+|Modfd|ISO20022.Semt022002.ModificationStatus5Choice||XmlElement()||
|+|Rprd|ISO20022.Semt022002.RepairStatus17Choice||XmlElement()||
|+|Rjctd|ISO20022.Semt022002.RejectionStatus42Choice||XmlElement()||
|+|Dnd|ISO20022.Semt022002.DeniedStatus19Choice||XmlElement()||
|+|PdgPrcg|ISO20022.Semt022002.PendingProcessingStatus16Choice||XmlElement()||
|+|AckdAccptd|ISO20022.Semt022002.AcknowledgedAcceptedStatus30Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Modfd),validElement(Rprd),validElement(Rjctd),validElement(Dnd),validElement(PdgPrcg),validElement(AckdAccptd),validChoice(Prtry,Modfd,Rprd,Rjctd,Dnd,PdgPrcg,AckdAccptd))|

---

## Value ISO20022.Semt022002.ModificationReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.ModificationReason5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.ModificationReason5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022002.ModificationStatus5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.ModificationReason5>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Semt022002.ModifiedStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||MDBY|Int32||XmlEnum("""MDBY""")|2|

---

## Enum ISO20022.Semt022002.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Semt022002.OrganisationIdentification32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Semt022002.GenericOrganisationIdentification2>||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt022002.OrganisationIdentificationSchemeName2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022002.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Semt022002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Semt022002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Semt022002.PartyIdentification156


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt022002.PartyIdentification136Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt022002.PendingProcessingReason12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.PendingProcessingReason14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.PendingProcessingReason13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.PendingProcessingReason15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.PendingProcessingReason14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022002.PendingProcessingReason15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt022002.PendingProcessingReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INBC|Int32||XmlEnum("""INBC""")|1|
||CDAC|Int32||XmlEnum("""CDAC""")|2|
||CDLR|Int32||XmlEnum("""CDLR""")|3|
||CDEL|Int32||XmlEnum("""CDEL""")|4|
||CVAL|Int32||XmlEnum("""CVAL""")|5|
||CSDH|Int32||XmlEnum("""CSDH""")|6|
||CERT|Int32||XmlEnum("""CERT""")|7|
||LIQU|Int32||XmlEnum("""LIQU""")|8|
||DENO|Int32||XmlEnum("""DENO""")|9|
||OTHR|Int32||XmlEnum("""OTHR""")|10|
||MINO|Int32||XmlEnum("""MINO""")|11|
||MONY|Int32||XmlEnum("""MONY""")|12|
||LALO|Int32||XmlEnum("""LALO""")|13|
||LACK|Int32||XmlEnum("""LACK""")|14|
||NEXT|Int32||XmlEnum("""NEXT""")|15|
||FLIM|Int32||XmlEnum("""FLIM""")|16|
||COLL|Int32||XmlEnum("""COLL""")|17|
||YCOL|Int32||XmlEnum("""YCOL""")|18|
||GLOB|Int32||XmlEnum("""GLOB""")|19|
||MUNO|Int32||XmlEnum("""MUNO""")|20|
||BLOC|Int32||XmlEnum("""BLOC""")|21|
||NOFX|Int32||XmlEnum("""NOFX""")|22|
||DOCY|Int32||XmlEnum("""DOCY""")|23|
||CAIS|Int32||XmlEnum("""CAIS""")|24|
||ADEA|Int32||XmlEnum("""ADEA""")|25|

---

## Enum ISO20022.Semt022002.PendingProcessingReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CERT|Int32||XmlEnum("""CERT""")|1|
||DENO|Int32||XmlEnum("""DENO""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||MINO|Int32||XmlEnum("""MINO""")|4|
||NEXT|Int32||XmlEnum("""NEXT""")|5|
||MUNO|Int32||XmlEnum("""MUNO""")|6|
||BLOC|Int32||XmlEnum("""BLOC""")|7|
||ADEA|Int32||XmlEnum("""ADEA""")|8|

---

## Value ISO20022.Semt022002.PendingProcessingStatus15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.PendingProcessingReason12>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.PendingProcessingStatus16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.PendingProcessingReason13>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.PendingReason20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.PendingReason37Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.PendingReason24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.PendingReason41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.PendingReason25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.PendingReason42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Enum ISO20022.Semt022002.PendingReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INBC|Int32||XmlEnum("""INBC""")|1|
||CDLR|Int32||XmlEnum("""CDLR""")|2|
||CVAL|Int32||XmlEnum("""CVAL""")|3|
||CSDH|Int32||XmlEnum("""CSDH""")|4|
||PRSY|Int32||XmlEnum("""PRSY""")|5|
||CERT|Int32||XmlEnum("""CERT""")|6|
||SETS|Int32||XmlEnum("""SETS""")|7|
||REGT|Int32||XmlEnum("""REGT""")|8|
||PRCY|Int32||XmlEnum("""PRCY""")|9|
||LIQU|Int32||XmlEnum("""LIQU""")|10|
||LATE|Int32||XmlEnum("""LATE""")|11|
||LAAW|Int32||XmlEnum("""LAAW""")|12|
||FROZ|Int32||XmlEnum("""FROZ""")|13|
||DKNY|Int32||XmlEnum("""DKNY""")|14|
||DISA|Int32||XmlEnum("""DISA""")|15|
||DENO|Int32||XmlEnum("""DENO""")|16|
||CLHT|Int32||XmlEnum("""CLHT""")|17|
||BOTH|Int32||XmlEnum("""BOTH""")|18|
||BENO|Int32||XmlEnum("""BENO""")|19|
||PHCK|Int32||XmlEnum("""PHCK""")|20|
||OTHR|Int32||XmlEnum("""OTHR""")|21|
||IAAD|Int32||XmlEnum("""IAAD""")|22|
||MINO|Int32||XmlEnum("""MINO""")|23|
||CPEC|Int32||XmlEnum("""CPEC""")|24|
||SBLO|Int32||XmlEnum("""SBLO""")|25|
||CYCL|Int32||XmlEnum("""CYCL""")|26|
||BATC|Int32||XmlEnum("""BATC""")|27|
||SDUT|Int32||XmlEnum("""SDUT""")|28|
||REFS|Int32||XmlEnum("""REFS""")|29|
||NCON|Int32||XmlEnum("""NCON""")|30|
||MONY|Int32||XmlEnum("""MONY""")|31|
||LALO|Int32||XmlEnum("""LALO""")|32|
||LACK|Int32||XmlEnum("""LACK""")|33|
||FUTU|Int32||XmlEnum("""FUTU""")|34|
||LINK|Int32||XmlEnum("""LINK""")|35|
||INCA|Int32||XmlEnum("""INCA""")|36|
||FLIM|Int32||XmlEnum("""FLIM""")|37|
||DEPO|Int32||XmlEnum("""DEPO""")|38|
||COLL|Int32||XmlEnum("""COLL""")|39|
||YCOL|Int32||XmlEnum("""YCOL""")|40|
||CMON|Int32||XmlEnum("""CMON""")|41|
||NOFX|Int32||XmlEnum("""NOFX""")|42|
||NMAS|Int32||XmlEnum("""NMAS""")|43|
||PART|Int32||XmlEnum("""PART""")|44|
||PREA|Int32||XmlEnum("""PREA""")|45|
||GLOB|Int32||XmlEnum("""GLOB""")|46|
||MUNO|Int32||XmlEnum("""MUNO""")|47|
||CLAC|Int32||XmlEnum("""CLAC""")|48|
||NEWI|Int32||XmlEnum("""NEWI""")|49|
||CHAS|Int32||XmlEnum("""CHAS""")|50|
||BLOC|Int32||XmlEnum("""BLOC""")|51|
||DOCC|Int32||XmlEnum("""DOCC""")|52|
||DOCY|Int32||XmlEnum("""DOCY""")|53|
||TAMM|Int32||XmlEnum("""TAMM""")|54|
||PHSE|Int32||XmlEnum("""PHSE""")|55|
||AWSH|Int32||XmlEnum("""AWSH""")|56|
||REFU|Int32||XmlEnum("""REFU""")|57|
||CAIS|Int32||XmlEnum("""CAIS""")|58|
||ADEA|Int32||XmlEnum("""ADEA""")|59|
||AWMO|Int32||XmlEnum("""AWMO""")|60|

---

## Value ISO20022.Semt022002.PendingReason37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022002.PendingReason41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022002.PendingReason42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt022002.PendingReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDRE|Int32||XmlEnum("""CDRE""")|1|
||CDCY|Int32||XmlEnum("""CDCY""")|2|
||CDRG|Int32||XmlEnum("""CDRG""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||CONF|Int32||XmlEnum("""CONF""")|5|
||ADEA|Int32||XmlEnum("""ADEA""")|6|

---

## Enum ISO20022.Semt022002.PendingReason9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INBC|Int32||XmlEnum("""INBC""")|1|
||CDAC|Int32||XmlEnum("""CDAC""")|2|
||CDRE|Int32||XmlEnum("""CDRE""")|3|
||CDCY|Int32||XmlEnum("""CDCY""")|4|
||CDRG|Int32||XmlEnum("""CDRG""")|5|
||OTHR|Int32||XmlEnum("""OTHR""")|6|
||CONF|Int32||XmlEnum("""CONF""")|7|
||ADEA|Int32||XmlEnum("""ADEA""")|8|

---

## Value ISO20022.Semt022002.PendingStatus46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.PendingReason20>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.PendingStatus50Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.PendingReason24>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.PendingStatus51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.PendingReason25>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.ProcessingStatus92Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ModReqd|ISO20022.Semt022002.ProprietaryReason5||XmlElement()||
|+|CxlReqd|ISO20022.Semt022002.ProprietaryReason5||XmlElement()||
|+|Prtry|ISO20022.Semt022002.ProprietaryStatusAndReason7||XmlElement()||
|+|PdgCxl|ISO20022.Semt022002.PendingStatus46Choice||XmlElement()||
|+|Canc|ISO20022.Semt022002.CancellationStatus25Choice||XmlElement()||
|+|Rpr|ISO20022.Semt022002.RepairStatus16Choice||XmlElement()||
|+|Rjctd|ISO20022.Semt022002.RejectionStatus41Choice||XmlElement()||
|+|PdgPrcg|ISO20022.Semt022002.PendingProcessingStatus15Choice||XmlElement()||
|+|AckdAccptd|ISO20022.Semt022002.AcknowledgedAcceptedStatus25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ModReqd),validElement(CxlReqd),validElement(Prtry),validElement(PdgCxl),validElement(Canc),validElement(Rpr),validElement(Rjctd),validElement(PdgPrcg),validElement(AckdAccptd),validChoice(ModReqd,CxlReqd,Prtry,PdgCxl,Canc,Rpr,Rjctd,PdgPrcg,AckdAccptd))|

---

## Value ISO20022.Semt022002.ProcessingStatus93Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Canc|ISO20022.Semt022002.CancellationStatus20Choice||XmlElement()||
|+|Dnd|ISO20022.Semt022002.DeniedStatus21Choice||XmlElement()||
|+|Prtry|ISO20022.Semt022002.ProprietaryStatusAndReason7||XmlElement()||
|+|AckdAccptd|ISO20022.Semt022002.AcknowledgedAcceptedStatus31Choice||XmlElement()||
|+|Rpr|ISO20022.Semt022002.RejectionOrRepairStatus46Choice||XmlElement()||
|+|Rjctd|ISO20022.Semt022002.RejectionOrRepairStatus47Choice||XmlElement()||
|+|PdgCxl|ISO20022.Semt022002.PendingStatus51Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Canc),validElement(Dnd),validElement(Prtry),validElement(AckdAccptd),validElement(Rpr),validElement(Rjctd),validElement(PdgCxl),validChoice(Canc,Dnd,Prtry,AckdAccptd,Rpr,Rjctd,PdgCxl))|

---

## Value ISO20022.Semt022002.ProprietaryReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Rsn))|

---

## Value ISO20022.Semt022002.ProprietaryStatusAndReason7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Semt022002.ProprietaryReason5>||XmlElement()||
|+|PrtrySts|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Semt022002.RejectionAndRepairReason41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022002.RejectionAndRepairReason42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022002.RejectionOrRepairReason41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.RejectionAndRepairReason41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.RejectionOrRepairReason42


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.RejectionAndRepairReason42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.RejectionOrRepairStatus46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.RejectionOrRepairReason41>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.RejectionOrRepairStatus47Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.RejectionOrRepairReason42>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.RejectionReason47Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022002.RejectionReason48Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022002.RejectionReason62


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.RejectionReason47Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.RejectionReason63


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.RejectionReason48Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Enum ISO20022.Semt022002.RejectionReason71Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INVL|Int32||XmlEnum("""INVL""")|1|
||INVM|Int32||XmlEnum("""INVM""")|2|
||REFE|Int32||XmlEnum("""REFE""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||NRGN|Int32||XmlEnum("""NRGN""")|5|
||NRGM|Int32||XmlEnum("""NRGM""")|6|
||SAFE|Int32||XmlEnum("""SAFE""")|7|
||LATE|Int32||XmlEnum("""LATE""")|8|
||ADEA|Int32||XmlEnum("""ADEA""")|9|

---

## Enum ISO20022.Semt022002.RejectionReason72Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VALR|Int32||XmlEnum("""VALR""")|1|
||INVN|Int32||XmlEnum("""INVN""")|2|
||INVB|Int32||XmlEnum("""INVB""")|3|
||INVL|Int32||XmlEnum("""INVL""")|4|
||IEXE|Int32||XmlEnum("""IEXE""")|5|
||DEPT|Int32||XmlEnum("""DEPT""")|6|
||ICAG|Int32||XmlEnum("""ICAG""")|7|
||ICUS|Int32||XmlEnum("""ICUS""")|8|
||OTHR|Int32||XmlEnum("""OTHR""")|9|
||INPS|Int32||XmlEnum("""INPS""")|10|
||SDUT|Int32||XmlEnum("""SDUT""")|11|
||SETR|Int32||XmlEnum("""SETR""")|12|
||DDAT|Int32||XmlEnum("""DDAT""")|13|
||CASY|Int32||XmlEnum("""CASY""")|14|
||CAEV|Int32||XmlEnum("""CAEV""")|15|
||IIND|Int32||XmlEnum("""IIND""")|16|
||SETS|Int32||XmlEnum("""SETS""")|17|
||TXST|Int32||XmlEnum("""TXST""")|18|
||MUNO|Int32||XmlEnum("""MUNO""")|19|
||BATC|Int32||XmlEnum("""BATC""")|20|
||MINO|Int32||XmlEnum("""MINO""")|21|
||DMON|Int32||XmlEnum("""DMON""")|22|
||REFE|Int32||XmlEnum("""REFE""")|23|
||PHYS|Int32||XmlEnum("""PHYS""")|24|
||NCRR|Int32||XmlEnum("""NCRR""")|25|
||RTGS|Int32||XmlEnum("""RTGS""")|26|
||PLCE|Int32||XmlEnum("""PLCE""")|27|
||DTRD|Int32||XmlEnum("""DTRD""")|28|
||DDEA|Int32||XmlEnum("""DDEA""")|29|
||CASH|Int32||XmlEnum("""CASH""")|30|
||LATE|Int32||XmlEnum("""LATE""")|31|
||DSEC|Int32||XmlEnum("""DSEC""")|32|
||ADEA|Int32||XmlEnum("""ADEA""")|33|
||DQUA|Int32||XmlEnum("""DQUA""")|34|
||SAFE|Int32||XmlEnum("""SAFE""")|35|

---

## Enum ISO20022.Semt022002.RejectionReason73Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VALR|Int32||XmlEnum("""VALR""")|1|
||INVN|Int32||XmlEnum("""INVN""")|2|
||INVL|Int32||XmlEnum("""INVL""")|3|
||INVB|Int32||XmlEnum("""INVB""")|4|
||IEXE|Int32||XmlEnum("""IEXE""")|5|
||DEPT|Int32||XmlEnum("""DEPT""")|6|
||ICAG|Int32||XmlEnum("""ICAG""")|7|
||ICUS|Int32||XmlEnum("""ICUS""")|8|
||OTHR|Int32||XmlEnum("""OTHR""")|9|
||INPS|Int32||XmlEnum("""INPS""")|10|
||SDUT|Int32||XmlEnum("""SDUT""")|11|
||SETR|Int32||XmlEnum("""SETR""")|12|
||DDAT|Int32||XmlEnum("""DDAT""")|13|
||CASY|Int32||XmlEnum("""CASY""")|14|
||CAEV|Int32||XmlEnum("""CAEV""")|15|
||IIND|Int32||XmlEnum("""IIND""")|16|
||SETS|Int32||XmlEnum("""SETS""")|17|
||TXST|Int32||XmlEnum("""TXST""")|18|
||MUNO|Int32||XmlEnum("""MUNO""")|19|
||BATC|Int32||XmlEnum("""BATC""")|20|
||MINO|Int32||XmlEnum("""MINO""")|21|
||DMON|Int32||XmlEnum("""DMON""")|22|
||REFE|Int32||XmlEnum("""REFE""")|23|
||PHYS|Int32||XmlEnum("""PHYS""")|24|
||NCRR|Int32||XmlEnum("""NCRR""")|25|
||RTGS|Int32||XmlEnum("""RTGS""")|26|
||PLCE|Int32||XmlEnum("""PLCE""")|27|
||DTRD|Int32||XmlEnum("""DTRD""")|28|
||DDEA|Int32||XmlEnum("""DDEA""")|29|
||CASH|Int32||XmlEnum("""CASH""")|30|
||LATE|Int32||XmlEnum("""LATE""")|31|
||DSEC|Int32||XmlEnum("""DSEC""")|32|
||ADEA|Int32||XmlEnum("""ADEA""")|33|
||DQUA|Int32||XmlEnum("""DQUA""")|34|
||SAFE|Int32||XmlEnum("""SAFE""")|35|

---

## Enum ISO20022.Semt022002.RejectionReason74Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||NRGM|Int32||XmlEnum("""NRGM""")|2|
||REFE|Int32||XmlEnum("""REFE""")|3|
||NRGN|Int32||XmlEnum("""NRGN""")|4|
||LATE|Int32||XmlEnum("""LATE""")|5|
||ADEA|Int32||XmlEnum("""ADEA""")|6|
||SAFE|Int32||XmlEnum("""SAFE""")|7|

---

## Value ISO20022.Semt022002.RejectionStatus41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.RejectionReason62>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.RejectionStatus42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.RejectionReason63>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.RepairReason12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.RepairReason14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.RepairReason13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.RepairReason14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.RepairReason14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt022002.RepairReason4Code


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

## Value ISO20022.Semt022002.RepairStatus16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.RepairReason12>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.RepairStatus17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.RepairReason13>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022002.SecuritiesAccount37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Aspect ISO20022.Semt022002.SecuritiesSettlementTransactionAuditTrailReport002V05


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StsTrl|global::System.Collections.Generic.List<ISO20022.Semt022002.StatusTrail11>||XmlElement()||
|+|AcctOwnr|ISO20022.Semt022002.PartyIdentification156||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt022002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt022002.SecuritiesAccount37||XmlElement()||
|+|TxId|ISO20022.Semt022002.TransactionIdentifications34||XmlElement()||
|+|QryRef|String||XmlElement()||
|+|Pgntn|ISO20022.Semt022002.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""StsTrl""",StsTrl),validElement(StsTrl),validElement(AcctOwnr),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(TxId),validPattern("""QryRef""",QryRef,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Pgntn))|

---

## Value ISO20022.Semt022002.SettlementStatus22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.ProprietaryStatusAndReason7||XmlElement()||
|+|Flng|ISO20022.Semt022002.FailingStatus12Choice||XmlElement()||
|+|Pdg|ISO20022.Semt022002.PendingStatus50Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Flng),validElement(Pdg),validChoice(Prtry,Flng,Pdg))|

---

## Value ISO20022.Semt022002.StatusTrail11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt022002.SupplementaryData1>||XmlElement()||
|+|Sttld|ISO20022.Semt022002.ProprietaryReason5||XmlElement()||
|+|CxlSts|ISO20022.Semt022002.ProcessingStatus93Choice||XmlElement()||
|+|ModPrcgSts|ISO20022.Semt022002.ModificationProcessingStatus11Choice||XmlElement()||
|+|SttlmSts|ISO20022.Semt022002.SettlementStatus22Choice||XmlElement()||
|+|MtchgSts|ISO20022.Semt022002.MatchingStatus30Choice||XmlElement()||
|+|IfrrdMtchgSts|ISO20022.Semt022002.MatchingStatus30Choice||XmlElement()||
|+|PrcgSts|ISO20022.Semt022002.ProcessingStatus92Choice||XmlElement()||
|+|UsrId|String||XmlElement()||
|+|SndgOrgId|ISO20022.Semt022002.OrganisationIdentification32||XmlElement()||
|+|StsDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Sttld),validElement(CxlSts),validElement(ModPrcgSts),validElement(SttlmSts),validElement(MtchgSts),validElement(IfrrdMtchgSts),validElement(PrcgSts),validPattern("""UsrId""",UsrId,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validElement(SndgOrgId))|

---

## Value ISO20022.Semt022002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Semt022002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Semt022002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt022002.TransactionIdentifications34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrcrTxId""",PrcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktInfrstrctrTxId""",MktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrTxId""",AcctSvcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctOwnrTxId""",AcctOwnrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Semt022002.UnmatchedReason12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DCMX|Int32||XmlEnum("""DCMX""")|1|
||DMCT|Int32||XmlEnum("""DMCT""")|2|
||DDAT|Int32||XmlEnum("""DDAT""")|3|
||UNBR|Int32||XmlEnum("""UNBR""")|4|
||DELN|Int32||XmlEnum("""DELN""")|5|
||DTRD|Int32||XmlEnum("""DTRD""")|6|
||TXST|Int32||XmlEnum("""TXST""")|7|
||SETR|Int32||XmlEnum("""SETR""")|8|
||SETS|Int32||XmlEnum("""SETS""")|9|
||DMON|Int32||XmlEnum("""DMON""")|10|
||SAFE|Int32||XmlEnum("""SAFE""")|11|
||RTGS|Int32||XmlEnum("""RTGS""")|12|
||REGD|Int32||XmlEnum("""REGD""")|13|
||IEXE|Int32||XmlEnum("""IEXE""")|14|
||ICUS|Int32||XmlEnum("""ICUS""")|15|
||ICAG|Int32||XmlEnum("""ICAG""")|16|
||DEPT|Int32||XmlEnum("""DEPT""")|17|
||PODU|Int32||XmlEnum("""PODU""")|18|
||PLCE|Int32||XmlEnum("""PLCE""")|19|
||INPS|Int32||XmlEnum("""INPS""")|20|
||PHYS|Int32||XmlEnum("""PHYS""")|21|
||FRAP|Int32||XmlEnum("""FRAP""")|22|
||OTHR|Int32||XmlEnum("""OTHR""")|23|
||DTRA|Int32||XmlEnum("""DTRA""")|24|
||NMAS|Int32||XmlEnum("""NMAS""")|25|
||CMIS|Int32||XmlEnum("""CMIS""")|26|
||MIME|Int32||XmlEnum("""MIME""")|27|
||LATE|Int32||XmlEnum("""LATE""")|28|
||LEOG|Int32||XmlEnum("""LEOG""")|29|
||DQUA|Int32||XmlEnum("""DQUA""")|30|
||DSEC|Int32||XmlEnum("""DSEC""")|31|
||DDEA|Int32||XmlEnum("""DDEA""")|32|
||NCRR|Int32||XmlEnum("""NCRR""")|33|
||CLAT|Int32||XmlEnum("""CLAT""")|34|
||CPCA|Int32||XmlEnum("""CPCA""")|35|
||IIND|Int32||XmlEnum("""IIND""")|36|
||ACRU|Int32||XmlEnum("""ACRU""")|37|
||ADEA|Int32||XmlEnum("""ADEA""")|38|

---

## Value ISO20022.Semt022002.UnmatchedReason19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022002.UnmatchedReason26Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Semt022002.UnmatchedReason26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022002.UnmatchedStatus20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022002.UnmatchedReason19>||XmlElement()||
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

