# colr.023.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Colr023001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Colr023001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Colr023001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Colr023001.AllocationStatus1Choice {
        + Prtry  : ISO20022.Colr023001.ProprietaryStatusAndReason6
        + PrtlyAllctd  : ISO20022.Colr023001.ProprietaryReason4
        + FullyAllctd  : ISO20022.Colr023001.ProprietaryReason4
    }
    ISO20022.Colr023001.AllocationStatus1Choice *-- ISO20022.Colr023001.ProprietaryStatusAndReason6
    ISO20022.Colr023001.AllocationStatus1Choice *-- ISO20022.Colr023001.ProprietaryReason4
    ISO20022.Colr023001.AllocationStatus1Choice *-- ISO20022.Colr023001.ProprietaryReason4
    class ISO20022.Colr023001.AlternatePartyIdentification7 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Colr023001.IdentificationType42Choice
    }
    ISO20022.Colr023001.AlternatePartyIdentification7 *-- ISO20022.Colr023001.IdentificationType42Choice
    class ISO20022.Colr023001.AmountAndDirection44 {
        + FXDtls  : ISO20022.Colr023001.ForeignExchangeTerms23
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Colr023001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Colr023001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Colr023001.AmountAndDirection44 *-- ISO20022.Colr023001.ForeignExchangeTerms23
    ISO20022.Colr023001.AmountAndDirection44 *-- ISO20022.Colr023001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr023001.AmountAndDirection44 *-- ISO20022.Colr023001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Colr023001.AmountAndDirection49 {
        + FXDtls  : ISO20022.Colr023001.ForeignExchangeTerms23
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Colr023001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Colr023001.ActiveCurrencyAndAmount
    }
    ISO20022.Colr023001.AmountAndDirection49 *-- ISO20022.Colr023001.ForeignExchangeTerms23
    ISO20022.Colr023001.AmountAndDirection49 *-- ISO20022.Colr023001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr023001.AmountAndDirection49 *-- ISO20022.Colr023001.ActiveCurrencyAndAmount
    class ISO20022.Colr023001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Colr023001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Colr023001.BlockChainAddressWallet3 *-- ISO20022.Colr023001.GenericIdentification30
    class ISO20022.Colr023001.CashAccountIdentification5Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Colr023001.CashMovement7 {
        + TrptyAgtSvcPrvdrCshMvmntId  : String
        + ClntCshMvmntId  : String
        + PosTp  : String
        + CshMvmntApprvd  : String
        + CollMvmnt  : String
        + MvmntSts  : ISO20022.Colr023001.ProprietaryStatusAndReason6
        + CshAcct  : ISO20022.Colr023001.CashAccountIdentification5Choice
        + CshAmt  : ISO20022.Colr023001.ActiveCurrencyAndAmount
        + CshMvmnt  : String
    }
    ISO20022.Colr023001.CashMovement7 *-- ISO20022.Colr023001.ProprietaryStatusAndReason6
    ISO20022.Colr023001.CashMovement7 *-- ISO20022.Colr023001.CashAccountIdentification5Choice
    ISO20022.Colr023001.CashMovement7 *-- ISO20022.Colr023001.ActiveCurrencyAndAmount
    class ISO20022.Colr023001.ClosingDate4Choice {
        + Cd  : ISO20022.Colr023001.Date3Choice
        + Dt  : ISO20022.Colr023001.DateAndDateTime2Choice
    }
    ISO20022.Colr023001.ClosingDate4Choice *-- ISO20022.Colr023001.Date3Choice
    ISO20022.Colr023001.ClosingDate4Choice *-- ISO20022.Colr023001.DateAndDateTime2Choice
    class ISO20022.Colr023001.CollateralAmount14 {
        + UdsptdTx  : ISO20022.Colr023001.AmountAndDirection49
        + ValSght  : ISO20022.Colr023001.AmountAndDirection49
        + Acrd  : ISO20022.Colr023001.AmountAndDirection49
        + Termntn  : ISO20022.Colr023001.AmountAndDirection49
        + Tx  : ISO20022.Colr023001.AmountAndDirection49
    }
    ISO20022.Colr023001.CollateralAmount14 *-- ISO20022.Colr023001.AmountAndDirection49
    ISO20022.Colr023001.CollateralAmount14 *-- ISO20022.Colr023001.AmountAndDirection49
    ISO20022.Colr023001.CollateralAmount14 *-- ISO20022.Colr023001.AmountAndDirection49
    ISO20022.Colr023001.CollateralAmount14 *-- ISO20022.Colr023001.AmountAndDirection49
    ISO20022.Colr023001.CollateralAmount14 *-- ISO20022.Colr023001.AmountAndDirection49
    class ISO20022.Colr023001.CollateralAmount5 {
        + RmngSttlm  : ISO20022.Colr023001.AmountAndDirection44
        + Sttld  : ISO20022.Colr023001.AmountAndDirection44
        + RmngCollsd  : ISO20022.Colr023001.AmountAndDirection44
        + Collsd  : ISO20022.Colr023001.AmountAndDirection44
        + ReqrdMrgn  : ISO20022.Colr023001.AmountAndDirection44
    }
    ISO20022.Colr023001.CollateralAmount5 *-- ISO20022.Colr023001.AmountAndDirection44
    ISO20022.Colr023001.CollateralAmount5 *-- ISO20022.Colr023001.AmountAndDirection44
    ISO20022.Colr023001.CollateralAmount5 *-- ISO20022.Colr023001.AmountAndDirection44
    ISO20022.Colr023001.CollateralAmount5 *-- ISO20022.Colr023001.AmountAndDirection44
    ISO20022.Colr023001.CollateralAmount5 *-- ISO20022.Colr023001.AmountAndDirection44
    class ISO20022.Colr023001.CollateralDate2 {
        + SttlmDt  : DateTime
        + ReqdExctnDt  : ISO20022.Colr023001.DateAndDateTime2Choice
        + TradDt  : DateTime
    }
    ISO20022.Colr023001.CollateralDate2 *-- ISO20022.Colr023001.DateAndDateTime2Choice
    class ISO20022.Colr023001.CollateralParameters13 {
        + CollAmt  : ISO20022.Colr023001.CollateralAmount5
        + SttlmApprvd  : String
        + CollApprvd  : String
        + AutomtcAllcn  : String
        + Prty  : ISO20022.Colr023001.GenericIdentification30
        + CollSd  : String
        + XpsrTp  : ISO20022.Colr023001.ExposureType23Choice
        + CollInstrTp  : ISO20022.Colr023001.CollateralTransactionType1Choice
    }
    ISO20022.Colr023001.CollateralParameters13 *-- ISO20022.Colr023001.CollateralAmount5
    ISO20022.Colr023001.CollateralParameters13 *-- ISO20022.Colr023001.GenericIdentification30
    ISO20022.Colr023001.CollateralParameters13 *-- ISO20022.Colr023001.ExposureType23Choice
    ISO20022.Colr023001.CollateralParameters13 *-- ISO20022.Colr023001.CollateralTransactionType1Choice
    class ISO20022.Colr023001.CollateralParties8 {
        + TrptyAgt  : ISO20022.Colr023001.PartyIdentification136
        + ClntPtyB  : ISO20022.Colr023001.PartyIdentificationAndAccount193
        + PtyB  : ISO20022.Colr023001.PartyIdentificationAndAccount203
        + ClntPtyA  : ISO20022.Colr023001.PartyIdentificationAndAccount193
        + PtyA  : ISO20022.Colr023001.PartyIdentificationAndAccount202
    }
    ISO20022.Colr023001.CollateralParties8 *-- ISO20022.Colr023001.PartyIdentification136
    ISO20022.Colr023001.CollateralParties8 *-- ISO20022.Colr023001.PartyIdentificationAndAccount193
    ISO20022.Colr023001.CollateralParties8 *-- ISO20022.Colr023001.PartyIdentificationAndAccount203
    ISO20022.Colr023001.CollateralParties8 *-- ISO20022.Colr023001.PartyIdentificationAndAccount193
    ISO20022.Colr023001.CollateralParties8 *-- ISO20022.Colr023001.PartyIdentificationAndAccount202
    class ISO20022.Colr023001.CollateralRole1Code {
        TAKE = 1
        GIVE = 2
    }
    class ISO20022.Colr023001.CollateralStatus3Choice {
        + Prtry  : global::System.Collections.Generic.List~ISO20022.Colr023001.ProprietaryStatusAndReason6~
        + Pdg  : global::System.Collections.Generic.List~ISO20022.Colr023001.ProprietaryReason4~
    }
    ISO20022.Colr023001.CollateralStatus3Choice *-- ISO20022.Colr023001.ProprietaryStatusAndReason6
    ISO20022.Colr023001.CollateralStatus3Choice *-- ISO20022.Colr023001.ProprietaryReason4
    class ISO20022.Colr023001.CollateralTransactionType1Choice {
        + Prtry  : ISO20022.Colr023001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr023001.CollateralTransactionType1Choice *-- ISO20022.Colr023001.GenericIdentification30
    class ISO20022.Colr023001.CollateralTransactionType1Code {
        TERM = 1
        RATA = 2
        PADJ = 3
        MADJ = 4
        INIT = 5
        DBVT = 6
        DADJ = 7
        CADJ = 8
        CDTA = 9
        AADJ = 10
    }
    class ISO20022.Colr023001.CreditDebit3Code {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Colr023001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Colr023001.Date3Choice {
        + Prtry  : ISO20022.Colr023001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr023001.Date3Choice *-- ISO20022.Colr023001.GenericIdentification30
    class ISO20022.Colr023001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Colr023001.DateType2Code {
        OPEN = 1
    }
    class ISO20022.Colr023001.DealTransactionDetails7 {
        + DealDtlsAmt  : ISO20022.Colr023001.CollateralAmount14
        + ClsgDt  : ISO20022.Colr023001.ClosingDate4Choice
    }
    ISO20022.Colr023001.DealTransactionDetails7 *-- ISO20022.Colr023001.CollateralAmount14
    ISO20022.Colr023001.DealTransactionDetails7 *-- ISO20022.Colr023001.ClosingDate4Choice
    class ISO20022.Colr023001.ExposureType14Code {
        MGLD = 1
        SHSL = 2
        REPO = 3
        TRBD = 4
        EQUI = 5
        CCPC = 6
        UDMS = 7
        TRCP = 8
        TBAS = 9
        SWPT = 10
        SCIE = 11
        SCIR = 12
        SLEB = 13
        SCRP = 14
        SBSC = 15
        SLOA = 16
        RVPO = 17
        OTCD = 18
        LIQU = 19
        OPTN = 20
        FUTR = 21
        FORW = 22
        FORX = 23
        FIXI = 24
        EXPT = 25
        EXTD = 26
        EQUS = 27
        EQPT = 28
        CRPR = 29
        CCIR = 30
        CRSP = 31
        CRTL = 32
        CRDS = 33
        COMM = 34
        CBCO = 35
        PAYM = 36
        BFWD = 37
    }
    class ISO20022.Colr023001.ExposureType23Choice {
        + Prtry  : ISO20022.Colr023001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr023001.ExposureType23Choice *-- ISO20022.Colr023001.GenericIdentification30
    class ISO20022.Colr023001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Colr023001.ForeignExchangeTerms23 {
        + RsltgAmt  : ISO20022.Colr023001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Colr023001.ForeignExchangeTerms23 *-- ISO20022.Colr023001.ActiveCurrencyAndAmount
    class ISO20022.Colr023001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr023001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr023001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Colr023001.IdentificationType42Choice {
        + Prtry  : ISO20022.Colr023001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr023001.IdentificationType42Choice *-- ISO20022.Colr023001.GenericIdentification30
    class ISO20022.Colr023001.NameAndAddress5 {
        + Adr  : ISO20022.Colr023001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Colr023001.NameAndAddress5 *-- ISO20022.Colr023001.PostalAddress1
    class ISO20022.Colr023001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Colr023001.OtherIdentification1 {
        + Tp  : ISO20022.Colr023001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Colr023001.OtherIdentification1 *-- ISO20022.Colr023001.IdentificationSource3Choice
    class ISO20022.Colr023001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Colr023001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Colr023001.NameAndAddress5
        + PrtryId  : ISO20022.Colr023001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Colr023001.PartyIdentification120Choice *-- ISO20022.Colr023001.NameAndAddress5
    ISO20022.Colr023001.PartyIdentification120Choice *-- ISO20022.Colr023001.GenericIdentification36
    class ISO20022.Colr023001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Colr023001.PartyIdentification120Choice
    }
    ISO20022.Colr023001.PartyIdentification136 *-- ISO20022.Colr023001.PartyIdentification120Choice
    class ISO20022.Colr023001.PartyIdentificationAndAccount193 {
        + AltrnId  : ISO20022.Colr023001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Colr023001.PartyIdentification120Choice
    }
    ISO20022.Colr023001.PartyIdentificationAndAccount193 *-- ISO20022.Colr023001.AlternatePartyIdentification7
    ISO20022.Colr023001.PartyIdentificationAndAccount193 *-- ISO20022.Colr023001.PartyIdentification120Choice
    class ISO20022.Colr023001.PartyIdentificationAndAccount202 {
        + PtyCpcty  : ISO20022.Colr023001.TradingPartyCapacity5Choice
        + AcctOwnr  : ISO20022.Colr023001.PartyIdentification136
        + BlckChainAdrOrWllt  : ISO20022.Colr023001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Colr023001.SecuritiesAccount19
        + AltrnId  : ISO20022.Colr023001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Colr023001.PartyIdentification120Choice
    }
    ISO20022.Colr023001.PartyIdentificationAndAccount202 *-- ISO20022.Colr023001.TradingPartyCapacity5Choice
    ISO20022.Colr023001.PartyIdentificationAndAccount202 *-- ISO20022.Colr023001.PartyIdentification136
    ISO20022.Colr023001.PartyIdentificationAndAccount202 *-- ISO20022.Colr023001.BlockChainAddressWallet3
    ISO20022.Colr023001.PartyIdentificationAndAccount202 *-- ISO20022.Colr023001.SecuritiesAccount19
    ISO20022.Colr023001.PartyIdentificationAndAccount202 *-- ISO20022.Colr023001.AlternatePartyIdentification7
    ISO20022.Colr023001.PartyIdentificationAndAccount202 *-- ISO20022.Colr023001.PartyIdentification120Choice
    class ISO20022.Colr023001.PartyIdentificationAndAccount203 {
        + PtyCpcty  : ISO20022.Colr023001.TradingPartyCapacity5Choice
        + BlckChainAdrOrWllt  : ISO20022.Colr023001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Colr023001.SecuritiesAccount19
        + AltrnId  : ISO20022.Colr023001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Colr023001.PartyIdentification120Choice
    }
    ISO20022.Colr023001.PartyIdentificationAndAccount203 *-- ISO20022.Colr023001.TradingPartyCapacity5Choice
    ISO20022.Colr023001.PartyIdentificationAndAccount203 *-- ISO20022.Colr023001.BlockChainAddressWallet3
    ISO20022.Colr023001.PartyIdentificationAndAccount203 *-- ISO20022.Colr023001.SecuritiesAccount19
    ISO20022.Colr023001.PartyIdentificationAndAccount203 *-- ISO20022.Colr023001.AlternatePartyIdentification7
    ISO20022.Colr023001.PartyIdentificationAndAccount203 *-- ISO20022.Colr023001.PartyIdentification120Choice
    class ISO20022.Colr023001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Colr023001.ProprietaryReason4 {
        + AddtlRsnInf  : String
        + Rsn  : ISO20022.Colr023001.GenericIdentification30
    }
    ISO20022.Colr023001.ProprietaryReason4 *-- ISO20022.Colr023001.GenericIdentification30
    class ISO20022.Colr023001.ProprietaryStatusAndReason6 {
        + PrtryRsn  : global::System.Collections.Generic.List~ISO20022.Colr023001.ProprietaryReason4~
        + PrtrySts  : ISO20022.Colr023001.GenericIdentification30
    }
    ISO20022.Colr023001.ProprietaryStatusAndReason6 *-- ISO20022.Colr023001.ProprietaryReason4
    ISO20022.Colr023001.ProprietaryStatusAndReason6 *-- ISO20022.Colr023001.GenericIdentification30
    class ISO20022.Colr023001.Quantity51Choice {
        + OrgnlAndCurFace  : ISO20022.Colr023001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Colr023001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Colr023001.Quantity51Choice *-- ISO20022.Colr023001.OriginalAndCurrentQuantities1
    ISO20022.Colr023001.Quantity51Choice *-- ISO20022.Colr023001.FinancialInstrumentQuantity33Choice
    class ISO20022.Colr023001.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Colr023001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Colr023001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Colr023001.SecuritiesAccount19 *-- ISO20022.Colr023001.GenericIdentification30
    class ISO20022.Colr023001.SecuritiesMovement8 {
        + MrgndVal  : ISO20022.Colr023001.AmountAndDirection44
        + TrptyAgtSvcPrvdrSctiesMvmntId  : String
        + ClntSctiesMvmntId  : String
        + BlckChainAdrOrWllt  : ISO20022.Colr023001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Colr023001.SecuritiesAccount19
        + PosTp  : String
        + SctiesMvmntsApprvd  : String
        + CollMvmnt  : String
        + MvmntSts  : ISO20022.Colr023001.SecuritiesMovementStatus1Choice
        + SctiesQty  : ISO20022.Colr023001.Quantity51Choice
        + FinInstrmId  : ISO20022.Colr023001.SecurityIdentification19
        + SctiesMvmntTp  : String
    }
    ISO20022.Colr023001.SecuritiesMovement8 *-- ISO20022.Colr023001.AmountAndDirection44
    ISO20022.Colr023001.SecuritiesMovement8 *-- ISO20022.Colr023001.BlockChainAddressWallet3
    ISO20022.Colr023001.SecuritiesMovement8 *-- ISO20022.Colr023001.SecuritiesAccount19
    ISO20022.Colr023001.SecuritiesMovement8 *-- ISO20022.Colr023001.SecuritiesMovementStatus1Choice
    ISO20022.Colr023001.SecuritiesMovement8 *-- ISO20022.Colr023001.Quantity51Choice
    ISO20022.Colr023001.SecuritiesMovement8 *-- ISO20022.Colr023001.SecurityIdentification19
    class ISO20022.Colr023001.SecuritiesMovementStatus1Choice {
        + Wait  : ISO20022.Colr023001.ProprietaryReason4
        + Tax  : ISO20022.Colr023001.ProprietaryReason4
        + Elgblty  : ISO20022.Colr023001.ProprietaryReason4
        + MnlyAccptd  : ISO20022.Colr023001.ProprietaryReason4
        + Pdg  : ISO20022.Colr023001.ProprietaryReason4
        + Futr  : ISO20022.Colr023001.ProprietaryReason4
        + Excld  : ISO20022.Colr023001.ProprietaryReason4
        + Ccy  : ISO20022.Colr023001.ProprietaryReason4
        + Csh  : ISO20022.Colr023001.ProprietaryReason4
        + Amt  : ISO20022.Colr023001.ProprietaryReason4
    }
    ISO20022.Colr023001.SecuritiesMovementStatus1Choice *-- ISO20022.Colr023001.ProprietaryReason4
    ISO20022.Colr023001.SecuritiesMovementStatus1Choice *-- ISO20022.Colr023001.ProprietaryReason4
    ISO20022.Colr023001.SecuritiesMovementStatus1Choice *-- ISO20022.Colr023001.ProprietaryReason4
    ISO20022.Colr023001.SecuritiesMovementStatus1Choice *-- ISO20022.Colr023001.ProprietaryReason4
    ISO20022.Colr023001.SecuritiesMovementStatus1Choice *-- ISO20022.Colr023001.ProprietaryReason4
    ISO20022.Colr023001.SecuritiesMovementStatus1Choice *-- ISO20022.Colr023001.ProprietaryReason4
    ISO20022.Colr023001.SecuritiesMovementStatus1Choice *-- ISO20022.Colr023001.ProprietaryReason4
    ISO20022.Colr023001.SecuritiesMovementStatus1Choice *-- ISO20022.Colr023001.ProprietaryReason4
    ISO20022.Colr023001.SecuritiesMovementStatus1Choice *-- ISO20022.Colr023001.ProprietaryReason4
    ISO20022.Colr023001.SecuritiesMovementStatus1Choice *-- ISO20022.Colr023001.ProprietaryReason4
    class ISO20022.Colr023001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Colr023001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Colr023001.SecurityIdentification19 *-- ISO20022.Colr023001.OtherIdentification1
    class ISO20022.Colr023001.SettlementStatus27Choice {
        + Prtry  : ISO20022.Colr023001.ProprietaryStatusAndReason6
        + Usttld  : global::System.Collections.Generic.List~ISO20022.Colr023001.ProprietaryReason4~
        + Sttld  : global::System.Collections.Generic.List~ISO20022.Colr023001.ProprietaryReason4~
        + PrtlSttlm  : global::System.Collections.Generic.List~ISO20022.Colr023001.ProprietaryReason4~
    }
    ISO20022.Colr023001.SettlementStatus27Choice *-- ISO20022.Colr023001.ProprietaryStatusAndReason6
    ISO20022.Colr023001.SettlementStatus27Choice *-- ISO20022.Colr023001.ProprietaryReason4
    ISO20022.Colr023001.SettlementStatus27Choice *-- ISO20022.Colr023001.ProprietaryReason4
    ISO20022.Colr023001.SettlementStatus27Choice *-- ISO20022.Colr023001.ProprietaryReason4
    class ISO20022.Colr023001.SupplementaryData1 {
        + Envlp  : ISO20022.Colr023001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Colr023001.SupplementaryData1 *-- ISO20022.Colr023001.SupplementaryDataEnvelope1
    class ISO20022.Colr023001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Colr023001.TradingCapacity7Code {
        PRIN = 1
        AGEN = 2
    }
    class ISO20022.Colr023001.TradingPartyCapacity5Choice {
        + Prtry  : ISO20022.Colr023001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr023001.TradingPartyCapacity5Choice *-- ISO20022.Colr023001.GenericIdentification30
    class ISO20022.Colr023001.TransactionIdentifications46 {
        + CmonTxId  : String
        + CtrPtyCollTxId  : String
        + TrptyAgtSvcPrvdrCollTxId  : String
        + TrptyAgtSvcPrvdrCollInstrId  : String
        + ClntCollTxId  : String
        + ClntCollInstrId  : String
    }
    class ISO20022.Colr023001.TripartyCollateralStatusAdviceV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Colr023001.SupplementaryData1~
        + CshMvmnt  : global::System.Collections.Generic.List~ISO20022.Colr023001.CashMovement7~
        + SctiesMvmnt  : global::System.Collections.Generic.List~ISO20022.Colr023001.SecuritiesMovement8~
        + DealTxDt  : ISO20022.Colr023001.CollateralDate2
        + DealTxDtls  : ISO20022.Colr023001.DealTransactionDetails7
        + CollPties  : ISO20022.Colr023001.CollateralParties8
        + GnlParams  : ISO20022.Colr023001.CollateralParameters13
        + CollSts  : ISO20022.Colr023001.CollateralStatus3Choice
        + SttlmSts  : ISO20022.Colr023001.SettlementStatus27Choice
        + AllcnSts  : ISO20022.Colr023001.AllocationStatus1Choice
        + Pgntn  : ISO20022.Colr023001.Pagination1
        + TxInstrId  : ISO20022.Colr023001.TransactionIdentifications46
    }
    ISO20022.Colr023001.TripartyCollateralStatusAdviceV01 *-- ISO20022.Colr023001.SupplementaryData1
    ISO20022.Colr023001.TripartyCollateralStatusAdviceV01 *-- ISO20022.Colr023001.CashMovement7
    ISO20022.Colr023001.TripartyCollateralStatusAdviceV01 *-- ISO20022.Colr023001.SecuritiesMovement8
    ISO20022.Colr023001.TripartyCollateralStatusAdviceV01 *-- ISO20022.Colr023001.CollateralDate2
    ISO20022.Colr023001.TripartyCollateralStatusAdviceV01 *-- ISO20022.Colr023001.DealTransactionDetails7
    ISO20022.Colr023001.TripartyCollateralStatusAdviceV01 *-- ISO20022.Colr023001.CollateralParties8
    ISO20022.Colr023001.TripartyCollateralStatusAdviceV01 *-- ISO20022.Colr023001.CollateralParameters13
    ISO20022.Colr023001.TripartyCollateralStatusAdviceV01 *-- ISO20022.Colr023001.CollateralStatus3Choice
    ISO20022.Colr023001.TripartyCollateralStatusAdviceV01 *-- ISO20022.Colr023001.SettlementStatus27Choice
    ISO20022.Colr023001.TripartyCollateralStatusAdviceV01 *-- ISO20022.Colr023001.AllocationStatus1Choice
    ISO20022.Colr023001.TripartyCollateralStatusAdviceV01 *-- ISO20022.Colr023001.Pagination1
    ISO20022.Colr023001.TripartyCollateralStatusAdviceV01 *-- ISO20022.Colr023001.TransactionIdentifications46
    class ISO20022.Colr023001.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
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

## Value ISO20022.Colr023001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Colr023001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Colr023001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Colr023001.AllocationStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr023001.ProprietaryStatusAndReason6||XmlElement()||
|+|PrtlyAllctd|ISO20022.Colr023001.ProprietaryReason4||XmlElement()||
|+|FullyAllctd|ISO20022.Colr023001.ProprietaryReason4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(PrtlyAllctd),validElement(FullyAllctd),validChoice(Prtry,PrtlyAllctd,FullyAllctd))|

---

## Value ISO20022.Colr023001.AlternatePartyIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Colr023001.IdentificationType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Colr023001.AmountAndDirection44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Colr023001.ForeignExchangeTerms23||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Colr023001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Colr023001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Colr023001.AmountAndDirection49


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Colr023001.ForeignExchangeTerms23||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Colr023001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Colr023001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Colr023001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr023001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr023001.CashAccountIdentification5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Value ISO20022.Colr023001.CashMovement7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrptyAgtSvcPrvdrCshMvmntId|String||XmlElement()||
|+|ClntCshMvmntId|String||XmlElement()||
|+|PosTp|String||XmlElement()||
|+|CshMvmntApprvd|String||XmlElement()||
|+|CollMvmnt|String||XmlElement()||
|+|MvmntSts|ISO20022.Colr023001.ProprietaryStatusAndReason6||XmlElement()||
|+|CshAcct|ISO20022.Colr023001.CashAccountIdentification5Choice||XmlElement()||
|+|CshAmt|ISO20022.Colr023001.ActiveCurrencyAndAmount||XmlElement()||
|+|CshMvmnt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MvmntSts),validElement(CshAcct),validElement(CshAmt))|

---

## Value ISO20022.Colr023001.ClosingDate4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|ISO20022.Colr023001.Date3Choice||XmlElement()||
|+|Dt|ISO20022.Colr023001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd),validElement(Dt),validChoice(Cd,Dt))|

---

## Value ISO20022.Colr023001.CollateralAmount14


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UdsptdTx|ISO20022.Colr023001.AmountAndDirection49||XmlElement()||
|+|ValSght|ISO20022.Colr023001.AmountAndDirection49||XmlElement()||
|+|Acrd|ISO20022.Colr023001.AmountAndDirection49||XmlElement()||
|+|Termntn|ISO20022.Colr023001.AmountAndDirection49||XmlElement()||
|+|Tx|ISO20022.Colr023001.AmountAndDirection49||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UdsptdTx),validElement(ValSght),validElement(Acrd),validElement(Termntn),validElement(Tx))|

---

## Value ISO20022.Colr023001.CollateralAmount5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RmngSttlm|ISO20022.Colr023001.AmountAndDirection44||XmlElement()||
|+|Sttld|ISO20022.Colr023001.AmountAndDirection44||XmlElement()||
|+|RmngCollsd|ISO20022.Colr023001.AmountAndDirection44||XmlElement()||
|+|Collsd|ISO20022.Colr023001.AmountAndDirection44||XmlElement()||
|+|ReqrdMrgn|ISO20022.Colr023001.AmountAndDirection44||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RmngSttlm),validElement(Sttld),validElement(RmngCollsd),validElement(Collsd),validElement(ReqrdMrgn))|

---

## Value ISO20022.Colr023001.CollateralDate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmDt|DateTime||XmlElement()||
|+|ReqdExctnDt|ISO20022.Colr023001.DateAndDateTime2Choice||XmlElement()||
|+|TradDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqdExctnDt))|

