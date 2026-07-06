# semt.017.002.12
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt017002.Account30 {
        + AcctSvcr  : ISO20022.Semt017002.PartyIdentification137Choice
        + Id  : ISO20022.Semt017002.AccountIdentification4
    }
    ISO20022.Semt017002.Account30 *-- ISO20022.Semt017002.PartyIdentification137Choice
    ISO20022.Semt017002.Account30 *-- ISO20022.Semt017002.AccountIdentification4
    class ISO20022.Semt017002.AccountIdentification4 {
        + Prtry  : ISO20022.Semt017002.SimpleIdentificationInformation1
    }
    ISO20022.Semt017002.AccountIdentification4 *-- ISO20022.Semt017002.SimpleIdentificationInformation1
    class ISO20022.Semt017002.AdditionalReference12 {
        + MsgNm  : String
        + RefIssr  : ISO20022.Semt017002.PartyIdentification192
        + Ref  : String
    }
    ISO20022.Semt017002.AdditionalReference12 *-- ISO20022.Semt017002.PartyIdentification192
    class ISO20022.Semt017002.AmountAndDirection18 {
        + CdtDbt  : String
        + Amt  : ISO20022.Semt017002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Semt017002.AmountAndDirection18 *-- ISO20022.Semt017002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    class ISO20022.Semt017002.AmountAndDirection59 {
        + CdtDbtInd  : String
        + Amt  : ISO20022.Semt017002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Semt017002.AmountAndDirection59 *-- ISO20022.Semt017002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    class ISO20022.Semt017002.BalanceQuantity17Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification144
        + Qty  : ISO20022.Semt017002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Semt017002.BalanceQuantity17Choice *-- ISO20022.Semt017002.GenericIdentification144
    ISO20022.Semt017002.BalanceQuantity17Choice *-- ISO20022.Semt017002.FinancialInstrumentQuantity36Choice
    class ISO20022.Semt017002.BeneficialOwnership5Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Semt017002.BeneficialOwnership5Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Semt017002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Semt017002.BlockChainAddressWallet7 *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.BlockChainAddressWallet8 {
        + Dsgnt  : String
        + Nm  : String
        + Tp  : ISO20022.Semt017002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Semt017002.BlockChainAddressWallet8 *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.BlockChainAddressWallet9 {
        + Nm  : String
        + Tp  : ISO20022.Semt017002.PurposeCode8Choice
        + Id  : String
    }
    ISO20022.Semt017002.BlockChainAddressWallet9 *-- ISO20022.Semt017002.PurposeCode8Choice
    class ISO20022.Semt017002.BlockTrade1Code {
        BLCH = 1
        BLPA = 2
    }
    class ISO20022.Semt017002.BlockTrade5Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.BlockTrade5Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.CashSettlementSystem2Code {
        NETS = 1
        GROS = 2
    }
    class ISO20022.Semt017002.CashSettlementSystem5Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.CashSettlementSystem5Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.CentralCounterPartyEligibility5Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Semt017002.CentralCounterPartyEligibility5Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.ClosingBalance6 {
        + ClsgBal  : ISO20022.Semt017002.ClosingBalance7Choice
        + ShrtLngInd  : String
    }
    ISO20022.Semt017002.ClosingBalance6 *-- ISO20022.Semt017002.ClosingBalance7Choice
    class ISO20022.Semt017002.ClosingBalance7Choice {
        + Intrmy  : ISO20022.Semt017002.BalanceQuantity17Choice
        + Fnl  : ISO20022.Semt017002.BalanceQuantity17Choice
    }
    ISO20022.Semt017002.ClosingBalance7Choice *-- ISO20022.Semt017002.BalanceQuantity17Choice
    ISO20022.Semt017002.ClosingBalance7Choice *-- ISO20022.Semt017002.BalanceQuantity17Choice
    class ISO20022.Semt017002.CorporateActionEventType101Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.CorporateActionEventType101Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.CorporateActionEventType33Code {
        TNDP = 1
        INFO = 2
        MTNG = 3
        ACCU = 4
        WRTH = 5
        WTRC = 6
        EXWA = 7
        SUSP = 8
        DLST = 9
        TEND = 10
        TREC = 11
        SPLF = 12
        DVSE = 13
        SOFF = 14
        SMAL = 15
        SHPR = 16
        DVSC = 17
        RHTS = 18
        SPLR = 19
        BIDS = 20
        REMK = 21
        REDO = 22
        BPUT = 23
        PRIO = 24
        PDEF = 25
        PLAC = 26
        PINK = 27
        PRED = 28
        PCAL = 29
        PARI = 30
        OTHR = 31
        ODLT = 32
        CERT = 33
        NOOF = 34
        MRGR = 35
        EXTM = 36
        LIQU = 37
        RHDI = 38
        INTR = 39
        PPMT = 40
        INCR = 41
        MCAL = 42
        REDM = 43
        EXOF = 44
        DTCH = 45
        DRAW = 46
        DRIP = 47
        DVOP = 48
        DSCL = 49
        DETI = 50
        DECR = 51
        CREV = 52
        CONV = 53
        CONS = 54
        CLSA = 55
        COOP = 56
        CHAN = 57
        DVCA = 58
        DRCA = 59
        CAPI = 60
        CAPG = 61
        CAPD = 62
        EXRI = 63
        BONU = 64
        DFLT = 65
        BRUP = 66
        ATTI = 67
        ACTV = 68
    }
    class ISO20022.Semt017002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Semt017002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Semt017002.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Semt017002.DateType3Code {
        VARI = 1
    }
    class ISO20022.Semt017002.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Semt017002.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class ISO20022.Semt017002.EventFrequency4Code {
        WEEK = 1
        INDA = 2
        DAIL = 3
        MNTH = 4
        ADHO = 5
        YEAR = 6
    }
    class ISO20022.Semt017002.FinancialInstrument76 {
        + ClssfctnTp  : ISO20022.Semt017002.SecurityClassificationType3Choice
        + DstrbtnPlcy  : String
        + ClssTp  : String
        + SctiesForm  : String
        + SplmtryId  : String
    }
    ISO20022.Semt017002.FinancialInstrument76 *-- ISO20022.Semt017002.SecurityClassificationType3Choice
    class ISO20022.Semt017002.FinancialInstrumentDetails43 {
        + Tx  : global::System.Collections.Generic.List~ISO20022.Semt017002.Transaction126~
        + ClsgBal  : ISO20022.Semt017002.ClosingBalance6
        + OpngBal  : ISO20022.Semt017002.OpeningBalance6
        + SfkpgPlc  : ISO20022.Semt017002.SafeKeepingPlace4
        + PricDtls  : ISO20022.Semt017002.PriceInformation24
        + InvstmtFndsFinInstrmAttrbts  : ISO20022.Semt017002.FinancialInstrument76
        + FinInstrmId  : ISO20022.Semt017002.SecurityIdentification20
    }
    ISO20022.Semt017002.FinancialInstrumentDetails43 *-- ISO20022.Semt017002.Transaction126
    ISO20022.Semt017002.FinancialInstrumentDetails43 *-- ISO20022.Semt017002.ClosingBalance6
    ISO20022.Semt017002.FinancialInstrumentDetails43 *-- ISO20022.Semt017002.OpeningBalance6
    ISO20022.Semt017002.FinancialInstrumentDetails43 *-- ISO20022.Semt017002.SafeKeepingPlace4
    ISO20022.Semt017002.FinancialInstrumentDetails43 *-- ISO20022.Semt017002.PriceInformation24
    ISO20022.Semt017002.FinancialInstrumentDetails43 *-- ISO20022.Semt017002.FinancialInstrument76
    ISO20022.Semt017002.FinancialInstrumentDetails43 *-- ISO20022.Semt017002.SecurityIdentification20
    class ISO20022.Semt017002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Semt017002.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Semt017002.Frequency26Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.Frequency26Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.GenericIdentification144 {
        + Bal  : Decimal
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt017002.GenericIdentification18 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Semt017002.GenericIdentification39 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt017002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt017002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt017002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Semt017002.GenericIdentification47
    }
    ISO20022.Semt017002.GenericIdentification85 *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt017002.Intermediary45 {
        + Acct  : ISO20022.Semt017002.Account30
        + Role  : ISO20022.Semt017002.Role7Choice
        + Id  : ISO20022.Semt017002.PartyIdentification157
    }
    ISO20022.Semt017002.Intermediary45 *-- ISO20022.Semt017002.Account30
    ISO20022.Semt017002.Intermediary45 *-- ISO20022.Semt017002.Role7Choice
    ISO20022.Semt017002.Intermediary45 *-- ISO20022.Semt017002.PartyIdentification157
    class ISO20022.Semt017002.InvestmentFundRole2Code {
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
    class ISO20022.Semt017002.LetterOfGuarantee5Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Semt017002.LetterOfGuarantee5Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.MarketClientSide1Code {
        MAKT = 1
        CLNT = 2
    }
    class ISO20022.Semt017002.MarketClientSide7Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.MarketClientSide7Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.MarketIdentification2Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Semt017002.MarketIdentification90 {
        + Tp  : ISO20022.Semt017002.MarketType16Choice
        + Id  : ISO20022.Semt017002.MarketIdentification2Choice
    }
    ISO20022.Semt017002.MarketIdentification90 *-- ISO20022.Semt017002.MarketType16Choice
    ISO20022.Semt017002.MarketIdentification90 *-- ISO20022.Semt017002.MarketIdentification2Choice
    class ISO20022.Semt017002.MarketIdentification91 {
        + Tp  : ISO20022.Semt017002.MarketType17Choice
        + Id  : ISO20022.Semt017002.MarketIdentification2Choice
    }
    ISO20022.Semt017002.MarketIdentification91 *-- ISO20022.Semt017002.MarketType17Choice
    ISO20022.Semt017002.MarketIdentification91 *-- ISO20022.Semt017002.MarketIdentification2Choice
    class ISO20022.Semt017002.MarketType16Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.MarketType16Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.MarketType17Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.MarketType17Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Semt017002.MarketType4Code {
        VEND = 1
        THEO = 2
        LMAR = 3
        FUND = 4
    }
    class ISO20022.Semt017002.NameAndAddress11 {
        + Adr  : ISO20022.Semt017002.PostalAddress7
        + Nm  : String
    }
    ISO20022.Semt017002.NameAndAddress11 *-- ISO20022.Semt017002.PostalAddress7
    class ISO20022.Semt017002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Semt017002.NettingEligibility5Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Semt017002.NettingEligibility5Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.Number3Choice {
        + Lng  : String
        + Shrt  : String
    }
    class ISO20022.Semt017002.OpeningBalance6 {
        + OpngBal  : ISO20022.Semt017002.OpeningBalance7Choice
        + ShrtLngInd  : String
    }
    ISO20022.Semt017002.OpeningBalance6 *-- ISO20022.Semt017002.OpeningBalance7Choice
    class ISO20022.Semt017002.OpeningBalance7Choice {
        + Intrmy  : ISO20022.Semt017002.BalanceQuantity17Choice
        + Frst  : ISO20022.Semt017002.BalanceQuantity17Choice
    }
    ISO20022.Semt017002.OpeningBalance7Choice *-- ISO20022.Semt017002.BalanceQuantity17Choice
    ISO20022.Semt017002.OpeningBalance7Choice *-- ISO20022.Semt017002.BalanceQuantity17Choice
    class ISO20022.Semt017002.OriginalAndCurrentQuantities4 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Semt017002.OtherIdentification2 {
        + Tp  : ISO20022.Semt017002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Semt017002.OtherIdentification2 *-- ISO20022.Semt017002.IdentificationSource4Choice
    class ISO20022.Semt017002.OwnershipLegalRestrictions1Code {
        RSTR = 1
        NRST = 2
        A144 = 3
    }
    class ISO20022.Semt017002.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Semt017002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Semt017002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Semt017002.PartyIdentification136Choice *-- ISO20022.Semt017002.GenericIdentification84
    class ISO20022.Semt017002.PartyIdentification137Choice {
        + NmAndAdr  : ISO20022.Semt017002.NameAndAddress12
        + PrtryId  : ISO20022.Semt017002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Semt017002.PartyIdentification137Choice *-- ISO20022.Semt017002.NameAndAddress12
    ISO20022.Semt017002.PartyIdentification137Choice *-- ISO20022.Semt017002.GenericIdentification84
    class ISO20022.Semt017002.PartyIdentification145Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Semt017002.NameAndAddress12
        + AnyBIC  : String
    }
    ISO20022.Semt017002.PartyIdentification145Choice *-- ISO20022.Semt017002.NameAndAddress12
    class ISO20022.Semt017002.PartyIdentification152Choice {
        + NmAndAdr  : ISO20022.Semt017002.NameAndAddress11
        + PrtryId  : ISO20022.Semt017002.GenericIdentification18
        + AnyBIC  : String
    }
    ISO20022.Semt017002.PartyIdentification152Choice *-- ISO20022.Semt017002.NameAndAddress11
    ISO20022.Semt017002.PartyIdentification152Choice *-- ISO20022.Semt017002.GenericIdentification18
    class ISO20022.Semt017002.PartyIdentification156 {
        + LEI  : String
        + Id  : ISO20022.Semt017002.PartyIdentification136Choice
    }
    ISO20022.Semt017002.PartyIdentification156 *-- ISO20022.Semt017002.PartyIdentification136Choice
    class ISO20022.Semt017002.PartyIdentification157 {
        + LEI  : String
        + Id  : ISO20022.Semt017002.PartyIdentification137Choice
    }
    ISO20022.Semt017002.PartyIdentification157 *-- ISO20022.Semt017002.PartyIdentification137Choice
    class ISO20022.Semt017002.PartyIdentification191 {
        + PrcgId  : String
        + LEI  : String
        + Id  : ISO20022.Semt017002.PartyIdentification145Choice
    }
    ISO20022.Semt017002.PartyIdentification191 *-- ISO20022.Semt017002.PartyIdentification145Choice
    class ISO20022.Semt017002.PartyIdentification192 {
        + LEI  : String
        + Pty  : ISO20022.Semt017002.PartyIdentification152Choice
    }
    ISO20022.Semt017002.PartyIdentification192 *-- ISO20022.Semt017002.PartyIdentification152Choice
    class ISO20022.Semt017002.PartyIdentificationAndAccount215 {
        + PrcgId  : String
        + BlckChainAdrOrWllt  : ISO20022.Semt017002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Semt017002.SecuritiesAccount30
        + LEI  : String
        + Id  : ISO20022.Semt017002.PartyIdentification137Choice
    }
    ISO20022.Semt017002.PartyIdentificationAndAccount215 *-- ISO20022.Semt017002.BlockChainAddressWallet7
    ISO20022.Semt017002.PartyIdentificationAndAccount215 *-- ISO20022.Semt017002.SecuritiesAccount30
    ISO20022.Semt017002.PartyIdentificationAndAccount215 *-- ISO20022.Semt017002.PartyIdentification137Choice
    class ISO20022.Semt017002.Period2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Semt017002.Period7Choice {
        + FrDtToDt  : ISO20022.Semt017002.Period2
        + FrDtTmToDtTm  : ISO20022.Semt017002.DateTimePeriod1
    }
    ISO20022.Semt017002.Period7Choice *-- ISO20022.Semt017002.Period2
    ISO20022.Semt017002.Period7Choice *-- ISO20022.Semt017002.DateTimePeriod1
    class ISO20022.Semt017002.PlaceOfClearingIdentification2 {
        + LEI  : String
        + Id  : String
    }
    class ISO20022.Semt017002.PlaceOfTradeIdentification2 {
        + LEI  : String
        + MktTpAndId  : ISO20022.Semt017002.MarketIdentification90
    }
    ISO20022.Semt017002.PlaceOfTradeIdentification2 *-- ISO20022.Semt017002.MarketIdentification90
    class ISO20022.Semt017002.PostalAddress7 {
        + Ctry  : String
        + TwnNm  : String
        + PstCd  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Semt017002.PriceInformation24 {
        + QtnDt  : ISO20022.Semt017002.DateAndDateTime2Choice
        + SrcOfPric  : ISO20022.Semt017002.MarketIdentification91
        + Val  : ISO20022.Semt017002.PriceRateOrAmountOrUnknown3Choice
        + ValTp  : ISO20022.Semt017002.YieldedOrValueType1Choice
        + Tp  : ISO20022.Semt017002.TypeOfPrice49Choice
    }
    ISO20022.Semt017002.PriceInformation24 *-- ISO20022.Semt017002.DateAndDateTime2Choice
    ISO20022.Semt017002.PriceInformation24 *-- ISO20022.Semt017002.MarketIdentification91
    ISO20022.Semt017002.PriceInformation24 *-- ISO20022.Semt017002.PriceRateOrAmountOrUnknown3Choice
    ISO20022.Semt017002.PriceInformation24 *-- ISO20022.Semt017002.YieldedOrValueType1Choice
    ISO20022.Semt017002.PriceInformation24 *-- ISO20022.Semt017002.TypeOfPrice49Choice
    class ISO20022.Semt017002.PriceRateOrAmountOrUnknown3Choice {
        + UknwnInd  : String
        + Amt  : ISO20022.Semt017002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Semt017002.PriceRateOrAmountOrUnknown3Choice *-- ISO20022.Semt017002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Semt017002.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Semt017002.PurposeCode8Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.PurposeCode8Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.Quantity54Choice {
        + OrgnlAndCurFace  : ISO20022.Semt017002.OriginalAndCurrentQuantities4
        + Qty  : ISO20022.Semt017002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Semt017002.Quantity54Choice *-- ISO20022.Semt017002.OriginalAndCurrentQuantities4
    ISO20022.Semt017002.Quantity54Choice *-- ISO20022.Semt017002.FinancialInstrumentQuantity36Choice
    class ISO20022.Semt017002.ReceiveDelivery1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Semt017002.Registration11Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.Registration11Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.Registration1Code {
        YREG = 1
        NREG = 2
    }
    class ISO20022.Semt017002.RepurchaseType24Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.RepurchaseType24Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.RepurchaseType9Code {
        WTHD = 1
        TOPU = 2
        CADJ = 3
        ROLP = 4
        CALL = 5
        RATE = 6
        PADJ = 7
        PAIR = 8
    }
    class ISO20022.Semt017002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt017002.RestrictedFINActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt017002.Restriction6Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.Restriction6Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.Role7Choice {
        + Txt  : String
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.Role7Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.SafeKeepingPlace4 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Semt017002.SafekeepingPlaceFormat39Choice
    }
    ISO20022.Semt017002.SafeKeepingPlace4 *-- ISO20022.Semt017002.SafekeepingPlaceFormat39Choice
    class ISO20022.Semt017002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Semt017002.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Semt017002.SafekeepingPlaceFormat39Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification85
        + TpAndId  : ISO20022.Semt017002.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Semt017002.SafekeepingPlaceTypeAndText15
    }
    ISO20022.Semt017002.SafekeepingPlaceFormat39Choice *-- ISO20022.Semt017002.GenericIdentification85
    ISO20022.Semt017002.SafekeepingPlaceFormat39Choice *-- ISO20022.Semt017002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Semt017002.SafekeepingPlaceFormat39Choice *-- ISO20022.Semt017002.SafekeepingPlaceTypeAndText15
    class ISO20022.Semt017002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt017002.SafekeepingPlaceTypeAndText15 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt017002.SecuritiesAccount30 {
        + Nm  : String
        + Tp  : ISO20022.Semt017002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Semt017002.SecuritiesAccount30 *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.SecuritiesAccount34 {
        + Nm  : String
        + Tp  : ISO20022.Semt017002.PurposeCode8Choice
        + Id  : String
    }
    ISO20022.Semt017002.SecuritiesAccount34 *-- ISO20022.Semt017002.PurposeCode8Choice
    class ISO20022.Semt017002.SecuritiesAccount40 {
        + Dsgnt  : String
        + Nm  : String
        + Tp  : ISO20022.Semt017002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Semt017002.SecuritiesAccount40 *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.SecuritiesAccountPurposeType1Code {
        PHYS = 1
        DVPA = 2
        CEND = 3
        ABRD = 4
        SHOR = 5
        MARG = 6
    }
    class ISO20022.Semt017002.SecuritiesRTGS5Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Ind  : String
    }
    ISO20022.Semt017002.SecuritiesRTGS5Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.SecuritiesTransactionPostingReport002V12 {
        + SubAcctDtls  : global::System.Collections.Generic.List~ISO20022.Semt017002.SubAccountIdentification70~
        + FinInstrmDtls  : global::System.Collections.Generic.List~ISO20022.Semt017002.FinancialInstrumentDetails43~
        + IntrmyInf  : global::System.Collections.Generic.List~ISO20022.Semt017002.Intermediary45~
        + BlckChainAdrOrWllt  : ISO20022.Semt017002.BlockChainAddressWallet8
        + SfkpgAcct  : ISO20022.Semt017002.SecuritiesAccount40
        + AcctOwnr  : ISO20022.Semt017002.PartyIdentification156
        + StmtGnlDtls  : ISO20022.Semt017002.Statement82
        + Pgntn  : ISO20022.Semt017002.Pagination1
    }
    ISO20022.Semt017002.SecuritiesTransactionPostingReport002V12 *-- ISO20022.Semt017002.SubAccountIdentification70
    ISO20022.Semt017002.SecuritiesTransactionPostingReport002V12 *-- ISO20022.Semt017002.FinancialInstrumentDetails43
    ISO20022.Semt017002.SecuritiesTransactionPostingReport002V12 *-- ISO20022.Semt017002.Intermediary45
    ISO20022.Semt017002.SecuritiesTransactionPostingReport002V12 *-- ISO20022.Semt017002.BlockChainAddressWallet8
    ISO20022.Semt017002.SecuritiesTransactionPostingReport002V12 *-- ISO20022.Semt017002.SecuritiesAccount40
    ISO20022.Semt017002.SecuritiesTransactionPostingReport002V12 *-- ISO20022.Semt017002.PartyIdentification156
    ISO20022.Semt017002.SecuritiesTransactionPostingReport002V12 *-- ISO20022.Semt017002.Statement82
    ISO20022.Semt017002.SecuritiesTransactionPostingReport002V12 *-- ISO20022.Semt017002.Pagination1
    class ISO20022.Semt017002.SecuritiesTransactionType27Code {
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
    class ISO20022.Semt017002.SecuritiesTransactionType58Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.SecuritiesTransactionType58Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.SecurityClassificationType3Choice {
        + AltrnClssfctn  : ISO20022.Semt017002.GenericIdentification39
        + CFI  : String
    }
    ISO20022.Semt017002.SecurityClassificationType3Choice *-- ISO20022.Semt017002.GenericIdentification39
    class ISO20022.Semt017002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Semt017002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Semt017002.SecurityIdentification20 *-- ISO20022.Semt017002.OtherIdentification2
    class ISO20022.Semt017002.SettlementDate20Choice {
        + DtCd  : ISO20022.Semt017002.SettlementDateCode9Choice
        + Dt  : ISO20022.Semt017002.DateAndDateTime2Choice
    }
    ISO20022.Semt017002.SettlementDate20Choice *-- ISO20022.Semt017002.SettlementDateCode9Choice
    ISO20022.Semt017002.SettlementDate20Choice *-- ISO20022.Semt017002.DateAndDateTime2Choice
    class ISO20022.Semt017002.SettlementDate4Code {
        WISS = 1
    }
    class ISO20022.Semt017002.SettlementDateCode9Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.SettlementDateCode9Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.SettlementDetails198 {
        + PrtlSttlmInd  : String
        + LttrOfGrnt  : ISO20022.Semt017002.LetterOfGuarantee5Choice
        + CCPElgblty  : ISO20022.Semt017002.CentralCounterPartyEligibility5Choice
        + NetgElgblty  : ISO20022.Semt017002.NettingEligibility5Choice
        + SttlmSysMtd  : ISO20022.Semt017002.SettlementSystemMethod5Choice
        + LglRstrctns  : ISO20022.Semt017002.Restriction6Choice
        + BlckTrad  : ISO20022.Semt017002.BlockTrade5Choice
        + MktClntSd  : ISO20022.Semt017002.MarketClientSide7Choice
        + RpTp  : ISO20022.Semt017002.RepurchaseType24Choice
        + TaxCpcty  : ISO20022.Semt017002.TaxCapacityParty5Choice
        + CshClrSys  : ISO20022.Semt017002.CashSettlementSystem5Choice
        + BnfclOwnrsh  : ISO20022.Semt017002.BeneficialOwnership5Choice
        + Regn  : ISO20022.Semt017002.Registration11Choice
        + SctiesRTGS  : ISO20022.Semt017002.SecuritiesRTGS5Choice
        + StmpDtyTaxBsis  : ISO20022.Semt017002.GenericIdentification47
        + SttlgCpcty  : ISO20022.Semt017002.SettlingCapacity8Choice
        + SttlmTxCond  : global::System.Collections.Generic.List~ISO20022.Semt017002.SettlementTransactionCondition37Choice~
    }
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.LetterOfGuarantee5Choice
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.CentralCounterPartyEligibility5Choice
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.NettingEligibility5Choice
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.SettlementSystemMethod5Choice
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.Restriction6Choice
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.BlockTrade5Choice
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.MarketClientSide7Choice
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.RepurchaseType24Choice
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.TaxCapacityParty5Choice
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.CashSettlementSystem5Choice
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.BeneficialOwnership5Choice
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.Registration11Choice
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.SecuritiesRTGS5Choice
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.GenericIdentification47
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.SettlingCapacity8Choice
    ISO20022.Semt017002.SettlementDetails198 *-- ISO20022.Semt017002.SettlementTransactionCondition37Choice
    class ISO20022.Semt017002.SettlementOrCorporateActionEvent33Choice {
        + CorpActnEvtTp  : ISO20022.Semt017002.CorporateActionEventType101Choice
        + SctiesTxTp  : ISO20022.Semt017002.SecuritiesTransactionType58Choice
    }
    ISO20022.Semt017002.SettlementOrCorporateActionEvent33Choice *-- ISO20022.Semt017002.CorporateActionEventType101Choice
    ISO20022.Semt017002.SettlementOrCorporateActionEvent33Choice *-- ISO20022.Semt017002.SecuritiesTransactionType58Choice
    class ISO20022.Semt017002.SettlementParties109 {
        + Pty5  : ISO20022.Semt017002.PartyIdentificationAndAccount215
        + Pty4  : ISO20022.Semt017002.PartyIdentificationAndAccount215
        + Pty3  : ISO20022.Semt017002.PartyIdentificationAndAccount215
        + Pty2  : ISO20022.Semt017002.PartyIdentificationAndAccount215
        + Pty1  : ISO20022.Semt017002.PartyIdentificationAndAccount215
        + Dpstry  : ISO20022.Semt017002.PartyIdentification191
    }
    ISO20022.Semt017002.SettlementParties109 *-- ISO20022.Semt017002.PartyIdentificationAndAccount215
    ISO20022.Semt017002.SettlementParties109 *-- ISO20022.Semt017002.PartyIdentificationAndAccount215
    ISO20022.Semt017002.SettlementParties109 *-- ISO20022.Semt017002.PartyIdentificationAndAccount215
    ISO20022.Semt017002.SettlementParties109 *-- ISO20022.Semt017002.PartyIdentificationAndAccount215
    ISO20022.Semt017002.SettlementParties109 *-- ISO20022.Semt017002.PartyIdentificationAndAccount215
    ISO20022.Semt017002.SettlementParties109 *-- ISO20022.Semt017002.PartyIdentification191
    class ISO20022.Semt017002.SettlementSystemMethod1Code {
        YSET = 1
        NSET = 2
    }
    class ISO20022.Semt017002.SettlementSystemMethod5Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.SettlementSystemMethod5Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.SettlementTransactionCondition12Code {
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
    class ISO20022.Semt017002.SettlementTransactionCondition37Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.SettlementTransactionCondition37Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.SettlementTransactionCondition5Code {
        PARQ = 1
        PARC = 2
        NPAR = 3
        PART = 4
    }
    class ISO20022.Semt017002.SettlingCapacity2Code {
        RISP = 1
        SPRI = 2
        CUST = 3
        SAGE = 4
    }
    class ISO20022.Semt017002.SettlingCapacity8Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.SettlingCapacity8Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Semt017002.SimpleIdentificationInformation1 {
        + Id  : String
    }
    class ISO20022.Semt017002.Statement82 {
        + SubAcctInd  : String
        + ActvtyInd  : String
        + StmtBsis  : ISO20022.Semt017002.StatementBasis12Choice
        + UpdTp  : ISO20022.Semt017002.UpdateType16Choice
        + Frqcy  : ISO20022.Semt017002.Frequency26Choice
        + StmtPrd  : ISO20022.Semt017002.Period7Choice
        + StmtId  : String
        + QryRef  : String
        + RptNb  : ISO20022.Semt017002.Number3Choice
    }
    ISO20022.Semt017002.Statement82 *-- ISO20022.Semt017002.StatementBasis12Choice
    ISO20022.Semt017002.Statement82 *-- ISO20022.Semt017002.UpdateType16Choice
    ISO20022.Semt017002.Statement82 *-- ISO20022.Semt017002.Frequency26Choice
    ISO20022.Semt017002.Statement82 *-- ISO20022.Semt017002.Period7Choice
    ISO20022.Semt017002.Statement82 *-- ISO20022.Semt017002.Number3Choice
    class ISO20022.Semt017002.StatementBasis12Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.StatementBasis12Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.StatementBasis2Code {
        TRAD = 1
        SETT = 2
    }
    class ISO20022.Semt017002.StatementUpdateType1Code {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Semt017002.SubAccountIdentification70 {
        + FinInstrmDtls  : global::System.Collections.Generic.List~ISO20022.Semt017002.FinancialInstrumentDetails43~
        + ActvtyInd  : String
        + BlckChainAdrOrWllt  : ISO20022.Semt017002.BlockChainAddressWallet9
        + SfkpgAcct  : ISO20022.Semt017002.SecuritiesAccount34
        + AcctOwnr  : ISO20022.Semt017002.PartyIdentification156
    }
    ISO20022.Semt017002.SubAccountIdentification70 *-- ISO20022.Semt017002.FinancialInstrumentDetails43
    ISO20022.Semt017002.SubAccountIdentification70 *-- ISO20022.Semt017002.BlockChainAddressWallet9
    ISO20022.Semt017002.SubAccountIdentification70 *-- ISO20022.Semt017002.SecuritiesAccount34
    ISO20022.Semt017002.SubAccountIdentification70 *-- ISO20022.Semt017002.PartyIdentification156
    class ISO20022.Semt017002.SupplementaryData1 {
        + Envlp  : ISO20022.Semt017002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Semt017002.SupplementaryData1 *-- ISO20022.Semt017002.SupplementaryDataEnvelope1
    class ISO20022.Semt017002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Semt017002.TaxCapacityParty5Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.TaxCapacityParty5Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.TaxLiability1Code {
        AGEN = 1
        PRIN = 2
    }
    class ISO20022.Semt017002.TradeDate9Choice {
        + DtCd  : ISO20022.Semt017002.TradeDateCode4Choice
        + Dt  : ISO20022.Semt017002.DateAndDateTime2Choice
    }
    ISO20022.Semt017002.TradeDate9Choice *-- ISO20022.Semt017002.TradeDateCode4Choice
    ISO20022.Semt017002.TradeDate9Choice *-- ISO20022.Semt017002.DateAndDateTime2Choice
    class ISO20022.Semt017002.TradeDateCode4Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.TradeDateCode4Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.Transaction126 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt017002.SupplementaryData1~
        + TxDtls  : ISO20022.Semt017002.TransactionDetails165
        + AcctSvcrLegId  : String
        + AcctOwnrLegId  : String
        + ClntRef  : ISO20022.Semt017002.AdditionalReference12
        + MstrRef  : String
        + TrptyAgtSvcPrvdrCollInstrId  : String
        + ClntCollInstrId  : String
        + ClntTrptyCollTxId  : String
        + TrptyAgtSvcPrvdrCollTxId  : String
        + CorpActnEvtId  : String
        + CmonId  : String
        + PoolId  : String
        + TradId  : global::System.Collections.Generic.List~String~
        + PrcrTxId  : String
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    ISO20022.Semt017002.Transaction126 *-- ISO20022.Semt017002.SupplementaryData1
    ISO20022.Semt017002.Transaction126 *-- ISO20022.Semt017002.TransactionDetails165
    ISO20022.Semt017002.Transaction126 *-- ISO20022.Semt017002.AdditionalReference12
    class ISO20022.Semt017002.TransactionActivity1Code {
        SETT = 1
        CORP = 2
        COLL = 3
        CLAI = 4
        BOLE = 5
    }
    class ISO20022.Semt017002.TransactionActivity4Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.TransactionActivity4Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.TransactionDetails165 {
        + TxAddtlDtls  : String
        + RvslInd  : String
        + RcvgSttlmPties  : ISO20022.Semt017002.SettlementParties109
        + DlvrgSttlmPties  : ISO20022.Semt017002.SettlementParties109
        + MtchdStsTmStmp  : DateTime
        + AckdStsTmStmp  : DateTime
        + ValDt  : ISO20022.Semt017002.DateAndDateTime2Choice
        + SttlmDt  : ISO20022.Semt017002.SettlementDate20Choice
        + FctvSttlmDt  : ISO20022.Semt017002.DateAndDateTime2Choice
        + TradDt  : ISO20022.Semt017002.TradeDate9Choice
        + AcrdIntrstAmt  : ISO20022.Semt017002.AmountAndDirection59
        + PstngAmt  : ISO20022.Semt017002.AmountAndDirection18
        + NbOfDaysAcrd  : Decimal
        + PstngQty  : ISO20022.Semt017002.Quantity54Choice
        + PlcOfClr  : ISO20022.Semt017002.PlaceOfClearingIdentification2
        + SfkpgPlc  : ISO20022.Semt017002.SafeKeepingPlace4
        + PlcOfTrad  : ISO20022.Semt017002.PlaceOfTradeIdentification2
        + SttlmParams  : ISO20022.Semt017002.SettlementDetails198
        + Pmt  : String
        + SctiesMvmntTp  : String
        + SttlmTxOrCorpActnEvtTp  : ISO20022.Semt017002.SettlementOrCorporateActionEvent33Choice
        + TxActvty  : ISO20022.Semt017002.TransactionActivity4Choice
    }
    ISO20022.Semt017002.TransactionDetails165 *-- ISO20022.Semt017002.SettlementParties109
    ISO20022.Semt017002.TransactionDetails165 *-- ISO20022.Semt017002.SettlementParties109
    ISO20022.Semt017002.TransactionDetails165 *-- ISO20022.Semt017002.DateAndDateTime2Choice
    ISO20022.Semt017002.TransactionDetails165 *-- ISO20022.Semt017002.SettlementDate20Choice
    ISO20022.Semt017002.TransactionDetails165 *-- ISO20022.Semt017002.DateAndDateTime2Choice
    ISO20022.Semt017002.TransactionDetails165 *-- ISO20022.Semt017002.TradeDate9Choice
    ISO20022.Semt017002.TransactionDetails165 *-- ISO20022.Semt017002.AmountAndDirection59
    ISO20022.Semt017002.TransactionDetails165 *-- ISO20022.Semt017002.AmountAndDirection18
    ISO20022.Semt017002.TransactionDetails165 *-- ISO20022.Semt017002.Quantity54Choice
    ISO20022.Semt017002.TransactionDetails165 *-- ISO20022.Semt017002.PlaceOfClearingIdentification2
    ISO20022.Semt017002.TransactionDetails165 *-- ISO20022.Semt017002.SafeKeepingPlace4
    ISO20022.Semt017002.TransactionDetails165 *-- ISO20022.Semt017002.PlaceOfTradeIdentification2
    ISO20022.Semt017002.TransactionDetails165 *-- ISO20022.Semt017002.SettlementDetails198
    ISO20022.Semt017002.TransactionDetails165 *-- ISO20022.Semt017002.SettlementOrCorporateActionEvent33Choice
    ISO20022.Semt017002.TransactionDetails165 *-- ISO20022.Semt017002.TransactionActivity4Choice
    class ISO20022.Semt017002.TypeOfPrice17Code {
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
    class ISO20022.Semt017002.TypeOfPrice49Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.TypeOfPrice49Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.UpdateType16Choice {
        + Prtry  : ISO20022.Semt017002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt017002.UpdateType16Choice *-- ISO20022.Semt017002.GenericIdentification47
    class ISO20022.Semt017002.YieldedOrValueType1Choice {
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

## Value ISO20022.Semt017002.Account30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctSvcr|ISO20022.Semt017002.PartyIdentification137Choice||XmlElement()||
|+|Id|ISO20022.Semt017002.AccountIdentification4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AcctSvcr),validElement(Id))|

---

## Value ISO20022.Semt017002.AccountIdentification4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.SimpleIdentificationInformation1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry))|

---

## Value ISO20022.Semt017002.AdditionalReference12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MsgNm|String||XmlElement()||
|+|RefIssr|ISO20022.Semt017002.PartyIdentification192||XmlElement()||
|+|Ref|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MsgNm""",MsgNm,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validElement(RefIssr),validPattern("""Ref""",Ref,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Semt017002.AmountAndDirection18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbt|String||XmlElement()||
|+|Amt|ISO20022.Semt017002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Semt017002.AmountAndDirection59


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Semt017002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Semt017002.BalanceQuantity17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification144||XmlElement()||
|+|Qty|ISO20022.Semt017002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Qty),validChoice(Prtry,Qty))|

---

## Value ISO20022.Semt017002.BeneficialOwnership5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Semt017002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Semt017002.BlockChainAddressWallet8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dsgnt|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Dsgnt""",Dsgnt,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Semt017002.BlockChainAddressWallet9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt017002.PurposeCode8Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Enum ISO20022.Semt017002.BlockTrade1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BLCH|Int32||XmlEnum("""BLCH""")|1|
||BLPA|Int32||XmlEnum("""BLPA""")|2|

---

## Value ISO20022.Semt017002.BlockTrade5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017002.CashSettlementSystem2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETS|Int32||XmlEnum("""NETS""")|1|
||GROS|Int32||XmlEnum("""GROS""")|2|

---

## Value ISO20022.Semt017002.CashSettlementSystem5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017002.CentralCounterPartyEligibility5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Semt017002.ClosingBalance6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClsgBal|ISO20022.Semt017002.ClosingBalance7Choice||XmlElement()||
|+|ShrtLngInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClsgBal))|

---

## Value ISO20022.Semt017002.ClosingBalance7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Intrmy|ISO20022.Semt017002.BalanceQuantity17Choice||XmlElement()||
|+|Fnl|ISO20022.Semt017002.BalanceQuantity17Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Intrmy),validElement(Fnl),validChoice(Intrmy,Fnl))|

---

## Value ISO20022.Semt017002.CorporateActionEventType101Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017002.CorporateActionEventType33Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TNDP|Int32||XmlEnum("""TNDP""")|1|
||INFO|Int32||XmlEnum("""INFO""")|2|
||MTNG|Int32||XmlEnum("""MTNG""")|3|
||ACCU|Int32||XmlEnum("""ACCU""")|4|
||WRTH|Int32||XmlEnum("""WRTH""")|5|
||WTRC|Int32||XmlEnum("""WTRC""")|6|
||EXWA|Int32||XmlEnum("""EXWA""")|7|
||SUSP|Int32||XmlEnum("""SUSP""")|8|
||DLST|Int32||XmlEnum("""DLST""")|9|
||TEND|Int32||XmlEnum("""TEND""")|10|
||TREC|Int32||XmlEnum("""TREC""")|11|
||SPLF|Int32||XmlEnum("""SPLF""")|12|
||DVSE|Int32||XmlEnum("""DVSE""")|13|
||SOFF|Int32||XmlEnum("""SOFF""")|14|
||SMAL|Int32||XmlEnum("""SMAL""")|15|
||SHPR|Int32||XmlEnum("""SHPR""")|16|
||DVSC|Int32||XmlEnum("""DVSC""")|17|
||RHTS|Int32||XmlEnum("""RHTS""")|18|
||SPLR|Int32||XmlEnum("""SPLR""")|19|
||BIDS|Int32||XmlEnum("""BIDS""")|20|
||REMK|Int32||XmlEnum("""REMK""")|21|
||REDO|Int32||XmlEnum("""REDO""")|22|
||BPUT|Int32||XmlEnum("""BPUT""")|23|
||PRIO|Int32||XmlEnum("""PRIO""")|24|
||PDEF|Int32||XmlEnum("""PDEF""")|25|
||PLAC|Int32||XmlEnum("""PLAC""")|26|
||PINK|Int32||XmlEnum("""PINK""")|27|
||PRED|Int32||XmlEnum("""PRED""")|28|
||PCAL|Int32||XmlEnum("""PCAL""")|29|
||PARI|Int32||XmlEnum("""PARI""")|30|
||OTHR|Int32||XmlEnum("""OTHR""")|31|
||ODLT|Int32||XmlEnum("""ODLT""")|32|
||CERT|Int32||XmlEnum("""CERT""")|33|
||NOOF|Int32||XmlEnum("""NOOF""")|34|
||MRGR|Int32||XmlEnum("""MRGR""")|35|
||EXTM|Int32||XmlEnum("""EXTM""")|36|
||LIQU|Int32||XmlEnum("""LIQU""")|37|
||RHDI|Int32||XmlEnum("""RHDI""")|38|
||INTR|Int32||XmlEnum("""INTR""")|39|
||PPMT|Int32||XmlEnum("""PPMT""")|40|
||INCR|Int32||XmlEnum("""INCR""")|41|
||MCAL|Int32||XmlEnum("""MCAL""")|42|
||REDM|Int32||XmlEnum("""REDM""")|43|
||EXOF|Int32||XmlEnum("""EXOF""")|44|
||DTCH|Int32||XmlEnum("""DTCH""")|45|
||DRAW|Int32||XmlEnum("""DRAW""")|46|
||DRIP|Int32||XmlEnum("""DRIP""")|47|
||DVOP|Int32||XmlEnum("""DVOP""")|48|
||DSCL|Int32||XmlEnum("""DSCL""")|49|
||DETI|Int32||XmlEnum("""DETI""")|50|
||DECR|Int32||XmlEnum("""DECR""")|51|
||CREV|Int32||XmlEnum("""CREV""")|52|
||CONV|Int32||XmlEnum("""CONV""")|53|
||CONS|Int32||XmlEnum("""CONS""")|54|
||CLSA|Int32||XmlEnum("""CLSA""")|55|
||COOP|Int32||XmlEnum("""COOP""")|56|
||CHAN|Int32||XmlEnum("""CHAN""")|57|
||DVCA|Int32||XmlEnum("""DVCA""")|58|
||DRCA|Int32||XmlEnum("""DRCA""")|59|
||CAPI|Int32||XmlEnum("""CAPI""")|60|
||CAPG|Int32||XmlEnum("""CAPG""")|61|
||CAPD|Int32||XmlEnum("""CAPD""")|62|
||EXRI|Int32||XmlEnum("""EXRI""")|63|
||BONU|Int32||XmlEnum("""BONU""")|64|
||DFLT|Int32||XmlEnum("""DFLT""")|65|
||BRUP|Int32||XmlEnum("""BRUP""")|66|
||ATTI|Int32||XmlEnum("""ATTI""")|67|
||ACTV|Int32||XmlEnum("""ACTV""")|68|

---

## Enum ISO20022.Semt017002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Semt017002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Semt017002.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Semt017002.DateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VARI|Int32||XmlEnum("""VARI""")|1|

---

## Enum ISO20022.Semt017002.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Enum ISO20022.Semt017002.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||DIST|Int32||XmlEnum("""DIST""")|2|

---

## Type ISO20022.Semt017002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesTxPstngRpt|ISO20022.Semt017002.SecuritiesTransactionPostingReport002V12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesTxPstngRpt))|

---

## Enum ISO20022.Semt017002.EventFrequency4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||INDA|Int32||XmlEnum("""INDA""")|2|
||DAIL|Int32||XmlEnum("""DAIL""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||ADHO|Int32||XmlEnum("""ADHO""")|5|
||YEAR|Int32||XmlEnum("""YEAR""")|6|

---

## Value ISO20022.Semt017002.FinancialInstrument76


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClssfctnTp|ISO20022.Semt017002.SecurityClassificationType3Choice||XmlElement()||
|+|DstrbtnPlcy|String||XmlElement()||
|+|ClssTp|String||XmlElement()||
|+|SctiesForm|String||XmlElement()||
|+|SplmtryId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ClssfctnTp),validPattern("""ClssTp""",ClssTp,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validPattern("""SplmtryId""",SplmtryId,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Semt017002.FinancialInstrumentDetails43


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tx|global::System.Collections.Generic.List<ISO20022.Semt017002.Transaction126>||XmlElement()||
|+|ClsgBal|ISO20022.Semt017002.ClosingBalance6||XmlElement()||
|+|OpngBal|ISO20022.Semt017002.OpeningBalance6||XmlElement()||
|+|SfkpgPlc|ISO20022.Semt017002.SafeKeepingPlace4||XmlElement()||
|+|PricDtls|ISO20022.Semt017002.PriceInformation24||XmlElement()||
|+|InvstmtFndsFinInstrmAttrbts|ISO20022.Semt017002.FinancialInstrument76||XmlElement()||
|+|FinInstrmId|ISO20022.Semt017002.SecurityIdentification20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Tx""",Tx),validList("""Tx""",Tx),validElement(Tx),validElement(ClsgBal),validElement(OpngBal),validElement(SfkpgPlc),validElement(PricDtls),validElement(InvstmtFndsFinInstrmAttrbts),validElement(FinInstrmId))|

---

## Value ISO20022.Semt017002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Enum ISO20022.Semt017002.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Semt017002.Frequency26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017002.GenericIdentification144


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|Decimal||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt017002.GenericIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt017002.GenericIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""([^/]+/)+([^/]+)\|([^/]*)"""),validPattern("""Id""",Id,"""([^/]+/)+([^/]+)\|([^/]*)"""))|

---

## Value ISO20022.Semt017002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt017002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt017002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Semt017002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017002.Intermediary45


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Acct|ISO20022.Semt017002.Account30||XmlElement()||
|+|Role|ISO20022.Semt017002.Role7Choice||XmlElement()||
|+|Id|ISO20022.Semt017002.PartyIdentification157||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Acct),validElement(Role),validElement(Id))|

---

## Enum ISO20022.Semt017002.InvestmentFundRole2Code


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

## Value ISO20022.Semt017002.LetterOfGuarantee5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Enum ISO20022.Semt017002.MarketClientSide1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||MAKT|Int32||XmlEnum("""MAKT""")|1|
||CLNT|Int32||XmlEnum("""CLNT""")|2|

---

## Value ISO20022.Semt017002.MarketClientSide7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017002.MarketIdentification2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Semt017002.MarketIdentification90


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt017002.MarketType16Choice||XmlElement()||
|+|Id|ISO20022.Semt017002.MarketIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Semt017002.MarketIdentification91


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt017002.MarketType17Choice||XmlElement()||
|+|Id|ISO20022.Semt017002.MarketIdentification2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Semt017002.MarketType16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017002.MarketType17Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017002.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Enum ISO20022.Semt017002.MarketType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VEND|Int32||XmlEnum("""VEND""")|1|
||THEO|Int32||XmlEnum("""THEO""")|2|
||LMAR|Int32||XmlEnum("""LMAR""")|3|
||FUND|Int32||XmlEnum("""FUND""")|4|

---

## Value ISO20022.Semt017002.NameAndAddress11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Semt017002.PostalAddress7||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr),validPattern("""Nm""",Nm,"""([^/]+/)+([^/]+)\|([^/]*)"""))|

---

## Value ISO20022.Semt017002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Semt017002.NettingEligibility5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Value ISO20022.Semt017002.Number3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|String||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lng""",Lng,"""[0-9]{5}"""),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Value ISO20022.Semt017002.OpeningBalance6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OpngBal|ISO20022.Semt017002.OpeningBalance7Choice||XmlElement()||
|+|ShrtLngInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OpngBal))|

---

## Value ISO20022.Semt017002.OpeningBalance7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Intrmy|ISO20022.Semt017002.BalanceQuantity17Choice||XmlElement()||
|+|Frst|ISO20022.Semt017002.BalanceQuantity17Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Intrmy),validElement(Frst),validChoice(Intrmy,Frst))|

---

## Value ISO20022.Semt017002.OriginalAndCurrentQuantities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt017002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt017002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Enum ISO20022.Semt017002.OwnershipLegalRestrictions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RSTR|Int32||XmlEnum("""RSTR""")|1|
||NRST|Int32||XmlEnum("""NRST""")|2|
||A144|Int32||XmlEnum("""A144""")|3|

---

## Value ISO20022.Semt017002.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Semt017002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Semt017002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Semt017002.PartyIdentification137Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Semt017002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Semt017002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Semt017002.PartyIdentification145Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Semt017002.NameAndAddress12||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,AnyBIC))|

---

## Value ISO20022.Semt017002.PartyIdentification152Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Semt017002.NameAndAddress11||XmlElement()||
|+|PrtryId|ISO20022.Semt017002.GenericIdentification18||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Semt017002.PartyIdentification156


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt017002.PartyIdentification136Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt017002.PartyIdentification157


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt017002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt017002.PartyIdentification191


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt017002.PartyIdentification145Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt017002.PartyIdentification192


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Pty|ISO20022.Semt017002.PartyIdentification152Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Pty))|

---

## Value ISO20022.Semt017002.PartyIdentificationAndAccount215


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcgId|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt017002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt017002.SecuritiesAccount30||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Semt017002.PartyIdentification137Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrcgId""",PrcgId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Semt017002.Period2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt017002.Period7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrDtToDt|ISO20022.Semt017002.Period2||XmlElement()||
|+|FrDtTmToDtTm|ISO20022.Semt017002.DateTimePeriod1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrDtToDt),validElement(FrDtTmToDtTm),validChoice(FrDtToDt,FrDtTmToDtTm))|

---

## Value ISO20022.Semt017002.PlaceOfClearingIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt017002.PlaceOfTradeIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|MktTpAndId|ISO20022.Semt017002.MarketIdentification90||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(MktTpAndId))|

---

## Value ISO20022.Semt017002.PostalAddress7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|TwnNm|String||XmlElement()||
|+|PstCd|String||XmlElement()||
|+|AdrLine|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validPattern("""TwnNm""",TwnNm,"""([^/]+/)+([^/]+)\|([^/]*)"""),validPattern("""PstCd""",PstCd,"""([^/]+/)+([^/]+)\|([^/]*)"""),validPattern("""AdrLine""",AdrLine,"""([^/]+/)+([^/]+)\|([^/]*)"""),validListMax("""AdrLine""",AdrLine,2))|

---

## Value ISO20022.Semt017002.PriceInformation24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtnDt|ISO20022.Semt017002.DateAndDateTime2Choice||XmlElement()||
|+|SrcOfPric|ISO20022.Semt017002.MarketIdentification91||XmlElement()||
|+|Val|ISO20022.Semt017002.PriceRateOrAmountOrUnknown3Choice||XmlElement()||
|+|ValTp|ISO20022.Semt017002.YieldedOrValueType1Choice||XmlElement()||
|+|Tp|ISO20022.Semt017002.TypeOfPrice49Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtnDt),validElement(SrcOfPric),validElement(Val),validElement(ValTp),validElement(Tp))|

---

## Value ISO20022.Semt017002.PriceRateOrAmountOrUnknown3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UknwnInd|String||XmlElement()||
|+|Amt|ISO20022.Semt017002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(UknwnInd,Amt,Rate))|

---

## Enum ISO20022.Semt017002.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Semt017002.PurposeCode8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017002.Quantity54Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Semt017002.OriginalAndCurrentQuantities4||XmlElement()||
|+|Qty|ISO20022.Semt017002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Enum ISO20022.Semt017002.ReceiveDelivery1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Semt017002.Registration11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017002.Registration1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YREG|Int32||XmlEnum("""YREG""")|1|
||NREG|Int32||XmlEnum("""NREG""")|2|

---

## Value ISO20022.Semt017002.RepurchaseType24Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017002.RepurchaseType9Code


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

## Value ISO20022.Semt017002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt017002.RestrictedFINActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt017002.Restriction6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017002.Role7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Txt|String||XmlElement()||
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Txt""",Txt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validElement(Prtry),validChoice(Txt,Prtry,Cd))|

