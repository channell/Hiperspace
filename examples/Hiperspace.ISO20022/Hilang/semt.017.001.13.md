# semt.017.001.13
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt017001.Account29 {
        + AcctSvcr  : ISO20022.Semt017001.PartyIdentification120Choice
        + Id  : ISO20022.Semt017001.AccountIdentification26
    }
    ISO20022.Semt017001.Account29 *-- ISO20022.Semt017001.PartyIdentification120Choice
    ISO20022.Semt017001.Account29 *-- ISO20022.Semt017001.AccountIdentification26
    class ISO20022.Semt017001.AccountIdentification26 {
        + Prtry  : ISO20022.Semt017001.SimpleIdentificationInformation4
    }
    ISO20022.Semt017001.AccountIdentification26 *-- ISO20022.Semt017001.SimpleIdentificationInformation4
    class ISO20022.Semt017001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt017001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt017001.AdditionalReference10 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Semt017001.PartyIdentification139
        + Ref  : String
    }
    ISO20022.Semt017001.AdditionalReference10 *-- ISO20022.Semt017001.PartyIdentification139
    class ISO20022.Semt017001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Semt017001.AmountAndDirection21 {
        + CdtDbtInd  : String
        + Amt  : ISO20022.Semt017001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Semt017001.AmountAndDirection21 *-- ISO20022.Semt017001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Semt017001.AmountAndDirection3 {
        + CdtDbt  : String
        + Amt  : ISO20022.Semt017001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Semt017001.AmountAndDirection3 *-- ISO20022.Semt017001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Semt017001.BalanceQuantity14Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification56
        + Qty  : ISO20022.Semt017001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Semt017001.BalanceQuantity14Choice *-- ISO20022.Semt017001.GenericIdentification56
    ISO20022.Semt017001.BalanceQuantity14Choice *-- ISO20022.Semt017001.FinancialInstrumentQuantity33Choice
    class ISO20022.Semt017001.BeneficialOwnership4Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Semt017001.BeneficialOwnership4Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.BlockChainAddressWallet2 {
        + Nm  : String
        + Tp  : ISO20022.Semt017001.PurposeCode7Choice
        + Id  : String
    }
    ISO20022.Semt017001.BlockChainAddressWallet2 *-- ISO20022.Semt017001.PurposeCode7Choice
    class ISO20022.Semt017001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Semt017001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Semt017001.BlockChainAddressWallet3 *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.BlockChainAddressWallet4 {
        + Dsgnt  : String
        + Nm  : String
        + Tp  : ISO20022.Semt017001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Semt017001.BlockChainAddressWallet4 *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.BlockTrade1Code {
        BLCH = 1
        BLPA = 2
    }
    class ISO20022.Semt017001.BlockTrade4Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.BlockTrade4Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.CashSettlementSystem2Code {
        NETS = 1
        GROS = 2
    }
    class ISO20022.Semt017001.CashSettlementSystem4Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.CashSettlementSystem4Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.CentralCounterPartyEligibility4Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Semt017001.CentralCounterPartyEligibility4Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.ClosingBalance5 {
        + ClsgBal  : ISO20022.Semt017001.ClosingBalance6Choice
        + ShrtLngInd  : String
    }
    ISO20022.Semt017001.ClosingBalance5 *-- ISO20022.Semt017001.ClosingBalance6Choice
    class ISO20022.Semt017001.ClosingBalance6Choice {
        + Intrmy  : ISO20022.Semt017001.BalanceQuantity14Choice
        + Fnl  : ISO20022.Semt017001.BalanceQuantity14Choice
    }
    ISO20022.Semt017001.ClosingBalance6Choice *-- ISO20022.Semt017001.BalanceQuantity14Choice
    ISO20022.Semt017001.ClosingBalance6Choice *-- ISO20022.Semt017001.BalanceQuantity14Choice
    class ISO20022.Semt017001.CorporateActionEventType110Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.CorporateActionEventType110Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.CorporateActionEventType38Code {
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
    class ISO20022.Semt017001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Semt017001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Semt017001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Semt017001.DateType3Code {
        VARI = 1
    }
    class ISO20022.Semt017001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Semt017001.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class ISO20022.Semt017001.EventFrequency4Code {
        WEEK = 1
        INDA = 2
        DAIL = 3
        MNTH = 4
        ADHO = 5
        YEAR = 6
    }
    class ISO20022.Semt017001.FinancialInstrument72 {
        + ClssfctnTp  : ISO20022.Semt017001.SecurityClassificationType2Choice
        + DstrbtnPlcy  : String
        + ClssTp  : String
        + SctiesForm  : String
        + SplmtryId  : String
    }
    ISO20022.Semt017001.FinancialInstrument72 *-- ISO20022.Semt017001.SecurityClassificationType2Choice
    class ISO20022.Semt017001.FinancialInstrumentDetails46 {
        + Tx  : global::System.Collections.Generic.List~ISO20022.Semt017001.Transaction161~
        + ClsgBal  : ISO20022.Semt017001.ClosingBalance5
        + OpngBal  : ISO20022.Semt017001.OpeningBalance5
        + SfkpgPlc  : ISO20022.Semt017001.SafeKeepingPlace5
        + PricDtls  : ISO20022.Semt017001.PriceInformation30
        + InvstmtFndsFinInstrmAttrbts  : ISO20022.Semt017001.FinancialInstrument72
        + FinInstrmId  : ISO20022.Semt017001.SecurityIdentification19
    }
    ISO20022.Semt017001.FinancialInstrumentDetails46 *-- ISO20022.Semt017001.Transaction161
    ISO20022.Semt017001.FinancialInstrumentDetails46 *-- ISO20022.Semt017001.ClosingBalance5
    ISO20022.Semt017001.FinancialInstrumentDetails46 *-- ISO20022.Semt017001.OpeningBalance5
    ISO20022.Semt017001.FinancialInstrumentDetails46 *-- ISO20022.Semt017001.SafeKeepingPlace5
    ISO20022.Semt017001.FinancialInstrumentDetails46 *-- ISO20022.Semt017001.PriceInformation30
    ISO20022.Semt017001.FinancialInstrumentDetails46 *-- ISO20022.Semt017001.FinancialInstrument72
    ISO20022.Semt017001.FinancialInstrumentDetails46 *-- ISO20022.Semt017001.SecurityIdentification19
    class ISO20022.Semt017001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Semt017001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Semt017001.Frequency25Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.Frequency25Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Semt017001.GenericIdentification3 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt017001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt017001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt017001.GenericIdentification56 {
        + Bal  : Decimal
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt017001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Semt017001.GenericIdentification30
    }
    ISO20022.Semt017001.GenericIdentification78 *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt017001.Intermediary44 {
        + Acct  : ISO20022.Semt017001.Account29
        + Role  : ISO20022.Semt017001.Role6Choice
        + Id  : ISO20022.Semt017001.PartyIdentification136
    }
    ISO20022.Semt017001.Intermediary44 *-- ISO20022.Semt017001.Account29
    ISO20022.Semt017001.Intermediary44 *-- ISO20022.Semt017001.Role6Choice
    ISO20022.Semt017001.Intermediary44 *-- ISO20022.Semt017001.PartyIdentification136
    class ISO20022.Semt017001.InvestmentFundRole2Code {
        TRAN = 1
        UCL2 = 2
        UCL1 = 3
        CONC = 4
        DIST = 5
        INTR = 6
        TRAG = 7
        REGI = 8
        FMCO = 9
    }
    class ISO20022.Semt017001.LetterOfGuarantee4Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Semt017001.LetterOfGuarantee4Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.MarketClientSide1Code {
        MAKT = 1
        CLNT = 2
    }
    class ISO20022.Semt017001.MarketClientSide6Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.MarketClientSide6Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.MarketIdentification1Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Semt017001.MarketIdentification5Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Semt017001.MarketIdentification84 {
        + Tp  : ISO20022.Semt017001.MarketType8Choice
        + Id  : ISO20022.Semt017001.MarketIdentification1Choice
    }
    ISO20022.Semt017001.MarketIdentification84 *-- ISO20022.Semt017001.MarketType8Choice
    ISO20022.Semt017001.MarketIdentification84 *-- ISO20022.Semt017001.MarketIdentification1Choice
    class ISO20022.Semt017001.MarketIdentification98 {
        + Tp  : ISO20022.Semt017001.MarketType19Choice
        + Id  : ISO20022.Semt017001.MarketIdentification5Choice
    }
    ISO20022.Semt017001.MarketIdentification98 *-- ISO20022.Semt017001.MarketType19Choice
    ISO20022.Semt017001.MarketIdentification98 *-- ISO20022.Semt017001.MarketIdentification5Choice
    class ISO20022.Semt017001.MarketType19Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.MarketType19Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Semt017001.MarketType8Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.MarketType8Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.MarketType9Code {
        SCAS = 1
        VEND = 2
        THEO = 3
        LMAR = 4
        FUND = 5
    }
    class ISO20022.Semt017001.NameAndAddress5 {
        + Adr  : ISO20022.Semt017001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Semt017001.NameAndAddress5 *-- ISO20022.Semt017001.PostalAddress1
    class ISO20022.Semt017001.NettingEligibility4Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Semt017001.NettingEligibility4Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.Number3Choice {
        + Lng  : String
        + Shrt  : String
    }
    class ISO20022.Semt017001.OpeningBalance5 {
        + OpngBal  : ISO20022.Semt017001.OpeningBalance6Choice
        + ShrtLngInd  : String
    }
    ISO20022.Semt017001.OpeningBalance5 *-- ISO20022.Semt017001.OpeningBalance6Choice
    class ISO20022.Semt017001.OpeningBalance6Choice {
        + Intrmy  : ISO20022.Semt017001.BalanceQuantity14Choice
        + Frst  : ISO20022.Semt017001.BalanceQuantity14Choice
    }
    ISO20022.Semt017001.OpeningBalance6Choice *-- ISO20022.Semt017001.BalanceQuantity14Choice
    ISO20022.Semt017001.OpeningBalance6Choice *-- ISO20022.Semt017001.BalanceQuantity14Choice
    class ISO20022.Semt017001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Semt017001.OtherIdentification1 {
        + Tp  : ISO20022.Semt017001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Semt017001.OtherIdentification1 *-- ISO20022.Semt017001.IdentificationSource3Choice
    class ISO20022.Semt017001.OwnershipLegalRestrictions1Code {
        RSTR = 1
        NRST = 2
        A144 = 3
    }
    class ISO20022.Semt017001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Semt017001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Semt017001.NameAndAddress5
        + PrtryId  : ISO20022.Semt017001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Semt017001.PartyIdentification120Choice *-- ISO20022.Semt017001.NameAndAddress5
    ISO20022.Semt017001.PartyIdentification120Choice *-- ISO20022.Semt017001.GenericIdentification36
    class ISO20022.Semt017001.PartyIdentification125Choice {
        + NmAndAdr  : ISO20022.Semt017001.NameAndAddress5
        + PrtryId  : ISO20022.Semt017001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Semt017001.PartyIdentification125Choice *-- ISO20022.Semt017001.NameAndAddress5
    ISO20022.Semt017001.PartyIdentification125Choice *-- ISO20022.Semt017001.GenericIdentification1
    class ISO20022.Semt017001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Semt017001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Semt017001.PartyIdentification127Choice *-- ISO20022.Semt017001.GenericIdentification36
    class ISO20022.Semt017001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Semt017001.PartyIdentification120Choice
    }
    ISO20022.Semt017001.PartyIdentification136 *-- ISO20022.Semt017001.PartyIdentification120Choice
    class ISO20022.Semt017001.PartyIdentification139 {
        + LEI  : String
        + Pty  : ISO20022.Semt017001.PartyIdentification125Choice
    }
    ISO20022.Semt017001.PartyIdentification139 *-- ISO20022.Semt017001.PartyIdentification125Choice
    class ISO20022.Semt017001.PartyIdentification144 {
        + LEI  : String
        + Id  : ISO20022.Semt017001.PartyIdentification127Choice
    }
    ISO20022.Semt017001.PartyIdentification144 *-- ISO20022.Semt017001.PartyIdentification127Choice
    class ISO20022.Semt017001.PartyIdentification257Choice {
        + DgtlLdgrId  : String
        + Ctry  : String
        + NmAndAdr  : ISO20022.Semt017001.NameAndAddress5
        + AnyBIC  : String
    }
    ISO20022.Semt017001.PartyIdentification257Choice *-- ISO20022.Semt017001.NameAndAddress5
    class ISO20022.Semt017001.PartyIdentification314 {
        + PrcgId  : String
        + LEI  : String
        + Id  : ISO20022.Semt017001.PartyIdentification257Choice
    }
    ISO20022.Semt017001.PartyIdentification314 *-- ISO20022.Semt017001.PartyIdentification257Choice
    class ISO20022.Semt017001.PartyIdentificationAndAccount195 {
        + PrcgId  : String
        + BlckChainAdrOrWllt  : ISO20022.Semt017001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Semt017001.SecuritiesAccount19
        + LEI  : String
        + Id  : ISO20022.Semt017001.PartyIdentification120Choice
    }
    ISO20022.Semt017001.PartyIdentificationAndAccount195 *-- ISO20022.Semt017001.BlockChainAddressWallet3
    ISO20022.Semt017001.PartyIdentificationAndAccount195 *-- ISO20022.Semt017001.SecuritiesAccount19
    ISO20022.Semt017001.PartyIdentificationAndAccount195 *-- ISO20022.Semt017001.PartyIdentification120Choice
    class ISO20022.Semt017001.Period2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Semt017001.Period7Choice {
        + FrDtToDt  : ISO20022.Semt017001.Period2
        + FrDtTmToDtTm  : ISO20022.Semt017001.DateTimePeriod1
    }
    ISO20022.Semt017001.Period7Choice *-- ISO20022.Semt017001.Period2
    ISO20022.Semt017001.Period7Choice *-- ISO20022.Semt017001.DateTimePeriod1
    class ISO20022.Semt017001.PlaceOfClearingIdentification2 {
        + LEI  : String
        + Id  : String
    }
    class ISO20022.Semt017001.PlaceOfTradeIdentification1 {
        + LEI  : String
        + MktTpAndId  : ISO20022.Semt017001.MarketIdentification84
    }
    ISO20022.Semt017001.PlaceOfTradeIdentification1 *-- ISO20022.Semt017001.MarketIdentification84
    class ISO20022.Semt017001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Semt017001.PriceInformation30 {
        + QtnDt  : ISO20022.Semt017001.DateAndDateTime2Choice
        + SrcOfPric  : ISO20022.Semt017001.MarketIdentification98
        + Val  : ISO20022.Semt017001.PriceRateOrAmountOrUnknown2Choice
        + ValTp  : ISO20022.Semt017001.YieldedOrValueType1Choice
        + Tp  : ISO20022.Semt017001.TypeOfPrice48Choice
    }
    ISO20022.Semt017001.PriceInformation30 *-- ISO20022.Semt017001.DateAndDateTime2Choice
    ISO20022.Semt017001.PriceInformation30 *-- ISO20022.Semt017001.MarketIdentification98
    ISO20022.Semt017001.PriceInformation30 *-- ISO20022.Semt017001.PriceRateOrAmountOrUnknown2Choice
    ISO20022.Semt017001.PriceInformation30 *-- ISO20022.Semt017001.YieldedOrValueType1Choice
    ISO20022.Semt017001.PriceInformation30 *-- ISO20022.Semt017001.TypeOfPrice48Choice
    class ISO20022.Semt017001.PriceRateOrAmountOrUnknown2Choice {
        + UknwnInd  : String
        + Amt  : ISO20022.Semt017001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Semt017001.PriceRateOrAmountOrUnknown2Choice *-- ISO20022.Semt017001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Semt017001.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Semt017001.PurposeCode7Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.PurposeCode7Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.Quantity51Choice {
        + OrgnlAndCurFace  : ISO20022.Semt017001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Semt017001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Semt017001.Quantity51Choice *-- ISO20022.Semt017001.OriginalAndCurrentQuantities1
    ISO20022.Semt017001.Quantity51Choice *-- ISO20022.Semt017001.FinancialInstrumentQuantity33Choice
    class ISO20022.Semt017001.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Semt017001.Registration1Code {
        YREG = 1
        NREG = 2
    }
    class ISO20022.Semt017001.Registration9Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.Registration9Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.RepurchaseType22Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.RepurchaseType22Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.RepurchaseType9Code {
        WTHD = 1
        TOPU = 2
        CADJ = 3
        ROLP = 4
        CALL = 5
        RATE = 6
        PADJ = 7
        PAIR = 8
    }
    class ISO20022.Semt017001.Restriction5Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.Restriction5Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.Role6Choice {
        + Txt  : String
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.Role6Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.SafeKeepingPlace5 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Semt017001.SafekeepingPlaceFormat41Choice
    }
    ISO20022.Semt017001.SafeKeepingPlace5 *-- ISO20022.Semt017001.SafekeepingPlaceFormat41Choice
    class ISO20022.Semt017001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Semt017001.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Semt017001.SafekeepingPlaceFormat41Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification78
        + TpAndId  : ISO20022.Semt017001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Semt017001.SafekeepingPlaceTypeAndText8
    }
    ISO20022.Semt017001.SafekeepingPlaceFormat41Choice *-- ISO20022.Semt017001.GenericIdentification78
    ISO20022.Semt017001.SafekeepingPlaceFormat41Choice *-- ISO20022.Semt017001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Semt017001.SafekeepingPlaceFormat41Choice *-- ISO20022.Semt017001.SafekeepingPlaceTypeAndText8
    class ISO20022.Semt017001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt017001.SafekeepingPlaceTypeAndText8 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt017001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Semt017001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Semt017001.SecuritiesAccount19 *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.SecuritiesAccount25 {
        + Nm  : String
        + Tp  : ISO20022.Semt017001.PurposeCode7Choice
        + Id  : String
    }
    ISO20022.Semt017001.SecuritiesAccount25 *-- ISO20022.Semt017001.PurposeCode7Choice
    class ISO20022.Semt017001.SecuritiesAccount36 {
        + Dsgnt  : String
        + Nm  : String
        + Tp  : ISO20022.Semt017001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Semt017001.SecuritiesAccount36 *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.SecuritiesAccountPurposeType1Code {
        PHYS = 1
        DVPA = 2
        CEND = 3
        ABRD = 4
        SHOR = 5
        MARG = 6
    }
    class ISO20022.Semt017001.SecuritiesRTGS4Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Ind  : String
    }
    ISO20022.Semt017001.SecuritiesRTGS4Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.SecuritiesTransactionPostingReportV13 {
        + SubAcctDtls  : global::System.Collections.Generic.List~ISO20022.Semt017001.SubAccountIdentification73~
        + FinInstrmDtls  : global::System.Collections.Generic.List~ISO20022.Semt017001.FinancialInstrumentDetails46~
        + IntrmyInf  : global::System.Collections.Generic.List~ISO20022.Semt017001.Intermediary44~
        + BlckChainAdrOrWllt  : ISO20022.Semt017001.BlockChainAddressWallet4
        + SfkpgAcct  : ISO20022.Semt017001.SecuritiesAccount36
        + AcctOwnr  : ISO20022.Semt017001.PartyIdentification144
        + StmtGnlDtls  : ISO20022.Semt017001.Statement79
        + Pgntn  : ISO20022.Semt017001.Pagination1
    }
    ISO20022.Semt017001.SecuritiesTransactionPostingReportV13 *-- ISO20022.Semt017001.SubAccountIdentification73
    ISO20022.Semt017001.SecuritiesTransactionPostingReportV13 *-- ISO20022.Semt017001.FinancialInstrumentDetails46
    ISO20022.Semt017001.SecuritiesTransactionPostingReportV13 *-- ISO20022.Semt017001.Intermediary44
    ISO20022.Semt017001.SecuritiesTransactionPostingReportV13 *-- ISO20022.Semt017001.BlockChainAddressWallet4
    ISO20022.Semt017001.SecuritiesTransactionPostingReportV13 *-- ISO20022.Semt017001.SecuritiesAccount36
    ISO20022.Semt017001.SecuritiesTransactionPostingReportV13 *-- ISO20022.Semt017001.PartyIdentification144
    ISO20022.Semt017001.SecuritiesTransactionPostingReportV13 *-- ISO20022.Semt017001.Statement79
    ISO20022.Semt017001.SecuritiesTransactionPostingReportV13 *-- ISO20022.Semt017001.Pagination1
    class ISO20022.Semt017001.SecuritiesTransactionType27Code {
        TOUT = 1
        TRIN = 2
        REBL = 3
        ETFT = 4
        SWIT = 5
        SWIF = 6
        AUTO = 7
        CORP = 8
        CLAI = 9
        TURN = 10
        TRVO = 11
        TRPO = 12
        TRAD = 13
        TBAC = 14
        SYND = 15
        SUBS = 16
        SLRE = 17
        SECL = 18
        SECB = 19
        SBRE = 20
        SBBK = 21
        RVPO = 22
        RODE = 23
        REPU = 24
        RELE = 25
        REDM = 26
        REDI = 27
        REAL = 28
        PORT = 29
        PLAC = 30
        PAIR = 31
        OWNI = 32
        OWNE = 33
        NSYN = 34
        NETT = 35
        MKUP = 36
        MKDW = 37
        ISSU = 38
        INSP = 39
        FCTA = 40
        CONV = 41
        COLO = 42
        COLI = 43
        CNCB = 44
        BYIY = 45
        BSBK = 46
    }
    class ISO20022.Semt017001.SecuritiesTransactionType48Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.SecuritiesTransactionType48Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.SecurityClassificationType2Choice {
        + AltrnClssfctn  : ISO20022.Semt017001.GenericIdentification3
        + CFI  : String
    }
    ISO20022.Semt017001.SecurityClassificationType2Choice *-- ISO20022.Semt017001.GenericIdentification3
    class ISO20022.Semt017001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Semt017001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Semt017001.SecurityIdentification19 *-- ISO20022.Semt017001.OtherIdentification1
    class ISO20022.Semt017001.SettlementDate17Choice {
        + DtCd  : ISO20022.Semt017001.SettlementDateCode7Choice
        + Dt  : ISO20022.Semt017001.DateAndDateTime2Choice
    }
    ISO20022.Semt017001.SettlementDate17Choice *-- ISO20022.Semt017001.SettlementDateCode7Choice
    ISO20022.Semt017001.SettlementDate17Choice *-- ISO20022.Semt017001.DateAndDateTime2Choice
    class ISO20022.Semt017001.SettlementDate4Code {
        WISS = 1
    }
    class ISO20022.Semt017001.SettlementDateCode7Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.SettlementDateCode7Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.SettlementDetails190 {
        + PrtlSttlmInd  : String
        + LttrOfGrnt  : ISO20022.Semt017001.LetterOfGuarantee4Choice
        + CCPElgblty  : ISO20022.Semt017001.CentralCounterPartyEligibility4Choice
        + NetgElgblty  : ISO20022.Semt017001.NettingEligibility4Choice
        + SttlmSysMtd  : ISO20022.Semt017001.SettlementSystemMethod4Choice
        + LglRstrctns  : ISO20022.Semt017001.Restriction5Choice
        + BlckTrad  : ISO20022.Semt017001.BlockTrade4Choice
        + MktClntSd  : ISO20022.Semt017001.MarketClientSide6Choice
        + RpTp  : ISO20022.Semt017001.RepurchaseType22Choice
        + TaxCpcty  : ISO20022.Semt017001.TaxCapacityParty4Choice
        + CshClrSys  : ISO20022.Semt017001.CashSettlementSystem4Choice
        + BnfclOwnrsh  : ISO20022.Semt017001.BeneficialOwnership4Choice
        + Regn  : ISO20022.Semt017001.Registration9Choice
        + SctiesRTGS  : ISO20022.Semt017001.SecuritiesRTGS4Choice
        + StmpDtyTaxBsis  : ISO20022.Semt017001.GenericIdentification30
        + SttlgCpcty  : ISO20022.Semt017001.SettlingCapacity7Choice
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Semt017001.SettlementTransactionCondition34Choice~
    }
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.LetterOfGuarantee4Choice
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.CentralCounterPartyEligibility4Choice
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.NettingEligibility4Choice
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.SettlementSystemMethod4Choice
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.Restriction5Choice
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.BlockTrade4Choice
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.MarketClientSide6Choice
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.RepurchaseType22Choice
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.TaxCapacityParty4Choice
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.CashSettlementSystem4Choice
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.BeneficialOwnership4Choice
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.Registration9Choice
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.SecuritiesRTGS4Choice
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.GenericIdentification30
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.SettlingCapacity7Choice
    ISO20022.Semt017001.SettlementDetails190 *-- ISO20022.Semt017001.SettlementTransactionCondition34Choice
    class ISO20022.Semt017001.SettlementOrCorporateActionEvent35Choice {
        + CorpActnEvtTp  : ISO20022.Semt017001.CorporateActionEventType110Choice
        + SctiesTxTp  : ISO20022.Semt017001.SecuritiesTransactionType48Choice
    }
    ISO20022.Semt017001.SettlementOrCorporateActionEvent35Choice *-- ISO20022.Semt017001.CorporateActionEventType110Choice
    ISO20022.Semt017001.SettlementOrCorporateActionEvent35Choice *-- ISO20022.Semt017001.SecuritiesTransactionType48Choice
    class ISO20022.Semt017001.SettlementParties125 {
        + Pty5  : ISO20022.Semt017001.PartyIdentificationAndAccount195
        + Pty4  : ISO20022.Semt017001.PartyIdentificationAndAccount195
        + Pty3  : ISO20022.Semt017001.PartyIdentificationAndAccount195
        + Pty2  : ISO20022.Semt017001.PartyIdentificationAndAccount195
        + Pty1  : ISO20022.Semt017001.PartyIdentificationAndAccount195
        + Dpstry  : ISO20022.Semt017001.PartyIdentification314
    }
    ISO20022.Semt017001.SettlementParties125 *-- ISO20022.Semt017001.PartyIdentificationAndAccount195
    ISO20022.Semt017001.SettlementParties125 *-- ISO20022.Semt017001.PartyIdentificationAndAccount195
    ISO20022.Semt017001.SettlementParties125 *-- ISO20022.Semt017001.PartyIdentificationAndAccount195
    ISO20022.Semt017001.SettlementParties125 *-- ISO20022.Semt017001.PartyIdentificationAndAccount195
    ISO20022.Semt017001.SettlementParties125 *-- ISO20022.Semt017001.PartyIdentificationAndAccount195
    ISO20022.Semt017001.SettlementParties125 *-- ISO20022.Semt017001.PartyIdentification314
    class ISO20022.Semt017001.SettlementSystemMethod1Code {
        YSET = 1
        NSET = 2
    }
    class ISO20022.Semt017001.SettlementSystemMethod4Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.SettlementSystemMethod4Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.SettlementTransactionCondition12Code {
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
    class ISO20022.Semt017001.SettlementTransactionCondition34Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.SettlementTransactionCondition34Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.SettlementTransactionCondition5Code {
        PARQ = 1
        PARC = 2
        NPAR = 3
        PART = 4
    }
    class ISO20022.Semt017001.SettlingCapacity2Code {
        RISP = 1
        SPRI = 2
        CUST = 3
        SAGE = 4
    }
    class ISO20022.Semt017001.SettlingCapacity7Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.SettlingCapacity7Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Semt017001.SimpleIdentificationInformation4 {
        + Id  : String
    }
    class ISO20022.Semt017001.Statement79 {
        + SubAcctInd  : String
        + ActvtyInd  : String
        + StmtBsis  : ISO20022.Semt017001.StatementBasis8Choice
        + UpdTp  : ISO20022.Semt017001.UpdateType15Choice
        + Frqcy  : ISO20022.Semt017001.Frequency25Choice
        + StmtPrd  : ISO20022.Semt017001.Period7Choice
        + StmtId  : String
        + QryRef  : String
        + RptNb  : ISO20022.Semt017001.Number3Choice
    }
    ISO20022.Semt017001.Statement79 *-- ISO20022.Semt017001.StatementBasis8Choice
    ISO20022.Semt017001.Statement79 *-- ISO20022.Semt017001.UpdateType15Choice
    ISO20022.Semt017001.Statement79 *-- ISO20022.Semt017001.Frequency25Choice
    ISO20022.Semt017001.Statement79 *-- ISO20022.Semt017001.Period7Choice
    ISO20022.Semt017001.Statement79 *-- ISO20022.Semt017001.Number3Choice
    class ISO20022.Semt017001.StatementBasis2Code {
        TRAD = 1
        SETT = 2
    }
    class ISO20022.Semt017001.StatementBasis8Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.StatementBasis8Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.StatementUpdateType1Code {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Semt017001.SubAccountIdentification73 {
        + FinInstrmDtls  : global::System.Collections.Generic.List~ISO20022.Semt017001.FinancialInstrumentDetails46~
        + ActvtyInd  : String
        + BlckChainAdrOrWllt  : ISO20022.Semt017001.BlockChainAddressWallet2
        + SfkpgAcct  : ISO20022.Semt017001.SecuritiesAccount25
        + AcctOwnr  : ISO20022.Semt017001.PartyIdentification144
    }
    ISO20022.Semt017001.SubAccountIdentification73 *-- ISO20022.Semt017001.FinancialInstrumentDetails46
    ISO20022.Semt017001.SubAccountIdentification73 *-- ISO20022.Semt017001.BlockChainAddressWallet2
    ISO20022.Semt017001.SubAccountIdentification73 *-- ISO20022.Semt017001.SecuritiesAccount25
    ISO20022.Semt017001.SubAccountIdentification73 *-- ISO20022.Semt017001.PartyIdentification144
    class ISO20022.Semt017001.SupplementaryData1 {
        + Envlp  : ISO20022.Semt017001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Semt017001.SupplementaryData1 *-- ISO20022.Semt017001.SupplementaryDataEnvelope1
    class ISO20022.Semt017001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Semt017001.TaxCapacityParty4Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.TaxCapacityParty4Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.TaxLiability1Code {
        AGEN = 1
        PRIN = 2
    }
    class ISO20022.Semt017001.TradeDate8Choice {
        + DtCd  : ISO20022.Semt017001.TradeDateCode3Choice
        + Dt  : ISO20022.Semt017001.DateAndDateTime2Choice
    }
    ISO20022.Semt017001.TradeDate8Choice *-- ISO20022.Semt017001.TradeDateCode3Choice
    ISO20022.Semt017001.TradeDate8Choice *-- ISO20022.Semt017001.DateAndDateTime2Choice
    class ISO20022.Semt017001.TradeDateCode3Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.TradeDateCode3Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.Transaction161 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt017001.SupplementaryData1~
        + TxDtls  : ISO20022.Semt017001.TransactionDetails169
        + AcctSvcrLegId  : String
        + AcctOwnrLegId  : String
        + ClntRef  : ISO20022.Semt017001.AdditionalReference10
        + MstrRef  : String
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
    ISO20022.Semt017001.Transaction161 *-- ISO20022.Semt017001.SupplementaryData1
    ISO20022.Semt017001.Transaction161 *-- ISO20022.Semt017001.TransactionDetails169
    ISO20022.Semt017001.Transaction161 *-- ISO20022.Semt017001.AdditionalReference10
    class ISO20022.Semt017001.TransactionActivity1Code {
        SETT = 1
        CORP = 2
        COLL = 3
        CLAI = 4
        BOLE = 5
    }
    class ISO20022.Semt017001.TransactionActivity3Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.TransactionActivity3Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.TransactionDetails169 {
        + TxAddtlDtls  : String
        + RvslInd  : String
        + RcvgSttlmPties  : ISO20022.Semt017001.SettlementParties125
        + DlvrgSttlmPties  : ISO20022.Semt017001.SettlementParties125
        + MtchdStsTmStmp  : DateTime
        + AckdStsTmStmp  : DateTime
        + ValDt  : ISO20022.Semt017001.DateAndDateTime2Choice
        + SttlmDt  : ISO20022.Semt017001.SettlementDate17Choice
        + FctvSttlmDt  : ISO20022.Semt017001.DateAndDateTime2Choice
        + TradDt  : ISO20022.Semt017001.TradeDate8Choice
        + AcrdIntrstAmt  : ISO20022.Semt017001.AmountAndDirection21
        + PstngAmt  : ISO20022.Semt017001.AmountAndDirection3
        + NbOfDaysAcrd  : Decimal
        + PstngQty  : ISO20022.Semt017001.Quantity51Choice
        + PlcOfClr  : ISO20022.Semt017001.PlaceOfClearingIdentification2
        + SfkpgPlc  : ISO20022.Semt017001.SafeKeepingPlace5
        + PlcOfTrad  : ISO20022.Semt017001.PlaceOfTradeIdentification1
        + SttlmParams  : ISO20022.Semt017001.SettlementDetails190
        + Pmt  : String
        + SctiesMvmntTp  : String
        + SttlmTxOrCorpActnEvtTp  : ISO20022.Semt017001.SettlementOrCorporateActionEvent35Choice
        + TxActvty  : ISO20022.Semt017001.TransactionActivity3Choice
    }
    ISO20022.Semt017001.TransactionDetails169 *-- ISO20022.Semt017001.SettlementParties125
    ISO20022.Semt017001.TransactionDetails169 *-- ISO20022.Semt017001.SettlementParties125
    ISO20022.Semt017001.TransactionDetails169 *-- ISO20022.Semt017001.DateAndDateTime2Choice
    ISO20022.Semt017001.TransactionDetails169 *-- ISO20022.Semt017001.SettlementDate17Choice
    ISO20022.Semt017001.TransactionDetails169 *-- ISO20022.Semt017001.DateAndDateTime2Choice
    ISO20022.Semt017001.TransactionDetails169 *-- ISO20022.Semt017001.TradeDate8Choice
    ISO20022.Semt017001.TransactionDetails169 *-- ISO20022.Semt017001.AmountAndDirection21
    ISO20022.Semt017001.TransactionDetails169 *-- ISO20022.Semt017001.AmountAndDirection3
    ISO20022.Semt017001.TransactionDetails169 *-- ISO20022.Semt017001.Quantity51Choice
    ISO20022.Semt017001.TransactionDetails169 *-- ISO20022.Semt017001.PlaceOfClearingIdentification2
    ISO20022.Semt017001.TransactionDetails169 *-- ISO20022.Semt017001.SafeKeepingPlace5
    ISO20022.Semt017001.TransactionDetails169 *-- ISO20022.Semt017001.PlaceOfTradeIdentification1
    ISO20022.Semt017001.TransactionDetails169 *-- ISO20022.Semt017001.SettlementDetails190
    ISO20022.Semt017001.TransactionDetails169 *-- ISO20022.Semt017001.SettlementOrCorporateActionEvent35Choice
    ISO20022.Semt017001.TransactionDetails169 *-- ISO20022.Semt017001.TransactionActivity3Choice
    class ISO20022.Semt017001.TypeOfPrice17Code {
        ACTU = 1
        DDVR = 2
        INDC = 3
        MRKT = 4
        SWIC = 5
        RINV = 6
        MIDD = 7
        SWNG = 8
        INTE = 9
        CANC = 10
        CREA = 11
        NAVL = 12
        OFFR = 13
        BIDE = 14
    }
    class ISO20022.Semt017001.TypeOfPrice48Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.TypeOfPrice48Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.UpdateType15Choice {
        + Prtry  : ISO20022.Semt017001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt017001.UpdateType15Choice *-- ISO20022.Semt017001.GenericIdentification30
    class ISO20022.Semt017001.YieldedOrValueType1Choice {
        + ValTp  : String
        + Yldd  : String
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

## Value ISO20022.Semt017001.Account29


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|ISO20022.Semt017001.PartyIdentification120Choice||XmlElement()||
|+|Id|ISO20022.Semt017001.AccountIdentification26||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcr),validElement(Id))|

---

## Value ISO20022.Semt017001.AccountIdentification26


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.SimpleIdentificationInformation4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry))|

---

## Value ISO20022.Semt017001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt017001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt017001.AdditionalReference10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Semt017001.PartyIdentification139||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefIssr))|

---

## Enum ISO20022.Semt017001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Semt017001.AmountAndDirection21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Semt017001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Semt017001.AmountAndDirection3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbt|String||XmlElement()||
|+|Amt|ISO20022.Semt017001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Semt017001.BalanceQuantity14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification56||XmlElement()||
|+|Qty|ISO20022.Semt017001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Qty),validChoice(Prtry,Qty))|

---

## Value ISO20022.Semt017001.BeneficialOwnership4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Semt017001.BlockChainAddressWallet2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt017001.PurposeCode7Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt017001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt017001.BlockChainAddressWallet4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dsgnt|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Semt017001.BlockTrade1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BLCH|Int32||XmlEnum("""BLCH""")|1|
||BLPA|Int32||XmlEnum("""BLPA""")|2|

---

## Value ISO20022.Semt017001.BlockTrade4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017001.CashSettlementSystem2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETS|Int32||XmlEnum("""NETS""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Value ISO20022.Semt017001.CashSettlementSystem4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017001.CentralCounterPartyEligibility4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Semt017001.ClosingBalance5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClsgBal|ISO20022.Semt017001.ClosingBalance6Choice||XmlElement()||
|+|ShrtLngInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClsgBal))|

---

## Value ISO20022.Semt017001.ClosingBalance6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Intrmy|ISO20022.Semt017001.BalanceQuantity14Choice||XmlElement()||
|+|Fnl|ISO20022.Semt017001.BalanceQuantity14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Intrmy),validElement(Fnl),validChoice(Intrmy,Fnl))|

---

## Value ISO20022.Semt017001.CorporateActionEventType110Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017001.CorporateActionEventType38Code


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

## Enum ISO20022.Semt017001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Semt017001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Semt017001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Semt017001.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Semt017001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Enum ISO20022.Semt017001.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||DIST|Int32||XmlEnum("""DIST""")|2|

---

## Type ISO20022.Semt017001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesTxPstngRpt|ISO20022.Semt017001.SecuritiesTransactionPostingReportV13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesTxPstngRpt))|

---

## Enum ISO20022.Semt017001.EventFrequency4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||INDA|Int32||XmlEnum("""INDA""")|2|
||DAIL|Int32||XmlEnum("""DAIL""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||ADHO|Int32||XmlEnum("""ADHO""")|5|
||YEAR|Int32||XmlEnum("""YEAR""")|6|

---

## Value ISO20022.Semt017001.FinancialInstrument72


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClssfctnTp|ISO20022.Semt017001.SecurityClassificationType2Choice||XmlElement()||
|+|DstrbtnPlcy|String||XmlElement()||
|+|ClssTp|String||XmlElement()||
|+|SctiesForm|String||XmlElement()||
|+|SplmtryId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClssfctnTp))|

---

## Value ISO20022.Semt017001.FinancialInstrumentDetails46


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|global::System.Collections.Generic.List<ISO20022.Semt017001.Transaction161>||XmlElement()||
|+|ClsgBal|ISO20022.Semt017001.ClosingBalance5||XmlElement()||
|+|OpngBal|ISO20022.Semt017001.OpeningBalance5||XmlElement()||
|+|SfkpgPlc|ISO20022.Semt017001.SafeKeepingPlace5||XmlElement()||
|+|PricDtls|ISO20022.Semt017001.PriceInformation30||XmlElement()||
|+|InvstmtFndsFinInstrmAttrbts|ISO20022.Semt017001.FinancialInstrument72||XmlElement()||
|+|FinInstrmId|ISO20022.Semt017001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Tx""",Tx),validList("""Tx""",Tx),validElement(Tx),validElement(ClsgBal),validElement(OpngBal),validElement(SfkpgPlc),validElement(PricDtls),validElement(InvstmtFndsFinInstrmAttrbts),validElement(FinInstrmId))|

---

## Value ISO20022.Semt017001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Enum ISO20022.Semt017001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Semt017001.Frequency25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt017001.GenericIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt017001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt017001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt017001.GenericIdentification56


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|Decimal||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt017001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt017001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017001.Intermediary44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Acct|ISO20022.Semt017001.Account29||XmlElement()||
|+|Role|ISO20022.Semt017001.Role6Choice||XmlElement()||
|+|Id|ISO20022.Semt017001.PartyIdentification136||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Acct),validElement(Role),validElement(Id))|

