# seev.033.001.13
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class ISO20022.Seev033001.AccountAndBalance61 {
        + Bal  : ISO20022.Seev033001.CorporateActionBalanceDetails42
        + SfkpgPlc  : ISO20022.Seev033001.SafekeepingPlaceFormat42Choice
        + AcctOwnr  : ISO20022.Seev033001.PartyIdentification127Choice
        + BlckChainAdrOrWllt  : String
        + SfkpgAcct  : String
    }
    ISO20022.Seev033001.AccountAndBalance61 *-- ISO20022.Seev033001.CorporateActionBalanceDetails42
    ISO20022.Seev033001.AccountAndBalance61 *-- ISO20022.Seev033001.SafekeepingPlaceFormat42Choice
    ISO20022.Seev033001.AccountAndBalance61 *-- ISO20022.Seev033001.PartyIdentification127Choice
    class ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev033001.ActiveCurrencyAndAmount {
        + Value  : Decimal
        + Ccy  : String
    }
    class ISO20022.Seev033001.AddressType2Code {
        DLVY = 1
        MLTO = 2
        BIZZ = 3
        HOME = 4
        PBOX = 5
        ADDR = 6
    }
    class ISO20022.Seev033001.AlternatePartyIdentification7 {
        + AltrnId  : String
        + Ctry  : String
        + IdTp  : ISO20022.Seev033001.IdentificationType42Choice
    }
    ISO20022.Seev033001.AlternatePartyIdentification7 *-- ISO20022.Seev033001.IdentificationType42Choice
    class ISO20022.Seev033001.AmountPrice3 {
        + PricVal  : ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev033001.AmountPrice3 *-- ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev033001.AmountPricePerAmount2 {
        + Amt  : ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount
        + PricVal  : ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev033001.AmountPricePerAmount2 *-- ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount
    ISO20022.Seev033001.AmountPricePerAmount2 *-- ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev033001.AmountPricePerFinancialInstrumentQuantity10 {
        + FinInstrmQty  : ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
        + PricVal  : ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount
        + AmtPricTp  : String
    }
    ISO20022.Seev033001.AmountPricePerFinancialInstrumentQuantity10 *-- ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev033001.AmountPricePerFinancialInstrumentQuantity10 *-- ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev033001.AmountPriceType1Code {
        PREM = 1
        PLOT = 2
        DISC = 3
        ACTU = 4
    }
    class ISO20022.Seev033001.BalanceFormat11Choice {
        + NotElgblBal  : ISO20022.Seev033001.SignedQuantityFormat10
        + ElgblBal  : ISO20022.Seev033001.SignedQuantityFormat10
        + Bal  : ISO20022.Seev033001.SignedQuantityFormat11
    }
    ISO20022.Seev033001.BalanceFormat11Choice *-- ISO20022.Seev033001.SignedQuantityFormat10
    ISO20022.Seev033001.BalanceFormat11Choice *-- ISO20022.Seev033001.SignedQuantityFormat10
    ISO20022.Seev033001.BalanceFormat11Choice *-- ISO20022.Seev033001.SignedQuantityFormat11
    class ISO20022.Seev033001.BeneficiaryCertificationType10Choice {
        + Prtry  : ISO20022.Seev033001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev033001.BeneficiaryCertificationType10Choice *-- ISO20022.Seev033001.GenericIdentification30
    class ISO20022.Seev033001.BeneficiaryCertificationType5Code {
        QIBB = 1
        NCOM = 2
        ACCI = 3
    }
    class ISO20022.Seev033001.ClassificationType32Choice {
        + AltrnClssfctn  : ISO20022.Seev033001.GenericIdentification36
        + ClssfctnFinInstrm  : String
    }
    ISO20022.Seev033001.ClassificationType32Choice *-- ISO20022.Seev033001.GenericIdentification36
    class ISO20022.Seev033001.CorporateActionBalanceDetails42 {
        + RegdBal  : ISO20022.Seev033001.BalanceFormat11Choice
        + InTrnsShipmntBal  : ISO20022.Seev033001.BalanceFormat11Choice
        + TradDtPosBal  : ISO20022.Seev033001.BalanceFormat11Choice
        + StrtPosBal  : ISO20022.Seev033001.BalanceFormat11Choice
        + SttlmPosBal  : ISO20022.Seev033001.BalanceFormat11Choice
        + OutForRegnBal  : ISO20022.Seev033001.BalanceFormat11Choice
        + PdgRctBal  : global::System.Collections.Generic.List~ISO20022.Seev033001.BalanceFormat11Choice~
        + PdgDlvryBal  : global::System.Collections.Generic.List~ISO20022.Seev033001.BalanceFormat11Choice~
        + OnLnBal  : ISO20022.Seev033001.BalanceFormat11Choice
        + CollOutBal  : ISO20022.Seev033001.BalanceFormat11Choice
        + CollInBal  : ISO20022.Seev033001.BalanceFormat11Choice
        + BrrwdBal  : ISO20022.Seev033001.BalanceFormat11Choice
        + BlckdBal  : ISO20022.Seev033001.BalanceFormat11Choice
        + TtlElgblBal  : ISO20022.Seev033001.Quantity49Choice
    }
    ISO20022.Seev033001.CorporateActionBalanceDetails42 *-- ISO20022.Seev033001.BalanceFormat11Choice
    ISO20022.Seev033001.CorporateActionBalanceDetails42 *-- ISO20022.Seev033001.BalanceFormat11Choice
    ISO20022.Seev033001.CorporateActionBalanceDetails42 *-- ISO20022.Seev033001.BalanceFormat11Choice
    ISO20022.Seev033001.CorporateActionBalanceDetails42 *-- ISO20022.Seev033001.BalanceFormat11Choice
    ISO20022.Seev033001.CorporateActionBalanceDetails42 *-- ISO20022.Seev033001.BalanceFormat11Choice
    ISO20022.Seev033001.CorporateActionBalanceDetails42 *-- ISO20022.Seev033001.BalanceFormat11Choice
    ISO20022.Seev033001.CorporateActionBalanceDetails42 *-- ISO20022.Seev033001.BalanceFormat11Choice
    ISO20022.Seev033001.CorporateActionBalanceDetails42 *-- ISO20022.Seev033001.BalanceFormat11Choice
    ISO20022.Seev033001.CorporateActionBalanceDetails42 *-- ISO20022.Seev033001.BalanceFormat11Choice
    ISO20022.Seev033001.CorporateActionBalanceDetails42 *-- ISO20022.Seev033001.BalanceFormat11Choice
    ISO20022.Seev033001.CorporateActionBalanceDetails42 *-- ISO20022.Seev033001.BalanceFormat11Choice
    ISO20022.Seev033001.CorporateActionBalanceDetails42 *-- ISO20022.Seev033001.BalanceFormat11Choice
    ISO20022.Seev033001.CorporateActionBalanceDetails42 *-- ISO20022.Seev033001.BalanceFormat11Choice
    ISO20022.Seev033001.CorporateActionBalanceDetails42 *-- ISO20022.Seev033001.Quantity49Choice
    class ISO20022.Seev033001.CorporateActionChangeType2Code {
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
    class ISO20022.Seev033001.CorporateActionChangeTypeFormat6Choice {
        + Prtry  : ISO20022.Seev033001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev033001.CorporateActionChangeTypeFormat6Choice *-- ISO20022.Seev033001.GenericIdentification30
    class ISO20022.Seev033001.CorporateActionEventReference3 {
        + LkgTp  : ISO20022.Seev033001.ProcessingPosition7Choice
        + EvtId  : ISO20022.Seev033001.CorporateActionEventReference3Choice
    }
    ISO20022.Seev033001.CorporateActionEventReference3 *-- ISO20022.Seev033001.ProcessingPosition7Choice
    ISO20022.Seev033001.CorporateActionEventReference3 *-- ISO20022.Seev033001.CorporateActionEventReference3Choice
    class ISO20022.Seev033001.CorporateActionEventReference3Choice {
        + LkdCorpActnId  : String
        + LkdOffclCorpActnEvtId  : String
    }
    class ISO20022.Seev033001.CorporateActionEventType112Choice {
        + Prtry  : ISO20022.Seev033001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev033001.CorporateActionEventType112Choice *-- ISO20022.Seev033001.GenericIdentification30
    class ISO20022.Seev033001.CorporateActionEventType40Code {
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
    class ISO20022.Seev033001.CorporateActionGeneralInformation180 {
        + UndrlygScty  : ISO20022.Seev033001.FinancialInstrumentAttributes132
        + EvtTp  : ISO20022.Seev033001.CorporateActionEventType112Choice
        + OffclCorpActnEvtId  : String
        + CorpActnEvtId  : String
    }
    ISO20022.Seev033001.CorporateActionGeneralInformation180 *-- ISO20022.Seev033001.FinancialInstrumentAttributes132
    ISO20022.Seev033001.CorporateActionGeneralInformation180 *-- ISO20022.Seev033001.CorporateActionEventType112Choice
    class ISO20022.Seev033001.CorporateActionInstructionV13 {
        + SplmtryData  : global::System.Collections.Generic.List~ISO20022.Seev033001.SupplementaryData1~
        + AddtlInf  : ISO20022.Seev033001.CorporateActionNarrative30
        + PrtctInstr  : ISO20022.Seev033001.ProtectInstruction1
        + CorpActnInstr  : ISO20022.Seev033001.CorporateActionOption237
        + BnfclOwnrDtls  : global::System.Collections.Generic.List~ISO20022.Seev033001.PartyIdentification313~
        + AcctDtls  : ISO20022.Seev033001.AccountAndBalance61
        + CorpActnGnlInf  : ISO20022.Seev033001.CorporateActionGeneralInformation180
        + EvtsLkg  : global::System.Collections.Generic.List~ISO20022.Seev033001.CorporateActionEventReference3~
        + OthrDocId  : global::System.Collections.Generic.List~ISO20022.Seev033001.DocumentIdentification32~
        + InstrCxlReqId  : ISO20022.Seev033001.DocumentIdentification31
        + CancInstrId  : ISO20022.Seev033001.DocumentIdentification31
        + ChngInstrInd  : String
    }
    ISO20022.Seev033001.CorporateActionInstructionV13 *-- ISO20022.Seev033001.SupplementaryData1
    ISO20022.Seev033001.CorporateActionInstructionV13 *-- ISO20022.Seev033001.CorporateActionNarrative30
    ISO20022.Seev033001.CorporateActionInstructionV13 *-- ISO20022.Seev033001.ProtectInstruction1
    ISO20022.Seev033001.CorporateActionInstructionV13 *-- ISO20022.Seev033001.CorporateActionOption237
    ISO20022.Seev033001.CorporateActionInstructionV13 *-- ISO20022.Seev033001.PartyIdentification313
    ISO20022.Seev033001.CorporateActionInstructionV13 *-- ISO20022.Seev033001.AccountAndBalance61
    ISO20022.Seev033001.CorporateActionInstructionV13 *-- ISO20022.Seev033001.CorporateActionGeneralInformation180
    ISO20022.Seev033001.CorporateActionInstructionV13 *-- ISO20022.Seev033001.CorporateActionEventReference3
    ISO20022.Seev033001.CorporateActionInstructionV13 *-- ISO20022.Seev033001.DocumentIdentification32
    ISO20022.Seev033001.CorporateActionInstructionV13 *-- ISO20022.Seev033001.DocumentIdentification31
    ISO20022.Seev033001.CorporateActionInstructionV13 *-- ISO20022.Seev033001.DocumentIdentification31
    class ISO20022.Seev033001.CorporateActionNarrative30 {
        + CertfctnBrkdwn  : global::System.Collections.Generic.List~String~
        + PtyCtctNrrtv  : global::System.Collections.Generic.List~String~
        + RegnDtls  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Seev033001.CorporateActionNarrative32 {
        + InstrAddtlInf  : global::System.Collections.Generic.List~String~
        + FXInstrsAddtlInf  : global::System.Collections.Generic.List~String~
        + DlvryDtls  : global::System.Collections.Generic.List~String~
        + InfToCmplyWth  : global::System.Collections.Generic.List~String~
    }
    class ISO20022.Seev033001.CorporateActionOption16Code {
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
    class ISO20022.Seev033001.CorporateActionOption237 {
        + AddtlInf  : ISO20022.Seev033001.CorporateActionNarrative32
        + ShrhldrNb  : String
        + PricDtls  : ISO20022.Seev033001.CorporateActionPrice88
        + RateAndAmtDtls  : ISO20022.Seev033001.CorporateActionRate127
        + ExctnReqdDtTm  : ISO20022.Seev033001.DateAndDateTime2Choice
        + SctiesQtyOrInstdAmt  : ISO20022.Seev033001.SecuritiesQuantityOrAmount6Choice
        + SctyId  : ISO20022.Seev033001.SecurityIdentification19
        + CcyOptn  : String
        + CcyToSell  : String
        + CcyToBuy  : String
        + SlctnDealrFeeInd  : String
        + ElgblForCollInd  : String
        + ChngTp  : global::System.Collections.Generic.List~ISO20022.Seev033001.CorporateActionChangeTypeFormat6Choice~
        + FrctnDspstn  : ISO20022.Seev033001.FractionDispositionType28Choice
        + OptnFeatrs  : ISO20022.Seev033001.OptionFeaturesFormat25Choice
        + OptnTp  : ISO20022.Seev033001.CorporateActionOption40Choice
        + OptnNb  : ISO20022.Seev033001.OptionNumber1Choice
    }
    ISO20022.Seev033001.CorporateActionOption237 *-- ISO20022.Seev033001.CorporateActionNarrative32
    ISO20022.Seev033001.CorporateActionOption237 *-- ISO20022.Seev033001.CorporateActionPrice88
    ISO20022.Seev033001.CorporateActionOption237 *-- ISO20022.Seev033001.CorporateActionRate127
    ISO20022.Seev033001.CorporateActionOption237 *-- ISO20022.Seev033001.DateAndDateTime2Choice
    ISO20022.Seev033001.CorporateActionOption237 *-- ISO20022.Seev033001.SecuritiesQuantityOrAmount6Choice
    ISO20022.Seev033001.CorporateActionOption237 *-- ISO20022.Seev033001.SecurityIdentification19
    ISO20022.Seev033001.CorporateActionOption237 *-- ISO20022.Seev033001.CorporateActionChangeTypeFormat6Choice
    ISO20022.Seev033001.CorporateActionOption237 *-- ISO20022.Seev033001.FractionDispositionType28Choice
    ISO20022.Seev033001.CorporateActionOption237 *-- ISO20022.Seev033001.OptionFeaturesFormat25Choice
    ISO20022.Seev033001.CorporateActionOption237 *-- ISO20022.Seev033001.CorporateActionOption40Choice
    ISO20022.Seev033001.CorporateActionOption237 *-- ISO20022.Seev033001.OptionNumber1Choice
    class ISO20022.Seev033001.CorporateActionOption40Choice {
        + Prtry  : ISO20022.Seev033001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev033001.CorporateActionOption40Choice *-- ISO20022.Seev033001.GenericIdentification30
    class ISO20022.Seev033001.CorporateActionPrice88 {
        + GncCshPricPdPerPdct  : ISO20022.Seev033001.PriceFormat77Choice
        + GncCshPricRcvdPerPdct  : ISO20022.Seev033001.PriceFormat78Choice
        + IssePric  : ISO20022.Seev033001.PriceFormat77Choice
        + IndctvOrMktPric  : ISO20022.Seev033001.IndicativeOrMarketPrice13Choice
    }
    ISO20022.Seev033001.CorporateActionPrice88 *-- ISO20022.Seev033001.PriceFormat77Choice
    ISO20022.Seev033001.CorporateActionPrice88 *-- ISO20022.Seev033001.PriceFormat78Choice
    ISO20022.Seev033001.CorporateActionPrice88 *-- ISO20022.Seev033001.PriceFormat77Choice
    ISO20022.Seev033001.CorporateActionPrice88 *-- ISO20022.Seev033001.IndicativeOrMarketPrice13Choice
    class ISO20022.Seev033001.CorporateActionRate127 {
        + ReqdScndLvlTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev033001.RateAndAmountFormat55Choice~
        + ReqdWhldgTaxRate  : global::System.Collections.Generic.List~ISO20022.Seev033001.RateAndAmountFormat55Choice~
        + OvrsbcptRate  : ISO20022.Seev033001.RateAndAmountFormat59Choice
        + PropsdRate  : Decimal
    }
    ISO20022.Seev033001.CorporateActionRate127 *-- ISO20022.Seev033001.RateAndAmountFormat55Choice
    ISO20022.Seev033001.CorporateActionRate127 *-- ISO20022.Seev033001.RateAndAmountFormat55Choice
    ISO20022.Seev033001.CorporateActionRate127 *-- ISO20022.Seev033001.RateAndAmountFormat59Choice
    class ISO20022.Seev033001.DateAndDateTime2Choice {
        + DtTm  : DateTime
        + Dt  : DateTime
    }
    class ISO20022.Seev033001.DocumentIdentification31 {
        + LkgTp  : ISO20022.Seev033001.ProcessingPosition7Choice
        + Id  : String
    }
    ISO20022.Seev033001.DocumentIdentification31 *-- ISO20022.Seev033001.ProcessingPosition7Choice
    class ISO20022.Seev033001.DocumentIdentification32 {
        + LkgTp  : ISO20022.Seev033001.ProcessingPosition7Choice
        + DocNb  : ISO20022.Seev033001.DocumentNumber5Choice
        + Id  : ISO20022.Seev033001.DocumentIdentification3Choice
    }
    ISO20022.Seev033001.DocumentIdentification32 *-- ISO20022.Seev033001.ProcessingPosition7Choice
    ISO20022.Seev033001.DocumentIdentification32 *-- ISO20022.Seev033001.DocumentNumber5Choice
    ISO20022.Seev033001.DocumentIdentification32 *-- ISO20022.Seev033001.DocumentIdentification3Choice
    class ISO20022.Seev033001.DocumentIdentification3Choice {
        + AcctOwnrDocId  : String
        + AcctSvcrDocId  : String
    }
    class ISO20022.Seev033001.DocumentNumber5Choice {
        + PrtryNb  : ISO20022.Seev033001.GenericIdentification36
        + LngNb  : String
        + ShrtNb  : String
    }
    ISO20022.Seev033001.DocumentNumber5Choice *-- ISO20022.Seev033001.GenericIdentification36
    class ISO20022.Seev033001.FinancialInstrumentAttributes132 {
        + CtrctSz  : ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
        + MinNmnlQty  : ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
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
        + ClssfctnTp  : ISO20022.Seev033001.ClassificationType32Choice
        + DayCntBsis  : ISO20022.Seev033001.InterestComputationMethodFormat4Choice
        + PlcOfListg  : ISO20022.Seev033001.MarketIdentification3Choice
        + FinInstrmId  : ISO20022.Seev033001.SecurityIdentification19
    }
    ISO20022.Seev033001.FinancialInstrumentAttributes132 *-- ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev033001.FinancialInstrumentAttributes132 *-- ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev033001.FinancialInstrumentAttributes132 *-- ISO20022.Seev033001.ClassificationType32Choice
    ISO20022.Seev033001.FinancialInstrumentAttributes132 *-- ISO20022.Seev033001.InterestComputationMethodFormat4Choice
    ISO20022.Seev033001.FinancialInstrumentAttributes132 *-- ISO20022.Seev033001.MarketIdentification3Choice
    ISO20022.Seev033001.FinancialInstrumentAttributes132 *-- ISO20022.Seev033001.SecurityIdentification19
    class ISO20022.Seev033001.FinancialInstrumentQuantity33Choice {
        + DgtlTknUnit  : Decimal
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + Unit  : Decimal
    }
    class ISO20022.Seev033001.FractionDispositionType10Code {
        DIST = 1
        EXPI = 2
        CINL = 3
        BUYU = 4
    }
    class ISO20022.Seev033001.FractionDispositionType28Choice {
        + Prtry  : ISO20022.Seev033001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev033001.FractionDispositionType28Choice *-- ISO20022.Seev033001.GenericIdentification30
    class ISO20022.Seev033001.GenericIdentification30 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev033001.GenericIdentification36 {
        + SchmeNm  : String
        + Issr  : String
        + Id  : String
    }
    class ISO20022.Seev033001.GenericIdentification78 {
        + Id  : String
        + Tp  : ISO20022.Seev033001.GenericIdentification30
    }
    ISO20022.Seev033001.GenericIdentification78 *-- ISO20022.Seev033001.GenericIdentification30
    class ISO20022.Seev033001.IdentificationSource3Choice {
        + Prtry  : String
        + Cd  : String
    }
    class ISO20022.Seev033001.IdentificationType42Choice {
        + Prtry  : ISO20022.Seev033001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev033001.IdentificationType42Choice *-- ISO20022.Seev033001.GenericIdentification30
    class ISO20022.Seev033001.IndicativeOrMarketPrice13Choice {
        + MktPric  : ISO20022.Seev033001.PriceFormat77Choice
        + IndctvPric  : ISO20022.Seev033001.PriceFormat77Choice
    }
    ISO20022.Seev033001.IndicativeOrMarketPrice13Choice *-- ISO20022.Seev033001.PriceFormat77Choice
    ISO20022.Seev033001.IndicativeOrMarketPrice13Choice *-- ISO20022.Seev033001.PriceFormat77Choice
    class ISO20022.Seev033001.InterestComputationMethod2Code {
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
    class ISO20022.Seev033001.InterestComputationMethodFormat4Choice {
        + Prtry  : ISO20022.Seev033001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev033001.InterestComputationMethodFormat4Choice *-- ISO20022.Seev033001.GenericIdentification30
    class ISO20022.Seev033001.MarketIdentification3Choice {
        + Desc  : String
        + MktIdrCd  : String
    }
    class ISO20022.Seev033001.NameAndAddress5 {
        + Adr  : ISO20022.Seev033001.PostalAddress1
        + Nm  : String
    }
    ISO20022.Seev033001.NameAndAddress5 *-- ISO20022.Seev033001.PostalAddress1
    class ISO20022.Seev033001.OptionFeatures12Code {
        OPLF = 1
    }
    class ISO20022.Seev033001.OptionFeaturesFormat25Choice {
        + Prtry  : ISO20022.Seev033001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev033001.OptionFeaturesFormat25Choice *-- ISO20022.Seev033001.GenericIdentification30
    class ISO20022.Seev033001.OptionNumber1Choice {
        + Cd  : String
        + Nb  : String
    }
    class ISO20022.Seev033001.OptionNumber1Code {
        UNSO = 1
    }
    class ISO20022.Seev033001.OriginalAndCurrentQuantities1 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
    }
    class ISO20022.Seev033001.OriginalAndCurrentQuantities6 {
        + AmtsdVal  : Decimal
        + FaceAmt  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev033001.OtherIdentification1 {
        + Tp  : ISO20022.Seev033001.IdentificationSource3Choice
        + Sfx  : String
        + Id  : String
    }
    ISO20022.Seev033001.OtherIdentification1 *-- ISO20022.Seev033001.IdentificationSource3Choice
    class ISO20022.Seev033001.PartyIdentification127Choice {
        + PrtryId  : ISO20022.Seev033001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Seev033001.PartyIdentification127Choice *-- ISO20022.Seev033001.GenericIdentification36
    class ISO20022.Seev033001.PartyIdentification229Choice {
        + IndvOwnrId  : ISO20022.Seev033001.AlternatePartyIdentification7
        + NmAndAdr  : ISO20022.Seev033001.NameAndAddress5
        + PrtryId  : ISO20022.Seev033001.GenericIdentification36
        + AnyBIC  : String
    }
    ISO20022.Seev033001.PartyIdentification229Choice *-- ISO20022.Seev033001.AlternatePartyIdentification7
    ISO20022.Seev033001.PartyIdentification229Choice *-- ISO20022.Seev033001.NameAndAddress5
    ISO20022.Seev033001.PartyIdentification229Choice *-- ISO20022.Seev033001.GenericIdentification36
    class ISO20022.Seev033001.PartyIdentification313 {
        + CertfctnBrkdwn  : global::System.Collections.Generic.List~String~
        + WhldgTaxRate  : ISO20022.Seev033001.RateAndAmountFormat57Choice
        + CertfctnTp  : global::System.Collections.Generic.List~ISO20022.Seev033001.BeneficiaryCertificationType10Choice~
        + OwndSctiesQty  : ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
        + NonDmclCtry  : global::System.Collections.Generic.List~String~
        + DmclCtry  : String
        + AltrnId  : global::System.Collections.Generic.List~ISO20022.Seev033001.AlternatePartyIdentification7~
        + LEIId  : String
        + OwnrId  : ISO20022.Seev033001.PartyIdentification229Choice
    }
    ISO20022.Seev033001.PartyIdentification313 *-- ISO20022.Seev033001.RateAndAmountFormat57Choice
    ISO20022.Seev033001.PartyIdentification313 *-- ISO20022.Seev033001.BeneficiaryCertificationType10Choice
    ISO20022.Seev033001.PartyIdentification313 *-- ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev033001.PartyIdentification313 *-- ISO20022.Seev033001.AlternatePartyIdentification7
    ISO20022.Seev033001.PartyIdentification313 *-- ISO20022.Seev033001.PartyIdentification229Choice
    class ISO20022.Seev033001.PercentagePrice2 {
        + PricVal  : Decimal
        + PctgPricTp  : String
    }
    class ISO20022.Seev033001.PostalAddress1 {
        + Ctry  : String
        + CtrySubDvsn  : String
        + TwnNm  : String
        + PstCd  : String
        + BldgNb  : String
        + StrtNm  : String
        + AdrLine  : global::System.Collections.Generic.List~String~
        + AdrTp  : String
    }
    class ISO20022.Seev033001.PriceFormat77Choice {
        + AmtPric  : ISO20022.Seev033001.AmountPrice3
        + PctgPric  : ISO20022.Seev033001.PercentagePrice2
    }
    ISO20022.Seev033001.PriceFormat77Choice *-- ISO20022.Seev033001.AmountPrice3
    ISO20022.Seev033001.PriceFormat77Choice *-- ISO20022.Seev033001.PercentagePrice2
    class ISO20022.Seev033001.PriceFormat78Choice {
        + IndxPts  : Decimal
        + AmtPricPerAmt  : ISO20022.Seev033001.AmountPricePerAmount2
        + AmtPricPerFinInstrmQty  : ISO20022.Seev033001.AmountPricePerFinancialInstrumentQuantity10
        + NotSpcfdPric  : String
        + AmtPric  : ISO20022.Seev033001.AmountPrice3
        + PctgPric  : ISO20022.Seev033001.PercentagePrice2
    }
    ISO20022.Seev033001.PriceFormat78Choice *-- ISO20022.Seev033001.AmountPricePerAmount2
    ISO20022.Seev033001.PriceFormat78Choice *-- ISO20022.Seev033001.AmountPricePerFinancialInstrumentQuantity10
    ISO20022.Seev033001.PriceFormat78Choice *-- ISO20022.Seev033001.AmountPrice3
    ISO20022.Seev033001.PriceFormat78Choice *-- ISO20022.Seev033001.PercentagePrice2
    class ISO20022.Seev033001.PriceRateType3Code {
        YIEL = 1
        PRCT = 2
        PREM = 3
        DISC = 4
    }
    class ISO20022.Seev033001.PriceValueType9Code {
        UKWN = 1
        UNSP = 2
        TBSP = 3
    }
    class ISO20022.Seev033001.ProcessingPosition3Code {
        INFO = 1
        BEFO = 2
        WITH = 3
        AFTE = 4
    }
    class ISO20022.Seev033001.ProcessingPosition7Choice {
        + Prtry  : ISO20022.Seev033001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev033001.ProcessingPosition7Choice *-- ISO20022.Seev033001.GenericIdentification30
    class ISO20022.Seev033001.ProprietaryQuantity7 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
        + ShrtLngPos  : String
    }
    class ISO20022.Seev033001.ProprietaryQuantity8 {
        + SchmeNm  : String
        + Issr  : String
        + QtyTp  : String
        + Qty  : Decimal
    }
    class ISO20022.Seev033001.ProtectInstruction1 {
        + PrtctDt  : DateTime
        + PrtctSfkpgAcct  : String
        + TxId  : String
        + TxTp  : String
    }
    class ISO20022.Seev033001.ProtectTransactionType2Code {
        COVR = 1
        COVP = 2
        PROT = 3
    }
    class ISO20022.Seev033001.Quantity1Code {
        QALL = 1
    }
    class ISO20022.Seev033001.Quantity48Choice {
        + PrtryQty  : ISO20022.Seev033001.ProprietaryQuantity8
        + Qty  : ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Seev033001.Quantity48Choice *-- ISO20022.Seev033001.ProprietaryQuantity8
    ISO20022.Seev033001.Quantity48Choice *-- ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
    class ISO20022.Seev033001.Quantity49Choice {
        + PrtryQty  : ISO20022.Seev033001.ProprietaryQuantity7
        + QtyChc  : ISO20022.Seev033001.Quantity50Choice
    }
    ISO20022.Seev033001.Quantity49Choice *-- ISO20022.Seev033001.ProprietaryQuantity7
    ISO20022.Seev033001.Quantity49Choice *-- ISO20022.Seev033001.Quantity50Choice
    class ISO20022.Seev033001.Quantity50Choice {
        + SgndQty  : ISO20022.Seev033001.SignedQuantityFormat10
        + OrgnlAndCurFaceAmt  : ISO20022.Seev033001.OriginalAndCurrentQuantities6
    }
    ISO20022.Seev033001.Quantity50Choice *-- ISO20022.Seev033001.SignedQuantityFormat10
    ISO20022.Seev033001.Quantity50Choice *-- ISO20022.Seev033001.OriginalAndCurrentQuantities6
    class ISO20022.Seev033001.Quantity52Choice {
        + Qty  : ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
        + OrgnlAndCurFaceAmt  : ISO20022.Seev033001.OriginalAndCurrentQuantities1
        + Cd  : String
    }
    ISO20022.Seev033001.Quantity52Choice *-- ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev033001.Quantity52Choice *-- ISO20022.Seev033001.OriginalAndCurrentQuantities1
    class ISO20022.Seev033001.RateAndAmountFormat55Choice {
        + RateTpAndRate  : ISO20022.Seev033001.RateTypeAndPercentageRate12
        + Amt  : ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev033001.RateAndAmountFormat55Choice *-- ISO20022.Seev033001.RateTypeAndPercentageRate12
    ISO20022.Seev033001.RateAndAmountFormat55Choice *-- ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev033001.RateAndAmountFormat57Choice {
        + Amt  : ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount
        + NotSpcfdRate  : String
        + Rate  : Decimal
    }
    ISO20022.Seev033001.RateAndAmountFormat57Choice *-- ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev033001.RateAndAmountFormat59Choice {
        + Amt  : ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount
        + Rate  : Decimal
    }
    ISO20022.Seev033001.RateAndAmountFormat59Choice *-- ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount
    class ISO20022.Seev033001.RateType42Choice {
        + Prtry  : ISO20022.Seev033001.GenericIdentification30
        + Cd  : String
    }
    ISO20022.Seev033001.RateType42Choice *-- ISO20022.Seev033001.GenericIdentification30
    class ISO20022.Seev033001.RateTypeAndPercentageRate12 {
        + Rate  : Decimal
        + RateTp  : ISO20022.Seev033001.RateType42Choice
    }
    ISO20022.Seev033001.RateTypeAndPercentageRate12 *-- ISO20022.Seev033001.RateType42Choice
    class ISO20022.Seev033001.RateValueType7Code {
        UKWN = 1
    }
    class ISO20022.Seev033001.SafekeepingPlace1Code {
        SHHE = 1
        NCSD = 2
        ICSD = 3
        CUST = 4
    }
    class ISO20022.Seev033001.SafekeepingPlace2Code {
        ALLP = 1
        SHHE = 2
    }
    class ISO20022.Seev033001.SafekeepingPlaceFormat42Choice {
        + Prtry  : ISO20022.Seev033001.GenericIdentification78
        + TpAndId  : ISO20022.Seev033001.SafekeepingPlaceTypeAndIdentification1
        + DgtlLdgrId  : String
        + Ctry  : String
        + Id  : ISO20022.Seev033001.SafekeepingPlaceTypeAndText6
    }
    ISO20022.Seev033001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev033001.GenericIdentification78
    ISO20022.Seev033001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev033001.SafekeepingPlaceTypeAndIdentification1
    ISO20022.Seev033001.SafekeepingPlaceFormat42Choice *-- ISO20022.Seev033001.SafekeepingPlaceTypeAndText6
    class ISO20022.Seev033001.SafekeepingPlaceTypeAndIdentification1 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev033001.SafekeepingPlaceTypeAndText6 {
        + Id  : String
        + SfkpgPlcTp  : String
    }
    class ISO20022.Seev033001.SecuritiesOption79 {
        + AddtlRndUpQty  : ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
        + InstdQty  : ISO20022.Seev033001.Quantity52Choice
        + CondlQty  : ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
    }
    ISO20022.Seev033001.SecuritiesOption79 *-- ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
    ISO20022.Seev033001.SecuritiesOption79 *-- ISO20022.Seev033001.Quantity52Choice
    ISO20022.Seev033001.SecuritiesOption79 *-- ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
    class ISO20022.Seev033001.SecuritiesQuantityOrAmount6Choice {
        + InstdAmt  : ISO20022.Seev033001.ActiveCurrencyAndAmount
        + SctiesQty  : ISO20022.Seev033001.SecuritiesOption79
    }
    ISO20022.Seev033001.SecuritiesQuantityOrAmount6Choice *-- ISO20022.Seev033001.ActiveCurrencyAndAmount
    ISO20022.Seev033001.SecuritiesQuantityOrAmount6Choice *-- ISO20022.Seev033001.SecuritiesOption79
    class ISO20022.Seev033001.SecurityIdentification19 {
        + Desc  : String
        + OthrId  : global::System.Collections.Generic.List~ISO20022.Seev033001.OtherIdentification1~
        + ISIN  : String
    }
    ISO20022.Seev033001.SecurityIdentification19 *-- ISO20022.Seev033001.OtherIdentification1
    class ISO20022.Seev033001.ShortLong1Code {
        LONG = 1
        SHOR = 2
    }
    class ISO20022.Seev033001.SignedQuantityFormat10 {
        + Qty  : ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev033001.SignedQuantityFormat10 *-- ISO20022.Seev033001.FinancialInstrumentQuantity33Choice
    class ISO20022.Seev033001.SignedQuantityFormat11 {
        + QtyChc  : ISO20022.Seev033001.Quantity48Choice
        + ShrtLngPos  : String
    }
    ISO20022.Seev033001.SignedQuantityFormat11 *-- ISO20022.Seev033001.Quantity48Choice
    class ISO20022.Seev033001.SupplementaryData1 {
        + Envlp  : ISO20022.Seev033001.SupplementaryDataEnvelope1
        + PlcAndNm  : String
    }
    ISO20022.Seev033001.SupplementaryData1 *-- ISO20022.Seev033001.SupplementaryDataEnvelope1
    class ISO20022.Seev033001.SupplementaryDataEnvelope1 {
    }
    class ISO20022.Seev033001.TypeOfIdentification1Code {
        TXID = 1
        FIIN = 2
        DRLC = 3
        CORP = 4
        CHTY = 5
        CCPT = 6
        ARNU = 7
    }
    class ISO20022.Seev033001.WithholdingTaxRateType1Code {
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

## Value ISO20022.Seev033001.AccountAndBalance61


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Bal|ISO20022.Seev033001.CorporateActionBalanceDetails42||XmlElement()||
|+|SfkpgPlc|ISO20022.Seev033001.SafekeepingPlaceFormat42Choice||XmlElement()||
|+|AcctOwnr|ISO20022.Seev033001.PartyIdentification127Choice||XmlElement()||
|+|BlckChainAdrOrWllt|String||XmlElement()||
|+|SfkpgAcct|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Bal),validElement(SfkpgPlc),validElement(AcctOwnr))|

---

## Value ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Value ISO20022.Seev033001.ActiveCurrencyAndAmount


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Decimal||XmlElement()||
|+|Ccy|String||XmlAttribute()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validRequired("""Value""",Value),validRequired("""Ccy""",Ccy),validPattern("""Ccy""",Ccy,"""[A-Z]{3,3}"""))|

---

## Enum ISO20022.Seev033001.AddressType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DLVY|Int32||XmlEnum("""DLVY""")|1|
||MLTO|Int32||XmlEnum("""MLTO""")|2|
||BIZZ|Int32||XmlEnum("""BIZZ""")|3|
||HOME|Int32||XmlEnum("""HOME""")|4|
||PBOX|Int32||XmlEnum("""PBOX""")|5|
||ADDR|Int32||XmlEnum("""ADDR""")|6|

---

## Value ISO20022.Seev033001.AlternatePartyIdentification7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|IdTp|ISO20022.Seev033001.IdentificationType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(IdTp))|

---

## Value ISO20022.Seev033001.AmountPrice3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PricVal))|

---

## Value ISO20022.Seev033001.AmountPricePerAmount2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|PricVal|ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validElement(PricVal))|

---

## Value ISO20022.Seev033001.AmountPricePerFinancialInstrumentQuantity10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|FinInstrmQty|ISO20022.Seev033001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|PricVal|ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|AmtPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(FinInstrmQty),validElement(PricVal))|

---

## Enum ISO20022.Seev033001.AmountPriceType1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||PREM|Int32||XmlEnum("""PREM""")|1|
||PLOT|Int32||XmlEnum("""PLOT""")|2|
||DISC|Int32||XmlEnum("""DISC""")|3|
||ACTU|Int32||XmlEnum("""ACTU""")|4|

---

## Value ISO20022.Seev033001.BalanceFormat11Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|NotElgblBal|ISO20022.Seev033001.SignedQuantityFormat10||XmlElement()||
|+|ElgblBal|ISO20022.Seev033001.SignedQuantityFormat10||XmlElement()||
|+|Bal|ISO20022.Seev033001.SignedQuantityFormat11||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(NotElgblBal),validElement(ElgblBal),validElement(Bal),validChoice(NotElgblBal,ElgblBal,Bal))|

---

## Value ISO20022.Seev033001.BeneficiaryCertificationType10Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev033001.BeneficiaryCertificationType5Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||QIBB|Int32||XmlEnum("""QIBB""")|1|
||NCOM|Int32||XmlEnum("""NCOM""")|2|
||ACCI|Int32||XmlEnum("""ACCI""")|3|

---

## Value ISO20022.Seev033001.ClassificationType32Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AltrnClssfctn|ISO20022.Seev033001.GenericIdentification36||XmlElement()||
|+|ClssfctnFinInstrm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AltrnClssfctn),validPattern("""ClssfctnFinInstrm""",ClssfctnFinInstrm,"""[A-Z]{6,6}"""),validChoice(AltrnClssfctn,ClssfctnFinInstrm))|

---

## Value ISO20022.Seev033001.CorporateActionBalanceDetails42


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RegdBal|ISO20022.Seev033001.BalanceFormat11Choice||XmlElement()||
|+|InTrnsShipmntBal|ISO20022.Seev033001.BalanceFormat11Choice||XmlElement()||
|+|TradDtPosBal|ISO20022.Seev033001.BalanceFormat11Choice||XmlElement()||
|+|StrtPosBal|ISO20022.Seev033001.BalanceFormat11Choice||XmlElement()||
|+|SttlmPosBal|ISO20022.Seev033001.BalanceFormat11Choice||XmlElement()||
|+|OutForRegnBal|ISO20022.Seev033001.BalanceFormat11Choice||XmlElement()||
|+|PdgRctBal|global::System.Collections.Generic.List<ISO20022.Seev033001.BalanceFormat11Choice>||XmlElement()||
|+|PdgDlvryBal|global::System.Collections.Generic.List<ISO20022.Seev033001.BalanceFormat11Choice>||XmlElement()||
|+|OnLnBal|ISO20022.Seev033001.BalanceFormat11Choice||XmlElement()||
|+|CollOutBal|ISO20022.Seev033001.BalanceFormat11Choice||XmlElement()||
|+|CollInBal|ISO20022.Seev033001.BalanceFormat11Choice||XmlElement()||
|+|BrrwdBal|ISO20022.Seev033001.BalanceFormat11Choice||XmlElement()||
|+|BlckdBal|ISO20022.Seev033001.BalanceFormat11Choice||XmlElement()||
|+|TtlElgblBal|ISO20022.Seev033001.Quantity49Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RegdBal),validElement(InTrnsShipmntBal),validElement(TradDtPosBal),validElement(StrtPosBal),validElement(SttlmPosBal),validElement(OutForRegnBal),validList("""PdgRctBal""",PdgRctBal),validElement(PdgRctBal),validList("""PdgDlvryBal""",PdgDlvryBal),validElement(PdgDlvryBal),validElement(OnLnBal),validElement(CollOutBal),validElement(CollInBal),validElement(BrrwdBal),validElement(BlckdBal),validElement(TtlElgblBal))|

---

## Enum ISO20022.Seev033001.CorporateActionChangeType2Code


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

## Value ISO20022.Seev033001.CorporateActionChangeTypeFormat6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033001.CorporateActionEventReference3


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev033001.ProcessingPosition7Choice||XmlElement()||
|+|EvtId|ISO20022.Seev033001.CorporateActionEventReference3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(EvtId))|

---

## Value ISO20022.Seev033001.CorporateActionEventReference3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkdCorpActnId|String||XmlElement()||
|+|LkdOffclCorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(LkdCorpActnId,LkdOffclCorpActnEvtId))|

---

## Value ISO20022.Seev033001.CorporateActionEventType112Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Enum ISO20022.Seev033001.CorporateActionEventType40Code


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

## Value ISO20022.Seev033001.CorporateActionGeneralInformation180


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|UndrlygScty|ISO20022.Seev033001.FinancialInstrumentAttributes132||XmlElement()||
|+|EvtTp|ISO20022.Seev033001.CorporateActionEventType112Choice||XmlElement()||
|+|OffclCorpActnEvtId|String||XmlElement()||
|+|CorpActnEvtId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(UndrlygScty),validElement(EvtTp))|

---

## Aspect ISO20022.Seev033001.CorporateActionInstructionV13


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SplmtryData|global::System.Collections.Generic.List<ISO20022.Seev033001.SupplementaryData1>||XmlElement()||
|+|AddtlInf|ISO20022.Seev033001.CorporateActionNarrative30||XmlElement()||
|+|PrtctInstr|ISO20022.Seev033001.ProtectInstruction1||XmlElement()||
|+|CorpActnInstr|ISO20022.Seev033001.CorporateActionOption237||XmlElement()||
|+|BnfclOwnrDtls|global::System.Collections.Generic.List<ISO20022.Seev033001.PartyIdentification313>||XmlElement()||
|+|AcctDtls|ISO20022.Seev033001.AccountAndBalance61||XmlElement()||
|+|CorpActnGnlInf|ISO20022.Seev033001.CorporateActionGeneralInformation180||XmlElement()||
|+|EvtsLkg|global::System.Collections.Generic.List<ISO20022.Seev033001.CorporateActionEventReference3>||XmlElement()||
|+|OthrDocId|global::System.Collections.Generic.List<ISO20022.Seev033001.DocumentIdentification32>||XmlElement()||
|+|InstrCxlReqId|ISO20022.Seev033001.DocumentIdentification31||XmlElement()||
|+|CancInstrId|ISO20022.Seev033001.DocumentIdentification31||XmlElement()||
|+|ChngInstrInd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""SplmtryData""",SplmtryData),validElement(SplmtryData),validElement(AddtlInf),validElement(PrtctInstr),validElement(CorpActnInstr),validList("""BnfclOwnrDtls""",BnfclOwnrDtls),validElement(BnfclOwnrDtls),validElement(AcctDtls),validElement(CorpActnGnlInf),validList("""EvtsLkg""",EvtsLkg),validElement(EvtsLkg),validList("""OthrDocId""",OthrDocId),validElement(OthrDocId),validElement(InstrCxlReqId),validElement(CancInstrId))|

---

## Value ISO20022.Seev033001.CorporateActionNarrative30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertfctnBrkdwn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|PtyCtctNrrtv|global::System.Collections.Generic.List<String>||XmlElement()||
|+|RegnDtls|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev033001.CorporateActionNarrative32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstrAddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|FXInstrsAddtlInf|global::System.Collections.Generic.List<String>||XmlElement()||
|+|DlvryDtls|global::System.Collections.Generic.List<String>||XmlElement()||
|+|InfToCmplyWth|global::System.Collections.Generic.List<String>||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev033001.CorporateActionOption16Code


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

## Value ISO20022.Seev033001.CorporateActionOption237


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlInf|ISO20022.Seev033001.CorporateActionNarrative32||XmlElement()||
|+|ShrhldrNb|String||XmlElement()||
|+|PricDtls|ISO20022.Seev033001.CorporateActionPrice88||XmlElement()||
|+|RateAndAmtDtls|ISO20022.Seev033001.CorporateActionRate127||XmlElement()||
|+|ExctnReqdDtTm|ISO20022.Seev033001.DateAndDateTime2Choice||XmlElement()||
|+|SctiesQtyOrInstdAmt|ISO20022.Seev033001.SecuritiesQuantityOrAmount6Choice||XmlElement()||
|+|SctyId|ISO20022.Seev033001.SecurityIdentification19||XmlElement()||
|+|CcyOptn|String||XmlElement()||
|+|CcyToSell|String||XmlElement()||
|+|CcyToBuy|String||XmlElement()||
|+|SlctnDealrFeeInd|String||XmlElement()||
|+|ElgblForCollInd|String||XmlElement()||
|+|ChngTp|global::System.Collections.Generic.List<ISO20022.Seev033001.CorporateActionChangeTypeFormat6Choice>||XmlElement()||
|+|FrctnDspstn|ISO20022.Seev033001.FractionDispositionType28Choice||XmlElement()||
|+|OptnFeatrs|ISO20022.Seev033001.OptionFeaturesFormat25Choice||XmlElement()||
|+|OptnTp|ISO20022.Seev033001.CorporateActionOption40Choice||XmlElement()||
|+|OptnNb|ISO20022.Seev033001.OptionNumber1Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlInf),validElement(PricDtls),validElement(RateAndAmtDtls),validElement(ExctnReqdDtTm),validElement(SctiesQtyOrInstdAmt),validElement(SctyId),validPattern("""CcyOptn""",CcyOptn,"""[A-Z]{3,3}"""),validPattern("""CcyToSell""",CcyToSell,"""[A-Z]{3,3}"""),validPattern("""CcyToBuy""",CcyToBuy,"""[A-Z]{3,3}"""),validList("""ChngTp""",ChngTp),validElement(ChngTp),validElement(FrctnDspstn),validElement(OptnFeatrs),validElement(OptnTp),validElement(OptnNb))|

---

## Value ISO20022.Seev033001.CorporateActionOption40Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033001.CorporateActionPrice88


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|GncCshPricPdPerPdct|ISO20022.Seev033001.PriceFormat77Choice||XmlElement()||
|+|GncCshPricRcvdPerPdct|ISO20022.Seev033001.PriceFormat78Choice||XmlElement()||
|+|IssePric|ISO20022.Seev033001.PriceFormat77Choice||XmlElement()||
|+|IndctvOrMktPric|ISO20022.Seev033001.IndicativeOrMarketPrice13Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(GncCshPricPdPerPdct),validElement(GncCshPricRcvdPerPdct),validElement(IssePric),validElement(IndctvOrMktPric))|

---

## Value ISO20022.Seev033001.CorporateActionRate127


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ReqdScndLvlTaxRate|global::System.Collections.Generic.List<ISO20022.Seev033001.RateAndAmountFormat55Choice>||XmlElement()||
|+|ReqdWhldgTaxRate|global::System.Collections.Generic.List<ISO20022.Seev033001.RateAndAmountFormat55Choice>||XmlElement()||
|+|OvrsbcptRate|ISO20022.Seev033001.RateAndAmountFormat59Choice||XmlElement()||
|+|PropsdRate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""ReqdScndLvlTaxRate""",ReqdScndLvlTaxRate),validElement(ReqdScndLvlTaxRate),validList("""ReqdWhldgTaxRate""",ReqdWhldgTaxRate),validElement(ReqdWhldgTaxRate),validElement(OvrsbcptRate))|

---

## Value ISO20022.Seev033001.DateAndDateTime2Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DtTm|DateTime||XmlElement()||
|+|Dt|DateTime||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DtTm,Dt))|

---

## Type ISO20022.Seev033001.Document


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CorpActnInstr|ISO20022.Seev033001.CorporateActionInstructionV13||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CorpActnInstr))|

---

## Value ISO20022.Seev033001.DocumentIdentification31


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev033001.ProcessingPosition7Choice||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp))|

---

## Value ISO20022.Seev033001.DocumentIdentification32


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|LkgTp|ISO20022.Seev033001.ProcessingPosition7Choice||XmlElement()||
|+|DocNb|ISO20022.Seev033001.DocumentNumber5Choice||XmlElement()||
|+|Id|ISO20022.Seev033001.DocumentIdentification3Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(LkgTp),validElement(DocNb),validElement(Id))|

