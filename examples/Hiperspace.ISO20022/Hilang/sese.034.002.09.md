# sese.034.002.09
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese034002.AcknowledgedAcceptedStatus25Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese034002.AcknowledgementReason13~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese034002.AcknowledgedAcceptedStatus25Choice *-- ISO20022.Sese034002.AcknowledgementReason13
    class ISO20022.Sese034002.AcknowledgedAcceptedStatus27Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese034002.AcknowledgementReason15~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese034002.AcknowledgedAcceptedStatus27Choice *-- ISO20022.Sese034002.AcknowledgementReason15
    class ISO20022.Sese034002.AcknowledgementReason13 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese034002.AcknowledgementReason16Choice
    }
    ISO20022.Sese034002.AcknowledgementReason13 *-- ISO20022.Sese034002.AcknowledgementReason16Choice
    class ISO20022.Sese034002.AcknowledgementReason15 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese034002.AcknowledgementReason18Choice
    }
    ISO20022.Sese034002.AcknowledgementReason15 *-- ISO20022.Sese034002.AcknowledgementReason18Choice
    class ISO20022.Sese034002.AcknowledgementReason16Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.AcknowledgementReason16Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.AcknowledgementReason18Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.AcknowledgementReason18Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.AcknowledgementReason5Code {
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
    class ISO20022.Sese034002.AlternatePartyIdentification9 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Sese034002.IdentificationType44Choice
    }
    ISO20022.Sese034002.AlternatePartyIdentification9 *-- ISO20022.Sese034002.IdentificationType44Choice
    class ISO20022.Sese034002.AmountAndDirection59 {
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese034002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Sese034002.AmountAndDirection59 *-- ISO20022.Sese034002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    class ISO20022.Sese034002.AmountAndDirection67 {
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese034002.RestrictedFINActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese034002.RestrictedFINActiveCurrencyAndAmount
    }
    ISO20022.Sese034002.AmountAndDirection67 *-- ISO20022.Sese034002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese034002.AmountAndDirection67 *-- ISO20022.Sese034002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese034002.BeneficialOwnership5Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese034002.BeneficialOwnership5Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Sese034002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese034002.BlockChainAddressWallet7 *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.BlockTrade1Code {
        BLCH = 1
        BLPA = 2
    }
    class ISO20022.Sese034002.BlockTrade5Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.BlockTrade5Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.CancellationReason15 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese034002.CancellationReason25Choice
    }
    ISO20022.Sese034002.CancellationReason15 *-- ISO20022.Sese034002.CancellationReason25Choice
    class ISO20022.Sese034002.CancellationReason25Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.CancellationReason25Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.CancellationStatus18Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese034002.CancellationReason15~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese034002.CancellationStatus18Choice *-- ISO20022.Sese034002.CancellationReason15
    class ISO20022.Sese034002.CancelledStatusReason9Code {
        OTHR = 1
        SCEX = 2
        CORP = 3
        CANZ = 4
        CANT = 5
        CXLR = 6
        CSUB = 7
        CANS = 8
        CANI = 9
    }
    class ISO20022.Sese034002.CashSettlementSystem2Code {
        NETS = 1
        GROS = 2
    }
    class ISO20022.Sese034002.CashSettlementSystem5Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.CashSettlementSystem5Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.CentralCounterPartyEligibility5Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese034002.CentralCounterPartyEligibility5Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese034002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese034002.DateCode32Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.DateCode32Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese034002.DateType4Code {
        UKWN = 1
        OPEN = 2
    }
    class ISO20022.Sese034002.DateType5Code {
        OPEN = 1
    }
    class ISO20022.Sese034002.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese034002.DeniedReason13 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese034002.DeniedReason18Choice
    }
    ISO20022.Sese034002.DeniedReason13 *-- ISO20022.Sese034002.DeniedReason18Choice
    class ISO20022.Sese034002.DeniedReason18Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.DeniedReason18Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.DeniedReason3Code {
        OTHR = 1
        LATE = 2
        DFOR = 3
        DCAL = 4
        ADEA = 5
    }
    class ISO20022.Sese034002.DeniedStatus18Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese034002.DeniedReason13~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese034002.DeniedStatus18Choice *-- ISO20022.Sese034002.DeniedReason13
    class ISO20022.Sese034002.FailingReason10 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese034002.FailingReason11Choice
    }
    ISO20022.Sese034002.FailingReason10 *-- ISO20022.Sese034002.FailingReason11Choice
    class ISO20022.Sese034002.FailingReason11Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.FailingReason11Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.FailingReason2Code {
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
    class ISO20022.Sese034002.FailingStatus12Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese034002.FailingReason10~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese034002.FailingStatus12Choice *-- ISO20022.Sese034002.FailingReason10
    class ISO20022.Sese034002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese034002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese034002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese034002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Sese034002.GenericIdentification47
    }
    ISO20022.Sese034002.GenericIdentification85 *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese034002.IdentificationType44Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.IdentificationType44Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.MarketClientSide1Code {
        MAKT = 1
        CLNT = 2
    }
    class ISO20022.Sese034002.MarketClientSide7Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.MarketClientSide7Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.MarketIdentification2Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Sese034002.MarketIdentification90 {
        + Tp  : ISO20022.Sese034002.MarketType16Choice
        + Id  : ISO20022.Sese034002.MarketIdentification2Choice
    }
    ISO20022.Sese034002.MarketIdentification90 *-- ISO20022.Sese034002.MarketType16Choice
    ISO20022.Sese034002.MarketIdentification90 *-- ISO20022.Sese034002.MarketIdentification2Choice
    class ISO20022.Sese034002.MarketType16Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.MarketType16Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Sese034002.MatchingStatus29Choice {
        + Prtry  : ISO20022.Sese034002.ProprietaryStatusAndReason7
        + Umtchd  : ISO20022.Sese034002.UnmatchedStatus19Choice
        + Mtchd  : ISO20022.Sese034002.ProprietaryReason5
    }
    ISO20022.Sese034002.MatchingStatus29Choice *-- ISO20022.Sese034002.ProprietaryStatusAndReason7
    ISO20022.Sese034002.MatchingStatus29Choice *-- ISO20022.Sese034002.UnmatchedStatus19Choice
    ISO20022.Sese034002.MatchingStatus29Choice *-- ISO20022.Sese034002.ProprietaryReason5
    class ISO20022.Sese034002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Sese034002.NettingEligibility5Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese034002.NettingEligibility5Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Sese034002.OriginalAndCurrentQuantities4 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Sese034002.OtherIdentification2 {
        + Tp  : ISO20022.Sese034002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese034002.OtherIdentification2 *-- ISO20022.Sese034002.IdentificationSource4Choice
    class ISO20022.Sese034002.OwnershipLegalRestrictions1Code {
        RSTR = 1
        NRST = 2
        A144 = 3
    }
    class ISO20022.Sese034002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Sese034002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese034002.PartyIdentification136Choice *-- ISO20022.Sese034002.GenericIdentification84
    class ISO20022.Sese034002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Sese034002.NameAndAddress12
        + PrtryId  : ISO20022.Sese034002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese034002.PartyIdentification137Choice *-- ISO20022.Sese034002.NameAndAddress12
    ISO20022.Sese034002.PartyIdentification137Choice *-- ISO20022.Sese034002.GenericIdentification84
    class ISO20022.Sese034002.PartyIdentification145Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese034002.NameAndAddress12
        + AnyBIC  : String
    }
    ISO20022.Sese034002.PartyIdentification145Choice *-- ISO20022.Sese034002.NameAndAddress12
    class ISO20022.Sese034002.PartyIdentification156 {
        + LEI  : String
        + Id  : ISO20022.Sese034002.PartyIdentification136Choice
    }
    ISO20022.Sese034002.PartyIdentification156 *-- ISO20022.Sese034002.PartyIdentification136Choice
    class ISO20022.Sese034002.PartyIdentification162 {
        + AddtlInf  : ISO20022.Sese034002.PartyTextInformation3
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese034002.DateAndDateTime2Choice
        + AltrnId  : ISO20022.Sese034002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese034002.PartyIdentification145Choice
    }
    ISO20022.Sese034002.PartyIdentification162 *-- ISO20022.Sese034002.PartyTextInformation3
    ISO20022.Sese034002.PartyIdentification162 *-- ISO20022.Sese034002.DateAndDateTime2Choice
    ISO20022.Sese034002.PartyIdentification162 *-- ISO20022.Sese034002.AlternatePartyIdentification9
    ISO20022.Sese034002.PartyIdentification162 *-- ISO20022.Sese034002.PartyIdentification145Choice
    class ISO20022.Sese034002.PartyIdentification170 {
        + LEI  : String
        + Id  : ISO20022.Sese034002.PartyIdentification176Choice
    }
    ISO20022.Sese034002.PartyIdentification170 *-- ISO20022.Sese034002.PartyIdentification176Choice
    class ISO20022.Sese034002.PartyIdentification176Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese034002.NameAndAddress12
        + PrtryId  : ISO20022.Sese034002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese034002.PartyIdentification176Choice *-- ISO20022.Sese034002.NameAndAddress12
    ISO20022.Sese034002.PartyIdentification176Choice *-- ISO20022.Sese034002.GenericIdentification84
    class ISO20022.Sese034002.PartyIdentificationAndAccount213 {
        + AddtlInf  : ISO20022.Sese034002.PartyTextInformation3
        + PrcgId  : String
        + PrcgDt  : ISO20022.Sese034002.DateAndDateTime2Choice
        + BlckChainAdrOrWllt  : ISO20022.Sese034002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese034002.SecuritiesAccount37
        + AltrnId  : ISO20022.Sese034002.AlternatePartyIdentification9
        + LEI  : String
        + Id  : ISO20022.Sese034002.PartyIdentification137Choice
    }
    ISO20022.Sese034002.PartyIdentificationAndAccount213 *-- ISO20022.Sese034002.PartyTextInformation3
    ISO20022.Sese034002.PartyIdentificationAndAccount213 *-- ISO20022.Sese034002.DateAndDateTime2Choice
    ISO20022.Sese034002.PartyIdentificationAndAccount213 *-- ISO20022.Sese034002.BlockChainAddressWallet7
    ISO20022.Sese034002.PartyIdentificationAndAccount213 *-- ISO20022.Sese034002.SecuritiesAccount37
    ISO20022.Sese034002.PartyIdentificationAndAccount213 *-- ISO20022.Sese034002.AlternatePartyIdentification9
    ISO20022.Sese034002.PartyIdentificationAndAccount213 *-- ISO20022.Sese034002.PartyIdentification137Choice
    class ISO20022.Sese034002.PartyTextInformation3 {
        + RegnDtls  : String
        + PtyCtctDtls  : String
        + DclrtnDtls  : String
    }
    class ISO20022.Sese034002.PendingProcessingReason11 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese034002.PendingProcessingReason13Choice
    }
    ISO20022.Sese034002.PendingProcessingReason11 *-- ISO20022.Sese034002.PendingProcessingReason13Choice
    class ISO20022.Sese034002.PendingProcessingReason13Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.PendingProcessingReason13Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.PendingProcessingReason1Code {
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
    class ISO20022.Sese034002.PendingProcessingStatus14Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese034002.PendingProcessingReason11~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese034002.PendingProcessingStatus14Choice *-- ISO20022.Sese034002.PendingProcessingReason11
    class ISO20022.Sese034002.PendingReason1Code {
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
        FUTU = 30
        LINK = 31
        INCA = 32
        FLIM = 33
        DEPO = 34
        COLL = 35
        YCOL = 36
        CMON = 37
        NOFX = 38
        NMAS = 39
        PART = 40
        PREA = 41
        GLOB = 42
        MUNO = 43
        CLAC = 44
        NEWI = 45
        CHAS = 46
        BLOC = 47
        DOCC = 48
        DOCY = 49
        TAMM = 50
        PHSE = 51
        AWSH = 52
        REFU = 53
        CAIS = 54
        ADEA = 55
        AWMO = 56
    }
    class ISO20022.Sese034002.PendingReason20 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese034002.PendingReason37Choice
    }
    ISO20022.Sese034002.PendingReason20 *-- ISO20022.Sese034002.PendingReason37Choice
    class ISO20022.Sese034002.PendingReason21 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese034002.PendingReason38Choice
    }
    ISO20022.Sese034002.PendingReason21 *-- ISO20022.Sese034002.PendingReason38Choice
    class ISO20022.Sese034002.PendingReason37Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.PendingReason37Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.PendingReason38Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.PendingReason38Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.PendingReason6Code {
        CDRE = 1
        CDCY = 2
        CDRG = 3
        OTHR = 4
        CONF = 5
        ADEA = 6
    }
    class ISO20022.Sese034002.PendingStatus46Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese034002.PendingReason20~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese034002.PendingStatus46Choice *-- ISO20022.Sese034002.PendingReason20
    class ISO20022.Sese034002.PendingStatus47Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese034002.PendingReason21~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese034002.PendingStatus47Choice *-- ISO20022.Sese034002.PendingReason21
    class ISO20022.Sese034002.PlaceOfTradeIdentification2 {
        + LEI  : String
        + MktTpAndId  : ISO20022.Sese034002.MarketIdentification90
    }
    ISO20022.Sese034002.PlaceOfTradeIdentification2 *-- ISO20022.Sese034002.MarketIdentification90
    class ISO20022.Sese034002.ProcessingStatus90Choice {
        + ModReqd  : ISO20022.Sese034002.ProprietaryReason5
        + CxlReqd  : ISO20022.Sese034002.ProprietaryReason5
        + Prtry  : ISO20022.Sese034002.ProprietaryStatusAndReason7
        + Canc  : ISO20022.Sese034002.CancellationStatus18Choice
        + Rpr  : ISO20022.Sese034002.RepairStatus15Choice
        + Rjctd  : ISO20022.Sese034002.RejectionStatus40Choice
        + PdgPrcg  : ISO20022.Sese034002.PendingProcessingStatus14Choice
        + AckdAccptd  : ISO20022.Sese034002.AcknowledgedAcceptedStatus25Choice
        + PdgCxl  : ISO20022.Sese034002.PendingStatus46Choice
    }
    ISO20022.Sese034002.ProcessingStatus90Choice *-- ISO20022.Sese034002.ProprietaryReason5
    ISO20022.Sese034002.ProcessingStatus90Choice *-- ISO20022.Sese034002.ProprietaryReason5
    ISO20022.Sese034002.ProcessingStatus90Choice *-- ISO20022.Sese034002.ProprietaryStatusAndReason7
    ISO20022.Sese034002.ProcessingStatus90Choice *-- ISO20022.Sese034002.CancellationStatus18Choice
    ISO20022.Sese034002.ProcessingStatus90Choice *-- ISO20022.Sese034002.RepairStatus15Choice
    ISO20022.Sese034002.ProcessingStatus90Choice *-- ISO20022.Sese034002.RejectionStatus40Choice
    ISO20022.Sese034002.ProcessingStatus90Choice *-- ISO20022.Sese034002.PendingProcessingStatus14Choice
    ISO20022.Sese034002.ProcessingStatus90Choice *-- ISO20022.Sese034002.AcknowledgedAcceptedStatus25Choice
    ISO20022.Sese034002.ProcessingStatus90Choice *-- ISO20022.Sese034002.PendingStatus46Choice
    class ISO20022.Sese034002.ProprietaryReason5 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Sese034002.GenericIdentification47
    }
    ISO20022.Sese034002.ProprietaryReason5 *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.ProprietaryStatusAndReason7 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Sese034002.ProprietaryReason5~
        + PrtrySts  : ISO20022.Sese034002.GenericIdentification47
    }
    ISO20022.Sese034002.ProprietaryStatusAndReason7 *-- ISO20022.Sese034002.ProprietaryReason5
    ISO20022.Sese034002.ProprietaryStatusAndReason7 *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.Quantity54Choice {
        + OrgnlAndCurFace  : ISO20022.Sese034002.OriginalAndCurrentQuantities4
        + Qty  : ISO20022.Sese034002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Sese034002.Quantity54Choice *-- ISO20022.Sese034002.OriginalAndCurrentQuantities4
    ISO20022.Sese034002.Quantity54Choice *-- ISO20022.Sese034002.FinancialInstrumentQuantity36Choice
    class ISO20022.Sese034002.Rate2 {
        + Rate  : Decimal
        + Sgn  : String
    }
    class ISO20022.Sese034002.RateName2 {
        + RateNm  : String
        + Issr  : String
    }
    class ISO20022.Sese034002.RateOrName2Choice {
        + RateNm  : ISO20022.Sese034002.RateName2
        + Rate  : ISO20022.Sese034002.Rate2
    }
    ISO20022.Sese034002.RateOrName2Choice *-- ISO20022.Sese034002.RateName2
    ISO20022.Sese034002.RateOrName2Choice *-- ISO20022.Sese034002.Rate2
    class ISO20022.Sese034002.RateType1Code {
        VARI = 1
        FORF = 2
        FIXE = 3
    }
    class ISO20022.Sese034002.RateType67Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.RateType67Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese034002.RejectionReason46Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.RejectionReason46Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.RejectionReason64 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese034002.RejectionReason46Choice
    }
    ISO20022.Sese034002.RejectionReason64 *-- ISO20022.Sese034002.RejectionReason46Choice
    class ISO20022.Sese034002.RejectionReason70Code {
        PLIS = 1
        INVE = 2
        IEXE = 3
        OTHR = 4
        DEPT = 5
        ICUS = 6
        INPS = 7
        ICAG = 8
        RSPR = 9
        RERT = 10
        REPP = 11
        REPO = 12
        REPA = 13
        VASU = 14
        TERM = 15
        FORF = 16
        CADE = 17
        SDUT = 18
        SETR = 19
        DDAT = 20
        CASY = 21
        CAEV = 22
        IIND = 23
        SETS = 24
        TXST = 25
        MUNO = 26
        BATC = 27
        MINO = 28
        DMON = 29
        REFE = 30
        PHYS = 31
        NCRR = 32
        RTGS = 33
        PLCE = 34
        DTRD = 35
        DDEA = 36
        CASH = 37
        LATE = 38
        DSEC = 39
        ADEA = 40
        DQUA = 41
        SAFE = 42
    }
    class ISO20022.Sese034002.RejectionStatus40Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese034002.RejectionReason64~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese034002.RejectionStatus40Choice *-- ISO20022.Sese034002.RejectionReason64
    class ISO20022.Sese034002.RepairReason11 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese034002.RepairReason13Choice
    }
    ISO20022.Sese034002.RepairReason11 *-- ISO20022.Sese034002.RepairReason13Choice
    class ISO20022.Sese034002.RepairReason13Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.RepairReason13Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.RepairReason5Code {
        FORF = 1
        TERM = 2
        REPP = 3
        REPO = 4
        VASU = 5
        RSPR = 6
        RERT = 7
        CADE = 8
        REPA = 9
        ICUS = 10
        DEPT = 11
        ICAG = 12
        IEXE = 13
        OTHR = 14
        SDUT = 15
        INPS = 16
        TXST = 17
        SETS = 18
        SETR = 19
        SAFE = 20
        RTGS = 21
        REFE = 22
        PLCE = 23
        PHYS = 24
        NCRR = 25
        MUNO = 26
        MINO = 27
        IIND = 28
        DTRD = 29
        DSEC = 30
        DQUA = 31
        DMON = 32
        DDEA = 33
        DDAT = 34
        CASY = 35
        CASH = 36
        CAEV = 37
        BATC = 38
    }
    class ISO20022.Sese034002.RepairStatus15Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese034002.RepairReason11~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese034002.RepairStatus15Choice *-- ISO20022.Sese034002.RepairReason11
    class ISO20022.Sese034002.RepoCallAcknowledgementReason2Code {
        ADEA = 1
        CALP = 2
        CALD = 3
    }
    class ISO20022.Sese034002.RepoCallRequestStatus9Choice {
        + Prtry  : ISO20022.Sese034002.ProprietaryStatusAndReason7
        + Dnd  : ISO20022.Sese034002.DeniedStatus18Choice
        + AckdAccptd  : ISO20022.Sese034002.AcknowledgedAcceptedStatus27Choice
    }
    ISO20022.Sese034002.RepoCallRequestStatus9Choice *-- ISO20022.Sese034002.ProprietaryStatusAndReason7
    ISO20022.Sese034002.RepoCallRequestStatus9Choice *-- ISO20022.Sese034002.DeniedStatus18Choice
    ISO20022.Sese034002.RepoCallRequestStatus9Choice *-- ISO20022.Sese034002.AcknowledgedAcceptedStatus27Choice
    class ISO20022.Sese034002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese034002.RestrictedFINActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese034002.Restriction6Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.Restriction6Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.SafeKeepingPlace4 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Sese034002.SafekeepingPlaceFormat39Choice
    }
    ISO20022.Sese034002.SafeKeepingPlace4 *-- ISO20022.Sese034002.SafekeepingPlaceFormat39Choice
    class ISO20022.Sese034002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Sese034002.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Sese034002.SafekeepingPlaceFormat39Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification85
        + TpAndId  : ISO20022.Sese034002.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Sese034002.SafekeepingPlaceTypeAndText15
    }
    ISO20022.Sese034002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese034002.GenericIdentification85
    ISO20022.Sese034002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese034002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Sese034002.SafekeepingPlaceFormat39Choice *-- ISO20022.Sese034002.SafekeepingPlaceTypeAndText15
    class ISO20022.Sese034002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese034002.SafekeepingPlaceTypeAndText15 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Sese034002.SecuritiesAccount30 {
        + Nm  : String
        + Tp  : ISO20022.Sese034002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese034002.SecuritiesAccount30 *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.SecuritiesAccount37 {
        + Nm  : String
        + Tp  : ISO20022.Sese034002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese034002.SecuritiesAccount37 *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.SecuritiesFinancingStatusAdvice002V09 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese034002.SupplementaryData1~
        + TxDtls  : ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53
        + RepoCallReqSts  : ISO20022.Sese034002.RepoCallRequestStatus9Choice
        + SttlmSts  : ISO20022.Sese034002.SettlementStatus21Choice
        + IfrrdMtchgSts  : ISO20022.Sese034002.MatchingStatus29Choice
        + MtchgSts  : ISO20022.Sese034002.MatchingStatus29Choice
        + PrcgSts  : ISO20022.Sese034002.ProcessingStatus90Choice
        + TxId  : ISO20022.Sese034002.TransactionIdentifications35
    }
    ISO20022.Sese034002.SecuritiesFinancingStatusAdvice002V09 *-- ISO20022.Sese034002.SupplementaryData1
    ISO20022.Sese034002.SecuritiesFinancingStatusAdvice002V09 *-- ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53
    ISO20022.Sese034002.SecuritiesFinancingStatusAdvice002V09 *-- ISO20022.Sese034002.RepoCallRequestStatus9Choice
    ISO20022.Sese034002.SecuritiesFinancingStatusAdvice002V09 *-- ISO20022.Sese034002.SettlementStatus21Choice
    ISO20022.Sese034002.SecuritiesFinancingStatusAdvice002V09 *-- ISO20022.Sese034002.MatchingStatus29Choice
    ISO20022.Sese034002.SecuritiesFinancingStatusAdvice002V09 *-- ISO20022.Sese034002.MatchingStatus29Choice
    ISO20022.Sese034002.SecuritiesFinancingStatusAdvice002V09 *-- ISO20022.Sese034002.ProcessingStatus90Choice
    ISO20022.Sese034002.SecuritiesFinancingStatusAdvice002V09 *-- ISO20022.Sese034002.TransactionIdentifications35
    class ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 {
        + SttlmInstrPrcgAddtlDtls  : String
        + Invstr  : ISO20022.Sese034002.PartyIdentification170
        + RcvgSttlmPties  : ISO20022.Sese034002.SettlementParties107
        + DlvrgSttlmPties  : ISO20022.Sese034002.SettlementParties107
        + Sprd  : ISO20022.Sese034002.Rate2
        + PricgRate  : ISO20022.Sese034002.RateOrName2Choice
        + SctiesHrcut  : ISO20022.Sese034002.Rate2
        + StockLnMrgn  : ISO20022.Sese034002.Rate2
        + RpRate  : ISO20022.Sese034002.Rate2
        + VarblRateSpprt  : ISO20022.Sese034002.RateName2
        + RateTp  : ISO20022.Sese034002.RateType67Choice
        + SttlmParams  : ISO20022.Sese034002.SettlementDetails173
        + Pmt  : String
        + SctiesMvmntTp  : String
        + SctiesFincgTxTp  : String
        + RateChngDt  : ISO20022.Sese034002.DateAndDateTime2Choice
        + LateDlvryDt  : ISO20022.Sese034002.DateAndDateTime2Choice
        + XpctdValDt  : ISO20022.Sese034002.DateAndDateTime2Choice
        + XpctdSttlmDt  : ISO20022.Sese034002.DateAndDateTime2Choice
        + TradDt  : ISO20022.Sese034002.TradeDate9Choice
        + TermntnDt  : ISO20022.Sese034002.TerminationDate7Choice
        + OpngSttlmDt  : ISO20022.Sese034002.SettlementDate32Choice
        + TermntnTxAmt  : ISO20022.Sese034002.AmountAndDirection59
        + OpngSttlmAmt  : ISO20022.Sese034002.AmountAndDirection67
        + SttlmQty  : ISO20022.Sese034002.Quantity54Choice
        + FinInstrmId  : ISO20022.Sese034002.SecurityIdentification20
        + PlcOfTrad  : ISO20022.Sese034002.PlaceOfTradeIdentification2
        + SfkpgPlc  : ISO20022.Sese034002.SafeKeepingPlace4
        + BlckChainAdrOrWllt  : ISO20022.Sese034002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese034002.SecuritiesAccount30
        + AcctOwnr  : ISO20022.Sese034002.PartyIdentification156
        + ClntTrptyCollTxId  : String
        + TrptyAgtSvcPrvdrCollTxId  : String
        + CorpActnEvtId  : String
        + PoolId  : String
        + ClsgLegId  : String
        + SctiesFincgTradId  : String
    }
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.PartyIdentification170
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.SettlementParties107
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.SettlementParties107
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.Rate2
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.RateOrName2Choice
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.Rate2
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.Rate2
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.Rate2
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.RateName2
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.RateType67Choice
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.SettlementDetails173
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.DateAndDateTime2Choice
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.DateAndDateTime2Choice
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.DateAndDateTime2Choice
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.DateAndDateTime2Choice
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.TradeDate9Choice
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.TerminationDate7Choice
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.SettlementDate32Choice
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.AmountAndDirection59
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.AmountAndDirection67
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.Quantity54Choice
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.SecurityIdentification20
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.PlaceOfTradeIdentification2
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.SafeKeepingPlace4
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.BlockChainAddressWallet7
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.SecuritiesAccount30
    ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53 *-- ISO20022.Sese034002.PartyIdentification156
    class ISO20022.Sese034002.SecuritiesFinancingTransactionType2Code {
        SBBK = 1
        BSBK = 2
        SECL = 3
        SECB = 4
        RVPO = 5
        REPU = 6
    }
    class ISO20022.Sese034002.SecuritiesRTGS5Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Sese034002.SecuritiesRTGS5Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese034002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Sese034002.SecurityIdentification20 *-- ISO20022.Sese034002.OtherIdentification2
    class ISO20022.Sese034002.SettlementDate32Choice {
        + DtCd  : ISO20022.Sese034002.SettlementDateCode11Choice
        + Dt  : ISO20022.Sese034002.DateAndDateTime2Choice
    }
    ISO20022.Sese034002.SettlementDate32Choice *-- ISO20022.Sese034002.SettlementDateCode11Choice
    ISO20022.Sese034002.SettlementDate32Choice *-- ISO20022.Sese034002.DateAndDateTime2Choice
    class ISO20022.Sese034002.SettlementDateCode11Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.SettlementDateCode11Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.SettlementDetails173 {
        + ElgblForColl  : String
        + PrtlSttlmInd  : String
        + CCPElgblty  : ISO20022.Sese034002.CentralCounterPartyEligibility5Choice
        + NetgElgblty  : ISO20022.Sese034002.NettingEligibility5Choice
        + SttlmSysMtd  : ISO20022.Sese034002.SettlementSystemMethod5Choice
        + LglRstrctns  : ISO20022.Sese034002.Restriction6Choice
        + BlckTrad  : ISO20022.Sese034002.BlockTrade5Choice
        + MktClntSd  : ISO20022.Sese034002.MarketClientSide7Choice
        + TaxCpcty  : ISO20022.Sese034002.TaxCapacityParty5Choice
        + CshClrSys  : ISO20022.Sese034002.CashSettlementSystem5Choice
        + BnfclOwnrsh  : ISO20022.Sese034002.BeneficialOwnership5Choice
        + SctiesRTGS  : ISO20022.Sese034002.SecuritiesRTGS5Choice
        + StmpDtyTaxBsis  : ISO20022.Sese034002.GenericIdentification47
        + SttlgCpcty  : ISO20022.Sese034002.SettlingCapacity8Choice
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Sese034002.SettlementTransactionCondition22Choice~
        + HldInd  : String
    }
    ISO20022.Sese034002.SettlementDetails173 *-- ISO20022.Sese034002.CentralCounterPartyEligibility5Choice
    ISO20022.Sese034002.SettlementDetails173 *-- ISO20022.Sese034002.NettingEligibility5Choice
    ISO20022.Sese034002.SettlementDetails173 *-- ISO20022.Sese034002.SettlementSystemMethod5Choice
    ISO20022.Sese034002.SettlementDetails173 *-- ISO20022.Sese034002.Restriction6Choice
    ISO20022.Sese034002.SettlementDetails173 *-- ISO20022.Sese034002.BlockTrade5Choice
    ISO20022.Sese034002.SettlementDetails173 *-- ISO20022.Sese034002.MarketClientSide7Choice
    ISO20022.Sese034002.SettlementDetails173 *-- ISO20022.Sese034002.TaxCapacityParty5Choice
    ISO20022.Sese034002.SettlementDetails173 *-- ISO20022.Sese034002.CashSettlementSystem5Choice
    ISO20022.Sese034002.SettlementDetails173 *-- ISO20022.Sese034002.BeneficialOwnership5Choice
    ISO20022.Sese034002.SettlementDetails173 *-- ISO20022.Sese034002.SecuritiesRTGS5Choice
    ISO20022.Sese034002.SettlementDetails173 *-- ISO20022.Sese034002.GenericIdentification47
    ISO20022.Sese034002.SettlementDetails173 *-- ISO20022.Sese034002.SettlingCapacity8Choice
    ISO20022.Sese034002.SettlementDetails173 *-- ISO20022.Sese034002.SettlementTransactionCondition22Choice
    class ISO20022.Sese034002.SettlementParties107 {
        + Pty5  : ISO20022.Sese034002.PartyIdentificationAndAccount213
        + Pty4  : ISO20022.Sese034002.PartyIdentificationAndAccount213
        + Pty3  : ISO20022.Sese034002.PartyIdentificationAndAccount213
        + Pty2  : ISO20022.Sese034002.PartyIdentificationAndAccount213
        + Pty1  : ISO20022.Sese034002.PartyIdentificationAndAccount213
        + Dpstry  : ISO20022.Sese034002.PartyIdentification162
    }
    ISO20022.Sese034002.SettlementParties107 *-- ISO20022.Sese034002.PartyIdentificationAndAccount213
    ISO20022.Sese034002.SettlementParties107 *-- ISO20022.Sese034002.PartyIdentificationAndAccount213
    ISO20022.Sese034002.SettlementParties107 *-- ISO20022.Sese034002.PartyIdentificationAndAccount213
    ISO20022.Sese034002.SettlementParties107 *-- ISO20022.Sese034002.PartyIdentificationAndAccount213
    ISO20022.Sese034002.SettlementParties107 *-- ISO20022.Sese034002.PartyIdentificationAndAccount213
    ISO20022.Sese034002.SettlementParties107 *-- ISO20022.Sese034002.PartyIdentification162
    class ISO20022.Sese034002.SettlementStatus21Choice {
        + Prtry  : ISO20022.Sese034002.ProprietaryStatusAndReason7
        + Flng  : ISO20022.Sese034002.FailingStatus12Choice
        + Pdg  : ISO20022.Sese034002.PendingStatus47Choice
    }
    ISO20022.Sese034002.SettlementStatus21Choice *-- ISO20022.Sese034002.ProprietaryStatusAndReason7
    ISO20022.Sese034002.SettlementStatus21Choice *-- ISO20022.Sese034002.FailingStatus12Choice
    ISO20022.Sese034002.SettlementStatus21Choice *-- ISO20022.Sese034002.PendingStatus47Choice
    class ISO20022.Sese034002.SettlementSystemMethod1Code {
        YSET = 1
        NSET = 2
    }
    class ISO20022.Sese034002.SettlementSystemMethod5Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.SettlementSystemMethod5Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.SettlementTransactionCondition22Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.SettlementTransactionCondition22Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.SettlementTransactionCondition5Code {
        PARQ = 1
        PARC = 2
        NPAR = 3
        PART = 4
    }
    class ISO20022.Sese034002.SettlementTransactionCondition6Code {
        ADEA = 1
        RHYP = 2
        TRAN = 3
        NOMC = 4
        TRIP = 5
        UNEX = 6
        PENS = 7
        EXPI = 8
        SPST = 9
        SPDL = 10
        SHOR = 11
        RESI = 12
        PHYS = 13
        KNOC = 14
        FRCL = 15
        EXER = 16
        DRAW = 17
        DLWM = 18
        DIRT = 19
        CLEN = 20
        BUTC = 21
        ASGN = 22
    }
    class ISO20022.Sese034002.SettlingCapacity2Code {
        RISP = 1
        SPRI = 2
        CUST = 3
        SAGE = 4
    }
    class ISO20022.Sese034002.SettlingCapacity8Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.SettlingCapacity8Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.SupplementaryData1 {
        + Envlp  : ISO20022.Sese034002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese034002.SupplementaryData1 *-- ISO20022.Sese034002.SupplementaryDataEnvelope1
    class ISO20022.Sese034002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese034002.TaxCapacityParty5Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.TaxCapacityParty5Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.TaxLiability1Code {
        AGEN = 1
        PRIN = 2
    }
    class ISO20022.Sese034002.TerminationDate7Choice {
        + Cd  : ISO20022.Sese034002.DateCode32Choice
        + Dt  : ISO20022.Sese034002.DateAndDateTime2Choice
    }
    ISO20022.Sese034002.TerminationDate7Choice *-- ISO20022.Sese034002.DateCode32Choice
    ISO20022.Sese034002.TerminationDate7Choice *-- ISO20022.Sese034002.DateAndDateTime2Choice
    class ISO20022.Sese034002.TradeDate9Choice {
        + DtCd  : ISO20022.Sese034002.TradeDateCode4Choice
        + Dt  : ISO20022.Sese034002.DateAndDateTime2Choice
    }
    ISO20022.Sese034002.TradeDate9Choice *-- ISO20022.Sese034002.TradeDateCode4Choice
    ISO20022.Sese034002.TradeDate9Choice *-- ISO20022.Sese034002.DateAndDateTime2Choice
    class ISO20022.Sese034002.TradeDateCode4Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.TradeDateCode4Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.TransactionIdentifications35 {
        + CmonId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    class ISO20022.Sese034002.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Sese034002.UnmatchedReason13Code {
        DCMX = 1
        DMCT = 2
        VASU = 3
        DELN = 4
        DTRD = 5
        TXST = 6
        SETR = 7
        SETS = 8
        DDAT = 9
        DMON = 10
        SAFE = 11
        RTGS = 12
        RERT = 13
        REPO = 14
        REPP = 15
        CADE = 16
        REPA = 17
        REGD = 18
        IEXE = 19
        ICUS = 20
        ICAG = 21
        DEPT = 22
        PODU = 23
        PLCE = 24
        INPS = 25
        PLIS = 26
        PHYS = 27
        FRAP = 28
        OTHR = 29
        DTRA = 30
        NMAS = 31
        CMIS = 32
        LATE = 33
        LEOG = 34
        INVE = 35
        FORF = 36
        DQUA = 37
        DSEC = 38
        DDEA = 39
        NCRR = 40
        CLAT = 41
        CPCA = 42
        IIND = 43
        TERM = 44
        ACRU = 45
        ADEA = 46
    }
    class ISO20022.Sese034002.UnmatchedReason18 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese034002.UnmatchedReason25Choice
    }
    ISO20022.Sese034002.UnmatchedReason18 *-- ISO20022.Sese034002.UnmatchedReason25Choice
    class ISO20022.Sese034002.UnmatchedReason25Choice {
        + Prtry  : ISO20022.Sese034002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese034002.UnmatchedReason25Choice *-- ISO20022.Sese034002.GenericIdentification47
    class ISO20022.Sese034002.UnmatchedStatus19Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese034002.UnmatchedReason18~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese034002.UnmatchedStatus19Choice *-- ISO20022.Sese034002.UnmatchedReason18
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

## Value ISO20022.Sese034002.AcknowledgedAcceptedStatus25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese034002.AcknowledgementReason13>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese034002.AcknowledgedAcceptedStatus27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese034002.AcknowledgementReason15>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese034002.AcknowledgementReason13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese034002.AcknowledgementReason16Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese034002.AcknowledgementReason15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese034002.AcknowledgementReason18Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese034002.AcknowledgementReason16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese034002.AcknowledgementReason18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese034002.AcknowledgementReason5Code


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

## Value ISO20022.Sese034002.AlternatePartyIdentification9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Sese034002.IdentificationType44Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AltrnId""",AltrnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Sese034002.AmountAndDirection59


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese034002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Sese034002.AmountAndDirection67


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese034002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese034002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese034002.BeneficialOwnership5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese034002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Enum ISO20022.Sese034002.BlockTrade1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BLCH|Int32||XmlEnum("""BLCH""")|1|
||BLPA|Int32||XmlEnum("""BLPA""")|2|

---

## Value ISO20022.Sese034002.BlockTrade5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese034002.CancellationReason15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese034002.CancellationReason25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese034002.CancellationReason25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese034002.CancellationStatus18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese034002.CancellationReason15>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese034002.CancelledStatusReason9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||SCEX|Int32||XmlEnum("""SCEX""")|2|
||CORP|Int32||XmlEnum("""CORP""")|3|
||CANZ|Int32||XmlEnum("""CANZ""")|4|
||CANT|Int32||XmlEnum("""CANT""")|5|
||CXLR|Int32||XmlEnum("""CXLR""")|6|
||CSUB|Int32||XmlEnum("""CSUB""")|7|
||CANS|Int32||XmlEnum("""CANS""")|8|
||CANI|Int32||XmlEnum("""CANI""")|9|

---

## Enum ISO20022.Sese034002.CashSettlementSystem2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETS|Int32||XmlEnum("""NETS""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Value ISO20022.Sese034002.CashSettlementSystem5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese034002.CentralCounterPartyEligibility5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Enum ISO20022.Sese034002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese034002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Sese034002.DateCode32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese034002.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese034002.DateType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||OPEN|Int32||XmlEnum("""OPEN""")|2|

---

## Enum ISO20022.Sese034002.DateType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEN|Int32||XmlEnum("""OPEN""")|1|

---

## Enum ISO20022.Sese034002.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Value ISO20022.Sese034002.DeniedReason13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese034002.DeniedReason18Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese034002.DeniedReason18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese034002.DeniedReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||LATE|Int32||XmlEnum("""LATE""")|2|
||DFOR|Int32||XmlEnum("""DFOR""")|3|
||DCAL|Int32||XmlEnum("""DCAL""")|4|
||ADEA|Int32||XmlEnum("""ADEA""")|5|

---

## Value ISO20022.Sese034002.DeniedStatus18Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese034002.DeniedReason13>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Type ISO20022.Sese034002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesFincgStsAdvc|ISO20022.Sese034002.SecuritiesFinancingStatusAdvice002V09||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesFincgStsAdvc))|

---

## Value ISO20022.Sese034002.FailingReason10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese034002.FailingReason11Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese034002.FailingReason11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese034002.FailingReason2Code


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

## Value ISO20022.Sese034002.FailingStatus12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese034002.FailingReason10>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese034002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese034002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese034002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese034002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Sese034002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese034002.IdentificationType44Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese034002.MarketClientSide1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MAKT|Int32||XmlEnum("""MAKT""")|1|
||CLNT|Int32||XmlEnum("""CLNT""")|2|

---

## Value ISO20022.Sese034002.MarketClientSide7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese034002.MarketIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Sese034002.MarketIdentification90


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese034002.MarketType16Choice||XmlElement()||
|+|Id|ISO20022.Sese034002.MarketIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Sese034002.MarketType16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese034002.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Value ISO20022.Sese034002.MatchingStatus29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.ProprietaryStatusAndReason7||XmlElement()||
|+|Umtchd|ISO20022.Sese034002.UnmatchedStatus19Choice||XmlElement()||
|+|Mtchd|ISO20022.Sese034002.ProprietaryReason5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Umtchd),validElement(Mtchd),validChoice(Prtry,Umtchd,Mtchd))|

---

## Value ISO20022.Sese034002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Sese034002.NettingEligibility5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Enum ISO20022.Sese034002.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Sese034002.OriginalAndCurrentQuantities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese034002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese034002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Enum ISO20022.Sese034002.OwnershipLegalRestrictions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSTR|Int32||XmlEnum("""RSTR""")|1|
||NRST|Int32||XmlEnum("""NRST""")|2|
||A144|Int32||XmlEnum("""A144""")|3|

---

## Value ISO20022.Sese034002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese034002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese034002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese034002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese034002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese034002.PartyIdentification145Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese034002.NameAndAddress12||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese034002.PartyIdentification156


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese034002.PartyIdentification136Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese034002.PartyIdentification162


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese034002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese034002.DateAndDateTime2Choice||XmlElement()||
|+|AltrnId|ISO20022.Sese034002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese034002.PartyIdentification145Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(PrcgDt),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese034002.PartyIdentification170


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese034002.PartyIdentification176Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese034002.PartyIdentification176Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese034002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese034002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese034002.PartyIdentificationAndAccount213


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Sese034002.PartyTextInformation3||XmlElement()||
|+|PrcgId|String||XmlElement()||
|+|PrcgDt|ISO20022.Sese034002.DateAndDateTime2Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese034002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese034002.SecuritiesAccount37||XmlElement()||
|+|AltrnId|ISO20022.Sese034002.AlternatePartyIdentification9||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese034002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(PrcgDt),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese034002.PartyTextInformation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegnDtls|String||XmlElement()||
|+|PtyCtctDtls|String||XmlElement()||
|+|DclrtnDtls|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RegnDtls""",RegnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""PtyCtctDtls""",PtyCtctDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""DclrtnDtls""",DclrtnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Value ISO20022.Sese034002.PendingProcessingReason11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese034002.PendingProcessingReason13Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese034002.PendingProcessingReason13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese034002.PendingProcessingReason1Code


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

## Value ISO20022.Sese034002.PendingProcessingStatus14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese034002.PendingProcessingReason11>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese034002.PendingReason1Code


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
||FUTU|Int32||XmlEnum("""FUTU""")|30|
||LINK|Int32||XmlEnum("""LINK""")|31|
||INCA|Int32||XmlEnum("""INCA""")|32|
||FLIM|Int32||XmlEnum("""FLIM""")|33|
||DEPO|Int32||XmlEnum("""DEPO""")|34|
||COLL|Int32||XmlEnum("""COLL""")|35|
||YCOL|Int32||XmlEnum("""YCOL""")|36|
||CMON|Int32||XmlEnum("""CMON""")|37|
||NOFX|Int32||XmlEnum("""NOFX""")|38|
||NMAS|Int32||XmlEnum("""NMAS""")|39|
||PART|Int32||XmlEnum("""PART""")|40|
||PREA|Int32||XmlEnum("""PREA""")|41|
||GLOB|Int32||XmlEnum("""GLOB""")|42|
||MUNO|Int32||XmlEnum("""MUNO""")|43|
||CLAC|Int32||XmlEnum("""CLAC""")|44|
||NEWI|Int32||XmlEnum("""NEWI""")|45|
||CHAS|Int32||XmlEnum("""CHAS""")|46|
||BLOC|Int32||XmlEnum("""BLOC""")|47|
||DOCC|Int32||XmlEnum("""DOCC""")|48|
||DOCY|Int32||XmlEnum("""DOCY""")|49|
||TAMM|Int32||XmlEnum("""TAMM""")|50|
||PHSE|Int32||XmlEnum("""PHSE""")|51|
||AWSH|Int32||XmlEnum("""AWSH""")|52|
||REFU|Int32||XmlEnum("""REFU""")|53|
||CAIS|Int32||XmlEnum("""CAIS""")|54|
||ADEA|Int32||XmlEnum("""ADEA""")|55|
||AWMO|Int32||XmlEnum("""AWMO""")|56|

---

## Value ISO20022.Sese034002.PendingReason20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese034002.PendingReason37Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese034002.PendingReason21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese034002.PendingReason38Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese034002.PendingReason37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese034002.PendingReason38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese034002.PendingReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CDRE|Int32||XmlEnum("""CDRE""")|1|
||CDCY|Int32||XmlEnum("""CDCY""")|2|
||CDRG|Int32||XmlEnum("""CDRG""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||CONF|Int32||XmlEnum("""CONF""")|5|
||ADEA|Int32||XmlEnum("""ADEA""")|6|

---

## Value ISO20022.Sese034002.PendingStatus46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese034002.PendingReason20>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese034002.PendingStatus47Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese034002.PendingReason21>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese034002.PlaceOfTradeIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|MktTpAndId|ISO20022.Sese034002.MarketIdentification90||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(MktTpAndId))|

---

## Value ISO20022.Sese034002.ProcessingStatus90Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ModReqd|ISO20022.Sese034002.ProprietaryReason5||XmlElement()||
|+|CxlReqd|ISO20022.Sese034002.ProprietaryReason5||XmlElement()||
|+|Prtry|ISO20022.Sese034002.ProprietaryStatusAndReason7||XmlElement()||
|+|Canc|ISO20022.Sese034002.CancellationStatus18Choice||XmlElement()||
|+|Rpr|ISO20022.Sese034002.RepairStatus15Choice||XmlElement()||
|+|Rjctd|ISO20022.Sese034002.RejectionStatus40Choice||XmlElement()||
|+|PdgPrcg|ISO20022.Sese034002.PendingProcessingStatus14Choice||XmlElement()||
|+|AckdAccptd|ISO20022.Sese034002.AcknowledgedAcceptedStatus25Choice||XmlElement()||
|+|PdgCxl|ISO20022.Sese034002.PendingStatus46Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ModReqd),validElement(CxlReqd),validElement(Prtry),validElement(Canc),validElement(Rpr),validElement(Rjctd),validElement(PdgPrcg),validElement(AckdAccptd),validElement(PdgCxl),validChoice(ModReqd,CxlReqd,Prtry,Canc,Rpr,Rjctd,PdgPrcg,AckdAccptd,PdgCxl))|

