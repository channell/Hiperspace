# reda.007.001.01
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Reda007001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Reda007001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Reda007001.ActiveOrHistoricCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Reda007001.AddressType1Code {
        BIZZ = 1
        HOME = 2
    }
    class ISO20022.Reda007001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Reda007001.AmountOrPercentageRange1 {
        + Term  : global::System.Collections.Generic.List~ISO20022.Reda007001.Term1~
        + Opr  : String
    }
    ISO20022.Reda007001.AmountOrPercentageRange1 *-- ISO20022.Reda007001.Term1
    class ISO20022.Reda007001.Appearance1Code {
        GLOB = 1
        TMPG = 2
        DLBE = 3
        DFBE = 4
        BENT = 5
        LIMI = 6
        NDEL = 7
        DELI = 8
    }
    class ISO20022.Reda007001.Appearance3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.Appearance3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.AssignmentMethod1Code {
        PROR = 1
        RAND = 2
    }
    class ISO20022.Reda007001.AssignmentMethod2Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.AssignmentMethod2Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.BenchmarkCurve6 {
        + BchmkCrvPt  : String
        + BchmkCrvNm  : ISO20022.Reda007001.BenchmarkCurveName7Choice
        + BchmkCrvCcy  : String
        + BchmkPric  : ISO20022.Reda007001.Price8
        + BchmkId  : ISO20022.Reda007001.SecurityIdentification39
        + Sprd  : Decimal
    }
    ISO20022.Reda007001.BenchmarkCurve6 *-- ISO20022.Reda007001.BenchmarkCurveName7Choice
    ISO20022.Reda007001.BenchmarkCurve6 *-- ISO20022.Reda007001.Price8
    ISO20022.Reda007001.BenchmarkCurve6 *-- ISO20022.Reda007001.SecurityIdentification39
    class ISO20022.Reda007001.BenchmarkCurveName1Code {
        PFAN = 1
        EURI = 2
        TREA = 3
        SWAP = 4
        LIBO = 5
        LIBI = 6
        FUSW = 7
        MAAA = 8
    }
    class ISO20022.Reda007001.BenchmarkCurveName7Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.BenchmarkCurveName7Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.CalculationType1Code {
        WRST = 1
        TRYL = 2
        TTDT = 3
        TXQV = 4
        SPLL = 5
        SHLF = 6
        SEMI = 7
        PRYL = 8
        PRCL = 9
        NXPT = 10
        PNAV = 11
        NXRF = 12
        YTMA = 13
        MARK = 14
        LGAL = 15
        LSYR = 16
        LSQR = 17
        LSMT = 18
        LSCL = 19
        NVFL = 20
        FLAS = 21
        GVEQ = 22
        TRGR = 23
        CUYI = 24
        CMPD = 25
        CLOS = 26
        CHCL = 27
        YTNC = 28
        BOOK = 29
        AVMA = 30
        ISSU = 31
        ANNU = 32
        AFTX = 33
    }
    class ISO20022.Reda007001.CalculationType3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.CalculationType3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.CallType1Code {
        PRTA = 1
        LOTT = 2
    }
    class ISO20022.Reda007001.CallType3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.CallType3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.ClassificationType2 {
        + AltrnClssfctn  : global::System.Collections.Generic.List~ISO20022.Reda007001.GenericIdentification36~
        + FinInstrmPdctTpCd  : String
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Reda007001.ClassificationType2 *-- ISO20022.Reda007001.GenericIdentification36
    class ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 {
        + UndrlygRsk  : ISO20022.Reda007001.Organisation38
        + Dpstry  : ISO20022.Reda007001.Organisation38
        + PngAgt  : ISO20022.Reda007001.Organisation38
        + PrncplPngAgt  : ISO20022.Reda007001.Organisation38
        + LeadMgr  : ISO20022.Reda007001.Organisation38
        + CtctNm  : ISO20022.Reda007001.Organisation38
        + FinInstrmForm  : ISO20022.Reda007001.FinancialInstrumentForm2
        + SttlmInf  : global::System.Collections.Generic.List~ISO20022.Reda007001.SettlementInformation17~
        + FinInstrmId  : ISO20022.Reda007001.SecurityIdentification39
        + Rstrctn  : global::System.Collections.Generic.List~ISO20022.Reda007001.SecurityRestriction3~
        + RedPmtCcy  : String
        + RedTp  : ISO20022.Reda007001.MaturityRedemptionType3Choice
        + CmonSfkpr  : ISO20022.Reda007001.PartyIdentification177Choice
        + AftrXchgPhysForm  : ISO20022.Reda007001.InitialPhysicalForm3Choice
        + InitlPhysForm  : ISO20022.Reda007001.InitialPhysicalForm4Choice
        + PmtSts  : ISO20022.Reda007001.SecuritiesPaymentStatus5Choice
        + WhldgTaxRgm  : global::System.Collections.Generic.List~ISO20022.Reda007001.SecurityWithHoldingTax1~
        + Clss  : String
        + SrNb  : String
        + TEFRARule  : ISO20022.Reda007001.TEFRARules3Choice
        + TradgMtd  : ISO20022.Reda007001.UnitOrFaceAmount1Choice
        + PmryPlcOfDpst  : ISO20022.Reda007001.PartyIdentification136
        + ConvsRatioDnmtr  : ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
        + ConvsRatioNmrtr  : ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
        + ConvsPrd  : ISO20022.Reda007001.DateTimePeriod1
        + ConvtblInd  : String
        + PrvtPlcmnt  : String
        + Cnfdtl  : String
        + FngbInd  : String
        + CallTp  : ISO20022.Reda007001.CallType3Choice
        + PutTp  : ISO20022.Reda007001.PutType3Choice
        + SprdAndBchmkCrv  : global::System.Collections.Generic.List~ISO20022.Reda007001.BenchmarkCurve6~
        + TradgMkt  : global::System.Collections.Generic.List~ISO20022.Reda007001.TradingParameters2~
        + Issnc  : ISO20022.Reda007001.Issuance5
        + ClssfctnTp  : ISO20022.Reda007001.ClassificationType2
        + Purp  : String
        + XpryDt  : DateTime
        + RcrdDt  : DateTime
        + ListgDt  : DateTime
        + NearTermPosLmt  : ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
        + PosLmt  : ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
        + LglRstrctns  : ISO20022.Reda007001.LegalRestrictions4Choice
        + CvrdInd  : String
        + PoolNb  : String
        + TaxLotNb  : String
        + CpnAttchdNb  : String
        + CtrctVrsnNb  : Decimal
        + CertNb  : String
        + DnmtnCcy  : String
        + NmVldFr  : ISO20022.Reda007001.DateAndDateTime2Choice
        + ISOSctyShrtNm  : String
        + ISOSctyLngNm  : String
        + SctySts  : ISO20022.Reda007001.SecurityStatus3Choice
    }
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.Organisation38
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.Organisation38
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.Organisation38
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.Organisation38
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.Organisation38
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.Organisation38
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.FinancialInstrumentForm2
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.SettlementInformation17
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.SecurityIdentification39
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.SecurityRestriction3
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.MaturityRedemptionType3Choice
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.PartyIdentification177Choice
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.InitialPhysicalForm3Choice
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.InitialPhysicalForm4Choice
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.SecuritiesPaymentStatus5Choice
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.SecurityWithHoldingTax1
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.TEFRARules3Choice
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.UnitOrFaceAmount1Choice
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.PartyIdentification136
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.DateTimePeriod1
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.CallType3Choice
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.PutType3Choice
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.BenchmarkCurve6
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.TradingParameters2
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.Issuance5
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.ClassificationType2
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.LegalRestrictions4Choice
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.DateAndDateTime2Choice
    ISO20022.Reda007001.CommonFinancialInstrumentAttributes12 *-- ISO20022.Reda007001.SecurityStatus3Choice
    class ISO20022.Reda007001.CommunicationAddress3 {
        + URLAdr  : String
        + TlxAdr  : String
        + FaxNb  : String
        + Mob  : String
        + Phne  : String
        + Email  : String
    }
    class ISO20022.Reda007001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Reda007001.DateTimePeriod1 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Reda007001.DateTimePeriod1Choice {
        + DtTmRg  : ISO20022.Reda007001.DateTimePeriod1
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    ISO20022.Reda007001.DateTimePeriod1Choice *-- ISO20022.Reda007001.DateTimePeriod1
    class ISO20022.Reda007001.DateTimePeriod2 {
        + ToDtTm  : DateTime
        + FrDtTm  : DateTime
    }
    class ISO20022.Reda007001.Debt5 {
        + PricRg  : ISO20022.Reda007001.AmountOrPercentageRange1
        + PricSrc  : String
        + WhlPoolInd  : String
        + SbstitnLft  : Decimal
        + SbstitnFrqcy  : ISO20022.Reda007001.Frequency35Choice
        + Sctr  : String
        + PricFrqcy  : ISO20022.Reda007001.Frequency35Choice
        + RstrctdInd  : String
        + Pdctn  : String
        + MinQty  : ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
        + MinIncrmt  : ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
        + MaxSbstitn  : Decimal
        + LookBck  : Decimal
        + TxConds  : ISO20022.Reda007001.TradeTransactionCondition7Choice
        + Hrcut  : Decimal
        + AutoRinvstmt  : Decimal
        + AltrntvMinTaxInd  : String
        + Purp  : String
        + CpnRg  : ISO20022.Reda007001.AmountOrPercentageRange1
        + YldRg  : ISO20022.Reda007001.AmountOrPercentageRange1
        + Geogcs  : String
        + PotntlEuroSysElgblty  : String
        + GblTp  : ISO20022.Reda007001.GlobalNote2Choice
        + InstrmStrTp  : ISO20022.Reda007001.InstrumentSubStructureType2Choice
        + IntrstTp  : String
        + YldClctn  : global::System.Collections.Generic.List~ISO20022.Reda007001.YieldCalculation6~
        + BkQlfdInd  : String
        + InsrdInd  : String
        + WghtdAvrgMtrty  : Decimal
        + WghtdAvrgLn  : Decimal
        + WghtdAvrgLife  : Decimal
        + WghtdAvrgCpn  : Decimal
        + CstPrePmtYld  : Decimal
        + LotId  : String
        + CstPrePmtPnltyInd  : String
        + PlsPerTrad  : Decimal
        + PlsPerLot  : Decimal
        + PlsPerMln  : Decimal
        + PlsMax  : Decimal
        + Pcs  : Decimal
        + PrvsFctr  : Decimal
        + NxtFctr  : Decimal
        + CurFctr  : Decimal
        + ActlDnmtnAmt  : global::System.Collections.Generic.List~ISO20022.Reda007001.ActiveCurrencyAndAmount~
        + CptlsdIntrst  : ISO20022.Reda007001.DistributionPolicy2Choice
        + IntrstClctnMtd  : String
        + AmtsblInd  : String
        + OverAlltmtRate  : Decimal
        + OverAlltmtAmt  : ISO20022.Reda007001.ActiveCurrencyAndAmount
        + VarblRateInd  : String
        + XtndblPrd  : ISO20022.Reda007001.DateTimePeriod1Choice
        + XtndblInd  : String
        + SubrdntdInd  : String
        + PerptlInd  : String
        + EscrwdInd  : String
        + PreFnddInd  : String
        + PutblInd  : String
        + IntrstAcrlDt  : DateTime
        + CPRegnTp  : String
        + CPPrgm  : Decimal
        + CllblInd  : String
        + OddCpnInd  : String
        + NxtIntrstRate  : Decimal
        + IntrstRate  : Decimal
        + PmtDrctnInd  : String
        + XprtnDt  : DateTime
        + NxtFctrDt  : DateTime
        + NxtCllblDt  : DateTime
        + PutblDt  : DateTime
        + NxtCpnDt  : DateTime
        + MtrtyDt  : DateTime
        + FrstPmtDt  : DateTime
        + DtdDt  : DateTime
        + IntrstFxgDt  : DateTime
        + PmtFrqcy  : ISO20022.Reda007001.Frequency35Choice
        + FaceAmt  : ISO20022.Reda007001.ActiveCurrencyAndAmount
        + PmtCcy  : String
    }
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.AmountOrPercentageRange1
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.Frequency35Choice
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.Frequency35Choice
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.TradeTransactionCondition7Choice
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.AmountOrPercentageRange1
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.AmountOrPercentageRange1
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.GlobalNote2Choice
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.InstrumentSubStructureType2Choice
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.YieldCalculation6
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.ActiveCurrencyAndAmount
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.DistributionPolicy2Choice
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.ActiveCurrencyAndAmount
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.DateTimePeriod1Choice
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.Frequency35Choice
    ISO20022.Reda007001.Debt5 *-- ISO20022.Reda007001.ActiveCurrencyAndAmount
    class ISO20022.Reda007001.Derivative4 {
        + Optn  : ISO20022.Reda007001.Option15
        + Futr  : ISO20022.Reda007001.Future4
    }
    ISO20022.Reda007001.Derivative4 *-- ISO20022.Reda007001.Option15
    ISO20022.Reda007001.Derivative4 *-- ISO20022.Reda007001.Future4
    class ISO20022.Reda007001.DistributionPolicy1Code {
        ACCU = 1
        DIST = 2
    }
    class ISO20022.Reda007001.DistributionPolicy2Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.DistributionPolicy2Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.Equity3 {
        + VtngRghtsPerShr  : Decimal
        + ParVal  : ISO20022.Reda007001.ActiveCurrencyAndAmount
        + NonPdAmt  : ISO20022.Reda007001.ActiveCurrencyAndAmount
        + MtrtyDt  : DateTime
        + PrefToIncm  : ISO20022.Reda007001.PreferenceToIncome5Choice
    }
    ISO20022.Reda007001.Equity3 *-- ISO20022.Reda007001.ActiveCurrencyAndAmount
    ISO20022.Reda007001.Equity3 *-- ISO20022.Reda007001.ActiveCurrencyAndAmount
    ISO20022.Reda007001.Equity3 *-- ISO20022.Reda007001.PreferenceToIncome5Choice
    class ISO20022.Reda007001.FinancialInstrument97 {
        + Deriv  : ISO20022.Reda007001.Derivative4
        + Debt  : ISO20022.Reda007001.Debt5
        + Warrt  : ISO20022.Reda007001.Warrant4
        + Eqty  : ISO20022.Reda007001.Equity3
    }
    ISO20022.Reda007001.FinancialInstrument97 *-- ISO20022.Reda007001.Derivative4
    ISO20022.Reda007001.FinancialInstrument97 *-- ISO20022.Reda007001.Debt5
    ISO20022.Reda007001.FinancialInstrument97 *-- ISO20022.Reda007001.Warrant4
    ISO20022.Reda007001.FinancialInstrument97 *-- ISO20022.Reda007001.Equity3
    class ISO20022.Reda007001.FinancialInstrumentForm2 {
        + LglForm  : ISO20022.Reda007001.FormOfSecurity8Choice
        + BookgApprnc  : ISO20022.Reda007001.Appearance3Choice
    }
    ISO20022.Reda007001.FinancialInstrumentForm2 *-- ISO20022.Reda007001.FormOfSecurity8Choice
    ISO20022.Reda007001.FinancialInstrumentForm2 *-- ISO20022.Reda007001.Appearance3Choice
    class ISO20022.Reda007001.FinancialInstrumentQuantity1Choice {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Reda007001.FormOfSecurity1Code {
        REGD = 1
        BEAR = 2
    }
    class ISO20022.Reda007001.FormOfSecurity8Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.FormOfSecurity8Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.Frequency35Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.Frequency35Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.Frequency5Code {
        TEND = 1
        OVNG = 2
        INDA = 3
        ADHO = 4
        DAIL = 5
        WEEK = 6
        MIAN = 7
        QURT = 8
        MNTH = 9
        YEAR = 10
    }
    class ISO20022.Reda007001.Future4 {
        + AddtlUndrlygAttrbts  : global::System.Collections.Generic.List~ISO20022.Reda007001.UnderlyingAttributes4~
        + TmUnit  : ISO20022.Reda007001.TimeUnit3Choice
        + UnitOfMeasr  : ISO20022.Reda007001.UnitOfMeasure7Choice
        + MinSz  : ISO20022.Reda007001.ActiveCurrencyAndAmount
        + FutrDt  : DateTime
        + ExrcPric  : ISO20022.Reda007001.Price8
        + CtrctSz  : Decimal
    }
    ISO20022.Reda007001.Future4 *-- ISO20022.Reda007001.UnderlyingAttributes4
    ISO20022.Reda007001.Future4 *-- ISO20022.Reda007001.TimeUnit3Choice
    ISO20022.Reda007001.Future4 *-- ISO20022.Reda007001.UnitOfMeasure7Choice
    ISO20022.Reda007001.Future4 *-- ISO20022.Reda007001.ActiveCurrencyAndAmount
    ISO20022.Reda007001.Future4 *-- ISO20022.Reda007001.Price8
    class ISO20022.Reda007001.GenericIdentification1 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Reda007001.GenericIdentification13 {
        + Issr  : String
        + SchmeNm  : String
        + Id  : String
    }
    class ISO20022.Reda007001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Reda007001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Reda007001.GlobalNote1Code {
        CGNO = 1
        NGNO = 2
    }
    class ISO20022.Reda007001.GlobalNote2Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.GlobalNote2Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Reda007001.InitialPhysicalForm1Code {
        DERN = 1
        GPGP = 2
        GTGT = 3
    }
    class ISO20022.Reda007001.InitialPhysicalForm2Code {
        DERN = 1
        GPGP = 2
    }
    class ISO20022.Reda007001.InitialPhysicalForm3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.InitialPhysicalForm3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.InitialPhysicalForm4Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.InitialPhysicalForm4Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.InstrumentSubStructureType1Code {
        WBSE = 1
        STUT = 2
        STRB = 3
        SCBO = 4
        RMBS = 5
        REPK = 6
        PYRT = 7
        PFAB = 8
        LPNO = 9
        HELO = 10
        CRCT = 11
        CSMR = 12
        CMBS = 13
        CLOB = 14
        CLNO = 15
        CDOB = 16
        CBOB = 17
        AUTT = 18
        AIRT = 19
        ABSE = 20
    }
    class ISO20022.Reda007001.InstrumentSubStructureType2Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.InstrumentSubStructureType2Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.InterestType3Code {
        DSCO = 1
        INDE = 2
        DUAL = 3
        FLRN = 4
        FIXD = 5
        ZCPN = 6
    }
    class ISO20022.Reda007001.InvestorRestrictionType1Code {
        INDV = 1
        CITI = 2
        LERE = 3
    }
    class ISO20022.Reda007001.InvestorRestrictionType3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.InvestorRestrictionType3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.InvestorType1Code {
        PPER = 1
        STAF = 2
        PROF = 3
        RETL = 4
    }
    class ISO20022.Reda007001.InvestorType3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.InvestorType3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.Issuance5 {
        + GovngLaw  : global::System.Collections.Generic.List~ISO20022.Reda007001.Jurisdiction1~
        + IssncDstrbtn  : ISO20022.Reda007001.SecuritiesTransactionType31Choice
        + IssePric  : ISO20022.Reda007001.PriceValue1
        + IsseSz  : Decimal
        + FullIssdAmt  : ISO20022.Reda007001.ActiveCurrencyAndAmount
        + IsseNmnlAmt  : ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
        + IssrOrg  : ISO20022.Reda007001.Organisation38
        + ISINVldFr  : DateTime
        + AnncmntDt  : DateTime
        + IsseDt  : DateTime
        + CtryOfIsse  : String
        + IssePlc  : String
    }
    ISO20022.Reda007001.Issuance5 *-- ISO20022.Reda007001.Jurisdiction1
    ISO20022.Reda007001.Issuance5 *-- ISO20022.Reda007001.SecuritiesTransactionType31Choice
    ISO20022.Reda007001.Issuance5 *-- ISO20022.Reda007001.PriceValue1
    ISO20022.Reda007001.Issuance5 *-- ISO20022.Reda007001.ActiveCurrencyAndAmount
    ISO20022.Reda007001.Issuance5 *-- ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
    ISO20022.Reda007001.Issuance5 *-- ISO20022.Reda007001.Organisation38
    class ISO20022.Reda007001.Jurisdiction1 {
        + Ctry  : String
        + Id  : String
    }
    class ISO20022.Reda007001.LegalRestrictions1Code {
        REST = 1
        NORE = 2
        USLE = 3
    }
    class ISO20022.Reda007001.LegalRestrictions2Code {
        PRIV = 1
        MARG = 2
        ACRI = 3
        PPLA = 4
        JURO = 5
    }
    class ISO20022.Reda007001.LegalRestrictions4Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.LegalRestrictions4Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.LegalRestrictions5Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.LegalRestrictions5Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.MaturityRedemptionType1Code {
        PUUT = 1
        CALL = 2
        PRRA = 3
        RNDM = 4
        PRWR = 5
        PRNR = 6
        FRED = 7
    }
    class ISO20022.Reda007001.MaturityRedemptionType3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.MaturityRedemptionType3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.MessageHeader1 {
        + CreDtTm  : DateTime
        + MsgId  : String
    }
    class ISO20022.Reda007001.NameAndAddress4 {
        + Adr  : ISO20022.Reda007001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Reda007001.NameAndAddress4 *-- ISO20022.Reda007001.PostalAddress1
    class ISO20022.Reda007001.NameAndAddress5 {
        + Adr  : ISO20022.Reda007001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Reda007001.NameAndAddress5 *-- ISO20022.Reda007001.PostalAddress1
    class ISO20022.Reda007001.Operation1Code {
        ANDD = 1
        ORRR = 2
        TILL = 3
    }
    class ISO20022.Reda007001.Operator1Code {
        EQAL = 1
        GREQ = 2
        GREA = 3
        SMEQ = 4
        SMAL = 5
    }
    class ISO20022.Reda007001.Option15 {
        + AddtlUndrlygAttrbts  : global::System.Collections.Generic.List~ISO20022.Reda007001.UnderlyingAttributes4~
        + CtrctSz  : Decimal
        + TradgPtyRole  : ISO20022.Reda007001.OptionParty3Choice
        + Stdstn  : ISO20022.Reda007001.Standardisation3Choice
        + XpryLctn  : String
        + VrsnNb  : Decimal
        + InstrmAssgnmtMtd  : ISO20022.Reda007001.AssignmentMethod2Choice
        + StrkMltplr  : Decimal
        + StrkVal  : Decimal
        + OptnTp  : ISO20022.Reda007001.OptionType8Choice
        + OptnStyle  : ISO20022.Reda007001.OptionStyle1Choice
        + ConvsPrd  : ISO20022.Reda007001.DateTimePeriod1Choice
        + MinExrcblQty  : ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
        + StrkPric  : ISO20022.Reda007001.Price8
        + ConvsDt  : DateTime
        + OptnSttlmStyle  : ISO20022.Reda007001.SettleStyle2Choice
    }
    ISO20022.Reda007001.Option15 *-- ISO20022.Reda007001.UnderlyingAttributes4
    ISO20022.Reda007001.Option15 *-- ISO20022.Reda007001.OptionParty3Choice
    ISO20022.Reda007001.Option15 *-- ISO20022.Reda007001.Standardisation3Choice
    ISO20022.Reda007001.Option15 *-- ISO20022.Reda007001.AssignmentMethod2Choice
    ISO20022.Reda007001.Option15 *-- ISO20022.Reda007001.OptionType8Choice
    ISO20022.Reda007001.Option15 *-- ISO20022.Reda007001.OptionStyle1Choice
    ISO20022.Reda007001.Option15 *-- ISO20022.Reda007001.DateTimePeriod1Choice
    ISO20022.Reda007001.Option15 *-- ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
    ISO20022.Reda007001.Option15 *-- ISO20022.Reda007001.Price8
    ISO20022.Reda007001.Option15 *-- ISO20022.Reda007001.SettleStyle2Choice
    class ISO20022.Reda007001.OptionParty1Code {
        BYER = 1
        SLLR = 2
    }
    class ISO20022.Reda007001.OptionParty3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Reda007001.OptionParty3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.OptionStyle1Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Reda007001.OptionStyle1Choice *-- ISO20022.Reda007001.GenericIdentification13
    class ISO20022.Reda007001.OptionStyle1Code {
        CANA = 1
        ASIA = 2
        BERM = 3
        EURO = 4
        AMER = 5
    }
    class ISO20022.Reda007001.OptionType1Code {
        PUTO = 1
        CALL = 2
    }
    class ISO20022.Reda007001.OptionType8Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Reda007001.OptionType8Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.Organisation38 {
        + ScndryComAdr  : ISO20022.Reda007001.CommunicationAddress3
        + PmryComAdr  : ISO20022.Reda007001.CommunicationAddress3
        + PstlAdr  : global::System.Collections.Generic.List~ISO20022.Reda007001.PostalAddress3~
        + NtlRegnNb  : String
        + TaxIdNb  : String
        + RegnDt  : DateTime
        + RegnCtry  : String
        + TaxtnCtry  : String
        + Purp  : String
        + Id  : ISO20022.Reda007001.PartyIdentification177Choice
        + Nm  : String
    }
    ISO20022.Reda007001.Organisation38 *-- ISO20022.Reda007001.CommunicationAddress3
    ISO20022.Reda007001.Organisation38 *-- ISO20022.Reda007001.CommunicationAddress3
    ISO20022.Reda007001.Organisation38 *-- ISO20022.Reda007001.PostalAddress3
    ISO20022.Reda007001.Organisation38 *-- ISO20022.Reda007001.PartyIdentification177Choice
    class ISO20022.Reda007001.OtherIdentification1 {
        + Tp  : ISO20022.Reda007001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Reda007001.OtherIdentification1 *-- ISO20022.Reda007001.IdentificationSource3Choice
    class ISO20022.Reda007001.PartyIdentification120Choice {
        + NmAndAdr  : ISO20022.Reda007001.NameAndAddress5
        + PrtryId  : ISO20022.Reda007001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Reda007001.PartyIdentification120Choice *-- ISO20022.Reda007001.NameAndAddress5
    ISO20022.Reda007001.PartyIdentification120Choice *-- ISO20022.Reda007001.GenericIdentification36
    class ISO20022.Reda007001.PartyIdentification136 {
        + LEI  : String
        + Id  : ISO20022.Reda007001.PartyIdentification120Choice
    }
    ISO20022.Reda007001.PartyIdentification136 *-- ISO20022.Reda007001.PartyIdentification120Choice
    class ISO20022.Reda007001.PartyIdentification177Choice {
        + PrtryId  : ISO20022.Reda007001.GenericIdentification1
        + AnyBIC  : String
    }
    ISO20022.Reda007001.PartyIdentification177Choice *-- ISO20022.Reda007001.GenericIdentification1
    class ISO20022.Reda007001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Reda007001.PostalAddress3 {
        + NmAndAdr  : ISO20022.Reda007001.NameAndAddress4
        + RegnAdrInd  : String
        + MlngInd  : String
        + AdrTp  : String
    }
    ISO20022.Reda007001.PostalAddress3 *-- ISO20022.Reda007001.NameAndAddress4
    class ISO20022.Reda007001.PreferenceToIncome1Code {
        PFRD = 1
        ORDN = 2
    }
    class ISO20022.Reda007001.PreferenceToIncome5Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.PreferenceToIncome5Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.Price8 {
        + PricTp  : String
        + Val  : ISO20022.Reda007001.PriceRateOrAmount3Choice
        + ValTp  : String
    }
    ISO20022.Reda007001.Price8 *-- ISO20022.Reda007001.PriceRateOrAmount3Choice
    class ISO20022.Reda007001.PriceRateOrAmount3Choice {
        + Amt  : ISO20022.Reda007001.ActiveOrHistoricCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Reda007001.PriceRateOrAmount3Choice *-- ISO20022.Reda007001.ActiveOrHistoricCurrencyAnd13DecimalAmount
    class ISO20022.Reda007001.PriceValue1 {
        + Amt  : ISO20022.Reda007001.ActiveCurrencyAnd13DecimalAmount
    }
    ISO20022.Reda007001.PriceValue1 *-- ISO20022.Reda007001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Reda007001.PriceValueType3Code {
        VACT = 1
        FICT = 2
        TEDY = 3
        TEDP = 4
        ABSO = 5
        PEUN = 6
        SPRE = 7
        YIEL = 8
        PARV = 9
        PREM = 10
        DISC = 11
    }
    class ISO20022.Reda007001.PutType1Code {
        TWOS = 1
        OPTI = 2
        MAND = 3
    }
    class ISO20022.Reda007001.PutType3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.PutType3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.RateAndAmountFormat1Choice {
        + NotSpcfdRate  : ISO20022.Reda007001.RateType12FormatChoice
        + Amt  : ISO20022.Reda007001.ActiveCurrencyAndAmount
        + Rate  : Decimal
    }
    ISO20022.Reda007001.RateAndAmountFormat1Choice *-- ISO20022.Reda007001.RateType12FormatChoice
    ISO20022.Reda007001.RateAndAmountFormat1Choice *-- ISO20022.Reda007001.ActiveCurrencyAndAmount
    class ISO20022.Reda007001.RateOrAbsoluteValue1Choice {
        + AbsVal  : Decimal
        + RateVal  : Decimal
    }
    class ISO20022.Reda007001.RateType12Code {
        NILP = 1
        UKWN = 2
        OPEN = 3
    }
    class ISO20022.Reda007001.RateType12FormatChoice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification13
        + Cd  : String
    }
    ISO20022.Reda007001.RateType12FormatChoice *-- ISO20022.Reda007001.GenericIdentification13
    class ISO20022.Reda007001.RestrictionType1Code {
        VOTR = 1
        HOLR = 2
        PLAR = 3
        BUYR = 4
        SELR = 5
    }
    class ISO20022.Reda007001.SecuritiesPaymentStatus1Code {
        PART = 1
        NILL = 2
        FULL = 3
    }
    class ISO20022.Reda007001.SecuritiesPaymentStatus5Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.SecuritiesPaymentStatus5Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.SecuritiesTransactionType11Code {
        SYND = 1
        NSYN = 2
    }
    class ISO20022.Reda007001.SecuritiesTransactionType31Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.SecuritiesTransactionType31Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.SecuritiesUpdateReason1Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.SecuritiesUpdateReason1Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.SecurityAttributes12 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Reda007001.SupplementaryData1~
        + FinInstrmAttrbts  : global::System.Collections.Generic.List~ISO20022.Reda007001.CommonFinancialInstrumentAttributes12~
        + FinInstrmTp  : global::System.Collections.Generic.List~ISO20022.Reda007001.FinancialInstrument97~
    }
    ISO20022.Reda007001.SecurityAttributes12 *-- ISO20022.Reda007001.SupplementaryData1
    ISO20022.Reda007001.SecurityAttributes12 *-- ISO20022.Reda007001.CommonFinancialInstrumentAttributes12
    ISO20022.Reda007001.SecurityAttributes12 *-- ISO20022.Reda007001.FinancialInstrument97
    class ISO20022.Reda007001.SecurityIdentification39 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Reda007001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Reda007001.SecurityIdentification39 *-- ISO20022.Reda007001.OtherIdentification1
    class ISO20022.Reda007001.SecurityMaintenanceRequestV01 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Reda007001.SupplementaryData1~
        + FinInstrmId  : ISO20022.Reda007001.SecurityIdentification39
        + UpdRsn  : ISO20022.Reda007001.SecuritiesUpdateReason1Choice
        + UpdTp  : ISO20022.Reda007001.UpdateType36Choice
        + MsgHdr  : ISO20022.Reda007001.MessageHeader1
    }
    ISO20022.Reda007001.SecurityMaintenanceRequestV01 *-- ISO20022.Reda007001.SupplementaryData1
    ISO20022.Reda007001.SecurityMaintenanceRequestV01 *-- ISO20022.Reda007001.SecurityIdentification39
    ISO20022.Reda007001.SecurityMaintenanceRequestV01 *-- ISO20022.Reda007001.SecuritiesUpdateReason1Choice
    ISO20022.Reda007001.SecurityMaintenanceRequestV01 *-- ISO20022.Reda007001.UpdateType36Choice
    ISO20022.Reda007001.SecurityMaintenanceRequestV01 *-- ISO20022.Reda007001.MessageHeader1
    class ISO20022.Reda007001.SecurityRestriction3 {
        + InvstrTp  : global::System.Collections.Generic.List~ISO20022.Reda007001.InvestorType3Choice~
        + InvstrRstrctnTp  : global::System.Collections.Generic.List~ISO20022.Reda007001.InvestorRestrictionType3Choice~
        + LglRstrctnTp  : ISO20022.Reda007001.LegalRestrictions5Choice
        + RstrctnTp  : ISO20022.Reda007001.SecurityRestrictionType2Choice
        + FctvPrd  : ISO20022.Reda007001.DateTimePeriod2
    }
    ISO20022.Reda007001.SecurityRestriction3 *-- ISO20022.Reda007001.InvestorType3Choice
    ISO20022.Reda007001.SecurityRestriction3 *-- ISO20022.Reda007001.InvestorRestrictionType3Choice
    ISO20022.Reda007001.SecurityRestriction3 *-- ISO20022.Reda007001.LegalRestrictions5Choice
    ISO20022.Reda007001.SecurityRestriction3 *-- ISO20022.Reda007001.SecurityRestrictionType2Choice
    ISO20022.Reda007001.SecurityRestriction3 *-- ISO20022.Reda007001.DateTimePeriod2
    class ISO20022.Reda007001.SecurityRestrictionType2Choice {
        + PrtryRstrctn  : ISO20022.Reda007001.GenericIdentification30
        + RstrctnTp  : String
    }
    ISO20022.Reda007001.SecurityRestrictionType2Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.SecurityStatus2Code {
        SUSP = 1
        INAC = 2
        ACTV = 3
    }
    class ISO20022.Reda007001.SecurityStatus3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.SecurityStatus3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.SecurityWithHoldingTax1 {
        + Ctry  : String
        + WhldgTaxVal  : ISO20022.Reda007001.RateAndAmountFormat1Choice
    }
    ISO20022.Reda007001.SecurityWithHoldingTax1 *-- ISO20022.Reda007001.RateAndAmountFormat1Choice
    class ISO20022.Reda007001.SettleStyle1Code {
        SETO = 1
        SETC = 2
    }
    class ISO20022.Reda007001.SettleStyle2Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Reda007001.SettleStyle2Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.SettlementInformation17 {
        + DevtgSttlmUnit  : global::System.Collections.Generic.List~ISO20022.Reda007001.FinancialInstrumentQuantity1Choice~
        + MinMltplQty  : ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
        + MinDnmtn  : ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
        + CtrctSttlmMnth  : String
        + SctiesQtyTp  : ISO20022.Reda007001.SettlementUnitType3Choice
    }
    ISO20022.Reda007001.SettlementInformation17 *-- ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
    ISO20022.Reda007001.SettlementInformation17 *-- ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
    ISO20022.Reda007001.SettlementInformation17 *-- ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
    ISO20022.Reda007001.SettlementInformation17 *-- ISO20022.Reda007001.SettlementUnitType3Choice
    class ISO20022.Reda007001.SettlementType1Code {
        NETO = 1
        PRIN = 2
    }
    class ISO20022.Reda007001.SettlementType3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.SettlementType3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.SettlementUnitType1Code {
        UNIT = 1
        FAMT = 2
    }
    class ISO20022.Reda007001.SettlementUnitType3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.SettlementUnitType3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.Standardisation1Code {
        STAN = 1
        NSTA = 2
        FLEX = 3
    }
    class ISO20022.Reda007001.Standardisation3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : global::System.Collections.Generic.List~String~
    }
    ISO20022.Reda007001.Standardisation3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.SupplementaryData1 {
        + Envlp  : ISO20022.Reda007001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Reda007001.SupplementaryData1 *-- ISO20022.Reda007001.SupplementaryDataEnvelope1
    class ISO20022.Reda007001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Reda007001.TEFRARules1Code {
        RULD = 1
        RULC = 2
    }
    class ISO20022.Reda007001.TEFRARules3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.TEFRARules3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.Term1 {
        + Val  : ISO20022.Reda007001.RateOrAbsoluteValue1Choice
        + Oprtr  : String
    }
    ISO20022.Reda007001.Term1 *-- ISO20022.Reda007001.RateOrAbsoluteValue1Choice
    class ISO20022.Reda007001.TimeUnit1Code {
        YEAR = 1
        WEEK = 2
        SECO = 3
        MNTH = 4
        MINU = 5
        HOUR = 6
        DAYC = 7
    }
    class ISO20022.Reda007001.TimeUnit3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.TimeUnit3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.TradeTransactionCondition2Code {
        GTDL = 1
        SPEX = 2
        SPCU = 3
        SPPR = 4
        CAST = 5
        SECR = 6
        SCCR = 7
        SERT = 8
        SCRT = 9
        SCBN = 10
        SEBN = 11
        SECN = 12
        SPCC = 13
    }
    class ISO20022.Reda007001.TradeTransactionCondition7Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.TradeTransactionCondition7Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.TradingParameters2 {
        + PmryPlcOfListgId  : String
        + MinTradgPricgIncrmt  : Decimal
        + MaxTraddNmnlQty  : ISO20022.Reda007001.UnitOrFaceAmount1Choice
        + MinTraddNmnlQty  : ISO20022.Reda007001.UnitOrFaceAmount1Choice
        + ScndryPlcOfListg  : global::System.Collections.Generic.List~String~
        + TradLotSz  : ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
        + RndLot  : ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
        + MktId  : String
    }
    ISO20022.Reda007001.TradingParameters2 *-- ISO20022.Reda007001.UnitOrFaceAmount1Choice
    ISO20022.Reda007001.TradingParameters2 *-- ISO20022.Reda007001.UnitOrFaceAmount1Choice
    ISO20022.Reda007001.TradingParameters2 *-- ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
    ISO20022.Reda007001.TradingParameters2 *-- ISO20022.Reda007001.FinancialInstrumentQuantity1Choice
    class ISO20022.Reda007001.TypeOfPrice1Code {
        STOP = 1
        RDAV = 2
        PARV = 3
        NOGR = 4
        NUND = 5
        NET1 = 6
        NDIS = 7
        NET2 = 8
        LIMI = 9
        GREX = 10
        COMB = 11
        AVOV = 12
        AVER = 13
    }
    class ISO20022.Reda007001.UnderlyingAttributes4 {
        + CapVal  : ISO20022.Reda007001.ActiveCurrencyAndAmount
        + XchgRate  : Decimal
        + AdjstdQty  : ISO20022.Reda007001.UnitOrFaceAmount1Choice
        + EndVal  : ISO20022.Reda007001.ActiveCurrencyAndAmount
        + CurVal  : ISO20022.Reda007001.ActiveCurrencyAndAmount
        + StartVal  : ISO20022.Reda007001.ActiveCurrencyAndAmount
        + EndPric  : ISO20022.Reda007001.Price8
        + DrtyPric  : ISO20022.Reda007001.Price8
        + Pric  : ISO20022.Reda007001.Price8
        + CshTp  : String
        + CshAmt  : ISO20022.Reda007001.ActiveCurrencyAndAmount
        + SttlmTp  : ISO20022.Reda007001.SettlementType3Choice
        + Qty  : ISO20022.Reda007001.UnitOrFaceAmount1Choice
        + AllcnPctg  : Decimal
    }
    ISO20022.Reda007001.UnderlyingAttributes4 *-- ISO20022.Reda007001.ActiveCurrencyAndAmount
    ISO20022.Reda007001.UnderlyingAttributes4 *-- ISO20022.Reda007001.UnitOrFaceAmount1Choice
    ISO20022.Reda007001.UnderlyingAttributes4 *-- ISO20022.Reda007001.ActiveCurrencyAndAmount
    ISO20022.Reda007001.UnderlyingAttributes4 *-- ISO20022.Reda007001.ActiveCurrencyAndAmount
    ISO20022.Reda007001.UnderlyingAttributes4 *-- ISO20022.Reda007001.ActiveCurrencyAndAmount
    ISO20022.Reda007001.UnderlyingAttributes4 *-- ISO20022.Reda007001.Price8
    ISO20022.Reda007001.UnderlyingAttributes4 *-- ISO20022.Reda007001.Price8
    ISO20022.Reda007001.UnderlyingAttributes4 *-- ISO20022.Reda007001.Price8
    ISO20022.Reda007001.UnderlyingAttributes4 *-- ISO20022.Reda007001.ActiveCurrencyAndAmount
    ISO20022.Reda007001.UnderlyingAttributes4 *-- ISO20022.Reda007001.SettlementType3Choice
    ISO20022.Reda007001.UnderlyingAttributes4 *-- ISO20022.Reda007001.UnitOrFaceAmount1Choice
    class ISO20022.Reda007001.UnitOfMeasure7Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.UnitOfMeasure7Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.UnitOfMeasure9Code {
        HECT = 1
        ARES = 2
        ACRE = 3
        GBOU = 4
        YARD = 5
        USTN = 6
        USQA = 7
        USPI = 8
        USGA = 9
        USFO = 10
        USBA = 11
        SQYA = 12
        SMIL = 13
        SQMI = 14
        SMET = 15
        SQKI = 16
        SQIN = 17
        SQFO = 18
        SCMT = 19
        USOU = 20
        PUND = 21
        MILI = 22
        MMET = 23
        MILE = 24
        TONE = 25
        METR = 26
        LITR = 27
        KMET = 28
        KILO = 29
        INCH = 30
        GRAM = 31
        GBTN = 32
        GBQA = 33
        GBPI = 34
        GBGA = 35
        GBFO = 36
        FOOT = 37
        PIEC = 38
        CBML = 39
        CBME = 40
        CBIN = 41
        CRAT = 42
        CNTR = 43
        CMET = 44
        CELI = 45
        CRTN = 46
        BOXX = 47
        BOTL = 48
        BALE = 49
        BAGG = 50
    }
    class ISO20022.Reda007001.UnitOrFaceAmount1Choice {
        + FaceAmt  : ISO20022.Reda007001.ActiveCurrencyAndAmount
        + Unit  : Decimal
    }
    ISO20022.Reda007001.UnitOrFaceAmount1Choice *-- ISO20022.Reda007001.ActiveCurrencyAndAmount
    class ISO20022.Reda007001.UpdateType35Choice {
        + Modfy  : ISO20022.Reda007001.SecurityAttributes12
        + Del  : ISO20022.Reda007001.SecurityAttributes12
        + Add  : ISO20022.Reda007001.SecurityAttributes12
    }
    ISO20022.Reda007001.UpdateType35Choice *-- ISO20022.Reda007001.SecurityAttributes12
    ISO20022.Reda007001.UpdateType35Choice *-- ISO20022.Reda007001.SecurityAttributes12
    ISO20022.Reda007001.UpdateType35Choice *-- ISO20022.Reda007001.SecurityAttributes12
    class ISO20022.Reda007001.UpdateType36Choice {
        + Rplc  : ISO20022.Reda007001.SecurityAttributes12
        + UpdTp  : global::System.Collections.Generic.List~ISO20022.Reda007001.UpdateType35Choice~
    }
    ISO20022.Reda007001.UpdateType36Choice *-- ISO20022.Reda007001.SecurityAttributes12
    ISO20022.Reda007001.UpdateType36Choice *-- ISO20022.Reda007001.UpdateType35Choice
    class ISO20022.Reda007001.Warrant4 {
        + WarrtAgt  : global::System.Collections.Generic.List~ISO20022.Reda007001.Organisation38~
        + Tp  : ISO20022.Reda007001.WarrantStyle3Choice
        + SbcptPric  : ISO20022.Reda007001.Price8
        + Mltplr  : Decimal
    }
    ISO20022.Reda007001.Warrant4 *-- ISO20022.Reda007001.Organisation38
    ISO20022.Reda007001.Warrant4 *-- ISO20022.Reda007001.WarrantStyle3Choice
    ISO20022.Reda007001.Warrant4 *-- ISO20022.Reda007001.Price8
    class ISO20022.Reda007001.WarrantStyle1Code {
        BERM = 1
        EURO = 2
        AMER = 3
    }
    class ISO20022.Reda007001.WarrantStyle3Choice {
        + Prtry  : ISO20022.Reda007001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Reda007001.WarrantStyle3Choice *-- ISO20022.Reda007001.GenericIdentification30
    class ISO20022.Reda007001.YieldCalculation6 {
        + ClctnDt  : DateTime
        + ValPrd  : ISO20022.Reda007001.DateTimePeriod1Choice
        + ValDt  : DateTime
        + RedPric  : ISO20022.Reda007001.Price8
        + ClctnTp  : ISO20022.Reda007001.CalculationType3Choice
        + Val  : Decimal
    }
    ISO20022.Reda007001.YieldCalculation6 *-- ISO20022.Reda007001.DateTimePeriod1Choice
    ISO20022.Reda007001.YieldCalculation6 *-- ISO20022.Reda007001.Price8
    ISO20022.Reda007001.YieldCalculation6 *-- ISO20022.Reda007001.CalculationType3Choice
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

## Value ISO20022.Reda007001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Reda007001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Reda007001.ActiveOrHistoricCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Reda007001.AddressType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BIZZ|Int32||XmlEnum("""BIZZ""")|1|
||HOME|Int32||XmlEnum("""HOME""")|2|

---

## Enum ISO20022.Reda007001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Reda007001.AmountOrPercentageRange1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Term|global::System.Collections.Generic.List<ISO20022.Reda007001.Term1>||XmlElement()||
|+|Opr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""Term""",Term),validListMax("""Term""",Term,10),validElement(Term))|

---

## Enum ISO20022.Reda007001.Appearance1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GLOB|Int32||XmlEnum("""GLOB""")|1|
||TMPG|Int32||XmlEnum("""TMPG""")|2|
||DLBE|Int32||XmlEnum("""DLBE""")|3|
||DFBE|Int32||XmlEnum("""DFBE""")|4|
||BENT|Int32||XmlEnum("""BENT""")|5|
||LIMI|Int32||XmlEnum("""LIMI""")|6|
||NDEL|Int32||XmlEnum("""NDEL""")|7|
||DELI|Int32||XmlEnum("""DELI""")|8|

---

## Value ISO20022.Reda007001.Appearance3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.AssignmentMethod1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PROR|Int32||XmlEnum("""PROR""")|1|
||RAND|Int32||XmlEnum("""RAND""")|2|

---

## Value ISO20022.Reda007001.AssignmentMethod2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.BenchmarkCurve6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|BchmkCrvPt|String||XmlElement()||
|+|BchmkCrvNm|ISO20022.Reda007001.BenchmarkCurveName7Choice||XmlElement()||
|+|BchmkCrvCcy|String||XmlElement()||
|+|BchmkPric|ISO20022.Reda007001.Price8||XmlElement()||
|+|BchmkId|ISO20022.Reda007001.SecurityIdentification39||XmlElement()||
|+|Sprd|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(BchmkCrvNm),validPattern("""BchmkCrvCcy""",BchmkCrvCcy,"""[A-Z]{3,3}"""),validElement(BchmkPric),validElement(BchmkId))|

---

## Enum ISO20022.Reda007001.BenchmarkCurveName1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PFAN|Int32||XmlEnum("""PFAN""")|1|
||EURI|Int32||XmlEnum("""EURI""")|2|
||TREA|Int32||XmlEnum("""TREA""")|3|
||SWAP|Int32||XmlEnum("""SWAP""")|4|
||LIBO|Int32||XmlEnum("""LIBO""")|5|
||LIBI|Int32||XmlEnum("""LIBI""")|6|
||FUSW|Int32||XmlEnum("""FUSW""")|7|
||MAAA|Int32||XmlEnum("""MAAA""")|8|

---

## Value ISO20022.Reda007001.BenchmarkCurveName7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.CalculationType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WRST|Int32||XmlEnum("""WRST""")|1|
||TRYL|Int32||XmlEnum("""TRYL""")|2|
||TTDT|Int32||XmlEnum("""TTDT""")|3|
||TXQV|Int32||XmlEnum("""TXQV""")|4|
||SPLL|Int32||XmlEnum("""SPLL""")|5|
||SHLF|Int32||XmlEnum("""SHLF""")|6|
||SEMI|Int32||XmlEnum("""SEMI""")|7|
||PRYL|Int32||XmlEnum("""PRYL""")|8|
||PRCL|Int32||XmlEnum("""PRCL""")|9|
||NXPT|Int32||XmlEnum("""NXPT""")|10|
||PNAV|Int32||XmlEnum("""PNAV""")|11|
||NXRF|Int32||XmlEnum("""NXRF""")|12|
||YTMA|Int32||XmlEnum("""YTMA""")|13|
||MARK|Int32||XmlEnum("""MARK""")|14|
||LGAL|Int32||XmlEnum("""LGAL""")|15|
||LSYR|Int32||XmlEnum("""LSYR""")|16|
||LSQR|Int32||XmlEnum("""LSQR""")|17|
||LSMT|Int32||XmlEnum("""LSMT""")|18|
||LSCL|Int32||XmlEnum("""LSCL""")|19|
||NVFL|Int32||XmlEnum("""NVFL""")|20|
||FLAS|Int32||XmlEnum("""FLAS""")|21|
||GVEQ|Int32||XmlEnum("""GVEQ""")|22|
||TRGR|Int32||XmlEnum("""TRGR""")|23|
||CUYI|Int32||XmlEnum("""CUYI""")|24|
||CMPD|Int32||XmlEnum("""CMPD""")|25|
||CLOS|Int32||XmlEnum("""CLOS""")|26|
||CHCL|Int32||XmlEnum("""CHCL""")|27|
||YTNC|Int32||XmlEnum("""YTNC""")|28|
||BOOK|Int32||XmlEnum("""BOOK""")|29|
||AVMA|Int32||XmlEnum("""AVMA""")|30|
||ISSU|Int32||XmlEnum("""ISSU""")|31|
||ANNU|Int32||XmlEnum("""ANNU""")|32|
||AFTX|Int32||XmlEnum("""AFTX""")|33|

---

## Value ISO20022.Reda007001.CalculationType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.CallType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRTA|Int32||XmlEnum("""PRTA""")|1|
||LOTT|Int32||XmlEnum("""LOTT""")|2|

---

## Value ISO20022.Reda007001.CallType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.ClassificationType2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|global::System.Collections.Generic.List<ISO20022.Reda007001.GenericIdentification36>||XmlElement()||
|+|FinInstrmPdctTpCd|String||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AltrnClssfctn""",AltrnClssfctn),validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""))|

---

## Value ISO20022.Reda007001.CommonFinancialInstrumentAttributes12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UndrlygRsk|ISO20022.Reda007001.Organisation38||XmlElement()||
|+|Dpstry|ISO20022.Reda007001.Organisation38||XmlElement()||
|+|PngAgt|ISO20022.Reda007001.Organisation38||XmlElement()||
|+|PrncplPngAgt|ISO20022.Reda007001.Organisation38||XmlElement()||
|+|LeadMgr|ISO20022.Reda007001.Organisation38||XmlElement()||
|+|CtctNm|ISO20022.Reda007001.Organisation38||XmlElement()||
|+|FinInstrmForm|ISO20022.Reda007001.FinancialInstrumentForm2||XmlElement()||
|+|SttlmInf|global::System.Collections.Generic.List<ISO20022.Reda007001.SettlementInformation17>||XmlElement()||
|+|FinInstrmId|ISO20022.Reda007001.SecurityIdentification39||XmlElement()||
|+|Rstrctn|global::System.Collections.Generic.List<ISO20022.Reda007001.SecurityRestriction3>||XmlElement()||
|+|RedPmtCcy|String||XmlElement()||
|+|RedTp|ISO20022.Reda007001.MaturityRedemptionType3Choice||XmlElement()||
|+|CmonSfkpr|ISO20022.Reda007001.PartyIdentification177Choice||XmlElement()||
|+|AftrXchgPhysForm|ISO20022.Reda007001.InitialPhysicalForm3Choice||XmlElement()||
|+|InitlPhysForm|ISO20022.Reda007001.InitialPhysicalForm4Choice||XmlElement()||
|+|PmtSts|ISO20022.Reda007001.SecuritiesPaymentStatus5Choice||XmlElement()||
|+|WhldgTaxRgm|global::System.Collections.Generic.List<ISO20022.Reda007001.SecurityWithHoldingTax1>||XmlElement()||
|+|Clss|String||XmlElement()||
|+|SrNb|String||XmlElement()||
|+|TEFRARule|ISO20022.Reda007001.TEFRARules3Choice||XmlElement()||
|+|TradgMtd|ISO20022.Reda007001.UnitOrFaceAmount1Choice||XmlElement()||
|+|PmryPlcOfDpst|ISO20022.Reda007001.PartyIdentification136||XmlElement()||
|+|ConvsRatioDnmtr|ISO20022.Reda007001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|ConvsRatioNmrtr|ISO20022.Reda007001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|ConvsPrd|ISO20022.Reda007001.DateTimePeriod1||XmlElement()||
|+|ConvtblInd|String||XmlElement()||
|+|PrvtPlcmnt|String||XmlElement()||
|+|Cnfdtl|String||XmlElement()||
|+|FngbInd|String||XmlElement()||
|+|CallTp|ISO20022.Reda007001.CallType3Choice||XmlElement()||
|+|PutTp|ISO20022.Reda007001.PutType3Choice||XmlElement()||
|+|SprdAndBchmkCrv|global::System.Collections.Generic.List<ISO20022.Reda007001.BenchmarkCurve6>||XmlElement()||
|+|TradgMkt|global::System.Collections.Generic.List<ISO20022.Reda007001.TradingParameters2>||XmlElement()||
|+|Issnc|ISO20022.Reda007001.Issuance5||XmlElement()||
|+|ClssfctnTp|ISO20022.Reda007001.ClassificationType2||XmlElement()||
|+|Purp|String||XmlElement()||
|+|XpryDt|DateTime||XmlElement()||
|+|RcrdDt|DateTime||XmlElement()||
|+|ListgDt|DateTime||XmlElement()||
|+|NearTermPosLmt|ISO20022.Reda007001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|PosLmt|ISO20022.Reda007001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|LglRstrctns|ISO20022.Reda007001.LegalRestrictions4Choice||XmlElement()||
|+|CvrdInd|String||XmlElement()||
|+|PoolNb|String||XmlElement()||
|+|TaxLotNb|String||XmlElement()||
|+|CpnAttchdNb|String||XmlElement()||
|+|CtrctVrsnNb|Decimal||XmlElement()||
|+|CertNb|String||XmlElement()||
|+|DnmtnCcy|String||XmlElement()||
|+|NmVldFr|ISO20022.Reda007001.DateAndDateTime2Choice||XmlElement()||
|+|ISOSctyShrtNm|String||XmlElement()||
|+|ISOSctyLngNm|String||XmlElement()||
|+|SctySts|ISO20022.Reda007001.SecurityStatus3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UndrlygRsk),validElement(Dpstry),validElement(PngAgt),validElement(PrncplPngAgt),validElement(LeadMgr),validElement(CtctNm),validElement(FinInstrmForm),validList("""SttlmInf""",SttlmInf),validElement(SttlmInf),validElement(FinInstrmId),validList("""Rstrctn""",Rstrctn),validElement(Rstrctn),validPattern("""RedPmtCcy""",RedPmtCcy,"""[A-Z]{3,3}"""),validElement(RedTp),validElement(CmonSfkpr),validElement(AftrXchgPhysForm),validElement(InitlPhysForm),validElement(PmtSts),validList("""WhldgTaxRgm""",WhldgTaxRgm),validElement(WhldgTaxRgm),validElement(TEFRARule),validElement(TradgMtd),validElement(PmryPlcOfDpst),validElement(ConvsRatioDnmtr),validElement(ConvsRatioNmrtr),validElement(ConvsPrd),validElement(CallTp),validElement(PutTp),validList("""SprdAndBchmkCrv""",SprdAndBchmkCrv),validElement(SprdAndBchmkCrv),validList("""TradgMkt""",TradgMkt),validElement(TradgMkt),validElement(Issnc),validElement(ClssfctnTp),validElement(NearTermPosLmt),validElement(PosLmt),validElement(LglRstrctns),validPattern("""PoolNb""",PoolNb,"""[0-9]{1,15}"""),validPattern("""TaxLotNb""",TaxLotNb,"""[0-9]{1,15}"""),validPattern("""CpnAttchdNb""",CpnAttchdNb,"""[0-9]{1,3}"""),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(NmVldFr),validElement(SctySts))|

---

## Value ISO20022.Reda007001.CommunicationAddress3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|URLAdr|String||XmlElement()||
|+|TlxAdr|String||XmlElement()||
|+|FaxNb|String||XmlElement()||
|+|Mob|String||XmlElement()||
|+|Phne|String||XmlElement()||
|+|Email|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""FaxNb""",FaxNb,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""Mob""",Mob,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""),validPattern("""Phne""",Phne,"""\+[0-9]{1,3}-[0-9()+\-]{1,30}"""))|