---

## Value ISO20022.Seev033001.DocumentIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AcctOwnrDocId|String||XmlElement()||
|+|AcctSvcrDocId|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(AcctOwnrDocId,AcctSvcrDocId))|

---

## Value ISO20022.Seev033001.DocumentNumber5Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryNb|ISO20022.Seev033001.GenericIdentification36||XmlElement()||
|+|LngNb|String||XmlElement()||
|+|ShrtNb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryNb),validPattern("""LngNb""",LngNb,"""[a-z]{4}\.[0-9]{3}\.[0-9]{3}\.[0-9]{2}"""),validPattern("""ShrtNb""",ShrtNb,"""[0-9]{3}"""),validChoice(PrtryNb,LngNb,ShrtNb))|

---

## Value ISO20022.Seev033001.FinancialInstrumentAttributes132


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CtrctSz|ISO20022.Seev033001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|MinNmnlQty|ISO20022.Seev033001.FinancialInstrumentQuantity33Choice||XmlElement()||
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
|+|ClssfctnTp|ISO20022.Seev033001.ClassificationType32Choice||XmlElement()||
|+|DayCntBsis|ISO20022.Seev033001.InterestComputationMethodFormat4Choice||XmlElement()||
|+|PlcOfListg|ISO20022.Seev033001.MarketIdentification3Choice||XmlElement()||
|+|FinInstrmId|ISO20022.Seev033001.SecurityIdentification19||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(CtrctSz),validElement(MinNmnlQty),validPattern("""DnmtnCcy""",DnmtnCcy,"""[A-Z]{3,3}"""),validElement(ClssfctnTp),validElement(DayCntBsis),validElement(PlcOfListg),validElement(FinInstrmId))|