---

## Value ISO20022.Sese034002.ProprietaryReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Rsn))|

---

## Value ISO20022.Sese034002.ProprietaryStatusAndReason7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Sese034002.ProprietaryReason5>||XmlElement()||
|+|PrtrySts|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Sese034002.Quantity54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Sese034002.OriginalAndCurrentQuantities4||XmlElement()||
|+|Qty|ISO20022.Sese034002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Sese034002.Rate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|Sgn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese034002.RateName2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""RateNm""",RateNm,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""Issr""",Issr,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,8}"""))|

---

## Value ISO20022.Sese034002.RateOrName2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateNm|ISO20022.Sese034002.RateName2||XmlElement()||
|+|Rate|ISO20022.Sese034002.Rate2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateNm),validElement(Rate),validChoice(RateNm,Rate))|

---

## Enum ISO20022.Sese034002.RateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|
||FORF|Int32||XmlEnum("""FORF""")|2|
||FIXE|Int32||XmlEnum("""FIXE""")|3|

---

## Value ISO20022.Sese034002.RateType67Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese034002.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Sese034002.RejectionReason46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese034002.RejectionReason64


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese034002.RejectionReason46Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Enum ISO20022.Sese034002.RejectionReason70Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PLIS|Int32||XmlEnum("""PLIS""")|1|
||INVE|Int32||XmlEnum("""INVE""")|2|
||IEXE|Int32||XmlEnum("""IEXE""")|3|
||OTHR|Int32||XmlEnum("""OTHR""")|4|
||DEPT|Int32||XmlEnum("""DEPT""")|5|
||ICUS|Int32||XmlEnum("""ICUS""")|6|
||INPS|Int32||XmlEnum("""INPS""")|7|
||ICAG|Int32||XmlEnum("""ICAG""")|8|
||RSPR|Int32||XmlEnum("""RSPR""")|9|
||RERT|Int32||XmlEnum("""RERT""")|10|
||REPP|Int32||XmlEnum("""REPP""")|11|
||REPO|Int32||XmlEnum("""REPO""")|12|
||REPA|Int32||XmlEnum("""REPA""")|13|
||VASU|Int32||XmlEnum("""VASU""")|14|
||TERM|Int32||XmlEnum("""TERM""")|15|
||FORF|Int32||XmlEnum("""FORF""")|16|
||CADE|Int32||XmlEnum("""CADE""")|17|
||SDUT|Int32||XmlEnum("""SDUT""")|18|
||SETR|Int32||XmlEnum("""SETR""")|19|
||DDAT|Int32||XmlEnum("""DDAT""")|20|
||CASY|Int32||XmlEnum("""CASY""")|21|
||CAEV|Int32||XmlEnum("""CAEV""")|22|
||IIND|Int32||XmlEnum("""IIND""")|23|
||SETS|Int32||XmlEnum("""SETS""")|24|
||TXST|Int32||XmlEnum("""TXST""")|25|
||MUNO|Int32||XmlEnum("""MUNO""")|26|
||BATC|Int32||XmlEnum("""BATC""")|27|
||MINO|Int32||XmlEnum("""MINO""")|28|
||DMON|Int32||XmlEnum("""DMON""")|29|
||REFE|Int32||XmlEnum("""REFE""")|30|
||PHYS|Int32||XmlEnum("""PHYS""")|31|
||NCRR|Int32||XmlEnum("""NCRR""")|32|
||RTGS|Int32||XmlEnum("""RTGS""")|33|
||PLCE|Int32||XmlEnum("""PLCE""")|34|
||DTRD|Int32||XmlEnum("""DTRD""")|35|
||DDEA|Int32||XmlEnum("""DDEA""")|36|
||CASH|Int32||XmlEnum("""CASH""")|37|
||LATE|Int32||XmlEnum("""LATE""")|38|
||DSEC|Int32||XmlEnum("""DSEC""")|39|
||ADEA|Int32||XmlEnum("""ADEA""")|40|
||DQUA|Int32||XmlEnum("""DQUA""")|41|
||SAFE|Int32||XmlEnum("""SAFE""")|42|

---

## Value ISO20022.Sese034002.RejectionStatus40Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese034002.RejectionReason64>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese034002.RepairReason11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese034002.RepairReason13Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese034002.RepairReason13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese034002.RepairReason5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FORF|Int32||XmlEnum("""FORF""")|1|
||TERM|Int32||XmlEnum("""TERM""")|2|
||REPP|Int32||XmlEnum("""REPP""")|3|
||REPO|Int32||XmlEnum("""REPO""")|4|
||VASU|Int32||XmlEnum("""VASU""")|5|
||RSPR|Int32||XmlEnum("""RSPR""")|6|
||RERT|Int32||XmlEnum("""RERT""")|7|
||CADE|Int32||XmlEnum("""CADE""")|8|
||REPA|Int32||XmlEnum("""REPA""")|9|
||ICUS|Int32||XmlEnum("""ICUS""")|10|
||DEPT|Int32||XmlEnum("""DEPT""")|11|
||ICAG|Int32||XmlEnum("""ICAG""")|12|
||IEXE|Int32||XmlEnum("""IEXE""")|13|
||OTHR|Int32||XmlEnum("""OTHR""")|14|
||SDUT|Int32||XmlEnum("""SDUT""")|15|
||INPS|Int32||XmlEnum("""INPS""")|16|
||TXST|Int32||XmlEnum("""TXST""")|17|
||SETS|Int32||XmlEnum("""SETS""")|18|
||SETR|Int32||XmlEnum("""SETR""")|19|
||SAFE|Int32||XmlEnum("""SAFE""")|20|
||RTGS|Int32||XmlEnum("""RTGS""")|21|
||REFE|Int32||XmlEnum("""REFE""")|22|
||PLCE|Int32||XmlEnum("""PLCE""")|23|
||PHYS|Int32||XmlEnum("""PHYS""")|24|
||NCRR|Int32||XmlEnum("""NCRR""")|25|
||MUNO|Int32||XmlEnum("""MUNO""")|26|
||MINO|Int32||XmlEnum("""MINO""")|27|
||IIND|Int32||XmlEnum("""IIND""")|28|
||DTRD|Int32||XmlEnum("""DTRD""")|29|
||DSEC|Int32||XmlEnum("""DSEC""")|30|
||DQUA|Int32||XmlEnum("""DQUA""")|31|
||DMON|Int32||XmlEnum("""DMON""")|32|
||DDEA|Int32||XmlEnum("""DDEA""")|33|
||DDAT|Int32||XmlEnum("""DDAT""")|34|
||CASY|Int32||XmlEnum("""CASY""")|35|
||CASH|Int32||XmlEnum("""CASH""")|36|
||CAEV|Int32||XmlEnum("""CAEV""")|37|
||BATC|Int32||XmlEnum("""BATC""")|38|

---

## Value ISO20022.Sese034002.RepairStatus15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese034002.RepairReason11>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese034002.RepoCallAcknowledgementReason2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ADEA|Int32||XmlEnum("""ADEA""")|1|
||CALP|Int32||XmlEnum("""CALP""")|2|
||CALD|Int32||XmlEnum("""CALD""")|3|

---

## Value ISO20022.Sese034002.RepoCallRequestStatus9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.ProprietaryStatusAndReason7||XmlElement()||
|+|Dnd|ISO20022.Sese034002.DeniedStatus18Choice||XmlElement()||
|+|AckdAccptd|ISO20022.Sese034002.AcknowledgedAcceptedStatus27Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Dnd),validElement(AckdAccptd),validChoice(Prtry,Dnd,AckdAccptd))|

---

## Value ISO20022.Sese034002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese034002.RestrictedFINActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese034002.Restriction6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese034002.SafeKeepingPlace4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Sese034002.SafekeepingPlaceFormat39Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Sese034002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Sese034002.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Sese034002.SafekeepingPlaceFormat39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Sese034002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Sese034002.SafekeepingPlaceTypeAndText15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Sese034002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Sese034002.SafekeepingPlaceTypeAndText15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese034002.SecuritiesAccount30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Sese034002.SecuritiesAccount37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Aspect ISO20022.Sese034002.SecuritiesFinancingStatusAdvice002V09


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese034002.SupplementaryData1>||XmlElement()||
|+|TxDtls|ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53||XmlElement()||
|+|RepoCallReqSts|ISO20022.Sese034002.RepoCallRequestStatus9Choice||XmlElement()||
|+|SttlmSts|ISO20022.Sese034002.SettlementStatus21Choice||XmlElement()||
|+|IfrrdMtchgSts|ISO20022.Sese034002.MatchingStatus29Choice||XmlElement()||
|+|MtchgSts|ISO20022.Sese034002.MatchingStatus29Choice||XmlElement()||
|+|PrcgSts|ISO20022.Sese034002.ProcessingStatus90Choice||XmlElement()||
|+|TxId|ISO20022.Sese034002.TransactionIdentifications35||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TxDtls),validElement(RepoCallReqSts),validElement(SttlmSts),validElement(IfrrdMtchgSts),validElement(MtchgSts),validElement(PrcgSts),validElement(TxId))|

---

## Value ISO20022.Sese034002.SecuritiesFinancingTransactionDetails53


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmInstrPrcgAddtlDtls|String||XmlElement()||
|+|Invstr|ISO20022.Sese034002.PartyIdentification170||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese034002.SettlementParties107||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese034002.SettlementParties107||XmlElement()||
|+|Sprd|ISO20022.Sese034002.Rate2||XmlElement()||
|+|PricgRate|ISO20022.Sese034002.RateOrName2Choice||XmlElement()||
|+|SctiesHrcut|ISO20022.Sese034002.Rate2||XmlElement()||
|+|StockLnMrgn|ISO20022.Sese034002.Rate2||XmlElement()||
|+|RpRate|ISO20022.Sese034002.Rate2||XmlElement()||
|+|VarblRateSpprt|ISO20022.Sese034002.RateName2||XmlElement()||
|+|RateTp|ISO20022.Sese034002.RateType67Choice||XmlElement()||
|+|SttlmParams|ISO20022.Sese034002.SettlementDetails173||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
|+|SctiesFincgTxTp|String||XmlElement()||
|+|RateChngDt|ISO20022.Sese034002.DateAndDateTime2Choice||XmlElement()||
|+|LateDlvryDt|ISO20022.Sese034002.DateAndDateTime2Choice||XmlElement()||
|+|XpctdValDt|ISO20022.Sese034002.DateAndDateTime2Choice||XmlElement()||
|+|XpctdSttlmDt|ISO20022.Sese034002.DateAndDateTime2Choice||XmlElement()||
|+|TradDt|ISO20022.Sese034002.TradeDate9Choice||XmlElement()||
|+|TermntnDt|ISO20022.Sese034002.TerminationDate7Choice||XmlElement()||
|+|OpngSttlmDt|ISO20022.Sese034002.SettlementDate32Choice||XmlElement()||
|+|TermntnTxAmt|ISO20022.Sese034002.AmountAndDirection59||XmlElement()||
|+|OpngSttlmAmt|ISO20022.Sese034002.AmountAndDirection67||XmlElement()||
|+|SttlmQty|ISO20022.Sese034002.Quantity54Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Sese034002.SecurityIdentification20||XmlElement()||
|+|PlcOfTrad|ISO20022.Sese034002.PlaceOfTradeIdentification2||XmlElement()||
|+|SfkpgPlc|ISO20022.Sese034002.SafeKeepingPlace4||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese034002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese034002.SecuritiesAccount30||XmlElement()||
|+|AcctOwnr|ISO20022.Sese034002.PartyIdentification156||XmlElement()||
|+|ClntTrptyCollTxId|String||XmlElement()||
|+|TrptyAgtSvcPrvdrCollTxId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|ClsgLegId|String||XmlElement()||
|+|SctiesFincgTradId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SttlmInstrPrcgAddtlDtls""",SttlmInstrPrcgAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validElement(Invstr),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(Sprd),validElement(PricgRate),validElement(SctiesHrcut),validElement(StockLnMrgn),validElement(RpRate),validElement(VarblRateSpprt),validElement(RateTp),validElement(SttlmParams),validElement(RateChngDt),validElement(LateDlvryDt),validElement(XpctdValDt),validElement(XpctdSttlmDt),validElement(TradDt),validElement(TermntnDt),validElement(OpngSttlmDt),validElement(TermntnTxAmt),validElement(OpngSttlmAmt),validElement(SttlmQty),validElement(FinInstrmId),validElement(PlcOfTrad),validElement(SfkpgPlc),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validPattern("""ClntTrptyCollTxId""",ClntTrptyCollTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""TrptyAgtSvcPrvdrCollTxId""",TrptyAgtSvcPrvdrCollTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CorpActnEvtId""",CorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""PoolId""",PoolId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""ClsgLegId""",ClsgLegId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""SctiesFincgTradId""",SctiesFincgTradId,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,52}"""))|

