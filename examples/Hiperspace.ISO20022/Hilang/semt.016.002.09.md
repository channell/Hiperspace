# semt.016.002.09
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt016002.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt016002.AmountAndDirection55 {
        + FXDtls  : ISO20022.Semt016002.ForeignExchangeTerms23
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Semt016002.RestrictedFINActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Semt016002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Semt016002.AmountAndDirection55 *-- ISO20022.Semt016002.ForeignExchangeTerms23
    ISO20022.Semt016002.AmountAndDirection55 *-- ISO20022.Semt016002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    ISO20022.Semt016002.AmountAndDirection55 *-- ISO20022.Semt016002.RestrictedFINActiveOrHistoricCurrencyAndAmount
    class ISO20022.Semt016002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Semt016002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Semt016002.BlockChainAddressWallet7 *-- ISO20022.Semt016002.GenericIdentification47
    class ISO20022.Semt016002.ClassificationType33Choice {
        + AltrnClssfctn  : ISO20022.Semt016002.GenericIdentification86
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Semt016002.ClassificationType33Choice *-- ISO20022.Semt016002.GenericIdentification86
    class ISO20022.Semt016002.CorporateActionEventType101Choice {
        + Prtry  : ISO20022.Semt016002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt016002.CorporateActionEventType101Choice *-- ISO20022.Semt016002.GenericIdentification47
    class ISO20022.Semt016002.CorporateActionEventType33Code {
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
    class ISO20022.Semt016002.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Semt016002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Semt016002.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Semt016002.EventFrequency3Code {
        WEEK = 1
        SEMI = 2
        QUTR = 3
        MNTH = 4
        YEAR = 5
    }
    class ISO20022.Semt016002.EventFrequency4Code {
        WEEK = 1
        INDA = 2
        DAIL = 3
        MNTH = 4
        ADHO = 5
        YEAR = 6
    }
    class ISO20022.Semt016002.FinancialInstrumentAttributes119 {
        + FinInstrmAttrAddtlDtls  : String
        + UndrlygFinInstrmId  : global::System.Collections.Generic.List~ISO20022.Semt016002.SecurityIdentification32~
        + CtrctSz  : ISO20022.Semt016002.FinancialInstrumentQuantity36Choice
        + MinNmnlQty  : ISO20022.Semt016002.FinancialInstrumentQuantity36Choice
        + StrkPric  : ISO20022.Semt016002.Price3
        + ConvsPric  : ISO20022.Semt016002.Price3
        + SbcptPric  : ISO20022.Semt016002.Price3
        + ExrcPric  : ISO20022.Semt016002.Price3
        + MktOrIndctvPric  : ISO20022.Semt016002.PriceType5Choice
        + PutblInd  : String
        + CllblInd  : String
        + VarblRateInd  : String
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt016002.QuantityBreakdown64~
        + PoolNb  : ISO20022.Semt016002.GenericIdentification39
        + CpnAttchdNb  : ISO20022.Semt016002.Number23Choice
        + IndxRateBsis  : Decimal
        + NxtIntrstRate  : Decimal
        + YldToMtrtyRate  : Decimal
        + IntrstRate  : Decimal
        + NxtFctr  : Decimal
        + CurFctr  : Decimal
        + PrvsFctr  : Decimal
        + FrstPmtDt  : DateTime
        + DtdDt  : DateTime
        + PutblDt  : DateTime
        + NxtCllblDt  : DateTime
        + IsseDt  : DateTime
        + MtrtyDt  : DateTime
        + FltgRateFxgDt  : DateTime
        + XpryDt  : DateTime
        + CpnDt  : DateTime
        + DnmtnCcy  : String
        + OptnTp  : ISO20022.Semt016002.OptionType7Choice
        + OptnStyle  : ISO20022.Semt016002.OptionStyle9Choice
        + ClssfctnTp  : ISO20022.Semt016002.ClassificationType33Choice
        + VarblRateChngFrqcy  : ISO20022.Semt016002.Frequency27Choice
        + PmtSts  : ISO20022.Semt016002.SecuritiesPaymentStatus6Choice
        + PmtFrqcy  : ISO20022.Semt016002.Frequency27Choice
        + RegnForm  : ISO20022.Semt016002.FormOfSecurity7Choice
        + DayCntBsis  : ISO20022.Semt016002.InterestComputationMethodFormat5Choice
        + PlcOfListg  : ISO20022.Semt016002.MarketIdentification4Choice
    }
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.SecurityIdentification32
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.FinancialInstrumentQuantity36Choice
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.FinancialInstrumentQuantity36Choice
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.Price3
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.Price3
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.Price3
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.Price3
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.PriceType5Choice
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.QuantityBreakdown64
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.GenericIdentification39
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.Number23Choice
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.OptionType7Choice
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.OptionStyle9Choice
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.ClassificationType33Choice
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.Frequency27Choice
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.SecuritiesPaymentStatus6Choice
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.Frequency27Choice
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.FormOfSecurity7Choice
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.InterestComputationMethodFormat5Choice
    ISO20022.Semt016002.FinancialInstrumentAttributes119 *-- ISO20022.Semt016002.MarketIdentification4Choice
    class ISO20022.Semt016002.FinancialInstrumentDetails44 {
        + SubBal  : global::System.Collections.Generic.List~ISO20022.Semt016002.IntraPositionDetails63~
        + FinInstrmAttrbts  : ISO20022.Semt016002.FinancialInstrumentAttributes119
        + FinInstrmId  : ISO20022.Semt016002.SecurityIdentification20
    }
    ISO20022.Semt016002.FinancialInstrumentDetails44 *-- ISO20022.Semt016002.IntraPositionDetails63
    ISO20022.Semt016002.FinancialInstrumentDetails44 *-- ISO20022.Semt016002.FinancialInstrumentAttributes119
    ISO20022.Semt016002.FinancialInstrumentDetails44 *-- ISO20022.Semt016002.SecurityIdentification20
    class ISO20022.Semt016002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Semt016002.ForeignExchangeTerms23 {
        + RsltgAmt  : ISO20022.Semt016002.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Semt016002.ForeignExchangeTerms23 *-- ISO20022.Semt016002.ActiveCurrencyAndAmount
    class ISO20022.Semt016002.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Semt016002.FormOfSecurity7Choice {
        + Prtry  : ISO20022.Semt016002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt016002.FormOfSecurity7Choice *-- ISO20022.Semt016002.GenericIdentification47
    class ISO20022.Semt016002.Frequency26Choice {
        + Prtry  : ISO20022.Semt016002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt016002.Frequency26Choice *-- ISO20022.Semt016002.GenericIdentification47
    class ISO20022.Semt016002.Frequency27Choice {
        + Prtry  : ISO20022.Semt016002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt016002.Frequency27Choice *-- ISO20022.Semt016002.GenericIdentification47
    class ISO20022.Semt016002.GenericIdentification18 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Semt016002.GenericIdentification39 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt016002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt016002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt016002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Semt016002.GenericIdentification47
    }
    ISO20022.Semt016002.GenericIdentification85 *-- ISO20022.Semt016002.GenericIdentification47
    class ISO20022.Semt016002.GenericIdentification86 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt016002.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt016002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt016002.InterestComputationMethod2Code {
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
    class ISO20022.Semt016002.InterestComputationMethodFormat5Choice {
        + Prtry  : ISO20022.Semt016002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt016002.InterestComputationMethodFormat5Choice *-- ISO20022.Semt016002.GenericIdentification47
    class ISO20022.Semt016002.IntraPositionDetails63 {
        + IntraPosMvmnt  : global::System.Collections.Generic.List~ISO20022.Semt016002.IntraPositionMovementDetails20~
        + BalFr  : ISO20022.Semt016002.SecuritiesBalanceType8Choice
        + SfkpgPlc  : ISO20022.Semt016002.SafekeepingPlaceFormat39Choice
    }
    ISO20022.Semt016002.IntraPositionDetails63 *-- ISO20022.Semt016002.IntraPositionMovementDetails20
    ISO20022.Semt016002.IntraPositionDetails63 *-- ISO20022.Semt016002.SecuritiesBalanceType8Choice
    ISO20022.Semt016002.IntraPositionDetails63 *-- ISO20022.Semt016002.SafekeepingPlaceFormat39Choice
    class ISO20022.Semt016002.IntraPositionMovementDetails20 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt016002.SupplementaryData1~
        + InstrPrcgAddtlDtls  : String
        + CollMntrAmt  : ISO20022.Semt016002.AmountAndDirection55
        + CorpActnEvtTp  : ISO20022.Semt016002.CorporateActionEventType101Choice
        + AckdStsTmStmp  : DateTime
        + AvlblDt  : ISO20022.Semt016002.DateAndDateTime2Choice
        + SttlmDt  : ISO20022.Semt016002.DateAndDateTime2Choice
        + BalTo  : ISO20022.Semt016002.SecuritiesBalanceType8Choice
        + SctiesSubBalId  : ISO20022.Semt016002.GenericIdentification39
        + RmngToBeSttldQty  : ISO20022.Semt016002.FinancialInstrumentQuantity36Choice
        + PrevslySttldQty  : ISO20022.Semt016002.FinancialInstrumentQuantity36Choice
        + SttldQty  : ISO20022.Semt016002.FinancialInstrumentQuantity36Choice
        + Id  : ISO20022.Semt016002.References75Choice
    }
    ISO20022.Semt016002.IntraPositionMovementDetails20 *-- ISO20022.Semt016002.SupplementaryData1
    ISO20022.Semt016002.IntraPositionMovementDetails20 *-- ISO20022.Semt016002.AmountAndDirection55
    ISO20022.Semt016002.IntraPositionMovementDetails20 *-- ISO20022.Semt016002.CorporateActionEventType101Choice
    ISO20022.Semt016002.IntraPositionMovementDetails20 *-- ISO20022.Semt016002.DateAndDateTime2Choice
    ISO20022.Semt016002.IntraPositionMovementDetails20 *-- ISO20022.Semt016002.DateAndDateTime2Choice
    ISO20022.Semt016002.IntraPositionMovementDetails20 *-- ISO20022.Semt016002.SecuritiesBalanceType8Choice
    ISO20022.Semt016002.IntraPositionMovementDetails20 *-- ISO20022.Semt016002.GenericIdentification39
    ISO20022.Semt016002.IntraPositionMovementDetails20 *-- ISO20022.Semt016002.FinancialInstrumentQuantity36Choice
    ISO20022.Semt016002.IntraPositionMovementDetails20 *-- ISO20022.Semt016002.FinancialInstrumentQuantity36Choice
    ISO20022.Semt016002.IntraPositionMovementDetails20 *-- ISO20022.Semt016002.FinancialInstrumentQuantity36Choice
    ISO20022.Semt016002.IntraPositionMovementDetails20 *-- ISO20022.Semt016002.References75Choice
    class ISO20022.Semt016002.IntraPositionMovementPostingReport002V09 {
        + FinInstrm  : global::System.Collections.Generic.List~ISO20022.Semt016002.FinancialInstrumentDetails44~
        + BlckChainAdrOrWllt  : ISO20022.Semt016002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Semt016002.SecuritiesAccount30
        + AcctOwnr  : ISO20022.Semt016002.PartyIdentification136Choice
        + StmtGnlDtls  : ISO20022.Semt016002.Statement81
        + Pgntn  : ISO20022.Semt016002.Pagination1
    }
    ISO20022.Semt016002.IntraPositionMovementPostingReport002V09 *-- ISO20022.Semt016002.FinancialInstrumentDetails44
    ISO20022.Semt016002.IntraPositionMovementPostingReport002V09 *-- ISO20022.Semt016002.BlockChainAddressWallet7
    ISO20022.Semt016002.IntraPositionMovementPostingReport002V09 *-- ISO20022.Semt016002.SecuritiesAccount30
    ISO20022.Semt016002.IntraPositionMovementPostingReport002V09 *-- ISO20022.Semt016002.PartyIdentification136Choice
    ISO20022.Semt016002.IntraPositionMovementPostingReport002V09 *-- ISO20022.Semt016002.Statement81
    ISO20022.Semt016002.IntraPositionMovementPostingReport002V09 *-- ISO20022.Semt016002.Pagination1
    class ISO20022.Semt016002.MarketIdentification4Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Semt016002.Number23Choice {
        + Lng  : ISO20022.Semt016002.GenericIdentification18
        + Shrt  : String
    }
    ISO20022.Semt016002.Number23Choice *-- ISO20022.Semt016002.GenericIdentification18
    class ISO20022.Semt016002.Number3Choice {
        + Lng  : String
        + Shrt  : String
    }
    class ISO20022.Semt016002.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Semt016002.OptionStyle9Choice {
        + Prtry  : ISO20022.Semt016002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt016002.OptionStyle9Choice *-- ISO20022.Semt016002.GenericIdentification47
    class ISO20022.Semt016002.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Semt016002.OptionType7Choice {
        + Prtry  : ISO20022.Semt016002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt016002.OptionType7Choice *-- ISO20022.Semt016002.GenericIdentification47
    class ISO20022.Semt016002.OtherIdentification2 {
        + Tp  : ISO20022.Semt016002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Semt016002.OtherIdentification2 *-- ISO20022.Semt016002.IdentificationSource4Choice
    class ISO20022.Semt016002.OtherIdentification3 {
        + Tp  : ISO20022.Semt016002.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Semt016002.OtherIdentification3 *-- ISO20022.Semt016002.IdentificationSource3Choice
    class ISO20022.Semt016002.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Semt016002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Semt016002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Semt016002.PartyIdentification136Choice *-- ISO20022.Semt016002.GenericIdentification84
    class ISO20022.Semt016002.Period2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Semt016002.Period7Choice {
        + FrDtToDt  : ISO20022.Semt016002.Period2
        + FrDtTmToDtTm  : ISO20022.Semt016002.DateTimePeriod1
    }
    ISO20022.Semt016002.Period7Choice *-- ISO20022.Semt016002.Period2
    ISO20022.Semt016002.Period7Choice *-- ISO20022.Semt016002.DateTimePeriod1
    class ISO20022.Semt016002.Price3 {
        + Val  : ISO20022.Semt016002.PriceRateOrAmount1Choice
        + Tp  : ISO20022.Semt016002.YieldedOrValueType1Choice
    }
    ISO20022.Semt016002.Price3 *-- ISO20022.Semt016002.PriceRateOrAmount1Choice
    ISO20022.Semt016002.Price3 *-- ISO20022.Semt016002.YieldedOrValueType1Choice
    class ISO20022.Semt016002.PriceRateOrAmount1Choice {
        + Amt  : ISO20022.Semt016002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Semt016002.PriceRateOrAmount1Choice *-- ISO20022.Semt016002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Semt016002.PriceType5Choice {
        + Indctv  : ISO20022.Semt016002.Price3
        + Mkt  : ISO20022.Semt016002.Price3
    }
    ISO20022.Semt016002.PriceType5Choice *-- ISO20022.Semt016002.Price3
    ISO20022.Semt016002.PriceType5Choice *-- ISO20022.Semt016002.Price3
    class ISO20022.Semt016002.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Semt016002.QuantityBreakdown64 {
        + LotQty  : ISO20022.Semt016002.FinancialInstrumentQuantity36Choice
        + LotNb  : ISO20022.Semt016002.GenericIdentification39
    }
    ISO20022.Semt016002.QuantityBreakdown64 *-- ISO20022.Semt016002.FinancialInstrumentQuantity36Choice
    ISO20022.Semt016002.QuantityBreakdown64 *-- ISO20022.Semt016002.GenericIdentification39
    class ISO20022.Semt016002.References75Choice {
        + PrcrTxId  : String
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + PoolId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    class ISO20022.Semt016002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt016002.RestrictedFINActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt016002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Semt016002.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Semt016002.SafekeepingPlaceFormat39Choice {
        + Prtry  : ISO20022.Semt016002.GenericIdentification85
        + TpAndId  : ISO20022.Semt016002.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Semt016002.SafekeepingPlaceTypeAndText15
    }
    ISO20022.Semt016002.SafekeepingPlaceFormat39Choice *-- ISO20022.Semt016002.GenericIdentification85
    ISO20022.Semt016002.SafekeepingPlaceFormat39Choice *-- ISO20022.Semt016002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Semt016002.SafekeepingPlaceFormat39Choice *-- ISO20022.Semt016002.SafekeepingPlaceTypeAndText15
    class ISO20022.Semt016002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt016002.SafekeepingPlaceTypeAndText15 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt016002.SecuritiesAccount30 {
        + Nm  : String
        + Tp  : ISO20022.Semt016002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Semt016002.SecuritiesAccount30 *-- ISO20022.Semt016002.GenericIdentification47
    class ISO20022.Semt016002.SecuritiesBalanceType11Code {
        LODE = 1
        QUAS = 2
        ISSU = 3
        UNRG = 4
        SPOS = 5
        NOMI = 6
        DIRT = 7
        CLEN = 8
        DRAW = 9
        TRAN = 10
        OTHR = 11
        RSTR = 12
        REGO = 13
        PLED = 14
        PEDA = 15
        PECA = 16
        MARG = 17
        LOAN = 18
        COLA = 19
        COLO = 20
        COLI = 21
        BORR = 22
        BLOV = 23
        BLOT = 24
        BLCA = 25
        AVAI = 26
        AWAS = 27
        BLOK = 28
    }
    class ISO20022.Semt016002.SecuritiesBalanceType8Choice {
        + Prtry  : ISO20022.Semt016002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt016002.SecuritiesBalanceType8Choice *-- ISO20022.Semt016002.GenericIdentification47
    class ISO20022.Semt016002.SecuritiesPaymentStatus1Code {
        PART = 1
        NILL = 2
        FULL = 3
    }
    class ISO20022.Semt016002.SecuritiesPaymentStatus6Choice {
        + Prtry  : ISO20022.Semt016002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt016002.SecuritiesPaymentStatus6Choice *-- ISO20022.Semt016002.GenericIdentification47
    class ISO20022.Semt016002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Semt016002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Semt016002.SecurityIdentification20 *-- ISO20022.Semt016002.OtherIdentification2
    class ISO20022.Semt016002.SecurityIdentification32 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Semt016002.OtherIdentification3~
        + ISIN  : String
    }
    ISO20022.Semt016002.SecurityIdentification32 *-- ISO20022.Semt016002.OtherIdentification3
    class ISO20022.Semt016002.Statement81 {
        + ActvtyInd  : String
        + UpdTp  : ISO20022.Semt016002.UpdateType16Choice
        + Frqcy  : ISO20022.Semt016002.Frequency26Choice
        + StmtPrd  : ISO20022.Semt016002.Period7Choice
        + StmtId  : String
        + QryRef  : String
        + RptNb  : ISO20022.Semt016002.Number3Choice
    }
    ISO20022.Semt016002.Statement81 *-- ISO20022.Semt016002.UpdateType16Choice
    ISO20022.Semt016002.Statement81 *-- ISO20022.Semt016002.Frequency26Choice
    ISO20022.Semt016002.Statement81 *-- ISO20022.Semt016002.Period7Choice
    ISO20022.Semt016002.Statement81 *-- ISO20022.Semt016002.Number3Choice
    class ISO20022.Semt016002.StatementUpdateType1Code {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Semt016002.SupplementaryData1 {
        + Envlp  : ISO20022.Semt016002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Semt016002.SupplementaryData1 *-- ISO20022.Semt016002.SupplementaryDataEnvelope1
    class ISO20022.Semt016002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Semt016002.UpdateType16Choice {
        + Prtry  : ISO20022.Semt016002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt016002.UpdateType16Choice *-- ISO20022.Semt016002.GenericIdentification47
    class ISO20022.Semt016002.YieldedOrValueType1Choice {
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

## Value ISO20022.Semt016002.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt016002.AmountAndDirection55


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Semt016002.ForeignExchangeTerms23||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Semt016002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Semt016002.RestrictedFINActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Semt016002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt016002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Semt016002.ClassificationType33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Semt016002.GenericIdentification86||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Value ISO20022.Semt016002.CorporateActionEventType101Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt016002.CorporateActionEventType33Code


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

## Enum ISO20022.Semt016002.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Semt016002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Semt016002.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Semt016002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntraPosMvmntPstngRpt|ISO20022.Semt016002.IntraPositionMovementPostingReport002V09||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntraPosMvmntPstngRpt))|

---

## Enum ISO20022.Semt016002.EventFrequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||SEMI|Int32||XmlEnum("""SEMI""")|2|
||QUTR|Int32||XmlEnum("""QUTR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|

---

## Enum ISO20022.Semt016002.EventFrequency4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||INDA|Int32||XmlEnum("""INDA""")|2|
||DAIL|Int32||XmlEnum("""DAIL""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||ADHO|Int32||XmlEnum("""ADHO""")|5|
||YEAR|Int32||XmlEnum("""YEAR""")|6|

---

## Value ISO20022.Semt016002.FinancialInstrumentAttributes119


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmAttrAddtlDtls|String||XmlElement()||
|+|UndrlygFinInstrmId|global::System.Collections.Generic.List<ISO20022.Semt016002.SecurityIdentification32>||XmlElement()||
|+|CtrctSz|ISO20022.Semt016002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Semt016002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|StrkPric|ISO20022.Semt016002.Price3||XmlElement()||
|+|ConvsPric|ISO20022.Semt016002.Price3||XmlElement()||
|+|SbcptPric|ISO20022.Semt016002.Price3||XmlElement()||
|+|ExrcPric|ISO20022.Semt016002.Price3||XmlElement()||
|+|MktOrIndctvPric|ISO20022.Semt016002.PriceType5Choice||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt016002.QuantityBreakdown64>||XmlElement()||
|+|PoolNb|ISO20022.Semt016002.GenericIdentification39||XmlElement()||
|+|CpnAttchdNb|ISO20022.Semt016002.Number23Choice||XmlElement()||
|+|IndxRateBsis|Decimal||XmlElement()||
|+|NxtIntrstRate|Decimal||XmlElement()||
|+|YldToMtrtyRate|Decimal||XmlElement()||
|+|IntrstRate|Decimal||XmlElement()||
|+|NxtFctr|Decimal||XmlElement()||
|+|CurFctr|Decimal||XmlElement()||
|+|PrvsFctr|Decimal||XmlElement()||
|+|FrstPmtDt|DateTime||XmlElement()||
|+|DtdDt|DateTime||XmlElement()||
|+|PutblDt|DateTime||XmlElement()||
|+|NxtCllblDt|DateTime||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|FltgRateFxgDt|DateTime||XmlElement()||
|+|XpryDt|DateTime||XmlElement()||
|+|CpnDt|DateTime||XmlElement()||
|+|DnmtnCcy|String||XmlElement()||
|+|OptnTp|ISO20022.Semt016002.OptionType7Choice||XmlElement()||
|+|OptnStyle|ISO20022.Semt016002.OptionStyle9Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Semt016002.ClassificationType33Choice||XmlElement()||
|+|VarblRateChngFrqcy|ISO20022.Semt016002.Frequency27Choice||XmlElement()||
|+|PmtSts|ISO20022.Semt016002.SecuritiesPaymentStatus6Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Semt016002.Frequency27Choice||XmlElement()||
|+|RegnForm|ISO20022.Semt016002.FormOfSecurity7Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Semt016002.InterestComputationMethodFormat5Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Semt016002.MarketIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FinInstrmAttrAddtlDtls""",FinInstrmAttrAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validList("""UndrlygFinInstrmId""",UndrlygFinInstrmId),validElement(UndrlygFinInstrmId),validElement(CtrctSz),validElement(MinNmnlQty),validElement(StrkPric),validElement(ConvsPric),validElement(SbcptPric),validElement(ExrcPric),validElement(MktOrIndctvPric),validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(PoolNb),validElement(CpnAttchdNb),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnTp),validElement(OptnStyle),validElement(ClssfctnTp),validElement(VarblRateChngFrqcy),validElement(PmtSts),validElement(PmtFrqcy),validElement(RegnForm),validElement(DayCntBsis),validElement(PlcOfListg))|

---

## Value ISO20022.Semt016002.FinancialInstrumentDetails44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubBal|global::System.Collections.Generic.List<ISO20022.Semt016002.IntraPositionDetails63>||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Semt016002.FinancialInstrumentAttributes119||XmlElement()||
|+|FinInstrmId|ISO20022.Semt016002.SecurityIdentification20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""SubBal""",SubBal),validList("""SubBal""",SubBal),validElement(SubBal),validElement(FinInstrmAttrbts),validElement(FinInstrmId))|

---

## Value ISO20022.Semt016002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Semt016002.ForeignExchangeTerms23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Semt016002.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Semt016002.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Semt016002.FormOfSecurity7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt016002.Frequency26Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt016002.Frequency27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt016002.GenericIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt016002.GenericIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""([^/]+/)+([^/]+)\|([^/]*)"""),validPattern("""Id""",Id,"""([^/]+/)+([^/]+)\|([^/]*)"""))|

---

## Value ISO20022.Semt016002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt016002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt016002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Semt016002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Semt016002.GenericIdentification86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt016002.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt016002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt016002.InterestComputationMethod2Code


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

## Value ISO20022.Semt016002.InterestComputationMethodFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt016002.IntraPositionDetails63


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntraPosMvmnt|global::System.Collections.Generic.List<ISO20022.Semt016002.IntraPositionMovementDetails20>||XmlElement()||
|+|BalFr|ISO20022.Semt016002.SecuritiesBalanceType8Choice||XmlElement()||
|+|SfkpgPlc|ISO20022.Semt016002.SafekeepingPlaceFormat39Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""IntraPosMvmnt""",IntraPosMvmnt),validList("""IntraPosMvmnt""",IntraPosMvmnt),validElement(IntraPosMvmnt),validElement(BalFr),validElement(SfkpgPlc))|

---

## Value ISO20022.Semt016002.IntraPositionMovementDetails20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt016002.SupplementaryData1>||XmlElement()||
|+|InstrPrcgAddtlDtls|String||XmlElement()||
|+|CollMntrAmt|ISO20022.Semt016002.AmountAndDirection55||XmlElement()||
|+|CorpActnEvtTp|ISO20022.Semt016002.CorporateActionEventType101Choice||XmlElement()||
|+|AckdStsTmStmp|DateTime||XmlElement()||
|+|AvlblDt|ISO20022.Semt016002.DateAndDateTime2Choice||XmlElement()||
|+|SttlmDt|ISO20022.Semt016002.DateAndDateTime2Choice||XmlElement()||
|+|BalTo|ISO20022.Semt016002.SecuritiesBalanceType8Choice||XmlElement()||
|+|SctiesSubBalId|ISO20022.Semt016002.GenericIdentification39||XmlElement()||
|+|RmngToBeSttldQty|ISO20022.Semt016002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|PrevslySttldQty|ISO20022.Semt016002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|SttldQty|ISO20022.Semt016002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|Id|ISO20022.Semt016002.References75Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validPattern("""InstrPrcgAddtlDtls""",InstrPrcgAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validElement(CollMntrAmt),validElement(CorpActnEvtTp),validElement(AvlblDt),validElement(SttlmDt),validElement(BalTo),validElement(SctiesSubBalId),validElement(RmngToBeSttldQty),validElement(PrevslySttldQty),validElement(SttldQty),validElement(Id))|

---

## Aspect ISO20022.Semt016002.IntraPositionMovementPostingReport002V09


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrm|global::System.Collections.Generic.List<ISO20022.Semt016002.FinancialInstrumentDetails44>||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt016002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt016002.SecuritiesAccount30||XmlElement()||
|+|AcctOwnr|ISO20022.Semt016002.PartyIdentification136Choice||XmlElement()||
|+|StmtGnlDtls|ISO20022.Semt016002.Statement81||XmlElement()||
|+|Pgntn|ISO20022.Semt016002.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""FinInstrm""",FinInstrm),validElement(FinInstrm),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(StmtGnlDtls),validElement(Pgntn))|

---

## Value ISO20022.Semt016002.MarketIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Semt016002.Number23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|ISO20022.Semt016002.GenericIdentification18||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lng),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Value ISO20022.Semt016002.Number3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|String||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lng""",Lng,"""[0-9]{5}"""),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Enum ISO20022.Semt016002.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Semt016002.OptionStyle9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt016002.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Semt016002.OptionType7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt016002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt016002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Semt016002.OtherIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt016002.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Semt016002.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Semt016002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Semt016002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Semt016002.Period2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt016002.Period7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrDtToDt|ISO20022.Semt016002.Period2||XmlElement()||
|+|FrDtTmToDtTm|ISO20022.Semt016002.DateTimePeriod1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrDtToDt),validElement(FrDtTmToDtTm),validChoice(FrDtToDt,FrDtTmToDtTm))|

---

## Value ISO20022.Semt016002.Price3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Semt016002.PriceRateOrAmount1Choice||XmlElement()||
|+|Tp|ISO20022.Semt016002.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Semt016002.PriceRateOrAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Semt016002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Semt016002.PriceType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indctv|ISO20022.Semt016002.Price3||XmlElement()||
|+|Mkt|ISO20022.Semt016002.Price3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indctv),validElement(Mkt),validChoice(Indctv,Mkt))|

---

## Enum ISO20022.Semt016002.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Semt016002.QuantityBreakdown64


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LotQty|ISO20022.Semt016002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|LotNb|ISO20022.Semt016002.GenericIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LotQty),validElement(LotNb))|

---

## Value ISO20022.Semt016002.References75Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcrTxId|String||XmlElement()||
|+|CtrPtyMktInfrstrctrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrcrTxId""",PrcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CtrPtyMktInfrstrctrTxId""",CtrPtyMktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktInfrstrctrTxId""",MktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""PoolId""",PoolId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrTxId""",AcctSvcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctOwnrTxId""",AcctOwnrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validChoice(PrcrTxId,CtrPtyMktInfrstrctrTxId,MktInfrstrctrTxId,PoolId,AcctSvcrTxId,AcctOwnrTxId))|

---

## Value ISO20022.Semt016002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt016002.RestrictedFINActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Semt016002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Semt016002.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Semt016002.SafekeepingPlaceFormat39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Semt016002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Semt016002.SafekeepingPlaceTypeAndText15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Semt016002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt016002.SafekeepingPlaceTypeAndText15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt016002.SecuritiesAccount30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt016002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Enum ISO20022.Semt016002.SecuritiesBalanceType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LODE|Int32||XmlEnum("""LODE""")|1|
||QUAS|Int32||XmlEnum("""QUAS""")|2|
||ISSU|Int32||XmlEnum("""ISSU""")|3|
||UNRG|Int32||XmlEnum("""UNRG""")|4|
||SPOS|Int32||XmlEnum("""SPOS""")|5|
||NOMI|Int32||XmlEnum("""NOMI""")|6|
||DIRT|Int32||XmlEnum("""DIRT""")|7|
||CLEN|Int32||XmlEnum("""CLEN""")|8|
||DRAW|Int32||XmlEnum("""DRAW""")|9|
||TRAN|Int32||XmlEnum("""TRAN""")|10|
||OTHR|Int32||XmlEnum("""OTHR""")|11|
||RSTR|Int32||XmlEnum("""RSTR""")|12|
||REGO|Int32||XmlEnum("""REGO""")|13|
||PLED|Int32||XmlEnum("""PLED""")|14|
||PEDA|Int32||XmlEnum("""PEDA""")|15|
||PECA|Int32||XmlEnum("""PECA""")|16|
||MARG|Int32||XmlEnum("""MARG""")|17|
||LOAN|Int32||XmlEnum("""LOAN""")|18|
||COLA|Int32||XmlEnum("""COLA""")|19|
||COLO|Int32||XmlEnum("""COLO""")|20|
||COLI|Int32||XmlEnum("""COLI""")|21|
||BORR|Int32||XmlEnum("""BORR""")|22|
||BLOV|Int32||XmlEnum("""BLOV""")|23|
||BLOT|Int32||XmlEnum("""BLOT""")|24|
||BLCA|Int32||XmlEnum("""BLCA""")|25|
||AVAI|Int32||XmlEnum("""AVAI""")|26|
||AWAS|Int32||XmlEnum("""AWAS""")|27|
||BLOK|Int32||XmlEnum("""BLOK""")|28|

---

## Value ISO20022.Semt016002.SecuritiesBalanceType8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt016002.SecuritiesPaymentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NILL|Int32||XmlEnum("""NILL""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Semt016002.SecuritiesPaymentStatus6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt016002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Semt016002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Semt016002.SecurityIdentification32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Semt016002.OtherIdentification3>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Semt016002.Statement81


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ActvtyInd|String||XmlElement()||
|+|UpdTp|ISO20022.Semt016002.UpdateType16Choice||XmlElement()||
|+|Frqcy|ISO20022.Semt016002.Frequency26Choice||XmlElement()||
|+|StmtPrd|ISO20022.Semt016002.Period7Choice||XmlElement()||
|+|StmtId|String||XmlElement()||
|+|QryRef|String||XmlElement()||
|+|RptNb|ISO20022.Semt016002.Number3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UpdTp),validElement(Frqcy),validElement(StmtPrd),validPattern("""StmtId""",StmtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""QryRef""",QryRef,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(RptNb))|

---

## Enum ISO20022.Semt016002.StatementUpdateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Semt016002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Semt016002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Semt016002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt016002.UpdateType16Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt016002.YieldedOrValueType1Choice


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