---

## Enum ISO20022.Semt017001.InvestmentFundRole2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAN|Int32||XmlEnum("""TRAN""")|1|
||UCL2|Int32||XmlEnum("""UCL2""")|2|
||UCL1|Int32||XmlEnum("""UCL1""")|3|
||CONC|Int32||XmlEnum("""CONC""")|4|
||DIST|Int32||XmlEnum("""DIST""")|5|
||INTR|Int32||XmlEnum("""INTR""")|6|
||TRAG|Int32||XmlEnum("""TRAG""")|7|
||REGI|Int32||XmlEnum("""REGI""")|8|
||FMCO|Int32||XmlEnum("""FMCO""")|9|

---

## Value ISO20022.Semt017001.LetterOfGuarantee4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Enum ISO20022.Semt017001.MarketClientSide1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MAKT|Int32||XmlEnum("""MAKT""")|1|
||CLNT|Int32||XmlEnum("""CLNT""")|2|

---

## Value ISO20022.Semt017001.MarketClientSide6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017001.MarketIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Semt017001.MarketIdentification5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Semt017001.MarketIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt017001.MarketType8Choice||XmlElement()||
|+|Id|ISO20022.Semt017001.MarketIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Semt017001.MarketIdentification98


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt017001.MarketType19Choice||XmlElement()||
|+|Id|ISO20022.Semt017001.MarketIdentification5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Semt017001.MarketType19Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017001.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Value ISO20022.Semt017001.MarketType8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017001.MarketType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SCAS|Int32||XmlEnum("""SCAS""")|1|
||VEND|Int32||XmlEnum("""VEND""")|2|
||THEO|Int32||XmlEnum("""THEO""")|3|
||LMAR|Int32||XmlEnum("""LMAR""")|4|
||FUND|Int32||XmlEnum("""FUND""")|5|