---

## Value ISO20022.Seev033001.FinancialInstrumentQuantity33Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|DgtlTknUnit|Decimal||XmlElement()||
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|Unit|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(DgtlTknUnit,AmtsdVal,FaceAmt,Unit))|

---

## Enum ISO20022.Seev033001.FractionDispositionType10Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||DIST|Int32||XmlEnum("""DIST""")|1|
||EXPI|Int32||XmlEnum("""EXPI""")|2|
||CINL|Int32||XmlEnum("""CINL""")|3|
||BUYU|Int32||XmlEnum("""BUYU""")|4|

---

## Value ISO20022.Seev033001.FractionDispositionType28Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033001.GenericIdentification30


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev033001.GenericIdentification36


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev033001.GenericIdentification78


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|Tp|ISO20022.Seev033001.GenericIdentification30||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev033001.IdentificationSource3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|String||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033001.IdentificationType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033001.IndicativeOrMarketPrice13Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MktPric|ISO20022.Seev033001.PriceFormat77Choice||XmlElement()||
|+|IndctvPric|ISO20022.Seev033001.PriceFormat77Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(MktPric),validElement(IndctvPric),validChoice(MktPric,IndctvPric))|

---

## Enum ISO20022.Seev033001.InterestComputationMethod2Code


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

## Value ISO20022.Seev033001.InterestComputationMethodFormat4Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033001.MarketIdentification3Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|MktIdrCd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""MktIdrCd""",MktIdrCd,"""[A-Z0-9]{4,4}"""),validChoice(Desc,MktIdrCd))|

