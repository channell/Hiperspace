# sese.039.002.06
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese039002.AcknowledgedAcceptedStatus30Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese039002.AcknowledgementReason18~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese039002.AcknowledgedAcceptedStatus30Choice *-- ISO20022.Sese039002.AcknowledgementReason18
    class ISO20022.Sese039002.AcknowledgementReason18 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese039002.AcknowledgementReason21Choice
    }
    ISO20022.Sese039002.AcknowledgementReason18 *-- ISO20022.Sese039002.AcknowledgementReason21Choice
    class ISO20022.Sese039002.AcknowledgementReason21Choice {
        + Prtry  : ISO20022.Sese039002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese039002.AcknowledgementReason21Choice *-- ISO20022.Sese039002.GenericIdentification47
    class ISO20022.Sese039002.AcknowledgementReason6Code {
        LATE = 1
        NSTP = 2
        OTHR = 3
        SMPG = 4
        ADEA = 5
    }
    class ISO20022.Sese039002.AmountAndDirection67 {
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese039002.RestrictedFINActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese039002.RestrictedFINActiveCurrencyAndAmount
    }
    ISO20022.Sese039002.AmountAndDirection67 *-- ISO20022.Sese039002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese039002.AmountAndDirection67 *-- ISO20022.Sese039002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese039002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Sese039002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese039002.BlockChainAddressWallet7 *-- ISO20022.Sese039002.GenericIdentification47
    class ISO20022.Sese039002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese039002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese039002.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese039002.DateType4Code {
        UKWN = 1
        OPEN = 2
    }
    class ISO20022.Sese039002.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese039002.DeniedReason17 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese039002.DeniedReason24Choice
    }
    ISO20022.Sese039002.DeniedReason17 *-- ISO20022.Sese039002.DeniedReason24Choice
    class ISO20022.Sese039002.DeniedReason24Choice {
        + Prtry  : ISO20022.Sese039002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese039002.DeniedReason24Choice *-- ISO20022.Sese039002.GenericIdentification47
    class ISO20022.Sese039002.DeniedReason6Code {
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
    class ISO20022.Sese039002.DeniedStatus19Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese039002.DeniedReason17~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese039002.DeniedStatus19Choice *-- ISO20022.Sese039002.DeniedReason17
    class ISO20022.Sese039002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese039002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese039002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese039002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese039002.ModificationProcessingStatus11Choice {
        + Prtry  : ISO20022.Sese039002.ProprietaryStatusAndReason7
        + Modfd  : ISO20022.Sese039002.ModificationStatus5Choice
        + Rprd  : ISO20022.Sese039002.RepairStatus17Choice
        + Rjctd  : ISO20022.Sese039002.RejectionStatus42Choice
        + Dnd  : ISO20022.Sese039002.DeniedStatus19Choice
        + PdgPrcg  : ISO20022.Sese039002.PendingProcessingStatus16Choice
        + AckdAccptd  : ISO20022.Sese039002.AcknowledgedAcceptedStatus30Choice
    }
    ISO20022.Sese039002.ModificationProcessingStatus11Choice *-- ISO20022.Sese039002.ProprietaryStatusAndReason7
    ISO20022.Sese039002.ModificationProcessingStatus11Choice *-- ISO20022.Sese039002.ModificationStatus5Choice
    ISO20022.Sese039002.ModificationProcessingStatus11Choice *-- ISO20022.Sese039002.RepairStatus17Choice
    ISO20022.Sese039002.ModificationProcessingStatus11Choice *-- ISO20022.Sese039002.RejectionStatus42Choice
    ISO20022.Sese039002.ModificationProcessingStatus11Choice *-- ISO20022.Sese039002.DeniedStatus19Choice
    ISO20022.Sese039002.ModificationProcessingStatus11Choice *-- ISO20022.Sese039002.PendingProcessingStatus16Choice
    ISO20022.Sese039002.ModificationProcessingStatus11Choice *-- ISO20022.Sese039002.AcknowledgedAcceptedStatus30Choice
    class ISO20022.Sese039002.ModificationReason5 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese039002.ModificationReason5Choice
    }
    ISO20022.Sese039002.ModificationReason5 *-- ISO20022.Sese039002.ModificationReason5Choice
    class ISO20022.Sese039002.ModificationReason5Choice {
        + Prtry  : ISO20022.Sese039002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese039002.ModificationReason5Choice *-- ISO20022.Sese039002.GenericIdentification47
    class ISO20022.Sese039002.ModificationStatus5Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese039002.ModificationReason5~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese039002.ModificationStatus5Choice *-- ISO20022.Sese039002.ModificationReason5
    class ISO20022.Sese039002.ModifiedStatusReason1Code {
        OTHR = 1
        MDBY = 2
    }
    class ISO20022.Sese039002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Sese039002.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Sese039002.OriginalAndCurrentQuantities4 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Sese039002.OtherIdentification2 {
        + Tp  : ISO20022.Sese039002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese039002.OtherIdentification2 *-- ISO20022.Sese039002.IdentificationSource4Choice
    class ISO20022.Sese039002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Sese039002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese039002.PartyIdentification136Choice *-- ISO20022.Sese039002.GenericIdentification84
    class ISO20022.Sese039002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Sese039002.NameAndAddress12
        + PrtryId  : ISO20022.Sese039002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese039002.PartyIdentification137Choice *-- ISO20022.Sese039002.NameAndAddress12
    ISO20022.Sese039002.PartyIdentification137Choice *-- ISO20022.Sese039002.GenericIdentification84
    class ISO20022.Sese039002.PartyIdentification145Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese039002.NameAndAddress12
        + AnyBIC  : String
    }
    ISO20022.Sese039002.PartyIdentification145Choice *-- ISO20022.Sese039002.NameAndAddress12
    class ISO20022.Sese039002.PartyIdentification156 {
        + LEI  : String
        + Id  : ISO20022.Sese039002.PartyIdentification136Choice
    }
    ISO20022.Sese039002.PartyIdentification156 *-- ISO20022.Sese039002.PartyIdentification136Choice
    class ISO20022.Sese039002.PartyIdentification170 {
        + LEI  : String
        + Id  : ISO20022.Sese039002.PartyIdentification176Choice
    }
    ISO20022.Sese039002.PartyIdentification170 *-- ISO20022.Sese039002.PartyIdentification176Choice
    class ISO20022.Sese039002.PartyIdentification176Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese039002.NameAndAddress12
        + PrtryId  : ISO20022.Sese039002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese039002.PartyIdentification176Choice *-- ISO20022.Sese039002.NameAndAddress12
    ISO20022.Sese039002.PartyIdentification176Choice *-- ISO20022.Sese039002.GenericIdentification84
    class ISO20022.Sese039002.PartyIdentification191 {
        + PrcgId  : String
        + LEI  : String
        + Id  : ISO20022.Sese039002.PartyIdentification145Choice
    }
    ISO20022.Sese039002.PartyIdentification191 *-- ISO20022.Sese039002.PartyIdentification145Choice
    class ISO20022.Sese039002.PartyIdentificationAndAccount215 {
        + PrcgId  : String
        + BlckChainAdrOrWllt  : ISO20022.Sese039002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese039002.SecuritiesAccount30
        + LEI  : String
        + Id  : ISO20022.Sese039002.PartyIdentification137Choice
    }
    ISO20022.Sese039002.PartyIdentificationAndAccount215 *-- ISO20022.Sese039002.BlockChainAddressWallet7
    ISO20022.Sese039002.PartyIdentificationAndAccount215 *-- ISO20022.Sese039002.SecuritiesAccount30
    ISO20022.Sese039002.PartyIdentificationAndAccount215 *-- ISO20022.Sese039002.PartyIdentification137Choice
    class ISO20022.Sese039002.PendingProcessingReason13 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese039002.PendingProcessingReason15Choice
    }
    ISO20022.Sese039002.PendingProcessingReason13 *-- ISO20022.Sese039002.PendingProcessingReason15Choice
    class ISO20022.Sese039002.PendingProcessingReason15Choice {
        + Prtry  : ISO20022.Sese039002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese039002.PendingProcessingReason15Choice *-- ISO20022.Sese039002.GenericIdentification47
    class ISO20022.Sese039002.PendingProcessingReason3Code {
        CERT = 1
        DENO = 2
        OTHR = 3
        MINO = 4
        NEXT = 5
        MUNO = 6
        BLOC = 7
        ADEA = 8
    }
    class ISO20022.Sese039002.PendingProcessingStatus16Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese039002.PendingProcessingReason13~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese039002.PendingProcessingStatus16Choice *-- ISO20022.Sese039002.PendingProcessingReason13
    class ISO20022.Sese039002.ProprietaryReason5 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Sese039002.GenericIdentification47
    }
    ISO20022.Sese039002.ProprietaryReason5 *-- ISO20022.Sese039002.GenericIdentification47
    class ISO20022.Sese039002.ProprietaryStatusAndReason7 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Sese039002.ProprietaryReason5~
        + PrtrySts  : ISO20022.Sese039002.GenericIdentification47
    }
    ISO20022.Sese039002.ProprietaryStatusAndReason7 *-- ISO20022.Sese039002.ProprietaryReason5
    ISO20022.Sese039002.ProprietaryStatusAndReason7 *-- ISO20022.Sese039002.GenericIdentification47
    class ISO20022.Sese039002.Quantity54Choice {
        + OrgnlAndCurFace  : ISO20022.Sese039002.OriginalAndCurrentQuantities4
        + Qty  : ISO20022.Sese039002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Sese039002.Quantity54Choice *-- ISO20022.Sese039002.OriginalAndCurrentQuantities4
    ISO20022.Sese039002.Quantity54Choice *-- ISO20022.Sese039002.FinancialInstrumentQuantity36Choice
    class ISO20022.Sese039002.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese039002.RejectionReason48Choice {
        + Prtry  : ISO20022.Sese039002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese039002.RejectionReason48Choice *-- ISO20022.Sese039002.GenericIdentification47
    class ISO20022.Sese039002.RejectionReason63 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese039002.RejectionReason48Choice
    }
    ISO20022.Sese039002.RejectionReason63 *-- ISO20022.Sese039002.RejectionReason48Choice
    class ISO20022.Sese039002.RejectionReason72Code {
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
    class ISO20022.Sese039002.RejectionStatus42Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese039002.RejectionReason63~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese039002.RejectionStatus42Choice *-- ISO20022.Sese039002.RejectionReason63
    class ISO20022.Sese039002.RepairReason13 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese039002.RepairReason14Choice
    }
    ISO20022.Sese039002.RepairReason13 *-- ISO20022.Sese039002.RepairReason14Choice
    class ISO20022.Sese039002.RepairReason14Choice {
        + Prtry  : ISO20022.Sese039002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese039002.RepairReason14Choice *-- ISO20022.Sese039002.GenericIdentification47
    class ISO20022.Sese039002.RepairReason4Code {
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
    class ISO20022.Sese039002.RepairStatus17Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese039002.RepairReason13~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese039002.RepairStatus17Choice *-- ISO20022.Sese039002.RepairReason13
    class ISO20022.Sese039002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese039002.RestrictedFINActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese039002.SecuritiesAccount30 {
        + Nm  : String
        + Tp  : ISO20022.Sese039002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese039002.SecuritiesAccount30 *-- ISO20022.Sese039002.GenericIdentification47
    class ISO20022.Sese039002.SecuritiesSettlementTransactionModificationRequestStatusAdvice002V06 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese039002.SupplementaryData1~
        + TxDtls  : ISO20022.Sese039002.TransactionDetails158
        + ModPrcgSts  : ISO20022.Sese039002.ModificationProcessingStatus11Choice
        + TxId  : ISO20022.Sese039002.TransactionIdentifications37
        + BlckChainAdrOrWllt  : ISO20022.Sese039002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese039002.SecuritiesAccount30
        + AcctOwnr  : ISO20022.Sese039002.PartyIdentification156
        + ModReqRef  : String
    }
    ISO20022.Sese039002.SecuritiesSettlementTransactionModificationRequestStatusAdvice002V06 *-- ISO20022.Sese039002.SupplementaryData1
    ISO20022.Sese039002.SecuritiesSettlementTransactionModificationRequestStatusAdvice002V06 *-- ISO20022.Sese039002.TransactionDetails158
    ISO20022.Sese039002.SecuritiesSettlementTransactionModificationRequestStatusAdvice002V06 *-- ISO20022.Sese039002.ModificationProcessingStatus11Choice
    ISO20022.Sese039002.SecuritiesSettlementTransactionModificationRequestStatusAdvice002V06 *-- ISO20022.Sese039002.TransactionIdentifications37
    ISO20022.Sese039002.SecuritiesSettlementTransactionModificationRequestStatusAdvice002V06 *-- ISO20022.Sese039002.BlockChainAddressWallet7
    ISO20022.Sese039002.SecuritiesSettlementTransactionModificationRequestStatusAdvice002V06 *-- ISO20022.Sese039002.SecuritiesAccount30
    ISO20022.Sese039002.SecuritiesSettlementTransactionModificationRequestStatusAdvice002V06 *-- ISO20022.Sese039002.PartyIdentification156
    class ISO20022.Sese039002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese039002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Sese039002.SecurityIdentification20 *-- ISO20022.Sese039002.OtherIdentification2
    class ISO20022.Sese039002.SettlementDate32Choice {
        + DtCd  : ISO20022.Sese039002.SettlementDateCode11Choice
        + Dt  : ISO20022.Sese039002.DateAndDateTime2Choice
    }
    ISO20022.Sese039002.SettlementDate32Choice *-- ISO20022.Sese039002.SettlementDateCode11Choice
    ISO20022.Sese039002.SettlementDate32Choice *-- ISO20022.Sese039002.DateAndDateTime2Choice
    class ISO20022.Sese039002.SettlementDateCode11Choice {
        + Prtry  : ISO20022.Sese039002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese039002.SettlementDateCode11Choice *-- ISO20022.Sese039002.GenericIdentification47
    class ISO20022.Sese039002.SettlementParties109 {
        + Pty5  : ISO20022.Sese039002.PartyIdentificationAndAccount215
        + Pty4  : ISO20022.Sese039002.PartyIdentificationAndAccount215
        + Pty3  : ISO20022.Sese039002.PartyIdentificationAndAccount215
        + Pty2  : ISO20022.Sese039002.PartyIdentificationAndAccount215
        + Pty1  : ISO20022.Sese039002.PartyIdentificationAndAccount215
        + Dpstry  : ISO20022.Sese039002.PartyIdentification191
    }
    ISO20022.Sese039002.SettlementParties109 *-- ISO20022.Sese039002.PartyIdentificationAndAccount215
    ISO20022.Sese039002.SettlementParties109 *-- ISO20022.Sese039002.PartyIdentificationAndAccount215
    ISO20022.Sese039002.SettlementParties109 *-- ISO20022.Sese039002.PartyIdentificationAndAccount215
    ISO20022.Sese039002.SettlementParties109 *-- ISO20022.Sese039002.PartyIdentificationAndAccount215
    ISO20022.Sese039002.SettlementParties109 *-- ISO20022.Sese039002.PartyIdentificationAndAccount215
    ISO20022.Sese039002.SettlementParties109 *-- ISO20022.Sese039002.PartyIdentification191
    class ISO20022.Sese039002.SupplementaryData1 {
        + Envlp  : ISO20022.Sese039002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese039002.SupplementaryData1 *-- ISO20022.Sese039002.SupplementaryDataEnvelope1
    class ISO20022.Sese039002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese039002.TradeDate9Choice {
        + DtCd  : ISO20022.Sese039002.TradeDateCode4Choice
        + Dt  : ISO20022.Sese039002.DateAndDateTime2Choice
    }
    ISO20022.Sese039002.TradeDate9Choice *-- ISO20022.Sese039002.TradeDateCode4Choice
    ISO20022.Sese039002.TradeDate9Choice *-- ISO20022.Sese039002.DateAndDateTime2Choice
    class ISO20022.Sese039002.TradeDateCode4Choice {
        + Prtry  : ISO20022.Sese039002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese039002.TradeDateCode4Choice *-- ISO20022.Sese039002.GenericIdentification47
    class ISO20022.Sese039002.TransactionDetails158 {
        + Invstr  : ISO20022.Sese039002.PartyIdentification170
        + RcvgSttlmPties  : ISO20022.Sese039002.SettlementParties109
        + DlvrgSttlmPties  : ISO20022.Sese039002.SettlementParties109
        + TradDt  : ISO20022.Sese039002.TradeDate9Choice
        + SttlmDt  : ISO20022.Sese039002.SettlementDate32Choice
        + SttlmAmt  : ISO20022.Sese039002.AmountAndDirection67
        + SttlmQty  : ISO20022.Sese039002.Quantity54Choice
        + Pmt  : String
        + SctiesMvmntTp  : String
        + FinInstrmId  : ISO20022.Sese039002.SecurityIdentification20
    }
    ISO20022.Sese039002.TransactionDetails158 *-- ISO20022.Sese039002.PartyIdentification170
    ISO20022.Sese039002.TransactionDetails158 *-- ISO20022.Sese039002.SettlementParties109
    ISO20022.Sese039002.TransactionDetails158 *-- ISO20022.Sese039002.SettlementParties109
    ISO20022.Sese039002.TransactionDetails158 *-- ISO20022.Sese039002.TradeDate9Choice
    ISO20022.Sese039002.TransactionDetails158 *-- ISO20022.Sese039002.SettlementDate32Choice
    ISO20022.Sese039002.TransactionDetails158 *-- ISO20022.Sese039002.AmountAndDirection67
    ISO20022.Sese039002.TransactionDetails158 *-- ISO20022.Sese039002.Quantity54Choice
    ISO20022.Sese039002.TransactionDetails158 *-- ISO20022.Sese039002.SecurityIdentification20
    class ISO20022.Sese039002.TransactionIdentifications37 {
        + OthrId  : String
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

## Value ISO20022.Sese039002.AcknowledgedAcceptedStatus30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese039002.AcknowledgementReason18>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese039002.AcknowledgementReason18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese039002.AcknowledgementReason21Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese039002.AcknowledgementReason21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese039002.AcknowledgementReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LATE|Int32||XmlEnum("""LATE""")|1|
||NSTP|Int32||XmlEnum("""NSTP""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||SMPG|Int32||XmlEnum("""SMPG""")|4|
||ADEA|Int32||XmlEnum("""ADEA""")|5|

---

## Value ISO20022.Sese039002.AmountAndDirection67


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese039002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese039002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese039002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese039002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Enum ISO20022.Sese039002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese039002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Sese039002.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese039002.DateType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||OPEN|Int32||XmlEnum("""OPEN""")|2|

---

## Enum ISO20022.Sese039002.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Value ISO20022.Sese039002.DeniedReason17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese039002.DeniedReason24Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese039002.DeniedReason24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese039002.DeniedReason6Code


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

## Value ISO20022.Sese039002.DeniedStatus19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese039002.DeniedReason17>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Type ISO20022.Sese039002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmTxModReqStsAdvc|ISO20022.Sese039002.SecuritiesSettlementTransactionModificationRequestStatusAdvice002V06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmTxModReqStsAdvc))|

---

## Value ISO20022.Sese039002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese039002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese039002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese039002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese039002.ModificationProcessingStatus11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039002.ProprietaryStatusAndReason7||XmlElement()||
|+|Modfd|ISO20022.Sese039002.ModificationStatus5Choice||XmlElement()||
|+|Rprd|ISO20022.Sese039002.RepairStatus17Choice||XmlElement()||
|+|Rjctd|ISO20022.Sese039002.RejectionStatus42Choice||XmlElement()||
|+|Dnd|ISO20022.Sese039002.DeniedStatus19Choice||XmlElement()||
|+|PdgPrcg|ISO20022.Sese039002.PendingProcessingStatus16Choice||XmlElement()||
|+|AckdAccptd|ISO20022.Sese039002.AcknowledgedAcceptedStatus30Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Modfd),validElement(Rprd),validElement(Rjctd),validElement(Dnd),validElement(PdgPrcg),validElement(AckdAccptd),validChoice(Prtry,Modfd,Rprd,Rjctd,Dnd,PdgPrcg,AckdAccptd))|

---

## Value ISO20022.Sese039002.ModificationReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese039002.ModificationReason5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese039002.ModificationReason5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese039002.ModificationStatus5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese039002.ModificationReason5>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese039002.ModifiedStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||MDBY|Int32||XmlEnum("""MDBY""")|2|

---

## Value ISO20022.Sese039002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Enum ISO20022.Sese039002.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Sese039002.OriginalAndCurrentQuantities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese039002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese039002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Sese039002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese039002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese039002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese039002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese039002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese039002.PartyIdentification145Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese039002.NameAndAddress12||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese039002.PartyIdentification156


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese039002.PartyIdentification136Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese039002.PartyIdentification170


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese039002.PartyIdentification176Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese039002.PartyIdentification176Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese039002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese039002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese039002.PartyIdentification191


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese039002.PartyIdentification145Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese039002.PartyIdentificationAndAccount215


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese039002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese039002.SecuritiesAccount30||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese039002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese039002.PendingProcessingReason13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese039002.PendingProcessingReason15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese039002.PendingProcessingReason15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese039002.PendingProcessingReason3Code


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

## Value ISO20022.Sese039002.PendingProcessingStatus16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese039002.PendingProcessingReason13>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese039002.ProprietaryReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Sese039002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Rsn))|

---

## Value ISO20022.Sese039002.ProprietaryStatusAndReason7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Sese039002.ProprietaryReason5>||XmlElement()||
|+|PrtrySts|ISO20022.Sese039002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Sese039002.Quantity54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Sese039002.OriginalAndCurrentQuantities4||XmlElement()||
|+|Qty|ISO20022.Sese039002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Enum ISO20022.Sese039002.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Sese039002.RejectionReason48Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese039002.RejectionReason63


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese039002.RejectionReason48Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Enum ISO20022.Sese039002.RejectionReason72Code


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

## Value ISO20022.Sese039002.RejectionStatus42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese039002.RejectionReason63>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese039002.RepairReason13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese039002.RepairReason14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese039002.RepairReason14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese039002.RepairReason4Code


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

## Value ISO20022.Sese039002.RepairStatus17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese039002.RepairReason13>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese039002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese039002.RestrictedFINActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese039002.SecuritiesAccount30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese039002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Aspect ISO20022.Sese039002.SecuritiesSettlementTransactionModificationRequestStatusAdvice002V06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese039002.SupplementaryData1>||XmlElement()||
|+|TxDtls|ISO20022.Sese039002.TransactionDetails158||XmlElement()||
|+|ModPrcgSts|ISO20022.Sese039002.ModificationProcessingStatus11Choice||XmlElement()||
|+|TxId|ISO20022.Sese039002.TransactionIdentifications37||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese039002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese039002.SecuritiesAccount30||XmlElement()||
|+|AcctOwnr|ISO20022.Sese039002.PartyIdentification156||XmlElement()||
|+|ModReqRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TxDtls),validElement(ModPrcgSts),validElement(TxId),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validPattern("""ModReqRef""",ModReqRef,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese039002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese039002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese039002.SettlementDate32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese039002.SettlementDateCode11Choice||XmlElement()||
|+|Dt|ISO20022.Sese039002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese039002.SettlementDateCode11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese039002.SettlementParties109


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese039002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty4|ISO20022.Sese039002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty3|ISO20022.Sese039002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty2|ISO20022.Sese039002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty1|ISO20022.Sese039002.PartyIdentificationAndAccount215||XmlElement()||
|+|Dpstry|ISO20022.Sese039002.PartyIdentification191||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Value ISO20022.Sese039002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese039002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese039002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese039002.TradeDate9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese039002.TradeDateCode4Choice||XmlElement()||
|+|Dt|ISO20022.Sese039002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese039002.TradeDateCode4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese039002.TransactionDetails158


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Invstr|ISO20022.Sese039002.PartyIdentification170||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese039002.SettlementParties109||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese039002.SettlementParties109||XmlElement()||
|+|TradDt|ISO20022.Sese039002.TradeDate9Choice||XmlElement()||
|+|SttlmDt|ISO20022.Sese039002.SettlementDate32Choice||XmlElement()||
|+|SttlmAmt|ISO20022.Sese039002.AmountAndDirection67||XmlElement()||
|+|SttlmQty|ISO20022.Sese039002.Quantity54Choice||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
|+|FinInstrmId|ISO20022.Sese039002.SecurityIdentification20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Invstr),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(TradDt),validElement(SttlmDt),validElement(SttlmAmt),validElement(SttlmQty),validElement(FinInstrmId))|

---

## Value ISO20022.Sese039002.TransactionIdentifications37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrId|String||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""OthrId""",OthrId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""PrcrTxId""",PrcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktInfrstrctrTxId""",MktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrTxId""",AcctSvcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctOwnrTxId""",AcctOwnrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

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