---

## Enum ISO20022.Sese034002.SecuritiesFinancingTransactionType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SBBK|Int32||XmlEnum("""SBBK""")|1|
||BSBK|Int32||XmlEnum("""BSBK""")|2|
||SECL|Int32||XmlEnum("""SECL""")|3|
||SECB|Int32||XmlEnum("""SECB""")|4|
||RVPO|Int32||XmlEnum("""RVPO""")|5|
||REPU|Int32||XmlEnum("""REPU""")|6|

---

## Value ISO20022.Sese034002.SecuritiesRTGS5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Sese034002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese034002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese034002.SettlementDate32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese034002.SettlementDateCode11Choice||XmlElement()||
|+|Dt|ISO20022.Sese034002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese034002.SettlementDateCode11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese034002.SettlementDetails173


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ElgblForColl|String||XmlElement()||
|+|PrtlSttlmInd|String||XmlElement()||
|+|CCPElgblty|ISO20022.Sese034002.CentralCounterPartyEligibility5Choice||XmlElement()||
|+|NetgElgblty|ISO20022.Sese034002.NettingEligibility5Choice||XmlElement()||
|+|SttlmSysMtd|ISO20022.Sese034002.SettlementSystemMethod5Choice||XmlElement()||
|+|LglRstrctns|ISO20022.Sese034002.Restriction6Choice||XmlElement()||
|+|BlckTrad|ISO20022.Sese034002.BlockTrade5Choice||XmlElement()||
|+|MktClntSd|ISO20022.Sese034002.MarketClientSide7Choice||XmlElement()||
|+|TaxCpcty|ISO20022.Sese034002.TaxCapacityParty5Choice||XmlElement()||
|+|CshClrSys|ISO20022.Sese034002.CashSettlementSystem5Choice||XmlElement()||
|+|BnfclOwnrsh|ISO20022.Sese034002.BeneficialOwnership5Choice||XmlElement()||
|+|SctiesRTGS|ISO20022.Sese034002.SecuritiesRTGS5Choice||XmlElement()||
|+|StmpDtyTaxBsis|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|SttlgCpcty|ISO20022.Sese034002.SettlingCapacity8Choice||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Sese034002.SettlementTransactionCondition22Choice>||XmlElement()||
|+|HldInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CCPElgblty),validElement(NetgElgblty),validElement(SttlmSysMtd),validElement(LglRstrctns),validElement(BlckTrad),validElement(MktClntSd),validElement(TaxCpcty),validElement(CshClrSys),validElement(BnfclOwnrsh),validElement(SctiesRTGS),validElement(StmpDtyTaxBsis),validElement(SttlgCpcty),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond))|