---

## Value ISO20022.Seev033001.NameAndAddress5


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Adr|ISO20022.Seev033001.PostalAddress1||XmlElement()||
|+|Nm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Adr))|

---

## Enum ISO20022.Seev033001.OptionFeatures12Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||OPLF|Int32||XmlEnum("""OPLF""")|1|

---

## Value ISO20022.Seev033001.OptionFeaturesFormat25Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033001.OptionNumber1Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Cd|String||XmlElement()||
|+|Nb|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Nb""",Nb,"""[0-9]{3}"""),validChoice(Cd,Nb))|

---

## Enum ISO20022.Seev033001.OptionNumber1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UNSO|Int32||XmlEnum("""UNSO""")|1|

---

## Value ISO20022.Seev033001.OriginalAndCurrentQuantities1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev033001.OriginalAndCurrentQuantities6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtsdVal|Decimal||XmlElement()||
|+|FaceAmt|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev033001.OtherIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Tp|ISO20022.Seev033001.IdentificationSource3Choice||XmlElement()||
|+|Sfx|String||XmlElement()||
|+|Id|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Tp))|

---

## Value ISO20022.Seev033001.PartyIdentification127Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryId|ISO20022.Seev033001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(PrtryId,AnyBIC))|

---

## Value ISO20022.Seev033001.PartyIdentification229Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndvOwnrId|ISO20022.Seev033001.AlternatePartyIdentification7||XmlElement()||
|+|NmAndAdr|ISO20022.Seev033001.NameAndAddress5||XmlElement()||
|+|PrtryId|ISO20022.Seev033001.GenericIdentification36||XmlElement()||
|+|AnyBIC|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(IndvOwnrId),validElement(NmAndAdr),validElement(PrtryId),validPattern("""AnyBIC""",AnyBIC,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""),validChoice(IndvOwnrId,NmAndAdr,PrtryId,AnyBIC))|

---

## Value ISO20022.Seev033001.PartyIdentification313


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|CertfctnBrkdwn|global::System.Collections.Generic.List<String>||XmlElement()||
|+|WhldgTaxRate|ISO20022.Seev033001.RateAndAmountFormat57Choice||XmlElement()||
|+|CertfctnTp|global::System.Collections.Generic.List<ISO20022.Seev033001.BeneficiaryCertificationType10Choice>||XmlElement()||
|+|OwndSctiesQty|ISO20022.Seev033001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|NonDmclCtry|global::System.Collections.Generic.List<String>||XmlElement()||
|+|DmclCtry|String||XmlElement()||
|+|AltrnId|global::System.Collections.Generic.List<ISO20022.Seev033001.AlternatePartyIdentification7>||XmlElement()||
|+|LEIId|String||XmlElement()||
|+|OwnrId|ISO20022.Seev033001.PartyIdentification229Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(WhldgTaxRate),validList("""CertfctnTp""",CertfctnTp),validElement(CertfctnTp),validElement(OwndSctiesQty),validPattern("""NonDmclCtry""",NonDmclCtry,"""[A-Z]{2,2}"""),validPattern("""DmclCtry""",DmclCtry,"""[A-Z]{2,2}"""),validList("""AltrnId""",AltrnId),validElement(AltrnId),validPattern("""LEIId""",LEIId,"""[A-Z0-9]{18,18}[0-9]{2,2}"""),validElement(OwnrId))|

---

## Value ISO20022.Seev033001.PercentagePrice2


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PricVal|Decimal||XmlElement()||
|+|PctgPricTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev033001.PostalAddress1


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

## Value ISO20022.Seev033001.PriceFormat77Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AmtPric|ISO20022.Seev033001.AmountPrice3||XmlElement()||
|+|PctgPric|ISO20022.Seev033001.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPric),validElement(PctgPric),validChoice(AmtPric,PctgPric))|

---

## Value ISO20022.Seev033001.PriceFormat78Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|IndxPts|Decimal||XmlElement()||
|+|AmtPricPerAmt|ISO20022.Seev033001.AmountPricePerAmount2||XmlElement()||
|+|AmtPricPerFinInstrmQty|ISO20022.Seev033001.AmountPricePerFinancialInstrumentQuantity10||XmlElement()||
|+|NotSpcfdPric|String||XmlElement()||
|+|AmtPric|ISO20022.Seev033001.AmountPrice3||XmlElement()||
|+|PctgPric|ISO20022.Seev033001.PercentagePrice2||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AmtPricPerAmt),validElement(AmtPricPerFinInstrmQty),validElement(AmtPric),validElement(PctgPric),validChoice(IndxPts,AmtPricPerAmt,AmtPricPerFinInstrmQty,NotSpcfdPric,AmtPric,PctgPric))|

---

## Enum ISO20022.Seev033001.PriceRateType3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||YIEL|Int32||XmlEnum("""YIEL""")|1|
||PRCT|Int32||XmlEnum("""PRCT""")|2|
||PREM|Int32||XmlEnum("""PREM""")|3|
||DISC|Int32||XmlEnum("""DISC""")|4|

---

## Enum ISO20022.Seev033001.PriceValueType9Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|
||UNSP|Int32||XmlEnum("""UNSP""")|2|
||TBSP|Int32||XmlEnum("""TBSP""")|3|

---

## Enum ISO20022.Seev033001.ProcessingPosition3Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||INFO|Int32||XmlEnum("""INFO""")|1|
||BEFO|Int32||XmlEnum("""BEFO""")|2|
||WITH|Int32||XmlEnum("""WITH""")|3|
||AFTE|Int32||XmlEnum("""AFTE""")|4|

---

## Value ISO20022.Seev033001.ProcessingPosition7Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033001.ProprietaryQuantity7


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev033001.ProprietaryQuantity8


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SchmeNm|String||XmlElement()||
|+|Issr|String||XmlElement()||
|+|QtyTp|String||XmlElement()||
|+|Qty|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""QtyTp""",QtyTp,"""[a-zA-Z0-9]{4}"""))|