---

## Value ISO20022.Reda007001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Value ISO20022.Reda007001.DateTimePeriod1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda007001.DateTimePeriod1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTmRg|ISO20022.Reda007001.DateTimePeriod1||XmlElement()||
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(DtTmRg),validChoice(DtTmRg,ToDtTm,FrDtTm))|

---

## Value ISO20022.Reda007001.DateTimePeriod2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ToDtTm|DateTime||XmlElement()||
|+|FrDtTm|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda007001.Debt5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricRg|ISO20022.Reda007001.AmountOrPercentageRange1||XmlElement()||
|+|PricSrc|String||XmlElement()||
|+|WhlPoolInd|String||XmlElement()||
|+|SbstitnLft|Decimal||XmlElement()||
|+|SbstitnFrqcy|ISO20022.Reda007001.Frequency35Choice||XmlElement()||
|+|Sctr|String||XmlElement()||
|+|PricFrqcy|ISO20022.Reda007001.Frequency35Choice||XmlElement()||
|+|RstrctdInd|String||XmlElement()||
|+|Pdctn|String||XmlElement()||
|+|MinQty|ISO20022.Reda007001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|MinIncrmt|ISO20022.Reda007001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|MaxSbstitn|Decimal||XmlElement()||
|+|LookBck|Decimal||XmlElement()||
|+|TxConds|ISO20022.Reda007001.TradeTransactionCondition7Choice||XmlElement()||
|+|Hrcut|Decimal||XmlElement()||
|+|AutoRinvstmt|Decimal||XmlElement()||
|+|AltrntvMinTaxInd|String||XmlElement()||
|+|Purp|String||XmlElement()||
|+|CpnRg|ISO20022.Reda007001.AmountOrPercentageRange1||XmlElement()||
|+|YldRg|ISO20022.Reda007001.AmountOrPercentageRange1||XmlElement()||
|+|Geogcs|String||XmlElement()||
|+|PotntlEuroSysElgblty|String||XmlElement()||
|+|GblTp|ISO20022.Reda007001.GlobalNote2Choice||XmlElement()||
|+|InstrmStrTp|ISO20022.Reda007001.InstrumentSubStructureType2Choice||XmlElement()||
|+|IntrstTp|String||XmlElement()||
|+|YldClctn|global::System.Collections.Generic.List<ISO20022.Reda007001.YieldCalculation6>||XmlElement()||
|+|BkQlfdInd|String||XmlElement()||
|+|InsrdInd|String||XmlElement()||
|+|WghtdAvrgMtrty|Decimal||XmlElement()||
|+|WghtdAvrgLn|Decimal||XmlElement()||
|+|WghtdAvrgLife|Decimal||XmlElement()||
|+|WghtdAvrgCpn|Decimal||XmlElement()||
|+|CstPrePmtYld|Decimal||XmlElement()||
|+|LotId|String||XmlElement()||
|+|CstPrePmtPnltyInd|String||XmlElement()||
|+|PlsPerTrad|Decimal||XmlElement()||
|+|PlsPerLot|Decimal||XmlElement()||
|+|PlsPerMln|Decimal||XmlElement()||
|+|PlsMax|Decimal||XmlElement()||
|+|Pcs|Decimal||XmlElement()||
|+|PrvsFctr|Decimal||XmlElement()||
|+|NxtFctr|Decimal||XmlElement()||
|+|CurFctr|Decimal||XmlElement()||
|+|ActlDnmtnAmt|global::System.Collections.Generic.List<ISO20022.Reda007001.ActiveCurrencyAndAmount>||XmlElement()||
|+|CptlsdIntrst|ISO20022.Reda007001.DistributionPolicy2Choice||XmlElement()||
|+|IntrstClctnMtd|String||XmlElement()||
|+|AmtsblInd|String||XmlElement()||
|+|OverAlltmtRate|Decimal||XmlElement()||
|+|OverAlltmtAmt|ISO20022.Reda007001.ActiveCurrencyAndAmount||XmlElement()||
|+|VarblRateInd|String||XmlElement()||
|+|XtndblPrd|ISO20022.Reda007001.DateTimePeriod1Choice||XmlElement()||
|+|XtndblInd|String||XmlElement()||
|+|SubrdntdInd|String||XmlElement()||
|+|PerptlInd|String||XmlElement()||
|+|EscrwdInd|String||XmlElement()||
|+|PreFnddInd|String||XmlElement()||
|+|PutblInd|String||XmlElement()||
|+|IntrstAcrlDt|DateTime||XmlElement()||
|+|CPRegnTp|String||XmlElement()||
|+|CPPrgm|Decimal||XmlElement()||
|+|CllblInd|String||XmlElement()||
|+|OddCpnInd|String||XmlElement()||
|+|NxtIntrstRate|Decimal||XmlElement()||
|+|IntrstRate|Decimal||XmlElement()||
|+|PmtDrctnInd|String||XmlElement()||
|+|XprtnDt|DateTime||XmlElement()||
|+|NxtFctrDt|DateTime||XmlElement()||
|+|NxtCllblDt|DateTime||XmlElement()||
|+|PutblDt|DateTime||XmlElement()||
|+|NxtCpnDt|DateTime||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|FrstPmtDt|DateTime||XmlElement()||
|+|DtdDt|DateTime||XmlElement()||
|+|IntrstFxgDt|DateTime||XmlElement()||
|+|PmtFrqcy|ISO20022.Reda007001.Frequency35Choice||XmlElement()||
|+|FaceAmt|ISO20022.Reda007001.ActiveCurrencyAndAmount||XmlElement()||
|+|PmtCcy|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricRg),validElement(SbstitnFrqcy),validElement(PricFrqcy),validElement(MinQty),validElement(MinIncrmt),validElement(TxConds),validElement(CpnRg),validElement(YldRg),validElement(GblTp),validElement(InstrmStrTp),validList("""YldClctn""",YldClctn),validElement(YldClctn),validList("""ActlDnmtnAmt""",ActlDnmtnAmt),validElement(ActlDnmtnAmt),validElement(CptlsdIntrst),validElement(OverAlltmtAmt),validElement(XtndblPrd),validElement(PmtFrqcy),validElement(FaceAmt),validPattern("""PmtCcy""",PmtCcy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Reda007001.Derivative4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Optn|ISO20022.Reda007001.Option15||XmlElement()||
|+|Futr|ISO20022.Reda007001.Future4||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Optn),validElement(Futr))|

