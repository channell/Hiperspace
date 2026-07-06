# sese.039.001.07
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Sese039001.AcknowledgedAcceptedStatus23Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese039001.AcknowledgementReason11~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese039001.AcknowledgedAcceptedStatus23Choice *-- ISO20022.Sese039001.AcknowledgementReason11
    class ISO20022.Sese039001.AcknowledgementReason11 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese039001.AcknowledgementReason14Choice
    }
    ISO20022.Sese039001.AcknowledgementReason11 *-- ISO20022.Sese039001.AcknowledgementReason14Choice
    class ISO20022.Sese039001.AcknowledgementReason14Choice {
        + Prtry  : ISO20022.Sese039001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese039001.AcknowledgementReason14Choice *-- ISO20022.Sese039001.GenericIdentification30
    class ISO20022.Sese039001.AcknowledgementReason6Code {
        LATE = 1
        NSTP = 2
        OTHR = 3
        SMPG = 4
        ADEA = 5
    }
    class ISO20022.Sese039001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese039001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Sese039001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Sese039001.AmountAndDirection51 {
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Sese039001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Sese039001.ActiveCurrencyAndAmount
    }
    ISO20022.Sese039001.AmountAndDirection51 *-- ISO20022.Sese039001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Sese039001.AmountAndDirection51 *-- ISO20022.Sese039001.ActiveCurrencyAndAmount
    class ISO20022.Sese039001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Sese039001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese039001.BlockChainAddressWallet3 *-- ISO20022.Sese039001.GenericIdentification30
    class ISO20022.Sese039001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Sese039001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Sese039001.DateType3Code {
        VARI = 1
    }
    class ISO20022.Sese039001.DateType4Code {
        UKWN = 1
        OPEN = 2
    }
    class ISO20022.Sese039001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Sese039001.DeniedReason10 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese039001.DeniedReason15Choice
    }
    ISO20022.Sese039001.DeniedReason10 *-- ISO20022.Sese039001.DeniedReason15Choice
    class ISO20022.Sese039001.DeniedReason15Choice {
        + Prtry  : ISO20022.Sese039001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese039001.DeniedReason15Choice *-- ISO20022.Sese039001.GenericIdentification30
    class ISO20022.Sese039001.DeniedReason6Code {
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
    class ISO20022.Sese039001.DeniedStatus15Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese039001.DeniedReason10~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese039001.DeniedStatus15Choice *-- ISO20022.Sese039001.DeniedReason10
    class ISO20022.Sese039001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Sese039001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese039001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Sese039001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Sese039001.ModificationProcessingStatus10Choice {
        + Prtry  : ISO20022.Sese039001.ProprietaryStatusAndReason6
        + Modfd  : ISO20022.Sese039001.ModificationStatus4Choice
        + Rprd  : ISO20022.Sese039001.RepairStatus13Choice
        + Rjctd  : ISO20022.Sese039001.RejectionStatus37Choice
        + Dnd  : ISO20022.Sese039001.DeniedStatus15Choice
        + PdgPrcg  : ISO20022.Sese039001.PendingProcessingStatus13Choice
        + AckdAccptd  : ISO20022.Sese039001.AcknowledgedAcceptedStatus23Choice
    }
    ISO20022.Sese039001.ModificationProcessingStatus10Choice *-- ISO20022.Sese039001.ProprietaryStatusAndReason6
    ISO20022.Sese039001.ModificationProcessingStatus10Choice *-- ISO20022.Sese039001.ModificationStatus4Choice
    ISO20022.Sese039001.ModificationProcessingStatus10Choice *-- ISO20022.Sese039001.RepairStatus13Choice
    ISO20022.Sese039001.ModificationProcessingStatus10Choice *-- ISO20022.Sese039001.RejectionStatus37Choice
    ISO20022.Sese039001.ModificationProcessingStatus10Choice *-- ISO20022.Sese039001.DeniedStatus15Choice
    ISO20022.Sese039001.ModificationProcessingStatus10Choice *-- ISO20022.Sese039001.PendingProcessingStatus13Choice
    ISO20022.Sese039001.ModificationProcessingStatus10Choice *-- ISO20022.Sese039001.AcknowledgedAcceptedStatus23Choice
    class ISO20022.Sese039001.ModificationReason4 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese039001.ModificationReason4Choice
    }
    ISO20022.Sese039001.ModificationReason4 *-- ISO20022.Sese039001.ModificationReason4Choice
    class ISO20022.Sese039001.ModificationReason4Choice {
        + Prtry  : ISO20022.Sese039001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese039001.ModificationReason4Choice *-- ISO20022.Sese039001.GenericIdentification30
    class ISO20022.Sese039001.ModificationStatus4Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese039001.ModificationReason4~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese039001.ModificationStatus4Choice *-- ISO20022.Sese039001.ModificationReason4
    class ISO20022.Sese039001.ModifiedStatusReason1Code {
        OTHR = 1
        MDBY = 2
    }
    class ISO20022.Sese039001.NameAndAddress5 {
        + Adr  : ISO20022.Sese039001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Sese039001.NameAndAddress5 *-- ISO20022.Sese039001.PostalAddress1
    class ISO20022.Sese039001.NoReasonCode {
        NORE = 1
    }
    class ISO20022.Sese039001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Sese039001.OtherIdentification1 {
        + Tp  : ISO20022.Sese039001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Sese039001.OtherIdentification1 *-- ISO20022.Sese039001.IdentificationSource3Choice
    class ISO20022.Sese039001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Sese039001.NameAndAddress5
        + PrtryId  : ISO20022.Sese039001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese039001.PartyIdentification120Choice *-- ISO20022.Sese039001.NameAndAddress5
    ISO20022.Sese039001.PartyIdentification120Choice *-- ISO20022.Sese039001.GenericIdentification36
    class ISO20022.Sese039001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Sese039001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese039001.PartyIdentification127Choice *-- ISO20022.Sese039001.GenericIdentification36
    class ISO20022.Sese039001.PartyIdentification134Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese039001.NameAndAddress5
        + PrtryId  : ISO20022.Sese039001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Sese039001.PartyIdentification134Choice *-- ISO20022.Sese039001.NameAndAddress5
    ISO20022.Sese039001.PartyIdentification134Choice *-- ISO20022.Sese039001.GenericIdentification36
    class ISO20022.Sese039001.PartyIdentification144 {
        + LEI  : String
        + Id  : ISO20022.Sese039001.PartyIdentification127Choice
    }
    ISO20022.Sese039001.PartyIdentification144 *-- ISO20022.Sese039001.PartyIdentification127Choice
    class ISO20022.Sese039001.PartyIdentification149 {
        + LEI  : String
        + Id  : ISO20022.Sese039001.PartyIdentification134Choice
    }
    ISO20022.Sese039001.PartyIdentification149 *-- ISO20022.Sese039001.PartyIdentification134Choice
    class ISO20022.Sese039001.PartyIdentification257Choice {
        + DgtlLdgrId  : String
        + Ctry  : String
        + NmAndAdr  : ISO20022.Sese039001.NameAndAddress5
        + AnyBIC  : String
    }
    ISO20022.Sese039001.PartyIdentification257Choice *-- ISO20022.Sese039001.NameAndAddress5
    class ISO20022.Sese039001.PartyIdentification314 {
        + PrcgId  : String
        + LEI  : String
        + Id  : ISO20022.Sese039001.PartyIdentification257Choice
    }
    ISO20022.Sese039001.PartyIdentification314 *-- ISO20022.Sese039001.PartyIdentification257Choice
    class ISO20022.Sese039001.PartyIdentificationAndAccount195 {
        + PrcgId  : String
        + BlckChainAdrOrWllt  : ISO20022.Sese039001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese039001.SecuritiesAccount19
        + LEI  : String
        + Id  : ISO20022.Sese039001.PartyIdentification120Choice
    }
    ISO20022.Sese039001.PartyIdentificationAndAccount195 *-- ISO20022.Sese039001.BlockChainAddressWallet3
    ISO20022.Sese039001.PartyIdentificationAndAccount195 *-- ISO20022.Sese039001.SecuritiesAccount19
    ISO20022.Sese039001.PartyIdentificationAndAccount195 *-- ISO20022.Sese039001.PartyIdentification120Choice
    class ISO20022.Sese039001.PendingProcessingReason10 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese039001.PendingProcessingReason12Choice
    }
    ISO20022.Sese039001.PendingProcessingReason10 *-- ISO20022.Sese039001.PendingProcessingReason12Choice
    class ISO20022.Sese039001.PendingProcessingReason12Choice {
        + Prtry  : ISO20022.Sese039001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese039001.PendingProcessingReason12Choice *-- ISO20022.Sese039001.GenericIdentification30
    class ISO20022.Sese039001.PendingProcessingReason3Code {
        CERT = 1
        DENO = 2
        OTHR = 3
        MINO = 4
        NEXT = 5
        MUNO = 6
        BLOC = 7
        ADEA = 8
    }
    class ISO20022.Sese039001.PendingProcessingStatus13Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese039001.PendingProcessingReason10~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese039001.PendingProcessingStatus13Choice *-- ISO20022.Sese039001.PendingProcessingReason10
    class ISO20022.Sese039001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Sese039001.ProprietaryReason4 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Sese039001.GenericIdentification30
    }
    ISO20022.Sese039001.ProprietaryReason4 *-- ISO20022.Sese039001.GenericIdentification30
    class ISO20022.Sese039001.ProprietaryStatusAndReason6 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Sese039001.ProprietaryReason4~
        + PrtrySts  : ISO20022.Sese039001.GenericIdentification30
    }
    ISO20022.Sese039001.ProprietaryStatusAndReason6 *-- ISO20022.Sese039001.ProprietaryReason4
    ISO20022.Sese039001.ProprietaryStatusAndReason6 *-- ISO20022.Sese039001.GenericIdentification30
    class ISO20022.Sese039001.Quantity51Choice {
        + OrgnlAndCurFace  : ISO20022.Sese039001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Sese039001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Sese039001.Quantity51Choice *-- ISO20022.Sese039001.OriginalAndCurrentQuantities1
    ISO20022.Sese039001.Quantity51Choice *-- ISO20022.Sese039001.FinancialInstrumentQuantity33Choice
    class ISO20022.Sese039001.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Sese039001.RejectionReason42Choice {
        + Prtry  : ISO20022.Sese039001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese039001.RejectionReason42Choice *-- ISO20022.Sese039001.GenericIdentification30
    class ISO20022.Sese039001.RejectionReason57 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese039001.RejectionReason42Choice
    }
    ISO20022.Sese039001.RejectionReason57 *-- ISO20022.Sese039001.RejectionReason42Choice
    class ISO20022.Sese039001.RejectionReason72Code {
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
    class ISO20022.Sese039001.RejectionStatus37Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese039001.RejectionReason57~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese039001.RejectionStatus37Choice *-- ISO20022.Sese039001.RejectionReason57
    class ISO20022.Sese039001.RepairReason10Choice {
        + Prtry  : ISO20022.Sese039001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese039001.RepairReason10Choice *-- ISO20022.Sese039001.GenericIdentification30
    class ISO20022.Sese039001.RepairReason4Code {
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
    class ISO20022.Sese039001.RepairReason9 {
        + AddtlRsnInf  : String
        + Cd  : ISO20022.Sese039001.RepairReason10Choice
    }
    ISO20022.Sese039001.RepairReason9 *-- ISO20022.Sese039001.RepairReason10Choice
    class ISO20022.Sese039001.RepairStatus13Choice {
        + Rsn  : global::System.Collections.Generic.List~ISO20022.Sese039001.RepairReason9~
        + NoSpcfdRsn  : String
    }
    ISO20022.Sese039001.RepairStatus13Choice *-- ISO20022.Sese039001.RepairReason9
    class ISO20022.Sese039001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Sese039001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Sese039001.SecuritiesAccount19 *-- ISO20022.Sese039001.GenericIdentification30
    class ISO20022.Sese039001.SecuritiesSettlementTransactionModificationRequestStatusAdviceV07 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Sese039001.SupplementaryData1~
        + TxDtls  : ISO20022.Sese039001.TransactionDetails171
        + ModPrcgSts  : ISO20022.Sese039001.ModificationProcessingStatus10Choice
        + TxId  : ISO20022.Sese039001.TransactionIdentifications33
        + BlckChainAdrOrWllt  : ISO20022.Sese039001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Sese039001.SecuritiesAccount19
        + AcctOwnr  : ISO20022.Sese039001.PartyIdentification144
        + ModReqRef  : String
    }
    ISO20022.Sese039001.SecuritiesSettlementTransactionModificationRequestStatusAdviceV07 *-- ISO20022.Sese039001.SupplementaryData1
    ISO20022.Sese039001.SecuritiesSettlementTransactionModificationRequestStatusAdviceV07 *-- ISO20022.Sese039001.TransactionDetails171
    ISO20022.Sese039001.SecuritiesSettlementTransactionModificationRequestStatusAdviceV07 *-- ISO20022.Sese039001.ModificationProcessingStatus10Choice
    ISO20022.Sese039001.SecuritiesSettlementTransactionModificationRequestStatusAdviceV07 *-- ISO20022.Sese039001.TransactionIdentifications33
    ISO20022.Sese039001.SecuritiesSettlementTransactionModificationRequestStatusAdviceV07 *-- ISO20022.Sese039001.BlockChainAddressWallet3
    ISO20022.Sese039001.SecuritiesSettlementTransactionModificationRequestStatusAdviceV07 *-- ISO20022.Sese039001.SecuritiesAccount19
    ISO20022.Sese039001.SecuritiesSettlementTransactionModificationRequestStatusAdviceV07 *-- ISO20022.Sese039001.PartyIdentification144
    class ISO20022.Sese039001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Sese039001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Sese039001.SecurityIdentification19 *-- ISO20022.Sese039001.OtherIdentification1
    class ISO20022.Sese039001.SettlementDate19Choice {
        + DtCd  : ISO20022.Sese039001.SettlementDateCode8Choice
        + Dt  : ISO20022.Sese039001.DateAndDateTime2Choice
    }
    ISO20022.Sese039001.SettlementDate19Choice *-- ISO20022.Sese039001.SettlementDateCode8Choice
    ISO20022.Sese039001.SettlementDate19Choice *-- ISO20022.Sese039001.DateAndDateTime2Choice
    class ISO20022.Sese039001.SettlementDateCode8Choice {
        + Prtry  : ISO20022.Sese039001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese039001.SettlementDateCode8Choice *-- ISO20022.Sese039001.GenericIdentification30
    class ISO20022.Sese039001.SettlementParties125 {
        + Pty5  : ISO20022.Sese039001.PartyIdentificationAndAccount195
        + Pty4  : ISO20022.Sese039001.PartyIdentificationAndAccount195
        + Pty3  : ISO20022.Sese039001.PartyIdentificationAndAccount195
        + Pty2  : ISO20022.Sese039001.PartyIdentificationAndAccount195
        + Pty1  : ISO20022.Sese039001.PartyIdentificationAndAccount195
        + Dpstry  : ISO20022.Sese039001.PartyIdentification314
    }
    ISO20022.Sese039001.SettlementParties125 *-- ISO20022.Sese039001.PartyIdentificationAndAccount195
    ISO20022.Sese039001.SettlementParties125 *-- ISO20022.Sese039001.PartyIdentificationAndAccount195
    ISO20022.Sese039001.SettlementParties125 *-- ISO20022.Sese039001.PartyIdentificationAndAccount195
    ISO20022.Sese039001.SettlementParties125 *-- ISO20022.Sese039001.PartyIdentificationAndAccount195
    ISO20022.Sese039001.SettlementParties125 *-- ISO20022.Sese039001.PartyIdentificationAndAccount195
    ISO20022.Sese039001.SettlementParties125 *-- ISO20022.Sese039001.PartyIdentification314
    class ISO20022.Sese039001.SupplementaryData1 {
        + Envlp  : ISO20022.Sese039001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Sese039001.SupplementaryData1 *-- ISO20022.Sese039001.SupplementaryDataEnvelope1
    class ISO20022.Sese039001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Sese039001.TradeDate8Choice {
        + DtCd  : ISO20022.Sese039001.TradeDateCode3Choice
        + Dt  : ISO20022.Sese039001.DateAndDateTime2Choice
    }
    ISO20022.Sese039001.TradeDate8Choice *-- ISO20022.Sese039001.TradeDateCode3Choice
    ISO20022.Sese039001.TradeDate8Choice *-- ISO20022.Sese039001.DateAndDateTime2Choice
    class ISO20022.Sese039001.TradeDateCode3Choice {
        + Prtry  : ISO20022.Sese039001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Sese039001.TradeDateCode3Choice *-- ISO20022.Sese039001.GenericIdentification30
    class ISO20022.Sese039001.TransactionDetails171 {
        + Invstr  : ISO20022.Sese039001.PartyIdentification149
        + RcvgSttlmPties  : ISO20022.Sese039001.SettlementParties125
        + DlvrgSttlmPties  : ISO20022.Sese039001.SettlementParties125
        + TradDt  : ISO20022.Sese039001.TradeDate8Choice
        + SttlmDt  : ISO20022.Sese039001.SettlementDate19Choice
        + SttlmAmt  : ISO20022.Sese039001.AmountAndDirection51
        + SttlmQty  : ISO20022.Sese039001.Quantity51Choice
        + Pmt  : String
        + SctiesMvmntTp  : String
        + FinInstrmId  : ISO20022.Sese039001.SecurityIdentification19
    }
    ISO20022.Sese039001.TransactionDetails171 *-- ISO20022.Sese039001.PartyIdentification149
    ISO20022.Sese039001.TransactionDetails171 *-- ISO20022.Sese039001.SettlementParties125
    ISO20022.Sese039001.TransactionDetails171 *-- ISO20022.Sese039001.SettlementParties125
    ISO20022.Sese039001.TransactionDetails171 *-- ISO20022.Sese039001.TradeDate8Choice
    ISO20022.Sese039001.TransactionDetails171 *-- ISO20022.Sese039001.SettlementDate19Choice
    ISO20022.Sese039001.TransactionDetails171 *-- ISO20022.Sese039001.AmountAndDirection51
    ISO20022.Sese039001.TransactionDetails171 *-- ISO20022.Sese039001.Quantity51Choice
    ISO20022.Sese039001.TransactionDetails171 *-- ISO20022.Sese039001.SecurityIdentification19
    class ISO20022.Sese039001.TransactionIdentifications33 {
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

## Value ISO20022.Sese039001.AcknowledgedAcceptedStatus23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese039001.AcknowledgementReason11>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese039001.AcknowledgementReason11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese039001.AcknowledgementReason14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese039001.AcknowledgementReason14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese039001.AcknowledgementReason6Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LATE|Int32||XmlEnum("""LATE""")|1|
||NSTP|Int32||XmlEnum("""NSTP""")|2|
||OTHR|Int32||XmlEnum("""OTHR""")|3|
||SMPG|Int32||XmlEnum("""SMPG""")|4|
||ADEA|Int32||XmlEnum("""ADEA""")|5|

---

## Value ISO20022.Sese039001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Sese039001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Sese039001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Sese039001.AmountAndDirection51


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Sese039001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Sese039001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Sese039001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese039001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Sese039001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Sese039001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Sese039001.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Sese039001.DateType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||OPEN|Int32||XmlEnum("""OPEN""")|2|

---

## Enum ISO20022.Sese039001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Value ISO20022.Sese039001.DeniedReason10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese039001.DeniedReason15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese039001.DeniedReason15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese039001.DeniedReason6Code


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

## Value ISO20022.Sese039001.DeniedStatus15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese039001.DeniedReason10>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Type ISO20022.Sese039001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSttlmTxModReqStsAdvc|ISO20022.Sese039001.SecuritiesSettlementTransactionModificationRequestStatusAdviceV07||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSttlmTxModReqStsAdvc))|

---

## Value ISO20022.Sese039001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Sese039001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Sese039001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese039001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese039001.ModificationProcessingStatus10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039001.ProprietaryStatusAndReason6||XmlElement()||
|+|Modfd|ISO20022.Sese039001.ModificationStatus4Choice||XmlElement()||
|+|Rprd|ISO20022.Sese039001.RepairStatus13Choice||XmlElement()||
|+|Rjctd|ISO20022.Sese039001.RejectionStatus37Choice||XmlElement()||
|+|Dnd|ISO20022.Sese039001.DeniedStatus15Choice||XmlElement()||
|+|PdgPrcg|ISO20022.Sese039001.PendingProcessingStatus13Choice||XmlElement()||
|+|AckdAccptd|ISO20022.Sese039001.AcknowledgedAcceptedStatus23Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Modfd),validElement(Rprd),validElement(Rjctd),validElement(Dnd),validElement(PdgPrcg),validElement(AckdAccptd),validChoice(Prtry,Modfd,Rprd,Rjctd,Dnd,PdgPrcg,AckdAccptd))|

---

## Value ISO20022.Sese039001.ModificationReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese039001.ModificationReason4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese039001.ModificationReason4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese039001.ModificationStatus4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese039001.ModificationReason4>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Enum ISO20022.Sese039001.ModifiedStatusReason1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OTHR|Int32||XmlEnum("""OTHR""")|1|
||MDBY|Int32||XmlEnum("""MDBY""")|2|

---

## Value ISO20022.Sese039001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Sese039001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Sese039001.NoReasonCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NORE|Int32||XmlEnum("""NORE""")|1|

---

## Value ISO20022.Sese039001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese039001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Sese039001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Sese039001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Sese039001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese039001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese039001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Sese039001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Sese039001.PartyIdentification134Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese039001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Sese039001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Sese039001.PartyIdentification144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese039001.PartyIdentification127Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese039001.PartyIdentification149


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese039001.PartyIdentification134Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese039001.PartyIdentification257Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Sese039001.NameAndAddress5||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(DgtlLdgrId,Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Sese039001.PartyIdentification314


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese039001.PartyIdentification257Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese039001.PartyIdentificationAndAccount195


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese039001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese039001.SecuritiesAccount19||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Sese039001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Sese039001.PendingProcessingReason10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese039001.PendingProcessingReason12Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese039001.PendingProcessingReason12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese039001.PendingProcessingReason3Code


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

## Value ISO20022.Sese039001.PendingProcessingStatus13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese039001.PendingProcessingReason10>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese039001.PostalAddress1


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

## Value ISO20022.Sese039001.ProprietaryReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Sese039001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Sese039001.ProprietaryStatusAndReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Sese039001.ProprietaryReason4>||XmlElement()||
|+|PrtrySts|ISO20022.Sese039001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Sese039001.Quantity51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Sese039001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Sese039001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Enum ISO20022.Sese039001.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Sese039001.RejectionReason42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese039001.RejectionReason57


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese039001.RejectionReason42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Enum ISO20022.Sese039001.RejectionReason72Code


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

## Value ISO20022.Sese039001.RejectionStatus37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese039001.RejectionReason57>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese039001.RepairReason10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Sese039001.RepairReason4Code


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

## Value ISO20022.Sese039001.RepairReason9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Cd|ISO20022.Sese039001.RepairReason10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd))|

---

## Value ISO20022.Sese039001.RepairStatus13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rsn|global::System.Collections.Generic.List<ISO20022.Sese039001.RepairReason9>||XmlElement()||
|+|NoSpcfdRsn|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Rsn""",Rsn),validList("""Rsn""",Rsn),validElement(Rsn),validChoice(Rsn,NoSpcfdRsn))|

---

## Value ISO20022.Sese039001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Sese039001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Aspect ISO20022.Sese039001.SecuritiesSettlementTransactionModificationRequestStatusAdviceV07


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Sese039001.SupplementaryData1>||XmlElement()||
|+|TxDtls|ISO20022.Sese039001.TransactionDetails171||XmlElement()||
|+|ModPrcgSts|ISO20022.Sese039001.ModificationProcessingStatus10Choice||XmlElement()||
|+|TxId|ISO20022.Sese039001.TransactionIdentifications33||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Sese039001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Sese039001.SecuritiesAccount19||XmlElement()||
|+|AcctOwnr|ISO20022.Sese039001.PartyIdentification144||XmlElement()||
|+|ModReqRef|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TxDtls),validElement(ModPrcgSts),validElement(TxId),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr))|

---

## Value ISO20022.Sese039001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Sese039001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Sese039001.SettlementDate19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese039001.SettlementDateCode8Choice||XmlElement()||
|+|Dt|ISO20022.Sese039001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese039001.SettlementDateCode8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese039001.SettlementParties125


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Sese039001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty4|ISO20022.Sese039001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty3|ISO20022.Sese039001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty2|ISO20022.Sese039001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty1|ISO20022.Sese039001.PartyIdentificationAndAccount195||XmlElement()||
|+|Dpstry|ISO20022.Sese039001.PartyIdentification314||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Value ISO20022.Sese039001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Sese039001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Sese039001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Sese039001.TradeDate8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Sese039001.TradeDateCode3Choice||XmlElement()||
|+|Dt|ISO20022.Sese039001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Sese039001.TradeDateCode3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Sese039001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Sese039001.TransactionDetails171


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Invstr|ISO20022.Sese039001.PartyIdentification149||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Sese039001.SettlementParties125||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Sese039001.SettlementParties125||XmlElement()||
|+|TradDt|ISO20022.Sese039001.TradeDate8Choice||XmlElement()||
|+|SttlmDt|ISO20022.Sese039001.SettlementDate19Choice||XmlElement()||
|+|SttlmAmt|ISO20022.Sese039001.AmountAndDirection51||XmlElement()||
|+|SttlmQty|ISO20022.Sese039001.Quantity51Choice||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
|+|FinInstrmId|ISO20022.Sese039001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Invstr),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(TradDt),validElement(SttlmDt),validElement(SttlmAmt),validElement(SttlmQty),validElement(FinInstrmId))|

---

## Value ISO20022.Sese039001.TransactionIdentifications33


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrId|String||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
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