---

## Value ISO20022.Seev033001.ProtectInstruction1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtctDt|DateTime||XmlElement()||
|+|PrtctSfkpgAcct|String||XmlElement()||
|+|TxId|String||XmlElement()||
|+|TxTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev033001.ProtectTransactionType2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||COVR|Int32||XmlEnum("""COVR""")|1|
||COVP|Int32||XmlEnum("""COVP""")|2|
||PROT|Int32||XmlEnum("""PROT""")|3|

---

## Enum ISO20022.Seev033001.Quantity1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||QALL|Int32||XmlEnum("""QALL""")|1|

---

## Value ISO20022.Seev033001.Quantity48Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev033001.ProprietaryQuantity8||XmlElement()||
|+|Qty|ISO20022.Seev033001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(Qty),validChoice(PrtryQty,Qty))|

---

## Value ISO20022.Seev033001.Quantity49Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|PrtryQty|ISO20022.Seev033001.ProprietaryQuantity7||XmlElement()||
|+|QtyChc|ISO20022.Seev033001.Quantity50Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(PrtryQty),validElement(QtyChc),validChoice(PrtryQty,QtyChc))|

---

## Value ISO20022.Seev033001.Quantity50Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|SgndQty|ISO20022.Seev033001.SignedQuantityFormat10||XmlElement()||
|+|OrgnlAndCurFaceAmt|ISO20022.Seev033001.OriginalAndCurrentQuantities6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(SgndQty),validElement(OrgnlAndCurFaceAmt),validChoice(SgndQty,OrgnlAndCurFaceAmt))|