---

## Enum ISO20022.Reda007001.DistributionPolicy1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||DIST|Int32||XmlEnum("""DIST""")|2|

---

## Value ISO20022.Reda007001.DistributionPolicy2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Type ISO20022.Reda007001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SctyMntncReq|ISO20022.Reda007001.SecurityMaintenanceRequestV01||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SctyMntncReq))|

---

## Value ISO20022.Reda007001.Equity3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|VtngRghtsPerShr|Decimal||XmlElement()||
|+|ParVal|ISO20022.Reda007001.ActiveCurrencyAndAmount||XmlElement()||
|+|NonPdAmt|ISO20022.Reda007001.ActiveCurrencyAndAmount||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|PrefToIncm|ISO20022.Reda007001.PreferenceToIncome5Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ParVal),validElement(NonPdAmt),validElement(PrefToIncm))|

---

## Value ISO20022.Reda007001.FinancialInstrument97


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Deriv|ISO20022.Reda007001.Derivative4||XmlElement()||
|+|Debt|ISO20022.Reda007001.Debt5||XmlElement()||
|+|Warrt|ISO20022.Reda007001.Warrant4||XmlElement()||
|+|Eqty|ISO20022.Reda007001.Equity3||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Deriv),validElement(Debt),validElement(Warrt),validElement(Eqty))|