---

## Value ISO20022.Semt017001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Semt017001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Semt017001.NettingEligibility4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Semt017001.Number3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|String||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lng""",Lng,"""[0-9]{5}"""),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Value ISO20022.Semt017001.OpeningBalance5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OpngBal|ISO20022.Semt017001.OpeningBalance6Choice||XmlElement()||
|+|ShrtLngInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OpngBal))|

---

## Value ISO20022.Semt017001.OpeningBalance6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Intrmy|ISO20022.Semt017001.BalanceQuantity14Choice||XmlElement()||
|+|Frst|ISO20022.Semt017001.BalanceQuantity14Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Intrmy),validElement(Frst),validChoice(Intrmy,Frst))|

---

## Value ISO20022.Semt017001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt017001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt017001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Semt017001.OwnershipLegalRestrictions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSTR|Int32||XmlEnum("""RSTR""")|1|
||NRST|Int32||XmlEnum("""NRST""")|2|
||A144|Int32||XmlEnum("""A144""")|3|

---

## Value ISO20022.Semt017001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Semt017001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Semt017001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Semt017001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Semt017001.PartyIdentification125Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Semt017001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Semt017001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Semt017001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Semt017001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Semt017001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt017001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt017001.PartyIdentification139


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Semt017001.PartyIdentification125Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Semt017001.PartyIdentification144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt017001.PartyIdentification127Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt017001.PartyIdentification257Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Semt017001.NameAndAddress5||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(DgtlLdgrId,Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Semt017001.PartyIdentification314


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt017001.PartyIdentification257Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt017001.PartyIdentificationAndAccount195


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt017001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt017001.SecuritiesAccount19||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt017001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt017001.Period2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt017001.Period7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrDtToDt|ISO20022.Semt017001.Period2||XmlElement()||
|+|FrDtTmToDtTm|ISO20022.Semt017001.DateTimePeriod1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrDtToDt),validElement(FrDtTmToDtTm),validChoice(FrDtToDt,FrDtTmToDtTm))|

