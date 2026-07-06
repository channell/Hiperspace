# semt.016.001.10
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt016001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt016001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt016001.ActiveOrHistoricCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt016001.AmountAndDirection44 {
        + FXDtls  : ISO20022.Semt016001.ForeignExchangeTerms23
        + OrgnlCcyAndOrdrdAmt  : ISO20022.Semt016001.ActiveOrHistoricCurrencyAndAmount
        + CdtDbtInd  : String
        + Amt  : ISO20022.Semt016001.ActiveOrHistoricCurrencyAndAmount
    }
    ISO20022.Semt016001.AmountAndDirection44 *-- ISO20022.Semt016001.ForeignExchangeTerms23
    ISO20022.Semt016001.AmountAndDirection44 *-- ISO20022.Semt016001.ActiveOrHistoricCurrencyAndAmount
    ISO20022.Semt016001.AmountAndDirection44 *-- ISO20022.Semt016001.ActiveOrHistoricCurrencyAndAmount
    class ISO20022.Semt016001.BlockChainAddressWallet3 {
        + Nm  : String
        + Tp  : ISO20022.Semt016001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Semt016001.BlockChainAddressWallet3 *-- ISO20022.Semt016001.GenericIdentification30
    class ISO20022.Semt016001.ClassificationType32Choice {
        + AltrnClssfctn  : ISO20022.Semt016001.GenericIdentification36
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Semt016001.ClassificationType32Choice *-- ISO20022.Semt016001.GenericIdentification36
    class ISO20022.Semt016001.CorporateActionEventType110Choice {
        + Prtry  : ISO20022.Semt016001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt016001.CorporateActionEventType110Choice *-- ISO20022.Semt016001.GenericIdentification30
    class ISO20022.Semt016001.CorporateActionEventType38Code {
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
    class ISO20022.Semt016001.CreditDebitCode {
        DBIT = 1
        CRDT = 2
    }
    class ISO20022.Semt016001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Semt016001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Semt016001.EventFrequency3Code {
        WEEK = 1
        SEMI = 2
        QUTR = 3
        MNTH = 4
        YEAR = 5
    }
    class ISO20022.Semt016001.EventFrequency4Code {
        WEEK = 1
        INDA = 2
        DAIL = 3
        MNTH = 4
        ADHO = 5
        YEAR = 6
    }
    class ISO20022.Semt016001.FinancialInstrumentAttributes112 {
        + FinInstrmAttrAddtlDtls  : String
        + UndrlygFinInstrmId  : global::System.Collections.Generic.List~ISO20022.Semt016001.SecurityIdentification19~
        + CtrctSz  : ISO20022.Semt016001.FinancialInstrumentQuantity33Choice
        + MinNmnlQty  : ISO20022.Semt016001.FinancialInstrumentQuantity33Choice
        + StrkPric  : ISO20022.Semt016001.Price7
        + ConvsPric  : ISO20022.Semt016001.Price7
        + SbcptPric  : ISO20022.Semt016001.Price7
        + ExrcPric  : ISO20022.Semt016001.Price7
        + MktOrIndctvPric  : ISO20022.Semt016001.PriceType4Choice
        + PutblInd  : String
        + CllblInd  : String
        + VarblRateInd  : String
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt016001.QuantityBreakdown60~
        + PoolNb  : ISO20022.Semt016001.GenericIdentification37
        + CpnAttchdNb  : ISO20022.Semt016001.Number22Choice
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
        + OptnTp  : ISO20022.Semt016001.OptionType6Choice
        + OptnStyle  : ISO20022.Semt016001.OptionStyle8Choice
        + ClssfctnTp  : ISO20022.Semt016001.ClassificationType32Choice
        + VarblRateChngFrqcy  : ISO20022.Semt016001.Frequency23Choice
        + PmtSts  : ISO20022.Semt016001.SecuritiesPaymentStatus5Choice
        + PmtFrqcy  : ISO20022.Semt016001.Frequency23Choice
        + RegnForm  : ISO20022.Semt016001.FormOfSecurity6Choice
        + DayCntBsis  : ISO20022.Semt016001.InterestComputationMethodFormat4Choice
        + PlcOfListg  : ISO20022.Semt016001.MarketIdentification3Choice
    }
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.SecurityIdentification19
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.FinancialInstrumentQuantity33Choice
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.FinancialInstrumentQuantity33Choice
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.Price7
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.Price7
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.Price7
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.Price7
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.PriceType4Choice
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.QuantityBreakdown60
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.GenericIdentification37
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.Number22Choice
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.OptionType6Choice
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.OptionStyle8Choice
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.ClassificationType32Choice
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.Frequency23Choice
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.SecuritiesPaymentStatus5Choice
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.Frequency23Choice
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.FormOfSecurity6Choice
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.InterestComputationMethodFormat4Choice
    ISO20022.Semt016001.FinancialInstrumentAttributes112 *-- ISO20022.Semt016001.MarketIdentification3Choice
    class ISO20022.Semt016001.FinancialInstrumentDetails47 {
        + SubBal  : global::System.Collections.Generic.List~ISO20022.Semt016001.IntraPositionDetails66~
        + FinInstrmAttrbts  : ISO20022.Semt016001.FinancialInstrumentAttributes112
        + FinInstrmId  : ISO20022.Semt016001.SecurityIdentification19
    }
    ISO20022.Semt016001.FinancialInstrumentDetails47 *-- ISO20022.Semt016001.IntraPositionDetails66
    ISO20022.Semt016001.FinancialInstrumentDetails47 *-- ISO20022.Semt016001.FinancialInstrumentAttributes112
    ISO20022.Semt016001.FinancialInstrumentDetails47 *-- ISO20022.Semt016001.SecurityIdentification19
    class ISO20022.Semt016001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Semt016001.ForeignExchangeTerms23 {
        + RsltgAmt  : ISO20022.Semt016001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + QtdCcy  : String
        + UnitCcy  : String
    }
    ISO20022.Semt016001.ForeignExchangeTerms23 *-- ISO20022.Semt016001.ActiveCurrencyAndAmount
    class ISO20022.Semt016001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Semt016001.FormOfSecurity6Choice {
        + Prtry  : ISO20022.Semt016001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt016001.FormOfSecurity6Choice *-- ISO20022.Semt016001.GenericIdentification30
    class ISO20022.Semt016001.Frequency23Choice {
        + Prtry  : ISO20022.Semt016001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt016001.Frequency23Choice *-- ISO20022.Semt016001.GenericIdentification30
    class ISO20022.Semt016001.Frequency25Choice {
        + Prtry  : ISO20022.Semt016001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt016001.Frequency25Choice *-- ISO20022.Semt016001.GenericIdentification30
    class ISO20022.Semt016001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Semt016001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt016001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt016001.GenericIdentification37 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt016001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Semt016001.GenericIdentification30
    }
    ISO20022.Semt016001.GenericIdentification78 *-- ISO20022.Semt016001.GenericIdentification30
    class ISO20022.Semt016001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt016001.InterestComputationMethod2Code {
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
    class ISO20022.Semt016001.InterestComputationMethodFormat4Choice {
        + Prtry  : ISO20022.Semt016001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt016001.InterestComputationMethodFormat4Choice *-- ISO20022.Semt016001.GenericIdentification30
    class ISO20022.Semt016001.IntraPositionDetails66 {
        + IntraPosMvmnt  : global::System.Collections.Generic.List~ISO20022.Semt016001.IntraPositionMovementDetails21~
        + BalFr  : ISO20022.Semt016001.SecuritiesBalanceType6Choice
        + SfkpgPlc  : ISO20022.Semt016001.SafekeepingPlaceFormat41Choice
    }
    ISO20022.Semt016001.IntraPositionDetails66 *-- ISO20022.Semt016001.IntraPositionMovementDetails21
    ISO20022.Semt016001.IntraPositionDetails66 *-- ISO20022.Semt016001.SecuritiesBalanceType6Choice
    ISO20022.Semt016001.IntraPositionDetails66 *-- ISO20022.Semt016001.SafekeepingPlaceFormat41Choice
    class ISO20022.Semt016001.IntraPositionMovementDetails21 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt016001.SupplementaryData1~
        + InstrPrcgAddtlDtls  : String
        + CollMntrAmt  : ISO20022.Semt016001.AmountAndDirection44
        + CorpActnEvtTp  : ISO20022.Semt016001.CorporateActionEventType110Choice
        + AckdStsTmStmp  : DateTime
        + AvlblDt  : ISO20022.Semt016001.DateAndDateTime2Choice
        + SttlmDt  : ISO20022.Semt016001.DateAndDateTime2Choice
        + BalTo  : ISO20022.Semt016001.SecuritiesBalanceType6Choice
        + SctiesSubBalId  : ISO20022.Semt016001.GenericIdentification37
        + RmngToBeSttldQty  : ISO20022.Semt016001.FinancialInstrumentQuantity33Choice
        + PrevslySttldQty  : ISO20022.Semt016001.FinancialInstrumentQuantity33Choice
        + SttldQty  : ISO20022.Semt016001.FinancialInstrumentQuantity33Choice
        + Id  : ISO20022.Semt016001.References72Choice
    }
    ISO20022.Semt016001.IntraPositionMovementDetails21 *-- ISO20022.Semt016001.SupplementaryData1
    ISO20022.Semt016001.IntraPositionMovementDetails21 *-- ISO20022.Semt016001.AmountAndDirection44
    ISO20022.Semt016001.IntraPositionMovementDetails21 *-- ISO20022.Semt016001.CorporateActionEventType110Choice
    ISO20022.Semt016001.IntraPositionMovementDetails21 *-- ISO20022.Semt016001.DateAndDateTime2Choice
    ISO20022.Semt016001.IntraPositionMovementDetails21 *-- ISO20022.Semt016001.DateAndDateTime2Choice
    ISO20022.Semt016001.IntraPositionMovementDetails21 *-- ISO20022.Semt016001.SecuritiesBalanceType6Choice
    ISO20022.Semt016001.IntraPositionMovementDetails21 *-- ISO20022.Semt016001.GenericIdentification37
    ISO20022.Semt016001.IntraPositionMovementDetails21 *-- ISO20022.Semt016001.FinancialInstrumentQuantity33Choice
    ISO20022.Semt016001.IntraPositionMovementDetails21 *-- ISO20022.Semt016001.FinancialInstrumentQuantity33Choice
    ISO20022.Semt016001.IntraPositionMovementDetails21 *-- ISO20022.Semt016001.FinancialInstrumentQuantity33Choice
    ISO20022.Semt016001.IntraPositionMovementDetails21 *-- ISO20022.Semt016001.References72Choice
    class ISO20022.Semt016001.IntraPositionMovementPostingReportV10 {
        + FinInstrm  : global::System.Collections.Generic.List~ISO20022.Semt016001.FinancialInstrumentDetails47~
        + BlckChainAdrOrWllt  : ISO20022.Semt016001.BlockChainAddressWallet3
        + SfkpgAcct  : ISO20022.Semt016001.SecuritiesAccount19
        + AcctOwnr  : ISO20022.Semt016001.PartyIdentification127Choice
        + StmtGnlDtls  : ISO20022.Semt016001.Statement80
        + Pgntn  : ISO20022.Semt016001.Pagination1
    }
    ISO20022.Semt016001.IntraPositionMovementPostingReportV10 *-- ISO20022.Semt016001.FinancialInstrumentDetails47
    ISO20022.Semt016001.IntraPositionMovementPostingReportV10 *-- ISO20022.Semt016001.BlockChainAddressWallet3
    ISO20022.Semt016001.IntraPositionMovementPostingReportV10 *-- ISO20022.Semt016001.SecuritiesAccount19
    ISO20022.Semt016001.IntraPositionMovementPostingReportV10 *-- ISO20022.Semt016001.PartyIdentification127Choice
    ISO20022.Semt016001.IntraPositionMovementPostingReportV10 *-- ISO20022.Semt016001.Statement80
    ISO20022.Semt016001.IntraPositionMovementPostingReportV10 *-- ISO20022.Semt016001.Pagination1
    class ISO20022.Semt016001.MarketIdentification3Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Semt016001.Number22Choice {
        + Lng  : ISO20022.Semt016001.GenericIdentification1
        + Shrt  : String
    }
    ISO20022.Semt016001.Number22Choice *-- ISO20022.Semt016001.GenericIdentification1
    class ISO20022.Semt016001.Number3Choice {
        + Lng  : String
        + Shrt  : String
    }
    class ISO20022.Semt016001.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Semt016001.OptionStyle8Choice {
        + Prtry  : ISO20022.Semt016001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt016001.OptionStyle8Choice *-- ISO20022.Semt016001.GenericIdentification30
    class ISO20022.Semt016001.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Semt016001.OptionType6Choice {
        + Prtry  : ISO20022.Semt016001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt016001.OptionType6Choice *-- ISO20022.Semt016001.GenericIdentification30
    class ISO20022.Semt016001.OtherIdentification1 {
        + Tp  : ISO20022.Semt016001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Semt016001.OtherIdentification1 *-- ISO20022.Semt016001.IdentificationSource3Choice
    class ISO20022.Semt016001.Pagination1 {
        + LastPgInd  : String
        + PgNb  : String
    }
    class ISO20022.Semt016001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Semt016001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Semt016001.PartyIdentification127Choice *-- ISO20022.Semt016001.GenericIdentification36
    class ISO20022.Semt016001.Period2 {
        + ToDt  : DateTime
        + FrDt  : DateTime
    }
    class ISO20022.Semt016001.Period7Choice {
        + FrDtToDt  : ISO20022.Semt016001.Period2
        + FrDtTmToDtTm  : ISO20022.Semt016001.DateTimePeriod1
    }
    ISO20022.Semt016001.Period7Choice *-- ISO20022.Semt016001.Period2
    ISO20022.Semt016001.Period7Choice *-- ISO20022.Semt016001.DateTimePeriod1
    class ISO20022.Semt016001.Price7 {
        + Val  : ISO20022.Semt016001.PriceRateOrAmount3Choice
        + Tp  : ISO20022.Semt016001.YieldedOrValueType1Choice
    }
    ISO20022.Semt016001.Price7 *-- ISO20022.Semt016001.PriceRateOrAmount3Choice
    ISO20022.Semt016001.Price7 *-- ISO20022.Semt016001.YieldedOrValueType1Choice
    class ISO20022.Semt016001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Semt016001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Semt016001.PriceRateOrAmount3Choice *-- ISO20022.Semt016001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Semt016001.PriceType4Choice {
        + Indctv  : ISO20022.Semt016001.Price7
        + Mkt  : ISO20022.Semt016001.Price7
    }
    ISO20022.Semt016001.PriceType4Choice *-- ISO20022.Semt016001.Price7
    ISO20022.Semt016001.PriceType4Choice *-- ISO20022.Semt016001.Price7
    class ISO20022.Semt016001.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Semt016001.QuantityBreakdown60 {
        + LotQty  : ISO20022.Semt016001.FinancialInstrumentQuantity33Choice
        + LotNb  : ISO20022.Semt016001.GenericIdentification37
    }
    ISO20022.Semt016001.QuantityBreakdown60 *-- ISO20022.Semt016001.FinancialInstrumentQuantity33Choice
    ISO20022.Semt016001.QuantityBreakdown60 *-- ISO20022.Semt016001.GenericIdentification37
    class ISO20022.Semt016001.References72Choice {
        + PrcrTxId  : String
        + CtrPtyMktInfrstrctrTxId  : String
        + MktInfrstrctrTxId  : String
        + PoolId  : String
        + AcctSvcrTxId  : String
        + AcctOwnrTxId  : String
    }
    class ISO20022.Semt016001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Semt016001.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Semt016001.SafekeepingPlaceFormat41Choice {
        + Prtry  : ISO20022.Semt016001.GenericIdentification78
        + TpAndId  : ISO20022.Semt016001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Semt016001.SafekeepingPlaceTypeAndText8
    }
    ISO20022.Semt016001.SafekeepingPlaceFormat41Choice *-- ISO20022.Semt016001.GenericIdentification78
    ISO20022.Semt016001.SafekeepingPlaceFormat41Choice *-- ISO20022.Semt016001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Semt016001.SafekeepingPlaceFormat41Choice *-- ISO20022.Semt016001.SafekeepingPlaceTypeAndText8
    class ISO20022.Semt016001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt016001.SafekeepingPlaceTypeAndText8 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt016001.SecuritiesAccount19 {
        + Nm  : String
        + Tp  : ISO20022.Semt016001.GenericIdentification30
        + Id  : String
    }
    ISO20022.Semt016001.SecuritiesAccount19 *-- ISO20022.Semt016001.GenericIdentification30
    class ISO20022.Semt016001.SecuritiesBalanceType11Code {
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
    class ISO20022.Semt016001.SecuritiesBalanceType6Choice {
        + Prtry  : ISO20022.Semt016001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt016001.SecuritiesBalanceType6Choice *-- ISO20022.Semt016001.GenericIdentification30
    class ISO20022.Semt016001.SecuritiesPaymentStatus1Code {
        PART = 1
        NILL = 2
        FULL = 3
    }
    class ISO20022.Semt016001.SecuritiesPaymentStatus5Choice {
        + Prtry  : ISO20022.Semt016001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt016001.SecuritiesPaymentStatus5Choice *-- ISO20022.Semt016001.GenericIdentification30
    class ISO20022.Semt016001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Semt016001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Semt016001.SecurityIdentification19 *-- ISO20022.Semt016001.OtherIdentification1
    class ISO20022.Semt016001.Statement80 {
        + ActvtyInd  : String
        + UpdTp  : ISO20022.Semt016001.UpdateType15Choice
        + Frqcy  : ISO20022.Semt016001.Frequency25Choice
        + StmtPrd  : ISO20022.Semt016001.Period7Choice
        + StmtId  : String
        + QryRef  : String
        + RptNb  : ISO20022.Semt016001.Number3Choice
    }
    ISO20022.Semt016001.Statement80 *-- ISO20022.Semt016001.UpdateType15Choice
    ISO20022.Semt016001.Statement80 *-- ISO20022.Semt016001.Frequency25Choice
    ISO20022.Semt016001.Statement80 *-- ISO20022.Semt016001.Period7Choice
    ISO20022.Semt016001.Statement80 *-- ISO20022.Semt016001.Number3Choice
    class ISO20022.Semt016001.StatementUpdateType1Code {
        DELT = 1
        COMP = 2
    }
    class ISO20022.Semt016001.SupplementaryData1 {
        + Envlp  : ISO20022.Semt016001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Semt016001.SupplementaryData1 *-- ISO20022.Semt016001.SupplementaryDataEnvelope1
    class ISO20022.Semt016001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Semt016001.UpdateType15Choice {
        + Prtry  : ISO20022.Semt016001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Semt016001.UpdateType15Choice *-- ISO20022.Semt016001.GenericIdentification30
    class ISO20022.Semt016001.YieldedOrValueType1Choice {
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

## Value ISO20022.Semt016001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt016001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt016001.ActiveOrHistoricCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Semt016001.AmountAndDirection44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FXDtls|ISO20022.Semt016001.ForeignExchangeTerms23||XmlElement()||
|+|OrgnlCcyAndOrdrdAmt|ISO20022.Semt016001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
|+|CdtDbtInd|String||XmlElement()||
|+|Amt|ISO20022.Semt016001.ActiveOrHistoricCurrencyAndAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FXDtls),validElement(OrgnlCcyAndOrdrdAmt),validElement(Amt))|

---

## Value ISO20022.Semt016001.BlockChainAddressWallet3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt016001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt016001.ClassificationType32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Semt016001.GenericIdentification36||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Value ISO20022.Semt016001.CorporateActionEventType110Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt016001.CorporateActionEventType38Code


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

## Enum ISO20022.Semt016001.CreditDebitCode


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DBIT|Int32||XmlEnum("""DBIT""")|1|
||CRDT|Int32||XmlEnum("""CRDT""")|2|

---

## Value ISO20022.Semt016001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Semt016001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Type ISO20022.Semt016001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntraPosMvmntPstngRpt|ISO20022.Semt016001.IntraPositionMovementPostingReportV10||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntraPosMvmntPstngRpt))|

---

## Enum ISO20022.Semt016001.EventFrequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||SEMI|Int32||XmlEnum("""SEMI""")|2|
||QUTR|Int32||XmlEnum("""QUTR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|

---

## Enum ISO20022.Semt016001.EventFrequency4Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||INDA|Int32||XmlEnum("""INDA""")|2|
||DAIL|Int32||XmlEnum("""DAIL""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||ADHO|Int32||XmlEnum("""ADHO""")|5|
||YEAR|Int32||XmlEnum("""YEAR""")|6|

---

## Value ISO20022.Semt016001.FinancialInstrumentAttributes112


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmAttrAddtlDtls|String||XmlElement()||
|+|UndrlygFinInstrmId|global::System.Collections.Generic.List<ISO20022.Semt016001.SecurityIdentification19>||XmlElement()||
|+|CtrctSz|ISO20022.Semt016001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Semt016001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|StrkPric|ISO20022.Semt016001.Price7||XmlElement()||
|+|ConvsPric|ISO20022.Semt016001.Price7||XmlElement()||
|+|SbcptPric|ISO20022.Semt016001.Price7||XmlElement()||
|+|ExrcPric|ISO20022.Semt016001.Price7||XmlElement()||
|+|MktOrIndctvPric|ISO20022.Semt016001.PriceType4Choice||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt016001.QuantityBreakdown60>||XmlElement()||
|+|PoolNb|ISO20022.Semt016001.GenericIdentification37||XmlElement()||
|+|CpnAttchdNb|ISO20022.Semt016001.Number22Choice||XmlElement()||
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
|+|OptnTp|ISO20022.Semt016001.OptionType6Choice||XmlElement()||
|+|OptnStyle|ISO20022.Semt016001.OptionStyle8Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Semt016001.ClassificationType32Choice||XmlElement()||
|+|VarblRateChngFrqcy|ISO20022.Semt016001.Frequency23Choice||XmlElement()||
|+|PmtSts|ISO20022.Semt016001.SecuritiesPaymentStatus5Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Semt016001.Frequency23Choice||XmlElement()||
|+|RegnForm|ISO20022.Semt016001.FormOfSecurity6Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Semt016001.InterestComputationMethodFormat4Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Semt016001.MarketIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""UndrlygFinInstrmId""",UndrlygFinInstrmId),validElement(UndrlygFinInstrmId),validElement(CtrctSz),validElement(MinNmnlQty),validElement(StrkPric),validElement(ConvsPric),validElement(SbcptPric),validElement(ExrcPric),validElement(MktOrIndctvPric),validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(PoolNb),validElement(CpnAttchdNb),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnTp),validElement(OptnStyle),validElement(ClssfctnTp),validElement(VarblRateChngFrqcy),validElement(PmtSts),validElement(PmtFrqcy),validElement(RegnForm),validElement(DayCntBsis),validElement(PlcOfListg))|

---

## Value ISO20022.Semt016001.FinancialInstrumentDetails47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SubBal|global::System.Collections.Generic.List<ISO20022.Semt016001.IntraPositionDetails66>||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Semt016001.FinancialInstrumentAttributes112||XmlElement()||
|+|FinInstrmId|ISO20022.Semt016001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""SubBal""",SubBal),validList("""SubBal""",SubBal),validElement(SubBal),validElement(FinInstrmAttrbts),validElement(FinInstrmId))|

---

## Value ISO20022.Semt016001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Value ISO20022.Semt016001.ForeignExchangeTerms23


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RsltgAmt|ISO20022.Semt016001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|QtdCcy|String||XmlElement()||
|+|UnitCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RsltgAmt),validPattern("""QtdCcy""",QtdCcy,"""[A-Z]{3,3}"""),validPattern("""UnitCcy""",UnitCcy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Semt016001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Semt016001.FormOfSecurity6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt016001.Frequency23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt016001.Frequency25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt016001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt016001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt016001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt016001.GenericIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt016001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Semt016001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt016001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt016001.InterestComputationMethod2Code


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

## Value ISO20022.Semt016001.InterestComputationMethodFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt016001.IntraPositionDetails66


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntraPosMvmnt|global::System.Collections.Generic.List<ISO20022.Semt016001.IntraPositionMovementDetails21>||XmlElement()||
|+|BalFr|ISO20022.Semt016001.SecuritiesBalanceType6Choice||XmlElement()||
|+|SfkpgPlc|ISO20022.Semt016001.SafekeepingPlaceFormat41Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""IntraPosMvmnt""",IntraPosMvmnt),validList("""IntraPosMvmnt""",IntraPosMvmnt),validElement(IntraPosMvmnt),validElement(BalFr),validElement(SfkpgPlc))|

---

## Value ISO20022.Semt016001.IntraPositionMovementDetails21


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt016001.SupplementaryData1>||XmlElement()||
|+|InstrPrcgAddtlDtls|String||XmlElement()||
|+|CollMntrAmt|ISO20022.Semt016001.AmountAndDirection44||XmlElement()||
|+|CorpActnEvtTp|ISO20022.Semt016001.CorporateActionEventType110Choice||XmlElement()||
|+|AckdStsTmStmp|DateTime||XmlElement()||
|+|AvlblDt|ISO20022.Semt016001.DateAndDateTime2Choice||XmlElement()||
|+|SttlmDt|ISO20022.Semt016001.DateAndDateTime2Choice||XmlElement()||
|+|BalTo|ISO20022.Semt016001.SecuritiesBalanceType6Choice||XmlElement()||
|+|SctiesSubBalId|ISO20022.Semt016001.GenericIdentification37||XmlElement()||
|+|RmngToBeSttldQty|ISO20022.Semt016001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|PrevslySttldQty|ISO20022.Semt016001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|SttldQty|ISO20022.Semt016001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|Id|ISO20022.Semt016001.References72Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(CollMntrAmt),validElement(CorpActnEvtTp),validElement(AvlblDt),validElement(SttlmDt),validElement(BalTo),validElement(SctiesSubBalId),validElement(RmngToBeSttldQty),validElement(PrevslySttldQty),validElement(SttldQty),validElement(Id))|

---

## Aspect ISO20022.Semt016001.IntraPositionMovementPostingReportV10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrm|global::System.Collections.Generic.List<ISO20022.Semt016001.FinancialInstrumentDetails47>||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt016001.BlockChainAddressWallet3||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt016001.SecuritiesAccount19||XmlElement()||
|+|AcctOwnr|ISO20022.Semt016001.PartyIdentification127Choice||XmlElement()||
|+|StmtGnlDtls|ISO20022.Semt016001.Statement80||XmlElement()||
|+|Pgntn|ISO20022.Semt016001.Pagination1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""FinInstrm""",FinInstrm),validElement(FinInstrm),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validElement(StmtGnlDtls),validElement(Pgntn))|

---

## Value ISO20022.Semt016001.MarketIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Semt016001.Number22Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|ISO20022.Semt016001.GenericIdentification1||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lng),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Value ISO20022.Semt016001.Number3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|String||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Lng""",Lng,"""[0-9]{5}"""),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Enum ISO20022.Semt016001.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Semt016001.OptionStyle8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt016001.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Semt016001.OptionType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt016001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt016001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Semt016001.Pagination1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LastPgInd|String||XmlElement()||
|+|PgNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PgNb""",PgNb,"""[0-9]{1,5}"""))|

---

## Value ISO20022.Semt016001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Semt016001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Semt016001.Period2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDt|DateTime||XmlElement()||
|+|FrDt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt016001.Period7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FrDtToDt|ISO20022.Semt016001.Period2||XmlElement()||
|+|FrDtTmToDtTm|ISO20022.Semt016001.DateTimePeriod1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FrDtToDt),validElement(FrDtTmToDtTm),validChoice(FrDtToDt,FrDtTmToDtTm))|

---

## Value ISO20022.Semt016001.Price7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Semt016001.PriceRateOrAmount3Choice||XmlElement()||
|+|Tp|ISO20022.Semt016001.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Semt016001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Semt016001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Semt016001.PriceType4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indctv|ISO20022.Semt016001.Price7||XmlElement()||
|+|Mkt|ISO20022.Semt016001.Price7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indctv),validElement(Mkt),validChoice(Indctv,Mkt))|

---

## Enum ISO20022.Semt016001.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Semt016001.QuantityBreakdown60


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LotQty|ISO20022.Semt016001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|LotNb|ISO20022.Semt016001.GenericIdentification37||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LotQty),validElement(LotNb))|

---

## Value ISO20022.Semt016001.References72Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrcrTxId|String||XmlElement()||
|+|CtrPtyMktInfrstrctrTxId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|AcctOwnrTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(PrcrTxId,CtrPtyMktInfrstrctrTxId,MktInfrstrctrTxId,PoolId,AcctSvcrTxId,AcctOwnrTxId))|

---

## Enum ISO20022.Semt016001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Semt016001.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Semt016001.SafekeepingPlaceFormat41Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Semt016001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Semt016001.SafekeepingPlaceTypeAndText8||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Semt016001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt016001.SafekeepingPlaceTypeAndText8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt016001.SecuritiesAccount19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt016001.GenericIdentification30||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Enum ISO20022.Semt016001.SecuritiesBalanceType11Code


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

## Value ISO20022.Semt016001.SecuritiesBalanceType6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt016001.SecuritiesPaymentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NILL|Int32||XmlEnum("""NILL""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Semt016001.SecuritiesPaymentStatus5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt016001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Semt016001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Semt016001.Statement80


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ActvtyInd|String||XmlElement()||
|+|UpdTp|ISO20022.Semt016001.UpdateType15Choice||XmlElement()||
|+|Frqcy|ISO20022.Semt016001.Frequency25Choice||XmlElement()||
|+|StmtPrd|ISO20022.Semt016001.Period7Choice||XmlElement()||
|+|StmtId|String||XmlElement()||
|+|QryRef|String||XmlElement()||
|+|RptNb|ISO20022.Semt016001.Number3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UpdTp),validElement(Frqcy),validElement(StmtPrd),validElement(RptNb))|

---

## Enum ISO20022.Semt016001.StatementUpdateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DELT|Int32||XmlEnum("""DELT""")|1|
||COMP|Int32||XmlEnum("""COMP""")|2|

---

## Value ISO20022.Semt016001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Semt016001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Semt016001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt016001.UpdateType15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt016001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt016001.YieldedOrValueType1Choice


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