---

## Value ISO20022.Reda007001.FinancialInstrumentForm2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LglForm|ISO20022.Reda007001.FormOfSecurity8Choice||XmlElement()||
|+|BookgApprnc|ISO20022.Reda007001.Appearance3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LglForm),validElement(BookgApprnc))|

---

## Value ISO20022.Reda007001.FinancialInstrumentQuantity1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AmtsdVal,FaceAmt,Unit))|

---

## Enum ISO20022.Reda007001.FormOfSecurity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REGD|Int32||XmlEnum("""REGD""")|1|
||BEAR|Int32||XmlEnum("""BEAR""")|2|

---

## Value ISO20022.Reda007001.FormOfSecurity8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.Frequency35Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.Frequency5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TEND|Int32||XmlEnum("""TEND""")|1|
||OVNG|Int32||XmlEnum("""OVNG""")|2|
||INDA|Int32||XmlEnum("""INDA""")|3|
||ADHO|Int32||XmlEnum("""ADHO""")|4|
||DAIL|Int32||XmlEnum("""DAIL""")|5|
||WEEK|Int32||XmlEnum("""WEEK""")|6|
||MIAN|Int32||XmlEnum("""MIAN""")|7|
||QURT|Int32||XmlEnum("""QURT""")|8|
||MNTH|Int32||XmlEnum("""MNTH""")|9|
||YEAR|Int32||XmlEnum("""YEAR""")|10|

