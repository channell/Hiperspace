# colr.019.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Colr019001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Colr019001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Colr019001.AdditionalInformation24 {
        + Note  : String
        + CollInstr  : String
    }
    class ISO20022.Colr019001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Colr019001.AlternatePartyIdentification7 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Colr019001.IdentificationType42Choice
    }
    ISO20022.Colr019001.AlternatePartyIdentification7 *-- ISO20022.Colr019001.IdentificationType42Choice
    class ISO20022.Colr019001.AmountAndDirection49 {
        + FXDtls  : ISO20022.Colr019001.ForeignExchangeTerms23
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Colr019001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Colr019001.ActiveCurrencyAndAmount
    }
    ISO20022.Colr019001.AmountAndDirection49 *-- ISO20022.Colr019001.ForeignExchangeTerms23
    ISO20022.Colr019001.AmountAndDirection49 *-- ISO20022.Colr019001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr019001.AmountAndDirection49 *-- ISO20022.Colr019001.ActiveCurrencyAndAmount
    class ISO20022.Colr019001.BasketIdentificationAndEligibilitySetProfile1 {
        + ElgbltySetPrfl  : ISO20022.Colr019001.GenericIdentification1
        + ExclsnBsktId  : ISO20022.Colr019001.GenericIdentification1
        + FllbckStartgBsktId  : ISO20022.Colr019001.GenericIdentification1
        + PrfrntlBsktIdNb  : ISO20022.Colr019001.GenericIdentification1
    }
    ISO20022.Colr019001.BasketIdentificationAndEligibilitySetProfile1 *-- ISO20022.Colr019001.GenericIdentification1
    ISO20022.Colr019001.BasketIdentificationAndEligibilitySetProfile1 *-- ISO20022.Colr019001.GenericIdentification1
    ISO20022.Colr019001.BasketIdentificationAndEligibilitySetProfile1 *-- ISO20022.Colr019001.GenericIdentification1
    ISO20022.Colr019001.BasketIdentificationAndEligibilitySetProfile1 *-- ISO20022.Colr019001.GenericIdentification1
    class ISO20022.Colr019001.BenchmarkCurveName13Choice {
        + Prtry  : ISO20022.Colr019001.GenericIdentification1
        + Cd  : String
    }
    ISO20022.Colr019001.BenchmarkCurveName13Choice *-- ISO20022.Colr019001.GenericIdentification1
    class ISO20022.Colr019001.BenchmarkCurveName7Code {
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
    class ISO20022.Colr019001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Colr019001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Colr019001.BlockChainAddressWallet3 *-- ISO20022.Colr019001.GenericIdentification30
    class ISO20022.Colr019001.CalculationMethod1Code {
        COMP = 1
        SIMP = 2
    }
    class ISO20022.Colr019001.CashAccountIdentification5Choice {
        + Prtry  : String
        + IBAN  : String
    }
    class ISO20022.Colr019001.CashMovement8 {
        + TrptyAgtSvcPrvdrCshMvmntId  : String
        + ClntCshMvmntId  : String
        + CollMvmnt  : String
        + CshAcct  : ISO20022.Colr019001.CashAccountIdentification5Choice
        + CshAmt  : ISO20022.Colr019001.ActiveCurrencyAndAmount
        + CshMvmnt  : String
    }
    ISO20022.Colr019001.CashMovement8 *-- ISO20022.Colr019001.CashAccountIdentification5Choice
    ISO20022.Colr019001.CashMovement8 *-- ISO20022.Colr019001.ActiveCurrencyAndAmount
    class ISO20022.Colr019001.ClosingDate4Choice {
        + Cd  : ISO20022.Colr019001.Date3Choice
        + Dt  : ISO20022.Colr019001.DateAndDateTime2Choice
    }
    ISO20022.Colr019001.ClosingDate4Choice *-- ISO20022.Colr019001.Date3Choice
    ISO20022.Colr019001.ClosingDate4Choice *-- ISO20022.Colr019001.DateAndDateTime2Choice
    class ISO20022.Colr019001.CollateralAmount18 {
        + ValSght  : ISO20022.Colr019001.AmountAndDirection49
        + TxAmtBrkdwn  : global::System.Collections.Generic.List~ISO20022.Colr019001.CollateralTransactionAmountBreakdown2~
        + IntrstPmtDely  : String
        + PmtFrqcy  : ISO20022.Colr019001.Frequency38Choice
        + CmpndSmplAcrlClctn  : String
        + Acrd  : ISO20022.Colr019001.AmountAndDirection49
        + Termntn  : ISO20022.Colr019001.AmountAndDirection49
        + Tx  : ISO20022.Colr019001.AmountAndDirection49
    }
    ISO20022.Colr019001.CollateralAmount18 *-- ISO20022.Colr019001.AmountAndDirection49
    ISO20022.Colr019001.CollateralAmount18 *-- ISO20022.Colr019001.CollateralTransactionAmountBreakdown2
    ISO20022.Colr019001.CollateralAmount18 *-- ISO20022.Colr019001.Frequency38Choice
    ISO20022.Colr019001.CollateralAmount18 *-- ISO20022.Colr019001.AmountAndDirection49
    ISO20022.Colr019001.CollateralAmount18 *-- ISO20022.Colr019001.AmountAndDirection49
    ISO20022.Colr019001.CollateralAmount18 *-- ISO20022.Colr019001.AmountAndDirection49
    class ISO20022.Colr019001.CollateralDate2 {
        + SttlmDt  : DateTime
        + ReqdExctnDt  : ISO20022.Colr019001.DateAndDateTime2Choice
        + TradDt  : DateTime
    }
    ISO20022.Colr019001.CollateralDate2 *-- ISO20022.Colr019001.DateAndDateTime2Choice
    class ISO20022.Colr019001.CollateralEntryType1Code {
        RECE = 1
        DELI = 2
    }
    class ISO20022.Colr019001.CollateralParameters10 {
        + AddtlInf  : ISO20022.Colr019001.AdditionalInformation24
        + RspnSts  : ISO20022.Colr019001.ResponseStatus9Choice
        + BsktIdAndElgbltySetPrfl  : ISO20022.Colr019001.BasketIdentificationAndEligibilitySetProfile1
        + MainTradgAcctCollstn  : String
        + FaildSttlmSlvtn  : String
        + AutomtcAllcn  : String
        + Prty  : ISO20022.Colr019001.GenericIdentification30
        + SttlmPrc  : ISO20022.Colr019001.GenericIdentification30
        + TrfTitl  : String
        + ValSghtMrgnRate  : ISO20022.Colr019001.RateOrType1Choice
        + CollSd  : String
        + XpsrTp  : ISO20022.Colr019001.ExposureType23Choice
        + CollInstrTp  : ISO20022.Colr019001.CollateralTransactionType1Choice
    }
    ISO20022.Colr019001.CollateralParameters10 *-- ISO20022.Colr019001.AdditionalInformation24
    ISO20022.Colr019001.CollateralParameters10 *-- ISO20022.Colr019001.ResponseStatus9Choice
    ISO20022.Colr019001.CollateralParameters10 *-- ISO20022.Colr019001.BasketIdentificationAndEligibilitySetProfile1
    ISO20022.Colr019001.CollateralParameters10 *-- ISO20022.Colr019001.GenericIdentification30
    ISO20022.Colr019001.CollateralParameters10 *-- ISO20022.Colr019001.GenericIdentification30
    ISO20022.Colr019001.CollateralParameters10 *-- ISO20022.Colr019001.RateOrType1Choice
    ISO20022.Colr019001.CollateralParameters10 *-- ISO20022.Colr019001.ExposureType23Choice
    ISO20022.Colr019001.CollateralParameters10 *-- ISO20022.Colr019001.CollateralTransactionType1Choice
    class ISO20022.Colr019001.CollateralParties10 {
        + CollAcct  : ISO20022.Colr019001.SecuritiesAccount19
        + TrptyAgt  : ISO20022.Colr019001.PartyIdentification136
        + ClntPtyB  : ISO20022.Colr019001.PartyIdentificationAndAccount203
        + PtyB  : ISO20022.Colr019001.PartyIdentificationAndAccount203
        + ClntPtyA  : ISO20022.Colr019001.PartyIdentificationAndAccount202
        + PtyA  : ISO20022.Colr019001.PartyIdentificationAndAccount202
    }
    ISO20022.Colr019001.CollateralParties10 *-- ISO20022.Colr019001.SecuritiesAccount19
    ISO20022.Colr019001.CollateralParties10 *-- ISO20022.Colr019001.PartyIdentification136
    ISO20022.Colr019001.CollateralParties10 *-- ISO20022.Colr019001.PartyIdentificationAndAccount203
    ISO20022.Colr019001.CollateralParties10 *-- ISO20022.Colr019001.PartyIdentificationAndAccount203
    ISO20022.Colr019001.CollateralParties10 *-- ISO20022.Colr019001.PartyIdentificationAndAccount202
    ISO20022.Colr019001.CollateralParties10 *-- ISO20022.Colr019001.PartyIdentificationAndAccount202
    class ISO20022.Colr019001.CollateralRole1Code {
        TAKE = 1
        GIVE = 2
    }
    class ISO20022.Colr019001.CollateralTransactionAmountBreakdown2 {
        + Prd  : ISO20022.Colr019001.Period4Choice
        + TxAmt  : ISO20022.Colr019001.ActiveOrHistoricCurrencyAndAmount
        + LotNb  : ISO20022.Colr019001.GenericIdentification178
    }
    ISO20022.Colr019001.CollateralTransactionAmountBreakdown2 *-- ISO20022.Colr019001.Period4Choice
    ISO20022.Colr019001.CollateralTransactionAmountBreakdown2 *-- ISO20022.Colr019001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Colr019001.CollateralTransactionAmountBreakdown2 *-- ISO20022.Colr019001.GenericIdentification178
    class ISO20022.Colr019001.CollateralTransactionType1Choice {
        + Prtry  : ISO20022.Colr019001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr019001.CollateralTransactionType1Choice *-- ISO20022.Colr019001.GenericIdentification30
    class ISO20022.Colr019001.CollateralTransactionType1Code {
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
    class ISO20022.Colr019001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Colr019001.CrystallisationDay1 {
        + Prd  : String
        + Day  : String
    }
    class ISO20022.Colr019001.Date3Choice {
        + Prtry  : ISO20022.Colr019001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr019001.Date3Choice *-- ISO20022.Colr019001.GenericIdentification30
    class ISO20022.Colr019001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Colr019001.DateType2Code {
        OPEN = 1
    }
    class ISO20022.Colr019001.DealTransactionDetails5 {
        + TermntnOptn  : String
        + OptnTp  : ISO20022.Colr019001.OptionType6Choice
        + Pmt  : String
        + DayCntBsis  : ISO20022.Colr019001.InterestComputationMethodFormat4Choice
        + Sprd  : Decimal
        + OvrnghtFrqcyRateFxg  : ISO20022.Colr019001.FrequencyRateFixing1Choice
        + PricgRateAndIndx  : ISO20022.Colr019001.RateOrName4Choice
        + DealDtlsAmt  : ISO20022.Colr019001.CollateralAmount18
        + ClsgDt  : ISO20022.Colr019001.ClosingDate4Choice
        + MinNtcePrd  : String
        + CncntrtnLmt  : String
        + PlcOfTrad  : ISO20022.Colr019001.PlaceOfTradeIdentification1
    }
    ISO20022.Colr019001.DealTransactionDetails5 *-- ISO20022.Colr019001.OptionType6Choice
    ISO20022.Colr019001.DealTransactionDetails5 *-- ISO20022.Colr019001.InterestComputationMethodFormat4Choice
    ISO20022.Colr019001.DealTransactionDetails5 *-- ISO20022.Colr019001.FrequencyRateFixing1Choice
    ISO20022.Colr019001.DealTransactionDetails5 *-- ISO20022.Colr019001.RateOrName4Choice
    ISO20022.Colr019001.DealTransactionDetails5 *-- ISO20022.Colr019001.CollateralAmount18
    ISO20022.Colr019001.DealTransactionDetails5 *-- ISO20022.Colr019001.ClosingDate4Choice
    ISO20022.Colr019001.DealTransactionDetails5 *-- ISO20022.Colr019001.PlaceOfTradeIdentification1
    class ISO20022.Colr019001.DeliveryReceiptType2Code {
        APMT = 1
        FREE = 2
    }
    class ISO20022.Colr019001.DocumentNumber5Choice {
        + PrtryNb  : ISO20022.Colr019001.GenericIdentification36
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Colr019001.DocumentNumber5Choice *-- ISO20022.Colr019001.GenericIdentification36
    class ISO20022.Colr019001.EventFrequency12Code {
        ONDE = 1
        WEEK = 2
        TWMN = 3
        SEMI = 4
        QUTR = 5
        MNTH = 6
        INDA = 7
        TOWK = 8
        TOMN = 9
        DAIL = 10
        YEAR = 11
        ADHO = 12
    }
    class ISO20022.Colr019001.ExposureType14Code {
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
    class ISO20022.Colr019001.ExposureType23Choice {
        + Prtry  : ISO20022.Colr019001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr019001.ExposureType23Choice *-- ISO20022.Colr019001.GenericIdentification30
    class ISO20022.Colr019001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Colr019001.ForeignExchangeTerms23 {
        + RsltgAmt  : ISO20022.Colr019001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Colr019001.ForeignExchangeTerms23 *-- ISO20022.Colr019001.ActiveCurrencyAndAmount
    class ISO20022.Colr019001.Frequency38Choice {
        + Prtry  : ISO20022.Colr019001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr019001.Frequency38Choice *-- ISO20022.Colr019001.GenericIdentification30
    class ISO20022.Colr019001.FrequencyRateFixing1Choice {
        + NbOfDays  : String
        + Cd  : String
    }
    class ISO20022.Colr019001.FrequencyRateFixing1Code {
        PRDC = 1
        OVNG = 2
        NONE = 3
    }
    class ISO20022.Colr019001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Colr019001.GenericIdentification178 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr019001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr019001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Colr019001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Colr019001.IdentificationType42Choice {
        + Prtry  : ISO20022.Colr019001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr019001.IdentificationType42Choice *-- ISO20022.Colr019001.GenericIdentification30
    class ISO20022.Colr019001.InterestComputationMethod2Code {
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
    class ISO20022.Colr019001.InterestComputationMethodFormat4Choice {
        + Prtry  : ISO20022.Colr019001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr019001.InterestComputationMethodFormat4Choice *-- ISO20022.Colr019001.GenericIdentification30
    class ISO20022.Colr019001.InterestRateIndexTenor2Code {
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
    class ISO20022.Colr019001.Linkages58 {
        + Refs  : ISO20022.Colr019001.References70Choice
        + MsgNb  : ISO20022.Colr019001.DocumentNumber5Choice
    }
    ISO20022.Colr019001.Linkages58 *-- ISO20022.Colr019001.References70Choice
    ISO20022.Colr019001.Linkages58 *-- ISO20022.Colr019001.DocumentNumber5Choice
    class ISO20022.Colr019001.MarketIdentification1Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Colr019001.MarketIdentification84 {
        + Tp  : ISO20022.Colr019001.MarketType8Choice
        + Id  : ISO20022.Colr019001.MarketIdentification1Choice
    }
    ISO20022.Colr019001.MarketIdentification84 *-- ISO20022.Colr019001.MarketType8Choice
    ISO20022.Colr019001.MarketIdentification84 *-- ISO20022.Colr019001.MarketIdentification1Choice
    class ISO20022.Colr019001.MarketType2Code {
        EXCH = 1
        VARI = 2
        OTCO = 3
        SECM = 4
        PRIM = 5
    }
    class ISO20022.Colr019001.MarketType8Choice {
        + Prtry  : ISO20022.Colr019001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr019001.MarketType8Choice *-- ISO20022.Colr019001.GenericIdentification30
    class ISO20022.Colr019001.NameAndAddress5 {
        + Adr  : ISO20022.Colr019001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Colr019001.NameAndAddress5 *-- ISO20022.Colr019001.PostalAddress1
    class ISO20022.Colr019001.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Colr019001.OptionType6Choice {
        + Prtry  : ISO20022.Colr019001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr019001.OptionType6Choice *-- ISO20022.Colr019001.GenericIdentification30
    class ISO20022.Colr019001.OtherIdentification1 {
        + Tp  : ISO20022.Colr019001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Colr019001.OtherIdentification1 *-- ISO20022.Colr019001.IdentificationSource3Choice
    class ISO20022.Colr019001.OtherParties38 {
        + Invstr  : global::System.Collections.Generic.List~ISO20022.Colr019001.PartyIdentification149~
        + Issr  : ISO20022.Colr019001.PartyIdentification136
    }
    ISO20022.Colr019001.OtherParties38 *-- ISO20022.Colr019001.PartyIdentification149
    ISO20022.Colr019001.OtherParties38 *-- ISO20022.Colr019001.PartyIdentification136
    class ISO20022.Colr019001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Colr019001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Colr019001.NameAndAddress5
        + PrtryId  : ISO20022.Colr019001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Colr019001.PartyIdentification120Choice *-- ISO20022.Colr019001.NameAndAddress5
    ISO20022.Colr019001.PartyIdentification120Choice *-- ISO20022.Colr019001.GenericIdentification36
    class ISO20022.Colr019001.PartyIdentification134Choice {
        + Ctry  : String
        + NmAndAdr  : ISO20022.Colr019001.NameAndAddress5
        + PrtryId  : ISO20022.Colr019001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Colr019001.PartyIdentification134Choice *-- ISO20022.Colr019001.NameAndAddress5
    ISO20022.Colr019001.PartyIdentification134Choice *-- ISO20022.Colr019001.GenericIdentification36
    class ISO20022.Colr019001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Colr019001.PartyIdentification120Choice
    }
    ISO20022.Colr019001.PartyIdentification136 *-- ISO20022.Colr019001.PartyIdentification120Choice
    class ISO20022.Colr019001.PartyIdentification149 {
        + LEI  : String
        + Id  : ISO20022.Colr019001.PartyIdentification134Choice
    }
    ISO20022.Colr019001.PartyIdentification149 *-- ISO20022.Colr019001.PartyIdentification134Choice
    class ISO20022.Colr019001.PartyIdentificationAndAccount202 {
        + PtyCpcty  : ISO20022.Colr019001.TradingPartyCapacity5Choice
        + AcctOwnr  : ISO20022.Colr019001.PartyIdentification136
        + BlckChainAdrOrWllt  : ISO20022.Colr019001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Colr019001.SecuritiesAccount19
        + AltrnId  : ISO20022.Colr019001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Colr019001.PartyIdentification120Choice
    }
    ISO20022.Colr019001.PartyIdentificationAndAccount202 *-- ISO20022.Colr019001.TradingPartyCapacity5Choice
    ISO20022.Colr019001.PartyIdentificationAndAccount202 *-- ISO20022.Colr019001.PartyIdentification136
    ISO20022.Colr019001.PartyIdentificationAndAccount202 *-- ISO20022.Colr019001.BlockChainAddressWallet3
    ISO20022.Colr019001.PartyIdentificationAndAccount202 *-- ISO20022.Colr019001.SecuritiesAccount19
    ISO20022.Colr019001.PartyIdentificationAndAccount202 *-- ISO20022.Colr019001.AlternatePartyIdentification7
    ISO20022.Colr019001.PartyIdentificationAndAccount202 *-- ISO20022.Colr019001.PartyIdentification120Choice
    class ISO20022.Colr019001.PartyIdentificationAndAccount203 {
        + PtyCpcty  : ISO20022.Colr019001.TradingPartyCapacity5Choice
        + BlckChainAdrOrWllt  : ISO20022.Colr019001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Colr019001.SecuritiesAccount19
        + AltrnId  : ISO20022.Colr019001.AlternatePartyIdentification7
        + LEI  : String
        + Id  : ISO20022.Colr019001.PartyIdentification120Choice
    }
    ISO20022.Colr019001.PartyIdentificationAndAccount203 *-- ISO20022.Colr019001.TradingPartyCapacity5Choice
    ISO20022.Colr019001.PartyIdentificationAndAccount203 *-- ISO20022.Colr019001.BlockChainAddressWallet3
    ISO20022.Colr019001.PartyIdentificationAndAccount203 *-- ISO20022.Colr019001.SecuritiesAccount19
    ISO20022.Colr019001.PartyIdentificationAndAccount203 *-- ISO20022.Colr019001.AlternatePartyIdentification7
    ISO20022.Colr019001.PartyIdentificationAndAccount203 *-- ISO20022.Colr019001.PartyIdentification120Choice
    class ISO20022.Colr019001.Period2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Colr019001.Period4Choice {
        + FrDtToDt  : ISO20022.Colr019001.Period2
        + ToDt  : DateTime
        + FrDt  : DateTime
        + Dt  : DateTime
    }
    ISO20022.Colr019001.Period4Choice *-- ISO20022.Colr019001.Period2
    class ISO20022.Colr019001.PlaceOfTradeIdentification1 {
        + LEI  : String
        + MktTpAndId  : ISO20022.Colr019001.MarketIdentification84
    }
    ISO20022.Colr019001.PlaceOfTradeIdentification1 *-- ISO20022.Colr019001.MarketIdentification84
    class ISO20022.Colr019001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Colr019001.RateOrName4Choice {
        + RateIndxDtls  : ISO20022.Colr019001.RateTypeAndLookback2
        + Rate  : Decimal
    }
    ISO20022.Colr019001.RateOrName4Choice *-- ISO20022.Colr019001.RateTypeAndLookback2
    class ISO20022.Colr019001.RateOrType1Choice {
        + Tp  : ISO20022.Colr019001.GenericIdentification1
        + Rate  : Decimal
    }
    ISO20022.Colr019001.RateOrType1Choice *-- ISO20022.Colr019001.GenericIdentification1
    class ISO20022.Colr019001.RateTypeAndLookback2 {
        + Ccy  : String
        + Tnr  : String
        + CrstllstnDt  : ISO20022.Colr019001.CrystallisationDay1
        + LookBckDays  : String
        + Tp  : ISO20022.Colr019001.BenchmarkCurveName13Choice
    }
    ISO20022.Colr019001.RateTypeAndLookback2 *-- ISO20022.Colr019001.CrystallisationDay1
    ISO20022.Colr019001.RateTypeAndLookback2 *-- ISO20022.Colr019001.BenchmarkCurveName13Choice
    class ISO20022.Colr019001.References70Choice {
        + TrptyAgtSvcPrvdrCollInstrId  : String
        + ClntCollInstrId  : String
    }
    class ISO20022.Colr019001.RepoTerminationOption1Code {
        ETSB = 1
        EGRN = 2
    }
    class ISO20022.Colr019001.ResponseStatus2Code {
        DKNY = 1
        CONF = 2
    }
    class ISO20022.Colr019001.ResponseStatus9Choice {
        + Prtry  : ISO20022.Colr019001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr019001.ResponseStatus9Choice *-- ISO20022.Colr019001.GenericIdentification30
    class ISO20022.Colr019001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Colr019001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Colr019001.SecuritiesAccount19 *-- ISO20022.Colr019001.GenericIdentification30
    class ISO20022.Colr019001.SecuritiesMovement9 {
        + TrptyAgtSvcPrvdrSctiesMvmntId  : String
        + ClntSctiesMvmntId  : String
        + CollMvmnt  : String
        + BlckChainAdrOrWllt  : ISO20022.Colr019001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Colr019001.SecuritiesAccount19
        + Qty  : ISO20022.Colr019001.FinancialInstrumentQuantity33Choice
        + FinInstrmId  : ISO20022.Colr019001.SecurityIdentification19
        + SctiesMvmntTp  : String
    }
    ISO20022.Colr019001.SecuritiesMovement9 *-- ISO20022.Colr019001.BlockChainAddressWallet3
    ISO20022.Colr019001.SecuritiesMovement9 *-- ISO20022.Colr019001.SecuritiesAccount19
    ISO20022.Colr019001.SecuritiesMovement9 *-- ISO20022.Colr019001.FinancialInstrumentQuantity33Choice
    ISO20022.Colr019001.SecuritiesMovement9 *-- ISO20022.Colr019001.SecurityIdentification19
    class ISO20022.Colr019001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Colr019001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Colr019001.SecurityIdentification19 *-- ISO20022.Colr019001.OtherIdentification1
    class ISO20022.Colr019001.SupplementaryData1 {
        + Envlp  : ISO20022.Colr019001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Colr019001.SupplementaryData1 *-- ISO20022.Colr019001.SupplementaryDataEnvelope1
    class ISO20022.Colr019001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Colr019001.TradingCapacity7Code {
        PRIN = 1
        AGEN = 2
    }
    class ISO20022.Colr019001.TradingPartyCapacity5Choice {
        + Prtry  : ISO20022.Colr019001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Colr019001.TradingPartyCapacity5Choice *-- ISO20022.Colr019001.GenericIdentification30
    class ISO20022.Colr019001.TransactionIdentifications45 {
        + CmonTxId  : String
        + TrptyAgtSvcPrvdrCollTxId  : String
        + TrptyAgtSvcPrvdrCollInstrId  : String
        + ClntCollTxId  : String
        + ClntCollInstrId  : String
    }
    class ISO20022.Colr019001.TripartyCollateralTransactionInstructionV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Colr019001.SupplementaryData1~
        + OthrPties  : ISO20022.Colr019001.OtherParties38
        + CshMvmnt  : global::System.Collections.Generic.List~ISO20022.Colr019001.CashMovement8~
        + SctiesMvmnt  : global::System.Collections.Generic.List~ISO20022.Colr019001.SecuritiesMovement9~
        + DealTxDt  : ISO20022.Colr019001.CollateralDate2
        + DealTxDtls  : ISO20022.Colr019001.DealTransactionDetails5
        + CollPties  : ISO20022.Colr019001.CollateralParties10
        + GnlParams  : ISO20022.Colr019001.CollateralParameters10
        + Pgntn  : ISO20022.Colr019001.Pagination1
        + Lnkgs  : global::System.Collections.Generic.List~ISO20022.Colr019001.Linkages58~
        + TxInstrId  : ISO20022.Colr019001.TransactionIdentifications45
    }
    ISO20022.Colr019001.TripartyCollateralTransactionInstructionV01 *-- ISO20022.Colr019001.SupplementaryData1
    ISO20022.Colr019001.TripartyCollateralTransactionInstructionV01 *-- ISO20022.Colr019001.OtherParties38
    ISO20022.Colr019001.TripartyCollateralTransactionInstructionV01 *-- ISO20022.Colr019001.CashMovement8
    ISO20022.Colr019001.TripartyCollateralTransactionInstructionV01 *-- ISO20022.Colr019001.SecuritiesMovement9
    ISO20022.Colr019001.TripartyCollateralTransactionInstructionV01 *-- ISO20022.Colr019001.CollateralDate2
    ISO20022.Colr019001.TripartyCollateralTransactionInstructionV01 *-- ISO20022.Colr019001.DealTransactionDetails5
    ISO20022.Colr019001.TripartyCollateralTransactionInstructionV01 *-- ISO20022.Colr019001.CollateralParties10
    ISO20022.Colr019001.TripartyCollateralTransactionInstructionV01 *-- ISO20022.Colr019001.CollateralParameters10
    ISO20022.Colr019001.TripartyCollateralTransactionInstructionV01 *-- ISO20022.Colr019001.Pagination1
    ISO20022.Colr019001.TripartyCollateralTransactionInstructionV01 *-- ISO20022.Colr019001.Linkages58
    ISO20022.Colr019001.TripartyCollateralTransactionInstructionV01 *-- ISO20022.Colr019001.TransactionIdentifications45
    class ISO20022.Colr019001.TypeOfIdentification1Code {
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

## Value ISO20022.Colr019001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Colr019001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Colr019001.AdditionalInformation24


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Note|String||XmlElement()||
|+|CollInstr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Colr019001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Colr019001.AlternatePartyIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Colr019001.IdentificationType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Colr019001.AmountAndDirection49


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Colr019001.ForeignExchangeTerms23||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Colr019001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Colr019001.ActiveCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Colr019001.BasketIdentificationAndEligibilitySetProfile1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ElgbltySetPrfl|ISO20022.Colr019001.GenericIdentification1||XmlElement()||
|+|ExclsnBsktId|ISO20022.Colr019001.GenericIdentification1||XmlElement()||
|+|FllbckStartgBsktId|ISO20022.Colr019001.GenericIdentification1||XmlElement()||
|+|PrfrntlBsktIdNb|ISO20022.Colr019001.GenericIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ElgbltySetPrfl),validElement(ExclsnBsktId),validElement(FllbckStartgBsktId),validElement(PrfrntlBsktIdNb))|

---

## Value ISO20022.Colr019001.BenchmarkCurveName13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr019001.GenericIdentification1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Colr019001.BenchmarkCurveName7Code


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

## Value ISO20022.Colr019001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr019001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Colr019001.CalculationMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COMP|Int32||XmlEnum("""COMP""")|1|
||SIMP|Int32||XmlEnum("""SIMP""")|2|

---

## Value ISO20022.Colr019001.CashAccountIdentification5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|IBAN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""IBAN""",IBAN,"""[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}"""),validChoice(Prtry,IBAN))|

---

## Value ISO20022.Colr019001.CashMovement8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrptyAgtSvcPrvdrCshMvmntId|String||XmlElement()||
|+|ClntCshMvmntId|String||XmlElement()||
|+|CollMvmnt|String||XmlElement()||
|+|CshAcct|ISO20022.Colr019001.CashAccountIdentification5Choice||XmlElement()||
|+|CshAmt|ISO20022.Colr019001.ActiveCurrencyAndAmount||XmlElement()||
|+|CshMvmnt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CshAcct),validElement(CshAmt))|

---

## Value ISO20022.Colr019001.ClosingDate4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|ISO20022.Colr019001.Date3Choice||XmlElement()||
|+|Dt|ISO20022.Colr019001.DateAndDateTime2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Cd),validElement(Dt),validChoice(Cd,Dt))|

---

## Value ISO20022.Colr019001.CollateralAmount18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ValSght|ISO20022.Colr019001.AmountAndDirection49||XmlElement()||
|+|TxAmtBrkdwn|global::System.Collections.Generic.List<ISO20022.Colr019001.CollateralTransactionAmountBreakdown2>||XmlElement()||
|+|IntrstPmtDely|String||XmlElement()||
|+|PmtFrqcy|ISO20022.Colr019001.Frequency38Choice||XmlElement()||
|+|CmpndSmplAcrlClctn|String||XmlElement()||
|+|Acrd|ISO20022.Colr019001.AmountAndDirection49||XmlElement()||
|+|Termntn|ISO20022.Colr019001.AmountAndDirection49||XmlElement()||
|+|Tx|ISO20022.Colr019001.AmountAndDirection49||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValSght),validList("""TxAmtBrkdwn""",TxAmtBrkdwn),validElement(TxAmtBrkdwn),validPattern("""IntrstPmtDely""",IntrstPmtDely,"""[0-9]{1,3}"""),validElement(PmtFrqcy),validElement(Acrd),validElement(Termntn),validElement(Tx))|

---

## Value ISO20022.Colr019001.CollateralDate2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SttlmDt|DateTime||XmlElement()||
|+|ReqdExctnDt|ISO20022.Colr019001.DateAndDateTime2Choice||XmlElement()||
|+|TradDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ReqdExctnDt))|

---

## Enum ISO20022.Colr019001.CollateralEntryType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RECE|Int32||XmlEnum("""RECE""")|1|
||DELI|Int32||XmlEnum("""DELI""")|2|

---

## Value ISO20022.Colr019001.CollateralParameters10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Colr019001.AdditionalInformation24||XmlElement()||
|+|RspnSts|ISO20022.Colr019001.ResponseStatus9Choice||XmlElement()||
|+|BsktIdAndElgbltySetPrfl|ISO20022.Colr019001.BasketIdentificationAndEligibilitySetProfile1||XmlElement()||
|+|MainTradgAcctCollstn|String||XmlElement()||
|+|FaildSttlmSlvtn|String||XmlElement()||
|+|AutomtcAllcn|String||XmlElement()||
|+|Prty|ISO20022.Colr019001.GenericIdentification30||XmlElement()||
|+|SttlmPrc|ISO20022.Colr019001.GenericIdentification30||XmlElement()||
|+|TrfTitl|String||XmlElement()||
|+|ValSghtMrgnRate|ISO20022.Colr019001.RateOrType1Choice||XmlElement()||
|+|CollSd|String||XmlElement()||
|+|XpsrTp|ISO20022.Colr019001.ExposureType23Choice||XmlElement()||
|+|CollInstrTp|ISO20022.Colr019001.CollateralTransactionType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(RspnSts),validElement(BsktIdAndElgbltySetPrfl),validElement(Prty),validElement(SttlmPrc),validElement(ValSghtMrgnRate),validElement(XpsrTp),validElement(CollInstrTp))|

---

## Value ISO20022.Colr019001.CollateralParties10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CollAcct|ISO20022.Colr019001.SecuritiesAccount19||XmlElement()||
|+|TrptyAgt|ISO20022.Colr019001.PartyIdentification136||XmlElement()||
|+|ClntPtyB|ISO20022.Colr019001.PartyIdentificationAndAccount203||XmlElement()||
|+|PtyB|ISO20022.Colr019001.PartyIdentificationAndAccount203||XmlElement()||
|+|ClntPtyA|ISO20022.Colr019001.PartyIdentificationAndAccount202||XmlElement()||
|+|PtyA|ISO20022.Colr019001.PartyIdentificationAndAccount202||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CollAcct),validElement(TrptyAgt),validElement(ClntPtyB),validElement(PtyB),validElement(ClntPtyA),validElement(PtyA))|

---

## Enum ISO20022.Colr019001.CollateralRole1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TAKE|Int32||XmlEnum("""TAKE""")|1|
||GIVE|Int32||XmlEnum("""GIVE""")|2|

---

## Value ISO20022.Colr019001.CollateralTransactionAmountBreakdown2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prd|ISO20022.Colr019001.Period4Choice||XmlElement()||
|+|TxAmt|ISO20022.Colr019001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|LotNb|ISO20022.Colr019001.GenericIdentification178||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prd),validElement(TxAmt),validElement(LotNb))|

---

## Value ISO20022.Colr019001.CollateralTransactionType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr019001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Colr019001.CollateralTransactionType1Code


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

## Enum ISO20022.Colr019001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Colr019001.CrystallisationDay1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prd|String||XmlElement()||
|+|Day|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prd""",Prd,"""[0-9]{1,3}"""))|

---

## Value ISO20022.Colr019001.Date3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr019001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr019001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Enum ISO20022.Colr019001.DateType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPEN|Int32||XmlEnum("""OPEN""")|1|

---

## Value ISO20022.Colr019001.DealTransactionDetails5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TermntnOptn|String||XmlElement()||
|+|OptnTp|ISO20022.Colr019001.OptionType6Choice||XmlElement()||
|+|Pmt|String||XmlElement()||
|+|DayCntBsis|ISO20022.Colr019001.InterestComputationMethodFormat4Choice||XmlElement()||
|+|Sprd|Decimal||XmlElement()||
|+|OvrnghtFrqcyRateFxg|ISO20022.Colr019001.FrequencyRateFixing1Choice||XmlElement()||
|+|PricgRateAndIndx|ISO20022.Colr019001.RateOrName4Choice||XmlElement()||
|+|DealDtlsAmt|ISO20022.Colr019001.CollateralAmount18||XmlElement()||
|+|ClsgDt|ISO20022.Colr019001.ClosingDate4Choice||XmlElement()||
|+|MinNtcePrd|String||XmlElement()||
|+|CncntrtnLmt|String||XmlElement()||
|+|PlcOfTrad|ISO20022.Colr019001.PlaceOfTradeIdentification1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(OptnTp),validElement(DayCntBsis),validElement(OvrnghtFrqcyRateFxg),validElement(PricgRateAndIndx),validElement(DealDtlsAmt),validElement(ClsgDt),validPattern("""MinNtcePrd""",MinNtcePrd,"""[0-9]{3}"""),validElement(PlcOfTrad))|

---

## Enum ISO20022.Colr019001.DeliveryReceiptType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||APMT|Int32||XmlEnum("""APMT""")|1|
||FREE|Int32||XmlEnum("""FREE""")|2|

---

## Type ISO20022.Colr019001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrptyCollTxInstr|ISO20022.Colr019001.TripartyCollateralTransactionInstructionV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TrptyCollTxInstr))|

---

## Value ISO20022.Colr019001.DocumentNumber5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Colr019001.GenericIdentification36||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Enum ISO20022.Colr019001.EventFrequency12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ONDE|Int32||XmlEnum("""ONDE""")|1|
||WEEK|Int32||XmlEnum("""WEEK""")|2|
||TWMN|Int32||XmlEnum("""TWMN""")|3|
||SEMI|Int32||XmlEnum("""SEMI""")|4|
||QUTR|Int32||XmlEnum("""QUTR""")|5|
||MNTH|Int32||XmlEnum("""MNTH""")|6|
||INDA|Int32||XmlEnum("""INDA""")|7|
||TOWK|Int32||XmlEnum("""TOWK""")|8|
||TOMN|Int32||XmlEnum("""TOMN""")|9|
||DAIL|Int32||XmlEnum("""DAIL""")|10|
||YEAR|Int32||XmlEnum("""YEAR""")|11|
||ADHO|Int32||XmlEnum("""ADHO""")|12|

---

## Enum ISO20022.Colr019001.ExposureType14Code


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

## Value ISO20022.Colr019001.ExposureType23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr019001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr019001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Colr019001.ForeignExchangeTerms23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Colr019001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Colr019001.Frequency38Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr019001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr019001.FrequencyRateFixing1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NbOfDays|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""NbOfDays""",NbOfDays,"""[0-9]{1,3}"""),validChoice(NbOfDays,Cd))|

---

## Enum ISO20022.Colr019001.FrequencyRateFixing1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRDC|Int32||XmlEnum("""PRDC""")|1|
||OVNG|Int32||XmlEnum("""OVNG""")|2|
||NONE|Int32||XmlEnum("""NONE""")|3|

---

## Value ISO20022.Colr019001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr019001.GenericIdentification178


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr019001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Colr019001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr019001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr019001.IdentificationType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr019001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Colr019001.InterestComputationMethod2Code


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

## Value ISO20022.Colr019001.InterestComputationMethodFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr019001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Colr019001.InterestRateIndexTenor2Code


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

## Value ISO20022.Colr019001.Linkages58


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Refs|ISO20022.Colr019001.References70Choice||XmlElement()||
|+|MsgNb|ISO20022.Colr019001.DocumentNumber5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Refs),validElement(MsgNb))|

---

## Value ISO20022.Colr019001.MarketIdentification1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Colr019001.MarketIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Colr019001.MarketType8Choice||XmlElement()||
|+|Id|ISO20022.Colr019001.MarketIdentification1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validElement(Id))|