---

## Value ISO20022.Seev033001.Quantity52Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Seev033001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|OrgnlAndCurFaceAmt|ISO20022.Seev033001.OriginalAndCurrentQuantities1||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty),validElement(OrgnlAndCurFaceAmt),validChoice(Qty,OrgnlAndCurFaceAmt,Cd))|

---

## Value ISO20022.Seev033001.RateAndAmountFormat55Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|RateTpAndRate|ISO20022.Seev033001.RateTypeAndPercentageRate12||XmlElement()||
|+|Amt|ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTpAndRate),validElement(Amt),validChoice(RateTpAndRate,Amt,Rate))|

---

## Value ISO20022.Seev033001.RateAndAmountFormat57Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|NotSpcfdRate|String||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,NotSpcfdRate,Rate))|

---

## Value ISO20022.Seev033001.RateAndAmountFormat59Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Amt|ISO20022.Seev033001.ActiveCurrencyAnd13DecimalAmount||XmlElement()||
|+|Rate|Decimal||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Amt),validChoice(Amt,Rate))|

---

## Value ISO20022.Seev033001.RateType42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033001.GenericIdentification30||XmlElement()||
|+|Cd|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validChoice(Prtry,Cd))|

---

## Value ISO20022.Seev033001.RateTypeAndPercentageRate12


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Rate|Decimal||XmlElement()||
|+|RateTp|ISO20022.Seev033001.RateType42Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(RateTp))|