---

## Value ISO20022.Reda007001.Future4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlUndrlygAttrbts|global::System.Collections.Generic.List<ISO20022.Reda007001.UnderlyingAttributes4>||XmlElement()||
|+|TmUnit|ISO20022.Reda007001.TimeUnit3Choice||XmlElement()||
|+|UnitOfMeasr|ISO20022.Reda007001.UnitOfMeasure7Choice||XmlElement()||
|+|MinSz|ISO20022.Reda007001.ActiveCurrencyAndAmount||XmlElement()||
|+|FutrDt|DateTime||XmlElement()||
|+|ExrcPric|ISO20022.Reda007001.Price8||XmlElement()||
|+|CtrctSz|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlUndrlygAttrbts""",AddtlUndrlygAttrbts),validElement(AddtlUndrlygAttrbts),validElement(TmUnit),validElement(UnitOfMeasr),validElement(MinSz),validElement(ExrcPric))|

---

## Value ISO20022.Reda007001.GenericIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda007001.GenericIdentification13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Issr|String||XmlElement()||
|+|SchmeNm|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{1,4}"""))|

---

## Value ISO20022.Reda007001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Reda007001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Reda007001.GlobalNote1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CGNO|Int32||XmlEnum("""CGNO""")|1|
||NGNO|Int32||XmlEnum("""NGNO""")|2|