---

## Value ISO20022.Sese034002.SettlementParties107


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese034002.PartyIdentificationAndAccount213||XmlElement()||
|+|Pty4|ISO20022.Sese034002.PartyIdentificationAndAccount213||XmlElement()||
|+|Pty3|ISO20022.Sese034002.PartyIdentificationAndAccount213||XmlElement()||
|+|Pty2|ISO20022.Sese034002.PartyIdentificationAndAccount213||XmlElement()||
|+|Pty1|ISO20022.Sese034002.PartyIdentificationAndAccount213||XmlElement()||
|+|Dpstry|ISO20022.Sese034002.PartyIdentification162||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Value ISO20022.Sese034002.SettlementStatus21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.ProprietaryStatusAndReason7||XmlElement()||
|+|Flng|ISO20022.Sese034002.FailingStatus12Choice||XmlElement()||
|+|Pdg|ISO20022.Sese034002.PendingStatus47Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Flng),validElement(Pdg),validChoice(Prtry,Flng,Pdg))|

---

## Enum ISO20022.Sese034002.SettlementSystemMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSET|Int32||XmlEnum("""YSET""")|1|
||NSET|Int32||XmlEnum("""NSET""")|2|

---

## Value ISO20022.Sese034002.SettlementSystemMethod5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese034002.SettlementTransactionCondition22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese034002.SettlementTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARQ|Int32||XmlEnum("""PARQ""")|1|
||PARC|Int32||XmlEnum("""PARC""")|2|
||NPAR|Int32||XmlEnum("""NPAR""")|3|
||PART|Int32||XmlEnum("""PART""")|4|