---

## Value ISO20022.Semt017001.PlaceOfClearingIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt017001.PlaceOfTradeIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|MktTpAndId|ISO20022.Semt017001.MarketIdentification84||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(MktTpAndId))|

---

## Value ISO20022.Semt017001.PostalAddress1


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

## Value ISO20022.Semt017001.PriceInformation30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtnDt|ISO20022.Semt017001.DateAndDateTime2Choice||XmlElement()||
|+|SrcOfPric|ISO20022.Semt017001.MarketIdentification98||XmlElement()||
|+|Val|ISO20022.Semt017001.PriceRateOrAmountOrUnknown2Choice||XmlElement()||
|+|ValTp|ISO20022.Semt017001.YieldedOrValueType1Choice||XmlElement()||
|+|Tp|ISO20022.Semt017001.TypeOfPrice48Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtnDt),validElement(SrcOfPric),validElement(Val),validElement(ValTp),validElement(Tp))|

---

## Value ISO20022.Semt017001.PriceRateOrAmountOrUnknown2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UknwnInd|String||XmlElement()||
|+|Amt|ISO20022.Semt017001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(UknwnInd,Amt,Rate))|

---

## Enum ISO20022.Semt017001.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Semt017001.PurposeCode7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017001.Quantity51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Semt017001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Semt017001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Enum ISO20022.Semt017001.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Enum ISO20022.Semt017001.Registration1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YREG|Int32||XmlEnum("""YREG""")|1|
||NREG|Int32||XmlEnum("""NREG""")|2|