---

## Value ISO20022.Reda007001.GlobalNote2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.InitialPhysicalForm1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DERN|Int32||XmlEnum("""DERN""")|1|
||GPGP|Int32||XmlEnum("""GPGP""")|2|
||GTGT|Int32||XmlEnum("""GTGT""")|3|

---

## Enum ISO20022.Reda007001.InitialPhysicalForm2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DERN|Int32||XmlEnum("""DERN""")|1|
||GPGP|Int32||XmlEnum("""GPGP""")|2|

---

## Value ISO20022.Reda007001.InitialPhysicalForm3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.InitialPhysicalForm4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.InstrumentSubStructureType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||WBSE|Int32||XmlEnum("""WBSE""")|1|
||STUT|Int32||XmlEnum("""STUT""")|2|
||STRB|Int32||XmlEnum("""STRB""")|3|
||SCBO|Int32||XmlEnum("""SCBO""")|4|
||RMBS|Int32||XmlEnum("""RMBS""")|5|
||REPK|Int32||XmlEnum("""REPK""")|6|
||PYRT|Int32||XmlEnum("""PYRT""")|7|
||PFAB|Int32||XmlEnum("""PFAB""")|8|
||LPNO|Int32||XmlEnum("""LPNO""")|9|
||HELO|Int32||XmlEnum("""HELO""")|10|
||CRCT|Int32||XmlEnum("""CRCT""")|11|
||CSMR|Int32||XmlEnum("""CSMR""")|12|
||CMBS|Int32||XmlEnum("""CMBS""")|13|
||CLOB|Int32||XmlEnum("""CLOB""")|14|
||CLNO|Int32||XmlEnum("""CLNO""")|15|
||CDOB|Int32||XmlEnum("""CDOB""")|16|
||CBOB|Int32||XmlEnum("""CBOB""")|17|
||AUTT|Int32||XmlEnum("""AUTT""")|18|
||AIRT|Int32||XmlEnum("""AIRT""")|19|
||ABSE|Int32||XmlEnum("""ABSE""")|20|

---

## Value ISO20022.Reda007001.InstrumentSubStructureType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.InterestType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DSCO|Int32||XmlEnum("""DSCO""")|1|
||INDE|Int32||XmlEnum("""INDE""")|2|
||DUAL|Int32||XmlEnum("""DUAL""")|3|
||FLRN|Int32||XmlEnum("""FLRN""")|4|
||FIXD|Int32||XmlEnum("""FIXD""")|5|
||ZCPN|Int32||XmlEnum("""ZCPN""")|6|

---

## Enum ISO20022.Reda007001.InvestorRestrictionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INDV|Int32||XmlEnum("""INDV""")|1|
||CITI|Int32||XmlEnum("""CITI""")|2|
||LERE|Int32||XmlEnum("""LERE""")|3|

---

## Value ISO20022.Reda007001.InvestorRestrictionType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.InvestorType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PPER|Int32||XmlEnum("""PPER""")|1|
||STAF|Int32||XmlEnum("""STAF""")|2|
||PROF|Int32||XmlEnum("""PROF""")|3|
||RETL|Int32||XmlEnum("""RETL""")|4|

---

## Value ISO20022.Reda007001.InvestorType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.Issuance5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GovngLaw|global::System.Collections.Generic.List<ISO20022.Reda007001.Jurisdiction1>||XmlElement()||
|+|IssncDstrbtn|ISO20022.Reda007001.SecuritiesTransactionType31Choice||XmlElement()||
|+|IssePric|ISO20022.Reda007001.PriceValue1||XmlElement()||
|+|IsseSz|Decimal||XmlElement()||
|+|FullIssdAmt|ISO20022.Reda007001.ActiveCurrencyAndAmount||XmlElement()||
|+|IsseNmnlAmt|ISO20022.Reda007001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|IssrOrg|ISO20022.Reda007001.Organisation38||XmlElement()||
|+|ISINVldFr|DateTime||XmlElement()||
|+|AnncmntDt|DateTime||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|CtryOfIsse|String||XmlElement()||
|+|IssePlc|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""GovngLaw""",GovngLaw),validElement(GovngLaw),validElement(IssncDstrbtn),validElement(IssePric),validElement(FullIssdAmt),validElement(IsseNmnlAmt),validElement(IssrOrg),validPattern("""CtryOfIsse""",CtryOfIsse,"""[A-Z]{2,2}"""),validPattern("""IssePlc""",IssePlc,"""[A-Z0-9]{4,4}"""))|

---

## Value ISO20022.Reda007001.Jurisdiction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""))|

---

## Enum ISO20022.Reda007001.LegalRestrictions1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||REST|Int32||XmlEnum("""REST""")|1|
||NORE|Int32||XmlEnum("""NORE""")|2|
||USLE|Int32||XmlEnum("""USLE""")|3|

---

## Enum ISO20022.Reda007001.LegalRestrictions2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PRIV|Int32||XmlEnum("""PRIV""")|1|
||MARG|Int32||XmlEnum("""MARG""")|2|
||ACRI|Int32||XmlEnum("""ACRI""")|3|
||PPLA|Int32||XmlEnum("""PPLA""")|4|
||JURO|Int32||XmlEnum("""JURO""")|5|

---

## Value ISO20022.Reda007001.LegalRestrictions4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.LegalRestrictions5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.MaturityRedemptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUUT|Int32||XmlEnum("""PUUT""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|
||PRRA|Int32||XmlEnum("""PRRA""")|3|
||RNDM|Int32||XmlEnum("""RNDM""")|4|
||PRWR|Int32||XmlEnum("""PRWR""")|5|
||PRNR|Int32||XmlEnum("""PRNR""")|6|
||FRED|Int32||XmlEnum("""FRED""")|7|

---

## Value ISO20022.Reda007001.MaturityRedemptionType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.MessageHeader1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CreDtTm|DateTime||XmlElement()||
|+|MsgId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Reda007001.NameAndAddress4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Reda007001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Value ISO20022.Reda007001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Reda007001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Reda007001.Operation1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ANDD|Int32||XmlEnum("""ANDD""")|1|
||ORRR|Int32||XmlEnum("""ORRR""")|2|
||TILL|Int32||XmlEnum("""TILL""")|3|

---