---

## Enum ISO20022.Sese034002.SettlementTransactionCondition6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ADEA|Int32||XmlEnum("""ADEA""")|1|
||RHYP|Int32||XmlEnum("""RHYP""")|2|
||TRAN|Int32||XmlEnum("""TRAN""")|3|
||NOMC|Int32||XmlEnum("""NOMC""")|4|
||TRIP|Int32||XmlEnum("""TRIP""")|5|
||UNEX|Int32||XmlEnum("""UNEX""")|6|
||PENS|Int32||XmlEnum("""PENS""")|7|
||EXPI|Int32||XmlEnum("""EXPI""")|8|
||SPST|Int32||XmlEnum("""SPST""")|9|
||SPDL|Int32||XmlEnum("""SPDL""")|10|
||SHOR|Int32||XmlEnum("""SHOR""")|11|
||RESI|Int32||XmlEnum("""RESI""")|12|
||PHYS|Int32||XmlEnum("""PHYS""")|13|
||KNOC|Int32||XmlEnum("""KNOC""")|14|
||FRCL|Int32||XmlEnum("""FRCL""")|15|
||EXER|Int32||XmlEnum("""EXER""")|16|
||DRAW|Int32||XmlEnum("""DRAW""")|17|
||DLWM|Int32||XmlEnum("""DLWM""")|18|
||DIRT|Int32||XmlEnum("""DIRT""")|19|
||CLEN|Int32||XmlEnum("""CLEN""")|20|
||BUTC|Int32||XmlEnum("""BUTC""")|21|
||ASGN|Int32||XmlEnum("""ASGN""")|22|