---

## Value ISO20022.Semt017001.Registration9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017001.RepurchaseType22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017001.RepurchaseType9Code


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

## Value ISO20022.Semt017001.Restriction5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017001.Role6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Txt,Prtry,Cd))|

---

## Value ISO20022.Semt017001.SafeKeepingPlace5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Semt017001.SafekeepingPlaceFormat41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Semt017001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Semt017001.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Semt017001.SafekeepingPlaceFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Semt017001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Semt017001.SafekeepingPlaceTypeAndText8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Semt017001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt017001.SafekeepingPlaceTypeAndText8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt017001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt017001.SecuritiesAccount25


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt017001.PurposeCode7Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt017001.SecuritiesAccount36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dsgnt|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Semt017001.SecuritiesAccountPurposeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHYS|Int32||XmlEnum("""PHYS""")|1|
||DVPA|Int32||XmlEnum("""DVPA""")|2|
||CEND|Int32||XmlEnum("""CEND""")|3|
||ABRD|Int32||XmlEnum("""ABRD""")|4|
||SHOR|Int32||XmlEnum("""SHOR""")|5|
||MARG|Int32||XmlEnum("""MARG""")|6|

---

## Value ISO20022.Semt017001.SecuritiesRTGS4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Aspect ISO20022.Semt017001.SecuritiesTransactionPostingReportV13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubAcctDtls|global::System.Collections.Generic.List<ISO20022.Semt017001.SubAccountIdentification73>||XmlElement()||
|+|FinInstrmDtls|global::System.Collections.Generic.List<ISO20022.Semt017001.FinancialInstrumentDetails46>||XmlElement()||
|+|IntrmyInf|global::System.Collections.Generic.List<ISO20022.Semt017001.Intermediary44>||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt017001.BlockChainAddressWallet4||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt017001.SecuritiesAccount36||XmlElement()||
|+|AcctOwnr|ISO20022.Semt017001.PartyIdentification144||XmlElement()||
|+|StmtGnlDtls|ISO20022.Semt017001.Statement79||XmlElement()||
|+|Pgntn|ISO20022.Semt017001.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SubAcctDtls""",SubAcctDtls),validElement(SubAcctDtls),validList("""FinInstrmDtls""",FinInstrmDtls),validElement(FinInstrmDtls),validList("""IntrmyInf""",IntrmyInf),validListMax("""IntrmyInf""",IntrmyInf,10),validElement(IntrmyInf),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(StmtGnlDtls),validElement(Pgntn))|

---

## Enum ISO20022.Semt017001.SecuritiesTransactionType27Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TOUT|Int32||XmlEnum("""TOUT""")|1|
||TRIN|Int32||XmlEnum("""TRIN""")|2|
||REBL|Int32||XmlEnum("""REBL""")|3|
||ETFT|Int32||XmlEnum("""ETFT""")|4|
||SWIT|Int32||XmlEnum("""SWIT""")|5|
||SWIF|Int32||XmlEnum("""SWIF""")|6|
||AUTO|Int32||XmlEnum("""AUTO""")|7|
||CORP|Int32||XmlEnum("""CORP""")|8|
||CLAI|Int32||XmlEnum("""CLAI""")|9|
||TURN|Int32||XmlEnum("""TURN""")|10|
||TRVO|Int32||XmlEnum("""TRVO""")|11|
||TRPO|Int32||XmlEnum("""TRPO""")|12|
||TRAD|Int32||XmlEnum("""TRAD""")|13|
||TBAC|Int32||XmlEnum("""TBAC""")|14|
||SYND|Int32||XmlEnum("""SYND""")|15|
||SUBS|Int32||XmlEnum("""SUBS""")|16|
||SLRE|Int32||XmlEnum("""SLRE""")|17|
||SECL|Int32||XmlEnum("""SECL""")|18|
||SECB|Int32||XmlEnum("""SECB""")|19|
||SBRE|Int32||XmlEnum("""SBRE""")|20|
||SBBK|Int32||XmlEnum("""SBBK""")|21|
||RVPO|Int32||XmlEnum("""RVPO""")|22|
||RODE|Int32||XmlEnum("""RODE""")|23|
||REPU|Int32||XmlEnum("""REPU""")|24|
||RELE|Int32||XmlEnum("""RELE""")|25|
||REDM|Int32||XmlEnum("""REDM""")|26|
||REDI|Int32||XmlEnum("""REDI""")|27|
||REAL|Int32||XmlEnum("""REAL""")|28|
||PORT|Int32||XmlEnum("""PORT""")|29|
||PLAC|Int32||XmlEnum("""PLAC""")|30|
||PAIR|Int32||XmlEnum("""PAIR""")|31|
||OWNI|Int32||XmlEnum("""OWNI""")|32|
||OWNE|Int32||XmlEnum("""OWNE""")|33|
||NSYN|Int32||XmlEnum("""NSYN""")|34|
||NETT|Int32||XmlEnum("""NETT""")|35|
||MKUP|Int32||XmlEnum("""MKUP""")|36|
||MKDW|Int32||XmlEnum("""MKDW""")|37|
||ISSU|Int32||XmlEnum("""ISSU""")|38|
||INSP|Int32||XmlEnum("""INSP""")|39|
||FCTA|Int32||XmlEnum("""FCTA""")|40|
||CONV|Int32||XmlEnum("""CONV""")|41|
||COLO|Int32||XmlEnum("""COLO""")|42|
||COLI|Int32||XmlEnum("""COLI""")|43|
||CNCB|Int32||XmlEnum("""CNCB""")|44|
||BYIY|Int32||XmlEnum("""BYIY""")|45|
||BSBK|Int32||XmlEnum("""BSBK""")|46|

---

## Value ISO20022.Semt017001.SecuritiesTransactionType48Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017001.SecurityClassificationType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Semt017001.GenericIdentification3||XmlElement()||
|+|CFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""CFI""",CFI,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,CFI))|