## Enum ISO20022.Reda007001.Operator1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||EQAL|Int32||XmlEnum("""EQAL""")|1|
||GREQ|Int32||XmlEnum("""GREQ""")|2|
||GREA|Int32||XmlEnum("""GREA""")|3|
||SMEQ|Int32||XmlEnum("""SMEQ""")|4|
||SMAL|Int32||XmlEnum("""SMAL""")|5|

---

## Value ISO20022.Reda007001.Option15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlUndrlygAttrbts|global::System.Collections.Generic.List<ISO20022.Reda007001.UnderlyingAttributes4>||XmlElement()||
|+|CtrctSz|Decimal||XmlElement()||
|+|TradgPtyRole|ISO20022.Reda007001.OptionParty3Choice||XmlElement()||
|+|Stdstn|ISO20022.Reda007001.Standardisation3Choice||XmlElement()||
|+|XpryLctn|String||XmlElement()||
|+|VrsnNb|Decimal||XmlElement()||
|+|InstrmAssgnmtMtd|ISO20022.Reda007001.AssignmentMethod2Choice||XmlElement()||
|+|StrkMltplr|Decimal||XmlElement()||
|+|StrkVal|Decimal||XmlElement()||
|+|OptnTp|ISO20022.Reda007001.OptionType8Choice||XmlElement()||
|+|OptnStyle|ISO20022.Reda007001.OptionStyle1Choice||XmlElement()||
|+|ConvsPrd|ISO20022.Reda007001.DateTimePeriod1Choice||XmlElement()||
|+|MinExrcblQty|ISO20022.Reda007001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|StrkPric|ISO20022.Reda007001.Price8||XmlElement()||
|+|ConvsDt|DateTime||XmlElement()||
|+|OptnSttlmStyle|ISO20022.Reda007001.SettleStyle2Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""AddtlUndrlygAttrbts""",AddtlUndrlygAttrbts),validElement(AddtlUndrlygAttrbts),validElement(TradgPtyRole),validElement(Stdstn),validPattern("""XpryLctn""",XpryLctn,"""[a-zA-Z0-9]{1,4}"""),validElement(InstrmAssgnmtMtd),validElement(OptnTp),validElement(OptnStyle),validElement(ConvsPrd),validElement(MinExrcblQty),validElement(StrkPric),validElement(OptnSttlmStyle))|

---

## Enum ISO20022.Reda007001.OptionParty1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BYER|Int32||XmlEnum("""BYER""")|1|
||SLLR|Int32||XmlEnum("""SLLR""")|2|

---

## Value ISO20022.Reda007001.OptionParty3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validRequired("""Cd""",Cd),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.OptionStyle1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.OptionStyle1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||CANA|Int32||XmlEnum("""CANA""")|1|
||ASIA|Int32||XmlEnum("""ASIA""")|2|
||BERM|Int32||XmlEnum("""BERM""")|3|
||EURO|Int32||XmlEnum("""EURO""")|4|
||AMER|Int32||XmlEnum("""AMER""")|5|

---

## Enum ISO20022.Reda007001.OptionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PUTO|Int32||XmlEnum("""PUTO""")|1|
||CALL|Int32||XmlEnum("""CALL""")|2|

---

## Value ISO20022.Reda007001.OptionType8Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.Organisation38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ScndryComAdr|ISO20022.Reda007001.CommunicationAddress3||XmlElement()||
|+|PmryComAdr|ISO20022.Reda007001.CommunicationAddress3||XmlElement()||
|+|PstlAdr|global::System.Collections.Generic.List<ISO20022.Reda007001.PostalAddress3>||XmlElement()||
|+|NtlRegnNb|String||XmlElement()||
|+|TaxIdNb|String||XmlElement()||
|+|RegnDt|DateTime||XmlElement()||
|+|RegnCtry|String||XmlElement()||
|+|TaxtnCtry|String||XmlElement()||
|+|Purp|String||XmlElement()||
|+|Id|ISO20022.Reda007001.PartyIdentification177Choice||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ScndryComAdr),validElement(PmryComAdr),validRequired("""PstlAdr""",PstlAdr),validList("""PstlAdr""",PstlAdr),validListMax("""PstlAdr""",PstlAdr,5),validElement(PstlAdr),validPattern("""RegnCtry""",RegnCtry,"""[A-Z]{2,2}"""),validPattern("""TaxtnCtry""",TaxtnCtry,"""[A-Z]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Reda007001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Reda007001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Reda007001.PartyIdentification120Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Reda007001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Reda007001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Reda007001.PartyIdentification136


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LEI|String||XmlElement()||
|+|Id|ISO20022.Reda007001.PartyIdentification120Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LEI""",LEI,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(Id))|

---

## Value ISO20022.Reda007001.PartyIdentification177Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Reda007001.GenericIdentification1||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Reda007001.PostalAddress1


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

## Value ISO20022.Reda007001.PostalAddress3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NmAndAdr|ISO20022.Reda007001.NameAndAddress4||XmlElement()||
|+|RegnAdrInd|String||XmlElement()||
|+|MlngInd|String||XmlElement()||
|+|AdrTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NmAndAdr))|

---

## Enum ISO20022.Reda007001.PreferenceToIncome1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PFRD|Int32||XmlEnum("""PFRD""")|1|
||ORDN|Int32||XmlEnum("""ORDN""")|2|

---

## Value ISO20022.Reda007001.PreferenceToIncome5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.Price8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricTp|String||XmlElement()||
|+|Val|ISO20022.Reda007001.PriceRateOrAmount3Choice||XmlElement()||
|+|ValTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val))|

---

## Value ISO20022.Reda007001.PriceRateOrAmount3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Reda007001.ActiveOrHistoricCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Reda007001.PriceValue1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Reda007001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt))|

---

## Enum ISO20022.Reda007001.PriceValueType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VACT|Int32||XmlEnum("""VACT""")|1|
||FICT|Int32||XmlEnum("""FICT""")|2|
||TEDY|Int32||XmlEnum("""TEDY""")|3|
||TEDP|Int32||XmlEnum("""TEDP""")|4|
||ABSO|Int32||XmlEnum("""ABSO""")|5|
||PEUN|Int32||XmlEnum("""PEUN""")|6|
||SPRE|Int32||XmlEnum("""SPRE""")|7|
||YIEL|Int32||XmlEnum("""YIEL""")|8|
||PARV|Int32||XmlEnum("""PARV""")|9|
||PREM|Int32||XmlEnum("""PREM""")|10|
||DISC|Int32||XmlEnum("""DISC""")|11|

---

## Enum ISO20022.Reda007001.PutType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TWOS|Int32||XmlEnum("""TWOS""")|1|
||OPTI|Int32||XmlEnum("""OPTI""")|2|
||MAND|Int32||XmlEnum("""MAND""")|3|

---

## Value ISO20022.Reda007001.PutType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.RateAndAmountFormat1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotSpcfdRate|ISO20022.Reda007001.RateType12FormatChoice||XmlElement()||
|+|Amt|ISO20022.Reda007001.ActiveCurrencyAndAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotSpcfdRate),validElement(Amt),validChoice(NotSpcfdRate,Amt,Rate))|

---

## Value ISO20022.Reda007001.RateOrAbsoluteValue1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AbsVal|Decimal||XmlElement()||
|+|RateVal|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AbsVal,RateVal))|

---

## Enum ISO20022.Reda007001.RateType12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NILP|Int32||XmlEnum("""NILP""")|1|
||UKWN|Int32||XmlEnum("""UKWN""")|2|
||OPEN|Int32||XmlEnum("""OPEN""")|3|

---

## Value ISO20022.Reda007001.RateType12FormatChoice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification13||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.RestrictionType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||VOTR|Int32||XmlEnum("""VOTR""")|1|
||HOLR|Int32||XmlEnum("""HOLR""")|2|
||PLAR|Int32||XmlEnum("""PLAR""")|3|
||BUYR|Int32||XmlEnum("""BUYR""")|4|
||SELR|Int32||XmlEnum("""SELR""")|5|

---

## Enum ISO20022.Reda007001.SecuritiesPaymentStatus1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PART|Int32||XmlEnum("""PART""")|1|
||NILL|Int32||XmlEnum("""NILL""")|2|
||FULL|Int32||XmlEnum("""FULL""")|3|

---

## Value ISO20022.Reda007001.SecuritiesPaymentStatus5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.SecuritiesTransactionType11Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SYND|Int32||XmlEnum("""SYND""")|1|
||NSYN|Int32||XmlEnum("""NSYN""")|2|

---

## Value ISO20022.Reda007001.SecuritiesTransactionType31Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.SecuritiesUpdateReason1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.SecurityAttributes12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Reda007001.SupplementaryData1>||XmlElement()||
|+|FinInstrmAttrbts|global::System.Collections.Generic.List<ISO20022.Reda007001.CommonFinancialInstrumentAttributes12>||XmlElement()||
|+|FinInstrmTp|global::System.Collections.Generic.List<ISO20022.Reda007001.FinancialInstrument97>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validList("""FinInstrmAttrbts""",FinInstrmAttrbts),validElement(FinInstrmAttrbts),validList("""FinInstrmTp""",FinInstrmTp),validElement(FinInstrmTp))|

---

## Value ISO20022.Reda007001.SecurityIdentification39


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Reda007001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Aspect ISO20022.Reda007001.SecurityMaintenanceRequestV01


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Reda007001.SupplementaryData1>||XmlElement()||
|+|FinInstrmId|ISO20022.Reda007001.SecurityIdentification39||XmlElement()||
|+|UpdRsn|ISO20022.Reda007001.SecuritiesUpdateReason1Choice||XmlElement()||
|+|UpdTp|ISO20022.Reda007001.UpdateType36Choice||XmlElement()||
|+|MsgHdr|ISO20022.Reda007001.MessageHeader1||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(FinInstrmId),validElement(UpdRsn),validElement(UpdTp),validElement(MsgHdr))|

---

## Value ISO20022.Reda007001.SecurityRestriction3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InvstrTp|global::System.Collections.Generic.List<ISO20022.Reda007001.InvestorType3Choice>||XmlElement()||
|+|InvstrRstrctnTp|global::System.Collections.Generic.List<ISO20022.Reda007001.InvestorRestrictionType3Choice>||XmlElement()||
|+|LglRstrctnTp|ISO20022.Reda007001.LegalRestrictions5Choice||XmlElement()||
|+|RstrctnTp|ISO20022.Reda007001.SecurityRestrictionType2Choice||XmlElement()||
|+|FctvPrd|ISO20022.Reda007001.DateTimePeriod2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""InvstrTp""",InvstrTp),validElement(InvstrTp),validList("""InvstrRstrctnTp""",InvstrRstrctnTp),validElement(InvstrRstrctnTp),validElement(LglRstrctnTp),validElement(RstrctnTp),validElement(FctvPrd))|

---

## Value ISO20022.Reda007001.SecurityRestrictionType2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryRstrctn|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|RstrctnTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryRstrctn),validChoice(PrtryRstrctn,RstrctnTp))|

---

## Enum ISO20022.Reda007001.SecurityStatus2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SUSP|Int32||XmlEnum("""SUSP""")|1|
||INAC|Int32||XmlEnum("""INAC""")|2|
||ACTV|Int32||XmlEnum("""ACTV""")|3|

---

## Value ISO20022.Reda007001.SecurityStatus3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.SecurityWithHoldingTax1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Ctry|String||XmlElement()||
|+|WhldgTaxVal|ISO20022.Reda007001.RateAndAmountFormat1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(WhldgTaxVal))|

---

## Enum ISO20022.Reda007001.SettleStyle1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SETO|Int32||XmlEnum("""SETO""")|1|
||SETC|Int32||XmlEnum("""SETC""")|2|

---

