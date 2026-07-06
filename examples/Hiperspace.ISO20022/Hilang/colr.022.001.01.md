# colr.022.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Colr022001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Colr022001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Colr022001.AlternatePartyIdentification7 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Colr022001.IdentificationType42Choice
    }
    ISO20022.Colr022001.AlternatePartyIdentification7 *-- ISO20022.Colr022001.IdentificationType42Choice
    class ISO20022.Colr022001.AmountAndDirection53 {
        + Sgn  : String
        + Amt  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Colr022001.AmountAndDirection53 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Colr022001.BalanceQuantity13Choice {
        + Prtry  : ISO20022.Colr022001.GenericIdentification56
        + Qty  : ISO20022.Colr022001.Quantity51Choice
    }
    ISO20022.Colr022001.BalanceQuantity13Choice *-- ISO20022.Colr022001.GenericIdentification56
    ISO20022.Colr022001.BalanceQuantity13Choice *-- ISO20022.Colr022001.Quantity51Choice
    class ISO20022.Colr022001.BasketIdentificationAndEligibilitySetProfile1 {
        + ElgbltySetPrfl  : ISO20022.Colr022001.GenericIdentification1
        + ExclsnBsktId  : ISO20022.Colr022001.GenericIdentification1
        + FllbckStartgBsktId  : ISO20022.Colr022001.GenericIdentification1
        + PrfrntlBsktIdNb  : ISO20022.Colr022001.GenericIdentification1
    }
    ISO20022.Colr022001.BasketIdentificationAndEligibilitySetProfile1 *-- ISO20022.Colr022001.GenericIdentification1
    ISO20022.Colr022001.BasketIdentificationAndEligibilitySetProfile1 *-- ISO20022.Colr022001.GenericIdentification1
    ISO20022.Colr022001.BasketIdentificationAndEligibilitySetProfile1 *-- ISO20022.Colr022001.GenericIdentification1
    ISO20022.Colr022001.BasketIdentificationAndEligibilitySetProfile1 *-- ISO20022.Colr022001.GenericIdentification1
    class ISO20022.Colr022001.BenchmarkCurveName13Choice {
        + Prtry  : ISO20022.Colr022001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Colr022001.BenchmarkCurveName13Choice *-- ISO20022.Colr022001.GenericIdentification1
    class ISO20022.Colr022001.BenchmarkCurveName7Code {
        WIBO = 1
        TREA = 2
        TOAR = 3
        TIBO = 4
        TLBO = 5
        SWAP = 6
        STBO = 7
        SONA = 8
        SOFR = 9
        RCTR = 10
        PRBO = 11
        PFAN = 12
        OBFR = 13
        NIBO = 14
        BJUO = 15
        MAAA = 16
        MOSP = 17
        LIBO = 18
        LIBI = 19
        JIBA = 20
        ETIO = 21
        ISDA = 22
        HKIO = 23
        GCFR = 24
        FUSW = 25
        EFFR = 26
        EUCH = 27
        EUUS = 28
        EURI = 29
        ESTR = 30
        EONS = 31
        EONA = 32
        CZNA = 33
        CORA = 34
        CIBO = 35
        CDOR = 36
        BCOL = 37
        BUBO = 38
        BBSW = 39
    }
    class ISO20022.Colr022001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Colr022001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Colr022001.BlockChainAddressWallet3 *-- ISO20022.Colr022001.GenericIdentification30
    class ISO20022.Colr022001.CashAccountIdentification5Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Colr022001.CashBalance15 {
        + TxLotNb  : global::System.Collections.Generic.List~ISO20022.Colr022001.GenericIdentification178~
        + ValtnDtls  : ISO20022.Colr022001.ValuationsDetails2
        + CshAcct  : ISO20022.Colr022001.CashAccountIdentification5Choice
        + FXDtls  : ISO20022.Colr022001.ForeignExchangeTerms19
        + Amt  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Colr022001.CashBalance15 *-- ISO20022.Colr022001.GenericIdentification178
    ISO20022.Colr022001.CashBalance15 *-- ISO20022.Colr022001.ValuationsDetails2
    ISO20022.Colr022001.CashBalance15 *-- ISO20022.Colr022001.CashAccountIdentification5Choice
    ISO20022.Colr022001.CashBalance15 *-- ISO20022.Colr022001.ForeignExchangeTerms19
    ISO20022.Colr022001.CashBalance15 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Colr022001.ClosingDate4Choice {
        + Cd  : ISO20022.Colr022001.Date3Choice
        + Dt  : ISO20022.Colr022001.DateAndDateTime2Choice
    }
    ISO20022.Colr022001.ClosingDate4Choice *-- ISO20022.Colr022001.Date3Choice
    ISO20022.Colr022001.ClosingDate4Choice *-- ISO20022.Colr022001.DateAndDateTime2Choice
    class ISO20022.Colr022001.CollateralAmount15 {
        + TtlCshFaild  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlValOfReusdColl  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlValOfOwnColl  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlPdgCollOut  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlPdgCollIn  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlOfPrncpls  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlFeesComssns  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlAcrdIntrst  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlCollReqrd  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + Mrgn  : ISO20022.Colr022001.AmountAndDirection53
        + TtlXpsr  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + ValOfCollHeld  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Colr022001.CollateralAmount15 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount15 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount15 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount15 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount15 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount15 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount15 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount15 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount15 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount15 *-- ISO20022.Colr022001.AmountAndDirection53
    ISO20022.Colr022001.CollateralAmount15 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount15 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Colr022001.CollateralAmount16 {
        + TtlCshFaild  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlPdgCollOut  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlPdgCollIn  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlOfPrncpls  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlValOfReusdColl  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlValOfOwnColl  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlAcrdIntrst  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlCollReqrd  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + Mrgn  : ISO20022.Colr022001.AmountAndDirection53
        + TtlXpsr  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + ValOfCollHeld  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Colr022001.CollateralAmount16 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount16 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount16 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount16 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount16 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount16 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount16 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount16 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount16 *-- ISO20022.Colr022001.AmountAndDirection53
    ISO20022.Colr022001.CollateralAmount16 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount16 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Colr022001.CollateralAmount17 {
        + TtlCshFaild  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TermntnTxAmt  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlOfPrncpls  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlPdgCollOut  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlPdgCollIn  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlValOfReusdColl  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlValOfOwnColl  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlCollReqrd  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlAcrdIntrst  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + Mrgn  : ISO20022.Colr022001.AmountAndDirection53
        + TxAmtBrkdwn  : global::System.Collections.Generic.List~ISO20022.Colr022001.CollateralTransactionAmountBreakdown2~
        + TxAmt  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlXpsr  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + ValOfCollHeld  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Colr022001.CollateralAmount17 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount17 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount17 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount17 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount17 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount17 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount17 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount17 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount17 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount17 *-- ISO20022.Colr022001.AmountAndDirection53
    ISO20022.Colr022001.CollateralAmount17 *-- ISO20022.Colr022001.CollateralTransactionAmountBreakdown2
    ISO20022.Colr022001.CollateralAmount17 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount17 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount17 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Colr022001.CollateralAmount4 {
        + TtlValOfReusdColl  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlValOfOwnColl  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + MktValAmtBfrValtnFctr  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + MktValAmtPstValtnFctr  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + XpsrCollInRptgCcy  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + XpsrCollInTxCcy  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + ActlMktValBfrValtnFctr  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + ActlMktValPstValtnFctr  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Colr022001.CollateralAmount4 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount4 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount4 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount4 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount4 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount4 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount4 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount4 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Colr022001.CollateralAmount9 {
        + MktValAmtBfrHrcut  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + MktValAmtPstHrcut  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + XpsrCollInRptgCcy  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + XpsrCollInTxCcy  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + ActlMktValBfrHrcut  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + ActlMktValPstHrcut  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Colr022001.CollateralAmount9 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount9 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount9 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount9 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount9 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralAmount9 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Colr022001.CollateralParties11 {
        + BlckChainAdrOrWllt  : ISO20022.Colr022001.BlockChainAddressWallet3
        + CollAcct  : ISO20022.Colr022001.SecuritiesAccount19
        + TrptyAgt  : ISO20022.Colr022001.PartyIdentification136
        + ClntPtyB  : ISO20022.Colr022001.PartyIdentification232
        + PtyB  : ISO20022.Colr022001.PartyIdentification232
    }
    ISO20022.Colr022001.CollateralParties11 *-- ISO20022.Colr022001.BlockChainAddressWallet3
    ISO20022.Colr022001.CollateralParties11 *-- ISO20022.Colr022001.SecuritiesAccount19
    ISO20022.Colr022001.CollateralParties11 *-- ISO20022.Colr022001.PartyIdentification136
    ISO20022.Colr022001.CollateralParties11 *-- ISO20022.Colr022001.PartyIdentification232
    ISO20022.Colr022001.CollateralParties11 *-- ISO20022.Colr022001.PartyIdentification232
    class ISO20022.Colr022001.CollateralParties9 {
        + TrptyAgt  : ISO20022.Colr022001.PartyIdentification136
        + ClntPtyA  : ISO20022.Colr022001.PartyIdentificationAndAccount202
        + PtyA  : ISO20022.Colr022001.PartyIdentificationAndAccount202
    }
    ISO20022.Colr022001.CollateralParties9 *-- ISO20022.Colr022001.PartyIdentification136
    ISO20022.Colr022001.CollateralParties9 *-- ISO20022.Colr022001.PartyIdentificationAndAccount202
    ISO20022.Colr022001.CollateralParties9 *-- ISO20022.Colr022001.PartyIdentificationAndAccount202
    class ISO20022.Colr022001.CollateralRole1Code {
        TAKE = 1
        GIVE = 2
    }
    class ISO20022.Colr022001.CollateralStatus1Code {
        FLAT = 1
        DEFI = 2
        EXCS = 3
    }
    class ISO20022.Colr022001.CollateralStatus2Choice {
        + Prtry  : ISO20022.Colr022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr022001.CollateralStatus2Choice *-- ISO20022.Colr022001.GenericIdentification30
    class ISO20022.Colr022001.CollateralTransactionAmountBreakdown2 {
        + Prd  : ISO20022.Colr022001.Period4Choice
        + TxAmt  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + LotNb  : ISO20022.Colr022001.GenericIdentification178
    }
    ISO20022.Colr022001.CollateralTransactionAmountBreakdown2 *-- ISO20022.Colr022001.Period4Choice
    ISO20022.Colr022001.CollateralTransactionAmountBreakdown2 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.CollateralTransactionAmountBreakdown2 *-- ISO20022.Colr022001.GenericIdentification178
    class ISO20022.Colr022001.CounterpartyAggregation3 {
        + GblCtrPtySts  : String
        + MrgnRate  : Decimal
        + ValtnAmts  : global::System.Collections.Generic.List~ISO20022.Colr022001.CollateralAmount16~
        + CollPties  : ISO20022.Colr022001.CollateralParties11
        + BsktIdAndElgbltySetPrfl  : ISO20022.Colr022001.BasketIdentificationAndEligibilitySetProfile1
        + TermntnOptn  : String
        + OptnTp  : ISO20022.Colr022001.OptionType6Choice
    }
    ISO20022.Colr022001.CounterpartyAggregation3 *-- ISO20022.Colr022001.CollateralAmount16
    ISO20022.Colr022001.CounterpartyAggregation3 *-- ISO20022.Colr022001.CollateralParties11
    ISO20022.Colr022001.CounterpartyAggregation3 *-- ISO20022.Colr022001.BasketIdentificationAndEligibilitySetProfile1
    ISO20022.Colr022001.CounterpartyAggregation3 *-- ISO20022.Colr022001.OptionType6Choice
    class ISO20022.Colr022001.CrystallisationDay1 {
        + Prd  : String
        + Day  : String
    }
    class ISO20022.Colr022001.Date3Choice {
        + Prtry  : ISO20022.Colr022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr022001.Date3Choice *-- ISO20022.Colr022001.GenericIdentification30
    class ISO20022.Colr022001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Colr022001.DateType2Code {
        OPEN = 1
    }
    class ISO20022.Colr022001.EventFrequency7Code {
        ONDE = 1
        OVNG = 2
        TWMN = 3
        TOWK = 4
        TOMN = 5
        QUTR = 6
        SEMI = 7
        WEEK = 8
        INDA = 9
        DAIL = 10
        MNTH = 11
        ADHO = 12
        YEAR = 13
    }
    class ISO20022.Colr022001.ExecutionStatus1Code {
        PINT = 1
        INTD = 2
    }
    class ISO20022.Colr022001.ExposureType14Code {
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
    class ISO20022.Colr022001.ExposureType23Choice {
        + Prtry  : ISO20022.Colr022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr022001.ExposureType23Choice *-- ISO20022.Colr022001.GenericIdentification30
    class ISO20022.Colr022001.ExposureTypeAggregation3 {
        + GblXpsrTpSts  : String
        + MrgnRate  : Decimal
        + ValtnAmts  : global::System.Collections.Generic.List~ISO20022.Colr022001.CollateralAmount16~
        + SttlmPrc  : ISO20022.Colr022001.GenericIdentification30
        + XpsrTp  : ISO20022.Colr022001.ExposureType23Choice
    }
    ISO20022.Colr022001.ExposureTypeAggregation3 *-- ISO20022.Colr022001.CollateralAmount16
    ISO20022.Colr022001.ExposureTypeAggregation3 *-- ISO20022.Colr022001.GenericIdentification30
    ISO20022.Colr022001.ExposureTypeAggregation3 *-- ISO20022.Colr022001.ExposureType23Choice
    class ISO20022.Colr022001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Colr022001.ForeignExchangeTerms19 {
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    class ISO20022.Colr022001.Frequency22Choice {
        + Prtry  : ISO20022.Colr022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr022001.Frequency22Choice *-- ISO20022.Colr022001.GenericIdentification30
    class ISO20022.Colr022001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Colr022001.GenericIdentification178 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr022001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr022001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr022001.GenericIdentification56 {
        + Bal  : Decimal
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr022001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Colr022001.GenericIdentification30
    }
    ISO20022.Colr022001.GenericIdentification78 *-- ISO20022.Colr022001.GenericIdentification30
    class ISO20022.Colr022001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Colr022001.IdentificationType42Choice {
        + Prtry  : ISO20022.Colr022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr022001.IdentificationType42Choice *-- ISO20022.Colr022001.GenericIdentification30
    class ISO20022.Colr022001.InterestComputationMethod2Code {
        NARR = 1
        A014 = 2
        A013 = 3
        A012 = 4
        A011 = 5
        A010 = 6
        A009 = 7
        A008 = 8
        A007 = 9
        A006 = 10
        A005 = 11
        A004 = 12
        A003 = 13
        A002 = 14
        A001 = 15
    }
    class ISO20022.Colr022001.InterestComputationMethodFormat4Choice {
        + Prtry  : ISO20022.Colr022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr022001.InterestComputationMethodFormat4Choice *-- ISO20022.Colr022001.GenericIdentification30
    class ISO20022.Colr022001.InterestRateIndexTenor2Code {
        TOWK = 1
        WEEK = 2
        OVNG = 3
        SEMI = 4
        FOMN = 5
        QUTR = 6
        TOMN = 7
        YEAR = 8
        MNTH = 9
        INDA = 10
    }
    class ISO20022.Colr022001.MarketIdentification1Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Colr022001.MarketIdentification89 {
        + Tp  : ISO20022.Colr022001.MarketType15Choice
        + Id  : ISO20022.Colr022001.MarketIdentification1Choice
    }
    ISO20022.Colr022001.MarketIdentification89 *-- ISO20022.Colr022001.MarketType15Choice
    ISO20022.Colr022001.MarketIdentification89 *-- ISO20022.Colr022001.MarketIdentification1Choice
    class ISO20022.Colr022001.MarketType15Choice {
        + Prtry  : ISO20022.Colr022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr022001.MarketType15Choice *-- ISO20022.Colr022001.GenericIdentification30
    class ISO20022.Colr022001.MarketType4Code {
        VEND = 1
        THEO = 2
        LMAR = 3
        FUND = 4
    }
    class ISO20022.Colr022001.NameAndAddress5 {
        + Adr  : ISO20022.Colr022001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Colr022001.NameAndAddress5 *-- ISO20022.Colr022001.PostalAddress1
    class ISO20022.Colr022001.Number3Choice {
        + Lng  : String
        + Shrt  : String
    }
    class ISO20022.Colr022001.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Colr022001.OptionType6Choice {
        + Prtry  : ISO20022.Colr022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr022001.OptionType6Choice *-- ISO20022.Colr022001.GenericIdentification30
    class ISO20022.Colr022001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Colr022001.OtherIdentification1 {
        + Tp  : ISO20022.Colr022001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Colr022001.OtherIdentification1 *-- ISO20022.Colr022001.IdentificationSource3Choice
    class ISO20022.Colr022001.OverallCollateralDetails2 {
        + CollAddtlDtls  : String
        + ValtnDt  : ISO20022.Colr022001.DateAndDateTime2Choice
        + GblCollSts  : String
        + MrgnRate  : Decimal
        + ValtnAmts  : ISO20022.Colr022001.CollateralAmount15
    }
    ISO20022.Colr022001.OverallCollateralDetails2 *-- ISO20022.Colr022001.DateAndDateTime2Choice
    ISO20022.Colr022001.OverallCollateralDetails2 *-- ISO20022.Colr022001.CollateralAmount15
    class ISO20022.Colr022001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Colr022001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Colr022001.NameAndAddress5
        + PrtryId  : ISO20022.Colr022001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Colr022001.PartyIdentification120Choice *-- ISO20022.Colr022001.NameAndAddress5
    ISO20022.Colr022001.PartyIdentification120Choice *-- ISO20022.Colr022001.GenericIdentification36
    class ISO20022.Colr022001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Colr022001.PartyIdentification120Choice
    }
    ISO20022.Colr022001.PartyIdentification136 *-- ISO20022.Colr022001.PartyIdentification120Choice
    class ISO20022.Colr022001.PartyIdentification232 {
        + AltrnId  : ISO20022.Colr022001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Colr022001.PartyIdentification120Choice
    }
    ISO20022.Colr022001.PartyIdentification232 *-- ISO20022.Colr022001.AlternatePartyIdentification7
    ISO20022.Colr022001.PartyIdentification232 *-- ISO20022.Colr022001.PartyIdentification120Choice
    class ISO20022.Colr022001.PartyIdentificationAndAccount202 {
        + PtyCpcty  : ISO20022.Colr022001.TradingPartyCapacity5Choice
        + AcctOwnr  : ISO20022.Colr022001.PartyIdentification136
        + BlckChainAdrOrWllt  : ISO20022.Colr022001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Colr022001.SecuritiesAccount19
        + AltrnId  : ISO20022.Colr022001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Colr022001.PartyIdentification120Choice
    }
    ISO20022.Colr022001.PartyIdentificationAndAccount202 *-- ISO20022.Colr022001.TradingPartyCapacity5Choice
    ISO20022.Colr022001.PartyIdentificationAndAccount202 *-- ISO20022.Colr022001.PartyIdentification136
    ISO20022.Colr022001.PartyIdentificationAndAccount202 *-- ISO20022.Colr022001.BlockChainAddressWallet3
    ISO20022.Colr022001.PartyIdentificationAndAccount202 *-- ISO20022.Colr022001.SecuritiesAccount19
    ISO20022.Colr022001.PartyIdentificationAndAccount202 *-- ISO20022.Colr022001.AlternatePartyIdentification7
    ISO20022.Colr022001.PartyIdentificationAndAccount202 *-- ISO20022.Colr022001.PartyIdentification120Choice
    class ISO20022.Colr022001.Period2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Colr022001.Period4Choice {
        + FrDtToDt  : ISO20022.Colr022001.Period2
        + ToDt  : DateTime
        + FrDt  : DateTime
        + Dt  : DateTime
    }
    ISO20022.Colr022001.Period4Choice *-- ISO20022.Colr022001.Period2
    class ISO20022.Colr022001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Colr022001.Price7 {
        + Val  : ISO20022.Colr022001.PriceRateOrAmount3Choice
        + Tp  : ISO20022.Colr022001.YieldedOrValueType1Choice
    }
    ISO20022.Colr022001.Price7 *-- ISO20022.Colr022001.PriceRateOrAmount3Choice
    ISO20022.Colr022001.Price7 *-- ISO20022.Colr022001.YieldedOrValueType1Choice
    class ISO20022.Colr022001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Colr022001.PriceRateOrAmount3Choice *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Colr022001.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Colr022001.Quantity51Choice {
        + OrgnlAndCurFace  : ISO20022.Colr022001.OriginalAndCurrentQuantities1
        + Qty  : ISO20022.Colr022001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Colr022001.Quantity51Choice *-- ISO20022.Colr022001.OriginalAndCurrentQuantities1
    ISO20022.Colr022001.Quantity51Choice *-- ISO20022.Colr022001.FinancialInstrumentQuantity33Choice
    class ISO20022.Colr022001.RateOrName4Choice {
        + RateIndxDtls  : ISO20022.Colr022001.RateTypeAndLookback2
        + Rate  : Decimal
    }
    ISO20022.Colr022001.RateOrName4Choice *-- ISO20022.Colr022001.RateTypeAndLookback2
    class ISO20022.Colr022001.RateTypeAndLookback2 {
        + Ccy  : String
        + Tnr  : String
        + CrstllstnDt  : ISO20022.Colr022001.CrystallisationDay1
        + LookBckDays  : String
        + Tp  : ISO20022.Colr022001.BenchmarkCurveName13Choice
    }
    ISO20022.Colr022001.RateTypeAndLookback2 *-- ISO20022.Colr022001.CrystallisationDay1
    ISO20022.Colr022001.RateTypeAndLookback2 *-- ISO20022.Colr022001.BenchmarkCurveName13Choice
    class ISO20022.Colr022001.Rating2 {
        + SrcOfRatg  : ISO20022.Colr022001.MarketIdentification89
        + Ratg  : String
    }
    ISO20022.Colr022001.Rating2 *-- ISO20022.Colr022001.MarketIdentification89
    class ISO20022.Colr022001.RepoTerminationOption1Code {
        ETSB = 1
        EGRN = 2
    }
    class ISO20022.Colr022001.SafeKeepingPlace3 {
        + LEI  : String
        + SfkpgPlcFrmt  : ISO20022.Colr022001.SafekeepingPlaceFormat29Choice
    }
    ISO20022.Colr022001.SafeKeepingPlace3 *-- ISO20022.Colr022001.SafekeepingPlaceFormat29Choice
    class ISO20022.Colr022001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Colr022001.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Colr022001.SafekeepingPlaceFormat29Choice {
        + Prtry  : ISO20022.Colr022001.GenericIdentification78
        + TpAndId  : ISO20022.Colr022001.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Colr022001.SafekeepingPlaceTypeAndText8
    }
    ISO20022.Colr022001.SafekeepingPlaceFormat29Choice *-- ISO20022.Colr022001.GenericIdentification78
    ISO20022.Colr022001.SafekeepingPlaceFormat29Choice *-- ISO20022.Colr022001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Colr022001.SafekeepingPlaceFormat29Choice *-- ISO20022.Colr022001.SafekeepingPlaceTypeAndText8
    class ISO20022.Colr022001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Colr022001.SafekeepingPlaceTypeAndText8 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Colr022001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Colr022001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Colr022001.SecuritiesAccount19 *-- ISO20022.Colr022001.GenericIdentification30
    class ISO20022.Colr022001.SecuritiesBalance3 {
        + TxLotNb  : global::System.Collections.Generic.List~ISO20022.Colr022001.GenericIdentification178~
        + ValtnDtls  : ISO20022.Colr022001.ValuationsDetails1
        + FXDtls  : ISO20022.Colr022001.ForeignExchangeTerms19
        + RatgDtls  : global::System.Collections.Generic.List~ISO20022.Colr022001.Rating2~
        + DnmtnCcy  : String
        + SttlmSts  : String
        + BlckChainAdrOrWllt  : ISO20022.Colr022001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Colr022001.SecuritiesAccount19
        + AcctOwnr  : ISO20022.Colr022001.PartyIdentification232
        + SfkpgPlc  : ISO20022.Colr022001.SafeKeepingPlace3
        + CollInd  : String
        + Qty  : ISO20022.Colr022001.BalanceQuantity13Choice
        + FinInstrmId  : ISO20022.Colr022001.SecurityIdentification19
    }
    ISO20022.Colr022001.SecuritiesBalance3 *-- ISO20022.Colr022001.GenericIdentification178
    ISO20022.Colr022001.SecuritiesBalance3 *-- ISO20022.Colr022001.ValuationsDetails1
    ISO20022.Colr022001.SecuritiesBalance3 *-- ISO20022.Colr022001.ForeignExchangeTerms19
    ISO20022.Colr022001.SecuritiesBalance3 *-- ISO20022.Colr022001.Rating2
    ISO20022.Colr022001.SecuritiesBalance3 *-- ISO20022.Colr022001.BlockChainAddressWallet3
    ISO20022.Colr022001.SecuritiesBalance3 *-- ISO20022.Colr022001.SecuritiesAccount19
    ISO20022.Colr022001.SecuritiesBalance3 *-- ISO20022.Colr022001.PartyIdentification232
    ISO20022.Colr022001.SecuritiesBalance3 *-- ISO20022.Colr022001.SafeKeepingPlace3
    ISO20022.Colr022001.SecuritiesBalance3 *-- ISO20022.Colr022001.BalanceQuantity13Choice
    ISO20022.Colr022001.SecuritiesBalance3 *-- ISO20022.Colr022001.SecurityIdentification19
    class ISO20022.Colr022001.SecuritiesSettlementStatus3Code {
        SETT = 1
        PEND = 2
    }
    class ISO20022.Colr022001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Colr022001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Colr022001.SecurityIdentification19 *-- ISO20022.Colr022001.OtherIdentification1
    class ISO20022.Colr022001.Statement78 {
        + ActvtyInd  : String
        + SummryInd  : String
        + StsTp  : String
        + StmtBsis  : ISO20022.Colr022001.StatementBasis14Choice
        + CollSd  : String
        + UpdTp  : ISO20022.Colr022001.UpdateType15Choice
        + Frqcy  : ISO20022.Colr022001.Frequency22Choice
        + StmtDtTm  : ISO20022.Colr022001.DateAndDateTime2Choice
        + QryRef  : String
        + RptNb  : ISO20022.Colr022001.Number3Choice
        + StmtId  : String
    }
    ISO20022.Colr022001.Statement78 *-- ISO20022.Colr022001.StatementBasis14Choice
    ISO20022.Colr022001.Statement78 *-- ISO20022.Colr022001.UpdateType15Choice
    ISO20022.Colr022001.Statement78 *-- ISO20022.Colr022001.Frequency22Choice
    ISO20022.Colr022001.Statement78 *-- ISO20022.Colr022001.DateAndDateTime2Choice
    ISO20022.Colr022001.Statement78 *-- ISO20022.Colr022001.Number3Choice
    class ISO20022.Colr022001.StatementBasis14Choice {
        + Prtry  : ISO20022.Colr022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr022001.StatementBasis14Choice *-- ISO20022.Colr022001.GenericIdentification30
    class ISO20022.Colr022001.StatementBasis3Code {
        FUTM = 1
        EOSP = 2
    }
    class ISO20022.Colr022001.StatementStatusType1Code {
        PEND = 1
        CONF = 2
    }
    class ISO20022.Colr022001.StatementUpdateType1Code {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Colr022001.SupplementaryData1 {
        + Envlp  : ISO20022.Colr022001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Colr022001.SupplementaryData1 *-- ISO20022.Colr022001.SupplementaryDataEnvelope1
    class ISO20022.Colr022001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Colr022001.TotalValueInPageAndStatement5 {
        + TtlCollHeldValOfPg  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + TtlXpsrValOfPg  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Colr022001.TotalValueInPageAndStatement5 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.TotalValueInPageAndStatement5 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Colr022001.TradingCapacity7Code {
        PRIN = 1
        AGEN = 2
    }
    class ISO20022.Colr022001.TradingPartyCapacity5Choice {
        + Prtry  : ISO20022.Colr022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr022001.TradingPartyCapacity5Choice *-- ISO20022.Colr022001.GenericIdentification30
    class ISO20022.Colr022001.Transaction124 {
        + CshBal  : global::System.Collections.Generic.List~ISO20022.Colr022001.CashBalance15~
        + SctiesBal  : global::System.Collections.Generic.List~ISO20022.Colr022001.SecuritiesBalance3~
        + TxSts  : global::System.Collections.Generic.List~ISO20022.Colr022001.TransactionStatus6~
        + AutomtcAllcn  : String
        + DayCntBsis  : ISO20022.Colr022001.InterestComputationMethodFormat4Choice
        + SprdRate  : Decimal
        + MrgnRate  : Decimal
        + PricgRate  : ISO20022.Colr022001.RateOrName4Choice
        + ValtnAmts  : ISO20022.Colr022001.CollateralAmount17
        + ClsgDt  : ISO20022.Colr022001.ClosingDate4Choice
        + ExctnReqdDt  : ISO20022.Colr022001.ClosingDate4Choice
        + CollPties  : ISO20022.Colr022001.CollateralParties11
        + BsktIdAndElgbltySetPrfl  : ISO20022.Colr022001.BasketIdentificationAndEligibilitySetProfile1
        + TermntnOptn  : String
        + OptnTp  : ISO20022.Colr022001.OptionType6Choice
        + XpsrTp  : ISO20022.Colr022001.ExposureType23Choice
        + CmonTxId  : String
        + CtrPtyCollTxRef  : String
        + TrptyAgtSvcPrvdrCollTxId  : String
        + ClntTrptyCollTxId  : String
    }
    ISO20022.Colr022001.Transaction124 *-- ISO20022.Colr022001.CashBalance15
    ISO20022.Colr022001.Transaction124 *-- ISO20022.Colr022001.SecuritiesBalance3
    ISO20022.Colr022001.Transaction124 *-- ISO20022.Colr022001.TransactionStatus6
    ISO20022.Colr022001.Transaction124 *-- ISO20022.Colr022001.InterestComputationMethodFormat4Choice
    ISO20022.Colr022001.Transaction124 *-- ISO20022.Colr022001.RateOrName4Choice
    ISO20022.Colr022001.Transaction124 *-- ISO20022.Colr022001.CollateralAmount17
    ISO20022.Colr022001.Transaction124 *-- ISO20022.Colr022001.ClosingDate4Choice
    ISO20022.Colr022001.Transaction124 *-- ISO20022.Colr022001.ClosingDate4Choice
    ISO20022.Colr022001.Transaction124 *-- ISO20022.Colr022001.CollateralParties11
    ISO20022.Colr022001.Transaction124 *-- ISO20022.Colr022001.BasketIdentificationAndEligibilitySetProfile1
    ISO20022.Colr022001.Transaction124 *-- ISO20022.Colr022001.OptionType6Choice
    ISO20022.Colr022001.Transaction124 *-- ISO20022.Colr022001.ExposureType23Choice
    class ISO20022.Colr022001.TransactionStatus6 {
        + ExctnSts  : ISO20022.Colr022001.CollateralStatus2Choice
        + CvrgSts  : String
    }
    ISO20022.Colr022001.TransactionStatus6 *-- ISO20022.Colr022001.CollateralStatus2Choice
    class ISO20022.Colr022001.TripartyCollateralAndExposureReportV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Colr022001.SupplementaryData1~
        + AcctBaseCcyTtlAmts  : ISO20022.Colr022001.TotalValueInPageAndStatement5
        + Txs  : global::System.Collections.Generic.List~ISO20022.Colr022001.Transaction124~
        + CtrPtyAggtn  : global::System.Collections.Generic.List~ISO20022.Colr022001.CounterpartyAggregation3~
        + XpsrTpAggtn  : global::System.Collections.Generic.List~ISO20022.Colr022001.ExposureTypeAggregation3~
        + OvrllCollAggtn  : ISO20022.Colr022001.OverallCollateralDetails2
        + CollPties  : ISO20022.Colr022001.CollateralParties9
        + StmtGnlDtls  : ISO20022.Colr022001.Statement78
        + Pgntn  : ISO20022.Colr022001.Pagination1
    }
    ISO20022.Colr022001.TripartyCollateralAndExposureReportV01 *-- ISO20022.Colr022001.SupplementaryData1
    ISO20022.Colr022001.TripartyCollateralAndExposureReportV01 *-- ISO20022.Colr022001.TotalValueInPageAndStatement5
    ISO20022.Colr022001.TripartyCollateralAndExposureReportV01 *-- ISO20022.Colr022001.Transaction124
    ISO20022.Colr022001.TripartyCollateralAndExposureReportV01 *-- ISO20022.Colr022001.CounterpartyAggregation3
    ISO20022.Colr022001.TripartyCollateralAndExposureReportV01 *-- ISO20022.Colr022001.ExposureTypeAggregation3
    ISO20022.Colr022001.TripartyCollateralAndExposureReportV01 *-- ISO20022.Colr022001.OverallCollateralDetails2
    ISO20022.Colr022001.TripartyCollateralAndExposureReportV01 *-- ISO20022.Colr022001.CollateralParties9
    ISO20022.Colr022001.TripartyCollateralAndExposureReportV01 *-- ISO20022.Colr022001.Statement78
    ISO20022.Colr022001.TripartyCollateralAndExposureReportV01 *-- ISO20022.Colr022001.Pagination1
    class ISO20022.Colr022001.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Colr022001.UpdateType15Choice {
        + Prtry  : ISO20022.Colr022001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr022001.UpdateType15Choice *-- ISO20022.Colr022001.GenericIdentification30
    class ISO20022.Colr022001.ValuationFactorBreakdown1 {
        + PoolFctr  : Decimal
        + Hrcut  : Decimal
        + InfltnFctr  : Decimal
        + ValtnFctr  : Decimal
    }
    class ISO20022.Colr022001.ValuationsDetails1 {
        + QtnAge  : Decimal
        + NbOfDaysAcrd  : Decimal
        + ValtnFctrBrkdwn  : ISO20022.Colr022001.ValuationFactorBreakdown1
        + CleanPric  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + AcrdIntrst  : ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
        + ValtnDtlsAmt  : ISO20022.Colr022001.CollateralAmount4
        + SttlmDt  : ISO20022.Colr022001.DateAndDateTime2Choice
        + SrcOfPric  : ISO20022.Colr022001.MarketIdentification89
        + MktPric  : ISO20022.Colr022001.Price7
    }
    ISO20022.Colr022001.ValuationsDetails1 *-- ISO20022.Colr022001.ValuationFactorBreakdown1
    ISO20022.Colr022001.ValuationsDetails1 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.ValuationsDetails1 *-- ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr022001.ValuationsDetails1 *-- ISO20022.Colr022001.CollateralAmount4
    ISO20022.Colr022001.ValuationsDetails1 *-- ISO20022.Colr022001.DateAndDateTime2Choice
    ISO20022.Colr022001.ValuationsDetails1 *-- ISO20022.Colr022001.MarketIdentification89
    ISO20022.Colr022001.ValuationsDetails1 *-- ISO20022.Colr022001.Price7
    class ISO20022.Colr022001.ValuationsDetails2 {
        + Hrcut  : Decimal
        + ValtnDtlsAmt  : global::System.Collections.Generic.List~ISO20022.Colr022001.CollateralAmount9~
    }
    ISO20022.Colr022001.ValuationsDetails2 *-- ISO20022.Colr022001.CollateralAmount9
    class ISO20022.Colr022001.YieldedOrValueType1Choice {
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

## Value ISO20022.Colr022001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Colr022001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Colr022001.AlternatePartyIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Colr022001.IdentificationType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Colr022001.AmountAndDirection53


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Sgn|String||XmlElement()||
|+|Amt|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Value ISO20022.Colr022001.BalanceQuantity13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr022001.GenericIdentification56||XmlElement()||
|+|Qty|ISO20022.Colr022001.Quantity51Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(Qty),validChoice(Prtry,Qty))|

---

## Value ISO20022.Colr022001.BasketIdentificationAndEligibilitySetProfile1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ElgbltySetPrfl|ISO20022.Colr022001.GenericIdentification1||XmlElement()||
|+|ExclsnBsktId|ISO20022.Colr022001.GenericIdentification1||XmlElement()||
|+|FllbckStartgBsktId|ISO20022.Colr022001.GenericIdentification1||XmlElement()||
|+|PrfrntlBsktIdNb|ISO20022.Colr022001.GenericIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ElgbltySetPrfl),validElement(ExclsnBsktId),validElement(FllbckStartgBsktId),validElement(PrfrntlBsktIdNb))|

---

## Value ISO20022.Colr022001.BenchmarkCurveName13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr022001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Colr022001.BenchmarkCurveName7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WIBO|Int32||XmlEnum("""WIBO""")|1|
||TREA|Int32||XmlEnum("""TREA""")|2|
||TOAR|Int32||XmlEnum("""TOAR""")|3|
||TIBO|Int32||XmlEnum("""TIBO""")|4|
||TLBO|Int32||XmlEnum("""TLBO""")|5|
||SWAP|Int32||XmlEnum("""SWAP""")|6|
||STBO|Int32||XmlEnum("""STBO""")|7|
||SONA|Int32||XmlEnum("""SONA""")|8|
||SOFR|Int32||XmlEnum("""SOFR""")|9|
||RCTR|Int32||XmlEnum("""RCTR""")|10|
||PRBO|Int32||XmlEnum("""PRBO""")|11|
||PFAN|Int32||XmlEnum("""PFAN""")|12|
||OBFR|Int32||XmlEnum("""OBFR""")|13|
||NIBO|Int32||XmlEnum("""NIBO""")|14|
||BJUO|Int32||XmlEnum("""BJUO""")|15|
||MAAA|Int32||XmlEnum("""MAAA""")|16|
||MOSP|Int32||XmlEnum("""MOSP""")|17|
||LIBO|Int32||XmlEnum("""LIBO""")|18|
||LIBI|Int32||XmlEnum("""LIBI""")|19|
||JIBA|Int32||XmlEnum("""JIBA""")|20|
||ETIO|Int32||XmlEnum("""ETIO""")|21|
||ISDA|Int32||XmlEnum("""ISDA""")|22|
||HKIO|Int32||XmlEnum("""HKIO""")|23|
||GCFR|Int32||XmlEnum("""GCFR""")|24|
||FUSW|Int32||XmlEnum("""FUSW""")|25|
||EFFR|Int32||XmlEnum("""EFFR""")|26|
||EUCH|Int32||XmlEnum("""EUCH""")|27|
||EUUS|Int32||XmlEnum("""EUUS""")|28|
||EURI|Int32||XmlEnum("""EURI""")|29|
||ESTR|Int32||XmlEnum("""ESTR""")|30|
||EONS|Int32||XmlEnum("""EONS""")|31|
||EONA|Int32||XmlEnum("""EONA""")|32|
||CZNA|Int32||XmlEnum("""CZNA""")|33|
||CORA|Int32||XmlEnum("""CORA""")|34|
||CIBO|Int32||XmlEnum("""CIBO""")|35|
||CDOR|Int32||XmlEnum("""CDOR""")|36|
||BCOL|Int32||XmlEnum("""BCOL""")|37|
||BUBO|Int32||XmlEnum("""BUBO""")|38|
||BBSW|Int32||XmlEnum("""BBSW""")|39|

---

## Value ISO20022.Colr022001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr022001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr022001.CashAccountIdentification5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Value ISO20022.Colr022001.CashBalance15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxLotNb|global::System.Collections.Generic.List<ISO20022.Colr022001.GenericIdentification178>||XmlElement()||
|+|ValtnDtls|ISO20022.Colr022001.ValuationsDetails2||XmlElement()||
|+|CshAcct|ISO20022.Colr022001.CashAccountIdentification5Choice||XmlElement()||
|+|FXDtls|ISO20022.Colr022001.ForeignExchangeTerms19||XmlElement()||
|+|Amt|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TxLotNb""",TxLotNb),validElement(TxLotNb),validElement(ValtnDtls),validElement(CshAcct),validElement(FXDtls),validElement(Amt))|

---

## Value ISO20022.Colr022001.ClosingDate4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|ISO20022.Colr022001.Date3Choice||XmlElement()||
|+|Dt|ISO20022.Colr022001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd),validElement(Dt),validChoice(Cd,Dt))|

---

## Value ISO20022.Colr022001.CollateralAmount15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlCshFaild|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlValOfReusdColl|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlValOfOwnColl|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlPdgCollOut|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlPdgCollIn|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlOfPrncpls|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlFeesComssns|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlAcrdIntrst|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlCollReqrd|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Mrgn|ISO20022.Colr022001.AmountAndDirection53||XmlElement()||
|+|TtlXpsr|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|ValOfCollHeld|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlCshFaild),validElement(TtlValOfReusdColl),validElement(TtlValOfOwnColl),validElement(TtlPdgCollOut),validElement(TtlPdgCollIn),validElement(TtlOfPrncpls),validElement(TtlFeesComssns),validElement(TtlAcrdIntrst),validElement(TtlCollReqrd),validElement(Mrgn),validElement(TtlXpsr),validElement(ValOfCollHeld))|

---

## Value ISO20022.Colr022001.CollateralAmount16


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlCshFaild|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlPdgCollOut|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlPdgCollIn|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlOfPrncpls|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlValOfReusdColl|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlValOfOwnColl|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlAcrdIntrst|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlCollReqrd|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Mrgn|ISO20022.Colr022001.AmountAndDirection53||XmlElement()||
|+|TtlXpsr|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|ValOfCollHeld|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlCshFaild),validElement(TtlPdgCollOut),validElement(TtlPdgCollIn),validElement(TtlOfPrncpls),validElement(TtlValOfReusdColl),validElement(TtlValOfOwnColl),validElement(TtlAcrdIntrst),validElement(TtlCollReqrd),validElement(Mrgn),validElement(TtlXpsr),validElement(ValOfCollHeld))|

---

## Value ISO20022.Colr022001.CollateralAmount17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlCshFaild|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TermntnTxAmt|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlOfPrncpls|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlPdgCollOut|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlPdgCollIn|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlValOfReusdColl|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlValOfOwnColl|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlCollReqrd|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlAcrdIntrst|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|Mrgn|ISO20022.Colr022001.AmountAndDirection53||XmlElement()||
|+|TxAmtBrkdwn|global::System.Collections.Generic.List<ISO20022.Colr022001.CollateralTransactionAmountBreakdown2>||XmlElement()||
|+|TxAmt|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlXpsr|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|ValOfCollHeld|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlCshFaild),validElement(TermntnTxAmt),validElement(TtlOfPrncpls),validElement(TtlPdgCollOut),validElement(TtlPdgCollIn),validElement(TtlValOfReusdColl),validElement(TtlValOfOwnColl),validElement(TtlCollReqrd),validElement(TtlAcrdIntrst),validElement(Mrgn),validList("""TxAmtBrkdwn""",TxAmtBrkdwn),validElement(TxAmtBrkdwn),validElement(TxAmt),validElement(TtlXpsr),validElement(ValOfCollHeld))|

---

## Value ISO20022.Colr022001.CollateralAmount4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlValOfReusdColl|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlValOfOwnColl|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|MktValAmtBfrValtnFctr|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|MktValAmtPstValtnFctr|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|XpsrCollInRptgCcy|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|XpsrCollInTxCcy|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|ActlMktValBfrValtnFctr|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|ActlMktValPstValtnFctr|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlValOfReusdColl),validElement(TtlValOfOwnColl),validElement(MktValAmtBfrValtnFctr),validElement(MktValAmtPstValtnFctr),validElement(XpsrCollInRptgCcy),validElement(XpsrCollInTxCcy),validElement(ActlMktValBfrValtnFctr),validElement(ActlMktValPstValtnFctr))|

---

## Value ISO20022.Colr022001.CollateralAmount9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktValAmtBfrHrcut|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|MktValAmtPstHrcut|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|XpsrCollInRptgCcy|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|XpsrCollInTxCcy|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|ActlMktValBfrHrcut|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|ActlMktValPstHrcut|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktValAmtBfrHrcut),validElement(MktValAmtPstHrcut),validElement(XpsrCollInRptgCcy),validElement(XpsrCollInTxCcy),validElement(ActlMktValBfrHrcut),validElement(ActlMktValPstHrcut))|

---

## Value ISO20022.Colr022001.CollateralParties11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BlckChainAdrOrWllt|ISO20022.Colr022001.BlockChainAddressWallet3||XmlElement()||
|+|CollAcct|ISO20022.Colr022001.SecuritiesAccount19||XmlElement()||
|+|TrptyAgt|ISO20022.Colr022001.PartyIdentification136||XmlElement()||
|+|ClntPtyB|ISO20022.Colr022001.PartyIdentification232||XmlElement()||
|+|PtyB|ISO20022.Colr022001.PartyIdentification232||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainAdrOrWllt),validElement(CollAcct),validElement(TrptyAgt),validElement(ClntPtyB),validElement(PtyB))|

---

## Value ISO20022.Colr022001.CollateralParties9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrptyAgt|ISO20022.Colr022001.PartyIdentification136||XmlElement()||
|+|ClntPtyA|ISO20022.Colr022001.PartyIdentificationAndAccount202||XmlElement()||
|+|PtyA|ISO20022.Colr022001.PartyIdentificationAndAccount202||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrptyAgt),validElement(ClntPtyA),validElement(PtyA))|

---

## Enum ISO20022.Colr022001.CollateralRole1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAKE|Int32||XmlEnum("""TAKE""")|1|
||GIVE|Int32||XmlEnum("""GIVE""")|2|

---

## Enum ISO20022.Colr022001.CollateralStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FLAT|Int32||XmlEnum("""FLAT""")|1|
||DEFI|Int32||XmlEnum("""DEFI""")|2|
||EXCS|Int32||XmlEnum("""EXCS""")|3|

---

## Value ISO20022.Colr022001.CollateralStatus2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr022001.CollateralTransactionAmountBreakdown2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prd|ISO20022.Colr022001.Period4Choice||XmlElement()||
|+|TxAmt|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|LotNb|ISO20022.Colr022001.GenericIdentification178||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prd),validElement(TxAmt),validElement(LotNb))|

---

## Value ISO20022.Colr022001.CounterpartyAggregation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GblCtrPtySts|String||XmlElement()||
|+|MrgnRate|Decimal||XmlElement()||
|+|ValtnAmts|global::System.Collections.Generic.List<ISO20022.Colr022001.CollateralAmount16>||XmlElement()||
|+|CollPties|ISO20022.Colr022001.CollateralParties11||XmlElement()||
|+|BsktIdAndElgbltySetPrfl|ISO20022.Colr022001.BasketIdentificationAndEligibilitySetProfile1||XmlElement()||
|+|TermntnOptn|String||XmlElement()||
|+|OptnTp|ISO20022.Colr022001.OptionType6Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""ValtnAmts""",ValtnAmts),validList("""ValtnAmts""",ValtnAmts),validElement(ValtnAmts),validElement(CollPties),validElement(BsktIdAndElgbltySetPrfl),validElement(OptnTp))|

---

## Value ISO20022.Colr022001.CrystallisationDay1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prd|String||XmlElement()||
|+|Day|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prd""",Prd,"""[0-9]{1,3}"""))|

---

## Value ISO20022.Colr022001.Date3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr022001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Colr022001.DateType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEN|Int32||XmlEnum("""OPEN""")|1|

---

## Type ISO20022.Colr022001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrptyCollAndXpsrRpt|ISO20022.Colr022001.TripartyCollateralAndExposureReportV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrptyCollAndXpsrRpt))|

---

## Enum ISO20022.Colr022001.EventFrequency7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONDE|Int32||XmlEnum("""ONDE""")|1|
||OVNG|Int32||XmlEnum("""OVNG""")|2|
||TWMN|Int32||XmlEnum("""TWMN""")|3|
||TOWK|Int32||XmlEnum("""TOWK""")|4|
||TOMN|Int32||XmlEnum("""TOMN""")|5|
||QUTR|Int32||XmlEnum("""QUTR""")|6|
||SEMI|Int32||XmlEnum("""SEMI""")|7|
||WEEK|Int32||XmlEnum("""WEEK""")|8|
||INDA|Int32||XmlEnum("""INDA""")|9|
||DAIL|Int32||XmlEnum("""DAIL""")|10|
||MNTH|Int32||XmlEnum("""MNTH""")|11|
||ADHO|Int32||XmlEnum("""ADHO""")|12|
||YEAR|Int32||XmlEnum("""YEAR""")|13|

---

## Enum ISO20022.Colr022001.ExecutionStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PINT|Int32||XmlEnum("""PINT""")|1|
||INTD|Int32||XmlEnum("""INTD""")|2|

---

## Enum ISO20022.Colr022001.ExposureType14Code


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

## Value ISO20022.Colr022001.ExposureType23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr022001.ExposureTypeAggregation3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GblXpsrTpSts|String||XmlElement()||
|+|MrgnRate|Decimal||XmlElement()||
|+|ValtnAmts|global::System.Collections.Generic.List<ISO20022.Colr022001.CollateralAmount16>||XmlElement()||
|+|SttlmPrc|ISO20022.Colr022001.GenericIdentification30||XmlElement()||
|+|XpsrTp|ISO20022.Colr022001.ExposureType23Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""ValtnAmts""",ValtnAmts),validList("""ValtnAmts""",ValtnAmts),validElement(ValtnAmts),validElement(SttlmPrc),validElement(XpsrTp))|

---

## Value ISO20022.Colr022001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Colr022001.ForeignExchangeTerms19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Colr022001.Frequency22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr022001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr022001.GenericIdentification178


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr022001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Colr022001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr022001.GenericIdentification56


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|Decimal||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Colr022001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Colr022001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr022001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr022001.IdentificationType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Colr022001.InterestComputationMethod2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NARR|Int32||XmlEnum("""NARR""")|1|
||A014|Int32||XmlEnum("""A014""")|2|
||A013|Int32||XmlEnum("""A013""")|3|
||A012|Int32||XmlEnum("""A012""")|4|
||A011|Int32||XmlEnum("""A011""")|5|
||A010|Int32||XmlEnum("""A010""")|6|
||A009|Int32||XmlEnum("""A009""")|7|
||A008|Int32||XmlEnum("""A008""")|8|
||A007|Int32||XmlEnum("""A007""")|9|
||A006|Int32||XmlEnum("""A006""")|10|
||A005|Int32||XmlEnum("""A005""")|11|
||A004|Int32||XmlEnum("""A004""")|12|
||A003|Int32||XmlEnum("""A003""")|13|
||A002|Int32||XmlEnum("""A002""")|14|
||A001|Int32||XmlEnum("""A001""")|15|

---

## Value ISO20022.Colr022001.InterestComputationMethodFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Colr022001.InterestRateIndexTenor2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TOWK|Int32||XmlEnum("""TOWK""")|1|
||WEEK|Int32||XmlEnum("""WEEK""")|2|
||OVNG|Int32||XmlEnum("""OVNG""")|3|
||SEMI|Int32||XmlEnum("""SEMI""")|4|
||FOMN|Int32||XmlEnum("""FOMN""")|5|
||QUTR|Int32||XmlEnum("""QUTR""")|6|
||TOMN|Int32||XmlEnum("""TOMN""")|7|
||YEAR|Int32||XmlEnum("""YEAR""")|8|
||MNTH|Int32||XmlEnum("""MNTH""")|9|
||INDA|Int32||XmlEnum("""INDA""")|10|

---

## Value ISO20022.Colr022001.MarketIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Colr022001.MarketIdentification89


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Colr022001.MarketType15Choice||XmlElement()||
|+|Id|ISO20022.Colr022001.MarketIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Value ISO20022.Colr022001.MarketType15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Colr022001.MarketType4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VEND|Int32||XmlEnum("""VEND""")|1|
||THEO|Int32||XmlEnum("""THEO""")|2|
||LMAR|Int32||XmlEnum("""LMAR""")|3|
||FUND|Int32||XmlEnum("""FUND""")|4|

---

## Value ISO20022.Colr022001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Colr022001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Colr022001.Number3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|String||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lng""",Lng,"""[0-9]{5}"""),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Enum ISO20022.Colr022001.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Colr022001.OptionType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr022001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr022001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Colr022001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr022001.OverallCollateralDetails2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollAddtlDtls|String||XmlElement()||
|+|ValtnDt|ISO20022.Colr022001.DateAndDateTime2Choice||XmlElement()||
|+|GblCollSts|String||XmlElement()||
|+|MrgnRate|Decimal||XmlElement()||
|+|ValtnAmts|ISO20022.Colr022001.CollateralAmount15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValtnDt),validElement(ValtnAmts))|

---

## Value ISO20022.Colr022001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Colr022001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Colr022001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Colr022001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Colr022001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Colr022001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Colr022001.PartyIdentification232


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|ISO20022.Colr022001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Colr022001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Colr022001.PartyIdentificationAndAccount202


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCpcty|ISO20022.Colr022001.TradingPartyCapacity5Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Colr022001.PartyIdentification136||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Colr022001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Colr022001.SecuritiesAccount19||XmlElement()||
|+|AltrnId|ISO20022.Colr022001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Colr022001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyCpcty),validElement(AcctOwnr),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Colr022001.Period2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr022001.Period4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrDtToDt|ISO20022.Colr022001.Period2||XmlElement()||
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrDtToDt),validChoice(FrDtToDt,ToDt,FrDt,Dt))|

---

## Value ISO20022.Colr022001.PostalAddress1


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

## Value ISO20022.Colr022001.Price7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Colr022001.PriceRateOrAmount3Choice||XmlElement()||
|+|Tp|ISO20022.Colr022001.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Colr022001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Colr022001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Enum ISO20022.Colr022001.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Colr022001.Quantity51Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OrgnlAndCurFace|ISO20022.Colr022001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Qty|ISO20022.Colr022001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OrgnlAndCurFace),validElement(Qty),validChoice(OrgnlAndCurFace,Qty))|

---

## Value ISO20022.Colr022001.RateOrName4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateIndxDtls|ISO20022.Colr022001.RateTypeAndLookback2||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateIndxDtls),validChoice(RateIndxDtls,Rate))|

---

## Value ISO20022.Colr022001.RateTypeAndLookback2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|Tnr|String||XmlElement()||
|+|CrstllstnDt|ISO20022.Colr022001.CrystallisationDay1||XmlElement()||
|+|LookBckDays|String||XmlElement()||
|+|Tp|ISO20022.Colr022001.BenchmarkCurveName13Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(CrstllstnDt),validPattern("""LookBckDays""",LookBckDays,"""[0-9]{1,3}"""),validElement(Tp))|

---

## Value ISO20022.Colr022001.Rating2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SrcOfRatg|ISO20022.Colr022001.MarketIdentification89||XmlElement()||
|+|Ratg|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SrcOfRatg))|

---

## Enum ISO20022.Colr022001.RepoTerminationOption1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ETSB|Int32||XmlEnum("""ETSB""")|1|
||EGRN|Int32||XmlEnum("""EGRN""")|2|

---

## Value ISO20022.Colr022001.SafeKeepingPlace3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|SfkpgPlcFrmt|ISO20022.Colr022001.SafekeepingPlaceFormat29Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(SfkpgPlcFrmt))|

---

## Enum ISO20022.Colr022001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Colr022001.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Colr022001.SafekeepingPlaceFormat29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr022001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Colr022001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Colr022001.SafekeepingPlaceTypeAndText8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Colr022001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Colr022001.SafekeepingPlaceTypeAndText8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr022001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr022001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr022001.SecuritiesBalance3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TxLotNb|global::System.Collections.Generic.List<ISO20022.Colr022001.GenericIdentification178>||XmlElement()||
|+|ValtnDtls|ISO20022.Colr022001.ValuationsDetails1||XmlElement()||
|+|FXDtls|ISO20022.Colr022001.ForeignExchangeTerms19||XmlElement()||
|+|RatgDtls|global::System.Collections.Generic.List<ISO20022.Colr022001.Rating2>||XmlElement()||
|+|DnmtnCcy|String||XmlElement()||
|+|SttlmSts|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Colr022001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Colr022001.SecuritiesAccount19||XmlElement()||
|+|AcctOwnr|ISO20022.Colr022001.PartyIdentification232||XmlElement()||
|+|SfkpgPlc|ISO20022.Colr022001.SafeKeepingPlace3||XmlElement()||
|+|CollInd|String||XmlElement()||
|+|Qty|ISO20022.Colr022001.BalanceQuantity13Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Colr022001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""TxLotNb""",TxLotNb),validElement(TxLotNb),validElement(ValtnDtls),validElement(FXDtls),validList("""RatgDtls""",RatgDtls),validElement(RatgDtls),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(SfkpgPlc),validElement(Qty),validElement(FinInstrmId))|

---

## Enum ISO20022.Colr022001.SecuritiesSettlementStatus3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SETT|Int32||XmlEnum("""SETT""")|1|
||PEND|Int32||XmlEnum("""PEND""")|2|

---

## Value ISO20022.Colr022001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Colr022001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Colr022001.Statement78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ActvtyInd|String||XmlElement()||
|+|SummryInd|String||XmlElement()||
|+|StsTp|String||XmlElement()||
|+|StmtBsis|ISO20022.Colr022001.StatementBasis14Choice||XmlElement()||
|+|CollSd|String||XmlElement()||
|+|UpdTp|ISO20022.Colr022001.UpdateType15Choice||XmlElement()||
|+|Frqcy|ISO20022.Colr022001.Frequency22Choice||XmlElement()||
|+|StmtDtTm|ISO20022.Colr022001.DateAndDateTime2Choice||XmlElement()||
|+|QryRef|String||XmlElement()||
|+|RptNb|ISO20022.Colr022001.Number3Choice||XmlElement()||
|+|StmtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(StmtBsis),validElement(UpdTp),validElement(Frqcy),validElement(StmtDtTm),validElement(RptNb))|

---

## Value ISO20022.Colr022001.StatementBasis14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Colr022001.StatementBasis3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||FUTM|Int32||XmlEnum("""FUTM""")|1|
||EOSP|Int32||XmlEnum("""EOSP""")|2|

---

## Enum ISO20022.Colr022001.StatementStatusType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PEND|Int32||XmlEnum("""PEND""")|1|
||CONF|Int32||XmlEnum("""CONF""")|2|

---

## Enum ISO20022.Colr022001.StatementUpdateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Colr022001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Colr022001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Colr022001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr022001.TotalValueInPageAndStatement5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlCollHeldValOfPg|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|TtlXpsrValOfPg|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlCollHeldValOfPg),validElement(TtlXpsrValOfPg))|

---

## Enum ISO20022.Colr022001.TradingCapacity7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRIN|Int32||XmlEnum("""PRIN""")|1|
||AGEN|Int32||XmlEnum("""AGEN""")|2|

---

## Value ISO20022.Colr022001.TradingPartyCapacity5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr022001.Transaction124


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CshBal|global::System.Collections.Generic.List<ISO20022.Colr022001.CashBalance15>||XmlElement()||
|+|SctiesBal|global::System.Collections.Generic.List<ISO20022.Colr022001.SecuritiesBalance3>||XmlElement()||
|+|TxSts|global::System.Collections.Generic.List<ISO20022.Colr022001.TransactionStatus6>||XmlElement()||
|+|AutomtcAllcn|String||XmlElement()||
|+|DayCntBsis|ISO20022.Colr022001.InterestComputationMethodFormat4Choice||XmlElement()||
|+|SprdRate|Decimal||XmlElement()||
|+|MrgnRate|Decimal||XmlElement()||
|+|PricgRate|ISO20022.Colr022001.RateOrName4Choice||XmlElement()||
|+|ValtnAmts|ISO20022.Colr022001.CollateralAmount17||XmlElement()||
|+|ClsgDt|ISO20022.Colr022001.ClosingDate4Choice||XmlElement()||
|+|ExctnReqdDt|ISO20022.Colr022001.ClosingDate4Choice||XmlElement()||
|+|CollPties|ISO20022.Colr022001.CollateralParties11||XmlElement()||
|+|BsktIdAndElgbltySetPrfl|ISO20022.Colr022001.BasketIdentificationAndEligibilitySetProfile1||XmlElement()||
|+|TermntnOptn|String||XmlElement()||
|+|OptnTp|ISO20022.Colr022001.OptionType6Choice||XmlElement()||
|+|XpsrTp|ISO20022.Colr022001.ExposureType23Choice||XmlElement()||
|+|CmonTxId|String||XmlElement()||
|+|CtrPtyCollTxRef|String||XmlElement()||
|+|TrptyAgtSvcPrvdrCollTxId|String||XmlElement()||
|+|ClntTrptyCollTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""CshBal""",CshBal),validElement(CshBal),validList("""SctiesBal""",SctiesBal),validElement(SctiesBal),validList("""TxSts""",TxSts),validListMax("""TxSts""",TxSts,2),validElement(TxSts),validElement(DayCntBsis),validElement(PricgRate),validElement(ValtnAmts),validElement(ClsgDt),validElement(ExctnReqdDt),validElement(CollPties),validElement(BsktIdAndElgbltySetPrfl),validElement(OptnTp),validElement(XpsrTp))|

---

## Value ISO20022.Colr022001.TransactionStatus6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ExctnSts|ISO20022.Colr022001.CollateralStatus2Choice||XmlElement()||
|+|CvrgSts|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ExctnSts))|

---

## Aspect ISO20022.Colr022001.TripartyCollateralAndExposureReportV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Colr022001.SupplementaryData1>||XmlElement()||
|+|AcctBaseCcyTtlAmts|ISO20022.Colr022001.TotalValueInPageAndStatement5||XmlElement()||
|+|Txs|global::System.Collections.Generic.List<ISO20022.Colr022001.Transaction124>||XmlElement()||
|+|CtrPtyAggtn|global::System.Collections.Generic.List<ISO20022.Colr022001.CounterpartyAggregation3>||XmlElement()||
|+|XpsrTpAggtn|global::System.Collections.Generic.List<ISO20022.Colr022001.ExposureTypeAggregation3>||XmlElement()||
|+|OvrllCollAggtn|ISO20022.Colr022001.OverallCollateralDetails2||XmlElement()||
|+|CollPties|ISO20022.Colr022001.CollateralParties9||XmlElement()||
|+|StmtGnlDtls|ISO20022.Colr022001.Statement78||XmlElement()||
|+|Pgntn|ISO20022.Colr022001.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AcctBaseCcyTtlAmts),validList("""Txs""",Txs),validElement(Txs),validList("""CtrPtyAggtn""",CtrPtyAggtn),validElement(CtrPtyAggtn),validList("""XpsrTpAggtn""",XpsrTpAggtn),validElement(XpsrTpAggtn),validElement(OvrllCollAggtn),validElement(CollPties),validElement(StmtGnlDtls),validElement(Pgntn))|

---

## Enum ISO20022.Colr022001.TypeOfIdentification1Code


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

## Value ISO20022.Colr022001.UpdateType15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr022001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr022001.ValuationFactorBreakdown1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PoolFctr|Decimal||XmlElement()||
|+|Hrcut|Decimal||XmlElement()||
|+|InfltnFctr|Decimal||XmlElement()||
|+|ValtnFctr|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr022001.ValuationsDetails1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtnAge|Decimal||XmlElement()||
|+|NbOfDaysAcrd|Decimal||XmlElement()||
|+|ValtnFctrBrkdwn|ISO20022.Colr022001.ValuationFactorBreakdown1||XmlElement()||
|+|CleanPric|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|AcrdIntrst|ISO20022.Colr022001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|ValtnDtlsAmt|ISO20022.Colr022001.CollateralAmount4||XmlElement()||
|+|SttlmDt|ISO20022.Colr022001.DateAndDateTime2Choice||XmlElement()||
|+|SrcOfPric|ISO20022.Colr022001.MarketIdentification89||XmlElement()||
|+|MktPric|ISO20022.Colr022001.Price7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValtnFctrBrkdwn),validElement(CleanPric),validElement(AcrdIntrst),validElement(ValtnDtlsAmt),validElement(SttlmDt),validElement(SrcOfPric),validElement(MktPric))|

---

## Value ISO20022.Colr022001.ValuationsDetails2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Hrcut|Decimal||XmlElement()||
|+|ValtnDtlsAmt|global::System.Collections.Generic.List<ISO20022.Colr022001.CollateralAmount9>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""ValtnDtlsAmt""",ValtnDtlsAmt),validList("""ValtnDtlsAmt""",ValtnDtlsAmt),validElement(ValtnDtlsAmt))|

---

## Value ISO20022.Colr022001.YieldedOrValueType1Choice


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