---

## Enum ISO20022.Colr019001.MarketType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EXCH|Int32||XmlEnum("""EXCH""")|1|
||VARI|Int32||XmlEnum("""VARI""")|2|
||OTCO|Int32||XmlEnum("""OTCO""")|3|
||SECM|Int32||XmlEnum("""SECM""")|4|
||PRIM|Int32||XmlEnum("""PRIM""")|5|

---

## Value ISO20022.Colr019001.MarketType8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr019001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr019001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Colr019001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Colr019001.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Colr019001.OptionType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr019001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr019001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Colr019001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr019001.OtherParties38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Invstr|global::System.Collections.Generic.List<ISO20022.Colr019001.PartyIdentification149>||XmlElement()||
|+|Issr|ISO20022.Colr019001.PartyIdentification136||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Invstr""",Invstr),validElement(Invstr),validElement(Issr))|

---

## Value ISO20022.Colr019001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Colr019001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Colr019001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Colr019001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Colr019001.PartyIdentification134Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|NmAndAdr|ISO20022.Colr019001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Colr019001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(Ctry,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Colr019001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Colr019001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Colr019001.PartyIdentification149


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Colr019001.PartyIdentification134Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Colr019001.PartyIdentificationAndAccount202


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCpcty|ISO20022.Colr019001.TradingPartyCapacity5Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Colr019001.PartyIdentification136||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Colr019001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Colr019001.SecuritiesAccount19||XmlElement()||
|+|AltrnId|ISO20022.Colr019001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Colr019001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyCpcty),validElement(AcctOwnr),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Colr019001.PartyIdentificationAndAccount203


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PtyCpcty|ISO20022.Colr019001.TradingPartyCapacity5Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Colr019001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Colr019001.SecuritiesAccount19||XmlElement()||
|+|AltrnId|ISO20022.Colr019001.AlternatePartyIdentification7||XmlElement()||
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Colr019001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PtyCpcty),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AltrnId),validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Colr019001.Period2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Colr019001.Period4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrDtToDt|ISO20022.Colr019001.Period2||XmlElement()||
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrDtToDt),validChoice(FrDtToDt,ToDt,FrDt,Dt))|

---

## Value ISO20022.Colr019001.PlaceOfTradeIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|MktTpAndId|ISO20022.Colr019001.MarketIdentification84||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(MktTpAndId))|

---

## Value ISO20022.Colr019001.PostalAddress1


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

## Value ISO20022.Colr019001.RateOrName4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateIndxDtls|ISO20022.Colr019001.RateTypeAndLookback2||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateIndxDtls),validChoice(RateIndxDtls,Rate))|

---

## Value ISO20022.Colr019001.RateOrType1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Colr019001.GenericIdentification1||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validChoice(Tp,Rate))|

---

## Value ISO20022.Colr019001.RateTypeAndLookback2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ccy|String||XmlElement()||
|+|Tnr|String||XmlElement()||
|+|CrstllstnDt|ISO20022.Colr019001.CrystallisationDay1||XmlElement()||
|+|LookBckDays|String||XmlElement()||
|+|Tp|ISO20022.Colr019001.BenchmarkCurveName13Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""),validElement(CrstllstnDt),validPattern("""LookBckDays""",LookBckDays,"""[0-9]{1,3}"""),validElement(Tp))|

---

## Value ISO20022.Colr019001.References70Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrptyAgtSvcPrvdrCollInstrId|String||XmlElement()||
|+|ClntCollInstrId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(TrptyAgtSvcPrvdrCollInstrId,ClntCollInstrId))|

---

## Enum ISO20022.Colr019001.RepoTerminationOption1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ETSB|Int32||XmlEnum("""ETSB""")|1|
||EGRN|Int32||XmlEnum("""EGRN""")|2|

---

## Enum ISO20022.Colr019001.ResponseStatus2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DKNY|Int32||XmlEnum("""DKNY""")|1|
||CONF|Int32||XmlEnum("""CONF""")|2|

---

## Value ISO20022.Colr019001.ResponseStatus9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr019001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr019001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Colr019001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Colr019001.SecuritiesMovement9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TrptyAgtSvcPrvdrSctiesMvmntId|String||XmlElement()||
|+|ClntSctiesMvmntId|String||XmlElement()||
|+|CollMvmnt|String||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Colr019001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Colr019001.SecuritiesAccount19||XmlElement()||
|+|Qty|ISO20022.Colr019001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Colr019001.SecurityIdentification19||XmlElement()||
|+|SctiesMvmntTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(Qty),validElement(FinInstrmId))|

---

## Value ISO20022.Colr019001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Colr019001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Colr019001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Colr019001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Colr019001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Colr019001.TradingCapacity7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRIN|Int32||XmlEnum("""PRIN""")|1|
||AGEN|Int32||XmlEnum("""AGEN""")|2|

---

## Value ISO20022.Colr019001.TradingPartyCapacity5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Colr019001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Colr019001.TransactionIdentifications45


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CmonTxId|String||XmlElement()||
|+|TrptyAgtSvcPrvdrCollTxId|String||XmlElement()||
|+|TrptyAgtSvcPrvdrCollInstrId|String||XmlElement()||
|+|ClntCollTxId|String||XmlElement()||
|+|ClntCollInstrId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Aspect ISO20022.Colr019001.TripartyCollateralTransactionInstructionV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Colr019001.SupplementaryData1>||XmlElement()||
|+|OthrPties|ISO20022.Colr019001.OtherParties38||XmlElement()||
|+|CshMvmnt|global::System.Collections.Generic.List<ISO20022.Colr019001.CashMovement8>||XmlElement()||
|+|SctiesMvmnt|global::System.Collections.Generic.List<ISO20022.Colr019001.SecuritiesMovement9>||XmlElement()||
|+|DealTxDt|ISO20022.Colr019001.CollateralDate2||XmlElement()||
|+|DealTxDtls|ISO20022.Colr019001.DealTransactionDetails5||XmlElement()||
|+|CollPties|ISO20022.Colr019001.CollateralParties10||XmlElement()||
|+|GnlParams|ISO20022.Colr019001.CollateralParameters10||XmlElement()||
|+|Pgntn|ISO20022.Colr019001.Pagination1||XmlElement()||
|+|Lnkgs|global::System.Collections.Generic.List<ISO20022.Colr019001.Linkages58>||XmlElement()||
|+|TxInstrId|ISO20022.Colr019001.TransactionIdentifications45||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(OthrPties),validList("""CshMvmnt""",CshMvmnt),validElement(CshMvmnt),validList("""SctiesMvmnt""",SctiesMvmnt),validElement(SctiesMvmnt),validElement(DealTxDt),validElement(DealTxDtls),validElement(CollPties),validElement(GnlParams),validElement(Pgntn),validList("""Lnkgs""",Lnkgs),validElement(Lnkgs),validElement(TxInstrId))|

---

## Enum ISO20022.Colr019001.TypeOfIdentification1Code


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