---

## Value ISO20022.Semt017002.SafeKeepingPlace4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Semt017002.SafekeepingPlaceFormat39Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Semt017002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Semt017002.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Semt017002.SafekeepingPlaceFormat39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Semt017002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Semt017002.SafekeepingPlaceTypeAndText15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Semt017002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt017002.SafekeepingPlaceTypeAndText15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt017002.SecuritiesAccount30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Semt017002.SecuritiesAccount34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt017002.PurposeCode8Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Semt017002.SecuritiesAccount40


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Dsgnt|String||XmlElement()||
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Dsgnt""",Dsgnt,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Enum ISO20022.Semt017002.SecuritiesAccountPurposeType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PHYS|Int32||XmlEnum("""PHYS""")|1|
||DVPA|Int32||XmlEnum("""DVPA""")|2|
||CEND|Int32||XmlEnum("""CEND""")|3|
||ABRD|Int32||XmlEnum("""ABRD""")|4|
||SHOR|Int32||XmlEnum("""SHOR""")|5|
||MARG|Int32||XmlEnum("""MARG""")|6|

---

## Value ISO20022.Semt017002.SecuritiesRTGS5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Ind|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Ind))|

---

## Aspect ISO20022.Semt017002.SecuritiesTransactionPostingReport002V12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubAcctDtls|global::System.Collections.Generic.List<ISO20022.Semt017002.SubAccountIdentification70>||XmlElement()||
|+|FinInstrmDtls|global::System.Collections.Generic.List<ISO20022.Semt017002.FinancialInstrumentDetails43>||XmlElement()||
|+|IntrmyInf|global::System.Collections.Generic.List<ISO20022.Semt017002.Intermediary45>||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt017002.BlockChainAddressWallet8||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt017002.SecuritiesAccount40||XmlElement()||
|+|AcctOwnr|ISO20022.Semt017002.PartyIdentification156||XmlElement()||
|+|StmtGnlDtls|ISO20022.Semt017002.Statement82||XmlElement()||
|+|Pgntn|ISO20022.Semt017002.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SubAcctDtls""",SubAcctDtls),validElement(SubAcctDtls),validList("""FinInstrmDtls""",FinInstrmDtls),validElement(FinInstrmDtls),validList("""IntrmyInf""",IntrmyInf),validListMax("""IntrmyInf""",IntrmyInf,10),validElement(IntrmyInf),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(StmtGnlDtls),validElement(Pgntn))|