---

## Value ISO20022.Semt017001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Semt017001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Semt017001.SettlementDate17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Semt017001.SettlementDateCode7Choice||XmlElement()||
|+|Dt|ISO20022.Semt017001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Semt017001.SettlementDate4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WISS|Int32||XmlEnum("""WISS""")|1|

---

## Value ISO20022.Semt017001.SettlementDateCode7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017001.SettlementDetails190


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtlSttlmInd|String||XmlElement()||
|+|LttrOfGrnt|ISO20022.Semt017001.LetterOfGuarantee4Choice||XmlElement()||
|+|CCPElgblty|ISO20022.Semt017001.CentralCounterPartyEligibility4Choice||XmlElement()||
|+|NetgElgblty|ISO20022.Semt017001.NettingEligibility4Choice||XmlElement()||
|+|SttlmSysMtd|ISO20022.Semt017001.SettlementSystemMethod4Choice||XmlElement()||
|+|LglRstrctns|ISO20022.Semt017001.Restriction5Choice||XmlElement()||
|+|BlckTrad|ISO20022.Semt017001.BlockTrade4Choice||XmlElement()||
|+|MktClntSd|ISO20022.Semt017001.MarketClientSide6Choice||XmlElement()||
|+|RpTp|ISO20022.Semt017001.RepurchaseType22Choice||XmlElement()||
|+|TaxCpcty|ISO20022.Semt017001.TaxCapacityParty4Choice||XmlElement()||
|+|CshClrSys|ISO20022.Semt017001.CashSettlementSystem4Choice||XmlElement()||
|+|BnfclOwnrsh|ISO20022.Semt017001.BeneficialOwnership4Choice||XmlElement()||
|+|Regn|ISO20022.Semt017001.Registration9Choice||XmlElement()||
|+|SctiesRTGS|ISO20022.Semt017001.SecuritiesRTGS4Choice||XmlElement()||
|+|StmpDtyTaxBsis|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|SttlgCpcty|ISO20022.Semt017001.SettlingCapacity7Choice||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Semt017001.SettlementTransactionCondition34Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LttrOfGrnt),validElement(CCPElgblty),validElement(NetgElgblty),validElement(SttlmSysMtd),validElement(LglRstrctns),validElement(BlckTrad),validElement(MktClntSd),validElement(RpTp),validElement(TaxCpcty),validElement(CshClrSys),validElement(BnfclOwnrsh),validElement(Regn),validElement(SctiesRTGS),validElement(StmpDtyTaxBsis),validElement(SttlgCpcty),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond))|