---

## Enum ISO20022.Seev033001.RateValueType7Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||UKWN|Int32||XmlEnum("""UKWN""")|1|

---

## Enum ISO20022.Seev033001.SafekeepingPlace1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||SHHE|Int32||XmlEnum("""SHHE""")|1|
||NCSD|Int32||XmlEnum("""NCSD""")|2|
||ICSD|Int32||XmlEnum("""ICSD""")|3|
||CUST|Int32||XmlEnum("""CUST""")|4|

---

## Enum ISO20022.Seev033001.SafekeepingPlace2Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||ALLP|Int32||XmlEnum("""ALLP""")|1|
||SHHE|Int32||XmlEnum("""SHHE""")|2|

---

## Value ISO20022.Seev033001.SafekeepingPlaceFormat42Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Prtry|ISO20022.Seev033001.GenericIdentification78||XmlElement()||
|+|TpAndId|ISO20022.Seev033001.SafekeepingPlaceTypeAndIdentification1||XmlElement()||
|+|DgtlLdgrId|String||XmlElement()||
|+|Ctry|String||XmlElement()||
|+|Id|ISO20022.Seev033001.SafekeepingPlaceTypeAndText6||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Prtry),validElement(TpAndId),validPattern("""DgtlLdgrId""",DgtlLdgrId,"""[1-9B-DF-HJ-NP-TV-XZ][0-9B-DF-HJ-NP-TV-XZ]{8,8}"""),validPattern("""Ctry""",Ctry,"""[A-Z]{2,2}"""),validElement(Id),validChoice(Prtry,TpAndId,DgtlLdgrId,Ctry,Id))|