---

## Value ISO20022.Colr023001.CollateralParameters13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollAmt|ISO20022.Colr023001.CollateralAmount5||XmlElement()||
|+|SttlmApprvd|String||XmlElement()||
|+|CollApprvd|String||XmlElement()||
|+|AutomtcAllcn|String||XmlElement()||
|+|Prty|ISO20022.Colr023001.GenericIdentification30||XmlElement()||
|+|CollSd|String||XmlElement()||
|+|XpsrTp|ISO20022.Colr023001.ExposureType23Choice||XmlElement()||
|+|CollInstrTp|ISO20022.Colr023001.CollateralTransactionType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollAmt),validElement(Prty),validElement(XpsrTp),validElement(CollInstrTp))|

---

## Value ISO20022.Colr023001.CollateralParties8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrptyAgt|ISO20022.Colr023001.PartyIdentification136||XmlElement()||
|+|ClntPtyB|ISO20022.Colr023001.PartyIdentificationAndAccount193||XmlElement()||
|+|PtyB|ISO20022.Colr023001.PartyIdentificationAndAccount203||XmlElement()||
|+|ClntPtyA|ISO20022.Colr023001.PartyIdentificationAndAccount193||XmlElement()||
|+|PtyA|ISO20022.Colr023001.PartyIdentificationAndAccount202||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrptyAgt),validElement(ClntPtyB),validElement(PtyB),validElement(ClntPtyA),validElement(PtyA))|