---

## Enum ISO20022.Semt017002.SecuritiesTransactionType27Code


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

## Value ISO20022.Semt017002.SecuritiesTransactionType58Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017002.SecurityClassificationType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Semt017002.GenericIdentification39||XmlElement()||
|+|CFI|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""CFI""",CFI,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,CFI))|

---

## Value ISO20022.Semt017002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Semt017002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Semt017002.SettlementDate20Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Semt017002.SettlementDateCode9Choice||XmlElement()||
|+|Dt|ISO20022.Semt017002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Enum ISO20022.Semt017002.SettlementDate4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WISS|Int32||XmlEnum("""WISS""")|1|

---

## Value ISO20022.Semt017002.SettlementDateCode9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017002.SettlementDetails198


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtlSttlmInd|String||XmlElement()||
|+|LttrOfGrnt|ISO20022.Semt017002.LetterOfGuarantee5Choice||XmlElement()||
|+|CCPElgblty|ISO20022.Semt017002.CentralCounterPartyEligibility5Choice||XmlElement()||
|+|NetgElgblty|ISO20022.Semt017002.NettingEligibility5Choice||XmlElement()||
|+|SttlmSysMtd|ISO20022.Semt017002.SettlementSystemMethod5Choice||XmlElement()||
|+|LglRstrctns|ISO20022.Semt017002.Restriction6Choice||XmlElement()||
|+|BlckTrad|ISO20022.Semt017002.BlockTrade5Choice||XmlElement()||
|+|MktClntSd|ISO20022.Semt017002.MarketClientSide7Choice||XmlElement()||
|+|RpTp|ISO20022.Semt017002.RepurchaseType24Choice||XmlElement()||
|+|TaxCpcty|ISO20022.Semt017002.TaxCapacityParty5Choice||XmlElement()||
|+|CshClrSys|ISO20022.Semt017002.CashSettlementSystem5Choice||XmlElement()||
|+|BnfclOwnrsh|ISO20022.Semt017002.BeneficialOwnership5Choice||XmlElement()||
|+|Regn|ISO20022.Semt017002.Registration11Choice||XmlElement()||
|+|SctiesRTGS|ISO20022.Semt017002.SecuritiesRTGS5Choice||XmlElement()||
|+|StmpDtyTaxBsis|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|SttlgCpcty|ISO20022.Semt017002.SettlingCapacity8Choice||XmlElement()||
|+|SttlmTxCond|global::System.Collections.Generic.List<ISO20022.Semt017002.SettlementTransactionCondition37Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LttrOfGrnt),validElement(CCPElgblty),validElement(NetgElgblty),validElement(SttlmSysMtd),validElement(LglRstrctns),validElement(BlckTrad),validElement(MktClntSd),validElement(RpTp),validElement(TaxCpcty),validElement(CshClrSys),validElement(BnfclOwnrsh),validElement(Regn),validElement(SctiesRTGS),validElement(StmpDtyTaxBsis),validElement(SttlgCpcty),validList("""SttlmTxCond""",SttlmTxCond),validElement(SttlmTxCond))|

---

## Value ISO20022.Semt017002.SettlementOrCorporateActionEvent33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnEvtTp|ISO20022.Semt017002.CorporateActionEventType101Choice||XmlElement()||
|+|SctiesTxTp|ISO20022.Semt017002.SecuritiesTransactionType58Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnEvtTp),validElement(SctiesTxTp),validChoice(CorpActnEvtTp,SctiesTxTp))|

---

## Value ISO20022.Semt017002.SettlementParties109


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Pty5|ISO20022.Semt017002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty4|ISO20022.Semt017002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty3|ISO20022.Semt017002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty2|ISO20022.Semt017002.PartyIdentificationAndAccount215||XmlElement()||
|+|Pty1|ISO20022.Semt017002.PartyIdentificationAndAccount215||XmlElement()||
|+|Dpstry|ISO20022.Semt017002.PartyIdentification191||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Pty5),validElement(Pty4),validElement(Pty3),validElement(Pty2),validElement(Pty1),validElement(Dpstry))|

---

## Enum ISO20022.Semt017002.SettlementSystemMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YSET|Int32||XmlEnum("""YSET""")|1|
||NSET|Int32||XmlEnum("""NSET""")|2|

---

## Value ISO20022.Semt017002.SettlementSystemMethod5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017002.SettlementTransactionCondition12Code


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

## Value ISO20022.Semt017002.SettlementTransactionCondition37Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017002.SettlementTransactionCondition5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARQ|Int32||XmlEnum("""PARQ""")|1|
||PARC|Int32||XmlEnum("""PARC""")|2|
||NPAR|Int32||XmlEnum("""NPAR""")|3|
||PART|Int32||XmlEnum("""PART""")|4|

---

## Enum ISO20022.Semt017002.SettlingCapacity2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RISP|Int32||XmlEnum("""RISP""")|1|
||SPRI|Int32||XmlEnum("""SPRI""")|2|
||CUST|Int32||XmlEnum("""CUST""")|3|
||SAGE|Int32||XmlEnum("""SAGE""")|4|

---

## Value ISO20022.Semt017002.SettlingCapacity8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017002.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Semt017002.SimpleIdentificationInformation1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Semt017002.Statement82


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubAcctInd|String||XmlElement()||
|+|ActvtyInd|String||XmlElement()||
|+|StmtBsis|ISO20022.Semt017002.StatementBasis12Choice||XmlElement()||
|+|UpdTp|ISO20022.Semt017002.UpdateType16Choice||XmlElement()||
|+|Frqcy|ISO20022.Semt017002.Frequency26Choice||XmlElement()||
|+|StmtPrd|ISO20022.Semt017002.Period7Choice||XmlElement()||
|+|StmtId|String||XmlElement()||
|+|QryRef|String||XmlElement()||
|+|RptNb|ISO20022.Semt017002.Number3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmtBsis),validElement(UpdTp),validElement(Frqcy),validElement(StmtPrd),validPattern("""StmtId""",StmtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""QryRef""",QryRef,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(RptNb))|