---

## Value ISO20022.Seev033001.SafekeepingPlaceTypeAndIdentification1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validPattern("""Id""",Id,"""[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}"""))|

---

## Value ISO20022.Seev033001.SafekeepingPlaceTypeAndText6


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Id|String||XmlElement()||
|+|SfkpgPlcTp|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Value ISO20022.Seev033001.SecuritiesOption79


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|AddtlRndUpQty|ISO20022.Seev033001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|InstdQty|ISO20022.Seev033001.Quantity52Choice||XmlElement()||
|+|CondlQty|ISO20022.Seev033001.FinancialInstrumentQuantity33Choice||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(AddtlRndUpQty),validElement(InstdQty),validElement(CondlQty))|

---

## Value ISO20022.Seev033001.SecuritiesQuantityOrAmount6Choice


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|InstdAmt|ISO20022.Seev033001.ActiveCurrencyAndAmount||XmlElement()||
|+|SctiesQty|ISO20022.Seev033001.SecuritiesOption79||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(InstdAmt),validElement(SctiesQty),validChoice(InstdAmt,SctiesQty))|

---

## Value ISO20022.Seev033001.SecurityIdentification19


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Desc|String||XmlElement()||
|+|OthrId|global::System.Collections.Generic.List<ISO20022.Seev033001.OtherIdentification1>||XmlElement()||
|+|ISIN|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validList("""OthrId""",OthrId),validElement(OthrId),validPattern("""ISIN""",ISIN,"""[A-Z]{2,2}[A-Z0-9]{9,9}[0-9]{1,1}"""))|

---

## Enum ISO20022.Seev033001.ShortLong1Code


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||LONG|Int32||XmlEnum("""LONG""")|1|
||SHOR|Int32||XmlEnum("""SHOR""")|2|

---

## Value ISO20022.Seev033001.SignedQuantityFormat10


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Qty|ISO20022.Seev033001.FinancialInstrumentQuantity33Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Qty))|

---

## Value ISO20022.Seev033001.SignedQuantityFormat11


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|QtyChc|ISO20022.Seev033001.Quantity48Choice||XmlElement()||
|+|ShrtLngPos|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(QtyChc))|

---

## Value ISO20022.Seev033001.SupplementaryData1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Envlp|ISO20022.Seev033001.SupplementaryDataEnvelope1||XmlElement()||
|+|PlcAndNm|String||XmlElement()||
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|validation(validElement(Envlp))|

---

## Value ISO20022.Seev033001.SupplementaryDataEnvelope1


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Validation|Some(String)||XmlIgnore(), JsonIgnore()|""|

---

## Enum ISO20022.Seev033001.TypeOfIdentification1Code


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

## Enum ISO20022.Seev033001.WithholdingTaxRateType1Code


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