---

## Enum ISO20022.Colr023001.CollateralRole1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAKE|Int32||XmlEnum("""TAKE""")|1|
||GIVE|Int32||XmlEnum("""GIVE""")|2|

---

## Value ISO20022.Colr023001.CollateralStatus3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|global::System.Collections.Generic.List<ISO20022.Colr023001.ProprietaryStatusAndReason6>||XmlElement()||
|+|Pdg|global::System.Collections.Generic.List<ISO20022.Colr023001.ProprietaryReason4>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Prtry""",Prtry),validList("""Prtry""",Prtry),validElement(Prtry),validRequired("""Pdg""",Pdg),validList("""Pdg""",Pdg),validElement(Pdg),validChoice(Prtry,Pdg))|

---

## Value ISO20022.Colr023001.CollateralTransactionType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr023001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Colr023001.CollateralTransactionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TERM|Int32||XmlEnum("""TERM""")|1|
||RATA|Int32||XmlEnum("""RATA""")|2|
||PADJ|Int32||XmlEnum("""PADJ""")|3|
||MADJ|Int32||XmlEnum("""MADJ""")|4|
||INIT|Int32||XmlEnum("""INIT""")|5|
||DBVT|Int32||XmlEnum("""DBVT""")|6|
||DADJ|Int32||XmlEnum("""DADJ""")|7|
||CADJ|Int32||XmlEnum("""CADJ""")|8|
||CDTA|Int32||XmlEnum("""CDTA""")|9|
||AADJ|Int32||XmlEnum("""AADJ""")|10|

---

## Enum ISO20022.Colr023001.CreditDebit3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Enum ISO20022.Colr023001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Colr023001.Date3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr023001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr023001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Colr023001.DateType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEN|Int32||XmlEnum("""OPEN""")|1|

---

## Value ISO20022.Colr023001.DealTransactionDetails7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DealDtlsAmt|ISO20022.Colr023001.CollateralAmount14||XmlElement()||
|+|ClsgDt|ISO20022.Colr023001.ClosingDate4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DealDtlsAmt),validElement(ClsgDt))|

---

## Type ISO20022.Colr023001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrptyCollStsAdvc|ISO20022.Colr023001.TripartyCollateralStatusAdviceV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrptyCollStsAdvc))|

---

## Enum ISO20022.Colr023001.ExposureType14Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MGLD|Int32||XmlEnum("""MGLD""")|1|
||SHSL|Int32||XmlEnum("""SHSL""")|2|
||REPO|Int32||XmlEnum("""REPO""")|3|
||TRBD|Int32||XmlEnum("""TRBD""")|4|
||EQUI|Int32||XmlEnum("""EQUI""")|5|
||CCPC|Int32||XmlEnum("""CCPC""")|6|
||UDMS|Int32||XmlEnum("""UDMS""")|7|
||TRCP|Int32||XmlEnum("""TRCP""")|8|
||TBAS|Int32||XmlEnum("""TBAS""")|9|
||SWPT|Int32||XmlEnum("""SWPT""")|10|
||SCIE|Int32||XmlEnum("""SCIE""")|11|
||SCIR|Int32||XmlEnum("""SCIR""")|12|
||SLEB|Int32||XmlEnum("""SLEB""")|13|
||SCRP|Int32||XmlEnum("""SCRP""")|14|
||SBSC|Int32||XmlEnum("""SBSC""")|15|
||SLOA|Int32||XmlEnum("""SLOA""")|16|
||RVPO|Int32||XmlEnum("""RVPO""")|17|
||OTCD|Int32||XmlEnum("""OTCD""")|18|
||LIQU|Int32||XmlEnum("""LIQU""")|19|
||OPTN|Int32||XmlEnum("""OPTN""")|20|
||FUTR|Int32||XmlEnum("""FUTR""")|21|
||FORW|Int32||XmlEnum("""FORW""")|22|
||FORX|Int32||XmlEnum("""FORX""")|23|
||FIXI|Int32||XmlEnum("""FIXI""")|24|
||EXPT|Int32||XmlEnum("""EXPT""")|25|
||EXTD|Int32||XmlEnum("""EXTD""")|26|
||EQUS|Int32||XmlEnum("""EQUS""")|27|
||EQPT|Int32||XmlEnum("""EQPT""")|28|
||CRPR|Int32||XmlEnum("""CRPR""")|29|
||CCIR|Int32||XmlEnum("""CCIR""")|30|
||CRSP|Int32||XmlEnum("""CRSP""")|31|
||CRTL|Int32||XmlEnum("""CRTL""")|32|
||CRDS|Int32||XmlEnum("""CRDS""")|33|
||COMM|Int32||XmlEnum("""COMM""")|34|
||CBCO|Int32||XmlEnum("""CBCO""")|35|
||PAYM|Int32||XmlEnum("""PAYM""")|36|
||BFWD|Int32||XmlEnum("""BFWD""")|37|

---

## Value ISO20022.Colr023001.ExposureType23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr023001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr023001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Colr023001.ForeignExchangeTerms23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Colr023001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Colr023001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Colr023001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr023001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr023001.IdentificationType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr023001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr023001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Colr023001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Colr023001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr023001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Colr023001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr023001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Colr023001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Colr023001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Colr023001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Colr023001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Colr023001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Colr023001.PartyIdentificationAndAccount193


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|ISO20022.Colr023001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Colr023001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Colr023001.PartyIdentificationAndAccount202


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCpcty|ISO20022.Colr023001.TradingPartyCapacity5Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Colr023001.PartyIdentification136||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Colr023001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Colr023001.SecuritiesAccount19||XmlElement()||
|+|AltrnId|ISO20022.Colr023001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Colr023001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyCpcty),validElement(AcctOwnr),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Colr023001.PartyIdentificationAndAccount203


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCpcty|ISO20022.Colr023001.TradingPartyCapacity5Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Colr023001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Colr023001.SecuritiesAccount19||XmlElement()||
|+|AltrnId|ISO20022.Colr023001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Colr023001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyCpcty),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Colr023001.PostalAddress1


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

## Value ISO20022.Colr023001.ProprietaryReason4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRsnInf|String||XmlElement()||
|+|Rsn|ISO20022.Colr023001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rsn))|

---

## Value ISO20022.Colr023001.ProprietaryStatusAndReason6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRsn|global::System.Collections.Generic.List<ISO20022.Colr023001.ProprietaryReason4>||XmlElement()||
|+|PrtrySts|ISO20022.Colr023001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""PrtryRsn""",PrtryRsn),validElement(PrtryRsn),validElement(PrtrySts))|

