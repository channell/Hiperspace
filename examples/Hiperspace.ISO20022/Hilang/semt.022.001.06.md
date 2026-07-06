# semt.022.001.06
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt022001.AcknowledgedAcceptedStatus21Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.AcknowledgementReason9~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.AcknowledgedAcceptedStatus21Choice *-- ISO20022.Semt022001.AcknowledgementReason9
    class ISO20022.Semt022001.AcknowledgedAcceptedStatus23Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.AcknowledgementReason11~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.AcknowledgedAcceptedStatus23Choice *-- ISO20022.Semt022001.AcknowledgementReason11
    class ISO20022.Semt022001.AcknowledgedAcceptedStatus24Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.AcknowledgementReason12~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.AcknowledgedAcceptedStatus24Choice *-- ISO20022.Semt022001.AcknowledgementReason12
    class ISO20022.Semt022001.AcknowledgementReason11 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.AcknowledgementReason14Choice
    }
    ISO20022.Semt022001.AcknowledgementReason11 *-- ISO20022.Semt022001.AcknowledgementReason14Choice
    class ISO20022.Semt022001.AcknowledgementReason12 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.AcknowledgementReason15Choice
    }
    ISO20022.Semt022001.AcknowledgementReason12 *-- ISO20022.Semt022001.AcknowledgementReason15Choice
    class ISO20022.Semt022001.AcknowledgementReason12Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.AcknowledgementReason12Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.AcknowledgementReason14Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.AcknowledgementReason14Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.AcknowledgementReason15Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.AcknowledgementReason15Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.AcknowledgementReason3Code {
        OTHR = 1
        SMPG = 2
        ADEA = 3
    }
    class ISO20022.Semt022001.AcknowledgementReason5Code {
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
    class ISO20022.Semt022001.AcknowledgementReason6Code {
        LATE = 1
        NSTP = 2
        OTHR = 3
        SMPG = 4
        ADEA = 5
    }
    class ISO20022.Semt022001.AcknowledgementReason9 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.AcknowledgementReason12Choice
    }
    ISO20022.Semt022001.AcknowledgementReason9 *-- ISO20022.Semt022001.AcknowledgementReason12Choice
    class ISO20022.Semt022001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Semt022001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Semt022001.BlockChainAddressWallet3 *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.CancellationReason10 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.CancellationReason21Choice
    }
    ISO20022.Semt022001.CancellationReason10 *-- ISO20022.Semt022001.CancellationReason21Choice
    class ISO20022.Semt022001.CancellationReason21Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.CancellationReason21Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.CancellationReason22 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.CancellationReason36Choice
    }
    ISO20022.Semt022001.CancellationReason22 *-- ISO20022.Semt022001.CancellationReason36Choice
    class ISO20022.Semt022001.CancellationReason36Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.CancellationReason36Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.CancellationStatus15Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.CancellationReason10~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.CancellationStatus15Choice *-- ISO20022.Semt022001.CancellationReason10
    class ISO20022.Semt022001.CancellationStatus24Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.CancellationReason22~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.CancellationStatus24Choice *-- ISO20022.Semt022001.CancellationReason22
    class ISO20022.Semt022001.CancelledStatusReason16Code {
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
    class ISO20022.Semt022001.CancelledStatusReason5Code {
        OTHR = 1
        CANI = 2
    }
    class ISO20022.Semt022001.DeniedReason10 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.DeniedReason15Choice
    }
    ISO20022.Semt022001.DeniedReason10 *-- ISO20022.Semt022001.DeniedReason15Choice
    class ISO20022.Semt022001.DeniedReason11 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.DeniedReason16Choice
    }
    ISO20022.Semt022001.DeniedReason11 *-- ISO20022.Semt022001.DeniedReason16Choice
    class ISO20022.Semt022001.DeniedReason15Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.DeniedReason15Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.DeniedReason16Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.DeniedReason16Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.DeniedReason4Code {
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
    class ISO20022.Semt022001.DeniedReason6Code {
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
    class ISO20022.Semt022001.DeniedStatus15Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.DeniedReason10~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.DeniedStatus15Choice *-- ISO20022.Semt022001.DeniedReason10
    class ISO20022.Semt022001.DeniedStatus16Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.DeniedReason11~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.DeniedStatus16Choice *-- ISO20022.Semt022001.DeniedReason11
    class ISO20022.Semt022001.FailingReason13 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.FailingReason18Choice
    }
    ISO20022.Semt022001.FailingReason13 *-- ISO20022.Semt022001.FailingReason18Choice
    class ISO20022.Semt022001.FailingReason18Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.FailingReason18Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.FailingReason5Code {
        PREL = 1
        PATD = 2
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
    class ISO20022.Semt022001.FailingStatus15Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.FailingReason13~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.FailingStatus15Choice *-- ISO20022.Semt022001.FailingReason13
    class ISO20022.Semt022001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt022001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt022001.GenericOrganisationIdentification1 {
        + Issr  : String
        + SchmeNm  : ISO20022.Semt022001.OrganisationIdentificationSchemeName1Choice
        + Id  : String
    }
    ISO20022.Semt022001.GenericOrganisationIdentification1 *-- ISO20022.Semt022001.OrganisationIdentificationSchemeName1Choice
    class ISO20022.Semt022001.MatchingStatus25Choice {
        + Prtry  : ISO20022.Semt022001.ProprietaryStatusAndReason6
        + Umtchd  : ISO20022.Semt022001.UnmatchedStatus17Choice
        + Mtchd  : ISO20022.Semt022001.ProprietaryReason4
    }
    ISO20022.Semt022001.MatchingStatus25Choice *-- ISO20022.Semt022001.ProprietaryStatusAndReason6
    ISO20022.Semt022001.MatchingStatus25Choice *-- ISO20022.Semt022001.UnmatchedStatus17Choice
    ISO20022.Semt022001.MatchingStatus25Choice *-- ISO20022.Semt022001.ProprietaryReason4
    class ISO20022.Semt022001.ModificationProcessingStatus10Choice {
        + Prtry  : ISO20022.Semt022001.ProprietaryStatusAndReason6
        + Modfd  : ISO20022.Semt022001.ModificationStatus4Choice
        + Rprd  : ISO20022.Semt022001.RepairStatus13Choice
        + Rjctd  : ISO20022.Semt022001.RejectionStatus37Choice
        + Dnd  : ISO20022.Semt022001.DeniedStatus15Choice
        + PdgPrcg  : ISO20022.Semt022001.PendingProcessingStatus13Choice
        + AckdAccptd  : ISO20022.Semt022001.AcknowledgedAcceptedStatus23Choice
    }
    ISO20022.Semt022001.ModificationProcessingStatus10Choice *-- ISO20022.Semt022001.ProprietaryStatusAndReason6
    ISO20022.Semt022001.ModificationProcessingStatus10Choice *-- ISO20022.Semt022001.ModificationStatus4Choice
    ISO20022.Semt022001.ModificationProcessingStatus10Choice *-- ISO20022.Semt022001.RepairStatus13Choice
    ISO20022.Semt022001.ModificationProcessingStatus10Choice *-- ISO20022.Semt022001.RejectionStatus37Choice
    ISO20022.Semt022001.ModificationProcessingStatus10Choice *-- ISO20022.Semt022001.DeniedStatus15Choice
    ISO20022.Semt022001.ModificationProcessingStatus10Choice *-- ISO20022.Semt022001.PendingProcessingStatus13Choice
    ISO20022.Semt022001.ModificationProcessingStatus10Choice *-- ISO20022.Semt022001.AcknowledgedAcceptedStatus23Choice
    class ISO20022.Semt022001.ModificationReason4 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.ModificationReason4Choice
    }
    ISO20022.Semt022001.ModificationReason4 *-- ISO20022.Semt022001.ModificationReason4Choice
    class ISO20022.Semt022001.ModificationReason4Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.ModificationReason4Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.ModificationStatus4Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.ModificationReason4~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.ModificationStatus4Choice *-- ISO20022.Semt022001.ModificationReason4
    class ISO20022.Semt022001.ModifiedStatusReason1Code {
        OTHR = 1
        MDBY = 2
    }
    class ISO20022.Semt022001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Semt022001.OrganisationIdentification31 {
        + Othr  : global::System.Collections.Generic.List~ISO20022.Semt022001.GenericOrganisationIdentification1~
        + AnyBIC  : String
    }
    ISO20022.Semt022001.OrganisationIdentification31 *-- ISO20022.Semt022001.GenericOrganisationIdentification1
    class ISO20022.Semt022001.OrganisationIdentificationSchemeName1Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt022001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Semt022001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Semt022001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Semt022001.PartyIdentification127Choice *-- ISO20022.Semt022001.GenericIdentification36
    class ISO20022.Semt022001.PartyIdentification144 {
        + LEI  : String
        + Id  : ISO20022.Semt022001.PartyIdentification127Choice
    }
    ISO20022.Semt022001.PartyIdentification144 *-- ISO20022.Semt022001.PartyIdentification127Choice
    class ISO20022.Semt022001.PendingProcessingReason10 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.PendingProcessingReason12Choice
    }
    ISO20022.Semt022001.PendingProcessingReason10 *-- ISO20022.Semt022001.PendingProcessingReason12Choice
    class ISO20022.Semt022001.PendingProcessingReason10Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.PendingProcessingReason10Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.PendingProcessingReason12Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.PendingProcessingReason12Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.PendingProcessingReason2Code {
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
    class ISO20022.Semt022001.PendingProcessingReason3Code {
        CERT = 1
        DENO = 2
        OTHR = 3
        MINO = 4
        NEXT = 5
        MUNO = 6
        BLOC = 7
        ADEA = 8
    }
    class ISO20022.Semt022001.PendingProcessingReason8 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.PendingProcessingReason10Choice
    }
    ISO20022.Semt022001.PendingProcessingReason8 *-- ISO20022.Semt022001.PendingProcessingReason10Choice
    class ISO20022.Semt022001.PendingProcessingStatus11Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.PendingProcessingReason8~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.PendingProcessingStatus11Choice *-- ISO20022.Semt022001.PendingProcessingReason8
    class ISO20022.Semt022001.PendingProcessingStatus13Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.PendingProcessingReason10~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.PendingProcessingStatus13Choice *-- ISO20022.Semt022001.PendingProcessingReason10
    class ISO20022.Semt022001.PendingReason16 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.PendingReason28Choice
    }
    ISO20022.Semt022001.PendingReason16 *-- ISO20022.Semt022001.PendingReason28Choice
    class ISO20022.Semt022001.PendingReason17 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.PendingReason30Choice
    }
    ISO20022.Semt022001.PendingReason17 *-- ISO20022.Semt022001.PendingReason30Choice
    class ISO20022.Semt022001.PendingReason28Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.PendingReason28Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.PendingReason28Code {
        PREL = 1
        PATD = 2
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
        CYCL = 28
        BATC = 29
        SDUT = 30
        REFS = 31
        NCON = 32
        MONY = 33
        LALO = 34
        LACK = 35
        FUTU = 36
        LINK = 37
        INCA = 38
        FLIM = 39
        DEPO = 40
        COLL = 41
        YCOL = 42
        CMON = 43
        NOFX = 44
        NMAS = 45
        PART = 46
        PREA = 47
        GLOB = 48
        MUNO = 49
        CLAC = 50
        NEWI = 51
        CHAS = 52
        BLOC = 53
        DOCC = 54
        DOCY = 55
        TAMM = 56
        PHSE = 57
        AWSH = 58
        REFU = 59
        CAIS = 60
        ADEA = 61
        AWMO = 62
    }
    class ISO20022.Semt022001.PendingReason30Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.PendingReason30Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.PendingReason32 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.PendingReason69Choice
    }
    ISO20022.Semt022001.PendingReason32 *-- ISO20022.Semt022001.PendingReason69Choice
    class ISO20022.Semt022001.PendingReason69Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.PendingReason69Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.PendingReason6Code {
        CDRE = 1
        CDCY = 2
        CDRG = 3
        OTHR = 4
        CONF = 5
        ADEA = 6
    }
    class ISO20022.Semt022001.PendingReason9Code {
        INBC = 1
        CDAC = 2
        CDRE = 3
        CDCY = 4
        CDRG = 5
        OTHR = 6
        CONF = 7
        ADEA = 8
    }
    class ISO20022.Semt022001.PendingStatus38Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.PendingReason16~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.PendingStatus38Choice *-- ISO20022.Semt022001.PendingReason16
    class ISO20022.Semt022001.PendingStatus39Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.PendingReason17~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.PendingStatus39Choice *-- ISO20022.Semt022001.PendingReason17
    class ISO20022.Semt022001.PendingStatus73Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.PendingReason32~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.PendingStatus73Choice *-- ISO20022.Semt022001.PendingReason32
    class ISO20022.Semt022001.ProcessingStatus86Choice {
        + Canc  : ISO20022.Semt022001.CancellationStatus15Choice
        + Dnd  : ISO20022.Semt022001.DeniedStatus16Choice
        + Prtry  : ISO20022.Semt022001.ProprietaryStatusAndReason6
        + AckdAccptd  : ISO20022.Semt022001.AcknowledgedAcceptedStatus24Choice
        + Rpr  : ISO20022.Semt022001.RejectionOrRepairStatus42Choice
        + Rjctd  : ISO20022.Semt022001.RejectionOrRepairStatus43Choice
        + PdgCxl  : ISO20022.Semt022001.PendingStatus39Choice
    }
    ISO20022.Semt022001.ProcessingStatus86Choice *-- ISO20022.Semt022001.CancellationStatus15Choice
    ISO20022.Semt022001.ProcessingStatus86Choice *-- ISO20022.Semt022001.DeniedStatus16Choice
    ISO20022.Semt022001.ProcessingStatus86Choice *-- ISO20022.Semt022001.ProprietaryStatusAndReason6
    ISO20022.Semt022001.ProcessingStatus86Choice *-- ISO20022.Semt022001.AcknowledgedAcceptedStatus24Choice
    ISO20022.Semt022001.ProcessingStatus86Choice *-- ISO20022.Semt022001.RejectionOrRepairStatus42Choice
    ISO20022.Semt022001.ProcessingStatus86Choice *-- ISO20022.Semt022001.RejectionOrRepairStatus43Choice
    ISO20022.Semt022001.ProcessingStatus86Choice *-- ISO20022.Semt022001.PendingStatus39Choice
    class ISO20022.Semt022001.ProcessingStatus87Choice {
        + ModReqd  : ISO20022.Semt022001.ProprietaryReason4
        + CxlReqd  : ISO20022.Semt022001.ProprietaryReason4
        + Prtry  : ISO20022.Semt022001.ProprietaryStatusAndReason6
        + PdgCxl  : ISO20022.Semt022001.PendingStatus38Choice
        + Canc  : ISO20022.Semt022001.CancellationStatus24Choice
        + Rpr  : ISO20022.Semt022001.RepairStatus12Choice
        + Rjctd  : ISO20022.Semt022001.RejectionStatus38Choice
        + PdgPrcg  : ISO20022.Semt022001.PendingProcessingStatus11Choice
        + AckdAccptd  : ISO20022.Semt022001.AcknowledgedAcceptedStatus21Choice
    }
    ISO20022.Semt022001.ProcessingStatus87Choice *-- ISO20022.Semt022001.ProprietaryReason4
    ISO20022.Semt022001.ProcessingStatus87Choice *-- ISO20022.Semt022001.ProprietaryReason4
    ISO20022.Semt022001.ProcessingStatus87Choice *-- ISO20022.Semt022001.ProprietaryStatusAndReason6
    ISO20022.Semt022001.ProcessingStatus87Choice *-- ISO20022.Semt022001.PendingStatus38Choice
    ISO20022.Semt022001.ProcessingStatus87Choice *-- ISO20022.Semt022001.CancellationStatus24Choice
    ISO20022.Semt022001.ProcessingStatus87Choice *-- ISO20022.Semt022001.RepairStatus12Choice
    ISO20022.Semt022001.ProcessingStatus87Choice *-- ISO20022.Semt022001.RejectionStatus38Choice
    ISO20022.Semt022001.ProcessingStatus87Choice *-- ISO20022.Semt022001.PendingProcessingStatus11Choice
    ISO20022.Semt022001.ProcessingStatus87Choice *-- ISO20022.Semt022001.AcknowledgedAcceptedStatus21Choice
    class ISO20022.Semt022001.ProprietaryReason4 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Semt022001.GenericIdentification30
    }
    ISO20022.Semt022001.ProprietaryReason4 *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.ProprietaryStatusAndReason6 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.ProprietaryReason4~
        + PrtrySts  : ISO20022.Semt022001.GenericIdentification30
    }
    ISO20022.Semt022001.ProprietaryStatusAndReason6 *-- ISO20022.Semt022001.ProprietaryReason4
    ISO20022.Semt022001.ProprietaryStatusAndReason6 *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.RejectionAndRepairReason37Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.RejectionAndRepairReason37Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.RejectionAndRepairReason38Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.RejectionAndRepairReason38Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.RejectionOrRepairReason37 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.RejectionAndRepairReason37Choice
    }
    ISO20022.Semt022001.RejectionOrRepairReason37 *-- ISO20022.Semt022001.RejectionAndRepairReason37Choice
    class ISO20022.Semt022001.RejectionOrRepairReason38 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.RejectionAndRepairReason38Choice
    }
    ISO20022.Semt022001.RejectionOrRepairReason38 *-- ISO20022.Semt022001.RejectionAndRepairReason38Choice
    class ISO20022.Semt022001.RejectionOrRepairStatus42Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.RejectionOrRepairReason37~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.RejectionOrRepairStatus42Choice *-- ISO20022.Semt022001.RejectionOrRepairReason37
    class ISO20022.Semt022001.RejectionOrRepairStatus43Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.RejectionOrRepairReason38~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.RejectionOrRepairStatus43Choice *-- ISO20022.Semt022001.RejectionOrRepairReason38
    class ISO20022.Semt022001.RejectionReason42Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.RejectionReason42Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.RejectionReason43Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.RejectionReason43Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.RejectionReason57 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.RejectionReason42Choice
    }
    ISO20022.Semt022001.RejectionReason57 *-- ISO20022.Semt022001.RejectionReason42Choice
    class ISO20022.Semt022001.RejectionReason58 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.RejectionReason43Choice
    }
    ISO20022.Semt022001.RejectionReason58 *-- ISO20022.Semt022001.RejectionReason43Choice
    class ISO20022.Semt022001.RejectionReason71Code {
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
    class ISO20022.Semt022001.RejectionReason72Code {
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
    class ISO20022.Semt022001.RejectionReason73Code {
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
    class ISO20022.Semt022001.RejectionReason74Code {
        OTHR = 1
        NRGM = 2
        REFE = 3
        NRGN = 4
        LATE = 5
        ADEA = 6
        SAFE = 7
    }
    class ISO20022.Semt022001.RejectionStatus37Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.RejectionReason57~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.RejectionStatus37Choice *-- ISO20022.Semt022001.RejectionReason57
    class ISO20022.Semt022001.RejectionStatus38Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.RejectionReason58~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.RejectionStatus38Choice *-- ISO20022.Semt022001.RejectionReason58
    class ISO20022.Semt022001.RepairReason10Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.RepairReason10Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.RepairReason4Code {
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
    class ISO20022.Semt022001.RepairReason8 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.RepairReason10Choice
    }
    ISO20022.Semt022001.RepairReason8 *-- ISO20022.Semt022001.RepairReason10Choice
    class ISO20022.Semt022001.RepairReason9 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.RepairReason10Choice
    }
    ISO20022.Semt022001.RepairReason9 *-- ISO20022.Semt022001.RepairReason10Choice
    class ISO20022.Semt022001.RepairStatus12Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.RepairReason8~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.RepairStatus12Choice *-- ISO20022.Semt022001.RepairReason8
    class ISO20022.Semt022001.RepairStatus13Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.RepairReason9~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.RepairStatus13Choice *-- ISO20022.Semt022001.RepairReason9
    class ISO20022.Semt022001.SecuritiesAccount22 {
        + Nm  : String
        + Tp  : ISO20022.Semt022001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Semt022001.SecuritiesAccount22 *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.SecuritiesSettlementTransactionAuditTrailReportV06 {
        + StsTrl  : global::System.Collections.Generic.List~ISO20022.Semt022001.StatusTrail12~
        + AcctOwnr  : ISO20022.Semt022001.PartyIdentification144
        + BlckChainAdrOrWllt  : ISO20022.Semt022001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Semt022001.SecuritiesAccount22
        + TxId  : ISO20022.Semt022001.TransactionIdentifications54
        + QryRef  : String
        + Pgntn  : ISO20022.Semt022001.Pagination1
    }
    ISO20022.Semt022001.SecuritiesSettlementTransactionAuditTrailReportV06 *-- ISO20022.Semt022001.StatusTrail12
    ISO20022.Semt022001.SecuritiesSettlementTransactionAuditTrailReportV06 *-- ISO20022.Semt022001.PartyIdentification144
    ISO20022.Semt022001.SecuritiesSettlementTransactionAuditTrailReportV06 *-- ISO20022.Semt022001.BlockChainAddressWallet3
    ISO20022.Semt022001.SecuritiesSettlementTransactionAuditTrailReportV06 *-- ISO20022.Semt022001.SecuritiesAccount22
    ISO20022.Semt022001.SecuritiesSettlementTransactionAuditTrailReportV06 *-- ISO20022.Semt022001.TransactionIdentifications54
    ISO20022.Semt022001.SecuritiesSettlementTransactionAuditTrailReportV06 *-- ISO20022.Semt022001.Pagination1
    class ISO20022.Semt022001.SettlementStatus32Choice {
        + Prtry  : ISO20022.Semt022001.ProprietaryStatusAndReason6
        + Flng  : ISO20022.Semt022001.FailingStatus15Choice
        + Pdg  : ISO20022.Semt022001.PendingStatus73Choice
    }
    ISO20022.Semt022001.SettlementStatus32Choice *-- ISO20022.Semt022001.ProprietaryStatusAndReason6
    ISO20022.Semt022001.SettlementStatus32Choice *-- ISO20022.Semt022001.FailingStatus15Choice
    ISO20022.Semt022001.SettlementStatus32Choice *-- ISO20022.Semt022001.PendingStatus73Choice
    class ISO20022.Semt022001.StatusTrail12 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt022001.SupplementaryData1~
        + Sttld  : ISO20022.Semt022001.ProprietaryReason4
        + CxlSts  : ISO20022.Semt022001.ProcessingStatus86Choice
        + ModPrcgSts  : ISO20022.Semt022001.ModificationProcessingStatus10Choice
        + SttlmSts  : ISO20022.Semt022001.SettlementStatus32Choice
        + MtchgSts  : ISO20022.Semt022001.MatchingStatus25Choice
        + IfrrdMtchgSts  : ISO20022.Semt022001.MatchingStatus25Choice
        + PrcgSts  : ISO20022.Semt022001.ProcessingStatus87Choice
        + UsrId  : String
        + SndgOrgId  : ISO20022.Semt022001.OrganisationIdentification31
        + StsDt  : DateTime
    }
    ISO20022.Semt022001.StatusTrail12 *-- ISO20022.Semt022001.SupplementaryData1
    ISO20022.Semt022001.StatusTrail12 *-- ISO20022.Semt022001.ProprietaryReason4
    ISO20022.Semt022001.StatusTrail12 *-- ISO20022.Semt022001.ProcessingStatus86Choice
    ISO20022.Semt022001.StatusTrail12 *-- ISO20022.Semt022001.ModificationProcessingStatus10Choice
    ISO20022.Semt022001.StatusTrail12 *-- ISO20022.Semt022001.SettlementStatus32Choice
    ISO20022.Semt022001.StatusTrail12 *-- ISO20022.Semt022001.MatchingStatus25Choice
    ISO20022.Semt022001.StatusTrail12 *-- ISO20022.Semt022001.MatchingStatus25Choice
    ISO20022.Semt022001.StatusTrail12 *-- ISO20022.Semt022001.ProcessingStatus87Choice
    ISO20022.Semt022001.StatusTrail12 *-- ISO20022.Semt022001.OrganisationIdentification31
    class ISO20022.Semt022001.SupplementaryData1 {
        + Envlp  : ISO20022.Semt022001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Semt022001.SupplementaryData1 *-- ISO20022.Semt022001.SupplementaryDataEnvelope1
    class ISO20022.Semt022001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Semt022001.TransactionIdentifications54 {
        + PrcrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
        + UnqTxIdr  : String
        + TradId  : String
    }
    class ISO20022.Semt022001.UnmatchedReason12Code {
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
    class ISO20022.Semt022001.UnmatchedReason16 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Semt022001.UnmatchedReason23Choice
    }
    ISO20022.Semt022001.UnmatchedReason16 *-- ISO20022.Semt022001.UnmatchedReason23Choice
    class ISO20022.Semt022001.UnmatchedReason23Choice {
        + Prtry  : ISO20022.Semt022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt022001.UnmatchedReason23Choice *-- ISO20022.Semt022001.GenericIdentification30
    class ISO20022.Semt022001.UnmatchedStatus17Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Semt022001.UnmatchedReason16~
        + NoSpcfdRsn  : String
    }
    ISO20022.Semt022001.UnmatchedStatus17Choice *-- ISO20022.Semt022001.UnmatchedReason16
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

## Value ISO20022.Semt022001.AcknowledgedAcceptedStatus21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.AcknowledgementReason9>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.AcknowledgedAcceptedStatus23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.AcknowledgementReason11>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.AcknowledgedAcceptedStatus24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.AcknowledgementReason12>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.AcknowledgementReason11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.AcknowledgementReason14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.AcknowledgementReason12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.AcknowledgementReason15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.AcknowledgementReason12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022001.AcknowledgementReason14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022001.AcknowledgementReason15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt022001.AcknowledgementReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||SMPG|Int32||XmlEnum("""SMPG""")|2|
||ADEA|Int32||XmlEnum("""ADEA""")|3|

---

## Enum ISO20022.Semt022001.AcknowledgementReason5Code


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

## Enum ISO20022.Semt022001.AcknowledgementReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LATE|Int32||XmlEnum("""LATE""")|1|
||NSTP|Int32||XmlEnum("""NSTP""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||SMPG|Int32||XmlEnum("""SMPG""")|4|
||ADEA|Int32||XmlEnum("""ADEA""")|5|

---

## Value ISO20022.Semt022001.AcknowledgementReason9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.AcknowledgementReason12Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt022001.CancellationReason10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.CancellationReason21Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.CancellationReason21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022001.CancellationReason22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.CancellationReason36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.CancellationReason36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022001.CancellationStatus15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.CancellationReason10>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.CancellationStatus24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.CancellationReason22>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Semt022001.CancelledStatusReason16Code


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

## Enum ISO20022.Semt022001.CancelledStatusReason5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||CANI|Int32||XmlEnum("""CANI""")|2|

---

## Value ISO20022.Semt022001.DeniedReason10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.DeniedReason15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.DeniedReason11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.DeniedReason16Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.DeniedReason15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022001.DeniedReason16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt022001.DeniedReason4Code


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

## Enum ISO20022.Semt022001.DeniedReason6Code


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

## Value ISO20022.Semt022001.DeniedStatus15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.DeniedReason10>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.DeniedStatus16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.DeniedReason11>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Type ISO20022.Semt022001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmTxAudtTrlRpt|ISO20022.Semt022001.SecuritiesSettlementTransactionAuditTrailReportV06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmTxAudtTrlRpt))|

---

## Value ISO20022.Semt022001.FailingReason13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.FailingReason18Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.FailingReason18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt022001.FailingReason5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREL|Int32||XmlEnum("""PREL""")|1|
||PATD|Int32||XmlEnum("""PATD""")|2|
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

## Value ISO20022.Semt022001.FailingStatus15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.FailingReason13>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt022001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt022001.GenericOrganisationIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|ISO20022.Semt022001.OrganisationIdentificationSchemeName1Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SchmeNm))|

---

## Value ISO20022.Semt022001.MatchingStatus25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.ProprietaryStatusAndReason6||XmlElement()||
|+|Umtchd|ISO20022.Semt022001.UnmatchedStatus17Choice||XmlElement()||
|+|Mtchd|ISO20022.Semt022001.ProprietaryReason4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Umtchd),validElement(Mtchd),validChoice(Prtry,Umtchd,Mtchd))|

---

## Value ISO20022.Semt022001.ModificationProcessingStatus10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.ProprietaryStatusAndReason6||XmlElement()||
|+|Modfd|ISO20022.Semt022001.ModificationStatus4Choice||XmlElement()||
|+|Rprd|ISO20022.Semt022001.RepairStatus13Choice||XmlElement()||
|+|Rjctd|ISO20022.Semt022001.RejectionStatus37Choice||XmlElement()||
|+|Dnd|ISO20022.Semt022001.DeniedStatus15Choice||XmlElement()||
|+|PdgPrcg|ISO20022.Semt022001.PendingProcessingStatus13Choice||XmlElement()||
|+|AckdAccptd|ISO20022.Semt022001.AcknowledgedAcceptedStatus23Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Modfd),validElement(Rprd),validElement(Rjctd),validElement(Dnd),validElement(PdgPrcg),validElement(AckdAccptd),validChoice(Prtry,Modfd,Rprd,Rjctd,Dnd,PdgPrcg,AckdAccptd))|

---

## Value ISO20022.Semt022001.ModificationReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.ModificationReason4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.ModificationReason4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022001.ModificationStatus4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.ModificationReason4>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Semt022001.ModifiedStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||MDBY|Int32||XmlEnum("""MDBY""")|2|

---

## Enum ISO20022.Semt022001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Semt022001.OrganisationIdentification31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Othr|global::System.Collections.Generic.List<ISO20022.Semt022001.GenericOrganisationIdentification1>||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Othr""",Othr),validElement(Othr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt022001.OrganisationIdentificationSchemeName1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Semt022001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Semt022001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Semt022001.PartyIdentification144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt022001.PartyIdentification127Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt022001.PendingProcessingReason10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.PendingProcessingReason12Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.PendingProcessingReason10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022001.PendingProcessingReason12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt022001.PendingProcessingReason2Code


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

## Enum ISO20022.Semt022001.PendingProcessingReason3Code


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

## Value ISO20022.Semt022001.PendingProcessingReason8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.PendingProcessingReason10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.PendingProcessingStatus11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.PendingProcessingReason8>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.PendingProcessingStatus13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.PendingProcessingReason10>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.PendingReason16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.PendingReason28Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.PendingReason17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.PendingReason30Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.PendingReason28Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt022001.PendingReason28Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREL|Int32||XmlEnum("""PREL""")|1|
||PATD|Int32||XmlEnum("""PATD""")|2|
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
||CYCL|Int32||XmlEnum("""CYCL""")|28|
||BATC|Int32||XmlEnum("""BATC""")|29|
||SDUT|Int32||XmlEnum("""SDUT""")|30|
||REFS|Int32||XmlEnum("""REFS""")|31|
||NCON|Int32||XmlEnum("""NCON""")|32|
||MONY|Int32||XmlEnum("""MONY""")|33|
||LALO|Int32||XmlEnum("""LALO""")|34|
||LACK|Int32||XmlEnum("""LACK""")|35|
||FUTU|Int32||XmlEnum("""FUTU""")|36|
||LINK|Int32||XmlEnum("""LINK""")|37|
||INCA|Int32||XmlEnum("""INCA""")|38|
||FLIM|Int32||XmlEnum("""FLIM""")|39|
||DEPO|Int32||XmlEnum("""DEPO""")|40|
||COLL|Int32||XmlEnum("""COLL""")|41|
||YCOL|Int32||XmlEnum("""YCOL""")|42|
||CMON|Int32||XmlEnum("""CMON""")|43|
||NOFX|Int32||XmlEnum("""NOFX""")|44|
||NMAS|Int32||XmlEnum("""NMAS""")|45|
||PART|Int32||XmlEnum("""PART""")|46|
||PREA|Int32||XmlEnum("""PREA""")|47|
||GLOB|Int32||XmlEnum("""GLOB""")|48|
||MUNO|Int32||XmlEnum("""MUNO""")|49|
||CLAC|Int32||XmlEnum("""CLAC""")|50|
||NEWI|Int32||XmlEnum("""NEWI""")|51|
||CHAS|Int32||XmlEnum("""CHAS""")|52|
||BLOC|Int32||XmlEnum("""BLOC""")|53|
||DOCC|Int32||XmlEnum("""DOCC""")|54|
||DOCY|Int32||XmlEnum("""DOCY""")|55|
||TAMM|Int32||XmlEnum("""TAMM""")|56|
||PHSE|Int32||XmlEnum("""PHSE""")|57|
||AWSH|Int32||XmlEnum("""AWSH""")|58|
||REFU|Int32||XmlEnum("""REFU""")|59|
||CAIS|Int32||XmlEnum("""CAIS""")|60|
||ADEA|Int32||XmlEnum("""ADEA""")|61|
||AWMO|Int32||XmlEnum("""AWMO""")|62|

---

## Value ISO20022.Semt022001.PendingReason30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022001.PendingReason32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.PendingReason69Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.PendingReason69Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt022001.PendingReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDRE|Int32||XmlEnum("""CDRE""")|1|
||CDCY|Int32||XmlEnum("""CDCY""")|2|
||CDRG|Int32||XmlEnum("""CDRG""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||CONF|Int32||XmlEnum("""CONF""")|5|
||ADEA|Int32||XmlEnum("""ADEA""")|6|

---

## Enum ISO20022.Semt022001.PendingReason9Code


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

## Value ISO20022.Semt022001.PendingStatus38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.PendingReason16>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.PendingStatus39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.PendingReason17>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.PendingStatus73Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.PendingReason32>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.ProcessingStatus86Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Canc|ISO20022.Semt022001.CancellationStatus15Choice||XmlElement()||
|+|Dnd|ISO20022.Semt022001.DeniedStatus16Choice||XmlElement()||
|+|Prtry|ISO20022.Semt022001.ProprietaryStatusAndReason6||XmlElement()||
|+|AckdAccptd|ISO20022.Semt022001.AcknowledgedAcceptedStatus24Choice||XmlElement()||
|+|Rpr|ISO20022.Semt022001.RejectionOrRepairStatus42Choice||XmlElement()||
|+|Rjctd|ISO20022.Semt022001.RejectionOrRepairStatus43Choice||XmlElement()||
|+|PdgCxl|ISO20022.Semt022001.PendingStatus39Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Canc),validElement(Dnd),validElement(Prtry),validElement(AckdAccptd),validElement(Rpr),validElement(Rjctd),validElement(PdgCxl),validChoice(Canc,Dnd,Prtry,AckdAccptd,Rpr,Rjctd,PdgCxl))|

---

## Value ISO20022.Semt022001.ProcessingStatus87Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ModReqd|ISO20022.Semt022001.ProprietaryReason4||XmlElement()||
|+|CxlReqd|ISO20022.Semt022001.ProprietaryReason4||XmlElement()||
|+|Prtry|ISO20022.Semt022001.ProprietaryStatusAndReason6||XmlElement()||
|+|PdgCxl|ISO20022.Semt022001.PendingStatus38Choice||XmlElement()||
|+|Canc|ISO20022.Semt022001.CancellationStatus24Choice||XmlElement()||
|+|Rpr|ISO20022.Semt022001.RepairStatus12Choice||XmlElement()||
|+|Rjctd|ISO20022.Semt022001.RejectionStatus38Choice||XmlElement()||
|+|PdgPrcg|ISO20022.Semt022001.PendingProcessingStatus11Choice||XmlElement()||
|+|AckdAccptd|ISO20022.Semt022001.AcknowledgedAcceptedStatus21Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ModReqd),validElement(CxlReqd),validElement(Prtry),validElement(PdgCxl),validElement(Canc),validElement(Rpr),validElement(Rjctd),validElement(PdgPrcg),validElement(AckdAccptd),validChoice(ModReqd,CxlReqd,Prtry,PdgCxl,Canc,Rpr,Rjctd,PdgPrcg,AckdAccptd))|

---

## Value ISO20022.Semt022001.ProprietaryReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Semt022001.ProprietaryStatusAndReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Semt022001.ProprietaryReason4>||XmlElement()||
|+|PrtrySts|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Semt022001.RejectionAndRepairReason37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022001.RejectionAndRepairReason38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022001.RejectionOrRepairReason37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.RejectionAndRepairReason37Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.RejectionOrRepairReason38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.RejectionAndRepairReason38Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.RejectionOrRepairStatus42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.RejectionOrRepairReason37>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.RejectionOrRepairStatus43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.RejectionOrRepairReason38>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.RejectionReason42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022001.RejectionReason43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022001.RejectionReason57


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.RejectionReason42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.RejectionReason58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.RejectionReason43Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Enum ISO20022.Semt022001.RejectionReason71Code


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

## Enum ISO20022.Semt022001.RejectionReason72Code


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

## Enum ISO20022.Semt022001.RejectionReason73Code


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

## Enum ISO20022.Semt022001.RejectionReason74Code


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

## Value ISO20022.Semt022001.RejectionStatus37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.RejectionReason57>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.RejectionStatus38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.RejectionReason58>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.RepairReason10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt022001.RepairReason4Code


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

## Value ISO20022.Semt022001.RepairReason8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.RepairReason10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.RepairReason9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.RepairReason10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.RepairStatus12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.RepairReason8>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.RepairStatus13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.RepairReason9>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Semt022001.SecuritiesAccount22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Aspect ISO20022.Semt022001.SecuritiesSettlementTransactionAuditTrailReportV06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|StsTrl|global::System.Collections.Generic.List<ISO20022.Semt022001.StatusTrail12>||XmlElement()||
|+|AcctOwnr|ISO20022.Semt022001.PartyIdentification144||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt022001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt022001.SecuritiesAccount22||XmlElement()||
|+|TxId|ISO20022.Semt022001.TransactionIdentifications54||XmlElement()||
|+|QryRef|String||XmlElement()||
|+|Pgntn|ISO20022.Semt022001.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""StsTrl""",StsTrl),validElement(StsTrl),validElement(AcctOwnr),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(TxId),validElement(Pgntn))|

---

## Value ISO20022.Semt022001.SettlementStatus32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.ProprietaryStatusAndReason6||XmlElement()||
|+|Flng|ISO20022.Semt022001.FailingStatus15Choice||XmlElement()||
|+|Pdg|ISO20022.Semt022001.PendingStatus73Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Flng),validElement(Pdg),validChoice(Prtry,Flng,Pdg))|

---

## Value ISO20022.Semt022001.StatusTrail12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt022001.SupplementaryData1>||XmlElement()||
|+|Sttld|ISO20022.Semt022001.ProprietaryReason4||XmlElement()||
|+|CxlSts|ISO20022.Semt022001.ProcessingStatus86Choice||XmlElement()||
|+|ModPrcgSts|ISO20022.Semt022001.ModificationProcessingStatus10Choice||XmlElement()||
|+|SttlmSts|ISO20022.Semt022001.SettlementStatus32Choice||XmlElement()||
|+|MtchgSts|ISO20022.Semt022001.MatchingStatus25Choice||XmlElement()||
|+|IfrrdMtchgSts|ISO20022.Semt022001.MatchingStatus25Choice||XmlElement()||
|+|PrcgSts|ISO20022.Semt022001.ProcessingStatus87Choice||XmlElement()||
|+|UsrId|String||XmlElement()||
|+|SndgOrgId|ISO20022.Semt022001.OrganisationIdentification31||XmlElement()||
|+|StsDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(Sttld),validElement(CxlSts),validElement(ModPrcgSts),validElement(SttlmSts),validElement(MtchgSts),validElement(IfrrdMtchgSts),validElement(PrcgSts),validElement(SndgOrgId))|

---

## Value ISO20022.Semt022001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Semt022001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Semt022001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt022001.TransactionIdentifications54


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
|+|UnqTxIdr|String||XmlElement()||
|+|TradId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""))|

---

## Enum ISO20022.Semt022001.UnmatchedReason12Code


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

## Value ISO20022.Semt022001.UnmatchedReason16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Semt022001.UnmatchedReason23Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Semt022001.UnmatchedReason23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt022001.UnmatchedStatus17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Semt022001.UnmatchedReason16>||XmlElement()||
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