---

## Value ISO20022.Semt017002.StatementBasis12Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017002.StatementBasis2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TRAD|Int32||XmlEnum("""TRAD""")|1|
||SETT|Int32||XmlEnum("""SETT""")|2|

---

## Enum ISO20022.Semt017002.StatementUpdateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Semt017002.SubAccountIdentification70


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmDtls|global::System.Collections.Generic.List<ISO20022.Semt017002.FinancialInstrumentDetails43>||XmlElement()||
|+|ActvtyInd|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt017002.BlockChainAddressWallet9||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt017002.SecuritiesAccount34||XmlElement()||
|+|AcctOwnr|ISO20022.Semt017002.PartyIdentification156||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""FinInstrmDtls""",FinInstrmDtls),validElement(FinInstrmDtls),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr))|

---

## Value ISO20022.Semt017002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Semt017002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Semt017002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt017002.TaxCapacityParty5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt017002.TaxLiability1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||AGEN|Int32||XmlEnum("""AGEN""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Semt017002.TradeDate9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtCd|ISO20022.Semt017002.TradeDateCode4Choice||XmlElement()||
|+|Dt|ISO20022.Semt017002.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtCd),validElement(Dt),validChoice(DtCd,Dt))|

---

## Value ISO20022.Semt017002.TradeDateCode4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017002.Transaction126


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt017002.SupplementaryData1>||XmlElement()||
|+|TxDtls|ISO20022.Semt017002.TransactionDetails165||XmlElement()||
|+|AcctSvcrLegId|String||XmlElement()||
|+|AcctOwnrLegId|String||XmlElement()||
|+|ClntRef|ISO20022.Semt017002.AdditionalReference12||XmlElement()||
|+|MstrRef|String||XmlElement()||
|+|TrptyAgtSvcPrvdrCollInstrId|String||XmlElement()||
|+|ClntCollInstrId|String||XmlElement()||
|+|ClntTrptyCollTxId|String||XmlElement()||
|+|TrptyAgtSvcPrvdrCollTxId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
|+|CmonId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|TradId|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PrcrTxId|String||XmlElement()||
|+|CtrPtyMktInfrstrctrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(TxDtls),validPattern("""AcctSvcrLegId""",AcctSvcrLegId,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validPattern("""AcctOwnrLegId""",AcctOwnrLegId,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validElement(ClntRef),validPattern("""MstrRef""",MstrRef,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""),validPattern("""TrptyAgtSvcPrvdrCollInstrId""",TrptyAgtSvcPrvdrCollInstrId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""ClntCollInstrId""",ClntCollInstrId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""ClntTrptyCollTxId""",ClntTrptyCollTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""TrptyAgtSvcPrvdrCollTxId""",TrptyAgtSvcPrvdrCollTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CorpActnEvtId""",CorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CmonId""",CmonId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""PoolId""",PoolId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""TradId""",TradId,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,52}"""),validPattern("""PrcrTxId""",PrcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CtrPtyMktInfrstrctrTxId""",CtrPtyMktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktInfrstrctrTxId""",MktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrTxId""",AcctSvcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctOwnrTxId""",AcctOwnrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Enum ISO20022.Semt017002.TransactionActivity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SETT|Int32||XmlEnum("""SETT""")|1|
||CORP|Int32||XmlEnum("""CORP""")|2|
||COLL|Int32||XmlEnum("""COLL""")|3|
||CLAI|Int32||XmlEnum("""CLAI""")|4|
||BOLE|Int32||XmlEnum("""BOLE""")|5|

---

## Value ISO20022.Semt017002.TransactionActivity4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017002.TransactionDetails165


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxAddtlDtls|String||XmlElement()||
|+|RvslInd|String||XmlElement()||
|+|RcvgSttlmPties|ISO20022.Semt017002.SettlementParties109||XmlElement()||
|+|DlvrgSttlmPties|ISO20022.Semt017002.SettlementParties109||XmlElement()||
|+|MtchdStsTmStmp|DateTime||XmlElement()||
|+|AckdStsTmStmp|DateTime||XmlElement()||
|+|ValDt|ISO20022.Semt017002.DateAndDateTime2Choice||XmlElement()||
|+|SttlmDt|ISO20022.Semt017002.SettlementDate20Choice||XmlElement()||
|+|FctvSttlmDt|ISO20022.Semt017002.DateAndDateTime2Choice||XmlElement()||
|+|TradDt|ISO20022.Semt017002.TradeDate9Choice||XmlElement()||
|+|AcrdIntrstAmt|ISO20022.Semt017002.AmountAndDirection59||XmlElement()||
|+|PstngAmt|ISO20022.Semt017002.AmountAndDirection18||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|PstngQty|ISO20022.Semt017002.Quantity54Choice||XmlElement()||
|+|PlcOfClr|ISO20022.Semt017002.PlaceOfClearingIdentification2||XmlElement()||
|+|SfkpgPlc|ISO20022.Semt017002.SafeKeepingPlace4||XmlElement()||
|+|PlcOfTrad|ISO20022.Semt017002.PlaceOfTradeIdentification2||XmlElement()||
|+|SttlmParams|ISO20022.Semt017002.SettlementDetails198||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
|+|SttlmTxOrCorpActnEvtTp|ISO20022.Semt017002.SettlementOrCorporateActionEvent33Choice||XmlElement()||
|+|TxActvty|ISO20022.Semt017002.TransactionActivity4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TxAddtlDtls""",TxAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validElement(RcvgSttlmPties),validElement(DlvrgSttlmPties),validElement(ValDt),validElement(SttlmDt),validElement(FctvSttlmDt),validElement(TradDt),validElement(AcrdIntrstAmt),validElement(PstngAmt),validElement(PstngQty),validElement(PlcOfClr),validElement(SfkpgPlc),validElement(PlcOfTrad),validElement(SttlmParams),validElement(SttlmTxOrCorpActnEvtTp),validElement(TxActvty))|

---

## Enum ISO20022.Semt017002.TypeOfPrice17Code


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

## Value ISO20022.Semt017002.TypeOfPrice49Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017002.UpdateType16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt017002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt017002.YieldedOrValueType1Choice


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