---

## Value ISO20022.Colr023001.Quantity51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Colr023001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Colr023001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Enum ISO20022.Colr023001.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Colr023001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr023001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr023001.SecuritiesMovement8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MrgndVal|ISO20022.Colr023001.AmountAndDirection44||XmlElement()||
|+|TrptyAgtSvcPrvdrSctiesMvmntId|String||XmlElement()||
|+|ClntSctiesMvmntId|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Colr023001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Colr023001.SecuritiesAccount19||XmlElement()||
|+|PosTp|String||XmlElement()||
|+|SctiesMvmntsApprvd|String||XmlElement()||
|+|CollMvmnt|String||XmlElement()||
|+|MvmntSts|ISO20022.Colr023001.SecuritiesMovementStatus1Choice||XmlElement()||
|+|SctiesQty|ISO20022.Colr023001.Quantity51Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Colr023001.SecurityIdentification19||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MrgndVal),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(MvmntSts),validElement(SctiesQty),validElement(FinInstrmId))|

---

## Value ISO20022.Colr023001.SecuritiesMovementStatus1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Wait|ISO20022.Colr023001.ProprietaryReason4||XmlElement()||
|+|Tax|ISO20022.Colr023001.ProprietaryReason4||XmlElement()||
|+|Elgblty|ISO20022.Colr023001.ProprietaryReason4||XmlElement()||
|+|MnlyAccptd|ISO20022.Colr023001.ProprietaryReason4||XmlElement()||
|+|Pdg|ISO20022.Colr023001.ProprietaryReason4||XmlElement()||
|+|Futr|ISO20022.Colr023001.ProprietaryReason4||XmlElement()||
|+|Excld|ISO20022.Colr023001.ProprietaryReason4||XmlElement()||
|+|Ccy|ISO20022.Colr023001.ProprietaryReason4||XmlElement()||
|+|Csh|ISO20022.Colr023001.ProprietaryReason4||XmlElement()||
|+|Amt|ISO20022.Colr023001.ProprietaryReason4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Wait),validElement(Tax),validElement(Elgblty),validElement(MnlyAccptd),validElement(Pdg),validElement(Futr),validElement(Excld),validElement(Ccy),validElement(Csh),validElement(Amt),validChoice(Wait,Tax,Elgblty,MnlyAccptd,Pdg,Futr,Excld,Ccy,Csh,Amt))|