---

## Enum ISO20022.Sese034002.SettlingCapacity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RISP|Int32||XmlEnum("""RISP""")|1|
||SPRI|Int32||XmlEnum("""SPRI""")|2|
||CUST|Int32||XmlEnum("""CUST""")|3|
||SAGE|Int32||XmlEnum("""SAGE""")|4|

---

## Value ISO20022.Sese034002.SettlingCapacity8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese034002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese034002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese034002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese034002.TaxCapacityParty5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese034002.TaxLiability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGEN|Int32||XmlEnum("""AGEN""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Sese034002.TerminationDate7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|ISO20022.Sese034002.DateCode32Choice||XmlElement()||
|+|Dt|ISO20022.Sese034002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd),validElement(Dt),validChoice(Cd,Dt))|

---

## Value ISO20022.Sese034002.TradeDate9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese034002.TradeDateCode4Choice||XmlElement()||
|+|Dt|ISO20022.Sese034002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese034002.TradeDateCode4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese034002.TransactionIdentifications35


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CmonId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CmonId""",CmonId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrTxId""",AcctSvcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctOwnrTxId""",AcctOwnrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Sese034002.TypeOfIdentification1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TXID|Int32||XmlEnum("""TXID""")|1|
||FIIN|Int32||XmlEnum("""FIIN""")|2|
||DRLC|Int32||XmlEnum("""DRLC""")|3|
||CORP|Int32||XmlEnum("""CORP""")|4|
||CHTY|Int32||XmlEnum("""CHTY""")|5|
||CCPT|Int32||XmlEnum("""CCPT""")|6|
||ARNU|Int32||XmlEnum("""ARNU""")|7|

---

## Enum ISO20022.Sese034002.UnmatchedReason13Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DCMX|Int32||XmlEnum("""DCMX""")|1|
||DMCT|Int32||XmlEnum("""DMCT""")|2|
||VASU|Int32||XmlEnum("""VASU""")|3|
||DELN|Int32||XmlEnum("""DELN""")|4|
||DTRD|Int32||XmlEnum("""DTRD""")|5|
||TXST|Int32||XmlEnum("""TXST""")|6|
||SETR|Int32||XmlEnum("""SETR""")|7|
||SETS|Int32||XmlEnum("""SETS""")|8|
||DDAT|Int32||XmlEnum("""DDAT""")|9|
||DMON|Int32||XmlEnum("""DMON""")|10|
||SAFE|Int32||XmlEnum("""SAFE""")|11|
||RTGS|Int32||XmlEnum("""RTGS""")|12|
||RERT|Int32||XmlEnum("""RERT""")|13|
||REPO|Int32||XmlEnum("""REPO""")|14|
||REPP|Int32||XmlEnum("""REPP""")|15|
||CADE|Int32||XmlEnum("""CADE""")|16|
||REPA|Int32||XmlEnum("""REPA""")|17|
||REGD|Int32||XmlEnum("""REGD""")|18|
||IEXE|Int32||XmlEnum("""IEXE""")|19|
||ICUS|Int32||XmlEnum("""ICUS""")|20|
||ICAG|Int32||XmlEnum("""ICAG""")|21|
||DEPT|Int32||XmlEnum("""DEPT""")|22|
||PODU|Int32||XmlEnum("""PODU""")|23|
||PLCE|Int32||XmlEnum("""PLCE""")|24|
||INPS|Int32||XmlEnum("""INPS""")|25|
||PLIS|Int32||XmlEnum("""PLIS""")|26|
||PHYS|Int32||XmlEnum("""PHYS""")|27|
||FRAP|Int32||XmlEnum("""FRAP""")|28|
||OTHR|Int32||XmlEnum("""OTHR""")|29|
||DTRA|Int32||XmlEnum("""DTRA""")|30|
||NMAS|Int32||XmlEnum("""NMAS""")|31|
||CMIS|Int32||XmlEnum("""CMIS""")|32|
||LATE|Int32||XmlEnum("""LATE""")|33|
||LEOG|Int32||XmlEnum("""LEOG""")|34|
||INVE|Int32||XmlEnum("""INVE""")|35|
||FORF|Int32||XmlEnum("""FORF""")|36|
||DQUA|Int32||XmlEnum("""DQUA""")|37|
||DSEC|Int32||XmlEnum("""DSEC""")|38|
||DDEA|Int32||XmlEnum("""DDEA""")|39|
||NCRR|Int32||XmlEnum("""NCRR""")|40|
||CLAT|Int32||XmlEnum("""CLAT""")|41|
||CPCA|Int32||XmlEnum("""CPCA""")|42|
||IIND|Int32||XmlEnum("""IIND""")|43|
||TERM|Int32||XmlEnum("""TERM""")|44|
||ACRU|Int32||XmlEnum("""ACRU""")|45|
||ADEA|Int32||XmlEnum("""ADEA""")|46|

---

## Value ISO20022.Sese034002.UnmatchedReason18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese034002.UnmatchedReason25Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese034002.UnmatchedReason25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese034002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese034002.UnmatchedStatus19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese034002.UnmatchedReason18>||XmlElement()||
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

