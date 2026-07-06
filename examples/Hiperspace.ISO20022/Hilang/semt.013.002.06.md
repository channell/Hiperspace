# semt.013.002.06
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Semt013002.BlockChainAddressWallet7 {
        + Nm  : String
        + Tp  : ISO20022.Semt013002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Semt013002.BlockChainAddressWallet7 *-- ISO20022.Semt013002.GenericIdentification47
    class ISO20022.Semt013002.ClassificationType33Choice {
        + AltrnClssfctn  : ISO20022.Semt013002.GenericIdentification86
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Semt013002.ClassificationType33Choice *-- ISO20022.Semt013002.GenericIdentification86
    class ISO20022.Semt013002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Semt013002.DocumentNumber6Choice {
        + PrtryNb  : ISO20022.Semt013002.GenericIdentification86
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Semt013002.DocumentNumber6Choice *-- ISO20022.Semt013002.GenericIdentification86
    class ISO20022.Semt013002.EventFrequency3Code {
        WEEK = 1
        SEMI = 2
        QUTR = 3
        MNTH = 4
        YEAR = 5
    }
    class ISO20022.Semt013002.FinancialInstrumentAttributes119 {
        + FinInstrmAttrAddtlDtls  : String
        + UndrlygFinInstrmId  : global::System.Collections.Generic.List~ISO20022.Semt013002.SecurityIdentification32~
        + CtrctSz  : ISO20022.Semt013002.FinancialInstrumentQuantity36Choice
        + MinNmnlQty  : ISO20022.Semt013002.FinancialInstrumentQuantity36Choice
        + StrkPric  : ISO20022.Semt013002.Price3
        + ConvsPric  : ISO20022.Semt013002.Price3
        + SbcptPric  : ISO20022.Semt013002.Price3
        + ExrcPric  : ISO20022.Semt013002.Price3
        + MktOrIndctvPric  : ISO20022.Semt013002.PriceType5Choice
        + PutblInd  : String
        + CllblInd  : String
        + VarblRateInd  : String
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt013002.QuantityBreakdown64~
        + PoolNb  : ISO20022.Semt013002.GenericIdentification39
        + CpnAttchdNb  : ISO20022.Semt013002.Number23Choice
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
        + OptnTp  : ISO20022.Semt013002.OptionType7Choice
        + OptnStyle  : ISO20022.Semt013002.OptionStyle9Choice
        + ClssfctnTp  : ISO20022.Semt013002.ClassificationType33Choice
        + VarblRateChngFrqcy  : ISO20022.Semt013002.Frequency27Choice
        + PmtSts  : ISO20022.Semt013002.SecuritiesPaymentStatus6Choice
        + PmtFrqcy  : ISO20022.Semt013002.Frequency27Choice
        + RegnForm  : ISO20022.Semt013002.FormOfSecurity7Choice
        + DayCntBsis  : ISO20022.Semt013002.InterestComputationMethodFormat5Choice
        + PlcOfListg  : ISO20022.Semt013002.MarketIdentification4Choice
    }
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.SecurityIdentification32
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.FinancialInstrumentQuantity36Choice
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.FinancialInstrumentQuantity36Choice
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.Price3
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.Price3
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.Price3
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.Price3
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.PriceType5Choice
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.QuantityBreakdown64
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.GenericIdentification39
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.Number23Choice
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.OptionType7Choice
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.OptionStyle9Choice
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.ClassificationType33Choice
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.Frequency27Choice
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.SecuritiesPaymentStatus6Choice
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.Frequency27Choice
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.FormOfSecurity7Choice
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.InterestComputationMethodFormat5Choice
    ISO20022.Semt013002.FinancialInstrumentAttributes119 *-- ISO20022.Semt013002.MarketIdentification4Choice
    class ISO20022.Semt013002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Semt013002.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Semt013002.FormOfSecurity7Choice {
        + Prtry  : ISO20022.Semt013002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt013002.FormOfSecurity7Choice *-- ISO20022.Semt013002.GenericIdentification47
    class ISO20022.Semt013002.Frequency27Choice {
        + Prtry  : ISO20022.Semt013002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt013002.Frequency27Choice *-- ISO20022.Semt013002.GenericIdentification47
    class ISO20022.Semt013002.GenericIdentification18 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Semt013002.GenericIdentification39 {
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt013002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt013002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt013002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Semt013002.GenericIdentification47
    }
    ISO20022.Semt013002.GenericIdentification85 *-- ISO20022.Semt013002.GenericIdentification47
    class ISO20022.Semt013002.GenericIdentification86 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Semt013002.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt013002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Semt013002.InterestComputationMethod2Code {
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
    class ISO20022.Semt013002.InterestComputationMethodFormat5Choice {
        + Prtry  : ISO20022.Semt013002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt013002.InterestComputationMethodFormat5Choice *-- ISO20022.Semt013002.GenericIdentification47
    class ISO20022.Semt013002.IntraPositionDetails62 {
        + InstrPrcgAddtlDtls  : String
        + BalTo  : ISO20022.Semt013002.SecuritiesSubBalanceTypeAndQuantityBreakdown6
        + BalFr  : ISO20022.Semt013002.SecuritiesSubBalanceTypeAndQuantityBreakdown6
        + SttlmDt  : ISO20022.Semt013002.DateAndDateTime2Choice
        + SctiesSubBalId  : ISO20022.Semt013002.GenericIdentification39
        + SttlmQty  : ISO20022.Semt013002.FinancialInstrumentQuantity36Choice
        + Prty  : ISO20022.Semt013002.PriorityNumeric5Choice
    }
    ISO20022.Semt013002.IntraPositionDetails62 *-- ISO20022.Semt013002.SecuritiesSubBalanceTypeAndQuantityBreakdown6
    ISO20022.Semt013002.IntraPositionDetails62 *-- ISO20022.Semt013002.SecuritiesSubBalanceTypeAndQuantityBreakdown6
    ISO20022.Semt013002.IntraPositionDetails62 *-- ISO20022.Semt013002.DateAndDateTime2Choice
    ISO20022.Semt013002.IntraPositionDetails62 *-- ISO20022.Semt013002.GenericIdentification39
    ISO20022.Semt013002.IntraPositionDetails62 *-- ISO20022.Semt013002.FinancialInstrumentQuantity36Choice
    ISO20022.Semt013002.IntraPositionDetails62 *-- ISO20022.Semt013002.PriorityNumeric5Choice
    class ISO20022.Semt013002.IntraPositionMovementInstruction002V06 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Semt013002.SupplementaryData1~
        + IntraPosDtls  : ISO20022.Semt013002.IntraPositionDetails62
        + FinInstrmAttrbts  : ISO20022.Semt013002.FinancialInstrumentAttributes119
        + FinInstrmId  : ISO20022.Semt013002.SecurityIdentification20
        + SfkpgPlc  : ISO20022.Semt013002.SafekeepingPlaceFormat39Choice
        + BlckChainAdrOrWllt  : ISO20022.Semt013002.BlockChainAddressWallet7
        + SfkpgAcct  : ISO20022.Semt013002.SecuritiesAccount30
        + AcctOwnr  : ISO20022.Semt013002.PartyIdentification136Choice
        + Lnkgs  : global::System.Collections.Generic.List~ISO20022.Semt013002.Linkages60~
        + NbCounts  : ISO20022.Semt013002.NumberCount1Choice
        + CorpActnEvtId  : String
        + TxId  : String
    }
    ISO20022.Semt013002.IntraPositionMovementInstruction002V06 *-- ISO20022.Semt013002.SupplementaryData1
    ISO20022.Semt013002.IntraPositionMovementInstruction002V06 *-- ISO20022.Semt013002.IntraPositionDetails62
    ISO20022.Semt013002.IntraPositionMovementInstruction002V06 *-- ISO20022.Semt013002.FinancialInstrumentAttributes119
    ISO20022.Semt013002.IntraPositionMovementInstruction002V06 *-- ISO20022.Semt013002.SecurityIdentification20
    ISO20022.Semt013002.IntraPositionMovementInstruction002V06 *-- ISO20022.Semt013002.SafekeepingPlaceFormat39Choice
    ISO20022.Semt013002.IntraPositionMovementInstruction002V06 *-- ISO20022.Semt013002.BlockChainAddressWallet7
    ISO20022.Semt013002.IntraPositionMovementInstruction002V06 *-- ISO20022.Semt013002.SecuritiesAccount30
    ISO20022.Semt013002.IntraPositionMovementInstruction002V06 *-- ISO20022.Semt013002.PartyIdentification136Choice
    ISO20022.Semt013002.IntraPositionMovementInstruction002V06 *-- ISO20022.Semt013002.Linkages60
    ISO20022.Semt013002.IntraPositionMovementInstruction002V06 *-- ISO20022.Semt013002.NumberCount1Choice
    class ISO20022.Semt013002.Linkages60 {
        + RefOwnr  : ISO20022.Semt013002.PartyIdentification136Choice
        + Ref  : ISO20022.Semt013002.References50Choice
        + MsgNb  : ISO20022.Semt013002.DocumentNumber6Choice
        + PrcgPos  : ISO20022.Semt013002.ProcessingPosition10Choice
    }
    ISO20022.Semt013002.Linkages60 *-- ISO20022.Semt013002.PartyIdentification136Choice
    ISO20022.Semt013002.Linkages60 *-- ISO20022.Semt013002.References50Choice
    ISO20022.Semt013002.Linkages60 *-- ISO20022.Semt013002.DocumentNumber6Choice
    ISO20022.Semt013002.Linkages60 *-- ISO20022.Semt013002.ProcessingPosition10Choice
    class ISO20022.Semt013002.MarketIdentification4Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Semt013002.Number23Choice {
        + Lng  : ISO20022.Semt013002.GenericIdentification18
        + Shrt  : String
    }
    ISO20022.Semt013002.Number23Choice *-- ISO20022.Semt013002.GenericIdentification18
    class ISO20022.Semt013002.NumberCount1Choice {
        + TtlNb  : ISO20022.Semt013002.TotalNumber1
        + CurInstrNb  : String
    }
    ISO20022.Semt013002.NumberCount1Choice *-- ISO20022.Semt013002.TotalNumber1
    class ISO20022.Semt013002.OptionStyle2Code {
        EURO = 1
        AMER = 2
    }
    class ISO20022.Semt013002.OptionStyle9Choice {
        + Prtry  : ISO20022.Semt013002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt013002.OptionStyle9Choice *-- ISO20022.Semt013002.GenericIdentification47
    class ISO20022.Semt013002.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Semt013002.OptionType7Choice {
        + Prtry  : ISO20022.Semt013002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt013002.OptionType7Choice *-- ISO20022.Semt013002.GenericIdentification47
    class ISO20022.Semt013002.OtherIdentification2 {
        + Tp  : ISO20022.Semt013002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Semt013002.OtherIdentification2 *-- ISO20022.Semt013002.IdentificationSource4Choice
    class ISO20022.Semt013002.OtherIdentification3 {
        + Tp  : ISO20022.Semt013002.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Semt013002.OtherIdentification3 *-- ISO20022.Semt013002.IdentificationSource3Choice
    class ISO20022.Semt013002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Semt013002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Semt013002.PartyIdentification136Choice *-- ISO20022.Semt013002.GenericIdentification84
    class ISO20022.Semt013002.Price3 {
        + Val  : ISO20022.Semt013002.PriceRateOrAmount1Choice
        + Tp  : ISO20022.Semt013002.YieldedOrValueType1Choice
    }
    ISO20022.Semt013002.Price3 *-- ISO20022.Semt013002.PriceRateOrAmount1Choice
    ISO20022.Semt013002.Price3 *-- ISO20022.Semt013002.YieldedOrValueType1Choice
    class ISO20022.Semt013002.PriceRateOrAmount1Choice {
        + Amt  : ISO20022.Semt013002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Semt013002.PriceRateOrAmount1Choice *-- ISO20022.Semt013002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Semt013002.PriceType5Choice {
        + Indctv  : ISO20022.Semt013002.Price3
        + Mkt  : ISO20022.Semt013002.Price3
    }
    ISO20022.Semt013002.PriceType5Choice *-- ISO20022.Semt013002.Price3
    ISO20022.Semt013002.PriceType5Choice *-- ISO20022.Semt013002.Price3
    class ISO20022.Semt013002.PriceValueType1Code {
        PARV = 1
        PREM = 2
        DISC = 3
    }
    class ISO20022.Semt013002.PriorityNumeric5Choice {
        + Prtry  : ISO20022.Semt013002.GenericIdentification47
        + Nmrc  : String
    }
    ISO20022.Semt013002.PriorityNumeric5Choice *-- ISO20022.Semt013002.GenericIdentification47
    class ISO20022.Semt013002.ProcessingPosition10Choice {
        + Prtry  : ISO20022.Semt013002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt013002.ProcessingPosition10Choice *-- ISO20022.Semt013002.GenericIdentification47
    class ISO20022.Semt013002.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Semt013002.QuantityBreakdown64 {
        + LotQty  : ISO20022.Semt013002.FinancialInstrumentQuantity36Choice
        + LotNb  : ISO20022.Semt013002.GenericIdentification39
    }
    ISO20022.Semt013002.QuantityBreakdown64 *-- ISO20022.Semt013002.FinancialInstrumentQuantity36Choice
    ISO20022.Semt013002.QuantityBreakdown64 *-- ISO20022.Semt013002.GenericIdentification39
    class ISO20022.Semt013002.QuantityBreakdown65 {
        + SctiesSubBalTp  : ISO20022.Semt013002.GenericIdentification47
        + LotQty  : ISO20022.Semt013002.FinancialInstrumentQuantity36Choice
        + LotNb  : ISO20022.Semt013002.GenericIdentification39
    }
    ISO20022.Semt013002.QuantityBreakdown65 *-- ISO20022.Semt013002.GenericIdentification47
    ISO20022.Semt013002.QuantityBreakdown65 *-- ISO20022.Semt013002.FinancialInstrumentQuantity36Choice
    ISO20022.Semt013002.QuantityBreakdown65 *-- ISO20022.Semt013002.GenericIdentification39
    class ISO20022.Semt013002.References50Choice {
        + OthrTxId  : String
        + PoolId  : String
        + MktInfrstrctrTxId  : String
        + AcctSvcrTxId  : String
        + IntraBalMvmntId  : String
        + IntraPosMvmntId  : String
        + SctiesSttlmTxId  : String
    }
    class ISO20022.Semt013002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Semt013002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Semt013002.SafekeepingPlace3Code {
        SHHE = 1
    }
    class ISO20022.Semt013002.SafekeepingPlaceFormat39Choice {
        + Prtry  : ISO20022.Semt013002.GenericIdentification85
        + TpAndId  : ISO20022.Semt013002.SafekeepingPlaceTypeAndIdentification1
        + Ctry  : String
        + Id  : ISO20022.Semt013002.SafekeepingPlaceTypeAndText15
    }
    ISO20022.Semt013002.SafekeepingPlaceFormat39Choice *-- ISO20022.Semt013002.GenericIdentification85
    ISO20022.Semt013002.SafekeepingPlaceFormat39Choice *-- ISO20022.Semt013002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Semt013002.SafekeepingPlaceFormat39Choice *-- ISO20022.Semt013002.SafekeepingPlaceTypeAndText15
    class ISO20022.Semt013002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt013002.SafekeepingPlaceTypeAndText15 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Semt013002.SecuritiesAccount30 {
        + Nm  : String
        + Tp  : ISO20022.Semt013002.GenericIdentification47
        + Id  : String
    }
    ISO20022.Semt013002.SecuritiesAccount30 *-- ISO20022.Semt013002.GenericIdentification47
    class ISO20022.Semt013002.SecuritiesBalanceType11Code {
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
    class ISO20022.Semt013002.SecuritiesBalanceType8Choice {
        + Prtry  : ISO20022.Semt013002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt013002.SecuritiesBalanceType8Choice *-- ISO20022.Semt013002.GenericIdentification47
    class ISO20022.Semt013002.SecuritiesPaymentStatus1Code {
        PART = 1
        NILL = 2
        FULL = 3
    }
    class ISO20022.Semt013002.SecuritiesPaymentStatus6Choice {
        + Prtry  : ISO20022.Semt013002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Semt013002.SecuritiesPaymentStatus6Choice *-- ISO20022.Semt013002.GenericIdentification47
    class ISO20022.Semt013002.SecuritiesSubBalanceTypeAndQuantityBreakdown6 {
        + QtyBrkdwn  : global::System.Collections.Generic.List~ISO20022.Semt013002.QuantityBreakdown65~
        + Tp  : ISO20022.Semt013002.SecuritiesBalanceType8Choice
    }
    ISO20022.Semt013002.SecuritiesSubBalanceTypeAndQuantityBreakdown6 *-- ISO20022.Semt013002.QuantityBreakdown65
    ISO20022.Semt013002.SecuritiesSubBalanceTypeAndQuantityBreakdown6 *-- ISO20022.Semt013002.SecuritiesBalanceType8Choice
    class ISO20022.Semt013002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Semt013002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Semt013002.SecurityIdentification20 *-- ISO20022.Semt013002.OtherIdentification2
    class ISO20022.Semt013002.SecurityIdentification32 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Semt013002.OtherIdentification3~
        + ISIN  : String
    }
    ISO20022.Semt013002.SecurityIdentification32 *-- ISO20022.Semt013002.OtherIdentification3
    class ISO20022.Semt013002.SupplementaryData1 {
        + Envlp  : ISO20022.Semt013002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Semt013002.SupplementaryData1 *-- ISO20022.Semt013002.SupplementaryDataEnvelope1
    class ISO20022.Semt013002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Semt013002.TotalNumber1 {
        + TtlOfLkdInstrs  : String
        + CurInstrNb  : String
    }
    class ISO20022.Semt013002.YieldedOrValueType1Choice {
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

## Value ISO20022.Semt013002.BlockChainAddressWallet7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt013002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,70}"""),validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Value ISO20022.Semt013002.ClassificationType33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Semt013002.GenericIdentification86||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Value ISO20022.Semt013002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Type ISO20022.Semt013002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IntraPosMvmntInstr|ISO20022.Semt013002.IntraPositionMovementInstruction002V06||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IntraPosMvmntInstr))|

---

## Value ISO20022.Semt013002.DocumentNumber6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Semt013002.GenericIdentification86||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Enum ISO20022.Semt013002.EventFrequency3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WEEK|Int32||XmlEnum("""WEEK""")|1|
||SEMI|Int32||XmlEnum("""SEMI""")|2|
||QUTR|Int32||XmlEnum("""QUTR""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||YEAR|Int32||XmlEnum("""YEAR""")|5|

---

## Value ISO20022.Semt013002.FinancialInstrumentAttributes119


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmAttrAddtlDtls|String||XmlElement()||
|+|UndrlygFinInstrmId|global::System.Collections.Generic.List<ISO20022.Semt013002.SecurityIdentification32>||XmlElement()||
|+|CtrctSz|ISO20022.Semt013002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Semt013002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|StrkPric|ISO20022.Semt013002.Price3||XmlElement()||
|+|ConvsPric|ISO20022.Semt013002.Price3||XmlElement()||
|+|SbcptPric|ISO20022.Semt013002.Price3||XmlElement()||
|+|ExrcPric|ISO20022.Semt013002.Price3||XmlElement()||
|+|MktOrIndctvPric|ISO20022.Semt013002.PriceType5Choice||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt013002.QuantityBreakdown64>||XmlElement()||
|+|PoolNb|ISO20022.Semt013002.GenericIdentification39||XmlElement()||
|+|CpnAttchdNb|ISO20022.Semt013002.Number23Choice||XmlElement()||
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
|+|OptnTp|ISO20022.Semt013002.OptionType7Choice||XmlElement()||
|+|OptnStyle|ISO20022.Semt013002.OptionStyle9Choice||XmlElement()||
|+|ClssfctnTp|ISO20022.Semt013002.ClassificationType33Choice||XmlElement()||
|+|VarblRateChngFrqcy|ISO20022.Semt013002.Frequency27Choice||XmlElement()||
|+|PmtSts|ISO20022.Semt013002.SecuritiesPaymentStatus6Choice||XmlElement()||
|+|PmtFrqcy|ISO20022.Semt013002.Frequency27Choice||XmlElement()||
|+|RegnForm|ISO20022.Semt013002.FormOfSecurity7Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Semt013002.InterestComputationMethodFormat5Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Semt013002.MarketIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FinInstrmAttrAddtlDtls""",FinInstrmAttrAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validList("""UndrlygFinInstrmId""",UndrlygFinInstrmId),validElement(UndrlygFinInstrmId),validElement(CtrctSz),validElement(MinNmnlQty),validElement(StrkPric),validElement(ConvsPric),validElement(SbcptPric),validElement(ExrcPric),validElement(MktOrIndctvPric),validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(PoolNb),validElement(CpnAttchdNb),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(OptnTp),validElement(OptnStyle),validElement(ClssfctnTp),validElement(VarblRateChngFrqcy),validElement(PmtSts),validElement(PmtFrqcy),validElement(RegnForm),validElement(DayCntBsis),validElement(PlcOfListg))|

---

## Value ISO20022.Semt013002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Enum ISO20022.Semt013002.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Semt013002.FormOfSecurity7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt013002.Frequency27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt013002.GenericIdentification18


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt013002.GenericIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Issr""",Issr,"""([^/]+/)+([^/]+)\|([^/]*)"""),validPattern("""Id""",Id,"""([^/]+/)+([^/]+)\|([^/]*)"""))|

---

## Value ISO20022.Semt013002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Semt013002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt013002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Semt013002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Semt013002.GenericIdentification86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt013002.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt013002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt013002.InterestComputationMethod2Code


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

## Value ISO20022.Semt013002.InterestComputationMethodFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt013002.IntraPositionDetails62


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrPrcgAddtlDtls|String||XmlElement()||
|+|BalTo|ISO20022.Semt013002.SecuritiesSubBalanceTypeAndQuantityBreakdown6||XmlElement()||
|+|BalFr|ISO20022.Semt013002.SecuritiesSubBalanceTypeAndQuantityBreakdown6||XmlElement()||
|+|SttlmDt|ISO20022.Semt013002.DateAndDateTime2Choice||XmlElement()||
|+|SctiesSubBalId|ISO20022.Semt013002.GenericIdentification39||XmlElement()||
|+|SttlmQty|ISO20022.Semt013002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|Prty|ISO20022.Semt013002.PriorityNumeric5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""InstrPrcgAddtlDtls""",InstrPrcgAddtlDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validElement(BalTo),validElement(BalFr),validElement(SttlmDt),validElement(SctiesSubBalId),validElement(SttlmQty),validElement(Prty))|

---

## Aspect ISO20022.Semt013002.IntraPositionMovementInstruction002V06


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Semt013002.SupplementaryData1>||XmlElement()||
|+|IntraPosDtls|ISO20022.Semt013002.IntraPositionDetails62||XmlElement()||
|+|FinInstrmAttrbts|ISO20022.Semt013002.FinancialInstrumentAttributes119||XmlElement()||
|+|FinInstrmId|ISO20022.Semt013002.SecurityIdentification20||XmlElement()||
|+|SfkpgPlc|ISO20022.Semt013002.SafekeepingPlaceFormat39Choice||XmlElement()||
|+|BlckChainAdrOrWllt|ISO20022.Semt013002.BlockChainAddressWallet7||XmlElement()||
|+|SfkpgAcct|ISO20022.Semt013002.SecuritiesAccount30||XmlElement()||
|+|AcctOwnr|ISO20022.Semt013002.PartyIdentification136Choice||XmlElement()||
|+|Lnkgs|global::System.Collections.Generic.List<ISO20022.Semt013002.Linkages60>||XmlElement()||
|+|NbCounts|ISO20022.Semt013002.NumberCount1Choice||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
|+|TxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(IntraPosDtls),validElement(FinInstrmAttrbts),validElement(FinInstrmId),validElement(SfkpgPlc),validElement(BlckChainAdrOrWllt),validElement(SfkpgAcct),validElement(AcctOwnr),validList("""Lnkgs""",Lnkgs),validElement(Lnkgs),validElement(NbCounts),validPattern("""CorpActnEvtId""",CorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""TxId""",TxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt013002.Linkages60


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RefOwnr|ISO20022.Semt013002.PartyIdentification136Choice||XmlElement()||
|+|Ref|ISO20022.Semt013002.References50Choice||XmlElement()||
|+|MsgNb|ISO20022.Semt013002.DocumentNumber6Choice||XmlElement()||
|+|PrcgPos|ISO20022.Semt013002.ProcessingPosition10Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RefOwnr),validElement(Ref),validElement(MsgNb),validElement(PrcgPos))|

---

## Value ISO20022.Semt013002.MarketIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Semt013002.Number23Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Lng|ISO20022.Semt013002.GenericIdentification18||XmlElement()||
|+|Shrt|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Lng),validPattern("""Shrt""",Shrt,"""[0-9]{3}"""),validChoice(Lng,Shrt))|

---

## Value ISO20022.Semt013002.NumberCount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlNb|ISO20022.Semt013002.TotalNumber1||XmlElement()||
|+|CurInstrNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(TtlNb),validPattern("""CurInstrNb""",CurInstrNb,"""[0-9]{3}"""),validChoice(TtlNb,CurInstrNb))|

---

## Enum ISO20022.Semt013002.OptionStyle2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EURO|Int32||XmlEnum("""EURO""")|1|
||AMER|Int32||XmlEnum("""AMER""")|2|

---

## Value ISO20022.Semt013002.OptionStyle9Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt013002.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Semt013002.OptionType7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt013002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt013002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Semt013002.OtherIdentification3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Semt013002.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Semt013002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Semt013002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Semt013002.Price3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Semt013002.PriceRateOrAmount1Choice||XmlElement()||
|+|Tp|ISO20022.Semt013002.YieldedOrValueType1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val),validElement(Tp))|

---

## Value ISO20022.Semt013002.PriceRateOrAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Semt013002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Semt013002.PriceType5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Indctv|ISO20022.Semt013002.Price3||XmlElement()||
|+|Mkt|ISO20022.Semt013002.Price3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Indctv),validElement(Mkt),validChoice(Indctv,Mkt))|

---

## Enum ISO20022.Semt013002.PriceValueType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PARV|Int32||XmlEnum("""PARV""")|1|
||PREM|Int32||XmlEnum("""PREM""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|

---

## Value ISO20022.Semt013002.PriorityNumeric5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013002.GenericIdentification47||XmlElement()||
|+|Nmrc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validPattern("""Nmrc""",Nmrc,"""[0-9]{4}"""),validChoice(Prtry,Nmrc))|

---

## Value ISO20022.Semt013002.ProcessingPosition10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt013002.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Semt013002.QuantityBreakdown64


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LotQty|ISO20022.Semt013002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|LotNb|ISO20022.Semt013002.GenericIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LotQty),validElement(LotNb))|

---

## Value ISO20022.Semt013002.QuantityBreakdown65


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctiesSubBalTp|ISO20022.Semt013002.GenericIdentification47||XmlElement()||
|+|LotQty|ISO20022.Semt013002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|LotNb|ISO20022.Semt013002.GenericIdentification39||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctiesSubBalTp),validElement(LotQty),validElement(LotNb))|

---

## Value ISO20022.Semt013002.References50Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OthrTxId|String||XmlElement()||
|+|PoolId|String||XmlElement()||
|+|MktInfrstrctrTxId|String||XmlElement()||
|+|AcctSvcrTxId|String||XmlElement()||
|+|IntraBalMvmntId|String||XmlElement()||
|+|IntraPosMvmntId|String||XmlElement()||
|+|SctiesSttlmTxId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""OthrTxId""",OthrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""PoolId""",PoolId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktInfrstrctrTxId""",MktInfrstrctrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrTxId""",AcctSvcrTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""IntraBalMvmntId""",IntraBalMvmntId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""IntraPosMvmntId""",IntraPosMvmntId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""SctiesSttlmTxId""",SctiesSttlmTxId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validChoice(OthrTxId,PoolId,MktInfrstrctrTxId,AcctSvcrTxId,IntraBalMvmntId,IntraPosMvmntId,SctiesSttlmTxId))|

---

## Value ISO20022.Semt013002.RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Semt013002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Semt013002.SafekeepingPlace3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|

---

## Value ISO20022.Semt013002.SafekeepingPlaceFormat39Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Semt013002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Semt013002.SafekeepingPlaceTypeAndText15||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,Ctry,Id))|

---

## Value ISO20022.Semt013002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Semt013002.SafekeepingPlaceTypeAndText15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Semt013002.SecuritiesAccount30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
|+|Tp|ISO20022.Semt013002.GenericIdentification47||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Enum ISO20022.Semt013002.SecuritiesBalanceType11Code


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

## Value ISO20022.Semt013002.SecuritiesBalanceType8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Semt013002.SecuritiesPaymentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NILL|Int32||XmlEnum("""NILL""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Semt013002.SecuritiesPaymentStatus6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Semt013002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Semt013002.SecuritiesSubBalanceTypeAndQuantityBreakdown6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyBrkdwn|global::System.Collections.Generic.List<ISO20022.Semt013002.QuantityBreakdown65>||XmlElement()||
|+|Tp|ISO20022.Semt013002.SecuritiesBalanceType8Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""QtyBrkdwn""",QtyBrkdwn),validElement(QtyBrkdwn),validElement(Tp))|

---

## Value ISO20022.Semt013002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Semt013002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Semt013002.SecurityIdentification32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Semt013002.OtherIdentification3>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Value ISO20022.Semt013002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Semt013002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Semt013002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Semt013002.TotalNumber1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TtlOfLkdInstrs|String||XmlElement()||
|+|CurInstrNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""TtlOfLkdInstrs""",TtlOfLkdInstrs,"""[0-9]{3}"""),validPattern("""CurInstrNb""",CurInstrNb,"""[0-9]{3}"""))|

---

## Value ISO20022.Semt013002.YieldedOrValueType1Choice


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