---

## Value ISO20022.Colr023001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Colr023001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Colr023001.SettlementStatus27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr023001.ProprietaryStatusAndReason6||XmlElement()||
|+|Usttld|global::System.Collections.Generic.List<ISO20022.Colr023001.ProprietaryReason4>||XmlElement()||
|+|Sttld|global::System.Collections.Generic.List<ISO20022.Colr023001.ProprietaryReason4>||XmlElement()||
|+|PrtlSttlm|global::System.Collections.Generic.List<ISO20022.Colr023001.ProprietaryReason4>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validRequired("""Usttld""",Usttld),validList("""Usttld""",Usttld),validElement(Usttld),validRequired("""Sttld""",Sttld),validList("""Sttld""",Sttld),validElement(Sttld),validRequired("""PrtlSttlm""",PrtlSttlm),validList("""PrtlSttlm""",PrtlSttlm),validElement(PrtlSttlm),validChoice(Prtry,Usttld,Sttld,PrtlSttlm))|

---

## Value ISO20022.Colr023001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Colr023001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Colr023001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Colr023001.TradingCapacity7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRIN|Int32||XmlEnum("""PRIN""")|1|
||AGEN|Int32||XmlEnum("""AGEN""")|2|

---

## Value ISO20022.Colr023001.TradingPartyCapacity5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr023001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr023001.TransactionIdentifications46


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CmonTxId|String||XmlElement()||
|+|CtrPtyCollTxId|String||XmlElement()||
|+|TrptyAgtSvcPrvdrCollTxId|String||XmlElement()||
|+|TrptyAgtSvcPrvdrCollInstrId|String||XmlElement()||
|+|ClntCollTxId|String||XmlElement()||
|+|ClntCollInstrId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Aspect ISO20022.Colr023001.TripartyCollateralStatusAdviceV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Colr023001.SupplementaryData1>||XmlElement()||
|+|CshMvmnt|global::System.Collections.Generic.List<ISO20022.Colr023001.CashMovement7>||XmlElement()||
|+|SctiesMvmnt|global::System.Collections.Generic.List<ISO20022.Colr023001.SecuritiesMovement8>||XmlElement()||
|+|DealTxDt|ISO20022.Colr023001.CollateralDate2||XmlElement()||
|+|DealTxDtls|ISO20022.Colr023001.DealTransactionDetails7||XmlElement()||
|+|CollPties|ISO20022.Colr023001.CollateralParties8||XmlElement()||
|+|GnlParams|ISO20022.Colr023001.CollateralParameters13||XmlElement()||
|+|CollSts|ISO20022.Colr023001.CollateralStatus3Choice||XmlElement()||
|+|SttlmSts|ISO20022.Colr023001.SettlementStatus27Choice||XmlElement()||
|+|AllcnSts|ISO20022.Colr023001.AllocationStatus1Choice||XmlElement()||
|+|Pgntn|ISO20022.Colr023001.Pagination1||XmlElement()||
|+|TxInstrId|ISO20022.Colr023001.TransactionIdentifications46||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""CshMvmnt""",CshMvmnt),validElement(CshMvmnt),validList("""SctiesMvmnt""",SctiesMvmnt),validElement(SctiesMvmnt),validElement(DealTxDt),validElement(DealTxDtls),validElement(CollPties),validElement(GnlParams),validElement(CollSts),validElement(SttlmSts),validElement(AllcnSts),validElement(Pgntn),validElement(TxInstrId))|

---

## Enum ISO20022.Colr023001.TypeOfIdentification1Code


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

## View Hiperspace.Node
node in a graph view of data

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|SKey|String||||
|+|TypeName|String||||
|+|Name|String||||
||Froms|Hiperspace.Edge|||From = this|
||Tos|Hiperspace.Edge|||To = this|

