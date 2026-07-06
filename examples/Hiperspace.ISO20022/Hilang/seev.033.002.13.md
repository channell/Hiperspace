# seev.033.002.13
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev033002.AccountAndBalance62 {
        + Bal  : ISO20022.Seev033002.CorporateActionBalanceDetails44
        + SfkpgPlc  : ISO20022.Seev033002.SafekeepingPlaceFormat48Choice
        + AcctOwnr  : ISO20022.Seev033002.PartyIdentification136Choice
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
    }
    ISO20022.Seev033002.AccountAndBalance62 *-- ISO20022.Seev033002.CorporateActionBalanceDetails44
    ISO20022.Seev033002.AccountAndBalance62 *-- ISO20022.Seev033002.SafekeepingPlaceFormat48Choice
    ISO20022.Seev033002.AccountAndBalance62 *-- ISO20022.Seev033002.PartyIdentification136Choice
    class ISO20022.Seev033002.AlternatePartyIdentification11 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Seev033002.IdentificationType46Choice
    }
    ISO20022.Seev033002.AlternatePartyIdentification11 *-- ISO20022.Seev033002.IdentificationType46Choice
    class ISO20022.Seev033002.AlternatePartyIdentification9 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Seev033002.IdentificationType44Choice
    }
    ISO20022.Seev033002.AlternatePartyIdentification9 *-- ISO20022.Seev033002.IdentificationType44Choice
    class ISO20022.Seev033002.AmountPrice5 {
        + PricVal  : ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev033002.AmountPrice5 *-- ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev033002.AmountPricePerAmount3 {
        + Amt  : ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + PricVal  : ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev033002.AmountPricePerAmount3 *-- ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev033002.AmountPricePerAmount3 *-- ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev033002.AmountPricePerFinancialInstrumentQuantity11 {
        + FinInstrmQty  : ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
        + PricVal  : ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev033002.AmountPricePerFinancialInstrumentQuantity11 *-- ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev033002.AmountPricePerFinancialInstrumentQuantity11 *-- ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev033002.AmountPriceType1Code {
        PREM = 1
        PLOT = 2
        DISC = 3
        ACTU = 4
    }
    class ISO20022.Seev033002.BalanceFormat14Choice {
        + NotElgblBal  : ISO20022.Seev033002.SignedQuantityFormat13
        + ElgblBal  : ISO20022.Seev033002.SignedQuantityFormat13
        + Bal  : ISO20022.Seev033002.SignedQuantityFormat12
    }
    ISO20022.Seev033002.BalanceFormat14Choice *-- ISO20022.Seev033002.SignedQuantityFormat13
    ISO20022.Seev033002.BalanceFormat14Choice *-- ISO20022.Seev033002.SignedQuantityFormat13
    ISO20022.Seev033002.BalanceFormat14Choice *-- ISO20022.Seev033002.SignedQuantityFormat12
    class ISO20022.Seev033002.BeneficiaryCertificationType11Choice {
        + Prtry  : ISO20022.Seev033002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev033002.BeneficiaryCertificationType11Choice *-- ISO20022.Seev033002.GenericIdentification47
    class ISO20022.Seev033002.BeneficiaryCertificationType5Code {
        QIBB = 1
        NCOM = 2
        ACCI = 3
    }
    class ISO20022.Seev033002.ClassificationType33Choice {
        + AltrnClssfctn  : ISO20022.Seev033002.GenericIdentification86
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Seev033002.ClassificationType33Choice *-- ISO20022.Seev033002.GenericIdentification86
    class ISO20022.Seev033002.CorporateActionBalanceDetails44 {
        + RegdBal  : ISO20022.Seev033002.BalanceFormat14Choice
        + InTrnsShipmntBal  : ISO20022.Seev033002.BalanceFormat14Choice
        + TradDtPosBal  : ISO20022.Seev033002.BalanceFormat14Choice
        + StrtPosBal  : ISO20022.Seev033002.BalanceFormat14Choice
        + SttlmPosBal  : ISO20022.Seev033002.BalanceFormat14Choice
        + OutForRegnBal  : ISO20022.Seev033002.BalanceFormat14Choice
        + PdgRctBal  : global::System.Collections.Generic.List~ISO20022.Seev033002.BalanceFormat14Choice~
        + PdgDlvryBal  : global::System.Collections.Generic.List~ISO20022.Seev033002.BalanceFormat14Choice~
        + OnLnBal  : ISO20022.Seev033002.BalanceFormat14Choice
        + CollOutBal  : ISO20022.Seev033002.BalanceFormat14Choice
        + CollInBal  : ISO20022.Seev033002.BalanceFormat14Choice
        + BrrwdBal  : ISO20022.Seev033002.BalanceFormat14Choice
        + BlckdBal  : ISO20022.Seev033002.BalanceFormat14Choice
        + TtlElgblBal  : ISO20022.Seev033002.Quantity80Choice
    }
    ISO20022.Seev033002.CorporateActionBalanceDetails44 *-- ISO20022.Seev033002.BalanceFormat14Choice
    ISO20022.Seev033002.CorporateActionBalanceDetails44 *-- ISO20022.Seev033002.BalanceFormat14Choice
    ISO20022.Seev033002.CorporateActionBalanceDetails44 *-- ISO20022.Seev033002.BalanceFormat14Choice
    ISO20022.Seev033002.CorporateActionBalanceDetails44 *-- ISO20022.Seev033002.BalanceFormat14Choice
    ISO20022.Seev033002.CorporateActionBalanceDetails44 *-- ISO20022.Seev033002.BalanceFormat14Choice
    ISO20022.Seev033002.CorporateActionBalanceDetails44 *-- ISO20022.Seev033002.BalanceFormat14Choice
    ISO20022.Seev033002.CorporateActionBalanceDetails44 *-- ISO20022.Seev033002.BalanceFormat14Choice
    ISO20022.Seev033002.CorporateActionBalanceDetails44 *-- ISO20022.Seev033002.BalanceFormat14Choice
    ISO20022.Seev033002.CorporateActionBalanceDetails44 *-- ISO20022.Seev033002.BalanceFormat14Choice
    ISO20022.Seev033002.CorporateActionBalanceDetails44 *-- ISO20022.Seev033002.BalanceFormat14Choice
    ISO20022.Seev033002.CorporateActionBalanceDetails44 *-- ISO20022.Seev033002.BalanceFormat14Choice
    ISO20022.Seev033002.CorporateActionBalanceDetails44 *-- ISO20022.Seev033002.BalanceFormat14Choice
    ISO20022.Seev033002.CorporateActionBalanceDetails44 *-- ISO20022.Seev033002.BalanceFormat14Choice
    ISO20022.Seev033002.CorporateActionBalanceDetails44 *-- ISO20022.Seev033002.Quantity80Choice
    class ISO20022.Seev033002.CorporateActionChangeType2Code {
        TERM = 1
        REBE = 2
        PHDE = 3
        NAME = 4
        GTPH = 5
        GTGP = 6
        GPPH = 7
        DEPH = 8
        CERT = 9
        BERE = 10
    }
    class ISO20022.Seev033002.CorporateActionChangeTypeFormat7Choice {
        + Prtry  : ISO20022.Seev033002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev033002.CorporateActionChangeTypeFormat7Choice *-- ISO20022.Seev033002.GenericIdentification47
    class ISO20022.Seev033002.CorporateActionEventReference4 {
        + LkgTp  : ISO20022.Seev033002.ProcessingPosition10Choice
        + EvtId  : ISO20022.Seev033002.CorporateActionEventReference4Choice
    }
    ISO20022.Seev033002.CorporateActionEventReference4 *-- ISO20022.Seev033002.ProcessingPosition10Choice
    ISO20022.Seev033002.CorporateActionEventReference4 *-- ISO20022.Seev033002.CorporateActionEventReference4Choice
    class ISO20022.Seev033002.CorporateActionEventReference4Choice {
        + LkdCorpActnId  : String
        + LkdOffclCorpActnEvtId  : String
    }
    class ISO20022.Seev033002.CorporateActionEventType119Choice {
        + Prtry  : ISO20022.Seev033002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev033002.CorporateActionEventType119Choice *-- ISO20022.Seev033002.GenericIdentification47
    class ISO20022.Seev033002.CorporateActionEventType40Code {
        ACCU = 1
        WRTH = 2
        WTRC = 3
        EXWA = 4
        SUSP = 5
        DLST = 6
        TEND = 7
        TREC = 8
        SPLF = 9
        DVSE = 10
        SOFF = 11
        SMAL = 12
        SHPR = 13
        DVSC = 14
        RHTS = 15
        SPLR = 16
        BIDS = 17
        REMK = 18
        REDO = 19
        BPUT = 20
        PRIO = 21
        PDEF = 22
        PLAC = 23
        PINK = 24
        PRED = 25
        PCAL = 26
        PARI = 27
        OTHR = 28
        ODLT = 29
        CERT = 30
        NOOF = 31
        MRGR = 32
        EXTM = 33
        LIQU = 34
        RHDI = 35
        INTR = 36
        PPMT = 37
        INCR = 38
        MCAL = 39
        REDM = 40
        EXOF = 41
        DTCH = 42
        DRAW = 43
        DRIP = 44
        DVOP = 45
        DSCL = 46
        DETI = 47
        DECR = 48
        CREV = 49
        CONV = 50
        CONS = 51
        CLSA = 52
        COOP = 53
        CHAN = 54
        DVCA = 55
        DRCA = 56
        CAPI = 57
        CAPG = 58
        CAPD = 59
        EXRI = 60
        BONU = 61
        DFLT = 62
        BRUP = 63
        ATTI = 64
        ACTV = 65
    }
    class ISO20022.Seev033002.CorporateActionGeneralInformation189 {
        + UndrlygScty  : ISO20022.Seev033002.FinancialInstrumentAttributes133
        + EvtTp  : ISO20022.Seev033002.CorporateActionEventType119Choice
        + OffclCorpActnEvtId  : String
        + CorpActnEvtId  : String
    }
    ISO20022.Seev033002.CorporateActionGeneralInformation189 *-- ISO20022.Seev033002.FinancialInstrumentAttributes133
    ISO20022.Seev033002.CorporateActionGeneralInformation189 *-- ISO20022.Seev033002.CorporateActionEventType119Choice
    class ISO20022.Seev033002.CorporateActionInstruction002V13 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev033002.SupplementaryData1~
        + AddtlInf  : ISO20022.Seev033002.CorporateActionNarrative34
        + PrtctInstr  : ISO20022.Seev033002.ProtectInstruction5
        + CorpActnInstr  : ISO20022.Seev033002.CorporateActionOption243
        + BnfclOwnrDtls  : global::System.Collections.Generic.List~ISO20022.Seev033002.PartyIdentification317~
        + AcctDtls  : ISO20022.Seev033002.AccountAndBalance62
        + CorpActnGnlInf  : ISO20022.Seev033002.CorporateActionGeneralInformation189
        + EvtsLkg  : global::System.Collections.Generic.List~ISO20022.Seev033002.CorporateActionEventReference4~
        + OthrDocId  : global::System.Collections.Generic.List~ISO20022.Seev033002.DocumentIdentification38~
        + InstrCxlReqId  : ISO20022.Seev033002.DocumentIdentification37
        + CancInstrId  : ISO20022.Seev033002.DocumentIdentification37
        + ChngInstrInd  : String
    }
    ISO20022.Seev033002.CorporateActionInstruction002V13 *-- ISO20022.Seev033002.SupplementaryData1
    ISO20022.Seev033002.CorporateActionInstruction002V13 *-- ISO20022.Seev033002.CorporateActionNarrative34
    ISO20022.Seev033002.CorporateActionInstruction002V13 *-- ISO20022.Seev033002.ProtectInstruction5
    ISO20022.Seev033002.CorporateActionInstruction002V13 *-- ISO20022.Seev033002.CorporateActionOption243
    ISO20022.Seev033002.CorporateActionInstruction002V13 *-- ISO20022.Seev033002.PartyIdentification317
    ISO20022.Seev033002.CorporateActionInstruction002V13 *-- ISO20022.Seev033002.AccountAndBalance62
    ISO20022.Seev033002.CorporateActionInstruction002V13 *-- ISO20022.Seev033002.CorporateActionGeneralInformation189
    ISO20022.Seev033002.CorporateActionInstruction002V13 *-- ISO20022.Seev033002.CorporateActionEventReference4
    ISO20022.Seev033002.CorporateActionInstruction002V13 *-- ISO20022.Seev033002.DocumentIdentification38
    ISO20022.Seev033002.CorporateActionInstruction002V13 *-- ISO20022.Seev033002.DocumentIdentification37
    ISO20022.Seev033002.CorporateActionInstruction002V13 *-- ISO20022.Seev033002.DocumentIdentification37
    class ISO20022.Seev033002.CorporateActionNarrative33 {
        + InstrAddtlInf  : global::System.Collections.Generic.List~String~
        + FXInstrsAddtlInf  : global::System.Collections.Generic.List~String~
        + DlvryDtls  : global::System.Collections.Generic.List~String~
        + InfToCmplyWth  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Seev033002.CorporateActionNarrative34 {
        + CertfctnBrkdwn  : global::System.Collections.Generic.List~String~
        + PtyCtctNrrtv  : global::System.Collections.Generic.List~String~
        + RegnDtls  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Seev033002.CorporateActionOption16Code {
        BOBD = 1
        PRUN = 2
        TAXI = 3
        SLLE = 4
        SECU = 5
        QINV = 6
        OVER = 7
        OTHR = 8
        OFFR = 9
        NOQU = 10
        NOAC = 11
        MPUT = 12
        MKUP = 13
        MKDW = 14
        LAPS = 15
        EXER = 16
        CTEN = 17
        CONY = 18
        CONN = 19
        CEXC = 20
        CERT = 21
        CASH = 22
        CASE = 23
        BUYA = 24
        BSPL = 25
        ABST = 26
    }
    class ISO20022.Seev033002.CorporateActionOption243 {
        + AddtlInf  : ISO20022.Seev033002.CorporateActionNarrative33
        + ShrhldrNb  : String
        + PricDtls  : ISO20022.Seev033002.CorporateActionPrice91
        + RateAndAmtDtls  : ISO20022.Seev033002.CorporateActionRate130
        + ExctnReqdDtTm  : ISO20022.Seev033002.DateAndDateTime2Choice
        + SctiesQtyOrInstdAmt  : ISO20022.Seev033002.SecuritiesQuantityOrAmount7Choice
        + SctyId  : ISO20022.Seev033002.SecurityIdentification20
        + CcyOptn  : String
        + CcyToSell  : String
        + CcyToBuy  : String
        + SlctnDealrFeeInd  : String
        + ElgblForCollInd  : String
        + ChngTp  : global::System.Collections.Generic.List~ISO20022.Seev033002.CorporateActionChangeTypeFormat7Choice~
        + FrctnDspstn  : ISO20022.Seev033002.FractionDispositionType29Choice
        + OptnFeatrs  : ISO20022.Seev033002.OptionFeaturesFormat27Choice
        + OptnTp  : ISO20022.Seev033002.CorporateActionOption43Choice
        + OptnNb  : ISO20022.Seev033002.OptionNumber1Choice
    }
    ISO20022.Seev033002.CorporateActionOption243 *-- ISO20022.Seev033002.CorporateActionNarrative33
    ISO20022.Seev033002.CorporateActionOption243 *-- ISO20022.Seev033002.CorporateActionPrice91
    ISO20022.Seev033002.CorporateActionOption243 *-- ISO20022.Seev033002.CorporateActionRate130
    ISO20022.Seev033002.CorporateActionOption243 *-- ISO20022.Seev033002.DateAndDateTime2Choice
    ISO20022.Seev033002.CorporateActionOption243 *-- ISO20022.Seev033002.SecuritiesQuantityOrAmount7Choice
    ISO20022.Seev033002.CorporateActionOption243 *-- ISO20022.Seev033002.SecurityIdentification20
    ISO20022.Seev033002.CorporateActionOption243 *-- ISO20022.Seev033002.CorporateActionChangeTypeFormat7Choice
    ISO20022.Seev033002.CorporateActionOption243 *-- ISO20022.Seev033002.FractionDispositionType29Choice
    ISO20022.Seev033002.CorporateActionOption243 *-- ISO20022.Seev033002.OptionFeaturesFormat27Choice
    ISO20022.Seev033002.CorporateActionOption243 *-- ISO20022.Seev033002.CorporateActionOption43Choice
    ISO20022.Seev033002.CorporateActionOption243 *-- ISO20022.Seev033002.OptionNumber1Choice
    class ISO20022.Seev033002.CorporateActionOption43Choice {
        + Prtry  : ISO20022.Seev033002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev033002.CorporateActionOption43Choice *-- ISO20022.Seev033002.GenericIdentification47
    class ISO20022.Seev033002.CorporateActionPrice91 {
        + GncCshPricPdPerPdct  : ISO20022.Seev033002.PriceFormat83Choice
        + GncCshPricRcvdPerPdct  : ISO20022.Seev033002.PriceFormat84Choice
        + IssePric  : ISO20022.Seev033002.PriceFormat83Choice
        + IndctvOrMktPric  : ISO20022.Seev033002.IndicativeOrMarketPrice15Choice
    }
    ISO20022.Seev033002.CorporateActionPrice91 *-- ISO20022.Seev033002.PriceFormat83Choice
    ISO20022.Seev033002.CorporateActionPrice91 *-- ISO20022.Seev033002.PriceFormat84Choice
    ISO20022.Seev033002.CorporateActionPrice91 *-- ISO20022.Seev033002.PriceFormat83Choice
    ISO20022.Seev033002.CorporateActionPrice91 *-- ISO20022.Seev033002.IndicativeOrMarketPrice15Choice
    class ISO20022.Seev033002.CorporateActionRate130 {
        + ReqdScndLvlTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev033002.RateAndAmountFormat65Choice~
        + ReqdWhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev033002.RateAndAmountFormat65Choice~
        + OvrsbcptRate  : ISO20022.Seev033002.RateAndAmountFormat64Choice
        + PropsdRate  : Decimal
    }
    ISO20022.Seev033002.CorporateActionRate130 *-- ISO20022.Seev033002.RateAndAmountFormat65Choice
    ISO20022.Seev033002.CorporateActionRate130 *-- ISO20022.Seev033002.RateAndAmountFormat65Choice
    ISO20022.Seev033002.CorporateActionRate130 *-- ISO20022.Seev033002.RateAndAmountFormat64Choice
    class ISO20022.Seev033002.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Seev033002.DocumentIdentification37 {
        + LkgTp  : ISO20022.Seev033002.ProcessingPosition10Choice
        + Id  : String
    }
    ISO20022.Seev033002.DocumentIdentification37 *-- ISO20022.Seev033002.ProcessingPosition10Choice
    class ISO20022.Seev033002.DocumentIdentification38 {
        + LkgTp  : ISO20022.Seev033002.ProcessingPosition10Choice
        + DocNb  : ISO20022.Seev033002.DocumentNumber6Choice
        + Id  : ISO20022.Seev033002.DocumentIdentification4Choice
    }
    ISO20022.Seev033002.DocumentIdentification38 *-- ISO20022.Seev033002.ProcessingPosition10Choice
    ISO20022.Seev033002.DocumentIdentification38 *-- ISO20022.Seev033002.DocumentNumber6Choice
    ISO20022.Seev033002.DocumentIdentification38 *-- ISO20022.Seev033002.DocumentIdentification4Choice
    class ISO20022.Seev033002.DocumentIdentification4Choice {
        + AcctOwnrDocId  : String
        + AcctSvcrDocId  : String
    }
    class ISO20022.Seev033002.DocumentNumber6Choice {
        + PrtryNb  : ISO20022.Seev033002.GenericIdentification86
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Seev033002.DocumentNumber6Choice *-- ISO20022.Seev033002.GenericIdentification86
    class ISO20022.Seev033002.FinancialInstrumentAttributes133 {
        + CtrctSz  : ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
        + MinNmnlQty  : ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
        + NxtIntrstRate  : Decimal
        + IntrstRate  : Decimal
        + NxtFctr  : Decimal
        + PrvsFctr  : Decimal
        + ConvsDt  : DateTime
        + DtdDt  : DateTime
        + PutblDt  : DateTime
        + NxtCllblDt  : DateTime
        + IsseDt  : DateTime
        + MtrtyDt  : DateTime
        + FltgRateFxgDt  : DateTime
        + XpryDt  : DateTime
        + NxtCpnDt  : DateTime
        + DnmtnCcy  : String
        + ClssfctnTp  : ISO20022.Seev033002.ClassificationType33Choice
        + DayCntBsis  : ISO20022.Seev033002.InterestComputationMethodFormat5Choice
        + PlcOfListg  : ISO20022.Seev033002.MarketIdentification4Choice
        + FinInstrmId  : ISO20022.Seev033002.SecurityIdentification20
    }
    ISO20022.Seev033002.FinancialInstrumentAttributes133 *-- ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev033002.FinancialInstrumentAttributes133 *-- ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev033002.FinancialInstrumentAttributes133 *-- ISO20022.Seev033002.ClassificationType33Choice
    ISO20022.Seev033002.FinancialInstrumentAttributes133 *-- ISO20022.Seev033002.InterestComputationMethodFormat5Choice
    ISO20022.Seev033002.FinancialInstrumentAttributes133 *-- ISO20022.Seev033002.MarketIdentification4Choice
    ISO20022.Seev033002.FinancialInstrumentAttributes133 *-- ISO20022.Seev033002.SecurityIdentification20
    class ISO20022.Seev033002.FinancialInstrumentQuantity36Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev033002.FractionDispositionType10Code {
        DIST = 1
        EXPI = 2
        CINL = 3
        BUYU = 4
    }
    class ISO20022.Seev033002.FractionDispositionType29Choice {
        + Prtry  : ISO20022.Seev033002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev033002.FractionDispositionType29Choice *-- ISO20022.Seev033002.GenericIdentification47
    class ISO20022.Seev033002.GenericIdentification47 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev033002.GenericIdentification84 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev033002.GenericIdentification85 {
        + Id  : String
        + Tp  : ISO20022.Seev033002.GenericIdentification47
    }
    ISO20022.Seev033002.GenericIdentification85 *-- ISO20022.Seev033002.GenericIdentification47
    class ISO20022.Seev033002.GenericIdentification86 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev033002.IdentificationSource4Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev033002.IdentificationType44Choice {
        + Prtry  : ISO20022.Seev033002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev033002.IdentificationType44Choice *-- ISO20022.Seev033002.GenericIdentification47
    class ISO20022.Seev033002.IdentificationType46Choice {
        + Prtry  : ISO20022.Seev033002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev033002.IdentificationType46Choice *-- ISO20022.Seev033002.GenericIdentification47
    class ISO20022.Seev033002.IndicativeOrMarketPrice15Choice {
        + MktPric  : ISO20022.Seev033002.PriceFormat83Choice
        + IndctvPric  : ISO20022.Seev033002.PriceFormat83Choice
    }
    ISO20022.Seev033002.IndicativeOrMarketPrice15Choice *-- ISO20022.Seev033002.PriceFormat83Choice
    ISO20022.Seev033002.IndicativeOrMarketPrice15Choice *-- ISO20022.Seev033002.PriceFormat83Choice
    class ISO20022.Seev033002.InterestComputationMethod2Code {
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
    class ISO20022.Seev033002.InterestComputationMethodFormat5Choice {
        + Prtry  : ISO20022.Seev033002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev033002.InterestComputationMethodFormat5Choice *-- ISO20022.Seev033002.GenericIdentification47
    class ISO20022.Seev033002.MarketIdentification4Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Seev033002.NameAndAddress12 {
        + Nm  : String
    }
    class ISO20022.Seev033002.OptionFeatures12Code {
        OPLF = 1
    }
    class ISO20022.Seev033002.OptionFeaturesFormat27Choice {
        + Prtry  : ISO20022.Seev033002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev033002.OptionFeaturesFormat27Choice *-- ISO20022.Seev033002.GenericIdentification47
    class ISO20022.Seev033002.OptionNumber1Choice {
        + Cd  : String
        + Nb  : String
    }
    class ISO20022.Seev033002.OptionNumber1Code {
        UNSO = 1
    }
    class ISO20022.Seev033002.OriginalAndCurrentQuantities4 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Seev033002.OriginalAndCurrentQuantities7 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev033002.OtherIdentification2 {
        + Tp  : ISO20022.Seev033002.IdentificationSource4Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev033002.OtherIdentification2 *-- ISO20022.Seev033002.IdentificationSource4Choice
    class ISO20022.Seev033002.PartyIdentification136Choice {
        + PrtryId  : ISO20022.Seev033002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Seev033002.PartyIdentification136Choice *-- ISO20022.Seev033002.GenericIdentification84
    class ISO20022.Seev033002.PartyIdentification259Choice {
        + IndvOwnrId  : ISO20022.Seev033002.AlternatePartyIdentification11
        + NmAndAdr  : ISO20022.Seev033002.NameAndAddress12
        + PrtryId  : ISO20022.Seev033002.GenericIdentification84
        + AnyBIC  : String
    }
    ISO20022.Seev033002.PartyIdentification259Choice *-- ISO20022.Seev033002.AlternatePartyIdentification11
    ISO20022.Seev033002.PartyIdentification259Choice *-- ISO20022.Seev033002.NameAndAddress12
    ISO20022.Seev033002.PartyIdentification259Choice *-- ISO20022.Seev033002.GenericIdentification84
    class ISO20022.Seev033002.PartyIdentification317 {
        + CertfctnBrkdwn  : global::System.Collections.Generic.List~String~
        + WhldgTaxRate  : ISO20022.Seev033002.RateAndAmountFormat63Choice
        + CertfctnTp  : global::System.Collections.Generic.List~ISO20022.Seev033002.BeneficiaryCertificationType11Choice~
        + OwndSctiesQty  : ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
        + NonDmclCtry  : global::System.Collections.Generic.List~String~
        + DmclCtry  : String
        + AltrnId  : global::System.Collections.Generic.List~ISO20022.Seev033002.AlternatePartyIdentification9~
        + LEIId  : String
        + OwnrId  : ISO20022.Seev033002.PartyIdentification259Choice
    }
    ISO20022.Seev033002.PartyIdentification317 *-- ISO20022.Seev033002.RateAndAmountFormat63Choice
    ISO20022.Seev033002.PartyIdentification317 *-- ISO20022.Seev033002.BeneficiaryCertificationType11Choice
    ISO20022.Seev033002.PartyIdentification317 *-- ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev033002.PartyIdentification317 *-- ISO20022.Seev033002.AlternatePartyIdentification9
    ISO20022.Seev033002.PartyIdentification317 *-- ISO20022.Seev033002.PartyIdentification259Choice
    class ISO20022.Seev033002.PercentagePrice2 {
        + PricVal  : Decimal
        + PctgPricTp  : String
    }
    class ISO20022.Seev033002.PriceFormat83Choice {
        + AmtPric  : ISO20022.Seev033002.AmountPrice5
        + PctgPric  : ISO20022.Seev033002.PercentagePrice2
    }
    ISO20022.Seev033002.PriceFormat83Choice *-- ISO20022.Seev033002.AmountPrice5
    ISO20022.Seev033002.PriceFormat83Choice *-- ISO20022.Seev033002.PercentagePrice2
    class ISO20022.Seev033002.PriceFormat84Choice {
        + IndxPts  : Decimal
        + AmtPricPerAmt  : ISO20022.Seev033002.AmountPricePerAmount3
        + AmtPricPerFinInstrmQty  : ISO20022.Seev033002.AmountPricePerFinancialInstrumentQuantity11
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev033002.AmountPrice5
        + PctgPric  : ISO20022.Seev033002.PercentagePrice2
    }
    ISO20022.Seev033002.PriceFormat84Choice *-- ISO20022.Seev033002.AmountPricePerAmount3
    ISO20022.Seev033002.PriceFormat84Choice *-- ISO20022.Seev033002.AmountPricePerFinancialInstrumentQuantity11
    ISO20022.Seev033002.PriceFormat84Choice *-- ISO20022.Seev033002.AmountPrice5
    ISO20022.Seev033002.PriceFormat84Choice *-- ISO20022.Seev033002.PercentagePrice2
    class ISO20022.Seev033002.PriceRateType3Code {
        YIEL = 1
        PRCT = 2
        PREM = 3
        DISC = 4
    }
    class ISO20022.Seev033002.PriceValueType9Code {
        UKWN = 1
        UNSP = 2
        TBSP = 3
    }
    class ISO20022.Seev033002.ProcessingPosition10Choice {
        + Prtry  : ISO20022.Seev033002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev033002.ProcessingPosition10Choice *-- ISO20022.Seev033002.GenericIdentification47
    class ISO20022.Seev033002.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Seev033002.ProprietaryQuantity10 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev033002.ProprietaryQuantity9 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
    }
    class ISO20022.Seev033002.ProtectInstruction5 {
        + PrtctDt  : DateTime
        + PrtctSfkpgAcct  : String
        + TxId  : String
        + TxTp  : String
    }
    class ISO20022.Seev033002.ProtectTransactionType2Code {
        COVR = 1
        COVP = 2
        PROT = 3
    }
    class ISO20022.Seev033002.Quantity1Code {
        QALL = 1
    }
    class ISO20022.Seev033002.Quantity53Choice {
        + PrtryQty  : ISO20022.Seev033002.ProprietaryQuantity9
        + Qty  : ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Seev033002.Quantity53Choice *-- ISO20022.Seev033002.ProprietaryQuantity9
    ISO20022.Seev033002.Quantity53Choice *-- ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev033002.Quantity55Choice {
        + Qty  : ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
        + OrgnlAndCurFaceAmt  : ISO20022.Seev033002.OriginalAndCurrentQuantities4
        + Cd  : String
    }
    ISO20022.Seev033002.Quantity55Choice *-- ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev033002.Quantity55Choice *-- ISO20022.Seev033002.OriginalAndCurrentQuantities4
    class ISO20022.Seev033002.Quantity57Choice {
        + SgndQty  : ISO20022.Seev033002.SignedQuantityFormat13
        + OrgnlAndCurFaceAmt  : ISO20022.Seev033002.OriginalAndCurrentQuantities7
    }
    ISO20022.Seev033002.Quantity57Choice *-- ISO20022.Seev033002.SignedQuantityFormat13
    ISO20022.Seev033002.Quantity57Choice *-- ISO20022.Seev033002.OriginalAndCurrentQuantities7
    class ISO20022.Seev033002.Quantity80Choice {
        + PrtryQty  : ISO20022.Seev033002.ProprietaryQuantity10
        + QtyChc  : ISO20022.Seev033002.Quantity57Choice
    }
    ISO20022.Seev033002.Quantity80Choice *-- ISO20022.Seev033002.ProprietaryQuantity10
    ISO20022.Seev033002.Quantity80Choice *-- ISO20022.Seev033002.Quantity57Choice
    class ISO20022.Seev033002.RateAndAmountFormat63Choice {
        + Amt  : ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    ISO20022.Seev033002.RateAndAmountFormat63Choice *-- ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev033002.RateAndAmountFormat64Choice {
        + Amt  : ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev033002.RateAndAmountFormat64Choice *-- ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev033002.RateAndAmountFormat65Choice {
        + RateTpAndRate  : ISO20022.Seev033002.RateTypeAndPercentageRate15
        + Amt  : ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev033002.RateAndAmountFormat65Choice *-- ISO20022.Seev033002.RateTypeAndPercentageRate15
    ISO20022.Seev033002.RateAndAmountFormat65Choice *-- ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev033002.RateType46Choice {
        + Prtry  : ISO20022.Seev033002.GenericIdentification47
        + Cd  : String
    }
    ISO20022.Seev033002.RateType46Choice *-- ISO20022.Seev033002.GenericIdentification47
    class ISO20022.Seev033002.RateTypeAndPercentageRate15 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev033002.RateType46Choice
    }
    ISO20022.Seev033002.RateTypeAndPercentageRate15 *-- ISO20022.Seev033002.RateType46Choice
    class ISO20022.Seev033002.RateValueType7Code {
        UKWN = 1
    }
    class ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev033002.RestrictedFINActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev033002.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Seev033002.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Seev033002.SafekeepingPlaceFormat48Choice {
        + Prtry  : ISO20022.Seev033002.GenericIdentification85
        + TpAndId  : ISO20022.Seev033002.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev033002.SafekeepingPlaceTypeAndText9
    }
    ISO20022.Seev033002.SafekeepingPlaceFormat48Choice *-- ISO20022.Seev033002.GenericIdentification85
    ISO20022.Seev033002.SafekeepingPlaceFormat48Choice *-- ISO20022.Seev033002.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev033002.SafekeepingPlaceFormat48Choice *-- ISO20022.Seev033002.SafekeepingPlaceTypeAndText9
    class ISO20022.Seev033002.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev033002.SafekeepingPlaceTypeAndText9 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev033002.SecuritiesOption88 {
        + AddtlRndUpQty  : ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
        + InstdQty  : ISO20022.Seev033002.Quantity55Choice
        + CondlQty  : ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
    }
    ISO20022.Seev033002.SecuritiesOption88 *-- ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
    ISO20022.Seev033002.SecuritiesOption88 *-- ISO20022.Seev033002.Quantity55Choice
    ISO20022.Seev033002.SecuritiesOption88 *-- ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev033002.SecuritiesQuantityOrAmount7Choice {
        + InstdAmt  : ISO20022.Seev033002.RestrictedFINActiveCurrencyAndAmount
        + SctiesQty  : ISO20022.Seev033002.SecuritiesOption88
    }
    ISO20022.Seev033002.SecuritiesQuantityOrAmount7Choice *-- ISO20022.Seev033002.RestrictedFINActiveCurrencyAndAmount
    ISO20022.Seev033002.SecuritiesQuantityOrAmount7Choice *-- ISO20022.Seev033002.SecuritiesOption88
    class ISO20022.Seev033002.SecurityIdentification20 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev033002.OtherIdentification2~
        + ISIN  : String
    }
    ISO20022.Seev033002.SecurityIdentification20 *-- ISO20022.Seev033002.OtherIdentification2
    class ISO20022.Seev033002.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Seev033002.SignedQuantityFormat12 {
        + QtyChc  : ISO20022.Seev033002.Quantity53Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev033002.SignedQuantityFormat12 *-- ISO20022.Seev033002.Quantity53Choice
    class ISO20022.Seev033002.SignedQuantityFormat13 {
        + Qty  : ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev033002.SignedQuantityFormat13 *-- ISO20022.Seev033002.FinancialInstrumentQuantity36Choice
    class ISO20022.Seev033002.SupplementaryData1 {
        + Envlp  : ISO20022.Seev033002.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev033002.SupplementaryData1 *-- ISO20022.Seev033002.SupplementaryDataEnvelope1
    class ISO20022.Seev033002.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Seev033002.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Seev033002.WithholdingTaxRateType1Code {
        NRAT = 1
        FTCA = 2
        BWIT = 3
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

## Value ISO20022.Seev033002.AccountAndBalance62


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|ISO20022.Seev033002.CorporateActionBalanceDetails44||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev033002.SafekeepingPlaceFormat48Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Seev033002.PartyIdentification136Choice||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bal),validElement(SfkpgPlc),validElement(AcctOwnr),validPattern("""BlckChainAdrOrWllt""",BlckChainAdrOrWllt,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validPattern("""SfkpgAcct""",SfkpgAcct,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,35}"""))|

---

## Value ISO20022.Seev033002.AlternatePartyIdentification11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Seev033002.IdentificationType46Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Seev033002.AlternatePartyIdentification9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Seev033002.IdentificationType44Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AltrnId""",AltrnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Seev033002.AmountPrice5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Value ISO20022.Seev033002.AmountPricePerAmount3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|PricVal|ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(PricVal))|

---

## Value ISO20022.Seev033002.AmountPricePerFinancialInstrumentQuantity11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmQty|ISO20022.Seev033002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|PricVal|ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmQty),validElement(PricVal))|

---

## Enum ISO20022.Seev033002.AmountPriceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREM|Int32||XmlEnum("""PREM""")|1|
||PLOT|Int32||XmlEnum("""PLOT""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|
||ACTU|Int32||XmlEnum("""ACTU""")|4|

---

## Value ISO20022.Seev033002.BalanceFormat14Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotElgblBal|ISO20022.Seev033002.SignedQuantityFormat13||XmlElement()||
|+|ElgblBal|ISO20022.Seev033002.SignedQuantityFormat13||XmlElement()||
|+|Bal|ISO20022.Seev033002.SignedQuantityFormat12||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotElgblBal),validElement(ElgblBal),validElement(Bal),validChoice(NotElgblBal,ElgblBal,Bal))|

---

## Value ISO20022.Seev033002.BeneficiaryCertificationType11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev033002.BeneficiaryCertificationType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||QIBB|Int32||XmlEnum("""QIBB""")|1|
||NCOM|Int32||XmlEnum("""NCOM""")|2|
||ACCI|Int32||XmlEnum("""ACCI""")|3|

---

## Value ISO20022.Seev033002.ClassificationType33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Seev033002.GenericIdentification86||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Value ISO20022.Seev033002.CorporateActionBalanceDetails44


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegdBal|ISO20022.Seev033002.BalanceFormat14Choice||XmlElement()||
|+|InTrnsShipmntBal|ISO20022.Seev033002.BalanceFormat14Choice||XmlElement()||
|+|TradDtPosBal|ISO20022.Seev033002.BalanceFormat14Choice||XmlElement()||
|+|StrtPosBal|ISO20022.Seev033002.BalanceFormat14Choice||XmlElement()||
|+|SttlmPosBal|ISO20022.Seev033002.BalanceFormat14Choice||XmlElement()||
|+|OutForRegnBal|ISO20022.Seev033002.BalanceFormat14Choice||XmlElement()||
|+|PdgRctBal|global::System.Collections.Generic.List<ISO20022.Seev033002.BalanceFormat14Choice>||XmlElement()||
|+|PdgDlvryBal|global::System.Collections.Generic.List<ISO20022.Seev033002.BalanceFormat14Choice>||XmlElement()||
|+|OnLnBal|ISO20022.Seev033002.BalanceFormat14Choice||XmlElement()||
|+|CollOutBal|ISO20022.Seev033002.BalanceFormat14Choice||XmlElement()||
|+|CollInBal|ISO20022.Seev033002.BalanceFormat14Choice||XmlElement()||
|+|BrrwdBal|ISO20022.Seev033002.BalanceFormat14Choice||XmlElement()||
|+|BlckdBal|ISO20022.Seev033002.BalanceFormat14Choice||XmlElement()||
|+|TtlElgblBal|ISO20022.Seev033002.Quantity80Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RegdBal),validElement(InTrnsShipmntBal),validElement(TradDtPosBal),validElement(StrtPosBal),validElement(SttlmPosBal),validElement(OutForRegnBal),validList("""PdgRctBal""",PdgRctBal),validElement(PdgRctBal),validList("""PdgDlvryBal""",PdgDlvryBal),validElement(PdgDlvryBal),validElement(OnLnBal),validElement(CollOutBal),validElement(CollInBal),validElement(BrrwdBal),validElement(BlckdBal),validElement(TtlElgblBal))|

---

## Enum ISO20022.Seev033002.CorporateActionChangeType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||TERM|Int32||XmlEnum("""TERM""")|1|
||REBE|Int32||XmlEnum("""REBE""")|2|
||PHDE|Int32||XmlEnum("""PHDE""")|3|
||NAME|Int32||XmlEnum("""NAME""")|4|
||GTPH|Int32||XmlEnum("""GTPH""")|5|
||GTGP|Int32||XmlEnum("""GTGP""")|6|
||GPPH|Int32||XmlEnum("""GPPH""")|7|
||DEPH|Int32||XmlEnum("""DEPH""")|8|
||CERT|Int32||XmlEnum("""CERT""")|9|
||BERE|Int32||XmlEnum("""BERE""")|10|

---

## Value ISO20022.Seev033002.CorporateActionChangeTypeFormat7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033002.CorporateActionEventReference4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev033002.ProcessingPosition10Choice||XmlElement()||
|+|EvtId|ISO20022.Seev033002.CorporateActionEventReference4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(EvtId))|

---

## Value ISO20022.Seev033002.CorporateActionEventReference4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkdCorpActnId|String||XmlElement()||
|+|LkdOffclCorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""LkdCorpActnId""",LkdCorpActnId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""LkdOffclCorpActnEvtId""",LkdOffclCorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validChoice(LkdCorpActnId,LkdOffclCorpActnEvtId))|

---

## Value ISO20022.Seev033002.CorporateActionEventType119Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev033002.CorporateActionEventType40Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ACCU|Int32||XmlEnum("""ACCU""")|1|
||WRTH|Int32||XmlEnum("""WRTH""")|2|
||WTRC|Int32||XmlEnum("""WTRC""")|3|
||EXWA|Int32||XmlEnum("""EXWA""")|4|
||SUSP|Int32||XmlEnum("""SUSP""")|5|
||DLST|Int32||XmlEnum("""DLST""")|6|
||TEND|Int32||XmlEnum("""TEND""")|7|
||TREC|Int32||XmlEnum("""TREC""")|8|
||SPLF|Int32||XmlEnum("""SPLF""")|9|
||DVSE|Int32||XmlEnum("""DVSE""")|10|
||SOFF|Int32||XmlEnum("""SOFF""")|11|
||SMAL|Int32||XmlEnum("""SMAL""")|12|
||SHPR|Int32||XmlEnum("""SHPR""")|13|
||DVSC|Int32||XmlEnum("""DVSC""")|14|
||RHTS|Int32||XmlEnum("""RHTS""")|15|
||SPLR|Int32||XmlEnum("""SPLR""")|16|
||BIDS|Int32||XmlEnum("""BIDS""")|17|
||REMK|Int32||XmlEnum("""REMK""")|18|
||REDO|Int32||XmlEnum("""REDO""")|19|
||BPUT|Int32||XmlEnum("""BPUT""")|20|
||PRIO|Int32||XmlEnum("""PRIO""")|21|
||PDEF|Int32||XmlEnum("""PDEF""")|22|
||PLAC|Int32||XmlEnum("""PLAC""")|23|
||PINK|Int32||XmlEnum("""PINK""")|24|
||PRED|Int32||XmlEnum("""PRED""")|25|
||PCAL|Int32||XmlEnum("""PCAL""")|26|
||PARI|Int32||XmlEnum("""PARI""")|27|
||OTHR|Int32||XmlEnum("""OTHR""")|28|
||ODLT|Int32||XmlEnum("""ODLT""")|29|
||CERT|Int32||XmlEnum("""CERT""")|30|
||NOOF|Int32||XmlEnum("""NOOF""")|31|
||MRGR|Int32||XmlEnum("""MRGR""")|32|
||EXTM|Int32||XmlEnum("""EXTM""")|33|
||LIQU|Int32||XmlEnum("""LIQU""")|34|
||RHDI|Int32||XmlEnum("""RHDI""")|35|
||INTR|Int32||XmlEnum("""INTR""")|36|
||PPMT|Int32||XmlEnum("""PPMT""")|37|
||INCR|Int32||XmlEnum("""INCR""")|38|
||MCAL|Int32||XmlEnum("""MCAL""")|39|
||REDM|Int32||XmlEnum("""REDM""")|40|
||EXOF|Int32||XmlEnum("""EXOF""")|41|
||DTCH|Int32||XmlEnum("""DTCH""")|42|
||DRAW|Int32||XmlEnum("""DRAW""")|43|
||DRIP|Int32||XmlEnum("""DRIP""")|44|
||DVOP|Int32||XmlEnum("""DVOP""")|45|
||DSCL|Int32||XmlEnum("""DSCL""")|46|
||DETI|Int32||XmlEnum("""DETI""")|47|
||DECR|Int32||XmlEnum("""DECR""")|48|
||CREV|Int32||XmlEnum("""CREV""")|49|
||CONV|Int32||XmlEnum("""CONV""")|50|
||CONS|Int32||XmlEnum("""CONS""")|51|
||CLSA|Int32||XmlEnum("""CLSA""")|52|
||COOP|Int32||XmlEnum("""COOP""")|53|
||CHAN|Int32||XmlEnum("""CHAN""")|54|
||DVCA|Int32||XmlEnum("""DVCA""")|55|
||DRCA|Int32||XmlEnum("""DRCA""")|56|
||CAPI|Int32||XmlEnum("""CAPI""")|57|
||CAPG|Int32||XmlEnum("""CAPG""")|58|
||CAPD|Int32||XmlEnum("""CAPD""")|59|
||EXRI|Int32||XmlEnum("""EXRI""")|60|
||BONU|Int32||XmlEnum("""BONU""")|61|
||DFLT|Int32||XmlEnum("""DFLT""")|62|
||BRUP|Int32||XmlEnum("""BRUP""")|63|
||ATTI|Int32||XmlEnum("""ATTI""")|64|
||ACTV|Int32||XmlEnum("""ACTV""")|65|

---

## Value ISO20022.Seev033002.CorporateActionGeneralInformation189


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UndrlygScty|ISO20022.Seev033002.FinancialInstrumentAttributes133||XmlElement()||
|+|EvtTp|ISO20022.Seev033002.CorporateActionEventType119Choice||XmlElement()||
|+|OffclCorpActnEvtId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UndrlygScty),validElement(EvtTp),validPattern("""OffclCorpActnEvtId""",OffclCorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""CorpActnEvtId""",CorpActnEvtId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Aspect ISO20022.Seev033002.CorporateActionInstruction002V13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev033002.SupplementaryData1>||XmlElement()||
|+|AddtlInf|ISO20022.Seev033002.CorporateActionNarrative34||XmlElement()||
|+|PrtctInstr|ISO20022.Seev033002.ProtectInstruction5||XmlElement()||
|+|CorpActnInstr|ISO20022.Seev033002.CorporateActionOption243||XmlElement()||
|+|BnfclOwnrDtls|global::System.Collections.Generic.List<ISO20022.Seev033002.PartyIdentification317>||XmlElement()||
|+|AcctDtls|ISO20022.Seev033002.AccountAndBalance62||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev033002.CorporateActionGeneralInformation189||XmlElement()||
|+|EvtsLkg|global::System.Collections.Generic.List<ISO20022.Seev033002.CorporateActionEventReference4>||XmlElement()||
|+|OthrDocId|global::System.Collections.Generic.List<ISO20022.Seev033002.DocumentIdentification38>||XmlElement()||
|+|InstrCxlReqId|ISO20022.Seev033002.DocumentIdentification37||XmlElement()||
|+|CancInstrId|ISO20022.Seev033002.DocumentIdentification37||XmlElement()||
|+|ChngInstrInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AddtlInf),validElement(PrtctInstr),validElement(CorpActnInstr),validList("""BnfclOwnrDtls""",BnfclOwnrDtls),validElement(BnfclOwnrDtls),validElement(AcctDtls),validElement(CorpActnGnlInf),validList("""EvtsLkg""",EvtsLkg),validElement(EvtsLkg),validList("""OthrDocId""",OthrDocId),validElement(OthrDocId),validElement(InstrCxlReqId),validElement(CancInstrId))|

---

## Value ISO20022.Seev033002.CorporateActionNarrative33


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrAddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|FXInstrsAddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|DlvryDtls|global::System.Collections.Generic.List<String>||XmlElement()||
|+|InfToCmplyWth|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""InstrAddtlInf""",InstrAddtlInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""FXInstrsAddtlInf""",FXInstrsAddtlInf,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""DlvryDtls""",DlvryDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""InfToCmplyWth""",InfToCmplyWth,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Value ISO20022.Seev033002.CorporateActionNarrative34


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertfctnBrkdwn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PtyCtctNrrtv|global::System.Collections.Generic.List<String>||XmlElement()||
|+|RegnDtls|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CertfctnBrkdwn""",CertfctnBrkdwn,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""PtyCtctNrrtv""",PtyCtctNrrtv,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validPattern("""RegnDtls""",RegnDtls,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""))|

---

## Enum ISO20022.Seev033002.CorporateActionOption16Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||BOBD|Int32||XmlEnum("""BOBD""")|1|
||PRUN|Int32||XmlEnum("""PRUN""")|2|
||TAXI|Int32||XmlEnum("""TAXI""")|3|
||SLLE|Int32||XmlEnum("""SLLE""")|4|
||SECU|Int32||XmlEnum("""SECU""")|5|
||QINV|Int32||XmlEnum("""QINV""")|6|
||OVER|Int32||XmlEnum("""OVER""")|7|
||OTHR|Int32||XmlEnum("""OTHR""")|8|
||OFFR|Int32||XmlEnum("""OFFR""")|9|
||NOQU|Int32||XmlEnum("""NOQU""")|10|
||NOAC|Int32||XmlEnum("""NOAC""")|11|
||MPUT|Int32||XmlEnum("""MPUT""")|12|
||MKUP|Int32||XmlEnum("""MKUP""")|13|
||MKDW|Int32||XmlEnum("""MKDW""")|14|
||LAPS|Int32||XmlEnum("""LAPS""")|15|
||EXER|Int32||XmlEnum("""EXER""")|16|
||CTEN|Int32||XmlEnum("""CTEN""")|17|
||CONY|Int32||XmlEnum("""CONY""")|18|
||CONN|Int32||XmlEnum("""CONN""")|19|
||CEXC|Int32||XmlEnum("""CEXC""")|20|
||CERT|Int32||XmlEnum("""CERT""")|21|
||CASH|Int32||XmlEnum("""CASH""")|22|
||CASE|Int32||XmlEnum("""CASE""")|23|
||BUYA|Int32||XmlEnum("""BUYA""")|24|
||BSPL|Int32||XmlEnum("""BSPL""")|25|
||ABST|Int32||XmlEnum("""ABST""")|26|

---

## Value ISO20022.Seev033002.CorporateActionOption243


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Seev033002.CorporateActionNarrative33||XmlElement()||
|+|ShrhldrNb|String||XmlElement()||
|+|PricDtls|ISO20022.Seev033002.CorporateActionPrice91||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev033002.CorporateActionRate130||XmlElement()||
|+|ExctnReqdDtTm|ISO20022.Seev033002.DateAndDateTime2Choice||XmlElement()||
|+|SctiesQtyOrInstdAmt|ISO20022.Seev033002.SecuritiesQuantityOrAmount7Choice||XmlElement()||
|+|SctyId|ISO20022.Seev033002.SecurityIdentification20||XmlElement()||
|+|CcyOptn|String||XmlElement()||
|+|CcyToSell|String||XmlElement()||
|+|CcyToBuy|String||XmlElement()||
|+|SlctnDealrFeeInd|String||XmlElement()||
|+|ElgblForCollInd|String||XmlElement()||
|+|ChngTp|global::System.Collections.Generic.List<ISO20022.Seev033002.CorporateActionChangeTypeFormat7Choice>||XmlElement()||
|+|FrctnDspstn|ISO20022.Seev033002.FractionDispositionType29Choice||XmlElement()||
|+|OptnFeatrs|ISO20022.Seev033002.OptionFeaturesFormat27Choice||XmlElement()||
|+|OptnTp|ISO20022.Seev033002.CorporateActionOption43Choice||XmlElement()||
|+|OptnNb|ISO20022.Seev033002.OptionNumber1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validPattern("""ShrhldrNb""",ShrhldrNb,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(PricDtls),validElement(RateAndAmtDtls),validElement(ExctnReqdDtTm),validElement(SctiesQtyOrInstdAmt),validElement(SctyId),validPattern("""CcyOptn""",CcyOptn,"""[A-Z]{3,3}"""),validPattern("""CcyToSell""",CcyToSell,"""[A-Z]{3,3}"""),validPattern("""CcyToBuy""",CcyToBuy,"""[A-Z]{3,3}"""),validList("""ChngTp""",ChngTp),validElement(ChngTp),validElement(FrctnDspstn),validElement(OptnFeatrs),validElement(OptnTp),validElement(OptnNb))|

---

## Value ISO20022.Seev033002.CorporateActionOption43Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033002.CorporateActionPrice91


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GncCshPricPdPerPdct|ISO20022.Seev033002.PriceFormat83Choice||XmlElement()||
|+|GncCshPricRcvdPerPdct|ISO20022.Seev033002.PriceFormat84Choice||XmlElement()||
|+|IssePric|ISO20022.Seev033002.PriceFormat83Choice||XmlElement()||
|+|IndctvOrMktPric|ISO20022.Seev033002.IndicativeOrMarketPrice15Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GncCshPricPdPerPdct),validElement(GncCshPricRcvdPerPdct),validElement(IssePric),validElement(IndctvOrMktPric))|

---

## Value ISO20022.Seev033002.CorporateActionRate130


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ReqdScndLvlTaxRate|global::System.Collections.Generic.List<ISO20022.Seev033002.RateAndAmountFormat65Choice>||XmlElement()||
|+|ReqdWhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev033002.RateAndAmountFormat65Choice>||XmlElement()||
|+|OvrsbcptRate|ISO20022.Seev033002.RateAndAmountFormat64Choice||XmlElement()||
|+|PropsdRate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""ReqdScndLvlTaxRate""",ReqdScndLvlTaxRate),validElement(ReqdScndLvlTaxRate),validList("""ReqdWhldgTaxRate""",ReqdWhldgTaxRate),validElement(ReqdWhldgTaxRate),validElement(OvrsbcptRate))|

---

## Value ISO20022.Seev033002.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Type ISO20022.Seev033002.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnInstr|ISO20022.Seev033002.CorporateActionInstruction002V13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnInstr))|

---

## Value ISO20022.Seev033002.DocumentIdentification37


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev033002.ProcessingPosition10Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev033002.DocumentIdentification38


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev033002.ProcessingPosition10Choice||XmlElement()||
|+|DocNb|ISO20022.Seev033002.DocumentNumber6Choice||XmlElement()||
|+|Id|ISO20022.Seev033002.DocumentIdentification4Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(DocNb),validElement(Id))|

---

## Value ISO20022.Seev033002.DocumentIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOwnrDocId|String||XmlElement()||
|+|AcctSvcrDocId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""AcctOwnrDocId""",AcctOwnrDocId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""AcctSvcrDocId""",AcctSvcrDocId,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validChoice(AcctOwnrDocId,AcctSvcrDocId))|

---

## Value ISO20022.Seev033002.DocumentNumber6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Seev033002.GenericIdentification86||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Value ISO20022.Seev033002.FinancialInstrumentAttributes133


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrctSz|ISO20022.Seev033002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Seev033002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|NxtIntrstRate|Decimal||XmlElement()||
|+|IntrstRate|Decimal||XmlElement()||
|+|NxtFctr|Decimal||XmlElement()||
|+|PrvsFctr|Decimal||XmlElement()||
|+|ConvsDt|DateTime||XmlElement()||
|+|DtdDt|DateTime||XmlElement()||
|+|PutblDt|DateTime||XmlElement()||
|+|NxtCllblDt|DateTime||XmlElement()||
|+|IsseDt|DateTime||XmlElement()||
|+|MtrtyDt|DateTime||XmlElement()||
|+|FltgRateFxgDt|DateTime||XmlElement()||
|+|XpryDt|DateTime||XmlElement()||
|+|NxtCpnDt|DateTime||XmlElement()||
|+|DnmtnCcy|String||XmlElement()||
|+|ClssfctnTp|ISO20022.Seev033002.ClassificationType33Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Seev033002.InterestComputationMethodFormat5Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Seev033002.MarketIdentification4Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Seev033002.SecurityIdentification20||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrctSz),validElement(MinNmnlQty),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(ClssfctnTp),validElement(DayCntBsis),validElement(PlcOfListg),validElement(FinInstrmId))|

---

## Value ISO20022.Seev033002.FinancialInstrumentQuantity36Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Enum ISO20022.Seev033002.FractionDispositionType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIST|Int32||XmlEnum("""DIST""")|1|
||EXPI|Int32||XmlEnum("""EXPI""")|2|
||CINL|Int32||XmlEnum("""CINL""")|3|
||BUYU|Int32||XmlEnum("""BUYU""")|4|

---

## Value ISO20022.Seev033002.FractionDispositionType29Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033002.GenericIdentification47


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev033002.GenericIdentification84


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev033002.GenericIdentification85


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Seev033002.GenericIdentification47||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validElement(Tp))|

---

## Value ISO20022.Seev033002.GenericIdentification86


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev033002.IdentificationSource4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Prtry""",Prtry,"""XX\|TS"""),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033002.IdentificationType44Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033002.IdentificationType46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033002.IndicativeOrMarketPrice15Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktPric|ISO20022.Seev033002.PriceFormat83Choice||XmlElement()||
|+|IndctvPric|ISO20022.Seev033002.PriceFormat83Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktPric),validElement(IndctvPric),validChoice(MktPric,IndctvPric))|

---

## Enum ISO20022.Seev033002.InterestComputationMethod2Code


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

## Value ISO20022.Seev033002.InterestComputationMethodFormat5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033002.MarketIdentification4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""),validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Seev033002.NameAndAddress12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nm""",Nm,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""))|

---

## Enum ISO20022.Seev033002.OptionFeatures12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPLF|Int32||XmlEnum("""OPLF""")|1|

---

## Value ISO20022.Seev033002.OptionFeaturesFormat27Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033002.OptionNumber1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nb""",Nb,"""[0-9]{3}"""),validChoice(Cd,Nb))|

---

## Enum ISO20022.Seev033002.OptionNumber1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNSO|Int32||XmlEnum("""UNSO""")|1|

---

## Value ISO20022.Seev033002.OriginalAndCurrentQuantities4


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev033002.OriginalAndCurrentQuantities7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev033002.OtherIdentification2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev033002.IdentificationSource4Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp),validPattern("""Id""",Id,"""[0-9a-zA-Z/\-\?:\(\)\.,'\+ ]{1,31}"""))|

---

## Value ISO20022.Seev033002.PartyIdentification136Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev033002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Seev033002.PartyIdentification259Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndvOwnrId|ISO20022.Seev033002.AlternatePartyIdentification11||XmlElement()||
|+|NmAndAdr|ISO20022.Seev033002.NameAndAddress12||XmlElement()||
|+|PrtryId|ISO20022.Seev033002.GenericIdentification84||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IndvOwnrId),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(IndvOwnrId,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Seev033002.PartyIdentification317


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertfctnBrkdwn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|WhldgTaxRate|ISO20022.Seev033002.RateAndAmountFormat63Choice||XmlElement()||
|+|CertfctnTp|global::System.Collections.Generic.List<ISO20022.Seev033002.BeneficiaryCertificationType11Choice>||XmlElement()||
|+|OwndSctiesQty|ISO20022.Seev033002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|NonDmclCtry|global::System.Collections.Generic.List<String>||XmlElement()||
|+|DmclCtry|String||XmlElement()||
|+|AltrnId|global::System.Collections.Generic.List<ISO20022.Seev033002.AlternatePartyIdentification9>||XmlElement()||
|+|LEIId|String||XmlElement()||
|+|OwnrId|ISO20022.Seev033002.PartyIdentification259Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""CertfctnBrkdwn""",CertfctnBrkdwn,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,350}"""),validElement(WhldgTaxRate),validList("""CertfctnTp""",CertfctnTp),validElement(CertfctnTp),validElement(OwndSctiesQty),validPattern("""NonDmclCtry""",NonDmclCtry,"""[A-Z]{2,2}"""),validPattern("""DmclCtry""",DmclCtry,"""[A-Z]{2,2}"""),validList("""AltrnId""",AltrnId),validElement(AltrnId),validPattern("""LEIId""",LEIId,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(OwnrId))|

---

## Value ISO20022.Seev033002.PercentagePrice2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|Decimal||XmlElement()||
|+|PctgPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev033002.PriceFormat83Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtPric|ISO20022.Seev033002.AmountPrice5||XmlElement()||
|+|PctgPric|ISO20022.Seev033002.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validElement(PctgPric),validChoice(AmtPric,PctgPric))|

---

## Value ISO20022.Seev033002.PriceFormat84Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|AmtPricPerAmt|ISO20022.Seev033002.AmountPricePerAmount3||XmlElement()||
|+|AmtPricPerFinInstrmQty|ISO20022.Seev033002.AmountPricePerFinancialInstrumentQuantity11||XmlElement()||
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev033002.AmountPrice5||XmlElement()||
|+|PctgPric|ISO20022.Seev033002.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPricPerAmt),validElement(AmtPricPerFinInstrmQty),validElement(AmtPric),validElement(PctgPric),validChoice(IndxPts,AmtPricPerAmt,AmtPricPerFinInstrmQty,NotSpcfdPric,AmtPric,PctgPric))|

---

## Enum ISO20022.Seev033002.PriceRateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YIEL|Int32||XmlEnum("""YIEL""")|1|
||PRCT|Int32||XmlEnum("""PRCT""")|2|
||PREM|Int32||XmlEnum("""PREM""")|3|
||DISC|Int32||XmlEnum("""DISC""")|4|

---

## Enum ISO20022.Seev033002.PriceValueType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||UNSP|Int32||XmlEnum("""UNSP""")|2|
||TBSP|Int32||XmlEnum("""TBSP""")|3|

---

## Value ISO20022.Seev033002.ProcessingPosition10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev033002.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Seev033002.ProprietaryQuantity10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev033002.ProprietaryQuantity9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""SchmeNm""",SchmeNm,"""[a-zA-Z0-9]{1,4}"""),validPattern("""Issr""",Issr,"""[a-zA-Z0-9]{1,4}"""),validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev033002.ProtectInstruction5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtctDt|DateTime||XmlElement()||
|+|PrtctSfkpgAcct|String||XmlElement()||
|+|TxId|String||XmlElement()||
|+|TxTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""PrtctSfkpgAcct""",PrtctSfkpgAcct,"""([^/]+/)+([^/]+)\|([^/]*)"""))|

---

## Enum ISO20022.Seev033002.ProtectTransactionType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COVR|Int32||XmlEnum("""COVR""")|1|
||COVP|Int32||XmlEnum("""COVP""")|2|
||PROT|Int32||XmlEnum("""PROT""")|3|

---

## Enum ISO20022.Seev033002.Quantity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||QALL|Int32||XmlEnum("""QALL""")|1|

---

## Value ISO20022.Seev033002.Quantity53Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev033002.ProprietaryQuantity9||XmlElement()||
|+|Qty|ISO20022.Seev033002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(Qty),validChoice(PrtryQty,Qty))|

---

## Value ISO20022.Seev033002.Quantity55Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Seev033002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|OrgnlAndCurFaceAmt|ISO20022.Seev033002.OriginalAndCurrentQuantities4||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty),validElement(OrgnlAndCurFaceAmt),validChoice(Qty,OrgnlAndCurFaceAmt,Cd))|

---

## Value ISO20022.Seev033002.Quantity57Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SgndQty|ISO20022.Seev033002.SignedQuantityFormat13||XmlElement()||
|+|OrgnlAndCurFaceAmt|ISO20022.Seev033002.OriginalAndCurrentQuantities7||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgndQty),validElement(OrgnlAndCurFaceAmt),validChoice(SgndQty,OrgnlAndCurFaceAmt))|

---

## Value ISO20022.Seev033002.Quantity80Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev033002.ProprietaryQuantity10||XmlElement()||
|+|QtyChc|ISO20022.Seev033002.Quantity57Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(QtyChc),validChoice(PrtryQty,QtyChc))|

---

## Value ISO20022.Seev033002.RateAndAmountFormat63Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev033002.RateAndAmountFormat64Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Seev033002.RateAndAmountFormat65Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndRate|ISO20022.Seev033002.RateTypeAndPercentageRate15||XmlElement()||
|+|Amt|ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndRate),validElement(Amt),validChoice(RateTpAndRate,Amt,Rate))|

---

## Value ISO20022.Seev033002.RateType46Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033002.GenericIdentification47||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033002.RateTypeAndPercentageRate15


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev033002.RateType46Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Enum ISO20022.Seev033002.RateValueType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Value ISO20022.Seev033002.RestrictedFINActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev033002.RestrictedFINActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev033002.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Seev033002.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Value ISO20022.Seev033002.SafekeepingPlaceFormat48Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033002.GenericIdentification85||XmlElement()||
|+|TpAndId|ISO20022.Seev033002.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev033002.SafekeepingPlaceTypeAndText9||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev033002.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Seev033002.SafekeepingPlaceTypeAndText9


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""([0-9a-zA-Z\-\?:\(\)\.,'\+ ]([0-9a-zA-Z\-\?:\(\)\.,'\+ ]*(/[0-9a-zA-Z\-\?:\(\)\.,'\+ ])?)*)"""))|

---

## Value ISO20022.Seev033002.SecuritiesOption88


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRndUpQty|ISO20022.Seev033002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|InstdQty|ISO20022.Seev033002.Quantity55Choice||XmlElement()||
|+|CondlQty|ISO20022.Seev033002.FinancialInstrumentQuantity36Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlRndUpQty),validElement(InstdQty),validElement(CondlQty))|

---

## Value ISO20022.Seev033002.SecuritiesQuantityOrAmount7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstdAmt|ISO20022.Seev033002.RestrictedFINActiveCurrencyAndAmount||XmlElement()||
|+|SctiesQty|ISO20022.Seev033002.SecuritiesOption88||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstdAmt),validElement(SctiesQty),validChoice(InstdAmt,SctiesQty))|

---

## Value ISO20022.Seev033002.SecurityIdentification20


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev033002.OtherIdentification2>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Desc""",Desc,"""[0-9a-zA-Z/\-\?:\(\)\.\n\r,'\+ ]{1,140}"""),validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Seev033002.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Seev033002.SignedQuantityFormat12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyChc|ISO20022.Seev033002.Quantity53Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyChc))|

---

## Value ISO20022.Seev033002.SignedQuantityFormat13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Seev033002.FinancialInstrumentQuantity36Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Seev033002.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev033002.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev033002.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev033002.TypeOfIdentification1Code


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

## Enum ISO20022.Seev033002.WithholdingTaxRateType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||NRAT|Int32||XmlEnum("""NRAT""")|1|
||FTCA|Int32||XmlEnum("""FTCA""")|2|
||BWIT|Int32||XmlEnum("""BWIT""")|3|

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

