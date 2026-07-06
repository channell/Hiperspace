# sese.027.002.07
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese027002.AcknowledgedAcceptedStatus31Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese027002.AcknowledgementReason19~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese027002.AcknowledgedAcceptedStatus31Choice *-- ISO20022.Sese027002.AcknowledgementReason19
    class ISO20022.Sese027002.AcknowledgementReason19 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese027002.AcknowledgementReason22Choice
    }
    ISO20022.Sese027002.AcknowledgementReason19 *-- ISO20022.Sese027002.AcknowledgementReason22Choice
    class ISO20022.Sese027002.AcknowledgementReason22Choice {
        + Prtry  : ISO20022.Sese027002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese027002.AcknowledgementReason22Choice *-- ISO20022.Sese027002.GenericIdentification47
    class ISO20022.Sese027002.AcknowledgementReason3Code {
        OTHR = 1
        SMPG = 2
        ADEA = 3
    }
    class ISO20022.Sese027002.AmountAndDirection67 {
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese027002.RestrictedFINActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese027002.RestrictedFINActiveCurrencyAndAmount
    }
    ISO20022.Sese027002.AmountAndDirection67 *-- ISO20022.Sese027002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese027002.AmountAndDirection67 *-- ISO20022.Sese027002.RestrictedFINActiveCurrencyAndAmount
    class ISO20022.Sese027002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Sese027002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese027002.BlockChainAddressWallet7 *-- ISO20022.Sese027002.GenericIdentification47
    class ISO20022.Sese027002.CancellationReason18 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese027002.CancellationReason28Choice
    }
    ISO20022.Sese027002.CancellationReason18 *-- ISO20022.Sese027002.CancellationReason28Choice
    class ISO20022.Sese027002.CancellationReason28Choice {
        + Prtry  : ISO20022.Sese027002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese027002.CancellationReason28Choice *-- ISO20022.Sese027002.GenericIdentification47
    class ISO20022.Sese027002.CancellationStatus20Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese027002.CancellationReason18~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese027002.CancellationStatus20Choice *-- ISO20022.Sese027002.CancellationReason18
    class ISO20022.Sese027002.CancelledStatusReason5Code {
        OTHR = 1
        CANI = 2
    }
    class ISO20022.Sese027002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese027002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese027002.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese027002.DateType4Code {
        UKWN = 1
        OPEN = 2
    }
    class ISO20022.Sese027002.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese027002.DeniedReason17 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese027002.DeniedReason24Choice
    }
    ISO20022.Sese027002.DeniedReason17 *-- ISO20022.Sese027002.DeniedReason24Choice
    class ISO20022.Sese027002.DeniedReason24Choice {
        + Prtry  : ISO20022.Sese027002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese027002.DeniedReason24Choice *-- ISO20022.Sese027002.GenericIdentification47
    class ISO20022.Sese027002.DeniedReason6Code {
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
    class ISO20022.Sese027002.DeniedStatus19Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese027002.DeniedReason17~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese027002.DeniedStatus19Choice *-- ISO20022.Sese027002.DeniedReason17
    class ISO20022.Sese027002.DocumentNumber6Choice {
        + PrtryNb  : ISO20022.Sese027002.GenericIdentification86
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Sese027002.DocumentNumber6Choice *-- ISO20022.Sese027002.GenericIdentification86
    class ISO20022.Sese027002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese027002.GenericDocumentIdentification5 {
        + Id  : String
        + MsgNb  : ISO20022.Sese027002.DocumentNumber6Choice
    }
    ISO20022.Sese027002.GenericDocumentIdentification5 *-- ISO20022.Sese027002.DocumentNumber6Choice
    class ISO20022.Sese027002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese027002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese027002.GenericIdentification86 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese027002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese027002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Sese027002.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Sese027002.OriginalAndCurrentQuantities4 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Sese027002.OtherIdentification2 {
        + Tp  : ISO20022.Sese027002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese027002.OtherIdentification2 *-- ISO20022.Sese027002.IdentificationSource4Choice
    class ISO20022.Sese027002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Sese027002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese027002.PartyIdentification136Choice *-- ISO20022.Sese027002.GenericIdentification84
    class ISO20022.Sese027002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Sese027002.NameAndAddress12
        + PrtryId  : ISO20022.Sese027002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese027002.PartyIdentification137Choice *-- ISO20022.Sese027002.NameAndAddress12
    ISO20022.Sese027002.PartyIdentification137Choice *-- ISO20022.Sese027002.GenericIdentification84
    class ISO20022.Sese027002.PartyIdentification145Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese027002.NameAndAddress12
        + AnyBIC  : String
    }
    ISO20022.Sese027002.PartyIdentification145Choice *-- ISO20022.Sese027002.NameAndAddress12
    class ISO20022.Sese027002.PartyIdentification156 {
        + LEI  : String
        + Id  : ISO20022.Sese027002.PartyIdentification136Choice
    }
    ISO20022.Sese027002.PartyIdentification156 *-- ISO20022.Sese027002.PartyIdentification136Choice
    class ISO20022.Sese027002.PartyIdentification170 {
        + LEI  : String
        + Id  : ISO20022.Sese027002.PartyIdentification176Choice
    }
    ISO20022.Sese027002.PartyIdentification170 *-- ISO20022.Sese027002.PartyIdentification176Choice
    class ISO20022.Sese027002.PartyIdentification176Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese027002.NameAndAddress12
        + PrtryId  : ISO20022.Sese027002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Sese027002.PartyIdentification176Choice *-- ISO20022.Sese027002.NameAndAddress12
    ISO20022.Sese027002.PartyIdentification176Choice *-- ISO20022.Sese027002.GenericIdentification84
    class ISO20022.Sese027002.PartyIdentification191 {
        + PrcgId  : String
        + LEI  : String
        + Id  : ISO20022.Sese027002.PartyIdentification145Choice
    }
    ISO20022.Sese027002.PartyIdentification191 *-- ISO20022.Sese027002.PartyIdentification145Choice
    class ISO20022.Sese027002.PartyIdentificationAndAccount215 {
        + PrcgId  : String
        + BlckChainAdrOrWllt  : ISO20022.Sese027002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese027002.SecuritiesAccount30
        + LEI  : String
        + Id  : ISO20022.Sese027002.PartyIdentification137Choice
    }
    ISO20022.Sese027002.PartyIdentificationAndAccount215 *-- ISO20022.Sese027002.BlockChainAddressWallet7
    ISO20022.Sese027002.PartyIdentificationAndAccount215 *-- ISO20022.Sese027002.SecuritiesAccount30
    ISO20022.Sese027002.PartyIdentificationAndAccount215 *-- ISO20022.Sese027002.PartyIdentification137Choice
    class ISO20022.Sese027002.PendingReason25 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese027002.PendingReason42Choice
    }
    ISO20022.Sese027002.PendingReason25 *-- ISO20022.Sese027002.PendingReason42Choice
    class ISO20022.Sese027002.PendingReason42Choice {
        + Prtry  : ISO20022.Sese027002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese027002.PendingReason42Choice *-- ISO20022.Sese027002.GenericIdentification47
    class ISO20022.Sese027002.PendingReason9Code {
        INBC = 1
        CDAC = 2
        CDRE = 3
        CDCY = 4
        CDRG = 5
        OTHR = 6
        CONF = 7
        ADEA = 8
    }
    class ISO20022.Sese027002.PendingStatus51Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese027002.PendingReason25~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese027002.PendingStatus51Choice *-- ISO20022.Sese027002.PendingReason25
    class ISO20022.Sese027002.ProcessingStatus96Choice {
        + Canc  : ISO20022.Sese027002.CancellationStatus20Choice
        + Dnd  : ISO20022.Sese027002.DeniedStatus19Choice
        + Prtry  : ISO20022.Sese027002.ProprietaryStatusAndReason7
        + AckdAccptd  : ISO20022.Sese027002.AcknowledgedAcceptedStatus31Choice
        + Rpr  : ISO20022.Sese027002.RejectionOrRepairStatus46Choice
        + Rjctd  : ISO20022.Sese027002.RejectionOrRepairStatus47Choice
        + PdgCxl  : ISO20022.Sese027002.PendingStatus51Choice
    }
    ISO20022.Sese027002.ProcessingStatus96Choice *-- ISO20022.Sese027002.CancellationStatus20Choice
    ISO20022.Sese027002.ProcessingStatus96Choice *-- ISO20022.Sese027002.DeniedStatus19Choice
    ISO20022.Sese027002.ProcessingStatus96Choice *-- ISO20022.Sese027002.ProprietaryStatusAndReason7
    ISO20022.Sese027002.ProcessingStatus96Choice *-- ISO20022.Sese027002.AcknowledgedAcceptedStatus31Choice
    ISO20022.Sese027002.ProcessingStatus96Choice *-- ISO20022.Sese027002.RejectionOrRepairStatus46Choice
    ISO20022.Sese027002.ProcessingStatus96Choice *-- ISO20022.Sese027002.RejectionOrRepairStatus47Choice
    ISO20022.Sese027002.ProcessingStatus96Choice *-- ISO20022.Sese027002.PendingStatus51Choice
    class ISO20022.Sese027002.ProprietaryReason5 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Sese027002.GenericIdentification47
    }
    ISO20022.Sese027002.ProprietaryReason5 *-- ISO20022.Sese027002.GenericIdentification47
    class ISO20022.Sese027002.ProprietaryStatusAndReason7 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Sese027002.ProprietaryReason5~
        + PrtrySts  : ISO20022.Sese027002.GenericIdentification47
    }
    ISO20022.Sese027002.ProprietaryStatusAndReason7 *-- ISO20022.Sese027002.ProprietaryReason5
    ISO20022.Sese027002.ProprietaryStatusAndReason7 *-- ISO20022.Sese027002.GenericIdentification47
    class ISO20022.Sese027002.Quantity54Choice {
        + OrgnlAndCurFace  : ISO20022.Sese027002.OriginalAndCurrentQuantities4
        + Qty  : ISO20022.Sese027002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Sese027002.Quantity54Choice *-- ISO20022.Sese027002.OriginalAndCurrentQuantities4
    ISO20022.Sese027002.Quantity54Choice *-- ISO20022.Sese027002.FinancialInstrumentQuantity36Choice
    class ISO20022.Sese027002.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese027002.References59Choice {
        + IntraPosMvmntId  : String
        + SctiesSttlmTxId  : ISO20022.Sese027002.SettlementTypeAndIdentification22
        + SctiesFincgTxId  : ISO20022.Sese027002.SettlementTypeAndIdentification22
        + OthrTxId  : ISO20022.Sese027002.GenericDocumentIdentification5
    }
    ISO20022.Sese027002.References59Choice *-- ISO20022.Sese027002.SettlementTypeAndIdentification22
    ISO20022.Sese027002.References59Choice *-- ISO20022.Sese027002.SettlementTypeAndIdentification22
    ISO20022.Sese027002.References59Choice *-- ISO20022.Sese027002.GenericDocumentIdentification5
    class ISO20022.Sese027002.RejectionAndRepairReason41Choice {
        + Prtry  : ISO20022.Sese027002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese027002.RejectionAndRepairReason41Choice *-- ISO20022.Sese027002.GenericIdentification47
    class ISO20022.Sese027002.RejectionAndRepairReason42Choice {
        + Prtry  : ISO20022.Sese027002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese027002.RejectionAndRepairReason42Choice *-- ISO20022.Sese027002.GenericIdentification47
    class ISO20022.Sese027002.RejectionOrRepairReason41 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese027002.RejectionAndRepairReason41Choice
    }
    ISO20022.Sese027002.RejectionOrRepairReason41 *-- ISO20022.Sese027002.RejectionAndRepairReason41Choice
    class ISO20022.Sese027002.RejectionOrRepairReason42 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese027002.RejectionAndRepairReason42Choice
    }
    ISO20022.Sese027002.RejectionOrRepairReason42 *-- ISO20022.Sese027002.RejectionAndRepairReason42Choice
    class ISO20022.Sese027002.RejectionOrRepairStatus46Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese027002.RejectionOrRepairReason41~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese027002.RejectionOrRepairStatus46Choice *-- ISO20022.Sese027002.RejectionOrRepairReason41
    class ISO20022.Sese027002.RejectionOrRepairStatus47Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese027002.RejectionOrRepairReason42~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese027002.RejectionOrRepairStatus47Choice *-- ISO20022.Sese027002.RejectionOrRepairReason42
    class ISO20022.Sese027002.RejectionReason71Code {
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
    class ISO20022.Sese027002.RejectionReason74Code {
        OTHR = 1
        NRGM = 2
        REFE = 3
        NRGN = 4
        LATE = 5
        ADEA = 6
        SAFE = 7
    }
    class ISO20022.Sese027002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese027002.RestrictedFINActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese027002.SecuritiesAccount30 {
        + Nm  : String
        + Tp  : ISO20022.Sese027002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Sese027002.SecuritiesAccount30 *-- ISO20022.Sese027002.GenericIdentification47
    class ISO20022.Sese027002.SecuritiesTransactionCancellationRequestStatusAdvice002V07 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese027002.SupplementaryData1~
        + TxDtls  : ISO20022.Sese027002.TransactionDetails162
        + PrcgSts  : ISO20022.Sese027002.ProcessingStatus96Choice
        + TxId  : ISO20022.Sese027002.TransactionIdentifications50
        + CxlReqRef  : String
    }
    ISO20022.Sese027002.SecuritiesTransactionCancellationRequestStatusAdvice002V07 *-- ISO20022.Sese027002.SupplementaryData1
    ISO20022.Sese027002.SecuritiesTransactionCancellationRequestStatusAdvice002V07 *-- ISO20022.Sese027002.TransactionDetails162
    ISO20022.Sese027002.SecuritiesTransactionCancellationRequestStatusAdvice002V07 *-- ISO20022.Sese027002.ProcessingStatus96Choice
    ISO20022.Sese027002.SecuritiesTransactionCancellationRequestStatusAdvice002V07 *-- ISO20022.Sese027002.TransactionIdentifications50
    class ISO20022.Sese027002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese027002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Sese027002.SecurityIdentification20 *-- ISO20022.Sese027002.OtherIdentification2
    class ISO20022.Sese027002.SettlementDate32Choice {
        + DtCd  : ISO20022.Sese027002.SettlementDateCode11Choice
        + Dt  : ISO20022.Sese027002.DateAndDateTime2Choice
    }
    ISO20022.Sese027002.SettlementDate32Choice *-- ISO20022.Sese027002.SettlementDateCode11Choice
    ISO20022.Sese027002.SettlementDate32Choice *-- ISO20022.Sese027002.DateAndDateTime2Choice
    class ISO20022.Sese027002.SettlementDateCode11Choice {
        + Prtry  : ISO20022.Sese027002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese027002.SettlementDateCode11Choice *-- ISO20022.Sese027002.GenericIdentification47
    class ISO20022.Sese027002.SettlementParties109 {
        + Pty5  : ISO20022.Sese027002.PartyIdentificationAndAccount215
        + Pty4  : ISO20022.Sese027002.PartyIdentificationAndAccount215
        + Pty3  : ISO20022.Sese027002.PartyIdentificationAndAccount215
        + Pty2  : ISO20022.Sese027002.PartyIdentificationAndAccount215
        + Pty1  : ISO20022.Sese027002.PartyIdentificationAndAccount215
        + Dpstry  : ISO20022.Sese027002.PartyIdentification191
    }
    ISO20022.Sese027002.SettlementParties109 *-- ISO20022.Sese027002.PartyIdentificationAndAccount215
    ISO20022.Sese027002.SettlementParties109 *-- ISO20022.Sese027002.PartyIdentificationAndAccount215
    ISO20022.Sese027002.SettlementParties109 *-- ISO20022.Sese027002.PartyIdentificationAndAccount215
    ISO20022.Sese027002.SettlementParties109 *-- ISO20022.Sese027002.PartyIdentificationAndAccount215
    ISO20022.Sese027002.SettlementParties109 *-- ISO20022.Sese027002.PartyIdentificationAndAccount215
    ISO20022.Sese027002.SettlementParties109 *-- ISO20022.Sese027002.PartyIdentification191
    class ISO20022.Sese027002.SettlementTypeAndIdentification22 {
        + Pmt  : String
        + SctiesMvmntTp  : String
        + TxId  : String
    }
    class ISO20022.Sese027002.SupplementaryData1 {
        + Envlp  : ISO20022.Sese027002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese027002.SupplementaryData1 *-- ISO20022.Sese027002.SupplementaryDataEnvelope1
    class ISO20022.Sese027002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese027002.TradeDate9Choice {
        + DtCd  : ISO20022.Sese027002.TradeDateCode4Choice
        + Dt  : ISO20022.Sese027002.DateAndDateTime2Choice
    }
    ISO20022.Sese027002.TradeDate9Choice *-- ISO20022.Sese027002.TradeDateCode4Choice
    ISO20022.Sese027002.TradeDate9Choice *-- ISO20022.Sese027002.DateAndDateTime2Choice
    class ISO20022.Sese027002.TradeDateCode4Choice {
        + Prtry  : ISO20022.Sese027002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Sese027002.TradeDateCode4Choice *-- ISO20022.Sese027002.GenericIdentification47
    class ISO20022.Sese027002.TransactionDetails162 {
        + Invstr  : ISO20022.Sese027002.PartyIdentification170
        + RcvgSttlmPties  : ISO20022.Sese027002.SettlementParties109
        + DlvrgSttlmPties  : ISO20022.Sese027002.SettlementParties109
        + SttlmDt  : ISO20022.Sese027002.SettlementDate32Choice
        + TradDt  : ISO20022.Sese027002.TradeDate9Choice
        + SttlmAmt  : ISO20022.Sese027002.AmountAndDirection67
        + SttlmQty  : ISO20022.Sese027002.Quantity54Choice
        + FinInstrmId  : ISO20022.Sese027002.SecurityIdentification20
        + BlckChainAdrOrWllt  : ISO20022.Sese027002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Sese027002.SecuritiesAccount30
        + AcctOwnr  : ISO20022.Sese027002.PartyIdentification156
    }
    ISO20022.Sese027002.TransactionDetails162 *-- ISO20022.Sese027002.PartyIdentification170
    ISO20022.Sese027002.TransactionDetails162 *-- ISO20022.Sese027002.SettlementParties109
    ISO20022.Sese027002.TransactionDetails162 *-- ISO20022.Sese027002.SettlementParties109
    ISO20022.Sese027002.TransactionDetails162 *-- ISO20022.Sese027002.SettlementDate32Choice
    ISO20022.Sese027002.TransactionDetails162 *-- ISO20022.Sese027002.TradeDate9Choice
    ISO20022.Sese027002.TransactionDetails162 *-- ISO20022.Sese027002.AmountAndDirection67
    ISO20022.Sese027002.TransactionDetails162 *-- ISO20022.Sese027002.Quantity54Choice
    ISO20022.Sese027002.TransactionDetails162 *-- ISO20022.Sese027002.SecurityIdentification20
    ISO20022.Sese027002.TransactionDetails162 *-- ISO20022.Sese027002.BlockChainAddressWallet7
    ISO20022.Sese027002.TransactionDetails162 *-- ISO20022.Sese027002.SecuritiesAccount30
    ISO20022.Sese027002.TransactionDetails162 *-- ISO20022.Sese027002.PartyIdentification156
    class ISO20022.Sese027002.TransactionIdentifications50 {
        + AcctOwnrTxId  : ISO20022.Sese027002.References59Choice
        + PrcrTxId  : String
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
    }
    ISO20022.Sese027002.TransactionIdentifications50 *-- ISO20022.Sese027002.References59Choice
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

## Value ISO20022.Sese027002.AcknowledgedAcceptedStatus31Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese027002.AcknowledgementReason19>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese027002.AcknowledgementReason19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese027002.AcknowledgementReason22Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese027002.AcknowledgementReason22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese027002.AcknowledgementReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||SMPG|Int32||XmlEnum("""SMPG""")|2|
||ADEA|Int32||XmlEnum("""ADEA""")|3|

---

## Value ISO20022.Sese027002.AmountAndDirection67


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese027002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese027002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese027002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese027002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Sese027002.CancellationReason18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese027002.CancellationReason28Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese027002.CancellationReason28Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese027002.CancellationStatus20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese027002.CancellationReason18>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese027002.CancelledStatusReason5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||CANI|Int32||XmlEnum("""CANI""")|2|

---

## Enum ISO20022.Sese027002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese027002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Sese027002.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese027002.DateType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||OPEN|Int32||XmlEnum("""OPEN""")|2|

---

## Enum ISO20022.Sese027002.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Value ISO20022.Sese027002.DeniedReason17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese027002.DeniedReason24Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese027002.DeniedReason24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese027002.DeniedReason6Code


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

## Value ISO20022.Sese027002.DeniedStatus19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese027002.DeniedReason17>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Type ISO20022.Sese027002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesTxCxlReqStsAdvc|ISO20022.Sese027002.SecuritiesTransactionCancellationRequestStatusAdvice002V07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesTxCxlReqStsAdvc))|

---

## Value ISO20022.Sese027002.DocumentNumber6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Sese027002.GenericIdentification86||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Value ISO20022.Sese027002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese027002.GenericDocumentIdentification5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|MsgNb|ISO20022.Sese027002.DocumentNumber6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(MsgNb))|

---

## Value ISO20022.Sese027002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese027002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese027002.GenericIdentification86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese027002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese027002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Enum ISO20022.Sese027002.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Sese027002.OriginalAndCurrentQuantities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese027002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese027002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Sese027002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese027002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese027002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese027002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese027002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese027002.PartyIdentification145Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese027002.NameAndAddress12||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese027002.PartyIdentification156


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese027002.PartyIdentification136Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese027002.PartyIdentification170


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese027002.PartyIdentification176Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese027002.PartyIdentification176Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese027002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Sese027002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese027002.PartyIdentification191


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese027002.PartyIdentification145Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese027002.PartyIdentificationAndAccount215


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese027002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese027002.SecuritiesAccount30||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese027002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese027002.PendingReason25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese027002.PendingReason42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese027002.PendingReason42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese027002.PendingReason9Code


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

## Value ISO20022.Sese027002.PendingStatus51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese027002.PendingReason25>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese027002.ProcessingStatus96Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Canc|ISO20022.Sese027002.CancellationStatus20Choice||XmlElement()||
|+|Dnd|ISO20022.Sese027002.DeniedStatus19Choice||XmlElement()||
|+|Prtry|ISO20022.Sese027002.ProprietaryStatusAndReason7||XmlElement()||
|+|AckdAccptd|ISO20022.Sese027002.AcknowledgedAcceptedStatus31Choice||XmlElement()||
|+|Rpr|ISO20022.Sese027002.RejectionOrRepairStatus46Choice||XmlElement()||
|+|Rjctd|ISO20022.Sese027002.RejectionOrRepairStatus47Choice||XmlElement()||
|+|PdgCxl|ISO20022.Sese027002.PendingStatus51Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Canc),validElement(Dnd),validElement(Prtry),validElement(AckdAccptd),validElement(Rpr),validElement(Rjctd),validElement(PdgCxl),validChoice(Canc,Dnd,Prtry,AckdAccptd,Rpr,Rjctd,PdgCxl))|

---

## Value ISO20022.Sese027002.ProprietaryReason5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Sese027002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Rsn))|

---

## Value ISO20022.Sese027002.ProprietaryStatusAndReason7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Sese027002.ProprietaryReason5>||XmlElement()||
|+|PrtrySts|ISO20022.Sese027002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Sese027002.Quantity54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Sese027002.OriginalAndCurrentQuantities4||XmlElement()||
|+|Qty|ISO20022.Sese027002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Enum ISO20022.Sese027002.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Sese027002.References59Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntraPosMvmntId|String||XmlElement()||
|+|SctiesSttlmTxId|ISO20022.Sese027002.SettlementTypeAndIdentification22||XmlElement()||
|+|SctiesFincgTxId|ISO20022.Sese027002.SettlementTypeAndIdentification22||XmlElement()||
|+|OthrTxId|ISO20022.Sese027002.GenericDocumentIdentification5||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IntraPosMvmntId""",IntraPosMvmntId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(SctiesSttlmTxId),validElement(SctiesFincgTxId),validElement(OthrTxId),validChoice(IntraPosMvmntId,SctiesSttlmTxId,SctiesFincgTxId,OthrTxId))|

---

## Value ISO20022.Sese027002.RejectionAndRepairReason41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese027002.RejectionAndRepairReason42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese027002.RejectionOrRepairReason41


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese027002.RejectionAndRepairReason41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese027002.RejectionOrRepairReason42


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese027002.RejectionAndRepairReason42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AddtlRsnInf""",AddtlRsnInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,210}"""),validElement(Cd))|

---

## Value ISO20022.Sese027002.RejectionOrRepairStatus46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese027002.RejectionOrRepairReason41>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese027002.RejectionOrRepairStatus47Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese027002.RejectionOrRepairReason42>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese027002.RejectionReason71Code


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

## Enum ISO20022.Sese027002.RejectionReason74Code


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

## Value ISO20022.Sese027002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese027002.RestrictedFINActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese027002.SecuritiesAccount30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese027002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Aspect ISO20022.Sese027002.SecuritiesTransactionCancellationRequestStatusAdvice002V07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese027002.SupplementaryData1>||XmlElement()||
|+|TxDtls|ISO20022.Sese027002.TransactionDetails162||XmlElement()||
|+|PrcgSts|ISO20022.Sese027002.ProcessingStatus96Choice||XmlElement()||
|+|TxId|ISO20022.Sese027002.TransactionIdentifications50||XmlElement()||
|+|CxlReqRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TxDtls),validElement(PrcgSts),validElement(TxId),validPattern("""CxlReqRef""",CxlReqRef,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese027002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese027002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese027002.SettlementDate32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese027002.SettlementDateCode11Choice||XmlElement()||
|+|Dt|ISO20022.Sese027002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese027002.SettlementDateCode11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese027002.SettlementParties109


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese027002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty4|ISO20022.Sese027002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty3|ISO20022.Sese027002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty2|ISO20022.Sese027002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty1|ISO20022.Sese027002.PartyIdentificationAndAccount215||XmlElement()||
|+|Dpstry|ISO20022.Sese027002.PartyIdentification191||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Value ISO20022.Sese027002.SettlementTypeAndIdentification22


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TxId""",TxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Sese027002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese027002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese027002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese027002.TradeDate9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese027002.TradeDateCode4Choice||XmlElement()||
|+|Dt|ISO20022.Sese027002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese027002.TradeDateCode4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese027002.TransactionDetails162


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Invstr|ISO20022.Sese027002.PartyIdentification170||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese027002.SettlementParties109||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese027002.SettlementParties109||XmlElement()||
|+|SttlmDt|ISO20022.Sese027002.SettlementDate32Choice||XmlElement()||
|+|TradDt|ISO20022.Sese027002.TradeDate9Choice||XmlElement()||
|+|SttlmAmt|ISO20022.Sese027002.AmountAndDirection67||XmlElement()||
|+|SttlmQty|ISO20022.Sese027002.Quantity54Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Sese027002.SecurityIdentification20||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese027002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese027002.SecuritiesAccount30||XmlElement()||
|+|AcctOwnr|ISO20022.Sese027002.PartyIdentification156||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Invstr),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(SttlmDt),validElement(TradDt),validElement(SttlmAmt),validElement(SttlmQty),validElement(FinInstrmId),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr))|

---

## Value ISO20022.Sese027002.TransactionIdentifications50


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOwnrTxId|ISO20022.Sese027002.References59Choice||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|CtrPtyMktInfrstrctrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctOwnrTxId),validPattern("""PrcrTxId""",PrcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CtrPtyMktInfrstrctrTxId""",CtrPtyMktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktInfrstrctrTxId""",MktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrTxId""",AcctSvcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

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