## Value ISO20022.Reda007001.SettleStyle2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.SettlementInformation17


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DevtgSttlmUnit|global::System.Collections.Generic.List<ISO20022.Reda007001.FinancialInstrumentQuantity1Choice>||XmlElement()||
|+|MinMltplQty|ISO20022.Reda007001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|MinDnmtn|ISO20022.Reda007001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|CtrctSttlmMnth|String||XmlElement()||
|+|SctiesQtyTp|ISO20022.Reda007001.SettlementUnitType3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""DevtgSttlmUnit""",DevtgSttlmUnit),validElement(DevtgSttlmUnit),validElement(MinMltplQty),validElement(MinDnmtn),validElement(SctiesQtyTp))|

---

## Enum ISO20022.Reda007001.SettlementType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NETO|Int32||XmlEnum("""NETO""")|1|
||PRIN|Int32||XmlEnum("""PRIN""")|2|

---

## Value ISO20022.Reda007001.SettlementType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.SettlementUnitType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNIT|Int32||XmlEnum("""UNIT""")|1|
||FAMT|Int32||XmlEnum("""FAMT""")|2|

---

## Value ISO20022.Reda007001.SettlementUnitType3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.Standardisation1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||STAN|Int32||XmlEnum("""STAN""")|1|
||NSTA|Int32||XmlEnum("""NSTA""")|2|
||FLEX|Int32||XmlEnum("""FLEX""")|3|

---

## Value ISO20022.Reda007001.Standardisation3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validRequired("""Cd""",Cd),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Reda007001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Reda007001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Reda007001.TEFRARules1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||RULD|Int32||XmlEnum("""RULD""")|1|
||RULC|Int32||XmlEnum("""RULC""")|2|

---

## Value ISO20022.Reda007001.TEFRARules3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.Term1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Val|ISO20022.Reda007001.RateOrAbsoluteValue1Choice||XmlElement()||
|+|Oprtr|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Val))|

---

## Enum ISO20022.Reda007001.TimeUnit1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YEAR|Int32||XmlEnum("""YEAR""")|1|
||WEEK|Int32||XmlEnum("""WEEK""")|2|
||SECO|Int32||XmlEnum("""SECO""")|3|
||MNTH|Int32||XmlEnum("""MNTH""")|4|
||MINU|Int32||XmlEnum("""MINU""")|5|
||HOUR|Int32||XmlEnum("""HOUR""")|6|
||DAYC|Int32||XmlEnum("""DAYC""")|7|

---

## Value ISO20022.Reda007001.TimeUnit3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.TradeTransactionCondition2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||GTDL|Int32||XmlEnum("""GTDL""")|1|
||SPEX|Int32||XmlEnum("""SPEX""")|2|
||SPCU|Int32||XmlEnum("""SPCU""")|3|
||SPPR|Int32||XmlEnum("""SPPR""")|4|
||CAST|Int32||XmlEnum("""CAST""")|5|
||SECR|Int32||XmlEnum("""SECR""")|6|
||SCCR|Int32||XmlEnum("""SCCR""")|7|
||SERT|Int32||XmlEnum("""SERT""")|8|
||SCRT|Int32||XmlEnum("""SCRT""")|9|
||SCBN|Int32||XmlEnum("""SCBN""")|10|
||SEBN|Int32||XmlEnum("""SEBN""")|11|
||SECN|Int32||XmlEnum("""SECN""")|12|
||SPCC|Int32||XmlEnum("""SPCC""")|13|

---

## Value ISO20022.Reda007001.TradeTransactionCondition7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.TradingParameters2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PmryPlcOfListgId|String||XmlElement()||
|+|MinTradgPricgIncrmt|Decimal||XmlElement()||
|+|MaxTraddNmnlQty|ISO20022.Reda007001.UnitOrFaceAmount1Choice||XmlElement()||
|+|MinTraddNmnlQty|ISO20022.Reda007001.UnitOrFaceAmount1Choice||XmlElement()||
|+|ScndryPlcOfListg|global::System.Collections.Generic.List<String>||XmlElement()||
|+|TradLotSz|ISO20022.Reda007001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|RndLot|ISO20022.Reda007001.FinancialInstrumentQuantity1Choice||XmlElement()||
|+|MktId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PmryPlcOfListgId""",PmryPlcOfListgId,"""[A-Z0-9]{4,4}"""),validElement(MaxTraddNmnlQty),validElement(MinTraddNmnlQty),validPattern("""ScndryPlcOfListg""",ScndryPlcOfListg,"""[A-Z0-9]{4,4}"""),validListMax("""ScndryPlcOfListg""",ScndryPlcOfListg,5),validElement(TradLotSz),validElement(RndLot),validPattern("""MktId""",MktId,"""[A-Z0-9]{4,4}"""))|

---

## Enum ISO20022.Reda007001.TypeOfPrice1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||STOP|Int32||XmlEnum("""STOP""")|1|
||RDAV|Int32||XmlEnum("""RDAV""")|2|
||PARV|Int32||XmlEnum("""PARV""")|3|
||NOGR|Int32||XmlEnum("""NOGR""")|4|
||NUND|Int32||XmlEnum("""NUND""")|5|
||NET1|Int32||XmlEnum("""NET1""")|6|
||NDIS|Int32||XmlEnum("""NDIS""")|7|
||NET2|Int32||XmlEnum("""NET2""")|8|
||LIMI|Int32||XmlEnum("""LIMI""")|9|
||GREX|Int32||XmlEnum("""GREX""")|10|
||COMB|Int32||XmlEnum("""COMB""")|11|
||AVOV|Int32||XmlEnum("""AVOV""")|12|
||AVER|Int32||XmlEnum("""AVER""")|13|

---

## Value ISO20022.Reda007001.UnderlyingAttributes4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CapVal|ISO20022.Reda007001.ActiveCurrencyAndAmount||XmlElement()||
|+|XchgRate|Decimal||XmlElement()||
|+|AdjstdQty|ISO20022.Reda007001.UnitOrFaceAmount1Choice||XmlElement()||
|+|EndVal|ISO20022.Reda007001.ActiveCurrencyAndAmount||XmlElement()||
|+|CurVal|ISO20022.Reda007001.ActiveCurrencyAndAmount||XmlElement()||
|+|StartVal|ISO20022.Reda007001.ActiveCurrencyAndAmount||XmlElement()||
|+|EndPric|ISO20022.Reda007001.Price8||XmlElement()||
|+|DrtyPric|ISO20022.Reda007001.Price8||XmlElement()||
|+|Pric|ISO20022.Reda007001.Price8||XmlElement()||
|+|CshTp|String||XmlElement()||
|+|CshAmt|ISO20022.Reda007001.ActiveCurrencyAndAmount||XmlElement()||
|+|SttlmTp|ISO20022.Reda007001.SettlementType3Choice||XmlElement()||
|+|Qty|ISO20022.Reda007001.UnitOrFaceAmount1Choice||XmlElement()||
|+|AllcnPctg|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CapVal),validElement(AdjstdQty),validElement(EndVal),validElement(CurVal),validElement(StartVal),validElement(EndPric),validElement(DrtyPric),validElement(Pric),validElement(CshAmt),validElement(SttlmTp),validElement(Qty))|

---

## Value ISO20022.Reda007001.UnitOfMeasure7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Reda007001.UnitOfMeasure9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||HECT|Int32||XmlEnum("""HECT""")|1|
||ARES|Int32||XmlEnum("""ARES""")|2|
||ACRE|Int32||XmlEnum("""ACRE""")|3|
||GBOU|Int32||XmlEnum("""GBOU""")|4|
||YARD|Int32||XmlEnum("""YARD""")|5|
||USTN|Int32||XmlEnum("""USTN""")|6|
||USQA|Int32||XmlEnum("""USQA""")|7|
||USPI|Int32||XmlEnum("""USPI""")|8|
||USGA|Int32||XmlEnum("""USGA""")|9|
||USFO|Int32||XmlEnum("""USFO""")|10|
||USBA|Int32||XmlEnum("""USBA""")|11|
||SQYA|Int32||XmlEnum("""SQYA""")|12|
||SMIL|Int32||XmlEnum("""SMIL""")|13|
||SQMI|Int32||XmlEnum("""SQMI""")|14|
||SMET|Int32||XmlEnum("""SMET""")|15|
||SQKI|Int32||XmlEnum("""SQKI""")|16|
||SQIN|Int32||XmlEnum("""SQIN""")|17|
||SQFO|Int32||XmlEnum("""SQFO""")|18|
||SCMT|Int32||XmlEnum("""SCMT""")|19|
||USOU|Int32||XmlEnum("""USOU""")|20|
||PUND|Int32||XmlEnum("""PUND""")|21|
||MILI|Int32||XmlEnum("""MILI""")|22|
||MMET|Int32||XmlEnum("""MMET""")|23|
||MILE|Int32||XmlEnum("""MILE""")|24|
||TONE|Int32||XmlEnum("""TONE""")|25|
||METR|Int32||XmlEnum("""METR""")|26|
||LITR|Int32||XmlEnum("""LITR""")|27|
||KMET|Int32||XmlEnum("""KMET""")|28|
||KILO|Int32||XmlEnum("""KILO""")|29|
||INCH|Int32||XmlEnum("""INCH""")|30|
||GRAM|Int32||XmlEnum("""GRAM""")|31|
||GBTN|Int32||XmlEnum("""GBTN""")|32|
||GBQA|Int32||XmlEnum("""GBQA""")|33|
||GBPI|Int32||XmlEnum("""GBPI""")|34|
||GBGA|Int32||XmlEnum("""GBGA""")|35|
||GBFO|Int32||XmlEnum("""GBFO""")|36|
||FOOT|Int32||XmlEnum("""FOOT""")|37|
||PIEC|Int32||XmlEnum("""PIEC""")|38|
||CBML|Int32||XmlEnum("""CBML""")|39|
||CBME|Int32||XmlEnum("""CBME""")|40|
||CBIN|Int32||XmlEnum("""CBIN""")|41|
||CRAT|Int32||XmlEnum("""CRAT""")|42|
||CNTR|Int32||XmlEnum("""CNTR""")|43|
||CMET|Int32||XmlEnum("""CMET""")|44|
||CELI|Int32||XmlEnum("""CELI""")|45|
||CRTN|Int32||XmlEnum("""CRTN""")|46|
||BOXX|Int32||XmlEnum("""BOXX""")|47|
||BOTL|Int32||XmlEnum("""BOTL""")|48|
||BALE|Int32||XmlEnum("""BALE""")|49|
||BAGG|Int32||XmlEnum("""BAGG""")|50|

---

## Value ISO20022.Reda007001.UnitOrFaceAmount1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FaceAmt|ISO20022.Reda007001.ActiveCurrencyAndAmount||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FaceAmt),validChoice(FaceAmt,Unit))|

---

## Value ISO20022.Reda007001.UpdateType35Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Modfy|ISO20022.Reda007001.SecurityAttributes12||XmlElement()||
|+|Del|ISO20022.Reda007001.SecurityAttributes12||XmlElement()||
|+|Add|ISO20022.Reda007001.SecurityAttributes12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Modfy),validElement(Del),validElement(Add),validChoice(Modfy,Del,Add))|

---

## Value ISO20022.Reda007001.UpdateType36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rplc|ISO20022.Reda007001.SecurityAttributes12||XmlElement()||
|+|UpdTp|global::System.Collections.Generic.List<ISO20022.Reda007001.UpdateType35Choice>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Rplc),validRequired("""UpdTp""",UpdTp),validList("""UpdTp""",UpdTp),validListMax("""UpdTp""",UpdTp,3),validElement(UpdTp),validChoice(Rplc,UpdTp))|

---

## Value ISO20022.Reda007001.Warrant4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|WarrtAgt|global::System.Collections.Generic.List<ISO20022.Reda007001.Organisation38>||XmlElement()||
|+|Tp|ISO20022.Reda007001.WarrantStyle3Choice||XmlElement()||
|+|SbcptPric|ISO20022.Reda007001.Price8||XmlElement()||
|+|Mltplr|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""WarrtAgt""",WarrtAgt),validElement(WarrtAgt),validElement(Tp),validElement(SbcptPric))|

---

## Enum ISO20022.Reda007001.WarrantStyle1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BERM|Int32||XmlEnum("""BERM""")|1|
||EURO|Int32||XmlEnum("""EURO""")|2|
||AMER|Int32||XmlEnum("""AMER""")|3|

---

## Value ISO20022.Reda007001.WarrantStyle3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Reda007001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Reda007001.YieldCalculation6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ClctnDt|DateTime||XmlElement()||
|+|ValPrd|ISO20022.Reda007001.DateTimePeriod1Choice||XmlElement()||
|+|ValDt|DateTime||XmlElement()||
|+|RedPric|ISO20022.Reda007001.Price8||XmlElement()||
|+|ClctnTp|ISO20022.Reda007001.CalculationType3Choice||XmlElement()||
|+|Val|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(ValPrd),validElement(RedPric),validElement(ClctnTp))|

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