---

## Value ISO20022.Semt017001.SettlementOrCorporateActionEvent35Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnEvtTp|ISO20022.Semt017001.CorporateActionEventType110Choice||XmlElement()||
|+|SctiesTxTp|ISO20022.Semt017001.SecuritiesTransactionType48Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnEvtTp),validElement(SctiesTxTp),validChoice(CorpActnEvtTp,SctiesTxTp))|

---

## Value ISO20022.Semt017001.SettlementParties125


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Semt017001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty4|ISO20022.Semt017001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty3|ISO20022.Semt017001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty2|ISO20022.Semt017001.PartyIdentificationAndAccount195||XmlElement()||
|+|Pty1|ISO20022.Semt017001.PartyIdentificationAndAccount195||XmlElement()||
|+|Dpstry|ISO20022.Semt017001.PartyIdentification314||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Semt017001.SettlementSystemMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSET|Int32||XmlEnum("""YSET""")|1|
||NSET|Int32||XmlEnum("""NSET""")|2|

---

## Value ISO20022.Semt017001.SettlementSystemMethod4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017001.SettlementTransactionCondition12Code


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

## Value ISO20022.Semt017001.SettlementTransactionCondition34Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017001.SettlementTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARQ|Int32||XmlEnum("""PARQ""")|1|
||PARC|Int32||XmlEnum("""PARC""")|2|
||NPAR|Int32||XmlEnum("""NPAR""")|3|
||PART|Int32||XmlEnum("""PART""")|4|

