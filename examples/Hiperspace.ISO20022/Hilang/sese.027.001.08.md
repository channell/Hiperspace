# sese.027.001.08
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese027001.AcknowledgedAcceptedStatus24Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese027001.AcknowledgementReason12~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese027001.AcknowledgedAcceptedStatus24Choice *-- ISO20022.Sese027001.AcknowledgementReason12
    class ISO20022.Sese027001.AcknowledgementReason12 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese027001.AcknowledgementReason15Choice
    }
    ISO20022.Sese027001.AcknowledgementReason12 *-- ISO20022.Sese027001.AcknowledgementReason15Choice
    class ISO20022.Sese027001.AcknowledgementReason15Choice {
        + Prtry  : ISO20022.Sese027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese027001.AcknowledgementReason15Choice *-- ISO20022.Sese027001.GenericIdentification30
    class ISO20022.Sese027001.AcknowledgementReason3Code {
        OTHR = 1
        SMPG = 2
        ADEA = 3
    }
    class ISO20022.Sese027001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese027001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese027001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Sese027001.AmountAndDirection51 {
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese027001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese027001.ActiveCurrencyAndAmount
    }
    ISO20022.Sese027001.AmountAndDirection51 *-- ISO20022.Sese027001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese027001.AmountAndDirection51 *-- ISO20022.Sese027001.ActiveCurrencyAndAmount
    class ISO20022.Sese027001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Sese027001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese027001.BlockChainAddressWallet3 *-- ISO20022.Sese027001.GenericIdentification30
    class ISO20022.Sese027001.CancellationReason10 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese027001.CancellationReason21Choice
    }
    ISO20022.Sese027001.CancellationReason10 *-- ISO20022.Sese027001.CancellationReason21Choice
    class ISO20022.Sese027001.CancellationReason21Choice {
        + Prtry  : ISO20022.Sese027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese027001.CancellationReason21Choice *-- ISO20022.Sese027001.GenericIdentification30
    class ISO20022.Sese027001.CancellationStatus15Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese027001.CancellationReason10~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese027001.CancellationStatus15Choice *-- ISO20022.Sese027001.CancellationReason10
    class ISO20022.Sese027001.CancelledStatusReason5Code {
        OTHR = 1
        CANI = 2
    }
    class ISO20022.Sese027001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese027001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese027001.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese027001.DateType4Code {
        UKWN = 1
        OPEN = 2
    }
    class ISO20022.Sese027001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese027001.DeniedReason10 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese027001.DeniedReason15Choice
    }
    ISO20022.Sese027001.DeniedReason10 *-- ISO20022.Sese027001.DeniedReason15Choice
    class ISO20022.Sese027001.DeniedReason15Choice {
        + Prtry  : ISO20022.Sese027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese027001.DeniedReason15Choice *-- ISO20022.Sese027001.GenericIdentification30
    class ISO20022.Sese027001.DeniedReason6Code {
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
    class ISO20022.Sese027001.DeniedStatus15Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese027001.DeniedReason10~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese027001.DeniedStatus15Choice *-- ISO20022.Sese027001.DeniedReason10
    class ISO20022.Sese027001.DocumentNumber5Choice {
        + PrtryNb  : ISO20022.Sese027001.GenericIdentification36
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Sese027001.DocumentNumber5Choice *-- ISO20022.Sese027001.GenericIdentification36
    class ISO20022.Sese027001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese027001.GenericDocumentIdentification4 {
        + Id  : String
        + MsgNb  : ISO20022.Sese027001.DocumentNumber5Choice
    }
    ISO20022.Sese027001.GenericDocumentIdentification4 *-- ISO20022.Sese027001.DocumentNumber5Choice
    class ISO20022.Sese027001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese027001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese027001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese027001.NameAndAddress5 {
        + Adr  : ISO20022.Sese027001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Sese027001.NameAndAddress5 *-- ISO20022.Sese027001.PostalAddress1
    class ISO20022.Sese027001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Sese027001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Sese027001.OtherIdentification1 {
        + Tp  : ISO20022.Sese027001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese027001.OtherIdentification1 *-- ISO20022.Sese027001.IdentificationSource3Choice
    class ISO20022.Sese027001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Sese027001.NameAndAddress5
        + PrtryId  : ISO20022.Sese027001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese027001.PartyIdentification120Choice *-- ISO20022.Sese027001.NameAndAddress5
    ISO20022.Sese027001.PartyIdentification120Choice *-- ISO20022.Sese027001.GenericIdentification36
    class ISO20022.Sese027001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Sese027001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese027001.PartyIdentification127Choice *-- ISO20022.Sese027001.GenericIdentification36
    class ISO20022.Sese027001.PartyIdentification134Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese027001.NameAndAddress5
        + PrtryId  : ISO20022.Sese027001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese027001.PartyIdentification134Choice *-- ISO20022.Sese027001.NameAndAddress5
    ISO20022.Sese027001.PartyIdentification134Choice *-- ISO20022.Sese027001.GenericIdentification36
    class ISO20022.Sese027001.PartyIdentification144 {
        + LEI  : String
        + Id  : ISO20022.Sese027001.PartyIdentification127Choice
    }
    ISO20022.Sese027001.PartyIdentification144 *-- ISO20022.Sese027001.PartyIdentification127Choice
    class ISO20022.Sese027001.PartyIdentification149 {
        + LEI  : String
        + Id  : ISO20022.Sese027001.PartyIdentification134Choice
    }
    ISO20022.Sese027001.PartyIdentification149 *-- ISO20022.Sese027001.PartyIdentification134Choice
    class ISO20022.Sese027001.PartyIdentification257Choice {
        + DgtlLdgrId  : String
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese027001.NameAndAddress5
        + AnyBIC  : String
    }
    ISO20022.Sese027001.PartyIdentification257Choice *-- ISO20022.Sese027001.NameAndAddress5
    class ISO20022.Sese027001.PartyIdentification314 {
        + PrcgId  : String
        + LEI  : String
        + Id  : ISO20022.Sese027001.PartyIdentification257Choice
    }
    ISO20022.Sese027001.PartyIdentification314 *-- ISO20022.Sese027001.PartyIdentification257Choice
    class ISO20022.Sese027001.PartyIdentificationAndAccount195 {
        + PrcgId  : String
        + BlckChainAdrOrWllt  : ISO20022.Sese027001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese027001.SecuritiesAccount19
        + LEI  : String
        + Id  : ISO20022.Sese027001.PartyIdentification120Choice
    }
    ISO20022.Sese027001.PartyIdentificationAndAccount195 *-- ISO20022.Sese027001.BlockChainAddressWallet3
    ISO20022.Sese027001.PartyIdentificationAndAccount195 *-- ISO20022.Sese027001.SecuritiesAccount19
    ISO20022.Sese027001.PartyIdentificationAndAccount195 *-- ISO20022.Sese027001.PartyIdentification120Choice
    class ISO20022.Sese027001.PendingReason17 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese027001.PendingReason30Choice
    }
    ISO20022.Sese027001.PendingReason17 *-- ISO20022.Sese027001.PendingReason30Choice
    class ISO20022.Sese027001.PendingReason30Choice {
        + Prtry  : ISO20022.Sese027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese027001.PendingReason30Choice *-- ISO20022.Sese027001.GenericIdentification30
    class ISO20022.Sese027001.PendingReason9Code {
        INBC = 1
        CDAC = 2
        CDRE = 3
        CDCY = 4
        CDRG = 5
        OTHR = 6
        CONF = 7
        ADEA = 8
    }
    class ISO20022.Sese027001.PendingStatus39Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese027001.PendingReason17~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese027001.PendingStatus39Choice *-- ISO20022.Sese027001.PendingReason17
    class ISO20022.Sese027001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Sese027001.ProcessingStatus84Choice {
        + Canc  : ISO20022.Sese027001.CancellationStatus15Choice
        + Dnd  : ISO20022.Sese027001.DeniedStatus15Choice
        + Prtry  : ISO20022.Sese027001.ProprietaryStatusAndReason6
        + AckdAccptd  : ISO20022.Sese027001.AcknowledgedAcceptedStatus24Choice
        + Rpr  : ISO20022.Sese027001.RejectionOrRepairStatus42Choice
        + Rjctd  : ISO20022.Sese027001.RejectionOrRepairStatus43Choice
        + PdgCxl  : ISO20022.Sese027001.PendingStatus39Choice
    }
    ISO20022.Sese027001.ProcessingStatus84Choice *-- ISO20022.Sese027001.CancellationStatus15Choice
    ISO20022.Sese027001.ProcessingStatus84Choice *-- ISO20022.Sese027001.DeniedStatus15Choice
    ISO20022.Sese027001.ProcessingStatus84Choice *-- ISO20022.Sese027001.ProprietaryStatusAndReason6
    ISO20022.Sese027001.ProcessingStatus84Choice *-- ISO20022.Sese027001.AcknowledgedAcceptedStatus24Choice
    ISO20022.Sese027001.ProcessingStatus84Choice *-- ISO20022.Sese027001.RejectionOrRepairStatus42Choice
    ISO20022.Sese027001.ProcessingStatus84Choice *-- ISO20022.Sese027001.RejectionOrRepairStatus43Choice
    ISO20022.Sese027001.ProcessingStatus84Choice *-- ISO20022.Sese027001.PendingStatus39Choice
    class ISO20022.Sese027001.ProprietaryReason4 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Sese027001.GenericIdentification30
    }
    ISO20022.Sese027001.ProprietaryReason4 *-- ISO20022.Sese027001.GenericIdentification30
    class ISO20022.Sese027001.ProprietaryStatusAndReason6 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Sese027001.ProprietaryReason4~
        + PrtrySts  : ISO20022.Sese027001.GenericIdentification30
    }
    ISO20022.Sese027001.ProprietaryStatusAndReason6 *-- ISO20022.Sese027001.ProprietaryReason4
    ISO20022.Sese027001.ProprietaryStatusAndReason6 *-- ISO20022.Sese027001.GenericIdentification30
    class ISO20022.Sese027001.Quantity51Choice {
        + OrgnlAndCurFace  : ISO20022.Sese027001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Sese027001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Sese027001.Quantity51Choice *-- ISO20022.Sese027001.OriginalAndCurrentQuantities1
    ISO20022.Sese027001.Quantity51Choice *-- ISO20022.Sese027001.FinancialInstrumentQuantity33Choice
    class ISO20022.Sese027001.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese027001.References44Choice {
        + IntraPosMvmntId  : String
        + SctiesSttlmTxId  : ISO20022.Sese027001.SettlementTypeAndIdentification18
        + SctiesFincgTxId  : ISO20022.Sese027001.SettlementTypeAndIdentification18
        + OthrTxId  : ISO20022.Sese027001.GenericDocumentIdentification4
    }
    ISO20022.Sese027001.References44Choice *-- ISO20022.Sese027001.SettlementTypeAndIdentification18
    ISO20022.Sese027001.References44Choice *-- ISO20022.Sese027001.SettlementTypeAndIdentification18
    ISO20022.Sese027001.References44Choice *-- ISO20022.Sese027001.GenericDocumentIdentification4
    class ISO20022.Sese027001.RejectionAndRepairReason37Choice {
        + Prtry  : ISO20022.Sese027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese027001.RejectionAndRepairReason37Choice *-- ISO20022.Sese027001.GenericIdentification30
    class ISO20022.Sese027001.RejectionAndRepairReason38Choice {
        + Prtry  : ISO20022.Sese027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese027001.RejectionAndRepairReason38Choice *-- ISO20022.Sese027001.GenericIdentification30
    class ISO20022.Sese027001.RejectionOrRepairReason37 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese027001.RejectionAndRepairReason37Choice
    }
    ISO20022.Sese027001.RejectionOrRepairReason37 *-- ISO20022.Sese027001.RejectionAndRepairReason37Choice
    class ISO20022.Sese027001.RejectionOrRepairReason38 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese027001.RejectionAndRepairReason38Choice
    }
    ISO20022.Sese027001.RejectionOrRepairReason38 *-- ISO20022.Sese027001.RejectionAndRepairReason38Choice
    class ISO20022.Sese027001.RejectionOrRepairStatus42Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese027001.RejectionOrRepairReason37~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese027001.RejectionOrRepairStatus42Choice *-- ISO20022.Sese027001.RejectionOrRepairReason37
    class ISO20022.Sese027001.RejectionOrRepairStatus43Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese027001.RejectionOrRepairReason38~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese027001.RejectionOrRepairStatus43Choice *-- ISO20022.Sese027001.RejectionOrRepairReason38
    class ISO20022.Sese027001.RejectionReason71Code {
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
    class ISO20022.Sese027001.RejectionReason74Code {
        OTHR = 1
        NRGM = 2
        REFE = 3
        NRGN = 4
        LATE = 5
        ADEA = 6
        SAFE = 7
    }
    class ISO20022.Sese027001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Sese027001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese027001.SecuritiesAccount19 *-- ISO20022.Sese027001.GenericIdentification30
    class ISO20022.Sese027001.SecuritiesTransactionCancellationRequestStatusAdviceV08 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese027001.SupplementaryData1~
        + TxDtls  : ISO20022.Sese027001.TransactionDetails174
        + PrcgSts  : ISO20022.Sese027001.ProcessingStatus84Choice
        + TxId  : ISO20022.Sese027001.TransactionIdentifications52
        + CxlReqRef  : String
    }
    ISO20022.Sese027001.SecuritiesTransactionCancellationRequestStatusAdviceV08 *-- ISO20022.Sese027001.SupplementaryData1
    ISO20022.Sese027001.SecuritiesTransactionCancellationRequestStatusAdviceV08 *-- ISO20022.Sese027001.TransactionDetails174
    ISO20022.Sese027001.SecuritiesTransactionCancellationRequestStatusAdviceV08 *-- ISO20022.Sese027001.ProcessingStatus84Choice
    ISO20022.Sese027001.SecuritiesTransactionCancellationRequestStatusAdviceV08 *-- ISO20022.Sese027001.TransactionIdentifications52
    class ISO20022.Sese027001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese027001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Sese027001.SecurityIdentification19 *-- ISO20022.Sese027001.OtherIdentification1
    class ISO20022.Sese027001.SettlementDate19Choice {
        + DtCd  : ISO20022.Sese027001.SettlementDateCode8Choice
        + Dt  : ISO20022.Sese027001.DateAndDateTime2Choice
    }
    ISO20022.Sese027001.SettlementDate19Choice *-- ISO20022.Sese027001.SettlementDateCode8Choice
    ISO20022.Sese027001.SettlementDate19Choice *-- ISO20022.Sese027001.DateAndDateTime2Choice
    class ISO20022.Sese027001.SettlementDateCode8Choice {
        + Prtry  : ISO20022.Sese027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese027001.SettlementDateCode8Choice *-- ISO20022.Sese027001.GenericIdentification30
    class ISO20022.Sese027001.SettlementParties125 {
        + Pty5  : ISO20022.Sese027001.PartyIdentificationAndAccount195
        + Pty4  : ISO20022.Sese027001.PartyIdentificationAndAccount195
        + Pty3  : ISO20022.Sese027001.PartyIdentificationAndAccount195
        + Pty2  : ISO20022.Sese027001.PartyIdentificationAndAccount195
        + Pty1  : ISO20022.Sese027001.PartyIdentificationAndAccount195
        + Dpstry  : ISO20022.Sese027001.PartyIdentification314
    }
    ISO20022.Sese027001.SettlementParties125 *-- ISO20022.Sese027001.PartyIdentificationAndAccount195
    ISO20022.Sese027001.SettlementParties125 *-- ISO20022.Sese027001.PartyIdentificationAndAccount195
    ISO20022.Sese027001.SettlementParties125 *-- ISO20022.Sese027001.PartyIdentificationAndAccount195
    ISO20022.Sese027001.SettlementParties125 *-- ISO20022.Sese027001.PartyIdentificationAndAccount195
    ISO20022.Sese027001.SettlementParties125 *-- ISO20022.Sese027001.PartyIdentificationAndAccount195
    ISO20022.Sese027001.SettlementParties125 *-- ISO20022.Sese027001.PartyIdentification314
    class ISO20022.Sese027001.SettlementTypeAndIdentification18 {
        + Pmt  : String
        + SctiesMvmntTp  : String
        + TxId  : String
    }
    class ISO20022.Sese027001.SupplementaryData1 {
        + Envlp  : ISO20022.Sese027001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese027001.SupplementaryData1 *-- ISO20022.Sese027001.SupplementaryDataEnvelope1
    class ISO20022.Sese027001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese027001.TradeDate8Choice {
        + DtCd  : ISO20022.Sese027001.TradeDateCode3Choice
        + Dt  : ISO20022.Sese027001.DateAndDateTime2Choice
    }
    ISO20022.Sese027001.TradeDate8Choice *-- ISO20022.Sese027001.TradeDateCode3Choice
    ISO20022.Sese027001.TradeDate8Choice *-- ISO20022.Sese027001.DateAndDateTime2Choice
    class ISO20022.Sese027001.TradeDateCode3Choice {
        + Prtry  : ISO20022.Sese027001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese027001.TradeDateCode3Choice *-- ISO20022.Sese027001.GenericIdentification30
    class ISO20022.Sese027001.TransactionDetails174 {
        + Invstr  : ISO20022.Sese027001.PartyIdentification149
        + RcvgSttlmPties  : ISO20022.Sese027001.SettlementParties125
        + DlvrgSttlmPties  : ISO20022.Sese027001.SettlementParties125
        + SttlmDt  : ISO20022.Sese027001.SettlementDate19Choice
        + TradDt  : ISO20022.Sese027001.TradeDate8Choice
        + SttlmAmt  : ISO20022.Sese027001.AmountAndDirection51
        + SttlmQty  : ISO20022.Sese027001.Quantity51Choice
        + FinInstrmId  : ISO20022.Sese027001.SecurityIdentification19
        + BlckChainAdrOrWllt  : ISO20022.Sese027001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese027001.SecuritiesAccount19
        + AcctOwnr  : ISO20022.Sese027001.PartyIdentification144
    }
    ISO20022.Sese027001.TransactionDetails174 *-- ISO20022.Sese027001.PartyIdentification149
    ISO20022.Sese027001.TransactionDetails174 *-- ISO20022.Sese027001.SettlementParties125
    ISO20022.Sese027001.TransactionDetails174 *-- ISO20022.Sese027001.SettlementParties125
    ISO20022.Sese027001.TransactionDetails174 *-- ISO20022.Sese027001.SettlementDate19Choice
    ISO20022.Sese027001.TransactionDetails174 *-- ISO20022.Sese027001.TradeDate8Choice
    ISO20022.Sese027001.TransactionDetails174 *-- ISO20022.Sese027001.AmountAndDirection51
    ISO20022.Sese027001.TransactionDetails174 *-- ISO20022.Sese027001.Quantity51Choice
    ISO20022.Sese027001.TransactionDetails174 *-- ISO20022.Sese027001.SecurityIdentification19
    ISO20022.Sese027001.TransactionDetails174 *-- ISO20022.Sese027001.BlockChainAddressWallet3
    ISO20022.Sese027001.TransactionDetails174 *-- ISO20022.Sese027001.SecuritiesAccount19
    ISO20022.Sese027001.TransactionDetails174 *-- ISO20022.Sese027001.PartyIdentification144
    class ISO20022.Sese027001.TransactionIdentifications52 {
        + AcctOwnrTxId  : ISO20022.Sese027001.References44Choice
        + NonceId  : String
        + PrcrTxId  : String
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
    }
    ISO20022.Sese027001.TransactionIdentifications52 *-- ISO20022.Sese027001.References44Choice
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

## Value ISO20022.Sese027001.AcknowledgedAcceptedStatus24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese027001.AcknowledgementReason12>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese027001.AcknowledgementReason12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese027001.AcknowledgementReason15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese027001.AcknowledgementReason15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese027001.AcknowledgementReason3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||SMPG|Int32||XmlEnum("""SMPG""")|2|
||ADEA|Int32||XmlEnum("""ADEA""")|3|

---

## Value ISO20022.Sese027001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese027001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese027001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Sese027001.AmountAndDirection51


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese027001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese027001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese027001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese027001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese027001.CancellationReason10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese027001.CancellationReason21Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese027001.CancellationReason21Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese027001.CancellationStatus15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese027001.CancellationReason10>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese027001.CancelledStatusReason5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||CANI|Int32||XmlEnum("""CANI""")|2|

---

## Enum ISO20022.Sese027001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese027001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Sese027001.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese027001.DateType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||OPEN|Int32||XmlEnum("""OPEN""")|2|

---

## Enum ISO20022.Sese027001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Value ISO20022.Sese027001.DeniedReason10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese027001.DeniedReason15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese027001.DeniedReason15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese027001.DeniedReason6Code


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

## Value ISO20022.Sese027001.DeniedStatus15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese027001.DeniedReason10>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Type ISO20022.Sese027001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesTxCxlReqStsAdvc|ISO20022.Sese027001.SecuritiesTransactionCancellationRequestStatusAdviceV08||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesTxCxlReqStsAdvc))|

---

## Value ISO20022.Sese027001.DocumentNumber5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Sese027001.GenericIdentification36||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Value ISO20022.Sese027001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese027001.GenericDocumentIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|MsgNb|ISO20022.Sese027001.DocumentNumber5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MsgNb))|

---

## Value ISO20022.Sese027001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese027001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese027001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese027001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Sese027001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Sese027001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Sese027001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese027001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese027001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese027001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese027001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese027001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese027001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese027001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese027001.PartyIdentification134Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese027001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese027001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese027001.PartyIdentification144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese027001.PartyIdentification127Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese027001.PartyIdentification149


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese027001.PartyIdentification134Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese027001.PartyIdentification257Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese027001.NameAndAddress5||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(DgtlLdgrId,Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese027001.PartyIdentification314


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese027001.PartyIdentification257Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese027001.PartyIdentificationAndAccount195


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese027001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese027001.SecuritiesAccount19||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese027001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese027001.PendingReason17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese027001.PendingReason30Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese027001.PendingReason30Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese027001.PendingReason9Code


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

## Value ISO20022.Sese027001.PendingStatus39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese027001.PendingReason17>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese027001.PostalAddress1


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

## Value ISO20022.Sese027001.ProcessingStatus84Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Canc|ISO20022.Sese027001.CancellationStatus15Choice||XmlElement()||
|+|Dnd|ISO20022.Sese027001.DeniedStatus15Choice||XmlElement()||
|+|Prtry|ISO20022.Sese027001.ProprietaryStatusAndReason6||XmlElement()||
|+|AckdAccptd|ISO20022.Sese027001.AcknowledgedAcceptedStatus24Choice||XmlElement()||
|+|Rpr|ISO20022.Sese027001.RejectionOrRepairStatus42Choice||XmlElement()||
|+|Rjctd|ISO20022.Sese027001.RejectionOrRepairStatus43Choice||XmlElement()||
|+|PdgCxl|ISO20022.Sese027001.PendingStatus39Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Canc),validElement(Dnd),validElement(Prtry),validElement(AckdAccptd),validElement(Rpr),validElement(Rjctd),validElement(PdgCxl),validChoice(Canc,Dnd,Prtry,AckdAccptd,Rpr,Rjctd,PdgCxl))|

---

## Value ISO20022.Sese027001.ProprietaryReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Sese027001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Sese027001.ProprietaryStatusAndReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Sese027001.ProprietaryReason4>||XmlElement()||
|+|PrtrySts|ISO20022.Sese027001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Sese027001.Quantity51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Sese027001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Sese027001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Enum ISO20022.Sese027001.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Sese027001.References44Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntraPosMvmntId|String||XmlElement()||
|+|SctiesSttlmTxId|ISO20022.Sese027001.SettlementTypeAndIdentification18||XmlElement()||
|+|SctiesFincgTxId|ISO20022.Sese027001.SettlementTypeAndIdentification18||XmlElement()||
|+|OthrTxId|ISO20022.Sese027001.GenericDocumentIdentification4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmTxId),validElement(SctiesFincgTxId),validElement(OthrTxId),validChoice(IntraPosMvmntId,SctiesSttlmTxId,SctiesFincgTxId,OthrTxId))|

---

## Value ISO20022.Sese027001.RejectionAndRepairReason37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese027001.RejectionAndRepairReason38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese027001.RejectionOrRepairReason37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese027001.RejectionAndRepairReason37Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese027001.RejectionOrRepairReason38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese027001.RejectionAndRepairReason38Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese027001.RejectionOrRepairStatus42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese027001.RejectionOrRepairReason37>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese027001.RejectionOrRepairStatus43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese027001.RejectionOrRepairReason38>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese027001.RejectionReason71Code


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

## Enum ISO20022.Sese027001.RejectionReason74Code


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

## Value ISO20022.Sese027001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese027001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Aspect ISO20022.Sese027001.SecuritiesTransactionCancellationRequestStatusAdviceV08


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese027001.SupplementaryData1>||XmlElement()||
|+|TxDtls|ISO20022.Sese027001.TransactionDetails174||XmlElement()||
|+|PrcgSts|ISO20022.Sese027001.ProcessingStatus84Choice||XmlElement()||
|+|TxId|ISO20022.Sese027001.TransactionIdentifications52||XmlElement()||
|+|CxlReqRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TxDtls),validElement(PrcgSts),validElement(TxId))|

---

## Value ISO20022.Sese027001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese027001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese027001.SettlementDate19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese027001.SettlementDateCode8Choice||XmlElement()||
|+|Dt|ISO20022.Sese027001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese027001.SettlementDateCode8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese027001.SettlementParties125


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese027001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty4|ISO20022.Sese027001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty3|ISO20022.Sese027001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty2|ISO20022.Sese027001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty1|ISO20022.Sese027001.PartyIdentificationAndAccount195||XmlElement()||
|+|Dpstry|ISO20022.Sese027001.PartyIdentification314||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Value ISO20022.Sese027001.SettlementTypeAndIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese027001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese027001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese027001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese027001.TradeDate8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese027001.TradeDateCode3Choice||XmlElement()||
|+|Dt|ISO20022.Sese027001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese027001.TradeDateCode3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese027001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese027001.TransactionDetails174


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Invstr|ISO20022.Sese027001.PartyIdentification149||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese027001.SettlementParties125||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese027001.SettlementParties125||XmlElement()||
|+|SttlmDt|ISO20022.Sese027001.SettlementDate19Choice||XmlElement()||
|+|TradDt|ISO20022.Sese027001.TradeDate8Choice||XmlElement()||
|+|SttlmAmt|ISO20022.Sese027001.AmountAndDirection51||XmlElement()||
|+|SttlmQty|ISO20022.Sese027001.Quantity51Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Sese027001.SecurityIdentification19||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese027001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese027001.SecuritiesAccount19||XmlElement()||
|+|AcctOwnr|ISO20022.Sese027001.PartyIdentification144||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Invstr),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(SttlmDt),validElement(TradDt),validElement(SttlmAmt),validElement(SttlmQty),validElement(FinInstrmId),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr))|

---

## Value ISO20022.Sese027001.TransactionIdentifications52


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOwnrTxId|ISO20022.Sese027001.References44Choice||XmlElement()||
|+|NonceId|String||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|CtrPtyMktInfrstrctrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctOwnrTxId))|

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