---

## Enum ISO20022.Semt017001.SettlingCapacity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RISP|Int32||XmlEnum("""RISP""")|1|
||SPRI|Int32||XmlEnum("""SPRI""")|2|
||CUST|Int32||XmlEnum("""CUST""")|3|
||SAGE|Int32||XmlEnum("""SAGE""")|4|

---

## Value ISO20022.Semt017001.SettlingCapacity7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017001.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Semt017001.SimpleIdentificationInformation4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt017001.Statement79


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubAcctInd|String||XmlElement()||
|+|ActvtyInd|String||XmlElement()||
|+|StmtBsis|ISO20022.Semt017001.StatementBasis8Choice||XmlElement()||
|+|UpdTp|ISO20022.Semt017001.UpdateType15Choice||XmlElement()||
|+|Frqcy|ISO20022.Semt017001.Frequency25Choice||XmlElement()||
|+|StmtPrd|ISO20022.Semt017001.Period7Choice||XmlElement()||
|+|StmtId|String||XmlElement()||
|+|QryRef|String||XmlElement()||
|+|RptNb|ISO20022.Semt017001.Number3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmtBsis),validElement(UpdTp),validElement(Frqcy),validElement(StmtPrd),validElement(RptNb))|

---

## Enum ISO20022.Semt017001.StatementBasis2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAD|Int32||XmlEnum("""TRAD""")|1|
||SETT|Int32||XmlEnum("""SETT""")|2|

---

## Value ISO20022.Semt017001.StatementBasis8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017001.StatementUpdateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Semt017001.SubAccountIdentification73


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmDtls|global::System.Collections.Generic.List<ISO20022.Semt017001.FinancialInstrumentDetails46>||XmlElement()||
|+|ActvtyInd|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt017001.BlockChainAddressWallet2||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt017001.SecuritiesAccount25||XmlElement()||
|+|AcctOwnr|ISO20022.Semt017001.PartyIdentification144||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""FinInstrmDtls""",FinInstrmDtls),validElement(FinInstrmDtls),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr))|

---

## Value ISO20022.Semt017001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Semt017001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Semt017001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt017001.TaxCapacityParty4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017001.TaxLiability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGEN|Int32||XmlEnum("""AGEN""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Semt017001.TradeDate8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Semt017001.TradeDateCode3Choice||XmlElement()||
|+|Dt|ISO20022.Semt017001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Semt017001.TradeDateCode3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017001.Transaction161


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt017001.SupplementaryData1>||XmlElement()||
|+|TxDtls|ISO20022.Semt017001.TransactionDetails169||XmlElement()||
|+|AcctSvcrLegId|String||XmlElement()||
|+|AcctOwnrLegId|String||XmlElement()||
|+|ClntRef|ISO20022.Semt017001.AdditionalReference10||XmlElement()||
|+|MstrRef|String||XmlElement()||
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
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TxDtls),validElement(ClntRef),validPattern("""UnqTxIdr""",UnqTxIdr,"""[A-Z0-9]{18}[0-9]{2}[A-Z0-9]{0,32}"""))|

---

## Enum ISO20022.Semt017001.TransactionActivity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SETT|Int32||XmlEnum("""SETT""")|1|
||CORP|Int32||XmlEnum("""CORP""")|2|
||COLL|Int32||XmlEnum("""COLL""")|3|
||CLAI|Int32||XmlEnum("""CLAI""")|4|
||BOLE|Int32||XmlEnum("""BOLE""")|5|

---

## Value ISO20022.Semt017001.TransactionActivity3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017001.TransactionDetails169


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxAddtlDtls|String||XmlElement()||
|+|RvslInd|String||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Semt017001.SettlementParties125||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Semt017001.SettlementParties125||XmlElement()||
|+|MtchdStsTmStmp|DateTime||XmlElement()||
|+|AckdStsTmStmp|DateTime||XmlElement()||
|+|ValDt|ISO20022.Semt017001.DateAndDateTime2Choice||XmlElement()||
|+|SttlmDt|ISO20022.Semt017001.SettlementDate17Choice||XmlElement()||
|+|FctvSttlmDt|ISO20022.Semt017001.DateAndDateTime2Choice||XmlElement()||
|+|TradDt|ISO20022.Semt017001.TradeDate8Choice||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Semt017001.AmountAndDirection21||XmlElement()||
|+|PstngAmt|ISO20022.Semt017001.AmountAndDirection3||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|PstngQty|ISO20022.Semt017001.Quantity51Choice||XmlElement()||
|+|PlcOfClr|ISO20022.Semt017001.PlaceOfClearingIdentification2||XmlElement()||
|+|SfkpgPlc|ISO20022.Semt017001.SafeKeepingPlace5||XmlElement()||
|+|PlcOfTrad|ISO20022.Semt017001.PlaceOfTradeIdentification1||XmlElement()||
|+|SttlmParams|ISO20022.Semt017001.SettlementDetails190||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
|+|SttlmTxOrCorpActnEvtTp|ISO20022.Semt017001.SettlementOrCorporateActionEvent35Choice||XmlElement()||
|+|TxActvty|ISO20022.Semt017001.TransactionActivity3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(ValDt),validElement(SttlmDt),validElement(FctvSttlmDt),validElement(TradDt),validElement(AcrdIntrstAmt),validElement(PstngAmt),validElement(PstngQty),validElement(PlcOfClr),validElement(SfkpgPlc),validElement(PlcOfTrad),validElement(SttlmParams),validElement(SttlmTxOrCorpActnEvtTp),validElement(TxActvty))|

---

## Enum ISO20022.Semt017001.TypeOfPrice17Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACTU|Int32||XmlEnum("""ACTU""")|1|
||DDVR|Int32||XmlEnum("""DDVR""")|2|
||INDC|Int32||XmlEnum("""INDC""")|3|
||MRKT|Int32||XmlEnum("""MRKT""")|4|
||SWIC|Int32||XmlEnum("""SWIC""")|5|
||RINV|Int32||XmlEnum("""RINV""")|6|
||MIDD|Int32||XmlEnum("""MIDD""")|7|
||SWNG|Int32||XmlEnum("""SWNG""")|8|
||INTE|Int32||XmlEnum("""INTE""")|9|
||CANC|Int32||XmlEnum("""CANC""")|10|
||CREA|Int32||XmlEnum("""CREA""")|11|
||NAVL|Int32||XmlEnum("""NAVL""")|12|
||OFFR|Int32||XmlEnum("""OFFR""")|13|
||BIDE|Int32||XmlEnum("""BIDE""")|14|

---

## Value ISO20022.Semt017001.TypeOfPrice48Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017001.UpdateType15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017001.YieldedOrValueType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValTp|String||XmlElement()||
|+|Yldd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(ValTp,Yldd))|

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

